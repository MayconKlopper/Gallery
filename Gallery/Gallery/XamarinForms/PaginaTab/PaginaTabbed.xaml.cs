﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Gallery.XamarinForms.PaginaTab
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PaginaTabbed : TabbedPage
    {
        public PaginaTabbed()
        {
            InitializeComponent();
        }
    }
}