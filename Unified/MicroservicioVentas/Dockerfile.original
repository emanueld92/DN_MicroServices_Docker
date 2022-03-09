#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["MicroservicioVentas.csproj", "."]
COPY ["../MicroservicioVentas.EntityFramework/MicroservicioVentas.EntityFramework.csproj", "../MicroservicioVentas.EntityFramework/"]
COPY ["../MicroservicioVentas.Core/MicroservicioVentas.Core.csproj", "../MicroservicioVentas.Core/"]
COPY ["../MicroservicioVentas.ApplicationServices/MicroservicioVentas.ApplicationServices.csproj", "../MicroservicioVentas.ApplicationServices/"]
RUN dotnet restore "MicroservicioVentas.csproj"
COPY . .
WORKDIR "/src/"
RUN dotnet build "MicroservicioVentas.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "MicroservicioVentas.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MicroservicioVentas.dll"]
