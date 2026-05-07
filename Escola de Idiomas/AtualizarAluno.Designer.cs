namespace Escola_de_Idiomas
{
	partial class AtualizarAluno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AtualizarAluno));
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
            label7 = new Label();
            textBox6 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.ForeColor = Color.OrangeRed;
            label1.Location = new Point(287, 36);
            label1.Name = "label1";
            label1.Size = new Size(218, 28);
            label1.TabIndex = 0;
            label1.Text = "Área de Atualizar Aluno";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(230, 96);
            label2.Name = "label2";
            label2.Size = new Size(63, 21);
            label2.TabIndex = 1;
            label2.Text = "Código:";
            label2.Click += label2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(299, 96);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(206, 23);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(237, 148);
            label3.Name = "label3";
            label3.Size = new Size(56, 21);
            label3.TabIndex = 3;
            label3.Text = "Nome:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(299, 146);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(206, 23);
            textBox2.TabIndex = 4;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(253, 191);
            label4.Name = "label4";
            label4.Size = new Size(40, 21);
            label4.TabIndex = 5;
            label4.Text = "CPF:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(299, 191);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(206, 23);
            textBox3.TabIndex = 6;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(236, 244);
            label5.Name = "label5";
            label5.Size = new Size(57, 21);
            label5.TabIndex = 7;
            label5.Text = "E-mail:";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(299, 242);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(206, 23);
            textBox4.TabIndex = 8;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(223, 292);
            label6.Name = "label6";
            label6.Size = new Size(70, 21);
            label6.TabIndex = 9;
            label6.Text = "Telefone:";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(299, 290);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(206, 23);
            textBox5.TabIndex = 10;
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(140, 330);
            label7.Name = "label7";
            label7.Size = new Size(153, 21);
            label7.TabIndex = 11;
            label7.Text = "Data de Nascimento:";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(299, 332);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(206, 23);
            textBox6.TabIndex = 12;
            textBox6.TextChanged += textBox6_TextChanged;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 15F);
            button1.Location = new Point(299, 378);
            button1.Name = "button1";
            button1.Size = new Size(206, 40);
            button1.TabIndex = 13;
            button1.Text = "Atualizar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 15F);
            button2.Location = new Point(580, 377);
            button2.Name = "button2";
            button2.Size = new Size(137, 41);
            button2.TabIndex = 14;
            button2.Text = "Sair";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // AtualizarAluno
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox6);
            Controls.Add(label7);
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
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(816, 489);
            MinimumSize = new Size(816, 489);
            Name = "AtualizarAluno";
            Load += AtualizarAluno_Load;
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
		private Label label7;
		private TextBox textBox6;
		private Button button1;
        private Button button2;
    }
}