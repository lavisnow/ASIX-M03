namespace JocDelRellotge
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
            this.tx_p1_cartas = new System.Windows.Forms.TextBox();
            this.tx_p2_cartas = new System.Windows.Forms.TextBox();
            this.tx_p1_resultat = new System.Windows.Forms.TextBox();
            this.tx_p2_resultat = new System.Windows.Forms.TextBox();
            this.bt_p1 = new System.Windows.Forms.Button();
            this.bt_p2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tx_contador_cartas = new System.Windows.Forms.TextBox();
            this.tx_contador = new System.Windows.Forms.TextBox();
            this.bt_start = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tx_p1_cartas
            // 
            this.tx_p1_cartas.Location = new System.Drawing.Point(99, 54);
            this.tx_p1_cartas.Name = "tx_p1_cartas";
            this.tx_p1_cartas.Size = new System.Drawing.Size(26, 20);
            this.tx_p1_cartas.TabIndex = 0;
            this.tx_p1_cartas.Text = "24";
            // 
            // tx_p2_cartas
            // 
            this.tx_p2_cartas.Location = new System.Drawing.Point(369, 54);
            this.tx_p2_cartas.Name = "tx_p2_cartas";
            this.tx_p2_cartas.Size = new System.Drawing.Size(26, 20);
            this.tx_p2_cartas.TabIndex = 1;
            this.tx_p2_cartas.Text = "24";
            // 
            // tx_p1_resultat
            // 
            this.tx_p1_resultat.Location = new System.Drawing.Point(71, 28);
            this.tx_p1_resultat.Name = "tx_p1_resultat";
            this.tx_p1_resultat.Size = new System.Drawing.Size(97, 20);
            this.tx_p1_resultat.TabIndex = 2;
            // 
            // tx_p2_resultat
            // 
            this.tx_p2_resultat.Location = new System.Drawing.Point(333, 28);
            this.tx_p2_resultat.Name = "tx_p2_resultat";
            this.tx_p2_resultat.Size = new System.Drawing.Size(108, 20);
            this.tx_p2_resultat.TabIndex = 3;
            // 
            // bt_p1
            // 
            this.bt_p1.Location = new System.Drawing.Point(71, 109);
            this.bt_p1.Name = "bt_p1";
            this.bt_p1.Size = new System.Drawing.Size(75, 23);
            this.bt_p1.TabIndex = 4;
            this.bt_p1.Text = "Player 1";
            this.bt_p1.UseVisualStyleBackColor = true;
            this.bt_p1.Click += new System.EventHandler(this.Bt_p1_Click);
            // 
            // bt_p2
            // 
            this.bt_p2.Location = new System.Drawing.Point(342, 109);
            this.bt_p2.Name = "bt_p2";
            this.bt_p2.Size = new System.Drawing.Size(75, 23);
            this.bt_p2.TabIndex = 5;
            this.bt_p2.Text = "Player 2";
            this.bt_p2.UseVisualStyleBackColor = true;
            this.bt_p2.Click += new System.EventHandler(this.Bt_p2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bt_start);
            this.groupBox1.Controls.Add(this.tx_contador_cartas);
            this.groupBox1.Controls.Add(this.tx_contador);
            this.groupBox1.Controls.Add(this.tx_p1_cartas);
            this.groupBox1.Controls.Add(this.bt_p2);
            this.groupBox1.Controls.Add(this.tx_p2_cartas);
            this.groupBox1.Controls.Add(this.bt_p1);
            this.groupBox1.Controls.Add(this.tx_p1_resultat);
            this.groupBox1.Controls.Add(this.tx_p2_resultat);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(500, 220);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Joc Cartes (Rellotge)";
            // 
            // tx_contador_cartas
            // 
            this.tx_contador_cartas.Location = new System.Drawing.Point(231, 19);
            this.tx_contador_cartas.Name = "tx_contador_cartas";
            this.tx_contador_cartas.Size = new System.Drawing.Size(26, 20);
            this.tx_contador_cartas.TabIndex = 7;
            this.tx_contador_cartas.Text = "0";
            // 
            // tx_contador
            // 
            this.tx_contador.Location = new System.Drawing.Point(231, 86);
            this.tx_contador.Name = "tx_contador";
            this.tx_contador.Size = new System.Drawing.Size(26, 20);
            this.tx_contador.TabIndex = 6;
            this.tx_contador.Text = "0";
            // 
            // bt_start
            // 
            this.bt_start.Location = new System.Drawing.Point(209, 164);
            this.bt_start.Name = "bt_start";
            this.bt_start.Size = new System.Drawing.Size(75, 23);
            this.bt_start.TabIndex = 8;
            this.bt_start.Text = "START";
            this.bt_start.UseVisualStyleBackColor = true;
            this.bt_start.Click += new System.EventHandler(this.Bt_start_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 242);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tx_p1_cartas;
        private System.Windows.Forms.TextBox tx_p2_cartas;
        private System.Windows.Forms.TextBox tx_p1_resultat;
        private System.Windows.Forms.TextBox tx_p2_resultat;
        private System.Windows.Forms.Button bt_p1;
        private System.Windows.Forms.Button bt_p2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tx_contador;
        private System.Windows.Forms.TextBox tx_contador_cartas;
        private System.Windows.Forms.Button bt_start;
    }
}

