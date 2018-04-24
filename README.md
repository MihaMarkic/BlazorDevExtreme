# Righthand.BlazorDevExtreme

[![NuGet](https://img.shields.io/nuget/v/Righthand.BlazorDevExtreme.svg)](https://www.nuget.org/packages/Righthand.BlazorDevExtreme)

This is a library that implements the interop between [Blazor](https://github.com/aspnet/Blazor) and [Developer Express DevExtreme library](https://github.com/DevExpress/DevExtreme). 

Per version 0.1 only initialization with options is implemented. Callbacks aren't implemented at this time, so no events from javascript to Blazor.

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
@page "/"

<h1>Hello, world!</h1>

<div id="buttonContainer"></div>

<button onclick="@InitDevExtreme">Init DevExtreme</button>

@functions {
    public void InitDevExtreme()
    {
        DxButton.Init("#buttonContainer", new DevExpress.Ui.DxButtonOptions { text = "DevExtreme Button" });
    }
}
```
Note:

* For now you have to click on the *Init DevExtreme* button to init the dxButton. That's because it is hard to understand when both jQuery and Blazor libraries are loaded.
* Clicking on dxButton does nothing since callbacks aren't yet implemented.