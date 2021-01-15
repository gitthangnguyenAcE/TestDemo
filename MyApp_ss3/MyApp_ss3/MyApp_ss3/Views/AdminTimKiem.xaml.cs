using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyApp_ss3.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AdminTimKiem : ContentPage
    {
        public AdminTimKiem()
        {
            InitializeComponent();
        }
        private async void Abutton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SearchPeoPleByBX());
        }
        private async void Bbutton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SearchPeoPleID());
        }
        private async void Cbutton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SearchPeolebyCMND());
        }
        private async void Dbutton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Search());
        }
        private async void Ebutton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SearchXeVP());
        }
        private async void Fbutton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SearchVPbydate());
        }

    }
}