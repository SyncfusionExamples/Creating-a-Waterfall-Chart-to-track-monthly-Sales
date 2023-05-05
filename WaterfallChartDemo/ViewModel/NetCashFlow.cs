using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaterfallChartDemo
{
    public class NetCashFlow
    {
        public NetCashFlow()
        {
            Data = new List<NetCashFlowModel>();
            Data.Add(new NetCashFlowModel() { Month = "Jan", Fund = 2500 });
            Data.Add(new NetCashFlowModel() { Month = "Feb", Fund = 2250 });
            Data.Add(new NetCashFlowModel() { Month = "Mar", Fund = -1000 });
            Data.Add(new NetCashFlowModel() { Month = "Apr", Fund = 2300 });
            Data.Add(new NetCashFlowModel() { Month = "May", Fund = 700 });
            Data.Add(new NetCashFlowModel() { Month = "Jun", Fund = -1500 });
            Data.Add(new NetCashFlowModel() { Month = "Jul", Fund = -800 });
            Data.Add(new NetCashFlowModel() { Month = "Aug", Fund = -600 });
            Data.Add(new NetCashFlowModel() { Month = "Sep", Fund = -900 });
            Data.Add(new NetCashFlowModel() { Month = "Oct", Fund = 2250 });
            Data.Add(new NetCashFlowModel() { Month = "Nov", Fund = 1200 });
            Data.Add(new NetCashFlowModel() { Month = "Dec", Fund = -3000 });
            Data.Add(new NetCashFlowModel() { Month = "Total", IsSum = true });
        }
        public List<NetCashFlowModel> Data { get; set; }
    }
}
