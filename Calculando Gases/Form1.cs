using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculando_Gases
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double pressao = Convert.ToDouble(textBox1.Text);
            double volume = Convert.ToDouble(textBox2.Text);
            double mols = Convert.ToDouble(textBox3.Text);
            double consta = Convert.ToDouble(textBox4.Text);
            double temp = Convert.ToDouble(textBox5.Text);
            double pressao2 = Convert.ToDouble(textBox7.Text);
            double volume2 = Convert.ToDouble(textBox8.Text);
            double temp2 = Convert.ToDouble(textBox9.Text);
            double mm = Convert.ToDouble(textBox10.Text);
            double massa = Convert.ToDouble(textBox11.Text);
            int molecula = Convert.ToInt32(textBox13.Text);
            if(mm != 0)
            {
                mols = massa / mm;
            }
            if(molecula !=  0)
            {
                mols = (molecula * (Math.Pow(10, 23))) / (6.02 * (Math.Pow(10, 23)));
            }
            if (Convert.ToDouble(textBox6.Text) == 1)
            {
                double resultado = (mols * consta * temp) / volume;
                label6.Text = $"O resultado é: {resultado}";
            }
            else if(Convert.ToDouble(textBox6.Text) == 2)
            {
                double resultado = (mols * consta * temp) / pressao;
                label6.Text = $"O resultado é: {resultado}";
            }
            else if (Convert.ToDouble(textBox6.Text) == 3)
            {
                double resultado = (volume * pressao) / (consta * temp);
                label6.Text = $"O resultado é: {resultado}";
            }
            else if (Convert.ToDouble(textBox6.Text) == 4)
            {
                double resultado = (volume * pressao) / (consta * mols);
                label6.Text = $"O resultado é: {resultado}";
            }
            else if (Convert.ToDouble(textBox6.Text) == 5)
            {
                double resultado = (volume * pressao * temp2) / (volume2 * temp);
                label6.Text = $"O resultado é: {resultado}";
            }
            else if (Convert.ToDouble(textBox6.Text) == 6)
            {
                double resultado = (volume * pressao * temp2) / (pressao2 * temp);
                label6.Text = $"O resultado é: {resultado}";
            }
            else if (Convert.ToDouble(textBox6.Text) == 7)
            {
                double resultado = (pressao2 * volume2 * temp) / (pressao * volume) ;
                label6.Text = $"O resultado é: {resultado}";
            }
            else if (Convert.ToDouble(textBox6.Text) == 8)
            {
                double resultado = (volume2 * pressao2 * temp) / (volume * temp2);
                label6.Text = $"O resultado é: {resultado}";
            }
            else if (Convert.ToDouble(textBox6.Text) == 9)
            {
                double resultado = (volume2 * pressao2 * temp) / (pressao * temp2);
                label6.Text = $"O resultado é: {resultado}";
            }
            else if (Convert.ToDouble(textBox6.Text) == 10)
            {
                double resultado = (volume * pressao * temp2) / (pressao2 * volume2);
                label6.Text = $"O resultado é: {resultado}";
            }
            else
            {
                label6.Text = $"Não há esta opção de cálculo";
            }
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
