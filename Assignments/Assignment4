--Use Northwind database. All questions are based on assumptions described by the Database Diagram sent to you yesterday. When inserting, make up info if necessary. Write query for each step. Do not use IDE. BE CAREFUL WHEN DELETING DATA OR DROPPING TABLE.
--1.	Lock tables Region, Territories, EmployeeTerritories and Employees. Insert following information into the database. 
--In case of an error, no changes should be made to DB.

--a.	A new region called “Middle Earth”;
SELECT * FROM Region
INSERT INTO dbo.Region(RegionID, RegionDescription) VALUES (5, 'Middle Earth')

--b.	A new territory called “Gondor”, belongs to region “Middle Earth”;
SELECT * FROM Territories
--DELETE FROM dbo.Territories WHERE TerritoryDescription = 'Middle Earth'
INSERT INTO dbo.Territories(TerritoryID, RegionID, TerritoryDescription) VALUES (00000, 5, 'Gondor')


--c.	A new employee “Aragorn King” who's territory is “Gondor”.
SELECT * FROM EmployeeTerritories
SELECT * FROM Employees
INSERT INTO dbo.Employees(EmployeeID, LastName, FirstName) VALUES (10, 'King', 'Aragorn')
INSERT INTO dbo.EmployeeTerritories(EmployeeID, TerritoryID) VALUES (10, 00000)


--2.	Change territory “Gondor” to “Arnor”.

UPDATE Territories
SET TerritoryDescription = 'Arnor'
WHERE TerritoryDescription = 'Gondor'


--3.	Delete Region “Middle Earth”. (tip: remove referenced data first) (Caution: do not forget WHERE or you will delete everything.) In case of an error, no changes should be made to DB. Unlock the tables mentioned in question 1.

DELETE FROM dbo.Region WHERE RegionDescription = 'Middle Earth'


--4.	Create a view named “view_product_order_[your_last_name]”, list all products and total ordered quantity for that product.
SELECT * FROM Products

CREATE VIEW view_product_order_Xu AS
SELECT ProductName, UnitsOnOrder
FROM Products


--5.	Create a stored procedure “sp_product_order_quantity_[your_last_name]” that accept product id as an input and 
--total quantities of order as output parameter.

CREATE VIEW sp_product_order_quantity__Xu AS
SELECT ProductID, UnitsInStock
FROM Products


--6.	Create a stored procedure “sp_product_order_city_[your_last_name]” that accept product name as an input and 
--top 5 cities that ordered most that product combined with the total quantity of that product ordered from that city as output.
SELECT * FROM Orders

CREATE VIEW sp_product_order_city_Xu AS
SELECT ShipCity
FROM Orders


--7.	Lock tables Region, Territories, EmployeeTerritories and Employees. 
--Create a stored procedure “sp_move_employees_[your_last_name]” that automatically find all employees in territory “Tory”; 
--if more than 0 found, insert a new territory “Stevens Point” of region “North” to the database, and then move those employees to 
--“Stevens Point”.
SELECT * FROM Employees

CREATE VIEW sp_move_employees_Xu AS
SELECT Employees.LastName, Employees.FirstName
FROM Region, Territories, EmployeeTerritories, Employees


--8.	Create a trigger that when there are more than 100 employees in territory “Stevens Point”, 
--move them back to Troy. (After test your code,) remove the trigger. Move those employees back to “Troy”, if any. Unlock the tables.
SELECT * FROM Territories
SELECT * FROM Employees

DROP TRIGGER IF TerritoryDescription IS NOT 'Stevens Point'
GO
CREATE TRIGGER Stevens_Point ON Territories INSTEAD OF INSERT
AS BEGIN
INSERT INTO Territories (Employees.City) VALUES ('Troy')
END


--9.	Create 2 new tables “people_your_last_name” “city_your_last_name”. 
--City table has two records: {Id:1, City: Seattle}, {Id:2, City: Green Bay}. 
--People has three records: {id:1, Name: Aaron Rodgers, City: 2}, {id:2, Name: Russell Wilson, City:1}, 
--{Id: 3, Name: Jody Nelson, City:2}. Remove city of Seattle. 
--If there was anyone from Seattle, put them into a new city “Madison”. 
--Create a view “Packers_your_name” lists all people from Green Bay. 
--If any error occurred, no changes should be made to DB. (after test) Drop both tables and view.

CREATE TABLE city_your_Xu (
	Id int, -- Both a primary and foreign key
	City varchar(30) NOT NULL,
)


INSERT INTO city_your_Xu (Id, City) VALUES
  (1, 'Seattle')
  (2, 'Green Bay')

 CREATE TABLE people_your_Xu (
	Id int, -- Both a primary and foreign key
	Name varchar(30) NOT NULL,
	City varchar(30) NOT NULL,
)

INSERT INTO city_your_Xu (Id, Name, City) VALUES
  (1, 'Aaron Rodgers', 2)
  (2, 'Russell Wilson', 1)
  (3, 'Jody Nelson', 2)

--10.	 Create a stored procedure “sp_birthday_employees_[you_last_name]” that 
--creates a new table “birthday_employees_your_last_name” and fill it with all employees that have a birthday on Feb. 
--(Make a screen shot) drop the table. Employee table should not be affected.

CREATE PROCEDURE sp_birthday_employees_Xu
as
begin
CREATE TABLE birthday_employees_your_Xu
SELECT LastName, FirstName 
FROM Employees
WHERE 
end


--11.	Create a stored procedure named “sp_your_last_name_1” that returns all cites that have at least 2 customers 
--who have bought no or only one kind of product. Create a stored procedure named “sp_your_last_name_2” 
--that returns the same but using a different approach. (sub-query and no-sub-query).
SELECT * FROM Customers

CREATE PROCEDUREsp_your_Xu_1
as
begin
SELECT CompanyName
FROM Customers
end


--12.	How do you make sure two tables have the same data?

--Basically, we have one table (original table) and it is backed up into another table (backup table); thus the two tables have exactly the same schema.

--In the beginning, both tables (original table and backup table) contains exactly the same set of data. After some time for some reason, I need to verify whether dataset in the original table has changed or not.

--In order to do this, I have to compare the dataset in the original table against the backup table.


--14.
--First Name	Last Name	Middle Name
--John	Green	
--Mike	White	M

--Output should be
--Full Name
--John Green
--Mike White M.
--Note: There is a dot after M when you output.

UPDATE Last_Name
SET Last_Name = Last_Name + '.'



--15.
--Student	Marks	Sex
--Ci	70	F
--Bob	80	M
--Li	90	F
--Mi	95	M
--Find the top marks of Female students.
--If there are to students have the max score, only output one.
SELECT TOP 1 * FROM Student
ORDER BY Marks
WHERE Sex = 'F'



--16.
--Student	Marks	Sex
--Li	90	F
--Ci	70	F
--Mi	95	M
--Bob	80	M
--How do you out put this?
--If there are to students have the max score, only output one.
SELECT TOP 1 * FROM Student
ORDER BY Marks
