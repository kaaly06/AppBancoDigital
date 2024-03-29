﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using AppBancoDigital.Model;
using AppBancoDigital.View;
using AppBancoDigital.Service;

namespace AppBancoDigital.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginCorrentista : ContentPage
    {
        public LoginCorrentista()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            //FrameCpf.BackgroundColor = Color.FromRgba(250, 250, 250, 50);
            //btn_login.BackgroundColor = Color.FromRgba(255, 255, 255, 50);
            //btn_cadastrar.BackgroundColor = Color.FromRgba(255,255,255,50);
            Logo.Source = ImageSource.FromResource("AppBancoDigital.Imagens.Logo-remove.png");
            btnvoltar.Source = ImageSource.FromResource("AppBancoDigital.Imagens.Voltar.png");
            //Usuario.Source = ImageSource.FromResource("AppBancoDigital.Imagens.PerfilUsuario.png");
            //logo.Source = ImageSource.FromResource("AppBancoDigital.Imagens.SuperBoys.ttf");         
        }

        private async void btn_login_Clicked(object sender, EventArgs e)
        {
            carregando.IsRunning = true;
            
            if (txt_cpf.Text == null || txt_senha.Text == null)
            {
                lbl_erro.Text = "Insira o usuário e a senha!";
                carregando.IsRunning = false;
            }
            else
            {
                try
                {
                    Correntista c = await DataServiceCorrentista.Entrar(new Correntista
                    {
                        senha = txt_senha.Text,
                        CPF = txt_cpf.Text.Replace(".", string.Empty).Replace("-", string.Empty)
                    });

                    if (c.Id != null)
                    {
                        App.DadosCorrentista = c;
                        App.Current.MainPage = new NavigationPage(new TelaInicial());

                        //await Navigation.PushAsync(new TelaInicial());

                    }
                    else
                    {
                        lbl_erro.Text = "Usuário ou senha incorretos!";
                            carregando.IsRunning = false;
                    }
                }
                catch (Exception ex)
                {
                    await DisplayAlert("Ops", ex.Message, "OK");
                    Console.WriteLine(ex.StackTrace);
                }
                finally
                {
                    carregando.IsRunning = false;
                }
            }
        }

        private void btnVoltar_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new TelaInicial());
        }
    }
}