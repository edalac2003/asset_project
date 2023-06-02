CREATE TRIGGER maintenance_number
ON MaintenanceRequests
FOR INSERT
AS
BEGIN
	Declare @RequestNumber varchar
	Declare @Id int
	  
	SELECT 
		@Id = Id, 
		@RequestNumber = 
		CASE 
			WHEN Id < 10  THEN '00000'
			WHEN Id >=10 AND Id < 99  THEN '0000'
			WHEN Id >= 100 AND Id < 999 THEN '000'
			WHEN Id >= 1000 AND Id < 9999  THEN '00'
			WHEN Id >= 10000 AND Id < 99999 THEN '0'
			ELSE '' 
		END
	FROM inserted
	UPDATE MaintenanceRequests
	set RequestNumber = 'SOL' + @RequestNumber + cast(@Id as varchar)
	where Id = @Id
END