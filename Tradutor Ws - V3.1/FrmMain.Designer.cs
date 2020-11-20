
namespace Tradutor_Ws___V3._1
{
    partial class FrmMain
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.CboFrom = new System.Windows.Forms.ComboBox();
            this.TextFrom = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.CboTo = new System.Windows.Forms.ComboBox();
            this.TextIdiomaDetect = new System.Windows.Forms.TextBox();
            this.TextFunc = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.LblIdiFrom = new System.Windows.Forms.Label();
            this.TextTo = new System.Windows.Forms.TextBox();
            this.BtTraduzir = new System.Windows.Forms.Button();
            this.TextIdSaida = new System.Windows.Forms.TextBox();
            this.TmrCheckCbo1 = new System.Windows.Forms.Timer(this.components);
            this.TmrPreenchBox = new System.Windows.Forms.Timer(this.components);
            this.LblCountCharTf = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // CboFrom
            // 
            this.CboFrom.FormattingEnabled = true;
            this.CboFrom.Location = new System.Drawing.Point(12, 21);
            this.CboFrom.Name = "CboFrom";
            this.CboFrom.Size = new System.Drawing.Size(159, 21);
            this.CboFrom.Sorted = true;
            this.CboFrom.TabIndex = 0;
            this.CboFrom.SelectedIndexChanged += new System.EventHandler(this.CboFrom_SelectedIndexChanged);
            // 
            // TextFrom
            // 
            this.TextFrom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextFrom.Location = new System.Drawing.Point(15, 49);
            this.TextFrom.Multiline = true;
            this.TextFrom.Name = "TextFrom";
            this.TextFrom.Size = new System.Drawing.Size(332, 52);
            this.TextFrom.TabIndex = 1;
            this.TextFrom.TextChanged += new System.EventHandler(this.TextFrom_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(475, 202);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 38);
            this.button1.TabIndex = 2;
            this.button1.TabStop = false;
            this.button1.Text = "Preenche Cbo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CboTo
            // 
            this.CboTo.FormattingEnabled = true;
            this.CboTo.Location = new System.Drawing.Point(191, 21);
            this.CboTo.Name = "CboTo";
            this.CboTo.Size = new System.Drawing.Size(159, 21);
            this.CboTo.Sorted = true;
            this.CboTo.TabIndex = 3;
            this.CboTo.SelectedIndexChanged += new System.EventHandler(this.CboTo_SelectedIndexChanged);
            // 
            // TextIdiomaDetect
            // 
            this.TextIdiomaDetect.Location = new System.Drawing.Point(475, 12);
            this.TextIdiomaDetect.Name = "TextIdiomaDetect";
            this.TextIdiomaDetect.Size = new System.Drawing.Size(54, 20);
            this.TextIdiomaDetect.TabIndex = 4;
            this.TextIdiomaDetect.TabStop = false;
            this.TextIdiomaDetect.Visible = false;
            // 
            // TextFunc
            // 
            this.TextFunc.Location = new System.Drawing.Point(475, 74);
            this.TextFunc.Name = "TextFunc";
            this.TextFunc.Size = new System.Drawing.Size(54, 20);
            this.TextFunc.TabIndex = 5;
            this.TextFunc.TabStop = false;
            this.TextFunc.Text = "Inicio";
            this.TextFunc.Visible = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(475, 158);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 38);
            this.button2.TabIndex = 6;
            this.button2.TabStop = false;
            this.button2.Text = "Detecta";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // LblIdiFrom
            // 
            this.LblIdiFrom.AutoSize = true;
            this.LblIdiFrom.Location = new System.Drawing.Point(12, 207);
            this.LblIdiFrom.Name = "LblIdiFrom";
            this.LblIdiFrom.Size = new System.Drawing.Size(0, 13);
            this.LblIdiFrom.TabIndex = 7;
            // 
            // TextTo
            // 
            this.TextTo.Location = new System.Drawing.Point(12, 125);
            this.TextTo.Multiline = true;
            this.TextTo.Name = "TextTo";
            this.TextTo.Size = new System.Drawing.Size(338, 71);
            this.TextTo.TabIndex = 8;
            // 
            // BtTraduzir
            // 
            this.BtTraduzir.Location = new System.Drawing.Point(275, 202);
            this.BtTraduzir.Name = "BtTraduzir";
            this.BtTraduzir.Size = new System.Drawing.Size(75, 23);
            this.BtTraduzir.TabIndex = 9;
            this.BtTraduzir.Text = "Traduzir";
            this.BtTraduzir.UseVisualStyleBackColor = true;
            this.BtTraduzir.Click += new System.EventHandler(this.BtTraduzir_Click);
            // 
            // TextIdSaida
            // 
            this.TextIdSaida.Location = new System.Drawing.Point(475, 38);
            this.TextIdSaida.Name = "TextIdSaida";
            this.TextIdSaida.Size = new System.Drawing.Size(54, 20);
            this.TextIdSaida.TabIndex = 10;
            this.TextIdSaida.TabStop = false;
            this.TextIdSaida.Visible = false;
            // 
            // TmrCheckCbo1
            // 
            this.TmrCheckCbo1.Enabled = true;
            this.TmrCheckCbo1.Tick += new System.EventHandler(this.TmrCheckCbo1_Tick);
            // 
            // TmrPreenchBox
            // 
            this.TmrPreenchBox.Enabled = true;
            this.TmrPreenchBox.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // LblCountCharTf
            // 
            this.LblCountCharTf.Location = new System.Drawing.Point(13, 102);
            this.LblCountCharTf.Name = "LblCountCharTf";
            this.LblCountCharTf.Size = new System.Drawing.Size(336, 15);
            this.LblCountCharTf.TabIndex = 11;
            this.LblCountCharTf.Text = "0 de 200";
            this.LblCountCharTf.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(12, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(338, 72);
            this.panel1.TabIndex = 12;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(369, 251);
            this.Controls.Add(this.LblCountCharTf);
            this.Controls.Add(this.TextIdSaida);
            this.Controls.Add(this.BtTraduzir);
            this.Controls.Add(this.TextTo);
            this.Controls.Add(this.LblIdiFrom);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.TextFunc);
            this.Controls.Add(this.TextIdiomaDetect);
            this.Controls.Add(this.CboTo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CboFrom);
            this.Controls.Add(this.TextFrom);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tradutor Ws";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.ComboBox CboFrom;
        public System.Windows.Forms.TextBox TextFrom;
        public System.Windows.Forms.ComboBox CboTo;
        public System.Windows.Forms.TextBox TextIdiomaDetect;
        public System.Windows.Forms.TextBox TextFunc;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.Label LblIdiFrom;
        public System.Windows.Forms.TextBox TextTo;
        private System.Windows.Forms.Button BtTraduzir;
        public System.Windows.Forms.TextBox TextIdSaida;
        private System.Windows.Forms.Timer TmrCheckCbo1;
        private System.Windows.Forms.Timer TmrPreenchBox;
        private System.Windows.Forms.Label LblCountCharTf;
        private System.Windows.Forms.Panel panel1;
    }
}

