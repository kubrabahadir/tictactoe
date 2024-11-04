using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{
    public partial class Form1 : Form
    {
        public enum Player
        {
            X, O
        }
        private Player currentPlayer;
        private int playerAScore = 0;
        private int playerBScore = 0;
        
        List<Button> buttons;

        public Form1()
        {
            string scoreFilePath = Directory.GetCurrentDirectory();
            string goBackwardsToProjectRoot = "..\\..\\..\\";
            string fileName = "scores.txt";
            string scoreFullPath = Path.Combine(scoreFilePath, goBackwardsToProjectRoot, fileName);
            ReadFromScoresFile(scoreFullPath);

            InitializeComponent();
            Restart();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
   

        private void ButtonClick(object sender, EventArgs e)
        {
            var button = (Button)sender;
            button.Text = currentPlayer.ToString();
            button.BackColor = Color.White;
            button.Enabled = false;
            buttons.Remove(button);
            CheckGame();
            if (currentPlayer == Player.X)
                currentPlayer = Player.O;
            else
                currentPlayer = Player.X;
        }

        private void Restart(object sender, EventArgs e)
        {
            playerAScore = 0;
            playerBScore = 0;
            string scoreFilePath = Directory.GetCurrentDirectory();
            string goBackwardsToProjectRoot = "..\\..\\..\\";
            string fileName = "scores.txt";
            string scoreFullPath = Path.Combine(scoreFilePath, goBackwardsToProjectRoot, fileName);
            WriteToScoresFile(scoreFullPath);

            Restart();
        }

        private void Restart()
        {
            buttons = new List<Button> { button1, button2, button3, button4, button5, button6, button7, button8, button9 };
            foreach (Button x in buttons)
            {
                x.Enabled = true;
                x.Text = " ";
                x.BackColor = Color.Black;
            }
            currentPlayer = Player.X;
            label1.Text = $"Player A (X) Score: {playerAScore}";
            label2.Text = $"Player B (O) Score: {playerBScore}";
        }

        private void ReadFromScoresFile(string filePath)
        {
            try
            {
                if (File.Exists(filePath))
                {
                    using (StreamReader sr = new StreamReader(filePath))
                    {
                        if (int.TryParse(sr.ReadLine(), out int readScore1))
                        {
                            playerAScore = readScore1;
                        }

                        if (int.TryParse(sr.ReadLine(),out int readScore2))
                        {
                            playerBScore = readScore2;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
            }
        }

        private void WriteToScoresFile(string filePath)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(filePath))
                {
                    sw.WriteLine(playerAScore);
                    sw.WriteLine(playerBScore);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
            }
        }

        private void CheckGame()
        {
            // Yatay, dikey ve çapraz durumları kontrol et
            if (CheckLine(button1, button2, button3) || CheckLine(button4, button5, button6) || CheckLine(button7, button8, button9) ||
                CheckLine(button1, button4, button7) || CheckLine(button2, button5, button8) || CheckLine(button3, button6, button9) ||
                CheckLine(button1, button5, button9) || CheckLine(button3, button5, button7))
            {
                // Kazanan durumu kontrol et
                if (currentPlayer == Player.X)
                    playerAScore++;
                else
                    playerBScore++;

                // Skorları güncelle
                label1.Text = $"PlayerA Score: {playerAScore}";
                label2.Text = $"PlayerB Score: {playerBScore}";

                MessageBox.Show($"{currentPlayer} wins!", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);

                string scoreFilePath = Directory.GetCurrentDirectory();
                string goBackwardsToProjectRoot = "..\\..\\..\\";
                string fileName = "scores.txt";
                string scoreFullPath = Path.Combine(scoreFilePath, goBackwardsToProjectRoot, fileName);
                WriteToScoresFile(scoreFullPath);

                // Oyunu yeniden başlat
                Restart();
            }
            else if (buttons.Count == 0)
            {
                // Berabere durumu kontrol et
                MessageBox.Show("It's a draw!", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Oyunu yeniden başlat
                Restart();
            }
        }
        private bool CheckLine(Button b1, Button b2, Button b3)
        {
            return (b1.Text == currentPlayer.ToString() && b2.Text == currentPlayer.ToString() && b3.Text == currentPlayer.ToString());
        }
    }
}
