FROM microsoft/dotnet:2.0-sdk
WORKDIR /app
COPY . .
RUN dotnet build -c Release CDON.Marketplace/CDON.Marketplace.csproj
RUN dotnet pack -c Release --include-source --include-symbols CDON.Marketplace/CDON.Marketplace.csproj --output ../