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
        public static async Task<Correntista> LoginCorrentistaAsync(Correntista c)
        {
           var json_enviar = JsonConvert.SerializeObject(c);

            Console.WriteLine("__________________________________________________________________");
            Console.WriteLine("DADOS QUE FORAM DIGITADOS PELO USUÁRIOS E JÁ CONVERTIDOS EM JSON: ");
            Console.WriteLine(json_enviar);
            Console.WriteLine("__________________________________________________________________");

            string json = await DataService.PostDataToService(json_enviar, "/correntista/login");

            return JsonConvert.DeserializeObject<Correntista>(json);
        }

        public static async Task<Correntista> SalvarAsync(Correntista c)
        {
            var json_enviar = JsonConvert.SerializeObject(c);

            string json = await DataService.PostDataToService(json_enviar, "/correntista/salvar");

            Correntista corr = JsonConvert.DeserializeObject<Correntista>(json);

            return JsonConvert.DeserializeObject<Correntista>(json);
        }

       
    }
}
