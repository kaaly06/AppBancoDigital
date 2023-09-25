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
            btn_transf.Source = ImageSource.FromResource("AppBancoDigital.Imagens.BtnTransf.png");
            btn_pagar.Source = ImageSource.FromResource("AppBancoDigital.Imagens.BtnPagar.png");
            //Console.WriteLine("_____________________CONTAS_____________________________");
            //Console.WriteLine(App.DadosCorrentista.rows_contas.Count);
            //Console.WriteLine("_____________________FIM CONTAS_____________________________");



        }

        private void btn_MostrarSaldo(object sender, EventArgs e)
        {
            double saldo_contas = App.DadosCorrentista.rows_contas.Sum(i => i.saldo);

            if (txt_SaldoUsuario.Text == "R$ ⎯⎯⎯⎯") 
            {
                txt_SaldoUsuario.Text = "R" + saldo_contas.ToString("C");
                btn_saldo.Source = ImageSource.FromResource("AppBancoDigital.Imagens.AbrirOlho.png");
            }
            else
            { 
                txt_SaldoUsuario.Text = "R$ ⎯⎯⎯⎯";
                btn_saldo.Source = ImageSource.FromResource("AppBancoDigital.Imagens.FecharOlho.png");
            }
        }

        private void Seta_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new View.LoginCorrentista());
        }

        private void btn_transf_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new View.Pix.PixInicial());
        }

        private void btn_pagar_Clicked(object sender, EventArgs e)
        {

        }
    }
}