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
    [System.Xml.Serialization.XmlTypeAttribute("variants", Namespace="https://schemas.cdon.com/product/4.0/4.12.2/product")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class Variants
    {
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.Generic.List<VariantBySize> _variantBySize;
        
        [System.Xml.Serialization.XmlElementAttribute("variantBySize")]
        public System.Collections.Generic.List<VariantBySize> VariantBySize
        {
            get
            {
                return this._variantBySize;
            }
            set
            {
                this._variantBySize = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the VariantBySize collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool VariantBySizeSpecified
        {
            get
            {
                return (this.VariantBySize?.Count != 0);
            }
        }
        
        /// <summary>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="Variants" /> class.</para>
        /// </summary>
        public Variants()
        {
            this._variantBySize = new System.Collections.Generic.List<VariantBySize>();
            this._variantByColor = new System.Collections.Generic.List<VariantByColor>();
            this._variantByFlavor = new System.Collections.Generic.List<VariantByFlavor>();
            this._variantBySizeColor = new System.Collections.Generic.List<VariantBySizeColor>();
            this._variantBySizeFlavor = new System.Collections.Generic.List<VariantBySizeFlavor>();
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.Generic.List<VariantByColor> _variantByColor;
        
        [System.Xml.Serialization.XmlElementAttribute("variantByColor")]
        public System.Collections.Generic.List<VariantByColor> VariantByColor
        {
            get
            {
                return this._variantByColor;
            }
            set
            {
                this._variantByColor = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the VariantByColor collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool VariantByColorSpecified
        {
            get
            {
                return (this.VariantByColor?.Count != 0);
            }
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.Generic.List<VariantByFlavor> _variantByFlavor;
        
        [System.Xml.Serialization.XmlElementAttribute("variantByFlavor")]
        public System.Collections.Generic.List<VariantByFlavor> VariantByFlavor
        {
            get
            {
                return this._variantByFlavor;
            }
            set
            {
                this._variantByFlavor = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the VariantByFlavor collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool VariantByFlavorSpecified
        {
            get
            {
                return (this.VariantByFlavor?.Count != 0);
            }
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.Generic.List<VariantBySizeColor> _variantBySizeColor;
        
        [System.Xml.Serialization.XmlElementAttribute("variantBySizeColor")]
        public System.Collections.Generic.List<VariantBySizeColor> VariantBySizeColor
        {
            get
            {
                return this._variantBySizeColor;
            }
            set
            {
                this._variantBySizeColor = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the VariantBySizeColor collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool VariantBySizeColorSpecified
        {
            get
            {
                return (this.VariantBySizeColor?.Count != 0);
            }
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.Generic.List<VariantBySizeFlavor> _variantBySizeFlavor;
        
        [System.Xml.Serialization.XmlElementAttribute("variantBySizeFlavor")]
        public System.Collections.Generic.List<VariantBySizeFlavor> VariantBySizeFlavor
        {
            get
            {
                return this._variantBySizeFlavor;
            }
            set
            {
                this._variantBySizeFlavor = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the VariantBySizeFlavor collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool VariantBySizeFlavorSpecified
        {
            get
            {
                return (this.VariantBySizeFlavor?.Count != 0);
            }
        }
    }
}
