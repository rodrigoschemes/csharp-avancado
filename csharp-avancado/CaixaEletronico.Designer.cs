namespace CaixaEletronico
{
    partial class CaixaEletronico
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textoConta = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textoTitular = new System.Windows.Forms.TextBox();
            this.textoSaldo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.valorOperacao = new System.Windows.Forms.TextBox();
            this.btnSacar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.comboContas = new System.Windows.Forms.ComboBox();
            this.btnCadastrarConta = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Conta";
            // 
            // textoConta
            // 
            this.textoConta.Location = new System.Drawing.Point(64, 160);
            this.textoConta.Name = "textoConta";
            this.textoConta.Size = new System.Drawing.Size(256, 22);
            this.textoConta.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Titular";
            // 
            // textoTitular
            // 
            this.textoTitular.Location = new System.Drawing.Point(64, 242);
            this.textoTitular.Name = "textoTitular";
            this.textoTitular.Size = new System.Drawing.Size(256, 22);
            this.textoTitular.TabIndex = 3;
            // 
            // textoSaldo
            // 
            this.textoSaldo.Location = new System.Drawing.Point(64, 317);
            this.textoSaldo.Name = "textoSaldo";
            this.textoSaldo.Size = new System.Drawing.Size(256, 22);
            this.textoSaldo.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 297);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Saldo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(402, 297);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Valor do Saque";
            // 
            // valorOperacao
            // 
            this.valorOperacao.Location = new System.Drawing.Point(405, 317);
            this.valorOperacao.Name = "valorOperacao";
            this.valorOperacao.Size = new System.Drawing.Size(256, 22);
            this.valorOperacao.TabIndex = 7;
            // 
            // btnSacar
            // 
            this.btnSacar.Location = new System.Drawing.Point(541, 345);
            this.btnSacar.Name = "btnSacar";
            this.btnSacar.Size = new System.Drawing.Size(120, 50);
            this.btnSacar.TabIndex = 8;
            this.btnSacar.Text = "Sacar";
            this.btnSacar.UseVisualStyleBackColor = true;
            this.btnSacar.Click += new System.EventHandler(this.btnSacar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(61, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Cliente";
            // 
            // comboContas
            // 
            this.comboContas.FormattingEnabled = true;
            this.comboContas.Location = new System.Drawing.Point(64, 59);
            this.comboContas.Name = "comboContas";
            this.comboContas.Size = new System.Drawing.Size(256, 24);
            this.comboContas.TabIndex = 10;
            this.comboContas.SelectedIndexChanged += new System.EventHandler(this.comboContas_SelectedIndexChanged);
            // 
            // btnCadastrarConta
            // 
            this.btnCadastrarConta.Location = new System.Drawing.Point(511, 59);
            this.btnCadastrarConta.Name = "btnCadastrarConta";
            this.btnCadastrarConta.Size = new System.Drawing.Size(154, 71);
            this.btnCadastrarConta.TabIndex = 11;
            this.btnCadastrarConta.Text = "Cadastrar Conta";
            this.btnCadastrarConta.UseVisualStyleBackColor = true;
            this.btnCadastrarConta.Click += new System.EventHandler(this.btnCadastrarConta_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.Location = new System.Drawing.Point(511, 160);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(154, 71);
            this.btnRemover.TabIndex = 12;
            this.btnRemover.Text = "Remover Conta";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // CaixaEletronico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 429);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.btnCadastrarConta);
            this.Controls.Add(this.comboContas);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnSacar);
            this.Controls.Add(this.valorOperacao);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textoSaldo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textoTitular);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textoConta);
            this.Controls.Add(this.label1);
            this.Name = "CaixaEletronico";
            this.Text = "CaixaEletronico";
            this.Load += new System.EventHandler(this.CaixaEletronico_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textoConta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textoTitular;
        private System.Windows.Forms.TextBox textoSaldo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox valorOperacao;
        private System.Windows.Forms.Button btnSacar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboContas;
        private System.Windows.Forms.Button btnCadastrarConta;
        private System.Windows.Forms.Button btnRemover;
    }
}