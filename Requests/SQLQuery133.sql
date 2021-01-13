CREATE VIEW Average AS
SELECT Studios.Name AS 'Studios Name', AVG(Series.Rating) AS 'Average rating of series'
FROM Series, Studios
WHERE Series.Id_studio = Studios.Id_studio
GROUP BY Studios.Name;