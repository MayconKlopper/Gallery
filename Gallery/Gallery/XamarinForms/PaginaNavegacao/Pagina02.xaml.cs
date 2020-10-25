using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Gallery.XamarinForms.PaginaNavegacao
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Pagina02 : ContentPage
    {
        public Pagina02()
        {
            InitializeComponent();
        }

        private void ProximaPagina(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Pagina03());
        }

        private void PaginaAnterior(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }

        private void PaginaInicial(object sender, EventArgs e)
        {
            Navigation.PopToRootAsync();
        }
    }
}