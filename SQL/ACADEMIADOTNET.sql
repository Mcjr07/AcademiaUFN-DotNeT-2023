CREATE DATABASE ACADEMIADOTNET
ON PRIMARY (
	NAME = ACADEMIADOTNET,
	FILENAME = 'F:\workspace\Academia dotnet\SQL\ACADEMIADOTNET.MDF'
);

USE ACADEMIADOTNET;

DROP DATABASE ACADEMIADOTNET;

CREATE TABLE alunos
(
	CPF VARCHAR(11) PRIMARY KEY,
	nome VARCHAR(50) NOT NULL,
	idade INTEGER,
	email VARCHAR(40) NOT NULL,
	endereco VARCHAR(80),
	fone VARCHAR(12),
	sexo CHAR,
	CHECK(sexo in ('M', 'F'))
);

DROP TABLE alunos;

ALTER TABLE alunos
ADD  RG VARCHAR(12)

ALTER TABLE alunos
DROP COLUMN idade;

ALTER TABLE alunos
ALTER COLUMN nome VARCHAR(100) NOT NULL;

SP_RENAME 'alunos.nome', 'nome_completo', 'COLUMN';

CREATE TABLE cursos
(
	ID INTEGER PRIMARY KEY IDENTITY,
	nome VARCHAR(30) NOT NULL,
	cargaHoraria INTEGER,
	ativo BIT DEFAULT 1,
	descricao TEXT
);

CREATE TABLE disciplina
(
	ID INTEGER PRIMARY KEY IDENTITY,
	nome VARCHAR(30) NOT NULL,
	cargaHoraria INTEGER NOT NULL,
	Fk_curso INTEGER NOT NULL,
	FOREIGN KEY (fk_curso) references cursos(ID)
);

CREATE TABLE matriculas
(
	ID INTEGER PRIMARY KEY IDENTITY,
	quando DATETIME DEFAULT GETDATE(),
	fk_aluno VARCHAR(11) NOT NULL,
	fk_curso INTEGER NOT NULL,
	FOREIGN KEY (fk_aluno) REFERENCES alunos(CPF),
	FOREIGN KEY (fk_curso) REFERENCES cursos(ID)
);



SP_HELPDB ACADEMIADOTNET;

EXEC sp_help matriculas;