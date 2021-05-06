//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// This code was generated by XmlSchemaClassGenerator version 2.0.521.0.
namespace CdonMarketplace.Price
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.521.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("marketSE", Namespace="https://schemas.cdon.com/product/4.0/4.9.0/price")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class MarketSE : Market
    {
        
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("shippingCost")]
        public MarketSEShippingCost ShippingCost { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Total number of digits in fraction: 2.</para>
        /// <para xml:lang="en">Minimum inclusive value: 0.</para>
        /// <para xml:lang="en">Maximum inclusive value: 100.</para>
        /// </summary>
        [System.ComponentModel.DataAnnotations.RangeAttribute(typeof(decimal), "0", "100")]
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("vat")]
        public decimal Vat { get; set; }
    }
    
    /// <summary>
    /// <para>Please see the documentation regarding valid values for the "shippingCost"- and "vat"-elements.</para>
    /// </summary>
    [System.ComponentModel.DescriptionAttribute("Please see the documentation regarding valid values for the \"shippingCost\"- and \"" +
        "vat\"-elements.")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.521.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("market", Namespace="https://schemas.cdon.com/product/4.0/4.9.0/price")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(MarketB2BSE))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(MarketDK))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(MarketFI))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(MarketNO))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(MarketRakutenFr))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(MarketSE))]
    public abstract partial class Market
    {
        
        /// <summary>
        /// <para>Amount includes VAT</para>
        /// <para xml:lang="en">Total number of digits in fraction: 2.</para>
        /// <para xml:lang="en">Minimum inclusive value: 0.</para>
        /// <para xml:lang="en">Maximum inclusive value: 1000000.</para>
        /// </summary>
        [System.ComponentModel.DataAnnotations.RangeAttribute(typeof(decimal), "0", "1000000")]
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("salePrice")]
        public decimal SalePrice { get; set; }
        
        /// <summary>
        /// <para>Amount includes VAT</para>
        /// <para xml:lang="en">Total number of digits in fraction: 2.</para>
        /// <para xml:lang="en">Minimum inclusive value: 0.</para>
        /// <para xml:lang="en">Maximum inclusive value: 1000000.</para>
        /// </summary>
        [System.ComponentModel.DataAnnotations.RangeAttribute(typeof(decimal), "0", "1000000")]
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("originalPrice")]
        public decimal OriginalPrice { get; set; }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.521.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("MarketSEShippingCost", Namespace="https://schemas.cdon.com/product/4.0/4.9.0/price", AnonymousType=true)]
    public enum MarketSEShippingCost
    {
        
        [System.Xml.Serialization.XmlEnumAttribute("0")]
        Item0,
        
        [System.Xml.Serialization.XmlEnumAttribute("19")]
        Item19,
        
        [System.Xml.Serialization.XmlEnumAttribute("29")]
        Item29,
        
        [System.Xml.Serialization.XmlEnumAttribute("39")]
        Item39,
        
        [System.Xml.Serialization.XmlEnumAttribute("49")]
        Item49,
        
        [System.Xml.Serialization.XmlEnumAttribute("59")]
        Item59,
        
        [System.Xml.Serialization.XmlEnumAttribute("79")]
        Item79,
        
        [System.Xml.Serialization.XmlEnumAttribute("99")]
        Item99,
        
        [System.Xml.Serialization.XmlEnumAttribute("199")]
        Item199,
        
        [System.Xml.Serialization.XmlEnumAttribute("249")]
        Item249,
        
        [System.Xml.Serialization.XmlEnumAttribute("299")]
        Item299,
        
        [System.Xml.Serialization.XmlEnumAttribute("395")]
        Item395,
        
        [System.Xml.Serialization.XmlEnumAttribute("495")]
        Item495,
        
        [System.Xml.Serialization.XmlEnumAttribute("499")]
        Item499,
        
        [System.Xml.Serialization.XmlEnumAttribute("995")]
        Item995,
        
        [System.Xml.Serialization.XmlEnumAttribute("1499")]
        Item1499,
        
        [System.Xml.Serialization.XmlEnumAttribute("3499")]
        Item3499,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.521.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("marketDK", Namespace="https://schemas.cdon.com/product/4.0/4.9.0/price")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class MarketDK : Market
    {
        
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("shippingCost")]
        public MarketDKShippingCost ShippingCost { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Total number of digits in fraction: 2.</para>
        /// <para xml:lang="en">Minimum inclusive value: 0.</para>
        /// <para xml:lang="en">Maximum inclusive value: 100.</para>
        /// </summary>
        [System.ComponentModel.DataAnnotations.RangeAttribute(typeof(decimal), "0", "100")]
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("vat")]
        public decimal Vat { get; set; }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.521.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("MarketDKShippingCost", Namespace="https://schemas.cdon.com/product/4.0/4.9.0/price", AnonymousType=true)]
    public enum MarketDKShippingCost
    {
        
        [System.Xml.Serialization.XmlEnumAttribute("0")]
        Item0,
        
        [System.Xml.Serialization.XmlEnumAttribute("19")]
        Item19,
        
        [System.Xml.Serialization.XmlEnumAttribute("29")]
        Item29,
        
        [System.Xml.Serialization.XmlEnumAttribute("39")]
        Item39,
        
        [System.Xml.Serialization.XmlEnumAttribute("49")]
        Item49,
        
        [System.Xml.Serialization.XmlEnumAttribute("59")]
        Item59,
        
        [System.Xml.Serialization.XmlEnumAttribute("79")]
        Item79,
        
        [System.Xml.Serialization.XmlEnumAttribute("99")]
        Item99,
        
        [System.Xml.Serialization.XmlEnumAttribute("199")]
        Item199,
        
        [System.Xml.Serialization.XmlEnumAttribute("299")]
        Item299,
        
        [System.Xml.Serialization.XmlEnumAttribute("495")]
        Item495,
        
        [System.Xml.Serialization.XmlEnumAttribute("995")]
        Item995,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.521.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("marketNO", Namespace="https://schemas.cdon.com/product/4.0/4.9.0/price")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class MarketNO : Market
    {
        
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("shippingCost")]
        public MarketNOShippingCost ShippingCost { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Total number of digits in fraction: 2.</para>
        /// <para xml:lang="en">Minimum inclusive value: 0.</para>
        /// <para xml:lang="en">Maximum inclusive value: 100.</para>
        /// </summary>
        [System.ComponentModel.DataAnnotations.RangeAttribute(typeof(decimal), "0", "100")]
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("vat")]
        public decimal Vat { get; set; }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.521.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("MarketNOShippingCost", Namespace="https://schemas.cdon.com/product/4.0/4.9.0/price", AnonymousType=true)]
    public enum MarketNOShippingCost
    {
        
        [System.Xml.Serialization.XmlEnumAttribute("0")]
        Item0,
        
        [System.Xml.Serialization.XmlEnumAttribute("19")]
        Item19,
        
        [System.Xml.Serialization.XmlEnumAttribute("39")]
        Item39,
        
        [System.Xml.Serialization.XmlEnumAttribute("49")]
        Item49,
        
        [System.Xml.Serialization.XmlEnumAttribute("59")]
        Item59,
        
        [System.Xml.Serialization.XmlEnumAttribute("79")]
        Item79,
        
        [System.Xml.Serialization.XmlEnumAttribute("99")]
        Item99,
        
        [System.Xml.Serialization.XmlEnumAttribute("199")]
        Item199,
        
        [System.Xml.Serialization.XmlEnumAttribute("399")]
        Item399,
        
        [System.Xml.Serialization.XmlEnumAttribute("799")]
        Item799,
        
        [System.Xml.Serialization.XmlEnumAttribute("995")]
        Item995,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.521.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("marketFI", Namespace="https://schemas.cdon.com/product/4.0/4.9.0/price")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class MarketFI : Market
    {
        
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("shippingCost")]
        public MarketFIShippingCost ShippingCost { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Total number of digits in fraction: 2.</para>
        /// <para xml:lang="en">Minimum inclusive value: 0.</para>
        /// <para xml:lang="en">Maximum inclusive value: 100.</para>
        /// </summary>
        [System.ComponentModel.DataAnnotations.RangeAttribute(typeof(decimal), "0", "100")]
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("vat")]
        public decimal Vat { get; set; }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.521.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("MarketFIShippingCost", Namespace="https://schemas.cdon.com/product/4.0/4.9.0/price", AnonymousType=true)]
    public enum MarketFIShippingCost
    {
        
        [System.Xml.Serialization.XmlEnumAttribute("0")]
        Item0,
        
        [System.Xml.Serialization.XmlEnumAttribute("1.95")]
        Item1Period95,
        
        [System.Xml.Serialization.XmlEnumAttribute("2.95")]
        Item2Period95,
        
        [System.Xml.Serialization.XmlEnumAttribute("3.95")]
        Item3Period95,
        
        [System.Xml.Serialization.XmlEnumAttribute("4.90")]
        Item4Period90,
        
        [System.Xml.Serialization.XmlEnumAttribute("4.95")]
        Item4Period95,
        
        [System.Xml.Serialization.XmlEnumAttribute("5.95")]
        Item5Period95,
        
        [System.Xml.Serialization.XmlEnumAttribute("7.95")]
        Item7Period95,
        
        [System.Xml.Serialization.XmlEnumAttribute("9.95")]
        Item9Period95,
        
        [System.Xml.Serialization.XmlEnumAttribute("19.5")]
        Item19Period5,
        
        [System.Xml.Serialization.XmlEnumAttribute("39.5")]
        Item39Period5,
        
        [System.Xml.Serialization.XmlEnumAttribute("59")]
        Item59,
        
        [System.Xml.Serialization.XmlEnumAttribute("79")]
        Item79,
        
        [System.Xml.Serialization.XmlEnumAttribute("99.5")]
        Item99Period5,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.521.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("marketRakutenFr", Namespace="https://schemas.cdon.com/product/4.0/4.9.0/price")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class MarketRakutenFr : Market
    {
        
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("shippingCost")]
        public object ShippingCost { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Total number of digits in fraction: 2.</para>
        /// <para xml:lang="en">Minimum inclusive value: 0.</para>
        /// <para xml:lang="en">Maximum inclusive value: 100.</para>
        /// </summary>
        [System.ComponentModel.DataAnnotations.RangeAttribute(typeof(decimal), "0", "100")]
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("vat")]
        public decimal Vat { get; set; }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.521.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("marketB2BSE", Namespace="https://schemas.cdon.com/product/4.0/4.9.0/price")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class MarketB2BSE : Market
    {
        
        /// <summary>
        /// <para xml:lang="en">Total number of digits in fraction: 2.</para>
        /// <para xml:lang="en">Minimum inclusive value: 0.</para>
        /// <para xml:lang="en">Maximum inclusive value: 100.</para>
        /// </summary>
        [System.ComponentModel.DataAnnotations.RangeAttribute(typeof(decimal), "0", "100")]
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("vat")]
        public decimal Vat { get; set; }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.521.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("product", Namespace="https://schemas.cdon.com/product/4.0/4.9.0/price")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class Product
    {
        
        /// <summary>
        /// <para xml:lang="en">Pattern: [a-zA-Z0-9åäöÅÄÖ\s\/_.-]{1,40}.</para>
        /// </summary>
        [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("[a-zA-Z0-9åäöÅÄÖ\\s\\/_.-]{1,40}")]
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("id")]
        public string Id { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("se")]
        public MarketSE Se { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("dk")]
        public MarketDK Dk { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("no")]
        public MarketNO No { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("fi")]
        public MarketFI Fi { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("rakuten_fr")]
        public MarketRakutenFr Rakuten_Fr { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("b2b_se")]
        public MarketB2BSE B2B_Se { get; set; }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.521.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("marketplace", Namespace="https://schemas.cdon.com/product/4.0/4.9.0/price", AnonymousType=true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute("marketplace", Namespace="https://schemas.cdon.com/product/4.0/4.9.0/price")]
    public partial class Marketplace
    {
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<Product> _product;
        
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("product")]
        public System.Collections.ObjectModel.Collection<Product> Product
        {
            get
            {
                return this._product;
            }
            private set
            {
                this._product = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="Marketplace" /> class.</para>
        /// </summary>
        public Marketplace()
        {
            this._product = new System.Collections.ObjectModel.Collection<Product>();
        }
    }
}
