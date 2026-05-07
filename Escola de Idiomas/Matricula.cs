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
    public partial class Matricula : Form
    {
        DAOAluno aluno;
        Cursos cursos;
        public Matricula()
        {
            InitializeComponent();
            this.aluno = new DAOAluno();
        }

        private void Matricula_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }// fim do campo nome do aluno

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }// fim do campo cpf do aluno

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }// fim do campo email do aluno

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }// fim do campo telefone do aluno

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }// fim do campo data de nascimento do aluno

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

                this.aluno.InserirMatricula(nome, cpf, email, telefone, dataNascimento);
                //limpar os campos
                LimparCampos();
            }// fim do botão matricular
        }
        private void LimparCampos()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
        }//fim do método limpar

        private void button2_Click(object sender, EventArgs e)
        {
            cursos = new Cursos();
            this.Hide();
            cursos.ShowDialog();
            this.Show();

        }// fim do botão selecionar curso

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        } // BOTAO DE SAIR

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        } //TEXTBOX MATRICULA
    }
}  
