//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// This code was generated by XmlSchemaClassGenerator version 2.0.521.0.
namespace CdonMarketplace.Media
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.521.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("identity", Namespace="https://schemas.cdon.com/product/4.0/4.9.0/media")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class Identity
    {
        
        /// <summary>
        /// <para xml:lang="en">Pattern: [a-zA-Z0-9åäöÅÄÖ\s\/_.-]{1,40}.</para>
        /// </summary>
        [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("[a-zA-Z0-9åäöÅÄÖ\\s\\/_.-]{1,40}")]
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("id")]
        public string Id { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Pattern: [0-9]{8}|[0-9]{12,14}.</para>
        /// </summary>
        [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("[0-9]{8}|[0-9]{12,14}")]
        [System.Xml.Serialization.XmlElementAttribute("gtin")]
        public string Gtin { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Minimum length: 1.</para>
        /// <para xml:lang="en">Maximum length: 50.</para>
        /// </summary>
        [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(50)]
        [System.Xml.Serialization.XmlElementAttribute("mpn")]
        public string Mpn { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Minimum length: 1.</para>
        /// <para xml:lang="en">Maximum length: 50.</para>
        /// </summary>
        [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(50)]
        [System.Xml.Serialization.XmlElementAttribute("sku")]
        public string Sku { get; set; }
    }
}
