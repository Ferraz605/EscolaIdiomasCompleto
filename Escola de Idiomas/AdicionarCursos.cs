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
    public partial class AdicionarCursos : Form
    {
        DAOCursos cursos;
        public AdicionarCursos()
        {
            InitializeComponent();
            this.cursos = new DAOCursos();
        }

        private void AdicionarCursos_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }// fim do campo nome

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }// fim do campo carga hoaria

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }// fim do campo valor

        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == ""))
            {
                MessageBox.Show("Preencha todos os campos!");
            }
            else
            {
                string nome = textBox1.Text;
                int cargaHoraria = int.Parse(textBox2.Text);
                double valor = double.Parse(textBox3.Text);
                //inserir esses dados no banco

                this.cursos.InserirCursos(nome, cargaHoraria, valor);
                //limpar os campos
                LimparCampos();
            }// fim do botão adicionar curso
        }

        public void LimparCampos()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        } // BOTAO DE SAIR
    }
}
