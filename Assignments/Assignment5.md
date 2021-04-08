![Picture1](https://user-images.githubusercontent.com/52603892/114061063-000dfb80-9864-11eb-8578-434ec20b1b40.png)
--1.	Write an sql statement that will display the name of each customer and the sum of order totals placed by that customer during 
-- the year 2002.
-- Create table customer(cust_id int,  iname varchar (50)) 
-- create table order(order_id int,cust_id int,amount money,order_date smalldatetime)

SELECT CompanyName FROM dbo.Customers

-- 2.  The following table is used to store information about company’s personnel:
--Create table person (id int, firstname varchar(100), lastname varchar(100)) write a query that returns 
-- all employees whose last names  start with “A”.
CREATE TABLE #CustomerInfo( CustomerID INT, FirstName VARCHAR(50),
LastName VARCHAR(50),CountOfSales INT, SumOfTotalDue MONEY)
GO
SELECT LastName FROM Sales.Customer 
WHERE LastName = 'A%'

--3.  The information about company’s personnel is stored in the following table:
--Create table person(person_id int primary key, manager_id int null, name varchar(100)not null) The filed managed_id contains 
-- the person_id of the employee’s manager.
--Please write a query that would return the names of all top managers(an employee who does not have  a manger, 
--and the number of people that report directly to this manager.

CREATE TABLE person(person_id int primary key, manager_id int null, name varchar(100)not null)
GO
SELECT name FROM person


--4.  List all events that can cause a trigger to be executed.

--You can write triggers that fire whenever one of the following operations occurs:

--DML statements (INSERT, UPDATE, DELETE) on a particular table or view, issued by any user

--DDL statements (CREATE or ALTER primarily) issued either by a particular schema/user or by any schema/user in the database

--Database events, such as logon/logoff, errors, or startup/shutdown, also issued either by a particular schema/user or by any schema/user in the database

--5. Generate a destination schema in 3rd Normal Form.  
--Include all necessary fact, join, and dictionary tables, and all Primary and Foreign Key relationships.  
--The following assumptions can be made:
--a. Each Company can have one or more Divisions.
--b. Each record in the Company table represents a unique combination 
--c. Physical locations are associated with Divisions.
--d. Some Company Divisions are collocated at the same physical of Company Name and Division Name.
--e. Contacts can be associated with one or more divisions and the address, but are differentiated by suite/mail drop records.status of each association should be separately maintained and audited.

(Since I couldn’t find the database we were supposed to operate in, I provided an example of 3rd Normal Form.)

![Picture1](https://user-images.githubusercontent.com/52603892/114061075-0603dc80-9864-11eb-901b-367253866150.png)

