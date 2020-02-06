namespace SopaLletres
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
            this.tx_sopa = new System.Windows.Forms.TextBox();
            this.tx_inici_X = new System.Windows.Forms.TextBox();
            this.tx_inici_Y = new System.Windows.Forms.TextBox();
            this.tx_fi_Y = new System.Windows.Forms.TextBox();
            this.tx_fi_X = new System.Windows.Forms.TextBox();
            this.bt_Search = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tx_paraules = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tx_sopa
            // 
            this.tx_sopa.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_sopa.Location = new System.Drawing.Point(12, 12);
            this.tx_sopa.Multiline = true;
            this.tx_sopa.Name = "tx_sopa";
            this.tx_sopa.Size = new System.Drawing.Size(320, 240);
            this.tx_sopa.TabIndex = 0;
            // 
            // tx_inici_X
            // 
            this.tx_inici_X.Location = new System.Drawing.Point(381, 45);
            this.tx_inici_X.Name = "tx_inici_X";
            this.tx_inici_X.Size = new System.Drawing.Size(26, 20);
            this.tx_inici_X.TabIndex = 1;
            // 
            // tx_inici_Y
            // 
            this.tx_inici_Y.Location = new System.Drawing.Point(437, 45);
            this.tx_inici_Y.Name = "tx_inici_Y";
            this.tx_inici_Y.Size = new System.Drawing.Size(26, 20);
            this.tx_inici_Y.TabIndex = 2;
            // 
            // tx_fi_Y
            // 
            this.tx_fi_Y.Location = new System.Drawing.Point(596, 43);
            this.tx_fi_Y.Name = "tx_fi_Y";
            this.tx_fi_Y.Size = new System.Drawing.Size(26, 20);
            this.tx_fi_Y.TabIndex = 3;
            // 
            // tx_fi_X
            // 
            this.tx_fi_X.Location = new System.Drawing.Point(540, 43);
            this.tx_fi_X.Name = "tx_fi_X";
            this.tx_fi_X.Size = new System.Drawing.Size(26, 20);
            this.tx_fi_X.TabIndex = 4;
            // 
            // bt_Search
            // 
            this.bt_Search.Location = new System.Drawing.Point(428, 85);
            this.bt_Search.Name = "bt_Search";
            this.bt_Search.Size = new System.Drawing.Size(116, 23);
            this.bt_Search.TabIndex = 5;
            this.bt_Search.Text = "Buscar";
            this.bt_Search.UseVisualStyleBackColor = true;
            this.bt_Search.Click += new System.EventHandler(this.bt_Search_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(355, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(514, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "X";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(413, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Y";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(572, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Y";
            // 
            // tx_paraules
            // 
            this.tx_paraules.Location = new System.Drawing.Point(365, 166);
            this.tx_paraules.Multiline = true;
            this.tx_paraules.Name = "tx_paraules";
            this.tx_paraules.Size = new System.Drawing.Size(282, 194);
            this.tx_paraules.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(361, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Posicio Inicial";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(525, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Posicio Final";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 372);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tx_paraules);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_Search);
            this.Controls.Add(this.tx_fi_X);
            this.Controls.Add(this.tx_fi_Y);
            this.Controls.Add(this.tx_inici_Y);
            this.Controls.Add(this.tx_inici_X);
            this.Controls.Add(this.tx_sopa);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tx_sopa;
        private System.Windows.Forms.TextBox tx_inici_X;
        private System.Windows.Forms.TextBox tx_inici_Y;
        private System.Windows.Forms.TextBox tx_fi_Y;
        private System.Windows.Forms.TextBox tx_fi_X;
        private System.Windows.Forms.Button bt_Search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tx_paraules;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

