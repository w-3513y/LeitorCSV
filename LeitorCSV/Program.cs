using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

namespace LeitorCSV
{
    class Program
    {
        static void Main(string[] args)
        {
            bool Terminar = false;
            while (!Terminar)
            {
                Console.WriteLine("0 - Duplicadas");
                Console.WriteLine("1 - Juntar");
                string decisao = Console.ReadLine();
                if (decisao == "0")
                {
                    Gerador.Gerar();
                    Console.WriteLine("Terminar? 0 - Não. 1 - Sim");
                    string decicao = Console.ReadLine();
                    if (decicao == "1")
                    {
                        Terminar = true;
                    }
                }
                else
                {
                    Consolidador.Gerar();
                }
                if (!Terminar)
                {
                    Console.WriteLine("Terminar? 0 - Não. 1 - Sim");
                    string decicao = Console.ReadLine();
                    if (decicao == "1")
                    {
                        Terminar = true;
                    }
                }
            }
        }
    }
}
