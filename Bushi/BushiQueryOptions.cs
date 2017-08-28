using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bushi
{
    public class BushiQueryOptions
    {
        public TimeSpan CacheTime { get; private set; }

        public BushiQueryOptions()
        {
            this.SetCacheTime(TimeSpan.FromHours(1));
        }

        public void SetCacheTime(TimeSpan cacheTime)
        {
            this.CacheTime = cacheTime;
        }
    }
}
