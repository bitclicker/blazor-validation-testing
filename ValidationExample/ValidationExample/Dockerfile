FROM mcr.microsoft.com/dotnet/aspnet:10.0 AS base
USER $APP_UID
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

FROM mcr.microsoft.com/dotnet/sdk:10.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["ValidationExample/ValidationExample/ValidationExample.csproj", "ValidationExample/ValidationExample/"]
COPY ["ValidationExample/ValidationExample.Client/ValidationExample.Client.csproj", "ValidationExample/ValidationExample.Client/"]
RUN dotnet restore "ValidationExample/ValidationExample/ValidationExample.csproj"
COPY . .
WORKDIR "/src/ValidationExample/ValidationExample"
RUN dotnet build "./ValidationExample.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./ValidationExample.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ValidationExample.dll"]
