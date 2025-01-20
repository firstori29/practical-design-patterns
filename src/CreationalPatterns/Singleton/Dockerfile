FROM mcr.microsoft.com/dotnet/runtime:9.0 AS base
USER $APP_UID
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["src/CreationalPatterns/Singleton/Singleton.csproj", "src/CreationalPatterns/Singleton/"]
RUN dotnet restore "src/CreationalPatterns/Singleton/Singleton.csproj"
COPY . .
WORKDIR "/src/src/CreationalPatterns/Singleton"
RUN dotnet build "Singleton.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "Singleton.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Singleton.dll"]
