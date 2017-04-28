using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
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
            cx = new SqlConnection(cadena);
        }
        public DataTable ConsultarUsuarios()
        {
            Conexion();
            SqlCommand cmd = new SqlCommand("select * from Usuario",cx);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet dt = new DataSet();
            cx.Open();
            da.Fill(dt);
            return dt.Tables[0];
        }
        public void insertarUsuario(string Nombre,int Fk_Ciudad)
        {
            Conexion();
            SqlCommand cmd = new SqlCommand("insert into Usuario values (@Nombre,@Fk_Ciudad)", cx);
            cx.Open();
            cmd.Parameters.AddWithValue("@Nombre", Nombre);
            cmd.Parameters.AddWithValue("@Fk_Ciudad", Fk_Ciudad);
            cmd.ExecuteNonQuery();
        }
        public void Actualizar(int IdUsuario )
        {
            Conexion();
            SqlCommand cmd = new SqlCommand("SpActualizar", cx);
            cmd.CommandType = CommandType.StoredProcedure;
            cx.Open();
            cmd.Parameters.AddWithValue("@IdUsuario", IdUsuario);
            cmd.ExecuteNonQuery();
        }
        public void  Eliminar(int IdUsuario)
        {
            Conexion();
            SqlCommand cmd = new SqlCommand("delete from Usuario where IdUsuario = @IdUsuario", cx);
            cx.Open();            
            cmd.Parameters.AddWithValue("@IdUsuario", IdUsuario);
            cmd.ExecuteNonQuery();
        }
        public DataTable CargarDrl()
        {
            Conexion();
            SqlCommand cmd = new SqlCommand("select * from Pais", cx);
            
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet dt = new DataSet();
            
            da.Fill(dt);
            return dt.Tables[0];
        }

        public DataTable CargarDrlCiudades(int index)
        {
            Conexion();
            SqlCommand cmd = new SqlCommand("select * from Ciudad where Fk_Pais =  @Fk_Pais ", cx);
            cmd.Parameters.AddWithValue("@Fk_Pais", index);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet dt = new DataSet();

            da.Fill(dt);
            return dt.Tables[0];
        }


        

    }
}
