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
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.521.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("market", Namespace="https://schemas.cdon.com/product/4.0/4.12.2/availability")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(MarketB2BSE))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(MarketDK))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(MarketFI))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(MarketNO))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(MarketSE))]
    public abstract partial class Market
    {
        
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("status")]
        public Status Status { get; set; }
    }
}
