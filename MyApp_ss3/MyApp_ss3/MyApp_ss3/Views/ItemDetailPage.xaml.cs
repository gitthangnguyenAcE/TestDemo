using MyApp_ss3.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace MyApp_ss3.Views
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