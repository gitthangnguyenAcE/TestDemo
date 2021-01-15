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
    public partial class SearchPeoPleByBX : ContentPage
    {
        private SQLiteConnection conn;
        public PeoPle peoPles;
        public SearchPeoPleByBX()
        {
            InitializeComponent();
            conn = DependencyService.Get<ISQLite>().GetConnection();
            if (conn != null)
            {
                conn.CreateTable<PeoPle>();

            }
            LoadData();
        }
        private void LoadData()
        {
            var data = (from li in conn.Table<PeoPle>() select li);
            SuggestionListview.ItemsSource = data;
            //searchResults.ItemsSource = data;
        }
        private void LoadDataKey(string key)
        {
            //string searchNoSpaces = key.Replace(" ", "%");
            key = key.ToUpper();
            var data = (from li in conn.Table<PeoPle>() where ((li.BX_Xemay == key) || (li.BX_Oto ==key)) select li);
            //var data = conn.Table<ListErr>(select * from ListErr)
            SuggestionListview.ItemsSource = data;
        }
        private void Search_c_TextChanged(object sender, TextChangedEventArgs e)
        {
            var key = Search_c.Text;
            //int k = Int32.Parse(key);
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