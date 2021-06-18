--14
SELECT DISTINCT p.ProductName
FROM Orders o FULL JOIN [Order Details] od
ON o.OrderID =  od.OrderID LEFT JOIN Products p
ON od.ProductID = p.ProductID
WHERE year(o.OrderDate)>year(DATEADD(year, -25, GETDATE()))

--15
SELECT TOP 5 o.ShipPostalCode, SUM(od.Quantity) AS Quantity 
FROM Orders o FULL JOIN [Order Details] od
ON o.OrderID =  od.OrderID
WHERE o.ShipPostalCode IS NOT NULL
GROUP BY o.ShipPostalCode

--16
SELECT TOP 5 o.ShipPostalCode, SUM(od.Quantity) AS Quantity 
FROM Orders o FULL JOIN [Order Details] od
ON o.OrderID =  od.OrderID
WHERE o.ShipPostalCode IS NOT NULL AND 
year(o.OrderDate)>year(DATEADD(year, -20, GETDATE()))
GROUP BY ShipPostalCode

--17
SELECT COUNT(customerID) AS NumOfCustomer,City
FROM Customers
GROUP BY City

--18
SELECT COUNT(customerID) AS NumOfCustomer,City
FROM Customers
GROUP BY City
HAVING COUNT(customerID)>10

--19
SELECT DISTINCT c.CustomerID, c.CompanyName, c.ContactName 
FROM Orders o INNER JOIN Customers c
ON o.CustomerID = c.CustomerID
WHERE o.OrderDate > '1998-1-1'

--20
SELECT c.ContactName, Max(o.Orderdate) AS MostRecent
FROM Customers c JOIN Orders o ON c.CustomerID = o.CustomerID
GROUP BY c.ContactName

--21
SELECT c.ContactName, COUNT(od.Quantity) AS NumOfProduct
FROM Customers c JOIN Orders o ON c.CustomerID = o.CustomerID
JOIN [Order Details] AS od ON o.OrderID = od.OrderID
GROUP BY c.ContactName

--22
SELECT c.ContactName, COUNT(od.Quantity) AS NumOfProduct
FROM Customers c JOIN Orders o ON c.CustomerID = o.CustomerID
JOIN [Order Details] AS od ON o.OrderID = od.OrderID
GROUP BY c.ContactName 
HAVING COUNT(od.Quantity)>100

--23
SELECT DISTINCT s.CompanyName AS [Supplier Company Name], sp.CompanyName AS [Shipping Company Name]
FROM Suppliers s JOIN Products p ON s.SupplierID = p.SupplierID
JOIN [Order Details] od ON p.ProductID = od.ProductID
JOIN Orders o ON od.OrderID = o.OrderID
JOIN Shippers sp ON o.ShipVia = sp.ShipperID

--24
SELECT o.OrderDate, p.ProductName
FROM Orders o
INNER JOIN [Order Details] od
ON o.OrderID = od.OrderID
INNER JOIN Products p
ON od.ProductID = p.ProductID
GROUP BY o.OrderDate, p.ProductName

--25
SELECT e1.LastName, e1.FirstName, e1.Title, e2.LastName, e2.FirstName, e1.Title
FROM Employees e1 INNER JOIN Employees e2 ON e2.Title = e1.Title
WHERE e1.EmployeeID <> e2.EmployeeID 

--26
SELECT a.LastName +' '+ a.FirstName AS Managers
FROM Employees a
INNER JOIN Employees b
ON a.EmployeeID = b.ReportsTo
GROUP BY a.LastName +' '+ a.FirstName
HAVING COUNT(b.ReportsTo) > 2

--27
SELECT City, CompanyName, ContactName, 'Customer' as Type
FROM Customers 
UNION
SELECT City, CompanyName, ContactName, 'Supplier' as Type
FROM Suppliers 

--28
--SELECT * FROM T1 INNER JOIN T2 ON F1.T1 = F2.T2;
/*
result:
2
3
*/
--29
--SELECT * FROM T1 LEFT JOIN T2 ON F1.T1 = F2.T2;
/*
result:
1   Null
2	2
3	3
*/