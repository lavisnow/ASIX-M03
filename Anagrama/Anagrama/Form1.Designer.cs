namespace Anagrama
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
            this.txb_in = new System.Windows.Forms.TextBox();
            this.txb_out = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bt_check = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txb_in
            // 
            this.txb_in.Location = new System.Drawing.Point(12, 40);
            this.txb_in.Multiline = true;
            this.txb_in.Name = "txb_in";
            this.txb_in.Size = new System.Drawing.Size(488, 53);
            this.txb_in.TabIndex = 0;
            // 
            // txb_out
            // 
            this.txb_out.Location = new System.Drawing.Point(12, 124);
            this.txb_out.Multiline = true;
            this.txb_out.Name = "txb_out";
            this.txb_out.Size = new System.Drawing.Size(488, 53);
            this.txb_out.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "ENTRADA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "SORTIDA";
            // 
            // bt_check
            // 
            this.bt_check.Location = new System.Drawing.Point(215, 183);
            this.bt_check.Name = "bt_check";
            this.bt_check.Size = new System.Drawing.Size(155, 40);
            this.bt_check.TabIndex = 4;
            this.bt_check.Text = "CHECK";
            this.bt_check.UseVisualStyleBackColor = true;
            this.bt_check.Click += new System.EventHandler(this.bt_check_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 300);
            this.Controls.Add(this.bt_check);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txb_out);
            this.Controls.Add(this.txb_in);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txb_in;
        private System.Windows.Forms.TextBox txb_out;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bt_check;
    }
}

