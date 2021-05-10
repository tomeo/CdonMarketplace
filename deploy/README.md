# Deploy package to Nuget.org

1. Make sure the version in csproj is correct
2. Run from project root:
```
docker build . --build-arg API_KEY=<API_KEY>
```