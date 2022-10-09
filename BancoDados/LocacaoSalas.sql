use [master];
DROP DATABASE IF EXISTS LocacaoSalas; /***Comando para apagar todas as tabelas***/
GO

CREATE DATABASE LocacaoSalas; /** Recria as tabelas***/
GO

use LocacaoSalas;
GO

CREATE TABLE Enderecos(
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
FOREIGN KEY(codend) REFERENCES Enderecos
);

CREATE TABLE Horarios(
codh integer,
inicio time,
fim time,
PRIMARY KEY(codh)
);

CREATE TABLE Periodos(
codp integer,
codh integer,
diaSemana date,
preco numeric(20),
estaAtiva bit,
PRIMARY KEY (codp),
FOREIGN KEY(codh) REFERENCES Horarios
);

CREATE TABLE Disponibilidades(
codd integer,
cods integer,
codp integer,
PRIMARY KEY(codd),
FOREIGN KEY(cods) REFERENCES Salas,
FOREIGN KEY(codp) REFERENCES Periodos
);

CREATE TABLE Clientes(
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
nome varchar(40) not null,
descricao varchar (100) not null,
voltagemVolts numeric(3),
pesoKg numeric(5),
volume smallint,
custoTotal numeric(20),
custoSeguro numeric(20),
custoHora numeric(20),
PRIMARY KEY (code)
);

CREATE TABLE MateriaisEscritorios(
codme integer,
nome varchar(100),
quantidade numeric(10),
PRIMARY KEY(codme)
);

CREATE TABLE Limpezas(
codl integer,
tipo varchar(40),
descricao varchar(100)
PRIMARY KEY(codl)
);

CREATE TABLE Objetos(
codob integer,
nome varchar(50),
descricao varchar(100)
PRIMARY KEY(codob)
);

CREATE TABLE CoffeeBreaks(
codcb integer,
tipo varchar(50),
nome varchar(80) not null,
quantidade numeric(10),
recheio varchar(50),
PRIMARY KEY(codcb)
);

CREATE TABLE Impressoes(
codi integer,
descricao varchar(100),
custo numeric(10),
PRIMARY KEY(codi)
);

CREATE TABLE Servicos(
codserv integer,
codcb integer,
codme integer,
codl integer,
codi integer,
codob integer, 
descricao varchar (100) not null,
custo numeric(20),
PRIMARY KEY(codserv),
FOREIGN KEY(codl) REFERENCES Limpezas,
FOREIGN KEY(codme) REFERENCES MateriaisEscritorios,
FOREIGN KEY(codcb) REFERENCES CoffeeBreaks,
FOREIGN KEY(codi) REFERENCES Impressoes,
FOREIGN KEY(codob) REFERENCES Objetos
);

CREATE TABLE Reservas(
codr integer,
codd integer,
code integer,
codserv integer,
codob integer,
valorTotal numeric(6),
reservaEfetuada bit,
PRIMARY KEY(codr),
FOREIGN KEY(codd) REFERENCES Disponibilidades,
FOREIGN KEY(code) REFERENCES Equipamentos,
FOREIGN KEY(codserv) REFERENCES Servicos,
FOREIGN KEY(codob) REFERENCES Objetos
)







