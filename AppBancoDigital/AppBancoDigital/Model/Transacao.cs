using System;
using System.Collections.Generic;
using System.Text;

namespace AppBancoDigital.Model
{
    public class Transacao
    {
        public DateTime Data { get; set; }

        public string Tipo { get; set; }
        public string ContaDestinatario { get; set; }
        public string ContaRemetente { get; set; }
        public double Valor { get; set; }


    }
}
