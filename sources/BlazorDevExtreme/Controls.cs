using Microsoft.AspNetCore.Blazor.Browser.Interop;
using System;
using BlazorDevExtreme;
using Microsoft.AspNetCore.Blazor;

namespace DevExpress
{
	public class DataHelperMixinInterop
	{
		public static object GetDataSourceEx(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DataHelperMixin.getDataSource_0", dxTarget);
		}
	}
	public class DxEventInterop
	{
		public static bool IsDefaultPrevented(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool>("BlazorDevExtreme.DxEvent.isDefaultPrevented_0", dxTarget);
		}
		public static bool IsImmediatePropagationStopped(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool>("BlazorDevExtreme.DxEvent.isImmediatePropagationStopped_1", dxTarget);
		}
		public static bool IsPropagationStopped(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool>("BlazorDevExtreme.DxEvent.isPropagationStopped_2", dxTarget);
		}
		public static void PreventDefault(ElementRef dxTarget)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxEvent.preventDefault_3", dxTarget);
		}
		public static void StopImmediatePropagation(ElementRef dxTarget)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxEvent.stopImmediatePropagation_4", dxTarget);
		}
		public static void StopPropagation(ElementRef dxTarget)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxEvent.stopPropagation_5", dxTarget);
		}
	}
	public class LocalizationInterop
	{
		public static void LoadMessages(object messages)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.Localization.loadMessages_0", messages);
		}
		public static string Locale()
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.Localization.locale_1");
		}
		public static void Locale(string locale)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.Localization.locale_2", locale);
		}
	}
	public class AnimationPresetsInterop
	{
		public static void ApplyChanges(ElementRef dxTarget)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.AnimationPresets.applyChanges_0", dxTarget);
		}
		public static void Clear(ElementRef dxTarget)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.AnimationPresets.clear_1", dxTarget);
		}
		public static void Clear(ElementRef dxTarget, string name)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.AnimationPresets.clear_2", dxTarget, name);
		}
		public static object GetPreset(ElementRef dxTarget, string name)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.AnimationPresets.getPreset_3", dxTarget, name);
		}
		public static void RegisterDefaultPresets(ElementRef dxTarget)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.AnimationPresets.registerDefaultPresets_4", dxTarget);
		}
		public static void RegisterPreset(ElementRef dxTarget, string name, object config)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.AnimationPresets.registerPreset_5", dxTarget, name, config);
		}
		public static void ResetToDefaults(ElementRef dxTarget)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.AnimationPresets.resetToDefaults_6", dxTarget);
		}
	}
	public class TransitionExecutorInterop
	{
		public static void Enter(ElementRef dxTarget, object elements, object animation)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.TransitionExecutor.enter_0", dxTarget, elements, animation);
		}
		public static void Leave(ElementRef dxTarget, object elements, object animation)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.TransitionExecutor.leave_1", dxTarget, elements, animation);
		}
		public static void Reset(ElementRef dxTarget)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.TransitionExecutor.reset_2", dxTarget);
		}
		public static object Start(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.TransitionExecutor.start_3", dxTarget);
		}
		public static void Stop(ElementRef dxTarget)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.TransitionExecutor.stop_4", dxTarget);
		}
	}
	public class ComponentInterop
	{
		public static event EventHandler<JQueryEventArgs> Disposing;
		public static event EventHandler<JQueryEventArgs> Initialized;
		public static event EventHandler<JQueryEventArgs> OptionChanged;
		public static void Init(ElementRef dxTarget, DevExpress.ComponentOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.Component.Init", dxTarget, json);
		}
		public static void OnDisposing(string identifier)
		{
			Disposing?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static void OnInitialized(string identifier)
		{
			Initialized?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static void OnOptionChanged(string identifier)
		{
			OptionChanged?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static void BeginUpdate(ElementRef dxTarget)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.Component.beginUpdate_0", dxTarget);
		}
		public static void EndUpdate(ElementRef dxTarget)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.Component.endUpdate_1", dxTarget);
		}
		public static object Instance(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.Component.instance_2", dxTarget);
		}
		public static object Off(ElementRef dxTarget, string eventName)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.Component.off_3", dxTarget, eventName);
		}
		public static object Off(ElementRef dxTarget, string eventName, object eventHandler)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.Component.off_4", dxTarget, eventName, eventHandler);
		}
		public static object On(ElementRef dxTarget, string eventName, object eventHandler)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.Component.on_5", dxTarget, eventName, eventHandler);
		}
		public static object On(ElementRef dxTarget, object events)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.Component.on_6", dxTarget, events);
		}
		public static object Option(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.Component.option_7", dxTarget);
		}
		public static object Option(ElementRef dxTarget, string optionName)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.Component.option_8", dxTarget, optionName);
		}
		public static void Option(ElementRef dxTarget, string optionName, object optionValue)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.Component.option_9", dxTarget, optionName, optionValue);
		}
		public static void Option(ElementRef dxTarget, object options)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.Component.option_10", dxTarget, options);
		}
	}
	public class DevicesObjectInterop
	{
		public static object Current(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DevicesObject.current_0", dxTarget);
		}
		public static void Current(ElementRef dxTarget, object deviceName)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DevicesObject.current_1", dxTarget, deviceName);
		}
		public static object Off(ElementRef dxTarget, string eventName)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DevicesObject.off_2", dxTarget, eventName);
		}
		public static object Off(ElementRef dxTarget, string eventName, object eventHandler)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DevicesObject.off_3", dxTarget, eventName, eventHandler);
		}
		public static object On(ElementRef dxTarget, string eventName, object eventHandler)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DevicesObject.on_4", dxTarget, eventName, eventHandler);
		}
		public static object On(ElementRef dxTarget, object events)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DevicesObject.on_5", dxTarget, events);
		}
		public static string Orientation(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DevicesObject.orientation_6", dxTarget);
		}
		public static object Real(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DevicesObject.real_7", dxTarget);
		}
	}
	public class DOMComponentInterop: ComponentInterop
	{
		public static event EventHandler<JQueryEventArgs> Disposing;
		public static event EventHandler<JQueryEventArgs> OptionChanged;
		public static void Init(ElementRef dxTarget, DevExpress.DOMComponentOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DOMComponent.Init", dxTarget, json);
		}
		public static void OnDisposing(string identifier)
		{
			Disposing?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static void OnOptionChanged(string identifier)
		{
			OptionChanged?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static object GetBindingOptions(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DOMComponent.GetOption", dxTarget, "bindingOptions");
		}
		public static void SetBindingOptions(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DOMComponent.SetOption", dxTarget, "bindingOptions", value);
		}
		public static object GetElementAttr(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DOMComponent.GetOption", dxTarget, "elementAttr");
		}
		public static void SetElementAttr(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DOMComponent.SetOption", dxTarget, "elementAttr", value);
		}
		public static object GetHeight(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DOMComponent.GetOption", dxTarget, "height");
		}
		public static void SetHeight(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DOMComponent.SetOption", dxTarget, "height", value);
		}
		public static bool? GetRtlEnabled(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DOMComponent.GetOption", dxTarget, "rtlEnabled");
		}
		public static void SetRtlEnabled(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DOMComponent.SetOption", dxTarget, "rtlEnabled", value);
		}
		public static object GetWidth(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DOMComponent.GetOption", dxTarget, "width");
		}
		public static void SetWidth(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DOMComponent.SetOption", dxTarget, "width", value);
		}
		public static void DefaultOptions(object rule)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DOMComponent.defaultOptions_0", rule);
		}
		public static object GetInstance(object element)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DOMComponent.getInstance_1", element);
		}
		public static void Dispose(ElementRef dxTarget)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DOMComponent.dispose_0", dxTarget);
		}
		public static object Element(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DOMComponent.element_1", dxTarget);
		}
	}
	public class EndpointSelectorInterop
	{
		public static string UrlFor(ElementRef dxTarget, string key)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.EndpointSelector.urlFor_0", dxTarget, key);
		}
	}
	public class ValidationEngineInterop
	{
		public static object GetGroupConfig()
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.ValidationEngine.getGroupConfig_0");
		}
		public static object GetGroupConfig(object group)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.ValidationEngine.getGroupConfig_1", group);
		}
		public static void RegisterModelForValidation(object model)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.ValidationEngine.registerModelForValidation_2", model);
		}
		public static void ResetGroup()
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.ValidationEngine.resetGroup_3");
		}
		public static void ResetGroup(object group)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.ValidationEngine.resetGroup_4", group);
		}
		public static void UnregisterModelForValidation(object model)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.ValidationEngine.unregisterModelForValidation_5", model);
		}
		public static object ValidateGroup()
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.ValidationEngine.validateGroup_6");
		}
		public static object ValidateGroup(object group)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.ValidationEngine.validateGroup_7", group);
		}
		public static object ValidateModel(object model)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.ValidationEngine.validateModel_8", model);
		}
	}
	public class UiInterop
	{
		public static void Notify(string message, string type, float displayTime)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.Ui.notify_0", message, type, displayTime);
		}
		public static void Notify(object options, string type, float displayTime)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.Ui.notify_1", options, type, displayTime);
		}
		public static void SetTemplateEngine(string templateEngineName)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.Ui.setTemplateEngine_2", templateEngineName);
		}
		public static void SetTemplateEngine(object templateEngineOptions)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.Ui.setTemplateEngine_3", templateEngineOptions);
		}
	}
	public class VizInterop
	{
		public static void CurrentPalette(string paletteName)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.Viz.currentPalette_0", paletteName);
		}
		public static string CurrentTheme()
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.Viz.currentTheme_1");
		}
		public static void CurrentTheme(string platform, string colorScheme)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.Viz.currentTheme_2", platform, colorScheme);
		}
		public static void CurrentTheme(string theme)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.Viz.currentTheme_3", theme);
		}
		public static void ExportFromMarkup(string markup, object options)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.Viz.exportFromMarkup_4", markup, options);
		}
		public static string GetMarkup(object widgetInstances)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.Viz.getMarkup_5", widgetInstances);
		}
		public static object GetPalette(string paletteName)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.Viz.getPalette_6", paletteName);
		}
		public static object GetTheme(string theme)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.Viz.getTheme_7", theme);
		}
		public static void RefreshPaths()
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.Viz.refreshPaths_8");
		}
		public static void RefreshTheme()
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.Viz.refreshTheme_9");
		}
		public static void RegisterPalette(string paletteName, object palette)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.Viz.registerPalette_10", paletteName, palette);
		}
		public static void RegisterTheme(object customTheme, string baseTheme)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.Viz.registerTheme_11", customTheme, baseTheme);
		}
	}
}
namespace DevExpress.Data
{
	public class GuidInterop
	{
		public static string ToString(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.Guid.toString_0", dxTarget);
		}
		public static string ValueOf(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.Guid.valueOf_1", dxTarget);
		}
	}
	public class StoreInterop
	{
		public static event EventHandler<JQueryEventArgs> Inserted;
		public static event EventHandler<JQueryEventArgs> Inserting;
		public static event EventHandler<JQueryEventArgs> Loaded;
		public static event EventHandler<JQueryEventArgs> Loading;
		public static event EventHandler<JQueryEventArgs> Modified;
		public static event EventHandler<JQueryEventArgs> Modifying;
		public static event EventHandler<JQueryEventArgs> Removed;
		public static event EventHandler<JQueryEventArgs> Removing;
		public static event EventHandler<JQueryEventArgs> Updated;
		public static event EventHandler<JQueryEventArgs> Updating;
		public static void Init(ElementRef dxTarget, DevExpress.Data.StoreOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.Store.Init", dxTarget, json);
		}
		public static void OnInserted(string identifier)
		{
			Inserted?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static void OnInserting(string identifier)
		{
			Inserting?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static void OnLoaded(string identifier)
		{
			Loaded?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static void OnLoading(string identifier)
		{
			Loading?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static void OnModified(string identifier)
		{
			Modified?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static void OnModifying(string identifier)
		{
			Modifying?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static void OnRemoved(string identifier)
		{
			Removed?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static void OnRemoving(string identifier)
		{
			Removing?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static void OnUpdated(string identifier)
		{
			Updated?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static void OnUpdating(string identifier)
		{
			Updating?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static object GetErrorHandler(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.Store.GetOption", dxTarget, "errorHandler");
		}
		public static void SetErrorHandler(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.Store.SetOption", dxTarget, "errorHandler", value);
		}
		public static object GetKey(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.Store.GetOption", dxTarget, "key");
		}
		public static void SetKey(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.Store.SetOption", dxTarget, "key", value);
		}
		public static object ByKey(ElementRef dxTarget, object key)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.Store.byKey_0", dxTarget, key);
		}
		public static object Insert(ElementRef dxTarget, object values)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.Store.insert_1", dxTarget, values);
		}
		public static object Key(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.Store.key_2", dxTarget);
		}
		public static object KeyOf(ElementRef dxTarget, object obj)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.Store.keyOf_3", dxTarget, obj);
		}
		public static object Load(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.Store.load_4", dxTarget);
		}
		public static object Load(ElementRef dxTarget, object options)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.Store.load_5", dxTarget, options);
		}
		public static object Off(ElementRef dxTarget, string eventName)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.Store.off_6", dxTarget, eventName);
		}
		public static object Off(ElementRef dxTarget, string eventName, object eventHandler)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.Store.off_7", dxTarget, eventName, eventHandler);
		}
		public static object On(ElementRef dxTarget, string eventName, object eventHandler)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.Store.on_8", dxTarget, eventName, eventHandler);
		}
		public static object On(ElementRef dxTarget, object events)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.Store.on_9", dxTarget, events);
		}
		public static object Remove(ElementRef dxTarget, object key)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.Store.remove_10", dxTarget, key);
		}
		public static object TotalCount(ElementRef dxTarget, object obj)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.Store.totalCount_11", dxTarget, obj);
		}
		public static object Update(ElementRef dxTarget, object key, object values)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.Store.update_12", dxTarget, key, values);
		}
	}
	public class ArrayStoreInterop: StoreInterop
	{
		public static void Init(ElementRef dxTarget, DevExpress.Data.ArrayStoreOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.ArrayStore.Init", dxTarget, json);
		}
		public static object GetData(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.ArrayStore.GetOption", dxTarget, "data");
		}
		public static void SetData(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.ArrayStore.SetOption", dxTarget, "data", value);
		}
		public static void Clear(ElementRef dxTarget)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.ArrayStore.clear_0", dxTarget);
		}
		public static object CreateQuery(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.ArrayStore.createQuery_1", dxTarget);
		}
	}
	public class CustomStoreInterop: StoreInterop
	{
		public static void Init(ElementRef dxTarget, DevExpress.Data.CustomStoreOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.CustomStore.Init", dxTarget, json);
		}
		public static object GetByKey(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.CustomStore.GetOption", dxTarget, "byKey");
		}
		public static void SetByKey(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.CustomStore.SetOption", dxTarget, "byKey", value);
		}
		public static bool? GetCacheRawData(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.CustomStore.GetOption", dxTarget, "cacheRawData");
		}
		public static void SetCacheRawData(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.CustomStore.SetOption", dxTarget, "cacheRawData", value);
		}
		public static object GetInsert(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.CustomStore.GetOption", dxTarget, "insert");
		}
		public static void SetInsert(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.CustomStore.SetOption", dxTarget, "insert", value);
		}
		public static object GetLoad(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.CustomStore.GetOption", dxTarget, "load");
		}
		public static void SetLoad(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.CustomStore.SetOption", dxTarget, "load", value);
		}
		public static string GetLoadMode(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.CustomStore.GetOption", dxTarget, "loadMode");
		}
		public static void SetLoadMode(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.CustomStore.SetOption", dxTarget, "loadMode", value);
		}
		public static object GetRemove(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.CustomStore.GetOption", dxTarget, "remove");
		}
		public static void SetRemove(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.CustomStore.SetOption", dxTarget, "remove", value);
		}
		public static object GetTotalCount(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.CustomStore.GetOption", dxTarget, "totalCount");
		}
		public static void SetTotalCount(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.CustomStore.SetOption", dxTarget, "totalCount", value);
		}
		public static object GetUpdate(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.CustomStore.GetOption", dxTarget, "update");
		}
		public static void SetUpdate(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.CustomStore.SetOption", dxTarget, "update", value);
		}
		public static bool? GetUseDefaultSearch(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.CustomStore.GetOption", dxTarget, "useDefaultSearch");
		}
		public static void SetUseDefaultSearch(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.CustomStore.SetOption", dxTarget, "useDefaultSearch", value);
		}
		public static void ClearRawDataCache(ElementRef dxTarget)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.CustomStore.clearRawDataCache_0", dxTarget);
		}
	}
	public class DataSourceInterop
	{
		public static event EventHandler<JQueryEventArgs> Changed;
		public static event EventHandler<JQueryEventArgs> LoadError;
		public static event EventHandler<JQueryEventArgs> LoadingChanged;
		public static void Init(ElementRef dxTarget, DevExpress.Data.DataSourceOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DataSource.Init", dxTarget, json);
		}
		public static void OnChanged(string identifier)
		{
			Changed?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static void OnLoadError(string identifier)
		{
			LoadError?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static void OnLoadingChanged(string identifier)
		{
			LoadingChanged?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static object GetCustomQueryParams(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DataSource.GetOption", dxTarget, "customQueryParams");
		}
		public static void SetCustomQueryParams(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DataSource.SetOption", dxTarget, "customQueryParams", value);
		}
		public static object GetExpand(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DataSource.GetOption", dxTarget, "expand");
		}
		public static void SetExpand(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DataSource.SetOption", dxTarget, "expand", value);
		}
		public static object GetFilter(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DataSource.GetOption", dxTarget, "filter");
		}
		public static void SetFilter(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DataSource.SetOption", dxTarget, "filter", value);
		}
		public static object GetGroup(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DataSource.GetOption", dxTarget, "group");
		}
		public static void SetGroup(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DataSource.SetOption", dxTarget, "group", value);
		}
		public static object GetMap(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DataSource.GetOption", dxTarget, "map");
		}
		public static void SetMap(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DataSource.SetOption", dxTarget, "map", value);
		}
		public static float? GetPageSize(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<float?>("BlazorDevExtreme.DataSource.GetOption", dxTarget, "pageSize");
		}
		public static void SetPageSize(ElementRef dxTarget, float? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DataSource.SetOption", dxTarget, "pageSize", value);
		}
		public static bool? GetPaginate(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DataSource.GetOption", dxTarget, "paginate");
		}
		public static void SetPaginate(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DataSource.SetOption", dxTarget, "paginate", value);
		}
		public static object GetPostProcess(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DataSource.GetOption", dxTarget, "postProcess");
		}
		public static void SetPostProcess(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DataSource.SetOption", dxTarget, "postProcess", value);
		}
		public static bool? GetRequireTotalCount(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DataSource.GetOption", dxTarget, "requireTotalCount");
		}
		public static void SetRequireTotalCount(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DataSource.SetOption", dxTarget, "requireTotalCount", value);
		}
		public static object GetSearchExpr(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DataSource.GetOption", dxTarget, "searchExpr");
		}
		public static void SetSearchExpr(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DataSource.SetOption", dxTarget, "searchExpr", value);
		}
		public static string GetSearchOperation(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DataSource.GetOption", dxTarget, "searchOperation");
		}
		public static void SetSearchOperation(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DataSource.SetOption", dxTarget, "searchOperation", value);
		}
		public static object GetSearchValue(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DataSource.GetOption", dxTarget, "searchValue");
		}
		public static void SetSearchValue(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DataSource.SetOption", dxTarget, "searchValue", value);
		}
		public static object GetSelect(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DataSource.GetOption", dxTarget, "select");
		}
		public static void SetSelect(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DataSource.SetOption", dxTarget, "select", value);
		}
		public static object GetSort(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DataSource.GetOption", dxTarget, "sort");
		}
		public static void SetSort(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DataSource.SetOption", dxTarget, "sort", value);
		}
		public static object GetStore(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DataSource.GetOption", dxTarget, "store");
		}
		public static void SetStore(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DataSource.SetOption", dxTarget, "store", value);
		}
		public static bool Cancel(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool>("BlazorDevExtreme.DataSource.cancel_0", dxTarget);
		}
		public static void Dispose(ElementRef dxTarget)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DataSource.dispose_1", dxTarget);
		}
		public static object Filter(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DataSource.filter_2", dxTarget);
		}
		public static void Filter(ElementRef dxTarget, object filterExpr)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DataSource.filter_3", dxTarget, filterExpr);
		}
		public static object Group(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DataSource.group_4", dxTarget);
		}
		public static void Group(ElementRef dxTarget, object groupExpr)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DataSource.group_5", dxTarget, groupExpr);
		}
		public static bool IsLastPage(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool>("BlazorDevExtreme.DataSource.isLastPage_6", dxTarget);
		}
		public static bool IsLoaded(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool>("BlazorDevExtreme.DataSource.isLoaded_7", dxTarget);
		}
		public static bool IsLoading(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool>("BlazorDevExtreme.DataSource.isLoading_8", dxTarget);
		}
		public static object Items(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DataSource.items_9", dxTarget);
		}
		public static object Key(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DataSource.key_10", dxTarget);
		}
		public static object Load(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DataSource.load_11", dxTarget);
		}
		public static object LoadOptions(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DataSource.loadOptions_12", dxTarget);
		}
		public static object Off(ElementRef dxTarget, string eventName)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DataSource.off_13", dxTarget, eventName);
		}
		public static object Off(ElementRef dxTarget, string eventName, object eventHandler)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DataSource.off_14", dxTarget, eventName, eventHandler);
		}
		public static object On(ElementRef dxTarget, string eventName, object eventHandler)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DataSource.on_15", dxTarget, eventName, eventHandler);
		}
		public static object On(ElementRef dxTarget, object events)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DataSource.on_16", dxTarget, events);
		}
		public static float PageIndex(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<float>("BlazorDevExtreme.DataSource.pageIndex_17", dxTarget);
		}
		public static void PageIndex(ElementRef dxTarget, float newIndex)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DataSource.pageIndex_18", dxTarget, newIndex);
		}
		public static float PageSize(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<float>("BlazorDevExtreme.DataSource.pageSize_19", dxTarget);
		}
		public static void PageSize(ElementRef dxTarget, float value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DataSource.pageSize_20", dxTarget, value);
		}
		public static bool Paginate(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool>("BlazorDevExtreme.DataSource.paginate_21", dxTarget);
		}
		public static void Paginate(ElementRef dxTarget, bool value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DataSource.paginate_22", dxTarget, value);
		}
		public static object Reload(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DataSource.reload_23", dxTarget);
		}
		public static bool RequireTotalCount(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool>("BlazorDevExtreme.DataSource.requireTotalCount_24", dxTarget);
		}
		public static void RequireTotalCount(ElementRef dxTarget, bool value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DataSource.requireTotalCount_25", dxTarget, value);
		}
		public static object SearchExpr(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DataSource.searchExpr_26", dxTarget);
		}
		public static void SearchExpr(ElementRef dxTarget, object expr)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DataSource.searchExpr_27", dxTarget, expr);
		}
		public static string SearchOperation(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DataSource.searchOperation_28", dxTarget);
		}
		public static void SearchOperation(ElementRef dxTarget, string op)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DataSource.searchOperation_29", dxTarget, op);
		}
		public static object SearchValue(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DataSource.searchValue_30", dxTarget);
		}
		public static void SearchValue(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DataSource.searchValue_31", dxTarget, value);
		}
		public static object Select(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DataSource.select_32", dxTarget);
		}
		public static void Select(ElementRef dxTarget, object expr)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DataSource.select_33", dxTarget, expr);
		}
		public static object Sort(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DataSource.sort_34", dxTarget);
		}
		public static void Sort(ElementRef dxTarget, object sortExpr)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DataSource.sort_35", dxTarget, sortExpr);
		}
		public static object Store(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DataSource.store_36", dxTarget);
		}
		public static float TotalCount(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<float>("BlazorDevExtreme.DataSource.totalCount_37", dxTarget);
		}
	}
	public class LocalStoreInterop: ArrayStoreInterop
	{
		public static void Init(ElementRef dxTarget, DevExpress.Data.LocalStoreOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.LocalStore.Init", dxTarget, json);
		}
		public static float? GetFlushInterval(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<float?>("BlazorDevExtreme.LocalStore.GetOption", dxTarget, "flushInterval");
		}
		public static void SetFlushInterval(ElementRef dxTarget, float? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.LocalStore.SetOption", dxTarget, "flushInterval", value);
		}
		public static bool? GetImmediate(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.LocalStore.GetOption", dxTarget, "immediate");
		}
		public static void SetImmediate(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.LocalStore.SetOption", dxTarget, "immediate", value);
		}
		public static string GetName(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.LocalStore.GetOption", dxTarget, "name");
		}
		public static void SetName(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.LocalStore.SetOption", dxTarget, "name", value);
		}
		public static void Clear(ElementRef dxTarget)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.LocalStore.clear_0", dxTarget);
		}
	}
	public class QueryInterop
	{
		public static object Aggregate(ElementRef dxTarget, object seed, object step, object finalize)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.Query.aggregate_0", dxTarget, seed, step, finalize);
		}
		public static object Aggregate(ElementRef dxTarget, object step)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.Query.aggregate_1", dxTarget, step);
		}
		public static object Avg(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.Query.avg_2", dxTarget);
		}
		public static object Avg(ElementRef dxTarget, object getter)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.Query.avg_3", dxTarget, getter);
		}
		public static object Count(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.Query.count_4", dxTarget);
		}
		public static object Enumerate(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.Query.enumerate_5", dxTarget);
		}
		public static object Filter(ElementRef dxTarget, object criteria)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.Query.filter_6", dxTarget, criteria);
		}
		public static object GroupBy(ElementRef dxTarget, object getter)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.Query.groupBy_8", dxTarget, getter);
		}
		public static object Max(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.Query.max_9", dxTarget);
		}
		public static object Max(ElementRef dxTarget, object getter)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.Query.max_10", dxTarget, getter);
		}
		public static object Min(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.Query.min_11", dxTarget);
		}
		public static object Min(ElementRef dxTarget, object getter)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.Query.min_12", dxTarget, getter);
		}
		public static object Select(ElementRef dxTarget, object getter)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.Query.select_13", dxTarget, getter);
		}
		public static object Slice(ElementRef dxTarget, float skip, float take)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.Query.slice_14", dxTarget, skip, take);
		}
		public static object SortBy(ElementRef dxTarget, object getter)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.Query.sortBy_15", dxTarget, getter);
		}
		public static object SortBy(ElementRef dxTarget, object getter, bool desc)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.Query.sortBy_16", dxTarget, getter, desc);
		}
		public static object Sum(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.Query.sum_17", dxTarget);
		}
		public static object Sum(ElementRef dxTarget, object getter)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.Query.sum_18", dxTarget, getter);
		}
		public static object ThenBy(ElementRef dxTarget, object getter)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.Query.thenBy_19", dxTarget, getter);
		}
		public static object ThenBy(ElementRef dxTarget, object getter, bool desc)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.Query.thenBy_20", dxTarget, getter, desc);
		}
		public static object ToArray(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.Query.toArray_21", dxTarget);
		}
	}
	public class ODataContextInterop
	{
		public static void Init(ElementRef dxTarget, DevExpress.Data.ODataContextOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.ODataContext.Init", dxTarget, json);
		}
		public static object GetBeforeSend(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.ODataContext.GetOption", dxTarget, "beforeSend");
		}
		public static void SetBeforeSend(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.ODataContext.SetOption", dxTarget, "beforeSend", value);
		}
		public static bool? GetDeserializeDates(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.ODataContext.GetOption", dxTarget, "deserializeDates");
		}
		public static void SetDeserializeDates(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.ODataContext.SetOption", dxTarget, "deserializeDates", value);
		}
		public static object GetEntities(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.ODataContext.GetOption", dxTarget, "entities");
		}
		public static void SetEntities(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.ODataContext.SetOption", dxTarget, "entities", value);
		}
		public static object GetErrorHandler(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.ODataContext.GetOption", dxTarget, "errorHandler");
		}
		public static void SetErrorHandler(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.ODataContext.SetOption", dxTarget, "errorHandler", value);
		}
		public static bool? GetJsonp(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.ODataContext.GetOption", dxTarget, "jsonp");
		}
		public static void SetJsonp(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.ODataContext.SetOption", dxTarget, "jsonp", value);
		}
		public static string GetUrl(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.ODataContext.GetOption", dxTarget, "url");
		}
		public static void SetUrl(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.ODataContext.SetOption", dxTarget, "url", value);
		}
		public static float? GetVersion(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<float?>("BlazorDevExtreme.ODataContext.GetOption", dxTarget, "version");
		}
		public static void SetVersion(ElementRef dxTarget, float? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.ODataContext.SetOption", dxTarget, "version", value);
		}
		public static bool? GetWithCredentials(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.ODataContext.GetOption", dxTarget, "withCredentials");
		}
		public static void SetWithCredentials(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.ODataContext.SetOption", dxTarget, "withCredentials", value);
		}
		public static object Get(ElementRef dxTarget, string operationName, object @params)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.ODataContext.get_0", dxTarget, operationName, @params);
		}
		public static object Invoke(ElementRef dxTarget, string operationName, object @params, object httpMethod)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.ODataContext.invoke_1", dxTarget, operationName, @params, httpMethod);
		}
		public static object ObjectLink(ElementRef dxTarget, string entityAlias, object key)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.ODataContext.objectLink_2", dxTarget, entityAlias, key);
		}
	}
	public class ODataStoreInterop: StoreInterop
	{
		public static event EventHandler<JQueryEventArgs> Loading;
		public static void Init(ElementRef dxTarget, DevExpress.Data.ODataStoreOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.ODataStore.Init", dxTarget, json);
		}
		public static void OnLoading(string identifier)
		{
			Loading?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static object GetBeforeSend(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.ODataStore.GetOption", dxTarget, "beforeSend");
		}
		public static void SetBeforeSend(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.ODataStore.SetOption", dxTarget, "beforeSend", value);
		}
		public static bool? GetDeserializeDates(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.ODataStore.GetOption", dxTarget, "deserializeDates");
		}
		public static void SetDeserializeDates(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.ODataStore.SetOption", dxTarget, "deserializeDates", value);
		}
		public static object GetFieldTypes(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.ODataStore.GetOption", dxTarget, "fieldTypes");
		}
		public static void SetFieldTypes(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.ODataStore.SetOption", dxTarget, "fieldTypes", value);
		}
		public static bool? GetJsonp(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.ODataStore.GetOption", dxTarget, "jsonp");
		}
		public static void SetJsonp(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.ODataStore.SetOption", dxTarget, "jsonp", value);
		}
		public static object GetKeyType(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.ODataStore.GetOption", dxTarget, "keyType");
		}
		public static void SetKeyType(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.ODataStore.SetOption", dxTarget, "keyType", value);
		}
		public static string GetUrl(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.ODataStore.GetOption", dxTarget, "url");
		}
		public static void SetUrl(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.ODataStore.SetOption", dxTarget, "url", value);
		}
		public static float? GetVersion(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<float?>("BlazorDevExtreme.ODataStore.GetOption", dxTarget, "version");
		}
		public static void SetVersion(ElementRef dxTarget, float? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.ODataStore.SetOption", dxTarget, "version", value);
		}
		public static bool? GetWithCredentials(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.ODataStore.GetOption", dxTarget, "withCredentials");
		}
		public static void SetWithCredentials(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.ODataStore.SetOption", dxTarget, "withCredentials", value);
		}
		public static object ByKey(ElementRef dxTarget, object key)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.ODataStore.byKey_0", dxTarget, key);
		}
		public static object ByKey(ElementRef dxTarget, object key, object extraOptions)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.ODataStore.byKey_1", dxTarget, key, extraOptions);
		}
		public static object CreateQuery(ElementRef dxTarget, object loadOptions)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.ODataStore.createQuery_2", dxTarget, loadOptions);
		}
		public static object Load(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.ODataStore.load_3", dxTarget);
		}
		public static object Load(ElementRef dxTarget, object options)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.ODataStore.load_4", dxTarget, options);
		}
	}
	public class EdmLiteralInterop
	{
		public static string ValueOf(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.EdmLiteral.valueOf_0", dxTarget);
		}
	}
	public class PivotGridDataSourceInterop
	{
		public static event EventHandler<JQueryEventArgs> Changed;
		public static event EventHandler<JQueryEventArgs> FieldsPrepared;
		public static event EventHandler<JQueryEventArgs> LoadError;
		public static event EventHandler<JQueryEventArgs> LoadingChanged;
		public static void Init(ElementRef dxTarget, DevExpress.Data.PivotGridDataSourceOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.PivotGridDataSource.Init", dxTarget, json);
		}
		public static void OnChanged(string identifier)
		{
			Changed?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static void OnFieldsPrepared(string identifier)
		{
			FieldsPrepared?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static void OnLoadError(string identifier)
		{
			LoadError?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static void OnLoadingChanged(string identifier)
		{
			LoadingChanged?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static object GetFields(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.PivotGridDataSource.GetOption", dxTarget, "fields");
		}
		public static void SetFields(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.PivotGridDataSource.SetOption", dxTarget, "fields", value);
		}
		public static object GetFilter(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.PivotGridDataSource.GetOption", dxTarget, "filter");
		}
		public static void SetFilter(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.PivotGridDataSource.SetOption", dxTarget, "filter", value);
		}
		public static bool? GetRemoteOperations(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.PivotGridDataSource.GetOption", dxTarget, "remoteOperations");
		}
		public static void SetRemoteOperations(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.PivotGridDataSource.SetOption", dxTarget, "remoteOperations", value);
		}
		public static bool? GetRetrieveFields(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.PivotGridDataSource.GetOption", dxTarget, "retrieveFields");
		}
		public static void SetRetrieveFields(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.PivotGridDataSource.SetOption", dxTarget, "retrieveFields", value);
		}
		public static object GetStore(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.PivotGridDataSource.GetOption", dxTarget, "store");
		}
		public static void SetStore(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.PivotGridDataSource.SetOption", dxTarget, "store", value);
		}
		public static void CollapseAll(ElementRef dxTarget, object id)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.PivotGridDataSource.collapseAll_0", dxTarget, id);
		}
		public static void CollapseHeaderItem(ElementRef dxTarget, string area, object path)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.PivotGridDataSource.collapseHeaderItem_1", dxTarget, area, path);
		}
		public static object CreateDrillDownDataSource(ElementRef dxTarget, object options)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.PivotGridDataSource.createDrillDownDataSource_2", dxTarget, options);
		}
		public static void Dispose(ElementRef dxTarget)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.PivotGridDataSource.dispose_3", dxTarget);
		}
		public static void ExpandAll(ElementRef dxTarget, object id)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.PivotGridDataSource.expandAll_4", dxTarget, id);
		}
		public static void ExpandHeaderItem(ElementRef dxTarget, string area, object path)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.PivotGridDataSource.expandHeaderItem_5", dxTarget, area, path);
		}
		public static object Field(ElementRef dxTarget, object id)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.PivotGridDataSource.field_6", dxTarget, id);
		}
		public static void Field(ElementRef dxTarget, object id, object options)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.PivotGridDataSource.field_7", dxTarget, id, options);
		}
		public static object Fields(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.PivotGridDataSource.fields_8", dxTarget);
		}
		public static void Fields(ElementRef dxTarget, object fields)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.PivotGridDataSource.fields_9", dxTarget, fields);
		}
		public static object Filter(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.PivotGridDataSource.filter_10", dxTarget);
		}
		public static void Filter(ElementRef dxTarget, object filterExpr)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.PivotGridDataSource.filter_11", dxTarget, filterExpr);
		}
		public static object GetAreaFields(ElementRef dxTarget, string area, bool collectGroups)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.PivotGridDataSource.getAreaFields_12", dxTarget, area, collectGroups);
		}
		public static object GetData(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.PivotGridDataSource.getData_13", dxTarget);
		}
		public static bool IsLoading(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool>("BlazorDevExtreme.PivotGridDataSource.isLoading_14", dxTarget);
		}
		public static object Load(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.PivotGridDataSource.load_15", dxTarget);
		}
		public static object Off(ElementRef dxTarget, string eventName)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.PivotGridDataSource.off_16", dxTarget, eventName);
		}
		public static object Off(ElementRef dxTarget, string eventName, object eventHandler)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.PivotGridDataSource.off_17", dxTarget, eventName, eventHandler);
		}
		public static object On(ElementRef dxTarget, string eventName, object eventHandler)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.PivotGridDataSource.on_18", dxTarget, eventName, eventHandler);
		}
		public static object On(ElementRef dxTarget, object events)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.PivotGridDataSource.on_19", dxTarget, events);
		}
		public static object Reload(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.PivotGridDataSource.reload_20", dxTarget);
		}
		public static object State(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.PivotGridDataSource.state_21", dxTarget);
		}
		public static void State(ElementRef dxTarget, object state)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.PivotGridDataSource.state_22", dxTarget, state);
		}
	}
	public class XmlaStoreInterop
	{
		public static void Init(ElementRef dxTarget, DevExpress.Data.XmlaStoreOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.XmlaStore.Init", dxTarget, json);
		}
		public static object GetBeforeSend(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.XmlaStore.GetOption", dxTarget, "beforeSend");
		}
		public static void SetBeforeSend(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.XmlaStore.SetOption", dxTarget, "beforeSend", value);
		}
		public static string GetCatalog(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.XmlaStore.GetOption", dxTarget, "catalog");
		}
		public static void SetCatalog(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.XmlaStore.SetOption", dxTarget, "catalog", value);
		}
		public static string GetCube(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.XmlaStore.GetOption", dxTarget, "cube");
		}
		public static void SetCube(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.XmlaStore.SetOption", dxTarget, "cube", value);
		}
		public static string GetUrl(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.XmlaStore.GetOption", dxTarget, "url");
		}
		public static void SetUrl(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.XmlaStore.SetOption", dxTarget, "url", value);
		}
	}
}
namespace DevExpress.Core
{
	public class EventsMixinInterop
	{
		public static object Off(ElementRef dxTarget, string eventName)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.EventsMixin.off_0", dxTarget, eventName);
		}
		public static object Off(ElementRef dxTarget, string eventName, object eventHandler)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.EventsMixin.off_1", dxTarget, eventName, eventHandler);
		}
		public static object On(ElementRef dxTarget, string eventName, object eventHandler)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.EventsMixin.on_2", dxTarget, eventName, eventHandler);
		}
		public static object On(ElementRef dxTarget, object events)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.EventsMixin.on_3", dxTarget, events);
		}
	}
}
namespace DevExpress.Framework
{
	public class DxCommandInterop: DOMComponentInterop
	{
		public static event EventHandler<JQueryEventArgs> Execute;
		public static void Init(ElementRef dxTarget, DevExpress.Framework.DxCommandOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxCommand.Init", dxTarget, json);
		}
		public static void OnExecute(string identifier)
		{
			Execute?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static bool? GetDisabled(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxCommand.GetOption", dxTarget, "disabled");
		}
		public static void SetDisabled(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxCommand.SetOption", dxTarget, "disabled", value);
		}
		public static string GetIcon(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxCommand.GetOption", dxTarget, "icon");
		}
		public static void SetIcon(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxCommand.SetOption", dxTarget, "icon", value);
		}
		public static object GetIconSrc(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxCommand.GetOption", dxTarget, "iconSrc");
		}
		public static void SetIconSrc(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxCommand.SetOption", dxTarget, "iconSrc", value);
		}
		public static string GetId(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxCommand.GetOption", dxTarget, "id");
		}
		public static void SetId(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxCommand.SetOption", dxTarget, "id", value);
		}
		public static string GetRenderStage(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxCommand.GetOption", dxTarget, "renderStage");
		}
		public static void SetRenderStage(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxCommand.SetOption", dxTarget, "renderStage", value);
		}
		public static string GetTitle(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxCommand.GetOption", dxTarget, "title");
		}
		public static void SetTitle(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxCommand.SetOption", dxTarget, "title", value);
		}
		public static string GetType(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxCommand.GetOption", dxTarget, "type");
		}
		public static void SetType(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxCommand.SetOption", dxTarget, "type", value);
		}
		public static bool? GetVisible(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxCommand.GetOption", dxTarget, "visible");
		}
		public static void SetVisible(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxCommand.SetOption", dxTarget, "visible", value);
		}
		public static void DoExecute(ElementRef dxTarget)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxCommand.execute_0", dxTarget);
		}
	}
	public class RouterInterop
	{
		public static string Format(ElementRef dxTarget, object obj)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.Router.format_0", dxTarget, obj);
		}
		public static object Parse(ElementRef dxTarget, string uri)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.Router.parse_1", dxTarget, uri);
		}
		public static void Register(ElementRef dxTarget, string pattern, object defaults, object constraints)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.Router.register_2", dxTarget, pattern, defaults, constraints);
		}
	}
	public class StateManagerInterop
	{
		public static void Init(ElementRef dxTarget, DevExpress.Framework.StateManagerOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.StateManager.Init", dxTarget, json);
		}
		public static object GetStorage(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.StateManager.GetOption", dxTarget, "storage");
		}
		public static void SetStorage(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.StateManager.SetOption", dxTarget, "storage", value);
		}
		public static void AddStateSource(ElementRef dxTarget, object stateSource)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.StateManager.addStateSource_0", dxTarget, stateSource);
		}
		public static void ClearState(ElementRef dxTarget)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.StateManager.clearState_1", dxTarget);
		}
		public static void RemoveStateSource(ElementRef dxTarget, object stateSource)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.StateManager.removeStateSource_2", dxTarget, stateSource);
		}
		public static void RestoreState(ElementRef dxTarget)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.StateManager.restoreState_3", dxTarget);
		}
		public static void SaveState(ElementRef dxTarget)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.StateManager.saveState_4", dxTarget);
		}
	}
	public class ViewCacheInterop
	{
		public static void Clear(ElementRef dxTarget)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.ViewCache.clear_0", dxTarget);
		}
		public static object GetView(ElementRef dxTarget, string key)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.ViewCache.getView_1", dxTarget, key);
		}
		public static bool HasView(ElementRef dxTarget, string key)
		{
			return RegisteredFunction.Invoke<bool>("BlazorDevExtreme.ViewCache.hasView_2", dxTarget, key);
		}
		public static object Off(ElementRef dxTarget, string eventName)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.ViewCache.off_3", dxTarget, eventName);
		}
		public static object Off(ElementRef dxTarget, string eventName, object eventHandler)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.ViewCache.off_4", dxTarget, eventName, eventHandler);
		}
		public static object On(ElementRef dxTarget, string eventName, object eventHandler)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.ViewCache.on_5", dxTarget, eventName, eventHandler);
		}
		public static object On(ElementRef dxTarget, object events)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.ViewCache.on_6", dxTarget, events);
		}
		public static object RemoveView(ElementRef dxTarget, string key)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.ViewCache.removeView_7", dxTarget, key);
		}
		public static void SetView(ElementRef dxTarget, string key, object viewInfo)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.ViewCache.setView_8", dxTarget, key, viewInfo);
		}
	}
	public class DxCommandContainerInterop
	{
		public static void Init(ElementRef dxTarget, DevExpress.Framework.DxCommandContainerOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxCommandContainer.Init", dxTarget, json);
		}
		public static string GetId(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxCommandContainer.GetOption", dxTarget, "id");
		}
		public static void SetId(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxCommandContainer.SetOption", dxTarget, "id", value);
		}
	}
	public class DxViewInterop
	{
		public static void Init(ElementRef dxTarget, DevExpress.Framework.DxViewOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxView.Init", dxTarget, json);
		}
		public static bool? GetDisableCache(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxView.GetOption", dxTarget, "disableCache");
		}
		public static void SetDisableCache(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxView.SetOption", dxTarget, "disableCache", value);
		}
		public static bool? GetModal(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxView.GetOption", dxTarget, "modal");
		}
		public static void SetModal(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxView.SetOption", dxTarget, "modal", value);
		}
		public static string GetName(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxView.GetOption", dxTarget, "name");
		}
		public static void SetName(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxView.SetOption", dxTarget, "name", value);
		}
		public static string GetOrientation(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxView.GetOption", dxTarget, "orientation");
		}
		public static void SetOrientation(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxView.SetOption", dxTarget, "orientation", value);
		}
		public static string GetPane(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxView.GetOption", dxTarget, "pane");
		}
		public static void SetPane(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxView.SetOption", dxTarget, "pane", value);
		}
		public static string GetTitle(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxView.GetOption", dxTarget, "title");
		}
		public static void SetTitle(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxView.SetOption", dxTarget, "title", value);
		}
	}
	public class DxLayoutInterop
	{
		public static void Init(ElementRef dxTarget, DevExpress.Framework.DxLayoutOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxLayout.Init", dxTarget, json);
		}
		public static string GetName(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxLayout.GetOption", dxTarget, "name");
		}
		public static void SetName(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxLayout.SetOption", dxTarget, "name", value);
		}
	}
	public class DxViewPlaceholderInterop
	{
		public static void Init(ElementRef dxTarget, DevExpress.Framework.DxViewPlaceholderOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxViewPlaceholder.Init", dxTarget, json);
		}
		public static string GetViewName(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxViewPlaceholder.GetOption", dxTarget, "viewName");
		}
		public static void SetViewName(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxViewPlaceholder.SetOption", dxTarget, "viewName", value);
		}
	}
	public class DxTransitionInterop
	{
		public static void Init(ElementRef dxTarget, DevExpress.Framework.DxTransitionOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTransition.Init", dxTarget, json);
		}
		public static string GetAnimation(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxTransition.GetOption", dxTarget, "animation");
		}
		public static void SetAnimation(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTransition.SetOption", dxTarget, "animation", value);
		}
		public static string GetName(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxTransition.GetOption", dxTarget, "name");
		}
		public static void SetName(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTransition.SetOption", dxTarget, "name", value);
		}
		public static string GetType(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxTransition.GetOption", dxTarget, "type");
		}
		public static void SetType(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTransition.SetOption", dxTarget, "type", value);
		}
	}
	public class DxContentPlaceholderInterop
	{
		public static void Init(ElementRef dxTarget, DevExpress.Framework.DxContentPlaceholderOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxContentPlaceholder.Init", dxTarget, json);
		}
		public static string GetAnimation(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxContentPlaceholder.GetOption", dxTarget, "animation");
		}
		public static void SetAnimation(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxContentPlaceholder.SetOption", dxTarget, "animation", value);
		}
		public static string GetContentCssPosition(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxContentPlaceholder.GetOption", dxTarget, "contentCssPosition");
		}
		public static void SetContentCssPosition(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxContentPlaceholder.SetOption", dxTarget, "contentCssPosition", value);
		}
		public static string GetName(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxContentPlaceholder.GetOption", dxTarget, "name");
		}
		public static void SetName(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxContentPlaceholder.SetOption", dxTarget, "name", value);
		}
		public static string GetTransition(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxContentPlaceholder.GetOption", dxTarget, "transition");
		}
		public static void SetTransition(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxContentPlaceholder.SetOption", dxTarget, "transition", value);
		}
	}
	public class DxContentInterop
	{
		public static void Init(ElementRef dxTarget, DevExpress.Framework.DxContentOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxContent.Init", dxTarget, json);
		}
		public static string GetTargetPlaceholder(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxContent.GetOption", dxTarget, "targetPlaceholder");
		}
		public static void SetTargetPlaceholder(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxContent.SetOption", dxTarget, "targetPlaceholder", value);
		}
	}
}
namespace DevExpress.Framework.Html
{
	public class HtmlApplicationInterop
	{
		public static void Init(ElementRef dxTarget, DevExpress.Framework.Html.HtmlApplicationOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.HtmlApplication.Init", dxTarget, json);
		}
		public static object GetAnimationSet(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.HtmlApplication.GetOption", dxTarget, "animationSet");
		}
		public static void SetAnimationSet(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.HtmlApplication.SetOption", dxTarget, "animationSet", value);
		}
		public static object GetCommandMapping(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.HtmlApplication.GetOption", dxTarget, "commandMapping");
		}
		public static void SetCommandMapping(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.HtmlApplication.SetOption", dxTarget, "commandMapping", value);
		}
		public static bool? GetDisableViewCache(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.HtmlApplication.GetOption", dxTarget, "disableViewCache");
		}
		public static void SetDisableViewCache(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.HtmlApplication.SetOption", dxTarget, "disableViewCache", value);
		}
		public static object GetLayoutSet(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.HtmlApplication.GetOption", dxTarget, "layoutSet");
		}
		public static void SetLayoutSet(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.HtmlApplication.SetOption", dxTarget, "layoutSet", value);
		}
		public static string GetMode(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.HtmlApplication.GetOption", dxTarget, "mode");
		}
		public static void SetMode(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.HtmlApplication.SetOption", dxTarget, "mode", value);
		}
		public static object GetNamespace(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.HtmlApplication.GetOption", dxTarget, "namespace");
		}
		public static void SetNamespace(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.HtmlApplication.SetOption", dxTarget, "namespace", value);
		}
		public static string GetNavigateToRootViewMode(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.HtmlApplication.GetOption", dxTarget, "navigateToRootViewMode");
		}
		public static void SetNavigateToRootViewMode(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.HtmlApplication.SetOption", dxTarget, "navigateToRootViewMode", value);
		}
		public static object GetNavigation(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.HtmlApplication.GetOption", dxTarget, "navigation");
		}
		public static void SetNavigation(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.HtmlApplication.SetOption", dxTarget, "navigation", value);
		}
		public static object GetRouter(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.HtmlApplication.GetOption", dxTarget, "router");
		}
		public static void SetRouter(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.HtmlApplication.SetOption", dxTarget, "router", value);
		}
		public static object GetStateManager(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.HtmlApplication.GetOption", dxTarget, "stateManager");
		}
		public static void SetStateManager(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.HtmlApplication.SetOption", dxTarget, "stateManager", value);
		}
		public static object GetStateStorage(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.HtmlApplication.GetOption", dxTarget, "stateStorage");
		}
		public static void SetStateStorage(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.HtmlApplication.SetOption", dxTarget, "stateStorage", value);
		}
		public static string GetTemplatesVersion(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.HtmlApplication.GetOption", dxTarget, "templatesVersion");
		}
		public static void SetTemplatesVersion(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.HtmlApplication.SetOption", dxTarget, "templatesVersion", value);
		}
		public static bool? GetUseViewTitleAsBackText(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.HtmlApplication.GetOption", dxTarget, "useViewTitleAsBackText");
		}
		public static void SetUseViewTitleAsBackText(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.HtmlApplication.SetOption", dxTarget, "useViewTitleAsBackText", value);
		}
		public static object GetViewCache(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.HtmlApplication.GetOption", dxTarget, "viewCache");
		}
		public static void SetViewCache(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.HtmlApplication.SetOption", dxTarget, "viewCache", value);
		}
		public static float? GetViewCacheSize(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<float?>("BlazorDevExtreme.HtmlApplication.GetOption", dxTarget, "viewCacheSize");
		}
		public static void SetViewCacheSize(ElementRef dxTarget, float? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.HtmlApplication.SetOption", dxTarget, "viewCacheSize", value);
		}
		public static object GetViewPort(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.HtmlApplication.GetOption", dxTarget, "viewPort");
		}
		public static void SetViewPort(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.HtmlApplication.SetOption", dxTarget, "viewPort", value);
		}
		public static void Back(ElementRef dxTarget)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.HtmlApplication.back_0", dxTarget);
		}
		public static bool CanBack(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool>("BlazorDevExtreme.HtmlApplication.canBack_1", dxTarget);
		}
		public static void ClearState(ElementRef dxTarget)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.HtmlApplication.clearState_2", dxTarget);
		}
		public static void CreateNavigation(ElementRef dxTarget, object navigationConfig)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.HtmlApplication.createNavigation_3", dxTarget, navigationConfig);
		}
		public static object GetViewTemplate(ElementRef dxTarget, string viewName)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.HtmlApplication.getViewTemplate_4", dxTarget, viewName);
		}
		public static object GetViewTemplateInfo(ElementRef dxTarget, string viewName)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.HtmlApplication.getViewTemplateInfo_5", dxTarget, viewName);
		}
		public static object LoadTemplates(ElementRef dxTarget, object source)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.HtmlApplication.loadTemplates_6", dxTarget, source);
		}
		public static void Navigate(ElementRef dxTarget, object uri)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.HtmlApplication.navigate_7", dxTarget, uri);
		}
		public static void Navigate(ElementRef dxTarget, object uri, object options)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.HtmlApplication.navigate_8", dxTarget, uri, options);
		}
		public static object Off(ElementRef dxTarget, string eventName)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.HtmlApplication.off_9", dxTarget, eventName);
		}
		public static object Off(ElementRef dxTarget, string eventName, object eventHandler)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.HtmlApplication.off_10", dxTarget, eventName, eventHandler);
		}
		public static object On(ElementRef dxTarget, string eventName, object eventHandler)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.HtmlApplication.on_11", dxTarget, eventName, eventHandler);
		}
		public static object On(ElementRef dxTarget, object events)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.HtmlApplication.on_12", dxTarget, events);
		}
		public static void RenderNavigation(ElementRef dxTarget)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.HtmlApplication.renderNavigation_13", dxTarget);
		}
		public static void RestoreState(ElementRef dxTarget)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.HtmlApplication.restoreState_14", dxTarget);
		}
		public static void SaveState(ElementRef dxTarget)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.HtmlApplication.saveState_15", dxTarget);
		}
		public static object TemplateContext(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.HtmlApplication.templateContext_16", dxTarget);
		}
	}
}
namespace DevExpress.Ui
{
	public class DxAccordionInterop: CollectionWidgetInterop
	{
		public static event EventHandler<JQueryEventArgs> ItemTitleClick;
		public static void Init(ElementRef dxTarget, DevExpress.Ui.DxAccordionOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxAccordion.Init", dxTarget, json);
		}
		public static void OnItemTitleClick(string identifier)
		{
			ItemTitleClick?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static float? GetAnimationDuration(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<float?>("BlazorDevExtreme.DxAccordion.GetOption", dxTarget, "animationDuration");
		}
		public static void SetAnimationDuration(ElementRef dxTarget, float? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxAccordion.SetOption", dxTarget, "animationDuration", value);
		}
		public static bool? GetCollapsible(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxAccordion.GetOption", dxTarget, "collapsible");
		}
		public static void SetCollapsible(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxAccordion.SetOption", dxTarget, "collapsible", value);
		}
		public static bool? GetDeferRendering(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxAccordion.GetOption", dxTarget, "deferRendering");
		}
		public static void SetDeferRendering(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxAccordion.SetOption", dxTarget, "deferRendering", value);
		}
		public static new bool? GetFocusStateEnabled(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxAccordion.GetOption", dxTarget, "focusStateEnabled");
		}
		public static new void SetFocusStateEnabled(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxAccordion.SetOption", dxTarget, "focusStateEnabled", value);
		}
		public static new object GetHeight(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxAccordion.GetOption", dxTarget, "height");
		}
		public static new void SetHeight(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxAccordion.SetOption", dxTarget, "height", value);
		}
		public static new bool? GetHoverStateEnabled(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxAccordion.GetOption", dxTarget, "hoverStateEnabled");
		}
		public static new void SetHoverStateEnabled(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxAccordion.SetOption", dxTarget, "hoverStateEnabled", value);
		}
		public static new object GetItemTemplate(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxAccordion.GetOption", dxTarget, "itemTemplate");
		}
		public static new void SetItemTemplate(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxAccordion.SetOption", dxTarget, "itemTemplate", value);
		}
		public static object GetItemTitleTemplate(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxAccordion.GetOption", dxTarget, "itemTitleTemplate");
		}
		public static void SetItemTitleTemplate(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxAccordion.SetOption", dxTarget, "itemTitleTemplate", value);
		}
		public static bool? GetMultiple(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxAccordion.GetOption", dxTarget, "multiple");
		}
		public static void SetMultiple(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxAccordion.SetOption", dxTarget, "multiple", value);
		}
		public static new float? GetSelectedIndex(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<float?>("BlazorDevExtreme.DxAccordion.GetOption", dxTarget, "selectedIndex");
		}
		public static new void SetSelectedIndex(ElementRef dxTarget, float? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxAccordion.SetOption", dxTarget, "selectedIndex", value);
		}
		public static object CollapseItem(ElementRef dxTarget, float index)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxAccordion.collapseItem_0", dxTarget, index);
		}
		public static object ExpandItem(ElementRef dxTarget, float index)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxAccordion.expandItem_1", dxTarget, index);
		}
		public static object UpdateDimensions(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxAccordion.updateDimensions_2", dxTarget);
		}
	}
	public class DxActionSheetInterop: CollectionWidgetInterop
	{
		public static event EventHandler<JQueryEventArgs> CancelClick;
		public static void Init(ElementRef dxTarget, DevExpress.Ui.DxActionSheetOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxActionSheet.Init", dxTarget, json);
		}
		public static void OnCancelClick(string identifier)
		{
			CancelClick?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static string GetCancelText(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxActionSheet.GetOption", dxTarget, "cancelText");
		}
		public static void SetCancelText(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxActionSheet.SetOption", dxTarget, "cancelText", value);
		}
		public static bool? GetShowCancelButton(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxActionSheet.GetOption", dxTarget, "showCancelButton");
		}
		public static void SetShowCancelButton(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxActionSheet.SetOption", dxTarget, "showCancelButton", value);
		}
		public static bool? GetShowTitle(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxActionSheet.GetOption", dxTarget, "showTitle");
		}
		public static void SetShowTitle(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxActionSheet.SetOption", dxTarget, "showTitle", value);
		}
		public static object GetTarget(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxActionSheet.GetOption", dxTarget, "target");
		}
		public static void SetTarget(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxActionSheet.SetOption", dxTarget, "target", value);
		}
		public static string GetTitle(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxActionSheet.GetOption", dxTarget, "title");
		}
		public static void SetTitle(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxActionSheet.SetOption", dxTarget, "title", value);
		}
		public static bool? GetUsePopover(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxActionSheet.GetOption", dxTarget, "usePopover");
		}
		public static void SetUsePopover(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxActionSheet.SetOption", dxTarget, "usePopover", value);
		}
		public static new bool? GetVisible(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxActionSheet.GetOption", dxTarget, "visible");
		}
		public static new void SetVisible(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxActionSheet.SetOption", dxTarget, "visible", value);
		}
		public static object Hide(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxActionSheet.hide_0", dxTarget);
		}
		public static object Show(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxActionSheet.show_1", dxTarget);
		}
		public static object Toggle(ElementRef dxTarget, bool showing)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxActionSheet.toggle_2", dxTarget, showing);
		}
	}
	public class DxAutocompleteInterop: DxDropDownListInterop
	{
		public static void Init(ElementRef dxTarget, DevExpress.Ui.DxAutocompleteOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxAutocomplete.Init", dxTarget, json);
		}
		public static float? GetMaxItemCount(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<float?>("BlazorDevExtreme.DxAutocomplete.GetOption", dxTarget, "maxItemCount");
		}
		public static void SetMaxItemCount(ElementRef dxTarget, float? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxAutocomplete.SetOption", dxTarget, "maxItemCount", value);
		}
		public static new float? GetMinSearchLength(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<float?>("BlazorDevExtreme.DxAutocomplete.GetOption", dxTarget, "minSearchLength");
		}
		public static new void SetMinSearchLength(ElementRef dxTarget, float? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxAutocomplete.SetOption", dxTarget, "minSearchLength", value);
		}
		public static new string GetValue(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxAutocomplete.GetOption", dxTarget, "value");
		}
		public static new void SetValue(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxAutocomplete.SetOption", dxTarget, "value", value);
		}
	}
	public class DxBoxInterop: CollectionWidgetInterop
	{
		public static void Init(ElementRef dxTarget, DevExpress.Ui.DxBoxOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxBox.Init", dxTarget, json);
		}
		public static string GetAlign(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxBox.GetOption", dxTarget, "align");
		}
		public static void SetAlign(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxBox.SetOption", dxTarget, "align", value);
		}
		public static string GetCrossAlign(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxBox.GetOption", dxTarget, "crossAlign");
		}
		public static void SetCrossAlign(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxBox.SetOption", dxTarget, "crossAlign", value);
		}
		public static string GetDirection(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxBox.GetOption", dxTarget, "direction");
		}
		public static void SetDirection(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxBox.SetOption", dxTarget, "direction", value);
		}
	}
	public class DxButtonInterop: WidgetInterop
	{
		public static event EventHandler<JQueryEventArgs> Click;
		public static void Init(ElementRef dxTarget, DevExpress.Ui.DxButtonOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxButton.Init", dxTarget, json);
		}
		public static void OnClick(string identifier)
		{
			Click?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static new bool? GetActiveStateEnabled(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxButton.GetOption", dxTarget, "activeStateEnabled");
		}
		public static new void SetActiveStateEnabled(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxButton.SetOption", dxTarget, "activeStateEnabled", value);
		}
		public static new bool? GetFocusStateEnabled(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxButton.GetOption", dxTarget, "focusStateEnabled");
		}
		public static new void SetFocusStateEnabled(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxButton.SetOption", dxTarget, "focusStateEnabled", value);
		}
		public static new bool? GetHoverStateEnabled(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxButton.GetOption", dxTarget, "hoverStateEnabled");
		}
		public static new void SetHoverStateEnabled(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxButton.SetOption", dxTarget, "hoverStateEnabled", value);
		}
		public static string GetIcon(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxButton.GetOption", dxTarget, "icon");
		}
		public static void SetIcon(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxButton.SetOption", dxTarget, "icon", value);
		}
		public static object GetTemplate(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxButton.GetOption", dxTarget, "template");
		}
		public static void SetTemplate(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxButton.SetOption", dxTarget, "template", value);
		}
		public static string GetText(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxButton.GetOption", dxTarget, "text");
		}
		public static void SetText(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxButton.SetOption", dxTarget, "text", value);
		}
		public static string GetType(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxButton.GetOption", dxTarget, "type");
		}
		public static void SetType(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxButton.SetOption", dxTarget, "type", value);
		}
		public static bool? GetUseSubmitBehavior(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxButton.GetOption", dxTarget, "useSubmitBehavior");
		}
		public static void SetUseSubmitBehavior(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxButton.SetOption", dxTarget, "useSubmitBehavior", value);
		}
		public static string GetValidationGroup(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxButton.GetOption", dxTarget, "validationGroup");
		}
		public static void SetValidationGroup(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxButton.SetOption", dxTarget, "validationGroup", value);
		}
	}
	public class DxCalendarInterop: EditorInterop
	{
		public static void Init(ElementRef dxTarget, DevExpress.Ui.DxCalendarOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxCalendar.Init", dxTarget, json);
		}
		public static new bool? GetActiveStateEnabled(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxCalendar.GetOption", dxTarget, "activeStateEnabled");
		}
		public static new void SetActiveStateEnabled(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxCalendar.SetOption", dxTarget, "activeStateEnabled", value);
		}
		public static object GetCellTemplate(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxCalendar.GetOption", dxTarget, "cellTemplate");
		}
		public static void SetCellTemplate(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxCalendar.SetOption", dxTarget, "cellTemplate", value);
		}
		public static string GetDateSerializationFormat(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxCalendar.GetOption", dxTarget, "dateSerializationFormat");
		}
		public static void SetDateSerializationFormat(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxCalendar.SetOption", dxTarget, "dateSerializationFormat", value);
		}
		public static object GetDisabledDates(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxCalendar.GetOption", dxTarget, "disabledDates");
		}
		public static void SetDisabledDates(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxCalendar.SetOption", dxTarget, "disabledDates", value);
		}
		public static object GetFirstDayOfWeek(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxCalendar.GetOption", dxTarget, "firstDayOfWeek");
		}
		public static void SetFirstDayOfWeek(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxCalendar.SetOption", dxTarget, "firstDayOfWeek", value);
		}
		public static new bool? GetFocusStateEnabled(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxCalendar.GetOption", dxTarget, "focusStateEnabled");
		}
		public static new void SetFocusStateEnabled(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxCalendar.SetOption", dxTarget, "focusStateEnabled", value);
		}
		public static new bool? GetHoverStateEnabled(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxCalendar.GetOption", dxTarget, "hoverStateEnabled");
		}
		public static new void SetHoverStateEnabled(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxCalendar.SetOption", dxTarget, "hoverStateEnabled", value);
		}
		public static object GetMax(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxCalendar.GetOption", dxTarget, "max");
		}
		public static void SetMax(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxCalendar.SetOption", dxTarget, "max", value);
		}
		public static string GetMaxZoomLevel(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxCalendar.GetOption", dxTarget, "maxZoomLevel");
		}
		public static void SetMaxZoomLevel(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxCalendar.SetOption", dxTarget, "maxZoomLevel", value);
		}
		public static object GetMin(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxCalendar.GetOption", dxTarget, "min");
		}
		public static void SetMin(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxCalendar.SetOption", dxTarget, "min", value);
		}
		public static string GetMinZoomLevel(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxCalendar.GetOption", dxTarget, "minZoomLevel");
		}
		public static void SetMinZoomLevel(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxCalendar.SetOption", dxTarget, "minZoomLevel", value);
		}
		public static string GetName(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxCalendar.GetOption", dxTarget, "name");
		}
		public static void SetName(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxCalendar.SetOption", dxTarget, "name", value);
		}
		public static bool? GetShowTodayButton(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxCalendar.GetOption", dxTarget, "showTodayButton");
		}
		public static void SetShowTodayButton(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxCalendar.SetOption", dxTarget, "showTodayButton", value);
		}
		public static new object GetValue(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxCalendar.GetOption", dxTarget, "value");
		}
		public static new void SetValue(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxCalendar.SetOption", dxTarget, "value", value);
		}
		public static string GetZoomLevel(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxCalendar.GetOption", dxTarget, "zoomLevel");
		}
		public static void SetZoomLevel(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxCalendar.SetOption", dxTarget, "zoomLevel", value);
		}
	}
	public class DxCheckBoxInterop: EditorInterop
	{
		public static void Init(ElementRef dxTarget, DevExpress.Ui.DxCheckBoxOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxCheckBox.Init", dxTarget, json);
		}
		public static new bool? GetActiveStateEnabled(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxCheckBox.GetOption", dxTarget, "activeStateEnabled");
		}
		public static new void SetActiveStateEnabled(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxCheckBox.SetOption", dxTarget, "activeStateEnabled", value);
		}
		public static new bool? GetFocusStateEnabled(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxCheckBox.GetOption", dxTarget, "focusStateEnabled");
		}
		public static new void SetFocusStateEnabled(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxCheckBox.SetOption", dxTarget, "focusStateEnabled", value);
		}
		public static new bool? GetHoverStateEnabled(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxCheckBox.GetOption", dxTarget, "hoverStateEnabled");
		}
		public static new void SetHoverStateEnabled(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxCheckBox.SetOption", dxTarget, "hoverStateEnabled", value);
		}
		public static string GetName(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxCheckBox.GetOption", dxTarget, "name");
		}
		public static void SetName(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxCheckBox.SetOption", dxTarget, "name", value);
		}
		public static string GetText(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxCheckBox.GetOption", dxTarget, "text");
		}
		public static void SetText(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxCheckBox.SetOption", dxTarget, "text", value);
		}
		public static new bool? GetValue(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxCheckBox.GetOption", dxTarget, "value");
		}
		public static new void SetValue(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxCheckBox.SetOption", dxTarget, "value", value);
		}
	}
	public class DxColorBoxInterop: DxDropDownEditorInterop
	{
		public static void Init(ElementRef dxTarget, DevExpress.Ui.DxColorBoxOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxColorBox.Init", dxTarget, json);
		}
		public static string GetApplyButtonText(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxColorBox.GetOption", dxTarget, "applyButtonText");
		}
		public static void SetApplyButtonText(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxColorBox.SetOption", dxTarget, "applyButtonText", value);
		}
		public static new string GetApplyValueMode(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxColorBox.GetOption", dxTarget, "applyValueMode");
		}
		public static new void SetApplyValueMode(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxColorBox.SetOption", dxTarget, "applyValueMode", value);
		}
		public static string GetCancelButtonText(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxColorBox.GetOption", dxTarget, "cancelButtonText");
		}
		public static void SetCancelButtonText(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxColorBox.SetOption", dxTarget, "cancelButtonText", value);
		}
		public static bool? GetEditAlphaChannel(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxColorBox.GetOption", dxTarget, "editAlphaChannel");
		}
		public static void SetEditAlphaChannel(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxColorBox.SetOption", dxTarget, "editAlphaChannel", value);
		}
		public static object GetFieldTemplate(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxColorBox.GetOption", dxTarget, "fieldTemplate");
		}
		public static void SetFieldTemplate(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxColorBox.SetOption", dxTarget, "fieldTemplate", value);
		}
		public static float? GetKeyStep(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<float?>("BlazorDevExtreme.DxColorBox.GetOption", dxTarget, "keyStep");
		}
		public static void SetKeyStep(ElementRef dxTarget, float? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxColorBox.SetOption", dxTarget, "keyStep", value);
		}
		public static new string GetValue(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxColorBox.GetOption", dxTarget, "value");
		}
		public static new void SetValue(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxColorBox.SetOption", dxTarget, "value", value);
		}
	}
	public class DxContextMenuInterop: DxMenuBaseInterop
	{
		public static event EventHandler<JQueryEventArgs> Hidden;
		public static event EventHandler<JQueryEventArgs> Hiding;
		public static event EventHandler<JQueryEventArgs> Positioning;
		public static event EventHandler<JQueryEventArgs> Showing;
		public static event EventHandler<JQueryEventArgs> Shown;
		public static void Init(ElementRef dxTarget, DevExpress.Ui.DxContextMenuOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxContextMenu.Init", dxTarget, json);
		}
		public static void OnHidden(string identifier)
		{
			Hidden?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static void OnHiding(string identifier)
		{
			Hiding?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static void OnPositioning(string identifier)
		{
			Positioning?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static void OnShowing(string identifier)
		{
			Showing?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static void OnShown(string identifier)
		{
			Shown?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static object GetCloseOnOutsideClick(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxContextMenu.GetOption", dxTarget, "closeOnOutsideClick");
		}
		public static void SetCloseOnOutsideClick(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxContextMenu.SetOption", dxTarget, "closeOnOutsideClick", value);
		}
		public static new object GetItems(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxContextMenu.GetOption", dxTarget, "items");
		}
		public static new void SetItems(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxContextMenu.SetOption", dxTarget, "items", value);
		}
		public static object GetPosition(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxContextMenu.GetOption", dxTarget, "position");
		}
		public static void SetPosition(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxContextMenu.SetOption", dxTarget, "position", value);
		}
		public static object GetShowEvent(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxContextMenu.GetOption", dxTarget, "showEvent");
		}
		public static void SetShowEvent(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxContextMenu.SetOption", dxTarget, "showEvent", value);
		}
		public static string GetSubmenuDirection(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxContextMenu.GetOption", dxTarget, "submenuDirection");
		}
		public static void SetSubmenuDirection(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxContextMenu.SetOption", dxTarget, "submenuDirection", value);
		}
		public static object GetTarget(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxContextMenu.GetOption", dxTarget, "target");
		}
		public static void SetTarget(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxContextMenu.SetOption", dxTarget, "target", value);
		}
		public static new bool? GetVisible(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxContextMenu.GetOption", dxTarget, "visible");
		}
		public static new void SetVisible(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxContextMenu.SetOption", dxTarget, "visible", value);
		}
		public static object Hide(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxContextMenu.hide_0", dxTarget);
		}
		public static object Show(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxContextMenu.show_1", dxTarget);
		}
		public static object Toggle(ElementRef dxTarget, bool showing)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxContextMenu.toggle_2", dxTarget, showing);
		}
	}
	public class GridBaseInterop: WidgetInterop
	{
		public static event EventHandler<JQueryEventArgs> AdaptiveDetailRowPreparing;
		public static event EventHandler<JQueryEventArgs> DataErrorOccurred;
		public static event EventHandler<JQueryEventArgs> InitNewRow;
		public static event EventHandler<JQueryEventArgs> KeyDown;
		public static event EventHandler<JQueryEventArgs> RowCollapsed;
		public static event EventHandler<JQueryEventArgs> RowCollapsing;
		public static event EventHandler<JQueryEventArgs> RowExpanded;
		public static event EventHandler<JQueryEventArgs> RowExpanding;
		public static event EventHandler<JQueryEventArgs> RowInserted;
		public static event EventHandler<JQueryEventArgs> RowInserting;
		public static event EventHandler<JQueryEventArgs> RowRemoved;
		public static event EventHandler<JQueryEventArgs> RowRemoving;
		public static event EventHandler<JQueryEventArgs> RowUpdated;
		public static event EventHandler<JQueryEventArgs> RowUpdating;
		public static event EventHandler<JQueryEventArgs> RowValidating;
		public static event EventHandler<JQueryEventArgs> SelectionChanged;
		public static event EventHandler<JQueryEventArgs> ToolbarPreparing;
		public static void Init(ElementRef dxTarget, DevExpress.Ui.GridBaseOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.GridBase.Init", dxTarget, json);
		}
		public static void OnAdaptiveDetailRowPreparing(string identifier)
		{
			AdaptiveDetailRowPreparing?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static void OnDataErrorOccurred(string identifier)
		{
			DataErrorOccurred?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static void OnInitNewRow(string identifier)
		{
			InitNewRow?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static void OnKeyDown(string identifier)
		{
			KeyDown?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static void OnRowCollapsed(string identifier)
		{
			RowCollapsed?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static void OnRowCollapsing(string identifier)
		{
			RowCollapsing?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static void OnRowExpanded(string identifier)
		{
			RowExpanded?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static void OnRowExpanding(string identifier)
		{
			RowExpanding?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static void OnRowInserted(string identifier)
		{
			RowInserted?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static void OnRowInserting(string identifier)
		{
			RowInserting?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static void OnRowRemoved(string identifier)
		{
			RowRemoved?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static void OnRowRemoving(string identifier)
		{
			RowRemoving?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static void OnRowUpdated(string identifier)
		{
			RowUpdated?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static void OnRowUpdating(string identifier)
		{
			RowUpdating?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static void OnRowValidating(string identifier)
		{
			RowValidating?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static void OnSelectionChanged(string identifier)
		{
			SelectionChanged?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static void OnToolbarPreparing(string identifier)
		{
			ToolbarPreparing?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static bool? GetAllowColumnReordering(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.GridBase.GetOption", dxTarget, "allowColumnReordering");
		}
		public static void SetAllowColumnReordering(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.GridBase.SetOption", dxTarget, "allowColumnReordering", value);
		}
		public static bool? GetAllowColumnResizing(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.GridBase.GetOption", dxTarget, "allowColumnResizing");
		}
		public static void SetAllowColumnResizing(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.GridBase.SetOption", dxTarget, "allowColumnResizing", value);
		}
		public static bool? GetCacheEnabled(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.GridBase.GetOption", dxTarget, "cacheEnabled");
		}
		public static void SetCacheEnabled(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.GridBase.SetOption", dxTarget, "cacheEnabled", value);
		}
		public static bool? GetCellHintEnabled(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.GridBase.GetOption", dxTarget, "cellHintEnabled");
		}
		public static void SetCellHintEnabled(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.GridBase.SetOption", dxTarget, "cellHintEnabled", value);
		}
		public static bool? GetColumnAutoWidth(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.GridBase.GetOption", dxTarget, "columnAutoWidth");
		}
		public static void SetColumnAutoWidth(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.GridBase.SetOption", dxTarget, "columnAutoWidth", value);
		}
		public static object GetColumnChooser(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.GridBase.GetOption", dxTarget, "columnChooser");
		}
		public static void SetColumnChooser(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.GridBase.SetOption", dxTarget, "columnChooser", value);
		}
		public static object GetColumnFixing(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.GridBase.GetOption", dxTarget, "columnFixing");
		}
		public static void SetColumnFixing(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.GridBase.SetOption", dxTarget, "columnFixing", value);
		}
		public static bool? GetColumnHidingEnabled(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.GridBase.GetOption", dxTarget, "columnHidingEnabled");
		}
		public static void SetColumnHidingEnabled(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.GridBase.SetOption", dxTarget, "columnHidingEnabled", value);
		}
		public static float? GetColumnMinWidth(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<float?>("BlazorDevExtreme.GridBase.GetOption", dxTarget, "columnMinWidth");
		}
		public static void SetColumnMinWidth(ElementRef dxTarget, float? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.GridBase.SetOption", dxTarget, "columnMinWidth", value);
		}
		public static string GetColumnResizingMode(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.GridBase.GetOption", dxTarget, "columnResizingMode");
		}
		public static void SetColumnResizingMode(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.GridBase.SetOption", dxTarget, "columnResizingMode", value);
		}
		public static object GetColumns(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.GridBase.GetOption", dxTarget, "columns");
		}
		public static void SetColumns(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.GridBase.SetOption", dxTarget, "columns", value);
		}
		public static float? GetColumnWidth(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<float?>("BlazorDevExtreme.GridBase.GetOption", dxTarget, "columnWidth");
		}
		public static void SetColumnWidth(ElementRef dxTarget, float? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.GridBase.SetOption", dxTarget, "columnWidth", value);
		}
		public static object GetDataSource(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.GridBase.GetOption", dxTarget, "dataSource");
		}
		public static void SetDataSource(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.GridBase.SetOption", dxTarget, "dataSource", value);
		}
		public static string GetDateSerializationFormat(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.GridBase.GetOption", dxTarget, "dateSerializationFormat");
		}
		public static void SetDateSerializationFormat(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.GridBase.SetOption", dxTarget, "dateSerializationFormat", value);
		}
		public static object GetEditing(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.GridBase.GetOption", dxTarget, "editing");
		}
		public static void SetEditing(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.GridBase.SetOption", dxTarget, "editing", value);
		}
		public static bool? GetErrorRowEnabled(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.GridBase.GetOption", dxTarget, "errorRowEnabled");
		}
		public static void SetErrorRowEnabled(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.GridBase.SetOption", dxTarget, "errorRowEnabled", value);
		}
		public static object GetFilterBuilder(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.GridBase.GetOption", dxTarget, "filterBuilder");
		}
		public static void SetFilterBuilder(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.GridBase.SetOption", dxTarget, "filterBuilder", value);
		}
		public static object GetFilterBuilderPopup(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.GridBase.GetOption", dxTarget, "filterBuilderPopup");
		}
		public static void SetFilterBuilderPopup(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.GridBase.SetOption", dxTarget, "filterBuilderPopup", value);
		}
		public static object GetFilterPanel(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.GridBase.GetOption", dxTarget, "filterPanel");
		}
		public static void SetFilterPanel(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.GridBase.SetOption", dxTarget, "filterPanel", value);
		}
		public static object GetFilterRow(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.GridBase.GetOption", dxTarget, "filterRow");
		}
		public static void SetFilterRow(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.GridBase.SetOption", dxTarget, "filterRow", value);
		}
		public static object GetFilterSyncEnabled(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.GridBase.GetOption", dxTarget, "filterSyncEnabled");
		}
		public static void SetFilterSyncEnabled(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.GridBase.SetOption", dxTarget, "filterSyncEnabled", value);
		}
		public static object GetFilterValue(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.GridBase.GetOption", dxTarget, "filterValue");
		}
		public static void SetFilterValue(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.GridBase.SetOption", dxTarget, "filterValue", value);
		}
		public static object GetHeaderFilter(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.GridBase.GetOption", dxTarget, "headerFilter");
		}
		public static void SetHeaderFilter(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.GridBase.SetOption", dxTarget, "headerFilter", value);
		}
		public static object GetLoadPanel(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.GridBase.GetOption", dxTarget, "loadPanel");
		}
		public static void SetLoadPanel(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.GridBase.SetOption", dxTarget, "loadPanel", value);
		}
		public static string GetNoDataText(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.GridBase.GetOption", dxTarget, "noDataText");
		}
		public static void SetNoDataText(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.GridBase.SetOption", dxTarget, "noDataText", value);
		}
		public static object GetPager(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.GridBase.GetOption", dxTarget, "pager");
		}
		public static void SetPager(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.GridBase.SetOption", dxTarget, "pager", value);
		}
		public static object GetPaging(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.GridBase.GetOption", dxTarget, "paging");
		}
		public static void SetPaging(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.GridBase.SetOption", dxTarget, "paging", value);
		}
		public static bool? GetRowAlternationEnabled(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.GridBase.GetOption", dxTarget, "rowAlternationEnabled");
		}
		public static void SetRowAlternationEnabled(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.GridBase.SetOption", dxTarget, "rowAlternationEnabled", value);
		}
		public static object GetScrolling(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.GridBase.GetOption", dxTarget, "scrolling");
		}
		public static void SetScrolling(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.GridBase.SetOption", dxTarget, "scrolling", value);
		}
		public static object GetSearchPanel(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.GridBase.GetOption", dxTarget, "searchPanel");
		}
		public static void SetSearchPanel(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.GridBase.SetOption", dxTarget, "searchPanel", value);
		}
		public static object GetSelectedRowKeys(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.GridBase.GetOption", dxTarget, "selectedRowKeys");
		}
		public static void SetSelectedRowKeys(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.GridBase.SetOption", dxTarget, "selectedRowKeys", value);
		}
		public static object GetSelection(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.GridBase.GetOption", dxTarget, "selection");
		}
		public static void SetSelection(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.GridBase.SetOption", dxTarget, "selection", value);
		}
		public static bool? GetShowBorders(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.GridBase.GetOption", dxTarget, "showBorders");
		}
		public static void SetShowBorders(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.GridBase.SetOption", dxTarget, "showBorders", value);
		}
		public static bool? GetShowColumnHeaders(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.GridBase.GetOption", dxTarget, "showColumnHeaders");
		}
		public static void SetShowColumnHeaders(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.GridBase.SetOption", dxTarget, "showColumnHeaders", value);
		}
		public static bool? GetShowColumnLines(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.GridBase.GetOption", dxTarget, "showColumnLines");
		}
		public static void SetShowColumnLines(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.GridBase.SetOption", dxTarget, "showColumnLines", value);
		}
		public static bool? GetShowRowLines(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.GridBase.GetOption", dxTarget, "showRowLines");
		}
		public static void SetShowRowLines(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.GridBase.SetOption", dxTarget, "showRowLines", value);
		}
		public static object GetSorting(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.GridBase.GetOption", dxTarget, "sorting");
		}
		public static void SetSorting(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.GridBase.SetOption", dxTarget, "sorting", value);
		}
		public static object GetStateStoring(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.GridBase.GetOption", dxTarget, "stateStoring");
		}
		public static void SetStateStoring(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.GridBase.SetOption", dxTarget, "stateStoring", value);
		}
		public static bool? GetTwoWayBindingEnabled(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.GridBase.GetOption", dxTarget, "twoWayBindingEnabled");
		}
		public static void SetTwoWayBindingEnabled(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.GridBase.SetOption", dxTarget, "twoWayBindingEnabled", value);
		}
		public static bool? GetWordWrapEnabled(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.GridBase.GetOption", dxTarget, "wordWrapEnabled");
		}
		public static void SetWordWrapEnabled(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.GridBase.SetOption", dxTarget, "wordWrapEnabled", value);
		}
		public static void BeginCustomLoading(ElementRef dxTarget, string messageText)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.GridBase.beginCustomLoading_0", dxTarget, messageText);
		}
		public static object ByKey(ElementRef dxTarget, object key)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.GridBase.byKey_1", dxTarget, key);
		}
		public static void CancelEditData(ElementRef dxTarget)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.GridBase.cancelEditData_2", dxTarget);
		}
		public static object CellValue(ElementRef dxTarget, float rowIndex, string dataField)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.GridBase.cellValue_3", dxTarget, rowIndex, dataField);
		}
		public static void CellValue(ElementRef dxTarget, float rowIndex, string dataField, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.GridBase.cellValue_4", dxTarget, rowIndex, dataField, value);
		}
		public static object CellValue(ElementRef dxTarget, float rowIndex, float visibleColumnIndex)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.GridBase.cellValue_5", dxTarget, rowIndex, visibleColumnIndex);
		}
		public static void CellValue(ElementRef dxTarget, float rowIndex, float visibleColumnIndex, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.GridBase.cellValue_6", dxTarget, rowIndex, visibleColumnIndex, value);
		}
		public static void ClearFilter(ElementRef dxTarget)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.GridBase.clearFilter_7", dxTarget);
		}
		public static void ClearFilter(ElementRef dxTarget, string filterName)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.GridBase.clearFilter_8", dxTarget, filterName);
		}
		public static void ClearSelection(ElementRef dxTarget)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.GridBase.clearSelection_9", dxTarget);
		}
		public static void ClearSorting(ElementRef dxTarget)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.GridBase.clearSorting_10", dxTarget);
		}
		public static void CloseEditCell(ElementRef dxTarget)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.GridBase.closeEditCell_11", dxTarget);
		}
		public static void CollapseAdaptiveDetailRow(ElementRef dxTarget)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.GridBase.collapseAdaptiveDetailRow_12", dxTarget);
		}
		public static float ColumnCount(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<float>("BlazorDevExtreme.GridBase.columnCount_13", dxTarget);
		}
		public static object ColumnOption(ElementRef dxTarget, object id)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.GridBase.columnOption_14", dxTarget, id);
		}
		public static object ColumnOption(ElementRef dxTarget, object id, string optionName)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.GridBase.columnOption_15", dxTarget, id, optionName);
		}
		public static void ColumnOption(ElementRef dxTarget, object id, string optionName, object optionValue)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.GridBase.columnOption_16", dxTarget, id, optionName, optionValue);
		}
		public static void ColumnOption(ElementRef dxTarget, object id, object options)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.GridBase.columnOption_17", dxTarget, id, options);
		}
		public static void DeleteColumn(ElementRef dxTarget, object id)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.GridBase.deleteColumn_18", dxTarget, id);
		}
		public static void DeleteRow(ElementRef dxTarget, float rowIndex)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.GridBase.deleteRow_19", dxTarget, rowIndex);
		}
		public static object DeselectAll(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.GridBase.deselectAll_20", dxTarget);
		}
		public static object DeselectRows(ElementRef dxTarget, object keys)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.GridBase.deselectRows_21", dxTarget, keys);
		}
		public static void EditCell(ElementRef dxTarget, float rowIndex, string dataField)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.GridBase.editCell_22", dxTarget, rowIndex, dataField);
		}
		public static void EditCell(ElementRef dxTarget, float rowIndex, float visibleColumnIndex)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.GridBase.editCell_23", dxTarget, rowIndex, visibleColumnIndex);
		}
		public static void EditRow(ElementRef dxTarget, float rowIndex)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.GridBase.editRow_24", dxTarget, rowIndex);
		}
		public static void EndCustomLoading(ElementRef dxTarget)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.GridBase.endCustomLoading_25", dxTarget);
		}
		public static void ExpandAdaptiveDetailRow(ElementRef dxTarget, object key)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.GridBase.expandAdaptiveDetailRow_26", dxTarget, key);
		}
		public static object Filter(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.GridBase.filter_27", dxTarget);
		}
		public static void Filter(ElementRef dxTarget, object filterExpr)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.GridBase.filter_28", dxTarget, filterExpr);
		}
		public static void Focus(ElementRef dxTarget)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.GridBase.focus_29", dxTarget);
		}
		public static void Focus(ElementRef dxTarget, object element)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.GridBase.focus_30", dxTarget, element);
		}
		public static object GetCellElement(ElementRef dxTarget, float rowIndex, string dataField)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.GridBase.getCellElement_31", dxTarget, rowIndex, dataField);
		}
		public static object GetCellElement(ElementRef dxTarget, float rowIndex, float visibleColumnIndex)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.GridBase.getCellElement_32", dxTarget, rowIndex, visibleColumnIndex);
		}
		public static object GetCombinedFilter(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.GridBase.getCombinedFilter_33", dxTarget);
		}
		public static object GetCombinedFilter(ElementRef dxTarget, bool returnDataField)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.GridBase.getCombinedFilter_34", dxTarget, returnDataField);
		}
		public static object GetDataSourceEx(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.GridBase.getDataSource_35", dxTarget);
		}
		public static object GetKeyByRowIndex(ElementRef dxTarget, float rowIndex)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.GridBase.getKeyByRowIndex_36", dxTarget, rowIndex);
		}
		public static object GetRowElement(ElementRef dxTarget, float rowIndex)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.GridBase.getRowElement_37", dxTarget, rowIndex);
		}
		public static float GetRowIndexByKey(ElementRef dxTarget, object key)
		{
			return RegisteredFunction.Invoke<float>("BlazorDevExtreme.GridBase.getRowIndexByKey_38", dxTarget, key);
		}
		public static object GetScrollable(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.GridBase.getScrollable_39", dxTarget);
		}
		public static bool HasEditData(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool>("BlazorDevExtreme.GridBase.hasEditData_40", dxTarget);
		}
		public static void HideColumnChooser(ElementRef dxTarget)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.GridBase.hideColumnChooser_41", dxTarget);
		}
		public static void IsAdaptiveDetailRowExpanded(ElementRef dxTarget, object key)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.GridBase.isAdaptiveDetailRowExpanded_42", dxTarget, key);
		}
		public static bool IsRowSelected(ElementRef dxTarget, object key)
		{
			return RegisteredFunction.Invoke<bool>("BlazorDevExtreme.GridBase.isRowSelected_43", dxTarget, key);
		}
		public static object KeyOf(ElementRef dxTarget, object obj)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.GridBase.keyOf_44", dxTarget, obj);
		}
		public static float PageCount(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<float>("BlazorDevExtreme.GridBase.pageCount_45", dxTarget);
		}
		public static float PageIndex(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<float>("BlazorDevExtreme.GridBase.pageIndex_46", dxTarget);
		}
		public static object PageIndex(ElementRef dxTarget, float newIndex)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.GridBase.pageIndex_47", dxTarget, newIndex);
		}
		public static float PageSize(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<float>("BlazorDevExtreme.GridBase.pageSize_48", dxTarget);
		}
		public static void PageSize(ElementRef dxTarget, float value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.GridBase.pageSize_49", dxTarget, value);
		}
		public static object Refresh(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.GridBase.refresh_50", dxTarget);
		}
		public static void RepaintRows(ElementRef dxTarget, object rowIndexes)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.GridBase.repaintRows_51", dxTarget, rowIndexes);
		}
		public static object SaveEditData(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.GridBase.saveEditData_52", dxTarget);
		}
		public static void SearchByText(ElementRef dxTarget, string text)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.GridBase.searchByText_53", dxTarget, text);
		}
		public static object SelectAll(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.GridBase.selectAll_54", dxTarget);
		}
		public static object SelectRows(ElementRef dxTarget, object keys, bool preserve)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.GridBase.selectRows_55", dxTarget, keys, preserve);
		}
		public static object SelectRowsByIndexes(ElementRef dxTarget, object indexes)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.GridBase.selectRowsByIndexes_56", dxTarget, indexes);
		}
		public static void ShowColumnChooser(ElementRef dxTarget)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.GridBase.showColumnChooser_57", dxTarget);
		}
		public static object State(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.GridBase.state_58", dxTarget);
		}
		public static void State(ElementRef dxTarget, object state)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.GridBase.state_59", dxTarget, state);
		}
		public static void UndeleteRow(ElementRef dxTarget, float rowIndex)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.GridBase.undeleteRow_60", dxTarget, rowIndex);
		}
		public static void UpdateDimensions(ElementRef dxTarget)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.GridBase.updateDimensions_61", dxTarget);
		}
	}
	public class DxDataGridInterop: GridBaseInterop
	{
		public static event EventHandler<JQueryEventArgs> CellClick;
		public static event EventHandler<JQueryEventArgs> CellHoverChanged;
		public static event EventHandler<JQueryEventArgs> CellPrepared;
		public static event EventHandler<JQueryEventArgs> ContextMenuPreparing;
		public static event EventHandler<JQueryEventArgs> EditingStart;
		public static event EventHandler<JQueryEventArgs> EditorPrepared;
		public static event EventHandler<JQueryEventArgs> EditorPreparing;
		public static event EventHandler<JQueryEventArgs> Exported;
		public static event EventHandler<JQueryEventArgs> Exporting;
		public static event EventHandler<JQueryEventArgs> FileSaving;
		public static event EventHandler<JQueryEventArgs> RowClick;
		public static event EventHandler<JQueryEventArgs> RowPrepared;
		public static void Init(ElementRef dxTarget, DevExpress.Ui.DxDataGridOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDataGrid.Init", dxTarget, json);
		}
		public static void OnCellClick(string identifier)
		{
			CellClick?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static void OnCellHoverChanged(string identifier)
		{
			CellHoverChanged?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static void OnCellPrepared(string identifier)
		{
			CellPrepared?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static void OnContextMenuPreparing(string identifier)
		{
			ContextMenuPreparing?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static void OnEditingStart(string identifier)
		{
			EditingStart?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static void OnEditorPrepared(string identifier)
		{
			EditorPrepared?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static void OnEditorPreparing(string identifier)
		{
			EditorPreparing?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static void OnExported(string identifier)
		{
			Exported?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static void OnExporting(string identifier)
		{
			Exporting?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static void OnFileSaving(string identifier)
		{
			FileSaving?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static void OnRowClick(string identifier)
		{
			RowClick?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static void OnRowPrepared(string identifier)
		{
			RowPrepared?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static new object GetColumns(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDataGrid.GetOption", dxTarget, "columns");
		}
		public static new void SetColumns(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDataGrid.SetOption", dxTarget, "columns", value);
		}
		public static object GetCustomizeColumns(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDataGrid.GetOption", dxTarget, "customizeColumns");
		}
		public static void SetCustomizeColumns(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDataGrid.SetOption", dxTarget, "customizeColumns", value);
		}
		public static object GetCustomizeExportData(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDataGrid.GetOption", dxTarget, "customizeExportData");
		}
		public static void SetCustomizeExportData(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDataGrid.SetOption", dxTarget, "customizeExportData", value);
		}
		public static new object GetEditing(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDataGrid.GetOption", dxTarget, "editing");
		}
		public static new void SetEditing(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDataGrid.SetOption", dxTarget, "editing", value);
		}
		public static object GetExport(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDataGrid.GetOption", dxTarget, "export");
		}
		public static void SetExport(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDataGrid.SetOption", dxTarget, "export", value);
		}
		public static object GetGrouping(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDataGrid.GetOption", dxTarget, "grouping");
		}
		public static void SetGrouping(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDataGrid.SetOption", dxTarget, "grouping", value);
		}
		public static object GetGroupPanel(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDataGrid.GetOption", dxTarget, "groupPanel");
		}
		public static void SetGroupPanel(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDataGrid.SetOption", dxTarget, "groupPanel", value);
		}
		public static object GetKeyExpr(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDataGrid.GetOption", dxTarget, "keyExpr");
		}
		public static void SetKeyExpr(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDataGrid.SetOption", dxTarget, "keyExpr", value);
		}
		public static object GetMasterDetail(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDataGrid.GetOption", dxTarget, "masterDetail");
		}
		public static void SetMasterDetail(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDataGrid.SetOption", dxTarget, "masterDetail", value);
		}
		public static object GetRemoteOperations(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDataGrid.GetOption", dxTarget, "remoteOperations");
		}
		public static void SetRemoteOperations(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDataGrid.SetOption", dxTarget, "remoteOperations", value);
		}
		public static object GetRowTemplate(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDataGrid.GetOption", dxTarget, "rowTemplate");
		}
		public static void SetRowTemplate(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDataGrid.SetOption", dxTarget, "rowTemplate", value);
		}
		public static new object GetScrolling(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDataGrid.GetOption", dxTarget, "scrolling");
		}
		public static new void SetScrolling(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDataGrid.SetOption", dxTarget, "scrolling", value);
		}
		public static new object GetSelection(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDataGrid.GetOption", dxTarget, "selection");
		}
		public static new void SetSelection(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDataGrid.SetOption", dxTarget, "selection", value);
		}
		public static object GetSelectionFilter(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDataGrid.GetOption", dxTarget, "selectionFilter");
		}
		public static void SetSelectionFilter(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDataGrid.SetOption", dxTarget, "selectionFilter", value);
		}
		public static object GetSortByGroupSummaryInfo(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDataGrid.GetOption", dxTarget, "sortByGroupSummaryInfo");
		}
		public static void SetSortByGroupSummaryInfo(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDataGrid.SetOption", dxTarget, "sortByGroupSummaryInfo", value);
		}
		public static object GetSummary(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDataGrid.GetOption", dxTarget, "summary");
		}
		public static void SetSummary(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDataGrid.SetOption", dxTarget, "summary", value);
		}
		public static void AddColumn(ElementRef dxTarget, object columnOptions)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDataGrid.addColumn_0", dxTarget, columnOptions);
		}
		public static void AddRow(ElementRef dxTarget)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDataGrid.addRow_1", dxTarget);
		}
		public static void ClearGrouping(ElementRef dxTarget)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDataGrid.clearGrouping_2", dxTarget);
		}
		public static void CollapseAll(ElementRef dxTarget, float groupIndex)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDataGrid.collapseAll_3", dxTarget, groupIndex);
		}
		public static object CollapseRow(ElementRef dxTarget, object key)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDataGrid.collapseRow_4", dxTarget, key);
		}
		public static void ExpandAll(ElementRef dxTarget, float groupIndex)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDataGrid.expandAll_5", dxTarget, groupIndex);
		}
		public static object ExpandRow(ElementRef dxTarget, object key)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDataGrid.expandRow_6", dxTarget, key);
		}
		public static void ExportToExcel(ElementRef dxTarget, bool selectionOnly)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDataGrid.exportToExcel_7", dxTarget, selectionOnly);
		}
		public static object GetSelectedRowKeys(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDataGrid.getSelectedRowKeys_8", dxTarget);
		}
		public static object GetSelectedRowsData(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDataGrid.getSelectedRowsData_9", dxTarget);
		}
		public static object GetTotalSummaryValue(ElementRef dxTarget, string summaryItemName)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDataGrid.getTotalSummaryValue_10", dxTarget, summaryItemName);
		}
		public static object GetVisibleColumns(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDataGrid.getVisibleColumns_11", dxTarget);
		}
		public static object GetVisibleColumns(ElementRef dxTarget, float headerLevel)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDataGrid.getVisibleColumns_12", dxTarget, headerLevel);
		}
		public static object GetVisibleRows(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDataGrid.getVisibleRows_13", dxTarget);
		}
		public static void InsertRow(ElementRef dxTarget)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDataGrid.insertRow_14", dxTarget);
		}
		public static bool IsRowExpanded(ElementRef dxTarget, object key)
		{
			return RegisteredFunction.Invoke<bool>("BlazorDevExtreme.DxDataGrid.isRowExpanded_15", dxTarget, key);
		}
		public static bool IsRowSelected(ElementRef dxTarget, object data)
		{
			return RegisteredFunction.Invoke<bool>("BlazorDevExtreme.DxDataGrid.isRowSelected_16", dxTarget, data);
		}
		public static void RemoveRow(ElementRef dxTarget, float rowIndex)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDataGrid.removeRow_18", dxTarget, rowIndex);
		}
		public static float TotalCount(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<float>("BlazorDevExtreme.DxDataGrid.totalCount_19", dxTarget);
		}
	}
	public class DxDateBoxInterop: DxDropDownEditorInterop
	{
		public static void Init(ElementRef dxTarget, DevExpress.Ui.DxDateBoxOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDateBox.Init", dxTarget, json);
		}
		public static bool? GetAdaptivityEnabled(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxDateBox.GetOption", dxTarget, "adaptivityEnabled");
		}
		public static void SetAdaptivityEnabled(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDateBox.SetOption", dxTarget, "adaptivityEnabled", value);
		}
		public static string GetApplyButtonText(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxDateBox.GetOption", dxTarget, "applyButtonText");
		}
		public static void SetApplyButtonText(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDateBox.SetOption", dxTarget, "applyButtonText", value);
		}
		public static object GetCalendarOptions(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDateBox.GetOption", dxTarget, "calendarOptions");
		}
		public static void SetCalendarOptions(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDateBox.SetOption", dxTarget, "calendarOptions", value);
		}
		public static string GetCancelButtonText(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxDateBox.GetOption", dxTarget, "cancelButtonText");
		}
		public static void SetCancelButtonText(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDateBox.SetOption", dxTarget, "cancelButtonText", value);
		}
		public static string GetDateOutOfRangeMessage(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxDateBox.GetOption", dxTarget, "dateOutOfRangeMessage");
		}
		public static void SetDateOutOfRangeMessage(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDateBox.SetOption", dxTarget, "dateOutOfRangeMessage", value);
		}
		public static string GetDateSerializationFormat(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxDateBox.GetOption", dxTarget, "dateSerializationFormat");
		}
		public static void SetDateSerializationFormat(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDateBox.SetOption", dxTarget, "dateSerializationFormat", value);
		}
		public static object GetDisabledDates(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDateBox.GetOption", dxTarget, "disabledDates");
		}
		public static void SetDisabledDates(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDateBox.SetOption", dxTarget, "disabledDates", value);
		}
		public static object GetDisplayFormat(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDateBox.GetOption", dxTarget, "displayFormat");
		}
		public static void SetDisplayFormat(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDateBox.SetOption", dxTarget, "displayFormat", value);
		}
		public static float? GetInterval(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<float?>("BlazorDevExtreme.DxDateBox.GetOption", dxTarget, "interval");
		}
		public static void SetInterval(ElementRef dxTarget, float? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDateBox.SetOption", dxTarget, "interval", value);
		}
		public static string GetInvalidDateMessage(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxDateBox.GetOption", dxTarget, "invalidDateMessage");
		}
		public static void SetInvalidDateMessage(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDateBox.SetOption", dxTarget, "invalidDateMessage", value);
		}
		public static object GetMax(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDateBox.GetOption", dxTarget, "max");
		}
		public static void SetMax(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDateBox.SetOption", dxTarget, "max", value);
		}
		public static string GetMaxZoomLevel(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxDateBox.GetOption", dxTarget, "maxZoomLevel");
		}
		public static void SetMaxZoomLevel(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDateBox.SetOption", dxTarget, "maxZoomLevel", value);
		}
		public static object GetMin(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDateBox.GetOption", dxTarget, "min");
		}
		public static void SetMin(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDateBox.SetOption", dxTarget, "min", value);
		}
		public static string GetMinZoomLevel(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxDateBox.GetOption", dxTarget, "minZoomLevel");
		}
		public static void SetMinZoomLevel(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDateBox.SetOption", dxTarget, "minZoomLevel", value);
		}
		public static string GetPickerType(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxDateBox.GetOption", dxTarget, "pickerType");
		}
		public static void SetPickerType(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDateBox.SetOption", dxTarget, "pickerType", value);
		}
		public static new string GetPlaceholder(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxDateBox.GetOption", dxTarget, "placeholder");
		}
		public static new void SetPlaceholder(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDateBox.SetOption", dxTarget, "placeholder", value);
		}
		public static bool? GetShowAnalogClock(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxDateBox.GetOption", dxTarget, "showAnalogClock");
		}
		public static void SetShowAnalogClock(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDateBox.SetOption", dxTarget, "showAnalogClock", value);
		}
		public static string GetType(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxDateBox.GetOption", dxTarget, "type");
		}
		public static void SetType(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDateBox.SetOption", dxTarget, "type", value);
		}
		public static new object GetValue(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDateBox.GetOption", dxTarget, "value");
		}
		public static new void SetValue(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDateBox.SetOption", dxTarget, "value", value);
		}
		public static void Close(ElementRef dxTarget)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDateBox.close_0", dxTarget);
		}
		public static void Open(ElementRef dxTarget)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDateBox.open_1", dxTarget);
		}
	}
	public class DxDeferRenderingInterop: WidgetInterop
	{
		public static event EventHandler<JQueryEventArgs> Rendered;
		public static event EventHandler<JQueryEventArgs> Shown;
		public static void Init(ElementRef dxTarget, DevExpress.Ui.DxDeferRenderingOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDeferRendering.Init", dxTarget, json);
		}
		public static void OnRendered(string identifier)
		{
			Rendered?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static void OnShown(string identifier)
		{
			Shown?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static object GetAnimation(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDeferRendering.GetOption", dxTarget, "animation");
		}
		public static void SetAnimation(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDeferRendering.SetOption", dxTarget, "animation", value);
		}
		public static object GetRenderWhen(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDeferRendering.GetOption", dxTarget, "renderWhen");
		}
		public static void SetRenderWhen(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDeferRendering.SetOption", dxTarget, "renderWhen", value);
		}
		public static bool? GetShowLoadIndicator(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxDeferRendering.GetOption", dxTarget, "showLoadIndicator");
		}
		public static void SetShowLoadIndicator(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDeferRendering.SetOption", dxTarget, "showLoadIndicator", value);
		}
		public static string GetStaggerItemSelector(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxDeferRendering.GetOption", dxTarget, "staggerItemSelector");
		}
		public static void SetStaggerItemSelector(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDeferRendering.SetOption", dxTarget, "staggerItemSelector", value);
		}
	}
	public class DxDropDownBoxInterop: DxDropDownEditorInterop
	{
		public static void Init(ElementRef dxTarget, DevExpress.Ui.DxDropDownBoxOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDropDownBox.Init", dxTarget, json);
		}
		public static new bool? GetAcceptCustomValue(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxDropDownBox.GetOption", dxTarget, "acceptCustomValue");
		}
		public static new void SetAcceptCustomValue(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDropDownBox.SetOption", dxTarget, "acceptCustomValue", value);
		}
		public static object GetContentTemplate(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDropDownBox.GetOption", dxTarget, "contentTemplate");
		}
		public static void SetContentTemplate(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDropDownBox.SetOption", dxTarget, "contentTemplate", value);
		}
		public static object GetDropDownOptions(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDropDownBox.GetOption", dxTarget, "dropDownOptions");
		}
		public static void SetDropDownOptions(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDropDownBox.SetOption", dxTarget, "dropDownOptions", value);
		}
		public static object GetFieldTemplate(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDropDownBox.GetOption", dxTarget, "fieldTemplate");
		}
		public static void SetFieldTemplate(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDropDownBox.SetOption", dxTarget, "fieldTemplate", value);
		}
		public static new string GetValueChangeEvent(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxDropDownBox.GetOption", dxTarget, "valueChangeEvent");
		}
		public static new void SetValueChangeEvent(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDropDownBox.SetOption", dxTarget, "valueChangeEvent", value);
		}
		public static object GetDataSourceEx(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDropDownBox.getDataSource_0", dxTarget);
		}
	}
	public class DxDropDownMenuInterop: WidgetInterop
	{
		public static event EventHandler<JQueryEventArgs> ButtonClick;
		public static event EventHandler<JQueryEventArgs> ItemClick;
		public static void Init(ElementRef dxTarget, DevExpress.Ui.DxDropDownMenuOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDropDownMenu.Init", dxTarget, json);
		}
		public static void OnButtonClick(string identifier)
		{
			ButtonClick?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static void OnItemClick(string identifier)
		{
			ItemClick?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static new bool? GetActiveStateEnabled(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxDropDownMenu.GetOption", dxTarget, "activeStateEnabled");
		}
		public static new void SetActiveStateEnabled(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDropDownMenu.SetOption", dxTarget, "activeStateEnabled", value);
		}
		public static string GetButtonIcon(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxDropDownMenu.GetOption", dxTarget, "buttonIcon");
		}
		public static void SetButtonIcon(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDropDownMenu.SetOption", dxTarget, "buttonIcon", value);
		}
		public static string GetButtonText(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxDropDownMenu.GetOption", dxTarget, "buttonText");
		}
		public static void SetButtonText(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDropDownMenu.SetOption", dxTarget, "buttonText", value);
		}
		public static object GetDataSource(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDropDownMenu.GetOption", dxTarget, "dataSource");
		}
		public static void SetDataSource(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDropDownMenu.SetOption", dxTarget, "dataSource", value);
		}
		public static new bool? GetHoverStateEnabled(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxDropDownMenu.GetOption", dxTarget, "hoverStateEnabled");
		}
		public static new void SetHoverStateEnabled(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDropDownMenu.SetOption", dxTarget, "hoverStateEnabled", value);
		}
		public static object GetItems(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDropDownMenu.GetOption", dxTarget, "items");
		}
		public static void SetItems(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDropDownMenu.SetOption", dxTarget, "items", value);
		}
		public static object GetItemTemplate(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDropDownMenu.GetOption", dxTarget, "itemTemplate");
		}
		public static void SetItemTemplate(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDropDownMenu.SetOption", dxTarget, "itemTemplate", value);
		}
		public static bool? GetOpened(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxDropDownMenu.GetOption", dxTarget, "opened");
		}
		public static void SetOpened(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDropDownMenu.SetOption", dxTarget, "opened", value);
		}
		public static object GetPopupHeight(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDropDownMenu.GetOption", dxTarget, "popupHeight");
		}
		public static void SetPopupHeight(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDropDownMenu.SetOption", dxTarget, "popupHeight", value);
		}
		public static object GetPopupWidth(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDropDownMenu.GetOption", dxTarget, "popupWidth");
		}
		public static void SetPopupWidth(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDropDownMenu.SetOption", dxTarget, "popupWidth", value);
		}
		public static bool? GetUsePopover(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxDropDownMenu.GetOption", dxTarget, "usePopover");
		}
		public static void SetUsePopover(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDropDownMenu.SetOption", dxTarget, "usePopover", value);
		}
		public static void Close(ElementRef dxTarget)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDropDownMenu.close_0", dxTarget);
		}
		public static void Open(ElementRef dxTarget)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDropDownMenu.open_1", dxTarget);
		}
	}
	public class DxFileUploaderInterop: EditorInterop
	{
		public static event EventHandler<JQueryEventArgs> Progress;
		public static event EventHandler<JQueryEventArgs> UploadAborted;
		public static event EventHandler<JQueryEventArgs> Uploaded;
		public static event EventHandler<JQueryEventArgs> UploadError;
		public static event EventHandler<JQueryEventArgs> UploadStarted;
		public static event EventHandler<JQueryEventArgs> ValueChanged;
		public static void Init(ElementRef dxTarget, DevExpress.Ui.DxFileUploaderOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxFileUploader.Init", dxTarget, json);
		}
		public static void OnProgress(string identifier)
		{
			Progress?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static void OnUploadAborted(string identifier)
		{
			UploadAborted?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static void OnUploaded(string identifier)
		{
			Uploaded?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static void OnUploadError(string identifier)
		{
			UploadError?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static void OnUploadStarted(string identifier)
		{
			UploadStarted?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static void OnValueChanged(string identifier)
		{
			ValueChanged?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static string GetAccept(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxFileUploader.GetOption", dxTarget, "accept");
		}
		public static void SetAccept(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxFileUploader.SetOption", dxTarget, "accept", value);
		}
		public static bool? GetAllowCanceling(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxFileUploader.GetOption", dxTarget, "allowCanceling");
		}
		public static void SetAllowCanceling(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxFileUploader.SetOption", dxTarget, "allowCanceling", value);
		}
		public static new bool? GetFocusStateEnabled(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxFileUploader.GetOption", dxTarget, "focusStateEnabled");
		}
		public static new void SetFocusStateEnabled(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxFileUploader.SetOption", dxTarget, "focusStateEnabled", value);
		}
		public static string GetLabelText(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxFileUploader.GetOption", dxTarget, "labelText");
		}
		public static void SetLabelText(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxFileUploader.SetOption", dxTarget, "labelText", value);
		}
		public static bool? GetMultiple(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxFileUploader.GetOption", dxTarget, "multiple");
		}
		public static void SetMultiple(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxFileUploader.SetOption", dxTarget, "multiple", value);
		}
		public static string GetName(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxFileUploader.GetOption", dxTarget, "name");
		}
		public static void SetName(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxFileUploader.SetOption", dxTarget, "name", value);
		}
		public static float? GetProgress(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<float?>("BlazorDevExtreme.DxFileUploader.GetOption", dxTarget, "progress");
		}
		public static void SetProgress(ElementRef dxTarget, float? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxFileUploader.SetOption", dxTarget, "progress", value);
		}
		public static string GetReadyToUploadMessage(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxFileUploader.GetOption", dxTarget, "readyToUploadMessage");
		}
		public static void SetReadyToUploadMessage(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxFileUploader.SetOption", dxTarget, "readyToUploadMessage", value);
		}
		public static string GetSelectButtonText(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxFileUploader.GetOption", dxTarget, "selectButtonText");
		}
		public static void SetSelectButtonText(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxFileUploader.SetOption", dxTarget, "selectButtonText", value);
		}
		public static bool? GetShowFileList(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxFileUploader.GetOption", dxTarget, "showFileList");
		}
		public static void SetShowFileList(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxFileUploader.SetOption", dxTarget, "showFileList", value);
		}
		public static string GetUploadButtonText(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxFileUploader.GetOption", dxTarget, "uploadButtonText");
		}
		public static void SetUploadButtonText(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxFileUploader.SetOption", dxTarget, "uploadButtonText", value);
		}
		public static string GetUploadedMessage(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxFileUploader.GetOption", dxTarget, "uploadedMessage");
		}
		public static void SetUploadedMessage(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxFileUploader.SetOption", dxTarget, "uploadedMessage", value);
		}
		public static string GetUploadFailedMessage(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxFileUploader.GetOption", dxTarget, "uploadFailedMessage");
		}
		public static void SetUploadFailedMessage(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxFileUploader.SetOption", dxTarget, "uploadFailedMessage", value);
		}
		public static object GetUploadHeaders(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxFileUploader.GetOption", dxTarget, "uploadHeaders");
		}
		public static void SetUploadHeaders(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxFileUploader.SetOption", dxTarget, "uploadHeaders", value);
		}
		public static string GetUploadMethod(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxFileUploader.GetOption", dxTarget, "uploadMethod");
		}
		public static void SetUploadMethod(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxFileUploader.SetOption", dxTarget, "uploadMethod", value);
		}
		public static string GetUploadMode(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxFileUploader.GetOption", dxTarget, "uploadMode");
		}
		public static void SetUploadMode(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxFileUploader.SetOption", dxTarget, "uploadMode", value);
		}
		public static string GetUploadUrl(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxFileUploader.GetOption", dxTarget, "uploadUrl");
		}
		public static void SetUploadUrl(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxFileUploader.SetOption", dxTarget, "uploadUrl", value);
		}
		public static new object GetValue(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxFileUploader.GetOption", dxTarget, "value");
		}
		public static new void SetValue(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxFileUploader.SetOption", dxTarget, "value", value);
		}
	}
	public class DxFilterBuilderInterop: WidgetInterop
	{
		public static event EventHandler<JQueryEventArgs> EditorPrepared;
		public static event EventHandler<JQueryEventArgs> EditorPreparing;
		public static event EventHandler<JQueryEventArgs> ValueChanged;
		public static void Init(ElementRef dxTarget, DevExpress.Ui.DxFilterBuilderOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxFilterBuilder.Init", dxTarget, json);
		}
		public static void OnEditorPrepared(string identifier)
		{
			EditorPrepared?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static void OnEditorPreparing(string identifier)
		{
			EditorPreparing?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static void OnValueChanged(string identifier)
		{
			ValueChanged?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static bool? GetAllowHierarchicalFields(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxFilterBuilder.GetOption", dxTarget, "allowHierarchicalFields");
		}
		public static void SetAllowHierarchicalFields(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxFilterBuilder.SetOption", dxTarget, "allowHierarchicalFields", value);
		}
		public static object GetCustomOperations(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxFilterBuilder.GetOption", dxTarget, "customOperations");
		}
		public static void SetCustomOperations(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxFilterBuilder.SetOption", dxTarget, "customOperations", value);
		}
		public static object GetFields(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxFilterBuilder.GetOption", dxTarget, "fields");
		}
		public static void SetFields(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxFilterBuilder.SetOption", dxTarget, "fields", value);
		}
		public static object GetFilterOperationDescriptions(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxFilterBuilder.GetOption", dxTarget, "filterOperationDescriptions");
		}
		public static void SetFilterOperationDescriptions(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxFilterBuilder.SetOption", dxTarget, "filterOperationDescriptions", value);
		}
		public static object GetGroupOperationDescriptions(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxFilterBuilder.GetOption", dxTarget, "groupOperationDescriptions");
		}
		public static void SetGroupOperationDescriptions(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxFilterBuilder.SetOption", dxTarget, "groupOperationDescriptions", value);
		}
		public static object GetValue(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxFilterBuilder.GetOption", dxTarget, "value");
		}
		public static void SetValue(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxFilterBuilder.SetOption", dxTarget, "value", value);
		}
		public static object GetFilterExpression(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxFilterBuilder.getFilterExpression_0", dxTarget);
		}
	}
	public class DxFormInterop: WidgetInterop
	{
		public static event EventHandler<JQueryEventArgs> EditorEnterKey;
		public static event EventHandler<JQueryEventArgs> FieldDataChanged;
		public static void Init(ElementRef dxTarget, DevExpress.Ui.DxFormOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxForm.Init", dxTarget, json);
		}
		public static void OnEditorEnterKey(string identifier)
		{
			EditorEnterKey?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static void OnFieldDataChanged(string identifier)
		{
			FieldDataChanged?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static bool? GetAlignItemLabels(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxForm.GetOption", dxTarget, "alignItemLabels");
		}
		public static void SetAlignItemLabels(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxForm.SetOption", dxTarget, "alignItemLabels", value);
		}
		public static bool? GetAlignItemLabelsInAllGroups(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxForm.GetOption", dxTarget, "alignItemLabelsInAllGroups");
		}
		public static void SetAlignItemLabelsInAllGroups(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxForm.SetOption", dxTarget, "alignItemLabelsInAllGroups", value);
		}
		public static object GetColCount(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxForm.GetOption", dxTarget, "colCount");
		}
		public static void SetColCount(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxForm.SetOption", dxTarget, "colCount", value);
		}
		public static object GetColCountByScreen(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxForm.GetOption", dxTarget, "colCountByScreen");
		}
		public static void SetColCountByScreen(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxForm.SetOption", dxTarget, "colCountByScreen", value);
		}
		public static object GetCustomizeItem(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxForm.GetOption", dxTarget, "customizeItem");
		}
		public static void SetCustomizeItem(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxForm.SetOption", dxTarget, "customizeItem", value);
		}
		public static object GetFormData(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxForm.GetOption", dxTarget, "formData");
		}
		public static void SetFormData(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxForm.SetOption", dxTarget, "formData", value);
		}
		public static object GetItems(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxForm.GetOption", dxTarget, "items");
		}
		public static void SetItems(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxForm.SetOption", dxTarget, "items", value);
		}
		public static string GetLabelLocation(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxForm.GetOption", dxTarget, "labelLocation");
		}
		public static void SetLabelLocation(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxForm.SetOption", dxTarget, "labelLocation", value);
		}
		public static float? GetMinColWidth(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<float?>("BlazorDevExtreme.DxForm.GetOption", dxTarget, "minColWidth");
		}
		public static void SetMinColWidth(ElementRef dxTarget, float? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxForm.SetOption", dxTarget, "minColWidth", value);
		}
		public static string GetOptionalMark(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxForm.GetOption", dxTarget, "optionalMark");
		}
		public static void SetOptionalMark(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxForm.SetOption", dxTarget, "optionalMark", value);
		}
		public static bool? GetReadOnly(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxForm.GetOption", dxTarget, "readOnly");
		}
		public static void SetReadOnly(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxForm.SetOption", dxTarget, "readOnly", value);
		}
		public static string GetRequiredMark(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxForm.GetOption", dxTarget, "requiredMark");
		}
		public static void SetRequiredMark(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxForm.SetOption", dxTarget, "requiredMark", value);
		}
		public static string GetRequiredMessage(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxForm.GetOption", dxTarget, "requiredMessage");
		}
		public static void SetRequiredMessage(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxForm.SetOption", dxTarget, "requiredMessage", value);
		}
		public static object GetScreenByWidth(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxForm.GetOption", dxTarget, "screenByWidth");
		}
		public static void SetScreenByWidth(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxForm.SetOption", dxTarget, "screenByWidth", value);
		}
		public static bool? GetScrollingEnabled(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxForm.GetOption", dxTarget, "scrollingEnabled");
		}
		public static void SetScrollingEnabled(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxForm.SetOption", dxTarget, "scrollingEnabled", value);
		}
		public static bool? GetShowColonAfterLabel(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxForm.GetOption", dxTarget, "showColonAfterLabel");
		}
		public static void SetShowColonAfterLabel(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxForm.SetOption", dxTarget, "showColonAfterLabel", value);
		}
		public static bool? GetShowOptionalMark(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxForm.GetOption", dxTarget, "showOptionalMark");
		}
		public static void SetShowOptionalMark(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxForm.SetOption", dxTarget, "showOptionalMark", value);
		}
		public static bool? GetShowRequiredMark(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxForm.GetOption", dxTarget, "showRequiredMark");
		}
		public static void SetShowRequiredMark(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxForm.SetOption", dxTarget, "showRequiredMark", value);
		}
		public static bool? GetShowValidationSummary(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxForm.GetOption", dxTarget, "showValidationSummary");
		}
		public static void SetShowValidationSummary(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxForm.SetOption", dxTarget, "showValidationSummary", value);
		}
		public static string GetValidationGroup(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxForm.GetOption", dxTarget, "validationGroup");
		}
		public static void SetValidationGroup(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxForm.SetOption", dxTarget, "validationGroup", value);
		}
		public static object GetEditor(ElementRef dxTarget, string dataField)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxForm.getEditor_0", dxTarget, dataField);
		}
		public static object ItemOption(ElementRef dxTarget, string id)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxForm.itemOption_1", dxTarget, id);
		}
		public static void ItemOption(ElementRef dxTarget, string id, string option, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxForm.itemOption_2", dxTarget, id, option, value);
		}
		public static void ItemOption(ElementRef dxTarget, string id, object options)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxForm.itemOption_3", dxTarget, id, options);
		}
		public static void ResetValues(ElementRef dxTarget)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxForm.resetValues_4", dxTarget);
		}
		public static void UpdateData(ElementRef dxTarget, object data)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxForm.updateData_5", dxTarget, data);
		}
		public static void UpdateData(ElementRef dxTarget, string dataField, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxForm.updateData_6", dxTarget, dataField, value);
		}
		public static object UpdateDimensions(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxForm.updateDimensions_7", dxTarget);
		}
		public static object Validate(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxForm.validate_8", dxTarget);
		}
	}
	public class DxGalleryInterop: CollectionWidgetInterop
	{
		public static void Init(ElementRef dxTarget, DevExpress.Ui.DxGalleryOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxGallery.Init", dxTarget, json);
		}
		public static float? GetAnimationDuration(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<float?>("BlazorDevExtreme.DxGallery.GetOption", dxTarget, "animationDuration");
		}
		public static void SetAnimationDuration(ElementRef dxTarget, float? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxGallery.SetOption", dxTarget, "animationDuration", value);
		}
		public static bool? GetAnimationEnabled(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxGallery.GetOption", dxTarget, "animationEnabled");
		}
		public static void SetAnimationEnabled(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxGallery.SetOption", dxTarget, "animationEnabled", value);
		}
		public static new bool? GetFocusStateEnabled(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxGallery.GetOption", dxTarget, "focusStateEnabled");
		}
		public static new void SetFocusStateEnabled(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxGallery.SetOption", dxTarget, "focusStateEnabled", value);
		}
		public static bool? GetIndicatorEnabled(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxGallery.GetOption", dxTarget, "indicatorEnabled");
		}
		public static void SetIndicatorEnabled(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxGallery.SetOption", dxTarget, "indicatorEnabled", value);
		}
		public static float? GetInitialItemWidth(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<float?>("BlazorDevExtreme.DxGallery.GetOption", dxTarget, "initialItemWidth");
		}
		public static void SetInitialItemWidth(ElementRef dxTarget, float? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxGallery.SetOption", dxTarget, "initialItemWidth", value);
		}
		public static bool? GetLoop(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxGallery.GetOption", dxTarget, "loop");
		}
		public static void SetLoop(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxGallery.SetOption", dxTarget, "loop", value);
		}
		public static new float? GetSelectedIndex(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<float?>("BlazorDevExtreme.DxGallery.GetOption", dxTarget, "selectedIndex");
		}
		public static new void SetSelectedIndex(ElementRef dxTarget, float? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxGallery.SetOption", dxTarget, "selectedIndex", value);
		}
		public static bool? GetShowIndicator(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxGallery.GetOption", dxTarget, "showIndicator");
		}
		public static void SetShowIndicator(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxGallery.SetOption", dxTarget, "showIndicator", value);
		}
		public static bool? GetShowNavButtons(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxGallery.GetOption", dxTarget, "showNavButtons");
		}
		public static void SetShowNavButtons(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxGallery.SetOption", dxTarget, "showNavButtons", value);
		}
		public static float? GetSlideshowDelay(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<float?>("BlazorDevExtreme.DxGallery.GetOption", dxTarget, "slideshowDelay");
		}
		public static void SetSlideshowDelay(ElementRef dxTarget, float? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxGallery.SetOption", dxTarget, "slideshowDelay", value);
		}
		public static bool? GetStretchImages(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxGallery.GetOption", dxTarget, "stretchImages");
		}
		public static void SetStretchImages(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxGallery.SetOption", dxTarget, "stretchImages", value);
		}
		public static bool? GetSwipeEnabled(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxGallery.GetOption", dxTarget, "swipeEnabled");
		}
		public static void SetSwipeEnabled(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxGallery.SetOption", dxTarget, "swipeEnabled", value);
		}
		public static bool? GetWrapAround(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxGallery.GetOption", dxTarget, "wrapAround");
		}
		public static void SetWrapAround(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxGallery.SetOption", dxTarget, "wrapAround", value);
		}
		public static object GoToItem(ElementRef dxTarget, float itemIndex, bool animation)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxGallery.goToItem_0", dxTarget, itemIndex, animation);
		}
		public static object NextItem(ElementRef dxTarget, bool animation)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxGallery.nextItem_1", dxTarget, animation);
		}
		public static object PrevItem(ElementRef dxTarget, bool animation)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxGallery.prevItem_2", dxTarget, animation);
		}
	}
	public class DxListInterop: CollectionWidgetInterop
	{
		public static event EventHandler<JQueryEventArgs> GroupRendered;
		public static event EventHandler<JQueryEventArgs> ItemClick;
		public static event EventHandler<JQueryEventArgs> ItemContextMenu;
		public static event EventHandler<JQueryEventArgs> ItemDeleted;
		public static event EventHandler<JQueryEventArgs> ItemDeleting;
		public static event EventHandler<JQueryEventArgs> ItemHold;
		public static event EventHandler<JQueryEventArgs> ItemReordered;
		public static event EventHandler<JQueryEventArgs> ItemSwipe;
		public static event EventHandler<JQueryEventArgs> PageLoading;
		public static event EventHandler<JQueryEventArgs> PullRefresh;
		public static event EventHandler<JQueryEventArgs> Scroll;
		public static event EventHandler<JQueryEventArgs> SelectAllValueChanged;
		public static void Init(ElementRef dxTarget, DevExpress.Ui.DxListOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxList.Init", dxTarget, json);
		}
		public static void OnGroupRendered(string identifier)
		{
			GroupRendered?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static void OnItemClick(string identifier)
		{
			ItemClick?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static void OnItemContextMenu(string identifier)
		{
			ItemContextMenu?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static void OnItemDeleted(string identifier)
		{
			ItemDeleted?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static void OnItemDeleting(string identifier)
		{
			ItemDeleting?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static void OnItemHold(string identifier)
		{
			ItemHold?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static void OnItemReordered(string identifier)
		{
			ItemReordered?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static void OnItemSwipe(string identifier)
		{
			ItemSwipe?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static void OnPageLoading(string identifier)
		{
			PageLoading?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static void OnPullRefresh(string identifier)
		{
			PullRefresh?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static void OnScroll(string identifier)
		{
			Scroll?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static void OnSelectAllValueChanged(string identifier)
		{
			SelectAllValueChanged?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static new bool? GetActiveStateEnabled(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxList.GetOption", dxTarget, "activeStateEnabled");
		}
		public static new void SetActiveStateEnabled(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxList.SetOption", dxTarget, "activeStateEnabled", value);
		}
		public static bool? GetAllowItemDeleting(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxList.GetOption", dxTarget, "allowItemDeleting");
		}
		public static void SetAllowItemDeleting(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxList.SetOption", dxTarget, "allowItemDeleting", value);
		}
		public static bool? GetAllowItemReordering(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxList.GetOption", dxTarget, "allowItemReordering");
		}
		public static void SetAllowItemReordering(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxList.SetOption", dxTarget, "allowItemReordering", value);
		}
		public static bool? GetBounceEnabled(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxList.GetOption", dxTarget, "bounceEnabled");
		}
		public static void SetBounceEnabled(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxList.SetOption", dxTarget, "bounceEnabled", value);
		}
		public static bool? GetCollapsibleGroups(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxList.GetOption", dxTarget, "collapsibleGroups");
		}
		public static void SetCollapsibleGroups(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxList.SetOption", dxTarget, "collapsibleGroups", value);
		}
		public static new bool? GetFocusStateEnabled(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxList.GetOption", dxTarget, "focusStateEnabled");
		}
		public static new void SetFocusStateEnabled(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxList.SetOption", dxTarget, "focusStateEnabled", value);
		}
		public static bool? GetGrouped(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxList.GetOption", dxTarget, "grouped");
		}
		public static void SetGrouped(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxList.SetOption", dxTarget, "grouped", value);
		}
		public static object GetGroupTemplate(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxList.GetOption", dxTarget, "groupTemplate");
		}
		public static void SetGroupTemplate(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxList.SetOption", dxTarget, "groupTemplate", value);
		}
		public static new bool? GetHoverStateEnabled(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxList.GetOption", dxTarget, "hoverStateEnabled");
		}
		public static new void SetHoverStateEnabled(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxList.SetOption", dxTarget, "hoverStateEnabled", value);
		}
		public static bool? GetIndicateLoading(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxList.GetOption", dxTarget, "indicateLoading");
		}
		public static void SetIndicateLoading(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxList.SetOption", dxTarget, "indicateLoading", value);
		}
		public static string GetItemDeleteMode(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxList.GetOption", dxTarget, "itemDeleteMode");
		}
		public static void SetItemDeleteMode(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxList.SetOption", dxTarget, "itemDeleteMode", value);
		}
		public static object GetMenuItems(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxList.GetOption", dxTarget, "menuItems");
		}
		public static void SetMenuItems(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxList.SetOption", dxTarget, "menuItems", value);
		}
		public static string GetMenuMode(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxList.GetOption", dxTarget, "menuMode");
		}
		public static void SetMenuMode(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxList.SetOption", dxTarget, "menuMode", value);
		}
		public static string GetNextButtonText(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxList.GetOption", dxTarget, "nextButtonText");
		}
		public static void SetNextButtonText(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxList.SetOption", dxTarget, "nextButtonText", value);
		}
		public static string GetPageLoadingText(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxList.GetOption", dxTarget, "pageLoadingText");
		}
		public static void SetPageLoadingText(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxList.SetOption", dxTarget, "pageLoadingText", value);
		}
		public static string GetPageLoadMode(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxList.GetOption", dxTarget, "pageLoadMode");
		}
		public static void SetPageLoadMode(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxList.SetOption", dxTarget, "pageLoadMode", value);
		}
		public static string GetPulledDownText(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxList.GetOption", dxTarget, "pulledDownText");
		}
		public static void SetPulledDownText(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxList.SetOption", dxTarget, "pulledDownText", value);
		}
		public static string GetPullingDownText(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxList.GetOption", dxTarget, "pullingDownText");
		}
		public static void SetPullingDownText(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxList.SetOption", dxTarget, "pullingDownText", value);
		}
		public static bool? GetPullRefreshEnabled(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxList.GetOption", dxTarget, "pullRefreshEnabled");
		}
		public static void SetPullRefreshEnabled(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxList.SetOption", dxTarget, "pullRefreshEnabled", value);
		}
		public static string GetRefreshingText(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxList.GetOption", dxTarget, "refreshingText");
		}
		public static void SetRefreshingText(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxList.SetOption", dxTarget, "refreshingText", value);
		}
		public static bool? GetScrollByContent(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxList.GetOption", dxTarget, "scrollByContent");
		}
		public static void SetScrollByContent(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxList.SetOption", dxTarget, "scrollByContent", value);
		}
		public static bool? GetScrollByThumb(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxList.GetOption", dxTarget, "scrollByThumb");
		}
		public static void SetScrollByThumb(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxList.SetOption", dxTarget, "scrollByThumb", value);
		}
		public static bool? GetScrollingEnabled(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxList.GetOption", dxTarget, "scrollingEnabled");
		}
		public static void SetScrollingEnabled(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxList.SetOption", dxTarget, "scrollingEnabled", value);
		}
		public static string GetSelectAllMode(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxList.GetOption", dxTarget, "selectAllMode");
		}
		public static void SetSelectAllMode(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxList.SetOption", dxTarget, "selectAllMode", value);
		}
		public static string GetSelectionMode(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxList.GetOption", dxTarget, "selectionMode");
		}
		public static void SetSelectionMode(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxList.SetOption", dxTarget, "selectionMode", value);
		}
		public static string GetShowScrollbar(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxList.GetOption", dxTarget, "showScrollbar");
		}
		public static void SetShowScrollbar(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxList.SetOption", dxTarget, "showScrollbar", value);
		}
		public static bool? GetShowSelectionControls(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxList.GetOption", dxTarget, "showSelectionControls");
		}
		public static void SetShowSelectionControls(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxList.SetOption", dxTarget, "showSelectionControls", value);
		}
		public static bool? GetUseNativeScrolling(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxList.GetOption", dxTarget, "useNativeScrolling");
		}
		public static void SetUseNativeScrolling(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxList.SetOption", dxTarget, "useNativeScrolling", value);
		}
		public static float ClientHeight(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<float>("BlazorDevExtreme.DxList.clientHeight_0", dxTarget);
		}
		public static object CollapseGroup(ElementRef dxTarget, float groupIndex)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxList.collapseGroup_1", dxTarget, groupIndex);
		}
		public static object DeleteItem(ElementRef dxTarget, object itemElement)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxList.deleteItem_2", dxTarget, itemElement);
		}
		public static object ExpandGroup(ElementRef dxTarget, float groupIndex)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxList.expandGroup_4", dxTarget, groupIndex);
		}
		public static bool IsItemSelected(ElementRef dxTarget, object itemElement)
		{
			return RegisteredFunction.Invoke<bool>("BlazorDevExtreme.DxList.isItemSelected_5", dxTarget, itemElement);
		}
		public static void Reload(ElementRef dxTarget)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxList.reload_7", dxTarget);
		}
		public static object ReorderItem(ElementRef dxTarget, object itemElement, object toItemElement)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxList.reorderItem_8", dxTarget, itemElement, toItemElement);
		}
		public static void ScrollBy(ElementRef dxTarget, float distance)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxList.scrollBy_10", dxTarget, distance);
		}
		public static float ScrollHeight(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<float>("BlazorDevExtreme.DxList.scrollHeight_11", dxTarget);
		}
		public static void ScrollTo(ElementRef dxTarget, float location)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxList.scrollTo_12", dxTarget, location);
		}
		public static void ScrollToItem(ElementRef dxTarget, object itemElement)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxList.scrollToItem_13", dxTarget, itemElement);
		}
		public static float ScrollTop(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<float>("BlazorDevExtreme.DxList.scrollTop_15", dxTarget);
		}
		public static void SelectAll(ElementRef dxTarget)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxList.selectAll_16", dxTarget);
		}
		public static void SelectItem(ElementRef dxTarget, object itemElement)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxList.selectItem_17", dxTarget, itemElement);
		}
		public static void UnselectAll(ElementRef dxTarget)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxList.unselectAll_19", dxTarget);
		}
		public static void UnselectItem(ElementRef dxTarget, object itemElement)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxList.unselectItem_20", dxTarget, itemElement);
		}
		public static object UpdateDimensions(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxList.updateDimensions_22", dxTarget);
		}
	}
	public class DxLoadIndicatorInterop: WidgetInterop
	{
		public static void Init(ElementRef dxTarget, DevExpress.Ui.DxLoadIndicatorOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxLoadIndicator.Init", dxTarget, json);
		}
		public static string GetIndicatorSrc(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxLoadIndicator.GetOption", dxTarget, "indicatorSrc");
		}
		public static void SetIndicatorSrc(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxLoadIndicator.SetOption", dxTarget, "indicatorSrc", value);
		}
	}
	public class DxLoadPanelInterop: DxOverlayInterop
	{
		public static void Init(ElementRef dxTarget, DevExpress.Ui.DxLoadPanelOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxLoadPanel.Init", dxTarget, json);
		}
		public static new object GetAnimation(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxLoadPanel.GetOption", dxTarget, "animation");
		}
		public static new void SetAnimation(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxLoadPanel.SetOption", dxTarget, "animation", value);
		}
		public static float? GetDelay(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<float?>("BlazorDevExtreme.DxLoadPanel.GetOption", dxTarget, "delay");
		}
		public static void SetDelay(ElementRef dxTarget, float? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxLoadPanel.SetOption", dxTarget, "delay", value);
		}
		public static new bool? GetFocusStateEnabled(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxLoadPanel.GetOption", dxTarget, "focusStateEnabled");
		}
		public static new void SetFocusStateEnabled(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxLoadPanel.SetOption", dxTarget, "focusStateEnabled", value);
		}
		public static new float? GetHeight(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<float?>("BlazorDevExtreme.DxLoadPanel.GetOption", dxTarget, "height");
		}
		public static new void SetHeight(ElementRef dxTarget, float? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxLoadPanel.SetOption", dxTarget, "height", value);
		}
		public static string GetIndicatorSrc(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxLoadPanel.GetOption", dxTarget, "indicatorSrc");
		}
		public static void SetIndicatorSrc(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxLoadPanel.SetOption", dxTarget, "indicatorSrc", value);
		}
		public static string GetMessage(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxLoadPanel.GetOption", dxTarget, "message");
		}
		public static void SetMessage(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxLoadPanel.SetOption", dxTarget, "message", value);
		}
		public static new object GetPosition(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxLoadPanel.GetOption", dxTarget, "position");
		}
		public static new void SetPosition(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxLoadPanel.SetOption", dxTarget, "position", value);
		}
		public static new string GetShadingColor(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxLoadPanel.GetOption", dxTarget, "shadingColor");
		}
		public static new void SetShadingColor(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxLoadPanel.SetOption", dxTarget, "shadingColor", value);
		}
		public static bool? GetShowIndicator(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxLoadPanel.GetOption", dxTarget, "showIndicator");
		}
		public static void SetShowIndicator(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxLoadPanel.SetOption", dxTarget, "showIndicator", value);
		}
		public static bool? GetShowPane(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxLoadPanel.GetOption", dxTarget, "showPane");
		}
		public static void SetShowPane(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxLoadPanel.SetOption", dxTarget, "showPane", value);
		}
		public static new float? GetWidth(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<float?>("BlazorDevExtreme.DxLoadPanel.GetOption", dxTarget, "width");
		}
		public static new void SetWidth(ElementRef dxTarget, float? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxLoadPanel.SetOption", dxTarget, "width", value);
		}
	}
	public class DxLookupInterop: DxDropDownListInterop
	{
		public static event EventHandler<JQueryEventArgs> PageLoading;
		public static event EventHandler<JQueryEventArgs> PullRefresh;
		public static event EventHandler<JQueryEventArgs> Scroll;
		public static event EventHandler<JQueryEventArgs> TitleRendered;
		public static event EventHandler<JQueryEventArgs> ValueChanged;
		public static void Init(ElementRef dxTarget, DevExpress.Ui.DxLookupOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxLookup.Init", dxTarget, json);
		}
		public static void OnPageLoading(string identifier)
		{
			PageLoading?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static void OnPullRefresh(string identifier)
		{
			PullRefresh?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static void OnScroll(string identifier)
		{
			Scroll?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static void OnTitleRendered(string identifier)
		{
			TitleRendered?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static void OnValueChanged(string identifier)
		{
			ValueChanged?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static object GetAnimation(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxLookup.GetOption", dxTarget, "animation");
		}
		public static void SetAnimation(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxLookup.SetOption", dxTarget, "animation", value);
		}
		public static string GetApplyButtonText(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxLookup.GetOption", dxTarget, "applyButtonText");
		}
		public static void SetApplyButtonText(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxLookup.SetOption", dxTarget, "applyButtonText", value);
		}
		public static new string GetApplyValueMode(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxLookup.GetOption", dxTarget, "applyValueMode");
		}
		public static new void SetApplyValueMode(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxLookup.SetOption", dxTarget, "applyValueMode", value);
		}
		public static string GetCancelButtonText(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxLookup.GetOption", dxTarget, "cancelButtonText");
		}
		public static void SetCancelButtonText(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxLookup.SetOption", dxTarget, "cancelButtonText", value);
		}
		public static bool? GetCleanSearchOnOpening(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxLookup.GetOption", dxTarget, "cleanSearchOnOpening");
		}
		public static void SetCleanSearchOnOpening(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxLookup.SetOption", dxTarget, "cleanSearchOnOpening", value);
		}
		public static string GetClearButtonText(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxLookup.GetOption", dxTarget, "clearButtonText");
		}
		public static void SetClearButtonText(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxLookup.SetOption", dxTarget, "clearButtonText", value);
		}
		public static object GetCloseOnOutsideClick(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxLookup.GetOption", dxTarget, "closeOnOutsideClick");
		}
		public static void SetCloseOnOutsideClick(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxLookup.SetOption", dxTarget, "closeOnOutsideClick", value);
		}
		public static object GetFieldTemplate(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxLookup.GetOption", dxTarget, "fieldTemplate");
		}
		public static void SetFieldTemplate(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxLookup.SetOption", dxTarget, "fieldTemplate", value);
		}
		public static new bool? GetFocusStateEnabled(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxLookup.GetOption", dxTarget, "focusStateEnabled");
		}
		public static new void SetFocusStateEnabled(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxLookup.SetOption", dxTarget, "focusStateEnabled", value);
		}
		public static bool? GetFullScreen(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxLookup.GetOption", dxTarget, "fullScreen");
		}
		public static void SetFullScreen(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxLookup.SetOption", dxTarget, "fullScreen", value);
		}
		public static new bool? GetGrouped(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxLookup.GetOption", dxTarget, "grouped");
		}
		public static new void SetGrouped(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxLookup.SetOption", dxTarget, "grouped", value);
		}
		public static new object GetGroupTemplate(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxLookup.GetOption", dxTarget, "groupTemplate");
		}
		public static new void SetGroupTemplate(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxLookup.SetOption", dxTarget, "groupTemplate", value);
		}
		public static string GetNextButtonText(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxLookup.GetOption", dxTarget, "nextButtonText");
		}
		public static void SetNextButtonText(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxLookup.SetOption", dxTarget, "nextButtonText", value);
		}
		public static string GetPageLoadingText(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxLookup.GetOption", dxTarget, "pageLoadingText");
		}
		public static void SetPageLoadingText(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxLookup.SetOption", dxTarget, "pageLoadingText", value);
		}
		public static string GetPageLoadMode(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxLookup.GetOption", dxTarget, "pageLoadMode");
		}
		public static void SetPageLoadMode(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxLookup.SetOption", dxTarget, "pageLoadMode", value);
		}
		public static new string GetPlaceholder(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxLookup.GetOption", dxTarget, "placeholder");
		}
		public static new void SetPlaceholder(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxLookup.SetOption", dxTarget, "placeholder", value);
		}
		public static object GetPopupHeight(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxLookup.GetOption", dxTarget, "popupHeight");
		}
		public static void SetPopupHeight(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxLookup.SetOption", dxTarget, "popupHeight", value);
		}
		public static object GetPopupWidth(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxLookup.GetOption", dxTarget, "popupWidth");
		}
		public static void SetPopupWidth(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxLookup.SetOption", dxTarget, "popupWidth", value);
		}
		public static object GetPosition(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxLookup.GetOption", dxTarget, "position");
		}
		public static void SetPosition(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxLookup.SetOption", dxTarget, "position", value);
		}
		public static string GetPulledDownText(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxLookup.GetOption", dxTarget, "pulledDownText");
		}
		public static void SetPulledDownText(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxLookup.SetOption", dxTarget, "pulledDownText", value);
		}
		public static string GetPullingDownText(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxLookup.GetOption", dxTarget, "pullingDownText");
		}
		public static void SetPullingDownText(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxLookup.SetOption", dxTarget, "pullingDownText", value);
		}
		public static bool? GetPullRefreshEnabled(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxLookup.GetOption", dxTarget, "pullRefreshEnabled");
		}
		public static void SetPullRefreshEnabled(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxLookup.SetOption", dxTarget, "pullRefreshEnabled", value);
		}
		public static string GetRefreshingText(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxLookup.GetOption", dxTarget, "refreshingText");
		}
		public static void SetRefreshingText(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxLookup.SetOption", dxTarget, "refreshingText", value);
		}
		public static new bool? GetSearchEnabled(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxLookup.GetOption", dxTarget, "searchEnabled");
		}
		public static new void SetSearchEnabled(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxLookup.SetOption", dxTarget, "searchEnabled", value);
		}
		public static string GetSearchPlaceholder(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxLookup.GetOption", dxTarget, "searchPlaceholder");
		}
		public static void SetSearchPlaceholder(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxLookup.SetOption", dxTarget, "searchPlaceholder", value);
		}
		public static bool? GetShading(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxLookup.GetOption", dxTarget, "shading");
		}
		public static void SetShading(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxLookup.SetOption", dxTarget, "shading", value);
		}
		public static bool? GetShowCancelButton(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxLookup.GetOption", dxTarget, "showCancelButton");
		}
		public static void SetShowCancelButton(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxLookup.SetOption", dxTarget, "showCancelButton", value);
		}
		public static new bool? GetShowClearButton(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxLookup.GetOption", dxTarget, "showClearButton");
		}
		public static new void SetShowClearButton(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxLookup.SetOption", dxTarget, "showClearButton", value);
		}
		public static bool? GetShowPopupTitle(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxLookup.GetOption", dxTarget, "showPopupTitle");
		}
		public static void SetShowPopupTitle(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxLookup.SetOption", dxTarget, "showPopupTitle", value);
		}
		public static string GetTitle(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxLookup.GetOption", dxTarget, "title");
		}
		public static void SetTitle(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxLookup.SetOption", dxTarget, "title", value);
		}
		public static object GetTitleTemplate(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxLookup.GetOption", dxTarget, "titleTemplate");
		}
		public static void SetTitleTemplate(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxLookup.SetOption", dxTarget, "titleTemplate", value);
		}
		public static bool? GetUseNativeScrolling(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxLookup.GetOption", dxTarget, "useNativeScrolling");
		}
		public static void SetUseNativeScrolling(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxLookup.SetOption", dxTarget, "useNativeScrolling", value);
		}
		public static bool? GetUsePopover(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxLookup.GetOption", dxTarget, "usePopover");
		}
		public static void SetUsePopover(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxLookup.SetOption", dxTarget, "usePopover", value);
		}
	}
	public class DxMapInterop: WidgetInterop
	{
		public static event EventHandler<JQueryEventArgs> Click;
		public static event EventHandler<JQueryEventArgs> MarkerAdded;
		public static event EventHandler<JQueryEventArgs> MarkerRemoved;
		public static event EventHandler<JQueryEventArgs> Ready;
		public static event EventHandler<JQueryEventArgs> RouteAdded;
		public static event EventHandler<JQueryEventArgs> RouteRemoved;
		public static void Init(ElementRef dxTarget, DevExpress.Ui.DxMapOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxMap.Init", dxTarget, json);
		}
		public static void OnClick(string identifier)
		{
			Click?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static void OnMarkerAdded(string identifier)
		{
			MarkerAdded?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static void OnMarkerRemoved(string identifier)
		{
			MarkerRemoved?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static void OnReady(string identifier)
		{
			Ready?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static void OnRouteAdded(string identifier)
		{
			RouteAdded?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static void OnRouteRemoved(string identifier)
		{
			RouteRemoved?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static bool? GetAutoAdjust(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxMap.GetOption", dxTarget, "autoAdjust");
		}
		public static void SetAutoAdjust(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxMap.SetOption", dxTarget, "autoAdjust", value);
		}
		public static object GetCenter(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxMap.GetOption", dxTarget, "center");
		}
		public static void SetCenter(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxMap.SetOption", dxTarget, "center", value);
		}
		public static bool? GetControls(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxMap.GetOption", dxTarget, "controls");
		}
		public static void SetControls(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxMap.SetOption", dxTarget, "controls", value);
		}
		public static new bool? GetFocusStateEnabled(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxMap.GetOption", dxTarget, "focusStateEnabled");
		}
		public static new void SetFocusStateEnabled(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxMap.SetOption", dxTarget, "focusStateEnabled", value);
		}
		public static new object GetHeight(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxMap.GetOption", dxTarget, "height");
		}
		public static new void SetHeight(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxMap.SetOption", dxTarget, "height", value);
		}
		public static object GetKey(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxMap.GetOption", dxTarget, "key");
		}
		public static void SetKey(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxMap.SetOption", dxTarget, "key", value);
		}
		public static string GetMarkerIconSrc(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxMap.GetOption", dxTarget, "markerIconSrc");
		}
		public static void SetMarkerIconSrc(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxMap.SetOption", dxTarget, "markerIconSrc", value);
		}
		public static object GetMarkers(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxMap.GetOption", dxTarget, "markers");
		}
		public static void SetMarkers(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxMap.SetOption", dxTarget, "markers", value);
		}
		public static string GetProvider(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxMap.GetOption", dxTarget, "provider");
		}
		public static void SetProvider(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxMap.SetOption", dxTarget, "provider", value);
		}
		public static object GetRoutes(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxMap.GetOption", dxTarget, "routes");
		}
		public static void SetRoutes(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxMap.SetOption", dxTarget, "routes", value);
		}
		public static string GetType(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxMap.GetOption", dxTarget, "type");
		}
		public static void SetType(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxMap.SetOption", dxTarget, "type", value);
		}
		public static new object GetWidth(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxMap.GetOption", dxTarget, "width");
		}
		public static new void SetWidth(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxMap.SetOption", dxTarget, "width", value);
		}
		public static float? GetZoom(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<float?>("BlazorDevExtreme.DxMap.GetOption", dxTarget, "zoom");
		}
		public static void SetZoom(ElementRef dxTarget, float? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxMap.SetOption", dxTarget, "zoom", value);
		}
		public static object AddMarker(ElementRef dxTarget, object markerOptions)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxMap.addMarker_0", dxTarget, markerOptions);
		}
		public static object AddRoute(ElementRef dxTarget, object options)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxMap.addRoute_1", dxTarget, options);
		}
		public static object RemoveMarker(ElementRef dxTarget, object marker)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxMap.removeMarker_2", dxTarget, marker);
		}
		public static object RemoveRoute(ElementRef dxTarget, object route)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxMap.removeRoute_3", dxTarget, route);
		}
	}
	public class DxMenuInterop: DxMenuBaseInterop
	{
		public static event EventHandler<JQueryEventArgs> SubmenuHidden;
		public static event EventHandler<JQueryEventArgs> SubmenuHiding;
		public static event EventHandler<JQueryEventArgs> SubmenuShowing;
		public static event EventHandler<JQueryEventArgs> SubmenuShown;
		public static void Init(ElementRef dxTarget, DevExpress.Ui.DxMenuOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxMenu.Init", dxTarget, json);
		}
		public static void OnSubmenuHidden(string identifier)
		{
			SubmenuHidden?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static void OnSubmenuHiding(string identifier)
		{
			SubmenuHiding?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static void OnSubmenuShowing(string identifier)
		{
			SubmenuShowing?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static void OnSubmenuShown(string identifier)
		{
			SubmenuShown?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static bool? GetAdaptivityEnabled(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxMenu.GetOption", dxTarget, "adaptivityEnabled");
		}
		public static void SetAdaptivityEnabled(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxMenu.SetOption", dxTarget, "adaptivityEnabled", value);
		}
		public static bool? GetHideSubmenuOnMouseLeave(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxMenu.GetOption", dxTarget, "hideSubmenuOnMouseLeave");
		}
		public static void SetHideSubmenuOnMouseLeave(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxMenu.SetOption", dxTarget, "hideSubmenuOnMouseLeave", value);
		}
		public static new object GetItems(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxMenu.GetOption", dxTarget, "items");
		}
		public static new void SetItems(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxMenu.SetOption", dxTarget, "items", value);
		}
		public static string GetOrientation(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxMenu.GetOption", dxTarget, "orientation");
		}
		public static void SetOrientation(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxMenu.SetOption", dxTarget, "orientation", value);
		}
		public static object GetShowFirstSubmenuMode(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxMenu.GetOption", dxTarget, "showFirstSubmenuMode");
		}
		public static void SetShowFirstSubmenuMode(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxMenu.SetOption", dxTarget, "showFirstSubmenuMode", value);
		}
		public static string GetSubmenuDirection(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxMenu.GetOption", dxTarget, "submenuDirection");
		}
		public static void SetSubmenuDirection(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxMenu.SetOption", dxTarget, "submenuDirection", value);
		}
	}
	public class DxMultiViewInterop: CollectionWidgetInterop
	{
		public static void Init(ElementRef dxTarget, DevExpress.Ui.DxMultiViewOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxMultiView.Init", dxTarget, json);
		}
		public static bool? GetAnimationEnabled(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxMultiView.GetOption", dxTarget, "animationEnabled");
		}
		public static void SetAnimationEnabled(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxMultiView.SetOption", dxTarget, "animationEnabled", value);
		}
		public static bool? GetDeferRendering(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxMultiView.GetOption", dxTarget, "deferRendering");
		}
		public static void SetDeferRendering(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxMultiView.SetOption", dxTarget, "deferRendering", value);
		}
		public static new bool? GetFocusStateEnabled(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxMultiView.GetOption", dxTarget, "focusStateEnabled");
		}
		public static new void SetFocusStateEnabled(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxMultiView.SetOption", dxTarget, "focusStateEnabled", value);
		}
		public static bool? GetLoop(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxMultiView.GetOption", dxTarget, "loop");
		}
		public static void SetLoop(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxMultiView.SetOption", dxTarget, "loop", value);
		}
		public static new float? GetSelectedIndex(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<float?>("BlazorDevExtreme.DxMultiView.GetOption", dxTarget, "selectedIndex");
		}
		public static new void SetSelectedIndex(ElementRef dxTarget, float? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxMultiView.SetOption", dxTarget, "selectedIndex", value);
		}
		public static bool? GetSwipeEnabled(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxMultiView.GetOption", dxTarget, "swipeEnabled");
		}
		public static void SetSwipeEnabled(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxMultiView.SetOption", dxTarget, "swipeEnabled", value);
		}
	}
	public class DxNavBarInterop: DxTabsInterop
	{
		public static void Init(ElementRef dxTarget, DevExpress.Ui.DxNavBarOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxNavBar.Init", dxTarget, json);
		}
		public static new bool? GetScrollByContent(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxNavBar.GetOption", dxTarget, "scrollByContent");
		}
		public static new void SetScrollByContent(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxNavBar.SetOption", dxTarget, "scrollByContent", value);
		}
	}
	public class DxNumberBoxInterop: DxTextEditorInterop
	{
		public static void Init(ElementRef dxTarget, DevExpress.Ui.DxNumberBoxOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxNumberBox.Init", dxTarget, json);
		}
		public static object GetFormat(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxNumberBox.GetOption", dxTarget, "format");
		}
		public static void SetFormat(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxNumberBox.SetOption", dxTarget, "format", value);
		}
		public static string GetInvalidValueMessage(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxNumberBox.GetOption", dxTarget, "invalidValueMessage");
		}
		public static void SetInvalidValueMessage(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxNumberBox.SetOption", dxTarget, "invalidValueMessage", value);
		}
		public static float? GetMax(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<float?>("BlazorDevExtreme.DxNumberBox.GetOption", dxTarget, "max");
		}
		public static void SetMax(ElementRef dxTarget, float? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxNumberBox.SetOption", dxTarget, "max", value);
		}
		public static float? GetMin(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<float?>("BlazorDevExtreme.DxNumberBox.GetOption", dxTarget, "min");
		}
		public static void SetMin(ElementRef dxTarget, float? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxNumberBox.SetOption", dxTarget, "min", value);
		}
		public static string GetMode(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxNumberBox.GetOption", dxTarget, "mode");
		}
		public static void SetMode(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxNumberBox.SetOption", dxTarget, "mode", value);
		}
		public static bool? GetShowSpinButtons(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxNumberBox.GetOption", dxTarget, "showSpinButtons");
		}
		public static void SetShowSpinButtons(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxNumberBox.SetOption", dxTarget, "showSpinButtons", value);
		}
		public static float? GetStep(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<float?>("BlazorDevExtreme.DxNumberBox.GetOption", dxTarget, "step");
		}
		public static void SetStep(ElementRef dxTarget, float? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxNumberBox.SetOption", dxTarget, "step", value);
		}
		public static bool? GetUseLargeSpinButtons(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxNumberBox.GetOption", dxTarget, "useLargeSpinButtons");
		}
		public static void SetUseLargeSpinButtons(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxNumberBox.SetOption", dxTarget, "useLargeSpinButtons", value);
		}
		public static new float? GetValue(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<float?>("BlazorDevExtreme.DxNumberBox.GetOption", dxTarget, "value");
		}
		public static new void SetValue(ElementRef dxTarget, float? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxNumberBox.SetOption", dxTarget, "value", value);
		}
	}
	public class DxOverlayInterop: WidgetInterop
	{
		public static event EventHandler<JQueryEventArgs> Hidden;
		public static event EventHandler<JQueryEventArgs> Hiding;
		public static event EventHandler<JQueryEventArgs> Showing;
		public static event EventHandler<JQueryEventArgs> Shown;
		public static void Init(ElementRef dxTarget, DevExpress.Ui.DxOverlayOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxOverlay.Init", dxTarget, json);
		}
		public static void OnHidden(string identifier)
		{
			Hidden?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static void OnHiding(string identifier)
		{
			Hiding?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static void OnShowing(string identifier)
		{
			Showing?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static void OnShown(string identifier)
		{
			Shown?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static object GetAnimation(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxOverlay.GetOption", dxTarget, "animation");
		}
		public static void SetAnimation(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxOverlay.SetOption", dxTarget, "animation", value);
		}
		public static bool? GetCloseOnBackButton(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxOverlay.GetOption", dxTarget, "closeOnBackButton");
		}
		public static void SetCloseOnBackButton(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxOverlay.SetOption", dxTarget, "closeOnBackButton", value);
		}
		public static object GetCloseOnOutsideClick(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxOverlay.GetOption", dxTarget, "closeOnOutsideClick");
		}
		public static void SetCloseOnOutsideClick(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxOverlay.SetOption", dxTarget, "closeOnOutsideClick", value);
		}
		public static object GetContentTemplate(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxOverlay.GetOption", dxTarget, "contentTemplate");
		}
		public static void SetContentTemplate(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxOverlay.SetOption", dxTarget, "contentTemplate", value);
		}
		public static bool? GetDeferRendering(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxOverlay.GetOption", dxTarget, "deferRendering");
		}
		public static void SetDeferRendering(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxOverlay.SetOption", dxTarget, "deferRendering", value);
		}
		public static bool? GetDragEnabled(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxOverlay.GetOption", dxTarget, "dragEnabled");
		}
		public static void SetDragEnabled(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxOverlay.SetOption", dxTarget, "dragEnabled", value);
		}
		public static new object GetHeight(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxOverlay.GetOption", dxTarget, "height");
		}
		public static new void SetHeight(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxOverlay.SetOption", dxTarget, "height", value);
		}
		public static object GetMaxHeight(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxOverlay.GetOption", dxTarget, "maxHeight");
		}
		public static void SetMaxHeight(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxOverlay.SetOption", dxTarget, "maxHeight", value);
		}
		public static object GetMaxWidth(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxOverlay.GetOption", dxTarget, "maxWidth");
		}
		public static void SetMaxWidth(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxOverlay.SetOption", dxTarget, "maxWidth", value);
		}
		public static object GetMinHeight(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxOverlay.GetOption", dxTarget, "minHeight");
		}
		public static void SetMinHeight(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxOverlay.SetOption", dxTarget, "minHeight", value);
		}
		public static object GetMinWidth(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxOverlay.GetOption", dxTarget, "minWidth");
		}
		public static void SetMinWidth(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxOverlay.SetOption", dxTarget, "minWidth", value);
		}
		public static object GetPosition(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxOverlay.GetOption", dxTarget, "position");
		}
		public static void SetPosition(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxOverlay.SetOption", dxTarget, "position", value);
		}
		public static bool? GetShading(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxOverlay.GetOption", dxTarget, "shading");
		}
		public static void SetShading(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxOverlay.SetOption", dxTarget, "shading", value);
		}
		public static string GetShadingColor(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxOverlay.GetOption", dxTarget, "shadingColor");
		}
		public static void SetShadingColor(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxOverlay.SetOption", dxTarget, "shadingColor", value);
		}
		public static new bool? GetVisible(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxOverlay.GetOption", dxTarget, "visible");
		}
		public static new void SetVisible(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxOverlay.SetOption", dxTarget, "visible", value);
		}
		public static new object GetWidth(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxOverlay.GetOption", dxTarget, "width");
		}
		public static new void SetWidth(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxOverlay.SetOption", dxTarget, "width", value);
		}
		public static object Content(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxOverlay.content_0", dxTarget);
		}
		public static object Hide(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxOverlay.hide_1", dxTarget);
		}
		public static void Repaint(ElementRef dxTarget)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxOverlay.repaint_2", dxTarget);
		}
		public static object Show(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxOverlay.show_3", dxTarget);
		}
		public static object Toggle(ElementRef dxTarget, bool showing)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxOverlay.toggle_4", dxTarget, showing);
		}
	}
	public class DxPanoramaInterop: CollectionWidgetInterop
	{
		public static void Init(ElementRef dxTarget, DevExpress.Ui.DxPanoramaOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPanorama.Init", dxTarget, json);
		}
		public static object GetBackgroundImage(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPanorama.GetOption", dxTarget, "backgroundImage");
		}
		public static void SetBackgroundImage(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPanorama.SetOption", dxTarget, "backgroundImage", value);
		}
		public static new bool? GetFocusStateEnabled(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxPanorama.GetOption", dxTarget, "focusStateEnabled");
		}
		public static new void SetFocusStateEnabled(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPanorama.SetOption", dxTarget, "focusStateEnabled", value);
		}
		public static new float? GetSelectedIndex(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<float?>("BlazorDevExtreme.DxPanorama.GetOption", dxTarget, "selectedIndex");
		}
		public static new void SetSelectedIndex(ElementRef dxTarget, float? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPanorama.SetOption", dxTarget, "selectedIndex", value);
		}
		public static string GetTitle(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxPanorama.GetOption", dxTarget, "title");
		}
		public static void SetTitle(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPanorama.SetOption", dxTarget, "title", value);
		}
	}
	public class DxPivotInterop: CollectionWidgetInterop
	{
		public static void Init(ElementRef dxTarget, DevExpress.Ui.DxPivotOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPivot.Init", dxTarget, json);
		}
		public static object GetContentTemplate(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPivot.GetOption", dxTarget, "contentTemplate");
		}
		public static void SetContentTemplate(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPivot.SetOption", dxTarget, "contentTemplate", value);
		}
		public static object GetItemTitleTemplate(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPivot.GetOption", dxTarget, "itemTitleTemplate");
		}
		public static void SetItemTitleTemplate(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPivot.SetOption", dxTarget, "itemTitleTemplate", value);
		}
		public static new float? GetSelectedIndex(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<float?>("BlazorDevExtreme.DxPivot.GetOption", dxTarget, "selectedIndex");
		}
		public static new void SetSelectedIndex(ElementRef dxTarget, float? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPivot.SetOption", dxTarget, "selectedIndex", value);
		}
		public static bool? GetSwipeEnabled(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxPivot.GetOption", dxTarget, "swipeEnabled");
		}
		public static void SetSwipeEnabled(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPivot.SetOption", dxTarget, "swipeEnabled", value);
		}
	}
	public class DxPivotGridInterop: WidgetInterop
	{
		public static event EventHandler<JQueryEventArgs> CellClick;
		public static event EventHandler<JQueryEventArgs> CellPrepared;
		public static event EventHandler<JQueryEventArgs> ContextMenuPreparing;
		public static event EventHandler<JQueryEventArgs> Exported;
		public static event EventHandler<JQueryEventArgs> Exporting;
		public static event EventHandler<JQueryEventArgs> FileSaving;
		public static void Init(ElementRef dxTarget, DevExpress.Ui.DxPivotGridOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPivotGrid.Init", dxTarget, json);
		}
		public static void OnCellClick(string identifier)
		{
			CellClick?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static void OnCellPrepared(string identifier)
		{
			CellPrepared?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static void OnContextMenuPreparing(string identifier)
		{
			ContextMenuPreparing?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static void OnExported(string identifier)
		{
			Exported?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static void OnExporting(string identifier)
		{
			Exporting?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static void OnFileSaving(string identifier)
		{
			FileSaving?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static bool? GetAllowExpandAll(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxPivotGrid.GetOption", dxTarget, "allowExpandAll");
		}
		public static void SetAllowExpandAll(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPivotGrid.SetOption", dxTarget, "allowExpandAll", value);
		}
		public static bool? GetAllowFiltering(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxPivotGrid.GetOption", dxTarget, "allowFiltering");
		}
		public static void SetAllowFiltering(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPivotGrid.SetOption", dxTarget, "allowFiltering", value);
		}
		public static bool? GetAllowSorting(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxPivotGrid.GetOption", dxTarget, "allowSorting");
		}
		public static void SetAllowSorting(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPivotGrid.SetOption", dxTarget, "allowSorting", value);
		}
		public static bool? GetAllowSortingBySummary(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxPivotGrid.GetOption", dxTarget, "allowSortingBySummary");
		}
		public static void SetAllowSortingBySummary(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPivotGrid.SetOption", dxTarget, "allowSortingBySummary", value);
		}
		public static string GetDataFieldArea(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxPivotGrid.GetOption", dxTarget, "dataFieldArea");
		}
		public static void SetDataFieldArea(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPivotGrid.SetOption", dxTarget, "dataFieldArea", value);
		}
		public static object GetDataSource(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPivotGrid.GetOption", dxTarget, "dataSource");
		}
		public static void SetDataSource(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPivotGrid.SetOption", dxTarget, "dataSource", value);
		}
		public static object GetExport(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPivotGrid.GetOption", dxTarget, "export");
		}
		public static void SetExport(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPivotGrid.SetOption", dxTarget, "export", value);
		}
		public static object GetFieldChooser(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPivotGrid.GetOption", dxTarget, "fieldChooser");
		}
		public static void SetFieldChooser(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPivotGrid.SetOption", dxTarget, "fieldChooser", value);
		}
		public static object GetFieldPanel(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPivotGrid.GetOption", dxTarget, "fieldPanel");
		}
		public static void SetFieldPanel(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPivotGrid.SetOption", dxTarget, "fieldPanel", value);
		}
		public static object GetHeaderFilter(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPivotGrid.GetOption", dxTarget, "headerFilter");
		}
		public static void SetHeaderFilter(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPivotGrid.SetOption", dxTarget, "headerFilter", value);
		}
		public static bool? GetHideEmptySummaryCells(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxPivotGrid.GetOption", dxTarget, "hideEmptySummaryCells");
		}
		public static void SetHideEmptySummaryCells(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPivotGrid.SetOption", dxTarget, "hideEmptySummaryCells", value);
		}
		public static object GetLoadPanel(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPivotGrid.GetOption", dxTarget, "loadPanel");
		}
		public static void SetLoadPanel(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPivotGrid.SetOption", dxTarget, "loadPanel", value);
		}
		public static string GetRowHeaderLayout(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxPivotGrid.GetOption", dxTarget, "rowHeaderLayout");
		}
		public static void SetRowHeaderLayout(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPivotGrid.SetOption", dxTarget, "rowHeaderLayout", value);
		}
		public static object GetScrolling(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPivotGrid.GetOption", dxTarget, "scrolling");
		}
		public static void SetScrolling(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPivotGrid.SetOption", dxTarget, "scrolling", value);
		}
		public static bool? GetShowBorders(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxPivotGrid.GetOption", dxTarget, "showBorders");
		}
		public static void SetShowBorders(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPivotGrid.SetOption", dxTarget, "showBorders", value);
		}
		public static bool? GetShowColumnGrandTotals(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxPivotGrid.GetOption", dxTarget, "showColumnGrandTotals");
		}
		public static void SetShowColumnGrandTotals(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPivotGrid.SetOption", dxTarget, "showColumnGrandTotals", value);
		}
		public static bool? GetShowColumnTotals(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxPivotGrid.GetOption", dxTarget, "showColumnTotals");
		}
		public static void SetShowColumnTotals(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPivotGrid.SetOption", dxTarget, "showColumnTotals", value);
		}
		public static bool? GetShowRowGrandTotals(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxPivotGrid.GetOption", dxTarget, "showRowGrandTotals");
		}
		public static void SetShowRowGrandTotals(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPivotGrid.SetOption", dxTarget, "showRowGrandTotals", value);
		}
		public static bool? GetShowRowTotals(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxPivotGrid.GetOption", dxTarget, "showRowTotals");
		}
		public static void SetShowRowTotals(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPivotGrid.SetOption", dxTarget, "showRowTotals", value);
		}
		public static string GetShowTotalsPrior(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxPivotGrid.GetOption", dxTarget, "showTotalsPrior");
		}
		public static void SetShowTotalsPrior(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPivotGrid.SetOption", dxTarget, "showTotalsPrior", value);
		}
		public static object GetStateStoring(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPivotGrid.GetOption", dxTarget, "stateStoring");
		}
		public static void SetStateStoring(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPivotGrid.SetOption", dxTarget, "stateStoring", value);
		}
		public static object GetTexts(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPivotGrid.GetOption", dxTarget, "texts");
		}
		public static void SetTexts(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPivotGrid.SetOption", dxTarget, "texts", value);
		}
		public static bool? GetWordWrapEnabled(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxPivotGrid.GetOption", dxTarget, "wordWrapEnabled");
		}
		public static void SetWordWrapEnabled(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPivotGrid.SetOption", dxTarget, "wordWrapEnabled", value);
		}
		public static object BindChart(ElementRef dxTarget, object chart, object integrationOptions)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPivotGrid.bindChart_0", dxTarget, chart, integrationOptions);
		}
		public static void ExportToExcel(ElementRef dxTarget)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPivotGrid.exportToExcel_1", dxTarget);
		}
		public static object GetDataSourceEx(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPivotGrid.getDataSource_2", dxTarget);
		}
		public static object GetFieldChooserPopup(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPivotGrid.getFieldChooserPopup_3", dxTarget);
		}
		public static void UpdateDimensions(ElementRef dxTarget)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPivotGrid.updateDimensions_4", dxTarget);
		}
	}
	public class DxPivotGridFieldChooserInterop: WidgetInterop
	{
		public static event EventHandler<JQueryEventArgs> ContextMenuPreparing;
		public static void Init(ElementRef dxTarget, DevExpress.Ui.DxPivotGridFieldChooserOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPivotGridFieldChooser.Init", dxTarget, json);
		}
		public static void OnContextMenuPreparing(string identifier)
		{
			ContextMenuPreparing?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static bool? GetAllowSearch(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxPivotGridFieldChooser.GetOption", dxTarget, "allowSearch");
		}
		public static void SetAllowSearch(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPivotGridFieldChooser.SetOption", dxTarget, "allowSearch", value);
		}
		public static string GetApplyChangesMode(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxPivotGridFieldChooser.GetOption", dxTarget, "applyChangesMode");
		}
		public static void SetApplyChangesMode(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPivotGridFieldChooser.SetOption", dxTarget, "applyChangesMode", value);
		}
		public static object GetDataSource(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPivotGridFieldChooser.GetOption", dxTarget, "dataSource");
		}
		public static void SetDataSource(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPivotGridFieldChooser.SetOption", dxTarget, "dataSource", value);
		}
		public static object GetHeaderFilter(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPivotGridFieldChooser.GetOption", dxTarget, "headerFilter");
		}
		public static void SetHeaderFilter(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPivotGridFieldChooser.SetOption", dxTarget, "headerFilter", value);
		}
		public static new object GetHeight(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPivotGridFieldChooser.GetOption", dxTarget, "height");
		}
		public static new void SetHeight(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPivotGridFieldChooser.SetOption", dxTarget, "height", value);
		}
		public static object GetLayout(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPivotGridFieldChooser.GetOption", dxTarget, "layout");
		}
		public static void SetLayout(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPivotGridFieldChooser.SetOption", dxTarget, "layout", value);
		}
		public static object GetState(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPivotGridFieldChooser.GetOption", dxTarget, "state");
		}
		public static void SetState(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPivotGridFieldChooser.SetOption", dxTarget, "state", value);
		}
		public static object GetTexts(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPivotGridFieldChooser.GetOption", dxTarget, "texts");
		}
		public static void SetTexts(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPivotGridFieldChooser.SetOption", dxTarget, "texts", value);
		}
		public static void ApplyChanges(ElementRef dxTarget)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPivotGridFieldChooser.applyChanges_0", dxTarget);
		}
		public static void CancelChanges(ElementRef dxTarget)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPivotGridFieldChooser.cancelChanges_1", dxTarget);
		}
		public static object GetDataSourceEx(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPivotGridFieldChooser.getDataSource_2", dxTarget);
		}
		public static void UpdateDimensions(ElementRef dxTarget)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPivotGridFieldChooser.updateDimensions_3", dxTarget);
		}
	}
	public class DxPopoverInterop: DxPopupInterop
	{
		public static void Init(ElementRef dxTarget, DevExpress.Ui.DxPopoverOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPopover.Init", dxTarget, json);
		}
		public static new object GetAnimation(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPopover.GetOption", dxTarget, "animation");
		}
		public static new void SetAnimation(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPopover.SetOption", dxTarget, "animation", value);
		}
		public static new object GetCloseOnOutsideClick(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPopover.GetOption", dxTarget, "closeOnOutsideClick");
		}
		public static new void SetCloseOnOutsideClick(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPopover.SetOption", dxTarget, "closeOnOutsideClick", value);
		}
		public static new object GetHeight(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPopover.GetOption", dxTarget, "height");
		}
		public static new void SetHeight(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPopover.SetOption", dxTarget, "height", value);
		}
		public static object GetHideEvent(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPopover.GetOption", dxTarget, "hideEvent");
		}
		public static void SetHideEvent(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPopover.SetOption", dxTarget, "hideEvent", value);
		}
		public static new object GetPosition(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPopover.GetOption", dxTarget, "position");
		}
		public static new void SetPosition(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPopover.SetOption", dxTarget, "position", value);
		}
		public static new bool? GetShading(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxPopover.GetOption", dxTarget, "shading");
		}
		public static new void SetShading(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPopover.SetOption", dxTarget, "shading", value);
		}
		public static object GetShowEvent(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPopover.GetOption", dxTarget, "showEvent");
		}
		public static void SetShowEvent(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPopover.SetOption", dxTarget, "showEvent", value);
		}
		public static new bool? GetShowTitle(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxPopover.GetOption", dxTarget, "showTitle");
		}
		public static new void SetShowTitle(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPopover.SetOption", dxTarget, "showTitle", value);
		}
		public static object GetTarget(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPopover.GetOption", dxTarget, "target");
		}
		public static void SetTarget(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPopover.SetOption", dxTarget, "target", value);
		}
		public static new object GetWidth(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPopover.GetOption", dxTarget, "width");
		}
		public static new void SetWidth(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPopover.SetOption", dxTarget, "width", value);
		}
		public static object Show(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPopover.show_0", dxTarget);
		}
		public static object Show(ElementRef dxTarget, object target)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPopover.show_1", dxTarget, target);
		}
	}
	public class DxPopupInterop: DxOverlayInterop
	{
		public static event EventHandler<JQueryEventArgs> Resize;
		public static event EventHandler<JQueryEventArgs> ResizeEnd;
		public static event EventHandler<JQueryEventArgs> ResizeStart;
		public static event EventHandler<JQueryEventArgs> TitleRendered;
		public static void Init(ElementRef dxTarget, DevExpress.Ui.DxPopupOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPopup.Init", dxTarget, json);
		}
		public static void OnResize(string identifier)
		{
			Resize?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static void OnResizeEnd(string identifier)
		{
			ResizeEnd?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static void OnResizeStart(string identifier)
		{
			ResizeStart?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static void OnTitleRendered(string identifier)
		{
			TitleRendered?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static new object GetAnimation(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPopup.GetOption", dxTarget, "animation");
		}
		public static new void SetAnimation(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPopup.SetOption", dxTarget, "animation", value);
		}
		public static object GetContainer(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPopup.GetOption", dxTarget, "container");
		}
		public static void SetContainer(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPopup.SetOption", dxTarget, "container", value);
		}
		public static new bool? GetDragEnabled(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxPopup.GetOption", dxTarget, "dragEnabled");
		}
		public static new void SetDragEnabled(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPopup.SetOption", dxTarget, "dragEnabled", value);
		}
		public static new bool? GetFocusStateEnabled(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxPopup.GetOption", dxTarget, "focusStateEnabled");
		}
		public static new void SetFocusStateEnabled(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPopup.SetOption", dxTarget, "focusStateEnabled", value);
		}
		public static bool? GetFullScreen(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxPopup.GetOption", dxTarget, "fullScreen");
		}
		public static void SetFullScreen(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPopup.SetOption", dxTarget, "fullScreen", value);
		}
		public static new object GetHeight(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPopup.GetOption", dxTarget, "height");
		}
		public static new void SetHeight(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPopup.SetOption", dxTarget, "height", value);
		}
		public static new object GetPosition(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPopup.GetOption", dxTarget, "position");
		}
		public static new void SetPosition(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPopup.SetOption", dxTarget, "position", value);
		}
		public static bool? GetResizeEnabled(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxPopup.GetOption", dxTarget, "resizeEnabled");
		}
		public static void SetResizeEnabled(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPopup.SetOption", dxTarget, "resizeEnabled", value);
		}
		public static bool? GetShowCloseButton(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxPopup.GetOption", dxTarget, "showCloseButton");
		}
		public static void SetShowCloseButton(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPopup.SetOption", dxTarget, "showCloseButton", value);
		}
		public static bool? GetShowTitle(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxPopup.GetOption", dxTarget, "showTitle");
		}
		public static void SetShowTitle(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPopup.SetOption", dxTarget, "showTitle", value);
		}
		public static string GetTitle(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxPopup.GetOption", dxTarget, "title");
		}
		public static void SetTitle(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPopup.SetOption", dxTarget, "title", value);
		}
		public static object GetTitleTemplate(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPopup.GetOption", dxTarget, "titleTemplate");
		}
		public static void SetTitleTemplate(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPopup.SetOption", dxTarget, "titleTemplate", value);
		}
		public static object GetToolbarItems(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPopup.GetOption", dxTarget, "toolbarItems");
		}
		public static void SetToolbarItems(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPopup.SetOption", dxTarget, "toolbarItems", value);
		}
		public static new object GetWidth(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPopup.GetOption", dxTarget, "width");
		}
		public static new void SetWidth(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPopup.SetOption", dxTarget, "width", value);
		}
	}
	public class DxProgressBarInterop: DxTrackBarInterop
	{
		public static event EventHandler<JQueryEventArgs> Complete;
		public static void Init(ElementRef dxTarget, DevExpress.Ui.DxProgressBarOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxProgressBar.Init", dxTarget, json);
		}
		public static void OnComplete(string identifier)
		{
			Complete?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static bool? GetShowStatus(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxProgressBar.GetOption", dxTarget, "showStatus");
		}
		public static void SetShowStatus(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxProgressBar.SetOption", dxTarget, "showStatus", value);
		}
		public static object GetStatusFormat(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxProgressBar.GetOption", dxTarget, "statusFormat");
		}
		public static void SetStatusFormat(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxProgressBar.SetOption", dxTarget, "statusFormat", value);
		}
		public static new float? GetValue(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<float?>("BlazorDevExtreme.DxProgressBar.GetOption", dxTarget, "value");
		}
		public static new void SetValue(ElementRef dxTarget, float? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxProgressBar.SetOption", dxTarget, "value", value);
		}
	}
	public class DxRadioGroupInterop: EditorInterop
	{
		public static void Init(ElementRef dxTarget, DevExpress.Ui.DxRadioGroupOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxRadioGroup.Init", dxTarget, json);
		}
		public static new bool? GetActiveStateEnabled(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxRadioGroup.GetOption", dxTarget, "activeStateEnabled");
		}
		public static new void SetActiveStateEnabled(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxRadioGroup.SetOption", dxTarget, "activeStateEnabled", value);
		}
		public static new bool? GetFocusStateEnabled(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxRadioGroup.GetOption", dxTarget, "focusStateEnabled");
		}
		public static new void SetFocusStateEnabled(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxRadioGroup.SetOption", dxTarget, "focusStateEnabled", value);
		}
		public static new bool? GetHoverStateEnabled(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxRadioGroup.GetOption", dxTarget, "hoverStateEnabled");
		}
		public static new void SetHoverStateEnabled(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxRadioGroup.SetOption", dxTarget, "hoverStateEnabled", value);
		}
		public static string GetLayout(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxRadioGroup.GetOption", dxTarget, "layout");
		}
		public static void SetLayout(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxRadioGroup.SetOption", dxTarget, "layout", value);
		}
		public static string GetName(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxRadioGroup.GetOption", dxTarget, "name");
		}
		public static void SetName(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxRadioGroup.SetOption", dxTarget, "name", value);
		}
		public static new object GetValue(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxRadioGroup.GetOption", dxTarget, "value");
		}
		public static new void SetValue(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxRadioGroup.SetOption", dxTarget, "value", value);
		}
		public static object GetDataSourceEx(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxRadioGroup.getDataSource_0", dxTarget);
		}
	}
	public class DxRangeSliderInterop: DxSliderBaseInterop
	{
		public static event EventHandler<JQueryEventArgs> ValueChanged;
		public static void Init(ElementRef dxTarget, DevExpress.Ui.DxRangeSliderOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxRangeSlider.Init", dxTarget, json);
		}
		public static void OnValueChanged(string identifier)
		{
			ValueChanged?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static float? GetEnd(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<float?>("BlazorDevExtreme.DxRangeSlider.GetOption", dxTarget, "end");
		}
		public static void SetEnd(ElementRef dxTarget, float? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxRangeSlider.SetOption", dxTarget, "end", value);
		}
		public static string GetEndName(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxRangeSlider.GetOption", dxTarget, "endName");
		}
		public static void SetEndName(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxRangeSlider.SetOption", dxTarget, "endName", value);
		}
		public static float? GetStart(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<float?>("BlazorDevExtreme.DxRangeSlider.GetOption", dxTarget, "start");
		}
		public static void SetStart(ElementRef dxTarget, float? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxRangeSlider.SetOption", dxTarget, "start", value);
		}
		public static string GetStartName(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxRangeSlider.GetOption", dxTarget, "startName");
		}
		public static void SetStartName(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxRangeSlider.SetOption", dxTarget, "startName", value);
		}
		public static new object GetValue(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxRangeSlider.GetOption", dxTarget, "value");
		}
		public static new void SetValue(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxRangeSlider.SetOption", dxTarget, "value", value);
		}
		public static void Reset(ElementRef dxTarget)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxRangeSlider.reset_0", dxTarget);
		}
	}
	public class DxResizableInterop: DOMComponentInterop
	{
		public static event EventHandler<JQueryEventArgs> Resize;
		public static event EventHandler<JQueryEventArgs> ResizeEnd;
		public static event EventHandler<JQueryEventArgs> ResizeStart;
		public static void Init(ElementRef dxTarget, DevExpress.Ui.DxResizableOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxResizable.Init", dxTarget, json);
		}
		public static void OnResize(string identifier)
		{
			Resize?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static void OnResizeEnd(string identifier)
		{
			ResizeEnd?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static void OnResizeStart(string identifier)
		{
			ResizeStart?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static string GetHandles(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxResizable.GetOption", dxTarget, "handles");
		}
		public static void SetHandles(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxResizable.SetOption", dxTarget, "handles", value);
		}
		public static new object GetHeight(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxResizable.GetOption", dxTarget, "height");
		}
		public static new void SetHeight(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxResizable.SetOption", dxTarget, "height", value);
		}
		public static float? GetMaxHeight(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<float?>("BlazorDevExtreme.DxResizable.GetOption", dxTarget, "maxHeight");
		}
		public static void SetMaxHeight(ElementRef dxTarget, float? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxResizable.SetOption", dxTarget, "maxHeight", value);
		}
		public static float? GetMaxWidth(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<float?>("BlazorDevExtreme.DxResizable.GetOption", dxTarget, "maxWidth");
		}
		public static void SetMaxWidth(ElementRef dxTarget, float? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxResizable.SetOption", dxTarget, "maxWidth", value);
		}
		public static float? GetMinHeight(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<float?>("BlazorDevExtreme.DxResizable.GetOption", dxTarget, "minHeight");
		}
		public static void SetMinHeight(ElementRef dxTarget, float? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxResizable.SetOption", dxTarget, "minHeight", value);
		}
		public static float? GetMinWidth(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<float?>("BlazorDevExtreme.DxResizable.GetOption", dxTarget, "minWidth");
		}
		public static void SetMinWidth(ElementRef dxTarget, float? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxResizable.SetOption", dxTarget, "minWidth", value);
		}
		public static new object GetWidth(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxResizable.GetOption", dxTarget, "width");
		}
		public static new void SetWidth(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxResizable.SetOption", dxTarget, "width", value);
		}
	}
	public class DxResponsiveBoxInterop: CollectionWidgetInterop
	{
		public static void Init(ElementRef dxTarget, DevExpress.Ui.DxResponsiveBoxOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxResponsiveBox.Init", dxTarget, json);
		}
		public static object GetCols(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxResponsiveBox.GetOption", dxTarget, "cols");
		}
		public static void SetCols(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxResponsiveBox.SetOption", dxTarget, "cols", value);
		}
		public static new object GetHeight(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxResponsiveBox.GetOption", dxTarget, "height");
		}
		public static new void SetHeight(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxResponsiveBox.SetOption", dxTarget, "height", value);
		}
		public static object GetRows(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxResponsiveBox.GetOption", dxTarget, "rows");
		}
		public static void SetRows(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxResponsiveBox.SetOption", dxTarget, "rows", value);
		}
		public static object GetScreenByWidth(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxResponsiveBox.GetOption", dxTarget, "screenByWidth");
		}
		public static void SetScreenByWidth(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxResponsiveBox.SetOption", dxTarget, "screenByWidth", value);
		}
		public static string GetSingleColumnScreen(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxResponsiveBox.GetOption", dxTarget, "singleColumnScreen");
		}
		public static void SetSingleColumnScreen(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxResponsiveBox.SetOption", dxTarget, "singleColumnScreen", value);
		}
		public static new object GetWidth(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxResponsiveBox.GetOption", dxTarget, "width");
		}
		public static new void SetWidth(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxResponsiveBox.SetOption", dxTarget, "width", value);
		}
	}
	public class DxSchedulerInterop: WidgetInterop
	{
		public static event EventHandler<JQueryEventArgs> AppointmentAdded;
		public static event EventHandler<JQueryEventArgs> AppointmentAdding;
		public static event EventHandler<JQueryEventArgs> AppointmentClick;
		public static event EventHandler<JQueryEventArgs> AppointmentContextMenu;
		public static event EventHandler<JQueryEventArgs> AppointmentDblClick;
		public static event EventHandler<JQueryEventArgs> AppointmentDeleted;
		public static event EventHandler<JQueryEventArgs> AppointmentDeleting;
		public static event EventHandler<JQueryEventArgs> AppointmentFormCreated;
		public static event EventHandler<JQueryEventArgs> AppointmentRendered;
		public static event EventHandler<JQueryEventArgs> AppointmentUpdated;
		public static event EventHandler<JQueryEventArgs> AppointmentUpdating;
		public static event EventHandler<JQueryEventArgs> CellClick;
		public static event EventHandler<JQueryEventArgs> CellContextMenu;
		public static void Init(ElementRef dxTarget, DevExpress.Ui.DxSchedulerOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxScheduler.Init", dxTarget, json);
		}
		public static void OnAppointmentAdded(string identifier)
		{
			AppointmentAdded?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static void OnAppointmentAdding(string identifier)
		{
			AppointmentAdding?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static void OnAppointmentClick(string identifier)
		{
			AppointmentClick?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static void OnAppointmentContextMenu(string identifier)
		{
			AppointmentContextMenu?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static void OnAppointmentDblClick(string identifier)
		{
			AppointmentDblClick?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static void OnAppointmentDeleted(string identifier)
		{
			AppointmentDeleted?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static void OnAppointmentDeleting(string identifier)
		{
			AppointmentDeleting?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static void OnAppointmentFormCreated(string identifier)
		{
			AppointmentFormCreated?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static void OnAppointmentRendered(string identifier)
		{
			AppointmentRendered?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static void OnAppointmentUpdated(string identifier)
		{
			AppointmentUpdated?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static void OnAppointmentUpdating(string identifier)
		{
			AppointmentUpdating?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static void OnCellClick(string identifier)
		{
			CellClick?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static void OnCellContextMenu(string identifier)
		{
			CellContextMenu?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static string GetAllDayExpr(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxScheduler.GetOption", dxTarget, "allDayExpr");
		}
		public static void SetAllDayExpr(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxScheduler.SetOption", dxTarget, "allDayExpr", value);
		}
		public static object GetAppointmentTemplate(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxScheduler.GetOption", dxTarget, "appointmentTemplate");
		}
		public static void SetAppointmentTemplate(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxScheduler.SetOption", dxTarget, "appointmentTemplate", value);
		}
		public static object GetAppointmentTooltipTemplate(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxScheduler.GetOption", dxTarget, "appointmentTooltipTemplate");
		}
		public static void SetAppointmentTooltipTemplate(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxScheduler.SetOption", dxTarget, "appointmentTooltipTemplate", value);
		}
		public static float? GetCellDuration(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<float?>("BlazorDevExtreme.DxScheduler.GetOption", dxTarget, "cellDuration");
		}
		public static void SetCellDuration(ElementRef dxTarget, float? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxScheduler.SetOption", dxTarget, "cellDuration", value);
		}
		public static bool? GetCrossScrollingEnabled(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxScheduler.GetOption", dxTarget, "crossScrollingEnabled");
		}
		public static void SetCrossScrollingEnabled(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxScheduler.SetOption", dxTarget, "crossScrollingEnabled", value);
		}
		public static object GetCurrentDate(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxScheduler.GetOption", dxTarget, "currentDate");
		}
		public static void SetCurrentDate(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxScheduler.SetOption", dxTarget, "currentDate", value);
		}
		public static string GetCurrentView(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxScheduler.GetOption", dxTarget, "currentView");
		}
		public static void SetCurrentView(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxScheduler.SetOption", dxTarget, "currentView", value);
		}
		public static object GetDataCellTemplate(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxScheduler.GetOption", dxTarget, "dataCellTemplate");
		}
		public static void SetDataCellTemplate(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxScheduler.SetOption", dxTarget, "dataCellTemplate", value);
		}
		public static object GetDataSource(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxScheduler.GetOption", dxTarget, "dataSource");
		}
		public static void SetDataSource(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxScheduler.SetOption", dxTarget, "dataSource", value);
		}
		public static object GetDateCellTemplate(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxScheduler.GetOption", dxTarget, "dateCellTemplate");
		}
		public static void SetDateCellTemplate(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxScheduler.SetOption", dxTarget, "dateCellTemplate", value);
		}
		public static string GetDateSerializationFormat(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxScheduler.GetOption", dxTarget, "dateSerializationFormat");
		}
		public static void SetDateSerializationFormat(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxScheduler.SetOption", dxTarget, "dateSerializationFormat", value);
		}
		public static string GetDescriptionExpr(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxScheduler.GetOption", dxTarget, "descriptionExpr");
		}
		public static void SetDescriptionExpr(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxScheduler.SetOption", dxTarget, "descriptionExpr", value);
		}
		public static object GetDropDownAppointmentTemplate(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxScheduler.GetOption", dxTarget, "dropDownAppointmentTemplate");
		}
		public static void SetDropDownAppointmentTemplate(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxScheduler.SetOption", dxTarget, "dropDownAppointmentTemplate", value);
		}
		public static object GetEditing(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxScheduler.GetOption", dxTarget, "editing");
		}
		public static void SetEditing(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxScheduler.SetOption", dxTarget, "editing", value);
		}
		public static string GetEndDateExpr(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxScheduler.GetOption", dxTarget, "endDateExpr");
		}
		public static void SetEndDateExpr(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxScheduler.SetOption", dxTarget, "endDateExpr", value);
		}
		public static string GetEndDateTimeZoneExpr(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxScheduler.GetOption", dxTarget, "endDateTimeZoneExpr");
		}
		public static void SetEndDateTimeZoneExpr(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxScheduler.SetOption", dxTarget, "endDateTimeZoneExpr", value);
		}
		public static float? GetEndDayHour(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<float?>("BlazorDevExtreme.DxScheduler.GetOption", dxTarget, "endDayHour");
		}
		public static void SetEndDayHour(ElementRef dxTarget, float? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxScheduler.SetOption", dxTarget, "endDayHour", value);
		}
		public static object GetFirstDayOfWeek(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxScheduler.GetOption", dxTarget, "firstDayOfWeek");
		}
		public static void SetFirstDayOfWeek(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxScheduler.SetOption", dxTarget, "firstDayOfWeek", value);
		}
		public static new bool? GetFocusStateEnabled(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxScheduler.GetOption", dxTarget, "focusStateEnabled");
		}
		public static new void SetFocusStateEnabled(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxScheduler.SetOption", dxTarget, "focusStateEnabled", value);
		}
		public static object GetGroups(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxScheduler.GetOption", dxTarget, "groups");
		}
		public static void SetGroups(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxScheduler.SetOption", dxTarget, "groups", value);
		}
		public static float? GetIndicatorUpdateInterval(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<float?>("BlazorDevExtreme.DxScheduler.GetOption", dxTarget, "indicatorUpdateInterval");
		}
		public static void SetIndicatorUpdateInterval(ElementRef dxTarget, float? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxScheduler.SetOption", dxTarget, "indicatorUpdateInterval", value);
		}
		public static object GetMax(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxScheduler.GetOption", dxTarget, "max");
		}
		public static void SetMax(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxScheduler.SetOption", dxTarget, "max", value);
		}
		public static object GetMaxAppointmentsPerCell(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxScheduler.GetOption", dxTarget, "maxAppointmentsPerCell");
		}
		public static void SetMaxAppointmentsPerCell(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxScheduler.SetOption", dxTarget, "maxAppointmentsPerCell", value);
		}
		public static object GetMin(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxScheduler.GetOption", dxTarget, "min");
		}
		public static void SetMin(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxScheduler.SetOption", dxTarget, "min", value);
		}
		public static string GetNoDataText(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxScheduler.GetOption", dxTarget, "noDataText");
		}
		public static void SetNoDataText(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxScheduler.SetOption", dxTarget, "noDataText", value);
		}
		public static string GetRecurrenceEditMode(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxScheduler.GetOption", dxTarget, "recurrenceEditMode");
		}
		public static void SetRecurrenceEditMode(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxScheduler.SetOption", dxTarget, "recurrenceEditMode", value);
		}
		public static string GetRecurrenceExceptionExpr(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxScheduler.GetOption", dxTarget, "recurrenceExceptionExpr");
		}
		public static void SetRecurrenceExceptionExpr(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxScheduler.SetOption", dxTarget, "recurrenceExceptionExpr", value);
		}
		public static string GetRecurrenceRuleExpr(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxScheduler.GetOption", dxTarget, "recurrenceRuleExpr");
		}
		public static void SetRecurrenceRuleExpr(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxScheduler.SetOption", dxTarget, "recurrenceRuleExpr", value);
		}
		public static bool? GetRemoteFiltering(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxScheduler.GetOption", dxTarget, "remoteFiltering");
		}
		public static void SetRemoteFiltering(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxScheduler.SetOption", dxTarget, "remoteFiltering", value);
		}
		public static object GetResourceCellTemplate(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxScheduler.GetOption", dxTarget, "resourceCellTemplate");
		}
		public static void SetResourceCellTemplate(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxScheduler.SetOption", dxTarget, "resourceCellTemplate", value);
		}
		public static object GetResources(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxScheduler.GetOption", dxTarget, "resources");
		}
		public static void SetResources(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxScheduler.SetOption", dxTarget, "resources", value);
		}
		public static object GetSelectedCellData(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxScheduler.GetOption", dxTarget, "selectedCellData");
		}
		public static void SetSelectedCellData(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxScheduler.SetOption", dxTarget, "selectedCellData", value);
		}
		public static bool? GetShadeUntilCurrentTime(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxScheduler.GetOption", dxTarget, "shadeUntilCurrentTime");
		}
		public static void SetShadeUntilCurrentTime(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxScheduler.SetOption", dxTarget, "shadeUntilCurrentTime", value);
		}
		public static bool? GetShowAllDayPanel(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxScheduler.GetOption", dxTarget, "showAllDayPanel");
		}
		public static void SetShowAllDayPanel(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxScheduler.SetOption", dxTarget, "showAllDayPanel", value);
		}
		public static bool? GetShowCurrentTimeIndicator(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxScheduler.GetOption", dxTarget, "showCurrentTimeIndicator");
		}
		public static void SetShowCurrentTimeIndicator(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxScheduler.SetOption", dxTarget, "showCurrentTimeIndicator", value);
		}
		public static string GetStartDateExpr(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxScheduler.GetOption", dxTarget, "startDateExpr");
		}
		public static void SetStartDateExpr(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxScheduler.SetOption", dxTarget, "startDateExpr", value);
		}
		public static string GetStartDateTimeZoneExpr(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxScheduler.GetOption", dxTarget, "startDateTimeZoneExpr");
		}
		public static void SetStartDateTimeZoneExpr(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxScheduler.SetOption", dxTarget, "startDateTimeZoneExpr", value);
		}
		public static float? GetStartDayHour(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<float?>("BlazorDevExtreme.DxScheduler.GetOption", dxTarget, "startDayHour");
		}
		public static void SetStartDayHour(ElementRef dxTarget, float? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxScheduler.SetOption", dxTarget, "startDayHour", value);
		}
		public static string GetTextExpr(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxScheduler.GetOption", dxTarget, "textExpr");
		}
		public static void SetTextExpr(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxScheduler.SetOption", dxTarget, "textExpr", value);
		}
		public static object GetTimeCellTemplate(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxScheduler.GetOption", dxTarget, "timeCellTemplate");
		}
		public static void SetTimeCellTemplate(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxScheduler.SetOption", dxTarget, "timeCellTemplate", value);
		}
		public static string GetTimeZone(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxScheduler.GetOption", dxTarget, "timeZone");
		}
		public static void SetTimeZone(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxScheduler.SetOption", dxTarget, "timeZone", value);
		}
		public static bool? GetUseDropDownViewSwitcher(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxScheduler.GetOption", dxTarget, "useDropDownViewSwitcher");
		}
		public static void SetUseDropDownViewSwitcher(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxScheduler.SetOption", dxTarget, "useDropDownViewSwitcher", value);
		}
		public static object GetViews(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxScheduler.GetOption", dxTarget, "views");
		}
		public static void SetViews(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxScheduler.SetOption", dxTarget, "views", value);
		}
		public static void AddAppointment(ElementRef dxTarget, object appointment)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxScheduler.addAppointment_0", dxTarget, appointment);
		}
		public static void DeleteAppointment(ElementRef dxTarget, object appointment)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxScheduler.deleteAppointment_1", dxTarget, appointment);
		}
		public static object GetDataSourceEx(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxScheduler.getDataSource_2", dxTarget);
		}
		public static object GetEndViewDate(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxScheduler.getEndViewDate_3", dxTarget);
		}
		public static object GetStartViewDate(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxScheduler.getStartViewDate_4", dxTarget);
		}
		public static void HideAppointmentPopup(ElementRef dxTarget, bool saveChanges)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxScheduler.hideAppointmentPopup_5", dxTarget, saveChanges);
		}
		public static void HideAppointmentTooltip(ElementRef dxTarget)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxScheduler.hideAppointmentTooltip_6", dxTarget);
		}
		public static void RegisterKeyHandler(ElementRef dxTarget)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxScheduler.registerKeyHandler_7", dxTarget);
		}
		public static void ScrollToTime(ElementRef dxTarget, float hours, float minutes, object date)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxScheduler.scrollToTime_8", dxTarget, hours, minutes, date);
		}
		public static void ShowAppointmentPopup(ElementRef dxTarget, object appointmentData, bool createNewAppointment, object currentAppointmentData)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxScheduler.showAppointmentPopup_9", dxTarget, appointmentData, createNewAppointment, currentAppointmentData);
		}
		public static void ShowAppointmentTooltip(ElementRef dxTarget, object appointmentData, object target, object currentAppointmentData)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxScheduler.showAppointmentTooltip_10", dxTarget, appointmentData, target, currentAppointmentData);
		}
		public static void UpdateAppointment(ElementRef dxTarget, object target, object appointment)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxScheduler.updateAppointment_11", dxTarget, target, appointment);
		}
	}
	public class DxScrollViewInterop: DxScrollableInterop
	{
		public static event EventHandler<JQueryEventArgs> PullDown;
		public static event EventHandler<JQueryEventArgs> ReachBottom;
		public static void Init(ElementRef dxTarget, DevExpress.Ui.DxScrollViewOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxScrollView.Init", dxTarget, json);
		}
		public static void OnPullDown(string identifier)
		{
			PullDown?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static void OnReachBottom(string identifier)
		{
			ReachBottom?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static string GetPulledDownText(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxScrollView.GetOption", dxTarget, "pulledDownText");
		}
		public static void SetPulledDownText(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxScrollView.SetOption", dxTarget, "pulledDownText", value);
		}
		public static string GetPullingDownText(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxScrollView.GetOption", dxTarget, "pullingDownText");
		}
		public static void SetPullingDownText(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxScrollView.SetOption", dxTarget, "pullingDownText", value);
		}
		public static string GetReachBottomText(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxScrollView.GetOption", dxTarget, "reachBottomText");
		}
		public static void SetReachBottomText(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxScrollView.SetOption", dxTarget, "reachBottomText", value);
		}
		public static string GetRefreshingText(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxScrollView.GetOption", dxTarget, "refreshingText");
		}
		public static void SetRefreshingText(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxScrollView.SetOption", dxTarget, "refreshingText", value);
		}
		public static void Refresh(ElementRef dxTarget)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxScrollView.refresh_0", dxTarget);
		}
		public static object Release(ElementRef dxTarget, bool preventScrollBottom)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxScrollView.release_1", dxTarget, preventScrollBottom);
		}
	}
	public class DxSelectBoxInterop: DxDropDownListInterop
	{
		public static event EventHandler<JQueryEventArgs> CustomItemCreating;
		public static void Init(ElementRef dxTarget, DevExpress.Ui.DxSelectBoxOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxSelectBox.Init", dxTarget, json);
		}
		public static void OnCustomItemCreating(string identifier)
		{
			CustomItemCreating?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static new bool? GetAcceptCustomValue(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxSelectBox.GetOption", dxTarget, "acceptCustomValue");
		}
		public static new void SetAcceptCustomValue(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxSelectBox.SetOption", dxTarget, "acceptCustomValue", value);
		}
		public static object GetFieldTemplate(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxSelectBox.GetOption", dxTarget, "fieldTemplate");
		}
		public static void SetFieldTemplate(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxSelectBox.SetOption", dxTarget, "fieldTemplate", value);
		}
		public static new string GetPlaceholder(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxSelectBox.GetOption", dxTarget, "placeholder");
		}
		public static new void SetPlaceholder(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxSelectBox.SetOption", dxTarget, "placeholder", value);
		}
		public static bool? GetShowSelectionControls(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxSelectBox.GetOption", dxTarget, "showSelectionControls");
		}
		public static void SetShowSelectionControls(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxSelectBox.SetOption", dxTarget, "showSelectionControls", value);
		}
		public static new string GetValueChangeEvent(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxSelectBox.GetOption", dxTarget, "valueChangeEvent");
		}
		public static new void SetValueChangeEvent(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxSelectBox.SetOption", dxTarget, "valueChangeEvent", value);
		}
	}
	public class DxSliderInterop: DxSliderBaseInterop
	{
		public static void Init(ElementRef dxTarget, DevExpress.Ui.DxSliderOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxSlider.Init", dxTarget, json);
		}
		public static new float? GetValue(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<float?>("BlazorDevExtreme.DxSlider.GetOption", dxTarget, "value");
		}
		public static new void SetValue(ElementRef dxTarget, float? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxSlider.SetOption", dxTarget, "value", value);
		}
	}
	public class DxSlideOutInterop: CollectionWidgetInterop
	{
		public static event EventHandler<JQueryEventArgs> MenuGroupRendered;
		public static event EventHandler<JQueryEventArgs> MenuItemRendered;
		public static void Init(ElementRef dxTarget, DevExpress.Ui.DxSlideOutOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxSlideOut.Init", dxTarget, json);
		}
		public static void OnMenuGroupRendered(string identifier)
		{
			MenuGroupRendered?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static void OnMenuItemRendered(string identifier)
		{
			MenuItemRendered?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static new bool? GetActiveStateEnabled(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxSlideOut.GetOption", dxTarget, "activeStateEnabled");
		}
		public static new void SetActiveStateEnabled(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxSlideOut.SetOption", dxTarget, "activeStateEnabled", value);
		}
		public static object GetContentTemplate(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxSlideOut.GetOption", dxTarget, "contentTemplate");
		}
		public static void SetContentTemplate(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxSlideOut.SetOption", dxTarget, "contentTemplate", value);
		}
		public static bool? GetMenuGrouped(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxSlideOut.GetOption", dxTarget, "menuGrouped");
		}
		public static void SetMenuGrouped(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxSlideOut.SetOption", dxTarget, "menuGrouped", value);
		}
		public static object GetMenuGroupTemplate(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxSlideOut.GetOption", dxTarget, "menuGroupTemplate");
		}
		public static void SetMenuGroupTemplate(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxSlideOut.SetOption", dxTarget, "menuGroupTemplate", value);
		}
		public static object GetMenuItemTemplate(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxSlideOut.GetOption", dxTarget, "menuItemTemplate");
		}
		public static void SetMenuItemTemplate(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxSlideOut.SetOption", dxTarget, "menuItemTemplate", value);
		}
		public static string GetMenuPosition(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxSlideOut.GetOption", dxTarget, "menuPosition");
		}
		public static void SetMenuPosition(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxSlideOut.SetOption", dxTarget, "menuPosition", value);
		}
		public static bool? GetMenuVisible(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxSlideOut.GetOption", dxTarget, "menuVisible");
		}
		public static void SetMenuVisible(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxSlideOut.SetOption", dxTarget, "menuVisible", value);
		}
		public static new float? GetSelectedIndex(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<float?>("BlazorDevExtreme.DxSlideOut.GetOption", dxTarget, "selectedIndex");
		}
		public static new void SetSelectedIndex(ElementRef dxTarget, float? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxSlideOut.SetOption", dxTarget, "selectedIndex", value);
		}
		public static bool? GetSwipeEnabled(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxSlideOut.GetOption", dxTarget, "swipeEnabled");
		}
		public static void SetSwipeEnabled(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxSlideOut.SetOption", dxTarget, "swipeEnabled", value);
		}
		public static object HideMenu(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxSlideOut.hideMenu_0", dxTarget);
		}
		public static object ShowMenu(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxSlideOut.showMenu_1", dxTarget);
		}
		public static object ToggleMenuVisibility(ElementRef dxTarget, bool showing)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxSlideOut.toggleMenuVisibility_2", dxTarget, showing);
		}
	}
	public class DxSlideOutViewInterop: WidgetInterop
	{
		public static void Init(ElementRef dxTarget, DevExpress.Ui.DxSlideOutViewOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxSlideOutView.Init", dxTarget, json);
		}
		public static object GetContentTemplate(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxSlideOutView.GetOption", dxTarget, "contentTemplate");
		}
		public static void SetContentTemplate(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxSlideOutView.SetOption", dxTarget, "contentTemplate", value);
		}
		public static string GetMenuPosition(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxSlideOutView.GetOption", dxTarget, "menuPosition");
		}
		public static void SetMenuPosition(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxSlideOutView.SetOption", dxTarget, "menuPosition", value);
		}
		public static object GetMenuTemplate(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxSlideOutView.GetOption", dxTarget, "menuTemplate");
		}
		public static void SetMenuTemplate(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxSlideOutView.SetOption", dxTarget, "menuTemplate", value);
		}
		public static bool? GetMenuVisible(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxSlideOutView.GetOption", dxTarget, "menuVisible");
		}
		public static void SetMenuVisible(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxSlideOutView.SetOption", dxTarget, "menuVisible", value);
		}
		public static bool? GetSwipeEnabled(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxSlideOutView.GetOption", dxTarget, "swipeEnabled");
		}
		public static void SetSwipeEnabled(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxSlideOutView.SetOption", dxTarget, "swipeEnabled", value);
		}
		public static object Content(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxSlideOutView.content_0", dxTarget);
		}
		public static object HideMenu(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxSlideOutView.hideMenu_1", dxTarget);
		}
		public static object MenuContent(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxSlideOutView.menuContent_2", dxTarget);
		}
		public static object ShowMenu(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxSlideOutView.showMenu_3", dxTarget);
		}
		public static object ToggleMenuVisibility(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxSlideOutView.toggleMenuVisibility_4", dxTarget);
		}
	}
	public class DxSwitchInterop: EditorInterop
	{
		public static void Init(ElementRef dxTarget, DevExpress.Ui.DxSwitchOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxSwitch.Init", dxTarget, json);
		}
		public static new bool? GetActiveStateEnabled(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxSwitch.GetOption", dxTarget, "activeStateEnabled");
		}
		public static new void SetActiveStateEnabled(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxSwitch.SetOption", dxTarget, "activeStateEnabled", value);
		}
		public static new bool? GetFocusStateEnabled(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxSwitch.GetOption", dxTarget, "focusStateEnabled");
		}
		public static new void SetFocusStateEnabled(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxSwitch.SetOption", dxTarget, "focusStateEnabled", value);
		}
		public static new bool? GetHoverStateEnabled(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxSwitch.GetOption", dxTarget, "hoverStateEnabled");
		}
		public static new void SetHoverStateEnabled(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxSwitch.SetOption", dxTarget, "hoverStateEnabled", value);
		}
		public static string GetName(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxSwitch.GetOption", dxTarget, "name");
		}
		public static void SetName(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxSwitch.SetOption", dxTarget, "name", value);
		}
		public static string GetOffText(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxSwitch.GetOption", dxTarget, "offText");
		}
		public static void SetOffText(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxSwitch.SetOption", dxTarget, "offText", value);
		}
		public static string GetOnText(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxSwitch.GetOption", dxTarget, "onText");
		}
		public static void SetOnText(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxSwitch.SetOption", dxTarget, "onText", value);
		}
		public static new bool? GetValue(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxSwitch.GetOption", dxTarget, "value");
		}
		public static new void SetValue(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxSwitch.SetOption", dxTarget, "value", value);
		}
	}
	public class DxTabsInterop: CollectionWidgetInterop
	{
		public static void Init(ElementRef dxTarget, DevExpress.Ui.DxTabsOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTabs.Init", dxTarget, json);
		}
		public static new bool? GetFocusStateEnabled(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxTabs.GetOption", dxTarget, "focusStateEnabled");
		}
		public static new void SetFocusStateEnabled(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTabs.SetOption", dxTarget, "focusStateEnabled", value);
		}
		public static new bool? GetHoverStateEnabled(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxTabs.GetOption", dxTarget, "hoverStateEnabled");
		}
		public static new void SetHoverStateEnabled(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTabs.SetOption", dxTarget, "hoverStateEnabled", value);
		}
		public static bool? GetScrollByContent(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxTabs.GetOption", dxTarget, "scrollByContent");
		}
		public static void SetScrollByContent(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTabs.SetOption", dxTarget, "scrollByContent", value);
		}
		public static bool? GetScrollingEnabled(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxTabs.GetOption", dxTarget, "scrollingEnabled");
		}
		public static void SetScrollingEnabled(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTabs.SetOption", dxTarget, "scrollingEnabled", value);
		}
		public static new object GetSelectedItems(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTabs.GetOption", dxTarget, "selectedItems");
		}
		public static new void SetSelectedItems(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTabs.SetOption", dxTarget, "selectedItems", value);
		}
		public static string GetSelectionMode(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxTabs.GetOption", dxTarget, "selectionMode");
		}
		public static void SetSelectionMode(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTabs.SetOption", dxTarget, "selectionMode", value);
		}
		public static bool? GetShowNavButtons(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxTabs.GetOption", dxTarget, "showNavButtons");
		}
		public static void SetShowNavButtons(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTabs.SetOption", dxTarget, "showNavButtons", value);
		}
	}
	public class DxTabPanelInterop: DxMultiViewInterop
	{
		public static event EventHandler<JQueryEventArgs> TitleClick;
		public static event EventHandler<JQueryEventArgs> TitleHold;
		public static event EventHandler<JQueryEventArgs> TitleRendered;
		public static void Init(ElementRef dxTarget, DevExpress.Ui.DxTabPanelOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTabPanel.Init", dxTarget, json);
		}
		public static void OnTitleClick(string identifier)
		{
			TitleClick?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static void OnTitleHold(string identifier)
		{
			TitleHold?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static void OnTitleRendered(string identifier)
		{
			TitleRendered?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static new bool? GetAnimationEnabled(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxTabPanel.GetOption", dxTarget, "animationEnabled");
		}
		public static new void SetAnimationEnabled(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTabPanel.SetOption", dxTarget, "animationEnabled", value);
		}
		public static new bool? GetFocusStateEnabled(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxTabPanel.GetOption", dxTarget, "focusStateEnabled");
		}
		public static new void SetFocusStateEnabled(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTabPanel.SetOption", dxTarget, "focusStateEnabled", value);
		}
		public static new bool? GetHoverStateEnabled(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxTabPanel.GetOption", dxTarget, "hoverStateEnabled");
		}
		public static new void SetHoverStateEnabled(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTabPanel.SetOption", dxTarget, "hoverStateEnabled", value);
		}
		public static object GetItemTitleTemplate(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTabPanel.GetOption", dxTarget, "itemTitleTemplate");
		}
		public static void SetItemTitleTemplate(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTabPanel.SetOption", dxTarget, "itemTitleTemplate", value);
		}
		public static bool? GetScrollByContent(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxTabPanel.GetOption", dxTarget, "scrollByContent");
		}
		public static void SetScrollByContent(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTabPanel.SetOption", dxTarget, "scrollByContent", value);
		}
		public static bool? GetScrollingEnabled(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxTabPanel.GetOption", dxTarget, "scrollingEnabled");
		}
		public static void SetScrollingEnabled(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTabPanel.SetOption", dxTarget, "scrollingEnabled", value);
		}
		public static bool? GetShowNavButtons(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxTabPanel.GetOption", dxTarget, "showNavButtons");
		}
		public static void SetShowNavButtons(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTabPanel.SetOption", dxTarget, "showNavButtons", value);
		}
		public static new bool? GetSwipeEnabled(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxTabPanel.GetOption", dxTarget, "swipeEnabled");
		}
		public static new void SetSwipeEnabled(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTabPanel.SetOption", dxTarget, "swipeEnabled", value);
		}
	}
	public class DxTagBoxInterop: DxSelectBoxInterop
	{
		public static event EventHandler<JQueryEventArgs> MultiTagPreparing;
		public static event EventHandler<JQueryEventArgs> SelectAllValueChanged;
		public static event EventHandler<JQueryEventArgs> SelectionChanged;
		public static void Init(ElementRef dxTarget, DevExpress.Ui.DxTagBoxOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTagBox.Init", dxTarget, json);
		}
		public static void OnMultiTagPreparing(string identifier)
		{
			MultiTagPreparing?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static void OnSelectAllValueChanged(string identifier)
		{
			SelectAllValueChanged?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static void OnSelectionChanged(string identifier)
		{
			SelectionChanged?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static new string GetApplyValueMode(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxTagBox.GetOption", dxTarget, "applyValueMode");
		}
		public static new void SetApplyValueMode(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTagBox.SetOption", dxTarget, "applyValueMode", value);
		}
		public static bool? GetHideSelectedItems(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxTagBox.GetOption", dxTarget, "hideSelectedItems");
		}
		public static void SetHideSelectedItems(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTagBox.SetOption", dxTarget, "hideSelectedItems", value);
		}
		public static float? GetMaxDisplayedTags(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<float?>("BlazorDevExtreme.DxTagBox.GetOption", dxTarget, "maxDisplayedTags");
		}
		public static void SetMaxDisplayedTags(ElementRef dxTarget, float? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTagBox.SetOption", dxTarget, "maxDisplayedTags", value);
		}
		public static bool? GetMultiline(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxTagBox.GetOption", dxTarget, "multiline");
		}
		public static void SetMultiline(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTagBox.SetOption", dxTarget, "multiline", value);
		}
		public static string GetSelectAllMode(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxTagBox.GetOption", dxTarget, "selectAllMode");
		}
		public static void SetSelectAllMode(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTagBox.SetOption", dxTarget, "selectAllMode", value);
		}
		public static object GetSelectedItems(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTagBox.GetOption", dxTarget, "selectedItems");
		}
		public static void SetSelectedItems(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTagBox.SetOption", dxTarget, "selectedItems", value);
		}
		public static bool? GetShowMultiTagOnly(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxTagBox.GetOption", dxTarget, "showMultiTagOnly");
		}
		public static void SetShowMultiTagOnly(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTagBox.SetOption", dxTarget, "showMultiTagOnly", value);
		}
		public static object GetTagTemplate(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTagBox.GetOption", dxTarget, "tagTemplate");
		}
		public static void SetTagTemplate(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTagBox.SetOption", dxTarget, "tagTemplate", value);
		}
		public static new object GetValue(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTagBox.GetOption", dxTarget, "value");
		}
		public static new void SetValue(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTagBox.SetOption", dxTarget, "value", value);
		}
	}
	public class DxTextAreaInterop: DxTextBoxInterop
	{
		public static void Init(ElementRef dxTarget, DevExpress.Ui.DxTextAreaOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTextArea.Init", dxTarget, json);
		}
		public static bool? GetAutoResizeEnabled(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxTextArea.GetOption", dxTarget, "autoResizeEnabled");
		}
		public static void SetAutoResizeEnabled(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTextArea.SetOption", dxTarget, "autoResizeEnabled", value);
		}
		public static object GetMaxHeight(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTextArea.GetOption", dxTarget, "maxHeight");
		}
		public static void SetMaxHeight(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTextArea.SetOption", dxTarget, "maxHeight", value);
		}
		public static object GetMinHeight(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTextArea.GetOption", dxTarget, "minHeight");
		}
		public static void SetMinHeight(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTextArea.SetOption", dxTarget, "minHeight", value);
		}
		public static new bool? GetSpellcheck(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxTextArea.GetOption", dxTarget, "spellcheck");
		}
		public static new void SetSpellcheck(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTextArea.SetOption", dxTarget, "spellcheck", value);
		}
	}
	public class DxTextBoxInterop: DxTextEditorInterop
	{
		public static void Init(ElementRef dxTarget, DevExpress.Ui.DxTextBoxOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTextBox.Init", dxTarget, json);
		}
		public static object GetMaxLength(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTextBox.GetOption", dxTarget, "maxLength");
		}
		public static void SetMaxLength(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTextBox.SetOption", dxTarget, "maxLength", value);
		}
		public static string GetMode(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxTextBox.GetOption", dxTarget, "mode");
		}
		public static void SetMode(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTextBox.SetOption", dxTarget, "mode", value);
		}
		public static new string GetValue(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxTextBox.GetOption", dxTarget, "value");
		}
		public static new void SetValue(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTextBox.SetOption", dxTarget, "value", value);
		}
	}
	public class DxTileViewInterop: CollectionWidgetInterop
	{
		public static void Init(ElementRef dxTarget, DevExpress.Ui.DxTileViewOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTileView.Init", dxTarget, json);
		}
		public static new bool? GetActiveStateEnabled(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxTileView.GetOption", dxTarget, "activeStateEnabled");
		}
		public static new void SetActiveStateEnabled(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTileView.SetOption", dxTarget, "activeStateEnabled", value);
		}
		public static float? GetBaseItemHeight(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<float?>("BlazorDevExtreme.DxTileView.GetOption", dxTarget, "baseItemHeight");
		}
		public static void SetBaseItemHeight(ElementRef dxTarget, float? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTileView.SetOption", dxTarget, "baseItemHeight", value);
		}
		public static float? GetBaseItemWidth(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<float?>("BlazorDevExtreme.DxTileView.GetOption", dxTarget, "baseItemWidth");
		}
		public static void SetBaseItemWidth(ElementRef dxTarget, float? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTileView.SetOption", dxTarget, "baseItemWidth", value);
		}
		public static string GetDirection(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxTileView.GetOption", dxTarget, "direction");
		}
		public static void SetDirection(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTileView.SetOption", dxTarget, "direction", value);
		}
		public static new bool? GetFocusStateEnabled(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxTileView.GetOption", dxTarget, "focusStateEnabled");
		}
		public static new void SetFocusStateEnabled(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTileView.SetOption", dxTarget, "focusStateEnabled", value);
		}
		public static new object GetHeight(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTileView.GetOption", dxTarget, "height");
		}
		public static new void SetHeight(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTileView.SetOption", dxTarget, "height", value);
		}
		public static new bool? GetHoverStateEnabled(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxTileView.GetOption", dxTarget, "hoverStateEnabled");
		}
		public static new void SetHoverStateEnabled(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTileView.SetOption", dxTarget, "hoverStateEnabled", value);
		}
		public static float? GetItemMargin(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<float?>("BlazorDevExtreme.DxTileView.GetOption", dxTarget, "itemMargin");
		}
		public static void SetItemMargin(ElementRef dxTarget, float? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTileView.SetOption", dxTarget, "itemMargin", value);
		}
		public static bool? GetShowScrollbar(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxTileView.GetOption", dxTarget, "showScrollbar");
		}
		public static void SetShowScrollbar(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTileView.SetOption", dxTarget, "showScrollbar", value);
		}
		public static float ScrollPosition(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<float>("BlazorDevExtreme.DxTileView.scrollPosition_0", dxTarget);
		}
	}
	public class DxToastInterop: DxOverlayInterop
	{
		public static void Init(ElementRef dxTarget, DevExpress.Ui.DxToastOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxToast.Init", dxTarget, json);
		}
		public static new object GetAnimation(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxToast.GetOption", dxTarget, "animation");
		}
		public static new void SetAnimation(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxToast.SetOption", dxTarget, "animation", value);
		}
		public static new bool? GetCloseOnBackButton(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxToast.GetOption", dxTarget, "closeOnBackButton");
		}
		public static new void SetCloseOnBackButton(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxToast.SetOption", dxTarget, "closeOnBackButton", value);
		}
		public static bool? GetCloseOnClick(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxToast.GetOption", dxTarget, "closeOnClick");
		}
		public static void SetCloseOnClick(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxToast.SetOption", dxTarget, "closeOnClick", value);
		}
		public static new object GetCloseOnOutsideClick(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxToast.GetOption", dxTarget, "closeOnOutsideClick");
		}
		public static new void SetCloseOnOutsideClick(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxToast.SetOption", dxTarget, "closeOnOutsideClick", value);
		}
		public static bool? GetCloseOnSwipe(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxToast.GetOption", dxTarget, "closeOnSwipe");
		}
		public static void SetCloseOnSwipe(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxToast.SetOption", dxTarget, "closeOnSwipe", value);
		}
		public static float? GetDisplayTime(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<float?>("BlazorDevExtreme.DxToast.GetOption", dxTarget, "displayTime");
		}
		public static void SetDisplayTime(ElementRef dxTarget, float? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxToast.SetOption", dxTarget, "displayTime", value);
		}
		public static new object GetHeight(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxToast.GetOption", dxTarget, "height");
		}
		public static new void SetHeight(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxToast.SetOption", dxTarget, "height", value);
		}
		public static new object GetMaxWidth(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxToast.GetOption", dxTarget, "maxWidth");
		}
		public static new void SetMaxWidth(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxToast.SetOption", dxTarget, "maxWidth", value);
		}
		public static string GetMessage(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxToast.GetOption", dxTarget, "message");
		}
		public static void SetMessage(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxToast.SetOption", dxTarget, "message", value);
		}
		public static new object GetMinWidth(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxToast.GetOption", dxTarget, "minWidth");
		}
		public static new void SetMinWidth(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxToast.SetOption", dxTarget, "minWidth", value);
		}
		public static new object GetPosition(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxToast.GetOption", dxTarget, "position");
		}
		public static new void SetPosition(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxToast.SetOption", dxTarget, "position", value);
		}
		public static new bool? GetShading(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxToast.GetOption", dxTarget, "shading");
		}
		public static new void SetShading(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxToast.SetOption", dxTarget, "shading", value);
		}
		public static string GetType(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxToast.GetOption", dxTarget, "type");
		}
		public static void SetType(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxToast.SetOption", dxTarget, "type", value);
		}
		public static new object GetWidth(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxToast.GetOption", dxTarget, "width");
		}
		public static new void SetWidth(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxToast.SetOption", dxTarget, "width", value);
		}
	}
	public class DxToolbarInterop: CollectionWidgetInterop
	{
		public static void Init(ElementRef dxTarget, DevExpress.Ui.DxToolbarOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxToolbar.Init", dxTarget, json);
		}
		public static object GetMenuItemTemplate(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxToolbar.GetOption", dxTarget, "menuItemTemplate");
		}
		public static void SetMenuItemTemplate(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxToolbar.SetOption", dxTarget, "menuItemTemplate", value);
		}
		public static string GetRenderAs(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxToolbar.GetOption", dxTarget, "renderAs");
		}
		public static void SetRenderAs(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxToolbar.SetOption", dxTarget, "renderAs", value);
		}
	}
	public class DxTooltipInterop: DxPopoverInterop
	{
		public static void Init(ElementRef dxTarget, DevExpress.Ui.DxTooltipOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTooltip.Init", dxTarget, json);
		}
	}
	public class DxTrackBarInterop: EditorInterop
	{
		public static void Init(ElementRef dxTarget, DevExpress.Ui.DxTrackBarOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTrackBar.Init", dxTarget, json);
		}
		public static float? GetMax(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<float?>("BlazorDevExtreme.DxTrackBar.GetOption", dxTarget, "max");
		}
		public static void SetMax(ElementRef dxTarget, float? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTrackBar.SetOption", dxTarget, "max", value);
		}
		public static float? GetMin(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<float?>("BlazorDevExtreme.DxTrackBar.GetOption", dxTarget, "min");
		}
		public static void SetMin(ElementRef dxTarget, float? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTrackBar.SetOption", dxTarget, "min", value);
		}
	}
	public class DxTreeListInterop: GridBaseInterop
	{
		public static event EventHandler<JQueryEventArgs> CellClick;
		public static event EventHandler<JQueryEventArgs> CellHoverChanged;
		public static event EventHandler<JQueryEventArgs> CellPrepared;
		public static event EventHandler<JQueryEventArgs> ContextMenuPreparing;
		public static event EventHandler<JQueryEventArgs> EditingStart;
		public static event EventHandler<JQueryEventArgs> EditorPrepared;
		public static event EventHandler<JQueryEventArgs> EditorPreparing;
		public static event EventHandler<JQueryEventArgs> NodesInitialized;
		public static event EventHandler<JQueryEventArgs> RowClick;
		public static event EventHandler<JQueryEventArgs> RowPrepared;
		public static void Init(ElementRef dxTarget, DevExpress.Ui.DxTreeListOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeList.Init", dxTarget, json);
		}
		public static void OnCellClick(string identifier)
		{
			CellClick?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static void OnCellHoverChanged(string identifier)
		{
			CellHoverChanged?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static void OnCellPrepared(string identifier)
		{
			CellPrepared?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static void OnContextMenuPreparing(string identifier)
		{
			ContextMenuPreparing?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static void OnEditingStart(string identifier)
		{
			EditingStart?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static void OnEditorPrepared(string identifier)
		{
			EditorPrepared?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static void OnEditorPreparing(string identifier)
		{
			EditorPreparing?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static void OnNodesInitialized(string identifier)
		{
			NodesInitialized?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static void OnRowClick(string identifier)
		{
			RowClick?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static void OnRowPrepared(string identifier)
		{
			RowPrepared?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static bool? GetAutoExpandAll(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxTreeList.GetOption", dxTarget, "autoExpandAll");
		}
		public static void SetAutoExpandAll(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeList.SetOption", dxTarget, "autoExpandAll", value);
		}
		public static new object GetColumns(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeList.GetOption", dxTarget, "columns");
		}
		public static new void SetColumns(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeList.SetOption", dxTarget, "columns", value);
		}
		public static object GetCustomizeColumns(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeList.GetOption", dxTarget, "customizeColumns");
		}
		public static void SetCustomizeColumns(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeList.SetOption", dxTarget, "customizeColumns", value);
		}
		public static string GetDataStructure(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxTreeList.GetOption", dxTarget, "dataStructure");
		}
		public static void SetDataStructure(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeList.SetOption", dxTarget, "dataStructure", value);
		}
		public static new object GetEditing(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeList.GetOption", dxTarget, "editing");
		}
		public static new void SetEditing(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeList.SetOption", dxTarget, "editing", value);
		}
		public static object GetExpandedRowKeys(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeList.GetOption", dxTarget, "expandedRowKeys");
		}
		public static void SetExpandedRowKeys(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeList.SetOption", dxTarget, "expandedRowKeys", value);
		}
		public static bool? GetExpandNodesOnFiltering(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxTreeList.GetOption", dxTarget, "expandNodesOnFiltering");
		}
		public static void SetExpandNodesOnFiltering(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeList.SetOption", dxTarget, "expandNodesOnFiltering", value);
		}
		public static object GetHasItemsExpr(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeList.GetOption", dxTarget, "hasItemsExpr");
		}
		public static void SetHasItemsExpr(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeList.SetOption", dxTarget, "hasItemsExpr", value);
		}
		public static object GetItemsExpr(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeList.GetOption", dxTarget, "itemsExpr");
		}
		public static void SetItemsExpr(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeList.SetOption", dxTarget, "itemsExpr", value);
		}
		public static object GetKeyExpr(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeList.GetOption", dxTarget, "keyExpr");
		}
		public static void SetKeyExpr(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeList.SetOption", dxTarget, "keyExpr", value);
		}
		public static new object GetPaging(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeList.GetOption", dxTarget, "paging");
		}
		public static new void SetPaging(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeList.SetOption", dxTarget, "paging", value);
		}
		public static object GetParentIdExpr(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeList.GetOption", dxTarget, "parentIdExpr");
		}
		public static void SetParentIdExpr(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeList.SetOption", dxTarget, "parentIdExpr", value);
		}
		public static object GetRemoteOperations(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeList.GetOption", dxTarget, "remoteOperations");
		}
		public static void SetRemoteOperations(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeList.SetOption", dxTarget, "remoteOperations", value);
		}
		public static object GetRootValue(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeList.GetOption", dxTarget, "rootValue");
		}
		public static void SetRootValue(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeList.SetOption", dxTarget, "rootValue", value);
		}
		public static new object GetScrolling(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeList.GetOption", dxTarget, "scrolling");
		}
		public static new void SetScrolling(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeList.SetOption", dxTarget, "scrolling", value);
		}
		public static new object GetSelection(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeList.GetOption", dxTarget, "selection");
		}
		public static new void SetSelection(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeList.SetOption", dxTarget, "selection", value);
		}
		public static void AddColumn(ElementRef dxTarget, object columnOptions)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeList.addColumn_0", dxTarget, columnOptions);
		}
		public static void AddRow(ElementRef dxTarget)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeList.addRow_1", dxTarget);
		}
		public static void AddRow(ElementRef dxTarget, object parentId)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeList.addRow_2", dxTarget, parentId);
		}
		public static object CollapseRow(ElementRef dxTarget, object key)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeList.collapseRow_3", dxTarget, key);
		}
		public static object ExpandRow(ElementRef dxTarget, object key)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeList.expandRow_4", dxTarget, key);
		}
		public static void ForEachNode(ElementRef dxTarget, object callback)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeList.forEachNode_5", dxTarget, callback);
		}
		public static void ForEachNode(ElementRef dxTarget, object nodes, object callback)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeList.forEachNode_6", dxTarget, nodes, callback);
		}
		public static object GetNodeByKey(ElementRef dxTarget, object key)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeList.getNodeByKey_7", dxTarget, key);
		}
		public static object GetRootNode(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeList.getRootNode_8", dxTarget);
		}
		public static object GetSelectedRowKeys(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeList.getSelectedRowKeys_9", dxTarget);
		}
		public static object GetSelectedRowKeys(ElementRef dxTarget, bool leavesOnly)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeList.getSelectedRowKeys_10", dxTarget, leavesOnly);
		}
		public static object GetSelectedRowKeys(ElementRef dxTarget, string mode)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeList.getSelectedRowKeys_11", dxTarget, mode);
		}
		public static object GetSelectedRowsData(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeList.getSelectedRowsData_12", dxTarget);
		}
		public static object GetVisibleColumns(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeList.getVisibleColumns_13", dxTarget);
		}
		public static object GetVisibleColumns(ElementRef dxTarget, float headerLevel)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeList.getVisibleColumns_14", dxTarget, headerLevel);
		}
		public static object GetVisibleRows(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeList.getVisibleRows_15", dxTarget);
		}
		public static bool IsRowExpanded(ElementRef dxTarget, object key)
		{
			return RegisteredFunction.Invoke<bool>("BlazorDevExtreme.DxTreeList.isRowExpanded_16", dxTarget, key);
		}
		public static object LoadDescendants(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeList.loadDescendants_17", dxTarget);
		}
		public static object LoadDescendants(ElementRef dxTarget, object keys)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeList.loadDescendants_18", dxTarget, keys);
		}
		public static object LoadDescendants(ElementRef dxTarget, object keys, bool childrenOnly)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeList.loadDescendants_19", dxTarget, keys, childrenOnly);
		}
	}
	public class DxTreeViewInterop: HierarchicalCollectionWidgetInterop
	{
		public static event EventHandler<JQueryEventArgs> ItemClick;
		public static event EventHandler<JQueryEventArgs> ItemCollapsed;
		public static event EventHandler<JQueryEventArgs> ItemContextMenu;
		public static event EventHandler<JQueryEventArgs> ItemExpanded;
		public static event EventHandler<JQueryEventArgs> ItemHold;
		public static event EventHandler<JQueryEventArgs> ItemRendered;
		public static event EventHandler<JQueryEventArgs> ItemSelectionChanged;
		public static event EventHandler<JQueryEventArgs> SelectionChanged;
		public static void Init(ElementRef dxTarget, DevExpress.Ui.DxTreeViewOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeView.Init", dxTarget, json);
		}
		public static void OnItemClick(string identifier)
		{
			ItemClick?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static void OnItemCollapsed(string identifier)
		{
			ItemCollapsed?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static void OnItemContextMenu(string identifier)
		{
			ItemContextMenu?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static void OnItemExpanded(string identifier)
		{
			ItemExpanded?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static void OnItemHold(string identifier)
		{
			ItemHold?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static void OnItemRendered(string identifier)
		{
			ItemRendered?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static void OnItemSelectionChanged(string identifier)
		{
			ItemSelectionChanged?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static void OnSelectionChanged(string identifier)
		{
			SelectionChanged?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static bool? GetAnimationEnabled(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxTreeView.GetOption", dxTarget, "animationEnabled");
		}
		public static void SetAnimationEnabled(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeView.SetOption", dxTarget, "animationEnabled", value);
		}
		public static object GetCreateChildren(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeView.GetOption", dxTarget, "createChildren");
		}
		public static void SetCreateChildren(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeView.SetOption", dxTarget, "createChildren", value);
		}
		public static string GetDataStructure(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxTreeView.GetOption", dxTarget, "dataStructure");
		}
		public static void SetDataStructure(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeView.SetOption", dxTarget, "dataStructure", value);
		}
		public static bool? GetExpandAllEnabled(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxTreeView.GetOption", dxTarget, "expandAllEnabled");
		}
		public static void SetExpandAllEnabled(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeView.SetOption", dxTarget, "expandAllEnabled", value);
		}
		public static object GetExpandedExpr(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeView.GetOption", dxTarget, "expandedExpr");
		}
		public static void SetExpandedExpr(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeView.SetOption", dxTarget, "expandedExpr", value);
		}
		public static bool? GetExpandNodesRecursive(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxTreeView.GetOption", dxTarget, "expandNodesRecursive");
		}
		public static void SetExpandNodesRecursive(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeView.SetOption", dxTarget, "expandNodesRecursive", value);
		}
		public static object GetHasItemsExpr(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeView.GetOption", dxTarget, "hasItemsExpr");
		}
		public static void SetHasItemsExpr(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeView.SetOption", dxTarget, "hasItemsExpr", value);
		}
		public static new object GetItems(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeView.GetOption", dxTarget, "items");
		}
		public static new void SetItems(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeView.SetOption", dxTarget, "items", value);
		}
		public static object GetParentIdExpr(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeView.GetOption", dxTarget, "parentIdExpr");
		}
		public static void SetParentIdExpr(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeView.SetOption", dxTarget, "parentIdExpr", value);
		}
		public static object GetRootValue(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeView.GetOption", dxTarget, "rootValue");
		}
		public static void SetRootValue(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeView.SetOption", dxTarget, "rootValue", value);
		}
		public static string GetScrollDirection(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxTreeView.GetOption", dxTarget, "scrollDirection");
		}
		public static void SetScrollDirection(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeView.SetOption", dxTarget, "scrollDirection", value);
		}
		public static string GetSelectAllText(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxTreeView.GetOption", dxTarget, "selectAllText");
		}
		public static void SetSelectAllText(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeView.SetOption", dxTarget, "selectAllText", value);
		}
		public static bool? GetSelectByClick(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxTreeView.GetOption", dxTarget, "selectByClick");
		}
		public static void SetSelectByClick(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeView.SetOption", dxTarget, "selectByClick", value);
		}
		public static string GetSelectionMode(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxTreeView.GetOption", dxTarget, "selectionMode");
		}
		public static void SetSelectionMode(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeView.SetOption", dxTarget, "selectionMode", value);
		}
		public static bool? GetSelectNodesRecursive(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxTreeView.GetOption", dxTarget, "selectNodesRecursive");
		}
		public static void SetSelectNodesRecursive(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeView.SetOption", dxTarget, "selectNodesRecursive", value);
		}
		public static string GetShowCheckBoxesMode(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxTreeView.GetOption", dxTarget, "showCheckBoxesMode");
		}
		public static void SetShowCheckBoxesMode(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeView.SetOption", dxTarget, "showCheckBoxesMode", value);
		}
		public static bool? GetVirtualModeEnabled(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxTreeView.GetOption", dxTarget, "virtualModeEnabled");
		}
		public static void SetVirtualModeEnabled(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeView.SetOption", dxTarget, "virtualModeEnabled", value);
		}
		public static void CollapseItem(ElementRef dxTarget, object itemData)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeView.collapseItem_0", dxTarget, itemData);
		}
		public static void ExpandItem(ElementRef dxTarget, object itemData)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeView.expandItem_3", dxTarget, itemData);
		}
		public static object GetNodes(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeView.getNodes_6", dxTarget);
		}
		public static void SelectAll(ElementRef dxTarget)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeView.selectAll_7", dxTarget);
		}
		public static void SelectItem(ElementRef dxTarget, object itemData)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeView.selectItem_8", dxTarget, itemData);
		}
		public static void UnselectAll(ElementRef dxTarget)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeView.unselectAll_11", dxTarget);
		}
		public static void UnselectItem(ElementRef dxTarget, object itemData)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeView.unselectItem_12", dxTarget, itemData);
		}
		public static object UpdateDimensions(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeView.updateDimensions_15", dxTarget);
		}
	}
	public class DxValidationGroupInterop: DOMComponentInterop
	{
		public static void Init(ElementRef dxTarget, DevExpress.Ui.DxValidationGroupOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxValidationGroup.Init", dxTarget, json);
		}
		public static void Reset(ElementRef dxTarget)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxValidationGroup.reset_0", dxTarget);
		}
		public static object Validate(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxValidationGroup.validate_1", dxTarget);
		}
	}
	public class DxValidationSummaryInterop: CollectionWidgetInterop
	{
		public static void Init(ElementRef dxTarget, DevExpress.Ui.DxValidationSummaryOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxValidationSummary.Init", dxTarget, json);
		}
		public static string GetValidationGroup(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxValidationSummary.GetOption", dxTarget, "validationGroup");
		}
		public static void SetValidationGroup(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxValidationSummary.SetOption", dxTarget, "validationGroup", value);
		}
	}
	public class DxValidatorInterop: DOMComponentInterop
	{
		public static event EventHandler<JQueryEventArgs> Validated;
		public static void Init(ElementRef dxTarget, DevExpress.Ui.DxValidatorOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxValidator.Init", dxTarget, json);
		}
		public static void OnValidated(string identifier)
		{
			Validated?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static object GetAdapter(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxValidator.GetOption", dxTarget, "adapter");
		}
		public static void SetAdapter(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxValidator.SetOption", dxTarget, "adapter", value);
		}
		public static string GetName(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxValidator.GetOption", dxTarget, "name");
		}
		public static void SetName(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxValidator.SetOption", dxTarget, "name", value);
		}
		public static string GetValidationGroup(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxValidator.GetOption", dxTarget, "validationGroup");
		}
		public static void SetValidationGroup(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxValidator.SetOption", dxTarget, "validationGroup", value);
		}
		public static object GetValidationRules(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxValidator.GetOption", dxTarget, "validationRules");
		}
		public static void SetValidationRules(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxValidator.SetOption", dxTarget, "validationRules", value);
		}
		public static void Focus(ElementRef dxTarget)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxValidator.focus_0", dxTarget);
		}
		public static void Reset(ElementRef dxTarget)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxValidator.reset_1", dxTarget);
		}
		public static object Validate(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxValidator.validate_2", dxTarget);
		}
	}
	public class CollectionWidgetInterop: WidgetInterop
	{
		public static event EventHandler<JQueryEventArgs> ItemClick;
		public static event EventHandler<JQueryEventArgs> ItemContextMenu;
		public static event EventHandler<JQueryEventArgs> ItemHold;
		public static event EventHandler<JQueryEventArgs> ItemRendered;
		public static event EventHandler<JQueryEventArgs> SelectionChanged;
		public static void Init(ElementRef dxTarget, DevExpress.Ui.CollectionWidgetOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.CollectionWidget.Init", dxTarget, json);
		}
		public static void OnItemClick(string identifier)
		{
			ItemClick?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static void OnItemContextMenu(string identifier)
		{
			ItemContextMenu?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static void OnItemHold(string identifier)
		{
			ItemHold?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static void OnItemRendered(string identifier)
		{
			ItemRendered?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static void OnSelectionChanged(string identifier)
		{
			SelectionChanged?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static object GetDataSource(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.CollectionWidget.GetOption", dxTarget, "dataSource");
		}
		public static void SetDataSource(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.CollectionWidget.SetOption", dxTarget, "dataSource", value);
		}
		public static float? GetItemHoldTimeout(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<float?>("BlazorDevExtreme.CollectionWidget.GetOption", dxTarget, "itemHoldTimeout");
		}
		public static void SetItemHoldTimeout(ElementRef dxTarget, float? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.CollectionWidget.SetOption", dxTarget, "itemHoldTimeout", value);
		}
		public static object GetItems(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.CollectionWidget.GetOption", dxTarget, "items");
		}
		public static void SetItems(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.CollectionWidget.SetOption", dxTarget, "items", value);
		}
		public static object GetItemTemplate(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.CollectionWidget.GetOption", dxTarget, "itemTemplate");
		}
		public static void SetItemTemplate(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.CollectionWidget.SetOption", dxTarget, "itemTemplate", value);
		}
		public static object GetKeyExpr(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.CollectionWidget.GetOption", dxTarget, "keyExpr");
		}
		public static void SetKeyExpr(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.CollectionWidget.SetOption", dxTarget, "keyExpr", value);
		}
		public static string GetNoDataText(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.CollectionWidget.GetOption", dxTarget, "noDataText");
		}
		public static void SetNoDataText(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.CollectionWidget.SetOption", dxTarget, "noDataText", value);
		}
		public static float? GetSelectedIndex(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<float?>("BlazorDevExtreme.CollectionWidget.GetOption", dxTarget, "selectedIndex");
		}
		public static void SetSelectedIndex(ElementRef dxTarget, float? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.CollectionWidget.SetOption", dxTarget, "selectedIndex", value);
		}
		public static object GetSelectedItem(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.CollectionWidget.GetOption", dxTarget, "selectedItem");
		}
		public static void SetSelectedItem(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.CollectionWidget.SetOption", dxTarget, "selectedItem", value);
		}
		public static object GetSelectedItemKeys(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.CollectionWidget.GetOption", dxTarget, "selectedItemKeys");
		}
		public static void SetSelectedItemKeys(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.CollectionWidget.SetOption", dxTarget, "selectedItemKeys", value);
		}
		public static object GetSelectedItems(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.CollectionWidget.GetOption", dxTarget, "selectedItems");
		}
		public static void SetSelectedItems(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.CollectionWidget.SetOption", dxTarget, "selectedItems", value);
		}
		public static object GetDataSourceEx(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.CollectionWidget.getDataSource_0", dxTarget);
		}
	}
	public class DxMenuBaseInterop: HierarchicalCollectionWidgetInterop
	{
		public static void Init(ElementRef dxTarget, DevExpress.Ui.DxMenuBaseOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxMenuBase.Init", dxTarget, json);
		}
		public static new bool? GetActiveStateEnabled(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxMenuBase.GetOption", dxTarget, "activeStateEnabled");
		}
		public static new void SetActiveStateEnabled(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxMenuBase.SetOption", dxTarget, "activeStateEnabled", value);
		}
		public static object GetAnimation(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxMenuBase.GetOption", dxTarget, "animation");
		}
		public static void SetAnimation(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxMenuBase.SetOption", dxTarget, "animation", value);
		}
		public static string GetCssClass(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxMenuBase.GetOption", dxTarget, "cssClass");
		}
		public static void SetCssClass(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxMenuBase.SetOption", dxTarget, "cssClass", value);
		}
		public static new object GetItems(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxMenuBase.GetOption", dxTarget, "items");
		}
		public static new void SetItems(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxMenuBase.SetOption", dxTarget, "items", value);
		}
		public static bool? GetSelectByClick(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxMenuBase.GetOption", dxTarget, "selectByClick");
		}
		public static void SetSelectByClick(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxMenuBase.SetOption", dxTarget, "selectByClick", value);
		}
		public static string GetSelectionMode(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxMenuBase.GetOption", dxTarget, "selectionMode");
		}
		public static void SetSelectionMode(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxMenuBase.SetOption", dxTarget, "selectionMode", value);
		}
		public static object GetShowSubmenuMode(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxMenuBase.GetOption", dxTarget, "showSubmenuMode");
		}
		public static void SetShowSubmenuMode(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxMenuBase.SetOption", dxTarget, "showSubmenuMode", value);
		}
		public static void SelectItem(ElementRef dxTarget, object itemElement)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxMenuBase.selectItem_0", dxTarget, itemElement);
		}
		public static void UnselectItem(ElementRef dxTarget, object itemElement)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxMenuBase.unselectItem_1", dxTarget, itemElement);
		}
	}
	public class DxDropDownEditorInterop: DxTextBoxInterop
	{
		public static event EventHandler<JQueryEventArgs> Closed;
		public static event EventHandler<JQueryEventArgs> Opened;
		public static void Init(ElementRef dxTarget, DevExpress.Ui.DxDropDownEditorOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDropDownEditor.Init", dxTarget, json);
		}
		public static void OnClosed(string identifier)
		{
			Closed?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static void OnOpened(string identifier)
		{
			Opened?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static bool? GetAcceptCustomValue(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxDropDownEditor.GetOption", dxTarget, "acceptCustomValue");
		}
		public static void SetAcceptCustomValue(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDropDownEditor.SetOption", dxTarget, "acceptCustomValue", value);
		}
		public static new bool? GetActiveStateEnabled(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxDropDownEditor.GetOption", dxTarget, "activeStateEnabled");
		}
		public static new void SetActiveStateEnabled(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDropDownEditor.SetOption", dxTarget, "activeStateEnabled", value);
		}
		public static string GetApplyValueMode(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxDropDownEditor.GetOption", dxTarget, "applyValueMode");
		}
		public static void SetApplyValueMode(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDropDownEditor.SetOption", dxTarget, "applyValueMode", value);
		}
		public static bool? GetDeferRendering(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxDropDownEditor.GetOption", dxTarget, "deferRendering");
		}
		public static void SetDeferRendering(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDropDownEditor.SetOption", dxTarget, "deferRendering", value);
		}
		public static object GetDropDownButtonTemplate(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDropDownEditor.GetOption", dxTarget, "dropDownButtonTemplate");
		}
		public static void SetDropDownButtonTemplate(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDropDownEditor.SetOption", dxTarget, "dropDownButtonTemplate", value);
		}
		public static bool? GetOpened(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxDropDownEditor.GetOption", dxTarget, "opened");
		}
		public static void SetOpened(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDropDownEditor.SetOption", dxTarget, "opened", value);
		}
		public static new object GetValue(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDropDownEditor.GetOption", dxTarget, "value");
		}
		public static new void SetValue(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDropDownEditor.SetOption", dxTarget, "value", value);
		}
		public static void Close(ElementRef dxTarget)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDropDownEditor.close_0", dxTarget);
		}
		public static object Content(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDropDownEditor.content_1", dxTarget);
		}
		public static object Field(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDropDownEditor.field_2", dxTarget);
		}
		public static void Open(ElementRef dxTarget)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDropDownEditor.open_3", dxTarget);
		}
		public static void Reset(ElementRef dxTarget)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDropDownEditor.reset_4", dxTarget);
		}
	}
	public class DxDropDownListInterop: DxDropDownEditorInterop
	{
		public static event EventHandler<JQueryEventArgs> ItemClick;
		public static event EventHandler<JQueryEventArgs> SelectionChanged;
		public static event EventHandler<JQueryEventArgs> ValueChanged;
		public static void Init(ElementRef dxTarget, DevExpress.Ui.DxDropDownListOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDropDownList.Init", dxTarget, json);
		}
		public static void OnItemClick(string identifier)
		{
			ItemClick?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static void OnSelectionChanged(string identifier)
		{
			SelectionChanged?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static void OnValueChanged(string identifier)
		{
			ValueChanged?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static string GetDisplayValue(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxDropDownList.GetOption", dxTarget, "displayValue");
		}
		public static void SetDisplayValue(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDropDownList.SetOption", dxTarget, "displayValue", value);
		}
		public static bool? GetGrouped(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxDropDownList.GetOption", dxTarget, "grouped");
		}
		public static void SetGrouped(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDropDownList.SetOption", dxTarget, "grouped", value);
		}
		public static object GetGroupTemplate(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDropDownList.GetOption", dxTarget, "groupTemplate");
		}
		public static void SetGroupTemplate(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDropDownList.SetOption", dxTarget, "groupTemplate", value);
		}
		public static float? GetMinSearchLength(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<float?>("BlazorDevExtreme.DxDropDownList.GetOption", dxTarget, "minSearchLength");
		}
		public static void SetMinSearchLength(ElementRef dxTarget, float? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDropDownList.SetOption", dxTarget, "minSearchLength", value);
		}
		public static string GetNoDataText(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxDropDownList.GetOption", dxTarget, "noDataText");
		}
		public static void SetNoDataText(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDropDownList.SetOption", dxTarget, "noDataText", value);
		}
		public static bool? GetSearchEnabled(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxDropDownList.GetOption", dxTarget, "searchEnabled");
		}
		public static void SetSearchEnabled(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDropDownList.SetOption", dxTarget, "searchEnabled", value);
		}
		public static object GetSearchExpr(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDropDownList.GetOption", dxTarget, "searchExpr");
		}
		public static void SetSearchExpr(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDropDownList.SetOption", dxTarget, "searchExpr", value);
		}
		public static string GetSearchMode(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxDropDownList.GetOption", dxTarget, "searchMode");
		}
		public static void SetSearchMode(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDropDownList.SetOption", dxTarget, "searchMode", value);
		}
		public static float? GetSearchTimeout(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<float?>("BlazorDevExtreme.DxDropDownList.GetOption", dxTarget, "searchTimeout");
		}
		public static void SetSearchTimeout(ElementRef dxTarget, float? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDropDownList.SetOption", dxTarget, "searchTimeout", value);
		}
		public static object GetSelectedItem(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDropDownList.GetOption", dxTarget, "selectedItem");
		}
		public static void SetSelectedItem(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDropDownList.SetOption", dxTarget, "selectedItem", value);
		}
		public static bool? GetShowDataBeforeSearch(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxDropDownList.GetOption", dxTarget, "showDataBeforeSearch");
		}
		public static void SetShowDataBeforeSearch(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDropDownList.SetOption", dxTarget, "showDataBeforeSearch", value);
		}
		public static new object GetValue(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDropDownList.GetOption", dxTarget, "value");
		}
		public static new void SetValue(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDropDownList.SetOption", dxTarget, "value", value);
		}
		public static new string GetValueChangeEvent(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxDropDownList.GetOption", dxTarget, "valueChangeEvent");
		}
		public static new void SetValueChangeEvent(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDropDownList.SetOption", dxTarget, "valueChangeEvent", value);
		}
		public static object GetDataSourceEx(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDropDownList.getDataSource_0", dxTarget);
		}
	}
	public class EditorInterop: WidgetInterop
	{
		public static event EventHandler<JQueryEventArgs> ValueChanged;
		public static void Init(ElementRef dxTarget, DevExpress.Ui.EditorOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.Editor.Init", dxTarget, json);
		}
		public static void OnValueChanged(string identifier)
		{
			ValueChanged?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static bool? GetIsValid(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.Editor.GetOption", dxTarget, "isValid");
		}
		public static void SetIsValid(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.Editor.SetOption", dxTarget, "isValid", value);
		}
		public static bool? GetReadOnly(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.Editor.GetOption", dxTarget, "readOnly");
		}
		public static void SetReadOnly(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.Editor.SetOption", dxTarget, "readOnly", value);
		}
		public static object GetValidationError(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.Editor.GetOption", dxTarget, "validationError");
		}
		public static void SetValidationError(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.Editor.SetOption", dxTarget, "validationError", value);
		}
		public static string GetValidationMessageMode(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.Editor.GetOption", dxTarget, "validationMessageMode");
		}
		public static void SetValidationMessageMode(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.Editor.SetOption", dxTarget, "validationMessageMode", value);
		}
		public static object GetValue(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.Editor.GetOption", dxTarget, "value");
		}
		public static void SetValue(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.Editor.SetOption", dxTarget, "value", value);
		}
		public static void Reset(ElementRef dxTarget)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.Editor.reset_0", dxTarget);
		}
	}
	public class DataExpressionMixinInterop
	{
		public static void Init(ElementRef dxTarget, DevExpress.Ui.DataExpressionMixinOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DataExpressionMixin.Init", dxTarget, json);
		}
		public static object GetDataSource(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DataExpressionMixin.GetOption", dxTarget, "dataSource");
		}
		public static void SetDataSource(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DataExpressionMixin.SetOption", dxTarget, "dataSource", value);
		}
		public static object GetDisplayExpr(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DataExpressionMixin.GetOption", dxTarget, "displayExpr");
		}
		public static void SetDisplayExpr(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DataExpressionMixin.SetOption", dxTarget, "displayExpr", value);
		}
		public static object GetItems(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DataExpressionMixin.GetOption", dxTarget, "items");
		}
		public static void SetItems(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DataExpressionMixin.SetOption", dxTarget, "items", value);
		}
		public static object GetItemTemplate(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DataExpressionMixin.GetOption", dxTarget, "itemTemplate");
		}
		public static void SetItemTemplate(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DataExpressionMixin.SetOption", dxTarget, "itemTemplate", value);
		}
		public static object GetValue(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DataExpressionMixin.GetOption", dxTarget, "value");
		}
		public static void SetValue(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DataExpressionMixin.SetOption", dxTarget, "value", value);
		}
		public static object GetValueExpr(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DataExpressionMixin.GetOption", dxTarget, "valueExpr");
		}
		public static void SetValueExpr(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DataExpressionMixin.SetOption", dxTarget, "valueExpr", value);
		}
		public static object GetDataSourceEx(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DataExpressionMixin.getDataSource_0", dxTarget);
		}
	}
	public class HierarchicalCollectionWidgetInterop: CollectionWidgetInterop
	{
		public static void Init(ElementRef dxTarget, DevExpress.Ui.HierarchicalCollectionWidgetOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.HierarchicalCollectionWidget.Init", dxTarget, json);
		}
		public static object GetDisabledExpr(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.HierarchicalCollectionWidget.GetOption", dxTarget, "disabledExpr");
		}
		public static void SetDisabledExpr(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.HierarchicalCollectionWidget.SetOption", dxTarget, "disabledExpr", value);
		}
		public static object GetDisplayExpr(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.HierarchicalCollectionWidget.GetOption", dxTarget, "displayExpr");
		}
		public static void SetDisplayExpr(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.HierarchicalCollectionWidget.SetOption", dxTarget, "displayExpr", value);
		}
		public static new bool? GetFocusStateEnabled(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.HierarchicalCollectionWidget.GetOption", dxTarget, "focusStateEnabled");
		}
		public static new void SetFocusStateEnabled(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.HierarchicalCollectionWidget.SetOption", dxTarget, "focusStateEnabled", value);
		}
		public static new bool? GetHoverStateEnabled(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.HierarchicalCollectionWidget.GetOption", dxTarget, "hoverStateEnabled");
		}
		public static new void SetHoverStateEnabled(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.HierarchicalCollectionWidget.SetOption", dxTarget, "hoverStateEnabled", value);
		}
		public static object GetItemsExpr(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.HierarchicalCollectionWidget.GetOption", dxTarget, "itemsExpr");
		}
		public static void SetItemsExpr(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.HierarchicalCollectionWidget.SetOption", dxTarget, "itemsExpr", value);
		}
		public static new object GetKeyExpr(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.HierarchicalCollectionWidget.GetOption", dxTarget, "keyExpr");
		}
		public static new void SetKeyExpr(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.HierarchicalCollectionWidget.SetOption", dxTarget, "keyExpr", value);
		}
		public static object GetSelectedExpr(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.HierarchicalCollectionWidget.GetOption", dxTarget, "selectedExpr");
		}
		public static void SetSelectedExpr(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.HierarchicalCollectionWidget.SetOption", dxTarget, "selectedExpr", value);
		}
	}
	public class DxPivotGridSummaryCellInterop
	{
		public static object Child(ElementRef dxTarget, string direction, object fieldValue)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPivotGridSummaryCell.child_0", dxTarget, direction, fieldValue);
		}
		public static object Children(ElementRef dxTarget, string direction)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPivotGridSummaryCell.children_1", dxTarget, direction);
		}
		public static object Field(ElementRef dxTarget, string area)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPivotGridSummaryCell.field_2", dxTarget, area);
		}
		public static object GrandTotal(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPivotGridSummaryCell.grandTotal_3", dxTarget);
		}
		public static object GrandTotal(ElementRef dxTarget, string direction)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPivotGridSummaryCell.grandTotal_4", dxTarget, direction);
		}
		public static object Next(ElementRef dxTarget, string direction)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPivotGridSummaryCell.next_5", dxTarget, direction);
		}
		public static object Next(ElementRef dxTarget, string direction, bool allowCrossGroup)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPivotGridSummaryCell.next_6", dxTarget, direction, allowCrossGroup);
		}
		public static object Parent(ElementRef dxTarget, string direction)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPivotGridSummaryCell.parent_7", dxTarget, direction);
		}
		public static object Prev(ElementRef dxTarget, string direction)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPivotGridSummaryCell.prev_8", dxTarget, direction);
		}
		public static object Prev(ElementRef dxTarget, string direction, bool allowCrossGroup)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPivotGridSummaryCell.prev_9", dxTarget, direction, allowCrossGroup);
		}
		public static object Slice(ElementRef dxTarget, object field, object value)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPivotGridSummaryCell.slice_10", dxTarget, field, value);
		}
		public static object ValueEx(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPivotGridSummaryCell.value_11", dxTarget);
		}
		public static object ValueEx(ElementRef dxTarget, object field)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPivotGridSummaryCell.value_12", dxTarget, field);
		}
		public static object ValueEx(ElementRef dxTarget, object field, bool isCalculatedValue)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPivotGridSummaryCell.value_13", dxTarget, field, isCalculatedValue);
		}
		public static object ValueEx(ElementRef dxTarget, bool isCalculatedValue)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPivotGridSummaryCell.value_14", dxTarget, isCalculatedValue);
		}
	}
	public class DxScrollableInterop: DOMComponentInterop
	{
		public static event EventHandler<JQueryEventArgs> Scroll;
		public static event EventHandler<JQueryEventArgs> Updated;
		public static void Init(ElementRef dxTarget, DevExpress.Ui.DxScrollableOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxScrollable.Init", dxTarget, json);
		}
		public static void OnScroll(string identifier)
		{
			Scroll?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static void OnUpdated(string identifier)
		{
			Updated?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static bool? GetBounceEnabled(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxScrollable.GetOption", dxTarget, "bounceEnabled");
		}
		public static void SetBounceEnabled(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxScrollable.SetOption", dxTarget, "bounceEnabled", value);
		}
		public static string GetDirection(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxScrollable.GetOption", dxTarget, "direction");
		}
		public static void SetDirection(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxScrollable.SetOption", dxTarget, "direction", value);
		}
		public static bool? GetDisabled(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxScrollable.GetOption", dxTarget, "disabled");
		}
		public static void SetDisabled(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxScrollable.SetOption", dxTarget, "disabled", value);
		}
		public static bool? GetScrollByContent(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxScrollable.GetOption", dxTarget, "scrollByContent");
		}
		public static void SetScrollByContent(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxScrollable.SetOption", dxTarget, "scrollByContent", value);
		}
		public static bool? GetScrollByThumb(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxScrollable.GetOption", dxTarget, "scrollByThumb");
		}
		public static void SetScrollByThumb(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxScrollable.SetOption", dxTarget, "scrollByThumb", value);
		}
		public static string GetShowScrollbar(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxScrollable.GetOption", dxTarget, "showScrollbar");
		}
		public static void SetShowScrollbar(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxScrollable.SetOption", dxTarget, "showScrollbar", value);
		}
		public static bool? GetUseNative(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxScrollable.GetOption", dxTarget, "useNative");
		}
		public static void SetUseNative(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxScrollable.SetOption", dxTarget, "useNative", value);
		}
		public static float ClientHeight(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<float>("BlazorDevExtreme.DxScrollable.clientHeight_0", dxTarget);
		}
		public static float ClientWidth(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<float>("BlazorDevExtreme.DxScrollable.clientWidth_1", dxTarget);
		}
		public static object Content(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxScrollable.content_2", dxTarget);
		}
		public static void ScrollBy(ElementRef dxTarget, float distance)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxScrollable.scrollBy_3", dxTarget, distance);
		}
		public static void ScrollBy(ElementRef dxTarget, object distanceObject)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxScrollable.scrollBy_4", dxTarget, distanceObject);
		}
		public static float ScrollHeight(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<float>("BlazorDevExtreme.DxScrollable.scrollHeight_5", dxTarget);
		}
		public static float ScrollLeft(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<float>("BlazorDevExtreme.DxScrollable.scrollLeft_6", dxTarget);
		}
		public static object ScrollOffset(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxScrollable.scrollOffset_7", dxTarget);
		}
		public static void ScrollTo(ElementRef dxTarget, float targetLocation)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxScrollable.scrollTo_8", dxTarget, targetLocation);
		}
		public static void ScrollTo(ElementRef dxTarget, object targetLocation)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxScrollable.scrollTo_9", dxTarget, targetLocation);
		}
		public static void ScrollToElement(ElementRef dxTarget, object element)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxScrollable.scrollToElement_10", dxTarget, element);
		}
		public static float ScrollTop(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<float>("BlazorDevExtreme.DxScrollable.scrollTop_11", dxTarget);
		}
		public static float ScrollWidth(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<float>("BlazorDevExtreme.DxScrollable.scrollWidth_12", dxTarget);
		}
		public static object Update(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxScrollable.update_13", dxTarget);
		}
	}
	public class DxSliderBaseInterop: DxTrackBarInterop
	{
		public static void Init(ElementRef dxTarget, DevExpress.Ui.DxSliderBaseOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxSliderBase.Init", dxTarget, json);
		}
		public static new bool? GetActiveStateEnabled(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxSliderBase.GetOption", dxTarget, "activeStateEnabled");
		}
		public static new void SetActiveStateEnabled(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxSliderBase.SetOption", dxTarget, "activeStateEnabled", value);
		}
		public static new bool? GetFocusStateEnabled(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxSliderBase.GetOption", dxTarget, "focusStateEnabled");
		}
		public static new void SetFocusStateEnabled(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxSliderBase.SetOption", dxTarget, "focusStateEnabled", value);
		}
		public static new bool? GetHoverStateEnabled(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxSliderBase.GetOption", dxTarget, "hoverStateEnabled");
		}
		public static new void SetHoverStateEnabled(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxSliderBase.SetOption", dxTarget, "hoverStateEnabled", value);
		}
		public static float? GetKeyStep(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<float?>("BlazorDevExtreme.DxSliderBase.GetOption", dxTarget, "keyStep");
		}
		public static void SetKeyStep(ElementRef dxTarget, float? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxSliderBase.SetOption", dxTarget, "keyStep", value);
		}
		public static object GetLabel(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxSliderBase.GetOption", dxTarget, "label");
		}
		public static void SetLabel(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxSliderBase.SetOption", dxTarget, "label", value);
		}
		public static string GetName(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxSliderBase.GetOption", dxTarget, "name");
		}
		public static void SetName(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxSliderBase.SetOption", dxTarget, "name", value);
		}
		public static bool? GetShowRange(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxSliderBase.GetOption", dxTarget, "showRange");
		}
		public static void SetShowRange(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxSliderBase.SetOption", dxTarget, "showRange", value);
		}
		public static float? GetStep(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<float?>("BlazorDevExtreme.DxSliderBase.GetOption", dxTarget, "step");
		}
		public static void SetStep(ElementRef dxTarget, float? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxSliderBase.SetOption", dxTarget, "step", value);
		}
		public static object GetTooltip(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxSliderBase.GetOption", dxTarget, "tooltip");
		}
		public static void SetTooltip(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxSliderBase.SetOption", dxTarget, "tooltip", value);
		}
	}
	public class DxTextEditorInterop: EditorInterop
	{
		public static event EventHandler<JQueryEventArgs> Change;
		public static event EventHandler<JQueryEventArgs> Copy;
		public static event EventHandler<JQueryEventArgs> Cut;
		public static event EventHandler<JQueryEventArgs> EnterKey;
		public static event EventHandler<JQueryEventArgs> FocusIn;
		public static event EventHandler<JQueryEventArgs> FocusOut;
		public static event EventHandler<JQueryEventArgs> Input;
		public static event EventHandler<JQueryEventArgs> KeyDown;
		public static event EventHandler<JQueryEventArgs> KeyPress;
		public static event EventHandler<JQueryEventArgs> KeyUp;
		public static event EventHandler<JQueryEventArgs> Paste;
		public static void Init(ElementRef dxTarget, DevExpress.Ui.DxTextEditorOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTextEditor.Init", dxTarget, json);
		}
		public static void OnChange(string identifier)
		{
			Change?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static void OnCopy(string identifier)
		{
			Copy?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static void OnCut(string identifier)
		{
			Cut?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static void OnEnterKey(string identifier)
		{
			EnterKey?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static void OnFocusIn(string identifier)
		{
			FocusIn?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static void OnFocusOut(string identifier)
		{
			FocusOut?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static void OnInput(string identifier)
		{
			Input?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static void OnKeyDown(string identifier)
		{
			KeyDown?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static void OnKeyPress(string identifier)
		{
			KeyPress?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static void OnKeyUp(string identifier)
		{
			KeyUp?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static void OnPaste(string identifier)
		{
			Paste?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static new bool? GetFocusStateEnabled(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxTextEditor.GetOption", dxTarget, "focusStateEnabled");
		}
		public static new void SetFocusStateEnabled(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTextEditor.SetOption", dxTarget, "focusStateEnabled", value);
		}
		public static new bool? GetHoverStateEnabled(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxTextEditor.GetOption", dxTarget, "hoverStateEnabled");
		}
		public static new void SetHoverStateEnabled(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTextEditor.SetOption", dxTarget, "hoverStateEnabled", value);
		}
		public static object GetInputAttr(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTextEditor.GetOption", dxTarget, "inputAttr");
		}
		public static void SetInputAttr(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTextEditor.SetOption", dxTarget, "inputAttr", value);
		}
		public static string GetMask(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxTextEditor.GetOption", dxTarget, "mask");
		}
		public static void SetMask(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTextEditor.SetOption", dxTarget, "mask", value);
		}
		public static string GetMaskChar(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxTextEditor.GetOption", dxTarget, "maskChar");
		}
		public static void SetMaskChar(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTextEditor.SetOption", dxTarget, "maskChar", value);
		}
		public static string GetMaskInvalidMessage(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxTextEditor.GetOption", dxTarget, "maskInvalidMessage");
		}
		public static void SetMaskInvalidMessage(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTextEditor.SetOption", dxTarget, "maskInvalidMessage", value);
		}
		public static object GetMaskRules(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTextEditor.GetOption", dxTarget, "maskRules");
		}
		public static void SetMaskRules(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTextEditor.SetOption", dxTarget, "maskRules", value);
		}
		public static string GetName(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxTextEditor.GetOption", dxTarget, "name");
		}
		public static void SetName(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTextEditor.SetOption", dxTarget, "name", value);
		}
		public static string GetPlaceholder(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxTextEditor.GetOption", dxTarget, "placeholder");
		}
		public static void SetPlaceholder(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTextEditor.SetOption", dxTarget, "placeholder", value);
		}
		public static bool? GetShowClearButton(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxTextEditor.GetOption", dxTarget, "showClearButton");
		}
		public static void SetShowClearButton(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTextEditor.SetOption", dxTarget, "showClearButton", value);
		}
		public static string GetShowMaskMode(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxTextEditor.GetOption", dxTarget, "showMaskMode");
		}
		public static void SetShowMaskMode(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTextEditor.SetOption", dxTarget, "showMaskMode", value);
		}
		public static bool? GetSpellcheck(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxTextEditor.GetOption", dxTarget, "spellcheck");
		}
		public static void SetSpellcheck(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTextEditor.SetOption", dxTarget, "spellcheck", value);
		}
		public static string GetText(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxTextEditor.GetOption", dxTarget, "text");
		}
		public static void SetText(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTextEditor.SetOption", dxTarget, "text", value);
		}
		public static bool? GetUseMaskedValue(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxTextEditor.GetOption", dxTarget, "useMaskedValue");
		}
		public static void SetUseMaskedValue(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTextEditor.SetOption", dxTarget, "useMaskedValue", value);
		}
		public static new object GetValue(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTextEditor.GetOption", dxTarget, "value");
		}
		public static new void SetValue(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTextEditor.SetOption", dxTarget, "value", value);
		}
		public static string GetValueChangeEvent(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxTextEditor.GetOption", dxTarget, "valueChangeEvent");
		}
		public static void SetValueChangeEvent(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTextEditor.SetOption", dxTarget, "valueChangeEvent", value);
		}
		public static void Blur(ElementRef dxTarget)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTextEditor.blur_0", dxTarget);
		}
		public static void Focus(ElementRef dxTarget)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTextEditor.focus_1", dxTarget);
		}
	}
	public class SearchBoxMixinInterop
	{
		public static void Init(ElementRef dxTarget, DevExpress.Ui.SearchBoxMixinOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.SearchBoxMixin.Init", dxTarget, json);
		}
		public static object GetSearchEditorOptions(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.SearchBoxMixin.GetOption", dxTarget, "searchEditorOptions");
		}
		public static void SetSearchEditorOptions(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.SearchBoxMixin.SetOption", dxTarget, "searchEditorOptions", value);
		}
		public static bool? GetSearchEnabled(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.SearchBoxMixin.GetOption", dxTarget, "searchEnabled");
		}
		public static void SetSearchEnabled(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.SearchBoxMixin.SetOption", dxTarget, "searchEnabled", value);
		}
		public static object GetSearchExpr(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.SearchBoxMixin.GetOption", dxTarget, "searchExpr");
		}
		public static void SetSearchExpr(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.SearchBoxMixin.SetOption", dxTarget, "searchExpr", value);
		}
		public static string GetSearchMode(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.SearchBoxMixin.GetOption", dxTarget, "searchMode");
		}
		public static void SetSearchMode(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.SearchBoxMixin.SetOption", dxTarget, "searchMode", value);
		}
		public static float? GetSearchTimeout(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<float?>("BlazorDevExtreme.SearchBoxMixin.GetOption", dxTarget, "searchTimeout");
		}
		public static void SetSearchTimeout(ElementRef dxTarget, float? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.SearchBoxMixin.SetOption", dxTarget, "searchTimeout", value);
		}
		public static string GetSearchValue(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.SearchBoxMixin.GetOption", dxTarget, "searchValue");
		}
		public static void SetSearchValue(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.SearchBoxMixin.SetOption", dxTarget, "searchValue", value);
		}
	}
	public class DxTemplateInterop
	{
		public static void Init(ElementRef dxTarget, DevExpress.Ui.DxTemplateOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTemplate.Init", dxTarget, json);
		}
		public static string GetName(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxTemplate.GetOption", dxTarget, "name");
		}
		public static void SetName(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTemplate.SetOption", dxTarget, "name", value);
		}
	}
	public class WidgetInterop: DOMComponentInterop
	{
		public static event EventHandler<JQueryEventArgs> ContentReady;
		public static void Init(ElementRef dxTarget, DevExpress.Ui.WidgetOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.Widget.Init", dxTarget, json);
		}
		public static void OnContentReady(string identifier)
		{
			ContentReady?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static string GetAccessKey(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.Widget.GetOption", dxTarget, "accessKey");
		}
		public static void SetAccessKey(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.Widget.SetOption", dxTarget, "accessKey", value);
		}
		public static bool? GetActiveStateEnabled(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.Widget.GetOption", dxTarget, "activeStateEnabled");
		}
		public static void SetActiveStateEnabled(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.Widget.SetOption", dxTarget, "activeStateEnabled", value);
		}
		public static bool? GetDisabled(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.Widget.GetOption", dxTarget, "disabled");
		}
		public static void SetDisabled(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.Widget.SetOption", dxTarget, "disabled", value);
		}
		public static bool? GetFocusStateEnabled(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.Widget.GetOption", dxTarget, "focusStateEnabled");
		}
		public static void SetFocusStateEnabled(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.Widget.SetOption", dxTarget, "focusStateEnabled", value);
		}
		public static string GetHint(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.Widget.GetOption", dxTarget, "hint");
		}
		public static void SetHint(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.Widget.SetOption", dxTarget, "hint", value);
		}
		public static bool? GetHoverStateEnabled(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.Widget.GetOption", dxTarget, "hoverStateEnabled");
		}
		public static void SetHoverStateEnabled(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.Widget.SetOption", dxTarget, "hoverStateEnabled", value);
		}
		public static float? GetTabIndex(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<float?>("BlazorDevExtreme.Widget.GetOption", dxTarget, "tabIndex");
		}
		public static void SetTabIndex(ElementRef dxTarget, float? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.Widget.SetOption", dxTarget, "tabIndex", value);
		}
		public static bool? GetVisible(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.Widget.GetOption", dxTarget, "visible");
		}
		public static void SetVisible(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.Widget.SetOption", dxTarget, "visible", value);
		}
		public static void Focus(ElementRef dxTarget)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.Widget.focus_0", dxTarget);
		}
		public static void RegisterKeyHandler(ElementRef dxTarget, string key, object handler)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.Widget.registerKeyHandler_1", dxTarget, key, handler);
		}
		public static void Repaint(ElementRef dxTarget)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.Widget.repaint_2", dxTarget);
		}
	}
	public class DialogInterop
	{
		public static object Alert(string message, string title)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.Dialog.alert_0", message, title);
		}
		public static object Confirm(string message, string title)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.Dialog.confirm_1", message, title);
		}
		public static object Custom(object options)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.Dialog.custom_2", options);
		}
	}
	public class ThemesInterop
	{
		public static string Current()
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.Themes.current_0");
		}
		public static void Current(string themeName)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.Themes.current_1", themeName);
		}
		public static void Ready(object callback)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.Themes.ready_2", callback);
		}
	}
}
namespace DevExpress.Viz
{
	public class BaseWidgetInterop: DOMComponentInterop
	{
		public static event EventHandler<JQueryEventArgs> Drawn;
		public static event EventHandler<JQueryEventArgs> Exported;
		public static event EventHandler<JQueryEventArgs> Exporting;
		public static event EventHandler<JQueryEventArgs> FileSaving;
		public static event EventHandler<JQueryEventArgs> IncidentOccurred;
		public static void Init(ElementRef dxTarget, DevExpress.Viz.BaseWidgetOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.BaseWidget.Init", dxTarget, json);
		}
		public static void OnDrawn(string identifier)
		{
			Drawn?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static void OnExported(string identifier)
		{
			Exported?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static void OnExporting(string identifier)
		{
			Exporting?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static void OnFileSaving(string identifier)
		{
			FileSaving?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static void OnIncidentOccurred(string identifier)
		{
			IncidentOccurred?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static object GetExport(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.BaseWidget.GetOption", dxTarget, "export");
		}
		public static void SetExport(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.BaseWidget.SetOption", dxTarget, "export", value);
		}
		public static object GetLoadingIndicator(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.BaseWidget.GetOption", dxTarget, "loadingIndicator");
		}
		public static void SetLoadingIndicator(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.BaseWidget.SetOption", dxTarget, "loadingIndicator", value);
		}
		public static object GetMargin(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.BaseWidget.GetOption", dxTarget, "margin");
		}
		public static void SetMargin(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.BaseWidget.SetOption", dxTarget, "margin", value);
		}
		public static bool? GetPathModified(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.BaseWidget.GetOption", dxTarget, "pathModified");
		}
		public static void SetPathModified(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.BaseWidget.SetOption", dxTarget, "pathModified", value);
		}
		public static bool? GetRedrawOnResize(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.BaseWidget.GetOption", dxTarget, "redrawOnResize");
		}
		public static void SetRedrawOnResize(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.BaseWidget.SetOption", dxTarget, "redrawOnResize", value);
		}
		public static new bool? GetRtlEnabled(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.BaseWidget.GetOption", dxTarget, "rtlEnabled");
		}
		public static new void SetRtlEnabled(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.BaseWidget.SetOption", dxTarget, "rtlEnabled", value);
		}
		public static object GetSize(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.BaseWidget.GetOption", dxTarget, "size");
		}
		public static void SetSize(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.BaseWidget.SetOption", dxTarget, "size", value);
		}
		public static string GetTheme(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.BaseWidget.GetOption", dxTarget, "theme");
		}
		public static void SetTheme(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.BaseWidget.SetOption", dxTarget, "theme", value);
		}
		public static object GetTitle(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.BaseWidget.GetOption", dxTarget, "title");
		}
		public static void SetTitle(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.BaseWidget.SetOption", dxTarget, "title", value);
		}
		public static object GetTooltip(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.BaseWidget.GetOption", dxTarget, "tooltip");
		}
		public static void SetTooltip(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.BaseWidget.SetOption", dxTarget, "tooltip", value);
		}
		public static void ExportTo(ElementRef dxTarget, string fileName, string format)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.BaseWidget.exportTo_0", dxTarget, fileName, format);
		}
		public static object GetSizeEx(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.BaseWidget.getSize_1", dxTarget);
		}
		public static void HideLoadingIndicator(ElementRef dxTarget)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.BaseWidget.hideLoadingIndicator_2", dxTarget);
		}
		public static void Print(ElementRef dxTarget)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.BaseWidget.print_3", dxTarget);
		}
		public static void Render(ElementRef dxTarget)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.BaseWidget.render_4", dxTarget);
		}
		public static void ShowLoadingIndicator(ElementRef dxTarget)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.BaseWidget.showLoadingIndicator_5", dxTarget);
		}
		public static string Svg(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.BaseWidget.svg_6", dxTarget);
		}
	}
	public class DxChartInterop: BaseChartInterop
	{
		public static event EventHandler<JQueryEventArgs> ArgumentAxisClick;
		public static event EventHandler<JQueryEventArgs> LegendClick;
		public static event EventHandler<JQueryEventArgs> SeriesClick;
		public static event EventHandler<JQueryEventArgs> SeriesHoverChanged;
		public static event EventHandler<JQueryEventArgs> SeriesSelectionChanged;
		public static event EventHandler<JQueryEventArgs> ZoomEnd;
		public static event EventHandler<JQueryEventArgs> ZoomStart;
		public static void Init(ElementRef dxTarget, DevExpress.Viz.Charts.DxChartOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxChart.Init", dxTarget, json);
		}
		public static void OnArgumentAxisClick(string identifier)
		{
			ArgumentAxisClick?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static void OnLegendClick(string identifier)
		{
			LegendClick?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static void OnSeriesClick(string identifier)
		{
			SeriesClick?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static void OnSeriesHoverChanged(string identifier)
		{
			SeriesHoverChanged?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static void OnSeriesSelectionChanged(string identifier)
		{
			SeriesSelectionChanged?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static void OnZoomEnd(string identifier)
		{
			ZoomEnd?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static void OnZoomStart(string identifier)
		{
			ZoomStart?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static bool? GetAdjustOnZoom(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxChart.GetOption", dxTarget, "adjustOnZoom");
		}
		public static void SetAdjustOnZoom(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxChart.SetOption", dxTarget, "adjustOnZoom", value);
		}
		public static object GetArgumentAxis(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxChart.GetOption", dxTarget, "argumentAxis");
		}
		public static void SetArgumentAxis(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxChart.SetOption", dxTarget, "argumentAxis", value);
		}
		public static float? GetBarGroupPadding(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<float?>("BlazorDevExtreme.DxChart.GetOption", dxTarget, "barGroupPadding");
		}
		public static void SetBarGroupPadding(ElementRef dxTarget, float? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxChart.SetOption", dxTarget, "barGroupPadding", value);
		}
		public static float? GetBarGroupWidth(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<float?>("BlazorDevExtreme.DxChart.GetOption", dxTarget, "barGroupWidth");
		}
		public static void SetBarGroupWidth(ElementRef dxTarget, float? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxChart.SetOption", dxTarget, "barGroupWidth", value);
		}
		public static float? GetBarWidth(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<float?>("BlazorDevExtreme.DxChart.GetOption", dxTarget, "barWidth");
		}
		public static void SetBarWidth(ElementRef dxTarget, float? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxChart.SetOption", dxTarget, "barWidth", value);
		}
		public static object GetCommonAxisSettings(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxChart.GetOption", dxTarget, "commonAxisSettings");
		}
		public static void SetCommonAxisSettings(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxChart.SetOption", dxTarget, "commonAxisSettings", value);
		}
		public static object GetCommonPaneSettings(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxChart.GetOption", dxTarget, "commonPaneSettings");
		}
		public static void SetCommonPaneSettings(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxChart.SetOption", dxTarget, "commonPaneSettings", value);
		}
		public static object GetCommonSeriesSettings(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxChart.GetOption", dxTarget, "commonSeriesSettings");
		}
		public static void SetCommonSeriesSettings(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxChart.SetOption", dxTarget, "commonSeriesSettings", value);
		}
		public static string GetContainerBackgroundColor(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxChart.GetOption", dxTarget, "containerBackgroundColor");
		}
		public static void SetContainerBackgroundColor(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxChart.SetOption", dxTarget, "containerBackgroundColor", value);
		}
		public static object GetCrosshair(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxChart.GetOption", dxTarget, "crosshair");
		}
		public static void SetCrosshair(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxChart.SetOption", dxTarget, "crosshair", value);
		}
		public static object GetDataPrepareSettings(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxChart.GetOption", dxTarget, "dataPrepareSettings");
		}
		public static void SetDataPrepareSettings(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxChart.SetOption", dxTarget, "dataPrepareSettings", value);
		}
		public static string GetDefaultPane(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxChart.GetOption", dxTarget, "defaultPane");
		}
		public static void SetDefaultPane(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxChart.SetOption", dxTarget, "defaultPane", value);
		}
		public static bool? GetEqualBarWidth(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxChart.GetOption", dxTarget, "equalBarWidth");
		}
		public static void SetEqualBarWidth(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxChart.SetOption", dxTarget, "equalBarWidth", value);
		}
		public static new object GetLegend(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxChart.GetOption", dxTarget, "legend");
		}
		public static new void SetLegend(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxChart.SetOption", dxTarget, "legend", value);
		}
		public static float? GetMaxBubbleSize(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<float?>("BlazorDevExtreme.DxChart.GetOption", dxTarget, "maxBubbleSize");
		}
		public static void SetMaxBubbleSize(ElementRef dxTarget, float? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxChart.SetOption", dxTarget, "maxBubbleSize", value);
		}
		public static float? GetMinBubbleSize(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<float?>("BlazorDevExtreme.DxChart.GetOption", dxTarget, "minBubbleSize");
		}
		public static void SetMinBubbleSize(ElementRef dxTarget, float? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxChart.SetOption", dxTarget, "minBubbleSize", value);
		}
		public static bool? GetNegativesAsZeroes(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxChart.GetOption", dxTarget, "negativesAsZeroes");
		}
		public static void SetNegativesAsZeroes(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxChart.SetOption", dxTarget, "negativesAsZeroes", value);
		}
		public static object GetPanes(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxChart.GetOption", dxTarget, "panes");
		}
		public static void SetPanes(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxChart.SetOption", dxTarget, "panes", value);
		}
		public static string GetResolveLabelOverlapping(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxChart.GetOption", dxTarget, "resolveLabelOverlapping");
		}
		public static void SetResolveLabelOverlapping(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxChart.SetOption", dxTarget, "resolveLabelOverlapping", value);
		}
		public static bool? GetRotated(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxChart.GetOption", dxTarget, "rotated");
		}
		public static void SetRotated(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxChart.SetOption", dxTarget, "rotated", value);
		}
		public static object GetScrollBar(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxChart.GetOption", dxTarget, "scrollBar");
		}
		public static void SetScrollBar(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxChart.SetOption", dxTarget, "scrollBar", value);
		}
		public static string GetScrollingMode(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxChart.GetOption", dxTarget, "scrollingMode");
		}
		public static void SetScrollingMode(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxChart.SetOption", dxTarget, "scrollingMode", value);
		}
		public static new object GetSeries(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxChart.GetOption", dxTarget, "series");
		}
		public static new void SetSeries(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxChart.SetOption", dxTarget, "series", value);
		}
		public static string GetSeriesSelectionMode(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxChart.GetOption", dxTarget, "seriesSelectionMode");
		}
		public static void SetSeriesSelectionMode(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxChart.SetOption", dxTarget, "seriesSelectionMode", value);
		}
		public static object GetSeriesTemplate(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxChart.GetOption", dxTarget, "seriesTemplate");
		}
		public static void SetSeriesTemplate(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxChart.SetOption", dxTarget, "seriesTemplate", value);
		}
		public static bool? GetSynchronizeMultiAxes(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxChart.GetOption", dxTarget, "synchronizeMultiAxes");
		}
		public static void SetSynchronizeMultiAxes(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxChart.SetOption", dxTarget, "synchronizeMultiAxes", value);
		}
		public static new object GetTooltip(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxChart.GetOption", dxTarget, "tooltip");
		}
		public static new void SetTooltip(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxChart.SetOption", dxTarget, "tooltip", value);
		}
		public static bool? GetUseAggregation(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxChart.GetOption", dxTarget, "useAggregation");
		}
		public static void SetUseAggregation(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxChart.SetOption", dxTarget, "useAggregation", value);
		}
		public static object GetValueAxis(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxChart.GetOption", dxTarget, "valueAxis");
		}
		public static void SetValueAxis(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxChart.SetOption", dxTarget, "valueAxis", value);
		}
		public static string GetZoomingMode(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxChart.GetOption", dxTarget, "zoomingMode");
		}
		public static void SetZoomingMode(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxChart.SetOption", dxTarget, "zoomingMode", value);
		}
		public static void ZoomArgument(ElementRef dxTarget, object startValue, object endValue)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxChart.zoomArgument_0", dxTarget, startValue, endValue);
		}
	}
	public class DxPieChartInterop: BaseChartInterop
	{
		public static event EventHandler<JQueryEventArgs> LegendClick;
		public static void Init(ElementRef dxTarget, DevExpress.Viz.Charts.DxPieChartOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPieChart.Init", dxTarget, json);
		}
		public static void OnLegendClick(string identifier)
		{
			LegendClick?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static new object GetAdaptiveLayout(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPieChart.GetOption", dxTarget, "adaptiveLayout");
		}
		public static new void SetAdaptiveLayout(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPieChart.SetOption", dxTarget, "adaptiveLayout", value);
		}
		public static object GetCommonSeriesSettings(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPieChart.GetOption", dxTarget, "commonSeriesSettings");
		}
		public static void SetCommonSeriesSettings(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPieChart.SetOption", dxTarget, "commonSeriesSettings", value);
		}
		public static float? GetDiameter(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<float?>("BlazorDevExtreme.DxPieChart.GetOption", dxTarget, "diameter");
		}
		public static void SetDiameter(ElementRef dxTarget, float? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPieChart.SetOption", dxTarget, "diameter", value);
		}
		public static float? GetInnerRadius(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<float?>("BlazorDevExtreme.DxPieChart.GetOption", dxTarget, "innerRadius");
		}
		public static void SetInnerRadius(ElementRef dxTarget, float? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPieChart.SetOption", dxTarget, "innerRadius", value);
		}
		public static new object GetLegend(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPieChart.GetOption", dxTarget, "legend");
		}
		public static new void SetLegend(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPieChart.SetOption", dxTarget, "legend", value);
		}
		public static float? GetMinDiameter(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<float?>("BlazorDevExtreme.DxPieChart.GetOption", dxTarget, "minDiameter");
		}
		public static void SetMinDiameter(ElementRef dxTarget, float? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPieChart.SetOption", dxTarget, "minDiameter", value);
		}
		public static new object GetPalette(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPieChart.GetOption", dxTarget, "palette");
		}
		public static new void SetPalette(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPieChart.SetOption", dxTarget, "palette", value);
		}
		public static string GetResolveLabelOverlapping(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxPieChart.GetOption", dxTarget, "resolveLabelOverlapping");
		}
		public static void SetResolveLabelOverlapping(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPieChart.SetOption", dxTarget, "resolveLabelOverlapping", value);
		}
		public static string GetSegmentsDirection(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxPieChart.GetOption", dxTarget, "segmentsDirection");
		}
		public static void SetSegmentsDirection(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPieChart.SetOption", dxTarget, "segmentsDirection", value);
		}
		public static new object GetSeries(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPieChart.GetOption", dxTarget, "series");
		}
		public static new void SetSeries(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPieChart.SetOption", dxTarget, "series", value);
		}
		public static object GetSeriesTemplate(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPieChart.GetOption", dxTarget, "seriesTemplate");
		}
		public static void SetSeriesTemplate(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPieChart.SetOption", dxTarget, "seriesTemplate", value);
		}
		public static string GetSizeGroup(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxPieChart.GetOption", dxTarget, "sizeGroup");
		}
		public static void SetSizeGroup(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPieChart.SetOption", dxTarget, "sizeGroup", value);
		}
		public static float? GetStartAngle(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<float?>("BlazorDevExtreme.DxPieChart.GetOption", dxTarget, "startAngle");
		}
		public static void SetStartAngle(ElementRef dxTarget, float? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPieChart.SetOption", dxTarget, "startAngle", value);
		}
		public static string GetType(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxPieChart.GetOption", dxTarget, "type");
		}
		public static void SetType(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPieChart.SetOption", dxTarget, "type", value);
		}
		public static object GetSeriesEx(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPieChart.getSeries_0", dxTarget);
		}
		public static object GetSeriesByName(ElementRef dxTarget, object seriesName)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPieChart.getSeriesByName_1", dxTarget, seriesName);
		}
		public static object GetSeriesByPos(ElementRef dxTarget, float seriesIndex)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPieChart.getSeriesByPos_2", dxTarget, seriesIndex);
		}
	}
	public class DxPolarChartInterop: BaseChartInterop
	{
		public static event EventHandler<JQueryEventArgs> ArgumentAxisClick;
		public static event EventHandler<JQueryEventArgs> LegendClick;
		public static event EventHandler<JQueryEventArgs> SeriesClick;
		public static event EventHandler<JQueryEventArgs> SeriesHoverChanged;
		public static event EventHandler<JQueryEventArgs> SeriesSelectionChanged;
		public static void Init(ElementRef dxTarget, DevExpress.Viz.Charts.DxPolarChartOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPolarChart.Init", dxTarget, json);
		}
		public static void OnArgumentAxisClick(string identifier)
		{
			ArgumentAxisClick?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static void OnLegendClick(string identifier)
		{
			LegendClick?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static void OnSeriesClick(string identifier)
		{
			SeriesClick?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static void OnSeriesHoverChanged(string identifier)
		{
			SeriesHoverChanged?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static void OnSeriesSelectionChanged(string identifier)
		{
			SeriesSelectionChanged?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static new object GetAdaptiveLayout(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPolarChart.GetOption", dxTarget, "adaptiveLayout");
		}
		public static new void SetAdaptiveLayout(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPolarChart.SetOption", dxTarget, "adaptiveLayout", value);
		}
		public static object GetArgumentAxis(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPolarChart.GetOption", dxTarget, "argumentAxis");
		}
		public static void SetArgumentAxis(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPolarChart.SetOption", dxTarget, "argumentAxis", value);
		}
		public static float? GetBarGroupPadding(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<float?>("BlazorDevExtreme.DxPolarChart.GetOption", dxTarget, "barGroupPadding");
		}
		public static void SetBarGroupPadding(ElementRef dxTarget, float? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPolarChart.SetOption", dxTarget, "barGroupPadding", value);
		}
		public static float? GetBarGroupWidth(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<float?>("BlazorDevExtreme.DxPolarChart.GetOption", dxTarget, "barGroupWidth");
		}
		public static void SetBarGroupWidth(ElementRef dxTarget, float? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPolarChart.SetOption", dxTarget, "barGroupWidth", value);
		}
		public static float? GetBarWidth(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<float?>("BlazorDevExtreme.DxPolarChart.GetOption", dxTarget, "barWidth");
		}
		public static void SetBarWidth(ElementRef dxTarget, float? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPolarChart.SetOption", dxTarget, "barWidth", value);
		}
		public static object GetCommonAxisSettings(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPolarChart.GetOption", dxTarget, "commonAxisSettings");
		}
		public static void SetCommonAxisSettings(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPolarChart.SetOption", dxTarget, "commonAxisSettings", value);
		}
		public static object GetCommonSeriesSettings(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPolarChart.GetOption", dxTarget, "commonSeriesSettings");
		}
		public static void SetCommonSeriesSettings(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPolarChart.SetOption", dxTarget, "commonSeriesSettings", value);
		}
		public static string GetContainerBackgroundColor(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxPolarChart.GetOption", dxTarget, "containerBackgroundColor");
		}
		public static void SetContainerBackgroundColor(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPolarChart.SetOption", dxTarget, "containerBackgroundColor", value);
		}
		public static object GetDataPrepareSettings(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPolarChart.GetOption", dxTarget, "dataPrepareSettings");
		}
		public static void SetDataPrepareSettings(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPolarChart.SetOption", dxTarget, "dataPrepareSettings", value);
		}
		public static bool? GetEqualBarWidth(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxPolarChart.GetOption", dxTarget, "equalBarWidth");
		}
		public static void SetEqualBarWidth(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPolarChart.SetOption", dxTarget, "equalBarWidth", value);
		}
		public static new object GetLegend(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPolarChart.GetOption", dxTarget, "legend");
		}
		public static new void SetLegend(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPolarChart.SetOption", dxTarget, "legend", value);
		}
		public static bool? GetNegativesAsZeroes(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxPolarChart.GetOption", dxTarget, "negativesAsZeroes");
		}
		public static void SetNegativesAsZeroes(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPolarChart.SetOption", dxTarget, "negativesAsZeroes", value);
		}
		public static string GetResolveLabelOverlapping(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxPolarChart.GetOption", dxTarget, "resolveLabelOverlapping");
		}
		public static void SetResolveLabelOverlapping(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPolarChart.SetOption", dxTarget, "resolveLabelOverlapping", value);
		}
		public static new object GetSeries(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPolarChart.GetOption", dxTarget, "series");
		}
		public static new void SetSeries(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPolarChart.SetOption", dxTarget, "series", value);
		}
		public static string GetSeriesSelectionMode(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxPolarChart.GetOption", dxTarget, "seriesSelectionMode");
		}
		public static void SetSeriesSelectionMode(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPolarChart.SetOption", dxTarget, "seriesSelectionMode", value);
		}
		public static object GetSeriesTemplate(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPolarChart.GetOption", dxTarget, "seriesTemplate");
		}
		public static void SetSeriesTemplate(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPolarChart.SetOption", dxTarget, "seriesTemplate", value);
		}
		public static new object GetTooltip(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPolarChart.GetOption", dxTarget, "tooltip");
		}
		public static new void SetTooltip(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPolarChart.SetOption", dxTarget, "tooltip", value);
		}
		public static bool? GetUseSpiderWeb(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxPolarChart.GetOption", dxTarget, "useSpiderWeb");
		}
		public static void SetUseSpiderWeb(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPolarChart.SetOption", dxTarget, "useSpiderWeb", value);
		}
		public static object GetValueAxis(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPolarChart.GetOption", dxTarget, "valueAxis");
		}
		public static void SetValueAxis(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPolarChart.SetOption", dxTarget, "valueAxis", value);
		}
	}
	public class BaseChartInterop: BaseWidgetInterop
	{
		public static event EventHandler<JQueryEventArgs> Done;
		public static event EventHandler<JQueryEventArgs> PointClick;
		public static event EventHandler<JQueryEventArgs> PointHoverChanged;
		public static event EventHandler<JQueryEventArgs> PointSelectionChanged;
		public static event EventHandler<JQueryEventArgs> TooltipHidden;
		public static event EventHandler<JQueryEventArgs> TooltipShown;
		public static void Init(ElementRef dxTarget, DevExpress.Viz.Charts.BaseChartOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.BaseChart.Init", dxTarget, json);
		}
		public static void OnDone(string identifier)
		{
			Done?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static void OnPointClick(string identifier)
		{
			PointClick?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static void OnPointHoverChanged(string identifier)
		{
			PointHoverChanged?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static void OnPointSelectionChanged(string identifier)
		{
			PointSelectionChanged?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static void OnTooltipHidden(string identifier)
		{
			TooltipHidden?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static void OnTooltipShown(string identifier)
		{
			TooltipShown?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static object GetAdaptiveLayout(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.BaseChart.GetOption", dxTarget, "adaptiveLayout");
		}
		public static void SetAdaptiveLayout(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.BaseChart.SetOption", dxTarget, "adaptiveLayout", value);
		}
		public static object GetAnimation(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.BaseChart.GetOption", dxTarget, "animation");
		}
		public static void SetAnimation(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.BaseChart.SetOption", dxTarget, "animation", value);
		}
		public static object GetCustomizeLabel(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.BaseChart.GetOption", dxTarget, "customizeLabel");
		}
		public static void SetCustomizeLabel(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.BaseChart.SetOption", dxTarget, "customizeLabel", value);
		}
		public static object GetCustomizePoint(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.BaseChart.GetOption", dxTarget, "customizePoint");
		}
		public static void SetCustomizePoint(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.BaseChart.SetOption", dxTarget, "customizePoint", value);
		}
		public static object GetDataSource(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.BaseChart.GetOption", dxTarget, "dataSource");
		}
		public static void SetDataSource(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.BaseChart.SetOption", dxTarget, "dataSource", value);
		}
		public static object GetLegend(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.BaseChart.GetOption", dxTarget, "legend");
		}
		public static void SetLegend(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.BaseChart.SetOption", dxTarget, "legend", value);
		}
		public static object GetPalette(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.BaseChart.GetOption", dxTarget, "palette");
		}
		public static void SetPalette(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.BaseChart.SetOption", dxTarget, "palette", value);
		}
		public static string GetPaletteExtensionMode(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.BaseChart.GetOption", dxTarget, "paletteExtensionMode");
		}
		public static void SetPaletteExtensionMode(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.BaseChart.SetOption", dxTarget, "paletteExtensionMode", value);
		}
		public static string GetPointSelectionMode(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.BaseChart.GetOption", dxTarget, "pointSelectionMode");
		}
		public static void SetPointSelectionMode(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.BaseChart.SetOption", dxTarget, "pointSelectionMode", value);
		}
		public static object GetSeries(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.BaseChart.GetOption", dxTarget, "series");
		}
		public static void SetSeries(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.BaseChart.SetOption", dxTarget, "series", value);
		}
		public static new object GetTooltip(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.BaseChart.GetOption", dxTarget, "tooltip");
		}
		public static new void SetTooltip(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.BaseChart.SetOption", dxTarget, "tooltip", value);
		}
		public static void ClearSelection(ElementRef dxTarget)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.BaseChart.clearSelection_0", dxTarget);
		}
		public static object GetAllSeries(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.BaseChart.getAllSeries_1", dxTarget);
		}
		public static object GetDataSourceEx(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.BaseChart.getDataSource_2", dxTarget);
		}
		public static object GetSeriesByName(ElementRef dxTarget, object seriesName)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.BaseChart.getSeriesByName_3", dxTarget, seriesName);
		}
		public static object GetSeriesByPos(ElementRef dxTarget, float seriesIndex)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.BaseChart.getSeriesByPos_4", dxTarget, seriesIndex);
		}
		public static void HideTooltip(ElementRef dxTarget)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.BaseChart.hideTooltip_5", dxTarget);
		}
		public static void Render(ElementRef dxTarget)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.BaseChart.render_6", dxTarget);
		}
		public static void Render(ElementRef dxTarget, object renderOptions)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.BaseChart.render_7", dxTarget, renderOptions);
		}
	}
	public class DxExporterInterop: ComponentInterop
	{
		public static void Init(ElementRef dxTarget, DevExpress.Viz.DxExporterOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxExporter.Init", dxTarget, json);
		}
		public static object GetExportFormat(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxExporter.GetOption", dxTarget, "exportFormat");
		}
		public static void SetExportFormat(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxExporter.SetOption", dxTarget, "exportFormat", value);
		}
		public static string GetFileName(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxExporter.GetOption", dxTarget, "fileName");
		}
		public static void SetFileName(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxExporter.SetOption", dxTarget, "fileName", value);
		}
		public static bool? GetPrintingEnabled(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxExporter.GetOption", dxTarget, "printingEnabled");
		}
		public static void SetPrintingEnabled(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxExporter.SetOption", dxTarget, "printingEnabled", value);
		}
		public static string GetServerUrl(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxExporter.GetOption", dxTarget, "serverUrl");
		}
		public static void SetServerUrl(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxExporter.SetOption", dxTarget, "serverUrl", value);
		}
		public static bool? GetShowMenu(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxExporter.GetOption", dxTarget, "showMenu");
		}
		public static void SetShowMenu(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxExporter.SetOption", dxTarget, "showMenu", value);
		}
		public static string GetSourceContainer(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxExporter.GetOption", dxTarget, "sourceContainer");
		}
		public static void SetSourceContainer(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxExporter.SetOption", dxTarget, "sourceContainer", value);
		}
		public static void ExportTo(ElementRef dxTarget, string fileName, string format)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxExporter.exportTo_0", dxTarget, fileName, format);
		}
		public static void Print(ElementRef dxTarget)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxExporter.print_1", dxTarget);
		}
	}
	public class DxFunnelInterop: BaseWidgetInterop
	{
		public static event EventHandler<JQueryEventArgs> HoverChanged;
		public static event EventHandler<JQueryEventArgs> ItemClick;
		public static event EventHandler<JQueryEventArgs> LegendClick;
		public static event EventHandler<JQueryEventArgs> SelectionChanged;
		public static void Init(ElementRef dxTarget, DevExpress.Viz.Funnel.DxFunnelOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxFunnel.Init", dxTarget, json);
		}
		public static void OnHoverChanged(string identifier)
		{
			HoverChanged?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static void OnItemClick(string identifier)
		{
			ItemClick?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static void OnLegendClick(string identifier)
		{
			LegendClick?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static void OnSelectionChanged(string identifier)
		{
			SelectionChanged?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static object GetAdaptiveLayout(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxFunnel.GetOption", dxTarget, "adaptiveLayout");
		}
		public static void SetAdaptiveLayout(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxFunnel.SetOption", dxTarget, "adaptiveLayout", value);
		}
		public static string GetAlgorithm(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxFunnel.GetOption", dxTarget, "algorithm");
		}
		public static void SetAlgorithm(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxFunnel.SetOption", dxTarget, "algorithm", value);
		}
		public static string GetArgumentField(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxFunnel.GetOption", dxTarget, "argumentField");
		}
		public static void SetArgumentField(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxFunnel.SetOption", dxTarget, "argumentField", value);
		}
		public static string GetColorField(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxFunnel.GetOption", dxTarget, "colorField");
		}
		public static void SetColorField(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxFunnel.SetOption", dxTarget, "colorField", value);
		}
		public static object GetDataSource(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxFunnel.GetOption", dxTarget, "dataSource");
		}
		public static void SetDataSource(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxFunnel.SetOption", dxTarget, "dataSource", value);
		}
		public static bool? GetHoverEnabled(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxFunnel.GetOption", dxTarget, "hoverEnabled");
		}
		public static void SetHoverEnabled(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxFunnel.SetOption", dxTarget, "hoverEnabled", value);
		}
		public static bool? GetInverted(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxFunnel.GetOption", dxTarget, "inverted");
		}
		public static void SetInverted(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxFunnel.SetOption", dxTarget, "inverted", value);
		}
		public static object GetItem(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxFunnel.GetOption", dxTarget, "item");
		}
		public static void SetItem(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxFunnel.SetOption", dxTarget, "item", value);
		}
		public static object GetLabel(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxFunnel.GetOption", dxTarget, "label");
		}
		public static void SetLabel(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxFunnel.SetOption", dxTarget, "label", value);
		}
		public static object GetLegend(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxFunnel.GetOption", dxTarget, "legend");
		}
		public static void SetLegend(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxFunnel.SetOption", dxTarget, "legend", value);
		}
		public static float? GetNeckHeight(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<float?>("BlazorDevExtreme.DxFunnel.GetOption", dxTarget, "neckHeight");
		}
		public static void SetNeckHeight(ElementRef dxTarget, float? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxFunnel.SetOption", dxTarget, "neckHeight", value);
		}
		public static float? GetNeckWidth(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<float?>("BlazorDevExtreme.DxFunnel.GetOption", dxTarget, "neckWidth");
		}
		public static void SetNeckWidth(ElementRef dxTarget, float? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxFunnel.SetOption", dxTarget, "neckWidth", value);
		}
		public static object GetPalette(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxFunnel.GetOption", dxTarget, "palette");
		}
		public static void SetPalette(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxFunnel.SetOption", dxTarget, "palette", value);
		}
		public static string GetPaletteExtensionMode(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxFunnel.GetOption", dxTarget, "paletteExtensionMode");
		}
		public static void SetPaletteExtensionMode(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxFunnel.SetOption", dxTarget, "paletteExtensionMode", value);
		}
		public static string GetSelectionMode(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxFunnel.GetOption", dxTarget, "selectionMode");
		}
		public static void SetSelectionMode(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxFunnel.SetOption", dxTarget, "selectionMode", value);
		}
		public static bool? GetSortData(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxFunnel.GetOption", dxTarget, "sortData");
		}
		public static void SetSortData(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxFunnel.SetOption", dxTarget, "sortData", value);
		}
		public static new object GetTooltip(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxFunnel.GetOption", dxTarget, "tooltip");
		}
		public static new void SetTooltip(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxFunnel.SetOption", dxTarget, "tooltip", value);
		}
		public static string GetValueField(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxFunnel.GetOption", dxTarget, "valueField");
		}
		public static void SetValueField(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxFunnel.SetOption", dxTarget, "valueField", value);
		}
		public static void ClearSelection(ElementRef dxTarget)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxFunnel.clearSelection_0", dxTarget);
		}
		public static object GetAllItems(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxFunnel.getAllItems_1", dxTarget);
		}
		public static object GetDataSourceEx(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxFunnel.getDataSource_2", dxTarget);
		}
		public static void HideTooltip(ElementRef dxTarget)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxFunnel.hideTooltip_3", dxTarget);
		}
	}
	public class BaseGaugeInterop: BaseWidgetInterop
	{
		public static event EventHandler<JQueryEventArgs> TooltipHidden;
		public static event EventHandler<JQueryEventArgs> TooltipShown;
		public static void Init(ElementRef dxTarget, DevExpress.Viz.Gauges.BaseGaugeOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.BaseGauge.Init", dxTarget, json);
		}
		public static void OnTooltipHidden(string identifier)
		{
			TooltipHidden?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static void OnTooltipShown(string identifier)
		{
			TooltipShown?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static object GetAnimation(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.BaseGauge.GetOption", dxTarget, "animation");
		}
		public static void SetAnimation(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.BaseGauge.SetOption", dxTarget, "animation", value);
		}
		public static string GetContainerBackgroundColor(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.BaseGauge.GetOption", dxTarget, "containerBackgroundColor");
		}
		public static void SetContainerBackgroundColor(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.BaseGauge.SetOption", dxTarget, "containerBackgroundColor", value);
		}
		public static object GetRangeContainer(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.BaseGauge.GetOption", dxTarget, "rangeContainer");
		}
		public static void SetRangeContainer(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.BaseGauge.SetOption", dxTarget, "rangeContainer", value);
		}
		public static object GetScale(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.BaseGauge.GetOption", dxTarget, "scale");
		}
		public static void SetScale(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.BaseGauge.SetOption", dxTarget, "scale", value);
		}
		public static object GetSubtitle(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.BaseGauge.GetOption", dxTarget, "subtitle");
		}
		public static void SetSubtitle(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.BaseGauge.SetOption", dxTarget, "subtitle", value);
		}
		public static object GetSubvalues(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.BaseGauge.GetOption", dxTarget, "subvalues");
		}
		public static void SetSubvalues(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.BaseGauge.SetOption", dxTarget, "subvalues", value);
		}
		public static new object GetTitle(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.BaseGauge.GetOption", dxTarget, "title");
		}
		public static new void SetTitle(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.BaseGauge.SetOption", dxTarget, "title", value);
		}
		public static new object GetTooltip(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.BaseGauge.GetOption", dxTarget, "tooltip");
		}
		public static new void SetTooltip(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.BaseGauge.SetOption", dxTarget, "tooltip", value);
		}
		public static float? GetValue(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<float?>("BlazorDevExtreme.BaseGauge.GetOption", dxTarget, "value");
		}
		public static void SetValue(ElementRef dxTarget, float? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.BaseGauge.SetOption", dxTarget, "value", value);
		}
		public static object SubvaluesEx(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.BaseGauge.subvalues_0", dxTarget);
		}
		public static void SubvaluesEx(ElementRef dxTarget, object subvalues)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.BaseGauge.subvalues_1", dxTarget, subvalues);
		}
		public static float ValueEx(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<float>("BlazorDevExtreme.BaseGauge.value_2", dxTarget);
		}
		public static void ValueEx(ElementRef dxTarget, float value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.BaseGauge.value_3", dxTarget, value);
		}
	}
	public class DxCircularGaugeInterop: BaseGaugeInterop
	{
		public static void Init(ElementRef dxTarget, DevExpress.Viz.Gauges.DxCircularGaugeOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxCircularGauge.Init", dxTarget, json);
		}
		public static object GetGeometry(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxCircularGauge.GetOption", dxTarget, "geometry");
		}
		public static void SetGeometry(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxCircularGauge.SetOption", dxTarget, "geometry", value);
		}
		public static new object GetRangeContainer(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxCircularGauge.GetOption", dxTarget, "rangeContainer");
		}
		public static new void SetRangeContainer(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxCircularGauge.SetOption", dxTarget, "rangeContainer", value);
		}
		public static new object GetScale(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxCircularGauge.GetOption", dxTarget, "scale");
		}
		public static new void SetScale(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxCircularGauge.SetOption", dxTarget, "scale", value);
		}
		public static object GetSubvalueIndicator(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxCircularGauge.GetOption", dxTarget, "subvalueIndicator");
		}
		public static void SetSubvalueIndicator(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxCircularGauge.SetOption", dxTarget, "subvalueIndicator", value);
		}
		public static object GetValueIndicator(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxCircularGauge.GetOption", dxTarget, "valueIndicator");
		}
		public static void SetValueIndicator(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxCircularGauge.SetOption", dxTarget, "valueIndicator", value);
		}
	}
	public class DxLinearGaugeInterop: BaseGaugeInterop
	{
		public static void Init(ElementRef dxTarget, DevExpress.Viz.Gauges.DxLinearGaugeOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxLinearGauge.Init", dxTarget, json);
		}
		public static object GetGeometry(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxLinearGauge.GetOption", dxTarget, "geometry");
		}
		public static void SetGeometry(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxLinearGauge.SetOption", dxTarget, "geometry", value);
		}
		public static new object GetRangeContainer(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxLinearGauge.GetOption", dxTarget, "rangeContainer");
		}
		public static new void SetRangeContainer(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxLinearGauge.SetOption", dxTarget, "rangeContainer", value);
		}
		public static new object GetScale(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxLinearGauge.GetOption", dxTarget, "scale");
		}
		public static new void SetScale(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxLinearGauge.SetOption", dxTarget, "scale", value);
		}
		public static object GetSubvalueIndicator(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxLinearGauge.GetOption", dxTarget, "subvalueIndicator");
		}
		public static void SetSubvalueIndicator(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxLinearGauge.SetOption", dxTarget, "subvalueIndicator", value);
		}
		public static object GetValueIndicator(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxLinearGauge.GetOption", dxTarget, "valueIndicator");
		}
		public static void SetValueIndicator(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxLinearGauge.SetOption", dxTarget, "valueIndicator", value);
		}
	}
	public class DxBarGaugeInterop: BaseWidgetInterop
	{
		public static event EventHandler<JQueryEventArgs> TooltipHidden;
		public static event EventHandler<JQueryEventArgs> TooltipShown;
		public static void Init(ElementRef dxTarget, DevExpress.Viz.Gauges.DxBarGaugeOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxBarGauge.Init", dxTarget, json);
		}
		public static void OnTooltipHidden(string identifier)
		{
			TooltipHidden?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static void OnTooltipShown(string identifier)
		{
			TooltipShown?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static object GetAnimation(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxBarGauge.GetOption", dxTarget, "animation");
		}
		public static void SetAnimation(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxBarGauge.SetOption", dxTarget, "animation", value);
		}
		public static string GetBackgroundColor(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxBarGauge.GetOption", dxTarget, "backgroundColor");
		}
		public static void SetBackgroundColor(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxBarGauge.SetOption", dxTarget, "backgroundColor", value);
		}
		public static float? GetBarSpacing(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<float?>("BlazorDevExtreme.DxBarGauge.GetOption", dxTarget, "barSpacing");
		}
		public static void SetBarSpacing(ElementRef dxTarget, float? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxBarGauge.SetOption", dxTarget, "barSpacing", value);
		}
		public static float? GetBaseValue(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<float?>("BlazorDevExtreme.DxBarGauge.GetOption", dxTarget, "baseValue");
		}
		public static void SetBaseValue(ElementRef dxTarget, float? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxBarGauge.SetOption", dxTarget, "baseValue", value);
		}
		public static float? GetEndValue(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<float?>("BlazorDevExtreme.DxBarGauge.GetOption", dxTarget, "endValue");
		}
		public static void SetEndValue(ElementRef dxTarget, float? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxBarGauge.SetOption", dxTarget, "endValue", value);
		}
		public static object GetGeometry(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxBarGauge.GetOption", dxTarget, "geometry");
		}
		public static void SetGeometry(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxBarGauge.SetOption", dxTarget, "geometry", value);
		}
		public static object GetLabel(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxBarGauge.GetOption", dxTarget, "label");
		}
		public static void SetLabel(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxBarGauge.SetOption", dxTarget, "label", value);
		}
		public static object GetPalette(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxBarGauge.GetOption", dxTarget, "palette");
		}
		public static void SetPalette(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxBarGauge.SetOption", dxTarget, "palette", value);
		}
		public static string GetPaletteExtensionMode(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxBarGauge.GetOption", dxTarget, "paletteExtensionMode");
		}
		public static void SetPaletteExtensionMode(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxBarGauge.SetOption", dxTarget, "paletteExtensionMode", value);
		}
		public static float? GetRelativeInnerRadius(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<float?>("BlazorDevExtreme.DxBarGauge.GetOption", dxTarget, "relativeInnerRadius");
		}
		public static void SetRelativeInnerRadius(ElementRef dxTarget, float? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxBarGauge.SetOption", dxTarget, "relativeInnerRadius", value);
		}
		public static float? GetStartValue(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<float?>("BlazorDevExtreme.DxBarGauge.GetOption", dxTarget, "startValue");
		}
		public static void SetStartValue(ElementRef dxTarget, float? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxBarGauge.SetOption", dxTarget, "startValue", value);
		}
		public static object GetSubtitle(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxBarGauge.GetOption", dxTarget, "subtitle");
		}
		public static void SetSubtitle(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxBarGauge.SetOption", dxTarget, "subtitle", value);
		}
		public static new object GetTitle(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxBarGauge.GetOption", dxTarget, "title");
		}
		public static new void SetTitle(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxBarGauge.SetOption", dxTarget, "title", value);
		}
		public static new object GetTooltip(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxBarGauge.GetOption", dxTarget, "tooltip");
		}
		public static new void SetTooltip(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxBarGauge.SetOption", dxTarget, "tooltip", value);
		}
		public static object GetValues(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxBarGauge.GetOption", dxTarget, "values");
		}
		public static void SetValues(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxBarGauge.SetOption", dxTarget, "values", value);
		}
		public static object ValuesEx(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxBarGauge.values_0", dxTarget);
		}
		public static void ValuesEx(ElementRef dxTarget, object values)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxBarGauge.values_1", dxTarget, values);
		}
	}
	public class BaseSeriesObjectInterop
	{
		public static void ClearHover(ElementRef dxTarget)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.BaseSeriesObject.clearHover_0", dxTarget);
		}
		public static void ClearSelection(ElementRef dxTarget)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.BaseSeriesObject.clearSelection_1", dxTarget);
		}
		public static void DeselectPoint(ElementRef dxTarget, object point)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.BaseSeriesObject.deselectPoint_2", dxTarget, point);
		}
		public static object GetAllPoints(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.BaseSeriesObject.getAllPoints_3", dxTarget);
		}
		public static string GetColor(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.BaseSeriesObject.getColor_4", dxTarget);
		}
		public static object GetPointByPos(ElementRef dxTarget, float positionIndex)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.BaseSeriesObject.getPointByPos_5", dxTarget, positionIndex);
		}
		public static object GetPointsByArg(ElementRef dxTarget, object pointArg)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.BaseSeriesObject.getPointsByArg_6", dxTarget, pointArg);
		}
		public static object GetVisiblePoints(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.BaseSeriesObject.getVisiblePoints_7", dxTarget);
		}
		public static void Hide(ElementRef dxTarget)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.BaseSeriesObject.hide_8", dxTarget);
		}
		public static void Hover(ElementRef dxTarget)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.BaseSeriesObject.hover_9", dxTarget);
		}
		public static bool IsHovered(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool>("BlazorDevExtreme.BaseSeriesObject.isHovered_10", dxTarget);
		}
		public static bool IsSelected(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool>("BlazorDevExtreme.BaseSeriesObject.isSelected_11", dxTarget);
		}
		public static bool IsVisible(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool>("BlazorDevExtreme.BaseSeriesObject.isVisible_12", dxTarget);
		}
		public static void Select(ElementRef dxTarget)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.BaseSeriesObject.select_13", dxTarget);
		}
		public static void SelectPoint(ElementRef dxTarget, object point)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.BaseSeriesObject.selectPoint_14", dxTarget, point);
		}
		public static void Show(ElementRef dxTarget)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.BaseSeriesObject.show_15", dxTarget);
		}
	}
	public class BasePointObjectInterop
	{
		public static void ClearHover(ElementRef dxTarget)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.BasePointObject.clearHover_0", dxTarget);
		}
		public static void ClearSelection(ElementRef dxTarget)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.BasePointObject.clearSelection_1", dxTarget);
		}
		public static string GetColor(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.BasePointObject.getColor_2", dxTarget);
		}
		public static object GetLabel(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.BasePointObject.getLabel_3", dxTarget);
		}
		public static void HideTooltip(ElementRef dxTarget)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.BasePointObject.hideTooltip_4", dxTarget);
		}
		public static void Hover(ElementRef dxTarget)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.BasePointObject.hover_5", dxTarget);
		}
		public static bool IsHovered(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool>("BlazorDevExtreme.BasePointObject.isHovered_6", dxTarget);
		}
		public static bool IsSelected(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool>("BlazorDevExtreme.BasePointObject.isSelected_7", dxTarget);
		}
		public static void Select(ElementRef dxTarget)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.BasePointObject.select_8", dxTarget);
		}
		public static void ShowTooltip(ElementRef dxTarget)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.BasePointObject.showTooltip_9", dxTarget);
		}
	}
	public class BaseLabelObjectInterop
	{
		public static object GetBoundingRect(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.BaseLabelObject.getBoundingRect_0", dxTarget);
		}
		public static void Hide(ElementRef dxTarget)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.BaseLabelObject.hide_1", dxTarget);
		}
		public static void Hide(ElementRef dxTarget, bool holdInvisible)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.BaseLabelObject.hide_2", dxTarget, holdInvisible);
		}
		public static bool IsVisible(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool>("BlazorDevExtreme.BaseLabelObject.isVisible_3", dxTarget);
		}
		public static void Show(ElementRef dxTarget)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.BaseLabelObject.show_4", dxTarget);
		}
		public static void Show(ElementRef dxTarget, bool holdVisible)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.BaseLabelObject.show_5", dxTarget, holdVisible);
		}
	}
	public class ChartSeriesObjectInterop: BaseSeriesObjectInterop
	{
	}
	public class ChartPointObjectInterop: BasePointObjectInterop
	{
		public static object GetBoundingRect(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.ChartPointObject.getBoundingRect_0", dxTarget);
		}
	}
	public class DxFunnelItemInterop
	{
		public static string GetColor(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxFunnelItem.getColor_0", dxTarget);
		}
		public static void Hover(ElementRef dxTarget, bool state)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxFunnelItem.hover_1", dxTarget, state);
		}
		public static bool IsHovered(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool>("BlazorDevExtreme.DxFunnelItem.isHovered_2", dxTarget);
		}
		public static bool IsSelected(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool>("BlazorDevExtreme.DxFunnelItem.isSelected_3", dxTarget);
		}
		public static void Select(ElementRef dxTarget, bool state)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxFunnelItem.select_4", dxTarget, state);
		}
		public static void ShowTooltip(ElementRef dxTarget)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxFunnelItem.showTooltip_5", dxTarget);
		}
	}
	public class PiePointObjectInterop: BasePointObjectInterop
	{
		public static void Hide(ElementRef dxTarget)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.PiePointObject.hide_0", dxTarget);
		}
		public static void HideTooltip(ElementRef dxTarget)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.PiePointObject.hideTooltip_1", dxTarget);
		}
		public static bool IsVisible(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool>("BlazorDevExtreme.PiePointObject.isVisible_2", dxTarget);
		}
		public static void Show(ElementRef dxTarget)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.PiePointObject.show_3", dxTarget);
		}
		public static void ShowTooltip(ElementRef dxTarget)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.PiePointObject.showTooltip_4", dxTarget);
		}
	}
	public class PieChartSeriesObjectInterop: BaseSeriesObjectInterop
	{
	}
	public class PolarChartSeriesObjectInterop: BaseSeriesObjectInterop
	{
	}
	public class PolarPointObjectInterop: BasePointObjectInterop
	{
	}
	public class DxTreeMapNodeInterop
	{
		public static void Customize(ElementRef dxTarget, object options)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeMapNode.customize_0", dxTarget, options);
		}
		public static void DrillDown(ElementRef dxTarget)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeMapNode.drillDown_1", dxTarget);
		}
		public static object GetAllChildren(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeMapNode.getAllChildren_2", dxTarget);
		}
		public static object GetAllNodes(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeMapNode.getAllNodes_3", dxTarget);
		}
		public static object GetChild(ElementRef dxTarget, float index)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeMapNode.getChild_4", dxTarget, index);
		}
		public static float GetChildrenCount(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<float>("BlazorDevExtreme.DxTreeMapNode.getChildrenCount_5", dxTarget);
		}
		public static object GetParent(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeMapNode.getParent_6", dxTarget);
		}
		public static bool IsActive(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool>("BlazorDevExtreme.DxTreeMapNode.isActive_7", dxTarget);
		}
		public static bool IsHovered(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool>("BlazorDevExtreme.DxTreeMapNode.isHovered_8", dxTarget);
		}
		public static bool IsLeaf(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool>("BlazorDevExtreme.DxTreeMapNode.isLeaf_9", dxTarget);
		}
		public static bool IsSelected(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool>("BlazorDevExtreme.DxTreeMapNode.isSelected_10", dxTarget);
		}
		public static string Label(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxTreeMapNode.label_11", dxTarget);
		}
		public static void Label(ElementRef dxTarget, string label)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeMapNode.label_12", dxTarget, label);
		}
		public static void ResetCustomization(ElementRef dxTarget)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeMapNode.resetCustomization_13", dxTarget);
		}
		public static void Select(ElementRef dxTarget, bool state)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeMapNode.select_14", dxTarget, state);
		}
		public static void ShowTooltip(ElementRef dxTarget)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeMapNode.showTooltip_15", dxTarget);
		}
		public static float ValueEx(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<float>("BlazorDevExtreme.DxTreeMapNode.value_16", dxTarget);
		}
	}
	public class MapLayerInterop
	{
		public static void ClearSelection(ElementRef dxTarget)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.MapLayer.clearSelection_0", dxTarget);
		}
		public static object GetDataSourceEx(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.MapLayer.getDataSource_1", dxTarget);
		}
		public static object GetElements(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.MapLayer.getElements_2", dxTarget);
		}
	}
	public class MapLayerElementInterop
	{
		public static void ApplySettings(ElementRef dxTarget, object settings)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.MapLayerElement.applySettings_0", dxTarget, settings);
		}
		public static object Attribute(ElementRef dxTarget, string name)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.MapLayerElement.attribute_1", dxTarget, name);
		}
		public static void Attribute(ElementRef dxTarget, string name, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.MapLayerElement.attribute_2", dxTarget, name, value);
		}
		public static object Coordinates(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.MapLayerElement.coordinates_3", dxTarget);
		}
		public static bool Selected(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool>("BlazorDevExtreme.MapLayerElement.selected_4", dxTarget);
		}
		public static void Selected(ElementRef dxTarget, bool state)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.MapLayerElement.selected_5", dxTarget, state);
		}
	}
	public class AreaObjectsInterop
	{
		public static void ApplySettings(ElementRef dxTarget, object settings)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.AreaObjects.applySettings_0", dxTarget, settings);
		}
		public static object Attribute(ElementRef dxTarget, string name)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.AreaObjects.attribute_1", dxTarget, name);
		}
		public static bool Selected(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool>("BlazorDevExtreme.AreaObjects.selected_2", dxTarget);
		}
		public static void Selected(ElementRef dxTarget, bool state)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.AreaObjects.selected_3", dxTarget, state);
		}
	}
	public class MarkerObjectsInterop
	{
		public static void ApplySettings(ElementRef dxTarget, object settings)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.MarkerObjects.applySettings_0", dxTarget, settings);
		}
		public static object Attribute(ElementRef dxTarget, string name)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.MarkerObjects.attribute_1", dxTarget, name);
		}
		public static object Coordinates(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.MarkerObjects.coordinates_2", dxTarget);
		}
		public static bool Selected(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool>("BlazorDevExtreme.MarkerObjects.selected_3", dxTarget);
		}
		public static void Selected(ElementRef dxTarget, bool state)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.MarkerObjects.selected_4", dxTarget, state);
		}
	}
	public class DxRangeSelectorInterop: BaseWidgetInterop
	{
		public static event EventHandler<JQueryEventArgs> SelectedRangeChanged;
		public static event EventHandler<JQueryEventArgs> ValueChanged;
		public static void Init(ElementRef dxTarget, DevExpress.Viz.RangeSelector.DxRangeSelectorOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxRangeSelector.Init", dxTarget, json);
		}
		public static void OnSelectedRangeChanged(string identifier)
		{
			SelectedRangeChanged?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static void OnValueChanged(string identifier)
		{
			ValueChanged?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static object GetBackground(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxRangeSelector.GetOption", dxTarget, "background");
		}
		public static void SetBackground(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxRangeSelector.SetOption", dxTarget, "background", value);
		}
		public static object GetBehavior(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxRangeSelector.GetOption", dxTarget, "behavior");
		}
		public static void SetBehavior(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxRangeSelector.SetOption", dxTarget, "behavior", value);
		}
		public static object GetChart(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxRangeSelector.GetOption", dxTarget, "chart");
		}
		public static void SetChart(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxRangeSelector.SetOption", dxTarget, "chart", value);
		}
		public static string GetContainerBackgroundColor(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxRangeSelector.GetOption", dxTarget, "containerBackgroundColor");
		}
		public static void SetContainerBackgroundColor(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxRangeSelector.SetOption", dxTarget, "containerBackgroundColor", value);
		}
		public static object GetDataSource(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxRangeSelector.GetOption", dxTarget, "dataSource");
		}
		public static void SetDataSource(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxRangeSelector.SetOption", dxTarget, "dataSource", value);
		}
		public static string GetDataSourceField(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxRangeSelector.GetOption", dxTarget, "dataSourceField");
		}
		public static void SetDataSourceField(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxRangeSelector.SetOption", dxTarget, "dataSourceField", value);
		}
		public static object GetIndent(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxRangeSelector.GetOption", dxTarget, "indent");
		}
		public static void SetIndent(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxRangeSelector.SetOption", dxTarget, "indent", value);
		}
		public static object GetScale(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxRangeSelector.GetOption", dxTarget, "scale");
		}
		public static void SetScale(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxRangeSelector.SetOption", dxTarget, "scale", value);
		}
		public static object GetSelectedRange(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxRangeSelector.GetOption", dxTarget, "selectedRange");
		}
		public static void SetSelectedRange(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxRangeSelector.SetOption", dxTarget, "selectedRange", value);
		}
		public static string GetSelectedRangeColor(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxRangeSelector.GetOption", dxTarget, "selectedRangeColor");
		}
		public static void SetSelectedRangeColor(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxRangeSelector.SetOption", dxTarget, "selectedRangeColor", value);
		}
		public static object GetShutter(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxRangeSelector.GetOption", dxTarget, "shutter");
		}
		public static void SetShutter(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxRangeSelector.SetOption", dxTarget, "shutter", value);
		}
		public static object GetSliderHandle(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxRangeSelector.GetOption", dxTarget, "sliderHandle");
		}
		public static void SetSliderHandle(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxRangeSelector.SetOption", dxTarget, "sliderHandle", value);
		}
		public static object GetSliderMarker(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxRangeSelector.GetOption", dxTarget, "sliderMarker");
		}
		public static void SetSliderMarker(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxRangeSelector.SetOption", dxTarget, "sliderMarker", value);
		}
		public static object GetValue(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxRangeSelector.GetOption", dxTarget, "value");
		}
		public static void SetValue(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxRangeSelector.SetOption", dxTarget, "value", value);
		}
		public static object GetDataSourceEx(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxRangeSelector.getDataSource_0", dxTarget);
		}
		public static object GetSelectedRangeEx(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxRangeSelector.getSelectedRange_1", dxTarget);
		}
		public static object GetValueEx(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxRangeSelector.getValue_2", dxTarget);
		}
		public static void Render(ElementRef dxTarget)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxRangeSelector.render_3", dxTarget);
		}
		public static void Render(ElementRef dxTarget, bool skipChartAnimation)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxRangeSelector.render_4", dxTarget, skipChartAnimation);
		}
		public static void SetSelectedRangeEx(ElementRef dxTarget, object selectedRange)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxRangeSelector.setSelectedRange_5", dxTarget, selectedRange);
		}
		public static void SetValueEx(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxRangeSelector.setValue_6", dxTarget, value);
		}
	}
	public class BaseSparklineInterop: BaseWidgetInterop
	{
		public static event EventHandler<JQueryEventArgs> TooltipHidden;
		public static event EventHandler<JQueryEventArgs> TooltipShown;
		public static void Init(ElementRef dxTarget, DevExpress.Viz.Sparklines.BaseSparklineOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.BaseSparkline.Init", dxTarget, json);
		}
		public static void OnTooltipHidden(string identifier)
		{
			TooltipHidden?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static void OnTooltipShown(string identifier)
		{
			TooltipShown?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static new object GetTooltip(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.BaseSparkline.GetOption", dxTarget, "tooltip");
		}
		public static new void SetTooltip(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.BaseSparkline.SetOption", dxTarget, "tooltip", value);
		}
	}
	public class DxSparklineInterop: BaseSparklineInterop
	{
		public static void Init(ElementRef dxTarget, DevExpress.Viz.Sparklines.DxSparklineOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxSparkline.Init", dxTarget, json);
		}
		public static string GetArgumentField(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxSparkline.GetOption", dxTarget, "argumentField");
		}
		public static void SetArgumentField(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxSparkline.SetOption", dxTarget, "argumentField", value);
		}
		public static string GetBarNegativeColor(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxSparkline.GetOption", dxTarget, "barNegativeColor");
		}
		public static void SetBarNegativeColor(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxSparkline.SetOption", dxTarget, "barNegativeColor", value);
		}
		public static string GetBarPositiveColor(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxSparkline.GetOption", dxTarget, "barPositiveColor");
		}
		public static void SetBarPositiveColor(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxSparkline.SetOption", dxTarget, "barPositiveColor", value);
		}
		public static object GetDataSource(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxSparkline.GetOption", dxTarget, "dataSource");
		}
		public static void SetDataSource(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxSparkline.SetOption", dxTarget, "dataSource", value);
		}
		public static string GetFirstLastColor(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxSparkline.GetOption", dxTarget, "firstLastColor");
		}
		public static void SetFirstLastColor(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxSparkline.SetOption", dxTarget, "firstLastColor", value);
		}
		public static bool? GetIgnoreEmptyPoints(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxSparkline.GetOption", dxTarget, "ignoreEmptyPoints");
		}
		public static void SetIgnoreEmptyPoints(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxSparkline.SetOption", dxTarget, "ignoreEmptyPoints", value);
		}
		public static string GetLineColor(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxSparkline.GetOption", dxTarget, "lineColor");
		}
		public static void SetLineColor(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxSparkline.SetOption", dxTarget, "lineColor", value);
		}
		public static float? GetLineWidth(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<float?>("BlazorDevExtreme.DxSparkline.GetOption", dxTarget, "lineWidth");
		}
		public static void SetLineWidth(ElementRef dxTarget, float? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxSparkline.SetOption", dxTarget, "lineWidth", value);
		}
		public static string GetLossColor(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxSparkline.GetOption", dxTarget, "lossColor");
		}
		public static void SetLossColor(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxSparkline.SetOption", dxTarget, "lossColor", value);
		}
		public static string GetMaxColor(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxSparkline.GetOption", dxTarget, "maxColor");
		}
		public static void SetMaxColor(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxSparkline.SetOption", dxTarget, "maxColor", value);
		}
		public static float? GetMaxValue(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<float?>("BlazorDevExtreme.DxSparkline.GetOption", dxTarget, "maxValue");
		}
		public static void SetMaxValue(ElementRef dxTarget, float? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxSparkline.SetOption", dxTarget, "maxValue", value);
		}
		public static string GetMinColor(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxSparkline.GetOption", dxTarget, "minColor");
		}
		public static void SetMinColor(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxSparkline.SetOption", dxTarget, "minColor", value);
		}
		public static float? GetMinValue(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<float?>("BlazorDevExtreme.DxSparkline.GetOption", dxTarget, "minValue");
		}
		public static void SetMinValue(ElementRef dxTarget, float? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxSparkline.SetOption", dxTarget, "minValue", value);
		}
		public static string GetPointColor(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxSparkline.GetOption", dxTarget, "pointColor");
		}
		public static void SetPointColor(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxSparkline.SetOption", dxTarget, "pointColor", value);
		}
		public static float? GetPointSize(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<float?>("BlazorDevExtreme.DxSparkline.GetOption", dxTarget, "pointSize");
		}
		public static void SetPointSize(ElementRef dxTarget, float? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxSparkline.SetOption", dxTarget, "pointSize", value);
		}
		public static string GetPointSymbol(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxSparkline.GetOption", dxTarget, "pointSymbol");
		}
		public static void SetPointSymbol(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxSparkline.SetOption", dxTarget, "pointSymbol", value);
		}
		public static bool? GetShowFirstLast(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxSparkline.GetOption", dxTarget, "showFirstLast");
		}
		public static void SetShowFirstLast(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxSparkline.SetOption", dxTarget, "showFirstLast", value);
		}
		public static bool? GetShowMinMax(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxSparkline.GetOption", dxTarget, "showMinMax");
		}
		public static void SetShowMinMax(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxSparkline.SetOption", dxTarget, "showMinMax", value);
		}
		public static string GetType(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxSparkline.GetOption", dxTarget, "type");
		}
		public static void SetType(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxSparkline.SetOption", dxTarget, "type", value);
		}
		public static string GetValueField(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxSparkline.GetOption", dxTarget, "valueField");
		}
		public static void SetValueField(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxSparkline.SetOption", dxTarget, "valueField", value);
		}
		public static string GetWinColor(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxSparkline.GetOption", dxTarget, "winColor");
		}
		public static void SetWinColor(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxSparkline.SetOption", dxTarget, "winColor", value);
		}
		public static float? GetWinlossThreshold(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<float?>("BlazorDevExtreme.DxSparkline.GetOption", dxTarget, "winlossThreshold");
		}
		public static void SetWinlossThreshold(ElementRef dxTarget, float? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxSparkline.SetOption", dxTarget, "winlossThreshold", value);
		}
		public static object GetDataSourceEx(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxSparkline.getDataSource_0", dxTarget);
		}
	}
	public class DxBulletInterop: BaseSparklineInterop
	{
		public static void Init(ElementRef dxTarget, DevExpress.Viz.Sparklines.DxBulletOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxBullet.Init", dxTarget, json);
		}
		public static string GetColor(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxBullet.GetOption", dxTarget, "color");
		}
		public static void SetColor(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxBullet.SetOption", dxTarget, "color", value);
		}
		public static float? GetEndScaleValue(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<float?>("BlazorDevExtreme.DxBullet.GetOption", dxTarget, "endScaleValue");
		}
		public static void SetEndScaleValue(ElementRef dxTarget, float? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxBullet.SetOption", dxTarget, "endScaleValue", value);
		}
		public static bool? GetShowTarget(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxBullet.GetOption", dxTarget, "showTarget");
		}
		public static void SetShowTarget(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxBullet.SetOption", dxTarget, "showTarget", value);
		}
		public static bool? GetShowZeroLevel(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxBullet.GetOption", dxTarget, "showZeroLevel");
		}
		public static void SetShowZeroLevel(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxBullet.SetOption", dxTarget, "showZeroLevel", value);
		}
		public static float? GetStartScaleValue(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<float?>("BlazorDevExtreme.DxBullet.GetOption", dxTarget, "startScaleValue");
		}
		public static void SetStartScaleValue(ElementRef dxTarget, float? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxBullet.SetOption", dxTarget, "startScaleValue", value);
		}
		public static float? GetTarget(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<float?>("BlazorDevExtreme.DxBullet.GetOption", dxTarget, "target");
		}
		public static void SetTarget(ElementRef dxTarget, float? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxBullet.SetOption", dxTarget, "target", value);
		}
		public static string GetTargetColor(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxBullet.GetOption", dxTarget, "targetColor");
		}
		public static void SetTargetColor(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxBullet.SetOption", dxTarget, "targetColor", value);
		}
		public static float? GetTargetWidth(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<float?>("BlazorDevExtreme.DxBullet.GetOption", dxTarget, "targetWidth");
		}
		public static void SetTargetWidth(ElementRef dxTarget, float? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxBullet.SetOption", dxTarget, "targetWidth", value);
		}
		public static float? GetValue(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<float?>("BlazorDevExtreme.DxBullet.GetOption", dxTarget, "value");
		}
		public static void SetValue(ElementRef dxTarget, float? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxBullet.SetOption", dxTarget, "value", value);
		}
	}
	public class DxTreeMapInterop: BaseWidgetInterop
	{
		public static event EventHandler<JQueryEventArgs> Click;
		public static event EventHandler<JQueryEventArgs> Drill;
		public static event EventHandler<JQueryEventArgs> HoverChanged;
		public static event EventHandler<JQueryEventArgs> NodesInitialized;
		public static event EventHandler<JQueryEventArgs> NodesRendering;
		public static event EventHandler<JQueryEventArgs> SelectionChanged;
		public static void Init(ElementRef dxTarget, DevExpress.Viz.TreeMap.DxTreeMapOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeMap.Init", dxTarget, json);
		}
		public static void OnClick(string identifier)
		{
			Click?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static void OnDrill(string identifier)
		{
			Drill?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static void OnHoverChanged(string identifier)
		{
			HoverChanged?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static void OnNodesInitialized(string identifier)
		{
			NodesInitialized?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static void OnNodesRendering(string identifier)
		{
			NodesRendering?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static void OnSelectionChanged(string identifier)
		{
			SelectionChanged?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static string GetChildrenField(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxTreeMap.GetOption", dxTarget, "childrenField");
		}
		public static void SetChildrenField(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeMap.SetOption", dxTarget, "childrenField", value);
		}
		public static string GetColorField(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxTreeMap.GetOption", dxTarget, "colorField");
		}
		public static void SetColorField(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeMap.SetOption", dxTarget, "colorField", value);
		}
		public static object GetColorizer(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeMap.GetOption", dxTarget, "colorizer");
		}
		public static void SetColorizer(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeMap.SetOption", dxTarget, "colorizer", value);
		}
		public static object GetDataSource(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeMap.GetOption", dxTarget, "dataSource");
		}
		public static void SetDataSource(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeMap.SetOption", dxTarget, "dataSource", value);
		}
		public static object GetGroup(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeMap.GetOption", dxTarget, "group");
		}
		public static void SetGroup(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeMap.SetOption", dxTarget, "group", value);
		}
		public static bool? GetHoverEnabled(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxTreeMap.GetOption", dxTarget, "hoverEnabled");
		}
		public static void SetHoverEnabled(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeMap.SetOption", dxTarget, "hoverEnabled", value);
		}
		public static string GetIdField(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxTreeMap.GetOption", dxTarget, "idField");
		}
		public static void SetIdField(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeMap.SetOption", dxTarget, "idField", value);
		}
		public static bool? GetInteractWithGroup(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxTreeMap.GetOption", dxTarget, "interactWithGroup");
		}
		public static void SetInteractWithGroup(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeMap.SetOption", dxTarget, "interactWithGroup", value);
		}
		public static string GetLabelField(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxTreeMap.GetOption", dxTarget, "labelField");
		}
		public static void SetLabelField(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeMap.SetOption", dxTarget, "labelField", value);
		}
		public static object GetLayoutAlgorithm(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeMap.GetOption", dxTarget, "layoutAlgorithm");
		}
		public static void SetLayoutAlgorithm(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeMap.SetOption", dxTarget, "layoutAlgorithm", value);
		}
		public static string GetLayoutDirection(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxTreeMap.GetOption", dxTarget, "layoutDirection");
		}
		public static void SetLayoutDirection(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeMap.SetOption", dxTarget, "layoutDirection", value);
		}
		public static float? GetMaxDepth(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<float?>("BlazorDevExtreme.DxTreeMap.GetOption", dxTarget, "maxDepth");
		}
		public static void SetMaxDepth(ElementRef dxTarget, float? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeMap.SetOption", dxTarget, "maxDepth", value);
		}
		public static string GetParentField(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxTreeMap.GetOption", dxTarget, "parentField");
		}
		public static void SetParentField(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeMap.SetOption", dxTarget, "parentField", value);
		}
		public static string GetResolveLabelOverflow(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxTreeMap.GetOption", dxTarget, "resolveLabelOverflow");
		}
		public static void SetResolveLabelOverflow(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeMap.SetOption", dxTarget, "resolveLabelOverflow", value);
		}
		public static string GetSelectionMode(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxTreeMap.GetOption", dxTarget, "selectionMode");
		}
		public static void SetSelectionMode(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeMap.SetOption", dxTarget, "selectionMode", value);
		}
		public static object GetTile(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeMap.GetOption", dxTarget, "tile");
		}
		public static void SetTile(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeMap.SetOption", dxTarget, "tile", value);
		}
		public static new object GetTooltip(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeMap.GetOption", dxTarget, "tooltip");
		}
		public static new void SetTooltip(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeMap.SetOption", dxTarget, "tooltip", value);
		}
		public static string GetValueField(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxTreeMap.GetOption", dxTarget, "valueField");
		}
		public static void SetValueField(ElementRef dxTarget, string value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeMap.SetOption", dxTarget, "valueField", value);
		}
		public static void ClearSelection(ElementRef dxTarget)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeMap.clearSelection_0", dxTarget);
		}
		public static void DrillUp(ElementRef dxTarget)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeMap.drillUp_1", dxTarget);
		}
		public static object GetCurrentNode(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeMap.getCurrentNode_2", dxTarget);
		}
		public static object GetDataSourceEx(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeMap.getDataSource_3", dxTarget);
		}
		public static object GetRootNode(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeMap.getRootNode_4", dxTarget);
		}
		public static void HideTooltip(ElementRef dxTarget)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeMap.hideTooltip_5", dxTarget);
		}
		public static void ResetDrillDown(ElementRef dxTarget)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeMap.resetDrillDown_6", dxTarget);
		}
	}
	public class DxVectorMapInterop: BaseWidgetInterop
	{
		public static event EventHandler<JQueryEventArgs> AreaClick;
		public static event EventHandler<JQueryEventArgs> AreaSelectionChanged;
		public static event EventHandler<JQueryEventArgs> CenterChanged;
		public static event EventHandler<JQueryEventArgs> Click;
		public static event EventHandler<JQueryEventArgs> MarkerClick;
		public static event EventHandler<JQueryEventArgs> MarkerSelectionChanged;
		public static event EventHandler<JQueryEventArgs> SelectionChanged;
		public static event EventHandler<JQueryEventArgs> TooltipHidden;
		public static event EventHandler<JQueryEventArgs> TooltipShown;
		public static event EventHandler<JQueryEventArgs> ZoomFactorChanged;
		public static void Init(ElementRef dxTarget, DevExpress.Viz.Map.DxVectorMapOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxVectorMap.Init", dxTarget, json);
		}
		public static void OnAreaClick(string identifier)
		{
			AreaClick?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static void OnAreaSelectionChanged(string identifier)
		{
			AreaSelectionChanged?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static void OnCenterChanged(string identifier)
		{
			CenterChanged?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static void OnClick(string identifier)
		{
			Click?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static void OnMarkerClick(string identifier)
		{
			MarkerClick?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static void OnMarkerSelectionChanged(string identifier)
		{
			MarkerSelectionChanged?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static void OnSelectionChanged(string identifier)
		{
			SelectionChanged?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static void OnTooltipHidden(string identifier)
		{
			TooltipHidden?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static void OnTooltipShown(string identifier)
		{
			TooltipShown?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static void OnZoomFactorChanged(string identifier)
		{
			ZoomFactorChanged?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static object GetAreaSettings(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxVectorMap.GetOption", dxTarget, "areaSettings");
		}
		public static void SetAreaSettings(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxVectorMap.SetOption", dxTarget, "areaSettings", value);
		}
		public static object GetBackground(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxVectorMap.GetOption", dxTarget, "background");
		}
		public static void SetBackground(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxVectorMap.SetOption", dxTarget, "background", value);
		}
		public static object GetBounds(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxVectorMap.GetOption", dxTarget, "bounds");
		}
		public static void SetBounds(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxVectorMap.SetOption", dxTarget, "bounds", value);
		}
		public static object GetCenter(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxVectorMap.GetOption", dxTarget, "center");
		}
		public static void SetCenter(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxVectorMap.SetOption", dxTarget, "center", value);
		}
		public static object GetControlBar(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxVectorMap.GetOption", dxTarget, "controlBar");
		}
		public static void SetControlBar(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxVectorMap.SetOption", dxTarget, "controlBar", value);
		}
		public static object GetLayers(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxVectorMap.GetOption", dxTarget, "layers");
		}
		public static void SetLayers(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxVectorMap.SetOption", dxTarget, "layers", value);
		}
		public static object GetLegends(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxVectorMap.GetOption", dxTarget, "legends");
		}
		public static void SetLegends(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxVectorMap.SetOption", dxTarget, "legends", value);
		}
		public static object GetMapData(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxVectorMap.GetOption", dxTarget, "mapData");
		}
		public static void SetMapData(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxVectorMap.SetOption", dxTarget, "mapData", value);
		}
		public static object GetMarkers(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxVectorMap.GetOption", dxTarget, "markers");
		}
		public static void SetMarkers(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxVectorMap.SetOption", dxTarget, "markers", value);
		}
		public static object GetMarkerSettings(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxVectorMap.GetOption", dxTarget, "markerSettings");
		}
		public static void SetMarkerSettings(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxVectorMap.SetOption", dxTarget, "markerSettings", value);
		}
		public static float? GetMaxZoomFactor(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<float?>("BlazorDevExtreme.DxVectorMap.GetOption", dxTarget, "maxZoomFactor");
		}
		public static void SetMaxZoomFactor(ElementRef dxTarget, float? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxVectorMap.SetOption", dxTarget, "maxZoomFactor", value);
		}
		public static bool? GetPanningEnabled(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxVectorMap.GetOption", dxTarget, "panningEnabled");
		}
		public static void SetPanningEnabled(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxVectorMap.SetOption", dxTarget, "panningEnabled", value);
		}
		public static object GetProjection(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxVectorMap.GetOption", dxTarget, "projection");
		}
		public static void SetProjection(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxVectorMap.SetOption", dxTarget, "projection", value);
		}
		public static new object GetTooltip(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxVectorMap.GetOption", dxTarget, "tooltip");
		}
		public static new void SetTooltip(ElementRef dxTarget, object value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxVectorMap.SetOption", dxTarget, "tooltip", value);
		}
		public static bool? GetTouchEnabled(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxVectorMap.GetOption", dxTarget, "touchEnabled");
		}
		public static void SetTouchEnabled(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxVectorMap.SetOption", dxTarget, "touchEnabled", value);
		}
		public static bool? GetWheelEnabled(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxVectorMap.GetOption", dxTarget, "wheelEnabled");
		}
		public static void SetWheelEnabled(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxVectorMap.SetOption", dxTarget, "wheelEnabled", value);
		}
		public static float? GetZoomFactor(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<float?>("BlazorDevExtreme.DxVectorMap.GetOption", dxTarget, "zoomFactor");
		}
		public static void SetZoomFactor(ElementRef dxTarget, float? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxVectorMap.SetOption", dxTarget, "zoomFactor", value);
		}
		public static bool? GetZoomingEnabled(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxVectorMap.GetOption", dxTarget, "zoomingEnabled");
		}
		public static void SetZoomingEnabled(ElementRef dxTarget, bool? value)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxVectorMap.SetOption", dxTarget, "zoomingEnabled", value);
		}
		public static object CenterEx(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxVectorMap.center_0", dxTarget);
		}
		public static void CenterEx(ElementRef dxTarget, object centerCoordinates)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxVectorMap.center_1", dxTarget, centerCoordinates);
		}
		public static void ClearAreaSelection(ElementRef dxTarget)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxVectorMap.clearAreaSelection_2", dxTarget);
		}
		public static void ClearMarkerSelection(ElementRef dxTarget)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxVectorMap.clearMarkerSelection_3", dxTarget);
		}
		public static void ClearSelection(ElementRef dxTarget)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxVectorMap.clearSelection_4", dxTarget);
		}
		public static object ConvertCoordinates(ElementRef dxTarget, float x, float y)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxVectorMap.convertCoordinates_5", dxTarget, x, y);
		}
		public static object GetAreas(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxVectorMap.getAreas_6", dxTarget);
		}
		public static object GetLayerByIndex(ElementRef dxTarget, float index)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxVectorMap.getLayerByIndex_7", dxTarget, index);
		}
		public static object GetLayerByName(ElementRef dxTarget, string name)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxVectorMap.getLayerByName_8", dxTarget, name);
		}
		public static object GetLayersEx(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxVectorMap.getLayers_9", dxTarget);
		}
		public static object GetMarkersEx(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxVectorMap.getMarkers_10", dxTarget);
		}
		public static object Viewport(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxVectorMap.viewport_11", dxTarget);
		}
		public static void Viewport(ElementRef dxTarget, object viewportCoordinates)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxVectorMap.viewport_12", dxTarget, viewportCoordinates);
		}
		public static float ZoomFactorEx(ElementRef dxTarget)
		{
			return RegisteredFunction.Invoke<float>("BlazorDevExtreme.DxVectorMap.zoomFactor_13", dxTarget);
		}
		public static void ZoomFactorEx(ElementRef dxTarget, float zoomFactor)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxVectorMap.zoomFactor_14", dxTarget, zoomFactor);
		}
	}
	public class CoreInterop
	{
		public static void CurrentPalette(string paletteName)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.Core.currentPalette_0", paletteName);
		}
		public static void CurrentTheme(string platform, string colorScheme)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.Core.currentTheme_1", platform, colorScheme);
		}
		public static void CurrentTheme(string theme)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.Core.currentTheme_2", theme);
		}
		public static object GetPalette(string paletteName)
		{
			return RegisteredFunction.Invoke<object>("BlazorDevExtreme.Core.getPalette_3", paletteName);
		}
		public static void RegisterPalette(string paletteName, object palette)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.Core.registerPalette_4", paletteName, palette);
		}
		public static void RegisterTheme(object customTheme, string baseTheme)
		{
			RegisteredFunction.Invoke<object>("BlazorDevExtreme.Core.registerTheme_5", customTheme, baseTheme);
		}
	}
}
