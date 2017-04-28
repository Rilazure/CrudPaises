using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public class Data
    {
        private SqlConnection cx;
        private void Conexion()
        {
            string cadena = ConfigurationManager.ConnectionStrings["dbz"].ConnectionString;
        }
        public void ConsultarUsuarios()
        {
            Conexion();


        }
    }
}
