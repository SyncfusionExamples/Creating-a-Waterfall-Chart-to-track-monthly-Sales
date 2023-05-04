using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaterfallChartDemo
{
    public class NetCashFlowModel
    {
        public string Month { get; set; }
        public double Fund { get; set; }
        private bool isSum = false;

        public bool IsSum
        {
            get { return isSum; }
            set { isSum = value; }
        }
    }
}
