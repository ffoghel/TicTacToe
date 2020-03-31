using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{

    public partial class Form1 : Form
    {
        changeName newChange = new changeName();
        bool randomBool()
        {
            Random random = new Random();
            int Bit = random.Next(0, 2);
            Console.WriteLine($"The random number is: {Bit}");
            if (Bit == 1)
            {
                return true;
            }
            else return false;
        }
        string firstPlayer = "Spieler X";
        string secondPlayer = "Spieler O";
        bool playerX;
        int turns = 0;
        int winsPlayerX = 0;
        int winsPlayerO = 0;
        int draws = 0;

        bool isDraw()
        {
            if (turns == 9 && isWinner() == false)
            {
                return true;
            }
            else return false;
        }
        bool isWinner()
        {
            //horizontal
            if (A00.Text != "" && A00.Text == A10.Text && A10.Text == A20.Text)
            {
                return true;
            }
            if (A01.Text != "" && A01.Text == A11.Text && A11.Text == A21.Text)
            {
                return true;
            }
            if (A02.Text != "" && A02.Text == A12.Text && A12.Text == A22.Text)
            {
                return true;
            }

            //vertical
            if (A00.Text != "" && A00.Text == A01.Text && A01.Text == A02.Text)
            {
                return true;
            }
            if (A10.Text != "" && A10.Text == A11.Text && A11.Text == A12.Text)
            {
                return true;
            }
            if (A20.Text != "" && A20.Text == A21.Text && A21.Text == A22.Text)
            {
                return true;
            }

            //diagonal
            if (A00.Text != "" && A00.Text == A11.Text && A11.Text == A22.Text)
            {
                return true;
            }
            if (A20.Text != "" && A20.Text == A11.Text && A11.Text == A02.Text)
            {
                return true;
            }

            else return false;
        }
        public Form1()
        {
            InitializeComponent();
            newGame();
        }
        public Form1(string first_Player, string second_Player)
        {
            InitializeComponent();
            lbl_X.Text = $"Siege {first_Player}: 0";
            lbl_Y.Text = $"Siege {second_Player}: 0";
            firstPlayer = first_Player;
            secondPlayer = second_Player;
            //this.Refresh();
            newGame();
        }

        public void newLabelText()
        {
            lbl_X.Text = $"Siege {firstPlayer}: " + winsPlayerX;
            lbl_Y.Text = $"Siege {secondPlayer}: " + winsPlayerO;
            lbl_draw.Text = "Unentschieden: " + draws;
        }
        private void buttonClick(object sender, EventArgs e)
        {
            Button button = (Button) sender;
            if (button.Text == "")
            {
                if(playerX == true)
                {
                    button.Text = "X";
                    playerX = false;
                    turns++;
                    lbl_actualPlayer.Text = $"{secondPlayer} ist am Zug!";
                }
                else
                {
                    button.Text = "O";
                    playerX = true;
                    turns++;
                    lbl_actualPlayer.Text = $"{firstPlayer} ist am Zug!";
                }
                if (isDraw() == true)
                {
                    lbl_actualPlayer.Text = "";
                    MessageBox.Show("Unentschieden!");
                    draws++;
                    newGame();
                }
                if (isWinner() == true)
                {
                    if (button.Text == "X")
                    {
                        lbl_actualPlayer.Text = "";
                        MessageBox.Show($"{firstPlayer} hat gewonnen!");
                        winsPlayerX++;
                        newGame();
                    }
                    else
                    {
                        lbl_actualPlayer.Text = "";
                        MessageBox.Show($"{secondPlayer} hat gewonnen!");
                        winsPlayerO++;
                        newGame();
                    }
                }
            }
        }

        private void bttn_newGame_Click(object sender, EventArgs e)
        {
            newGame();
        }

        public void newGame()
        {
            playerX = randomBool();
            Console.WriteLine(firstPlayer);
            if (playerX == true)
            {
                lbl_actualPlayer.Text = $"{firstPlayer} ist am Zug!";
            }
            else
            {
                lbl_actualPlayer.Text = $"{secondPlayer} ist am Zug!";
            }
            turns = 0;
            A00.Text = A10.Text = A20.Text = A01.Text = A11.Text = A21.Text = A02.Text = A12.Text = A22.Text = "";

            newLabelText();
        }

        private void bttn_reset_Click(object sender, EventArgs e)
        {
            winsPlayerX = winsPlayerO = draws = 0;
            newGame();
        }

        private void bttn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bttn_changeName_Click(object sender, EventArgs e)
        {
            this.Hide();
            newChange.ShowDialog();
            this.Show();
            //this.SendToBack();
            //this.hideEverything();
        }
        private void hideEverything()
        {
            A00.Hide();
            A01.Hide();
            A02.Hide();
            A10.Hide();
            A11.Hide();
            A12.Hide();
            A20.Hide();
            A21.Hide();
            A22.Hide();
            lbl_actualPlayer.Hide();
            lbl_draw.Hide();
            lbl_X.Hide();
            lbl_Y.Hide();
            bttn_changeName.Hide();
            bttn_newGame.Hide();
            bttn_reset.Hide();
            bttn_close.Hide();
        }

    }
}
