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
    public partial class PixInicial : ContentPage
    {
        public PixInicial()
        {
            NavigationPage.SetHasNavigationBar(this, false);
            InitializeComponent();
        }

        private void Button_Clicked_FazerPix(object sender, EventArgs e)
        {
            Navigation.PushAsync(new View.Pix.EnviarPix());
        }

        private void Button_Clicked_ReceberPix(object sender, EventArgs e)
        {

        }
    }
}