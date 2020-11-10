USE Escuela;

Create table Alumno 
(
ID_Alumno	int primary key identity not null,
Nombre		varchar(50),
Apellido	varchar(50),
)


Create table Materias 
(
ID_Materia	int primary key,
Nombre_Materia varchar(25)
);

Create table Calificaciones_Alumnos
(
ID int primary key identity not null,
ID_Alumno int,
ID_Materia int,
Calificacion float
);



/*se insertan los datos para los 17 estudiantes del grupo ej:

tabla alumno:
INSERT INTO Alumno (Nombre,Apellido) VALUES ('Luis','Bernal');
INSERT INTO Alumno (Nombre,Apellido) VALUES ('Juan','Perez');
INSERT INTO Alumno (Nombre,Apellido) VALUES ('Quirino','Ordaz');
INSERT INTO Alumno (Nombre,Apellido) VALUES ('Carlos','Slim');
INSERT INTO Alumno (Nombre,Apellido) VALUES ('Steve','Tyler');

tabla materias:
INSERT INTO Materias(ID_Materia,Nombre_Materia) VALUES (111,'Bases de Datos');
INSERT INTO Materias(ID_Materia,Nombre_Materia) VALUES (222,'Pruebas de Software');
INSERT INTO Materias(ID_Materia,Nombre_Materia) VALUES (333,'POO');
INSERT INTO Materias(ID_Materia,Nombre_Materia) VALUES (444,'Matematicas Discretas');
INSERT INTO Materias(ID_Materia,Nombre_Materia) VALUES (555,'Simulacion');
INSERT INTO Materias(ID_Materia,Nombre_Materia) VALUES (666,'Estadistica');
INSERT INTO Materias(ID_Materia,Nombre_Materia) VALUES (777,'Fisica General');

tabla Calificaciones_Alumnos: (ultimas calificaciones insertadas)
INSERT INTO Calificaciones_Alumnos(ID_Alumno,ID_Materia,Calificacion) VALUES (17,111,9.2);
INSERT INTO Calificaciones_Alumnos(ID_Alumno,ID_Materia,Calificacion) VALUES (17,222,10);
INSERT INTO Calificaciones_Alumnos(ID_Alumno,ID_Materia,Calificacion) VALUES (17,333,10);
INSERT INTO Calificaciones_Alumnos(ID_Alumno,ID_Materia,Calificacion) VALUES (17,444,10);
INSERT INTO Calificaciones_Alumnos(ID_Alumno,ID_Materia,Calificacion) VALUES (17,555,10);
INSERT INTO Calificaciones_Alumnos(ID_Alumno,ID_Materia,Calificacion) VALUES (17,666,10);
INSERT INTO Calificaciones_Alumnos(ID_Alumno,ID_Materia,Calificacion) VALUES (17,777,10);

*/


--una vez insertados todos los datos correspondientes se realiza la consulta:


select top 10 a.Nombre, a.Apellido, avg(c.Calificacion) as promedio
from Alumno a inner join Calificaciones_Alumnos c
on a.ID_Alumno = c.ID_Alumno
group by a.Nombre, a.Apellido
order by promedio desc