using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Escola_de_Idiomas
{
    public partial class AtualizarProfessor : Form
    {
        DAOProfessor professor;
        public AtualizarProfessor()
        {
            InitializeComponent();
            this.professor = new DAOProfessor();
        }

        private void AtualizarProfessor_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }// fim do campo codigo

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }// fim do campo nome

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }// fim do campo telefone

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }// fim do campo formação

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }// fim do campo idiomas

        private void button1_Click(object sender, EventArgs e)
        {
            int codigo = Convert.ToInt32(textBox1.Text);

            //Atualizando os dados
            this.professor.atualizarProfessor(codigo, "nome", textBox2.Text);
            this.professor.atualizarProfessor(codigo, "telefone", textBox3.Text);
            this.professor.atualizarProfessor(codigo, "formacao", textBox4.Text);
            string atualizado = this.professor.atualizarProfessor(codigo, "idiomas", textBox5.Text);
            MessageBox.Show(atualizado);

            //Limpar os campos
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
        }// fim do botão atualizar

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        } // BOTAO DE SAIR
    }
}
