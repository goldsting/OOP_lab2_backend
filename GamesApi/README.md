# Привет! Я проект с играми

## Чтобы меня запустить введи `dotnet run`

|Метод|Маршрут|Описание|Статус|
|---|---|---|---|
|GET|/api/games|Получить все игры|200|
|GET|/api/games/{id}|Получить игру по id|200/404|
|POST|/api/games|Добавить игру|201|
|DELETE|/api/games/{id}|Удалить игру|204/404|

## `curl http://localhost:5122/api/games`
## `curl http://localhost:5122/api/games/1`
## `curl -X POST http://localhost:5122/api/games \-H "Content-Type: application/json" \-d "{\"title\": \"Stardew Valley\", \"genre\": \"Simulation\", \"releaseYear\": 2016}"`
## `curl -X PUT http://localhost:5122/api/games/99 \-H "Content-Type: application/json" \-d "{\"title\": \"Test\", \"genre\": \"Test\", \"releaseYear\": 2020}"`