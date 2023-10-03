using AppBancoDigital.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppBancoDigital.View.Acesso
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Cadastro2 : ContentPage
	{
		public Cadastro2 ()
		{
			InitializeComponent ();
            btn_senha.Source = ImageSource.FromResource("AppBancoDigital.Imagens.FecharOlho");
        }

        private async void btn_Cadastrar_Clicked(object sender, EventArgs e)
        {
            try
            {
                Model.Correntista c = await DataServiceCorrentista.save(new Model.Correntista
                {
                    senha = txt_senha.Text,
                    email = txt_email.Text

                });

                if (c.Id != null)
                {
                    App.DadosCorrentista = c;

                    await Navigation.PushAsync(new LoginCorrentista());
                }
                else
                    throw new Exception("Ocorreu um erro ao Salvar seu Cadastro.");
                {

                }
            }catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                await DisplayAlert("Ops!", ex.Message, "OK");
            }          
        }

        private void btn_senha_Clicked(object sender, EventArgs e)
        {
            if (txt_senha.IsPassword == true)
            {
                txt_senha.IsPassword = false;
                btn_senha.Source = ImageSource.FromResource("AppBancoDigital.Imagens.FecharOlho.png");
            }
            else
            {
                txt_senha.IsPassword = true;
                btn_senha.Source = ImageSource.FromResource("AppBancoDigital.Imagens.AbrirOlho.png");

            }
        }
    }
}