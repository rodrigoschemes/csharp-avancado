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
    public partial class TesteObject : Form
    {
        public TesteObject()
        {
            InitializeComponent();
        }

        private void TesteObject_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cliente guilherme = new Cliente("Guilherme Silveira");
            guilherme.Rg = "12345678-9";

            Cliente mauricio = new Cliente("Mauricio Aniche");
            mauricio.Rg = "12345678-9";

            MessageBox.Show(guilherme.Equals(mauricio).ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Cliente guilherme = new Cliente("Guilherme");
            guilherme.Rg = "12345678-9";
            MessageBox.Show(guilherme.ToString());
        }
    }
}
