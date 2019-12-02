using System.IO;
using System.Text;

namespace CDON.Marketplace
{
    public class UTF8StringWriter : StringWriter
    {
        public override Encoding Encoding => Encoding.UTF8;
    }
}