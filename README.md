ContextMenuWhileSearching — BepInEx‑плагин для SPT‑AKI, реализующий вызов контекстного меню предмета в режиме обыска контейнера.

zzzzzzzzАрхитектура и особенности:
Использует Harmony‑патчи для перехвата логики отображения меню.
Конфигурация через BepInEx ConfigEntry.
Логирование через ManualLogSource для удобной отладки.
Минималистичный код без лишних зависимостей.

zzzzzzzzТехнические детали:
Целевая платформа: .NET 6.0 (IL2CPP).
Фреймворки: BepInEx, HarmonyLib.
Целевой объект патча: ItemUiContext.ShowContextMenu.

zzzzzzzzТребования:
SPT‑5.0 сервер/клиент.
BepInEx (IL2CPP).

zzzzzzzzСборка:
Откройте проект в Visual Studio или Rider.
Убедитесь, что подключены все NuGet‑пакеты (BepInEx, HarmonyLib).
Соберите проект в режиме Release.
Полученный .dll разместите в \\EscapeFromTarkov5.0\BepInEx\plugins.

zzzzzzzzЧто умеет:
Открывает контекстное меню предмета во время обыска контейнера.
Даёт полный набор действий: осмотр, установка, извлечение патронов, метки, добавление в избранное, выброс.
Позволяет включать/выключать функционал через конфиг.
Выводит логи загрузки для быстрой диагностики.

zzzzzzzzБлагодарности:
zzzNIKOzzz — автор, тестирование, сборка под SPT 5.0.0
Оригинальная идея: LetMeRightClick мод  от Lacyway (версия для SPT 4.1.6 / Mono)

zzzzzzzzЛицензия:
MIT — делай что хочешь, просто не забудь упомянуть автора.
<img width="1280" height="720" alt="fc0437f1-6ff4-4c68-bfed-f18cfa6aa752" src="https://github.com/user-attachments/assets/05dee0cb-d802-4d6d-9c3a-0c1ff0be3d5b" />
