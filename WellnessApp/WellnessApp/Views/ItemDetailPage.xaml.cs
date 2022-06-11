using System.ComponentModel;
using WellnessApp.ViewModels;
using Xamarin.Forms;

namespace WellnessApp.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}