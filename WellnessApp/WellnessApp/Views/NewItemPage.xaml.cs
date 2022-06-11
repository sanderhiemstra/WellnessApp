using System;
using System.Collections.Generic;
using System.ComponentModel;
using WellnessApp.Models;
using WellnessApp.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WellnessApp.Views
{
    public partial class NewItemPage : ContentPage
    {
        public Item Item { get; set; }

        public NewItemPage()
        {
            InitializeComponent();
            BindingContext = new NewItemViewModel();
        }
    }
}