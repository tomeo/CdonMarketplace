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
    [System.Xml.Serialization.XmlTypeAttribute("specification", Namespace="https://schemas.cdon.com/product/4.0/4.12.0/product")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class Specification
    {
        
        [System.Xml.Serialization.XmlElementAttribute("header")]
        public CdonMarketplace.Product.LanguageString Header { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.Generic.List<SpecificationRow> _rows;
        
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlArrayAttribute("rows")]
        [System.Xml.Serialization.XmlArrayItemAttribute("row", Namespace="https://schemas.cdon.com/product/4.0/4.12.0/product")]
        public System.Collections.Generic.List<SpecificationRow> Rows
        {
            get
            {
                return this._rows;
            }
            set
            {
                this._rows = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="Specification" /> class.</para>
        /// </summary>
        public Specification()
        {
            this._rows = new System.Collections.Generic.List<SpecificationRow>();
        }
    }
}