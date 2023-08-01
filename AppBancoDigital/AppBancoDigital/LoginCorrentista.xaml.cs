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
                               
        }

        private void btn_cadastrar_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new View.CadastroCorrentista());

        }
    }
}