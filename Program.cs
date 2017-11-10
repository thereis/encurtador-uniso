using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncurtadorLink
{
    class Program
    {
        static void Main(string[] args)
        {

            // variaveis
            var padrao = "http://uni.so/";
            var url = string.Empty;

            // logo da uniso
            using (StreamReader uniso = new StreamReader("uniso.txt"))
            {
                var line = uniso.ReadToEnd();
                Console.WriteLine(line);
            }

            Console.WriteLine("------------- ENCURTADOR DE URL UNISO -------------");
            Console.WriteLine("Tenha o total conhecimento que as URLs depois de encurtadas, não funcionarão.");
            Console.WriteLine("Este projeto tem finalidade didática.");

            // verifica se a string está vazia ou nula
            while (string.IsNullOrEmpty(url))
            {
                Console.WriteLine("\n\nInsira a URL que você deseja encurtar:");
                url = Console.ReadLine();
            }
           
            // limpa o console
            Console.Clear();

            // encurta a URL
            var encurtar = new Encurtar(url);

            // resultado
            var result = encurtar.Encrypt();

            Console.WriteLine("URL encriptada com sucesso! Para acessar, basta copiar e colar o link gerado abaixo em seu navegador!\n\n");
            Console.WriteLine($"{padrao}{result}");
            Console.WriteLine("\n\nObrigado por utilizar a nossa ferramenta!");
            Console.ReadLine();

        }
    }
}
