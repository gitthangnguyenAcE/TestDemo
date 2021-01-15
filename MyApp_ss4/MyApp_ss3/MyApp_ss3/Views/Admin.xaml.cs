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
    public partial class Admin : ContentPage
    {
        public Admin()
        {
            InitializeComponent();
        }
            
        private async void Aboutbutton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AdminTimKiem());
        }
        private async void AddListErrbutton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AddListErr());
        }
        private async void Addpeoplebutton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AddPerson());
        }
        private async void SearchListErrbutton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Search());
        }
        private async void SearchErrbutton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SearchXeVP());
        }

        private async void AddErrbutton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new AddXeVP());//want to go the previous page
        }
    }
}