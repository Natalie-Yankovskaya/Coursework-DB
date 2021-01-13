SELECT Series.[Total duration]
FROM Users1, Series
WHERE Series.Id_series = Users1.[Current series] AND Id_user = 1;