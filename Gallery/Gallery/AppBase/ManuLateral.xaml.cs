using Gallery.XamarinForms.PaginaCarrosel;
using Gallery.XamarinForms.PaginaConteudo;
using Gallery.XamarinForms.PaginaModal;
using Gallery.XamarinForms.PaginaNavegacao;
using Gallery.XamarinForms.PaginaTab;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Gallery.AppBase
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ManuLateral : MasterDetailPage
    {
        public ManuLateral()
        {
            InitializeComponent();
        }

        private void Fechar(object sender, EventArgs e)
        {
            IsPresented = false;
        }

        private void AbrirContPage(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new PagineConteudo());
            IsPresented = false;
        }

        private void AbrirNavigationPage(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new XamarinForms.PaginaNavegacao.Pagina01());
            IsPresented = false;
        }

        private void AbrirCarrouselPage(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new PaginaCarrousel());
            IsPresented = false;  
        }

        private void AbrirTabbedPage(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new PaginaTabbed());
            IsPresented = false;
        }

        private void AbrirPaginaInicial(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new MainPage());
            IsPresented = false;
        }

        private void AbrirModalpage(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new PaginaModal());
            IsPresented = false;
        }
    }
}