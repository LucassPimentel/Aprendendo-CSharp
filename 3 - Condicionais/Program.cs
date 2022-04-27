using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condicionais
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executanto aplicação");

            int idade = 18;

            if (idade < 18)
            {
                Console.WriteLine("Você é menor de idade;");
            }
            else
            {
                Console.WriteLine("Você é maior de idade");
            }

            Console.WriteLine("Execução finalizada");
            Console.ReadLine();

        }
    }
}
