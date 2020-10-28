# CDON Marketplace

## Find xsd.exe
The XML Schema Definition tool (Xsd.exe) usually can be found in the following path:
`C:\Program Files (x86)\Microsoft SDKs\Windows\{version}\bin\NETFX {version} Tools\`

## Generate from XSD
For example
```
xsd /c /n:CDON.Marketplace.Price price.xsd
```

## Build and push package
```
docker build . --build-arg API_KEY=<API_KEY>
```