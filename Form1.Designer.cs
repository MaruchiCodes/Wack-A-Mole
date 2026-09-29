namespace Lab2
{
    partial class Form1
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
            this.buttonStartGame = new System.Windows.Forms.Button();
            this.buttonResetGame = new System.Windows.Forms.Button();
            this.wackAMoleLabel = new System.Windows.Forms.Label();
            this.hole1 = new System.Windows.Forms.PictureBox();
            this.hole2 = new System.Windows.Forms.PictureBox();
            this.hole3 = new System.Windows.Forms.PictureBox();
            this.hole4 = new System.Windows.Forms.PictureBox();
            this.hole5 = new System.Windows.Forms.PictureBox();
            this.hole6 = new System.Windows.Forms.PictureBox();
            this.hole7 = new System.Windows.Forms.PictureBox();
            this.hole8 = new System.Windows.Forms.PictureBox();
            this.hole9 = new System.Windows.Forms.PictureBox();
            this.buttonExit = new System.Windows.Forms.Button();
            this.labelWelcome = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.labelPlayerInfo = new System.Windows.Forms.Label();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.labelScore = new System.Windows.Forms.Label();
            this.labelScoreBox = new System.Windows.Forms.Label();
            this.labelhole = new System.Windows.Forms.Label();
            this.buttonMoveMole = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.hole1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hole2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hole3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hole4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hole5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hole6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hole7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hole8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hole9)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonStartGame
            // 
            this.buttonStartGame.BackColor = System.Drawing.Color.Green;
            this.buttonStartGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStartGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonStartGame.Location = new System.Drawing.Point(260, 407);
            this.buttonStartGame.Name = "buttonStartGame";
            this.buttonStartGame.Size = new System.Drawing.Size(100, 65);
            this.buttonStartGame.TabIndex = 0;
            this.buttonStartGame.Text = "Start Game";
            this.buttonStartGame.UseVisualStyleBackColor = false;
            this.buttonStartGame.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonResetGame
            // 
            this.buttonResetGame.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonResetGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonResetGame.Location = new System.Drawing.Point(471, 407);
            this.buttonResetGame.Name = "buttonResetGame";
            this.buttonResetGame.Size = new System.Drawing.Size(100, 65);
            this.buttonResetGame.TabIndex = 2;
            this.buttonResetGame.Text = "Reset Game";
            this.buttonResetGame.UseVisualStyleBackColor = false;
            // 
            // wackAMoleLabel
            // 
            this.wackAMoleLabel.AutoSize = true;
            this.wackAMoleLabel.BackColor = System.Drawing.Color.Transparent;
            this.wackAMoleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F);
            this.wackAMoleLabel.Location = new System.Drawing.Point(248, 9);
            this.wackAMoleLabel.Name = "wackAMoleLabel";
            this.wackAMoleLabel.Size = new System.Drawing.Size(352, 63);
            this.wackAMoleLabel.TabIndex = 3;
            this.wackAMoleLabel.Text = "Wack-A-Mole";
            this.wackAMoleLabel.Click += new System.EventHandler(this.wackAMoleLabel_Click);
            // 
            // hole1
            // 
            this.hole1.BackgroundImage = global::Lab2.Properties.Resources.hole;
            this.hole1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.hole1.Location = new System.Drawing.Point(260, 89);
            this.hole1.Name = "hole1";
            this.hole1.Size = new System.Drawing.Size(100, 100);
            this.hole1.TabIndex = 4;
            this.hole1.TabStop = false;
            this.hole1.Click += new System.EventHandler(this.Whole1_Click);
            // 
            // hole2
            // 
            this.hole2.BackgroundImage = global::Lab2.Properties.Resources.hole;
            this.hole2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.hole2.Location = new System.Drawing.Point(366, 89);
            this.hole2.Name = "hole2";
            this.hole2.Size = new System.Drawing.Size(100, 100);
            this.hole2.TabIndex = 5;
            this.hole2.TabStop = false;
            this.hole2.Click += new System.EventHandler(this.Whole2_Click);
            // 
            // hole3
            // 
            this.hole3.BackgroundImage = global::Lab2.Properties.Resources.hole;
            this.hole3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.hole3.Location = new System.Drawing.Point(471, 89);
            this.hole3.Name = "hole3";
            this.hole3.Size = new System.Drawing.Size(100, 100);
            this.hole3.TabIndex = 6;
            this.hole3.TabStop = false;
            this.hole3.Click += new System.EventHandler(this.Whole3_Click_1);
            // 
            // hole4
            // 
            this.hole4.BackgroundImage = global::Lab2.Properties.Resources.hole;
            this.hole4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.hole4.Location = new System.Drawing.Point(260, 197);
            this.hole4.Name = "hole4";
            this.hole4.Size = new System.Drawing.Size(100, 100);
            this.hole4.TabIndex = 7;
            this.hole4.TabStop = false;
            this.hole4.Click += new System.EventHandler(this.Whole4_Click);
            // 
            // hole5
            // 
            this.hole5.BackgroundImage = global::Lab2.Properties.Resources.hole;
            this.hole5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.hole5.Location = new System.Drawing.Point(366, 197);
            this.hole5.Name = "hole5";
            this.hole5.Size = new System.Drawing.Size(100, 100);
            this.hole5.TabIndex = 8;
            this.hole5.TabStop = false;
            this.hole5.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // hole6
            // 
            this.hole6.BackgroundImage = global::Lab2.Properties.Resources.hole;
            this.hole6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.hole6.Location = new System.Drawing.Point(471, 197);
            this.hole6.Name = "hole6";
            this.hole6.Size = new System.Drawing.Size(100, 100);
            this.hole6.TabIndex = 9;
            this.hole6.TabStop = false;
            this.hole6.Click += new System.EventHandler(this.Whole5_Click);
            // 
            // hole7
            // 
            this.hole7.BackgroundImage = global::Lab2.Properties.Resources.hole;
            this.hole7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.hole7.Location = new System.Drawing.Point(259, 303);
            this.hole7.Name = "hole7";
            this.hole7.Size = new System.Drawing.Size(100, 100);
            this.hole7.TabIndex = 10;
            this.hole7.TabStop = false;
            this.hole7.Click += new System.EventHandler(this.hole7_Click);
            // 
            // hole8
            // 
            this.hole8.BackgroundImage = global::Lab2.Properties.Resources.hole;
            this.hole8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.hole8.Location = new System.Drawing.Point(365, 303);
            this.hole8.Name = "hole8";
            this.hole8.Size = new System.Drawing.Size(100, 100);
            this.hole8.TabIndex = 11;
            this.hole8.TabStop = false;
            this.hole8.Click += new System.EventHandler(this.hole8_Click);
            // 
            // hole9
            // 
            this.hole9.BackgroundImage = global::Lab2.Properties.Resources.hole;
            this.hole9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.hole9.Location = new System.Drawing.Point(471, 303);
            this.hole9.Name = "hole9";
            this.hole9.Size = new System.Drawing.Size(100, 100);
            this.hole9.TabIndex = 12;
            this.hole9.TabStop = false;
            this.hole9.Click += new System.EventHandler(this.hole9_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.Red;
            this.buttonExit.Location = new System.Drawing.Point(365, 407);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(100, 65);
            this.buttonExit.TabIndex = 13;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // labelWelcome
            // 
            this.labelWelcome.BackColor = System.Drawing.Color.Transparent;
            this.labelWelcome.Location = new System.Drawing.Point(311, 63);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(183, 23);
            this.labelWelcome.TabIndex = 14;
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.BackColor = System.Drawing.Color.Transparent;
            this.labelLastName.Location = new System.Drawing.Point(11, 149);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(75, 16);
            this.labelLastName.TabIndex = 15;
            this.labelLastName.Text = "Last Name:";
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.BackColor = System.Drawing.Color.Transparent;
            this.labelFirstName.Location = new System.Drawing.Point(11, 105);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(75, 16);
            this.labelFirstName.TabIndex = 16;
            this.labelFirstName.Text = "First Name:";
            // 
            // labelPlayerInfo
            // 
            this.labelPlayerInfo.AutoSize = true;
            this.labelPlayerInfo.BackColor = System.Drawing.Color.Transparent;
            this.labelPlayerInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelPlayerInfo.Location = new System.Drawing.Point(55, 76);
            this.labelPlayerInfo.Name = "labelPlayerInfo";
            this.labelPlayerInfo.Size = new System.Drawing.Size(110, 25);
            this.labelPlayerInfo.TabIndex = 17;
            this.labelPlayerInfo.Text = "Player Info:";
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(14, 124);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(100, 22);
            this.textBoxFirstName.TabIndex = 18;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(14, 169);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(100, 22);
            this.textBoxLastName.TabIndex = 19;
            // 
            // labelScore
            // 
            this.labelScore.BackColor = System.Drawing.Color.Transparent;
            this.labelScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScore.Location = new System.Drawing.Point(33, 270);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(100, 23);
            this.labelScore.TabIndex = 20;
            this.labelScore.Text = "Score:";
            this.labelScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelScore.Click += new System.EventHandler(this.labelScore_Click);
            // 
            // labelScoreBox
            // 
            this.labelScoreBox.BackColor = System.Drawing.Color.GreenYellow;
            this.labelScoreBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScoreBox.Location = new System.Drawing.Point(33, 303);
            this.labelScoreBox.Name = "labelScoreBox";
            this.labelScoreBox.Size = new System.Drawing.Size(100, 23);
            this.labelScoreBox.TabIndex = 21;
            this.labelScoreBox.Text = "0";
            this.labelScoreBox.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelhole
            // 
            this.labelhole.Location = new System.Drawing.Point(35, 344);
            this.labelhole.Name = "labelhole";
            this.labelhole.Size = new System.Drawing.Size(100, 23);
            this.labelhole.TabIndex = 22;
            this.labelhole.Click += new System.EventHandler(this.labelWhole_Click);
            // 
            // buttonMoveMole
            // 
            this.buttonMoveMole.BackColor = System.Drawing.Color.Orange;
            this.buttonMoveMole.Location = new System.Drawing.Point(155, 407);
            this.buttonMoveMole.Name = "buttonMoveMole";
            this.buttonMoveMole.Size = new System.Drawing.Size(99, 65);
            this.buttonMoveMole.TabIndex = 23;
            this.buttonMoveMole.Text = "Move the Mole";
            this.buttonMoveMole.UseVisualStyleBackColor = false;
            this.buttonMoveMole.Click += new System.EventHandler(this.buttonMoveMole_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Lab2.Properties.Resources.Background;
            this.ClientSize = new System.Drawing.Size(800, 493);
            this.Controls.Add(this.buttonMoveMole);
            this.Controls.Add(this.labelhole);
            this.Controls.Add(this.labelScoreBox);
            this.Controls.Add(this.labelScore);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.labelPlayerInfo);
            this.Controls.Add(this.labelFirstName);
            this.Controls.Add(this.labelLastName);
            this.Controls.Add(this.labelWelcome);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.hole9);
            this.Controls.Add(this.hole8);
            this.Controls.Add(this.hole7);
            this.Controls.Add(this.hole6);
            this.Controls.Add(this.hole5);
            this.Controls.Add(this.hole4);
            this.Controls.Add(this.hole3);
            this.Controls.Add(this.hole2);
            this.Controls.Add(this.hole1);
            this.Controls.Add(this.wackAMoleLabel);
            this.Controls.Add(this.buttonResetGame);
            this.Controls.Add(this.buttonStartGame);
            this.Name = "Form1";
            this.Text = "Wack-A-Mole";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hole1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hole2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hole3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hole4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hole5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hole6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hole7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hole8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hole9)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonStartGame;
        private System.Windows.Forms.Button buttonResetGame;
        private System.Windows.Forms.Label wackAMoleLabel;
        private System.Windows.Forms.PictureBox hole1;
        private System.Windows.Forms.PictureBox hole2;
        private System.Windows.Forms.PictureBox hole3;
        private System.Windows.Forms.PictureBox hole4;
        private System.Windows.Forms.PictureBox hole5;
        private System.Windows.Forms.PictureBox hole6;
        private System.Windows.Forms.PictureBox hole7;
        private System.Windows.Forms.PictureBox hole8;
        private System.Windows.Forms.PictureBox hole9;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.Label labelPlayerInfo;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.Label labelScoreBox;
        private System.Windows.Forms.Label labelhole;
        private System.Windows.Forms.Button buttonMoveMole;
    }
}

