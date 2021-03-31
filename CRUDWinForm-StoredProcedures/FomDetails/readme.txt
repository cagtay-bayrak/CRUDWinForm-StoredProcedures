create db CRUD_SP_DB;

create table Employee
(
ID int primary key identity(1,1),
Name nvarchar(50),
Fname nvarchar(50),
Design nvarchar(50),
eMail nvarchar(50),
Emp_ID nvarchar(50),
Gender nvarchar(50),
Address nvarchar(50),
)


USE [CRUD_SP_DB]
GO

INSERT INTO [dbo].[Employee]
           ([Name]
           ,[Fname]
           ,[Design]
           ,[eMail]
           ,[Emp_ID]
           ,[Gender]
           ,[Address])
     VALUES
           ('Cagtay',
            'Bayrak',
            'Test',
         'bayrak.cagtay@gmail.com',
          '28',
         'Male',
		 'bayrampaşa')
 



