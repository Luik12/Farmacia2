using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface
{
    public partial class Productos : Form
    {
        public Productos()
        {
            InitializeComponent();
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

 
        

        private void Productos_Load(object sender, EventArgs e)
        {
      
        }


 

        private void guna2CustomGradientPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

    


     

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }


        private void guna2DataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            label6.Text = "ACTUALIZAR PRODUTO";
            guna2Button3.Text = "ACTUALIZAR";
            

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            if (guna2Button3.Text == "ACTUALIZAR")
            {
                label6.Text = "AGREGAR PRODUTO";
                guna2Button3.Text = "AGREGAR";
            }

            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }

}
