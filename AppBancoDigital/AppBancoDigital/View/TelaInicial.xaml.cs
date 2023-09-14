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
            btnSeta.Source = ImageSource.FromResource("AppBancoDigital.Imagens.Voltar.png");

            //Console.WriteLine("_____________________CONTAS_____________________________");
            //Console.WriteLine(App.DadosCorrentista.rows_contas.Count);
            //Console.WriteLine("_____________________FIM CONTAS_____________________________");


            double saldo_contas = App.DadosCorrentista.rows_contas.Sum(i => i.saldo);

            txt_SaldoUsuario.Text = saldo_contas.ToString();
        }

        private void btn_MostrarSaldo(object sender, EventArgs e)
        {
            if (txt_SaldoUsuario.IsVisible == true) 
            {
                txt_SaldoUsuario.IsVisible = false;
                btn_saldo.Source = ImageSource.FromResource("AppBancoDigital.Imagens.FecharOlho.png");
            }
            else
            {
                txt_SaldoUsuario.IsVisible = true;
                btn_saldo.Source = ImageSource.FromResource("AppBancoDigital.Imagens.AbrirOlho.png");
            }
        }

        private void Seta_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new View.LoginCorrentista());
        }
    }
}