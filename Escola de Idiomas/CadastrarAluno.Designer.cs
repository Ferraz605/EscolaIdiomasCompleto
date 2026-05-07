namespace Escola_de_Idiomas
{
	partial class Cadastrar_Aluno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cadastrar_Aluno));
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            textBox2 = new TextBox();
            label4 = new Label();
            textBox3 = new TextBox();
            label5 = new Label();
            textBox4 = new TextBox();
            label6 = new Label();
            textBox5 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.ForeColor = Color.OrangeRed;
            label1.Location = new Point(291, 34);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(246, 28);
            label1.TabIndex = 0;
            label1.Text = "Área de Cadastro de Aluno";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(178, 108);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(70, 28);
            label2.TabIndex = 1;
            label2.Text = "Nome:";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 15F);
            textBox1.Location = new Point(258, 102);
            textBox1.Margin = new Padding(5, 6, 5, 6);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(302, 34);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(189, 169);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(49, 28);
            label3.TabIndex = 3;
            label3.Text = "CPF:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(258, 169);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(302, 34);
            textBox2.TabIndex = 4;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(177, 238);
            label4.Name = "label4";
            label4.Size = new Size(71, 28);
            label4.TabIndex = 5;
            label4.Text = "E-mail:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(258, 235);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(302, 34);
            textBox3.TabIndex = 6;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(160, 303);
            label5.Name = "label5";
            label5.Size = new Size(88, 28);
            label5.TabIndex = 7;
            label5.Text = "Telefone:";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(258, 303);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(302, 34);
            textBox4.TabIndex = 8;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(55, 374);
            label6.Name = "label6";
            label6.Size = new Size(193, 28);
            label6.TabIndex = 9;
            label6.Text = "Data de Nascimento:";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(258, 368);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(302, 34);
            textBox5.TabIndex = 10;
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(271, 439);
            button1.Name = "button1";
            button1.Size = new Size(266, 41);
            button1.TabIndex = 11;
            button1.Text = "Cadastrar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(601, 439);
            button2.Name = "button2";
            button2.Size = new Size(137, 41);
            button2.TabIndex = 12;
            button2.Text = "Sair";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Cadastrar_Aluno
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(833, 523);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox5);
            Controls.Add(label6);
            Controls.Add(textBox4);
            Controls.Add(label5);
            Controls.Add(textBox3);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 15F);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5, 6, 5, 6);
            MaximumSize = new Size(849, 562);
            MinimumSize = new Size(849, 562);
            Name = "Cadastrar_Aluno";
            Text = "Cadastro";
            Load += Cadastrar_Aluno_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
		private Label label2;
		private TextBox textBox1;
		private Label label3;
		private TextBox textBox2;
		private Label label4;
		private TextBox textBox3;
		private Label label5;
		private TextBox textBox4;
		private Label label6;
		private TextBox textBox5;
		private Button button1;
        private Button button2;
    }
}