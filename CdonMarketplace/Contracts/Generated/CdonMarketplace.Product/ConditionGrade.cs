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
    
    
    /// <summary>
    /// <para>The condition grade of the pre-owned product.
    ///
    ///				Used (like new)
    ///				Excellent condition, but has previously been worn or used. No signs of wear or defect. In original box.
    ///
    ///				Used (very good)
    ///				Very good with minimal or no wear. Or new without original box.
    ///
    ///				Used (good)
    ///				Minor signs of wear. Item is operational and works as intended.
    ///
    ///				Used (fair)
    ///				Some signs of wear and tear or minor defects. Item is still usable as intended.
    ///
    ///				Defective
    ///				The product has been determined defective. See description for more details.</para>
    /// </summary>
    [System.ComponentModel.DescriptionAttribute(@"The condition grade of the pre-owned product. Used (like new) Excellent condition, but has previously been worn or used. No signs of wear or defect. In original box. Used (very good) Very good with minimal or no wear. Or new without original box. Used (good) Minor signs of wear. Item is operational and works as intended. Used (fair) Some signs of wear and tear or minor defects. Item is still usable as intended. Defective The product has been determined defective. See description for more details.")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.521.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("conditionGrade", Namespace="https://schemas.cdon.com/product/4.0/4.12.2/product")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ConditionGrade
    {
        
        [System.Xml.Serialization.XmlElementAttribute("usedLikeNew")]
        public object UsedLikeNew { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("usedVeryGood")]
        public object UsedVeryGood { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("usedGood")]
        public object UsedGood { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("usedFair")]
        public object UsedFair { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("defective")]
        public object Defective { get; set; }
    }
}