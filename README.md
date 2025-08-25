### Тестовое задание для Акцент 
## Подключение к БД
Для подключения к базе отредактируйте app.config

```
	<connectionStrings>
		<add name="DBConn" connectionString="Server=СЕРВЕР,1433;Database=БАЗА;User Id=ЛОГИН;Password=ПАРОЛЬ;" providerName="System.Data.SqlClient" />
	</connectionStrings>
```

Также можно проверить на тестовых данных -- init.sql + fill.sql
