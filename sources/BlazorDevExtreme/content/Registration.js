const assemblyName = "BlazorDevExtreme";

// DevExpress.DataHelperMixin interop automatically generated
function BlazorDevExtreme_DataHelperMixin_getDataSource_0 (blazor_element) {
	return DevExpress.DataHelperMixin.getInstance(blazor_element).getDataSource();
};
function BlazorDevExtreme_DataHelperMixin_SetOption (element, key, value) {
	DevExpress.DataHelperMixin.getInstance(element).option(key, value);
};
function BlazorDevExtreme_DataHelperMixin_GetOption (element, key) {
	return DevExpress.DataHelperMixin.getInstance(blazor_element).option(key);
};
// DevExpress.dxEvent interop automatically generated
function BlazorDevExtreme_DxEvent_isDefaultPrevented_0 (blazor_element) {
	return DevExpress.dxEvent.getInstance(blazor_element).isDefaultPrevented();
};
function BlazorDevExtreme_DxEvent_isImmediatePropagationStopped_1 (blazor_element) {
	return DevExpress.dxEvent.getInstance(blazor_element).isImmediatePropagationStopped();
};
function BlazorDevExtreme_DxEvent_isPropagationStopped_2 (blazor_element) {
	return DevExpress.dxEvent.getInstance(blazor_element).isPropagationStopped();
};
function BlazorDevExtreme_DxEvent_preventDefault_3 (blazor_element) {
	DevExpress.dxEvent.getInstance(blazor_element).preventDefault();
};
function BlazorDevExtreme_DxEvent_stopImmediatePropagation_4 (blazor_element) {
	DevExpress.dxEvent.getInstance(blazor_element).stopImmediatePropagation();
};
function BlazorDevExtreme_DxEvent_stopPropagation_5 (blazor_element) {
	DevExpress.dxEvent.getInstance(blazor_element).stopPropagation();
};
function BlazorDevExtreme_DxEvent_SetOption (element, key, value) {
	DevExpress.dxEvent.getInstance(element).option(key, value);
};
function BlazorDevExtreme_DxEvent_GetOption (element, key) {
	return DevExpress.dxEvent.getInstance(blazor_element).option(key);
};
// DevExpress.localization interop automatically generated
function BlazorDevExtreme_Localization_loadMessages_0 (messages) {
	DevExpress.localization.loadMessages(messages);
};
function BlazorDevExtreme_Localization_locale_1 () {
	DevExpress.localization.locale();
};
function BlazorDevExtreme_Localization_locale_2 (locale) {
	DevExpress.localization.locale(locale);
};
function BlazorDevExtreme_Localization_SetOption (element, key, value) {
	DevExpress.localization.getInstance(element).option(key, value);
};
function BlazorDevExtreme_Localization_GetOption (element, key) {
	return DevExpress.localization.getInstance(blazor_element).option(key);
};
// DevExpress.animationPresets interop automatically generated
function BlazorDevExtreme_AnimationPresets_applyChanges_0 (blazor_element) {
	DevExpress.animationPresets.getInstance(blazor_element).applyChanges();
};
function BlazorDevExtreme_AnimationPresets_clear_1 (blazor_element) {
	DevExpress.animationPresets.getInstance(blazor_element).clear();
};
function BlazorDevExtreme_AnimationPresets_clear_2 (blazor_element, name) {
	DevExpress.animationPresets.getInstance(blazor_element).clear(name);
};
function BlazorDevExtreme_AnimationPresets_getPreset_3 (blazor_element, name) {
	return DevExpress.animationPresets.getInstance(blazor_element).getPreset(name);
};
function BlazorDevExtreme_AnimationPresets_registerDefaultPresets_4 (blazor_element) {
	DevExpress.animationPresets.getInstance(blazor_element).registerDefaultPresets();
};
function BlazorDevExtreme_AnimationPresets_registerPreset_5 (blazor_element, name, config) {
	DevExpress.animationPresets.getInstance(blazor_element).registerPreset(name, config);
};
function BlazorDevExtreme_AnimationPresets_resetToDefaults_6 (blazor_element) {
	DevExpress.animationPresets.getInstance(blazor_element).resetToDefaults();
};
function BlazorDevExtreme_AnimationPresets_SetOption (element, key, value) {
	DevExpress.animationPresets.getInstance(element).option(key, value);
};
function BlazorDevExtreme_AnimationPresets_GetOption (element, key) {
	return DevExpress.animationPresets.getInstance(blazor_element).option(key);
};
// DevExpress.TransitionExecutor interop automatically generated
function BlazorDevExtreme_TransitionExecutor_enter_0 (blazor_element, elements, animation) {
	DevExpress.TransitionExecutor.getInstance(blazor_element).enter(elements, animation);
};
function BlazorDevExtreme_TransitionExecutor_leave_1 (blazor_element, elements, animation) {
	DevExpress.TransitionExecutor.getInstance(blazor_element).leave(elements, animation);
};
function BlazorDevExtreme_TransitionExecutor_reset_2 (blazor_element) {
	DevExpress.TransitionExecutor.getInstance(blazor_element).reset();
};
function BlazorDevExtreme_TransitionExecutor_start_3 (blazor_element) {
	return DevExpress.TransitionExecutor.getInstance(blazor_element).start();
};
function BlazorDevExtreme_TransitionExecutor_stop_4 (blazor_element) {
	DevExpress.TransitionExecutor.getInstance(blazor_element).stop();
};
function BlazorDevExtreme_TransitionExecutor_SetOption (element, key, value) {
	DevExpress.TransitionExecutor.getInstance(element).option(key, value);
};
function BlazorDevExtreme_TransitionExecutor_GetOption (element, key) {
	return DevExpress.TransitionExecutor.getInstance(blazor_element).option(key);
};
// DevExpress.Component interop automatically generated
function BlazorDevExtreme_Component_Init (element, optionsText) {
	const options = JSON.parse(optionsText);

	if (options.onDisposingEnabled) {
		options.onDisposing = function () {
			DotNet.invokeMethodAsync(assemblyName, 'DevExpress.ComponentInterop.OnDisposing', element.id);
			
		}
	}
	if (options.onInitializedEnabled) {
		options.onInitialized = function () {
			DotNet.invokeMethodAsync(assemblyName, 'DevExpress.ComponentInterop.OnInitialized', element.id);
			
		}
	}
	if (options.onOptionChangedEnabled) {
		options.onOptionChanged = function () {
			DotNet.invokeMethodAsync(assemblyName, 'DevExpress.ComponentInterop.OnOptionChanged', element.id);
			
		}
	}
	let instance = new DevExpress.Component(element, options);
}
function BlazorDevExtreme_Component_beginUpdate_0 (blazor_element) {
	DevExpress.Component.getInstance(blazor_element).beginUpdate();
};
function BlazorDevExtreme_Component_endUpdate_1 (blazor_element) {
	DevExpress.Component.getInstance(blazor_element).endUpdate();
};
function BlazorDevExtreme_Component_instance_2 (blazor_element) {
	return DevExpress.Component.getInstance(blazor_element).instance();
};
function BlazorDevExtreme_Component_off_3 (blazor_element, eventName) {
	return DevExpress.Component.getInstance(blazor_element).off(eventName);
};
function BlazorDevExtreme_Component_off_4 (blazor_element, eventName, eventHandler) {
	return DevExpress.Component.getInstance(blazor_element).off(eventName, eventHandler);
};
function BlazorDevExtreme_Component_on_5 (blazor_element, eventName, eventHandler) {
	return DevExpress.Component.getInstance(blazor_element).on(eventName, eventHandler);
};
function BlazorDevExtreme_Component_on_6 (blazor_element, events) {
	return DevExpress.Component.getInstance(blazor_element).on(events);
};
function BlazorDevExtreme_Component_option_7 (blazor_element) {
	return DevExpress.Component.getInstance(blazor_element).option();
};
function BlazorDevExtreme_Component_option_8 (blazor_element, optionName) {
	return DevExpress.Component.getInstance(blazor_element).option(optionName);
};
function BlazorDevExtreme_Component_option_9 (blazor_element, optionName, optionValue) {
	DevExpress.Component.getInstance(blazor_element).option(optionName, optionValue);
};
function BlazorDevExtreme_Component_option_10 (blazor_element, options) {
	DevExpress.Component.getInstance(blazor_element).option(options);
};
function BlazorDevExtreme_Component_SetOption (element, key, value) {
	DevExpress.Component.getInstance(element).option(key, value);
};
function BlazorDevExtreme_Component_GetOption (element, key) {
	return DevExpress.Component.getInstance(blazor_element).option(key);
};
// DevExpress.DevicesObject interop automatically generated
function BlazorDevExtreme_DevicesObject_current_0 (blazor_element) {
	return DevExpress.DevicesObject.getInstance(blazor_element).current();
};
function BlazorDevExtreme_DevicesObject_current_1 (blazor_element, deviceName) {
	DevExpress.DevicesObject.getInstance(blazor_element).current(deviceName);
};
function BlazorDevExtreme_DevicesObject_off_2 (blazor_element, eventName) {
	return DevExpress.DevicesObject.getInstance(blazor_element).off(eventName);
};
function BlazorDevExtreme_DevicesObject_off_3 (blazor_element, eventName, eventHandler) {
	return DevExpress.DevicesObject.getInstance(blazor_element).off(eventName, eventHandler);
};
function BlazorDevExtreme_DevicesObject_on_4 (blazor_element, eventName, eventHandler) {
	return DevExpress.DevicesObject.getInstance(blazor_element).on(eventName, eventHandler);
};
function BlazorDevExtreme_DevicesObject_on_5 (blazor_element, events) {
	return DevExpress.DevicesObject.getInstance(blazor_element).on(events);
};
function BlazorDevExtreme_DevicesObject_orientation_6 (blazor_element) {
	return DevExpress.DevicesObject.getInstance(blazor_element).orientation();
};
function BlazorDevExtreme_DevicesObject_real_7 (blazor_element) {
	return DevExpress.DevicesObject.getInstance(blazor_element).real();
};
function BlazorDevExtreme_DevicesObject_SetOption (element, key, value) {
	DevExpress.DevicesObject.getInstance(element).option(key, value);
};
function BlazorDevExtreme_DevicesObject_GetOption (element, key) {
	return DevExpress.DevicesObject.getInstance(blazor_element).option(key);
};
// DevExpress.DOMComponent interop automatically generated
function BlazorDevExtreme_DOMComponent_Init (element, optionsText) {
	const options = JSON.parse(optionsText);

	if (options.onDisposingEnabled) {
		options.onDisposing = function () {
			DotNet.invokeMethodAsync(assemblyName, 'DevExpress.DOMComponentInterop.OnDisposing', element.id);
			
		}
	}
	if (options.onOptionChangedEnabled) {
		options.onOptionChanged = function () {
			DotNet.invokeMethodAsync(assemblyName, 'DevExpress.DOMComponentInterop.OnOptionChanged', element.id);
			
		}
	}
	let instance = new DevExpress.DOMComponent(element, options);
}
function BlazorDevExtreme_DOMComponent_defaultOptions_0 (rule) {
	DevExpress.DOMComponent.defaultOptions(rule);
};
function BlazorDevExtreme_DOMComponent_getInstance_1 (element) {
	DevExpress.DOMComponent.getInstance(element);
};
function BlazorDevExtreme_DOMComponent_dispose_0 (blazor_element) {
	DevExpress.DOMComponent.getInstance(blazor_element).dispose();
};
function BlazorDevExtreme_DOMComponent_element_1 (blazor_element) {
	return DevExpress.DOMComponent.getInstance(blazor_element).element();
};
function BlazorDevExtreme_DOMComponent_SetOption (element, key, value) {
	DevExpress.DOMComponent.getInstance(element).option(key, value);
};
function BlazorDevExtreme_DOMComponent_GetOption (element, key) {
	return DevExpress.DOMComponent.getInstance(blazor_element).option(key);
};
// DevExpress.EndpointSelector interop automatically generated
function BlazorDevExtreme_EndpointSelector_urlFor_0 (blazor_element, key) {
	return DevExpress.EndpointSelector.getInstance(blazor_element).urlFor(key);
};
function BlazorDevExtreme_EndpointSelector_SetOption (element, key, value) {
	DevExpress.EndpointSelector.getInstance(element).option(key, value);
};
function BlazorDevExtreme_EndpointSelector_GetOption (element, key) {
	return DevExpress.EndpointSelector.getInstance(blazor_element).option(key);
};
// DevExpress.validationEngine interop automatically generated
function BlazorDevExtreme_ValidationEngine_getGroupConfig_0 () {
	DevExpress.validationEngine.getGroupConfig();
};
function BlazorDevExtreme_ValidationEngine_getGroupConfig_1 (group) {
	DevExpress.validationEngine.getGroupConfig(group);
};
function BlazorDevExtreme_ValidationEngine_registerModelForValidation_2 (model) {
	DevExpress.validationEngine.registerModelForValidation(model);
};
function BlazorDevExtreme_ValidationEngine_resetGroup_3 () {
	DevExpress.validationEngine.resetGroup();
};
function BlazorDevExtreme_ValidationEngine_resetGroup_4 (group) {
	DevExpress.validationEngine.resetGroup(group);
};
function BlazorDevExtreme_ValidationEngine_unregisterModelForValidation_5 (model) {
	DevExpress.validationEngine.unregisterModelForValidation(model);
};
function BlazorDevExtreme_ValidationEngine_validateGroup_6 () {
	DevExpress.validationEngine.validateGroup();
};
function BlazorDevExtreme_ValidationEngine_validateGroup_7 (group) {
	DevExpress.validationEngine.validateGroup(group);
};
function BlazorDevExtreme_ValidationEngine_validateModel_8 (model) {
	DevExpress.validationEngine.validateModel(model);
};
function BlazorDevExtreme_ValidationEngine_SetOption (element, key, value) {
	DevExpress.validationEngine.getInstance(element).option(key, value);
};
function BlazorDevExtreme_ValidationEngine_GetOption (element, key) {
	return DevExpress.validationEngine.getInstance(blazor_element).option(key);
};
// DevExpress.ui interop automatically generated
function BlazorDevExtreme_Ui_notify_0 (message, type, displayTime) {
	DevExpress.ui.notify(message, type, displayTime);
};
function BlazorDevExtreme_Ui_notify_1 (options, type, displayTime) {
	DevExpress.ui.notify(options, type, displayTime);
};
function BlazorDevExtreme_Ui_setTemplateEngine_2 (templateEngineName) {
	DevExpress.ui.setTemplateEngine(templateEngineName);
};
function BlazorDevExtreme_Ui_setTemplateEngine_3 (templateEngineOptions) {
	DevExpress.ui.setTemplateEngine(templateEngineOptions);
};
function BlazorDevExtreme_Ui_SetOption (element, key, value) {
	DevExpress.ui.getInstance(element).option(key, value);
};
function BlazorDevExtreme_Ui_GetOption (element, key) {
	return DevExpress.ui.getInstance(blazor_element).option(key);
};
// DevExpress.viz interop automatically generated
function BlazorDevExtreme_Viz_currentPalette_0 (paletteName) {
	DevExpress.viz.currentPalette(paletteName);
};
function BlazorDevExtreme_Viz_currentTheme_1 () {
	DevExpress.viz.currentTheme();
};
function BlazorDevExtreme_Viz_currentTheme_2 (platform, colorScheme) {
	DevExpress.viz.currentTheme(platform, colorScheme);
};
function BlazorDevExtreme_Viz_currentTheme_3 (theme) {
	DevExpress.viz.currentTheme(theme);
};
function BlazorDevExtreme_Viz_exportFromMarkup_4 (markup, options) {
	DevExpress.viz.exportFromMarkup(markup, options);
};
function BlazorDevExtreme_Viz_getMarkup_5 (widgetInstances) {
	DevExpress.viz.getMarkup(widgetInstances);
};
function BlazorDevExtreme_Viz_getPalette_6 (paletteName) {
	DevExpress.viz.getPalette(paletteName);
};
function BlazorDevExtreme_Viz_getTheme_7 (theme) {
	DevExpress.viz.getTheme(theme);
};
function BlazorDevExtreme_Viz_refreshPaths_8 () {
	DevExpress.viz.refreshPaths();
};
function BlazorDevExtreme_Viz_refreshTheme_9 () {
	DevExpress.viz.refreshTheme();
};
function BlazorDevExtreme_Viz_registerPalette_10 (paletteName, palette) {
	DevExpress.viz.registerPalette(paletteName, palette);
};
function BlazorDevExtreme_Viz_registerTheme_11 (customTheme, baseTheme) {
	DevExpress.viz.registerTheme(customTheme, baseTheme);
};
function BlazorDevExtreme_Viz_SetOption (element, key, value) {
	DevExpress.viz.getInstance(element).option(key, value);
};
function BlazorDevExtreme_Viz_GetOption (element, key) {
	return DevExpress.viz.getInstance(blazor_element).option(key);
};
// DevExpress.data.Guid interop automatically generated
function BlazorDevExtreme_Guid_toString_0 (blazor_element) {
	return DevExpress.data.Guid.getInstance(blazor_element).toString();
};
function BlazorDevExtreme_Guid_valueOf_1 (blazor_element) {
	return DevExpress.data.Guid.getInstance(blazor_element).valueOf();
};
function BlazorDevExtreme_Guid_SetOption (element, key, value) {
	DevExpress.data.Guid.getInstance(element).option(key, value);
};
function BlazorDevExtreme_Guid_GetOption (element, key) {
	return DevExpress.data.Guid.getInstance(blazor_element).option(key);
};
// DevExpress.data.Store interop automatically generated
function BlazorDevExtreme_Store_Init (element, optionsText) {
	const options = JSON.parse(optionsText);

	if (options.onInsertedEnabled) {
		options.onInserted = function () {
			DotNet.invokeMethodAsync(assemblyName, 'DevExpress.Data.StoreInterop.OnInserted', element.id);
			
		}
	}
	if (options.onInsertingEnabled) {
		options.onInserting = function () {
			DotNet.invokeMethodAsync(assemblyName, 'DevExpress.Data.StoreInterop.OnInserting', element.id);
			
		}
	}
	if (options.onLoadedEnabled) {
		options.onLoaded = function () {
			DotNet.invokeMethodAsync(assemblyName, 'DevExpress.Data.StoreInterop.OnLoaded', element.id);
			
		}
	}
	if (options.onLoadingEnabled) {
		options.onLoading = function () {
			DotNet.invokeMethodAsync(assemblyName, 'DevExpress.Data.StoreInterop.OnLoading', element.id);
			
		}
	}
	if (options.onModifiedEnabled) {
		options.onModified = function () {
			DotNet.invokeMethodAsync(assemblyName, 'DevExpress.Data.StoreInterop.OnModified', element.id);
			
		}
	}
	if (options.onModifyingEnabled) {
		options.onModifying = function () {
			DotNet.invokeMethodAsync(assemblyName, 'DevExpress.Data.StoreInterop.OnModifying', element.id);
			
		}
	}
	if (options.onRemovedEnabled) {
		options.onRemoved = function () {
			DotNet.invokeMethodAsync(assemblyName, 'DevExpress.Data.StoreInterop.OnRemoved', element.id);
			
		}
	}
	if (options.onRemovingEnabled) {
		options.onRemoving = function () {
			DotNet.invokeMethodAsync(assemblyName, 'DevExpress.Data.StoreInterop.OnRemoving', element.id);
			
		}
	}
	if (options.onUpdatedEnabled) {
		options.onUpdated = function () {
			DotNet.invokeMethodAsync(assemblyName, 'DevExpress.Data.StoreInterop.OnUpdated', element.id);
			
		}
	}
	if (options.onUpdatingEnabled) {
		options.onUpdating = function () {
			DotNet.invokeMethodAsync(assemblyName, 'DevExpress.Data.StoreInterop.OnUpdating', element.id);
			
		}
	}
	let instance = new DevExpress.data.Store(element, options);
}
function BlazorDevExtreme_Store_byKey_0 (blazor_element, key) {
	return DevExpress.data.Store.getInstance(blazor_element).byKey(key);
};
function BlazorDevExtreme_Store_insert_1 (blazor_element, values) {
	return DevExpress.data.Store.getInstance(blazor_element).insert(values);
};
function BlazorDevExtreme_Store_key_2 (blazor_element) {
	return DevExpress.data.Store.getInstance(blazor_element).key();
};
function BlazorDevExtreme_Store_keyOf_3 (blazor_element, obj) {
	return DevExpress.data.Store.getInstance(blazor_element).keyOf(obj);
};
function BlazorDevExtreme_Store_load_4 (blazor_element) {
	return DevExpress.data.Store.getInstance(blazor_element).load();
};
function BlazorDevExtreme_Store_load_5 (blazor_element, options) {
	return DevExpress.data.Store.getInstance(blazor_element).load(options);
};
function BlazorDevExtreme_Store_off_6 (blazor_element, eventName) {
	return DevExpress.data.Store.getInstance(blazor_element).off(eventName);
};
function BlazorDevExtreme_Store_off_7 (blazor_element, eventName, eventHandler) {
	return DevExpress.data.Store.getInstance(blazor_element).off(eventName, eventHandler);
};
function BlazorDevExtreme_Store_on_8 (blazor_element, eventName, eventHandler) {
	return DevExpress.data.Store.getInstance(blazor_element).on(eventName, eventHandler);
};
function BlazorDevExtreme_Store_on_9 (blazor_element, events) {
	return DevExpress.data.Store.getInstance(blazor_element).on(events);
};
function BlazorDevExtreme_Store_remove_10 (blazor_element, key) {
	return DevExpress.data.Store.getInstance(blazor_element).remove(key);
};
function BlazorDevExtreme_Store_totalCount_11 (blazor_element, obj) {
	return DevExpress.data.Store.getInstance(blazor_element).totalCount(obj);
};
function BlazorDevExtreme_Store_update_12 (blazor_element, key, values) {
	return DevExpress.data.Store.getInstance(blazor_element).update(key, values);
};
function BlazorDevExtreme_Store_SetOption (element, key, value) {
	DevExpress.data.Store.getInstance(element).option(key, value);
};
function BlazorDevExtreme_Store_GetOption (element, key) {
	return DevExpress.data.Store.getInstance(blazor_element).option(key);
};
// DevExpress.data.ArrayStore interop automatically generated
function BlazorDevExtreme_ArrayStore_Init (element, optionsText) {
	const options = JSON.parse(optionsText);

	let instance = new DevExpress.data.ArrayStore(element, options);
}
function BlazorDevExtreme_ArrayStore_clear_0 (blazor_element) {
	DevExpress.data.ArrayStore.getInstance(blazor_element).clear();
};
function BlazorDevExtreme_ArrayStore_createQuery_1 (blazor_element) {
	return DevExpress.data.ArrayStore.getInstance(blazor_element).createQuery();
};
function BlazorDevExtreme_ArrayStore_SetOption (element, key, value) {
	DevExpress.data.ArrayStore.getInstance(element).option(key, value);
};
function BlazorDevExtreme_ArrayStore_GetOption (element, key) {
	return DevExpress.data.ArrayStore.getInstance(blazor_element).option(key);
};
// DevExpress.data.CustomStore interop automatically generated
function BlazorDevExtreme_CustomStore_Init (element, optionsText) {
	const options = JSON.parse(optionsText);

	let instance = new DevExpress.data.CustomStore(element, options);
}
function BlazorDevExtreme_CustomStore_clearRawDataCache_0 (blazor_element) {
	DevExpress.data.CustomStore.getInstance(blazor_element).clearRawDataCache();
};
function BlazorDevExtreme_CustomStore_SetOption (element, key, value) {
	DevExpress.data.CustomStore.getInstance(element).option(key, value);
};
function BlazorDevExtreme_CustomStore_GetOption (element, key) {
	return DevExpress.data.CustomStore.getInstance(blazor_element).option(key);
};
// DevExpress.data.DataSource interop automatically generated
function BlazorDevExtreme_DataSource_Init (element, optionsText) {
	const options = JSON.parse(optionsText);

	if (options.onChangedEnabled) {
		options.onChanged = function () {
			DotNet.invokeMethodAsync(assemblyName, 'DevExpress.Data.DataSourceInterop.OnChanged', element.id);
			
		}
	}
	if (options.onLoadErrorEnabled) {
		options.onLoadError = function () {
			DotNet.invokeMethodAsync(assemblyName, 'DevExpress.Data.DataSourceInterop.OnLoadError', element.id);
			
		}
	}
	if (options.onLoadingChangedEnabled) {
		options.onLoadingChanged = function () {
			DotNet.invokeMethodAsync(assemblyName, 'DevExpress.Data.DataSourceInterop.OnLoadingChanged', element.id);
			
		}
	}
	let instance = new DevExpress.data.DataSource(element, options);
}
function BlazorDevExtreme_DataSource_cancel_0 (blazor_element) {
	return DevExpress.data.DataSource.getInstance(blazor_element).cancel();
};
function BlazorDevExtreme_DataSource_dispose_1 (blazor_element) {
	DevExpress.data.DataSource.getInstance(blazor_element).dispose();
};
function BlazorDevExtreme_DataSource_filter_2 (blazor_element) {
	return DevExpress.data.DataSource.getInstance(blazor_element).filter();
};
function BlazorDevExtreme_DataSource_filter_3 (blazor_element, filterExpr) {
	DevExpress.data.DataSource.getInstance(blazor_element).filter(filterExpr);
};
function BlazorDevExtreme_DataSource_group_4 (blazor_element) {
	return DevExpress.data.DataSource.getInstance(blazor_element).group();
};
function BlazorDevExtreme_DataSource_group_5 (blazor_element, groupExpr) {
	DevExpress.data.DataSource.getInstance(blazor_element).group(groupExpr);
};
function BlazorDevExtreme_DataSource_isLastPage_6 (blazor_element) {
	return DevExpress.data.DataSource.getInstance(blazor_element).isLastPage();
};
function BlazorDevExtreme_DataSource_isLoaded_7 (blazor_element) {
	return DevExpress.data.DataSource.getInstance(blazor_element).isLoaded();
};
function BlazorDevExtreme_DataSource_isLoading_8 (blazor_element) {
	return DevExpress.data.DataSource.getInstance(blazor_element).isLoading();
};
function BlazorDevExtreme_DataSource_items_9 (blazor_element) {
	return DevExpress.data.DataSource.getInstance(blazor_element).items();
};
function BlazorDevExtreme_DataSource_key_10 (blazor_element) {
	return DevExpress.data.DataSource.getInstance(blazor_element).key();
};
function BlazorDevExtreme_DataSource_load_11 (blazor_element) {
	return DevExpress.data.DataSource.getInstance(blazor_element).load();
};
function BlazorDevExtreme_DataSource_loadOptions_12 (blazor_element) {
	return DevExpress.data.DataSource.getInstance(blazor_element).loadOptions();
};
function BlazorDevExtreme_DataSource_off_13 (blazor_element, eventName) {
	return DevExpress.data.DataSource.getInstance(blazor_element).off(eventName);
};
function BlazorDevExtreme_DataSource_off_14 (blazor_element, eventName, eventHandler) {
	return DevExpress.data.DataSource.getInstance(blazor_element).off(eventName, eventHandler);
};
function BlazorDevExtreme_DataSource_on_15 (blazor_element, eventName, eventHandler) {
	return DevExpress.data.DataSource.getInstance(blazor_element).on(eventName, eventHandler);
};
function BlazorDevExtreme_DataSource_on_16 (blazor_element, events) {
	return DevExpress.data.DataSource.getInstance(blazor_element).on(events);
};
function BlazorDevExtreme_DataSource_pageIndex_17 (blazor_element) {
	return DevExpress.data.DataSource.getInstance(blazor_element).pageIndex();
};
function BlazorDevExtreme_DataSource_pageIndex_18 (blazor_element, newIndex) {
	DevExpress.data.DataSource.getInstance(blazor_element).pageIndex(newIndex);
};
function BlazorDevExtreme_DataSource_pageSize_19 (blazor_element) {
	return DevExpress.data.DataSource.getInstance(blazor_element).pageSize();
};
function BlazorDevExtreme_DataSource_pageSize_20 (blazor_element, value) {
	DevExpress.data.DataSource.getInstance(blazor_element).pageSize(value);
};
function BlazorDevExtreme_DataSource_paginate_21 (blazor_element) {
	return DevExpress.data.DataSource.getInstance(blazor_element).paginate();
};
function BlazorDevExtreme_DataSource_paginate_22 (blazor_element, value) {
	DevExpress.data.DataSource.getInstance(blazor_element).paginate(value);
};
function BlazorDevExtreme_DataSource_reload_23 (blazor_element) {
	return DevExpress.data.DataSource.getInstance(blazor_element).reload();
};
function BlazorDevExtreme_DataSource_requireTotalCount_24 (blazor_element) {
	return DevExpress.data.DataSource.getInstance(blazor_element).requireTotalCount();
};
function BlazorDevExtreme_DataSource_requireTotalCount_25 (blazor_element, value) {
	DevExpress.data.DataSource.getInstance(blazor_element).requireTotalCount(value);
};
function BlazorDevExtreme_DataSource_searchExpr_26 (blazor_element) {
	return DevExpress.data.DataSource.getInstance(blazor_element).searchExpr();
};
function BlazorDevExtreme_DataSource_searchExpr_27 (blazor_element, expr) {
	DevExpress.data.DataSource.getInstance(blazor_element).searchExpr(expr);
};
function BlazorDevExtreme_DataSource_searchOperation_28 (blazor_element) {
	return DevExpress.data.DataSource.getInstance(blazor_element).searchOperation();
};
function BlazorDevExtreme_DataSource_searchOperation_29 (blazor_element, op) {
	DevExpress.data.DataSource.getInstance(blazor_element).searchOperation(op);
};
function BlazorDevExtreme_DataSource_searchValue_30 (blazor_element) {
	return DevExpress.data.DataSource.getInstance(blazor_element).searchValue();
};
function BlazorDevExtreme_DataSource_searchValue_31 (blazor_element, value) {
	DevExpress.data.DataSource.getInstance(blazor_element).searchValue(value);
};
function BlazorDevExtreme_DataSource_select_32 (blazor_element) {
	return DevExpress.data.DataSource.getInstance(blazor_element).select();
};
function BlazorDevExtreme_DataSource_select_33 (blazor_element, expr) {
	DevExpress.data.DataSource.getInstance(blazor_element).select(expr);
};
function BlazorDevExtreme_DataSource_sort_34 (blazor_element) {
	return DevExpress.data.DataSource.getInstance(blazor_element).sort();
};
function BlazorDevExtreme_DataSource_sort_35 (blazor_element, sortExpr) {
	DevExpress.data.DataSource.getInstance(blazor_element).sort(sortExpr);
};
function BlazorDevExtreme_DataSource_store_36 (blazor_element) {
	return DevExpress.data.DataSource.getInstance(blazor_element).store();
};
function BlazorDevExtreme_DataSource_totalCount_37 (blazor_element) {
	return DevExpress.data.DataSource.getInstance(blazor_element).totalCount();
};
function BlazorDevExtreme_DataSource_SetOption (element, key, value) {
	DevExpress.data.DataSource.getInstance(element).option(key, value);
};
function BlazorDevExtreme_DataSource_GetOption (element, key) {
	return DevExpress.data.DataSource.getInstance(blazor_element).option(key);
};
// DevExpress.data.LocalStore interop automatically generated
function BlazorDevExtreme_LocalStore_Init (element, optionsText) {
	const options = JSON.parse(optionsText);

	let instance = new DevExpress.data.LocalStore(element, options);
}
function BlazorDevExtreme_LocalStore_clear_0 (blazor_element) {
	DevExpress.data.LocalStore.getInstance(blazor_element).clear();
};
function BlazorDevExtreme_LocalStore_SetOption (element, key, value) {
	DevExpress.data.LocalStore.getInstance(element).option(key, value);
};
function BlazorDevExtreme_LocalStore_GetOption (element, key) {
	return DevExpress.data.LocalStore.getInstance(blazor_element).option(key);
};
// DevExpress.data.Query interop automatically generated
function BlazorDevExtreme_Query_aggregate_0 (blazor_element, seed, step, finalize) {
	return DevExpress.data.Query.getInstance(blazor_element).aggregate(seed, step, finalize);
};
function BlazorDevExtreme_Query_aggregate_1 (blazor_element, step) {
	return DevExpress.data.Query.getInstance(blazor_element).aggregate(step);
};
function BlazorDevExtreme_Query_avg_2 (blazor_element) {
	return DevExpress.data.Query.getInstance(blazor_element).avg();
};
function BlazorDevExtreme_Query_avg_3 (blazor_element, getter) {
	return DevExpress.data.Query.getInstance(blazor_element).avg(getter);
};
function BlazorDevExtreme_Query_count_4 (blazor_element) {
	return DevExpress.data.Query.getInstance(blazor_element).count();
};
function BlazorDevExtreme_Query_enumerate_5 (blazor_element) {
	return DevExpress.data.Query.getInstance(blazor_element).enumerate();
};
function BlazorDevExtreme_Query_filter_6 (blazor_element, criteria) {
	return DevExpress.data.Query.getInstance(blazor_element).filter(criteria);
};
function BlazorDevExtreme_Query_filter_7 (blazor_element, predicate) {
	return DevExpress.data.Query.getInstance(blazor_element).filter(predicate);
};
function BlazorDevExtreme_Query_groupBy_8 (blazor_element, getter) {
	return DevExpress.data.Query.getInstance(blazor_element).groupBy(getter);
};
function BlazorDevExtreme_Query_max_9 (blazor_element) {
	return DevExpress.data.Query.getInstance(blazor_element).max();
};
function BlazorDevExtreme_Query_max_10 (blazor_element, getter) {
	return DevExpress.data.Query.getInstance(blazor_element).max(getter);
};
function BlazorDevExtreme_Query_min_11 (blazor_element) {
	return DevExpress.data.Query.getInstance(blazor_element).min();
};
function BlazorDevExtreme_Query_min_12 (blazor_element, getter) {
	return DevExpress.data.Query.getInstance(blazor_element).min(getter);
};
function BlazorDevExtreme_Query_select_13 (blazor_element, getter) {
	return DevExpress.data.Query.getInstance(blazor_element).select(getter);
};
function BlazorDevExtreme_Query_slice_14 (blazor_element, skip, take) {
	return DevExpress.data.Query.getInstance(blazor_element).slice(skip, take);
};
function BlazorDevExtreme_Query_sortBy_15 (blazor_element, getter) {
	return DevExpress.data.Query.getInstance(blazor_element).sortBy(getter);
};
function BlazorDevExtreme_Query_sortBy_16 (blazor_element, getter, desc) {
	return DevExpress.data.Query.getInstance(blazor_element).sortBy(getter, desc);
};
function BlazorDevExtreme_Query_sum_17 (blazor_element) {
	return DevExpress.data.Query.getInstance(blazor_element).sum();
};
function BlazorDevExtreme_Query_sum_18 (blazor_element, getter) {
	return DevExpress.data.Query.getInstance(blazor_element).sum(getter);
};
function BlazorDevExtreme_Query_thenBy_19 (blazor_element, getter) {
	return DevExpress.data.Query.getInstance(blazor_element).thenBy(getter);
};
function BlazorDevExtreme_Query_thenBy_20 (blazor_element, getter, desc) {
	return DevExpress.data.Query.getInstance(blazor_element).thenBy(getter, desc);
};
function BlazorDevExtreme_Query_toArray_21 (blazor_element) {
	return DevExpress.data.Query.getInstance(blazor_element).toArray();
};
function BlazorDevExtreme_Query_SetOption (element, key, value) {
	DevExpress.data.Query.getInstance(element).option(key, value);
};
function BlazorDevExtreme_Query_GetOption (element, key) {
	return DevExpress.data.Query.getInstance(blazor_element).option(key);
};
// DevExpress.data.ODataContext interop automatically generated
function BlazorDevExtreme_ODataContext_Init (element, optionsText) {
	const options = JSON.parse(optionsText);

	let instance = new DevExpress.data.ODataContext(element, options);
}
function BlazorDevExtreme_ODataContext_get_0 (blazor_element, operationName, params) {
	return DevExpress.data.ODataContext.getInstance(blazor_element).get(operationName, params);
};
function BlazorDevExtreme_ODataContext_invoke_1 (blazor_element, operationName, params, httpMethod) {
	return DevExpress.data.ODataContext.getInstance(blazor_element).invoke(operationName, params, httpMethod);
};
function BlazorDevExtreme_ODataContext_objectLink_2 (blazor_element, entityAlias, key) {
	return DevExpress.data.ODataContext.getInstance(blazor_element).objectLink(entityAlias, key);
};
function BlazorDevExtreme_ODataContext_SetOption (element, key, value) {
	DevExpress.data.ODataContext.getInstance(element).option(key, value);
};
function BlazorDevExtreme_ODataContext_GetOption (element, key) {
	return DevExpress.data.ODataContext.getInstance(blazor_element).option(key);
};
// DevExpress.data.ODataStore interop automatically generated
function BlazorDevExtreme_ODataStore_Init (element, optionsText) {
	const options = JSON.parse(optionsText);

	if (options.onLoadingEnabled) {
		options.onLoading = function () {
			DotNet.invokeMethodAsync(assemblyName, 'DevExpress.Data.ODataStoreInterop.OnLoading', element.id);
			
		}
	}
	let instance = new DevExpress.data.ODataStore(element, options);
}
function BlazorDevExtreme_ODataStore_byKey_0 (blazor_element, key) {
	return DevExpress.data.ODataStore.getInstance(blazor_element).byKey(key);
};
function BlazorDevExtreme_ODataStore_byKey_1 (blazor_element, key, extraOptions) {
	return DevExpress.data.ODataStore.getInstance(blazor_element).byKey(key, extraOptions);
};
function BlazorDevExtreme_ODataStore_createQuery_2 (blazor_element, loadOptions) {
	return DevExpress.data.ODataStore.getInstance(blazor_element).createQuery(loadOptions);
};
function BlazorDevExtreme_ODataStore_load_3 (blazor_element) {
	return DevExpress.data.ODataStore.getInstance(blazor_element).load();
};
function BlazorDevExtreme_ODataStore_load_4 (blazor_element, options) {
	return DevExpress.data.ODataStore.getInstance(blazor_element).load(options);
};
function BlazorDevExtreme_ODataStore_SetOption (element, key, value) {
	DevExpress.data.ODataStore.getInstance(element).option(key, value);
};
function BlazorDevExtreme_ODataStore_GetOption (element, key) {
	return DevExpress.data.ODataStore.getInstance(blazor_element).option(key);
};
// DevExpress.data.EdmLiteral interop automatically generated
function BlazorDevExtreme_EdmLiteral_valueOf_0 (blazor_element) {
	return DevExpress.data.EdmLiteral.getInstance(blazor_element).valueOf();
};
function BlazorDevExtreme_EdmLiteral_SetOption (element, key, value) {
	DevExpress.data.EdmLiteral.getInstance(element).option(key, value);
};
function BlazorDevExtreme_EdmLiteral_GetOption (element, key) {
	return DevExpress.data.EdmLiteral.getInstance(blazor_element).option(key);
};
// DevExpress.data.PivotGridDataSource interop automatically generated
function BlazorDevExtreme_PivotGridDataSource_Init (element, optionsText) {
	const options = JSON.parse(optionsText);

	if (options.onChangedEnabled) {
		options.onChanged = function () {
			DotNet.invokeMethodAsync(assemblyName, 'DevExpress.Data.PivotGridDataSourceInterop.OnChanged', element.id);
			
		}
	}
	if (options.onFieldsPreparedEnabled) {
		options.onFieldsPrepared = function () {
			DotNet.invokeMethodAsync(assemblyName, 'DevExpress.Data.PivotGridDataSourceInterop.OnFieldsPrepared', element.id);
			
		}
	}
	if (options.onLoadErrorEnabled) {
		options.onLoadError = function () {
			DotNet.invokeMethodAsync(assemblyName, 'DevExpress.Data.PivotGridDataSourceInterop.OnLoadError', element.id);
			
		}
	}
	if (options.onLoadingChangedEnabled) {
		options.onLoadingChanged = function () {
			DotNet.invokeMethodAsync(assemblyName, 'DevExpress.Data.PivotGridDataSourceInterop.OnLoadingChanged', element.id);
			
		}
	}
	let instance = new DevExpress.data.PivotGridDataSource(element, options);
}
function BlazorDevExtreme_PivotGridDataSource_collapseAll_0 (blazor_element, id) {
	DevExpress.data.PivotGridDataSource.getInstance(blazor_element).collapseAll(id);
};
function BlazorDevExtreme_PivotGridDataSource_collapseHeaderItem_1 (blazor_element, area, path) {
	DevExpress.data.PivotGridDataSource.getInstance(blazor_element).collapseHeaderItem(area, path);
};
function BlazorDevExtreme_PivotGridDataSource_createDrillDownDataSource_2 (blazor_element, options) {
	return DevExpress.data.PivotGridDataSource.getInstance(blazor_element).createDrillDownDataSource(options);
};
function BlazorDevExtreme_PivotGridDataSource_dispose_3 (blazor_element) {
	DevExpress.data.PivotGridDataSource.getInstance(blazor_element).dispose();
};
function BlazorDevExtreme_PivotGridDataSource_expandAll_4 (blazor_element, id) {
	DevExpress.data.PivotGridDataSource.getInstance(blazor_element).expandAll(id);
};
function BlazorDevExtreme_PivotGridDataSource_expandHeaderItem_5 (blazor_element, area, path) {
	DevExpress.data.PivotGridDataSource.getInstance(blazor_element).expandHeaderItem(area, path);
};
function BlazorDevExtreme_PivotGridDataSource_field_6 (blazor_element, id) {
	return DevExpress.data.PivotGridDataSource.getInstance(blazor_element).field(id);
};
function BlazorDevExtreme_PivotGridDataSource_field_7 (blazor_element, id, options) {
	DevExpress.data.PivotGridDataSource.getInstance(blazor_element).field(id, options);
};
function BlazorDevExtreme_PivotGridDataSource_fields_8 (blazor_element) {
	return DevExpress.data.PivotGridDataSource.getInstance(blazor_element).fields();
};
function BlazorDevExtreme_PivotGridDataSource_fields_9 (blazor_element, fields) {
	DevExpress.data.PivotGridDataSource.getInstance(blazor_element).fields(fields);
};
function BlazorDevExtreme_PivotGridDataSource_filter_10 (blazor_element) {
	return DevExpress.data.PivotGridDataSource.getInstance(blazor_element).filter();
};
function BlazorDevExtreme_PivotGridDataSource_filter_11 (blazor_element, filterExpr) {
	DevExpress.data.PivotGridDataSource.getInstance(blazor_element).filter(filterExpr);
};
function BlazorDevExtreme_PivotGridDataSource_getAreaFields_12 (blazor_element, area, collectGroups) {
	return DevExpress.data.PivotGridDataSource.getInstance(blazor_element).getAreaFields(area, collectGroups);
};
function BlazorDevExtreme_PivotGridDataSource_getData_13 (blazor_element) {
	return DevExpress.data.PivotGridDataSource.getInstance(blazor_element).getData();
};
function BlazorDevExtreme_PivotGridDataSource_isLoading_14 (blazor_element) {
	return DevExpress.data.PivotGridDataSource.getInstance(blazor_element).isLoading();
};
function BlazorDevExtreme_PivotGridDataSource_load_15 (blazor_element) {
	return DevExpress.data.PivotGridDataSource.getInstance(blazor_element).load();
};
function BlazorDevExtreme_PivotGridDataSource_off_16 (blazor_element, eventName) {
	return DevExpress.data.PivotGridDataSource.getInstance(blazor_element).off(eventName);
};
function BlazorDevExtreme_PivotGridDataSource_off_17 (blazor_element, eventName, eventHandler) {
	return DevExpress.data.PivotGridDataSource.getInstance(blazor_element).off(eventName, eventHandler);
};
function BlazorDevExtreme_PivotGridDataSource_on_18 (blazor_element, eventName, eventHandler) {
	return DevExpress.data.PivotGridDataSource.getInstance(blazor_element).on(eventName, eventHandler);
};
function BlazorDevExtreme_PivotGridDataSource_on_19 (blazor_element, events) {
	return DevExpress.data.PivotGridDataSource.getInstance(blazor_element).on(events);
};
function BlazorDevExtreme_PivotGridDataSource_reload_20 (blazor_element) {
	return DevExpress.data.PivotGridDataSource.getInstance(blazor_element).reload();
};
function BlazorDevExtreme_PivotGridDataSource_state_21 (blazor_element) {
	return DevExpress.data.PivotGridDataSource.getInstance(blazor_element).state();
};
function BlazorDevExtreme_PivotGridDataSource_state_22 (blazor_element, state) {
	DevExpress.data.PivotGridDataSource.getInstance(blazor_element).state(state);
};
function BlazorDevExtreme_PivotGridDataSource_SetOption (element, key, value) {
	DevExpress.data.PivotGridDataSource.getInstance(element).option(key, value);
};
function BlazorDevExtreme_PivotGridDataSource_GetOption (element, key) {
	return DevExpress.data.PivotGridDataSource.getInstance(blazor_element).option(key);
};
// DevExpress.data.XmlaStore interop automatically generated
function BlazorDevExtreme_XmlaStore_Init (element, optionsText) {
	const options = JSON.parse(optionsText);

	let instance = new DevExpress.data.XmlaStore(element, options);
}
function BlazorDevExtreme_XmlaStore_SetOption (element, key, value) {
	DevExpress.data.XmlaStore.getInstance(element).option(key, value);
};
function BlazorDevExtreme_XmlaStore_GetOption (element, key) {
	return DevExpress.data.XmlaStore.getInstance(blazor_element).option(key);
};
// DevExpress.core.EventsMixin interop automatically generated
function BlazorDevExtreme_EventsMixin_off_0 (blazor_element, eventName) {
	return DevExpress.core.EventsMixin.getInstance(blazor_element).off(eventName);
};
function BlazorDevExtreme_EventsMixin_off_1 (blazor_element, eventName, eventHandler) {
	return DevExpress.core.EventsMixin.getInstance(blazor_element).off(eventName, eventHandler);
};
function BlazorDevExtreme_EventsMixin_on_2 (blazor_element, eventName, eventHandler) {
	return DevExpress.core.EventsMixin.getInstance(blazor_element).on(eventName, eventHandler);
};
function BlazorDevExtreme_EventsMixin_on_3 (blazor_element, events) {
	return DevExpress.core.EventsMixin.getInstance(blazor_element).on(events);
};
function BlazorDevExtreme_EventsMixin_SetOption (element, key, value) {
	DevExpress.core.EventsMixin.getInstance(element).option(key, value);
};
function BlazorDevExtreme_EventsMixin_GetOption (element, key) {
	return DevExpress.core.EventsMixin.getInstance(blazor_element).option(key);
};
// DevExpress.framework.dxCommand interop automatically generated
function BlazorDevExtreme_DxCommand_Init (element, optionsText) {
	const options = JSON.parse(optionsText);

	if (options.onExecuteEnabled) {
		options.onExecute = function () {
			DotNet.invokeMethodAsync(assemblyName, 'DevExpress.Framework.DxCommandInterop.OnExecute', element.id);
			
		}
	}
	let instance = new DevExpress.framework.dxCommand(element, options);
}
function BlazorDevExtreme_DxCommand_execute_0 (blazor_element) {
	DevExpress.framework.dxCommand.getInstance(blazor_element).execute();
};
function BlazorDevExtreme_DxCommand_SetOption (element, key, value) {
	DevExpress.framework.dxCommand.getInstance(element).option(key, value);
};
function BlazorDevExtreme_DxCommand_GetOption (element, key) {
	return DevExpress.framework.dxCommand.getInstance(blazor_element).option(key);
};
// DevExpress.framework.Router interop automatically generated
function BlazorDevExtreme_Router_format_0 (blazor_element, obj) {
	return DevExpress.framework.Router.getInstance(blazor_element).format(obj);
};
function BlazorDevExtreme_Router_parse_1 (blazor_element, uri) {
	return DevExpress.framework.Router.getInstance(blazor_element).parse(uri);
};
function BlazorDevExtreme_Router_register_2 (blazor_element, pattern, defaults, constraints) {
	DevExpress.framework.Router.getInstance(blazor_element).register(pattern, defaults, constraints);
};
function BlazorDevExtreme_Router_SetOption (element, key, value) {
	DevExpress.framework.Router.getInstance(element).option(key, value);
};
function BlazorDevExtreme_Router_GetOption (element, key) {
	return DevExpress.framework.Router.getInstance(blazor_element).option(key);
};
// DevExpress.framework.StateManager interop automatically generated
function BlazorDevExtreme_StateManager_Init (element, optionsText) {
	const options = JSON.parse(optionsText);

	let instance = new DevExpress.framework.StateManager(element, options);
}
function BlazorDevExtreme_StateManager_addStateSource_0 (blazor_element, stateSource) {
	DevExpress.framework.StateManager.getInstance(blazor_element).addStateSource(stateSource);
};
function BlazorDevExtreme_StateManager_clearState_1 (blazor_element) {
	DevExpress.framework.StateManager.getInstance(blazor_element).clearState();
};
function BlazorDevExtreme_StateManager_removeStateSource_2 (blazor_element, stateSource) {
	DevExpress.framework.StateManager.getInstance(blazor_element).removeStateSource(stateSource);
};
function BlazorDevExtreme_StateManager_restoreState_3 (blazor_element) {
	DevExpress.framework.StateManager.getInstance(blazor_element).restoreState();
};
function BlazorDevExtreme_StateManager_saveState_4 (blazor_element) {
	DevExpress.framework.StateManager.getInstance(blazor_element).saveState();
};
function BlazorDevExtreme_StateManager_SetOption (element, key, value) {
	DevExpress.framework.StateManager.getInstance(element).option(key, value);
};
function BlazorDevExtreme_StateManager_GetOption (element, key) {
	return DevExpress.framework.StateManager.getInstance(blazor_element).option(key);
};
// DevExpress.framework.ViewCache interop automatically generated
function BlazorDevExtreme_ViewCache_clear_0 (blazor_element) {
	DevExpress.framework.ViewCache.getInstance(blazor_element).clear();
};
function BlazorDevExtreme_ViewCache_getView_1 (blazor_element, key) {
	return DevExpress.framework.ViewCache.getInstance(blazor_element).getView(key);
};
function BlazorDevExtreme_ViewCache_hasView_2 (blazor_element, key) {
	return DevExpress.framework.ViewCache.getInstance(blazor_element).hasView(key);
};
function BlazorDevExtreme_ViewCache_off_3 (blazor_element, eventName) {
	return DevExpress.framework.ViewCache.getInstance(blazor_element).off(eventName);
};
function BlazorDevExtreme_ViewCache_off_4 (blazor_element, eventName, eventHandler) {
	return DevExpress.framework.ViewCache.getInstance(blazor_element).off(eventName, eventHandler);
};
function BlazorDevExtreme_ViewCache_on_5 (blazor_element, eventName, eventHandler) {
	return DevExpress.framework.ViewCache.getInstance(blazor_element).on(eventName, eventHandler);
};
function BlazorDevExtreme_ViewCache_on_6 (blazor_element, events) {
	return DevExpress.framework.ViewCache.getInstance(blazor_element).on(events);
};
function BlazorDevExtreme_ViewCache_removeView_7 (blazor_element, key) {
	return DevExpress.framework.ViewCache.getInstance(blazor_element).removeView(key);
};
function BlazorDevExtreme_ViewCache_setView_8 (blazor_element, key, viewInfo) {
	DevExpress.framework.ViewCache.getInstance(blazor_element).setView(key, viewInfo);
};
function BlazorDevExtreme_ViewCache_SetOption (element, key, value) {
	DevExpress.framework.ViewCache.getInstance(element).option(key, value);
};
function BlazorDevExtreme_ViewCache_GetOption (element, key) {
	return DevExpress.framework.ViewCache.getInstance(blazor_element).option(key);
};
// DevExpress.framework.dxCommandContainer interop automatically generated
function BlazorDevExtreme_DxCommandContainer_Init (element, optionsText) {
	const options = JSON.parse(optionsText);

	let instance = new DevExpress.framework.dxCommandContainer(element, options);
}
function BlazorDevExtreme_DxCommandContainer_SetOption (element, key, value) {
	DevExpress.framework.dxCommandContainer.getInstance(element).option(key, value);
};
function BlazorDevExtreme_DxCommandContainer_GetOption (element, key) {
	return DevExpress.framework.dxCommandContainer.getInstance(blazor_element).option(key);
};
// DevExpress.framework.dxView interop automatically generated
function BlazorDevExtreme_DxView_Init (element, optionsText) {
	const options = JSON.parse(optionsText);

	let instance = new DevExpress.framework.dxView(element, options);
}
function BlazorDevExtreme_DxView_SetOption (element, key, value) {
	DevExpress.framework.dxView.getInstance(element).option(key, value);
};
function BlazorDevExtreme_DxView_GetOption (element, key) {
	return DevExpress.framework.dxView.getInstance(blazor_element).option(key);
};
// DevExpress.framework.dxLayout interop automatically generated
function BlazorDevExtreme_DxLayout_Init (element, optionsText) {
	const options = JSON.parse(optionsText);

	let instance = new DevExpress.framework.dxLayout(element, options);
}
function BlazorDevExtreme_DxLayout_SetOption (element, key, value) {
	DevExpress.framework.dxLayout.getInstance(element).option(key, value);
};
function BlazorDevExtreme_DxLayout_GetOption (element, key) {
	return DevExpress.framework.dxLayout.getInstance(blazor_element).option(key);
};
// DevExpress.framework.dxViewPlaceholder interop automatically generated
function BlazorDevExtreme_DxViewPlaceholder_Init (element, optionsText) {
	const options = JSON.parse(optionsText);

	let instance = new DevExpress.framework.dxViewPlaceholder(element, options);
}
function BlazorDevExtreme_DxViewPlaceholder_SetOption (element, key, value) {
	DevExpress.framework.dxViewPlaceholder.getInstance(element).option(key, value);
};
function BlazorDevExtreme_DxViewPlaceholder_GetOption (element, key) {
	return DevExpress.framework.dxViewPlaceholder.getInstance(blazor_element).option(key);
};
// DevExpress.framework.dxTransition interop automatically generated
function BlazorDevExtreme_DxTransition_Init (element, optionsText) {
	const options = JSON.parse(optionsText);

	let instance = new DevExpress.framework.dxTransition(element, options);
}
function BlazorDevExtreme_DxTransition_SetOption (element, key, value) {
	DevExpress.framework.dxTransition.getInstance(element).option(key, value);
};
function BlazorDevExtreme_DxTransition_GetOption (element, key) {
	return DevExpress.framework.dxTransition.getInstance(blazor_element).option(key);
};
// DevExpress.framework.dxContentPlaceholder interop automatically generated
function BlazorDevExtreme_DxContentPlaceholder_Init (element, optionsText) {
	const options = JSON.parse(optionsText);

	let instance = new DevExpress.framework.dxContentPlaceholder(element, options);
}
function BlazorDevExtreme_DxContentPlaceholder_SetOption (element, key, value) {
	DevExpress.framework.dxContentPlaceholder.getInstance(element).option(key, value);
};
function BlazorDevExtreme_DxContentPlaceholder_GetOption (element, key) {
	return DevExpress.framework.dxContentPlaceholder.getInstance(blazor_element).option(key);
};
// DevExpress.framework.dxContent interop automatically generated
function BlazorDevExtreme_DxContent_Init (element, optionsText) {
	const options = JSON.parse(optionsText);

	let instance = new DevExpress.framework.dxContent(element, options);
}
function BlazorDevExtreme_DxContent_SetOption (element, key, value) {
	DevExpress.framework.dxContent.getInstance(element).option(key, value);
};
function BlazorDevExtreme_DxContent_GetOption (element, key) {
	return DevExpress.framework.dxContent.getInstance(blazor_element).option(key);
};
// DevExpress.framework.html.HtmlApplication interop automatically generated
function BlazorDevExtreme_HtmlApplication_Init (element, optionsText) {
	const options = JSON.parse(optionsText);

	let instance = new DevExpress.framework.html.HtmlApplication(element, options);
}
function BlazorDevExtreme_HtmlApplication_back_0 (blazor_element) {
	DevExpress.framework.html.HtmlApplication.getInstance(blazor_element).back();
};
function BlazorDevExtreme_HtmlApplication_canBack_1 (blazor_element) {
	return DevExpress.framework.html.HtmlApplication.getInstance(blazor_element).canBack();
};
function BlazorDevExtreme_HtmlApplication_clearState_2 (blazor_element) {
	DevExpress.framework.html.HtmlApplication.getInstance(blazor_element).clearState();
};
function BlazorDevExtreme_HtmlApplication_createNavigation_3 (blazor_element, navigationConfig) {
	DevExpress.framework.html.HtmlApplication.getInstance(blazor_element).createNavigation(navigationConfig);
};
function BlazorDevExtreme_HtmlApplication_getViewTemplate_4 (blazor_element, viewName) {
	return DevExpress.framework.html.HtmlApplication.getInstance(blazor_element).getViewTemplate(viewName);
};
function BlazorDevExtreme_HtmlApplication_getViewTemplateInfo_5 (blazor_element, viewName) {
	return DevExpress.framework.html.HtmlApplication.getInstance(blazor_element).getViewTemplateInfo(viewName);
};
function BlazorDevExtreme_HtmlApplication_loadTemplates_6 (blazor_element, source) {
	return DevExpress.framework.html.HtmlApplication.getInstance(blazor_element).loadTemplates(source);
};
function BlazorDevExtreme_HtmlApplication_navigate_7 (blazor_element, uri) {
	DevExpress.framework.html.HtmlApplication.getInstance(blazor_element).navigate(uri);
};
function BlazorDevExtreme_HtmlApplication_navigate_8 (blazor_element, uri, options) {
	DevExpress.framework.html.HtmlApplication.getInstance(blazor_element).navigate(uri, options);
};
function BlazorDevExtreme_HtmlApplication_off_9 (blazor_element, eventName) {
	return DevExpress.framework.html.HtmlApplication.getInstance(blazor_element).off(eventName);
};
function BlazorDevExtreme_HtmlApplication_off_10 (blazor_element, eventName, eventHandler) {
	return DevExpress.framework.html.HtmlApplication.getInstance(blazor_element).off(eventName, eventHandler);
};
function BlazorDevExtreme_HtmlApplication_on_11 (blazor_element, eventName, eventHandler) {
	return DevExpress.framework.html.HtmlApplication.getInstance(blazor_element).on(eventName, eventHandler);
};
function BlazorDevExtreme_HtmlApplication_on_12 (blazor_element, events) {
	return DevExpress.framework.html.HtmlApplication.getInstance(blazor_element).on(events);
};
function BlazorDevExtreme_HtmlApplication_renderNavigation_13 (blazor_element) {
	DevExpress.framework.html.HtmlApplication.getInstance(blazor_element).renderNavigation();
};
function BlazorDevExtreme_HtmlApplication_restoreState_14 (blazor_element) {
	DevExpress.framework.html.HtmlApplication.getInstance(blazor_element).restoreState();
};
function BlazorDevExtreme_HtmlApplication_saveState_15 (blazor_element) {
	DevExpress.framework.html.HtmlApplication.getInstance(blazor_element).saveState();
};
function BlazorDevExtreme_HtmlApplication_templateContext_16 (blazor_element) {
	return DevExpress.framework.html.HtmlApplication.getInstance(blazor_element).templateContext();
};
function BlazorDevExtreme_HtmlApplication_SetOption (element, key, value) {
	DevExpress.framework.html.HtmlApplication.getInstance(element).option(key, value);
};
function BlazorDevExtreme_HtmlApplication_GetOption (element, key) {
	return DevExpress.framework.html.HtmlApplication.getInstance(blazor_element).option(key);
};
// DevExpress.ui.dxAccordion interop automatically generated
function BlazorDevExtreme_DxAccordion_Init (element, optionsText) {
	const options = JSON.parse(optionsText);

	if (options.onItemTitleClickEnabled) {
		options.onItemTitleClick = function () {
			DotNet.invokeMethodAsync(assemblyName, 'DevExpress.Ui.DxAccordionInterop.OnItemTitleClick', element.id);
			
		}
	}
	let instance = new DevExpress.ui.dxAccordion(element, options);
}
function BlazorDevExtreme_DxAccordion_collapseItem_0 (blazor_element, index) {
	return DevExpress.ui.dxAccordion.getInstance(blazor_element).collapseItem(index);
};
function BlazorDevExtreme_DxAccordion_expandItem_1 (blazor_element, index) {
	return DevExpress.ui.dxAccordion.getInstance(blazor_element).expandItem(index);
};
function BlazorDevExtreme_DxAccordion_updateDimensions_2 (blazor_element) {
	return DevExpress.ui.dxAccordion.getInstance(blazor_element).updateDimensions();
};
function BlazorDevExtreme_DxAccordion_SetOption (element, key, value) {
	DevExpress.ui.dxAccordion.getInstance(element).option(key, value);
};
function BlazorDevExtreme_DxAccordion_GetOption (element, key) {
	return DevExpress.ui.dxAccordion.getInstance(blazor_element).option(key);
};
// DevExpress.ui.dxActionSheet interop automatically generated
function BlazorDevExtreme_DxActionSheet_Init (element, optionsText) {
	const options = JSON.parse(optionsText);

	if (options.onCancelClickEnabled) {
		options.onCancelClick = function () {
			DotNet.invokeMethodAsync(assemblyName, 'DevExpress.Ui.DxActionSheetInterop.OnCancelClick', element.id);
			
		}
	}
	let instance = new DevExpress.ui.dxActionSheet(element, options);
}
function BlazorDevExtreme_DxActionSheet_hide_0 (blazor_element) {
	return DevExpress.ui.dxActionSheet.getInstance(blazor_element).hide();
};
function BlazorDevExtreme_DxActionSheet_show_1 (blazor_element) {
	return DevExpress.ui.dxActionSheet.getInstance(blazor_element).show();
};
function BlazorDevExtreme_DxActionSheet_toggle_2 (blazor_element, showing) {
	return DevExpress.ui.dxActionSheet.getInstance(blazor_element).toggle(showing);
};
function BlazorDevExtreme_DxActionSheet_SetOption (element, key, value) {
	DevExpress.ui.dxActionSheet.getInstance(element).option(key, value);
};
function BlazorDevExtreme_DxActionSheet_GetOption (element, key) {
	return DevExpress.ui.dxActionSheet.getInstance(blazor_element).option(key);
};
// DevExpress.ui.dxAutocomplete interop automatically generated
function BlazorDevExtreme_DxAutocomplete_Init (element, optionsText) {
	const options = JSON.parse(optionsText);

	let instance = new DevExpress.ui.dxAutocomplete(element, options);
}
function BlazorDevExtreme_DxAutocomplete_SetOption (element, key, value) {
	DevExpress.ui.dxAutocomplete.getInstance(element).option(key, value);
};
function BlazorDevExtreme_DxAutocomplete_GetOption (element, key) {
	return DevExpress.ui.dxAutocomplete.getInstance(blazor_element).option(key);
};
// DevExpress.ui.dxBox interop automatically generated
function BlazorDevExtreme_DxBox_Init (element, optionsText) {
	const options = JSON.parse(optionsText);

	let instance = new DevExpress.ui.dxBox(element, options);
}
function BlazorDevExtreme_DxBox_SetOption (element, key, value) {
	DevExpress.ui.dxBox.getInstance(element).option(key, value);
};
function BlazorDevExtreme_DxBox_GetOption (element, key) {
	return DevExpress.ui.dxBox.getInstance(blazor_element).option(key);
};
// DevExpress.ui.dxButton interop automatically generated
function BlazorDevExtreme_DxButton_Init (element, optionsText) {
	const options = JSON.parse(optionsText);

	if (options.onClickEnabled) {
		options.onClick = function () {
			DotNet.invokeMethodAsync(assemblyName, 'DevExpress.Ui.DxButtonInterop.OnClick', element.id);
			
		}
	}
	let instance = new DevExpress.ui.dxButton(element, options);
}
function BlazorDevExtreme_DxButton_SetOption (element, key, value) {
	DevExpress.ui.dxButton.getInstance(element).option(key, value);
};
function BlazorDevExtreme_DxButton_GetOption (element, key) {
	return DevExpress.ui.dxButton.getInstance(blazor_element).option(key);
};
// DevExpress.ui.dxCalendar interop automatically generated
function BlazorDevExtreme_DxCalendar_Init (element, optionsText) {
	const options = JSON.parse(optionsText);

	let instance = new DevExpress.ui.dxCalendar(element, options);
}
function BlazorDevExtreme_DxCalendar_SetOption (element, key, value) {
	DevExpress.ui.dxCalendar.getInstance(element).option(key, value);
};
function BlazorDevExtreme_DxCalendar_GetOption (element, key) {
	return DevExpress.ui.dxCalendar.getInstance(blazor_element).option(key);
};
// DevExpress.ui.dxCheckBox interop automatically generated
function BlazorDevExtreme_DxCheckBox_Init (element, optionsText) {
	const options = JSON.parse(optionsText);

    if (options.onValueChangedEnabled) {
        options.onValueChanged = function () {
            DotNet.invokeMethodAsync(assemblyName, 'DevExpress.Ui.DxCheckBoxInterop.OnValueChanged', element.id, instance.option("value"));

        }
    }

	let instance = new DevExpress.ui.dxCheckBox(element, options);
}
function BlazorDevExtreme_DxCheckBox_SetOption (element, key, value) {
	DevExpress.ui.dxCheckBox.getInstance(element).option(key, value);
};
function BlazorDevExtreme_DxCheckBox_GetOption (element, key) {
	return DevExpress.ui.dxCheckBox.getInstance(blazor_element).option(key);
};
// DevExpress.ui.dxColorBox interop automatically generated
function BlazorDevExtreme_DxColorBox_Init (element, optionsText) {
	const options = JSON.parse(optionsText);

	let instance = new DevExpress.ui.dxColorBox(element, options);
}
function BlazorDevExtreme_DxColorBox_SetOption (element, key, value) {
	DevExpress.ui.dxColorBox.getInstance(element).option(key, value);
};
function BlazorDevExtreme_DxColorBox_GetOption (element, key) {
	return DevExpress.ui.dxColorBox.getInstance(blazor_element).option(key);
};
// DevExpress.ui.dxContextMenu interop automatically generated
function BlazorDevExtreme_DxContextMenu_Init (element, optionsText) {
	const options = JSON.parse(optionsText);

	if (options.onHiddenEnabled) {
		options.onHidden = function () {
			DotNet.invokeMethodAsync(assemblyName, 'DevExpress.Ui.DxContextMenuInterop.OnHidden', element.id);
			
		}
	}
	if (options.onHidingEnabled) {
		options.onHiding = function () {
			DotNet.invokeMethodAsync(assemblyName, 'DevExpress.Ui.DxContextMenuInterop.OnHiding', element.id);
			
		}
	}
	if (options.onPositioningEnabled) {
		options.onPositioning = function () {
			DotNet.invokeMethodAsync(assemblyName, 'DevExpress.Ui.DxContextMenuInterop.OnPositioning', element.id);
			
		}
	}
	if (options.onShowingEnabled) {
		options.onShowing = function () {
			DotNet.invokeMethodAsync(assemblyName, 'DevExpress.Ui.DxContextMenuInterop.OnShowing', element.id);
			
		}
	}
	if (options.onShownEnabled) {
		options.onShown = function () {
			DotNet.invokeMethodAsync(assemblyName, 'DevExpress.Ui.DxContextMenuInterop.OnShown', element.id);
			
		}
	}
	let instance = new DevExpress.ui.dxContextMenu(element, options);
}
function BlazorDevExtreme_DxContextMenu_hide_0 (blazor_element) {
	return DevExpress.ui.dxContextMenu.getInstance(blazor_element).hide();
};
function BlazorDevExtreme_DxContextMenu_show_1 (blazor_element) {
	return DevExpress.ui.dxContextMenu.getInstance(blazor_element).show();
};
function BlazorDevExtreme_DxContextMenu_toggle_2 (blazor_element, showing) {
	return DevExpress.ui.dxContextMenu.getInstance(blazor_element).toggle(showing);
};
function BlazorDevExtreme_DxContextMenu_SetOption (element, key, value) {
	DevExpress.ui.dxContextMenu.getInstance(element).option(key, value);
};
function BlazorDevExtreme_DxContextMenu_GetOption (element, key) {
	return DevExpress.ui.dxContextMenu.getInstance(blazor_element).option(key);
};
// DevExpress.ui.GridBase interop automatically generated
function BlazorDevExtreme_GridBase_Init (element, optionsText) {
	const options = JSON.parse(optionsText);

	if (options.onAdaptiveDetailRowPreparingEnabled) {
		options.onAdaptiveDetailRowPreparing = function () {
			DotNet.invokeMethodAsync(assemblyName, 'DevExpress.Ui.GridBaseInterop.OnAdaptiveDetailRowPreparing', element.id);
			
		}
	}
	if (options.onDataErrorOccurredEnabled) {
		options.onDataErrorOccurred = function () {
			DotNet.invokeMethodAsync(assemblyName, 'DevExpress.Ui.GridBaseInterop.OnDataErrorOccurred', element.id);
			
		}
	}
	if (options.onInitNewRowEnabled) {
		options.onInitNewRow = function () {
			DotNet.invokeMethodAsync(assemblyName, 'DevExpress.Ui.GridBaseInterop.OnInitNewRow', element.id);
			
		}
	}
	if (options.onKeyDownEnabled) {
		options.onKeyDown = function () {
			DotNet.invokeMethodAsync(assemblyName, 'DevExpress.Ui.GridBaseInterop.OnKeyDown', element.id);
			
		}
	}
	if (options.onRowCollapsedEnabled) {
		options.onRowCollapsed = function () {
			DotNet.invokeMethodAsync(assemblyName, 'DevExpress.Ui.GridBaseInterop.OnRowCollapsed', element.id);
			
		}
	}
	if (options.onRowCollapsingEnabled) {
		options.onRowCollapsing = function () {
			DotNet.invokeMethodAsync(assemblyName, 'DevExpress.Ui.GridBaseInterop.OnRowCollapsing', element.id);
			
		}
	}
	if (options.onRowExpandedEnabled) {
		options.onRowExpanded = function () {
			DotNet.invokeMethodAsync(assemblyName, 'DevExpress.Ui.GridBaseInterop.OnRowExpanded', element.id);
			
		}
	}
	if (options.onRowExpandingEnabled) {
		options.onRowExpanding = function () {
			DotNet.invokeMethodAsync(assemblyName, 'DevExpress.Ui.GridBaseInterop.OnRowExpanding', element.id);
			
		}
	}
	if (options.onRowInsertedEnabled) {
		options.onRowInserted = function () {
			DotNet.invokeMethodAsync(assemblyName, 'DevExpress.Ui.GridBaseInterop.OnRowInserted', element.id);
			
		}
	}
	if (options.onRowInsertingEnabled) {
		options.onRowInserting = function () {
			DotNet.invokeMethodAsync(assemblyName, 'DevExpress.Ui.GridBaseInterop.OnRowInserting', element.id);
			
		}
	}
	if (options.onRowRemovedEnabled) {
		options.onRowRemoved = function () {
			DotNet.invokeMethodAsync(assemblyName, 'DevExpress.Ui.GridBaseInterop.OnRowRemoved', element.id);
			
		}
	}
	if (options.onRowRemovingEnabled) {
		options.onRowRemoving = function () {
			DotNet.invokeMethodAsync(assemblyName, 'DevExpress.Ui.GridBaseInterop.OnRowRemoving', element.id);
			
		}
	}
	if (options.onRowUpdatedEnabled) {
		options.onRowUpdated = function () {
			DotNet.invokeMethodAsync(assemblyName, 'DevExpress.Ui.GridBaseInterop.OnRowUpdated', element.id);
			
		}
	}
	if (options.onRowUpdatingEnabled) {
		options.onRowUpdating = function () {
			DotNet.invokeMethodAsync(assemblyName, 'DevExpress.Ui.GridBaseInterop.OnRowUpdating', element.id);
			
		}
	}
	if (options.onRowValidatingEnabled) {
		options.onRowValidating = function () {
			DotNet.invokeMethodAsync(assemblyName, 'DevExpress.Ui.GridBaseInterop.OnRowValidating', element.id);
			
		}
	}
	if (options.onSelectionChangedEnabled) {
		options.onSelectionChanged = function () {
			DotNet.invokeMethodAsync(assemblyName, 'DevExpress.Ui.GridBaseInterop.OnSelectionChanged', element.id);
			
		}
	}
	if (options.onToolbarPreparingEnabled) {
		options.onToolbarPreparing = function () {
			DotNet.invokeMethodAsync(assemblyName, 'DevExpress.Ui.GridBaseInterop.OnToolbarPreparing', element.id);
			
		}
	}
	let instance = new DevExpress.ui.GridBase(element, options);
}
function BlazorDevExtreme_GridBase_beginCustomLoading_0 (blazor_element, messageText) {
	DevExpress.ui.GridBase.getInstance(blazor_element).beginCustomLoading(messageText);
};
function BlazorDevExtreme_GridBase_byKey_1 (blazor_element, key) {
	return DevExpress.ui.GridBase.getInstance(blazor_element).byKey(key);
};
function BlazorDevExtreme_GridBase_cancelEditData_2 (blazor_element) {
	DevExpress.ui.GridBase.getInstance(blazor_element).cancelEditData();
};
function BlazorDevExtreme_GridBase_cellValue_3 (blazor_element, rowIndex, dataField) {
	return DevExpress.ui.GridBase.getInstance(blazor_element).cellValue(rowIndex, dataField);
};
function BlazorDevExtreme_GridBase_cellValue_4 (blazor_element, rowIndex, dataField, value) {
	DevExpress.ui.GridBase.getInstance(blazor_element).cellValue(rowIndex, dataField, value);
};
function BlazorDevExtreme_GridBase_cellValue_5 (blazor_element, rowIndex, visibleColumnIndex) {
	return DevExpress.ui.GridBase.getInstance(blazor_element).cellValue(rowIndex, visibleColumnIndex);
};
function BlazorDevExtreme_GridBase_cellValue_6 (blazor_element, rowIndex, visibleColumnIndex, value) {
	DevExpress.ui.GridBase.getInstance(blazor_element).cellValue(rowIndex, visibleColumnIndex, value);
};
function BlazorDevExtreme_GridBase_clearFilter_7 (blazor_element) {
	DevExpress.ui.GridBase.getInstance(blazor_element).clearFilter();
};
function BlazorDevExtreme_GridBase_clearFilter_8 (blazor_element, filterName) {
	DevExpress.ui.GridBase.getInstance(blazor_element).clearFilter(filterName);
};
function BlazorDevExtreme_GridBase_clearSelection_9 (blazor_element) {
	DevExpress.ui.GridBase.getInstance(blazor_element).clearSelection();
};
function BlazorDevExtreme_GridBase_clearSorting_10 (blazor_element) {
	DevExpress.ui.GridBase.getInstance(blazor_element).clearSorting();
};
function BlazorDevExtreme_GridBase_closeEditCell_11 (blazor_element) {
	DevExpress.ui.GridBase.getInstance(blazor_element).closeEditCell();
};
function BlazorDevExtreme_GridBase_collapseAdaptiveDetailRow_12 (blazor_element) {
	DevExpress.ui.GridBase.getInstance(blazor_element).collapseAdaptiveDetailRow();
};
function BlazorDevExtreme_GridBase_columnCount_13 (blazor_element) {
	return DevExpress.ui.GridBase.getInstance(blazor_element).columnCount();
};
function BlazorDevExtreme_GridBase_columnOption_14 (blazor_element, id) {
	return DevExpress.ui.GridBase.getInstance(blazor_element).columnOption(id);
};
function BlazorDevExtreme_GridBase_columnOption_15 (blazor_element, id, optionName) {
	return DevExpress.ui.GridBase.getInstance(blazor_element).columnOption(id, optionName);
};
function BlazorDevExtreme_GridBase_columnOption_16 (blazor_element, id, optionName, optionValue) {
	DevExpress.ui.GridBase.getInstance(blazor_element).columnOption(id, optionName, optionValue);
};
function BlazorDevExtreme_GridBase_columnOption_17 (blazor_element, id, options) {
	DevExpress.ui.GridBase.getInstance(blazor_element).columnOption(id, options);
};
function BlazorDevExtreme_GridBase_deleteColumn_18 (blazor_element, id) {
	DevExpress.ui.GridBase.getInstance(blazor_element).deleteColumn(id);
};
function BlazorDevExtreme_GridBase_deleteRow_19 (blazor_element, rowIndex) {
	DevExpress.ui.GridBase.getInstance(blazor_element).deleteRow(rowIndex);
};
function BlazorDevExtreme_GridBase_deselectAll_20 (blazor_element) {
	return DevExpress.ui.GridBase.getInstance(blazor_element).deselectAll();
};
function BlazorDevExtreme_GridBase_deselectRows_21 (blazor_element, keys) {
	return DevExpress.ui.GridBase.getInstance(blazor_element).deselectRows(keys);
};
function BlazorDevExtreme_GridBase_editCell_22 (blazor_element, rowIndex, dataField) {
	DevExpress.ui.GridBase.getInstance(blazor_element).editCell(rowIndex, dataField);
};
function BlazorDevExtreme_GridBase_editCell_23 (blazor_element, rowIndex, visibleColumnIndex) {
	DevExpress.ui.GridBase.getInstance(blazor_element).editCell(rowIndex, visibleColumnIndex);
};
function BlazorDevExtreme_GridBase_editRow_24 (blazor_element, rowIndex) {
	DevExpress.ui.GridBase.getInstance(blazor_element).editRow(rowIndex);
};
function BlazorDevExtreme_GridBase_endCustomLoading_25 (blazor_element) {
	DevExpress.ui.GridBase.getInstance(blazor_element).endCustomLoading();
};
function BlazorDevExtreme_GridBase_expandAdaptiveDetailRow_26 (blazor_element, key) {
	DevExpress.ui.GridBase.getInstance(blazor_element).expandAdaptiveDetailRow(key);
};
function BlazorDevExtreme_GridBase_filter_27 (blazor_element) {
	return DevExpress.ui.GridBase.getInstance(blazor_element).filter();
};
function BlazorDevExtreme_GridBase_filter_28 (blazor_element, filterExpr) {
	DevExpress.ui.GridBase.getInstance(blazor_element).filter(filterExpr);
};
function BlazorDevExtreme_GridBase_focus_29 (blazor_element) {
	DevExpress.ui.GridBase.getInstance(blazor_element).focus();
};
function BlazorDevExtreme_GridBase_focus_30 (blazor_element, element) {
	DevExpress.ui.GridBase.getInstance(blazor_element).focus(element);
};
function BlazorDevExtreme_GridBase_getCellElement_31 (blazor_element, rowIndex, dataField) {
	return DevExpress.ui.GridBase.getInstance(blazor_element).getCellElement(rowIndex, dataField);
};
function BlazorDevExtreme_GridBase_getCellElement_32 (blazor_element, rowIndex, visibleColumnIndex) {
	return DevExpress.ui.GridBase.getInstance(blazor_element).getCellElement(rowIndex, visibleColumnIndex);
};
function BlazorDevExtreme_GridBase_getCombinedFilter_33 (blazor_element) {
	return DevExpress.ui.GridBase.getInstance(blazor_element).getCombinedFilter();
};
function BlazorDevExtreme_GridBase_getCombinedFilter_34 (blazor_element, returnDataField) {
	return DevExpress.ui.GridBase.getInstance(blazor_element).getCombinedFilter(returnDataField);
};
function BlazorDevExtreme_GridBase_getDataSource_35 (blazor_element) {
	return DevExpress.ui.GridBase.getInstance(blazor_element).getDataSource();
};
function BlazorDevExtreme_GridBase_getKeyByRowIndex_36 (blazor_element, rowIndex) {
	return DevExpress.ui.GridBase.getInstance(blazor_element).getKeyByRowIndex(rowIndex);
};
function BlazorDevExtreme_GridBase_getRowElement_37 (blazor_element, rowIndex) {
	return DevExpress.ui.GridBase.getInstance(blazor_element).getRowElement(rowIndex);
};
function BlazorDevExtreme_GridBase_getRowIndexByKey_38 (blazor_element, key) {
	return DevExpress.ui.GridBase.getInstance(blazor_element).getRowIndexByKey(key);
};
function BlazorDevExtreme_GridBase_getScrollable_39 (blazor_element) {
	return DevExpress.ui.GridBase.getInstance(blazor_element).getScrollable();
};
function BlazorDevExtreme_GridBase_hasEditData_40 (blazor_element) {
	return DevExpress.ui.GridBase.getInstance(blazor_element).hasEditData();
};
function BlazorDevExtreme_GridBase_hideColumnChooser_41 (blazor_element) {
	DevExpress.ui.GridBase.getInstance(blazor_element).hideColumnChooser();
};
function BlazorDevExtreme_GridBase_isAdaptiveDetailRowExpanded_42 (blazor_element, key) {
	DevExpress.ui.GridBase.getInstance(blazor_element).isAdaptiveDetailRowExpanded(key);
};
function BlazorDevExtreme_GridBase_isRowSelected_43 (blazor_element, key) {
	return DevExpress.ui.GridBase.getInstance(blazor_element).isRowSelected(key);
};
function BlazorDevExtreme_GridBase_keyOf_44 (blazor_element, obj) {
	return DevExpress.ui.GridBase.getInstance(blazor_element).keyOf(obj);
};
function BlazorDevExtreme_GridBase_pageCount_45 (blazor_element) {
	return DevExpress.ui.GridBase.getInstance(blazor_element).pageCount();
};
function BlazorDevExtreme_GridBase_pageIndex_46 (blazor_element) {
	return DevExpress.ui.GridBase.getInstance(blazor_element).pageIndex();
};
function BlazorDevExtreme_GridBase_pageIndex_47 (blazor_element, newIndex) {
	return DevExpress.ui.GridBase.getInstance(blazor_element).pageIndex(newIndex);
};
function BlazorDevExtreme_GridBase_pageSize_48 (blazor_element) {
	return DevExpress.ui.GridBase.getInstance(blazor_element).pageSize();
};
function BlazorDevExtreme_GridBase_pageSize_49 (blazor_element, value) {
	DevExpress.ui.GridBase.getInstance(blazor_element).pageSize(value);
};
function BlazorDevExtreme_GridBase_refresh_50 (blazor_element) {
	return DevExpress.ui.GridBase.getInstance(blazor_element).refresh();
};
function BlazorDevExtreme_GridBase_repaintRows_51 (blazor_element, rowIndexes) {
	DevExpress.ui.GridBase.getInstance(blazor_element).repaintRows(rowIndexes);
};
function BlazorDevExtreme_GridBase_saveEditData_52 (blazor_element) {
	return DevExpress.ui.GridBase.getInstance(blazor_element).saveEditData();
};
function BlazorDevExtreme_GridBase_searchByText_53 (blazor_element, text) {
	DevExpress.ui.GridBase.getInstance(blazor_element).searchByText(text);
};
function BlazorDevExtreme_GridBase_selectAll_54 (blazor_element) {
	return DevExpress.ui.GridBase.getInstance(blazor_element).selectAll();
};
function BlazorDevExtreme_GridBase_selectRows_55 (blazor_element, keys, preserve) {
	return DevExpress.ui.GridBase.getInstance(blazor_element).selectRows(keys, preserve);
};
function BlazorDevExtreme_GridBase_selectRowsByIndexes_56 (blazor_element, indexes) {
	return DevExpress.ui.GridBase.getInstance(blazor_element).selectRowsByIndexes(indexes);
};
function BlazorDevExtreme_GridBase_showColumnChooser_57 (blazor_element) {
	DevExpress.ui.GridBase.getInstance(blazor_element).showColumnChooser();
};
function BlazorDevExtreme_GridBase_state_58 (blazor_element) {
	return DevExpress.ui.GridBase.getInstance(blazor_element).state();
};
function BlazorDevExtreme_GridBase_state_59 (blazor_element, state) {
	DevExpress.ui.GridBase.getInstance(blazor_element).state(state);
};
function BlazorDevExtreme_GridBase_undeleteRow_60 (blazor_element, rowIndex) {
	DevExpress.ui.GridBase.getInstance(blazor_element).undeleteRow(rowIndex);
};
function BlazorDevExtreme_GridBase_updateDimensions_61 (blazor_element) {
	DevExpress.ui.GridBase.getInstance(blazor_element).updateDimensions();
};
function BlazorDevExtreme_DxDataGrid_updateDimensions(blazor_element) {
    DevExpress.ui.dxDataGrid.getInstance(blazor_element).updateDimensions();
};
function BlazorDevExtreme_GridBase_SetOption (element, key, value) {

    DevExpress.ui.GridBase.getInstance(element).option(key, value);
};
function BlazorDevExtreme_GridBase_GetOption (element, key) {
	return DevExpress.ui.GridBase.getInstance(blazor_element).option(key);
};
// DevExpress.ui.dxDataGrid interop automatically generated
function BlazorDevExtreme_DxDataGrid_Init (element, optionsText) {
	const options = JSON.parse(optionsText);

	if (options.onContentReadyEnabled) {
		options.onContentReady = function () {
			DotNet.invokeMethodAsync(assemblyName, 'DevExpress.Ui.WidgetInterop.OnContentReady', element.id);

		}
	}

	if (options.onInitializedEnabled) {
		options.onInitialized = function () {
			DotNet.invokeMethodAsync(assemblyName, 'DevExpress.ComponentInterop.OnInitialized', element.id);

		}
	}

	if (options.onCellClickEnabled) {
		options.onCellClick = function () {
			DotNet.invokeMethodAsync(assemblyName, 'DevExpress.Ui.DxDataGridInterop.OnCellClick', element.id);
			
		}
	}
	if (options.onCellHoverChangedEnabled) {
		options.onCellHoverChanged = function () {
			DotNet.invokeMethodAsync(assemblyName, 'DevExpress.Ui.DxDataGridInterop.OnCellHoverChanged', element.id);
			
		}
	}
	if (options.onCellPreparedEnabled) {
		options.onCellPrepared = function () {
			DotNet.invokeMethodAsync(assemblyName, 'DevExpress.Ui.DxDataGridInterop.OnCellPrepared', element.id);
			
		}
	}
	if (options.onContextMenuPreparingEnabled) {
		options.onContextMenuPreparing = function () {
			DotNet.invokeMethodAsync(assemblyName, 'DevExpress.Ui.DxDataGridInterop.OnContextMenuPreparing', element.id);
			
		}
	}
	if (options.onEditingStartEnabled) {
		options.onEditingStart = function () {
			DotNet.invokeMethodAsync(assemblyName, 'DevExpress.Ui.DxDataGridInterop.OnEditingStart', element.id);
			
		}
	}
	if (options.onEditorPreparedEnabled) {
		options.onEditorPrepared = function () {
			DotNet.invokeMethodAsync(assemblyName, 'DevExpress.Ui.DxDataGridInterop.OnEditorPrepared', element.id);
			
		}
	}
	if (options.onEditorPreparingEnabled) {
		options.onEditorPreparing = function () {
			DotNet.invokeMethodAsync(assemblyName, 'DevExpress.Ui.DxDataGridInterop.OnEditorPreparing', element.id);
			
		}
	}
	if (options.onExportedEnabled) {
		options.onExported = function () {
			DotNet.invokeMethodAsync(assemblyName, 'DevExpress.Ui.DxDataGridInterop.OnExported', element.id);
			
		}
	}
	if (options.onExportingEnabled) {
		options.onExporting = function () {
			DotNet.invokeMethodAsync(assemblyName, 'DevExpress.Ui.DxDataGridInterop.OnExporting', element.id);
			
		}
	}
	if (options.onFileSavingEnabled) {
		options.onFileSaving = function () {
			DotNet.invokeMethodAsync(assemblyName, 'DevExpress.Ui.DxDataGridInterop.OnFileSaving', element.id);
			
		}
	}
	if (options.onRowClickEnabled) {
		options.onRowClick = function () {
			DotNet.invokeMethodAsync(assemblyName, 'DevExpress.Ui.DxDataGridInterop.OnRowClick', element.id);
			
		}
	}
	if (options.onRowPreparedEnabled) {
		options.onRowPrepared = function () {
			DotNet.invokeMethodAsync(assemblyName, 'DevExpress.Ui.DxDataGridInterop.OnRowPrepared', element.id);
			
		}
	}
	let instance = new DevExpress.ui.dxDataGrid(element, options);
}
function BlazorDevExtreme_DxDataGrid_addColumn_0 (blazor_element, columnOptions) {
	DevExpress.ui.dxDataGrid.getInstance(blazor_element).addColumn(columnOptions);
};
function BlazorDevExtreme_DxDataGrid_addRow_1 (blazor_element) {
	DevExpress.ui.dxDataGrid.getInstance(blazor_element).addRow();
};
function BlazorDevExtreme_DxDataGrid_clearGrouping_2 (blazor_element) {
	DevExpress.ui.dxDataGrid.getInstance(blazor_element).clearGrouping();
};
function BlazorDevExtreme_DxDataGrid_collapseAll_3 (blazor_element, groupIndex) {
	DevExpress.ui.dxDataGrid.getInstance(blazor_element).collapseAll(groupIndex);
};
function BlazorDevExtreme_DxDataGrid_collapseRow_4 (blazor_element, key) {
	return DevExpress.ui.dxDataGrid.getInstance(blazor_element).collapseRow(key);
};
function BlazorDevExtreme_DxDataGrid_expandAll_5 (blazor_element, groupIndex) {
	DevExpress.ui.dxDataGrid.getInstance(blazor_element).expandAll(groupIndex);
};
function BlazorDevExtreme_DxDataGrid_expandRow_6 (blazor_element, key) {
	return DevExpress.ui.dxDataGrid.getInstance(blazor_element).expandRow(key);
};
function BlazorDevExtreme_DxDataGrid_exportToExcel_7 (blazor_element, selectionOnly) {
	DevExpress.ui.dxDataGrid.getInstance(blazor_element).exportToExcel(selectionOnly);
};
function BlazorDevExtreme_DxDataGrid_getSelectedRowKeys_8 (blazor_element) {
	return DevExpress.ui.dxDataGrid.getInstance(blazor_element).getSelectedRowKeys();
};
function BlazorDevExtreme_DxDataGrid_getSelectedRowsData_9 (blazor_element) {
	return DevExpress.ui.dxDataGrid.getInstance(blazor_element).getSelectedRowsData();
};
function BlazorDevExtreme_DxDataGrid_getTotalSummaryValue_10 (blazor_element, summaryItemName) {
	return DevExpress.ui.dxDataGrid.getInstance(blazor_element).getTotalSummaryValue(summaryItemName);
};
function BlazorDevExtreme_DxDataGrid_getVisibleColumns_11 (blazor_element) {
	return DevExpress.ui.dxDataGrid.getInstance(blazor_element).getVisibleColumns();
};
function BlazorDevExtreme_DxDataGrid_getVisibleColumns_12 (blazor_element, headerLevel) {
	return DevExpress.ui.dxDataGrid.getInstance(blazor_element).getVisibleColumns(headerLevel);
};
function BlazorDevExtreme_DxDataGrid_getVisibleRows_13 (blazor_element) {
	return DevExpress.ui.dxDataGrid.getInstance(blazor_element).getVisibleRows();
};
function BlazorDevExtreme_DxDataGrid_insertRow_14 (blazor_element) {
	DevExpress.ui.dxDataGrid.getInstance(blazor_element).insertRow();
};
function BlazorDevExtreme_DxDataGrid_isRowExpanded_15 (blazor_element, key) {
	return DevExpress.ui.dxDataGrid.getInstance(blazor_element).isRowExpanded(key);
};
function BlazorDevExtreme_DxDataGrid_isRowSelected_16 (blazor_element, data) {
	return DevExpress.ui.dxDataGrid.getInstance(blazor_element).isRowSelected(data);
};
function BlazorDevExtreme_DxDataGrid_isRowSelected_17 (blazor_element, key) {
	return DevExpress.ui.dxDataGrid.getInstance(blazor_element).isRowSelected(key);
};
function BlazorDevExtreme_DxDataGrid_removeRow_18 (blazor_element, rowIndex) {
	DevExpress.ui.dxDataGrid.getInstance(blazor_element).removeRow(rowIndex);
};
function BlazorDevExtreme_DxDataGrid_totalCount_19 (blazor_element) {
	return DevExpress.ui.dxDataGrid.getInstance(blazor_element).totalCount();
};
function BlazorDevExtreme_DxDataGrid_SetOption (element, key, value) {
    const option = JSON.parse(value);
    DevExpress.ui.dxDataGrid.getInstance(element).option(key, option);
};
function BlazorDevExtreme_DxDataGrid_GetOption (element, key) {
	return DevExpress.ui.dxDataGrid.getInstance(blazor_element).option(key);
};
// DevExpress.ui.dxDateBox interop automatically generated
function BlazorDevExtreme_DxDateBox_Init (element, optionsText) {
	const options = JSON.parse(optionsText);

    if (options.onValueChangedEnabled) {
        options.onValueChanged = function () {
            DotNet.invokeMethodAsync(assemblyName, 'DevExpress.Ui.EditorInterop.OnValueChanged', element.id, instance.option("value"));

        }
    }

	let instance = new DevExpress.ui.dxDateBox(element, options);
}
function BlazorDevExtreme_DxDateBox_close_0 (blazor_element) {
	DevExpress.ui.dxDateBox.getInstance(blazor_element).close();
};
function BlazorDevExtreme_DxDateBox_open_1 (blazor_element) {
	DevExpress.ui.dxDateBox.getInstance(blazor_element).open();
};
function BlazorDevExtreme_DxDateBox_SetOption (element, key, value) {
	DevExpress.ui.dxDateBox.getInstance(element).option(key, value);
};
function BlazorDevExtreme_DxDateBox_GetOption (element, key) {
	return DevExpress.ui.dxDateBox.getInstance(blazor_element).option(key);
};
// DevExpress.ui.dxDeferRendering interop automatically generated
function BlazorDevExtreme_DxDeferRendering_Init (element, optionsText) {
	const options = JSON.parse(optionsText);

	if (options.onRenderedEnabled) {
		options.onRendered = function () {
			DotNet.invokeMethodAsync(assemblyName, 'DevExpress.Ui.DxDeferRenderingInterop.OnRendered', element.id);
			
		}
	}
	if (options.onShownEnabled) {
		options.onShown = function () {
			DotNet.invokeMethodAsync(assemblyName, 'DevExpress.Ui.DxDeferRenderingInterop.OnShown', element.id);
			
		}
	}
	let instance = new DevExpress.ui.dxDeferRendering(element, options);
}
function BlazorDevExtreme_DxDeferRendering_SetOption (element, key, value) {
	DevExpress.ui.dxDeferRendering.getInstance(element).option(key, value);
};
function BlazorDevExtreme_DxDeferRendering_GetOption (element, key) {
	return DevExpress.ui.dxDeferRendering.getInstance(blazor_element).option(key);
};
// DevExpress.ui.dxDropDownBox interop automatically generated
function BlazorDevExtreme_DxDropDownBox_Init (element, optionsText) {
	const options = JSON.parse(optionsText);

	let instance = new DevExpress.ui.dxDropDownBox(element, options);
}
function BlazorDevExtreme_DxDropDownBox_getDataSource_0 (blazor_element) {
	return DevExpress.ui.dxDropDownBox.getInstance(blazor_element).getDataSource();
};
function BlazorDevExtreme_DxDropDownBox_SetOption (element, key, value) {
	DevExpress.ui.dxDropDownBox.getInstance(element).option(key, value);
};
function BlazorDevExtreme_DxDropDownBox_GetOption (element, key) {
	return DevExpress.ui.dxDropDownBox.getInstance(blazor_element).option(key);
};
// DevExpress.ui.dxDropDownMenu interop automatically generated
function BlazorDevExtreme_DxDropDownMenu_Init (element, optionsText) {
	const options = JSON.parse(optionsText);

	if (options.onButtonClickEnabled) {
		options.onButtonClick = function () {
			DotNet.invokeMethodAsync(assemblyName, 'DevExpress.Ui.DxDropDownMenuInterop.OnButtonClick', element.id);
			
		}
	}
	if (options.onItemClickEnabled) {
		options.onItemClick = function () {
			DotNet.invokeMethodAsync(assemblyName, 'DevExpress.Ui.DxDropDownMenuInterop.OnItemClick', element.id);
			
		}
	}
	let instance = new DevExpress.ui.dxDropDownMenu(element, options);
}
function BlazorDevExtreme_DxDropDownMenu_close_0 (blazor_element) {
	DevExpress.ui.dxDropDownMenu.getInstance(blazor_element).close();
};
function BlazorDevExtreme_DxDropDownMenu_open_1 (blazor_element) {
	DevExpress.ui.dxDropDownMenu.getInstance(blazor_element).open();
};
function BlazorDevExtreme_DxDropDownMenu_SetOption (element, key, value) {
	DevExpress.ui.dxDropDownMenu.getInstance(element).option(key, value);
};
function BlazorDevExtreme_DxDropDownMenu_GetOption (element, key) {
	return DevExpress.ui.dxDropDownMenu.getInstance(blazor_element).option(key);
};
// DevExpress.ui.dxFileUploader interop automatically generated
function BlazorDevExtreme_DxFileUploader_Init (element, optionsText) {
	const options = JSON.parse(optionsText);

	if (options.onProgressEnabled) {
		options.onProgress = function () {
			DotNet.invokeMethodAsync(assemblyName, 'DevExpress.Ui.DxFileUploaderInterop.OnProgress', element.id);
			
		}
	}
	if (options.onUploadAbortedEnabled) {
		options.onUploadAborted = function () {
			DotNet.invokeMethodAsync(assemblyName, 'DevExpress.Ui.DxFileUploaderInterop.OnUploadAborted', element.id);
			
		}
	}
	if (options.onUploadedEnabled) {
		options.onUploaded = function () {
			DotNet.invokeMethodAsync(assemblyName, 'DevExpress.Ui.DxFileUploaderInterop.OnUploaded', element.id);
			
		}
	}
	if (options.onUploadErrorEnabled) {
		options.onUploadError = function () {
			DotNet.invokeMethodAsync(assemblyName, 'DevExpress.Ui.DxFileUploaderInterop.OnUploadError', element.id);
			
		}
	}
	if (options.onUploadStartedEnabled) {
		options.onUploadStarted = function () {
			DotNet.invokeMethodAsync(assemblyName, 'DevExpress.Ui.DxFileUploaderInterop.OnUploadStarted', element.id);
			
		}
	}
	if (options.onValueChangedEnabled) {
		options.onValueChanged = function () {
            DotNet.invokeMethodAsync(assemblyName, 'DevExpress.Ui.EditorInterop.OnValueChanged', element.id);
			
		}
	}
	let instance = new DevExpress.ui.dxFileUploader(element, options);
}
function BlazorDevExtreme_DxFileUploader_SetOption (element, key, value) {
	DevExpress.ui.dxFileUploader.getInstance(element).option(key, value);
};
function BlazorDevExtreme_DxFileUploader_GetOption (element, key) {
	return DevExpress.ui.dxFileUploader.getInstance(blazor_element).option(key);
};
// DevExpress.ui.dxFilterBuilder interop automatically generated
function BlazorDevExtreme_DxFilterBuilder_Init (element, optionsText) {
	const options = JSON.parse(optionsText);

	if (options.onEditorPreparedEnabled) {
		options.onEditorPrepared = function () {
			DotNet.invokeMethodAsync(assemblyName, 'DevExpress.Ui.DxFilterBuilderInterop.OnEditorPrepared', element.id);
			
		}
	}
	if (options.onEditorPreparingEnabled) {
		options.onEditorPreparing = function () {
			DotNet.invokeMethodAsync(assemblyName, 'DevExpress.Ui.DxFilterBuilderInterop.OnEditorPreparing', element.id);
			
		}
	}
	if (options.onValueChangedEnabled) {
		options.onValueChanged = function () {
			DotNet.invokeMethodAsync(assemblyName, 'DevExpress.Ui.DxFilterBuilderInterop.OnValueChanged', element.id);
			
		}
	}
	let instance = new DevExpress.ui.dxFilterBuilder(element, options);
}
function BlazorDevExtreme_DxFilterBuilder_getFilterExpression_0 (blazor_element) {
	return DevExpress.ui.dxFilterBuilder.getInstance(blazor_element).getFilterExpression();
};
function BlazorDevExtreme_DxFilterBuilder_SetOption (element, key, value) {
	DevExpress.ui.dxFilterBuilder.getInstance(element).option(key, value);
};
function BlazorDevExtreme_DxFilterBuilder_GetOption (element, key) {
	return DevExpress.ui.dxFilterBuilder.getInstance(blazor_element).option(key);
};
// DevExpress.ui.dxForm interop automatically generated
function BlazorDevExtreme_DxForm_Init (element, optionsText) {
	const options = JSON.parse(optionsText);

	if (options.onEditorEnterKeyEnabled) {
		options.onEditorEnterKey = function () {
			DotNet.invokeMethodAsync(assemblyName, 'DevExpress.Ui.DxFormInterop.OnEditorEnterKey', element.id);
			
		}
	}
	if (options.onFieldDataChangedEnabled) {
		options.onFieldDataChanged = function () {
			DotNet.invokeMethodAsync(assemblyName, 'DevExpress.Ui.DxFormInterop.OnFieldDataChanged', element.id);
			
		}
	}
	let instance = new DevExpress.ui.dxForm(element, options);
}
function BlazorDevExtreme_DxForm_getEditor_0 (blazor_element, dataField) {
	return DevExpress.ui.dxForm.getInstance(blazor_element).getEditor(dataField);
};
function BlazorDevExtreme_DxForm_itemOption_1 (blazor_element, id) {
	return DevExpress.ui.dxForm.getInstance(blazor_element).itemOption(id);
};
function BlazorDevExtreme_DxForm_itemOption_2 (blazor_element, id, option, value) {
	DevExpress.ui.dxForm.getInstance(blazor_element).itemOption(id, option, value);
};
function BlazorDevExtreme_DxForm_itemOption_3 (blazor_element, id, options) {
	DevExpress.ui.dxForm.getInstance(blazor_element).itemOption(id, options);
};
function BlazorDevExtreme_DxForm_resetValues_4 (blazor_element) {
	DevExpress.ui.dxForm.getInstance(blazor_element).resetValues();
};
function BlazorDevExtreme_DxForm_updateData_5 (blazor_element, data) {
	DevExpress.ui.dxForm.getInstance(blazor_element).updateData(data);
};
function BlazorDevExtreme_DxForm_updateData_6 (blazor_element, dataField, value) {
	DevExpress.ui.dxForm.getInstance(blazor_element).updateData(dataField, value);
};
function BlazorDevExtreme_DxForm_updateDimensions_7 (blazor_element) {
	return DevExpress.ui.dxForm.getInstance(blazor_element).updateDimensions();
};
function BlazorDevExtreme_DxForm_validate_8 (blazor_element) {
	return DevExpress.ui.dxForm.getInstance(blazor_element).validate();
};
function BlazorDevExtreme_DxForm_SetOption (element, key, value) {
	DevExpress.ui.dxForm.getInstance(element).option(key, value);
};
function BlazorDevExtreme_DxForm_GetOption (element, key) {
	return DevExpress.ui.dxForm.getInstance(blazor_element).option(key);
};
// DevExpress.ui.dxGallery interop automatically generated
function BlazorDevExtreme_DxGallery_Init (element, optionsText) {
	const options = JSON.parse(optionsText);

	let instance = new DevExpress.ui.dxGallery(element, options);
}
function BlazorDevExtreme_DxGallery_goToItem_0 (blazor_element, itemIndex, animation) {
	return DevExpress.ui.dxGallery.getInstance(blazor_element).goToItem(itemIndex, animation);
};
function BlazorDevExtreme_DxGallery_nextItem_1 (blazor_element, animation) {
	return DevExpress.ui.dxGallery.getInstance(blazor_element).nextItem(animation);
};
function BlazorDevExtreme_DxGallery_prevItem_2 (blazor_element, animation) {
	return DevExpress.ui.dxGallery.getInstance(blazor_element).prevItem(animation);
};
function BlazorDevExtreme_DxGallery_SetOption (element, key, value) {
	DevExpress.ui.dxGallery.getInstance(element).option(key, value);
};
function BlazorDevExtreme_DxGallery_GetOption (element, key) {
	return DevExpress.ui.dxGallery.getInstance(blazor_element).option(key);
};
// DevExpress.ui.dxList interop automatically generated
function BlazorDevExtreme_DxList_Init (element, optionsText) {
	const options = JSON.parse(optionsText);

	if (options.onGroupRenderedEnabled) {
		options.onGroupRendered = function () {
			DotNet.invokeMethodAsync(assemblyName, 'DevExpress.Ui.DxListInterop.OnGroupRendered', element.id);
			
		}
	}
	if (options.onItemClickEnabled) {
		options.onItemClick = function () {
			DotNet.invokeMethodAsync(assemblyName, 'DevExpress.Ui.DxListInterop.OnItemClick', element.id);
			
		}
	}
	if (options.onItemContextMenuEnabled) {
		options.onItemContextMenu = function () {
			DotNet.invokeMethodAsync(assemblyName, 'DevExpress.Ui.DxListInterop.OnItemContextMenu', element.id);
			
		}
	}
	if (options.onItemDeletedEnabled) {
		options.onItemDeleted = function () {
			DotNet.invokeMethodAsync(assemblyName, 'DevExpress.Ui.DxListInterop.OnItemDeleted', element.id);
			
		}
	}
	if (options.onItemDeletingEnabled) {
		options.onItemDeleting = function () {
			DotNet.invokeMethodAsync(assemblyName, 'DevExpress.Ui.DxListInterop.OnItemDeleting', element.id);
			
		}
	}
	if (options.onItemHoldEnabled) {
		options.onItemHold = function () {
			DotNet.invokeMethodAsync(assemblyName, 'DevExpress.Ui.DxListInterop.OnItemHold', element.id);
			
		}
	}
	if (options.onItemReorderedEnabled) {
		options.onItemReordered = function () {
			DotNet.invokeMethodAsync(assemblyName, 'DevExpress.Ui.DxListInterop.OnItemReordered', element.id);
			
		}
	}
	if (options.onItemSwipeEnabled) {
		options.onItemSwipe = function () {
			DotNet.invokeMethodAsync(assemblyName, 'DevExpress.Ui.DxListInterop.OnItemSwipe', element.id);
			
		}
	}
	if (options.onPageLoadingEnabled) {
		options.onPageLoading = function () {
			DotNet.invokeMethodAsync(assemblyName, 'DevExpress.Ui.DxListInterop.OnPageLoading', element.id);
			
		}
	}
	if (options.onPullRefreshEnabled) {
		options.onPullRefresh = function () {
			DotNet.invokeMethodAsync(assemblyName, 'DevExpress.Ui.DxListInterop.OnPullRefresh', element.id);
			
		}
	}
	if (options.onScrollEnabled) {
		options.onScroll = function () {
			DotNet.invokeMethodAsync(assemblyName, 'DevExpress.Ui.DxListInterop.OnScroll', element.id);
			
		}
	}
	if (options.onSelectAllValueChangedEnabled) {
		options.onSelectAllValueChanged = function () {
			DotNet.invokeMethodAsync(assemblyName, 'DevExpress.Ui.DxListInterop.OnSelectAllValueChanged', element.id);
			
		}
	}
	let instance = new DevExpress.ui.dxList(element, options);
}
function BlazorDevExtreme_DxList_clientHeight_0 (blazor_element) {
	return DevExpress.ui.dxList.getInstance(blazor_element).clientHeight();
};
function BlazorDevExtreme_DxList_collapseGroup_1 (blazor_element, groupIndex) {
	return DevExpress.ui.dxList.getInstance(blazor_element).collapseGroup(groupIndex);
};
function BlazorDevExtreme_DxList_deleteItem_2 (blazor_element, itemElement) {
	return DevExpress.ui.dxList.getInstance(blazor_element).deleteItem(itemElement);
};
function BlazorDevExtreme_DxList_deleteItem_3 (blazor_element, itemIndex) {
	return DevExpress.ui.dxList.getInstance(blazor_element).deleteItem(itemIndex);
};
function BlazorDevExtreme_DxList_expandGroup_4 (blazor_element, groupIndex) {
	return DevExpress.ui.dxList.getInstance(blazor_element).expandGroup(groupIndex);
};
function BlazorDevExtreme_DxList_isItemSelected_5 (blazor_element, itemElement) {
	return DevExpress.ui.dxList.getInstance(blazor_element).isItemSelected(itemElement);
};
function BlazorDevExtreme_DxList_isItemSelected_6 (blazor_element, itemIndex) {
	return DevExpress.ui.dxList.getInstance(blazor_element).isItemSelected(itemIndex);
};
function BlazorDevExtreme_DxList_reload_7 (blazor_element) {
	DevExpress.ui.dxList.getInstance(blazor_element).reload();
};
function BlazorDevExtreme_DxList_reorderItem_8 (blazor_element, itemElement, toItemElement) {
	return DevExpress.ui.dxList.getInstance(blazor_element).reorderItem(itemElement, toItemElement);
};
function BlazorDevExtreme_DxList_reorderItem_9 (blazor_element, itemIndex, toItemIndex) {
	return DevExpress.ui.dxList.getInstance(blazor_element).reorderItem(itemIndex, toItemIndex);
};
function BlazorDevExtreme_DxList_scrollBy_10 (blazor_element, distance) {
	DevExpress.ui.dxList.getInstance(blazor_element).scrollBy(distance);
};
function BlazorDevExtreme_DxList_scrollHeight_11 (blazor_element) {
	return DevExpress.ui.dxList.getInstance(blazor_element).scrollHeight();
};
function BlazorDevExtreme_DxList_scrollTo_12 (blazor_element, location) {
	DevExpress.ui.dxList.getInstance(blazor_element).scrollTo(location);
};
function BlazorDevExtreme_DxList_scrollToItem_13 (blazor_element, itemElement) {
	DevExpress.ui.dxList.getInstance(blazor_element).scrollToItem(itemElement);
};
function BlazorDevExtreme_DxList_scrollToItem_14 (blazor_element, itemIndex) {
	DevExpress.ui.dxList.getInstance(blazor_element).scrollToItem(itemIndex);
};
function BlazorDevExtreme_DxList_scrollTop_15 (blazor_element) {
	return DevExpress.ui.dxList.getInstance(blazor_element).scrollTop();
};
function BlazorDevExtreme_DxList_selectAll_16 (blazor_element) {
	DevExpress.ui.dxList.getInstance(blazor_element).selectAll();
};
function BlazorDevExtreme_DxList_selectItem_17 (blazor_element, itemElement) {
	DevExpress.ui.dxList.getInstance(blazor_element).selectItem(itemElement);
};
function BlazorDevExtreme_DxList_selectItem_18 (blazor_element, itemIndex) {
	DevExpress.ui.dxList.getInstance(blazor_element).selectItem(itemIndex);
};
function BlazorDevExtreme_DxList_unselectAll_19 (blazor_element) {
	DevExpress.ui.dxList.getInstance(blazor_element).unselectAll();
};
function BlazorDevExtreme_DxList_unselectItem_20 (blazor_element, itemElement) {
	DevExpress.ui.dxList.getInstance(blazor_element).unselectItem(itemElement);
};
function BlazorDevExtreme_DxList_unselectItem_21 (blazor_element, itemIndex) {
	DevExpress.ui.dxList.getInstance(blazor_element).unselectItem(itemIndex);
};
function BlazorDevExtreme_DxList_updateDimensions_22 (blazor_element) {
	return DevExpress.ui.dxList.getInstance(blazor_element).updateDimensions();
};
function BlazorDevExtreme_DxList_SetOption (element, key, value) {
	DevExpress.ui.dxList.getInstance(element).option(key, value);
};
function BlazorDevExtreme_DxList_GetOption (element, key) {
	return DevExpress.ui.dxList.getInstance(blazor_element).option(key);
};
// DevExpress.ui.dxLoadIndicator interop automatically generated
function BlazorDevExtreme_DxLoadIndicator_Init (element, optionsText) {
	const options = JSON.parse(optionsText);

	let instance = new DevExpress.ui.dxLoadIndicator(element, options);
}
function BlazorDevExtreme_DxLoadIndicator_SetOption (element, key, value) {
	DevExpress.ui.dxLoadIndicator.getInstance(element).option(key, value);
};
function BlazorDevExtreme_DxLoadIndicator_GetOption (element, key) {
	return DevExpress.ui.dxLoadIndicator.getInstance(blazor_element).option(key);
};
// DevExpress.ui.dxLoadPanel interop automatically generated
function BlazorDevExtreme_DxLoadPanel_Init (element, optionsText) {
	const options = JSON.parse(optionsText);

	let instance = new DevExpress.ui.dxLoadPanel(element, options);
}
function BlazorDevExtreme_DxLoadPanel_SetOption (element, key, value) {
	DevExpress.ui.dxLoadPanel.getInstance(element).option(key, value);
};
function BlazorDevExtreme_DxLoadPanel_GetOption (element, key) {
	return DevExpress.ui.dxLoadPanel.getInstance(blazor_element).option(key);
};
// DevExpress.ui.dxLookup interop automatically generated
function BlazorDevExtreme_DxLookup_Init (element, optionsText) {
	const options = JSON.parse(optionsText);

	if (options.onPageLoadingEnabled) {
		options.onPageLoading = function () {
			DotNet.invokeMethodAsync(assemblyName, 'DevExpress.Ui.DxLookupInterop.OnPageLoading', element.id);
			
		}
	}
	if (options.onPullRefreshEnabled) {
		options.onPullRefresh = function () {
			DotNet.invokeMethodAsync(assemblyName, 'DevExpress.Ui.DxLookupInterop.OnPullRefresh', element.id);
			
		}
	}
	if (options.onScrollEnabled) {
		options.onScroll = function () {
			DotNet.invokeMethodAsync(assemblyName, 'DevExpress.Ui.DxLookupInterop.OnScroll', element.id);
			
		}
	}
	if (options.onTitleRenderedEnabled) {
		options.onTitleRendered = function () {
			DotNet.invokeMethodAsync(assemblyName, 'DevExpress.Ui.DxLookupInterop.OnTitleRendered', element.id);
			
		}
	}
	if (options.onValueChangedEnabled) {
		options.onValueChanged = function () {
			DotNet.invokeMethodAsync(assemblyName, 'DevExpress.Ui.DxLookupInterop.OnValueChanged', element.id);
			
		}
	}
	let instance = new DevExpress.ui.dxLookup(element, options);
}
function BlazorDevExtreme_DxLookup_SetOption (element, key, value) {
	DevExpress.ui.dxLookup.getInstance(element).option(key, value);
};
function BlazorDevExtreme_DxLookup_GetOption (element, key) {
	return DevExpress.ui.dxLookup.getInstance(blazor_element).option(key);
};
// DevExpress.ui.dxMap interop automatically generated
function BlazorDevExtreme_DxMap_Init (element, optionsText) {
	const options = JSON.parse(optionsText);

	if (options.onClickEnabled) {
		options.onClick = function () {
			DotNet.invokeMethodAsync(assemblyName, 'DevExpress.Ui.DxMapInterop.OnClick', element.id);
			
		}
	}
	if (options.onMarkerAddedEnabled) {
		options.onMarkerAdded = function () {
			DotNet.invokeMethodAsync(assemblyName, 'DevExpress.Ui.DxMapInterop.OnMarkerAdded', element.id);
			
		}
	}
	if (options.onMarkerRemovedEnabled) {
		options.onMarkerRemoved = function () {
			DotNet.invokeMethodAsync(assemblyName, 'DevExpress.Ui.DxMapInterop.OnMarkerRemoved', element.id);
			
		}
	}
	if (options.onReadyEnabled) {
		options.onReady = function () {
			DotNet.invokeMethodAsync(assemblyName, 'DevExpress.Ui.DxMapInterop.OnReady', element.id);
			
		}
	}
	if (options.onRouteAddedEnabled) {
		options.onRouteAdded = function () {
			DotNet.invokeMethodAsync(assemblyName, 'DevExpress.Ui.DxMapInterop.OnRouteAdded', element.id);
			
		}
	}
	if (options.onRouteRemovedEnabled) {
		options.onRouteRemoved = function () {
			DotNet.invokeMethodAsync(assemblyName, 'DevExpress.Ui.DxMapInterop.OnRouteRemoved', element.id);
			
		}
	}
	let instance = new DevExpress.ui.dxMap(element, options);
}
function BlazorDevExtreme_DxMap_addMarker_0 (blazor_element, markerOptions) {
	return DevExpress.ui.dxMap.getInstance(blazor_element).addMarker(markerOptions);
};
function BlazorDevExtreme_DxMap_addRoute_1 (blazor_element, options) {
	return DevExpress.ui.dxMap.getInstance(blazor_element).addRoute(options);
};
function BlazorDevExtreme_DxMap_removeMarker_2 (blazor_element, marker) {
	return DevExpress.ui.dxMap.getInstance(blazor_element).removeMarker(marker);
};
function BlazorDevExtreme_DxMap_removeRoute_3 (blazor_element, route) {
	return DevExpress.ui.dxMap.getInstance(blazor_element).removeRoute(route);
};
function BlazorDevExtreme_DxMap_SetOption (element, key, value) {
	DevExpress.ui.dxMap.getInstance(element).option(key, value);
};
function BlazorDevExtreme_DxMap_GetOption (element, key) {
	return DevExpress.ui.dxMap.getInstance(blazor_element).option(key);
};
// DevExpress.ui.dxMenu interop automatically generated
function BlazorDevExtreme_DxMenu_Init (element, optionsText) {
	const options = JSON.parse(optionsText);

	if (options.onSubmenuHiddenEnabled) {
		options.onSubmenuHidden = function () {
			DotNet.invokeMethodAsync(assemblyName, 'DevExpress.Ui.DxMenuInterop.OnSubmenuHidden', element.id);
			
		}
	}
	if (options.onSubmenuHidingEnabled) {
		options.onSubmenuHiding = function () {
			DotNet.invokeMethodAsync(assemblyName, 'DevExpress.Ui.DxMenuInterop.OnSubmenuHiding', element.id);
			
		}
	}
	if (options.onSubmenuShowingEnabled) {
		options.onSubmenuShowing = function () {
			DotNet.invokeMethodAsync(assemblyName, 'DevExpress.Ui.DxMenuInterop.OnSubmenuShowing', element.id);
			
		}
	}
	if (options.onSubmenuShownEnabled) {
		options.onSubmenuShown = function () {
			DotNet.invokeMethodAsync(assemblyName, 'DevExpress.Ui.DxMenuInterop.OnSubmenuShown', element.id);
			
		}
	}
	let instance = new DevExpress.ui.dxMenu(element, options);
}
function BlazorDevExtreme_DxMenu_SetOption (element, key, value) {
	DevExpress.ui.dxMenu.getInstance(element).option(key, value);
};
function BlazorDevExtreme_DxMenu_GetOption (element, key) {
	return DevExpress.ui.dxMenu.getInstance(blazor_element).option(key);
};
// DevExpress.ui.dxMultiView interop automatically generated
function BlazorDevExtreme_DxMultiView_Init (element, optionsText) {
	const options = JSON.parse(optionsText);

	let instance = new DevExpress.ui.dxMultiView(element, options);
}
function BlazorDevExtreme_DxMultiView_SetOption (element, key, value) {
	DevExpress.ui.dxMultiView.getInstance(element).option(key, value);
};
function BlazorDevExtreme_DxMultiView_GetOption (element, key) {
	return DevExpress.ui.dxMultiView.getInstance(blazor_element).option(key);
};
// DevExpress.ui.dxNavBar interop automatically generated
function BlazorDevExtreme_DxNavBar_Init (element, optionsText) {
	const options = JSON.parse(optionsText);

	let instance = new DevExpress.ui.dxNavBar(element, options);
}
function BlazorDevExtreme_DxNavBar_SetOption (element, key, value) {
	DevExpress.ui.dxNavBar.getInstance(element).option(key, value);
};
function BlazorDevExtreme_DxNavBar_GetOption (element, key) {
	return DevExpress.ui.dxNavBar.getInstance(blazor_element).option(key);
};
// DevExpress.ui.dxNumberBox interop automatically generated
function BlazorDevExtreme_DxNumberBox_Init (element, optionsText) {
	const options = JSON.parse(optionsText);

	let instance = new DevExpress.ui.dxNumberBox(element, options);
}
function BlazorDevExtreme_DxNumberBox_SetOption (element, key, value) {
	DevExpress.ui.dxNumberBox.getInstance(element).option(key, value);
};
function BlazorDevExtreme_DxNumberBox_GetOption (element, key) {
	return DevExpress.ui.dxNumberBox.getInstance(blazor_element).option(key);
};
// DevExpress.ui.dxOverlay interop automatically generated
function BlazorDevExtreme_DxOverlay_Init (element, optionsText) {
	const options = JSON.parse(optionsText);

	if (options.onHiddenEnabled) {
		options.onHidden = function () {
			DotNet.invokeMethodAsync(assemblyName, 'DevExpress.Ui.DxOverlayInterop.OnHidden', element.id);
			
		}
	}
	if (options.onHidingEnabled) {
		options.onHiding = function () {
			DotNet.invokeMethodAsync(assemblyName, 'DevExpress.Ui.DxOverlayInterop.OnHiding', element.id);
			
		}
	}
	if (options.onShowingEnabled) {
		options.onShowing = function () {
			DotNet.invokeMethodAsync(assemblyName, 'DevExpress.Ui.DxOverlayInterop.OnShowing', element.id);
			
		}
	}
	if (options.onShownEnabled) {
		options.onShown = function () {
			DotNet.invokeMethodAsync(assemblyName, 'DevExpress.Ui.DxOverlayInterop.OnShown', element.id);
			
		}
	}
	let instance = new DevExpress.ui.dxOverlay(element, options);
}
function BlazorDevExtreme_DxOverlay_content_0 (blazor_element) {
	return DevExpress.ui.dxOverlay.getInstance(blazor_element).content();
};
function BlazorDevExtreme_DxOverlay_hide_1 (blazor_element) {
	return DevExpress.ui.dxOverlay.getInstance(blazor_element).hide();
};
function BlazorDevExtreme_DxOverlay_repaint_2 (blazor_element) {
	DevExpress.ui.dxOverlay.getInstance(blazor_element).repaint();
};
function BlazorDevExtreme_DxOverlay_show_3 (blazor_element) {
	return DevExpress.ui.dxOverlay.getInstance(blazor_element).show();
};
function BlazorDevExtreme_DxOverlay_toggle_4 (blazor_element, showing) {
	return DevExpress.ui.dxOverlay.getInstance(blazor_element).toggle(showing);
};
function BlazorDevExtreme_DxOverlay_SetOption (element, key, value) {
	DevExpress.ui.dxOverlay.getInstance(element).option(key, value);
};
function BlazorDevExtreme_DxOverlay_GetOption (element, key) {
	return DevExpress.ui.dxOverlay.getInstance(blazor_element).option(key);
};
// DevExpress.ui.dxPanorama interop automatically generated
function BlazorDevExtreme_DxPanorama_Init (element, optionsText) {
	const options = JSON.parse(optionsText);

	let instance = new DevExpress.ui.dxPanorama(element, options);
}
function BlazorDevExtreme_DxPanorama_SetOption (element, key, value) {
	DevExpress.ui.dxPanorama.getInstance(element).option(key, value);
};
function BlazorDevExtreme_DxPanorama_GetOption (element, key) {
	return DevExpress.ui.dxPanorama.getInstance(blazor_element).option(key);
};
// DevExpress.ui.dxPivot interop automatically generated
function BlazorDevExtreme_DxPivot_Init (element, optionsText) {
	const options = JSON.parse(optionsText);

	let instance = new DevExpress.ui.dxPivot(element, options);
}
function BlazorDevExtreme_DxPivot_SetOption (element, key, value) {
	DevExpress.ui.dxPivot.getInstance(element).option(key, value);
};
function BlazorDevExtreme_DxPivot_GetOption (element, key) {
	return DevExpress.ui.dxPivot.getInstance(blazor_element).option(key);
};
// DevExpress.ui.dxPivotGrid interop automatically generated
function BlazorDevExtreme_DxPivotGrid_Init (element, optionsText) {
	const options = JSON.parse(optionsText);

	if (options.onCellClickEnabled) {
		options.onCellClick = function () {
			DotNet.invokeMethodAsync(assemblyName, 'DevExpress.Ui.DxPivotGridInterop.OnCellClick', element.id);
			
		}
	}
	if (options.onCellPreparedEnabled) {
		options.onCellPrepared = function () {
			DotNet.invokeMethodAsync(assemblyName, 'DevExpress.Ui.DxPivotGridInterop.OnCellPrepared', element.id);
			
		}
	}
	if (options.onContextMenuPreparingEnabled) {
		options.onContextMenuPreparing = function () {
			DotNet.invokeMethodAsync(assemblyName, 'DevExpress.Ui.DxPivotGridInterop.OnContextMenuPreparing', element.id);
			
		}
	}
	if (options.onExportedEnabled) {
		options.onExported = function () {
			DotNet.invokeMethodAsync(assemblyName, 'DevExpress.Ui.DxPivotGridInterop.OnExported', element.id);
			
		}
	}
	if (options.onExportingEnabled) {
		options.onExporting = function () {
			DotNet.invokeMethodAsync(assemblyName, 'DevExpress.Ui.DxPivotGridInterop.OnExporting', element.id);
			
		}
	}
	if (options.onFileSavingEnabled) {
		options.onFileSaving = function () {
			DotNet.invokeMethodAsync(assemblyName, 'DevExpress.Ui.DxPivotGridInterop.OnFileSaving', element.id);
			
		}
	}
	let instance = new DevExpress.ui.dxPivotGrid(element, options);
}
function BlazorDevExtreme_DxPivotGrid_bindChart_0 (blazor_element, chart, integrationOptions) {
	return DevExpress.ui.dxPivotGrid.getInstance(blazor_element).bindChart(chart, integrationOptions);
};
function BlazorDevExtreme_DxPivotGrid_exportToExcel_1 (blazor_element) {
	DevExpress.ui.dxPivotGrid.getInstance(blazor_element).exportToExcel();
};
function BlazorDevExtreme_DxPivotGrid_getDataSource_2 (blazor_element) {
	return DevExpress.ui.dxPivotGrid.getInstance(blazor_element).getDataSource();
};
function BlazorDevExtreme_DxPivotGrid_getFieldChooserPopup_3 (blazor_element) {
	return DevExpress.ui.dxPivotGrid.getInstance(blazor_element).getFieldChooserPopup();
};
function BlazorDevExtreme_DxPivotGrid_updateDimensions_4 (blazor_element) {
	DevExpress.ui.dxPivotGrid.getInstance(blazor_element).updateDimensions();
};
function BlazorDevExtreme_DxPivotGrid_SetOption (element, key, value) {
	DevExpress.ui.dxPivotGrid.getInstance(element).option(key, value);
};
function BlazorDevExtreme_DxPivotGrid_GetOption (element, key) {
	return DevExpress.ui.dxPivotGrid.getInstance(blazor_element).option(key);
};
// DevExpress.ui.dxPivotGridFieldChooser interop automatically generated
function BlazorDevExtreme_DxPivotGridFieldChooser_Init (element, optionsText) {
	const options = JSON.parse(optionsText);

	if (options.onContextMenuPreparingEnabled) {
		options.onContextMenuPreparing = function () {
			DotNet.invokeMethodAsync(assemblyName, 'DevExpress.Ui.DxPivotGridFieldChooserInterop.OnContextMenuPreparing', element.id);
			
		}
	}
	let instance = new DevExpress.ui.dxPivotGridFieldChooser(element, options);
}
function BlazorDevExtreme_DxPivotGridFieldChooser_applyChanges_0 (blazor_element) {
	DevExpress.ui.dxPivotGridFieldChooser.getInstance(blazor_element).applyChanges();
};
function BlazorDevExtreme_DxPivotGridFieldChooser_cancelChanges_1 (blazor_element) {
	DevExpress.ui.dxPivotGridFieldChooser.getInstance(blazor_element).cancelChanges();
};
function BlazorDevExtreme_DxPivotGridFieldChooser_getDataSource_2 (blazor_element) {
	return DevExpress.ui.dxPivotGridFieldChooser.getInstance(blazor_element).getDataSource();
};
function BlazorDevExtreme_DxPivotGridFieldChooser_updateDimensions_3 (blazor_element) {
	DevExpress.ui.dxPivotGridFieldChooser.getInstance(blazor_element).updateDimensions();
};
function BlazorDevExtreme_DxPivotGridFieldChooser_SetOption (element, key, value) {
	DevExpress.ui.dxPivotGridFieldChooser.getInstance(element).option(key, value);
};
function BlazorDevExtreme_DxPivotGridFieldChooser_GetOption (element, key) {
	return DevExpress.ui.dxPivotGridFieldChooser.getInstance(blazor_element).option(key);
};
// DevExpress.ui.dxPopover interop automatically generated
function BlazorDevExtreme_DxPopover_Init (element, optionsText) {
	const options = JSON.parse(optionsText);

	let instance = new DevExpress.ui.dxPopover(element, options);
}
function BlazorDevExtreme_DxPopover_show_0 (blazor_element) {
	return DevExpress.ui.dxPopover.getInstance(blazor_element).show();
};
function BlazorDevExtreme_DxPopover_show_1 (blazor_element, target) {
	return DevExpress.ui.dxPopover.getInstance(blazor_element).show(target);
};
function BlazorDevExtreme_DxPopover_SetOption (element, key, value) {
	DevExpress.ui.dxPopover.getInstance(element).option(key, value);
};
function BlazorDevExtreme_DxPopover_GetOption (element, key) {
	return DevExpress.ui.dxPopover.getInstance(blazor_element).option(key);
};
// DevExpress.ui.dxPopup interop automatically generated
function BlazorDevExtreme_DxPopup_Init (element, optionsText) {
	const options = JSON.parse(optionsText);

	if (options.onResizeEnabled) {
		options.onResize = function () {
			DotNet.invokeMethodAsync(assemblyName, 'DevExpress.Ui.DxPopupInterop.OnResize', element.id);
			
		}
	}
	if (options.onResizeEndEnabled) {
		options.onResizeEnd = function () {
			DotNet.invokeMethodAsync(assemblyName, 'DevExpress.Ui.DxPopupInterop.OnResizeEnd', element.id);
			
		}
	}
	if (options.onResizeStartEnabled) {
		options.onResizeStart = function () {
			DotNet.invokeMethodAsync(assemblyName, 'DevExpress.Ui.DxPopupInterop.OnResizeStart', element.id);
			
		}
	}
	if (options.onTitleRenderedEnabled) {
		options.onTitleRendered = function () {
			DotNet.invokeMethodAsync(assemblyName, 'DevExpress.Ui.DxPopupInterop.OnTitleRendered', element.id);
			
		}
	}
	let instance = new DevExpress.ui.dxPopup(element, options);
}
function BlazorDevExtreme_DxPopup_SetOption (element, key, value) {
	DevExpress.ui.dxPopup.getInstance(element).option(key, value);
};
function BlazorDevExtreme_DxPopup_GetOption (element, key) {
	return DevExpress.ui.dxPopup.getInstance(blazor_element).option(key);
};
// DevExpress.ui.dxProgressBar interop automatically generated
function BlazorDevExtreme_DxProgressBar_Init (element, optionsText) {
	const options = JSON.parse(optionsText);

	if (options.onCompleteEnabled) {
		options.onComplete = function () {
			DotNet.invokeMethodAsync(assemblyName, 'DevExpress.Ui.DxProgressBarInterop.OnComplete', element.id);
			
		}
	}
	let instance = new DevExpress.ui.dxProgressBar(element, options);
}
function BlazorDevExtreme_DxProgressBar_SetOption (element, key, value) {
	DevExpress.ui.dxProgressBar.getInstance(element).option(key, value);
};
function BlazorDevExtreme_DxProgressBar_GetOption (element, key) {
	return DevExpress.ui.dxProgressBar.getInstance(blazor_element).option(key);
};
// DevExpress.ui.dxRadioGroup interop automatically generated
function BlazorDevExtreme_DxRadioGroup_Init (element, optionsText) {
	const options = JSON.parse(optionsText);

	let instance = new DevExpress.ui.dxRadioGroup(element, options);
}
function BlazorDevExtreme_DxRadioGroup_getDataSource_0 (blazor_element) {
	return DevExpress.ui.dxRadioGroup.getInstance(blazor_element).getDataSource();
};
function BlazorDevExtreme_DxRadioGroup_SetOption (element, key, value) {
	DevExpress.ui.dxRadioGroup.getInstance(element).option(key, value);
};
function BlazorDevExtreme_DxRadioGroup_GetOption (element, key) {
	return DevExpress.ui.dxRadioGroup.getInstance(blazor_element).option(key);
};
// DevExpress.ui.dxRangeSlider interop automatically generated
function BlazorDevExtreme_DxRangeSlider_Init (element, optionsText) {
	const options = JSON.parse(optionsText);

	if (options.onValueChangedEnabled) {
		options.onValueChanged = function () {
			DotNet.invokeMethodAsync(assemblyName, 'DevExpress.Ui.DxRangeSliderInterop.OnValueChanged', element.id);
			
		}
	}
	let instance = new DevExpress.ui.dxRangeSlider(element, options);
}
function BlazorDevExtreme_DxRangeSlider_reset_0 (blazor_element) {
	DevExpress.ui.dxRangeSlider.getInstance(blazor_element).reset();
};
function BlazorDevExtreme_DxRangeSlider_SetOption (element, key, value) {
	DevExpress.ui.dxRangeSlider.getInstance(element).option(key, value);
};
function BlazorDevExtreme_DxRangeSlider_GetOption (element, key) {
	return DevExpress.ui.dxRangeSlider.getInstance(blazor_element).option(key);
};
// DevExpress.ui.dxResizable interop automatically generated
function BlazorDevExtreme_DxResizable_Init (element, optionsText) {
	const options = JSON.parse(optionsText);

	if (options.onResizeEnabled) {
		options.onResize = function () {
			DotNet.invokeMethodAsync(assemblyName, 'DevExpress.Ui.DxResizableInterop.OnResize', element.id);
			
		}
	}
	if (options.onResizeEndEnabled) {
		options.onResizeEnd = function () {
			DotNet.invokeMethodAsync(assemblyName, 'DevExpress.Ui.DxResizableInterop.OnResizeEnd', element.id);
			
		}
	}
	if (options.onResizeStartEnabled) {
		options.onResizeStart = function () {
			DotNet.invokeMethodAsync(assemblyName, 'DevExpress.Ui.DxResizableInterop.OnResizeStart', element.id);
			
		}
	}
	let instance = new DevExpress.ui.dxResizable(element, options);
}
function BlazorDevExtreme_DxResizable_SetOption (element, key, value) {
	DevExpress.ui.dxResizable.getInstance(element).option(key, value);
};
function BlazorDevExtreme_DxResizable_GetOption (element, key) {
	return DevExpress.ui.dxResizable.getInstance(blazor_element).option(key);
};
// DevExpress.ui.dxResponsiveBox interop automatically generated
function BlazorDevExtreme_DxResponsiveBox_Init (element, optionsText) {
	const options = JSON.parse(optionsText);

	let instance = new DevExpress.ui.dxResponsiveBox(element, options);
}
function BlazorDevExtreme_DxResponsiveBox_SetOption (element, key, value) {
	DevExpress.ui.dxResponsiveBox.getInstance(element).option(key, value);
};
function BlazorDevExtreme_DxResponsiveBox_GetOption (element, key) {
	return DevExpress.ui.dxResponsiveBox.getInstance(blazor_element).option(key);
};
// DevExpress.ui.dxScheduler interop automatically generated
function BlazorDevExtreme_DxScheduler_Init (element, optionsText) {
	const options = JSON.parse(optionsText);

	if (options.onAppointmentAddedEnabled) {
		options.onAppointmentAdded = function () {
			DotNet.invokeMethodAsync(assemblyName, 'DevExpress.Ui.DxSchedulerInterop.OnAppointmentAdded', element.id);
			
		}
	}
	if (options.onAppointmentAddingEnabled) {
		options.onAppointmentAdding = function () {
			DotNet.invokeMethodAsync(assemblyName, 'DevExpress.Ui.DxSchedulerInterop.OnAppointmentAdding', element.id);
			
		}
	}
	if (options.onAppointmentClickEnabled) {
		options.onAppointmentClick = function () {
			DotNet.invokeMethodAsync(assemblyName, 'DevExpress.Ui.DxSchedulerInterop.OnAppointmentClick', element.id);
			
		}
	}
	if (options.onAppointmentContextMenuEnabled) {
		options.onAppointmentContextMenu = function () {
			DotNet.invokeMethodAsync(assemblyName, 'DevExpress.Ui.DxSchedulerInterop.OnAppointmentContextMenu', element.id);
			
		}
	}
	if (options.onAppointmentDblClickEnabled) {
		options.onAppointmentDblClick = function () {
			DotNet.invokeMethodAsync(assemblyName, 'DevExpress.Ui.DxSchedulerInterop.OnAppointmentDblClick', element.id);
			
		}
	}
	if (options.onAppointmentDeletedEnabled) {
		options.onAppointmentDeleted = function () {
			DotNet.invokeMethodAsync(assemblyName, 'DevExpress.Ui.DxSchedulerInterop.OnAppointmentDeleted', element.id);
			
		}
	}
	if (options.onAppointmentDeletingEnabled) {
		options.onAppointmentDeleting = function () {
			DotNet.invokeMethodAsync(assemblyName, 'DevExpress.Ui.DxSchedulerInterop.OnAppointmentDeleting', element.id);
			
		}
	}
	if (options.onAppointmentFormCreatedEnabled) {
		options.onAppointmentFormCreated = function () {
			DotNet.invokeMethodAsync(assemblyName, 'DevExpress.Ui.DxSchedulerInterop.OnAppointmentFormCreated', element.id);
			
		}
	}
	if (options.onAppointmentRenderedEnabled) {
		options.onAppointmentRendered = function () {
			DotNet.invokeMethodAsync(assemblyName, 'DevExpress.Ui.DxSchedulerInterop.OnAppointmentRendered', element.id);
			
		}
	}
	if (options.onAppointmentUpdatedEnabled) {
		options.onAppointmentUpdated = function () {
			DotNet.invokeMethodAsync(assemblyName, 'DevExpress.Ui.DxSchedulerInterop.OnAppointmentUpdated', element.id);
			
		}
	}
	if (options.onAppointmentUpdatingEnabled) {
		options.onAppointmentUpdating = function () {
			DotNet.invokeMethodAsync(assemblyName, 'DevExpress.Ui.DxSchedulerInterop.OnAppointmentUpdating', element.id);
			
		}
	}
	if (options.onCellClickEnabled) {
		options.onCellClick = function () {
			DotNet.invokeMethodAsync(assemblyName, 'DevExpress.Ui.DxSchedulerInterop.OnCellClick', element.id);
			
		}
	}
	if (options.onCellContextMenuEnabled) {
		options.onCellContextMenu = function () {
			DotNet.invokeMethodAsync(assemblyName, 'DevExpress.Ui.DxSchedulerInterop.OnCellContextMenu', element.id);
			
		}
	}
	let instance = new DevExpress.ui.dxScheduler(element, options);
}
function BlazorDevExtreme_DxScheduler_addAppointment_0 (blazor_element, appointment) {
	DevExpress.ui.dxScheduler.getInstance(blazor_element).addAppointment(appointment);
};
function BlazorDevExtreme_DxScheduler_deleteAppointment_1 (blazor_element, appointment) {
	DevExpress.ui.dxScheduler.getInstance(blazor_element).deleteAppointment(appointment);
};
function BlazorDevExtreme_DxScheduler_getDataSource_2 (blazor_element) {
	return DevExpress.ui.dxScheduler.getInstance(blazor_element).getDataSource();
};
function BlazorDevExtreme_DxScheduler_getEndViewDate_3 (blazor_element) {
	return DevExpress.ui.dxScheduler.getInstance(blazor_element).getEndViewDate();
};
function BlazorDevExtreme_DxScheduler_getStartViewDate_4 (blazor_element) {
	return DevExpress.ui.dxScheduler.getInstance(blazor_element).getStartViewDate();
};
function BlazorDevExtreme_DxScheduler_hideAppointmentPopup_5 (blazor_element, saveChanges) {
	DevExpress.ui.dxScheduler.getInstance(blazor_element).hideAppointmentPopup(saveChanges);
};
function BlazorDevExtreme_DxScheduler_hideAppointmentTooltip_6 (blazor_element) {
	DevExpress.ui.dxScheduler.getInstance(blazor_element).hideAppointmentTooltip();
};
function BlazorDevExtreme_DxScheduler_registerKeyHandler_7 (blazor_element) {
	DevExpress.ui.dxScheduler.getInstance(blazor_element).registerKeyHandler();
};
function BlazorDevExtreme_DxScheduler_scrollToTime_8 (blazor_element, hours, minutes, date) {
	DevExpress.ui.dxScheduler.getInstance(blazor_element).scrollToTime(hours, minutes, date);
};
function BlazorDevExtreme_DxScheduler_showAppointmentPopup_9 (blazor_element, appointmentData, createNewAppointment, currentAppointmentData) {
	DevExpress.ui.dxScheduler.getInstance(blazor_element).showAppointmentPopup(appointmentData, createNewAppointment, currentAppointmentData);
};
function BlazorDevExtreme_DxScheduler_showAppointmentTooltip_10 (blazor_element, appointmentData, target, currentAppointmentData) {
	DevExpress.ui.dxScheduler.getInstance(blazor_element).showAppointmentTooltip(appointmentData, target, currentAppointmentData);
};
function BlazorDevExtreme_DxScheduler_updateAppointment_11 (blazor_element, target, appointment) {
	DevExpress.ui.dxScheduler.getInstance(blazor_element).updateAppointment(target, appointment);
};
function BlazorDevExtreme_DxScheduler_SetOption (element, key, value) {
	DevExpress.ui.dxScheduler.getInstance(element).option(key, value);
};
function BlazorDevExtreme_DxScheduler_GetOption (element, key) {
	return DevExpress.ui.dxScheduler.getInstance(blazor_element).option(key);
};
// DevExpress.ui.dxScrollView interop automatically generated
function BlazorDevExtreme_DxScrollView_Init (element, optionsText) {
	const options = JSON.parse(optionsText);

	if (options.onPullDownEnabled) {
		options.onPullDown = function () {
			DotNet.invokeMethodAsync(assemblyName, 'DevExpress.Ui.DxScrollViewInterop.OnPullDown', element.id);
			
		}
	}
	if (options.onReachBottomEnabled) {
		options.onReachBottom = function () {
			DotNet.invokeMethodAsync(assemblyName, 'DevExpress.Ui.DxScrollViewInterop.OnReachBottom', element.id);
			
		}
	}
	let instance = new DevExpress.ui.dxScrollView(element, options);
}
function BlazorDevExtreme_DxScrollView_refresh_0 (blazor_element) {
	DevExpress.ui.dxScrollView.getInstance(blazor_element).refresh();
};
function BlazorDevExtreme_DxScrollView_release_1 (blazor_element, preventScrollBottom) {
	return DevExpress.ui.dxScrollView.getInstance(blazor_element).release(preventScrollBottom);
};
function BlazorDevExtreme_DxScrollView_SetOption (element, key, value) {
	DevExpress.ui.dxScrollView.getInstance(element).option(key, value);
};
function BlazorDevExtreme_DxScrollView_GetOption (element, key) {
	return DevExpress.ui.dxScrollView.getInstance(blazor_element).option(key);
};
// DevExpress.ui.dxSelectBox interop automatically generated
function BlazorDevExtreme_DxSelectBox_Init (element, optionsText) {
	const options = JSON.parse(optionsText);

	if (options.onCustomItemCreatingEnabled) {
		options.onCustomItemCreating = function () {
			DotNet.invokeMethodAsync(assemblyName, 'DevExpress.Ui.DxSelectBoxInterop.OnCustomItemCreating', element.id);
			
		}
    }

    if (options.onValueChangedEnabled) {
        options.onValueChanged = function () {
            DotNet.invokeMethodAsync(assemblyName, 'DevExpress.Ui.EditorInterop.OnValueChanged', element.id, instance.option("value"));

        }
    }
	let instance = new DevExpress.ui.dxSelectBox(element, options);
}
function BlazorDevExtreme_DxSelectBox_SetOption (element, key, value) {
	DevExpress.ui.dxSelectBox.getInstance(element).option(key, value);
};
function BlazorDevExtreme_DxSelectBox_GetOption (element, key) {
	return DevExpress.ui.dxSelectBox.getInstance(blazor_element).option(key);
};
// DevExpress.ui.dxSlider interop automatically generated
function BlazorDevExtreme_DxSlider_Init (element, optionsText) {
	const options = JSON.parse(optionsText);

	let instance = new DevExpress.ui.dxSlider(element, options);
}
function BlazorDevExtreme_DxSlider_SetOption (element, key, value) {
	DevExpress.ui.dxSlider.getInstance(element).option(key, value);
};
function BlazorDevExtreme_DxSlider_GetOption (element, key) {
	return DevExpress.ui.dxSlider.getInstance(blazor_element).option(key);
};
// DevExpress.ui.dxSlideOut interop automatically generated
function BlazorDevExtreme_DxSlideOut_Init (element, optionsText) {
	const options = JSON.parse(optionsText);

	if (options.onMenuGroupRenderedEnabled) {
		options.onMenuGroupRendered = function () {
			DotNet.invokeMethodAsync(assemblyName, 'DevExpress.Ui.DxSlideOutInterop.OnMenuGroupRendered', element.id);
			
		}
	}
	if (options.onMenuItemRenderedEnabled) {
		options.onMenuItemRendered = function () {
			DotNet.invokeMethodAsync(assemblyName, 'DevExpress.Ui.DxSlideOutInterop.OnMenuItemRendered', element.id);
			
		}
	}
	let instance = new DevExpress.ui.dxSlideOut(element, options);
}
function BlazorDevExtreme_DxSlideOut_hideMenu_0 (blazor_element) {
	return DevExpress.ui.dxSlideOut.getInstance(blazor_element).hideMenu();
};
function BlazorDevExtreme_DxSlideOut_showMenu_1 (blazor_element) {
	return DevExpress.ui.dxSlideOut.getInstance(blazor_element).showMenu();
};
function BlazorDevExtreme_DxSlideOut_toggleMenuVisibility_2 (blazor_element, showing) {
	return DevExpress.ui.dxSlideOut.getInstance(blazor_element).toggleMenuVisibility(showing);
};
function BlazorDevExtreme_DxSlideOut_SetOption (element, key, value) {
	DevExpress.ui.dxSlideOut.getInstance(element).option(key, value);
};
function BlazorDevExtreme_DxSlideOut_GetOption (element, key) {
	return DevExpress.ui.dxSlideOut.getInstance(blazor_element).option(key);
};
// DevExpress.ui.dxSlideOutView interop automatically generated
function BlazorDevExtreme_DxSlideOutView_Init (element, optionsText) {
	const options = JSON.parse(optionsText);

	let instance = new DevExpress.ui.dxSlideOutView(element, options);
}
function BlazorDevExtreme_DxSlideOutView_content_0 (blazor_element) {
	return DevExpress.ui.dxSlideOutView.getInstance(blazor_element).content();
};
function BlazorDevExtreme_DxSlideOutView_hideMenu_1 (blazor_element) {
	return DevExpress.ui.dxSlideOutView.getInstance(blazor_element).hideMenu();
};
function BlazorDevExtreme_DxSlideOutView_menuContent_2 (blazor_element) {
	return DevExpress.ui.dxSlideOutView.getInstance(blazor_element).menuContent();
};
function BlazorDevExtreme_DxSlideOutView_showMenu_3 (blazor_element) {
	return DevExpress.ui.dxSlideOutView.getInstance(blazor_element).showMenu();
};
function BlazorDevExtreme_DxSlideOutView_toggleMenuVisibility_4 (blazor_element) {
	return DevExpress.ui.dxSlideOutView.getInstance(blazor_element).toggleMenuVisibility();
};
function BlazorDevExtreme_DxSlideOutView_SetOption (element, key, value) {
	DevExpress.ui.dxSlideOutView.getInstance(element).option(key, value);
};
function BlazorDevExtreme_DxSlideOutView_GetOption (element, key) {
	return DevExpress.ui.dxSlideOutView.getInstance(blazor_element).option(key);
};
// DevExpress.ui.dxSwitch interop automatically generated
function BlazorDevExtreme_DxSwitch_Init (element, optionsText) {
	const options = JSON.parse(optionsText);

	let instance = new DevExpress.ui.dxSwitch(element, options);
}
function BlazorDevExtreme_DxSwitch_SetOption (element, key, value) {
	DevExpress.ui.dxSwitch.getInstance(element).option(key, value);
};
function BlazorDevExtreme_DxSwitch_GetOption (element, key) {
	return DevExpress.ui.dxSwitch.getInstance(blazor_element).option(key);
};
// DevExpress.ui.dxTabs interop automatically generated
function BlazorDevExtreme_DxTabs_Init (element, optionsText) {
	const options = JSON.parse(optionsText);

	let instance = new DevExpress.ui.dxTabs(element, options);
}
function BlazorDevExtreme_DxTabs_SetOption (element, key, value) {
	DevExpress.ui.dxTabs.getInstance(element).option(key, value);
};
function BlazorDevExtreme_DxTabs_GetOption (element, key) {
	return DevExpress.ui.dxTabs.getInstance(blazor_element).option(key);
};
// DevExpress.ui.dxTabPanel interop automatically generated
function BlazorDevExtreme_DxTabPanel_Init (element, optionsText) {
	const options = JSON.parse(optionsText);

	if (options.onTitleClickEnabled) {
		options.onTitleClick = function () {
			DotNet.invokeMethodAsync(assemblyName, 'DevExpress.Ui.DxTabPanelInterop.OnTitleClick', element.id);
			
		}
	}
	if (options.onTitleHoldEnabled) {
		options.onTitleHold = function () {
			DotNet.invokeMethodAsync(assemblyName, 'DevExpress.Ui.DxTabPanelInterop.OnTitleHold', element.id);
			
		}
	}
	if (options.onTitleRenderedEnabled) {
		options.onTitleRendered = function () {
			DotNet.invokeMethodAsync(assemblyName, 'DevExpress.Ui.DxTabPanelInterop.OnTitleRendered', element.id);
			
		}
	}
	let instance = new DevExpress.ui.dxTabPanel(element, options);
}
function BlazorDevExtreme_DxTabPanel_SetOption (element, key, value) {
	DevExpress.ui.dxTabPanel.getInstance(element).option(key, value);
};
function BlazorDevExtreme_DxTabPanel_GetOption (element, key) {
	return DevExpress.ui.dxTabPanel.getInstance(blazor_element).option(key);
};
// DevExpress.ui.dxTagBox interop automatically generated
function BlazorDevExtreme_DxTagBox_Init (element, optionsText) {
	const options = JSON.parse(optionsText);

	if (options.onMultiTagPreparingEnabled) {
		options.onMultiTagPreparing = function () {
			DotNet.invokeMethodAsync(assemblyName, 'DevExpress.Ui.DxTagBoxInterop.OnMultiTagPreparing', element.id);
			
		}
	}
	if (options.onSelectAllValueChangedEnabled) {
		options.onSelectAllValueChanged = function () {
			DotNet.invokeMethodAsync(assemblyName, 'DevExpress.Ui.DxTagBoxInterop.OnSelectAllValueChanged', element.id);
			
		}
	}
	if (options.onSelectionChangedEnabled) {
		options.onSelectionChanged = function () {
			DotNet.invokeMethodAsync(assemblyName, 'DevExpress.Ui.DxTagBoxInterop.OnSelectionChanged', element.id);
			
		}
	}
	let instance = new DevExpress.ui.dxTagBox(element, options);
}
function BlazorDevExtreme_DxTagBox_SetOption (element, key, value) {
	DevExpress.ui.dxTagBox.getInstance(element).option(key, value);
};
function BlazorDevExtreme_DxTagBox_GetOption (element, key) {
	return DevExpress.ui.dxTagBox.getInstance(blazor_element).option(key);
};
// DevExpress.ui.dxTextArea interop automatically generated
function BlazorDevExtreme_DxTextArea_Init (element, optionsText) {
	const options = JSON.parse(optionsText);

	let instance = new DevExpress.ui.dxTextArea(element, options);
}
function BlazorDevExtreme_DxTextArea_SetOption (element, key, value) {
	DevExpress.ui.dxTextArea.getInstance(element).option(key, value);
};
function BlazorDevExtreme_DxTextArea_GetOption (element, key) {
	return DevExpress.ui.dxTextArea.getInstance(blazor_element).option(key);
};
// DevExpress.ui.dxTextBox interop automatically generated
function BlazorDevExtreme_DxTextBox_Init (element, optionsText) {
    
    const options = JSON.parse(optionsText);

    if (options.onValueChangedEnabled) {
        options.onValueChanged = function () {
            DotNet.invokeMethodAsync(assemblyName, 'DevExpress.Ui.EditorInterop.OnValueChanged', element.id, instance.option("value"));

        }
    }

    let instance = new DevExpress.ui.dxTextBox(element, options);
    // Not working:
    //BlazorDevExtreme_Editor_Init(element, optionsText, instance);
}
function BlazorDevExtreme_DxTextBox_SetOption (element, key, value) {
	DevExpress.ui.dxTextBox.getInstance(element).option(key, value);
};
function BlazorDevExtreme_DxTextBox_GetOption (element, key) {
	return DevExpress.ui.dxTextBox.getInstance(blazor_element).option(key);
};
// DevExpress.ui.dxTileView interop automatically generated
function BlazorDevExtreme_DxTileView_Init (element, optionsText) {
	const options = JSON.parse(optionsText);

	let instance = new DevExpress.ui.dxTileView(element, options);
}
function BlazorDevExtreme_DxTileView_scrollPosition_0 (blazor_element) {
	return DevExpress.ui.dxTileView.getInstance(blazor_element).scrollPosition();
};
function BlazorDevExtreme_DxTileView_SetOption (element, key, value) {
	DevExpress.ui.dxTileView.getInstance(element).option(key, value);
};
function BlazorDevExtreme_DxTileView_GetOption (element, key) {
	return DevExpress.ui.dxTileView.getInstance(blazor_element).option(key);
};
// DevExpress.ui.dxToast interop automatically generated
function BlazorDevExtreme_DxToast_Init (element, optionsText) {
	const options = JSON.parse(optionsText);

	let instance = new DevExpress.ui.dxToast(element, options);
}
function BlazorDevExtreme_DxToast_SetOption (element, key, value) {
	DevExpress.ui.dxToast.getInstance(element).option(key, value);
};
function BlazorDevExtreme_DxToast_GetOption (element, key) {
	return DevExpress.ui.dxToast.getInstance(blazor_element).option(key);
};
// DevExpress.ui.dxToolbar interop automatically generated
function BlazorDevExtreme_DxToolbar_Init (element, optionsText) {
	const options = JSON.parse(optionsText);

	let instance = new DevExpress.ui.dxToolbar(element, options);
}
function BlazorDevExtreme_DxToolbar_SetOption (element, key, value) {
	DevExpress.ui.dxToolbar.getInstance(element).option(key, value);
};
function BlazorDevExtreme_DxToolbar_GetOption (element, key) {
	return DevExpress.ui.dxToolbar.getInstance(blazor_element).option(key);
};
// DevExpress.ui.dxTooltip interop automatically generated
function BlazorDevExtreme_DxTooltip_Init (element, optionsText) {
	const options = JSON.parse(optionsText);

	let instance = new DevExpress.ui.dxTooltip(element, options);
}
function BlazorDevExtreme_DxTooltip_SetOption (element, key, value) {
	DevExpress.ui.dxTooltip.getInstance(element).option(key, value);
};
function BlazorDevExtreme_DxTooltip_GetOption (element, key) {
	return DevExpress.ui.dxTooltip.getInstance(blazor_element).option(key);
};
// DevExpress.ui.dxTrackBar interop automatically generated
function BlazorDevExtreme_DxTrackBar_Init (element, optionsText) {
	const options = JSON.parse(optionsText);

	let instance = new DevExpress.ui.dxTrackBar(element, options);
}
function BlazorDevExtreme_DxTrackBar_SetOption (element, key, value) {
	DevExpress.ui.dxTrackBar.getInstance(element).option(key, value);
};
function BlazorDevExtreme_DxTrackBar_GetOption (element, key) {
	return DevExpress.ui.dxTrackBar.getInstance(blazor_element).option(key);
};
// DevExpress.ui.dxTreeList interop automatically generated
function BlazorDevExtreme_DxTreeList_Init (element, optionsText) {
	const options = JSON.parse(optionsText);

	if (options.onCellClickEnabled) {
		options.onCellClick = function () {
			DotNet.invokeMethodAsync(assemblyName, 'DevExpress.Ui.DxTreeListInterop.OnCellClick', element.id);
			
		}
	}
	if (options.onCellHoverChangedEnabled) {
		options.onCellHoverChanged = function () {
			DotNet.invokeMethodAsync(assemblyName, 'DevExpress.Ui.DxTreeListInterop.OnCellHoverChanged', element.id);
			
		}
	}
	if (options.onCellPreparedEnabled) {
		options.onCellPrepared = function () {
			DotNet.invokeMethodAsync(assemblyName, 'DevExpress.Ui.DxTreeListInterop.OnCellPrepared', element.id);
			
		}
	}
	if (options.onContextMenuPreparingEnabled) {
		options.onContextMenuPreparing = function () {
			DotNet.invokeMethodAsync(assemblyName, 'DevExpress.Ui.DxTreeListInterop.OnContextMenuPreparing', element.id);
			
		}
	}
	if (options.onEditingStartEnabled) {
		options.onEditingStart = function () {
			DotNet.invokeMethodAsync(assemblyName, 'DevExpress.Ui.DxTreeListInterop.OnEditingStart', element.id);
			
		}
	}
	if (options.onEditorPreparedEnabled) {
		options.onEditorPrepared = function () {
			DotNet.invokeMethodAsync(assemblyName, 'DevExpress.Ui.DxTreeListInterop.OnEditorPrepared', element.id);
			
		}
	}
	if (options.onEditorPreparingEnabled) {
		options.onEditorPreparing = function () {
			DotNet.invokeMethodAsync(assemblyName, 'DevExpress.Ui.DxTreeListInterop.OnEditorPreparing', element.id);
			
		}
	}
	if (options.onNodesInitializedEnabled) {
		options.onNodesInitialized = function () {
			DotNet.invokeMethodAsync(assemblyName, 'DevExpress.Ui.DxTreeListInterop.OnNodesInitialized', element.id);
			
		}
	}
	if (options.onRowClickEnabled) {
		options.onRowClick = function () {
			DotNet.invokeMethodAsync(assemblyName, 'DevExpress.Ui.DxTreeListInterop.OnRowClick', element.id);
			
		}
	}
	if (options.onRowPreparedEnabled) {
		options.onRowPrepared = function () {
			DotNet.invokeMethodAsync(assemblyName, 'DevExpress.Ui.DxTreeListInterop.OnRowPrepared', element.id);
			
		}
	}
	let instance = new DevExpress.ui.dxTreeList(element, options);
}
function BlazorDevExtreme_DxTreeList_addColumn_0 (blazor_element, columnOptions) {
	DevExpress.ui.dxTreeList.getInstance(blazor_element).addColumn(columnOptions);
};
function BlazorDevExtreme_DxTreeList_addRow_1 (blazor_element) {
	DevExpress.ui.dxTreeList.getInstance(blazor_element).addRow();
};
function BlazorDevExtreme_DxTreeList_addRow_2 (blazor_element, parentId) {
	DevExpress.ui.dxTreeList.getInstance(blazor_element).addRow(parentId);
};
function BlazorDevExtreme_DxTreeList_collapseRow_3 (blazor_element, key) {
	return DevExpress.ui.dxTreeList.getInstance(blazor_element).collapseRow(key);
};
function BlazorDevExtreme_DxTreeList_expandRow_4 (blazor_element, key) {
	return DevExpress.ui.dxTreeList.getInstance(blazor_element).expandRow(key);
};
function BlazorDevExtreme_DxTreeList_forEachNode_5 (blazor_element, callback) {
	DevExpress.ui.dxTreeList.getInstance(blazor_element).forEachNode(callback);
};
function BlazorDevExtreme_DxTreeList_forEachNode_6 (blazor_element, nodes, callback) {
	DevExpress.ui.dxTreeList.getInstance(blazor_element).forEachNode(nodes, callback);
};
function BlazorDevExtreme_DxTreeList_getNodeByKey_7 (blazor_element, key) {
	return DevExpress.ui.dxTreeList.getInstance(blazor_element).getNodeByKey(key);
};
function BlazorDevExtreme_DxTreeList_getRootNode_8 (blazor_element) {
	return DevExpress.ui.dxTreeList.getInstance(blazor_element).getRootNode();
};
function BlazorDevExtreme_DxTreeList_getSelectedRowKeys_9 (blazor_element) {
	return DevExpress.ui.dxTreeList.getInstance(blazor_element).getSelectedRowKeys();
};
function BlazorDevExtreme_DxTreeList_getSelectedRowKeys_10 (blazor_element, leavesOnly) {
	return DevExpress.ui.dxTreeList.getInstance(blazor_element).getSelectedRowKeys(leavesOnly);
};
function BlazorDevExtreme_DxTreeList_getSelectedRowKeys_11 (blazor_element, mode) {
	return DevExpress.ui.dxTreeList.getInstance(blazor_element).getSelectedRowKeys(mode);
};
function BlazorDevExtreme_DxTreeList_getSelectedRowsData_12 (blazor_element) {
	return DevExpress.ui.dxTreeList.getInstance(blazor_element).getSelectedRowsData();
};
function BlazorDevExtreme_DxTreeList_getVisibleColumns_13 (blazor_element) {
	return DevExpress.ui.dxTreeList.getInstance(blazor_element).getVisibleColumns();
};
function BlazorDevExtreme_DxTreeList_getVisibleColumns_14 (blazor_element, headerLevel) {
	return DevExpress.ui.dxTreeList.getInstance(blazor_element).getVisibleColumns(headerLevel);
};
function BlazorDevExtreme_DxTreeList_getVisibleRows_15 (blazor_element) {
	return DevExpress.ui.dxTreeList.getInstance(blazor_element).getVisibleRows();
};
function BlazorDevExtreme_DxTreeList_isRowExpanded_16 (blazor_element, key) {
	return DevExpress.ui.dxTreeList.getInstance(blazor_element).isRowExpanded(key);
};
function BlazorDevExtreme_DxTreeList_loadDescendants_17 (blazor_element) {
	return DevExpress.ui.dxTreeList.getInstance(blazor_element).loadDescendants();
};
function BlazorDevExtreme_DxTreeList_loadDescendants_18 (blazor_element, keys) {
	return DevExpress.ui.dxTreeList.getInstance(blazor_element).loadDescendants(keys);
};
function BlazorDevExtreme_DxTreeList_loadDescendants_19 (blazor_element, keys, childrenOnly) {
	return DevExpress.ui.dxTreeList.getInstance(blazor_element).loadDescendants(keys, childrenOnly);
};
function BlazorDevExtreme_DxTreeList_SetOption (element, key, value) {
	DevExpress.ui.dxTreeList.getInstance(element).option(key, value);
};
function BlazorDevExtreme_DxTreeList_GetOption (element, key) {
	return DevExpress.ui.dxTreeList.getInstance(blazor_element).option(key);
};
// DevExpress.ui.dxTreeView interop automatically generated
function BlazorDevExtreme_DxTreeView_Init (element, optionsText) {
	const options = JSON.parse(optionsText);

	if (options.onItemClickEnabled) {
		options.onItemClick = function () {
			DotNet.invokeMethodAsync(assemblyName, 'DevExpress.Ui.DxTreeViewInterop.OnItemClick', element.id);
			
		}
	}
	if (options.onItemCollapsedEnabled) {
		options.onItemCollapsed = function () {
			DotNet.invokeMethodAsync(assemblyName, 'DevExpress.Ui.DxTreeViewInterop.OnItemCollapsed', element.id);
			
		}
	}
	if (options.onItemContextMenuEnabled) {
		options.onItemContextMenu = function () {
			DotNet.invokeMethodAsync(assemblyName, 'DevExpress.Ui.DxTreeViewInterop.OnItemContextMenu', element.id);
			
		}
	}
	if (options.onItemExpandedEnabled) {
		options.onItemExpanded = function () {
			DotNet.invokeMethodAsync(assemblyName, 'DevExpress.Ui.DxTreeViewInterop.OnItemExpanded', element.id);
			
		}
	}
	if (options.onItemHoldEnabled) {
		options.onItemHold = function () {
			DotNet.invokeMethodAsync(assemblyName, 'DevExpress.Ui.DxTreeViewInterop.OnItemHold', element.id);
			
		}
	}
	if (options.onItemRenderedEnabled) {
		options.onItemRendered = function () {
			DotNet.invokeMethodAsync(assemblyName, 'DevExpress.Ui.DxTreeViewInterop.OnItemRendered', element.id);
			
		}
	}
	if (options.onItemSelectionChangedEnabled) {
		options.onItemSelectionChanged = function () {
			DotNet.invokeMethodAsync(assemblyName, 'DevExpress.Ui.DxTreeViewInterop.OnItemSelectionChanged', element.id);
			
		}
	}
	if (options.onSelectionChangedEnabled) {
		options.onSelectionChanged = function () {
			DotNet.invokeMethodAsync(assemblyName, 'DevExpress.Ui.DxTreeViewInterop.OnSelectionChanged', element.id);
			
		}
	}
	let instance = new DevExpress.ui.dxTreeView(element, options);
}
function BlazorDevExtreme_DxTreeView_collapseItem_0 (blazor_element, itemData) {
	DevExpress.ui.dxTreeView.getInstance(blazor_element).collapseItem(itemData);
};
function BlazorDevExtreme_DxTreeView_collapseItem_1 (blazor_element, itemElement) {
	DevExpress.ui.dxTreeView.getInstance(blazor_element).collapseItem(itemElement);
};
function BlazorDevExtreme_DxTreeView_collapseItem_2 (blazor_element, key) {
	DevExpress.ui.dxTreeView.getInstance(blazor_element).collapseItem(key);
};
function BlazorDevExtreme_DxTreeView_expandItem_3 (blazor_element, itemData) {
	DevExpress.ui.dxTreeView.getInstance(blazor_element).expandItem(itemData);
};
function BlazorDevExtreme_DxTreeView_expandItem_4 (blazor_element, itemElement) {
	DevExpress.ui.dxTreeView.getInstance(blazor_element).expandItem(itemElement);
};
function BlazorDevExtreme_DxTreeView_expandItem_5 (blazor_element, key) {
	DevExpress.ui.dxTreeView.getInstance(blazor_element).expandItem(key);
};
function BlazorDevExtreme_DxTreeView_getNodes_6 (blazor_element) {
	return DevExpress.ui.dxTreeView.getInstance(blazor_element).getNodes();
};
function BlazorDevExtreme_DxTreeView_selectAll_7 (blazor_element) {
	DevExpress.ui.dxTreeView.getInstance(blazor_element).selectAll();
};
function BlazorDevExtreme_DxTreeView_selectItem_8 (blazor_element, itemData) {
	DevExpress.ui.dxTreeView.getInstance(blazor_element).selectItem(itemData);
};
function BlazorDevExtreme_DxTreeView_selectItem_9 (blazor_element, itemElement) {
	DevExpress.ui.dxTreeView.getInstance(blazor_element).selectItem(itemElement);
};
function BlazorDevExtreme_DxTreeView_selectItem_10 (blazor_element, key) {
	DevExpress.ui.dxTreeView.getInstance(blazor_element).selectItem(key);
};
function BlazorDevExtreme_DxTreeView_unselectAll_11 (blazor_element) {
	DevExpress.ui.dxTreeView.getInstance(blazor_element).unselectAll();
};
function BlazorDevExtreme_DxTreeView_unselectItem_12 (blazor_element, itemData) {
	DevExpress.ui.dxTreeView.getInstance(blazor_element).unselectItem(itemData);
};
function BlazorDevExtreme_DxTreeView_unselectItem_13 (blazor_element, itemElement) {
	DevExpress.ui.dxTreeView.getInstance(blazor_element).unselectItem(itemElement);
};
function BlazorDevExtreme_DxTreeView_unselectItem_14 (blazor_element, key) {
	DevExpress.ui.dxTreeView.getInstance(blazor_element).unselectItem(key);
};
function BlazorDevExtreme_DxTreeView_updateDimensions_15 (blazor_element) {
	return DevExpress.ui.dxTreeView.getInstance(blazor_element).updateDimensions();
};
function BlazorDevExtreme_DxTreeView_SetOption (element, key, value) {
	DevExpress.ui.dxTreeView.getInstance(element).option(key, value);
};
function BlazorDevExtreme_DxTreeView_GetOption (element, key) {
	return DevExpress.ui.dxTreeView.getInstance(blazor_element).option(key);
};
// DevExpress.ui.dxValidationGroup interop automatically generated
function BlazorDevExtreme_DxValidationGroup_Init (element, optionsText) {
	const options = JSON.parse(optionsText);

	let instance = new DevExpress.ui.dxValidationGroup(element, options);
}
function BlazorDevExtreme_DxValidationGroup_reset_0 (blazor_element) {
	DevExpress.ui.dxValidationGroup.getInstance(blazor_element).reset();
};
function BlazorDevExtreme_DxValidationGroup_validate_1 (blazor_element) {
	return DevExpress.ui.dxValidationGroup.getInstance(blazor_element).validate();
};
function BlazorDevExtreme_DxValidationGroup_SetOption (element, key, value) {
	DevExpress.ui.dxValidationGroup.getInstance(element).option(key, value);
};
function BlazorDevExtreme_DxValidationGroup_GetOption (element, key) {
	return DevExpress.ui.dxValidationGroup.getInstance(blazor_element).option(key);
};
// DevExpress.ui.dxValidationSummary interop automatically generated
function BlazorDevExtreme_DxValidationSummary_Init (element, optionsText) {
	const options = JSON.parse(optionsText);

	let instance = new DevExpress.ui.dxValidationSummary(element, options);
}
function BlazorDevExtreme_DxValidationSummary_SetOption (element, key, value) {
	DevExpress.ui.dxValidationSummary.getInstance(element).option(key, value);
};
function BlazorDevExtreme_DxValidationSummary_GetOption (element, key) {
	return DevExpress.ui.dxValidationSummary.getInstance(blazor_element).option(key);
};
// DevExpress.ui.dxValidator interop automatically generated
function BlazorDevExtreme_DxValidator_Init (element, optionsText) {
	const options = JSON.parse(optionsText);

	if (options.onValidatedEnabled) {
		options.onValidated = function () {
			DotNet.invokeMethodAsync(assemblyName, 'DevExpress.Ui.DxValidatorInterop.OnValidated', element.id);
			
		}
	}
	let instance = new DevExpress.ui.dxValidator(element, options);
}
function BlazorDevExtreme_DxValidator_focus_0 (blazor_element) {
	DevExpress.ui.dxValidator.getInstance(blazor_element).focus();
};
function BlazorDevExtreme_DxValidator_reset_1 (blazor_element) {
	DevExpress.ui.dxValidator.getInstance(blazor_element).reset();
};
function BlazorDevExtreme_DxValidator_validate_2 (blazor_element) {
	return DevExpress.ui.dxValidator.getInstance(blazor_element).validate();
};
function BlazorDevExtreme_DxValidator_SetOption (element, key, value) {
	DevExpress.ui.dxValidator.getInstance(element).option(key, value);
};
function BlazorDevExtreme_DxValidator_GetOption (element, key) {
	return DevExpress.ui.dxValidator.getInstance(blazor_element).option(key);
};
// DevExpress.ui.CollectionWidget interop automatically generated
function BlazorDevExtreme_CollectionWidget_Init (element, optionsText) {
	const options = JSON.parse(optionsText);

	if (options.onItemClickEnabled) {
		options.onItemClick = function () {
			DotNet.invokeMethodAsync(assemblyName, 'DevExpress.Ui.CollectionWidgetInterop.OnItemClick', element.id);
			
		}
	}
	if (options.onItemContextMenuEnabled) {
		options.onItemContextMenu = function () {
			DotNet.invokeMethodAsync(assemblyName, 'DevExpress.Ui.CollectionWidgetInterop.OnItemContextMenu', element.id);
			
		}
	}
	if (options.onItemHoldEnabled) {
		options.onItemHold = function () {
			DotNet.invokeMethodAsync(assemblyName, 'DevExpress.Ui.CollectionWidgetInterop.OnItemHold', element.id);
			
		}
	}
	if (options.onItemRenderedEnabled) {
		options.onItemRendered = function () {
			DotNet.invokeMethodAsync(assemblyName, 'DevExpress.Ui.CollectionWidgetInterop.OnItemRendered', element.id);
			
		}
	}
	if (options.onSelectionChangedEnabled) {
		options.onSelectionChanged = function () {
			DotNet.invokeMethodAsync(assemblyName, 'DevExpress.Ui.CollectionWidgetInterop.OnSelectionChanged', element.id);
			
		}
	}
	let instance = new DevExpress.ui.CollectionWidget(element, options);
}
function BlazorDevExtreme_CollectionWidget_getDataSource_0 (blazor_element) {
	return DevExpress.ui.CollectionWidget.getInstance(blazor_element).getDataSource();
};
function BlazorDevExtreme_CollectionWidget_SetOption (element, key, value) {
	DevExpress.ui.CollectionWidget.getInstance(element).option(key, value);
};
function BlazorDevExtreme_CollectionWidget_GetOption (element, key) {
	return DevExpress.ui.CollectionWidget.getInstance(blazor_element).option(key);
};
// DevExpress.ui.dxMenuBase interop automatically generated
function BlazorDevExtreme_DxMenuBase_Init (element, optionsText) {
	const options = JSON.parse(optionsText);

	let instance = new DevExpress.ui.dxMenuBase(element, options);
}
function BlazorDevExtreme_DxMenuBase_selectItem_0 (blazor_element, itemElement) {
	DevExpress.ui.dxMenuBase.getInstance(blazor_element).selectItem(itemElement);
};
function BlazorDevExtreme_DxMenuBase_unselectItem_1 (blazor_element, itemElement) {
	DevExpress.ui.dxMenuBase.getInstance(blazor_element).unselectItem(itemElement);
};
function BlazorDevExtreme_DxMenuBase_SetOption (element, key, value) {
	DevExpress.ui.dxMenuBase.getInstance(element).option(key, value);
};
function BlazorDevExtreme_DxMenuBase_GetOption (element, key) {
	return DevExpress.ui.dxMenuBase.getInstance(blazor_element).option(key);
};
// DevExpress.ui.dxDropDownEditor interop automatically generated
function BlazorDevExtreme_DxDropDownEditor_Init (element, optionsText) {
	const options = JSON.parse(optionsText);

	if (options.onClosedEnabled) {
		options.onClosed = function () {
			DotNet.invokeMethodAsync(assemblyName, 'DevExpress.Ui.DxDropDownEditorInterop.OnClosed', element.id);
			
		}
	}
	if (options.onOpenedEnabled) {
		options.onOpened = function () {
			DotNet.invokeMethodAsync(assemblyName, 'DevExpress.Ui.DxDropDownEditorInterop.OnOpened', element.id);
			
		}
	}
	let instance = new DevExpress.ui.dxDropDownEditor(element, options);
}
function BlazorDevExtreme_DxDropDownEditor_close_0 (blazor_element) {
	DevExpress.ui.dxDropDownEditor.getInstance(blazor_element).close();
};
function BlazorDevExtreme_DxDropDownEditor_content_1 (blazor_element) {
	return DevExpress.ui.dxDropDownEditor.getInstance(blazor_element).content();
};
function BlazorDevExtreme_DxDropDownEditor_field_2 (blazor_element) {
	return DevExpress.ui.dxDropDownEditor.getInstance(blazor_element).field();
};
function BlazorDevExtreme_DxDropDownEditor_open_3 (blazor_element) {
	DevExpress.ui.dxDropDownEditor.getInstance(blazor_element).open();
};
function BlazorDevExtreme_DxDropDownEditor_reset_4 (blazor_element) {
	DevExpress.ui.dxDropDownEditor.getInstance(blazor_element).reset();
};
function BlazorDevExtreme_DxDropDownEditor_SetOption (element, key, value) {
	DevExpress.ui.dxDropDownEditor.getInstance(element).option(key, value);
};
function BlazorDevExtreme_DxDropDownEditor_GetOption (element, key) {
	return DevExpress.ui.dxDropDownEditor.getInstance(blazor_element).option(key);
};
// DevExpress.ui.dxDropDownList interop automatically generated
function BlazorDevExtreme_DxDropDownList_Init (element, optionsText) {
	const options = JSON.parse(optionsText);

	if (options.onItemClickEnabled) {
		options.onItemClick = function () {
			DotNet.invokeMethodAsync(assemblyName, 'DevExpress.Ui.DxDropDownListInterop.OnItemClick', element.id);
			
		}
	}
	if (options.onSelectionChangedEnabled) {
		options.onSelectionChanged = function () {
			DotNet.invokeMethodAsync(assemblyName, 'DevExpress.Ui.DxDropDownListInterop.OnSelectionChanged', element.id);
			
		}
	}
	if (options.onValueChangedEnabled) {
		options.onValueChanged = function () {
			DotNet.invokeMethodAsync(assemblyName, 'DevExpress.Ui.DxDropDownListInterop.OnValueChanged', element.id);
			
		}
	}
	let instance = new DevExpress.ui.dxDropDownList(element, options);
}
function BlazorDevExtreme_DxDropDownList_getDataSource_0 (blazor_element) {
	return DevExpress.ui.dxDropDownList.getInstance(blazor_element).getDataSource();
};
function BlazorDevExtreme_DxDropDownList_SetOption (element, key, value) {
	DevExpress.ui.dxDropDownList.getInstance(element).option(key, value);
};
function BlazorDevExtreme_DxDropDownList_GetOption (element, key) {
	return DevExpress.ui.dxDropDownList.getInstance(blazor_element).option(key);
};
// DevExpress.ui.Editor interop automatically generated
function BlazorDevExtreme_Editor_Init (element, optionsText) {
	const options = JSON.parse(optionsText);

	if (options.onValueChangedEnabled) {
		options.onValueChanged = function () {
            DotNet.invokeMethodAsync(assemblyName, 'DevExpress.Ui.EditorInterop.OnValueChanged', element.id, instance.option("value"));
			
		}
	}
	let instance = new DevExpress.ui.Editor(element, options);
}
function BlazorDevExtreme_Editor_reset_0 (blazor_element) {
	DevExpress.ui.Editor.getInstance(blazor_element).reset();
};
function BlazorDevExtreme_Editor_SetOption (element, key, value) {
	DevExpress.ui.Editor.getInstance(element).option(key, value);
};
function BlazorDevExtreme_Editor_GetOption (element, key) {
	return DevExpress.ui.Editor.getInstance(blazor_element).option(key);
};
// DevExpress.ui.DataExpressionMixin interop automatically generated
function BlazorDevExtreme_DataExpressionMixin_Init (element, optionsText) {
	const options = JSON.parse(optionsText);

	let instance = new DevExpress.ui.DataExpressionMixin(element, options);
}
function BlazorDevExtreme_DataExpressionMixin_getDataSource_0 (blazor_element) {
	return DevExpress.ui.DataExpressionMixin.getInstance(blazor_element).getDataSource();
};
function BlazorDevExtreme_DataExpressionMixin_SetOption (element, key, value) {
	DevExpress.ui.DataExpressionMixin.getInstance(element).option(key, value);
};
function BlazorDevExtreme_DataExpressionMixin_GetOption (element, key) {
	return DevExpress.ui.DataExpressionMixin.getInstance(blazor_element).option(key);
};
// DevExpress.ui.HierarchicalCollectionWidget interop automatically generated
function BlazorDevExtreme_HierarchicalCollectionWidget_Init (element, optionsText) {
	const options = JSON.parse(optionsText);

	let instance = new DevExpress.ui.HierarchicalCollectionWidget(element, options);
}
function BlazorDevExtreme_HierarchicalCollectionWidget_SetOption (element, key, value) {
	DevExpress.ui.HierarchicalCollectionWidget.getInstance(element).option(key, value);
};
function BlazorDevExtreme_HierarchicalCollectionWidget_GetOption (element, key) {
	return DevExpress.ui.HierarchicalCollectionWidget.getInstance(blazor_element).option(key);
};
// DevExpress.ui.dxPivotGridSummaryCell interop automatically generated
function BlazorDevExtreme_DxPivotGridSummaryCell_child_0 (blazor_element, direction, fieldValue) {
	return DevExpress.ui.dxPivotGridSummaryCell.getInstance(blazor_element).child(direction, fieldValue);
};
function BlazorDevExtreme_DxPivotGridSummaryCell_children_1 (blazor_element, direction) {
	return DevExpress.ui.dxPivotGridSummaryCell.getInstance(blazor_element).children(direction);
};
function BlazorDevExtreme_DxPivotGridSummaryCell_field_2 (blazor_element, area) {
	return DevExpress.ui.dxPivotGridSummaryCell.getInstance(blazor_element).field(area);
};
function BlazorDevExtreme_DxPivotGridSummaryCell_grandTotal_3 (blazor_element) {
	return DevExpress.ui.dxPivotGridSummaryCell.getInstance(blazor_element).grandTotal();
};
function BlazorDevExtreme_DxPivotGridSummaryCell_grandTotal_4 (blazor_element, direction) {
	return DevExpress.ui.dxPivotGridSummaryCell.getInstance(blazor_element).grandTotal(direction);
};
function BlazorDevExtreme_DxPivotGridSummaryCell_next_5 (blazor_element, direction) {
	return DevExpress.ui.dxPivotGridSummaryCell.getInstance(blazor_element).next(direction);
};
function BlazorDevExtreme_DxPivotGridSummaryCell_next_6 (blazor_element, direction, allowCrossGroup) {
	return DevExpress.ui.dxPivotGridSummaryCell.getInstance(blazor_element).next(direction, allowCrossGroup);
};
function BlazorDevExtreme_DxPivotGridSummaryCell_parent_7 (blazor_element, direction) {
	return DevExpress.ui.dxPivotGridSummaryCell.getInstance(blazor_element).parent(direction);
};
function BlazorDevExtreme_DxPivotGridSummaryCell_prev_8 (blazor_element, direction) {
	return DevExpress.ui.dxPivotGridSummaryCell.getInstance(blazor_element).prev(direction);
};
function BlazorDevExtreme_DxPivotGridSummaryCell_prev_9 (blazor_element, direction, allowCrossGroup) {
	return DevExpress.ui.dxPivotGridSummaryCell.getInstance(blazor_element).prev(direction, allowCrossGroup);
};
function BlazorDevExtreme_DxPivotGridSummaryCell_slice_10 (blazor_element, field, value) {
	return DevExpress.ui.dxPivotGridSummaryCell.getInstance(blazor_element).slice(field, value);
};
function BlazorDevExtreme_DxPivotGridSummaryCell_value_11 (blazor_element) {
	return DevExpress.ui.dxPivotGridSummaryCell.getInstance(blazor_element).value();
};
function BlazorDevExtreme_DxPivotGridSummaryCell_value_12 (blazor_element, field) {
	return DevExpress.ui.dxPivotGridSummaryCell.getInstance(blazor_element).value(field);
};
function BlazorDevExtreme_DxPivotGridSummaryCell_value_13 (blazor_element, field, isCalculatedValue) {
	return DevExpress.ui.dxPivotGridSummaryCell.getInstance(blazor_element).value(field, isCalculatedValue);
};
function BlazorDevExtreme_DxPivotGridSummaryCell_value_14 (blazor_element, isCalculatedValue) {
	return DevExpress.ui.dxPivotGridSummaryCell.getInstance(blazor_element).value(isCalculatedValue);
};
function BlazorDevExtreme_DxPivotGridSummaryCell_SetOption (element, key, value) {
	DevExpress.ui.dxPivotGridSummaryCell.getInstance(element).option(key, value);
};
function BlazorDevExtreme_DxPivotGridSummaryCell_GetOption (element, key) {
	return DevExpress.ui.dxPivotGridSummaryCell.getInstance(blazor_element).option(key);
};
// DevExpress.ui.dxScrollable interop automatically generated
function BlazorDevExtreme_DxScrollable_Init (element, optionsText) {
	const options = JSON.parse(optionsText);

	if (options.onScrollEnabled) {
		options.onScroll = function () {
			DotNet.invokeMethodAsync(assemblyName, 'DevExpress.Ui.DxScrollableInterop.OnScroll', element.id);
			
		}
	}
	if (options.onUpdatedEnabled) {
		options.onUpdated = function () {
			DotNet.invokeMethodAsync(assemblyName, 'DevExpress.Ui.DxScrollableInterop.OnUpdated', element.id);
			
		}
	}
	let instance = new DevExpress.ui.dxScrollable(element, options);
}
function BlazorDevExtreme_DxScrollable_clientHeight_0 (blazor_element) {
	return DevExpress.ui.dxScrollable.getInstance(blazor_element).clientHeight();
};
function BlazorDevExtreme_DxScrollable_clientWidth_1 (blazor_element) {
	return DevExpress.ui.dxScrollable.getInstance(blazor_element).clientWidth();
};
function BlazorDevExtreme_DxScrollable_content_2 (blazor_element) {
	return DevExpress.ui.dxScrollable.getInstance(blazor_element).content();
};
function BlazorDevExtreme_DxScrollable_scrollBy_3 (blazor_element, distance) {
	DevExpress.ui.dxScrollable.getInstance(blazor_element).scrollBy(distance);
};
function BlazorDevExtreme_DxScrollable_scrollBy_4 (blazor_element, distanceObject) {
	DevExpress.ui.dxScrollable.getInstance(blazor_element).scrollBy(distanceObject);
};
function BlazorDevExtreme_DxScrollable_scrollHeight_5 (blazor_element) {
	return DevExpress.ui.dxScrollable.getInstance(blazor_element).scrollHeight();
};
function BlazorDevExtreme_DxScrollable_scrollLeft_6 (blazor_element) {
	return DevExpress.ui.dxScrollable.getInstance(blazor_element).scrollLeft();
};
function BlazorDevExtreme_DxScrollable_scrollOffset_7 (blazor_element) {
	return DevExpress.ui.dxScrollable.getInstance(blazor_element).scrollOffset();
};
function BlazorDevExtreme_DxScrollable_scrollTo_8 (blazor_element, targetLocation) {
	DevExpress.ui.dxScrollable.getInstance(blazor_element).scrollTo(targetLocation);
};
function BlazorDevExtreme_DxScrollable_scrollTo_9 (blazor_element, targetLocation) {
	DevExpress.ui.dxScrollable.getInstance(blazor_element).scrollTo(targetLocation);
};
function BlazorDevExtreme_DxScrollable_scrollToElement_10 (blazor_element, element) {
	DevExpress.ui.dxScrollable.getInstance(blazor_element).scrollToElement(element);
};
function BlazorDevExtreme_DxScrollable_scrollTop_11 (blazor_element) {
	return DevExpress.ui.dxScrollable.getInstance(blazor_element).scrollTop();
};
function BlazorDevExtreme_DxScrollable_scrollWidth_12 (blazor_element) {
	return DevExpress.ui.dxScrollable.getInstance(blazor_element).scrollWidth();
};
function BlazorDevExtreme_DxScrollable_update_13 (blazor_element) {
	return DevExpress.ui.dxScrollable.getInstance(blazor_element).update();
};
function BlazorDevExtreme_DxScrollable_SetOption (element, key, value) {
	DevExpress.ui.dxScrollable.getInstance(element).option(key, value);
};
function BlazorDevExtreme_DxScrollable_GetOption (element, key) {
	return DevExpress.ui.dxScrollable.getInstance(blazor_element).option(key);
};
// DevExpress.ui.dxSliderBase interop automatically generated
function BlazorDevExtreme_DxSliderBase_Init (element, optionsText) {
	const options = JSON.parse(optionsText);

	let instance = new DevExpress.ui.dxSliderBase(element, options);
}
function BlazorDevExtreme_DxSliderBase_SetOption (element, key, value) {
	DevExpress.ui.dxSliderBase.getInstance(element).option(key, value);
};
function BlazorDevExtreme_DxSliderBase_GetOption (element, key) {
	return DevExpress.ui.dxSliderBase.getInstance(blazor_element).option(key);
};
// DevExpress.ui.dxTextEditor interop automatically generated
function BlazorDevExtreme_DxTextEditor_Init (element, optionsText) {
	const options = JSON.parse(optionsText);

	if (options.onChangeEnabled) {
		options.onChange = function () {
			DotNet.invokeMethodAsync(assemblyName, 'DevExpress.Ui.DxTextEditorInterop.OnChange', element.id);
			
		}
	}
	if (options.onCopyEnabled) {
		options.onCopy = function () {
			DotNet.invokeMethodAsync(assemblyName, 'DevExpress.Ui.DxTextEditorInterop.OnCopy', element.id);
			
		}
	}
	if (options.onCutEnabled) {
		options.onCut = function () {
			DotNet.invokeMethodAsync(assemblyName, 'DevExpress.Ui.DxTextEditorInterop.OnCut', element.id);
			
		}
	}
	if (options.onEnterKeyEnabled) {
		options.onEnterKey = function () {
			DotNet.invokeMethodAsync(assemblyName, 'DevExpress.Ui.DxTextEditorInterop.OnEnterKey', element.id);
			
		}
	}
	if (options.onFocusInEnabled) {
		options.onFocusIn = function () {
			DotNet.invokeMethodAsync(assemblyName, 'DevExpress.Ui.DxTextEditorInterop.OnFocusIn', element.id);
			
		}
	}
	if (options.onFocusOutEnabled) {
		options.onFocusOut = function () {
			DotNet.invokeMethodAsync(assemblyName, 'DevExpress.Ui.DxTextEditorInterop.OnFocusOut', element.id);
			
		}
	}
	if (options.onInputEnabled) {
		options.onInput = function () {
			DotNet.invokeMethodAsync(assemblyName, 'DevExpress.Ui.DxTextEditorInterop.OnInput', element.id);
			
		}
	}
	if (options.onKeyDownEnabled) {
		options.onKeyDown = function () {
			DotNet.invokeMethodAsync(assemblyName, 'DevExpress.Ui.DxTextEditorInterop.OnKeyDown', element.id);
			
		}
	}
	if (options.onKeyPressEnabled) {
		options.onKeyPress = function () {
			DotNet.invokeMethodAsync(assemblyName, 'DevExpress.Ui.DxTextEditorInterop.OnKeyPress', element.id);
			
		}
	}
	if (options.onKeyUpEnabled) {
		options.onKeyUp = function () {
			DotNet.invokeMethodAsync(assemblyName, 'DevExpress.Ui.DxTextEditorInterop.OnKeyUp', element.id);
			
		}
	}
	if (options.onPasteEnabled) {
		options.onPaste = function () {
			DotNet.invokeMethodAsync(assemblyName, 'DevExpress.Ui.DxTextEditorInterop.OnPaste', element.id);
			
		}
	}
	let instance = new DevExpress.ui.dxTextEditor(element, options);
}
function BlazorDevExtreme_DxTextEditor_blur_0 (blazor_element) {
	DevExpress.ui.dxTextEditor.getInstance(blazor_element).blur();
};
function BlazorDevExtreme_DxTextEditor_focus_1 (blazor_element) {
	DevExpress.ui.dxTextEditor.getInstance(blazor_element).focus();
};
function BlazorDevExtreme_DxTextEditor_SetOption (element, key, value) {
	DevExpress.ui.dxTextEditor.getInstance(element).option(key, value);
};
function BlazorDevExtreme_DxTextEditor_GetOption (element, key) {
	return DevExpress.ui.dxTextEditor.getInstance(blazor_element).option(key);
};
// DevExpress.ui.SearchBoxMixin interop automatically generated
function BlazorDevExtreme_SearchBoxMixin_Init (element, optionsText) {
	const options = JSON.parse(optionsText);

	let instance = new DevExpress.ui.SearchBoxMixin(element, options);
}
function BlazorDevExtreme_SearchBoxMixin_SetOption (element, key, value) {
	DevExpress.ui.SearchBoxMixin.getInstance(element).option(key, value);
};
function BlazorDevExtreme_SearchBoxMixin_GetOption (element, key) {
	return DevExpress.ui.SearchBoxMixin.getInstance(blazor_element).option(key);
};
// DevExpress.ui.dxTemplate interop automatically generated
function BlazorDevExtreme_DxTemplate_Init (element, optionsText) {
	const options = JSON.parse(optionsText);

	let instance = new DevExpress.ui.dxTemplate(element, options);
}
function BlazorDevExtreme_DxTemplate_SetOption (element, key, value) {
	DevExpress.ui.dxTemplate.getInstance(element).option(key, value);
};
function BlazorDevExtreme_DxTemplate_GetOption (element, key) {
	return DevExpress.ui.dxTemplate.getInstance(blazor_element).option(key);
};
// DevExpress.ui.Widget interop automatically generated
function BlazorDevExtreme_Widget_Init (element, optionsText) {
	const options = JSON.parse(optionsText);

	if (options.onContentReadyEnabled) {
		options.onContentReady = function () {
			DotNet.invokeMethodAsync(assemblyName, 'DevExpress.Ui.WidgetInterop.OnContentReady', element.id);
			
		}
	}
	let instance = new DevExpress.ui.Widget(element, options);
}
function BlazorDevExtreme_Widget_focus_0 (blazor_element) {
	DevExpress.ui.Widget.getInstance(blazor_element).focus();
};
function BlazorDevExtreme_Widget_registerKeyHandler_1 (blazor_element, key, handler) {
	DevExpress.ui.Widget.getInstance(blazor_element).registerKeyHandler(key, handler);
};
function BlazorDevExtreme_Widget_repaint_2 (blazor_element) {
	DevExpress.ui.Widget.getInstance(blazor_element).repaint();
};
function BlazorDevExtreme_Widget_SetOption (element, key, value) {
	DevExpress.ui.Widget.getInstance(element).option(key, value);
};
function BlazorDevExtreme_Widget_GetOption (element, key) {
	return DevExpress.ui.Widget.getInstance(blazor_element).option(key);
};
// DevExpress.ui.dialog interop automatically generated
function BlazorDevExtreme_Dialog_alert_0 (message, title) {
	DevExpress.ui.dialog.alert(message, title);
};
function BlazorDevExtreme_Dialog_confirm_1 (message, title) {
	DevExpress.ui.dialog.confirm(message, title);
};
function BlazorDevExtreme_Dialog_custom_2 (options) {
	DevExpress.ui.dialog.custom(options);
};
function BlazorDevExtreme_Dialog_SetOption (element, key, value) {
	DevExpress.ui.dialog.getInstance(element).option(key, value);
};
function BlazorDevExtreme_Dialog_GetOption (element, key) {
	return DevExpress.ui.dialog.getInstance(blazor_element).option(key);
};
// DevExpress.ui.themes interop automatically generated
function BlazorDevExtreme_Themes_current_0 () {
	DevExpress.ui.themes.current();
};
function BlazorDevExtreme_Themes_current_1 (themeName) {
	DevExpress.ui.themes.current(themeName);
};
function BlazorDevExtreme_Themes_ready_2 (callback) {
	DevExpress.ui.themes.ready(callback);
};
function BlazorDevExtreme_Themes_SetOption (element, key, value) {
	DevExpress.ui.themes.getInstance(element).option(key, value);
};
function BlazorDevExtreme_Themes_GetOption (element, key) {
	return DevExpress.ui.themes.getInstance(blazor_element).option(key);
};
// DevExpress.viz.BaseWidget interop automatically generated
function BlazorDevExtreme_BaseWidget_Init (element, optionsText) {
	const options = JSON.parse(optionsText);

	if (options.onDrawnEnabled) {
		options.onDrawn = function () {
			DotNet.invokeMethodAsync(assemblyName, 'DevExpress.Viz.BaseWidgetInterop.OnDrawn', element.id);
			
		}
	}
	if (options.onExportedEnabled) {
		options.onExported = function () {
			DotNet.invokeMethodAsync(assemblyName, 'DevExpress.Viz.BaseWidgetInterop.OnExported', element.id);
			
		}
	}
	if (options.onExportingEnabled) {
		options.onExporting = function () {
			DotNet.invokeMethodAsync(assemblyName, 'DevExpress.Viz.BaseWidgetInterop.OnExporting', element.id);
			
		}
	}
	if (options.onFileSavingEnabled) {
		options.onFileSaving = function () {
			DotNet.invokeMethodAsync(assemblyName, 'DevExpress.Viz.BaseWidgetInterop.OnFileSaving', element.id);
			
		}
	}
	if (options.onIncidentOccurredEnabled) {
		options.onIncidentOccurred = function () {
			DotNet.invokeMethodAsync(assemblyName, 'DevExpress.Viz.BaseWidgetInterop.OnIncidentOccurred', element.id);
			
		}
	}
	let instance = new DevExpress.viz.BaseWidget(element, options);
}
function BlazorDevExtreme_BaseWidget_exportTo_0 (blazor_element, fileName, format) {
	DevExpress.viz.BaseWidget.getInstance(blazor_element).exportTo(fileName, format);
};
function BlazorDevExtreme_BaseWidget_getSize_1 (blazor_element) {
	return DevExpress.viz.BaseWidget.getInstance(blazor_element).getSize();
};
function BlazorDevExtreme_BaseWidget_hideLoadingIndicator_2 (blazor_element) {
	DevExpress.viz.BaseWidget.getInstance(blazor_element).hideLoadingIndicator();
};
function BlazorDevExtreme_BaseWidget_print_3 (blazor_element) {
	DevExpress.viz.BaseWidget.getInstance(blazor_element).print();
};
function BlazorDevExtreme_BaseWidget_render_4 (blazor_element) {
	DevExpress.viz.BaseWidget.getInstance(blazor_element).render();
};
function BlazorDevExtreme_BaseWidget_showLoadingIndicator_5 (blazor_element) {
	DevExpress.viz.BaseWidget.getInstance(blazor_element).showLoadingIndicator();
};
function BlazorDevExtreme_BaseWidget_svg_6 (blazor_element) {
	return DevExpress.viz.BaseWidget.getInstance(blazor_element).svg();
};
function BlazorDevExtreme_BaseWidget_SetOption (element, key, value) {
	DevExpress.viz.BaseWidget.getInstance(element).option(key, value);
};
function BlazorDevExtreme_BaseWidget_GetOption (element, key) {
	return DevExpress.viz.BaseWidget.getInstance(blazor_element).option(key);
};
// DevExpress.viz.dxChart interop automatically generated
function BlazorDevExtreme_DxChart_Init (element, optionsText) {
	const options = JSON.parse(optionsText);

	if (options.onArgumentAxisClickEnabled) {
		options.onArgumentAxisClick = function () {
			DotNet.invokeMethodAsync(assemblyName, 'DevExpress.Viz.DxChartInterop.OnArgumentAxisClick', element.id);
			
		}
	}
	if (options.onLegendClickEnabled) {
		options.onLegendClick = function () {
			DotNet.invokeMethodAsync(assemblyName, 'DevExpress.Viz.DxChartInterop.OnLegendClick', element.id);
			
		}
	}
	if (options.onSeriesClickEnabled) {
		options.onSeriesClick = function () {
			DotNet.invokeMethodAsync(assemblyName, 'DevExpress.Viz.DxChartInterop.OnSeriesClick', element.id);
			
		}
	}
	if (options.onSeriesHoverChangedEnabled) {
		options.onSeriesHoverChanged = function () {
			DotNet.invokeMethodAsync(assemblyName, 'DevExpress.Viz.DxChartInterop.OnSeriesHoverChanged', element.id);
			
		}
	}
	if (options.onSeriesSelectionChangedEnabled) {
		options.onSeriesSelectionChanged = function () {
			DotNet.invokeMethodAsync(assemblyName, 'DevExpress.Viz.DxChartInterop.OnSeriesSelectionChanged', element.id);
			
		}
	}
	if (options.onZoomEndEnabled) {
		options.onZoomEnd = function () {
			DotNet.invokeMethodAsync(assemblyName, 'DevExpress.Viz.DxChartInterop.OnZoomEnd', element.id);
			
		}
	}
	if (options.onZoomStartEnabled) {
		options.onZoomStart = function () {
			DotNet.invokeMethodAsync(assemblyName, 'DevExpress.Viz.DxChartInterop.OnZoomStart', element.id);
			
		}
	}
	let instance = new DevExpress.viz.dxChart(element, options);
}
function BlazorDevExtreme_DxChart_zoomArgument_0 (blazor_element, startValue, endValue) {
	DevExpress.viz.dxChart.getInstance(blazor_element).zoomArgument(startValue, endValue);
};
function BlazorDevExtreme_DxChart_SetOption (element, key, value) {
	DevExpress.viz.dxChart.getInstance(element).option(key, value);
};
function BlazorDevExtreme_DxChart_GetOption (element, key) {
	return DevExpress.viz.dxChart.getInstance(blazor_element).option(key);
};
// DevExpress.viz.dxPieChart interop automatically generated
function BlazorDevExtreme_DxPieChart_Init (element, optionsText) {
	const options = JSON.parse(optionsText);

	if (options.onLegendClickEnabled) {
		options.onLegendClick = function () {
			DotNet.invokeMethodAsync(assemblyName, 'DevExpress.Viz.DxPieChartInterop.OnLegendClick', element.id);
			
		}
	}
	let instance = new DevExpress.viz.dxPieChart(element, options);
}
function BlazorDevExtreme_DxPieChart_getSeries_0 (blazor_element) {
	return DevExpress.viz.dxPieChart.getInstance(blazor_element).getSeries();
};
function BlazorDevExtreme_DxPieChart_getSeriesByName_1 (blazor_element, seriesName) {
	return DevExpress.viz.dxPieChart.getInstance(blazor_element).getSeriesByName(seriesName);
};
function BlazorDevExtreme_DxPieChart_getSeriesByPos_2 (blazor_element, seriesIndex) {
	return DevExpress.viz.dxPieChart.getInstance(blazor_element).getSeriesByPos(seriesIndex);
};
function BlazorDevExtreme_DxPieChart_SetOption (element, key, value) {
	DevExpress.viz.dxPieChart.getInstance(element).option(key, value);
};
function BlazorDevExtreme_DxPieChart_GetOption (element, key) {
	return DevExpress.viz.dxPieChart.getInstance(blazor_element).option(key);
};
// DevExpress.viz.dxPolarChart interop automatically generated
function BlazorDevExtreme_DxPolarChart_Init (element, optionsText) {
	const options = JSON.parse(optionsText);

	if (options.onArgumentAxisClickEnabled) {
		options.onArgumentAxisClick = function () {
			DotNet.invokeMethodAsync(assemblyName, 'DevExpress.Viz.DxPolarChartInterop.OnArgumentAxisClick', element.id);
			
		}
	}
	if (options.onLegendClickEnabled) {
		options.onLegendClick = function () {
			DotNet.invokeMethodAsync(assemblyName, 'DevExpress.Viz.DxPolarChartInterop.OnLegendClick', element.id);
			
		}
	}
	if (options.onSeriesClickEnabled) {
		options.onSeriesClick = function () {
			DotNet.invokeMethodAsync(assemblyName, 'DevExpress.Viz.DxPolarChartInterop.OnSeriesClick', element.id);
			
		}
	}
	if (options.onSeriesHoverChangedEnabled) {
		options.onSeriesHoverChanged = function () {
			DotNet.invokeMethodAsync(assemblyName, 'DevExpress.Viz.DxPolarChartInterop.OnSeriesHoverChanged', element.id);
			
		}
	}
	if (options.onSeriesSelectionChangedEnabled) {
		options.onSeriesSelectionChanged = function () {
			DotNet.invokeMethodAsync(assemblyName, 'DevExpress.Viz.DxPolarChartInterop.OnSeriesSelectionChanged', element.id);
			
		}
	}
	let instance = new DevExpress.viz.dxPolarChart(element, options);
}
function BlazorDevExtreme_DxPolarChart_SetOption (element, key, value) {
	DevExpress.viz.dxPolarChart.getInstance(element).option(key, value);
};
function BlazorDevExtreme_DxPolarChart_GetOption (element, key) {
	return DevExpress.viz.dxPolarChart.getInstance(blazor_element).option(key);
};
// DevExpress.viz.BaseChart interop automatically generated
function BlazorDevExtreme_BaseChart_Init (element, optionsText) {
	const options = JSON.parse(optionsText);

	if (options.onDoneEnabled) {
		options.onDone = function () {
			DotNet.invokeMethodAsync(assemblyName, 'DevExpress.Viz.BaseChartInterop.OnDone', element.id);
			
		}
	}
	if (options.onPointClickEnabled) {
		options.onPointClick = function () {
			DotNet.invokeMethodAsync(assemblyName, 'DevExpress.Viz.BaseChartInterop.OnPointClick', element.id);
			
		}
	}
	if (options.onPointHoverChangedEnabled) {
		options.onPointHoverChanged = function () {
			DotNet.invokeMethodAsync(assemblyName, 'DevExpress.Viz.BaseChartInterop.OnPointHoverChanged', element.id);
			
		}
	}
	if (options.onPointSelectionChangedEnabled) {
		options.onPointSelectionChanged = function () {
			DotNet.invokeMethodAsync(assemblyName, 'DevExpress.Viz.BaseChartInterop.OnPointSelectionChanged', element.id);
			
		}
	}
	if (options.onTooltipHiddenEnabled) {
		options.onTooltipHidden = function () {
			DotNet.invokeMethodAsync(assemblyName, 'DevExpress.Viz.BaseChartInterop.OnTooltipHidden', element.id);
			
		}
	}
	if (options.onTooltipShownEnabled) {
		options.onTooltipShown = function () {
			DotNet.invokeMethodAsync(assemblyName, 'DevExpress.Viz.BaseChartInterop.OnTooltipShown', element.id);
			
		}
	}
	let instance = new DevExpress.viz.BaseChart(element, options);
}
function BlazorDevExtreme_BaseChart_clearSelection_0 (blazor_element) {
	DevExpress.viz.BaseChart.getInstance(blazor_element).clearSelection();
};
function BlazorDevExtreme_BaseChart_getAllSeries_1 (blazor_element) {
	return DevExpress.viz.BaseChart.getInstance(blazor_element).getAllSeries();
};
function BlazorDevExtreme_BaseChart_getDataSource_2 (blazor_element) {
	return DevExpress.viz.BaseChart.getInstance(blazor_element).getDataSource();
};
function BlazorDevExtreme_BaseChart_getSeriesByName_3 (blazor_element, seriesName) {
	return DevExpress.viz.BaseChart.getInstance(blazor_element).getSeriesByName(seriesName);
};
function BlazorDevExtreme_BaseChart_getSeriesByPos_4 (blazor_element, seriesIndex) {
	return DevExpress.viz.BaseChart.getInstance(blazor_element).getSeriesByPos(seriesIndex);
};
function BlazorDevExtreme_BaseChart_hideTooltip_5 (blazor_element) {
	DevExpress.viz.BaseChart.getInstance(blazor_element).hideTooltip();
};
function BlazorDevExtreme_BaseChart_render_6 (blazor_element) {
	DevExpress.viz.BaseChart.getInstance(blazor_element).render();
};
function BlazorDevExtreme_BaseChart_render_7 (blazor_element, renderOptions) {
	DevExpress.viz.BaseChart.getInstance(blazor_element).render(renderOptions);
};
function BlazorDevExtreme_BaseChart_SetOption (element, key, value) {
	DevExpress.viz.BaseChart.getInstance(element).option(key, value);
};
function BlazorDevExtreme_BaseChart_GetOption (element, key) {
	return DevExpress.viz.BaseChart.getInstance(blazor_element).option(key);
};
// DevExpress.viz.dxExporter interop automatically generated
function BlazorDevExtreme_DxExporter_Init (element, optionsText) {
	const options = JSON.parse(optionsText);

	let instance = new DevExpress.viz.dxExporter(element, options);
}
function BlazorDevExtreme_DxExporter_exportTo_0 (blazor_element, fileName, format) {
	DevExpress.viz.dxExporter.getInstance(blazor_element).exportTo(fileName, format);
};
function BlazorDevExtreme_DxExporter_print_1 (blazor_element) {
	DevExpress.viz.dxExporter.getInstance(blazor_element).print();
};
function BlazorDevExtreme_DxExporter_SetOption (element, key, value) {
	DevExpress.viz.dxExporter.getInstance(element).option(key, value);
};
function BlazorDevExtreme_DxExporter_GetOption (element, key) {
	return DevExpress.viz.dxExporter.getInstance(blazor_element).option(key);
};
// DevExpress.viz.dxFunnel interop automatically generated
function BlazorDevExtreme_DxFunnel_Init (element, optionsText) {
	const options = JSON.parse(optionsText);

	if (options.onHoverChangedEnabled) {
		options.onHoverChanged = function () {
			DotNet.invokeMethodAsync(assemblyName, 'DevExpress.Viz.DxFunnelInterop.OnHoverChanged', element.id);
			
		}
	}
	if (options.onItemClickEnabled) {
		options.onItemClick = function () {
			DotNet.invokeMethodAsync(assemblyName, 'DevExpress.Viz.DxFunnelInterop.OnItemClick', element.id);
			
		}
	}
	if (options.onLegendClickEnabled) {
		options.onLegendClick = function () {
			DotNet.invokeMethodAsync(assemblyName, 'DevExpress.Viz.DxFunnelInterop.OnLegendClick', element.id);
			
		}
	}
	if (options.onSelectionChangedEnabled) {
		options.onSelectionChanged = function () {
			DotNet.invokeMethodAsync(assemblyName, 'DevExpress.Viz.DxFunnelInterop.OnSelectionChanged', element.id);
			
		}
	}
	let instance = new DevExpress.viz.dxFunnel(element, options);
}
function BlazorDevExtreme_DxFunnel_clearSelection_0 (blazor_element) {
	DevExpress.viz.dxFunnel.getInstance(blazor_element).clearSelection();
};
function BlazorDevExtreme_DxFunnel_getAllItems_1 (blazor_element) {
	return DevExpress.viz.dxFunnel.getInstance(blazor_element).getAllItems();
};
function BlazorDevExtreme_DxFunnel_getDataSource_2 (blazor_element) {
	return DevExpress.viz.dxFunnel.getInstance(blazor_element).getDataSource();
};
function BlazorDevExtreme_DxFunnel_hideTooltip_3 (blazor_element) {
	DevExpress.viz.dxFunnel.getInstance(blazor_element).hideTooltip();
};
function BlazorDevExtreme_DxFunnel_SetOption (element, key, value) {
	DevExpress.viz.dxFunnel.getInstance(element).option(key, value);
};
function BlazorDevExtreme_DxFunnel_GetOption (element, key) {
	return DevExpress.viz.dxFunnel.getInstance(blazor_element).option(key);
};
// DevExpress.viz.BaseGauge interop automatically generated
function BlazorDevExtreme_BaseGauge_Init (element, optionsText) {
	const options = JSON.parse(optionsText);

	if (options.onTooltipHiddenEnabled) {
		options.onTooltipHidden = function () {
			DotNet.invokeMethodAsync(assemblyName, 'DevExpress.Viz.BaseGaugeInterop.OnTooltipHidden', element.id);
			
		}
	}
	if (options.onTooltipShownEnabled) {
		options.onTooltipShown = function () {
			DotNet.invokeMethodAsync(assemblyName, 'DevExpress.Viz.BaseGaugeInterop.OnTooltipShown', element.id);
			
		}
	}
	let instance = new DevExpress.viz.BaseGauge(element, options);
}
function BlazorDevExtreme_BaseGauge_subvalues_0 (blazor_element) {
	return DevExpress.viz.BaseGauge.getInstance(blazor_element).subvalues();
};
function BlazorDevExtreme_BaseGauge_subvalues_1 (blazor_element, subvalues) {
	DevExpress.viz.BaseGauge.getInstance(blazor_element).subvalues(subvalues);
};
function BlazorDevExtreme_BaseGauge_value_2 (blazor_element) {
	return DevExpress.viz.BaseGauge.getInstance(blazor_element).value();
};
function BlazorDevExtreme_BaseGauge_value_3 (blazor_element, value) {
	DevExpress.viz.BaseGauge.getInstance(blazor_element).value(value);
};
function BlazorDevExtreme_BaseGauge_SetOption (element, key, value) {
	DevExpress.viz.BaseGauge.getInstance(element).option(key, value);
};
function BlazorDevExtreme_BaseGauge_GetOption (element, key) {
	return DevExpress.viz.BaseGauge.getInstance(blazor_element).option(key);
};
// DevExpress.viz.dxCircularGauge interop automatically generated
function BlazorDevExtreme_DxCircularGauge_Init (element, optionsText) {
	const options = JSON.parse(optionsText);

	let instance = new DevExpress.viz.dxCircularGauge(element, options);
}
function BlazorDevExtreme_DxCircularGauge_SetOption (element, key, value) {
	DevExpress.viz.dxCircularGauge.getInstance(element).option(key, value);
};
function BlazorDevExtreme_DxCircularGauge_GetOption (element, key) {
	return DevExpress.viz.dxCircularGauge.getInstance(blazor_element).option(key);
};
// DevExpress.viz.dxLinearGauge interop automatically generated
function BlazorDevExtreme_DxLinearGauge_Init (element, optionsText) {
	const options = JSON.parse(optionsText);

	let instance = new DevExpress.viz.dxLinearGauge(element, options);
}
function BlazorDevExtreme_DxLinearGauge_SetOption (element, key, value) {
	DevExpress.viz.dxLinearGauge.getInstance(element).option(key, value);
};
function BlazorDevExtreme_DxLinearGauge_GetOption (element, key) {
	return DevExpress.viz.dxLinearGauge.getInstance(blazor_element).option(key);
};
// DevExpress.viz.dxBarGauge interop automatically generated
function BlazorDevExtreme_DxBarGauge_Init (element, optionsText) {
	const options = JSON.parse(optionsText);

	if (options.onTooltipHiddenEnabled) {
		options.onTooltipHidden = function () {
			DotNet.invokeMethodAsync(assemblyName, 'DevExpress.Viz.DxBarGaugeInterop.OnTooltipHidden', element.id);
			
		}
	}
	if (options.onTooltipShownEnabled) {
		options.onTooltipShown = function () {
			DotNet.invokeMethodAsync(assemblyName, 'DevExpress.Viz.DxBarGaugeInterop.OnTooltipShown', element.id);
			
		}
	}
	let instance = new DevExpress.viz.dxBarGauge(element, options);
}
function BlazorDevExtreme_DxBarGauge_values_0 (blazor_element) {
	return DevExpress.viz.dxBarGauge.getInstance(blazor_element).values();
};
function BlazorDevExtreme_DxBarGauge_values_1 (blazor_element, values) {
	DevExpress.viz.dxBarGauge.getInstance(blazor_element).values(values);
};
function BlazorDevExtreme_DxBarGauge_SetOption (element, key, value) {
	DevExpress.viz.dxBarGauge.getInstance(element).option(key, value);
};
function BlazorDevExtreme_DxBarGauge_GetOption (element, key) {
	return DevExpress.viz.dxBarGauge.getInstance(blazor_element).option(key);
};
// DevExpress.viz.baseSeriesObject interop automatically generated
function BlazorDevExtreme_BaseSeriesObject_clearHover_0 (blazor_element) {
	DevExpress.viz.baseSeriesObject.getInstance(blazor_element).clearHover();
};
function BlazorDevExtreme_BaseSeriesObject_clearSelection_1 (blazor_element) {
	DevExpress.viz.baseSeriesObject.getInstance(blazor_element).clearSelection();
};
function BlazorDevExtreme_BaseSeriesObject_deselectPoint_2 (blazor_element, point) {
	DevExpress.viz.baseSeriesObject.getInstance(blazor_element).deselectPoint(point);
};
function BlazorDevExtreme_BaseSeriesObject_getAllPoints_3 (blazor_element) {
	return DevExpress.viz.baseSeriesObject.getInstance(blazor_element).getAllPoints();
};
function BlazorDevExtreme_BaseSeriesObject_getColor_4 (blazor_element) {
	return DevExpress.viz.baseSeriesObject.getInstance(blazor_element).getColor();
};
function BlazorDevExtreme_BaseSeriesObject_getPointByPos_5 (blazor_element, positionIndex) {
	return DevExpress.viz.baseSeriesObject.getInstance(blazor_element).getPointByPos(positionIndex);
};
function BlazorDevExtreme_BaseSeriesObject_getPointsByArg_6 (blazor_element, pointArg) {
	return DevExpress.viz.baseSeriesObject.getInstance(blazor_element).getPointsByArg(pointArg);
};
function BlazorDevExtreme_BaseSeriesObject_getVisiblePoints_7 (blazor_element) {
	return DevExpress.viz.baseSeriesObject.getInstance(blazor_element).getVisiblePoints();
};
function BlazorDevExtreme_BaseSeriesObject_hide_8 (blazor_element) {
	DevExpress.viz.baseSeriesObject.getInstance(blazor_element).hide();
};
function BlazorDevExtreme_BaseSeriesObject_hover_9 (blazor_element) {
	DevExpress.viz.baseSeriesObject.getInstance(blazor_element).hover();
};
function BlazorDevExtreme_BaseSeriesObject_isHovered_10 (blazor_element) {
	return DevExpress.viz.baseSeriesObject.getInstance(blazor_element).isHovered();
};
function BlazorDevExtreme_BaseSeriesObject_isSelected_11 (blazor_element) {
	return DevExpress.viz.baseSeriesObject.getInstance(blazor_element).isSelected();
};
function BlazorDevExtreme_BaseSeriesObject_isVisible_12 (blazor_element) {
	return DevExpress.viz.baseSeriesObject.getInstance(blazor_element).isVisible();
};
function BlazorDevExtreme_BaseSeriesObject_select_13 (blazor_element) {
	DevExpress.viz.baseSeriesObject.getInstance(blazor_element).select();
};
function BlazorDevExtreme_BaseSeriesObject_selectPoint_14 (blazor_element, point) {
	DevExpress.viz.baseSeriesObject.getInstance(blazor_element).selectPoint(point);
};
function BlazorDevExtreme_BaseSeriesObject_show_15 (blazor_element) {
	DevExpress.viz.baseSeriesObject.getInstance(blazor_element).show();
};
function BlazorDevExtreme_BaseSeriesObject_SetOption (element, key, value) {
	DevExpress.viz.baseSeriesObject.getInstance(element).option(key, value);
};
function BlazorDevExtreme_BaseSeriesObject_GetOption (element, key) {
	return DevExpress.viz.baseSeriesObject.getInstance(blazor_element).option(key);
};
// DevExpress.viz.basePointObject interop automatically generated
function BlazorDevExtreme_BasePointObject_clearHover_0 (blazor_element) {
	DevExpress.viz.basePointObject.getInstance(blazor_element).clearHover();
};
function BlazorDevExtreme_BasePointObject_clearSelection_1 (blazor_element) {
	DevExpress.viz.basePointObject.getInstance(blazor_element).clearSelection();
};
function BlazorDevExtreme_BasePointObject_getColor_2 (blazor_element) {
	return DevExpress.viz.basePointObject.getInstance(blazor_element).getColor();
};
function BlazorDevExtreme_BasePointObject_getLabel_3 (blazor_element) {
	return DevExpress.viz.basePointObject.getInstance(blazor_element).getLabel();
};
function BlazorDevExtreme_BasePointObject_hideTooltip_4 (blazor_element) {
	DevExpress.viz.basePointObject.getInstance(blazor_element).hideTooltip();
};
function BlazorDevExtreme_BasePointObject_hover_5 (blazor_element) {
	DevExpress.viz.basePointObject.getInstance(blazor_element).hover();
};
function BlazorDevExtreme_BasePointObject_isHovered_6 (blazor_element) {
	return DevExpress.viz.basePointObject.getInstance(blazor_element).isHovered();
};
function BlazorDevExtreme_BasePointObject_isSelected_7 (blazor_element) {
	return DevExpress.viz.basePointObject.getInstance(blazor_element).isSelected();
};
function BlazorDevExtreme_BasePointObject_select_8 (blazor_element) {
	DevExpress.viz.basePointObject.getInstance(blazor_element).select();
};
function BlazorDevExtreme_BasePointObject_showTooltip_9 (blazor_element) {
	DevExpress.viz.basePointObject.getInstance(blazor_element).showTooltip();
};
function BlazorDevExtreme_BasePointObject_SetOption (element, key, value) {
	DevExpress.viz.basePointObject.getInstance(element).option(key, value);
};
function BlazorDevExtreme_BasePointObject_GetOption (element, key) {
	return DevExpress.viz.basePointObject.getInstance(blazor_element).option(key);
};
// DevExpress.viz.baseLabelObject interop automatically generated
function BlazorDevExtreme_BaseLabelObject_getBoundingRect_0 (blazor_element) {
	return DevExpress.viz.baseLabelObject.getInstance(blazor_element).getBoundingRect();
};
function BlazorDevExtreme_BaseLabelObject_hide_1 (blazor_element) {
	DevExpress.viz.baseLabelObject.getInstance(blazor_element).hide();
};
function BlazorDevExtreme_BaseLabelObject_hide_2 (blazor_element, holdInvisible) {
	DevExpress.viz.baseLabelObject.getInstance(blazor_element).hide(holdInvisible);
};
function BlazorDevExtreme_BaseLabelObject_isVisible_3 (blazor_element) {
	return DevExpress.viz.baseLabelObject.getInstance(blazor_element).isVisible();
};
function BlazorDevExtreme_BaseLabelObject_show_4 (blazor_element) {
	DevExpress.viz.baseLabelObject.getInstance(blazor_element).show();
};
function BlazorDevExtreme_BaseLabelObject_show_5 (blazor_element, holdVisible) {
	DevExpress.viz.baseLabelObject.getInstance(blazor_element).show(holdVisible);
};
function BlazorDevExtreme_BaseLabelObject_SetOption (element, key, value) {
	DevExpress.viz.baseLabelObject.getInstance(element).option(key, value);
};
function BlazorDevExtreme_BaseLabelObject_GetOption (element, key) {
	return DevExpress.viz.baseLabelObject.getInstance(blazor_element).option(key);
};
// DevExpress.viz.chartSeriesObject interop automatically generated
function BlazorDevExtreme_ChartSeriesObject_SetOption (element, key, value) {
	DevExpress.viz.chartSeriesObject.getInstance(element).option(key, value);
};
function BlazorDevExtreme_ChartSeriesObject_GetOption (element, key) {
	return DevExpress.viz.chartSeriesObject.getInstance(blazor_element).option(key);
};
// DevExpress.viz.chartPointObject interop automatically generated
function BlazorDevExtreme_ChartPointObject_getBoundingRect_0 (blazor_element) {
	return DevExpress.viz.chartPointObject.getInstance(blazor_element).getBoundingRect();
};
function BlazorDevExtreme_ChartPointObject_SetOption (element, key, value) {
	DevExpress.viz.chartPointObject.getInstance(element).option(key, value);
};
function BlazorDevExtreme_ChartPointObject_GetOption (element, key) {
	return DevExpress.viz.chartPointObject.getInstance(blazor_element).option(key);
};
// DevExpress.viz.dxFunnelItem interop automatically generated
function BlazorDevExtreme_DxFunnelItem_getColor_0 (blazor_element) {
	return DevExpress.viz.dxFunnelItem.getInstance(blazor_element).getColor();
};
function BlazorDevExtreme_DxFunnelItem_hover_1 (blazor_element, state) {
	DevExpress.viz.dxFunnelItem.getInstance(blazor_element).hover(state);
};
function BlazorDevExtreme_DxFunnelItem_isHovered_2 (blazor_element) {
	return DevExpress.viz.dxFunnelItem.getInstance(blazor_element).isHovered();
};
function BlazorDevExtreme_DxFunnelItem_isSelected_3 (blazor_element) {
	return DevExpress.viz.dxFunnelItem.getInstance(blazor_element).isSelected();
};
function BlazorDevExtreme_DxFunnelItem_select_4 (blazor_element, state) {
	DevExpress.viz.dxFunnelItem.getInstance(blazor_element).select(state);
};
function BlazorDevExtreme_DxFunnelItem_showTooltip_5 (blazor_element) {
	DevExpress.viz.dxFunnelItem.getInstance(blazor_element).showTooltip();
};
function BlazorDevExtreme_DxFunnelItem_SetOption (element, key, value) {
	DevExpress.viz.dxFunnelItem.getInstance(element).option(key, value);
};
function BlazorDevExtreme_DxFunnelItem_GetOption (element, key) {
	return DevExpress.viz.dxFunnelItem.getInstance(blazor_element).option(key);
};
// DevExpress.viz.piePointObject interop automatically generated
function BlazorDevExtreme_PiePointObject_hide_0 (blazor_element) {
	DevExpress.viz.piePointObject.getInstance(blazor_element).hide();
};
function BlazorDevExtreme_PiePointObject_hideTooltip_1 (blazor_element) {
	DevExpress.viz.piePointObject.getInstance(blazor_element).hideTooltip();
};
function BlazorDevExtreme_PiePointObject_isVisible_2 (blazor_element) {
	return DevExpress.viz.piePointObject.getInstance(blazor_element).isVisible();
};
function BlazorDevExtreme_PiePointObject_show_3 (blazor_element) {
	DevExpress.viz.piePointObject.getInstance(blazor_element).show();
};
function BlazorDevExtreme_PiePointObject_showTooltip_4 (blazor_element) {
	DevExpress.viz.piePointObject.getInstance(blazor_element).showTooltip();
};
function BlazorDevExtreme_PiePointObject_SetOption (element, key, value) {
	DevExpress.viz.piePointObject.getInstance(element).option(key, value);
};
function BlazorDevExtreme_PiePointObject_GetOption (element, key) {
	return DevExpress.viz.piePointObject.getInstance(blazor_element).option(key);
};
// DevExpress.viz.pieChartSeriesObject interop automatically generated
function BlazorDevExtreme_PieChartSeriesObject_SetOption (element, key, value) {
	DevExpress.viz.pieChartSeriesObject.getInstance(element).option(key, value);
};
function BlazorDevExtreme_PieChartSeriesObject_GetOption (element, key) {
	return DevExpress.viz.pieChartSeriesObject.getInstance(blazor_element).option(key);
};
// DevExpress.viz.polarChartSeriesObject interop automatically generated
function BlazorDevExtreme_PolarChartSeriesObject_SetOption (element, key, value) {
	DevExpress.viz.polarChartSeriesObject.getInstance(element).option(key, value);
};
function BlazorDevExtreme_PolarChartSeriesObject_GetOption (element, key) {
	return DevExpress.viz.polarChartSeriesObject.getInstance(blazor_element).option(key);
};
// DevExpress.viz.polarPointObject interop automatically generated
function BlazorDevExtreme_PolarPointObject_SetOption (element, key, value) {
	DevExpress.viz.polarPointObject.getInstance(element).option(key, value);
};
function BlazorDevExtreme_PolarPointObject_GetOption (element, key) {
	return DevExpress.viz.polarPointObject.getInstance(blazor_element).option(key);
};
// DevExpress.viz.dxTreeMapNode interop automatically generated
function BlazorDevExtreme_DxTreeMapNode_customize_0 (blazor_element, options) {
	DevExpress.viz.dxTreeMapNode.getInstance(blazor_element).customize(options);
};
function BlazorDevExtreme_DxTreeMapNode_drillDown_1 (blazor_element) {
	DevExpress.viz.dxTreeMapNode.getInstance(blazor_element).drillDown();
};
function BlazorDevExtreme_DxTreeMapNode_getAllChildren_2 (blazor_element) {
	return DevExpress.viz.dxTreeMapNode.getInstance(blazor_element).getAllChildren();
};
function BlazorDevExtreme_DxTreeMapNode_getAllNodes_3 (blazor_element) {
	return DevExpress.viz.dxTreeMapNode.getInstance(blazor_element).getAllNodes();
};
function BlazorDevExtreme_DxTreeMapNode_getChild_4 (blazor_element, index) {
	return DevExpress.viz.dxTreeMapNode.getInstance(blazor_element).getChild(index);
};
function BlazorDevExtreme_DxTreeMapNode_getChildrenCount_5 (blazor_element) {
	return DevExpress.viz.dxTreeMapNode.getInstance(blazor_element).getChildrenCount();
};
function BlazorDevExtreme_DxTreeMapNode_getParent_6 (blazor_element) {
	return DevExpress.viz.dxTreeMapNode.getInstance(blazor_element).getParent();
};
function BlazorDevExtreme_DxTreeMapNode_isActive_7 (blazor_element) {
	return DevExpress.viz.dxTreeMapNode.getInstance(blazor_element).isActive();
};
function BlazorDevExtreme_DxTreeMapNode_isHovered_8 (blazor_element) {
	return DevExpress.viz.dxTreeMapNode.getInstance(blazor_element).isHovered();
};
function BlazorDevExtreme_DxTreeMapNode_isLeaf_9 (blazor_element) {
	return DevExpress.viz.dxTreeMapNode.getInstance(blazor_element).isLeaf();
};
function BlazorDevExtreme_DxTreeMapNode_isSelected_10 (blazor_element) {
	return DevExpress.viz.dxTreeMapNode.getInstance(blazor_element).isSelected();
};
function BlazorDevExtreme_DxTreeMapNode_label_11 (blazor_element) {
	return DevExpress.viz.dxTreeMapNode.getInstance(blazor_element).label();
};
function BlazorDevExtreme_DxTreeMapNode_label_12 (blazor_element, label) {
	DevExpress.viz.dxTreeMapNode.getInstance(blazor_element).label(label);
};
function BlazorDevExtreme_DxTreeMapNode_resetCustomization_13 (blazor_element) {
	DevExpress.viz.dxTreeMapNode.getInstance(blazor_element).resetCustomization();
};
function BlazorDevExtreme_DxTreeMapNode_select_14 (blazor_element, state) {
	DevExpress.viz.dxTreeMapNode.getInstance(blazor_element).select(state);
};
function BlazorDevExtreme_DxTreeMapNode_showTooltip_15 (blazor_element) {
	DevExpress.viz.dxTreeMapNode.getInstance(blazor_element).showTooltip();
};
function BlazorDevExtreme_DxTreeMapNode_value_16 (blazor_element) {
	return DevExpress.viz.dxTreeMapNode.getInstance(blazor_element).value();
};
function BlazorDevExtreme_DxTreeMapNode_SetOption (element, key, value) {
	DevExpress.viz.dxTreeMapNode.getInstance(element).option(key, value);
};
function BlazorDevExtreme_DxTreeMapNode_GetOption (element, key) {
	return DevExpress.viz.dxTreeMapNode.getInstance(blazor_element).option(key);
};
// DevExpress.viz.MapLayer interop automatically generated
function BlazorDevExtreme_MapLayer_clearSelection_0 (blazor_element) {
	DevExpress.viz.MapLayer.getInstance(blazor_element).clearSelection();
};
function BlazorDevExtreme_MapLayer_getDataSource_1 (blazor_element) {
	return DevExpress.viz.MapLayer.getInstance(blazor_element).getDataSource();
};
function BlazorDevExtreme_MapLayer_getElements_2 (blazor_element) {
	return DevExpress.viz.MapLayer.getInstance(blazor_element).getElements();
};
function BlazorDevExtreme_MapLayer_SetOption (element, key, value) {
	DevExpress.viz.MapLayer.getInstance(element).option(key, value);
};
function BlazorDevExtreme_MapLayer_GetOption (element, key) {
	return DevExpress.viz.MapLayer.getInstance(blazor_element).option(key);
};
// DevExpress.viz.MapLayerElement interop automatically generated
function BlazorDevExtreme_MapLayerElement_applySettings_0 (blazor_element, settings) {
	DevExpress.viz.MapLayerElement.getInstance(blazor_element).applySettings(settings);
};
function BlazorDevExtreme_MapLayerElement_attribute_1 (blazor_element, name) {
	return DevExpress.viz.MapLayerElement.getInstance(blazor_element).attribute(name);
};
function BlazorDevExtreme_MapLayerElement_attribute_2 (blazor_element, name, value) {
	DevExpress.viz.MapLayerElement.getInstance(blazor_element).attribute(name, value);
};
function BlazorDevExtreme_MapLayerElement_coordinates_3 (blazor_element) {
	return DevExpress.viz.MapLayerElement.getInstance(blazor_element).coordinates();
};
function BlazorDevExtreme_MapLayerElement_selected_4 (blazor_element) {
	return DevExpress.viz.MapLayerElement.getInstance(blazor_element).selected();
};
function BlazorDevExtreme_MapLayerElement_selected_5 (blazor_element, state) {
	DevExpress.viz.MapLayerElement.getInstance(blazor_element).selected(state);
};
function BlazorDevExtreme_MapLayerElement_SetOption (element, key, value) {
	DevExpress.viz.MapLayerElement.getInstance(element).option(key, value);
};
function BlazorDevExtreme_MapLayerElement_GetOption (element, key) {
	return DevExpress.viz.MapLayerElement.getInstance(blazor_element).option(key);
};
// DevExpress.viz.areaObjects interop automatically generated
function BlazorDevExtreme_AreaObjects_applySettings_0 (blazor_element, settings) {
	DevExpress.viz.areaObjects.getInstance(blazor_element).applySettings(settings);
};
function BlazorDevExtreme_AreaObjects_attribute_1 (blazor_element, name) {
	return DevExpress.viz.areaObjects.getInstance(blazor_element).attribute(name);
};
function BlazorDevExtreme_AreaObjects_selected_2 (blazor_element) {
	return DevExpress.viz.areaObjects.getInstance(blazor_element).selected();
};
function BlazorDevExtreme_AreaObjects_selected_3 (blazor_element, state) {
	DevExpress.viz.areaObjects.getInstance(blazor_element).selected(state);
};
function BlazorDevExtreme_AreaObjects_SetOption (element, key, value) {
	DevExpress.viz.areaObjects.getInstance(element).option(key, value);
};
function BlazorDevExtreme_AreaObjects_GetOption (element, key) {
	return DevExpress.viz.areaObjects.getInstance(blazor_element).option(key);
};
// DevExpress.viz.markerObjects interop automatically generated
function BlazorDevExtreme_MarkerObjects_applySettings_0 (blazor_element, settings) {
	DevExpress.viz.markerObjects.getInstance(blazor_element).applySettings(settings);
};
function BlazorDevExtreme_MarkerObjects_attribute_1 (blazor_element, name) {
	return DevExpress.viz.markerObjects.getInstance(blazor_element).attribute(name);
};
function BlazorDevExtreme_MarkerObjects_coordinates_2 (blazor_element) {
	return DevExpress.viz.markerObjects.getInstance(blazor_element).coordinates();
};
function BlazorDevExtreme_MarkerObjects_selected_3 (blazor_element) {
	return DevExpress.viz.markerObjects.getInstance(blazor_element).selected();
};
function BlazorDevExtreme_MarkerObjects_selected_4 (blazor_element, state) {
	DevExpress.viz.markerObjects.getInstance(blazor_element).selected(state);
};
function BlazorDevExtreme_MarkerObjects_SetOption (element, key, value) {
	DevExpress.viz.markerObjects.getInstance(element).option(key, value);
};
function BlazorDevExtreme_MarkerObjects_GetOption (element, key) {
	return DevExpress.viz.markerObjects.getInstance(blazor_element).option(key);
};
// DevExpress.viz.dxRangeSelector interop automatically generated
function BlazorDevExtreme_DxRangeSelector_Init (element, optionsText) {
	const options = JSON.parse(optionsText);

	if (options.onSelectedRangeChangedEnabled) {
		options.onSelectedRangeChanged = function () {
			DotNet.invokeMethodAsync(assemblyName, 'DevExpress.Viz.DxRangeSelectorInterop.OnSelectedRangeChanged', element.id);
			
		}
	}
	if (options.onValueChangedEnabled) {
		options.onValueChanged = function () {
			DotNet.invokeMethodAsync(assemblyName, 'DevExpress.Viz.DxRangeSelectorInterop.OnValueChanged', element.id);
			
		}
	}
	let instance = new DevExpress.viz.dxRangeSelector(element, options);
}
function BlazorDevExtreme_DxRangeSelector_getDataSource_0 (blazor_element) {
	return DevExpress.viz.dxRangeSelector.getInstance(blazor_element).getDataSource();
};
function BlazorDevExtreme_DxRangeSelector_getSelectedRange_1 (blazor_element) {
	return DevExpress.viz.dxRangeSelector.getInstance(blazor_element).getSelectedRange();
};
function BlazorDevExtreme_DxRangeSelector_getValue_2 (blazor_element) {
	return DevExpress.viz.dxRangeSelector.getInstance(blazor_element).getValue();
};
function BlazorDevExtreme_DxRangeSelector_render_3 (blazor_element) {
	DevExpress.viz.dxRangeSelector.getInstance(blazor_element).render();
};
function BlazorDevExtreme_DxRangeSelector_render_4 (blazor_element, skipChartAnimation) {
	DevExpress.viz.dxRangeSelector.getInstance(blazor_element).render(skipChartAnimation);
};
function BlazorDevExtreme_DxRangeSelector_setSelectedRange_5 (blazor_element, selectedRange) {
	DevExpress.viz.dxRangeSelector.getInstance(blazor_element).setSelectedRange(selectedRange);
};
function BlazorDevExtreme_DxRangeSelector_setValue_6 (blazor_element, value) {
	DevExpress.viz.dxRangeSelector.getInstance(blazor_element).setValue(value);
};
function BlazorDevExtreme_DxRangeSelector_SetOption (element, key, value) {
	DevExpress.viz.dxRangeSelector.getInstance(element).option(key, value);
};
function BlazorDevExtreme_DxRangeSelector_GetOption (element, key) {
	return DevExpress.viz.dxRangeSelector.getInstance(blazor_element).option(key);
};
// DevExpress.viz.BaseSparkline interop automatically generated
function BlazorDevExtreme_BaseSparkline_Init (element, optionsText) {
	const options = JSON.parse(optionsText);

	if (options.onTooltipHiddenEnabled) {
		options.onTooltipHidden = function () {
			DotNet.invokeMethodAsync(assemblyName, 'DevExpress.Viz.BaseSparklineInterop.OnTooltipHidden', element.id);
			
		}
	}
	if (options.onTooltipShownEnabled) {
		options.onTooltipShown = function () {
			DotNet.invokeMethodAsync(assemblyName, 'DevExpress.Viz.BaseSparklineInterop.OnTooltipShown', element.id);
			
		}
	}
	let instance = new DevExpress.viz.BaseSparkline(element, options);
}
function BlazorDevExtreme_BaseSparkline_SetOption (element, key, value) {
	DevExpress.viz.BaseSparkline.getInstance(element).option(key, value);
};
function BlazorDevExtreme_BaseSparkline_GetOption (element, key) {
	return DevExpress.viz.BaseSparkline.getInstance(blazor_element).option(key);
};
// DevExpress.viz.dxSparkline interop automatically generated
function BlazorDevExtreme_DxSparkline_Init (element, optionsText) {
	const options = JSON.parse(optionsText);

	let instance = new DevExpress.viz.dxSparkline(element, options);
}
function BlazorDevExtreme_DxSparkline_getDataSource_0 (blazor_element) {
	return DevExpress.viz.dxSparkline.getInstance(blazor_element).getDataSource();
};
function BlazorDevExtreme_DxSparkline_SetOption (element, key, value) {
	DevExpress.viz.dxSparkline.getInstance(element).option(key, value);
};
function BlazorDevExtreme_DxSparkline_GetOption (element, key) {
	return DevExpress.viz.dxSparkline.getInstance(blazor_element).option(key);
};
// DevExpress.viz.dxBullet interop automatically generated
function BlazorDevExtreme_DxBullet_Init (element, optionsText) {
	const options = JSON.parse(optionsText);

	let instance = new DevExpress.viz.dxBullet(element, options);
}
function BlazorDevExtreme_DxBullet_SetOption (element, key, value) {
	DevExpress.viz.dxBullet.getInstance(element).option(key, value);
};
function BlazorDevExtreme_DxBullet_GetOption (element, key) {
	return DevExpress.viz.dxBullet.getInstance(blazor_element).option(key);
};
// DevExpress.viz.dxTreeMap interop automatically generated
function BlazorDevExtreme_DxTreeMap_Init (element, optionsText) {
	const options = JSON.parse(optionsText);

	if (options.onClickEnabled) {
		options.onClick = function () {
			DotNet.invokeMethodAsync(assemblyName, 'DevExpress.Viz.DxTreeMapInterop.OnClick', element.id);
			
		}
	}
	if (options.onDrillEnabled) {
		options.onDrill = function () {
			DotNet.invokeMethodAsync(assemblyName, 'DevExpress.Viz.DxTreeMapInterop.OnDrill', element.id);
			
		}
	}
	if (options.onHoverChangedEnabled) {
		options.onHoverChanged = function () {
			DotNet.invokeMethodAsync(assemblyName, 'DevExpress.Viz.DxTreeMapInterop.OnHoverChanged', element.id);
			
		}
	}
	if (options.onNodesInitializedEnabled) {
		options.onNodesInitialized = function () {
			DotNet.invokeMethodAsync(assemblyName, 'DevExpress.Viz.DxTreeMapInterop.OnNodesInitialized', element.id);
			
		}
	}
	if (options.onNodesRenderingEnabled) {
		options.onNodesRendering = function () {
			DotNet.invokeMethodAsync(assemblyName, 'DevExpress.Viz.DxTreeMapInterop.OnNodesRendering', element.id);
			
		}
	}
	if (options.onSelectionChangedEnabled) {
		options.onSelectionChanged = function () {
			DotNet.invokeMethodAsync(assemblyName, 'DevExpress.Viz.DxTreeMapInterop.OnSelectionChanged', element.id);
			
		}
	}
	let instance = new DevExpress.viz.dxTreeMap(element, options);
}
function BlazorDevExtreme_DxTreeMap_clearSelection_0 (blazor_element) {
	DevExpress.viz.dxTreeMap.getInstance(blazor_element).clearSelection();
};
function BlazorDevExtreme_DxTreeMap_drillUp_1 (blazor_element) {
	DevExpress.viz.dxTreeMap.getInstance(blazor_element).drillUp();
};
function BlazorDevExtreme_DxTreeMap_getCurrentNode_2 (blazor_element) {
	return DevExpress.viz.dxTreeMap.getInstance(blazor_element).getCurrentNode();
};
function BlazorDevExtreme_DxTreeMap_getDataSource_3 (blazor_element) {
	return DevExpress.viz.dxTreeMap.getInstance(blazor_element).getDataSource();
};
function BlazorDevExtreme_DxTreeMap_getRootNode_4 (blazor_element) {
	return DevExpress.viz.dxTreeMap.getInstance(blazor_element).getRootNode();
};
function BlazorDevExtreme_DxTreeMap_hideTooltip_5 (blazor_element) {
	DevExpress.viz.dxTreeMap.getInstance(blazor_element).hideTooltip();
};
function BlazorDevExtreme_DxTreeMap_resetDrillDown_6 (blazor_element) {
	DevExpress.viz.dxTreeMap.getInstance(blazor_element).resetDrillDown();
};
function BlazorDevExtreme_DxTreeMap_SetOption (element, key, value) {
	DevExpress.viz.dxTreeMap.getInstance(element).option(key, value);
};
function BlazorDevExtreme_DxTreeMap_GetOption (element, key) {
	return DevExpress.viz.dxTreeMap.getInstance(blazor_element).option(key);
};
// DevExpress.viz.dxVectorMap interop automatically generated
function BlazorDevExtreme_DxVectorMap_Init (element, optionsText) {
	const options = JSON.parse(optionsText);

	if (options.onAreaClickEnabled) {
		options.onAreaClick = function () {
			DotNet.invokeMethodAsync(assemblyName, 'DevExpress.Viz.DxVectorMapInterop.OnAreaClick', element.id);
			
		}
	}
	if (options.onAreaSelectionChangedEnabled) {
		options.onAreaSelectionChanged = function () {
			DotNet.invokeMethodAsync(assemblyName, 'DevExpress.Viz.DxVectorMapInterop.OnAreaSelectionChanged', element.id);
			
		}
	}
	if (options.onCenterChangedEnabled) {
		options.onCenterChanged = function () {
			DotNet.invokeMethodAsync(assemblyName, 'DevExpress.Viz.DxVectorMapInterop.OnCenterChanged', element.id);
			
		}
	}
	if (options.onClickEnabled) {
		options.onClick = function () {
			DotNet.invokeMethodAsync(assemblyName, 'DevExpress.Viz.DxVectorMapInterop.OnClick', element.id);
			
		}
	}
	if (options.onMarkerClickEnabled) {
		options.onMarkerClick = function () {
			DotNet.invokeMethodAsync(assemblyName, 'DevExpress.Viz.DxVectorMapInterop.OnMarkerClick', element.id);
			
		}
	}
	if (options.onMarkerSelectionChangedEnabled) {
		options.onMarkerSelectionChanged = function () {
			DotNet.invokeMethodAsync(assemblyName, 'DevExpress.Viz.DxVectorMapInterop.OnMarkerSelectionChanged', element.id);
			
		}
	}
	if (options.onSelectionChangedEnabled) {
		options.onSelectionChanged = function () {
			DotNet.invokeMethodAsync(assemblyName, 'DevExpress.Viz.DxVectorMapInterop.OnSelectionChanged', element.id);
			
		}
	}
	if (options.onTooltipHiddenEnabled) {
		options.onTooltipHidden = function () {
			DotNet.invokeMethodAsync(assemblyName, 'DevExpress.Viz.DxVectorMapInterop.OnTooltipHidden', element.id);
			
		}
	}
	if (options.onTooltipShownEnabled) {
		options.onTooltipShown = function () {
			DotNet.invokeMethodAsync(assemblyName, 'DevExpress.Viz.DxVectorMapInterop.OnTooltipShown', element.id);
			
		}
	}
	if (options.onZoomFactorChangedEnabled) {
		options.onZoomFactorChanged = function () {
			DotNet.invokeMethodAsync(assemblyName, 'DevExpress.Viz.DxVectorMapInterop.OnZoomFactorChanged', element.id);
			
		}
	}
	let instance = new DevExpress.viz.dxVectorMap(element, options);
}
function BlazorDevExtreme_DxVectorMap_center_0 (blazor_element) {
	return DevExpress.viz.dxVectorMap.getInstance(blazor_element).center();
};
function BlazorDevExtreme_DxVectorMap_center_1 (blazor_element, centerCoordinates) {
	DevExpress.viz.dxVectorMap.getInstance(blazor_element).center(centerCoordinates);
};
function BlazorDevExtreme_DxVectorMap_clearAreaSelection_2 (blazor_element) {
	DevExpress.viz.dxVectorMap.getInstance(blazor_element).clearAreaSelection();
};
function BlazorDevExtreme_DxVectorMap_clearMarkerSelection_3 (blazor_element) {
	DevExpress.viz.dxVectorMap.getInstance(blazor_element).clearMarkerSelection();
};
function BlazorDevExtreme_DxVectorMap_clearSelection_4 (blazor_element) {
	DevExpress.viz.dxVectorMap.getInstance(blazor_element).clearSelection();
};
function BlazorDevExtreme_DxVectorMap_convertCoordinates_5 (blazor_element, x, y) {
	return DevExpress.viz.dxVectorMap.getInstance(blazor_element).convertCoordinates(x, y);
};
function BlazorDevExtreme_DxVectorMap_getAreas_6 (blazor_element) {
	return DevExpress.viz.dxVectorMap.getInstance(blazor_element).getAreas();
};
function BlazorDevExtreme_DxVectorMap_getLayerByIndex_7 (blazor_element, index) {
	return DevExpress.viz.dxVectorMap.getInstance(blazor_element).getLayerByIndex(index);
};
function BlazorDevExtreme_DxVectorMap_getLayerByName_8 (blazor_element, name) {
	return DevExpress.viz.dxVectorMap.getInstance(blazor_element).getLayerByName(name);
};
function BlazorDevExtreme_DxVectorMap_getLayers_9 (blazor_element) {
	return DevExpress.viz.dxVectorMap.getInstance(blazor_element).getLayers();
};
function BlazorDevExtreme_DxVectorMap_getMarkers_10 (blazor_element) {
	return DevExpress.viz.dxVectorMap.getInstance(blazor_element).getMarkers();
};
function BlazorDevExtreme_DxVectorMap_viewport_11 (blazor_element) {
	return DevExpress.viz.dxVectorMap.getInstance(blazor_element).viewport();
};
function BlazorDevExtreme_DxVectorMap_viewport_12 (blazor_element, viewportCoordinates) {
	DevExpress.viz.dxVectorMap.getInstance(blazor_element).viewport(viewportCoordinates);
};
function BlazorDevExtreme_DxVectorMap_zoomFactor_13 (blazor_element) {
	return DevExpress.viz.dxVectorMap.getInstance(blazor_element).zoomFactor();
};
function BlazorDevExtreme_DxVectorMap_zoomFactor_14 (blazor_element, zoomFactor) {
	DevExpress.viz.dxVectorMap.getInstance(blazor_element).zoomFactor(zoomFactor);
};
function BlazorDevExtreme_DxVectorMap_SetOption (element, key, value) {
	DevExpress.viz.dxVectorMap.getInstance(element).option(key, value);
};
function BlazorDevExtreme_DxVectorMap_GetOption (element, key) {
	return DevExpress.viz.dxVectorMap.getInstance(blazor_element).option(key);
};
// DevExpress.viz.core interop automatically generated
function BlazorDevExtreme_Core_currentPalette_0 (paletteName) {
	DevExpress.viz.core.currentPalette(paletteName);
};
function BlazorDevExtreme_Core_currentTheme_1 (platform, colorScheme) {
	DevExpress.viz.core.currentTheme(platform, colorScheme);
};
function BlazorDevExtreme_Core_currentTheme_2 (theme) {
	DevExpress.viz.core.currentTheme(theme);
};
function BlazorDevExtreme_Core_getPalette_3 (paletteName) {
	DevExpress.viz.core.getPalette(paletteName);
};
function BlazorDevExtreme_Core_registerPalette_4 (paletteName, palette) {
	DevExpress.viz.core.registerPalette(paletteName, palette);
};
function BlazorDevExtreme_Core_registerTheme_5 (customTheme, baseTheme) {
	DevExpress.viz.core.registerTheme(customTheme, baseTheme);
};
function BlazorDevExtreme_Core_SetOption (element, key, value) {
	DevExpress.viz.core.getInstance(element).option(key, value);
};
function BlazorDevExtreme_Core_GetOption (element, key) {
	return DevExpress.viz.core.getInstance(blazor_element).option(key);
};
