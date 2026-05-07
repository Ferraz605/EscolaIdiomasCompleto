using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;//importando a estrutura de tela

namespace Escola_de_Idiomas
{
	class DAOCursos
	{
		public MySqlConnection conexao;
		public string dados;
		public string comando;
		public int[] codigo;
		public string[] nome;
		public long[] cpf;
		public string[] email;
		public string[] telefone;
		public DateTime[] dtDeNascimento;
		public int[] cargaHoraria;
		public double[] valor;
		public int i;
		public int contar;
		public string msg;

		public DAOCursos()
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

		public void InserirCursos(string nome, int cargaHoraria, double valor)
		{
			try
			{
				this.dados = $"('', '{nome}', '{cargaHoraria}', '{valor}')";
				this.comando = $"Insert into curso(codigo, nome, cargaHoraria, valor) values{this.dados}";
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


		public string DeletarCurso(int codigo)
		{
			try
			{
				string query = $"DELETE FROM curso WHERE codigo = {codigo}";

				MySqlCommand sql = new MySqlCommand(query, this.conexao);
				int resultado = sql.ExecuteNonQuery();

				if (resultado > 0)
				{
					return "Deletado com sucesso!";
				}
				else
				{
					return "Nenhum registro encontrado com esse código.";
				}
			}
			catch (Exception erro)
			{
				return $"Algo deu errado\n\n{erro.Message}";
			}
		}

		//Preencher Vetor --> Coletar os dados do banco e preenhcer o vetor
		public void PreencherVetor()
		{
			string query = "select * from curso";//Buscando todos os dados da tabela autor
												 //Instanciar os vetores
			this.codigo = new int[100];
			this.nome = new string[100];
			this.cargaHoraria = new int[100];
			this.valor = new double[100];

			//Preencher os vetores com valores padrões
			for (i = 0; i < 100; i++)
			{
				this.codigo[i] = 0;
				this.nome[i] = "";
				this.cargaHoraria[i] = 0;
				this.valor[i] = 0;

			}//fim do for

			//Executar o comando do SQL
			MySqlCommand coletar = new MySqlCommand(query, this.conexao);

			//Leitura do dado no banco
			MySqlDataReader leitura = coletar.ExecuteReader();//Percorre o banco e traz os dados

			//Zerar o contador
			i = 0;
			this.contar = 0;
			while (leitura.Read())
			{
				this.codigo[i] = Convert.ToInt32(leitura["codigo"]);
				this.nome[i] = leitura["nome"] + "";
				this.cargaHoraria[i] = Convert.ToInt32(leitura["cargaHoraria"] + "");
				this.valor[i] = Convert.ToDouble(leitura["valor"] + "");
				i++;
				this.contar++;
			}//fim do while
			leitura.Close();//Encerrando o processo de busca
		}//fim do método
        public string Atualizar(int codigo, string campo, string novoDado)
        {
            try
            {
                string query = $"update curso set {campo} = '{novoDado}' where codigo = '{codigo}'";
                MySqlCommand sql = new MySqlCommand(query, this.conexao);
                string resultado = "" + sql.ExecuteNonQuery(); // comando de inserção no banco
                return $"Atualizado com sucesso\n\n {resultado}";
            }
            catch (Exception erro)
            {
                return $"Algo deu errado\n\n {erro}";
            }
        }
    }
}

