# Stage 1: Build
FROM mcr.microsoft.com/dotnet/sdk:10.0 AS builder

WORKDIR /src

# Copiar todos los archivos de proyecto del AuthService
COPY ["src/AuthService/MiniIdentityApi.Api/MiniIdentityApi.Api.csproj", "src/AuthService/MiniIdentityApi.Api/"]
COPY ["src/AuthService/MiniIdentityApi.Application/MiniIdentityApi.Application.csproj", "src/AuthService/MiniIdentityApi.Application/"]
COPY ["src/AuthService/MiniIdentityApi.Domain/MiniIdentityApi.Domain.csproj", "src/AuthService/MiniIdentityApi.Domain/"]
COPY ["src/AuthService/MiniIdentityApi.Infrastructure/MiniIdentityApi.Infrastructure.csproj", "src/AuthService/MiniIdentityApi.Infrastructure/"]

# Restaurar dependencias
RUN dotnet restore "src/AuthService/MiniIdentityApi.Api/MiniIdentityApi.Api.csproj"

# Copiar código fuente
COPY ["src/AuthService/", "src/AuthService/"]

# Compilar
RUN dotnet build "src/AuthService/MiniIdentityApi.Api/MiniIdentityApi.Api.csproj" -c Release -o /app/build

# Publicar
RUN dotnet publish "src/AuthService/MiniIdentityApi.Api/MiniIdentityApi.Api.csproj" -c Release -o /app/publish

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
ENTRYPOINT ["dotnet", "MiniIdentityApi.Api.dll"]
