namespace spaceRacers
{
    partial class spaceRacer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(spaceRacer));
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.player1Label = new System.Windows.Forms.Label();
            this.player2Label = new System.Windows.Forms.Label();
            this.winLabel = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // player1Label
            // 
            this.player1Label.AutoSize = true;
            this.player1Label.ForeColor = System.Drawing.Color.White;
            this.player1Label.Location = new System.Drawing.Point(158, 501);
            this.player1Label.Name = "player1Label";
            this.player1Label.Size = new System.Drawing.Size(14, 16);
            this.player1Label.TabIndex = 0;
            this.player1Label.Text = "0";
            // 
            // player2Label
            // 
            this.player2Label.AutoSize = true;
            this.player2Label.ForeColor = System.Drawing.Color.White;
            this.player2Label.Location = new System.Drawing.Point(623, 501);
            this.player2Label.Name = "player2Label";
            this.player2Label.Size = new System.Drawing.Size(14, 16);
            this.player2Label.TabIndex = 1;
            this.player2Label.Text = "0";
            // 
            // winLabel
            // 
            this.winLabel.AutoSize = true;
            this.winLabel.ForeColor = System.Drawing.Color.White;
            this.winLabel.Location = new System.Drawing.Point(362, 133);
            this.winLabel.Name = "winLabel";
            this.winLabel.Size = new System.Drawing.Size(0, 16);
            this.winLabel.TabIndex = 2;
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.ForeColor = System.Drawing.Color.White;
            this.timeLabel.Location = new System.Drawing.Point(381, 501);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(41, 16);
            this.timeLabel.TabIndex = 3;
            this.timeLabel.Text = "Time:";
            // 
            // spaceRacer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(832, 553);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.winLabel);
            this.Controls.Add(this.player2Label);
            this.Controls.Add(this.player1Label);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "spaceRacer";
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.spaceRacer_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.spaceRacer_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.spaceRacer_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label player1Label;
        private System.Windows.Forms.Label player2Label;
        private System.Windows.Forms.Label winLabel;
        private System.Windows.Forms.Label timeLabel;
    }
}

