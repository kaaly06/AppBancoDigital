using System;
using System.Collections.Generic;
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
    }
}