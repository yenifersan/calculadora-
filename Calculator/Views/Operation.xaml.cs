﻿using Calculator.ViewMoldels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Calculator.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Operation : ContentPage
    {
        public Operation()
        {
            InitializeComponent();
            this.BindingContext = new OperacionesViewsModels();
        }
    }
}