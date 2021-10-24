using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Serialization;

namespace CdonMarketplace.Utils
{
    internal class CustomXmlSerializer : XmlSerializer
    {
        private readonly Type _type;

        public CustomXmlSerializer(Type type) : base(type)
        {
            _type = type;
        }

        public void Serialize(CustomXmlWriter writer, object o)
        {
            AddCDataProperties(writer);
            base.Serialize(writer, o);
        }

        private void AddCDataProperties(CustomXmlWriter writer)
        {
            var attributes = _type.GetCustomAttributes(typeof(CDataAttribute), true).Cast<CDataAttribute>();
            foreach (var attribute in attributes)
            {
                var path = new List<string> { _type.Name };
                path.AddRange(attribute.Property.Split('.'));
                if (attribute.PropertyType != typeof(string))
                {
                    foreach (var property in
                        attribute.PropertyType.GetProperties()
                            .Where(p => p.PropertyType == typeof(string))
                            .Select(p => p.Name))
                        writer.AddCDataPath(path.Append(property));
                }
                else
                    writer.AddCDataPath(path);
            }
        }
    }
}