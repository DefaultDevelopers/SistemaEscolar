#User
INSERT INTO User (idUser, user) VALUES (001, "Adm");
INSERT INTO User (idUser, user) VALUES (002, "Professor");
INSERT INTO User (idUser, user) VALUES (003, "Aluno");
#TestesUser
SELECT * FROM User;

#Tipos
INSERT INTO Tipo (idTipo, tipo) VALUES (001, "Integrado");
INSERT INTO Tipo (idTipo, tipo) VALUES (002, "Concomitante");
INSERT INTO Tipo (idTipo, tipo) VALUES (003, "Subsequente");
#TesteTipo
SELECT * FROM Tipo;
SELECT idTipo, tipo FROM Tipo;

#Turno
INSERT INTO Turno (idTurno, turno) VALUES (001, "Matutino");
INSERT INTO Turno (idTurno, turno) VALUES (002, "Vespertino");
INSERT INTO Turno (idTurno, turno) VALUES (003, "Noturno");
#TesteTurno
SELECT * FROM Turno;

#Cursos
INSERT INTO Curso (idCurso, Tipo_idTipo, Turno_idTurno, nome, descricao) VALUES (205, 001, 002, "Informática", "Curso direcionado ao ensino básico de programação de computadores.");
INSERT INTO Curso (idCurso, Tipo_idTipo, Turno_idTurno, nome, descricao) VALUES (245, 001, 002, "Telecomunicações", "Curso direcionado ao ensino básico de telecomunicações.");
INSERT INTO Curso (idCurso, Tipo_idTipo, Turno_idTurno, nome, descricao) VALUES (215, 003, 002, "Mecânica", "Curso direcionado ao ensino báscio de mecânica.");
INSERT INTO Curso (idCurso, Tipo_idTipo, Turno_idTurno, nome, descricao) VALUES (255, 002, 003, "Eletrônica", "Curso direcionado ao ensino báscio de Eletrônica.");
#TestesCurso
SELECT * FROM Curso;
SELECT idCurso as 'ID do Curso', nome as 'Nome do Curso', tipo as 'Tipo', turno as 'Turno', descricao as 'Descrição' FROM Curso=c, Tipo=t, Turno=tu WHERE c.Tipo_idTipo=t.idTipo AND c.Turno_idTurno=tu.idTurno;
UPDATE Curso SET nome = 'Eletrônica' WHERE idCurso = 255;

#Turma
INSERT INTO Turma (idTurma, Curso_idCurso, sala) VALUES (610, 205, 15);
INSERT INTO Turma (idTurma, Curso_idCurso, sala) VALUES (620, 215, 16);
#TestesTurma
SELECT idTurma, sala FROM Turma WHERE idCurso = 205;
SELECT idTurma, idCurso FROM Turma;
SELECT DISTINCT t.idTurma FROM Turma=t, Curso=c WHERE t.idCurso = 0;

#Disciplina
INSERT INTO Disciplina (idDisciplina, Curso_idCurso, carga_horaria, nome, descricao) VALUES (025, 205, 80, "Programação Orientada a Objetos", "Disciplina que introduz o conceito da programação orientada a objetos.");
INSERT INTO Disciplina (idDisciplina, Curso_idCurso, carga_horaria, nome, descricao) VALUES (035, 215, 60, "Física", "Disciplina que introduz conceitos importantes de física para o curso de mecânica.");
INSERT INTO Disciplina (idDisciplina, Curso_idCurso, carga_horaria, nome, descricao) VALUES (095, 255, 120, "Análise de Circuitos", "Disciplina que introduz conceitos importantes sobre a análise de circuitos.");
#TestesDisciplina
SELECT * FROM Disciplina;
SELECT DISTINCT idDisciplina as 'ID da Disciplina', d.nome as 'Nome', carga_horaria as 'Carga Horária', d.descricao as 'Descrição' FROM Disciplina=d, Curso=c;

#Login
INSERT INTO Login (Login, Senha, User_idUser) VALUES (2012145234, 123456, 003);
INSERT INTO Login (Login, Senha, User_idUser) VALUES (20145768, 123456, 002);
INSERT INTO Login (Login, Senha, User_idUser) VALUES ("admin", 12345, 001);
INSERT INTO Login (Login, Senha, User_idUser) VALUES (2014205123, 123456, 003);
#TestesLogin
SELECT * FROM Login;
SELECT Login , Senha, u.user as 'Tipo de usuário' FROM Login=l, User=u WHERE l.User_idUser=u.idUser;

SELECT idUser FROM Login WHERE Login = 'admin';

SELECT nome, idCurso FROM Curso WHERE idTurno = 002 AND idTipo = 1;

#Aluno
INSERT INTO Aluno (Login_Login, nome, email, cpf, telefone, data_nascimento, endereco) VALUES (2014205123, "Ronaldo", 'ronaldo@', 2312312, 23323123, '2014-11-21', "Rua abacaxi");
SELECT * FROM Aluno;

#Matricula
SELECT Turma_idTurma FROM Matricula WHERE Aluno_Login_Login = '20143447123';

SELECT idAluno as 'ID do Aluno', Login_Login as 'Matrícula', Turma_idTurma as 'Turma', nome as 'Nome', email as 'E-mail', cpf as 'CPF', telefone as 'Telefone', data_nascimento as 'Data de Nascimento', endereco as 'Endereço' FROM Login, Aluno, Matricula WHERE Login = Login_Login;

DELETE FROM Login WHERE Login = '20149440123';