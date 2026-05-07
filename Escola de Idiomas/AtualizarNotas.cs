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
    public partial class AtualizarNotas : Form
    {
        DAONotas notas;
        public AtualizarNotas()
        {
            InitializeComponent();
            this.notas = new DAONotas();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }// fim do campo codigo

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }// fim do campo nota

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }// fim do campo data de avaliação

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }// fim do campo observação

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "")
            {
                MessageBox.Show("Preencha os campos!");
                return;
            }

            int codigo = Convert.ToInt32(textBox1.Text);
            decimal nota = Convert.ToDecimal(textBox2.Text);
            DateTime dat = Convert.ToDateTime(textBox3.Text);
            string observacao = textBox4.Text;
            int alunoCodigo = Convert.ToInt32(textBox5.Text);

            this.notas.Atualizar(codigo, "nota", nota.ToString());
            this.notas.Atualizar(codigo, "dat", dat.ToString("yyyy-MM-dd"));
            this.notas.Atualizar(codigo, "observacao", observacao);
            this.notas.Atualizar(codigo, "alunoCodigo", alunoCodigo.ToString());
            MessageBox.Show("Atualizado com sucesso!");

            LimparCampos();
        }// fim do botão atualizar notas

        public void LimparCampos()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
        }// fim do método limpar

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        } // BOTAO DE SAIR

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        } // TEXTBOX CODIGO ALUNO
    }
}
