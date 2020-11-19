namespace Preguntes
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
            this.bt_imp = new System.Windows.Forms.Button();
            this.bt_exp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_imp
            // 
            this.bt_imp.Location = new System.Drawing.Point(12, 12);
            this.bt_imp.Name = "bt_imp";
            this.bt_imp.Size = new System.Drawing.Size(156, 55);
            this.bt_imp.TabIndex = 0;
            this.bt_imp.Text = "Import";
            this.bt_imp.UseVisualStyleBackColor = true;
            this.bt_imp.Click += new System.EventHandler(this.bt_imp_Click);
            // 
            // bt_exp
            // 
            this.bt_exp.Location = new System.Drawing.Point(206, 14);
            this.bt_exp.Name = "bt_exp";
            this.bt_exp.Size = new System.Drawing.Size(156, 55);
            this.bt_exp.TabIndex = 1;
            this.bt_exp.Text = "Export";
            this.bt_exp.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 83);
            this.Controls.Add(this.bt_exp);
            this.Controls.Add(this.bt_imp);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_imp;
        private System.Windows.Forms.Button bt_exp;
    }
}

