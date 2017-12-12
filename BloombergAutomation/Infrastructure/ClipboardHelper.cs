using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BloombergAutomation.Infrastructure
{
    public class ClipboardHelper
    {


        public static void Clear()
        {
            try
            {
                Clipboard.Clear();
            }
            catch (Exception)
            {
               
            }
        }

        public static string GetText()
        {
            string result = null;

            try
            {
                if (Clipboard.ContainsText(TextDataFormat.UnicodeText))
                {
                    result = Clipboard.GetText(TextDataFormat.UnicodeText);
                }
                else if (Clipboard.ContainsText(TextDataFormat.Text))
                {
                    result = Clipboard.GetText(TextDataFormat.Text);
                }
                else if (Clipboard.ContainsText(TextDataFormat.Rtf))
                {
                    result = Clipboard.GetText(TextDataFormat.Rtf);
                }
                else if (Clipboard.ContainsText(TextDataFormat.Html))
                {
                    result = Clipboard.GetText(TextDataFormat.Html);
                }

                return result;
            }
            catch (Exception)
            {

                return null;
            }


        }

        public static Image GetImage()
        {
            Image result = null;
            try
            {
                if (Clipboard.ContainsImage())
                {
                    result = Clipboard.GetImage();
                }

                return result;
            }
            catch (Exception)
            {

                return null;
            }

        }
    }
}
