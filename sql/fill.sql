INSERT INTO dbo.status (name) VALUES
(N'Active'),
(N'Inactive'),
(N'On Leave');

INSERT INTO dbo.deps (name) VALUES
(N'IT Department'),
(N'HR Department'),
(N'Finance Department');

INSERT INTO dbo.posts ( name) VALUES
(N'Developer'),
(N'Manager'),
(N'Analyst');

INSERT INTO dbo.persons (last_name, first_name, second_name, status, id_dep, id_post, date_employ, date_unemploy) VALUES
( N'Ivanov', N'Ivan', N'Petrovich', 1, 1, 1, '2024-01-15', NULL),
( N'Petrova', N'Anna', N'Sergeevna', 2, 2, 2, '2023-06-01', '2025-02-10'),
( N'Sidorov', N'Mikhail', N'Alexandrovich', 1, 3, 3, '2024-03-20', NULL),
( N'Kuznetsova', N'Elena', N'Dmitrievna', 3, 1, 2, '2022-11-10', NULL),
( N'Smirnov', N'Alexey', N'Viktorovich', 1, 2, 1, '2025-01-01', NULL),
( N'Popova', N'Olga', N'Nikolaevna', 2, 3, 3, '2023-09-15', '2024-12-31'),
( N'Vasiliev', N'Dmitry', N'Ivanovich', 1, 1, 1, '2024-07-01', NULL),
( N'Morozova', N'Natalia', N'Pavlovna', 3, 2, 2, '2023-03-01', NULL),
( N'Novikov', N'Sergey', N'Mikhailovich', 1, 3, 1, '2024-05-10', NULL),
( N'Fedorova', N'Maria', N'Alekseevna', 2, 1, 3, '2022-08-20', '2025-07-15');