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
    public partial class ConsultarMatricula : Form
    {
        DAOAluno aluno;
        public ConsultarMatricula()
        {
            InitializeComponent();
            this.aluno = new DAOAluno();
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
            dataGrid.Columns[2].Name = "CPF";
            dataGrid.Columns[3].Name = "Email";
            dataGrid.Columns[4].Name = "Telefone";
            dataGrid.Columns[5].Name = "Dt. Nascimento";
        }

        public void ConfigurarDataGrid(DataGridView dataGrid)
        {
            dataGrid.AllowUserToAddRows = false;
            dataGrid.AllowUserToDeleteRows = false;
            dataGrid.AllowUserToResizeColumns = false;
            dataGrid.AllowUserToResizeRows = false;
            dataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGrid.ColumnCount = 6;
        }

        public void AdicionarDados(DataGridView dataGrid)
        {
            this.aluno.PreencherVetor();
            for (int i = 0; i < this.aluno.contar; i++)
            {
                dataGrid.Rows.Add(
                    this.aluno.codigo[i],
                    this.aluno.nome[i],
                    this.aluno.cpf[i],
                    this.aluno.email[i],
                    this.aluno.telefone[i],
                    this.aluno.dtDeNascimento[i].ToString("dd/MM/yyyy")
                );
            }
        }

        public DataGridView retornarData()
        {
            return dataGridView1;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        } // BOTAO DE SAIR
    }
}
