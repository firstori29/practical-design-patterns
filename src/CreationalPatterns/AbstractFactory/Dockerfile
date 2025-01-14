FROM mcr.microsoft.com/dotnet/runtime:9.0 AS base
USER $APP_UID
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src

COPY ["Directory.Packages.props", "./"]
COPY ["Directory.Build.props", "./"]

COPY ["src/CreationalPatterns/AbstractFactory/AbstractFactory.csproj", "src/CreationalPatterns/AbstractFactory/"]
RUN dotnet restore "src/CreationalPatterns/AbstractFactory/AbstractFactory.csproj"
COPY . .
WORKDIR "/src/src/CreationalPatterns/AbstractFactory"
RUN dotnet build "AbstractFactory.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "AbstractFactory.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "AbstractFactory.dll"]
