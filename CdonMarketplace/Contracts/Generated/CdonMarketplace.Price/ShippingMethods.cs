//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// This code was generated by XmlSchemaClassGenerator version 2.0.521.0.
namespace CdonMarketplace.Price
{
    
    
    /// <summary>
    /// <para>[HomeDelivery - Home delivery],
    ///        [PickupPoint - Delivery to pickup point],
    ///        [Mailbox - Delivery to mailbox],
    ///        [Digital - Digital product (E-mail or SMS), no carrier]</para>
    /// </summary>
    [System.ComponentModel.DescriptionAttribute("[HomeDelivery - Home delivery], [PickupPoint - Delivery to pickup point], [Mailbo" +
        "x - Delivery to mailbox], [Digital - Digital product (E-mail or SMS), no carrier" +
        "]")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.521.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("shippingMethods", Namespace="https://schemas.cdon.com/product/4.0/4.12.2/price")]
    public enum ShippingMethods
    {
        
        HomeDelivery,
        
        PickupPoint,
        
        Mailbox,
        
        Digital,
    }
}