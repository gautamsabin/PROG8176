FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build-env

WORKDIR /Assignment2

# Copy everything
COPY . ./

# Restore as distinct layers
RUN dotnet restore

RUN dotnet build

# Build and publish a release
RUN dotnet publish -c Release -o out

# Build runtime image
FROM mcr.microsoft.com/dotnet/aspnet:7.0
WORKDIR /Assignment2

# Copy the published application from the build stage
COPY --from=build-env /Assignment2/out .

# Expose port 80 inside the container (for informational purposes)
EXPOSE 80

# Entry point for the container to run your application
ENTRYPOINT ["dotnet", "Assignment2.dll"]