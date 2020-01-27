namespace StanLee
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
            this.tx_search = new System.Windows.Forms.TextBox();
            this.bt_search = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tx_search
            // 
            this.tx_search.Location = new System.Drawing.Point(12, 12);
            this.tx_search.Multiline = true;
            this.tx_search.Name = "tx_search";
            this.tx_search.Size = new System.Drawing.Size(776, 201);
            this.tx_search.TabIndex = 0;
            // 
            // bt_search
            // 
            this.bt_search.Location = new System.Drawing.Point(309, 231);
            this.bt_search.Name = "bt_search";
            this.bt_search.Size = new System.Drawing.Size(174, 39);
            this.bt_search.TabIndex = 1;
            this.bt_search.Text = "Search";
            this.bt_search.UseVisualStyleBackColor = true;
            this.bt_search.Click += new System.EventHandler(this.bt_search_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 294);
            this.Controls.Add(this.bt_search);
            this.Controls.Add(this.tx_search);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tx_search;
        private System.Windows.Forms.Button bt_search;
    }
}

