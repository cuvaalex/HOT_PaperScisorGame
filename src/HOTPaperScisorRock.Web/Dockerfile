FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER $APP_UID
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["src/HOTPaperScisorRock.Web/HOTPaperScisorRock.Web.csproj", "src/HOTPaperScisorRock.Web/"]
RUN dotnet restore "src/HOTPaperScisorRock.Web/HOTPaperScisorRock.Web.csproj"
COPY . .
WORKDIR "/src/src/HOTPaperScisorRock.Web"
RUN dotnet build "HOTPaperScisorRock.Web.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "HOTPaperScisorRock.Web.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "HOTPaperScisorRock.Web.dll"]
