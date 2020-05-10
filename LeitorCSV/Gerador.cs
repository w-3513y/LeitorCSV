using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace LeitorCSV
{
    static class Gerador
    {
        static public void Gerar()
        {
            Console.WriteLine("Nome Arquivo:");
            string compl = Console.ReadLine();
            string arq1 = @"E:\Pendencias\Lançamentos\LAN\" + compl + ".csv";
            string arq3 = @"E:\Pendencias\Lançamentos\OUT\" + compl + ".csv";
            string arq4 = @"E:\Pendencias\Lançamentos\DUP\" + compl + ".csv";

            LAN lan1 = new LAN();

            var listaLancOne = lan1.LeLinha(arq1);
            var listaLancTwo = lan1.LeLinha(arq1);


            List<string> linesFind = new List<string>();
            linesFind.Add("Data;Chave;Devedora;Credora;Valor;Historico;LoteApagar;LoteOrigem;Origem");

            List<string> linhas = new List<string>();
            linhas.Add("Data;Chave;Devedora;Credora;Valor;Historico;LoteApagar;LoteOrigem;Origem");

            string[] lotes = new string[] { "7", "8", "9"};

            
          //  var last = arqTwo.Last();
          //  var last2 = arqOne.Last();

            foreach (var x in listaLancTwo)
            {
                bool find = false;
               // if (x == last) para debbugar - validar se ambas as coleçoes estão indo até o final
               // {
               //     Console.ReadLine();
               // }
                foreach (var y in listaLancOne)
                {
               //     if (y == last2)
               //     {
               //         int i = 0;
               //     }
                    if ((x.Data == y.Data) && (x.Devedora == y.Devedora) && (x.Credora == y.Credora) && (x.Valor == y.Valor) && (x.Historico == y.Historico) && (x.Lote != y.Lote) && (Array.IndexOf(lotes, x.Lote) > -1))
                    {                       
                        linesFind.Add(x.Data + ";" + x.Chave + ";" + x.Devedora + ";" + x.Credora + ";" + x.Valor + ";" + x.Historico + ";" + x.Lote + ";" + y.Lote + ";" + x.Origem);
                        find = true;
                        break;
                    }

                }
                if (!find && (Array.IndexOf(lotes, x.Lote) > -1))
                {
                    linhas.Add(x.Data + ";" + x.Chave + ";" + x.Devedora + ";" + x.Credora + ";" + x.Valor + ";" + x.Historico + ";" + x.Lote + ";" + ";" + x.Origem);
                }
            }
       //     Console.ReadLine();
            File.WriteAllLines(arq3, linhas);
            File.WriteAllLines(arq4, linesFind);


        }
    }
}
