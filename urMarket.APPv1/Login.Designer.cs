namespace urMarket.APPv1
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label4 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox1 = new TextBox();
            btEntrar = new Button();
            label1 = new Label();
            label3 = new Label();
            btCadastrar = new Button();
            btAcessoRestrito = new Button();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Playbill", 48F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(120, 31);
            label4.Name = "label4";
            label4.Size = new Size(163, 65);
            label4.TabIndex = 21;
            label4.Text = "urMarket";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(90, 202);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(218, 23);
            textBox2.TabIndex = 20;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(90, 179);
            label2.Name = "label2";
            label2.Size = new Size(48, 20);
            label2.TabIndex = 19;
            label2.Text = "Senha";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(90, 144);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(218, 23);
            textBox1.TabIndex = 18;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // btEntrar
            // 
            btEntrar.Location = new Point(90, 245);
            btEntrar.Name = "btEntrar";
            btEntrar.Size = new Size(218, 23);
            btEntrar.TabIndex = 17;
            btEntrar.Text = "Entrar";
            btEntrar.UseVisualStyleBackColor = true;
            btEntrar.Click += btEntrar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(90, 121);
            label1.Name = "label1";
            label1.Size = new Size(45, 20);
            label1.TabIndex = 16;
            label1.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(90, 286);
            label3.Name = "label3";
            label3.Size = new Size(123, 15);
            label3.TabIndex = 22;
            label3.Text = "Ainda não tem conta?";
            // 
            // btCadastrar
            // 
            btCadastrar.BackColor = Color.Transparent;
            btCadastrar.FlatAppearance.BorderSize = 0;
            btCadastrar.Location = new Point(223, 282);
            btCadastrar.Name = "btCadastrar";
            btCadastrar.Size = new Size(85, 23);
            btCadastrar.TabIndex = 23;
            btCadastrar.Text = "Cadastrar-se";
            btCadastrar.UseVisualStyleBackColor = false;
            btCadastrar.Click += btCadastrar_Click;
            // 
            // btAcessoRestrito
            // 
            btAcessoRestrito.BackColor = Color.Transparent;
            btAcessoRestrito.FlatAppearance.BorderSize = 0;
            btAcessoRestrito.FlatStyle = FlatStyle.Flat;
            btAcessoRestrito.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btAcessoRestrito.Location = new Point(297, 1);
            btAcessoRestrito.Name = "btAcessoRestrito";
            btAcessoRestrito.Size = new Size(104, 23);
            btAcessoRestrito.TabIndex = 24;
            btAcessoRestrito.Text = "Acesso Restrito";
            btAcessoRestrito.UseVisualStyleBackColor = false;
            btAcessoRestrito.Click += btAcessoRestrito_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(402, 344);
            Controls.Add(btAcessoRestrito);
            Controls.Add(btCadastrar);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(btEntrar);
            Controls.Add(label1);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login urMarket";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox1;
        private Button btEntrar;
        private Label label1;
        private Label label3;
        private Button btCadastrar;
        private Button btAcessoRestrito;
    }
}