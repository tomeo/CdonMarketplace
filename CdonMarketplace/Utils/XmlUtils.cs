using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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
            using var xw = new CustomXmlWriter(XmlWriter.Create(sw, WriterSettings));

            new CustomXmlSerializer(typeof(T)).Serialize(xw, subject);

            return sw.ToString();
        }

        public class Utf8StringWriter : StringWriter
        {
            public override Encoding Encoding => Encoding.UTF8;
        }
    }

    internal class CustomXmlSerializer : XmlSerializer
    {
	    private readonly Type _type;

	    public CustomXmlSerializer(Type type) : base(type)
	    {
		    _type = type;
	    }

	    public void Serialize(CustomXmlWriter writer, object o)
	    {
		    var attributes = _type.GetCustomAttributes(typeof(CDataAttribute), true).Cast<CDataAttribute>();
		    foreach (var attribute in attributes)
		    {
			    var path = new List<string> { _type.Name };
			    path.AddRange(attribute.Property.Split('.'));
			    foreach (var property in attribute.PropertyType.GetProperties().Where(p => p.PropertyType == typeof(string)).Select(p => p.Name))
				    writer.AddCDataPath(path.Append(property));

		    }
			base.Serialize(writer, o);
	    }
    }
}