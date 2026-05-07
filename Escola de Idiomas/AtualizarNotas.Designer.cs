namespace Escola_de_Idiomas
{
	partial class AtualizarNotas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AtualizarNotas));
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            textBox2 = new TextBox();
            label4 = new Label();
            textBox3 = new TextBox();
            label5 = new Label();
            textBox4 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            textBox5 = new TextBox();
            label6 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.ForeColor = Color.OrangeRed;
            label1.Location = new Point(304, 46);
            label1.Name = "label1";
            label1.Size = new Size(210, 28);
            label1.TabIndex = 0;
            label1.Text = "Área de Atualizar Nota";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(185, 101);
            label2.Name = "label2";
            label2.Size = new Size(81, 28);
            label2.TabIndex = 1;
            label2.Text = "Codigo:";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 15F);
            textBox1.Location = new Point(272, 98);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(265, 34);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F);
            label3.Location = new Point(206, 164);
            label3.Name = "label3";
            label3.Size = new Size(60, 28);
            label3.TabIndex = 3;
            label3.Text = "Nota:";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 15F);
            textBox2.Location = new Point(272, 161);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(265, 34);
            textBox2.TabIndex = 4;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F);
            label4.Location = new Point(93, 224);
            label4.Name = "label4";
            label4.Size = new Size(173, 28);
            label4.TabIndex = 5;
            label4.Text = "Data da Avaliação:";
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 15F);
            textBox3.Location = new Point(272, 224);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(265, 34);
            textBox3.TabIndex = 6;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15F);
            label5.Location = new Point(147, 278);
            label5.Name = "label5";
            label5.Size = new Size(119, 28);
            label5.TabIndex = 7;
            label5.Text = "Observação:";
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Segoe UI", 15F);
            textBox4.Location = new Point(272, 278);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(265, 34);
            textBox4.TabIndex = 8;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 15F);
            button1.Location = new Point(272, 381);
            button1.Name = "button1";
            button1.Size = new Size(265, 46);
            button1.TabIndex = 9;
            button1.Text = "ATUALIZAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 15F);
            button2.Location = new Point(580, 381);
            button2.Name = "button2";
            button2.Size = new Size(137, 46);
            button2.TabIndex = 37;
            button2.Text = "Sair";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(272, 329);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(265, 34);
            textBox5.TabIndex = 38;
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15F);
            label6.Location = new Point(128, 335);
            label6.Name = "label6";
            label6.Size = new Size(138, 28);
            label6.TabIndex = 39;
            label6.Text = "Código Aluno:";
            // 
            // AtualizarNotas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Copilot_20260430_1446157;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(textBox5);
            Controls.Add(button2);
            Controls.Add(button1);
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
            Name = "AtualizarNotas";
            Text = "AtualizarNotas";
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
		private Button button1;
        private Button button2;
        private TextBox textBox5;
        private Label label6;
    }
}