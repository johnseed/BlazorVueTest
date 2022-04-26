FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM base AS final
ENV LANG="en_US.UTF-8"
ENV TZ Asia/Shanghai

WORKDIR /app
COPY publish .
ENTRYPOINT ["dotnet", "BlazorVueTest.dll"]