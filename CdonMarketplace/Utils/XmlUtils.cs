using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace CdonMarketplace.Utils
{
    public static class XmlUtils
    {
        public static string SerializeXml<T>(T subject)
        {
            using var sw = new Utf8StringWriter();
            using var xw = new SameNamespaceXmlWriter(sw);

            new XmlSerializer(typeof(T)).Serialize(xw, subject);

            return sw.ToString();
        }

        private class SameNamespaceXmlWriter : XmlTextWriter
        {
            private string _namespace;
            private bool _start = true;

            public SameNamespaceXmlWriter(TextWriter output)
                : base(output)
            {
                Formatting = Formatting.None;
            }

            public override void WriteStartElement(string prefix, string localName, string ns)
            {
                if (_start)
                {
                    _start = false;
                    _namespace = ns;
                }

                base.WriteStartElement(prefix, localName, _namespace);
            }
        }

        private class Utf8StringWriter : StringWriter
        {
            public override Encoding Encoding => Encoding.UTF8;
        }
    }
}