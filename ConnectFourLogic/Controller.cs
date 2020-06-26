using ConnectFourData;
using System;
using System.Collections.Generic;

namespace ConnectFourLogic
{
    public class Controller
    {
        public Player Player1;
        public Player Player2;
        List<Player> players = new List<Player>();
        Repository repository = new Repository();
        public List<Player> FillComboBoxesPlayers()
        {
            List<Player> allPlayers = repository.GetPlayersFromDatabase();
            this.players = allPlayers;
            return allPlayers;
        }
        public void AddNewPlayer(string playerName)
        {
            repository.AddNewPlayerToDatabase(playerName);
        }
        public void SetPlayer(Player player1, Player player2)
        {
            Player1 = player1;
            Player2 = player2;
        }
       
    }
}
