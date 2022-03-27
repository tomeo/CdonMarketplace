//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// This code was generated by XmlSchemaClassGenerator version 2.0.521.0.
namespace CdonMarketplace.Availability
{
    
    
    /// <summary>
    /// <para>If selling digital products or services, set stock to a very high number (less than 1000000) to not run out of sellable products.</para>
    /// </summary>
    [System.ComponentModel.DescriptionAttribute("If selling digital products or services, set stock to a very high number (less th" +
        "an 1000000) to not run out of sellable products.")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.521.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("product", Namespace="https://schemas.cdon.com/product/4.0/4.12.0/availability")]
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
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("status")]
        public Status StatusValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the Status property is specified.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool StatusValueSpecified { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public System.Nullable<Status> Status
        {
            get
            {
                if (this.StatusValueSpecified)
                {
                    return this.StatusValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.StatusValue = value.GetValueOrDefault();
                this.StatusValueSpecified = value.HasValue;
            }
        }
        
        /// <summary>
        /// <para xml:lang="en">Minimum inclusive value: 0.</para>
        /// </summary>
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("stock")]
        public int Stock { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("se")]
        public MarketSE Se { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("dk")]
        public MarketDK Dk { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("no")]
        public MarketNO No { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("fi")]
        public MarketFI Fi { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("b2b_se")]
        public MarketB2BSE B2B_Se { get; set; }
    }
}
