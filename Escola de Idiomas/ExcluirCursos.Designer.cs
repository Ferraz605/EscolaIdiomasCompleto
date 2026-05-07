namespace Escola_de_Idiomas
{
	partial class ExcluirCursos
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
            button2 = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.ForeColor = Color.OrangeRed;
            label1.Location = new Point(318, 74);
            label1.Name = "label1";
            label1.Size = new Size(192, 28);
            label1.TabIndex = 0;
            label1.Text = "Área de excluir curso";
            label1.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 15F);
            textBox1.Location = new Point(318, 210);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(192, 34);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 15F);
            button1.Location = new Point(318, 371);
            button1.Name = "button1";
            button1.Size = new Size(192, 39);
            button1.TabIndex = 3;
            button1.Text = "EXCLUIR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 15F);
            button2.Location = new Point(573, 371);
            button2.Name = "button2";
            button2.Size = new Size(137, 41);
            button2.TabIndex = 15;
            button2.Text = "Sair";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F);
            label3.Location = new Point(218, 213);
            label3.Name = "label3";
            label3.Size = new Size(81, 28);
            label3.TabIndex = 16;
            label3.Text = "Código:";
            // 
            // ExcluirCursos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Copilot_20260430_14461510;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            MaximumSize = new Size(816, 489);
            MinimumSize = new Size(816, 489);
            Name = "ExcluirCursos";
            Text = "ExcluirCursos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
		private TextBox textBox1;
		private Button button1;
        private Button button2;
        private Label label3;
    }
}