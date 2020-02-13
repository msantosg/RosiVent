using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using RosiVent.DataAccess;
using RosiVent.Models;

namespace RosiVent.DataAccess
{
    public class DAOUsuario : conexionBD
    {
        private SqlCommand cmd;
        private SqlDataReader dr;
        
        public int validateUser(Usuario usuario)
        {
            try
            {
                cmd = new SqlCommand();
                cmd.Connection = conectar();
                cmd.CommandTimeout = 60;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM usuario WHERE nombreUsuario = @usuario AND claveUsuario = @clave";
                cmd.Parameters.AddWithValue("@usuario", SqlDbType.VarChar).Value = usuario.nombreUsuario;
                cmd.Parameters.AddWithValue("@clave", SqlDbType.VarChar).Value = usuario.claveUsuario;
                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
            catch
            {
                throw;
            }
            finally
            {
                desconectar();
            }
        }
        
    }
}