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
    /// <para>Every category has a set of valid attributes.
    ///        Documentation on how to use attributes can be found here: https://connect.marketplace.cdon.com/help/product_data_specification
    ///        APIs to fetch the attributes can be found here: https://cdonexternalapi-prod-apim.developer.azure-api.net/apis</para>
    /// </summary>
    [System.ComponentModel.DescriptionAttribute(@"Every category has a set of valid attributes. Documentation on how to use attributes can be found here: https://connect.marketplace.cdon.com/help/product_data_specification APIs to fetch the attributes can be found here: https://cdonexternalapi-prod-apim.developer.azure-api.net/apis")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.521.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("attributes", Namespace="https://schemas.cdon.com/product/4.0/4.11.1/product")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class Attributes
    {
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.Generic.List<System.Xml.XmlElement> _any;
        
        [System.Xml.Serialization.XmlAnyElementAttribute()]
        public System.Collections.Generic.List<System.Xml.XmlElement> Any
        {
            get
            {
                return this._any;
            }
            set
            {
                this._any = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the Any collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AnySpecified
        {
            get
            {
                return (this.Any.Count != 0);
            }
        }
        
        /// <summary>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="Attributes" /> class.</para>
        /// </summary>
        public Attributes()
        {
            this._any = new System.Collections.Generic.List<System.Xml.XmlElement>();
        }
    }
}
