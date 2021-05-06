# CDON Marketplace XSD-files

All XSD-files are available at https://schemas.cdon.com/product/4.0/

## Generate contracts

### Install xscgen
Install [xscgen](https://github.com/mganss/XmlSchemaClassGenerator). There are several ways of installing `xscgen` (see docs). This illustrates how to install it as a dotnet tool:
```
dotnet tool install --global dotnet-xscgen --version 2.0.521
```

### Run generateClasses-script

The version you want to generate is given as a parameter to the script:
```
./generateClasses.sh 4.9.0
```