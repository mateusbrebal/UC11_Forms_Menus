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
    public partial class FormPRINCIPAL : Form
    {
        public FormPRINCIPAL()
        {
            InitializeComponent();
        }

        private void menuCLIENTE_Click(object sender, EventArgs e)
        {
            Form telaCLIENTE = new FormCLIENTE();
            telaCLIENTE.Show();
        }
    }
}
