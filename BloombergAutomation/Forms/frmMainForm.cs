using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BloombergAutomation.Forms
{
    public partial class frmMainForm : Form
    {

        public frmMainForm()
        {
            InitializeComponent();
        }


        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void menuDDE_Click(object sender, EventArgs e)
        {
            frmDDE objForm = new frmDDE();
            objForm.MdiParent = this;
            objForm.Show();
        }

        private void menuALLQ_Click(object sender, EventArgs e)
        {
            frmALLQ objForm = new frmALLQ();
            objForm.MdiParent = this;
            objForm.Show();
        }

        private void menuHP_Click(object sender, EventArgs e)
        {
            frmHP objForm = new frmHP();
            objForm.MdiParent = this;
            objForm.Show();
        }

        private void menuEmail_Click(object sender, EventArgs e)
        {
            frmEmail objForm = new frmEmail();
            objForm.MdiParent = this;
            objForm.Show();
        }
    }
}
