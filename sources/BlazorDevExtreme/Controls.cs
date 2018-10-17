using System;
using System.Threading.Tasks;
using Microsoft.JSInterop;
using Microsoft.AspNetCore.Blazor;
using BlazorDevExtreme;

namespace DevExpress
{
	public class DataHelperMixinInterop
	{
		public static object GetDataSourceEx(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DataHelperMixin_getDataSource_0", dxTarget);
		}
	}
	public class DxEventInterop
	{
		public static bool IsDefaultPrevented(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool>("BlazorDevExtreme_DxEvent_isDefaultPrevented_0", dxTarget);
		}
		public static bool IsImmediatePropagationStopped(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool>("BlazorDevExtreme_DxEvent_isImmediatePropagationStopped_1", dxTarget);
		}
		public static bool IsPropagationStopped(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool>("BlazorDevExtreme_DxEvent_isPropagationStopped_2", dxTarget);
		}
		public static void PreventDefault(ElementRef dxTarget)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxEvent_preventDefault_3", dxTarget);
		}
		public static void StopImmediatePropagation(ElementRef dxTarget)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxEvent_stopImmediatePropagation_4", dxTarget);
		}
		public static void StopPropagation(ElementRef dxTarget)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxEvent_stopPropagation_5", dxTarget);
		}
	}
	public class LocalizationInterop
	{
		public static void LoadMessages(object messages)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_Localization_loadMessages_0", messages);
		}
		public static string Locale()
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_Localization_locale_1");
		}
		public static void Locale(string locale)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_Localization_locale_2", locale);
		}
	}
	public class AnimationPresetsInterop
	{
		public static void ApplyChanges(ElementRef dxTarget)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_AnimationPresets_applyChanges_0", dxTarget);
		}
		public static void Clear(ElementRef dxTarget)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_AnimationPresets_clear_1", dxTarget);
		}
		public static void Clear(ElementRef dxTarget, string name)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_AnimationPresets_clear_2", dxTarget, name);
		}
		public static object GetPreset(ElementRef dxTarget, string name)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_AnimationPresets_getPreset_3", dxTarget, name);
		}
		public static void RegisterDefaultPresets(ElementRef dxTarget)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_AnimationPresets_registerDefaultPresets_4", dxTarget);
		}
		public static void RegisterPreset(ElementRef dxTarget, string name, object config)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_AnimationPresets_registerPreset_5", dxTarget, name, config);
		}
		public static void ResetToDefaults(ElementRef dxTarget)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_AnimationPresets_resetToDefaults_6", dxTarget);
		}
	}
	public class TransitionExecutorInterop
	{
		public static void Enter(ElementRef dxTarget, object elements, object animation)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_TransitionExecutor_enter_0", dxTarget, elements, animation);
		}
		public static void Leave(ElementRef dxTarget, object elements, object animation)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_TransitionExecutor_leave_1", dxTarget, elements, animation);
		}
		public static void Reset(ElementRef dxTarget)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_TransitionExecutor_reset_2", dxTarget);
		}
		public static object Start(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_TransitionExecutor_start_3", dxTarget);
		}
		public static void Stop(ElementRef dxTarget)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_TransitionExecutor_stop_4", dxTarget);
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
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_Component_Init", dxTarget, json);
		}
		[JSInvokable("DevExpress.ComponentInterop.OnDisposing")]
		public static void OnDisposing(string identifier)
		{
			Disposing?.Invoke(null, new JQueryEventArgs(identifier));
		}
		[JSInvokable("DevExpress.ComponentInterop.OnInitialized")]
		public static void OnInitialized(string identifier)
		{
			Initialized?.Invoke(null, new JQueryEventArgs(identifier));
		}
		[JSInvokable("DevExpress.ComponentInterop.OnOptionChanged")]
		public static void OnOptionChanged(string identifier)
		{
			OptionChanged?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static void BeginUpdate(ElementRef dxTarget)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_Component_beginUpdate_0", dxTarget);
		}
		public static void EndUpdate(ElementRef dxTarget)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_Component_endUpdate_1", dxTarget);
		}
		public static object Instance(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_Component_instance_2", dxTarget);
		}
		public static object Off(ElementRef dxTarget, string eventName)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_Component_off_3", dxTarget, eventName);
		}
		public static object Off(ElementRef dxTarget, string eventName, object eventHandler)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_Component_off_4", dxTarget, eventName, eventHandler);
		}
		public static object On(ElementRef dxTarget, string eventName, object eventHandler)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_Component_on_5", dxTarget, eventName, eventHandler);
		}
		public static object On(ElementRef dxTarget, object events)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_Component_on_6", dxTarget, events);
		}
		public static object Option(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_Component_option_7", dxTarget);
		}
		public static object Option(ElementRef dxTarget, string optionName)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_Component_option_8", dxTarget, optionName);
		}
		public static void Option(ElementRef dxTarget, string optionName, object optionValue)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_Component_option_9", dxTarget, optionName, optionValue);
		}
		public static void Option(ElementRef dxTarget, object options)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_Component_option_10", dxTarget, options);
		}
	}
	public class DevicesObjectInterop
	{
		public static object Current(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DevicesObject_current_0", dxTarget);
		}
		public static void Current(ElementRef dxTarget, object deviceName)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DevicesObject_current_1", dxTarget, deviceName);
		}
		public static object Off(ElementRef dxTarget, string eventName)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DevicesObject_off_2", dxTarget, eventName);
		}
		public static object Off(ElementRef dxTarget, string eventName, object eventHandler)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DevicesObject_off_3", dxTarget, eventName, eventHandler);
		}
		public static object On(ElementRef dxTarget, string eventName, object eventHandler)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DevicesObject_on_4", dxTarget, eventName, eventHandler);
		}
		public static object On(ElementRef dxTarget, object events)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DevicesObject_on_5", dxTarget, events);
		}
		public static string Orientation(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_DevicesObject_orientation_6", dxTarget);
		}
		public static object Real(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DevicesObject_real_7", dxTarget);
		}
	}
	public class DOMComponentInterop: ComponentInterop
	{
		public static event EventHandler<JQueryEventArgs> Disposing;
		public static event EventHandler<JQueryEventArgs> OptionChanged;
		public static void Init(ElementRef dxTarget, DevExpress.DOMComponentOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DOMComponent_Init", dxTarget, json);
		}
		[JSInvokable("DevExpress.DOMComponentInterop.OnDisposing")]
		public static void OnDisposing(string identifier)
		{
			Disposing?.Invoke(null, new JQueryEventArgs(identifier));
		}
		[JSInvokable("DevExpress.DOMComponentInterop.OnOptionChanged")]
		public static void OnOptionChanged(string identifier)
		{
			OptionChanged?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static object GetBindingOptions(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DOMComponent_GetOption", dxTarget, "bindingOptions");
		}
		public static void SetBindingOptions(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DOMComponent_SetOption", dxTarget, "bindingOptions", value);
		}
		public static object GetElementAttr(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DOMComponent_GetOption", dxTarget, "elementAttr");
		}
		public static void SetElementAttr(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DOMComponent_SetOption", dxTarget, "elementAttr", value);
		}
		public static object GetHeight(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DOMComponent_GetOption", dxTarget, "height");
		}
		public static void SetHeight(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DOMComponent_SetOption", dxTarget, "height", value);
		}
		public static bool? GetRtlEnabled(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_DOMComponent_GetOption", dxTarget, "rtlEnabled");
		}
		public static void SetRtlEnabled(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DOMComponent_SetOption", dxTarget, "rtlEnabled", value);
		}
		public static object GetWidth(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DOMComponent_GetOption", dxTarget, "width");
		}
		public static void SetWidth(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DOMComponent_SetOption", dxTarget, "width", value);
		}
		public static void DefaultOptions(object rule)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DOMComponent_defaultOptions_0", rule);
		}
		public static object GetInstance(object element)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DOMComponent_getInstance_1", element);
		}
		public static void Dispose(ElementRef dxTarget)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DOMComponent_dispose_0", dxTarget);
		}
		public static object Element(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DOMComponent_element_1", dxTarget);
		}
	}
	public class EndpointSelectorInterop
	{
		public static string UrlFor(ElementRef dxTarget, string key)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_EndpointSelector_urlFor_0", dxTarget, key);
		}
	}
	public class ValidationEngineInterop
	{
		public static object GetGroupConfig()
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_ValidationEngine_getGroupConfig_0");
		}
		public static object GetGroupConfig(object group)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_ValidationEngine_getGroupConfig_1", group);
		}
		public static void RegisterModelForValidation(object model)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_ValidationEngine_registerModelForValidation_2", model);
		}
		public static void ResetGroup()
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_ValidationEngine_resetGroup_3");
		}
		public static void ResetGroup(object group)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_ValidationEngine_resetGroup_4", group);
		}
		public static void UnregisterModelForValidation(object model)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_ValidationEngine_unregisterModelForValidation_5", model);
		}
		public static object ValidateGroup()
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_ValidationEngine_validateGroup_6");
		}
		public static object ValidateGroup(object group)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_ValidationEngine_validateGroup_7", group);
		}
		public static object ValidateModel(object model)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_ValidationEngine_validateModel_8", model);
		}
	}
	public class UiInterop
	{
		public static void Notify(string message, string type, float displayTime)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_Ui_notify_0", message, type, displayTime);
		}
		public static void Notify(object options, string type, float displayTime)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_Ui_notify_1", options, type, displayTime);
		}
		public static void SetTemplateEngine(string templateEngineName)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_Ui_setTemplateEngine_2", templateEngineName);
		}
		public static void SetTemplateEngine(object templateEngineOptions)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_Ui_setTemplateEngine_3", templateEngineOptions);
		}
	}
	public class VizInterop
	{
		public static void CurrentPalette(string paletteName)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_Viz_currentPalette_0", paletteName);
		}
		public static string CurrentTheme()
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_Viz_currentTheme_1");
		}
		public static void CurrentTheme(string platform, string colorScheme)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_Viz_currentTheme_2", platform, colorScheme);
		}
		public static void CurrentTheme(string theme)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_Viz_currentTheme_3", theme);
		}
		public static void ExportFromMarkup(string markup, object options)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_Viz_exportFromMarkup_4", markup, options);
		}
		public static string GetMarkup(object widgetInstances)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_Viz_getMarkup_5", widgetInstances);
		}
		public static object GetPalette(string paletteName)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_Viz_getPalette_6", paletteName);
		}
		public static object GetTheme(string theme)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_Viz_getTheme_7", theme);
		}
		public static void RefreshPaths()
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_Viz_refreshPaths_8");
		}
		public static void RefreshTheme()
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_Viz_refreshTheme_9");
		}
		public static void RegisterPalette(string paletteName, object palette)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_Viz_registerPalette_10", paletteName, palette);
		}
		public static void RegisterTheme(object customTheme, string baseTheme)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_Viz_registerTheme_11", customTheme, baseTheme);
		}
	}
}
namespace DevExpress.Data
{
	public class GuidInterop
	{
		public static string ToString(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_Guid_toString_0", dxTarget);
		}
		public static string ValueOf(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_Guid_valueOf_1", dxTarget);
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
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_Store_Init", dxTarget, json);
		}
		[JSInvokable("DevExpress.Data.StoreInterop.OnInserted")]
		public static void OnInserted(string identifier)
		{
			Inserted?.Invoke(null, new JQueryEventArgs(identifier));
		}
		[JSInvokable("DevExpress.Data.StoreInterop.OnInserting")]
		public static void OnInserting(string identifier)
		{
			Inserting?.Invoke(null, new JQueryEventArgs(identifier));
		}
		[JSInvokable("DevExpress.Data.StoreInterop.OnLoaded")]
		public static void OnLoaded(string identifier)
		{
			Loaded?.Invoke(null, new JQueryEventArgs(identifier));
		}
		[JSInvokable("DevExpress.Data.StoreInterop.OnLoading")]
		public static void OnLoading(string identifier)
		{
			Loading?.Invoke(null, new JQueryEventArgs(identifier));
		}
		[JSInvokable("DevExpress.Data.StoreInterop.OnModified")]
		public static void OnModified(string identifier)
		{
			Modified?.Invoke(null, new JQueryEventArgs(identifier));
		}
		[JSInvokable("DevExpress.Data.StoreInterop.OnModifying")]
		public static void OnModifying(string identifier)
		{
			Modifying?.Invoke(null, new JQueryEventArgs(identifier));
		}
		[JSInvokable("DevExpress.Data.StoreInterop.OnRemoved")]
		public static void OnRemoved(string identifier)
		{
			Removed?.Invoke(null, new JQueryEventArgs(identifier));
		}
		[JSInvokable("DevExpress.Data.StoreInterop.OnRemoving")]
		public static void OnRemoving(string identifier)
		{
			Removing?.Invoke(null, new JQueryEventArgs(identifier));
		}
		[JSInvokable("DevExpress.Data.StoreInterop.OnUpdated")]
		public static void OnUpdated(string identifier)
		{
			Updated?.Invoke(null, new JQueryEventArgs(identifier));
		}
		[JSInvokable("DevExpress.Data.StoreInterop.OnUpdating")]
		public static void OnUpdating(string identifier)
		{
			Updating?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static object GetErrorHandler(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_Store_GetOption", dxTarget, "errorHandler");
		}
		public static void SetErrorHandler(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_Store_SetOption", dxTarget, "errorHandler", value);
		}
		public static object GetKey(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_Store_GetOption", dxTarget, "key");
		}
		public static void SetKey(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_Store_SetOption", dxTarget, "key", value);
		}
		public static object ByKey(ElementRef dxTarget, object key)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_Store_byKey_0", dxTarget, key);
		}
		public static object Insert(ElementRef dxTarget, object values)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_Store_insert_1", dxTarget, values);
		}
		public static object Key(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_Store_key_2", dxTarget);
		}
		public static object KeyOf(ElementRef dxTarget, object obj)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_Store_keyOf_3", dxTarget, obj);
		}
		public static object Load(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_Store_load_4", dxTarget);
		}
		public static object Load(ElementRef dxTarget, object options)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_Store_load_5", dxTarget, options);
		}
		public static object Off(ElementRef dxTarget, string eventName)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_Store_off_6", dxTarget, eventName);
		}
		public static object Off(ElementRef dxTarget, string eventName, object eventHandler)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_Store_off_7", dxTarget, eventName, eventHandler);
		}
		public static object On(ElementRef dxTarget, string eventName, object eventHandler)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_Store_on_8", dxTarget, eventName, eventHandler);
		}
		public static object On(ElementRef dxTarget, object events)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_Store_on_9", dxTarget, events);
		}
		public static object Remove(ElementRef dxTarget, object key)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_Store_remove_10", dxTarget, key);
		}
		public static object TotalCount(ElementRef dxTarget, object obj)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_Store_totalCount_11", dxTarget, obj);
		}
		public static object Update(ElementRef dxTarget, object key, object values)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_Store_update_12", dxTarget, key, values);
		}
	}
	public class ArrayStoreInterop: StoreInterop
	{
		public static void Init(ElementRef dxTarget, DevExpress.Data.ArrayStoreOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_ArrayStore_Init", dxTarget, json);
		}
		public static object GetData(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_ArrayStore_GetOption", dxTarget, "data");
		}
		public static void SetData(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_ArrayStore_SetOption", dxTarget, "data", value);
		}
		public static void Clear(ElementRef dxTarget)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_ArrayStore_clear_0", dxTarget);
		}
		public static object CreateQuery(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_ArrayStore_createQuery_1", dxTarget);
		}
	}
	public class CustomStoreInterop: StoreInterop
	{
		public static void Init(ElementRef dxTarget, DevExpress.Data.CustomStoreOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_CustomStore_Init", dxTarget, json);
		}
		public static object GetByKey(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_CustomStore_GetOption", dxTarget, "byKey");
		}
		public static void SetByKey(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_CustomStore_SetOption", dxTarget, "byKey", value);
		}
		public static bool? GetCacheRawData(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_CustomStore_GetOption", dxTarget, "cacheRawData");
		}
		public static void SetCacheRawData(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_CustomStore_SetOption", dxTarget, "cacheRawData", value);
		}
		public static object GetInsert(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_CustomStore_GetOption", dxTarget, "insert");
		}
		public static void SetInsert(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_CustomStore_SetOption", dxTarget, "insert", value);
		}
		public static object GetLoad(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_CustomStore_GetOption", dxTarget, "load");
		}
		public static void SetLoad(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_CustomStore_SetOption", dxTarget, "load", value);
		}
		public static string GetLoadMode(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_CustomStore_GetOption", dxTarget, "loadMode");
		}
		public static void SetLoadMode(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_CustomStore_SetOption", dxTarget, "loadMode", value);
		}
		public static object GetRemove(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_CustomStore_GetOption", dxTarget, "remove");
		}
		public static void SetRemove(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_CustomStore_SetOption", dxTarget, "remove", value);
		}
		public static object GetTotalCount(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_CustomStore_GetOption", dxTarget, "totalCount");
		}
		public static void SetTotalCount(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_CustomStore_SetOption", dxTarget, "totalCount", value);
		}
		public static object GetUpdate(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_CustomStore_GetOption", dxTarget, "update");
		}
		public static void SetUpdate(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_CustomStore_SetOption", dxTarget, "update", value);
		}
		public static bool? GetUseDefaultSearch(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_CustomStore_GetOption", dxTarget, "useDefaultSearch");
		}
		public static void SetUseDefaultSearch(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_CustomStore_SetOption", dxTarget, "useDefaultSearch", value);
		}
		public static void ClearRawDataCache(ElementRef dxTarget)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_CustomStore_clearRawDataCache_0", dxTarget);
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
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DataSource_Init", dxTarget, json);
		}
		[JSInvokable("DevExpress.Data.DataSourceInterop.OnChanged")]
		public static void OnChanged(string identifier)
		{
			Changed?.Invoke(null, new JQueryEventArgs(identifier));
		}
		[JSInvokable("DevExpress.Data.DataSourceInterop.OnLoadError")]
		public static void OnLoadError(string identifier)
		{
			LoadError?.Invoke(null, new JQueryEventArgs(identifier));
		}
		[JSInvokable("DevExpress.Data.DataSourceInterop.OnLoadingChanged")]
		public static void OnLoadingChanged(string identifier)
		{
			LoadingChanged?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static object GetCustomQueryParams(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DataSource_GetOption", dxTarget, "customQueryParams");
		}
		public static void SetCustomQueryParams(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DataSource_SetOption", dxTarget, "customQueryParams", value);
		}
		public static object GetExpand(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DataSource_GetOption", dxTarget, "expand");
		}
		public static void SetExpand(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DataSource_SetOption", dxTarget, "expand", value);
		}
		public static object GetFilter(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DataSource_GetOption", dxTarget, "filter");
		}
		public static void SetFilter(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DataSource_SetOption", dxTarget, "filter", value);
		}
		public static object GetGroup(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DataSource_GetOption", dxTarget, "group");
		}
		public static void SetGroup(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DataSource_SetOption", dxTarget, "group", value);
		}
		public static object GetMap(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DataSource_GetOption", dxTarget, "map");
		}
		public static void SetMap(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DataSource_SetOption", dxTarget, "map", value);
		}
		public static float? GetPageSize(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<float?>("BlazorDevExtreme_DataSource_GetOption", dxTarget, "pageSize");
		}
		public static void SetPageSize(ElementRef dxTarget, float? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DataSource_SetOption", dxTarget, "pageSize", value);
		}
		public static bool? GetPaginate(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_DataSource_GetOption", dxTarget, "paginate");
		}
		public static void SetPaginate(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DataSource_SetOption", dxTarget, "paginate", value);
		}
		public static object GetPostProcess(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DataSource_GetOption", dxTarget, "postProcess");
		}
		public static void SetPostProcess(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DataSource_SetOption", dxTarget, "postProcess", value);
		}
		public static bool? GetRequireTotalCount(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_DataSource_GetOption", dxTarget, "requireTotalCount");
		}
		public static void SetRequireTotalCount(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DataSource_SetOption", dxTarget, "requireTotalCount", value);
		}
		public static object GetSearchExpr(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DataSource_GetOption", dxTarget, "searchExpr");
		}
		public static void SetSearchExpr(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DataSource_SetOption", dxTarget, "searchExpr", value);
		}
		public static string GetSearchOperation(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_DataSource_GetOption", dxTarget, "searchOperation");
		}
		public static void SetSearchOperation(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DataSource_SetOption", dxTarget, "searchOperation", value);
		}
		public static object GetSearchValue(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DataSource_GetOption", dxTarget, "searchValue");
		}
		public static void SetSearchValue(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DataSource_SetOption", dxTarget, "searchValue", value);
		}
		public static object GetSelect(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DataSource_GetOption", dxTarget, "select");
		}
		public static void SetSelect(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DataSource_SetOption", dxTarget, "select", value);
		}
		public static object GetSort(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DataSource_GetOption", dxTarget, "sort");
		}
		public static void SetSort(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DataSource_SetOption", dxTarget, "sort", value);
		}
		public static object GetStore(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DataSource_GetOption", dxTarget, "store");
		}
		public static void SetStore(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DataSource_SetOption", dxTarget, "store", value);
		}
		public static bool Cancel(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool>("BlazorDevExtreme_DataSource_cancel_0", dxTarget);
		}
		public static void Dispose(ElementRef dxTarget)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DataSource_dispose_1", dxTarget);
		}
		public static object Filter(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DataSource_filter_2", dxTarget);
		}
		public static void Filter(ElementRef dxTarget, object filterExpr)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DataSource_filter_3", dxTarget, filterExpr);
		}
		public static object Group(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DataSource_group_4", dxTarget);
		}
		public static void Group(ElementRef dxTarget, object groupExpr)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DataSource_group_5", dxTarget, groupExpr);
		}
		public static bool IsLastPage(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool>("BlazorDevExtreme_DataSource_isLastPage_6", dxTarget);
		}
		public static bool IsLoaded(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool>("BlazorDevExtreme_DataSource_isLoaded_7", dxTarget);
		}
		public static bool IsLoading(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool>("BlazorDevExtreme_DataSource_isLoading_8", dxTarget);
		}
		public static object Items(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DataSource_items_9", dxTarget);
		}
		public static object Key(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DataSource_key_10", dxTarget);
		}
		public static object Load(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DataSource_load_11", dxTarget);
		}
		public static object LoadOptions(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DataSource_loadOptions_12", dxTarget);
		}
		public static object Off(ElementRef dxTarget, string eventName)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DataSource_off_13", dxTarget, eventName);
		}
		public static object Off(ElementRef dxTarget, string eventName, object eventHandler)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DataSource_off_14", dxTarget, eventName, eventHandler);
		}
		public static object On(ElementRef dxTarget, string eventName, object eventHandler)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DataSource_on_15", dxTarget, eventName, eventHandler);
		}
		public static object On(ElementRef dxTarget, object events)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DataSource_on_16", dxTarget, events);
		}
		public static float PageIndex(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<float>("BlazorDevExtreme_DataSource_pageIndex_17", dxTarget);
		}
		public static void PageIndex(ElementRef dxTarget, float newIndex)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DataSource_pageIndex_18", dxTarget, newIndex);
		}
		public static float PageSize(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<float>("BlazorDevExtreme_DataSource_pageSize_19", dxTarget);
		}
		public static void PageSize(ElementRef dxTarget, float value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DataSource_pageSize_20", dxTarget, value);
		}
		public static bool Paginate(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool>("BlazorDevExtreme_DataSource_paginate_21", dxTarget);
		}
		public static void Paginate(ElementRef dxTarget, bool value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DataSource_paginate_22", dxTarget, value);
		}
		public static object Reload(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DataSource_reload_23", dxTarget);
		}
		public static bool RequireTotalCount(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool>("BlazorDevExtreme_DataSource_requireTotalCount_24", dxTarget);
		}
		public static void RequireTotalCount(ElementRef dxTarget, bool value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DataSource_requireTotalCount_25", dxTarget, value);
		}
		public static object SearchExpr(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DataSource_searchExpr_26", dxTarget);
		}
		public static void SearchExpr(ElementRef dxTarget, object expr)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DataSource_searchExpr_27", dxTarget, expr);
		}
		public static string SearchOperation(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_DataSource_searchOperation_28", dxTarget);
		}
		public static void SearchOperation(ElementRef dxTarget, string op)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DataSource_searchOperation_29", dxTarget, op);
		}
		public static object SearchValue(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DataSource_searchValue_30", dxTarget);
		}
		public static void SearchValue(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DataSource_searchValue_31", dxTarget, value);
		}
		public static object Select(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DataSource_select_32", dxTarget);
		}
		public static void Select(ElementRef dxTarget, object expr)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DataSource_select_33", dxTarget, expr);
		}
		public static object Sort(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DataSource_sort_34", dxTarget);
		}
		public static void Sort(ElementRef dxTarget, object sortExpr)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DataSource_sort_35", dxTarget, sortExpr);
		}
		public static object Store(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DataSource_store_36", dxTarget);
		}
		public static float TotalCount(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<float>("BlazorDevExtreme_DataSource_totalCount_37", dxTarget);
		}
	}
	public class LocalStoreInterop: ArrayStoreInterop
	{
		public static void Init(ElementRef dxTarget, DevExpress.Data.LocalStoreOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_LocalStore_Init", dxTarget, json);
		}
		public static float? GetFlushInterval(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<float?>("BlazorDevExtreme_LocalStore_GetOption", dxTarget, "flushInterval");
		}
		public static void SetFlushInterval(ElementRef dxTarget, float? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_LocalStore_SetOption", dxTarget, "flushInterval", value);
		}
		public static bool? GetImmediate(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_LocalStore_GetOption", dxTarget, "immediate");
		}
		public static void SetImmediate(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_LocalStore_SetOption", dxTarget, "immediate", value);
		}
		public static string GetName(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_LocalStore_GetOption", dxTarget, "name");
		}
		public static void SetName(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_LocalStore_SetOption", dxTarget, "name", value);
		}
		public static void Clear(ElementRef dxTarget)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_LocalStore_clear_0", dxTarget);
		}
	}
	public class QueryInterop
	{
		public static object Aggregate(ElementRef dxTarget, object seed, object step, object finalize)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_Query_aggregate_0", dxTarget, seed, step, finalize);
		}
		public static object Aggregate(ElementRef dxTarget, object step)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_Query_aggregate_1", dxTarget, step);
		}
		public static object Avg(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_Query_avg_2", dxTarget);
		}
		public static object Avg(ElementRef dxTarget, object getter)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_Query_avg_3", dxTarget, getter);
		}
		public static object Count(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_Query_count_4", dxTarget);
		}
		public static object Enumerate(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_Query_enumerate_5", dxTarget);
		}
		public static object Filter(ElementRef dxTarget, object criteria)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_Query_filter_6", dxTarget, criteria);
		}
		public static object GroupBy(ElementRef dxTarget, object getter)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_Query_groupBy_8", dxTarget, getter);
		}
		public static object Max(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_Query_max_9", dxTarget);
		}
		public static object Max(ElementRef dxTarget, object getter)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_Query_max_10", dxTarget, getter);
		}
		public static object Min(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_Query_min_11", dxTarget);
		}
		public static object Min(ElementRef dxTarget, object getter)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_Query_min_12", dxTarget, getter);
		}
		public static object Select(ElementRef dxTarget, object getter)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_Query_select_13", dxTarget, getter);
		}
		public static object Slice(ElementRef dxTarget, float skip, float take)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_Query_slice_14", dxTarget, skip, take);
		}
		public static object SortBy(ElementRef dxTarget, object getter)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_Query_sortBy_15", dxTarget, getter);
		}
		public static object SortBy(ElementRef dxTarget, object getter, bool desc)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_Query_sortBy_16", dxTarget, getter, desc);
		}
		public static object Sum(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_Query_sum_17", dxTarget);
		}
		public static object Sum(ElementRef dxTarget, object getter)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_Query_sum_18", dxTarget, getter);
		}
		public static object ThenBy(ElementRef dxTarget, object getter)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_Query_thenBy_19", dxTarget, getter);
		}
		public static object ThenBy(ElementRef dxTarget, object getter, bool desc)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_Query_thenBy_20", dxTarget, getter, desc);
		}
		public static object ToArray(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_Query_toArray_21", dxTarget);
		}
	}
	public class ODataContextInterop
	{
		public static void Init(ElementRef dxTarget, DevExpress.Data.ODataContextOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_ODataContext_Init", dxTarget, json);
		}
		public static object GetBeforeSend(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_ODataContext_GetOption", dxTarget, "beforeSend");
		}
		public static void SetBeforeSend(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_ODataContext_SetOption", dxTarget, "beforeSend", value);
		}
		public static bool? GetDeserializeDates(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_ODataContext_GetOption", dxTarget, "deserializeDates");
		}
		public static void SetDeserializeDates(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_ODataContext_SetOption", dxTarget, "deserializeDates", value);
		}
		public static object GetEntities(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_ODataContext_GetOption", dxTarget, "entities");
		}
		public static void SetEntities(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_ODataContext_SetOption", dxTarget, "entities", value);
		}
		public static object GetErrorHandler(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_ODataContext_GetOption", dxTarget, "errorHandler");
		}
		public static void SetErrorHandler(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_ODataContext_SetOption", dxTarget, "errorHandler", value);
		}
		public static bool? GetJsonp(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_ODataContext_GetOption", dxTarget, "jsonp");
		}
		public static void SetJsonp(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_ODataContext_SetOption", dxTarget, "jsonp", value);
		}
		public static string GetUrl(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_ODataContext_GetOption", dxTarget, "url");
		}
		public static void SetUrl(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_ODataContext_SetOption", dxTarget, "url", value);
		}
		public static float? GetVersion(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<float?>("BlazorDevExtreme_ODataContext_GetOption", dxTarget, "version");
		}
		public static void SetVersion(ElementRef dxTarget, float? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_ODataContext_SetOption", dxTarget, "version", value);
		}
		public static bool? GetWithCredentials(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_ODataContext_GetOption", dxTarget, "withCredentials");
		}
		public static void SetWithCredentials(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_ODataContext_SetOption", dxTarget, "withCredentials", value);
		}
		public static object Get(ElementRef dxTarget, string operationName, object @params)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_ODataContext_get_0", dxTarget, operationName, @params);
		}
		public static object Invoke(ElementRef dxTarget, string operationName, object @params, object httpMethod)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_ODataContext_invoke_1", dxTarget, operationName, @params, httpMethod);
		}
		public static object ObjectLink(ElementRef dxTarget, string entityAlias, object key)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_ODataContext_objectLink_2", dxTarget, entityAlias, key);
		}
	}
	public class ODataStoreInterop: StoreInterop
	{
		public static event EventHandler<JQueryEventArgs> Loading;
		public static void Init(ElementRef dxTarget, DevExpress.Data.ODataStoreOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_ODataStore_Init", dxTarget, json);
		}
		[JSInvokable("DevExpress.Data.ODataStoreInterop.OnLoading")]
		public static void OnLoading(string identifier)
		{
			Loading?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static object GetBeforeSend(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_ODataStore_GetOption", dxTarget, "beforeSend");
		}
		public static void SetBeforeSend(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_ODataStore_SetOption", dxTarget, "beforeSend", value);
		}
		public static bool? GetDeserializeDates(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_ODataStore_GetOption", dxTarget, "deserializeDates");
		}
		public static void SetDeserializeDates(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_ODataStore_SetOption", dxTarget, "deserializeDates", value);
		}
		public static object GetFieldTypes(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_ODataStore_GetOption", dxTarget, "fieldTypes");
		}
		public static void SetFieldTypes(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_ODataStore_SetOption", dxTarget, "fieldTypes", value);
		}
		public static bool? GetJsonp(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_ODataStore_GetOption", dxTarget, "jsonp");
		}
		public static void SetJsonp(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_ODataStore_SetOption", dxTarget, "jsonp", value);
		}
		public static object GetKeyType(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_ODataStore_GetOption", dxTarget, "keyType");
		}
		public static void SetKeyType(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_ODataStore_SetOption", dxTarget, "keyType", value);
		}
		public static string GetUrl(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_ODataStore_GetOption", dxTarget, "url");
		}
		public static void SetUrl(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_ODataStore_SetOption", dxTarget, "url", value);
		}
		public static float? GetVersion(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<float?>("BlazorDevExtreme_ODataStore_GetOption", dxTarget, "version");
		}
		public static void SetVersion(ElementRef dxTarget, float? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_ODataStore_SetOption", dxTarget, "version", value);
		}
		public static bool? GetWithCredentials(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_ODataStore_GetOption", dxTarget, "withCredentials");
		}
		public static void SetWithCredentials(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_ODataStore_SetOption", dxTarget, "withCredentials", value);
		}
		public static object ByKey(ElementRef dxTarget, object key)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_ODataStore_byKey_0", dxTarget, key);
		}
		public static object ByKey(ElementRef dxTarget, object key, object extraOptions)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_ODataStore_byKey_1", dxTarget, key, extraOptions);
		}
		public static object CreateQuery(ElementRef dxTarget, object loadOptions)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_ODataStore_createQuery_2", dxTarget, loadOptions);
		}
		public static object Load(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_ODataStore_load_3", dxTarget);
		}
		public static object Load(ElementRef dxTarget, object options)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_ODataStore_load_4", dxTarget, options);
		}
	}
	public class EdmLiteralInterop
	{
		public static string ValueOf(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_EdmLiteral_valueOf_0", dxTarget);
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
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_PivotGridDataSource_Init", dxTarget, json);
		}
		[JSInvokable("DevExpress.Data.PivotGridDataSourceInterop.OnChanged")]
		public static void OnChanged(string identifier)
		{
			Changed?.Invoke(null, new JQueryEventArgs(identifier));
		}
		[JSInvokable("DevExpress.Data.PivotGridDataSourceInterop.OnFieldsPrepared")]
		public static void OnFieldsPrepared(string identifier)
		{
			FieldsPrepared?.Invoke(null, new JQueryEventArgs(identifier));
		}
		[JSInvokable("DevExpress.Data.PivotGridDataSourceInterop.OnLoadError")]
		public static void OnLoadError(string identifier)
		{
			LoadError?.Invoke(null, new JQueryEventArgs(identifier));
		}
		[JSInvokable("DevExpress.Data.PivotGridDataSourceInterop.OnLoadingChanged")]
		public static void OnLoadingChanged(string identifier)
		{
			LoadingChanged?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static object GetFields(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_PivotGridDataSource_GetOption", dxTarget, "fields");
		}
		public static void SetFields(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_PivotGridDataSource_SetOption", dxTarget, "fields", value);
		}
		public static object GetFilter(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_PivotGridDataSource_GetOption", dxTarget, "filter");
		}
		public static void SetFilter(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_PivotGridDataSource_SetOption", dxTarget, "filter", value);
		}
		public static bool? GetRemoteOperations(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_PivotGridDataSource_GetOption", dxTarget, "remoteOperations");
		}
		public static void SetRemoteOperations(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_PivotGridDataSource_SetOption", dxTarget, "remoteOperations", value);
		}
		public static bool? GetRetrieveFields(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_PivotGridDataSource_GetOption", dxTarget, "retrieveFields");
		}
		public static void SetRetrieveFields(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_PivotGridDataSource_SetOption", dxTarget, "retrieveFields", value);
		}
		public static object GetStore(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_PivotGridDataSource_GetOption", dxTarget, "store");
		}
		public static void SetStore(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_PivotGridDataSource_SetOption", dxTarget, "store", value);
		}
		public static void CollapseAll(ElementRef dxTarget, object id)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_PivotGridDataSource_collapseAll_0", dxTarget, id);
		}
		public static void CollapseHeaderItem(ElementRef dxTarget, string area, object path)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_PivotGridDataSource_collapseHeaderItem_1", dxTarget, area, path);
		}
		public static object CreateDrillDownDataSource(ElementRef dxTarget, object options)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_PivotGridDataSource_createDrillDownDataSource_2", dxTarget, options);
		}
		public static void Dispose(ElementRef dxTarget)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_PivotGridDataSource_dispose_3", dxTarget);
		}
		public static void ExpandAll(ElementRef dxTarget, object id)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_PivotGridDataSource_expandAll_4", dxTarget, id);
		}
		public static void ExpandHeaderItem(ElementRef dxTarget, string area, object path)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_PivotGridDataSource_expandHeaderItem_5", dxTarget, area, path);
		}
		public static object Field(ElementRef dxTarget, object id)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_PivotGridDataSource_field_6", dxTarget, id);
		}
		public static void Field(ElementRef dxTarget, object id, object options)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_PivotGridDataSource_field_7", dxTarget, id, options);
		}
		public static object Fields(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_PivotGridDataSource_fields_8", dxTarget);
		}
		public static void Fields(ElementRef dxTarget, object fields)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_PivotGridDataSource_fields_9", dxTarget, fields);
		}
		public static object Filter(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_PivotGridDataSource_filter_10", dxTarget);
		}
		public static void Filter(ElementRef dxTarget, object filterExpr)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_PivotGridDataSource_filter_11", dxTarget, filterExpr);
		}
		public static object GetAreaFields(ElementRef dxTarget, string area, bool collectGroups)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_PivotGridDataSource_getAreaFields_12", dxTarget, area, collectGroups);
		}
		public static object GetData(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_PivotGridDataSource_getData_13", dxTarget);
		}
		public static bool IsLoading(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool>("BlazorDevExtreme_PivotGridDataSource_isLoading_14", dxTarget);
		}
		public static object Load(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_PivotGridDataSource_load_15", dxTarget);
		}
		public static object Off(ElementRef dxTarget, string eventName)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_PivotGridDataSource_off_16", dxTarget, eventName);
		}
		public static object Off(ElementRef dxTarget, string eventName, object eventHandler)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_PivotGridDataSource_off_17", dxTarget, eventName, eventHandler);
		}
		public static object On(ElementRef dxTarget, string eventName, object eventHandler)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_PivotGridDataSource_on_18", dxTarget, eventName, eventHandler);
		}
		public static object On(ElementRef dxTarget, object events)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_PivotGridDataSource_on_19", dxTarget, events);
		}
		public static object Reload(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_PivotGridDataSource_reload_20", dxTarget);
		}
		public static object State(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_PivotGridDataSource_state_21", dxTarget);
		}
		public static void State(ElementRef dxTarget, object state)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_PivotGridDataSource_state_22", dxTarget, state);
		}
	}
	public class XmlaStoreInterop
	{
		public static void Init(ElementRef dxTarget, DevExpress.Data.XmlaStoreOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_XmlaStore_Init", dxTarget, json);
		}
		public static object GetBeforeSend(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_XmlaStore_GetOption", dxTarget, "beforeSend");
		}
		public static void SetBeforeSend(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_XmlaStore_SetOption", dxTarget, "beforeSend", value);
		}
		public static string GetCatalog(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_XmlaStore_GetOption", dxTarget, "catalog");
		}
		public static void SetCatalog(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_XmlaStore_SetOption", dxTarget, "catalog", value);
		}
		public static string GetCube(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_XmlaStore_GetOption", dxTarget, "cube");
		}
		public static void SetCube(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_XmlaStore_SetOption", dxTarget, "cube", value);
		}
		public static string GetUrl(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_XmlaStore_GetOption", dxTarget, "url");
		}
		public static void SetUrl(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_XmlaStore_SetOption", dxTarget, "url", value);
		}
	}
}
namespace DevExpress.Core
{
	public class EventsMixinInterop
	{
		public static object Off(ElementRef dxTarget, string eventName)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_EventsMixin_off_0", dxTarget, eventName);
		}
		public static object Off(ElementRef dxTarget, string eventName, object eventHandler)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_EventsMixin_off_1", dxTarget, eventName, eventHandler);
		}
		public static object On(ElementRef dxTarget, string eventName, object eventHandler)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_EventsMixin_on_2", dxTarget, eventName, eventHandler);
		}
		public static object On(ElementRef dxTarget, object events)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_EventsMixin_on_3", dxTarget, events);
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
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxCommand_Init", dxTarget, json);
		}
		[JSInvokable("DevExpress.Framework.DxCommandInterop.OnExecute")]
		public static void OnExecute(string identifier)
		{
			Execute?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static bool? GetDisabled(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_DxCommand_GetOption", dxTarget, "disabled");
		}
		public static void SetDisabled(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxCommand_SetOption", dxTarget, "disabled", value);
		}
		public static string GetIcon(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_DxCommand_GetOption", dxTarget, "icon");
		}
		public static void SetIcon(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxCommand_SetOption", dxTarget, "icon", value);
		}
		public static object GetIconSrc(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxCommand_GetOption", dxTarget, "iconSrc");
		}
		public static void SetIconSrc(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxCommand_SetOption", dxTarget, "iconSrc", value);
		}
		public static string GetId(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_DxCommand_GetOption", dxTarget, "id");
		}
		public static void SetId(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxCommand_SetOption", dxTarget, "id", value);
		}
		public static string GetRenderStage(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_DxCommand_GetOption", dxTarget, "renderStage");
		}
		public static void SetRenderStage(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxCommand_SetOption", dxTarget, "renderStage", value);
		}
		public static string GetTitle(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_DxCommand_GetOption", dxTarget, "title");
		}
		public static void SetTitle(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxCommand_SetOption", dxTarget, "title", value);
		}
		public static string GetType(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_DxCommand_GetOption", dxTarget, "type");
		}
		public static void SetType(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxCommand_SetOption", dxTarget, "type", value);
		}
		public static bool? GetVisible(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_DxCommand_GetOption", dxTarget, "visible");
		}
		public static void SetVisible(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxCommand_SetOption", dxTarget, "visible", value);
		}
		public static void DoExecute(ElementRef dxTarget)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxCommand_execute_0", dxTarget);
		}
	}
	public class RouterInterop
	{
		public static string Format(ElementRef dxTarget, object obj)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_Router_format_0", dxTarget, obj);
		}
		public static object Parse(ElementRef dxTarget, string uri)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_Router_parse_1", dxTarget, uri);
		}
		public static void Register(ElementRef dxTarget, string pattern, object defaults, object constraints)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_Router_register_2", dxTarget, pattern, defaults, constraints);
		}
	}
	public class StateManagerInterop
	{
		public static void Init(ElementRef dxTarget, DevExpress.Framework.StateManagerOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_StateManager_Init", dxTarget, json);
		}
		public static object GetStorage(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_StateManager_GetOption", dxTarget, "storage");
		}
		public static void SetStorage(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_StateManager_SetOption", dxTarget, "storage", value);
		}
		public static void AddStateSource(ElementRef dxTarget, object stateSource)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_StateManager_addStateSource_0", dxTarget, stateSource);
		}
		public static void ClearState(ElementRef dxTarget)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_StateManager_clearState_1", dxTarget);
		}
		public static void RemoveStateSource(ElementRef dxTarget, object stateSource)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_StateManager_removeStateSource_2", dxTarget, stateSource);
		}
		public static void RestoreState(ElementRef dxTarget)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_StateManager_restoreState_3", dxTarget);
		}
		public static void SaveState(ElementRef dxTarget)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_StateManager_saveState_4", dxTarget);
		}
	}
	public class ViewCacheInterop
	{
		public static void Clear(ElementRef dxTarget)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_ViewCache_clear_0", dxTarget);
		}
		public static object GetView(ElementRef dxTarget, string key)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_ViewCache_getView_1", dxTarget, key);
		}
		public static bool HasView(ElementRef dxTarget, string key)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool>("BlazorDevExtreme_ViewCache_hasView_2", dxTarget, key);
		}
		public static object Off(ElementRef dxTarget, string eventName)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_ViewCache_off_3", dxTarget, eventName);
		}
		public static object Off(ElementRef dxTarget, string eventName, object eventHandler)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_ViewCache_off_4", dxTarget, eventName, eventHandler);
		}
		public static object On(ElementRef dxTarget, string eventName, object eventHandler)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_ViewCache_on_5", dxTarget, eventName, eventHandler);
		}
		public static object On(ElementRef dxTarget, object events)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_ViewCache_on_6", dxTarget, events);
		}
		public static object RemoveView(ElementRef dxTarget, string key)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_ViewCache_removeView_7", dxTarget, key);
		}
		public static void SetView(ElementRef dxTarget, string key, object viewInfo)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_ViewCache_setView_8", dxTarget, key, viewInfo);
		}
	}
	public class DxCommandContainerInterop
	{
		public static void Init(ElementRef dxTarget, DevExpress.Framework.DxCommandContainerOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxCommandContainer_Init", dxTarget, json);
		}
		public static string GetId(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_DxCommandContainer_GetOption", dxTarget, "id");
		}
		public static void SetId(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxCommandContainer_SetOption", dxTarget, "id", value);
		}
	}
	public class DxViewInterop
	{
		public static void Init(ElementRef dxTarget, DevExpress.Framework.DxViewOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxView_Init", dxTarget, json);
		}
		public static bool? GetDisableCache(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_DxView_GetOption", dxTarget, "disableCache");
		}
		public static void SetDisableCache(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxView_SetOption", dxTarget, "disableCache", value);
		}
		public static bool? GetModal(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_DxView_GetOption", dxTarget, "modal");
		}
		public static void SetModal(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxView_SetOption", dxTarget, "modal", value);
		}
		public static string GetName(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_DxView_GetOption", dxTarget, "name");
		}
		public static void SetName(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxView_SetOption", dxTarget, "name", value);
		}
		public static string GetOrientation(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_DxView_GetOption", dxTarget, "orientation");
		}
		public static void SetOrientation(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxView_SetOption", dxTarget, "orientation", value);
		}
		public static string GetPane(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_DxView_GetOption", dxTarget, "pane");
		}
		public static void SetPane(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxView_SetOption", dxTarget, "pane", value);
		}
		public static string GetTitle(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_DxView_GetOption", dxTarget, "title");
		}
		public static void SetTitle(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxView_SetOption", dxTarget, "title", value);
		}
	}
	public class DxLayoutInterop
	{
		public static void Init(ElementRef dxTarget, DevExpress.Framework.DxLayoutOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxLayout_Init", dxTarget, json);
		}
		public static string GetName(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_DxLayout_GetOption", dxTarget, "name");
		}
		public static void SetName(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxLayout_SetOption", dxTarget, "name", value);
		}
	}
	public class DxViewPlaceholderInterop
	{
		public static void Init(ElementRef dxTarget, DevExpress.Framework.DxViewPlaceholderOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxViewPlaceholder_Init", dxTarget, json);
		}
		public static string GetViewName(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_DxViewPlaceholder_GetOption", dxTarget, "viewName");
		}
		public static void SetViewName(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxViewPlaceholder_SetOption", dxTarget, "viewName", value);
		}
	}
	public class DxTransitionInterop
	{
		public static void Init(ElementRef dxTarget, DevExpress.Framework.DxTransitionOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxTransition_Init", dxTarget, json);
		}
		public static string GetAnimation(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_DxTransition_GetOption", dxTarget, "animation");
		}
		public static void SetAnimation(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxTransition_SetOption", dxTarget, "animation", value);
		}
		public static string GetName(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_DxTransition_GetOption", dxTarget, "name");
		}
		public static void SetName(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxTransition_SetOption", dxTarget, "name", value);
		}
		public static string GetType(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_DxTransition_GetOption", dxTarget, "type");
		}
		public static void SetType(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxTransition_SetOption", dxTarget, "type", value);
		}
	}
	public class DxContentPlaceholderInterop
	{
		public static void Init(ElementRef dxTarget, DevExpress.Framework.DxContentPlaceholderOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxContentPlaceholder_Init", dxTarget, json);
		}
		public static string GetAnimation(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_DxContentPlaceholder_GetOption", dxTarget, "animation");
		}
		public static void SetAnimation(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxContentPlaceholder_SetOption", dxTarget, "animation", value);
		}
		public static string GetContentCssPosition(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_DxContentPlaceholder_GetOption", dxTarget, "contentCssPosition");
		}
		public static void SetContentCssPosition(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxContentPlaceholder_SetOption", dxTarget, "contentCssPosition", value);
		}
		public static string GetName(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_DxContentPlaceholder_GetOption", dxTarget, "name");
		}
		public static void SetName(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxContentPlaceholder_SetOption", dxTarget, "name", value);
		}
		public static string GetTransition(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_DxContentPlaceholder_GetOption", dxTarget, "transition");
		}
		public static void SetTransition(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxContentPlaceholder_SetOption", dxTarget, "transition", value);
		}
	}
	public class DxContentInterop
	{
		public static void Init(ElementRef dxTarget, DevExpress.Framework.DxContentOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxContent_Init", dxTarget, json);
		}
		public static string GetTargetPlaceholder(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_DxContent_GetOption", dxTarget, "targetPlaceholder");
		}
		public static void SetTargetPlaceholder(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxContent_SetOption", dxTarget, "targetPlaceholder", value);
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
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_HtmlApplication_Init", dxTarget, json);
		}
		public static object GetAnimationSet(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_HtmlApplication_GetOption", dxTarget, "animationSet");
		}
		public static void SetAnimationSet(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_HtmlApplication_SetOption", dxTarget, "animationSet", value);
		}
		public static object GetCommandMapping(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_HtmlApplication_GetOption", dxTarget, "commandMapping");
		}
		public static void SetCommandMapping(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_HtmlApplication_SetOption", dxTarget, "commandMapping", value);
		}
		public static bool? GetDisableViewCache(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_HtmlApplication_GetOption", dxTarget, "disableViewCache");
		}
		public static void SetDisableViewCache(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_HtmlApplication_SetOption", dxTarget, "disableViewCache", value);
		}
		public static object GetLayoutSet(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_HtmlApplication_GetOption", dxTarget, "layoutSet");
		}
		public static void SetLayoutSet(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_HtmlApplication_SetOption", dxTarget, "layoutSet", value);
		}
		public static string GetMode(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_HtmlApplication_GetOption", dxTarget, "mode");
		}
		public static void SetMode(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_HtmlApplication_SetOption", dxTarget, "mode", value);
		}
		public static object GetNamespace(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_HtmlApplication_GetOption", dxTarget, "namespace");
		}
		public static void SetNamespace(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_HtmlApplication_SetOption", dxTarget, "namespace", value);
		}
		public static string GetNavigateToRootViewMode(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_HtmlApplication_GetOption", dxTarget, "navigateToRootViewMode");
		}
		public static void SetNavigateToRootViewMode(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_HtmlApplication_SetOption", dxTarget, "navigateToRootViewMode", value);
		}
		public static object GetNavigation(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_HtmlApplication_GetOption", dxTarget, "navigation");
		}
		public static void SetNavigation(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_HtmlApplication_SetOption", dxTarget, "navigation", value);
		}
		public static object GetRouter(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_HtmlApplication_GetOption", dxTarget, "router");
		}
		public static void SetRouter(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_HtmlApplication_SetOption", dxTarget, "router", value);
		}
		public static object GetStateManager(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_HtmlApplication_GetOption", dxTarget, "stateManager");
		}
		public static void SetStateManager(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_HtmlApplication_SetOption", dxTarget, "stateManager", value);
		}
		public static object GetStateStorage(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_HtmlApplication_GetOption", dxTarget, "stateStorage");
		}
		public static void SetStateStorage(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_HtmlApplication_SetOption", dxTarget, "stateStorage", value);
		}
		public static string GetTemplatesVersion(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_HtmlApplication_GetOption", dxTarget, "templatesVersion");
		}
		public static void SetTemplatesVersion(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_HtmlApplication_SetOption", dxTarget, "templatesVersion", value);
		}
		public static bool? GetUseViewTitleAsBackText(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_HtmlApplication_GetOption", dxTarget, "useViewTitleAsBackText");
		}
		public static void SetUseViewTitleAsBackText(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_HtmlApplication_SetOption", dxTarget, "useViewTitleAsBackText", value);
		}
		public static object GetViewCache(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_HtmlApplication_GetOption", dxTarget, "viewCache");
		}
		public static void SetViewCache(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_HtmlApplication_SetOption", dxTarget, "viewCache", value);
		}
		public static float? GetViewCacheSize(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<float?>("BlazorDevExtreme_HtmlApplication_GetOption", dxTarget, "viewCacheSize");
		}
		public static void SetViewCacheSize(ElementRef dxTarget, float? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_HtmlApplication_SetOption", dxTarget, "viewCacheSize", value);
		}
		public static object GetViewPort(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_HtmlApplication_GetOption", dxTarget, "viewPort");
		}
		public static void SetViewPort(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_HtmlApplication_SetOption", dxTarget, "viewPort", value);
		}
		public static void Back(ElementRef dxTarget)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_HtmlApplication_back_0", dxTarget);
		}
		public static bool CanBack(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool>("BlazorDevExtreme_HtmlApplication_canBack_1", dxTarget);
		}
		public static void ClearState(ElementRef dxTarget)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_HtmlApplication_clearState_2", dxTarget);
		}
		public static void CreateNavigation(ElementRef dxTarget, object navigationConfig)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_HtmlApplication_createNavigation_3", dxTarget, navigationConfig);
		}
		public static object GetViewTemplate(ElementRef dxTarget, string viewName)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_HtmlApplication_getViewTemplate_4", dxTarget, viewName);
		}
		public static object GetViewTemplateInfo(ElementRef dxTarget, string viewName)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_HtmlApplication_getViewTemplateInfo_5", dxTarget, viewName);
		}
		public static object LoadTemplates(ElementRef dxTarget, object source)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_HtmlApplication_loadTemplates_6", dxTarget, source);
		}
		public static void Navigate(ElementRef dxTarget, object uri)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_HtmlApplication_navigate_7", dxTarget, uri);
		}
		public static void Navigate(ElementRef dxTarget, object uri, object options)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_HtmlApplication_navigate_8", dxTarget, uri, options);
		}
		public static object Off(ElementRef dxTarget, string eventName)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_HtmlApplication_off_9", dxTarget, eventName);
		}
		public static object Off(ElementRef dxTarget, string eventName, object eventHandler)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_HtmlApplication_off_10", dxTarget, eventName, eventHandler);
		}
		public static object On(ElementRef dxTarget, string eventName, object eventHandler)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_HtmlApplication_on_11", dxTarget, eventName, eventHandler);
		}
		public static object On(ElementRef dxTarget, object events)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_HtmlApplication_on_12", dxTarget, events);
		}
		public static void RenderNavigation(ElementRef dxTarget)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_HtmlApplication_renderNavigation_13", dxTarget);
		}
		public static void RestoreState(ElementRef dxTarget)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_HtmlApplication_restoreState_14", dxTarget);
		}
		public static void SaveState(ElementRef dxTarget)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_HtmlApplication_saveState_15", dxTarget);
		}
		public static object TemplateContext(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_HtmlApplication_templateContext_16", dxTarget);
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
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxAccordion_Init", dxTarget, json);
		}
		[JSInvokable("DevExpress.Ui.DxAccordionInterop.OnItemTitleClick")]
		public static void OnItemTitleClick(string identifier)
		{
			ItemTitleClick?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static float? GetAnimationDuration(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<float?>("BlazorDevExtreme_DxAccordion_GetOption", dxTarget, "animationDuration");
		}
		public static void SetAnimationDuration(ElementRef dxTarget, float? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxAccordion_SetOption", dxTarget, "animationDuration", value);
		}
		public static bool? GetCollapsible(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_DxAccordion_GetOption", dxTarget, "collapsible");
		}
		public static void SetCollapsible(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxAccordion_SetOption", dxTarget, "collapsible", value);
		}
		public static bool? GetDeferRendering(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_DxAccordion_GetOption", dxTarget, "deferRendering");
		}
		public static void SetDeferRendering(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxAccordion_SetOption", dxTarget, "deferRendering", value);
		}
		public static new bool? GetFocusStateEnabled(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_DxAccordion_GetOption", dxTarget, "focusStateEnabled");
		}
		public static new void SetFocusStateEnabled(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxAccordion_SetOption", dxTarget, "focusStateEnabled", value);
		}
		public static new object GetHeight(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxAccordion_GetOption", dxTarget, "height");
		}
		public static new void SetHeight(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxAccordion_SetOption", dxTarget, "height", value);
		}
		public static new bool? GetHoverStateEnabled(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_DxAccordion_GetOption", dxTarget, "hoverStateEnabled");
		}
		public static new void SetHoverStateEnabled(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxAccordion_SetOption", dxTarget, "hoverStateEnabled", value);
		}
		public static new object GetItemTemplate(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxAccordion_GetOption", dxTarget, "itemTemplate");
		}
		public static new void SetItemTemplate(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxAccordion_SetOption", dxTarget, "itemTemplate", value);
		}
		public static object GetItemTitleTemplate(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxAccordion_GetOption", dxTarget, "itemTitleTemplate");
		}
		public static void SetItemTitleTemplate(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxAccordion_SetOption", dxTarget, "itemTitleTemplate", value);
		}
		public static bool? GetMultiple(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_DxAccordion_GetOption", dxTarget, "multiple");
		}
		public static void SetMultiple(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxAccordion_SetOption", dxTarget, "multiple", value);
		}
		public static new float? GetSelectedIndex(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<float?>("BlazorDevExtreme_DxAccordion_GetOption", dxTarget, "selectedIndex");
		}
		public static new void SetSelectedIndex(ElementRef dxTarget, float? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxAccordion_SetOption", dxTarget, "selectedIndex", value);
		}
		public static object CollapseItem(ElementRef dxTarget, float index)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxAccordion_collapseItem_0", dxTarget, index);
		}
		public static object ExpandItem(ElementRef dxTarget, float index)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxAccordion_expandItem_1", dxTarget, index);
		}
		public static object UpdateDimensions(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxAccordion_updateDimensions_2", dxTarget);
		}
	}
	public class DxActionSheetInterop: CollectionWidgetInterop
	{
		public static event EventHandler<JQueryEventArgs> CancelClick;
		public static void Init(ElementRef dxTarget, DevExpress.Ui.DxActionSheetOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxActionSheet_Init", dxTarget, json);
		}
		[JSInvokable("DevExpress.Ui.DxActionSheetInterop.OnCancelClick")]
		public static void OnCancelClick(string identifier)
		{
			CancelClick?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static string GetCancelText(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_DxActionSheet_GetOption", dxTarget, "cancelText");
		}
		public static void SetCancelText(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxActionSheet_SetOption", dxTarget, "cancelText", value);
		}
		public static bool? GetShowCancelButton(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_DxActionSheet_GetOption", dxTarget, "showCancelButton");
		}
		public static void SetShowCancelButton(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxActionSheet_SetOption", dxTarget, "showCancelButton", value);
		}
		public static bool? GetShowTitle(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_DxActionSheet_GetOption", dxTarget, "showTitle");
		}
		public static void SetShowTitle(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxActionSheet_SetOption", dxTarget, "showTitle", value);
		}
		public static object GetTarget(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxActionSheet_GetOption", dxTarget, "target");
		}
		public static void SetTarget(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxActionSheet_SetOption", dxTarget, "target", value);
		}
		public static string GetTitle(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_DxActionSheet_GetOption", dxTarget, "title");
		}
		public static void SetTitle(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxActionSheet_SetOption", dxTarget, "title", value);
		}
		public static bool? GetUsePopover(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_DxActionSheet_GetOption", dxTarget, "usePopover");
		}
		public static void SetUsePopover(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxActionSheet_SetOption", dxTarget, "usePopover", value);
		}
		public static new bool? GetVisible(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_DxActionSheet_GetOption", dxTarget, "visible");
		}
		public static new void SetVisible(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxActionSheet_SetOption", dxTarget, "visible", value);
		}
		public static object Hide(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxActionSheet_hide_0", dxTarget);
		}
		public static object Show(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxActionSheet_show_1", dxTarget);
		}
		public static object Toggle(ElementRef dxTarget, bool showing)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxActionSheet_toggle_2", dxTarget, showing);
		}
	}
	public class DxAutocompleteInterop: DxDropDownListInterop
	{
		public static void Init(ElementRef dxTarget, DevExpress.Ui.DxAutocompleteOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxAutocomplete_Init", dxTarget, json);
		}
		public static float? GetMaxItemCount(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<float?>("BlazorDevExtreme_DxAutocomplete_GetOption", dxTarget, "maxItemCount");
		}
		public static void SetMaxItemCount(ElementRef dxTarget, float? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxAutocomplete_SetOption", dxTarget, "maxItemCount", value);
		}
		public static new float? GetMinSearchLength(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<float?>("BlazorDevExtreme_DxAutocomplete_GetOption", dxTarget, "minSearchLength");
		}
		public static new void SetMinSearchLength(ElementRef dxTarget, float? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxAutocomplete_SetOption", dxTarget, "minSearchLength", value);
		}
		public static new string GetValue(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_DxAutocomplete_GetOption", dxTarget, "value");
		}
		public static new void SetValue(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxAutocomplete_SetOption", dxTarget, "value", value);
		}
	}
	public class DxBoxInterop: CollectionWidgetInterop
	{
		public static void Init(ElementRef dxTarget, DevExpress.Ui.DxBoxOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxBox_Init", dxTarget, json);
		}
		public static string GetAlign(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_DxBox_GetOption", dxTarget, "align");
		}
		public static void SetAlign(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxBox_SetOption", dxTarget, "align", value);
		}
		public static string GetCrossAlign(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_DxBox_GetOption", dxTarget, "crossAlign");
		}
		public static void SetCrossAlign(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxBox_SetOption", dxTarget, "crossAlign", value);
		}
		public static string GetDirection(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_DxBox_GetOption", dxTarget, "direction");
		}
		public static void SetDirection(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxBox_SetOption", dxTarget, "direction", value);
		}
	}
	public class DxButtonInterop: WidgetInterop
	{
		public static event EventHandler<JQueryEventArgs> Click;
		public static void Init(ElementRef dxTarget, DevExpress.Ui.DxButtonOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxButton_Init", dxTarget, json);
		}
		[JSInvokable("DevExpress.Ui.DxButtonInterop.OnClick")]
		public static void OnClick(string identifier)
		{
			Click?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static new bool? GetActiveStateEnabled(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_DxButton_GetOption", dxTarget, "activeStateEnabled");
		}
		public static new void SetActiveStateEnabled(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxButton_SetOption", dxTarget, "activeStateEnabled", value);
		}
		public static new bool? GetFocusStateEnabled(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_DxButton_GetOption", dxTarget, "focusStateEnabled");
		}
		public static new void SetFocusStateEnabled(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxButton_SetOption", dxTarget, "focusStateEnabled", value);
		}
		public static new bool? GetHoverStateEnabled(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_DxButton_GetOption", dxTarget, "hoverStateEnabled");
		}
		public static new void SetHoverStateEnabled(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxButton_SetOption", dxTarget, "hoverStateEnabled", value);
		}
		public static string GetIcon(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_DxButton_GetOption", dxTarget, "icon");
		}
		public static void SetIcon(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxButton_SetOption", dxTarget, "icon", value);
		}
		public static object GetTemplate(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxButton_GetOption", dxTarget, "template");
		}
		public static void SetTemplate(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxButton_SetOption", dxTarget, "template", value);
		}
		public static string GetText(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_DxButton_GetOption", dxTarget, "text");
		}
		public static void SetText(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxButton_SetOption", dxTarget, "text", value);
		}
		public static string GetType(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_DxButton_GetOption", dxTarget, "type");
		}
		public static void SetType(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxButton_SetOption", dxTarget, "type", value);
		}
		public static bool? GetUseSubmitBehavior(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_DxButton_GetOption", dxTarget, "useSubmitBehavior");
		}
		public static void SetUseSubmitBehavior(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxButton_SetOption", dxTarget, "useSubmitBehavior", value);
		}
		public static string GetValidationGroup(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_DxButton_GetOption", dxTarget, "validationGroup");
		}
		public static void SetValidationGroup(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxButton_SetOption", dxTarget, "validationGroup", value);
		}
	}
	public class DxCalendarInterop: EditorInterop
	{
		public static void Init(ElementRef dxTarget, DevExpress.Ui.DxCalendarOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxCalendar_Init", dxTarget, json);
		}
		public static new bool? GetActiveStateEnabled(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_DxCalendar_GetOption", dxTarget, "activeStateEnabled");
		}
		public static new void SetActiveStateEnabled(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxCalendar_SetOption", dxTarget, "activeStateEnabled", value);
		}
		public static object GetCellTemplate(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxCalendar_GetOption", dxTarget, "cellTemplate");
		}
		public static void SetCellTemplate(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxCalendar_SetOption", dxTarget, "cellTemplate", value);
		}
		public static string GetDateSerializationFormat(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_DxCalendar_GetOption", dxTarget, "dateSerializationFormat");
		}
		public static void SetDateSerializationFormat(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxCalendar_SetOption", dxTarget, "dateSerializationFormat", value);
		}
		public static object GetDisabledDates(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxCalendar_GetOption", dxTarget, "disabledDates");
		}
		public static void SetDisabledDates(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxCalendar_SetOption", dxTarget, "disabledDates", value);
		}
		public static object GetFirstDayOfWeek(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxCalendar_GetOption", dxTarget, "firstDayOfWeek");
		}
		public static void SetFirstDayOfWeek(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxCalendar_SetOption", dxTarget, "firstDayOfWeek", value);
		}
		public static new bool? GetFocusStateEnabled(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_DxCalendar_GetOption", dxTarget, "focusStateEnabled");
		}
		public static new void SetFocusStateEnabled(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxCalendar_SetOption", dxTarget, "focusStateEnabled", value);
		}
		public static new bool? GetHoverStateEnabled(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_DxCalendar_GetOption", dxTarget, "hoverStateEnabled");
		}
		public static new void SetHoverStateEnabled(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxCalendar_SetOption", dxTarget, "hoverStateEnabled", value);
		}
		public static object GetMax(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxCalendar_GetOption", dxTarget, "max");
		}
		public static void SetMax(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxCalendar_SetOption", dxTarget, "max", value);
		}
		public static string GetMaxZoomLevel(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_DxCalendar_GetOption", dxTarget, "maxZoomLevel");
		}
		public static void SetMaxZoomLevel(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxCalendar_SetOption", dxTarget, "maxZoomLevel", value);
		}
		public static object GetMin(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxCalendar_GetOption", dxTarget, "min");
		}
		public static void SetMin(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxCalendar_SetOption", dxTarget, "min", value);
		}
		public static string GetMinZoomLevel(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_DxCalendar_GetOption", dxTarget, "minZoomLevel");
		}
		public static void SetMinZoomLevel(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxCalendar_SetOption", dxTarget, "minZoomLevel", value);
		}
		public static string GetName(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_DxCalendar_GetOption", dxTarget, "name");
		}
		public static void SetName(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxCalendar_SetOption", dxTarget, "name", value);
		}
		public static bool? GetShowTodayButton(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_DxCalendar_GetOption", dxTarget, "showTodayButton");
		}
		public static void SetShowTodayButton(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxCalendar_SetOption", dxTarget, "showTodayButton", value);
		}
		public static new object GetValue(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxCalendar_GetOption", dxTarget, "value");
		}
		public static new void SetValue(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxCalendar_SetOption", dxTarget, "value", value);
		}
		public static string GetZoomLevel(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_DxCalendar_GetOption", dxTarget, "zoomLevel");
		}
		public static void SetZoomLevel(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxCalendar_SetOption", dxTarget, "zoomLevel", value);
		}
	}
	public class DxCheckBoxInterop: EditorInterop
	{
		public static void Init(ElementRef dxTarget, DevExpress.Ui.DxCheckBoxOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxCheckBox_Init", dxTarget, json);
		}
		public static new bool? GetActiveStateEnabled(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_DxCheckBox_GetOption", dxTarget, "activeStateEnabled");
		}
		public static new void SetActiveStateEnabled(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxCheckBox_SetOption", dxTarget, "activeStateEnabled", value);
		}
		public static new bool? GetFocusStateEnabled(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_DxCheckBox_GetOption", dxTarget, "focusStateEnabled");
		}
		public static new void SetFocusStateEnabled(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxCheckBox_SetOption", dxTarget, "focusStateEnabled", value);
		}
		public static new bool? GetHoverStateEnabled(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_DxCheckBox_GetOption", dxTarget, "hoverStateEnabled");
		}
		public static new void SetHoverStateEnabled(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxCheckBox_SetOption", dxTarget, "hoverStateEnabled", value);
		}
		public static string GetName(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_DxCheckBox_GetOption", dxTarget, "name");
		}
		public static void SetName(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxCheckBox_SetOption", dxTarget, "name", value);
		}
		public static string GetText(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_DxCheckBox_GetOption", dxTarget, "text");
		}
		public static void SetText(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxCheckBox_SetOption", dxTarget, "text", value);
		}
		public static new bool? GetValue(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_DxCheckBox_GetOption", dxTarget, "value");
		}
		public static new void SetValue(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxCheckBox_SetOption", dxTarget, "value", value);
		}
	}
	public class DxColorBoxInterop: DxDropDownEditorInterop
	{
		public static void Init(ElementRef dxTarget, DevExpress.Ui.DxColorBoxOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxColorBox_Init", dxTarget, json);
		}
		public static string GetApplyButtonText(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_DxColorBox_GetOption", dxTarget, "applyButtonText");
		}
		public static void SetApplyButtonText(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxColorBox_SetOption", dxTarget, "applyButtonText", value);
		}
		public static new string GetApplyValueMode(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_DxColorBox_GetOption", dxTarget, "applyValueMode");
		}
		public static new void SetApplyValueMode(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxColorBox_SetOption", dxTarget, "applyValueMode", value);
		}
		public static string GetCancelButtonText(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_DxColorBox_GetOption", dxTarget, "cancelButtonText");
		}
		public static void SetCancelButtonText(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxColorBox_SetOption", dxTarget, "cancelButtonText", value);
		}
		public static bool? GetEditAlphaChannel(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_DxColorBox_GetOption", dxTarget, "editAlphaChannel");
		}
		public static void SetEditAlphaChannel(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxColorBox_SetOption", dxTarget, "editAlphaChannel", value);
		}
		public static object GetFieldTemplate(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxColorBox_GetOption", dxTarget, "fieldTemplate");
		}
		public static void SetFieldTemplate(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxColorBox_SetOption", dxTarget, "fieldTemplate", value);
		}
		public static float? GetKeyStep(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<float?>("BlazorDevExtreme_DxColorBox_GetOption", dxTarget, "keyStep");
		}
		public static void SetKeyStep(ElementRef dxTarget, float? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxColorBox_SetOption", dxTarget, "keyStep", value);
		}
		public static new string GetValue(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_DxColorBox_GetOption", dxTarget, "value");
		}
		public static new void SetValue(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxColorBox_SetOption", dxTarget, "value", value);
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
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxContextMenu_Init", dxTarget, json);
		}
		[JSInvokable("DevExpress.Ui.DxContextMenuInterop.OnHidden")]
		public static void OnHidden(string identifier)
		{
			Hidden?.Invoke(null, new JQueryEventArgs(identifier));
		}
		[JSInvokable("DevExpress.Ui.DxContextMenuInterop.OnHiding")]
		public static void OnHiding(string identifier)
		{
			Hiding?.Invoke(null, new JQueryEventArgs(identifier));
		}
		[JSInvokable("DevExpress.Ui.DxContextMenuInterop.OnPositioning")]
		public static void OnPositioning(string identifier)
		{
			Positioning?.Invoke(null, new JQueryEventArgs(identifier));
		}
		[JSInvokable("DevExpress.Ui.DxContextMenuInterop.OnShowing")]
		public static void OnShowing(string identifier)
		{
			Showing?.Invoke(null, new JQueryEventArgs(identifier));
		}
		[JSInvokable("DevExpress.Ui.DxContextMenuInterop.OnShown")]
		public static void OnShown(string identifier)
		{
			Shown?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static object GetCloseOnOutsideClick(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxContextMenu_GetOption", dxTarget, "closeOnOutsideClick");
		}
		public static void SetCloseOnOutsideClick(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxContextMenu_SetOption", dxTarget, "closeOnOutsideClick", value);
		}
		public static new object GetItems(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxContextMenu_GetOption", dxTarget, "items");
		}
		public static new void SetItems(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxContextMenu_SetOption", dxTarget, "items", value);
		}
		public static object GetPosition(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxContextMenu_GetOption", dxTarget, "position");
		}
		public static void SetPosition(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxContextMenu_SetOption", dxTarget, "position", value);
		}
		public static object GetShowEvent(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxContextMenu_GetOption", dxTarget, "showEvent");
		}
		public static void SetShowEvent(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxContextMenu_SetOption", dxTarget, "showEvent", value);
		}
		public static string GetSubmenuDirection(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_DxContextMenu_GetOption", dxTarget, "submenuDirection");
		}
		public static void SetSubmenuDirection(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxContextMenu_SetOption", dxTarget, "submenuDirection", value);
		}
		public static object GetTarget(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxContextMenu_GetOption", dxTarget, "target");
		}
		public static void SetTarget(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxContextMenu_SetOption", dxTarget, "target", value);
		}
		public static new bool? GetVisible(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_DxContextMenu_GetOption", dxTarget, "visible");
		}
		public static new void SetVisible(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxContextMenu_SetOption", dxTarget, "visible", value);
		}
		public static object Hide(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxContextMenu_hide_0", dxTarget);
		}
		public static object Show(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxContextMenu_show_1", dxTarget);
		}
		public static object Toggle(ElementRef dxTarget, bool showing)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxContextMenu_toggle_2", dxTarget, showing);
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
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_GridBase_Init", dxTarget, json);
		}
		[JSInvokable("DevExpress.Ui.GridBaseInterop.OnAdaptiveDetailRowPreparing")]
		public static void OnAdaptiveDetailRowPreparing(string identifier)
		{
			AdaptiveDetailRowPreparing?.Invoke(null, new JQueryEventArgs(identifier));
		}
		[JSInvokable("DevExpress.Ui.GridBaseInterop.OnDataErrorOccurred")]
		public static void OnDataErrorOccurred(string identifier)
		{
			DataErrorOccurred?.Invoke(null, new JQueryEventArgs(identifier));
		}
		[JSInvokable("DevExpress.Ui.GridBaseInterop.OnInitNewRow")]
		public static void OnInitNewRow(string identifier)
		{
			InitNewRow?.Invoke(null, new JQueryEventArgs(identifier));
		}
		[JSInvokable("DevExpress.Ui.GridBaseInterop.OnKeyDown")]
		public static void OnKeyDown(string identifier)
		{
			KeyDown?.Invoke(null, new JQueryEventArgs(identifier));
		}
		[JSInvokable("DevExpress.Ui.GridBaseInterop.OnRowCollapsed")]
		public static void OnRowCollapsed(string identifier)
		{
			RowCollapsed?.Invoke(null, new JQueryEventArgs(identifier));
		}
		[JSInvokable("DevExpress.Ui.GridBaseInterop.OnRowCollapsing")]
		public static void OnRowCollapsing(string identifier)
		{
			RowCollapsing?.Invoke(null, new JQueryEventArgs(identifier));
		}
		[JSInvokable("DevExpress.Ui.GridBaseInterop.OnRowExpanded")]
		public static void OnRowExpanded(string identifier)
		{
			RowExpanded?.Invoke(null, new JQueryEventArgs(identifier));
		}
		[JSInvokable("DevExpress.Ui.GridBaseInterop.OnRowExpanding")]
		public static void OnRowExpanding(string identifier)
		{
			RowExpanding?.Invoke(null, new JQueryEventArgs(identifier));
		}
		[JSInvokable("DevExpress.Ui.GridBaseInterop.OnRowInserted")]
		public static void OnRowInserted(string identifier)
		{
			RowInserted?.Invoke(null, new JQueryEventArgs(identifier));
		}
		[JSInvokable("DevExpress.Ui.GridBaseInterop.OnRowInserting")]
		public static void OnRowInserting(string identifier)
		{
			RowInserting?.Invoke(null, new JQueryEventArgs(identifier));
		}
		[JSInvokable("DevExpress.Ui.GridBaseInterop.OnRowRemoved")]
		public static void OnRowRemoved(string identifier)
		{
			RowRemoved?.Invoke(null, new JQueryEventArgs(identifier));
		}
		[JSInvokable("DevExpress.Ui.GridBaseInterop.OnRowRemoving")]
		public static void OnRowRemoving(string identifier)
		{
			RowRemoving?.Invoke(null, new JQueryEventArgs(identifier));
		}
		[JSInvokable("DevExpress.Ui.GridBaseInterop.OnRowUpdated")]
		public static void OnRowUpdated(string identifier)
		{
			RowUpdated?.Invoke(null, new JQueryEventArgs(identifier));
		}
		[JSInvokable("DevExpress.Ui.GridBaseInterop.OnRowUpdating")]
		public static void OnRowUpdating(string identifier)
		{
			RowUpdating?.Invoke(null, new JQueryEventArgs(identifier));
		}
		[JSInvokable("DevExpress.Ui.GridBaseInterop.OnRowValidating")]
		public static void OnRowValidating(string identifier)
		{
			RowValidating?.Invoke(null, new JQueryEventArgs(identifier));
		}
		[JSInvokable("DevExpress.Ui.GridBaseInterop.OnSelectionChanged")]
		public static void OnSelectionChanged(string identifier)
		{
			SelectionChanged?.Invoke(null, new JQueryEventArgs(identifier));
		}
		[JSInvokable("DevExpress.Ui.GridBaseInterop.OnToolbarPreparing")]
		public static void OnToolbarPreparing(string identifier)
		{
			ToolbarPreparing?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static bool? GetAllowColumnReordering(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_GridBase_GetOption", dxTarget, "allowColumnReordering");
		}
		public static void SetAllowColumnReordering(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_GridBase_SetOption", dxTarget, "allowColumnReordering", value);
		}
		public static bool? GetAllowColumnResizing(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_GridBase_GetOption", dxTarget, "allowColumnResizing");
		}
		public static void SetAllowColumnResizing(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_GridBase_SetOption", dxTarget, "allowColumnResizing", value);
		}
		public static bool? GetCacheEnabled(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_GridBase_GetOption", dxTarget, "cacheEnabled");
		}
		public static void SetCacheEnabled(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_GridBase_SetOption", dxTarget, "cacheEnabled", value);
		}
		public static bool? GetCellHintEnabled(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_GridBase_GetOption", dxTarget, "cellHintEnabled");
		}
		public static void SetCellHintEnabled(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_GridBase_SetOption", dxTarget, "cellHintEnabled", value);
		}
		public static bool? GetColumnAutoWidth(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_GridBase_GetOption", dxTarget, "columnAutoWidth");
		}
		public static void SetColumnAutoWidth(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_GridBase_SetOption", dxTarget, "columnAutoWidth", value);
		}
		public static object GetColumnChooser(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_GridBase_GetOption", dxTarget, "columnChooser");
		}
		public static void SetColumnChooser(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_GridBase_SetOption", dxTarget, "columnChooser", value);
		}
		public static object GetColumnFixing(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_GridBase_GetOption", dxTarget, "columnFixing");
		}
		public static void SetColumnFixing(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_GridBase_SetOption", dxTarget, "columnFixing", value);
		}
		public static bool? GetColumnHidingEnabled(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_GridBase_GetOption", dxTarget, "columnHidingEnabled");
		}
		public static void SetColumnHidingEnabled(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_GridBase_SetOption", dxTarget, "columnHidingEnabled", value);
		}
		public static float? GetColumnMinWidth(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<float?>("BlazorDevExtreme_GridBase_GetOption", dxTarget, "columnMinWidth");
		}
		public static void SetColumnMinWidth(ElementRef dxTarget, float? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_GridBase_SetOption", dxTarget, "columnMinWidth", value);
		}
		public static string GetColumnResizingMode(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_GridBase_GetOption", dxTarget, "columnResizingMode");
		}
		public static void SetColumnResizingMode(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_GridBase_SetOption", dxTarget, "columnResizingMode", value);
		}
		public static object GetColumns(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_GridBase_GetOption", dxTarget, "columns");
		}
		public static void SetColumns(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_GridBase_SetOption", dxTarget, "columns", value);
		}
		public static float? GetColumnWidth(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<float?>("BlazorDevExtreme_GridBase_GetOption", dxTarget, "columnWidth");
		}
		public static void SetColumnWidth(ElementRef dxTarget, float? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_GridBase_SetOption", dxTarget, "columnWidth", value);
		}
		public static object GetDataSource(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_GridBase_GetOption", dxTarget, "dataSource");
		}
		public static void SetDataSource(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_GridBase_SetOption", dxTarget, "dataSource", value);
		}
		public static string GetDateSerializationFormat(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_GridBase_GetOption", dxTarget, "dateSerializationFormat");
		}
		public static void SetDateSerializationFormat(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_GridBase_SetOption", dxTarget, "dateSerializationFormat", value);
		}
		public static object GetEditing(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_GridBase_GetOption", dxTarget, "editing");
		}
		public static void SetEditing(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_GridBase_SetOption", dxTarget, "editing", value);
		}
		public static bool? GetErrorRowEnabled(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_GridBase_GetOption", dxTarget, "errorRowEnabled");
		}
		public static void SetErrorRowEnabled(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_GridBase_SetOption", dxTarget, "errorRowEnabled", value);
		}
		public static object GetFilterBuilder(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_GridBase_GetOption", dxTarget, "filterBuilder");
		}
		public static void SetFilterBuilder(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_GridBase_SetOption", dxTarget, "filterBuilder", value);
		}
		public static object GetFilterBuilderPopup(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_GridBase_GetOption", dxTarget, "filterBuilderPopup");
		}
		public static void SetFilterBuilderPopup(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_GridBase_SetOption", dxTarget, "filterBuilderPopup", value);
		}
		public static object GetFilterPanel(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_GridBase_GetOption", dxTarget, "filterPanel");
		}
		public static void SetFilterPanel(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_GridBase_SetOption", dxTarget, "filterPanel", value);
		}
		public static object GetFilterRow(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_GridBase_GetOption", dxTarget, "filterRow");
		}
		public static void SetFilterRow(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_GridBase_SetOption", dxTarget, "filterRow", value);
		}
		public static object GetFilterSyncEnabled(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_GridBase_GetOption", dxTarget, "filterSyncEnabled");
		}
		public static void SetFilterSyncEnabled(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_GridBase_SetOption", dxTarget, "filterSyncEnabled", value);
		}
		public static object GetFilterValue(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_GridBase_GetOption", dxTarget, "filterValue");
		}
		public static void SetFilterValue(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_GridBase_SetOption", dxTarget, "filterValue", value);
		}
		public static object GetHeaderFilter(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_GridBase_GetOption", dxTarget, "headerFilter");
		}
		public static void SetHeaderFilter(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_GridBase_SetOption", dxTarget, "headerFilter", value);
		}
		public static object GetLoadPanel(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_GridBase_GetOption", dxTarget, "loadPanel");
		}
		public static void SetLoadPanel(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_GridBase_SetOption", dxTarget, "loadPanel", value);
		}
		public static string GetNoDataText(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_GridBase_GetOption", dxTarget, "noDataText");
		}
		public static void SetNoDataText(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_GridBase_SetOption", dxTarget, "noDataText", value);
		}
		public static object GetPager(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_GridBase_GetOption", dxTarget, "pager");
		}
		public static void SetPager(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_GridBase_SetOption", dxTarget, "pager", value);
		}
		public static object GetPaging(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_GridBase_GetOption", dxTarget, "paging");
		}
		public static void SetPaging(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_GridBase_SetOption", dxTarget, "paging", value);
		}
		public static bool? GetRowAlternationEnabled(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_GridBase_GetOption", dxTarget, "rowAlternationEnabled");
		}
		public static void SetRowAlternationEnabled(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_GridBase_SetOption", dxTarget, "rowAlternationEnabled", value);
		}
		public static object GetScrolling(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_GridBase_GetOption", dxTarget, "scrolling");
		}
		public static void SetScrolling(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_GridBase_SetOption", dxTarget, "scrolling", value);
		}
		public static object GetSearchPanel(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_GridBase_GetOption", dxTarget, "searchPanel");
		}
		public static void SetSearchPanel(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_GridBase_SetOption", dxTarget, "searchPanel", value);
		}
		public static object GetSelectedRowKeys(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_GridBase_GetOption", dxTarget, "selectedRowKeys");
		}
		public static void SetSelectedRowKeys(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_GridBase_SetOption", dxTarget, "selectedRowKeys", value);
		}
		public static object GetSelection(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_GridBase_GetOption", dxTarget, "selection");
		}
		public static void SetSelection(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_GridBase_SetOption", dxTarget, "selection", value);
		}
		public static bool? GetShowBorders(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_GridBase_GetOption", dxTarget, "showBorders");
		}
		public static void SetShowBorders(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_GridBase_SetOption", dxTarget, "showBorders", value);
		}
		public static bool? GetShowColumnHeaders(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_GridBase_GetOption", dxTarget, "showColumnHeaders");
		}
		public static void SetShowColumnHeaders(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_GridBase_SetOption", dxTarget, "showColumnHeaders", value);
		}
		public static bool? GetShowColumnLines(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_GridBase_GetOption", dxTarget, "showColumnLines");
		}
		public static void SetShowColumnLines(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_GridBase_SetOption", dxTarget, "showColumnLines", value);
		}
		public static bool? GetShowRowLines(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_GridBase_GetOption", dxTarget, "showRowLines");
		}
		public static void SetShowRowLines(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_GridBase_SetOption", dxTarget, "showRowLines", value);
		}
		public static object GetSorting(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_GridBase_GetOption", dxTarget, "sorting");
		}
		public static void SetSorting(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_GridBase_SetOption", dxTarget, "sorting", value);
		}
		public static object GetStateStoring(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_GridBase_GetOption", dxTarget, "stateStoring");
		}
		public static void SetStateStoring(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_GridBase_SetOption", dxTarget, "stateStoring", value);
		}
		public static bool? GetTwoWayBindingEnabled(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_GridBase_GetOption", dxTarget, "twoWayBindingEnabled");
		}
		public static void SetTwoWayBindingEnabled(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_GridBase_SetOption", dxTarget, "twoWayBindingEnabled", value);
		}
		public static bool? GetWordWrapEnabled(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_GridBase_GetOption", dxTarget, "wordWrapEnabled");
		}
		public static void SetWordWrapEnabled(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_GridBase_SetOption", dxTarget, "wordWrapEnabled", value);
		}
		public static void BeginCustomLoading(ElementRef dxTarget, string messageText)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_GridBase_beginCustomLoading_0", dxTarget, messageText);
		}
		public static object ByKey(ElementRef dxTarget, object key)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_GridBase_byKey_1", dxTarget, key);
		}
		public static void CancelEditData(ElementRef dxTarget)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_GridBase_cancelEditData_2", dxTarget);
		}
		public static object CellValue(ElementRef dxTarget, float rowIndex, string dataField)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_GridBase_cellValue_3", dxTarget, rowIndex, dataField);
		}
		public static void CellValue(ElementRef dxTarget, float rowIndex, string dataField, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_GridBase_cellValue_4", dxTarget, rowIndex, dataField, value);
		}
		public static object CellValue(ElementRef dxTarget, float rowIndex, float visibleColumnIndex)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_GridBase_cellValue_5", dxTarget, rowIndex, visibleColumnIndex);
		}
		public static void CellValue(ElementRef dxTarget, float rowIndex, float visibleColumnIndex, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_GridBase_cellValue_6", dxTarget, rowIndex, visibleColumnIndex, value);
		}
		public static void ClearFilter(ElementRef dxTarget)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_GridBase_clearFilter_7", dxTarget);
		}
		public static void ClearFilter(ElementRef dxTarget, string filterName)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_GridBase_clearFilter_8", dxTarget, filterName);
		}
		public static void ClearSelection(ElementRef dxTarget)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_GridBase_clearSelection_9", dxTarget);
		}
		public static void ClearSorting(ElementRef dxTarget)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_GridBase_clearSorting_10", dxTarget);
		}
		public static void CloseEditCell(ElementRef dxTarget)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_GridBase_closeEditCell_11", dxTarget);
		}
		public static void CollapseAdaptiveDetailRow(ElementRef dxTarget)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_GridBase_collapseAdaptiveDetailRow_12", dxTarget);
		}
		public static float ColumnCount(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<float>("BlazorDevExtreme_GridBase_columnCount_13", dxTarget);
		}
		public static object ColumnOption(ElementRef dxTarget, object id)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_GridBase_columnOption_14", dxTarget, id);
		}
		public static object ColumnOption(ElementRef dxTarget, object id, string optionName)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_GridBase_columnOption_15", dxTarget, id, optionName);
		}
		public static void ColumnOption(ElementRef dxTarget, object id, string optionName, object optionValue)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_GridBase_columnOption_16", dxTarget, id, optionName, optionValue);
		}
		public static void ColumnOption(ElementRef dxTarget, object id, object options)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_GridBase_columnOption_17", dxTarget, id, options);
		}
		public static void DeleteColumn(ElementRef dxTarget, object id)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_GridBase_deleteColumn_18", dxTarget, id);
		}
		public static void DeleteRow(ElementRef dxTarget, float rowIndex)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_GridBase_deleteRow_19", dxTarget, rowIndex);
		}
		public static object DeselectAll(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_GridBase_deselectAll_20", dxTarget);
		}
		public static object DeselectRows(ElementRef dxTarget, object keys)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_GridBase_deselectRows_21", dxTarget, keys);
		}
		public static void EditCell(ElementRef dxTarget, float rowIndex, string dataField)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_GridBase_editCell_22", dxTarget, rowIndex, dataField);
		}
		public static void EditCell(ElementRef dxTarget, float rowIndex, float visibleColumnIndex)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_GridBase_editCell_23", dxTarget, rowIndex, visibleColumnIndex);
		}
		public static void EditRow(ElementRef dxTarget, float rowIndex)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_GridBase_editRow_24", dxTarget, rowIndex);
		}
		public static void EndCustomLoading(ElementRef dxTarget)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_GridBase_endCustomLoading_25", dxTarget);
		}
		public static void ExpandAdaptiveDetailRow(ElementRef dxTarget, object key)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_GridBase_expandAdaptiveDetailRow_26", dxTarget, key);
		}
		public static object Filter(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_GridBase_filter_27", dxTarget);
		}
		public static void Filter(ElementRef dxTarget, object filterExpr)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_GridBase_filter_28", dxTarget, filterExpr);
		}
		public static void Focus(ElementRef dxTarget)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_GridBase_focus_29", dxTarget);
		}
		public static void Focus(ElementRef dxTarget, object element)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_GridBase_focus_30", dxTarget, element);
		}
		public static object GetCellElement(ElementRef dxTarget, float rowIndex, string dataField)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_GridBase_getCellElement_31", dxTarget, rowIndex, dataField);
		}
		public static object GetCellElement(ElementRef dxTarget, float rowIndex, float visibleColumnIndex)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_GridBase_getCellElement_32", dxTarget, rowIndex, visibleColumnIndex);
		}
		public static object GetCombinedFilter(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_GridBase_getCombinedFilter_33", dxTarget);
		}
		public static object GetCombinedFilter(ElementRef dxTarget, bool returnDataField)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_GridBase_getCombinedFilter_34", dxTarget, returnDataField);
		}
		public static object GetDataSourceEx(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_GridBase_getDataSource_35", dxTarget);
		}
		public static object GetKeyByRowIndex(ElementRef dxTarget, float rowIndex)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_GridBase_getKeyByRowIndex_36", dxTarget, rowIndex);
		}
		public static object GetRowElement(ElementRef dxTarget, float rowIndex)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_GridBase_getRowElement_37", dxTarget, rowIndex);
		}
		public static float GetRowIndexByKey(ElementRef dxTarget, object key)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<float>("BlazorDevExtreme_GridBase_getRowIndexByKey_38", dxTarget, key);
		}
		public static object GetScrollable(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_GridBase_getScrollable_39", dxTarget);
		}
		public static bool HasEditData(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool>("BlazorDevExtreme_GridBase_hasEditData_40", dxTarget);
		}
		public static void HideColumnChooser(ElementRef dxTarget)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_GridBase_hideColumnChooser_41", dxTarget);
		}
		public static void IsAdaptiveDetailRowExpanded(ElementRef dxTarget, object key)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_GridBase_isAdaptiveDetailRowExpanded_42", dxTarget, key);
		}
		public static bool IsRowSelected(ElementRef dxTarget, object key)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool>("BlazorDevExtreme_GridBase_isRowSelected_43", dxTarget, key);
		}
		public static object KeyOf(ElementRef dxTarget, object obj)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_GridBase_keyOf_44", dxTarget, obj);
		}
		public static float PageCount(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<float>("BlazorDevExtreme_GridBase_pageCount_45", dxTarget);
		}
		public static float PageIndex(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<float>("BlazorDevExtreme_GridBase_pageIndex_46", dxTarget);
		}
		public static object PageIndex(ElementRef dxTarget, float newIndex)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_GridBase_pageIndex_47", dxTarget, newIndex);
		}
		public static float PageSize(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<float>("BlazorDevExtreme_GridBase_pageSize_48", dxTarget);
		}
		public static void PageSize(ElementRef dxTarget, float value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_GridBase_pageSize_49", dxTarget, value);
		}
		public static object Refresh(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_GridBase_refresh_50", dxTarget);
		}
		public static void RepaintRows(ElementRef dxTarget, object rowIndexes)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_GridBase_repaintRows_51", dxTarget, rowIndexes);
		}
		public static object SaveEditData(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_GridBase_saveEditData_52", dxTarget);
		}
		public static void SearchByText(ElementRef dxTarget, string text)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_GridBase_searchByText_53", dxTarget, text);
		}
		public static object SelectAll(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_GridBase_selectAll_54", dxTarget);
		}
		public static object SelectRows(ElementRef dxTarget, object keys, bool preserve)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_GridBase_selectRows_55", dxTarget, keys, preserve);
		}
		public static object SelectRowsByIndexes(ElementRef dxTarget, object indexes)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_GridBase_selectRowsByIndexes_56", dxTarget, indexes);
		}
		public static void ShowColumnChooser(ElementRef dxTarget)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_GridBase_showColumnChooser_57", dxTarget);
		}
		public static object State(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_GridBase_state_58", dxTarget);
		}
		public static void State(ElementRef dxTarget, object state)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_GridBase_state_59", dxTarget, state);
		}
		public static void UndeleteRow(ElementRef dxTarget, float rowIndex)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_GridBase_undeleteRow_60", dxTarget, rowIndex);
		}
		public static void UpdateDimensions(ElementRef dxTarget)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_GridBase_updateDimensions_61", dxTarget);
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
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxDataGrid_Init", dxTarget, json);
		}
		[JSInvokable("DevExpress.Ui.DxDataGridInterop.OnCellClick")]
		public static void OnCellClick(string identifier)
		{
			CellClick?.Invoke(null, new JQueryEventArgs(identifier));
		}
		[JSInvokable("DevExpress.Ui.DxDataGridInterop.OnCellHoverChanged")]
		public static void OnCellHoverChanged(string identifier)
		{
			CellHoverChanged?.Invoke(null, new JQueryEventArgs(identifier));
		}
		[JSInvokable("DevExpress.Ui.DxDataGridInterop.OnCellPrepared")]
		public static void OnCellPrepared(string identifier)
		{
			CellPrepared?.Invoke(null, new JQueryEventArgs(identifier));
		}
		[JSInvokable("DevExpress.Ui.DxDataGridInterop.OnContextMenuPreparing")]
		public static void OnContextMenuPreparing(string identifier)
		{
			ContextMenuPreparing?.Invoke(null, new JQueryEventArgs(identifier));
		}
		[JSInvokable("DevExpress.Ui.DxDataGridInterop.OnEditingStart")]
		public static void OnEditingStart(string identifier)
		{
			EditingStart?.Invoke(null, new JQueryEventArgs(identifier));
		}
		[JSInvokable("DevExpress.Ui.DxDataGridInterop.OnEditorPrepared")]
		public static void OnEditorPrepared(string identifier)
		{
			EditorPrepared?.Invoke(null, new JQueryEventArgs(identifier));
		}
		[JSInvokable("DevExpress.Ui.DxDataGridInterop.OnEditorPreparing")]
		public static void OnEditorPreparing(string identifier)
		{
			EditorPreparing?.Invoke(null, new JQueryEventArgs(identifier));
		}
		[JSInvokable("DevExpress.Ui.DxDataGridInterop.OnExported")]
		public static void OnExported(string identifier)
		{
			Exported?.Invoke(null, new JQueryEventArgs(identifier));
		}
		[JSInvokable("DevExpress.Ui.DxDataGridInterop.OnExporting")]
		public static void OnExporting(string identifier)
		{
			Exporting?.Invoke(null, new JQueryEventArgs(identifier));
		}
		[JSInvokable("DevExpress.Ui.DxDataGridInterop.OnFileSaving")]
		public static void OnFileSaving(string identifier)
		{
			FileSaving?.Invoke(null, new JQueryEventArgs(identifier));
		}
		[JSInvokable("DevExpress.Ui.DxDataGridInterop.OnRowClick")]
		public static void OnRowClick(string identifier)
		{
			RowClick?.Invoke(null, new JQueryEventArgs(identifier));
		}
		[JSInvokable("DevExpress.Ui.DxDataGridInterop.OnRowPrepared")]
		public static void OnRowPrepared(string identifier)
		{
			RowPrepared?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static new object GetColumns(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxDataGrid_GetOption", dxTarget, "columns");
		}
		public static new void SetColumns(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxDataGrid_SetOption", dxTarget, "columns", value);
		}
		public static object GetCustomizeColumns(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxDataGrid_GetOption", dxTarget, "customizeColumns");
		}
		public static void SetCustomizeColumns(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxDataGrid_SetOption", dxTarget, "customizeColumns", value);
		}
		public static object GetCustomizeExportData(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxDataGrid_GetOption", dxTarget, "customizeExportData");
		}
		public static void SetCustomizeExportData(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxDataGrid_SetOption", dxTarget, "customizeExportData", value);
		}
		public static new object GetEditing(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxDataGrid_GetOption", dxTarget, "editing");
		}
		public static new void SetEditing(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxDataGrid_SetOption", dxTarget, "editing", value);
		}
		public static object GetExport(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxDataGrid_GetOption", dxTarget, "export");
		}
		public static void SetExport(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxDataGrid_SetOption", dxTarget, "export", value);
		}
		public static object GetGrouping(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxDataGrid_GetOption", dxTarget, "grouping");
		}
		public static void SetGrouping(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxDataGrid_SetOption", dxTarget, "grouping", value);
		}
		public static object GetGroupPanel(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxDataGrid_GetOption", dxTarget, "groupPanel");
		}
		public static void SetGroupPanel(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxDataGrid_SetOption", dxTarget, "groupPanel", value);
		}
		public static object GetKeyExpr(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxDataGrid_GetOption", dxTarget, "keyExpr");
		}
		public static void SetKeyExpr(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxDataGrid_SetOption", dxTarget, "keyExpr", value);
		}
		public static object GetMasterDetail(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxDataGrid_GetOption", dxTarget, "masterDetail");
		}
		public static void SetMasterDetail(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxDataGrid_SetOption", dxTarget, "masterDetail", value);
		}
		public static object GetRemoteOperations(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxDataGrid_GetOption", dxTarget, "remoteOperations");
		}
		public static void SetRemoteOperations(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxDataGrid_SetOption", dxTarget, "remoteOperations", value);
		}
		public static object GetRowTemplate(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxDataGrid_GetOption", dxTarget, "rowTemplate");
		}
		public static void SetRowTemplate(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxDataGrid_SetOption", dxTarget, "rowTemplate", value);
		}
		public static new object GetScrolling(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxDataGrid_GetOption", dxTarget, "scrolling");
		}
		public static new void SetScrolling(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxDataGrid_SetOption", dxTarget, "scrolling", value);
		}
		public static new object GetSelection(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxDataGrid_GetOption", dxTarget, "selection");
		}
		public static new void SetSelection(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxDataGrid_SetOption", dxTarget, "selection", value);
		}
		public static object GetSelectionFilter(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxDataGrid_GetOption", dxTarget, "selectionFilter");
		}
		public static void SetSelectionFilter(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxDataGrid_SetOption", dxTarget, "selectionFilter", value);
		}
		public static object GetSortByGroupSummaryInfo(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxDataGrid_GetOption", dxTarget, "sortByGroupSummaryInfo");
		}
		public static void SetSortByGroupSummaryInfo(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxDataGrid_SetOption", dxTarget, "sortByGroupSummaryInfo", value);
		}
		public static object GetSummary(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxDataGrid_GetOption", dxTarget, "summary");
		}
		public static void SetSummary(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxDataGrid_SetOption", dxTarget, "summary", value);
		}
		public static void AddColumn(ElementRef dxTarget, object columnOptions)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxDataGrid_addColumn_0", dxTarget, columnOptions);
		}
		public static void AddRow(ElementRef dxTarget)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxDataGrid_addRow_1", dxTarget);
		}
		public static void ClearGrouping(ElementRef dxTarget)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxDataGrid_clearGrouping_2", dxTarget);
		}
		public static void CollapseAll(ElementRef dxTarget, float groupIndex)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxDataGrid_collapseAll_3", dxTarget, groupIndex);
		}
		public static object CollapseRow(ElementRef dxTarget, object key)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxDataGrid_collapseRow_4", dxTarget, key);
		}
		public static void ExpandAll(ElementRef dxTarget, float groupIndex)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxDataGrid_expandAll_5", dxTarget, groupIndex);
		}
		public static object ExpandRow(ElementRef dxTarget, object key)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxDataGrid_expandRow_6", dxTarget, key);
		}
		public static void ExportToExcel(ElementRef dxTarget, bool selectionOnly)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxDataGrid_exportToExcel_7", dxTarget, selectionOnly);
		}
		public static object GetSelectedRowKeys(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxDataGrid_getSelectedRowKeys_8", dxTarget);
		}
		public static object GetSelectedRowsData(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxDataGrid_getSelectedRowsData_9", dxTarget);
		}
		public static object GetTotalSummaryValue(ElementRef dxTarget, string summaryItemName)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxDataGrid_getTotalSummaryValue_10", dxTarget, summaryItemName);
		}
		public static object GetVisibleColumns(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxDataGrid_getVisibleColumns_11", dxTarget);
		}
		public static object GetVisibleColumns(ElementRef dxTarget, float headerLevel)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxDataGrid_getVisibleColumns_12", dxTarget, headerLevel);
		}
		public static object GetVisibleRows(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxDataGrid_getVisibleRows_13", dxTarget);
		}
		public static void InsertRow(ElementRef dxTarget)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxDataGrid_insertRow_14", dxTarget);
		}
		public static bool IsRowExpanded(ElementRef dxTarget, object key)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool>("BlazorDevExtreme_DxDataGrid_isRowExpanded_15", dxTarget, key);
		}
		public static bool IsRowSelected(ElementRef dxTarget, object data)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool>("BlazorDevExtreme_DxDataGrid_isRowSelected_16", dxTarget, data);
		}
		public static void RemoveRow(ElementRef dxTarget, float rowIndex)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxDataGrid_removeRow_18", dxTarget, rowIndex);
		}
		public static float TotalCount(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<float>("BlazorDevExtreme_DxDataGrid_totalCount_19", dxTarget);
		}
	}
	public class DxDateBoxInterop: DxDropDownEditorInterop
	{
		public static void Init(ElementRef dxTarget, DevExpress.Ui.DxDateBoxOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxDateBox_Init", dxTarget, json);
		}
		public static bool? GetAdaptivityEnabled(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_DxDateBox_GetOption", dxTarget, "adaptivityEnabled");
		}
		public static void SetAdaptivityEnabled(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxDateBox_SetOption", dxTarget, "adaptivityEnabled", value);
		}
		public static string GetApplyButtonText(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_DxDateBox_GetOption", dxTarget, "applyButtonText");
		}
		public static void SetApplyButtonText(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxDateBox_SetOption", dxTarget, "applyButtonText", value);
		}
		public static object GetCalendarOptions(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxDateBox_GetOption", dxTarget, "calendarOptions");
		}
		public static void SetCalendarOptions(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxDateBox_SetOption", dxTarget, "calendarOptions", value);
		}
		public static string GetCancelButtonText(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_DxDateBox_GetOption", dxTarget, "cancelButtonText");
		}
		public static void SetCancelButtonText(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxDateBox_SetOption", dxTarget, "cancelButtonText", value);
		}
		public static string GetDateOutOfRangeMessage(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_DxDateBox_GetOption", dxTarget, "dateOutOfRangeMessage");
		}
		public static void SetDateOutOfRangeMessage(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxDateBox_SetOption", dxTarget, "dateOutOfRangeMessage", value);
		}
		public static string GetDateSerializationFormat(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_DxDateBox_GetOption", dxTarget, "dateSerializationFormat");
		}
		public static void SetDateSerializationFormat(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxDateBox_SetOption", dxTarget, "dateSerializationFormat", value);
		}
		public static object GetDisabledDates(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxDateBox_GetOption", dxTarget, "disabledDates");
		}
		public static void SetDisabledDates(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxDateBox_SetOption", dxTarget, "disabledDates", value);
		}
		public static object GetDisplayFormat(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxDateBox_GetOption", dxTarget, "displayFormat");
		}
		public static void SetDisplayFormat(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxDateBox_SetOption", dxTarget, "displayFormat", value);
		}
		public static float? GetInterval(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<float?>("BlazorDevExtreme_DxDateBox_GetOption", dxTarget, "interval");
		}
		public static void SetInterval(ElementRef dxTarget, float? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxDateBox_SetOption", dxTarget, "interval", value);
		}
		public static string GetInvalidDateMessage(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_DxDateBox_GetOption", dxTarget, "invalidDateMessage");
		}
		public static void SetInvalidDateMessage(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxDateBox_SetOption", dxTarget, "invalidDateMessage", value);
		}
		public static object GetMax(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxDateBox_GetOption", dxTarget, "max");
		}
		public static void SetMax(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxDateBox_SetOption", dxTarget, "max", value);
		}
		public static string GetMaxZoomLevel(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_DxDateBox_GetOption", dxTarget, "maxZoomLevel");
		}
		public static void SetMaxZoomLevel(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxDateBox_SetOption", dxTarget, "maxZoomLevel", value);
		}
		public static object GetMin(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxDateBox_GetOption", dxTarget, "min");
		}
		public static void SetMin(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxDateBox_SetOption", dxTarget, "min", value);
		}
		public static string GetMinZoomLevel(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_DxDateBox_GetOption", dxTarget, "minZoomLevel");
		}
		public static void SetMinZoomLevel(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxDateBox_SetOption", dxTarget, "minZoomLevel", value);
		}
		public static string GetPickerType(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_DxDateBox_GetOption", dxTarget, "pickerType");
		}
		public static void SetPickerType(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxDateBox_SetOption", dxTarget, "pickerType", value);
		}
		public static new string GetPlaceholder(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_DxDateBox_GetOption", dxTarget, "placeholder");
		}
		public static new void SetPlaceholder(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxDateBox_SetOption", dxTarget, "placeholder", value);
		}
		public static bool? GetShowAnalogClock(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_DxDateBox_GetOption", dxTarget, "showAnalogClock");
		}
		public static void SetShowAnalogClock(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxDateBox_SetOption", dxTarget, "showAnalogClock", value);
		}
		public static string GetType(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_DxDateBox_GetOption", dxTarget, "type");
		}
		public static void SetType(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxDateBox_SetOption", dxTarget, "type", value);
		}
		public static new object GetValue(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxDateBox_GetOption", dxTarget, "value");
		}
		public static new void SetValue(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxDateBox_SetOption", dxTarget, "value", value);
		}
		public static void Close(ElementRef dxTarget)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxDateBox_close_0", dxTarget);
		}
		public static void Open(ElementRef dxTarget)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxDateBox_open_1", dxTarget);
		}
	}
	public class DxDeferRenderingInterop: WidgetInterop
	{
		public static event EventHandler<JQueryEventArgs> Rendered;
		public static event EventHandler<JQueryEventArgs> Shown;
		public static void Init(ElementRef dxTarget, DevExpress.Ui.DxDeferRenderingOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxDeferRendering_Init", dxTarget, json);
		}
		[JSInvokable("DevExpress.Ui.DxDeferRenderingInterop.OnRendered")]
		public static void OnRendered(string identifier)
		{
			Rendered?.Invoke(null, new JQueryEventArgs(identifier));
		}
		[JSInvokable("DevExpress.Ui.DxDeferRenderingInterop.OnShown")]
		public static void OnShown(string identifier)
		{
			Shown?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static object GetAnimation(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxDeferRendering_GetOption", dxTarget, "animation");
		}
		public static void SetAnimation(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxDeferRendering_SetOption", dxTarget, "animation", value);
		}
		public static object GetRenderWhen(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxDeferRendering_GetOption", dxTarget, "renderWhen");
		}
		public static void SetRenderWhen(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxDeferRendering_SetOption", dxTarget, "renderWhen", value);
		}
		public static bool? GetShowLoadIndicator(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_DxDeferRendering_GetOption", dxTarget, "showLoadIndicator");
		}
		public static void SetShowLoadIndicator(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxDeferRendering_SetOption", dxTarget, "showLoadIndicator", value);
		}
		public static string GetStaggerItemSelector(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_DxDeferRendering_GetOption", dxTarget, "staggerItemSelector");
		}
		public static void SetStaggerItemSelector(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxDeferRendering_SetOption", dxTarget, "staggerItemSelector", value);
		}
	}
	public class DxDropDownBoxInterop: DxDropDownEditorInterop
	{
		public static void Init(ElementRef dxTarget, DevExpress.Ui.DxDropDownBoxOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxDropDownBox_Init", dxTarget, json);
		}
		public static new bool? GetAcceptCustomValue(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_DxDropDownBox_GetOption", dxTarget, "acceptCustomValue");
		}
		public static new void SetAcceptCustomValue(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxDropDownBox_SetOption", dxTarget, "acceptCustomValue", value);
		}
		public static object GetContentTemplate(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxDropDownBox_GetOption", dxTarget, "contentTemplate");
		}
		public static void SetContentTemplate(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxDropDownBox_SetOption", dxTarget, "contentTemplate", value);
		}
		public static object GetDropDownOptions(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxDropDownBox_GetOption", dxTarget, "dropDownOptions");
		}
		public static void SetDropDownOptions(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxDropDownBox_SetOption", dxTarget, "dropDownOptions", value);
		}
		public static object GetFieldTemplate(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxDropDownBox_GetOption", dxTarget, "fieldTemplate");
		}
		public static void SetFieldTemplate(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxDropDownBox_SetOption", dxTarget, "fieldTemplate", value);
		}
		public static new string GetValueChangeEvent(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_DxDropDownBox_GetOption", dxTarget, "valueChangeEvent");
		}
		public static new void SetValueChangeEvent(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxDropDownBox_SetOption", dxTarget, "valueChangeEvent", value);
		}
		public static object GetDataSourceEx(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxDropDownBox_getDataSource_0", dxTarget);
		}
	}
	public class DxDropDownMenuInterop: WidgetInterop
	{
		public static event EventHandler<JQueryEventArgs> ButtonClick;
		public static event EventHandler<JQueryEventArgs> ItemClick;
		public static void Init(ElementRef dxTarget, DevExpress.Ui.DxDropDownMenuOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxDropDownMenu_Init", dxTarget, json);
		}
		[JSInvokable("DevExpress.Ui.DxDropDownMenuInterop.OnButtonClick")]
		public static void OnButtonClick(string identifier)
		{
			ButtonClick?.Invoke(null, new JQueryEventArgs(identifier));
		}
		[JSInvokable("DevExpress.Ui.DxDropDownMenuInterop.OnItemClick")]
		public static void OnItemClick(string identifier)
		{
			ItemClick?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static new bool? GetActiveStateEnabled(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_DxDropDownMenu_GetOption", dxTarget, "activeStateEnabled");
		}
		public static new void SetActiveStateEnabled(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxDropDownMenu_SetOption", dxTarget, "activeStateEnabled", value);
		}
		public static string GetButtonIcon(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_DxDropDownMenu_GetOption", dxTarget, "buttonIcon");
		}
		public static void SetButtonIcon(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxDropDownMenu_SetOption", dxTarget, "buttonIcon", value);
		}
		public static string GetButtonText(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_DxDropDownMenu_GetOption", dxTarget, "buttonText");
		}
		public static void SetButtonText(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxDropDownMenu_SetOption", dxTarget, "buttonText", value);
		}
		public static object GetDataSource(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxDropDownMenu_GetOption", dxTarget, "dataSource");
		}
		public static void SetDataSource(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxDropDownMenu_SetOption", dxTarget, "dataSource", value);
		}
		public static new bool? GetHoverStateEnabled(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_DxDropDownMenu_GetOption", dxTarget, "hoverStateEnabled");
		}
		public static new void SetHoverStateEnabled(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxDropDownMenu_SetOption", dxTarget, "hoverStateEnabled", value);
		}
		public static object GetItems(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxDropDownMenu_GetOption", dxTarget, "items");
		}
		public static void SetItems(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxDropDownMenu_SetOption", dxTarget, "items", value);
		}
		public static object GetItemTemplate(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxDropDownMenu_GetOption", dxTarget, "itemTemplate");
		}
		public static void SetItemTemplate(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxDropDownMenu_SetOption", dxTarget, "itemTemplate", value);
		}
		public static bool? GetOpened(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_DxDropDownMenu_GetOption", dxTarget, "opened");
		}
		public static void SetOpened(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxDropDownMenu_SetOption", dxTarget, "opened", value);
		}
		public static object GetPopupHeight(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxDropDownMenu_GetOption", dxTarget, "popupHeight");
		}
		public static void SetPopupHeight(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxDropDownMenu_SetOption", dxTarget, "popupHeight", value);
		}
		public static object GetPopupWidth(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxDropDownMenu_GetOption", dxTarget, "popupWidth");
		}
		public static void SetPopupWidth(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxDropDownMenu_SetOption", dxTarget, "popupWidth", value);
		}
		public static bool? GetUsePopover(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_DxDropDownMenu_GetOption", dxTarget, "usePopover");
		}
		public static void SetUsePopover(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxDropDownMenu_SetOption", dxTarget, "usePopover", value);
		}
		public static void Close(ElementRef dxTarget)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxDropDownMenu_close_0", dxTarget);
		}
		public static void Open(ElementRef dxTarget)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxDropDownMenu_open_1", dxTarget);
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
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxFileUploader_Init", dxTarget, json);
		}
		[JSInvokable("DevExpress.Ui.DxFileUploaderInterop.OnProgress")]
		public static void OnProgress(string identifier)
		{
			Progress?.Invoke(null, new JQueryEventArgs(identifier));
		}
		[JSInvokable("DevExpress.Ui.DxFileUploaderInterop.OnUploadAborted")]
		public static void OnUploadAborted(string identifier)
		{
			UploadAborted?.Invoke(null, new JQueryEventArgs(identifier));
		}
		[JSInvokable("DevExpress.Ui.DxFileUploaderInterop.OnUploaded")]
		public static void OnUploaded(string identifier)
		{
			Uploaded?.Invoke(null, new JQueryEventArgs(identifier));
		}
		[JSInvokable("DevExpress.Ui.DxFileUploaderInterop.OnUploadError")]
		public static void OnUploadError(string identifier)
		{
			UploadError?.Invoke(null, new JQueryEventArgs(identifier));
		}
		[JSInvokable("DevExpress.Ui.DxFileUploaderInterop.OnUploadStarted")]
		public static void OnUploadStarted(string identifier)
		{
			UploadStarted?.Invoke(null, new JQueryEventArgs(identifier));
		}
		[JSInvokable("DevExpress.Ui.DxFileUploaderInterop.OnValueChanged")]
		public static void OnValueChanged(string identifier)
		{
			ValueChanged?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static string GetAccept(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_DxFileUploader_GetOption", dxTarget, "accept");
		}
		public static void SetAccept(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxFileUploader_SetOption", dxTarget, "accept", value);
		}
		public static bool? GetAllowCanceling(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_DxFileUploader_GetOption", dxTarget, "allowCanceling");
		}
		public static void SetAllowCanceling(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxFileUploader_SetOption", dxTarget, "allowCanceling", value);
		}
		public static new bool? GetFocusStateEnabled(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_DxFileUploader_GetOption", dxTarget, "focusStateEnabled");
		}
		public static new void SetFocusStateEnabled(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxFileUploader_SetOption", dxTarget, "focusStateEnabled", value);
		}
		public static string GetLabelText(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_DxFileUploader_GetOption", dxTarget, "labelText");
		}
		public static void SetLabelText(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxFileUploader_SetOption", dxTarget, "labelText", value);
		}
		public static bool? GetMultiple(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_DxFileUploader_GetOption", dxTarget, "multiple");
		}
		public static void SetMultiple(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxFileUploader_SetOption", dxTarget, "multiple", value);
		}
		public static string GetName(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_DxFileUploader_GetOption", dxTarget, "name");
		}
		public static void SetName(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxFileUploader_SetOption", dxTarget, "name", value);
		}
		public static float? GetProgress(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<float?>("BlazorDevExtreme_DxFileUploader_GetOption", dxTarget, "progress");
		}
		public static void SetProgress(ElementRef dxTarget, float? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxFileUploader_SetOption", dxTarget, "progress", value);
		}
		public static string GetReadyToUploadMessage(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_DxFileUploader_GetOption", dxTarget, "readyToUploadMessage");
		}
		public static void SetReadyToUploadMessage(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxFileUploader_SetOption", dxTarget, "readyToUploadMessage", value);
		}
		public static string GetSelectButtonText(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_DxFileUploader_GetOption", dxTarget, "selectButtonText");
		}
		public static void SetSelectButtonText(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxFileUploader_SetOption", dxTarget, "selectButtonText", value);
		}
		public static bool? GetShowFileList(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_DxFileUploader_GetOption", dxTarget, "showFileList");
		}
		public static void SetShowFileList(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxFileUploader_SetOption", dxTarget, "showFileList", value);
		}
		public static string GetUploadButtonText(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_DxFileUploader_GetOption", dxTarget, "uploadButtonText");
		}
		public static void SetUploadButtonText(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxFileUploader_SetOption", dxTarget, "uploadButtonText", value);
		}
		public static string GetUploadedMessage(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_DxFileUploader_GetOption", dxTarget, "uploadedMessage");
		}
		public static void SetUploadedMessage(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxFileUploader_SetOption", dxTarget, "uploadedMessage", value);
		}
		public static string GetUploadFailedMessage(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_DxFileUploader_GetOption", dxTarget, "uploadFailedMessage");
		}
		public static void SetUploadFailedMessage(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxFileUploader_SetOption", dxTarget, "uploadFailedMessage", value);
		}
		public static object GetUploadHeaders(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxFileUploader_GetOption", dxTarget, "uploadHeaders");
		}
		public static void SetUploadHeaders(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxFileUploader_SetOption", dxTarget, "uploadHeaders", value);
		}
		public static string GetUploadMethod(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_DxFileUploader_GetOption", dxTarget, "uploadMethod");
		}
		public static void SetUploadMethod(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxFileUploader_SetOption", dxTarget, "uploadMethod", value);
		}
		public static string GetUploadMode(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_DxFileUploader_GetOption", dxTarget, "uploadMode");
		}
		public static void SetUploadMode(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxFileUploader_SetOption", dxTarget, "uploadMode", value);
		}
		public static string GetUploadUrl(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_DxFileUploader_GetOption", dxTarget, "uploadUrl");
		}
		public static void SetUploadUrl(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxFileUploader_SetOption", dxTarget, "uploadUrl", value);
		}
		public static new object GetValue(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxFileUploader_GetOption", dxTarget, "value");
		}
		public static new void SetValue(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxFileUploader_SetOption", dxTarget, "value", value);
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
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxFilterBuilder_Init", dxTarget, json);
		}
		[JSInvokable("DevExpress.Ui.DxFilterBuilderInterop.OnEditorPrepared")]
		public static void OnEditorPrepared(string identifier)
		{
			EditorPrepared?.Invoke(null, new JQueryEventArgs(identifier));
		}
		[JSInvokable("DevExpress.Ui.DxFilterBuilderInterop.OnEditorPreparing")]
		public static void OnEditorPreparing(string identifier)
		{
			EditorPreparing?.Invoke(null, new JQueryEventArgs(identifier));
		}
		[JSInvokable("DevExpress.Ui.DxFilterBuilderInterop.OnValueChanged")]
		public static void OnValueChanged(string identifier)
		{
			ValueChanged?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static bool? GetAllowHierarchicalFields(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_DxFilterBuilder_GetOption", dxTarget, "allowHierarchicalFields");
		}
		public static void SetAllowHierarchicalFields(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxFilterBuilder_SetOption", dxTarget, "allowHierarchicalFields", value);
		}
		public static object GetCustomOperations(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxFilterBuilder_GetOption", dxTarget, "customOperations");
		}
		public static void SetCustomOperations(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxFilterBuilder_SetOption", dxTarget, "customOperations", value);
		}
		public static object GetFields(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxFilterBuilder_GetOption", dxTarget, "fields");
		}
		public static void SetFields(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxFilterBuilder_SetOption", dxTarget, "fields", value);
		}
		public static object GetFilterOperationDescriptions(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxFilterBuilder_GetOption", dxTarget, "filterOperationDescriptions");
		}
		public static void SetFilterOperationDescriptions(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxFilterBuilder_SetOption", dxTarget, "filterOperationDescriptions", value);
		}
		public static object GetGroupOperationDescriptions(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxFilterBuilder_GetOption", dxTarget, "groupOperationDescriptions");
		}
		public static void SetGroupOperationDescriptions(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxFilterBuilder_SetOption", dxTarget, "groupOperationDescriptions", value);
		}
		public static object GetValue(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxFilterBuilder_GetOption", dxTarget, "value");
		}
		public static void SetValue(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxFilterBuilder_SetOption", dxTarget, "value", value);
		}
		public static object GetFilterExpression(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxFilterBuilder_getFilterExpression_0", dxTarget);
		}
	}
	public class DxFormInterop: WidgetInterop
	{
		public static event EventHandler<JQueryEventArgs> EditorEnterKey;
		public static event EventHandler<JQueryEventArgs> FieldDataChanged;
		public static void Init(ElementRef dxTarget, DevExpress.Ui.DxFormOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxForm_Init", dxTarget, json);
		}
		[JSInvokable("DevExpress.Ui.DxFormInterop.OnEditorEnterKey")]
		public static void OnEditorEnterKey(string identifier)
		{
			EditorEnterKey?.Invoke(null, new JQueryEventArgs(identifier));
		}
		[JSInvokable("DevExpress.Ui.DxFormInterop.OnFieldDataChanged")]
		public static void OnFieldDataChanged(string identifier)
		{
			FieldDataChanged?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static bool? GetAlignItemLabels(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_DxForm_GetOption", dxTarget, "alignItemLabels");
		}
		public static void SetAlignItemLabels(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxForm_SetOption", dxTarget, "alignItemLabels", value);
		}
		public static bool? GetAlignItemLabelsInAllGroups(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_DxForm_GetOption", dxTarget, "alignItemLabelsInAllGroups");
		}
		public static void SetAlignItemLabelsInAllGroups(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxForm_SetOption", dxTarget, "alignItemLabelsInAllGroups", value);
		}
		public static object GetColCount(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxForm_GetOption", dxTarget, "colCount");
		}
		public static void SetColCount(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxForm_SetOption", dxTarget, "colCount", value);
		}
		public static object GetColCountByScreen(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxForm_GetOption", dxTarget, "colCountByScreen");
		}
		public static void SetColCountByScreen(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxForm_SetOption", dxTarget, "colCountByScreen", value);
		}
		public static object GetCustomizeItem(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxForm_GetOption", dxTarget, "customizeItem");
		}
		public static void SetCustomizeItem(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxForm_SetOption", dxTarget, "customizeItem", value);
		}
		public static object GetFormData(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxForm_GetOption", dxTarget, "formData");
		}
		public static void SetFormData(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxForm_SetOption", dxTarget, "formData", value);
		}
		public static object GetItems(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxForm_GetOption", dxTarget, "items");
		}
		public static void SetItems(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxForm_SetOption", dxTarget, "items", value);
		}
		public static string GetLabelLocation(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_DxForm_GetOption", dxTarget, "labelLocation");
		}
		public static void SetLabelLocation(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxForm_SetOption", dxTarget, "labelLocation", value);
		}
		public static float? GetMinColWidth(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<float?>("BlazorDevExtreme_DxForm_GetOption", dxTarget, "minColWidth");
		}
		public static void SetMinColWidth(ElementRef dxTarget, float? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxForm_SetOption", dxTarget, "minColWidth", value);
		}
		public static string GetOptionalMark(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_DxForm_GetOption", dxTarget, "optionalMark");
		}
		public static void SetOptionalMark(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxForm_SetOption", dxTarget, "optionalMark", value);
		}
		public static bool? GetReadOnly(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_DxForm_GetOption", dxTarget, "readOnly");
		}
		public static void SetReadOnly(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxForm_SetOption", dxTarget, "readOnly", value);
		}
		public static string GetRequiredMark(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_DxForm_GetOption", dxTarget, "requiredMark");
		}
		public static void SetRequiredMark(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxForm_SetOption", dxTarget, "requiredMark", value);
		}
		public static string GetRequiredMessage(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_DxForm_GetOption", dxTarget, "requiredMessage");
		}
		public static void SetRequiredMessage(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxForm_SetOption", dxTarget, "requiredMessage", value);
		}
		public static object GetScreenByWidth(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxForm_GetOption", dxTarget, "screenByWidth");
		}
		public static void SetScreenByWidth(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxForm_SetOption", dxTarget, "screenByWidth", value);
		}
		public static bool? GetScrollingEnabled(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_DxForm_GetOption", dxTarget, "scrollingEnabled");
		}
		public static void SetScrollingEnabled(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxForm_SetOption", dxTarget, "scrollingEnabled", value);
		}
		public static bool? GetShowColonAfterLabel(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_DxForm_GetOption", dxTarget, "showColonAfterLabel");
		}
		public static void SetShowColonAfterLabel(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxForm_SetOption", dxTarget, "showColonAfterLabel", value);
		}
		public static bool? GetShowOptionalMark(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_DxForm_GetOption", dxTarget, "showOptionalMark");
		}
		public static void SetShowOptionalMark(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxForm_SetOption", dxTarget, "showOptionalMark", value);
		}
		public static bool? GetShowRequiredMark(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_DxForm_GetOption", dxTarget, "showRequiredMark");
		}
		public static void SetShowRequiredMark(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxForm_SetOption", dxTarget, "showRequiredMark", value);
		}
		public static bool? GetShowValidationSummary(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_DxForm_GetOption", dxTarget, "showValidationSummary");
		}
		public static void SetShowValidationSummary(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxForm_SetOption", dxTarget, "showValidationSummary", value);
		}
		public static string GetValidationGroup(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_DxForm_GetOption", dxTarget, "validationGroup");
		}
		public static void SetValidationGroup(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxForm_SetOption", dxTarget, "validationGroup", value);
		}
		public static object GetEditor(ElementRef dxTarget, string dataField)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxForm_getEditor_0", dxTarget, dataField);
		}
		public static object ItemOption(ElementRef dxTarget, string id)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxForm_itemOption_1", dxTarget, id);
		}
		public static void ItemOption(ElementRef dxTarget, string id, string option, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxForm_itemOption_2", dxTarget, id, option, value);
		}
		public static void ItemOption(ElementRef dxTarget, string id, object options)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxForm_itemOption_3", dxTarget, id, options);
		}
		public static void ResetValues(ElementRef dxTarget)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxForm_resetValues_4", dxTarget);
		}
		public static void UpdateData(ElementRef dxTarget, object data)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxForm_updateData_5", dxTarget, data);
		}
		public static void UpdateData(ElementRef dxTarget, string dataField, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxForm_updateData_6", dxTarget, dataField, value);
		}
		public static object UpdateDimensions(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxForm_updateDimensions_7", dxTarget);
		}
		public static object Validate(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxForm_validate_8", dxTarget);
		}
	}
	public class DxGalleryInterop: CollectionWidgetInterop
	{
		public static void Init(ElementRef dxTarget, DevExpress.Ui.DxGalleryOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxGallery_Init", dxTarget, json);
		}
		public static float? GetAnimationDuration(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<float?>("BlazorDevExtreme_DxGallery_GetOption", dxTarget, "animationDuration");
		}
		public static void SetAnimationDuration(ElementRef dxTarget, float? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxGallery_SetOption", dxTarget, "animationDuration", value);
		}
		public static bool? GetAnimationEnabled(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_DxGallery_GetOption", dxTarget, "animationEnabled");
		}
		public static void SetAnimationEnabled(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxGallery_SetOption", dxTarget, "animationEnabled", value);
		}
		public static new bool? GetFocusStateEnabled(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_DxGallery_GetOption", dxTarget, "focusStateEnabled");
		}
		public static new void SetFocusStateEnabled(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxGallery_SetOption", dxTarget, "focusStateEnabled", value);
		}
		public static bool? GetIndicatorEnabled(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_DxGallery_GetOption", dxTarget, "indicatorEnabled");
		}
		public static void SetIndicatorEnabled(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxGallery_SetOption", dxTarget, "indicatorEnabled", value);
		}
		public static float? GetInitialItemWidth(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<float?>("BlazorDevExtreme_DxGallery_GetOption", dxTarget, "initialItemWidth");
		}
		public static void SetInitialItemWidth(ElementRef dxTarget, float? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxGallery_SetOption", dxTarget, "initialItemWidth", value);
		}
		public static bool? GetLoop(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_DxGallery_GetOption", dxTarget, "loop");
		}
		public static void SetLoop(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxGallery_SetOption", dxTarget, "loop", value);
		}
		public static new float? GetSelectedIndex(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<float?>("BlazorDevExtreme_DxGallery_GetOption", dxTarget, "selectedIndex");
		}
		public static new void SetSelectedIndex(ElementRef dxTarget, float? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxGallery_SetOption", dxTarget, "selectedIndex", value);
		}
		public static bool? GetShowIndicator(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_DxGallery_GetOption", dxTarget, "showIndicator");
		}
		public static void SetShowIndicator(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxGallery_SetOption", dxTarget, "showIndicator", value);
		}
		public static bool? GetShowNavButtons(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_DxGallery_GetOption", dxTarget, "showNavButtons");
		}
		public static void SetShowNavButtons(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxGallery_SetOption", dxTarget, "showNavButtons", value);
		}
		public static float? GetSlideshowDelay(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<float?>("BlazorDevExtreme_DxGallery_GetOption", dxTarget, "slideshowDelay");
		}
		public static void SetSlideshowDelay(ElementRef dxTarget, float? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxGallery_SetOption", dxTarget, "slideshowDelay", value);
		}
		public static bool? GetStretchImages(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_DxGallery_GetOption", dxTarget, "stretchImages");
		}
		public static void SetStretchImages(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxGallery_SetOption", dxTarget, "stretchImages", value);
		}
		public static bool? GetSwipeEnabled(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_DxGallery_GetOption", dxTarget, "swipeEnabled");
		}
		public static void SetSwipeEnabled(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxGallery_SetOption", dxTarget, "swipeEnabled", value);
		}
		public static bool? GetWrapAround(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_DxGallery_GetOption", dxTarget, "wrapAround");
		}
		public static void SetWrapAround(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxGallery_SetOption", dxTarget, "wrapAround", value);
		}
		public static object GoToItem(ElementRef dxTarget, float itemIndex, bool animation)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxGallery_goToItem_0", dxTarget, itemIndex, animation);
		}
		public static object NextItem(ElementRef dxTarget, bool animation)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxGallery_nextItem_1", dxTarget, animation);
		}
		public static object PrevItem(ElementRef dxTarget, bool animation)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxGallery_prevItem_2", dxTarget, animation);
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
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxList_Init", dxTarget, json);
		}
		[JSInvokable("DevExpress.Ui.DxListInterop.OnGroupRendered")]
		public static void OnGroupRendered(string identifier)
		{
			GroupRendered?.Invoke(null, new JQueryEventArgs(identifier));
		}
		[JSInvokable("DevExpress.Ui.DxListInterop.OnItemClick")]
		public static void OnItemClick(string identifier)
		{
			ItemClick?.Invoke(null, new JQueryEventArgs(identifier));
		}
		[JSInvokable("DevExpress.Ui.DxListInterop.OnItemContextMenu")]
		public static void OnItemContextMenu(string identifier)
		{
			ItemContextMenu?.Invoke(null, new JQueryEventArgs(identifier));
		}
		[JSInvokable("DevExpress.Ui.DxListInterop.OnItemDeleted")]
		public static void OnItemDeleted(string identifier)
		{
			ItemDeleted?.Invoke(null, new JQueryEventArgs(identifier));
		}
		[JSInvokable("DevExpress.Ui.DxListInterop.OnItemDeleting")]
		public static void OnItemDeleting(string identifier)
		{
			ItemDeleting?.Invoke(null, new JQueryEventArgs(identifier));
		}
		[JSInvokable("DevExpress.Ui.DxListInterop.OnItemHold")]
		public static void OnItemHold(string identifier)
		{
			ItemHold?.Invoke(null, new JQueryEventArgs(identifier));
		}
		[JSInvokable("DevExpress.Ui.DxListInterop.OnItemReordered")]
		public static void OnItemReordered(string identifier)
		{
			ItemReordered?.Invoke(null, new JQueryEventArgs(identifier));
		}
		[JSInvokable("DevExpress.Ui.DxListInterop.OnItemSwipe")]
		public static void OnItemSwipe(string identifier)
		{
			ItemSwipe?.Invoke(null, new JQueryEventArgs(identifier));
		}
		[JSInvokable("DevExpress.Ui.DxListInterop.OnPageLoading")]
		public static void OnPageLoading(string identifier)
		{
			PageLoading?.Invoke(null, new JQueryEventArgs(identifier));
		}
		[JSInvokable("DevExpress.Ui.DxListInterop.OnPullRefresh")]
		public static void OnPullRefresh(string identifier)
		{
			PullRefresh?.Invoke(null, new JQueryEventArgs(identifier));
		}
		[JSInvokable("DevExpress.Ui.DxListInterop.OnScroll")]
		public static void OnScroll(string identifier)
		{
			Scroll?.Invoke(null, new JQueryEventArgs(identifier));
		}
		[JSInvokable("DevExpress.Ui.DxListInterop.OnSelectAllValueChanged")]
		public static void OnSelectAllValueChanged(string identifier)
		{
			SelectAllValueChanged?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static new bool? GetActiveStateEnabled(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_DxList_GetOption", dxTarget, "activeStateEnabled");
		}
		public static new void SetActiveStateEnabled(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxList_SetOption", dxTarget, "activeStateEnabled", value);
		}
		public static bool? GetAllowItemDeleting(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_DxList_GetOption", dxTarget, "allowItemDeleting");
		}
		public static void SetAllowItemDeleting(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxList_SetOption", dxTarget, "allowItemDeleting", value);
		}
		public static bool? GetAllowItemReordering(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_DxList_GetOption", dxTarget, "allowItemReordering");
		}
		public static void SetAllowItemReordering(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxList_SetOption", dxTarget, "allowItemReordering", value);
		}
		public static bool? GetBounceEnabled(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_DxList_GetOption", dxTarget, "bounceEnabled");
		}
		public static void SetBounceEnabled(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxList_SetOption", dxTarget, "bounceEnabled", value);
		}
		public static bool? GetCollapsibleGroups(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_DxList_GetOption", dxTarget, "collapsibleGroups");
		}
		public static void SetCollapsibleGroups(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxList_SetOption", dxTarget, "collapsibleGroups", value);
		}
		public static new bool? GetFocusStateEnabled(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_DxList_GetOption", dxTarget, "focusStateEnabled");
		}
		public static new void SetFocusStateEnabled(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxList_SetOption", dxTarget, "focusStateEnabled", value);
		}
		public static bool? GetGrouped(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_DxList_GetOption", dxTarget, "grouped");
		}
		public static void SetGrouped(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxList_SetOption", dxTarget, "grouped", value);
		}
		public static object GetGroupTemplate(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxList_GetOption", dxTarget, "groupTemplate");
		}
		public static void SetGroupTemplate(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxList_SetOption", dxTarget, "groupTemplate", value);
		}
		public static new bool? GetHoverStateEnabled(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_DxList_GetOption", dxTarget, "hoverStateEnabled");
		}
		public static new void SetHoverStateEnabled(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxList_SetOption", dxTarget, "hoverStateEnabled", value);
		}
		public static bool? GetIndicateLoading(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_DxList_GetOption", dxTarget, "indicateLoading");
		}
		public static void SetIndicateLoading(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxList_SetOption", dxTarget, "indicateLoading", value);
		}
		public static string GetItemDeleteMode(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_DxList_GetOption", dxTarget, "itemDeleteMode");
		}
		public static void SetItemDeleteMode(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxList_SetOption", dxTarget, "itemDeleteMode", value);
		}
		public static object GetMenuItems(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxList_GetOption", dxTarget, "menuItems");
		}
		public static void SetMenuItems(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxList_SetOption", dxTarget, "menuItems", value);
		}
		public static string GetMenuMode(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_DxList_GetOption", dxTarget, "menuMode");
		}
		public static void SetMenuMode(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxList_SetOption", dxTarget, "menuMode", value);
		}
		public static string GetNextButtonText(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_DxList_GetOption", dxTarget, "nextButtonText");
		}
		public static void SetNextButtonText(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxList_SetOption", dxTarget, "nextButtonText", value);
		}
		public static string GetPageLoadingText(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_DxList_GetOption", dxTarget, "pageLoadingText");
		}
		public static void SetPageLoadingText(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxList_SetOption", dxTarget, "pageLoadingText", value);
		}
		public static string GetPageLoadMode(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_DxList_GetOption", dxTarget, "pageLoadMode");
		}
		public static void SetPageLoadMode(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxList_SetOption", dxTarget, "pageLoadMode", value);
		}
		public static string GetPulledDownText(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_DxList_GetOption", dxTarget, "pulledDownText");
		}
		public static void SetPulledDownText(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxList_SetOption", dxTarget, "pulledDownText", value);
		}
		public static string GetPullingDownText(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_DxList_GetOption", dxTarget, "pullingDownText");
		}
		public static void SetPullingDownText(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxList_SetOption", dxTarget, "pullingDownText", value);
		}
		public static bool? GetPullRefreshEnabled(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_DxList_GetOption", dxTarget, "pullRefreshEnabled");
		}
		public static void SetPullRefreshEnabled(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxList_SetOption", dxTarget, "pullRefreshEnabled", value);
		}
		public static string GetRefreshingText(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_DxList_GetOption", dxTarget, "refreshingText");
		}
		public static void SetRefreshingText(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxList_SetOption", dxTarget, "refreshingText", value);
		}
		public static bool? GetScrollByContent(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_DxList_GetOption", dxTarget, "scrollByContent");
		}
		public static void SetScrollByContent(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxList_SetOption", dxTarget, "scrollByContent", value);
		}
		public static bool? GetScrollByThumb(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_DxList_GetOption", dxTarget, "scrollByThumb");
		}
		public static void SetScrollByThumb(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxList_SetOption", dxTarget, "scrollByThumb", value);
		}
		public static bool? GetScrollingEnabled(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_DxList_GetOption", dxTarget, "scrollingEnabled");
		}
		public static void SetScrollingEnabled(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxList_SetOption", dxTarget, "scrollingEnabled", value);
		}
		public static string GetSelectAllMode(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_DxList_GetOption", dxTarget, "selectAllMode");
		}
		public static void SetSelectAllMode(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxList_SetOption", dxTarget, "selectAllMode", value);
		}
		public static string GetSelectionMode(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_DxList_GetOption", dxTarget, "selectionMode");
		}
		public static void SetSelectionMode(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxList_SetOption", dxTarget, "selectionMode", value);
		}
		public static string GetShowScrollbar(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_DxList_GetOption", dxTarget, "showScrollbar");
		}
		public static void SetShowScrollbar(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxList_SetOption", dxTarget, "showScrollbar", value);
		}
		public static bool? GetShowSelectionControls(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_DxList_GetOption", dxTarget, "showSelectionControls");
		}
		public static void SetShowSelectionControls(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxList_SetOption", dxTarget, "showSelectionControls", value);
		}
		public static bool? GetUseNativeScrolling(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_DxList_GetOption", dxTarget, "useNativeScrolling");
		}
		public static void SetUseNativeScrolling(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxList_SetOption", dxTarget, "useNativeScrolling", value);
		}
		public static float ClientHeight(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<float>("BlazorDevExtreme_DxList_clientHeight_0", dxTarget);
		}
		public static object CollapseGroup(ElementRef dxTarget, float groupIndex)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxList_collapseGroup_1", dxTarget, groupIndex);
		}
		public static object DeleteItem(ElementRef dxTarget, object itemElement)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxList_deleteItem_2", dxTarget, itemElement);
		}
		public static object ExpandGroup(ElementRef dxTarget, float groupIndex)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxList_expandGroup_4", dxTarget, groupIndex);
		}
		public static bool IsItemSelected(ElementRef dxTarget, object itemElement)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool>("BlazorDevExtreme_DxList_isItemSelected_5", dxTarget, itemElement);
		}
		public static void Reload(ElementRef dxTarget)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxList_reload_7", dxTarget);
		}
		public static object ReorderItem(ElementRef dxTarget, object itemElement, object toItemElement)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxList_reorderItem_8", dxTarget, itemElement, toItemElement);
		}
		public static void ScrollBy(ElementRef dxTarget, float distance)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxList_scrollBy_10", dxTarget, distance);
		}
		public static float ScrollHeight(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<float>("BlazorDevExtreme_DxList_scrollHeight_11", dxTarget);
		}
		public static void ScrollTo(ElementRef dxTarget, float location)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxList_scrollTo_12", dxTarget, location);
		}
		public static void ScrollToItem(ElementRef dxTarget, object itemElement)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxList_scrollToItem_13", dxTarget, itemElement);
		}
		public static float ScrollTop(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<float>("BlazorDevExtreme_DxList_scrollTop_15", dxTarget);
		}
		public static void SelectAll(ElementRef dxTarget)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxList_selectAll_16", dxTarget);
		}
		public static void SelectItem(ElementRef dxTarget, object itemElement)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxList_selectItem_17", dxTarget, itemElement);
		}
		public static void UnselectAll(ElementRef dxTarget)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxList_unselectAll_19", dxTarget);
		}
		public static void UnselectItem(ElementRef dxTarget, object itemElement)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxList_unselectItem_20", dxTarget, itemElement);
		}
		public static object UpdateDimensions(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxList_updateDimensions_22", dxTarget);
		}
	}
	public class DxLoadIndicatorInterop: WidgetInterop
	{
		public static void Init(ElementRef dxTarget, DevExpress.Ui.DxLoadIndicatorOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxLoadIndicator_Init", dxTarget, json);
		}
		public static string GetIndicatorSrc(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_DxLoadIndicator_GetOption", dxTarget, "indicatorSrc");
		}
		public static void SetIndicatorSrc(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxLoadIndicator_SetOption", dxTarget, "indicatorSrc", value);
		}
	}
	public class DxLoadPanelInterop: DxOverlayInterop
	{
		public static void Init(ElementRef dxTarget, DevExpress.Ui.DxLoadPanelOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxLoadPanel_Init", dxTarget, json);
		}
		public static new object GetAnimation(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxLoadPanel_GetOption", dxTarget, "animation");
		}
		public static new void SetAnimation(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxLoadPanel_SetOption", dxTarget, "animation", value);
		}
		public static float? GetDelay(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<float?>("BlazorDevExtreme_DxLoadPanel_GetOption", dxTarget, "delay");
		}
		public static void SetDelay(ElementRef dxTarget, float? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxLoadPanel_SetOption", dxTarget, "delay", value);
		}
		public static new bool? GetFocusStateEnabled(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_DxLoadPanel_GetOption", dxTarget, "focusStateEnabled");
		}
		public static new void SetFocusStateEnabled(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxLoadPanel_SetOption", dxTarget, "focusStateEnabled", value);
		}
		public static new float? GetHeight(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<float?>("BlazorDevExtreme_DxLoadPanel_GetOption", dxTarget, "height");
		}
		public static new void SetHeight(ElementRef dxTarget, float? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxLoadPanel_SetOption", dxTarget, "height", value);
		}
		public static string GetIndicatorSrc(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_DxLoadPanel_GetOption", dxTarget, "indicatorSrc");
		}
		public static void SetIndicatorSrc(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxLoadPanel_SetOption", dxTarget, "indicatorSrc", value);
		}
		public static string GetMessage(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_DxLoadPanel_GetOption", dxTarget, "message");
		}
		public static void SetMessage(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxLoadPanel_SetOption", dxTarget, "message", value);
		}
		public static new object GetPosition(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxLoadPanel_GetOption", dxTarget, "position");
		}
		public static new void SetPosition(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxLoadPanel_SetOption", dxTarget, "position", value);
		}
		public static new string GetShadingColor(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_DxLoadPanel_GetOption", dxTarget, "shadingColor");
		}
		public static new void SetShadingColor(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxLoadPanel_SetOption", dxTarget, "shadingColor", value);
		}
		public static bool? GetShowIndicator(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_DxLoadPanel_GetOption", dxTarget, "showIndicator");
		}
		public static void SetShowIndicator(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxLoadPanel_SetOption", dxTarget, "showIndicator", value);
		}
		public static bool? GetShowPane(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_DxLoadPanel_GetOption", dxTarget, "showPane");
		}
		public static void SetShowPane(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxLoadPanel_SetOption", dxTarget, "showPane", value);
		}
		public static new float? GetWidth(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<float?>("BlazorDevExtreme_DxLoadPanel_GetOption", dxTarget, "width");
		}
		public static new void SetWidth(ElementRef dxTarget, float? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxLoadPanel_SetOption", dxTarget, "width", value);
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
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxLookup_Init", dxTarget, json);
		}
		[JSInvokable("DevExpress.Ui.DxLookupInterop.OnPageLoading")]
		public static void OnPageLoading(string identifier)
		{
			PageLoading?.Invoke(null, new JQueryEventArgs(identifier));
		}
		[JSInvokable("DevExpress.Ui.DxLookupInterop.OnPullRefresh")]
		public static void OnPullRefresh(string identifier)
		{
			PullRefresh?.Invoke(null, new JQueryEventArgs(identifier));
		}
		[JSInvokable("DevExpress.Ui.DxLookupInterop.OnScroll")]
		public static void OnScroll(string identifier)
		{
			Scroll?.Invoke(null, new JQueryEventArgs(identifier));
		}
		[JSInvokable("DevExpress.Ui.DxLookupInterop.OnTitleRendered")]
		public static void OnTitleRendered(string identifier)
		{
			TitleRendered?.Invoke(null, new JQueryEventArgs(identifier));
		}
		[JSInvokable("DevExpress.Ui.DxLookupInterop.OnValueChanged")]
		public static void OnValueChanged(string identifier)
		{
			ValueChanged?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static object GetAnimation(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxLookup_GetOption", dxTarget, "animation");
		}
		public static void SetAnimation(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxLookup_SetOption", dxTarget, "animation", value);
		}
		public static string GetApplyButtonText(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_DxLookup_GetOption", dxTarget, "applyButtonText");
		}
		public static void SetApplyButtonText(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxLookup_SetOption", dxTarget, "applyButtonText", value);
		}
		public static new string GetApplyValueMode(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_DxLookup_GetOption", dxTarget, "applyValueMode");
		}
		public static new void SetApplyValueMode(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxLookup_SetOption", dxTarget, "applyValueMode", value);
		}
		public static string GetCancelButtonText(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_DxLookup_GetOption", dxTarget, "cancelButtonText");
		}
		public static void SetCancelButtonText(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxLookup_SetOption", dxTarget, "cancelButtonText", value);
		}
		public static bool? GetCleanSearchOnOpening(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_DxLookup_GetOption", dxTarget, "cleanSearchOnOpening");
		}
		public static void SetCleanSearchOnOpening(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxLookup_SetOption", dxTarget, "cleanSearchOnOpening", value);
		}
		public static string GetClearButtonText(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_DxLookup_GetOption", dxTarget, "clearButtonText");
		}
		public static void SetClearButtonText(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxLookup_SetOption", dxTarget, "clearButtonText", value);
		}
		public static object GetCloseOnOutsideClick(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxLookup_GetOption", dxTarget, "closeOnOutsideClick");
		}
		public static void SetCloseOnOutsideClick(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxLookup_SetOption", dxTarget, "closeOnOutsideClick", value);
		}
		public static object GetFieldTemplate(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxLookup_GetOption", dxTarget, "fieldTemplate");
		}
		public static void SetFieldTemplate(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxLookup_SetOption", dxTarget, "fieldTemplate", value);
		}
		public static new bool? GetFocusStateEnabled(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_DxLookup_GetOption", dxTarget, "focusStateEnabled");
		}
		public static new void SetFocusStateEnabled(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxLookup_SetOption", dxTarget, "focusStateEnabled", value);
		}
		public static bool? GetFullScreen(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_DxLookup_GetOption", dxTarget, "fullScreen");
		}
		public static void SetFullScreen(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxLookup_SetOption", dxTarget, "fullScreen", value);
		}
		public static new bool? GetGrouped(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_DxLookup_GetOption", dxTarget, "grouped");
		}
		public static new void SetGrouped(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxLookup_SetOption", dxTarget, "grouped", value);
		}
		public static new object GetGroupTemplate(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxLookup_GetOption", dxTarget, "groupTemplate");
		}
		public static new void SetGroupTemplate(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxLookup_SetOption", dxTarget, "groupTemplate", value);
		}
		public static string GetNextButtonText(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_DxLookup_GetOption", dxTarget, "nextButtonText");
		}
		public static void SetNextButtonText(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxLookup_SetOption", dxTarget, "nextButtonText", value);
		}
		public static string GetPageLoadingText(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_DxLookup_GetOption", dxTarget, "pageLoadingText");
		}
		public static void SetPageLoadingText(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxLookup_SetOption", dxTarget, "pageLoadingText", value);
		}
		public static string GetPageLoadMode(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_DxLookup_GetOption", dxTarget, "pageLoadMode");
		}
		public static void SetPageLoadMode(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxLookup_SetOption", dxTarget, "pageLoadMode", value);
		}
		public static new string GetPlaceholder(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_DxLookup_GetOption", dxTarget, "placeholder");
		}
		public static new void SetPlaceholder(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxLookup_SetOption", dxTarget, "placeholder", value);
		}
		public static object GetPopupHeight(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxLookup_GetOption", dxTarget, "popupHeight");
		}
		public static void SetPopupHeight(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxLookup_SetOption", dxTarget, "popupHeight", value);
		}
		public static object GetPopupWidth(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxLookup_GetOption", dxTarget, "popupWidth");
		}
		public static void SetPopupWidth(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxLookup_SetOption", dxTarget, "popupWidth", value);
		}
		public static object GetPosition(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxLookup_GetOption", dxTarget, "position");
		}
		public static void SetPosition(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxLookup_SetOption", dxTarget, "position", value);
		}
		public static string GetPulledDownText(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_DxLookup_GetOption", dxTarget, "pulledDownText");
		}
		public static void SetPulledDownText(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxLookup_SetOption", dxTarget, "pulledDownText", value);
		}
		public static string GetPullingDownText(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_DxLookup_GetOption", dxTarget, "pullingDownText");
		}
		public static void SetPullingDownText(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxLookup_SetOption", dxTarget, "pullingDownText", value);
		}
		public static bool? GetPullRefreshEnabled(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_DxLookup_GetOption", dxTarget, "pullRefreshEnabled");
		}
		public static void SetPullRefreshEnabled(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxLookup_SetOption", dxTarget, "pullRefreshEnabled", value);
		}
		public static string GetRefreshingText(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_DxLookup_GetOption", dxTarget, "refreshingText");
		}
		public static void SetRefreshingText(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxLookup_SetOption", dxTarget, "refreshingText", value);
		}
		public static new bool? GetSearchEnabled(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_DxLookup_GetOption", dxTarget, "searchEnabled");
		}
		public static new void SetSearchEnabled(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxLookup_SetOption", dxTarget, "searchEnabled", value);
		}
		public static string GetSearchPlaceholder(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_DxLookup_GetOption", dxTarget, "searchPlaceholder");
		}
		public static void SetSearchPlaceholder(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxLookup_SetOption", dxTarget, "searchPlaceholder", value);
		}
		public static bool? GetShading(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_DxLookup_GetOption", dxTarget, "shading");
		}
		public static void SetShading(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxLookup_SetOption", dxTarget, "shading", value);
		}
		public static bool? GetShowCancelButton(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_DxLookup_GetOption", dxTarget, "showCancelButton");
		}
		public static void SetShowCancelButton(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxLookup_SetOption", dxTarget, "showCancelButton", value);
		}
		public static new bool? GetShowClearButton(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_DxLookup_GetOption", dxTarget, "showClearButton");
		}
		public static new void SetShowClearButton(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxLookup_SetOption", dxTarget, "showClearButton", value);
		}
		public static bool? GetShowPopupTitle(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_DxLookup_GetOption", dxTarget, "showPopupTitle");
		}
		public static void SetShowPopupTitle(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxLookup_SetOption", dxTarget, "showPopupTitle", value);
		}
		public static string GetTitle(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_DxLookup_GetOption", dxTarget, "title");
		}
		public static void SetTitle(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxLookup_SetOption", dxTarget, "title", value);
		}
		public static object GetTitleTemplate(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxLookup_GetOption", dxTarget, "titleTemplate");
		}
		public static void SetTitleTemplate(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxLookup_SetOption", dxTarget, "titleTemplate", value);
		}
		public static bool? GetUseNativeScrolling(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_DxLookup_GetOption", dxTarget, "useNativeScrolling");
		}
		public static void SetUseNativeScrolling(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxLookup_SetOption", dxTarget, "useNativeScrolling", value);
		}
		public static bool? GetUsePopover(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_DxLookup_GetOption", dxTarget, "usePopover");
		}
		public static void SetUsePopover(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxLookup_SetOption", dxTarget, "usePopover", value);
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
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxMap_Init", dxTarget, json);
		}
		[JSInvokable("DevExpress.Ui.DxMapInterop.OnClick")]
		public static void OnClick(string identifier)
		{
			Click?.Invoke(null, new JQueryEventArgs(identifier));
		}
		[JSInvokable("DevExpress.Ui.DxMapInterop.OnMarkerAdded")]
		public static void OnMarkerAdded(string identifier)
		{
			MarkerAdded?.Invoke(null, new JQueryEventArgs(identifier));
		}
		[JSInvokable("DevExpress.Ui.DxMapInterop.OnMarkerRemoved")]
		public static void OnMarkerRemoved(string identifier)
		{
			MarkerRemoved?.Invoke(null, new JQueryEventArgs(identifier));
		}
		[JSInvokable("DevExpress.Ui.DxMapInterop.OnReady")]
		public static void OnReady(string identifier)
		{
			Ready?.Invoke(null, new JQueryEventArgs(identifier));
		}
		[JSInvokable("DevExpress.Ui.DxMapInterop.OnRouteAdded")]
		public static void OnRouteAdded(string identifier)
		{
			RouteAdded?.Invoke(null, new JQueryEventArgs(identifier));
		}
		[JSInvokable("DevExpress.Ui.DxMapInterop.OnRouteRemoved")]
		public static void OnRouteRemoved(string identifier)
		{
			RouteRemoved?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static bool? GetAutoAdjust(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_DxMap_GetOption", dxTarget, "autoAdjust");
		}
		public static void SetAutoAdjust(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxMap_SetOption", dxTarget, "autoAdjust", value);
		}
		public static object GetCenter(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxMap_GetOption", dxTarget, "center");
		}
		public static void SetCenter(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxMap_SetOption", dxTarget, "center", value);
		}
		public static bool? GetControls(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_DxMap_GetOption", dxTarget, "controls");
		}
		public static void SetControls(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxMap_SetOption", dxTarget, "controls", value);
		}
		public static new bool? GetFocusStateEnabled(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_DxMap_GetOption", dxTarget, "focusStateEnabled");
		}
		public static new void SetFocusStateEnabled(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxMap_SetOption", dxTarget, "focusStateEnabled", value);
		}
		public static new object GetHeight(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxMap_GetOption", dxTarget, "height");
		}
		public static new void SetHeight(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxMap_SetOption", dxTarget, "height", value);
		}
		public static object GetKey(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxMap_GetOption", dxTarget, "key");
		}
		public static void SetKey(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxMap_SetOption", dxTarget, "key", value);
		}
		public static string GetMarkerIconSrc(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_DxMap_GetOption", dxTarget, "markerIconSrc");
		}
		public static void SetMarkerIconSrc(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxMap_SetOption", dxTarget, "markerIconSrc", value);
		}
		public static object GetMarkers(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxMap_GetOption", dxTarget, "markers");
		}
		public static void SetMarkers(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxMap_SetOption", dxTarget, "markers", value);
		}
		public static string GetProvider(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_DxMap_GetOption", dxTarget, "provider");
		}
		public static void SetProvider(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxMap_SetOption", dxTarget, "provider", value);
		}
		public static object GetRoutes(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxMap_GetOption", dxTarget, "routes");
		}
		public static void SetRoutes(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxMap_SetOption", dxTarget, "routes", value);
		}
		public static string GetType(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_DxMap_GetOption", dxTarget, "type");
		}
		public static void SetType(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxMap_SetOption", dxTarget, "type", value);
		}
		public static new object GetWidth(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxMap_GetOption", dxTarget, "width");
		}
		public static new void SetWidth(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxMap_SetOption", dxTarget, "width", value);
		}
		public static float? GetZoom(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<float?>("BlazorDevExtreme_DxMap_GetOption", dxTarget, "zoom");
		}
		public static void SetZoom(ElementRef dxTarget, float? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxMap_SetOption", dxTarget, "zoom", value);
		}
		public static object AddMarker(ElementRef dxTarget, object markerOptions)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxMap_addMarker_0", dxTarget, markerOptions);
		}
		public static object AddRoute(ElementRef dxTarget, object options)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxMap_addRoute_1", dxTarget, options);
		}
		public static object RemoveMarker(ElementRef dxTarget, object marker)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxMap_removeMarker_2", dxTarget, marker);
		}
		public static object RemoveRoute(ElementRef dxTarget, object route)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxMap_removeRoute_3", dxTarget, route);
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
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxMenu_Init", dxTarget, json);
		}
		[JSInvokable("DevExpress.Ui.DxMenuInterop.OnSubmenuHidden")]
		public static void OnSubmenuHidden(string identifier)
		{
			SubmenuHidden?.Invoke(null, new JQueryEventArgs(identifier));
		}
		[JSInvokable("DevExpress.Ui.DxMenuInterop.OnSubmenuHiding")]
		public static void OnSubmenuHiding(string identifier)
		{
			SubmenuHiding?.Invoke(null, new JQueryEventArgs(identifier));
		}
		[JSInvokable("DevExpress.Ui.DxMenuInterop.OnSubmenuShowing")]
		public static void OnSubmenuShowing(string identifier)
		{
			SubmenuShowing?.Invoke(null, new JQueryEventArgs(identifier));
		}
		[JSInvokable("DevExpress.Ui.DxMenuInterop.OnSubmenuShown")]
		public static void OnSubmenuShown(string identifier)
		{
			SubmenuShown?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static bool? GetAdaptivityEnabled(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_DxMenu_GetOption", dxTarget, "adaptivityEnabled");
		}
		public static void SetAdaptivityEnabled(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxMenu_SetOption", dxTarget, "adaptivityEnabled", value);
		}
		public static bool? GetHideSubmenuOnMouseLeave(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_DxMenu_GetOption", dxTarget, "hideSubmenuOnMouseLeave");
		}
		public static void SetHideSubmenuOnMouseLeave(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxMenu_SetOption", dxTarget, "hideSubmenuOnMouseLeave", value);
		}
		public static new object GetItems(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxMenu_GetOption", dxTarget, "items");
		}
		public static new void SetItems(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxMenu_SetOption", dxTarget, "items", value);
		}
		public static string GetOrientation(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_DxMenu_GetOption", dxTarget, "orientation");
		}
		public static void SetOrientation(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxMenu_SetOption", dxTarget, "orientation", value);
		}
		public static object GetShowFirstSubmenuMode(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxMenu_GetOption", dxTarget, "showFirstSubmenuMode");
		}
		public static void SetShowFirstSubmenuMode(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxMenu_SetOption", dxTarget, "showFirstSubmenuMode", value);
		}
		public static string GetSubmenuDirection(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_DxMenu_GetOption", dxTarget, "submenuDirection");
		}
		public static void SetSubmenuDirection(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxMenu_SetOption", dxTarget, "submenuDirection", value);
		}
	}
	public class DxMultiViewInterop: CollectionWidgetInterop
	{
		public static void Init(ElementRef dxTarget, DevExpress.Ui.DxMultiViewOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxMultiView_Init", dxTarget, json);
		}
		public static bool? GetAnimationEnabled(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_DxMultiView_GetOption", dxTarget, "animationEnabled");
		}
		public static void SetAnimationEnabled(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxMultiView_SetOption", dxTarget, "animationEnabled", value);
		}
		public static bool? GetDeferRendering(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_DxMultiView_GetOption", dxTarget, "deferRendering");
		}
		public static void SetDeferRendering(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxMultiView_SetOption", dxTarget, "deferRendering", value);
		}
		public static new bool? GetFocusStateEnabled(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_DxMultiView_GetOption", dxTarget, "focusStateEnabled");
		}
		public static new void SetFocusStateEnabled(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxMultiView_SetOption", dxTarget, "focusStateEnabled", value);
		}
		public static bool? GetLoop(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_DxMultiView_GetOption", dxTarget, "loop");
		}
		public static void SetLoop(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxMultiView_SetOption", dxTarget, "loop", value);
		}
		public static new float? GetSelectedIndex(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<float?>("BlazorDevExtreme_DxMultiView_GetOption", dxTarget, "selectedIndex");
		}
		public static new void SetSelectedIndex(ElementRef dxTarget, float? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxMultiView_SetOption", dxTarget, "selectedIndex", value);
		}
		public static bool? GetSwipeEnabled(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_DxMultiView_GetOption", dxTarget, "swipeEnabled");
		}
		public static void SetSwipeEnabled(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxMultiView_SetOption", dxTarget, "swipeEnabled", value);
		}
	}
	public class DxNavBarInterop: DxTabsInterop
	{
		public static void Init(ElementRef dxTarget, DevExpress.Ui.DxNavBarOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxNavBar_Init", dxTarget, json);
		}
		public static new bool? GetScrollByContent(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_DxNavBar_GetOption", dxTarget, "scrollByContent");
		}
		public static new void SetScrollByContent(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxNavBar_SetOption", dxTarget, "scrollByContent", value);
		}
	}
	public class DxNumberBoxInterop: DxTextEditorInterop
	{
		public static void Init(ElementRef dxTarget, DevExpress.Ui.DxNumberBoxOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxNumberBox_Init", dxTarget, json);
		}
		public static object GetFormat(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxNumberBox_GetOption", dxTarget, "format");
		}
		public static void SetFormat(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxNumberBox_SetOption", dxTarget, "format", value);
		}
		public static string GetInvalidValueMessage(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_DxNumberBox_GetOption", dxTarget, "invalidValueMessage");
		}
		public static void SetInvalidValueMessage(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxNumberBox_SetOption", dxTarget, "invalidValueMessage", value);
		}
		public static float? GetMax(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<float?>("BlazorDevExtreme_DxNumberBox_GetOption", dxTarget, "max");
		}
		public static void SetMax(ElementRef dxTarget, float? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxNumberBox_SetOption", dxTarget, "max", value);
		}
		public static float? GetMin(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<float?>("BlazorDevExtreme_DxNumberBox_GetOption", dxTarget, "min");
		}
		public static void SetMin(ElementRef dxTarget, float? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxNumberBox_SetOption", dxTarget, "min", value);
		}
		public static string GetMode(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_DxNumberBox_GetOption", dxTarget, "mode");
		}
		public static void SetMode(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxNumberBox_SetOption", dxTarget, "mode", value);
		}
		public static bool? GetShowSpinButtons(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_DxNumberBox_GetOption", dxTarget, "showSpinButtons");
		}
		public static void SetShowSpinButtons(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxNumberBox_SetOption", dxTarget, "showSpinButtons", value);
		}
		public static float? GetStep(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<float?>("BlazorDevExtreme_DxNumberBox_GetOption", dxTarget, "step");
		}
		public static void SetStep(ElementRef dxTarget, float? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxNumberBox_SetOption", dxTarget, "step", value);
		}
		public static bool? GetUseLargeSpinButtons(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_DxNumberBox_GetOption", dxTarget, "useLargeSpinButtons");
		}
		public static void SetUseLargeSpinButtons(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxNumberBox_SetOption", dxTarget, "useLargeSpinButtons", value);
		}
		public static new float? GetValue(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<float?>("BlazorDevExtreme_DxNumberBox_GetOption", dxTarget, "value");
		}
		public static new void SetValue(ElementRef dxTarget, float? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxNumberBox_SetOption", dxTarget, "value", value);
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
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxOverlay_Init", dxTarget, json);
		}
		[JSInvokable("DevExpress.Ui.DxOverlayInterop.OnHidden")]
		public static void OnHidden(string identifier)
		{
			Hidden?.Invoke(null, new JQueryEventArgs(identifier));
		}
		[JSInvokable("DevExpress.Ui.DxOverlayInterop.OnHiding")]
		public static void OnHiding(string identifier)
		{
			Hiding?.Invoke(null, new JQueryEventArgs(identifier));
		}
		[JSInvokable("DevExpress.Ui.DxOverlayInterop.OnShowing")]
		public static void OnShowing(string identifier)
		{
			Showing?.Invoke(null, new JQueryEventArgs(identifier));
		}
		[JSInvokable("DevExpress.Ui.DxOverlayInterop.OnShown")]
		public static void OnShown(string identifier)
		{
			Shown?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static object GetAnimation(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxOverlay_GetOption", dxTarget, "animation");
		}
		public static void SetAnimation(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxOverlay_SetOption", dxTarget, "animation", value);
		}
		public static bool? GetCloseOnBackButton(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_DxOverlay_GetOption", dxTarget, "closeOnBackButton");
		}
		public static void SetCloseOnBackButton(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxOverlay_SetOption", dxTarget, "closeOnBackButton", value);
		}
		public static object GetCloseOnOutsideClick(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxOverlay_GetOption", dxTarget, "closeOnOutsideClick");
		}
		public static void SetCloseOnOutsideClick(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxOverlay_SetOption", dxTarget, "closeOnOutsideClick", value);
		}
		public static object GetContentTemplate(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxOverlay_GetOption", dxTarget, "contentTemplate");
		}
		public static void SetContentTemplate(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxOverlay_SetOption", dxTarget, "contentTemplate", value);
		}
		public static bool? GetDeferRendering(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_DxOverlay_GetOption", dxTarget, "deferRendering");
		}
		public static void SetDeferRendering(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxOverlay_SetOption", dxTarget, "deferRendering", value);
		}
		public static bool? GetDragEnabled(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_DxOverlay_GetOption", dxTarget, "dragEnabled");
		}
		public static void SetDragEnabled(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxOverlay_SetOption", dxTarget, "dragEnabled", value);
		}
		public static new object GetHeight(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxOverlay_GetOption", dxTarget, "height");
		}
		public static new void SetHeight(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxOverlay_SetOption", dxTarget, "height", value);
		}
		public static object GetMaxHeight(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxOverlay_GetOption", dxTarget, "maxHeight");
		}
		public static void SetMaxHeight(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxOverlay_SetOption", dxTarget, "maxHeight", value);
		}
		public static object GetMaxWidth(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxOverlay_GetOption", dxTarget, "maxWidth");
		}
		public static void SetMaxWidth(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxOverlay_SetOption", dxTarget, "maxWidth", value);
		}
		public static object GetMinHeight(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxOverlay_GetOption", dxTarget, "minHeight");
		}
		public static void SetMinHeight(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxOverlay_SetOption", dxTarget, "minHeight", value);
		}
		public static object GetMinWidth(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxOverlay_GetOption", dxTarget, "minWidth");
		}
		public static void SetMinWidth(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxOverlay_SetOption", dxTarget, "minWidth", value);
		}
		public static object GetPosition(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxOverlay_GetOption", dxTarget, "position");
		}
		public static void SetPosition(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxOverlay_SetOption", dxTarget, "position", value);
		}
		public static bool? GetShading(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_DxOverlay_GetOption", dxTarget, "shading");
		}
		public static void SetShading(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxOverlay_SetOption", dxTarget, "shading", value);
		}
		public static string GetShadingColor(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_DxOverlay_GetOption", dxTarget, "shadingColor");
		}
		public static void SetShadingColor(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxOverlay_SetOption", dxTarget, "shadingColor", value);
		}
		public static new bool? GetVisible(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_DxOverlay_GetOption", dxTarget, "visible");
		}
		public static new void SetVisible(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxOverlay_SetOption", dxTarget, "visible", value);
		}
		public static new object GetWidth(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxOverlay_GetOption", dxTarget, "width");
		}
		public static new void SetWidth(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxOverlay_SetOption", dxTarget, "width", value);
		}
		public static object Content(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxOverlay_content_0", dxTarget);
		}
		public static object Hide(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxOverlay_hide_1", dxTarget);
		}
		public static void Repaint(ElementRef dxTarget)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxOverlay_repaint_2", dxTarget);
		}
		public static object Show(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxOverlay_show_3", dxTarget);
		}
		public static object Toggle(ElementRef dxTarget, bool showing)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxOverlay_toggle_4", dxTarget, showing);
		}
	}
	public class DxPanoramaInterop: CollectionWidgetInterop
	{
		public static void Init(ElementRef dxTarget, DevExpress.Ui.DxPanoramaOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxPanorama_Init", dxTarget, json);
		}
		public static object GetBackgroundImage(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxPanorama_GetOption", dxTarget, "backgroundImage");
		}
		public static void SetBackgroundImage(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxPanorama_SetOption", dxTarget, "backgroundImage", value);
		}
		public static new bool? GetFocusStateEnabled(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_DxPanorama_GetOption", dxTarget, "focusStateEnabled");
		}
		public static new void SetFocusStateEnabled(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxPanorama_SetOption", dxTarget, "focusStateEnabled", value);
		}
		public static new float? GetSelectedIndex(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<float?>("BlazorDevExtreme_DxPanorama_GetOption", dxTarget, "selectedIndex");
		}
		public static new void SetSelectedIndex(ElementRef dxTarget, float? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxPanorama_SetOption", dxTarget, "selectedIndex", value);
		}
		public static string GetTitle(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_DxPanorama_GetOption", dxTarget, "title");
		}
		public static void SetTitle(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxPanorama_SetOption", dxTarget, "title", value);
		}
	}
	public class DxPivotInterop: CollectionWidgetInterop
	{
		public static void Init(ElementRef dxTarget, DevExpress.Ui.DxPivotOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxPivot_Init", dxTarget, json);
		}
		public static object GetContentTemplate(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxPivot_GetOption", dxTarget, "contentTemplate");
		}
		public static void SetContentTemplate(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxPivot_SetOption", dxTarget, "contentTemplate", value);
		}
		public static object GetItemTitleTemplate(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxPivot_GetOption", dxTarget, "itemTitleTemplate");
		}
		public static void SetItemTitleTemplate(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxPivot_SetOption", dxTarget, "itemTitleTemplate", value);
		}
		public static new float? GetSelectedIndex(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<float?>("BlazorDevExtreme_DxPivot_GetOption", dxTarget, "selectedIndex");
		}
		public static new void SetSelectedIndex(ElementRef dxTarget, float? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxPivot_SetOption", dxTarget, "selectedIndex", value);
		}
		public static bool? GetSwipeEnabled(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_DxPivot_GetOption", dxTarget, "swipeEnabled");
		}
		public static void SetSwipeEnabled(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxPivot_SetOption", dxTarget, "swipeEnabled", value);
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
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxPivotGrid_Init", dxTarget, json);
		}
		[JSInvokable("DevExpress.Ui.DxPivotGridInterop.OnCellClick")]
		public static void OnCellClick(string identifier)
		{
			CellClick?.Invoke(null, new JQueryEventArgs(identifier));
		}
		[JSInvokable("DevExpress.Ui.DxPivotGridInterop.OnCellPrepared")]
		public static void OnCellPrepared(string identifier)
		{
			CellPrepared?.Invoke(null, new JQueryEventArgs(identifier));
		}
		[JSInvokable("DevExpress.Ui.DxPivotGridInterop.OnContextMenuPreparing")]
		public static void OnContextMenuPreparing(string identifier)
		{
			ContextMenuPreparing?.Invoke(null, new JQueryEventArgs(identifier));
		}
		[JSInvokable("DevExpress.Ui.DxPivotGridInterop.OnExported")]
		public static void OnExported(string identifier)
		{
			Exported?.Invoke(null, new JQueryEventArgs(identifier));
		}
		[JSInvokable("DevExpress.Ui.DxPivotGridInterop.OnExporting")]
		public static void OnExporting(string identifier)
		{
			Exporting?.Invoke(null, new JQueryEventArgs(identifier));
		}
		[JSInvokable("DevExpress.Ui.DxPivotGridInterop.OnFileSaving")]
		public static void OnFileSaving(string identifier)
		{
			FileSaving?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static bool? GetAllowExpandAll(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_DxPivotGrid_GetOption", dxTarget, "allowExpandAll");
		}
		public static void SetAllowExpandAll(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxPivotGrid_SetOption", dxTarget, "allowExpandAll", value);
		}
		public static bool? GetAllowFiltering(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_DxPivotGrid_GetOption", dxTarget, "allowFiltering");
		}
		public static void SetAllowFiltering(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxPivotGrid_SetOption", dxTarget, "allowFiltering", value);
		}
		public static bool? GetAllowSorting(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_DxPivotGrid_GetOption", dxTarget, "allowSorting");
		}
		public static void SetAllowSorting(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxPivotGrid_SetOption", dxTarget, "allowSorting", value);
		}
		public static bool? GetAllowSortingBySummary(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_DxPivotGrid_GetOption", dxTarget, "allowSortingBySummary");
		}
		public static void SetAllowSortingBySummary(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxPivotGrid_SetOption", dxTarget, "allowSortingBySummary", value);
		}
		public static string GetDataFieldArea(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_DxPivotGrid_GetOption", dxTarget, "dataFieldArea");
		}
		public static void SetDataFieldArea(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxPivotGrid_SetOption", dxTarget, "dataFieldArea", value);
		}
		public static object GetDataSource(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxPivotGrid_GetOption", dxTarget, "dataSource");
		}
		public static void SetDataSource(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxPivotGrid_SetOption", dxTarget, "dataSource", value);
		}
		public static object GetExport(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxPivotGrid_GetOption", dxTarget, "export");
		}
		public static void SetExport(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxPivotGrid_SetOption", dxTarget, "export", value);
		}
		public static object GetFieldChooser(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxPivotGrid_GetOption", dxTarget, "fieldChooser");
		}
		public static void SetFieldChooser(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxPivotGrid_SetOption", dxTarget, "fieldChooser", value);
		}
		public static object GetFieldPanel(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxPivotGrid_GetOption", dxTarget, "fieldPanel");
		}
		public static void SetFieldPanel(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxPivotGrid_SetOption", dxTarget, "fieldPanel", value);
		}
		public static object GetHeaderFilter(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxPivotGrid_GetOption", dxTarget, "headerFilter");
		}
		public static void SetHeaderFilter(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxPivotGrid_SetOption", dxTarget, "headerFilter", value);
		}
		public static bool? GetHideEmptySummaryCells(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_DxPivotGrid_GetOption", dxTarget, "hideEmptySummaryCells");
		}
		public static void SetHideEmptySummaryCells(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxPivotGrid_SetOption", dxTarget, "hideEmptySummaryCells", value);
		}
		public static object GetLoadPanel(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxPivotGrid_GetOption", dxTarget, "loadPanel");
		}
		public static void SetLoadPanel(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxPivotGrid_SetOption", dxTarget, "loadPanel", value);
		}
		public static string GetRowHeaderLayout(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_DxPivotGrid_GetOption", dxTarget, "rowHeaderLayout");
		}
		public static void SetRowHeaderLayout(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxPivotGrid_SetOption", dxTarget, "rowHeaderLayout", value);
		}
		public static object GetScrolling(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxPivotGrid_GetOption", dxTarget, "scrolling");
		}
		public static void SetScrolling(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxPivotGrid_SetOption", dxTarget, "scrolling", value);
		}
		public static bool? GetShowBorders(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_DxPivotGrid_GetOption", dxTarget, "showBorders");
		}
		public static void SetShowBorders(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxPivotGrid_SetOption", dxTarget, "showBorders", value);
		}
		public static bool? GetShowColumnGrandTotals(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_DxPivotGrid_GetOption", dxTarget, "showColumnGrandTotals");
		}
		public static void SetShowColumnGrandTotals(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxPivotGrid_SetOption", dxTarget, "showColumnGrandTotals", value);
		}
		public static bool? GetShowColumnTotals(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_DxPivotGrid_GetOption", dxTarget, "showColumnTotals");
		}
		public static void SetShowColumnTotals(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxPivotGrid_SetOption", dxTarget, "showColumnTotals", value);
		}
		public static bool? GetShowRowGrandTotals(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_DxPivotGrid_GetOption", dxTarget, "showRowGrandTotals");
		}
		public static void SetShowRowGrandTotals(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxPivotGrid_SetOption", dxTarget, "showRowGrandTotals", value);
		}
		public static bool? GetShowRowTotals(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_DxPivotGrid_GetOption", dxTarget, "showRowTotals");
		}
		public static void SetShowRowTotals(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxPivotGrid_SetOption", dxTarget, "showRowTotals", value);
		}
		public static string GetShowTotalsPrior(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_DxPivotGrid_GetOption", dxTarget, "showTotalsPrior");
		}
		public static void SetShowTotalsPrior(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxPivotGrid_SetOption", dxTarget, "showTotalsPrior", value);
		}
		public static object GetStateStoring(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxPivotGrid_GetOption", dxTarget, "stateStoring");
		}
		public static void SetStateStoring(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxPivotGrid_SetOption", dxTarget, "stateStoring", value);
		}
		public static object GetTexts(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxPivotGrid_GetOption", dxTarget, "texts");
		}
		public static void SetTexts(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxPivotGrid_SetOption", dxTarget, "texts", value);
		}
		public static bool? GetWordWrapEnabled(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_DxPivotGrid_GetOption", dxTarget, "wordWrapEnabled");
		}
		public static void SetWordWrapEnabled(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxPivotGrid_SetOption", dxTarget, "wordWrapEnabled", value);
		}
		public static object BindChart(ElementRef dxTarget, object chart, object integrationOptions)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxPivotGrid_bindChart_0", dxTarget, chart, integrationOptions);
		}
		public static void ExportToExcel(ElementRef dxTarget)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxPivotGrid_exportToExcel_1", dxTarget);
		}
		public static object GetDataSourceEx(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxPivotGrid_getDataSource_2", dxTarget);
		}
		public static object GetFieldChooserPopup(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxPivotGrid_getFieldChooserPopup_3", dxTarget);
		}
		public static void UpdateDimensions(ElementRef dxTarget)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxPivotGrid_updateDimensions_4", dxTarget);
		}
	}
	public class DxPivotGridFieldChooserInterop: WidgetInterop
	{
		public static event EventHandler<JQueryEventArgs> ContextMenuPreparing;
		public static void Init(ElementRef dxTarget, DevExpress.Ui.DxPivotGridFieldChooserOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxPivotGridFieldChooser_Init", dxTarget, json);
		}
		[JSInvokable("DevExpress.Ui.DxPivotGridFieldChooserInterop.OnContextMenuPreparing")]
		public static void OnContextMenuPreparing(string identifier)
		{
			ContextMenuPreparing?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static bool? GetAllowSearch(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_DxPivotGridFieldChooser_GetOption", dxTarget, "allowSearch");
		}
		public static void SetAllowSearch(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxPivotGridFieldChooser_SetOption", dxTarget, "allowSearch", value);
		}
		public static string GetApplyChangesMode(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_DxPivotGridFieldChooser_GetOption", dxTarget, "applyChangesMode");
		}
		public static void SetApplyChangesMode(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxPivotGridFieldChooser_SetOption", dxTarget, "applyChangesMode", value);
		}
		public static object GetDataSource(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxPivotGridFieldChooser_GetOption", dxTarget, "dataSource");
		}
		public static void SetDataSource(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxPivotGridFieldChooser_SetOption", dxTarget, "dataSource", value);
		}
		public static object GetHeaderFilter(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxPivotGridFieldChooser_GetOption", dxTarget, "headerFilter");
		}
		public static void SetHeaderFilter(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxPivotGridFieldChooser_SetOption", dxTarget, "headerFilter", value);
		}
		public static new object GetHeight(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxPivotGridFieldChooser_GetOption", dxTarget, "height");
		}
		public static new void SetHeight(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxPivotGridFieldChooser_SetOption", dxTarget, "height", value);
		}
		public static object GetLayout(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxPivotGridFieldChooser_GetOption", dxTarget, "layout");
		}
		public static void SetLayout(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxPivotGridFieldChooser_SetOption", dxTarget, "layout", value);
		}
		public static object GetState(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxPivotGridFieldChooser_GetOption", dxTarget, "state");
		}
		public static void SetState(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxPivotGridFieldChooser_SetOption", dxTarget, "state", value);
		}
		public static object GetTexts(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxPivotGridFieldChooser_GetOption", dxTarget, "texts");
		}
		public static void SetTexts(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxPivotGridFieldChooser_SetOption", dxTarget, "texts", value);
		}
		public static void ApplyChanges(ElementRef dxTarget)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxPivotGridFieldChooser_applyChanges_0", dxTarget);
		}
		public static void CancelChanges(ElementRef dxTarget)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxPivotGridFieldChooser_cancelChanges_1", dxTarget);
		}
		public static object GetDataSourceEx(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxPivotGridFieldChooser_getDataSource_2", dxTarget);
		}
		public static void UpdateDimensions(ElementRef dxTarget)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxPivotGridFieldChooser_updateDimensions_3", dxTarget);
		}
	}
	public class DxPopoverInterop: DxPopupInterop
	{
		public static void Init(ElementRef dxTarget, DevExpress.Ui.DxPopoverOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxPopover_Init", dxTarget, json);
		}
		public static new object GetAnimation(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxPopover_GetOption", dxTarget, "animation");
		}
		public static new void SetAnimation(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxPopover_SetOption", dxTarget, "animation", value);
		}
		public static new object GetCloseOnOutsideClick(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxPopover_GetOption", dxTarget, "closeOnOutsideClick");
		}
		public static new void SetCloseOnOutsideClick(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxPopover_SetOption", dxTarget, "closeOnOutsideClick", value);
		}
		public static new object GetHeight(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxPopover_GetOption", dxTarget, "height");
		}
		public static new void SetHeight(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxPopover_SetOption", dxTarget, "height", value);
		}
		public static object GetHideEvent(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxPopover_GetOption", dxTarget, "hideEvent");
		}
		public static void SetHideEvent(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxPopover_SetOption", dxTarget, "hideEvent", value);
		}
		public static new object GetPosition(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxPopover_GetOption", dxTarget, "position");
		}
		public static new void SetPosition(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxPopover_SetOption", dxTarget, "position", value);
		}
		public static new bool? GetShading(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_DxPopover_GetOption", dxTarget, "shading");
		}
		public static new void SetShading(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxPopover_SetOption", dxTarget, "shading", value);
		}
		public static object GetShowEvent(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxPopover_GetOption", dxTarget, "showEvent");
		}
		public static void SetShowEvent(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxPopover_SetOption", dxTarget, "showEvent", value);
		}
		public static new bool? GetShowTitle(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_DxPopover_GetOption", dxTarget, "showTitle");
		}
		public static new void SetShowTitle(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxPopover_SetOption", dxTarget, "showTitle", value);
		}
		public static object GetTarget(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxPopover_GetOption", dxTarget, "target");
		}
		public static void SetTarget(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxPopover_SetOption", dxTarget, "target", value);
		}
		public static new object GetWidth(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxPopover_GetOption", dxTarget, "width");
		}
		public static new void SetWidth(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxPopover_SetOption", dxTarget, "width", value);
		}
		public static object Show(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxPopover_show_0", dxTarget);
		}
		public static object Show(ElementRef dxTarget, object target)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxPopover_show_1", dxTarget, target);
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
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxPopup_Init", dxTarget, json);
		}
		[JSInvokable("DevExpress.Ui.DxPopupInterop.OnResize")]
		public static void OnResize(string identifier)
		{
			Resize?.Invoke(null, new JQueryEventArgs(identifier));
		}
		[JSInvokable("DevExpress.Ui.DxPopupInterop.OnResizeEnd")]
		public static void OnResizeEnd(string identifier)
		{
			ResizeEnd?.Invoke(null, new JQueryEventArgs(identifier));
		}
		[JSInvokable("DevExpress.Ui.DxPopupInterop.OnResizeStart")]
		public static void OnResizeStart(string identifier)
		{
			ResizeStart?.Invoke(null, new JQueryEventArgs(identifier));
		}
		[JSInvokable("DevExpress.Ui.DxPopupInterop.OnTitleRendered")]
		public static void OnTitleRendered(string identifier)
		{
			TitleRendered?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static new object GetAnimation(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxPopup_GetOption", dxTarget, "animation");
		}
		public static new void SetAnimation(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxPopup_SetOption", dxTarget, "animation", value);
		}
		public static object GetContainer(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxPopup_GetOption", dxTarget, "container");
		}
		public static void SetContainer(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxPopup_SetOption", dxTarget, "container", value);
		}
		public static new bool? GetDragEnabled(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_DxPopup_GetOption", dxTarget, "dragEnabled");
		}
		public static new void SetDragEnabled(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxPopup_SetOption", dxTarget, "dragEnabled", value);
		}
		public static new bool? GetFocusStateEnabled(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_DxPopup_GetOption", dxTarget, "focusStateEnabled");
		}
		public static new void SetFocusStateEnabled(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxPopup_SetOption", dxTarget, "focusStateEnabled", value);
		}
		public static bool? GetFullScreen(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_DxPopup_GetOption", dxTarget, "fullScreen");
		}
		public static void SetFullScreen(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxPopup_SetOption", dxTarget, "fullScreen", value);
		}
		public static new object GetHeight(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxPopup_GetOption", dxTarget, "height");
		}
		public static new void SetHeight(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxPopup_SetOption", dxTarget, "height", value);
		}
		public static new object GetPosition(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxPopup_GetOption", dxTarget, "position");
		}
		public static new void SetPosition(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxPopup_SetOption", dxTarget, "position", value);
		}
		public static bool? GetResizeEnabled(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_DxPopup_GetOption", dxTarget, "resizeEnabled");
		}
		public static void SetResizeEnabled(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxPopup_SetOption", dxTarget, "resizeEnabled", value);
		}
		public static bool? GetShowCloseButton(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_DxPopup_GetOption", dxTarget, "showCloseButton");
		}
		public static void SetShowCloseButton(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxPopup_SetOption", dxTarget, "showCloseButton", value);
		}
		public static bool? GetShowTitle(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_DxPopup_GetOption", dxTarget, "showTitle");
		}
		public static void SetShowTitle(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxPopup_SetOption", dxTarget, "showTitle", value);
		}
		public static string GetTitle(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_DxPopup_GetOption", dxTarget, "title");
		}
		public static void SetTitle(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxPopup_SetOption", dxTarget, "title", value);
		}
		public static object GetTitleTemplate(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxPopup_GetOption", dxTarget, "titleTemplate");
		}
		public static void SetTitleTemplate(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxPopup_SetOption", dxTarget, "titleTemplate", value);
		}
		public static object GetToolbarItems(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxPopup_GetOption", dxTarget, "toolbarItems");
		}
		public static void SetToolbarItems(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxPopup_SetOption", dxTarget, "toolbarItems", value);
		}
		public static new object GetWidth(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxPopup_GetOption", dxTarget, "width");
		}
		public static new void SetWidth(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxPopup_SetOption", dxTarget, "width", value);
		}
	}
	public class DxProgressBarInterop: DxTrackBarInterop
	{
		public static event EventHandler<JQueryEventArgs> Complete;
		public static void Init(ElementRef dxTarget, DevExpress.Ui.DxProgressBarOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxProgressBar_Init", dxTarget, json);
		}
		[JSInvokable("DevExpress.Ui.DxProgressBarInterop.OnComplete")]
		public static void OnComplete(string identifier)
		{
			Complete?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static bool? GetShowStatus(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_DxProgressBar_GetOption", dxTarget, "showStatus");
		}
		public static void SetShowStatus(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxProgressBar_SetOption", dxTarget, "showStatus", value);
		}
		public static object GetStatusFormat(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxProgressBar_GetOption", dxTarget, "statusFormat");
		}
		public static void SetStatusFormat(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxProgressBar_SetOption", dxTarget, "statusFormat", value);
		}
		public static new float? GetValue(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<float?>("BlazorDevExtreme_DxProgressBar_GetOption", dxTarget, "value");
		}
		public static new void SetValue(ElementRef dxTarget, float? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxProgressBar_SetOption", dxTarget, "value", value);
		}
	}
	public class DxRadioGroupInterop: EditorInterop
	{
		public static void Init(ElementRef dxTarget, DevExpress.Ui.DxRadioGroupOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxRadioGroup_Init", dxTarget, json);
		}
		public static new bool? GetActiveStateEnabled(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_DxRadioGroup_GetOption", dxTarget, "activeStateEnabled");
		}
		public static new void SetActiveStateEnabled(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxRadioGroup_SetOption", dxTarget, "activeStateEnabled", value);
		}
		public static new bool? GetFocusStateEnabled(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_DxRadioGroup_GetOption", dxTarget, "focusStateEnabled");
		}
		public static new void SetFocusStateEnabled(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxRadioGroup_SetOption", dxTarget, "focusStateEnabled", value);
		}
		public static new bool? GetHoverStateEnabled(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_DxRadioGroup_GetOption", dxTarget, "hoverStateEnabled");
		}
		public static new void SetHoverStateEnabled(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxRadioGroup_SetOption", dxTarget, "hoverStateEnabled", value);
		}
		public static string GetLayout(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_DxRadioGroup_GetOption", dxTarget, "layout");
		}
		public static void SetLayout(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxRadioGroup_SetOption", dxTarget, "layout", value);
		}
		public static string GetName(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_DxRadioGroup_GetOption", dxTarget, "name");
		}
		public static void SetName(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxRadioGroup_SetOption", dxTarget, "name", value);
		}
		public static new object GetValue(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxRadioGroup_GetOption", dxTarget, "value");
		}
		public static new void SetValue(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxRadioGroup_SetOption", dxTarget, "value", value);
		}
		public static object GetDataSourceEx(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxRadioGroup_getDataSource_0", dxTarget);
		}
	}
	public class DxRangeSliderInterop: DxSliderBaseInterop
	{
		public static event EventHandler<JQueryEventArgs> ValueChanged;
		public static void Init(ElementRef dxTarget, DevExpress.Ui.DxRangeSliderOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxRangeSlider_Init", dxTarget, json);
		}
		[JSInvokable("DevExpress.Ui.DxRangeSliderInterop.OnValueChanged")]
		public static void OnValueChanged(string identifier)
		{
			ValueChanged?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static float? GetEnd(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<float?>("BlazorDevExtreme_DxRangeSlider_GetOption", dxTarget, "end");
		}
		public static void SetEnd(ElementRef dxTarget, float? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxRangeSlider_SetOption", dxTarget, "end", value);
		}
		public static string GetEndName(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_DxRangeSlider_GetOption", dxTarget, "endName");
		}
		public static void SetEndName(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxRangeSlider_SetOption", dxTarget, "endName", value);
		}
		public static float? GetStart(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<float?>("BlazorDevExtreme_DxRangeSlider_GetOption", dxTarget, "start");
		}
		public static void SetStart(ElementRef dxTarget, float? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxRangeSlider_SetOption", dxTarget, "start", value);
		}
		public static string GetStartName(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_DxRangeSlider_GetOption", dxTarget, "startName");
		}
		public static void SetStartName(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxRangeSlider_SetOption", dxTarget, "startName", value);
		}
		public static new object GetValue(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxRangeSlider_GetOption", dxTarget, "value");
		}
		public static new void SetValue(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxRangeSlider_SetOption", dxTarget, "value", value);
		}
		public static void Reset(ElementRef dxTarget)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxRangeSlider_reset_0", dxTarget);
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
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxResizable_Init", dxTarget, json);
		}
		[JSInvokable("DevExpress.Ui.DxResizableInterop.OnResize")]
		public static void OnResize(string identifier)
		{
			Resize?.Invoke(null, new JQueryEventArgs(identifier));
		}
		[JSInvokable("DevExpress.Ui.DxResizableInterop.OnResizeEnd")]
		public static void OnResizeEnd(string identifier)
		{
			ResizeEnd?.Invoke(null, new JQueryEventArgs(identifier));
		}
		[JSInvokable("DevExpress.Ui.DxResizableInterop.OnResizeStart")]
		public static void OnResizeStart(string identifier)
		{
			ResizeStart?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static string GetHandles(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_DxResizable_GetOption", dxTarget, "handles");
		}
		public static void SetHandles(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxResizable_SetOption", dxTarget, "handles", value);
		}
		public static new object GetHeight(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxResizable_GetOption", dxTarget, "height");
		}
		public static new void SetHeight(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxResizable_SetOption", dxTarget, "height", value);
		}
		public static float? GetMaxHeight(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<float?>("BlazorDevExtreme_DxResizable_GetOption", dxTarget, "maxHeight");
		}
		public static void SetMaxHeight(ElementRef dxTarget, float? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxResizable_SetOption", dxTarget, "maxHeight", value);
		}
		public static float? GetMaxWidth(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<float?>("BlazorDevExtreme_DxResizable_GetOption", dxTarget, "maxWidth");
		}
		public static void SetMaxWidth(ElementRef dxTarget, float? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxResizable_SetOption", dxTarget, "maxWidth", value);
		}
		public static float? GetMinHeight(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<float?>("BlazorDevExtreme_DxResizable_GetOption", dxTarget, "minHeight");
		}
		public static void SetMinHeight(ElementRef dxTarget, float? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxResizable_SetOption", dxTarget, "minHeight", value);
		}
		public static float? GetMinWidth(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<float?>("BlazorDevExtreme_DxResizable_GetOption", dxTarget, "minWidth");
		}
		public static void SetMinWidth(ElementRef dxTarget, float? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxResizable_SetOption", dxTarget, "minWidth", value);
		}
		public static new object GetWidth(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxResizable_GetOption", dxTarget, "width");
		}
		public static new void SetWidth(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxResizable_SetOption", dxTarget, "width", value);
		}
	}
	public class DxResponsiveBoxInterop: CollectionWidgetInterop
	{
		public static void Init(ElementRef dxTarget, DevExpress.Ui.DxResponsiveBoxOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxResponsiveBox_Init", dxTarget, json);
		}
		public static object GetCols(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxResponsiveBox_GetOption", dxTarget, "cols");
		}
		public static void SetCols(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxResponsiveBox_SetOption", dxTarget, "cols", value);
		}
		public static new object GetHeight(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxResponsiveBox_GetOption", dxTarget, "height");
		}
		public static new void SetHeight(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxResponsiveBox_SetOption", dxTarget, "height", value);
		}
		public static object GetRows(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxResponsiveBox_GetOption", dxTarget, "rows");
		}
		public static void SetRows(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxResponsiveBox_SetOption", dxTarget, "rows", value);
		}
		public static object GetScreenByWidth(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxResponsiveBox_GetOption", dxTarget, "screenByWidth");
		}
		public static void SetScreenByWidth(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxResponsiveBox_SetOption", dxTarget, "screenByWidth", value);
		}
		public static string GetSingleColumnScreen(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_DxResponsiveBox_GetOption", dxTarget, "singleColumnScreen");
		}
		public static void SetSingleColumnScreen(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxResponsiveBox_SetOption", dxTarget, "singleColumnScreen", value);
		}
		public static new object GetWidth(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxResponsiveBox_GetOption", dxTarget, "width");
		}
		public static new void SetWidth(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxResponsiveBox_SetOption", dxTarget, "width", value);
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
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxScheduler_Init", dxTarget, json);
		}
		[JSInvokable("DevExpress.Ui.DxSchedulerInterop.OnAppointmentAdded")]
		public static void OnAppointmentAdded(string identifier)
		{
			AppointmentAdded?.Invoke(null, new JQueryEventArgs(identifier));
		}
		[JSInvokable("DevExpress.Ui.DxSchedulerInterop.OnAppointmentAdding")]
		public static void OnAppointmentAdding(string identifier)
		{
			AppointmentAdding?.Invoke(null, new JQueryEventArgs(identifier));
		}
		[JSInvokable("DevExpress.Ui.DxSchedulerInterop.OnAppointmentClick")]
		public static void OnAppointmentClick(string identifier)
		{
			AppointmentClick?.Invoke(null, new JQueryEventArgs(identifier));
		}
		[JSInvokable("DevExpress.Ui.DxSchedulerInterop.OnAppointmentContextMenu")]
		public static void OnAppointmentContextMenu(string identifier)
		{
			AppointmentContextMenu?.Invoke(null, new JQueryEventArgs(identifier));
		}
		[JSInvokable("DevExpress.Ui.DxSchedulerInterop.OnAppointmentDblClick")]
		public static void OnAppointmentDblClick(string identifier)
		{
			AppointmentDblClick?.Invoke(null, new JQueryEventArgs(identifier));
		}
		[JSInvokable("DevExpress.Ui.DxSchedulerInterop.OnAppointmentDeleted")]
		public static void OnAppointmentDeleted(string identifier)
		{
			AppointmentDeleted?.Invoke(null, new JQueryEventArgs(identifier));
		}
		[JSInvokable("DevExpress.Ui.DxSchedulerInterop.OnAppointmentDeleting")]
		public static void OnAppointmentDeleting(string identifier)
		{
			AppointmentDeleting?.Invoke(null, new JQueryEventArgs(identifier));
		}
		[JSInvokable("DevExpress.Ui.DxSchedulerInterop.OnAppointmentFormCreated")]
		public static void OnAppointmentFormCreated(string identifier)
		{
			AppointmentFormCreated?.Invoke(null, new JQueryEventArgs(identifier));
		}
		[JSInvokable("DevExpress.Ui.DxSchedulerInterop.OnAppointmentRendered")]
		public static void OnAppointmentRendered(string identifier)
		{
			AppointmentRendered?.Invoke(null, new JQueryEventArgs(identifier));
		}
		[JSInvokable("DevExpress.Ui.DxSchedulerInterop.OnAppointmentUpdated")]
		public static void OnAppointmentUpdated(string identifier)
		{
			AppointmentUpdated?.Invoke(null, new JQueryEventArgs(identifier));
		}
		[JSInvokable("DevExpress.Ui.DxSchedulerInterop.OnAppointmentUpdating")]
		public static void OnAppointmentUpdating(string identifier)
		{
			AppointmentUpdating?.Invoke(null, new JQueryEventArgs(identifier));
		}
		[JSInvokable("DevExpress.Ui.DxSchedulerInterop.OnCellClick")]
		public static void OnCellClick(string identifier)
		{
			CellClick?.Invoke(null, new JQueryEventArgs(identifier));
		}
		[JSInvokable("DevExpress.Ui.DxSchedulerInterop.OnCellContextMenu")]
		public static void OnCellContextMenu(string identifier)
		{
			CellContextMenu?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static string GetAllDayExpr(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_DxScheduler_GetOption", dxTarget, "allDayExpr");
		}
		public static void SetAllDayExpr(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxScheduler_SetOption", dxTarget, "allDayExpr", value);
		}
		public static object GetAppointmentTemplate(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxScheduler_GetOption", dxTarget, "appointmentTemplate");
		}
		public static void SetAppointmentTemplate(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxScheduler_SetOption", dxTarget, "appointmentTemplate", value);
		}
		public static object GetAppointmentTooltipTemplate(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxScheduler_GetOption", dxTarget, "appointmentTooltipTemplate");
		}
		public static void SetAppointmentTooltipTemplate(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxScheduler_SetOption", dxTarget, "appointmentTooltipTemplate", value);
		}
		public static float? GetCellDuration(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<float?>("BlazorDevExtreme_DxScheduler_GetOption", dxTarget, "cellDuration");
		}
		public static void SetCellDuration(ElementRef dxTarget, float? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxScheduler_SetOption", dxTarget, "cellDuration", value);
		}
		public static bool? GetCrossScrollingEnabled(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_DxScheduler_GetOption", dxTarget, "crossScrollingEnabled");
		}
		public static void SetCrossScrollingEnabled(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxScheduler_SetOption", dxTarget, "crossScrollingEnabled", value);
		}
		public static object GetCurrentDate(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxScheduler_GetOption", dxTarget, "currentDate");
		}
		public static void SetCurrentDate(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxScheduler_SetOption", dxTarget, "currentDate", value);
		}
		public static string GetCurrentView(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_DxScheduler_GetOption", dxTarget, "currentView");
		}
		public static void SetCurrentView(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxScheduler_SetOption", dxTarget, "currentView", value);
		}
		public static object GetDataCellTemplate(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxScheduler_GetOption", dxTarget, "dataCellTemplate");
		}
		public static void SetDataCellTemplate(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxScheduler_SetOption", dxTarget, "dataCellTemplate", value);
		}
		public static object GetDataSource(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxScheduler_GetOption", dxTarget, "dataSource");
		}
		public static void SetDataSource(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxScheduler_SetOption", dxTarget, "dataSource", value);
		}
		public static object GetDateCellTemplate(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxScheduler_GetOption", dxTarget, "dateCellTemplate");
		}
		public static void SetDateCellTemplate(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxScheduler_SetOption", dxTarget, "dateCellTemplate", value);
		}
		public static string GetDateSerializationFormat(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_DxScheduler_GetOption", dxTarget, "dateSerializationFormat");
		}
		public static void SetDateSerializationFormat(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxScheduler_SetOption", dxTarget, "dateSerializationFormat", value);
		}
		public static string GetDescriptionExpr(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_DxScheduler_GetOption", dxTarget, "descriptionExpr");
		}
		public static void SetDescriptionExpr(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxScheduler_SetOption", dxTarget, "descriptionExpr", value);
		}
		public static object GetDropDownAppointmentTemplate(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxScheduler_GetOption", dxTarget, "dropDownAppointmentTemplate");
		}
		public static void SetDropDownAppointmentTemplate(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxScheduler_SetOption", dxTarget, "dropDownAppointmentTemplate", value);
		}
		public static object GetEditing(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxScheduler_GetOption", dxTarget, "editing");
		}
		public static void SetEditing(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxScheduler_SetOption", dxTarget, "editing", value);
		}
		public static string GetEndDateExpr(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_DxScheduler_GetOption", dxTarget, "endDateExpr");
		}
		public static void SetEndDateExpr(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxScheduler_SetOption", dxTarget, "endDateExpr", value);
		}
		public static string GetEndDateTimeZoneExpr(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_DxScheduler_GetOption", dxTarget, "endDateTimeZoneExpr");
		}
		public static void SetEndDateTimeZoneExpr(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxScheduler_SetOption", dxTarget, "endDateTimeZoneExpr", value);
		}
		public static float? GetEndDayHour(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<float?>("BlazorDevExtreme_DxScheduler_GetOption", dxTarget, "endDayHour");
		}
		public static void SetEndDayHour(ElementRef dxTarget, float? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxScheduler_SetOption", dxTarget, "endDayHour", value);
		}
		public static object GetFirstDayOfWeek(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxScheduler_GetOption", dxTarget, "firstDayOfWeek");
		}
		public static void SetFirstDayOfWeek(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxScheduler_SetOption", dxTarget, "firstDayOfWeek", value);
		}
		public static new bool? GetFocusStateEnabled(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_DxScheduler_GetOption", dxTarget, "focusStateEnabled");
		}
		public static new void SetFocusStateEnabled(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxScheduler_SetOption", dxTarget, "focusStateEnabled", value);
		}
		public static object GetGroups(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxScheduler_GetOption", dxTarget, "groups");
		}
		public static void SetGroups(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxScheduler_SetOption", dxTarget, "groups", value);
		}
		public static float? GetIndicatorUpdateInterval(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<float?>("BlazorDevExtreme_DxScheduler_GetOption", dxTarget, "indicatorUpdateInterval");
		}
		public static void SetIndicatorUpdateInterval(ElementRef dxTarget, float? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxScheduler_SetOption", dxTarget, "indicatorUpdateInterval", value);
		}
		public static object GetMax(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxScheduler_GetOption", dxTarget, "max");
		}
		public static void SetMax(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxScheduler_SetOption", dxTarget, "max", value);
		}
		public static object GetMaxAppointmentsPerCell(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxScheduler_GetOption", dxTarget, "maxAppointmentsPerCell");
		}
		public static void SetMaxAppointmentsPerCell(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxScheduler_SetOption", dxTarget, "maxAppointmentsPerCell", value);
		}
		public static object GetMin(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxScheduler_GetOption", dxTarget, "min");
		}
		public static void SetMin(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxScheduler_SetOption", dxTarget, "min", value);
		}
		public static string GetNoDataText(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_DxScheduler_GetOption", dxTarget, "noDataText");
		}
		public static void SetNoDataText(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxScheduler_SetOption", dxTarget, "noDataText", value);
		}
		public static string GetRecurrenceEditMode(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_DxScheduler_GetOption", dxTarget, "recurrenceEditMode");
		}
		public static void SetRecurrenceEditMode(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxScheduler_SetOption", dxTarget, "recurrenceEditMode", value);
		}
		public static string GetRecurrenceExceptionExpr(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_DxScheduler_GetOption", dxTarget, "recurrenceExceptionExpr");
		}
		public static void SetRecurrenceExceptionExpr(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxScheduler_SetOption", dxTarget, "recurrenceExceptionExpr", value);
		}
		public static string GetRecurrenceRuleExpr(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_DxScheduler_GetOption", dxTarget, "recurrenceRuleExpr");
		}
		public static void SetRecurrenceRuleExpr(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxScheduler_SetOption", dxTarget, "recurrenceRuleExpr", value);
		}
		public static bool? GetRemoteFiltering(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_DxScheduler_GetOption", dxTarget, "remoteFiltering");
		}
		public static void SetRemoteFiltering(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxScheduler_SetOption", dxTarget, "remoteFiltering", value);
		}
		public static object GetResourceCellTemplate(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxScheduler_GetOption", dxTarget, "resourceCellTemplate");
		}
		public static void SetResourceCellTemplate(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxScheduler_SetOption", dxTarget, "resourceCellTemplate", value);
		}
		public static object GetResources(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxScheduler_GetOption", dxTarget, "resources");
		}
		public static void SetResources(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxScheduler_SetOption", dxTarget, "resources", value);
		}
		public static object GetSelectedCellData(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxScheduler_GetOption", dxTarget, "selectedCellData");
		}
		public static void SetSelectedCellData(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxScheduler_SetOption", dxTarget, "selectedCellData", value);
		}
		public static bool? GetShadeUntilCurrentTime(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_DxScheduler_GetOption", dxTarget, "shadeUntilCurrentTime");
		}
		public static void SetShadeUntilCurrentTime(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxScheduler_SetOption", dxTarget, "shadeUntilCurrentTime", value);
		}
		public static bool? GetShowAllDayPanel(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_DxScheduler_GetOption", dxTarget, "showAllDayPanel");
		}
		public static void SetShowAllDayPanel(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxScheduler_SetOption", dxTarget, "showAllDayPanel", value);
		}
		public static bool? GetShowCurrentTimeIndicator(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_DxScheduler_GetOption", dxTarget, "showCurrentTimeIndicator");
		}
		public static void SetShowCurrentTimeIndicator(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxScheduler_SetOption", dxTarget, "showCurrentTimeIndicator", value);
		}
		public static string GetStartDateExpr(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_DxScheduler_GetOption", dxTarget, "startDateExpr");
		}
		public static void SetStartDateExpr(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxScheduler_SetOption", dxTarget, "startDateExpr", value);
		}
		public static string GetStartDateTimeZoneExpr(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_DxScheduler_GetOption", dxTarget, "startDateTimeZoneExpr");
		}
		public static void SetStartDateTimeZoneExpr(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxScheduler_SetOption", dxTarget, "startDateTimeZoneExpr", value);
		}
		public static float? GetStartDayHour(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<float?>("BlazorDevExtreme_DxScheduler_GetOption", dxTarget, "startDayHour");
		}
		public static void SetStartDayHour(ElementRef dxTarget, float? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxScheduler_SetOption", dxTarget, "startDayHour", value);
		}
		public static string GetTextExpr(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_DxScheduler_GetOption", dxTarget, "textExpr");
		}
		public static void SetTextExpr(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxScheduler_SetOption", dxTarget, "textExpr", value);
		}
		public static object GetTimeCellTemplate(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxScheduler_GetOption", dxTarget, "timeCellTemplate");
		}
		public static void SetTimeCellTemplate(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxScheduler_SetOption", dxTarget, "timeCellTemplate", value);
		}
		public static string GetTimeZone(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_DxScheduler_GetOption", dxTarget, "timeZone");
		}
		public static void SetTimeZone(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxScheduler_SetOption", dxTarget, "timeZone", value);
		}
		public static bool? GetUseDropDownViewSwitcher(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_DxScheduler_GetOption", dxTarget, "useDropDownViewSwitcher");
		}
		public static void SetUseDropDownViewSwitcher(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxScheduler_SetOption", dxTarget, "useDropDownViewSwitcher", value);
		}
		public static object GetViews(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxScheduler_GetOption", dxTarget, "views");
		}
		public static void SetViews(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxScheduler_SetOption", dxTarget, "views", value);
		}
		public static void AddAppointment(ElementRef dxTarget, object appointment)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxScheduler_addAppointment_0", dxTarget, appointment);
		}
		public static void DeleteAppointment(ElementRef dxTarget, object appointment)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxScheduler_deleteAppointment_1", dxTarget, appointment);
		}
		public static object GetDataSourceEx(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxScheduler_getDataSource_2", dxTarget);
		}
		public static object GetEndViewDate(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxScheduler_getEndViewDate_3", dxTarget);
		}
		public static object GetStartViewDate(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxScheduler_getStartViewDate_4", dxTarget);
		}
		public static void HideAppointmentPopup(ElementRef dxTarget, bool saveChanges)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxScheduler_hideAppointmentPopup_5", dxTarget, saveChanges);
		}
		public static void HideAppointmentTooltip(ElementRef dxTarget)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxScheduler_hideAppointmentTooltip_6", dxTarget);
		}
		public static void RegisterKeyHandler(ElementRef dxTarget)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxScheduler_registerKeyHandler_7", dxTarget);
		}
		public static void ScrollToTime(ElementRef dxTarget, float hours, float minutes, object date)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxScheduler_scrollToTime_8", dxTarget, hours, minutes, date);
		}
		public static void ShowAppointmentPopup(ElementRef dxTarget, object appointmentData, bool createNewAppointment, object currentAppointmentData)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxScheduler_showAppointmentPopup_9", dxTarget, appointmentData, createNewAppointment, currentAppointmentData);
		}
		public static void ShowAppointmentTooltip(ElementRef dxTarget, object appointmentData, object target, object currentAppointmentData)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxScheduler_showAppointmentTooltip_10", dxTarget, appointmentData, target, currentAppointmentData);
		}
		public static void UpdateAppointment(ElementRef dxTarget, object target, object appointment)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxScheduler_updateAppointment_11", dxTarget, target, appointment);
		}
	}
	public class DxScrollViewInterop: DxScrollableInterop
	{
		public static event EventHandler<JQueryEventArgs> PullDown;
		public static event EventHandler<JQueryEventArgs> ReachBottom;
		public static void Init(ElementRef dxTarget, DevExpress.Ui.DxScrollViewOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxScrollView_Init", dxTarget, json);
		}
		[JSInvokable("DevExpress.Ui.DxScrollViewInterop.OnPullDown")]
		public static void OnPullDown(string identifier)
		{
			PullDown?.Invoke(null, new JQueryEventArgs(identifier));
		}
		[JSInvokable("DevExpress.Ui.DxScrollViewInterop.OnReachBottom")]
		public static void OnReachBottom(string identifier)
		{
			ReachBottom?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static string GetPulledDownText(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_DxScrollView_GetOption", dxTarget, "pulledDownText");
		}
		public static void SetPulledDownText(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxScrollView_SetOption", dxTarget, "pulledDownText", value);
		}
		public static string GetPullingDownText(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_DxScrollView_GetOption", dxTarget, "pullingDownText");
		}
		public static void SetPullingDownText(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxScrollView_SetOption", dxTarget, "pullingDownText", value);
		}
		public static string GetReachBottomText(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_DxScrollView_GetOption", dxTarget, "reachBottomText");
		}
		public static void SetReachBottomText(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxScrollView_SetOption", dxTarget, "reachBottomText", value);
		}
		public static string GetRefreshingText(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_DxScrollView_GetOption", dxTarget, "refreshingText");
		}
		public static void SetRefreshingText(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxScrollView_SetOption", dxTarget, "refreshingText", value);
		}
		public static void Refresh(ElementRef dxTarget)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxScrollView_refresh_0", dxTarget);
		}
		public static object Release(ElementRef dxTarget, bool preventScrollBottom)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxScrollView_release_1", dxTarget, preventScrollBottom);
		}
	}
	public class DxSelectBoxInterop: DxDropDownListInterop
	{
		public static event EventHandler<JQueryEventArgs> CustomItemCreating;
		public static void Init(ElementRef dxTarget, DevExpress.Ui.DxSelectBoxOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxSelectBox_Init", dxTarget, json);
		}
		[JSInvokable("DevExpress.Ui.DxSelectBoxInterop.OnCustomItemCreating")]
		public static void OnCustomItemCreating(string identifier)
		{
			CustomItemCreating?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static new bool? GetAcceptCustomValue(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_DxSelectBox_GetOption", dxTarget, "acceptCustomValue");
		}
		public static new void SetAcceptCustomValue(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxSelectBox_SetOption", dxTarget, "acceptCustomValue", value);
		}
		public static object GetFieldTemplate(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxSelectBox_GetOption", dxTarget, "fieldTemplate");
		}
		public static void SetFieldTemplate(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxSelectBox_SetOption", dxTarget, "fieldTemplate", value);
		}
		public static new string GetPlaceholder(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_DxSelectBox_GetOption", dxTarget, "placeholder");
		}
		public static new void SetPlaceholder(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxSelectBox_SetOption", dxTarget, "placeholder", value);
		}
		public static bool? GetShowSelectionControls(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_DxSelectBox_GetOption", dxTarget, "showSelectionControls");
		}
		public static void SetShowSelectionControls(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxSelectBox_SetOption", dxTarget, "showSelectionControls", value);
		}
		public static new string GetValueChangeEvent(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_DxSelectBox_GetOption", dxTarget, "valueChangeEvent");
		}
		public static new void SetValueChangeEvent(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxSelectBox_SetOption", dxTarget, "valueChangeEvent", value);
		}
	}
	public class DxSliderInterop: DxSliderBaseInterop
	{
		public static void Init(ElementRef dxTarget, DevExpress.Ui.DxSliderOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxSlider_Init", dxTarget, json);
		}
		public static new float? GetValue(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<float?>("BlazorDevExtreme_DxSlider_GetOption", dxTarget, "value");
		}
		public static new void SetValue(ElementRef dxTarget, float? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxSlider_SetOption", dxTarget, "value", value);
		}
	}
	public class DxSlideOutInterop: CollectionWidgetInterop
	{
		public static event EventHandler<JQueryEventArgs> MenuGroupRendered;
		public static event EventHandler<JQueryEventArgs> MenuItemRendered;
		public static void Init(ElementRef dxTarget, DevExpress.Ui.DxSlideOutOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxSlideOut_Init", dxTarget, json);
		}
		[JSInvokable("DevExpress.Ui.DxSlideOutInterop.OnMenuGroupRendered")]
		public static void OnMenuGroupRendered(string identifier)
		{
			MenuGroupRendered?.Invoke(null, new JQueryEventArgs(identifier));
		}
		[JSInvokable("DevExpress.Ui.DxSlideOutInterop.OnMenuItemRendered")]
		public static void OnMenuItemRendered(string identifier)
		{
			MenuItemRendered?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static new bool? GetActiveStateEnabled(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_DxSlideOut_GetOption", dxTarget, "activeStateEnabled");
		}
		public static new void SetActiveStateEnabled(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxSlideOut_SetOption", dxTarget, "activeStateEnabled", value);
		}
		public static object GetContentTemplate(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxSlideOut_GetOption", dxTarget, "contentTemplate");
		}
		public static void SetContentTemplate(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxSlideOut_SetOption", dxTarget, "contentTemplate", value);
		}
		public static bool? GetMenuGrouped(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_DxSlideOut_GetOption", dxTarget, "menuGrouped");
		}
		public static void SetMenuGrouped(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxSlideOut_SetOption", dxTarget, "menuGrouped", value);
		}
		public static object GetMenuGroupTemplate(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxSlideOut_GetOption", dxTarget, "menuGroupTemplate");
		}
		public static void SetMenuGroupTemplate(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxSlideOut_SetOption", dxTarget, "menuGroupTemplate", value);
		}
		public static object GetMenuItemTemplate(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxSlideOut_GetOption", dxTarget, "menuItemTemplate");
		}
		public static void SetMenuItemTemplate(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxSlideOut_SetOption", dxTarget, "menuItemTemplate", value);
		}
		public static string GetMenuPosition(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_DxSlideOut_GetOption", dxTarget, "menuPosition");
		}
		public static void SetMenuPosition(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxSlideOut_SetOption", dxTarget, "menuPosition", value);
		}
		public static bool? GetMenuVisible(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_DxSlideOut_GetOption", dxTarget, "menuVisible");
		}
		public static void SetMenuVisible(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxSlideOut_SetOption", dxTarget, "menuVisible", value);
		}
		public static new float? GetSelectedIndex(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<float?>("BlazorDevExtreme_DxSlideOut_GetOption", dxTarget, "selectedIndex");
		}
		public static new void SetSelectedIndex(ElementRef dxTarget, float? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxSlideOut_SetOption", dxTarget, "selectedIndex", value);
		}
		public static bool? GetSwipeEnabled(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_DxSlideOut_GetOption", dxTarget, "swipeEnabled");
		}
		public static void SetSwipeEnabled(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxSlideOut_SetOption", dxTarget, "swipeEnabled", value);
		}
		public static object HideMenu(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxSlideOut_hideMenu_0", dxTarget);
		}
		public static object ShowMenu(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxSlideOut_showMenu_1", dxTarget);
		}
		public static object ToggleMenuVisibility(ElementRef dxTarget, bool showing)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxSlideOut_toggleMenuVisibility_2", dxTarget, showing);
		}
	}
	public class DxSlideOutViewInterop: WidgetInterop
	{
		public static void Init(ElementRef dxTarget, DevExpress.Ui.DxSlideOutViewOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxSlideOutView_Init", dxTarget, json);
		}
		public static object GetContentTemplate(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxSlideOutView_GetOption", dxTarget, "contentTemplate");
		}
		public static void SetContentTemplate(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxSlideOutView_SetOption", dxTarget, "contentTemplate", value);
		}
		public static string GetMenuPosition(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_DxSlideOutView_GetOption", dxTarget, "menuPosition");
		}
		public static void SetMenuPosition(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxSlideOutView_SetOption", dxTarget, "menuPosition", value);
		}
		public static object GetMenuTemplate(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxSlideOutView_GetOption", dxTarget, "menuTemplate");
		}
		public static void SetMenuTemplate(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxSlideOutView_SetOption", dxTarget, "menuTemplate", value);
		}
		public static bool? GetMenuVisible(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_DxSlideOutView_GetOption", dxTarget, "menuVisible");
		}
		public static void SetMenuVisible(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxSlideOutView_SetOption", dxTarget, "menuVisible", value);
		}
		public static bool? GetSwipeEnabled(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_DxSlideOutView_GetOption", dxTarget, "swipeEnabled");
		}
		public static void SetSwipeEnabled(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxSlideOutView_SetOption", dxTarget, "swipeEnabled", value);
		}
		public static object Content(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxSlideOutView_content_0", dxTarget);
		}
		public static object HideMenu(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxSlideOutView_hideMenu_1", dxTarget);
		}
		public static object MenuContent(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxSlideOutView_menuContent_2", dxTarget);
		}
		public static object ShowMenu(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxSlideOutView_showMenu_3", dxTarget);
		}
		public static object ToggleMenuVisibility(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxSlideOutView_toggleMenuVisibility_4", dxTarget);
		}
	}
	public class DxSwitchInterop: EditorInterop
	{
		public static void Init(ElementRef dxTarget, DevExpress.Ui.DxSwitchOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxSwitch_Init", dxTarget, json);
		}
		public static new bool? GetActiveStateEnabled(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_DxSwitch_GetOption", dxTarget, "activeStateEnabled");
		}
		public static new void SetActiveStateEnabled(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxSwitch_SetOption", dxTarget, "activeStateEnabled", value);
		}
		public static new bool? GetFocusStateEnabled(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_DxSwitch_GetOption", dxTarget, "focusStateEnabled");
		}
		public static new void SetFocusStateEnabled(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxSwitch_SetOption", dxTarget, "focusStateEnabled", value);
		}
		public static new bool? GetHoverStateEnabled(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_DxSwitch_GetOption", dxTarget, "hoverStateEnabled");
		}
		public static new void SetHoverStateEnabled(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxSwitch_SetOption", dxTarget, "hoverStateEnabled", value);
		}
		public static string GetName(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_DxSwitch_GetOption", dxTarget, "name");
		}
		public static void SetName(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxSwitch_SetOption", dxTarget, "name", value);
		}
		public static string GetOffText(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_DxSwitch_GetOption", dxTarget, "offText");
		}
		public static void SetOffText(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxSwitch_SetOption", dxTarget, "offText", value);
		}
		public static string GetOnText(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_DxSwitch_GetOption", dxTarget, "onText");
		}
		public static void SetOnText(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxSwitch_SetOption", dxTarget, "onText", value);
		}
		public static new bool? GetValue(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_DxSwitch_GetOption", dxTarget, "value");
		}
		public static new void SetValue(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxSwitch_SetOption", dxTarget, "value", value);
		}
	}
	public class DxTabsInterop: CollectionWidgetInterop
	{
		public static void Init(ElementRef dxTarget, DevExpress.Ui.DxTabsOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxTabs_Init", dxTarget, json);
		}
		public static new bool? GetFocusStateEnabled(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_DxTabs_GetOption", dxTarget, "focusStateEnabled");
		}
		public static new void SetFocusStateEnabled(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxTabs_SetOption", dxTarget, "focusStateEnabled", value);
		}
		public static new bool? GetHoverStateEnabled(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_DxTabs_GetOption", dxTarget, "hoverStateEnabled");
		}
		public static new void SetHoverStateEnabled(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxTabs_SetOption", dxTarget, "hoverStateEnabled", value);
		}
		public static bool? GetScrollByContent(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_DxTabs_GetOption", dxTarget, "scrollByContent");
		}
		public static void SetScrollByContent(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxTabs_SetOption", dxTarget, "scrollByContent", value);
		}
		public static bool? GetScrollingEnabled(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_DxTabs_GetOption", dxTarget, "scrollingEnabled");
		}
		public static void SetScrollingEnabled(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxTabs_SetOption", dxTarget, "scrollingEnabled", value);
		}
		public static new object GetSelectedItems(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxTabs_GetOption", dxTarget, "selectedItems");
		}
		public static new void SetSelectedItems(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxTabs_SetOption", dxTarget, "selectedItems", value);
		}
		public static string GetSelectionMode(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_DxTabs_GetOption", dxTarget, "selectionMode");
		}
		public static void SetSelectionMode(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxTabs_SetOption", dxTarget, "selectionMode", value);
		}
		public static bool? GetShowNavButtons(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_DxTabs_GetOption", dxTarget, "showNavButtons");
		}
		public static void SetShowNavButtons(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxTabs_SetOption", dxTarget, "showNavButtons", value);
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
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxTabPanel_Init", dxTarget, json);
		}
		[JSInvokable("DevExpress.Ui.DxTabPanelInterop.OnTitleClick")]
		public static void OnTitleClick(string identifier)
		{
			TitleClick?.Invoke(null, new JQueryEventArgs(identifier));
		}
		[JSInvokable("DevExpress.Ui.DxTabPanelInterop.OnTitleHold")]
		public static void OnTitleHold(string identifier)
		{
			TitleHold?.Invoke(null, new JQueryEventArgs(identifier));
		}
		[JSInvokable("DevExpress.Ui.DxTabPanelInterop.OnTitleRendered")]
		public static void OnTitleRendered(string identifier)
		{
			TitleRendered?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static new bool? GetAnimationEnabled(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_DxTabPanel_GetOption", dxTarget, "animationEnabled");
		}
		public static new void SetAnimationEnabled(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxTabPanel_SetOption", dxTarget, "animationEnabled", value);
		}
		public static new bool? GetFocusStateEnabled(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_DxTabPanel_GetOption", dxTarget, "focusStateEnabled");
		}
		public static new void SetFocusStateEnabled(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxTabPanel_SetOption", dxTarget, "focusStateEnabled", value);
		}
		public static new bool? GetHoverStateEnabled(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_DxTabPanel_GetOption", dxTarget, "hoverStateEnabled");
		}
		public static new void SetHoverStateEnabled(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxTabPanel_SetOption", dxTarget, "hoverStateEnabled", value);
		}
		public static object GetItemTitleTemplate(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxTabPanel_GetOption", dxTarget, "itemTitleTemplate");
		}
		public static void SetItemTitleTemplate(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxTabPanel_SetOption", dxTarget, "itemTitleTemplate", value);
		}
		public static bool? GetScrollByContent(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_DxTabPanel_GetOption", dxTarget, "scrollByContent");
		}
		public static void SetScrollByContent(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxTabPanel_SetOption", dxTarget, "scrollByContent", value);
		}
		public static bool? GetScrollingEnabled(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_DxTabPanel_GetOption", dxTarget, "scrollingEnabled");
		}
		public static void SetScrollingEnabled(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxTabPanel_SetOption", dxTarget, "scrollingEnabled", value);
		}
		public static bool? GetShowNavButtons(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_DxTabPanel_GetOption", dxTarget, "showNavButtons");
		}
		public static void SetShowNavButtons(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxTabPanel_SetOption", dxTarget, "showNavButtons", value);
		}
		public static new bool? GetSwipeEnabled(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_DxTabPanel_GetOption", dxTarget, "swipeEnabled");
		}
		public static new void SetSwipeEnabled(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxTabPanel_SetOption", dxTarget, "swipeEnabled", value);
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
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxTagBox_Init", dxTarget, json);
		}
		[JSInvokable("DevExpress.Ui.DxTagBoxInterop.OnMultiTagPreparing")]
		public static void OnMultiTagPreparing(string identifier)
		{
			MultiTagPreparing?.Invoke(null, new JQueryEventArgs(identifier));
		}
		[JSInvokable("DevExpress.Ui.DxTagBoxInterop.OnSelectAllValueChanged")]
		public static void OnSelectAllValueChanged(string identifier)
		{
			SelectAllValueChanged?.Invoke(null, new JQueryEventArgs(identifier));
		}
		[JSInvokable("DevExpress.Ui.DxTagBoxInterop.OnSelectionChanged")]
		public static void OnSelectionChanged(string identifier)
		{
			SelectionChanged?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static new string GetApplyValueMode(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_DxTagBox_GetOption", dxTarget, "applyValueMode");
		}
		public static new void SetApplyValueMode(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxTagBox_SetOption", dxTarget, "applyValueMode", value);
		}
		public static bool? GetHideSelectedItems(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_DxTagBox_GetOption", dxTarget, "hideSelectedItems");
		}
		public static void SetHideSelectedItems(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxTagBox_SetOption", dxTarget, "hideSelectedItems", value);
		}
		public static float? GetMaxDisplayedTags(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<float?>("BlazorDevExtreme_DxTagBox_GetOption", dxTarget, "maxDisplayedTags");
		}
		public static void SetMaxDisplayedTags(ElementRef dxTarget, float? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxTagBox_SetOption", dxTarget, "maxDisplayedTags", value);
		}
		public static bool? GetMultiline(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_DxTagBox_GetOption", dxTarget, "multiline");
		}
		public static void SetMultiline(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxTagBox_SetOption", dxTarget, "multiline", value);
		}
		public static string GetSelectAllMode(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_DxTagBox_GetOption", dxTarget, "selectAllMode");
		}
		public static void SetSelectAllMode(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxTagBox_SetOption", dxTarget, "selectAllMode", value);
		}
		public static object GetSelectedItems(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxTagBox_GetOption", dxTarget, "selectedItems");
		}
		public static void SetSelectedItems(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxTagBox_SetOption", dxTarget, "selectedItems", value);
		}
		public static bool? GetShowMultiTagOnly(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_DxTagBox_GetOption", dxTarget, "showMultiTagOnly");
		}
		public static void SetShowMultiTagOnly(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxTagBox_SetOption", dxTarget, "showMultiTagOnly", value);
		}
		public static object GetTagTemplate(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxTagBox_GetOption", dxTarget, "tagTemplate");
		}
		public static void SetTagTemplate(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxTagBox_SetOption", dxTarget, "tagTemplate", value);
		}
		public static new object GetValue(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxTagBox_GetOption", dxTarget, "value");
		}
		public static new void SetValue(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxTagBox_SetOption", dxTarget, "value", value);
		}
	}
	public class DxTextAreaInterop: DxTextBoxInterop
	{
		public static void Init(ElementRef dxTarget, DevExpress.Ui.DxTextAreaOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxTextArea_Init", dxTarget, json);
		}
		public static bool? GetAutoResizeEnabled(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_DxTextArea_GetOption", dxTarget, "autoResizeEnabled");
		}
		public static void SetAutoResizeEnabled(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxTextArea_SetOption", dxTarget, "autoResizeEnabled", value);
		}
		public static object GetMaxHeight(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxTextArea_GetOption", dxTarget, "maxHeight");
		}
		public static void SetMaxHeight(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxTextArea_SetOption", dxTarget, "maxHeight", value);
		}
		public static object GetMinHeight(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxTextArea_GetOption", dxTarget, "minHeight");
		}
		public static void SetMinHeight(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxTextArea_SetOption", dxTarget, "minHeight", value);
		}
		public static new bool? GetSpellcheck(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_DxTextArea_GetOption", dxTarget, "spellcheck");
		}
		public static new void SetSpellcheck(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxTextArea_SetOption", dxTarget, "spellcheck", value);
		}
	}
	public class DxTextBoxInterop: DxTextEditorInterop
	{
		public static void Init(ElementRef dxTarget, DevExpress.Ui.DxTextBoxOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxTextBox_Init", dxTarget, json);
		}
		public static object GetMaxLength(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxTextBox_GetOption", dxTarget, "maxLength");
		}
		public static void SetMaxLength(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxTextBox_SetOption", dxTarget, "maxLength", value);
		}
		public static string GetMode(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_DxTextBox_GetOption", dxTarget, "mode");
		}
		public static void SetMode(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxTextBox_SetOption", dxTarget, "mode", value);
		}
		public static new string GetValue(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_DxTextBox_GetOption", dxTarget, "value");
		}
		public static new void SetValue(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxTextBox_SetOption", dxTarget, "value", value);
		}
	}
	public class DxTileViewInterop: CollectionWidgetInterop
	{
		public static void Init(ElementRef dxTarget, DevExpress.Ui.DxTileViewOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxTileView_Init", dxTarget, json);
		}
		public static new bool? GetActiveStateEnabled(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_DxTileView_GetOption", dxTarget, "activeStateEnabled");
		}
		public static new void SetActiveStateEnabled(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxTileView_SetOption", dxTarget, "activeStateEnabled", value);
		}
		public static float? GetBaseItemHeight(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<float?>("BlazorDevExtreme_DxTileView_GetOption", dxTarget, "baseItemHeight");
		}
		public static void SetBaseItemHeight(ElementRef dxTarget, float? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxTileView_SetOption", dxTarget, "baseItemHeight", value);
		}
		public static float? GetBaseItemWidth(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<float?>("BlazorDevExtreme_DxTileView_GetOption", dxTarget, "baseItemWidth");
		}
		public static void SetBaseItemWidth(ElementRef dxTarget, float? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxTileView_SetOption", dxTarget, "baseItemWidth", value);
		}
		public static string GetDirection(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_DxTileView_GetOption", dxTarget, "direction");
		}
		public static void SetDirection(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxTileView_SetOption", dxTarget, "direction", value);
		}
		public static new bool? GetFocusStateEnabled(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_DxTileView_GetOption", dxTarget, "focusStateEnabled");
		}
		public static new void SetFocusStateEnabled(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxTileView_SetOption", dxTarget, "focusStateEnabled", value);
		}
		public static new object GetHeight(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxTileView_GetOption", dxTarget, "height");
		}
		public static new void SetHeight(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxTileView_SetOption", dxTarget, "height", value);
		}
		public static new bool? GetHoverStateEnabled(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_DxTileView_GetOption", dxTarget, "hoverStateEnabled");
		}
		public static new void SetHoverStateEnabled(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxTileView_SetOption", dxTarget, "hoverStateEnabled", value);
		}
		public static float? GetItemMargin(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<float?>("BlazorDevExtreme_DxTileView_GetOption", dxTarget, "itemMargin");
		}
		public static void SetItemMargin(ElementRef dxTarget, float? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxTileView_SetOption", dxTarget, "itemMargin", value);
		}
		public static bool? GetShowScrollbar(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_DxTileView_GetOption", dxTarget, "showScrollbar");
		}
		public static void SetShowScrollbar(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxTileView_SetOption", dxTarget, "showScrollbar", value);
		}
		public static float ScrollPosition(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<float>("BlazorDevExtreme_DxTileView_scrollPosition_0", dxTarget);
		}
	}
	public class DxToastInterop: DxOverlayInterop
	{
		public static void Init(ElementRef dxTarget, DevExpress.Ui.DxToastOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxToast_Init", dxTarget, json);
		}
		public static new object GetAnimation(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxToast_GetOption", dxTarget, "animation");
		}
		public static new void SetAnimation(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxToast_SetOption", dxTarget, "animation", value);
		}
		public static new bool? GetCloseOnBackButton(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_DxToast_GetOption", dxTarget, "closeOnBackButton");
		}
		public static new void SetCloseOnBackButton(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxToast_SetOption", dxTarget, "closeOnBackButton", value);
		}
		public static bool? GetCloseOnClick(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_DxToast_GetOption", dxTarget, "closeOnClick");
		}
		public static void SetCloseOnClick(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxToast_SetOption", dxTarget, "closeOnClick", value);
		}
		public static new object GetCloseOnOutsideClick(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxToast_GetOption", dxTarget, "closeOnOutsideClick");
		}
		public static new void SetCloseOnOutsideClick(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxToast_SetOption", dxTarget, "closeOnOutsideClick", value);
		}
		public static bool? GetCloseOnSwipe(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_DxToast_GetOption", dxTarget, "closeOnSwipe");
		}
		public static void SetCloseOnSwipe(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxToast_SetOption", dxTarget, "closeOnSwipe", value);
		}
		public static float? GetDisplayTime(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<float?>("BlazorDevExtreme_DxToast_GetOption", dxTarget, "displayTime");
		}
		public static void SetDisplayTime(ElementRef dxTarget, float? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxToast_SetOption", dxTarget, "displayTime", value);
		}
		public static new object GetHeight(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxToast_GetOption", dxTarget, "height");
		}
		public static new void SetHeight(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxToast_SetOption", dxTarget, "height", value);
		}
		public static new object GetMaxWidth(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxToast_GetOption", dxTarget, "maxWidth");
		}
		public static new void SetMaxWidth(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxToast_SetOption", dxTarget, "maxWidth", value);
		}
		public static string GetMessage(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_DxToast_GetOption", dxTarget, "message");
		}
		public static void SetMessage(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxToast_SetOption", dxTarget, "message", value);
		}
		public static new object GetMinWidth(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxToast_GetOption", dxTarget, "minWidth");
		}
		public static new void SetMinWidth(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxToast_SetOption", dxTarget, "minWidth", value);
		}
		public static new object GetPosition(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxToast_GetOption", dxTarget, "position");
		}
		public static new void SetPosition(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxToast_SetOption", dxTarget, "position", value);
		}
		public static new bool? GetShading(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_DxToast_GetOption", dxTarget, "shading");
		}
		public static new void SetShading(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxToast_SetOption", dxTarget, "shading", value);
		}
		public static string GetType(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_DxToast_GetOption", dxTarget, "type");
		}
		public static void SetType(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxToast_SetOption", dxTarget, "type", value);
		}
		public static new object GetWidth(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxToast_GetOption", dxTarget, "width");
		}
		public static new void SetWidth(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxToast_SetOption", dxTarget, "width", value);
		}
	}
	public class DxToolbarInterop: CollectionWidgetInterop
	{
		public static void Init(ElementRef dxTarget, DevExpress.Ui.DxToolbarOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxToolbar_Init", dxTarget, json);
		}
		public static object GetMenuItemTemplate(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxToolbar_GetOption", dxTarget, "menuItemTemplate");
		}
		public static void SetMenuItemTemplate(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxToolbar_SetOption", dxTarget, "menuItemTemplate", value);
		}
		public static string GetRenderAs(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_DxToolbar_GetOption", dxTarget, "renderAs");
		}
		public static void SetRenderAs(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxToolbar_SetOption", dxTarget, "renderAs", value);
		}
	}
	public class DxTooltipInterop: DxPopoverInterop
	{
		public static void Init(ElementRef dxTarget, DevExpress.Ui.DxTooltipOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxTooltip_Init", dxTarget, json);
		}
	}
	public class DxTrackBarInterop: EditorInterop
	{
		public static void Init(ElementRef dxTarget, DevExpress.Ui.DxTrackBarOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxTrackBar_Init", dxTarget, json);
		}
		public static float? GetMax(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<float?>("BlazorDevExtreme_DxTrackBar_GetOption", dxTarget, "max");
		}
		public static void SetMax(ElementRef dxTarget, float? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxTrackBar_SetOption", dxTarget, "max", value);
		}
		public static float? GetMin(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<float?>("BlazorDevExtreme_DxTrackBar_GetOption", dxTarget, "min");
		}
		public static void SetMin(ElementRef dxTarget, float? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxTrackBar_SetOption", dxTarget, "min", value);
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
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxTreeList_Init", dxTarget, json);
		}
		[JSInvokable("DevExpress.Ui.DxTreeListInterop.OnCellClick")]
		public static void OnCellClick(string identifier)
		{
			CellClick?.Invoke(null, new JQueryEventArgs(identifier));
		}
		[JSInvokable("DevExpress.Ui.DxTreeListInterop.OnCellHoverChanged")]
		public static void OnCellHoverChanged(string identifier)
		{
			CellHoverChanged?.Invoke(null, new JQueryEventArgs(identifier));
		}
		[JSInvokable("DevExpress.Ui.DxTreeListInterop.OnCellPrepared")]
		public static void OnCellPrepared(string identifier)
		{
			CellPrepared?.Invoke(null, new JQueryEventArgs(identifier));
		}
		[JSInvokable("DevExpress.Ui.DxTreeListInterop.OnContextMenuPreparing")]
		public static void OnContextMenuPreparing(string identifier)
		{
			ContextMenuPreparing?.Invoke(null, new JQueryEventArgs(identifier));
		}
		[JSInvokable("DevExpress.Ui.DxTreeListInterop.OnEditingStart")]
		public static void OnEditingStart(string identifier)
		{
			EditingStart?.Invoke(null, new JQueryEventArgs(identifier));
		}
		[JSInvokable("DevExpress.Ui.DxTreeListInterop.OnEditorPrepared")]
		public static void OnEditorPrepared(string identifier)
		{
			EditorPrepared?.Invoke(null, new JQueryEventArgs(identifier));
		}
		[JSInvokable("DevExpress.Ui.DxTreeListInterop.OnEditorPreparing")]
		public static void OnEditorPreparing(string identifier)
		{
			EditorPreparing?.Invoke(null, new JQueryEventArgs(identifier));
		}
		[JSInvokable("DevExpress.Ui.DxTreeListInterop.OnNodesInitialized")]
		public static void OnNodesInitialized(string identifier)
		{
			NodesInitialized?.Invoke(null, new JQueryEventArgs(identifier));
		}
		[JSInvokable("DevExpress.Ui.DxTreeListInterop.OnRowClick")]
		public static void OnRowClick(string identifier)
		{
			RowClick?.Invoke(null, new JQueryEventArgs(identifier));
		}
		[JSInvokable("DevExpress.Ui.DxTreeListInterop.OnRowPrepared")]
		public static void OnRowPrepared(string identifier)
		{
			RowPrepared?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static bool? GetAutoExpandAll(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_DxTreeList_GetOption", dxTarget, "autoExpandAll");
		}
		public static void SetAutoExpandAll(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxTreeList_SetOption", dxTarget, "autoExpandAll", value);
		}
		public static new object GetColumns(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxTreeList_GetOption", dxTarget, "columns");
		}
		public static new void SetColumns(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxTreeList_SetOption", dxTarget, "columns", value);
		}
		public static object GetCustomizeColumns(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxTreeList_GetOption", dxTarget, "customizeColumns");
		}
		public static void SetCustomizeColumns(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxTreeList_SetOption", dxTarget, "customizeColumns", value);
		}
		public static string GetDataStructure(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_DxTreeList_GetOption", dxTarget, "dataStructure");
		}
		public static void SetDataStructure(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxTreeList_SetOption", dxTarget, "dataStructure", value);
		}
		public static new object GetEditing(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxTreeList_GetOption", dxTarget, "editing");
		}
		public static new void SetEditing(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxTreeList_SetOption", dxTarget, "editing", value);
		}
		public static object GetExpandedRowKeys(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxTreeList_GetOption", dxTarget, "expandedRowKeys");
		}
		public static void SetExpandedRowKeys(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxTreeList_SetOption", dxTarget, "expandedRowKeys", value);
		}
		public static bool? GetExpandNodesOnFiltering(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_DxTreeList_GetOption", dxTarget, "expandNodesOnFiltering");
		}
		public static void SetExpandNodesOnFiltering(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxTreeList_SetOption", dxTarget, "expandNodesOnFiltering", value);
		}
		public static object GetHasItemsExpr(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxTreeList_GetOption", dxTarget, "hasItemsExpr");
		}
		public static void SetHasItemsExpr(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxTreeList_SetOption", dxTarget, "hasItemsExpr", value);
		}
		public static object GetItemsExpr(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxTreeList_GetOption", dxTarget, "itemsExpr");
		}
		public static void SetItemsExpr(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxTreeList_SetOption", dxTarget, "itemsExpr", value);
		}
		public static object GetKeyExpr(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxTreeList_GetOption", dxTarget, "keyExpr");
		}
		public static void SetKeyExpr(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxTreeList_SetOption", dxTarget, "keyExpr", value);
		}
		public static new object GetPaging(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxTreeList_GetOption", dxTarget, "paging");
		}
		public static new void SetPaging(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxTreeList_SetOption", dxTarget, "paging", value);
		}
		public static object GetParentIdExpr(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxTreeList_GetOption", dxTarget, "parentIdExpr");
		}
		public static void SetParentIdExpr(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxTreeList_SetOption", dxTarget, "parentIdExpr", value);
		}
		public static object GetRemoteOperations(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxTreeList_GetOption", dxTarget, "remoteOperations");
		}
		public static void SetRemoteOperations(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxTreeList_SetOption", dxTarget, "remoteOperations", value);
		}
		public static object GetRootValue(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxTreeList_GetOption", dxTarget, "rootValue");
		}
		public static void SetRootValue(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxTreeList_SetOption", dxTarget, "rootValue", value);
		}
		public static new object GetScrolling(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxTreeList_GetOption", dxTarget, "scrolling");
		}
		public static new void SetScrolling(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxTreeList_SetOption", dxTarget, "scrolling", value);
		}
		public static new object GetSelection(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxTreeList_GetOption", dxTarget, "selection");
		}
		public static new void SetSelection(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxTreeList_SetOption", dxTarget, "selection", value);
		}
		public static void AddColumn(ElementRef dxTarget, object columnOptions)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxTreeList_addColumn_0", dxTarget, columnOptions);
		}
		public static void AddRow(ElementRef dxTarget)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxTreeList_addRow_1", dxTarget);
		}
		public static void AddRow(ElementRef dxTarget, object parentId)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxTreeList_addRow_2", dxTarget, parentId);
		}
		public static object CollapseRow(ElementRef dxTarget, object key)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxTreeList_collapseRow_3", dxTarget, key);
		}
		public static object ExpandRow(ElementRef dxTarget, object key)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxTreeList_expandRow_4", dxTarget, key);
		}
		public static void ForEachNode(ElementRef dxTarget, object callback)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxTreeList_forEachNode_5", dxTarget, callback);
		}
		public static void ForEachNode(ElementRef dxTarget, object nodes, object callback)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxTreeList_forEachNode_6", dxTarget, nodes, callback);
		}
		public static object GetNodeByKey(ElementRef dxTarget, object key)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxTreeList_getNodeByKey_7", dxTarget, key);
		}
		public static object GetRootNode(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxTreeList_getRootNode_8", dxTarget);
		}
		public static object GetSelectedRowKeys(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxTreeList_getSelectedRowKeys_9", dxTarget);
		}
		public static object GetSelectedRowKeys(ElementRef dxTarget, bool leavesOnly)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxTreeList_getSelectedRowKeys_10", dxTarget, leavesOnly);
		}
		public static object GetSelectedRowKeys(ElementRef dxTarget, string mode)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxTreeList_getSelectedRowKeys_11", dxTarget, mode);
		}
		public static object GetSelectedRowsData(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxTreeList_getSelectedRowsData_12", dxTarget);
		}
		public static object GetVisibleColumns(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxTreeList_getVisibleColumns_13", dxTarget);
		}
		public static object GetVisibleColumns(ElementRef dxTarget, float headerLevel)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxTreeList_getVisibleColumns_14", dxTarget, headerLevel);
		}
		public static object GetVisibleRows(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxTreeList_getVisibleRows_15", dxTarget);
		}
		public static bool IsRowExpanded(ElementRef dxTarget, object key)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool>("BlazorDevExtreme_DxTreeList_isRowExpanded_16", dxTarget, key);
		}
		public static object LoadDescendants(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxTreeList_loadDescendants_17", dxTarget);
		}
		public static object LoadDescendants(ElementRef dxTarget, object keys)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxTreeList_loadDescendants_18", dxTarget, keys);
		}
		public static object LoadDescendants(ElementRef dxTarget, object keys, bool childrenOnly)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxTreeList_loadDescendants_19", dxTarget, keys, childrenOnly);
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
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxTreeView_Init", dxTarget, json);
		}
		[JSInvokable("DevExpress.Ui.DxTreeViewInterop.OnItemClick")]
		public static void OnItemClick(string identifier)
		{
			ItemClick?.Invoke(null, new JQueryEventArgs(identifier));
		}
		[JSInvokable("DevExpress.Ui.DxTreeViewInterop.OnItemCollapsed")]
		public static void OnItemCollapsed(string identifier)
		{
			ItemCollapsed?.Invoke(null, new JQueryEventArgs(identifier));
		}
		[JSInvokable("DevExpress.Ui.DxTreeViewInterop.OnItemContextMenu")]
		public static void OnItemContextMenu(string identifier)
		{
			ItemContextMenu?.Invoke(null, new JQueryEventArgs(identifier));
		}
		[JSInvokable("DevExpress.Ui.DxTreeViewInterop.OnItemExpanded")]
		public static void OnItemExpanded(string identifier)
		{
			ItemExpanded?.Invoke(null, new JQueryEventArgs(identifier));
		}
		[JSInvokable("DevExpress.Ui.DxTreeViewInterop.OnItemHold")]
		public static void OnItemHold(string identifier)
		{
			ItemHold?.Invoke(null, new JQueryEventArgs(identifier));
		}
		[JSInvokable("DevExpress.Ui.DxTreeViewInterop.OnItemRendered")]
		public static void OnItemRendered(string identifier)
		{
			ItemRendered?.Invoke(null, new JQueryEventArgs(identifier));
		}
		[JSInvokable("DevExpress.Ui.DxTreeViewInterop.OnItemSelectionChanged")]
		public static void OnItemSelectionChanged(string identifier)
		{
			ItemSelectionChanged?.Invoke(null, new JQueryEventArgs(identifier));
		}
		[JSInvokable("DevExpress.Ui.DxTreeViewInterop.OnSelectionChanged")]
		public static void OnSelectionChanged(string identifier)
		{
			SelectionChanged?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static bool? GetAnimationEnabled(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_DxTreeView_GetOption", dxTarget, "animationEnabled");
		}
		public static void SetAnimationEnabled(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxTreeView_SetOption", dxTarget, "animationEnabled", value);
		}
		public static object GetCreateChildren(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxTreeView_GetOption", dxTarget, "createChildren");
		}
		public static void SetCreateChildren(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxTreeView_SetOption", dxTarget, "createChildren", value);
		}
		public static string GetDataStructure(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_DxTreeView_GetOption", dxTarget, "dataStructure");
		}
		public static void SetDataStructure(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxTreeView_SetOption", dxTarget, "dataStructure", value);
		}
		public static bool? GetExpandAllEnabled(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_DxTreeView_GetOption", dxTarget, "expandAllEnabled");
		}
		public static void SetExpandAllEnabled(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxTreeView_SetOption", dxTarget, "expandAllEnabled", value);
		}
		public static object GetExpandedExpr(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxTreeView_GetOption", dxTarget, "expandedExpr");
		}
		public static void SetExpandedExpr(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxTreeView_SetOption", dxTarget, "expandedExpr", value);
		}
		public static bool? GetExpandNodesRecursive(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_DxTreeView_GetOption", dxTarget, "expandNodesRecursive");
		}
		public static void SetExpandNodesRecursive(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxTreeView_SetOption", dxTarget, "expandNodesRecursive", value);
		}
		public static object GetHasItemsExpr(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxTreeView_GetOption", dxTarget, "hasItemsExpr");
		}
		public static void SetHasItemsExpr(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxTreeView_SetOption", dxTarget, "hasItemsExpr", value);
		}
		public static new object GetItems(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxTreeView_GetOption", dxTarget, "items");
		}
		public static new void SetItems(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxTreeView_SetOption", dxTarget, "items", value);
		}
		public static object GetParentIdExpr(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxTreeView_GetOption", dxTarget, "parentIdExpr");
		}
		public static void SetParentIdExpr(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxTreeView_SetOption", dxTarget, "parentIdExpr", value);
		}
		public static object GetRootValue(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxTreeView_GetOption", dxTarget, "rootValue");
		}
		public static void SetRootValue(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxTreeView_SetOption", dxTarget, "rootValue", value);
		}
		public static string GetScrollDirection(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_DxTreeView_GetOption", dxTarget, "scrollDirection");
		}
		public static void SetScrollDirection(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxTreeView_SetOption", dxTarget, "scrollDirection", value);
		}
		public static string GetSelectAllText(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_DxTreeView_GetOption", dxTarget, "selectAllText");
		}
		public static void SetSelectAllText(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxTreeView_SetOption", dxTarget, "selectAllText", value);
		}
		public static bool? GetSelectByClick(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_DxTreeView_GetOption", dxTarget, "selectByClick");
		}
		public static void SetSelectByClick(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxTreeView_SetOption", dxTarget, "selectByClick", value);
		}
		public static string GetSelectionMode(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_DxTreeView_GetOption", dxTarget, "selectionMode");
		}
		public static void SetSelectionMode(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxTreeView_SetOption", dxTarget, "selectionMode", value);
		}
		public static bool? GetSelectNodesRecursive(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_DxTreeView_GetOption", dxTarget, "selectNodesRecursive");
		}
		public static void SetSelectNodesRecursive(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxTreeView_SetOption", dxTarget, "selectNodesRecursive", value);
		}
		public static string GetShowCheckBoxesMode(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_DxTreeView_GetOption", dxTarget, "showCheckBoxesMode");
		}
		public static void SetShowCheckBoxesMode(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxTreeView_SetOption", dxTarget, "showCheckBoxesMode", value);
		}
		public static bool? GetVirtualModeEnabled(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_DxTreeView_GetOption", dxTarget, "virtualModeEnabled");
		}
		public static void SetVirtualModeEnabled(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxTreeView_SetOption", dxTarget, "virtualModeEnabled", value);
		}
		public static void CollapseItem(ElementRef dxTarget, object itemData)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxTreeView_collapseItem_0", dxTarget, itemData);
		}
		public static void ExpandItem(ElementRef dxTarget, object itemData)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxTreeView_expandItem_3", dxTarget, itemData);
		}
		public static object GetNodes(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxTreeView_getNodes_6", dxTarget);
		}
		public static void SelectAll(ElementRef dxTarget)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxTreeView_selectAll_7", dxTarget);
		}
		public static void SelectItem(ElementRef dxTarget, object itemData)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxTreeView_selectItem_8", dxTarget, itemData);
		}
		public static void UnselectAll(ElementRef dxTarget)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxTreeView_unselectAll_11", dxTarget);
		}
		public static void UnselectItem(ElementRef dxTarget, object itemData)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxTreeView_unselectItem_12", dxTarget, itemData);
		}
		public static object UpdateDimensions(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxTreeView_updateDimensions_15", dxTarget);
		}
	}
	public class DxValidationGroupInterop: DOMComponentInterop
	{
		public static void Init(ElementRef dxTarget, DevExpress.Ui.DxValidationGroupOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxValidationGroup_Init", dxTarget, json);
		}
		public static void Reset(ElementRef dxTarget)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxValidationGroup_reset_0", dxTarget);
		}
		public static object Validate(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxValidationGroup_validate_1", dxTarget);
		}
	}
	public class DxValidationSummaryInterop: CollectionWidgetInterop
	{
		public static void Init(ElementRef dxTarget, DevExpress.Ui.DxValidationSummaryOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxValidationSummary_Init", dxTarget, json);
		}
		public static string GetValidationGroup(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_DxValidationSummary_GetOption", dxTarget, "validationGroup");
		}
		public static void SetValidationGroup(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxValidationSummary_SetOption", dxTarget, "validationGroup", value);
		}
	}
	public class DxValidatorInterop: DOMComponentInterop
	{
		public static event EventHandler<JQueryEventArgs> Validated;
		public static void Init(ElementRef dxTarget, DevExpress.Ui.DxValidatorOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxValidator_Init", dxTarget, json);
		}
		[JSInvokable("DevExpress.Ui.DxValidatorInterop.OnValidated")]
		public static void OnValidated(string identifier)
		{
			Validated?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static object GetAdapter(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxValidator_GetOption", dxTarget, "adapter");
		}
		public static void SetAdapter(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxValidator_SetOption", dxTarget, "adapter", value);
		}
		public static string GetName(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_DxValidator_GetOption", dxTarget, "name");
		}
		public static void SetName(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxValidator_SetOption", dxTarget, "name", value);
		}
		public static string GetValidationGroup(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_DxValidator_GetOption", dxTarget, "validationGroup");
		}
		public static void SetValidationGroup(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxValidator_SetOption", dxTarget, "validationGroup", value);
		}
		public static object GetValidationRules(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxValidator_GetOption", dxTarget, "validationRules");
		}
		public static void SetValidationRules(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxValidator_SetOption", dxTarget, "validationRules", value);
		}
		public static void Focus(ElementRef dxTarget)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxValidator_focus_0", dxTarget);
		}
		public static void Reset(ElementRef dxTarget)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxValidator_reset_1", dxTarget);
		}
		public static object Validate(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxValidator_validate_2", dxTarget);
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
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_CollectionWidget_Init", dxTarget, json);
		}
		[JSInvokable("DevExpress.Ui.CollectionWidgetInterop.OnItemClick")]
		public static void OnItemClick(string identifier)
		{
			ItemClick?.Invoke(null, new JQueryEventArgs(identifier));
		}
		[JSInvokable("DevExpress.Ui.CollectionWidgetInterop.OnItemContextMenu")]
		public static void OnItemContextMenu(string identifier)
		{
			ItemContextMenu?.Invoke(null, new JQueryEventArgs(identifier));
		}
		[JSInvokable("DevExpress.Ui.CollectionWidgetInterop.OnItemHold")]
		public static void OnItemHold(string identifier)
		{
			ItemHold?.Invoke(null, new JQueryEventArgs(identifier));
		}
		[JSInvokable("DevExpress.Ui.CollectionWidgetInterop.OnItemRendered")]
		public static void OnItemRendered(string identifier)
		{
			ItemRendered?.Invoke(null, new JQueryEventArgs(identifier));
		}
		[JSInvokable("DevExpress.Ui.CollectionWidgetInterop.OnSelectionChanged")]
		public static void OnSelectionChanged(string identifier)
		{
			SelectionChanged?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static object GetDataSource(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_CollectionWidget_GetOption", dxTarget, "dataSource");
		}
		public static void SetDataSource(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_CollectionWidget_SetOption", dxTarget, "dataSource", value);
		}
		public static float? GetItemHoldTimeout(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<float?>("BlazorDevExtreme_CollectionWidget_GetOption", dxTarget, "itemHoldTimeout");
		}
		public static void SetItemHoldTimeout(ElementRef dxTarget, float? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_CollectionWidget_SetOption", dxTarget, "itemHoldTimeout", value);
		}
		public static object GetItems(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_CollectionWidget_GetOption", dxTarget, "items");
		}
		public static void SetItems(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_CollectionWidget_SetOption", dxTarget, "items", value);
		}
		public static object GetItemTemplate(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_CollectionWidget_GetOption", dxTarget, "itemTemplate");
		}
		public static void SetItemTemplate(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_CollectionWidget_SetOption", dxTarget, "itemTemplate", value);
		}
		public static object GetKeyExpr(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_CollectionWidget_GetOption", dxTarget, "keyExpr");
		}
		public static void SetKeyExpr(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_CollectionWidget_SetOption", dxTarget, "keyExpr", value);
		}
		public static string GetNoDataText(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_CollectionWidget_GetOption", dxTarget, "noDataText");
		}
		public static void SetNoDataText(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_CollectionWidget_SetOption", dxTarget, "noDataText", value);
		}
		public static float? GetSelectedIndex(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<float?>("BlazorDevExtreme_CollectionWidget_GetOption", dxTarget, "selectedIndex");
		}
		public static void SetSelectedIndex(ElementRef dxTarget, float? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_CollectionWidget_SetOption", dxTarget, "selectedIndex", value);
		}
		public static object GetSelectedItem(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_CollectionWidget_GetOption", dxTarget, "selectedItem");
		}
		public static void SetSelectedItem(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_CollectionWidget_SetOption", dxTarget, "selectedItem", value);
		}
		public static object GetSelectedItemKeys(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_CollectionWidget_GetOption", dxTarget, "selectedItemKeys");
		}
		public static void SetSelectedItemKeys(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_CollectionWidget_SetOption", dxTarget, "selectedItemKeys", value);
		}
		public static object GetSelectedItems(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_CollectionWidget_GetOption", dxTarget, "selectedItems");
		}
		public static void SetSelectedItems(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_CollectionWidget_SetOption", dxTarget, "selectedItems", value);
		}
		public static object GetDataSourceEx(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_CollectionWidget_getDataSource_0", dxTarget);
		}
	}
	public class DxMenuBaseInterop: HierarchicalCollectionWidgetInterop
	{
		public static void Init(ElementRef dxTarget, DevExpress.Ui.DxMenuBaseOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxMenuBase_Init", dxTarget, json);
		}
		public static new bool? GetActiveStateEnabled(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_DxMenuBase_GetOption", dxTarget, "activeStateEnabled");
		}
		public static new void SetActiveStateEnabled(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxMenuBase_SetOption", dxTarget, "activeStateEnabled", value);
		}
		public static object GetAnimation(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxMenuBase_GetOption", dxTarget, "animation");
		}
		public static void SetAnimation(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxMenuBase_SetOption", dxTarget, "animation", value);
		}
		public static string GetCssClass(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_DxMenuBase_GetOption", dxTarget, "cssClass");
		}
		public static void SetCssClass(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxMenuBase_SetOption", dxTarget, "cssClass", value);
		}
		public static new object GetItems(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxMenuBase_GetOption", dxTarget, "items");
		}
		public static new void SetItems(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxMenuBase_SetOption", dxTarget, "items", value);
		}
		public static bool? GetSelectByClick(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_DxMenuBase_GetOption", dxTarget, "selectByClick");
		}
		public static void SetSelectByClick(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxMenuBase_SetOption", dxTarget, "selectByClick", value);
		}
		public static string GetSelectionMode(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_DxMenuBase_GetOption", dxTarget, "selectionMode");
		}
		public static void SetSelectionMode(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxMenuBase_SetOption", dxTarget, "selectionMode", value);
		}
		public static object GetShowSubmenuMode(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxMenuBase_GetOption", dxTarget, "showSubmenuMode");
		}
		public static void SetShowSubmenuMode(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxMenuBase_SetOption", dxTarget, "showSubmenuMode", value);
		}
		public static void SelectItem(ElementRef dxTarget, object itemElement)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxMenuBase_selectItem_0", dxTarget, itemElement);
		}
		public static void UnselectItem(ElementRef dxTarget, object itemElement)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxMenuBase_unselectItem_1", dxTarget, itemElement);
		}
	}
	public class DxDropDownEditorInterop: DxTextBoxInterop
	{
		public static event EventHandler<JQueryEventArgs> Closed;
		public static event EventHandler<JQueryEventArgs> Opened;
		public static void Init(ElementRef dxTarget, DevExpress.Ui.DxDropDownEditorOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxDropDownEditor_Init", dxTarget, json);
		}
		[JSInvokable("DevExpress.Ui.DxDropDownEditorInterop.OnClosed")]
		public static void OnClosed(string identifier)
		{
			Closed?.Invoke(null, new JQueryEventArgs(identifier));
		}
		[JSInvokable("DevExpress.Ui.DxDropDownEditorInterop.OnOpened")]
		public static void OnOpened(string identifier)
		{
			Opened?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static bool? GetAcceptCustomValue(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_DxDropDownEditor_GetOption", dxTarget, "acceptCustomValue");
		}
		public static void SetAcceptCustomValue(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxDropDownEditor_SetOption", dxTarget, "acceptCustomValue", value);
		}
		public static new bool? GetActiveStateEnabled(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_DxDropDownEditor_GetOption", dxTarget, "activeStateEnabled");
		}
		public static new void SetActiveStateEnabled(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxDropDownEditor_SetOption", dxTarget, "activeStateEnabled", value);
		}
		public static string GetApplyValueMode(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_DxDropDownEditor_GetOption", dxTarget, "applyValueMode");
		}
		public static void SetApplyValueMode(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxDropDownEditor_SetOption", dxTarget, "applyValueMode", value);
		}
		public static bool? GetDeferRendering(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_DxDropDownEditor_GetOption", dxTarget, "deferRendering");
		}
		public static void SetDeferRendering(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxDropDownEditor_SetOption", dxTarget, "deferRendering", value);
		}
		public static object GetDropDownButtonTemplate(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxDropDownEditor_GetOption", dxTarget, "dropDownButtonTemplate");
		}
		public static void SetDropDownButtonTemplate(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxDropDownEditor_SetOption", dxTarget, "dropDownButtonTemplate", value);
		}
		public static bool? GetOpened(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_DxDropDownEditor_GetOption", dxTarget, "opened");
		}
		public static void SetOpened(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxDropDownEditor_SetOption", dxTarget, "opened", value);
		}
		public static new object GetValue(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxDropDownEditor_GetOption", dxTarget, "value");
		}
		public static new void SetValue(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxDropDownEditor_SetOption", dxTarget, "value", value);
		}
		public static void Close(ElementRef dxTarget)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxDropDownEditor_close_0", dxTarget);
		}
		public static object Content(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxDropDownEditor_content_1", dxTarget);
		}
		public static object Field(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxDropDownEditor_field_2", dxTarget);
		}
		public static void Open(ElementRef dxTarget)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxDropDownEditor_open_3", dxTarget);
		}
		public static void Reset(ElementRef dxTarget)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxDropDownEditor_reset_4", dxTarget);
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
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxDropDownList_Init", dxTarget, json);
		}
		[JSInvokable("DevExpress.Ui.DxDropDownListInterop.OnItemClick")]
		public static void OnItemClick(string identifier)
		{
			ItemClick?.Invoke(null, new JQueryEventArgs(identifier));
		}
		[JSInvokable("DevExpress.Ui.DxDropDownListInterop.OnSelectionChanged")]
		public static void OnSelectionChanged(string identifier)
		{
			SelectionChanged?.Invoke(null, new JQueryEventArgs(identifier));
		}
		[JSInvokable("DevExpress.Ui.DxDropDownListInterop.OnValueChanged")]
		public static void OnValueChanged(string identifier)
		{
			ValueChanged?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static string GetDisplayValue(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_DxDropDownList_GetOption", dxTarget, "displayValue");
		}
		public static void SetDisplayValue(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxDropDownList_SetOption", dxTarget, "displayValue", value);
		}
		public static bool? GetGrouped(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_DxDropDownList_GetOption", dxTarget, "grouped");
		}
		public static void SetGrouped(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxDropDownList_SetOption", dxTarget, "grouped", value);
		}
		public static object GetGroupTemplate(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxDropDownList_GetOption", dxTarget, "groupTemplate");
		}
		public static void SetGroupTemplate(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxDropDownList_SetOption", dxTarget, "groupTemplate", value);
		}
		public static float? GetMinSearchLength(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<float?>("BlazorDevExtreme_DxDropDownList_GetOption", dxTarget, "minSearchLength");
		}
		public static void SetMinSearchLength(ElementRef dxTarget, float? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxDropDownList_SetOption", dxTarget, "minSearchLength", value);
		}
		public static string GetNoDataText(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_DxDropDownList_GetOption", dxTarget, "noDataText");
		}
		public static void SetNoDataText(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxDropDownList_SetOption", dxTarget, "noDataText", value);
		}
		public static bool? GetSearchEnabled(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_DxDropDownList_GetOption", dxTarget, "searchEnabled");
		}
		public static void SetSearchEnabled(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxDropDownList_SetOption", dxTarget, "searchEnabled", value);
		}
		public static object GetSearchExpr(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxDropDownList_GetOption", dxTarget, "searchExpr");
		}
		public static void SetSearchExpr(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxDropDownList_SetOption", dxTarget, "searchExpr", value);
		}
		public static string GetSearchMode(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_DxDropDownList_GetOption", dxTarget, "searchMode");
		}
		public static void SetSearchMode(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxDropDownList_SetOption", dxTarget, "searchMode", value);
		}
		public static float? GetSearchTimeout(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<float?>("BlazorDevExtreme_DxDropDownList_GetOption", dxTarget, "searchTimeout");
		}
		public static void SetSearchTimeout(ElementRef dxTarget, float? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxDropDownList_SetOption", dxTarget, "searchTimeout", value);
		}
		public static object GetSelectedItem(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxDropDownList_GetOption", dxTarget, "selectedItem");
		}
		public static void SetSelectedItem(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxDropDownList_SetOption", dxTarget, "selectedItem", value);
		}
		public static bool? GetShowDataBeforeSearch(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_DxDropDownList_GetOption", dxTarget, "showDataBeforeSearch");
		}
		public static void SetShowDataBeforeSearch(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxDropDownList_SetOption", dxTarget, "showDataBeforeSearch", value);
		}
		public static new object GetValue(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxDropDownList_GetOption", dxTarget, "value");
		}
		public static new void SetValue(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxDropDownList_SetOption", dxTarget, "value", value);
		}
		public static new string GetValueChangeEvent(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_DxDropDownList_GetOption", dxTarget, "valueChangeEvent");
		}
		public static new void SetValueChangeEvent(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxDropDownList_SetOption", dxTarget, "valueChangeEvent", value);
		}
		public static object GetDataSourceEx(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxDropDownList_getDataSource_0", dxTarget);
		}
	}
	public class EditorInterop: WidgetInterop
	{
		public static event EventHandler<JQueryEventArgs> ValueChanged;
		public static void Init(ElementRef dxTarget, DevExpress.Ui.EditorOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_Editor_Init", dxTarget, json);
		}
		[JSInvokable("DevExpress.Ui.EditorInterop.OnValueChanged")]
		public static void OnValueChanged(string identifier)
		{
			ValueChanged?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static bool? GetIsValid(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_Editor_GetOption", dxTarget, "isValid");
		}
		public static void SetIsValid(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_Editor_SetOption", dxTarget, "isValid", value);
		}
		public static bool? GetReadOnly(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_Editor_GetOption", dxTarget, "readOnly");
		}
		public static void SetReadOnly(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_Editor_SetOption", dxTarget, "readOnly", value);
		}
		public static object GetValidationError(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_Editor_GetOption", dxTarget, "validationError");
		}
		public static void SetValidationError(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_Editor_SetOption", dxTarget, "validationError", value);
		}
		public static string GetValidationMessageMode(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_Editor_GetOption", dxTarget, "validationMessageMode");
		}
		public static void SetValidationMessageMode(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_Editor_SetOption", dxTarget, "validationMessageMode", value);
		}
		public static object GetValue(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_Editor_GetOption", dxTarget, "value");
		}
		public static void SetValue(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_Editor_SetOption", dxTarget, "value", value);
		}
		public static void Reset(ElementRef dxTarget)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_Editor_reset_0", dxTarget);
		}
	}
	public class DataExpressionMixinInterop
	{
		public static void Init(ElementRef dxTarget, DevExpress.Ui.DataExpressionMixinOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DataExpressionMixin_Init", dxTarget, json);
		}
		public static object GetDataSource(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DataExpressionMixin_GetOption", dxTarget, "dataSource");
		}
		public static void SetDataSource(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DataExpressionMixin_SetOption", dxTarget, "dataSource", value);
		}
		public static object GetDisplayExpr(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DataExpressionMixin_GetOption", dxTarget, "displayExpr");
		}
		public static void SetDisplayExpr(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DataExpressionMixin_SetOption", dxTarget, "displayExpr", value);
		}
		public static object GetItems(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DataExpressionMixin_GetOption", dxTarget, "items");
		}
		public static void SetItems(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DataExpressionMixin_SetOption", dxTarget, "items", value);
		}
		public static object GetItemTemplate(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DataExpressionMixin_GetOption", dxTarget, "itemTemplate");
		}
		public static void SetItemTemplate(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DataExpressionMixin_SetOption", dxTarget, "itemTemplate", value);
		}
		public static object GetValue(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DataExpressionMixin_GetOption", dxTarget, "value");
		}
		public static void SetValue(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DataExpressionMixin_SetOption", dxTarget, "value", value);
		}
		public static object GetValueExpr(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DataExpressionMixin_GetOption", dxTarget, "valueExpr");
		}
		public static void SetValueExpr(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DataExpressionMixin_SetOption", dxTarget, "valueExpr", value);
		}
		public static object GetDataSourceEx(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DataExpressionMixin_getDataSource_0", dxTarget);
		}
	}
	public class HierarchicalCollectionWidgetInterop: CollectionWidgetInterop
	{
		public static void Init(ElementRef dxTarget, DevExpress.Ui.HierarchicalCollectionWidgetOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_HierarchicalCollectionWidget_Init", dxTarget, json);
		}
		public static object GetDisabledExpr(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_HierarchicalCollectionWidget_GetOption", dxTarget, "disabledExpr");
		}
		public static void SetDisabledExpr(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_HierarchicalCollectionWidget_SetOption", dxTarget, "disabledExpr", value);
		}
		public static object GetDisplayExpr(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_HierarchicalCollectionWidget_GetOption", dxTarget, "displayExpr");
		}
		public static void SetDisplayExpr(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_HierarchicalCollectionWidget_SetOption", dxTarget, "displayExpr", value);
		}
		public static new bool? GetFocusStateEnabled(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_HierarchicalCollectionWidget_GetOption", dxTarget, "focusStateEnabled");
		}
		public static new void SetFocusStateEnabled(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_HierarchicalCollectionWidget_SetOption", dxTarget, "focusStateEnabled", value);
		}
		public static new bool? GetHoverStateEnabled(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_HierarchicalCollectionWidget_GetOption", dxTarget, "hoverStateEnabled");
		}
		public static new void SetHoverStateEnabled(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_HierarchicalCollectionWidget_SetOption", dxTarget, "hoverStateEnabled", value);
		}
		public static object GetItemsExpr(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_HierarchicalCollectionWidget_GetOption", dxTarget, "itemsExpr");
		}
		public static void SetItemsExpr(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_HierarchicalCollectionWidget_SetOption", dxTarget, "itemsExpr", value);
		}
		public static new object GetKeyExpr(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_HierarchicalCollectionWidget_GetOption", dxTarget, "keyExpr");
		}
		public static new void SetKeyExpr(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_HierarchicalCollectionWidget_SetOption", dxTarget, "keyExpr", value);
		}
		public static object GetSelectedExpr(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_HierarchicalCollectionWidget_GetOption", dxTarget, "selectedExpr");
		}
		public static void SetSelectedExpr(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_HierarchicalCollectionWidget_SetOption", dxTarget, "selectedExpr", value);
		}
	}
	public class DxPivotGridSummaryCellInterop
	{
		public static object Child(ElementRef dxTarget, string direction, object fieldValue)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxPivotGridSummaryCell_child_0", dxTarget, direction, fieldValue);
		}
		public static object Children(ElementRef dxTarget, string direction)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxPivotGridSummaryCell_children_1", dxTarget, direction);
		}
		public static object Field(ElementRef dxTarget, string area)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxPivotGridSummaryCell_field_2", dxTarget, area);
		}
		public static object GrandTotal(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxPivotGridSummaryCell_grandTotal_3", dxTarget);
		}
		public static object GrandTotal(ElementRef dxTarget, string direction)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxPivotGridSummaryCell_grandTotal_4", dxTarget, direction);
		}
		public static object Next(ElementRef dxTarget, string direction)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxPivotGridSummaryCell_next_5", dxTarget, direction);
		}
		public static object Next(ElementRef dxTarget, string direction, bool allowCrossGroup)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxPivotGridSummaryCell_next_6", dxTarget, direction, allowCrossGroup);
		}
		public static object Parent(ElementRef dxTarget, string direction)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxPivotGridSummaryCell_parent_7", dxTarget, direction);
		}
		public static object Prev(ElementRef dxTarget, string direction)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxPivotGridSummaryCell_prev_8", dxTarget, direction);
		}
		public static object Prev(ElementRef dxTarget, string direction, bool allowCrossGroup)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxPivotGridSummaryCell_prev_9", dxTarget, direction, allowCrossGroup);
		}
		public static object Slice(ElementRef dxTarget, object field, object value)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxPivotGridSummaryCell_slice_10", dxTarget, field, value);
		}
		public static object ValueEx(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxPivotGridSummaryCell_value_11", dxTarget);
		}
		public static object ValueEx(ElementRef dxTarget, object field)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxPivotGridSummaryCell_value_12", dxTarget, field);
		}
		public static object ValueEx(ElementRef dxTarget, object field, bool isCalculatedValue)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxPivotGridSummaryCell_value_13", dxTarget, field, isCalculatedValue);
		}
		public static object ValueEx(ElementRef dxTarget, bool isCalculatedValue)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxPivotGridSummaryCell_value_14", dxTarget, isCalculatedValue);
		}
	}
	public class DxScrollableInterop: DOMComponentInterop
	{
		public static event EventHandler<JQueryEventArgs> Scroll;
		public static event EventHandler<JQueryEventArgs> Updated;
		public static void Init(ElementRef dxTarget, DevExpress.Ui.DxScrollableOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxScrollable_Init", dxTarget, json);
		}
		[JSInvokable("DevExpress.Ui.DxScrollableInterop.OnScroll")]
		public static void OnScroll(string identifier)
		{
			Scroll?.Invoke(null, new JQueryEventArgs(identifier));
		}
		[JSInvokable("DevExpress.Ui.DxScrollableInterop.OnUpdated")]
		public static void OnUpdated(string identifier)
		{
			Updated?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static bool? GetBounceEnabled(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_DxScrollable_GetOption", dxTarget, "bounceEnabled");
		}
		public static void SetBounceEnabled(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxScrollable_SetOption", dxTarget, "bounceEnabled", value);
		}
		public static string GetDirection(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_DxScrollable_GetOption", dxTarget, "direction");
		}
		public static void SetDirection(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxScrollable_SetOption", dxTarget, "direction", value);
		}
		public static bool? GetDisabled(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_DxScrollable_GetOption", dxTarget, "disabled");
		}
		public static void SetDisabled(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxScrollable_SetOption", dxTarget, "disabled", value);
		}
		public static bool? GetScrollByContent(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_DxScrollable_GetOption", dxTarget, "scrollByContent");
		}
		public static void SetScrollByContent(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxScrollable_SetOption", dxTarget, "scrollByContent", value);
		}
		public static bool? GetScrollByThumb(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_DxScrollable_GetOption", dxTarget, "scrollByThumb");
		}
		public static void SetScrollByThumb(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxScrollable_SetOption", dxTarget, "scrollByThumb", value);
		}
		public static string GetShowScrollbar(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_DxScrollable_GetOption", dxTarget, "showScrollbar");
		}
		public static void SetShowScrollbar(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxScrollable_SetOption", dxTarget, "showScrollbar", value);
		}
		public static bool? GetUseNative(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_DxScrollable_GetOption", dxTarget, "useNative");
		}
		public static void SetUseNative(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxScrollable_SetOption", dxTarget, "useNative", value);
		}
		public static float ClientHeight(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<float>("BlazorDevExtreme_DxScrollable_clientHeight_0", dxTarget);
		}
		public static float ClientWidth(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<float>("BlazorDevExtreme_DxScrollable_clientWidth_1", dxTarget);
		}
		public static object Content(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxScrollable_content_2", dxTarget);
		}
		public static void ScrollBy(ElementRef dxTarget, float distance)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxScrollable_scrollBy_3", dxTarget, distance);
		}
		public static void ScrollBy(ElementRef dxTarget, object distanceObject)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxScrollable_scrollBy_4", dxTarget, distanceObject);
		}
		public static float ScrollHeight(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<float>("BlazorDevExtreme_DxScrollable_scrollHeight_5", dxTarget);
		}
		public static float ScrollLeft(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<float>("BlazorDevExtreme_DxScrollable_scrollLeft_6", dxTarget);
		}
		public static object ScrollOffset(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxScrollable_scrollOffset_7", dxTarget);
		}
		public static void ScrollTo(ElementRef dxTarget, float targetLocation)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxScrollable_scrollTo_8", dxTarget, targetLocation);
		}
		public static void ScrollTo(ElementRef dxTarget, object targetLocation)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxScrollable_scrollTo_9", dxTarget, targetLocation);
		}
		public static void ScrollToElement(ElementRef dxTarget, object element)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxScrollable_scrollToElement_10", dxTarget, element);
		}
		public static float ScrollTop(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<float>("BlazorDevExtreme_DxScrollable_scrollTop_11", dxTarget);
		}
		public static float ScrollWidth(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<float>("BlazorDevExtreme_DxScrollable_scrollWidth_12", dxTarget);
		}
		public static object Update(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxScrollable_update_13", dxTarget);
		}
	}
	public class DxSliderBaseInterop: DxTrackBarInterop
	{
		public static void Init(ElementRef dxTarget, DevExpress.Ui.DxSliderBaseOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxSliderBase_Init", dxTarget, json);
		}
		public static new bool? GetActiveStateEnabled(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_DxSliderBase_GetOption", dxTarget, "activeStateEnabled");
		}
		public static new void SetActiveStateEnabled(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxSliderBase_SetOption", dxTarget, "activeStateEnabled", value);
		}
		public static new bool? GetFocusStateEnabled(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_DxSliderBase_GetOption", dxTarget, "focusStateEnabled");
		}
		public static new void SetFocusStateEnabled(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxSliderBase_SetOption", dxTarget, "focusStateEnabled", value);
		}
		public static new bool? GetHoverStateEnabled(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_DxSliderBase_GetOption", dxTarget, "hoverStateEnabled");
		}
		public static new void SetHoverStateEnabled(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxSliderBase_SetOption", dxTarget, "hoverStateEnabled", value);
		}
		public static float? GetKeyStep(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<float?>("BlazorDevExtreme_DxSliderBase_GetOption", dxTarget, "keyStep");
		}
		public static void SetKeyStep(ElementRef dxTarget, float? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxSliderBase_SetOption", dxTarget, "keyStep", value);
		}
		public static object GetLabel(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxSliderBase_GetOption", dxTarget, "label");
		}
		public static void SetLabel(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxSliderBase_SetOption", dxTarget, "label", value);
		}
		public static string GetName(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_DxSliderBase_GetOption", dxTarget, "name");
		}
		public static void SetName(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxSliderBase_SetOption", dxTarget, "name", value);
		}
		public static bool? GetShowRange(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_DxSliderBase_GetOption", dxTarget, "showRange");
		}
		public static void SetShowRange(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxSliderBase_SetOption", dxTarget, "showRange", value);
		}
		public static float? GetStep(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<float?>("BlazorDevExtreme_DxSliderBase_GetOption", dxTarget, "step");
		}
		public static void SetStep(ElementRef dxTarget, float? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxSliderBase_SetOption", dxTarget, "step", value);
		}
		public static object GetTooltip(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxSliderBase_GetOption", dxTarget, "tooltip");
		}
		public static void SetTooltip(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxSliderBase_SetOption", dxTarget, "tooltip", value);
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
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxTextEditor_Init", dxTarget, json);
		}
		[JSInvokable("DevExpress.Ui.DxTextEditorInterop.OnChange")]
		public static void OnChange(string identifier)
		{
			Change?.Invoke(null, new JQueryEventArgs(identifier));
		}
		[JSInvokable("DevExpress.Ui.DxTextEditorInterop.OnCopy")]
		public static void OnCopy(string identifier)
		{
			Copy?.Invoke(null, new JQueryEventArgs(identifier));
		}
		[JSInvokable("DevExpress.Ui.DxTextEditorInterop.OnCut")]
		public static void OnCut(string identifier)
		{
			Cut?.Invoke(null, new JQueryEventArgs(identifier));
		}
		[JSInvokable("DevExpress.Ui.DxTextEditorInterop.OnEnterKey")]
		public static void OnEnterKey(string identifier)
		{
			EnterKey?.Invoke(null, new JQueryEventArgs(identifier));
		}
		[JSInvokable("DevExpress.Ui.DxTextEditorInterop.OnFocusIn")]
		public static void OnFocusIn(string identifier)
		{
			FocusIn?.Invoke(null, new JQueryEventArgs(identifier));
		}
		[JSInvokable("DevExpress.Ui.DxTextEditorInterop.OnFocusOut")]
		public static void OnFocusOut(string identifier)
		{
			FocusOut?.Invoke(null, new JQueryEventArgs(identifier));
		}
		[JSInvokable("DevExpress.Ui.DxTextEditorInterop.OnInput")]
		public static void OnInput(string identifier)
		{
			Input?.Invoke(null, new JQueryEventArgs(identifier));
		}
		[JSInvokable("DevExpress.Ui.DxTextEditorInterop.OnKeyDown")]
		public static void OnKeyDown(string identifier)
		{
			KeyDown?.Invoke(null, new JQueryEventArgs(identifier));
		}
		[JSInvokable("DevExpress.Ui.DxTextEditorInterop.OnKeyPress")]
		public static void OnKeyPress(string identifier)
		{
			KeyPress?.Invoke(null, new JQueryEventArgs(identifier));
		}
		[JSInvokable("DevExpress.Ui.DxTextEditorInterop.OnKeyUp")]
		public static void OnKeyUp(string identifier)
		{
			KeyUp?.Invoke(null, new JQueryEventArgs(identifier));
		}
		[JSInvokable("DevExpress.Ui.DxTextEditorInterop.OnPaste")]
		public static void OnPaste(string identifier)
		{
			Paste?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static new bool? GetFocusStateEnabled(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_DxTextEditor_GetOption", dxTarget, "focusStateEnabled");
		}
		public static new void SetFocusStateEnabled(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxTextEditor_SetOption", dxTarget, "focusStateEnabled", value);
		}
		public static new bool? GetHoverStateEnabled(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_DxTextEditor_GetOption", dxTarget, "hoverStateEnabled");
		}
		public static new void SetHoverStateEnabled(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxTextEditor_SetOption", dxTarget, "hoverStateEnabled", value);
		}
		public static object GetInputAttr(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxTextEditor_GetOption", dxTarget, "inputAttr");
		}
		public static void SetInputAttr(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxTextEditor_SetOption", dxTarget, "inputAttr", value);
		}
		public static string GetMask(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_DxTextEditor_GetOption", dxTarget, "mask");
		}
		public static void SetMask(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxTextEditor_SetOption", dxTarget, "mask", value);
		}
		public static string GetMaskChar(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_DxTextEditor_GetOption", dxTarget, "maskChar");
		}
		public static void SetMaskChar(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxTextEditor_SetOption", dxTarget, "maskChar", value);
		}
		public static string GetMaskInvalidMessage(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_DxTextEditor_GetOption", dxTarget, "maskInvalidMessage");
		}
		public static void SetMaskInvalidMessage(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxTextEditor_SetOption", dxTarget, "maskInvalidMessage", value);
		}
		public static object GetMaskRules(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxTextEditor_GetOption", dxTarget, "maskRules");
		}
		public static void SetMaskRules(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxTextEditor_SetOption", dxTarget, "maskRules", value);
		}
		public static string GetName(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_DxTextEditor_GetOption", dxTarget, "name");
		}
		public static void SetName(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxTextEditor_SetOption", dxTarget, "name", value);
		}
		public static string GetPlaceholder(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_DxTextEditor_GetOption", dxTarget, "placeholder");
		}
		public static void SetPlaceholder(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxTextEditor_SetOption", dxTarget, "placeholder", value);
		}
		public static bool? GetShowClearButton(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_DxTextEditor_GetOption", dxTarget, "showClearButton");
		}
		public static void SetShowClearButton(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxTextEditor_SetOption", dxTarget, "showClearButton", value);
		}
		public static string GetShowMaskMode(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_DxTextEditor_GetOption", dxTarget, "showMaskMode");
		}
		public static void SetShowMaskMode(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxTextEditor_SetOption", dxTarget, "showMaskMode", value);
		}
		public static bool? GetSpellcheck(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_DxTextEditor_GetOption", dxTarget, "spellcheck");
		}
		public static void SetSpellcheck(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxTextEditor_SetOption", dxTarget, "spellcheck", value);
		}
		public static string GetText(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_DxTextEditor_GetOption", dxTarget, "text");
		}
		public static void SetText(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxTextEditor_SetOption", dxTarget, "text", value);
		}
		public static bool? GetUseMaskedValue(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_DxTextEditor_GetOption", dxTarget, "useMaskedValue");
		}
		public static void SetUseMaskedValue(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxTextEditor_SetOption", dxTarget, "useMaskedValue", value);
		}
		public static new object GetValue(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxTextEditor_GetOption", dxTarget, "value");
		}
		public static new void SetValue(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxTextEditor_SetOption", dxTarget, "value", value);
		}
		public static string GetValueChangeEvent(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_DxTextEditor_GetOption", dxTarget, "valueChangeEvent");
		}
		public static void SetValueChangeEvent(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxTextEditor_SetOption", dxTarget, "valueChangeEvent", value);
		}
		public static void Blur(ElementRef dxTarget)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxTextEditor_blur_0", dxTarget);
		}
		public static void Focus(ElementRef dxTarget)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxTextEditor_focus_1", dxTarget);
		}
	}
	public class SearchBoxMixinInterop
	{
		public static void Init(ElementRef dxTarget, DevExpress.Ui.SearchBoxMixinOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_SearchBoxMixin_Init", dxTarget, json);
		}
		public static object GetSearchEditorOptions(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_SearchBoxMixin_GetOption", dxTarget, "searchEditorOptions");
		}
		public static void SetSearchEditorOptions(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_SearchBoxMixin_SetOption", dxTarget, "searchEditorOptions", value);
		}
		public static bool? GetSearchEnabled(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_SearchBoxMixin_GetOption", dxTarget, "searchEnabled");
		}
		public static void SetSearchEnabled(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_SearchBoxMixin_SetOption", dxTarget, "searchEnabled", value);
		}
		public static object GetSearchExpr(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_SearchBoxMixin_GetOption", dxTarget, "searchExpr");
		}
		public static void SetSearchExpr(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_SearchBoxMixin_SetOption", dxTarget, "searchExpr", value);
		}
		public static string GetSearchMode(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_SearchBoxMixin_GetOption", dxTarget, "searchMode");
		}
		public static void SetSearchMode(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_SearchBoxMixin_SetOption", dxTarget, "searchMode", value);
		}
		public static float? GetSearchTimeout(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<float?>("BlazorDevExtreme_SearchBoxMixin_GetOption", dxTarget, "searchTimeout");
		}
		public static void SetSearchTimeout(ElementRef dxTarget, float? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_SearchBoxMixin_SetOption", dxTarget, "searchTimeout", value);
		}
		public static string GetSearchValue(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_SearchBoxMixin_GetOption", dxTarget, "searchValue");
		}
		public static void SetSearchValue(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_SearchBoxMixin_SetOption", dxTarget, "searchValue", value);
		}
	}
	public class DxTemplateInterop
	{
		public static void Init(ElementRef dxTarget, DevExpress.Ui.DxTemplateOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxTemplate_Init", dxTarget, json);
		}
		public static string GetName(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_DxTemplate_GetOption", dxTarget, "name");
		}
		public static void SetName(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxTemplate_SetOption", dxTarget, "name", value);
		}
	}
	public class WidgetInterop: DOMComponentInterop
	{
		public static event EventHandler<JQueryEventArgs> ContentReady;
		public static void Init(ElementRef dxTarget, DevExpress.Ui.WidgetOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_Widget_Init", dxTarget, json);
		}
		[JSInvokable("DevExpress.Ui.WidgetInterop.OnContentReady")]
		public static void OnContentReady(string identifier)
		{
			ContentReady?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static string GetAccessKey(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_Widget_GetOption", dxTarget, "accessKey");
		}
		public static void SetAccessKey(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_Widget_SetOption", dxTarget, "accessKey", value);
		}
		public static bool? GetActiveStateEnabled(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_Widget_GetOption", dxTarget, "activeStateEnabled");
		}
		public static void SetActiveStateEnabled(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_Widget_SetOption", dxTarget, "activeStateEnabled", value);
		}
		public static bool? GetDisabled(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_Widget_GetOption", dxTarget, "disabled");
		}
		public static void SetDisabled(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_Widget_SetOption", dxTarget, "disabled", value);
		}
		public static bool? GetFocusStateEnabled(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_Widget_GetOption", dxTarget, "focusStateEnabled");
		}
		public static void SetFocusStateEnabled(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_Widget_SetOption", dxTarget, "focusStateEnabled", value);
		}
		public static string GetHint(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_Widget_GetOption", dxTarget, "hint");
		}
		public static void SetHint(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_Widget_SetOption", dxTarget, "hint", value);
		}
		public static bool? GetHoverStateEnabled(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_Widget_GetOption", dxTarget, "hoverStateEnabled");
		}
		public static void SetHoverStateEnabled(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_Widget_SetOption", dxTarget, "hoverStateEnabled", value);
		}
		public static float? GetTabIndex(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<float?>("BlazorDevExtreme_Widget_GetOption", dxTarget, "tabIndex");
		}
		public static void SetTabIndex(ElementRef dxTarget, float? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_Widget_SetOption", dxTarget, "tabIndex", value);
		}
		public static bool? GetVisible(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_Widget_GetOption", dxTarget, "visible");
		}
		public static void SetVisible(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_Widget_SetOption", dxTarget, "visible", value);
		}
		public static void Focus(ElementRef dxTarget)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_Widget_focus_0", dxTarget);
		}
		public static void RegisterKeyHandler(ElementRef dxTarget, string key, object handler)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_Widget_registerKeyHandler_1", dxTarget, key, handler);
		}
		public static void Repaint(ElementRef dxTarget)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_Widget_repaint_2", dxTarget);
		}
	}
	public class DialogInterop
	{
		public static object Alert(string message, string title)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_Dialog_alert_0", message, title);
		}
		public static object Confirm(string message, string title)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_Dialog_confirm_1", message, title);
		}
		public static object Custom(object options)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_Dialog_custom_2", options);
		}
	}
	public class ThemesInterop
	{
		public static string Current()
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_Themes_current_0");
		}
		public static void Current(string themeName)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_Themes_current_1", themeName);
		}
		public static void Ready(object callback)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_Themes_ready_2", callback);
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
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_BaseWidget_Init", dxTarget, json);
		}
		[JSInvokable("DevExpress.Viz.BaseWidgetInterop.OnDrawn")]
		public static void OnDrawn(string identifier)
		{
			Drawn?.Invoke(null, new JQueryEventArgs(identifier));
		}
		[JSInvokable("DevExpress.Viz.BaseWidgetInterop.OnExported")]
		public static void OnExported(string identifier)
		{
			Exported?.Invoke(null, new JQueryEventArgs(identifier));
		}
		[JSInvokable("DevExpress.Viz.BaseWidgetInterop.OnExporting")]
		public static void OnExporting(string identifier)
		{
			Exporting?.Invoke(null, new JQueryEventArgs(identifier));
		}
		[JSInvokable("DevExpress.Viz.BaseWidgetInterop.OnFileSaving")]
		public static void OnFileSaving(string identifier)
		{
			FileSaving?.Invoke(null, new JQueryEventArgs(identifier));
		}
		[JSInvokable("DevExpress.Viz.BaseWidgetInterop.OnIncidentOccurred")]
		public static void OnIncidentOccurred(string identifier)
		{
			IncidentOccurred?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static object GetExport(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_BaseWidget_GetOption", dxTarget, "export");
		}
		public static void SetExport(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_BaseWidget_SetOption", dxTarget, "export", value);
		}
		public static object GetLoadingIndicator(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_BaseWidget_GetOption", dxTarget, "loadingIndicator");
		}
		public static void SetLoadingIndicator(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_BaseWidget_SetOption", dxTarget, "loadingIndicator", value);
		}
		public static object GetMargin(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_BaseWidget_GetOption", dxTarget, "margin");
		}
		public static void SetMargin(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_BaseWidget_SetOption", dxTarget, "margin", value);
		}
		public static bool? GetPathModified(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_BaseWidget_GetOption", dxTarget, "pathModified");
		}
		public static void SetPathModified(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_BaseWidget_SetOption", dxTarget, "pathModified", value);
		}
		public static bool? GetRedrawOnResize(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_BaseWidget_GetOption", dxTarget, "redrawOnResize");
		}
		public static void SetRedrawOnResize(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_BaseWidget_SetOption", dxTarget, "redrawOnResize", value);
		}
		public static new bool? GetRtlEnabled(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_BaseWidget_GetOption", dxTarget, "rtlEnabled");
		}
		public static new void SetRtlEnabled(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_BaseWidget_SetOption", dxTarget, "rtlEnabled", value);
		}
		public static object GetSize(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_BaseWidget_GetOption", dxTarget, "size");
		}
		public static void SetSize(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_BaseWidget_SetOption", dxTarget, "size", value);
		}
		public static string GetTheme(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_BaseWidget_GetOption", dxTarget, "theme");
		}
		public static void SetTheme(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_BaseWidget_SetOption", dxTarget, "theme", value);
		}
		public static object GetTitle(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_BaseWidget_GetOption", dxTarget, "title");
		}
		public static void SetTitle(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_BaseWidget_SetOption", dxTarget, "title", value);
		}
		public static object GetTooltip(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_BaseWidget_GetOption", dxTarget, "tooltip");
		}
		public static void SetTooltip(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_BaseWidget_SetOption", dxTarget, "tooltip", value);
		}
		public static void ExportTo(ElementRef dxTarget, string fileName, string format)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_BaseWidget_exportTo_0", dxTarget, fileName, format);
		}
		public static object GetSizeEx(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_BaseWidget_getSize_1", dxTarget);
		}
		public static void HideLoadingIndicator(ElementRef dxTarget)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_BaseWidget_hideLoadingIndicator_2", dxTarget);
		}
		public static void Print(ElementRef dxTarget)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_BaseWidget_print_3", dxTarget);
		}
		public static void Render(ElementRef dxTarget)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_BaseWidget_render_4", dxTarget);
		}
		public static void ShowLoadingIndicator(ElementRef dxTarget)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_BaseWidget_showLoadingIndicator_5", dxTarget);
		}
		public static string Svg(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_BaseWidget_svg_6", dxTarget);
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
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxChart_Init", dxTarget, json);
		}
		[JSInvokable("DevExpress.Viz.DxChartInterop.OnArgumentAxisClick")]
		public static void OnArgumentAxisClick(string identifier)
		{
			ArgumentAxisClick?.Invoke(null, new JQueryEventArgs(identifier));
		}
		[JSInvokable("DevExpress.Viz.DxChartInterop.OnLegendClick")]
		public static void OnLegendClick(string identifier)
		{
			LegendClick?.Invoke(null, new JQueryEventArgs(identifier));
		}
		[JSInvokable("DevExpress.Viz.DxChartInterop.OnSeriesClick")]
		public static void OnSeriesClick(string identifier)
		{
			SeriesClick?.Invoke(null, new JQueryEventArgs(identifier));
		}
		[JSInvokable("DevExpress.Viz.DxChartInterop.OnSeriesHoverChanged")]
		public static void OnSeriesHoverChanged(string identifier)
		{
			SeriesHoverChanged?.Invoke(null, new JQueryEventArgs(identifier));
		}
		[JSInvokable("DevExpress.Viz.DxChartInterop.OnSeriesSelectionChanged")]
		public static void OnSeriesSelectionChanged(string identifier)
		{
			SeriesSelectionChanged?.Invoke(null, new JQueryEventArgs(identifier));
		}
		[JSInvokable("DevExpress.Viz.DxChartInterop.OnZoomEnd")]
		public static void OnZoomEnd(string identifier)
		{
			ZoomEnd?.Invoke(null, new JQueryEventArgs(identifier));
		}
		[JSInvokable("DevExpress.Viz.DxChartInterop.OnZoomStart")]
		public static void OnZoomStart(string identifier)
		{
			ZoomStart?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static bool? GetAdjustOnZoom(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_DxChart_GetOption", dxTarget, "adjustOnZoom");
		}
		public static void SetAdjustOnZoom(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxChart_SetOption", dxTarget, "adjustOnZoom", value);
		}
		public static object GetArgumentAxis(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxChart_GetOption", dxTarget, "argumentAxis");
		}
		public static void SetArgumentAxis(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxChart_SetOption", dxTarget, "argumentAxis", value);
		}
		public static float? GetBarGroupPadding(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<float?>("BlazorDevExtreme_DxChart_GetOption", dxTarget, "barGroupPadding");
		}
		public static void SetBarGroupPadding(ElementRef dxTarget, float? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxChart_SetOption", dxTarget, "barGroupPadding", value);
		}
		public static float? GetBarGroupWidth(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<float?>("BlazorDevExtreme_DxChart_GetOption", dxTarget, "barGroupWidth");
		}
		public static void SetBarGroupWidth(ElementRef dxTarget, float? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxChart_SetOption", dxTarget, "barGroupWidth", value);
		}
		public static float? GetBarWidth(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<float?>("BlazorDevExtreme_DxChart_GetOption", dxTarget, "barWidth");
		}
		public static void SetBarWidth(ElementRef dxTarget, float? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxChart_SetOption", dxTarget, "barWidth", value);
		}
		public static object GetCommonAxisSettings(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxChart_GetOption", dxTarget, "commonAxisSettings");
		}
		public static void SetCommonAxisSettings(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxChart_SetOption", dxTarget, "commonAxisSettings", value);
		}
		public static object GetCommonPaneSettings(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxChart_GetOption", dxTarget, "commonPaneSettings");
		}
		public static void SetCommonPaneSettings(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxChart_SetOption", dxTarget, "commonPaneSettings", value);
		}
		public static object GetCommonSeriesSettings(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxChart_GetOption", dxTarget, "commonSeriesSettings");
		}
		public static void SetCommonSeriesSettings(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxChart_SetOption", dxTarget, "commonSeriesSettings", value);
		}
		public static string GetContainerBackgroundColor(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_DxChart_GetOption", dxTarget, "containerBackgroundColor");
		}
		public static void SetContainerBackgroundColor(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxChart_SetOption", dxTarget, "containerBackgroundColor", value);
		}
		public static object GetCrosshair(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxChart_GetOption", dxTarget, "crosshair");
		}
		public static void SetCrosshair(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxChart_SetOption", dxTarget, "crosshair", value);
		}
		public static object GetDataPrepareSettings(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxChart_GetOption", dxTarget, "dataPrepareSettings");
		}
		public static void SetDataPrepareSettings(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxChart_SetOption", dxTarget, "dataPrepareSettings", value);
		}
		public static string GetDefaultPane(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_DxChart_GetOption", dxTarget, "defaultPane");
		}
		public static void SetDefaultPane(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxChart_SetOption", dxTarget, "defaultPane", value);
		}
		public static bool? GetEqualBarWidth(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_DxChart_GetOption", dxTarget, "equalBarWidth");
		}
		public static void SetEqualBarWidth(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxChart_SetOption", dxTarget, "equalBarWidth", value);
		}
		public static new object GetLegend(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxChart_GetOption", dxTarget, "legend");
		}
		public static new void SetLegend(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxChart_SetOption", dxTarget, "legend", value);
		}
		public static float? GetMaxBubbleSize(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<float?>("BlazorDevExtreme_DxChart_GetOption", dxTarget, "maxBubbleSize");
		}
		public static void SetMaxBubbleSize(ElementRef dxTarget, float? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxChart_SetOption", dxTarget, "maxBubbleSize", value);
		}
		public static float? GetMinBubbleSize(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<float?>("BlazorDevExtreme_DxChart_GetOption", dxTarget, "minBubbleSize");
		}
		public static void SetMinBubbleSize(ElementRef dxTarget, float? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxChart_SetOption", dxTarget, "minBubbleSize", value);
		}
		public static bool? GetNegativesAsZeroes(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_DxChart_GetOption", dxTarget, "negativesAsZeroes");
		}
		public static void SetNegativesAsZeroes(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxChart_SetOption", dxTarget, "negativesAsZeroes", value);
		}
		public static object GetPanes(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxChart_GetOption", dxTarget, "panes");
		}
		public static void SetPanes(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxChart_SetOption", dxTarget, "panes", value);
		}
		public static string GetResolveLabelOverlapping(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_DxChart_GetOption", dxTarget, "resolveLabelOverlapping");
		}
		public static void SetResolveLabelOverlapping(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxChart_SetOption", dxTarget, "resolveLabelOverlapping", value);
		}
		public static bool? GetRotated(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_DxChart_GetOption", dxTarget, "rotated");
		}
		public static void SetRotated(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxChart_SetOption", dxTarget, "rotated", value);
		}
		public static object GetScrollBar(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxChart_GetOption", dxTarget, "scrollBar");
		}
		public static void SetScrollBar(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxChart_SetOption", dxTarget, "scrollBar", value);
		}
		public static string GetScrollingMode(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_DxChart_GetOption", dxTarget, "scrollingMode");
		}
		public static void SetScrollingMode(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxChart_SetOption", dxTarget, "scrollingMode", value);
		}
		public static new object GetSeries(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxChart_GetOption", dxTarget, "series");
		}
		public static new void SetSeries(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxChart_SetOption", dxTarget, "series", value);
		}
		public static string GetSeriesSelectionMode(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_DxChart_GetOption", dxTarget, "seriesSelectionMode");
		}
		public static void SetSeriesSelectionMode(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxChart_SetOption", dxTarget, "seriesSelectionMode", value);
		}
		public static object GetSeriesTemplate(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxChart_GetOption", dxTarget, "seriesTemplate");
		}
		public static void SetSeriesTemplate(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxChart_SetOption", dxTarget, "seriesTemplate", value);
		}
		public static bool? GetSynchronizeMultiAxes(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_DxChart_GetOption", dxTarget, "synchronizeMultiAxes");
		}
		public static void SetSynchronizeMultiAxes(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxChart_SetOption", dxTarget, "synchronizeMultiAxes", value);
		}
		public static new object GetTooltip(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxChart_GetOption", dxTarget, "tooltip");
		}
		public static new void SetTooltip(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxChart_SetOption", dxTarget, "tooltip", value);
		}
		public static bool? GetUseAggregation(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_DxChart_GetOption", dxTarget, "useAggregation");
		}
		public static void SetUseAggregation(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxChart_SetOption", dxTarget, "useAggregation", value);
		}
		public static object GetValueAxis(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxChart_GetOption", dxTarget, "valueAxis");
		}
		public static void SetValueAxis(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxChart_SetOption", dxTarget, "valueAxis", value);
		}
		public static string GetZoomingMode(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_DxChart_GetOption", dxTarget, "zoomingMode");
		}
		public static void SetZoomingMode(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxChart_SetOption", dxTarget, "zoomingMode", value);
		}
		public static void ZoomArgument(ElementRef dxTarget, object startValue, object endValue)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxChart_zoomArgument_0", dxTarget, startValue, endValue);
		}
	}
	public class DxPieChartInterop: BaseChartInterop
	{
		public static event EventHandler<JQueryEventArgs> LegendClick;
		public static void Init(ElementRef dxTarget, DevExpress.Viz.Charts.DxPieChartOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxPieChart_Init", dxTarget, json);
		}
		[JSInvokable("DevExpress.Viz.DxPieChartInterop.OnLegendClick")]
		public static void OnLegendClick(string identifier)
		{
			LegendClick?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static new object GetAdaptiveLayout(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxPieChart_GetOption", dxTarget, "adaptiveLayout");
		}
		public static new void SetAdaptiveLayout(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxPieChart_SetOption", dxTarget, "adaptiveLayout", value);
		}
		public static object GetCommonSeriesSettings(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxPieChart_GetOption", dxTarget, "commonSeriesSettings");
		}
		public static void SetCommonSeriesSettings(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxPieChart_SetOption", dxTarget, "commonSeriesSettings", value);
		}
		public static float? GetDiameter(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<float?>("BlazorDevExtreme_DxPieChart_GetOption", dxTarget, "diameter");
		}
		public static void SetDiameter(ElementRef dxTarget, float? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxPieChart_SetOption", dxTarget, "diameter", value);
		}
		public static float? GetInnerRadius(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<float?>("BlazorDevExtreme_DxPieChart_GetOption", dxTarget, "innerRadius");
		}
		public static void SetInnerRadius(ElementRef dxTarget, float? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxPieChart_SetOption", dxTarget, "innerRadius", value);
		}
		public static new object GetLegend(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxPieChart_GetOption", dxTarget, "legend");
		}
		public static new void SetLegend(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxPieChart_SetOption", dxTarget, "legend", value);
		}
		public static float? GetMinDiameter(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<float?>("BlazorDevExtreme_DxPieChart_GetOption", dxTarget, "minDiameter");
		}
		public static void SetMinDiameter(ElementRef dxTarget, float? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxPieChart_SetOption", dxTarget, "minDiameter", value);
		}
		public static new object GetPalette(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxPieChart_GetOption", dxTarget, "palette");
		}
		public static new void SetPalette(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxPieChart_SetOption", dxTarget, "palette", value);
		}
		public static string GetResolveLabelOverlapping(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_DxPieChart_GetOption", dxTarget, "resolveLabelOverlapping");
		}
		public static void SetResolveLabelOverlapping(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxPieChart_SetOption", dxTarget, "resolveLabelOverlapping", value);
		}
		public static string GetSegmentsDirection(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_DxPieChart_GetOption", dxTarget, "segmentsDirection");
		}
		public static void SetSegmentsDirection(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxPieChart_SetOption", dxTarget, "segmentsDirection", value);
		}
		public static new object GetSeries(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxPieChart_GetOption", dxTarget, "series");
		}
		public static new void SetSeries(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxPieChart_SetOption", dxTarget, "series", value);
		}
		public static object GetSeriesTemplate(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxPieChart_GetOption", dxTarget, "seriesTemplate");
		}
		public static void SetSeriesTemplate(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxPieChart_SetOption", dxTarget, "seriesTemplate", value);
		}
		public static string GetSizeGroup(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_DxPieChart_GetOption", dxTarget, "sizeGroup");
		}
		public static void SetSizeGroup(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxPieChart_SetOption", dxTarget, "sizeGroup", value);
		}
		public static float? GetStartAngle(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<float?>("BlazorDevExtreme_DxPieChart_GetOption", dxTarget, "startAngle");
		}
		public static void SetStartAngle(ElementRef dxTarget, float? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxPieChart_SetOption", dxTarget, "startAngle", value);
		}
		public static string GetType(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_DxPieChart_GetOption", dxTarget, "type");
		}
		public static void SetType(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxPieChart_SetOption", dxTarget, "type", value);
		}
		public static object GetSeriesEx(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxPieChart_getSeries_0", dxTarget);
		}
		public static object GetSeriesByName(ElementRef dxTarget, object seriesName)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxPieChart_getSeriesByName_1", dxTarget, seriesName);
		}
		public static object GetSeriesByPos(ElementRef dxTarget, float seriesIndex)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxPieChart_getSeriesByPos_2", dxTarget, seriesIndex);
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
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxPolarChart_Init", dxTarget, json);
		}
		[JSInvokable("DevExpress.Viz.DxPolarChartInterop.OnArgumentAxisClick")]
		public static void OnArgumentAxisClick(string identifier)
		{
			ArgumentAxisClick?.Invoke(null, new JQueryEventArgs(identifier));
		}
		[JSInvokable("DevExpress.Viz.DxPolarChartInterop.OnLegendClick")]
		public static void OnLegendClick(string identifier)
		{
			LegendClick?.Invoke(null, new JQueryEventArgs(identifier));
		}
		[JSInvokable("DevExpress.Viz.DxPolarChartInterop.OnSeriesClick")]
		public static void OnSeriesClick(string identifier)
		{
			SeriesClick?.Invoke(null, new JQueryEventArgs(identifier));
		}
		[JSInvokable("DevExpress.Viz.DxPolarChartInterop.OnSeriesHoverChanged")]
		public static void OnSeriesHoverChanged(string identifier)
		{
			SeriesHoverChanged?.Invoke(null, new JQueryEventArgs(identifier));
		}
		[JSInvokable("DevExpress.Viz.DxPolarChartInterop.OnSeriesSelectionChanged")]
		public static void OnSeriesSelectionChanged(string identifier)
		{
			SeriesSelectionChanged?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static new object GetAdaptiveLayout(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxPolarChart_GetOption", dxTarget, "adaptiveLayout");
		}
		public static new void SetAdaptiveLayout(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxPolarChart_SetOption", dxTarget, "adaptiveLayout", value);
		}
		public static object GetArgumentAxis(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxPolarChart_GetOption", dxTarget, "argumentAxis");
		}
		public static void SetArgumentAxis(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxPolarChart_SetOption", dxTarget, "argumentAxis", value);
		}
		public static float? GetBarGroupPadding(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<float?>("BlazorDevExtreme_DxPolarChart_GetOption", dxTarget, "barGroupPadding");
		}
		public static void SetBarGroupPadding(ElementRef dxTarget, float? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxPolarChart_SetOption", dxTarget, "barGroupPadding", value);
		}
		public static float? GetBarGroupWidth(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<float?>("BlazorDevExtreme_DxPolarChart_GetOption", dxTarget, "barGroupWidth");
		}
		public static void SetBarGroupWidth(ElementRef dxTarget, float? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxPolarChart_SetOption", dxTarget, "barGroupWidth", value);
		}
		public static float? GetBarWidth(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<float?>("BlazorDevExtreme_DxPolarChart_GetOption", dxTarget, "barWidth");
		}
		public static void SetBarWidth(ElementRef dxTarget, float? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxPolarChart_SetOption", dxTarget, "barWidth", value);
		}
		public static object GetCommonAxisSettings(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxPolarChart_GetOption", dxTarget, "commonAxisSettings");
		}
		public static void SetCommonAxisSettings(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxPolarChart_SetOption", dxTarget, "commonAxisSettings", value);
		}
		public static object GetCommonSeriesSettings(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxPolarChart_GetOption", dxTarget, "commonSeriesSettings");
		}
		public static void SetCommonSeriesSettings(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxPolarChart_SetOption", dxTarget, "commonSeriesSettings", value);
		}
		public static string GetContainerBackgroundColor(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_DxPolarChart_GetOption", dxTarget, "containerBackgroundColor");
		}
		public static void SetContainerBackgroundColor(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxPolarChart_SetOption", dxTarget, "containerBackgroundColor", value);
		}
		public static object GetDataPrepareSettings(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxPolarChart_GetOption", dxTarget, "dataPrepareSettings");
		}
		public static void SetDataPrepareSettings(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxPolarChart_SetOption", dxTarget, "dataPrepareSettings", value);
		}
		public static bool? GetEqualBarWidth(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_DxPolarChart_GetOption", dxTarget, "equalBarWidth");
		}
		public static void SetEqualBarWidth(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxPolarChart_SetOption", dxTarget, "equalBarWidth", value);
		}
		public static new object GetLegend(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxPolarChart_GetOption", dxTarget, "legend");
		}
		public static new void SetLegend(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxPolarChart_SetOption", dxTarget, "legend", value);
		}
		public static bool? GetNegativesAsZeroes(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_DxPolarChart_GetOption", dxTarget, "negativesAsZeroes");
		}
		public static void SetNegativesAsZeroes(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxPolarChart_SetOption", dxTarget, "negativesAsZeroes", value);
		}
		public static string GetResolveLabelOverlapping(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_DxPolarChart_GetOption", dxTarget, "resolveLabelOverlapping");
		}
		public static void SetResolveLabelOverlapping(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxPolarChart_SetOption", dxTarget, "resolveLabelOverlapping", value);
		}
		public static new object GetSeries(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxPolarChart_GetOption", dxTarget, "series");
		}
		public static new void SetSeries(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxPolarChart_SetOption", dxTarget, "series", value);
		}
		public static string GetSeriesSelectionMode(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_DxPolarChart_GetOption", dxTarget, "seriesSelectionMode");
		}
		public static void SetSeriesSelectionMode(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxPolarChart_SetOption", dxTarget, "seriesSelectionMode", value);
		}
		public static object GetSeriesTemplate(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxPolarChart_GetOption", dxTarget, "seriesTemplate");
		}
		public static void SetSeriesTemplate(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxPolarChart_SetOption", dxTarget, "seriesTemplate", value);
		}
		public static new object GetTooltip(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxPolarChart_GetOption", dxTarget, "tooltip");
		}
		public static new void SetTooltip(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxPolarChart_SetOption", dxTarget, "tooltip", value);
		}
		public static bool? GetUseSpiderWeb(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_DxPolarChart_GetOption", dxTarget, "useSpiderWeb");
		}
		public static void SetUseSpiderWeb(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxPolarChart_SetOption", dxTarget, "useSpiderWeb", value);
		}
		public static object GetValueAxis(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxPolarChart_GetOption", dxTarget, "valueAxis");
		}
		public static void SetValueAxis(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxPolarChart_SetOption", dxTarget, "valueAxis", value);
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
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_BaseChart_Init", dxTarget, json);
		}
		[JSInvokable("DevExpress.Viz.BaseChartInterop.OnDone")]
		public static void OnDone(string identifier)
		{
			Done?.Invoke(null, new JQueryEventArgs(identifier));
		}
		[JSInvokable("DevExpress.Viz.BaseChartInterop.OnPointClick")]
		public static void OnPointClick(string identifier)
		{
			PointClick?.Invoke(null, new JQueryEventArgs(identifier));
		}
		[JSInvokable("DevExpress.Viz.BaseChartInterop.OnPointHoverChanged")]
		public static void OnPointHoverChanged(string identifier)
		{
			PointHoverChanged?.Invoke(null, new JQueryEventArgs(identifier));
		}
		[JSInvokable("DevExpress.Viz.BaseChartInterop.OnPointSelectionChanged")]
		public static void OnPointSelectionChanged(string identifier)
		{
			PointSelectionChanged?.Invoke(null, new JQueryEventArgs(identifier));
		}
		[JSInvokable("DevExpress.Viz.BaseChartInterop.OnTooltipHidden")]
		public static void OnTooltipHidden(string identifier)
		{
			TooltipHidden?.Invoke(null, new JQueryEventArgs(identifier));
		}
		[JSInvokable("DevExpress.Viz.BaseChartInterop.OnTooltipShown")]
		public static void OnTooltipShown(string identifier)
		{
			TooltipShown?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static object GetAdaptiveLayout(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_BaseChart_GetOption", dxTarget, "adaptiveLayout");
		}
		public static void SetAdaptiveLayout(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_BaseChart_SetOption", dxTarget, "adaptiveLayout", value);
		}
		public static object GetAnimation(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_BaseChart_GetOption", dxTarget, "animation");
		}
		public static void SetAnimation(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_BaseChart_SetOption", dxTarget, "animation", value);
		}
		public static object GetCustomizeLabel(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_BaseChart_GetOption", dxTarget, "customizeLabel");
		}
		public static void SetCustomizeLabel(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_BaseChart_SetOption", dxTarget, "customizeLabel", value);
		}
		public static object GetCustomizePoint(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_BaseChart_GetOption", dxTarget, "customizePoint");
		}
		public static void SetCustomizePoint(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_BaseChart_SetOption", dxTarget, "customizePoint", value);
		}
		public static object GetDataSource(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_BaseChart_GetOption", dxTarget, "dataSource");
		}
		public static void SetDataSource(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_BaseChart_SetOption", dxTarget, "dataSource", value);
		}
		public static object GetLegend(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_BaseChart_GetOption", dxTarget, "legend");
		}
		public static void SetLegend(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_BaseChart_SetOption", dxTarget, "legend", value);
		}
		public static object GetPalette(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_BaseChart_GetOption", dxTarget, "palette");
		}
		public static void SetPalette(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_BaseChart_SetOption", dxTarget, "palette", value);
		}
		public static string GetPaletteExtensionMode(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_BaseChart_GetOption", dxTarget, "paletteExtensionMode");
		}
		public static void SetPaletteExtensionMode(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_BaseChart_SetOption", dxTarget, "paletteExtensionMode", value);
		}
		public static string GetPointSelectionMode(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_BaseChart_GetOption", dxTarget, "pointSelectionMode");
		}
		public static void SetPointSelectionMode(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_BaseChart_SetOption", dxTarget, "pointSelectionMode", value);
		}
		public static object GetSeries(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_BaseChart_GetOption", dxTarget, "series");
		}
		public static void SetSeries(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_BaseChart_SetOption", dxTarget, "series", value);
		}
		public static new object GetTooltip(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_BaseChart_GetOption", dxTarget, "tooltip");
		}
		public static new void SetTooltip(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_BaseChart_SetOption", dxTarget, "tooltip", value);
		}
		public static void ClearSelection(ElementRef dxTarget)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_BaseChart_clearSelection_0", dxTarget);
		}
		public static object GetAllSeries(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_BaseChart_getAllSeries_1", dxTarget);
		}
		public static object GetDataSourceEx(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_BaseChart_getDataSource_2", dxTarget);
		}
		public static object GetSeriesByName(ElementRef dxTarget, object seriesName)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_BaseChart_getSeriesByName_3", dxTarget, seriesName);
		}
		public static object GetSeriesByPos(ElementRef dxTarget, float seriesIndex)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_BaseChart_getSeriesByPos_4", dxTarget, seriesIndex);
		}
		public static void HideTooltip(ElementRef dxTarget)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_BaseChart_hideTooltip_5", dxTarget);
		}
		public static void Render(ElementRef dxTarget)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_BaseChart_render_6", dxTarget);
		}
		public static void Render(ElementRef dxTarget, object renderOptions)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_BaseChart_render_7", dxTarget, renderOptions);
		}
	}
	public class DxExporterInterop: ComponentInterop
	{
		public static void Init(ElementRef dxTarget, DevExpress.Viz.DxExporterOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxExporter_Init", dxTarget, json);
		}
		public static object GetExportFormat(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxExporter_GetOption", dxTarget, "exportFormat");
		}
		public static void SetExportFormat(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxExporter_SetOption", dxTarget, "exportFormat", value);
		}
		public static string GetFileName(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_DxExporter_GetOption", dxTarget, "fileName");
		}
		public static void SetFileName(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxExporter_SetOption", dxTarget, "fileName", value);
		}
		public static bool? GetPrintingEnabled(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_DxExporter_GetOption", dxTarget, "printingEnabled");
		}
		public static void SetPrintingEnabled(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxExporter_SetOption", dxTarget, "printingEnabled", value);
		}
		public static string GetServerUrl(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_DxExporter_GetOption", dxTarget, "serverUrl");
		}
		public static void SetServerUrl(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxExporter_SetOption", dxTarget, "serverUrl", value);
		}
		public static bool? GetShowMenu(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_DxExporter_GetOption", dxTarget, "showMenu");
		}
		public static void SetShowMenu(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxExporter_SetOption", dxTarget, "showMenu", value);
		}
		public static string GetSourceContainer(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_DxExporter_GetOption", dxTarget, "sourceContainer");
		}
		public static void SetSourceContainer(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxExporter_SetOption", dxTarget, "sourceContainer", value);
		}
		public static void ExportTo(ElementRef dxTarget, string fileName, string format)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxExporter_exportTo_0", dxTarget, fileName, format);
		}
		public static void Print(ElementRef dxTarget)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxExporter_print_1", dxTarget);
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
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxFunnel_Init", dxTarget, json);
		}
		[JSInvokable("DevExpress.Viz.DxFunnelInterop.OnHoverChanged")]
		public static void OnHoverChanged(string identifier)
		{
			HoverChanged?.Invoke(null, new JQueryEventArgs(identifier));
		}
		[JSInvokable("DevExpress.Viz.DxFunnelInterop.OnItemClick")]
		public static void OnItemClick(string identifier)
		{
			ItemClick?.Invoke(null, new JQueryEventArgs(identifier));
		}
		[JSInvokable("DevExpress.Viz.DxFunnelInterop.OnLegendClick")]
		public static void OnLegendClick(string identifier)
		{
			LegendClick?.Invoke(null, new JQueryEventArgs(identifier));
		}
		[JSInvokable("DevExpress.Viz.DxFunnelInterop.OnSelectionChanged")]
		public static void OnSelectionChanged(string identifier)
		{
			SelectionChanged?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static object GetAdaptiveLayout(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxFunnel_GetOption", dxTarget, "adaptiveLayout");
		}
		public static void SetAdaptiveLayout(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxFunnel_SetOption", dxTarget, "adaptiveLayout", value);
		}
		public static string GetAlgorithm(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_DxFunnel_GetOption", dxTarget, "algorithm");
		}
		public static void SetAlgorithm(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxFunnel_SetOption", dxTarget, "algorithm", value);
		}
		public static string GetArgumentField(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_DxFunnel_GetOption", dxTarget, "argumentField");
		}
		public static void SetArgumentField(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxFunnel_SetOption", dxTarget, "argumentField", value);
		}
		public static string GetColorField(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_DxFunnel_GetOption", dxTarget, "colorField");
		}
		public static void SetColorField(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxFunnel_SetOption", dxTarget, "colorField", value);
		}
		public static object GetDataSource(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxFunnel_GetOption", dxTarget, "dataSource");
		}
		public static void SetDataSource(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxFunnel_SetOption", dxTarget, "dataSource", value);
		}
		public static bool? GetHoverEnabled(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_DxFunnel_GetOption", dxTarget, "hoverEnabled");
		}
		public static void SetHoverEnabled(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxFunnel_SetOption", dxTarget, "hoverEnabled", value);
		}
		public static bool? GetInverted(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_DxFunnel_GetOption", dxTarget, "inverted");
		}
		public static void SetInverted(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxFunnel_SetOption", dxTarget, "inverted", value);
		}
		public static object GetItem(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxFunnel_GetOption", dxTarget, "item");
		}
		public static void SetItem(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxFunnel_SetOption", dxTarget, "item", value);
		}
		public static object GetLabel(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxFunnel_GetOption", dxTarget, "label");
		}
		public static void SetLabel(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxFunnel_SetOption", dxTarget, "label", value);
		}
		public static object GetLegend(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxFunnel_GetOption", dxTarget, "legend");
		}
		public static void SetLegend(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxFunnel_SetOption", dxTarget, "legend", value);
		}
		public static float? GetNeckHeight(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<float?>("BlazorDevExtreme_DxFunnel_GetOption", dxTarget, "neckHeight");
		}
		public static void SetNeckHeight(ElementRef dxTarget, float? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxFunnel_SetOption", dxTarget, "neckHeight", value);
		}
		public static float? GetNeckWidth(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<float?>("BlazorDevExtreme_DxFunnel_GetOption", dxTarget, "neckWidth");
		}
		public static void SetNeckWidth(ElementRef dxTarget, float? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxFunnel_SetOption", dxTarget, "neckWidth", value);
		}
		public static object GetPalette(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxFunnel_GetOption", dxTarget, "palette");
		}
		public static void SetPalette(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxFunnel_SetOption", dxTarget, "palette", value);
		}
		public static string GetPaletteExtensionMode(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_DxFunnel_GetOption", dxTarget, "paletteExtensionMode");
		}
		public static void SetPaletteExtensionMode(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxFunnel_SetOption", dxTarget, "paletteExtensionMode", value);
		}
		public static string GetSelectionMode(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_DxFunnel_GetOption", dxTarget, "selectionMode");
		}
		public static void SetSelectionMode(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxFunnel_SetOption", dxTarget, "selectionMode", value);
		}
		public static bool? GetSortData(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_DxFunnel_GetOption", dxTarget, "sortData");
		}
		public static void SetSortData(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxFunnel_SetOption", dxTarget, "sortData", value);
		}
		public static new object GetTooltip(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxFunnel_GetOption", dxTarget, "tooltip");
		}
		public static new void SetTooltip(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxFunnel_SetOption", dxTarget, "tooltip", value);
		}
		public static string GetValueField(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_DxFunnel_GetOption", dxTarget, "valueField");
		}
		public static void SetValueField(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxFunnel_SetOption", dxTarget, "valueField", value);
		}
		public static void ClearSelection(ElementRef dxTarget)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxFunnel_clearSelection_0", dxTarget);
		}
		public static object GetAllItems(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxFunnel_getAllItems_1", dxTarget);
		}
		public static object GetDataSourceEx(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxFunnel_getDataSource_2", dxTarget);
		}
		public static void HideTooltip(ElementRef dxTarget)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxFunnel_hideTooltip_3", dxTarget);
		}
	}
	public class BaseGaugeInterop: BaseWidgetInterop
	{
		public static event EventHandler<JQueryEventArgs> TooltipHidden;
		public static event EventHandler<JQueryEventArgs> TooltipShown;
		public static void Init(ElementRef dxTarget, DevExpress.Viz.Gauges.BaseGaugeOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_BaseGauge_Init", dxTarget, json);
		}
		[JSInvokable("DevExpress.Viz.BaseGaugeInterop.OnTooltipHidden")]
		public static void OnTooltipHidden(string identifier)
		{
			TooltipHidden?.Invoke(null, new JQueryEventArgs(identifier));
		}
		[JSInvokable("DevExpress.Viz.BaseGaugeInterop.OnTooltipShown")]
		public static void OnTooltipShown(string identifier)
		{
			TooltipShown?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static object GetAnimation(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_BaseGauge_GetOption", dxTarget, "animation");
		}
		public static void SetAnimation(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_BaseGauge_SetOption", dxTarget, "animation", value);
		}
		public static string GetContainerBackgroundColor(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_BaseGauge_GetOption", dxTarget, "containerBackgroundColor");
		}
		public static void SetContainerBackgroundColor(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_BaseGauge_SetOption", dxTarget, "containerBackgroundColor", value);
		}
		public static object GetRangeContainer(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_BaseGauge_GetOption", dxTarget, "rangeContainer");
		}
		public static void SetRangeContainer(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_BaseGauge_SetOption", dxTarget, "rangeContainer", value);
		}
		public static object GetScale(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_BaseGauge_GetOption", dxTarget, "scale");
		}
		public static void SetScale(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_BaseGauge_SetOption", dxTarget, "scale", value);
		}
		public static object GetSubtitle(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_BaseGauge_GetOption", dxTarget, "subtitle");
		}
		public static void SetSubtitle(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_BaseGauge_SetOption", dxTarget, "subtitle", value);
		}
		public static object GetSubvalues(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_BaseGauge_GetOption", dxTarget, "subvalues");
		}
		public static void SetSubvalues(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_BaseGauge_SetOption", dxTarget, "subvalues", value);
		}
		public static new object GetTitle(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_BaseGauge_GetOption", dxTarget, "title");
		}
		public static new void SetTitle(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_BaseGauge_SetOption", dxTarget, "title", value);
		}
		public static new object GetTooltip(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_BaseGauge_GetOption", dxTarget, "tooltip");
		}
		public static new void SetTooltip(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_BaseGauge_SetOption", dxTarget, "tooltip", value);
		}
		public static float? GetValue(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<float?>("BlazorDevExtreme_BaseGauge_GetOption", dxTarget, "value");
		}
		public static void SetValue(ElementRef dxTarget, float? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_BaseGauge_SetOption", dxTarget, "value", value);
		}
		public static object SubvaluesEx(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_BaseGauge_subvalues_0", dxTarget);
		}
		public static void SubvaluesEx(ElementRef dxTarget, object subvalues)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_BaseGauge_subvalues_1", dxTarget, subvalues);
		}
		public static float ValueEx(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<float>("BlazorDevExtreme_BaseGauge_value_2", dxTarget);
		}
		public static void ValueEx(ElementRef dxTarget, float value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_BaseGauge_value_3", dxTarget, value);
		}
	}
	public class DxCircularGaugeInterop: BaseGaugeInterop
	{
		public static void Init(ElementRef dxTarget, DevExpress.Viz.Gauges.DxCircularGaugeOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxCircularGauge_Init", dxTarget, json);
		}
		public static object GetGeometry(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxCircularGauge_GetOption", dxTarget, "geometry");
		}
		public static void SetGeometry(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxCircularGauge_SetOption", dxTarget, "geometry", value);
		}
		public static new object GetRangeContainer(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxCircularGauge_GetOption", dxTarget, "rangeContainer");
		}
		public static new void SetRangeContainer(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxCircularGauge_SetOption", dxTarget, "rangeContainer", value);
		}
		public static new object GetScale(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxCircularGauge_GetOption", dxTarget, "scale");
		}
		public static new void SetScale(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxCircularGauge_SetOption", dxTarget, "scale", value);
		}
		public static object GetSubvalueIndicator(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxCircularGauge_GetOption", dxTarget, "subvalueIndicator");
		}
		public static void SetSubvalueIndicator(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxCircularGauge_SetOption", dxTarget, "subvalueIndicator", value);
		}
		public static object GetValueIndicator(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxCircularGauge_GetOption", dxTarget, "valueIndicator");
		}
		public static void SetValueIndicator(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxCircularGauge_SetOption", dxTarget, "valueIndicator", value);
		}
	}
	public class DxLinearGaugeInterop: BaseGaugeInterop
	{
		public static void Init(ElementRef dxTarget, DevExpress.Viz.Gauges.DxLinearGaugeOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxLinearGauge_Init", dxTarget, json);
		}
		public static object GetGeometry(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxLinearGauge_GetOption", dxTarget, "geometry");
		}
		public static void SetGeometry(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxLinearGauge_SetOption", dxTarget, "geometry", value);
		}
		public static new object GetRangeContainer(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxLinearGauge_GetOption", dxTarget, "rangeContainer");
		}
		public static new void SetRangeContainer(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxLinearGauge_SetOption", dxTarget, "rangeContainer", value);
		}
		public static new object GetScale(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxLinearGauge_GetOption", dxTarget, "scale");
		}
		public static new void SetScale(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxLinearGauge_SetOption", dxTarget, "scale", value);
		}
		public static object GetSubvalueIndicator(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxLinearGauge_GetOption", dxTarget, "subvalueIndicator");
		}
		public static void SetSubvalueIndicator(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxLinearGauge_SetOption", dxTarget, "subvalueIndicator", value);
		}
		public static object GetValueIndicator(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxLinearGauge_GetOption", dxTarget, "valueIndicator");
		}
		public static void SetValueIndicator(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxLinearGauge_SetOption", dxTarget, "valueIndicator", value);
		}
	}
	public class DxBarGaugeInterop: BaseWidgetInterop
	{
		public static event EventHandler<JQueryEventArgs> TooltipHidden;
		public static event EventHandler<JQueryEventArgs> TooltipShown;
		public static void Init(ElementRef dxTarget, DevExpress.Viz.Gauges.DxBarGaugeOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxBarGauge_Init", dxTarget, json);
		}
		[JSInvokable("DevExpress.Viz.DxBarGaugeInterop.OnTooltipHidden")]
		public static void OnTooltipHidden(string identifier)
		{
			TooltipHidden?.Invoke(null, new JQueryEventArgs(identifier));
		}
		[JSInvokable("DevExpress.Viz.DxBarGaugeInterop.OnTooltipShown")]
		public static void OnTooltipShown(string identifier)
		{
			TooltipShown?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static object GetAnimation(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxBarGauge_GetOption", dxTarget, "animation");
		}
		public static void SetAnimation(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxBarGauge_SetOption", dxTarget, "animation", value);
		}
		public static string GetBackgroundColor(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_DxBarGauge_GetOption", dxTarget, "backgroundColor");
		}
		public static void SetBackgroundColor(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxBarGauge_SetOption", dxTarget, "backgroundColor", value);
		}
		public static float? GetBarSpacing(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<float?>("BlazorDevExtreme_DxBarGauge_GetOption", dxTarget, "barSpacing");
		}
		public static void SetBarSpacing(ElementRef dxTarget, float? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxBarGauge_SetOption", dxTarget, "barSpacing", value);
		}
		public static float? GetBaseValue(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<float?>("BlazorDevExtreme_DxBarGauge_GetOption", dxTarget, "baseValue");
		}
		public static void SetBaseValue(ElementRef dxTarget, float? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxBarGauge_SetOption", dxTarget, "baseValue", value);
		}
		public static float? GetEndValue(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<float?>("BlazorDevExtreme_DxBarGauge_GetOption", dxTarget, "endValue");
		}
		public static void SetEndValue(ElementRef dxTarget, float? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxBarGauge_SetOption", dxTarget, "endValue", value);
		}
		public static object GetGeometry(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxBarGauge_GetOption", dxTarget, "geometry");
		}
		public static void SetGeometry(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxBarGauge_SetOption", dxTarget, "geometry", value);
		}
		public static object GetLabel(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxBarGauge_GetOption", dxTarget, "label");
		}
		public static void SetLabel(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxBarGauge_SetOption", dxTarget, "label", value);
		}
		public static object GetPalette(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxBarGauge_GetOption", dxTarget, "palette");
		}
		public static void SetPalette(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxBarGauge_SetOption", dxTarget, "palette", value);
		}
		public static string GetPaletteExtensionMode(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_DxBarGauge_GetOption", dxTarget, "paletteExtensionMode");
		}
		public static void SetPaletteExtensionMode(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxBarGauge_SetOption", dxTarget, "paletteExtensionMode", value);
		}
		public static float? GetRelativeInnerRadius(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<float?>("BlazorDevExtreme_DxBarGauge_GetOption", dxTarget, "relativeInnerRadius");
		}
		public static void SetRelativeInnerRadius(ElementRef dxTarget, float? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxBarGauge_SetOption", dxTarget, "relativeInnerRadius", value);
		}
		public static float? GetStartValue(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<float?>("BlazorDevExtreme_DxBarGauge_GetOption", dxTarget, "startValue");
		}
		public static void SetStartValue(ElementRef dxTarget, float? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxBarGauge_SetOption", dxTarget, "startValue", value);
		}
		public static object GetSubtitle(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxBarGauge_GetOption", dxTarget, "subtitle");
		}
		public static void SetSubtitle(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxBarGauge_SetOption", dxTarget, "subtitle", value);
		}
		public static new object GetTitle(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxBarGauge_GetOption", dxTarget, "title");
		}
		public static new void SetTitle(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxBarGauge_SetOption", dxTarget, "title", value);
		}
		public static new object GetTooltip(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxBarGauge_GetOption", dxTarget, "tooltip");
		}
		public static new void SetTooltip(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxBarGauge_SetOption", dxTarget, "tooltip", value);
		}
		public static object GetValues(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxBarGauge_GetOption", dxTarget, "values");
		}
		public static void SetValues(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxBarGauge_SetOption", dxTarget, "values", value);
		}
		public static object ValuesEx(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxBarGauge_values_0", dxTarget);
		}
		public static void ValuesEx(ElementRef dxTarget, object values)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxBarGauge_values_1", dxTarget, values);
		}
	}
	public class BaseSeriesObjectInterop
	{
		public static void ClearHover(ElementRef dxTarget)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_BaseSeriesObject_clearHover_0", dxTarget);
		}
		public static void ClearSelection(ElementRef dxTarget)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_BaseSeriesObject_clearSelection_1", dxTarget);
		}
		public static void DeselectPoint(ElementRef dxTarget, object point)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_BaseSeriesObject_deselectPoint_2", dxTarget, point);
		}
		public static object GetAllPoints(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_BaseSeriesObject_getAllPoints_3", dxTarget);
		}
		public static string GetColor(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_BaseSeriesObject_getColor_4", dxTarget);
		}
		public static object GetPointByPos(ElementRef dxTarget, float positionIndex)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_BaseSeriesObject_getPointByPos_5", dxTarget, positionIndex);
		}
		public static object GetPointsByArg(ElementRef dxTarget, object pointArg)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_BaseSeriesObject_getPointsByArg_6", dxTarget, pointArg);
		}
		public static object GetVisiblePoints(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_BaseSeriesObject_getVisiblePoints_7", dxTarget);
		}
		public static void Hide(ElementRef dxTarget)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_BaseSeriesObject_hide_8", dxTarget);
		}
		public static void Hover(ElementRef dxTarget)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_BaseSeriesObject_hover_9", dxTarget);
		}
		public static bool IsHovered(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool>("BlazorDevExtreme_BaseSeriesObject_isHovered_10", dxTarget);
		}
		public static bool IsSelected(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool>("BlazorDevExtreme_BaseSeriesObject_isSelected_11", dxTarget);
		}
		public static bool IsVisible(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool>("BlazorDevExtreme_BaseSeriesObject_isVisible_12", dxTarget);
		}
		public static void Select(ElementRef dxTarget)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_BaseSeriesObject_select_13", dxTarget);
		}
		public static void SelectPoint(ElementRef dxTarget, object point)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_BaseSeriesObject_selectPoint_14", dxTarget, point);
		}
		public static void Show(ElementRef dxTarget)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_BaseSeriesObject_show_15", dxTarget);
		}
	}
	public class BasePointObjectInterop
	{
		public static void ClearHover(ElementRef dxTarget)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_BasePointObject_clearHover_0", dxTarget);
		}
		public static void ClearSelection(ElementRef dxTarget)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_BasePointObject_clearSelection_1", dxTarget);
		}
		public static string GetColor(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_BasePointObject_getColor_2", dxTarget);
		}
		public static object GetLabel(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_BasePointObject_getLabel_3", dxTarget);
		}
		public static void HideTooltip(ElementRef dxTarget)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_BasePointObject_hideTooltip_4", dxTarget);
		}
		public static void Hover(ElementRef dxTarget)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_BasePointObject_hover_5", dxTarget);
		}
		public static bool IsHovered(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool>("BlazorDevExtreme_BasePointObject_isHovered_6", dxTarget);
		}
		public static bool IsSelected(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool>("BlazorDevExtreme_BasePointObject_isSelected_7", dxTarget);
		}
		public static void Select(ElementRef dxTarget)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_BasePointObject_select_8", dxTarget);
		}
		public static void ShowTooltip(ElementRef dxTarget)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_BasePointObject_showTooltip_9", dxTarget);
		}
	}
	public class BaseLabelObjectInterop
	{
		public static object GetBoundingRect(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_BaseLabelObject_getBoundingRect_0", dxTarget);
		}
		public static void Hide(ElementRef dxTarget)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_BaseLabelObject_hide_1", dxTarget);
		}
		public static void Hide(ElementRef dxTarget, bool holdInvisible)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_BaseLabelObject_hide_2", dxTarget, holdInvisible);
		}
		public static bool IsVisible(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool>("BlazorDevExtreme_BaseLabelObject_isVisible_3", dxTarget);
		}
		public static void Show(ElementRef dxTarget)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_BaseLabelObject_show_4", dxTarget);
		}
		public static void Show(ElementRef dxTarget, bool holdVisible)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_BaseLabelObject_show_5", dxTarget, holdVisible);
		}
	}
	public class ChartSeriesObjectInterop: BaseSeriesObjectInterop
	{
	}
	public class ChartPointObjectInterop: BasePointObjectInterop
	{
		public static object GetBoundingRect(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_ChartPointObject_getBoundingRect_0", dxTarget);
		}
	}
	public class DxFunnelItemInterop
	{
		public static string GetColor(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_DxFunnelItem_getColor_0", dxTarget);
		}
		public static void Hover(ElementRef dxTarget, bool state)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxFunnelItem_hover_1", dxTarget, state);
		}
		public static bool IsHovered(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool>("BlazorDevExtreme_DxFunnelItem_isHovered_2", dxTarget);
		}
		public static bool IsSelected(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool>("BlazorDevExtreme_DxFunnelItem_isSelected_3", dxTarget);
		}
		public static void Select(ElementRef dxTarget, bool state)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxFunnelItem_select_4", dxTarget, state);
		}
		public static void ShowTooltip(ElementRef dxTarget)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxFunnelItem_showTooltip_5", dxTarget);
		}
	}
	public class PiePointObjectInterop: BasePointObjectInterop
	{
		public static void Hide(ElementRef dxTarget)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_PiePointObject_hide_0", dxTarget);
		}
		public static void HideTooltip(ElementRef dxTarget)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_PiePointObject_hideTooltip_1", dxTarget);
		}
		public static bool IsVisible(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool>("BlazorDevExtreme_PiePointObject_isVisible_2", dxTarget);
		}
		public static void Show(ElementRef dxTarget)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_PiePointObject_show_3", dxTarget);
		}
		public static void ShowTooltip(ElementRef dxTarget)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_PiePointObject_showTooltip_4", dxTarget);
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
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxTreeMapNode_customize_0", dxTarget, options);
		}
		public static void DrillDown(ElementRef dxTarget)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxTreeMapNode_drillDown_1", dxTarget);
		}
		public static object GetAllChildren(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxTreeMapNode_getAllChildren_2", dxTarget);
		}
		public static object GetAllNodes(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxTreeMapNode_getAllNodes_3", dxTarget);
		}
		public static object GetChild(ElementRef dxTarget, float index)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxTreeMapNode_getChild_4", dxTarget, index);
		}
		public static float GetChildrenCount(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<float>("BlazorDevExtreme_DxTreeMapNode_getChildrenCount_5", dxTarget);
		}
		public static object GetParent(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxTreeMapNode_getParent_6", dxTarget);
		}
		public static bool IsActive(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool>("BlazorDevExtreme_DxTreeMapNode_isActive_7", dxTarget);
		}
		public static bool IsHovered(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool>("BlazorDevExtreme_DxTreeMapNode_isHovered_8", dxTarget);
		}
		public static bool IsLeaf(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool>("BlazorDevExtreme_DxTreeMapNode_isLeaf_9", dxTarget);
		}
		public static bool IsSelected(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool>("BlazorDevExtreme_DxTreeMapNode_isSelected_10", dxTarget);
		}
		public static string Label(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_DxTreeMapNode_label_11", dxTarget);
		}
		public static void Label(ElementRef dxTarget, string label)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxTreeMapNode_label_12", dxTarget, label);
		}
		public static void ResetCustomization(ElementRef dxTarget)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxTreeMapNode_resetCustomization_13", dxTarget);
		}
		public static void Select(ElementRef dxTarget, bool state)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxTreeMapNode_select_14", dxTarget, state);
		}
		public static void ShowTooltip(ElementRef dxTarget)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxTreeMapNode_showTooltip_15", dxTarget);
		}
		public static float ValueEx(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<float>("BlazorDevExtreme_DxTreeMapNode_value_16", dxTarget);
		}
	}
	public class MapLayerInterop
	{
		public static void ClearSelection(ElementRef dxTarget)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_MapLayer_clearSelection_0", dxTarget);
		}
		public static object GetDataSourceEx(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_MapLayer_getDataSource_1", dxTarget);
		}
		public static object GetElements(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_MapLayer_getElements_2", dxTarget);
		}
	}
	public class MapLayerElementInterop
	{
		public static void ApplySettings(ElementRef dxTarget, object settings)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_MapLayerElement_applySettings_0", dxTarget, settings);
		}
		public static object Attribute(ElementRef dxTarget, string name)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_MapLayerElement_attribute_1", dxTarget, name);
		}
		public static void Attribute(ElementRef dxTarget, string name, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_MapLayerElement_attribute_2", dxTarget, name, value);
		}
		public static object Coordinates(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_MapLayerElement_coordinates_3", dxTarget);
		}
		public static bool Selected(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool>("BlazorDevExtreme_MapLayerElement_selected_4", dxTarget);
		}
		public static void Selected(ElementRef dxTarget, bool state)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_MapLayerElement_selected_5", dxTarget, state);
		}
	}
	public class AreaObjectsInterop
	{
		public static void ApplySettings(ElementRef dxTarget, object settings)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_AreaObjects_applySettings_0", dxTarget, settings);
		}
		public static object Attribute(ElementRef dxTarget, string name)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_AreaObjects_attribute_1", dxTarget, name);
		}
		public static bool Selected(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool>("BlazorDevExtreme_AreaObjects_selected_2", dxTarget);
		}
		public static void Selected(ElementRef dxTarget, bool state)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_AreaObjects_selected_3", dxTarget, state);
		}
	}
	public class MarkerObjectsInterop
	{
		public static void ApplySettings(ElementRef dxTarget, object settings)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_MarkerObjects_applySettings_0", dxTarget, settings);
		}
		public static object Attribute(ElementRef dxTarget, string name)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_MarkerObjects_attribute_1", dxTarget, name);
		}
		public static object Coordinates(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_MarkerObjects_coordinates_2", dxTarget);
		}
		public static bool Selected(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool>("BlazorDevExtreme_MarkerObjects_selected_3", dxTarget);
		}
		public static void Selected(ElementRef dxTarget, bool state)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_MarkerObjects_selected_4", dxTarget, state);
		}
	}
	public class DxRangeSelectorInterop: BaseWidgetInterop
	{
		public static event EventHandler<JQueryEventArgs> SelectedRangeChanged;
		public static event EventHandler<JQueryEventArgs> ValueChanged;
		public static void Init(ElementRef dxTarget, DevExpress.Viz.RangeSelector.DxRangeSelectorOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxRangeSelector_Init", dxTarget, json);
		}
		[JSInvokable("DevExpress.Viz.DxRangeSelectorInterop.OnSelectedRangeChanged")]
		public static void OnSelectedRangeChanged(string identifier)
		{
			SelectedRangeChanged?.Invoke(null, new JQueryEventArgs(identifier));
		}
		[JSInvokable("DevExpress.Viz.DxRangeSelectorInterop.OnValueChanged")]
		public static void OnValueChanged(string identifier)
		{
			ValueChanged?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static object GetBackground(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxRangeSelector_GetOption", dxTarget, "background");
		}
		public static void SetBackground(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxRangeSelector_SetOption", dxTarget, "background", value);
		}
		public static object GetBehavior(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxRangeSelector_GetOption", dxTarget, "behavior");
		}
		public static void SetBehavior(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxRangeSelector_SetOption", dxTarget, "behavior", value);
		}
		public static object GetChart(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxRangeSelector_GetOption", dxTarget, "chart");
		}
		public static void SetChart(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxRangeSelector_SetOption", dxTarget, "chart", value);
		}
		public static string GetContainerBackgroundColor(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_DxRangeSelector_GetOption", dxTarget, "containerBackgroundColor");
		}
		public static void SetContainerBackgroundColor(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxRangeSelector_SetOption", dxTarget, "containerBackgroundColor", value);
		}
		public static object GetDataSource(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxRangeSelector_GetOption", dxTarget, "dataSource");
		}
		public static void SetDataSource(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxRangeSelector_SetOption", dxTarget, "dataSource", value);
		}
		public static string GetDataSourceField(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_DxRangeSelector_GetOption", dxTarget, "dataSourceField");
		}
		public static void SetDataSourceField(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxRangeSelector_SetOption", dxTarget, "dataSourceField", value);
		}
		public static object GetIndent(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxRangeSelector_GetOption", dxTarget, "indent");
		}
		public static void SetIndent(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxRangeSelector_SetOption", dxTarget, "indent", value);
		}
		public static object GetScale(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxRangeSelector_GetOption", dxTarget, "scale");
		}
		public static void SetScale(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxRangeSelector_SetOption", dxTarget, "scale", value);
		}
		public static object GetSelectedRange(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxRangeSelector_GetOption", dxTarget, "selectedRange");
		}
		public static void SetSelectedRange(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxRangeSelector_SetOption", dxTarget, "selectedRange", value);
		}
		public static string GetSelectedRangeColor(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_DxRangeSelector_GetOption", dxTarget, "selectedRangeColor");
		}
		public static void SetSelectedRangeColor(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxRangeSelector_SetOption", dxTarget, "selectedRangeColor", value);
		}
		public static object GetShutter(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxRangeSelector_GetOption", dxTarget, "shutter");
		}
		public static void SetShutter(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxRangeSelector_SetOption", dxTarget, "shutter", value);
		}
		public static object GetSliderHandle(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxRangeSelector_GetOption", dxTarget, "sliderHandle");
		}
		public static void SetSliderHandle(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxRangeSelector_SetOption", dxTarget, "sliderHandle", value);
		}
		public static object GetSliderMarker(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxRangeSelector_GetOption", dxTarget, "sliderMarker");
		}
		public static void SetSliderMarker(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxRangeSelector_SetOption", dxTarget, "sliderMarker", value);
		}
		public static object GetValue(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxRangeSelector_GetOption", dxTarget, "value");
		}
		public static void SetValue(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxRangeSelector_SetOption", dxTarget, "value", value);
		}
		public static object GetDataSourceEx(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxRangeSelector_getDataSource_0", dxTarget);
		}
		public static object GetSelectedRangeEx(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxRangeSelector_getSelectedRange_1", dxTarget);
		}
		public static object GetValueEx(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxRangeSelector_getValue_2", dxTarget);
		}
		public static void Render(ElementRef dxTarget)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxRangeSelector_render_3", dxTarget);
		}
		public static void Render(ElementRef dxTarget, bool skipChartAnimation)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxRangeSelector_render_4", dxTarget, skipChartAnimation);
		}
		public static void SetSelectedRangeEx(ElementRef dxTarget, object selectedRange)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxRangeSelector_setSelectedRange_5", dxTarget, selectedRange);
		}
		public static void SetValueEx(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxRangeSelector_setValue_6", dxTarget, value);
		}
	}
	public class BaseSparklineInterop: BaseWidgetInterop
	{
		public static event EventHandler<JQueryEventArgs> TooltipHidden;
		public static event EventHandler<JQueryEventArgs> TooltipShown;
		public static void Init(ElementRef dxTarget, DevExpress.Viz.Sparklines.BaseSparklineOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_BaseSparkline_Init", dxTarget, json);
		}
		[JSInvokable("DevExpress.Viz.BaseSparklineInterop.OnTooltipHidden")]
		public static void OnTooltipHidden(string identifier)
		{
			TooltipHidden?.Invoke(null, new JQueryEventArgs(identifier));
		}
		[JSInvokable("DevExpress.Viz.BaseSparklineInterop.OnTooltipShown")]
		public static void OnTooltipShown(string identifier)
		{
			TooltipShown?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static new object GetTooltip(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_BaseSparkline_GetOption", dxTarget, "tooltip");
		}
		public static new void SetTooltip(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_BaseSparkline_SetOption", dxTarget, "tooltip", value);
		}
	}
	public class DxSparklineInterop: BaseSparklineInterop
	{
		public static void Init(ElementRef dxTarget, DevExpress.Viz.Sparklines.DxSparklineOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxSparkline_Init", dxTarget, json);
		}
		public static string GetArgumentField(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_DxSparkline_GetOption", dxTarget, "argumentField");
		}
		public static void SetArgumentField(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxSparkline_SetOption", dxTarget, "argumentField", value);
		}
		public static string GetBarNegativeColor(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_DxSparkline_GetOption", dxTarget, "barNegativeColor");
		}
		public static void SetBarNegativeColor(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxSparkline_SetOption", dxTarget, "barNegativeColor", value);
		}
		public static string GetBarPositiveColor(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_DxSparkline_GetOption", dxTarget, "barPositiveColor");
		}
		public static void SetBarPositiveColor(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxSparkline_SetOption", dxTarget, "barPositiveColor", value);
		}
		public static object GetDataSource(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxSparkline_GetOption", dxTarget, "dataSource");
		}
		public static void SetDataSource(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxSparkline_SetOption", dxTarget, "dataSource", value);
		}
		public static string GetFirstLastColor(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_DxSparkline_GetOption", dxTarget, "firstLastColor");
		}
		public static void SetFirstLastColor(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxSparkline_SetOption", dxTarget, "firstLastColor", value);
		}
		public static bool? GetIgnoreEmptyPoints(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_DxSparkline_GetOption", dxTarget, "ignoreEmptyPoints");
		}
		public static void SetIgnoreEmptyPoints(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxSparkline_SetOption", dxTarget, "ignoreEmptyPoints", value);
		}
		public static string GetLineColor(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_DxSparkline_GetOption", dxTarget, "lineColor");
		}
		public static void SetLineColor(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxSparkline_SetOption", dxTarget, "lineColor", value);
		}
		public static float? GetLineWidth(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<float?>("BlazorDevExtreme_DxSparkline_GetOption", dxTarget, "lineWidth");
		}
		public static void SetLineWidth(ElementRef dxTarget, float? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxSparkline_SetOption", dxTarget, "lineWidth", value);
		}
		public static string GetLossColor(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_DxSparkline_GetOption", dxTarget, "lossColor");
		}
		public static void SetLossColor(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxSparkline_SetOption", dxTarget, "lossColor", value);
		}
		public static string GetMaxColor(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_DxSparkline_GetOption", dxTarget, "maxColor");
		}
		public static void SetMaxColor(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxSparkline_SetOption", dxTarget, "maxColor", value);
		}
		public static float? GetMaxValue(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<float?>("BlazorDevExtreme_DxSparkline_GetOption", dxTarget, "maxValue");
		}
		public static void SetMaxValue(ElementRef dxTarget, float? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxSparkline_SetOption", dxTarget, "maxValue", value);
		}
		public static string GetMinColor(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_DxSparkline_GetOption", dxTarget, "minColor");
		}
		public static void SetMinColor(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxSparkline_SetOption", dxTarget, "minColor", value);
		}
		public static float? GetMinValue(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<float?>("BlazorDevExtreme_DxSparkline_GetOption", dxTarget, "minValue");
		}
		public static void SetMinValue(ElementRef dxTarget, float? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxSparkline_SetOption", dxTarget, "minValue", value);
		}
		public static string GetPointColor(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_DxSparkline_GetOption", dxTarget, "pointColor");
		}
		public static void SetPointColor(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxSparkline_SetOption", dxTarget, "pointColor", value);
		}
		public static float? GetPointSize(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<float?>("BlazorDevExtreme_DxSparkline_GetOption", dxTarget, "pointSize");
		}
		public static void SetPointSize(ElementRef dxTarget, float? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxSparkline_SetOption", dxTarget, "pointSize", value);
		}
		public static string GetPointSymbol(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_DxSparkline_GetOption", dxTarget, "pointSymbol");
		}
		public static void SetPointSymbol(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxSparkline_SetOption", dxTarget, "pointSymbol", value);
		}
		public static bool? GetShowFirstLast(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_DxSparkline_GetOption", dxTarget, "showFirstLast");
		}
		public static void SetShowFirstLast(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxSparkline_SetOption", dxTarget, "showFirstLast", value);
		}
		public static bool? GetShowMinMax(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_DxSparkline_GetOption", dxTarget, "showMinMax");
		}
		public static void SetShowMinMax(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxSparkline_SetOption", dxTarget, "showMinMax", value);
		}
		public static string GetType(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_DxSparkline_GetOption", dxTarget, "type");
		}
		public static void SetType(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxSparkline_SetOption", dxTarget, "type", value);
		}
		public static string GetValueField(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_DxSparkline_GetOption", dxTarget, "valueField");
		}
		public static void SetValueField(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxSparkline_SetOption", dxTarget, "valueField", value);
		}
		public static string GetWinColor(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_DxSparkline_GetOption", dxTarget, "winColor");
		}
		public static void SetWinColor(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxSparkline_SetOption", dxTarget, "winColor", value);
		}
		public static float? GetWinlossThreshold(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<float?>("BlazorDevExtreme_DxSparkline_GetOption", dxTarget, "winlossThreshold");
		}
		public static void SetWinlossThreshold(ElementRef dxTarget, float? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxSparkline_SetOption", dxTarget, "winlossThreshold", value);
		}
		public static object GetDataSourceEx(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxSparkline_getDataSource_0", dxTarget);
		}
	}
	public class DxBulletInterop: BaseSparklineInterop
	{
		public static void Init(ElementRef dxTarget, DevExpress.Viz.Sparklines.DxBulletOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxBullet_Init", dxTarget, json);
		}
		public static string GetColor(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_DxBullet_GetOption", dxTarget, "color");
		}
		public static void SetColor(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxBullet_SetOption", dxTarget, "color", value);
		}
		public static float? GetEndScaleValue(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<float?>("BlazorDevExtreme_DxBullet_GetOption", dxTarget, "endScaleValue");
		}
		public static void SetEndScaleValue(ElementRef dxTarget, float? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxBullet_SetOption", dxTarget, "endScaleValue", value);
		}
		public static bool? GetShowTarget(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_DxBullet_GetOption", dxTarget, "showTarget");
		}
		public static void SetShowTarget(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxBullet_SetOption", dxTarget, "showTarget", value);
		}
		public static bool? GetShowZeroLevel(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_DxBullet_GetOption", dxTarget, "showZeroLevel");
		}
		public static void SetShowZeroLevel(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxBullet_SetOption", dxTarget, "showZeroLevel", value);
		}
		public static float? GetStartScaleValue(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<float?>("BlazorDevExtreme_DxBullet_GetOption", dxTarget, "startScaleValue");
		}
		public static void SetStartScaleValue(ElementRef dxTarget, float? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxBullet_SetOption", dxTarget, "startScaleValue", value);
		}
		public static float? GetTarget(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<float?>("BlazorDevExtreme_DxBullet_GetOption", dxTarget, "target");
		}
		public static void SetTarget(ElementRef dxTarget, float? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxBullet_SetOption", dxTarget, "target", value);
		}
		public static string GetTargetColor(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_DxBullet_GetOption", dxTarget, "targetColor");
		}
		public static void SetTargetColor(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxBullet_SetOption", dxTarget, "targetColor", value);
		}
		public static float? GetTargetWidth(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<float?>("BlazorDevExtreme_DxBullet_GetOption", dxTarget, "targetWidth");
		}
		public static void SetTargetWidth(ElementRef dxTarget, float? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxBullet_SetOption", dxTarget, "targetWidth", value);
		}
		public static float? GetValue(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<float?>("BlazorDevExtreme_DxBullet_GetOption", dxTarget, "value");
		}
		public static void SetValue(ElementRef dxTarget, float? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxBullet_SetOption", dxTarget, "value", value);
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
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxTreeMap_Init", dxTarget, json);
		}
		[JSInvokable("DevExpress.Viz.DxTreeMapInterop.OnClick")]
		public static void OnClick(string identifier)
		{
			Click?.Invoke(null, new JQueryEventArgs(identifier));
		}
		[JSInvokable("DevExpress.Viz.DxTreeMapInterop.OnDrill")]
		public static void OnDrill(string identifier)
		{
			Drill?.Invoke(null, new JQueryEventArgs(identifier));
		}
		[JSInvokable("DevExpress.Viz.DxTreeMapInterop.OnHoverChanged")]
		public static void OnHoverChanged(string identifier)
		{
			HoverChanged?.Invoke(null, new JQueryEventArgs(identifier));
		}
		[JSInvokable("DevExpress.Viz.DxTreeMapInterop.OnNodesInitialized")]
		public static void OnNodesInitialized(string identifier)
		{
			NodesInitialized?.Invoke(null, new JQueryEventArgs(identifier));
		}
		[JSInvokable("DevExpress.Viz.DxTreeMapInterop.OnNodesRendering")]
		public static void OnNodesRendering(string identifier)
		{
			NodesRendering?.Invoke(null, new JQueryEventArgs(identifier));
		}
		[JSInvokable("DevExpress.Viz.DxTreeMapInterop.OnSelectionChanged")]
		public static void OnSelectionChanged(string identifier)
		{
			SelectionChanged?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static string GetChildrenField(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_DxTreeMap_GetOption", dxTarget, "childrenField");
		}
		public static void SetChildrenField(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxTreeMap_SetOption", dxTarget, "childrenField", value);
		}
		public static string GetColorField(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_DxTreeMap_GetOption", dxTarget, "colorField");
		}
		public static void SetColorField(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxTreeMap_SetOption", dxTarget, "colorField", value);
		}
		public static object GetColorizer(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxTreeMap_GetOption", dxTarget, "colorizer");
		}
		public static void SetColorizer(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxTreeMap_SetOption", dxTarget, "colorizer", value);
		}
		public static object GetDataSource(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxTreeMap_GetOption", dxTarget, "dataSource");
		}
		public static void SetDataSource(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxTreeMap_SetOption", dxTarget, "dataSource", value);
		}
		public static object GetGroup(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxTreeMap_GetOption", dxTarget, "group");
		}
		public static void SetGroup(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxTreeMap_SetOption", dxTarget, "group", value);
		}
		public static bool? GetHoverEnabled(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_DxTreeMap_GetOption", dxTarget, "hoverEnabled");
		}
		public static void SetHoverEnabled(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxTreeMap_SetOption", dxTarget, "hoverEnabled", value);
		}
		public static string GetIdField(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_DxTreeMap_GetOption", dxTarget, "idField");
		}
		public static void SetIdField(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxTreeMap_SetOption", dxTarget, "idField", value);
		}
		public static bool? GetInteractWithGroup(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_DxTreeMap_GetOption", dxTarget, "interactWithGroup");
		}
		public static void SetInteractWithGroup(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxTreeMap_SetOption", dxTarget, "interactWithGroup", value);
		}
		public static string GetLabelField(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_DxTreeMap_GetOption", dxTarget, "labelField");
		}
		public static void SetLabelField(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxTreeMap_SetOption", dxTarget, "labelField", value);
		}
		public static object GetLayoutAlgorithm(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxTreeMap_GetOption", dxTarget, "layoutAlgorithm");
		}
		public static void SetLayoutAlgorithm(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxTreeMap_SetOption", dxTarget, "layoutAlgorithm", value);
		}
		public static string GetLayoutDirection(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_DxTreeMap_GetOption", dxTarget, "layoutDirection");
		}
		public static void SetLayoutDirection(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxTreeMap_SetOption", dxTarget, "layoutDirection", value);
		}
		public static float? GetMaxDepth(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<float?>("BlazorDevExtreme_DxTreeMap_GetOption", dxTarget, "maxDepth");
		}
		public static void SetMaxDepth(ElementRef dxTarget, float? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxTreeMap_SetOption", dxTarget, "maxDepth", value);
		}
		public static string GetParentField(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_DxTreeMap_GetOption", dxTarget, "parentField");
		}
		public static void SetParentField(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxTreeMap_SetOption", dxTarget, "parentField", value);
		}
		public static string GetResolveLabelOverflow(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_DxTreeMap_GetOption", dxTarget, "resolveLabelOverflow");
		}
		public static void SetResolveLabelOverflow(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxTreeMap_SetOption", dxTarget, "resolveLabelOverflow", value);
		}
		public static string GetSelectionMode(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_DxTreeMap_GetOption", dxTarget, "selectionMode");
		}
		public static void SetSelectionMode(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxTreeMap_SetOption", dxTarget, "selectionMode", value);
		}
		public static object GetTile(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxTreeMap_GetOption", dxTarget, "tile");
		}
		public static void SetTile(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxTreeMap_SetOption", dxTarget, "tile", value);
		}
		public static new object GetTooltip(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxTreeMap_GetOption", dxTarget, "tooltip");
		}
		public static new void SetTooltip(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxTreeMap_SetOption", dxTarget, "tooltip", value);
		}
		public static string GetValueField(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("BlazorDevExtreme_DxTreeMap_GetOption", dxTarget, "valueField");
		}
		public static void SetValueField(ElementRef dxTarget, string value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxTreeMap_SetOption", dxTarget, "valueField", value);
		}
		public static void ClearSelection(ElementRef dxTarget)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxTreeMap_clearSelection_0", dxTarget);
		}
		public static void DrillUp(ElementRef dxTarget)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxTreeMap_drillUp_1", dxTarget);
		}
		public static object GetCurrentNode(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxTreeMap_getCurrentNode_2", dxTarget);
		}
		public static object GetDataSourceEx(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxTreeMap_getDataSource_3", dxTarget);
		}
		public static object GetRootNode(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxTreeMap_getRootNode_4", dxTarget);
		}
		public static void HideTooltip(ElementRef dxTarget)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxTreeMap_hideTooltip_5", dxTarget);
		}
		public static void ResetDrillDown(ElementRef dxTarget)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxTreeMap_resetDrillDown_6", dxTarget);
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
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxVectorMap_Init", dxTarget, json);
		}
		[JSInvokable("DevExpress.Viz.DxVectorMapInterop.OnAreaClick")]
		public static void OnAreaClick(string identifier)
		{
			AreaClick?.Invoke(null, new JQueryEventArgs(identifier));
		}
		[JSInvokable("DevExpress.Viz.DxVectorMapInterop.OnAreaSelectionChanged")]
		public static void OnAreaSelectionChanged(string identifier)
		{
			AreaSelectionChanged?.Invoke(null, new JQueryEventArgs(identifier));
		}
		[JSInvokable("DevExpress.Viz.DxVectorMapInterop.OnCenterChanged")]
		public static void OnCenterChanged(string identifier)
		{
			CenterChanged?.Invoke(null, new JQueryEventArgs(identifier));
		}
		[JSInvokable("DevExpress.Viz.DxVectorMapInterop.OnClick")]
		public static void OnClick(string identifier)
		{
			Click?.Invoke(null, new JQueryEventArgs(identifier));
		}
		[JSInvokable("DevExpress.Viz.DxVectorMapInterop.OnMarkerClick")]
		public static void OnMarkerClick(string identifier)
		{
			MarkerClick?.Invoke(null, new JQueryEventArgs(identifier));
		}
		[JSInvokable("DevExpress.Viz.DxVectorMapInterop.OnMarkerSelectionChanged")]
		public static void OnMarkerSelectionChanged(string identifier)
		{
			MarkerSelectionChanged?.Invoke(null, new JQueryEventArgs(identifier));
		}
		[JSInvokable("DevExpress.Viz.DxVectorMapInterop.OnSelectionChanged")]
		public static void OnSelectionChanged(string identifier)
		{
			SelectionChanged?.Invoke(null, new JQueryEventArgs(identifier));
		}
		[JSInvokable("DevExpress.Viz.DxVectorMapInterop.OnTooltipHidden")]
		public static void OnTooltipHidden(string identifier)
		{
			TooltipHidden?.Invoke(null, new JQueryEventArgs(identifier));
		}
		[JSInvokable("DevExpress.Viz.DxVectorMapInterop.OnTooltipShown")]
		public static void OnTooltipShown(string identifier)
		{
			TooltipShown?.Invoke(null, new JQueryEventArgs(identifier));
		}
		[JSInvokable("DevExpress.Viz.DxVectorMapInterop.OnZoomFactorChanged")]
		public static void OnZoomFactorChanged(string identifier)
		{
			ZoomFactorChanged?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static object GetAreaSettings(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxVectorMap_GetOption", dxTarget, "areaSettings");
		}
		public static void SetAreaSettings(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxVectorMap_SetOption", dxTarget, "areaSettings", value);
		}
		public static object GetBackground(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxVectorMap_GetOption", dxTarget, "background");
		}
		public static void SetBackground(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxVectorMap_SetOption", dxTarget, "background", value);
		}
		public static object GetBounds(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxVectorMap_GetOption", dxTarget, "bounds");
		}
		public static void SetBounds(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxVectorMap_SetOption", dxTarget, "bounds", value);
		}
		public static object GetCenter(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxVectorMap_GetOption", dxTarget, "center");
		}
		public static void SetCenter(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxVectorMap_SetOption", dxTarget, "center", value);
		}
		public static object GetControlBar(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxVectorMap_GetOption", dxTarget, "controlBar");
		}
		public static void SetControlBar(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxVectorMap_SetOption", dxTarget, "controlBar", value);
		}
		public static object GetLayers(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxVectorMap_GetOption", dxTarget, "layers");
		}
		public static void SetLayers(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxVectorMap_SetOption", dxTarget, "layers", value);
		}
		public static object GetLegends(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxVectorMap_GetOption", dxTarget, "legends");
		}
		public static void SetLegends(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxVectorMap_SetOption", dxTarget, "legends", value);
		}
		public static object GetMapData(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxVectorMap_GetOption", dxTarget, "mapData");
		}
		public static void SetMapData(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxVectorMap_SetOption", dxTarget, "mapData", value);
		}
		public static object GetMarkers(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxVectorMap_GetOption", dxTarget, "markers");
		}
		public static void SetMarkers(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxVectorMap_SetOption", dxTarget, "markers", value);
		}
		public static object GetMarkerSettings(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxVectorMap_GetOption", dxTarget, "markerSettings");
		}
		public static void SetMarkerSettings(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxVectorMap_SetOption", dxTarget, "markerSettings", value);
		}
		public static float? GetMaxZoomFactor(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<float?>("BlazorDevExtreme_DxVectorMap_GetOption", dxTarget, "maxZoomFactor");
		}
		public static void SetMaxZoomFactor(ElementRef dxTarget, float? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxVectorMap_SetOption", dxTarget, "maxZoomFactor", value);
		}
		public static bool? GetPanningEnabled(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_DxVectorMap_GetOption", dxTarget, "panningEnabled");
		}
		public static void SetPanningEnabled(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxVectorMap_SetOption", dxTarget, "panningEnabled", value);
		}
		public static object GetProjection(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxVectorMap_GetOption", dxTarget, "projection");
		}
		public static void SetProjection(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxVectorMap_SetOption", dxTarget, "projection", value);
		}
		public static new object GetTooltip(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxVectorMap_GetOption", dxTarget, "tooltip");
		}
		public static new void SetTooltip(ElementRef dxTarget, object value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxVectorMap_SetOption", dxTarget, "tooltip", value);
		}
		public static bool? GetTouchEnabled(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_DxVectorMap_GetOption", dxTarget, "touchEnabled");
		}
		public static void SetTouchEnabled(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxVectorMap_SetOption", dxTarget, "touchEnabled", value);
		}
		public static bool? GetWheelEnabled(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_DxVectorMap_GetOption", dxTarget, "wheelEnabled");
		}
		public static void SetWheelEnabled(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxVectorMap_SetOption", dxTarget, "wheelEnabled", value);
		}
		public static float? GetZoomFactor(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<float?>("BlazorDevExtreme_DxVectorMap_GetOption", dxTarget, "zoomFactor");
		}
		public static void SetZoomFactor(ElementRef dxTarget, float? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxVectorMap_SetOption", dxTarget, "zoomFactor", value);
		}
		public static bool? GetZoomingEnabled(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<bool?>("BlazorDevExtreme_DxVectorMap_GetOption", dxTarget, "zoomingEnabled");
		}
		public static void SetZoomingEnabled(ElementRef dxTarget, bool? value)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxVectorMap_SetOption", dxTarget, "zoomingEnabled", value);
		}
		public static object CenterEx(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxVectorMap_center_0", dxTarget);
		}
		public static void CenterEx(ElementRef dxTarget, object centerCoordinates)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxVectorMap_center_1", dxTarget, centerCoordinates);
		}
		public static void ClearAreaSelection(ElementRef dxTarget)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxVectorMap_clearAreaSelection_2", dxTarget);
		}
		public static void ClearMarkerSelection(ElementRef dxTarget)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxVectorMap_clearMarkerSelection_3", dxTarget);
		}
		public static void ClearSelection(ElementRef dxTarget)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxVectorMap_clearSelection_4", dxTarget);
		}
		public static object ConvertCoordinates(ElementRef dxTarget, float x, float y)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxVectorMap_convertCoordinates_5", dxTarget, x, y);
		}
		public static object GetAreas(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxVectorMap_getAreas_6", dxTarget);
		}
		public static object GetLayerByIndex(ElementRef dxTarget, float index)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxVectorMap_getLayerByIndex_7", dxTarget, index);
		}
		public static object GetLayerByName(ElementRef dxTarget, string name)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxVectorMap_getLayerByName_8", dxTarget, name);
		}
		public static object GetLayersEx(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxVectorMap_getLayers_9", dxTarget);
		}
		public static object GetMarkersEx(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxVectorMap_getMarkers_10", dxTarget);
		}
		public static object Viewport(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxVectorMap_viewport_11", dxTarget);
		}
		public static void Viewport(ElementRef dxTarget, object viewportCoordinates)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxVectorMap_viewport_12", dxTarget, viewportCoordinates);
		}
		public static float ZoomFactorEx(ElementRef dxTarget)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<float>("BlazorDevExtreme_DxVectorMap_zoomFactor_13", dxTarget);
		}
		public static void ZoomFactorEx(ElementRef dxTarget, float zoomFactor)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_DxVectorMap_zoomFactor_14", dxTarget, zoomFactor);
		}
	}
	public class CoreInterop
	{
		public static void CurrentPalette(string paletteName)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_Core_currentPalette_0", paletteName);
		}
		public static void CurrentTheme(string platform, string colorScheme)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_Core_currentTheme_1", platform, colorScheme);
		}
		public static void CurrentTheme(string theme)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_Core_currentTheme_2", theme);
		}
		public static object GetPalette(string paletteName)
		{
			return ((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_Core_getPalette_3", paletteName);
		}
		public static void RegisterPalette(string paletteName, object palette)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_Core_registerPalette_4", paletteName, palette);
		}
		public static void RegisterTheme(object customTheme, string baseTheme)
		{
			((IJSInProcessRuntime)JSRuntime.Current).Invoke<object>("BlazorDevExtreme_Core_registerTheme_5", customTheme, baseTheme);
		}
	}
}
