using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tradutor_Ws___V3._1
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            ClassDetectaIdioma.DetectaIdioma();
            FrmLoanding FrmL = new FrmLoanding();
            FrmL.Show();
        }

        private void CboFrom_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void CboTo_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void BtTraduzir_Click(object sender, EventArgs e)
        {
            //Verifica se algum idioma de saida foi escolhinho no combo
            int C = CboTo.Text.Length;

            if (C == 0)
            {
                MessageBox.Show("Informe o idioma para o qual quer traduzir");
            }
            else
            {
                TextFunc.Text = "SaidaOk";
                ClassIdiomas.SelecionaIdioma();
            }
        }

        private void TmrCheckCbo1_Tick(object sender, EventArgs e)
        {
            int C = CboFrom.Text.Length;

            if (C == 0)
            {
                BtTraduzir.Enabled = false;
            }
            else
            {
                BtTraduzir.Enabled = true;
            }
        }

        private void TextFrom_TextChanged(object sender, EventArgs e)

        {
           
            int C = TextFrom.TextLength;
            int Ccf = C;
            LblCountCharTf.Text = Ccf + " de 200";
            if (C > 200)
            {
                MessageBox.Show("Limite de caractere excedido.");
            }
            if (C == 10)
            {
                ClassDetectaIdioma.DetectaIdioma();
                return;
            }
            if (C == 0)
            {
                CboFrom.Text = "";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
            TmrPreenchBox.Enabled = false;
           
            ClassIdiomas.SelecionaIdioma();
        }

      
    }
}
