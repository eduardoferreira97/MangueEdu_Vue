FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER $APP_UID
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Debug
WORKDIR /src
COPY ["Manguedu.Api/Manguedu.Api.csproj", "Manguedu.Api/"]
COPY ["Manguedu.Domain/Manguedu.Domain.csproj", "Manguedu.Domain/"]
RUN dotnet restore "Manguedu.Api/Manguedu.Api.csproj"
COPY . .
WORKDIR "/src/Manguedu.Api"
RUN dotnet build "Manguedu.Api.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Debug
RUN dotnet publish "Manguedu.Api.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Manguedu.Api.dll"]
