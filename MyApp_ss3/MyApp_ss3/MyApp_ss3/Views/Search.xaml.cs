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
    public partial class Search : ContentPage
    {
        private SQLiteConnection conn;
        public ListErr ListErrs;
        public List<ListErr> Da;
        public Search()
        {
            InitializeComponent();
            this.BindingContext = new SearchViewModel();
            conn = DependencyService.Get<ISQLite>().GetConnection();
            if (conn != null)
            {
                 conn.CreateTable<ListErr>();
                
            }
            
            LoadData();
            //LoadDataKey(Search_c.Text);
        }
        private void LoadData()
        {
            var data = (from li in conn.Table<ListErr>() select li);
            SuggestionListview.ItemsSource = data;
            //searchResults.ItemsSource = data;
        }
        private string Dd(string a, string b)
        {
            return a + " like '%" + b + "'%";
        }
        private void LoadDataKey( int key)
        {
            //string searchNoSpaces = key.Replace(" ", "%");
            var data = (from li in conn.Table<ListErr>() where(li.ID == key) select li);
            //var data = conn.Table<ListErr>(select * from ListErr)
            SuggestionListview.ItemsSource = data;
        }
        //(li.Name + " like '%" + searchNoSpaces + "%'")
        //private void Search_c_SearchButtonPressed(object sender, EventArgs e)
        //{
        //    var key = Search_c.Text;
        //    if (key == null)
        //    {
        //        LoadData();
        //    }
        //    else
        //    {
        //        LoadDataKey(key);
        //    }
        //}

        private void Search_c_TextChanged(object sender, TextChangedEventArgs e)
        {
            var key = Search_c.Text;
            //int k = Int32.Parse(key);
            if (key.Length <1)
            {
                LoadData();
            }
            else
            {
                LoadDataKey(Int32.Parse(key));
            }
        }
    }
}