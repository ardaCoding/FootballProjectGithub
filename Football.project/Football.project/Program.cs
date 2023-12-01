using Football.project.Interfaces;
using Football.project.Model;
using Football.project.Model.Interfaces;
using Football.project.Servis;
using Football.project.Servis.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football.project
{
    public class Program
    {
        public static void Main(string[] args)
        {


            var midfieler = new Midfieler();
            midfieler.ShootPower = 70;
            midfieler.PlayerName = "Toreira";
            midfieler.Teams = new List<string>
            {
            "Fiorentina",
            "Galatasaray"

            };

            var defance = new Defance();
            defance.ShootPower = 89;
            defance.PlayerName = "Abdulkerim Bardakci";

            SimulateMatch<Defance>(defance);
            SimulateMatch<Midfieler>(midfieler);
        }

        public static void SimulateMatch<TPlayer>(IPlayer player) where TPlayer : class
        {
            var playerManager = FactoryPlayer.CreatePlayerManager<TPlayer>();
            var playerAnalyze = (PlayerAnalyze)playerManager; // dynamic casting
            playerAnalyze.Transfer(player);

            playerManager.Shoot(player);
           
        }










    }
}

