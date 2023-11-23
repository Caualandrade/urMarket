namespace urMarket.APPv1
{
    partial class AcessoRestrito
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
            button1 = new Button();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(41, 109);
            label1.Name = "label1";
            label1.Size = new Size(207, 20);
            label1.TabIndex = 0;
            label1.Text = "Senha para o acesso do sistema";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(254, 106);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(133, 23);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(158, 163);
            button1.Name = "button1";
            button1.Size = new Size(99, 23);
            button1.TabIndex = 2;
            button1.Text = "Enviar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Playbill", 36F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(146, 35);
            label4.Name = "label4";
            label4.Size = new Size(123, 49);
            label4.TabIndex = 16;
            label4.Text = "urMarket";
            // 
            // AcessoRestrito
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(425, 224);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "AcessoRestrito";
            Text = "Acesso Restrito";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Button button1;
        private Label label4;
    }
}