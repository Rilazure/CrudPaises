using Dal;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bel
{
    public class Bll
    {
        Data Dl = new Data();

        public DataTable ConsultarUsuariosB()
        {
            return Dl.ConsultarUsuarios();
        }
        public void InsertUsuarioB(string Nombre,int Fk_Ciudad)
        {
            Dl.insertarUsuario(Nombre,Fk_Ciudad);
        }
        public void ActualizarB(int IdUsuario)
        {
            Dl.Actualizar(IdUsuario);
        }
        public void EliminarB(int IdUsuario)
        {
            Dl.Eliminar(IdUsuario);
        }
        public DataTable CargarDrlB()
        {
            return Dl.CargarDrl();
        }
        public DataTable CargarDrlCiudades(int index)
        {
            return Dl.CargarDrlCiudades(index);
        }
    }
}
