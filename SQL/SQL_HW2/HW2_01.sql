--Author: Bochen Huang

--1
SELECT COUNT(1)
FROM Production.Product

--2
SELECT COUNT(1)
FROM Production.Product
WHERE ProductSubcategoryID IS NOT NULL

--3
SELECT ProductSubcategoryID, COUNT(1) AS CountedProducts
FROM Production.Product
WHERE ProductSubcategoryID IS NOT NULL
GROUP BY ProductSubcategoryID;

--4
SELECT COUNT(1)
FROM Production.Product
WHERE ProductSubcategoryID IS NULL

--5
SELECT SUM(Quantity)
FROM  Production.ProductInventory
GROUP BY ProductID

--6
SELECT ProductID, SUM(Quantity) AS TheSum 
FROM  Production.ProductInventory
WHERE LocationID = 40 
GROUP BY ProductID
HAVING SUM(Quantity) < 100

--7
SELECT Shelf, ProductID,  SUM(Quantity) AS TheSum
FROM  Production.ProductInventory
WHERE LocationID = 40
GROUP BY ProductID, Shelf
HAVING SUM(Quantity) < 100

--8
SELECT AVG(Quantity) AS TheAvg
FROM Production.ProductInventory
WHERE LocationID = 10;

--9
SELECT ProductID, Shelf, AVG(Quantity) AS TheAvg
FROM Production.ProductInventory 
GROUP BY ProductID, Shelf;

--10
SELECT ProductID, Shelf, AVG(Quantity) AS TheAvg
FROM Production.ProductInventory
WHERE Shelf <> 'N/A'
GROUP BY ProductID, Shelf;

--11
SELECT Color, Class, COUNT(*) AS TheCount, AVG(ListPrice) AS AvgPrice
FROM Production.Product
WHERE Color IS NOT NULL AND Class IS NOT NULL
GROUP BY Color, Class;

--12
SELECT c.Name AS Country, s.Name AS Province
FROM Person.CountryRegion AS c INNER JOIN Person.StateProvince AS s
ON c.CountryRegionCode = s.CountryRegionCode;

--13
SELECT c.Name AS Country, s.Name Province
FROM  person. CountryRegion AS c INNER JOIN person. StateProvince AS s
ON c.CountryRegionCode = s.CountryRegionCode
WHERE c.Name IN ('Germany', 'Canada')

