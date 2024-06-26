#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 5000

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["MBPortfolio/MBPortfolio.csproj", "MBPortfolio/"]
RUN dotnet restore "MBPortfolio/MBPortfolio.csproj"
COPY . .
WORKDIR "/src/MBPortfolio"
RUN dotnet build "MBPortfolio.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "MBPortfolio.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MBPortfolio.dll"]