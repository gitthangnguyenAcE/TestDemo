using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace MyApp_ss3.Data
{
    public interface ISQLite
    {
        SQLiteConnection GetConnection();
    }
}
