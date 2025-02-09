CREATE TABLE Utente(
utenteID INT PRIMARY KEY IDENTITY(1,1),
nome VARCHAR(250) NOT NULL,
cognome VARCHAR(250) NOT NULL,
email VARCHAR(250)
);

CREATE TABLE Libro(
libroID INT PRIMARY KEY IDENTITY(1,1),
titolo NVARCHAR(100) NOT NULL,
annoPubblicazione INT NOT NULL,
Disponibile BIT
);

CREATE TABLE Prestito(
prestitoID INT PRIMARY KEY IDENTITY(1,1),
DataPrestito DATE NOT NULL,
DataRitorno DATE,
utenteRIF INT NOT NULL,
libroRIF INT NOT NULL,
FOREIGN KEY (utenteRIF) REFERENCES Utente(utenteID) ON DELETE CASCADE,
FOREIGN KEY (libroRIF) REFERENCES Libro(libroID) ON DELETE CASCADE
);

SELECT * FROM Libro;