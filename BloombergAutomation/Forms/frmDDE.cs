using BloombergAutomation.Infrastructure;
using BloombergAutomation.Infrastructure.Enums;
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
    public partial class frmDDE : Form
    {

        public frmDDE()
        {
            InitializeComponent();
        }

        private void frmDDE_Load(object sender, EventArgs e)
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

                LogPrint("Execute Command:" + txtCommand.Text);

                bloombergDDE.DDEInputCommand(windowNum, txtCommand.Text);

            }


        }

        private void LogPrint(string msg)
        {
            txtMessage.AppendText(msg);
            txtMessage.AppendText(Environment.NewLine);
        }

        private void btnCopyScreen_Click(object sender, EventArgs e)
        {
            using (BloombergDDEBase bloombergDDE = new BloombergDDEBase())
            {
                int windowNum = int.Parse(cboWindowNum.Text);

                LogPrint("Before Execute Command: <COPY>");

                bloombergDDE.CopyScreen(windowNum);

                LogPrint("After Execute Command: <COPY>");
            }
        }

        private void btnReLogin_Click(object sender, EventArgs e)
        {
            using (BloombergDDEBase bloombergDDE = new BloombergDDEBase())
            {
                LogPrint("Before Login");
                bloombergDDE.InputLoginUser("YourId", "YourPassword");
                LogPrint("After Login");
            }
        }


        private void btnChangeLanguageToEnglish_Click(object sender, EventArgs e)
        {
            using (BloombergDDEBase bloombergDDE = new BloombergDDEBase())
            {

                bloombergDDE.ChangeLanguage(BloombergLanguage.English);

            }
        }

        private void btnChangeLanguageToChinese_Click(object sender, EventArgs e)
        {
            using (BloombergDDEBase bloombergDDE = new BloombergDDEBase())
            {

                bloombergDDE.ChangeLanguage(BloombergLanguage.TraditionalChinese);

            }
        }
    }
}
