curl -O -sS https://schemas.cdon.com/product/4.0/$1/availability.xsd && \
curl -O -sS https://schemas.cdon.com/product/4.0/$1/dimensions.xsd && \
curl -O -sS https://schemas.cdon.com/product/4.0/$1/energy.xsd && \
curl -O -sS https://schemas.cdon.com/product/4.0/$1/identities.xsd && \
curl -O -sS https://schemas.cdon.com/product/4.0/$1/media.xsd && \
curl -O -sS https://schemas.cdon.com/product/4.0/$1/price.xsd && \
curl -O -sS https://schemas.cdon.com/product/4.0/$1/product.xsd && \
curl -O -sS https://schemas.cdon.com/product/4.0/$1/types.xsd && \
curl -O -sS https://schemas.cdon.com/product/4.0/$1/variants.xsd

OUT=../CdonMarketplace/Contracts/Generated
rm -rf $OUT
mkdir $OUT

xscgen \
    --prefix=CdonMarketplace \
    --namespace "|product.xsd=Product" \
    --namespace "|types.xsd=Product" \
    --namespace "|dimensions.xsd=Product" \
    --namespace "|energy.xsd=Product" \
    --namespace "|variants.xsd=Product" \
    --namespace "|identities.xsd=Product" \
    --pascal \
    --separateFiles \
    --nullable \
    --collectionSettersMode Public \
    --collectionType=System.Collections.Generic.List\`1 \
    --output=$OUT \
    product.xsd

xscgen \
    --prefix=CdonMarketplace \
    --namespace "|price.xsd=Price" \
    --namespace "|types.xsd=Price" \
    --namespace "|identities.xsd=Price" \
    --pascal \
    --separateFiles \
    --nullable \
    --collectionSettersMode Public \
    --collectionType=System.Collections.Generic.List\`1 \
    --output=$OUT \
    price.xsd

xscgen \
    --prefix=CdonMarketplace \
    --namespace "|availability.xsd=Availability" \
    --namespace "|types.xsd=Availability" \
    --namespace "|identities.xsd=Availability" \
    --pascal \
    --separateFiles \
    --collectionSettersMode Public \
    --collectionType=System.Collections.Generic.List\`1 \
    --output=$OUT \
    availability.xsd

xscgen \
    --prefix=CdonMarketplace \
    --namespace "|media.xsd=Media" \
    --namespace "|types.xsd=Media" \
    --namespace "|identities.xsd=Media" \
    --pascal \
    --separateFiles \
    --nullable \
    --collectionSettersMode Public \
    --collectionType=System.Collections.Generic.List\`1 \
    --output=$OUT \
    media.xsd

# Hack to fix CData
cp ./Description.cs $OUT/CdonMarketplace.Product/Description.cs