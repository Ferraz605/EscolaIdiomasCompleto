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
    public partial class Cursos : Form
    {
        DAOCursos cursos;
        AdicionarCursos adicionarCursos;
        ExcluirCursos excluirCursos;
        AtualizarCursos atualizarCursos;

        public Cursos()
        {
            InitializeComponent();
            this.cursos = new DAOCursos();
            ChamarMetodo(dataGridView1);
        }

        public void ChamarMetodo(DataGridView datagrid)
        {
            ConfigurarDataGrid(datagrid);
            NomeColunas(datagrid);
            AdicionarDados(datagrid);
        }

        public void NomeColunas(DataGridView dataGrid)
        {
            dataGrid.Columns[0].Name = "Código";
            dataGrid.Columns[1].Name = "Nome";
            dataGrid.Columns[2].Name = "CargaHoraria";
            dataGrid.Columns[3].Name = "Valor";
        }

        public void ConfigurarDataGrid(DataGridView dataGrid)
        {
            dataGrid.AllowUserToAddRows = false;
            dataGrid.AllowUserToDeleteRows = false;
            dataGrid.AllowUserToResizeColumns = false;
            dataGrid.AllowUserToResizeRows = false;
            dataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGrid.ColumnCount = 4;
        }

        public void AdicionarDados(DataGridView dataGrid)
        {
            this.cursos.PreencherVetor();
            for (int i = 0; i < this.cursos.contar; i++)
            {
                dataGrid.Rows.Add(
                    this.cursos.codigo[i],
                    this.cursos.nome[i],
                    this.cursos.cargaHoraria[i],
                    this.cursos.valor[i]
                );
            }
        }

        public DataGridView retornarData()
        {
            return dataGridView1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            adicionarCursos = new AdicionarCursos();
            this.Hide();
            adicionarCursos.ShowDialog();
            this.Show();
        }// fim do botão adicionar cursos

        private void button2_Click(object sender, EventArgs e)
        {
            excluirCursos = new ExcluirCursos();
            this.Hide();
            excluirCursos.ShowDialog();
            this.Show();
        }// fim do botão excluir cursos

        private void Cursos_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        } // BOTAO DE SAIR

        private void button4_Click(object sender, EventArgs e)
        {
            atualizarCursos = new AtualizarCursos();
            this.Hide();
            atualizarCursos.ShowDialog();
            this.Show();
        } // BOTAO ATUALIZAR CURSOS
    }
}
