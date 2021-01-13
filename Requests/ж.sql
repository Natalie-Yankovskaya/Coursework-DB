SELECT Series.Title AS 'Сериал', Actors.Name AS 'Имя Актёра', Actors.Surname AS 'Фамилия актера',  Roles.Role AS 'Роль'
FROM Roles, Actors, Series
WHERE Roles.Id_series = Series.Id_series AND Roles.Id_actor = Actors.Id_actor;