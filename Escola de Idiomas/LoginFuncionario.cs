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
	public partial class LoginFuncionario : Form
	{
		DAOFuncionario Funcionario;
		public LoginFuncionario()
		{
			InitializeComponent();
			this.Funcionario = new DAOFuncionario();
		}

		private void textBox2_TextChanged(object sender, EventArgs e)
		{

		}// fim do campo senha

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}// fim do campo email

		private void button1_Click(object sender, EventArgs e)
		{
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Preencha os campos");
                return;
            }

            string email = textBox1.Text;
            string senha = textBox2.Text;

            bool loginOk = Funcionario.ValidarLoginFuncionario(email, senha);

            if (loginOk)
            {
                MessageBox.Show("Bem-vindo!");
                Form1 menu = new Form1();
                menu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Email ou senha incorretos!");
            }

        }// fim do botão login
	}
}
