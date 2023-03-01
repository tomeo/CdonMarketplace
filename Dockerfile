FROM mcr.microsoft.com/dotnet/sdk:6.0
# ARG API_KEY
ARG GITHUB_ACCESS_TOKEN
WORKDIR /app
COPY . .
RUN dotnet test && dotnet build -c Release CdonMarketplace/CdonMarketplace.csproj
RUN dotnet pack -c Release --include-source --include-symbols CdonMarketplace/CdonMarketplace.csproj --output ../
RUN dotnet nuget push /*.nupkg --api-key ${GITHUB_ACCESS_TOKEN} --source https://nuget.pkg.github.com/tomeo/index.json
# RUN dotnet nuget push /*.nupkg --source https://api.nuget.org/v3/index.json --api-key ${API_KEY}