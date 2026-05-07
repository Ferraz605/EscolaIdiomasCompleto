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
    public partial class ExcluirAluno : Form
    {
        DAOAluno aluno;
        public ExcluirAluno()
        {
            InitializeComponent();
            this.aluno = new DAOAluno();
        }

        private void ExcluirAluno_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }// fim do campo codigo

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Preencha o campo do código!");

            }
            else
            {
                int codigo = Convert.ToInt32(textBox1.Text);//pegar o código digitado
                string excluido = this.aluno.deletar(codigo);// deletar o dado do banco de dados
                MessageBox.Show(excluido);// mostrar a mensagem de exclusão
                textBox1.Text = "";// limpar o campo do código
            }
        }// fim do botão excluir

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        } // BOTAO DE SAIR
    }
}
