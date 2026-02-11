using Guna.UI2.WinForms.Suite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Interface
{
    public partial class empleado1 : UserControl
    {
        public event EventHandler EditarEmpleado;
        public empleado1()
        {
            InitializeComponent();
        }



        public string Nombre
        {
            get { return nombre.Text; }
            set { nombre.Text = value; }
        }

        public string Apellido
        {
            get { return apellido.Text; }
            set { apellido.Text = value; }
        }

        public string Codigo
        {
            get { return codigo.Text; }
            set { codigo.Text = value; }
        }
        public string Cedula
        {
            get { return cedula.Text; }
            set { cedula.Text = value; }
        }

        public string Telefono
        {
            get { return telefono.Text; }
            set { telefono.Text = value; }
        }
        public string Estado
        {
            get { return estado.Text; }
            set { estado.Text = value; }
        }
        public string Cargo
        {
            get { return cargo.Text; }
            set { cargo.Text = value; }
        }

    

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void botoneditar_Click(object sender, EventArgs e)
        {
            EditarEmpleado?.Invoke(this, EventArgs.Empty);

        }

        private void estado_Click(object sender, EventArgs e)
        {

        }

        private void telefono_Click(object sender, EventArgs e)
        {

        }

        private void apellido_Click(object sender, EventArgs e)
        {

        }
    }
}
