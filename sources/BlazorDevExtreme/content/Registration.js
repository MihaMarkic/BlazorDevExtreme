const assemblyName = "BlazorDevExtreme";

// DevExpress.DataHelperMixin interop automatically generated
Blazor.registerFunction('BlazorDevExtreme.DataHelperMixin.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.DataHelperMixin.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.DataHelperMixin.GetOption', function (identifier, key) {
    let element = document.getElementById(identifier);
    return DevExpress.DataHelperMixin.getInstance(element).option(key);
});
// DevExpress.dxEvent interop automatically generated
Blazor.registerFunction('BlazorDevExtreme.DxEvent.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.dxEvent.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.DxEvent.GetOption', function (identifier, key) {
    let element = document.getElementById(identifier);
    return DevExpress.dxEvent.getInstance(element).option(key);
});
// DevExpress.localization interop automatically generated
Blazor.registerFunction('BlazorDevExtreme.Localization.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.localization.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.Localization.GetOption', function (identifier, key) {
    let element = document.getElementById(identifier);
    return DevExpress.localization.getInstance(element).option(key);
});
// DevExpress.animationPresets interop automatically generated
Blazor.registerFunction('BlazorDevExtreme.AnimationPresets.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.animationPresets.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.AnimationPresets.GetOption', function (identifier, key) {
    let element = document.getElementById(identifier);
    return DevExpress.animationPresets.getInstance(element).option(key);
});
// DevExpress.TransitionExecutor interop automatically generated
Blazor.registerFunction('BlazorDevExtreme.TransitionExecutor.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.TransitionExecutor.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.TransitionExecutor.GetOption', function (identifier, key) {
    let element = document.getElementById(identifier);
    return DevExpress.TransitionExecutor.getInstance(element).option(key);
});
// DevExpress.Component interop automatically generated
Blazor.registerFunction('BlazorDevExtreme.Component.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    if (options.onDisposingEnabled) {
        options.onDisposing = function () {
            const callback = Blazor.platform.findMethod(assemblyName, "DevExpress", "ComponentInterop", "OnDisposing");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onInitializedEnabled) {
        options.onInitialized = function () {
            const callback = Blazor.platform.findMethod(assemblyName, "DevExpress", "ComponentInterop", "OnInitialized");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onOptionChangedEnabled) {
        options.onOptionChanged = function () {
            const callback = Blazor.platform.findMethod(assemblyName, "DevExpress", "ComponentInterop", "OnOptionChanged");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    let element = document.getElementById(identifier);
    let instance = new DevExpress.Component(element, options);
});
Blazor.registerFunction('BlazorDevExtreme.Component.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.Component.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.Component.GetOption', function (identifier, key) {
    let element = document.getElementById(identifier);
    return DevExpress.Component.getInstance(element).option(key);
});
// DevExpress.DevicesObject interop automatically generated
Blazor.registerFunction('BlazorDevExtreme.DevicesObject.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.DevicesObject.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.DevicesObject.GetOption', function (identifier, key) {
    let element = document.getElementById(identifier);
    return DevExpress.DevicesObject.getInstance(element).option(key);
});
// DevExpress.DOMComponent interop automatically generated
Blazor.registerFunction('BlazorDevExtreme.DOMComponent.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    if (options.onDisposingEnabled) {
        options.onDisposing = function () {
            const callback = Blazor.platform.findMethod(assemblyName, "DevExpress", "DOMComponentInterop", "OnDisposing");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onOptionChangedEnabled) {
        options.onOptionChanged = function () {
            const callback = Blazor.platform.findMethod(assemblyName, "DevExpress", "DOMComponentInterop", "OnOptionChanged");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    let element = document.getElementById(identifier);
    let instance = new DevExpress.DOMComponent(element, options);
});
Blazor.registerFunction('BlazorDevExtreme.DOMComponent.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.DOMComponent.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.DOMComponent.GetOption', function (identifier, key) {
    let element = document.getElementById(identifier);
    return DevExpress.DOMComponent.getInstance(element).option(key);
});
// DevExpress.EndpointSelector interop automatically generated
Blazor.registerFunction('BlazorDevExtreme.EndpointSelector.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.EndpointSelector.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.EndpointSelector.GetOption', function (identifier, key) {
    let element = document.getElementById(identifier);
    return DevExpress.EndpointSelector.getInstance(element).option(key);
});
// DevExpress.validationEngine interop automatically generated
Blazor.registerFunction('BlazorDevExtreme.ValidationEngine.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.validationEngine.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.ValidationEngine.GetOption', function (identifier, key) {
    let element = document.getElementById(identifier);
    return DevExpress.validationEngine.getInstance(element).option(key);
});
// DevExpress.ui interop automatically generated
Blazor.registerFunction('BlazorDevExtreme.Ui.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.ui.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.Ui.GetOption', function (identifier, key) {
    let element = document.getElementById(identifier);
    return DevExpress.ui.getInstance(element).option(key);
});
// DevExpress.viz interop automatically generated
Blazor.registerFunction('BlazorDevExtreme.Viz.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.viz.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.Viz.GetOption', function (identifier, key) {
    let element = document.getElementById(identifier);
    return DevExpress.viz.getInstance(element).option(key);
});
// DevExpress.data.Guid interop automatically generated
Blazor.registerFunction('BlazorDevExtreme.Guid.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.data.Guid.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.Guid.GetOption', function (identifier, key) {
    let element = document.getElementById(identifier);
    return DevExpress.data.Guid.getInstance(element).option(key);
});
// DevExpress.data.Store interop automatically generated
Blazor.registerFunction('BlazorDevExtreme.Store.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    if (options.onInsertedEnabled) {
        options.onInserted = function () {
            const callback = Blazor.platform.findMethod(assemblyName, "DevExpress.Data", "StoreInterop", "OnInserted");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onInsertingEnabled) {
        options.onInserting = function () {
            const callback = Blazor.platform.findMethod(assemblyName, "DevExpress.Data", "StoreInterop", "OnInserting");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onLoadedEnabled) {
        options.onLoaded = function () {
            const callback = Blazor.platform.findMethod(assemblyName, "DevExpress.Data", "StoreInterop", "OnLoaded");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onLoadingEnabled) {
        options.onLoading = function () {
            const callback = Blazor.platform.findMethod(assemblyName, "DevExpress.Data", "StoreInterop", "OnLoading");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onModifiedEnabled) {
        options.onModified = function () {
            const callback = Blazor.platform.findMethod(assemblyName, "DevExpress.Data", "StoreInterop", "OnModified");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onModifyingEnabled) {
        options.onModifying = function () {
            const callback = Blazor.platform.findMethod(assemblyName, "DevExpress.Data", "StoreInterop", "OnModifying");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onRemovedEnabled) {
        options.onRemoved = function () {
            const callback = Blazor.platform.findMethod(assemblyName, "DevExpress.Data", "StoreInterop", "OnRemoved");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onRemovingEnabled) {
        options.onRemoving = function () {
            const callback = Blazor.platform.findMethod(assemblyName, "DevExpress.Data", "StoreInterop", "OnRemoving");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onUpdatedEnabled) {
        options.onUpdated = function () {
            const callback = Blazor.platform.findMethod(assemblyName, "DevExpress.Data", "StoreInterop", "OnUpdated");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onUpdatingEnabled) {
        options.onUpdating = function () {
            const callback = Blazor.platform.findMethod(assemblyName, "DevExpress.Data", "StoreInterop", "OnUpdating");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    let element = document.getElementById(identifier);
    let instance = new DevExpress.data.Store(element, options);
});
Blazor.registerFunction('BlazorDevExtreme.Store.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.data.Store.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.Store.GetOption', function (identifier, key) {
    let element = document.getElementById(identifier);
    return DevExpress.data.Store.getInstance(element).option(key);
});
// DevExpress.data.ArrayStore interop automatically generated
Blazor.registerFunction('BlazorDevExtreme.ArrayStore.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    let element = document.getElementById(identifier);
    let instance = new DevExpress.data.ArrayStore(element, options);
});
Blazor.registerFunction('BlazorDevExtreme.ArrayStore.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.data.ArrayStore.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.ArrayStore.GetOption', function (identifier, key) {
    let element = document.getElementById(identifier);
    return DevExpress.data.ArrayStore.getInstance(element).option(key);
});
// DevExpress.data.CustomStore interop automatically generated
Blazor.registerFunction('BlazorDevExtreme.CustomStore.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    let element = document.getElementById(identifier);
    let instance = new DevExpress.data.CustomStore(element, options);
});
Blazor.registerFunction('BlazorDevExtreme.CustomStore.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.data.CustomStore.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.CustomStore.GetOption', function (identifier, key) {
    let element = document.getElementById(identifier);
    return DevExpress.data.CustomStore.getInstance(element).option(key);
});
// DevExpress.data.DataSource interop automatically generated
Blazor.registerFunction('BlazorDevExtreme.DataSource.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    if (options.onChangedEnabled) {
        options.onChanged = function () {
            const callback = Blazor.platform.findMethod(assemblyName, "DevExpress.Data", "DataSourceInterop", "OnChanged");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onLoadErrorEnabled) {
        options.onLoadError = function () {
            const callback = Blazor.platform.findMethod(assemblyName, "DevExpress.Data", "DataSourceInterop", "OnLoadError");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onLoadingChangedEnabled) {
        options.onLoadingChanged = function () {
            const callback = Blazor.platform.findMethod(assemblyName, "DevExpress.Data", "DataSourceInterop", "OnLoadingChanged");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    let element = document.getElementById(identifier);
    let instance = new DevExpress.data.DataSource(element, options);
});
Blazor.registerFunction('BlazorDevExtreme.DataSource.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.data.DataSource.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.DataSource.GetOption', function (identifier, key) {
    let element = document.getElementById(identifier);
    return DevExpress.data.DataSource.getInstance(element).option(key);
});
// DevExpress.data.LocalStore interop automatically generated
Blazor.registerFunction('BlazorDevExtreme.LocalStore.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    let element = document.getElementById(identifier);
    let instance = new DevExpress.data.LocalStore(element, options);
});
Blazor.registerFunction('BlazorDevExtreme.LocalStore.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.data.LocalStore.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.LocalStore.GetOption', function (identifier, key) {
    let element = document.getElementById(identifier);
    return DevExpress.data.LocalStore.getInstance(element).option(key);
});
// DevExpress.data.Query interop automatically generated
Blazor.registerFunction('BlazorDevExtreme.Query.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.data.Query.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.Query.GetOption', function (identifier, key) {
    let element = document.getElementById(identifier);
    return DevExpress.data.Query.getInstance(element).option(key);
});
// DevExpress.data.ODataContext interop automatically generated
Blazor.registerFunction('BlazorDevExtreme.ODataContext.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    let element = document.getElementById(identifier);
    let instance = new DevExpress.data.ODataContext(element, options);
});
Blazor.registerFunction('BlazorDevExtreme.ODataContext.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.data.ODataContext.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.ODataContext.GetOption', function (identifier, key) {
    let element = document.getElementById(identifier);
    return DevExpress.data.ODataContext.getInstance(element).option(key);
});
// DevExpress.data.ODataStore interop automatically generated
Blazor.registerFunction('BlazorDevExtreme.ODataStore.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    if (options.onLoadingEnabled) {
        options.onLoading = function () {
            const callback = Blazor.platform.findMethod(assemblyName, "DevExpress.Data", "ODataStoreInterop", "OnLoading");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    let element = document.getElementById(identifier);
    let instance = new DevExpress.data.ODataStore(element, options);
});
Blazor.registerFunction('BlazorDevExtreme.ODataStore.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.data.ODataStore.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.ODataStore.GetOption', function (identifier, key) {
    let element = document.getElementById(identifier);
    return DevExpress.data.ODataStore.getInstance(element).option(key);
});
// DevExpress.data.EdmLiteral interop automatically generated
Blazor.registerFunction('BlazorDevExtreme.EdmLiteral.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.data.EdmLiteral.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.EdmLiteral.GetOption', function (identifier, key) {
    let element = document.getElementById(identifier);
    return DevExpress.data.EdmLiteral.getInstance(element).option(key);
});
// DevExpress.data.PivotGridDataSource interop automatically generated
Blazor.registerFunction('BlazorDevExtreme.PivotGridDataSource.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    if (options.onChangedEnabled) {
        options.onChanged = function () {
            const callback = Blazor.platform.findMethod(assemblyName, "DevExpress.Data", "PivotGridDataSourceInterop", "OnChanged");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onFieldsPreparedEnabled) {
        options.onFieldsPrepared = function () {
            const callback = Blazor.platform.findMethod(assemblyName, "DevExpress.Data", "PivotGridDataSourceInterop", "OnFieldsPrepared");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onLoadErrorEnabled) {
        options.onLoadError = function () {
            const callback = Blazor.platform.findMethod(assemblyName, "DevExpress.Data", "PivotGridDataSourceInterop", "OnLoadError");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onLoadingChangedEnabled) {
        options.onLoadingChanged = function () {
            const callback = Blazor.platform.findMethod(assemblyName, "DevExpress.Data", "PivotGridDataSourceInterop", "OnLoadingChanged");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    let element = document.getElementById(identifier);
    let instance = new DevExpress.data.PivotGridDataSource(element, options);
});
Blazor.registerFunction('BlazorDevExtreme.PivotGridDataSource.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.data.PivotGridDataSource.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.PivotGridDataSource.GetOption', function (identifier, key) {
    let element = document.getElementById(identifier);
    return DevExpress.data.PivotGridDataSource.getInstance(element).option(key);
});
// DevExpress.data.XmlaStore interop automatically generated
Blazor.registerFunction('BlazorDevExtreme.XmlaStore.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    let element = document.getElementById(identifier);
    let instance = new DevExpress.data.XmlaStore(element, options);
});
Blazor.registerFunction('BlazorDevExtreme.XmlaStore.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.data.XmlaStore.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.XmlaStore.GetOption', function (identifier, key) {
    let element = document.getElementById(identifier);
    return DevExpress.data.XmlaStore.getInstance(element).option(key);
});
// DevExpress.core.EventsMixin interop automatically generated
Blazor.registerFunction('BlazorDevExtreme.EventsMixin.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.core.EventsMixin.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.EventsMixin.GetOption', function (identifier, key) {
    let element = document.getElementById(identifier);
    return DevExpress.core.EventsMixin.getInstance(element).option(key);
});
// DevExpress.framework.dxCommand interop automatically generated
Blazor.registerFunction('BlazorDevExtreme.DxCommand.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    if (options.onExecuteEnabled) {
        options.onExecute = function () {
            const callback = Blazor.platform.findMethod(assemblyName, "DevExpress.Framework", "DxCommandInterop", "OnExecute");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    let element = document.getElementById(identifier);
    let instance = new DevExpress.framework.dxCommand(element, options);
});
Blazor.registerFunction('BlazorDevExtreme.DxCommand.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.framework.dxCommand.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.DxCommand.GetOption', function (identifier, key) {
    let element = document.getElementById(identifier);
    return DevExpress.framework.dxCommand.getInstance(element).option(key);
});
// DevExpress.framework.Router interop automatically generated
Blazor.registerFunction('BlazorDevExtreme.Router.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.framework.Router.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.Router.GetOption', function (identifier, key) {
    let element = document.getElementById(identifier);
    return DevExpress.framework.Router.getInstance(element).option(key);
});
// DevExpress.framework.StateManager interop automatically generated
Blazor.registerFunction('BlazorDevExtreme.StateManager.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    let element = document.getElementById(identifier);
    let instance = new DevExpress.framework.StateManager(element, options);
});
Blazor.registerFunction('BlazorDevExtreme.StateManager.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.framework.StateManager.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.StateManager.GetOption', function (identifier, key) {
    let element = document.getElementById(identifier);
    return DevExpress.framework.StateManager.getInstance(element).option(key);
});
// DevExpress.framework.ViewCache interop automatically generated
Blazor.registerFunction('BlazorDevExtreme.ViewCache.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.framework.ViewCache.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.ViewCache.GetOption', function (identifier, key) {
    let element = document.getElementById(identifier);
    return DevExpress.framework.ViewCache.getInstance(element).option(key);
});
// DevExpress.framework.dxCommandContainer interop automatically generated
Blazor.registerFunction('BlazorDevExtreme.DxCommandContainer.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    let element = document.getElementById(identifier);
    let instance = new DevExpress.framework.dxCommandContainer(element, options);
});
Blazor.registerFunction('BlazorDevExtreme.DxCommandContainer.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.framework.dxCommandContainer.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.DxCommandContainer.GetOption', function (identifier, key) {
    let element = document.getElementById(identifier);
    return DevExpress.framework.dxCommandContainer.getInstance(element).option(key);
});
// DevExpress.framework.dxView interop automatically generated
Blazor.registerFunction('BlazorDevExtreme.DxView.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    let element = document.getElementById(identifier);
    let instance = new DevExpress.framework.dxView(element, options);
});
Blazor.registerFunction('BlazorDevExtreme.DxView.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.framework.dxView.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.DxView.GetOption', function (identifier, key) {
    let element = document.getElementById(identifier);
    return DevExpress.framework.dxView.getInstance(element).option(key);
});
// DevExpress.framework.dxLayout interop automatically generated
Blazor.registerFunction('BlazorDevExtreme.DxLayout.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    let element = document.getElementById(identifier);
    let instance = new DevExpress.framework.dxLayout(element, options);
});
Blazor.registerFunction('BlazorDevExtreme.DxLayout.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.framework.dxLayout.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.DxLayout.GetOption', function (identifier, key) {
    let element = document.getElementById(identifier);
    return DevExpress.framework.dxLayout.getInstance(element).option(key);
});
// DevExpress.framework.dxViewPlaceholder interop automatically generated
Blazor.registerFunction('BlazorDevExtreme.DxViewPlaceholder.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    let element = document.getElementById(identifier);
    let instance = new DevExpress.framework.dxViewPlaceholder(element, options);
});
Blazor.registerFunction('BlazorDevExtreme.DxViewPlaceholder.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.framework.dxViewPlaceholder.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.DxViewPlaceholder.GetOption', function (identifier, key) {
    let element = document.getElementById(identifier);
    return DevExpress.framework.dxViewPlaceholder.getInstance(element).option(key);
});
// DevExpress.framework.dxTransition interop automatically generated
Blazor.registerFunction('BlazorDevExtreme.DxTransition.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    let element = document.getElementById(identifier);
    let instance = new DevExpress.framework.dxTransition(element, options);
});
Blazor.registerFunction('BlazorDevExtreme.DxTransition.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.framework.dxTransition.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.DxTransition.GetOption', function (identifier, key) {
    let element = document.getElementById(identifier);
    return DevExpress.framework.dxTransition.getInstance(element).option(key);
});
// DevExpress.framework.dxContentPlaceholder interop automatically generated
Blazor.registerFunction('BlazorDevExtreme.DxContentPlaceholder.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    let element = document.getElementById(identifier);
    let instance = new DevExpress.framework.dxContentPlaceholder(element, options);
});
Blazor.registerFunction('BlazorDevExtreme.DxContentPlaceholder.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.framework.dxContentPlaceholder.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.DxContentPlaceholder.GetOption', function (identifier, key) {
    let element = document.getElementById(identifier);
    return DevExpress.framework.dxContentPlaceholder.getInstance(element).option(key);
});
// DevExpress.framework.dxContent interop automatically generated
Blazor.registerFunction('BlazorDevExtreme.DxContent.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    let element = document.getElementById(identifier);
    let instance = new DevExpress.framework.dxContent(element, options);
});
Blazor.registerFunction('BlazorDevExtreme.DxContent.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.framework.dxContent.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.DxContent.GetOption', function (identifier, key) {
    let element = document.getElementById(identifier);
    return DevExpress.framework.dxContent.getInstance(element).option(key);
});
// DevExpress.framework.html.HtmlApplication interop automatically generated
Blazor.registerFunction('BlazorDevExtreme.HtmlApplication.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    let element = document.getElementById(identifier);
    let instance = new DevExpress.framework.html.HtmlApplication(element, options);
});
Blazor.registerFunction('BlazorDevExtreme.HtmlApplication.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.framework.html.HtmlApplication.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.HtmlApplication.GetOption', function (identifier, key) {
    let element = document.getElementById(identifier);
    return DevExpress.framework.html.HtmlApplication.getInstance(element).option(key);
});
// DevExpress.ui.dxAccordion interop automatically generated
Blazor.registerFunction('BlazorDevExtreme.DxAccordion.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    if (options.onItemTitleClickEnabled) {
        options.onItemTitleClick = function () {
            const callback = Blazor.platform.findMethod(assemblyName, "DevExpress.Ui", "DxAccordionInterop", "OnItemTitleClick");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    let element = document.getElementById(identifier);
    let instance = new DevExpress.ui.dxAccordion(element, options);
});
Blazor.registerFunction('BlazorDevExtreme.DxAccordion.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.ui.dxAccordion.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.DxAccordion.GetOption', function (identifier, key) {
    let element = document.getElementById(identifier);
    return DevExpress.ui.dxAccordion.getInstance(element).option(key);
});
// DevExpress.ui.dxActionSheet interop automatically generated
Blazor.registerFunction('BlazorDevExtreme.DxActionSheet.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    if (options.onCancelClickEnabled) {
        options.onCancelClick = function () {
            const callback = Blazor.platform.findMethod(assemblyName, "DevExpress.Ui", "DxActionSheetInterop", "OnCancelClick");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    let element = document.getElementById(identifier);
    let instance = new DevExpress.ui.dxActionSheet(element, options);
});
Blazor.registerFunction('BlazorDevExtreme.DxActionSheet.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.ui.dxActionSheet.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.DxActionSheet.GetOption', function (identifier, key) {
    let element = document.getElementById(identifier);
    return DevExpress.ui.dxActionSheet.getInstance(element).option(key);
});
// DevExpress.ui.dxAutocomplete interop automatically generated
Blazor.registerFunction('BlazorDevExtreme.DxAutocomplete.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    let element = document.getElementById(identifier);
    let instance = new DevExpress.ui.dxAutocomplete(element, options);
});
Blazor.registerFunction('BlazorDevExtreme.DxAutocomplete.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.ui.dxAutocomplete.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.DxAutocomplete.GetOption', function (identifier, key) {
    let element = document.getElementById(identifier);
    return DevExpress.ui.dxAutocomplete.getInstance(element).option(key);
});
// DevExpress.ui.dxBox interop automatically generated
Blazor.registerFunction('BlazorDevExtreme.DxBox.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    let element = document.getElementById(identifier);
    let instance = new DevExpress.ui.dxBox(element, options);
});
Blazor.registerFunction('BlazorDevExtreme.DxBox.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.ui.dxBox.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.DxBox.GetOption', function (identifier, key) {
    let element = document.getElementById(identifier);
    return DevExpress.ui.dxBox.getInstance(element).option(key);
});
// DevExpress.ui.dxButton interop automatically generated
Blazor.registerFunction('BlazorDevExtreme.DxButton.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    if (options.onClickEnabled) {
        options.onClick = function () {
            const callback = Blazor.platform.findMethod(assemblyName, "DevExpress.Ui", "DxButtonInterop", "OnClick");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    let element = document.getElementById(identifier);
    let instance = new DevExpress.ui.dxButton(element, options);
});
Blazor.registerFunction('BlazorDevExtreme.DxButton.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.ui.dxButton.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.DxButton.GetOption', function (identifier, key) {
    let element = document.getElementById(identifier);
    return DevExpress.ui.dxButton.getInstance(element).option(key);
});
// DevExpress.ui.dxCalendar interop automatically generated
Blazor.registerFunction('BlazorDevExtreme.DxCalendar.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    let element = document.getElementById(identifier);
    let instance = new DevExpress.ui.dxCalendar(element, options);
});
Blazor.registerFunction('BlazorDevExtreme.DxCalendar.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.ui.dxCalendar.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.DxCalendar.GetOption', function (identifier, key) {
    let element = document.getElementById(identifier);
    return DevExpress.ui.dxCalendar.getInstance(element).option(key);
});
// DevExpress.ui.dxCheckBox interop automatically generated
Blazor.registerFunction('BlazorDevExtreme.DxCheckBox.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    let element = document.getElementById(identifier);
    let instance = new DevExpress.ui.dxCheckBox(element, options);
});
Blazor.registerFunction('BlazorDevExtreme.DxCheckBox.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.ui.dxCheckBox.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.DxCheckBox.GetOption', function (identifier, key) {
    let element = document.getElementById(identifier);
    return DevExpress.ui.dxCheckBox.getInstance(element).option(key);
});
// DevExpress.ui.dxColorBox interop automatically generated
Blazor.registerFunction('BlazorDevExtreme.DxColorBox.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    let element = document.getElementById(identifier);
    let instance = new DevExpress.ui.dxColorBox(element, options);
});
Blazor.registerFunction('BlazorDevExtreme.DxColorBox.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.ui.dxColorBox.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.DxColorBox.GetOption', function (identifier, key) {
    let element = document.getElementById(identifier);
    return DevExpress.ui.dxColorBox.getInstance(element).option(key);
});
// DevExpress.ui.dxContextMenu interop automatically generated
Blazor.registerFunction('BlazorDevExtreme.DxContextMenu.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    if (options.onHiddenEnabled) {
        options.onHidden = function () {
            const callback = Blazor.platform.findMethod(assemblyName, "DevExpress.Ui", "DxContextMenuInterop", "OnHidden");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onHidingEnabled) {
        options.onHiding = function () {
            const callback = Blazor.platform.findMethod(assemblyName, "DevExpress.Ui", "DxContextMenuInterop", "OnHiding");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onPositioningEnabled) {
        options.onPositioning = function () {
            const callback = Blazor.platform.findMethod(assemblyName, "DevExpress.Ui", "DxContextMenuInterop", "OnPositioning");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onShowingEnabled) {
        options.onShowing = function () {
            const callback = Blazor.platform.findMethod(assemblyName, "DevExpress.Ui", "DxContextMenuInterop", "OnShowing");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onShownEnabled) {
        options.onShown = function () {
            const callback = Blazor.platform.findMethod(assemblyName, "DevExpress.Ui", "DxContextMenuInterop", "OnShown");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    let element = document.getElementById(identifier);
    let instance = new DevExpress.ui.dxContextMenu(element, options);
});
Blazor.registerFunction('BlazorDevExtreme.DxContextMenu.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.ui.dxContextMenu.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.DxContextMenu.GetOption', function (identifier, key) {
    let element = document.getElementById(identifier);
    return DevExpress.ui.dxContextMenu.getInstance(element).option(key);
});
// DevExpress.ui.GridBase interop automatically generated
Blazor.registerFunction('BlazorDevExtreme.GridBase.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    if (options.onAdaptiveDetailRowPreparingEnabled) {
        options.onAdaptiveDetailRowPreparing = function () {
            const callback = Blazor.platform.findMethod(assemblyName, "DevExpress.Ui", "GridBaseInterop", "OnAdaptiveDetailRowPreparing");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onDataErrorOccurredEnabled) {
        options.onDataErrorOccurred = function () {
            const callback = Blazor.platform.findMethod(assemblyName, "DevExpress.Ui", "GridBaseInterop", "OnDataErrorOccurred");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onInitNewRowEnabled) {
        options.onInitNewRow = function () {
            const callback = Blazor.platform.findMethod(assemblyName, "DevExpress.Ui", "GridBaseInterop", "OnInitNewRow");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onKeyDownEnabled) {
        options.onKeyDown = function () {
            const callback = Blazor.platform.findMethod(assemblyName, "DevExpress.Ui", "GridBaseInterop", "OnKeyDown");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onRowCollapsedEnabled) {
        options.onRowCollapsed = function () {
            const callback = Blazor.platform.findMethod(assemblyName, "DevExpress.Ui", "GridBaseInterop", "OnRowCollapsed");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onRowCollapsingEnabled) {
        options.onRowCollapsing = function () {
            const callback = Blazor.platform.findMethod(assemblyName, "DevExpress.Ui", "GridBaseInterop", "OnRowCollapsing");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onRowExpandedEnabled) {
        options.onRowExpanded = function () {
            const callback = Blazor.platform.findMethod(assemblyName, "DevExpress.Ui", "GridBaseInterop", "OnRowExpanded");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onRowExpandingEnabled) {
        options.onRowExpanding = function () {
            const callback = Blazor.platform.findMethod(assemblyName, "DevExpress.Ui", "GridBaseInterop", "OnRowExpanding");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onRowInsertedEnabled) {
        options.onRowInserted = function () {
            const callback = Blazor.platform.findMethod(assemblyName, "DevExpress.Ui", "GridBaseInterop", "OnRowInserted");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onRowInsertingEnabled) {
        options.onRowInserting = function () {
            const callback = Blazor.platform.findMethod(assemblyName, "DevExpress.Ui", "GridBaseInterop", "OnRowInserting");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onRowRemovedEnabled) {
        options.onRowRemoved = function () {
            const callback = Blazor.platform.findMethod(assemblyName, "DevExpress.Ui", "GridBaseInterop", "OnRowRemoved");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onRowRemovingEnabled) {
        options.onRowRemoving = function () {
            const callback = Blazor.platform.findMethod(assemblyName, "DevExpress.Ui", "GridBaseInterop", "OnRowRemoving");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onRowUpdatedEnabled) {
        options.onRowUpdated = function () {
            const callback = Blazor.platform.findMethod(assemblyName, "DevExpress.Ui", "GridBaseInterop", "OnRowUpdated");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onRowUpdatingEnabled) {
        options.onRowUpdating = function () {
            const callback = Blazor.platform.findMethod(assemblyName, "DevExpress.Ui", "GridBaseInterop", "OnRowUpdating");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onRowValidatingEnabled) {
        options.onRowValidating = function () {
            const callback = Blazor.platform.findMethod(assemblyName, "DevExpress.Ui", "GridBaseInterop", "OnRowValidating");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onSelectionChangedEnabled) {
        options.onSelectionChanged = function () {
            const callback = Blazor.platform.findMethod(assemblyName, "DevExpress.Ui", "GridBaseInterop", "OnSelectionChanged");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onToolbarPreparingEnabled) {
        options.onToolbarPreparing = function () {
            const callback = Blazor.platform.findMethod(assemblyName, "DevExpress.Ui", "GridBaseInterop", "OnToolbarPreparing");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    let element = document.getElementById(identifier);
    let instance = new DevExpress.ui.GridBase(element, options);
});
Blazor.registerFunction('BlazorDevExtreme.GridBase.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.ui.GridBase.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.GridBase.GetOption', function (identifier, key) {
    let element = document.getElementById(identifier);
    return DevExpress.ui.GridBase.getInstance(element).option(key);
});
// DevExpress.ui.dxDataGrid interop automatically generated
Blazor.registerFunction('BlazorDevExtreme.DxDataGrid.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    if (options.onCellClickEnabled) {
        options.onCellClick = function () {
            const callback = Blazor.platform.findMethod(assemblyName, "DevExpress.Ui", "DxDataGridInterop", "OnCellClick");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onCellHoverChangedEnabled) {
        options.onCellHoverChanged = function () {
            const callback = Blazor.platform.findMethod(assemblyName, "DevExpress.Ui", "DxDataGridInterop", "OnCellHoverChanged");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onCellPreparedEnabled) {
        options.onCellPrepared = function () {
            const callback = Blazor.platform.findMethod(assemblyName, "DevExpress.Ui", "DxDataGridInterop", "OnCellPrepared");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onContextMenuPreparingEnabled) {
        options.onContextMenuPreparing = function () {
            const callback = Blazor.platform.findMethod(assemblyName, "DevExpress.Ui", "DxDataGridInterop", "OnContextMenuPreparing");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onEditingStartEnabled) {
        options.onEditingStart = function () {
            const callback = Blazor.platform.findMethod(assemblyName, "DevExpress.Ui", "DxDataGridInterop", "OnEditingStart");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onEditorPreparedEnabled) {
        options.onEditorPrepared = function () {
            const callback = Blazor.platform.findMethod(assemblyName, "DevExpress.Ui", "DxDataGridInterop", "OnEditorPrepared");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onEditorPreparingEnabled) {
        options.onEditorPreparing = function () {
            const callback = Blazor.platform.findMethod(assemblyName, "DevExpress.Ui", "DxDataGridInterop", "OnEditorPreparing");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onExportedEnabled) {
        options.onExported = function () {
            const callback = Blazor.platform.findMethod(assemblyName, "DevExpress.Ui", "DxDataGridInterop", "OnExported");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onExportingEnabled) {
        options.onExporting = function () {
            const callback = Blazor.platform.findMethod(assemblyName, "DevExpress.Ui", "DxDataGridInterop", "OnExporting");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onFileSavingEnabled) {
        options.onFileSaving = function () {
            const callback = Blazor.platform.findMethod(assemblyName, "DevExpress.Ui", "DxDataGridInterop", "OnFileSaving");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onRowClickEnabled) {
        options.onRowClick = function () {
            const callback = Blazor.platform.findMethod(assemblyName, "DevExpress.Ui", "DxDataGridInterop", "OnRowClick");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onRowPreparedEnabled) {
        options.onRowPrepared = function () {
            const callback = Blazor.platform.findMethod(assemblyName, "DevExpress.Ui", "DxDataGridInterop", "OnRowPrepared");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    let element = document.getElementById(identifier);
    let instance = new DevExpress.ui.dxDataGrid(element, options);
});
Blazor.registerFunction('BlazorDevExtreme.DxDataGrid.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.ui.dxDataGrid.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.DxDataGrid.GetOption', function (identifier, key) {
    let element = document.getElementById(identifier);
    return DevExpress.ui.dxDataGrid.getInstance(element).option(key);
});
// DevExpress.ui.dxDateBox interop automatically generated
Blazor.registerFunction('BlazorDevExtreme.DxDateBox.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    let element = document.getElementById(identifier);
    let instance = new DevExpress.ui.dxDateBox(element, options);
});
Blazor.registerFunction('BlazorDevExtreme.DxDateBox.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.ui.dxDateBox.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.DxDateBox.GetOption', function (identifier, key) {
    let element = document.getElementById(identifier);
    return DevExpress.ui.dxDateBox.getInstance(element).option(key);
});
// DevExpress.ui.dxDeferRendering interop automatically generated
Blazor.registerFunction('BlazorDevExtreme.DxDeferRendering.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    if (options.onRenderedEnabled) {
        options.onRendered = function () {
            const callback = Blazor.platform.findMethod(assemblyName, "DevExpress.Ui", "DxDeferRenderingInterop", "OnRendered");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onShownEnabled) {
        options.onShown = function () {
            const callback = Blazor.platform.findMethod(assemblyName, "DevExpress.Ui", "DxDeferRenderingInterop", "OnShown");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    let element = document.getElementById(identifier);
    let instance = new DevExpress.ui.dxDeferRendering(element, options);
});
Blazor.registerFunction('BlazorDevExtreme.DxDeferRendering.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.ui.dxDeferRendering.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.DxDeferRendering.GetOption', function (identifier, key) {
    let element = document.getElementById(identifier);
    return DevExpress.ui.dxDeferRendering.getInstance(element).option(key);
});
// DevExpress.ui.dxDropDownBox interop automatically generated
Blazor.registerFunction('BlazorDevExtreme.DxDropDownBox.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    let element = document.getElementById(identifier);
    let instance = new DevExpress.ui.dxDropDownBox(element, options);
});
Blazor.registerFunction('BlazorDevExtreme.DxDropDownBox.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.ui.dxDropDownBox.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.DxDropDownBox.GetOption', function (identifier, key) {
    let element = document.getElementById(identifier);
    return DevExpress.ui.dxDropDownBox.getInstance(element).option(key);
});
// DevExpress.ui.dxDropDownMenu interop automatically generated
Blazor.registerFunction('BlazorDevExtreme.DxDropDownMenu.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    if (options.onButtonClickEnabled) {
        options.onButtonClick = function () {
            const callback = Blazor.platform.findMethod(assemblyName, "DevExpress.Ui", "DxDropDownMenuInterop", "OnButtonClick");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onItemClickEnabled) {
        options.onItemClick = function () {
            const callback = Blazor.platform.findMethod(assemblyName, "DevExpress.Ui", "DxDropDownMenuInterop", "OnItemClick");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    let element = document.getElementById(identifier);
    let instance = new DevExpress.ui.dxDropDownMenu(element, options);
});
Blazor.registerFunction('BlazorDevExtreme.DxDropDownMenu.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.ui.dxDropDownMenu.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.DxDropDownMenu.GetOption', function (identifier, key) {
    let element = document.getElementById(identifier);
    return DevExpress.ui.dxDropDownMenu.getInstance(element).option(key);
});
// DevExpress.ui.dxFileUploader interop automatically generated
Blazor.registerFunction('BlazorDevExtreme.DxFileUploader.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    if (options.onProgressEnabled) {
        options.onProgress = function () {
            const callback = Blazor.platform.findMethod(assemblyName, "DevExpress.Ui", "DxFileUploaderInterop", "OnProgress");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onUploadAbortedEnabled) {
        options.onUploadAborted = function () {
            const callback = Blazor.platform.findMethod(assemblyName, "DevExpress.Ui", "DxFileUploaderInterop", "OnUploadAborted");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onUploadedEnabled) {
        options.onUploaded = function () {
            const callback = Blazor.platform.findMethod(assemblyName, "DevExpress.Ui", "DxFileUploaderInterop", "OnUploaded");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onUploadErrorEnabled) {
        options.onUploadError = function () {
            const callback = Blazor.platform.findMethod(assemblyName, "DevExpress.Ui", "DxFileUploaderInterop", "OnUploadError");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onUploadStartedEnabled) {
        options.onUploadStarted = function () {
            const callback = Blazor.platform.findMethod(assemblyName, "DevExpress.Ui", "DxFileUploaderInterop", "OnUploadStarted");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onValueChangedEnabled) {
        options.onValueChanged = function () {
            const callback = Blazor.platform.findMethod(assemblyName, "DevExpress.Ui", "DxFileUploaderInterop", "OnValueChanged");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    let element = document.getElementById(identifier);
    let instance = new DevExpress.ui.dxFileUploader(element, options);
});
Blazor.registerFunction('BlazorDevExtreme.DxFileUploader.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.ui.dxFileUploader.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.DxFileUploader.GetOption', function (identifier, key) {
    let element = document.getElementById(identifier);
    return DevExpress.ui.dxFileUploader.getInstance(element).option(key);
});
// DevExpress.ui.dxFilterBuilder interop automatically generated
Blazor.registerFunction('BlazorDevExtreme.DxFilterBuilder.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    if (options.onEditorPreparedEnabled) {
        options.onEditorPrepared = function () {
            const callback = Blazor.platform.findMethod(assemblyName, "DevExpress.Ui", "DxFilterBuilderInterop", "OnEditorPrepared");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onEditorPreparingEnabled) {
        options.onEditorPreparing = function () {
            const callback = Blazor.platform.findMethod(assemblyName, "DevExpress.Ui", "DxFilterBuilderInterop", "OnEditorPreparing");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onValueChangedEnabled) {
        options.onValueChanged = function () {
            const callback = Blazor.platform.findMethod(assemblyName, "DevExpress.Ui", "DxFilterBuilderInterop", "OnValueChanged");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    let element = document.getElementById(identifier);
    let instance = new DevExpress.ui.dxFilterBuilder(element, options);
});
Blazor.registerFunction('BlazorDevExtreme.DxFilterBuilder.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.ui.dxFilterBuilder.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.DxFilterBuilder.GetOption', function (identifier, key) {
    let element = document.getElementById(identifier);
    return DevExpress.ui.dxFilterBuilder.getInstance(element).option(key);
});
// DevExpress.ui.dxForm interop automatically generated
Blazor.registerFunction('BlazorDevExtreme.DxForm.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    if (options.onEditorEnterKeyEnabled) {
        options.onEditorEnterKey = function () {
            const callback = Blazor.platform.findMethod(assemblyName, "DevExpress.Ui", "DxFormInterop", "OnEditorEnterKey");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onFieldDataChangedEnabled) {
        options.onFieldDataChanged = function () {
            const callback = Blazor.platform.findMethod(assemblyName, "DevExpress.Ui", "DxFormInterop", "OnFieldDataChanged");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    let element = document.getElementById(identifier);
    let instance = new DevExpress.ui.dxForm(element, options);
});
Blazor.registerFunction('BlazorDevExtreme.DxForm.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.ui.dxForm.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.DxForm.GetOption', function (identifier, key) {
    let element = document.getElementById(identifier);
    return DevExpress.ui.dxForm.getInstance(element).option(key);
});
// DevExpress.ui.dxGallery interop automatically generated
Blazor.registerFunction('BlazorDevExtreme.DxGallery.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    let element = document.getElementById(identifier);
    let instance = new DevExpress.ui.dxGallery(element, options);
});
Blazor.registerFunction('BlazorDevExtreme.DxGallery.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.ui.dxGallery.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.DxGallery.GetOption', function (identifier, key) {
    let element = document.getElementById(identifier);
    return DevExpress.ui.dxGallery.getInstance(element).option(key);
});
// DevExpress.ui.dxList interop automatically generated
Blazor.registerFunction('BlazorDevExtreme.DxList.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    if (options.onGroupRenderedEnabled) {
        options.onGroupRendered = function () {
            const callback = Blazor.platform.findMethod(assemblyName, "DevExpress.Ui", "DxListInterop", "OnGroupRendered");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onItemClickEnabled) {
        options.onItemClick = function () {
            const callback = Blazor.platform.findMethod(assemblyName, "DevExpress.Ui", "DxListInterop", "OnItemClick");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onItemContextMenuEnabled) {
        options.onItemContextMenu = function () {
            const callback = Blazor.platform.findMethod(assemblyName, "DevExpress.Ui", "DxListInterop", "OnItemContextMenu");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onItemDeletedEnabled) {
        options.onItemDeleted = function () {
            const callback = Blazor.platform.findMethod(assemblyName, "DevExpress.Ui", "DxListInterop", "OnItemDeleted");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onItemDeletingEnabled) {
        options.onItemDeleting = function () {
            const callback = Blazor.platform.findMethod(assemblyName, "DevExpress.Ui", "DxListInterop", "OnItemDeleting");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onItemHoldEnabled) {
        options.onItemHold = function () {
            const callback = Blazor.platform.findMethod(assemblyName, "DevExpress.Ui", "DxListInterop", "OnItemHold");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onItemReorderedEnabled) {
        options.onItemReordered = function () {
            const callback = Blazor.platform.findMethod(assemblyName, "DevExpress.Ui", "DxListInterop", "OnItemReordered");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onItemSwipeEnabled) {
        options.onItemSwipe = function () {
            const callback = Blazor.platform.findMethod(assemblyName, "DevExpress.Ui", "DxListInterop", "OnItemSwipe");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onPageLoadingEnabled) {
        options.onPageLoading = function () {
            const callback = Blazor.platform.findMethod(assemblyName, "DevExpress.Ui", "DxListInterop", "OnPageLoading");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onPullRefreshEnabled) {
        options.onPullRefresh = function () {
            const callback = Blazor.platform.findMethod(assemblyName, "DevExpress.Ui", "DxListInterop", "OnPullRefresh");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onScrollEnabled) {
        options.onScroll = function () {
            const callback = Blazor.platform.findMethod(assemblyName, "DevExpress.Ui", "DxListInterop", "OnScroll");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onSelectAllValueChangedEnabled) {
        options.onSelectAllValueChanged = function () {
            const callback = Blazor.platform.findMethod(assemblyName, "DevExpress.Ui", "DxListInterop", "OnSelectAllValueChanged");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    let element = document.getElementById(identifier);
    let instance = new DevExpress.ui.dxList(element, options);
});
Blazor.registerFunction('BlazorDevExtreme.DxList.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.ui.dxList.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.DxList.GetOption', function (identifier, key) {
    let element = document.getElementById(identifier);
    return DevExpress.ui.dxList.getInstance(element).option(key);
});
// DevExpress.ui.dxLoadIndicator interop automatically generated
Blazor.registerFunction('BlazorDevExtreme.DxLoadIndicator.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    let element = document.getElementById(identifier);
    let instance = new DevExpress.ui.dxLoadIndicator(element, options);
});
Blazor.registerFunction('BlazorDevExtreme.DxLoadIndicator.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.ui.dxLoadIndicator.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.DxLoadIndicator.GetOption', function (identifier, key) {
    let element = document.getElementById(identifier);
    return DevExpress.ui.dxLoadIndicator.getInstance(element).option(key);
});
// DevExpress.ui.dxLoadPanel interop automatically generated
Blazor.registerFunction('BlazorDevExtreme.DxLoadPanel.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    let element = document.getElementById(identifier);
    let instance = new DevExpress.ui.dxLoadPanel(element, options);
});
Blazor.registerFunction('BlazorDevExtreme.DxLoadPanel.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.ui.dxLoadPanel.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.DxLoadPanel.GetOption', function (identifier, key) {
    let element = document.getElementById(identifier);
    return DevExpress.ui.dxLoadPanel.getInstance(element).option(key);
});
// DevExpress.ui.dxLookup interop automatically generated
Blazor.registerFunction('BlazorDevExtreme.DxLookup.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    if (options.onPageLoadingEnabled) {
        options.onPageLoading = function () {
            const callback = Blazor.platform.findMethod(assemblyName, "DevExpress.Ui", "DxLookupInterop", "OnPageLoading");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onPullRefreshEnabled) {
        options.onPullRefresh = function () {
            const callback = Blazor.platform.findMethod(assemblyName, "DevExpress.Ui", "DxLookupInterop", "OnPullRefresh");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onScrollEnabled) {
        options.onScroll = function () {
            const callback = Blazor.platform.findMethod(assemblyName, "DevExpress.Ui", "DxLookupInterop", "OnScroll");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onTitleRenderedEnabled) {
        options.onTitleRendered = function () {
            const callback = Blazor.platform.findMethod(assemblyName, "DevExpress.Ui", "DxLookupInterop", "OnTitleRendered");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onValueChangedEnabled) {
        options.onValueChanged = function () {
            const callback = Blazor.platform.findMethod(assemblyName, "DevExpress.Ui", "DxLookupInterop", "OnValueChanged");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    let element = document.getElementById(identifier);
    let instance = new DevExpress.ui.dxLookup(element, options);
});
Blazor.registerFunction('BlazorDevExtreme.DxLookup.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.ui.dxLookup.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.DxLookup.GetOption', function (identifier, key) {
    let element = document.getElementById(identifier);
    return DevExpress.ui.dxLookup.getInstance(element).option(key);
});
// DevExpress.ui.dxMap interop automatically generated
Blazor.registerFunction('BlazorDevExtreme.DxMap.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    if (options.onClickEnabled) {
        options.onClick = function () {
            const callback = Blazor.platform.findMethod(assemblyName, "DevExpress.Ui", "DxMapInterop", "OnClick");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onMarkerAddedEnabled) {
        options.onMarkerAdded = function () {
            const callback = Blazor.platform.findMethod(assemblyName, "DevExpress.Ui", "DxMapInterop", "OnMarkerAdded");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onMarkerRemovedEnabled) {
        options.onMarkerRemoved = function () {
            const callback = Blazor.platform.findMethod(assemblyName, "DevExpress.Ui", "DxMapInterop", "OnMarkerRemoved");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onReadyEnabled) {
        options.onReady = function () {
            const callback = Blazor.platform.findMethod(assemblyName, "DevExpress.Ui", "DxMapInterop", "OnReady");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onRouteAddedEnabled) {
        options.onRouteAdded = function () {
            const callback = Blazor.platform.findMethod(assemblyName, "DevExpress.Ui", "DxMapInterop", "OnRouteAdded");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onRouteRemovedEnabled) {
        options.onRouteRemoved = function () {
            const callback = Blazor.platform.findMethod(assemblyName, "DevExpress.Ui", "DxMapInterop", "OnRouteRemoved");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    let element = document.getElementById(identifier);
    let instance = new DevExpress.ui.dxMap(element, options);
});
Blazor.registerFunction('BlazorDevExtreme.DxMap.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.ui.dxMap.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.DxMap.GetOption', function (identifier, key) {
    let element = document.getElementById(identifier);
    return DevExpress.ui.dxMap.getInstance(element).option(key);
});
// DevExpress.ui.dxMenu interop automatically generated
Blazor.registerFunction('BlazorDevExtreme.DxMenu.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    if (options.onSubmenuHiddenEnabled) {
        options.onSubmenuHidden = function () {
            const callback = Blazor.platform.findMethod(assemblyName, "DevExpress.Ui", "DxMenuInterop", "OnSubmenuHidden");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onSubmenuHidingEnabled) {
        options.onSubmenuHiding = function () {
            const callback = Blazor.platform.findMethod(assemblyName, "DevExpress.Ui", "DxMenuInterop", "OnSubmenuHiding");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onSubmenuShowingEnabled) {
        options.onSubmenuShowing = function () {
            const callback = Blazor.platform.findMethod(assemblyName, "DevExpress.Ui", "DxMenuInterop", "OnSubmenuShowing");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onSubmenuShownEnabled) {
        options.onSubmenuShown = function () {
            const callback = Blazor.platform.findMethod(assemblyName, "DevExpress.Ui", "DxMenuInterop", "OnSubmenuShown");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    let element = document.getElementById(identifier);
    let instance = new DevExpress.ui.dxMenu(element, options);
});
Blazor.registerFunction('BlazorDevExtreme.DxMenu.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.ui.dxMenu.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.DxMenu.GetOption', function (identifier, key) {
    let element = document.getElementById(identifier);
    return DevExpress.ui.dxMenu.getInstance(element).option(key);
});
// DevExpress.ui.dxMultiView interop automatically generated
Blazor.registerFunction('BlazorDevExtreme.DxMultiView.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    let element = document.getElementById(identifier);
    let instance = new DevExpress.ui.dxMultiView(element, options);
});
Blazor.registerFunction('BlazorDevExtreme.DxMultiView.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.ui.dxMultiView.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.DxMultiView.GetOption', function (identifier, key) {
    let element = document.getElementById(identifier);
    return DevExpress.ui.dxMultiView.getInstance(element).option(key);
});
// DevExpress.ui.dxNavBar interop automatically generated
Blazor.registerFunction('BlazorDevExtreme.DxNavBar.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    let element = document.getElementById(identifier);
    let instance = new DevExpress.ui.dxNavBar(element, options);
});
Blazor.registerFunction('BlazorDevExtreme.DxNavBar.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.ui.dxNavBar.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.DxNavBar.GetOption', function (identifier, key) {
    let element = document.getElementById(identifier);
    return DevExpress.ui.dxNavBar.getInstance(element).option(key);
});
// DevExpress.ui.dxNumberBox interop automatically generated
Blazor.registerFunction('BlazorDevExtreme.DxNumberBox.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    let element = document.getElementById(identifier);
    let instance = new DevExpress.ui.dxNumberBox(element, options);
});
Blazor.registerFunction('BlazorDevExtreme.DxNumberBox.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.ui.dxNumberBox.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.DxNumberBox.GetOption', function (identifier, key) {
    let element = document.getElementById(identifier);
    return DevExpress.ui.dxNumberBox.getInstance(element).option(key);
});
// DevExpress.ui.dxOverlay interop automatically generated
Blazor.registerFunction('BlazorDevExtreme.DxOverlay.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    if (options.onHiddenEnabled) {
        options.onHidden = function () {
            const callback = Blazor.platform.findMethod(assemblyName, "DevExpress.Ui", "DxOverlayInterop", "OnHidden");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onHidingEnabled) {
        options.onHiding = function () {
            const callback = Blazor.platform.findMethod(assemblyName, "DevExpress.Ui", "DxOverlayInterop", "OnHiding");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onShowingEnabled) {
        options.onShowing = function () {
            const callback = Blazor.platform.findMethod(assemblyName, "DevExpress.Ui", "DxOverlayInterop", "OnShowing");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onShownEnabled) {
        options.onShown = function () {
            const callback = Blazor.platform.findMethod(assemblyName, "DevExpress.Ui", "DxOverlayInterop", "OnShown");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    let element = document.getElementById(identifier);
    let instance = new DevExpress.ui.dxOverlay(element, options);
});
Blazor.registerFunction('BlazorDevExtreme.DxOverlay.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.ui.dxOverlay.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.DxOverlay.GetOption', function (identifier, key) {
    let element = document.getElementById(identifier);
    return DevExpress.ui.dxOverlay.getInstance(element).option(key);
});
// DevExpress.ui.dxPanorama interop automatically generated
Blazor.registerFunction('BlazorDevExtreme.DxPanorama.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    let element = document.getElementById(identifier);
    let instance = new DevExpress.ui.dxPanorama(element, options);
});
Blazor.registerFunction('BlazorDevExtreme.DxPanorama.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.ui.dxPanorama.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.DxPanorama.GetOption', function (identifier, key) {
    let element = document.getElementById(identifier);
    return DevExpress.ui.dxPanorama.getInstance(element).option(key);
});
// DevExpress.ui.dxPivot interop automatically generated
Blazor.registerFunction('BlazorDevExtreme.DxPivot.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    let element = document.getElementById(identifier);
    let instance = new DevExpress.ui.dxPivot(element, options);
});
Blazor.registerFunction('BlazorDevExtreme.DxPivot.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.ui.dxPivot.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.DxPivot.GetOption', function (identifier, key) {
    let element = document.getElementById(identifier);
    return DevExpress.ui.dxPivot.getInstance(element).option(key);
});
// DevExpress.ui.dxPivotGrid interop automatically generated
Blazor.registerFunction('BlazorDevExtreme.DxPivotGrid.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    if (options.onCellClickEnabled) {
        options.onCellClick = function () {
            const callback = Blazor.platform.findMethod(assemblyName, "DevExpress.Ui", "DxPivotGridInterop", "OnCellClick");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onCellPreparedEnabled) {
        options.onCellPrepared = function () {
            const callback = Blazor.platform.findMethod(assemblyName, "DevExpress.Ui", "DxPivotGridInterop", "OnCellPrepared");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onContextMenuPreparingEnabled) {
        options.onContextMenuPreparing = function () {
            const callback = Blazor.platform.findMethod(assemblyName, "DevExpress.Ui", "DxPivotGridInterop", "OnContextMenuPreparing");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onExportedEnabled) {
        options.onExported = function () {
            const callback = Blazor.platform.findMethod(assemblyName, "DevExpress.Ui", "DxPivotGridInterop", "OnExported");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onExportingEnabled) {
        options.onExporting = function () {
            const callback = Blazor.platform.findMethod(assemblyName, "DevExpress.Ui", "DxPivotGridInterop", "OnExporting");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onFileSavingEnabled) {
        options.onFileSaving = function () {
            const callback = Blazor.platform.findMethod(assemblyName, "DevExpress.Ui", "DxPivotGridInterop", "OnFileSaving");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    let element = document.getElementById(identifier);
    let instance = new DevExpress.ui.dxPivotGrid(element, options);
});
Blazor.registerFunction('BlazorDevExtreme.DxPivotGrid.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.ui.dxPivotGrid.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.DxPivotGrid.GetOption', function (identifier, key) {
    let element = document.getElementById(identifier);
    return DevExpress.ui.dxPivotGrid.getInstance(element).option(key);
});
// DevExpress.ui.dxPivotGridFieldChooser interop automatically generated
Blazor.registerFunction('BlazorDevExtreme.DxPivotGridFieldChooser.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    if (options.onContextMenuPreparingEnabled) {
        options.onContextMenuPreparing = function () {
            const callback = Blazor.platform.findMethod(assemblyName, "DevExpress.Ui", "DxPivotGridFieldChooserInterop", "OnContextMenuPreparing");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    let element = document.getElementById(identifier);
    let instance = new DevExpress.ui.dxPivotGridFieldChooser(element, options);
});
Blazor.registerFunction('BlazorDevExtreme.DxPivotGridFieldChooser.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.ui.dxPivotGridFieldChooser.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.DxPivotGridFieldChooser.GetOption', function (identifier, key) {
    let element = document.getElementById(identifier);
    return DevExpress.ui.dxPivotGridFieldChooser.getInstance(element).option(key);
});
// DevExpress.ui.dxPopover interop automatically generated
Blazor.registerFunction('BlazorDevExtreme.DxPopover.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    let element = document.getElementById(identifier);
    let instance = new DevExpress.ui.dxPopover(element, options);
});
Blazor.registerFunction('BlazorDevExtreme.DxPopover.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.ui.dxPopover.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.DxPopover.GetOption', function (identifier, key) {
    let element = document.getElementById(identifier);
    return DevExpress.ui.dxPopover.getInstance(element).option(key);
});
// DevExpress.ui.dxPopup interop automatically generated
Blazor.registerFunction('BlazorDevExtreme.DxPopup.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    if (options.onResizeEnabled) {
        options.onResize = function () {
            const callback = Blazor.platform.findMethod(assemblyName, "DevExpress.Ui", "DxPopupInterop", "OnResize");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onResizeEndEnabled) {
        options.onResizeEnd = function () {
            const callback = Blazor.platform.findMethod(assemblyName, "DevExpress.Ui", "DxPopupInterop", "OnResizeEnd");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onResizeStartEnabled) {
        options.onResizeStart = function () {
            const callback = Blazor.platform.findMethod(assemblyName, "DevExpress.Ui", "DxPopupInterop", "OnResizeStart");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onTitleRenderedEnabled) {
        options.onTitleRendered = function () {
            const callback = Blazor.platform.findMethod(assemblyName, "DevExpress.Ui", "DxPopupInterop", "OnTitleRendered");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    let element = document.getElementById(identifier);
    let instance = new DevExpress.ui.dxPopup(element, options);
});
Blazor.registerFunction('BlazorDevExtreme.DxPopup.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.ui.dxPopup.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.DxPopup.GetOption', function (identifier, key) {
    let element = document.getElementById(identifier);
    return DevExpress.ui.dxPopup.getInstance(element).option(key);
});
// DevExpress.ui.dxProgressBar interop automatically generated
Blazor.registerFunction('BlazorDevExtreme.DxProgressBar.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    if (options.onCompleteEnabled) {
        options.onComplete = function () {
            const callback = Blazor.platform.findMethod(assemblyName, "DevExpress.Ui", "DxProgressBarInterop", "OnComplete");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    let element = document.getElementById(identifier);
    let instance = new DevExpress.ui.dxProgressBar(element, options);
});
Blazor.registerFunction('BlazorDevExtreme.DxProgressBar.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.ui.dxProgressBar.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.DxProgressBar.GetOption', function (identifier, key) {
    let element = document.getElementById(identifier);
    return DevExpress.ui.dxProgressBar.getInstance(element).option(key);
});
// DevExpress.ui.dxRadioGroup interop automatically generated
Blazor.registerFunction('BlazorDevExtreme.DxRadioGroup.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    let element = document.getElementById(identifier);
    let instance = new DevExpress.ui.dxRadioGroup(element, options);
});
Blazor.registerFunction('BlazorDevExtreme.DxRadioGroup.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.ui.dxRadioGroup.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.DxRadioGroup.GetOption', function (identifier, key) {
    let element = document.getElementById(identifier);
    return DevExpress.ui.dxRadioGroup.getInstance(element).option(key);
});
// DevExpress.ui.dxRangeSlider interop automatically generated
Blazor.registerFunction('BlazorDevExtreme.DxRangeSlider.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    if (options.onValueChangedEnabled) {
        options.onValueChanged = function () {
            const callback = Blazor.platform.findMethod(assemblyName, "DevExpress.Ui", "DxRangeSliderInterop", "OnValueChanged");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    let element = document.getElementById(identifier);
    let instance = new DevExpress.ui.dxRangeSlider(element, options);
});
Blazor.registerFunction('BlazorDevExtreme.DxRangeSlider.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.ui.dxRangeSlider.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.DxRangeSlider.GetOption', function (identifier, key) {
    let element = document.getElementById(identifier);
    return DevExpress.ui.dxRangeSlider.getInstance(element).option(key);
});
// DevExpress.ui.dxResizable interop automatically generated
Blazor.registerFunction('BlazorDevExtreme.DxResizable.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    if (options.onResizeEnabled) {
        options.onResize = function () {
            const callback = Blazor.platform.findMethod(assemblyName, "DevExpress.Ui", "DxResizableInterop", "OnResize");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onResizeEndEnabled) {
        options.onResizeEnd = function () {
            const callback = Blazor.platform.findMethod(assemblyName, "DevExpress.Ui", "DxResizableInterop", "OnResizeEnd");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onResizeStartEnabled) {
        options.onResizeStart = function () {
            const callback = Blazor.platform.findMethod(assemblyName, "DevExpress.Ui", "DxResizableInterop", "OnResizeStart");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    let element = document.getElementById(identifier);
    let instance = new DevExpress.ui.dxResizable(element, options);
});
Blazor.registerFunction('BlazorDevExtreme.DxResizable.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.ui.dxResizable.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.DxResizable.GetOption', function (identifier, key) {
    let element = document.getElementById(identifier);
    return DevExpress.ui.dxResizable.getInstance(element).option(key);
});
// DevExpress.ui.dxResponsiveBox interop automatically generated
Blazor.registerFunction('BlazorDevExtreme.DxResponsiveBox.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    let element = document.getElementById(identifier);
    let instance = new DevExpress.ui.dxResponsiveBox(element, options);
});
Blazor.registerFunction('BlazorDevExtreme.DxResponsiveBox.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.ui.dxResponsiveBox.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.DxResponsiveBox.GetOption', function (identifier, key) {
    let element = document.getElementById(identifier);
    return DevExpress.ui.dxResponsiveBox.getInstance(element).option(key);
});
// DevExpress.ui.dxScheduler interop automatically generated
Blazor.registerFunction('BlazorDevExtreme.DxScheduler.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    if (options.onAppointmentAddedEnabled) {
        options.onAppointmentAdded = function () {
            const callback = Blazor.platform.findMethod(assemblyName, "DevExpress.Ui", "DxSchedulerInterop", "OnAppointmentAdded");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onAppointmentAddingEnabled) {
        options.onAppointmentAdding = function () {
            const callback = Blazor.platform.findMethod(assemblyName, "DevExpress.Ui", "DxSchedulerInterop", "OnAppointmentAdding");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onAppointmentClickEnabled) {
        options.onAppointmentClick = function () {
            const callback = Blazor.platform.findMethod(assemblyName, "DevExpress.Ui", "DxSchedulerInterop", "OnAppointmentClick");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onAppointmentContextMenuEnabled) {
        options.onAppointmentContextMenu = function () {
            const callback = Blazor.platform.findMethod(assemblyName, "DevExpress.Ui", "DxSchedulerInterop", "OnAppointmentContextMenu");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onAppointmentDblClickEnabled) {
        options.onAppointmentDblClick = function () {
            const callback = Blazor.platform.findMethod(assemblyName, "DevExpress.Ui", "DxSchedulerInterop", "OnAppointmentDblClick");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onAppointmentDeletedEnabled) {
        options.onAppointmentDeleted = function () {
            const callback = Blazor.platform.findMethod(assemblyName, "DevExpress.Ui", "DxSchedulerInterop", "OnAppointmentDeleted");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onAppointmentDeletingEnabled) {
        options.onAppointmentDeleting = function () {
            const callback = Blazor.platform.findMethod(assemblyName, "DevExpress.Ui", "DxSchedulerInterop", "OnAppointmentDeleting");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onAppointmentFormCreatedEnabled) {
        options.onAppointmentFormCreated = function () {
            const callback = Blazor.platform.findMethod(assemblyName, "DevExpress.Ui", "DxSchedulerInterop", "OnAppointmentFormCreated");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onAppointmentRenderedEnabled) {
        options.onAppointmentRendered = function () {
            const callback = Blazor.platform.findMethod(assemblyName, "DevExpress.Ui", "DxSchedulerInterop", "OnAppointmentRendered");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onAppointmentUpdatedEnabled) {
        options.onAppointmentUpdated = function () {
            const callback = Blazor.platform.findMethod(assemblyName, "DevExpress.Ui", "DxSchedulerInterop", "OnAppointmentUpdated");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onAppointmentUpdatingEnabled) {
        options.onAppointmentUpdating = function () {
            const callback = Blazor.platform.findMethod(assemblyName, "DevExpress.Ui", "DxSchedulerInterop", "OnAppointmentUpdating");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onCellClickEnabled) {
        options.onCellClick = function () {
            const callback = Blazor.platform.findMethod(assemblyName, "DevExpress.Ui", "DxSchedulerInterop", "OnCellClick");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onCellContextMenuEnabled) {
        options.onCellContextMenu = function () {
            const callback = Blazor.platform.findMethod(assemblyName, "DevExpress.Ui", "DxSchedulerInterop", "OnCellContextMenu");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    let element = document.getElementById(identifier);
    let instance = new DevExpress.ui.dxScheduler(element, options);
});
Blazor.registerFunction('BlazorDevExtreme.DxScheduler.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.ui.dxScheduler.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.DxScheduler.GetOption', function (identifier, key) {
    let element = document.getElementById(identifier);
    return DevExpress.ui.dxScheduler.getInstance(element).option(key);
});
// DevExpress.ui.dxScrollView interop automatically generated
Blazor.registerFunction('BlazorDevExtreme.DxScrollView.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    if (options.onPullDownEnabled) {
        options.onPullDown = function () {
            const callback = Blazor.platform.findMethod(assemblyName, "DevExpress.Ui", "DxScrollViewInterop", "OnPullDown");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onReachBottomEnabled) {
        options.onReachBottom = function () {
            const callback = Blazor.platform.findMethod(assemblyName, "DevExpress.Ui", "DxScrollViewInterop", "OnReachBottom");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    let element = document.getElementById(identifier);
    let instance = new DevExpress.ui.dxScrollView(element, options);
});
Blazor.registerFunction('BlazorDevExtreme.DxScrollView.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.ui.dxScrollView.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.DxScrollView.GetOption', function (identifier, key) {
    let element = document.getElementById(identifier);
    return DevExpress.ui.dxScrollView.getInstance(element).option(key);
});
// DevExpress.ui.dxSelectBox interop automatically generated
Blazor.registerFunction('BlazorDevExtreme.DxSelectBox.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    if (options.onCustomItemCreatingEnabled) {
        options.onCustomItemCreating = function () {
            const callback = Blazor.platform.findMethod(assemblyName, "DevExpress.Ui", "DxSelectBoxInterop", "OnCustomItemCreating");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    let element = document.getElementById(identifier);
    let instance = new DevExpress.ui.dxSelectBox(element, options);
});
Blazor.registerFunction('BlazorDevExtreme.DxSelectBox.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.ui.dxSelectBox.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.DxSelectBox.GetOption', function (identifier, key) {
    let element = document.getElementById(identifier);
    return DevExpress.ui.dxSelectBox.getInstance(element).option(key);
});
// DevExpress.ui.dxSlider interop automatically generated
Blazor.registerFunction('BlazorDevExtreme.DxSlider.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    let element = document.getElementById(identifier);
    let instance = new DevExpress.ui.dxSlider(element, options);
});
Blazor.registerFunction('BlazorDevExtreme.DxSlider.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.ui.dxSlider.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.DxSlider.GetOption', function (identifier, key) {
    let element = document.getElementById(identifier);
    return DevExpress.ui.dxSlider.getInstance(element).option(key);
});
// DevExpress.ui.dxSlideOut interop automatically generated
Blazor.registerFunction('BlazorDevExtreme.DxSlideOut.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    if (options.onMenuGroupRenderedEnabled) {
        options.onMenuGroupRendered = function () {
            const callback = Blazor.platform.findMethod(assemblyName, "DevExpress.Ui", "DxSlideOutInterop", "OnMenuGroupRendered");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onMenuItemRenderedEnabled) {
        options.onMenuItemRendered = function () {
            const callback = Blazor.platform.findMethod(assemblyName, "DevExpress.Ui", "DxSlideOutInterop", "OnMenuItemRendered");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    let element = document.getElementById(identifier);
    let instance = new DevExpress.ui.dxSlideOut(element, options);
});
Blazor.registerFunction('BlazorDevExtreme.DxSlideOut.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.ui.dxSlideOut.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.DxSlideOut.GetOption', function (identifier, key) {
    let element = document.getElementById(identifier);
    return DevExpress.ui.dxSlideOut.getInstance(element).option(key);
});
// DevExpress.ui.dxSlideOutView interop automatically generated
Blazor.registerFunction('BlazorDevExtreme.DxSlideOutView.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    let element = document.getElementById(identifier);
    let instance = new DevExpress.ui.dxSlideOutView(element, options);
});
Blazor.registerFunction('BlazorDevExtreme.DxSlideOutView.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.ui.dxSlideOutView.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.DxSlideOutView.GetOption', function (identifier, key) {
    let element = document.getElementById(identifier);
    return DevExpress.ui.dxSlideOutView.getInstance(element).option(key);
});
// DevExpress.ui.dxSwitch interop automatically generated
Blazor.registerFunction('BlazorDevExtreme.DxSwitch.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    let element = document.getElementById(identifier);
    let instance = new DevExpress.ui.dxSwitch(element, options);
});
Blazor.registerFunction('BlazorDevExtreme.DxSwitch.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.ui.dxSwitch.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.DxSwitch.GetOption', function (identifier, key) {
    let element = document.getElementById(identifier);
    return DevExpress.ui.dxSwitch.getInstance(element).option(key);
});
// DevExpress.ui.dxTabs interop automatically generated
Blazor.registerFunction('BlazorDevExtreme.DxTabs.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    let element = document.getElementById(identifier);
    let instance = new DevExpress.ui.dxTabs(element, options);
});
Blazor.registerFunction('BlazorDevExtreme.DxTabs.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.ui.dxTabs.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.DxTabs.GetOption', function (identifier, key) {
    let element = document.getElementById(identifier);
    return DevExpress.ui.dxTabs.getInstance(element).option(key);
});
// DevExpress.ui.dxTabPanel interop automatically generated
Blazor.registerFunction('BlazorDevExtreme.DxTabPanel.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    if (options.onTitleClickEnabled) {
        options.onTitleClick = function () {
            const callback = Blazor.platform.findMethod(assemblyName, "DevExpress.Ui", "DxTabPanelInterop", "OnTitleClick");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onTitleHoldEnabled) {
        options.onTitleHold = function () {
            const callback = Blazor.platform.findMethod(assemblyName, "DevExpress.Ui", "DxTabPanelInterop", "OnTitleHold");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onTitleRenderedEnabled) {
        options.onTitleRendered = function () {
            const callback = Blazor.platform.findMethod(assemblyName, "DevExpress.Ui", "DxTabPanelInterop", "OnTitleRendered");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    let element = document.getElementById(identifier);
    let instance = new DevExpress.ui.dxTabPanel(element, options);
});
Blazor.registerFunction('BlazorDevExtreme.DxTabPanel.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.ui.dxTabPanel.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.DxTabPanel.GetOption', function (identifier, key) {
    let element = document.getElementById(identifier);
    return DevExpress.ui.dxTabPanel.getInstance(element).option(key);
});
// DevExpress.ui.dxTagBox interop automatically generated
Blazor.registerFunction('BlazorDevExtreme.DxTagBox.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    if (options.onMultiTagPreparingEnabled) {
        options.onMultiTagPreparing = function () {
            const callback = Blazor.platform.findMethod(assemblyName, "DevExpress.Ui", "DxTagBoxInterop", "OnMultiTagPreparing");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onSelectAllValueChangedEnabled) {
        options.onSelectAllValueChanged = function () {
            const callback = Blazor.platform.findMethod(assemblyName, "DevExpress.Ui", "DxTagBoxInterop", "OnSelectAllValueChanged");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onSelectionChangedEnabled) {
        options.onSelectionChanged = function () {
            const callback = Blazor.platform.findMethod(assemblyName, "DevExpress.Ui", "DxTagBoxInterop", "OnSelectionChanged");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    let element = document.getElementById(identifier);
    let instance = new DevExpress.ui.dxTagBox(element, options);
});
Blazor.registerFunction('BlazorDevExtreme.DxTagBox.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.ui.dxTagBox.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.DxTagBox.GetOption', function (identifier, key) {
    let element = document.getElementById(identifier);
    return DevExpress.ui.dxTagBox.getInstance(element).option(key);
});
// DevExpress.ui.dxTextArea interop automatically generated
Blazor.registerFunction('BlazorDevExtreme.DxTextArea.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    let element = document.getElementById(identifier);
    let instance = new DevExpress.ui.dxTextArea(element, options);
});
Blazor.registerFunction('BlazorDevExtreme.DxTextArea.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.ui.dxTextArea.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.DxTextArea.GetOption', function (identifier, key) {
    let element = document.getElementById(identifier);
    return DevExpress.ui.dxTextArea.getInstance(element).option(key);
});
// DevExpress.ui.dxTextBox interop automatically generated
Blazor.registerFunction('BlazorDevExtreme.DxTextBox.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    let element = document.getElementById(identifier);
    let instance = new DevExpress.ui.dxTextBox(element, options);
});
Blazor.registerFunction('BlazorDevExtreme.DxTextBox.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.ui.dxTextBox.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.DxTextBox.GetOption', function (identifier, key) {
    let element = document.getElementById(identifier);
    return DevExpress.ui.dxTextBox.getInstance(element).option(key);
});
// DevExpress.ui.dxTileView interop automatically generated
Blazor.registerFunction('BlazorDevExtreme.DxTileView.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    let element = document.getElementById(identifier);
    let instance = new DevExpress.ui.dxTileView(element, options);
});
Blazor.registerFunction('BlazorDevExtreme.DxTileView.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.ui.dxTileView.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.DxTileView.GetOption', function (identifier, key) {
    let element = document.getElementById(identifier);
    return DevExpress.ui.dxTileView.getInstance(element).option(key);
});
// DevExpress.ui.dxToast interop automatically generated
Blazor.registerFunction('BlazorDevExtreme.DxToast.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    let element = document.getElementById(identifier);
    let instance = new DevExpress.ui.dxToast(element, options);
});
Blazor.registerFunction('BlazorDevExtreme.DxToast.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.ui.dxToast.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.DxToast.GetOption', function (identifier, key) {
    let element = document.getElementById(identifier);
    return DevExpress.ui.dxToast.getInstance(element).option(key);
});
// DevExpress.ui.dxToolbar interop automatically generated
Blazor.registerFunction('BlazorDevExtreme.DxToolbar.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    let element = document.getElementById(identifier);
    let instance = new DevExpress.ui.dxToolbar(element, options);
});
Blazor.registerFunction('BlazorDevExtreme.DxToolbar.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.ui.dxToolbar.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.DxToolbar.GetOption', function (identifier, key) {
    let element = document.getElementById(identifier);
    return DevExpress.ui.dxToolbar.getInstance(element).option(key);
});
// DevExpress.ui.dxTooltip interop automatically generated
Blazor.registerFunction('BlazorDevExtreme.DxTooltip.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    let element = document.getElementById(identifier);
    let instance = new DevExpress.ui.dxTooltip(element, options);
});
Blazor.registerFunction('BlazorDevExtreme.DxTooltip.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.ui.dxTooltip.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.DxTooltip.GetOption', function (identifier, key) {
    let element = document.getElementById(identifier);
    return DevExpress.ui.dxTooltip.getInstance(element).option(key);
});
// DevExpress.ui.dxTrackBar interop automatically generated
Blazor.registerFunction('BlazorDevExtreme.DxTrackBar.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    let element = document.getElementById(identifier);
    let instance = new DevExpress.ui.dxTrackBar(element, options);
});
Blazor.registerFunction('BlazorDevExtreme.DxTrackBar.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.ui.dxTrackBar.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.DxTrackBar.GetOption', function (identifier, key) {
    let element = document.getElementById(identifier);
    return DevExpress.ui.dxTrackBar.getInstance(element).option(key);
});
// DevExpress.ui.dxTreeList interop automatically generated
Blazor.registerFunction('BlazorDevExtreme.DxTreeList.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    if (options.onCellClickEnabled) {
        options.onCellClick = function () {
            const callback = Blazor.platform.findMethod(assemblyName, "DevExpress.Ui", "DxTreeListInterop", "OnCellClick");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onCellHoverChangedEnabled) {
        options.onCellHoverChanged = function () {
            const callback = Blazor.platform.findMethod(assemblyName, "DevExpress.Ui", "DxTreeListInterop", "OnCellHoverChanged");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onCellPreparedEnabled) {
        options.onCellPrepared = function () {
            const callback = Blazor.platform.findMethod(assemblyName, "DevExpress.Ui", "DxTreeListInterop", "OnCellPrepared");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onContextMenuPreparingEnabled) {
        options.onContextMenuPreparing = function () {
            const callback = Blazor.platform.findMethod(assemblyName, "DevExpress.Ui", "DxTreeListInterop", "OnContextMenuPreparing");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onEditingStartEnabled) {
        options.onEditingStart = function () {
            const callback = Blazor.platform.findMethod(assemblyName, "DevExpress.Ui", "DxTreeListInterop", "OnEditingStart");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onEditorPreparedEnabled) {
        options.onEditorPrepared = function () {
            const callback = Blazor.platform.findMethod(assemblyName, "DevExpress.Ui", "DxTreeListInterop", "OnEditorPrepared");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onEditorPreparingEnabled) {
        options.onEditorPreparing = function () {
            const callback = Blazor.platform.findMethod(assemblyName, "DevExpress.Ui", "DxTreeListInterop", "OnEditorPreparing");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onNodesInitializedEnabled) {
        options.onNodesInitialized = function () {
            const callback = Blazor.platform.findMethod(assemblyName, "DevExpress.Ui", "DxTreeListInterop", "OnNodesInitialized");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onRowClickEnabled) {
        options.onRowClick = function () {
            const callback = Blazor.platform.findMethod(assemblyName, "DevExpress.Ui", "DxTreeListInterop", "OnRowClick");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onRowPreparedEnabled) {
        options.onRowPrepared = function () {
            const callback = Blazor.platform.findMethod(assemblyName, "DevExpress.Ui", "DxTreeListInterop", "OnRowPrepared");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    let element = document.getElementById(identifier);
    let instance = new DevExpress.ui.dxTreeList(element, options);
});
Blazor.registerFunction('BlazorDevExtreme.DxTreeList.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.ui.dxTreeList.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.DxTreeList.GetOption', function (identifier, key) {
    let element = document.getElementById(identifier);
    return DevExpress.ui.dxTreeList.getInstance(element).option(key);
});
// DevExpress.ui.dxTreeView interop automatically generated
Blazor.registerFunction('BlazorDevExtreme.DxTreeView.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    if (options.onItemClickEnabled) {
        options.onItemClick = function () {
            const callback = Blazor.platform.findMethod(assemblyName, "DevExpress.Ui", "DxTreeViewInterop", "OnItemClick");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onItemCollapsedEnabled) {
        options.onItemCollapsed = function () {
            const callback = Blazor.platform.findMethod(assemblyName, "DevExpress.Ui", "DxTreeViewInterop", "OnItemCollapsed");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onItemContextMenuEnabled) {
        options.onItemContextMenu = function () {
            const callback = Blazor.platform.findMethod(assemblyName, "DevExpress.Ui", "DxTreeViewInterop", "OnItemContextMenu");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onItemExpandedEnabled) {
        options.onItemExpanded = function () {
            const callback = Blazor.platform.findMethod(assemblyName, "DevExpress.Ui", "DxTreeViewInterop", "OnItemExpanded");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onItemHoldEnabled) {
        options.onItemHold = function () {
            const callback = Blazor.platform.findMethod(assemblyName, "DevExpress.Ui", "DxTreeViewInterop", "OnItemHold");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onItemRenderedEnabled) {
        options.onItemRendered = function () {
            const callback = Blazor.platform.findMethod(assemblyName, "DevExpress.Ui", "DxTreeViewInterop", "OnItemRendered");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onItemSelectionChangedEnabled) {
        options.onItemSelectionChanged = function () {
            const callback = Blazor.platform.findMethod(assemblyName, "DevExpress.Ui", "DxTreeViewInterop", "OnItemSelectionChanged");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onSelectionChangedEnabled) {
        options.onSelectionChanged = function () {
            const callback = Blazor.platform.findMethod(assemblyName, "DevExpress.Ui", "DxTreeViewInterop", "OnSelectionChanged");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    let element = document.getElementById(identifier);
    let instance = new DevExpress.ui.dxTreeView(element, options);
});
Blazor.registerFunction('BlazorDevExtreme.DxTreeView.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.ui.dxTreeView.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.DxTreeView.GetOption', function (identifier, key) {
    let element = document.getElementById(identifier);
    return DevExpress.ui.dxTreeView.getInstance(element).option(key);
});
// DevExpress.ui.dxValidationGroup interop automatically generated
Blazor.registerFunction('BlazorDevExtreme.DxValidationGroup.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    let element = document.getElementById(identifier);
    let instance = new DevExpress.ui.dxValidationGroup(element, options);
});
Blazor.registerFunction('BlazorDevExtreme.DxValidationGroup.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.ui.dxValidationGroup.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.DxValidationGroup.GetOption', function (identifier, key) {
    let element = document.getElementById(identifier);
    return DevExpress.ui.dxValidationGroup.getInstance(element).option(key);
});
// DevExpress.ui.dxValidationSummary interop automatically generated
Blazor.registerFunction('BlazorDevExtreme.DxValidationSummary.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    let element = document.getElementById(identifier);
    let instance = new DevExpress.ui.dxValidationSummary(element, options);
});
Blazor.registerFunction('BlazorDevExtreme.DxValidationSummary.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.ui.dxValidationSummary.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.DxValidationSummary.GetOption', function (identifier, key) {
    let element = document.getElementById(identifier);
    return DevExpress.ui.dxValidationSummary.getInstance(element).option(key);
});
// DevExpress.ui.dxValidator interop automatically generated
Blazor.registerFunction('BlazorDevExtreme.DxValidator.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    if (options.onValidatedEnabled) {
        options.onValidated = function () {
            const callback = Blazor.platform.findMethod(assemblyName, "DevExpress.Ui", "DxValidatorInterop", "OnValidated");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    let element = document.getElementById(identifier);
    let instance = new DevExpress.ui.dxValidator(element, options);
});
Blazor.registerFunction('BlazorDevExtreme.DxValidator.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.ui.dxValidator.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.DxValidator.GetOption', function (identifier, key) {
    let element = document.getElementById(identifier);
    return DevExpress.ui.dxValidator.getInstance(element).option(key);
});
// DevExpress.ui.CollectionWidget interop automatically generated
Blazor.registerFunction('BlazorDevExtreme.CollectionWidget.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    if (options.onItemClickEnabled) {
        options.onItemClick = function () {
            const callback = Blazor.platform.findMethod(assemblyName, "DevExpress.Ui", "CollectionWidgetInterop", "OnItemClick");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onItemContextMenuEnabled) {
        options.onItemContextMenu = function () {
            const callback = Blazor.platform.findMethod(assemblyName, "DevExpress.Ui", "CollectionWidgetInterop", "OnItemContextMenu");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onItemHoldEnabled) {
        options.onItemHold = function () {
            const callback = Blazor.platform.findMethod(assemblyName, "DevExpress.Ui", "CollectionWidgetInterop", "OnItemHold");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onItemRenderedEnabled) {
        options.onItemRendered = function () {
            const callback = Blazor.platform.findMethod(assemblyName, "DevExpress.Ui", "CollectionWidgetInterop", "OnItemRendered");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onSelectionChangedEnabled) {
        options.onSelectionChanged = function () {
            const callback = Blazor.platform.findMethod(assemblyName, "DevExpress.Ui", "CollectionWidgetInterop", "OnSelectionChanged");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    let element = document.getElementById(identifier);
    let instance = new DevExpress.ui.CollectionWidget(element, options);
});
Blazor.registerFunction('BlazorDevExtreme.CollectionWidget.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.ui.CollectionWidget.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.CollectionWidget.GetOption', function (identifier, key) {
    let element = document.getElementById(identifier);
    return DevExpress.ui.CollectionWidget.getInstance(element).option(key);
});
// DevExpress.ui.dxMenuBase interop automatically generated
Blazor.registerFunction('BlazorDevExtreme.DxMenuBase.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    let element = document.getElementById(identifier);
    let instance = new DevExpress.ui.dxMenuBase(element, options);
});
Blazor.registerFunction('BlazorDevExtreme.DxMenuBase.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.ui.dxMenuBase.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.DxMenuBase.GetOption', function (identifier, key) {
    let element = document.getElementById(identifier);
    return DevExpress.ui.dxMenuBase.getInstance(element).option(key);
});
// DevExpress.ui.dxDropDownEditor interop automatically generated
Blazor.registerFunction('BlazorDevExtreme.DxDropDownEditor.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    if (options.onClosedEnabled) {
        options.onClosed = function () {
            const callback = Blazor.platform.findMethod(assemblyName, "DevExpress.Ui", "DxDropDownEditorInterop", "OnClosed");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onOpenedEnabled) {
        options.onOpened = function () {
            const callback = Blazor.platform.findMethod(assemblyName, "DevExpress.Ui", "DxDropDownEditorInterop", "OnOpened");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    let element = document.getElementById(identifier);
    let instance = new DevExpress.ui.dxDropDownEditor(element, options);
});
Blazor.registerFunction('BlazorDevExtreme.DxDropDownEditor.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.ui.dxDropDownEditor.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.DxDropDownEditor.GetOption', function (identifier, key) {
    let element = document.getElementById(identifier);
    return DevExpress.ui.dxDropDownEditor.getInstance(element).option(key);
});
// DevExpress.ui.dxDropDownList interop automatically generated
Blazor.registerFunction('BlazorDevExtreme.DxDropDownList.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    if (options.onItemClickEnabled) {
        options.onItemClick = function () {
            const callback = Blazor.platform.findMethod(assemblyName, "DevExpress.Ui", "DxDropDownListInterop", "OnItemClick");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onSelectionChangedEnabled) {
        options.onSelectionChanged = function () {
            const callback = Blazor.platform.findMethod(assemblyName, "DevExpress.Ui", "DxDropDownListInterop", "OnSelectionChanged");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onValueChangedEnabled) {
        options.onValueChanged = function () {
            const callback = Blazor.platform.findMethod(assemblyName, "DevExpress.Ui", "DxDropDownListInterop", "OnValueChanged");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    let element = document.getElementById(identifier);
    let instance = new DevExpress.ui.dxDropDownList(element, options);
});
Blazor.registerFunction('BlazorDevExtreme.DxDropDownList.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.ui.dxDropDownList.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.DxDropDownList.GetOption', function (identifier, key) {
    let element = document.getElementById(identifier);
    return DevExpress.ui.dxDropDownList.getInstance(element).option(key);
});
// DevExpress.ui.Editor interop automatically generated
Blazor.registerFunction('BlazorDevExtreme.Editor.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    if (options.onValueChangedEnabled) {
        options.onValueChanged = function () {
            const callback = Blazor.platform.findMethod(assemblyName, "DevExpress.Ui", "EditorInterop", "OnValueChanged");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    let element = document.getElementById(identifier);
    let instance = new DevExpress.ui.Editor(element, options);
});
Blazor.registerFunction('BlazorDevExtreme.Editor.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.ui.Editor.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.Editor.GetOption', function (identifier, key) {
    let element = document.getElementById(identifier);
    return DevExpress.ui.Editor.getInstance(element).option(key);
});
// DevExpress.ui.DataExpressionMixin interop automatically generated
Blazor.registerFunction('BlazorDevExtreme.DataExpressionMixin.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    let element = document.getElementById(identifier);
    let instance = new DevExpress.ui.DataExpressionMixin(element, options);
});
Blazor.registerFunction('BlazorDevExtreme.DataExpressionMixin.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.ui.DataExpressionMixin.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.DataExpressionMixin.GetOption', function (identifier, key) {
    let element = document.getElementById(identifier);
    return DevExpress.ui.DataExpressionMixin.getInstance(element).option(key);
});
// DevExpress.ui.HierarchicalCollectionWidget interop automatically generated
Blazor.registerFunction('BlazorDevExtreme.HierarchicalCollectionWidget.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    let element = document.getElementById(identifier);
    let instance = new DevExpress.ui.HierarchicalCollectionWidget(element, options);
});
Blazor.registerFunction('BlazorDevExtreme.HierarchicalCollectionWidget.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.ui.HierarchicalCollectionWidget.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.HierarchicalCollectionWidget.GetOption', function (identifier, key) {
    let element = document.getElementById(identifier);
    return DevExpress.ui.HierarchicalCollectionWidget.getInstance(element).option(key);
});
// DevExpress.ui.dxPivotGridSummaryCell interop automatically generated
Blazor.registerFunction('BlazorDevExtreme.DxPivotGridSummaryCell.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.ui.dxPivotGridSummaryCell.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.DxPivotGridSummaryCell.GetOption', function (identifier, key) {
    let element = document.getElementById(identifier);
    return DevExpress.ui.dxPivotGridSummaryCell.getInstance(element).option(key);
});
// DevExpress.ui.dxScrollable interop automatically generated
Blazor.registerFunction('BlazorDevExtreme.DxScrollable.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    if (options.onScrollEnabled) {
        options.onScroll = function () {
            const callback = Blazor.platform.findMethod(assemblyName, "DevExpress.Ui", "DxScrollableInterop", "OnScroll");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onUpdatedEnabled) {
        options.onUpdated = function () {
            const callback = Blazor.platform.findMethod(assemblyName, "DevExpress.Ui", "DxScrollableInterop", "OnUpdated");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    let element = document.getElementById(identifier);
    let instance = new DevExpress.ui.dxScrollable(element, options);
});
Blazor.registerFunction('BlazorDevExtreme.DxScrollable.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.ui.dxScrollable.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.DxScrollable.GetOption', function (identifier, key) {
    let element = document.getElementById(identifier);
    return DevExpress.ui.dxScrollable.getInstance(element).option(key);
});
// DevExpress.ui.dxSliderBase interop automatically generated
Blazor.registerFunction('BlazorDevExtreme.DxSliderBase.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    let element = document.getElementById(identifier);
    let instance = new DevExpress.ui.dxSliderBase(element, options);
});
Blazor.registerFunction('BlazorDevExtreme.DxSliderBase.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.ui.dxSliderBase.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.DxSliderBase.GetOption', function (identifier, key) {
    let element = document.getElementById(identifier);
    return DevExpress.ui.dxSliderBase.getInstance(element).option(key);
});
// DevExpress.ui.dxTextEditor interop automatically generated
Blazor.registerFunction('BlazorDevExtreme.DxTextEditor.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    if (options.onChangeEnabled) {
        options.onChange = function () {
            const callback = Blazor.platform.findMethod(assemblyName, "DevExpress.Ui", "DxTextEditorInterop", "OnChange");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onCopyEnabled) {
        options.onCopy = function () {
            const callback = Blazor.platform.findMethod(assemblyName, "DevExpress.Ui", "DxTextEditorInterop", "OnCopy");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onCutEnabled) {
        options.onCut = function () {
            const callback = Blazor.platform.findMethod(assemblyName, "DevExpress.Ui", "DxTextEditorInterop", "OnCut");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onEnterKeyEnabled) {
        options.onEnterKey = function () {
            const callback = Blazor.platform.findMethod(assemblyName, "DevExpress.Ui", "DxTextEditorInterop", "OnEnterKey");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onFocusInEnabled) {
        options.onFocusIn = function () {
            const callback = Blazor.platform.findMethod(assemblyName, "DevExpress.Ui", "DxTextEditorInterop", "OnFocusIn");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onFocusOutEnabled) {
        options.onFocusOut = function () {
            const callback = Blazor.platform.findMethod(assemblyName, "DevExpress.Ui", "DxTextEditorInterop", "OnFocusOut");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onInputEnabled) {
        options.onInput = function () {
            const callback = Blazor.platform.findMethod(assemblyName, "DevExpress.Ui", "DxTextEditorInterop", "OnInput");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onKeyDownEnabled) {
        options.onKeyDown = function () {
            const callback = Blazor.platform.findMethod(assemblyName, "DevExpress.Ui", "DxTextEditorInterop", "OnKeyDown");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onKeyPressEnabled) {
        options.onKeyPress = function () {
            const callback = Blazor.platform.findMethod(assemblyName, "DevExpress.Ui", "DxTextEditorInterop", "OnKeyPress");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onKeyUpEnabled) {
        options.onKeyUp = function () {
            const callback = Blazor.platform.findMethod(assemblyName, "DevExpress.Ui", "DxTextEditorInterop", "OnKeyUp");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onPasteEnabled) {
        options.onPaste = function () {
            const callback = Blazor.platform.findMethod(assemblyName, "DevExpress.Ui", "DxTextEditorInterop", "OnPaste");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    let element = document.getElementById(identifier);
    let instance = new DevExpress.ui.dxTextEditor(element, options);
});
Blazor.registerFunction('BlazorDevExtreme.DxTextEditor.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.ui.dxTextEditor.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.DxTextEditor.GetOption', function (identifier, key) {
    let element = document.getElementById(identifier);
    return DevExpress.ui.dxTextEditor.getInstance(element).option(key);
});
// DevExpress.ui.SearchBoxMixin interop automatically generated
Blazor.registerFunction('BlazorDevExtreme.SearchBoxMixin.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    let element = document.getElementById(identifier);
    let instance = new DevExpress.ui.SearchBoxMixin(element, options);
});
Blazor.registerFunction('BlazorDevExtreme.SearchBoxMixin.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.ui.SearchBoxMixin.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.SearchBoxMixin.GetOption', function (identifier, key) {
    let element = document.getElementById(identifier);
    return DevExpress.ui.SearchBoxMixin.getInstance(element).option(key);
});
// DevExpress.ui.dxTemplate interop automatically generated
Blazor.registerFunction('BlazorDevExtreme.DxTemplate.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    let element = document.getElementById(identifier);
    let instance = new DevExpress.ui.dxTemplate(element, options);
});
Blazor.registerFunction('BlazorDevExtreme.DxTemplate.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.ui.dxTemplate.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.DxTemplate.GetOption', function (identifier, key) {
    let element = document.getElementById(identifier);
    return DevExpress.ui.dxTemplate.getInstance(element).option(key);
});
// DevExpress.ui.Widget interop automatically generated
Blazor.registerFunction('BlazorDevExtreme.Widget.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    if (options.onContentReadyEnabled) {
        options.onContentReady = function () {
            const callback = Blazor.platform.findMethod(assemblyName, "DevExpress.Ui", "WidgetInterop", "OnContentReady");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    let element = document.getElementById(identifier);
    let instance = new DevExpress.ui.Widget(element, options);
});
Blazor.registerFunction('BlazorDevExtreme.Widget.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.ui.Widget.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.Widget.GetOption', function (identifier, key) {
    let element = document.getElementById(identifier);
    return DevExpress.ui.Widget.getInstance(element).option(key);
});
// DevExpress.ui.dialog interop automatically generated
Blazor.registerFunction('BlazorDevExtreme.Dialog.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.ui.dialog.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.Dialog.GetOption', function (identifier, key) {
    let element = document.getElementById(identifier);
    return DevExpress.ui.dialog.getInstance(element).option(key);
});
// DevExpress.ui.themes interop automatically generated
Blazor.registerFunction('BlazorDevExtreme.Themes.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.ui.themes.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.Themes.GetOption', function (identifier, key) {
    let element = document.getElementById(identifier);
    return DevExpress.ui.themes.getInstance(element).option(key);
});
// DevExpress.viz.BaseWidget interop automatically generated
Blazor.registerFunction('BlazorDevExtreme.BaseWidget.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    if (options.onDrawnEnabled) {
        options.onDrawn = function () {
            const callback = Blazor.platform.findMethod(assemblyName, "DevExpress.Viz", "BaseWidgetInterop", "OnDrawn");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onExportedEnabled) {
        options.onExported = function () {
            const callback = Blazor.platform.findMethod(assemblyName, "DevExpress.Viz", "BaseWidgetInterop", "OnExported");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onExportingEnabled) {
        options.onExporting = function () {
            const callback = Blazor.platform.findMethod(assemblyName, "DevExpress.Viz", "BaseWidgetInterop", "OnExporting");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onFileSavingEnabled) {
        options.onFileSaving = function () {
            const callback = Blazor.platform.findMethod(assemblyName, "DevExpress.Viz", "BaseWidgetInterop", "OnFileSaving");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onIncidentOccurredEnabled) {
        options.onIncidentOccurred = function () {
            const callback = Blazor.platform.findMethod(assemblyName, "DevExpress.Viz", "BaseWidgetInterop", "OnIncidentOccurred");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    let element = document.getElementById(identifier);
    let instance = new DevExpress.viz.BaseWidget(element, options);
});
Blazor.registerFunction('BlazorDevExtreme.BaseWidget.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.viz.BaseWidget.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.BaseWidget.GetOption', function (identifier, key) {
    let element = document.getElementById(identifier);
    return DevExpress.viz.BaseWidget.getInstance(element).option(key);
});
// DevExpress.viz.dxChart interop automatically generated
Blazor.registerFunction('BlazorDevExtreme.DxChart.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    if (options.onArgumentAxisClickEnabled) {
        options.onArgumentAxisClick = function () {
            const callback = Blazor.platform.findMethod(assemblyName, "DevExpress.Viz", "DxChartInterop", "OnArgumentAxisClick");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onLegendClickEnabled) {
        options.onLegendClick = function () {
            const callback = Blazor.platform.findMethod(assemblyName, "DevExpress.Viz", "DxChartInterop", "OnLegendClick");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onSeriesClickEnabled) {
        options.onSeriesClick = function () {
            const callback = Blazor.platform.findMethod(assemblyName, "DevExpress.Viz", "DxChartInterop", "OnSeriesClick");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onSeriesHoverChangedEnabled) {
        options.onSeriesHoverChanged = function () {
            const callback = Blazor.platform.findMethod(assemblyName, "DevExpress.Viz", "DxChartInterop", "OnSeriesHoverChanged");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onSeriesSelectionChangedEnabled) {
        options.onSeriesSelectionChanged = function () {
            const callback = Blazor.platform.findMethod(assemblyName, "DevExpress.Viz", "DxChartInterop", "OnSeriesSelectionChanged");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onZoomEndEnabled) {
        options.onZoomEnd = function () {
            const callback = Blazor.platform.findMethod(assemblyName, "DevExpress.Viz", "DxChartInterop", "OnZoomEnd");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onZoomStartEnabled) {
        options.onZoomStart = function () {
            const callback = Blazor.platform.findMethod(assemblyName, "DevExpress.Viz", "DxChartInterop", "OnZoomStart");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    let element = document.getElementById(identifier);
    let instance = new DevExpress.viz.dxChart(element, options);
});
Blazor.registerFunction('BlazorDevExtreme.DxChart.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.viz.dxChart.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.DxChart.GetOption', function (identifier, key) {
    let element = document.getElementById(identifier);
    return DevExpress.viz.dxChart.getInstance(element).option(key);
});
// DevExpress.viz.dxPieChart interop automatically generated
Blazor.registerFunction('BlazorDevExtreme.DxPieChart.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    if (options.onLegendClickEnabled) {
        options.onLegendClick = function () {
            const callback = Blazor.platform.findMethod(assemblyName, "DevExpress.Viz", "DxPieChartInterop", "OnLegendClick");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    let element = document.getElementById(identifier);
    let instance = new DevExpress.viz.dxPieChart(element, options);
});
Blazor.registerFunction('BlazorDevExtreme.DxPieChart.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.viz.dxPieChart.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.DxPieChart.GetOption', function (identifier, key) {
    let element = document.getElementById(identifier);
    return DevExpress.viz.dxPieChart.getInstance(element).option(key);
});
// DevExpress.viz.dxPolarChart interop automatically generated
Blazor.registerFunction('BlazorDevExtreme.DxPolarChart.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    if (options.onArgumentAxisClickEnabled) {
        options.onArgumentAxisClick = function () {
            const callback = Blazor.platform.findMethod(assemblyName, "DevExpress.Viz", "DxPolarChartInterop", "OnArgumentAxisClick");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onLegendClickEnabled) {
        options.onLegendClick = function () {
            const callback = Blazor.platform.findMethod(assemblyName, "DevExpress.Viz", "DxPolarChartInterop", "OnLegendClick");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onSeriesClickEnabled) {
        options.onSeriesClick = function () {
            const callback = Blazor.platform.findMethod(assemblyName, "DevExpress.Viz", "DxPolarChartInterop", "OnSeriesClick");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onSeriesHoverChangedEnabled) {
        options.onSeriesHoverChanged = function () {
            const callback = Blazor.platform.findMethod(assemblyName, "DevExpress.Viz", "DxPolarChartInterop", "OnSeriesHoverChanged");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onSeriesSelectionChangedEnabled) {
        options.onSeriesSelectionChanged = function () {
            const callback = Blazor.platform.findMethod(assemblyName, "DevExpress.Viz", "DxPolarChartInterop", "OnSeriesSelectionChanged");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    let element = document.getElementById(identifier);
    let instance = new DevExpress.viz.dxPolarChart(element, options);
});
Blazor.registerFunction('BlazorDevExtreme.DxPolarChart.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.viz.dxPolarChart.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.DxPolarChart.GetOption', function (identifier, key) {
    let element = document.getElementById(identifier);
    return DevExpress.viz.dxPolarChart.getInstance(element).option(key);
});
// DevExpress.viz.BaseChart interop automatically generated
Blazor.registerFunction('BlazorDevExtreme.BaseChart.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    if (options.onDoneEnabled) {
        options.onDone = function () {
            const callback = Blazor.platform.findMethod(assemblyName, "DevExpress.Viz", "BaseChartInterop", "OnDone");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onPointClickEnabled) {
        options.onPointClick = function () {
            const callback = Blazor.platform.findMethod(assemblyName, "DevExpress.Viz", "BaseChartInterop", "OnPointClick");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onPointHoverChangedEnabled) {
        options.onPointHoverChanged = function () {
            const callback = Blazor.platform.findMethod(assemblyName, "DevExpress.Viz", "BaseChartInterop", "OnPointHoverChanged");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onPointSelectionChangedEnabled) {
        options.onPointSelectionChanged = function () {
            const callback = Blazor.platform.findMethod(assemblyName, "DevExpress.Viz", "BaseChartInterop", "OnPointSelectionChanged");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onTooltipHiddenEnabled) {
        options.onTooltipHidden = function () {
            const callback = Blazor.platform.findMethod(assemblyName, "DevExpress.Viz", "BaseChartInterop", "OnTooltipHidden");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onTooltipShownEnabled) {
        options.onTooltipShown = function () {
            const callback = Blazor.platform.findMethod(assemblyName, "DevExpress.Viz", "BaseChartInterop", "OnTooltipShown");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    let element = document.getElementById(identifier);
    let instance = new DevExpress.viz.BaseChart(element, options);
});
Blazor.registerFunction('BlazorDevExtreme.BaseChart.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.viz.BaseChart.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.BaseChart.GetOption', function (identifier, key) {
    let element = document.getElementById(identifier);
    return DevExpress.viz.BaseChart.getInstance(element).option(key);
});
// DevExpress.viz.dxExporter interop automatically generated
Blazor.registerFunction('BlazorDevExtreme.DxExporter.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    let element = document.getElementById(identifier);
    let instance = new DevExpress.viz.dxExporter(element, options);
});
Blazor.registerFunction('BlazorDevExtreme.DxExporter.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.viz.dxExporter.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.DxExporter.GetOption', function (identifier, key) {
    let element = document.getElementById(identifier);
    return DevExpress.viz.dxExporter.getInstance(element).option(key);
});
// DevExpress.viz.dxFunnel interop automatically generated
Blazor.registerFunction('BlazorDevExtreme.DxFunnel.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    if (options.onHoverChangedEnabled) {
        options.onHoverChanged = function () {
            const callback = Blazor.platform.findMethod(assemblyName, "DevExpress.Viz", "DxFunnelInterop", "OnHoverChanged");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onItemClickEnabled) {
        options.onItemClick = function () {
            const callback = Blazor.platform.findMethod(assemblyName, "DevExpress.Viz", "DxFunnelInterop", "OnItemClick");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onLegendClickEnabled) {
        options.onLegendClick = function () {
            const callback = Blazor.platform.findMethod(assemblyName, "DevExpress.Viz", "DxFunnelInterop", "OnLegendClick");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onSelectionChangedEnabled) {
        options.onSelectionChanged = function () {
            const callback = Blazor.platform.findMethod(assemblyName, "DevExpress.Viz", "DxFunnelInterop", "OnSelectionChanged");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    let element = document.getElementById(identifier);
    let instance = new DevExpress.viz.dxFunnel(element, options);
});
Blazor.registerFunction('BlazorDevExtreme.DxFunnel.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.viz.dxFunnel.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.DxFunnel.GetOption', function (identifier, key) {
    let element = document.getElementById(identifier);
    return DevExpress.viz.dxFunnel.getInstance(element).option(key);
});
// DevExpress.viz.BaseGauge interop automatically generated
Blazor.registerFunction('BlazorDevExtreme.BaseGauge.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    if (options.onTooltipHiddenEnabled) {
        options.onTooltipHidden = function () {
            const callback = Blazor.platform.findMethod(assemblyName, "DevExpress.Viz", "BaseGaugeInterop", "OnTooltipHidden");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onTooltipShownEnabled) {
        options.onTooltipShown = function () {
            const callback = Blazor.platform.findMethod(assemblyName, "DevExpress.Viz", "BaseGaugeInterop", "OnTooltipShown");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    let element = document.getElementById(identifier);
    let instance = new DevExpress.viz.BaseGauge(element, options);
});
Blazor.registerFunction('BlazorDevExtreme.BaseGauge.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.viz.BaseGauge.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.BaseGauge.GetOption', function (identifier, key) {
    let element = document.getElementById(identifier);
    return DevExpress.viz.BaseGauge.getInstance(element).option(key);
});
// DevExpress.viz.dxCircularGauge interop automatically generated
Blazor.registerFunction('BlazorDevExtreme.DxCircularGauge.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    let element = document.getElementById(identifier);
    let instance = new DevExpress.viz.dxCircularGauge(element, options);
});
Blazor.registerFunction('BlazorDevExtreme.DxCircularGauge.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.viz.dxCircularGauge.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.DxCircularGauge.GetOption', function (identifier, key) {
    let element = document.getElementById(identifier);
    return DevExpress.viz.dxCircularGauge.getInstance(element).option(key);
});
// DevExpress.viz.dxLinearGauge interop automatically generated
Blazor.registerFunction('BlazorDevExtreme.DxLinearGauge.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    let element = document.getElementById(identifier);
    let instance = new DevExpress.viz.dxLinearGauge(element, options);
});
Blazor.registerFunction('BlazorDevExtreme.DxLinearGauge.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.viz.dxLinearGauge.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.DxLinearGauge.GetOption', function (identifier, key) {
    let element = document.getElementById(identifier);
    return DevExpress.viz.dxLinearGauge.getInstance(element).option(key);
});
// DevExpress.viz.dxBarGauge interop automatically generated
Blazor.registerFunction('BlazorDevExtreme.DxBarGauge.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    if (options.onTooltipHiddenEnabled) {
        options.onTooltipHidden = function () {
            const callback = Blazor.platform.findMethod(assemblyName, "DevExpress.Viz", "DxBarGaugeInterop", "OnTooltipHidden");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onTooltipShownEnabled) {
        options.onTooltipShown = function () {
            const callback = Blazor.platform.findMethod(assemblyName, "DevExpress.Viz", "DxBarGaugeInterop", "OnTooltipShown");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    let element = document.getElementById(identifier);
    let instance = new DevExpress.viz.dxBarGauge(element, options);
});
Blazor.registerFunction('BlazorDevExtreme.DxBarGauge.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.viz.dxBarGauge.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.DxBarGauge.GetOption', function (identifier, key) {
    let element = document.getElementById(identifier);
    return DevExpress.viz.dxBarGauge.getInstance(element).option(key);
});
// DevExpress.viz.baseSeriesObject interop automatically generated
Blazor.registerFunction('BlazorDevExtreme.BaseSeriesObject.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.viz.baseSeriesObject.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.BaseSeriesObject.GetOption', function (identifier, key) {
    let element = document.getElementById(identifier);
    return DevExpress.viz.baseSeriesObject.getInstance(element).option(key);
});
// DevExpress.viz.basePointObject interop automatically generated
Blazor.registerFunction('BlazorDevExtreme.BasePointObject.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.viz.basePointObject.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.BasePointObject.GetOption', function (identifier, key) {
    let element = document.getElementById(identifier);
    return DevExpress.viz.basePointObject.getInstance(element).option(key);
});
// DevExpress.viz.baseLabelObject interop automatically generated
Blazor.registerFunction('BlazorDevExtreme.BaseLabelObject.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.viz.baseLabelObject.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.BaseLabelObject.GetOption', function (identifier, key) {
    let element = document.getElementById(identifier);
    return DevExpress.viz.baseLabelObject.getInstance(element).option(key);
});
// DevExpress.viz.chartSeriesObject interop automatically generated
Blazor.registerFunction('BlazorDevExtreme.ChartSeriesObject.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.viz.chartSeriesObject.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.ChartSeriesObject.GetOption', function (identifier, key) {
    let element = document.getElementById(identifier);
    return DevExpress.viz.chartSeriesObject.getInstance(element).option(key);
});
// DevExpress.viz.chartPointObject interop automatically generated
Blazor.registerFunction('BlazorDevExtreme.ChartPointObject.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.viz.chartPointObject.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.ChartPointObject.GetOption', function (identifier, key) {
    let element = document.getElementById(identifier);
    return DevExpress.viz.chartPointObject.getInstance(element).option(key);
});
// DevExpress.viz.dxFunnelItem interop automatically generated
Blazor.registerFunction('BlazorDevExtreme.DxFunnelItem.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.viz.dxFunnelItem.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.DxFunnelItem.GetOption', function (identifier, key) {
    let element = document.getElementById(identifier);
    return DevExpress.viz.dxFunnelItem.getInstance(element).option(key);
});
// DevExpress.viz.piePointObject interop automatically generated
Blazor.registerFunction('BlazorDevExtreme.PiePointObject.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.viz.piePointObject.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.PiePointObject.GetOption', function (identifier, key) {
    let element = document.getElementById(identifier);
    return DevExpress.viz.piePointObject.getInstance(element).option(key);
});
// DevExpress.viz.pieChartSeriesObject interop automatically generated
Blazor.registerFunction('BlazorDevExtreme.PieChartSeriesObject.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.viz.pieChartSeriesObject.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.PieChartSeriesObject.GetOption', function (identifier, key) {
    let element = document.getElementById(identifier);
    return DevExpress.viz.pieChartSeriesObject.getInstance(element).option(key);
});
// DevExpress.viz.polarChartSeriesObject interop automatically generated
Blazor.registerFunction('BlazorDevExtreme.PolarChartSeriesObject.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.viz.polarChartSeriesObject.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.PolarChartSeriesObject.GetOption', function (identifier, key) {
    let element = document.getElementById(identifier);
    return DevExpress.viz.polarChartSeriesObject.getInstance(element).option(key);
});
// DevExpress.viz.polarPointObject interop automatically generated
Blazor.registerFunction('BlazorDevExtreme.PolarPointObject.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.viz.polarPointObject.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.PolarPointObject.GetOption', function (identifier, key) {
    let element = document.getElementById(identifier);
    return DevExpress.viz.polarPointObject.getInstance(element).option(key);
});
// DevExpress.viz.dxTreeMapNode interop automatically generated
Blazor.registerFunction('BlazorDevExtreme.DxTreeMapNode.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.viz.dxTreeMapNode.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.DxTreeMapNode.GetOption', function (identifier, key) {
    let element = document.getElementById(identifier);
    return DevExpress.viz.dxTreeMapNode.getInstance(element).option(key);
});
// DevExpress.viz.MapLayer interop automatically generated
Blazor.registerFunction('BlazorDevExtreme.MapLayer.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.viz.MapLayer.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.MapLayer.GetOption', function (identifier, key) {
    let element = document.getElementById(identifier);
    return DevExpress.viz.MapLayer.getInstance(element).option(key);
});
// DevExpress.viz.MapLayerElement interop automatically generated
Blazor.registerFunction('BlazorDevExtreme.MapLayerElement.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.viz.MapLayerElement.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.MapLayerElement.GetOption', function (identifier, key) {
    let element = document.getElementById(identifier);
    return DevExpress.viz.MapLayerElement.getInstance(element).option(key);
});
// DevExpress.viz.areaObjects interop automatically generated
Blazor.registerFunction('BlazorDevExtreme.AreaObjects.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.viz.areaObjects.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.AreaObjects.GetOption', function (identifier, key) {
    let element = document.getElementById(identifier);
    return DevExpress.viz.areaObjects.getInstance(element).option(key);
});
// DevExpress.viz.markerObjects interop automatically generated
Blazor.registerFunction('BlazorDevExtreme.MarkerObjects.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.viz.markerObjects.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.MarkerObjects.GetOption', function (identifier, key) {
    let element = document.getElementById(identifier);
    return DevExpress.viz.markerObjects.getInstance(element).option(key);
});
// DevExpress.viz.dxRangeSelector interop automatically generated
Blazor.registerFunction('BlazorDevExtreme.DxRangeSelector.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    if (options.onSelectedRangeChangedEnabled) {
        options.onSelectedRangeChanged = function () {
            const callback = Blazor.platform.findMethod(assemblyName, "DevExpress.Viz", "DxRangeSelectorInterop", "OnSelectedRangeChanged");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onValueChangedEnabled) {
        options.onValueChanged = function () {
            const callback = Blazor.platform.findMethod(assemblyName, "DevExpress.Viz", "DxRangeSelectorInterop", "OnValueChanged");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    let element = document.getElementById(identifier);
    let instance = new DevExpress.viz.dxRangeSelector(element, options);
});
Blazor.registerFunction('BlazorDevExtreme.DxRangeSelector.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.viz.dxRangeSelector.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.DxRangeSelector.GetOption', function (identifier, key) {
    let element = document.getElementById(identifier);
    return DevExpress.viz.dxRangeSelector.getInstance(element).option(key);
});
// DevExpress.viz.BaseSparkline interop automatically generated
Blazor.registerFunction('BlazorDevExtreme.BaseSparkline.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    if (options.onTooltipHiddenEnabled) {
        options.onTooltipHidden = function () {
            const callback = Blazor.platform.findMethod(assemblyName, "DevExpress.Viz", "BaseSparklineInterop", "OnTooltipHidden");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onTooltipShownEnabled) {
        options.onTooltipShown = function () {
            const callback = Blazor.platform.findMethod(assemblyName, "DevExpress.Viz", "BaseSparklineInterop", "OnTooltipShown");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    let element = document.getElementById(identifier);
    let instance = new DevExpress.viz.BaseSparkline(element, options);
});
Blazor.registerFunction('BlazorDevExtreme.BaseSparkline.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.viz.BaseSparkline.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.BaseSparkline.GetOption', function (identifier, key) {
    let element = document.getElementById(identifier);
    return DevExpress.viz.BaseSparkline.getInstance(element).option(key);
});
// DevExpress.viz.dxSparkline interop automatically generated
Blazor.registerFunction('BlazorDevExtreme.DxSparkline.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    let element = document.getElementById(identifier);
    let instance = new DevExpress.viz.dxSparkline(element, options);
});
Blazor.registerFunction('BlazorDevExtreme.DxSparkline.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.viz.dxSparkline.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.DxSparkline.GetOption', function (identifier, key) {
    let element = document.getElementById(identifier);
    return DevExpress.viz.dxSparkline.getInstance(element).option(key);
});
// DevExpress.viz.dxBullet interop automatically generated
Blazor.registerFunction('BlazorDevExtreme.DxBullet.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    let element = document.getElementById(identifier);
    let instance = new DevExpress.viz.dxBullet(element, options);
});
Blazor.registerFunction('BlazorDevExtreme.DxBullet.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.viz.dxBullet.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.DxBullet.GetOption', function (identifier, key) {
    let element = document.getElementById(identifier);
    return DevExpress.viz.dxBullet.getInstance(element).option(key);
});
// DevExpress.viz.dxTreeMap interop automatically generated
Blazor.registerFunction('BlazorDevExtreme.DxTreeMap.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    if (options.onClickEnabled) {
        options.onClick = function () {
            const callback = Blazor.platform.findMethod(assemblyName, "DevExpress.Viz", "DxTreeMapInterop", "OnClick");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onDrillEnabled) {
        options.onDrill = function () {
            const callback = Blazor.platform.findMethod(assemblyName, "DevExpress.Viz", "DxTreeMapInterop", "OnDrill");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onHoverChangedEnabled) {
        options.onHoverChanged = function () {
            const callback = Blazor.platform.findMethod(assemblyName, "DevExpress.Viz", "DxTreeMapInterop", "OnHoverChanged");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onNodesInitializedEnabled) {
        options.onNodesInitialized = function () {
            const callback = Blazor.platform.findMethod(assemblyName, "DevExpress.Viz", "DxTreeMapInterop", "OnNodesInitialized");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onNodesRenderingEnabled) {
        options.onNodesRendering = function () {
            const callback = Blazor.platform.findMethod(assemblyName, "DevExpress.Viz", "DxTreeMapInterop", "OnNodesRendering");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onSelectionChangedEnabled) {
        options.onSelectionChanged = function () {
            const callback = Blazor.platform.findMethod(assemblyName, "DevExpress.Viz", "DxTreeMapInterop", "OnSelectionChanged");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    let element = document.getElementById(identifier);
    let instance = new DevExpress.viz.dxTreeMap(element, options);
});
Blazor.registerFunction('BlazorDevExtreme.DxTreeMap.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.viz.dxTreeMap.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.DxTreeMap.GetOption', function (identifier, key) {
    let element = document.getElementById(identifier);
    return DevExpress.viz.dxTreeMap.getInstance(element).option(key);
});
// DevExpress.viz.dxVectorMap interop automatically generated
Blazor.registerFunction('BlazorDevExtreme.DxVectorMap.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    if (options.onAreaClickEnabled) {
        options.onAreaClick = function () {
            const callback = Blazor.platform.findMethod(assemblyName, "DevExpress.Viz", "DxVectorMapInterop", "OnAreaClick");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onAreaSelectionChangedEnabled) {
        options.onAreaSelectionChanged = function () {
            const callback = Blazor.platform.findMethod(assemblyName, "DevExpress.Viz", "DxVectorMapInterop", "OnAreaSelectionChanged");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onCenterChangedEnabled) {
        options.onCenterChanged = function () {
            const callback = Blazor.platform.findMethod(assemblyName, "DevExpress.Viz", "DxVectorMapInterop", "OnCenterChanged");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onClickEnabled) {
        options.onClick = function () {
            const callback = Blazor.platform.findMethod(assemblyName, "DevExpress.Viz", "DxVectorMapInterop", "OnClick");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onMarkerClickEnabled) {
        options.onMarkerClick = function () {
            const callback = Blazor.platform.findMethod(assemblyName, "DevExpress.Viz", "DxVectorMapInterop", "OnMarkerClick");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onMarkerSelectionChangedEnabled) {
        options.onMarkerSelectionChanged = function () {
            const callback = Blazor.platform.findMethod(assemblyName, "DevExpress.Viz", "DxVectorMapInterop", "OnMarkerSelectionChanged");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onSelectionChangedEnabled) {
        options.onSelectionChanged = function () {
            const callback = Blazor.platform.findMethod(assemblyName, "DevExpress.Viz", "DxVectorMapInterop", "OnSelectionChanged");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onTooltipHiddenEnabled) {
        options.onTooltipHidden = function () {
            const callback = Blazor.platform.findMethod(assemblyName, "DevExpress.Viz", "DxVectorMapInterop", "OnTooltipHidden");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onTooltipShownEnabled) {
        options.onTooltipShown = function () {
            const callback = Blazor.platform.findMethod(assemblyName, "DevExpress.Viz", "DxVectorMapInterop", "OnTooltipShown");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onZoomFactorChangedEnabled) {
        options.onZoomFactorChanged = function () {
            const callback = Blazor.platform.findMethod(assemblyName, "DevExpress.Viz", "DxVectorMapInterop", "OnZoomFactorChanged");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    let element = document.getElementById(identifier);
    let instance = new DevExpress.viz.dxVectorMap(element, options);
});
Blazor.registerFunction('BlazorDevExtreme.DxVectorMap.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.viz.dxVectorMap.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.DxVectorMap.GetOption', function (identifier, key) {
    let element = document.getElementById(identifier);
    return DevExpress.viz.dxVectorMap.getInstance(element).option(key);
});
// DevExpress.viz.core interop automatically generated
Blazor.registerFunction('BlazorDevExtreme.Core.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.viz.core.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.Core.GetOption', function (identifier, key) {
    let element = document.getElementById(identifier);
    return DevExpress.viz.core.getInstance(element).option(key);
});
