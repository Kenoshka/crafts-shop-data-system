use Kurs1

insert PaymentTypes values ('Card'), ('Cash'), ('Balance')

insert Categories values ('Wooden crafts'),
('Metal crafts'),
('Paper crafts'),
('Papier mache crafts'),
('Clay crafts')

insert Suppliers values ('IP Lesorubovo', 'Sidorovich Ivan Prohorovich', '8 928 829 11 11', 'leslesov@outlook.com'),
('OOO StroiKopai', 'Erogin Eugine Eduardovich', '+7901 555 10 20', 'stroikopai@gmail.com'),
('IP Bumajnaya Massa', 'Antonov Anton Maksimovich', '89110981234', 'paperbusiness@mail.ru')

insert Materials values ('Steel', 'OOO StroiKopai', null, 0),
('Copper', 'OOO StroiKopai', null, 0),
('Oak wood', 'IP Lesorubovo', null, 0),
('Red wood', 'IP Lesorubovo', null, 0),
('Clay', 'OOO StroiKopai', null, 0),
('White paper', 'IP Bumajnaya Massa', null, 0),
('Papier mache', 'IP Bumajnaya Massa', null, 0)

CREATE TRIGGER NewPostavka
ON Postavki
AFTER INSERT
AS
UPDATE Materials
SET Amount = Amount + (select Amount from inserted)
WHERE Material = (SELECT Material FROM inserted)

insert Postavki (Material, Amount, PostavkaDate, PerUnit) values ('Steel', 50, GETDATE(), 2);
insert Postavki (Material, Amount, PostavkaDate, PerUnit) values ('Copper', 50, GETDATE(), 2);
insert Postavki (Material, Amount, PostavkaDate, PerUnit) values ('Oak wood', 50, GETDATE(), 2);
insert Postavki (Material, Amount, PostavkaDate, PerUnit) values ('Red wood', 50, GETDATE(),2);
insert Postavki (Material, Amount, PostavkaDate, PerUnit) values ('Clay', 50, GETDATE(),2);
insert Postavki (Material, Amount, PostavkaDate, PerUnit) values ('White paper', 50,GETDATE(), 2);
insert Postavki (Material, Amount, PostavkaDate, PerUnit) values ('Papier mache', 50, GETDATE(), 2);

insert Tovars values ('Paper decorative fan', 'Paper crafts', 300, 1, 'veer.jpg'),
('Gift chess set', 'Wooden crafts', 2300, 5, 'shahmati.jpg'),
('Clay pot', 'Clay crafts', 300, 1, 'gorshok.jpg'),
('Clay vase', 'Clay crafts', 450, 2, 'vaza.jpg'),
('Copper statuette', 'Metal crafts', 500, 3, 'med_stat.jpg'),
('Steel statuette', 'Metal crafts', 510, 3, 'stal_stat.jpg')

insert TovarsContent values	(1, 'White paper', 2, null),
(2, 'Oak wood', 5, null),
(2, 'Red wood', 4, null)

insert UsersList values ('Borisov Eduard Victorovich', 'Borei123', 'password123', 1000),
('Rinatov Igor Andreevich', 'IIIGO4', 'password123', 2500),
('Zenitov Valerie Alexandrovich', 'ZenitCool', 'password123', 3600),
('Ananasov Vladimir Georgievich', 'Customer14', 'password123', 5000),
('Yan Easevich', 'easy', 'easy', 10000)

insert Staff values ('Benediktov Mark Prohorovich', '12-30-1985', '8 911 816 50 64', '09-03-2018'),
('Burunov Timofey Radionovich', '03-10-1990', '8 911 456 12 21', '12-01-2015'),
('Voronina Irina Olegovna', '03-10-1999', '8 911 909 80 70', '11-05-2022')

insert StaffSkills values (6, 'Wooden crafts'),
(7, 'Metal crafts'),
(7, 'Clay crafts'),
(7, 'Papier mache crafts'),
(7, 'Paper crafts')

CREATE TRIGGER NewZakazContent
ON ZakazContent
AFTER INSERT
AS
UPDATE Zakaz
SET Summa = Summa + (select SumOfZakaz from inserted)
WHERE ZakazId = (SELECT ZakazId FROM inserted)

insert Zakaz (ZakazId, UserId, Summa, OrderDate, PayType) values (0, null, 0, GETDATE(), null)

CREATE PROC createZakaz
@Id int,
@user int,
@sum float,
@payType varchar(15)
as insert Zakaz values (@Id, @user, 0, GETDATE(), @payType)

CREATE FUNCTION newZakazId()
    RETURNS int
    BEGIN
        DECLARE @id int
        select @id = max(ZakazId) + 1 from Zakaz
        RETURN @id
    END;

create proc UpdateLoginAndData
@id int,
@login varchar(30),
@pass varchar(30)
as 
update UsersList set Login = @login where UserId = @id
update UsersList set Password = @pass where UserId = @id;

create function sumAllZakazes()
    RETURNS float
    BEGIN
        DECLARE @sum float
        select @sum = sum(Summa) from Zakaz
        RETURN @sum
    END;
