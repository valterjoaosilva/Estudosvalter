﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
namespace Caelum.Leilao
{
    [TestFixture]
    public class AvaliadorTest
    {
        private Avaliador leiloeiro;
        private Usuario joao;
        private Usuario jose;
        private Usuario maria;

        [SetUp]
        public void CriaAvaliador()
        {
            this.leiloeiro = new Avaliador();
            Console.WriteLine("Executando o Cria Avaliador");


            this.joao = new Usuario("Joao");
            this.jose = new Usuario("Jose");
            this.maria = new Usuario("Maria");
        }
        [Test]
        public void DeveEntenderLancesEmOrdemCrescente()
        {

            Leilao leilao = new Leilao("Playstation 3 Novo");

            leilao.Propoe(new Lance(maria, 250.0));
            leilao.Propoe(new Lance(joao, 300.0));
            leilao.Propoe(new Lance(jose, 400.0));


     
            leiloeiro.Avalia(leilao);

            double maiorEsperado = 400;
            double menorEsperado = 250;

            
            Assert.AreEqual(maiorEsperado, leiloeiro.MaiorLance);
            Assert.AreEqual(menorEsperado, leiloeiro.MenorLance);

        }

        [Test]
        public void DeveEntenderLeilaoComApenasUmLance()
        {
          
            
            Leilao leilao = new CriadorDeLeilao().Para("Playstation 3 Novo")
                      
            .Lance(joao, 1000)
            .Constroi();

     
            leiloeiro.Avalia(leilao);
                       

            Assert.AreEqual(1000, leiloeiro.MaiorLance, 0.0001);
            Assert.AreEqual(1000, leiloeiro.MenorLance, 0.0001);


        }
        [Test]
        public void DeveEncontrarOsTresMaioresLances()
        {


            Leilao leilao = new CriadorDeLeilao().Para("Playstation")
                .Lance(joao, 100)
                .Lance(maria, 200)
                .Lance(joao, 300)
                .Lance(maria, 400)
                .Constroi();


                     
            leiloeiro.Avalia(leilao);

            var maiores = leiloeiro.TresMaiores;


            Assert.AreEqual(3, maiores.Count);
            Assert.AreEqual(400, maiores[0].Valor, 0.0001);
            Assert.AreEqual(300, maiores[1].Valor, 0.0001);
            Assert.AreEqual(200, maiores[2].Valor, 0.0001);
        }
     



    }
}
