namespace CdonMarketplace.Product
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.521.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("description", Namespace = "https://schemas.cdon.com/product/4.0/4.9.0/product")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class Description
    {

        /// <summary>
        /// <para xml:lang="en">Minimum length: 1.</para>
        /// <para xml:lang="en">Maximum length: 10000.</para>
        /// </summary>
        [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(10000)]
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("default")]
        public CData Default { get; set; }

        /// <summary>
        /// <para xml:lang="en">Minimum length: 1.</para>
        /// <para xml:lang="en">Maximum length: 10000.</para>
        /// </summary>
        [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(10000)]
        [System.Xml.Serialization.XmlElementAttribute("se")]
        public CData Se { get; set; }

        /// <summary>
        /// <para xml:lang="en">Minimum length: 1.</para>
        /// <para xml:lang="en">Maximum length: 10000.</para>
        /// </summary>
        [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(10000)]
        [System.Xml.Serialization.XmlElementAttribute("dk")]
        public CData Dk { get; set; }

        /// <summary>
        /// <para xml:lang="en">Minimum length: 1.</para>
        /// <para xml:lang="en">Maximum length: 10000.</para>
        /// </summary>
        [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(10000)]
        [System.Xml.Serialization.XmlElementAttribute("no")]
        public CData No { get; set; }

        /// <summary>
        /// <para xml:lang="en">Minimum length: 1.</para>
        /// <para xml:lang="en">Maximum length: 10000.</para>
        /// </summary>
        [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(10000)]
        [System.Xml.Serialization.XmlElementAttribute("fi")]
        public CData Fi { get; set; }

        /// <summary>
        /// <para xml:lang="en">Minimum length: 1.</para>
        /// <para xml:lang="en">Maximum length: 10000.</para>
        /// </summary>
        [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(10000)]
        [System.Xml.Serialization.XmlElementAttribute("fr")]
        public CData Fr { get; set; }
    }
}
