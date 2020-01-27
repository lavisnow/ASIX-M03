namespace Piedra_Papel_Tijera_Lagarto_Spock
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
            this.tx_j1 = new System.Windows.Forms.TextBox();
            this.bt_res = new System.Windows.Forms.Button();
            this.tx_j2 = new System.Windows.Forms.TextBox();
            this.tx_res = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tx_j1
            // 
            this.tx_j1.Location = new System.Drawing.Point(87, 46);
            this.tx_j1.Multiline = true;
            this.tx_j1.Name = "tx_j1";
            this.tx_j1.Size = new System.Drawing.Size(148, 23);
            this.tx_j1.TabIndex = 0;
            // 
            // bt_res
            // 
            this.bt_res.Location = new System.Drawing.Point(157, 144);
            this.bt_res.Name = "bt_res";
            this.bt_res.Size = new System.Drawing.Size(203, 62);
            this.bt_res.TabIndex = 2;
            this.bt_res.Text = "Resultat";
            this.bt_res.UseVisualStyleBackColor = true;
            this.bt_res.Click += new System.EventHandler(this.Bt_res_Click);
            // 
            // tx_j2
            // 
            this.tx_j2.Location = new System.Drawing.Point(275, 46);
            this.tx_j2.Multiline = true;
            this.tx_j2.Name = "tx_j2";
            this.tx_j2.Size = new System.Drawing.Size(148, 23);
            this.tx_j2.TabIndex = 3;
            // 
            // tx_res
            // 
            this.tx_res.Location = new System.Drawing.Point(190, 95);
            this.tx_res.Multiline = true;
            this.tx_res.Name = "tx_res";
            this.tx_res.Size = new System.Drawing.Size(148, 23);
            this.tx_res.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(125, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Jugador 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(313, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Jugador 2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 344);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tx_res);
            this.Controls.Add(this.tx_j2);
            this.Controls.Add(this.bt_res);
            this.Controls.Add(this.tx_j1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tx_j1;
        private System.Windows.Forms.Button bt_res;
        private System.Windows.Forms.TextBox tx_j2;
        private System.Windows.Forms.TextBox tx_res;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

