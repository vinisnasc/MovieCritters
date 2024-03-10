#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["src/web/MovieCritters.MVC/MovieCritters.MVC.csproj", "src/web/MovieCritters.MVC/"]
RUN dotnet restore "src/web/MovieCritters.MVC/MovieCritters.MVC.csproj"
COPY . .
WORKDIR "/src/src/web/MovieCritters.MVC"
RUN dotnet build "MovieCritters.MVC.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "MovieCritters.MVC.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MovieCritters.MVC.dll"]