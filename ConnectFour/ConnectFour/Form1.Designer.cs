namespace ConnectFour
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
            this.cb_Colum = new System.Windows.Forms.ComboBox();
            this.tx_board = new System.Windows.Forms.TextBox();
            this.bt_Play = new System.Windows.Forms.Button();
            this.bt_res = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cb_Colum
            // 
            this.cb_Colum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Colum.FormattingEnabled = true;
            this.cb_Colum.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.cb_Colum.Location = new System.Drawing.Point(184, 381);
            this.cb_Colum.Name = "cb_Colum";
            this.cb_Colum.Size = new System.Drawing.Size(37, 28);
            this.cb_Colum.TabIndex = 0;
            this.cb_Colum.Text = "1";
            // 
            // tx_board
            // 
            this.tx_board.Font = new System.Drawing.Font("Microsoft Sans Serif", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_board.Location = new System.Drawing.Point(12, 12);
            this.tx_board.Multiline = true;
            this.tx_board.Name = "tx_board";
            this.tx_board.Size = new System.Drawing.Size(546, 356);
            this.tx_board.TabIndex = 1;
            // 
            // bt_Play
            // 
            this.bt_Play.Location = new System.Drawing.Point(227, 374);
            this.bt_Play.Name = "bt_Play";
            this.bt_Play.Size = new System.Drawing.Size(100, 43);
            this.bt_Play.TabIndex = 3;
            this.bt_Play.Text = "Juga";
            this.bt_Play.UseVisualStyleBackColor = true;
            this.bt_Play.Click += new System.EventHandler(this.bt_Play_Click);
            // 
            // bt_res
            // 
            this.bt_res.Location = new System.Drawing.Point(569, 40);
            this.bt_res.Name = "bt_res";
            this.bt_res.Size = new System.Drawing.Size(75, 23);
            this.bt_res.TabIndex = 4;
            this.bt_res.Text = "Restart";
            this.bt_res.UseVisualStyleBackColor = true;
            this.bt_res.Click += new System.EventHandler(this.bt_res_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 457);
            this.Controls.Add(this.bt_res);
            this.Controls.Add(this.bt_Play);
            this.Controls.Add(this.tx_board);
            this.Controls.Add(this.cb_Colum);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_Colum;
        private System.Windows.Forms.TextBox tx_board;
        private System.Windows.Forms.Button bt_Play;
        private System.Windows.Forms.Button bt_res;
    }
}

