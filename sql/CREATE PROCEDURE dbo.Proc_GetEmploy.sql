CREATE PROCEDURE Proc_GetEmployees
         @statusId INT = NULL,
         @depId INT = NULL,
         @postId INT = NULL,
         @lastNamePart VARCHAR(100) = NULL,
         @sortField VARCHAR(50) = 'FIO',
         @sortDir VARCHAR(4) = 'ASC'
     AS
     BEGIN
         SET NOCOUNT ON;

         DECLARE @sql NVARCHAR(MAX);

         SET @sql = N'
         SELECT 
             p.id,
             CONCAT(p.last_name, '' '', LEFT(p.first_name, 1), ''. '', LEFT(p.second_name, 1), ''.'') AS FIO,
             s.name AS StatusName,
             d.name AS DepName,
             po.name AS PostName,
             p.date_employ,
             p.date_unemploy
         FROM master.dbo.persons p
         INNER JOIN master.dbo.status s ON p.status = s.id
         INNER JOIN master.dbo.deps d ON p.id_dep = d.id
         INNER JOIN master.dbo.posts po ON p.id_post = po.id
         WHERE (@statusId IS NULL OR p.status = @statusId)
           AND (@depId IS NULL OR p.id_dep = @depId)
           AND (@postId IS NULL OR p.id_post = @postId)
           AND (@lastNamePart IS NULL OR p.last_name LIKE ''%'' + @lastNamePart + ''%'')
         ORDER BY ' + 
             CASE 
                 WHEN @sortField = 'FIO' THEN 'p.last_name ' + @sortDir
                 WHEN @sortField = 'Status' THEN 's.name ' + @sortDir
                 WHEN @sortField = 'Dep' THEN 'd.name ' + @sortDir
                 WHEN @sortField = 'Post' THEN 'po.name ' + @sortDir
                 WHEN @sortField = 'EmployDate' THEN 'p.date_employ ' + @sortDir
                 WHEN @sortField = 'UnemployDate' THEN 'p.date_unemploy ' + @sortDir + ' NULLS LAST'
                 ELSE 'p.last_name ASC'
             END;

         EXEC sp_executesql @sql,
             N'@statusId INT, @depId INT, @postId INT, @lastNamePart VARCHAR(100), @sortField VARCHAR(50), @sortDir VARCHAR(4)',
             @statusId, @depId, @postId, @lastNamePart, @sortField, @sortDir;
     END