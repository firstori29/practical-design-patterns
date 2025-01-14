FROM mcr.microsoft.com/dotnet/runtime:9.0 AS base
USER $APP_UID
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src

COPY ["Directory.Packages.props", "./"]
COPY ["Directory.Build.props", "./"]

COPY ["src/CreationalPatterns/FactoryMethod/FactoryMethod.csproj", "src/CreationalPatterns/FactoryMethod/"]
RUN dotnet restore "src/CreationalPatterns/FactoryMethod/FactoryMethod.csproj"
COPY . .
WORKDIR "/src/src/CreationalPatterns/FactoryMethod"
RUN dotnet build "FactoryMethod.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "FactoryMethod.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "FactoryMethod.dll"]
