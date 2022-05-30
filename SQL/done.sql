CREATE TABLE Customers
(
    ID SERIAL PRIMARY KEY,
    NAME VARCHAR(30) NOT NULL
);

CREATE TABLE Orders
(
    ID SERIAL PRIMARY KEY,
    CustomerId INTEGER NOT NULL
);

INSERT INTO Customers VALUES 
(1, 'Max'),
(2, 'Pavel'),
(3, 'Ivan'),
(4, 'Leonid');

INSERT INTO Orders VALUES
(1, 2),
(2, 4);

SELECT NAME FROM Customers
WHERE ID NOT IN (SELECT DISTINCT CustomerId FROM Orders);