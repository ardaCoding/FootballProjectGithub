using Football.project.Interfaces;
using Football.project.Servis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football.project.Model
{
    public class DefanceControl : PlayerAnalyze, IPlayerManager
    {
        

       

        public void Shoot(IPlayer player)
            
        {
            Console.WriteLine( player.PlayerName +  " Şuta  Hazırlanıyor");

            if (player.ShootPower > 90)
            {
                
                Console.WriteLine("Gol oldu");


            }
            else { Console.WriteLine("gol olmadı"); }

        }
    }
}
