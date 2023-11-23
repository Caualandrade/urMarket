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
using urMarket.MODEL;
using static System.Net.WebRequestMethods;

namespace urMarket.APPv1
{
    public partial class CadastrarCategoria : Form
    {
        Categoria categoria = new Categoria();
        public CadastrarCategoria()
        {
            InitializeComponent();
            PopularGrade();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string url = "http://localhost:5043/api/Categoria";
            categoria.Nome = textBox1.Text;

            string jsonCategoria = JsonConvert.SerializeObject(categoria);
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                StringContent content = new StringContent(jsonCategoria, Encoding.UTF8, "application/json");

                try
                {

                    HttpResponseMessage response = await client.PostAsync(url, content);


                    if (response.IsSuccessStatusCode)
                    {

                        MessageBox.Show("Categoria cadastrado com sucesso!");
                        PopularGrade();
                        textBox1.Text = "";
                    }
                    else
                    {

                        MessageBox.Show($"Erro ao cadastrar categoria. Código: {response.StatusCode}");
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show($"Erro ao cadastrar categoria: {ex.Message}");
                }
            }
        }

        private async void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private async void PopularGrade()
        {

            string url = "http://localhost:5043/api/Categoria";
            HttpClient httpClient = new HttpClient();
            HttpResponseMessage resposta = await httpClient.GetAsync(url);
            var content = await resposta.Content.ReadAsStringAsync();
            List<Categoria> categorias = JsonConvert.DeserializeObject<List<Categoria>>(content);
            dataGridView1.Columns.Clear();
            dataGridView1.DataSource = categorias;
            dataGridView1.Columns["Produtos"].Visible = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

        }

        private void CadastrarCategoria_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
            PopularGrade();
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            string id = textBox2.Text;
            string url = $"http://localhost:5043/api/Categoria?id={id}";

            using (HttpClient httpClient = new HttpClient())
            {
                HttpResponseMessage responseMessage = await httpClient.DeleteAsync(url);

                if (responseMessage.IsSuccessStatusCode)
                {

                    MessageBox.Show("Categoria excluída com sucesso!");
                    PopularGrade();
                    textBox2.Text = "";
                }
                else
                {

                    MessageBox.Show($"Erro ao excluir categoria. Código: {responseMessage.StatusCode}");
                }
            }
        }
    }
}
