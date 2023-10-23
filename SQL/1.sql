--create database Kurs1

use Kurs1

create table PaymentTypes(
Type varchar(15) primary key
)

create table Categories(
Categ varchar(30) primary key
)

create table Suppliers(
Supplier varchar(30) primary key,
FIO varchar(30),
PhoneNum varchar(15),
Email varchar(50))

create table Materials(
Material varchar(30) primary key,
Supplier varchar(30) references Suppliers(Supplier),
TextureImage varchar(50),
Amount int)

create table Postavki(
PostavkaId int primary key identity(1, 1),
Material varchar(30) references Materials(Material),
Amount int,
PostavkaDate date default GETDATE(),
PerUnit float
)

create table Tovars(
TovarId int primary key identity(1, 1),
TovarName varchar(60),
Categ varchar(30) references Categories(Categ),
Price float,
DaysToProduce int,
pathToPicture varchar(30)
)

create table TovarsContent(
TovarId int references Tovars(TovarId) ON DELETE CASCADE,
Material varchar(30) references Materials(Material),
Amount int,
Purpose varchar(10),
primary key(TovarId, Material))

create table UsersList(
UserId int primary key identity(1, 1),
FIO varchar(30),
Login varchar(30) unique,
Password varchar(30),
Balance float)

create table Zakaz(
ZakazId int primary key,
UserId int references UsersList(UserId),
Summa float,
OrderDate date,
PayType varchar(15) references PaymentTypes(Type)
)

create table Staff(
StaffId int primary key identity(1, 1),
FIO varchar(30),
Bday date,
Phone varchar(15),
HireDate date
)

create table ZakazContent(
ZakazId int references Zakaz(ZakazId),
TovarId int references Tovars(TovarId),
Amount int,
StaffId int references Staff(StaffId),
SumOfZakaz float,
primary key(ZakazId, TovarId))

create table StaffSkills(
StaffId int references Staff(StaffId),
Categ varchar(30) references Categories(Categ),
primary key(StaffId, Categ)
)

drop table ZakazContent
drop table StaffSkills
drop table Staff
drop table Zakaz
drop table UsersList
drop table TovarsContent
drop table Tovars
drop table Postavki
drop table Materials
drop table Suppliers
drop table Categories
drop table PaymentTypes
drop PROC createZakaz
drop TRIGGER NewZakazContent
drop TRIGGER NewPostavka
drop FUNCTION newZakazId
drop proc UpdateLoginAndData

CREATE VIEW StaffAndSkills as 
SELECT S.FIO, SS.Categ from Staff S join StaffSkills SS on S.StaffId = SS.StaffId 

CREATE VIEW MaterialsAndSuppliersInfo as 
Select Material from Materials M join Suppliers S on M.Supplier = S.Supplier

CREATE VIEW ClientFIOSAndOrders as 
Select U.FIO from UsersList U join Zakaz Z on U.UserId = Z.UserId
