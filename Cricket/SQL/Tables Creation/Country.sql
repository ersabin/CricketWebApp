CREATE DATABASE Cricket;

USE Cricket 
GO

CREATE TABLE Country(
	CountryID INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	CountryName varchar(30),
	Continent varchar(30),
	CountryCode varchar(3)
);





