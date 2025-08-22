CREATE PROCEDURE Proc_GetDeps
AS
BEGIN
    SELECT id, name FROM dbo.deps;
END