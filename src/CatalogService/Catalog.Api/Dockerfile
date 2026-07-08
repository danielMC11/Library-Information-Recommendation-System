# Stage 1: Build
FROM mcr.microsoft.com/dotnet/sdk:10.0 AS builder

WORKDIR /src

# Copiar todos los archivos de proyecto del CatalogService
COPY ["src/CatalogService/Catalog.Api/Catalog.Api.csproj", "src/CatalogService/Catalog.Api/"]
COPY ["src/CatalogService/Catalog.Application/Catalog.Application.csproj", "src/CatalogService/Catalog.Application/"]
COPY ["src/CatalogService/Catalog.Domain/Catalog.Domain.csproj", "src/CatalogService/Catalog.Domain/"]
COPY ["src/CatalogService/Catalog.Infrastructure/Catalog.Infrastructure.csproj", "src/CatalogService/Catalog.Infrastructure/"]
COPY ["src/Shared/Shared/Shared.csproj", "src/Shared/Shared/"]

# Restaurar dependencias
RUN dotnet restore "src/CatalogService/Catalog.Api/Catalog.Api.csproj"

# Copiar código fuente
COPY ["src/CatalogService/", "src/CatalogService/"]
COPY ["src/Shared/", "src/Shared/"]

# Compilar
RUN dotnet build "src/CatalogService/Catalog.Api/Catalog.Api.csproj" -c Release -o /app/build

# Publicar
RUN dotnet publish "src/CatalogService/Catalog.Api/Catalog.Api.csproj" -c Release -o /app/publish

# Stage 2: Runtime
FROM mcr.microsoft.com/dotnet/aspnet:10.0

WORKDIR /app

# Copiar archivos publicados del build
COPY --from=builder /app/publish .

# Exponer puerto
EXPOSE 5281

# Variables de entorno
ENV ASPNETCORE_HTTP_PORTS=5281
ENV ASPNETCORE_ENVIRONMENT=Production

# Comando de inicio
ENTRYPOINT ["dotnet", "Catalog.Api.dll"]
