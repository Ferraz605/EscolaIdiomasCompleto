using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;//importando a estrutura de tela
using System.Numerics;

namespace Escola_de_Idiomas
{
    class DAOFuncionario
    {
        public MySqlConnection conexao;
        public string dados;
        public string comando;
        Form1 Form1;
        LoginFuncionario loginFuncionario;
        public int[] codigo;
        public string[] nome;
        public string[] telefone;
        public long[] cnpj;
        public DateTime[] dataNascimento;
        public double[] salario;
        public string[] cargo;
        public string[] email;
        public string[] senha;
        public int i;
        public int contar;

        public DAOFuncionario()
        {
            conexao = new MySqlConnection("server=localhost;DataBase=escolaIdiomas;Uid=root;Password=;Convert Zero DateTime=True");
            try
            {
                conexao.Open();//abrir a conexão
            }
            catch (Exception erro)
            {
                MessageBox.Show($"Algo deu errado!\n\n {erro}");
                conexao.Close();//fecha conexão com o banco de dados
            }//fim do try_catch
        }

        public void InserirFuncionario(string nome, string telefone, string cnpj, DateTime dataNascimento, double salario, string cargo, string email, string senha)
        {
            try
            {
                string dataFormatada = dataNascimento.ToString("yyyy-MM-dd");
                this.dados = $"('', '{nome}', '{telefone}', '{cnpj}', '{dataFormatada}', '{salario}', '{cargo}', '{email}', '{senha}')";
                this.comando = $"Insert into funcionario(codigo, nome, telefone, cnpj, dataNascimento, salario, cargo, email, senha) values{this.dados}";
                //Inserir comando
                MySqlCommand sql = new MySqlCommand(this.comando, this.conexao);
                string resultado = "" + sql.ExecuteNonQuery();
                MessageBox.Show($"Inserido com Sucesso! \n\n{resultado}");
            }
            catch (Exception erro)
            {
                MessageBox.Show($"Algo deu errado\n\n {erro}");
            }
        }//fim do inserir

        public void PreencherVetor()
        {
            string query = "SELECT * FROM funcionario";

            this.codigo = new int[100];
            this.nome = new string[100];
            this.telefone = new string[100];
            this.cnpj = new long[100];
            this.dataNascimento = new DateTime[100];
            this.salario = new double[100];
            this.cargo = new string[100];
            this.email = new string[100];
            this.senha = new string[100];

            for (i = 0; i < 100; i++)
            {
                this.codigo[i] = 0;
                this.nome[i] = "";
                this.telefone[i] = "";
                this.cnpj[i] = 0;
                this.dataNascimento[i] = DateTime.MinValue;
                this.salario[i] = 0;
                this.cargo[i] = "";
                this.email[i] = "";
                this.senha[i] = "";
            }

            MySqlCommand coletar = new MySqlCommand(query, this.conexao);
            MySqlDataReader leitura = coletar.ExecuteReader();

            i = 0;
            this.contar = 0;
            while (leitura.Read())
            {
                this.codigo[i] = Convert.ToInt32(leitura["codigo"]);
                this.nome[i] = leitura["nome"] + "";
                this.telefone[i] = leitura["telefone"] + "";
                this.cnpj[i] = Convert.ToInt64(leitura["cnpj"]);
                this.dataNascimento[i] = Convert.ToDateTime(leitura["dataNascimento"]);
                this.salario[i] = Convert.ToDouble(leitura["salario"], System.Globalization.CultureInfo.InvariantCulture);
                this.cargo[i] = leitura["cargo"] + "";
                this.email[i] = leitura["email"] + "";
                this.senha[i] = leitura["senha"] + "";
                i++;
                this.contar++;
            }
            leitura.Close();
        }

        public void InserirFuncionario(string nome, string telefone, long cnpj, DateTime dataNascimento, double salario, string cargo, string email, string senha)
        {
            try
            {
                string comando = "INSERT INTO funcionario (nome, telefone, cnpj, dataNascimento, salario, cargo, email, senha) VALUES (@nome, @telefone, @cnpj, @dataNascimento, @salario, @cargo, @email, @senha)";
                MySqlCommand sql = new MySqlCommand(comando, this.conexao);
                sql.Parameters.AddWithValue("@nome", nome);
                sql.Parameters.AddWithValue("@telefone", telefone);
                sql.Parameters.AddWithValue("@cnpj", cnpj);
                sql.Parameters.AddWithValue("@dataNascimento", dataNascimento.ToString("yyyy-MM-dd"));
                sql.Parameters.AddWithValue("@salario", salario);
                sql.Parameters.AddWithValue("@cargo", cargo);
                sql.Parameters.AddWithValue("@email", email);
                sql.Parameters.AddWithValue("@senha", senha);
                int resultado = sql.ExecuteNonQuery();
                MessageBox.Show($"Inserido com Sucesso!\n\nLinhas afetadas: {resultado}");
            }
            catch (Exception erro)
            {
                MessageBox.Show($"Algo deu errado\n\n {erro.Message}");
            }
        }
        public bool ValidarLoginFuncionario(string email, string senha)
        {
            string sql = "SELECT * FROM funcionario " +
                         "WHERE email = '" + email + "' AND senha = '" + senha + "'";

            MySqlCommand cmd = new MySqlCommand(sql, conexao);
            MySqlDataReader leitura = cmd.ExecuteReader();

            bool encontrou = leitura.Read();
            leitura.Close();
            return encontrou;
        }

        public string Atualizar(int codigo, string campo, string novoDado)
        {
            try
            {
                string query = $"update funcionario set {campo} = '{novoDado}' where codigo = '{codigo}'";
                MySqlCommand sql = new MySqlCommand(query, this.conexao);
                string resultado = "" + sql.ExecuteNonQuery(); // comando de inserção no banco
                return $"Atualizado com sucesso\n\n {resultado}";
            }
            catch (Exception erro)
            {
                return $"Algo deu errado\n\n {erro}";
            }
        }
        public string Deletar(int codigo)
        {
            try
            {
                string query = "DELETE FROM funcionario WHERE codigo = @codigo";
                MySqlCommand sql = new MySqlCommand(query, this.conexao);
                sql.Parameters.AddWithValue("@codigo", codigo);
                int resultado = sql.ExecuteNonQuery();
                return resultado > 0 ? "Deletado com sucesso!" : "Nenhum registro encontrado.";
            }
            catch (Exception erro)
            {
                return $"Algo deu errado\n\n{erro.Message}";
            }
        }
    }
}
        