

use [master];
DROP DATABASE IF EXISTS [LocacaoSalas]; /***Comando para apagar todas as tabelas***/
GO

use LocacaoSalas;

CREATE DATABASE [LocacaoSalas2]; /** Recriar as tabelas***/
GO

use LocacaoSalas;

GO

CREATE TABLE Equipamentos (
code integer,
nome varchar(40) not null,
descricao varchar (100) not null,
voltagemVolts numeric(3) unique,
pesoKg numeric(5) unique,
volume smallint,
custoTotal numeric(20) unique,
custoSeguro numeric(20) unique,
custoHora numeric(20) unique,
PRIMARY KEY (code)
);

CREATE TABLE Salas (
cods integer,
id numeric(5), 
descricao varchar (100) not null,
identificacao varchar (100) not null,
estado varchar (100) not null,
mediaLado1Metros numeric(10),
medialado2Metros numeric(10),
capacidadeMaximaPessoas numeric(10),
janelas varchar(3),
localizacao varchar (100) not null,
temBanheiro varchar(3) not null,
temEstacionamento varchar(3) not null,
temArCondicionado varchar(3) not null,
PRIMARY KEY (cods)
);

CREATE TABLE Servico(
id numeric(5), 
descricao varchar (100) not null,
custo numeric(20) unique,
);

CREATE TABLE Periodo(
codp integer,
diaSemana date,
horario time,
preco numeric(20) unique,
estaAtiva varchar(3) not null,
PRIMARY KEY (codp)
);

CREATE TABLE Horario(
codh integer,
inicio time,
fim time,
PRIMARY KEY(codh)
);

CREATE TABLE Endereco(
logradouro varchar(60) not null,
bairro varchar(30) not null,
numero numeric(5),
complemento varchar(3) not null
);

CREATE TABLE Disponibilidade(
cods integer,
codp integer,
FOREIGN KEY(cods) REFERENCES Salas,
FOREIGN KEY(codp) REFERENCES Periodo
);

CREATE TABLE Cliente(
nome varchar (100) not null,
email varchar (100) not null,
celular numeric(10),
cpf numeric(14),
cnpj numeric(20)
)



