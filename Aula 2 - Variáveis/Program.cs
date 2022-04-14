using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2___Variaveis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // int para inteiros
            int idade = 19;

            // long 
            long universo = 130000000000;

            // short
            short minhaContaBancaria = 200;

            // float
            float altura = 1.8f;

            // double numeros flutuantes
            double salario;
            salario = 1364.50;

            // char 
            char inicialDoNome = 'L';

            // string

            string cursosProgramacao =
@".NET
Python
Javascript";


            Console.WriteLine(cursosProgramacao);
             
            Console.Write("Executando projeto 2 - Criando variáveis");

            Console.WriteLine(" Sua idade é " + idade + " anos, " + "sua altura é " + altura + "m ," + "seu salário é " + salario + ", você está inserido em um universo de " + universo + " bilhões de anos" + " e seu amigo Lucas tem " + minhaContaBancaria + ",00 reais na conta.");

            Console.WriteLine("Execução finalizada, tecle enter para sair...");
            Console.ReadLine();
        }
    }
}
