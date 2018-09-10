using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Portal.Infraestrutura
{
    public static class Utilidades
    {

        public static string ConverterParthParaNomeAssembly(string path)
        {
            // /Assets/css/styles.css
            // /Assets/js/main.js

            var prefixoAssembly = "ByteBank.Portal";
            var pathComPontos = path.Replace('/', '.');

            var nomeCompleto = $"{prefixoAssembly}.{pathComPontos}";

            return nomeCompleto;
        }
            
    }
}
