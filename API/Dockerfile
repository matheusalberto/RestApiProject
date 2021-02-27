#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0-buster-slim AS build
WORKDIR /src
COPY ["API/RestApiProject.API.csproj", "API/"]
COPY ["RestApiProject.Infrastructure/RestApiProject.Infrastructure.csproj", "RestApiProject.Infrastructure/"]
COPY ["RestApiProject.Domain.Services/RestApiProject.Domain.Services.csproj", "RestApiProject.Domain.Services/"]
COPY ["RestApiProject.Domain.Core/RestApiProject.Domain.Core.csproj", "RestApiProject.Domain.Core/"]
COPY ["RestApiProject.Domain/RestApiProject.Domain.csproj", "RestApiProject.Domain/"]
COPY ["Application/RestApiProject.Application.csproj", "Application/"]
RUN dotnet restore "API/RestApiProject.API.csproj"
COPY . .
WORKDIR "/src/API"
RUN dotnet build "RestApiProject.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "RestApiProject.API.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "RestApiProject.API.dll"]
