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
    public partial class ConsultarProfessor : Form
    {
        DAOProfessor professor;

        public ConsultarProfessor()
        {
            InitializeComponent();
            professor = new DAOProfessor();
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
            dataGrid.Columns[2].Name = "Telefone";
            dataGrid.Columns[3].Name = "Formação";
            dataGrid.Columns[4].Name = "Idiomas";
        }

        public void ConfigurarDataGrid(DataGridView dataGrid)
        {
            dataGrid.AllowUserToAddRows = false;
            dataGrid.AllowUserToDeleteRows = false;
            dataGrid.AllowUserToResizeColumns = false;
            dataGrid.AllowUserToResizeRows = false;
            dataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGrid.ColumnCount = 5; // codigo, nome, telefone, formacao, idiomas
        }

        public void AdicionarDados(DataGridView dataGrid)
        {
            this.professor.PreencherVetor();
            for (int i = 0; i < this.professor.contar; i++)
            {
                dataGrid.Rows.Add(
                    this.professor.codigo[i],
                    this.professor.nome[i],
                    this.professor.telefone[i],
                    this.professor.formacao[i],
                    this.professor.idiomas[i]
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
        } // BOTAO CONSULTAR PROFESSOR
    }
}
