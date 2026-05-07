namespace Escola_de_Idiomas
{
    public partial class Form1 : Form
    {
        Cadastrar_Aluno cadastrarAluno;
        CadastrarProfessor cadastrarProfessor;
        AtualizarAluno atualizarAluno;
        AtualizarProfessor atualizarProfessor;
        AtualizarFuncionario atualizarFucionario;
        ExcluirAluno excluirAluno;
        ExcluirProfessor excluirProfessor;
        ExcluirFuncionario excluirFuncionario;
        CadastrarFuncionario cadastrarFuncionario;
        Matricula matricula;
        ConsultarMatricula ConsultarMatricula;
        ConsultarProfessor consultarProfessor;
        ConsultarFuncionario consultarFuncionario;
        Notas notas;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cadastrarAluno = new Cadastrar_Aluno();
            this.Hide(); cadastrarAluno.ShowDialog(); this.Show();
        }//botão de cadastrar aluno

        private void button2_Click(object sender, EventArgs e)
        {
            cadastrarProfessor = new CadastrarProfessor();
            this.Hide(); cadastrarProfessor.ShowDialog(); this.Show();
        }// botão de cadastrar professor

        private void button7_Click(object sender, EventArgs e)
        {
            atualizarAluno = new AtualizarAluno();
            this.Hide(); atualizarAluno.ShowDialog(); this.Show();
        }// botão de atualizar aluno

        private void button9_Click(object sender, EventArgs e)
        {
            atualizarProfessor = new AtualizarProfessor();
            this.Hide(); atualizarProfessor.ShowDialog(); this.Show();
        }// botão de atualizar professor

        private void button8_Click(object sender, EventArgs e)
        {
            excluirAluno = new ExcluirAluno();
            this.Hide(); excluirAluno.ShowDialog(); this.Show();
        }// botão de excluir aluno

        private void button10_Click(object sender, EventArgs e)
        {
            excluirProfessor = new ExcluirProfessor();
            this.Hide(); excluirProfessor.ShowDialog(); this.Show();
        }// botão de excluir professor

        private void button12_Click(object sender, EventArgs e)
        {
            cadastrarFuncionario = new CadastrarFuncionario();
            this.Hide(); cadastrarFuncionario.ShowDialog(); this.Show();
        }// fim do cadastrar funcionario

        private void button4_Click(object sender, EventArgs e)
        {
            matricula = new Matricula();
            this.Hide(); matricula.ShowDialog(); this.Show();
        }// botão de matricular aluno

        private void button6_Click(object sender, EventArgs e)
        {
            ConsultarMatricula = new ConsultarMatricula();
            this.Hide(); ConsultarMatricula.ShowDialog(); this.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            notas = new Notas();
            this.Hide(); notas.ShowDialog(); this.Show();
        }// botao pra área de notas

        private void button3_Click_1(object sender, EventArgs e)
        {
            atualizarFucionario = new AtualizarFuncionario();
            this.Hide(); atualizarFucionario.ShowDialog(); this.Show();
        } // botão atualizar funcionario

        private void button11_Click(object sender, EventArgs e)
        {
            excluirFuncionario = new ExcluirFuncionario();
            this.Hide(); excluirFuncionario.ShowDialog(); this.Show();
        } // botão excluir funcionario

        private void button14_Click(object sender, EventArgs e)
        {
            consultarProfessor = new ConsultarProfessor();
            this.Hide(); consultarProfessor.ShowDialog(); this.Show();
        } // botão consultar professor

        private void button15_Click(object sender, EventArgs e)
        {
            consultarFuncionario = new ConsultarFuncionario();
            this.Hide(); consultarFuncionario.ShowDialog(); this.Show();
        } // botão consultar funcionario

        private void button13_Click(object sender, EventArgs e)
        {
            this.Close();
        } // BOTAO SAIR DO SISTEMA
    }
}
