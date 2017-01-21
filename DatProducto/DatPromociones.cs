using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opticx.Productos.Data
{
    public class DatPromociones:DatAbstracta
    {
        public DataTable TopCincoPromociones()
        {
            SqlCommand com = new SqlCommand("spTopCinco", con);
            com.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }

    }
}
