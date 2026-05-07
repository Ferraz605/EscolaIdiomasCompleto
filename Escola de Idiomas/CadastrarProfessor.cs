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
    public partial class CadastrarProfessor : Form
    {
        DAOProfessor professor;
        public CadastrarProfessor()
        {
            InitializeComponent();
            this.professor = new DAOProfessor();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }// fim do campo nome

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }// fim do campo telefone

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }// fim do campo formação

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }// fim do campo idiomas

        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == ""))
            {
                MessageBox.Show("Preencha todos os campos!");
            }
            else
            {
                string nome = textBox1.Text;
                string telefone = textBox2.Text;
                string formacao = textBox3.Text;
                string idiomas = textBox4.Text;
                //inserir esses dados no banco
                this.professor.InserirProf(nome, telefone, formacao, idiomas);
                //limpar os campos
                LimparCampos();
            }//fim do método cadastrar	
        }// fim do botão cadastrar professor

        private void LimparCampos()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }//fim do método limpar

        private void CadastrarProfessor_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        } // BOTAO DE SAIR
    }
}
