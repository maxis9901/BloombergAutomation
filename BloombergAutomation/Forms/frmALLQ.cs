using BloombergAutomation.Infrastructure;
using BloombergAutomation.Infrastructure.EventArgs;
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
    public partial class frmALLQ : Form
    {
        public frmALLQ()
        {
            InitializeComponent();
        }

        private void frmALLQ_Load(object sender, EventArgs e)
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

        private async void btnExecute_Click(object sender, EventArgs e)
        {
            try
            {
                picResult.Image = null;
                txtResult.Text = "";

                List<BloombergTicker> tickers = new List<BloombergTicker>
                {
                    new BloombergTicker {ISIN=txtISIN.Text, MarketSector="CORP" }
                };


                using (BloombergDDE_ALLQ bloomberg = new BloombergDDE_ALLQ())
                {
                    Progress<ALLQProgressArgs> blpGetDataCallback = new Progress<ALLQProgressArgs>(BLPDataArrive);
                    int windowNum = int.Parse(cboWindowNum.Text);

                    await bloomberg.ProcessALLQAsync(tickers, windowNum, blpGetDataCallback);
                }

                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }

        private void BLPDataArrive(ALLQProgressArgs args)
        {

            int winNum = args.Windownum;
            string ISIN = args.ISIN;
            Image image = args.Image;
            string text = args.Text;
            bool isSuccess = !args.IsError;
            string errorMessage = args.ErrorMessage;


            if (isSuccess)
            {
                picResult.Image = image;
                txtResult.Text = text;
            }
            else  // Error
            {
                // error handle
            }

        }

        
    }
}
