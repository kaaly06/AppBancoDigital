using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using AppBancoDigital.Model;
using AppBancoDigital.View;

namespace AppBancoDigital.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginCorrentista : ContentPage
    {
        public LoginCorrentista()
        {
            InitializeComponent();
            
            //Frame.BackgroundColor = Color.FromRgba(255, 255, 255, 50);
            //btn_login.BackgroundColor = Color.FromRgba(255, 255, 255, 50);
            //btn_cadastrar.BackgroundColor = Color.FromRgba(255,255,255,50);

            NavigationPage.SetHasNavigationBar(this, false);
        }

        private void btn_login_Clicked(object sender, EventArgs e)
        {

        }

        private void btn_cadastrar_Clicked(object sender, EventArgs e)
        {

        }
    }
}