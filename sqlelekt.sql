--use master
create database esdnevnik
use esdnevnik

--drop table ocena
--drop table raspodela
--drop table upisnica
--drop table predmet
--drop table odeljenje
--drop table osoba
--drop table smer
--drop table skolska_godina

create table Smer(
id INT IDENTITY(1,1) PRIMARY KEY,
naziv NVARCHAR(60)
)

create table Skolska_godina(
id INT IDENTITY(1,1) PRIMARY KEY,
naziv NVARCHAR(15)
)

create table Predmet(
id INT IDENTITY(1,1) PRIMARY KEY,
naziv NVARCHAR(20),
razred INT
)
create table Osoba(
id INT IDENTITY(1,1) PRIMARY KEY,
ime NVARCHAR(20),
prezime NVARCHAR(30),
adresa NVARCHAR(30),
jmbg VARCHAR(15),
email VARCHAR(30),
pass VARCHAR(20),
uloga INT
)

create table Odeljenje(
id INT IDENTITY(1,1) PRIMARY KEY,
razred INT,
indeks VARCHAR(10),
smer_id INT FOREIGN KEY REFERENCES Smer(id),
razredni_id INT FOREIGN KEY REFERENCES osoba(id),
godina_id INT FOREIGN KEY REFERENCES Skolska_godina(id)
)

create table Upisnica(
id INT IDENTITY(1,1) PRIMARY KEY,
osoba_id INT FOREIGN KEY REFERENCES Osoba(id),
odeljenje_id INT FOREIGN KEY REFERENCES Odeljenje(id)
)

create table Raspodela(
id INT IDENTITY(1,1) PRIMARY KEY,
nastavnik_id INT FOREIGN KEY REFERENCES osoba(id),
godina_id INT FOREIGN KEY REFERENCES Skolska_godina(id),
predmet_id INT FOREIGN KEY REFERENCES Predmet(id),
odeljenje_id INT FOREIGN KEY REFERENCES Odeljenje(id)
)

create table Ocena(
id INT IDENTITY(1,1) PRIMARY KEY,
datum DATE default GETDATE(),
raspodela_id INT FOREIGN KEY REFERENCES Raspodela(id),
ocena INT,
ucenik_id INT FOREIGN KEY REFERENCES osoba(id)
)

insert into Smer
values('Prirodni')
insert into Smer
values('Drustveni')
insert into Smer
values('Informaticki') --3 (OVAJ)

insert into Skolska_godina
values('2019/20'); --1
insert into Skolska_godina
values('2020/21'); --2 
insert into Skolska_godina
values('2021/22'); --3
insert into Skolska_godina
values('2022/23'); --4 (OVA)

insert into Predmet
values('Baze podataka 2', 4),
('Programiranje', 3), 
('Srpski jezik', 3),
('Srpski jezik', 4),
('Matematika',4),
('Programske paradigme',4), 
('Engleski jezik',4),
('Fizika',4)
--2 i 3 su predmeti iz treceg razreda (godina 2021/22)

insert into Osoba
values('Jovan','Djordjevic','Adr1','0101004123456','jovan@gmail.com','011234',1),
      ('Dusan','Zagorac','Adr2', '0201004123456','dusan@sbb.net','021234',1),
	  ('Lazar','Marinkovic','Adr3', '0301004123456','lazar@sbb.net','031234',1),
	  ('Pavle','Kovacevic','Adr4', '0401004123456','pavle@sbb.net','041234',1),
      ('Zarko','Bacovic','Adr5', '0501004123456','zarko@sbb.net','051234',1),
	  ('Stefan','Musikic','Adr6', '0601004123456','stefan@sbb.net','061234',1),
	  ('Nikola','Kotarenov','Adr7', '0701004123456','nikola@sbb.net','071234',1),
	  ('Petar','Vilotijevic','Adr8', '0801004123456','petar@sbb.net','081234',1),
	  ('Aleksandar','Kamaljevic','Adr9', '0901004123456','aca@sbb.net','091234',1),
	  ('David','Ulnikovic','Adr10', '1001004123456','david@sbb.net','101234',1),
	  ('David','Milenkovic','Adr11', '1101004123456','david1@sbb.net','111234',1),
	  ('Stojna','Pusicic','Adr12', '1201004123456','stojna@sbb.net','121234',1),
	  ('Ivona','Stevanovic','Adr13', '1301004123456','ivona@sbb.net','131234',1),	  
	  ('Uros','Milicevic','Adr14', '1401004123456','uros@sbb.net','141234',1),	
	  ('Vuk','Srdanovic','Adr15', '1501004123456','vuk@sbb.net','151234',1),		  
	  ('Matija','Novovic','Adr16', '1601004123456','matija@sbb.net','161234',1),		  
	  ('Nemanja','Lukic','Adr17', '1701004123456','matija@sbb.net','171234',1),		  
	  ('Filip','Lucic','Adr18', '1801004123456','matija@sbb.net','181234',1),		  	  	  	  	  
	  
	  ('Dragana','Stojanovic','Adr19', '0101000123456','dragana@sbb.net','191234',2),
      ('Branko','Vrhovac','Adr20', '0201000123456','branko@sbb.net','201234',2),
      ('Natasa','Majstrovic','Adr21', '0301000123456','natasa@sbb.net','211234',2),
      ('Nevena','Vasilic-Lukic','Adr22', '0401000123456','nevena@sbb.net','221234',2),
      ('Marina','Jovicic-Samardzija','Adr23', '0501000123456','marina@sbb.net','231234',2),
      ('Cedo','Skoric','Adr24', '0601000123456','cedo@sbb.net','241234',2)            
      
insert into Odeljenje
values(4,'10',3,19,4),(4,'9',3,24,4),(3,'10',3,19,3),(3,'9',3,24,3)

insert into Upisnica
values (1,1),(2,1),(3,1),(4,1),(5,1),(6,1),(7,1),(8,1),(9,1),(10,1),(11,1),(12,1),(13,1),(14,1),(15,1),(16,1),(17,1),(18,1),
       (1,3),(2,3),(3,3),(4,3),(5,3),(6,3),(7,3),(8,3),(9,3),(10,3),(11,3),(12,3),(13,3),(14,3),(15,3),(16,3),(17,3),(18,3)




insert into Raspodela values
(19,4,4,1), --D.Stojanovic, Srpski, 4.razred
(19,3,3,3), --D.Stojanovic, Srpski, 3.razred
(20,4,1,1), --B.Vrhovac, Baze, 4.razred
(20,3,2,3), --B.Vrhovac, Programiranje, 4.razred
(21,4,6,1), --N.Majstrovic, Paradigme, 4.razred
(22,4,5,1), --N.Vasilic-Lukic, Matematika, 4.razred 
(23,4,7,1), --M.Jovicic-Samardzija, Engleski, 4.razred 
(24,4,8,1)  --C.Skoric, Fizika, 4.razred 

--provera
select osoba.ime + ' ' + Osoba.prezime as Nastavnik, Skolska_godina.naziv as Godina, Predmet.naziv as Predmet, STR(Odeljenje.razred) + '/' +  Odeljenje.indeks as Odeljenje from
Raspodela left join Osoba on Raspodela.nastavnik_id = Osoba.id
left join Skolska_godina on Raspodela.godina_id = Skolska_godina.id
left join Predmet on Raspodela.predmet_id = Predmet.id
left join Odeljenje on Raspodela.odeljenje_id = Odeljenje.id
--kraj provere

insert into Ocena(raspodela_id,ocena,ucenik_id) values
(1,3,2),
(1,4,3),
(1,5,4),
(1,5,5),
(1,4,6),
(1,5,7),
(3,2,2),
(3,4,3),
(3,5,4),
(3,2,5),
(3,4,6),
(3,5,7),
(5,3,2),
(5,4,3),
(5,5,4),
(5,5,5),
(5,4,6),
(5,5,7)