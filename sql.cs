using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hospSystem
{
    public class sql
    {
        public static SqlConnection con = new SqlConnection("Data Source=SERKANKAYA;Initial Catalog=dbo_hospital;Integrated Security=True");
    }
}
