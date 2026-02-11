using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface
{
    public partial class Detalles : UserControl
    {
        public Detalles()
        {
            InitializeComponent();
        }
        public string Descricion
        {
            get { return descripcion.Text; }
            set {descripcion.Text = value; }
        }
        public string Precio
        {
            get { return precio.Text; }
            set { precio.Text = value; }
        }
        public string Codigo
        {
            get { return codigo.Text; }
            set { codigo.Text = value; }
        }

        public decimal Cantidad
        {
            get { return cantidad.Value; }
            set { cantidad.Value = value; }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            

        }

        private void edicant_Click(object sender, EventArgs e)
        {
            if (cantidad.Enabled==false)
            {
                cantidad.Enabled = true;

            }
            else { cantidad.Enabled = false; }
        }

        private void eliminarpruduc_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
            this.Dispose();
        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cantidad_ValueChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
