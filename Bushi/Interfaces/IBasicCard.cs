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
        CardType Type { get; }
        Clan Clan { get; }
        Side Side { get; }
        string Name { get; }
        PackInfo PackInfo { get; }
    }
}
