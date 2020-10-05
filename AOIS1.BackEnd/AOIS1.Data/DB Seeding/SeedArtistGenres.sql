use [ExpertSystemDB];

DELETE 
FROM [ArtistGenre];


INSERT INTO [ArtistGenre] (ArtistId, GenreId, Probability) VALUES
	(11, 1, 0.9),
	(11, 2, 0.4),
	(11, 4, 1.00),
	(11, 5, 0.55),
	(11, 7, 0.2),
	(12, 1, 0.85),
	(12, 2, 0.63),
	(12, 3, 0.7),
	(13, 1, 0.45),
	(13, 3, 0.3),
	(13, 6, 0.4),
	(13, 7, 0.6),
	(13, 8, 0.9),
	(14, 6, 0.5),
	(14, 7, 0.7),
	(14, 9, 0.95),
	(14, 10, 0.84),
	(15, 1, 0.8),
	(15, 12, 1.00),
	(16, 1, 0.4),
	(16, 2, 0.95),
	(16, 7, 0.4),
	(16, 11, 0.7),
	(17, 1, 0.4),
	(17, 2, 1.00),
	(17, 7, 0.6),
	(17, 11, 0.8),
	(17, 12, 0.2),
	(18, 1, 0.5),
	(18, 3, 0.4),
	(18, 6, 0.7),
	(18, 7, 0.4),
	(18, 8, 0.6),
	(18, 9, 1.00),
	(18, 10, 0.3),
	(18, 12, 0.2),
	(19, 2, 0.4),
	(19, 3, 0.5),
	(19, 4, 0.6),
	(19, 5, 0.8),
	(20, 1, 0.3),
	(20, 3, 0.2),
	(20, 9, 0.6),
	(21, 1, 0.6),
	(21, 2, 0.7),
	(21, 3, 0.5),
	(21, 5, 0.8),
	(21, 11, 0.4);