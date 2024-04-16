using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack1
{
    internal class Program
    {
        public struct Aluno
        {
            public string Nome;
            public int NumeroAluno;
            public string Morada;
            public DateTime DataNascimento;
        }

        static void Main(string[] args)
        {
            /*
               1 (revisões) - Criar um array de 26 elementos para a struct Aluno, chamado alunos
           */

            //______ alunos = new ______;

            /*
                2 - Completar a declaração de uma stack, chamada numeros, do tipo int
             */

            // ______<______> numeros = new ______<______>();

            /* 
                3 - Inserir os seguintes números na stack numeros:
                    
                        5, 25, 0, 8, -22, 199
            */

            //_______._______(5);
            //__________________;
            //__________________;
            //__________________;
            //__________________;
            //__________________;

            /*
                4 - Retirar os três primeiros elementos da stack
            */

            //numeros.______;
            //numeros.______;
            //numeros.______;

            /* 
                5 - Retirar o elemento seguinte da stack, atribuir à variável x e mostrar na consola
            */

            //______ x = ______;
            //Console.______(x);

            /*
                6 - Obter *mas sem retirar* o próximo elemento da queue e mostrar na consola
             */

            //Console.WriteLine(______);

            /*
                7 - Criar uma stack chamada websites e introduzir os seguintes elementos:

                "https://slashdot.org/", "https://kotlinlang.org", "https://learn.microsoft.com/pt-pt/dotnet/csharp/"
            */

            // Inserir aqui o código

            /*
                8 - Percorrer a stack numeros e mostrar o conteúdo
            */

            //Console.WriteLine("\nLista de números");
            //foreach (______ numero in ______)
            //{
            //    Console.WriteLine(numero);
            //}

            /*
                9 - Mostre o número de elementos da stack numeros e da stack websites
            */

            //Console.WriteLine($"\nNúmero de elementos da stack numeros: {numeros.______}");
            //Console.WriteLine($"Número de elementos da stack websites: {websites.______}");

            /*
                10 - Limpar o conteúdo da stack numeros e da stack websites
            */

            //______.______();
            //______.______();

            Console.ReadKey();
        }
    }
}
