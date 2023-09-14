using System;
using System.Collections.Generic;
using System.Text;

namespace AppBancoDigital.Model
{
    public class Conta
    {
        public int Id { get; set; }
        public string tipo { get; set; }
        public double saldo {  get; set; }
        public double limite { get; set; }
        public string id_Correntista { get; set; }

    }
}
