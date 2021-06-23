USE MenuMaintain
CREATE TABLE Category (
	CategoryName		VARCHAR(50) Primary Key,
	ShortDescription		VARCHAR(50),
	EmployeeInCharge	VARCHAR(50) NOT NULL
)
CREATE TABLE Course (
	CourseName		VARCHAR(50),
	ShortDescription	VARCHAR(50),
	Photo			VARCHAR(50),
	Price			MONEY,
	CategoryName	VARCHAR(50),
	FOREIGN KEY (CategoryName) REFERENCES Category(CategoryName)
)
CREATE TABLE Recipe (
	Ingredient		VARCHAR(50),
	RequiredAmount	FLOAT,
	Unit			FLOAT,
	CourseName		VARCHAR(50),
	AmountInStore	FLOAT
)