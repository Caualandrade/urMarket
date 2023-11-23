namespace urMarket.APPv1
{
    partial class TelaCadastroItem
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox3 = new TextBox();
            label3 = new Label();
            listBox1 = new ListBox();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            label5 = new Label();
            btLimparCampos = new Button();
            button3 = new Button();
            dataGridView1 = new DataGridView();
            label6 = new Label();
            label7 = new Label();
            panel1 = new Panel();
            button2 = new Button();
            button4 = new Button();
            textBox4 = new TextBox();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(37, 75);
            label1.Name = "label1";
            label1.Size = new Size(45, 20);
            label1.TabIndex = 0;
            label1.Text = "Nome";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(126, 72);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(169, 23);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(126, 111);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(169, 23);
            textBox2.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(37, 114);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 2;
            label2.Text = "Descrição";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(126, 193);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(169, 23);
            textBox3.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(37, 196);
            label3.Name = "label3";
            label3.Size = new Size(42, 20);
            label3.TabIndex = 4;
            label3.Text = "Valor";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(126, 154);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(169, 19);
            listBox1.TabIndex = 6;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(37, 154);
            label4.Name = "label4";
            label4.Size = new Size(68, 20);
            label4.TabIndex = 7;
            label4.Text = "Categoria";
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(126, 233);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(88, 108);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(192, 255, 192);
            button1.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(233, 318);
            button1.Name = "button1";
            button1.Size = new Size(62, 23);
            button1.TabIndex = 9;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(40, 233);
            label5.Name = "label5";
            label5.Size = new Size(59, 20);
            label5.TabIndex = 10;
            label5.Text = "Imagem";
            // 
            // btLimparCampos
            // 
            btLimparCampos.Location = new Point(213, 391);
            btLimparCampos.Name = "btLimparCampos";
            btLimparCampos.Size = new Size(82, 23);
            btLimparCampos.TabIndex = 11;
            btLimparCampos.Text = "Limpar";
            btLimparCampos.UseVisualStyleBackColor = true;
            btLimparCampos.Click += btLimparCampos_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(192, 255, 192);
            button3.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(40, 383);
            button3.Name = "button3";
            button3.Size = new Size(142, 31);
            button3.TabIndex = 120;
            button3.Text = "Salvar";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.Window;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(370, 111);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(416, 303);
            dataGridView1.TabIndex = 14;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.DoubleClick += dataGridView1_DoubleClick;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(370, 72);
            label6.Name = "label6";
            label6.Size = new Size(179, 23);
            label6.TabIndex = 15;
            label6.Text = "Produtos cadastrados";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Playbill", 36F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(9, 3);
            label7.Name = "label7";
            label7.Size = new Size(123, 49);
            label7.TabIndex = 22;
            label7.Text = "urMarket";
            label7.Click += label7_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(button2);
            panel1.Controls.Add(label7);
            panel1.Location = new Point(-2, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(823, 55);
            panel1.TabIndex = 23;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(372, 13);
            button2.Name = "button2";
            button2.Size = new Size(159, 37);
            button2.TabIndex = 23;
            button2.Text = "Categoria";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.IndianRed;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Arial Narrow", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Location = new Point(676, 470);
            button4.Name = "button4";
            button4.Size = new Size(110, 28);
            button4.TabIndex = 24;
            button4.Text = "Excluir Produto";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(676, 430);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(110, 23);
            textBox4.TabIndex = 25;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(370, 430);
            label8.Name = "label8";
            label8.Size = new Size(278, 17);
            label8.TabIndex = 26;
            label8.Text = "Informe o Id do produto que deseja excluir";
            label8.Click += label8_Click;
            // 
            // TelaCadastroItem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(817, 510);
            Controls.Add(label8);
            Controls.Add(textBox4);
            Controls.Add(button4);
            Controls.Add(panel1);
            Controls.Add(label6);
            Controls.Add(dataGridView1);
            Controls.Add(button3);
            Controls.Add(btLimparCampos);
            Controls.Add(label5);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(label4);
            Controls.Add(listBox1);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "TelaCadastroItem";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TelaCadastroItem";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox3;
        private Label label3;
        private ListBox listBox1;
        private Label label4;
        private PictureBox pictureBox1;
        private Button button1;
        private Label label5;
        private Button btLimparCampos;
        private Button button3;
        private DataGridView dataGridView1;
        private Label label6;
        private Label label7;
        private Panel panel1;
        private Button button2;
        private Button button4;
        private TextBox textBox4;
        private Label label8;
    }
}