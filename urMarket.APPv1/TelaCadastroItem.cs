using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.ComponentModel.Com2Interop;
using urMarket.BLL;
using urMarket.MODEL;

namespace urMarket.APPv1
{
    public partial class TelaCadastroItem : Form
    {

        public string caminhoFoto = "";
        Produto produto = new Produto();

        public TelaCadastroItem()
        {
            InitializeComponent();
            popularListBox();
            PopularDataGradeView();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CadastrarCategoria cadastrarCategoria = new CadastrarCategoria();
            cadastrarCategoria.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CarregarFotoUsuario();
        }

        private void CarregarFotoUsuario()
        {
            var openFile = new OpenFileDialog();
            openFile.Filter = "Arquivos de imagens jpg, jpeg e png|*.jpg;*.jpeg;*.png";
            openFile.Multiselect = false;
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                caminhoFoto = openFile.FileName;
            }
            if (caminhoFoto != "")
            {
                pictureBox1.Load(caminhoFoto);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            }
        }



        private async void button3_Click(object sender, EventArgs e)
        {

            try
            {
                produto.Nome = textBox1.Text;
                produto.Descricao = textBox2.Text;
                if (listBox1.SelectedItem != null)
                {
                    string cat = listBox1.SelectedItem.ToString();

                    List<Categoria> list = CategoriaRepository.GetAll();

                    foreach (Categoria categoria in list)
                    {
                        if (cat == categoria.Nome)
                        {
                            produto.IdCat = categoria.Id;
                        }
                    }
                    produto.Valor = decimal.Parse(textBox3.Text);
                    produto.CaminhoFoto = caminhoFoto;
                    produto.Foto = ProdutoRepository.GetFoto(produto.CaminhoFoto);
                }
                else
                {
                    MessageBox.Show("Nenhuma categoria selecionada.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            addItemHttp(produto);
        }

        private async void addItemHttp(Produto prod)
        {

            string url = "http://localhost:5043/api/Produto";
            string json = JsonConvert.SerializeObject(prod);
            using (HttpClient httpClient = new HttpClient())
            {
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                StringContent content = new StringContent(json, Encoding.UTF8, "application/json");
                try
                {

                    HttpResponseMessage response = await httpClient.PostAsync(url, content);
                    if (response.IsSuccessStatusCode)
                    {

                        MessageBox.Show("Produto cadastrado com sucesso!");
                        PopularDataGradeView();
                    }
                    else
                    {

                        MessageBox.Show($"Erro ao cadastrar produto. Código: {response.StatusCode}");
                    }
                }
                catch (Exception ex) { MessageBox.Show($"Erro ao cadastrar produto: {ex.Message}"); }

            }
        }

        private async void popularListBox()
        {
            string url = "http://localhost:5043/api/Categoria";
            HttpClient httpClient = new HttpClient();
            HttpResponseMessage resposta = await httpClient.GetAsync(url);
            var content = await resposta.Content.ReadAsStringAsync();
            List<Categoria> categorias = JsonConvert.DeserializeObject<List<Categoria>>(content);
            foreach (Categoria cat in categorias)
            {
                listBox1.Items.Add(cat.Nome);
            }
        }

        
        public static async Task<List<Produto>> GetProdutos(string url)
        {

            HttpClient httpClient = new HttpClient();
            HttpResponseMessage resposta = await httpClient.GetAsync(url);
            var content = await resposta.Content.ReadAsStringAsync();
            List<Produto> produtos = JsonConvert.DeserializeObject<List<Produto>>(content);
            return produtos;
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
                categoria = CategoriaRepository.GetById(produtos[i].IdCat);
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


        private void label7_Click(object sender, EventArgs e)
        {
            PopularDataGradeView();
        }

        private void btLimparCampos_Click(object sender, EventArgs e)
        {
            produto.Id = 0;
            produto.Nome = "";
            produto.Descricao = "";
            produto.IdCat = 0;
            produto.Valor = 0;

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            pictureBox1.Image = null;
            listBox1.ClearSelected();

            textBox1.Focus();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            var path = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells["CaminhoFoto"].Value.ToString();
            using (Form frm = new produtoMaior(path)) { frm.ShowDialog(); }
        }

        private async void button4_Click(object sender, EventArgs e)
        {
            string id = textBox4.Text;
            string url = $"http://localhost:5043/api/Produto?id={id}";
            using (HttpClient httpClient = new HttpClient())
            {
                HttpResponseMessage responseMessage = await httpClient.DeleteAsync(url);

                if (responseMessage.IsSuccessStatusCode)
                {

                    MessageBox.Show("Produto excluído com sucesso!");
                    PopularDataGradeView();
                }
                else
                {

                    MessageBox.Show($"Erro ao excluir produto. Código: {responseMessage.StatusCode}");
                }
            }
        }
    }
}
