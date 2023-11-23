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
    public partial class produtoMaior : Form
    {
        string path;
        public produtoMaior(string path)
        {
            InitializeComponent();
            this.path = path;
        }

        private void produtoMaior_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(path);
        }
    }
}
