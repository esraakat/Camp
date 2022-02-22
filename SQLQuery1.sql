select * from Customers 
select ContactName Adi, City Sehir from Customers
select * from Customers where City = 'London'
select * from Products
select * from Products where CategoryID = 1 or CategoryID = 3
select * from Products where CategoryID = 1 and UnitPrice > 10
select * from Products order by ProductName
select * from Products order by CategoryID, ProductName
select * from Products order by UnitPrice asc --ascending
select * from Products where CategoryID = 1 order by UnitPrice desc
select COUNT(*) from Products
select count(*) adet from Products where CategoryID = 2
select CategoryID, count(*) from Products group by CategoryID
select CategoryID, count(*) from Products where UnitPrice >20 group by CategoryID having count(*) < 10

select Products.ProductID, Products.ProductName, Products.UnitPrice, Categories.CategoryName
from Products inner join Categories on Products.CategoryID =  Categories.CategoryID
where Products.UnitPrice > 10

select * from Products p inner join [Order Details] od
on p.ProductID = od.ProductID
inner join Orders o
on od.OrderID = o.id

select * from Customers c left join Orders o
on c.CustomerID = o.CustomerID
where o.OrderID is null