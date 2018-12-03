DECLARE @cnt INT = 0;

WHILE @cnt < 10
BEGIN 
	INSERT INTO Products(PRODUCT, ARTIST, Price, Code)
	Values('Album' + CAST(@cnt as varchar), 'The artist' + Cast(@cnt as varchar), '21.00', @cnt);
	set @cnt = @cnt + 1;
END;