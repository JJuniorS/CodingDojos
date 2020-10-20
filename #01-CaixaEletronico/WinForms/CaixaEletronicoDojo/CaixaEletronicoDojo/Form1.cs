using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaixaEletronicoDojo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void btn_Sacar_Click(object sender, EventArgs e)
        {
            
            int Qtd100 = 0;
            int Qtd50 = 0;
            int Qtd20 = 0;
            int Qtd10 = 0;
            bool isValid;
            bool OcorreuErro = false;
            decimal valorRestante = txt_ValorSacar.Text != "" ? Convert.ToDecimal(txt_ValorSacar.Text) : 0;

            if (valorRestante == 0)
            {
                MessageBox.Show("O valor inserido está vazio ou valor é igual a zero", "Campo vazio", MessageBoxButtons.OK, MessageBoxIcon.Error);
                OcorreuErro = true;
                return;
            }
            
            while (valorRestante != 0)
            {
                isValid = false;
                if (valorRestante >= 100)
                {
                    Qtd100++;
                    isValid = true;
                    valorRestante -= 100;
                } else if(valorRestante >= 50)
                {
                    Qtd50++;
                    isValid = true;
                    valorRestante -= 50;
                } else if(valorRestante >= 20)
                {
                    Qtd20++;
                    isValid = true;
                    valorRestante -= 20;
                } else if(valorRestante >= 10)
                {
                    Qtd10++;
                    isValid = true;
                    valorRestante -= 10;
                }

                if (isValid == false)
                {
                    MessageBox.Show("Valor inserido não é valído, caixa possui apenas notas de 100, 50, 20 e 10", "Valor invalído", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    OcorreuErro = true;
                    break;
                }
            }

            if (OcorreuErro == false)
            {
                txt_Notas100.Text = Qtd100.ToString();
                txt_Notas50.Text = Qtd50.ToString();
                txt_Notas20.Text = Qtd20.ToString();
                txt_Notas10.Text = Qtd10.ToString();
            }
        }

        private void btn_NovoSaque_Click(object sender, EventArgs e)
        {
            txt_ValorSacar.Text = string.Empty;
            txt_Notas100.Text = string.Empty;
            txt_Notas50.Text = string.Empty;
            txt_Notas20.Text = string.Empty;
            txt_Notas10.Text = string.Empty;
        }

        private void txt_ValorSacar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void btn_Sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
