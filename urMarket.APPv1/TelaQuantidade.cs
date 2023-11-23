using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using urMarket.BLL;
using urMarket.MODEL;

namespace urMarket.APPv1
{
    public partial class TelaQuantidade : Form
    {
        int idUser = Login.idUser;
        int idProduto = TelaMarket.idProduto;


        public TelaQuantidade()
        {
            InitializeComponent();
            atualizarPag();
        }

        //httpPost
        private async void button1_Click(object sender, EventArgs e)
        {
            int qntd = int.Parse(textBox1.Text);
            TelaMarket telaMarket = new TelaMarket();
            Carrinho carrinho = await telaMarket.CadastrarCarrinho(idProduto, idUser, qntd);
            CarrinhoRepository.Add(carrinho);
            MessageBox.Show("Produto adicionado no carrinho");
            carrinho.Id = 0;
            Close();
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public static async Task<Produto> GetProdutoById(string url)
        {
            HttpClient httpClient = new HttpClient();
            HttpResponseMessage resposta = await httpClient.GetAsync(url);
            var content = await resposta.Content.ReadAsStringAsync();
            Produto prod = JsonConvert.DeserializeObject<Produto>(content);
            return prod;
        }

        private async void atualizarPag()
        {
            string url = $"http://localhost:5043/api/Produto/{idProduto}";
            Produto produto = await GetProdutoById(url);
            label1.Text = "Informe a quantidade do item: " + produto.Nome;
        }
    }
}
