select *from Customers
select  ContactName Adi, CompanyName SirketAdi, City Sehir from Customers --fake tablo
select *from Customers where City = 'London' --where-->condition, filtration
select *from Products where CategoryID = 1 or CategoryID = 3
select *from Products where CategoryID = 1 and UnitPrice >= 10
select *from Products order by ProductName
select *from Products order by UnitPrice asc --ascending, default
select *from Products order by UnitPrice desc --descending
select *from Products order by CategoryID, ProductName
select *from Products where CategoryID = 1 order by UnitPrice desc
select count(*) from Products --number of line
select count(*) from Products where CategoryID = 2 --number of line in categoryıd=2
--select count(*), ProductName from Products --->false

select categoryId ,count(*) from Products group by CategoryID --List all the categories but 
--Datayı group by'daki gibi verdik.
--When you group by, you think that generating a tablo for every group
--You can group by 2 columns.
--group by yazdığında select ettiğin kolon sadece group by da yazdığın kolon veya kümülatif data olabilir, count* gibi

select categoryId, count(*) from Products group by CategoryID having count (*)<10
--Show columns with less than 10 products
--group bylarda kümülatif dataya yazılan koşul having olarak yazılır, like count,avg,sum
--Use having keyword to cumulative 
select categoryId, count(*) from Products where unitprice >20 group by categoryId having count(*)<10
--always run 'where' first

--join tables
--There are 2 types of join. inner join and inner left or right 
--inner join---> Get matching in 2 tables, if data does not match, do not get 
select Products.ProductID, Products.ProductName, Products.UnitPrice, Categories.CategoryName
from Products inner join Categories
on Products.CategoryID = Categories.CategoryID   --on ---> ıt means in condition
where products.UnitPrice>10    --join with categories for unitprice<10

select *from Products p inner join [Order Details] od
on p.ProductID = od.ProductID
inner join Orders o  --add another join
on o.OrderID = od.OrderID

select *from Customers c left join Orders o --datas that are in left but are not right 
on c.CustomerID = o.CustomerID
where c.CustomerID is null

--it is alternative to the above 
select *from Orders o right join Customers c
on o.CustomerID = c.CustomerID
where c.CustomerID is null



--select - one of the most useful querys-to select a data in a database  
--*from - all the columns
--sql-case insensitive
--<> ---> get different ones
--inner join - if datas match in 2 tablos, join them - find a common column in 2 tablos
--left join - find datas that are in left but are not right
--use alians in join
--do not use spaces in naming because of understanding 2 different codes, ssquare brackets in sql
--the code that runs is sql server, but the code we write works in both oracle and mysql.