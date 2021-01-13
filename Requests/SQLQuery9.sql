SELECT Studios.Name AS 'Название студии', COUNT(Series.Id_studio) AS 'Количество сериалов'
FROM Studios, Series
WHERE Studios.Id_studio = Series.Id_studio
GROUP BY Studios.Name
HAVING COUNT(Series.Id_studio) >= 2;