# Build stage
FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
WORKDIR /src

# Copy project files
COPY ["ReelsCommerceSystem.Api/ReelsCommerceSystem.Api.csproj", "ReelsCommerceSystem.Api/"]
COPY ["ReelsCommerceSystem.Application/ReelsCommerceSystem.Application.csproj", "ReelsCommerceSystem.Application/"]
COPY ["ReelsCommerceSystem.Domain/ReelsCommerceSystem.Domain.csproj", "ReelsCommerceSystem.Domain/"]
COPY ["ReelsCommerceSystem.Shared/ReelsCommerceSystem.Shared.csproj", "ReelsCommerceSystem.Shared/"]
COPY ["Infrastructure.Infrastructure/ReelsCommerceSystem.Infrastructure.csproj", "Infrastructure.Infrastructure/"]

# Restore dependencies
RUN dotnet restore "ReelsCommerceSystem.Api/ReelsCommerceSystem.Api.csproj"

# Copy source code
COPY . .

# Build the application
RUN dotnet build "ReelsCommerceSystem.Api/ReelsCommerceSystem.Api.csproj" -c Release -o /app/build

# Publish stage
FROM build AS publish
RUN dotnet publish "ReelsCommerceSystem.Api/ReelsCommerceSystem.Api.csproj" -c Release -o /app/publish /p:UseAppHost=false

# Runtime stage
FROM mcr.microsoft.com/dotnet/aspnet:9.0 AS runtime
WORKDIR /app

# Install curl for health check
RUN apt-get update && apt-get install -y --no-install-recommends curl && rm -rf /var/lib/apt/lists/*

# Copy published application
COPY --from=publish /app/publish .

# Expose port
EXPOSE 8080

# Health check
HEALTHCHECK --interval=30s --timeout=10s --start-period=5s --retries=3 \
    CMD curl -f http://localhost:8080/health/live || exit 1

# Set environment
#ENV ASPNETCORE_URLS=http://+:8080
#ENV ASPNETCORE_ENVIRONMENT=Staging

# Start application
ENTRYPOINT ["dotnet", "ReelsCommerceSystem.Api.dll"]
