FROM mcr.microsoft.com/dotnet/core/sdk:3.0
ARG API_KEY
WORKDIR /app
COPY . .
RUN dotnet build -c Release CDON.Marketplace/CDON.Marketplace.csproj
RUN dotnet pack -c Release --include-source --include-symbols CDON.Marketplace/CDON.Marketplace.csproj --output ../
RUN dotnet nuget push /*.nupkg --source https://api.nuget.org/v3/index.json --api-key ${API_KEY}