﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Layer
{
    public class ConnectionDB
    {
        public string GetConnection()
        {
            string con = @"Data Source=.\SQLExpress;Initial Catalog=UAS;Integrated Security=True";
            return con;
        }
    }
}
