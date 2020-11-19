namespace dbSQLSERVER
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
            this.bt_db = new System.Windows.Forms.Button();
            this.bt_table = new System.Windows.Forms.Button();
            this.bt_register = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tx_db = new System.Windows.Forms.TextBox();
            this.tx_table = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cb_dbnames = new System.Windows.Forms.ComboBox();
            this.bt_Update = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_db
            // 
            this.bt_db.Location = new System.Drawing.Point(12, 12);
            this.bt_db.Name = "bt_db";
            this.bt_db.Size = new System.Drawing.Size(101, 34);
            this.bt_db.TabIndex = 0;
            this.bt_db.Text = "Create db";
            this.bt_db.UseVisualStyleBackColor = true;
            this.bt_db.Click += new System.EventHandler(this.bt_db_Click);
            // 
            // bt_table
            // 
            this.bt_table.Location = new System.Drawing.Point(119, 12);
            this.bt_table.Name = "bt_table";
            this.bt_table.Size = new System.Drawing.Size(101, 34);
            this.bt_table.TabIndex = 1;
            this.bt_table.Text = "Create Table";
            this.bt_table.UseVisualStyleBackColor = true;
            this.bt_table.Click += new System.EventHandler(this.bt_table_Click);
            // 
            // bt_register
            // 
            this.bt_register.Location = new System.Drawing.Point(687, 404);
            this.bt_register.Name = "bt_register";
            this.bt_register.Size = new System.Drawing.Size(101, 34);
            this.bt_register.TabIndex = 2;
            this.bt_register.Text = "Registrar";
            this.bt_register.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(663, 368);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(132, 20);
            this.textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(645, 342);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(150, 20);
            this.textBox3.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(576, 342);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Usuari :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(575, 366);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Password: ";
            // 
            // tx_db
            // 
            this.tx_db.Location = new System.Drawing.Point(13, 52);
            this.tx_db.Name = "tx_db";
            this.tx_db.Size = new System.Drawing.Size(100, 20);
            this.tx_db.TabIndex = 8;
            // 
            // tx_table
            // 
            this.tx_table.Location = new System.Drawing.Point(120, 52);
            this.tx_table.Name = "tx_table";
            this.tx_table.Size = new System.Drawing.Size(100, 20);
            this.tx_table.TabIndex = 9;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 78);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(557, 360);
            this.dataGridView1.TabIndex = 10;
            // 
            // cb_dbnames
            // 
            this.cb_dbnames.FormattingEnabled = true;
            this.cb_dbnames.Location = new System.Drawing.Point(667, 20);
            this.cb_dbnames.Name = "cb_dbnames";
            this.cb_dbnames.Size = new System.Drawing.Size(121, 21);
            this.cb_dbnames.TabIndex = 11;
            // 
            // bt_Update
            // 
            this.bt_Update.Location = new System.Drawing.Point(586, 18);
            this.bt_Update.Name = "bt_Update";
            this.bt_Update.Size = new System.Drawing.Size(75, 23);
            this.bt_Update.TabIndex = 12;
            this.bt_Update.Text = "Actualitzar";
            this.bt_Update.UseVisualStyleBackColor = true;
            this.bt_Update.Click += new System.EventHandler(this.bt_Update_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bt_Update);
            this.Controls.Add(this.cb_dbnames);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tx_table);
            this.Controls.Add(this.tx_db);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.bt_register);
            this.Controls.Add(this.bt_table);
            this.Controls.Add(this.bt_db);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_db;
        private System.Windows.Forms.Button bt_table;
        private System.Windows.Forms.Button bt_register;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tx_db;
        private System.Windows.Forms.TextBox tx_table;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cb_dbnames;
        private System.Windows.Forms.Button bt_Update;
    }
}

