namespace Escola_de_Idiomas
{
    partial class AtualizarCursos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AtualizarCursos));
            button2 = new Button();
            button1 = new Button();
            textBox4 = new TextBox();
            label5 = new Label();
            textBox3 = new TextBox();
            label4 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 15F);
            button2.Location = new Point(575, 364);
            button2.Name = "button2";
            button2.Size = new Size(137, 46);
            button2.TabIndex = 48;
            button2.Text = "Sair";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 15F);
            button1.Location = new Point(268, 364);
            button1.Name = "button1";
            button1.Size = new Size(265, 46);
            button1.TabIndex = 47;
            button1.Text = "ATUALIZAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Segoe UI", 15F);
            textBox4.Location = new Point(268, 298);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(265, 34);
            textBox4.TabIndex = 46;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15F);
            label5.Location = new Point(190, 304);
            label5.Name = "label5";
            label5.Size = new Size(61, 28);
            label5.TabIndex = 45;
            label5.Text = "Valor:";
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 15F);
            textBox3.Location = new Point(268, 237);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(265, 34);
            textBox3.TabIndex = 44;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F);
            label4.Location = new Point(114, 240);
            label4.Name = "label4";
            label4.Size = new Size(137, 28);
            label4.TabIndex = 43;
            label4.Text = "Carga Horaria:";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 15F);
            textBox2.Location = new Point(268, 174);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(265, 34);
            textBox2.TabIndex = 42;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F);
            label3.Location = new Point(181, 174);
            label3.Name = "label3";
            label3.Size = new Size(70, 28);
            label3.TabIndex = 41;
            label3.Text = "Nome:";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 15F);
            textBox1.Location = new Point(268, 111);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(265, 34);
            textBox1.TabIndex = 40;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(181, 114);
            label2.Name = "label2";
            label2.Size = new Size(81, 28);
            label2.TabIndex = 39;
            label2.Text = "Codigo:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.ForeColor = Color.OrangeRed;
            label1.Location = new Point(295, 41);
            label1.Name = "label1";
            label1.Size = new Size(216, 28);
            label1.TabIndex = 38;
            label1.Text = "Área de Atualizar Curso";
            // 
            // AtualizarCursos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
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
            Name = "AtualizarCursos";
            Text = "AtualizarCursos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private Button button1;
        private TextBox textBox4;
        private Label label5;
        private TextBox textBox3;
        private Label label4;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox1;
        private Label label2;
        private Label label1;
    }
}