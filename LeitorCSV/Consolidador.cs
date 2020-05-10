using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace LeitorCSV
{
    class Consolidador
    {
        static public void Gerar()
        {
            string b = @"E:\Pendencias\Lançamentos\DUP\";
            string a = ".csv";
            string[] arquivos = new string[] { b+"1005"+a, b+"1010"+a, b+"1015"+a, b+"1020"+a, b+"1025"+a, b+"1031"+a, b+"1105"+a, b+"1110"+a, b+"1115"+a, b+"1120"+a, b+"1125"+a, b+"1130"+a, b+"1205"+a, b+"1210"+a, b+"1215"+a, b+"1220"+a,
                                          b+"1225"+a, b+"1231"+a};

            LAN lanc = new LAN();

            List<string> linesFind = new List<string>();
            linesFind.Add("Data;Chave;Devedora;Credora;Valor;Historico;LoteApagar;LoteOrigem;Origem");

            foreach (var y in arquivos)
            {
                var lanclist = lanc.LeLinhaDuplicada(y);
                foreach(var x in lanclist)
                {
                    linesFind.Add(x.Data + ";" + x.Chave + ";" + x.Devedora + ";" + x.Credora + ";" + x.Valor + ";" + x.Historico + ";" + x.Lote + ";" + x.LoteCorreto + ";" + x.Origem);
                }                
            }
            File.WriteAllLines(@"E:\Pendencias\Lançamentos\DUP\Consol.csv", linesFind);
        }
    }
}
