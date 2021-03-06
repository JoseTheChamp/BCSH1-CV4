using GameLibrary;

namespace Game
{
    partial class GameForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gameListBox = new System.Windows.Forms.ListBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.correctLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.missedLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.accuracyLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.difficultyProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gameListBox
            // 
            this.gameListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gameListBox.Font = new System.Drawing.Font("Times New Roman", 85.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gameListBox.FormattingEnabled = true;
            this.gameListBox.ItemHeight = 163;
            this.gameListBox.Location = new System.Drawing.Point(0, 0);
            this.gameListBox.MultiColumn = true;
            this.gameListBox.Name = "gameListBox";
            this.gameListBox.Size = new System.Drawing.Size(1023, 181);
            this.gameListBox.TabIndex = 0;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.correctLabel,
            this.missedLabel,
            this.accuracyLabel,
            this.toolStripStatusLabel4,
            this.difficultyProgressBar});
            this.statusStrip1.Location = new System.Drawing.Point(0, 155);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1023, 26);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // correctLabel
            // 
            this.correctLabel.Name = "correctLabel";
            this.correctLabel.Size = new System.Drawing.Size(91, 20);
            this.correctLabel.Text = "correctLabel";
            // 
            // missedLabel
            // 
            this.missedLabel.Name = "missedLabel";
            this.missedLabel.Size = new System.Drawing.Size(91, 20);
            this.missedLabel.Text = "missedLabel";
            // 
            // accuracyLabel
            // 
            this.accuracyLabel.Name = "accuracyLabel";
            this.accuracyLabel.Size = new System.Drawing.Size(102, 20);
            this.accuracyLabel.Text = "accuracyLabel";
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(622, 20);
            this.toolStripStatusLabel4.Spring = true;
            this.toolStripStatusLabel4.Text = "Difficulty:";
            this.toolStripStatusLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // difficultyProgressBar
            // 
            this.difficultyProgressBar.Maximum = 800;
            this.difficultyProgressBar.Name = "difficultyProgressBar";
            this.difficultyProgressBar.Size = new System.Drawing.Size(100, 18);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 800;
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 181);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.gameListBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GameForm";
            this.Text = "GameForm";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox gameListBox;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel correctLabel;
        private ToolStripStatusLabel missedLabel;
        private ToolStripStatusLabel accuracyLabel;
        private ToolStripStatusLabel toolStripStatusLabel4;
        private ToolStripProgressBar difficultyProgressBar;
        private System.Windows.Forms.Timer timer1;

        private Random random;
        private Stats stats;
        private int difficultyMax = 654;
        private int interval = 800;
        private bool timerRunning= true;



    }
}