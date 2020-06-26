namespace ConnectFour
{
    partial class Player
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
            this.comBoPlayer1 = new System.Windows.Forms.ComboBox();
            this.comBoPlayer2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSavePlayers = new System.Windows.Forms.Button();
            this.tbNewPlayer = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAddPlayer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comBoPlayer1
            // 
            this.comBoPlayer1.FormattingEnabled = true;
            this.comBoPlayer1.Location = new System.Drawing.Point(142, 52);
            this.comBoPlayer1.Name = "comBoPlayer1";
            this.comBoPlayer1.Size = new System.Drawing.Size(167, 28);
            this.comBoPlayer1.TabIndex = 0;
            // 
            // comBoPlayer2
            // 
            this.comBoPlayer2.FormattingEnabled = true;
            this.comBoPlayer2.Location = new System.Drawing.Point(141, 109);
            this.comBoPlayer2.Name = "comBoPlayer2";
            this.comBoPlayer2.Size = new System.Drawing.Size(167, 28);
            this.comBoPlayer2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Player1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Player2:";
            // 
            // btnSavePlayers
            // 
            this.btnSavePlayers.Location = new System.Drawing.Point(78, 178);
            this.btnSavePlayers.Name = "btnSavePlayers";
            this.btnSavePlayers.Size = new System.Drawing.Size(179, 60);
            this.btnSavePlayers.TabIndex = 4;
            this.btnSavePlayers.Text = "Los Geht\'s!";
            this.btnSavePlayers.UseVisualStyleBackColor = true;
            this.btnSavePlayers.Click += new System.EventHandler(this.btnSavePlayers_Click);
            // 
            // tbNewPlayer
            // 
            this.tbNewPlayer.Location = new System.Drawing.Point(430, 110);
            this.tbNewPlayer.Name = "tbNewPlayer";
            this.tbNewPlayer.Size = new System.Drawing.Size(165, 27);
            this.tbNewPlayer.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(457, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Neuer Spieler:";
            // 
            // btnAddPlayer
            // 
            this.btnAddPlayer.Location = new System.Drawing.Point(447, 163);
            this.btnAddPlayer.Name = "btnAddPlayer";
            this.btnAddPlayer.Size = new System.Drawing.Size(129, 52);
            this.btnAddPlayer.TabIndex = 7;
            this.btnAddPlayer.Text = "Spieler speichern";
            this.btnAddPlayer.UseVisualStyleBackColor = true;
            this.btnAddPlayer.Click += new System.EventHandler(this.btnAddPlayer_Click);
            // 
            // Player
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 311);
            this.Controls.Add(this.btnAddPlayer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbNewPlayer);
            this.Controls.Add(this.btnSavePlayers);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comBoPlayer2);
            this.Controls.Add(this.comBoPlayer1);
            this.Name = "Player";
            this.Text = "Player";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comBoPlayer1;
        private System.Windows.Forms.ComboBox comBoPlayer2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSavePlayers;
        private System.Windows.Forms.TextBox tbNewPlayer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAddPlayer;
    }
}