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
    public partial class ExcluirNotas : Form
    {
        DAONotas notas;
        public ExcluirNotas()
        {
            InitializeComponent();
            this.notas = new DAONotas();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }// fim do campo codigo

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "")
            {
                MessageBox.Show("Preencha o Campo");
            }
            else
            {
                int codigo = Convert.ToInt32(textBox1.Text);

                string msg = this.notas.Deletar(codigo);
                MessageBox.Show(msg);

                LimparCampos();
            }// fim do botao excluir notas
        }

        public void LimparCampos()
        {
            textBox1.Text = "";
        }

        private void ExcluirNotas_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        } // BOTAO DE SAIR
    }
}
