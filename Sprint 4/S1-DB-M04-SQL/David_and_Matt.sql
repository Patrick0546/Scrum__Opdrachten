SELECT        tblDoctor.DoctorName, tblEpisode.Title FROM            tblDoctor INNER JOIN
tblEpisode ON tblDoctor.DoctorId = tblEpisode.DoctorId where EpisodeDate like '%2010%'