//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// This code was generated by XmlSchemaClassGenerator version 2.0.521.0.
namespace CdonMarketplace.Product
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.521.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("dimensions", Namespace="https://schemas.cdon.com/product/4.0/4.9.0/product")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class Dimensions
    {
        
        [System.Xml.Serialization.XmlElementAttribute("height")]
        public Size Height { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("width")]
        public Size Width { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("length")]
        public Size Length { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("weight")]
        public Mass Weight { get; set; }
    }
}