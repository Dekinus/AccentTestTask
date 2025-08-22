CREATE PROCEDURE Proc_GetPosts
AS
BEGIN
    SELECT id, name FROM dbo.posts;
END