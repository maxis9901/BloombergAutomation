using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloombergAutomation.Infrastructure
{
    public class BloombergTicker
    {
        public string ISIN { get; set; }
        public string MarketSector { get; set; }
        public string PricingSource { get; set; }
    }
}
