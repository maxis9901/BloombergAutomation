using BloombergAutomation.Infrastructure;
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
    public partial class frmEmail : Form
    {
        public frmEmail()
        {
            InitializeComponent();
        }

        private void frmEmail_Load(object sender, EventArgs e)
        {
            ComboboxItem[] items = new ComboboxItem[]
            {
                new ComboboxItem("1", "1"),
                new ComboboxItem("2", "2"),
                new ComboboxItem("3", "3"),
                new ComboboxItem("4", "4"),
            };

            cboWindowNum.Items.Clear();
            cboWindowNum.Items.AddRange(items);

            //Window Num default "1"
            ComboboxItem selectItem = cboWindowNum.Items.Cast<ComboboxItem>().SingleOrDefault(x => x.Value.Equals("1"));
            cboWindowNum.SelectedItem = selectItem;
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            using (BloombergDDEBase bloombergDDE = new BloombergDDEBase())
            {
                int windowNum = int.Parse(cboWindowNum.Text);

                bloombergDDE.SendMailByGRAB(windowNum, txtRecipient.Text, txtSubject.Text);
            }
        }

        
    }
}
