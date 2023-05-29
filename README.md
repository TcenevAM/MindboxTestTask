# 2 Задание

SELECT Products.Name AS ProductName, COALESCE(Categories.Name, 'Без категории') AS CategoryName

FROM Products

LEFT JOIN ProductCategory ON Products.ProductId = ProductCategory.ProductId

LEFT JOIN Categories ON ProductCategory.CategoryId = Categories.CategoryId;
