use [master];
DROP DATABASE IF EXISTS LocacaoSalas; /***Comando para apagar todas as tabelas***/
GO

CREATE DATABASE LocacaoSalas; /** Recria as tabelas***/
GO

use LocacaoSalas;
GO

CREATE TABLE Endereco(
codend integer,
logradouro varchar(60) not null,
bairro varchar(30),
numero numeric(5),
complemento varchar(30),
cidade varchar(30),
estado varchar(2),
PRIMARY KEY(codend)
);

CREATE TABLE Salas (
codend integer,
cods integer,
id varchar(2),
descricao varchar (100) not null,
estado varchar (100) not null,
mediaLado1Metros numeric(10),
medialado2Metros numeric(10),
capacidadeMaximaPessoas numeric(10),
janelas bit,
localizacao varchar (150) not null,
temBanheiro bit,
temEstacionamento bit,
temArCondicionado bit,
PRIMARY KEY (cods),
FOREIGN KEY(codend) REFERENCES Endereco
);

CREATE TABLE Horario(
codh integer,
inicio time,
fim time,
PRIMARY KEY(codh)
);

CREATE TABLE Periodo(
codp integer,
codh integer,
diaSemana date,
horario time,
preco numeric(20),
estaAtiva varchar(3) not null,
PRIMARY KEY (codp),
FOREIGN KEY(codh) REFERENCES Horario
);

CREATE TABLE Reserva(
codr integer,
codc integer,
salaReservada varchar(30),
PRIMARY KEY(codr),
FOREIGN KEY(codc) REFERENCES Reserva
);

CREATE TABLE Disponibilidade(
cods integer,
codp integer,
FOREIGN KEY(cods) REFERENCES Salas,
FOREIGN KEY(codp) REFERENCES Periodo
);

CREATE TABLE Cliente(
codc integer,
nome varchar (100) not null,
email varchar (100) not null,
celular numeric(10),
cpf numeric(14),
cnpj numeric(20),
PRIMARY KEY(codc)
);

CREATE TABLE Equipamentos (
code integer,
codr integer,
nome varchar(40) not null,
descricao varchar (100) not null,
voltagemVolts numeric(3),
pesoKg numeric(5),
volume smallint,
custoTotal numeric(20),
custoSeguro numeric(20),
custoHora numeric(20),
PRIMARY KEY (code),
FOREIGN KEY(codr) REFERENCES Reserva
);

CREATE TABLE MateriaisEscritorio(
codme integer,
nome varchar(100) not null,
quantidade numeric(5),
PRIMARY KEY(codme)
);

CREATE TABLE Limpeza(
codl integer,
tipo varchar(40),
descricao varchar(100)
PRIMARY KEY(codl)
);

CREATE TABLE CoffeBreak(
codcb integer,
tipo varchar(50),
nome varchar(80) not null,
quantidade numeric(10),
recheio varchar(50),
PRIMARY KEY(codcb)
);

CREATE TABLE Impressao(
codi integer,
descricao varchar(100),
custo numeric(10),
PRIMARY KEY(codi)
);

CREATE TABLE Servico(
codcb integer,
codme integer,
codl integer,
codi integer,
codr integer,
codserv numeric(5) not null, 
descricao varchar (100) not null,
custo numeric(20),
PRIMARY KEY(codserv),
FOREIGN KEY(codl) REFERENCES Limpeza,
FOREIGN KEY(codme) REFERENCES MateriaisEscritorio,
FOREIGN KEY(codcb) REFERENCES CoffeBreak,
FOREIGN KEY(codi) REFERENCES Impressao,
FOREIGN KEY(codr) REFERENCES Reserva
)






