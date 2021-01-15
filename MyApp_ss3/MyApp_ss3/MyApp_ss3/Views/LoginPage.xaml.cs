using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MyApp_ss3.Models;
using MyApp_ss3.Data;
using MyApp_ss3.ViewModels;

namespace MyApp_ss3.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        private SQLiteConnection conn;
        public PeoPle peoPles;
        public LoginPage()
        {
            InitializeComponent();
            this.BindingContext = new LoginViewModel();
            conn = DependencyService.Get<ISQLite>().GetConnection();

            if (conn != null)
            {
                //conn.CreateTable<ListErr>();
                conn.CreateTable<PeoPle>();
            }
        }
        private async void NavigateButton_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Admin());
            //await Navigation.PushModalAsync(new AddListErr());//want to go the previous page
        }
        public bool Check(User user)
        {
            //285589360
            var data = (from li in conn.Table<PeoPle>() where (li.CMND == user.UserName ) select li);
            if(data.Count() > 0)
            {
                if (user.UserName == user.Password)
                {
                    //user.Name=data.f
                    return true;
                }
                    
                else return false;
            }
            return false;
            //DisplayAlert("Welcome", entry_username.Text + " login succesfull!", "Ok");

        }
        public bool check_admin(User user)
        {
            if (user.UserName == user.Password && user.Password == "admin") return true;
            return false;
        }
        public async void  LoginAccount(object sender, EventArgs e)
        {
            User user = new User(entry_username.Text, entry_password.Text);
            if (check_admin(user))
            {
                DisplayAlert("Welcome", entry_username.Text + " login succesfull!", "Ok");
                //Navigation.PushModalAsync(new Admin());//want to go the previous page
                //await Navigation.PushModalAsync(new Admin());//want to go the previous page
                //PushAsync is not supported globally on Android, please use a NavigationPage
                Navigation.PushAsync(new Admin());
            }
            else
            {
                if (Check(user))
                {
                    DisplayAlert("Welcome", entry_username.Text + " login succesfull!", "Ok");
                    //Navigation.PushModalAsync(new UserView());//want to go the previous page
                    //await Navigation.PushModalAsync(new UserView());//want to go the previous page
                    Navigation.PushAsync(new UserView());
                }
                else DisplayAlert("Login", "Login Not correct, Please check again!", "Ok");
            }

        }
    }

}
