FROM mcr.microsoft.com/dotnet/runtime:9.0 AS base
USER $APP_UID
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["src/BehavioralPatterns/Mediator/Mediator.csproj", "src/BehavioralPatterns/Mediator/"]
RUN dotnet restore "src/BehavioralPatterns/Mediator/Mediator.csproj"
COPY . .
WORKDIR "/src/src/BehavioralPatterns/Mediator"
RUN dotnet build "Mediator.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "Mediator.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Mediator.dll"]
