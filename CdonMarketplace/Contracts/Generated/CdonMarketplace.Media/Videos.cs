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
    [System.Xml.Serialization.XmlTypeAttribute("videos", Namespace="https://schemas.cdon.com/product/4.0/4.9.0/media")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class Videos
    {
        
        /// <summary>
        /// <para xml:lang="en">Minimum length: 1.</para>
        /// <para xml:lang="en">Maximum length: 20.</para>
        /// </summary>
        [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(20)]
        [System.Xml.Serialization.XmlElementAttribute("youtube")]
        public string Youtube { get; set; }
    }
}
