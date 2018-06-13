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
            var attribute = new SimpleAttribute
            {
                Id = "DESCRIPTION",
                Values = new []
                {
                    new SimpleAttributeValue("en", "Line1<br><br>Line2")
                }
            };
            var serializer = new XmlSerializer(typeof(SimpleAttribute));
            var writer = new StringWriter();
            serializer.Serialize(writer, attribute);
            var output = writer.ToString();
            Assert.Equal(
                "<?xml version=\"1.0\" encoding=\"utf-16\"?>\r\n<SimpleAttribute xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\" id=\"DESCRIPTION\">\r\n  <value lang=\"en\"><![CDATA[Line1<br><br>Line2]]></value>\r\n</SimpleAttribute>",
                output);
        }
    }
}
