using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using MyApp_ss3.Data;
using MyApp_ss3.Models;

namespace MyApp_ss3.Models
{
    public class PeoPle
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Name { get; set; }
        public string CMND { get; set; }
        public string Address { get; set; }
        public string BX_Xemay { get; set; }
        public string BX_Oto { get; set; }
        public string Decription { get; set; }
    }
}
