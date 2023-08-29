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
    public partial class TelaInicial : ContentPage
    {
        public TelaInicial()

        {
            NavigationPage.SetHasNavigationBar(this, false);
            InitializeComponent();
            btn_saldo.Source = ImageSource.FromResource("AppBancoDigital.Imagens.AbrirOlho.png");

            
        }

        private void btn_MostrarSaldo(object sender, EventArgs e)
        {
            
        }
    }
}