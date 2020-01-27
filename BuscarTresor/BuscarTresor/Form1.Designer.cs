namespace BuscarTresor
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
            this.bt_create = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tx_MidaY = new System.Windows.Forms.TextBox();
            this.tx_MidaX = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tx_try = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_Search = new System.Windows.Forms.Button();
            this.tx_y = new System.Windows.Forms.TextBox();
            this.tx_x = new System.Windows.Forms.TextBox();
            this.tx_main = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bt_create
            // 
            this.bt_create.Location = new System.Drawing.Point(335, 5);
            this.bt_create.Name = "bt_create";
            this.bt_create.Size = new System.Drawing.Size(84, 35);
            this.bt_create.TabIndex = 27;
            this.bt_create.Text = "Crear";
            this.bt_create.UseVisualStyleBackColor = true;
            this.bt_create.Click += new System.EventHandler(this.bt_create_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(227, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 24);
            this.label5.TabIndex = 26;
            this.label5.Text = "Y:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(164, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 24);
            this.label6.TabIndex = 25;
            this.label6.Text = "X:";
            // 
            // tx_MidaY
            // 
            this.tx_MidaY.Location = new System.Drawing.Point(260, 12);
            this.tx_MidaY.Name = "tx_MidaY";
            this.tx_MidaY.Size = new System.Drawing.Size(30, 20);
            this.tx_MidaY.TabIndex = 24;
            // 
            // tx_MidaX
            // 
            this.tx_MidaX.Location = new System.Drawing.Point(194, 12);
            this.tx_MidaX.Name = "tx_MidaX";
            this.tx_MidaX.Size = new System.Drawing.Size(27, 20);
            this.tx_MidaX.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(73, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 20);
            this.label4.TabIndex = 22;
            this.label4.Text = "Mida tauler:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(454, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 21;
            this.label3.Text = "Intents:";
            // 
            // tx_try
            // 
            this.tx_try.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_try.Location = new System.Drawing.Point(473, 185);
            this.tx_try.Name = "tx_try";
            this.tx_try.Size = new System.Drawing.Size(30, 22);
            this.tx_try.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(137, 331);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 24);
            this.label2.TabIndex = 19;
            this.label2.Text = "Y:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(74, 331);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 24);
            this.label1.TabIndex = 18;
            this.label1.Text = "X:";
            // 
            // bt_Search
            // 
            this.bt_Search.Location = new System.Drawing.Point(314, 315);
            this.bt_Search.Name = "bt_Search";
            this.bt_Search.Size = new System.Drawing.Size(134, 61);
            this.bt_Search.TabIndex = 17;
            this.bt_Search.Text = "Search";
            this.bt_Search.UseVisualStyleBackColor = true;
            this.bt_Search.Click += new System.EventHandler(this.bt_Search_Click_1);
            // 
            // tx_y
            // 
            this.tx_y.Location = new System.Drawing.Point(170, 335);
            this.tx_y.Name = "tx_y";
            this.tx_y.Size = new System.Drawing.Size(30, 20);
            this.tx_y.TabIndex = 16;
            // 
            // tx_x
            // 
            this.tx_x.Location = new System.Drawing.Point(104, 335);
            this.tx_x.Name = "tx_x";
            this.tx_x.Size = new System.Drawing.Size(27, 20);
            this.tx_x.TabIndex = 15;
            // 
            // tx_main
            // 
            this.tx_main.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_main.Location = new System.Drawing.Point(37, 75);
            this.tx_main.Multiline = true;
            this.tx_main.Name = "tx_main";
            this.tx_main.Size = new System.Drawing.Size(411, 229);
            this.tx_main.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 381);
            this.Controls.Add(this.bt_create);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tx_MidaY);
            this.Controls.Add(this.tx_MidaX);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tx_try);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_Search);
            this.Controls.Add(this.tx_y);
            this.Controls.Add(this.tx_x);
            this.Controls.Add(this.tx_main);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_create;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tx_MidaY;
        private System.Windows.Forms.TextBox tx_MidaX;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tx_try;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_Search;
        private System.Windows.Forms.TextBox tx_y;
        private System.Windows.Forms.TextBox tx_x;
        private System.Windows.Forms.TextBox tx_main;
    }
}

