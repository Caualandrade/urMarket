using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using urMarket.MODEL;

namespace urMarket.APPv1
{
    public partial class Cadastro : Form
    {

        Usuario usuario = new Usuario();

        public Cadastro()
        {
            InitializeComponent();
        }

        private void Cadastro_Load(object sender, EventArgs e)
        {

        }

        private async void btCadastrar_Click(object sender, EventArgs e)
        {
            
            string url = "http://localhost:5043/api/Usuario";
            usuario.Tipo = "USER";
            usuario.Email = textBox1.Text;
            usuario.Senha = textBox2.Text;

            string jsonUsuario = JsonConvert.SerializeObject(usuario);
            using (HttpClient client = new HttpClient())
            {
                string url2 = url + $"/{usuario.Email}";
                HttpResponseMessage response2 = await client.GetAsync(url2);
                if(response2.IsSuccessStatusCode)
                {
                    MessageBox.Show("Usuario já cadastrado");
                }
                else
                {
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    StringContent content = new StringContent(jsonUsuario, Encoding.UTF8, "application/json");
                    try
                    {

                        HttpResponseMessage response = await client.PostAsync(url, content);
                        if (response.IsSuccessStatusCode)
                        {

                            MessageBox.Show("Usuário cadastrado com sucesso!");
                        }
                        else
                        {

                            MessageBox.Show($"Erro ao cadastrar usuário. Código: {response.StatusCode}");
                        }
                    }
                    catch (Exception ex) { MessageBox.Show($"Erro ao cadastrar usuário: {ex.Message}"); }
                }
                

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
