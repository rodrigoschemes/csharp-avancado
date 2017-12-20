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
    public partial class CaixaEletronico : Form
    {
        private List<Conta> contas;
        private int quantidadeDeContas;

        public CaixaEletronico()
        {
            InitializeComponent();
        }

        private void CaixaEletronico_Load(object sender, EventArgs e)
        {
            this.CriarContas();
        }

        private void CriarContas()
        {
            contas = new List<Conta>();

            Conta c1 = new ContaCorrente()
            {
                Titular = new Cliente("Roberta Cintra"),
                Numero = 9644
            };

            c1.Deposita(100);

            Conta c2 = new ContaCorrente()
            {
                Titular = new Cliente("Rodrigo Schemes"),
                Numero = 4567
            };

            c2.Deposita(500);

            Conta c3 = new ContaCorrente()
            {
                Titular = new Cliente("Raul Cintra"),
                Numero = 7890
            };

            c3.Deposita(1000);

            contas.Add(c1);
            contas.Add(c2);
            contas.Add(c3);

            this.quantidadeDeContas = 3;

            foreach (Conta conta in contas)
            {
                if (conta != null)
                    comboContas.Items.Add(conta.Titular.Nome);
            }


        }

        private void btnSacar_Click(object sender, EventArgs e)
        {
            try
            {
                string textoValorSaque = valorOperacao.Text;
                double valorSaque = Convert.ToDouble(textoValorSaque);

                Conta contaAtual = this.BuscaContaSelecionada();
                contaAtual.Saca(valorSaque);
                MessageBox.Show("Dinheiro Liberado");

                MostraConta(contaAtual);
            }
            catch (SaldoInsuficienteException ex)
            {
                MessageBox.Show("Saldo insuficiente");
            }
            catch (System.ArgumentException ex)
            {
                MessageBox.Show("Valor do saque inválido.");
            }
            catch (System.FormatException ex)
            {
                MessageBox.Show("Informar um número válido");
            }
            catch (System.NullReferenceException ex)
            {
                MessageBox.Show("Selecionar uma conta");
            }

        }

        

        private void MostraConta(Conta contaSelecionada)
        {
            textoConta.Text = Convert.ToString(contaSelecionada.Numero);
            textoSaldo.Text = Convert.ToString(contaSelecionada.Saldo);
            textoTitular.Text = contaSelecionada.Titular.Nome;
        }

        

        private void comboContas_SelectedIndexChanged(object sender, EventArgs e)
        {
            string titularSelecionado = comboContas.Text;
            Conta contaSelecionada = this.BuscaContaSelecionada();
            this.MostraConta(contaSelecionada);
        }

        public void AdicionaConta(Conta c)
        {
            this.contas.Add(c);

            comboContas.Items.Add(c.Titular.Nome);
        }

        private void btnCadastrarConta_Click(object sender, EventArgs e)
        {
            CadastroDeConta formularioDeCadastro = new CadastroDeConta(this);

            formularioDeCadastro.ShowDialog();
        }

        private Conta BuscaContaSelecionada()
        {
            int indiceSelecionado = comboContas.SelectedIndex;
            return this.contas[indiceSelecionado];
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            Conta c = BuscaContaSelecionada();

            comboContas.Items.Remove(c);

            this.contas.Remove(c);
        }
    }
}
