create database budgetApp
go
use budgetApp
go
create table Expense
(
	ExpenseId UNIQUEIDENTIFIER primary key default NEWID(),
	[Name] nvarchar (50) unique not null,
	[Description] nvarchar (200) not null,
	Amount decimal (19,4) not null,
	[Repeats] int not null default 1,
)
go

create table Income
(
	Income UNIQUEIDENTIFIER primary key default NEWID(),
	[Name] nvarchar (50) unique not null,
	[Description] nvarchar (200) not null,
	Amount decimal (19,4) not null,
	[Repeats] int not null default 1,
);
go

/*test data*/
insert into Expense values (NEWID(), 'Mobile phone', 'mobile phone payments, monthly', 15.0, 12);
insert into Expense values (NEWID(), 'Sport', 'Summer sport payments', 31.0, 26);
insert into Income values (NEWID(), 'Salary', 'Income from my work', 100.0, 12);
insert into Income values (NEWID(), 'Investment', 'Bitcoin investments', 500.0, 1);
go

select * from Expense
go

select * from Income