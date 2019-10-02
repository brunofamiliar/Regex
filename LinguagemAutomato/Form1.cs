using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinguagemAutomato
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonEnviar_Click(object sender, EventArgs e)
        {
            string expressao = textBoxExpressao.Text;
            var t = Automato.Instance.Gerar(expressao);

            MessageBox.Show("Teste");
        }
    }
}
