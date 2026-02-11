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
    public partial class CierreCaja : Form
    {
        public CierreCaja()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            label8.Text = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss tt");
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            timer1.Start(); 
        }
    }
}
