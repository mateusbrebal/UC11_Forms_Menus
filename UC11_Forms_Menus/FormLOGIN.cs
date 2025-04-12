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
    public partial class FormLOGIN : Form
    {
        public FormLOGIN()
        {
            InitializeComponent();
        }

        private void buttonENTRAR_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form telaPRINCIPAL = new FormPRINCIPAL();
            telaPRINCIPAL.Closed += (s, args) => this.Close();
            telaPRINCIPAL.Show();
        }
    }
}
