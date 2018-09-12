﻿using ByteBank.Portal.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Portal.Infraestrutura
{

    public class WebApplication
    {
        private readonly string[] _prefixos;
        private char[] respostaConteudo;
        private char[] paginaConteudo;

        public WebApplication(string[] prefixos)
        {
            if (prefixos == null)
                throw new ArgumentNullException(nameof(prefixos));
            _prefixos = prefixos;
            
        }
       

        public void Iniciar()
        {
            while (true)
                ManipularRequisicao();
          

        }
        private void ManipularRequisicao()
        {
            var httpListener = new HttpListener();

            foreach (var prefixo in _prefixos)
                httpListener.Prefixes.Add(prefixo);


            httpListener.Start();

            var contexto = httpListener.GetContext();
            var requisicao = contexto.Request;
            var resposta = contexto.Response;

            var path = requisicao.Url.AbsolutePath;

            if (Utilidades.EhArquivo(path))
            {
                var manipulador = new ManipuladorRequisicaoArquivo();
                manipulador.Maipular(resposta, path)
            }
                else if (path == "/Cambio/MXN")
                {
                    var controller = new CambioController();
                    var paginaConteudo = controller.MXN();
                }

                var bufferArquivo = Encoding.UTF8.GetBytes(paginaConteudo);
                resposta.StatusCode = 200;
                resposta.ContentType = "text/html; charset=uft-8";
                resposta.ContentLength64 = bufferArquivo.Length;

                resposta.OutputStream.Write(bufferArquivo, 0, bufferArquivo.Lenght);
                resposta.OutputStream.Close();
        }
            else if(path == "/Cambio/USD")
         

            public string USD()
            {

                var valorFinal = _cambioService.Calcular("USD", "BRL", 1);
                var nomeCompletoResource = "ByteBank.Portal.View.Cambio.MXN.html";
                var assembly = Assembly.GetExecutingAssembly();

                var streamRecurso = assembly.GetManifestResourceStream(nomeCompletoResource);

                var streamLeitura = new StreamReader(streamRecurso);
                var textoPagina = streamLeitura.ReadToEnd();

                var textoResultado = textoPagina.Replace("VALOR_EM_REAIS", valorFinal.ToString());

                Return textoResultado;



            }



            httpListener.Stop();
        }
    }
}
