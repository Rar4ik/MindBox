use MindBoxSQL
select ProductsName.ProductName, ProductsName.Id, ProductsCategory.ProductCategory
from ProductsName
left outer join CategoryName
On ProductsName.Id = CategoryName.ProductId
left outer join ProductsCategory
on CategoryName.CategoryId = ProductsCategory.Id
