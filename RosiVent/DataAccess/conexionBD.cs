using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace RosiVent.DataAccess
{
    public class conexionBD
    {
        private SqlConnection cnn;

        public SqlConnection conectar()
        {
            try
            {
                cnn = new SqlConnection();
                cnn.ConnectionString = @"data source=.\SQLEXPRESS;initial catalog=dbventas;user id=sa;password=Root34;";
                cnn.Open();
                return cnn;
            }
            catch
            {
                throw;
            }
        }

        public void desconectar()
        {
            if (cnn.State == System.Data.ConnectionState.Open)
                cnn.Close();
        }
    }
}