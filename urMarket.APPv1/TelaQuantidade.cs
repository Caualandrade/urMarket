using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Web;
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
            atualizarFraseDaPagina();
        }

        
        private async void button1_Click(object sender, EventArgs e)
        {
            int qntd = int.Parse(textBox1.Text);
            TelaMarket telaMarket = new TelaMarket();
            Carrinho carrinho = await telaMarket.CadastrarCarrinho(idProduto, idUser, qntd);
           
            string urlCarrinho = "http://localhost:5043/api/Carrinho";
            string json = JsonConvert.SerializeObject(carrinho);
            using(HttpClient httpClient = new HttpClient())
            {
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                StringContent content = new StringContent(json, Encoding.UTF8, "application/json");
                try
                {

                    HttpResponseMessage response = await httpClient.PostAsync(urlCarrinho, content);
                    if (response.IsSuccessStatusCode)
                    {

                        MessageBox.Show("Item adicionado no carrinho com sucesso!");
                    }
                    else
                    {

                        MessageBox.Show($"Erro ao adicionar item. Código: {response.StatusCode}");
                    }
                }
                catch (Exception ex) { MessageBox.Show($"Erro ao adicionar item: {ex.Message}"); }
            }

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
            if (resposta.IsSuccessStatusCode)
            {
                var content = await resposta.Content.ReadAsStringAsync();
                Produto prod = JsonConvert.DeserializeObject<Produto>(content);
                return prod;
            }
            else
            {
                return null;
            }
           
        }

        private async void atualizarFraseDaPagina()
        {
            string url = $"http://localhost:5043/api/Produto/{idProduto}";
            try
            {
                Produto produto = await GetProdutoById(url);
                if( produto != null )
                {
                    label1.Text = "Informe a quantidade do item: " + produto.Nome;
                }
                else
                {
                    MessageBox.Show("Erro ao cadastrar um produto. Nenhum produto selecionado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
                
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
           
        }
    }
}
