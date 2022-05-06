declare @GenerateTable varchar(8000)
declare @i int
set @i = 1
set @GenerateTable = 'Create Table Alphabet('
set @GenerateTable = @GenerateTable + ' NO0' + ' int primary key, '
while(@i<400)
	begin
		set @GenerateTable = @GenerateTable + 'NO'+CONVERT(varchar,@i) + ' int null, '
		set @i = @i +1
	end
set @GenerateTable = @GenerateTable + 'NO'+CONVERT(varchar,@i) + ' int null )'
print(@GenerateTable)
exec (@GenerateTable)