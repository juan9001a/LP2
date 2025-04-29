using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Pmatrizes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExercicio1_Click(object sender, EventArgs e)
        {
            int[] vetor = new int[20];
            string auxiliar = "";
            for (int i = 0; i < vetor.Length; i++)
            {
                auxiliar = Interaction.InputBox($"Digite o {i+1} numero", "Entrada de dados");
                if (auxiliar == "")
                {
                    break;   
                }
                if (!int.TryParse(auxiliar, out vetor[i]))
                {
                    MessageBox.Show("numero inválido@");
                    i--;
                }
            }

            Array.Reverse(vetor); // inverte os dados
            auxiliar = "";
            foreach (int numero in vetor)
            {
                auxiliar += numero + "\n";
            }
            MessageBox.Show(auxiliar);


        }

        private void btnExercicio2_Click(object sender, EventArgs e)
        {
            ArrayList lista  = new ArrayList();
            lista.Add("Ana");
            lista.Add("André");
            lista.Add("Beatriz");
            lista.Add("Camila");
            lista.Add("joão");
            lista.Add("Joana");
            lista.Add("Otavio");
            lista.Add("Marcelo");
            lista.Add("pedro");
            lista.Add("Thais");

            lista.Remove("Otavio");

            string resultado = string.Join("\n", lista.ToArray());

            MessageBox.Show(resultado);
            
        }

        private void btnExercicio3_Click(object sender, EventArgs e)
        {
            double[,] notas = new double[20, 3];


        }
    }
}
