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
    [System.Xml.Serialization.XmlTypeAttribute("product", Namespace="https://schemas.cdon.com/product/4.0/4.9.0/product")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class Product
    {
        
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("identity")]
        public CdonMarketplace.Product.Identity Identity { get; set; }
        
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("title")]
        public Title Title { get; set; }
        
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("description")]
        public Description Description { get; set; }
        
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("category")]
        public Category Category { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Minimum length: 1.</para>
        /// <para xml:lang="en">Maximum length: 70.</para>
        /// </summary>
        [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(70)]
        [System.Xml.Serialization.XmlElementAttribute("brand")]
        public string Brand { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.Generic.List<UspValue> _usp;
        
        [System.Xml.Serialization.XmlArrayAttribute("usp")]
        [System.Xml.Serialization.XmlArrayItemAttribute("value", Namespace="https://schemas.cdon.com/product/4.0/4.9.0/product")]
        public System.Collections.Generic.List<UspValue> Usp
        {
            get
            {
                return this._usp;
            }
            set
            {
                this._usp = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the Usp collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool UspSpecified
        {
            get
            {
                return (this.Usp.Count != 0);
            }
        }
        
        /// <summary>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="Product" /> class.</para>
        /// </summary>
        public Product()
        {
            this._usp = new System.Collections.Generic.List<UspValue>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("energy")]
        public CdonMarketplace.Product.EnergyClassification Energy { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("dimensions")]
        public CdonMarketplace.Product.Dimensions Dimensions { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Minimum exclusive value: 1900-01-01.</para>
        /// <para xml:lang="en">Maximum inclusive value: 2079-06-06.</para>
        /// </summary>
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("releaseDate", DataType="date")]
        public System.DateTime ReleaseDateValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the ReleaseDate property is specified.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool ReleaseDateValueSpecified { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Minimum exclusive value: 1900-01-01.</para>
        /// <para xml:lang="en">Maximum inclusive value: 2079-06-06.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public System.Nullable<System.DateTime> ReleaseDate
        {
            get
            {
                if (this.ReleaseDateValueSpecified)
                {
                    return this.ReleaseDateValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.ReleaseDateValue = value.GetValueOrDefault();
                this.ReleaseDateValueSpecified = value.HasValue;
            }
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("isAdult")]
        public bool IsAdultValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the IsAdult property is specified.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool IsAdultValueSpecified { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public System.Nullable<bool> IsAdult
        {
            get
            {
                if (this.IsAdultValueSpecified)
                {
                    return this.IsAdultValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.IsAdultValue = value.GetValueOrDefault();
                this.IsAdultValueSpecified = value.HasValue;
            }
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("isDrug")]
        public bool IsDrugValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the IsDrug property is specified.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool IsDrugValueSpecified { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public System.Nullable<bool> IsDrug
        {
            get
            {
                if (this.IsDrugValueSpecified)
                {
                    return this.IsDrugValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.IsDrugValue = value.GetValueOrDefault();
                this.IsDrugValueSpecified = value.HasValue;
            }
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("isPreOwned")]
        public bool IsPreOwnedValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the IsPreOwned property is specified.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool IsPreOwnedValueSpecified { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public System.Nullable<bool> IsPreOwned
        {
            get
            {
                if (this.IsPreOwnedValueSpecified)
                {
                    return this.IsPreOwnedValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.IsPreOwnedValue = value.GetValueOrDefault();
                this.IsPreOwnedValueSpecified = value.HasValue;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("variants")]
        public CdonMarketplace.Product.Variants Variants { get; set; }
    }
}