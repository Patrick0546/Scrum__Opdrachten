SELECT * FROM tblEvent
Where (CountryID in(8,22,30,35) or
EventDetails like '% water %' or
CategoryID = 4) and EventDate > '1970-01-01'