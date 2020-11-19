namespace Generador_de_frases
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
            this.tx_frase = new System.Windows.Forms.TextBox();
            this.tx_verb = new System.Windows.Forms.TextBox();
            this.tx_adjectiu = new System.Windows.Forms.TextBox();
            this.bt_frase = new System.Windows.Forms.Button();
            this.bt_verb = new System.Windows.Forms.Button();
            this.bt_adjectiu = new System.Windows.Forms.Button();
            this.bt_generar = new System.Windows.Forms.Button();
            this.tx_main = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tx_frase
            // 
            this.tx_frase.Location = new System.Drawing.Point(12, 41);
            this.tx_frase.Name = "tx_frase";
            this.tx_frase.Size = new System.Drawing.Size(224, 20);
            this.tx_frase.TabIndex = 0;
            // 
            // tx_verb
            // 
            this.tx_verb.Location = new System.Drawing.Point(242, 41);
            this.tx_verb.Name = "tx_verb";
            this.tx_verb.Size = new System.Drawing.Size(114, 20);
            this.tx_verb.TabIndex = 1;
            // 
            // tx_adjectiu
            // 
            this.tx_adjectiu.Location = new System.Drawing.Point(362, 41);
            this.tx_adjectiu.Name = "tx_adjectiu";
            this.tx_adjectiu.Size = new System.Drawing.Size(114, 20);
            this.tx_adjectiu.TabIndex = 2;
            // 
            // bt_frase
            // 
            this.bt_frase.Location = new System.Drawing.Point(76, 67);
            this.bt_frase.Name = "bt_frase";
            this.bt_frase.Size = new System.Drawing.Size(75, 23);
            this.bt_frase.TabIndex = 3;
            this.bt_frase.Text = "Add frase";
            this.bt_frase.UseVisualStyleBackColor = true;
            // 
            // bt_verb
            // 
            this.bt_verb.Location = new System.Drawing.Point(260, 67);
            this.bt_verb.Name = "bt_verb";
            this.bt_verb.Size = new System.Drawing.Size(75, 23);
            this.bt_verb.TabIndex = 4;
            this.bt_verb.Text = "Add Verb";
            this.bt_verb.UseVisualStyleBackColor = true;
            // 
            // bt_adjectiu
            // 
            this.bt_adjectiu.Location = new System.Drawing.Point(384, 67);
            this.bt_adjectiu.Name = "bt_adjectiu";
            this.bt_adjectiu.Size = new System.Drawing.Size(75, 23);
            this.bt_adjectiu.TabIndex = 5;
            this.bt_adjectiu.Text = "Add Adjectiu";
            this.bt_adjectiu.UseVisualStyleBackColor = true;
            // 
            // bt_generar
            // 
            this.bt_generar.Location = new System.Drawing.Point(190, 148);
            this.bt_generar.Name = "bt_generar";
            this.bt_generar.Size = new System.Drawing.Size(75, 23);
            this.bt_generar.TabIndex = 6;
            this.bt_generar.Text = "Generar";
            this.bt_generar.UseVisualStyleBackColor = true;
            // 
            // tx_main
            // 
            this.tx_main.Location = new System.Drawing.Point(1, 177);
            this.tx_main.Name = "tx_main";
            this.tx_main.Size = new System.Drawing.Size(475, 20);
            this.tx_main.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Generador de frases";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 237);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tx_main);
            this.Controls.Add(this.bt_generar);
            this.Controls.Add(this.bt_adjectiu);
            this.Controls.Add(this.bt_verb);
            this.Controls.Add(this.bt_frase);
            this.Controls.Add(this.tx_adjectiu);
            this.Controls.Add(this.tx_verb);
            this.Controls.Add(this.tx_frase);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tx_frase;
        private System.Windows.Forms.TextBox tx_verb;
        private System.Windows.Forms.TextBox tx_adjectiu;
        private System.Windows.Forms.Button bt_frase;
        private System.Windows.Forms.Button bt_verb;
        private System.Windows.Forms.Button bt_adjectiu;
        private System.Windows.Forms.Button bt_generar;
        private System.Windows.Forms.TextBox tx_main;
        private System.Windows.Forms.Label label1;
    }
}

