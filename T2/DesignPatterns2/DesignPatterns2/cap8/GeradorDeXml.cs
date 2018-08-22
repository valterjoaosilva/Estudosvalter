using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2.cap8
{
    class GeradorDeXml
    {
        public String GeraXml(object o)
        {
            XlmSerializer serializer = new XlmSerializer(o.GetType());
            StringWriter writer = new StringWriter();
            serializer.Serialize(writer, o);
            return writer.ToString();
        }
    }
}
