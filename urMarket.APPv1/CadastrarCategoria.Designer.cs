namespace urMarket.APPv1
{
    partial class CadastrarCategoria
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
            panel1 = new Panel();
            label7 = new Label();
            dataGridView1 = new DataGridView();
            label2 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            button1 = new Button();
            button2 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 73);
            label1.Name = "label1";
            label1.Size = new Size(45, 20);
            label1.TabIndex = 0;
            label1.Text = "Nome";
            label1.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(72, 70);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(156, 23);
            textBox1.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(label7);
            panel1.Location = new Point(-1, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(689, 55);
            panel1.TabIndex = 2;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Playbill", 36F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(9, 3);
            label7.Name = "label7";
            label7.Size = new Size(123, 49);
            label7.TabIndex = 23;
            label7.Text = "urMarket";
            label7.Click += label7_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.Window;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(280, 98);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(229, 150);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(280, 66);
            label2.Name = "label2";
            label2.Size = new Size(190, 23);
            label2.TabIndex = 4;
            label2.Text = "Categorias cadastradas";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(72, 172);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(156, 23);
            textBox2.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(12, 175);
            label3.Name = "label3";
            label3.Size = new Size(52, 20);
            label3.TabIndex = 6;
            label3.Text = "Excluir";
            // 
            // button1
            // 
            button1.Location = new Point(12, 111);
            button1.Name = "button1";
            button1.Size = new Size(73, 23);
            button1.TabIndex = 7;
            button1.Text = "Salvar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(12, 215);
            button2.Name = "button2";
            button2.Size = new Size(73, 23);
            button2.TabIndex = 8;
            button2.Text = "Deletar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // CadastrarCategoria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(526, 295);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "CadastrarCategoria";
            Text = "Cadastrar Categoria";
            Load += CadastrarCategoria_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Panel panel1;
        private Label label7;
        private DataGridView dataGridView1;
        private Label label2;
        private TextBox textBox2;
        private Label label3;
        private Button button1;
        private Button button2;
    }
}