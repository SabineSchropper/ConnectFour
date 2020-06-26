using ConnectFourLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ConnectFour
{
    public partial class Player : Form
    {
        Controller controller;
        public Player(Controller controller)
        {
            this.controller = controller;
            InitializeComponent();
            FillComboBoxes();
            
        }
        public void FillComboBoxes()
        {
            List<ConnectFourData.Player> players = controller.FillComboBoxesPlayers();
            comBoPlayer1.DataSource = players;
            comBoPlayer2.DataSource = players;
        }

        private void btnSavePlayers_Click(object sender, EventArgs e)
        {
            ConnectFourData.Player player1 = (ConnectFourData.Player)comBoPlayer1.SelectedItem;
            ConnectFourData.Player player2 = (ConnectFourData.Player)comBoPlayer2.SelectedItem;

            if (player1 != null && player2 != null)
            {
                controller.SetPlayer(player1,player2);
            }
            this.Close();
        }

        private void btnAddPlayer_Click(object sender, EventArgs e)
        {           
            string playerName = tbNewPlayer.Text;
            if (!string.IsNullOrEmpty(playerName))
            {
                controller.AddNewPlayer(playerName);
            }
            else
            {
                MessageBox.Show("Geben Sie den Namen des neuen Spielers ein.");
            }
            FillComboBoxes();

        }
    }
}
