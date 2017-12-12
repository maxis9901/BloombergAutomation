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
    public partial class frmHP : Form
    {
        public frmHP()
        {
            InitializeComponent();
        }

        private void frmHP_Load(object sender, EventArgs e)
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


            items = new ComboboxItem[]
            {
                new ComboboxItem("BGN", "BGN"),
                new ComboboxItem("BVAL", "BVAL")
            };

            cboPricingSource.Items.Clear();
            cboPricingSource.Items.AddRange(items);

            //Pricing Source default "BGN"
            selectItem = cboPricingSource.Items.Cast<ComboboxItem>().SingleOrDefault(x => x.Value.Equals("BGN"));
            cboPricingSource.SelectedItem = selectItem;


            dtStartDate.Value = DateTime.Today.AddMonths(-1);
            dtEndDate.Value = DateTime.Today;

        }

        private async void btnExecute_Click(object sender, EventArgs e)
        {
            try
            {
                picResult.Image = null;
                txtResult.Text = "";

                string pricingSource = cboPricingSource.SelectedItem.ToString();

                
                List<BloombergTicker> tickers = new List<BloombergTicker>
                {
                    new BloombergTicker {
                        ISIN =txtISIN.Text,
                        MarketSector ="CORP" ,
                        PricingSource = pricingSource
                        }
                };
                

                using (BloombergDDE_HP bloomberg = new BloombergDDE_HP())
                {
                    DateTime pricingStartDate, pricingEndDate;

                    pricingStartDate = dtStartDate.Value;
                    pricingEndDate = dtEndDate.Value;

                    var blpGetDataCallback = new Progress<HPProgressArgs>(BLPDataArrive);
                    int windowNum = int.Parse(cboWindowNum.Text);

                    await bloomberg.ProcessHPAsync(tickers, windowNum, blpGetDataCallback, pricingStartDate, pricingEndDate);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void BLPDataArrive(HPProgressArgs args)
        {

            int winNum = args.Windownum;
            string ISIN = args.ISIN;
            string pricingSource = args.PricingSource;
            Image image = args.Image;
            string text = args.Text;
            bool isSuccess = !args.IsError;
            string errorMessage = args.ErrorMessage;


            if (isSuccess)
            {
                picResult.Image = image;
                txtResult.Text = text;
            }
            else
            {
                // Error handle

            }

        }
    }
}
