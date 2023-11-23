namespace urMarket.APPv1
{
    partial class TelaMarket
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
            panel1 = new Panel();
            btCarrinho = new Button();
            label7 = new Label();
            dataGridView1 = new DataGridView();
            label6 = new Label();
            button1 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(btCarrinho);
            panel1.Controls.Add(label7);
            panel1.Location = new Point(-1, -4);
            panel1.Name = "panel1";
            panel1.Size = new Size(610, 55);
            panel1.TabIndex = 24;
            // 
            // btCarrinho
            // 
            btCarrinho.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btCarrinho.BackColor = Color.Transparent;
            btCarrinho.FlatAppearance.BorderSize = 0;
            btCarrinho.FlatStyle = FlatStyle.Flat;
            btCarrinho.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btCarrinho.Location = new Point(445, 18);
            btCarrinho.Name = "btCarrinho";
            btCarrinho.Size = new Size(143, 34);
            btCarrinho.TabIndex = 27;
            btCarrinho.Text = "Acessar o carrinho";
            btCarrinho.UseVisualStyleBackColor = false;
            btCarrinho.Click += btCarrinho_Click;
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
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.BackgroundColor = SystemColors.Window;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(22, 111);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(545, 240);
            dataGridView1.TabIndex = 25;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.DoubleClick += dataGridView1_DoubleClick;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(22, 75);
            label6.Name = "label6";
            label6.Size = new Size(172, 23);
            label6.TabIndex = 26;
            label6.Text = "Produtos disponíveis";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.BackColor = Color.FromArgb(192, 255, 192);
            button1.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(493, 366);
            button1.Name = "button1";
            button1.Size = new Size(73, 23);
            button1.TabIndex = 27;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // TelaMarket
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(587, 411);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Name = "TelaMarket";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TelaMarket";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label7;
        private DataGridView dataGridView1;
        private Label label6;
        private Button btCarrinho;
        private Button button1;
    }
}