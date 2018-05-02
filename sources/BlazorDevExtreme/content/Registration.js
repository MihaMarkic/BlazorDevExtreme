const assemblyName = "BlazorDevExtreme";

// DevExpress.DataHelperMixin interop automatically generated
Blazor.registerFunction('BlazorDevExtreme.DataHelperMixin.getDataSource_0', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.DataHelperMixin.getInstance(blazor_element).getDataSource();
});
Blazor.registerFunction('BlazorDevExtreme.DataHelperMixin.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.DataHelperMixin.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.DataHelperMixin.GetOption', function (identifier, key) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.DataHelperMixin.getInstance(blazor_element).option(key);
});
// DevExpress.dxEvent interop automatically generated
Blazor.registerFunction('BlazorDevExtreme.DxEvent.isDefaultPrevented_0', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.dxEvent.getInstance(blazor_element).isDefaultPrevented();
});
Blazor.registerFunction('BlazorDevExtreme.DxEvent.isImmediatePropagationStopped_1', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.dxEvent.getInstance(blazor_element).isImmediatePropagationStopped();
});
Blazor.registerFunction('BlazorDevExtreme.DxEvent.isPropagationStopped_2', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.dxEvent.getInstance(blazor_element).isPropagationStopped();
});
Blazor.registerFunction('BlazorDevExtreme.DxEvent.preventDefault_3', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    DevExpress.dxEvent.getInstance(blazor_element).preventDefault();
});
Blazor.registerFunction('BlazorDevExtreme.DxEvent.stopImmediatePropagation_4', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    DevExpress.dxEvent.getInstance(blazor_element).stopImmediatePropagation();
});
Blazor.registerFunction('BlazorDevExtreme.DxEvent.stopPropagation_5', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    DevExpress.dxEvent.getInstance(blazor_element).stopPropagation();
});
Blazor.registerFunction('BlazorDevExtreme.DxEvent.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.dxEvent.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.DxEvent.GetOption', function (identifier, key) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.dxEvent.getInstance(blazor_element).option(key);
});
// DevExpress.localization interop automatically generated
Blazor.registerFunction('BlazorDevExtreme.Localization.loadMessages_0', function (messages) {
    DevExpress.localization.loadMessages(messages);
});
Blazor.registerFunction('BlazorDevExtreme.Localization.locale_1', function () {
    DevExpress.localization.locale();
});
Blazor.registerFunction('BlazorDevExtreme.Localization.locale_2', function (locale) {
    DevExpress.localization.locale(locale);
});
Blazor.registerFunction('BlazorDevExtreme.Localization.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.localization.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.Localization.GetOption', function (identifier, key) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.localization.getInstance(blazor_element).option(key);
});
// DevExpress.animationPresets interop automatically generated
Blazor.registerFunction('BlazorDevExtreme.AnimationPresets.applyChanges_0', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    DevExpress.animationPresets.getInstance(blazor_element).applyChanges();
});
Blazor.registerFunction('BlazorDevExtreme.AnimationPresets.clear_1', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    DevExpress.animationPresets.getInstance(blazor_element).clear();
});
Blazor.registerFunction('BlazorDevExtreme.AnimationPresets.clear_2', function (identifier, name) {
    let blazor_element = document.getElementById(identifier);
    DevExpress.animationPresets.getInstance(blazor_element).clear(name);
});
Blazor.registerFunction('BlazorDevExtreme.AnimationPresets.getPreset_3', function (identifier, name) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.animationPresets.getInstance(blazor_element).getPreset(name);
});
Blazor.registerFunction('BlazorDevExtreme.AnimationPresets.registerDefaultPresets_4', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    DevExpress.animationPresets.getInstance(blazor_element).registerDefaultPresets();
});
Blazor.registerFunction('BlazorDevExtreme.AnimationPresets.registerPreset_5', function (identifier, name, config) {
    let blazor_element = document.getElementById(identifier);
    DevExpress.animationPresets.getInstance(blazor_element).registerPreset(name, config);
});
Blazor.registerFunction('BlazorDevExtreme.AnimationPresets.resetToDefaults_6', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    DevExpress.animationPresets.getInstance(blazor_element).resetToDefaults();
});
Blazor.registerFunction('BlazorDevExtreme.AnimationPresets.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.animationPresets.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.AnimationPresets.GetOption', function (identifier, key) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.animationPresets.getInstance(blazor_element).option(key);
});
// DevExpress.TransitionExecutor interop automatically generated
Blazor.registerFunction('BlazorDevExtreme.TransitionExecutor.enter_0', function (identifier, elements, animation) {
    let blazor_element = document.getElementById(identifier);
    DevExpress.TransitionExecutor.getInstance(blazor_element).enter(elements, animation);
});
Blazor.registerFunction('BlazorDevExtreme.TransitionExecutor.leave_1', function (identifier, elements, animation) {
    let blazor_element = document.getElementById(identifier);
    DevExpress.TransitionExecutor.getInstance(blazor_element).leave(elements, animation);
});
Blazor.registerFunction('BlazorDevExtreme.TransitionExecutor.reset_2', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    DevExpress.TransitionExecutor.getInstance(blazor_element).reset();
});
Blazor.registerFunction('BlazorDevExtreme.TransitionExecutor.start_3', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.TransitionExecutor.getInstance(blazor_element).start();
});
Blazor.registerFunction('BlazorDevExtreme.TransitionExecutor.stop_4', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    DevExpress.TransitionExecutor.getInstance(blazor_element).stop();
});
Blazor.registerFunction('BlazorDevExtreme.TransitionExecutor.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.TransitionExecutor.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.TransitionExecutor.GetOption', function (identifier, key) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.TransitionExecutor.getInstance(blazor_element).option(key);
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
Blazor.registerFunction('BlazorDevExtreme.Component.beginUpdate_0', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    DevExpress.Component.getInstance(blazor_element).beginUpdate();
});
Blazor.registerFunction('BlazorDevExtreme.Component.endUpdate_1', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    DevExpress.Component.getInstance(blazor_element).endUpdate();
});
Blazor.registerFunction('BlazorDevExtreme.Component.instance_2', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.Component.getInstance(blazor_element).instance();
});
Blazor.registerFunction('BlazorDevExtreme.Component.off_3', function (identifier, eventName) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.Component.getInstance(blazor_element).off(eventName);
});
Blazor.registerFunction('BlazorDevExtreme.Component.off_4', function (identifier, eventName, eventHandler) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.Component.getInstance(blazor_element).off(eventName, eventHandler);
});
Blazor.registerFunction('BlazorDevExtreme.Component.on_5', function (identifier, eventName, eventHandler) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.Component.getInstance(blazor_element).on(eventName, eventHandler);
});
Blazor.registerFunction('BlazorDevExtreme.Component.on_6', function (identifier, events) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.Component.getInstance(blazor_element).on(events);
});
Blazor.registerFunction('BlazorDevExtreme.Component.option_7', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.Component.getInstance(blazor_element).option();
});
Blazor.registerFunction('BlazorDevExtreme.Component.option_8', function (identifier, optionName) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.Component.getInstance(blazor_element).option(optionName);
});
Blazor.registerFunction('BlazorDevExtreme.Component.option_9', function (identifier, optionName, optionValue) {
    let blazor_element = document.getElementById(identifier);
    DevExpress.Component.getInstance(blazor_element).option(optionName, optionValue);
});
Blazor.registerFunction('BlazorDevExtreme.Component.option_10', function (identifier, options) {
    let blazor_element = document.getElementById(identifier);
    DevExpress.Component.getInstance(blazor_element).option(options);
});
Blazor.registerFunction('BlazorDevExtreme.Component.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.Component.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.Component.GetOption', function (identifier, key) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.Component.getInstance(blazor_element).option(key);
});
// DevExpress.DevicesObject interop automatically generated
Blazor.registerFunction('BlazorDevExtreme.DevicesObject.current_0', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.DevicesObject.getInstance(blazor_element).current();
});
Blazor.registerFunction('BlazorDevExtreme.DevicesObject.current_1', function (identifier, deviceName) {
    let blazor_element = document.getElementById(identifier);
    DevExpress.DevicesObject.getInstance(blazor_element).current(deviceName);
});
Blazor.registerFunction('BlazorDevExtreme.DevicesObject.off_2', function (identifier, eventName) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.DevicesObject.getInstance(blazor_element).off(eventName);
});
Blazor.registerFunction('BlazorDevExtreme.DevicesObject.off_3', function (identifier, eventName, eventHandler) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.DevicesObject.getInstance(blazor_element).off(eventName, eventHandler);
});
Blazor.registerFunction('BlazorDevExtreme.DevicesObject.on_4', function (identifier, eventName, eventHandler) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.DevicesObject.getInstance(blazor_element).on(eventName, eventHandler);
});
Blazor.registerFunction('BlazorDevExtreme.DevicesObject.on_5', function (identifier, events) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.DevicesObject.getInstance(blazor_element).on(events);
});
Blazor.registerFunction('BlazorDevExtreme.DevicesObject.orientation_6', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.DevicesObject.getInstance(blazor_element).orientation();
});
Blazor.registerFunction('BlazorDevExtreme.DevicesObject.real_7', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.DevicesObject.getInstance(blazor_element).real();
});
Blazor.registerFunction('BlazorDevExtreme.DevicesObject.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.DevicesObject.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.DevicesObject.GetOption', function (identifier, key) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.DevicesObject.getInstance(blazor_element).option(key);
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
Blazor.registerFunction('BlazorDevExtreme.DOMComponent.defaultOptions_0', function (rule) {
    DevExpress.DOMComponent.defaultOptions(rule);
});
Blazor.registerFunction('BlazorDevExtreme.DOMComponent.getInstance_1', function (element) {
    DevExpress.DOMComponent.getInstance(element);
});
Blazor.registerFunction('BlazorDevExtreme.DOMComponent.dispose_0', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    DevExpress.DOMComponent.getInstance(blazor_element).dispose();
});
Blazor.registerFunction('BlazorDevExtreme.DOMComponent.element_1', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.DOMComponent.getInstance(blazor_element).element();
});
Blazor.registerFunction('BlazorDevExtreme.DOMComponent.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.DOMComponent.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.DOMComponent.GetOption', function (identifier, key) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.DOMComponent.getInstance(blazor_element).option(key);
});
// DevExpress.EndpointSelector interop automatically generated
Blazor.registerFunction('BlazorDevExtreme.EndpointSelector.urlFor_0', function (identifier, key) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.EndpointSelector.getInstance(blazor_element).urlFor(key);
});
Blazor.registerFunction('BlazorDevExtreme.EndpointSelector.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.EndpointSelector.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.EndpointSelector.GetOption', function (identifier, key) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.EndpointSelector.getInstance(blazor_element).option(key);
});
// DevExpress.validationEngine interop automatically generated
Blazor.registerFunction('BlazorDevExtreme.ValidationEngine.getGroupConfig_0', function () {
    DevExpress.validationEngine.getGroupConfig();
});
Blazor.registerFunction('BlazorDevExtreme.ValidationEngine.getGroupConfig_1', function (group) {
    DevExpress.validationEngine.getGroupConfig(group);
});
Blazor.registerFunction('BlazorDevExtreme.ValidationEngine.registerModelForValidation_2', function (model) {
    DevExpress.validationEngine.registerModelForValidation(model);
});
Blazor.registerFunction('BlazorDevExtreme.ValidationEngine.resetGroup_3', function () {
    DevExpress.validationEngine.resetGroup();
});
Blazor.registerFunction('BlazorDevExtreme.ValidationEngine.resetGroup_4', function (group) {
    DevExpress.validationEngine.resetGroup(group);
});
Blazor.registerFunction('BlazorDevExtreme.ValidationEngine.unregisterModelForValidation_5', function (model) {
    DevExpress.validationEngine.unregisterModelForValidation(model);
});
Blazor.registerFunction('BlazorDevExtreme.ValidationEngine.validateGroup_6', function () {
    DevExpress.validationEngine.validateGroup();
});
Blazor.registerFunction('BlazorDevExtreme.ValidationEngine.validateGroup_7', function (group) {
    DevExpress.validationEngine.validateGroup(group);
});
Blazor.registerFunction('BlazorDevExtreme.ValidationEngine.validateModel_8', function (model) {
    DevExpress.validationEngine.validateModel(model);
});
Blazor.registerFunction('BlazorDevExtreme.ValidationEngine.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.validationEngine.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.ValidationEngine.GetOption', function (identifier, key) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.validationEngine.getInstance(blazor_element).option(key);
});
// DevExpress.ui interop automatically generated
Blazor.registerFunction('BlazorDevExtreme.Ui.notify_0', function (message, type, displayTime) {
    DevExpress.ui.notify(message, type, displayTime);
});
Blazor.registerFunction('BlazorDevExtreme.Ui.notify_1', function (options, type, displayTime) {
    DevExpress.ui.notify(options, type, displayTime);
});
Blazor.registerFunction('BlazorDevExtreme.Ui.setTemplateEngine_2', function (templateEngineName) {
    DevExpress.ui.setTemplateEngine(templateEngineName);
});
Blazor.registerFunction('BlazorDevExtreme.Ui.setTemplateEngine_3', function (templateEngineOptions) {
    DevExpress.ui.setTemplateEngine(templateEngineOptions);
});
Blazor.registerFunction('BlazorDevExtreme.Ui.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.ui.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.Ui.GetOption', function (identifier, key) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.ui.getInstance(blazor_element).option(key);
});
// DevExpress.viz interop automatically generated
Blazor.registerFunction('BlazorDevExtreme.Viz.currentPalette_0', function (paletteName) {
    DevExpress.viz.currentPalette(paletteName);
});
Blazor.registerFunction('BlazorDevExtreme.Viz.currentTheme_1', function () {
    DevExpress.viz.currentTheme();
});
Blazor.registerFunction('BlazorDevExtreme.Viz.currentTheme_2', function (platform, colorScheme) {
    DevExpress.viz.currentTheme(platform, colorScheme);
});
Blazor.registerFunction('BlazorDevExtreme.Viz.currentTheme_3', function (theme) {
    DevExpress.viz.currentTheme(theme);
});
Blazor.registerFunction('BlazorDevExtreme.Viz.exportFromMarkup_4', function (markup, options) {
    DevExpress.viz.exportFromMarkup(markup, options);
});
Blazor.registerFunction('BlazorDevExtreme.Viz.getMarkup_5', function (widgetInstances) {
    DevExpress.viz.getMarkup(widgetInstances);
});
Blazor.registerFunction('BlazorDevExtreme.Viz.getPalette_6', function (paletteName) {
    DevExpress.viz.getPalette(paletteName);
});
Blazor.registerFunction('BlazorDevExtreme.Viz.getTheme_7', function (theme) {
    DevExpress.viz.getTheme(theme);
});
Blazor.registerFunction('BlazorDevExtreme.Viz.refreshPaths_8', function () {
    DevExpress.viz.refreshPaths();
});
Blazor.registerFunction('BlazorDevExtreme.Viz.refreshTheme_9', function () {
    DevExpress.viz.refreshTheme();
});
Blazor.registerFunction('BlazorDevExtreme.Viz.registerPalette_10', function (paletteName, palette) {
    DevExpress.viz.registerPalette(paletteName, palette);
});
Blazor.registerFunction('BlazorDevExtreme.Viz.registerTheme_11', function (customTheme, baseTheme) {
    DevExpress.viz.registerTheme(customTheme, baseTheme);
});
Blazor.registerFunction('BlazorDevExtreme.Viz.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.viz.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.Viz.GetOption', function (identifier, key) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.viz.getInstance(blazor_element).option(key);
});
// DevExpress.data.Guid interop automatically generated
Blazor.registerFunction('BlazorDevExtreme.Guid.toString_0', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.data.Guid.getInstance(blazor_element).toString();
});
Blazor.registerFunction('BlazorDevExtreme.Guid.valueOf_1', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.data.Guid.getInstance(blazor_element).valueOf();
});
Blazor.registerFunction('BlazorDevExtreme.Guid.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.data.Guid.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.Guid.GetOption', function (identifier, key) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.data.Guid.getInstance(blazor_element).option(key);
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
Blazor.registerFunction('BlazorDevExtreme.Store.byKey_0', function (identifier, key) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.data.Store.getInstance(blazor_element).byKey(key);
});
Blazor.registerFunction('BlazorDevExtreme.Store.insert_1', function (identifier, values) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.data.Store.getInstance(blazor_element).insert(values);
});
Blazor.registerFunction('BlazorDevExtreme.Store.key_2', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.data.Store.getInstance(blazor_element).key();
});
Blazor.registerFunction('BlazorDevExtreme.Store.keyOf_3', function (identifier, obj) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.data.Store.getInstance(blazor_element).keyOf(obj);
});
Blazor.registerFunction('BlazorDevExtreme.Store.load_4', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.data.Store.getInstance(blazor_element).load();
});
Blazor.registerFunction('BlazorDevExtreme.Store.load_5', function (identifier, options) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.data.Store.getInstance(blazor_element).load(options);
});
Blazor.registerFunction('BlazorDevExtreme.Store.off_6', function (identifier, eventName) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.data.Store.getInstance(blazor_element).off(eventName);
});
Blazor.registerFunction('BlazorDevExtreme.Store.off_7', function (identifier, eventName, eventHandler) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.data.Store.getInstance(blazor_element).off(eventName, eventHandler);
});
Blazor.registerFunction('BlazorDevExtreme.Store.on_8', function (identifier, eventName, eventHandler) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.data.Store.getInstance(blazor_element).on(eventName, eventHandler);
});
Blazor.registerFunction('BlazorDevExtreme.Store.on_9', function (identifier, events) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.data.Store.getInstance(blazor_element).on(events);
});
Blazor.registerFunction('BlazorDevExtreme.Store.remove_10', function (identifier, key) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.data.Store.getInstance(blazor_element).remove(key);
});
Blazor.registerFunction('BlazorDevExtreme.Store.totalCount_11', function (identifier, obj) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.data.Store.getInstance(blazor_element).totalCount(obj);
});
Blazor.registerFunction('BlazorDevExtreme.Store.update_12', function (identifier, key, values) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.data.Store.getInstance(blazor_element).update(key, values);
});
Blazor.registerFunction('BlazorDevExtreme.Store.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.data.Store.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.Store.GetOption', function (identifier, key) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.data.Store.getInstance(blazor_element).option(key);
});
// DevExpress.data.ArrayStore interop automatically generated
Blazor.registerFunction('BlazorDevExtreme.ArrayStore.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    let element = document.getElementById(identifier);
    let instance = new DevExpress.data.ArrayStore(element, options);
});
Blazor.registerFunction('BlazorDevExtreme.ArrayStore.clear_0', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    DevExpress.data.ArrayStore.getInstance(blazor_element).clear();
});
Blazor.registerFunction('BlazorDevExtreme.ArrayStore.createQuery_1', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.data.ArrayStore.getInstance(blazor_element).createQuery();
});
Blazor.registerFunction('BlazorDevExtreme.ArrayStore.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.data.ArrayStore.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.ArrayStore.GetOption', function (identifier, key) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.data.ArrayStore.getInstance(blazor_element).option(key);
});
// DevExpress.data.CustomStore interop automatically generated
Blazor.registerFunction('BlazorDevExtreme.CustomStore.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    let element = document.getElementById(identifier);
    let instance = new DevExpress.data.CustomStore(element, options);
});
Blazor.registerFunction('BlazorDevExtreme.CustomStore.clearRawDataCache_0', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    DevExpress.data.CustomStore.getInstance(blazor_element).clearRawDataCache();
});
Blazor.registerFunction('BlazorDevExtreme.CustomStore.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.data.CustomStore.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.CustomStore.GetOption', function (identifier, key) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.data.CustomStore.getInstance(blazor_element).option(key);
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
Blazor.registerFunction('BlazorDevExtreme.DataSource.cancel_0', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.data.DataSource.getInstance(blazor_element).cancel();
});
Blazor.registerFunction('BlazorDevExtreme.DataSource.dispose_1', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    DevExpress.data.DataSource.getInstance(blazor_element).dispose();
});
Blazor.registerFunction('BlazorDevExtreme.DataSource.filter_2', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.data.DataSource.getInstance(blazor_element).filter();
});
Blazor.registerFunction('BlazorDevExtreme.DataSource.filter_3', function (identifier, filterExpr) {
    let blazor_element = document.getElementById(identifier);
    DevExpress.data.DataSource.getInstance(blazor_element).filter(filterExpr);
});
Blazor.registerFunction('BlazorDevExtreme.DataSource.group_4', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.data.DataSource.getInstance(blazor_element).group();
});
Blazor.registerFunction('BlazorDevExtreme.DataSource.group_5', function (identifier, groupExpr) {
    let blazor_element = document.getElementById(identifier);
    DevExpress.data.DataSource.getInstance(blazor_element).group(groupExpr);
});
Blazor.registerFunction('BlazorDevExtreme.DataSource.isLastPage_6', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.data.DataSource.getInstance(blazor_element).isLastPage();
});
Blazor.registerFunction('BlazorDevExtreme.DataSource.isLoaded_7', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.data.DataSource.getInstance(blazor_element).isLoaded();
});
Blazor.registerFunction('BlazorDevExtreme.DataSource.isLoading_8', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.data.DataSource.getInstance(blazor_element).isLoading();
});
Blazor.registerFunction('BlazorDevExtreme.DataSource.items_9', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.data.DataSource.getInstance(blazor_element).items();
});
Blazor.registerFunction('BlazorDevExtreme.DataSource.key_10', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.data.DataSource.getInstance(blazor_element).key();
});
Blazor.registerFunction('BlazorDevExtreme.DataSource.load_11', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.data.DataSource.getInstance(blazor_element).load();
});
Blazor.registerFunction('BlazorDevExtreme.DataSource.loadOptions_12', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.data.DataSource.getInstance(blazor_element).loadOptions();
});
Blazor.registerFunction('BlazorDevExtreme.DataSource.off_13', function (identifier, eventName) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.data.DataSource.getInstance(blazor_element).off(eventName);
});
Blazor.registerFunction('BlazorDevExtreme.DataSource.off_14', function (identifier, eventName, eventHandler) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.data.DataSource.getInstance(blazor_element).off(eventName, eventHandler);
});
Blazor.registerFunction('BlazorDevExtreme.DataSource.on_15', function (identifier, eventName, eventHandler) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.data.DataSource.getInstance(blazor_element).on(eventName, eventHandler);
});
Blazor.registerFunction('BlazorDevExtreme.DataSource.on_16', function (identifier, events) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.data.DataSource.getInstance(blazor_element).on(events);
});
Blazor.registerFunction('BlazorDevExtreme.DataSource.pageIndex_17', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.data.DataSource.getInstance(blazor_element).pageIndex();
});
Blazor.registerFunction('BlazorDevExtreme.DataSource.pageIndex_18', function (identifier, newIndex) {
    let blazor_element = document.getElementById(identifier);
    DevExpress.data.DataSource.getInstance(blazor_element).pageIndex(newIndex);
});
Blazor.registerFunction('BlazorDevExtreme.DataSource.pageSize_19', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.data.DataSource.getInstance(blazor_element).pageSize();
});
Blazor.registerFunction('BlazorDevExtreme.DataSource.pageSize_20', function (identifier, value) {
    let blazor_element = document.getElementById(identifier);
    DevExpress.data.DataSource.getInstance(blazor_element).pageSize(value);
});
Blazor.registerFunction('BlazorDevExtreme.DataSource.paginate_21', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.data.DataSource.getInstance(blazor_element).paginate();
});
Blazor.registerFunction('BlazorDevExtreme.DataSource.paginate_22', function (identifier, value) {
    let blazor_element = document.getElementById(identifier);
    DevExpress.data.DataSource.getInstance(blazor_element).paginate(value);
});
Blazor.registerFunction('BlazorDevExtreme.DataSource.reload_23', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.data.DataSource.getInstance(blazor_element).reload();
});
Blazor.registerFunction('BlazorDevExtreme.DataSource.requireTotalCount_24', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.data.DataSource.getInstance(blazor_element).requireTotalCount();
});
Blazor.registerFunction('BlazorDevExtreme.DataSource.requireTotalCount_25', function (identifier, value) {
    let blazor_element = document.getElementById(identifier);
    DevExpress.data.DataSource.getInstance(blazor_element).requireTotalCount(value);
});
Blazor.registerFunction('BlazorDevExtreme.DataSource.searchExpr_26', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.data.DataSource.getInstance(blazor_element).searchExpr();
});
Blazor.registerFunction('BlazorDevExtreme.DataSource.searchExpr_27', function (identifier, expr) {
    let blazor_element = document.getElementById(identifier);
    DevExpress.data.DataSource.getInstance(blazor_element).searchExpr(expr);
});
Blazor.registerFunction('BlazorDevExtreme.DataSource.searchOperation_28', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.data.DataSource.getInstance(blazor_element).searchOperation();
});
Blazor.registerFunction('BlazorDevExtreme.DataSource.searchOperation_29', function (identifier, op) {
    let blazor_element = document.getElementById(identifier);
    DevExpress.data.DataSource.getInstance(blazor_element).searchOperation(op);
});
Blazor.registerFunction('BlazorDevExtreme.DataSource.searchValue_30', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.data.DataSource.getInstance(blazor_element).searchValue();
});
Blazor.registerFunction('BlazorDevExtreme.DataSource.searchValue_31', function (identifier, value) {
    let blazor_element = document.getElementById(identifier);
    DevExpress.data.DataSource.getInstance(blazor_element).searchValue(value);
});
Blazor.registerFunction('BlazorDevExtreme.DataSource.select_32', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.data.DataSource.getInstance(blazor_element).select();
});
Blazor.registerFunction('BlazorDevExtreme.DataSource.select_33', function (identifier, expr) {
    let blazor_element = document.getElementById(identifier);
    DevExpress.data.DataSource.getInstance(blazor_element).select(expr);
});
Blazor.registerFunction('BlazorDevExtreme.DataSource.sort_34', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.data.DataSource.getInstance(blazor_element).sort();
});
Blazor.registerFunction('BlazorDevExtreme.DataSource.sort_35', function (identifier, sortExpr) {
    let blazor_element = document.getElementById(identifier);
    DevExpress.data.DataSource.getInstance(blazor_element).sort(sortExpr);
});
Blazor.registerFunction('BlazorDevExtreme.DataSource.store_36', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.data.DataSource.getInstance(blazor_element).store();
});
Blazor.registerFunction('BlazorDevExtreme.DataSource.totalCount_37', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.data.DataSource.getInstance(blazor_element).totalCount();
});
Blazor.registerFunction('BlazorDevExtreme.DataSource.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.data.DataSource.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.DataSource.GetOption', function (identifier, key) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.data.DataSource.getInstance(blazor_element).option(key);
});
// DevExpress.data.LocalStore interop automatically generated
Blazor.registerFunction('BlazorDevExtreme.LocalStore.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    let element = document.getElementById(identifier);
    let instance = new DevExpress.data.LocalStore(element, options);
});
Blazor.registerFunction('BlazorDevExtreme.LocalStore.clear_0', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    DevExpress.data.LocalStore.getInstance(blazor_element).clear();
});
Blazor.registerFunction('BlazorDevExtreme.LocalStore.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.data.LocalStore.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.LocalStore.GetOption', function (identifier, key) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.data.LocalStore.getInstance(blazor_element).option(key);
});
// DevExpress.data.Query interop automatically generated
Blazor.registerFunction('BlazorDevExtreme.Query.aggregate_0', function (identifier, seed, step, finalize) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.data.Query.getInstance(blazor_element).aggregate(seed, step, finalize);
});
Blazor.registerFunction('BlazorDevExtreme.Query.aggregate_1', function (identifier, step) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.data.Query.getInstance(blazor_element).aggregate(step);
});
Blazor.registerFunction('BlazorDevExtreme.Query.avg_2', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.data.Query.getInstance(blazor_element).avg();
});
Blazor.registerFunction('BlazorDevExtreme.Query.avg_3', function (identifier, getter) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.data.Query.getInstance(blazor_element).avg(getter);
});
Blazor.registerFunction('BlazorDevExtreme.Query.count_4', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.data.Query.getInstance(blazor_element).count();
});
Blazor.registerFunction('BlazorDevExtreme.Query.enumerate_5', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.data.Query.getInstance(blazor_element).enumerate();
});
Blazor.registerFunction('BlazorDevExtreme.Query.filter_6', function (identifier, criteria) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.data.Query.getInstance(blazor_element).filter(criteria);
});
Blazor.registerFunction('BlazorDevExtreme.Query.filter_7', function (identifier, predicate) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.data.Query.getInstance(blazor_element).filter(predicate);
});
Blazor.registerFunction('BlazorDevExtreme.Query.groupBy_8', function (identifier, getter) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.data.Query.getInstance(blazor_element).groupBy(getter);
});
Blazor.registerFunction('BlazorDevExtreme.Query.max_9', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.data.Query.getInstance(blazor_element).max();
});
Blazor.registerFunction('BlazorDevExtreme.Query.max_10', function (identifier, getter) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.data.Query.getInstance(blazor_element).max(getter);
});
Blazor.registerFunction('BlazorDevExtreme.Query.min_11', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.data.Query.getInstance(blazor_element).min();
});
Blazor.registerFunction('BlazorDevExtreme.Query.min_12', function (identifier, getter) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.data.Query.getInstance(blazor_element).min(getter);
});
Blazor.registerFunction('BlazorDevExtreme.Query.select_13', function (identifier, getter) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.data.Query.getInstance(blazor_element).select(getter);
});
Blazor.registerFunction('BlazorDevExtreme.Query.slice_14', function (identifier, skip, take) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.data.Query.getInstance(blazor_element).slice(skip, take);
});
Blazor.registerFunction('BlazorDevExtreme.Query.sortBy_15', function (identifier, getter) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.data.Query.getInstance(blazor_element).sortBy(getter);
});
Blazor.registerFunction('BlazorDevExtreme.Query.sortBy_16', function (identifier, getter, desc) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.data.Query.getInstance(blazor_element).sortBy(getter, desc);
});
Blazor.registerFunction('BlazorDevExtreme.Query.sum_17', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.data.Query.getInstance(blazor_element).sum();
});
Blazor.registerFunction('BlazorDevExtreme.Query.sum_18', function (identifier, getter) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.data.Query.getInstance(blazor_element).sum(getter);
});
Blazor.registerFunction('BlazorDevExtreme.Query.thenBy_19', function (identifier, getter) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.data.Query.getInstance(blazor_element).thenBy(getter);
});
Blazor.registerFunction('BlazorDevExtreme.Query.thenBy_20', function (identifier, getter, desc) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.data.Query.getInstance(blazor_element).thenBy(getter, desc);
});
Blazor.registerFunction('BlazorDevExtreme.Query.toArray_21', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.data.Query.getInstance(blazor_element).toArray();
});
Blazor.registerFunction('BlazorDevExtreme.Query.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.data.Query.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.Query.GetOption', function (identifier, key) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.data.Query.getInstance(blazor_element).option(key);
});
// DevExpress.data.ODataContext interop automatically generated
Blazor.registerFunction('BlazorDevExtreme.ODataContext.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    let element = document.getElementById(identifier);
    let instance = new DevExpress.data.ODataContext(element, options);
});
Blazor.registerFunction('BlazorDevExtreme.ODataContext.get_0', function (identifier, operationName, params) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.data.ODataContext.getInstance(blazor_element).get(operationName, params);
});
Blazor.registerFunction('BlazorDevExtreme.ODataContext.invoke_1', function (identifier, operationName, params, httpMethod) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.data.ODataContext.getInstance(blazor_element).invoke(operationName, params, httpMethod);
});
Blazor.registerFunction('BlazorDevExtreme.ODataContext.objectLink_2', function (identifier, entityAlias, key) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.data.ODataContext.getInstance(blazor_element).objectLink(entityAlias, key);
});
Blazor.registerFunction('BlazorDevExtreme.ODataContext.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.data.ODataContext.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.ODataContext.GetOption', function (identifier, key) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.data.ODataContext.getInstance(blazor_element).option(key);
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
Blazor.registerFunction('BlazorDevExtreme.ODataStore.byKey_0', function (identifier, key) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.data.ODataStore.getInstance(blazor_element).byKey(key);
});
Blazor.registerFunction('BlazorDevExtreme.ODataStore.byKey_1', function (identifier, key, extraOptions) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.data.ODataStore.getInstance(blazor_element).byKey(key, extraOptions);
});
Blazor.registerFunction('BlazorDevExtreme.ODataStore.createQuery_2', function (identifier, loadOptions) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.data.ODataStore.getInstance(blazor_element).createQuery(loadOptions);
});
Blazor.registerFunction('BlazorDevExtreme.ODataStore.load_3', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.data.ODataStore.getInstance(blazor_element).load();
});
Blazor.registerFunction('BlazorDevExtreme.ODataStore.load_4', function (identifier, options) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.data.ODataStore.getInstance(blazor_element).load(options);
});
Blazor.registerFunction('BlazorDevExtreme.ODataStore.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.data.ODataStore.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.ODataStore.GetOption', function (identifier, key) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.data.ODataStore.getInstance(blazor_element).option(key);
});
// DevExpress.data.EdmLiteral interop automatically generated
Blazor.registerFunction('BlazorDevExtreme.EdmLiteral.valueOf_0', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.data.EdmLiteral.getInstance(blazor_element).valueOf();
});
Blazor.registerFunction('BlazorDevExtreme.EdmLiteral.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.data.EdmLiteral.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.EdmLiteral.GetOption', function (identifier, key) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.data.EdmLiteral.getInstance(blazor_element).option(key);
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
Blazor.registerFunction('BlazorDevExtreme.PivotGridDataSource.collapseAll_0', function (identifier, id) {
    let blazor_element = document.getElementById(identifier);
    DevExpress.data.PivotGridDataSource.getInstance(blazor_element).collapseAll(id);
});
Blazor.registerFunction('BlazorDevExtreme.PivotGridDataSource.collapseHeaderItem_1', function (identifier, area, path) {
    let blazor_element = document.getElementById(identifier);
    DevExpress.data.PivotGridDataSource.getInstance(blazor_element).collapseHeaderItem(area, path);
});
Blazor.registerFunction('BlazorDevExtreme.PivotGridDataSource.createDrillDownDataSource_2', function (identifier, options) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.data.PivotGridDataSource.getInstance(blazor_element).createDrillDownDataSource(options);
});
Blazor.registerFunction('BlazorDevExtreme.PivotGridDataSource.dispose_3', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    DevExpress.data.PivotGridDataSource.getInstance(blazor_element).dispose();
});
Blazor.registerFunction('BlazorDevExtreme.PivotGridDataSource.expandAll_4', function (identifier, id) {
    let blazor_element = document.getElementById(identifier);
    DevExpress.data.PivotGridDataSource.getInstance(blazor_element).expandAll(id);
});
Blazor.registerFunction('BlazorDevExtreme.PivotGridDataSource.expandHeaderItem_5', function (identifier, area, path) {
    let blazor_element = document.getElementById(identifier);
    DevExpress.data.PivotGridDataSource.getInstance(blazor_element).expandHeaderItem(area, path);
});
Blazor.registerFunction('BlazorDevExtreme.PivotGridDataSource.field_6', function (identifier, id) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.data.PivotGridDataSource.getInstance(blazor_element).field(id);
});
Blazor.registerFunction('BlazorDevExtreme.PivotGridDataSource.field_7', function (identifier, id, options) {
    let blazor_element = document.getElementById(identifier);
    DevExpress.data.PivotGridDataSource.getInstance(blazor_element).field(id, options);
});
Blazor.registerFunction('BlazorDevExtreme.PivotGridDataSource.fields_8', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.data.PivotGridDataSource.getInstance(blazor_element).fields();
});
Blazor.registerFunction('BlazorDevExtreme.PivotGridDataSource.fields_9', function (identifier, fields) {
    let blazor_element = document.getElementById(identifier);
    DevExpress.data.PivotGridDataSource.getInstance(blazor_element).fields(fields);
});
Blazor.registerFunction('BlazorDevExtreme.PivotGridDataSource.filter_10', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.data.PivotGridDataSource.getInstance(blazor_element).filter();
});
Blazor.registerFunction('BlazorDevExtreme.PivotGridDataSource.filter_11', function (identifier, filterExpr) {
    let blazor_element = document.getElementById(identifier);
    DevExpress.data.PivotGridDataSource.getInstance(blazor_element).filter(filterExpr);
});
Blazor.registerFunction('BlazorDevExtreme.PivotGridDataSource.getAreaFields_12', function (identifier, area, collectGroups) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.data.PivotGridDataSource.getInstance(blazor_element).getAreaFields(area, collectGroups);
});
Blazor.registerFunction('BlazorDevExtreme.PivotGridDataSource.getData_13', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.data.PivotGridDataSource.getInstance(blazor_element).getData();
});
Blazor.registerFunction('BlazorDevExtreme.PivotGridDataSource.isLoading_14', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.data.PivotGridDataSource.getInstance(blazor_element).isLoading();
});
Blazor.registerFunction('BlazorDevExtreme.PivotGridDataSource.load_15', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.data.PivotGridDataSource.getInstance(blazor_element).load();
});
Blazor.registerFunction('BlazorDevExtreme.PivotGridDataSource.off_16', function (identifier, eventName) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.data.PivotGridDataSource.getInstance(blazor_element).off(eventName);
});
Blazor.registerFunction('BlazorDevExtreme.PivotGridDataSource.off_17', function (identifier, eventName, eventHandler) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.data.PivotGridDataSource.getInstance(blazor_element).off(eventName, eventHandler);
});
Blazor.registerFunction('BlazorDevExtreme.PivotGridDataSource.on_18', function (identifier, eventName, eventHandler) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.data.PivotGridDataSource.getInstance(blazor_element).on(eventName, eventHandler);
});
Blazor.registerFunction('BlazorDevExtreme.PivotGridDataSource.on_19', function (identifier, events) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.data.PivotGridDataSource.getInstance(blazor_element).on(events);
});
Blazor.registerFunction('BlazorDevExtreme.PivotGridDataSource.reload_20', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.data.PivotGridDataSource.getInstance(blazor_element).reload();
});
Blazor.registerFunction('BlazorDevExtreme.PivotGridDataSource.state_21', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.data.PivotGridDataSource.getInstance(blazor_element).state();
});
Blazor.registerFunction('BlazorDevExtreme.PivotGridDataSource.state_22', function (identifier, state) {
    let blazor_element = document.getElementById(identifier);
    DevExpress.data.PivotGridDataSource.getInstance(blazor_element).state(state);
});
Blazor.registerFunction('BlazorDevExtreme.PivotGridDataSource.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.data.PivotGridDataSource.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.PivotGridDataSource.GetOption', function (identifier, key) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.data.PivotGridDataSource.getInstance(blazor_element).option(key);
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
    let blazor_element = document.getElementById(identifier);
    return DevExpress.data.XmlaStore.getInstance(blazor_element).option(key);
});
// DevExpress.core.EventsMixin interop automatically generated
Blazor.registerFunction('BlazorDevExtreme.EventsMixin.off_0', function (identifier, eventName) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.core.EventsMixin.getInstance(blazor_element).off(eventName);
});
Blazor.registerFunction('BlazorDevExtreme.EventsMixin.off_1', function (identifier, eventName, eventHandler) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.core.EventsMixin.getInstance(blazor_element).off(eventName, eventHandler);
});
Blazor.registerFunction('BlazorDevExtreme.EventsMixin.on_2', function (identifier, eventName, eventHandler) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.core.EventsMixin.getInstance(blazor_element).on(eventName, eventHandler);
});
Blazor.registerFunction('BlazorDevExtreme.EventsMixin.on_3', function (identifier, events) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.core.EventsMixin.getInstance(blazor_element).on(events);
});
Blazor.registerFunction('BlazorDevExtreme.EventsMixin.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.core.EventsMixin.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.EventsMixin.GetOption', function (identifier, key) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.core.EventsMixin.getInstance(blazor_element).option(key);
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
Blazor.registerFunction('BlazorDevExtreme.DxCommand.execute_0', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    DevExpress.framework.dxCommand.getInstance(blazor_element).execute();
});
Blazor.registerFunction('BlazorDevExtreme.DxCommand.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.framework.dxCommand.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.DxCommand.GetOption', function (identifier, key) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.framework.dxCommand.getInstance(blazor_element).option(key);
});
// DevExpress.framework.Router interop automatically generated
Blazor.registerFunction('BlazorDevExtreme.Router.format_0', function (identifier, obj) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.framework.Router.getInstance(blazor_element).format(obj);
});
Blazor.registerFunction('BlazorDevExtreme.Router.parse_1', function (identifier, uri) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.framework.Router.getInstance(blazor_element).parse(uri);
});
Blazor.registerFunction('BlazorDevExtreme.Router.register_2', function (identifier, pattern, defaults, constraints) {
    let blazor_element = document.getElementById(identifier);
    DevExpress.framework.Router.getInstance(blazor_element).register(pattern, defaults, constraints);
});
Blazor.registerFunction('BlazorDevExtreme.Router.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.framework.Router.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.Router.GetOption', function (identifier, key) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.framework.Router.getInstance(blazor_element).option(key);
});
// DevExpress.framework.StateManager interop automatically generated
Blazor.registerFunction('BlazorDevExtreme.StateManager.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    let element = document.getElementById(identifier);
    let instance = new DevExpress.framework.StateManager(element, options);
});
Blazor.registerFunction('BlazorDevExtreme.StateManager.addStateSource_0', function (identifier, stateSource) {
    let blazor_element = document.getElementById(identifier);
    DevExpress.framework.StateManager.getInstance(blazor_element).addStateSource(stateSource);
});
Blazor.registerFunction('BlazorDevExtreme.StateManager.clearState_1', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    DevExpress.framework.StateManager.getInstance(blazor_element).clearState();
});
Blazor.registerFunction('BlazorDevExtreme.StateManager.removeStateSource_2', function (identifier, stateSource) {
    let blazor_element = document.getElementById(identifier);
    DevExpress.framework.StateManager.getInstance(blazor_element).removeStateSource(stateSource);
});
Blazor.registerFunction('BlazorDevExtreme.StateManager.restoreState_3', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    DevExpress.framework.StateManager.getInstance(blazor_element).restoreState();
});
Blazor.registerFunction('BlazorDevExtreme.StateManager.saveState_4', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    DevExpress.framework.StateManager.getInstance(blazor_element).saveState();
});
Blazor.registerFunction('BlazorDevExtreme.StateManager.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.framework.StateManager.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.StateManager.GetOption', function (identifier, key) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.framework.StateManager.getInstance(blazor_element).option(key);
});
// DevExpress.framework.ViewCache interop automatically generated
Blazor.registerFunction('BlazorDevExtreme.ViewCache.clear_0', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    DevExpress.framework.ViewCache.getInstance(blazor_element).clear();
});
Blazor.registerFunction('BlazorDevExtreme.ViewCache.getView_1', function (identifier, key) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.framework.ViewCache.getInstance(blazor_element).getView(key);
});
Blazor.registerFunction('BlazorDevExtreme.ViewCache.hasView_2', function (identifier, key) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.framework.ViewCache.getInstance(blazor_element).hasView(key);
});
Blazor.registerFunction('BlazorDevExtreme.ViewCache.off_3', function (identifier, eventName) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.framework.ViewCache.getInstance(blazor_element).off(eventName);
});
Blazor.registerFunction('BlazorDevExtreme.ViewCache.off_4', function (identifier, eventName, eventHandler) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.framework.ViewCache.getInstance(blazor_element).off(eventName, eventHandler);
});
Blazor.registerFunction('BlazorDevExtreme.ViewCache.on_5', function (identifier, eventName, eventHandler) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.framework.ViewCache.getInstance(blazor_element).on(eventName, eventHandler);
});
Blazor.registerFunction('BlazorDevExtreme.ViewCache.on_6', function (identifier, events) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.framework.ViewCache.getInstance(blazor_element).on(events);
});
Blazor.registerFunction('BlazorDevExtreme.ViewCache.removeView_7', function (identifier, key) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.framework.ViewCache.getInstance(blazor_element).removeView(key);
});
Blazor.registerFunction('BlazorDevExtreme.ViewCache.setView_8', function (identifier, key, viewInfo) {
    let blazor_element = document.getElementById(identifier);
    DevExpress.framework.ViewCache.getInstance(blazor_element).setView(key, viewInfo);
});
Blazor.registerFunction('BlazorDevExtreme.ViewCache.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.framework.ViewCache.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.ViewCache.GetOption', function (identifier, key) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.framework.ViewCache.getInstance(blazor_element).option(key);
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
    let blazor_element = document.getElementById(identifier);
    return DevExpress.framework.dxCommandContainer.getInstance(blazor_element).option(key);
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
    let blazor_element = document.getElementById(identifier);
    return DevExpress.framework.dxView.getInstance(blazor_element).option(key);
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
    let blazor_element = document.getElementById(identifier);
    return DevExpress.framework.dxLayout.getInstance(blazor_element).option(key);
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
    let blazor_element = document.getElementById(identifier);
    return DevExpress.framework.dxViewPlaceholder.getInstance(blazor_element).option(key);
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
    let blazor_element = document.getElementById(identifier);
    return DevExpress.framework.dxTransition.getInstance(blazor_element).option(key);
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
    let blazor_element = document.getElementById(identifier);
    return DevExpress.framework.dxContentPlaceholder.getInstance(blazor_element).option(key);
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
    let blazor_element = document.getElementById(identifier);
    return DevExpress.framework.dxContent.getInstance(blazor_element).option(key);
});
// DevExpress.framework.html.HtmlApplication interop automatically generated
Blazor.registerFunction('BlazorDevExtreme.HtmlApplication.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    let element = document.getElementById(identifier);
    let instance = new DevExpress.framework.html.HtmlApplication(element, options);
});
Blazor.registerFunction('BlazorDevExtreme.HtmlApplication.back_0', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    DevExpress.framework.html.HtmlApplication.getInstance(blazor_element).back();
});
Blazor.registerFunction('BlazorDevExtreme.HtmlApplication.canBack_1', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.framework.html.HtmlApplication.getInstance(blazor_element).canBack();
});
Blazor.registerFunction('BlazorDevExtreme.HtmlApplication.clearState_2', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    DevExpress.framework.html.HtmlApplication.getInstance(blazor_element).clearState();
});
Blazor.registerFunction('BlazorDevExtreme.HtmlApplication.createNavigation_3', function (identifier, navigationConfig) {
    let blazor_element = document.getElementById(identifier);
    DevExpress.framework.html.HtmlApplication.getInstance(blazor_element).createNavigation(navigationConfig);
});
Blazor.registerFunction('BlazorDevExtreme.HtmlApplication.getViewTemplate_4', function (identifier, viewName) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.framework.html.HtmlApplication.getInstance(blazor_element).getViewTemplate(viewName);
});
Blazor.registerFunction('BlazorDevExtreme.HtmlApplication.getViewTemplateInfo_5', function (identifier, viewName) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.framework.html.HtmlApplication.getInstance(blazor_element).getViewTemplateInfo(viewName);
});
Blazor.registerFunction('BlazorDevExtreme.HtmlApplication.loadTemplates_6', function (identifier, source) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.framework.html.HtmlApplication.getInstance(blazor_element).loadTemplates(source);
});
Blazor.registerFunction('BlazorDevExtreme.HtmlApplication.navigate_7', function (identifier, uri) {
    let blazor_element = document.getElementById(identifier);
    DevExpress.framework.html.HtmlApplication.getInstance(blazor_element).navigate(uri);
});
Blazor.registerFunction('BlazorDevExtreme.HtmlApplication.navigate_8', function (identifier, uri, options) {
    let blazor_element = document.getElementById(identifier);
    DevExpress.framework.html.HtmlApplication.getInstance(blazor_element).navigate(uri, options);
});
Blazor.registerFunction('BlazorDevExtreme.HtmlApplication.off_9', function (identifier, eventName) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.framework.html.HtmlApplication.getInstance(blazor_element).off(eventName);
});
Blazor.registerFunction('BlazorDevExtreme.HtmlApplication.off_10', function (identifier, eventName, eventHandler) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.framework.html.HtmlApplication.getInstance(blazor_element).off(eventName, eventHandler);
});
Blazor.registerFunction('BlazorDevExtreme.HtmlApplication.on_11', function (identifier, eventName, eventHandler) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.framework.html.HtmlApplication.getInstance(blazor_element).on(eventName, eventHandler);
});
Blazor.registerFunction('BlazorDevExtreme.HtmlApplication.on_12', function (identifier, events) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.framework.html.HtmlApplication.getInstance(blazor_element).on(events);
});
Blazor.registerFunction('BlazorDevExtreme.HtmlApplication.renderNavigation_13', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    DevExpress.framework.html.HtmlApplication.getInstance(blazor_element).renderNavigation();
});
Blazor.registerFunction('BlazorDevExtreme.HtmlApplication.restoreState_14', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    DevExpress.framework.html.HtmlApplication.getInstance(blazor_element).restoreState();
});
Blazor.registerFunction('BlazorDevExtreme.HtmlApplication.saveState_15', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    DevExpress.framework.html.HtmlApplication.getInstance(blazor_element).saveState();
});
Blazor.registerFunction('BlazorDevExtreme.HtmlApplication.templateContext_16', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.framework.html.HtmlApplication.getInstance(blazor_element).templateContext();
});
Blazor.registerFunction('BlazorDevExtreme.HtmlApplication.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.framework.html.HtmlApplication.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.HtmlApplication.GetOption', function (identifier, key) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.framework.html.HtmlApplication.getInstance(blazor_element).option(key);
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
Blazor.registerFunction('BlazorDevExtreme.DxAccordion.collapseItem_0', function (identifier, index) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.ui.dxAccordion.getInstance(blazor_element).collapseItem(index);
});
Blazor.registerFunction('BlazorDevExtreme.DxAccordion.expandItem_1', function (identifier, index) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.ui.dxAccordion.getInstance(blazor_element).expandItem(index);
});
Blazor.registerFunction('BlazorDevExtreme.DxAccordion.updateDimensions_2', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.ui.dxAccordion.getInstance(blazor_element).updateDimensions();
});
Blazor.registerFunction('BlazorDevExtreme.DxAccordion.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.ui.dxAccordion.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.DxAccordion.GetOption', function (identifier, key) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.ui.dxAccordion.getInstance(blazor_element).option(key);
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
Blazor.registerFunction('BlazorDevExtreme.DxActionSheet.hide_0', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.ui.dxActionSheet.getInstance(blazor_element).hide();
});
Blazor.registerFunction('BlazorDevExtreme.DxActionSheet.show_1', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.ui.dxActionSheet.getInstance(blazor_element).show();
});
Blazor.registerFunction('BlazorDevExtreme.DxActionSheet.toggle_2', function (identifier, showing) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.ui.dxActionSheet.getInstance(blazor_element).toggle(showing);
});
Blazor.registerFunction('BlazorDevExtreme.DxActionSheet.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.ui.dxActionSheet.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.DxActionSheet.GetOption', function (identifier, key) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.ui.dxActionSheet.getInstance(blazor_element).option(key);
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
    let blazor_element = document.getElementById(identifier);
    return DevExpress.ui.dxAutocomplete.getInstance(blazor_element).option(key);
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
    let blazor_element = document.getElementById(identifier);
    return DevExpress.ui.dxBox.getInstance(blazor_element).option(key);
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
    let blazor_element = document.getElementById(identifier);
    return DevExpress.ui.dxButton.getInstance(blazor_element).option(key);
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
    let blazor_element = document.getElementById(identifier);
    return DevExpress.ui.dxCalendar.getInstance(blazor_element).option(key);
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
    let blazor_element = document.getElementById(identifier);
    return DevExpress.ui.dxCheckBox.getInstance(blazor_element).option(key);
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
    let blazor_element = document.getElementById(identifier);
    return DevExpress.ui.dxColorBox.getInstance(blazor_element).option(key);
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
Blazor.registerFunction('BlazorDevExtreme.DxContextMenu.hide_0', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.ui.dxContextMenu.getInstance(blazor_element).hide();
});
Blazor.registerFunction('BlazorDevExtreme.DxContextMenu.show_1', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.ui.dxContextMenu.getInstance(blazor_element).show();
});
Blazor.registerFunction('BlazorDevExtreme.DxContextMenu.toggle_2', function (identifier, showing) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.ui.dxContextMenu.getInstance(blazor_element).toggle(showing);
});
Blazor.registerFunction('BlazorDevExtreme.DxContextMenu.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.ui.dxContextMenu.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.DxContextMenu.GetOption', function (identifier, key) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.ui.dxContextMenu.getInstance(blazor_element).option(key);
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
Blazor.registerFunction('BlazorDevExtreme.GridBase.beginCustomLoading_0', function (identifier, messageText) {
    let blazor_element = document.getElementById(identifier);
    DevExpress.ui.GridBase.getInstance(blazor_element).beginCustomLoading(messageText);
});
Blazor.registerFunction('BlazorDevExtreme.GridBase.byKey_1', function (identifier, key) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.ui.GridBase.getInstance(blazor_element).byKey(key);
});
Blazor.registerFunction('BlazorDevExtreme.GridBase.cancelEditData_2', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    DevExpress.ui.GridBase.getInstance(blazor_element).cancelEditData();
});
Blazor.registerFunction('BlazorDevExtreme.GridBase.cellValue_3', function (identifier, rowIndex, dataField) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.ui.GridBase.getInstance(blazor_element).cellValue(rowIndex, dataField);
});
Blazor.registerFunction('BlazorDevExtreme.GridBase.cellValue_4', function (identifier, rowIndex, dataField, value) {
    let blazor_element = document.getElementById(identifier);
    DevExpress.ui.GridBase.getInstance(blazor_element).cellValue(rowIndex, dataField, value);
});
Blazor.registerFunction('BlazorDevExtreme.GridBase.cellValue_5', function (identifier, rowIndex, visibleColumnIndex) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.ui.GridBase.getInstance(blazor_element).cellValue(rowIndex, visibleColumnIndex);
});
Blazor.registerFunction('BlazorDevExtreme.GridBase.cellValue_6', function (identifier, rowIndex, visibleColumnIndex, value) {
    let blazor_element = document.getElementById(identifier);
    DevExpress.ui.GridBase.getInstance(blazor_element).cellValue(rowIndex, visibleColumnIndex, value);
});
Blazor.registerFunction('BlazorDevExtreme.GridBase.clearFilter_7', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    DevExpress.ui.GridBase.getInstance(blazor_element).clearFilter();
});
Blazor.registerFunction('BlazorDevExtreme.GridBase.clearFilter_8', function (identifier, filterName) {
    let blazor_element = document.getElementById(identifier);
    DevExpress.ui.GridBase.getInstance(blazor_element).clearFilter(filterName);
});
Blazor.registerFunction('BlazorDevExtreme.GridBase.clearSelection_9', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    DevExpress.ui.GridBase.getInstance(blazor_element).clearSelection();
});
Blazor.registerFunction('BlazorDevExtreme.GridBase.clearSorting_10', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    DevExpress.ui.GridBase.getInstance(blazor_element).clearSorting();
});
Blazor.registerFunction('BlazorDevExtreme.GridBase.closeEditCell_11', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    DevExpress.ui.GridBase.getInstance(blazor_element).closeEditCell();
});
Blazor.registerFunction('BlazorDevExtreme.GridBase.collapseAdaptiveDetailRow_12', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    DevExpress.ui.GridBase.getInstance(blazor_element).collapseAdaptiveDetailRow();
});
Blazor.registerFunction('BlazorDevExtreme.GridBase.columnCount_13', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.ui.GridBase.getInstance(blazor_element).columnCount();
});
Blazor.registerFunction('BlazorDevExtreme.GridBase.columnOption_14', function (identifier, id) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.ui.GridBase.getInstance(blazor_element).columnOption(id);
});
Blazor.registerFunction('BlazorDevExtreme.GridBase.columnOption_15', function (identifier, id, optionName) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.ui.GridBase.getInstance(blazor_element).columnOption(id, optionName);
});
Blazor.registerFunction('BlazorDevExtreme.GridBase.columnOption_16', function (identifier, id, optionName, optionValue) {
    let blazor_element = document.getElementById(identifier);
    DevExpress.ui.GridBase.getInstance(blazor_element).columnOption(id, optionName, optionValue);
});
Blazor.registerFunction('BlazorDevExtreme.GridBase.columnOption_17', function (identifier, id, options) {
    let blazor_element = document.getElementById(identifier);
    DevExpress.ui.GridBase.getInstance(blazor_element).columnOption(id, options);
});
Blazor.registerFunction('BlazorDevExtreme.GridBase.deleteColumn_18', function (identifier, id) {
    let blazor_element = document.getElementById(identifier);
    DevExpress.ui.GridBase.getInstance(blazor_element).deleteColumn(id);
});
Blazor.registerFunction('BlazorDevExtreme.GridBase.deleteRow_19', function (identifier, rowIndex) {
    let blazor_element = document.getElementById(identifier);
    DevExpress.ui.GridBase.getInstance(blazor_element).deleteRow(rowIndex);
});
Blazor.registerFunction('BlazorDevExtreme.GridBase.deselectAll_20', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.ui.GridBase.getInstance(blazor_element).deselectAll();
});
Blazor.registerFunction('BlazorDevExtreme.GridBase.deselectRows_21', function (identifier, keys) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.ui.GridBase.getInstance(blazor_element).deselectRows(keys);
});
Blazor.registerFunction('BlazorDevExtreme.GridBase.editCell_22', function (identifier, rowIndex, dataField) {
    let blazor_element = document.getElementById(identifier);
    DevExpress.ui.GridBase.getInstance(blazor_element).editCell(rowIndex, dataField);
});
Blazor.registerFunction('BlazorDevExtreme.GridBase.editCell_23', function (identifier, rowIndex, visibleColumnIndex) {
    let blazor_element = document.getElementById(identifier);
    DevExpress.ui.GridBase.getInstance(blazor_element).editCell(rowIndex, visibleColumnIndex);
});
Blazor.registerFunction('BlazorDevExtreme.GridBase.editRow_24', function (identifier, rowIndex) {
    let blazor_element = document.getElementById(identifier);
    DevExpress.ui.GridBase.getInstance(blazor_element).editRow(rowIndex);
});
Blazor.registerFunction('BlazorDevExtreme.GridBase.endCustomLoading_25', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    DevExpress.ui.GridBase.getInstance(blazor_element).endCustomLoading();
});
Blazor.registerFunction('BlazorDevExtreme.GridBase.expandAdaptiveDetailRow_26', function (identifier, key) {
    let blazor_element = document.getElementById(identifier);
    DevExpress.ui.GridBase.getInstance(blazor_element).expandAdaptiveDetailRow(key);
});
Blazor.registerFunction('BlazorDevExtreme.GridBase.filter_27', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.ui.GridBase.getInstance(blazor_element).filter();
});
Blazor.registerFunction('BlazorDevExtreme.GridBase.filter_28', function (identifier, filterExpr) {
    let blazor_element = document.getElementById(identifier);
    DevExpress.ui.GridBase.getInstance(blazor_element).filter(filterExpr);
});
Blazor.registerFunction('BlazorDevExtreme.GridBase.focus_29', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    DevExpress.ui.GridBase.getInstance(blazor_element).focus();
});
Blazor.registerFunction('BlazorDevExtreme.GridBase.focus_30', function (identifier, element) {
    let blazor_element = document.getElementById(identifier);
    DevExpress.ui.GridBase.getInstance(blazor_element).focus(element);
});
Blazor.registerFunction('BlazorDevExtreme.GridBase.getCellElement_31', function (identifier, rowIndex, dataField) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.ui.GridBase.getInstance(blazor_element).getCellElement(rowIndex, dataField);
});
Blazor.registerFunction('BlazorDevExtreme.GridBase.getCellElement_32', function (identifier, rowIndex, visibleColumnIndex) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.ui.GridBase.getInstance(blazor_element).getCellElement(rowIndex, visibleColumnIndex);
});
Blazor.registerFunction('BlazorDevExtreme.GridBase.getCombinedFilter_33', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.ui.GridBase.getInstance(blazor_element).getCombinedFilter();
});
Blazor.registerFunction('BlazorDevExtreme.GridBase.getCombinedFilter_34', function (identifier, returnDataField) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.ui.GridBase.getInstance(blazor_element).getCombinedFilter(returnDataField);
});
Blazor.registerFunction('BlazorDevExtreme.GridBase.getDataSource_35', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.ui.GridBase.getInstance(blazor_element).getDataSource();
});
Blazor.registerFunction('BlazorDevExtreme.GridBase.getKeyByRowIndex_36', function (identifier, rowIndex) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.ui.GridBase.getInstance(blazor_element).getKeyByRowIndex(rowIndex);
});
Blazor.registerFunction('BlazorDevExtreme.GridBase.getRowElement_37', function (identifier, rowIndex) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.ui.GridBase.getInstance(blazor_element).getRowElement(rowIndex);
});
Blazor.registerFunction('BlazorDevExtreme.GridBase.getRowIndexByKey_38', function (identifier, key) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.ui.GridBase.getInstance(blazor_element).getRowIndexByKey(key);
});
Blazor.registerFunction('BlazorDevExtreme.GridBase.getScrollable_39', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.ui.GridBase.getInstance(blazor_element).getScrollable();
});
Blazor.registerFunction('BlazorDevExtreme.GridBase.hasEditData_40', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.ui.GridBase.getInstance(blazor_element).hasEditData();
});
Blazor.registerFunction('BlazorDevExtreme.GridBase.hideColumnChooser_41', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    DevExpress.ui.GridBase.getInstance(blazor_element).hideColumnChooser();
});
Blazor.registerFunction('BlazorDevExtreme.GridBase.isAdaptiveDetailRowExpanded_42', function (identifier, key) {
    let blazor_element = document.getElementById(identifier);
    DevExpress.ui.GridBase.getInstance(blazor_element).isAdaptiveDetailRowExpanded(key);
});
Blazor.registerFunction('BlazorDevExtreme.GridBase.isRowSelected_43', function (identifier, key) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.ui.GridBase.getInstance(blazor_element).isRowSelected(key);
});
Blazor.registerFunction('BlazorDevExtreme.GridBase.keyOf_44', function (identifier, obj) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.ui.GridBase.getInstance(blazor_element).keyOf(obj);
});
Blazor.registerFunction('BlazorDevExtreme.GridBase.pageCount_45', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.ui.GridBase.getInstance(blazor_element).pageCount();
});
Blazor.registerFunction('BlazorDevExtreme.GridBase.pageIndex_46', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.ui.GridBase.getInstance(blazor_element).pageIndex();
});
Blazor.registerFunction('BlazorDevExtreme.GridBase.pageIndex_47', function (identifier, newIndex) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.ui.GridBase.getInstance(blazor_element).pageIndex(newIndex);
});
Blazor.registerFunction('BlazorDevExtreme.GridBase.pageSize_48', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.ui.GridBase.getInstance(blazor_element).pageSize();
});
Blazor.registerFunction('BlazorDevExtreme.GridBase.pageSize_49', function (identifier, value) {
    let blazor_element = document.getElementById(identifier);
    DevExpress.ui.GridBase.getInstance(blazor_element).pageSize(value);
});
Blazor.registerFunction('BlazorDevExtreme.GridBase.refresh_50', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.ui.GridBase.getInstance(blazor_element).refresh();
});
Blazor.registerFunction('BlazorDevExtreme.GridBase.repaintRows_51', function (identifier, rowIndexes) {
    let blazor_element = document.getElementById(identifier);
    DevExpress.ui.GridBase.getInstance(blazor_element).repaintRows(rowIndexes);
});
Blazor.registerFunction('BlazorDevExtreme.GridBase.saveEditData_52', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.ui.GridBase.getInstance(blazor_element).saveEditData();
});
Blazor.registerFunction('BlazorDevExtreme.GridBase.searchByText_53', function (identifier, text) {
    let blazor_element = document.getElementById(identifier);
    DevExpress.ui.GridBase.getInstance(blazor_element).searchByText(text);
});
Blazor.registerFunction('BlazorDevExtreme.GridBase.selectAll_54', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.ui.GridBase.getInstance(blazor_element).selectAll();
});
Blazor.registerFunction('BlazorDevExtreme.GridBase.selectRows_55', function (identifier, keys, preserve) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.ui.GridBase.getInstance(blazor_element).selectRows(keys, preserve);
});
Blazor.registerFunction('BlazorDevExtreme.GridBase.selectRowsByIndexes_56', function (identifier, indexes) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.ui.GridBase.getInstance(blazor_element).selectRowsByIndexes(indexes);
});
Blazor.registerFunction('BlazorDevExtreme.GridBase.showColumnChooser_57', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    DevExpress.ui.GridBase.getInstance(blazor_element).showColumnChooser();
});
Blazor.registerFunction('BlazorDevExtreme.GridBase.state_58', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.ui.GridBase.getInstance(blazor_element).state();
});
Blazor.registerFunction('BlazorDevExtreme.GridBase.state_59', function (identifier, state) {
    let blazor_element = document.getElementById(identifier);
    DevExpress.ui.GridBase.getInstance(blazor_element).state(state);
});
Blazor.registerFunction('BlazorDevExtreme.GridBase.undeleteRow_60', function (identifier, rowIndex) {
    let blazor_element = document.getElementById(identifier);
    DevExpress.ui.GridBase.getInstance(blazor_element).undeleteRow(rowIndex);
});
Blazor.registerFunction('BlazorDevExtreme.GridBase.updateDimensions_61', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    DevExpress.ui.GridBase.getInstance(blazor_element).updateDimensions();
});
Blazor.registerFunction('BlazorDevExtreme.GridBase.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.ui.GridBase.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.GridBase.GetOption', function (identifier, key) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.ui.GridBase.getInstance(blazor_element).option(key);
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
Blazor.registerFunction('BlazorDevExtreme.DxDataGrid.addColumn_0', function (identifier, columnOptions) {
    let blazor_element = document.getElementById(identifier);
    DevExpress.ui.dxDataGrid.getInstance(blazor_element).addColumn(columnOptions);
});
Blazor.registerFunction('BlazorDevExtreme.DxDataGrid.addRow_1', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    DevExpress.ui.dxDataGrid.getInstance(blazor_element).addRow();
});
Blazor.registerFunction('BlazorDevExtreme.DxDataGrid.clearGrouping_2', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    DevExpress.ui.dxDataGrid.getInstance(blazor_element).clearGrouping();
});
Blazor.registerFunction('BlazorDevExtreme.DxDataGrid.collapseAll_3', function (identifier, groupIndex) {
    let blazor_element = document.getElementById(identifier);
    DevExpress.ui.dxDataGrid.getInstance(blazor_element).collapseAll(groupIndex);
});
Blazor.registerFunction('BlazorDevExtreme.DxDataGrid.collapseRow_4', function (identifier, key) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.ui.dxDataGrid.getInstance(blazor_element).collapseRow(key);
});
Blazor.registerFunction('BlazorDevExtreme.DxDataGrid.expandAll_5', function (identifier, groupIndex) {
    let blazor_element = document.getElementById(identifier);
    DevExpress.ui.dxDataGrid.getInstance(blazor_element).expandAll(groupIndex);
});
Blazor.registerFunction('BlazorDevExtreme.DxDataGrid.expandRow_6', function (identifier, key) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.ui.dxDataGrid.getInstance(blazor_element).expandRow(key);
});
Blazor.registerFunction('BlazorDevExtreme.DxDataGrid.exportToExcel_7', function (identifier, selectionOnly) {
    let blazor_element = document.getElementById(identifier);
    DevExpress.ui.dxDataGrid.getInstance(blazor_element).exportToExcel(selectionOnly);
});
Blazor.registerFunction('BlazorDevExtreme.DxDataGrid.getSelectedRowKeys_8', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.ui.dxDataGrid.getInstance(blazor_element).getSelectedRowKeys();
});
Blazor.registerFunction('BlazorDevExtreme.DxDataGrid.getSelectedRowsData_9', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.ui.dxDataGrid.getInstance(blazor_element).getSelectedRowsData();
});
Blazor.registerFunction('BlazorDevExtreme.DxDataGrid.getTotalSummaryValue_10', function (identifier, summaryItemName) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.ui.dxDataGrid.getInstance(blazor_element).getTotalSummaryValue(summaryItemName);
});
Blazor.registerFunction('BlazorDevExtreme.DxDataGrid.getVisibleColumns_11', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.ui.dxDataGrid.getInstance(blazor_element).getVisibleColumns();
});
Blazor.registerFunction('BlazorDevExtreme.DxDataGrid.getVisibleColumns_12', function (identifier, headerLevel) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.ui.dxDataGrid.getInstance(blazor_element).getVisibleColumns(headerLevel);
});
Blazor.registerFunction('BlazorDevExtreme.DxDataGrid.getVisibleRows_13', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.ui.dxDataGrid.getInstance(blazor_element).getVisibleRows();
});
Blazor.registerFunction('BlazorDevExtreme.DxDataGrid.insertRow_14', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    DevExpress.ui.dxDataGrid.getInstance(blazor_element).insertRow();
});
Blazor.registerFunction('BlazorDevExtreme.DxDataGrid.isRowExpanded_15', function (identifier, key) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.ui.dxDataGrid.getInstance(blazor_element).isRowExpanded(key);
});
Blazor.registerFunction('BlazorDevExtreme.DxDataGrid.isRowSelected_16', function (identifier, data) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.ui.dxDataGrid.getInstance(blazor_element).isRowSelected(data);
});
Blazor.registerFunction('BlazorDevExtreme.DxDataGrid.isRowSelected_17', function (identifier, key) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.ui.dxDataGrid.getInstance(blazor_element).isRowSelected(key);
});
Blazor.registerFunction('BlazorDevExtreme.DxDataGrid.removeRow_18', function (identifier, rowIndex) {
    let blazor_element = document.getElementById(identifier);
    DevExpress.ui.dxDataGrid.getInstance(blazor_element).removeRow(rowIndex);
});
Blazor.registerFunction('BlazorDevExtreme.DxDataGrid.totalCount_19', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.ui.dxDataGrid.getInstance(blazor_element).totalCount();
});
Blazor.registerFunction('BlazorDevExtreme.DxDataGrid.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.ui.dxDataGrid.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.DxDataGrid.GetOption', function (identifier, key) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.ui.dxDataGrid.getInstance(blazor_element).option(key);
});
// DevExpress.ui.dxDateBox interop automatically generated
Blazor.registerFunction('BlazorDevExtreme.DxDateBox.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    let element = document.getElementById(identifier);
    let instance = new DevExpress.ui.dxDateBox(element, options);
});
Blazor.registerFunction('BlazorDevExtreme.DxDateBox.close_0', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    DevExpress.ui.dxDateBox.getInstance(blazor_element).close();
});
Blazor.registerFunction('BlazorDevExtreme.DxDateBox.open_1', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    DevExpress.ui.dxDateBox.getInstance(blazor_element).open();
});
Blazor.registerFunction('BlazorDevExtreme.DxDateBox.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.ui.dxDateBox.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.DxDateBox.GetOption', function (identifier, key) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.ui.dxDateBox.getInstance(blazor_element).option(key);
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
    let blazor_element = document.getElementById(identifier);
    return DevExpress.ui.dxDeferRendering.getInstance(blazor_element).option(key);
});
// DevExpress.ui.dxDropDownBox interop automatically generated
Blazor.registerFunction('BlazorDevExtreme.DxDropDownBox.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    let element = document.getElementById(identifier);
    let instance = new DevExpress.ui.dxDropDownBox(element, options);
});
Blazor.registerFunction('BlazorDevExtreme.DxDropDownBox.getDataSource_0', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.ui.dxDropDownBox.getInstance(blazor_element).getDataSource();
});
Blazor.registerFunction('BlazorDevExtreme.DxDropDownBox.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.ui.dxDropDownBox.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.DxDropDownBox.GetOption', function (identifier, key) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.ui.dxDropDownBox.getInstance(blazor_element).option(key);
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
Blazor.registerFunction('BlazorDevExtreme.DxDropDownMenu.close_0', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    DevExpress.ui.dxDropDownMenu.getInstance(blazor_element).close();
});
Blazor.registerFunction('BlazorDevExtreme.DxDropDownMenu.open_1', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    DevExpress.ui.dxDropDownMenu.getInstance(blazor_element).open();
});
Blazor.registerFunction('BlazorDevExtreme.DxDropDownMenu.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.ui.dxDropDownMenu.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.DxDropDownMenu.GetOption', function (identifier, key) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.ui.dxDropDownMenu.getInstance(blazor_element).option(key);
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
    let blazor_element = document.getElementById(identifier);
    return DevExpress.ui.dxFileUploader.getInstance(blazor_element).option(key);
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
Blazor.registerFunction('BlazorDevExtreme.DxFilterBuilder.getFilterExpression_0', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.ui.dxFilterBuilder.getInstance(blazor_element).getFilterExpression();
});
Blazor.registerFunction('BlazorDevExtreme.DxFilterBuilder.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.ui.dxFilterBuilder.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.DxFilterBuilder.GetOption', function (identifier, key) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.ui.dxFilterBuilder.getInstance(blazor_element).option(key);
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
Blazor.registerFunction('BlazorDevExtreme.DxForm.getEditor_0', function (identifier, dataField) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.ui.dxForm.getInstance(blazor_element).getEditor(dataField);
});
Blazor.registerFunction('BlazorDevExtreme.DxForm.itemOption_1', function (identifier, id) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.ui.dxForm.getInstance(blazor_element).itemOption(id);
});
Blazor.registerFunction('BlazorDevExtreme.DxForm.itemOption_2', function (identifier, id, option, value) {
    let blazor_element = document.getElementById(identifier);
    DevExpress.ui.dxForm.getInstance(blazor_element).itemOption(id, option, value);
});
Blazor.registerFunction('BlazorDevExtreme.DxForm.itemOption_3', function (identifier, id, options) {
    let blazor_element = document.getElementById(identifier);
    DevExpress.ui.dxForm.getInstance(blazor_element).itemOption(id, options);
});
Blazor.registerFunction('BlazorDevExtreme.DxForm.resetValues_4', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    DevExpress.ui.dxForm.getInstance(blazor_element).resetValues();
});
Blazor.registerFunction('BlazorDevExtreme.DxForm.updateData_5', function (identifier, data) {
    let blazor_element = document.getElementById(identifier);
    DevExpress.ui.dxForm.getInstance(blazor_element).updateData(data);
});
Blazor.registerFunction('BlazorDevExtreme.DxForm.updateData_6', function (identifier, dataField, value) {
    let blazor_element = document.getElementById(identifier);
    DevExpress.ui.dxForm.getInstance(blazor_element).updateData(dataField, value);
});
Blazor.registerFunction('BlazorDevExtreme.DxForm.updateDimensions_7', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.ui.dxForm.getInstance(blazor_element).updateDimensions();
});
Blazor.registerFunction('BlazorDevExtreme.DxForm.validate_8', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.ui.dxForm.getInstance(blazor_element).validate();
});
Blazor.registerFunction('BlazorDevExtreme.DxForm.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.ui.dxForm.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.DxForm.GetOption', function (identifier, key) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.ui.dxForm.getInstance(blazor_element).option(key);
});
// DevExpress.ui.dxGallery interop automatically generated
Blazor.registerFunction('BlazorDevExtreme.DxGallery.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    let element = document.getElementById(identifier);
    let instance = new DevExpress.ui.dxGallery(element, options);
});
Blazor.registerFunction('BlazorDevExtreme.DxGallery.goToItem_0', function (identifier, itemIndex, animation) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.ui.dxGallery.getInstance(blazor_element).goToItem(itemIndex, animation);
});
Blazor.registerFunction('BlazorDevExtreme.DxGallery.nextItem_1', function (identifier, animation) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.ui.dxGallery.getInstance(blazor_element).nextItem(animation);
});
Blazor.registerFunction('BlazorDevExtreme.DxGallery.prevItem_2', function (identifier, animation) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.ui.dxGallery.getInstance(blazor_element).prevItem(animation);
});
Blazor.registerFunction('BlazorDevExtreme.DxGallery.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.ui.dxGallery.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.DxGallery.GetOption', function (identifier, key) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.ui.dxGallery.getInstance(blazor_element).option(key);
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
Blazor.registerFunction('BlazorDevExtreme.DxList.clientHeight_0', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.ui.dxList.getInstance(blazor_element).clientHeight();
});
Blazor.registerFunction('BlazorDevExtreme.DxList.collapseGroup_1', function (identifier, groupIndex) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.ui.dxList.getInstance(blazor_element).collapseGroup(groupIndex);
});
Blazor.registerFunction('BlazorDevExtreme.DxList.deleteItem_2', function (identifier, itemElement) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.ui.dxList.getInstance(blazor_element).deleteItem(itemElement);
});
Blazor.registerFunction('BlazorDevExtreme.DxList.deleteItem_3', function (identifier, itemIndex) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.ui.dxList.getInstance(blazor_element).deleteItem(itemIndex);
});
Blazor.registerFunction('BlazorDevExtreme.DxList.expandGroup_4', function (identifier, groupIndex) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.ui.dxList.getInstance(blazor_element).expandGroup(groupIndex);
});
Blazor.registerFunction('BlazorDevExtreme.DxList.isItemSelected_5', function (identifier, itemElement) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.ui.dxList.getInstance(blazor_element).isItemSelected(itemElement);
});
Blazor.registerFunction('BlazorDevExtreme.DxList.isItemSelected_6', function (identifier, itemIndex) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.ui.dxList.getInstance(blazor_element).isItemSelected(itemIndex);
});
Blazor.registerFunction('BlazorDevExtreme.DxList.reload_7', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    DevExpress.ui.dxList.getInstance(blazor_element).reload();
});
Blazor.registerFunction('BlazorDevExtreme.DxList.reorderItem_8', function (identifier, itemElement, toItemElement) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.ui.dxList.getInstance(blazor_element).reorderItem(itemElement, toItemElement);
});
Blazor.registerFunction('BlazorDevExtreme.DxList.reorderItem_9', function (identifier, itemIndex, toItemIndex) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.ui.dxList.getInstance(blazor_element).reorderItem(itemIndex, toItemIndex);
});
Blazor.registerFunction('BlazorDevExtreme.DxList.scrollBy_10', function (identifier, distance) {
    let blazor_element = document.getElementById(identifier);
    DevExpress.ui.dxList.getInstance(blazor_element).scrollBy(distance);
});
Blazor.registerFunction('BlazorDevExtreme.DxList.scrollHeight_11', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.ui.dxList.getInstance(blazor_element).scrollHeight();
});
Blazor.registerFunction('BlazorDevExtreme.DxList.scrollTo_12', function (identifier, location) {
    let blazor_element = document.getElementById(identifier);
    DevExpress.ui.dxList.getInstance(blazor_element).scrollTo(location);
});
Blazor.registerFunction('BlazorDevExtreme.DxList.scrollToItem_13', function (identifier, itemElement) {
    let blazor_element = document.getElementById(identifier);
    DevExpress.ui.dxList.getInstance(blazor_element).scrollToItem(itemElement);
});
Blazor.registerFunction('BlazorDevExtreme.DxList.scrollToItem_14', function (identifier, itemIndex) {
    let blazor_element = document.getElementById(identifier);
    DevExpress.ui.dxList.getInstance(blazor_element).scrollToItem(itemIndex);
});
Blazor.registerFunction('BlazorDevExtreme.DxList.scrollTop_15', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.ui.dxList.getInstance(blazor_element).scrollTop();
});
Blazor.registerFunction('BlazorDevExtreme.DxList.selectAll_16', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    DevExpress.ui.dxList.getInstance(blazor_element).selectAll();
});
Blazor.registerFunction('BlazorDevExtreme.DxList.selectItem_17', function (identifier, itemElement) {
    let blazor_element = document.getElementById(identifier);
    DevExpress.ui.dxList.getInstance(blazor_element).selectItem(itemElement);
});
Blazor.registerFunction('BlazorDevExtreme.DxList.selectItem_18', function (identifier, itemIndex) {
    let blazor_element = document.getElementById(identifier);
    DevExpress.ui.dxList.getInstance(blazor_element).selectItem(itemIndex);
});
Blazor.registerFunction('BlazorDevExtreme.DxList.unselectAll_19', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    DevExpress.ui.dxList.getInstance(blazor_element).unselectAll();
});
Blazor.registerFunction('BlazorDevExtreme.DxList.unselectItem_20', function (identifier, itemElement) {
    let blazor_element = document.getElementById(identifier);
    DevExpress.ui.dxList.getInstance(blazor_element).unselectItem(itemElement);
});
Blazor.registerFunction('BlazorDevExtreme.DxList.unselectItem_21', function (identifier, itemIndex) {
    let blazor_element = document.getElementById(identifier);
    DevExpress.ui.dxList.getInstance(blazor_element).unselectItem(itemIndex);
});
Blazor.registerFunction('BlazorDevExtreme.DxList.updateDimensions_22', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.ui.dxList.getInstance(blazor_element).updateDimensions();
});
Blazor.registerFunction('BlazorDevExtreme.DxList.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.ui.dxList.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.DxList.GetOption', function (identifier, key) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.ui.dxList.getInstance(blazor_element).option(key);
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
    let blazor_element = document.getElementById(identifier);
    return DevExpress.ui.dxLoadIndicator.getInstance(blazor_element).option(key);
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
    let blazor_element = document.getElementById(identifier);
    return DevExpress.ui.dxLoadPanel.getInstance(blazor_element).option(key);
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
    let blazor_element = document.getElementById(identifier);
    return DevExpress.ui.dxLookup.getInstance(blazor_element).option(key);
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
Blazor.registerFunction('BlazorDevExtreme.DxMap.addMarker_0', function (identifier, markerOptions) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.ui.dxMap.getInstance(blazor_element).addMarker(markerOptions);
});
Blazor.registerFunction('BlazorDevExtreme.DxMap.addRoute_1', function (identifier, options) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.ui.dxMap.getInstance(blazor_element).addRoute(options);
});
Blazor.registerFunction('BlazorDevExtreme.DxMap.removeMarker_2', function (identifier, marker) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.ui.dxMap.getInstance(blazor_element).removeMarker(marker);
});
Blazor.registerFunction('BlazorDevExtreme.DxMap.removeRoute_3', function (identifier, route) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.ui.dxMap.getInstance(blazor_element).removeRoute(route);
});
Blazor.registerFunction('BlazorDevExtreme.DxMap.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.ui.dxMap.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.DxMap.GetOption', function (identifier, key) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.ui.dxMap.getInstance(blazor_element).option(key);
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
    let blazor_element = document.getElementById(identifier);
    return DevExpress.ui.dxMenu.getInstance(blazor_element).option(key);
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
    let blazor_element = document.getElementById(identifier);
    return DevExpress.ui.dxMultiView.getInstance(blazor_element).option(key);
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
    let blazor_element = document.getElementById(identifier);
    return DevExpress.ui.dxNavBar.getInstance(blazor_element).option(key);
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
    let blazor_element = document.getElementById(identifier);
    return DevExpress.ui.dxNumberBox.getInstance(blazor_element).option(key);
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
Blazor.registerFunction('BlazorDevExtreme.DxOverlay.content_0', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.ui.dxOverlay.getInstance(blazor_element).content();
});
Blazor.registerFunction('BlazorDevExtreme.DxOverlay.hide_1', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.ui.dxOverlay.getInstance(blazor_element).hide();
});
Blazor.registerFunction('BlazorDevExtreme.DxOverlay.repaint_2', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    DevExpress.ui.dxOverlay.getInstance(blazor_element).repaint();
});
Blazor.registerFunction('BlazorDevExtreme.DxOverlay.show_3', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.ui.dxOverlay.getInstance(blazor_element).show();
});
Blazor.registerFunction('BlazorDevExtreme.DxOverlay.toggle_4', function (identifier, showing) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.ui.dxOverlay.getInstance(blazor_element).toggle(showing);
});
Blazor.registerFunction('BlazorDevExtreme.DxOverlay.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.ui.dxOverlay.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.DxOverlay.GetOption', function (identifier, key) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.ui.dxOverlay.getInstance(blazor_element).option(key);
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
    let blazor_element = document.getElementById(identifier);
    return DevExpress.ui.dxPanorama.getInstance(blazor_element).option(key);
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
    let blazor_element = document.getElementById(identifier);
    return DevExpress.ui.dxPivot.getInstance(blazor_element).option(key);
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
Blazor.registerFunction('BlazorDevExtreme.DxPivotGrid.bindChart_0', function (identifier, chart, integrationOptions) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.ui.dxPivotGrid.getInstance(blazor_element).bindChart(chart, integrationOptions);
});
Blazor.registerFunction('BlazorDevExtreme.DxPivotGrid.exportToExcel_1', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    DevExpress.ui.dxPivotGrid.getInstance(blazor_element).exportToExcel();
});
Blazor.registerFunction('BlazorDevExtreme.DxPivotGrid.getDataSource_2', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.ui.dxPivotGrid.getInstance(blazor_element).getDataSource();
});
Blazor.registerFunction('BlazorDevExtreme.DxPivotGrid.getFieldChooserPopup_3', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.ui.dxPivotGrid.getInstance(blazor_element).getFieldChooserPopup();
});
Blazor.registerFunction('BlazorDevExtreme.DxPivotGrid.updateDimensions_4', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    DevExpress.ui.dxPivotGrid.getInstance(blazor_element).updateDimensions();
});
Blazor.registerFunction('BlazorDevExtreme.DxPivotGrid.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.ui.dxPivotGrid.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.DxPivotGrid.GetOption', function (identifier, key) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.ui.dxPivotGrid.getInstance(blazor_element).option(key);
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
Blazor.registerFunction('BlazorDevExtreme.DxPivotGridFieldChooser.applyChanges_0', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    DevExpress.ui.dxPivotGridFieldChooser.getInstance(blazor_element).applyChanges();
});
Blazor.registerFunction('BlazorDevExtreme.DxPivotGridFieldChooser.cancelChanges_1', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    DevExpress.ui.dxPivotGridFieldChooser.getInstance(blazor_element).cancelChanges();
});
Blazor.registerFunction('BlazorDevExtreme.DxPivotGridFieldChooser.getDataSource_2', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.ui.dxPivotGridFieldChooser.getInstance(blazor_element).getDataSource();
});
Blazor.registerFunction('BlazorDevExtreme.DxPivotGridFieldChooser.updateDimensions_3', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    DevExpress.ui.dxPivotGridFieldChooser.getInstance(blazor_element).updateDimensions();
});
Blazor.registerFunction('BlazorDevExtreme.DxPivotGridFieldChooser.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.ui.dxPivotGridFieldChooser.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.DxPivotGridFieldChooser.GetOption', function (identifier, key) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.ui.dxPivotGridFieldChooser.getInstance(blazor_element).option(key);
});
// DevExpress.ui.dxPopover interop automatically generated
Blazor.registerFunction('BlazorDevExtreme.DxPopover.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    let element = document.getElementById(identifier);
    let instance = new DevExpress.ui.dxPopover(element, options);
});
Blazor.registerFunction('BlazorDevExtreme.DxPopover.show_0', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.ui.dxPopover.getInstance(blazor_element).show();
});
Blazor.registerFunction('BlazorDevExtreme.DxPopover.show_1', function (identifier, target) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.ui.dxPopover.getInstance(blazor_element).show(target);
});
Blazor.registerFunction('BlazorDevExtreme.DxPopover.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.ui.dxPopover.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.DxPopover.GetOption', function (identifier, key) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.ui.dxPopover.getInstance(blazor_element).option(key);
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
    let blazor_element = document.getElementById(identifier);
    return DevExpress.ui.dxPopup.getInstance(blazor_element).option(key);
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
    let blazor_element = document.getElementById(identifier);
    return DevExpress.ui.dxProgressBar.getInstance(blazor_element).option(key);
});
// DevExpress.ui.dxRadioGroup interop automatically generated
Blazor.registerFunction('BlazorDevExtreme.DxRadioGroup.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    let element = document.getElementById(identifier);
    let instance = new DevExpress.ui.dxRadioGroup(element, options);
});
Blazor.registerFunction('BlazorDevExtreme.DxRadioGroup.getDataSource_0', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.ui.dxRadioGroup.getInstance(blazor_element).getDataSource();
});
Blazor.registerFunction('BlazorDevExtreme.DxRadioGroup.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.ui.dxRadioGroup.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.DxRadioGroup.GetOption', function (identifier, key) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.ui.dxRadioGroup.getInstance(blazor_element).option(key);
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
Blazor.registerFunction('BlazorDevExtreme.DxRangeSlider.reset_0', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    DevExpress.ui.dxRangeSlider.getInstance(blazor_element).reset();
});
Blazor.registerFunction('BlazorDevExtreme.DxRangeSlider.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.ui.dxRangeSlider.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.DxRangeSlider.GetOption', function (identifier, key) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.ui.dxRangeSlider.getInstance(blazor_element).option(key);
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
    let blazor_element = document.getElementById(identifier);
    return DevExpress.ui.dxResizable.getInstance(blazor_element).option(key);
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
    let blazor_element = document.getElementById(identifier);
    return DevExpress.ui.dxResponsiveBox.getInstance(blazor_element).option(key);
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
Blazor.registerFunction('BlazorDevExtreme.DxScheduler.addAppointment_0', function (identifier, appointment) {
    let blazor_element = document.getElementById(identifier);
    DevExpress.ui.dxScheduler.getInstance(blazor_element).addAppointment(appointment);
});
Blazor.registerFunction('BlazorDevExtreme.DxScheduler.deleteAppointment_1', function (identifier, appointment) {
    let blazor_element = document.getElementById(identifier);
    DevExpress.ui.dxScheduler.getInstance(blazor_element).deleteAppointment(appointment);
});
Blazor.registerFunction('BlazorDevExtreme.DxScheduler.getDataSource_2', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.ui.dxScheduler.getInstance(blazor_element).getDataSource();
});
Blazor.registerFunction('BlazorDevExtreme.DxScheduler.getEndViewDate_3', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.ui.dxScheduler.getInstance(blazor_element).getEndViewDate();
});
Blazor.registerFunction('BlazorDevExtreme.DxScheduler.getStartViewDate_4', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.ui.dxScheduler.getInstance(blazor_element).getStartViewDate();
});
Blazor.registerFunction('BlazorDevExtreme.DxScheduler.hideAppointmentPopup_5', function (identifier, saveChanges) {
    let blazor_element = document.getElementById(identifier);
    DevExpress.ui.dxScheduler.getInstance(blazor_element).hideAppointmentPopup(saveChanges);
});
Blazor.registerFunction('BlazorDevExtreme.DxScheduler.hideAppointmentTooltip_6', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    DevExpress.ui.dxScheduler.getInstance(blazor_element).hideAppointmentTooltip();
});
Blazor.registerFunction('BlazorDevExtreme.DxScheduler.registerKeyHandler_7', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    DevExpress.ui.dxScheduler.getInstance(blazor_element).registerKeyHandler();
});
Blazor.registerFunction('BlazorDevExtreme.DxScheduler.scrollToTime_8', function (identifier, hours, minutes, date) {
    let blazor_element = document.getElementById(identifier);
    DevExpress.ui.dxScheduler.getInstance(blazor_element).scrollToTime(hours, minutes, date);
});
Blazor.registerFunction('BlazorDevExtreme.DxScheduler.showAppointmentPopup_9', function (identifier, appointmentData, createNewAppointment, currentAppointmentData) {
    let blazor_element = document.getElementById(identifier);
    DevExpress.ui.dxScheduler.getInstance(blazor_element).showAppointmentPopup(appointmentData, createNewAppointment, currentAppointmentData);
});
Blazor.registerFunction('BlazorDevExtreme.DxScheduler.showAppointmentTooltip_10', function (identifier, appointmentData, target, currentAppointmentData) {
    let blazor_element = document.getElementById(identifier);
    DevExpress.ui.dxScheduler.getInstance(blazor_element).showAppointmentTooltip(appointmentData, target, currentAppointmentData);
});
Blazor.registerFunction('BlazorDevExtreme.DxScheduler.updateAppointment_11', function (identifier, target, appointment) {
    let blazor_element = document.getElementById(identifier);
    DevExpress.ui.dxScheduler.getInstance(blazor_element).updateAppointment(target, appointment);
});
Blazor.registerFunction('BlazorDevExtreme.DxScheduler.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.ui.dxScheduler.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.DxScheduler.GetOption', function (identifier, key) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.ui.dxScheduler.getInstance(blazor_element).option(key);
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
Blazor.registerFunction('BlazorDevExtreme.DxScrollView.refresh_0', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    DevExpress.ui.dxScrollView.getInstance(blazor_element).refresh();
});
Blazor.registerFunction('BlazorDevExtreme.DxScrollView.release_1', function (identifier, preventScrollBottom) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.ui.dxScrollView.getInstance(blazor_element).release(preventScrollBottom);
});
Blazor.registerFunction('BlazorDevExtreme.DxScrollView.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.ui.dxScrollView.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.DxScrollView.GetOption', function (identifier, key) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.ui.dxScrollView.getInstance(blazor_element).option(key);
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
    let blazor_element = document.getElementById(identifier);
    return DevExpress.ui.dxSelectBox.getInstance(blazor_element).option(key);
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
    let blazor_element = document.getElementById(identifier);
    return DevExpress.ui.dxSlider.getInstance(blazor_element).option(key);
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
Blazor.registerFunction('BlazorDevExtreme.DxSlideOut.hideMenu_0', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.ui.dxSlideOut.getInstance(blazor_element).hideMenu();
});
Blazor.registerFunction('BlazorDevExtreme.DxSlideOut.showMenu_1', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.ui.dxSlideOut.getInstance(blazor_element).showMenu();
});
Blazor.registerFunction('BlazorDevExtreme.DxSlideOut.toggleMenuVisibility_2', function (identifier, showing) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.ui.dxSlideOut.getInstance(blazor_element).toggleMenuVisibility(showing);
});
Blazor.registerFunction('BlazorDevExtreme.DxSlideOut.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.ui.dxSlideOut.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.DxSlideOut.GetOption', function (identifier, key) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.ui.dxSlideOut.getInstance(blazor_element).option(key);
});
// DevExpress.ui.dxSlideOutView interop automatically generated
Blazor.registerFunction('BlazorDevExtreme.DxSlideOutView.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    let element = document.getElementById(identifier);
    let instance = new DevExpress.ui.dxSlideOutView(element, options);
});
Blazor.registerFunction('BlazorDevExtreme.DxSlideOutView.content_0', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.ui.dxSlideOutView.getInstance(blazor_element).content();
});
Blazor.registerFunction('BlazorDevExtreme.DxSlideOutView.hideMenu_1', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.ui.dxSlideOutView.getInstance(blazor_element).hideMenu();
});
Blazor.registerFunction('BlazorDevExtreme.DxSlideOutView.menuContent_2', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.ui.dxSlideOutView.getInstance(blazor_element).menuContent();
});
Blazor.registerFunction('BlazorDevExtreme.DxSlideOutView.showMenu_3', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.ui.dxSlideOutView.getInstance(blazor_element).showMenu();
});
Blazor.registerFunction('BlazorDevExtreme.DxSlideOutView.toggleMenuVisibility_4', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.ui.dxSlideOutView.getInstance(blazor_element).toggleMenuVisibility();
});
Blazor.registerFunction('BlazorDevExtreme.DxSlideOutView.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.ui.dxSlideOutView.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.DxSlideOutView.GetOption', function (identifier, key) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.ui.dxSlideOutView.getInstance(blazor_element).option(key);
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
    let blazor_element = document.getElementById(identifier);
    return DevExpress.ui.dxSwitch.getInstance(blazor_element).option(key);
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
    let blazor_element = document.getElementById(identifier);
    return DevExpress.ui.dxTabs.getInstance(blazor_element).option(key);
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
    let blazor_element = document.getElementById(identifier);
    return DevExpress.ui.dxTabPanel.getInstance(blazor_element).option(key);
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
    let blazor_element = document.getElementById(identifier);
    return DevExpress.ui.dxTagBox.getInstance(blazor_element).option(key);
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
    let blazor_element = document.getElementById(identifier);
    return DevExpress.ui.dxTextArea.getInstance(blazor_element).option(key);
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
    let blazor_element = document.getElementById(identifier);
    return DevExpress.ui.dxTextBox.getInstance(blazor_element).option(key);
});
// DevExpress.ui.dxTileView interop automatically generated
Blazor.registerFunction('BlazorDevExtreme.DxTileView.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    let element = document.getElementById(identifier);
    let instance = new DevExpress.ui.dxTileView(element, options);
});
Blazor.registerFunction('BlazorDevExtreme.DxTileView.scrollPosition_0', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.ui.dxTileView.getInstance(blazor_element).scrollPosition();
});
Blazor.registerFunction('BlazorDevExtreme.DxTileView.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.ui.dxTileView.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.DxTileView.GetOption', function (identifier, key) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.ui.dxTileView.getInstance(blazor_element).option(key);
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
    let blazor_element = document.getElementById(identifier);
    return DevExpress.ui.dxToast.getInstance(blazor_element).option(key);
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
    let blazor_element = document.getElementById(identifier);
    return DevExpress.ui.dxToolbar.getInstance(blazor_element).option(key);
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
    let blazor_element = document.getElementById(identifier);
    return DevExpress.ui.dxTooltip.getInstance(blazor_element).option(key);
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
    let blazor_element = document.getElementById(identifier);
    return DevExpress.ui.dxTrackBar.getInstance(blazor_element).option(key);
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
Blazor.registerFunction('BlazorDevExtreme.DxTreeList.addColumn_0', function (identifier, columnOptions) {
    let blazor_element = document.getElementById(identifier);
    DevExpress.ui.dxTreeList.getInstance(blazor_element).addColumn(columnOptions);
});
Blazor.registerFunction('BlazorDevExtreme.DxTreeList.addRow_1', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    DevExpress.ui.dxTreeList.getInstance(blazor_element).addRow();
});
Blazor.registerFunction('BlazorDevExtreme.DxTreeList.addRow_2', function (identifier, parentId) {
    let blazor_element = document.getElementById(identifier);
    DevExpress.ui.dxTreeList.getInstance(blazor_element).addRow(parentId);
});
Blazor.registerFunction('BlazorDevExtreme.DxTreeList.collapseRow_3', function (identifier, key) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.ui.dxTreeList.getInstance(blazor_element).collapseRow(key);
});
Blazor.registerFunction('BlazorDevExtreme.DxTreeList.expandRow_4', function (identifier, key) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.ui.dxTreeList.getInstance(blazor_element).expandRow(key);
});
Blazor.registerFunction('BlazorDevExtreme.DxTreeList.forEachNode_5', function (identifier, callback) {
    let blazor_element = document.getElementById(identifier);
    DevExpress.ui.dxTreeList.getInstance(blazor_element).forEachNode(callback);
});
Blazor.registerFunction('BlazorDevExtreme.DxTreeList.forEachNode_6', function (identifier, nodes, callback) {
    let blazor_element = document.getElementById(identifier);
    DevExpress.ui.dxTreeList.getInstance(blazor_element).forEachNode(nodes, callback);
});
Blazor.registerFunction('BlazorDevExtreme.DxTreeList.getNodeByKey_7', function (identifier, key) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.ui.dxTreeList.getInstance(blazor_element).getNodeByKey(key);
});
Blazor.registerFunction('BlazorDevExtreme.DxTreeList.getRootNode_8', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.ui.dxTreeList.getInstance(blazor_element).getRootNode();
});
Blazor.registerFunction('BlazorDevExtreme.DxTreeList.getSelectedRowKeys_9', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.ui.dxTreeList.getInstance(blazor_element).getSelectedRowKeys();
});
Blazor.registerFunction('BlazorDevExtreme.DxTreeList.getSelectedRowKeys_10', function (identifier, leavesOnly) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.ui.dxTreeList.getInstance(blazor_element).getSelectedRowKeys(leavesOnly);
});
Blazor.registerFunction('BlazorDevExtreme.DxTreeList.getSelectedRowKeys_11', function (identifier, mode) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.ui.dxTreeList.getInstance(blazor_element).getSelectedRowKeys(mode);
});
Blazor.registerFunction('BlazorDevExtreme.DxTreeList.getSelectedRowsData_12', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.ui.dxTreeList.getInstance(blazor_element).getSelectedRowsData();
});
Blazor.registerFunction('BlazorDevExtreme.DxTreeList.getVisibleColumns_13', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.ui.dxTreeList.getInstance(blazor_element).getVisibleColumns();
});
Blazor.registerFunction('BlazorDevExtreme.DxTreeList.getVisibleColumns_14', function (identifier, headerLevel) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.ui.dxTreeList.getInstance(blazor_element).getVisibleColumns(headerLevel);
});
Blazor.registerFunction('BlazorDevExtreme.DxTreeList.getVisibleRows_15', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.ui.dxTreeList.getInstance(blazor_element).getVisibleRows();
});
Blazor.registerFunction('BlazorDevExtreme.DxTreeList.isRowExpanded_16', function (identifier, key) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.ui.dxTreeList.getInstance(blazor_element).isRowExpanded(key);
});
Blazor.registerFunction('BlazorDevExtreme.DxTreeList.loadDescendants_17', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.ui.dxTreeList.getInstance(blazor_element).loadDescendants();
});
Blazor.registerFunction('BlazorDevExtreme.DxTreeList.loadDescendants_18', function (identifier, keys) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.ui.dxTreeList.getInstance(blazor_element).loadDescendants(keys);
});
Blazor.registerFunction('BlazorDevExtreme.DxTreeList.loadDescendants_19', function (identifier, keys, childrenOnly) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.ui.dxTreeList.getInstance(blazor_element).loadDescendants(keys, childrenOnly);
});
Blazor.registerFunction('BlazorDevExtreme.DxTreeList.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.ui.dxTreeList.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.DxTreeList.GetOption', function (identifier, key) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.ui.dxTreeList.getInstance(blazor_element).option(key);
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
Blazor.registerFunction('BlazorDevExtreme.DxTreeView.collapseItem_0', function (identifier, itemData) {
    let blazor_element = document.getElementById(identifier);
    DevExpress.ui.dxTreeView.getInstance(blazor_element).collapseItem(itemData);
});
Blazor.registerFunction('BlazorDevExtreme.DxTreeView.collapseItem_1', function (identifier, itemElement) {
    let blazor_element = document.getElementById(identifier);
    DevExpress.ui.dxTreeView.getInstance(blazor_element).collapseItem(itemElement);
});
Blazor.registerFunction('BlazorDevExtreme.DxTreeView.collapseItem_2', function (identifier, key) {
    let blazor_element = document.getElementById(identifier);
    DevExpress.ui.dxTreeView.getInstance(blazor_element).collapseItem(key);
});
Blazor.registerFunction('BlazorDevExtreme.DxTreeView.expandItem_3', function (identifier, itemData) {
    let blazor_element = document.getElementById(identifier);
    DevExpress.ui.dxTreeView.getInstance(blazor_element).expandItem(itemData);
});
Blazor.registerFunction('BlazorDevExtreme.DxTreeView.expandItem_4', function (identifier, itemElement) {
    let blazor_element = document.getElementById(identifier);
    DevExpress.ui.dxTreeView.getInstance(blazor_element).expandItem(itemElement);
});
Blazor.registerFunction('BlazorDevExtreme.DxTreeView.expandItem_5', function (identifier, key) {
    let blazor_element = document.getElementById(identifier);
    DevExpress.ui.dxTreeView.getInstance(blazor_element).expandItem(key);
});
Blazor.registerFunction('BlazorDevExtreme.DxTreeView.getNodes_6', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.ui.dxTreeView.getInstance(blazor_element).getNodes();
});
Blazor.registerFunction('BlazorDevExtreme.DxTreeView.selectAll_7', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    DevExpress.ui.dxTreeView.getInstance(blazor_element).selectAll();
});
Blazor.registerFunction('BlazorDevExtreme.DxTreeView.selectItem_8', function (identifier, itemData) {
    let blazor_element = document.getElementById(identifier);
    DevExpress.ui.dxTreeView.getInstance(blazor_element).selectItem(itemData);
});
Blazor.registerFunction('BlazorDevExtreme.DxTreeView.selectItem_9', function (identifier, itemElement) {
    let blazor_element = document.getElementById(identifier);
    DevExpress.ui.dxTreeView.getInstance(blazor_element).selectItem(itemElement);
});
Blazor.registerFunction('BlazorDevExtreme.DxTreeView.selectItem_10', function (identifier, key) {
    let blazor_element = document.getElementById(identifier);
    DevExpress.ui.dxTreeView.getInstance(blazor_element).selectItem(key);
});
Blazor.registerFunction('BlazorDevExtreme.DxTreeView.unselectAll_11', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    DevExpress.ui.dxTreeView.getInstance(blazor_element).unselectAll();
});
Blazor.registerFunction('BlazorDevExtreme.DxTreeView.unselectItem_12', function (identifier, itemData) {
    let blazor_element = document.getElementById(identifier);
    DevExpress.ui.dxTreeView.getInstance(blazor_element).unselectItem(itemData);
});
Blazor.registerFunction('BlazorDevExtreme.DxTreeView.unselectItem_13', function (identifier, itemElement) {
    let blazor_element = document.getElementById(identifier);
    DevExpress.ui.dxTreeView.getInstance(blazor_element).unselectItem(itemElement);
});
Blazor.registerFunction('BlazorDevExtreme.DxTreeView.unselectItem_14', function (identifier, key) {
    let blazor_element = document.getElementById(identifier);
    DevExpress.ui.dxTreeView.getInstance(blazor_element).unselectItem(key);
});
Blazor.registerFunction('BlazorDevExtreme.DxTreeView.updateDimensions_15', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.ui.dxTreeView.getInstance(blazor_element).updateDimensions();
});
Blazor.registerFunction('BlazorDevExtreme.DxTreeView.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.ui.dxTreeView.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.DxTreeView.GetOption', function (identifier, key) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.ui.dxTreeView.getInstance(blazor_element).option(key);
});
// DevExpress.ui.dxValidationGroup interop automatically generated
Blazor.registerFunction('BlazorDevExtreme.DxValidationGroup.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    let element = document.getElementById(identifier);
    let instance = new DevExpress.ui.dxValidationGroup(element, options);
});
Blazor.registerFunction('BlazorDevExtreme.DxValidationGroup.reset_0', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    DevExpress.ui.dxValidationGroup.getInstance(blazor_element).reset();
});
Blazor.registerFunction('BlazorDevExtreme.DxValidationGroup.validate_1', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.ui.dxValidationGroup.getInstance(blazor_element).validate();
});
Blazor.registerFunction('BlazorDevExtreme.DxValidationGroup.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.ui.dxValidationGroup.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.DxValidationGroup.GetOption', function (identifier, key) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.ui.dxValidationGroup.getInstance(blazor_element).option(key);
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
    let blazor_element = document.getElementById(identifier);
    return DevExpress.ui.dxValidationSummary.getInstance(blazor_element).option(key);
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
Blazor.registerFunction('BlazorDevExtreme.DxValidator.focus_0', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    DevExpress.ui.dxValidator.getInstance(blazor_element).focus();
});
Blazor.registerFunction('BlazorDevExtreme.DxValidator.reset_1', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    DevExpress.ui.dxValidator.getInstance(blazor_element).reset();
});
Blazor.registerFunction('BlazorDevExtreme.DxValidator.validate_2', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.ui.dxValidator.getInstance(blazor_element).validate();
});
Blazor.registerFunction('BlazorDevExtreme.DxValidator.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.ui.dxValidator.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.DxValidator.GetOption', function (identifier, key) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.ui.dxValidator.getInstance(blazor_element).option(key);
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
Blazor.registerFunction('BlazorDevExtreme.CollectionWidget.getDataSource_0', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.ui.CollectionWidget.getInstance(blazor_element).getDataSource();
});
Blazor.registerFunction('BlazorDevExtreme.CollectionWidget.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.ui.CollectionWidget.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.CollectionWidget.GetOption', function (identifier, key) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.ui.CollectionWidget.getInstance(blazor_element).option(key);
});
// DevExpress.ui.dxMenuBase interop automatically generated
Blazor.registerFunction('BlazorDevExtreme.DxMenuBase.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    let element = document.getElementById(identifier);
    let instance = new DevExpress.ui.dxMenuBase(element, options);
});
Blazor.registerFunction('BlazorDevExtreme.DxMenuBase.selectItem_0', function (identifier, itemElement) {
    let blazor_element = document.getElementById(identifier);
    DevExpress.ui.dxMenuBase.getInstance(blazor_element).selectItem(itemElement);
});
Blazor.registerFunction('BlazorDevExtreme.DxMenuBase.unselectItem_1', function (identifier, itemElement) {
    let blazor_element = document.getElementById(identifier);
    DevExpress.ui.dxMenuBase.getInstance(blazor_element).unselectItem(itemElement);
});
Blazor.registerFunction('BlazorDevExtreme.DxMenuBase.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.ui.dxMenuBase.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.DxMenuBase.GetOption', function (identifier, key) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.ui.dxMenuBase.getInstance(blazor_element).option(key);
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
Blazor.registerFunction('BlazorDevExtreme.DxDropDownEditor.close_0', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    DevExpress.ui.dxDropDownEditor.getInstance(blazor_element).close();
});
Blazor.registerFunction('BlazorDevExtreme.DxDropDownEditor.content_1', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.ui.dxDropDownEditor.getInstance(blazor_element).content();
});
Blazor.registerFunction('BlazorDevExtreme.DxDropDownEditor.field_2', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.ui.dxDropDownEditor.getInstance(blazor_element).field();
});
Blazor.registerFunction('BlazorDevExtreme.DxDropDownEditor.open_3', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    DevExpress.ui.dxDropDownEditor.getInstance(blazor_element).open();
});
Blazor.registerFunction('BlazorDevExtreme.DxDropDownEditor.reset_4', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    DevExpress.ui.dxDropDownEditor.getInstance(blazor_element).reset();
});
Blazor.registerFunction('BlazorDevExtreme.DxDropDownEditor.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.ui.dxDropDownEditor.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.DxDropDownEditor.GetOption', function (identifier, key) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.ui.dxDropDownEditor.getInstance(blazor_element).option(key);
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
Blazor.registerFunction('BlazorDevExtreme.DxDropDownList.getDataSource_0', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.ui.dxDropDownList.getInstance(blazor_element).getDataSource();
});
Blazor.registerFunction('BlazorDevExtreme.DxDropDownList.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.ui.dxDropDownList.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.DxDropDownList.GetOption', function (identifier, key) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.ui.dxDropDownList.getInstance(blazor_element).option(key);
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
Blazor.registerFunction('BlazorDevExtreme.Editor.reset_0', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    DevExpress.ui.Editor.getInstance(blazor_element).reset();
});
Blazor.registerFunction('BlazorDevExtreme.Editor.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.ui.Editor.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.Editor.GetOption', function (identifier, key) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.ui.Editor.getInstance(blazor_element).option(key);
});
// DevExpress.ui.DataExpressionMixin interop automatically generated
Blazor.registerFunction('BlazorDevExtreme.DataExpressionMixin.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    let element = document.getElementById(identifier);
    let instance = new DevExpress.ui.DataExpressionMixin(element, options);
});
Blazor.registerFunction('BlazorDevExtreme.DataExpressionMixin.getDataSource_0', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.ui.DataExpressionMixin.getInstance(blazor_element).getDataSource();
});
Blazor.registerFunction('BlazorDevExtreme.DataExpressionMixin.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.ui.DataExpressionMixin.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.DataExpressionMixin.GetOption', function (identifier, key) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.ui.DataExpressionMixin.getInstance(blazor_element).option(key);
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
    let blazor_element = document.getElementById(identifier);
    return DevExpress.ui.HierarchicalCollectionWidget.getInstance(blazor_element).option(key);
});
// DevExpress.ui.dxPivotGridSummaryCell interop automatically generated
Blazor.registerFunction('BlazorDevExtreme.DxPivotGridSummaryCell.child_0', function (identifier, direction, fieldValue) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.ui.dxPivotGridSummaryCell.getInstance(blazor_element).child(direction, fieldValue);
});
Blazor.registerFunction('BlazorDevExtreme.DxPivotGridSummaryCell.children_1', function (identifier, direction) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.ui.dxPivotGridSummaryCell.getInstance(blazor_element).children(direction);
});
Blazor.registerFunction('BlazorDevExtreme.DxPivotGridSummaryCell.field_2', function (identifier, area) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.ui.dxPivotGridSummaryCell.getInstance(blazor_element).field(area);
});
Blazor.registerFunction('BlazorDevExtreme.DxPivotGridSummaryCell.grandTotal_3', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.ui.dxPivotGridSummaryCell.getInstance(blazor_element).grandTotal();
});
Blazor.registerFunction('BlazorDevExtreme.DxPivotGridSummaryCell.grandTotal_4', function (identifier, direction) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.ui.dxPivotGridSummaryCell.getInstance(blazor_element).grandTotal(direction);
});
Blazor.registerFunction('BlazorDevExtreme.DxPivotGridSummaryCell.next_5', function (identifier, direction) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.ui.dxPivotGridSummaryCell.getInstance(blazor_element).next(direction);
});
Blazor.registerFunction('BlazorDevExtreme.DxPivotGridSummaryCell.next_6', function (identifier, direction, allowCrossGroup) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.ui.dxPivotGridSummaryCell.getInstance(blazor_element).next(direction, allowCrossGroup);
});
Blazor.registerFunction('BlazorDevExtreme.DxPivotGridSummaryCell.parent_7', function (identifier, direction) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.ui.dxPivotGridSummaryCell.getInstance(blazor_element).parent(direction);
});
Blazor.registerFunction('BlazorDevExtreme.DxPivotGridSummaryCell.prev_8', function (identifier, direction) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.ui.dxPivotGridSummaryCell.getInstance(blazor_element).prev(direction);
});
Blazor.registerFunction('BlazorDevExtreme.DxPivotGridSummaryCell.prev_9', function (identifier, direction, allowCrossGroup) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.ui.dxPivotGridSummaryCell.getInstance(blazor_element).prev(direction, allowCrossGroup);
});
Blazor.registerFunction('BlazorDevExtreme.DxPivotGridSummaryCell.slice_10', function (identifier, field, value) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.ui.dxPivotGridSummaryCell.getInstance(blazor_element).slice(field, value);
});
Blazor.registerFunction('BlazorDevExtreme.DxPivotGridSummaryCell.value_11', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.ui.dxPivotGridSummaryCell.getInstance(blazor_element).value();
});
Blazor.registerFunction('BlazorDevExtreme.DxPivotGridSummaryCell.value_12', function (identifier, field) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.ui.dxPivotGridSummaryCell.getInstance(blazor_element).value(field);
});
Blazor.registerFunction('BlazorDevExtreme.DxPivotGridSummaryCell.value_13', function (identifier, field, isCalculatedValue) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.ui.dxPivotGridSummaryCell.getInstance(blazor_element).value(field, isCalculatedValue);
});
Blazor.registerFunction('BlazorDevExtreme.DxPivotGridSummaryCell.value_14', function (identifier, isCalculatedValue) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.ui.dxPivotGridSummaryCell.getInstance(blazor_element).value(isCalculatedValue);
});
Blazor.registerFunction('BlazorDevExtreme.DxPivotGridSummaryCell.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.ui.dxPivotGridSummaryCell.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.DxPivotGridSummaryCell.GetOption', function (identifier, key) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.ui.dxPivotGridSummaryCell.getInstance(blazor_element).option(key);
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
Blazor.registerFunction('BlazorDevExtreme.DxScrollable.clientHeight_0', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.ui.dxScrollable.getInstance(blazor_element).clientHeight();
});
Blazor.registerFunction('BlazorDevExtreme.DxScrollable.clientWidth_1', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.ui.dxScrollable.getInstance(blazor_element).clientWidth();
});
Blazor.registerFunction('BlazorDevExtreme.DxScrollable.content_2', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.ui.dxScrollable.getInstance(blazor_element).content();
});
Blazor.registerFunction('BlazorDevExtreme.DxScrollable.scrollBy_3', function (identifier, distance) {
    let blazor_element = document.getElementById(identifier);
    DevExpress.ui.dxScrollable.getInstance(blazor_element).scrollBy(distance);
});
Blazor.registerFunction('BlazorDevExtreme.DxScrollable.scrollBy_4', function (identifier, distanceObject) {
    let blazor_element = document.getElementById(identifier);
    DevExpress.ui.dxScrollable.getInstance(blazor_element).scrollBy(distanceObject);
});
Blazor.registerFunction('BlazorDevExtreme.DxScrollable.scrollHeight_5', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.ui.dxScrollable.getInstance(blazor_element).scrollHeight();
});
Blazor.registerFunction('BlazorDevExtreme.DxScrollable.scrollLeft_6', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.ui.dxScrollable.getInstance(blazor_element).scrollLeft();
});
Blazor.registerFunction('BlazorDevExtreme.DxScrollable.scrollOffset_7', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.ui.dxScrollable.getInstance(blazor_element).scrollOffset();
});
Blazor.registerFunction('BlazorDevExtreme.DxScrollable.scrollTo_8', function (identifier, targetLocation) {
    let blazor_element = document.getElementById(identifier);
    DevExpress.ui.dxScrollable.getInstance(blazor_element).scrollTo(targetLocation);
});
Blazor.registerFunction('BlazorDevExtreme.DxScrollable.scrollTo_9', function (identifier, targetLocation) {
    let blazor_element = document.getElementById(identifier);
    DevExpress.ui.dxScrollable.getInstance(blazor_element).scrollTo(targetLocation);
});
Blazor.registerFunction('BlazorDevExtreme.DxScrollable.scrollToElement_10', function (identifier, element) {
    let blazor_element = document.getElementById(identifier);
    DevExpress.ui.dxScrollable.getInstance(blazor_element).scrollToElement(element);
});
Blazor.registerFunction('BlazorDevExtreme.DxScrollable.scrollTop_11', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.ui.dxScrollable.getInstance(blazor_element).scrollTop();
});
Blazor.registerFunction('BlazorDevExtreme.DxScrollable.scrollWidth_12', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.ui.dxScrollable.getInstance(blazor_element).scrollWidth();
});
Blazor.registerFunction('BlazorDevExtreme.DxScrollable.update_13', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.ui.dxScrollable.getInstance(blazor_element).update();
});
Blazor.registerFunction('BlazorDevExtreme.DxScrollable.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.ui.dxScrollable.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.DxScrollable.GetOption', function (identifier, key) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.ui.dxScrollable.getInstance(blazor_element).option(key);
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
    let blazor_element = document.getElementById(identifier);
    return DevExpress.ui.dxSliderBase.getInstance(blazor_element).option(key);
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
Blazor.registerFunction('BlazorDevExtreme.DxTextEditor.blur_0', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    DevExpress.ui.dxTextEditor.getInstance(blazor_element).blur();
});
Blazor.registerFunction('BlazorDevExtreme.DxTextEditor.focus_1', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    DevExpress.ui.dxTextEditor.getInstance(blazor_element).focus();
});
Blazor.registerFunction('BlazorDevExtreme.DxTextEditor.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.ui.dxTextEditor.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.DxTextEditor.GetOption', function (identifier, key) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.ui.dxTextEditor.getInstance(blazor_element).option(key);
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
    let blazor_element = document.getElementById(identifier);
    return DevExpress.ui.SearchBoxMixin.getInstance(blazor_element).option(key);
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
    let blazor_element = document.getElementById(identifier);
    return DevExpress.ui.dxTemplate.getInstance(blazor_element).option(key);
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
Blazor.registerFunction('BlazorDevExtreme.Widget.focus_0', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    DevExpress.ui.Widget.getInstance(blazor_element).focus();
});
Blazor.registerFunction('BlazorDevExtreme.Widget.registerKeyHandler_1', function (identifier, key, handler) {
    let blazor_element = document.getElementById(identifier);
    DevExpress.ui.Widget.getInstance(blazor_element).registerKeyHandler(key, handler);
});
Blazor.registerFunction('BlazorDevExtreme.Widget.repaint_2', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    DevExpress.ui.Widget.getInstance(blazor_element).repaint();
});
Blazor.registerFunction('BlazorDevExtreme.Widget.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.ui.Widget.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.Widget.GetOption', function (identifier, key) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.ui.Widget.getInstance(blazor_element).option(key);
});
// DevExpress.ui.dialog interop automatically generated
Blazor.registerFunction('BlazorDevExtreme.Dialog.alert_0', function (message, title) {
    DevExpress.ui.dialog.alert(message, title);
});
Blazor.registerFunction('BlazorDevExtreme.Dialog.confirm_1', function (message, title) {
    DevExpress.ui.dialog.confirm(message, title);
});
Blazor.registerFunction('BlazorDevExtreme.Dialog.custom_2', function (options) {
    DevExpress.ui.dialog.custom(options);
});
Blazor.registerFunction('BlazorDevExtreme.Dialog.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.ui.dialog.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.Dialog.GetOption', function (identifier, key) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.ui.dialog.getInstance(blazor_element).option(key);
});
// DevExpress.ui.themes interop automatically generated
Blazor.registerFunction('BlazorDevExtreme.Themes.current_0', function () {
    DevExpress.ui.themes.current();
});
Blazor.registerFunction('BlazorDevExtreme.Themes.current_1', function (themeName) {
    DevExpress.ui.themes.current(themeName);
});
Blazor.registerFunction('BlazorDevExtreme.Themes.ready_2', function (callback) {
    DevExpress.ui.themes.ready(callback);
});
Blazor.registerFunction('BlazorDevExtreme.Themes.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.ui.themes.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.Themes.GetOption', function (identifier, key) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.ui.themes.getInstance(blazor_element).option(key);
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
Blazor.registerFunction('BlazorDevExtreme.BaseWidget.exportTo_0', function (identifier, fileName, format) {
    let blazor_element = document.getElementById(identifier);
    DevExpress.viz.BaseWidget.getInstance(blazor_element).exportTo(fileName, format);
});
Blazor.registerFunction('BlazorDevExtreme.BaseWidget.getSize_1', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.viz.BaseWidget.getInstance(blazor_element).getSize();
});
Blazor.registerFunction('BlazorDevExtreme.BaseWidget.hideLoadingIndicator_2', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    DevExpress.viz.BaseWidget.getInstance(blazor_element).hideLoadingIndicator();
});
Blazor.registerFunction('BlazorDevExtreme.BaseWidget.print_3', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    DevExpress.viz.BaseWidget.getInstance(blazor_element).print();
});
Blazor.registerFunction('BlazorDevExtreme.BaseWidget.render_4', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    DevExpress.viz.BaseWidget.getInstance(blazor_element).render();
});
Blazor.registerFunction('BlazorDevExtreme.BaseWidget.showLoadingIndicator_5', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    DevExpress.viz.BaseWidget.getInstance(blazor_element).showLoadingIndicator();
});
Blazor.registerFunction('BlazorDevExtreme.BaseWidget.svg_6', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.viz.BaseWidget.getInstance(blazor_element).svg();
});
Blazor.registerFunction('BlazorDevExtreme.BaseWidget.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.viz.BaseWidget.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.BaseWidget.GetOption', function (identifier, key) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.viz.BaseWidget.getInstance(blazor_element).option(key);
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
Blazor.registerFunction('BlazorDevExtreme.DxChart.zoomArgument_0', function (identifier, startValue, endValue) {
    let blazor_element = document.getElementById(identifier);
    DevExpress.viz.dxChart.getInstance(blazor_element).zoomArgument(startValue, endValue);
});
Blazor.registerFunction('BlazorDevExtreme.DxChart.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.viz.dxChart.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.DxChart.GetOption', function (identifier, key) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.viz.dxChart.getInstance(blazor_element).option(key);
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
Blazor.registerFunction('BlazorDevExtreme.DxPieChart.getSeries_0', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.viz.dxPieChart.getInstance(blazor_element).getSeries();
});
Blazor.registerFunction('BlazorDevExtreme.DxPieChart.getSeriesByName_1', function (identifier, seriesName) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.viz.dxPieChart.getInstance(blazor_element).getSeriesByName(seriesName);
});
Blazor.registerFunction('BlazorDevExtreme.DxPieChart.getSeriesByPos_2', function (identifier, seriesIndex) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.viz.dxPieChart.getInstance(blazor_element).getSeriesByPos(seriesIndex);
});
Blazor.registerFunction('BlazorDevExtreme.DxPieChart.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.viz.dxPieChart.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.DxPieChart.GetOption', function (identifier, key) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.viz.dxPieChart.getInstance(blazor_element).option(key);
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
    let blazor_element = document.getElementById(identifier);
    return DevExpress.viz.dxPolarChart.getInstance(blazor_element).option(key);
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
Blazor.registerFunction('BlazorDevExtreme.BaseChart.clearSelection_0', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    DevExpress.viz.BaseChart.getInstance(blazor_element).clearSelection();
});
Blazor.registerFunction('BlazorDevExtreme.BaseChart.getAllSeries_1', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.viz.BaseChart.getInstance(blazor_element).getAllSeries();
});
Blazor.registerFunction('BlazorDevExtreme.BaseChart.getDataSource_2', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.viz.BaseChart.getInstance(blazor_element).getDataSource();
});
Blazor.registerFunction('BlazorDevExtreme.BaseChart.getSeriesByName_3', function (identifier, seriesName) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.viz.BaseChart.getInstance(blazor_element).getSeriesByName(seriesName);
});
Blazor.registerFunction('BlazorDevExtreme.BaseChart.getSeriesByPos_4', function (identifier, seriesIndex) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.viz.BaseChart.getInstance(blazor_element).getSeriesByPos(seriesIndex);
});
Blazor.registerFunction('BlazorDevExtreme.BaseChart.hideTooltip_5', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    DevExpress.viz.BaseChart.getInstance(blazor_element).hideTooltip();
});
Blazor.registerFunction('BlazorDevExtreme.BaseChart.render_6', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    DevExpress.viz.BaseChart.getInstance(blazor_element).render();
});
Blazor.registerFunction('BlazorDevExtreme.BaseChart.render_7', function (identifier, renderOptions) {
    let blazor_element = document.getElementById(identifier);
    DevExpress.viz.BaseChart.getInstance(blazor_element).render(renderOptions);
});
Blazor.registerFunction('BlazorDevExtreme.BaseChart.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.viz.BaseChart.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.BaseChart.GetOption', function (identifier, key) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.viz.BaseChart.getInstance(blazor_element).option(key);
});
// DevExpress.viz.dxExporter interop automatically generated
Blazor.registerFunction('BlazorDevExtreme.DxExporter.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    let element = document.getElementById(identifier);
    let instance = new DevExpress.viz.dxExporter(element, options);
});
Blazor.registerFunction('BlazorDevExtreme.DxExporter.exportTo_0', function (identifier, fileName, format) {
    let blazor_element = document.getElementById(identifier);
    DevExpress.viz.dxExporter.getInstance(blazor_element).exportTo(fileName, format);
});
Blazor.registerFunction('BlazorDevExtreme.DxExporter.print_1', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    DevExpress.viz.dxExporter.getInstance(blazor_element).print();
});
Blazor.registerFunction('BlazorDevExtreme.DxExporter.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.viz.dxExporter.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.DxExporter.GetOption', function (identifier, key) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.viz.dxExporter.getInstance(blazor_element).option(key);
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
Blazor.registerFunction('BlazorDevExtreme.DxFunnel.clearSelection_0', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    DevExpress.viz.dxFunnel.getInstance(blazor_element).clearSelection();
});
Blazor.registerFunction('BlazorDevExtreme.DxFunnel.getAllItems_1', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.viz.dxFunnel.getInstance(blazor_element).getAllItems();
});
Blazor.registerFunction('BlazorDevExtreme.DxFunnel.getDataSource_2', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.viz.dxFunnel.getInstance(blazor_element).getDataSource();
});
Blazor.registerFunction('BlazorDevExtreme.DxFunnel.hideTooltip_3', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    DevExpress.viz.dxFunnel.getInstance(blazor_element).hideTooltip();
});
Blazor.registerFunction('BlazorDevExtreme.DxFunnel.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.viz.dxFunnel.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.DxFunnel.GetOption', function (identifier, key) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.viz.dxFunnel.getInstance(blazor_element).option(key);
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
Blazor.registerFunction('BlazorDevExtreme.BaseGauge.subvalues_0', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.viz.BaseGauge.getInstance(blazor_element).subvalues();
});
Blazor.registerFunction('BlazorDevExtreme.BaseGauge.subvalues_1', function (identifier, subvalues) {
    let blazor_element = document.getElementById(identifier);
    DevExpress.viz.BaseGauge.getInstance(blazor_element).subvalues(subvalues);
});
Blazor.registerFunction('BlazorDevExtreme.BaseGauge.value_2', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.viz.BaseGauge.getInstance(blazor_element).value();
});
Blazor.registerFunction('BlazorDevExtreme.BaseGauge.value_3', function (identifier, value) {
    let blazor_element = document.getElementById(identifier);
    DevExpress.viz.BaseGauge.getInstance(blazor_element).value(value);
});
Blazor.registerFunction('BlazorDevExtreme.BaseGauge.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.viz.BaseGauge.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.BaseGauge.GetOption', function (identifier, key) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.viz.BaseGauge.getInstance(blazor_element).option(key);
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
    let blazor_element = document.getElementById(identifier);
    return DevExpress.viz.dxCircularGauge.getInstance(blazor_element).option(key);
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
    let blazor_element = document.getElementById(identifier);
    return DevExpress.viz.dxLinearGauge.getInstance(blazor_element).option(key);
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
Blazor.registerFunction('BlazorDevExtreme.DxBarGauge.values_0', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.viz.dxBarGauge.getInstance(blazor_element).values();
});
Blazor.registerFunction('BlazorDevExtreme.DxBarGauge.values_1', function (identifier, values) {
    let blazor_element = document.getElementById(identifier);
    DevExpress.viz.dxBarGauge.getInstance(blazor_element).values(values);
});
Blazor.registerFunction('BlazorDevExtreme.DxBarGauge.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.viz.dxBarGauge.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.DxBarGauge.GetOption', function (identifier, key) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.viz.dxBarGauge.getInstance(blazor_element).option(key);
});
// DevExpress.viz.baseSeriesObject interop automatically generated
Blazor.registerFunction('BlazorDevExtreme.BaseSeriesObject.clearHover_0', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    DevExpress.viz.baseSeriesObject.getInstance(blazor_element).clearHover();
});
Blazor.registerFunction('BlazorDevExtreme.BaseSeriesObject.clearSelection_1', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    DevExpress.viz.baseSeriesObject.getInstance(blazor_element).clearSelection();
});
Blazor.registerFunction('BlazorDevExtreme.BaseSeriesObject.deselectPoint_2', function (identifier, point) {
    let blazor_element = document.getElementById(identifier);
    DevExpress.viz.baseSeriesObject.getInstance(blazor_element).deselectPoint(point);
});
Blazor.registerFunction('BlazorDevExtreme.BaseSeriesObject.getAllPoints_3', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.viz.baseSeriesObject.getInstance(blazor_element).getAllPoints();
});
Blazor.registerFunction('BlazorDevExtreme.BaseSeriesObject.getColor_4', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.viz.baseSeriesObject.getInstance(blazor_element).getColor();
});
Blazor.registerFunction('BlazorDevExtreme.BaseSeriesObject.getPointByPos_5', function (identifier, positionIndex) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.viz.baseSeriesObject.getInstance(blazor_element).getPointByPos(positionIndex);
});
Blazor.registerFunction('BlazorDevExtreme.BaseSeriesObject.getPointsByArg_6', function (identifier, pointArg) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.viz.baseSeriesObject.getInstance(blazor_element).getPointsByArg(pointArg);
});
Blazor.registerFunction('BlazorDevExtreme.BaseSeriesObject.getVisiblePoints_7', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.viz.baseSeriesObject.getInstance(blazor_element).getVisiblePoints();
});
Blazor.registerFunction('BlazorDevExtreme.BaseSeriesObject.hide_8', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    DevExpress.viz.baseSeriesObject.getInstance(blazor_element).hide();
});
Blazor.registerFunction('BlazorDevExtreme.BaseSeriesObject.hover_9', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    DevExpress.viz.baseSeriesObject.getInstance(blazor_element).hover();
});
Blazor.registerFunction('BlazorDevExtreme.BaseSeriesObject.isHovered_10', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.viz.baseSeriesObject.getInstance(blazor_element).isHovered();
});
Blazor.registerFunction('BlazorDevExtreme.BaseSeriesObject.isSelected_11', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.viz.baseSeriesObject.getInstance(blazor_element).isSelected();
});
Blazor.registerFunction('BlazorDevExtreme.BaseSeriesObject.isVisible_12', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.viz.baseSeriesObject.getInstance(blazor_element).isVisible();
});
Blazor.registerFunction('BlazorDevExtreme.BaseSeriesObject.select_13', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    DevExpress.viz.baseSeriesObject.getInstance(blazor_element).select();
});
Blazor.registerFunction('BlazorDevExtreme.BaseSeriesObject.selectPoint_14', function (identifier, point) {
    let blazor_element = document.getElementById(identifier);
    DevExpress.viz.baseSeriesObject.getInstance(blazor_element).selectPoint(point);
});
Blazor.registerFunction('BlazorDevExtreme.BaseSeriesObject.show_15', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    DevExpress.viz.baseSeriesObject.getInstance(blazor_element).show();
});
Blazor.registerFunction('BlazorDevExtreme.BaseSeriesObject.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.viz.baseSeriesObject.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.BaseSeriesObject.GetOption', function (identifier, key) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.viz.baseSeriesObject.getInstance(blazor_element).option(key);
});
// DevExpress.viz.basePointObject interop automatically generated
Blazor.registerFunction('BlazorDevExtreme.BasePointObject.clearHover_0', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    DevExpress.viz.basePointObject.getInstance(blazor_element).clearHover();
});
Blazor.registerFunction('BlazorDevExtreme.BasePointObject.clearSelection_1', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    DevExpress.viz.basePointObject.getInstance(blazor_element).clearSelection();
});
Blazor.registerFunction('BlazorDevExtreme.BasePointObject.getColor_2', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.viz.basePointObject.getInstance(blazor_element).getColor();
});
Blazor.registerFunction('BlazorDevExtreme.BasePointObject.getLabel_3', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.viz.basePointObject.getInstance(blazor_element).getLabel();
});
Blazor.registerFunction('BlazorDevExtreme.BasePointObject.hideTooltip_4', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    DevExpress.viz.basePointObject.getInstance(blazor_element).hideTooltip();
});
Blazor.registerFunction('BlazorDevExtreme.BasePointObject.hover_5', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    DevExpress.viz.basePointObject.getInstance(blazor_element).hover();
});
Blazor.registerFunction('BlazorDevExtreme.BasePointObject.isHovered_6', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.viz.basePointObject.getInstance(blazor_element).isHovered();
});
Blazor.registerFunction('BlazorDevExtreme.BasePointObject.isSelected_7', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.viz.basePointObject.getInstance(blazor_element).isSelected();
});
Blazor.registerFunction('BlazorDevExtreme.BasePointObject.select_8', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    DevExpress.viz.basePointObject.getInstance(blazor_element).select();
});
Blazor.registerFunction('BlazorDevExtreme.BasePointObject.showTooltip_9', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    DevExpress.viz.basePointObject.getInstance(blazor_element).showTooltip();
});
Blazor.registerFunction('BlazorDevExtreme.BasePointObject.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.viz.basePointObject.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.BasePointObject.GetOption', function (identifier, key) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.viz.basePointObject.getInstance(blazor_element).option(key);
});
// DevExpress.viz.baseLabelObject interop automatically generated
Blazor.registerFunction('BlazorDevExtreme.BaseLabelObject.getBoundingRect_0', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.viz.baseLabelObject.getInstance(blazor_element).getBoundingRect();
});
Blazor.registerFunction('BlazorDevExtreme.BaseLabelObject.hide_1', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    DevExpress.viz.baseLabelObject.getInstance(blazor_element).hide();
});
Blazor.registerFunction('BlazorDevExtreme.BaseLabelObject.hide_2', function (identifier, holdInvisible) {
    let blazor_element = document.getElementById(identifier);
    DevExpress.viz.baseLabelObject.getInstance(blazor_element).hide(holdInvisible);
});
Blazor.registerFunction('BlazorDevExtreme.BaseLabelObject.isVisible_3', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.viz.baseLabelObject.getInstance(blazor_element).isVisible();
});
Blazor.registerFunction('BlazorDevExtreme.BaseLabelObject.show_4', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    DevExpress.viz.baseLabelObject.getInstance(blazor_element).show();
});
Blazor.registerFunction('BlazorDevExtreme.BaseLabelObject.show_5', function (identifier, holdVisible) {
    let blazor_element = document.getElementById(identifier);
    DevExpress.viz.baseLabelObject.getInstance(blazor_element).show(holdVisible);
});
Blazor.registerFunction('BlazorDevExtreme.BaseLabelObject.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.viz.baseLabelObject.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.BaseLabelObject.GetOption', function (identifier, key) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.viz.baseLabelObject.getInstance(blazor_element).option(key);
});
// DevExpress.viz.chartSeriesObject interop automatically generated
Blazor.registerFunction('BlazorDevExtreme.ChartSeriesObject.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.viz.chartSeriesObject.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.ChartSeriesObject.GetOption', function (identifier, key) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.viz.chartSeriesObject.getInstance(blazor_element).option(key);
});
// DevExpress.viz.chartPointObject interop automatically generated
Blazor.registerFunction('BlazorDevExtreme.ChartPointObject.getBoundingRect_0', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.viz.chartPointObject.getInstance(blazor_element).getBoundingRect();
});
Blazor.registerFunction('BlazorDevExtreme.ChartPointObject.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.viz.chartPointObject.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.ChartPointObject.GetOption', function (identifier, key) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.viz.chartPointObject.getInstance(blazor_element).option(key);
});
// DevExpress.viz.dxFunnelItem interop automatically generated
Blazor.registerFunction('BlazorDevExtreme.DxFunnelItem.getColor_0', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.viz.dxFunnelItem.getInstance(blazor_element).getColor();
});
Blazor.registerFunction('BlazorDevExtreme.DxFunnelItem.hover_1', function (identifier, state) {
    let blazor_element = document.getElementById(identifier);
    DevExpress.viz.dxFunnelItem.getInstance(blazor_element).hover(state);
});
Blazor.registerFunction('BlazorDevExtreme.DxFunnelItem.isHovered_2', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.viz.dxFunnelItem.getInstance(blazor_element).isHovered();
});
Blazor.registerFunction('BlazorDevExtreme.DxFunnelItem.isSelected_3', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.viz.dxFunnelItem.getInstance(blazor_element).isSelected();
});
Blazor.registerFunction('BlazorDevExtreme.DxFunnelItem.select_4', function (identifier, state) {
    let blazor_element = document.getElementById(identifier);
    DevExpress.viz.dxFunnelItem.getInstance(blazor_element).select(state);
});
Blazor.registerFunction('BlazorDevExtreme.DxFunnelItem.showTooltip_5', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    DevExpress.viz.dxFunnelItem.getInstance(blazor_element).showTooltip();
});
Blazor.registerFunction('BlazorDevExtreme.DxFunnelItem.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.viz.dxFunnelItem.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.DxFunnelItem.GetOption', function (identifier, key) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.viz.dxFunnelItem.getInstance(blazor_element).option(key);
});
// DevExpress.viz.piePointObject interop automatically generated
Blazor.registerFunction('BlazorDevExtreme.PiePointObject.hide_0', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    DevExpress.viz.piePointObject.getInstance(blazor_element).hide();
});
Blazor.registerFunction('BlazorDevExtreme.PiePointObject.hideTooltip_1', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    DevExpress.viz.piePointObject.getInstance(blazor_element).hideTooltip();
});
Blazor.registerFunction('BlazorDevExtreme.PiePointObject.isVisible_2', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.viz.piePointObject.getInstance(blazor_element).isVisible();
});
Blazor.registerFunction('BlazorDevExtreme.PiePointObject.show_3', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    DevExpress.viz.piePointObject.getInstance(blazor_element).show();
});
Blazor.registerFunction('BlazorDevExtreme.PiePointObject.showTooltip_4', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    DevExpress.viz.piePointObject.getInstance(blazor_element).showTooltip();
});
Blazor.registerFunction('BlazorDevExtreme.PiePointObject.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.viz.piePointObject.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.PiePointObject.GetOption', function (identifier, key) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.viz.piePointObject.getInstance(blazor_element).option(key);
});
// DevExpress.viz.pieChartSeriesObject interop automatically generated
Blazor.registerFunction('BlazorDevExtreme.PieChartSeriesObject.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.viz.pieChartSeriesObject.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.PieChartSeriesObject.GetOption', function (identifier, key) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.viz.pieChartSeriesObject.getInstance(blazor_element).option(key);
});
// DevExpress.viz.polarChartSeriesObject interop automatically generated
Blazor.registerFunction('BlazorDevExtreme.PolarChartSeriesObject.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.viz.polarChartSeriesObject.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.PolarChartSeriesObject.GetOption', function (identifier, key) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.viz.polarChartSeriesObject.getInstance(blazor_element).option(key);
});
// DevExpress.viz.polarPointObject interop automatically generated
Blazor.registerFunction('BlazorDevExtreme.PolarPointObject.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.viz.polarPointObject.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.PolarPointObject.GetOption', function (identifier, key) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.viz.polarPointObject.getInstance(blazor_element).option(key);
});
// DevExpress.viz.dxTreeMapNode interop automatically generated
Blazor.registerFunction('BlazorDevExtreme.DxTreeMapNode.customize_0', function (identifier, options) {
    let blazor_element = document.getElementById(identifier);
    DevExpress.viz.dxTreeMapNode.getInstance(blazor_element).customize(options);
});
Blazor.registerFunction('BlazorDevExtreme.DxTreeMapNode.drillDown_1', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    DevExpress.viz.dxTreeMapNode.getInstance(blazor_element).drillDown();
});
Blazor.registerFunction('BlazorDevExtreme.DxTreeMapNode.getAllChildren_2', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.viz.dxTreeMapNode.getInstance(blazor_element).getAllChildren();
});
Blazor.registerFunction('BlazorDevExtreme.DxTreeMapNode.getAllNodes_3', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.viz.dxTreeMapNode.getInstance(blazor_element).getAllNodes();
});
Blazor.registerFunction('BlazorDevExtreme.DxTreeMapNode.getChild_4', function (identifier, index) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.viz.dxTreeMapNode.getInstance(blazor_element).getChild(index);
});
Blazor.registerFunction('BlazorDevExtreme.DxTreeMapNode.getChildrenCount_5', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.viz.dxTreeMapNode.getInstance(blazor_element).getChildrenCount();
});
Blazor.registerFunction('BlazorDevExtreme.DxTreeMapNode.getParent_6', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.viz.dxTreeMapNode.getInstance(blazor_element).getParent();
});
Blazor.registerFunction('BlazorDevExtreme.DxTreeMapNode.isActive_7', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.viz.dxTreeMapNode.getInstance(blazor_element).isActive();
});
Blazor.registerFunction('BlazorDevExtreme.DxTreeMapNode.isHovered_8', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.viz.dxTreeMapNode.getInstance(blazor_element).isHovered();
});
Blazor.registerFunction('BlazorDevExtreme.DxTreeMapNode.isLeaf_9', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.viz.dxTreeMapNode.getInstance(blazor_element).isLeaf();
});
Blazor.registerFunction('BlazorDevExtreme.DxTreeMapNode.isSelected_10', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.viz.dxTreeMapNode.getInstance(blazor_element).isSelected();
});
Blazor.registerFunction('BlazorDevExtreme.DxTreeMapNode.label_11', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.viz.dxTreeMapNode.getInstance(blazor_element).label();
});
Blazor.registerFunction('BlazorDevExtreme.DxTreeMapNode.label_12', function (identifier, label) {
    let blazor_element = document.getElementById(identifier);
    DevExpress.viz.dxTreeMapNode.getInstance(blazor_element).label(label);
});
Blazor.registerFunction('BlazorDevExtreme.DxTreeMapNode.resetCustomization_13', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    DevExpress.viz.dxTreeMapNode.getInstance(blazor_element).resetCustomization();
});
Blazor.registerFunction('BlazorDevExtreme.DxTreeMapNode.select_14', function (identifier, state) {
    let blazor_element = document.getElementById(identifier);
    DevExpress.viz.dxTreeMapNode.getInstance(blazor_element).select(state);
});
Blazor.registerFunction('BlazorDevExtreme.DxTreeMapNode.showTooltip_15', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    DevExpress.viz.dxTreeMapNode.getInstance(blazor_element).showTooltip();
});
Blazor.registerFunction('BlazorDevExtreme.DxTreeMapNode.value_16', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.viz.dxTreeMapNode.getInstance(blazor_element).value();
});
Blazor.registerFunction('BlazorDevExtreme.DxTreeMapNode.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.viz.dxTreeMapNode.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.DxTreeMapNode.GetOption', function (identifier, key) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.viz.dxTreeMapNode.getInstance(blazor_element).option(key);
});
// DevExpress.viz.MapLayer interop automatically generated
Blazor.registerFunction('BlazorDevExtreme.MapLayer.clearSelection_0', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    DevExpress.viz.MapLayer.getInstance(blazor_element).clearSelection();
});
Blazor.registerFunction('BlazorDevExtreme.MapLayer.getDataSource_1', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.viz.MapLayer.getInstance(blazor_element).getDataSource();
});
Blazor.registerFunction('BlazorDevExtreme.MapLayer.getElements_2', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.viz.MapLayer.getInstance(blazor_element).getElements();
});
Blazor.registerFunction('BlazorDevExtreme.MapLayer.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.viz.MapLayer.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.MapLayer.GetOption', function (identifier, key) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.viz.MapLayer.getInstance(blazor_element).option(key);
});
// DevExpress.viz.MapLayerElement interop automatically generated
Blazor.registerFunction('BlazorDevExtreme.MapLayerElement.applySettings_0', function (identifier, settings) {
    let blazor_element = document.getElementById(identifier);
    DevExpress.viz.MapLayerElement.getInstance(blazor_element).applySettings(settings);
});
Blazor.registerFunction('BlazorDevExtreme.MapLayerElement.attribute_1', function (identifier, name) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.viz.MapLayerElement.getInstance(blazor_element).attribute(name);
});
Blazor.registerFunction('BlazorDevExtreme.MapLayerElement.attribute_2', function (identifier, name, value) {
    let blazor_element = document.getElementById(identifier);
    DevExpress.viz.MapLayerElement.getInstance(blazor_element).attribute(name, value);
});
Blazor.registerFunction('BlazorDevExtreme.MapLayerElement.coordinates_3', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.viz.MapLayerElement.getInstance(blazor_element).coordinates();
});
Blazor.registerFunction('BlazorDevExtreme.MapLayerElement.selected_4', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.viz.MapLayerElement.getInstance(blazor_element).selected();
});
Blazor.registerFunction('BlazorDevExtreme.MapLayerElement.selected_5', function (identifier, state) {
    let blazor_element = document.getElementById(identifier);
    DevExpress.viz.MapLayerElement.getInstance(blazor_element).selected(state);
});
Blazor.registerFunction('BlazorDevExtreme.MapLayerElement.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.viz.MapLayerElement.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.MapLayerElement.GetOption', function (identifier, key) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.viz.MapLayerElement.getInstance(blazor_element).option(key);
});
// DevExpress.viz.areaObjects interop automatically generated
Blazor.registerFunction('BlazorDevExtreme.AreaObjects.applySettings_0', function (identifier, settings) {
    let blazor_element = document.getElementById(identifier);
    DevExpress.viz.areaObjects.getInstance(blazor_element).applySettings(settings);
});
Blazor.registerFunction('BlazorDevExtreme.AreaObjects.attribute_1', function (identifier, name) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.viz.areaObjects.getInstance(blazor_element).attribute(name);
});
Blazor.registerFunction('BlazorDevExtreme.AreaObjects.selected_2', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.viz.areaObjects.getInstance(blazor_element).selected();
});
Blazor.registerFunction('BlazorDevExtreme.AreaObjects.selected_3', function (identifier, state) {
    let blazor_element = document.getElementById(identifier);
    DevExpress.viz.areaObjects.getInstance(blazor_element).selected(state);
});
Blazor.registerFunction('BlazorDevExtreme.AreaObjects.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.viz.areaObjects.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.AreaObjects.GetOption', function (identifier, key) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.viz.areaObjects.getInstance(blazor_element).option(key);
});
// DevExpress.viz.markerObjects interop automatically generated
Blazor.registerFunction('BlazorDevExtreme.MarkerObjects.applySettings_0', function (identifier, settings) {
    let blazor_element = document.getElementById(identifier);
    DevExpress.viz.markerObjects.getInstance(blazor_element).applySettings(settings);
});
Blazor.registerFunction('BlazorDevExtreme.MarkerObjects.attribute_1', function (identifier, name) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.viz.markerObjects.getInstance(blazor_element).attribute(name);
});
Blazor.registerFunction('BlazorDevExtreme.MarkerObjects.coordinates_2', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.viz.markerObjects.getInstance(blazor_element).coordinates();
});
Blazor.registerFunction('BlazorDevExtreme.MarkerObjects.selected_3', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.viz.markerObjects.getInstance(blazor_element).selected();
});
Blazor.registerFunction('BlazorDevExtreme.MarkerObjects.selected_4', function (identifier, state) {
    let blazor_element = document.getElementById(identifier);
    DevExpress.viz.markerObjects.getInstance(blazor_element).selected(state);
});
Blazor.registerFunction('BlazorDevExtreme.MarkerObjects.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.viz.markerObjects.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.MarkerObjects.GetOption', function (identifier, key) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.viz.markerObjects.getInstance(blazor_element).option(key);
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
Blazor.registerFunction('BlazorDevExtreme.DxRangeSelector.getDataSource_0', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.viz.dxRangeSelector.getInstance(blazor_element).getDataSource();
});
Blazor.registerFunction('BlazorDevExtreme.DxRangeSelector.getSelectedRange_1', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.viz.dxRangeSelector.getInstance(blazor_element).getSelectedRange();
});
Blazor.registerFunction('BlazorDevExtreme.DxRangeSelector.getValue_2', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.viz.dxRangeSelector.getInstance(blazor_element).getValue();
});
Blazor.registerFunction('BlazorDevExtreme.DxRangeSelector.render_3', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    DevExpress.viz.dxRangeSelector.getInstance(blazor_element).render();
});
Blazor.registerFunction('BlazorDevExtreme.DxRangeSelector.render_4', function (identifier, skipChartAnimation) {
    let blazor_element = document.getElementById(identifier);
    DevExpress.viz.dxRangeSelector.getInstance(blazor_element).render(skipChartAnimation);
});
Blazor.registerFunction('BlazorDevExtreme.DxRangeSelector.setSelectedRange_5', function (identifier, selectedRange) {
    let blazor_element = document.getElementById(identifier);
    DevExpress.viz.dxRangeSelector.getInstance(blazor_element).setSelectedRange(selectedRange);
});
Blazor.registerFunction('BlazorDevExtreme.DxRangeSelector.setValue_6', function (identifier, value) {
    let blazor_element = document.getElementById(identifier);
    DevExpress.viz.dxRangeSelector.getInstance(blazor_element).setValue(value);
});
Blazor.registerFunction('BlazorDevExtreme.DxRangeSelector.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.viz.dxRangeSelector.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.DxRangeSelector.GetOption', function (identifier, key) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.viz.dxRangeSelector.getInstance(blazor_element).option(key);
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
    let blazor_element = document.getElementById(identifier);
    return DevExpress.viz.BaseSparkline.getInstance(blazor_element).option(key);
});
// DevExpress.viz.dxSparkline interop automatically generated
Blazor.registerFunction('BlazorDevExtreme.DxSparkline.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    let element = document.getElementById(identifier);
    let instance = new DevExpress.viz.dxSparkline(element, options);
});
Blazor.registerFunction('BlazorDevExtreme.DxSparkline.getDataSource_0', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.viz.dxSparkline.getInstance(blazor_element).getDataSource();
});
Blazor.registerFunction('BlazorDevExtreme.DxSparkline.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.viz.dxSparkline.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.DxSparkline.GetOption', function (identifier, key) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.viz.dxSparkline.getInstance(blazor_element).option(key);
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
    let blazor_element = document.getElementById(identifier);
    return DevExpress.viz.dxBullet.getInstance(blazor_element).option(key);
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
Blazor.registerFunction('BlazorDevExtreme.DxTreeMap.clearSelection_0', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    DevExpress.viz.dxTreeMap.getInstance(blazor_element).clearSelection();
});
Blazor.registerFunction('BlazorDevExtreme.DxTreeMap.drillUp_1', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    DevExpress.viz.dxTreeMap.getInstance(blazor_element).drillUp();
});
Blazor.registerFunction('BlazorDevExtreme.DxTreeMap.getCurrentNode_2', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.viz.dxTreeMap.getInstance(blazor_element).getCurrentNode();
});
Blazor.registerFunction('BlazorDevExtreme.DxTreeMap.getDataSource_3', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.viz.dxTreeMap.getInstance(blazor_element).getDataSource();
});
Blazor.registerFunction('BlazorDevExtreme.DxTreeMap.getRootNode_4', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.viz.dxTreeMap.getInstance(blazor_element).getRootNode();
});
Blazor.registerFunction('BlazorDevExtreme.DxTreeMap.hideTooltip_5', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    DevExpress.viz.dxTreeMap.getInstance(blazor_element).hideTooltip();
});
Blazor.registerFunction('BlazorDevExtreme.DxTreeMap.resetDrillDown_6', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    DevExpress.viz.dxTreeMap.getInstance(blazor_element).resetDrillDown();
});
Blazor.registerFunction('BlazorDevExtreme.DxTreeMap.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.viz.dxTreeMap.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.DxTreeMap.GetOption', function (identifier, key) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.viz.dxTreeMap.getInstance(blazor_element).option(key);
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
Blazor.registerFunction('BlazorDevExtreme.DxVectorMap.center_0', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.viz.dxVectorMap.getInstance(blazor_element).center();
});
Blazor.registerFunction('BlazorDevExtreme.DxVectorMap.center_1', function (identifier, centerCoordinates) {
    let blazor_element = document.getElementById(identifier);
    DevExpress.viz.dxVectorMap.getInstance(blazor_element).center(centerCoordinates);
});
Blazor.registerFunction('BlazorDevExtreme.DxVectorMap.clearAreaSelection_2', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    DevExpress.viz.dxVectorMap.getInstance(blazor_element).clearAreaSelection();
});
Blazor.registerFunction('BlazorDevExtreme.DxVectorMap.clearMarkerSelection_3', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    DevExpress.viz.dxVectorMap.getInstance(blazor_element).clearMarkerSelection();
});
Blazor.registerFunction('BlazorDevExtreme.DxVectorMap.clearSelection_4', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    DevExpress.viz.dxVectorMap.getInstance(blazor_element).clearSelection();
});
Blazor.registerFunction('BlazorDevExtreme.DxVectorMap.convertCoordinates_5', function (identifier, x, y) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.viz.dxVectorMap.getInstance(blazor_element).convertCoordinates(x, y);
});
Blazor.registerFunction('BlazorDevExtreme.DxVectorMap.getAreas_6', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.viz.dxVectorMap.getInstance(blazor_element).getAreas();
});
Blazor.registerFunction('BlazorDevExtreme.DxVectorMap.getLayerByIndex_7', function (identifier, index) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.viz.dxVectorMap.getInstance(blazor_element).getLayerByIndex(index);
});
Blazor.registerFunction('BlazorDevExtreme.DxVectorMap.getLayerByName_8', function (identifier, name) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.viz.dxVectorMap.getInstance(blazor_element).getLayerByName(name);
});
Blazor.registerFunction('BlazorDevExtreme.DxVectorMap.getLayers_9', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.viz.dxVectorMap.getInstance(blazor_element).getLayers();
});
Blazor.registerFunction('BlazorDevExtreme.DxVectorMap.getMarkers_10', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.viz.dxVectorMap.getInstance(blazor_element).getMarkers();
});
Blazor.registerFunction('BlazorDevExtreme.DxVectorMap.viewport_11', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.viz.dxVectorMap.getInstance(blazor_element).viewport();
});
Blazor.registerFunction('BlazorDevExtreme.DxVectorMap.viewport_12', function (identifier, viewportCoordinates) {
    let blazor_element = document.getElementById(identifier);
    DevExpress.viz.dxVectorMap.getInstance(blazor_element).viewport(viewportCoordinates);
});
Blazor.registerFunction('BlazorDevExtreme.DxVectorMap.zoomFactor_13', function (identifier) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.viz.dxVectorMap.getInstance(blazor_element).zoomFactor();
});
Blazor.registerFunction('BlazorDevExtreme.DxVectorMap.zoomFactor_14', function (identifier, zoomFactor) {
    let blazor_element = document.getElementById(identifier);
    DevExpress.viz.dxVectorMap.getInstance(blazor_element).zoomFactor(zoomFactor);
});
Blazor.registerFunction('BlazorDevExtreme.DxVectorMap.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.viz.dxVectorMap.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.DxVectorMap.GetOption', function (identifier, key) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.viz.dxVectorMap.getInstance(blazor_element).option(key);
});
// DevExpress.viz.core interop automatically generated
Blazor.registerFunction('BlazorDevExtreme.Core.currentPalette_0', function (paletteName) {
    DevExpress.viz.core.currentPalette(paletteName);
});
Blazor.registerFunction('BlazorDevExtreme.Core.currentTheme_1', function (platform, colorScheme) {
    DevExpress.viz.core.currentTheme(platform, colorScheme);
});
Blazor.registerFunction('BlazorDevExtreme.Core.currentTheme_2', function (theme) {
    DevExpress.viz.core.currentTheme(theme);
});
Blazor.registerFunction('BlazorDevExtreme.Core.getPalette_3', function (paletteName) {
    DevExpress.viz.core.getPalette(paletteName);
});
Blazor.registerFunction('BlazorDevExtreme.Core.registerPalette_4', function (paletteName, palette) {
    DevExpress.viz.core.registerPalette(paletteName, palette);
});
Blazor.registerFunction('BlazorDevExtreme.Core.registerTheme_5', function (customTheme, baseTheme) {
    DevExpress.viz.core.registerTheme(customTheme, baseTheme);
});
Blazor.registerFunction('BlazorDevExtreme.Core.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.viz.core.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.Core.GetOption', function (identifier, key) {
    let blazor_element = document.getElementById(identifier);
    return DevExpress.viz.core.getInstance(blazor_element).option(key);
});
