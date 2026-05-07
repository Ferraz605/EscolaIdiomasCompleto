create database escolaIdiomas;
 
use escolaIdiomas;
 
create table avaliacao(

	codigo int primary key not null auto_increment,

    nota decimal(4,2) not null,

    dat date not null,

    observacao varchar(50) not null

)engine = InnoDB;
 
 ALTER TABLE avaliacao ADD COLUMN alunoCodigo INT NOT NULL;

 
create table curso(

	codigo int primary key not null auto_increment,

    nome varchar(45) not null,

    cargaHoraria int not null,

    valor decimal(6,2) not null,

    avaliacaoCodigo int null,

    idiomaCodigo int null

)engine = InnoDB;
 
create table idioma(

	codigo int not null primary key auto_increment,

    titulo varchar(45) not null

)engine = InnoDB;
 
create table professor(

	codigo int not null primary key auto_increment,

    nome varchar(150) not null,

    telefone varchar(16) not null,

    formacao varchar(45) not null,

    idiomas varchar(200) not null

)engine = InnoDB;

create table funcionario(

	codigo int primary key not null auto_increment,

    nome varchar(150) not null,

    telefone varchar(16) not null,

    cnpj bigint not null,

    dataNascimento date not null,

    salario decimal(10,2) not null,

    cargo varchar(100) not null,

    email varchar(200) not null,

    senha varchar(30) not null

)engine = InnoDB;
 
 insert into funcionario value ('','josé','11992240612','23123123123','23/02/2000','1200','admin','arlindo@arlindo','arlindo');
 
 create table matricula(
 codigo int not null auto_increment primary key,
 nome varchar(100) not null,
 cpf bigint not null,
 email varchar(100) not null,
 telefone varchar(16) not null,
 dtDeNascimento dateTime not null
 )engine  InnoDB;
 
create table ministrar(

	codigo int primary key not null auto_increment,

    cursoCodigo int not null,

    professorCodigo int not null

)engine = InnoDB;
 
create table fazer(

	codigo int primary key not null auto_increment,

    alunoCodigo int not null,

    cursoCodigo int not null

)engine = InnoDB;
 
create table aluno(

	codigo int primary key not null auto_increment,

    nome varchar(150) not null,

    cpf bigint not null,

    email varchar(150) not null,

    telefone varchar(16) not null,

    dtDeNascimento date not null

)engine = InnoDB;
 
alter table fazer add constraint fazerAluno foreign key (alunoCodigo) references aluno(codigo);

alter table fazer add constraint fazerCurso foreign key (cursoCodigo) references curso(codigo);

alter table curso add constraint cursoIdioma foreign key (idiomaCodigo) references idioma(codigo);

alter table curso add constraint cursoAvaliacao foreign key (avaliacaoCodigo) references avaliacao(codigo);

alter table ministrar add constraint ministrarCurso foreign key (cursoCodigo) references curso(codigo);

alter table ministrar add constraint ministrarProfessor foreign key (professorCodigo) references professor(codigo);
 
describe idioma;

DELIMITER $$

	create procedure inserirIdioma(in codigoP int, in tituloP varchar(45))                                                                     

    begin

		insert into idioma(codigo, titulo) values

        ('', tituloP);

    end $$

DELIMITER ;

drop procedure inserirIdioma;
 
call inserirIdioma('', 'portugues');
 
describe curso;

DELIMITER $$

	create procedure inserirCurso(in codigoP int, in nomeP varchar(45), in cargaHorariaP int, in valorP decimal(6,2), in avaliacaoCodigoP int, in idiomaCodigoP int)                                                                     

    begin

		insert into curso(codigo, nome, cargaHoraria, valor, avaliacaoCodigo, idiomaCodigo) values

        ('', nomeP, cargaHorariaP, valorP, avaliacaoCodigoP, idiomaCodigoP);

    end $$

DELIMITER ;

drop procedure inserirCurso;
 
call inserirCurso('', 'Inglês Básico', 60, 850.00, 1, 1);
 
 
describe avaliacao;

DELIMITER $$

	create procedure inserirAvaliacao(in codigoP int, in notaP decimal(4,2), in datP date, in observacaoP varchar(50))                                                                     

    begin

		insert into avaliacao(codigo, nota, dat, observacao) values

        ('', notaP, datP, observacaoP);

    end $$

DELIMITER ;

drop procedure inserirAvaliacao;
 
call inserirAvaliacao('', 6.90, '2025-02-25', 'Revisar tempos verbais');
 
DELIMITER $$

	create procedure contarAvaliacao(out resultado int)

	begin

		select count(codigo) into resultado from avaliacao; 

    end $$

DELIMITER ;
 
drop procedure contarAvaliacao;
 
call contarAvaliacao(@resultado); -- Executando

select @resultado; -- Visualizando
 
select * from information_schema.routines;

DELIMITER $

	create trigger contarAvaliacaoGatilho after insert on avaliacao for each row

	begin

	call contarAvaliacao(@resultado);

	end $

DELIMITER ;
 
describe avaliacao;

call inserirAvaliacao('', 6.90, '2025-02-25', 'Revisar tempos verbais');

select @resultado;
 
-- Vizualizar os dados da tabela da esquerda - Left join
 
select * from curso;

select * from avaliacao;

select c.nome, c.cargaHoraria, c.valor, a.nota from curso c left join avaliacao a

on c.avaliacaoCodigo = c.codigo;
 
 
-- Vizualizar os dados da tabela da direita - Right join
 
select c.nome, c.cargaHoraria, c.valor, a.nota from curso c right join avaliacao a

on c.avaliacaoCodigo = c.codigo;
 
-- Vizualizar dados comuns entre as tabelas - Inner join
 
select c.nome, c.cargaHoraria, c.valor, a.nota from curso c inner join avaliacao a

on c.avaliacaoCodigo = c.codigo;
 