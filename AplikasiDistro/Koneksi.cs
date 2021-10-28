using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;

namespace AplikasiDistro
{
    class Koneksi
    {
        public static MySqlConnection GetConnection()
        {
            string conn = "SERVER = localhost; PORT = 3306; "+
                          "UID = root; PWD = ; DATABASE = distro";

            return new MySqlConnection(conn);
        }
    }
}
