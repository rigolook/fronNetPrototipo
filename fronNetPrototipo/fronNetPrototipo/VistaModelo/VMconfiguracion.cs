using CalculadoraMVVMTriggers_RLG.VistaModelo;
using fronNetPrototipo.View;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace fronNetPrototipo.VistaModelo
{
    
    public class VMconfiguracion : BaseViewModel
    {
        #region VARIABLES


        #endregion
        #region CONTRUCTOR
        public VMconfiguracion(INavigation navigation)
        {
            Navigation = navigation;

        }
        #endregion
        #region OBJETOS
        public List<Color> Colores { get; } = new List<Color>
        {
            Color.FromHex("#FFFFFF"), // Color 1
            Color.FromHex("#FDB4FF"),   // Color 2
            Color.FromHex("#1ff299")    // Color 3
            // Puedes agregar más colores si lo deseas
        };
        
        #endregion
        #region PROCESOS
        public async Task MostrarRegistro()
        {

        }
        public void camPagina()
        {
            Navigation.PushAsync(new principal());
        }
        public void ventiladorAutomatico(Button btn)
        {
            bool activo = false;
            if (activo == false)
            {
                btn.BackgroundColor = Color.Black;
                btn.TextColor = Color.FromHex("#1ff299");
                btn.Text = "ON";
                activo = true;
            }
            else if (activo == true) 
            {
                btn.BackgroundColor = Color.FromHex("#FDB4FF");
                btn.TextColor = Color.FromHex("#1ff299");
                btn.Text = "OFF";
                activo = false;
            }
            else
            {
                DisplayAlert("Error", "ocurrio un error", "ok");
            }
        }
        
        #endregion
        #region COMANDOS
        //public ICommand Insertarcommand => new Command(async () => await Insertar());
        public ICommand camPaginacommand => new Command(camPagina);
        public ICommand VentiladorAutomaticoCommand => new Command<Button>((btn) => ventiladorAutomatico(btn));
        #endregion
    }
}
