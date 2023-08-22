using AppBancoDigital.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace AppBancoDigital.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CadastroCorrentista : ContentPage
	{
		public CadastroCorrentista ()

		{
			InitializeComponent ();
			NavigationPage.SetHasNavigationBar(this, false);	
		}

        private async void Button_Clicked_cadastrar(object sender, EventArgs e)
        {
          try
			{
				Model.Correntista c = await DataServiceCorrentista.CorrentistaSalvar(new Model.Correntista
					{
                    nome = txt_nome.Text,
                    senha = txt_senha.Text,
                    email = txt_email.Text,
                    CPF = txt_cpf.Text.Replace(".", string.Empty).Replace("-", string.Empty)

                });

				if (c.Id != null)
				{
					App.DadosCorrentista = c;

					await Navigation.PushAsync(new TelaInicial());
				}
				else
					throw new Exception("Ocorreu um erro ao Salvar seu Cadastro.");
			}
			catch(Exception ex)
			{
				Console.WriteLine(ex.StackTrace);
				await DisplayAlert("Ops!", ex.Message, "OK");
            }
        }
    }
}
