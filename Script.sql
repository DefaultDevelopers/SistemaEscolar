#User		
INSERT INTO User (idUser, user) VALUES (001, "Adm");		
INSERT INTO User (idUser, user) VALUES (002, "Professor");		
INSERT INTO User (idUser, user) VALUES (003, "Aluno");		
		
#Tipos		
INSERT INTO Tipo (idTipo, tipo) VALUES (001, "Integrado");		
INSERT INTO Tipo (idTipo, tipo) VALUES (002, "Concomitante");		
INSERT INTO Tipo (idTipo, tipo) VALUES (003, "Subsequente");
		
#Turno		
INSERT INTO Turno (idTurno, turno) VALUES (001, "Matutino");		
INSERT INTO Turno (idTurno, turno) VALUES (002, "Vespertino");		
INSERT INTO Turno (idTurno, turno) VALUES (003, "Noturno");		
		
#Cursos		
INSERT INTO Curso (idCurso, nome, descricao) VALUES (205, "Informática", "Curso direcionado ao ensino básico de programação de computadores.");		
INSERT INTO Curso (idCurso, nome, descricao) VALUES (245, "Telecomunicações", "Curso direcionado ao ensino básico de telecomunicações.");		
INSERT INTO Curso (idCurso, nome, descricao) VALUES (215, "Mecânica", "Curso direcionado ao ensino báscio de mecânica.");		
INSERT INTO Curso (idCurso, nome, descricao) VALUES (255, "Eletrônica", "Curso direcionado ao ensino báscio de Eletrônica.");		
		
#Turma		
INSERT INTO Turma (idTurma, Curso_idCurso, Turno_idTurno, Tipo_idTipo, sala) VALUES (610, 205, 002, 001, 15);		
INSERT INTO Turma (idTurma, Curso_idCurso, Turno_idTurno, Tipo_idTipo, sala) VALUES (645, 245, 002, 001, 17);		
INSERT INTO Turma (idTurma, Curso_idCurso, Turno_idTurno, Tipo_idTipo, sala) VALUES (620, 215, 003, 002, 16);		
		
#Disciplina		
INSERT INTO Disciplina (idDisciplina, carga_horaria, nome, descricao) VALUES (025, 80, "Programação Orientada a Objetos", "Disciplina que introduz o conceito da programação orientada a objetos.");		
INSERT INTO Disciplina (idDisciplina, carga_horaria, nome, descricao) VALUES (035, 60, "Física", "Disciplina que introduz conceitos importantes de física para o curso de mecânica.");		
INSERT INTO Disciplina (idDisciplina, carga_horaria, nome, descricao) VALUES (095, 120, "Análise de Circuitos", "Disciplina que introduz conceitos importantes sobre a análise de circuitos.");
#Login		
INSERT INTO Login (Login, Senha, User_idUser) VALUES ("admin", 12345, 001);

#SELECTs
select * from login;
SELECT * FROM Aluno;
select * from matricula;
SELECT * FROM Professor;
SELECT * FROM professor_turma;
select * from boletim;
select * from disc_boletim;

INSERT INTO Login (Login, Senha, User_idUser) VALUES ("12345", 12345, 003);
insert into aluno (Login_Login, nome, email, cpf, telefone, data_nascimento) values ('12345', 'arnaldo', 'aaasa', '21331213', '12391203', '2014-12-22');


insert into boletim (Aluno_Login_Login, Turma_idTurma, Disciplina_idDisciplina, nota1, nota2, nota3, nota4, media, ano) values ('12345', 610, 95, 0, 0, 0, 0, 0, 2014);
#inserir
insert into boletim (Aluno_Login_Login, Turma_idTurma, Disciplina_idDisciplina, nota1, nota2, nota3, nota4, media, ano) values ('12345', 610, 25, 0, 0, 0, 0, 0, 2014) ON DUPLICATE KEY UPDATE nota1 = 9;
insert into disc_boletim (Disciplina_idDisciplina) values (95);

#pesquisar
select distinct Login_Login as 'Matrícula', nome as 'Nome', nota1, nota2, nota3, nota4 FROM boletim, aluno where Turma_idTurma = 610 AND Disciplina_idDisciplina = 25;