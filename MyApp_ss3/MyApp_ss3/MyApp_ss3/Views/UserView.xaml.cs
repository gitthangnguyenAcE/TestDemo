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
    public partial class UserView : ContentPage
    {
        public UserView()
        {
            InitializeComponent();
        }

        private  void Aboutbutton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AdminTimKiem());
            //Navigation.PushModalAsync(new AdminTimKiem());//want to go the previous page
           // await Navigation.PushAsync(new AdminTimKiem());
        }

        private  void Bboutbutton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AdminTimKiem());
            //await Navigation.PushAsync(new AdminTimKiem());
            //Navigation.PushModalAsync(new AdminTimKiem());//want to go the previous page
        }
    }
}