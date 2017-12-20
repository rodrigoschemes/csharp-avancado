using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaixaEletronico
{
    public partial class CadastroDeConta : Form
    {
        private CaixaEletronico aplicacaoPrincipal;

        public CadastroDeConta(CaixaEletronico aplicacaoPrincipal)
        {
            this.aplicacaoPrincipal = aplicacaoPrincipal;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Conta c;
            if (tipoDeConta.Text.Equals("Conta Poupança"))
            {
                c = new ContaPoupanca();
            }
            else if (tipoDeConta.Text.Equals("Conta Corrente"))
            {
                c = new ContaCorrente();
            }
            else
            {
                c = new ContaInvestimento();
            }


            c.Titular = new Cliente(titularConta.Text);
            c.Numero = Convert.ToInt32(numeroDaConta.Text);


            aplicacaoPrincipal.AdicionaConta(c);

            this.Close();
        }

        private void CadastroDeConta_Load(object sender, EventArgs e)
        {
            this.tipoDeConta.Items.Add("Conta Corrente");
            this.tipoDeConta.Items.Add("Conta Poupança");
            this.tipoDeConta.Items.Add("Conta Investimento");
        }
    }
}
