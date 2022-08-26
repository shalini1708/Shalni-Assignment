using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhaseEndProject
{
    public class OneDayTeam:ITeam
    {
        public static List<Player> oneDayTeam = new List<Player>();

        public OneDayTeam()
        {
            oneDayTeam.Capacity = 11;
        }
        public void Add(Player player)
        {
            if (oneDayTeam.Count < 11)
            {
                oneDayTeam.Add(player);
            }
        }

        public void Remove(int playerId)
        {
            var player = oneDayTeam.Where(p => p.PlayerId == playerId).FirstOrDefault();
            oneDayTeam.Remove(player);           
        }
      
        public List<Player> GetAllPlayers()
        {
           return oneDayTeam.ToList();
        }

        public Player GetPlayerById(int playerId)
        {
            var player = oneDayTeam.Where(p=>p.PlayerId==playerId).FirstOrDefault();
            return player;
        }

        public Player GetPlayerByName(string playerName)
        {
            var player = oneDayTeam.Where(p => p.PlayerName == playerName).FirstOrDefault();
            return player;
        }
    }
}
