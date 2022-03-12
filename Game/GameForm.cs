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
        }

        private void UpdatedStatsHandler(object sender, UpdatedStatsEventArgs e)
        {
            correctLabel.Text = "Correct: " + e.Corrcet.ToString();
            missedLabel.Text = "Missed: " + e.Missed.ToString();
            accuracyLabel.Text = "Accuracy: " + e.Accuracy.ToString();
        }

        private void Tick(object sender, EventArgs e) {
            gameListBox.Items.Add((char)random.Next('a','z'));
            if (gameListBox.Items.Count>6)
            {
                timer1.Stop();
                gameListBox.Items.Clear();
                gameListBox.Items.Add("GameOver");
            }
        }

        private void KeyDown() { 
        
        }
    }
}
