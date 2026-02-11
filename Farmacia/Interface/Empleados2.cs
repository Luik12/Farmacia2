using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Interface.empleado1;

namespace Interface
{
    public partial class Empleados2 : Form
    {
        public Empleados2()
        {
            InitializeComponent();
           
        }

        private void LimpiarCampos()
        {
            codigo1.Clear();
            nombre1.Clear();
            apellido1.Clear();
            cedula1.Clear();
            telefono1.Clear();
            cargo1.Clear();

         
            nombre1.Focus(); 
        }


        private void Empleados2_Load(object sender, EventArgs e)
        {

        }
        private void LlenarEmpleados()
        {
            DBempleados obj = new DBempleados();
    
            
            if (string.IsNullOrWhiteSpace(filtroEmp.Text))
            {
                obj.LlenarBotones(flowLayoutPanel2, "exec sp_VerEmpleados", EditarEmpleado);
            }
            else
            {
                obj.LlenarBotones(
                    flowLayoutPanel2,
                    $"exec sp_BuscarEmpleados '{filtroEmp.Text}'", EditarEmpleado
                );
            }

        }
        private void EditarEmpleado(object sender, EventArgs e)
        {
            empleado1 emp = sender as empleado1;

            codigo1.Text = emp.Codigo;
            nombre1.Text = emp.Nombre;
            apellido1.Text = emp.Apellido;
            cedula1.Text = emp.Cedula;
            telefono1.Text = emp.Telefono;
            cargo1.Text = emp.Cargo;
             estado2.Text = emp.Estado;
            actualizar1.Visible = true;
            agregar1.Visible = false;
            label4.Text = "ACTUALIDAR EMPLEADO";
        }

        private void filtroEmp_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                LlenarEmpleados();
            }
        }

        private void filtroEmp_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {

            if (!Validador.Requerido(nombre1, "El nombre es obligatorio")) return;
            if (!Validador.SoloLetras(nombre1, "El nombre solo debe tener letras")) return;

            if (!Validador.Requerido(apellido1, "El apellido es obligatorio")) return;
            if (!Validador.SoloLetras(apellido1, "El apellido solo debe tener letras")) return;
            if (!Validador.Requerido(cedula1, "La cédula es obligatoria")) return;
            if (!Validador.SoloNumeros(cedula1, "La cédula solo debe tener números")) return;
            if (!Validador.LongitudExacta(cedula1, 11, "La cédula debe tener 11 dígitos")) return;

            if (!Validador.SoloNumeros(telefono1, "El teléfono solo debe tener números")) return;
            if (!Validador.Requerido(cargo1, "El cargo es obligatorio")) return;
            if (!Validador.ComboRequerido(estado2, "Seleccione un estado")) return;



            MoverDatos db = new MoverDatos();

            List<SqlParameter> parametros = new List<SqlParameter>()
    {
        new SqlParameter("@Nombre", nombre1.Text),
        new SqlParameter("@Apellido", apellido1.Text),
        new SqlParameter("@Cedula", cedula1.Text),
        new SqlParameter("@Telefono", telefono1.Text),
        new SqlParameter("@Cargo",cargo1.Text),
        new SqlParameter("@Estado", estado2.Text)
    };

            db.EjecutarSP("dbo.sp_InsertarEmpleado", parametros);
            LimpiarCampos();
            LlenarEmpleados();
        }


        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void actualizar1_Click(object sender, EventArgs e)
        {
            if (!Validador.Requerido(nombre1, "El nombre es obligatorio")) return;
            if (!Validador.SoloLetras(nombre1, "El nombre solo debe tener letras")) return;

            if (!Validador.Requerido(apellido1, "El apellido es obligatorio")) return;
            if (!Validador.SoloLetras(apellido1, "El apellido solo debe tener letras")) return;
            if (!Validador.Requerido(cedula1, "La cédula es obligatoria")) return;
            if (!Validador.SoloNumeros(cedula1, "La cédula solo debe tener números")) return;
            if (!Validador.LongitudExacta(cedula1, 11, "La cédula debe tener 11 dígitos")) return;

            if (!Validador.SoloNumeros(telefono1, "El teléfono solo debe tener números")) return;
            if (!Validador.Requerido(cargo1, "El cargo es obligatorio")) return;
            if (!Validador.ComboRequerido(estado2, "Seleccione un estado")) return;
            MoverDatos db = new MoverDatos();
            actualizar1.Visible = false;
            agregar1.Visible = true;
            label4.Text = "AGREGAR EMPLEADO";


            List<SqlParameter> parametros = new List<SqlParameter>()
    {
        new SqlParameter("@EmpleadoID", int.Parse(codigo1.Text)),
        new SqlParameter("@Nombre", nombre1.Text),
        new SqlParameter("@Apellido", apellido1.Text),
        new SqlParameter("@Cedula", cedula1.Text),
        new SqlParameter("@Telefono", telefono1.Text),
        new SqlParameter("@Cargo",cargo1.Text),
        new SqlParameter("@Estado", estado2.Text)
    };

            db.EjecutarSP("dbo.sp_ActualizarEmpleado", parametros);
            LimpiarCampos();
            LlenarEmpleados();
        }
    }
    
}