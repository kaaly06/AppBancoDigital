using AppBancoDigital.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppBancoDigital.Service
{
    public class DataServiceCorrentista : DataService
    {     // login do cliente
        public static async Task<Correntista> CorrentistaSalvar(Correntista c)
        {
            var json_a_enviar = JsonConvert.SerializeObject(c);

            Console.Write("__________________________________________________________________");
            Console.WriteLine("DADOS QUE FORAM DIGITADOS PELO USUÁRIOS E JÁ CONVERTIDOS EM JSON:");
            Console.WriteLine(json_a_enviar);
            Console.WriteLine("__________________________________________________________________");

            string json = await DataService.PostDataToService(json_a_enviar, "/correntista/salvar");
            return JsonConvert.DeserializeObject<Correntista>(json);
        }

        public static async Task<Correntista> Entrar(Correntista c)
        {
            var json_a_enviar = JsonConvert.SerializeObject(c);

            Console.Write("__________________________________________________________________");
            Console.WriteLine("DADOS QUE FORAM DIGITADOS PELO USUÁRIOS E JÁ CONVERTIDOS EM JSON:");
            Console.WriteLine(json_a_enviar);
            Console.WriteLine("__________________________________________________________________");


            string json = await DataService.PostDataToService(json_a_enviar, "/correntista/entrar");

            return JsonConvert.DeserializeObject<Correntista>(json);
        }

       
    }
}
