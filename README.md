# Righthand.BlazorDevExtreme

[![NuGet](https://img.shields.io/nuget/v/Righthand.BlazorDevExtreme.svg)](https://www.nuget.org/packages/Righthand.BlazorDevExtreme)

This is a library that implements the interop between [Blazor](https://github.com/aspnet/Blazor) and [Developer Express DevExtreme library](https://github.com/DevExpress/DevExtreme). 

## IMPORTANT (3.4.2019)
I tempted to discountinue the project since DevExpress [announced](https://community.devexpress.com/blogs/aspnet/archive/2019/04/02/announcing-devexpress-ui-for-blazor-razor-components-preview.aspx) official Blazor support. Keeping this alternative doesn't make much sense anymore, even more so because it is technically very challenging. Thanks for all the comments and contribution, it has been a fun ride.

### About

Per version 0.2 initialization with options is implemented., no instance functions at this time.

Instance and static methods implemented in 0.4.

Support for server side has been added in 0.6.1.

### Callbacks

Callbacks are implemented in a simple way (no arguments except for jQuery identifier are passed).

To use callbacks, set [onEVENTNAME]Enabled property to true in options. Then bind to static event of the target class and compare the passed identifier to understand which instance fired the event. Don't forget to unsubscribe to events (within Dispose method).

### Properties with restrictions

When there is a known string restriction for a certain property, a *static class* with *const string* restrictions is created. Class name consists of  `[ClassName][PropertyName]`.

For example:
```csharp
public partial class AnimationConfig
{
    public string direction { get; set; }
}
    
public static class AnimationConfigDirection
{
   public const string Bottom = "bottom";
   public const string Left = "left";
   public const string Right = "right";
   public const string Top = "top";
}
```

## Method restrictions

Some methods have conflicting names with properties and have *Ex* appended (i.e. Values). Also some method overloads are duplicates when argument types are object types (type mismatch from typescript).

Javascript methods are postfixed with ordinal method number to avoid overloading problems.

## System requirements

Built against Blazor 0.4.

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
### Using components
```csharp
@addTagHelper *, BlazorDevExtreme
@using BlazorDevExtreme
@using BlazorDevExtreme.Components
@page "/"

<h1>Hello, DevExtreme within Blazor!</h1>

<label>Clicked count:</label>
<div>@ClickedCount</div>

<DxButton Text=@ButtonText Click=@((Action)DxButton_Click) OnClickEnabled="true" />

@functions {
    public int ClickedCount { get; set; } = 0;
    void DxButton_Click()
    {
        ClickedCount++;
        StateHasChanged();
        UiInterop.Notify($"Clicked {ClickedCount}!", "info", 5000); // displays a notification using a static method
    }
    string ButtonText => $"Was clicked {ClickedCount} times";
}
```

Notes:

* demonstrates how to create a dxButton, enabled and bind it's onClick event and change its text
* you have to explicitly enabled events with [EVENTNAME]Enabled flag (i.e. OnClickEnabled="true")

### Using interop directly

And init a dxButton with code like this.

```csharp
@using BlazorDevExtreme
@implements IDisposable
@page "/"

<h1>Hello, world!</h1>

<div id="@ButtonId" ref="target"></div>

<button onclick="@InitDevExtreme">Init DevExtreme</button>
<div></div>
<label>Clicked count:</label>
<div>@ClickedCount</div>

@functions {
	ElementRef target;
    public const string ButtonId = "buttonContainer";
    public int ClickedCount { get; set; } = 0;
    public void InitDevExtreme()
    {
    	// Init methods are async, but here is no need to await for
    	DxButton.Init(target, new DevExpress.Ui.DxButtonOptions { text = "DevExtreme Button", onClickEnabled = true });
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
