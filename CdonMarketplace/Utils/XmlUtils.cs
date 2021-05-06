using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace CdonMarketplace.Utils
{
    public static class XmlUtils
    {
        private static readonly XmlWriterSettings WriterSettings =
            new XmlWriterSettings
            {
                CloseOutput = false,
                Encoding = Encoding.UTF8,
                OmitXmlDeclaration = false,
                Indent = false
            };

        public static string SerializeXml<T>(T subject)
        {
            using var sw = new Utf8StringWriter();
            using var xw = XmlWriter.Create(sw, WriterSettings);
            new XmlSerializer(typeof(T)).Serialize(xw, subject);
            return sw.ToString().Replace(" xmlns=\"\"", "");
        }

        public class Utf8StringWriter : StringWriter
        {
            public override Encoding Encoding => Encoding.UTF8;
        }
    }
}