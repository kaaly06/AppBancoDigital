using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
            Logo.Source = ImageSource.FromResource("AppBancoDigital.Imagens.logo-remove (2).png");
            //Assistente.Source = ImageSource.FromResource("AppBancoDigital.Imagens.Assistente.png");

            CarouselView carouselView = new CarouselView();
            carouselView.SetBinding(ItemsView.ItemsSourceProperty, "Assistente");

           carouselView.ItemTemplate = new DataTemplate(typeof(TelaEntrada));
            {
                Image image = new Image {Source};
                image.SetBinding(Image.SourceProperty, "ImgUrl");
            }

           
           
        }

        public class Assistente
        {
            public string ImgUrl { get; set; }
        }


    }

       
}