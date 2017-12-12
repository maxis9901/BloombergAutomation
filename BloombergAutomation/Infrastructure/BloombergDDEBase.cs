using BloombergAutomation.Infrastructure.Constants;
using BloombergAutomation.Infrastructure.Enums;
using NDde.Client;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsInput;
using WindowsInput.Native;

namespace BloombergAutomation.Infrastructure
{
    public class BloombergDDEBase : IDisposable
    {
        private enum WindowState
        {
            Tiny,
            Small,
            Normal,
            Large,
            FullScreen
        }

        bool disposed = false;

        private DdeClient _dc;
        private IntPtr[] _hwinds = new IntPtr[5];   //use index 1 ~ 4

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposed)
                return;

            if (disposing)
            {

                if (_dc != null)
                {
                    _dc.Disconnect();
                    _dc = null;
                }

            }

            disposed = true;
        }

        public BloombergDDEBase()
        {
            Connect();
        }

        private void Connect()
        {
            _dc = new DdeClient("winblp", "bbk");

            _dc.Connect();

            _hwinds[1] = NativeMethods.FindWindow(null, "1-BLOOMBERG");
            _hwinds[2] = NativeMethods.FindWindow(null, "2-BLOOMBERG");
            _hwinds[3] = NativeMethods.FindWindow(null, "3-BLOOMBERG");
            _hwinds[4] = NativeMethods.FindWindow(null, "4-BLOOMBERG");

        }

        //Input Command 
        public void DDEInputCommand(int windowNum, string commandText)
        {
            if (_dc == null)
            {
                throw new Exception("DDE Server not connected!");
            }

            _dc.Execute(GetDDEWindowNum(windowNum) + commandText, 5000);
        }

        private string GetDDEWindowNum(int windowNum)
        {
            return "<blp-" + (windowNum - 1) + ">";
        }

        public void Sleep(int milliseconds)
        {
            if (milliseconds != 0)
            {
                Thread.Sleep(milliseconds);
            }

        }

        public void Sleep(TimeSpan delay)
        {
            if (delay.TotalMilliseconds != 0)
            {
                Thread.Sleep(delay);
            }

        }

        public async Task SleepAsync(int milliseconds)
        {
            if (milliseconds != 0)
            {
                await Task.Delay(milliseconds);
            }

        }

        public async Task SleepAsync(TimeSpan delay)
        {
            if (delay.TotalMilliseconds != 0)
            {
                await Task.Delay(delay);

            }

        }

        


        

        //Input ISIN and Function, then hit <GO>
        public void InputISINAndFunction(int windowNum, string ISIN, string marketSector, string function)
        {
            string ticker = ISIN + " <" + marketSector + ">" + function;
            string commandString = ticker + BloombergKeys.Go;
            DDEInputCommand(windowNum, commandString);
        }

        // send copy function
        public void CopyScreen(int windowNum)
        {

            DDEInputCommand(windowNum, BloombergKeys.CopyScreen);
        }
        

        // change Bloomberg UI
        public void ChangeLanguage(BloombergLanguage blpLanguage)
        {
            int windowsNum = 1;
            string command;


            // use LANG1, LANG2.... to change UI
            // LANG1 is English , LANG8 is Traditional Chinese
            // After change UI , send  99<GO> to reload Terminal

            command = BloombergFunctions.Language + (int)blpLanguage +
                    BloombergKeys.Go +
                    "99" +
                    BloombergKeys.Go;

            DDEInputCommand(windowsNum, command);

            Sleep(TimeSpan.FromSeconds(5));

        }

        // Login Termial, input id/pwd
        public void InputLoginUser(string userName, string password)
        {
            int windowsNum = 1;

            // Logout first: <CANCEL>OFF<GO>
            DDEInputCommand(windowsNum,
                BloombergKeys.Cancel + BloombergFunctions.Logout + BloombergKeys.Go);

            Sleep(TimeSpan.FromSeconds(3));

            // Login : ON<GO>
            DDEInputCommand(windowsNum,
                BloombergFunctions.Login + BloombergKeys.Go);

            Sleep(TimeSpan.FromSeconds(3));

            // Input Username / Password : {userName}<TABR>{password}<GO>
            DDEInputCommand(windowsNum,
                userName + BloombergKeys.TabRight + password + BloombergKeys.Go);
            Sleep(TimeSpan.FromSeconds(10));
        }

        // simulate mouse click input field, then hit ESC key
        public void ClickAndESCInputField(int windowNum)
        {
            System.Drawing.Point pos;

            // 因為畫面大小不同的情況，輸入資料的欄位位置也會不同,
            // 因此下面用各種不同的視窗大小分別模擬滑鼠點選

            // 模擬 Full Screen(全螢幕) 點選輸入資料的欄位
            pos = GetInputFieldPosition(WindowState.FullScreen);
            ClickAndESCInputField(windowNum, pos.X, pos.Y);

            // 模擬 Tiny(最小螢幕) 點選輸入資料的欄位
            //pos = GetInputFieldPosition(WindowState.Tiny);
            //ClickAndESCInputField(windowNum, pos.X, pos.Y);

            // 模擬 Small(小螢幕) 點選輸入資料的欄位
            //pos = GetInputFieldPosition(WindowState.Small);
            //ClickAndESCInputField(windowNum, pos.X, pos.Y);


            // 模擬 Large(大螢幕) 點選輸入資料的欄位
            //pos = GetInputFieldPosition(WindowState.Large);
            //ClickAndESCInputField(windowNum, pos.X, pos.Y);


            // 模擬 Normal(正常螢幕) 點選輸入資料的欄位
            pos = GetInputFieldPosition(WindowState.Normal);
            ClickAndESCInputField(windowNum, pos.X, pos.Y);


        }


        // 模擬滑鼠點選輸入資料的欄位,再按 ESC 鍵
        // 用於 Bloomberg 卡住無法接收 DDE 資料的情況
        public void ClickAndESCInputField(int windowNum, int posX, int posY)
        {
            // 將 Bloomberg 視窗移至前景,以供後續讓滑鼠 click 輸入資料的欄位
            IntPtr hwnd = SetForegroundWindow(windowNum);

            if (hwnd == IntPtr.Zero)
            {
                return;
            }

            // 將滑鼠要移動的目的位置 x,y 座標由 Pixel 轉換成 0 ~ 65535 的滑鼠座標
            var sim = new InputSimulator();
            System.Drawing.Point point = FormPositionToMouseCoordinate(hwnd, posX, posY);


            sim.Mouse
               .MoveMouseTo(point.X, point.Y)  //移動滑鼠
               .LeftButtonClick()   // 模擬滑鼠點一下畫面
               .Keyboard
               .KeyPress(VirtualKeyCode.ESCAPE)     // 模擬按兩次 ESC 鍵
               .KeyPress(VirtualKeyCode.ESCAPE)
               .Sleep(200);


        }

        public IntPtr SetForegroundWindow(int windowNum)
        {

            IntPtr hwnd = IntPtr.Zero;

            hwnd = _hwinds[windowNum];

            NativeMethods.SetForegroundWindow(hwnd);

            return hwnd;
        }

        // 用 GRAB 指令將畫面透過 EMAIL 傳送
        public void SendMailByGRAB(int windowNum, string recipient, string subject)
        {
            string command;
            //GRAB receipient<GO> subject < GO > 1 < GO >
            command = $"GRAB {recipient} <GO> {subject} <GO> 1 <GO>";
            DDEInputCommand(windowNum, command);

            // GRAB 指令會顯示輸入email的畫面,傳送後仍會停留在email畫面，
            // 因此需用 GO BACK 回到前一畫面
            command = $"GO BACK<GO>";
            DDEInputCommand(windowNum, command);
        }



        /// <summary>
        /// 將 Form 的 X,Y pixel座標轉成滑鼠的 0 ~ 65535 的座標
        /// </summary>
        /// <param name="handle"></param>
        /// <param name="posX"></param>
        /// <param name="posY"></param>
        /// <returns></returns>
        private System.Drawing.Point FormPositionToMouseCoordinate(IntPtr handle, int posX, int posY)
        {
            //  將 Form 的pixel座標轉成桌面pixel座標
            System.Drawing.Point point = new System.Drawing.Point(posX, posY);
            bool result = NativeMethods.ClientToScreen(handle, ref point);
            if (!result)
            {
                throw new Exception("ClientToScreen error");
            }


            // 將 Pixel 轉換成 0 ~ 65535 的座標
            int destX, destY;
            var screenBounds = System.Windows.Forms.Screen.PrimaryScreen.Bounds;
            destX = (int)(point.X * (65535.0f / screenBounds.Width));
            destY = (int)(point.Y * (65535.0f / screenBounds.Height));

            return new System.Drawing.Point(destX, destY);
        }

        // 取得輸入欄位在畫面的座標
        private System.Drawing.Point GetInputFieldPosition(WindowState state)
        {
            System.Drawing.Point pos = new System.Drawing.Point();

            // X 座標設定成同一個位置
            pos.X = 81;

            switch (state)
            {
                case WindowState.Tiny:  //最小螢幕
                    pos.Y = 145;
                    break;
                case WindowState.Small: //小螢幕
                    pos.Y = 120;
                    break;
                case WindowState.Normal:    //正常螢幕
                    pos.Y = 120;
                    break;
                case WindowState.Large:     //大螢幕
                    pos.Y = 110;
                    break;
                case WindowState.FullScreen:    //全螢幕
                    pos.Y = 38;
                    break;
                default:

                    throw new Exception("GetInputFieldPosition() parameter error");
            }

            return pos;
        }
    }
}
