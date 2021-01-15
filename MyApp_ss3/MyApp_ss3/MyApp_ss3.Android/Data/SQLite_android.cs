//using Android.App;
//using Android.Content;
//using Android.OS;
//using Android.Runtime;
//using Android.Views;
//using Android.Widget;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using MyApp_ss3.Data;
//using System.IO;
//using SQLite;
//using Xamarin.Forms;
//using MyApp_ss3.Droid.Data;

//[assembly:Dependency(typeof(SQLite_android)) ]
//namespace MyApp_ss3.Droid.Data
//{
//    public class SQLite_android : ISQLite
//    {
//        public SQLite_android() { }
//        public SQLiteConnection DbConnection()

//        {

//            var dbName = "ProductsDB.db3";

//            var path = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), dbName);

//            return new SQLiteConnection(path);

//        }

//        public SQLiteConnection GetConnection()
//        {
//            throw new NotImplementedException();
//        }
//    }
//}