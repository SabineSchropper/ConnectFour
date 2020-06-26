using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectFourData
{
    public class Repository
    {
        ConnectFourEntities entities = new ConnectFourEntities();
        public void AddNewPlayerToDatabase(string playerName)
        {
            Player player = new Player();
            player.name = playerName;
            entities.Player.Add(player);
            entities.SaveChanges();
        }
        public List<Player> GetPlayersFromDatabase()
        {
            List<Player> players = entities.Player.Where(x => x.id != 0).ToList();
            return players;
        }
    }
}
