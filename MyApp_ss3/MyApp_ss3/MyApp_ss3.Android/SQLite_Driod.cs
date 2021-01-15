using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SQLite;
using MyApp_ss3.Data;
using System.IO;
using Xamarin.Forms;
using MyApp_ss3.Droid;

[assembly: Dependency(typeof(SQLite_Driod))]
namespace MyApp_ss3.Droid
{
    public class SQLite_Driod : ISQLite
    {
        public SQLiteConnection GetConnection()
        {
            var dbName = "mydatabase.sqlite";
            var dbPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.ApplicationData);
            var path = Path.Combine(dbPath,dbName);
            var conn = new SQLiteConnection(path);
            return conn;
        }
    }
}