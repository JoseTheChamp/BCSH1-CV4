using GameLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public partial class GameForm : Form
    {
        public GameForm()
        {
            InitializeComponent();
            stats = new GameLibrary.Stats();
            random = new Random();
            stats.UpdatedStats += UpdatedStatsHandler;
            timer1.Tick += Tick;
            gameListBox.KeyDown += input;
        }

        private void UpdatedStatsHandler(object sender, UpdatedStatsEventArgs e)
        {
            correctLabel.Text = "Correct: " + e.Corrcet.ToString();
            missedLabel.Text = "Missed: " + e.Missed.ToString();
            accuracyLabel.Text = "Accuracy: " + e.Accuracy.ToString();
        }

        private void Tick(object sender, EventArgs e) {
            gameListBox.Items.Add(((char)random.Next('a','z')).ToString().ToUpper());                  //((char)(random.Next('a','z').ToString().ToUpper()));
            //System.Diagnostics.Debug.WriteLine("HERE");
            if (gameListBox.Items.Count>6)
            {
                timer1.Stop();
                timerRunning = false;
                gameListBox.Items.Clear();
                gameListBox.Items.Add("GameOver");
            }
        }

        private void input(object sender, System.Windows.Forms.KeyEventArgs e) {
            for (int i = 0; i < gameListBox.Items.Count; i++)
            {
                System.Diagnostics.Debug.Write(gameListBox.Items[i] + "  ");
            }
            System.Diagnostics.Debug.WriteLine("Zmacknuto: " + e.KeyCode);
            if (timerRunning)
            {
                if (gameListBox.Items.Contains(e.KeyCode.ToString()))
                {
                    System.Diagnostics.Debug.WriteLine("ROVNO");
                    stats.Update(true);
                    gameListBox.Items.Remove(e.KeyCode.ToString());
                    gameListBox.Refresh();
                    if (interval > 400)
                    {
                        interval -= 60;
                    }
                    else if (interval > 250)
                    {
                        interval -= 15;
                    }
                    else if (interval > 150)
                    {
                        interval -= 8;
                    }
                    difficultyProgressBar.Value = 800 - interval;
                }
                else
                {
                    stats.Update(false);
                }
            }
            else { 
                timer1.Start();
                gameListBox.Items.Clear();
                stats.Reset();
                timerRunning = true;
            }
        }
    }
}
