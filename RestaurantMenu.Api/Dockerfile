FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["RestaurantMenu.Api/RestaurantMenu.Api.csproj", "RestaurantMenu.Api/"]
RUN dotnet restore "RestaurantMenu.Api/RestaurantMenu.Api.csproj"
COPY . .
WORKDIR "/src/RestaurantMenu.Api"
RUN dotnet build "RestaurantMenu.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "RestaurantMenu.Api.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "RestaurantMenu.Api.dll"]
