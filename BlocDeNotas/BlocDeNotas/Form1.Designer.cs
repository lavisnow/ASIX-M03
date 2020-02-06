namespace BlocDeNotas
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
            this.bt_new = new System.Windows.Forms.Button();
            this.bt_save = new System.Windows.Forms.Button();
            this.bt_load = new System.Windows.Forms.Button();
            this.tx_notepad = new System.Windows.Forms.TextBox();
            this.tx_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_count = new System.Windows.Forms.Button();
            this.bt_name = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_new
            // 
            this.bt_new.Location = new System.Drawing.Point(27, 12);
            this.bt_new.Name = "bt_new";
            this.bt_new.Size = new System.Drawing.Size(75, 23);
            this.bt_new.TabIndex = 0;
            this.bt_new.Text = "Nou";
            this.bt_new.UseVisualStyleBackColor = true;
            this.bt_new.Click += new System.EventHandler(this.bt_new_Click);
            // 
            // bt_save
            // 
            this.bt_save.Location = new System.Drawing.Point(108, 12);
            this.bt_save.Name = "bt_save";
            this.bt_save.Size = new System.Drawing.Size(75, 23);
            this.bt_save.TabIndex = 1;
            this.bt_save.Text = "Guardar";
            this.bt_save.UseVisualStyleBackColor = true;
            this.bt_save.Click += new System.EventHandler(this.bt_save_Click);
            // 
            // bt_load
            // 
            this.bt_load.Location = new System.Drawing.Point(189, 12);
            this.bt_load.Name = "bt_load";
            this.bt_load.Size = new System.Drawing.Size(75, 23);
            this.bt_load.TabIndex = 2;
            this.bt_load.Text = "Cargar";
            this.bt_load.UseVisualStyleBackColor = true;
            this.bt_load.Click += new System.EventHandler(this.bt_load_Click);
            // 
            // tx_notepad
            // 
            this.tx_notepad.Location = new System.Drawing.Point(12, 41);
            this.tx_notepad.Multiline = true;
            this.tx_notepad.Name = "tx_notepad";
            this.tx_notepad.Size = new System.Drawing.Size(776, 397);
            this.tx_notepad.TabIndex = 3;
            // 
            // tx_name
            // 
            this.tx_name.Location = new System.Drawing.Point(615, 12);
            this.tx_name.Name = "tx_name";
            this.tx_name.Size = new System.Drawing.Size(173, 20);
            this.tx_name.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(574, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Fitxer:";
            // 
            // bt_count
            // 
            this.bt_count.Location = new System.Drawing.Point(270, 12);
            this.bt_count.Name = "bt_count";
            this.bt_count.Size = new System.Drawing.Size(75, 23);
            this.bt_count.TabIndex = 6;
            this.bt_count.Text = "Contar";
            this.bt_count.UseVisualStyleBackColor = true;
            this.bt_count.Click += new System.EventHandler(this.bt_count_Click);
            // 
            // bt_name
            // 
            this.bt_name.Location = new System.Drawing.Point(351, 12);
            this.bt_name.Name = "bt_name";
            this.bt_name.Size = new System.Drawing.Size(75, 23);
            this.bt_name.TabIndex = 7;
            this.bt_name.Text = "Nom";
            this.bt_name.UseVisualStyleBackColor = true;
            this.bt_name.Click += new System.EventHandler(this.bt_name_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bt_name);
            this.Controls.Add(this.bt_count);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tx_name);
            this.Controls.Add(this.tx_notepad);
            this.Controls.Add(this.bt_load);
            this.Controls.Add(this.bt_save);
            this.Controls.Add(this.bt_new);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_new;
        private System.Windows.Forms.Button bt_save;
        private System.Windows.Forms.Button bt_load;
        private System.Windows.Forms.TextBox tx_notepad;
        private System.Windows.Forms.TextBox tx_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_count;
        private System.Windows.Forms.Button bt_name;
    }
}

