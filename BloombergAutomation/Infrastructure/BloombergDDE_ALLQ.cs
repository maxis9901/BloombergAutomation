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
    public class BloombergDDE_ALLQ : BloombergDDEBase
    {
        private bool _disposed = false;

        private IProgress<ALLQProgressArgs> _blpGetDataCallback;


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


        public async Task ProcessALLQAsync(List<BloombergTicker> tickers,
                                    int windowNum,
                                    IProgress<ALLQProgressArgs> blpGetDataCallback)
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
                    // input ISIN and ALLQ
                    InputALLQ(windowNum, ticker.ISIN, ticker.MarketSector);

                    // copy screen
                    await GetScreenDataAsync(windowNum, ticker);

                }


            }
            catch (Exception)
            {
                throw;
            }
        }

        // input ISIN and ALLQ
        private void InputALLQ(int windowNum, string ISIN, string marketSector)
        {

            base.InputISINAndFunction(windowNum, ISIN, marketSector, "ALLQ");
        }


        // copy screen
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
            if (_blpGetDataCallback != null)
            {
                ALLQProgressArgs arg = new ALLQProgressArgs();
                arg.Windownum = winNum;
                arg.ISIN = data.ISIN;
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
