using QRCoder;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppBancoDigital.View.Pix
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EnviarPix : ContentPage
    {
        public EnviarPix()
        {
            NavigationPage.SetHasNavigationBar(this, false);
            InitializeComponent();
            btnvoltar.Source = ImageSource.FromResource("AppBancoDigital.Imagens.Voltar.png");
            qrcode.Source = ImageSource.FromResource("AppBancoDigital.Imagens.camera.png");
        }

        private void Scanner(object sender, EventArgs e)
        {
            Navigation.PushAsync(new LerQrCode());
        }

        private void btnvoltar_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PixInicial());
        }
    }
}