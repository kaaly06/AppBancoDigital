using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace AppBancoDigital.Model
{
    public class Correntista
    {
        public int? Id { get; set; }
        public string nome { get; set; }
        public string email { get; set; }   
        public string CPF { get; set; }
        public DateTime data_nasc { get;set; }
        public string senha { get; set; }
        public List<Conta> rows_contas { get; set; } 
        
    }
}
