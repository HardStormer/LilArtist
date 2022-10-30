#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["LilArtist.CA.PL.WebApiLinux/LilArtist.CA.PL.WebApiLinux.csproj", "LilArtist.CA.PL.WebApiLinux/"]
RUN dotnet restore "LilArtist.CA.PL.WebApiLinux/LilArtist.CA.PL.WebApiLinux.csproj"
COPY . .
WORKDIR "/src/LilArtist.CA.PL.WebApiLinux"
RUN dotnet build "LilArtist.CA.PL.WebApiLinux.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "LilArtist.CA.PL.WebApiLinux.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "LilArtist.CA.PL.WebApiLinux.dll"]