using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*dynamic valor = "1 real";
            var nome = "Gabriel";
            var idade = 22;

            valor = 1.0;

            Console.WriteLine("Hello");
            Console.WriteLine("abc");
            Console.ReadLine();*/

            Console.WriteLine("Escreva seu nome: ");
            String nome = Console.ReadLine();
            Console.WriteLine("Seu nome é "  +  nome);

            Console.ReadLine();

            if(nome.Equals("Gabriel")==true)
            {
                Console.WriteLine("OK!");
            }
            else 
            { 
                Console.WriteLine("ERRO!"); 
            }


        }
    }
}
