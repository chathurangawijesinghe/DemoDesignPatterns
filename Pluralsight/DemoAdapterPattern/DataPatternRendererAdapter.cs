using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoAdapterPattern
{
    public class DataPatternRendererAdapter : IDataPatternRendererAdapter
    {
        private DataRenderer dataRenderer;

        public string ListPatterns(IEnumerable<Pattern> patterns)
        {
            dataRenderer = new DataRenderer();
        }
    }
}
