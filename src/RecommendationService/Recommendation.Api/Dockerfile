# Stage 1: Build
FROM mcr.microsoft.com/dotnet/sdk:10.0 AS builder

WORKDIR /src

# Copiar todos los archivos de proyecto del RecommendationService
COPY ["src/RecommendationService/Recommendation.Api/Recommendation.Api.csproj", "src/RecommendationService/Recommendation.Api/"]
COPY ["src/RecommendationService/Recommendation.Application/Recommendation.Application.csproj", "src/RecommendationService/Recommendation.Application/"]
COPY ["src/RecommendationService/Recommendation.Domain/Recommendation.Domain.csproj", "src/RecommendationService/Recommendation.Domain/"]
COPY ["src/RecommendationService/Recommendation.Infrastructure/Recommendation.Infrastructure.csproj", "src/RecommendationService/Recommendation.Infrastructure/"]
COPY ["src/Shared/Shared/Shared.csproj", "src/Shared/Shared/"]

# Restaurar dependencias
RUN dotnet restore "src/RecommendationService/Recommendation.Api/Recommendation.Api.csproj"

# Copiar código fuente
COPY ["src/RecommendationService/", "src/RecommendationService/"]
COPY ["src/Shared/", "src/Shared/"]

# Compilar
RUN dotnet build "src/RecommendationService/Recommendation.Api/Recommendation.Api.csproj" -c Release -o /app/build

# Publicar
RUN dotnet publish "src/RecommendationService/Recommendation.Api/Recommendation.Api.csproj" -c Release -o /app/publish

# Stage 2: Runtime
FROM mcr.microsoft.com/dotnet/aspnet:10.0

WORKDIR /app

# Copiar archivos publicados del build
COPY --from=builder /app/publish .

# Exponer puerto
EXPOSE 5180

# Variables de entorno
ENV ASPNETCORE_HTTP_PORTS=5180
ENV ASPNETCORE_ENVIRONMENT=Production

# Comando de inicio
ENTRYPOINT ["dotnet", "Recommendation.Api.dll"]
