using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace TechBlogWeb.DAL
{
    public class BaseRepository
    {
        protected IDbConnection connect;
        public BaseRepository()
        {
            connect = new SqlConnection(@"Data Source=DESKTOP-FKE39FG;Initial Catalog=TechBlogDB;Integrated Security=True");
        }
    }
}
