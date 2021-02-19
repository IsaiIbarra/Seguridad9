using System;
using System.Data;
using System.Data.SqlClient;
using Seguridad9.Clases;

namespace Seguridad9.Procedimiento
{
    public static class SPHelper
    {
        public static void InsertarMandado(Mandado mandadito)
        {
            FormPrincipal nuevo = new FormPrincipal();
            Boolean validarCatch = true;


            string connString = "Data Source=DESKTOP-JK1SJNS;Initial Catalog=Test1;Integrated Security=True;";

            SqlConnection connSQL = new SqlConnection(connString);

            try
            {
                connSQL.Open();

                SqlCommand cmdProcedimiento = new SqlCommand("InsertarMandado", connSQL)
                {
                    CommandType = CommandType.StoredProcedure
                };

                cmdProcedimiento.Parameters.AddWithValue("producto", mandadito.Nombre);
                cmdProcedimiento.Parameters.AddWithValue("cantidad", mandadito.Cantidad);

                cmdProcedimiento.ExecuteNonQuery();
            }
            catch (SqlException sqlEx)
            {
                validarCatch = false;
                throw;
            }
            finally
            {
                connSQL.Close();
            }

            if (validarCatch)
            {
                nuevo.errorUsuario(validarCatch);
            }
            else
            {
                nuevo.errorUsuario(validarCatch);
                validarCatch = true;
            }
        }
    }
}
