namespace urMarket.APPv1
{
    partial class TelaCarrinho
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
            dataGridView1 = new DataGridView();
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            btRemover = new Button();
            panel1 = new Panel();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(10, 67);
            label1.Name = "label1";
            label1.Size = new Size(150, 20);
            label1.TabIndex = 0;
            label1.Text = "Olá, Teste@gmail.com";
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.BackgroundColor = SystemColors.Window;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(10, 105);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(436, 150);
            dataGridView1.TabIndex = 1;
            //dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(299, 25);
            label3.Name = "label3";
            label3.Size = new Size(68, 22);
            label3.TabIndex = 3;
            label3.Text = "Total: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(10, 269);
            label4.Name = "label4";
            label4.Size = new Size(160, 30);
            label4.TabIndex = 4;
            label4.Text = "Deseja remover algum item? \r\nInforme o Id :";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(93, 287);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(67, 23);
            textBox1.TabIndex = 5;
            // 
            // btRemover
            // 
            btRemover.BackColor = Color.IndianRed;
            btRemover.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btRemover.Location = new Point(12, 323);
            btRemover.Name = "btRemover";
            btRemover.Size = new Size(66, 25);
            btRemover.TabIndex = 6;
            btRemover.Text = "Remover";
            btRemover.UseVisualStyleBackColor = false;
            btRemover.Click += btRemover_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(553, 55);
            panel1.TabIndex = 7;
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
            // 
            // TelaCarrinho
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(499, 371);
            Controls.Add(panel1);
            Controls.Add(btRemover);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Name = "TelaCarrinho";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Carrinho";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private Button btRemover;
        private Panel panel1;
        private Label label7;
    }
}