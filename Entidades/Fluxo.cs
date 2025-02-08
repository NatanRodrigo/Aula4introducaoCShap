using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExemploTemplateConsole.Entidades;

namespace ExemploTemplateConsole.Entidades
{
    public class Fluxo
    {
        public void Executar()
        {
            // declarei uma váriavel do tipo pessoa
            // coloquei o nome da váriavel como pessoa
            // inicializei usando o igual
            // recebendo o valor instanciando através do new
            // que o new instaciou a classe Pessoa
            // fiz com que a váriavel pessoa tenha todos os atributos da claase
            Pessoa pessoa = new Pessoa();

            // Quando eu coloco o nome da váriavel que eu instanciei um objeto (classe)
            // através do .(ponto) eu consigo acessar e modificar os atribustos que tem na classe
            // ou seja o nome, está dentro de class Pessoa 
            // public string Nome { get; set; } pelo fato dele está public eu consigo acessar ele aqui
            pessoa.Nome = "Natan";

            pessoa.Nascimento = DateTime.Parse("2001-02-15");

            TimeSpan tempoEntreDatas = DateTime.Now - pessoa.Nascimento;

            DateTime quantosAnosTem = new DateTime(tempoEntreDatas.Ticks);

            int quantosAnos = quantosAnosTem.Year;

            if (quantosAnos < 18)
            {
                Console.WriteLine("Menor de idade");
            }
            else
            {
                Console.WriteLine("Maior de idade");
            }
        }

    }
}
