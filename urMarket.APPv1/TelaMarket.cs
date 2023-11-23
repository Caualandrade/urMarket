using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using urMarket.BLL;
using urMarket.MODEL;

namespace urMarket.APPv1
{
    public partial class TelaMarket : Form
    {

        int idUser = Login.idUser;
        public static int idProduto { get; set; }
        Carrinho carrinho = new Carrinho();

        public TelaMarket()
        {
            InitializeComponent();
            PopularDataGradeView();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        public static async Task<List<Produto>> GetProdutos(string url)
        {
            HttpClient httpClient = new HttpClient();
            HttpResponseMessage resposta = await httpClient.GetAsync(url);
            var content = await resposta.Content.ReadAsStringAsync();
            List<Produto> produtos = JsonConvert.DeserializeObject<List<Produto>>(content);
            return produtos;
        }

        public static async Task<Categoria> GetCategoriaById(string url)
        {
            HttpClient httpClient = new HttpClient();
            HttpResponseMessage resposta = await httpClient.GetAsync(url);
            var content = await resposta.Content.ReadAsStringAsync();
            Categoria cat = JsonConvert.DeserializeObject<Categoria>(content);
            return cat;
        }

        public static async Task<Produto> GetProdutoById(string url)
        {
            HttpClient httpClient = new HttpClient();
            HttpResponseMessage resposta = await httpClient.GetAsync(url);
            var content = await resposta.Content.ReadAsStringAsync();
            Produto prod = JsonConvert.DeserializeObject<Produto>(content);
            return prod;
        }

        public async void PopularDataGradeView()
        {
            string url = "http://localhost:5043/api/Produto";
            List<Produto> produtos = await GetProdutos(url);

            
            Categoria categoria = new Categoria();

            dataGridView1.Columns.Clear();
            dataGridView1.DataSource = produtos;
            dataGridView1.Columns.Add("Categoria", "Categoria");

            for (int i = 0; i < produtos.Count; i++)
            {
                
                string url2 = $"http://localhost:5043/api/Categoria/{produtos[i].IdCat}";
                categoria = await GetCategoriaById(url2);
                dataGridView1.Rows[i].Cells["Categoria"].Value = categoria.Nome;

            }

            dataGridView1.Columns["Foto"].Visible = false;
            dataGridView1.Columns["Carrinhos"].Visible = false;
            dataGridView1.Columns["IdCatNavigation"].Visible = false;
            dataGridView1.Columns["CaminhoFoto"].Visible = false;
            dataGridView1.Columns["IdCat"].Visible = false;

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            DataGridViewImageColumn col = new DataGridViewImageColumn();
            col.Name = "img";
            col.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dataGridView1.Columns.Add(col);
            dataGridView1.Columns["img"].HeaderText = "Foto";
            dataGridView1.Columns["img"].Width = 64;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                row.Cells["img"].Value = Image.FromFile(row.Cells["CaminhoFoto"].Value.ToString());
            }
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            var path = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells["CaminhoFoto"].Value.ToString();
            using (Form frm = new produtoMaior(path)) { frm.ShowDialog(); }
        }

        private void btCarrinho_Click(object sender, EventArgs e)
        {
            TelaCarrinho tela = new TelaCarrinho();
            tela.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            TelaQuantidade tq = new TelaQuantidade();
            tq.Show();

        }

        
        public async Task<Carrinho> CadastrarCarrinho(int idProduto, int idUser, int qntd)
        {
            
            string url = $"http://localhost:5043/api/Produto/{idProduto}";
            Produto produto = await GetProdutoById(url);

            carrinho.IdProd = idProduto;
            carrinho.IdUsuario = idUser;
            carrinho.Quantidade = qntd;
            carrinho.Total += carrinho.Quantidade * produto.Valor;
            return carrinho;

        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    row.Selected = false;
                }

                dataGridView1.Rows[e.RowIndex].Selected = true;

                DataGridViewRow linhaSelecionada = dataGridView1.Rows[e.RowIndex];

                string valorNomeColuna = Convert.ToString(linhaSelecionada.Cells["Id"].Value);

                idProduto = int.Parse(valorNomeColuna);

            }

        }


    }
}

