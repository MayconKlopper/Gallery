using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Gallery.XamarinForms.PaginaModal
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PaginaModal : ContentPage
    {
        public PaginaModal()
        {
            InitializeComponent();
        }

        private void AbrirModal(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new Pagina01());
        }
    }
}