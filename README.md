# restart-explorer
A small dotnet core global tool for restarting the explorer process on troublesome windows computers.

## Prerequisites
requires dotnet 8 runtime or SDK.

## Installation
There's a couple of ways of installing the tool.

### Via GitHub NuGet source
Unfortunately there's no direct way to supply authentication values to the `--add-source` option when executing `dotnet tool install`.
The proper way of doing this is to add the private feed as a nuget soruce on your machine. Unfortunately that doens't work as expected either as there as issues in the dotnet SDK. As NuGet searches the index of all soruces in parallel it probably fails to find the apckage within the default NuGet repository. This will cause the install to fail. There's a CLI options called `--ignore-failed-sources`but according to this [issue](https://github.com/dotnet/sdk/issues/9555) this doens'øt work as intended in dotnet 8.

### Via GitHub releases
Alongside the Nuget Feed a GitHub [release](https://github.com/LordLyng/restart-explorer/releases) is created. You can download the latest release and isntall it using.

Run the following command
```
dotnet tool install RestartExplorer -g --add-source <path-to-folder-containing-nupkg-file> --ignore-failed-sources
```

## Usage
```
restart-explorer
```