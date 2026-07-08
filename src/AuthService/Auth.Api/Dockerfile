# Stage 1: Build
FROM mcr.microsoft.com/dotnet/sdk:10.0 AS builder

WORKDIR /src

# Copiar todos los archivos de proyecto del AuthService
COPY ["src/AuthService/Auth.Api/Auth.Api.csproj", "src/AuthService/Auth.Api/"]
COPY ["src/AuthService/Auth.Application/Auth.Application.csproj", "src/AuthService/Auth.Application/"]
COPY ["src/AuthService/Auth.Domain/Auth.Domain.csproj", "src/AuthService/Auth.Domain/"]
COPY ["src/AuthService/Auth.Infrastructure/Auth.Infrastructure.csproj", "src/AuthService/Auth.Infrastructure/"]
COPY ["src/Shared/Shared/Shared.csproj", "src/Shared/Shared/"]

# Restaurar dependencias
RUN dotnet restore "src/AuthService/Auth.Api/Auth.Api.csproj"

# Copiar código fuente
COPY ["src/AuthService/", "src/AuthService/"]
COPY ["src/Shared/", "src/Shared/"]

# Compilar
RUN dotnet build "src/AuthService/Auth.Api/Auth.Api.csproj" -c Release -o /app/build

# Publicar
RUN dotnet publish "src/AuthService/Auth.Api/Auth.Api.csproj" -c Release -o /app/publish

# Stage 2: Runtime
FROM mcr.microsoft.com/dotnet/aspnet:10.0

WORKDIR /app

# Copiar archivos publicados del build
COPY --from=builder /app/publish .

# Exponer puerto
EXPOSE 5132

# Variables de entorno
ENV ASPNETCORE_HTTP_PORTS=5132
ENV ASPNETCORE_ENVIRONMENT=Production

# Comando de inicio
ENTRYPOINT ["dotnet", "Auth.Api.dll"]
