CREATE DATABASE BankManage

Create Table Customer (
	STK char(10) PRIMARY KEY,
	Name varchar(255) NOT NULL,
	Address varchar(255),
	DoB date,
	CitizenID char(12) NOT NULL,
	PhoneNum char(10) NOT NULL,
	Money int,
	CreateAt date,
	UpdateAt date
)
