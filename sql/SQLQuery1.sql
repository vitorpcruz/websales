-- TODOS OS PROUTOS COMPRADOS POR UM CLIENTE  -- LINQ
SELECT p.Id, p.Name FROM Products p
INNER JOIN Sales s ON p.Id = s.ProductId
INNER JOIN Customers c ON c.Id = s.CustomerId
--WHERE p.Id == ID

-- PRODUTOS MAIS VENDIDOS EM UM DETERMINADO DIA -- LINQ
SELECT p.Name, sum(s.Total) AS 'Total' FROM Products p
LEFT JOIN Sales s ON p.Id = s.ProductId
GROUP BY p.Name order BY 'Total' DESC;

-- COMPRAS VINCULADAS À CLIENTES -- ADONET
SELECT c.Id, c.FullName, c.Document, s.SaleNumber FROM Customers c
INNER JOIN Sales s 
ON c.Id = s.CustomerId

-- VENDAS EXISTENTES VINCULADAS À PRODUTOS EXISTENTES
SELECT s.SaleNumber, p.Name, s.ProductPriceAtMoment, s.Total, s.ProductId FROM Sales s
LEFT JOIN Products p
ON p.Id = s.ProductId
WHERE s.SaleCancelled = 0 AND p.Id IS NOT NULL

-- TODAS AS VENDAS REALIZADAS COM OU SEM VINCULOS
SELECT 
    s.SaleNumber, 
    s.ProductPriceAtMoment, 
    s.ProductQuantity, 
    s.Total, 
    s.SaleCancelled,
    p.Name as 'ProductName', 
    c.FullName as 'CustomerFullName'
FROM Sales s
LEFT JOIN Products p ON s.ProductId = p.Id
LEFT JOIN Customers c ON s.CustomerId = c.Id