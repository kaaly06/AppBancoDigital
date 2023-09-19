using AppBancoDigital.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
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
            dtcpk_data_nasc.MaximumDate = DateTime.Now.AddYears(-17);
            btn_senha.Source = ImageSource.FromResource("AppBancoDigital.Imagens.FecharOlho");
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
                    nome = txt_nome.Text,
					data_nasc = dtcpk_data_nasc.Date,
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

        private void btn_voltar_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new View.LoginCorrentista());
        }
    }
}
