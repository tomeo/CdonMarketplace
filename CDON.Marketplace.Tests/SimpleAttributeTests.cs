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
            var usps = string.Join("\n", "usp1", "usp2", "usp3");
            var attributes = new[]
            {
                new SimpleAttribute
                {
                    Id = "DESCRIPTION",
                    Values = new[]
                    {
                        new SimpleAttributeValue("en", "Line1<br><br>Line2", true)
                    }
                },
                new SimpleAttribute
                {
                    Id = "UniqueSellingPoint",
                    Values = new[]
                    {
                        new SimpleAttributeValue("en", usps),
                    }
                }
            };
            var serializer = new XmlSerializer(typeof(SimpleAttribute[]));
            var writer = new StringWriter();
            serializer.Serialize(writer, attributes);
            var output = writer.ToString();
            Assert.Equal(
                "<?xml version=\"1.0\" encoding=\"utf-16\"?>\r\n<ArrayOfSimpleAttribute xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <SimpleAttribute id=\"DESCRIPTION\">\r\n    <value lang=\"en\"><![CDATA[Line1<br><br>Line2]]></value>\r\n  </SimpleAttribute>\r\n  <SimpleAttribute id=\"UniqueSellingPoint\">\r\n    <value lang=\"en\">usp1\nusp2\nusp3</value>\r\n  </SimpleAttribute>\r\n</ArrayOfSimpleAttribute>",
                output);
        }
    }
}
