SELECT        EventName, EventDate,
DATENAME(WEEKDAY,Eventdate) as Day_of_Week,
DATENAME(DAY, EventDate) as Day_Number
FROM            tblEvent
where DATENAME(WEEKDAY,Eventdate) = 'Friday' and DATENAME(DAY, EventDate) = '13' or DATENAME(WEEKDAY,Eventdate) = 'Thursday' and DATENAME(DAY, EventDate) = '12' or DATENAME(WEEKDAY,Eventdate) = 'Saturday' and DATENAME(DAY, EventDate) = '14'
