using Football.project.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football.project.Servis
{
    public abstract class PlayerAnalyze
    {
       
        public virtual void Transfer(IPlayer player)
        {
            Console.WriteLine(player.PlayerName + " Oyuncusunun oynadığı takımlar: ");
            if (player.Teams != null)
            {

                foreach (var team in player.Teams)
                {
                    Console.WriteLine(team);

                }
            }

            else
            {
                Console.WriteLine("oyuncunun geçmişi bulunamadı");
            }


        }
    }
}
