CREATE TABLE Student (
ID int PRIMARY KEY(ID, DocentID, VakID),
Naam varchar,
DocentID int,
VakID int,
);

CREATE TABLE Vak (
ID int,
Naam varchar,
);

CREATE TABLE Docent (
ID int,
Naam varchar,
);

CREATE TABLE Cijfers(
ID int,
VakID int,
DocentID int,
);

