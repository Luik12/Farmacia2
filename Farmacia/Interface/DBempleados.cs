using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface
{
    public class DBempleados 
    {
        private string Nombre;
        private string Apellido;
        private string Codigo;
        private string Cedula;
        private string Telefono;
        private string Estado;
        private string Cargo;

        public string Nombre1 { get => Nombre; set => Nombre = value; }
        public string Apellido1 { get => Apellido; set => Apellido = value; }
        public string Codigo1 { get => Codigo; set => Codigo = value; }
        public string Cedula1 { get => Cedula; set => Cedula = value; }
        public string Telefono1 { get => Telefono; set => Telefono = value; }
        public string Estado1 { get => Estado; set => Estado = value; }
        public string Cargo1 { get => Cargo; set => Cargo = value; }

        SqlConnection conecxion = new SqlConnection ("Data Source=LUIK12;Initial Catalog=FarmaciaDB;Integrated Security=True;");


        public void LlenarBotones(FlowLayoutPanel Contenedor, string cons, EventHandler eventoEditar)
        {
            Contenedor.Controls.Clear();
            conecxion.Open();
            string transactSql = cons;
            SqlCommand comando = new SqlCommand(transactSql, conecxion);
            comando.CommandType = CommandType.Text;
            SqlDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {
                Codigo1 = reader[0].ToString();
                Nombre1 = reader[1].ToString();
                Apellido1 = reader[2].ToString();
                Cedula1 = reader[3].ToString();
                Telefono1 = reader[4].ToString();
                Cargo1 = reader[5].ToString();
                Estado1 = reader[6].ToString();

                empleado1 empleados = new empleado1();
                empleados.Nombre = Nombre1;
                empleados.Apellido= Apellido1;
                empleados.Cedula= Cedula1;
                empleados.Telefono= Telefono1;
                empleados.Cargo= Cargo1;
                empleados.Estado= Estado1;
                empleados.Codigo=  Codigo1;
                empleados.EditarEmpleado += eventoEditar;
                Contenedor.Controls.Add(empleados);
            }
            conecxion.Close();
            conecxion.Dispose();
        }

    }


}
