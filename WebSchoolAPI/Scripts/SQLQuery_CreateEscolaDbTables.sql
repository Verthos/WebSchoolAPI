CREATE TABLE MATERIAS (
  MATERIA_ID int IDENTITY(1,1) NOT NULL PRIMARY KEY,
  NOME nvarchar(255) NOT NULL,
)
CREATE TABLE SALAS (
  SALA_ID int IDENTITY(1,1) NOT NULL PRIMARY KEY,
  BLOCO char(10),
  NOME nvarchar(255) NOT NULL,
);

CREATE TABLE PROFESSORES (
  PROFESSOR_ID int IDENTITY(1,1) NOT NULL PRIMARY KEY,
  NOME nvarchar(255) NOT NULL,
  SOBRENOME nvarchar(255) NOT NULL,
  IDADE int NOT NULL,
  RG nvarchar(255),
  DATA_INICIO datetime NOT NULL,
  MATERIA_ID int NOT NULL
  CONSTRAINT FK_MATERIAS_PROFESSORES FOREIGN KEY (MATERIA_ID)     
    REFERENCES MATERIAS (MATERIA_ID)
);
CREATE TABLE ALUNOS (
  ALUNO_ID int IDENTITY(1,1) NOT NULL PRIMARY KEY,
  NOME nvarchar(255) NOT NULL,
  SOBRENOME nvarchar(255) NOT NULL,
  IDADE int NOT NULL,
  RG nvarchar(255),
  DATA_MATRICULA datetime NOT NULL,
  MATERIA_ID int,
  SALA_ID int
  CONSTRAINT FK_ALUNOS_MATERIAS FOREIGN KEY (MATERIA_ID)     
    REFERENCES MATERIAS (MATERIA_ID),
  CONSTRAINT FK_ALUNOS_SALAS FOREIGN KEY (SALA_ID)     
    REFERENCES SALAS (SALA_ID)
);
