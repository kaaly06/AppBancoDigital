using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using AppBancoDigital.Model;
using AppBancoDigital.View;
using AppBancoDigital.Service;

namespace AppBancoDigital.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginCorrentista : ContentPage
    {
        public LoginCorrentista()
        {
            InitializeComponent();

            //FrameCpf.BackgroundColor = Color.FromRgba(250, 250, 250, 50);
            //btn_login.BackgroundColor = Color.FromRgba(255, 255, 255, 50);
            //btn_cadastrar.BackgroundColor = Color.FromRgba(255,255,255,50);
            Logo.Source = ImageSource.FromResource("AppBancoDigital.Imagens.Logo.png");
            Usuario.Source = ImageSource.FromResource("AppBancoDigital.Imagens.PerfilUsuario.png");
            
         

            NavigationPage.SetHasNavigationBar(this, false);
        }

        private async void btn_login_Clicked(object sender, EventArgs e)
        {
            try
            {
                Model.Correntista c = await DataServiceCorrentista.CadastroCorrentista(new Model.Correntista
                {
                    CPF = txt_cpf.Text,
                    senha = txt_senha.Text,
                });

                if (c.id != null)
                {
                    App.DadosCorrentista = c;
                    App.Current.MainPage = new NavigationPage(new View.LoginCorrentista());
                }
                else
                    throw new Exception("Dados de login inválidos.");

            }catch(Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }
        }

        private void btn_cadastrar_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new View.CadastroCorrentista());

        }
    }
}