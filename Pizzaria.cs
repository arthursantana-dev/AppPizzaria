using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace AppRabioButton
{
    public partial class Pizzaria : Form
    {
        public Pizzaria()
        {
            InitializeComponent();
        }

        double[] precos = {
            17.50, 
            17.85, 
            16.10, 
            12.00, 
            20.50, 
            16.70, 
            15.50, 
            22.75, 
            3.45, 
            4.65, 
            5.50, 
            4.00, 
            3.50, 
            5.10, 
            2.85, 
            3.50, 
            4.20, 
            6.05, 
            4.25, 
            6.30, 
            4.10, 
            6.50};
        private void checkBox19_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.CheckBox[] checkboxes = { checkBoxModaDaCasa, checkBoxAtum, checkBoxBaiana, checkBoxBrocolis, checkBoxCalabresa, checkBoxMussarela, checkBoxQuatroQueijos, checkBoxStrogonoff, checkBoxSem, checkBoxCatupiry, checkBoxCheddar, checkBoxCervejaGarrafa, checkBoxCervejaLata, checkBoxCocaColaLata, checkBoxCocaColaLitro, checkBoxGuaranaLata, checkBoxGuaranaLitro, checkBoxAbacaxiCopo, checkBoxAbacaxiJarra, checkBoxLaranjaCopo, checkBoxLaranjaJarra, checkBoxMaracujaCopo, checkBoxMaracujaJarra };

            List<System.Windows.Forms.CheckBox> checkBoxes = new List<System.Windows.Forms.CheckBox>();
            List<System.Windows.Forms.CheckBox> checkboxesChecadas = checkBoxes;

            List<double> precoProdutosEscolhidos = new List<double>();

            foreach (System.Windows.Forms.CheckBox checkbox in checkboxes)
            {
                if (checkbox.Checked)
                {
                    checkboxesChecadas.Add(checkbox);
                }
            }

            checkboxesChecadas.ToArray();


            foreach (System.Windows.Forms.CheckBox checkbox in checkboxesChecadas)
            {
                int i = Array.IndexOf(checkboxes, checkbox);


                precoProdutosEscolhidos.Add(precos[i]);
            }

            foreach (double preco in precoProdutosEscolhidos)
            {
                Console.WriteLine($"{preco}");
            }
            

        }

        private void Pizzaria_Load(object sender, EventArgs e)
        {
            Label[] labelPrecos = {label2,  label3, label4, label5, label7, label8, label9, label10, label12,
            label13,
            label14,
            label15,
            label16,
            label17,
            label18,
            label19,
            label20,
            label21,
            label22,
            label23,
            label24,
            label25};

            for (int i = 0; i < labelPrecos.Length; i++)
            {
                Console.WriteLine($"{precos.Length}, {labelPrecos.Length}");
                //Console.WriteLine(i + ": " + labelPrecos[i] + " " + precos[i]);
                labelPrecos[i].Text = $"R${precos[i]}";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
