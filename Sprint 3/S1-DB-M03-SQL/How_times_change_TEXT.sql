SET NOCOUNT ON
SELECT TOP 2  EventName as What, EventDate as When_ From tblEvent
order by EventDate ASC

SELECT TOP 2  EventName as What, EventDate as When_ From tblEvent
order by EventDate DESC
