SELECT Users1.Id_user, Users1.Name, Users1.Surname, Users1.[E-mail], Series.Title, Users1.[Finished series], Users1.[Spent Time]
FROM Users1, Series
WHERE Series.Id_series = Users1.[Current series];