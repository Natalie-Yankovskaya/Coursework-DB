SELECT Title AS 'Название серала', (Year(SYSDATETIME()) - Year([Release date])) AS 'Продолжительность' 
FROM Series;
