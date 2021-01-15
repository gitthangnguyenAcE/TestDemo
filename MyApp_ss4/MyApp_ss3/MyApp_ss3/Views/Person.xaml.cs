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

namespace MyApp_ss3.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Person : ContentPage
    {
        private SQLiteConnection conn;
        public ListErr ListErrs;
        public Person Persons;
        public Person()
        {
            InitializeComponent();
            conn = DependencyService.Get<ISQLite>().GetConnection();
            conn.CreateTable<Person>();
            conn.CreateTable<ListErr>();
        }
    }
}