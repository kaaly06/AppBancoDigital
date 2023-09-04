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
			btn_senha.Source = ImageSource.FromResource("AppBancoDigital.Imagens.FecharOlho");
		}

        private async void Button_Clicked_cadastrar(object sender, EventArgs e)
        {
          try
			{
				Model.Correntista c = await DataServiceCorrentista.save(new Model.Correntista
					{
                    nome = txt_nome.Text,
                    senha = txt_senha.Text,
                    email = txt_email.Text,
                    CPF = txt_cpf.Text.Replace(".", string.Empty).Replace("-", string.Empty)

                });

				if (c.Id != null)
				{
					App.DadosCorrentista = c;

					await Navigation.PushAsync(new LoginCorrentista());
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

        private void btn_MostrarSenha(object sender, EventArgs e)
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
