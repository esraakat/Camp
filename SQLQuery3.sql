--select - en yoğun kulllanılan sorgulardan biri - seç - bir veri kaynağındaki datayı seçmek için kullanılır
--* tüm kolonlar 
--sql-case insensitive 
--<> farklı 10'dan farklı olanları getir.
--sorguya da select almak isteyebiliriz.
--metinler ansıı standartlarınd atek tırnakla yazılır.
--ansıı standardı-çalışan kod sql server ama yazdığımız kod oracleda da mysqlde de çalışır 
select ContactName Adi, CompanyName Sirketadi, City Sehir from Customers --face bir tabo oluşturur.
select *from Customers where City= 'London'   --filtreleme, where koşul demek
select *from Products where CategoryID = 1 or CategoryID = 3
select *from Products where CategoryID = 1 and UnitPrice >= 10
select *from Products order by ProductName --sırala
select *from Products order by UnitPrice asc --ascending --defaultu artandır.
select *from Products order by UnitPrice desc --descending --düşen fiyat
select *from Products order by CategoryID, ProductName --categoryıd'ye göre sırala
select *from Products where CategoryID=1 order by UnitPrice desc
select count(*) from Products --satır sayısı -tek bir kolon tek bir satır gelmesi gerekiyor.
select count(*) Adet from Products where CategoryID=2
--select count(*), ProductName from Products - yanlış
select categoryId,count(*) from Products group by CategoryID
--datayı tamamen group by ifadesinde belirtilene göre verdik. Bütün kategorileri tekrar etmeyecek şekilde listele demektir.
--sen bir group by yaptığında aslında her bir grup için arka planda bir tablo oluşturuluyor gibi düşünebilirsin.
--group by yazdığında select ettiğin kolon sadece group by da yazdığın kolon veya kümülatif data olabilir, count* gibi
--sql sektörde kurtarır.
--2 kolona birden de group by yapabiliriz.
--group bylarda kümülatif dataya yazılan koşul havibg olarak yazılır.
select categoryId, count(*) from Products group by CategoryID having count (*) <10
--içinde 10 tanden az ürün çesidi olan kategorileri ver demektir.
--having grou bya konu olan kümülatif sorguya yazılır. count-sayı avg-ort -sum ort
select categoryId, count(*) from Products where unitprice >20 
group by categoryId having count(*)<10
--datayı filtrelemek istersen üsttekini kullan
--nce her zaman where çalışır
--birim fiyatı 20den fazla ürünleri categoyıdye göre grupla onlardan da sayısı her bi groupta sayısı
--havıng kümülatiflere uygularız 

--join-tabloları birleştirme
select Products.ProductID, Products.ProductName, Products.UnitPrice, Categories.CategoryName
from Products inner join Categories
on Products.CategoryID = Categories.CategoryID 
where products.UnitPrice>10 --fiyatı >10 olanları için kategorilerle join et bana getir.
--neye göre birlşetiricem 
--on durumunda, şartında anlamındadır.

--DTO-DATA TRANSFORMATİON OBJECT-C#da karşımıza çıkar. joinler

--bir tane daha join var çok önemlidir.
--inner join 2 tabloda eşlenenleri getirir eşleşmeyen data varsa onu getirmez
select *from Products p inner join [Order Details] od --left-- 
on p.ProductID = od.ProductID
inner join Orders o   --bi join daha eklemek için devamına inner join eklriz.
on o.OrderID = od.OrderID
--genelde ana tablo öne yazılır.
select *from Customers c left join Orders o --SOLDA OLUP SAĞDA OLMAYANLAR
on c.CustomerID = o.CustomerID
where o.customerId is null

--select *from Orders o right join Customer c -- yukardakiyle aynı şeydri.
--KOŞULU P E UYGULARIZ 
--left join - solda olup sağda olmayanları da geti.r
--inner join 2 tablodada eşlesiyorsa birleştirir. 
--iki tabloyu join edeceğim sırada iki tablodaki oratak kolonu bulmalaısısn.
--boşluk isimlerdirme de doğru deği iki farklı kod olarak algılmasın diye sqldeköşeli parantez 
--her zaman joınlerde *la başla 
--genelde joinlerde kısaltma alians kullanılır.
--başka sqk-l komutları da var in, distinct uniun gibi