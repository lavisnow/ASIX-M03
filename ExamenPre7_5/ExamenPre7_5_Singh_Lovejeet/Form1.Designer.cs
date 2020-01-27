namespace ExamenPre7_5_Singh_Lovejeet
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tx_player_01 = new System.Windows.Forms.TextBox();
            this.tx_resultat = new System.Windows.Forms.TextBox();
            this.tx_player_02 = new System.Windows.Forms.TextBox();
            this.bt_play_01 = new System.Windows.Forms.Button();
            this.bt_play_02 = new System.Windows.Forms.Button();
            this.bt_winner = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tx_player_01
            // 
            this.tx_player_01.Location = new System.Drawing.Point(115, 37);
            this.tx_player_01.Multiline = true;
            this.tx_player_01.Name = "tx_player_01";
            this.tx_player_01.Size = new System.Drawing.Size(245, 161);
            this.tx_player_01.TabIndex = 0;
            // 
            // tx_resultat
            // 
            this.tx_resultat.Location = new System.Drawing.Point(282, 316);
            this.tx_resultat.Multiline = true;
            this.tx_resultat.Name = "tx_resultat";
            this.tx_resultat.Size = new System.Drawing.Size(241, 35);
            this.tx_resultat.TabIndex = 2;
            // 
            // tx_player_02
            // 
            this.tx_player_02.Location = new System.Drawing.Point(459, 37);
            this.tx_player_02.Multiline = true;
            this.tx_player_02.Name = "tx_player_02";
            this.tx_player_02.Size = new System.Drawing.Size(238, 161);
            this.tx_player_02.TabIndex = 3;
            // 
            // bt_play_01
            // 
            this.bt_play_01.Location = new System.Drawing.Point(184, 224);
            this.bt_play_01.Name = "bt_play_01";
            this.bt_play_01.Size = new System.Drawing.Size(75, 23);
            this.bt_play_01.TabIndex = 4;
            this.bt_play_01.Text = "Play";
            this.bt_play_01.UseVisualStyleBackColor = true;
            this.bt_play_01.Click += new System.EventHandler(this.button1_Click);
            // 
            // bt_play_02
            // 
            this.bt_play_02.Location = new System.Drawing.Point(559, 224);
            this.bt_play_02.Name = "bt_play_02";
            this.bt_play_02.Size = new System.Drawing.Size(75, 23);
            this.bt_play_02.TabIndex = 5;
            this.bt_play_02.Text = "Play";
            this.bt_play_02.UseVisualStyleBackColor = true;
            this.bt_play_02.Click += new System.EventHandler(this.bt_play_02_Click);
            // 
            // bt_winner
            // 
            this.bt_winner.Location = new System.Drawing.Point(363, 370);
            this.bt_winner.Name = "bt_winner";
            this.bt_winner.Size = new System.Drawing.Size(75, 23);
            this.bt_winner.TabIndex = 6;
            this.bt_winner.Text = "Winner";
            this.bt_winner.UseVisualStyleBackColor = true;
            this.bt_winner.Click += new System.EventHandler(this.bt_winner_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bt_winner);
            this.Controls.Add(this.bt_play_02);
            this.Controls.Add(this.bt_play_01);
            this.Controls.Add(this.tx_player_02);
            this.Controls.Add(this.tx_resultat);
            this.Controls.Add(this.tx_player_01);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tx_player_01;
        private System.Windows.Forms.TextBox tx_resultat;
        private System.Windows.Forms.TextBox tx_player_02;
        private System.Windows.Forms.Button bt_play_01;
        private System.Windows.Forms.Button bt_play_02;
        private System.Windows.Forms.Button bt_winner;
    }
}

