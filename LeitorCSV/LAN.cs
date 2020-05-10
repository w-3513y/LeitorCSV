using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace LeitorCSV
{
    class LAN
    {        
        public string Chave { get; set; }
        public string Data { get; set; }
        public string Devedora { get; set; }
        public string Credora { get; set; }        
        public string Valor { get; set; }
        public string Historico { get; set; }
        public string Origem { get; set; }
        public string Lote { get; set; }
        public string LoteCorreto { get; set; }

        public List<LAN> LeLinha(string path)
        {
            File.ReadAllLines(path);
            return File.ReadAllLines(path)
                          .Select(a => a.Split(';'))                          
                          .Select(c => new LAN()
                          {                              
                              Data = c[0],
                              Chave = c[1],
                              Devedora = c[2],
                              Credora = c[3],                              
                              Valor = c[4],
                              Historico = c[5],
                              Origem = c[6],
                              Lote = c[7]
                          })
                          .ToList();
        }

        public List<LAN> LeLinhaDuplicada(string path)
        {
            File.ReadAllLines(path);
            return File.ReadAllLines(path)
                          .Select(a => a.Split(';'))
                          .Skip(1)
                          .Select(c => new LAN()
                          {
                              Data = c[0],
                              Chave = c[1],
                              Devedora = c[2],
                              Credora = c[3],
                              Valor = c[4],
                              Historico = c[5],
                              Lote = c[6],
                              LoteCorreto = c[7],
                              Origem = c[8]
                          })
                          .ToList();

        }

    }
}
