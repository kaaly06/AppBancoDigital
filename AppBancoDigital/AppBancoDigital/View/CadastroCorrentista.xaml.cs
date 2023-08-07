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



		private async void Cadastrar(object sender, EventArgs e)
		{
			if (txt_nome.Text == null || txt_cpf.Text == null || txt_senha.Text == null || txt_conf_senha.Text == null)
			{
				lbl_erro.Text = "Preencha todos os campos!";
			}
			else
			{
				if (txt_senha.Text != txt_conf_senha.Text)
				{
					lbl_erro.Text = "A senha deve ser a mesma nos dois campos!";
				}
				else
				{
					try
					{
						Model.Correntista c = await DataServiceCorrentista.CadastroCorrentista(new Model.Correntista
						{
							nome = txt_nome.Text,
                            senha = txt_senha.Text,                         
                            CPF = txt_cpf.Text.Replace(".", string.Empty).Replace("-", string.Empty)
                        });

                        string msg = $"Correntista criado! Faça login para acessar.";

                        await DisplayAlert("Sucesso!", msg, "OK");

                        await Navigation.PushAsync(new LoginCorrentista());
                    }
					catch (Exception ex)
					{
                        await DisplayAlert("Ops", ex.Message, "OK");
                    }
				}

			}

		} 
    }
}