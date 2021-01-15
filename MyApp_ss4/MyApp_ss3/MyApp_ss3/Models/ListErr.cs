using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using MyApp_ss3.Data;
using MyApp_ss3.Models;

namespace MyApp_ss3.Models
{
    public class ListErr
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Moto { get; set; }
        public string Car { get; set; }
        public string Decription { get; set; }
    }


}
