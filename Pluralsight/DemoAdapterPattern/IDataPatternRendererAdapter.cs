using System.Collections.Generic;

namespace DemoAdapterPattern
{
    public interface IDataPatternRendererAdapter
    {
        string ListPatterns(IEnumerable<Pattern> patterns);
    }
}