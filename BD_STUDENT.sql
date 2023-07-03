CREATE DATABASE Student
GO
USE Student
GO

create table Student(
	    idStudent 		char(36) 		not null,
		profileImg		varchar(150)    not null,
        dni 			char(8)			not null,
        name 			varchar(80) 	not null,
        lastName	 	varchar(100) 	not null,
        condition	bit 			not null,
        school	 		varchar(100) 	not null,
        faculty	 		varchar(100) 	not null,
        disability	 	bit 			not null,
		phone	 	char(9) 		null,
        address	 		varchar(150) 	not null,
        sex	 			char(1) 		null,
        studentState	bit 			null, 
        password		varchar(max) 	null,
        mail	 		varchar(60) 	null,
        code	 		char(6) not 	null,
		PRIMARY KEY (idStudent)
)
go

INSERT INTO Student (idStudent,profileImg, dni, name, lastName, condition, school, faculty, disability, phone, address, sex, studentState, password, mail, code)
VALUES ('b454687f-048d-4c02-8255-885b52c33635','https://e0.pxfuel.com/wallpapers/442/989/desktop-wallpaper-perfil-boy-face-thumbnail.jpg', '12345678', 'Jhair', 'Arone Angeles', 1, 'Ingenieria Sistemas y Sistemas', 'Ingenieria', 0, '987654321', 'tamburco', 'M', 1, 'password123', '201054@unamba.edu.pe', '201054');

