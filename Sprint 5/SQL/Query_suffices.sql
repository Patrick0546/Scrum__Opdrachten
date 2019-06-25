SELECT        EventName,
FORMAT(EventDate,'D') as Event_Date
FROM            tblEvent
ORDER BY EventDate ASC