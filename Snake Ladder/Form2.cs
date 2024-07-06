using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake_Ladder
{
    public partial class FormGame : Form
    {
        public int DiceNumber = 0;
        public int PlayerOneLocation = 0;
        public int PlayerTwoLocation = 0;

        public bool playerTurn = false;
        public int playerCounter = 1;

        public FormGame()
        {
            InitializeComponent();
        }

        private void FormGame_Load(object sender, EventArgs e)
        {
            pbPlayerOne.Location = new Point(47, 358);
            pbPlayerTwo.Location = new Point(47, 394);
        }

        private async void btnRoll_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int RandomDiceNumber = random.Next(1, 7);
            switch (RandomDiceNumber)
            {
                case 1:
                    pbDiceOne.Visible = true;
                    pbDiceTwo.Visible = false;
                    pbDiceThree.Visible = false;
                    pbDiceFour.Visible = false;
                    pbDiceFive.Visible = false;
                    pbDiceSix.Visible = false;
                    break;
                case 2:
                    pbDiceOne.Visible = false;
                    pbDiceTwo.Visible = true;
                    pbDiceThree.Visible = false;
                    pbDiceFour.Visible = false;
                    pbDiceFive.Visible = false;
                    pbDiceSix.Visible = false;
                    break;
                case 3:
                    pbDiceOne.Visible = false;
                    pbDiceTwo.Visible = false;
                    pbDiceThree.Visible = true;
                    pbDiceFour.Visible = false;
                    pbDiceFive.Visible = false;
                    pbDiceSix.Visible = false;
                    break;
                case 4:
                    pbDiceOne.Visible = false;
                    pbDiceTwo.Visible = false;
                    pbDiceThree.Visible = false;
                    pbDiceFour.Visible = true;
                    pbDiceFive.Visible = false;
                    pbDiceSix.Visible = false;
                    break;
                case 5:
                    pbDiceOne.Visible = false;
                    pbDiceTwo.Visible = false;
                    pbDiceThree.Visible = false;
                    pbDiceFour.Visible = false;
                    pbDiceFive.Visible = true;
                    pbDiceSix.Visible = false;
                    break;
                case 6:
                    pbDiceOne.Visible = false;
                    pbDiceTwo.Visible = false;
                    pbDiceThree.Visible = false;
                    pbDiceFour.Visible = false;
                    pbDiceFive.Visible = false;
                    pbDiceSix.Visible = true;
                    break;
            }
            playerCounter++;
            playerTurn = playerCounter % 2 == 0;

            if (playerTurn) {
                if (PlayerOneLocation + RandomDiceNumber <= 29) {
                    int newLocation = PlayerOneLocation + RandomDiceNumber;
                    PlayersLocationClass.PlayerOneMove(newLocation, pbPlayerOne);
                    await Task.Delay(1000);

                    PlayerOneLocation = HandleSnakesAndLadders(newLocation, pbPlayerOne, true);
                    if (PlayerOneLocation == 29) {
                        PlayersLocationClass.PlayerOneMove(29, pbPlayerOne);
                        MessageBox.Show("Player One Wins!");
                        btnRoll.Enabled = false;
                        PromptPlayAgain();
                    }
                }
            } else {
                if (PlayerTwoLocation + RandomDiceNumber <= 29) {
                    int newLocation = PlayerTwoLocation + RandomDiceNumber;
                    PlayersLocationClass.PlayerTwoMove(newLocation, pbPlayerTwo);
                    await Task.Delay(1000);

                    PlayerTwoLocation = HandleSnakesAndLadders(newLocation, pbPlayerTwo, false);
                    if (PlayerTwoLocation == 29) {
                        PlayersLocationClass.PlayerTwoMove(29, pbPlayerTwo);
                        MessageBox.Show("Player Two Wins!");
                        btnRoll.Enabled = false;
                        PromptPlayAgain();
                    }
                }
            }
        }

        private void PromptPlayAgain() {
            var result = MessageBox.Show("Do you want to play again?", "Play Again?", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes) {
                ResetGame();
            } else {
                this.Close();
            }
        }

        private void ResetGame() {
            pbPlayerOne.Location = new Point(47, 358);
            pbPlayerTwo.Location = new Point(47, 394);
            PlayerOneLocation = 0;
            PlayerTwoLocation = 0;
            playerTurn = true;

            PlayersLocationClass.PlayerOneMove(PlayerOneLocation, pbPlayerOne);
            PlayersLocationClass.PlayerTwoMove(PlayerTwoLocation, pbPlayerTwo);

            btnRoll.Enabled = true;
        }

        private int HandleSnakesAndLadders(int playerLocation, PictureBox playerPictureBox, bool isPlayerOne)
        {
            // Snakes
            if (playerLocation == 16) playerLocation = 3;
            else if (playerLocation == 18) playerLocation = 6;
            else if (playerLocation == 20) playerLocation = 8;
            else if (playerLocation == 24) playerLocation = 12;
            else if (playerLocation == 26) playerLocation = 1;

            // Ladders
            else if (playerLocation == 2) playerLocation = 15;
            else if (playerLocation == 4) playerLocation = 7;
            else if (playerLocation == 10) playerLocation = 25;
            else if (playerLocation == 19) playerLocation = 28;

            if (isPlayerOne)
            {
                PlayersLocationClass.PlayerOneMove(playerLocation, playerPictureBox);
            }
            else
            {
                PlayersLocationClass.PlayerTwoMove(playerLocation, playerPictureBox);
            }

            return playerLocation;
        }
    }
}
