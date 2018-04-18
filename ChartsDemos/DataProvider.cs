using System;
using System.Collections.Generic;
using System.Linq;

namespace ChartsDemos
{
    public sealed class DataProvider
    {
        public DataProvider(params Double[] values) => data = new List<Double>(values);

        private List<Double> data;

        public List<Double> GetData() => data.Select(x => x).ToList();

        public List<Double> GetDataAsPercent() => data.Select(x => x / data.Sum()).ToList();
    }
}
