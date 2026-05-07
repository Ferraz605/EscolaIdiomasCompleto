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
    public partial class CadastrarFuncionario : Form
    {
        DAOFuncionario Funcionario;
        public CadastrarFuncionario()
        {
            InitializeComponent();
            this.Funcionario = new DAOFuncionario();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if ((textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" ||
                textBox6.Text == "" || textBox7.Text == "" || textBox8.Text == ""))
            {
                MessageBox.Show("Preencha todos os campos!");
            }
            else
            {
                string nome = textBox1.Text;
                string telefone = textBox2.Text;
                string cnpj = textBox3.Text;
                DateTime dataNascimento = DateTime.Parse(textBox4.Text);
                double salario = double.Parse(textBox5.Text);
                string cargo = textBox6.Text;
                string email = textBox7.Text;
                string senha = textBox8.Text;
                //inserir esses dados no banco
                this.Funcionario.InserirFuncionario(nome, telefone, cnpj, dataNascimento, salario, cargo, email, senha);
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
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
        }//fim do método limpar

        private void CadastrarFuncionario_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }// fim do campo nome

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }// fim do campo telefone

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }// fim do campo CNPJ

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }// fim do campo data de nascimento

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }// fim do campo salário

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }// fim do campo cargo

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }// fim do campo email

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }// fim do campo senha

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        } // BOTAO DE SAIR
    }
}
