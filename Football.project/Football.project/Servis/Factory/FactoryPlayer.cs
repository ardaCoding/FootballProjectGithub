using Football.project.Interfaces;
using Football.project.Model;
using Football.project.Model.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football.project.Servis.Factory
{
public  static class FactoryPlayer
    {

        public static IPlayerManager CreatePlayerManager<TPlayer>() where TPlayer : class
        {
            if (typeof(TPlayer) == typeof(Forvet)) 
                return new ForvetControl();
            if (typeof(TPlayer) == typeof(Midfieler))
                return new MidfielerControl();
            if (typeof(TPlayer) == typeof(Defance))
                return new DefanceControl();

            return null;
        }




    }
}
