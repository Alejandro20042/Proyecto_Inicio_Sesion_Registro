using Proyecto_Inicio_Sesion_Registro.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Proyecto_Inicio_Sesion_Registro.ViewModel
{
    public class VMpatron : BaseViewModel
    {
        public VMpatron(INavigation navigation)
        {
            Navigation = navigation;
        }

        public async Task Navegar()
        {
            await Navigation.PushAsync(new Registro());
        }


        public ICommand ProcesoNavegarCommand => new Command(async () => await Navegar());
    }
}