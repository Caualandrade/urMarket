using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace urMarket.APPv1
{
    public partial class AcessoRestrito : Form
    {
        public AcessoRestrito()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string senhaInput = textBox1.Text;
            if (senhaInput == "ADMIN123")
            {
                CadastroAR cadastroAR = new CadastroAR();
                cadastroAR.ShowDialog();
            }
            else
            {
                MessageBox.Show("Senha incorreta");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.PasswordChar = '*';
        }
    }
}
