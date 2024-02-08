using fronNetPrototipo.VistaModelo;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace fronNetPrototipo.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Configuracion : ContentPage
    {
        public Configuracion()
        {
            InitializeComponent();
            BindingContext = new VMconfiguracion(Navigation);
        }


        


    }
}