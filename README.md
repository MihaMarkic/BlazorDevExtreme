# Righthand.BlazorDevExtreme

[![NuGet](https://img.shields.io/nuget/v/Righthand.BlazorDevExtreme.svg)](https://www.nuget.org/packages/Righthand.BlazorDevExtreme)

This is a library that implements the interop between [Blazor](https://github.com/aspnet/Blazor) and [Developer Express DevExtreme library](https://github.com/DevExpress/DevExtreme). 

Per version 0.2 initialization with options is implemented., no instance functions at this time.

### Callbacks

Callbacks are implemented in a simple way (no arguments except for jQuery identifier are passed).

To use callbacks, set [onEVENTNAME]Enabled property to true in options. Then bind to static event of the target class and compare the passed identifier to understand which instance fired the event. Don't forget to unsubscribe to events (within Dispose method).

Built against Blazor 0.2.1.

## Sample usage

Include DevExtreme style sheets and javascript files
```html
<!DOCTYPE html>
<html>
<head>
<meta charset="utf-8" />
    <title>BlazorDevExtremeApp</title>
    <base href="/" />
    <link href="css/bootstrap/bootstrap.min.css" rel="stylesheet" />
    <link href="css/site.css" rel="stylesheet" />
    <!-- DevExtreme dependencies -->
    <script type="text/javascript" src="https://ajax.aspnetcdn.com/ajax/jquery/jquery-3.1.0.min.js"></script>
    <!-- DevExtreme themes -->
    <link rel="stylesheet" type="text/css" href="https://cdn3.devexpress.com/jslib/17.2.7/css/dx.common.css" />
    <link rel="stylesheet" type="text/css" href="https://cdn3.devexpress.com/jslib/17.2.7/css/dx.light.css" />
    <!-- A DevExtreme library -->
    <script type="text/javascript" src="https://cdn3.devexpress.com/jslib/17.2.7/js/dx.all.js"></script>
</head>
...
</html>
```
And init a dxButton with code like this.
```csharp
@using BlazorDevExtreme
@implements IDisposable
@page "/"

<h1>Hello, world!</h1>

<div id="@ButtonId"></div>

<button onclick="@InitDevExtreme">Init DevExtreme</button>
<div></div>
<label>Clicked count:</label>
<div>@ClickedCount</div>

@functions {
    public const string ButtonId = "buttonContainer";
    public int ClickedCount { get; set; } = 0;
    public void InitDevExtreme()
    {
        DxButton.Init($"#{ButtonId}", new DevExpress.Ui.DxButtonOptions { text = "DevExtreme Button", onClickEnabled = true });
    }
    protected override void OnInit()
    {
        DxButton.Click += DxButton_Click;
    }
    void DxButton_Click(object sender, JQueryEventArgs e)
    {
        if (e.Identifier == $"#{ButtonId}")
        {
            ClickedCount++;
            StateHasChanged();
        }
    }
    public void Dispose()
    {
        DxButton.Click -= DxButton_Click;
    }
}
```
Note:

* For now you have to click on the *Init DevExtreme* button to init the dxButton. That's because it is hard to understand when both jQuery and Blazor libraries are loaded.