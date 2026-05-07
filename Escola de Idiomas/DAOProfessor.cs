using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escola_de_Idiomas
{
	class DAOProfessor
	{
		public MySqlConnection conexao;
		public string dados;
		public string comando;
        public int[] codigo;
        public string[] nome;
        public string[] telefone;
        public string[] formacao;
        public string[] idiomas;
        public int i;
        public int contar;

        public DAOProfessor()
		{
			conexao = new MySqlConnection("server=localhost;DataBase=escolaIdiomas;Uid=root;Password=;Convert Zero DateTime=True");
			try
			{
				conexao.Open();//abrir a conexão
			}
			catch (Exception erro)
			{
				System.Windows.Forms.MessageBox.Show($"Algo deu errado!\n\n {erro}");
				conexao.Close();//fecha conexão com o banco de dados
			}//fim do try_catch
		}

		public void InserirProf(string nome, string telefone, string formacao, string idiomas)
		{
			try
			{
				this.dados = $"('', '{nome}', '{telefone}', '{formacao}', '{idiomas}')";
				this.comando = $"Insert into professor(codigo, nome, telefone, formacao, idiomas) values{this.dados}";
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
            string query = "SELECT * FROM professor";

            this.codigo = new int[100];
            this.nome = new string[100];
            this.telefone = new string[100];
            this.formacao = new string[100];
            this.idiomas = new string[100];

            for (i = 0; i < 100; i++)
            {
                this.codigo[i] = 0;
                this.nome[i] = "";
                this.telefone[i] = "";
                this.formacao[i] = "";
                this.idiomas[i] = "";
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
                this.formacao[i] = leitura["formacao"] + "";
                this.idiomas[i] = leitura["idiomas"] + "";
                i++;
                this.contar++;
            }
            leitura.Close();
        }

        public string atualizarProfessor(int codigo, string campo, string novoDado)
		{
			try
			{
				string query = $"update professor set {campo} = '{novoDado}' where codigo = '{codigo}'";
				//executar o comando

				MySqlCommand sql = new MySqlCommand(query, this.conexao);
				string resultado = "" + sql.ExecuteNonQuery();//comando da inserção no banco
				return $"Atualizado com sucesso!\n\n{resultado}";
			}
			catch (Exception erro)
			{
				return $"Algo deu errado\n\n{erro}";
			}
		}

		public string deletar(int codigo)
		{
			try
			{
				string query = $"delete from professor where codigo = '{codigo}'";
				//executar o comando

				MySqlCommand sql = new MySqlCommand(query, this.conexao);
				string resultado = "" + sql.ExecuteNonQuery();//comando da inserção no banco
				return $"Deletado com sucesso!\n\n{resultado}";
			}
			catch (Exception erro)
			{
				return $"Algo deu errado\n\n{erro}";
			}
		}
	}
}
