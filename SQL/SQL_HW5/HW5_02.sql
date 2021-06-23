USE LendingManage
CREATE TABLE Lenders(
	LenderId int Primary Key,
	LenderName VARCHAR(50),
	AmountAvailable int
)

CREATE TABLE Borrowers(
	BorrowerId int Primary Key,
	BorrowerName VARCHAR(50),
	RiskValue int
)

CREATE TABLE Loan(
	LoanCode int Primary Key,
	TotalAmount int,
	RefundDeadline DATETIME,
	InterstRate FLOAT,
	Purpose VARCHAR(50),
	LenderId int,
	FOREIGN KEY (LenderId) REFERENCES Lenders(LenderId),
	BorrorwerId int,
	FOREIGN KEY (BorrorwerId) REFERENCES Borrowers(BorrowerId)
)
