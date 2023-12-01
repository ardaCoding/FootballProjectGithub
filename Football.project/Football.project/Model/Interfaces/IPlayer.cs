using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football.project.Interfaces
{
    public interface IPlayer
    {
        string PlayerName { get; set; }
        int MarketPrice { get; set; }

        int ShootPower { get; set; }

        List<string> Teams { get; set; }

    }
}
