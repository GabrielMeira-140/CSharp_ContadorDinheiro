using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace notasmoedas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            richTB1.Clear();
            double Num = (double)(numUD1.Value);
            
            int nota50, nota20, nota10, nota5, nota2, moeda1real, moeda050, moeda025, moeda010, moeda05, moeda001, res;

            res = (int)Num;

            int nota100 = res / 10000;


            //parte das notas
            richTB1.AppendText("NOTAS:" + Environment.NewLine); //notas 

            
            richTB1.AppendText(nota100 + " nota(s) de R$ 100.00" + Environment.NewLine); //notas de 100

            res = res % 10000;
            nota50 = res / 5000;

            richTB1.AppendText(nota50 + " nota(s) de R$ 50.00" + Environment.NewLine); //notas de 50

            res = res % 5000;
            nota20 = res / 2000;

            richTB1.AppendText(nota20 + " nota(s) de R$ 20.00" + Environment.NewLine); //notas de 25

            res = res % 2000;
            nota10= res / 1000;

            richTB1.AppendText(nota10 + " nota(s) de R$ 10.00" + Environment.NewLine); //notas de 10

            res = res % 1000;
            nota5 = res / 500;

            richTB1.AppendText(nota5 + " nota(s) de R$ 5.00" + Environment.NewLine); //notas de 5

            res = res % 500;
            nota2 = res / 200;

            richTB1.AppendText(nota2 + " nota(s) de R$ 2.00" + Environment.NewLine); //notas de 2

            //parte das moedas
            richTB1.AppendText("MOEDAS:" + Environment.NewLine); // moedas

            res = res % 200;
            moeda1real = res / 100;

            richTB1.AppendText(moeda1real + " moeda(s) de R$ 1.00" + Environment.NewLine); // moedas de 1 real

            res = res % 100;
            moeda050 = res / 50;

            richTB1.AppendText(moeda050 + " moeda(s) de R$ 0.50" + Environment.NewLine);  // moedas de 0,50

            res = res % 50;
            moeda025 = res / 25;

            richTB1.AppendText(moeda025 + " moeda(s) de R$ 0.25" + Environment.NewLine); // moedas de 0,25

            res = res % 25;
            moeda010 = res / 10;

            richTB1.AppendText(moeda010 + " moeda(s) de R$ 0.10" + Environment.NewLine); // moedas de 0,10

            res = res % 10;
            moeda05 = res / 5;

            richTB1.AppendText(moeda05 + " moeda(s) de R$ 0.05" + Environment.NewLine); // moedas de 0,05

            res = res % 5;
            moeda001 = res;

            richTB1.AppendText(moeda001 + " moeda(s) de R$ 0.01" + Environment.NewLine); // moedas de 0,01


        }
    }
    
}
