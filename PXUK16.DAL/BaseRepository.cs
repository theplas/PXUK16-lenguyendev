﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace PXUK16.DAL
{
    public class BaseRepository
    {
        protected IDbConnection connect;
        public BaseRepository()
        {
            connect = new SqlConnection(@"Data Source=DESKTOP-CM3G3FU\SQLEXPRESS;Initial Catalog=PXUK16DB;Integrated Security=True");
        }
    }
}
