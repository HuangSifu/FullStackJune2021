--1
SELECT c.iname, SUM(o.order_id)
FROM Customer c INNER JOIN Order o  ON c.cust_id = o.cust_id 
WHERE year(o.order_date) = 2002
GROUP BY c.iname;

CREATE TABLE Customer 
 ( 
	cust_id int Primary Key,
	iname varchar (50) NOT NULL
)

CREATE TABLE [Order] 
(
	order_id int Primary Key,
	cust_id int,
	amount money,
	order_date smalldatetime
)

--2
SELECT id, firstname, lastname
FROM person WHERE lastname LIKE 'A&';

Create table Person 
(
	id int, 
	firstname varchar(100), 
	lastname varchar(100)
) 

--3
Create table Person
(	person_id int primary key, 
	manager_id int null, 
	name varchar(100)not null
)

SELECT p2.name as Manager, count(p1.Person_id) AS NumberOfReportedFrom
FROM Person p1 INNER JOIN Person p2 ON p1.manager_id = p2.person_id;

--4
-- DELETE, UPDATE, CREATE, ALTER, Logon/Logoff, errors

--5
CREATE TABLE Company(
	CompanyId int primary key,
	CompanyName varchar(20) unique,
	DivisionId int foreign key references Divisions(DivisionId),
	PhysicalAddressId int foreign key references PhysicalLocation(PhysicalAddressId)
	)

CREATE TABLE Division(
	DivisionId int primary key,
	DivisionName varchar(20),
    PhysicalAddressId int foreign key references PhysicalLocation(PhysicalAddressId)

)

CREATE TABLE PhysicalLocation(
	PhysicalLocation int primary key,
	PhysicalLocationDescription varchar(50)
)

CREATE TABLE Contact(
	ContactId int primary key,
	Telephone int unique,
	DivisionId int foreign key references Division(DivisionId),
	PhysicalLocationId int foreign key references PhysicalLocation(PhysicalLocationId),
	recordsStatus varchar(10)
)