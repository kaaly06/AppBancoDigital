using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppBancoDigital.View.AbrirConta
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Entrada : ContentPage
    {
        public Entrada()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            Logo.Source = ImageSource.FromResource("AppBancoDigital.Imagens.Logo-remove.png");
            Assistente1.Source = ImageSource.FromResource("AppBancoDigital.Imagens.Assistente.png");
            btn_criarconta.BackgroundColor = Color.FromRgba(141, 69, 91, 1);
         
        }

        private void Button_Abrir(object sender, EventArgs e)
        {
            Navigation.PushAsync(new View.LoginCorrentista());
        }

        private void Button_Criar(object sender, EventArgs e)
        {
            Navigation.PushAsync(new View.CadastroCorrentista());
        }      
    }
}