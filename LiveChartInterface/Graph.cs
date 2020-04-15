using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveChartInterface
{
    public class Graph
    {
        public string Name { get; set; }
        public string XAxisTitle { get; set; }
        public List<YAxis> YAxes { get; set; }
    }
    public class YAxis
    {
        public string Title { get; set; }
        public string Color { get; set; }
    }
    public class Series
    {
        public string Name { get; set; }
        public string RawDataPointKey { get; set; }
        public string Color { get; set; }
        public int YAxis { get; set; }
    }
}
