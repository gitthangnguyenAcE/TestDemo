using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using MyApp_ss3.Data;
using MyApp_ss3.Models;

namespace MyApp_ss3.Models
{
    public class LoiVP
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string BX { get; set; }
        public string TG_vp { get; set; }
        public string Address { get; set; }
        public int IdVP { get; set; }
        public int money { get; set; }
        public string TT { get; set; }
    }
}
