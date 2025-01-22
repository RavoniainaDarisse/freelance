# Utiliser l'image officielle de .NET
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 80

# Utiliser l'image SDK pour la construction du projet
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["./freelance.csproj", "freelance/"]
RUN dotnet restore "freelance/freelance.csproj"
COPY . .
WORKDIR "/src/freelance"
RUN dotnet build "freelance.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "freelance.csproj" -c Release -o /app/publish

# Finaliser l'image avec les fichiers publiés
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "freelance.dll"]
