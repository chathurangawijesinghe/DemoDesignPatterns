using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoAdapterPattern
{
    public class PatternRenderer
    {
        private readonly IDataPatternRendererAdapter dataPatternRenderer;

        public PatternRenderer(IDataPatternRendererAdapter dataPatternRenderer)
        {
            this.dataPatternRenderer = dataPatternRenderer;
        }

        public string ListPatterns(IEnumerable<Pattern> patterns)
        {
            return dataPatternRenderer.ListPatterns(patterns);
        }
    }
}
