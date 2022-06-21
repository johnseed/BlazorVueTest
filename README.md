# BlazorVueTest

### dotnet 

```bash
dotnet run
```

### Vue

```bash
npm install
npm run dev
npm run build
```

### Offline Docker build

download nuget packages

    $ docker run --rm --name project -v  "$(pwd)":/usr/src/ -v /root/.nuget/:/root/.nuget/ -w /usr/src/ mcr.microsoft.com/dotnet/sdk:6.0 dotnet publish -c Release -o /usr/src/publish


### Publish

```bash
dotnet publish -c Release -r win-x64
dotnet publish -c Release -r linux-x64 -p:PublishSingleFile=true -p:PublishTrimmed=true
dotnet publish -c Release --no-self-contained -r linux-x64 -p:PublishSingleFile=true
dotnet publish -c Release -r win-x64 --self-contained -p:PublishSingleFile=true -p:PublishTrimmed=true -p:IncludeNativeLibrariesForSelfExtract=true -p:PublishReadyToRun=true -p:PublishReadyToRunComposite=true
dotnet publish -c Release -r osx.11.0-arm64 --no-self-contained -p:PublishSingleFile=true
dotnet publish -c Release -r osx.11.0-arm64 --self-contained -p:PublishSingleFile=true -p:PublishTrimmed=true -p:PublishReadyToRun=true -p:PublishReadyToRunComposite=true
```

### Invoke example
```javascript
await DotNet.invokeMethodAsync('BlazorVueTest', 'Interp', [100, 101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112,
    113, 114, 115, 116, 117, 118, 119], [60, 59, 58, 57, 56, 55, 54, 53, 52, 51, 50, 49, 48, 47, 46, 45, 44,
    43, 42, 41]);  


await DotNet.invokeMethodAsync('BlazorVueTest', 'InterpProgress',
    [
        {
            lon: [100, 101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112,
                113, 114, 115, 116, 117, 118, 119], lat: [60, 59, 58, 57, 56, 55, 54, 53, 52, 51, 50, 49, 48, 47, 46, 45, 44,
                    43, 42, 41]
        },
        {
            lon: [100, 101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112,
                113, 114, 115, 116, 117, 118, 119], lat: [60, 59, 58, 57, 56, 55, 54, 53, 52, 51, 50, 49, 48, 47, 46, 45, 44,
                    43, 42, 41]
        }
    ]
);
```