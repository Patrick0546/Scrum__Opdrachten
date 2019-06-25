SELECT EventName, EventDate,
CHARINDEX( 'this', EventDetails, 1)as thisPosition,
CHARINDEX( 'that', EventDetails, 1)as thatPosition
FROM tblEvent
where EventDetails like '%this%' and EventDetails like '%that%' and CHARINDEX( 'this', EventDetails, 1)< CHARINDEX( 'that', EventDetails, 1)