using System;
using System.IO;
using DesignPatterns2.cap8;

namespace DesignPatterns2
{
    internal class XlmSerializer
    {
        private Type type;

        public XlmSerializer(Type type)
        {
            this.type = type;
        }

        internal void Serialize(StringWriter writer, Cliente cliente)
        {
            throw new NotImplementedException();
        }

        internal void Serialize(StringWriter writer, object o)
        {
            throw new NotImplementedException();
        }
    }
}