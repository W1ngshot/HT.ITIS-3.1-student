FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 5000

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY Dotnet.Homeworks.Mailing.API/Dotnet.Homeworks.Mailing.API.csproj Dotnet.Homeworks.Mailing.API/
RUN dotnet restore Dotnet.Homeworks.Mailing.API

COPY . .
WORKDIR /src/Dotnet.Homeworks.Mailing.API
RUN dotnet build Dotnet.Homeworks.Mailing.API.csproj -c Release -o /app/build

FROM build AS publish
RUN dotnet publish Dotnet.Homeworks.Mailing.API.csproj -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Dotnet.Homeworks.Mailing.API.dll"]