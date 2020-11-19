namespace SopaLletres_DB
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
            this.tx_result = new System.Windows.Forms.TextBox();
            this.bt_search = new System.Windows.Forms.Button();
            this.bt_start = new System.Windows.Forms.Button();
            this.bt_export = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tx_main
            // 
            this.tx_main.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_main.Location = new System.Drawing.Point(12, 50);
            this.tx_main.Multiline = true;
            this.tx_main.Name = "tx_main";
            this.tx_main.Size = new System.Drawing.Size(539, 426);
            this.tx_main.TabIndex = 4;
            // 
            // tx_result
            // 
            this.tx_result.Location = new System.Drawing.Point(573, 50);
            this.tx_result.Multiline = true;
            this.tx_result.Name = "tx_result";
            this.tx_result.Size = new System.Drawing.Size(184, 426);
            this.tx_result.TabIndex = 5;
            // 
            // bt_search
            // 
            this.bt_search.Location = new System.Drawing.Point(12, 12);
            this.bt_search.Name = "bt_search";
            this.bt_search.Size = new System.Drawing.Size(75, 23);
            this.bt_search.TabIndex = 6;
            this.bt_search.Text = "Buscar";
            this.bt_search.UseVisualStyleBackColor = true;
            this.bt_search.Click += new System.EventHandler(this.bt_search_Click);
            // 
            // bt_start
            // 
            this.bt_start.Location = new System.Drawing.Point(476, 12);
            this.bt_start.Name = "bt_start";
            this.bt_start.Size = new System.Drawing.Size(75, 23);
            this.bt_start.TabIndex = 7;
            this.bt_start.Text = "Començar";
            this.bt_start.UseVisualStyleBackColor = true;
            this.bt_start.Click += new System.EventHandler(this.bt_start_Click);
            // 
            // bt_export
            // 
            this.bt_export.Location = new System.Drawing.Point(573, 12);
            this.bt_export.Name = "bt_export";
            this.bt_export.Size = new System.Drawing.Size(75, 23);
            this.bt_export.TabIndex = 8;
            this.bt_export.Text = "Exportar";
            this.bt_export.UseVisualStyleBackColor = true;
            this.bt_export.Click += new System.EventHandler(this.bt_export_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(782, 50);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(585, 426);
            this.dataGridView1.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1452, 524);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bt_export);
            this.Controls.Add(this.bt_start);
            this.Controls.Add(this.bt_search);
            this.Controls.Add(this.tx_result);
            this.Controls.Add(this.tx_main);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tx_main;
        private System.Windows.Forms.TextBox tx_result;
        private System.Windows.Forms.Button bt_search;
        private System.Windows.Forms.Button bt_start;
        private System.Windows.Forms.Button bt_export;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

