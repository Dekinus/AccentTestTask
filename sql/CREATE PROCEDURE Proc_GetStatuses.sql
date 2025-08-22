CREATE PROCEDURE Proc_GetStatuses
AS
BEGIN
    SELECT id, name FROM dbo.status;
END