using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using System.Windows.Forms;

namespace Interface
{
    public partial class Ventas : Form
    {
        public Ventas()
        {
            InitializeComponent();
        }



  

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Ventas_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void guna2TextBox1_Leave(object sender, EventArgs e)
        {
            panel5.Visible=false;

        }

        private void guna2TextBox1_anged(object sender, EventArgs e)
        {
            panel5.Visible = true;
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2TextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Detalles detale = new Detalles();
                detale.Dock = DockStyle.Top;     
                panel11.Controls.Add(detale);
                detale.SendToBack();
           

            }
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            panel11.Controls.Clear();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            fecha.Text = DateTime.Now.ToString("dd/MM/yyyy");   // F
            hora.Text = DateTime.Now.ToString("HH:mm:ss");     
        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
