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
    public partial class TelaEntrada : ContentPage
    {
        public TelaEntrada()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            //Logo do App
            Logo.Source = ImageSource.FromResource("AppBancoDigital.Imagens.logo-remove.png");
            //Assistente.Source = ImageSource.FromResource("AppBancoDigital.Imagens.Assistente.png");
        }
    }
}