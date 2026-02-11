using Guna.UI2.WinForms;
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

namespace Interface
{
    public partial class Proveedores : Form
    {
        public Proveedores()
        {
            InitializeComponent();

            tablaprovee1.ReadOnly = true; 
            tablaprovee1.AllowUserToAddRows = false;
            tablaprovee1.AllowUserToDeleteRows = false;
            tablaprovee1.AllowUserToResizeRows = false;

        }
        MoverDatos mover = new MoverDatos();
        private void Limpiar()
        {
            nombre1.Clear();
            rnc1.Clear();
            contacto1.Clear();
            telefono1.Clear();
            correo1.Clear();

        }
        private void CargarClientes()
        {
            if (string.IsNullOrWhiteSpace(filtro1.Text))
            {
                tablaprovee1.DataSource = mover.MostrarClientes("exec SP_MostrarProveedores");
                tablaprovee1.Columns["Editar2"].DisplayIndex = tablaprovee1.Columns.Count - 1;
            }
            else {
                tablaprovee1.DataSource = mover.MostrarClientes($"SP_BuscarProveedores '{filtro1.Text}'");
                tablaprovee1.Columns["Editar2"].DisplayIndex = tablaprovee1.Columns.Count - 1;
            }
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void agregar1_Click(object sender, EventArgs e)
        {
            if (!Validador.Requerido(nombre1,"el NOMBRE no puede estar vacio")) return ;
            if (!Validador.Requerido(rnc1, "el RNC no puede estar vacio")) return;
            if (!Validador.SoloNumeros(rnc1, "el RNC solo permite numeros")) return;
            if (!Validador.Requerido(contacto1, "el CONTACTO no puede estar vacio")) return;
            if (!Validador.Requerido(telefono1, "el TELEFONO no puede estar vacio")) return;
            if (!Validador.SoloNumeros(telefono1, "el TELEFONO solo permite numeros")) return;
            if (!Validador.Requerido(correo1, "el CORREO no puede estar vacio")) return;
            MoverDatos db = new MoverDatos();

            List<SqlParameter> parametros = new List<SqlParameter>()
    {
        new SqlParameter("@Nombre", nombre1.Text),
        new SqlParameter("@RFC", rnc1.Text),
        new SqlParameter("@Contacto", contacto1.Text),
        new SqlParameter("@Telefono", telefono1.Text),
        new SqlParameter("@Correo",correo1.Text),
        new SqlParameter("@Estado", estado2.Text)
    };

            db.EjecutarSP("dbo.SP_AgregarProveedor", parametros);
            CargarClientes();
            Limpiar();
        }



        private void Proveedores_Load(object sender, EventArgs e)
        {
        
        }

        private void tablaprovee1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var fila = tablaprovee1.Rows[e.RowIndex];

            if (tablaprovee1.Columns[e.ColumnIndex].Name == "Editar2")
            {
                ide1.Text = fila.Cells["ProveedorID"].Value?.ToString();
                nombre1.Text = fila.Cells["Nombre"].Value?.ToString();
                rnc1.Text = fila.Cells["RFC"].Value?.ToString();
                telefono1.Text = fila.Cells["Telefono"].Value?.ToString();
                correo1.Text = fila.Cells["Correo"].Value?.ToString();
                contacto1.Text = fila.Cells["Contacto"].Value?.ToString(); 
                estado2.Text = fila.Cells["Estado"].Value?.ToString();
                label4.Text = "ACTUALIZAR PROVEEDOR";
                actualizar1.Visible = true;
                agregar1.Visible = false;
            }
        }

        private void guna2TextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CargarClientes();
            }
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

            if (!Validador.Requerido(nombre1, "el NOMBRE no puede estar vacio")) return;
            if (!Validador.Requerido(rnc1, "el RNC no puede estar vacio")) return;
            if (!Validador.SoloNumeros(rnc1, "el RNC solo permite numeros")) return;
            if (!Validador.Requerido(contacto1, "el CONTACTO no puede estar vacio")) return;
            if (!Validador.Requerido(telefono1, "el TELEFONO no puede estar vacio")) return;
            if (!Validador.SoloNumeros(telefono1, "el TELEFONO solo permite numeros")) return;
            if (!Validador.Requerido(correo1, "el CORREO no puede estar vacio")) return;
            MoverDatos db = new MoverDatos();

            List<SqlParameter> parametros = new List<SqlParameter>()
    {
        new SqlParameter("@Nombre", nombre1.Text),
        new SqlParameter("@RFC", rnc1.Text),
        new SqlParameter("@Contacto", contacto1.Text),
        new SqlParameter("@Telefono", telefono1.Text),
        new SqlParameter("@Correo",correo1.Text),
        new SqlParameter("@ProveedorID",ide1.Text),
        new SqlParameter("@Estado", estado2.Text)
    };

            db.EjecutarSP("dbo.SP_ActualizarProveedor", parametros);
            CargarClientes();
            Limpiar();
            actualizar1.Visible = false;
            agregar1.Visible = true;
            label4.Text = "AGREGAR PROVEEDOR";

        }
    }
}
