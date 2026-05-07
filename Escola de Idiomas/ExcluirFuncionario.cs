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
    public partial class ExcluirFuncionario : Form
    {
        DAOFuncionario DAOFun;
        public ExcluirFuncionario()
        {
            InitializeComponent();
            DAOFun = new DAOFuncionario();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        } // TEXTBOX CODIGO

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Preencha o Campo");
            }
            else
            {
                int codigo = Convert.ToInt32(textBox1.Text);
                string msg = this.DAOFun.Deletar(codigo);
                MessageBox.Show(msg);
                LimparCampos();
            } // BOTAO EXCLUIR
        }
        public void LimparCampos()
        {
            textBox1.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        } // BOTAO DE SAIR
    }
}
