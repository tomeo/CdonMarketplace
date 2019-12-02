using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace CDON.Marketplace
{
    public static class XMLUtils
    {
        private static readonly XmlWriterSettings WriterSettings =
            new XmlWriterSettings
            {
                CloseOutput = false,
                Encoding = Encoding.UTF8,
                OmitXmlDeclaration = false,
                Indent = false
            };

        public static string SerializeXML<T>(T subject)
        {
            using var sw = new UTF8StringWriter();
            using var xw = XmlWriter.Create(sw, WriterSettings);
            new XmlSerializer(typeof(T)).Serialize(xw, subject);
            return sw.ToString().Replace(" xmlns=\"\"", "");
        }
    }
}