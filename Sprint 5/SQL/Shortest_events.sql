SELECT EventName, len(EventName) from tblEvent WHERE LEN (EventName)<9 order by LEN (EventName) ASC