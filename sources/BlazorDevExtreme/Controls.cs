using System;
using System.Threading.Tasks;
using Microsoft.JSInterop;
using Microsoft.AspNetCore.Blazor;
using BlazorDevExtreme;

namespace DevExpress
{
	public class DataHelperMixinInterop
	{
		public static Task<object> GetDataSourceEx(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DataHelperMixin_getDataSource_0", dxTarget);
		}
	}
	public class DxEventInterop
	{
		public static Task<bool> IsDefaultPrevented(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool>("BlazorDevExtreme_DxEvent_isDefaultPrevented_0", dxTarget);
		}
		public static Task<bool> IsImmediatePropagationStopped(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool>("BlazorDevExtreme_DxEvent_isImmediatePropagationStopped_1", dxTarget);
		}
		public static Task<bool> IsPropagationStopped(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool>("BlazorDevExtreme_DxEvent_isPropagationStopped_2", dxTarget);
		}
		public static Task PreventDefault(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxEvent_preventDefault_3", dxTarget);
		}
		public static Task StopImmediatePropagation(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxEvent_stopImmediatePropagation_4", dxTarget);
		}
		public static Task StopPropagation(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxEvent_stopPropagation_5", dxTarget);
		}
	}
	public class LocalizationInterop
	{
		public static Task<string> FormatDate(object value, object format)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_Localization_formatDate_0", value, format);
		}
		public static Task<string> FormatMessage(string key, object value)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_Localization_formatMessage_1", key, value);
		}
		public static Task<string> FormatNumber(float value, object format)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_Localization_formatNumber_2", value, format);
		}
		public static Task LoadMessages(object messages)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Localization_loadMessages_3", messages);
		}
		public static Task<string> Locale()
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_Localization_locale_4");
		}
		public static Task Locale(string locale)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Localization_locale_5", locale);
		}
		public static Task<object> ParseDate(string text, object format)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Localization_parseDate_6", text, format);
		}
		public static Task<float> ParseNumber(string text, object format)
		{
			return JSRuntime.Current.InvokeAsync<float>("BlazorDevExtreme_Localization_parseNumber_7", text, format);
		}
	}
	public class AnimationPresetsInterop
	{
		public static Task ApplyChanges(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_AnimationPresets_applyChanges_0", dxTarget);
		}
		public static Task Clear(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_AnimationPresets_clear_1", dxTarget);
		}
		public static Task Clear(ElementRef dxTarget, string name)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_AnimationPresets_clear_2", dxTarget, name);
		}
		public static Task<object> GetPreset(ElementRef dxTarget, string name)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_AnimationPresets_getPreset_3", dxTarget, name);
		}
		public static Task RegisterDefaultPresets(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_AnimationPresets_registerDefaultPresets_4", dxTarget);
		}
		public static Task RegisterPreset(ElementRef dxTarget, string name, object config)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_AnimationPresets_registerPreset_5", dxTarget, name, config);
		}
		public static Task ResetToDefaults(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_AnimationPresets_resetToDefaults_6", dxTarget);
		}
	}
	public class TransitionExecutorInterop
	{
		public static Task Enter(ElementRef dxTarget, object elements, object animation)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_TransitionExecutor_enter_0", dxTarget, elements, animation);
		}
		public static Task Leave(ElementRef dxTarget, object elements, object animation)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_TransitionExecutor_leave_1", dxTarget, elements, animation);
		}
		public static Task Reset(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_TransitionExecutor_reset_2", dxTarget);
		}
		public static Task<object> Start(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_TransitionExecutor_start_3", dxTarget);
		}
		public static Task Stop(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_TransitionExecutor_stop_4", dxTarget);
		}
	}
	public class ComponentInterop
	{
		public static event EventHandler<JQueryEventArgs> Disposing;
		public static event EventHandler<JQueryEventArgs> Initialized;
		public static event EventHandler<JQueryEventArgs> OptionChanged;
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
		public static Task BeginUpdate(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Component_beginUpdate_0", dxTarget);
		}
		public static Task EndUpdate(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Component_endUpdate_1", dxTarget);
		}
		public static Task<object> Instance(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Component_instance_2", dxTarget);
		}
		public static Task<object> Off(ElementRef dxTarget, string eventName)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Component_off_3", dxTarget, eventName);
		}
		public static Task<object> Off(ElementRef dxTarget, string eventName, object eventHandler)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Component_off_4", dxTarget, eventName, eventHandler);
		}
		public static Task<object> On(ElementRef dxTarget, string eventName, object eventHandler)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Component_on_5", dxTarget, eventName, eventHandler);
		}
		public static Task<object> On(ElementRef dxTarget, object events)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Component_on_6", dxTarget, events);
		}
		public static Task<object> Option(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Component_option_7", dxTarget);
		}
		public static Task<object> Option(ElementRef dxTarget, string optionName)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Component_option_8", dxTarget, optionName);
		}
		public static Task Option(ElementRef dxTarget, string optionName, object optionValue)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Component_option_9", dxTarget, optionName, optionValue);
		}
		public static Task Option(ElementRef dxTarget, object options)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Component_option_10", dxTarget, options);
		}
	}
	public class DevicesObjectInterop
	{
		public static Task<object> Current(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DevicesObject_current_0", dxTarget);
		}
		public static Task Current(ElementRef dxTarget, object deviceName)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DevicesObject_current_1", dxTarget, deviceName);
		}
		public static Task<object> Off(ElementRef dxTarget, string eventName)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DevicesObject_off_2", dxTarget, eventName);
		}
		public static Task<object> Off(ElementRef dxTarget, string eventName, object eventHandler)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DevicesObject_off_3", dxTarget, eventName, eventHandler);
		}
		public static Task<object> On(ElementRef dxTarget, string eventName, object eventHandler)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DevicesObject_on_4", dxTarget, eventName, eventHandler);
		}
		public static Task<object> On(ElementRef dxTarget, object events)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DevicesObject_on_5", dxTarget, events);
		}
		public static Task<string> Orientation(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DevicesObject_orientation_6", dxTarget);
		}
		public static Task<object> Real(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DevicesObject_real_7", dxTarget);
		}
	}
	public class DOMComponentInterop: ComponentInterop
	{
		public static Task<object> GetBindingOptionsOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DOMComponent_GetOption", dxTarget, "bindingOptions");
		}
		public static Task SetBindingOptionsOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DOMComponent_SetOption", dxTarget, "bindingOptions", value);
		}
		public static Task<object> GetElementAttrOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DOMComponent_GetOption", dxTarget, "elementAttr");
		}
		public static Task SetElementAttrOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DOMComponent_SetOption", dxTarget, "elementAttr", value);
		}
		public static Task<object> GetHeightOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DOMComponent_GetOption", dxTarget, "height");
		}
		public static Task SetHeightOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DOMComponent_SetOption", dxTarget, "height", value);
		}
		public static Task<bool?> GetRtlEnabledOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DOMComponent_GetOption", dxTarget, "rtlEnabled");
		}
		public static Task SetRtlEnabledOption(ElementRef dxTarget, bool? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DOMComponent_SetOption", dxTarget, "rtlEnabled", value);
		}
		public static Task<object> GetWidthOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DOMComponent_GetOption", dxTarget, "width");
		}
		public static Task SetWidthOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DOMComponent_SetOption", dxTarget, "width", value);
		}
		public static Task DefaultOptions(object rule)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DOMComponent_defaultOptions_0", rule);
		}
		public static Task<object> GetInstance(object element)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DOMComponent_getInstance_1", element);
		}
		public static Task Dispose(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DOMComponent_dispose_0", dxTarget);
		}
		public static Task<object> Element(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DOMComponent_element_1", dxTarget);
		}
	}
	public class EndpointSelectorInterop
	{
		public static Task<string> UrlFor(ElementRef dxTarget, string key)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_EndpointSelector_urlFor_0", dxTarget, key);
		}
	}
	public class ValidationEngineInterop
	{
		public static Task<object> GetGroupConfig()
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_ValidationEngine_getGroupConfig_0");
		}
		public static Task<object> GetGroupConfig(object group)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_ValidationEngine_getGroupConfig_1", group);
		}
		public static Task RegisterModelForValidation(object model)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_ValidationEngine_registerModelForValidation_2", model);
		}
		public static Task ResetGroup()
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_ValidationEngine_resetGroup_3");
		}
		public static Task ResetGroup(object group)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_ValidationEngine_resetGroup_4", group);
		}
		public static Task UnregisterModelForValidation(object model)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_ValidationEngine_unregisterModelForValidation_5", model);
		}
		public static Task<object> ValidateGroup()
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_ValidationEngine_validateGroup_6");
		}
		public static Task<object> ValidateGroup(object group)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_ValidationEngine_validateGroup_7", group);
		}
		public static Task<object> ValidateModel(object model)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_ValidationEngine_validateModel_8", model);
		}
	}
	public class UiInterop
	{
		public static Task Notify(string message, string type, float displayTime)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Ui_notify_0", message, type, displayTime);
		}
		public static Task Notify(object options, string type, float displayTime)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Ui_notify_1", options, type, displayTime);
		}
		public static Task SetTemplateEngine(string templateEngineName)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Ui_setTemplateEngine_2", templateEngineName);
		}
		public static Task SetTemplateEngine(object templateEngineOptions)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Ui_setTemplateEngine_3", templateEngineOptions);
		}
	}
	public class VizInterop
	{
		public static Task CurrentPalette(string paletteName)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Viz_currentPalette_0", paletteName);
		}
		public static Task<string> CurrentTheme()
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_Viz_currentTheme_1");
		}
		public static Task CurrentTheme(string platform, string colorScheme)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Viz_currentTheme_2", platform, colorScheme);
		}
		public static Task CurrentTheme(string theme)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Viz_currentTheme_3", theme);
		}
		public static Task ExportFromMarkup(string markup, object options)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Viz_exportFromMarkup_4", markup, options);
		}
		public static Task<string> GetMarkup(object widgetInstances)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_Viz_getMarkup_5", widgetInstances);
		}
		public static Task<object> GetPalette(string paletteName)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Viz_getPalette_6", paletteName);
		}
		public static Task<object> GetTheme(string theme)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Viz_getTheme_7", theme);
		}
		public static Task RefreshPaths()
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Viz_refreshPaths_8");
		}
		public static Task RefreshTheme()
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Viz_refreshTheme_9");
		}
		public static Task RegisterPalette(string paletteName, object palette)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Viz_registerPalette_10", paletteName, palette);
		}
		public static Task RegisterTheme(object customTheme, string baseTheme)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Viz_registerTheme_11", customTheme, baseTheme);
		}
	}
}
namespace DevExpress.Data
{
	public class GuidInterop
	{
		public static Task<string> ToString(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_Guid_toString_0", dxTarget);
		}
		public static Task<string> ValueOf(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_Guid_valueOf_1", dxTarget);
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
		public static event EventHandler<JQueryEventArgs> Push;
		public static event EventHandler<JQueryEventArgs> Removed;
		public static event EventHandler<JQueryEventArgs> Removing;
		public static event EventHandler<JQueryEventArgs> Updated;
		public static event EventHandler<JQueryEventArgs> Updating;
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
		[JSInvokable("DevExpress.Data.StoreInterop.OnPush")]
		public static void OnPush(string identifier)
		{
			Push?.Invoke(null, new JQueryEventArgs(identifier));
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
		public static Task<object> GetErrorHandlerOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Store_GetOption", dxTarget, "errorHandler");
		}
		public static Task SetErrorHandlerOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Store_SetOption", dxTarget, "errorHandler", value);
		}
		public static Task<object> GetKeyOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Store_GetOption", dxTarget, "key");
		}
		public static Task SetKeyOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Store_SetOption", dxTarget, "key", value);
		}
		public static Task<object> ByKey(ElementRef dxTarget, object key)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Store_byKey_0", dxTarget, key);
		}
		public static Task<object> Insert(ElementRef dxTarget, object values)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Store_insert_1", dxTarget, values);
		}
		public static Task<object> Key(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Store_key_2", dxTarget);
		}
		public static Task<object> KeyOf(ElementRef dxTarget, object obj)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Store_keyOf_3", dxTarget, obj);
		}
		public static Task<object> Load(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Store_load_4", dxTarget);
		}
		public static Task<object> Load(ElementRef dxTarget, object options)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Store_load_5", dxTarget, options);
		}
		public static Task<object> Off(ElementRef dxTarget, string eventName)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Store_off_6", dxTarget, eventName);
		}
		public static Task<object> Off(ElementRef dxTarget, string eventName, object eventHandler)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Store_off_7", dxTarget, eventName, eventHandler);
		}
		public static Task<object> On(ElementRef dxTarget, string eventName, object eventHandler)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Store_on_8", dxTarget, eventName, eventHandler);
		}
		public static Task<object> On(ElementRef dxTarget, object events)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Store_on_9", dxTarget, events);
		}
		//public static Task Push(ElementRef dxTarget, object changes)
		//{
		//	return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Store_push_10", dxTarget, changes);
		//}
		public static Task<object> Remove(ElementRef dxTarget, object key)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Store_remove_11", dxTarget, key);
		}
		public static Task<object> TotalCount(ElementRef dxTarget, object obj)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Store_totalCount_12", dxTarget, obj);
		}
		public static Task<object> Update(ElementRef dxTarget, object key, object values)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Store_update_13", dxTarget, key, values);
		}
	}
	public class ArrayStoreInterop: StoreInterop
	{
		public static Task<object> GetDataOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_ArrayStore_GetOption", dxTarget, "data");
		}
		public static Task SetDataOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_ArrayStore_SetOption", dxTarget, "data", value);
		}
		public static Task Clear(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_ArrayStore_clear_0", dxTarget);
		}
		public static Task<object> CreateQuery(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_ArrayStore_createQuery_1", dxTarget);
		}
	}
	public class CustomStoreInterop: StoreInterop
	{
		public static Task Init(ElementRef dxTarget, DevExpress.Data.CustomStoreOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_CustomStore_Init", dxTarget, json);
		}
		public static Task<object> GetByKeyOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_CustomStore_GetOption", dxTarget, "byKey");
		}
		public static Task SetByKeyOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_CustomStore_SetOption", dxTarget, "byKey", value);
		}
		public static Task<bool?> GetCacheRawDataOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_CustomStore_GetOption", dxTarget, "cacheRawData");
		}
		public static Task SetCacheRawDataOption(ElementRef dxTarget, bool? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_CustomStore_SetOption", dxTarget, "cacheRawData", value);
		}
		public static Task<object> GetInsertOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_CustomStore_GetOption", dxTarget, "insert");
		}
		public static Task SetInsertOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_CustomStore_SetOption", dxTarget, "insert", value);
		}
		public static Task<object> GetLoadOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_CustomStore_GetOption", dxTarget, "load");
		}
		public static Task SetLoadOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_CustomStore_SetOption", dxTarget, "load", value);
		}
		public static Task<string> GetLoadModeOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_CustomStore_GetOption", dxTarget, "loadMode");
		}
		public static Task SetLoadModeOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_CustomStore_SetOption", dxTarget, "loadMode", value);
		}
		public static Task<object> GetRemoveOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_CustomStore_GetOption", dxTarget, "remove");
		}
		public static Task SetRemoveOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_CustomStore_SetOption", dxTarget, "remove", value);
		}
		public static Task<object> GetTotalCountOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_CustomStore_GetOption", dxTarget, "totalCount");
		}
		public static Task SetTotalCountOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_CustomStore_SetOption", dxTarget, "totalCount", value);
		}
		public static Task<object> GetUpdateOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_CustomStore_GetOption", dxTarget, "update");
		}
		public static Task SetUpdateOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_CustomStore_SetOption", dxTarget, "update", value);
		}
		public static Task<bool?> GetUseDefaultSearchOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_CustomStore_GetOption", dxTarget, "useDefaultSearch");
		}
		public static Task SetUseDefaultSearchOption(ElementRef dxTarget, bool? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_CustomStore_SetOption", dxTarget, "useDefaultSearch", value);
		}
		public static Task ClearRawDataCache(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_CustomStore_clearRawDataCache_0", dxTarget);
		}
	}
	public class DataSourceInterop
	{
		public static event EventHandler<JQueryEventArgs> Changed;
		public static event EventHandler<JQueryEventArgs> LoadError;
		public static event EventHandler<JQueryEventArgs> LoadingChanged;
		public static Task Init(ElementRef dxTarget, DevExpress.Data.DataSourceOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DataSource_Init", dxTarget, json);
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
		public static Task<object> GetCustomQueryParamsOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DataSource_GetOption", dxTarget, "customQueryParams");
		}
		public static Task SetCustomQueryParamsOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DataSource_SetOption", dxTarget, "customQueryParams", value);
		}
		public static Task<object> GetExpandOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DataSource_GetOption", dxTarget, "expand");
		}
		public static Task SetExpandOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DataSource_SetOption", dxTarget, "expand", value);
		}
		public static Task<object> GetFilterOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DataSource_GetOption", dxTarget, "filter");
		}
		public static Task SetFilterOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DataSource_SetOption", dxTarget, "filter", value);
		}
		public static Task<object> GetGroupOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DataSource_GetOption", dxTarget, "group");
		}
		public static Task SetGroupOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DataSource_SetOption", dxTarget, "group", value);
		}
		public static Task<object> GetMapOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DataSource_GetOption", dxTarget, "map");
		}
		public static Task SetMapOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DataSource_SetOption", dxTarget, "map", value);
		}
		public static Task<float?> GetPageSizeOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_DataSource_GetOption", dxTarget, "pageSize");
		}
		public static Task SetPageSizeOption(ElementRef dxTarget, float? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DataSource_SetOption", dxTarget, "pageSize", value);
		}
		public static Task<bool?> GetPaginateOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DataSource_GetOption", dxTarget, "paginate");
		}
		public static Task SetPaginateOption(ElementRef dxTarget, bool? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DataSource_SetOption", dxTarget, "paginate", value);
		}
		public static Task<object> GetPostProcessOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DataSource_GetOption", dxTarget, "postProcess");
		}
		public static Task SetPostProcessOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DataSource_SetOption", dxTarget, "postProcess", value);
		}
		public static Task<float?> GetPushAggregationTimeoutOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_DataSource_GetOption", dxTarget, "pushAggregationTimeout");
		}
		public static Task SetPushAggregationTimeoutOption(ElementRef dxTarget, float? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DataSource_SetOption", dxTarget, "pushAggregationTimeout", value);
		}
		public static Task<bool?> GetRequireTotalCountOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DataSource_GetOption", dxTarget, "requireTotalCount");
		}
		public static Task SetRequireTotalCountOption(ElementRef dxTarget, bool? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DataSource_SetOption", dxTarget, "requireTotalCount", value);
		}
		public static Task<bool?> GetReshapeOnPushOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DataSource_GetOption", dxTarget, "reshapeOnPush");
		}
		public static Task SetReshapeOnPushOption(ElementRef dxTarget, bool? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DataSource_SetOption", dxTarget, "reshapeOnPush", value);
		}
		public static Task<object> GetSearchExprOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DataSource_GetOption", dxTarget, "searchExpr");
		}
		public static Task SetSearchExprOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DataSource_SetOption", dxTarget, "searchExpr", value);
		}
		public static Task<string> GetSearchOperationOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DataSource_GetOption", dxTarget, "searchOperation");
		}
		public static Task SetSearchOperationOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DataSource_SetOption", dxTarget, "searchOperation", value);
		}
		public static Task<object> GetSearchValueOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DataSource_GetOption", dxTarget, "searchValue");
		}
		public static Task SetSearchValueOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DataSource_SetOption", dxTarget, "searchValue", value);
		}
		public static Task<object> GetSelectOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DataSource_GetOption", dxTarget, "select");
		}
		public static Task SetSelectOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DataSource_SetOption", dxTarget, "select", value);
		}
		public static Task<object> GetSortOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DataSource_GetOption", dxTarget, "sort");
		}
		public static Task SetSortOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DataSource_SetOption", dxTarget, "sort", value);
		}
		public static Task<object> GetStoreOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DataSource_GetOption", dxTarget, "store");
		}
		public static Task SetStoreOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DataSource_SetOption", dxTarget, "store", value);
		}
		public static Task<bool> Cancel(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool>("BlazorDevExtreme_DataSource_cancel_0", dxTarget);
		}
		public static Task Dispose(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DataSource_dispose_1", dxTarget);
		}
		public static Task<object> Filter(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DataSource_filter_2", dxTarget);
		}
		public static Task Filter(ElementRef dxTarget, object filterExpr)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DataSource_filter_3", dxTarget, filterExpr);
		}
		public static Task<object> Group(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DataSource_group_4", dxTarget);
		}
		public static Task Group(ElementRef dxTarget, object groupExpr)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DataSource_group_5", dxTarget, groupExpr);
		}
		public static Task<bool> IsLastPage(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool>("BlazorDevExtreme_DataSource_isLastPage_6", dxTarget);
		}
		public static Task<bool> IsLoaded(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool>("BlazorDevExtreme_DataSource_isLoaded_7", dxTarget);
		}
		public static Task<bool> IsLoading(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool>("BlazorDevExtreme_DataSource_isLoading_8", dxTarget);
		}
		public static Task<object> Items(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DataSource_items_9", dxTarget);
		}
		public static Task<object> Key(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DataSource_key_10", dxTarget);
		}
		public static Task<object> Load(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DataSource_load_11", dxTarget);
		}
		public static Task<object> LoadOptions(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DataSource_loadOptions_12", dxTarget);
		}
		public static Task<object> Off(ElementRef dxTarget, string eventName)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DataSource_off_13", dxTarget, eventName);
		}
		public static Task<object> Off(ElementRef dxTarget, string eventName, object eventHandler)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DataSource_off_14", dxTarget, eventName, eventHandler);
		}
		public static Task<object> On(ElementRef dxTarget, string eventName, object eventHandler)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DataSource_on_15", dxTarget, eventName, eventHandler);
		}
		public static Task<object> On(ElementRef dxTarget, object events)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DataSource_on_16", dxTarget, events);
		}
		public static Task<float> PageIndex(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<float>("BlazorDevExtreme_DataSource_pageIndex_17", dxTarget);
		}
		public static Task PageIndex(ElementRef dxTarget, float newIndex)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DataSource_pageIndex_18", dxTarget, newIndex);
		}
		public static Task<float> PageSize(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<float>("BlazorDevExtreme_DataSource_pageSize_19", dxTarget);
		}
		public static Task PageSize(ElementRef dxTarget, float value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DataSource_pageSize_20", dxTarget, value);
		}
		public static Task<bool> Paginate(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool>("BlazorDevExtreme_DataSource_paginate_21", dxTarget);
		}
		public static Task Paginate(ElementRef dxTarget, bool value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DataSource_paginate_22", dxTarget, value);
		}
		public static Task<object> Reload(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DataSource_reload_23", dxTarget);
		}
		public static Task<bool> RequireTotalCount(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool>("BlazorDevExtreme_DataSource_requireTotalCount_24", dxTarget);
		}
		public static Task RequireTotalCount(ElementRef dxTarget, bool value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DataSource_requireTotalCount_25", dxTarget, value);
		}
		public static Task<object> SearchExpr(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DataSource_searchExpr_26", dxTarget);
		}
		public static Task SearchExpr(ElementRef dxTarget, object expr)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DataSource_searchExpr_27", dxTarget, expr);
		}
		public static Task<string> SearchOperation(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DataSource_searchOperation_28", dxTarget);
		}
		public static Task SearchOperation(ElementRef dxTarget, string op)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DataSource_searchOperation_29", dxTarget, op);
		}
		public static Task<object> SearchValue(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DataSource_searchValue_30", dxTarget);
		}
		public static Task SearchValue(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DataSource_searchValue_31", dxTarget, value);
		}
		public static Task<object> Select(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DataSource_select_32", dxTarget);
		}
		public static Task Select(ElementRef dxTarget, object expr)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DataSource_select_33", dxTarget, expr);
		}
		public static Task<object> Sort(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DataSource_sort_34", dxTarget);
		}
		public static Task Sort(ElementRef dxTarget, object sortExpr)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DataSource_sort_35", dxTarget, sortExpr);
		}
		public static Task<object> Store(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DataSource_store_36", dxTarget);
		}
		public static Task<float> TotalCount(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<float>("BlazorDevExtreme_DataSource_totalCount_37", dxTarget);
		}
	}
	public class LocalStoreInterop: ArrayStoreInterop
	{
		public static Task Init(ElementRef dxTarget, DevExpress.Data.LocalStoreOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_LocalStore_Init", dxTarget, json);
		}
		public static Task<float?> GetFlushIntervalOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_LocalStore_GetOption", dxTarget, "flushInterval");
		}
		public static Task SetFlushIntervalOption(ElementRef dxTarget, float? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_LocalStore_SetOption", dxTarget, "flushInterval", value);
		}
		public static Task<bool?> GetImmediateOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_LocalStore_GetOption", dxTarget, "immediate");
		}
		public static Task SetImmediateOption(ElementRef dxTarget, bool? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_LocalStore_SetOption", dxTarget, "immediate", value);
		}
		public static Task<string> GetNameOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_LocalStore_GetOption", dxTarget, "name");
		}
		public static Task SetNameOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_LocalStore_SetOption", dxTarget, "name", value);
		}
		public static Task Clear(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_LocalStore_clear_0", dxTarget);
		}
	}
	public class QueryInterop
	{
		public static Task<object> Aggregate(ElementRef dxTarget, object seed, object step, object finalize)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Query_aggregate_0", dxTarget, seed, step, finalize);
		}
		public static Task<object> Aggregate(ElementRef dxTarget, object step)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Query_aggregate_1", dxTarget, step);
		}
		public static Task<object> Avg(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Query_avg_2", dxTarget);
		}
		public static Task<object> Avg(ElementRef dxTarget, object getter)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Query_avg_3", dxTarget, getter);
		}
		public static Task<object> Count(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Query_count_4", dxTarget);
		}
		public static Task<object> Enumerate(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Query_enumerate_5", dxTarget);
		}
		public static Task<object> Filter(ElementRef dxTarget, object criteria)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Query_filter_6", dxTarget, criteria);
		}
		public static Task<object> GroupBy(ElementRef dxTarget, object getter)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Query_groupBy_8", dxTarget, getter);
		}
		public static Task<object> Max(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Query_max_9", dxTarget);
		}
		public static Task<object> Max(ElementRef dxTarget, object getter)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Query_max_10", dxTarget, getter);
		}
		public static Task<object> Min(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Query_min_11", dxTarget);
		}
		public static Task<object> Min(ElementRef dxTarget, object getter)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Query_min_12", dxTarget, getter);
		}
		public static Task<object> Select(ElementRef dxTarget, object getter)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Query_select_13", dxTarget, getter);
		}
		public static Task<object> Slice(ElementRef dxTarget, float skip, float take)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Query_slice_14", dxTarget, skip, take);
		}
		public static Task<object> SortBy(ElementRef dxTarget, object getter)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Query_sortBy_15", dxTarget, getter);
		}
		public static Task<object> SortBy(ElementRef dxTarget, object getter, bool desc)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Query_sortBy_16", dxTarget, getter, desc);
		}
		public static Task<object> Sum(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Query_sum_17", dxTarget);
		}
		public static Task<object> Sum(ElementRef dxTarget, object getter)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Query_sum_18", dxTarget, getter);
		}
		public static Task<object> ThenBy(ElementRef dxTarget, object getter)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Query_thenBy_19", dxTarget, getter);
		}
		public static Task<object> ThenBy(ElementRef dxTarget, object getter, bool desc)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Query_thenBy_20", dxTarget, getter, desc);
		}
		public static Task<object> ToArray(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Query_toArray_21", dxTarget);
		}
	}
	public class ODataContextInterop
	{
		public static Task Init(ElementRef dxTarget, DevExpress.Data.ODataContextOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_ODataContext_Init", dxTarget, json);
		}
		public static Task<object> GetBeforeSendOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_ODataContext_GetOption", dxTarget, "beforeSend");
		}
		public static Task SetBeforeSendOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_ODataContext_SetOption", dxTarget, "beforeSend", value);
		}
		public static Task<bool?> GetDeserializeDatesOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_ODataContext_GetOption", dxTarget, "deserializeDates");
		}
		public static Task SetDeserializeDatesOption(ElementRef dxTarget, bool? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_ODataContext_SetOption", dxTarget, "deserializeDates", value);
		}
		public static Task<object> GetEntitiesOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_ODataContext_GetOption", dxTarget, "entities");
		}
		public static Task SetEntitiesOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_ODataContext_SetOption", dxTarget, "entities", value);
		}
		public static Task<object> GetErrorHandlerOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_ODataContext_GetOption", dxTarget, "errorHandler");
		}
		public static Task SetErrorHandlerOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_ODataContext_SetOption", dxTarget, "errorHandler", value);
		}
		public static Task<bool?> GetJsonpOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_ODataContext_GetOption", dxTarget, "jsonp");
		}
		public static Task SetJsonpOption(ElementRef dxTarget, bool? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_ODataContext_SetOption", dxTarget, "jsonp", value);
		}
		public static Task<string> GetUrlOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_ODataContext_GetOption", dxTarget, "url");
		}
		public static Task SetUrlOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_ODataContext_SetOption", dxTarget, "url", value);
		}
		public static Task<float?> GetVersionOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_ODataContext_GetOption", dxTarget, "version");
		}
		public static Task SetVersionOption(ElementRef dxTarget, float? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_ODataContext_SetOption", dxTarget, "version", value);
		}
		public static Task<bool?> GetWithCredentialsOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_ODataContext_GetOption", dxTarget, "withCredentials");
		}
		public static Task SetWithCredentialsOption(ElementRef dxTarget, bool? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_ODataContext_SetOption", dxTarget, "withCredentials", value);
		}
		public static Task<object> Get(ElementRef dxTarget, string operationName, object @params)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_ODataContext_get_0", dxTarget, operationName, @params);
		}
		public static Task<object> Invoke(ElementRef dxTarget, string operationName, object @params, object httpMethod)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_ODataContext_invoke_1", dxTarget, operationName, @params, httpMethod);
		}
		public static Task<object> ObjectLink(ElementRef dxTarget, string entityAlias, object key)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_ODataContext_objectLink_2", dxTarget, entityAlias, key);
		}
	}
	public class ODataStoreInterop: StoreInterop
	{
		public static Task Init(ElementRef dxTarget, DevExpress.Data.ODataStoreOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_ODataStore_Init", dxTarget, json);
		}
		public static Task<object> GetBeforeSendOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_ODataStore_GetOption", dxTarget, "beforeSend");
		}
		public static Task SetBeforeSendOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_ODataStore_SetOption", dxTarget, "beforeSend", value);
		}
		public static Task<bool?> GetDeserializeDatesOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_ODataStore_GetOption", dxTarget, "deserializeDates");
		}
		public static Task SetDeserializeDatesOption(ElementRef dxTarget, bool? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_ODataStore_SetOption", dxTarget, "deserializeDates", value);
		}
		public static Task<object> GetFieldTypesOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_ODataStore_GetOption", dxTarget, "fieldTypes");
		}
		public static Task SetFieldTypesOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_ODataStore_SetOption", dxTarget, "fieldTypes", value);
		}
		public static Task<bool?> GetJsonpOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_ODataStore_GetOption", dxTarget, "jsonp");
		}
		public static Task SetJsonpOption(ElementRef dxTarget, bool? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_ODataStore_SetOption", dxTarget, "jsonp", value);
		}
		public static Task<object> GetKeyTypeOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_ODataStore_GetOption", dxTarget, "keyType");
		}
		public static Task SetKeyTypeOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_ODataStore_SetOption", dxTarget, "keyType", value);
		}
		public static Task<string> GetUrlOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_ODataStore_GetOption", dxTarget, "url");
		}
		public static Task SetUrlOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_ODataStore_SetOption", dxTarget, "url", value);
		}
		public static Task<float?> GetVersionOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_ODataStore_GetOption", dxTarget, "version");
		}
		public static Task SetVersionOption(ElementRef dxTarget, float? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_ODataStore_SetOption", dxTarget, "version", value);
		}
		public static Task<bool?> GetWithCredentialsOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_ODataStore_GetOption", dxTarget, "withCredentials");
		}
		public static Task SetWithCredentialsOption(ElementRef dxTarget, bool? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_ODataStore_SetOption", dxTarget, "withCredentials", value);
		}
		public static Task<object> ByKey(ElementRef dxTarget, object key)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_ODataStore_byKey_0", dxTarget, key);
		}
		public static Task<object> ByKey(ElementRef dxTarget, object key, object extraOptions)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_ODataStore_byKey_1", dxTarget, key, extraOptions);
		}
		public static Task<object> CreateQuery(ElementRef dxTarget, object loadOptions)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_ODataStore_createQuery_2", dxTarget, loadOptions);
		}
	}
	public class EdmLiteralInterop
	{
		public static Task<string> ValueOf(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_EdmLiteral_valueOf_0", dxTarget);
		}
	}
	public class PivotGridDataSourceInterop
	{
		public static event EventHandler<JQueryEventArgs> Changed;
		public static event EventHandler<JQueryEventArgs> FieldsPrepared;
		public static event EventHandler<JQueryEventArgs> LoadError;
		public static event EventHandler<JQueryEventArgs> LoadingChanged;
		public static Task Init(ElementRef dxTarget, DevExpress.Data.PivotGridDataSourceOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_PivotGridDataSource_Init", dxTarget, json);
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
		public static Task<object> GetFieldsOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_PivotGridDataSource_GetOption", dxTarget, "fields");
		}
		public static Task SetFieldsOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_PivotGridDataSource_SetOption", dxTarget, "fields", value);
		}
		public static Task<object> GetFilterOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_PivotGridDataSource_GetOption", dxTarget, "filter");
		}
		public static Task SetFilterOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_PivotGridDataSource_SetOption", dxTarget, "filter", value);
		}
		public static Task<bool?> GetRemoteOperationsOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_PivotGridDataSource_GetOption", dxTarget, "remoteOperations");
		}
		public static Task SetRemoteOperationsOption(ElementRef dxTarget, bool? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_PivotGridDataSource_SetOption", dxTarget, "remoteOperations", value);
		}
		public static Task<bool?> GetRetrieveFieldsOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_PivotGridDataSource_GetOption", dxTarget, "retrieveFields");
		}
		public static Task SetRetrieveFieldsOption(ElementRef dxTarget, bool? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_PivotGridDataSource_SetOption", dxTarget, "retrieveFields", value);
		}
		public static Task<object> GetStoreOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_PivotGridDataSource_GetOption", dxTarget, "store");
		}
		public static Task SetStoreOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_PivotGridDataSource_SetOption", dxTarget, "store", value);
		}
		public static Task CollapseAll(ElementRef dxTarget, object id)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_PivotGridDataSource_collapseAll_0", dxTarget, id);
		}
		public static Task CollapseHeaderItem(ElementRef dxTarget, string area, object path)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_PivotGridDataSource_collapseHeaderItem_1", dxTarget, area, path);
		}
		public static Task<object> CreateDrillDownDataSource(ElementRef dxTarget, object options)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_PivotGridDataSource_createDrillDownDataSource_2", dxTarget, options);
		}
		public static Task Dispose(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_PivotGridDataSource_dispose_3", dxTarget);
		}
		public static Task ExpandAll(ElementRef dxTarget, object id)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_PivotGridDataSource_expandAll_4", dxTarget, id);
		}
		public static Task ExpandHeaderItem(ElementRef dxTarget, string area, object path)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_PivotGridDataSource_expandHeaderItem_5", dxTarget, area, path);
		}
		public static Task<object> Field(ElementRef dxTarget, object id)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_PivotGridDataSource_field_6", dxTarget, id);
		}
		public static Task Field(ElementRef dxTarget, object id, object options)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_PivotGridDataSource_field_7", dxTarget, id, options);
		}
		public static Task<object> Fields(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_PivotGridDataSource_fields_8", dxTarget);
		}
		public static Task Fields(ElementRef dxTarget, object fields)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_PivotGridDataSource_fields_9", dxTarget, fields);
		}
		public static Task<object> Filter(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_PivotGridDataSource_filter_10", dxTarget);
		}
		public static Task Filter(ElementRef dxTarget, object filterExpr)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_PivotGridDataSource_filter_11", dxTarget, filterExpr);
		}
		public static Task<object> GetAreaFields(ElementRef dxTarget, string area, bool collectGroups)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_PivotGridDataSource_getAreaFields_12", dxTarget, area, collectGroups);
		}
		public static Task<object> GetData(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_PivotGridDataSource_getData_13", dxTarget);
		}
		public static Task<bool> IsLoading(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool>("BlazorDevExtreme_PivotGridDataSource_isLoading_14", dxTarget);
		}
		public static Task<object> Load(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_PivotGridDataSource_load_15", dxTarget);
		}
		public static Task<object> Off(ElementRef dxTarget, string eventName)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_PivotGridDataSource_off_16", dxTarget, eventName);
		}
		public static Task<object> Off(ElementRef dxTarget, string eventName, object eventHandler)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_PivotGridDataSource_off_17", dxTarget, eventName, eventHandler);
		}
		public static Task<object> On(ElementRef dxTarget, string eventName, object eventHandler)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_PivotGridDataSource_on_18", dxTarget, eventName, eventHandler);
		}
		public static Task<object> On(ElementRef dxTarget, object events)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_PivotGridDataSource_on_19", dxTarget, events);
		}
		public static Task<object> Reload(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_PivotGridDataSource_reload_20", dxTarget);
		}
		public static Task<object> State(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_PivotGridDataSource_state_21", dxTarget);
		}
		public static Task State(ElementRef dxTarget, object state)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_PivotGridDataSource_state_22", dxTarget, state);
		}
	}
	public class XmlaStoreInterop
	{
		public static Task Init(ElementRef dxTarget, DevExpress.Data.XmlaStoreOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_XmlaStore_Init", dxTarget, json);
		}
		public static Task<object> GetBeforeSendOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_XmlaStore_GetOption", dxTarget, "beforeSend");
		}
		public static Task SetBeforeSendOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_XmlaStore_SetOption", dxTarget, "beforeSend", value);
		}
		public static Task<string> GetCatalogOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_XmlaStore_GetOption", dxTarget, "catalog");
		}
		public static Task SetCatalogOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_XmlaStore_SetOption", dxTarget, "catalog", value);
		}
		public static Task<string> GetCubeOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_XmlaStore_GetOption", dxTarget, "cube");
		}
		public static Task SetCubeOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_XmlaStore_SetOption", dxTarget, "cube", value);
		}
		public static Task<string> GetUrlOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_XmlaStore_GetOption", dxTarget, "url");
		}
		public static Task SetUrlOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_XmlaStore_SetOption", dxTarget, "url", value);
		}
	}
}
namespace DevExpress.Core
{
	public class EventsMixinInterop
	{
		public static Task<object> Off(ElementRef dxTarget, string eventName)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_EventsMixin_off_0", dxTarget, eventName);
		}
		public static Task<object> Off(ElementRef dxTarget, string eventName, object eventHandler)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_EventsMixin_off_1", dxTarget, eventName, eventHandler);
		}
		public static Task<object> On(ElementRef dxTarget, string eventName, object eventHandler)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_EventsMixin_on_2", dxTarget, eventName, eventHandler);
		}
		public static Task<object> On(ElementRef dxTarget, object events)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_EventsMixin_on_3", dxTarget, events);
		}
	}
}
namespace DevExpress.Framework
{
	public class DxCommandInterop: DOMComponentInterop
	{
		public static event EventHandler<JQueryEventArgs> Execute;
		public static Task Init(ElementRef dxTarget, DevExpress.Framework.DxCommandOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxCommand_Init", dxTarget, json);
		}
		[JSInvokable("DevExpress.Framework.DxCommandInterop.OnExecute")]
		public static void OnExecute(string identifier)
		{
			Execute?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static Task<bool?> GetDisabledOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxCommand_GetOption", dxTarget, "disabled");
		}
		public static Task SetDisabledOption(ElementRef dxTarget, bool? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxCommand_SetOption", dxTarget, "disabled", value);
		}
		public static Task<string> GetIconOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxCommand_GetOption", dxTarget, "icon");
		}
		public static Task SetIconOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxCommand_SetOption", dxTarget, "icon", value);
		}
		public static Task<object> GetIconSrcOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxCommand_GetOption", dxTarget, "iconSrc");
		}
		public static Task SetIconSrcOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxCommand_SetOption", dxTarget, "iconSrc", value);
		}
		public static Task<string> GetIdOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxCommand_GetOption", dxTarget, "id");
		}
		public static Task SetIdOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxCommand_SetOption", dxTarget, "id", value);
		}
		public static Task<string> GetRenderStageOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxCommand_GetOption", dxTarget, "renderStage");
		}
		public static Task SetRenderStageOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxCommand_SetOption", dxTarget, "renderStage", value);
		}
		public static Task<string> GetTitleOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxCommand_GetOption", dxTarget, "title");
		}
		public static Task SetTitleOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxCommand_SetOption", dxTarget, "title", value);
		}
		public static Task<string> GetTypeOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxCommand_GetOption", dxTarget, "type");
		}
		public static Task SetTypeOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxCommand_SetOption", dxTarget, "type", value);
		}
		public static Task<bool?> GetVisibleOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxCommand_GetOption", dxTarget, "visible");
		}
		public static Task SetVisibleOption(ElementRef dxTarget, bool? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxCommand_SetOption", dxTarget, "visible", value);
		}
		public static Task DoExecute(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxCommand_execute_0", dxTarget);
		}
	}
	public class RouterInterop
	{
		public static Task<string> Format(ElementRef dxTarget, object obj)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_Router_format_0", dxTarget, obj);
		}
		public static Task<object> Parse(ElementRef dxTarget, string uri)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Router_parse_1", dxTarget, uri);
		}
		public static Task Register(ElementRef dxTarget, string pattern, object defaults, object constraints)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Router_register_2", dxTarget, pattern, defaults, constraints);
		}
	}
	public class StateManagerInterop
	{
		public static Task Init(ElementRef dxTarget, DevExpress.Framework.StateManagerOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_StateManager_Init", dxTarget, json);
		}
		public static Task<object> GetStorageOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_StateManager_GetOption", dxTarget, "storage");
		}
		public static Task SetStorageOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_StateManager_SetOption", dxTarget, "storage", value);
		}
		public static Task AddStateSource(ElementRef dxTarget, object stateSource)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_StateManager_addStateSource_0", dxTarget, stateSource);
		}
		public static Task ClearState(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_StateManager_clearState_1", dxTarget);
		}
		public static Task RemoveStateSource(ElementRef dxTarget, object stateSource)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_StateManager_removeStateSource_2", dxTarget, stateSource);
		}
		public static Task RestoreState(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_StateManager_restoreState_3", dxTarget);
		}
		public static Task SaveState(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_StateManager_saveState_4", dxTarget);
		}
	}
	public class ViewCacheInterop
	{
		public static Task Clear(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_ViewCache_clear_0", dxTarget);
		}
		public static Task<object> GetView(ElementRef dxTarget, string key)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_ViewCache_getView_1", dxTarget, key);
		}
		public static Task<bool> HasView(ElementRef dxTarget, string key)
		{
			return JSRuntime.Current.InvokeAsync<bool>("BlazorDevExtreme_ViewCache_hasView_2", dxTarget, key);
		}
		public static Task<object> Off(ElementRef dxTarget, string eventName)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_ViewCache_off_3", dxTarget, eventName);
		}
		public static Task<object> Off(ElementRef dxTarget, string eventName, object eventHandler)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_ViewCache_off_4", dxTarget, eventName, eventHandler);
		}
		public static Task<object> On(ElementRef dxTarget, string eventName, object eventHandler)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_ViewCache_on_5", dxTarget, eventName, eventHandler);
		}
		public static Task<object> On(ElementRef dxTarget, object events)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_ViewCache_on_6", dxTarget, events);
		}
		public static Task<object> RemoveView(ElementRef dxTarget, string key)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_ViewCache_removeView_7", dxTarget, key);
		}
		public static Task SetView(ElementRef dxTarget, string key, object viewInfo)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_ViewCache_setView_8", dxTarget, key, viewInfo);
		}
	}
	public class DxCommandContainerInterop
	{
		public static Task Init(ElementRef dxTarget, DevExpress.Framework.DxCommandContainerOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxCommandContainer_Init", dxTarget, json);
		}
		public static Task<string> GetIdOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxCommandContainer_GetOption", dxTarget, "id");
		}
		public static Task SetIdOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxCommandContainer_SetOption", dxTarget, "id", value);
		}
	}
	public class DxViewInterop
	{
		public static Task Init(ElementRef dxTarget, DevExpress.Framework.DxViewOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxView_Init", dxTarget, json);
		}
		public static Task<bool?> GetDisableCacheOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxView_GetOption", dxTarget, "disableCache");
		}
		public static Task SetDisableCacheOption(ElementRef dxTarget, bool? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxView_SetOption", dxTarget, "disableCache", value);
		}
		public static Task<bool?> GetModalOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxView_GetOption", dxTarget, "modal");
		}
		public static Task SetModalOption(ElementRef dxTarget, bool? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxView_SetOption", dxTarget, "modal", value);
		}
		public static Task<string> GetNameOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxView_GetOption", dxTarget, "name");
		}
		public static Task SetNameOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxView_SetOption", dxTarget, "name", value);
		}
		public static Task<string> GetOrientationOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxView_GetOption", dxTarget, "orientation");
		}
		public static Task SetOrientationOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxView_SetOption", dxTarget, "orientation", value);
		}
		public static Task<string> GetPaneOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxView_GetOption", dxTarget, "pane");
		}
		public static Task SetPaneOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxView_SetOption", dxTarget, "pane", value);
		}
		public static Task<string> GetTitleOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxView_GetOption", dxTarget, "title");
		}
		public static Task SetTitleOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxView_SetOption", dxTarget, "title", value);
		}
	}
	public class DxLayoutInterop
	{
		public static Task Init(ElementRef dxTarget, DevExpress.Framework.DxLayoutOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxLayout_Init", dxTarget, json);
		}
		public static Task<string> GetNameOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxLayout_GetOption", dxTarget, "name");
		}
		public static Task SetNameOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxLayout_SetOption", dxTarget, "name", value);
		}
	}
	public class DxViewPlaceholderInterop
	{
		public static Task Init(ElementRef dxTarget, DevExpress.Framework.DxViewPlaceholderOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxViewPlaceholder_Init", dxTarget, json);
		}
		public static Task<string> GetViewNameOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxViewPlaceholder_GetOption", dxTarget, "viewName");
		}
		public static Task SetViewNameOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxViewPlaceholder_SetOption", dxTarget, "viewName", value);
		}
	}
	public class DxTransitionInterop
	{
		public static Task Init(ElementRef dxTarget, DevExpress.Framework.DxTransitionOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTransition_Init", dxTarget, json);
		}
		public static Task<string> GetAnimationOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxTransition_GetOption", dxTarget, "animation");
		}
		public static Task SetAnimationOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTransition_SetOption", dxTarget, "animation", value);
		}
		public static Task<string> GetNameOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxTransition_GetOption", dxTarget, "name");
		}
		public static Task SetNameOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTransition_SetOption", dxTarget, "name", value);
		}
		public static Task<string> GetTypeOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxTransition_GetOption", dxTarget, "type");
		}
		public static Task SetTypeOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTransition_SetOption", dxTarget, "type", value);
		}
	}
	public class DxContentPlaceholderInterop
	{
		public static Task Init(ElementRef dxTarget, DevExpress.Framework.DxContentPlaceholderOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxContentPlaceholder_Init", dxTarget, json);
		}
		public static Task<string> GetAnimationOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxContentPlaceholder_GetOption", dxTarget, "animation");
		}
		public static Task SetAnimationOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxContentPlaceholder_SetOption", dxTarget, "animation", value);
		}
		public static Task<string> GetContentCssPositionOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxContentPlaceholder_GetOption", dxTarget, "contentCssPosition");
		}
		public static Task SetContentCssPositionOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxContentPlaceholder_SetOption", dxTarget, "contentCssPosition", value);
		}
		public static Task<string> GetNameOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxContentPlaceholder_GetOption", dxTarget, "name");
		}
		public static Task SetNameOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxContentPlaceholder_SetOption", dxTarget, "name", value);
		}
		public static Task<string> GetTransitionOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxContentPlaceholder_GetOption", dxTarget, "transition");
		}
		public static Task SetTransitionOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxContentPlaceholder_SetOption", dxTarget, "transition", value);
		}
	}
	public class DxContentInterop
	{
		public static Task Init(ElementRef dxTarget, DevExpress.Framework.DxContentOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxContent_Init", dxTarget, json);
		}
		public static Task<string> GetTargetPlaceholderOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxContent_GetOption", dxTarget, "targetPlaceholder");
		}
		public static Task SetTargetPlaceholderOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxContent_SetOption", dxTarget, "targetPlaceholder", value);
		}
	}
}
namespace DevExpress.Framework.Html
{
	public class HtmlApplicationInterop
	{
		public static Task Init(ElementRef dxTarget, DevExpress.Framework.Html.HtmlApplicationOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_HtmlApplication_Init", dxTarget, json);
		}
		public static Task<object> GetAnimationSetOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_HtmlApplication_GetOption", dxTarget, "animationSet");
		}
		public static Task SetAnimationSetOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_HtmlApplication_SetOption", dxTarget, "animationSet", value);
		}
		public static Task<object> GetCommandMappingOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_HtmlApplication_GetOption", dxTarget, "commandMapping");
		}
		public static Task SetCommandMappingOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_HtmlApplication_SetOption", dxTarget, "commandMapping", value);
		}
		public static Task<bool?> GetDisableViewCacheOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_HtmlApplication_GetOption", dxTarget, "disableViewCache");
		}
		public static Task SetDisableViewCacheOption(ElementRef dxTarget, bool? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_HtmlApplication_SetOption", dxTarget, "disableViewCache", value);
		}
		public static Task<object> GetLayoutSetOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_HtmlApplication_GetOption", dxTarget, "layoutSet");
		}
		public static Task SetLayoutSetOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_HtmlApplication_SetOption", dxTarget, "layoutSet", value);
		}
		public static Task<string> GetModeOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_HtmlApplication_GetOption", dxTarget, "mode");
		}
		public static Task SetModeOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_HtmlApplication_SetOption", dxTarget, "mode", value);
		}
		public static Task<object> GetNamespaceOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_HtmlApplication_GetOption", dxTarget, "namespace");
		}
		public static Task SetNamespaceOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_HtmlApplication_SetOption", dxTarget, "namespace", value);
		}
		public static Task<string> GetNavigateToRootViewModeOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_HtmlApplication_GetOption", dxTarget, "navigateToRootViewMode");
		}
		public static Task SetNavigateToRootViewModeOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_HtmlApplication_SetOption", dxTarget, "navigateToRootViewMode", value);
		}
		public static Task<object> GetNavigationOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_HtmlApplication_GetOption", dxTarget, "navigation");
		}
		public static Task SetNavigationOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_HtmlApplication_SetOption", dxTarget, "navigation", value);
		}
		public static Task<object> GetRouterOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_HtmlApplication_GetOption", dxTarget, "router");
		}
		public static Task SetRouterOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_HtmlApplication_SetOption", dxTarget, "router", value);
		}
		public static Task<object> GetStateManagerOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_HtmlApplication_GetOption", dxTarget, "stateManager");
		}
		public static Task SetStateManagerOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_HtmlApplication_SetOption", dxTarget, "stateManager", value);
		}
		public static Task<object> GetStateStorageOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_HtmlApplication_GetOption", dxTarget, "stateStorage");
		}
		public static Task SetStateStorageOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_HtmlApplication_SetOption", dxTarget, "stateStorage", value);
		}
		public static Task<string> GetTemplatesVersionOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_HtmlApplication_GetOption", dxTarget, "templatesVersion");
		}
		public static Task SetTemplatesVersionOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_HtmlApplication_SetOption", dxTarget, "templatesVersion", value);
		}
		public static Task<bool?> GetUseViewTitleAsBackTextOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_HtmlApplication_GetOption", dxTarget, "useViewTitleAsBackText");
		}
		public static Task SetUseViewTitleAsBackTextOption(ElementRef dxTarget, bool? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_HtmlApplication_SetOption", dxTarget, "useViewTitleAsBackText", value);
		}
		public static Task<object> GetViewCacheOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_HtmlApplication_GetOption", dxTarget, "viewCache");
		}
		public static Task SetViewCacheOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_HtmlApplication_SetOption", dxTarget, "viewCache", value);
		}
		public static Task<float?> GetViewCacheSizeOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_HtmlApplication_GetOption", dxTarget, "viewCacheSize");
		}
		public static Task SetViewCacheSizeOption(ElementRef dxTarget, float? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_HtmlApplication_SetOption", dxTarget, "viewCacheSize", value);
		}
		public static Task<object> GetViewPortOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_HtmlApplication_GetOption", dxTarget, "viewPort");
		}
		public static Task SetViewPortOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_HtmlApplication_SetOption", dxTarget, "viewPort", value);
		}
		public static Task Back(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_HtmlApplication_back_0", dxTarget);
		}
		public static Task<bool> CanBack(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool>("BlazorDevExtreme_HtmlApplication_canBack_1", dxTarget);
		}
		public static Task ClearState(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_HtmlApplication_clearState_2", dxTarget);
		}
		public static Task CreateNavigation(ElementRef dxTarget, object navigationConfig)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_HtmlApplication_createNavigation_3", dxTarget, navigationConfig);
		}
		public static Task<object> GetViewTemplate(ElementRef dxTarget, string viewName)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_HtmlApplication_getViewTemplate_4", dxTarget, viewName);
		}
		public static Task<object> GetViewTemplateInfo(ElementRef dxTarget, string viewName)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_HtmlApplication_getViewTemplateInfo_5", dxTarget, viewName);
		}
		public static Task<object> LoadTemplates(ElementRef dxTarget, object source)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_HtmlApplication_loadTemplates_6", dxTarget, source);
		}
		public static Task Navigate(ElementRef dxTarget, object uri)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_HtmlApplication_navigate_7", dxTarget, uri);
		}
		public static Task Navigate(ElementRef dxTarget, object uri, object options)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_HtmlApplication_navigate_8", dxTarget, uri, options);
		}
		public static Task<object> Off(ElementRef dxTarget, string eventName)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_HtmlApplication_off_9", dxTarget, eventName);
		}
		public static Task<object> Off(ElementRef dxTarget, string eventName, object eventHandler)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_HtmlApplication_off_10", dxTarget, eventName, eventHandler);
		}
		public static Task<object> On(ElementRef dxTarget, string eventName, object eventHandler)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_HtmlApplication_on_11", dxTarget, eventName, eventHandler);
		}
		public static Task<object> On(ElementRef dxTarget, object events)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_HtmlApplication_on_12", dxTarget, events);
		}
		public static Task RenderNavigation(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_HtmlApplication_renderNavigation_13", dxTarget);
		}
		public static Task RestoreState(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_HtmlApplication_restoreState_14", dxTarget);
		}
		public static Task SaveState(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_HtmlApplication_saveState_15", dxTarget);
		}
		public static Task<object> TemplateContext(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_HtmlApplication_templateContext_16", dxTarget);
		}
	}
}
namespace DevExpress.Ui
{
	public class DxAccordionInterop: CollectionWidgetInterop
	{
		public static event EventHandler<JQueryEventArgs> ItemTitleClick;
		public static Task Init(ElementRef dxTarget, DevExpress.Ui.DxAccordionOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxAccordion_Init", dxTarget, json);
		}
		[JSInvokable("DevExpress.Ui.DxAccordionInterop.OnItemTitleClick")]
		public static void OnItemTitleClick(string identifier)
		{
			ItemTitleClick?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static Task<float?> GetAnimationDurationOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_DxAccordion_GetOption", dxTarget, "animationDuration");
		}
		public static Task SetAnimationDurationOption(ElementRef dxTarget, float? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxAccordion_SetOption", dxTarget, "animationDuration", value);
		}
		public static Task<bool?> GetCollapsibleOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxAccordion_GetOption", dxTarget, "collapsible");
		}
		public static Task SetCollapsibleOption(ElementRef dxTarget, bool? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxAccordion_SetOption", dxTarget, "collapsible", value);
		}
		public static Task<bool?> GetDeferRenderingOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxAccordion_GetOption", dxTarget, "deferRendering");
		}
		public static Task SetDeferRenderingOption(ElementRef dxTarget, bool? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxAccordion_SetOption", dxTarget, "deferRendering", value);
		}
		public static Task<object> GetItemTitleTemplateOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxAccordion_GetOption", dxTarget, "itemTitleTemplate");
		}
		public static Task SetItemTitleTemplateOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxAccordion_SetOption", dxTarget, "itemTitleTemplate", value);
		}
		public static Task<bool?> GetMultipleOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxAccordion_GetOption", dxTarget, "multiple");
		}
		public static Task SetMultipleOption(ElementRef dxTarget, bool? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxAccordion_SetOption", dxTarget, "multiple", value);
		}
		public static Task<bool?> GetRepaintChangesOnlyOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxAccordion_GetOption", dxTarget, "repaintChangesOnly");
		}
		public static Task SetRepaintChangesOnlyOption(ElementRef dxTarget, bool? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxAccordion_SetOption", dxTarget, "repaintChangesOnly", value);
		}
		public static Task<object> CollapseItem(ElementRef dxTarget, float index)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxAccordion_collapseItem_0", dxTarget, index);
		}
		public static Task<object> ExpandItem(ElementRef dxTarget, float index)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxAccordion_expandItem_1", dxTarget, index);
		}
		public static Task<object> UpdateDimensions(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxAccordion_updateDimensions_2", dxTarget);
		}
	}
	public class DxActionSheetInterop: CollectionWidgetInterop
	{
		public static event EventHandler<JQueryEventArgs> CancelClick;
		public static Task Init(ElementRef dxTarget, DevExpress.Ui.DxActionSheetOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxActionSheet_Init", dxTarget, json);
		}
		[JSInvokable("DevExpress.Ui.DxActionSheetInterop.OnCancelClick")]
		public static void OnCancelClick(string identifier)
		{
			CancelClick?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static Task<string> GetCancelTextOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxActionSheet_GetOption", dxTarget, "cancelText");
		}
		public static Task SetCancelTextOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxActionSheet_SetOption", dxTarget, "cancelText", value);
		}
		public static Task<bool?> GetShowCancelButtonOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxActionSheet_GetOption", dxTarget, "showCancelButton");
		}
		public static Task SetShowCancelButtonOption(ElementRef dxTarget, bool? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxActionSheet_SetOption", dxTarget, "showCancelButton", value);
		}
		public static Task<bool?> GetShowTitleOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxActionSheet_GetOption", dxTarget, "showTitle");
		}
		public static Task SetShowTitleOption(ElementRef dxTarget, bool? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxActionSheet_SetOption", dxTarget, "showTitle", value);
		}
		public static Task<object> GetTargetOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxActionSheet_GetOption", dxTarget, "target");
		}
		public static Task SetTargetOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxActionSheet_SetOption", dxTarget, "target", value);
		}
		public static Task<string> GetTitleOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxActionSheet_GetOption", dxTarget, "title");
		}
		public static Task SetTitleOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxActionSheet_SetOption", dxTarget, "title", value);
		}
		public static Task<bool?> GetUsePopoverOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxActionSheet_GetOption", dxTarget, "usePopover");
		}
		public static Task SetUsePopoverOption(ElementRef dxTarget, bool? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxActionSheet_SetOption", dxTarget, "usePopover", value);
		}
		public static Task<object> Hide(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxActionSheet_hide_0", dxTarget);
		}
		public static Task<object> Show(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxActionSheet_show_1", dxTarget);
		}
		public static Task<object> Toggle(ElementRef dxTarget, bool showing)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxActionSheet_toggle_2", dxTarget, showing);
		}
	}
	public class DxAutocompleteInterop: DxDropDownListInterop
	{
		public static Task Init(ElementRef dxTarget, DevExpress.Ui.DxAutocompleteOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxAutocomplete_Init", dxTarget, json);
		}
		public static Task<float?> GetMaxItemCountOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_DxAutocomplete_GetOption", dxTarget, "maxItemCount");
		}
		public static Task SetMaxItemCountOption(ElementRef dxTarget, float? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxAutocomplete_SetOption", dxTarget, "maxItemCount", value);
		}
	}
	public class DxBoxInterop: CollectionWidgetInterop
	{
		public static Task Init(ElementRef dxTarget, DevExpress.Ui.DxBoxOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxBox_Init", dxTarget, json);
		}
		public static Task<string> GetAlignOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxBox_GetOption", dxTarget, "align");
		}
		public static Task SetAlignOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxBox_SetOption", dxTarget, "align", value);
		}
		public static Task<string> GetCrossAlignOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxBox_GetOption", dxTarget, "crossAlign");
		}
		public static Task SetCrossAlignOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxBox_SetOption", dxTarget, "crossAlign", value);
		}
		public static Task<string> GetDirectionOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxBox_GetOption", dxTarget, "direction");
		}
		public static Task SetDirectionOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxBox_SetOption", dxTarget, "direction", value);
		}
	}
	public class DxButtonInterop: WidgetInterop
	{
		public static event EventHandler<JQueryEventArgs> Click;
		public static Task Init(ElementRef dxTarget, DevExpress.Ui.DxButtonOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxButton_Init", dxTarget, json);
		}
		[JSInvokable("DevExpress.Ui.DxButtonInterop.OnClick")]
		public static void OnClick(string identifier)
		{
			Click?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static Task<string> GetIconOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxButton_GetOption", dxTarget, "icon");
		}
		public static Task SetIconOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxButton_SetOption", dxTarget, "icon", value);
		}
		public static Task<string> GetStylingModeOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxButton_GetOption", dxTarget, "stylingMode");
		}
		public static Task SetStylingModeOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxButton_SetOption", dxTarget, "stylingMode", value);
		}
		public static Task<object> GetTemplateOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxButton_GetOption", dxTarget, "template");
		}
		public static Task SetTemplateOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxButton_SetOption", dxTarget, "template", value);
		}
		public static Task<string> GetTextOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxButton_GetOption", dxTarget, "text");
		}
		public static Task SetTextOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxButton_SetOption", dxTarget, "text", value);
		}
		public static Task<string> GetTypeOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxButton_GetOption", dxTarget, "type");
		}
		public static Task SetTypeOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxButton_SetOption", dxTarget, "type", value);
		}
		public static Task<bool?> GetUseSubmitBehaviorOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxButton_GetOption", dxTarget, "useSubmitBehavior");
		}
		public static Task SetUseSubmitBehaviorOption(ElementRef dxTarget, bool? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxButton_SetOption", dxTarget, "useSubmitBehavior", value);
		}
		public static Task<string> GetValidationGroupOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxButton_GetOption", dxTarget, "validationGroup");
		}
		public static Task SetValidationGroupOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxButton_SetOption", dxTarget, "validationGroup", value);
		}
	}
	public class DxButtonGroupInterop: WidgetInterop
	{
		public static event EventHandler<JQueryEventArgs> SelectionChanged;
		public static Task Init(ElementRef dxTarget, DevExpress.Ui.DxButtonGroupOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxButtonGroup_Init", dxTarget, json);
		}
		[JSInvokable("DevExpress.Ui.DxButtonGroupInterop.OnSelectionChanged")]
		public static void OnSelectionChanged(string identifier)
		{
			SelectionChanged?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static Task<object> GetItemsOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxButtonGroup_GetOption", dxTarget, "items");
		}
		public static Task SetItemsOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxButtonGroup_SetOption", dxTarget, "items", value);
		}
		public static Task<object> GetItemTemplateOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxButtonGroup_GetOption", dxTarget, "itemTemplate");
		}
		public static Task SetItemTemplateOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxButtonGroup_SetOption", dxTarget, "itemTemplate", value);
		}
		public static Task<object> GetKeyExprOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxButtonGroup_GetOption", dxTarget, "keyExpr");
		}
		public static Task SetKeyExprOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxButtonGroup_SetOption", dxTarget, "keyExpr", value);
		}
		public static Task<object> GetSelectedItemKeysOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxButtonGroup_GetOption", dxTarget, "selectedItemKeys");
		}
		public static Task SetSelectedItemKeysOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxButtonGroup_SetOption", dxTarget, "selectedItemKeys", value);
		}
		public static Task<object> GetSelectedItemsOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxButtonGroup_GetOption", dxTarget, "selectedItems");
		}
		public static Task SetSelectedItemsOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxButtonGroup_SetOption", dxTarget, "selectedItems", value);
		}
		public static Task<string> GetSelectionModeOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxButtonGroup_GetOption", dxTarget, "selectionMode");
		}
		public static Task SetSelectionModeOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxButtonGroup_SetOption", dxTarget, "selectionMode", value);
		}
		public static Task<string> GetStylingModeOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxButtonGroup_GetOption", dxTarget, "stylingMode");
		}
		public static Task SetStylingModeOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxButtonGroup_SetOption", dxTarget, "stylingMode", value);
		}
	}
	public class DxCalendarInterop: EditorInterop
	{
		public static Task Init(ElementRef dxTarget, DevExpress.Ui.DxCalendarOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxCalendar_Init", dxTarget, json);
		}
		public static Task<object> GetCellTemplateOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxCalendar_GetOption", dxTarget, "cellTemplate");
		}
		public static Task SetCellTemplateOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxCalendar_SetOption", dxTarget, "cellTemplate", value);
		}
		public static Task<string> GetDateSerializationFormatOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxCalendar_GetOption", dxTarget, "dateSerializationFormat");
		}
		public static Task SetDateSerializationFormatOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxCalendar_SetOption", dxTarget, "dateSerializationFormat", value);
		}
		public static Task<object> GetDisabledDatesOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxCalendar_GetOption", dxTarget, "disabledDates");
		}
		public static Task SetDisabledDatesOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxCalendar_SetOption", dxTarget, "disabledDates", value);
		}
		public static Task<object> GetFirstDayOfWeekOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxCalendar_GetOption", dxTarget, "firstDayOfWeek");
		}
		public static Task SetFirstDayOfWeekOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxCalendar_SetOption", dxTarget, "firstDayOfWeek", value);
		}
		public static Task<object> GetMaxOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxCalendar_GetOption", dxTarget, "max");
		}
		public static Task SetMaxOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxCalendar_SetOption", dxTarget, "max", value);
		}
		public static Task<string> GetMaxZoomLevelOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxCalendar_GetOption", dxTarget, "maxZoomLevel");
		}
		public static Task SetMaxZoomLevelOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxCalendar_SetOption", dxTarget, "maxZoomLevel", value);
		}
		public static Task<object> GetMinOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxCalendar_GetOption", dxTarget, "min");
		}
		public static Task SetMinOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxCalendar_SetOption", dxTarget, "min", value);
		}
		public static Task<string> GetMinZoomLevelOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxCalendar_GetOption", dxTarget, "minZoomLevel");
		}
		public static Task SetMinZoomLevelOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxCalendar_SetOption", dxTarget, "minZoomLevel", value);
		}
		public static Task<string> GetNameOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxCalendar_GetOption", dxTarget, "name");
		}
		public static Task SetNameOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxCalendar_SetOption", dxTarget, "name", value);
		}
		public static Task<bool?> GetShowTodayButtonOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxCalendar_GetOption", dxTarget, "showTodayButton");
		}
		public static Task SetShowTodayButtonOption(ElementRef dxTarget, bool? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxCalendar_SetOption", dxTarget, "showTodayButton", value);
		}
		public static Task<string> GetZoomLevelOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxCalendar_GetOption", dxTarget, "zoomLevel");
		}
		public static Task SetZoomLevelOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxCalendar_SetOption", dxTarget, "zoomLevel", value);
		}
	}
	public class DxCheckBoxInterop: EditorInterop
	{
		public static Task Init(ElementRef dxTarget, DevExpress.Ui.DxCheckBoxOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxCheckBox_Init", dxTarget, json);
		}
		public static Task<string> GetNameOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxCheckBox_GetOption", dxTarget, "name");
		}
		public static Task SetNameOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxCheckBox_SetOption", dxTarget, "name", value);
		}
		public static Task<string> GetTextOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxCheckBox_GetOption", dxTarget, "text");
		}
		public static Task SetTextOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxCheckBox_SetOption", dxTarget, "text", value);
		}
	}
	public class DxColorBoxInterop: DxDropDownEditorInterop
	{
		public static Task Init(ElementRef dxTarget, DevExpress.Ui.DxColorBoxOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxColorBox_Init", dxTarget, json);
		}
		public static Task<string> GetApplyButtonTextOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxColorBox_GetOption", dxTarget, "applyButtonText");
		}
		public static Task SetApplyButtonTextOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxColorBox_SetOption", dxTarget, "applyButtonText", value);
		}
		public static Task<string> GetCancelButtonTextOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxColorBox_GetOption", dxTarget, "cancelButtonText");
		}
		public static Task SetCancelButtonTextOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxColorBox_SetOption", dxTarget, "cancelButtonText", value);
		}
		public static Task<bool?> GetEditAlphaChannelOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxColorBox_GetOption", dxTarget, "editAlphaChannel");
		}
		public static Task SetEditAlphaChannelOption(ElementRef dxTarget, bool? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxColorBox_SetOption", dxTarget, "editAlphaChannel", value);
		}
		public static Task<object> GetFieldTemplateOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxColorBox_GetOption", dxTarget, "fieldTemplate");
		}
		public static Task SetFieldTemplateOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxColorBox_SetOption", dxTarget, "fieldTemplate", value);
		}
		public static Task<float?> GetKeyStepOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_DxColorBox_GetOption", dxTarget, "keyStep");
		}
		public static Task SetKeyStepOption(ElementRef dxTarget, float? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxColorBox_SetOption", dxTarget, "keyStep", value);
		}
	}
	public class DxContextMenuInterop: DxMenuBaseInterop
	{
		public static event EventHandler<JQueryEventArgs> Hidden;
		public static event EventHandler<JQueryEventArgs> Hiding;
		public static event EventHandler<JQueryEventArgs> Positioning;
		public static event EventHandler<JQueryEventArgs> Showing;
		public static event EventHandler<JQueryEventArgs> Shown;
		public static Task Init(ElementRef dxTarget, DevExpress.Ui.DxContextMenuOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxContextMenu_Init", dxTarget, json);
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
		public static Task<object> GetCloseOnOutsideClickOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxContextMenu_GetOption", dxTarget, "closeOnOutsideClick");
		}
		public static Task SetCloseOnOutsideClickOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxContextMenu_SetOption", dxTarget, "closeOnOutsideClick", value);
		}
		public static Task<object> GetPositionOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxContextMenu_GetOption", dxTarget, "position");
		}
		public static Task SetPositionOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxContextMenu_SetOption", dxTarget, "position", value);
		}
		public static Task<object> GetShowEventOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxContextMenu_GetOption", dxTarget, "showEvent");
		}
		public static Task SetShowEventOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxContextMenu_SetOption", dxTarget, "showEvent", value);
		}
		public static Task<string> GetSubmenuDirectionOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxContextMenu_GetOption", dxTarget, "submenuDirection");
		}
		public static Task SetSubmenuDirectionOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxContextMenu_SetOption", dxTarget, "submenuDirection", value);
		}
		public static Task<object> GetTargetOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxContextMenu_GetOption", dxTarget, "target");
		}
		public static Task SetTargetOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxContextMenu_SetOption", dxTarget, "target", value);
		}
		public static Task<object> Hide(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxContextMenu_hide_0", dxTarget);
		}
		public static Task<object> Show(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxContextMenu_show_1", dxTarget);
		}
		public static Task<object> Toggle(ElementRef dxTarget, bool showing)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxContextMenu_toggle_2", dxTarget, showing);
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
		public static Task<bool?> GetAllowColumnReorderingOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_GridBase_GetOption", dxTarget, "allowColumnReordering");
		}
		public static Task SetAllowColumnReorderingOption(ElementRef dxTarget, bool? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_SetOption", dxTarget, "allowColumnReordering", value);
		}
		public static Task<bool?> GetAllowColumnResizingOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_GridBase_GetOption", dxTarget, "allowColumnResizing");
		}
		public static Task SetAllowColumnResizingOption(ElementRef dxTarget, bool? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_SetOption", dxTarget, "allowColumnResizing", value);
		}
		public static Task<bool?> GetCacheEnabledOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_GridBase_GetOption", dxTarget, "cacheEnabled");
		}
		public static Task SetCacheEnabledOption(ElementRef dxTarget, bool? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_SetOption", dxTarget, "cacheEnabled", value);
		}
		public static Task<bool?> GetCellHintEnabledOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_GridBase_GetOption", dxTarget, "cellHintEnabled");
		}
		public static Task SetCellHintEnabledOption(ElementRef dxTarget, bool? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_SetOption", dxTarget, "cellHintEnabled", value);
		}
		public static Task<bool?> GetColumnAutoWidthOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_GridBase_GetOption", dxTarget, "columnAutoWidth");
		}
		public static Task SetColumnAutoWidthOption(ElementRef dxTarget, bool? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_SetOption", dxTarget, "columnAutoWidth", value);
		}
		public static Task<object> GetColumnChooserOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_GetOption", dxTarget, "columnChooser");
		}
		public static Task SetColumnChooserOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_SetOption", dxTarget, "columnChooser", value);
		}
		public static Task<object> GetColumnFixingOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_GetOption", dxTarget, "columnFixing");
		}
		public static Task SetColumnFixingOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_SetOption", dxTarget, "columnFixing", value);
		}
		public static Task<bool?> GetColumnHidingEnabledOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_GridBase_GetOption", dxTarget, "columnHidingEnabled");
		}
		public static Task SetColumnHidingEnabledOption(ElementRef dxTarget, bool? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_SetOption", dxTarget, "columnHidingEnabled", value);
		}
		public static Task<float?> GetColumnMinWidthOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_GridBase_GetOption", dxTarget, "columnMinWidth");
		}
		public static Task SetColumnMinWidthOption(ElementRef dxTarget, float? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_SetOption", dxTarget, "columnMinWidth", value);
		}
		public static Task<string> GetColumnResizingModeOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_GridBase_GetOption", dxTarget, "columnResizingMode");
		}
		public static Task SetColumnResizingModeOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_SetOption", dxTarget, "columnResizingMode", value);
		}
		public static Task<object> GetColumnsOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_GetOption", dxTarget, "columns");
		}
		public static Task SetColumnsOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_SetOption", dxTarget, "columns", value);
		}
		public static Task<float?> GetColumnWidthOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_GridBase_GetOption", dxTarget, "columnWidth");
		}
		public static Task SetColumnWidthOption(ElementRef dxTarget, float? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_SetOption", dxTarget, "columnWidth", value);
		}
		public static Task<object> GetDataSourceOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_GetOption", dxTarget, "dataSource");
		}
		public static Task SetDataSourceOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_SetOption", dxTarget, "dataSource", value);
		}
		public static Task<string> GetDateSerializationFormatOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_GridBase_GetOption", dxTarget, "dateSerializationFormat");
		}
		public static Task SetDateSerializationFormatOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_SetOption", dxTarget, "dateSerializationFormat", value);
		}
		public static Task<object> GetEditingOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_GetOption", dxTarget, "editing");
		}
		public static Task SetEditingOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_SetOption", dxTarget, "editing", value);
		}
		public static Task<bool?> GetErrorRowEnabledOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_GridBase_GetOption", dxTarget, "errorRowEnabled");
		}
		public static Task SetErrorRowEnabledOption(ElementRef dxTarget, bool? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_SetOption", dxTarget, "errorRowEnabled", value);
		}
		public static Task<object> GetFilterBuilderOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_GetOption", dxTarget, "filterBuilder");
		}
		public static Task SetFilterBuilderOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_SetOption", dxTarget, "filterBuilder", value);
		}
		public static Task<object> GetFilterBuilderPopupOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_GetOption", dxTarget, "filterBuilderPopup");
		}
		public static Task SetFilterBuilderPopupOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_SetOption", dxTarget, "filterBuilderPopup", value);
		}
		public static Task<object> GetFilterPanelOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_GetOption", dxTarget, "filterPanel");
		}
		public static Task SetFilterPanelOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_SetOption", dxTarget, "filterPanel", value);
		}
		public static Task<object> GetFilterRowOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_GetOption", dxTarget, "filterRow");
		}
		public static Task SetFilterRowOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_SetOption", dxTarget, "filterRow", value);
		}
		public static Task<object> GetFilterSyncEnabledOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_GetOption", dxTarget, "filterSyncEnabled");
		}
		public static Task SetFilterSyncEnabledOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_SetOption", dxTarget, "filterSyncEnabled", value);
		}
		public static Task<object> GetFilterValueOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_GetOption", dxTarget, "filterValue");
		}
		public static Task SetFilterValueOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_SetOption", dxTarget, "filterValue", value);
		}
		public static Task<float?> GetFocusedColumnIndexOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_GridBase_GetOption", dxTarget, "focusedColumnIndex");
		}
		public static Task SetFocusedColumnIndexOption(ElementRef dxTarget, float? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_SetOption", dxTarget, "focusedColumnIndex", value);
		}
		public static Task<bool?> GetFocusedRowEnabledOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_GridBase_GetOption", dxTarget, "focusedRowEnabled");
		}
		public static Task SetFocusedRowEnabledOption(ElementRef dxTarget, bool? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_SetOption", dxTarget, "focusedRowEnabled", value);
		}
		public static Task<float?> GetFocusedRowIndexOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_GridBase_GetOption", dxTarget, "focusedRowIndex");
		}
		public static Task SetFocusedRowIndexOption(ElementRef dxTarget, float? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_SetOption", dxTarget, "focusedRowIndex", value);
		}
		public static Task<object> GetFocusedRowKeyOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_GetOption", dxTarget, "focusedRowKey");
		}
		public static Task SetFocusedRowKeyOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_SetOption", dxTarget, "focusedRowKey", value);
		}
		public static Task<object> GetHeaderFilterOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_GetOption", dxTarget, "headerFilter");
		}
		public static Task SetHeaderFilterOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_SetOption", dxTarget, "headerFilter", value);
		}
		public static Task<bool?> GetHighlightChangesOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_GridBase_GetOption", dxTarget, "highlightChanges");
		}
		public static Task SetHighlightChangesOption(ElementRef dxTarget, bool? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_SetOption", dxTarget, "highlightChanges", value);
		}
		public static Task<object> GetLoadPanelOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_GetOption", dxTarget, "loadPanel");
		}
		public static Task SetLoadPanelOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_SetOption", dxTarget, "loadPanel", value);
		}
		public static Task<string> GetNoDataTextOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_GridBase_GetOption", dxTarget, "noDataText");
		}
		public static Task SetNoDataTextOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_SetOption", dxTarget, "noDataText", value);
		}
		public static Task<object> GetPagerOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_GetOption", dxTarget, "pager");
		}
		public static Task SetPagerOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_SetOption", dxTarget, "pager", value);
		}
		public static Task<object> GetPagingOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_GetOption", dxTarget, "paging");
		}
		public static Task SetPagingOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_SetOption", dxTarget, "paging", value);
		}
		public static Task<bool?> GetRenderAsyncOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_GridBase_GetOption", dxTarget, "renderAsync");
		}
		public static Task SetRenderAsyncOption(ElementRef dxTarget, bool? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_SetOption", dxTarget, "renderAsync", value);
		}
		public static Task<bool?> GetRepaintChangesOnlyOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_GridBase_GetOption", dxTarget, "repaintChangesOnly");
		}
		public static Task SetRepaintChangesOnlyOption(ElementRef dxTarget, bool? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_SetOption", dxTarget, "repaintChangesOnly", value);
		}
		public static Task<bool?> GetRowAlternationEnabledOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_GridBase_GetOption", dxTarget, "rowAlternationEnabled");
		}
		public static Task SetRowAlternationEnabledOption(ElementRef dxTarget, bool? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_SetOption", dxTarget, "rowAlternationEnabled", value);
		}
		public static Task<object> GetScrollingOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_GetOption", dxTarget, "scrolling");
		}
		public static Task SetScrollingOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_SetOption", dxTarget, "scrolling", value);
		}
		public static Task<object> GetSearchPanelOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_GetOption", dxTarget, "searchPanel");
		}
		public static Task SetSearchPanelOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_SetOption", dxTarget, "searchPanel", value);
		}
		public static Task<object> GetSelectedRowKeysOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_GetOption", dxTarget, "selectedRowKeys");
		}
		public static Task SetSelectedRowKeysOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_SetOption", dxTarget, "selectedRowKeys", value);
		}
		public static Task<object> GetSelectionOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_GetOption", dxTarget, "selection");
		}
		public static Task SetSelectionOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_SetOption", dxTarget, "selection", value);
		}
		public static Task<bool?> GetShowBordersOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_GridBase_GetOption", dxTarget, "showBorders");
		}
		public static Task SetShowBordersOption(ElementRef dxTarget, bool? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_SetOption", dxTarget, "showBorders", value);
		}
		public static Task<bool?> GetShowColumnHeadersOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_GridBase_GetOption", dxTarget, "showColumnHeaders");
		}
		public static Task SetShowColumnHeadersOption(ElementRef dxTarget, bool? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_SetOption", dxTarget, "showColumnHeaders", value);
		}
		public static Task<bool?> GetShowColumnLinesOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_GridBase_GetOption", dxTarget, "showColumnLines");
		}
		public static Task SetShowColumnLinesOption(ElementRef dxTarget, bool? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_SetOption", dxTarget, "showColumnLines", value);
		}
		public static Task<bool?> GetShowRowLinesOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_GridBase_GetOption", dxTarget, "showRowLines");
		}
		public static Task SetShowRowLinesOption(ElementRef dxTarget, bool? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_SetOption", dxTarget, "showRowLines", value);
		}
		public static Task<object> GetSortingOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_GetOption", dxTarget, "sorting");
		}
		public static Task SetSortingOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_SetOption", dxTarget, "sorting", value);
		}
		public static Task<object> GetStateStoringOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_GetOption", dxTarget, "stateStoring");
		}
		public static Task SetStateStoringOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_SetOption", dxTarget, "stateStoring", value);
		}
		public static Task<bool?> GetTwoWayBindingEnabledOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_GridBase_GetOption", dxTarget, "twoWayBindingEnabled");
		}
		public static Task SetTwoWayBindingEnabledOption(ElementRef dxTarget, bool? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_SetOption", dxTarget, "twoWayBindingEnabled", value);
		}
		public static Task<bool?> GetWordWrapEnabledOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_GridBase_GetOption", dxTarget, "wordWrapEnabled");
		}
		public static Task SetWordWrapEnabledOption(ElementRef dxTarget, bool? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_SetOption", dxTarget, "wordWrapEnabled", value);
		}
		public static Task BeginCustomLoading(ElementRef dxTarget, string messageText)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_beginCustomLoading_0", dxTarget, messageText);
		}
		public static Task<object> ByKey(ElementRef dxTarget, object key)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_byKey_1", dxTarget, key);
		}
		public static Task CancelEditData(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_cancelEditData_2", dxTarget);
		}
		public static Task<object> CellValue(ElementRef dxTarget, float rowIndex, string dataField)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_cellValue_3", dxTarget, rowIndex, dataField);
		}
		public static Task CellValue(ElementRef dxTarget, float rowIndex, string dataField, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_cellValue_4", dxTarget, rowIndex, dataField, value);
		}
		public static Task<object> CellValue(ElementRef dxTarget, float rowIndex, float visibleColumnIndex)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_cellValue_5", dxTarget, rowIndex, visibleColumnIndex);
		}
		public static Task CellValue(ElementRef dxTarget, float rowIndex, float visibleColumnIndex, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_cellValue_6", dxTarget, rowIndex, visibleColumnIndex, value);
		}
		public static Task ClearFilter(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_clearFilter_7", dxTarget);
		}
		public static Task ClearFilter(ElementRef dxTarget, string filterName)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_clearFilter_8", dxTarget, filterName);
		}
		public static Task ClearSelection(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_clearSelection_9", dxTarget);
		}
		public static Task ClearSorting(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_clearSorting_10", dxTarget);
		}
		public static Task CloseEditCell(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_closeEditCell_11", dxTarget);
		}
		public static Task CollapseAdaptiveDetailRow(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_collapseAdaptiveDetailRow_12", dxTarget);
		}
		public static Task<float> ColumnCount(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<float>("BlazorDevExtreme_GridBase_columnCount_13", dxTarget);
		}
		public static Task<object> ColumnOption(ElementRef dxTarget, object id)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_columnOption_14", dxTarget, id);
		}
		public static Task<object> ColumnOption(ElementRef dxTarget, object id, string optionName)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_columnOption_15", dxTarget, id, optionName);
		}
		public static Task ColumnOption(ElementRef dxTarget, object id, string optionName, object optionValue)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_columnOption_16", dxTarget, id, optionName, optionValue);
		}
		public static Task ColumnOption(ElementRef dxTarget, object id, object options)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_columnOption_17", dxTarget, id, options);
		}
		public static Task DeleteColumn(ElementRef dxTarget, object id)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_deleteColumn_18", dxTarget, id);
		}
		public static Task DeleteRow(ElementRef dxTarget, float rowIndex)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_deleteRow_19", dxTarget, rowIndex);
		}
		public static Task<object> DeselectAll(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_deselectAll_20", dxTarget);
		}
		public static Task<object> DeselectRows(ElementRef dxTarget, object keys)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_deselectRows_21", dxTarget, keys);
		}
		public static Task EditCell(ElementRef dxTarget, float rowIndex, string dataField)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_editCell_22", dxTarget, rowIndex, dataField);
		}
		public static Task EditCell(ElementRef dxTarget, float rowIndex, float visibleColumnIndex)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_editCell_23", dxTarget, rowIndex, visibleColumnIndex);
		}
		public static Task EditRow(ElementRef dxTarget, float rowIndex)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_editRow_24", dxTarget, rowIndex);
		}
		public static Task EndCustomLoading(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_endCustomLoading_25", dxTarget);
		}
		public static Task ExpandAdaptiveDetailRow(ElementRef dxTarget, object key)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_expandAdaptiveDetailRow_26", dxTarget, key);
		}
		public static Task<object> Filter(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_filter_27", dxTarget);
		}
		public static Task Filter(ElementRef dxTarget, object filterExpr)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_filter_28", dxTarget, filterExpr);
		}
		public static Task Focus(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_focus_29", dxTarget);
		}
		public static Task Focus(ElementRef dxTarget, object element)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_focus_30", dxTarget, element);
		}
		public static Task<object> GetCellElement(ElementRef dxTarget, float rowIndex, string dataField)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_getCellElement_31", dxTarget, rowIndex, dataField);
		}
		public static Task<object> GetCellElement(ElementRef dxTarget, float rowIndex, float visibleColumnIndex)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_getCellElement_32", dxTarget, rowIndex, visibleColumnIndex);
		}
		public static Task<object> GetCombinedFilter(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_getCombinedFilter_33", dxTarget);
		}
		public static Task<object> GetCombinedFilter(ElementRef dxTarget, bool returnDataField)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_getCombinedFilter_34", dxTarget, returnDataField);
		}
		public static Task<object> GetDataSourceEx(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_getDataSource_35", dxTarget);
		}
		public static Task<object> GetKeyByRowIndex(ElementRef dxTarget, float rowIndex)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_getKeyByRowIndex_36", dxTarget, rowIndex);
		}
		public static Task<object> GetRowElement(ElementRef dxTarget, float rowIndex)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_getRowElement_37", dxTarget, rowIndex);
		}
		public static Task<float> GetRowIndexByKey(ElementRef dxTarget, object key)
		{
			return JSRuntime.Current.InvokeAsync<float>("BlazorDevExtreme_GridBase_getRowIndexByKey_38", dxTarget, key);
		}
		public static Task<object> GetScrollable(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_getScrollable_39", dxTarget);
		}
		public static Task<bool> HasEditData(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool>("BlazorDevExtreme_GridBase_hasEditData_40", dxTarget);
		}
		public static Task HideColumnChooser(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_hideColumnChooser_41", dxTarget);
		}
		public static Task<bool> IsAdaptiveDetailRowExpanded(ElementRef dxTarget, object key)
		{
			return JSRuntime.Current.InvokeAsync<bool>("BlazorDevExtreme_GridBase_isAdaptiveDetailRowExpanded_42", dxTarget, key);
		}
		public static Task<bool> IsRowFocused(ElementRef dxTarget, object key)
		{
			return JSRuntime.Current.InvokeAsync<bool>("BlazorDevExtreme_GridBase_isRowFocused_43", dxTarget, key);
		}
		public static Task<bool> IsRowSelected(ElementRef dxTarget, object key)
		{
			return JSRuntime.Current.InvokeAsync<bool>("BlazorDevExtreme_GridBase_isRowSelected_44", dxTarget, key);
		}
		public static Task<object> KeyOf(ElementRef dxTarget, object obj)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_keyOf_45", dxTarget, obj);
		}
		public static Task NavigateToRow(ElementRef dxTarget, object key)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_navigateToRow_46", dxTarget, key);
		}
		public static Task<float> PageCount(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<float>("BlazorDevExtreme_GridBase_pageCount_47", dxTarget);
		}
		public static Task<float> PageIndex(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<float>("BlazorDevExtreme_GridBase_pageIndex_48", dxTarget);
		}
		public static Task<object> PageIndex(ElementRef dxTarget, float newIndex)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_pageIndex_49", dxTarget, newIndex);
		}
		public static Task<float> PageSize(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<float>("BlazorDevExtreme_GridBase_pageSize_50", dxTarget);
		}
		public static Task PageSize(ElementRef dxTarget, float value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_pageSize_51", dxTarget, value);
		}
		public static Task<object> Refresh(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_refresh_52", dxTarget);
		}
		public static Task<object> Refresh(ElementRef dxTarget, bool changesOnly)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_refresh_53", dxTarget, changesOnly);
		}
		public static Task RepaintRows(ElementRef dxTarget, object rowIndexes)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_repaintRows_54", dxTarget, rowIndexes);
		}
		public static Task<object> SaveEditData(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_saveEditData_55", dxTarget);
		}
		public static Task SearchByText(ElementRef dxTarget, string text)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_searchByText_56", dxTarget, text);
		}
		public static Task<object> SelectAll(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_selectAll_57", dxTarget);
		}
		public static Task<object> SelectRows(ElementRef dxTarget, object keys, bool preserve)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_selectRows_58", dxTarget, keys, preserve);
		}
		public static Task<object> SelectRowsByIndexes(ElementRef dxTarget, object indexes)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_selectRowsByIndexes_59", dxTarget, indexes);
		}
		public static Task ShowColumnChooser(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_showColumnChooser_60", dxTarget);
		}
		public static Task<object> State(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_state_61", dxTarget);
		}
		public static Task State(ElementRef dxTarget, object state)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_state_62", dxTarget, state);
		}
		public static Task UndeleteRow(ElementRef dxTarget, float rowIndex)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_undeleteRow_63", dxTarget, rowIndex);
		}
		public static Task UpdateDimensions(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_updateDimensions_64", dxTarget);
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
		public static event EventHandler<JQueryEventArgs> FocusedCellChanged;
		public static event EventHandler<JQueryEventArgs> FocusedCellChanging;
		public static event EventHandler<JQueryEventArgs> FocusedRowChanged;
		public static event EventHandler<JQueryEventArgs> FocusedRowChanging;
		public static event EventHandler<JQueryEventArgs> RowClick;
		public static event EventHandler<JQueryEventArgs> RowPrepared;
		public static Task Init(ElementRef dxTarget, DevExpress.Ui.DxDataGridOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDataGrid_Init", dxTarget, json);
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
		[JSInvokable("DevExpress.Ui.DxDataGridInterop.OnFocusedCellChanged")]
		public static void OnFocusedCellChanged(string identifier)
		{
			FocusedCellChanged?.Invoke(null, new JQueryEventArgs(identifier));
		}
		[JSInvokable("DevExpress.Ui.DxDataGridInterop.OnFocusedCellChanging")]
		public static void OnFocusedCellChanging(string identifier)
		{
			FocusedCellChanging?.Invoke(null, new JQueryEventArgs(identifier));
		}
		[JSInvokable("DevExpress.Ui.DxDataGridInterop.OnFocusedRowChanged")]
		public static void OnFocusedRowChanged(string identifier)
		{
			FocusedRowChanged?.Invoke(null, new JQueryEventArgs(identifier));
		}
		[JSInvokable("DevExpress.Ui.DxDataGridInterop.OnFocusedRowChanging")]
		public static void OnFocusedRowChanging(string identifier)
		{
			FocusedRowChanging?.Invoke(null, new JQueryEventArgs(identifier));
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
		public static Task<object> GetCustomizeColumnsOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDataGrid_GetOption", dxTarget, "customizeColumns");
		}
		public static Task SetCustomizeColumnsOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDataGrid_SetOption", dxTarget, "customizeColumns", value);
		}
		public static Task<object> GetCustomizeExportDataOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDataGrid_GetOption", dxTarget, "customizeExportData");
		}
		public static Task SetCustomizeExportDataOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDataGrid_SetOption", dxTarget, "customizeExportData", value);
		}
		public static Task<object> GetExportOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDataGrid_GetOption", dxTarget, "export");
		}
		public static Task SetExportOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDataGrid_SetOption", dxTarget, "export", value);
		}
		public static Task<object> GetGroupingOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDataGrid_GetOption", dxTarget, "grouping");
		}
		public static Task SetGroupingOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDataGrid_SetOption", dxTarget, "grouping", value);
		}
		public static Task<object> GetGroupPanelOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDataGrid_GetOption", dxTarget, "groupPanel");
		}
		public static Task SetGroupPanelOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDataGrid_SetOption", dxTarget, "groupPanel", value);
		}
		public static Task<object> GetKeyExprOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDataGrid_GetOption", dxTarget, "keyExpr");
		}
		public static Task SetKeyExprOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDataGrid_SetOption", dxTarget, "keyExpr", value);
		}
		public static Task<object> GetMasterDetailOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDataGrid_GetOption", dxTarget, "masterDetail");
		}
		public static Task SetMasterDetailOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDataGrid_SetOption", dxTarget, "masterDetail", value);
		}
		public static Task<object> GetRemoteOperationsOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDataGrid_GetOption", dxTarget, "remoteOperations");
		}
		public static Task SetRemoteOperationsOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDataGrid_SetOption", dxTarget, "remoteOperations", value);
		}
		public static Task<object> GetRowTemplateOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDataGrid_GetOption", dxTarget, "rowTemplate");
		}
		public static Task SetRowTemplateOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDataGrid_SetOption", dxTarget, "rowTemplate", value);
		}
		public static Task<object> GetSelectionFilterOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDataGrid_GetOption", dxTarget, "selectionFilter");
		}
		public static Task SetSelectionFilterOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDataGrid_SetOption", dxTarget, "selectionFilter", value);
		}
		public static Task<object> GetSortByGroupSummaryInfoOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDataGrid_GetOption", dxTarget, "sortByGroupSummaryInfo");
		}
		public static Task SetSortByGroupSummaryInfoOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDataGrid_SetOption", dxTarget, "sortByGroupSummaryInfo", value);
		}
		public static Task<object> GetSummaryOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDataGrid_GetOption", dxTarget, "summary");
		}
		public static Task SetSummaryOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDataGrid_SetOption", dxTarget, "summary", value);
		}
		public static Task AddColumn(ElementRef dxTarget, object columnOptions)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDataGrid_addColumn_0", dxTarget, columnOptions);
		}
		public static Task AddRow(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDataGrid_addRow_1", dxTarget);
		}
		public static Task ClearGrouping(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDataGrid_clearGrouping_2", dxTarget);
		}
		public static Task CollapseAll(ElementRef dxTarget, float groupIndex)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDataGrid_collapseAll_3", dxTarget, groupIndex);
		}
		public static Task<object> CollapseRow(ElementRef dxTarget, object key)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDataGrid_collapseRow_4", dxTarget, key);
		}
		public static Task ExpandAll(ElementRef dxTarget, float groupIndex)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDataGrid_expandAll_5", dxTarget, groupIndex);
		}
		public static Task<object> ExpandRow(ElementRef dxTarget, object key)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDataGrid_expandRow_6", dxTarget, key);
		}
		public static Task ExportToExcel(ElementRef dxTarget, bool selectionOnly)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDataGrid_exportToExcel_7", dxTarget, selectionOnly);
		}
		public static Task<object> GetSelectedRowKeys(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDataGrid_getSelectedRowKeys_8", dxTarget);
		}
		public static Task<object> GetSelectedRowsData(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDataGrid_getSelectedRowsData_9", dxTarget);
		}
		public static Task<object> GetTotalSummaryValue(ElementRef dxTarget, string summaryItemName)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDataGrid_getTotalSummaryValue_10", dxTarget, summaryItemName);
		}
		public static Task<object> GetVisibleColumns(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDataGrid_getVisibleColumns_11", dxTarget);
		}
		public static Task<object> GetVisibleColumns(ElementRef dxTarget, float headerLevel)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDataGrid_getVisibleColumns_12", dxTarget, headerLevel);
		}
		public static Task<object> GetVisibleRows(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDataGrid_getVisibleRows_13", dxTarget);
		}
		public static Task InsertRow(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDataGrid_insertRow_14", dxTarget);
		}
		public static Task<bool> IsRowExpanded(ElementRef dxTarget, object key)
		{
			return JSRuntime.Current.InvokeAsync<bool>("BlazorDevExtreme_DxDataGrid_isRowExpanded_15", dxTarget, key);
		}
		public static Task<bool> IsRowSelected(ElementRef dxTarget, object data)
		{
			return JSRuntime.Current.InvokeAsync<bool>("BlazorDevExtreme_DxDataGrid_isRowSelected_16", dxTarget, data);
		}
		public static Task RemoveRow(ElementRef dxTarget, float rowIndex)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDataGrid_removeRow_18", dxTarget, rowIndex);
		}
		public static Task<float> TotalCount(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<float>("BlazorDevExtreme_DxDataGrid_totalCount_19", dxTarget);
		}
	}
	public class DxDateBoxInterop: DxDropDownEditorInterop
	{
		public static Task Init(ElementRef dxTarget, DevExpress.Ui.DxDateBoxOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDateBox_Init", dxTarget, json);
		}
		public static Task<bool?> GetAdaptivityEnabledOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxDateBox_GetOption", dxTarget, "adaptivityEnabled");
		}
		public static Task SetAdaptivityEnabledOption(ElementRef dxTarget, bool? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDateBox_SetOption", dxTarget, "adaptivityEnabled", value);
		}
		public static Task<string> GetApplyButtonTextOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxDateBox_GetOption", dxTarget, "applyButtonText");
		}
		public static Task SetApplyButtonTextOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDateBox_SetOption", dxTarget, "applyButtonText", value);
		}
		public static Task<object> GetCalendarOptionsOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDateBox_GetOption", dxTarget, "calendarOptions");
		}
		public static Task SetCalendarOptionsOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDateBox_SetOption", dxTarget, "calendarOptions", value);
		}
		public static Task<string> GetCancelButtonTextOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxDateBox_GetOption", dxTarget, "cancelButtonText");
		}
		public static Task SetCancelButtonTextOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDateBox_SetOption", dxTarget, "cancelButtonText", value);
		}
		public static Task<string> GetDateOutOfRangeMessageOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxDateBox_GetOption", dxTarget, "dateOutOfRangeMessage");
		}
		public static Task SetDateOutOfRangeMessageOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDateBox_SetOption", dxTarget, "dateOutOfRangeMessage", value);
		}
		public static Task<string> GetDateSerializationFormatOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxDateBox_GetOption", dxTarget, "dateSerializationFormat");
		}
		public static Task SetDateSerializationFormatOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDateBox_SetOption", dxTarget, "dateSerializationFormat", value);
		}
		public static Task<object> GetDisabledDatesOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDateBox_GetOption", dxTarget, "disabledDates");
		}
		public static Task SetDisabledDatesOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDateBox_SetOption", dxTarget, "disabledDates", value);
		}
		public static Task<object> GetDisplayFormatOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDateBox_GetOption", dxTarget, "displayFormat");
		}
		public static Task SetDisplayFormatOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDateBox_SetOption", dxTarget, "displayFormat", value);
		}
		public static Task<float?> GetIntervalOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_DxDateBox_GetOption", dxTarget, "interval");
		}
		public static Task SetIntervalOption(ElementRef dxTarget, float? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDateBox_SetOption", dxTarget, "interval", value);
		}
		public static Task<string> GetInvalidDateMessageOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxDateBox_GetOption", dxTarget, "invalidDateMessage");
		}
		public static Task SetInvalidDateMessageOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDateBox_SetOption", dxTarget, "invalidDateMessage", value);
		}
		public static Task<object> GetMaxOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDateBox_GetOption", dxTarget, "max");
		}
		public static Task SetMaxOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDateBox_SetOption", dxTarget, "max", value);
		}
		public static Task<string> GetMaxZoomLevelOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxDateBox_GetOption", dxTarget, "maxZoomLevel");
		}
		public static Task SetMaxZoomLevelOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDateBox_SetOption", dxTarget, "maxZoomLevel", value);
		}
		public static Task<object> GetMinOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDateBox_GetOption", dxTarget, "min");
		}
		public static Task SetMinOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDateBox_SetOption", dxTarget, "min", value);
		}
		public static Task<string> GetMinZoomLevelOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxDateBox_GetOption", dxTarget, "minZoomLevel");
		}
		public static Task SetMinZoomLevelOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDateBox_SetOption", dxTarget, "minZoomLevel", value);
		}
		public static Task<string> GetPickerTypeOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxDateBox_GetOption", dxTarget, "pickerType");
		}
		public static Task SetPickerTypeOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDateBox_SetOption", dxTarget, "pickerType", value);
		}
		public static Task<bool?> GetShowAnalogClockOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxDateBox_GetOption", dxTarget, "showAnalogClock");
		}
		public static Task SetShowAnalogClockOption(ElementRef dxTarget, bool? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDateBox_SetOption", dxTarget, "showAnalogClock", value);
		}
		public static Task<string> GetTypeOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxDateBox_GetOption", dxTarget, "type");
		}
		public static Task SetTypeOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDateBox_SetOption", dxTarget, "type", value);
		}
		public static Task<bool?> GetUseMaskBehaviorOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxDateBox_GetOption", dxTarget, "useMaskBehavior");
		}
		public static Task SetUseMaskBehaviorOption(ElementRef dxTarget, bool? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDateBox_SetOption", dxTarget, "useMaskBehavior", value);
		}
		public static Task Close(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDateBox_close_0", dxTarget);
		}
		public static Task Open(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDateBox_open_1", dxTarget);
		}
	}
	public class DxDeferRenderingInterop: WidgetInterop
	{
		public static event EventHandler<JQueryEventArgs> Rendered;
		public static event EventHandler<JQueryEventArgs> Shown;
		public static Task Init(ElementRef dxTarget, DevExpress.Ui.DxDeferRenderingOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDeferRendering_Init", dxTarget, json);
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
		public static Task<object> GetAnimationOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDeferRendering_GetOption", dxTarget, "animation");
		}
		public static Task SetAnimationOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDeferRendering_SetOption", dxTarget, "animation", value);
		}
		public static Task<object> GetRenderWhenOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDeferRendering_GetOption", dxTarget, "renderWhen");
		}
		public static Task SetRenderWhenOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDeferRendering_SetOption", dxTarget, "renderWhen", value);
		}
		public static Task<bool?> GetShowLoadIndicatorOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxDeferRendering_GetOption", dxTarget, "showLoadIndicator");
		}
		public static Task SetShowLoadIndicatorOption(ElementRef dxTarget, bool? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDeferRendering_SetOption", dxTarget, "showLoadIndicator", value);
		}
		public static Task<string> GetStaggerItemSelectorOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxDeferRendering_GetOption", dxTarget, "staggerItemSelector");
		}
		public static Task SetStaggerItemSelectorOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDeferRendering_SetOption", dxTarget, "staggerItemSelector", value);
		}
	}
	public class DxDrawerInterop: WidgetInterop
	{
		public static Task Init(ElementRef dxTarget, DevExpress.Ui.DxDrawerOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDrawer_Init", dxTarget, json);
		}
		public static Task<float?> GetAnimationDurationOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_DxDrawer_GetOption", dxTarget, "animationDuration");
		}
		public static Task SetAnimationDurationOption(ElementRef dxTarget, float? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDrawer_SetOption", dxTarget, "animationDuration", value);
		}
		public static Task<bool?> GetAnimationEnabledOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxDrawer_GetOption", dxTarget, "animationEnabled");
		}
		public static Task SetAnimationEnabledOption(ElementRef dxTarget, bool? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDrawer_SetOption", dxTarget, "animationEnabled", value);
		}
		public static Task<object> GetCloseOnOutsideClickOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDrawer_GetOption", dxTarget, "closeOnOutsideClick");
		}
		public static Task SetCloseOnOutsideClickOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDrawer_SetOption", dxTarget, "closeOnOutsideClick", value);
		}
		public static Task<float?> GetMaxSizeOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_DxDrawer_GetOption", dxTarget, "maxSize");
		}
		public static Task SetMaxSizeOption(ElementRef dxTarget, float? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDrawer_SetOption", dxTarget, "maxSize", value);
		}
		public static Task<float?> GetMinSizeOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_DxDrawer_GetOption", dxTarget, "minSize");
		}
		public static Task SetMinSizeOption(ElementRef dxTarget, float? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDrawer_SetOption", dxTarget, "minSize", value);
		}
		public static Task<bool?> GetOpenedOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxDrawer_GetOption", dxTarget, "opened");
		}
		public static Task SetOpenedOption(ElementRef dxTarget, bool? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDrawer_SetOption", dxTarget, "opened", value);
		}
		public static Task<string> GetOpenedStateModeOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxDrawer_GetOption", dxTarget, "openedStateMode");
		}
		public static Task SetOpenedStateModeOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDrawer_SetOption", dxTarget, "openedStateMode", value);
		}
		public static Task<string> GetPositionOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxDrawer_GetOption", dxTarget, "position");
		}
		public static Task SetPositionOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDrawer_SetOption", dxTarget, "position", value);
		}
		public static Task<string> GetRevealModeOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxDrawer_GetOption", dxTarget, "revealMode");
		}
		public static Task SetRevealModeOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDrawer_SetOption", dxTarget, "revealMode", value);
		}
		public static Task<bool?> GetShadingOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxDrawer_GetOption", dxTarget, "shading");
		}
		public static Task SetShadingOption(ElementRef dxTarget, bool? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDrawer_SetOption", dxTarget, "shading", value);
		}
		public static Task<object> GetTargetOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDrawer_GetOption", dxTarget, "target");
		}
		public static Task SetTargetOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDrawer_SetOption", dxTarget, "target", value);
		}
		public static Task<object> GetTemplateOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDrawer_GetOption", dxTarget, "template");
		}
		public static Task SetTemplateOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDrawer_SetOption", dxTarget, "template", value);
		}
		public static Task<object> Content(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDrawer_content_0", dxTarget);
		}
		public static Task<object> Hide(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDrawer_hide_1", dxTarget);
		}
		public static Task<object> Show(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDrawer_show_2", dxTarget);
		}
		public static Task<object> Toggle(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDrawer_toggle_3", dxTarget);
		}
	}
	public class DxDropDownBoxInterop: DxDropDownEditorInterop
	{
		public static Task Init(ElementRef dxTarget, DevExpress.Ui.DxDropDownBoxOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDropDownBox_Init", dxTarget, json);
		}
		public static Task<object> GetContentTemplateOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDropDownBox_GetOption", dxTarget, "contentTemplate");
		}
		public static Task SetContentTemplateOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDropDownBox_SetOption", dxTarget, "contentTemplate", value);
		}
		public static Task<object> GetDropDownOptionsOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDropDownBox_GetOption", dxTarget, "dropDownOptions");
		}
		public static Task SetDropDownOptionsOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDropDownBox_SetOption", dxTarget, "dropDownOptions", value);
		}
		public static Task<object> GetFieldTemplateOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDropDownBox_GetOption", dxTarget, "fieldTemplate");
		}
		public static Task SetFieldTemplateOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDropDownBox_SetOption", dxTarget, "fieldTemplate", value);
		}
		public static Task<object> GetDataSourceOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDropDownBox_GetOption", dxTarget, "dataSource");
		}
		public static Task SetDataSourceOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDropDownBox_SetOption", dxTarget, "dataSource", value);
		}
		public static Task<object> GetDisplayExprOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDropDownBox_GetOption", dxTarget, "displayExpr");
		}
		public static Task SetDisplayExprOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDropDownBox_SetOption", dxTarget, "displayExpr", value);
		}
		public static Task<object> GetItemsOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDropDownBox_GetOption", dxTarget, "items");
		}
		public static Task SetItemsOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDropDownBox_SetOption", dxTarget, "items", value);
		}
		public static Task<object> GetItemTemplateOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDropDownBox_GetOption", dxTarget, "itemTemplate");
		}
		public static Task SetItemTemplateOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDropDownBox_SetOption", dxTarget, "itemTemplate", value);
		}
		public static Task<object> GetValueExprOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDropDownBox_GetOption", dxTarget, "valueExpr");
		}
		public static Task SetValueExprOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDropDownBox_SetOption", dxTarget, "valueExpr", value);
		}
		public static Task<object> GetDataSourceEx(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDropDownBox_getDataSource_0", dxTarget);
		}
	}
	public class DxDropDownMenuInterop: WidgetInterop
	{
		public static event EventHandler<JQueryEventArgs> ButtonClick;
		public static event EventHandler<JQueryEventArgs> ItemClick;
		public static Task Init(ElementRef dxTarget, DevExpress.Ui.DxDropDownMenuOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDropDownMenu_Init", dxTarget, json);
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
		public static Task<string> GetButtonIconOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxDropDownMenu_GetOption", dxTarget, "buttonIcon");
		}
		public static Task SetButtonIconOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDropDownMenu_SetOption", dxTarget, "buttonIcon", value);
		}
		public static Task<string> GetButtonTextOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxDropDownMenu_GetOption", dxTarget, "buttonText");
		}
		public static Task SetButtonTextOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDropDownMenu_SetOption", dxTarget, "buttonText", value);
		}
		public static Task<object> GetDataSourceOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDropDownMenu_GetOption", dxTarget, "dataSource");
		}
		public static Task SetDataSourceOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDropDownMenu_SetOption", dxTarget, "dataSource", value);
		}
		public static Task<object> GetItemsOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDropDownMenu_GetOption", dxTarget, "items");
		}
		public static Task SetItemsOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDropDownMenu_SetOption", dxTarget, "items", value);
		}
		public static Task<object> GetItemTemplateOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDropDownMenu_GetOption", dxTarget, "itemTemplate");
		}
		public static Task SetItemTemplateOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDropDownMenu_SetOption", dxTarget, "itemTemplate", value);
		}
		public static Task<bool?> GetOpenedOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxDropDownMenu_GetOption", dxTarget, "opened");
		}
		public static Task SetOpenedOption(ElementRef dxTarget, bool? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDropDownMenu_SetOption", dxTarget, "opened", value);
		}
		public static Task<object> GetPopupHeightOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDropDownMenu_GetOption", dxTarget, "popupHeight");
		}
		public static Task SetPopupHeightOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDropDownMenu_SetOption", dxTarget, "popupHeight", value);
		}
		public static Task<object> GetPopupWidthOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDropDownMenu_GetOption", dxTarget, "popupWidth");
		}
		public static Task SetPopupWidthOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDropDownMenu_SetOption", dxTarget, "popupWidth", value);
		}
		public static Task<bool?> GetUsePopoverOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxDropDownMenu_GetOption", dxTarget, "usePopover");
		}
		public static Task SetUsePopoverOption(ElementRef dxTarget, bool? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDropDownMenu_SetOption", dxTarget, "usePopover", value);
		}
		public static Task Close(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDropDownMenu_close_0", dxTarget);
		}
		public static Task Open(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDropDownMenu_open_1", dxTarget);
		}
	}
	public class DxFileUploaderInterop: EditorInterop
	{
		public static event EventHandler<JQueryEventArgs> Progress;
		public static event EventHandler<JQueryEventArgs> UploadAborted;
		public static event EventHandler<JQueryEventArgs> Uploaded;
		public static event EventHandler<JQueryEventArgs> UploadError;
		public static event EventHandler<JQueryEventArgs> UploadStarted;
		public static Task Init(ElementRef dxTarget, DevExpress.Ui.DxFileUploaderOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxFileUploader_Init", dxTarget, json);
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
		public static Task<string> GetAcceptOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxFileUploader_GetOption", dxTarget, "accept");
		}
		public static Task SetAcceptOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxFileUploader_SetOption", dxTarget, "accept", value);
		}
		public static Task<bool?> GetAllowCancelingOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxFileUploader_GetOption", dxTarget, "allowCanceling");
		}
		public static Task SetAllowCancelingOption(ElementRef dxTarget, bool? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxFileUploader_SetOption", dxTarget, "allowCanceling", value);
		}
		public static Task<object> GetAllowedFileExtensionsOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxFileUploader_GetOption", dxTarget, "allowedFileExtensions");
		}
		public static Task SetAllowedFileExtensionsOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxFileUploader_SetOption", dxTarget, "allowedFileExtensions", value);
		}
		public static Task<float?> GetChunkSizeOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_DxFileUploader_GetOption", dxTarget, "chunkSize");
		}
		public static Task SetChunkSizeOption(ElementRef dxTarget, float? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxFileUploader_SetOption", dxTarget, "chunkSize", value);
		}
		public static Task<string> GetInvalidFileExtensionMessageOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxFileUploader_GetOption", dxTarget, "invalidFileExtensionMessage");
		}
		public static Task SetInvalidFileExtensionMessageOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxFileUploader_SetOption", dxTarget, "invalidFileExtensionMessage", value);
		}
		public static Task<string> GetInvalidMaxFileSizeMessageOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxFileUploader_GetOption", dxTarget, "invalidMaxFileSizeMessage");
		}
		public static Task SetInvalidMaxFileSizeMessageOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxFileUploader_SetOption", dxTarget, "invalidMaxFileSizeMessage", value);
		}
		public static Task<string> GetInvalidMinFileSizeMessageOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxFileUploader_GetOption", dxTarget, "invalidMinFileSizeMessage");
		}
		public static Task SetInvalidMinFileSizeMessageOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxFileUploader_SetOption", dxTarget, "invalidMinFileSizeMessage", value);
		}
		public static Task<string> GetLabelTextOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxFileUploader_GetOption", dxTarget, "labelText");
		}
		public static Task SetLabelTextOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxFileUploader_SetOption", dxTarget, "labelText", value);
		}
		public static Task<float?> GetMaxFileSizeOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_DxFileUploader_GetOption", dxTarget, "maxFileSize");
		}
		public static Task SetMaxFileSizeOption(ElementRef dxTarget, float? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxFileUploader_SetOption", dxTarget, "maxFileSize", value);
		}
		public static Task<float?> GetMinFileSizeOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_DxFileUploader_GetOption", dxTarget, "minFileSize");
		}
		public static Task SetMinFileSizeOption(ElementRef dxTarget, float? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxFileUploader_SetOption", dxTarget, "minFileSize", value);
		}
		public static Task<bool?> GetMultipleOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxFileUploader_GetOption", dxTarget, "multiple");
		}
		public static Task SetMultipleOption(ElementRef dxTarget, bool? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxFileUploader_SetOption", dxTarget, "multiple", value);
		}
		public static Task<string> GetNameOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxFileUploader_GetOption", dxTarget, "name");
		}
		public static Task SetNameOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxFileUploader_SetOption", dxTarget, "name", value);
		}
		public static Task<float?> GetProgressOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_DxFileUploader_GetOption", dxTarget, "progress");
		}
		public static Task SetProgressOption(ElementRef dxTarget, float? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxFileUploader_SetOption", dxTarget, "progress", value);
		}
		public static Task<string> GetReadyToUploadMessageOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxFileUploader_GetOption", dxTarget, "readyToUploadMessage");
		}
		public static Task SetReadyToUploadMessageOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxFileUploader_SetOption", dxTarget, "readyToUploadMessage", value);
		}
		public static Task<string> GetSelectButtonTextOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxFileUploader_GetOption", dxTarget, "selectButtonText");
		}
		public static Task SetSelectButtonTextOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxFileUploader_SetOption", dxTarget, "selectButtonText", value);
		}
		public static Task<bool?> GetShowFileListOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxFileUploader_GetOption", dxTarget, "showFileList");
		}
		public static Task SetShowFileListOption(ElementRef dxTarget, bool? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxFileUploader_SetOption", dxTarget, "showFileList", value);
		}
		public static Task<string> GetUploadButtonTextOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxFileUploader_GetOption", dxTarget, "uploadButtonText");
		}
		public static Task SetUploadButtonTextOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxFileUploader_SetOption", dxTarget, "uploadButtonText", value);
		}
		public static Task<string> GetUploadedMessageOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxFileUploader_GetOption", dxTarget, "uploadedMessage");
		}
		public static Task SetUploadedMessageOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxFileUploader_SetOption", dxTarget, "uploadedMessage", value);
		}
		public static Task<string> GetUploadFailedMessageOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxFileUploader_GetOption", dxTarget, "uploadFailedMessage");
		}
		public static Task SetUploadFailedMessageOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxFileUploader_SetOption", dxTarget, "uploadFailedMessage", value);
		}
		public static Task<object> GetUploadHeadersOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxFileUploader_GetOption", dxTarget, "uploadHeaders");
		}
		public static Task SetUploadHeadersOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxFileUploader_SetOption", dxTarget, "uploadHeaders", value);
		}
		public static Task<string> GetUploadMethodOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxFileUploader_GetOption", dxTarget, "uploadMethod");
		}
		public static Task SetUploadMethodOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxFileUploader_SetOption", dxTarget, "uploadMethod", value);
		}
		public static Task<string> GetUploadModeOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxFileUploader_GetOption", dxTarget, "uploadMode");
		}
		public static Task SetUploadModeOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxFileUploader_SetOption", dxTarget, "uploadMode", value);
		}
		public static Task<string> GetUploadUrlOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxFileUploader_GetOption", dxTarget, "uploadUrl");
		}
		public static Task SetUploadUrlOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxFileUploader_SetOption", dxTarget, "uploadUrl", value);
		}
	}
	public class DxFilterBuilderInterop: WidgetInterop
	{
		public static event EventHandler<JQueryEventArgs> EditorPrepared;
		public static event EventHandler<JQueryEventArgs> EditorPreparing;
		public static event EventHandler<JQueryEventArgs> ValueChanged;
		public static Task Init(ElementRef dxTarget, DevExpress.Ui.DxFilterBuilderOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxFilterBuilder_Init", dxTarget, json);
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
		public static Task<bool?> GetAllowHierarchicalFieldsOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxFilterBuilder_GetOption", dxTarget, "allowHierarchicalFields");
		}
		public static Task SetAllowHierarchicalFieldsOption(ElementRef dxTarget, bool? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxFilterBuilder_SetOption", dxTarget, "allowHierarchicalFields", value);
		}
		public static Task<object> GetCustomOperationsOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxFilterBuilder_GetOption", dxTarget, "customOperations");
		}
		public static Task SetCustomOperationsOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxFilterBuilder_SetOption", dxTarget, "customOperations", value);
		}
		public static Task<object> GetFieldsOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxFilterBuilder_GetOption", dxTarget, "fields");
		}
		public static Task SetFieldsOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxFilterBuilder_SetOption", dxTarget, "fields", value);
		}
		public static Task<object> GetFilterOperationDescriptionsOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxFilterBuilder_GetOption", dxTarget, "filterOperationDescriptions");
		}
		public static Task SetFilterOperationDescriptionsOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxFilterBuilder_SetOption", dxTarget, "filterOperationDescriptions", value);
		}
		public static Task<object> GetGroupOperationDescriptionsOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxFilterBuilder_GetOption", dxTarget, "groupOperationDescriptions");
		}
		public static Task SetGroupOperationDescriptionsOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxFilterBuilder_SetOption", dxTarget, "groupOperationDescriptions", value);
		}
		public static Task<object> GetGroupOperationsOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxFilterBuilder_GetOption", dxTarget, "groupOperations");
		}
		public static Task SetGroupOperationsOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxFilterBuilder_SetOption", dxTarget, "groupOperations", value);
		}
		public static Task<float?> GetMaxGroupLevelOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_DxFilterBuilder_GetOption", dxTarget, "maxGroupLevel");
		}
		public static Task SetMaxGroupLevelOption(ElementRef dxTarget, float? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxFilterBuilder_SetOption", dxTarget, "maxGroupLevel", value);
		}
		public static Task<object> GetValueOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxFilterBuilder_GetOption", dxTarget, "value");
		}
		public static Task SetValueOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxFilterBuilder_SetOption", dxTarget, "value", value);
		}
		public static Task<object> GetFilterExpression(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxFilterBuilder_getFilterExpression_0", dxTarget);
		}
	}
	public class DxFormInterop: WidgetInterop
	{
		public static event EventHandler<JQueryEventArgs> EditorEnterKey;
		public static event EventHandler<JQueryEventArgs> FieldDataChanged;
		public static Task Init(ElementRef dxTarget, DevExpress.Ui.DxFormOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxForm_Init", dxTarget, json);
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
		public static Task<bool?> GetAlignItemLabelsOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxForm_GetOption", dxTarget, "alignItemLabels");
		}
		public static Task SetAlignItemLabelsOption(ElementRef dxTarget, bool? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxForm_SetOption", dxTarget, "alignItemLabels", value);
		}
		public static Task<bool?> GetAlignItemLabelsInAllGroupsOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxForm_GetOption", dxTarget, "alignItemLabelsInAllGroups");
		}
		public static Task SetAlignItemLabelsInAllGroupsOption(ElementRef dxTarget, bool? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxForm_SetOption", dxTarget, "alignItemLabelsInAllGroups", value);
		}
		public static Task<object> GetColCountOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxForm_GetOption", dxTarget, "colCount");
		}
		public static Task SetColCountOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxForm_SetOption", dxTarget, "colCount", value);
		}
		public static Task<object> GetColCountByScreenOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxForm_GetOption", dxTarget, "colCountByScreen");
		}
		public static Task SetColCountByScreenOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxForm_SetOption", dxTarget, "colCountByScreen", value);
		}
		public static Task<object> GetCustomizeItemOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxForm_GetOption", dxTarget, "customizeItem");
		}
		public static Task SetCustomizeItemOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxForm_SetOption", dxTarget, "customizeItem", value);
		}
		public static Task<object> GetFormDataOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxForm_GetOption", dxTarget, "formData");
		}
		public static Task SetFormDataOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxForm_SetOption", dxTarget, "formData", value);
		}
		public static Task<object> GetItemsOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxForm_GetOption", dxTarget, "items");
		}
		public static Task SetItemsOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxForm_SetOption", dxTarget, "items", value);
		}
		public static Task<string> GetLabelLocationOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxForm_GetOption", dxTarget, "labelLocation");
		}
		public static Task SetLabelLocationOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxForm_SetOption", dxTarget, "labelLocation", value);
		}
		public static Task<float?> GetMinColWidthOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_DxForm_GetOption", dxTarget, "minColWidth");
		}
		public static Task SetMinColWidthOption(ElementRef dxTarget, float? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxForm_SetOption", dxTarget, "minColWidth", value);
		}
		public static Task<string> GetOptionalMarkOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxForm_GetOption", dxTarget, "optionalMark");
		}
		public static Task SetOptionalMarkOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxForm_SetOption", dxTarget, "optionalMark", value);
		}
		public static Task<bool?> GetReadOnlyOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxForm_GetOption", dxTarget, "readOnly");
		}
		public static Task SetReadOnlyOption(ElementRef dxTarget, bool? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxForm_SetOption", dxTarget, "readOnly", value);
		}
		public static Task<string> GetRequiredMarkOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxForm_GetOption", dxTarget, "requiredMark");
		}
		public static Task SetRequiredMarkOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxForm_SetOption", dxTarget, "requiredMark", value);
		}
		public static Task<string> GetRequiredMessageOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxForm_GetOption", dxTarget, "requiredMessage");
		}
		public static Task SetRequiredMessageOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxForm_SetOption", dxTarget, "requiredMessage", value);
		}
		public static Task<object> GetScreenByWidthOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxForm_GetOption", dxTarget, "screenByWidth");
		}
		public static Task SetScreenByWidthOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxForm_SetOption", dxTarget, "screenByWidth", value);
		}
		public static Task<bool?> GetScrollingEnabledOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxForm_GetOption", dxTarget, "scrollingEnabled");
		}
		public static Task SetScrollingEnabledOption(ElementRef dxTarget, bool? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxForm_SetOption", dxTarget, "scrollingEnabled", value);
		}
		public static Task<bool?> GetShowColonAfterLabelOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxForm_GetOption", dxTarget, "showColonAfterLabel");
		}
		public static Task SetShowColonAfterLabelOption(ElementRef dxTarget, bool? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxForm_SetOption", dxTarget, "showColonAfterLabel", value);
		}
		public static Task<bool?> GetShowOptionalMarkOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxForm_GetOption", dxTarget, "showOptionalMark");
		}
		public static Task SetShowOptionalMarkOption(ElementRef dxTarget, bool? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxForm_SetOption", dxTarget, "showOptionalMark", value);
		}
		public static Task<bool?> GetShowRequiredMarkOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxForm_GetOption", dxTarget, "showRequiredMark");
		}
		public static Task SetShowRequiredMarkOption(ElementRef dxTarget, bool? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxForm_SetOption", dxTarget, "showRequiredMark", value);
		}
		public static Task<bool?> GetShowValidationSummaryOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxForm_GetOption", dxTarget, "showValidationSummary");
		}
		public static Task SetShowValidationSummaryOption(ElementRef dxTarget, bool? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxForm_SetOption", dxTarget, "showValidationSummary", value);
		}
		public static Task<string> GetValidationGroupOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxForm_GetOption", dxTarget, "validationGroup");
		}
		public static Task SetValidationGroupOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxForm_SetOption", dxTarget, "validationGroup", value);
		}
		public static Task<object> GetButton(ElementRef dxTarget, string name)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxForm_getButton_0", dxTarget, name);
		}
		public static Task<object> GetEditor(ElementRef dxTarget, string dataField)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxForm_getEditor_1", dxTarget, dataField);
		}
		public static Task<object> ItemOption(ElementRef dxTarget, string id)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxForm_itemOption_2", dxTarget, id);
		}
		public static Task ItemOption(ElementRef dxTarget, string id, string option, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxForm_itemOption_3", dxTarget, id, option, value);
		}
		public static Task ItemOption(ElementRef dxTarget, string id, object options)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxForm_itemOption_4", dxTarget, id, options);
		}
		public static Task ResetValues(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxForm_resetValues_5", dxTarget);
		}
		public static Task UpdateData(ElementRef dxTarget, object data)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxForm_updateData_6", dxTarget, data);
		}
		public static Task UpdateData(ElementRef dxTarget, string dataField, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxForm_updateData_7", dxTarget, dataField, value);
		}
		public static Task<object> UpdateDimensions(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxForm_updateDimensions_8", dxTarget);
		}
		public static Task<object> Validate(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxForm_validate_9", dxTarget);
		}
	}
	public class DxGalleryInterop: CollectionWidgetInterop
	{
		public static Task Init(ElementRef dxTarget, DevExpress.Ui.DxGalleryOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxGallery_Init", dxTarget, json);
		}
		public static Task<float?> GetAnimationDurationOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_DxGallery_GetOption", dxTarget, "animationDuration");
		}
		public static Task SetAnimationDurationOption(ElementRef dxTarget, float? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxGallery_SetOption", dxTarget, "animationDuration", value);
		}
		public static Task<bool?> GetAnimationEnabledOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxGallery_GetOption", dxTarget, "animationEnabled");
		}
		public static Task SetAnimationEnabledOption(ElementRef dxTarget, bool? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxGallery_SetOption", dxTarget, "animationEnabled", value);
		}
		public static Task<bool?> GetIndicatorEnabledOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxGallery_GetOption", dxTarget, "indicatorEnabled");
		}
		public static Task SetIndicatorEnabledOption(ElementRef dxTarget, bool? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxGallery_SetOption", dxTarget, "indicatorEnabled", value);
		}
		public static Task<float?> GetInitialItemWidthOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_DxGallery_GetOption", dxTarget, "initialItemWidth");
		}
		public static Task SetInitialItemWidthOption(ElementRef dxTarget, float? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxGallery_SetOption", dxTarget, "initialItemWidth", value);
		}
		public static Task<bool?> GetLoopOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxGallery_GetOption", dxTarget, "loop");
		}
		public static Task SetLoopOption(ElementRef dxTarget, bool? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxGallery_SetOption", dxTarget, "loop", value);
		}
		public static Task<bool?> GetShowIndicatorOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxGallery_GetOption", dxTarget, "showIndicator");
		}
		public static Task SetShowIndicatorOption(ElementRef dxTarget, bool? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxGallery_SetOption", dxTarget, "showIndicator", value);
		}
		public static Task<bool?> GetShowNavButtonsOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxGallery_GetOption", dxTarget, "showNavButtons");
		}
		public static Task SetShowNavButtonsOption(ElementRef dxTarget, bool? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxGallery_SetOption", dxTarget, "showNavButtons", value);
		}
		public static Task<float?> GetSlideshowDelayOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_DxGallery_GetOption", dxTarget, "slideshowDelay");
		}
		public static Task SetSlideshowDelayOption(ElementRef dxTarget, float? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxGallery_SetOption", dxTarget, "slideshowDelay", value);
		}
		public static Task<bool?> GetStretchImagesOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxGallery_GetOption", dxTarget, "stretchImages");
		}
		public static Task SetStretchImagesOption(ElementRef dxTarget, bool? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxGallery_SetOption", dxTarget, "stretchImages", value);
		}
		public static Task<bool?> GetSwipeEnabledOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxGallery_GetOption", dxTarget, "swipeEnabled");
		}
		public static Task SetSwipeEnabledOption(ElementRef dxTarget, bool? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxGallery_SetOption", dxTarget, "swipeEnabled", value);
		}
		public static Task<bool?> GetWrapAroundOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxGallery_GetOption", dxTarget, "wrapAround");
		}
		public static Task SetWrapAroundOption(ElementRef dxTarget, bool? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxGallery_SetOption", dxTarget, "wrapAround", value);
		}
		public static Task<object> GoToItem(ElementRef dxTarget, float itemIndex, bool animation)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxGallery_goToItem_0", dxTarget, itemIndex, animation);
		}
		public static Task<object> NextItem(ElementRef dxTarget, bool animation)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxGallery_nextItem_1", dxTarget, animation);
		}
		public static Task<object> PrevItem(ElementRef dxTarget, bool animation)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxGallery_prevItem_2", dxTarget, animation);
		}
	}
	public class DxHtmlEditorInterop: EditorInterop
	{
		public static event EventHandler<JQueryEventArgs> FocusIn;
		public static event EventHandler<JQueryEventArgs> FocusOut;
		public static Task Init(ElementRef dxTarget, DevExpress.Ui.DxHtmlEditorOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxHtmlEditor_Init", dxTarget, json);
		}
		[JSInvokable("DevExpress.Ui.DxHtmlEditorInterop.OnFocusIn")]
		public static void OnFocusIn(string identifier)
		{
			FocusIn?.Invoke(null, new JQueryEventArgs(identifier));
		}
		[JSInvokable("DevExpress.Ui.DxHtmlEditorInterop.OnFocusOut")]
		public static void OnFocusOut(string identifier)
		{
			FocusOut?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static Task<string> GetNameOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxHtmlEditor_GetOption", dxTarget, "name");
		}
		public static Task SetNameOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxHtmlEditor_SetOption", dxTarget, "name", value);
		}
		public static Task<string> GetPlaceholderOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxHtmlEditor_GetOption", dxTarget, "placeholder");
		}
		public static Task SetPlaceholderOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxHtmlEditor_SetOption", dxTarget, "placeholder", value);
		}
		public static Task<object> GetToolbarOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxHtmlEditor_GetOption", dxTarget, "toolbar");
		}
		public static Task SetToolbarOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxHtmlEditor_SetOption", dxTarget, "toolbar", value);
		}
		public static Task<string> GetValueTypeOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxHtmlEditor_GetOption", dxTarget, "valueType");
		}
		public static Task SetValueTypeOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxHtmlEditor_SetOption", dxTarget, "valueType", value);
		}
		public static Task<object> GetVariablesOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxHtmlEditor_GetOption", dxTarget, "variables");
		}
		public static Task SetVariablesOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxHtmlEditor_SetOption", dxTarget, "variables", value);
		}
		public static Task ClearHistory(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxHtmlEditor_clearHistory_0", dxTarget);
		}
		public static Task Delete(ElementRef dxTarget, float index, float length)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxHtmlEditor_delete_1", dxTarget, index, length);
		}
		public static Task Format(ElementRef dxTarget, string formatName, object formatValue)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxHtmlEditor_format_2", dxTarget, formatName, formatValue);
		}
		public static Task FormatLine(ElementRef dxTarget, float index, float length, string formatName, object formatValue)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxHtmlEditor_formatLine_3", dxTarget, index, length, formatName, formatValue);
		}
		public static Task FormatLine(ElementRef dxTarget, float index, float length, object formats)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxHtmlEditor_formatLine_4", dxTarget, index, length, formats);
		}
		public static Task FormatText(ElementRef dxTarget, float index, float length, string formatName, object formatValue)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxHtmlEditor_formatText_5", dxTarget, index, length, formatName, formatValue);
		}
		public static Task FormatText(ElementRef dxTarget, float index, float length, object formats)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxHtmlEditor_formatText_6", dxTarget, index, length, formats);
		}
		public static Task<object> GetFormat(ElementRef dxTarget, float index, float length)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxHtmlEditor_getFormat_7", dxTarget, index, length);
		}
		public static Task<float> GetLength(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<float>("BlazorDevExtreme_DxHtmlEditor_getLength_8", dxTarget);
		}
		public static Task<object> GetModule(ElementRef dxTarget, string modulePath)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxHtmlEditor_getModule_9", dxTarget, modulePath);
		}
		public static Task<object> GetQuillInstance(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxHtmlEditor_getQuillInstance_10", dxTarget);
		}
		public static Task<object> GetSelection(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxHtmlEditor_getSelection_11", dxTarget);
		}
		public static Task InsertEmbed(ElementRef dxTarget, float index, string type, object config)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxHtmlEditor_insertEmbed_12", dxTarget, index, type, config);
		}
		public static Task InsertText(ElementRef dxTarget, float index, string text, object formats)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxHtmlEditor_insertText_13", dxTarget, index, text, formats);
		}
		public static Task Redo(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxHtmlEditor_redo_14", dxTarget);
		}
		public static Task RegisterModules(ElementRef dxTarget, object modules)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxHtmlEditor_registerModules_15", dxTarget, modules);
		}
		public static Task RemoveFormat(ElementRef dxTarget, float index, float length)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxHtmlEditor_removeFormat_16", dxTarget, index, length);
		}
		public static Task SetSelection(ElementRef dxTarget, float index, float length)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxHtmlEditor_setSelection_17", dxTarget, index, length);
		}
		public static Task Undo(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxHtmlEditor_undo_18", dxTarget);
		}
	}
	public class DxListInterop: CollectionWidgetInterop
	{
		public static event EventHandler<JQueryEventArgs> GroupRendered;
		public static event EventHandler<JQueryEventArgs> ItemDeleted;
		public static event EventHandler<JQueryEventArgs> ItemDeleting;
		public static event EventHandler<JQueryEventArgs> ItemReordered;
		public static event EventHandler<JQueryEventArgs> ItemSwipe;
		public static event EventHandler<JQueryEventArgs> PageLoading;
		public static event EventHandler<JQueryEventArgs> PullRefresh;
		public static event EventHandler<JQueryEventArgs> Scroll;
		public static event EventHandler<JQueryEventArgs> SelectAllValueChanged;
		public static Task Init(ElementRef dxTarget, DevExpress.Ui.DxListOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxList_Init", dxTarget, json);
		}
		[JSInvokable("DevExpress.Ui.DxListInterop.OnGroupRendered")]
		public static void OnGroupRendered(string identifier)
		{
			GroupRendered?.Invoke(null, new JQueryEventArgs(identifier));
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
		public static Task<bool?> GetAllowItemDeletingOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxList_GetOption", dxTarget, "allowItemDeleting");
		}
		public static Task SetAllowItemDeletingOption(ElementRef dxTarget, bool? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxList_SetOption", dxTarget, "allowItemDeleting", value);
		}
		public static Task<bool?> GetAllowItemReorderingOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxList_GetOption", dxTarget, "allowItemReordering");
		}
		public static Task SetAllowItemReorderingOption(ElementRef dxTarget, bool? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxList_SetOption", dxTarget, "allowItemReordering", value);
		}
		public static Task<bool?> GetBounceEnabledOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxList_GetOption", dxTarget, "bounceEnabled");
		}
		public static Task SetBounceEnabledOption(ElementRef dxTarget, bool? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxList_SetOption", dxTarget, "bounceEnabled", value);
		}
		public static Task<bool?> GetCollapsibleGroupsOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxList_GetOption", dxTarget, "collapsibleGroups");
		}
		public static Task SetCollapsibleGroupsOption(ElementRef dxTarget, bool? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxList_SetOption", dxTarget, "collapsibleGroups", value);
		}
		public static Task<bool?> GetGroupedOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxList_GetOption", dxTarget, "grouped");
		}
		public static Task SetGroupedOption(ElementRef dxTarget, bool? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxList_SetOption", dxTarget, "grouped", value);
		}
		public static Task<object> GetGroupTemplateOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxList_GetOption", dxTarget, "groupTemplate");
		}
		public static Task SetGroupTemplateOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxList_SetOption", dxTarget, "groupTemplate", value);
		}
		public static Task<bool?> GetIndicateLoadingOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxList_GetOption", dxTarget, "indicateLoading");
		}
		public static Task SetIndicateLoadingOption(ElementRef dxTarget, bool? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxList_SetOption", dxTarget, "indicateLoading", value);
		}
		public static Task<string> GetItemDeleteModeOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxList_GetOption", dxTarget, "itemDeleteMode");
		}
		public static Task SetItemDeleteModeOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxList_SetOption", dxTarget, "itemDeleteMode", value);
		}
		public static Task<object> GetMenuItemsOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxList_GetOption", dxTarget, "menuItems");
		}
		public static Task SetMenuItemsOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxList_SetOption", dxTarget, "menuItems", value);
		}
		public static Task<string> GetMenuModeOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxList_GetOption", dxTarget, "menuMode");
		}
		public static Task SetMenuModeOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxList_SetOption", dxTarget, "menuMode", value);
		}
		public static Task<string> GetNextButtonTextOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxList_GetOption", dxTarget, "nextButtonText");
		}
		public static Task SetNextButtonTextOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxList_SetOption", dxTarget, "nextButtonText", value);
		}
		public static Task<string> GetPageLoadingTextOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxList_GetOption", dxTarget, "pageLoadingText");
		}
		public static Task SetPageLoadingTextOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxList_SetOption", dxTarget, "pageLoadingText", value);
		}
		public static Task<string> GetPageLoadModeOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxList_GetOption", dxTarget, "pageLoadMode");
		}
		public static Task SetPageLoadModeOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxList_SetOption", dxTarget, "pageLoadMode", value);
		}
		public static Task<string> GetPulledDownTextOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxList_GetOption", dxTarget, "pulledDownText");
		}
		public static Task SetPulledDownTextOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxList_SetOption", dxTarget, "pulledDownText", value);
		}
		public static Task<string> GetPullingDownTextOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxList_GetOption", dxTarget, "pullingDownText");
		}
		public static Task SetPullingDownTextOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxList_SetOption", dxTarget, "pullingDownText", value);
		}
		public static Task<bool?> GetPullRefreshEnabledOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxList_GetOption", dxTarget, "pullRefreshEnabled");
		}
		public static Task SetPullRefreshEnabledOption(ElementRef dxTarget, bool? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxList_SetOption", dxTarget, "pullRefreshEnabled", value);
		}
		public static Task<string> GetRefreshingTextOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxList_GetOption", dxTarget, "refreshingText");
		}
		public static Task SetRefreshingTextOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxList_SetOption", dxTarget, "refreshingText", value);
		}
		public static Task<bool?> GetRepaintChangesOnlyOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxList_GetOption", dxTarget, "repaintChangesOnly");
		}
		public static Task SetRepaintChangesOnlyOption(ElementRef dxTarget, bool? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxList_SetOption", dxTarget, "repaintChangesOnly", value);
		}
		public static Task<bool?> GetScrollByContentOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxList_GetOption", dxTarget, "scrollByContent");
		}
		public static Task SetScrollByContentOption(ElementRef dxTarget, bool? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxList_SetOption", dxTarget, "scrollByContent", value);
		}
		public static Task<bool?> GetScrollByThumbOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxList_GetOption", dxTarget, "scrollByThumb");
		}
		public static Task SetScrollByThumbOption(ElementRef dxTarget, bool? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxList_SetOption", dxTarget, "scrollByThumb", value);
		}
		public static Task<bool?> GetScrollingEnabledOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxList_GetOption", dxTarget, "scrollingEnabled");
		}
		public static Task SetScrollingEnabledOption(ElementRef dxTarget, bool? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxList_SetOption", dxTarget, "scrollingEnabled", value);
		}
		public static Task<string> GetSelectAllModeOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxList_GetOption", dxTarget, "selectAllMode");
		}
		public static Task SetSelectAllModeOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxList_SetOption", dxTarget, "selectAllMode", value);
		}
		public static Task<string> GetSelectionModeOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxList_GetOption", dxTarget, "selectionMode");
		}
		public static Task SetSelectionModeOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxList_SetOption", dxTarget, "selectionMode", value);
		}
		public static Task<string> GetShowScrollbarOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxList_GetOption", dxTarget, "showScrollbar");
		}
		public static Task SetShowScrollbarOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxList_SetOption", dxTarget, "showScrollbar", value);
		}
		public static Task<bool?> GetShowSelectionControlsOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxList_GetOption", dxTarget, "showSelectionControls");
		}
		public static Task SetShowSelectionControlsOption(ElementRef dxTarget, bool? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxList_SetOption", dxTarget, "showSelectionControls", value);
		}
		public static Task<bool?> GetUseNativeScrollingOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxList_GetOption", dxTarget, "useNativeScrolling");
		}
		public static Task SetUseNativeScrollingOption(ElementRef dxTarget, bool? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxList_SetOption", dxTarget, "useNativeScrolling", value);
		}
		public static Task<object> GetSearchEditorOptionsOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxList_GetOption", dxTarget, "searchEditorOptions");
		}
		public static Task SetSearchEditorOptionsOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxList_SetOption", dxTarget, "searchEditorOptions", value);
		}
		public static Task<bool?> GetSearchEnabledOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxList_GetOption", dxTarget, "searchEnabled");
		}
		public static Task SetSearchEnabledOption(ElementRef dxTarget, bool? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxList_SetOption", dxTarget, "searchEnabled", value);
		}
		public static Task<object> GetSearchExprOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxList_GetOption", dxTarget, "searchExpr");
		}
		public static Task SetSearchExprOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxList_SetOption", dxTarget, "searchExpr", value);
		}
		public static Task<string> GetSearchModeOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxList_GetOption", dxTarget, "searchMode");
		}
		public static Task SetSearchModeOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxList_SetOption", dxTarget, "searchMode", value);
		}
		public static Task<float?> GetSearchTimeoutOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_DxList_GetOption", dxTarget, "searchTimeout");
		}
		public static Task SetSearchTimeoutOption(ElementRef dxTarget, float? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxList_SetOption", dxTarget, "searchTimeout", value);
		}
		public static Task<string> GetSearchValueOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxList_GetOption", dxTarget, "searchValue");
		}
		public static Task SetSearchValueOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxList_SetOption", dxTarget, "searchValue", value);
		}
		public static Task<float> ClientHeight(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<float>("BlazorDevExtreme_DxList_clientHeight_0", dxTarget);
		}
		public static Task<object> CollapseGroup(ElementRef dxTarget, float groupIndex)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxList_collapseGroup_1", dxTarget, groupIndex);
		}
		public static Task<object> DeleteItem(ElementRef dxTarget, object itemElement)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxList_deleteItem_2", dxTarget, itemElement);
		}
		public static Task<object> ExpandGroup(ElementRef dxTarget, float groupIndex)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxList_expandGroup_4", dxTarget, groupIndex);
		}
		public static Task<bool> IsItemSelected(ElementRef dxTarget, object itemElement)
		{
			return JSRuntime.Current.InvokeAsync<bool>("BlazorDevExtreme_DxList_isItemSelected_5", dxTarget, itemElement);
		}
		public static Task Reload(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxList_reload_7", dxTarget);
		}
		public static Task<object> ReorderItem(ElementRef dxTarget, object itemElement, object toItemElement)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxList_reorderItem_8", dxTarget, itemElement, toItemElement);
		}
		public static Task ScrollBy(ElementRef dxTarget, float distance)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxList_scrollBy_10", dxTarget, distance);
		}
		public static Task<float> ScrollHeight(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<float>("BlazorDevExtreme_DxList_scrollHeight_11", dxTarget);
		}
		public static Task ScrollTo(ElementRef dxTarget, float location)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxList_scrollTo_12", dxTarget, location);
		}
		public static Task ScrollToItem(ElementRef dxTarget, object itemElement)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxList_scrollToItem_13", dxTarget, itemElement);
		}
		public static Task<float> ScrollTop(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<float>("BlazorDevExtreme_DxList_scrollTop_15", dxTarget);
		}
		public static Task SelectAll(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxList_selectAll_16", dxTarget);
		}
		public static Task SelectItem(ElementRef dxTarget, object itemElement)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxList_selectItem_17", dxTarget, itemElement);
		}
		public static Task UnselectAll(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxList_unselectAll_19", dxTarget);
		}
		public static Task UnselectItem(ElementRef dxTarget, object itemElement)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxList_unselectItem_20", dxTarget, itemElement);
		}
		public static Task<object> UpdateDimensions(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxList_updateDimensions_22", dxTarget);
		}
	}
	public class DxLoadIndicatorInterop: WidgetInterop
	{
		public static Task Init(ElementRef dxTarget, DevExpress.Ui.DxLoadIndicatorOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxLoadIndicator_Init", dxTarget, json);
		}
		public static Task<string> GetIndicatorSrcOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxLoadIndicator_GetOption", dxTarget, "indicatorSrc");
		}
		public static Task SetIndicatorSrcOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxLoadIndicator_SetOption", dxTarget, "indicatorSrc", value);
		}
	}
	public class DxLoadPanelInterop: DxOverlayInterop
	{
		public static Task Init(ElementRef dxTarget, DevExpress.Ui.DxLoadPanelOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxLoadPanel_Init", dxTarget, json);
		}
		public static Task<object> GetContainerOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxLoadPanel_GetOption", dxTarget, "container");
		}
		public static Task SetContainerOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxLoadPanel_SetOption", dxTarget, "container", value);
		}
		public static Task<float?> GetDelayOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_DxLoadPanel_GetOption", dxTarget, "delay");
		}
		public static Task SetDelayOption(ElementRef dxTarget, float? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxLoadPanel_SetOption", dxTarget, "delay", value);
		}
		public static Task<string> GetIndicatorSrcOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxLoadPanel_GetOption", dxTarget, "indicatorSrc");
		}
		public static Task SetIndicatorSrcOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxLoadPanel_SetOption", dxTarget, "indicatorSrc", value);
		}
		public static Task<string> GetMessageOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxLoadPanel_GetOption", dxTarget, "message");
		}
		public static Task SetMessageOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxLoadPanel_SetOption", dxTarget, "message", value);
		}
		public static Task<bool?> GetShowIndicatorOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxLoadPanel_GetOption", dxTarget, "showIndicator");
		}
		public static Task SetShowIndicatorOption(ElementRef dxTarget, bool? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxLoadPanel_SetOption", dxTarget, "showIndicator", value);
		}
		public static Task<bool?> GetShowPaneOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxLoadPanel_GetOption", dxTarget, "showPane");
		}
		public static Task SetShowPaneOption(ElementRef dxTarget, bool? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxLoadPanel_SetOption", dxTarget, "showPane", value);
		}
	}
	public class DxLookupInterop: DxDropDownListInterop
	{
		public static event EventHandler<JQueryEventArgs> PageLoading;
		public static event EventHandler<JQueryEventArgs> PullRefresh;
		public static event EventHandler<JQueryEventArgs> Scroll;
		public static event EventHandler<JQueryEventArgs> TitleRendered;
		public static Task Init(ElementRef dxTarget, DevExpress.Ui.DxLookupOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxLookup_Init", dxTarget, json);
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
		public static Task<object> GetAnimationOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxLookup_GetOption", dxTarget, "animation");
		}
		public static Task SetAnimationOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxLookup_SetOption", dxTarget, "animation", value);
		}
		public static Task<string> GetApplyButtonTextOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxLookup_GetOption", dxTarget, "applyButtonText");
		}
		public static Task SetApplyButtonTextOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxLookup_SetOption", dxTarget, "applyButtonText", value);
		}
		public static Task<string> GetCancelButtonTextOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxLookup_GetOption", dxTarget, "cancelButtonText");
		}
		public static Task SetCancelButtonTextOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxLookup_SetOption", dxTarget, "cancelButtonText", value);
		}
		public static Task<bool?> GetCleanSearchOnOpeningOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxLookup_GetOption", dxTarget, "cleanSearchOnOpening");
		}
		public static Task SetCleanSearchOnOpeningOption(ElementRef dxTarget, bool? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxLookup_SetOption", dxTarget, "cleanSearchOnOpening", value);
		}
		public static Task<string> GetClearButtonTextOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxLookup_GetOption", dxTarget, "clearButtonText");
		}
		public static Task SetClearButtonTextOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxLookup_SetOption", dxTarget, "clearButtonText", value);
		}
		public static Task<object> GetCloseOnOutsideClickOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxLookup_GetOption", dxTarget, "closeOnOutsideClick");
		}
		public static Task SetCloseOnOutsideClickOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxLookup_SetOption", dxTarget, "closeOnOutsideClick", value);
		}
		public static Task<object> GetFieldTemplateOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxLookup_GetOption", dxTarget, "fieldTemplate");
		}
		public static Task SetFieldTemplateOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxLookup_SetOption", dxTarget, "fieldTemplate", value);
		}
		public static Task<bool?> GetFullScreenOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxLookup_GetOption", dxTarget, "fullScreen");
		}
		public static Task SetFullScreenOption(ElementRef dxTarget, bool? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxLookup_SetOption", dxTarget, "fullScreen", value);
		}
		public static Task<string> GetNextButtonTextOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxLookup_GetOption", dxTarget, "nextButtonText");
		}
		public static Task SetNextButtonTextOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxLookup_SetOption", dxTarget, "nextButtonText", value);
		}
		public static Task<string> GetPageLoadingTextOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxLookup_GetOption", dxTarget, "pageLoadingText");
		}
		public static Task SetPageLoadingTextOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxLookup_SetOption", dxTarget, "pageLoadingText", value);
		}
		public static Task<string> GetPageLoadModeOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxLookup_GetOption", dxTarget, "pageLoadMode");
		}
		public static Task SetPageLoadModeOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxLookup_SetOption", dxTarget, "pageLoadMode", value);
		}
		public static Task<object> GetPopupHeightOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxLookup_GetOption", dxTarget, "popupHeight");
		}
		public static Task SetPopupHeightOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxLookup_SetOption", dxTarget, "popupHeight", value);
		}
		public static Task<object> GetPopupWidthOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxLookup_GetOption", dxTarget, "popupWidth");
		}
		public static Task SetPopupWidthOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxLookup_SetOption", dxTarget, "popupWidth", value);
		}
		public static Task<object> GetPositionOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxLookup_GetOption", dxTarget, "position");
		}
		public static Task SetPositionOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxLookup_SetOption", dxTarget, "position", value);
		}
		public static Task<string> GetPulledDownTextOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxLookup_GetOption", dxTarget, "pulledDownText");
		}
		public static Task SetPulledDownTextOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxLookup_SetOption", dxTarget, "pulledDownText", value);
		}
		public static Task<string> GetPullingDownTextOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxLookup_GetOption", dxTarget, "pullingDownText");
		}
		public static Task SetPullingDownTextOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxLookup_SetOption", dxTarget, "pullingDownText", value);
		}
		public static Task<bool?> GetPullRefreshEnabledOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxLookup_GetOption", dxTarget, "pullRefreshEnabled");
		}
		public static Task SetPullRefreshEnabledOption(ElementRef dxTarget, bool? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxLookup_SetOption", dxTarget, "pullRefreshEnabled", value);
		}
		public static Task<string> GetRefreshingTextOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxLookup_GetOption", dxTarget, "refreshingText");
		}
		public static Task SetRefreshingTextOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxLookup_SetOption", dxTarget, "refreshingText", value);
		}
		public static Task<string> GetSearchPlaceholderOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxLookup_GetOption", dxTarget, "searchPlaceholder");
		}
		public static Task SetSearchPlaceholderOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxLookup_SetOption", dxTarget, "searchPlaceholder", value);
		}
		public static Task<bool?> GetShadingOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxLookup_GetOption", dxTarget, "shading");
		}
		public static Task SetShadingOption(ElementRef dxTarget, bool? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxLookup_SetOption", dxTarget, "shading", value);
		}
		public static Task<bool?> GetShowCancelButtonOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxLookup_GetOption", dxTarget, "showCancelButton");
		}
		public static Task SetShowCancelButtonOption(ElementRef dxTarget, bool? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxLookup_SetOption", dxTarget, "showCancelButton", value);
		}
		public static Task<bool?> GetShowPopupTitleOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxLookup_GetOption", dxTarget, "showPopupTitle");
		}
		public static Task SetShowPopupTitleOption(ElementRef dxTarget, bool? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxLookup_SetOption", dxTarget, "showPopupTitle", value);
		}
		public static Task<string> GetTitleOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxLookup_GetOption", dxTarget, "title");
		}
		public static Task SetTitleOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxLookup_SetOption", dxTarget, "title", value);
		}
		public static Task<object> GetTitleTemplateOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxLookup_GetOption", dxTarget, "titleTemplate");
		}
		public static Task SetTitleTemplateOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxLookup_SetOption", dxTarget, "titleTemplate", value);
		}
		public static Task<bool?> GetUseNativeScrollingOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxLookup_GetOption", dxTarget, "useNativeScrolling");
		}
		public static Task SetUseNativeScrollingOption(ElementRef dxTarget, bool? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxLookup_SetOption", dxTarget, "useNativeScrolling", value);
		}
		public static Task<bool?> GetUsePopoverOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxLookup_GetOption", dxTarget, "usePopover");
		}
		public static Task SetUsePopoverOption(ElementRef dxTarget, bool? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxLookup_SetOption", dxTarget, "usePopover", value);
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
		public static Task Init(ElementRef dxTarget, DevExpress.Ui.DxMapOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxMap_Init", dxTarget, json);
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
		public static Task<bool?> GetAutoAdjustOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxMap_GetOption", dxTarget, "autoAdjust");
		}
		public static Task SetAutoAdjustOption(ElementRef dxTarget, bool? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxMap_SetOption", dxTarget, "autoAdjust", value);
		}
		public static Task<object> GetCenterOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxMap_GetOption", dxTarget, "center");
		}
		public static Task SetCenterOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxMap_SetOption", dxTarget, "center", value);
		}
		public static Task<bool?> GetControlsOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxMap_GetOption", dxTarget, "controls");
		}
		public static Task SetControlsOption(ElementRef dxTarget, bool? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxMap_SetOption", dxTarget, "controls", value);
		}
		public static Task<object> GetKeyOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxMap_GetOption", dxTarget, "key");
		}
		public static Task SetKeyOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxMap_SetOption", dxTarget, "key", value);
		}
		public static Task<string> GetMarkerIconSrcOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxMap_GetOption", dxTarget, "markerIconSrc");
		}
		public static Task SetMarkerIconSrcOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxMap_SetOption", dxTarget, "markerIconSrc", value);
		}
		public static Task<object> GetMarkersOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxMap_GetOption", dxTarget, "markers");
		}
		public static Task SetMarkersOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxMap_SetOption", dxTarget, "markers", value);
		}
		public static Task<string> GetProviderOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxMap_GetOption", dxTarget, "provider");
		}
		public static Task SetProviderOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxMap_SetOption", dxTarget, "provider", value);
		}
		public static Task<object> GetRoutesOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxMap_GetOption", dxTarget, "routes");
		}
		public static Task SetRoutesOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxMap_SetOption", dxTarget, "routes", value);
		}
		public static Task<string> GetTypeOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxMap_GetOption", dxTarget, "type");
		}
		public static Task SetTypeOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxMap_SetOption", dxTarget, "type", value);
		}
		public static Task<float?> GetZoomOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_DxMap_GetOption", dxTarget, "zoom");
		}
		public static Task SetZoomOption(ElementRef dxTarget, float? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxMap_SetOption", dxTarget, "zoom", value);
		}
		public static Task<object> AddMarker(ElementRef dxTarget, object markerOptions)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxMap_addMarker_0", dxTarget, markerOptions);
		}
		public static Task<object> AddRoute(ElementRef dxTarget, object options)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxMap_addRoute_1", dxTarget, options);
		}
		public static Task<object> RemoveMarker(ElementRef dxTarget, object marker)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxMap_removeMarker_2", dxTarget, marker);
		}
		public static Task<object> RemoveRoute(ElementRef dxTarget, object route)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxMap_removeRoute_3", dxTarget, route);
		}
	}
	public class DxMenuInterop: DxMenuBaseInterop
	{
		public static event EventHandler<JQueryEventArgs> SubmenuHidden;
		public static event EventHandler<JQueryEventArgs> SubmenuHiding;
		public static event EventHandler<JQueryEventArgs> SubmenuShowing;
		public static event EventHandler<JQueryEventArgs> SubmenuShown;
		public static Task Init(ElementRef dxTarget, DevExpress.Ui.DxMenuOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxMenu_Init", dxTarget, json);
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
		public static Task<bool?> GetAdaptivityEnabledOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxMenu_GetOption", dxTarget, "adaptivityEnabled");
		}
		public static Task SetAdaptivityEnabledOption(ElementRef dxTarget, bool? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxMenu_SetOption", dxTarget, "adaptivityEnabled", value);
		}
		public static Task<bool?> GetHideSubmenuOnMouseLeaveOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxMenu_GetOption", dxTarget, "hideSubmenuOnMouseLeave");
		}
		public static Task SetHideSubmenuOnMouseLeaveOption(ElementRef dxTarget, bool? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxMenu_SetOption", dxTarget, "hideSubmenuOnMouseLeave", value);
		}
		public static Task<string> GetOrientationOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxMenu_GetOption", dxTarget, "orientation");
		}
		public static Task SetOrientationOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxMenu_SetOption", dxTarget, "orientation", value);
		}
		public static Task<object> GetShowFirstSubmenuModeOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxMenu_GetOption", dxTarget, "showFirstSubmenuMode");
		}
		public static Task SetShowFirstSubmenuModeOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxMenu_SetOption", dxTarget, "showFirstSubmenuMode", value);
		}
		public static Task<string> GetSubmenuDirectionOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxMenu_GetOption", dxTarget, "submenuDirection");
		}
		public static Task SetSubmenuDirectionOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxMenu_SetOption", dxTarget, "submenuDirection", value);
		}
	}
	public class DxMultiViewInterop: CollectionWidgetInterop
	{
		public static Task<bool?> GetAnimationEnabledOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxMultiView_GetOption", dxTarget, "animationEnabled");
		}
		public static Task SetAnimationEnabledOption(ElementRef dxTarget, bool? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxMultiView_SetOption", dxTarget, "animationEnabled", value);
		}
		public static Task<bool?> GetDeferRenderingOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxMultiView_GetOption", dxTarget, "deferRendering");
		}
		public static Task SetDeferRenderingOption(ElementRef dxTarget, bool? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxMultiView_SetOption", dxTarget, "deferRendering", value);
		}
		public static Task<bool?> GetLoopOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxMultiView_GetOption", dxTarget, "loop");
		}
		public static Task SetLoopOption(ElementRef dxTarget, bool? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxMultiView_SetOption", dxTarget, "loop", value);
		}
		public static Task<bool?> GetSwipeEnabledOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxMultiView_GetOption", dxTarget, "swipeEnabled");
		}
		public static Task SetSwipeEnabledOption(ElementRef dxTarget, bool? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxMultiView_SetOption", dxTarget, "swipeEnabled", value);
		}
	}
	public class DxNavBarInterop: DxTabsInterop
	{
		public static Task Init(ElementRef dxTarget, DevExpress.Ui.DxNavBarOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxNavBar_Init", dxTarget, json);
		}
	}
	public class DxNumberBoxInterop: DxTextEditorInterop
	{
		public static Task Init(ElementRef dxTarget, DevExpress.Ui.DxNumberBoxOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxNumberBox_Init", dxTarget, json);
		}
		public static Task<object> GetFormatOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxNumberBox_GetOption", dxTarget, "format");
		}
		public static Task SetFormatOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxNumberBox_SetOption", dxTarget, "format", value);
		}
		public static Task<string> GetInvalidValueMessageOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxNumberBox_GetOption", dxTarget, "invalidValueMessage");
		}
		public static Task SetInvalidValueMessageOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxNumberBox_SetOption", dxTarget, "invalidValueMessage", value);
		}
		public static Task<float?> GetMaxOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_DxNumberBox_GetOption", dxTarget, "max");
		}
		public static Task SetMaxOption(ElementRef dxTarget, float? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxNumberBox_SetOption", dxTarget, "max", value);
		}
		public static Task<float?> GetMinOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_DxNumberBox_GetOption", dxTarget, "min");
		}
		public static Task SetMinOption(ElementRef dxTarget, float? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxNumberBox_SetOption", dxTarget, "min", value);
		}
		public static Task<string> GetModeOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxNumberBox_GetOption", dxTarget, "mode");
		}
		public static Task SetModeOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxNumberBox_SetOption", dxTarget, "mode", value);
		}
		public static Task<bool?> GetShowSpinButtonsOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxNumberBox_GetOption", dxTarget, "showSpinButtons");
		}
		public static Task SetShowSpinButtonsOption(ElementRef dxTarget, bool? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxNumberBox_SetOption", dxTarget, "showSpinButtons", value);
		}
		public static Task<float?> GetStepOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_DxNumberBox_GetOption", dxTarget, "step");
		}
		public static Task SetStepOption(ElementRef dxTarget, float? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxNumberBox_SetOption", dxTarget, "step", value);
		}
		public static Task<bool?> GetUseLargeSpinButtonsOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxNumberBox_GetOption", dxTarget, "useLargeSpinButtons");
		}
		public static Task SetUseLargeSpinButtonsOption(ElementRef dxTarget, bool? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxNumberBox_SetOption", dxTarget, "useLargeSpinButtons", value);
		}
	}
	public class DxOverlayInterop: WidgetInterop
	{
		public static event EventHandler<JQueryEventArgs> Hidden;
		public static event EventHandler<JQueryEventArgs> Hiding;
		public static event EventHandler<JQueryEventArgs> Showing;
		public static event EventHandler<JQueryEventArgs> Shown;
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
		public static Task<object> GetAnimationOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxOverlay_GetOption", dxTarget, "animation");
		}
		public static Task SetAnimationOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxOverlay_SetOption", dxTarget, "animation", value);
		}
		public static Task<bool?> GetCloseOnBackButtonOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxOverlay_GetOption", dxTarget, "closeOnBackButton");
		}
		public static Task SetCloseOnBackButtonOption(ElementRef dxTarget, bool? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxOverlay_SetOption", dxTarget, "closeOnBackButton", value);
		}
		public static Task<object> GetCloseOnOutsideClickOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxOverlay_GetOption", dxTarget, "closeOnOutsideClick");
		}
		public static Task SetCloseOnOutsideClickOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxOverlay_SetOption", dxTarget, "closeOnOutsideClick", value);
		}
		public static Task<object> GetContentTemplateOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxOverlay_GetOption", dxTarget, "contentTemplate");
		}
		public static Task SetContentTemplateOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxOverlay_SetOption", dxTarget, "contentTemplate", value);
		}
		public static Task<bool?> GetDeferRenderingOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxOverlay_GetOption", dxTarget, "deferRendering");
		}
		public static Task SetDeferRenderingOption(ElementRef dxTarget, bool? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxOverlay_SetOption", dxTarget, "deferRendering", value);
		}
		public static Task<bool?> GetDragEnabledOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxOverlay_GetOption", dxTarget, "dragEnabled");
		}
		public static Task SetDragEnabledOption(ElementRef dxTarget, bool? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxOverlay_SetOption", dxTarget, "dragEnabled", value);
		}
		public static Task<object> GetMaxHeightOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxOverlay_GetOption", dxTarget, "maxHeight");
		}
		public static Task SetMaxHeightOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxOverlay_SetOption", dxTarget, "maxHeight", value);
		}
		public static Task<object> GetMaxWidthOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxOverlay_GetOption", dxTarget, "maxWidth");
		}
		public static Task SetMaxWidthOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxOverlay_SetOption", dxTarget, "maxWidth", value);
		}
		public static Task<object> GetMinHeightOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxOverlay_GetOption", dxTarget, "minHeight");
		}
		public static Task SetMinHeightOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxOverlay_SetOption", dxTarget, "minHeight", value);
		}
		public static Task<object> GetMinWidthOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxOverlay_GetOption", dxTarget, "minWidth");
		}
		public static Task SetMinWidthOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxOverlay_SetOption", dxTarget, "minWidth", value);
		}
		public static Task<object> GetPositionOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxOverlay_GetOption", dxTarget, "position");
		}
		public static Task SetPositionOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxOverlay_SetOption", dxTarget, "position", value);
		}
		public static Task<bool?> GetShadingOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxOverlay_GetOption", dxTarget, "shading");
		}
		public static Task SetShadingOption(ElementRef dxTarget, bool? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxOverlay_SetOption", dxTarget, "shading", value);
		}
		public static Task<string> GetShadingColorOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxOverlay_GetOption", dxTarget, "shadingColor");
		}
		public static Task SetShadingColorOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxOverlay_SetOption", dxTarget, "shadingColor", value);
		}
		public static Task<object> Content(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxOverlay_content_0", dxTarget);
		}
		public static Task<object> Hide(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxOverlay_hide_1", dxTarget);
		}
		public static Task Repaint(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxOverlay_repaint_2", dxTarget);
		}
		public static Task<object> Show(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxOverlay_show_3", dxTarget);
		}
		public static Task<object> Toggle(ElementRef dxTarget, bool showing)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxOverlay_toggle_4", dxTarget, showing);
		}
	}
	public class DxPanoramaInterop: CollectionWidgetInterop
	{
		public static Task Init(ElementRef dxTarget, DevExpress.Ui.DxPanoramaOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPanorama_Init", dxTarget, json);
		}
		public static Task<object> GetBackgroundImageOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPanorama_GetOption", dxTarget, "backgroundImage");
		}
		public static Task SetBackgroundImageOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPanorama_SetOption", dxTarget, "backgroundImage", value);
		}
		public static Task<string> GetTitleOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxPanorama_GetOption", dxTarget, "title");
		}
		public static Task SetTitleOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPanorama_SetOption", dxTarget, "title", value);
		}
	}
	public class DxPivotInterop: CollectionWidgetInterop
	{
		public static Task Init(ElementRef dxTarget, DevExpress.Ui.DxPivotOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPivot_Init", dxTarget, json);
		}
		public static Task<object> GetContentTemplateOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPivot_GetOption", dxTarget, "contentTemplate");
		}
		public static Task SetContentTemplateOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPivot_SetOption", dxTarget, "contentTemplate", value);
		}
		public static Task<object> GetItemTitleTemplateOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPivot_GetOption", dxTarget, "itemTitleTemplate");
		}
		public static Task SetItemTitleTemplateOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPivot_SetOption", dxTarget, "itemTitleTemplate", value);
		}
		public static Task<bool?> GetSwipeEnabledOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxPivot_GetOption", dxTarget, "swipeEnabled");
		}
		public static Task SetSwipeEnabledOption(ElementRef dxTarget, bool? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPivot_SetOption", dxTarget, "swipeEnabled", value);
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
		public static Task Init(ElementRef dxTarget, DevExpress.Ui.DxPivotGridOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPivotGrid_Init", dxTarget, json);
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
		public static Task<bool?> GetAllowExpandAllOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxPivotGrid_GetOption", dxTarget, "allowExpandAll");
		}
		public static Task SetAllowExpandAllOption(ElementRef dxTarget, bool? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPivotGrid_SetOption", dxTarget, "allowExpandAll", value);
		}
		public static Task<bool?> GetAllowFilteringOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxPivotGrid_GetOption", dxTarget, "allowFiltering");
		}
		public static Task SetAllowFilteringOption(ElementRef dxTarget, bool? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPivotGrid_SetOption", dxTarget, "allowFiltering", value);
		}
		public static Task<bool?> GetAllowSortingOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxPivotGrid_GetOption", dxTarget, "allowSorting");
		}
		public static Task SetAllowSortingOption(ElementRef dxTarget, bool? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPivotGrid_SetOption", dxTarget, "allowSorting", value);
		}
		public static Task<bool?> GetAllowSortingBySummaryOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxPivotGrid_GetOption", dxTarget, "allowSortingBySummary");
		}
		public static Task SetAllowSortingBySummaryOption(ElementRef dxTarget, bool? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPivotGrid_SetOption", dxTarget, "allowSortingBySummary", value);
		}
		public static Task<string> GetDataFieldAreaOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxPivotGrid_GetOption", dxTarget, "dataFieldArea");
		}
		public static Task SetDataFieldAreaOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPivotGrid_SetOption", dxTarget, "dataFieldArea", value);
		}
		public static Task<object> GetDataSourceOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPivotGrid_GetOption", dxTarget, "dataSource");
		}
		public static Task SetDataSourceOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPivotGrid_SetOption", dxTarget, "dataSource", value);
		}
		public static Task<object> GetExportOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPivotGrid_GetOption", dxTarget, "export");
		}
		public static Task SetExportOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPivotGrid_SetOption", dxTarget, "export", value);
		}
		public static Task<object> GetFieldChooserOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPivotGrid_GetOption", dxTarget, "fieldChooser");
		}
		public static Task SetFieldChooserOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPivotGrid_SetOption", dxTarget, "fieldChooser", value);
		}
		public static Task<object> GetFieldPanelOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPivotGrid_GetOption", dxTarget, "fieldPanel");
		}
		public static Task SetFieldPanelOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPivotGrid_SetOption", dxTarget, "fieldPanel", value);
		}
		public static Task<object> GetHeaderFilterOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPivotGrid_GetOption", dxTarget, "headerFilter");
		}
		public static Task SetHeaderFilterOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPivotGrid_SetOption", dxTarget, "headerFilter", value);
		}
		public static Task<bool?> GetHideEmptySummaryCellsOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxPivotGrid_GetOption", dxTarget, "hideEmptySummaryCells");
		}
		public static Task SetHideEmptySummaryCellsOption(ElementRef dxTarget, bool? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPivotGrid_SetOption", dxTarget, "hideEmptySummaryCells", value);
		}
		public static Task<object> GetLoadPanelOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPivotGrid_GetOption", dxTarget, "loadPanel");
		}
		public static Task SetLoadPanelOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPivotGrid_SetOption", dxTarget, "loadPanel", value);
		}
		public static Task<string> GetRowHeaderLayoutOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxPivotGrid_GetOption", dxTarget, "rowHeaderLayout");
		}
		public static Task SetRowHeaderLayoutOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPivotGrid_SetOption", dxTarget, "rowHeaderLayout", value);
		}
		public static Task<object> GetScrollingOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPivotGrid_GetOption", dxTarget, "scrolling");
		}
		public static Task SetScrollingOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPivotGrid_SetOption", dxTarget, "scrolling", value);
		}
		public static Task<bool?> GetShowBordersOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxPivotGrid_GetOption", dxTarget, "showBorders");
		}
		public static Task SetShowBordersOption(ElementRef dxTarget, bool? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPivotGrid_SetOption", dxTarget, "showBorders", value);
		}
		public static Task<bool?> GetShowColumnGrandTotalsOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxPivotGrid_GetOption", dxTarget, "showColumnGrandTotals");
		}
		public static Task SetShowColumnGrandTotalsOption(ElementRef dxTarget, bool? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPivotGrid_SetOption", dxTarget, "showColumnGrandTotals", value);
		}
		public static Task<bool?> GetShowColumnTotalsOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxPivotGrid_GetOption", dxTarget, "showColumnTotals");
		}
		public static Task SetShowColumnTotalsOption(ElementRef dxTarget, bool? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPivotGrid_SetOption", dxTarget, "showColumnTotals", value);
		}
		public static Task<bool?> GetShowRowGrandTotalsOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxPivotGrid_GetOption", dxTarget, "showRowGrandTotals");
		}
		public static Task SetShowRowGrandTotalsOption(ElementRef dxTarget, bool? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPivotGrid_SetOption", dxTarget, "showRowGrandTotals", value);
		}
		public static Task<bool?> GetShowRowTotalsOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxPivotGrid_GetOption", dxTarget, "showRowTotals");
		}
		public static Task SetShowRowTotalsOption(ElementRef dxTarget, bool? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPivotGrid_SetOption", dxTarget, "showRowTotals", value);
		}
		public static Task<string> GetShowTotalsPriorOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxPivotGrid_GetOption", dxTarget, "showTotalsPrior");
		}
		public static Task SetShowTotalsPriorOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPivotGrid_SetOption", dxTarget, "showTotalsPrior", value);
		}
		public static Task<object> GetStateStoringOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPivotGrid_GetOption", dxTarget, "stateStoring");
		}
		public static Task SetStateStoringOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPivotGrid_SetOption", dxTarget, "stateStoring", value);
		}
		public static Task<object> GetTextsOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPivotGrid_GetOption", dxTarget, "texts");
		}
		public static Task SetTextsOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPivotGrid_SetOption", dxTarget, "texts", value);
		}
		public static Task<bool?> GetWordWrapEnabledOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxPivotGrid_GetOption", dxTarget, "wordWrapEnabled");
		}
		public static Task SetWordWrapEnabledOption(ElementRef dxTarget, bool? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPivotGrid_SetOption", dxTarget, "wordWrapEnabled", value);
		}
		public static Task<object> BindChart(ElementRef dxTarget, object chart, object integrationOptions)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPivotGrid_bindChart_0", dxTarget, chart, integrationOptions);
		}
		public static Task ExportToExcel(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPivotGrid_exportToExcel_1", dxTarget);
		}
		public static Task<object> GetDataSourceEx(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPivotGrid_getDataSource_2", dxTarget);
		}
		public static Task<object> GetFieldChooserPopup(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPivotGrid_getFieldChooserPopup_3", dxTarget);
		}
		public static Task UpdateDimensions(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPivotGrid_updateDimensions_4", dxTarget);
		}
	}
	public class DxPivotGridFieldChooserInterop: WidgetInterop
	{
		public static event EventHandler<JQueryEventArgs> ContextMenuPreparing;
		public static Task Init(ElementRef dxTarget, DevExpress.Ui.DxPivotGridFieldChooserOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPivotGridFieldChooser_Init", dxTarget, json);
		}
		[JSInvokable("DevExpress.Ui.DxPivotGridFieldChooserInterop.OnContextMenuPreparing")]
		public static void OnContextMenuPreparing(string identifier)
		{
			ContextMenuPreparing?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static Task<bool?> GetAllowSearchOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxPivotGridFieldChooser_GetOption", dxTarget, "allowSearch");
		}
		public static Task SetAllowSearchOption(ElementRef dxTarget, bool? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPivotGridFieldChooser_SetOption", dxTarget, "allowSearch", value);
		}
		public static Task<string> GetApplyChangesModeOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxPivotGridFieldChooser_GetOption", dxTarget, "applyChangesMode");
		}
		public static Task SetApplyChangesModeOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPivotGridFieldChooser_SetOption", dxTarget, "applyChangesMode", value);
		}
		public static Task<object> GetDataSourceOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPivotGridFieldChooser_GetOption", dxTarget, "dataSource");
		}
		public static Task SetDataSourceOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPivotGridFieldChooser_SetOption", dxTarget, "dataSource", value);
		}
		public static Task<object> GetHeaderFilterOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPivotGridFieldChooser_GetOption", dxTarget, "headerFilter");
		}
		public static Task SetHeaderFilterOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPivotGridFieldChooser_SetOption", dxTarget, "headerFilter", value);
		}
		public static Task<object> GetLayoutOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPivotGridFieldChooser_GetOption", dxTarget, "layout");
		}
		public static Task SetLayoutOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPivotGridFieldChooser_SetOption", dxTarget, "layout", value);
		}
		public static Task<float?> GetSearchTimeoutOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_DxPivotGridFieldChooser_GetOption", dxTarget, "searchTimeout");
		}
		public static Task SetSearchTimeoutOption(ElementRef dxTarget, float? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPivotGridFieldChooser_SetOption", dxTarget, "searchTimeout", value);
		}
		public static Task<object> GetStateOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPivotGridFieldChooser_GetOption", dxTarget, "state");
		}
		public static Task SetStateOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPivotGridFieldChooser_SetOption", dxTarget, "state", value);
		}
		public static Task<object> GetTextsOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPivotGridFieldChooser_GetOption", dxTarget, "texts");
		}
		public static Task SetTextsOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPivotGridFieldChooser_SetOption", dxTarget, "texts", value);
		}
		public static Task ApplyChanges(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPivotGridFieldChooser_applyChanges_0", dxTarget);
		}
		public static Task CancelChanges(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPivotGridFieldChooser_cancelChanges_1", dxTarget);
		}
		public static Task<object> GetDataSourceEx(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPivotGridFieldChooser_getDataSource_2", dxTarget);
		}
		public static Task UpdateDimensions(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPivotGridFieldChooser_updateDimensions_3", dxTarget);
		}
	}
	public class DxPopoverInterop: DxPopupInterop
	{
		public static Task<object> GetHideEventOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPopover_GetOption", dxTarget, "hideEvent");
		}
		public static Task SetHideEventOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPopover_SetOption", dxTarget, "hideEvent", value);
		}
		public static Task<object> GetShowEventOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPopover_GetOption", dxTarget, "showEvent");
		}
		public static Task SetShowEventOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPopover_SetOption", dxTarget, "showEvent", value);
		}
		public static Task<object> GetTargetOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPopover_GetOption", dxTarget, "target");
		}
		public static Task SetTargetOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPopover_SetOption", dxTarget, "target", value);
		}
		public static Task<object> Show(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPopover_show_0", dxTarget);
		}
		public static Task<object> Show(ElementRef dxTarget, object target)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPopover_show_1", dxTarget, target);
		}
	}
	public class DxPopupInterop: DxOverlayInterop
	{
		public static event EventHandler<JQueryEventArgs> Resize;
		public static event EventHandler<JQueryEventArgs> ResizeEnd;
		public static event EventHandler<JQueryEventArgs> ResizeStart;
		public static event EventHandler<JQueryEventArgs> TitleRendered;
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
		public static Task<object> GetContainerOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPopup_GetOption", dxTarget, "container");
		}
		public static Task SetContainerOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPopup_SetOption", dxTarget, "container", value);
		}
		public static Task<bool?> GetFullScreenOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxPopup_GetOption", dxTarget, "fullScreen");
		}
		public static Task SetFullScreenOption(ElementRef dxTarget, bool? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPopup_SetOption", dxTarget, "fullScreen", value);
		}
		public static Task<bool?> GetResizeEnabledOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxPopup_GetOption", dxTarget, "resizeEnabled");
		}
		public static Task SetResizeEnabledOption(ElementRef dxTarget, bool? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPopup_SetOption", dxTarget, "resizeEnabled", value);
		}
		public static Task<bool?> GetShowCloseButtonOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxPopup_GetOption", dxTarget, "showCloseButton");
		}
		public static Task SetShowCloseButtonOption(ElementRef dxTarget, bool? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPopup_SetOption", dxTarget, "showCloseButton", value);
		}
		public static Task<bool?> GetShowTitleOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxPopup_GetOption", dxTarget, "showTitle");
		}
		public static Task SetShowTitleOption(ElementRef dxTarget, bool? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPopup_SetOption", dxTarget, "showTitle", value);
		}
		public static Task<string> GetTitleOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxPopup_GetOption", dxTarget, "title");
		}
		public static Task SetTitleOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPopup_SetOption", dxTarget, "title", value);
		}
		public static Task<object> GetTitleTemplateOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPopup_GetOption", dxTarget, "titleTemplate");
		}
		public static Task SetTitleTemplateOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPopup_SetOption", dxTarget, "titleTemplate", value);
		}
		public static Task<object> GetToolbarItemsOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPopup_GetOption", dxTarget, "toolbarItems");
		}
		public static Task SetToolbarItemsOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPopup_SetOption", dxTarget, "toolbarItems", value);
		}
	}
	public class DxProgressBarInterop: DxTrackBarInterop
	{
		public static event EventHandler<JQueryEventArgs> Complete;
		public static Task Init(ElementRef dxTarget, DevExpress.Ui.DxProgressBarOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxProgressBar_Init", dxTarget, json);
		}
		[JSInvokable("DevExpress.Ui.DxProgressBarInterop.OnComplete")]
		public static void OnComplete(string identifier)
		{
			Complete?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static Task<bool?> GetShowStatusOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxProgressBar_GetOption", dxTarget, "showStatus");
		}
		public static Task SetShowStatusOption(ElementRef dxTarget, bool? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxProgressBar_SetOption", dxTarget, "showStatus", value);
		}
		public static Task<object> GetStatusFormatOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxProgressBar_GetOption", dxTarget, "statusFormat");
		}
		public static Task SetStatusFormatOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxProgressBar_SetOption", dxTarget, "statusFormat", value);
		}
	}
	public class DxRadioGroupInterop: EditorInterop
	{
		public static Task Init(ElementRef dxTarget, DevExpress.Ui.DxRadioGroupOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxRadioGroup_Init", dxTarget, json);
		}
		public static Task<string> GetLayoutOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxRadioGroup_GetOption", dxTarget, "layout");
		}
		public static Task SetLayoutOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxRadioGroup_SetOption", dxTarget, "layout", value);
		}
		public static Task<string> GetNameOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxRadioGroup_GetOption", dxTarget, "name");
		}
		public static Task SetNameOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxRadioGroup_SetOption", dxTarget, "name", value);
		}
		public static Task<object> GetDataSourceOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxRadioGroup_GetOption", dxTarget, "dataSource");
		}
		public static Task SetDataSourceOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxRadioGroup_SetOption", dxTarget, "dataSource", value);
		}
		public static Task<object> GetDisplayExprOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxRadioGroup_GetOption", dxTarget, "displayExpr");
		}
		public static Task SetDisplayExprOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxRadioGroup_SetOption", dxTarget, "displayExpr", value);
		}
		public static Task<object> GetItemsOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxRadioGroup_GetOption", dxTarget, "items");
		}
		public static Task SetItemsOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxRadioGroup_SetOption", dxTarget, "items", value);
		}
		public static Task<object> GetItemTemplateOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxRadioGroup_GetOption", dxTarget, "itemTemplate");
		}
		public static Task SetItemTemplateOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxRadioGroup_SetOption", dxTarget, "itemTemplate", value);
		}
		public static Task<object> GetValueExprOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxRadioGroup_GetOption", dxTarget, "valueExpr");
		}
		public static Task SetValueExprOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxRadioGroup_SetOption", dxTarget, "valueExpr", value);
		}
		public static Task<object> GetDataSourceEx(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxRadioGroup_getDataSource_0", dxTarget);
		}
	}
	public class DxRangeSliderInterop: DxSliderBaseInterop
	{
		public static Task Init(ElementRef dxTarget, DevExpress.Ui.DxRangeSliderOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxRangeSlider_Init", dxTarget, json);
		}
		public static Task<float?> GetEndOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_DxRangeSlider_GetOption", dxTarget, "end");
		}
		public static Task SetEndOption(ElementRef dxTarget, float? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxRangeSlider_SetOption", dxTarget, "end", value);
		}
		public static Task<string> GetEndNameOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxRangeSlider_GetOption", dxTarget, "endName");
		}
		public static Task SetEndNameOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxRangeSlider_SetOption", dxTarget, "endName", value);
		}
		public static Task<float?> GetStartOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_DxRangeSlider_GetOption", dxTarget, "start");
		}
		public static Task SetStartOption(ElementRef dxTarget, float? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxRangeSlider_SetOption", dxTarget, "start", value);
		}
		public static Task<string> GetStartNameOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxRangeSlider_GetOption", dxTarget, "startName");
		}
		public static Task SetStartNameOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxRangeSlider_SetOption", dxTarget, "startName", value);
		}
		public static Task Reset(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxRangeSlider_reset_0", dxTarget);
		}
	}
	public class DxRecurrenceEditorInterop: EditorInterop
	{
		public static Task Init(ElementRef dxTarget, DevExpress.Ui.DxRecurrenceEditorOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxRecurrenceEditor_Init", dxTarget, json);
		}
	}
	public class DxResizableInterop: DOMComponentInterop
	{
		public static event EventHandler<JQueryEventArgs> Resize;
		public static event EventHandler<JQueryEventArgs> ResizeEnd;
		public static event EventHandler<JQueryEventArgs> ResizeStart;
		public static Task Init(ElementRef dxTarget, DevExpress.Ui.DxResizableOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxResizable_Init", dxTarget, json);
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
		public static Task<object> GetHandlesOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxResizable_GetOption", dxTarget, "handles");
		}
		public static Task SetHandlesOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxResizable_SetOption", dxTarget, "handles", value);
		}
		public static Task<float?> GetMaxHeightOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_DxResizable_GetOption", dxTarget, "maxHeight");
		}
		public static Task SetMaxHeightOption(ElementRef dxTarget, float? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxResizable_SetOption", dxTarget, "maxHeight", value);
		}
		public static Task<float?> GetMaxWidthOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_DxResizable_GetOption", dxTarget, "maxWidth");
		}
		public static Task SetMaxWidthOption(ElementRef dxTarget, float? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxResizable_SetOption", dxTarget, "maxWidth", value);
		}
		public static Task<float?> GetMinHeightOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_DxResizable_GetOption", dxTarget, "minHeight");
		}
		public static Task SetMinHeightOption(ElementRef dxTarget, float? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxResizable_SetOption", dxTarget, "minHeight", value);
		}
		public static Task<float?> GetMinWidthOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_DxResizable_GetOption", dxTarget, "minWidth");
		}
		public static Task SetMinWidthOption(ElementRef dxTarget, float? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxResizable_SetOption", dxTarget, "minWidth", value);
		}
	}
	public class DxResponsiveBoxInterop: CollectionWidgetInterop
	{
		public static Task Init(ElementRef dxTarget, DevExpress.Ui.DxResponsiveBoxOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxResponsiveBox_Init", dxTarget, json);
		}
		public static Task<object> GetColsOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxResponsiveBox_GetOption", dxTarget, "cols");
		}
		public static Task SetColsOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxResponsiveBox_SetOption", dxTarget, "cols", value);
		}
		public static Task<object> GetRowsOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxResponsiveBox_GetOption", dxTarget, "rows");
		}
		public static Task SetRowsOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxResponsiveBox_SetOption", dxTarget, "rows", value);
		}
		public static Task<object> GetScreenByWidthOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxResponsiveBox_GetOption", dxTarget, "screenByWidth");
		}
		public static Task SetScreenByWidthOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxResponsiveBox_SetOption", dxTarget, "screenByWidth", value);
		}
		public static Task<string> GetSingleColumnScreenOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxResponsiveBox_GetOption", dxTarget, "singleColumnScreen");
		}
		public static Task SetSingleColumnScreenOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxResponsiveBox_SetOption", dxTarget, "singleColumnScreen", value);
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
		public static Task Init(ElementRef dxTarget, DevExpress.Ui.DxSchedulerOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScheduler_Init", dxTarget, json);
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
		public static Task<string> GetAllDayExprOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxScheduler_GetOption", dxTarget, "allDayExpr");
		}
		public static Task SetAllDayExprOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScheduler_SetOption", dxTarget, "allDayExpr", value);
		}
		public static Task<object> GetAppointmentTemplateOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScheduler_GetOption", dxTarget, "appointmentTemplate");
		}
		public static Task SetAppointmentTemplateOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScheduler_SetOption", dxTarget, "appointmentTemplate", value);
		}
		public static Task<object> GetAppointmentTooltipTemplateOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScheduler_GetOption", dxTarget, "appointmentTooltipTemplate");
		}
		public static Task SetAppointmentTooltipTemplateOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScheduler_SetOption", dxTarget, "appointmentTooltipTemplate", value);
		}
		public static Task<float?> GetCellDurationOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_DxScheduler_GetOption", dxTarget, "cellDuration");
		}
		public static Task SetCellDurationOption(ElementRef dxTarget, float? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScheduler_SetOption", dxTarget, "cellDuration", value);
		}
		public static Task<bool?> GetCrossScrollingEnabledOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxScheduler_GetOption", dxTarget, "crossScrollingEnabled");
		}
		public static Task SetCrossScrollingEnabledOption(ElementRef dxTarget, bool? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScheduler_SetOption", dxTarget, "crossScrollingEnabled", value);
		}
		public static Task<object> GetCurrentDateOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScheduler_GetOption", dxTarget, "currentDate");
		}
		public static Task SetCurrentDateOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScheduler_SetOption", dxTarget, "currentDate", value);
		}
		public static Task<string> GetCurrentViewOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxScheduler_GetOption", dxTarget, "currentView");
		}
		public static Task SetCurrentViewOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScheduler_SetOption", dxTarget, "currentView", value);
		}
		public static Task<object> GetDataCellTemplateOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScheduler_GetOption", dxTarget, "dataCellTemplate");
		}
		public static Task SetDataCellTemplateOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScheduler_SetOption", dxTarget, "dataCellTemplate", value);
		}
		public static Task<object> GetDataSourceOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScheduler_GetOption", dxTarget, "dataSource");
		}
		public static Task SetDataSourceOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScheduler_SetOption", dxTarget, "dataSource", value);
		}
		public static Task<object> GetDateCellTemplateOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScheduler_GetOption", dxTarget, "dateCellTemplate");
		}
		public static Task SetDateCellTemplateOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScheduler_SetOption", dxTarget, "dateCellTemplate", value);
		}
		public static Task<string> GetDateSerializationFormatOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxScheduler_GetOption", dxTarget, "dateSerializationFormat");
		}
		public static Task SetDateSerializationFormatOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScheduler_SetOption", dxTarget, "dateSerializationFormat", value);
		}
		public static Task<string> GetDescriptionExprOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxScheduler_GetOption", dxTarget, "descriptionExpr");
		}
		public static Task SetDescriptionExprOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScheduler_SetOption", dxTarget, "descriptionExpr", value);
		}
		public static Task<object> GetDropDownAppointmentTemplateOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScheduler_GetOption", dxTarget, "dropDownAppointmentTemplate");
		}
		public static Task SetDropDownAppointmentTemplateOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScheduler_SetOption", dxTarget, "dropDownAppointmentTemplate", value);
		}
		public static Task<object> GetEditingOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScheduler_GetOption", dxTarget, "editing");
		}
		public static Task SetEditingOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScheduler_SetOption", dxTarget, "editing", value);
		}
		public static Task<string> GetEndDateExprOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxScheduler_GetOption", dxTarget, "endDateExpr");
		}
		public static Task SetEndDateExprOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScheduler_SetOption", dxTarget, "endDateExpr", value);
		}
		public static Task<string> GetEndDateTimeZoneExprOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxScheduler_GetOption", dxTarget, "endDateTimeZoneExpr");
		}
		public static Task SetEndDateTimeZoneExprOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScheduler_SetOption", dxTarget, "endDateTimeZoneExpr", value);
		}
		public static Task<float?> GetEndDayHourOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_DxScheduler_GetOption", dxTarget, "endDayHour");
		}
		public static Task SetEndDayHourOption(ElementRef dxTarget, float? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScheduler_SetOption", dxTarget, "endDayHour", value);
		}
		public static Task<object> GetFirstDayOfWeekOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScheduler_GetOption", dxTarget, "firstDayOfWeek");
		}
		public static Task SetFirstDayOfWeekOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScheduler_SetOption", dxTarget, "firstDayOfWeek", value);
		}
		public static Task<bool?> GetGroupByDateOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxScheduler_GetOption", dxTarget, "groupByDate");
		}
		public static Task SetGroupByDateOption(ElementRef dxTarget, bool? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScheduler_SetOption", dxTarget, "groupByDate", value);
		}
		public static Task<object> GetGroupsOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScheduler_GetOption", dxTarget, "groups");
		}
		public static Task SetGroupsOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScheduler_SetOption", dxTarget, "groups", value);
		}
		public static Task<float?> GetIndicatorUpdateIntervalOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_DxScheduler_GetOption", dxTarget, "indicatorUpdateInterval");
		}
		public static Task SetIndicatorUpdateIntervalOption(ElementRef dxTarget, float? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScheduler_SetOption", dxTarget, "indicatorUpdateInterval", value);
		}
		public static Task<object> GetMaxOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScheduler_GetOption", dxTarget, "max");
		}
		public static Task SetMaxOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScheduler_SetOption", dxTarget, "max", value);
		}
		public static Task<object> GetMaxAppointmentsPerCellOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScheduler_GetOption", dxTarget, "maxAppointmentsPerCell");
		}
		public static Task SetMaxAppointmentsPerCellOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScheduler_SetOption", dxTarget, "maxAppointmentsPerCell", value);
		}
		public static Task<object> GetMinOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScheduler_GetOption", dxTarget, "min");
		}
		public static Task SetMinOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScheduler_SetOption", dxTarget, "min", value);
		}
		public static Task<string> GetNoDataTextOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxScheduler_GetOption", dxTarget, "noDataText");
		}
		public static Task SetNoDataTextOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScheduler_SetOption", dxTarget, "noDataText", value);
		}
		public static Task<string> GetRecurrenceEditModeOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxScheduler_GetOption", dxTarget, "recurrenceEditMode");
		}
		public static Task SetRecurrenceEditModeOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScheduler_SetOption", dxTarget, "recurrenceEditMode", value);
		}
		public static Task<string> GetRecurrenceExceptionExprOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxScheduler_GetOption", dxTarget, "recurrenceExceptionExpr");
		}
		public static Task SetRecurrenceExceptionExprOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScheduler_SetOption", dxTarget, "recurrenceExceptionExpr", value);
		}
		public static Task<string> GetRecurrenceRuleExprOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxScheduler_GetOption", dxTarget, "recurrenceRuleExpr");
		}
		public static Task SetRecurrenceRuleExprOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScheduler_SetOption", dxTarget, "recurrenceRuleExpr", value);
		}
		public static Task<bool?> GetRemoteFilteringOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxScheduler_GetOption", dxTarget, "remoteFiltering");
		}
		public static Task SetRemoteFilteringOption(ElementRef dxTarget, bool? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScheduler_SetOption", dxTarget, "remoteFiltering", value);
		}
		public static Task<object> GetResourceCellTemplateOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScheduler_GetOption", dxTarget, "resourceCellTemplate");
		}
		public static Task SetResourceCellTemplateOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScheduler_SetOption", dxTarget, "resourceCellTemplate", value);
		}
		public static Task<object> GetResourcesOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScheduler_GetOption", dxTarget, "resources");
		}
		public static Task SetResourcesOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScheduler_SetOption", dxTarget, "resources", value);
		}
		public static Task<object> GetSelectedCellDataOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScheduler_GetOption", dxTarget, "selectedCellData");
		}
		public static Task SetSelectedCellDataOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScheduler_SetOption", dxTarget, "selectedCellData", value);
		}
		public static Task<bool?> GetShadeUntilCurrentTimeOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxScheduler_GetOption", dxTarget, "shadeUntilCurrentTime");
		}
		public static Task SetShadeUntilCurrentTimeOption(ElementRef dxTarget, bool? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScheduler_SetOption", dxTarget, "shadeUntilCurrentTime", value);
		}
		public static Task<bool?> GetShowAllDayPanelOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxScheduler_GetOption", dxTarget, "showAllDayPanel");
		}
		public static Task SetShowAllDayPanelOption(ElementRef dxTarget, bool? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScheduler_SetOption", dxTarget, "showAllDayPanel", value);
		}
		public static Task<bool?> GetShowCurrentTimeIndicatorOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxScheduler_GetOption", dxTarget, "showCurrentTimeIndicator");
		}
		public static Task SetShowCurrentTimeIndicatorOption(ElementRef dxTarget, bool? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScheduler_SetOption", dxTarget, "showCurrentTimeIndicator", value);
		}
		public static Task<string> GetStartDateExprOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxScheduler_GetOption", dxTarget, "startDateExpr");
		}
		public static Task SetStartDateExprOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScheduler_SetOption", dxTarget, "startDateExpr", value);
		}
		public static Task<string> GetStartDateTimeZoneExprOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxScheduler_GetOption", dxTarget, "startDateTimeZoneExpr");
		}
		public static Task SetStartDateTimeZoneExprOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScheduler_SetOption", dxTarget, "startDateTimeZoneExpr", value);
		}
		public static Task<float?> GetStartDayHourOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_DxScheduler_GetOption", dxTarget, "startDayHour");
		}
		public static Task SetStartDayHourOption(ElementRef dxTarget, float? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScheduler_SetOption", dxTarget, "startDayHour", value);
		}
		public static Task<string> GetTextExprOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxScheduler_GetOption", dxTarget, "textExpr");
		}
		public static Task SetTextExprOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScheduler_SetOption", dxTarget, "textExpr", value);
		}
		public static Task<object> GetTimeCellTemplateOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScheduler_GetOption", dxTarget, "timeCellTemplate");
		}
		public static Task SetTimeCellTemplateOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScheduler_SetOption", dxTarget, "timeCellTemplate", value);
		}
		public static Task<string> GetTimeZoneOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxScheduler_GetOption", dxTarget, "timeZone");
		}
		public static Task SetTimeZoneOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScheduler_SetOption", dxTarget, "timeZone", value);
		}
		public static Task<bool?> GetUseDropDownViewSwitcherOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxScheduler_GetOption", dxTarget, "useDropDownViewSwitcher");
		}
		public static Task SetUseDropDownViewSwitcherOption(ElementRef dxTarget, bool? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScheduler_SetOption", dxTarget, "useDropDownViewSwitcher", value);
		}
		public static Task<object> GetViewsOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScheduler_GetOption", dxTarget, "views");
		}
		public static Task SetViewsOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScheduler_SetOption", dxTarget, "views", value);
		}
		public static Task AddAppointment(ElementRef dxTarget, object appointment)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScheduler_addAppointment_0", dxTarget, appointment);
		}
		public static Task DeleteAppointment(ElementRef dxTarget, object appointment)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScheduler_deleteAppointment_1", dxTarget, appointment);
		}
		public static Task<object> GetDataSourceEx(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScheduler_getDataSource_2", dxTarget);
		}
		public static Task<object> GetEndViewDate(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScheduler_getEndViewDate_3", dxTarget);
		}
		public static Task<object> GetStartViewDate(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScheduler_getStartViewDate_4", dxTarget);
		}
		public static Task HideAppointmentPopup(ElementRef dxTarget, bool saveChanges)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScheduler_hideAppointmentPopup_5", dxTarget, saveChanges);
		}
		public static Task HideAppointmentTooltip(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScheduler_hideAppointmentTooltip_6", dxTarget);
		}
		public static Task RegisterKeyHandler(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScheduler_registerKeyHandler_7", dxTarget);
		}
		public static Task ScrollToTime(ElementRef dxTarget, float hours, float minutes, object date)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScheduler_scrollToTime_8", dxTarget, hours, minutes, date);
		}
		public static Task ShowAppointmentPopup(ElementRef dxTarget, object appointmentData, bool createNewAppointment, object currentAppointmentData)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScheduler_showAppointmentPopup_9", dxTarget, appointmentData, createNewAppointment, currentAppointmentData);
		}
		public static Task ShowAppointmentTooltip(ElementRef dxTarget, object appointmentData, object target, object currentAppointmentData)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScheduler_showAppointmentTooltip_10", dxTarget, appointmentData, target, currentAppointmentData);
		}
		public static Task UpdateAppointment(ElementRef dxTarget, object target, object appointment)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScheduler_updateAppointment_11", dxTarget, target, appointment);
		}
	}
	public class DxScrollViewInterop: DxScrollableInterop
	{
		public static event EventHandler<JQueryEventArgs> PullDown;
		public static event EventHandler<JQueryEventArgs> ReachBottom;
		public static Task Init(ElementRef dxTarget, DevExpress.Ui.DxScrollViewOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScrollView_Init", dxTarget, json);
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
		public static Task<string> GetPulledDownTextOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxScrollView_GetOption", dxTarget, "pulledDownText");
		}
		public static Task SetPulledDownTextOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScrollView_SetOption", dxTarget, "pulledDownText", value);
		}
		public static Task<string> GetPullingDownTextOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxScrollView_GetOption", dxTarget, "pullingDownText");
		}
		public static Task SetPullingDownTextOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScrollView_SetOption", dxTarget, "pullingDownText", value);
		}
		public static Task<string> GetReachBottomTextOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxScrollView_GetOption", dxTarget, "reachBottomText");
		}
		public static Task SetReachBottomTextOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScrollView_SetOption", dxTarget, "reachBottomText", value);
		}
		public static Task<string> GetRefreshingTextOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxScrollView_GetOption", dxTarget, "refreshingText");
		}
		public static Task SetRefreshingTextOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScrollView_SetOption", dxTarget, "refreshingText", value);
		}
		public static Task Refresh(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScrollView_refresh_0", dxTarget);
		}
		public static Task<object> Release(ElementRef dxTarget, bool preventScrollBottom)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScrollView_release_1", dxTarget, preventScrollBottom);
		}
	}
	public class DxSelectBoxInterop: DxDropDownListInterop
	{
		public static event EventHandler<JQueryEventArgs> CustomItemCreating;
		[JSInvokable("DevExpress.Ui.DxSelectBoxInterop.OnCustomItemCreating")]
		public static void OnCustomItemCreating(string identifier)
		{
			CustomItemCreating?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static Task<object> GetFieldTemplateOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxSelectBox_GetOption", dxTarget, "fieldTemplate");
		}
		public static Task SetFieldTemplateOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxSelectBox_SetOption", dxTarget, "fieldTemplate", value);
		}
		public static Task<bool?> GetShowSelectionControlsOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxSelectBox_GetOption", dxTarget, "showSelectionControls");
		}
		public static Task SetShowSelectionControlsOption(ElementRef dxTarget, bool? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxSelectBox_SetOption", dxTarget, "showSelectionControls", value);
		}
	}
	public class DxSliderInterop: DxSliderBaseInterop
	{
		public static Task Init(ElementRef dxTarget, DevExpress.Ui.DxSliderOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxSlider_Init", dxTarget, json);
		}
	}
	public class DxSlideOutInterop: CollectionWidgetInterop
	{
		public static event EventHandler<JQueryEventArgs> MenuGroupRendered;
		public static event EventHandler<JQueryEventArgs> MenuItemRendered;
		public static Task Init(ElementRef dxTarget, DevExpress.Ui.DxSlideOutOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxSlideOut_Init", dxTarget, json);
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
		public static Task<object> GetContentTemplateOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxSlideOut_GetOption", dxTarget, "contentTemplate");
		}
		public static Task SetContentTemplateOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxSlideOut_SetOption", dxTarget, "contentTemplate", value);
		}
		public static Task<bool?> GetMenuGroupedOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxSlideOut_GetOption", dxTarget, "menuGrouped");
		}
		public static Task SetMenuGroupedOption(ElementRef dxTarget, bool? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxSlideOut_SetOption", dxTarget, "menuGrouped", value);
		}
		public static Task<object> GetMenuGroupTemplateOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxSlideOut_GetOption", dxTarget, "menuGroupTemplate");
		}
		public static Task SetMenuGroupTemplateOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxSlideOut_SetOption", dxTarget, "menuGroupTemplate", value);
		}
		public static Task<object> GetMenuItemTemplateOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxSlideOut_GetOption", dxTarget, "menuItemTemplate");
		}
		public static Task SetMenuItemTemplateOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxSlideOut_SetOption", dxTarget, "menuItemTemplate", value);
		}
		public static Task<string> GetMenuPositionOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxSlideOut_GetOption", dxTarget, "menuPosition");
		}
		public static Task SetMenuPositionOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxSlideOut_SetOption", dxTarget, "menuPosition", value);
		}
		public static Task<bool?> GetMenuVisibleOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxSlideOut_GetOption", dxTarget, "menuVisible");
		}
		public static Task SetMenuVisibleOption(ElementRef dxTarget, bool? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxSlideOut_SetOption", dxTarget, "menuVisible", value);
		}
		public static Task<bool?> GetSwipeEnabledOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxSlideOut_GetOption", dxTarget, "swipeEnabled");
		}
		public static Task SetSwipeEnabledOption(ElementRef dxTarget, bool? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxSlideOut_SetOption", dxTarget, "swipeEnabled", value);
		}
		public static Task<object> HideMenu(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxSlideOut_hideMenu_0", dxTarget);
		}
		public static Task<object> ShowMenu(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxSlideOut_showMenu_1", dxTarget);
		}
		public static Task<object> ToggleMenuVisibility(ElementRef dxTarget, bool showing)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxSlideOut_toggleMenuVisibility_2", dxTarget, showing);
		}
	}
	public class DxSlideOutViewInterop: WidgetInterop
	{
		public static Task Init(ElementRef dxTarget, DevExpress.Ui.DxSlideOutViewOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxSlideOutView_Init", dxTarget, json);
		}
		public static Task<object> GetContentTemplateOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxSlideOutView_GetOption", dxTarget, "contentTemplate");
		}
		public static Task SetContentTemplateOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxSlideOutView_SetOption", dxTarget, "contentTemplate", value);
		}
		public static Task<string> GetMenuPositionOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxSlideOutView_GetOption", dxTarget, "menuPosition");
		}
		public static Task SetMenuPositionOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxSlideOutView_SetOption", dxTarget, "menuPosition", value);
		}
		public static Task<object> GetMenuTemplateOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxSlideOutView_GetOption", dxTarget, "menuTemplate");
		}
		public static Task SetMenuTemplateOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxSlideOutView_SetOption", dxTarget, "menuTemplate", value);
		}
		public static Task<bool?> GetMenuVisibleOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxSlideOutView_GetOption", dxTarget, "menuVisible");
		}
		public static Task SetMenuVisibleOption(ElementRef dxTarget, bool? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxSlideOutView_SetOption", dxTarget, "menuVisible", value);
		}
		public static Task<bool?> GetSwipeEnabledOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxSlideOutView_GetOption", dxTarget, "swipeEnabled");
		}
		public static Task SetSwipeEnabledOption(ElementRef dxTarget, bool? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxSlideOutView_SetOption", dxTarget, "swipeEnabled", value);
		}
		public static Task<object> Content(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxSlideOutView_content_0", dxTarget);
		}
		public static Task<object> HideMenu(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxSlideOutView_hideMenu_1", dxTarget);
		}
		public static Task<object> MenuContent(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxSlideOutView_menuContent_2", dxTarget);
		}
		public static Task<object> ShowMenu(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxSlideOutView_showMenu_3", dxTarget);
		}
		public static Task<object> ToggleMenuVisibility(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxSlideOutView_toggleMenuVisibility_4", dxTarget);
		}
	}
	public class DxSwitchInterop: EditorInterop
	{
		public static Task Init(ElementRef dxTarget, DevExpress.Ui.DxSwitchOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxSwitch_Init", dxTarget, json);
		}
		public static Task<string> GetNameOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxSwitch_GetOption", dxTarget, "name");
		}
		public static Task SetNameOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxSwitch_SetOption", dxTarget, "name", value);
		}
		public static Task<string> GetOffTextOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxSwitch_GetOption", dxTarget, "offText");
		}
		public static Task SetOffTextOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxSwitch_SetOption", dxTarget, "offText", value);
		}
		public static Task<string> GetOnTextOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxSwitch_GetOption", dxTarget, "onText");
		}
		public static Task SetOnTextOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxSwitch_SetOption", dxTarget, "onText", value);
		}
		public static Task<string> GetSwitchedOffTextOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxSwitch_GetOption", dxTarget, "switchedOffText");
		}
		public static Task SetSwitchedOffTextOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxSwitch_SetOption", dxTarget, "switchedOffText", value);
		}
		public static Task<string> GetSwitchedOnTextOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxSwitch_GetOption", dxTarget, "switchedOnText");
		}
		public static Task SetSwitchedOnTextOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxSwitch_SetOption", dxTarget, "switchedOnText", value);
		}
	}
	public class DxTabsInterop: CollectionWidgetInterop
	{
		public static Task<bool?> GetRepaintChangesOnlyOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxTabs_GetOption", dxTarget, "repaintChangesOnly");
		}
		public static Task SetRepaintChangesOnlyOption(ElementRef dxTarget, bool? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTabs_SetOption", dxTarget, "repaintChangesOnly", value);
		}
		public static Task<bool?> GetScrollByContentOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxTabs_GetOption", dxTarget, "scrollByContent");
		}
		public static Task SetScrollByContentOption(ElementRef dxTarget, bool? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTabs_SetOption", dxTarget, "scrollByContent", value);
		}
		public static Task<bool?> GetScrollingEnabledOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxTabs_GetOption", dxTarget, "scrollingEnabled");
		}
		public static Task SetScrollingEnabledOption(ElementRef dxTarget, bool? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTabs_SetOption", dxTarget, "scrollingEnabled", value);
		}
		public static Task<string> GetSelectionModeOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxTabs_GetOption", dxTarget, "selectionMode");
		}
		public static Task SetSelectionModeOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTabs_SetOption", dxTarget, "selectionMode", value);
		}
		public static Task<bool?> GetShowNavButtonsOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxTabs_GetOption", dxTarget, "showNavButtons");
		}
		public static Task SetShowNavButtonsOption(ElementRef dxTarget, bool? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTabs_SetOption", dxTarget, "showNavButtons", value);
		}
	}
	public class DxTabPanelInterop: DxMultiViewInterop
	{
		public static event EventHandler<JQueryEventArgs> TitleClick;
		public static event EventHandler<JQueryEventArgs> TitleHold;
		public static event EventHandler<JQueryEventArgs> TitleRendered;
		public static Task Init(ElementRef dxTarget, DevExpress.Ui.DxTabPanelOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTabPanel_Init", dxTarget, json);
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
		public static Task<object> GetItemTitleTemplateOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTabPanel_GetOption", dxTarget, "itemTitleTemplate");
		}
		public static Task SetItemTitleTemplateOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTabPanel_SetOption", dxTarget, "itemTitleTemplate", value);
		}
		public static Task<bool?> GetRepaintChangesOnlyOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxTabPanel_GetOption", dxTarget, "repaintChangesOnly");
		}
		public static Task SetRepaintChangesOnlyOption(ElementRef dxTarget, bool? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTabPanel_SetOption", dxTarget, "repaintChangesOnly", value);
		}
		public static Task<bool?> GetScrollByContentOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxTabPanel_GetOption", dxTarget, "scrollByContent");
		}
		public static Task SetScrollByContentOption(ElementRef dxTarget, bool? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTabPanel_SetOption", dxTarget, "scrollByContent", value);
		}
		public static Task<bool?> GetScrollingEnabledOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxTabPanel_GetOption", dxTarget, "scrollingEnabled");
		}
		public static Task SetScrollingEnabledOption(ElementRef dxTarget, bool? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTabPanel_SetOption", dxTarget, "scrollingEnabled", value);
		}
		public static Task<bool?> GetShowNavButtonsOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxTabPanel_GetOption", dxTarget, "showNavButtons");
		}
		public static Task SetShowNavButtonsOption(ElementRef dxTarget, bool? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTabPanel_SetOption", dxTarget, "showNavButtons", value);
		}
	}
	public class DxTagBoxInterop: DxSelectBoxInterop
	{
		public static event EventHandler<JQueryEventArgs> MultiTagPreparing;
		public static event EventHandler<JQueryEventArgs> SelectAllValueChanged;
		public static Task Init(ElementRef dxTarget, DevExpress.Ui.DxTagBoxOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTagBox_Init", dxTarget, json);
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
		public static Task<bool?> GetHideSelectedItemsOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxTagBox_GetOption", dxTarget, "hideSelectedItems");
		}
		public static Task SetHideSelectedItemsOption(ElementRef dxTarget, bool? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTagBox_SetOption", dxTarget, "hideSelectedItems", value);
		}
		public static Task<float?> GetMaxDisplayedTagsOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_DxTagBox_GetOption", dxTarget, "maxDisplayedTags");
		}
		public static Task SetMaxDisplayedTagsOption(ElementRef dxTarget, float? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTagBox_SetOption", dxTarget, "maxDisplayedTags", value);
		}
		public static Task<bool?> GetMultilineOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxTagBox_GetOption", dxTarget, "multiline");
		}
		public static Task SetMultilineOption(ElementRef dxTarget, bool? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTagBox_SetOption", dxTarget, "multiline", value);
		}
		public static Task<string> GetSelectAllModeOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxTagBox_GetOption", dxTarget, "selectAllMode");
		}
		public static Task SetSelectAllModeOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTagBox_SetOption", dxTarget, "selectAllMode", value);
		}
		public static Task<object> GetSelectedItemsOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTagBox_GetOption", dxTarget, "selectedItems");
		}
		public static Task SetSelectedItemsOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTagBox_SetOption", dxTarget, "selectedItems", value);
		}
		public static Task<bool?> GetShowMultiTagOnlyOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxTagBox_GetOption", dxTarget, "showMultiTagOnly");
		}
		public static Task SetShowMultiTagOnlyOption(ElementRef dxTarget, bool? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTagBox_SetOption", dxTarget, "showMultiTagOnly", value);
		}
		public static Task<object> GetTagTemplateOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTagBox_GetOption", dxTarget, "tagTemplate");
		}
		public static Task SetTagTemplateOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTagBox_SetOption", dxTarget, "tagTemplate", value);
		}
	}
	public class DxTextAreaInterop: DxTextBoxInterop
	{
		public static Task Init(ElementRef dxTarget, DevExpress.Ui.DxTextAreaOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTextArea_Init", dxTarget, json);
		}
		public static Task<bool?> GetAutoResizeEnabledOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxTextArea_GetOption", dxTarget, "autoResizeEnabled");
		}
		public static Task SetAutoResizeEnabledOption(ElementRef dxTarget, bool? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTextArea_SetOption", dxTarget, "autoResizeEnabled", value);
		}
		public static Task<object> GetMaxHeightOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTextArea_GetOption", dxTarget, "maxHeight");
		}
		public static Task SetMaxHeightOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTextArea_SetOption", dxTarget, "maxHeight", value);
		}
		public static Task<object> GetMinHeightOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTextArea_GetOption", dxTarget, "minHeight");
		}
		public static Task SetMinHeightOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTextArea_SetOption", dxTarget, "minHeight", value);
		}
	}
	public class DxTextBoxInterop: DxTextEditorInterop
	{
		public static Task<object> GetMaxLengthOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTextBox_GetOption", dxTarget, "maxLength");
		}
		public static Task SetMaxLengthOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTextBox_SetOption", dxTarget, "maxLength", value);
		}
		public static Task<string> GetModeOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxTextBox_GetOption", dxTarget, "mode");
		}
		public static Task SetModeOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTextBox_SetOption", dxTarget, "mode", value);
		}
	}
	public class DxTileViewInterop: CollectionWidgetInterop
	{
		public static Task Init(ElementRef dxTarget, DevExpress.Ui.DxTileViewOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTileView_Init", dxTarget, json);
		}
		public static Task<float?> GetBaseItemHeightOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_DxTileView_GetOption", dxTarget, "baseItemHeight");
		}
		public static Task SetBaseItemHeightOption(ElementRef dxTarget, float? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTileView_SetOption", dxTarget, "baseItemHeight", value);
		}
		public static Task<float?> GetBaseItemWidthOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_DxTileView_GetOption", dxTarget, "baseItemWidth");
		}
		public static Task SetBaseItemWidthOption(ElementRef dxTarget, float? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTileView_SetOption", dxTarget, "baseItemWidth", value);
		}
		public static Task<string> GetDirectionOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxTileView_GetOption", dxTarget, "direction");
		}
		public static Task SetDirectionOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTileView_SetOption", dxTarget, "direction", value);
		}
		public static Task<float?> GetItemMarginOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_DxTileView_GetOption", dxTarget, "itemMargin");
		}
		public static Task SetItemMarginOption(ElementRef dxTarget, float? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTileView_SetOption", dxTarget, "itemMargin", value);
		}
		public static Task<bool?> GetShowScrollbarOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxTileView_GetOption", dxTarget, "showScrollbar");
		}
		public static Task SetShowScrollbarOption(ElementRef dxTarget, bool? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTileView_SetOption", dxTarget, "showScrollbar", value);
		}
		public static Task<float> ScrollPosition(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<float>("BlazorDevExtreme_DxTileView_scrollPosition_0", dxTarget);
		}
	}
	public class DxToastInterop: DxOverlayInterop
	{
		public static Task Init(ElementRef dxTarget, DevExpress.Ui.DxToastOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxToast_Init", dxTarget, json);
		}
		public static Task<bool?> GetCloseOnClickOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxToast_GetOption", dxTarget, "closeOnClick");
		}
		public static Task SetCloseOnClickOption(ElementRef dxTarget, bool? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxToast_SetOption", dxTarget, "closeOnClick", value);
		}
		public static Task<bool?> GetCloseOnSwipeOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxToast_GetOption", dxTarget, "closeOnSwipe");
		}
		public static Task SetCloseOnSwipeOption(ElementRef dxTarget, bool? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxToast_SetOption", dxTarget, "closeOnSwipe", value);
		}
		public static Task<float?> GetDisplayTimeOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_DxToast_GetOption", dxTarget, "displayTime");
		}
		public static Task SetDisplayTimeOption(ElementRef dxTarget, float? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxToast_SetOption", dxTarget, "displayTime", value);
		}
		public static Task<string> GetMessageOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxToast_GetOption", dxTarget, "message");
		}
		public static Task SetMessageOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxToast_SetOption", dxTarget, "message", value);
		}
		public static Task<string> GetTypeOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxToast_GetOption", dxTarget, "type");
		}
		public static Task SetTypeOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxToast_SetOption", dxTarget, "type", value);
		}
	}
	public class DxToolbarInterop: CollectionWidgetInterop
	{
		public static Task Init(ElementRef dxTarget, DevExpress.Ui.DxToolbarOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxToolbar_Init", dxTarget, json);
		}
		public static Task<object> GetMenuItemTemplateOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxToolbar_GetOption", dxTarget, "menuItemTemplate");
		}
		public static Task SetMenuItemTemplateOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxToolbar_SetOption", dxTarget, "menuItemTemplate", value);
		}
		public static Task<string> GetRenderAsOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxToolbar_GetOption", dxTarget, "renderAs");
		}
		public static Task SetRenderAsOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxToolbar_SetOption", dxTarget, "renderAs", value);
		}
	}
	public class DxTooltipInterop: DxPopoverInterop
	{
		public static Task Init(ElementRef dxTarget, DevExpress.Ui.DxTooltipOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTooltip_Init", dxTarget, json);
		}
	}
	public class DxTrackBarInterop: EditorInterop
	{
		public static Task<float?> GetMaxOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_DxTrackBar_GetOption", dxTarget, "max");
		}
		public static Task SetMaxOption(ElementRef dxTarget, float? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTrackBar_SetOption", dxTarget, "max", value);
		}
		public static Task<float?> GetMinOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_DxTrackBar_GetOption", dxTarget, "min");
		}
		public static Task SetMinOption(ElementRef dxTarget, float? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTrackBar_SetOption", dxTarget, "min", value);
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
		public static event EventHandler<JQueryEventArgs> FocusedCellChanged;
		public static event EventHandler<JQueryEventArgs> FocusedCellChanging;
		public static event EventHandler<JQueryEventArgs> FocusedRowChanged;
		public static event EventHandler<JQueryEventArgs> FocusedRowChanging;
		public static event EventHandler<JQueryEventArgs> NodesInitialized;
		public static event EventHandler<JQueryEventArgs> RowClick;
		public static event EventHandler<JQueryEventArgs> RowPrepared;
		public static Task Init(ElementRef dxTarget, DevExpress.Ui.DxTreeListOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeList_Init", dxTarget, json);
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
		[JSInvokable("DevExpress.Ui.DxTreeListInterop.OnFocusedCellChanged")]
		public static void OnFocusedCellChanged(string identifier)
		{
			FocusedCellChanged?.Invoke(null, new JQueryEventArgs(identifier));
		}
		[JSInvokable("DevExpress.Ui.DxTreeListInterop.OnFocusedCellChanging")]
		public static void OnFocusedCellChanging(string identifier)
		{
			FocusedCellChanging?.Invoke(null, new JQueryEventArgs(identifier));
		}
		[JSInvokable("DevExpress.Ui.DxTreeListInterop.OnFocusedRowChanged")]
		public static void OnFocusedRowChanged(string identifier)
		{
			FocusedRowChanged?.Invoke(null, new JQueryEventArgs(identifier));
		}
		[JSInvokable("DevExpress.Ui.DxTreeListInterop.OnFocusedRowChanging")]
		public static void OnFocusedRowChanging(string identifier)
		{
			FocusedRowChanging?.Invoke(null, new JQueryEventArgs(identifier));
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
		public static Task<bool?> GetAutoExpandAllOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxTreeList_GetOption", dxTarget, "autoExpandAll");
		}
		public static Task SetAutoExpandAllOption(ElementRef dxTarget, bool? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeList_SetOption", dxTarget, "autoExpandAll", value);
		}
		public static Task<object> GetCustomizeColumnsOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeList_GetOption", dxTarget, "customizeColumns");
		}
		public static Task SetCustomizeColumnsOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeList_SetOption", dxTarget, "customizeColumns", value);
		}
		public static Task<string> GetDataStructureOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxTreeList_GetOption", dxTarget, "dataStructure");
		}
		public static Task SetDataStructureOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeList_SetOption", dxTarget, "dataStructure", value);
		}
		public static Task<object> GetExpandedRowKeysOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeList_GetOption", dxTarget, "expandedRowKeys");
		}
		public static Task SetExpandedRowKeysOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeList_SetOption", dxTarget, "expandedRowKeys", value);
		}
		public static Task<bool?> GetExpandNodesOnFilteringOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxTreeList_GetOption", dxTarget, "expandNodesOnFiltering");
		}
		public static Task SetExpandNodesOnFilteringOption(ElementRef dxTarget, bool? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeList_SetOption", dxTarget, "expandNodesOnFiltering", value);
		}
		public static Task<object> GetHasItemsExprOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeList_GetOption", dxTarget, "hasItemsExpr");
		}
		public static Task SetHasItemsExprOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeList_SetOption", dxTarget, "hasItemsExpr", value);
		}
		public static Task<object> GetItemsExprOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeList_GetOption", dxTarget, "itemsExpr");
		}
		public static Task SetItemsExprOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeList_SetOption", dxTarget, "itemsExpr", value);
		}
		public static Task<object> GetKeyExprOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeList_GetOption", dxTarget, "keyExpr");
		}
		public static Task SetKeyExprOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeList_SetOption", dxTarget, "keyExpr", value);
		}
		public static Task<object> GetParentIdExprOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeList_GetOption", dxTarget, "parentIdExpr");
		}
		public static Task SetParentIdExprOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeList_SetOption", dxTarget, "parentIdExpr", value);
		}
		public static Task<object> GetRemoteOperationsOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeList_GetOption", dxTarget, "remoteOperations");
		}
		public static Task SetRemoteOperationsOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeList_SetOption", dxTarget, "remoteOperations", value);
		}
		public static Task<object> GetRootValueOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeList_GetOption", dxTarget, "rootValue");
		}
		public static Task SetRootValueOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeList_SetOption", dxTarget, "rootValue", value);
		}
		public static Task AddColumn(ElementRef dxTarget, object columnOptions)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeList_addColumn_0", dxTarget, columnOptions);
		}
		public static Task AddRow(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeList_addRow_1", dxTarget);
		}
		public static Task AddRow(ElementRef dxTarget, object parentId)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeList_addRow_2", dxTarget, parentId);
		}
		public static Task<object> CollapseRow(ElementRef dxTarget, object key)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeList_collapseRow_3", dxTarget, key);
		}
		public static Task<object> ExpandRow(ElementRef dxTarget, object key)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeList_expandRow_4", dxTarget, key);
		}
		public static Task ForEachNode(ElementRef dxTarget, object callback)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeList_forEachNode_5", dxTarget, callback);
		}
		public static Task ForEachNode(ElementRef dxTarget, object nodes, object callback)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeList_forEachNode_6", dxTarget, nodes, callback);
		}
		public static Task<object> GetNodeByKey(ElementRef dxTarget, object key)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeList_getNodeByKey_7", dxTarget, key);
		}
		public static Task<object> GetRootNode(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeList_getRootNode_8", dxTarget);
		}
		public static Task<object> GetSelectedRowKeys(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeList_getSelectedRowKeys_9", dxTarget);
		}
		public static Task<object> GetSelectedRowKeys(ElementRef dxTarget, bool leavesOnly)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeList_getSelectedRowKeys_10", dxTarget, leavesOnly);
		}
		public static Task<object> GetSelectedRowKeys(ElementRef dxTarget, string mode)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeList_getSelectedRowKeys_11", dxTarget, mode);
		}
		public static Task<object> GetSelectedRowsData(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeList_getSelectedRowsData_12", dxTarget);
		}
		public static Task<object> GetSelectedRowsData(ElementRef dxTarget, string mode)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeList_getSelectedRowsData_13", dxTarget, mode);
		}
		public static Task<object> GetVisibleColumns(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeList_getVisibleColumns_14", dxTarget);
		}
		public static Task<object> GetVisibleColumns(ElementRef dxTarget, float headerLevel)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeList_getVisibleColumns_15", dxTarget, headerLevel);
		}
		public static Task<object> GetVisibleRows(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeList_getVisibleRows_16", dxTarget);
		}
		public static Task<bool> IsRowExpanded(ElementRef dxTarget, object key)
		{
			return JSRuntime.Current.InvokeAsync<bool>("BlazorDevExtreme_DxTreeList_isRowExpanded_17", dxTarget, key);
		}
		public static Task<object> LoadDescendants(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeList_loadDescendants_18", dxTarget);
		}
		public static Task<object> LoadDescendants(ElementRef dxTarget, object keys)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeList_loadDescendants_19", dxTarget, keys);
		}
		public static Task<object> LoadDescendants(ElementRef dxTarget, object keys, bool childrenOnly)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeList_loadDescendants_20", dxTarget, keys, childrenOnly);
		}
	}
	public class DxTreeViewInterop: HierarchicalCollectionWidgetInterop
	{
		public static event EventHandler<JQueryEventArgs> ItemCollapsed;
		public static event EventHandler<JQueryEventArgs> ItemExpanded;
		public static event EventHandler<JQueryEventArgs> ItemSelectionChanged;
		public static event EventHandler<JQueryEventArgs> SelectAllValueChanged;
		public static Task Init(ElementRef dxTarget, DevExpress.Ui.DxTreeViewOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeView_Init", dxTarget, json);
		}
		[JSInvokable("DevExpress.Ui.DxTreeViewInterop.OnItemCollapsed")]
		public static void OnItemCollapsed(string identifier)
		{
			ItemCollapsed?.Invoke(null, new JQueryEventArgs(identifier));
		}
		[JSInvokable("DevExpress.Ui.DxTreeViewInterop.OnItemExpanded")]
		public static void OnItemExpanded(string identifier)
		{
			ItemExpanded?.Invoke(null, new JQueryEventArgs(identifier));
		}
		[JSInvokable("DevExpress.Ui.DxTreeViewInterop.OnItemSelectionChanged")]
		public static void OnItemSelectionChanged(string identifier)
		{
			ItemSelectionChanged?.Invoke(null, new JQueryEventArgs(identifier));
		}
		[JSInvokable("DevExpress.Ui.DxTreeViewInterop.OnSelectAllValueChanged")]
		public static void OnSelectAllValueChanged(string identifier)
		{
			SelectAllValueChanged?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static Task<bool?> GetAnimationEnabledOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxTreeView_GetOption", dxTarget, "animationEnabled");
		}
		public static Task SetAnimationEnabledOption(ElementRef dxTarget, bool? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeView_SetOption", dxTarget, "animationEnabled", value);
		}
		public static Task<object> GetCreateChildrenOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeView_GetOption", dxTarget, "createChildren");
		}
		public static Task SetCreateChildrenOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeView_SetOption", dxTarget, "createChildren", value);
		}
		public static Task<string> GetDataStructureOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxTreeView_GetOption", dxTarget, "dataStructure");
		}
		public static Task SetDataStructureOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeView_SetOption", dxTarget, "dataStructure", value);
		}
		public static Task<bool?> GetExpandAllEnabledOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxTreeView_GetOption", dxTarget, "expandAllEnabled");
		}
		public static Task SetExpandAllEnabledOption(ElementRef dxTarget, bool? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeView_SetOption", dxTarget, "expandAllEnabled", value);
		}
		public static Task<object> GetExpandedExprOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeView_GetOption", dxTarget, "expandedExpr");
		}
		public static Task SetExpandedExprOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeView_SetOption", dxTarget, "expandedExpr", value);
		}
		public static Task<string> GetExpandEventOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxTreeView_GetOption", dxTarget, "expandEvent");
		}
		public static Task SetExpandEventOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeView_SetOption", dxTarget, "expandEvent", value);
		}
		public static Task<bool?> GetExpandNodesRecursiveOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxTreeView_GetOption", dxTarget, "expandNodesRecursive");
		}
		public static Task SetExpandNodesRecursiveOption(ElementRef dxTarget, bool? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeView_SetOption", dxTarget, "expandNodesRecursive", value);
		}
		public static Task<object> GetHasItemsExprOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeView_GetOption", dxTarget, "hasItemsExpr");
		}
		public static Task SetHasItemsExprOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeView_SetOption", dxTarget, "hasItemsExpr", value);
		}
		public static Task<object> GetParentIdExprOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeView_GetOption", dxTarget, "parentIdExpr");
		}
		public static Task SetParentIdExprOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeView_SetOption", dxTarget, "parentIdExpr", value);
		}
		public static Task<object> GetRootValueOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeView_GetOption", dxTarget, "rootValue");
		}
		public static Task SetRootValueOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeView_SetOption", dxTarget, "rootValue", value);
		}
		public static Task<string> GetScrollDirectionOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxTreeView_GetOption", dxTarget, "scrollDirection");
		}
		public static Task SetScrollDirectionOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeView_SetOption", dxTarget, "scrollDirection", value);
		}
		public static Task<string> GetSelectAllTextOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxTreeView_GetOption", dxTarget, "selectAllText");
		}
		public static Task SetSelectAllTextOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeView_SetOption", dxTarget, "selectAllText", value);
		}
		public static Task<bool?> GetSelectByClickOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxTreeView_GetOption", dxTarget, "selectByClick");
		}
		public static Task SetSelectByClickOption(ElementRef dxTarget, bool? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeView_SetOption", dxTarget, "selectByClick", value);
		}
		public static Task<string> GetSelectionModeOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxTreeView_GetOption", dxTarget, "selectionMode");
		}
		public static Task SetSelectionModeOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeView_SetOption", dxTarget, "selectionMode", value);
		}
		public static Task<bool?> GetSelectNodesRecursiveOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxTreeView_GetOption", dxTarget, "selectNodesRecursive");
		}
		public static Task SetSelectNodesRecursiveOption(ElementRef dxTarget, bool? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeView_SetOption", dxTarget, "selectNodesRecursive", value);
		}
		public static Task<string> GetShowCheckBoxesModeOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxTreeView_GetOption", dxTarget, "showCheckBoxesMode");
		}
		public static Task SetShowCheckBoxesModeOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeView_SetOption", dxTarget, "showCheckBoxesMode", value);
		}
		public static Task<bool?> GetVirtualModeEnabledOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxTreeView_GetOption", dxTarget, "virtualModeEnabled");
		}
		public static Task SetVirtualModeEnabledOption(ElementRef dxTarget, bool? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeView_SetOption", dxTarget, "virtualModeEnabled", value);
		}
		public static Task<object> GetSearchEditorOptionsOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeView_GetOption", dxTarget, "searchEditorOptions");
		}
		public static Task SetSearchEditorOptionsOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeView_SetOption", dxTarget, "searchEditorOptions", value);
		}
		public static Task<bool?> GetSearchEnabledOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxTreeView_GetOption", dxTarget, "searchEnabled");
		}
		public static Task SetSearchEnabledOption(ElementRef dxTarget, bool? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeView_SetOption", dxTarget, "searchEnabled", value);
		}
		public static Task<object> GetSearchExprOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeView_GetOption", dxTarget, "searchExpr");
		}
		public static Task SetSearchExprOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeView_SetOption", dxTarget, "searchExpr", value);
		}
		public static Task<string> GetSearchModeOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxTreeView_GetOption", dxTarget, "searchMode");
		}
		public static Task SetSearchModeOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeView_SetOption", dxTarget, "searchMode", value);
		}
		public static Task<float?> GetSearchTimeoutOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_DxTreeView_GetOption", dxTarget, "searchTimeout");
		}
		public static Task SetSearchTimeoutOption(ElementRef dxTarget, float? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeView_SetOption", dxTarget, "searchTimeout", value);
		}
		public static Task<string> GetSearchValueOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxTreeView_GetOption", dxTarget, "searchValue");
		}
		public static Task SetSearchValueOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeView_SetOption", dxTarget, "searchValue", value);
		}
		public static Task CollapseAll(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeView_collapseAll_0", dxTarget);
		}
		public static Task CollapseItem(ElementRef dxTarget, object itemData)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeView_collapseItem_1", dxTarget, itemData);
		}
		public static Task ExpandAll(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeView_expandAll_4", dxTarget);
		}
		public static Task ExpandItem(ElementRef dxTarget, object itemData)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeView_expandItem_5", dxTarget, itemData);
		}
		public static Task<object> GetNodes(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeView_getNodes_8", dxTarget);
		}
		public static Task SelectAll(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeView_selectAll_9", dxTarget);
		}
		public static Task SelectItem(ElementRef dxTarget, object itemData)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeView_selectItem_10", dxTarget, itemData);
		}
		public static Task UnselectAll(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeView_unselectAll_13", dxTarget);
		}
		public static Task UnselectItem(ElementRef dxTarget, object itemData)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeView_unselectItem_14", dxTarget, itemData);
		}
		public static Task<object> UpdateDimensions(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeView_updateDimensions_17", dxTarget);
		}
	}
	public class DxValidationGroupInterop: DOMComponentInterop
	{
		public static Task Init(ElementRef dxTarget, DevExpress.Ui.DxValidationGroupOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxValidationGroup_Init", dxTarget, json);
		}
		public static Task Reset(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxValidationGroup_reset_0", dxTarget);
		}
		public static Task<object> Validate(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxValidationGroup_validate_1", dxTarget);
		}
	}
	public class DxValidationSummaryInterop: CollectionWidgetInterop
	{
		public static Task Init(ElementRef dxTarget, DevExpress.Ui.DxValidationSummaryOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxValidationSummary_Init", dxTarget, json);
		}
		public static Task<string> GetValidationGroupOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxValidationSummary_GetOption", dxTarget, "validationGroup");
		}
		public static Task SetValidationGroupOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxValidationSummary_SetOption", dxTarget, "validationGroup", value);
		}
	}
	public class DxValidatorInterop: DOMComponentInterop
	{
		public static event EventHandler<JQueryEventArgs> Validated;
		public static Task Init(ElementRef dxTarget, DevExpress.Ui.DxValidatorOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxValidator_Init", dxTarget, json);
		}
		[JSInvokable("DevExpress.Ui.DxValidatorInterop.OnValidated")]
		public static void OnValidated(string identifier)
		{
			Validated?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static Task<object> GetAdapterOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxValidator_GetOption", dxTarget, "adapter");
		}
		public static Task SetAdapterOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxValidator_SetOption", dxTarget, "adapter", value);
		}
		public static Task<string> GetNameOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxValidator_GetOption", dxTarget, "name");
		}
		public static Task SetNameOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxValidator_SetOption", dxTarget, "name", value);
		}
		public static Task<string> GetValidationGroupOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxValidator_GetOption", dxTarget, "validationGroup");
		}
		public static Task SetValidationGroupOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxValidator_SetOption", dxTarget, "validationGroup", value);
		}
		public static Task<object> GetValidationRulesOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxValidator_GetOption", dxTarget, "validationRules");
		}
		public static Task SetValidationRulesOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxValidator_SetOption", dxTarget, "validationRules", value);
		}
		public static Task Focus(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxValidator_focus_0", dxTarget);
		}
		public static Task Reset(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxValidator_reset_1", dxTarget);
		}
		public static Task<object> Validate(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxValidator_validate_2", dxTarget);
		}
	}
	public class CollectionWidgetInterop: WidgetInterop
	{
		public static event EventHandler<JQueryEventArgs> ItemClick;
		public static event EventHandler<JQueryEventArgs> ItemContextMenu;
		public static event EventHandler<JQueryEventArgs> ItemHold;
		public static event EventHandler<JQueryEventArgs> ItemRendered;
		public static event EventHandler<JQueryEventArgs> SelectionChanged;
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
		public static Task<object> GetDataSourceOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_CollectionWidget_GetOption", dxTarget, "dataSource");
		}
		public static Task SetDataSourceOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_CollectionWidget_SetOption", dxTarget, "dataSource", value);
		}
		public static Task<float?> GetItemHoldTimeoutOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_CollectionWidget_GetOption", dxTarget, "itemHoldTimeout");
		}
		public static Task SetItemHoldTimeoutOption(ElementRef dxTarget, float? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_CollectionWidget_SetOption", dxTarget, "itemHoldTimeout", value);
		}
		public static Task<object> GetItemsOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_CollectionWidget_GetOption", dxTarget, "items");
		}
		public static Task SetItemsOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_CollectionWidget_SetOption", dxTarget, "items", value);
		}
		public static Task<object> GetItemTemplateOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_CollectionWidget_GetOption", dxTarget, "itemTemplate");
		}
		public static Task SetItemTemplateOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_CollectionWidget_SetOption", dxTarget, "itemTemplate", value);
		}
		public static Task<object> GetKeyExprOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_CollectionWidget_GetOption", dxTarget, "keyExpr");
		}
		public static Task SetKeyExprOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_CollectionWidget_SetOption", dxTarget, "keyExpr", value);
		}
		public static Task<string> GetNoDataTextOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_CollectionWidget_GetOption", dxTarget, "noDataText");
		}
		public static Task SetNoDataTextOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_CollectionWidget_SetOption", dxTarget, "noDataText", value);
		}
		public static Task<float?> GetSelectedIndexOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_CollectionWidget_GetOption", dxTarget, "selectedIndex");
		}
		public static Task SetSelectedIndexOption(ElementRef dxTarget, float? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_CollectionWidget_SetOption", dxTarget, "selectedIndex", value);
		}
		public static Task<object> GetSelectedItemOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_CollectionWidget_GetOption", dxTarget, "selectedItem");
		}
		public static Task SetSelectedItemOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_CollectionWidget_SetOption", dxTarget, "selectedItem", value);
		}
		public static Task<object> GetSelectedItemKeysOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_CollectionWidget_GetOption", dxTarget, "selectedItemKeys");
		}
		public static Task SetSelectedItemKeysOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_CollectionWidget_SetOption", dxTarget, "selectedItemKeys", value);
		}
		public static Task<object> GetSelectedItemsOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_CollectionWidget_GetOption", dxTarget, "selectedItems");
		}
		public static Task SetSelectedItemsOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_CollectionWidget_SetOption", dxTarget, "selectedItems", value);
		}
		public static Task<object> GetDataSourceEx(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_CollectionWidget_getDataSource_0", dxTarget);
		}
	}
	public class DxMenuBaseInterop: HierarchicalCollectionWidgetInterop
	{
		public static Task<object> GetAnimationOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxMenuBase_GetOption", dxTarget, "animation");
		}
		public static Task SetAnimationOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxMenuBase_SetOption", dxTarget, "animation", value);
		}
		public static Task<string> GetCssClassOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxMenuBase_GetOption", dxTarget, "cssClass");
		}
		public static Task SetCssClassOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxMenuBase_SetOption", dxTarget, "cssClass", value);
		}
		public static Task<bool?> GetSelectByClickOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxMenuBase_GetOption", dxTarget, "selectByClick");
		}
		public static Task SetSelectByClickOption(ElementRef dxTarget, bool? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxMenuBase_SetOption", dxTarget, "selectByClick", value);
		}
		public static Task<string> GetSelectionModeOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxMenuBase_GetOption", dxTarget, "selectionMode");
		}
		public static Task SetSelectionModeOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxMenuBase_SetOption", dxTarget, "selectionMode", value);
		}
		public static Task<object> GetShowSubmenuModeOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxMenuBase_GetOption", dxTarget, "showSubmenuMode");
		}
		public static Task SetShowSubmenuModeOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxMenuBase_SetOption", dxTarget, "showSubmenuMode", value);
		}
		public static Task SelectItem(ElementRef dxTarget, object itemElement)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxMenuBase_selectItem_0", dxTarget, itemElement);
		}
		public static Task UnselectItem(ElementRef dxTarget, object itemElement)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxMenuBase_unselectItem_1", dxTarget, itemElement);
		}
	}
	public class DxDropDownEditorInterop: DxTextBoxInterop
	{
		public static event EventHandler<JQueryEventArgs> Closed;
		public static event EventHandler<JQueryEventArgs> Opened;
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
		public static Task<bool?> GetAcceptCustomValueOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxDropDownEditor_GetOption", dxTarget, "acceptCustomValue");
		}
		public static Task SetAcceptCustomValueOption(ElementRef dxTarget, bool? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDropDownEditor_SetOption", dxTarget, "acceptCustomValue", value);
		}
		public static Task<string> GetApplyValueModeOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxDropDownEditor_GetOption", dxTarget, "applyValueMode");
		}
		public static Task SetApplyValueModeOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDropDownEditor_SetOption", dxTarget, "applyValueMode", value);
		}
		public static Task<bool?> GetDeferRenderingOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxDropDownEditor_GetOption", dxTarget, "deferRendering");
		}
		public static Task SetDeferRenderingOption(ElementRef dxTarget, bool? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDropDownEditor_SetOption", dxTarget, "deferRendering", value);
		}
		public static Task<object> GetDropDownButtonTemplateOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDropDownEditor_GetOption", dxTarget, "dropDownButtonTemplate");
		}
		public static Task SetDropDownButtonTemplateOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDropDownEditor_SetOption", dxTarget, "dropDownButtonTemplate", value);
		}
		public static Task<bool?> GetOpenedOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxDropDownEditor_GetOption", dxTarget, "opened");
		}
		public static Task SetOpenedOption(ElementRef dxTarget, bool? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDropDownEditor_SetOption", dxTarget, "opened", value);
		}
		public static Task<bool?> GetOpenOnFieldClickOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxDropDownEditor_GetOption", dxTarget, "openOnFieldClick");
		}
		public static Task SetOpenOnFieldClickOption(ElementRef dxTarget, bool? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDropDownEditor_SetOption", dxTarget, "openOnFieldClick", value);
		}
		public static Task<bool?> GetShowDropDownButtonOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxDropDownEditor_GetOption", dxTarget, "showDropDownButton");
		}
		public static Task SetShowDropDownButtonOption(ElementRef dxTarget, bool? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDropDownEditor_SetOption", dxTarget, "showDropDownButton", value);
		}
		public static Task Close(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDropDownEditor_close_0", dxTarget);
		}
		public static Task<object> Content(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDropDownEditor_content_1", dxTarget);
		}
		public static Task<object> Field(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDropDownEditor_field_2", dxTarget);
		}
		public static Task Open(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDropDownEditor_open_3", dxTarget);
		}
		public static Task Reset(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDropDownEditor_reset_4", dxTarget);
		}
	}
	public class DxDropDownListInterop: DxDropDownEditorInterop
	{
		public static event EventHandler<JQueryEventArgs> ItemClick;
		public static event EventHandler<JQueryEventArgs> SelectionChanged;
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
		public static Task<string> GetDisplayValueOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxDropDownList_GetOption", dxTarget, "displayValue");
		}
		public static Task SetDisplayValueOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDropDownList_SetOption", dxTarget, "displayValue", value);
		}
		public static Task<bool?> GetGroupedOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxDropDownList_GetOption", dxTarget, "grouped");
		}
		public static Task SetGroupedOption(ElementRef dxTarget, bool? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDropDownList_SetOption", dxTarget, "grouped", value);
		}
		public static Task<object> GetGroupTemplateOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDropDownList_GetOption", dxTarget, "groupTemplate");
		}
		public static Task SetGroupTemplateOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDropDownList_SetOption", dxTarget, "groupTemplate", value);
		}
		public static Task<float?> GetMinSearchLengthOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_DxDropDownList_GetOption", dxTarget, "minSearchLength");
		}
		public static Task SetMinSearchLengthOption(ElementRef dxTarget, float? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDropDownList_SetOption", dxTarget, "minSearchLength", value);
		}
		public static Task<string> GetNoDataTextOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxDropDownList_GetOption", dxTarget, "noDataText");
		}
		public static Task SetNoDataTextOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDropDownList_SetOption", dxTarget, "noDataText", value);
		}
		public static Task<bool?> GetSearchEnabledOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxDropDownList_GetOption", dxTarget, "searchEnabled");
		}
		public static Task SetSearchEnabledOption(ElementRef dxTarget, bool? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDropDownList_SetOption", dxTarget, "searchEnabled", value);
		}
		public static Task<object> GetSearchExprOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDropDownList_GetOption", dxTarget, "searchExpr");
		}
		public static Task SetSearchExprOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDropDownList_SetOption", dxTarget, "searchExpr", value);
		}
		public static Task<string> GetSearchModeOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxDropDownList_GetOption", dxTarget, "searchMode");
		}
		public static Task SetSearchModeOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDropDownList_SetOption", dxTarget, "searchMode", value);
		}
		public static Task<float?> GetSearchTimeoutOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_DxDropDownList_GetOption", dxTarget, "searchTimeout");
		}
		public static Task SetSearchTimeoutOption(ElementRef dxTarget, float? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDropDownList_SetOption", dxTarget, "searchTimeout", value);
		}
		public static Task<object> GetSelectedItemOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDropDownList_GetOption", dxTarget, "selectedItem");
		}
		public static Task SetSelectedItemOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDropDownList_SetOption", dxTarget, "selectedItem", value);
		}
		public static Task<bool?> GetShowDataBeforeSearchOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxDropDownList_GetOption", dxTarget, "showDataBeforeSearch");
		}
		public static Task SetShowDataBeforeSearchOption(ElementRef dxTarget, bool? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDropDownList_SetOption", dxTarget, "showDataBeforeSearch", value);
		}
		public static Task<object> GetDataSourceOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDropDownList_GetOption", dxTarget, "dataSource");
		}
		public static Task SetDataSourceOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDropDownList_SetOption", dxTarget, "dataSource", value);
		}
		public static Task<object> GetDisplayExprOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDropDownList_GetOption", dxTarget, "displayExpr");
		}
		public static Task SetDisplayExprOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDropDownList_SetOption", dxTarget, "displayExpr", value);
		}
		public static Task<object> GetItemsOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDropDownList_GetOption", dxTarget, "items");
		}
		public static Task SetItemsOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDropDownList_SetOption", dxTarget, "items", value);
		}
		public static Task<object> GetItemTemplateOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDropDownList_GetOption", dxTarget, "itemTemplate");
		}
		public static Task SetItemTemplateOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDropDownList_SetOption", dxTarget, "itemTemplate", value);
		}
		public static Task<object> GetValueExprOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDropDownList_GetOption", dxTarget, "valueExpr");
		}
		public static Task SetValueExprOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDropDownList_SetOption", dxTarget, "valueExpr", value);
		}
		public static Task<object> GetDataSourceEx(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDropDownList_getDataSource_0", dxTarget);
		}
	}
	public class EditorInterop: WidgetInterop
	{
		public static event EventHandler<JQueryEventArgs> ValueChanged;
		[JSInvokable("DevExpress.Ui.EditorInterop.OnValueChanged")]
		public static void OnValueChanged(string identifier)
		{
			ValueChanged?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static Task<bool?> GetIsValidOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_Editor_GetOption", dxTarget, "isValid");
		}
		public static Task SetIsValidOption(ElementRef dxTarget, bool? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Editor_SetOption", dxTarget, "isValid", value);
		}
		public static Task<bool?> GetReadOnlyOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_Editor_GetOption", dxTarget, "readOnly");
		}
		public static Task SetReadOnlyOption(ElementRef dxTarget, bool? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Editor_SetOption", dxTarget, "readOnly", value);
		}
		public static Task<object> GetValidationErrorOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Editor_GetOption", dxTarget, "validationError");
		}
		public static Task SetValidationErrorOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Editor_SetOption", dxTarget, "validationError", value);
		}
		public static Task<string> GetValidationMessageModeOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_Editor_GetOption", dxTarget, "validationMessageMode");
		}
		public static Task SetValidationMessageModeOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Editor_SetOption", dxTarget, "validationMessageMode", value);
		}
		public static Task<object> GetValueOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Editor_GetOption", dxTarget, "value");
		}
		public static Task SetValueOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Editor_SetOption", dxTarget, "value", value);
		}
		public static Task Reset(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Editor_reset_0", dxTarget);
		}
	}
	public class DataExpressionMixinInterop
	{
		public static Task<object> GetDataSourceOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DataExpressionMixin_GetOption", dxTarget, "dataSource");
		}
		public static Task SetDataSourceOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DataExpressionMixin_SetOption", dxTarget, "dataSource", value);
		}
		public static Task<object> GetDisplayExprOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DataExpressionMixin_GetOption", dxTarget, "displayExpr");
		}
		public static Task SetDisplayExprOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DataExpressionMixin_SetOption", dxTarget, "displayExpr", value);
		}
		public static Task<object> GetItemsOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DataExpressionMixin_GetOption", dxTarget, "items");
		}
		public static Task SetItemsOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DataExpressionMixin_SetOption", dxTarget, "items", value);
		}
		public static Task<object> GetItemTemplateOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DataExpressionMixin_GetOption", dxTarget, "itemTemplate");
		}
		public static Task SetItemTemplateOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DataExpressionMixin_SetOption", dxTarget, "itemTemplate", value);
		}
		public static Task<object> GetValueOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DataExpressionMixin_GetOption", dxTarget, "value");
		}
		public static Task SetValueOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DataExpressionMixin_SetOption", dxTarget, "value", value);
		}
		public static Task<object> GetValueExprOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DataExpressionMixin_GetOption", dxTarget, "valueExpr");
		}
		public static Task SetValueExprOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DataExpressionMixin_SetOption", dxTarget, "valueExpr", value);
		}
		public static Task<object> GetDataSourceEx(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DataExpressionMixin_getDataSource_0", dxTarget);
		}
	}
	public class HierarchicalCollectionWidgetInterop: CollectionWidgetInterop
	{
		public static Task<object> GetDisabledExprOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_HierarchicalCollectionWidget_GetOption", dxTarget, "disabledExpr");
		}
		public static Task SetDisabledExprOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_HierarchicalCollectionWidget_SetOption", dxTarget, "disabledExpr", value);
		}
		public static Task<object> GetDisplayExprOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_HierarchicalCollectionWidget_GetOption", dxTarget, "displayExpr");
		}
		public static Task SetDisplayExprOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_HierarchicalCollectionWidget_SetOption", dxTarget, "displayExpr", value);
		}
		public static Task<object> GetItemsExprOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_HierarchicalCollectionWidget_GetOption", dxTarget, "itemsExpr");
		}
		public static Task SetItemsExprOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_HierarchicalCollectionWidget_SetOption", dxTarget, "itemsExpr", value);
		}
		public static Task<object> GetSelectedExprOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_HierarchicalCollectionWidget_GetOption", dxTarget, "selectedExpr");
		}
		public static Task SetSelectedExprOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_HierarchicalCollectionWidget_SetOption", dxTarget, "selectedExpr", value);
		}
	}
	public class DxPivotGridSummaryCellInterop
	{
		public static Task<object> Child(ElementRef dxTarget, string direction, object fieldValue)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPivotGridSummaryCell_child_0", dxTarget, direction, fieldValue);
		}
		public static Task<object> Children(ElementRef dxTarget, string direction)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPivotGridSummaryCell_children_1", dxTarget, direction);
		}
		public static Task<object> Field(ElementRef dxTarget, string area)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPivotGridSummaryCell_field_2", dxTarget, area);
		}
		public static Task<object> GrandTotal(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPivotGridSummaryCell_grandTotal_3", dxTarget);
		}
		public static Task<object> GrandTotal(ElementRef dxTarget, string direction)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPivotGridSummaryCell_grandTotal_4", dxTarget, direction);
		}
		public static Task<object> Next(ElementRef dxTarget, string direction)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPivotGridSummaryCell_next_5", dxTarget, direction);
		}
		public static Task<object> Next(ElementRef dxTarget, string direction, bool allowCrossGroup)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPivotGridSummaryCell_next_6", dxTarget, direction, allowCrossGroup);
		}
		public static Task<object> Parent(ElementRef dxTarget, string direction)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPivotGridSummaryCell_parent_7", dxTarget, direction);
		}
		public static Task<object> Prev(ElementRef dxTarget, string direction)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPivotGridSummaryCell_prev_8", dxTarget, direction);
		}
		public static Task<object> Prev(ElementRef dxTarget, string direction, bool allowCrossGroup)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPivotGridSummaryCell_prev_9", dxTarget, direction, allowCrossGroup);
		}
		public static Task<object> Slice(ElementRef dxTarget, object field, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPivotGridSummaryCell_slice_10", dxTarget, field, value);
		}
		public static Task<object> ValueEx(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPivotGridSummaryCell_value_11", dxTarget);
		}
		public static Task<object> ValueEx(ElementRef dxTarget, object field)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPivotGridSummaryCell_value_12", dxTarget, field);
		}
		public static Task<object> ValueEx(ElementRef dxTarget, object field, bool isCalculatedValue)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPivotGridSummaryCell_value_13", dxTarget, field, isCalculatedValue);
		}
		public static Task<object> ValueEx(ElementRef dxTarget, bool isCalculatedValue)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPivotGridSummaryCell_value_14", dxTarget, isCalculatedValue);
		}
	}
	public class DxScrollableInterop: DOMComponentInterop
	{
		public static event EventHandler<JQueryEventArgs> Scroll;
		public static event EventHandler<JQueryEventArgs> Updated;
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
		public static Task<bool?> GetBounceEnabledOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxScrollable_GetOption", dxTarget, "bounceEnabled");
		}
		public static Task SetBounceEnabledOption(ElementRef dxTarget, bool? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScrollable_SetOption", dxTarget, "bounceEnabled", value);
		}
		public static Task<string> GetDirectionOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxScrollable_GetOption", dxTarget, "direction");
		}
		public static Task SetDirectionOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScrollable_SetOption", dxTarget, "direction", value);
		}
		public static Task<bool?> GetDisabledOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxScrollable_GetOption", dxTarget, "disabled");
		}
		public static Task SetDisabledOption(ElementRef dxTarget, bool? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScrollable_SetOption", dxTarget, "disabled", value);
		}
		public static Task<bool?> GetScrollByContentOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxScrollable_GetOption", dxTarget, "scrollByContent");
		}
		public static Task SetScrollByContentOption(ElementRef dxTarget, bool? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScrollable_SetOption", dxTarget, "scrollByContent", value);
		}
		public static Task<bool?> GetScrollByThumbOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxScrollable_GetOption", dxTarget, "scrollByThumb");
		}
		public static Task SetScrollByThumbOption(ElementRef dxTarget, bool? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScrollable_SetOption", dxTarget, "scrollByThumb", value);
		}
		public static Task<string> GetShowScrollbarOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxScrollable_GetOption", dxTarget, "showScrollbar");
		}
		public static Task SetShowScrollbarOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScrollable_SetOption", dxTarget, "showScrollbar", value);
		}
		public static Task<bool?> GetUseNativeOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxScrollable_GetOption", dxTarget, "useNative");
		}
		public static Task SetUseNativeOption(ElementRef dxTarget, bool? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScrollable_SetOption", dxTarget, "useNative", value);
		}
		public static Task<float> ClientHeight(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<float>("BlazorDevExtreme_DxScrollable_clientHeight_0", dxTarget);
		}
		public static Task<float> ClientWidth(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<float>("BlazorDevExtreme_DxScrollable_clientWidth_1", dxTarget);
		}
		public static Task<object> Content(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScrollable_content_2", dxTarget);
		}
		public static Task ScrollBy(ElementRef dxTarget, float distance)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScrollable_scrollBy_3", dxTarget, distance);
		}
		public static Task ScrollBy(ElementRef dxTarget, object distanceObject)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScrollable_scrollBy_4", dxTarget, distanceObject);
		}
		public static Task<float> ScrollHeight(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<float>("BlazorDevExtreme_DxScrollable_scrollHeight_5", dxTarget);
		}
		public static Task<float> ScrollLeft(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<float>("BlazorDevExtreme_DxScrollable_scrollLeft_6", dxTarget);
		}
		public static Task<object> ScrollOffset(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScrollable_scrollOffset_7", dxTarget);
		}
		public static Task ScrollTo(ElementRef dxTarget, float targetLocation)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScrollable_scrollTo_8", dxTarget, targetLocation);
		}
		public static Task ScrollTo(ElementRef dxTarget, object targetLocation)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScrollable_scrollTo_9", dxTarget, targetLocation);
		}
		public static Task ScrollToElement(ElementRef dxTarget, object element)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScrollable_scrollToElement_10", dxTarget, element);
		}
		public static Task<float> ScrollTop(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<float>("BlazorDevExtreme_DxScrollable_scrollTop_11", dxTarget);
		}
		public static Task<float> ScrollWidth(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<float>("BlazorDevExtreme_DxScrollable_scrollWidth_12", dxTarget);
		}
		public static Task<object> Update(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScrollable_update_13", dxTarget);
		}
	}
	public class DxSliderBaseInterop: DxTrackBarInterop
	{
		public static Task<float?> GetKeyStepOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_DxSliderBase_GetOption", dxTarget, "keyStep");
		}
		public static Task SetKeyStepOption(ElementRef dxTarget, float? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxSliderBase_SetOption", dxTarget, "keyStep", value);
		}
		public static Task<object> GetLabelOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxSliderBase_GetOption", dxTarget, "label");
		}
		public static Task SetLabelOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxSliderBase_SetOption", dxTarget, "label", value);
		}
		public static Task<string> GetNameOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxSliderBase_GetOption", dxTarget, "name");
		}
		public static Task SetNameOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxSliderBase_SetOption", dxTarget, "name", value);
		}
		public static Task<bool?> GetShowRangeOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxSliderBase_GetOption", dxTarget, "showRange");
		}
		public static Task SetShowRangeOption(ElementRef dxTarget, bool? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxSliderBase_SetOption", dxTarget, "showRange", value);
		}
		public static Task<float?> GetStepOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_DxSliderBase_GetOption", dxTarget, "step");
		}
		public static Task SetStepOption(ElementRef dxTarget, float? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxSliderBase_SetOption", dxTarget, "step", value);
		}
		public static Task<object> GetTooltipOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxSliderBase_GetOption", dxTarget, "tooltip");
		}
		public static Task SetTooltipOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxSliderBase_SetOption", dxTarget, "tooltip", value);
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
		public static Task<object> GetInputAttrOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTextEditor_GetOption", dxTarget, "inputAttr");
		}
		public static Task SetInputAttrOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTextEditor_SetOption", dxTarget, "inputAttr", value);
		}
		public static Task<string> GetMaskOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxTextEditor_GetOption", dxTarget, "mask");
		}
		public static Task SetMaskOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTextEditor_SetOption", dxTarget, "mask", value);
		}
		public static Task<string> GetMaskCharOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxTextEditor_GetOption", dxTarget, "maskChar");
		}
		public static Task SetMaskCharOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTextEditor_SetOption", dxTarget, "maskChar", value);
		}
		public static Task<string> GetMaskInvalidMessageOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxTextEditor_GetOption", dxTarget, "maskInvalidMessage");
		}
		public static Task SetMaskInvalidMessageOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTextEditor_SetOption", dxTarget, "maskInvalidMessage", value);
		}
		public static Task<object> GetMaskRulesOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTextEditor_GetOption", dxTarget, "maskRules");
		}
		public static Task SetMaskRulesOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTextEditor_SetOption", dxTarget, "maskRules", value);
		}
		public static Task<string> GetNameOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxTextEditor_GetOption", dxTarget, "name");
		}
		public static Task SetNameOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTextEditor_SetOption", dxTarget, "name", value);
		}
		public static Task<string> GetPlaceholderOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxTextEditor_GetOption", dxTarget, "placeholder");
		}
		public static Task SetPlaceholderOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTextEditor_SetOption", dxTarget, "placeholder", value);
		}
		public static Task<bool?> GetShowClearButtonOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxTextEditor_GetOption", dxTarget, "showClearButton");
		}
		public static Task SetShowClearButtonOption(ElementRef dxTarget, bool? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTextEditor_SetOption", dxTarget, "showClearButton", value);
		}
		public static Task<string> GetShowMaskModeOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxTextEditor_GetOption", dxTarget, "showMaskMode");
		}
		public static Task SetShowMaskModeOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTextEditor_SetOption", dxTarget, "showMaskMode", value);
		}
		public static Task<bool?> GetSpellcheckOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxTextEditor_GetOption", dxTarget, "spellcheck");
		}
		public static Task SetSpellcheckOption(ElementRef dxTarget, bool? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTextEditor_SetOption", dxTarget, "spellcheck", value);
		}
		public static Task<string> GetStylingModeOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxTextEditor_GetOption", dxTarget, "stylingMode");
		}
		public static Task SetStylingModeOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTextEditor_SetOption", dxTarget, "stylingMode", value);
		}
		public static Task<string> GetTextOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxTextEditor_GetOption", dxTarget, "text");
		}
		public static Task SetTextOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTextEditor_SetOption", dxTarget, "text", value);
		}
		public static Task<bool?> GetUseMaskedValueOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxTextEditor_GetOption", dxTarget, "useMaskedValue");
		}
		public static Task SetUseMaskedValueOption(ElementRef dxTarget, bool? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTextEditor_SetOption", dxTarget, "useMaskedValue", value);
		}
		public static Task<string> GetValueChangeEventOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxTextEditor_GetOption", dxTarget, "valueChangeEvent");
		}
		public static Task SetValueChangeEventOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTextEditor_SetOption", dxTarget, "valueChangeEvent", value);
		}
		public static Task Blur(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTextEditor_blur_0", dxTarget);
		}
		public static Task Focus(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTextEditor_focus_1", dxTarget);
		}
	}
	public class SearchBoxMixinInterop
	{
		public static Task<object> GetSearchEditorOptionsOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_SearchBoxMixin_GetOption", dxTarget, "searchEditorOptions");
		}
		public static Task SetSearchEditorOptionsOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_SearchBoxMixin_SetOption", dxTarget, "searchEditorOptions", value);
		}
		public static Task<bool?> GetSearchEnabledOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_SearchBoxMixin_GetOption", dxTarget, "searchEnabled");
		}
		public static Task SetSearchEnabledOption(ElementRef dxTarget, bool? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_SearchBoxMixin_SetOption", dxTarget, "searchEnabled", value);
		}
		public static Task<object> GetSearchExprOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_SearchBoxMixin_GetOption", dxTarget, "searchExpr");
		}
		public static Task SetSearchExprOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_SearchBoxMixin_SetOption", dxTarget, "searchExpr", value);
		}
		public static Task<string> GetSearchModeOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_SearchBoxMixin_GetOption", dxTarget, "searchMode");
		}
		public static Task SetSearchModeOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_SearchBoxMixin_SetOption", dxTarget, "searchMode", value);
		}
		public static Task<float?> GetSearchTimeoutOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_SearchBoxMixin_GetOption", dxTarget, "searchTimeout");
		}
		public static Task SetSearchTimeoutOption(ElementRef dxTarget, float? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_SearchBoxMixin_SetOption", dxTarget, "searchTimeout", value);
		}
		public static Task<string> GetSearchValueOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_SearchBoxMixin_GetOption", dxTarget, "searchValue");
		}
		public static Task SetSearchValueOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_SearchBoxMixin_SetOption", dxTarget, "searchValue", value);
		}
	}
	public class DxTemplateInterop
	{
		public static Task Init(ElementRef dxTarget, DevExpress.Ui.DxTemplateOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTemplate_Init", dxTarget, json);
		}
		public static Task<string> GetNameOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxTemplate_GetOption", dxTarget, "name");
		}
		public static Task SetNameOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTemplate_SetOption", dxTarget, "name", value);
		}
	}
	public class WidgetInterop: DOMComponentInterop
	{
		public static event EventHandler<JQueryEventArgs> ContentReady;
		[JSInvokable("DevExpress.Ui.WidgetInterop.OnContentReady")]
		public static void OnContentReady(string identifier)
		{
			ContentReady?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static Task<string> GetAccessKeyOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_Widget_GetOption", dxTarget, "accessKey");
		}
		public static Task SetAccessKeyOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Widget_SetOption", dxTarget, "accessKey", value);
		}
		public static Task<bool?> GetActiveStateEnabledOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_Widget_GetOption", dxTarget, "activeStateEnabled");
		}
		public static Task SetActiveStateEnabledOption(ElementRef dxTarget, bool? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Widget_SetOption", dxTarget, "activeStateEnabled", value);
		}
		public static Task<bool?> GetDisabledOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_Widget_GetOption", dxTarget, "disabled");
		}
		public static Task SetDisabledOption(ElementRef dxTarget, bool? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Widget_SetOption", dxTarget, "disabled", value);
		}
		public static Task<bool?> GetFocusStateEnabledOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_Widget_GetOption", dxTarget, "focusStateEnabled");
		}
		public static Task SetFocusStateEnabledOption(ElementRef dxTarget, bool? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Widget_SetOption", dxTarget, "focusStateEnabled", value);
		}
		public static Task<string> GetHintOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_Widget_GetOption", dxTarget, "hint");
		}
		public static Task SetHintOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Widget_SetOption", dxTarget, "hint", value);
		}
		public static Task<bool?> GetHoverStateEnabledOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_Widget_GetOption", dxTarget, "hoverStateEnabled");
		}
		public static Task SetHoverStateEnabledOption(ElementRef dxTarget, bool? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Widget_SetOption", dxTarget, "hoverStateEnabled", value);
		}
		public static Task<float?> GetTabIndexOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_Widget_GetOption", dxTarget, "tabIndex");
		}
		public static Task SetTabIndexOption(ElementRef dxTarget, float? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Widget_SetOption", dxTarget, "tabIndex", value);
		}
		public static Task<bool?> GetVisibleOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_Widget_GetOption", dxTarget, "visible");
		}
		public static Task SetVisibleOption(ElementRef dxTarget, bool? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Widget_SetOption", dxTarget, "visible", value);
		}
		public static Task Focus(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Widget_focus_0", dxTarget);
		}
		public static Task RegisterKeyHandler(ElementRef dxTarget, string key, object handler)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Widget_registerKeyHandler_1", dxTarget, key, handler);
		}
		public static Task Repaint(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Widget_repaint_2", dxTarget);
		}
	}
	public class DialogInterop
	{
		public static Task<object> Alert(string message, string title)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Dialog_alert_0", message, title);
		}
		public static Task<object> Confirm(string message, string title)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Dialog_confirm_1", message, title);
		}
		public static Task<object> Custom(object options)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Dialog_custom_2", options);
		}
	}
	public class ThemesInterop
	{
		public static Task<string> Current()
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_Themes_current_0");
		}
		public static Task Current(string themeName)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Themes_current_1", themeName);
		}
		public static Task Ready(object callback)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Themes_ready_2", callback);
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
		public static Task<bool?> GetDisabledOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_BaseWidget_GetOption", dxTarget, "disabled");
		}
		public static Task SetDisabledOption(ElementRef dxTarget, bool? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BaseWidget_SetOption", dxTarget, "disabled", value);
		}
		public static Task<object> GetExportOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BaseWidget_GetOption", dxTarget, "export");
		}
		public static Task SetExportOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BaseWidget_SetOption", dxTarget, "export", value);
		}
		public static Task<object> GetLoadingIndicatorOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BaseWidget_GetOption", dxTarget, "loadingIndicator");
		}
		public static Task SetLoadingIndicatorOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BaseWidget_SetOption", dxTarget, "loadingIndicator", value);
		}
		public static Task<object> GetMarginOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BaseWidget_GetOption", dxTarget, "margin");
		}
		public static Task SetMarginOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BaseWidget_SetOption", dxTarget, "margin", value);
		}
		public static Task<bool?> GetPathModifiedOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_BaseWidget_GetOption", dxTarget, "pathModified");
		}
		public static Task SetPathModifiedOption(ElementRef dxTarget, bool? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BaseWidget_SetOption", dxTarget, "pathModified", value);
		}
		public static Task<bool?> GetRedrawOnResizeOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_BaseWidget_GetOption", dxTarget, "redrawOnResize");
		}
		public static Task SetRedrawOnResizeOption(ElementRef dxTarget, bool? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BaseWidget_SetOption", dxTarget, "redrawOnResize", value);
		}
		public static Task<object> GetSizeOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BaseWidget_GetOption", dxTarget, "size");
		}
		public static Task SetSizeOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BaseWidget_SetOption", dxTarget, "size", value);
		}
		public static Task<string> GetThemeOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_BaseWidget_GetOption", dxTarget, "theme");
		}
		public static Task SetThemeOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BaseWidget_SetOption", dxTarget, "theme", value);
		}
		public static Task<object> GetTitleOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BaseWidget_GetOption", dxTarget, "title");
		}
		public static Task SetTitleOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BaseWidget_SetOption", dxTarget, "title", value);
		}
		public static Task<object> GetTooltipOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BaseWidget_GetOption", dxTarget, "tooltip");
		}
		public static Task SetTooltipOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BaseWidget_SetOption", dxTarget, "tooltip", value);
		}
		public static Task ExportTo(ElementRef dxTarget, string fileName, string format)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BaseWidget_exportTo_0", dxTarget, fileName, format);
		}
		public static Task<object> GetSizeEx(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BaseWidget_getSize_1", dxTarget);
		}
		public static Task HideLoadingIndicator(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BaseWidget_hideLoadingIndicator_2", dxTarget);
		}
		public static Task Print(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BaseWidget_print_3", dxTarget);
		}
		public static Task Render(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BaseWidget_render_4", dxTarget);
		}
		public static Task ShowLoadingIndicator(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BaseWidget_showLoadingIndicator_5", dxTarget);
		}
		public static Task<string> Svg(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_BaseWidget_svg_6", dxTarget);
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
		public static Task Init(ElementRef dxTarget, DevExpress.Viz.DxChartOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxChart_Init", dxTarget, json);
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
		public static Task<bool?> GetAdjustOnZoomOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxChart_GetOption", dxTarget, "adjustOnZoom");
		}
		public static Task SetAdjustOnZoomOption(ElementRef dxTarget, bool? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxChart_SetOption", dxTarget, "adjustOnZoom", value);
		}
		public static Task<object> GetArgumentAxisOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxChart_GetOption", dxTarget, "argumentAxis");
		}
		public static Task SetArgumentAxisOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxChart_SetOption", dxTarget, "argumentAxis", value);
		}
		public static Task<float?> GetBarGroupPaddingOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_DxChart_GetOption", dxTarget, "barGroupPadding");
		}
		public static Task SetBarGroupPaddingOption(ElementRef dxTarget, float? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxChart_SetOption", dxTarget, "barGroupPadding", value);
		}
		public static Task<float?> GetBarGroupWidthOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_DxChart_GetOption", dxTarget, "barGroupWidth");
		}
		public static Task SetBarGroupWidthOption(ElementRef dxTarget, float? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxChart_SetOption", dxTarget, "barGroupWidth", value);
		}
		public static Task<float?> GetBarWidthOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_DxChart_GetOption", dxTarget, "barWidth");
		}
		public static Task SetBarWidthOption(ElementRef dxTarget, float? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxChart_SetOption", dxTarget, "barWidth", value);
		}
		public static Task<object> GetCommonAxisSettingsOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxChart_GetOption", dxTarget, "commonAxisSettings");
		}
		public static Task SetCommonAxisSettingsOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxChart_SetOption", dxTarget, "commonAxisSettings", value);
		}
		public static Task<object> GetCommonPaneSettingsOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxChart_GetOption", dxTarget, "commonPaneSettings");
		}
		public static Task SetCommonPaneSettingsOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxChart_SetOption", dxTarget, "commonPaneSettings", value);
		}
		public static Task<object> GetCommonSeriesSettingsOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxChart_GetOption", dxTarget, "commonSeriesSettings");
		}
		public static Task SetCommonSeriesSettingsOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxChart_SetOption", dxTarget, "commonSeriesSettings", value);
		}
		public static Task<string> GetContainerBackgroundColorOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxChart_GetOption", dxTarget, "containerBackgroundColor");
		}
		public static Task SetContainerBackgroundColorOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxChart_SetOption", dxTarget, "containerBackgroundColor", value);
		}
		public static Task<object> GetCrosshairOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxChart_GetOption", dxTarget, "crosshair");
		}
		public static Task SetCrosshairOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxChart_SetOption", dxTarget, "crosshair", value);
		}
		public static Task<object> GetDataPrepareSettingsOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxChart_GetOption", dxTarget, "dataPrepareSettings");
		}
		public static Task SetDataPrepareSettingsOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxChart_SetOption", dxTarget, "dataPrepareSettings", value);
		}
		public static Task<string> GetDefaultPaneOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxChart_GetOption", dxTarget, "defaultPane");
		}
		public static Task SetDefaultPaneOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxChart_SetOption", dxTarget, "defaultPane", value);
		}
		public static Task<bool?> GetEqualBarWidthOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxChart_GetOption", dxTarget, "equalBarWidth");
		}
		public static Task SetEqualBarWidthOption(ElementRef dxTarget, bool? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxChart_SetOption", dxTarget, "equalBarWidth", value);
		}
		public static Task<float?> GetMaxBubbleSizeOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_DxChart_GetOption", dxTarget, "maxBubbleSize");
		}
		public static Task SetMaxBubbleSizeOption(ElementRef dxTarget, float? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxChart_SetOption", dxTarget, "maxBubbleSize", value);
		}
		public static Task<float?> GetMinBubbleSizeOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_DxChart_GetOption", dxTarget, "minBubbleSize");
		}
		public static Task SetMinBubbleSizeOption(ElementRef dxTarget, float? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxChart_SetOption", dxTarget, "minBubbleSize", value);
		}
		public static Task<bool?> GetNegativesAsZeroesOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxChart_GetOption", dxTarget, "negativesAsZeroes");
		}
		public static Task SetNegativesAsZeroesOption(ElementRef dxTarget, bool? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxChart_SetOption", dxTarget, "negativesAsZeroes", value);
		}
		public static Task<object> GetPanesOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxChart_GetOption", dxTarget, "panes");
		}
		public static Task SetPanesOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxChart_SetOption", dxTarget, "panes", value);
		}
		public static Task<string> GetResolveLabelOverlappingOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxChart_GetOption", dxTarget, "resolveLabelOverlapping");
		}
		public static Task SetResolveLabelOverlappingOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxChart_SetOption", dxTarget, "resolveLabelOverlapping", value);
		}
		public static Task<bool?> GetRotatedOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxChart_GetOption", dxTarget, "rotated");
		}
		public static Task SetRotatedOption(ElementRef dxTarget, bool? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxChart_SetOption", dxTarget, "rotated", value);
		}
		public static Task<object> GetScrollBarOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxChart_GetOption", dxTarget, "scrollBar");
		}
		public static Task SetScrollBarOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxChart_SetOption", dxTarget, "scrollBar", value);
		}
		public static Task<string> GetScrollingModeOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxChart_GetOption", dxTarget, "scrollingMode");
		}
		public static Task SetScrollingModeOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxChart_SetOption", dxTarget, "scrollingMode", value);
		}
		public static Task<string> GetSeriesSelectionModeOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxChart_GetOption", dxTarget, "seriesSelectionMode");
		}
		public static Task SetSeriesSelectionModeOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxChart_SetOption", dxTarget, "seriesSelectionMode", value);
		}
		public static Task<object> GetSeriesTemplateOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxChart_GetOption", dxTarget, "seriesTemplate");
		}
		public static Task SetSeriesTemplateOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxChart_SetOption", dxTarget, "seriesTemplate", value);
		}
		public static Task<bool?> GetSynchronizeMultiAxesOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxChart_GetOption", dxTarget, "synchronizeMultiAxes");
		}
		public static Task SetSynchronizeMultiAxesOption(ElementRef dxTarget, bool? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxChart_SetOption", dxTarget, "synchronizeMultiAxes", value);
		}
		public static Task<bool?> GetUseAggregationOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxChart_GetOption", dxTarget, "useAggregation");
		}
		public static Task SetUseAggregationOption(ElementRef dxTarget, bool? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxChart_SetOption", dxTarget, "useAggregation", value);
		}
		public static Task<object> GetValueAxisOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxChart_GetOption", dxTarget, "valueAxis");
		}
		public static Task SetValueAxisOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxChart_SetOption", dxTarget, "valueAxis", value);
		}
		public static Task<object> GetZoomAndPanOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxChart_GetOption", dxTarget, "zoomAndPan");
		}
		public static Task SetZoomAndPanOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxChart_SetOption", dxTarget, "zoomAndPan", value);
		}
		public static Task<string> GetZoomingModeOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxChart_GetOption", dxTarget, "zoomingMode");
		}
		public static Task SetZoomingModeOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxChart_SetOption", dxTarget, "zoomingMode", value);
		}
		public static Task<object> GetArgumentAxis(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxChart_getArgumentAxis_0", dxTarget);
		}
		public static Task<object> GetValueAxis(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxChart_getValueAxis_1", dxTarget);
		}
		public static Task<object> GetValueAxis(ElementRef dxTarget, string name)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxChart_getValueAxis_2", dxTarget, name);
		}
		public static Task ResetVisualRange(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxChart_resetVisualRange_3", dxTarget);
		}
		public static Task ZoomArgument(ElementRef dxTarget, object startValue, object endValue)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxChart_zoomArgument_4", dxTarget, startValue, endValue);
		}
	}
	public class DxPieChartInterop: BaseChartInterop
	{
		public static event EventHandler<JQueryEventArgs> LegendClick;
		public static Task Init(ElementRef dxTarget, DevExpress.Viz.DxPieChartOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPieChart_Init", dxTarget, json);
		}
		[JSInvokable("DevExpress.Viz.DxPieChartInterop.OnLegendClick")]
		public static void OnLegendClick(string identifier)
		{
			LegendClick?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static Task<object> GetCommonSeriesSettingsOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPieChart_GetOption", dxTarget, "commonSeriesSettings");
		}
		public static Task SetCommonSeriesSettingsOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPieChart_SetOption", dxTarget, "commonSeriesSettings", value);
		}
		public static Task<float?> GetDiameterOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_DxPieChart_GetOption", dxTarget, "diameter");
		}
		public static Task SetDiameterOption(ElementRef dxTarget, float? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPieChart_SetOption", dxTarget, "diameter", value);
		}
		public static Task<float?> GetInnerRadiusOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_DxPieChart_GetOption", dxTarget, "innerRadius");
		}
		public static Task SetInnerRadiusOption(ElementRef dxTarget, float? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPieChart_SetOption", dxTarget, "innerRadius", value);
		}
		public static Task<float?> GetMinDiameterOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_DxPieChart_GetOption", dxTarget, "minDiameter");
		}
		public static Task SetMinDiameterOption(ElementRef dxTarget, float? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPieChart_SetOption", dxTarget, "minDiameter", value);
		}
		public static Task<string> GetResolveLabelOverlappingOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxPieChart_GetOption", dxTarget, "resolveLabelOverlapping");
		}
		public static Task SetResolveLabelOverlappingOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPieChart_SetOption", dxTarget, "resolveLabelOverlapping", value);
		}
		public static Task<string> GetSegmentsDirectionOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxPieChart_GetOption", dxTarget, "segmentsDirection");
		}
		public static Task SetSegmentsDirectionOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPieChart_SetOption", dxTarget, "segmentsDirection", value);
		}
		public static Task<object> GetSeriesTemplateOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPieChart_GetOption", dxTarget, "seriesTemplate");
		}
		public static Task SetSeriesTemplateOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPieChart_SetOption", dxTarget, "seriesTemplate", value);
		}
		public static Task<string> GetSizeGroupOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxPieChart_GetOption", dxTarget, "sizeGroup");
		}
		public static Task SetSizeGroupOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPieChart_SetOption", dxTarget, "sizeGroup", value);
		}
		public static Task<float?> GetStartAngleOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_DxPieChart_GetOption", dxTarget, "startAngle");
		}
		public static Task SetStartAngleOption(ElementRef dxTarget, float? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPieChart_SetOption", dxTarget, "startAngle", value);
		}
		public static Task<string> GetTypeOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxPieChart_GetOption", dxTarget, "type");
		}
		public static Task SetTypeOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPieChart_SetOption", dxTarget, "type", value);
		}
	}
	public class DxPolarChartInterop: BaseChartInterop
	{
		public static event EventHandler<JQueryEventArgs> ArgumentAxisClick;
		public static event EventHandler<JQueryEventArgs> LegendClick;
		public static event EventHandler<JQueryEventArgs> SeriesClick;
		public static event EventHandler<JQueryEventArgs> SeriesHoverChanged;
		public static event EventHandler<JQueryEventArgs> SeriesSelectionChanged;
		public static Task Init(ElementRef dxTarget, DevExpress.Viz.DxPolarChartOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPolarChart_Init", dxTarget, json);
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
		public static Task<object> GetArgumentAxisOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPolarChart_GetOption", dxTarget, "argumentAxis");
		}
		public static Task SetArgumentAxisOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPolarChart_SetOption", dxTarget, "argumentAxis", value);
		}
		public static Task<float?> GetBarGroupPaddingOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_DxPolarChart_GetOption", dxTarget, "barGroupPadding");
		}
		public static Task SetBarGroupPaddingOption(ElementRef dxTarget, float? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPolarChart_SetOption", dxTarget, "barGroupPadding", value);
		}
		public static Task<float?> GetBarGroupWidthOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_DxPolarChart_GetOption", dxTarget, "barGroupWidth");
		}
		public static Task SetBarGroupWidthOption(ElementRef dxTarget, float? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPolarChart_SetOption", dxTarget, "barGroupWidth", value);
		}
		public static Task<float?> GetBarWidthOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_DxPolarChart_GetOption", dxTarget, "barWidth");
		}
		public static Task SetBarWidthOption(ElementRef dxTarget, float? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPolarChart_SetOption", dxTarget, "barWidth", value);
		}
		public static Task<object> GetCommonAxisSettingsOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPolarChart_GetOption", dxTarget, "commonAxisSettings");
		}
		public static Task SetCommonAxisSettingsOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPolarChart_SetOption", dxTarget, "commonAxisSettings", value);
		}
		public static Task<object> GetCommonSeriesSettingsOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPolarChart_GetOption", dxTarget, "commonSeriesSettings");
		}
		public static Task SetCommonSeriesSettingsOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPolarChart_SetOption", dxTarget, "commonSeriesSettings", value);
		}
		public static Task<string> GetContainerBackgroundColorOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxPolarChart_GetOption", dxTarget, "containerBackgroundColor");
		}
		public static Task SetContainerBackgroundColorOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPolarChart_SetOption", dxTarget, "containerBackgroundColor", value);
		}
		public static Task<object> GetDataPrepareSettingsOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPolarChart_GetOption", dxTarget, "dataPrepareSettings");
		}
		public static Task SetDataPrepareSettingsOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPolarChart_SetOption", dxTarget, "dataPrepareSettings", value);
		}
		public static Task<bool?> GetEqualBarWidthOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxPolarChart_GetOption", dxTarget, "equalBarWidth");
		}
		public static Task SetEqualBarWidthOption(ElementRef dxTarget, bool? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPolarChart_SetOption", dxTarget, "equalBarWidth", value);
		}
		public static Task<bool?> GetNegativesAsZeroesOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxPolarChart_GetOption", dxTarget, "negativesAsZeroes");
		}
		public static Task SetNegativesAsZeroesOption(ElementRef dxTarget, bool? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPolarChart_SetOption", dxTarget, "negativesAsZeroes", value);
		}
		public static Task<string> GetResolveLabelOverlappingOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxPolarChart_GetOption", dxTarget, "resolveLabelOverlapping");
		}
		public static Task SetResolveLabelOverlappingOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPolarChart_SetOption", dxTarget, "resolveLabelOverlapping", value);
		}
		public static Task<string> GetSeriesSelectionModeOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxPolarChart_GetOption", dxTarget, "seriesSelectionMode");
		}
		public static Task SetSeriesSelectionModeOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPolarChart_SetOption", dxTarget, "seriesSelectionMode", value);
		}
		public static Task<object> GetSeriesTemplateOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPolarChart_GetOption", dxTarget, "seriesTemplate");
		}
		public static Task SetSeriesTemplateOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPolarChart_SetOption", dxTarget, "seriesTemplate", value);
		}
		public static Task<bool?> GetUseSpiderWebOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxPolarChart_GetOption", dxTarget, "useSpiderWeb");
		}
		public static Task SetUseSpiderWebOption(ElementRef dxTarget, bool? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPolarChart_SetOption", dxTarget, "useSpiderWeb", value);
		}
		public static Task<object> GetValueAxisOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPolarChart_GetOption", dxTarget, "valueAxis");
		}
		public static Task SetValueAxisOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPolarChart_SetOption", dxTarget, "valueAxis", value);
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
		public static Task<object> GetAdaptiveLayoutOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BaseChart_GetOption", dxTarget, "adaptiveLayout");
		}
		public static Task SetAdaptiveLayoutOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BaseChart_SetOption", dxTarget, "adaptiveLayout", value);
		}
		public static Task<object> GetAnimationOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BaseChart_GetOption", dxTarget, "animation");
		}
		public static Task SetAnimationOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BaseChart_SetOption", dxTarget, "animation", value);
		}
		public static Task<object> GetCustomizeLabelOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BaseChart_GetOption", dxTarget, "customizeLabel");
		}
		public static Task SetCustomizeLabelOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BaseChart_SetOption", dxTarget, "customizeLabel", value);
		}
		public static Task<object> GetCustomizePointOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BaseChart_GetOption", dxTarget, "customizePoint");
		}
		public static Task SetCustomizePointOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BaseChart_SetOption", dxTarget, "customizePoint", value);
		}
		public static Task<object> GetDataSourceOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BaseChart_GetOption", dxTarget, "dataSource");
		}
		public static Task SetDataSourceOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BaseChart_SetOption", dxTarget, "dataSource", value);
		}
		public static Task<object> GetLegendOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BaseChart_GetOption", dxTarget, "legend");
		}
		public static Task SetLegendOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BaseChart_SetOption", dxTarget, "legend", value);
		}
		public static Task<object> GetPaletteOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BaseChart_GetOption", dxTarget, "palette");
		}
		public static Task SetPaletteOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BaseChart_SetOption", dxTarget, "palette", value);
		}
		public static Task<string> GetPaletteExtensionModeOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_BaseChart_GetOption", dxTarget, "paletteExtensionMode");
		}
		public static Task SetPaletteExtensionModeOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BaseChart_SetOption", dxTarget, "paletteExtensionMode", value);
		}
		public static Task<string> GetPointSelectionModeOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_BaseChart_GetOption", dxTarget, "pointSelectionMode");
		}
		public static Task SetPointSelectionModeOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BaseChart_SetOption", dxTarget, "pointSelectionMode", value);
		}
		public static Task<object> GetSeriesOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BaseChart_GetOption", dxTarget, "series");
		}
		public static Task SetSeriesOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BaseChart_SetOption", dxTarget, "series", value);
		}
		public static Task ClearSelection(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BaseChart_clearSelection_0", dxTarget);
		}
		public static Task<object> GetAllSeries(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BaseChart_getAllSeries_1", dxTarget);
		}
		public static Task<object> GetDataSourceEx(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BaseChart_getDataSource_2", dxTarget);
		}
		public static Task<object> GetSeriesByName(ElementRef dxTarget, object seriesName)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BaseChart_getSeriesByName_3", dxTarget, seriesName);
		}
		public static Task<object> GetSeriesByPos(ElementRef dxTarget, float seriesIndex)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BaseChart_getSeriesByPos_4", dxTarget, seriesIndex);
		}
		public static Task HideTooltip(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BaseChart_hideTooltip_5", dxTarget);
		}
		public static Task Refresh(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BaseChart_refresh_6", dxTarget);
		}
		public static Task Render(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BaseChart_render_7", dxTarget);
		}
		public static Task Render(ElementRef dxTarget, object renderOptions)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BaseChart_render_8", dxTarget, renderOptions);
		}
	}
	public class DxFunnelInterop: BaseWidgetInterop
	{
		public static event EventHandler<JQueryEventArgs> HoverChanged;
		public static event EventHandler<JQueryEventArgs> ItemClick;
		public static event EventHandler<JQueryEventArgs> LegendClick;
		public static event EventHandler<JQueryEventArgs> SelectionChanged;
		public static Task Init(ElementRef dxTarget, DevExpress.Viz.DxFunnelOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxFunnel_Init", dxTarget, json);
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
		public static Task<object> GetAdaptiveLayoutOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxFunnel_GetOption", dxTarget, "adaptiveLayout");
		}
		public static Task SetAdaptiveLayoutOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxFunnel_SetOption", dxTarget, "adaptiveLayout", value);
		}
		public static Task<string> GetAlgorithmOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxFunnel_GetOption", dxTarget, "algorithm");
		}
		public static Task SetAlgorithmOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxFunnel_SetOption", dxTarget, "algorithm", value);
		}
		public static Task<string> GetArgumentFieldOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxFunnel_GetOption", dxTarget, "argumentField");
		}
		public static Task SetArgumentFieldOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxFunnel_SetOption", dxTarget, "argumentField", value);
		}
		public static Task<string> GetColorFieldOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxFunnel_GetOption", dxTarget, "colorField");
		}
		public static Task SetColorFieldOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxFunnel_SetOption", dxTarget, "colorField", value);
		}
		public static Task<object> GetDataSourceOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxFunnel_GetOption", dxTarget, "dataSource");
		}
		public static Task SetDataSourceOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxFunnel_SetOption", dxTarget, "dataSource", value);
		}
		public static Task<bool?> GetHoverEnabledOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxFunnel_GetOption", dxTarget, "hoverEnabled");
		}
		public static Task SetHoverEnabledOption(ElementRef dxTarget, bool? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxFunnel_SetOption", dxTarget, "hoverEnabled", value);
		}
		public static Task<bool?> GetInvertedOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxFunnel_GetOption", dxTarget, "inverted");
		}
		public static Task SetInvertedOption(ElementRef dxTarget, bool? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxFunnel_SetOption", dxTarget, "inverted", value);
		}
		public static Task<object> GetItemOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxFunnel_GetOption", dxTarget, "item");
		}
		public static Task SetItemOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxFunnel_SetOption", dxTarget, "item", value);
		}
		public static Task<object> GetLabelOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxFunnel_GetOption", dxTarget, "label");
		}
		public static Task SetLabelOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxFunnel_SetOption", dxTarget, "label", value);
		}
		public static Task<object> GetLegendOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxFunnel_GetOption", dxTarget, "legend");
		}
		public static Task SetLegendOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxFunnel_SetOption", dxTarget, "legend", value);
		}
		public static Task<float?> GetNeckHeightOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_DxFunnel_GetOption", dxTarget, "neckHeight");
		}
		public static Task SetNeckHeightOption(ElementRef dxTarget, float? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxFunnel_SetOption", dxTarget, "neckHeight", value);
		}
		public static Task<float?> GetNeckWidthOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_DxFunnel_GetOption", dxTarget, "neckWidth");
		}
		public static Task SetNeckWidthOption(ElementRef dxTarget, float? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxFunnel_SetOption", dxTarget, "neckWidth", value);
		}
		public static Task<object> GetPaletteOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxFunnel_GetOption", dxTarget, "palette");
		}
		public static Task SetPaletteOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxFunnel_SetOption", dxTarget, "palette", value);
		}
		public static Task<string> GetPaletteExtensionModeOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxFunnel_GetOption", dxTarget, "paletteExtensionMode");
		}
		public static Task SetPaletteExtensionModeOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxFunnel_SetOption", dxTarget, "paletteExtensionMode", value);
		}
		public static Task<string> GetSelectionModeOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxFunnel_GetOption", dxTarget, "selectionMode");
		}
		public static Task SetSelectionModeOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxFunnel_SetOption", dxTarget, "selectionMode", value);
		}
		public static Task<bool?> GetSortDataOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxFunnel_GetOption", dxTarget, "sortData");
		}
		public static Task SetSortDataOption(ElementRef dxTarget, bool? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxFunnel_SetOption", dxTarget, "sortData", value);
		}
		public static Task<string> GetValueFieldOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxFunnel_GetOption", dxTarget, "valueField");
		}
		public static Task SetValueFieldOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxFunnel_SetOption", dxTarget, "valueField", value);
		}
		public static Task ClearSelection(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxFunnel_clearSelection_0", dxTarget);
		}
		public static Task<object> GetAllItems(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxFunnel_getAllItems_1", dxTarget);
		}
		public static Task<object> GetDataSourceEx(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxFunnel_getDataSource_2", dxTarget);
		}
		public static Task HideTooltip(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxFunnel_hideTooltip_3", dxTarget);
		}
	}
	public class BaseGaugeInterop: BaseWidgetInterop
	{
		public static event EventHandler<JQueryEventArgs> TooltipHidden;
		public static event EventHandler<JQueryEventArgs> TooltipShown;
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
		public static Task<object> GetAnimationOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BaseGauge_GetOption", dxTarget, "animation");
		}
		public static Task SetAnimationOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BaseGauge_SetOption", dxTarget, "animation", value);
		}
		public static Task<string> GetContainerBackgroundColorOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_BaseGauge_GetOption", dxTarget, "containerBackgroundColor");
		}
		public static Task SetContainerBackgroundColorOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BaseGauge_SetOption", dxTarget, "containerBackgroundColor", value);
		}
		public static Task<object> GetRangeContainerOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BaseGauge_GetOption", dxTarget, "rangeContainer");
		}
		public static Task SetRangeContainerOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BaseGauge_SetOption", dxTarget, "rangeContainer", value);
		}
		public static Task<object> GetScaleOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BaseGauge_GetOption", dxTarget, "scale");
		}
		public static Task SetScaleOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BaseGauge_SetOption", dxTarget, "scale", value);
		}
		public static Task<object> GetSubvaluesOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BaseGauge_GetOption", dxTarget, "subvalues");
		}
		public static Task SetSubvaluesOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BaseGauge_SetOption", dxTarget, "subvalues", value);
		}
		public static Task<float?> GetValueOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_BaseGauge_GetOption", dxTarget, "value");
		}
		public static Task SetValueOption(ElementRef dxTarget, float? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BaseGauge_SetOption", dxTarget, "value", value);
		}
		public static Task<object> SubvaluesEx(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BaseGauge_subvalues_0", dxTarget);
		}
		public static Task SubvaluesEx(ElementRef dxTarget, object subvalues)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BaseGauge_subvalues_1", dxTarget, subvalues);
		}
		public static Task<float> ValueEx(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<float>("BlazorDevExtreme_BaseGauge_value_2", dxTarget);
		}
		public static Task ValueEx(ElementRef dxTarget, float value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BaseGauge_value_3", dxTarget, value);
		}
	}
	public class DxCircularGaugeInterop: BaseGaugeInterop
	{
		public static Task Init(ElementRef dxTarget, DevExpress.Viz.DxCircularGaugeOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxCircularGauge_Init", dxTarget, json);
		}
		public static Task<object> GetGeometryOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxCircularGauge_GetOption", dxTarget, "geometry");
		}
		public static Task SetGeometryOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxCircularGauge_SetOption", dxTarget, "geometry", value);
		}
		public static Task<object> GetSubvalueIndicatorOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxCircularGauge_GetOption", dxTarget, "subvalueIndicator");
		}
		public static Task SetSubvalueIndicatorOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxCircularGauge_SetOption", dxTarget, "subvalueIndicator", value);
		}
		public static Task<object> GetValueIndicatorOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxCircularGauge_GetOption", dxTarget, "valueIndicator");
		}
		public static Task SetValueIndicatorOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxCircularGauge_SetOption", dxTarget, "valueIndicator", value);
		}
	}
	public class DxLinearGaugeInterop: BaseGaugeInterop
	{
		public static Task Init(ElementRef dxTarget, DevExpress.Viz.DxLinearGaugeOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxLinearGauge_Init", dxTarget, json);
		}
		public static Task<object> GetGeometryOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxLinearGauge_GetOption", dxTarget, "geometry");
		}
		public static Task SetGeometryOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxLinearGauge_SetOption", dxTarget, "geometry", value);
		}
		public static Task<object> GetSubvalueIndicatorOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxLinearGauge_GetOption", dxTarget, "subvalueIndicator");
		}
		public static Task SetSubvalueIndicatorOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxLinearGauge_SetOption", dxTarget, "subvalueIndicator", value);
		}
		public static Task<object> GetValueIndicatorOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxLinearGauge_GetOption", dxTarget, "valueIndicator");
		}
		public static Task SetValueIndicatorOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxLinearGauge_SetOption", dxTarget, "valueIndicator", value);
		}
	}
	public class DxBarGaugeInterop: BaseWidgetInterop
	{
		public static event EventHandler<JQueryEventArgs> TooltipHidden;
		public static event EventHandler<JQueryEventArgs> TooltipShown;
		public static Task Init(ElementRef dxTarget, DevExpress.Viz.DxBarGaugeOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxBarGauge_Init", dxTarget, json);
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
		public static Task<object> GetAnimationOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxBarGauge_GetOption", dxTarget, "animation");
		}
		public static Task SetAnimationOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxBarGauge_SetOption", dxTarget, "animation", value);
		}
		public static Task<string> GetBackgroundColorOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxBarGauge_GetOption", dxTarget, "backgroundColor");
		}
		public static Task SetBackgroundColorOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxBarGauge_SetOption", dxTarget, "backgroundColor", value);
		}
		public static Task<float?> GetBarSpacingOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_DxBarGauge_GetOption", dxTarget, "barSpacing");
		}
		public static Task SetBarSpacingOption(ElementRef dxTarget, float? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxBarGauge_SetOption", dxTarget, "barSpacing", value);
		}
		public static Task<float?> GetBaseValueOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_DxBarGauge_GetOption", dxTarget, "baseValue");
		}
		public static Task SetBaseValueOption(ElementRef dxTarget, float? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxBarGauge_SetOption", dxTarget, "baseValue", value);
		}
		public static Task<float?> GetEndValueOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_DxBarGauge_GetOption", dxTarget, "endValue");
		}
		public static Task SetEndValueOption(ElementRef dxTarget, float? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxBarGauge_SetOption", dxTarget, "endValue", value);
		}
		public static Task<object> GetGeometryOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxBarGauge_GetOption", dxTarget, "geometry");
		}
		public static Task SetGeometryOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxBarGauge_SetOption", dxTarget, "geometry", value);
		}
		public static Task<object> GetLabelOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxBarGauge_GetOption", dxTarget, "label");
		}
		public static Task SetLabelOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxBarGauge_SetOption", dxTarget, "label", value);
		}
		public static Task<object> GetPaletteOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxBarGauge_GetOption", dxTarget, "palette");
		}
		public static Task SetPaletteOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxBarGauge_SetOption", dxTarget, "palette", value);
		}
		public static Task<string> GetPaletteExtensionModeOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxBarGauge_GetOption", dxTarget, "paletteExtensionMode");
		}
		public static Task SetPaletteExtensionModeOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxBarGauge_SetOption", dxTarget, "paletteExtensionMode", value);
		}
		public static Task<float?> GetRelativeInnerRadiusOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_DxBarGauge_GetOption", dxTarget, "relativeInnerRadius");
		}
		public static Task SetRelativeInnerRadiusOption(ElementRef dxTarget, float? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxBarGauge_SetOption", dxTarget, "relativeInnerRadius", value);
		}
		public static Task<float?> GetStartValueOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_DxBarGauge_GetOption", dxTarget, "startValue");
		}
		public static Task SetStartValueOption(ElementRef dxTarget, float? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxBarGauge_SetOption", dxTarget, "startValue", value);
		}
		public static Task<object> GetValuesOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxBarGauge_GetOption", dxTarget, "values");
		}
		public static Task SetValuesOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxBarGauge_SetOption", dxTarget, "values", value);
		}
		public static Task<object> ValuesEx(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxBarGauge_values_0", dxTarget);
		}
		public static Task ValuesEx(ElementRef dxTarget, object values)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxBarGauge_values_1", dxTarget, values);
		}
	}
	public class BaseSeriesObjectInterop
	{
		public static Task ClearHover(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BaseSeriesObject_clearHover_0", dxTarget);
		}
		public static Task ClearSelection(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BaseSeriesObject_clearSelection_1", dxTarget);
		}
		public static Task DeselectPoint(ElementRef dxTarget, object point)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BaseSeriesObject_deselectPoint_2", dxTarget, point);
		}
		public static Task<object> GetAllPoints(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BaseSeriesObject_getAllPoints_3", dxTarget);
		}
		public static Task<string> GetColor(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_BaseSeriesObject_getColor_4", dxTarget);
		}
		public static Task<object> GetPointByPos(ElementRef dxTarget, float positionIndex)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BaseSeriesObject_getPointByPos_5", dxTarget, positionIndex);
		}
		public static Task<object> GetPointsByArg(ElementRef dxTarget, object pointArg)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BaseSeriesObject_getPointsByArg_6", dxTarget, pointArg);
		}
		public static Task<object> GetVisiblePoints(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BaseSeriesObject_getVisiblePoints_7", dxTarget);
		}
		public static Task Hide(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BaseSeriesObject_hide_8", dxTarget);
		}
		public static Task Hover(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BaseSeriesObject_hover_9", dxTarget);
		}
		public static Task<bool> IsHovered(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool>("BlazorDevExtreme_BaseSeriesObject_isHovered_10", dxTarget);
		}
		public static Task<bool> IsSelected(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool>("BlazorDevExtreme_BaseSeriesObject_isSelected_11", dxTarget);
		}
		public static Task<bool> IsVisible(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool>("BlazorDevExtreme_BaseSeriesObject_isVisible_12", dxTarget);
		}
		public static Task Select(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BaseSeriesObject_select_13", dxTarget);
		}
		public static Task SelectPoint(ElementRef dxTarget, object point)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BaseSeriesObject_selectPoint_14", dxTarget, point);
		}
		public static Task Show(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BaseSeriesObject_show_15", dxTarget);
		}
	}
	public class BasePointObjectInterop
	{
		public static Task ClearHover(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BasePointObject_clearHover_0", dxTarget);
		}
		public static Task ClearSelection(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BasePointObject_clearSelection_1", dxTarget);
		}
		public static Task<string> GetColor(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_BasePointObject_getColor_2", dxTarget);
		}
		public static Task<object> GetLabel(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BasePointObject_getLabel_3", dxTarget);
		}
		public static Task HideTooltip(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BasePointObject_hideTooltip_4", dxTarget);
		}
		public static Task Hover(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BasePointObject_hover_5", dxTarget);
		}
		public static Task<bool> IsHovered(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool>("BlazorDevExtreme_BasePointObject_isHovered_6", dxTarget);
		}
		public static Task<bool> IsSelected(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool>("BlazorDevExtreme_BasePointObject_isSelected_7", dxTarget);
		}
		public static Task Select(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BasePointObject_select_8", dxTarget);
		}
		public static Task ShowTooltip(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BasePointObject_showTooltip_9", dxTarget);
		}
	}
	public class BaseLabelObjectInterop
	{
		public static Task<object> GetBoundingRect(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BaseLabelObject_getBoundingRect_0", dxTarget);
		}
		public static Task Hide(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BaseLabelObject_hide_1", dxTarget);
		}
		public static Task Hide(ElementRef dxTarget, bool holdInvisible)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BaseLabelObject_hide_2", dxTarget, holdInvisible);
		}
		public static Task<bool> IsVisible(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool>("BlazorDevExtreme_BaseLabelObject_isVisible_3", dxTarget);
		}
		public static Task Show(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BaseLabelObject_show_4", dxTarget);
		}
		public static Task Show(ElementRef dxTarget, bool holdVisible)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BaseLabelObject_show_5", dxTarget, holdVisible);
		}
	}
	public class ChartSeriesObjectInterop: BaseSeriesObjectInterop
	{
		public static Task<object> GetArgumentAxis(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_ChartSeriesObject_getArgumentAxis_0", dxTarget);
		}
		public static Task<object> GetValueAxis(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_ChartSeriesObject_getValueAxis_1", dxTarget);
		}
	}
	public class ChartPointObjectInterop: BasePointObjectInterop
	{
		public static Task<object> GetBoundingRect(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_ChartPointObject_getBoundingRect_0", dxTarget);
		}
	}
	public class ChartAxisObjectInterop
	{
		public static Task<object> VisualRange(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_ChartAxisObject_visualRange_0", dxTarget);
		}
		public static Task VisualRange(ElementRef dxTarget, object visualRange)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_ChartAxisObject_visualRange_1", dxTarget, visualRange);
		}
	}
	public class DxFunnelItemInterop
	{
		public static Task<string> GetColor(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxFunnelItem_getColor_0", dxTarget);
		}
		public static Task Hover(ElementRef dxTarget, bool state)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxFunnelItem_hover_1", dxTarget, state);
		}
		public static Task<bool> IsHovered(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool>("BlazorDevExtreme_DxFunnelItem_isHovered_2", dxTarget);
		}
		public static Task<bool> IsSelected(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool>("BlazorDevExtreme_DxFunnelItem_isSelected_3", dxTarget);
		}
		public static Task Select(ElementRef dxTarget, bool state)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxFunnelItem_select_4", dxTarget, state);
		}
		public static Task ShowTooltip(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxFunnelItem_showTooltip_5", dxTarget);
		}
	}
	public class PiePointObjectInterop: BasePointObjectInterop
	{
		public static Task Hide(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_PiePointObject_hide_0", dxTarget);
		}
		public static Task HideTooltip(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_PiePointObject_hideTooltip_1", dxTarget);
		}
		public static Task<bool> IsVisible(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool>("BlazorDevExtreme_PiePointObject_isVisible_2", dxTarget);
		}
		public static Task Show(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_PiePointObject_show_3", dxTarget);
		}
		public static Task ShowTooltip(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_PiePointObject_showTooltip_4", dxTarget);
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
	public class DxSankeyNodeInterop
	{
		public static Task HideTooltip(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxSankeyNode_hideTooltip_0", dxTarget);
		}
		public static Task Hover(ElementRef dxTarget, bool state)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxSankeyNode_hover_1", dxTarget, state);
		}
		public static Task<bool> IsHovered(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool>("BlazorDevExtreme_DxSankeyNode_isHovered_2", dxTarget);
		}
		public static Task ShowTooltip(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxSankeyNode_showTooltip_3", dxTarget);
		}
	}
	public class DxSankeyLinkInterop
	{
		public static Task HideTooltip(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxSankeyLink_hideTooltip_0", dxTarget);
		}
		public static Task Hover(ElementRef dxTarget, bool state)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxSankeyLink_hover_1", dxTarget, state);
		}
		public static Task<bool> IsHovered(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool>("BlazorDevExtreme_DxSankeyLink_isHovered_2", dxTarget);
		}
		public static Task ShowTooltip(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxSankeyLink_showTooltip_3", dxTarget);
		}
	}
	public class DxTreeMapNodeInterop
	{
		public static Task Customize(ElementRef dxTarget, object options)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeMapNode_customize_0", dxTarget, options);
		}
		public static Task DrillDown(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeMapNode_drillDown_1", dxTarget);
		}
		public static Task<object> GetAllChildren(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeMapNode_getAllChildren_2", dxTarget);
		}
		public static Task<object> GetAllNodes(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeMapNode_getAllNodes_3", dxTarget);
		}
		public static Task<object> GetChild(ElementRef dxTarget, float index)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeMapNode_getChild_4", dxTarget, index);
		}
		public static Task<float> GetChildrenCount(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<float>("BlazorDevExtreme_DxTreeMapNode_getChildrenCount_5", dxTarget);
		}
		public static Task<object> GetParent(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeMapNode_getParent_6", dxTarget);
		}
		public static Task<bool> IsActive(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool>("BlazorDevExtreme_DxTreeMapNode_isActive_7", dxTarget);
		}
		public static Task<bool> IsHovered(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool>("BlazorDevExtreme_DxTreeMapNode_isHovered_8", dxTarget);
		}
		public static Task<bool> IsLeaf(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool>("BlazorDevExtreme_DxTreeMapNode_isLeaf_9", dxTarget);
		}
		public static Task<bool> IsSelected(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool>("BlazorDevExtreme_DxTreeMapNode_isSelected_10", dxTarget);
		}
		public static Task<string> Label(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxTreeMapNode_label_11", dxTarget);
		}
		public static Task Label(ElementRef dxTarget, string label)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeMapNode_label_12", dxTarget, label);
		}
		public static Task ResetCustomization(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeMapNode_resetCustomization_13", dxTarget);
		}
		public static Task Select(ElementRef dxTarget, bool state)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeMapNode_select_14", dxTarget, state);
		}
		public static Task ShowTooltip(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeMapNode_showTooltip_15", dxTarget);
		}
		public static Task<float> ValueEx(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<float>("BlazorDevExtreme_DxTreeMapNode_value_16", dxTarget);
		}
	}
	public class MapLayerInterop
	{
		public static Task ClearSelection(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_MapLayer_clearSelection_0", dxTarget);
		}
		public static Task<object> GetDataSourceEx(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_MapLayer_getDataSource_1", dxTarget);
		}
		public static Task<object> GetElements(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_MapLayer_getElements_2", dxTarget);
		}
	}
	public class MapLayerElementInterop
	{
		public static Task ApplySettings(ElementRef dxTarget, object settings)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_MapLayerElement_applySettings_0", dxTarget, settings);
		}
		public static Task<object> Attribute(ElementRef dxTarget, string name)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_MapLayerElement_attribute_1", dxTarget, name);
		}
		public static Task Attribute(ElementRef dxTarget, string name, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_MapLayerElement_attribute_2", dxTarget, name, value);
		}
		public static Task<object> Coordinates(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_MapLayerElement_coordinates_3", dxTarget);
		}
		public static Task<bool> Selected(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool>("BlazorDevExtreme_MapLayerElement_selected_4", dxTarget);
		}
		public static Task Selected(ElementRef dxTarget, bool state)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_MapLayerElement_selected_5", dxTarget, state);
		}
	}
	public class DxRangeSelectorInterop: BaseWidgetInterop
	{
		public static event EventHandler<JQueryEventArgs> ValueChanged;
		public static Task Init(ElementRef dxTarget, DevExpress.Viz.DxRangeSelectorOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxRangeSelector_Init", dxTarget, json);
		}
		[JSInvokable("DevExpress.Viz.DxRangeSelectorInterop.OnValueChanged")]
		public static void OnValueChanged(string identifier)
		{
			ValueChanged?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static Task<object> GetBackgroundOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxRangeSelector_GetOption", dxTarget, "background");
		}
		public static Task SetBackgroundOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxRangeSelector_SetOption", dxTarget, "background", value);
		}
		public static Task<object> GetBehaviorOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxRangeSelector_GetOption", dxTarget, "behavior");
		}
		public static Task SetBehaviorOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxRangeSelector_SetOption", dxTarget, "behavior", value);
		}
		public static Task<object> GetChartOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxRangeSelector_GetOption", dxTarget, "chart");
		}
		public static Task SetChartOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxRangeSelector_SetOption", dxTarget, "chart", value);
		}
		public static Task<string> GetContainerBackgroundColorOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxRangeSelector_GetOption", dxTarget, "containerBackgroundColor");
		}
		public static Task SetContainerBackgroundColorOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxRangeSelector_SetOption", dxTarget, "containerBackgroundColor", value);
		}
		public static Task<object> GetDataSourceOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxRangeSelector_GetOption", dxTarget, "dataSource");
		}
		public static Task SetDataSourceOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxRangeSelector_SetOption", dxTarget, "dataSource", value);
		}
		public static Task<string> GetDataSourceFieldOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxRangeSelector_GetOption", dxTarget, "dataSourceField");
		}
		public static Task SetDataSourceFieldOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxRangeSelector_SetOption", dxTarget, "dataSourceField", value);
		}
		public static Task<object> GetIndentOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxRangeSelector_GetOption", dxTarget, "indent");
		}
		public static Task SetIndentOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxRangeSelector_SetOption", dxTarget, "indent", value);
		}
		public static Task<object> GetScaleOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxRangeSelector_GetOption", dxTarget, "scale");
		}
		public static Task SetScaleOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxRangeSelector_SetOption", dxTarget, "scale", value);
		}
		public static Task<string> GetSelectedRangeColorOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxRangeSelector_GetOption", dxTarget, "selectedRangeColor");
		}
		public static Task SetSelectedRangeColorOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxRangeSelector_SetOption", dxTarget, "selectedRangeColor", value);
		}
		public static Task<string> GetSelectedRangeUpdateModeOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxRangeSelector_GetOption", dxTarget, "selectedRangeUpdateMode");
		}
		public static Task SetSelectedRangeUpdateModeOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxRangeSelector_SetOption", dxTarget, "selectedRangeUpdateMode", value);
		}
		public static Task<object> GetShutterOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxRangeSelector_GetOption", dxTarget, "shutter");
		}
		public static Task SetShutterOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxRangeSelector_SetOption", dxTarget, "shutter", value);
		}
		public static Task<object> GetSliderHandleOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxRangeSelector_GetOption", dxTarget, "sliderHandle");
		}
		public static Task SetSliderHandleOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxRangeSelector_SetOption", dxTarget, "sliderHandle", value);
		}
		public static Task<object> GetSliderMarkerOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxRangeSelector_GetOption", dxTarget, "sliderMarker");
		}
		public static Task SetSliderMarkerOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxRangeSelector_SetOption", dxTarget, "sliderMarker", value);
		}
		public static Task<object> GetValueOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxRangeSelector_GetOption", dxTarget, "value");
		}
		public static Task SetValueOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxRangeSelector_SetOption", dxTarget, "value", value);
		}
		public static Task<object> GetDataSourceEx(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxRangeSelector_getDataSource_0", dxTarget);
		}
		public static Task<object> GetValueEx(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxRangeSelector_getValue_1", dxTarget);
		}
		public static Task Render(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxRangeSelector_render_2", dxTarget);
		}
		public static Task Render(ElementRef dxTarget, bool skipChartAnimation)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxRangeSelector_render_3", dxTarget, skipChartAnimation);
		}
		public static Task SetValueEx(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxRangeSelector_setValue_4", dxTarget, value);
		}
	}
	public class DxSankeyInterop: BaseWidgetInterop
	{
		public static event EventHandler<JQueryEventArgs> LinkClick;
		public static event EventHandler<JQueryEventArgs> LinkHoverChanged;
		public static event EventHandler<JQueryEventArgs> NodeClick;
		public static event EventHandler<JQueryEventArgs> NodeHoverChanged;
		public static Task Init(ElementRef dxTarget, DevExpress.Viz.DxSankeyOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxSankey_Init", dxTarget, json);
		}
		[JSInvokable("DevExpress.Viz.DxSankeyInterop.OnLinkClick")]
		public static void OnLinkClick(string identifier)
		{
			LinkClick?.Invoke(null, new JQueryEventArgs(identifier));
		}
		[JSInvokable("DevExpress.Viz.DxSankeyInterop.OnLinkHoverChanged")]
		public static void OnLinkHoverChanged(string identifier)
		{
			LinkHoverChanged?.Invoke(null, new JQueryEventArgs(identifier));
		}
		[JSInvokable("DevExpress.Viz.DxSankeyInterop.OnNodeClick")]
		public static void OnNodeClick(string identifier)
		{
			NodeClick?.Invoke(null, new JQueryEventArgs(identifier));
		}
		[JSInvokable("DevExpress.Viz.DxSankeyInterop.OnNodeHoverChanged")]
		public static void OnNodeHoverChanged(string identifier)
		{
			NodeHoverChanged?.Invoke(null, new JQueryEventArgs(identifier));
		}
		public static Task<object> GetAdaptiveLayoutOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxSankey_GetOption", dxTarget, "adaptiveLayout");
		}
		public static Task SetAdaptiveLayoutOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxSankey_SetOption", dxTarget, "adaptiveLayout", value);
		}
		public static Task<object> GetAlignmentOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxSankey_GetOption", dxTarget, "alignment");
		}
		public static Task SetAlignmentOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxSankey_SetOption", dxTarget, "alignment", value);
		}
		public static Task<object> GetDataSourceOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxSankey_GetOption", dxTarget, "dataSource");
		}
		public static Task SetDataSourceOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxSankey_SetOption", dxTarget, "dataSource", value);
		}
		public static Task<bool?> GetHoverEnabledOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxSankey_GetOption", dxTarget, "hoverEnabled");
		}
		public static Task SetHoverEnabledOption(ElementRef dxTarget, bool? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxSankey_SetOption", dxTarget, "hoverEnabled", value);
		}
		public static Task<object> GetLabelOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxSankey_GetOption", dxTarget, "label");
		}
		public static Task SetLabelOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxSankey_SetOption", dxTarget, "label", value);
		}
		public static Task<object> GetLinkOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxSankey_GetOption", dxTarget, "link");
		}
		public static Task SetLinkOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxSankey_SetOption", dxTarget, "link", value);
		}
		public static Task<object> GetNodeOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxSankey_GetOption", dxTarget, "node");
		}
		public static Task SetNodeOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxSankey_SetOption", dxTarget, "node", value);
		}
		public static Task<object> GetPaletteOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxSankey_GetOption", dxTarget, "palette");
		}
		public static Task SetPaletteOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxSankey_SetOption", dxTarget, "palette", value);
		}
		public static Task<string> GetPaletteExtensionModeOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxSankey_GetOption", dxTarget, "paletteExtensionMode");
		}
		public static Task SetPaletteExtensionModeOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxSankey_SetOption", dxTarget, "paletteExtensionMode", value);
		}
		public static Task<object> GetSortDataOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxSankey_GetOption", dxTarget, "sortData");
		}
		public static Task SetSortDataOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxSankey_SetOption", dxTarget, "sortData", value);
		}
		public static Task<string> GetSourceFieldOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxSankey_GetOption", dxTarget, "sourceField");
		}
		public static Task SetSourceFieldOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxSankey_SetOption", dxTarget, "sourceField", value);
		}
		public static Task<string> GetTargetFieldOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxSankey_GetOption", dxTarget, "targetField");
		}
		public static Task SetTargetFieldOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxSankey_SetOption", dxTarget, "targetField", value);
		}
		public static Task<string> GetWeightFieldOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxSankey_GetOption", dxTarget, "weightField");
		}
		public static Task SetWeightFieldOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxSankey_SetOption", dxTarget, "weightField", value);
		}
		public static Task<object> GetAllLinks(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxSankey_getAllLinks_0", dxTarget);
		}
		public static Task<object> GetAllNodes(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxSankey_getAllNodes_1", dxTarget);
		}
		public static Task<object> GetDataSourceEx(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxSankey_getDataSource_2", dxTarget);
		}
		public static Task HideTooltip(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxSankey_hideTooltip_3", dxTarget);
		}
	}
	public class BaseSparklineInterop: BaseWidgetInterop
	{
		public static event EventHandler<JQueryEventArgs> TooltipHidden;
		public static event EventHandler<JQueryEventArgs> TooltipShown;
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
	}
	public class DxSparklineInterop: BaseSparklineInterop
	{
		public static Task Init(ElementRef dxTarget, DevExpress.Viz.DxSparklineOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxSparkline_Init", dxTarget, json);
		}
		public static Task<string> GetArgumentFieldOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxSparkline_GetOption", dxTarget, "argumentField");
		}
		public static Task SetArgumentFieldOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxSparkline_SetOption", dxTarget, "argumentField", value);
		}
		public static Task<string> GetBarNegativeColorOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxSparkline_GetOption", dxTarget, "barNegativeColor");
		}
		public static Task SetBarNegativeColorOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxSparkline_SetOption", dxTarget, "barNegativeColor", value);
		}
		public static Task<string> GetBarPositiveColorOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxSparkline_GetOption", dxTarget, "barPositiveColor");
		}
		public static Task SetBarPositiveColorOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxSparkline_SetOption", dxTarget, "barPositiveColor", value);
		}
		public static Task<object> GetDataSourceOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxSparkline_GetOption", dxTarget, "dataSource");
		}
		public static Task SetDataSourceOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxSparkline_SetOption", dxTarget, "dataSource", value);
		}
		public static Task<string> GetFirstLastColorOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxSparkline_GetOption", dxTarget, "firstLastColor");
		}
		public static Task SetFirstLastColorOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxSparkline_SetOption", dxTarget, "firstLastColor", value);
		}
		public static Task<bool?> GetIgnoreEmptyPointsOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxSparkline_GetOption", dxTarget, "ignoreEmptyPoints");
		}
		public static Task SetIgnoreEmptyPointsOption(ElementRef dxTarget, bool? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxSparkline_SetOption", dxTarget, "ignoreEmptyPoints", value);
		}
		public static Task<string> GetLineColorOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxSparkline_GetOption", dxTarget, "lineColor");
		}
		public static Task SetLineColorOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxSparkline_SetOption", dxTarget, "lineColor", value);
		}
		public static Task<float?> GetLineWidthOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_DxSparkline_GetOption", dxTarget, "lineWidth");
		}
		public static Task SetLineWidthOption(ElementRef dxTarget, float? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxSparkline_SetOption", dxTarget, "lineWidth", value);
		}
		public static Task<string> GetLossColorOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxSparkline_GetOption", dxTarget, "lossColor");
		}
		public static Task SetLossColorOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxSparkline_SetOption", dxTarget, "lossColor", value);
		}
		public static Task<string> GetMaxColorOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxSparkline_GetOption", dxTarget, "maxColor");
		}
		public static Task SetMaxColorOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxSparkline_SetOption", dxTarget, "maxColor", value);
		}
		public static Task<float?> GetMaxValueOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_DxSparkline_GetOption", dxTarget, "maxValue");
		}
		public static Task SetMaxValueOption(ElementRef dxTarget, float? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxSparkline_SetOption", dxTarget, "maxValue", value);
		}
		public static Task<string> GetMinColorOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxSparkline_GetOption", dxTarget, "minColor");
		}
		public static Task SetMinColorOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxSparkline_SetOption", dxTarget, "minColor", value);
		}
		public static Task<float?> GetMinValueOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_DxSparkline_GetOption", dxTarget, "minValue");
		}
		public static Task SetMinValueOption(ElementRef dxTarget, float? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxSparkline_SetOption", dxTarget, "minValue", value);
		}
		public static Task<string> GetPointColorOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxSparkline_GetOption", dxTarget, "pointColor");
		}
		public static Task SetPointColorOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxSparkline_SetOption", dxTarget, "pointColor", value);
		}
		public static Task<float?> GetPointSizeOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_DxSparkline_GetOption", dxTarget, "pointSize");
		}
		public static Task SetPointSizeOption(ElementRef dxTarget, float? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxSparkline_SetOption", dxTarget, "pointSize", value);
		}
		public static Task<string> GetPointSymbolOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxSparkline_GetOption", dxTarget, "pointSymbol");
		}
		public static Task SetPointSymbolOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxSparkline_SetOption", dxTarget, "pointSymbol", value);
		}
		public static Task<bool?> GetShowFirstLastOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxSparkline_GetOption", dxTarget, "showFirstLast");
		}
		public static Task SetShowFirstLastOption(ElementRef dxTarget, bool? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxSparkline_SetOption", dxTarget, "showFirstLast", value);
		}
		public static Task<bool?> GetShowMinMaxOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxSparkline_GetOption", dxTarget, "showMinMax");
		}
		public static Task SetShowMinMaxOption(ElementRef dxTarget, bool? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxSparkline_SetOption", dxTarget, "showMinMax", value);
		}
		public static Task<string> GetTypeOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxSparkline_GetOption", dxTarget, "type");
		}
		public static Task SetTypeOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxSparkline_SetOption", dxTarget, "type", value);
		}
		public static Task<string> GetValueFieldOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxSparkline_GetOption", dxTarget, "valueField");
		}
		public static Task SetValueFieldOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxSparkline_SetOption", dxTarget, "valueField", value);
		}
		public static Task<string> GetWinColorOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxSparkline_GetOption", dxTarget, "winColor");
		}
		public static Task SetWinColorOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxSparkline_SetOption", dxTarget, "winColor", value);
		}
		public static Task<float?> GetWinlossThresholdOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_DxSparkline_GetOption", dxTarget, "winlossThreshold");
		}
		public static Task SetWinlossThresholdOption(ElementRef dxTarget, float? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxSparkline_SetOption", dxTarget, "winlossThreshold", value);
		}
		public static Task<object> GetDataSourceEx(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxSparkline_getDataSource_0", dxTarget);
		}
	}
	public class DxBulletInterop: BaseSparklineInterop
	{
		public static Task Init(ElementRef dxTarget, DevExpress.Viz.DxBulletOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxBullet_Init", dxTarget, json);
		}
		public static Task<string> GetColorOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxBullet_GetOption", dxTarget, "color");
		}
		public static Task SetColorOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxBullet_SetOption", dxTarget, "color", value);
		}
		public static Task<float?> GetEndScaleValueOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_DxBullet_GetOption", dxTarget, "endScaleValue");
		}
		public static Task SetEndScaleValueOption(ElementRef dxTarget, float? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxBullet_SetOption", dxTarget, "endScaleValue", value);
		}
		public static Task<bool?> GetShowTargetOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxBullet_GetOption", dxTarget, "showTarget");
		}
		public static Task SetShowTargetOption(ElementRef dxTarget, bool? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxBullet_SetOption", dxTarget, "showTarget", value);
		}
		public static Task<bool?> GetShowZeroLevelOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxBullet_GetOption", dxTarget, "showZeroLevel");
		}
		public static Task SetShowZeroLevelOption(ElementRef dxTarget, bool? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxBullet_SetOption", dxTarget, "showZeroLevel", value);
		}
		public static Task<float?> GetStartScaleValueOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_DxBullet_GetOption", dxTarget, "startScaleValue");
		}
		public static Task SetStartScaleValueOption(ElementRef dxTarget, float? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxBullet_SetOption", dxTarget, "startScaleValue", value);
		}
		public static Task<float?> GetTargetOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_DxBullet_GetOption", dxTarget, "target");
		}
		public static Task SetTargetOption(ElementRef dxTarget, float? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxBullet_SetOption", dxTarget, "target", value);
		}
		public static Task<string> GetTargetColorOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxBullet_GetOption", dxTarget, "targetColor");
		}
		public static Task SetTargetColorOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxBullet_SetOption", dxTarget, "targetColor", value);
		}
		public static Task<float?> GetTargetWidthOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_DxBullet_GetOption", dxTarget, "targetWidth");
		}
		public static Task SetTargetWidthOption(ElementRef dxTarget, float? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxBullet_SetOption", dxTarget, "targetWidth", value);
		}
		public static Task<float?> GetValueOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_DxBullet_GetOption", dxTarget, "value");
		}
		public static Task SetValueOption(ElementRef dxTarget, float? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxBullet_SetOption", dxTarget, "value", value);
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
		public static Task Init(ElementRef dxTarget, DevExpress.Viz.DxTreeMapOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeMap_Init", dxTarget, json);
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
		public static Task<string> GetChildrenFieldOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxTreeMap_GetOption", dxTarget, "childrenField");
		}
		public static Task SetChildrenFieldOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeMap_SetOption", dxTarget, "childrenField", value);
		}
		public static Task<string> GetColorFieldOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxTreeMap_GetOption", dxTarget, "colorField");
		}
		public static Task SetColorFieldOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeMap_SetOption", dxTarget, "colorField", value);
		}
		public static Task<object> GetColorizerOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeMap_GetOption", dxTarget, "colorizer");
		}
		public static Task SetColorizerOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeMap_SetOption", dxTarget, "colorizer", value);
		}
		public static Task<object> GetDataSourceOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeMap_GetOption", dxTarget, "dataSource");
		}
		public static Task SetDataSourceOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeMap_SetOption", dxTarget, "dataSource", value);
		}
		public static Task<object> GetGroupOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeMap_GetOption", dxTarget, "group");
		}
		public static Task SetGroupOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeMap_SetOption", dxTarget, "group", value);
		}
		public static Task<bool?> GetHoverEnabledOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxTreeMap_GetOption", dxTarget, "hoverEnabled");
		}
		public static Task SetHoverEnabledOption(ElementRef dxTarget, bool? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeMap_SetOption", dxTarget, "hoverEnabled", value);
		}
		public static Task<string> GetIdFieldOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxTreeMap_GetOption", dxTarget, "idField");
		}
		public static Task SetIdFieldOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeMap_SetOption", dxTarget, "idField", value);
		}
		public static Task<bool?> GetInteractWithGroupOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxTreeMap_GetOption", dxTarget, "interactWithGroup");
		}
		public static Task SetInteractWithGroupOption(ElementRef dxTarget, bool? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeMap_SetOption", dxTarget, "interactWithGroup", value);
		}
		public static Task<string> GetLabelFieldOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxTreeMap_GetOption", dxTarget, "labelField");
		}
		public static Task SetLabelFieldOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeMap_SetOption", dxTarget, "labelField", value);
		}
		public static Task<object> GetLayoutAlgorithmOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeMap_GetOption", dxTarget, "layoutAlgorithm");
		}
		public static Task SetLayoutAlgorithmOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeMap_SetOption", dxTarget, "layoutAlgorithm", value);
		}
		public static Task<string> GetLayoutDirectionOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxTreeMap_GetOption", dxTarget, "layoutDirection");
		}
		public static Task SetLayoutDirectionOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeMap_SetOption", dxTarget, "layoutDirection", value);
		}
		public static Task<float?> GetMaxDepthOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_DxTreeMap_GetOption", dxTarget, "maxDepth");
		}
		public static Task SetMaxDepthOption(ElementRef dxTarget, float? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeMap_SetOption", dxTarget, "maxDepth", value);
		}
		public static Task<string> GetParentFieldOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxTreeMap_GetOption", dxTarget, "parentField");
		}
		public static Task SetParentFieldOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeMap_SetOption", dxTarget, "parentField", value);
		}
		public static Task<string> GetResolveLabelOverflowOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxTreeMap_GetOption", dxTarget, "resolveLabelOverflow");
		}
		public static Task SetResolveLabelOverflowOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeMap_SetOption", dxTarget, "resolveLabelOverflow", value);
		}
		public static Task<string> GetSelectionModeOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxTreeMap_GetOption", dxTarget, "selectionMode");
		}
		public static Task SetSelectionModeOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeMap_SetOption", dxTarget, "selectionMode", value);
		}
		public static Task<object> GetTileOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeMap_GetOption", dxTarget, "tile");
		}
		public static Task SetTileOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeMap_SetOption", dxTarget, "tile", value);
		}
		public static Task<string> GetValueFieldOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxTreeMap_GetOption", dxTarget, "valueField");
		}
		public static Task SetValueFieldOption(ElementRef dxTarget, string value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeMap_SetOption", dxTarget, "valueField", value);
		}
		public static Task ClearSelection(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeMap_clearSelection_0", dxTarget);
		}
		public static Task DrillUp(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeMap_drillUp_1", dxTarget);
		}
		public static Task<object> GetCurrentNode(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeMap_getCurrentNode_2", dxTarget);
		}
		public static Task<object> GetDataSourceEx(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeMap_getDataSource_3", dxTarget);
		}
		public static Task<object> GetRootNode(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeMap_getRootNode_4", dxTarget);
		}
		public static Task HideTooltip(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeMap_hideTooltip_5", dxTarget);
		}
		public static Task ResetDrillDown(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeMap_resetDrillDown_6", dxTarget);
		}
	}
	public class DxVectorMapInterop: BaseWidgetInterop
	{
		public static event EventHandler<JQueryEventArgs> CenterChanged;
		public static event EventHandler<JQueryEventArgs> Click;
		public static event EventHandler<JQueryEventArgs> SelectionChanged;
		public static event EventHandler<JQueryEventArgs> TooltipHidden;
		public static event EventHandler<JQueryEventArgs> TooltipShown;
		public static event EventHandler<JQueryEventArgs> ZoomFactorChanged;
		public static Task Init(ElementRef dxTarget, DevExpress.Viz.DxVectorMapOptions options)
		{
			string json = SimpleJson.SimpleJson.SerializeObject(options);
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxVectorMap_Init", dxTarget, json);
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
		public static Task<object> GetBackgroundOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxVectorMap_GetOption", dxTarget, "background");
		}
		public static Task SetBackgroundOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxVectorMap_SetOption", dxTarget, "background", value);
		}
		public static Task<object> GetBoundsOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxVectorMap_GetOption", dxTarget, "bounds");
		}
		public static Task SetBoundsOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxVectorMap_SetOption", dxTarget, "bounds", value);
		}
		public static Task<object> GetCenterOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxVectorMap_GetOption", dxTarget, "center");
		}
		public static Task SetCenterOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxVectorMap_SetOption", dxTarget, "center", value);
		}
		public static Task<object> GetControlBarOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxVectorMap_GetOption", dxTarget, "controlBar");
		}
		public static Task SetControlBarOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxVectorMap_SetOption", dxTarget, "controlBar", value);
		}
		public static Task<object> GetLayersOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxVectorMap_GetOption", dxTarget, "layers");
		}
		public static Task SetLayersOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxVectorMap_SetOption", dxTarget, "layers", value);
		}
		public static Task<object> GetLegendsOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxVectorMap_GetOption", dxTarget, "legends");
		}
		public static Task SetLegendsOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxVectorMap_SetOption", dxTarget, "legends", value);
		}
		public static Task<float?> GetMaxZoomFactorOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_DxVectorMap_GetOption", dxTarget, "maxZoomFactor");
		}
		public static Task SetMaxZoomFactorOption(ElementRef dxTarget, float? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxVectorMap_SetOption", dxTarget, "maxZoomFactor", value);
		}
		public static Task<bool?> GetPanningEnabledOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxVectorMap_GetOption", dxTarget, "panningEnabled");
		}
		public static Task SetPanningEnabledOption(ElementRef dxTarget, bool? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxVectorMap_SetOption", dxTarget, "panningEnabled", value);
		}
		public static Task<object> GetProjectionOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxVectorMap_GetOption", dxTarget, "projection");
		}
		public static Task SetProjectionOption(ElementRef dxTarget, object value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxVectorMap_SetOption", dxTarget, "projection", value);
		}
		public static Task<bool?> GetTouchEnabledOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxVectorMap_GetOption", dxTarget, "touchEnabled");
		}
		public static Task SetTouchEnabledOption(ElementRef dxTarget, bool? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxVectorMap_SetOption", dxTarget, "touchEnabled", value);
		}
		public static Task<bool?> GetWheelEnabledOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxVectorMap_GetOption", dxTarget, "wheelEnabled");
		}
		public static Task SetWheelEnabledOption(ElementRef dxTarget, bool? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxVectorMap_SetOption", dxTarget, "wheelEnabled", value);
		}
		public static Task<float?> GetZoomFactorOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_DxVectorMap_GetOption", dxTarget, "zoomFactor");
		}
		public static Task SetZoomFactorOption(ElementRef dxTarget, float? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxVectorMap_SetOption", dxTarget, "zoomFactor", value);
		}
		public static Task<bool?> GetZoomingEnabledOption(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxVectorMap_GetOption", dxTarget, "zoomingEnabled");
		}
		public static Task SetZoomingEnabledOption(ElementRef dxTarget, bool? value)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxVectorMap_SetOption", dxTarget, "zoomingEnabled", value);
		}
		public static Task<object> CenterEx(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxVectorMap_center_0", dxTarget);
		}
		public static Task CenterEx(ElementRef dxTarget, object centerCoordinates)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxVectorMap_center_1", dxTarget, centerCoordinates);
		}
		public static Task ClearSelection(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxVectorMap_clearSelection_2", dxTarget);
		}
		public static Task<object> ConvertCoordinates(ElementRef dxTarget, float x, float y)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxVectorMap_convertCoordinates_3", dxTarget, x, y);
		}
		public static Task<object> GetLayerByIndex(ElementRef dxTarget, float index)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxVectorMap_getLayerByIndex_4", dxTarget, index);
		}
		public static Task<object> GetLayerByName(ElementRef dxTarget, string name)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxVectorMap_getLayerByName_5", dxTarget, name);
		}
		public static Task<object> GetLayersEx(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxVectorMap_getLayers_6", dxTarget);
		}
		public static Task<object> Viewport(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxVectorMap_viewport_7", dxTarget);
		}
		public static Task Viewport(ElementRef dxTarget, object viewportCoordinates)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxVectorMap_viewport_8", dxTarget, viewportCoordinates);
		}
		public static Task<float> ZoomFactorEx(ElementRef dxTarget)
		{
			return JSRuntime.Current.InvokeAsync<float>("BlazorDevExtreme_DxVectorMap_zoomFactor_9", dxTarget);
		}
		public static Task ZoomFactorEx(ElementRef dxTarget, float zoomFactor)
		{
			return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxVectorMap_zoomFactor_10", dxTarget, zoomFactor);
		}
	}
}
