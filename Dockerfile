# Étape 1: Utilisation de l'image de base .NET SDK pour construire l'application
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /app

# Copiez le fichier .csproj et restaurez les dépendances
COPY ["freelance.csproj", "./"]
RUN dotnet restore "freelance.csproj"

# Copiez le reste du code source
COPY . .

# Construisez l'application en mode Release
RUN dotnet publish "freelance.csproj" -c Release -o /app/publish

# Étape 2: Utilisation de l'image de base ASP.NET pour l'exécution
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 80

# Copiez les fichiers publiés depuis l'étape de build
COPY --from=build /app/publish .

# Commande pour démarrer l'application
ENTRYPOINT ["dotnet", "freelance.dll"]
