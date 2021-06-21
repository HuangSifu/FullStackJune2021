--1
SELECT City
FROM dbo.Employees
WHERE City IN
(SELECT City
FROM dbo.Customers)

--2
--a
SELECT City
FROM dbo.Customers
WHERE City NOT IN
(SELECT City
FROM dbo.Employees)

--b
SELECT c.City
FROM dbo.Customers c
EXCEPT
SELECT e.City
FROM dbo.Employees e

--3
SELECT p.ProductName, SUM(od.Quantity) AS TotalOrders
FROM Products p
INNER JOIN [Order Details] od
ON p.ProductID = od.ProductID
GROUP BY p.ProductName

--4
SELECT c.City, COUNT(od.Quantity) AS TotalOrders
FROM Customers c LEFT JOIN Orders o ON c.CustomerID = o.CustomerID
RIGHT JOIN [Order Details] od ON o.OrderID = od.OrderID
GROUP BY c.City
ORDER BY COUNT(od.Quantity) desc

--5
--a
SELECT c.City, COUNT(c.CustomerID) AS NumCus FROM Customers c
GROUP BY c.City
HAVING COUNT(c.CustomerID) >= 2
UNION
SELECT s.City, COUNT(s.CustomerID) AS NumCus FROM Customers s
GROUP BY s.City
HAVING COUNT(s.CustomerID) >= 2;

--b
SELECT DISTINCT City FROM Customers WHERE City NOT IN 
(SELECT City FROM Customers 
GROUP BY City
HAVING COUNT(CustomerID) <2 )
ORDER BY City;

--6
SELECT City
FROM dbo.Customers
GROUP BY (City)
HAVING COUNT(CustomerID) >=2

--7
SELECT CustomerID
FROM dbo.Customers
WHERE City 
NOT IN (SELECT ShipCity
FROM dbo.Orders)

--8
SELECT TOP 5 p.ProductName, AVG(od.unitPrice) AS AvgPrice, SUM(od.Quantity) AS TotalQuantity, c.City
FROM Customers c FULL JOIN Orders o ON c.CustomerID = o.CustomerID
FULL JOIN [Order Details] od ON o.OrderID = od.OrderID
FULL JOIN Products p ON od.ProductID = p.ProductID
GROUP BY p.ProductName, c.City
ORDER BY TotalQuantity desc

--9
--a
SELECT City
FROM dbo.Employees
WHERE City NOT IN
(SELECT City
FROM dbo.Customers)

--b
SELECT e.City
FROM dbo.Employees e
EXCEPT
SELECT c.City
FROM dbo.Customers c

--10
SELECT DISTINCT e.City
FROM Employees e FULL JOIN Orders o ON e.EmployeeID = o.EmployeeID 
WHERE e.City IN 
(SELECT o.ShipCity
FROM Orders r FULL JOIN [Order Details] od ON r.OrderID = od.OrderID 
WHERE o.shipCity IN 
(SELECT TOP 1 shipCity FROM [Order Details] 
))

--11
--SELECT * FROM TABLE
--GROUP BY id

--12
SELECT EmployeeID FROM dbo.Employees
WHERE ReportsTo IS NULL

--13

--14

