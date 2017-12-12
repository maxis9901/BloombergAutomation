using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloombergAutomation.Infrastructure.EventArgs
{
    public class ALLQProgressArgs
    {
        public int Windownum { get; set; }
        public string ISIN { get; set; }
        public Image Image { get; set; }
        public string Text { get; set; }
        public bool IsError { get; set; } = false;
        public string ErrorMessage { get; set; }
    }
}
