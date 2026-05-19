FROM mcr.microsoft.com/dotnet/aspnet:10.0 AS base
USER $APP_UID
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

FROM mcr.microsoft.com/dotnet/sdk:10.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["ValidationExample/ValidationExample.Client/ValidationExample.Client.csproj", "ValidationExample/ValidationExample.Client/"]
RUN dotnet restore "ValidationExample/ValidationExample.Client/ValidationExample.Client.csproj"
COPY . .
WORKDIR "/src/ValidationExample/ValidationExample.Client"
RUN dotnet build "./ValidationExample.Client.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./ValidationExample.Client.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ValidationExample.Client.dll"]
