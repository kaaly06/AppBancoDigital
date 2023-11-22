using AppBancoDigital.Service;
using AppBancoDigital.View.AbrirConta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using AppBancoDigital.View;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using AppBancoDigital.View.Acesso;

namespace AppBancoDigital.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CadastroCorrentista : ContentPage
	{
		public CadastroCorrentista ()

		{
			InitializeComponent();
			NavigationPage.SetHasNavigationBar(this, false);
            dtcpk_data_nasc.MaximumDate = DateTime.Now.AddYears(-17);
			btn_voltar.Source = ImageSource.FromResource("AppBancoDigital.Imagens.Voltar.png");

			//var editor = new Editor { Keyboard = Keyboard.Email};

            var editor = new Editor();
            editor.Keyboard = Keyboard.Create(KeyboardFlags.Suggestions | KeyboardFlags.CapitalizeWord);
        }

		private async void Button_Clicked_cadastrar(object sender, EventArgs e)
		{
			try
			{
				Model.Correntista c = await DataServiceCorrentista.save(new Model.Correntista
				{
					//nome = App.Globais._nome,
					//data_nasc = App.Globais._dtcpk_data_nasc.Date,
					//CPF = App.Globais._txt_cpf.Text.Replace(".", string.Empty).Replace("-", string.Empty)

				});

				if (c.Id != null)
				{
					App.DadosCorrentista = c;

					await Navigation.PushAsync(new Cadastro2());
				}
				else
					throw new Exception("Ocorreu um erro ao Salvar seu Cadastro.");
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.StackTrace);
				await DisplayAlert("Ops!", ex.Message, "OK");
			}			
        }    

        private async void btn_voltar_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new View.AbrirConta.Entrada());
        }

        private void btn_continuar_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new View.Acesso.Cadastro2());
        }
    }
}
