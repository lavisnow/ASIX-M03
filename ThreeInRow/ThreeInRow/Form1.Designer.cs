namespace ThreeInRow
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
            this.tx_Board = new System.Windows.Forms.TextBox();
            this.tx_X = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tx_Y = new System.Windows.Forms.TextBox();
            this.bt_Play = new System.Windows.Forms.Button();
            this.bt_replay = new System.Windows.Forms.Button();
            this.lb_player1 = new System.Windows.Forms.Label();
            this.lb_player2 = new System.Windows.Forms.Label();
            this.lb_change = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tx_Board
            // 
            this.tx_Board.Font = new System.Drawing.Font("Microsoft Sans Serif", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_Board.Location = new System.Drawing.Point(12, 12);
            this.tx_Board.Multiline = true;
            this.tx_Board.Name = "tx_Board";
            this.tx_Board.Size = new System.Drawing.Size(222, 164);
            this.tx_Board.TabIndex = 0;
            // 
            // tx_X
            // 
            this.tx_X.Location = new System.Drawing.Point(128, 207);
            this.tx_X.Name = "tx_X";
            this.tx_X.Size = new System.Drawing.Size(34, 20);
            this.tx_X.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(102, 207);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Y";
            // 
            // tx_Y
            // 
            this.tx_Y.Location = new System.Drawing.Point(49, 207);
            this.tx_Y.Name = "tx_Y";
            this.tx_Y.Size = new System.Drawing.Size(34, 20);
            this.tx_Y.TabIndex = 3;
            // 
            // bt_Play
            // 
            this.bt_Play.Location = new System.Drawing.Point(264, 206);
            this.bt_Play.Name = "bt_Play";
            this.bt_Play.Size = new System.Drawing.Size(145, 54);
            this.bt_Play.TabIndex = 5;
            this.bt_Play.Text = "Juga";
            this.bt_Play.UseVisualStyleBackColor = true;
            this.bt_Play.Click += new System.EventHandler(this.bt_Play_Click);
            // 
            // bt_replay
            // 
            this.bt_replay.Location = new System.Drawing.Point(255, 12);
            this.bt_replay.Name = "bt_replay";
            this.bt_replay.Size = new System.Drawing.Size(171, 34);
            this.bt_replay.TabIndex = 6;
            this.bt_replay.Text = "Tornar Jugar";
            this.bt_replay.UseVisualStyleBackColor = true;
            this.bt_replay.Click += new System.EventHandler(this.bt_replay_Click);
            // 
            // lb_player1
            // 
            this.lb_player1.AutoSize = true;
            this.lb_player1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_player1.Location = new System.Drawing.Point(277, 72);
            this.lb_player1.Name = "lb_player1";
            this.lb_player1.Size = new System.Drawing.Size(102, 20);
            this.lb_player1.TabIndex = 7;
            this.lb_player1.Text = "JUGADOR 1";
            // 
            // lb_player2
            // 
            this.lb_player2.AutoSize = true;
            this.lb_player2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_player2.Location = new System.Drawing.Point(277, 113);
            this.lb_player2.Name = "lb_player2";
            this.lb_player2.Size = new System.Drawing.Size(102, 20);
            this.lb_player2.TabIndex = 8;
            this.lb_player2.Text = "JUGADOR 2";
            // 
            // lb_change
            // 
            this.lb_change.AutoSize = true;
            this.lb_change.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_change.Location = new System.Drawing.Point(260, 156);
            this.lb_change.Name = "lb_change";
            this.lb_change.Size = new System.Drawing.Size(137, 20);
            this.lb_change.TabIndex = 9;
            this.lb_change.Text = "FICHA A MOURE";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 272);
            this.Controls.Add(this.lb_change);
            this.Controls.Add(this.lb_player2);
            this.Controls.Add(this.lb_player1);
            this.Controls.Add(this.bt_replay);
            this.Controls.Add(this.bt_Play);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tx_Y);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tx_X);
            this.Controls.Add(this.tx_Board);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tx_Board;
        private System.Windows.Forms.TextBox tx_X;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tx_Y;
        private System.Windows.Forms.Button bt_Play;
        private System.Windows.Forms.Button bt_replay;
        private System.Windows.Forms.Label lb_player1;
        private System.Windows.Forms.Label lb_player2;
        private System.Windows.Forms.Label lb_change;
    }
}

