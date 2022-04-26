docker run --rm --name dotnet-publish -v  "$(pwd)":/usr/src/ -v /root/.nuget/:/root/.nuget/ -w /usr/src/ mcr.microsoft.com/dotnet/sdk:6.0 dotnet restore --source /root/.nuget/packages/ || exit 1
docker run --rm --name dotnet-publish -v  "$(pwd)":/usr/src/ -v /root/.nuget/:/root/.nuget/ -w /usr/src/ mcr.microsoft.com/dotnet/sdk:6.0 dotnet publish -c Release -o /usr/src/publish --no-restore || exit 1
docker build . -t gda-web-blazor -f Nuget.Dockerfile
rm -rf publish