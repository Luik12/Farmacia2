using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface
{
    public static class Validador
    {
      
        public static bool Requerido(Guna2TextBox txt, string mensaje)
        {
            if (string.IsNullOrWhiteSpace(txt.Text))
            {
                MessageBox.Show(mensaje, "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

                txt.Focus();
                return false;
            }

            txt.BorderColor = System.Drawing.Color.Silver;
            return true;
        }

        public static bool ComboRequerido(Guna2ComboBox combo, string mensaje)
        {
            if (combo.SelectedIndex == -1 || string.IsNullOrWhiteSpace(combo.Text))
            {
                MessageBox.Show(mensaje, "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

                combo.Focus();
               
                return false;
            }

            
            return true;
        }

  
        public static bool SoloNumeros(Guna2TextBox txt, string mensaje)
        {
            if (!Regex.IsMatch(txt.Text, @"^\d+$"))
            {
                MessageBox.Show(mensaje, "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

                txt.Focus();
              
                return false;
            }

       
            return true;
        }

        
        public static bool LongitudExacta(Guna2TextBox txt, int longitud, string mensaje)
        {
            if (txt.Text.Length != longitud)
            {
                MessageBox.Show(mensaje, "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

                txt.Focus();
                return false;
            }

            return true;
        }

       
        public static bool SoloLetras(Guna2TextBox txt, string mensaje)
        {
            if (!Regex.IsMatch(txt.Text, @"^[a-zA-ZáéíóúÁÉÍÓÚñÑ\s]+$"))
            {
                MessageBox.Show(mensaje, "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

                txt.Focus();
                return false;
            }

            return true;
        }
    }
}
