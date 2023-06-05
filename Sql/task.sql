SELECT p.Name, c.Name
FROM Products p
LEFT JOIN ProductsCategories pc
	ON p.ProductId = pc.ProductId
LEFT JOIN Categories c
	ON pc.CategoryId = c.CategoryId
ORDER BY p.Name;
