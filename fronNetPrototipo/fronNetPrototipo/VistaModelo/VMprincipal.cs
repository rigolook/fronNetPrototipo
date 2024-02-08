using CalculadoraMVVMTriggers_RLG.VistaModelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using fronNetPrototipo.View;

namespace fronNetPrototipo.VistaModelo
{
    public class VMprincipal : BaseViewModel
    {
        #region VARIABLES
        

        #endregion
        #region CONTRUCTOR
        public VMprincipal(INavigation navigation)
        {
            Navigation = navigation;
            
        }
        #endregion
        #region OBJETOS
       

        #endregion
        #region PROCESOS
        public async Task MostrarRegistro()
        {
            
        }
        public  void Insertar()
        {
            Navigation.PushAsync(new Historial());
        }

        
        #endregion
        #region COMANDOS
        //public ICommand Insertarcommand => new Command(async () => await Insertar());
        public ICommand normalcommand => new Command(Insertar);

        #endregion
    }
}
