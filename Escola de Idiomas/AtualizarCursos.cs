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
    public partial class AtualizarCursos : Form
    {
        DAOCursos DAOCursos;
        public AtualizarCursos()
        {
            InitializeComponent();
            DAOCursos = new DAOCursos();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        } // TEXTBOX CODIGO

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        } // TEXTBOX NOME

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        } // TEXTBOX CARGA HORARIA

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        } // TEXTBOX VALOR

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "")
            {
                MessageBox.Show("Preencha os campos!");
                return;
            }

            int codigo = Convert.ToInt32(textBox1.Text);
            string nome = textBox2.Text;
            int cargaHoraria = Convert.ToInt32(textBox3.Text);
            decimal valor = Convert.ToDecimal(textBox4.Text);

            this.DAOCursos.Atualizar(codigo, "nome", nome);
            this.DAOCursos.Atualizar(codigo, "cargaHoraria", cargaHoraria.ToString());
            this.DAOCursos.Atualizar(codigo, "valor", valor.ToString());
            MessageBox.Show("Atualizado com sucesso!");

            LimparCampos();
        }


        public void LimparCampos()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }// fim do método limpar
        // BOTAO ATUALIZAR

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        } // BOTAO SAIR
    }
}
