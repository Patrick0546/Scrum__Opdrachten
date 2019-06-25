SELECT        EventName, EventDate,
FORMAT(EventDate, 'dd/MM/yyyy')as UsingFormat,
CONVERT(varchar(12), EventDate)as UsingConvert
FROM            tblEvent
where year(EventDate)='1978'