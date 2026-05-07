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
    public partial class ConsultarFuncionario : Form
    {
        DAOFuncionario funcionario;

        public ConsultarFuncionario()
        {
            InitializeComponent();
            this.funcionario = new DAOFuncionario();
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
            dataGrid.Columns[3].Name = "CNPJ";
            dataGrid.Columns[4].Name = "Dt. Nascimento";
            dataGrid.Columns[5].Name = "Salário";
            dataGrid.Columns[6].Name = "Cargo";
            dataGrid.Columns[7].Name = "Email";
            dataGrid.Columns[8].Name = "Senha";
        }

        public void ConfigurarDataGrid(DataGridView dataGrid)
        {
            dataGrid.AllowUserToAddRows = false;
            dataGrid.AllowUserToDeleteRows = false;
            dataGrid.AllowUserToResizeColumns = false;
            dataGrid.AllowUserToResizeRows = false;
            dataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGrid.ColumnCount = 9; // codigo, nome, telefone, cnpj, dataNascimento, salario, cargo, email, senha
        }

        public void AdicionarDados(DataGridView dataGrid)
        {
            this.funcionario.PreencherVetor();
            for (int i = 0; i < this.funcionario.contar; i++)
            {
                dataGrid.Rows.Add(
                    this.funcionario.codigo[i],
                    this.funcionario.nome[i],
                    this.funcionario.telefone[i],
                    this.funcionario.cnpj[i],
                    this.funcionario.dataNascimento[i].ToString("dd/MM/yyyy"),
                    this.funcionario.salario[i],
                    this.funcionario.cargo[i],
                    this.funcionario.email[i],
                    this.funcionario.senha[i]
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
