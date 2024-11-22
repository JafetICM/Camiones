-- Crear la base de datos
CREATE DATABASE refaccionaria;
GO

-- Usar la base de datos
USE refaccionaria;
GO

-- Crear la tabla Camion
CREATE TABLE Camion (
    Idcamion INT PRIMARY KEY IDENTITY(1,1),
    Nombre VARCHAR(50) NOT NULL,
    Totalmacenaje DECIMAL(10,2) NOT NULL,
    Placas VARCHAR(30) NOT NULL,
    Marca VARCHAR(30) NOT NULL
);
GO

-- Insertar algunos datos de ejemplo
INSERT INTO Camion (Nombre, Totalmacenaje, Placas, Marca)
VALUES
('Camion A', 5000.00, 'ABC123', 'Marca A'),
('Camion B', 7500.50, 'DEF456', 'Marca B'),
('Camion C', 3000.75, 'GHI789', 'Marca C');
GO

select * from Camion;

DELETE FROM Camion;


