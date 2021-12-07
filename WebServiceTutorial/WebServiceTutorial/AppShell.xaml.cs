﻿using System;
using System.Collections.Generic;
using WebServiceTutorial.ViewModels;
using WebServiceTutorial.Views;
using Xamarin.Forms;

namespace WebServiceTutorial
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

    }
}
