using Football.project.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football.project.Model
{
    public class Forvet : IPlayer
    {
        public string PlayerName { get; set; }
        public int MarketPrice { get; set; }
        public int ShootPower { get; set; }
        public List<string> Teams { get; set; }
    }
}
