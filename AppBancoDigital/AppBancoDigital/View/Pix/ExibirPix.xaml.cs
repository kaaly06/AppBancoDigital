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
    public partial class ExibirPix : ContentPage
    {
        public ExibirPix()
        {
            NavigationPage.SetHasNavigationBar(this, false);
            InitializeComponent();
            btnvoltar.Source = ImageSource.FromResource("AppBancoDigital.Imagens.Voltar.png");
            btnInfo.Source = ImageSource.FromResource("AppBancoDigital.Imagens.info.png");
        }

        private void btnInfo_Clicked(object sender, EventArgs e)
        {

        }

        private void btn_gerar_Clicked(object sender, EventArgs e)
        {

            string teste = "Chave da transferência: kalianyandressa2@gmail.com";

            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(teste, QRCodeGenerator.ECCLevel.Q);
            PngByteQRCode qRCode = new PngByteQRCode(qrCodeData);
            byte[] qrCodeBytes = qRCode.GetGraphic(20);
            img_qr.Source = ImageSource.FromStream(() => new MemoryStream(qrCodeBytes));
        }

        private void btn_voltar_Clicked(object sender, EventArgs e)
        {

        }
    }
}