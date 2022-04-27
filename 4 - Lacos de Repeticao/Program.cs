using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4___Laços_de_repetições
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto!");

            //double valorInvestido = 1000;

            // WHILE
            //while (mes <= 12)
            //{
            //    valorInvestido = valorInvestido + (valorInvestido * 0.0036);

            //    if (mes == 1)
            //    {
            //        Console.WriteLine("Em 1 mês você terá " + valorInvestido);
            //    }
            //    else
            //    {
            //        Console.WriteLine("Em " + mes + " meses você terá " + valorInvestido);
            //    }

            //    mes++;

            //}

            //---------------------------------------------------

            // FOR
            //for(int mes = 1; mes <= 12; mes++)
            //{
            //    valorInvestido *= 1.0036;
            //    Console.WriteLine("Em " + mes + " mês(es) você terá " + valorInvestido);
            //}

            //double fatorRendimento = 1.0036;

            //---------------------------------------------------

            // FOR ENCADEADOS
            //for(int ano = 1; ano <= 5; ano++)
            //{
            //    for(int mes = 1; mes <=12; mes++)
            //    {
            //        valorInvestido *= fatorRendimento;
            //    }

            //    fatorRendimento += 0.0010;

            //}
            //    Console.WriteLine("Ao término do investimento você terá " + valorInvestido);

            //---------------------------------------------------
            // DESAFIO OPCIONAL
            //    string asterisco = "*";
            //for(int index = 1; index <= 100; index++)
            //{
            //    Console.WriteLine(asterisco);
            //    asterisco += "*";
            //}

            //---------------------------------------------------
            // DESAFIO OPCIONAL
            //int valorFinal = 100;
            //for (int numero = 1; numero <= valorFinal; numero++)
            //{
            //    if (numero % 2 == 0)

            //        Console.WriteLine(numero + " é par");

            //    else
            //        Console.WriteLine(numero + " é impar");
            //}

            //---------------------------------------------------
            // DESAFIO OPCIONAL
            int fatorial = 1;
            for (int i = 1; i < 11; i++)
            {
                fatorial *= i;
                Console.WriteLine("Fatorial de " + i + " = " + fatorial);
            }
        

            Console.ReadLine();
        }
    }
}
