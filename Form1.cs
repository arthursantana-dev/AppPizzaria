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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonEscolher_Click(object sender, EventArgs e)
        {
            if (radioButtonNerf.Checked)
            {
                MessageBox.Show("Você escolheu a única opção B)", "Brabo");
            } else
            {
                MessageBox.Show("Você escolheu nenhuma opção :(", "Paia");
            }
        }
    }
}
