using Bushi.Enums;
using Bushi.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bushi.Interfaces
{
    public interface IBasicCard
    {
        Clan Clan { get; }
        Side Side { get; }
        PackInfo PackInfo { get; }
    }
}
