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
    [System.Xml.Serialization.XmlTypeAttribute("product", Namespace="https://schemas.cdon.com/product/4.0/4.12.2/media")]
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
        
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("images")]
        public Images Images { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("videos")]
        public Videos Videos { get; set; }
    }
}
