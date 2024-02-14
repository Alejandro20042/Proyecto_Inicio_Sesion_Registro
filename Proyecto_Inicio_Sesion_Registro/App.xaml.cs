using Proyecto_Inicio_Sesion_Registro.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Proyecto_Inicio_Sesion_Registro
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new InicioSesion());
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
