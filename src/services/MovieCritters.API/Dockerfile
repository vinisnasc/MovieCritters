#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["src/services/MovieCritters.API/MovieCritters.API.csproj", "src/services/MovieCritters.API/"]
COPY ["src/services/MovieCritters.Infrastructure/MovieCritters.Infrastructure.csproj", "src/services/MovieCritters.Infrastructure/"]
COPY ["src/services/MovieCritters.Application/MovieCritters.Application.csproj", "src/services/MovieCritters.Application/"]
COPY ["src/services/MovieCritters.Domain/MovieCritters.Domain.csproj", "src/services/MovieCritters.Domain/"]
RUN dotnet restore "src/services/MovieCritters.API/MovieCritters.API.csproj"
COPY . .
WORKDIR "/src/src/services/MovieCritters.API"
RUN dotnet build "MovieCritters.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "MovieCritters.API.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MovieCritters.API.dll"]