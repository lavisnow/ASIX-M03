namespace Class
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
            this.tx_cpu = new System.Windows.Forms.TextBox();
            this.tx_ram = new System.Windows.Forms.TextBox();
            this.tx_hdd = new System.Windows.Forms.TextBox();
            this.tx_gpu = new System.Windows.Forms.TextBox();
            this.bt_save = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tx_spec = new System.Windows.Forms.TextBox();
            this.bt_load = new System.Windows.Forms.Button();
            this.bt_left = new System.Windows.Forms.Button();
            this.bt_right = new System.Windows.Forms.Button();
            this.bt_download = new System.Windows.Forms.Button();
            this.bt_loadfile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tx_cpu
            // 
            this.tx_cpu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_cpu.Location = new System.Drawing.Point(53, 12);
            this.tx_cpu.Multiline = true;
            this.tx_cpu.Name = "tx_cpu";
            this.tx_cpu.Size = new System.Drawing.Size(311, 35);
            this.tx_cpu.TabIndex = 0;
            // 
            // tx_ram
            // 
            this.tx_ram.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_ram.Location = new System.Drawing.Point(53, 53);
            this.tx_ram.Multiline = true;
            this.tx_ram.Name = "tx_ram";
            this.tx_ram.Size = new System.Drawing.Size(311, 35);
            this.tx_ram.TabIndex = 1;
            // 
            // tx_hdd
            // 
            this.tx_hdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_hdd.Location = new System.Drawing.Point(53, 94);
            this.tx_hdd.Multiline = true;
            this.tx_hdd.Name = "tx_hdd";
            this.tx_hdd.Size = new System.Drawing.Size(311, 35);
            this.tx_hdd.TabIndex = 2;
            // 
            // tx_gpu
            // 
            this.tx_gpu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_gpu.Location = new System.Drawing.Point(53, 135);
            this.tx_gpu.Multiline = true;
            this.tx_gpu.Name = "tx_gpu";
            this.tx_gpu.Size = new System.Drawing.Size(311, 35);
            this.tx_gpu.TabIndex = 3;
            // 
            // bt_save
            // 
            this.bt_save.Location = new System.Drawing.Point(141, 176);
            this.bt_save.Name = "bt_save";
            this.bt_save.Size = new System.Drawing.Size(124, 28);
            this.bt_save.TabIndex = 4;
            this.bt_save.Text = "SAVE";
            this.bt_save.UseVisualStyleBackColor = true;
            this.bt_save.Click += new System.EventHandler(this.bt_save_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "CPU";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "HDD";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "RAM";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "GPU";
            // 
            // tx_spec
            // 
            this.tx_spec.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_spec.Location = new System.Drawing.Point(387, 12);
            this.tx_spec.Multiline = true;
            this.tx_spec.Name = "tx_spec";
            this.tx_spec.Size = new System.Drawing.Size(526, 508);
            this.tx_spec.TabIndex = 9;
            // 
            // bt_load
            // 
            this.bt_load.Location = new System.Drawing.Point(141, 210);
            this.bt_load.Name = "bt_load";
            this.bt_load.Size = new System.Drawing.Size(124, 28);
            this.bt_load.TabIndex = 10;
            this.bt_load.Text = "LOAD";
            this.bt_load.UseVisualStyleBackColor = true;
            this.bt_load.Click += new System.EventHandler(this.bt_load_Click);
            // 
            // bt_left
            // 
            this.bt_left.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_left.Location = new System.Drawing.Point(53, 186);
            this.bt_left.Name = "bt_left";
            this.bt_left.Size = new System.Drawing.Size(63, 42);
            this.bt_left.TabIndex = 11;
            this.bt_left.Text = "<";
            this.bt_left.UseVisualStyleBackColor = true;
            this.bt_left.Click += new System.EventHandler(this.bt_left_Click);
            // 
            // bt_right
            // 
            this.bt_right.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_right.Location = new System.Drawing.Point(283, 186);
            this.bt_right.Name = "bt_right";
            this.bt_right.Size = new System.Drawing.Size(63, 42);
            this.bt_right.TabIndex = 12;
            this.bt_right.Text = ">";
            this.bt_right.UseVisualStyleBackColor = true;
            this.bt_right.Click += new System.EventHandler(this.bt_right_Click);
            // 
            // bt_download
            // 
            this.bt_download.Location = new System.Drawing.Point(495, 526);
            this.bt_download.Name = "bt_download";
            this.bt_download.Size = new System.Drawing.Size(124, 28);
            this.bt_download.TabIndex = 13;
            this.bt_download.Text = "DOWNLOAD";
            this.bt_download.UseVisualStyleBackColor = true;
            this.bt_download.Click += new System.EventHandler(this.bt_download_Click);
            // 
            // bt_loadfile
            // 
            this.bt_loadfile.Location = new System.Drawing.Point(691, 526);
            this.bt_loadfile.Name = "bt_loadfile";
            this.bt_loadfile.Size = new System.Drawing.Size(124, 28);
            this.bt_loadfile.TabIndex = 14;
            this.bt_loadfile.Text = "LOAD FILE";
            this.bt_loadfile.UseVisualStyleBackColor = true;
            this.bt_loadfile.Click += new System.EventHandler(this.bt_loadfile_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 566);
            this.Controls.Add(this.bt_loadfile);
            this.Controls.Add(this.bt_download);
            this.Controls.Add(this.bt_right);
            this.Controls.Add(this.bt_left);
            this.Controls.Add(this.bt_load);
            this.Controls.Add(this.tx_spec);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_save);
            this.Controls.Add(this.tx_gpu);
            this.Controls.Add(this.tx_hdd);
            this.Controls.Add(this.tx_ram);
            this.Controls.Add(this.tx_cpu);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tx_cpu;
        private System.Windows.Forms.TextBox tx_ram;
        private System.Windows.Forms.TextBox tx_hdd;
        private System.Windows.Forms.TextBox tx_gpu;
        private System.Windows.Forms.Button bt_save;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tx_spec;
        private System.Windows.Forms.Button bt_load;
        private System.Windows.Forms.Button bt_left;
        private System.Windows.Forms.Button bt_right;
        private System.Windows.Forms.Button bt_download;
        private System.Windows.Forms.Button bt_loadfile;
    }
}

