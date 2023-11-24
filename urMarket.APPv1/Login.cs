using Microsoft.EntityFrameworkCore.SqlServer.Query.Internal;
using Newtonsoft.Json;
using System.Runtime.CompilerServices;
using urMarket.MODEL;

namespace urMarket.APPv1
{
    public partial class Login : Form
    {
        Usuario usuario = new Usuario();
        public static int idUser { get; set; }

        public Login()
        {
            InitializeComponent();
        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            Cadastro cadastro = new Cadastro();
            cadastro.Show();
        }

        private void btAcessoRestrito_Click(object sender, EventArgs e)
        {
            AcessoRestrito acessoRestrito = new AcessoRestrito();
            acessoRestrito.Show();
        }

        private async void btEntrar_Click(object sender, EventArgs e)
        {

            string url = "http://localhost:5043/api/Usuario";

            string email = textBox1.Text;
            string senha = textBox2.Text;

            usuario.Email = email;
            usuario.Senha = senha;

            bool cadastrado = false;

            HttpClient httpClient = new HttpClient();
            HttpResponseMessage response = await httpClient.GetAsync(url);
            var content = await response.Content.ReadAsStringAsync();
            List<Usuario> usuarios = JsonConvert.DeserializeObject<List<Usuario>>(content);

            foreach (Usuario u in usuarios)
            {
                if (u.Email == usuario.Email && u.Senha == usuario.Senha)
                {
                    cadastrado = true;
                    usuario.Tipo = u.Tipo;
                    idUser = u.Id;
                }
            }

            if (cadastrado && usuario.Tipo == "ADMIN")
            {
                TelaCadastroItem telaCadastroItem = new TelaCadastroItem();
                telaCadastroItem.Show();

            }
            else if (cadastrado && usuario.Tipo == "USER")
            {
                TelaMarket telaMarket = new TelaMarket();
                telaMarket.Show();

            }
            else if (cadastrado == false) { MessageBox.Show("Usuario não cadastrado"); }


        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '*';
        }

    }
}