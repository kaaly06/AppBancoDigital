using AppBancoDigital.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppBancoDigital.Service
{
    public class DataServiceCorrentista : DataService
    {
        public static async Task<List<Correntista>> GetCorrentistaAsync()
        {
            string json = await DataService.GetDataFromService("/correntista");

            List<Correntista> arr_correntistas = JsonConvert.DeserializeObject<List<Correntista>>(json);

            return arr_correntistas;
        }

        public static async Task<Correntista> Cadastrar(Correntista c)
        {
            var json_enviar = JsonConvert.SerializeObject(c);

            string json = await DataService.PostDataToService(json_enviar, "/correntista/salvar");

            Correntista corr = JsonConvert.DeserializeObject<Correntista>(json);

            return corr;
        }

       
    }
}
