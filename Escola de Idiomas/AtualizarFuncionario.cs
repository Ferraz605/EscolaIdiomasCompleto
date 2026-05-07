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
    public partial class AtualizarFuncionario : Form
    {
        DAOFuncionario DAOFUN;
        public AtualizarFuncionario()
        {
            InitializeComponent();
            DAOFUN = new DAOFuncionario();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        } // TEXTBOX NOME

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        } // TEXTBOX CODIGO

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        } // TEXTBOX TELEFONE

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        } // TEXTBOX CNPJ

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        } // TEXTBOX DATA DE NASCIMENTO

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        } // TEXTBOX SALARIO

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        } // TEXTBOX CARGO

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        } // TEXTBOX EMAIL

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        } // TEXTBOX SENHA

        private void button1_Click(object sender, EventArgs e)
        {
            // Validar se o código foi preenchido
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "" || textBox7.Text == "" || textBox8.Text == "" || textBox9.Text == "")
            {
                MessageBox.Show("Informe o código do funcionário!");
                return;
            }

            int codigo = int.Parse(textBox9.Text); // pega o código do textBox9

            this.DAOFUN.Atualizar(codigo, "nome", textBox1.Text);
            this.DAOFUN.Atualizar(codigo, "telefone", textBox2.Text);
            this.DAOFUN.Atualizar(codigo, "cnpj", textBox3.Text);
            this.DAOFUN.Atualizar(codigo, "dtDeNascimento", textBox4.Text);
            this.DAOFUN.Atualizar(codigo, "salario", textBox5.Text);
            this.DAOFUN.Atualizar(codigo, "cargo", textBox6.Text);
            this.DAOFUN.Atualizar(codigo, "email", textBox7.Text);
            this.DAOFUN.Atualizar(codigo, "senha", textBox8.Text);
            this.DAOFUN.Atualizar(codigo, "codigo", textBox9.Text);

            MessageBox.Show("Atualizado com sucesso!");

            // Limpar os campos
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        } // BOTAO DE SAIR
    }
}
