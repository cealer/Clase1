create database dbUAP
go

use dbUAP
go

create table Estudiante(
idEstudiante int primary key identity(1,1),
nombres varchar(100),
apellidos varchar(100),
email varchar(100),
dni varchar(8),
fecha datetime
)

insert into Estudiante values ('Taylor','Otwell','taylorotwell@hotmail.com','12345678','08-11-1994')
insert into Estudiante values ('Nikola','Tesla','nikolatesla@hotmail.com','12345678','08-01-1995')
insert into Estudiante values ('Sergey','Brin','sergeybrin@gmail.com','12345678','08-04-1990')

select * from Estudiante