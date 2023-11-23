namespace urMarket.APPv1
{
    partial class CadastroAR
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
            label4 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox1 = new TextBox();
            btCadastrar = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Playbill", 48F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(102, 24);
            label4.Name = "label4";
            label4.Size = new Size(163, 65);
            label4.TabIndex = 21;
            label4.Text = "urMarket";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(75, 189);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(205, 23);
            textBox2.TabIndex = 20;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(75, 166);
            label2.Name = "label2";
            label2.Size = new Size(48, 20);
            label2.TabIndex = 19;
            label2.Text = "Senha";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(75, 131);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(205, 23);
            textBox1.TabIndex = 18;
            // 
            // btCadastrar
            // 
            btCadastrar.Location = new Point(75, 232);
            btCadastrar.Name = "btCadastrar";
            btCadastrar.Size = new Size(205, 23);
            btCadastrar.TabIndex = 17;
            btCadastrar.Text = "Cadastrar-se";
            btCadastrar.UseVisualStyleBackColor = true;
            btCadastrar.Click += btCadastrar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(75, 108);
            label1.Name = "label1";
            label1.Size = new Size(45, 20);
            label1.TabIndex = 16;
            label1.Text = "Email";
            // 
            // CadastroAR
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(352, 338);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(btCadastrar);
            Controls.Add(label1);
            Name = "CadastroAR";
            Text = "Cadastro Acesso Restrito";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox1;
        private Button btCadastrar;
        private Label label1;
    }
}