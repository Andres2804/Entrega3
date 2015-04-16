using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppCheck
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (chkOpcion1.Checked == true)
            {
                Text = Text + "Google Chrome";
            }

            if (chkOpcion2.Checked == true)
            {
                Text = Text + "Mozilla Firefox";
            }

            if (chkOpcion3.Checked == true)
            {
                Text = Text + "Spartan";
            }
        }
    }
}
