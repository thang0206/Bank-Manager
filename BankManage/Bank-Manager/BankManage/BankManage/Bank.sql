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

INSERT INTO Customer(STK, Name, Address, DoB, CitizenID, PhoneNum, Money)
VALUES ('1234567890', 'Nguyen Van A', 'HCM', '1999-5-15','123456789012','0365471254', 250000)

INSERT INTO Customer(STK, Name, Address, DoB, CitizenID, PhoneNum, Money)
VALUES ('1564567890', 'Nguyen Van B', 'HCM', '1999-5-15','156456789012','0365471254', 250000)

CREATE TABLE Trans(
	STK char(10),
	MaGD char(10),
	LoaiGD varchar(255),
	Money int,
	ThoigianGD date,
	ReceivedSTK char(10)
	PRIMARY KEY (STK, MaGD),
	FOREIGN KEY (STK) REFERENCES Customer(STK),
	FOREIGN KEY (ReceivedSTK) REFERENCES Customer(STK),
	)

INSERT INTO Trans(STK, MaGD, LoaiGD, Money, ThoigianGD, ReceivedSTK)
VALUES ('1234567890', '001', 'Chuyen tien', 15000, '2022-5-6','1564567890')