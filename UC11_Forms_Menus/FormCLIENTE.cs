using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UC11_Forms_Menus
{
    public partial class FormCLIENTE : Form
    {
        public FormCLIENTE()
        {
            InitializeComponent();
        }

        private void menuENDERECO_Click(object sender, EventArgs e)
        {
            Form telaENDERECO = new FormENDERECO();
            telaENDERECO.MdiParent = this;
            telaENDERECO.Show();
        }
    }
}
