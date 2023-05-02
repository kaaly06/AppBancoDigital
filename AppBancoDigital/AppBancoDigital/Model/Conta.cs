using System;
using System.Collections.Generic;
using System.Text;

namespace AppBancoDigital.Model
{
    public class Conta
    {
        public int Id { get; set; }
        public string tipo { get; set; }
        public int numero { get; set; }
        public string senha { get; set; }
        public string id_correntista { get; set; }

    }
}
