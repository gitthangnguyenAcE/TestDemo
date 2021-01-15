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
    public partial class SearchXeVP : ContentPage
    {
        private SQLiteConnection conn;
        public LoiVP LoiVP;
        public SearchXeVP()
        {
            InitializeComponent();
            conn = DependencyService.Get<ISQLite>().GetConnection();
            if (conn != null)
            {
                conn.CreateTable<LoiVP>();

            }
            LoadData();
        }
        private void LoadData()
        {
            var data = (from li in conn.Table<LoiVP>() select li);
            SuggestionListview.ItemsSource = data;
            //searchResults.ItemsSource = data;
        }
        private void LoadDataKey(string key)
        {
            string searchNoSpaces = key.ToUpper();
            var data = (from li in conn.Table<LoiVP>() where (li.BX == searchNoSpaces) select li);
            //var data = conn.Table<ListErr>(select * from ListErr)
            SuggestionListview.ItemsSource = data;
        }
        private void Search_TextChanged(object sender, TextChangedEventArgs e)
        {
            var key = Search.Text;
            if (key.Length < 1)
            {
                LoadData();
            }
            else
            {
                LoadDataKey(key);
            }
        }
    }
}