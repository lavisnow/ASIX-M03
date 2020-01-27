namespace Wheeloffortune
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
            this.txPhrase = new System.Windows.Forms.TextBox();
            this.txTry = new System.Windows.Forms.TextBox();
            this.txMarker1 = new System.Windows.Forms.TextBox();
            this.txSolve = new System.Windows.Forms.TextBox();
            this.txMarker2 = new System.Windows.Forms.TextBox();
            this.btStart = new System.Windows.Forms.Button();
            this.btPull = new System.Windows.Forms.Button();
            this.btTry = new System.Windows.Forms.Button();
            this.btSolve = new System.Windows.Forms.Button();
            this.ptbox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ptbox)).BeginInit();
            this.SuspendLayout();
            // 
            // txPhrase
            // 
            this.txPhrase.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txPhrase.Location = new System.Drawing.Point(112, 44);
            this.txPhrase.Multiline = true;
            this.txPhrase.Name = "txPhrase";
            this.txPhrase.Size = new System.Drawing.Size(666, 303);
            this.txPhrase.TabIndex = 0;
            this.txPhrase.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txTry
            // 
            this.txTry.Location = new System.Drawing.Point(826, 211);
            this.txTry.Multiline = true;
            this.txTry.Name = "txTry";
            this.txTry.Size = new System.Drawing.Size(44, 40);
            this.txTry.TabIndex = 2;
            this.txTry.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txMarker1
            // 
            this.txMarker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txMarker1.Location = new System.Drawing.Point(112, 461);
            this.txMarker1.Multiline = true;
            this.txMarker1.Name = "txMarker1";
            this.txMarker1.Size = new System.Drawing.Size(204, 94);
            this.txMarker1.TabIndex = 3;
            this.txMarker1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txSolve
            // 
            this.txSolve.Location = new System.Drawing.Point(112, 356);
            this.txSolve.Multiline = true;
            this.txSolve.Name = "txSolve";
            this.txSolve.Size = new System.Drawing.Size(666, 60);
            this.txSolve.TabIndex = 4;
            this.txSolve.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txMarker2
            // 
            this.txMarker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txMarker2.Location = new System.Drawing.Point(574, 461);
            this.txMarker2.Multiline = true;
            this.txMarker2.Name = "txMarker2";
            this.txMarker2.Size = new System.Drawing.Size(204, 94);
            this.txMarker2.TabIndex = 5;
            this.txMarker2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btStart
            // 
            this.btStart.Location = new System.Drawing.Point(806, 44);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(127, 49);
            this.btStart.TabIndex = 6;
            this.btStart.Text = "Start";
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Click += new System.EventHandler(this.BtStart_Click);
            // 
            // btPull
            // 
            this.btPull.Location = new System.Drawing.Point(1110, 546);
            this.btPull.Name = "btPull";
            this.btPull.Size = new System.Drawing.Size(211, 43);
            this.btPull.TabIndex = 7;
            this.btPull.Text = "Tirar";
            this.btPull.UseVisualStyleBackColor = true;
            this.btPull.Click += new System.EventHandler(this.BtPull_Click);
            // 
            // btTry
            // 
            this.btTry.Location = new System.Drawing.Point(886, 216);
            this.btTry.Name = "btTry";
            this.btTry.Size = new System.Drawing.Size(47, 30);
            this.btTry.TabIndex = 8;
            this.btTry.Text = "Letra";
            this.btTry.UseVisualStyleBackColor = true;
            this.btTry.Click += new System.EventHandler(this.BtTry_Click);
            // 
            // btSolve
            // 
            this.btSolve.Location = new System.Drawing.Point(794, 370);
            this.btSolve.Name = "btSolve";
            this.btSolve.Size = new System.Drawing.Size(123, 30);
            this.btSolve.TabIndex = 9;
            this.btSolve.Text = "Resoldre";
            this.btSolve.UseVisualStyleBackColor = true;
            this.btSolve.Click += new System.EventHandler(this.BtSolve_Click);
            // 
            // ptbox
            // 
            this.ptbox.Location = new System.Drawing.Point(1012, 55);
            this.ptbox.Name = "ptbox";
            this.ptbox.Size = new System.Drawing.Size(391, 485);
            this.ptbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbox.TabIndex = 10;
            this.ptbox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(160, 434);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 24);
            this.label1.TabIndex = 11;
            this.label1.Text = "Marcador 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(632, 434);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 24);
            this.label2.TabIndex = 12;
            this.label2.Text = "Marcador 2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1435, 617);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ptbox);
            this.Controls.Add(this.btSolve);
            this.Controls.Add(this.btTry);
            this.Controls.Add(this.btPull);
            this.Controls.Add(this.btStart);
            this.Controls.Add(this.txMarker2);
            this.Controls.Add(this.txSolve);
            this.Controls.Add(this.txMarker1);
            this.Controls.Add(this.txTry);
            this.Controls.Add(this.txPhrase);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ptbox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txPhrase;
        private System.Windows.Forms.TextBox txTry;
        private System.Windows.Forms.TextBox txMarker1;
        private System.Windows.Forms.TextBox txSolve;
        private System.Windows.Forms.TextBox txMarker2;
        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.Button btPull;
        private System.Windows.Forms.Button btTry;
        private System.Windows.Forms.Button btSolve;
        private System.Windows.Forms.PictureBox ptbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

