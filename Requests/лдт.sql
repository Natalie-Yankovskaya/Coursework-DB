SELECT Actors.Citizenship AS 'Гражданство', COUNT(Actors.Id_actor) AS 'Количество актеров'
FROM Actors
GROUP BY Actors.Citizenship;