#Tipos
INSERT INTO Tipo (idTipo, tipo) VALUES (001, "Integrado");
INSERT INTO Tipo (idTipo, tipo) VALUES (002, "Concomitante");
INSERT INTO Tipo (idTipo, tipo) VALUES (003, "Subsequente");
#TesteTipo
SELECT * FROM Tipo;

#Turno
INSERT INTO Turno (idTurno, turno) VALUES (001, "Matutino");
INSERT INTO Turno (idTurno, turno) VALUES (002, "Vespertino");
INSERT INTO Turno (idTurno, turno) VALUES (003, "Noturno");
#TesteTurno
SELECT * FROM Turno;

#Cursos
INSERT INTO Curso (idCurso, idTipo, idTurno, nome, descricao) VALUES (205, 001, 002, "Informática", "Curso direcionado ao ensino básico de programação de computadores.");
INSERT INTO Curso (idCurso, idTipo, idTurno, nome, descricao) VALUES (215, 003, 002, "Mecânica", "Curso direcionado ao ensino báscio de mecânica.");
INSERT INTO Curso (idCurso, idTipo, idTurno, nome, descricao) VALUES (255, 002, 003, "Eletrônica", "Curso direcionado ao ensino báscio de Eletrônica.");
#TestesCurso
SELECT * FROM Curso;
SELECT idCurso as 'ID do Curso', nome as 'Nome do Curso', tipo as 'Tipo', turno as 'Turno', descricao as 'Descrição' FROM Curso=c, Tipo=t, Turno=tu WHERE c.idTipo=t.idTipo AND c.idTurno=tu.idTurno;
UPDATE Curso SET nome = 'Eletrônica' WHERE idCurso = 255;

#Disciplina
INSERT INTO Disciplina (idDisciplina, idCurso, carga_horaria, nome, descricao) VALUES (025, 205, 80, "Programação Orientada a Objetos", "Disciplina que introduz o conceito da programação orientada a objetos.");
INSERT INTO Disciplina (idDisciplina, idCurso, carga_horaria, nome, descricao) VALUES (035, 215, 60, "Física", "Disciplina que introduz conceitos importantes de física para o curso de mecânica.");
INSERT INTO Disciplina (idDisciplina, idCurso, carga_horaria, nome, descricao) VALUES (095, 255, 120, "Análise de Circuitos", "Disciplina que introduz conceitos importantes sobre a análise de circuitos.");
#TestesDisciplina
SELECT * FROM Disciplina;
SELECT idDisciplina as 'ID da Disciplina', d.nome as 'Nome', c.nome as 'Curso a que pertence', carga_horaria as 'Carga Horária', d.descricao as 'Descrição' FROM Disciplina=d, Curso=c WHERE d.idCurso=c.idCurso;