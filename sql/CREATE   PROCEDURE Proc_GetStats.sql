CREATE PROCEDURE Proc_GetStats
    @statusId INT,
    @startDate DATETIME,
    @endDate DATETIME,
    @mode VARCHAR(10) 
AS
BEGIN
    IF @mode = 'Employ'
    BEGIN
        SELECT 
            CAST(p.date_employ AS DATE) AS Day,
            COUNT(*) AS Count
        FROM dbo.persons p
        WHERE p.status = @statusId
          AND p.date_employ IS NOT NULL
          AND p.date_employ BETWEEN @startDate AND @endDate
        GROUP BY CAST(p.date_employ AS DATE)
        ORDER BY Day;
    END
    ELSE IF @mode = 'Unemploy'
    BEGIN
        SELECT 
            CAST(p.date_unemploy AS DATE) AS Day,
            COUNT(*) AS Count
        FROM dbo.persons p
        WHERE p.status = @statusId
          AND p.date_unemploy IS NOT NULL
          AND p.date_unemploy BETWEEN @startDate AND @endDate
        GROUP BY CAST(p.date_unemploy AS DATE)
        ORDER BY Day;
    END
END