## Практическая работа № 6
## Цель работы
Освоить принципы системного тестирования и создание автоматических тестов на C# (MSTest, XUnit).

## Выполненная работа
- Core: Validator, TariffService, TariffWithDiscount
- Тесты MSTest: ValidatorTests, TariffServiceTests, TariffWithDiscountTests
- Тесты NUnit:ValidatorTests_Converted, TariffServiceTests_Converted, TariffWithDiscountTests_Converted
- Тесты XUnit: ValidatorTests, TariffServiceTests, TariffWithDiscountTests
- Всего 26 тестов MSTest, все проходят зелёными
  скриншот в отчете.

 ## Дополнительное задание
В папке dop-zadanie находятся материалы, относящиеся к дополнительной части лабораторной работы. Данная часть 
представляет собой завершённую реализацию и тестирование системы расчёта тарифов с применением скидок.

 ## Содержимое папки dop-zadanie
В проект входят следующие компоненты:
1. Основной модуль — Core
Содержит реализацию основной бизнес-логики приложения:
Validator.cs — проверка корректности данных (например, e-mail).
TariffService.cs — расчёт базового тарифа.
TariffWithDiscount.cs — расчёт тарифа с учётом скидок.
DiscountProvider.cs — реализация интерфейса для получения размера скидки.
IDiscountProvider.cs — интерфейс поставщика скидок.

3. Тестирование на MSTest
Модуль для проверки корректности работы методов с помощью фреймворка MSTest:
ValidatorTests.cs — проверка работы валидатора.
TariffServiceTests.cs — тестирование расчёта тарифов без скидки.
TariffWithDiscountTests.cs — тестирование расчёта тарифов с учётом скидок.
Все тесты прошли успешно.

4. Тестирование на xUnit
Модуль, реализующий аналогичные проверки с использованием фреймворка xUnit:
ValidatorTests.cs
TariffServiceTests.cs
TariffWithDiscountTests.cs
Все тесты прошли успешно.

 ## Итог работы
В результате выполнения дополнительного задания были реализованы:
основные классы бизнес-логики для расчёта тарифов;
модули тестирования на двух фреймворках (MSTest и xUnit);
успешное прохождение всех тестов — 30 из 30.
