using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hospSystem
{
    public class dbControl
    {
        public static void check()
        {
            if (sql.con.State != System.Data.ConnectionState.Open)
            {
                sql.con.Open();
            }
        }
    }
}
