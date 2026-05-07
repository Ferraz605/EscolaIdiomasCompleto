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
    public partial class Cadastrar_Aluno : Form
    {
        DAOAluno aluno;
        public Cadastrar_Aluno()
        {
            InitializeComponent();
            this.aluno = new DAOAluno();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }// fim do campo nome

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }// fim do campo cpf

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }// fim do campo email

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }// fim do campo telefone

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }// fim do campo data de nascimento

        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == ""))
            {
                MessageBox.Show("Preencha todos os campos!");
            }
            else
            {
                string nome = textBox1.Text;
                string cpf = textBox2.Text;
                string email = textBox3.Text;
                string telefone = textBox4.Text;
                DateTime dataNascimento = DateTime.Parse(textBox5.Text);
                //inserir esses dados no banco

                this.aluno.Inserir(nome, cpf, email, telefone, dataNascimento);
                //limpar os campos
                LimparCampos();
            }//fim do método cadastrar	
        }//fim do botão cadastrar

        private void LimparCampos()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
        }//fim do método limpar

        private void Cadastrar_Aluno_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        } // BOTAO SAIR
    }
}
