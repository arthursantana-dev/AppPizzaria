using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppRabioButton
{
    public partial class EstadoCivil : Form
    {
        public EstadoCivil()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void splitter1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void buttonEnviar_Click(object sender, EventArgs e)
        {
            string estadoCivil = "";
            string sexo = radioButtonMasculino.Checked ? "Masculino" : "Feminino";
            string mensagemCurso = "";

            //estadoCivil = radioButtonCasado.Checked ? "Casado" : "";
            //estadoCivil = radioButtonSolteiro.Checked ? "Solteiro" : "";
            //estadoCivil = radioButtonDivorciado.Checked ? "Divorciado" : "";
            //estadoCivil = radioButtonViuvo.Checked ? "Viuvo" : "";

            if (radioButtonCasado.Checked)
            {
                estadoCivil = "Casado";
            } else if (radioButtonSolteiro.Checked)
            {
                estadoCivil = "Solteiro";
            }
            else if (radioButtonDivorciado.Checked)
            {
                estadoCivil = "Divorciado";
            }
            else
            {
                estadoCivil = "Viuvo";
            }

            if (checkBoxDs.Checked)
            {
                mensagemCurso = "e você é sensato";
            } else
            {
                mensagemCurso = "e você é um trouxa";
            }

                MessageBox.Show($"Você é do sexo {sexo} é seu estado civil é {estadoCivil} {mensagemCurso}");
        }

        private void EstadoCivil_Load(object sender, EventArgs e)
        {
            groupBox2.Enabled = false;
            buttonEnviar.Enabled = false;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            groupBox2.Enabled = true;
            buttonEnviar.Enabled = true;
        }
    }
}
