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

        private void button1_Click(object sender, EventArgs e) { }
        
        private void CboFrom_SelectedIndexChanged(object sender, EventArgs e) { }

        private void CboTo_SelectedIndexChanged(object sender, EventArgs e) { }
        
        private void button2_Click(object sender, EventArgs e)
        {
            ClassDetectaIdioma.DetectaIdioma();
            FrmLoanding FrmL = new FrmLoanding();
            FrmL.Show();
        }

        private void BtTraduzir_Click(object sender, EventArgs e)
        {
            //Verifica se algum idioma de saida foi escolhinho no combo           
            if (string.IsNullOrEmpty(CboTo.Text))
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
            BtTraduzir.Enabled = string.IsNullOrEmpty(CboFrom.Text) ? false : true;
        }

        private void TextFrom_TextChanged(object sender, EventArgs e)
        {           
            LblCountCharTf.Text = TextFrom.Text.Length + " de 200";
            if (TextFrom.Text.Length > 200) { MessageBox.Show("Limite de caractere excedido."); }
            if (TextFrom.Text.Length == 10) { ClassDetectaIdioma.DetectaIdioma(); return; }
            if (string.IsNullOrEmpty(TextFrom.Text)) { CboFrom.Text = string.Empty; }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {           
            TmrPreenchBox.Enabled = false;           
            ClassIdiomas.SelecionaIdioma();
        }      
    }
}
