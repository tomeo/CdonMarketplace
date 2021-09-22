FROM mcr.microsoft.com/dotnet/core/sdk:3.0
ARG API_KEY
WORKDIR /app
COPY . .
RUN dotnet build -c Release CdonMarketplace/CdonMarketplace.csproj
RUN dotnet pack -c Release --include-source --include-symbols CdonMarketplace/CdonMarketplace.csproj --output ../
RUN dotnet nuget push /*.nupkg --source https://api.nuget.org/v3/index.json --api-key ${API_KEY}