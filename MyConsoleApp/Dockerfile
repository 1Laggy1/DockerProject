FROM mcr.microsoft.com/dotnet/sdk:7.0-bullseye-slim-amd64 AS build

WORKDIR /app

COPY *.csproj ./

RUN dotnet restore

COPY . ./

RUN dotnet add package Newtonsoft.Json

RUN dotnet publish -c Release -o out

FROM mcr.microsoft.com/dotnet/runtime:7.0-bullseye-slim AS runtime

WORKDIR /app

COPY --from=build /app/out ./

ENTRYPOINT ["dotnet", "MyConsoleApp.dll"]
