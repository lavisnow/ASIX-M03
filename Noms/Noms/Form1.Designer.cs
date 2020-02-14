namespace Noms
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
            this.tx_main = new System.Windows.Forms.TextBox();
            this.bt_dret = new System.Windows.Forms.Button();
            this.bt_esq = new System.Windows.Forms.Button();
            this.bt_load = new System.Windows.Forms.Button();
            this.bt_save = new System.Windows.Forms.Button();
            this.tx_array = new System.Windows.Forms.TextBox();
            this.bt_array = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tx_main
            // 
            this.tx_main.Location = new System.Drawing.Point(63, 56);
            this.tx_main.Name = "tx_main";
            this.tx_main.Size = new System.Drawing.Size(230, 20);
            this.tx_main.TabIndex = 0;
            // 
            // bt_dret
            // 
            this.bt_dret.Location = new System.Drawing.Point(299, 56);
            this.bt_dret.Name = "bt_dret";
            this.bt_dret.Size = new System.Drawing.Size(29, 23);
            this.bt_dret.TabIndex = 1;
            this.bt_dret.Text = ">";
            this.bt_dret.UseVisualStyleBackColor = true;
            this.bt_dret.Click += new System.EventHandler(this.bt_dret_Click);
            // 
            // bt_esq
            // 
            this.bt_esq.Location = new System.Drawing.Point(29, 56);
            this.bt_esq.Name = "bt_esq";
            this.bt_esq.Size = new System.Drawing.Size(28, 23);
            this.bt_esq.TabIndex = 2;
            this.bt_esq.Text = "<";
            this.bt_esq.UseVisualStyleBackColor = true;
            this.bt_esq.Click += new System.EventHandler(this.bt_esq_Click);
            // 
            // bt_load
            // 
            this.bt_load.Location = new System.Drawing.Point(73, 109);
            this.bt_load.Name = "bt_load";
            this.bt_load.Size = new System.Drawing.Size(75, 23);
            this.bt_load.TabIndex = 3;
            this.bt_load.Text = "Load";
            this.bt_load.UseVisualStyleBackColor = true;
            this.bt_load.Click += new System.EventHandler(this.bt_load_Click);
            // 
            // bt_save
            // 
            this.bt_save.Location = new System.Drawing.Point(196, 108);
            this.bt_save.Name = "bt_save";
            this.bt_save.Size = new System.Drawing.Size(75, 23);
            this.bt_save.TabIndex = 4;
            this.bt_save.Text = "Save";
            this.bt_save.UseVisualStyleBackColor = true;
            this.bt_save.Click += new System.EventHandler(this.bt_save_Click);
            // 
            // tx_array
            // 
            this.tx_array.Location = new System.Drawing.Point(29, 12);
            this.tx_array.Multiline = true;
            this.tx_array.Name = "tx_array";
            this.tx_array.Size = new System.Drawing.Size(28, 20);
            this.tx_array.TabIndex = 5;
            // 
            // bt_array
            // 
            this.bt_array.Location = new System.Drawing.Point(63, 12);
            this.bt_array.Name = "bt_array";
            this.bt_array.Size = new System.Drawing.Size(48, 23);
            this.bt_array.TabIndex = 6;
            this.bt_array.Text = "Array";
            this.bt_array.UseVisualStyleBackColor = true;
            this.bt_array.Click += new System.EventHandler(this.bt_array_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 143);
            this.Controls.Add(this.bt_array);
            this.Controls.Add(this.tx_array);
            this.Controls.Add(this.bt_save);
            this.Controls.Add(this.bt_load);
            this.Controls.Add(this.bt_esq);
            this.Controls.Add(this.bt_dret);
            this.Controls.Add(this.tx_main);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tx_main;
        private System.Windows.Forms.Button bt_dret;
        private System.Windows.Forms.Button bt_esq;
        private System.Windows.Forms.Button bt_load;
        private System.Windows.Forms.Button bt_save;
        private System.Windows.Forms.TextBox tx_array;
        private System.Windows.Forms.Button bt_array;
    }
}

