using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;//importando a estrutura de tela
using MySql.Data.MySqlClient;//importando a estrutura de conexão com o banco de dados

namespace Escola_de_Idiomas
{
	class DAONotas
	{
		public MySqlConnection conexao;
		public string dados;
		public string comando;
		public int[] codigo;
		public decimal[] nota;
		public DateTime[] dat;
		public string[] observacao;
		public int i;
		public int contar;
		public string msg;
        public int[] alunoCodigo;

        public DAONotas()
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

        public void InserirNotas(decimal nota, DateTime dat, string observacao, int alunoCodigo)
        {
            try
            {
                string dataFormatada = dat.ToString("yyyy-MM-dd");
                string notaFormatada = nota.ToString(System.Globalization.CultureInfo.InvariantCulture);
                this.dados = $"('','{notaFormatada}','{dataFormatada}','{observacao}','{alunoCodigo}')";
                this.comando = $"Insert into avaliacao(codigo, nota, dat, observacao, alunoCodigo) values{this.dados}";

                MySqlCommand sql = new MySqlCommand(this.comando, this.conexao);
                string resultado = "" + sql.ExecuteNonQuery();
                MessageBox.Show($"Inserido com sucesso!");
            }
            catch (Exception erro)
            {
                MessageBox.Show($"Algo deu errado\n\n {erro}");
            }
        }

        //Preencher Vetor --> Coletar os dados do banco e preenhcer o vetor
        public void PreencherVetor()
		{
			string query = "select * from avaliacao";//Buscando todos os dados da tabela autor
													 //Instanciar os vetores
			this.codigo = new int[100];
			this.nota = new decimal[100];
			this.dat = new DateTime[100];
			this.observacao = new string[100];
            this.alunoCodigo = new int[100];

            //Preencher os vetores com valores padrões
            for (i = 0; i < 100; i++)
			{
				this.codigo[i] = 0;
				this.nota[i] = 0;
				this.dat[i] = DateTime.MinValue;
				this.observacao[i] = "";
                this.alunoCodigo[i] = 0;
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
				this.nota[i] = Convert.ToDecimal(leitura["nota"] + "");
				this.dat[i] = Convert.ToDateTime(leitura["dat"] + "");
				this.observacao[i] = leitura["observacao"] + "";
                this.alunoCodigo[i] = Convert.ToInt32(leitura["alunoCodigo"]);
                i++;
				this.contar++;//Informar quantos dados tem no banco
			}//fim do while

			leitura.Close();//Encerrando o processo de busca
		}//fim do método


		public string Deletar(int codigo)
		{
			try
			{
				string query = $"DELETE FROM avaliacao WHERE codigo = {codigo}";

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

		public string Atualizar(int codigo, string campo, string novoDado)
		{
			try
			{
				string query = $"update avaliacao set {campo} = '{novoDado}' where codigo = '{codigo}'";
				MySqlCommand sql = new MySqlCommand(query, this.conexao);
				string resultado = "" + sql.ExecuteNonQuery(); // comando de inserção no banco
				return $"Atualizado com sucesso";
			}
			catch (Exception erro)
			{
				return $"Algo deu errado\n\n {erro}";
			}

		}
	}
}
