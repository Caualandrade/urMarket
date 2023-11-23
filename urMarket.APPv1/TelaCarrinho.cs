using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Mapping;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using urMarket.BLL;
using urMarket.MODEL;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace urMarket.APPv1
{
    public partial class TelaCarrinho : Form
    {
        int idUser = Login.idUser;
        int idProd = TelaMarket.idProduto;


        public TelaCarrinho()
        {
            InitializeComponent();
            ConfigurarDataGradeView();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        public async Task<List<Carrinho>> GetCarrinhoUsuario(string url)
        {
            HttpClient httpClient = new HttpClient();
            HttpResponseMessage response = await httpClient.GetAsync(url);
            var content = await response.Content.ReadAsStringAsync();
            List<Carrinho> carrinhoCliente = JsonConvert.DeserializeObject<List<Carrinho>>(content);
            return carrinhoCliente;
        }

        public async Task<Usuario> GetUsuario(string url)
        {
            HttpClient httpClient = new HttpClient();
            HttpResponseMessage response = await httpClient.GetAsync(url);
            var content = await response.Content.ReadAsStringAsync();
            Usuario user = JsonConvert.DeserializeObject<Usuario>(content);
            return user;
        }

        public async void ConfigurarDataGradeView()
        {
            decimal total = 0;
            string url = $"http://localhost:5043/api/Carrinho/{idUser}";
            List<Carrinho> carrinhoCliente = await GetCarrinhoUsuario(url);

            Produto produto = new Produto();

            dataGridView1.Columns.Clear();

            dataGridView1.DataSource = carrinhoCliente;

            dataGridView1.Columns["IdUsuario"].Visible = false;
            dataGridView1.Columns["IdProd"].Visible = false;
            dataGridView1.Columns["IdProdNavigation"].Visible = false;
            dataGridView1.Columns["IdUsuarioNavigation"].Visible = false;
            dataGridView1.Columns["Total"].Visible = true;
            dataGridView1.Columns.Add("Produto", "Produto");
            dataGridView1.Columns.Add("Valor", "Valor");

            dataGridView1.Columns["Id"].DisplayIndex = 0;
            dataGridView1.Columns["Produto"].DisplayIndex = 1;
            dataGridView1.Columns["Valor"].DisplayIndex = 2;
            dataGridView1.Columns["Quantidade"].DisplayIndex = 3;
            dataGridView1.Columns["Total"].DisplayIndex = 4;


            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            for (int i = 0; i < carrinhoCliente.Count; i++)
            {
                produto = ProdutoRepository.GetById(carrinhoCliente[i].IdProd);
                dataGridView1.Rows[i].Cells["Produto"].Value = produto.Nome;
                dataGridView1.Rows[i].Cells["Valor"].Value = produto.Valor;
                dataGridView1.Rows[i].Cells["Quantidade"].Value = carrinhoCliente[i].Quantidade.ToString();
                dataGridView1.Rows[i].Cells["Total"].Value = carrinhoCliente[i].Quantidade * produto.Valor;

                total += carrinhoCliente[i].Total;
            }


            label3.Text = "Total: R$ " + total.ToString();

            string url2 = $"http://localhost:5043/api/Usuario/user/{idUser}";
            Usuario user = await GetUsuario(url2);
            label1.Text = "Olá, " + user.Email;

        }

        private async void btRemover_Click(object sender, EventArgs e)
        {
            string id = textBox1.Text;
            string url = $"http://localhost:5043/api/Carrinho?id={id}";
            using (HttpClient httpClient = new HttpClient())
            {
                HttpResponseMessage responseMessage = await httpClient.DeleteAsync(url);

                if (responseMessage.IsSuccessStatusCode)
                {

                    MessageBox.Show("Compra excluída com sucesso!");
                    ConfigurarDataGradeView();
                    textBox1.Text = "";
                }
                else
                {

                    MessageBox.Show($"Erro ao excluir categoria. Código: {responseMessage.StatusCode}");
                }
            }
        }
    }
}
