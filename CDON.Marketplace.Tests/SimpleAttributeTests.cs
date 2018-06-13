using System.IO;
using System.Xml.Serialization;
using CDON.Marketplace.Contracts;
using Xunit;

namespace CDON.Marketplace.Tests
{
    public class SimpleAttributeTests
    {
        [Fact]
        public void ShouldSerializeSimpleAttributeValueTextAsCData()
        {
            var value = new SimpleAttributeValue
            {
                Lang = "en",
                Text = "Line1<br><br>Line2"
            };
            var serializer = new XmlSerializer(typeof(SimpleAttributeValue));
            var writer = new StringWriter();
            serializer.Serialize(writer, value);
            var output = writer.ToString();
            Assert.Equal(
                "<?xml version=\"1.0\" encoding=\"utf-16\"?>\r\n<SimpleAttributeValue xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\" lang=\"en\">\r\n  <Text><![CDATA[Line1<br><br>Line2]]></Text>\r\n</SimpleAttributeValue>",
                output);
        }
    }
}
