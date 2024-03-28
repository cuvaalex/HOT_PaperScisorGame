FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER $APP_UID
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["src/HOT.Assessment.RockPaperScissor.Web/HOT.Assessment.RockPaperScissor.Web.csproj", "src/HOT.Assessment.RockPaperScissor.Web/"]
RUN dotnet restore "src/HOT.Assessment.RockPaperScissor.Web/HOT.Assessment.RockPaperScissor.Web.csproj"
COPY . .
WORKDIR "/src/src/HOT.Assessment.RockPaperScissor.Web"
RUN dotnet build "HOT.Assessment.RockPaperScissor.Web.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "HOT.Assessment.RockPaperScissor.Web.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "HOT.Assessment.RockPaperScissor.Web.dll"]
