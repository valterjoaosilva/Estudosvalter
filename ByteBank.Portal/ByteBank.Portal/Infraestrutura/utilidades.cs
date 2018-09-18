﻿using System;
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

            var nomeCompleto = $"{prefixoAssembly}{pathComPontos}";

            return nomeCompleto;
        }
        public static string ObterTipoDeConteudo(string path)
        {
            if (path.EndsWith(".css"))
                return "text/css; charset=utf-8";

            if (path.EndsWith(".js"))
                return "application/js; charset=utf-8";

            if (path.EndsWith(".html"))
                return "text/html; charset=utf=8";

                throw new NotImplementedException("Tipo de conteúdo não previsto!");
        }
            
    }
}
