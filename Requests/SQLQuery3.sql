SELECT CONCAT(CONCAT(N'Сериалы снимаются в ', (COUNT (DISTINCT Country))), N' странах')
FROM Series;