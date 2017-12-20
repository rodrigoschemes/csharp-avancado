using System;

namespace CaixaEletronico
{
        public class Cliente
        {
            public string Nome { get; set; }
            public string Rg { get; set; }
            public string cpf;
            public string endereco;
            public int idade;
            private bool EEmancipado;

            public Cliente(string nome)
            {
                this.Nome = nome;
            }

            public Cliente() { }

            public bool PodeAbrirContaSozinho
            {
                get
                {
                    var maiorDeIdade = this.idade >= 18;
                    var emancipado = (this.EEmancipado);
                    var possuiCPF = !string.IsNullOrEmpty(this.cpf);
                    return (maiorDeIdade || emancipado) && possuiCPF;
                }
            }

            public bool EhMaiorDeIdade()
            {
                return this.idade >= 18;
            }

            public override bool Equals(Object objeto)
            {
                Cliente outroCliente = (Cliente)objeto;
                return this.Rg == outroCliente.Rg;
            }

            public override string ToString()
            {
                return "Nome: " + this.Nome + " RG: " + this.Rg;
            }
    }
}