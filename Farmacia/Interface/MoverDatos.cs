using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

public class MoverDatos
{
    private string cadenaConexion = "Data Source=LUIK12;Initial Catalog=FarmaciaDB;Integrated Security=True;";

    public void EjecutarSP(string nombreSP, List<SqlParameter> parametros)
    {
        using (SqlConnection conexion = new SqlConnection(cadenaConexion))
        {
            SqlCommand cmd = new SqlCommand(nombreSP, conexion);
            cmd.CommandType = CommandType.StoredProcedure;

            foreach (SqlParameter p in parametros)
            {
                cmd.Parameters.Add(p);
            }

            conexion.Open();
            cmd.ExecuteNonQuery();
        }
    }

    public DataTable MostrarClientes(string consulta)
    {
        using (SqlConnection con = new SqlConnection(cadenaConexion))
        {
            string query = consulta;

            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }
    }
}
