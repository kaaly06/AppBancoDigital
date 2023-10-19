using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.AndroidSpecific;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.Xaml;

namespace AppBancoDigital.View.Pix
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PixInicial : ContentPage
    {
        public PixInicial()
        {
            NavigationPage.SetHasNavigationBar(this, false);
            InitializeComponent(); 
            btnVoltar.Source = ImageSource.FromResource("AppBancoDigital.Imagens.Voltar.png");
            btnInterrogacao.Source = ImageSource.FromResource("AppBancoDigital.Imagens.interrogacao.png");
            btnPagar.Source = ImageSource.FromResource("AppBancoDigital.Imagens.pagar.png");
            btnSetaD.Source = ImageSource.FromResource("AppBancoDigital.Imagens.seta-direita.png");
            btnReceber.Source = ImageSource.FromResource("AppBancoDigital.Imagens.qrcode.png");
            btnContinuar.Source = ImageSource.FromResource("AppBancoDigital.Imagens.seta-direita.png");
            Assist.Source = ImageSource.FromResource("AppBancoDigital.Imagens.Assistente.png");
        }

        private void Button_Clicked_FazerPix(object sender, EventArgs e)
        {
            Navigation.PushAsync(new View.Pix.EnviarPix());
        }

        private void Button_Clicked_ReceberPix(object sender, EventArgs e)
        {

        }

        private void btnvoltar_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new TelaInicial());
        }

        private void btnInterrogacao_Clicked(object sender, EventArgs e)
        {

        }
    }
}