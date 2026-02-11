using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Interface
{
    public partial class Pincipal : Form
    {
        // Diccionario para guardar los módulos ya creados
        private Dictionary<string, Form> formularios = new Dictionary<string, Form>();

        public Pincipal()
        {
            InitializeComponent();
            this.DoubleBuffered = true; // evita parpadeo
        }

        // Método central optimizado
        public void AbrirFormEnPanel(string nombre, Func<Form> crearFormulario)
        {
            // Si ya existe, solo lo mostramos
            if (formularios.ContainsKey(nombre))
            {
                Form formExistente = formularios[nombre];
                formExistente.BringToFront();
                formExistente.Show();
                return;
            }

            // Si no existe, lo creamos una sola vez
            Form formHijo = crearFormulario();

            formHijo.TopLevel = false;
            formHijo.FormBorderStyle = FormBorderStyle.None;
            formHijo.Dock = DockStyle.Fill;

            panel5.Controls.Add(formHijo);
            panel5.Tag = formHijo;

            formularios.Add(nombre, formHijo);

            formHijo.Show();
            formHijo.BringToFront();
        }

        private void Pincipal_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            label2.Text = "INICIO";

            guna2Button2.Checked = false;
            guna2Button3.Checked = false;
            guna2Button4.Checked = false;
            guna2Button5.Checked = false;
            guna2Button6.Checked = false;

            // Ocultamos todos los módulos
            foreach (var f in formularios.Values)
            {
                f.Hide();
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            label2.Text = "VENTAS";
            AbrirFormEnPanel("Ventas", () => new Ventas());
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            label2.Text = "PRODUCTOS";
            AbrirFormEnPanel("Productos", () => new Productos());
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            label2.Text = "CLIENTES";
            AbrirFormEnPanel("Clientes", () => new Clientes());
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            label2.Text = "EMPLEADOS";
            AbrirFormEnPanel("Empleados", () => new Empleados2());
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            label2.Text = "CONTROL DE USUARIOS";
            AbrirFormEnPanel("Usuarios", () => new Usuarios());
        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            label2.Text = "REPORTES";
            AbrirFormEnPanel("Reportes", () => new Reportes());
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            label2.Text = "PROVEEDORES";
            AbrirFormEnPanel("Proveedores", () => new Proveedores());
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label4.Text = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss tt");
        }
    }
}
