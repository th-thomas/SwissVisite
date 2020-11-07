using System;
using System.Windows.Forms;

namespace SwissVisite.Forms
{
    public partial class QuitterForm : Form
    {
        public QuitterForm()
        {
            InitializeComponent();

            ActiveControl = null;
        }

        private void quitterOuiBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void quitterNonBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
