FROM mcr.microsoft.com/dotnet/runtime:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["TrendyolSOLID/TrendyolSOLID.csproj", "TrendyolSOLID/"]
RUN dotnet restore "TrendyolSOLID/TrendyolSOLID.csproj"
COPY . .
WORKDIR "/src/TrendyolSOLID"
RUN dotnet build "TrendyolSOLID.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "TrendyolSOLID.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "TrendyolSOLID.dll"]
