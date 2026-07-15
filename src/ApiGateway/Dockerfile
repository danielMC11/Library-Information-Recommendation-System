# Stage 1: Build
FROM mcr.microsoft.com/dotnet/sdk:10.0 AS builder

WORKDIR /src

# Copy project file
COPY ["src/ApiGateway/ApiGateway.csproj", "src/ApiGateway/"]

# Restore dependencies
RUN dotnet restore "src/ApiGateway/ApiGateway.csproj"

# Copy source code
COPY ["src/ApiGateway/", "src/ApiGateway/"]

# Build
RUN dotnet build "src/ApiGateway/ApiGateway.csproj" -c Release -o /app/build

# Publish
RUN dotnet publish "src/ApiGateway/ApiGateway.csproj" -c Release -o /app/publish

# Stage 2: Runtime
FROM mcr.microsoft.com/dotnet/aspnet:10.0

RUN apt-get update && \
    apt-get install -y curl && \
    rm -rf /var/lib/apt/lists/*

WORKDIR /app

# Copy published output
COPY --from=builder /app/publish .

# Expose port
EXPOSE 5075

# Environment variables
ENV ASPNETCORE_HTTP_PORTS=5075
ENV ASPNETCORE_ENVIRONMENT=Production

# Entry point
ENTRYPOINT ["dotnet", "ApiGateway.dll"]
