namespace AppRabioButton
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.radioButtonNerf = new System.Windows.Forms.RadioButton();
            this.radioButtonNada = new System.Windows.Forms.RadioButton();
            this.buttonEscolher = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Escolha uma das opções";
            // 
            // radioButtonNerf
            // 
            this.radioButtonNerf.AutoSize = true;
            this.radioButtonNerf.Location = new System.Drawing.Point(16, 40);
            this.radioButtonNerf.Name = "radioButtonNerf";
            this.radioButtonNerf.Size = new System.Drawing.Size(45, 17);
            this.radioButtonNerf.TabIndex = 1;
            this.radioButtonNerf.TabStop = true;
            this.radioButtonNerf.Text = "Nerf";
            this.radioButtonNerf.UseVisualStyleBackColor = true;
            // 
            // radioButtonNada
            // 
            this.radioButtonNada.AutoSize = true;
            this.radioButtonNada.Location = new System.Drawing.Point(16, 63);
            this.radioButtonNada.Name = "radioButtonNada";
            this.radioButtonNada.Size = new System.Drawing.Size(14, 13);
            this.radioButtonNada.TabIndex = 2;
            this.radioButtonNada.TabStop = true;
            this.radioButtonNada.UseVisualStyleBackColor = true;
            // 
            // buttonEscolher
            // 
            this.buttonEscolher.Location = new System.Drawing.Point(16, 83);
            this.buttonEscolher.Name = "buttonEscolher";
            this.buttonEscolher.Size = new System.Drawing.Size(75, 23);
            this.buttonEscolher.TabIndex = 3;
            this.buttonEscolher.Text = "Escolher";
            this.buttonEscolher.UseVisualStyleBackColor = true;
            this.buttonEscolher.Click += new System.EventHandler(this.buttonEscolher_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(185, 122);
            this.Controls.Add(this.buttonEscolher);
            this.Controls.Add(this.radioButtonNada);
            this.Controls.Add(this.radioButtonNerf);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButtonNerf;
        private System.Windows.Forms.RadioButton radioButtonNada;
        private System.Windows.Forms.Button buttonEscolher;
    }
}

