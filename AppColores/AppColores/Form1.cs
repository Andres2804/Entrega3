using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppColores
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            String texto;
            if (chkColor1.Checked == true)
            {
                
                Text = Text + "Amarillo";
                texto = "Amarillo";
                MessageBox.Show(texto);

            }

            if (chkColor2.Checked == true)
            {
                Text = Text + "Azul";
                texto = "Azul";
                MessageBox.Show(texto);
            }

            if (chkColor3.Checked == true)
            {
                Text = Text + "Rojo";
                texto = "Rojo";
                MessageBox.Show(texto);
            }

            
          
        }
    }
}
