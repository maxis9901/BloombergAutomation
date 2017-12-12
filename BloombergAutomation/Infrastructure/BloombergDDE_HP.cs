using BloombergAutomation.Infrastructure.EventArgs;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloombergAutomation.Infrastructure
{
    public class BloombergDDE_HP : BloombergDDEBase
    {
        private bool _disposed = false;

        private IProgress<HPProgressArgs> _blpGetDataCallback;

        // Protected implementation of Dispose pattern.
        protected override void Dispose(bool disposing)
        {
            if (_disposed)
                return;

            if (disposing)
            {

                _blpGetDataCallback = null;
            }

            _disposed = true;
            // Call base class implementation.
            base.Dispose(disposing);
        }


        public async Task ProcessHPAsync(List<BloombergTicker> tickers,
                                    int windowNum,
                                    IProgress<HPProgressArgs> blpGetDataCallback,
                                    DateTime startDate,
                                    DateTime endDate)
        {

            
            if (tickers.Count == 0)
            {
                return;
            }

            try
            {

                _blpGetDataCallback = blpGetDataCallback;

                foreach (BloombergTicker ticker in tickers)
                {
                    // simulate mouse click input field, then hit ESC key
                    base.ClickAndESCInputField(windowNum);

                    // input ISIN and HP
                    InputHP(windowNum, ticker.ISIN, ticker.MarketSector);

                    // input query fields
                    InputQueryFields(windowNum, ticker.PricingSource, startDate, endDate);


                    // copy screen
                    await GetScreenDataAsync(windowNum, ticker);

                }

            }
            catch (Exception)
            {
                throw;
            }

        }

        // input ISIN and HP
        private void InputHP(int windowNum, string ISIN, string marketSector)
        {
        
            base.InputISINAndFunction(windowNum, ISIN, marketSector, "HP");
        }


        // input query fields
        private void InputQueryFields(int windowNum, string pricingSource, DateTime startDate, DateTime endDate)
        {

            string ddeCommand = "";

            //HP<GO><left>BGN<GO><down><down>06012015<TABR>07012015<TABR><TABR>3<TABR>4<GO><COPY><COPY><COPY><COPY>

            ddeCommand = "<TABL>"       // Shift TAB (go to Source field)
                       + pricingSource  // input Pricing Source
                       + "<GO>"         // Hit GO
                       + "<TABR>"       // Hit TAB (go to Securities Name field)
                       + "<TABR>"       // Hit TAB (go to Range start date field)
                       + startDate.ToString("MMddyyyy") // input start date
                       + "<TABR>"       // Hit TAB (go to Range end date field)
                       + endDate.ToString("MMddyyyy")   // input end date
                       + "<TABR>"       // Hit TAB (go to Period field)
                       + "<TABR>"       // Hit TAB (go to first Market field)
                       + "Bid Price"    // input Bid Price
                       + "<TABR>"       // Hit TAB (go to second Market field)
                       + "Ask Price"    // input Ask Price
                       + "<TABL><TABL>" // Hit TAB (go to other field)
                       + "<GO>";        // Query Data

            base.DDEInputCommand(windowNum, ddeCommand);

        }

        // 解析畫面
        private async Task GetScreenDataAsync(int winNum, BloombergTicker processTicker)
        {
            string clipboardText = null;
            Image clipboardImage = null;
            Stopwatch timerRetryCopyWaitTime = new Stopwatch();

            try
            {

                ClipboardHelper.Clear();

                // input copy function
                base.CopyScreen(winNum);
                await SleepAsync(300);

                timerRetryCopyWaitTime.Restart();


                DateTime timeOutDate = DateTime.Now.Add(TimeSpan.FromSeconds(20));


                bool success = false;

                while (!success && (DateTime.Now < timeOutDate))
                {

                    clipboardText = ClipboardHelper.GetText();


                    if (string.IsNullOrEmpty(clipboardText) || clipboardText.Length < 100)
                    {
                        clipboardText = null;
                    }
                    else
                    {
                        clipboardImage = ClipboardHelper.GetImage();
                    }

                    if (clipboardText != null && clipboardImage != null)
                    {
                        success = true;
                    }
                    else
                    {
                        // wait 100 Milliseconds
                        if (DateTime.Now < timeOutDate.AddMilliseconds(100))
                        {
                            await SleepAsync(100);
                        }

                        // resend copy function after 2 seconds
                        if (timerRetryCopyWaitTime.Elapsed.TotalMilliseconds > 2000)
                        {
                            ClipboardHelper.Clear();
                            base.CopyScreen(winNum);
                            await SleepAsync(2000);
                            timerRetryCopyWaitTime.Restart();
                        }
                    }


                }


                // Callback
                if (success)
                {
                    CallBackEvent(winNum, processTicker, clipboardText, clipboardImage, "");
                }
                else
                {
                    CallBackEvent(winNum, processTicker, clipboardText, clipboardImage, "Timeout!");
                }



            }
            catch (Exception ex)
            {
                CallBackEvent(winNum, processTicker, clipboardText, clipboardImage, ex.Message);
                throw;
            }
        }

        private void CallBackEvent(int winNum, BloombergTicker data, string text, Image image, string errorMessage)
        {
            if(_blpGetDataCallback != null)
            {
                HPProgressArgs arg = new HPProgressArgs();
                arg.Windownum = winNum;
                arg.ISIN = data.ISIN;
                arg.PricingSource = data.PricingSource;
                arg.Text = text;
                arg.Image = image;

                if (!string.IsNullOrEmpty(errorMessage))
                {
                    arg.IsError = true;
                    arg.ErrorMessage = errorMessage;
                }

                _blpGetDataCallback.Report(arg);
            }

        }
    }
}
