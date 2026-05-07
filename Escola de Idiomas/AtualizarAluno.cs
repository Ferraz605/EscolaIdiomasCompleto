using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Escola_de_Idiomas
{
    public partial class AtualizarAluno : Form
    {
        DAOAluno aluno;
        public AtualizarAluno()
        {
            InitializeComponent();
            this.aluno = new DAOAluno();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void AtualizarAluno_Load(object sender, EventArgs e)
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

        }// fim do campo cpf

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }// fim do campo email

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }// fim do campo telefone

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }// fim do campo data de nascimento

        private void button1_Click(object sender, EventArgs e)
        {
            int codigo = Convert.ToInt32(textBox1.Text);

            //Atualizando os dados
            this.aluno.atualizarAluno(codigo, "nome", textBox2.Text);
            this.aluno.atualizarAluno(codigo, "cpf", textBox3.Text);
            this.aluno.atualizarAluno(codigo, "email", textBox4.Text);
            this.aluno.atualizarAluno(codigo, "telefone", textBox5.Text);
            string atualizado = this.aluno.atualizarAluno(codigo, "dtDeNascimento", textBox6.Text);
            MessageBox.Show(atualizado);

            //Limpar os campos
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
        }// fim do botão atualizar

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        } // BOTAO DE SAIR
    }
}
