create database projetoProfessor;

create table professor (
	codigo integer auto_increment,
    nome varchar(255),
    email varchar(255), 
    senha varchar(255), 
    telefone varchar(15),
    ativo boolean,
    primary key (codigo)
);

create table usuario (
	codigo integer auto_increment,
    nome varchar(50),
    email varchar(100),
    senha varchar(20),
    primary key (codigo)
);