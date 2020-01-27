namespace SpiderMan
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
            this.tx_posSM = new System.Windows.Forms.TextBox();
            this.tx_posB1 = new System.Windows.Forms.TextBox();
            this.tx_posB2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bt_calc_dist = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tx_posSM
            // 
            this.tx_posSM.Location = new System.Drawing.Point(193, 23);
            this.tx_posSM.Name = "tx_posSM";
            this.tx_posSM.Size = new System.Drawing.Size(28, 20);
            this.tx_posSM.TabIndex = 0;
            // 
            // tx_posB1
            // 
            this.tx_posB1.Location = new System.Drawing.Point(79, 116);
            this.tx_posB1.Name = "tx_posB1";
            this.tx_posB1.Size = new System.Drawing.Size(28, 20);
            this.tx_posB1.TabIndex = 1;
            // 
            // tx_posB2
            // 
            this.tx_posB2.Location = new System.Drawing.Point(143, 116);
            this.tx_posB2.Name = "tx_posB2";
            this.tx_posB2.Size = new System.Drawing.Size(28, 20);
            this.tx_posB2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Posicio Spider-Man:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(61, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Posicio Bombes:";
            // 
            // bt_calc_dist
            // 
            this.bt_calc_dist.Location = new System.Drawing.Point(54, 161);
            this.bt_calc_dist.Name = "bt_calc_dist";
            this.bt_calc_dist.Size = new System.Drawing.Size(143, 23);
            this.bt_calc_dist.TabIndex = 6;
            this.bt_calc_dist.Text = "Calcular Distancia";
            this.bt_calc_dist.UseVisualStyleBackColor = true;
            this.bt_calc_dist.Click += new System.EventHandler(this.bt_calc_dist_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 214);
            this.Controls.Add(this.bt_calc_dist);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tx_posB2);
            this.Controls.Add(this.tx_posB1);
            this.Controls.Add(this.tx_posSM);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tx_posSM;
        private System.Windows.Forms.TextBox tx_posB1;
        private System.Windows.Forms.TextBox tx_posB2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bt_calc_dist;
    }
}

