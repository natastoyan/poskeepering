### Подключение проекта
После подключения проекта вставить ссылку на js-библиотеку в `_Host.cshtml`
```html
<script src="_content/roads.blazor.shared/js/domUtils.js"></script>
```
### Компоненты и утилиты
##### DomPropertiesProvider
Вспомогательный класс, позволяет получить и установить различные свойства DOM, например, высоту элемента, заголовок окна и т.п. Можно использовать как сервис `services.AddScoped<DomPropertiesProvider>();` или пользоваться статическими методами, передавая экземпляр `IJSRuntime`
##### FullHeight
Компонент устанавливает высоту дочернего содержимого таким образом, чтобы оно занимало высоту, оставшуюся до нижней части окна. Использование:
```html
<FullHeight>
	<div style="height: 100%">...</div>
</FullHeight>
```
У содержимого необходимо задать высоту 100%
##### WaitIndicator
Индикатор загрузки. Подключение: `services.AddScoped<IWaitIndicatorService, WaitIndicatorService>();` Использование:
```html
 <WaitIndicator>
	 ...
</WaitIndicator>
```
```csharp
@inject IWaitIndicatorService WaitIndicatorService
	...
  await WaitIndicatorService.RunOperation(async op =>
        {
            op.Message = "Загрузка данных...";
           await ....

        });
```
Для установки высоты индикатора можно использовать свойство `Height`. В методе `RunOperation` можно менять свойство `Message` для отображения прогресса в реальном времени. Если нужно на одной странице использовать несколько независимых индикаторов, то следует задать у компонента строковое свойство `ContextKey` (установить уникальное значение в пределах страницы), а затем вызывать метод `WaitIndicatorService.RunOperation` с параметром `contextKey` с тем же значением.
##### PageTitle
Позволяет динамически установить свойство `document.title`. Использование:
```html
 <PageTitle Title="Название страницы"/>
```