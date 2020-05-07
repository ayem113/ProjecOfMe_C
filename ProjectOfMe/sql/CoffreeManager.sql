CREATE DATABASE CoffreeManager1
GO

USE CoffreeManager1
GO

CREATE TABLE Account(
	Id INT PRIMARY KEY IDENTITY (1,1),
	UserName VARCHAR(30) NOT NULL UNIQUE,
	Passwords VARCHAR(300) NOT NULL,
	DisplayName NVARCHAR(50) ,
	Email VARCHAR(50) NOT NULL UNIQUE,
	Img NVARCHAR(200)
)
GO

CREATE TABLE Tabless(
	Id INT PRIMARY KEY IDENTITY (1,1),
	Name NVARCHAR(20) NOT NULL UNIQUE,
	Statuss VARCHAR(1) NOT NULL DEFAULT 0 --0 là trống, 1 là có người 
)
GO

CREATE TABLE Menu(
	Id INT PRIMARY KEY IDENTITY (1,1),
	Name NVARCHAR(20) NOT NULL UNIQUE,
)
GO



CREATE TABLE  Food(
	Id INT PRIMARY KEY IDENTITY (1,1),
	Name NVARCHAR(100) NOT NULL UNIQUE,
	Price FLOAT NOT NULL,
	Img  NVARCHAR(200),
	IdMenu INT FOREIGN KEY REFERENCES dbo.Menu(Id) NOT NULL
)
GO

CREATE TABLE Bill(
	Id INT PRIMARY KEY IDENTITY (1,1),
	DateCheckin DATETIME NOT NULL DEFAULT GETDATE(),
	DateCheckout DATETIME,
	Disscount TINYINT DEFAULT 0, 
	Stt VARCHAR(1) NOT NULL DEFAULT 0, --0 chưa thanh toán , 1 là đã thanh toán
	IDTable INT FOREIGN KEY REFERENCES dbo.Tabless(Id) NOT NULL,
)
GO

CREATE TABLE BillDetal(
	Id INT PRIMARY KEY IDENTITY (1,1),
	CountFood TINYINT NOT NULL, -- số lượng món ăn
	IDBill  INT FOREIGN KEY REFERENCES dbo.Bill(Id) NOT NULL,
	IDFood INT FOREIGN KEY REFERENCES dbo.Food(Id) NOT NULL,
	--DateCreate DATETIME NOT NULL DEFAULT GETDATE(),
)
GO
ALTER TABLE dbo.BillDetal ALTER COLUMN CountFood INT


DROP TABLE dbo.Account
DROP TABLE dbo.Bill
DROP TABLE dbo.BillDetal
DROP TABLE dbo.Food
DROP TABLE dbo.Menu
DROP TABLE dbo.Tabless


--reset IDENTITY 
DBCC CHECKIDENT ('dbo.Account', RESEED, 0)
DBCC CHECKIDENT ('dbo.Menu', RESEED, 0)
DBCC CHECKIDENT ('dbo.Food', RESEED, 0)
DBCC CHECKIDENT ('dbo.Tabless', RESEED, 0)
DBCC CHECKIDENT ('dbo.Bill', RESEED, 0)
DBCC CHECKIDENT ('dbo.BillDetal', RESEED, 0)


--DELETE
DELETE dbo.Account
DELETE dbo.Menu
DELETE dbo.Food
DELETE dbo.Tabless
DELETE dbo.Bill
DELETE dbo.BillDetal

--SELECT
SELECT * FROM dbo.Account
SELECT * FROM dbo.Menu
SELECT * FROM dbo.Food
SELECT * FROM dbo.Tabless
SELECT * FROM dbo.Bill
SELECT * FROM dbo.BillDetal

--INSERT
INSERT INTO dbo.Account( UserName ,Passwords ,DisplayName ,Email ,Img)
VALUES  ( 'admin','admin',N'admin','admin@gmail.com' ,N''),( 'duy','ducduy',N'duy còi','duy123@gmail.com' ,N''),
		( 'vohuyhieu','huyhieu',N'hiếu','vohuyhieu.qb@gmail.com' ,N''),( 'nhat','trongnhat',N'nhất','nhat23@gmail.com' ,N'')

INSERT INTO dbo.Menu( Name )
VALUES  ( N'CÀ PHÊ' ),( N'TRÀ SỮA' ),( N'NƯỚC ÉP' ),( N'SINH TỐ' ),( N'NƯỚC NGỌT' ),( N'ĐỒ ĂN VẶT' )

INSERT INTO dbo.Food( Name, Price, Img, IdMenu )
VALUES  (N'ĐEN', 20, N'', 1),(N'VIỆT QUẤT', 10, N'', 2),(N'CAM', 20, N'', 3),(N'BƠ', 20, N'', 4),(N'BÒ HÚC', 10, N'', 5),(N'PIZZA', 10, N'', 6),
		(N'NÂU', 20, N'', 1),(N'SÔ ĐA', 20, N'', 2),(N'XOÀI', 20, N'', 3),(N'DÂU', 20, N'', 4),(N'NƯỚC KHOÁNG', 8, N'', 5),(N'GÀ RÁN', 10, N'', 6),
		(N'BẠC XỈU', 25, N'', 1),(N'CACAO', 25, N'', 2),(N'DƯA HẤU', 20, N'', 3),(N'CHUỐI XOÀI', 20, N'', 4),(N'STING', 10, N'', 5),(N'LẠM SƯÒN', 10, N'', 6),
		(N'ĐÁ SAY', 25, N'', 1),(N'BẠC HÀ', 15, N'', 2),(N'CHANH LEO', 25, N'', 3),(N'SẦU RIÊNG', 20, N'', 4),(N'KHÔNG ĐỘ', 10, N'', 5),(N'KHOAI TÂY CHIÊN', 10, N'', 6)


DECLARE @i INT =0
WHILE @I < 10
BEGIN
	INSERT INTO dbo.Tabless( Name )VALUES  ( N'BÀN '+CAST(@I AS NVARCHAR(20)))
	SET @i=@i+1
END
DECLARE @j INT =10
WHILE @j < 30
BEGIN
	INSERT INTO dbo.Tabless( Name )VALUES  ( N'BÀN '+CAST(@j AS NVARCHAR(20)))
	SET @j=@j+1
END


INSERT INTO dbo.Bill( DateCheckin ,DateCheckout ,Disscount ,Stt ,IDTable)
VALUES  (GETDATE() ,null, 15 ,'0' ,1 ),(GETDATE() , NULL , 25 ,'0' ,2 ),(GETDATE() , GETDATE() , 15 ,'1' ,1 ),(GETDATE() , NULL , 15 ,'0' ,3 )


INSERT INTO dbo.BillDetal(CountFood, IDBill, IDFood )
VALUES  ( 2,1,1),( 3,1,3),( 4,2,5),( 1,2,3)




CREATE PROC inserBilll  @DateCheckin  