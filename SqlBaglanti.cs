﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace HastaneYönetimiRandevuSistemi
{
    internal class SqlBaglanti
    {
        public SqlConnection Baglanti() 
        { 
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-H345E0I;Initial Catalog=HastaneYonetimiDB;Integrated Security=True");
            conn.Open();
            return conn;
        }
    }
}
