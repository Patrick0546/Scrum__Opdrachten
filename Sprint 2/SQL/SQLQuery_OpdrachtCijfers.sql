CREATE TABLE Student (
ID int PRIMARY KEY(ID, DocentID, VakID),
Naam varchar,
DocentID int,
VakID int,
);

CREATE TABLE Vak (
ID int PRIMARY KEY(ID),
Naam varchar,
);

CREATE TABLE Docent (
ID int PRIMARY KEY(ID),
Naam varchar,
);

CREATE TABLE Cijfers(
ID int PRIMARY KEY(ID, VakID, DocentID),
VakID int,
DocentID int,
);

