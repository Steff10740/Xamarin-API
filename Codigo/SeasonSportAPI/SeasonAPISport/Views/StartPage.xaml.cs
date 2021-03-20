﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeasonAPISport.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SeasonAPISport.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StartPage : ContentPage
    {
        public StartPage()
        {
            InitializeComponent();
            BindingContext = new SeasonVM();
        }
    }
}