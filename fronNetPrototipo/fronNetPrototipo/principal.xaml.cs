using fronNetPrototipo.VistaModelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace fronNetPrototipo
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class principal : ContentPage
    {
        public principal()
        {
            InitializeComponent();
            BindingContext = new VMprincipal(Navigation);
        }
    }
}