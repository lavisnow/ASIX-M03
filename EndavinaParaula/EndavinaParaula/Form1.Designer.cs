namespace EndavinaParaula
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
            this.tx_endavina = new System.Windows.Forms.TextBox();
            this.tx_paraula = new System.Windows.Forms.TextBox();
            this.tx_pista = new System.Windows.Forms.TextBox();
            this.bt_juga = new System.Windows.Forms.Button();
            this.bt_endavina = new System.Windows.Forms.Button();
            this.bt_pista = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tx_endavina
            // 
            this.tx_endavina.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_endavina.Location = new System.Drawing.Point(12, 12);
            this.tx_endavina.Multiline = true;
            this.tx_endavina.Name = "tx_endavina";
            this.tx_endavina.Size = new System.Drawing.Size(776, 117);
            this.tx_endavina.TabIndex = 0;
            this.tx_endavina.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tx_paraula
            // 
            this.tx_paraula.Location = new System.Drawing.Point(765, 135);
            this.tx_paraula.Name = "tx_paraula";
            this.tx_paraula.Size = new System.Drawing.Size(23, 20);
            this.tx_paraula.TabIndex = 1;
            // 
            // tx_pista
            // 
            this.tx_pista.Location = new System.Drawing.Point(30, 135);
            this.tx_pista.Multiline = true;
            this.tx_pista.Name = "tx_pista";
            this.tx_pista.Size = new System.Drawing.Size(488, 43);
            this.tx_pista.TabIndex = 2;
            // 
            // bt_juga
            // 
            this.bt_juga.Location = new System.Drawing.Point(684, 135);
            this.bt_juga.Name = "bt_juga";
            this.bt_juga.Size = new System.Drawing.Size(75, 23);
            this.bt_juga.TabIndex = 3;
            this.bt_juga.Text = "Juga";
            this.bt_juga.UseVisualStyleBackColor = true;
            this.bt_juga.Click += new System.EventHandler(this.bt_juga_Click);
            // 
            // bt_endavina
            // 
            this.bt_endavina.Location = new System.Drawing.Point(524, 164);
            this.bt_endavina.Name = "bt_endavina";
            this.bt_endavina.Size = new System.Drawing.Size(75, 23);
            this.bt_endavina.TabIndex = 4;
            this.bt_endavina.Text = "Endavina";
            this.bt_endavina.UseVisualStyleBackColor = true;
            this.bt_endavina.Click += new System.EventHandler(this.bt_endavina_Click);
            // 
            // bt_pista
            // 
            this.bt_pista.Location = new System.Drawing.Point(524, 135);
            this.bt_pista.Name = "bt_pista";
            this.bt_pista.Size = new System.Drawing.Size(75, 23);
            this.bt_pista.TabIndex = 5;
            this.bt_pista.Text = "Pista";
            this.bt_pista.UseVisualStyleBackColor = true;
            this.bt_pista.Click += new System.EventHandler(this.bt_pista_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 190);
            this.Controls.Add(this.bt_pista);
            this.Controls.Add(this.bt_endavina);
            this.Controls.Add(this.bt_juga);
            this.Controls.Add(this.tx_pista);
            this.Controls.Add(this.tx_paraula);
            this.Controls.Add(this.tx_endavina);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tx_endavina;
        private System.Windows.Forms.TextBox tx_paraula;
        private System.Windows.Forms.TextBox tx_pista;
        private System.Windows.Forms.Button bt_juga;
        private System.Windows.Forms.Button bt_endavina;
        private System.Windows.Forms.Button bt_pista;
    }
}

