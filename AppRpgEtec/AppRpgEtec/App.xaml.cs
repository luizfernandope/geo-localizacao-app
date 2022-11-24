using AppRpgEtec.Views.Personagens;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppRpgEtec
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new ViewModels.Usuarios.LocalizacaoView());
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
