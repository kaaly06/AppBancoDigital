using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using AppBancoDigital.Model;
using AppBancoDigital.View;

namespace AppBancoDigital
{
    public partial class App : Application
    {
        public static Model.Correntista DadosCorrentista { get; set; }

        public App()
        {
         
            InitializeComponent();

            MainPage = new NavigationPage(new LoginCorrentista());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
