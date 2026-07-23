[CmdletBinding()]
param(
    [Parameter(Mandatory)]
    [string] $PackagePath,

    [Parameter(Mandatory)]
    [string] $ExpectedVersion,

    [string] $ExpectedPackageId = 'OpenDisNet'
)

$ErrorActionPreference = 'Stop'
$resolvedPackage = (Resolve-Path -LiteralPath $PackagePath).Path

Add-Type -AssemblyName System.IO.Compression.FileSystem
$archive = [System.IO.Compression.ZipFile]::OpenRead($resolvedPackage)

try {
    $entryNames = @($archive.Entries | ForEach-Object FullName)
    $requiredEntries = @(
        'README.md',
        'opendisnet-icon.png',
        'lib/net9.0/OpenDisNet.dll',
        'lib/net10.0/OpenDisNet.dll'
    )

    foreach ($entry in $requiredEntries) {
        if ($entryNames -cnotcontains $entry) {
            throw "Package is missing required entry '$entry'."
        }
    }

    $nuspecEntry = $archive.Entries |
        Where-Object FullName -Like '*.nuspec' |
        Select-Object -First 1
    if ($null -eq $nuspecEntry) {
        throw 'Package does not contain a .nuspec file.'
    }

    $reader = [System.IO.StreamReader]::new($nuspecEntry.Open())
    try {
        [xml] $nuspec = $reader.ReadToEnd()
    }
    finally {
        $reader.Dispose()
    }

    $metadata = $nuspec.package.metadata
    if ($metadata.id -ne $ExpectedPackageId) {
        throw "Expected package ID '$ExpectedPackageId', found '$($metadata.id)'."
    }

    if ($metadata.version -ne $ExpectedVersion) {
        throw "Expected package version '$ExpectedVersion', found '$($metadata.version)'."
    }

    if ($ExpectedVersion -notmatch '^(\d+)\.(\d+)\.(\d+)(?:-[0-9A-Za-z]+(?:[.-][0-9A-Za-z]+)*)?$') {
        throw "Expected version '$ExpectedVersion' is not a supported semantic version."
    }

    $expectedAssemblyVersion = "$($Matches[1]).$($Matches[2]).$($Matches[3]).0"
    $assemblyEntries = @(
        'lib/net9.0/OpenDisNet.dll',
        'lib/net10.0/OpenDisNet.dll'
    )
    $temporaryDirectory = Join-Path ([System.IO.Path]::GetTempPath()) (
        'opendisnet-package-validation-' + [System.Guid]::NewGuid().ToString('N'))
    [void] [System.IO.Directory]::CreateDirectory($temporaryDirectory)

    try {
        foreach ($entryName in $assemblyEntries) {
            $assemblyEntry = $archive.GetEntry($entryName)
            $temporaryAssembly = Join-Path $temporaryDirectory ($entryName.Replace('/', '_'))
            $sourceStream = $assemblyEntry.Open()
            $destinationStream = [System.IO.File]::Create($temporaryAssembly)

            try {
                $sourceStream.CopyTo($destinationStream)
            }
            finally {
                $destinationStream.Dispose()
                $sourceStream.Dispose()
            }

            $assemblyVersion = [System.Reflection.AssemblyName]::GetAssemblyName(
                $temporaryAssembly).Version.ToString()
            $fileVersion = [System.Diagnostics.FileVersionInfo]::GetVersionInfo(
                $temporaryAssembly)

            if ($assemblyVersion -ne $expectedAssemblyVersion) {
                throw "Expected '$entryName' assembly version '$expectedAssemblyVersion', found '$assemblyVersion'."
            }

            if ($fileVersion.FileVersion -ne $expectedAssemblyVersion) {
                throw "Expected '$entryName' file version '$expectedAssemblyVersion', found '$($fileVersion.FileVersion)'."
            }

            if ($fileVersion.ProductVersion -ne $ExpectedVersion -and
                -not $fileVersion.ProductVersion.StartsWith(
                    "$ExpectedVersion+", [System.StringComparison]::Ordinal)) {
                throw "Expected '$entryName' product version '$ExpectedVersion', found '$($fileVersion.ProductVersion)'."
            }
        }
    }
    finally {
        [System.IO.Directory]::Delete($temporaryDirectory, $true)
    }

    Write-Host "Validated $ExpectedPackageId $ExpectedVersion ($($entryNames.Count) entries)."
}
finally {
    $archive.Dispose()
}
