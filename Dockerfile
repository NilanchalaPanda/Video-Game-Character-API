# Stage 1: Build
FROM mcr.microsoft.com/dotnet/sdk:10.0-preview AS build
WORKDIR /app

# Copy csproj and restore dependencies
COPY *.csproj ./
RUN dotnet restore

# Copy everything else and build
COPY . ./
RUN dotnet publish -c Release -o out

# Stage 2: Runtime
FROM mcr.microsoft.com/dotnet/aspnet:10.0-preview
WORKDIR /app

# Copy build output
COPY --from=build /app/out .

# Expose port
EXPOSE 8080

# Start the app
ENTRYPOINT ["dotnet", "VideoGameCharacterAPI.dll"]