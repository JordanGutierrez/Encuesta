using DataAccess.Seguridad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Administracion;
using SqlDataAccess.Utils;
using System.Data;

namespace SqlDataAccess.Seguridad
{
    public class UsuarioDAO : IUsuarioDAO
    {

        ConsultasSQL sql = new ConsultasSQL();

        public List<Usuario> getAllUsuario(ref string mensaje)
        {
            List<Usuario> usuarios = new List<Usuario>();
            sql = new ConsultasSQL();
            sql.Comando.CommandType = CommandType.StoredProcedure;
            sql.Comando.CommandText = "pa_getAllUsuario";

            try
            {
                IDataReader reader = sql.EjecutaReader(ref mensaje);
                while (reader.Read())
                {
                    usuarios.Add(Usuario.CreateUsuarioFromDataRecord(reader));
                }
            }
            catch (Exception ex)
            {
                mensaje = ex.Message;
            }

            return usuarios;
        }

        public Usuario getUsuario(int id, ref string mensaje)
        {
            throw new NotImplementedException();
        }

        public void insertUsuario(Usuario usuario, string user, ref string mensaje)
        {
            throw new NotImplementedException();
        }

        public void updateUsuario(Usuario usuario, string user, ref string mensaje)
        {
            throw new NotImplementedException();
        }
    }
}
