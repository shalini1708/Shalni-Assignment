using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhaseEndProject
{
    public  interface ITeam
    {
        void Add(Player player);

        void Remove(int playerId);

        List<Player> GetAllPlayers();

        Player GetPlayerById(int playerId);

        Player GetPlayerByName(string playerName);
        
    }
}
