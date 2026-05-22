# Stage 1: Build
FROM mcr.microsoft.com/dotnet/sdk:10.0 AS builder

WORKDIR /src

# Copiar todos los archivos de proyecto del InteractionService
COPY ["src/InteractionService/Interaction.Api/Interaction.Api.csproj", "src/InteractionService/Interaction.Api/"]
COPY ["src/InteractionService/Interaction.Application/Interaction.Application.csproj", "src/InteractionService/Interaction.Application/"]
COPY ["src/InteractionService/Interaction.Domain/Interaction.Domain.csproj", "src/InteractionService/Interaction.Domain/"]
COPY ["src/InteractionService/Interaction.Infrastructure/Interaction.Infrastructure.csproj", "src/InteractionService/Interaction.Infrastructure/"]

# Restaurar dependencias
RUN dotnet restore "src/InteractionService/Interaction.Api/Interaction.Api.csproj"

# Copiar código fuente
COPY ["src/InteractionService/", "src/InteractionService/"]

# Compilar
RUN dotnet build "src/InteractionService/Interaction.Api/Interaction.Api.csproj" -c Release -o /app/build

# Publicar
RUN dotnet publish "src/InteractionService/Interaction.Api/Interaction.Api.csproj" -c Release -o /app/publish

# Stage 2: Runtime
FROM mcr.microsoft.com/dotnet/aspnet:10.0

WORKDIR /app

# Copiar archivos publicados del build
COPY --from=builder /app/publish .

# Exponer puerto
EXPOSE 5144

# Variables de entorno
ENV ASPNETCORE_HTTP_PORTS=5144
ENV ASPNETCORE_ENVIRONMENT=Production

# Comando de inicio
ENTRYPOINT ["dotnet", "Interaction.Api.dll"]
