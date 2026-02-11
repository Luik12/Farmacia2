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
    public partial class Reportes : Form
    {
        public Reportes()
        {
            InitializeComponent();
        }
     
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            using (var ventasd = new Ventasdiarias())
            {
                ventasd.ShowDialog();
            }
        }

        private void Reportes_Load(object sender, EventArgs e)
        {

        }

        public void MostrarPanel(bool visible)
        {
            panel2.Visible = visible;
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
          
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            using (var inventario = new Inventario())
            {
                inventario.ShowDialog();
            }
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            using (var reba = new Rebastecimiento())
            {
                reba.ShowDialog();
            }
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            using (var fac = new Rfacturas())
            {
                fac.ShowDialog();
            }
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            using (var cajac = new CierreCaja())
            {
                cajac.ShowDialog();
            }
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            using (var control = new Control())
            {
                control.ShowDialog();
            }
        }

        private void guna2Button9_Click(object sender, EventArgs e)
        {
            using (var seguimiento = new Seguimiento())
            {
                seguimiento.ShowDialog();
            }
        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            using (var compa = new Compras())
            {
                compa.ShowDialog();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button10_Click(object sender, EventArgs e)
        {
            using (var DV = new DetallesVenta())
            {
                DV.ShowDialog();
            }
        }

        private void guna2Button2_Click_1(object sender, EventArgs e)
        {
            using (var RE = new Rempleados())
            {
                RE.ShowDialog();
            }
        }

        private void guna2Button11_Click(object sender, EventArgs e)
        {
            using (var RP = new Rproveedores())
            {
                RP.ShowDialog();
            }
        }

        private void guna2Button12_Click(object sender, EventArgs e)
        {
            using (var RU = new Rusuarios())
            {
                RU.ShowDialog();
            }
        }
    }
}
