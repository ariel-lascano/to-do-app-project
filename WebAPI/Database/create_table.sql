CREATE TABLE dbo.data
(
    ID INT IDENTITY(1,1) NOT NULL,  -- Chiave primaria intero incrementale automatico
    VisualOrder INT NOT NULL,       -- Intero non negativo non nullo
    Name NVARCHAR(255) NOT NULL,    -- Stringa non nulla
    Description NVARCHAR(MAX) NULL  -- Stringa che può essere nulla
);