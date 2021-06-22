--1
--a
--select * from Region
INSERT INTO Region VALUES(5,'Middle Earth')
--b
INSERT INTO Territories VALUES(00005, 'Gondor', 5)
--c
--select * from Territories
INSERT INTO Employees(LastName, FirstName) VALUES('Aragorn', 'King')
INSERT INTO EmployeeTerritories VALUES(10, 00005)
--2
UPDATE Territories
SET TerritoryDescription = 'Arnor'
WHERE TerritoryDescription = 'Gondor'

--3
--select * from Territories
DELETE FROM EmployeeTerritories
WHERE TerritoryID = '5'
DELETE FROM Territories
WHERE TerritoryDescription = 'Arnor'
DELETE FROM Region
WHERE RegionDescription = 'Middle Earth'
GO

--4
CREATE VIEW view_product_order_Huang 
AS
SELECT p.ProductID, SUM(od.Quantity) Qty
FROM Products p
INNER JOIN [Order Details] od
ON p.ProductID = od.ProductID
GROUP BY p.ProductID;
GO

--5
CREATE PROCEDURE sp_product_order_quantity_Huang (
	@ProductID INT,  
    @TotalQuantity INT OUTPUT
) AS 
BEGIN 
	SELECT * FROM Products;
END;
GO

--6
CREATE PROCEDURE sp_product_order_city_Huang
	@ProductName VARCHAR(40),
	@Top5City VARCHAR(15) OUTPUT,
	@TotalQuantity INT OUTPUT
AS
BEGIN
	SELECT TOP 5 @Top5City = o.ShipCity, @TotalQuantity = COUNT(od.Quantity)
	FROM Products p FULL JOIN [Order Details] od ON p.ProductID = od.ProductID
	FULL JOIN Orders o ON od.OrderID = o.OrderID 
	WHERE p.ProductName = @ProductName
	GROUP BY o.ShipCity
	ORDER BY COUNT(od.Quantity)
END
GO

--7
CREATE PROCEDURE sp_move_employees_Huang
	@TotalEmployee INT,
	@EmployeeID INT
AS
BEGIN 
	SELECT @EmployeeID = e.EmployeeID, @TotalEmployee = COUNT(e.EmployeeID)
	FROM Employees e INNER JOIN EmployeeTerritories et ON e.EmployeeID = et.EmployeeID
	INNER JOIN Territories t ON t.TerritoryID = et.TerritoryID
	WHERE t.TerritoryDescription = 'Tory'
	GROUP BY e.EmployeeID

	IF(@TotalEmployee > 0)
	BEGIN
		INSERT INTO Territories VALUES ('22222', 'Stevens Point', 3)
		UPDATE EmployeeTerritories SET TerritoryID = '22222' WHERE EmployeeID = @EmployeeID
	END
END
GO

--8
CREATE TRIGGER moveBackT ON Territories
FOR UPDATE 
AS
	BEGIN
	IF((SELECT COUNT(t.EmployeeID) FROM EmployeeTerritories t)>100)
		BEGIN
		UPDATE 
		EmployeeTerritories  SET TerritoryID = '33333' WHERE TerritoryID = '22222';
	END
END
GO

--9
CREATE TABLE people_Huang (Id INT, City VARCHAR(50))
CREATE TABLE city_Huang (Id INT, Name VARCHAR(50), City INT)
GO
INSERT INTO people_Huang VALUES (1, 'Seattle'), (2, 'Green Bay')
INSERT INTO city_Huang VALUES (1, 'Aaron Rodgers', 1), (2, 'Russell Wilson', 1), (3, 'Jody Nelson', 2)
GO
UPDATE people_Huang SET City = 'Madison' WHERE City = 'Seattle'
GO

CREATE VIEW Packers_Huang
AS
SELECT c.Name
FROM city_Huang c
INNER JOIN people_Huang p
ON c.City = p.Id
WHERE p.City = 'Green Bay'
GO
--SELECT * FROM Packers_Huang;
DROP TABLE people_Huang;
DROP TABLE city_Huang;
DROP VIEW Packers_Huang;

GO

--10
CREATE PROCEDURE sp_birthday_employees_Huang
AS 
BEGIN 
	CREATE TABLE birthday_employees_Huang (LastName VARCHAR(50), FirstName  VARCHAR(50))
	INSERT INTO birthday_employees_Huang (LastName, FirstName)
	SELECT LastName, FirstName
	FROM Employees 
	WHERE  MONTH(BirthDate) = 2
END
GO

--11
CREATE PROCEDURE sp_Huang_1
AS
	SELECT c.City
	FROM Customers c INNER JOIN Orders o ON c.CustomerID = o.CustomerID
	INNER JOIN [Order Details] od ON o.OrderID = od.OrderID
	GROUP BY c.City
	HAVING COUNT(c.ContactName) >= 2 AND COUNT(od.Quantity)<=1
GO

CREATE PROCEDURE sp_Huang_2
AS
	SELECT City FROM Customers WHERE CustomerID IN
		(SELECT CustomerID FROM Orders WHERE OrderID IN 
			(SELECT OrderID FROM [Order Details] 
				GROUP BY OrderID HAVING COUNT(Quantity)<=1)
			)GROUP BY CITY HAVING COUNT(ContactName) >=2
GO

--12
--CHECKSUM TABLE original_table, backup_table;
--Or
--SELECT * FROM Table1
--UNION
--SELECT * FROM Table2

--14
--SELECT CONCAT(First_Name, Last_Nmae, Middle_Name + '.')

--15
--SELECT Student, 
--		Marks, 
--		DENSE_RANK() OVER (ORDER BY Marks DESC) Rank 
--FROM table_name
--WHERE Sex = "F"
--ORDER BY Rank;

--16
--SELECT Student, 
--		Marks
--		Sex,
--		DENSE_RANK() OVER (PARTITION BY Sex ORDER BY Marks DESC) Rank
--FROM table_name
--ORDER BY Rank;