namespace AppRabioButton
{
    partial class EstadoCivil
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
            this.radioButtonMasculino = new System.Windows.Forms.RadioButton();
            this.radioButtonFeminino = new System.Windows.Forms.RadioButton();
            this.radioButtonSolteiro = new System.Windows.Forms.RadioButton();
            this.radioButtonCasado = new System.Windows.Forms.RadioButton();
            this.radioButtonDivorciado = new System.Windows.Forms.RadioButton();
            this.radioButtonViuvo = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonEnviar = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.checkBoxAdm = new System.Windows.Forms.CheckBox();
            this.checkBoxDs = new System.Windows.Forms.CheckBox();
            this.checkBoxEdf = new System.Windows.Forms.CheckBox();
            this.checkBoxMeca = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioButtonMasculino
            // 
            this.radioButtonMasculino.AutoSize = true;
            this.radioButtonMasculino.Location = new System.Drawing.Point(6, 19);
            this.radioButtonMasculino.Name = "radioButtonMasculino";
            this.radioButtonMasculino.Size = new System.Drawing.Size(73, 17);
            this.radioButtonMasculino.TabIndex = 0;
            this.radioButtonMasculino.TabStop = true;
            this.radioButtonMasculino.Text = "Masculino";
            this.radioButtonMasculino.UseVisualStyleBackColor = true;
            this.radioButtonMasculino.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButtonFeminino
            // 
            this.radioButtonFeminino.AutoSize = true;
            this.radioButtonFeminino.Location = new System.Drawing.Point(6, 42);
            this.radioButtonFeminino.Name = "radioButtonFeminino";
            this.radioButtonFeminino.Size = new System.Drawing.Size(67, 17);
            this.radioButtonFeminino.TabIndex = 1;
            this.radioButtonFeminino.TabStop = true;
            this.radioButtonFeminino.Text = "Feminino";
            this.radioButtonFeminino.UseVisualStyleBackColor = true;
            this.radioButtonFeminino.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButtonSolteiro
            // 
            this.radioButtonSolteiro.AutoSize = true;
            this.radioButtonSolteiro.Location = new System.Drawing.Point(6, 19);
            this.radioButtonSolteiro.Name = "radioButtonSolteiro";
            this.radioButtonSolteiro.Size = new System.Drawing.Size(60, 17);
            this.radioButtonSolteiro.TabIndex = 2;
            this.radioButtonSolteiro.TabStop = true;
            this.radioButtonSolteiro.Text = "Solteiro";
            this.radioButtonSolteiro.UseVisualStyleBackColor = true;
            // 
            // radioButtonCasado
            // 
            this.radioButtonCasado.AutoSize = true;
            this.radioButtonCasado.Location = new System.Drawing.Point(6, 43);
            this.radioButtonCasado.Name = "radioButtonCasado";
            this.radioButtonCasado.Size = new System.Drawing.Size(61, 17);
            this.radioButtonCasado.TabIndex = 3;
            this.radioButtonCasado.TabStop = true;
            this.radioButtonCasado.Text = "Casado";
            this.radioButtonCasado.UseVisualStyleBackColor = true;
            // 
            // radioButtonDivorciado
            // 
            this.radioButtonDivorciado.AutoSize = true;
            this.radioButtonDivorciado.Location = new System.Drawing.Point(6, 67);
            this.radioButtonDivorciado.Name = "radioButtonDivorciado";
            this.radioButtonDivorciado.Size = new System.Drawing.Size(76, 17);
            this.radioButtonDivorciado.TabIndex = 4;
            this.radioButtonDivorciado.TabStop = true;
            this.radioButtonDivorciado.Text = "Divorciado";
            this.radioButtonDivorciado.UseVisualStyleBackColor = true;
            // 
            // radioButtonViuvo
            // 
            this.radioButtonViuvo.AutoSize = true;
            this.radioButtonViuvo.Location = new System.Drawing.Point(6, 91);
            this.radioButtonViuvo.Name = "radioButtonViuvo";
            this.radioButtonViuvo.Size = new System.Drawing.Size(52, 17);
            this.radioButtonViuvo.TabIndex = 5;
            this.radioButtonViuvo.TabStop = true;
            this.radioButtonViuvo.Text = "Viúvo";
            this.radioButtonViuvo.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonMasculino);
            this.groupBox1.Controls.Add(this.radioButtonFeminino);
            this.groupBox1.Location = new System.Drawing.Point(12, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(106, 119);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sexo";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButtonSolteiro);
            this.groupBox2.Controls.Add(this.radioButtonCasado);
            this.groupBox2.Controls.Add(this.radioButtonViuvo);
            this.groupBox2.Controls.Add(this.radioButtonDivorciado);
            this.groupBox2.Location = new System.Drawing.Point(124, 7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(104, 119);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Estado Civil";
            // 
            // buttonEnviar
            // 
            this.buttonEnviar.Location = new System.Drawing.Point(12, 132);
            this.buttonEnviar.Name = "buttonEnviar";
            this.buttonEnviar.Size = new System.Drawing.Size(419, 33);
            this.buttonEnviar.TabIndex = 8;
            this.buttonEnviar.Text = "Enviar";
            this.buttonEnviar.UseVisualStyleBackColor = true;
            this.buttonEnviar.Click += new System.EventHandler(this.buttonEnviar_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.checkBoxMeca);
            this.groupBox3.Controls.Add(this.checkBoxEdf);
            this.groupBox3.Controls.Add(this.checkBoxDs);
            this.groupBox3.Controls.Add(this.checkBoxAdm);
            this.groupBox3.Location = new System.Drawing.Point(235, 7);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 119);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Melhores cursos na Etec";
            // 
            // checkBoxAdm
            // 
            this.checkBoxAdm.AutoSize = true;
            this.checkBoxAdm.Location = new System.Drawing.Point(7, 20);
            this.checkBoxAdm.Name = "checkBoxAdm";
            this.checkBoxAdm.Size = new System.Drawing.Size(50, 17);
            this.checkBoxAdm.TabIndex = 0;
            this.checkBoxAdm.Text = "ADM";
            this.checkBoxAdm.UseVisualStyleBackColor = true;
            // 
            // checkBoxDs
            // 
            this.checkBoxDs.AutoSize = true;
            this.checkBoxDs.Location = new System.Drawing.Point(7, 44);
            this.checkBoxDs.Name = "checkBoxDs";
            this.checkBoxDs.Size = new System.Drawing.Size(41, 17);
            this.checkBoxDs.TabIndex = 1;
            this.checkBoxDs.Text = "DS";
            this.checkBoxDs.UseVisualStyleBackColor = true;
            // 
            // checkBoxEdf
            // 
            this.checkBoxEdf.AutoSize = true;
            this.checkBoxEdf.Location = new System.Drawing.Point(7, 68);
            this.checkBoxEdf.Name = "checkBoxEdf";
            this.checkBoxEdf.Size = new System.Drawing.Size(47, 17);
            this.checkBoxEdf.TabIndex = 2;
            this.checkBoxEdf.Text = "EDF";
            this.checkBoxEdf.UseVisualStyleBackColor = true;
            // 
            // checkBoxMeca
            // 
            this.checkBoxMeca.AutoSize = true;
            this.checkBoxMeca.Location = new System.Drawing.Point(7, 92);
            this.checkBoxMeca.Name = "checkBoxMeca";
            this.checkBoxMeca.Size = new System.Drawing.Size(56, 17);
            this.checkBoxMeca.TabIndex = 3;
            this.checkBoxMeca.Text = "MECA";
            this.checkBoxMeca.UseVisualStyleBackColor = true;
            // 
            // EstadoCivil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 177);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.buttonEnviar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "EstadoCivil";
            this.Text = "EstadoCivil";
            this.Load += new System.EventHandler(this.EstadoCivil_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButtonMasculino;
        private System.Windows.Forms.RadioButton radioButtonFeminino;
        private System.Windows.Forms.RadioButton radioButtonSolteiro;
        private System.Windows.Forms.RadioButton radioButtonCasado;
        private System.Windows.Forms.RadioButton radioButtonDivorciado;
        private System.Windows.Forms.RadioButton radioButtonViuvo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonEnviar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox checkBoxMeca;
        private System.Windows.Forms.CheckBox checkBoxEdf;
        private System.Windows.Forms.CheckBox checkBoxDs;
        private System.Windows.Forms.CheckBox checkBoxAdm;
    }
}