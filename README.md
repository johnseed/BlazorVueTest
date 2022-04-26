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