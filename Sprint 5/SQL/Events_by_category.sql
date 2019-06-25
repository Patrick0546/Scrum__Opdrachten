SELECT        tblEvent.EventName + cast(tblCategory.CategoryID AS varchar(12)) , tblEvent.EventDate
FROM            tblCountry INNER JOIN
                         tblEvent ON tblCountry.CountryID = tblEvent.CountryID INNER JOIN
                         tblCategory ON tblEvent.CategoryID = tblCategory.CategoryID
where CountryName like '%Ukraine%'