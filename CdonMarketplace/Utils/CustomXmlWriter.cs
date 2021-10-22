using System.Collections.Generic;
using System.Xml;

namespace CdonMarketplace.Utils
{
    internal class CustomXmlWriter : XmlWriter
    {
        private readonly XmlWriter _inner;
        private string _namespace;
        private bool _start = true;
        private readonly CDataTracker _cDataTracker;

        public CustomXmlWriter(XmlWriter inner)
        {
            _inner = inner;
            _cDataTracker = new CDataTracker();
        }

        public override void Flush() => _inner.Flush();

        public override string LookupPrefix(string ns) => _inner.LookupPrefix(ns);

        public override void WriteBase64(byte[] buffer, int index, int count) =>
            _inner.WriteBase64(buffer, index, count);

        public override void WriteCData(string text) => _inner.WriteCData(text);

        public override void WriteCharEntity(char ch) => _inner.WriteCharEntity(ch);

        public override void WriteChars(char[] buffer, int index, int count) => _inner.WriteChars(buffer, index, count);

        public override void WriteComment(string text) => _inner.WriteComment(text);

        public override void WriteDocType(string name, string pubid, string sysid, string subset) =>
            _inner.WriteDocType(name, pubid, sysid, subset);

        public override void WriteEndAttribute() => _inner.WriteEndAttribute();

        public override void WriteEndDocument() => _inner.WriteEndDocument();

        public override void WriteEndElement()
        {
            _inner.WriteEndElement();
            _cDataTracker.Pop();
        }

        public override void WriteEntityRef(string name) => _inner.WriteEntityRef(name);

        public override void WriteFullEndElement() => _inner.WriteFullEndElement();

        public override void WriteProcessingInstruction(string name, string text) =>
            _inner.WriteProcessingInstruction(name, text);

        public override void WriteRaw(char[] buffer, int index, int count) => _inner.WriteRaw(buffer, index, count);

        public override void WriteRaw(string data) => _inner.WriteRaw(data);

        public override void WriteStartAttribute(string prefix, string localName, string ns) =>
            _inner.WriteStartAttribute(prefix, localName, ns);

        public override void WriteStartDocument() => _inner.WriteStartDocument();

        public override void WriteStartDocument(bool standalone) => _inner.WriteStartDocument(standalone);

        public override void WriteStartElement(string prefix, string localName, string ns)
        {
	        if (_start)
	        {
		        _start = false;
		        _namespace = ns;
	        }
            _inner.WriteStartElement(prefix, localName, _namespace);
            _cDataTracker.Push(localName);
        }

        public override void WriteString(string text)
        {
            if (_cDataTracker.CdataMode)
                WriteCData(text);
            else
                _inner.WriteString(text);
        }

        public override void WriteSurrogateCharEntity(char lowChar, char highChar) =>
            _inner.WriteSurrogateCharEntity(lowChar, highChar);

        public override void WriteWhitespace(string ws) => _inner.WriteWhitespace(ws);

        public override WriteState WriteState => _inner.WriteState;

        public void AddCDataPath(IEnumerable<string> path) =>
            _cDataTracker.Add(path);
    }
}