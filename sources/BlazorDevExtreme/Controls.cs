using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using BlazorDevExtreme;
using Microsoft.JSInterop;
using JSRuntime = BlazorDevExtreme.JSRuntime;

namespace DevExpress
{
    public class DataHelperMixinInterop
    {
        public static Task<object> GetDataSourceEx(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DataHelperMixin_getDataSource_0", dxTarget);
        }
    }

    public class DxEventInterop
    {
        public static Task<bool> IsDefaultPrevented(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool>("BlazorDevExtreme_DxEvent_isDefaultPrevented_0", dxTarget);
        }
        public static Task<bool> IsImmediatePropagationStopped(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool>("BlazorDevExtreme_DxEvent_isImmediatePropagationStopped_1", dxTarget);
        }
        public static Task<bool> IsPropagationStopped(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool>("BlazorDevExtreme_DxEvent_isPropagationStopped_2", dxTarget);
        }
        public static Task PreventDefault(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxEvent_preventDefault_3", dxTarget);
        }
        public static Task StopImmediatePropagation(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxEvent_stopImmediatePropagation_4", dxTarget);
        }
        public static Task StopPropagation(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxEvent_stopPropagation_5", dxTarget);
        }
    }
    public class LocalizationInterop
    {
        public static Task LoadMessages(object messages)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Localization_loadMessages_0", messages);
        }
        public static Task<string> Locale()
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_Localization_locale_1");
        }
        public static Task Locale(string locale)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Localization_locale_2", locale);
        }
    }
    public class AnimationPresetsInterop
    {
        public static Task ApplyChanges(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_AnimationPresets_applyChanges_0", dxTarget);
        }
        public static Task Clear(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_AnimationPresets_clear_1", dxTarget);
        }
        public static Task Clear(ElementReference dxTarget, string name)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_AnimationPresets_clear_2", dxTarget, name);
        }
        public static Task<object> GetPreset(ElementReference dxTarget, string name)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_AnimationPresets_getPreset_3", dxTarget, name);
        }
        public static Task RegisterDefaultPresets(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_AnimationPresets_registerDefaultPresets_4", dxTarget);
        }
        public static Task RegisterPreset(ElementReference dxTarget, string name, object config)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_AnimationPresets_registerPreset_5", dxTarget, name, config);
        }
        public static Task ResetToDefaults(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_AnimationPresets_resetToDefaults_6", dxTarget);
        }
    }
    public class TransitionExecutorInterop
    {
        public static Task Enter(ElementReference dxTarget, object elements, object animation)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_TransitionExecutor_enter_0", dxTarget, elements, animation);
        }
        public static Task Leave(ElementReference dxTarget, object elements, object animation)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_TransitionExecutor_leave_1", dxTarget, elements, animation);
        }
        public static Task Reset(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_TransitionExecutor_reset_2", dxTarget);
        }
        public static Task<object> Start(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_TransitionExecutor_start_3", dxTarget);
        }
        public static Task Stop(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_TransitionExecutor_stop_4", dxTarget);
        }
    }
    public class ComponentInterop
    {
        public static event EventHandler<JQueryEventArgs> Disposing;
        public static event EventHandler<JQueryEventArgs> Initialized;
        public static event EventHandler<JQueryEventArgs> OptionChanged;
        public static Task Init(ElementReference dxTarget, DevExpress.ComponentOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Component_Init", dxTarget, json);
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
        public static Task BeginUpdate(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Component_beginUpdate_0", dxTarget);
        }
        public static Task EndUpdate(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Component_endUpdate_1", dxTarget);
        }
        public static Task<object> Instance(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Component_instance_2", dxTarget);
        }
        public static Task<object> Off(ElementReference dxTarget, string eventName)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Component_off_3", dxTarget, eventName);
        }
        public static Task<object> Off(ElementReference dxTarget, string eventName, object eventHandler)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Component_off_4", dxTarget, eventName, eventHandler);
        }
        public static Task<object> On(ElementReference dxTarget, string eventName, object eventHandler)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Component_on_5", dxTarget, eventName, eventHandler);
        }
        public static Task<object> On(ElementReference dxTarget, object events)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Component_on_6", dxTarget, events);
        }
        public static Task<object> Option(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Component_option_7", dxTarget);
        }
        public static Task<object> Option(ElementReference dxTarget, string optionName)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Component_option_8", dxTarget, optionName);
        }
        public static Task Option(ElementReference dxTarget, string optionName, object optionValue)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Component_option_9", dxTarget, optionName, optionValue);
        }
        public static Task Option(ElementReference dxTarget, object options)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Component_option_10", dxTarget, options);
        }
    }
    public class DevicesObjectInterop
    {
        public static Task<object> Current(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DevicesObject_current_0", dxTarget);
        }
        public static Task Current(ElementReference dxTarget, object deviceName)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DevicesObject_current_1", dxTarget, deviceName);
        }
        public static Task<object> Off(ElementReference dxTarget, string eventName)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DevicesObject_off_2", dxTarget, eventName);
        }
        public static Task<object> Off(ElementReference dxTarget, string eventName, object eventHandler)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DevicesObject_off_3", dxTarget, eventName, eventHandler);
        }
        public static Task<object> On(ElementReference dxTarget, string eventName, object eventHandler)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DevicesObject_on_4", dxTarget, eventName, eventHandler);
        }
        public static Task<object> On(ElementReference dxTarget, object events)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DevicesObject_on_5", dxTarget, events);
        }
        public static Task<string> Orientation(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DevicesObject_orientation_6", dxTarget);
        }
        public static Task<object> Real(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DevicesObject_real_7", dxTarget);
        }
    }
    public class DOMComponentInterop: ComponentInterop
    {
        public static Task Init(ElementReference dxTarget, DevExpress.DOMComponentOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DOMComponent_Init", dxTarget, json);
        }
        public static Task<object> GetBindingOptions(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DOMComponent_GetOption", dxTarget, "bindingOptions");
        }
        public static Task SetBindingOptions(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DOMComponent_SetOption", dxTarget, "bindingOptions", value);
        }
        public static Task<object> GetElementAttr(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DOMComponent_GetOption", dxTarget, "elementAttr");
        }
        public static Task SetElementAttr(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DOMComponent_SetOption", dxTarget, "elementAttr", value);
        }
        public static Task<object> GetHeight(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DOMComponent_GetOption", dxTarget, "height");
        }
        public static Task SetHeight(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DOMComponent_SetOption", dxTarget, "height", value);
        }
        public static Task<bool?> GetRtlEnabled(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DOMComponent_GetOption", dxTarget, "rtlEnabled");
        }
        public static Task SetRtlEnabled(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DOMComponent_SetOption", dxTarget, "rtlEnabled", value);
        }
        public static Task<object> GetWidth(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DOMComponent_GetOption", dxTarget, "width");
        }
        public static Task SetWidth(ElementReference dxTarget, object value)
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
        public static Task Dispose(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DOMComponent_dispose_0", dxTarget);
        }
        public static Task<object> Element(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DOMComponent_element_1", dxTarget);
        }
    }
    public class EndpointSelectorInterop
    {
        public static Task<string> UrlFor(ElementReference dxTarget, string key)
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
        public static Task<string> ToString(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_Guid_toString_0", dxTarget);
        }
        public static Task<string> ValueOf(ElementReference dxTarget)
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
        public static event EventHandler<JQueryEventArgs> Removed;
        public static event EventHandler<JQueryEventArgs> Removing;
        public static event EventHandler<JQueryEventArgs> Updated;
        public static event EventHandler<JQueryEventArgs> Updating;
        public static Task Init(ElementReference dxTarget, DevExpress.Data.StoreOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Store_Init", dxTarget, json);
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
        public static Task<object> GetErrorHandler(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Store_GetOption", dxTarget, "errorHandler");
        }
        public static Task SetErrorHandler(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Store_SetOption", dxTarget, "errorHandler", value);
        }
        public static Task<object> GetKey(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Store_GetOption", dxTarget, "key");
        }
        public static Task SetKey(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Store_SetOption", dxTarget, "key", value);
        }
        public static Task<object> ByKey(ElementReference dxTarget, object key)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Store_byKey_0", dxTarget, key);
        }
        public static Task<object> Insert(ElementReference dxTarget, object values)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Store_insert_1", dxTarget, values);
        }
        public static Task<object> Key(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Store_key_2", dxTarget);
        }
        public static Task<object> KeyOf(ElementReference dxTarget, object obj)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Store_keyOf_3", dxTarget, obj);
        }
        public static Task<object> Load(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Store_load_4", dxTarget);
        }
        public static Task<object> Load(ElementReference dxTarget, object options)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Store_load_5", dxTarget, options);
        }
        public static Task<object> Off(ElementReference dxTarget, string eventName)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Store_off_6", dxTarget, eventName);
        }
        public static Task<object> Off(ElementReference dxTarget, string eventName, object eventHandler)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Store_off_7", dxTarget, eventName, eventHandler);
        }
        public static Task<object> On(ElementReference dxTarget, string eventName, object eventHandler)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Store_on_8", dxTarget, eventName, eventHandler);
        }
        public static Task<object> On(ElementReference dxTarget, object events)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Store_on_9", dxTarget, events);
        }
        public static Task<object> Remove(ElementReference dxTarget, object key)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Store_remove_10", dxTarget, key);
        }
        public static Task<object> TotalCount(ElementReference dxTarget, object obj)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Store_totalCount_11", dxTarget, obj);
        }
        public static Task<object> Update(ElementReference dxTarget, object key, object values)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Store_update_12", dxTarget, key, values);
        }
    }
    public class ArrayStoreInterop: StoreInterop
    {
        public static Task Init(ElementReference dxTarget, DevExpress.Data.ArrayStoreOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_ArrayStore_Init", dxTarget, json);
        }
        public static Task<object> GetData(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_ArrayStore_GetOption", dxTarget, "data");
        }
        public static Task SetData(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_ArrayStore_SetOption", dxTarget, "data", value);
        }
        public static Task Clear(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_ArrayStore_clear_0", dxTarget);
        }
        public static Task<object> CreateQuery(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_ArrayStore_createQuery_1", dxTarget);
        }
    }
    public class CustomStoreInterop: StoreInterop
    {
        public static Task Init(ElementReference dxTarget, DevExpress.Data.CustomStoreOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_CustomStore_Init", dxTarget, json);
        }
        public static Task<object> GetByKey(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_CustomStore_GetOption", dxTarget, "byKey");
        }
        public static Task SetByKey(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_CustomStore_SetOption", dxTarget, "byKey", value);
        }
        public static Task<bool?> GetCacheRawData(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_CustomStore_GetOption", dxTarget, "cacheRawData");
        }
        public static Task SetCacheRawData(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_CustomStore_SetOption", dxTarget, "cacheRawData", value);
        }
        public static Task<object> GetInsert(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_CustomStore_GetOption", dxTarget, "insert");
        }
        public static Task SetInsert(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_CustomStore_SetOption", dxTarget, "insert", value);
        }
        public static Task<object> GetLoad(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_CustomStore_GetOption", dxTarget, "load");
        }
        public static Task SetLoad(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_CustomStore_SetOption", dxTarget, "load", value);
        }
        public static Task<string> GetLoadMode(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_CustomStore_GetOption", dxTarget, "loadMode");
        }
        public static Task SetLoadMode(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_CustomStore_SetOption", dxTarget, "loadMode", value);
        }
        public static Task<object> GetRemove(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_CustomStore_GetOption", dxTarget, "remove");
        }
        public static Task SetRemove(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_CustomStore_SetOption", dxTarget, "remove", value);
        }
        public static Task<object> GetTotalCount(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_CustomStore_GetOption", dxTarget, "totalCount");
        }
        public static Task SetTotalCount(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_CustomStore_SetOption", dxTarget, "totalCount", value);
        }
        public static Task<object> GetUpdate(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_CustomStore_GetOption", dxTarget, "update");
        }
        public static Task SetUpdate(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_CustomStore_SetOption", dxTarget, "update", value);
        }
        public static Task<bool?> GetUseDefaultSearch(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_CustomStore_GetOption", dxTarget, "useDefaultSearch");
        }
        public static Task SetUseDefaultSearch(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_CustomStore_SetOption", dxTarget, "useDefaultSearch", value);
        }
        public static Task ClearRawDataCache(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_CustomStore_clearRawDataCache_0", dxTarget);
        }
    }
    public class DataSourceInterop
    {
        public static event EventHandler<JQueryEventArgs> Changed;
        public static event EventHandler<JQueryEventArgs> LoadError;
        public static event EventHandler<JQueryEventArgs> LoadingChanged;
        public static Task Init(ElementReference dxTarget, DevExpress.Data.DataSourceOptions options)
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
        public static Task<object> GetCustomQueryParams(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DataSource_GetOption", dxTarget, "customQueryParams");
        }
        public static Task SetCustomQueryParams(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DataSource_SetOption", dxTarget, "customQueryParams", value);
        }
        public static Task<object> GetExpand(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DataSource_GetOption", dxTarget, "expand");
        }
        public static Task SetExpand(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DataSource_SetOption", dxTarget, "expand", value);
        }
        public static Task<object> GetFilter(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DataSource_GetOption", dxTarget, "filter");
        }
        public static Task SetFilter(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DataSource_SetOption", dxTarget, "filter", value);
        }
        public static Task<object> GetGroup(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DataSource_GetOption", dxTarget, "group");
        }
        public static Task SetGroup(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DataSource_SetOption", dxTarget, "group", value);
        }
        public static Task<object> GetMap(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DataSource_GetOption", dxTarget, "map");
        }
        public static Task SetMap(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DataSource_SetOption", dxTarget, "map", value);
        }
        public static Task<float?> GetPageSize(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_DataSource_GetOption", dxTarget, "pageSize");
        }
        public static Task SetPageSize(ElementReference dxTarget, float? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DataSource_SetOption", dxTarget, "pageSize", value);
        }
        public static Task<bool?> GetPaginate(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DataSource_GetOption", dxTarget, "paginate");
        }
        public static Task SetPaginate(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DataSource_SetOption", dxTarget, "paginate", value);
        }
        public static Task<object> GetPostProcess(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DataSource_GetOption", dxTarget, "postProcess");
        }
        public static Task SetPostProcess(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DataSource_SetOption", dxTarget, "postProcess", value);
        }
        public static Task<bool?> GetRequireTotalCount(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DataSource_GetOption", dxTarget, "requireTotalCount");
        }
        public static Task SetRequireTotalCount(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DataSource_SetOption", dxTarget, "requireTotalCount", value);
        }
        public static Task<object> GetSearchExpr(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DataSource_GetOption", dxTarget, "searchExpr");
        }
        public static Task SetSearchExpr(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DataSource_SetOption", dxTarget, "searchExpr", value);
        }
        public static Task<string> GetSearchOperation(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DataSource_GetOption", dxTarget, "searchOperation");
        }
        public static Task SetSearchOperation(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DataSource_SetOption", dxTarget, "searchOperation", value);
        }
        public static Task<object> GetSearchValue(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DataSource_GetOption", dxTarget, "searchValue");
        }
        public static Task SetSearchValue(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DataSource_SetOption", dxTarget, "searchValue", value);
        }
        public static Task<object> GetSelect(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DataSource_GetOption", dxTarget, "select");
        }
        public static Task SetSelect(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DataSource_SetOption", dxTarget, "select", value);
        }
        public static Task<object> GetSort(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DataSource_GetOption", dxTarget, "sort");
        }
        public static Task SetSort(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DataSource_SetOption", dxTarget, "sort", value);
        }
        public static Task<object> GetStore(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DataSource_GetOption", dxTarget, "store");
        }
        public static Task SetStore(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DataSource_SetOption", dxTarget, "store", value);
        }
        public static Task<bool> Cancel(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool>("BlazorDevExtreme_DataSource_cancel_0", dxTarget);
        }
        public static Task Dispose(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DataSource_dispose_1", dxTarget);
        }
        public static Task<object> Filter(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DataSource_filter_2", dxTarget);
        }
        public static Task Filter(ElementReference dxTarget, object filterExpr)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DataSource_filter_3", dxTarget, filterExpr);
        }
        public static Task<object> Group(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DataSource_group_4", dxTarget);
        }
        public static Task Group(ElementReference dxTarget, object groupExpr)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DataSource_group_5", dxTarget, groupExpr);
        }
        public static Task<bool> IsLastPage(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool>("BlazorDevExtreme_DataSource_isLastPage_6", dxTarget);
        }
        public static Task<bool> IsLoaded(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool>("BlazorDevExtreme_DataSource_isLoaded_7", dxTarget);
        }
        public static Task<bool> IsLoading(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool>("BlazorDevExtreme_DataSource_isLoading_8", dxTarget);
        }
        public static Task<object> Items(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DataSource_items_9", dxTarget);
        }
        public static Task<object> Key(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DataSource_key_10", dxTarget);
        }
        public static Task<object> Load(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DataSource_load_11", dxTarget);
        }
        public static Task<object> LoadOptions(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DataSource_loadOptions_12", dxTarget);
        }
        public static Task<object> Off(ElementReference dxTarget, string eventName)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DataSource_off_13", dxTarget, eventName);
        }
        public static Task<object> Off(ElementReference dxTarget, string eventName, object eventHandler)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DataSource_off_14", dxTarget, eventName, eventHandler);
        }
        public static Task<object> On(ElementReference dxTarget, string eventName, object eventHandler)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DataSource_on_15", dxTarget, eventName, eventHandler);
        }
        public static Task<object> On(ElementReference dxTarget, object events)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DataSource_on_16", dxTarget, events);
        }
        public static Task<float> PageIndex(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<float>("BlazorDevExtreme_DataSource_pageIndex_17", dxTarget);
        }
        public static Task PageIndex(ElementReference dxTarget, float newIndex)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DataSource_pageIndex_18", dxTarget, newIndex);
        }
        public static Task<float> PageSize(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<float>("BlazorDevExtreme_DataSource_pageSize_19", dxTarget);
        }
        public static Task PageSize(ElementReference dxTarget, float value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DataSource_pageSize_20", dxTarget, value);
        }
        public static Task<bool> Paginate(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool>("BlazorDevExtreme_DataSource_paginate_21", dxTarget);
        }
        public static Task Paginate(ElementReference dxTarget, bool value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DataSource_paginate_22", dxTarget, value);
        }
        public static Task<object> Reload(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DataSource_reload_23", dxTarget);
        }
        public static Task<bool> RequireTotalCount(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool>("BlazorDevExtreme_DataSource_requireTotalCount_24", dxTarget);
        }
        public static Task RequireTotalCount(ElementReference dxTarget, bool value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DataSource_requireTotalCount_25", dxTarget, value);
        }
        public static Task<object> SearchExpr(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DataSource_searchExpr_26", dxTarget);
        }
        public static Task SearchExpr(ElementReference dxTarget, object expr)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DataSource_searchExpr_27", dxTarget, expr);
        }
        public static Task<string> SearchOperation(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DataSource_searchOperation_28", dxTarget);
        }
        public static Task SearchOperation(ElementReference dxTarget, string op)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DataSource_searchOperation_29", dxTarget, op);
        }
        public static Task<object> SearchValue(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DataSource_searchValue_30", dxTarget);
        }
        public static Task SearchValue(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DataSource_searchValue_31", dxTarget, value);
        }
        public static Task<object> Select(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DataSource_select_32", dxTarget);
        }
        public static Task Select(ElementReference dxTarget, object expr)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DataSource_select_33", dxTarget, expr);
        }
        public static Task<object> Sort(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DataSource_sort_34", dxTarget);
        }
        public static Task Sort(ElementReference dxTarget, object sortExpr)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DataSource_sort_35", dxTarget, sortExpr);
        }
        public static Task<object> Store(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DataSource_store_36", dxTarget);
        }
        public static Task<float> TotalCount(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<float>("BlazorDevExtreme_DataSource_totalCount_37", dxTarget);
        }
    }
    public class LocalStoreInterop: ArrayStoreInterop
    {
        public static Task Init(ElementReference dxTarget, DevExpress.Data.LocalStoreOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_LocalStore_Init", dxTarget, json);
        }
        public static Task<float?> GetFlushInterval(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_LocalStore_GetOption", dxTarget, "flushInterval");
        }
        public static Task SetFlushInterval(ElementReference dxTarget, float? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_LocalStore_SetOption", dxTarget, "flushInterval", value);
        }
        public static Task<bool?> GetImmediate(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_LocalStore_GetOption", dxTarget, "immediate");
        }
        public static Task SetImmediate(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_LocalStore_SetOption", dxTarget, "immediate", value);
        }
        public static Task<string> GetName(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_LocalStore_GetOption", dxTarget, "name");
        }
        public static Task SetName(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_LocalStore_SetOption", dxTarget, "name", value);
        }
        public static Task Clear(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_LocalStore_clear_0", dxTarget);
        }
    }
    public class QueryInterop
    {
        public static Task<object> Aggregate(ElementReference dxTarget, object seed, object step, object finalize)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Query_aggregate_0", dxTarget, seed, step, finalize);
        }
        public static Task<object> Aggregate(ElementReference dxTarget, object step)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Query_aggregate_1", dxTarget, step);
        }
        public static Task<object> Avg(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Query_avg_2", dxTarget);
        }
        public static Task<object> Avg(ElementReference dxTarget, object getter)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Query_avg_3", dxTarget, getter);
        }
        public static Task<object> Count(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Query_count_4", dxTarget);
        }
        public static Task<object> Enumerate(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Query_enumerate_5", dxTarget);
        }
        public static Task<object> Filter(ElementReference dxTarget, object criteria)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Query_filter_6", dxTarget, criteria);
        }
        public static Task<object> GroupBy(ElementReference dxTarget, object getter)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Query_groupBy_8", dxTarget, getter);
        }
        public static Task<object> Max(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Query_max_9", dxTarget);
        }
        public static Task<object> Max(ElementReference dxTarget, object getter)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Query_max_10", dxTarget, getter);
        }
        public static Task<object> Min(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Query_min_11", dxTarget);
        }
        public static Task<object> Min(ElementReference dxTarget, object getter)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Query_min_12", dxTarget, getter);
        }
        public static Task<object> Select(ElementReference dxTarget, object getter)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Query_select_13", dxTarget, getter);
        }
        public static Task<object> Slice(ElementReference dxTarget, float skip, float take)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Query_slice_14", dxTarget, skip, take);
        }
        public static Task<object> SortBy(ElementReference dxTarget, object getter)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Query_sortBy_15", dxTarget, getter);
        }
        public static Task<object> SortBy(ElementReference dxTarget, object getter, bool desc)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Query_sortBy_16", dxTarget, getter, desc);
        }
        public static Task<object> Sum(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Query_sum_17", dxTarget);
        }
        public static Task<object> Sum(ElementReference dxTarget, object getter)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Query_sum_18", dxTarget, getter);
        }
        public static Task<object> ThenBy(ElementReference dxTarget, object getter)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Query_thenBy_19", dxTarget, getter);
        }
        public static Task<object> ThenBy(ElementReference dxTarget, object getter, bool desc)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Query_thenBy_20", dxTarget, getter, desc);
        }
        public static Task<object> ToArray(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Query_toArray_21", dxTarget);
        }
    }
    public class ODataContextInterop
    {
        public static Task Init(ElementReference dxTarget, DevExpress.Data.ODataContextOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_ODataContext_Init", dxTarget, json);
        }
        public static Task<object> GetBeforeSend(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_ODataContext_GetOption", dxTarget, "beforeSend");
        }
        public static Task SetBeforeSend(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_ODataContext_SetOption", dxTarget, "beforeSend", value);
        }
        public static Task<bool?> GetDeserializeDates(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_ODataContext_GetOption", dxTarget, "deserializeDates");
        }
        public static Task SetDeserializeDates(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_ODataContext_SetOption", dxTarget, "deserializeDates", value);
        }
        public static Task<object> GetEntities(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_ODataContext_GetOption", dxTarget, "entities");
        }
        public static Task SetEntities(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_ODataContext_SetOption", dxTarget, "entities", value);
        }
        public static Task<object> GetErrorHandler(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_ODataContext_GetOption", dxTarget, "errorHandler");
        }
        public static Task SetErrorHandler(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_ODataContext_SetOption", dxTarget, "errorHandler", value);
        }
        public static Task<bool?> GetJsonp(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_ODataContext_GetOption", dxTarget, "jsonp");
        }
        public static Task SetJsonp(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_ODataContext_SetOption", dxTarget, "jsonp", value);
        }
        public static Task<string> GetUrl(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_ODataContext_GetOption", dxTarget, "url");
        }
        public static Task SetUrl(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_ODataContext_SetOption", dxTarget, "url", value);
        }
        public static Task<float?> GetVersion(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_ODataContext_GetOption", dxTarget, "version");
        }
        public static Task SetVersion(ElementReference dxTarget, float? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_ODataContext_SetOption", dxTarget, "version", value);
        }
        public static Task<bool?> GetWithCredentials(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_ODataContext_GetOption", dxTarget, "withCredentials");
        }
        public static Task SetWithCredentials(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_ODataContext_SetOption", dxTarget, "withCredentials", value);
        }
        public static Task<object> Get(ElementReference dxTarget, string operationName, object @params)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_ODataContext_get_0", dxTarget, operationName, @params);
        }
        public static Task<object> Invoke(ElementReference dxTarget, string operationName, object @params, object httpMethod)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_ODataContext_invoke_1", dxTarget, operationName, @params, httpMethod);
        }
        public static Task<object> ObjectLink(ElementReference dxTarget, string entityAlias, object key)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_ODataContext_objectLink_2", dxTarget, entityAlias, key);
        }
    }
    public class ODataStoreInterop: StoreInterop
    {
        public static Task Init(ElementReference dxTarget, DevExpress.Data.ODataStoreOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_ODataStore_Init", dxTarget, json);
        }
        public static Task<object> GetBeforeSend(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_ODataStore_GetOption", dxTarget, "beforeSend");
        }
        public static Task SetBeforeSend(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_ODataStore_SetOption", dxTarget, "beforeSend", value);
        }
        public static Task<bool?> GetDeserializeDates(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_ODataStore_GetOption", dxTarget, "deserializeDates");
        }
        public static Task SetDeserializeDates(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_ODataStore_SetOption", dxTarget, "deserializeDates", value);
        }
        public static Task<object> GetFieldTypes(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_ODataStore_GetOption", dxTarget, "fieldTypes");
        }
        public static Task SetFieldTypes(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_ODataStore_SetOption", dxTarget, "fieldTypes", value);
        }
        public static Task<bool?> GetJsonp(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_ODataStore_GetOption", dxTarget, "jsonp");
        }
        public static Task SetJsonp(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_ODataStore_SetOption", dxTarget, "jsonp", value);
        }
        public static Task<object> GetKeyType(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_ODataStore_GetOption", dxTarget, "keyType");
        }
        public static Task SetKeyType(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_ODataStore_SetOption", dxTarget, "keyType", value);
        }
        public static Task<string> GetUrl(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_ODataStore_GetOption", dxTarget, "url");
        }
        public static Task SetUrl(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_ODataStore_SetOption", dxTarget, "url", value);
        }
        public static Task<float?> GetVersion(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_ODataStore_GetOption", dxTarget, "version");
        }
        public static Task SetVersion(ElementReference dxTarget, float? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_ODataStore_SetOption", dxTarget, "version", value);
        }
        public static Task<bool?> GetWithCredentials(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_ODataStore_GetOption", dxTarget, "withCredentials");
        }
        public static Task SetWithCredentials(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_ODataStore_SetOption", dxTarget, "withCredentials", value);
        }
        public static Task<object> ByKey(ElementReference dxTarget, object key)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_ODataStore_byKey_0", dxTarget, key);
        }
        public static Task<object> ByKey(ElementReference dxTarget, object key, object extraOptions)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_ODataStore_byKey_1", dxTarget, key, extraOptions);
        }
        public static Task<object> CreateQuery(ElementReference dxTarget, object loadOptions)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_ODataStore_createQuery_2", dxTarget, loadOptions);
        }
        public static Task<object> Load(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_ODataStore_load_3", dxTarget);
        }
        public static Task<object> Load(ElementReference dxTarget, object options)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_ODataStore_load_4", dxTarget, options);
        }
    }
    public class EdmLiteralInterop
    {
        public static Task<string> ValueOf(ElementReference dxTarget)
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
        public static Task Init(ElementReference dxTarget, DevExpress.Data.PivotGridDataSourceOptions options)
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
        public static Task<object> GetFields(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_PivotGridDataSource_GetOption", dxTarget, "fields");
        }
        public static Task SetFields(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_PivotGridDataSource_SetOption", dxTarget, "fields", value);
        }
        public static Task<object> GetFilter(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_PivotGridDataSource_GetOption", dxTarget, "filter");
        }
        public static Task SetFilter(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_PivotGridDataSource_SetOption", dxTarget, "filter", value);
        }
        public static Task<bool?> GetRemoteOperations(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_PivotGridDataSource_GetOption", dxTarget, "remoteOperations");
        }
        public static Task SetRemoteOperations(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_PivotGridDataSource_SetOption", dxTarget, "remoteOperations", value);
        }
        public static Task<bool?> GetRetrieveFields(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_PivotGridDataSource_GetOption", dxTarget, "retrieveFields");
        }
        public static Task SetRetrieveFields(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_PivotGridDataSource_SetOption", dxTarget, "retrieveFields", value);
        }
        public static Task<object> GetStore(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_PivotGridDataSource_GetOption", dxTarget, "store");
        }
        public static Task SetStore(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_PivotGridDataSource_SetOption", dxTarget, "store", value);
        }
        public static Task CollapseAll(ElementReference dxTarget, object id)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_PivotGridDataSource_collapseAll_0", dxTarget, id);
        }
        public static Task CollapseHeaderItem(ElementReference dxTarget, string area, object path)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_PivotGridDataSource_collapseHeaderItem_1", dxTarget, area, path);
        }
        public static Task<object> CreateDrillDownDataSource(ElementReference dxTarget, object options)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_PivotGridDataSource_createDrillDownDataSource_2", dxTarget, options);
        }
        public static Task Dispose(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_PivotGridDataSource_dispose_3", dxTarget);
        }
        public static Task ExpandAll(ElementReference dxTarget, object id)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_PivotGridDataSource_expandAll_4", dxTarget, id);
        }
        public static Task ExpandHeaderItem(ElementReference dxTarget, string area, object path)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_PivotGridDataSource_expandHeaderItem_5", dxTarget, area, path);
        }
        public static Task<object> Field(ElementReference dxTarget, object id)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_PivotGridDataSource_field_6", dxTarget, id);
        }
        public static Task Field(ElementReference dxTarget, object id, object options)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_PivotGridDataSource_field_7", dxTarget, id, options);
        }
        public static Task<object> Fields(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_PivotGridDataSource_fields_8", dxTarget);
        }
        public static Task Fields(ElementReference dxTarget, object fields)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_PivotGridDataSource_fields_9", dxTarget, fields);
        }
        public static Task<object> Filter(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_PivotGridDataSource_filter_10", dxTarget);
        }
        public static Task Filter(ElementReference dxTarget, object filterExpr)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_PivotGridDataSource_filter_11", dxTarget, filterExpr);
        }
        public static Task<object> GetAreaFields(ElementReference dxTarget, string area, bool collectGroups)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_PivotGridDataSource_getAreaFields_12", dxTarget, area, collectGroups);
        }
        public static Task<object> GetData(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_PivotGridDataSource_getData_13", dxTarget);
        }
        public static Task<bool> IsLoading(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool>("BlazorDevExtreme_PivotGridDataSource_isLoading_14", dxTarget);
        }
        public static Task<object> Load(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_PivotGridDataSource_load_15", dxTarget);
        }
        public static Task<object> Off(ElementReference dxTarget, string eventName)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_PivotGridDataSource_off_16", dxTarget, eventName);
        }
        public static Task<object> Off(ElementReference dxTarget, string eventName, object eventHandler)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_PivotGridDataSource_off_17", dxTarget, eventName, eventHandler);
        }
        public static Task<object> On(ElementReference dxTarget, string eventName, object eventHandler)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_PivotGridDataSource_on_18", dxTarget, eventName, eventHandler);
        }
        public static Task<object> On(ElementReference dxTarget, object events)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_PivotGridDataSource_on_19", dxTarget, events);
        }
        public static Task<object> Reload(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_PivotGridDataSource_reload_20", dxTarget);
        }
        public static Task<object> State(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_PivotGridDataSource_state_21", dxTarget);
        }
        public static Task State(ElementReference dxTarget, object state)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_PivotGridDataSource_state_22", dxTarget, state);
        }
    }
    public class XmlaStoreInterop
    {
        public static Task Init(ElementReference dxTarget, DevExpress.Data.XmlaStoreOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_XmlaStore_Init", dxTarget, json);
        }
        public static Task<object> GetBeforeSend(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_XmlaStore_GetOption", dxTarget, "beforeSend");
        }
        public static Task SetBeforeSend(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_XmlaStore_SetOption", dxTarget, "beforeSend", value);
        }
        public static Task<string> GetCatalog(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_XmlaStore_GetOption", dxTarget, "catalog");
        }
        public static Task SetCatalog(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_XmlaStore_SetOption", dxTarget, "catalog", value);
        }
        public static Task<string> GetCube(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_XmlaStore_GetOption", dxTarget, "cube");
        }
        public static Task SetCube(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_XmlaStore_SetOption", dxTarget, "cube", value);
        }
        public static Task<string> GetUrl(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_XmlaStore_GetOption", dxTarget, "url");
        }
        public static Task SetUrl(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_XmlaStore_SetOption", dxTarget, "url", value);
        }
    }
}
namespace DevExpress.Core
{
    public class EventsMixinInterop
    {
        public static Task<object> Off(ElementReference dxTarget, string eventName)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_EventsMixin_off_0", dxTarget, eventName);
        }
        public static Task<object> Off(ElementReference dxTarget, string eventName, object eventHandler)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_EventsMixin_off_1", dxTarget, eventName, eventHandler);
        }
        public static Task<object> On(ElementReference dxTarget, string eventName, object eventHandler)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_EventsMixin_on_2", dxTarget, eventName, eventHandler);
        }
        public static Task<object> On(ElementReference dxTarget, object events)
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
        public static Task Init(ElementReference dxTarget, DevExpress.Framework.DxCommandOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxCommand_Init", dxTarget, json);
        }
        [JSInvokable("DevExpress.Framework.DxCommandInterop.OnExecute")]
        public static void OnExecute(string identifier)
        {
            Execute?.Invoke(null, new JQueryEventArgs(identifier));
        }
        public static Task<bool?> GetDisabled(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxCommand_GetOption", dxTarget, "disabled");
        }
        public static Task SetDisabled(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxCommand_SetOption", dxTarget, "disabled", value);
        }
        public static Task<string> GetIcon(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxCommand_GetOption", dxTarget, "icon");
        }
        public static Task SetIcon(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxCommand_SetOption", dxTarget, "icon", value);
        }
        public static Task<object> GetIconSrc(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxCommand_GetOption", dxTarget, "iconSrc");
        }
        public static Task SetIconSrc(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxCommand_SetOption", dxTarget, "iconSrc", value);
        }
        public static Task<string> GetId(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxCommand_GetOption", dxTarget, "id");
        }
        public static Task SetId(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxCommand_SetOption", dxTarget, "id", value);
        }
        public static Task<string> GetRenderStage(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxCommand_GetOption", dxTarget, "renderStage");
        }
        public static Task SetRenderStage(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxCommand_SetOption", dxTarget, "renderStage", value);
        }
        public static Task<string> GetTitle(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxCommand_GetOption", dxTarget, "title");
        }
        public static Task SetTitle(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxCommand_SetOption", dxTarget, "title", value);
        }
        public static Task<string> GetType(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxCommand_GetOption", dxTarget, "type");
        }
        public static Task SetType(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxCommand_SetOption", dxTarget, "type", value);
        }
        public static Task<bool?> GetVisible(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxCommand_GetOption", dxTarget, "visible");
        }
        public static Task SetVisible(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxCommand_SetOption", dxTarget, "visible", value);
        }
        public static Task DoExecute(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxCommand_execute_0", dxTarget);
        }
    }
    public class RouterInterop
    {
        public static Task<string> Format(ElementReference dxTarget, object obj)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_Router_format_0", dxTarget, obj);
        }
        public static Task<object> Parse(ElementReference dxTarget, string uri)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Router_parse_1", dxTarget, uri);
        }
        public static Task Register(ElementReference dxTarget, string pattern, object defaults, object constraints)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Router_register_2", dxTarget, pattern, defaults, constraints);
        }
    }
    public class StateManagerInterop
    {
        public static Task Init(ElementReference dxTarget, DevExpress.Framework.StateManagerOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_StateManager_Init", dxTarget, json);
        }
        public static Task<object> GetStorage(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_StateManager_GetOption", dxTarget, "storage");
        }
        public static Task SetStorage(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_StateManager_SetOption", dxTarget, "storage", value);
        }
        public static Task AddStateSource(ElementReference dxTarget, object stateSource)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_StateManager_addStateSource_0", dxTarget, stateSource);
        }
        public static Task ClearState(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_StateManager_clearState_1", dxTarget);
        }
        public static Task RemoveStateSource(ElementReference dxTarget, object stateSource)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_StateManager_removeStateSource_2", dxTarget, stateSource);
        }
        public static Task RestoreState(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_StateManager_restoreState_3", dxTarget);
        }
        public static Task SaveState(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_StateManager_saveState_4", dxTarget);
        }
    }
    public class ViewCacheInterop
    {
        public static Task Clear(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_ViewCache_clear_0", dxTarget);
        }
        public static Task<object> GetView(ElementReference dxTarget, string key)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_ViewCache_getView_1", dxTarget, key);
        }
        public static Task<bool> HasView(ElementReference dxTarget, string key)
        {
            return JSRuntime.Current.InvokeAsync<bool>("BlazorDevExtreme_ViewCache_hasView_2", dxTarget, key);
        }
        public static Task<object> Off(ElementReference dxTarget, string eventName)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_ViewCache_off_3", dxTarget, eventName);
        }
        public static Task<object> Off(ElementReference dxTarget, string eventName, object eventHandler)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_ViewCache_off_4", dxTarget, eventName, eventHandler);
        }
        public static Task<object> On(ElementReference dxTarget, string eventName, object eventHandler)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_ViewCache_on_5", dxTarget, eventName, eventHandler);
        }
        public static Task<object> On(ElementReference dxTarget, object events)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_ViewCache_on_6", dxTarget, events);
        }
        public static Task<object> RemoveView(ElementReference dxTarget, string key)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_ViewCache_removeView_7", dxTarget, key);
        }
        public static Task SetView(ElementReference dxTarget, string key, object viewInfo)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_ViewCache_setView_8", dxTarget, key, viewInfo);
        }
    }
    public class DxCommandContainerInterop
    {
        public static Task Init(ElementReference dxTarget, DevExpress.Framework.DxCommandContainerOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxCommandContainer_Init", dxTarget, json);
        }
        public static Task<string> GetId(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxCommandContainer_GetOption", dxTarget, "id");
        }
        public static Task SetId(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxCommandContainer_SetOption", dxTarget, "id", value);
        }
    }
    public class DxViewInterop
    {
        public static Task Init(ElementReference dxTarget, DevExpress.Framework.DxViewOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxView_Init", dxTarget, json);
        }
        public static Task<bool?> GetDisableCache(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxView_GetOption", dxTarget, "disableCache");
        }
        public static Task SetDisableCache(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxView_SetOption", dxTarget, "disableCache", value);
        }
        public static Task<bool?> GetModal(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxView_GetOption", dxTarget, "modal");
        }
        public static Task SetModal(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxView_SetOption", dxTarget, "modal", value);
        }
        public static Task<string> GetName(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxView_GetOption", dxTarget, "name");
        }
        public static Task SetName(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxView_SetOption", dxTarget, "name", value);
        }
        public static Task<string> GetOrientation(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxView_GetOption", dxTarget, "orientation");
        }
        public static Task SetOrientation(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxView_SetOption", dxTarget, "orientation", value);
        }
        public static Task<string> GetPane(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxView_GetOption", dxTarget, "pane");
        }
        public static Task SetPane(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxView_SetOption", dxTarget, "pane", value);
        }
        public static Task<string> GetTitle(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxView_GetOption", dxTarget, "title");
        }
        public static Task SetTitle(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxView_SetOption", dxTarget, "title", value);
        }
    }
    public class DxLayoutInterop
    {
        public static Task Init(ElementReference dxTarget, DevExpress.Framework.DxLayoutOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxLayout_Init", dxTarget, json);
        }
        public static Task<string> GetName(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxLayout_GetOption", dxTarget, "name");
        }
        public static Task SetName(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxLayout_SetOption", dxTarget, "name", value);
        }
    }
    public class DxViewPlaceholderInterop
    {
        public static Task Init(ElementReference dxTarget, DevExpress.Framework.DxViewPlaceholderOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxViewPlaceholder_Init", dxTarget, json);
        }
        public static Task<string> GetViewName(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxViewPlaceholder_GetOption", dxTarget, "viewName");
        }
        public static Task SetViewName(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxViewPlaceholder_SetOption", dxTarget, "viewName", value);
        }
    }
    public class DxTransitionInterop
    {
        public static Task Init(ElementReference dxTarget, DevExpress.Framework.DxTransitionOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTransition_Init", dxTarget, json);
        }
        public static Task<string> GetAnimation(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxTransition_GetOption", dxTarget, "animation");
        }
        public static Task SetAnimation(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTransition_SetOption", dxTarget, "animation", value);
        }
        public static Task<string> GetName(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxTransition_GetOption", dxTarget, "name");
        }
        public static Task SetName(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTransition_SetOption", dxTarget, "name", value);
        }
        public static Task<string> GetType(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxTransition_GetOption", dxTarget, "type");
        }
        public static Task SetType(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTransition_SetOption", dxTarget, "type", value);
        }
    }
    public class DxContentPlaceholderInterop
    {
        public static Task Init(ElementReference dxTarget, DevExpress.Framework.DxContentPlaceholderOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxContentPlaceholder_Init", dxTarget, json);
        }
        public static Task<string> GetAnimation(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxContentPlaceholder_GetOption", dxTarget, "animation");
        }
        public static Task SetAnimation(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxContentPlaceholder_SetOption", dxTarget, "animation", value);
        }
        public static Task<string> GetContentCssPosition(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxContentPlaceholder_GetOption", dxTarget, "contentCssPosition");
        }
        public static Task SetContentCssPosition(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxContentPlaceholder_SetOption", dxTarget, "contentCssPosition", value);
        }
        public static Task<string> GetName(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxContentPlaceholder_GetOption", dxTarget, "name");
        }
        public static Task SetName(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxContentPlaceholder_SetOption", dxTarget, "name", value);
        }
        public static Task<string> GetTransition(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxContentPlaceholder_GetOption", dxTarget, "transition");
        }
        public static Task SetTransition(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxContentPlaceholder_SetOption", dxTarget, "transition", value);
        }
    }
    public class DxContentInterop
    {
        public static Task Init(ElementReference dxTarget, DevExpress.Framework.DxContentOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxContent_Init", dxTarget, json);
        }
        public static Task<string> GetTargetPlaceholder(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxContent_GetOption", dxTarget, "targetPlaceholder");
        }
        public static Task SetTargetPlaceholder(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxContent_SetOption", dxTarget, "targetPlaceholder", value);
        }
    }
}
namespace DevExpress.Framework.Html
{
    public class HtmlApplicationInterop
    {
        public static Task Init(ElementReference dxTarget, DevExpress.Framework.Html.HtmlApplicationOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_HtmlApplication_Init", dxTarget, json);
        }
        public static Task<object> GetAnimationSet(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_HtmlApplication_GetOption", dxTarget, "animationSet");
        }
        public static Task SetAnimationSet(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_HtmlApplication_SetOption", dxTarget, "animationSet", value);
        }
        public static Task<object> GetCommandMapping(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_HtmlApplication_GetOption", dxTarget, "commandMapping");
        }
        public static Task SetCommandMapping(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_HtmlApplication_SetOption", dxTarget, "commandMapping", value);
        }
        public static Task<bool?> GetDisableViewCache(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_HtmlApplication_GetOption", dxTarget, "disableViewCache");
        }
        public static Task SetDisableViewCache(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_HtmlApplication_SetOption", dxTarget, "disableViewCache", value);
        }
        public static Task<object> GetLayoutSet(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_HtmlApplication_GetOption", dxTarget, "layoutSet");
        }
        public static Task SetLayoutSet(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_HtmlApplication_SetOption", dxTarget, "layoutSet", value);
        }
        public static Task<string> GetMode(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_HtmlApplication_GetOption", dxTarget, "mode");
        }
        public static Task SetMode(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_HtmlApplication_SetOption", dxTarget, "mode", value);
        }
        public static Task<object> GetNamespace(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_HtmlApplication_GetOption", dxTarget, "namespace");
        }
        public static Task SetNamespace(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_HtmlApplication_SetOption", dxTarget, "namespace", value);
        }
        public static Task<string> GetNavigateToRootViewMode(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_HtmlApplication_GetOption", dxTarget, "navigateToRootViewMode");
        }
        public static Task SetNavigateToRootViewMode(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_HtmlApplication_SetOption", dxTarget, "navigateToRootViewMode", value);
        }
        public static Task<object> GetNavigation(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_HtmlApplication_GetOption", dxTarget, "navigation");
        }
        public static Task SetNavigation(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_HtmlApplication_SetOption", dxTarget, "navigation", value);
        }
        public static Task<object> GetRouter(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_HtmlApplication_GetOption", dxTarget, "router");
        }
        public static Task SetRouter(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_HtmlApplication_SetOption", dxTarget, "router", value);
        }
        public static Task<object> GetStateManager(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_HtmlApplication_GetOption", dxTarget, "stateManager");
        }
        public static Task SetStateManager(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_HtmlApplication_SetOption", dxTarget, "stateManager", value);
        }
        public static Task<object> GetStateStorage(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_HtmlApplication_GetOption", dxTarget, "stateStorage");
        }
        public static Task SetStateStorage(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_HtmlApplication_SetOption", dxTarget, "stateStorage", value);
        }
        public static Task<string> GetTemplatesVersion(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_HtmlApplication_GetOption", dxTarget, "templatesVersion");
        }
        public static Task SetTemplatesVersion(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_HtmlApplication_SetOption", dxTarget, "templatesVersion", value);
        }
        public static Task<bool?> GetUseViewTitleAsBackText(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_HtmlApplication_GetOption", dxTarget, "useViewTitleAsBackText");
        }
        public static Task SetUseViewTitleAsBackText(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_HtmlApplication_SetOption", dxTarget, "useViewTitleAsBackText", value);
        }
        public static Task<object> GetViewCache(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_HtmlApplication_GetOption", dxTarget, "viewCache");
        }
        public static Task SetViewCache(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_HtmlApplication_SetOption", dxTarget, "viewCache", value);
        }
        public static Task<float?> GetViewCacheSize(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_HtmlApplication_GetOption", dxTarget, "viewCacheSize");
        }
        public static Task SetViewCacheSize(ElementReference dxTarget, float? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_HtmlApplication_SetOption", dxTarget, "viewCacheSize", value);
        }
        public static Task<object> GetViewPort(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_HtmlApplication_GetOption", dxTarget, "viewPort");
        }
        public static Task SetViewPort(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_HtmlApplication_SetOption", dxTarget, "viewPort", value);
        }
        public static Task Back(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_HtmlApplication_back_0", dxTarget);
        }
        public static Task<bool> CanBack(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool>("BlazorDevExtreme_HtmlApplication_canBack_1", dxTarget);
        }
        public static Task ClearState(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_HtmlApplication_clearState_2", dxTarget);
        }
        public static Task CreateNavigation(ElementReference dxTarget, object navigationConfig)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_HtmlApplication_createNavigation_3", dxTarget, navigationConfig);
        }
        public static Task<object> GetViewTemplate(ElementReference dxTarget, string viewName)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_HtmlApplication_getViewTemplate_4", dxTarget, viewName);
        }
        public static Task<object> GetViewTemplateInfo(ElementReference dxTarget, string viewName)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_HtmlApplication_getViewTemplateInfo_5", dxTarget, viewName);
        }
        public static Task<object> LoadTemplates(ElementReference dxTarget, object source)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_HtmlApplication_loadTemplates_6", dxTarget, source);
        }
        public static Task Navigate(ElementReference dxTarget, object uri)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_HtmlApplication_navigate_7", dxTarget, uri);
        }
        public static Task Navigate(ElementReference dxTarget, object uri, object options)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_HtmlApplication_navigate_8", dxTarget, uri, options);
        }
        public static Task<object> Off(ElementReference dxTarget, string eventName)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_HtmlApplication_off_9", dxTarget, eventName);
        }
        public static Task<object> Off(ElementReference dxTarget, string eventName, object eventHandler)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_HtmlApplication_off_10", dxTarget, eventName, eventHandler);
        }
        public static Task<object> On(ElementReference dxTarget, string eventName, object eventHandler)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_HtmlApplication_on_11", dxTarget, eventName, eventHandler);
        }
        public static Task<object> On(ElementReference dxTarget, object events)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_HtmlApplication_on_12", dxTarget, events);
        }
        public static Task RenderNavigation(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_HtmlApplication_renderNavigation_13", dxTarget);
        }
        public static Task RestoreState(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_HtmlApplication_restoreState_14", dxTarget);
        }
        public static Task SaveState(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_HtmlApplication_saveState_15", dxTarget);
        }
        public static Task<object> TemplateContext(ElementReference dxTarget)
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
        public static Task Init(ElementReference dxTarget, DevExpress.Ui.DxAccordionOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxAccordion_Init", dxTarget, json);
        }
        [JSInvokable("DevExpress.Ui.DxAccordionInterop.OnItemTitleClick")]
        public static void OnItemTitleClick(string identifier)
        {
            ItemTitleClick?.Invoke(null, new JQueryEventArgs(identifier));
        }
        public static Task<float?> GetAnimationDuration(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_DxAccordion_GetOption", dxTarget, "animationDuration");
        }
        public static Task SetAnimationDuration(ElementReference dxTarget, float? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxAccordion_SetOption", dxTarget, "animationDuration", value);
        }
        public static Task<bool?> GetCollapsible(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxAccordion_GetOption", dxTarget, "collapsible");
        }
        public static Task SetCollapsible(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxAccordion_SetOption", dxTarget, "collapsible", value);
        }
        public static Task<bool?> GetDeferRendering(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxAccordion_GetOption", dxTarget, "deferRendering");
        }
        public static Task SetDeferRendering(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxAccordion_SetOption", dxTarget, "deferRendering", value);
        }
        public static Task<object> GetItemTitleTemplate(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxAccordion_GetOption", dxTarget, "itemTitleTemplate");
        }
        public static Task SetItemTitleTemplate(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxAccordion_SetOption", dxTarget, "itemTitleTemplate", value);
        }
        public static Task<bool?> GetMultiple(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxAccordion_GetOption", dxTarget, "multiple");
        }
        public static Task SetMultiple(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxAccordion_SetOption", dxTarget, "multiple", value);
        }
        public static Task<object> CollapseItem(ElementReference dxTarget, float index)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxAccordion_collapseItem_0", dxTarget, index);
        }
        public static Task<object> ExpandItem(ElementReference dxTarget, float index)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxAccordion_expandItem_1", dxTarget, index);
        }
        public static Task<object> UpdateDimensions(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxAccordion_updateDimensions_2", dxTarget);
        }
    }
    public class DxActionSheetInterop: CollectionWidgetInterop
    {
        public static event EventHandler<JQueryEventArgs> CancelClick;
        public static Task Init(ElementReference dxTarget, DevExpress.Ui.DxActionSheetOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxActionSheet_Init", dxTarget, json);
        }
        [JSInvokable("DevExpress.Ui.DxActionSheetInterop.OnCancelClick")]
        public static void OnCancelClick(string identifier)
        {
            CancelClick?.Invoke(null, new JQueryEventArgs(identifier));
        }
        public static Task<string> GetCancelText(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxActionSheet_GetOption", dxTarget, "cancelText");
        }
        public static Task SetCancelText(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxActionSheet_SetOption", dxTarget, "cancelText", value);
        }
        public static Task<bool?> GetShowCancelButton(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxActionSheet_GetOption", dxTarget, "showCancelButton");
        }
        public static Task SetShowCancelButton(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxActionSheet_SetOption", dxTarget, "showCancelButton", value);
        }
        public static Task<bool?> GetShowTitle(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxActionSheet_GetOption", dxTarget, "showTitle");
        }
        public static Task SetShowTitle(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxActionSheet_SetOption", dxTarget, "showTitle", value);
        }
        public static Task<object> GetTarget(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxActionSheet_GetOption", dxTarget, "target");
        }
        public static Task SetTarget(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxActionSheet_SetOption", dxTarget, "target", value);
        }
        public static Task<string> GetTitle(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxActionSheet_GetOption", dxTarget, "title");
        }
        public static Task SetTitle(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxActionSheet_SetOption", dxTarget, "title", value);
        }
        public static Task<bool?> GetUsePopover(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxActionSheet_GetOption", dxTarget, "usePopover");
        }
        public static Task SetUsePopover(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxActionSheet_SetOption", dxTarget, "usePopover", value);
        }
        public static Task<object> Hide(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxActionSheet_hide_0", dxTarget);
        }
        public static Task<object> Show(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxActionSheet_show_1", dxTarget);
        }
        public static Task<object> Toggle(ElementReference dxTarget, bool showing)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxActionSheet_toggle_2", dxTarget, showing);
        }
    }
    public class DxAutocompleteInterop: DxDropDownListInterop
    {
        public static Task Init(ElementReference dxTarget, DevExpress.Ui.DxAutocompleteOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxAutocomplete_Init", dxTarget, json);
        }
        public static Task<float?> GetMaxItemCount(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_DxAutocomplete_GetOption", dxTarget, "maxItemCount");
        }
        public static Task SetMaxItemCount(ElementReference dxTarget, float? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxAutocomplete_SetOption", dxTarget, "maxItemCount", value);
        }
    }
    public class DxBoxInterop: CollectionWidgetInterop
    {
        public static Task Init(ElementReference dxTarget, DevExpress.Ui.DxBoxOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxBox_Init", dxTarget, json);
        }
        public static Task<string> GetAlign(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxBox_GetOption", dxTarget, "align");
        }
        public static Task SetAlign(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxBox_SetOption", dxTarget, "align", value);
        }
        public static Task<string> GetCrossAlign(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxBox_GetOption", dxTarget, "crossAlign");
        }
        public static Task SetCrossAlign(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxBox_SetOption", dxTarget, "crossAlign", value);
        }
        public static Task<string> GetDirection(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxBox_GetOption", dxTarget, "direction");
        }
        public static Task SetDirection(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxBox_SetOption", dxTarget, "direction", value);
        }
    }
    public class DxButtonInterop: WidgetInterop
    {
        public static event EventHandler<JQueryEventArgs> Click;
        public static Task Init(ElementReference dxTarget, DevExpress.Ui.DxButtonOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxButton_Init", dxTarget, json);
        }
        [JSInvokable("DevExpress.Ui.DxButtonInterop.OnClick")]
        public static void OnClick(string identifier)
        {
            Click?.Invoke(null, new JQueryEventArgs(identifier));
        }
        public static Task<string> GetIcon(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxButton_GetOption", dxTarget, "icon");
        }
        public static Task SetIcon(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxButton_SetOption", dxTarget, "icon", value);
        }
        public static Task<object> GetTemplate(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxButton_GetOption", dxTarget, "template");
        }
        public static Task SetTemplate(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxButton_SetOption", dxTarget, "template", value);
        }
        public static Task<string> GetText(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxButton_GetOption", dxTarget, "text");
        }
        public static Task SetText(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxButton_SetOption", dxTarget, "text", value);
        }
        public static Task<string> GetType(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxButton_GetOption", dxTarget, "type");
        }
        public static Task SetType(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxButton_SetOption", dxTarget, "type", value);
        }
        public static Task<bool?> GetUseSubmitBehavior(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxButton_GetOption", dxTarget, "useSubmitBehavior");
        }
        public static Task SetUseSubmitBehavior(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxButton_SetOption", dxTarget, "useSubmitBehavior", value);
        }
        public static Task<string> GetValidationGroup(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxButton_GetOption", dxTarget, "validationGroup");
        }
        public static Task SetValidationGroup(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxButton_SetOption", dxTarget, "validationGroup", value);
        }
    }
    public class DxCalendarInterop: EditorInterop
    {
        public static Task Init(ElementReference dxTarget, DevExpress.Ui.DxCalendarOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxCalendar_Init", dxTarget, json);
        }
        public static Task<object> GetCellTemplate(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxCalendar_GetOption", dxTarget, "cellTemplate");
        }
        public static Task SetCellTemplate(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxCalendar_SetOption", dxTarget, "cellTemplate", value);
        }
        public static Task<string> GetDateSerializationFormat(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxCalendar_GetOption", dxTarget, "dateSerializationFormat");
        }
        public static Task SetDateSerializationFormat(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxCalendar_SetOption", dxTarget, "dateSerializationFormat", value);
        }
        public static Task<object> GetDisabledDates(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxCalendar_GetOption", dxTarget, "disabledDates");
        }
        public static Task SetDisabledDates(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxCalendar_SetOption", dxTarget, "disabledDates", value);
        }
        public static Task<object> GetFirstDayOfWeek(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxCalendar_GetOption", dxTarget, "firstDayOfWeek");
        }
        public static Task SetFirstDayOfWeek(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxCalendar_SetOption", dxTarget, "firstDayOfWeek", value);
        }
        public static Task<object> GetMax(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxCalendar_GetOption", dxTarget, "max");
        }
        public static Task SetMax(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxCalendar_SetOption", dxTarget, "max", value);
        }
        public static Task<string> GetMaxZoomLevel(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxCalendar_GetOption", dxTarget, "maxZoomLevel");
        }
        public static Task SetMaxZoomLevel(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxCalendar_SetOption", dxTarget, "maxZoomLevel", value);
        }
        public static Task<object> GetMin(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxCalendar_GetOption", dxTarget, "min");
        }
        public static Task SetMin(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxCalendar_SetOption", dxTarget, "min", value);
        }
        public static Task<string> GetMinZoomLevel(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxCalendar_GetOption", dxTarget, "minZoomLevel");
        }
        public static Task SetMinZoomLevel(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxCalendar_SetOption", dxTarget, "minZoomLevel", value);
        }
        public static Task<string> GetName(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxCalendar_GetOption", dxTarget, "name");
        }
        public static Task SetName(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxCalendar_SetOption", dxTarget, "name", value);
        }
        public static Task<bool?> GetShowTodayButton(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxCalendar_GetOption", dxTarget, "showTodayButton");
        }
        public static Task SetShowTodayButton(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxCalendar_SetOption", dxTarget, "showTodayButton", value);
        }
        public static Task<string> GetZoomLevel(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxCalendar_GetOption", dxTarget, "zoomLevel");
        }
        public static Task SetZoomLevel(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxCalendar_SetOption", dxTarget, "zoomLevel", value);
        }
    }
    public class DxCheckBoxInterop: EditorInterop
    {
        public static new event EventHandler<(JQueryEventArgs, bool?)> ValueChanged;

        [JSInvokable("DevExpress.Ui.DxCheckBoxInterop.OnValueChanged")]
        public static void OnValueChanged(string identifier, bool? value)
        {
            ValueChanged?.Invoke(null, (new JQueryEventArgs(identifier), value));
        }

        public static Task Init(ElementReference dxTarget, DevExpress.Ui.DxCheckBoxOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxCheckBox_Init", dxTarget, json);
        }
        public static Task<string> GetName(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxCheckBox_GetOption", dxTarget, "name");
        }
        public static Task SetName(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxCheckBox_SetOption", dxTarget, "name", value);
        }
        public static Task<string> GetText(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxCheckBox_GetOption", dxTarget, "text");
        }
        public static Task SetText(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxCheckBox_SetOption", dxTarget, "text", value);
        }
    }
    public class DxColorBoxInterop: DxDropDownEditorInterop
    {
        public static Task Init(ElementReference dxTarget, DevExpress.Ui.DxColorBoxOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxColorBox_Init", dxTarget, json);
        }
        public static Task<string> GetApplyButtonText(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxColorBox_GetOption", dxTarget, "applyButtonText");
        }
        public static Task SetApplyButtonText(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxColorBox_SetOption", dxTarget, "applyButtonText", value);
        }
        public static Task<string> GetCancelButtonText(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxColorBox_GetOption", dxTarget, "cancelButtonText");
        }
        public static Task SetCancelButtonText(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxColorBox_SetOption", dxTarget, "cancelButtonText", value);
        }
        public static Task<bool?> GetEditAlphaChannel(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxColorBox_GetOption", dxTarget, "editAlphaChannel");
        }
        public static Task SetEditAlphaChannel(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxColorBox_SetOption", dxTarget, "editAlphaChannel", value);
        }
        public static Task<object> GetFieldTemplate(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxColorBox_GetOption", dxTarget, "fieldTemplate");
        }
        public static Task SetFieldTemplate(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxColorBox_SetOption", dxTarget, "fieldTemplate", value);
        }
        public static Task<float?> GetKeyStep(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_DxColorBox_GetOption", dxTarget, "keyStep");
        }
        public static Task SetKeyStep(ElementReference dxTarget, float? value)
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
        public static Task Init(ElementReference dxTarget, DevExpress.Ui.DxContextMenuOptions options)
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
        public static Task<object> GetCloseOnOutsideClick(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxContextMenu_GetOption", dxTarget, "closeOnOutsideClick");
        }
        public static Task SetCloseOnOutsideClick(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxContextMenu_SetOption", dxTarget, "closeOnOutsideClick", value);
        }
        public static Task<object> GetPosition(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxContextMenu_GetOption", dxTarget, "position");
        }
        public static Task SetPosition(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxContextMenu_SetOption", dxTarget, "position", value);
        }
        public static Task<object> GetShowEvent(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxContextMenu_GetOption", dxTarget, "showEvent");
        }
        public static Task SetShowEvent(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxContextMenu_SetOption", dxTarget, "showEvent", value);
        }
        public static Task<string> GetSubmenuDirection(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxContextMenu_GetOption", dxTarget, "submenuDirection");
        }
        public static Task SetSubmenuDirection(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxContextMenu_SetOption", dxTarget, "submenuDirection", value);
        }
        public static Task<object> GetTarget(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxContextMenu_GetOption", dxTarget, "target");
        }
        public static Task SetTarget(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxContextMenu_SetOption", dxTarget, "target", value);
        }
        public static Task<object> Hide(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxContextMenu_hide_0", dxTarget);
        }
        public static Task<object> Show(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxContextMenu_show_1", dxTarget);
        }
        public static Task<object> Toggle(ElementReference dxTarget, bool showing)
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
        public static Task Init(ElementReference dxTarget, DevExpress.Ui.GridBaseOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_Init", dxTarget, json);
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
        public static Task<bool?> GetAllowColumnReordering(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_GridBase_GetOption", dxTarget, "allowColumnReordering");
        }
        public static Task SetAllowColumnReordering(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_SetOption", dxTarget, "allowColumnReordering", value);
        }
        public static Task<bool?> GetAllowColumnResizing(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_GridBase_GetOption", dxTarget, "allowColumnResizing");
        }
        public static Task SetAllowColumnResizing(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_SetOption", dxTarget, "allowColumnResizing", value);
        }
        public static Task<bool?> GetCacheEnabled(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_GridBase_GetOption", dxTarget, "cacheEnabled");
        }
        public static Task SetCacheEnabled(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_SetOption", dxTarget, "cacheEnabled", value);
        }
        public static Task<bool?> GetCellHintEnabled(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_GridBase_GetOption", dxTarget, "cellHintEnabled");
        }
        public static Task SetCellHintEnabled(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_SetOption", dxTarget, "cellHintEnabled", value);
        }
        public static Task<bool?> GetColumnAutoWidth(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_GridBase_GetOption", dxTarget, "columnAutoWidth");
        }
        public static Task SetColumnAutoWidth(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_SetOption", dxTarget, "columnAutoWidth", value);
        }
        public static Task<object> GetColumnChooser(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_GetOption", dxTarget, "columnChooser");
        }
        public static Task SetColumnChooser(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_SetOption", dxTarget, "columnChooser", value);
        }
        public static Task<object> GetColumnFixing(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_GetOption", dxTarget, "columnFixing");
        }
        public static Task SetColumnFixing(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_SetOption", dxTarget, "columnFixing", value);
        }
        public static Task<bool?> GetColumnHidingEnabled(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_GridBase_GetOption", dxTarget, "columnHidingEnabled");
        }
        public static Task SetColumnHidingEnabled(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_SetOption", dxTarget, "columnHidingEnabled", value);
        }
        public static Task<float?> GetColumnMinWidth(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_GridBase_GetOption", dxTarget, "columnMinWidth");
        }
        public static Task SetColumnMinWidth(ElementReference dxTarget, float? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_SetOption", dxTarget, "columnMinWidth", value);
        }
        public static Task<string> GetColumnResizingMode(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_GridBase_GetOption", dxTarget, "columnResizingMode");
        }
        public static Task SetColumnResizingMode(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_SetOption", dxTarget, "columnResizingMode", value);
        }
        public static Task<object> GetColumns(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_GetOption", dxTarget, "columns");
        }
        public static Task SetColumns(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_SetOption", dxTarget, "columns", value);
        }
        public static Task<float?> GetColumnWidth(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_GridBase_GetOption", dxTarget, "columnWidth");
        }
        public static Task SetColumnWidth(ElementReference dxTarget, float? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_SetOption", dxTarget, "columnWidth", value);
        }
        public static Task<object> GetDataSource(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_GetOption", dxTarget, "dataSource");
        }
        public static Task SetDataSource(ElementReference dxTarget, object value)
        {
            string jsonValue = SimpleJson.SimpleJson.SerializeObject(value);
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_SetOption", dxTarget, "dataSource", jsonValue);
        }
        public static Task<string> GetDateSerializationFormat(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_GridBase_GetOption", dxTarget, "dateSerializationFormat");
        }
        public static Task SetDateSerializationFormat(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_SetOption", dxTarget, "dateSerializationFormat", value);
        }
        public static Task<object> GetEditing(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_GetOption", dxTarget, "editing");
        }
        public static Task SetEditing(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_SetOption", dxTarget, "editing", value);
        }
        public static Task<bool?> GetErrorRowEnabled(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_GridBase_GetOption", dxTarget, "errorRowEnabled");
        }
        public static Task SetErrorRowEnabled(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_SetOption", dxTarget, "errorRowEnabled", value);
        }
        public static Task<object> GetFilterBuilder(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_GetOption", dxTarget, "filterBuilder");
        }
        public static Task SetFilterBuilder(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_SetOption", dxTarget, "filterBuilder", value);
        }
        public static Task<object> GetFilterBuilderPopup(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_GetOption", dxTarget, "filterBuilderPopup");
        }
        public static Task SetFilterBuilderPopup(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_SetOption", dxTarget, "filterBuilderPopup", value);
        }
        public static Task<object> GetFilterPanel(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_GetOption", dxTarget, "filterPanel");
        }
        public static Task SetFilterPanel(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_SetOption", dxTarget, "filterPanel", value);
        }
        public static Task<object> GetFilterRow(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_GetOption", dxTarget, "filterRow");
        }
        public static Task SetFilterRow(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_SetOption", dxTarget, "filterRow", value);
        }
        public static Task<object> GetFilterSyncEnabled(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_GetOption", dxTarget, "filterSyncEnabled");
        }
        public static Task SetFilterSyncEnabled(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_SetOption", dxTarget, "filterSyncEnabled", value);
        }
        public static Task<object> GetFilterValue(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_GetOption", dxTarget, "filterValue");
        }
        public static Task SetFilterValue(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_SetOption", dxTarget, "filterValue", value);
        }
        public static Task<object> GetHeaderFilter(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_GetOption", dxTarget, "headerFilter");
        }
        public static Task SetHeaderFilter(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_SetOption", dxTarget, "headerFilter", value);
        }
        public static Task<object> GetLoadPanel(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_GetOption", dxTarget, "loadPanel");
        }
        public static Task SetLoadPanel(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_SetOption", dxTarget, "loadPanel", value);
        }
        public static Task<string> GetNoDataText(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_GridBase_GetOption", dxTarget, "noDataText");
        }
        public static Task SetNoDataText(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_SetOption", dxTarget, "noDataText", value);
        }
        public static Task<object> GetPager(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_GetOption", dxTarget, "pager");
        }
        public static Task SetPager(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_SetOption", dxTarget, "pager", value);
        }
        public static Task<object> GetPaging(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_GetOption", dxTarget, "paging");
        }
        public static Task SetPaging(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_SetOption", dxTarget, "paging", value);
        }
        public static Task<bool?> GetRowAlternationEnabled(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_GridBase_GetOption", dxTarget, "rowAlternationEnabled");
        }
        public static Task SetRowAlternationEnabled(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_SetOption", dxTarget, "rowAlternationEnabled", value);
        }
        public static Task<object> GetScrolling(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_GetOption", dxTarget, "scrolling");
        }
        public static Task SetScrolling(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_SetOption", dxTarget, "scrolling", value);
        }
        public static Task<object> GetSearchPanel(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_GetOption", dxTarget, "searchPanel");
        }
        public static Task SetSearchPanel(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_SetOption", dxTarget, "searchPanel", value);
        }
        public static Task<object> GetSelectedRowKeys(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_GetOption", dxTarget, "selectedRowKeys");
        }
        public static Task SetSelectedRowKeys(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_SetOption", dxTarget, "selectedRowKeys", value);
        }
        public static Task<object> GetSelection(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_GetOption", dxTarget, "selection");
        }
        public static Task SetSelection(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_SetOption", dxTarget, "selection", value);
        }
        public static Task<bool?> GetShowBorders(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_GridBase_GetOption", dxTarget, "showBorders");
        }
        public static Task SetShowBorders(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_SetOption", dxTarget, "showBorders", value);
        }
        public static Task<bool?> GetShowColumnHeaders(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_GridBase_GetOption", dxTarget, "showColumnHeaders");
        }
        public static Task SetShowColumnHeaders(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_SetOption", dxTarget, "showColumnHeaders", value);
        }
        public static Task<bool?> GetShowColumnLines(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_GridBase_GetOption", dxTarget, "showColumnLines");
        }
        public static Task SetShowColumnLines(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_SetOption", dxTarget, "showColumnLines", value);
        }
        public static Task<bool?> GetShowRowLines(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_GridBase_GetOption", dxTarget, "showRowLines");
        }
        public static Task SetShowRowLines(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_SetOption", dxTarget, "showRowLines", value);
        }
        public static Task<object> GetSorting(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_GetOption", dxTarget, "sorting");
        }
        public static Task SetSorting(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_SetOption", dxTarget, "sorting", value);
        }
        public static Task<object> GetStateStoring(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_GetOption", dxTarget, "stateStoring");
        }
        public static Task SetStateStoring(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_SetOption", dxTarget, "stateStoring", value);
        }
        public static Task<bool?> GetTwoWayBindingEnabled(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_GridBase_GetOption", dxTarget, "twoWayBindingEnabled");
        }
        public static Task SetTwoWayBindingEnabled(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_SetOption", dxTarget, "twoWayBindingEnabled", value);
        }
        public static Task<bool?> GetWordWrapEnabled(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_GridBase_GetOption", dxTarget, "wordWrapEnabled");
        }
        public static Task SetWordWrapEnabled(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_SetOption", dxTarget, "wordWrapEnabled", value);
        }
        public static Task BeginCustomLoading(ElementReference dxTarget, string messageText)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_beginCustomLoading_0", dxTarget, messageText);
        }
        public static Task<object> ByKey(ElementReference dxTarget, object key)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_byKey_1", dxTarget, key);
        }
        public static Task CancelEditData(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_cancelEditData_2", dxTarget);
        }
        public static Task<object> CellValue(ElementReference dxTarget, float rowIndex, string dataField)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_cellValue_3", dxTarget, rowIndex, dataField);
        }
        public static Task CellValue(ElementReference dxTarget, float rowIndex, string dataField, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_cellValue_4", dxTarget, rowIndex, dataField, value);
        }
        public static Task<object> CellValue(ElementReference dxTarget, float rowIndex, float visibleColumnIndex)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_cellValue_5", dxTarget, rowIndex, visibleColumnIndex);
        }
        public static Task CellValue(ElementReference dxTarget, float rowIndex, float visibleColumnIndex, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_cellValue_6", dxTarget, rowIndex, visibleColumnIndex, value);
        }
        public static Task ClearFilter(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_clearFilter_7", dxTarget);
        }
        public static Task ClearFilter(ElementReference dxTarget, string filterName)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_clearFilter_8", dxTarget, filterName);
        }
        public static Task ClearSelection(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_clearSelection_9", dxTarget);
        }
        public static Task ClearSorting(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_clearSorting_10", dxTarget);
        }
        public static Task CloseEditCell(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_closeEditCell_11", dxTarget);
        }
        public static Task CollapseAdaptiveDetailRow(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_collapseAdaptiveDetailRow_12", dxTarget);
        }
        public static Task<float> ColumnCount(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<float>("BlazorDevExtreme_GridBase_columnCount_13", dxTarget);
        }
        public static Task<object> ColumnOption(ElementReference dxTarget, object id)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_columnOption_14", dxTarget, id);
        }
        public static Task<object> ColumnOption(ElementReference dxTarget, object id, string optionName)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_columnOption_15", dxTarget, id, optionName);
        }
        public static Task ColumnOption(ElementReference dxTarget, object id, string optionName, object optionValue)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_columnOption_16", dxTarget, id, optionName, optionValue);
        }
        public static Task ColumnOption(ElementReference dxTarget, object id, object options)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_columnOption_17", dxTarget, id, options);
        }
        public static Task DeleteColumn(ElementReference dxTarget, object id)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_deleteColumn_18", dxTarget, id);
        }
        public static Task DeleteRow(ElementReference dxTarget, float rowIndex)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_deleteRow_19", dxTarget, rowIndex);
        }
        public static Task<object> DeselectAll(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_deselectAll_20", dxTarget);
        }
        public static Task<object> DeselectRows(ElementReference dxTarget, object keys)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_deselectRows_21", dxTarget, keys);
        }
        public static Task EditCell(ElementReference dxTarget, float rowIndex, string dataField)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_editCell_22", dxTarget, rowIndex, dataField);
        }
        public static Task EditCell(ElementReference dxTarget, float rowIndex, float visibleColumnIndex)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_editCell_23", dxTarget, rowIndex, visibleColumnIndex);
        }
        public static Task EditRow(ElementReference dxTarget, float rowIndex)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_editRow_24", dxTarget, rowIndex);
        }
        public static Task EndCustomLoading(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_endCustomLoading_25", dxTarget);
        }
        public static Task ExpandAdaptiveDetailRow(ElementReference dxTarget, object key)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_expandAdaptiveDetailRow_26", dxTarget, key);
        }
        public static Task<object> Filter(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_filter_27", dxTarget);
        }
        public static Task Filter(ElementReference dxTarget, object filterExpr)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_filter_28", dxTarget, filterExpr);
        }
        public static Task Focus(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_focus_29", dxTarget);
        }
        public static Task Focus(ElementReference dxTarget, object element)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_focus_30", dxTarget, element);
        }
        public static Task<object> GetCellElement(ElementReference dxTarget, float rowIndex, string dataField)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_getCellElement_31", dxTarget, rowIndex, dataField);
        }
        public static Task<object> GetCellElement(ElementReference dxTarget, float rowIndex, float visibleColumnIndex)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_getCellElement_32", dxTarget, rowIndex, visibleColumnIndex);
        }
        public static Task<object> GetCombinedFilter(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_getCombinedFilter_33", dxTarget);
        }
        public static Task<object> GetCombinedFilter(ElementReference dxTarget, bool returnDataField)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_getCombinedFilter_34", dxTarget, returnDataField);
        }
        public static Task<object> GetDataSourceEx(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_getDataSource_35", dxTarget);
        }
        public static Task<object> GetKeyByRowIndex(ElementReference dxTarget, float rowIndex)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_getKeyByRowIndex_36", dxTarget, rowIndex);
        }
        public static Task<object> GetRowElement(ElementReference dxTarget, float rowIndex)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_getRowElement_37", dxTarget, rowIndex);
        }
        public static Task<float> GetRowIndexByKey(ElementReference dxTarget, object key)
        {
            return JSRuntime.Current.InvokeAsync<float>("BlazorDevExtreme_GridBase_getRowIndexByKey_38", dxTarget, key);
        }
        public static Task<object> GetScrollable(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_getScrollable_39", dxTarget);
        }
        public static Task<bool> HasEditData(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool>("BlazorDevExtreme_GridBase_hasEditData_40", dxTarget);
        }
        public static Task HideColumnChooser(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_hideColumnChooser_41", dxTarget);
        }
        public static Task IsAdaptiveDetailRowExpanded(ElementReference dxTarget, object key)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_isAdaptiveDetailRowExpanded_42", dxTarget, key);
        }
        public static Task<bool> IsRowSelected(ElementReference dxTarget, object key)
        {
            return JSRuntime.Current.InvokeAsync<bool>("BlazorDevExtreme_GridBase_isRowSelected_43", dxTarget, key);
        }
        public static Task<object> KeyOf(ElementReference dxTarget, object obj)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_keyOf_44", dxTarget, obj);
        }
        public static Task<float> PageCount(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<float>("BlazorDevExtreme_GridBase_pageCount_45", dxTarget);
        }
        public static Task<float> PageIndex(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<float>("BlazorDevExtreme_GridBase_pageIndex_46", dxTarget);
        }
        public static Task<object> PageIndex(ElementReference dxTarget, float newIndex)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_pageIndex_47", dxTarget, newIndex);
        }
        public static Task<float> PageSize(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<float>("BlazorDevExtreme_GridBase_pageSize_48", dxTarget);
        }
        public static Task PageSize(ElementReference dxTarget, float value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_pageSize_49", dxTarget, value);
        }
        public static Task<object> Refresh(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_refresh_50", dxTarget);
        }
        public static Task RepaintRows(ElementReference dxTarget, object rowIndexes)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_repaintRows_51", dxTarget, rowIndexes);
        }
        public static Task<object> SaveEditData(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_saveEditData_52", dxTarget);
        }
        public static Task SearchByText(ElementReference dxTarget, string text)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_searchByText_53", dxTarget, text);
        }
        public static Task<object> SelectAll(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_selectAll_54", dxTarget);
        }
        public static Task<object> SelectRows(ElementReference dxTarget, object keys, bool preserve)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_selectRows_55", dxTarget, keys, preserve);
        }
        public static Task<object> SelectRowsByIndexes(ElementReference dxTarget, object indexes)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_selectRowsByIndexes_56", dxTarget, indexes);
        }
        public static Task ShowColumnChooser(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_showColumnChooser_57", dxTarget);
        }
        public static Task<object> State(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_state_58", dxTarget);
        }
        public static Task State(ElementReference dxTarget, object state)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_state_59", dxTarget, state);
        }
        public static Task UndeleteRow(ElementReference dxTarget, float rowIndex)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_undeleteRow_60", dxTarget, rowIndex);
        }
        public static Task UpdateDimensions(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_updateDimensions_61", dxTarget);
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
        public static Task Init(ElementReference dxTarget, DevExpress.Ui.DxDataGridOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDataGrid_Init", dxTarget, json);
        }

        public new static Task UpdateDimensions(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDataGid_updateDimensions", dxTarget);
        }

        public new static Task SetPaging(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDataGrid_SetOption", dxTarget, "paging", value);
        }
            
        public new static Task SetPager(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDataGrid_SetOption", dxTarget, "pager", value);
        }

        public new static Task SetFilterRow(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDataGrid_SetOption", dxTarget, "filterRow", value);
        }

        public new static Task SetColumns(ElementReference dxTarget, object value)
        {
            string jsonValue = SimpleJson.SimpleJson.SerializeObject(value);
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDataGrid_SetOption", dxTarget, "columns", jsonValue);
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
        public static Task<object> GetCustomizeColumns(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDataGrid_GetOption", dxTarget, "customizeColumns");
        }
        public static Task SetCustomizeColumns(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDataGrid_SetOption", dxTarget, "customizeColumns", value);
        }
        public static Task<object> GetCustomizeExportData(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDataGrid_GetOption", dxTarget, "customizeExportData");
        }
        public static Task SetCustomizeExportData(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDataGrid_SetOption", dxTarget, "customizeExportData", value);
        }
        public static Task<object> GetExport(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDataGrid_GetOption", dxTarget, "export");
        }
        public static Task SetExport(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDataGrid_SetOption", dxTarget, "export", value);
        }
        public static Task<object> GetGrouping(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDataGrid_GetOption", dxTarget, "grouping");
        }
        public static Task SetGrouping(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDataGrid_SetOption", dxTarget, "grouping", value);
        }
        public static Task<object> GetGroupPanel(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDataGrid_GetOption", dxTarget, "groupPanel");
        }
        public static Task SetGroupPanel(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDataGrid_SetOption", dxTarget, "groupPanel", value);
        }
        public static Task<object> GetKeyExpr(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDataGrid_GetOption", dxTarget, "keyExpr");
        }
        public static Task SetKeyExpr(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDataGrid_SetOption", dxTarget, "keyExpr", value);
        }
        public static Task<object> GetMasterDetail(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDataGrid_GetOption", dxTarget, "masterDetail");
        }
        public static Task SetMasterDetail(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDataGrid_SetOption", dxTarget, "masterDetail", value);
        }
        public static Task<object> GetRemoteOperations(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDataGrid_GetOption", dxTarget, "remoteOperations");
        }
        public static Task SetRemoteOperations(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDataGrid_SetOption", dxTarget, "remoteOperations", value);
        }
        public static Task<object> GetRowTemplate(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDataGrid_GetOption", dxTarget, "rowTemplate");
        }
        public static Task SetRowTemplate(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDataGrid_SetOption", dxTarget, "rowTemplate", value);
        }
        public static Task<object> GetSelectionFilter(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDataGrid_GetOption", dxTarget, "selectionFilter");
        }
        public static Task SetSelectionFilter(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDataGrid_SetOption", dxTarget, "selectionFilter", value);
        }
        public static Task<object> GetSortByGroupSummaryInfo(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDataGrid_GetOption", dxTarget, "sortByGroupSummaryInfo");
        }
        public static Task SetSortByGroupSummaryInfo(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDataGrid_SetOption", dxTarget, "sortByGroupSummaryInfo", value);
        }
        public static Task<object> GetSummary(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDataGrid_GetOption", dxTarget, "summary");
        }
        public static Task SetSummary(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDataGrid_SetOption", dxTarget, "summary", value);
        }
        public static Task AddColumn(ElementReference dxTarget, object columnOptions)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDataGrid_addColumn_0", dxTarget, columnOptions);
        }
        public static Task AddRow(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDataGrid_addRow_1", dxTarget);
        }
        public static Task ClearGrouping(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDataGrid_clearGrouping_2", dxTarget);
        }
        public static Task CollapseAll(ElementReference dxTarget, float groupIndex)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDataGrid_collapseAll_3", dxTarget, groupIndex);
        }
        public static Task<object> CollapseRow(ElementReference dxTarget, object key)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDataGrid_collapseRow_4", dxTarget, key);
        }
        public static Task ExpandAll(ElementReference dxTarget, float groupIndex)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDataGrid_expandAll_5", dxTarget, groupIndex);
        }
        public static Task<object> ExpandRow(ElementReference dxTarget, object key)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDataGrid_expandRow_6", dxTarget, key);
        }
        public static Task ExportToExcel(ElementReference dxTarget, bool selectionOnly)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDataGrid_exportToExcel_7", dxTarget, selectionOnly);
        }
        public static Task<object> GetSelectedRowKeys(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDataGrid_getSelectedRowKeys_8", dxTarget);
        }
        public static Task<object> GetSelectedRowsData(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDataGrid_getSelectedRowsData_9", dxTarget);
        }
        public static Task<object> GetTotalSummaryValue(ElementReference dxTarget, string summaryItemName)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDataGrid_getTotalSummaryValue_10", dxTarget, summaryItemName);
        }
        public static Task<object> GetVisibleColumns(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDataGrid_getVisibleColumns_11", dxTarget);
        }
        public static Task<object> GetVisibleColumns(ElementReference dxTarget, float headerLevel)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDataGrid_getVisibleColumns_12", dxTarget, headerLevel);
        }
        public static Task<object> GetVisibleRows(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDataGrid_getVisibleRows_13", dxTarget);
        }
        public static Task InsertRow(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDataGrid_insertRow_14", dxTarget);
        }
        public static Task<bool> IsRowExpanded(ElementReference dxTarget, object key)
        {
            return JSRuntime.Current.InvokeAsync<bool>("BlazorDevExtreme_DxDataGrid_isRowExpanded_15", dxTarget, key);
        }
        public static Task<bool> IsRowSelected(ElementReference dxTarget, object data)
        {
            return JSRuntime.Current.InvokeAsync<bool>("BlazorDevExtreme_DxDataGrid_isRowSelected_16", dxTarget, data);
        }
        public static Task RemoveRow(ElementReference dxTarget, float rowIndex)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDataGrid_removeRow_18", dxTarget, rowIndex);
        }
        public static Task<float> TotalCount(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<float>("BlazorDevExtreme_DxDataGrid_totalCount_19", dxTarget);
        }
    }
    public class DxDateBoxInterop: DxDropDownEditorInterop
    {
        public static Task Init(ElementReference dxTarget, DevExpress.Ui.DxDateBoxOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDateBox_Init", dxTarget, json);
        }
        public static Task<bool?> GetAdaptivityEnabled(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxDateBox_GetOption", dxTarget, "adaptivityEnabled");
        }
        public static Task SetAdaptivityEnabled(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDateBox_SetOption", dxTarget, "adaptivityEnabled", value);
        }
        public static Task<string> GetApplyButtonText(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxDateBox_GetOption", dxTarget, "applyButtonText");
        }
        public static Task SetApplyButtonText(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDateBox_SetOption", dxTarget, "applyButtonText", value);
        }
        public static Task<object> GetCalendarOptions(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDateBox_GetOption", dxTarget, "calendarOptions");
        }
        public static Task SetCalendarOptions(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDateBox_SetOption", dxTarget, "calendarOptions", value);
        }
        public static Task<string> GetCancelButtonText(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxDateBox_GetOption", dxTarget, "cancelButtonText");
        }
        public static Task SetCancelButtonText(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDateBox_SetOption", dxTarget, "cancelButtonText", value);
        }
        public static Task<string> GetDateOutOfRangeMessage(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxDateBox_GetOption", dxTarget, "dateOutOfRangeMessage");
        }
        public static Task SetDateOutOfRangeMessage(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDateBox_SetOption", dxTarget, "dateOutOfRangeMessage", value);
        }
        public static Task<string> GetDateSerializationFormat(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxDateBox_GetOption", dxTarget, "dateSerializationFormat");
        }
        public static Task SetDateSerializationFormat(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDateBox_SetOption", dxTarget, "dateSerializationFormat", value);
        }
        public static Task<object> GetDisabledDates(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDateBox_GetOption", dxTarget, "disabledDates");
        }
        public static Task SetDisabledDates(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDateBox_SetOption", dxTarget, "disabledDates", value);
        }
        public static Task<object> GetDisplayFormat(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDateBox_GetOption", dxTarget, "displayFormat");
        }
        public static Task SetDisplayFormat(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDateBox_SetOption", dxTarget, "displayFormat", value);
        }
        public static Task<float?> GetInterval(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_DxDateBox_GetOption", dxTarget, "interval");
        }
        public static Task SetInterval(ElementReference dxTarget, float? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDateBox_SetOption", dxTarget, "interval", value);
        }
        public static Task<string> GetInvalidDateMessage(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxDateBox_GetOption", dxTarget, "invalidDateMessage");
        }
        public static Task SetInvalidDateMessage(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDateBox_SetOption", dxTarget, "invalidDateMessage", value);
        }
        public static Task<object> GetMax(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDateBox_GetOption", dxTarget, "max");
        }
        public static Task SetMax(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDateBox_SetOption", dxTarget, "max", value);
        }
        public static Task<string> GetMaxZoomLevel(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxDateBox_GetOption", dxTarget, "maxZoomLevel");
        }
        public static Task SetMaxZoomLevel(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDateBox_SetOption", dxTarget, "maxZoomLevel", value);
        }
        public static Task<object> GetMin(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDateBox_GetOption", dxTarget, "min");
        }
        public static Task SetMin(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDateBox_SetOption", dxTarget, "min", value);
        }
        public static Task<string> GetMinZoomLevel(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxDateBox_GetOption", dxTarget, "minZoomLevel");
        }
        public static Task SetMinZoomLevel(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDateBox_SetOption", dxTarget, "minZoomLevel", value);
        }
        public static Task<string> GetPickerType(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxDateBox_GetOption", dxTarget, "pickerType");
        }
        public static Task SetPickerType(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDateBox_SetOption", dxTarget, "pickerType", value);
        }
        public static Task<bool?> GetShowAnalogClock(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxDateBox_GetOption", dxTarget, "showAnalogClock");
        }
        public static Task SetShowAnalogClock(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDateBox_SetOption", dxTarget, "showAnalogClock", value);
        }
        public static Task<string> GetType(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxDateBox_GetOption", dxTarget, "type");
        }
        public static Task SetType(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDateBox_SetOption", dxTarget, "type", value);
        }
        public static Task Close(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDateBox_close_0", dxTarget);
        }
        public static Task Open(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDateBox_open_1", dxTarget);
        }
    }
    public class DxDeferRenderingInterop: WidgetInterop
    {
        public static event EventHandler<JQueryEventArgs> Rendered;
        public static event EventHandler<JQueryEventArgs> Shown;
        public static Task Init(ElementReference dxTarget, DevExpress.Ui.DxDeferRenderingOptions options)
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
        public static Task<object> GetAnimation(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDeferRendering_GetOption", dxTarget, "animation");
        }
        public static Task SetAnimation(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDeferRendering_SetOption", dxTarget, "animation", value);
        }
        public static Task<object> GetRenderWhen(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDeferRendering_GetOption", dxTarget, "renderWhen");
        }
        public static Task SetRenderWhen(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDeferRendering_SetOption", dxTarget, "renderWhen", value);
        }
        public static Task<bool?> GetShowLoadIndicator(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxDeferRendering_GetOption", dxTarget, "showLoadIndicator");
        }
        public static Task SetShowLoadIndicator(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDeferRendering_SetOption", dxTarget, "showLoadIndicator", value);
        }
        public static Task<string> GetStaggerItemSelector(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxDeferRendering_GetOption", dxTarget, "staggerItemSelector");
        }
        public static Task SetStaggerItemSelector(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDeferRendering_SetOption", dxTarget, "staggerItemSelector", value);
        }
    }
    public class DxDropDownBoxInterop: DxDropDownEditorInterop
    {
        public static Task Init(ElementReference dxTarget, DevExpress.Ui.DxDropDownBoxOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDropDownBox_Init", dxTarget, json);
        }
        public static Task<object> GetContentTemplate(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDropDownBox_GetOption", dxTarget, "contentTemplate");
        }
        public static Task SetContentTemplate(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDropDownBox_SetOption", dxTarget, "contentTemplate", value);
        }
        public static Task<object> GetDropDownOptions(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDropDownBox_GetOption", dxTarget, "dropDownOptions");
        }
        public static Task SetDropDownOptions(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDropDownBox_SetOption", dxTarget, "dropDownOptions", value);
        }
        public static Task<object> GetFieldTemplate(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDropDownBox_GetOption", dxTarget, "fieldTemplate");
        }
        public static Task SetFieldTemplate(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDropDownBox_SetOption", dxTarget, "fieldTemplate", value);
        }
        public static Task<object> GetDataSource(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDropDownBox_GetOption", dxTarget, "dataSource");
        }
        public static Task SetDataSource(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDropDownBox_SetOption", dxTarget, "dataSource", value);
        }
        public static Task<object> GetDisplayExpr(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDropDownBox_GetOption", dxTarget, "displayExpr");
        }
        public static Task SetDisplayExpr(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDropDownBox_SetOption", dxTarget, "displayExpr", value);
        }
        public static Task<object> GetItems(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDropDownBox_GetOption", dxTarget, "items");
        }
        public static Task SetItems(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDropDownBox_SetOption", dxTarget, "items", value);
        }
        public static Task<object> GetItemTemplate(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDropDownBox_GetOption", dxTarget, "itemTemplate");
        }
        public static Task SetItemTemplate(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDropDownBox_SetOption", dxTarget, "itemTemplate", value);
        }
        public static Task<object> GetValueExpr(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDropDownBox_GetOption", dxTarget, "valueExpr");
        }
        public static Task SetValueExpr(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDropDownBox_SetOption", dxTarget, "valueExpr", value);
        }
        public static Task<object> GetDataSourceEx(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDropDownBox_getDataSource_0", dxTarget);
        }
    }
    public class DxDropDownMenuInterop: WidgetInterop
    {
        public static event EventHandler<JQueryEventArgs> ButtonClick;
        public static event EventHandler<JQueryEventArgs> ItemClick;
        public static Task Init(ElementReference dxTarget, DevExpress.Ui.DxDropDownMenuOptions options)
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
        public static Task<string> GetButtonIcon(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxDropDownMenu_GetOption", dxTarget, "buttonIcon");
        }
        public static Task SetButtonIcon(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDropDownMenu_SetOption", dxTarget, "buttonIcon", value);
        }
        public static Task<string> GetButtonText(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxDropDownMenu_GetOption", dxTarget, "buttonText");
        }
        public static Task SetButtonText(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDropDownMenu_SetOption", dxTarget, "buttonText", value);
        }
        public static Task<object> GetDataSource(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDropDownMenu_GetOption", dxTarget, "dataSource");
        }
        public static Task SetDataSource(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDropDownMenu_SetOption", dxTarget, "dataSource", value);
        }
        public static Task<object> GetItems(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDropDownMenu_GetOption", dxTarget, "items");
        }
        public static Task SetItems(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDropDownMenu_SetOption", dxTarget, "items", value);
        }
        public static Task<object> GetItemTemplate(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDropDownMenu_GetOption", dxTarget, "itemTemplate");
        }
        public static Task SetItemTemplate(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDropDownMenu_SetOption", dxTarget, "itemTemplate", value);
        }
        public static Task<bool?> GetOpened(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxDropDownMenu_GetOption", dxTarget, "opened");
        }
        public static Task SetOpened(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDropDownMenu_SetOption", dxTarget, "opened", value);
        }
        public static Task<object> GetPopupHeight(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDropDownMenu_GetOption", dxTarget, "popupHeight");
        }
        public static Task SetPopupHeight(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDropDownMenu_SetOption", dxTarget, "popupHeight", value);
        }
        public static Task<object> GetPopupWidth(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDropDownMenu_GetOption", dxTarget, "popupWidth");
        }
        public static Task SetPopupWidth(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDropDownMenu_SetOption", dxTarget, "popupWidth", value);
        }
        public static Task<bool?> GetUsePopover(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxDropDownMenu_GetOption", dxTarget, "usePopover");
        }
        public static Task SetUsePopover(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDropDownMenu_SetOption", dxTarget, "usePopover", value);
        }
        public static Task Close(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDropDownMenu_close_0", dxTarget);
        }
        public static Task Open(ElementReference dxTarget)
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
        
        public static Task Init(ElementReference dxTarget, DevExpress.Ui.DxFileUploaderOptions options)
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

        public static Task<string> GetAccept(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxFileUploader_GetOption", dxTarget, "accept");
        }
        public static Task SetAccept(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxFileUploader_SetOption", dxTarget, "accept", value);
        }
        public static Task<bool?> GetAllowCanceling(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxFileUploader_GetOption", dxTarget, "allowCanceling");
        }
        public static Task SetAllowCanceling(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxFileUploader_SetOption", dxTarget, "allowCanceling", value);
        }
        public static Task<string> GetLabelText(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxFileUploader_GetOption", dxTarget, "labelText");
        }
        public static Task SetLabelText(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxFileUploader_SetOption", dxTarget, "labelText", value);
        }
        public static Task<bool?> GetMultiple(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxFileUploader_GetOption", dxTarget, "multiple");
        }
        public static Task SetMultiple(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxFileUploader_SetOption", dxTarget, "multiple", value);
        }
        public static Task<string> GetName(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxFileUploader_GetOption", dxTarget, "name");
        }
        public static Task SetName(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxFileUploader_SetOption", dxTarget, "name", value);
        }
        public static Task<float?> GetProgress(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_DxFileUploader_GetOption", dxTarget, "progress");
        }
        public static Task SetProgress(ElementReference dxTarget, float? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxFileUploader_SetOption", dxTarget, "progress", value);
        }
        public static Task<string> GetReadyToUploadMessage(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxFileUploader_GetOption", dxTarget, "readyToUploadMessage");
        }
        public static Task SetReadyToUploadMessage(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxFileUploader_SetOption", dxTarget, "readyToUploadMessage", value);
        }
        public static Task<string> GetSelectButtonText(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxFileUploader_GetOption", dxTarget, "selectButtonText");
        }
        public static Task SetSelectButtonText(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxFileUploader_SetOption", dxTarget, "selectButtonText", value);
        }
        public static Task<bool?> GetShowFileList(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxFileUploader_GetOption", dxTarget, "showFileList");
        }
        public static Task SetShowFileList(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxFileUploader_SetOption", dxTarget, "showFileList", value);
        }
        public static Task<string> GetUploadButtonText(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxFileUploader_GetOption", dxTarget, "uploadButtonText");
        }
        public static Task SetUploadButtonText(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxFileUploader_SetOption", dxTarget, "uploadButtonText", value);
        }
        public static Task<string> GetUploadedMessage(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxFileUploader_GetOption", dxTarget, "uploadedMessage");
        }
        public static Task SetUploadedMessage(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxFileUploader_SetOption", dxTarget, "uploadedMessage", value);
        }
        public static Task<string> GetUploadFailedMessage(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxFileUploader_GetOption", dxTarget, "uploadFailedMessage");
        }
        public static Task SetUploadFailedMessage(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxFileUploader_SetOption", dxTarget, "uploadFailedMessage", value);
        }
        public static Task<object> GetUploadHeaders(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxFileUploader_GetOption", dxTarget, "uploadHeaders");
        }
        public static Task SetUploadHeaders(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxFileUploader_SetOption", dxTarget, "uploadHeaders", value);
        }
        public static Task<string> GetUploadMethod(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxFileUploader_GetOption", dxTarget, "uploadMethod");
        }
        public static Task SetUploadMethod(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxFileUploader_SetOption", dxTarget, "uploadMethod", value);
        }
        public static Task<string> GetUploadMode(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxFileUploader_GetOption", dxTarget, "uploadMode");
        }
        public static Task SetUploadMode(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxFileUploader_SetOption", dxTarget, "uploadMode", value);
        }
        public static Task<string> GetUploadUrl(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxFileUploader_GetOption", dxTarget, "uploadUrl");
        }
        public static Task SetUploadUrl(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxFileUploader_SetOption", dxTarget, "uploadUrl", value);
        }
    }
    public class DxFilterBuilderInterop: WidgetInterop
    {
        public static event EventHandler<JQueryEventArgs> EditorPrepared;
        public static event EventHandler<JQueryEventArgs> EditorPreparing;
        public static event EventHandler<JQueryEventArgs> ValueChanged;
        public static Task Init(ElementReference dxTarget, DevExpress.Ui.DxFilterBuilderOptions options)
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
        public static Task<bool?> GetAllowHierarchicalFields(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxFilterBuilder_GetOption", dxTarget, "allowHierarchicalFields");
        }
        public static Task SetAllowHierarchicalFields(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxFilterBuilder_SetOption", dxTarget, "allowHierarchicalFields", value);
        }
        public static Task<object> GetCustomOperations(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxFilterBuilder_GetOption", dxTarget, "customOperations");
        }
        public static Task SetCustomOperations(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxFilterBuilder_SetOption", dxTarget, "customOperations", value);
        }
        public static Task<object> GetFields(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxFilterBuilder_GetOption", dxTarget, "fields");
        }
        public static Task SetFields(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxFilterBuilder_SetOption", dxTarget, "fields", value);
        }
        public static Task<object> GetFilterOperationDescriptions(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxFilterBuilder_GetOption", dxTarget, "filterOperationDescriptions");
        }
        public static Task SetFilterOperationDescriptions(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxFilterBuilder_SetOption", dxTarget, "filterOperationDescriptions", value);
        }
        public static Task<object> GetGroupOperationDescriptions(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxFilterBuilder_GetOption", dxTarget, "groupOperationDescriptions");
        }
        public static Task SetGroupOperationDescriptions(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxFilterBuilder_SetOption", dxTarget, "groupOperationDescriptions", value);
        }
        public static Task<object> GetValue(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxFilterBuilder_GetOption", dxTarget, "value");
        }
        public static Task SetValue(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxFilterBuilder_SetOption", dxTarget, "value", value);
        }
        public static Task<object> GetFilterExpression(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxFilterBuilder_getFilterExpression_0", dxTarget);
        }
    }
    public class DxFormInterop: WidgetInterop
    {
        public static event EventHandler<JQueryEventArgs> EditorEnterKey;
        public static event EventHandler<JQueryEventArgs> FieldDataChanged;
        public static Task Init(ElementReference dxTarget, DevExpress.Ui.DxFormOptions options)
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
        public static Task<bool?> GetAlignItemLabels(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxForm_GetOption", dxTarget, "alignItemLabels");
        }
        public static Task SetAlignItemLabels(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxForm_SetOption", dxTarget, "alignItemLabels", value);
        }
        public static Task<bool?> GetAlignItemLabelsInAllGroups(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxForm_GetOption", dxTarget, "alignItemLabelsInAllGroups");
        }
        public static Task SetAlignItemLabelsInAllGroups(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxForm_SetOption", dxTarget, "alignItemLabelsInAllGroups", value);
        }
        public static Task<object> GetColCount(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxForm_GetOption", dxTarget, "colCount");
        }
        public static Task SetColCount(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxForm_SetOption", dxTarget, "colCount", value);
        }
        public static Task<object> GetColCountByScreen(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxForm_GetOption", dxTarget, "colCountByScreen");
        }
        public static Task SetColCountByScreen(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxForm_SetOption", dxTarget, "colCountByScreen", value);
        }
        public static Task<object> GetCustomizeItem(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxForm_GetOption", dxTarget, "customizeItem");
        }
        public static Task SetCustomizeItem(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxForm_SetOption", dxTarget, "customizeItem", value);
        }
        public static Task<object> GetFormData(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxForm_GetOption", dxTarget, "formData");
        }
        public static Task SetFormData(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxForm_SetOption", dxTarget, "formData", value);
        }
        public static Task<object> GetItems(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxForm_GetOption", dxTarget, "items");
        }
        public static Task SetItems(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxForm_SetOption", dxTarget, "items", value);
        }
        public static Task<string> GetLabelLocation(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxForm_GetOption", dxTarget, "labelLocation");
        }
        public static Task SetLabelLocation(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxForm_SetOption", dxTarget, "labelLocation", value);
        }
        public static Task<float?> GetMinColWidth(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_DxForm_GetOption", dxTarget, "minColWidth");
        }
        public static Task SetMinColWidth(ElementReference dxTarget, float? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxForm_SetOption", dxTarget, "minColWidth", value);
        }
        public static Task<string> GetOptionalMark(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxForm_GetOption", dxTarget, "optionalMark");
        }
        public static Task SetOptionalMark(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxForm_SetOption", dxTarget, "optionalMark", value);
        }
        public static Task<bool?> GetReadOnly(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxForm_GetOption", dxTarget, "readOnly");
        }
        public static Task SetReadOnly(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxForm_SetOption", dxTarget, "readOnly", value);
        }
        public static Task<string> GetRequiredMark(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxForm_GetOption", dxTarget, "requiredMark");
        }
        public static Task SetRequiredMark(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxForm_SetOption", dxTarget, "requiredMark", value);
        }
        public static Task<string> GetRequiredMessage(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxForm_GetOption", dxTarget, "requiredMessage");
        }
        public static Task SetRequiredMessage(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxForm_SetOption", dxTarget, "requiredMessage", value);
        }
        public static Task<object> GetScreenByWidth(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxForm_GetOption", dxTarget, "screenByWidth");
        }
        public static Task SetScreenByWidth(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxForm_SetOption", dxTarget, "screenByWidth", value);
        }
        public static Task<bool?> GetScrollingEnabled(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxForm_GetOption", dxTarget, "scrollingEnabled");
        }
        public static Task SetScrollingEnabled(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxForm_SetOption", dxTarget, "scrollingEnabled", value);
        }
        public static Task<bool?> GetShowColonAfterLabel(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxForm_GetOption", dxTarget, "showColonAfterLabel");
        }
        public static Task SetShowColonAfterLabel(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxForm_SetOption", dxTarget, "showColonAfterLabel", value);
        }
        public static Task<bool?> GetShowOptionalMark(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxForm_GetOption", dxTarget, "showOptionalMark");
        }
        public static Task SetShowOptionalMark(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxForm_SetOption", dxTarget, "showOptionalMark", value);
        }
        public static Task<bool?> GetShowRequiredMark(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxForm_GetOption", dxTarget, "showRequiredMark");
        }
        public static Task SetShowRequiredMark(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxForm_SetOption", dxTarget, "showRequiredMark", value);
        }
        public static Task<bool?> GetShowValidationSummary(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxForm_GetOption", dxTarget, "showValidationSummary");
        }
        public static Task SetShowValidationSummary(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxForm_SetOption", dxTarget, "showValidationSummary", value);
        }
        public static Task<string> GetValidationGroup(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxForm_GetOption", dxTarget, "validationGroup");
        }
        public static Task SetValidationGroup(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxForm_SetOption", dxTarget, "validationGroup", value);
        }
        public static Task<object> GetEditor(ElementReference dxTarget, string dataField)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxForm_getEditor_0", dxTarget, dataField);
        }
        public static Task<object> ItemOption(ElementReference dxTarget, string id)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxForm_itemOption_1", dxTarget, id);
        }
        public static Task ItemOption(ElementReference dxTarget, string id, string option, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxForm_itemOption_2", dxTarget, id, option, value);
        }
        public static Task ItemOption(ElementReference dxTarget, string id, object options)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxForm_itemOption_3", dxTarget, id, options);
        }
        public static Task ResetValues(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxForm_resetValues_4", dxTarget);
        }
        public static Task UpdateData(ElementReference dxTarget, object data)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxForm_updateData_5", dxTarget, data);
        }
        public static Task UpdateData(ElementReference dxTarget, string dataField, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxForm_updateData_6", dxTarget, dataField, value);
        }
        public static Task<object> UpdateDimensions(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxForm_updateDimensions_7", dxTarget);
        }
        public static Task<object> Validate(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxForm_validate_8", dxTarget);
        }
    }
    public class DxGalleryInterop: CollectionWidgetInterop
    {
        public static Task Init(ElementReference dxTarget, DevExpress.Ui.DxGalleryOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxGallery_Init", dxTarget, json);
        }
        public static Task<float?> GetAnimationDuration(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_DxGallery_GetOption", dxTarget, "animationDuration");
        }
        public static Task SetAnimationDuration(ElementReference dxTarget, float? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxGallery_SetOption", dxTarget, "animationDuration", value);
        }
        public static Task<bool?> GetAnimationEnabled(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxGallery_GetOption", dxTarget, "animationEnabled");
        }
        public static Task SetAnimationEnabled(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxGallery_SetOption", dxTarget, "animationEnabled", value);
        }
        public static Task<bool?> GetIndicatorEnabled(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxGallery_GetOption", dxTarget, "indicatorEnabled");
        }
        public static Task SetIndicatorEnabled(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxGallery_SetOption", dxTarget, "indicatorEnabled", value);
        }
        public static Task<float?> GetInitialItemWidth(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_DxGallery_GetOption", dxTarget, "initialItemWidth");
        }
        public static Task SetInitialItemWidth(ElementReference dxTarget, float? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxGallery_SetOption", dxTarget, "initialItemWidth", value);
        }
        public static Task<bool?> GetLoop(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxGallery_GetOption", dxTarget, "loop");
        }
        public static Task SetLoop(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxGallery_SetOption", dxTarget, "loop", value);
        }
        public static Task<bool?> GetShowIndicator(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxGallery_GetOption", dxTarget, "showIndicator");
        }
        public static Task SetShowIndicator(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxGallery_SetOption", dxTarget, "showIndicator", value);
        }
        public static Task<bool?> GetShowNavButtons(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxGallery_GetOption", dxTarget, "showNavButtons");
        }
        public static Task SetShowNavButtons(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxGallery_SetOption", dxTarget, "showNavButtons", value);
        }
        public static Task<float?> GetSlideshowDelay(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_DxGallery_GetOption", dxTarget, "slideshowDelay");
        }
        public static Task SetSlideshowDelay(ElementReference dxTarget, float? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxGallery_SetOption", dxTarget, "slideshowDelay", value);
        }
        public static Task<bool?> GetStretchImages(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxGallery_GetOption", dxTarget, "stretchImages");
        }
        public static Task SetStretchImages(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxGallery_SetOption", dxTarget, "stretchImages", value);
        }
        public static Task<bool?> GetSwipeEnabled(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxGallery_GetOption", dxTarget, "swipeEnabled");
        }
        public static Task SetSwipeEnabled(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxGallery_SetOption", dxTarget, "swipeEnabled", value);
        }
        public static Task<bool?> GetWrapAround(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxGallery_GetOption", dxTarget, "wrapAround");
        }
        public static Task SetWrapAround(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxGallery_SetOption", dxTarget, "wrapAround", value);
        }
        public static Task<object> GoToItem(ElementReference dxTarget, float itemIndex, bool animation)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxGallery_goToItem_0", dxTarget, itemIndex, animation);
        }
        public static Task<object> NextItem(ElementReference dxTarget, bool animation)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxGallery_nextItem_1", dxTarget, animation);
        }
        public static Task<object> PrevItem(ElementReference dxTarget, bool animation)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxGallery_prevItem_2", dxTarget, animation);
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
        public static Task Init(ElementReference dxTarget, DevExpress.Ui.DxListOptions options)
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
        public static Task<bool?> GetAllowItemDeleting(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxList_GetOption", dxTarget, "allowItemDeleting");
        }
        public static Task SetAllowItemDeleting(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxList_SetOption", dxTarget, "allowItemDeleting", value);
        }
        public static Task<bool?> GetAllowItemReordering(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxList_GetOption", dxTarget, "allowItemReordering");
        }
        public static Task SetAllowItemReordering(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxList_SetOption", dxTarget, "allowItemReordering", value);
        }
        public static Task<bool?> GetBounceEnabled(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxList_GetOption", dxTarget, "bounceEnabled");
        }
        public static Task SetBounceEnabled(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxList_SetOption", dxTarget, "bounceEnabled", value);
        }
        public static Task<bool?> GetCollapsibleGroups(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxList_GetOption", dxTarget, "collapsibleGroups");
        }
        public static Task SetCollapsibleGroups(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxList_SetOption", dxTarget, "collapsibleGroups", value);
        }
        public static Task<bool?> GetGrouped(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxList_GetOption", dxTarget, "grouped");
        }
        public static Task SetGrouped(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxList_SetOption", dxTarget, "grouped", value);
        }
        public static Task<object> GetGroupTemplate(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxList_GetOption", dxTarget, "groupTemplate");
        }
        public static Task SetGroupTemplate(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxList_SetOption", dxTarget, "groupTemplate", value);
        }
        public static Task<bool?> GetIndicateLoading(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxList_GetOption", dxTarget, "indicateLoading");
        }
        public static Task SetIndicateLoading(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxList_SetOption", dxTarget, "indicateLoading", value);
        }
        public static Task<string> GetItemDeleteMode(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxList_GetOption", dxTarget, "itemDeleteMode");
        }
        public static Task SetItemDeleteMode(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxList_SetOption", dxTarget, "itemDeleteMode", value);
        }
        public static Task<object> GetMenuItems(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxList_GetOption", dxTarget, "menuItems");
        }
        public static Task SetMenuItems(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxList_SetOption", dxTarget, "menuItems", value);
        }
        public static Task<string> GetMenuMode(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxList_GetOption", dxTarget, "menuMode");
        }
        public static Task SetMenuMode(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxList_SetOption", dxTarget, "menuMode", value);
        }
        public static Task<string> GetNextButtonText(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxList_GetOption", dxTarget, "nextButtonText");
        }
        public static Task SetNextButtonText(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxList_SetOption", dxTarget, "nextButtonText", value);
        }
        public static Task<string> GetPageLoadingText(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxList_GetOption", dxTarget, "pageLoadingText");
        }
        public static Task SetPageLoadingText(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxList_SetOption", dxTarget, "pageLoadingText", value);
        }
        public static Task<string> GetPageLoadMode(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxList_GetOption", dxTarget, "pageLoadMode");
        }
        public static Task SetPageLoadMode(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxList_SetOption", dxTarget, "pageLoadMode", value);
        }
        public static Task<string> GetPulledDownText(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxList_GetOption", dxTarget, "pulledDownText");
        }
        public static Task SetPulledDownText(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxList_SetOption", dxTarget, "pulledDownText", value);
        }
        public static Task<string> GetPullingDownText(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxList_GetOption", dxTarget, "pullingDownText");
        }
        public static Task SetPullingDownText(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxList_SetOption", dxTarget, "pullingDownText", value);
        }
        public static Task<bool?> GetPullRefreshEnabled(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxList_GetOption", dxTarget, "pullRefreshEnabled");
        }
        public static Task SetPullRefreshEnabled(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxList_SetOption", dxTarget, "pullRefreshEnabled", value);
        }
        public static Task<string> GetRefreshingText(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxList_GetOption", dxTarget, "refreshingText");
        }
        public static Task SetRefreshingText(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxList_SetOption", dxTarget, "refreshingText", value);
        }
        public static Task<bool?> GetScrollByContent(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxList_GetOption", dxTarget, "scrollByContent");
        }
        public static Task SetScrollByContent(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxList_SetOption", dxTarget, "scrollByContent", value);
        }
        public static Task<bool?> GetScrollByThumb(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxList_GetOption", dxTarget, "scrollByThumb");
        }
        public static Task SetScrollByThumb(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxList_SetOption", dxTarget, "scrollByThumb", value);
        }
        public static Task<bool?> GetScrollingEnabled(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxList_GetOption", dxTarget, "scrollingEnabled");
        }
        public static Task SetScrollingEnabled(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxList_SetOption", dxTarget, "scrollingEnabled", value);
        }
        public static Task<string> GetSelectAllMode(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxList_GetOption", dxTarget, "selectAllMode");
        }
        public static Task SetSelectAllMode(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxList_SetOption", dxTarget, "selectAllMode", value);
        }
        public static Task<string> GetSelectionMode(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxList_GetOption", dxTarget, "selectionMode");
        }
        public static Task SetSelectionMode(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxList_SetOption", dxTarget, "selectionMode", value);
        }
        public static Task<string> GetShowScrollbar(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxList_GetOption", dxTarget, "showScrollbar");
        }
        public static Task SetShowScrollbar(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxList_SetOption", dxTarget, "showScrollbar", value);
        }
        public static Task<bool?> GetShowSelectionControls(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxList_GetOption", dxTarget, "showSelectionControls");
        }
        public static Task SetShowSelectionControls(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxList_SetOption", dxTarget, "showSelectionControls", value);
        }
        public static Task<bool?> GetUseNativeScrolling(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxList_GetOption", dxTarget, "useNativeScrolling");
        }
        public static Task SetUseNativeScrolling(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxList_SetOption", dxTarget, "useNativeScrolling", value);
        }
        public static Task<object> GetSearchEditorOptions(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxList_GetOption", dxTarget, "searchEditorOptions");
        }
        public static Task SetSearchEditorOptions(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxList_SetOption", dxTarget, "searchEditorOptions", value);
        }
        public static Task<bool?> GetSearchEnabled(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxList_GetOption", dxTarget, "searchEnabled");
        }
        public static Task SetSearchEnabled(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxList_SetOption", dxTarget, "searchEnabled", value);
        }
        public static Task<object> GetSearchExpr(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxList_GetOption", dxTarget, "searchExpr");
        }
        public static Task SetSearchExpr(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxList_SetOption", dxTarget, "searchExpr", value);
        }
        public static Task<string> GetSearchMode(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxList_GetOption", dxTarget, "searchMode");
        }
        public static Task SetSearchMode(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxList_SetOption", dxTarget, "searchMode", value);
        }
        public static Task<float?> GetSearchTimeout(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_DxList_GetOption", dxTarget, "searchTimeout");
        }
        public static Task SetSearchTimeout(ElementReference dxTarget, float? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxList_SetOption", dxTarget, "searchTimeout", value);
        }
        public static Task<string> GetSearchValue(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxList_GetOption", dxTarget, "searchValue");
        }
        public static Task SetSearchValue(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxList_SetOption", dxTarget, "searchValue", value);
        }
        public static Task<float> ClientHeight(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<float>("BlazorDevExtreme_DxList_clientHeight_0", dxTarget);
        }
        public static Task<object> CollapseGroup(ElementReference dxTarget, float groupIndex)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxList_collapseGroup_1", dxTarget, groupIndex);
        }
        public static Task<object> DeleteItem(ElementReference dxTarget, object itemElement)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxList_deleteItem_2", dxTarget, itemElement);
        }
        public static Task<object> ExpandGroup(ElementReference dxTarget, float groupIndex)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxList_expandGroup_4", dxTarget, groupIndex);
        }
        public static Task<bool> IsItemSelected(ElementReference dxTarget, object itemElement)
        {
            return JSRuntime.Current.InvokeAsync<bool>("BlazorDevExtreme_DxList_isItemSelected_5", dxTarget, itemElement);
        }
        public static Task Reload(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxList_reload_7", dxTarget);
        }
        public static Task<object> ReorderItem(ElementReference dxTarget, object itemElement, object toItemElement)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxList_reorderItem_8", dxTarget, itemElement, toItemElement);
        }
        public static Task ScrollBy(ElementReference dxTarget, float distance)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxList_scrollBy_10", dxTarget, distance);
        }
        public static Task<float> ScrollHeight(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<float>("BlazorDevExtreme_DxList_scrollHeight_11", dxTarget);
        }
        public static Task ScrollTo(ElementReference dxTarget, float location)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxList_scrollTo_12", dxTarget, location);
        }
        public static Task ScrollToItem(ElementReference dxTarget, object itemElement)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxList_scrollToItem_13", dxTarget, itemElement);
        }
        public static Task<float> ScrollTop(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<float>("BlazorDevExtreme_DxList_scrollTop_15", dxTarget);
        }
        public static Task SelectAll(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxList_selectAll_16", dxTarget);
        }
        public static Task SelectItem(ElementReference dxTarget, object itemElement)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxList_selectItem_17", dxTarget, itemElement);
        }
        public static Task UnselectAll(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxList_unselectAll_19", dxTarget);
        }
        public static Task UnselectItem(ElementReference dxTarget, object itemElement)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxList_unselectItem_20", dxTarget, itemElement);
        }
        public static Task<object> UpdateDimensions(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxList_updateDimensions_22", dxTarget);
        }
    }
    public class DxLoadIndicatorInterop: WidgetInterop
    {
        public static Task Init(ElementReference dxTarget, DevExpress.Ui.DxLoadIndicatorOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxLoadIndicator_Init", dxTarget, json);
        }
        public static Task<string> GetIndicatorSrc(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxLoadIndicator_GetOption", dxTarget, "indicatorSrc");
        }
        public static Task SetIndicatorSrc(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxLoadIndicator_SetOption", dxTarget, "indicatorSrc", value);
        }
    }
    public class DxLoadPanelInterop: DxOverlayInterop
    {
        public static Task Init(ElementReference dxTarget, DevExpress.Ui.DxLoadPanelOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxLoadPanel_Init", dxTarget, json);
        }
        public static Task<float?> GetDelay(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_DxLoadPanel_GetOption", dxTarget, "delay");
        }
        public static Task SetDelay(ElementReference dxTarget, float? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxLoadPanel_SetOption", dxTarget, "delay", value);
        }
        public static Task<string> GetIndicatorSrc(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxLoadPanel_GetOption", dxTarget, "indicatorSrc");
        }
        public static Task SetIndicatorSrc(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxLoadPanel_SetOption", dxTarget, "indicatorSrc", value);
        }
        public static Task<string> GetMessage(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxLoadPanel_GetOption", dxTarget, "message");
        }
        public static Task SetMessage(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxLoadPanel_SetOption", dxTarget, "message", value);
        }
        public static Task<bool?> GetShowIndicator(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxLoadPanel_GetOption", dxTarget, "showIndicator");
        }
        public static Task SetShowIndicator(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxLoadPanel_SetOption", dxTarget, "showIndicator", value);
        }
        public static Task<bool?> GetShowPane(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxLoadPanel_GetOption", dxTarget, "showPane");
        }
        public static Task SetShowPane(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxLoadPanel_SetOption", dxTarget, "showPane", value);
        }

        public static new Task SetVisible(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Widget_SetOption", dxTarget, "visible", value);
        }
    }
    public class DxLookupInterop: DxDropDownListInterop
    {
        public static event EventHandler<JQueryEventArgs> PageLoading;
        public static event EventHandler<JQueryEventArgs> PullRefresh;
        public static event EventHandler<JQueryEventArgs> Scroll;
        public static event EventHandler<JQueryEventArgs> TitleRendered;
        public static Task Init(ElementReference dxTarget, DevExpress.Ui.DxLookupOptions options)
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
        public static Task<object> GetAnimation(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxLookup_GetOption", dxTarget, "animation");
        }
        public static Task SetAnimation(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxLookup_SetOption", dxTarget, "animation", value);
        }
        public static Task<string> GetApplyButtonText(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxLookup_GetOption", dxTarget, "applyButtonText");
        }
        public static Task SetApplyButtonText(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxLookup_SetOption", dxTarget, "applyButtonText", value);
        }
        public static Task<string> GetCancelButtonText(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxLookup_GetOption", dxTarget, "cancelButtonText");
        }
        public static Task SetCancelButtonText(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxLookup_SetOption", dxTarget, "cancelButtonText", value);
        }
        public static Task<bool?> GetCleanSearchOnOpening(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxLookup_GetOption", dxTarget, "cleanSearchOnOpening");
        }
        public static Task SetCleanSearchOnOpening(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxLookup_SetOption", dxTarget, "cleanSearchOnOpening", value);
        }
        public static Task<string> GetClearButtonText(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxLookup_GetOption", dxTarget, "clearButtonText");
        }
        public static Task SetClearButtonText(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxLookup_SetOption", dxTarget, "clearButtonText", value);
        }
        public static Task<object> GetCloseOnOutsideClick(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxLookup_GetOption", dxTarget, "closeOnOutsideClick");
        }
        public static Task SetCloseOnOutsideClick(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxLookup_SetOption", dxTarget, "closeOnOutsideClick", value);
        }
        public static Task<object> GetFieldTemplate(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxLookup_GetOption", dxTarget, "fieldTemplate");
        }
        public static Task SetFieldTemplate(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxLookup_SetOption", dxTarget, "fieldTemplate", value);
        }
        public static Task<bool?> GetFullScreen(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxLookup_GetOption", dxTarget, "fullScreen");
        }
        public static Task SetFullScreen(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxLookup_SetOption", dxTarget, "fullScreen", value);
        }
        public static Task<string> GetNextButtonText(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxLookup_GetOption", dxTarget, "nextButtonText");
        }
        public static Task SetNextButtonText(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxLookup_SetOption", dxTarget, "nextButtonText", value);
        }
        public static Task<string> GetPageLoadingText(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxLookup_GetOption", dxTarget, "pageLoadingText");
        }
        public static Task SetPageLoadingText(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxLookup_SetOption", dxTarget, "pageLoadingText", value);
        }
        public static Task<string> GetPageLoadMode(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxLookup_GetOption", dxTarget, "pageLoadMode");
        }
        public static Task SetPageLoadMode(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxLookup_SetOption", dxTarget, "pageLoadMode", value);
        }
        public static Task<object> GetPopupHeight(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxLookup_GetOption", dxTarget, "popupHeight");
        }
        public static Task SetPopupHeight(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxLookup_SetOption", dxTarget, "popupHeight", value);
        }
        public static Task<object> GetPopupWidth(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxLookup_GetOption", dxTarget, "popupWidth");
        }
        public static Task SetPopupWidth(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxLookup_SetOption", dxTarget, "popupWidth", value);
        }
        public static Task<object> GetPosition(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxLookup_GetOption", dxTarget, "position");
        }
        public static Task SetPosition(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxLookup_SetOption", dxTarget, "position", value);
        }
        public static Task<string> GetPulledDownText(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxLookup_GetOption", dxTarget, "pulledDownText");
        }
        public static Task SetPulledDownText(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxLookup_SetOption", dxTarget, "pulledDownText", value);
        }
        public static Task<string> GetPullingDownText(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxLookup_GetOption", dxTarget, "pullingDownText");
        }
        public static Task SetPullingDownText(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxLookup_SetOption", dxTarget, "pullingDownText", value);
        }
        public static Task<bool?> GetPullRefreshEnabled(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxLookup_GetOption", dxTarget, "pullRefreshEnabled");
        }
        public static Task SetPullRefreshEnabled(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxLookup_SetOption", dxTarget, "pullRefreshEnabled", value);
        }
        public static Task<string> GetRefreshingText(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxLookup_GetOption", dxTarget, "refreshingText");
        }
        public static Task SetRefreshingText(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxLookup_SetOption", dxTarget, "refreshingText", value);
        }
        public static Task<string> GetSearchPlaceholder(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxLookup_GetOption", dxTarget, "searchPlaceholder");
        }
        public static Task SetSearchPlaceholder(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxLookup_SetOption", dxTarget, "searchPlaceholder", value);
        }
        public static Task<bool?> GetShading(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxLookup_GetOption", dxTarget, "shading");
        }
        public static Task SetShading(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxLookup_SetOption", dxTarget, "shading", value);
        }
        public static Task<bool?> GetShowCancelButton(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxLookup_GetOption", dxTarget, "showCancelButton");
        }
        public static Task SetShowCancelButton(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxLookup_SetOption", dxTarget, "showCancelButton", value);
        }
        public static Task<bool?> GetShowPopupTitle(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxLookup_GetOption", dxTarget, "showPopupTitle");
        }
        public static Task SetShowPopupTitle(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxLookup_SetOption", dxTarget, "showPopupTitle", value);
        }
        public static Task<string> GetTitle(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxLookup_GetOption", dxTarget, "title");
        }
        public static Task SetTitle(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxLookup_SetOption", dxTarget, "title", value);
        }
        public static Task<object> GetTitleTemplate(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxLookup_GetOption", dxTarget, "titleTemplate");
        }
        public static Task SetTitleTemplate(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxLookup_SetOption", dxTarget, "titleTemplate", value);
        }
        public static Task<bool?> GetUseNativeScrolling(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxLookup_GetOption", dxTarget, "useNativeScrolling");
        }
        public static Task SetUseNativeScrolling(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxLookup_SetOption", dxTarget, "useNativeScrolling", value);
        }
        public static Task<bool?> GetUsePopover(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxLookup_GetOption", dxTarget, "usePopover");
        }
        public static Task SetUsePopover(ElementReference dxTarget, bool? value)
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
        public static Task Init(ElementReference dxTarget, DevExpress.Ui.DxMapOptions options)
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
        public static Task<bool?> GetAutoAdjust(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxMap_GetOption", dxTarget, "autoAdjust");
        }
        public static Task SetAutoAdjust(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxMap_SetOption", dxTarget, "autoAdjust", value);
        }
        public static Task<object> GetCenter(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxMap_GetOption", dxTarget, "center");
        }
        public static Task SetCenter(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxMap_SetOption", dxTarget, "center", value);
        }
        public static Task<bool?> GetControls(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxMap_GetOption", dxTarget, "controls");
        }
        public static Task SetControls(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxMap_SetOption", dxTarget, "controls", value);
        }
        public static Task<object> GetKey(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxMap_GetOption", dxTarget, "key");
        }
        public static Task SetKey(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxMap_SetOption", dxTarget, "key", value);
        }
        public static Task<string> GetMarkerIconSrc(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxMap_GetOption", dxTarget, "markerIconSrc");
        }
        public static Task SetMarkerIconSrc(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxMap_SetOption", dxTarget, "markerIconSrc", value);
        }
        public static Task<object> GetMarkers(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxMap_GetOption", dxTarget, "markers");
        }
        public static Task SetMarkers(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxMap_SetOption", dxTarget, "markers", value);
        }
        public static Task<string> GetProvider(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxMap_GetOption", dxTarget, "provider");
        }
        public static Task SetProvider(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxMap_SetOption", dxTarget, "provider", value);
        }
        public static Task<object> GetRoutes(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxMap_GetOption", dxTarget, "routes");
        }
        public static Task SetRoutes(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxMap_SetOption", dxTarget, "routes", value);
        }
        public static Task<string> GetType(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxMap_GetOption", dxTarget, "type");
        }
        public static Task SetType(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxMap_SetOption", dxTarget, "type", value);
        }
        public static Task<float?> GetZoom(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_DxMap_GetOption", dxTarget, "zoom");
        }
        public static Task SetZoom(ElementReference dxTarget, float? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxMap_SetOption", dxTarget, "zoom", value);
        }
        public static Task<object> AddMarker(ElementReference dxTarget, object markerOptions)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxMap_addMarker_0", dxTarget, markerOptions);
        }
        public static Task<object> AddRoute(ElementReference dxTarget, object options)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxMap_addRoute_1", dxTarget, options);
        }
        public static Task<object> RemoveMarker(ElementReference dxTarget, object marker)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxMap_removeMarker_2", dxTarget, marker);
        }
        public static Task<object> RemoveRoute(ElementReference dxTarget, object route)
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
        public static Task Init(ElementReference dxTarget, DevExpress.Ui.DxMenuOptions options)
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
        public static Task<bool?> GetAdaptivityEnabled(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxMenu_GetOption", dxTarget, "adaptivityEnabled");
        }
        public static Task SetAdaptivityEnabled(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxMenu_SetOption", dxTarget, "adaptivityEnabled", value);
        }
        public static Task<bool?> GetHideSubmenuOnMouseLeave(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxMenu_GetOption", dxTarget, "hideSubmenuOnMouseLeave");
        }
        public static Task SetHideSubmenuOnMouseLeave(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxMenu_SetOption", dxTarget, "hideSubmenuOnMouseLeave", value);
        }
        public static Task<string> GetOrientation(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxMenu_GetOption", dxTarget, "orientation");
        }
        public static Task SetOrientation(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxMenu_SetOption", dxTarget, "orientation", value);
        }
        public static Task<object> GetShowFirstSubmenuMode(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxMenu_GetOption", dxTarget, "showFirstSubmenuMode");
        }
        public static Task SetShowFirstSubmenuMode(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxMenu_SetOption", dxTarget, "showFirstSubmenuMode", value);
        }
        public static Task<string> GetSubmenuDirection(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxMenu_GetOption", dxTarget, "submenuDirection");
        }
        public static Task SetSubmenuDirection(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxMenu_SetOption", dxTarget, "submenuDirection", value);
        }
    }
    public class DxMultiViewInterop: CollectionWidgetInterop
    {
        public static Task Init(ElementReference dxTarget, DevExpress.Ui.DxMultiViewOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxMultiView_Init", dxTarget, json);
        }
        public static Task<bool?> GetAnimationEnabled(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxMultiView_GetOption", dxTarget, "animationEnabled");
        }
        public static Task SetAnimationEnabled(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxMultiView_SetOption", dxTarget, "animationEnabled", value);
        }
        public static Task<bool?> GetDeferRendering(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxMultiView_GetOption", dxTarget, "deferRendering");
        }
        public static Task SetDeferRendering(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxMultiView_SetOption", dxTarget, "deferRendering", value);
        }
        public static Task<bool?> GetLoop(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxMultiView_GetOption", dxTarget, "loop");
        }
        public static Task SetLoop(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxMultiView_SetOption", dxTarget, "loop", value);
        }
        public static Task<bool?> GetSwipeEnabled(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxMultiView_GetOption", dxTarget, "swipeEnabled");
        }
        public static Task SetSwipeEnabled(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxMultiView_SetOption", dxTarget, "swipeEnabled", value);
        }
    }
    public class DxNavBarInterop: DxTabsInterop
    {
        public static Task Init(ElementReference dxTarget, DevExpress.Ui.DxNavBarOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxNavBar_Init", dxTarget, json);
        }
    }
    public class DxNumberBoxInterop: DxTextEditorInterop
    {
        public static Task Init(ElementReference dxTarget, DevExpress.Ui.DxNumberBoxOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxNumberBox_Init", dxTarget, json);
        }
        public static Task<object> GetFormat(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxNumberBox_GetOption", dxTarget, "format");
        }
        public static Task SetFormat(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxNumberBox_SetOption", dxTarget, "format", value);
        }
        public static Task<string> GetInvalidValueMessage(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxNumberBox_GetOption", dxTarget, "invalidValueMessage");
        }
        public static Task SetInvalidValueMessage(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxNumberBox_SetOption", dxTarget, "invalidValueMessage", value);
        }
        public static Task<float?> GetMax(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_DxNumberBox_GetOption", dxTarget, "max");
        }
        public static Task SetMax(ElementReference dxTarget, float? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxNumberBox_SetOption", dxTarget, "max", value);
        }
        public static Task<float?> GetMin(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_DxNumberBox_GetOption", dxTarget, "min");
        }
        public static Task SetMin(ElementReference dxTarget, float? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxNumberBox_SetOption", dxTarget, "min", value);
        }
        public static Task<string> GetMode(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxNumberBox_GetOption", dxTarget, "mode");
        }
        public static Task SetMode(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxNumberBox_SetOption", dxTarget, "mode", value);
        }
        public static Task<bool?> GetShowSpinButtons(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxNumberBox_GetOption", dxTarget, "showSpinButtons");
        }
        public static Task SetShowSpinButtons(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxNumberBox_SetOption", dxTarget, "showSpinButtons", value);
        }
        public static Task<float?> GetStep(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_DxNumberBox_GetOption", dxTarget, "step");
        }
        public static Task SetStep(ElementReference dxTarget, float? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxNumberBox_SetOption", dxTarget, "step", value);
        }
        public static Task<bool?> GetUseLargeSpinButtons(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxNumberBox_GetOption", dxTarget, "useLargeSpinButtons");
        }
        public static Task SetUseLargeSpinButtons(ElementReference dxTarget, bool? value)
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
        public static Task Init(ElementReference dxTarget, DevExpress.Ui.DxOverlayOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxOverlay_Init", dxTarget, json);
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
        public static Task<object> GetAnimation(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxOverlay_GetOption", dxTarget, "animation");
        }
        public static Task SetAnimation(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxOverlay_SetOption", dxTarget, "animation", value);
        }
        public static Task<bool?> GetCloseOnBackButton(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxOverlay_GetOption", dxTarget, "closeOnBackButton");
        }
        public static Task SetCloseOnBackButton(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxOverlay_SetOption", dxTarget, "closeOnBackButton", value);
        }
        public static Task<object> GetCloseOnOutsideClick(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxOverlay_GetOption", dxTarget, "closeOnOutsideClick");
        }
        public static Task SetCloseOnOutsideClick(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxOverlay_SetOption", dxTarget, "closeOnOutsideClick", value);
        }
        public static Task<object> GetContentTemplate(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxOverlay_GetOption", dxTarget, "contentTemplate");
        }
        public static Task SetContentTemplate(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxOverlay_SetOption", dxTarget, "contentTemplate", value);
        }
        public static Task<bool?> GetDeferRendering(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxOverlay_GetOption", dxTarget, "deferRendering");
        }
        public static Task SetDeferRendering(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxOverlay_SetOption", dxTarget, "deferRendering", value);
        }
        public static Task<bool?> GetDragEnabled(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxOverlay_GetOption", dxTarget, "dragEnabled");
        }
        public static Task SetDragEnabled(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxOverlay_SetOption", dxTarget, "dragEnabled", value);
        }
        public static Task<object> GetMaxHeight(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxOverlay_GetOption", dxTarget, "maxHeight");
        }
        public static Task SetMaxHeight(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxOverlay_SetOption", dxTarget, "maxHeight", value);
        }
        public static Task<object> GetMaxWidth(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxOverlay_GetOption", dxTarget, "maxWidth");
        }
        public static Task SetMaxWidth(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxOverlay_SetOption", dxTarget, "maxWidth", value);
        }
        public static Task<object> GetMinHeight(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxOverlay_GetOption", dxTarget, "minHeight");
        }
        public static Task SetMinHeight(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxOverlay_SetOption", dxTarget, "minHeight", value);
        }
        public static Task<object> GetMinWidth(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxOverlay_GetOption", dxTarget, "minWidth");
        }
        public static Task SetMinWidth(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxOverlay_SetOption", dxTarget, "minWidth", value);
        }
        public static Task<object> GetPosition(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxOverlay_GetOption", dxTarget, "position");
        }
        public static Task SetPosition(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxOverlay_SetOption", dxTarget, "position", value);
        }
        public static Task<bool?> GetShading(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxOverlay_GetOption", dxTarget, "shading");
        }
        public static Task SetShading(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxOverlay_SetOption", dxTarget, "shading", value);
        }
        public static Task<string> GetShadingColor(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxOverlay_GetOption", dxTarget, "shadingColor");
        }
        public static Task SetShadingColor(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxOverlay_SetOption", dxTarget, "shadingColor", value);
        }
        public static Task<object> Content(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxOverlay_content_0", dxTarget);
        }
        public static Task<object> Hide(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxOverlay_hide_1", dxTarget);
        }
        public static Task Repaint(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxOverlay_repaint_2", dxTarget);
        }
        public static Task<object> Show(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxOverlay_show_3", dxTarget);
        }
        public static Task<object> Toggle(ElementReference dxTarget, bool showing)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxOverlay_toggle_4", dxTarget, showing);
        }
    }
    public class DxPanoramaInterop: CollectionWidgetInterop
    {
        public static Task Init(ElementReference dxTarget, DevExpress.Ui.DxPanoramaOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPanorama_Init", dxTarget, json);
        }
        public static Task<object> GetBackgroundImage(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPanorama_GetOption", dxTarget, "backgroundImage");
        }
        public static Task SetBackgroundImage(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPanorama_SetOption", dxTarget, "backgroundImage", value);
        }
        public static Task<string> GetTitle(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxPanorama_GetOption", dxTarget, "title");
        }
        public static Task SetTitle(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPanorama_SetOption", dxTarget, "title", value);
        }
    }
    public class DxPivotInterop: CollectionWidgetInterop
    {
        public static Task Init(ElementReference dxTarget, DevExpress.Ui.DxPivotOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPivot_Init", dxTarget, json);
        }
        public static Task<object> GetContentTemplate(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPivot_GetOption", dxTarget, "contentTemplate");
        }
        public static Task SetContentTemplate(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPivot_SetOption", dxTarget, "contentTemplate", value);
        }
        public static Task<object> GetItemTitleTemplate(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPivot_GetOption", dxTarget, "itemTitleTemplate");
        }
        public static Task SetItemTitleTemplate(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPivot_SetOption", dxTarget, "itemTitleTemplate", value);
        }
        public static Task<bool?> GetSwipeEnabled(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxPivot_GetOption", dxTarget, "swipeEnabled");
        }
        public static Task SetSwipeEnabled(ElementReference dxTarget, bool? value)
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
        public static Task Init(ElementReference dxTarget, DevExpress.Ui.DxPivotGridOptions options)
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
        public static Task<bool?> GetAllowExpandAll(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxPivotGrid_GetOption", dxTarget, "allowExpandAll");
        }
        public static Task SetAllowExpandAll(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPivotGrid_SetOption", dxTarget, "allowExpandAll", value);
        }
        public static Task<bool?> GetAllowFiltering(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxPivotGrid_GetOption", dxTarget, "allowFiltering");
        }
        public static Task SetAllowFiltering(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPivotGrid_SetOption", dxTarget, "allowFiltering", value);
        }
        public static Task<bool?> GetAllowSorting(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxPivotGrid_GetOption", dxTarget, "allowSorting");
        }
        public static Task SetAllowSorting(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPivotGrid_SetOption", dxTarget, "allowSorting", value);
        }
        public static Task<bool?> GetAllowSortingBySummary(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxPivotGrid_GetOption", dxTarget, "allowSortingBySummary");
        }
        public static Task SetAllowSortingBySummary(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPivotGrid_SetOption", dxTarget, "allowSortingBySummary", value);
        }
        public static Task<string> GetDataFieldArea(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxPivotGrid_GetOption", dxTarget, "dataFieldArea");
        }
        public static Task SetDataFieldArea(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPivotGrid_SetOption", dxTarget, "dataFieldArea", value);
        }
        public static Task<object> GetDataSource(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPivotGrid_GetOption", dxTarget, "dataSource");
        }
        public static Task SetDataSource(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPivotGrid_SetOption", dxTarget, "dataSource", value);
        }
        public static Task<object> GetExport(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPivotGrid_GetOption", dxTarget, "export");
        }
        public static Task SetExport(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPivotGrid_SetOption", dxTarget, "export", value);
        }
        public static Task<object> GetFieldChooser(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPivotGrid_GetOption", dxTarget, "fieldChooser");
        }
        public static Task SetFieldChooser(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPivotGrid_SetOption", dxTarget, "fieldChooser", value);
        }
        public static Task<object> GetFieldPanel(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPivotGrid_GetOption", dxTarget, "fieldPanel");
        }
        public static Task SetFieldPanel(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPivotGrid_SetOption", dxTarget, "fieldPanel", value);
        }
        public static Task<object> GetHeaderFilter(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPivotGrid_GetOption", dxTarget, "headerFilter");
        }
        public static Task SetHeaderFilter(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPivotGrid_SetOption", dxTarget, "headerFilter", value);
        }
        public static Task<bool?> GetHideEmptySummaryCells(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxPivotGrid_GetOption", dxTarget, "hideEmptySummaryCells");
        }
        public static Task SetHideEmptySummaryCells(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPivotGrid_SetOption", dxTarget, "hideEmptySummaryCells", value);
        }
        public static Task<object> GetLoadPanel(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPivotGrid_GetOption", dxTarget, "loadPanel");
        }
        public static Task SetLoadPanel(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPivotGrid_SetOption", dxTarget, "loadPanel", value);
        }
        public static Task<string> GetRowHeaderLayout(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxPivotGrid_GetOption", dxTarget, "rowHeaderLayout");
        }
        public static Task SetRowHeaderLayout(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPivotGrid_SetOption", dxTarget, "rowHeaderLayout", value);
        }
        public static Task<object> GetScrolling(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPivotGrid_GetOption", dxTarget, "scrolling");
        }
        public static Task SetScrolling(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPivotGrid_SetOption", dxTarget, "scrolling", value);
        }
        public static Task<bool?> GetShowBorders(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxPivotGrid_GetOption", dxTarget, "showBorders");
        }
        public static Task SetShowBorders(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPivotGrid_SetOption", dxTarget, "showBorders", value);
        }
        public static Task<bool?> GetShowColumnGrandTotals(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxPivotGrid_GetOption", dxTarget, "showColumnGrandTotals");
        }
        public static Task SetShowColumnGrandTotals(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPivotGrid_SetOption", dxTarget, "showColumnGrandTotals", value);
        }
        public static Task<bool?> GetShowColumnTotals(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxPivotGrid_GetOption", dxTarget, "showColumnTotals");
        }
        public static Task SetShowColumnTotals(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPivotGrid_SetOption", dxTarget, "showColumnTotals", value);
        }
        public static Task<bool?> GetShowRowGrandTotals(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxPivotGrid_GetOption", dxTarget, "showRowGrandTotals");
        }
        public static Task SetShowRowGrandTotals(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPivotGrid_SetOption", dxTarget, "showRowGrandTotals", value);
        }
        public static Task<bool?> GetShowRowTotals(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxPivotGrid_GetOption", dxTarget, "showRowTotals");
        }
        public static Task SetShowRowTotals(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPivotGrid_SetOption", dxTarget, "showRowTotals", value);
        }
        public static Task<string> GetShowTotalsPrior(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxPivotGrid_GetOption", dxTarget, "showTotalsPrior");
        }
        public static Task SetShowTotalsPrior(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPivotGrid_SetOption", dxTarget, "showTotalsPrior", value);
        }
        public static Task<object> GetStateStoring(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPivotGrid_GetOption", dxTarget, "stateStoring");
        }
        public static Task SetStateStoring(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPivotGrid_SetOption", dxTarget, "stateStoring", value);
        }
        public static Task<object> GetTexts(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPivotGrid_GetOption", dxTarget, "texts");
        }
        public static Task SetTexts(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPivotGrid_SetOption", dxTarget, "texts", value);
        }
        public static Task<bool?> GetWordWrapEnabled(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxPivotGrid_GetOption", dxTarget, "wordWrapEnabled");
        }
        public static Task SetWordWrapEnabled(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPivotGrid_SetOption", dxTarget, "wordWrapEnabled", value);
        }
        public static Task<object> BindChart(ElementReference dxTarget, object chart, object integrationOptions)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPivotGrid_bindChart_0", dxTarget, chart, integrationOptions);
        }
        public static Task ExportToExcel(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPivotGrid_exportToExcel_1", dxTarget);
        }
        public static Task<object> GetDataSourceEx(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPivotGrid_getDataSource_2", dxTarget);
        }
        public static Task<object> GetFieldChooserPopup(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPivotGrid_getFieldChooserPopup_3", dxTarget);
        }
        public static Task UpdateDimensions(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPivotGrid_updateDimensions_4", dxTarget);
        }
    }
    public class DxPivotGridFieldChooserInterop: WidgetInterop
    {
        public static event EventHandler<JQueryEventArgs> ContextMenuPreparing;
        public static Task Init(ElementReference dxTarget, DevExpress.Ui.DxPivotGridFieldChooserOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPivotGridFieldChooser_Init", dxTarget, json);
        }
        [JSInvokable("DevExpress.Ui.DxPivotGridFieldChooserInterop.OnContextMenuPreparing")]
        public static void OnContextMenuPreparing(string identifier)
        {
            ContextMenuPreparing?.Invoke(null, new JQueryEventArgs(identifier));
        }
        public static Task<bool?> GetAllowSearch(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxPivotGridFieldChooser_GetOption", dxTarget, "allowSearch");
        }
        public static Task SetAllowSearch(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPivotGridFieldChooser_SetOption", dxTarget, "allowSearch", value);
        }
        public static Task<string> GetApplyChangesMode(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxPivotGridFieldChooser_GetOption", dxTarget, "applyChangesMode");
        }
        public static Task SetApplyChangesMode(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPivotGridFieldChooser_SetOption", dxTarget, "applyChangesMode", value);
        }
        public static Task<object> GetDataSource(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPivotGridFieldChooser_GetOption", dxTarget, "dataSource");
        }
        public static Task SetDataSource(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPivotGridFieldChooser_SetOption", dxTarget, "dataSource", value);
        }
        public static Task<object> GetHeaderFilter(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPivotGridFieldChooser_GetOption", dxTarget, "headerFilter");
        }
        public static Task SetHeaderFilter(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPivotGridFieldChooser_SetOption", dxTarget, "headerFilter", value);
        }
        public static Task<object> GetLayout(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPivotGridFieldChooser_GetOption", dxTarget, "layout");
        }
        public static Task SetLayout(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPivotGridFieldChooser_SetOption", dxTarget, "layout", value);
        }
        public static Task<object> GetState(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPivotGridFieldChooser_GetOption", dxTarget, "state");
        }
        public static Task SetState(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPivotGridFieldChooser_SetOption", dxTarget, "state", value);
        }
        public static Task<object> GetTexts(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPivotGridFieldChooser_GetOption", dxTarget, "texts");
        }
        public static Task SetTexts(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPivotGridFieldChooser_SetOption", dxTarget, "texts", value);
        }
        public static Task ApplyChanges(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPivotGridFieldChooser_applyChanges_0", dxTarget);
        }
        public static Task CancelChanges(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPivotGridFieldChooser_cancelChanges_1", dxTarget);
        }
        public static Task<object> GetDataSourceEx(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPivotGridFieldChooser_getDataSource_2", dxTarget);
        }
        public static Task UpdateDimensions(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPivotGridFieldChooser_updateDimensions_3", dxTarget);
        }
    }
    public class DxPopoverInterop: DxPopupInterop
    {
        public static Task Init(ElementReference dxTarget, DevExpress.Ui.DxPopoverOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPopover_Init", dxTarget, json);
        }
        public static Task<object> GetHideEvent(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPopover_GetOption", dxTarget, "hideEvent");
        }
        public static Task SetHideEvent(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPopover_SetOption", dxTarget, "hideEvent", value);
        }
        public static Task<object> GetShowEvent(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPopover_GetOption", dxTarget, "showEvent");
        }
        public static Task SetShowEvent(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPopover_SetOption", dxTarget, "showEvent", value);
        }
        public static Task<object> GetTarget(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPopover_GetOption", dxTarget, "target");
        }
        public static Task SetTarget(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPopover_SetOption", dxTarget, "target", value);
        }
        public static Task<object> Show(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPopover_show_0", dxTarget);
        }
        public static Task<object> Show(ElementReference dxTarget, object target)
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
        public static Task Init(ElementReference dxTarget, DevExpress.Ui.DxPopupOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPopup_Init", dxTarget, json);
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
        public static Task<object> GetContainer(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPopup_GetOption", dxTarget, "container");
        }
        public static Task SetContainer(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPopup_SetOption", dxTarget, "container", value);
        }
        public static Task<bool?> GetFullScreen(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxPopup_GetOption", dxTarget, "fullScreen");
        }
        public static Task SetFullScreen(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPopup_SetOption", dxTarget, "fullScreen", value);
        }
        public static Task<bool?> GetResizeEnabled(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxPopup_GetOption", dxTarget, "resizeEnabled");
        }
        public static Task SetResizeEnabled(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPopup_SetOption", dxTarget, "resizeEnabled", value);
        }
        public static Task<bool?> GetShowCloseButton(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxPopup_GetOption", dxTarget, "showCloseButton");
        }
        public static Task SetShowCloseButton(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPopup_SetOption", dxTarget, "showCloseButton", value);
        }
        public static Task<bool?> GetShowTitle(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxPopup_GetOption", dxTarget, "showTitle");
        }
        public static Task SetShowTitle(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPopup_SetOption", dxTarget, "showTitle", value);
        }
        public static Task<string> GetTitle(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxPopup_GetOption", dxTarget, "title");
        }
        public static Task SetTitle(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPopup_SetOption", dxTarget, "title", value);
        }
        public static Task<object> GetTitleTemplate(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPopup_GetOption", dxTarget, "titleTemplate");
        }
        public static Task SetTitleTemplate(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPopup_SetOption", dxTarget, "titleTemplate", value);
        }
        public static Task<object> GetToolbarItems(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPopup_GetOption", dxTarget, "toolbarItems");
        }
        public static Task SetToolbarItems(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPopup_SetOption", dxTarget, "toolbarItems", value);
        }
    }
    public class DxProgressBarInterop: DxTrackBarInterop
    {
        public static event EventHandler<JQueryEventArgs> Complete;
        public static Task Init(ElementReference dxTarget, DevExpress.Ui.DxProgressBarOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxProgressBar_Init", dxTarget, json);
        }
        [JSInvokable("DevExpress.Ui.DxProgressBarInterop.OnComplete")]
        public static void OnComplete(string identifier)
        {
            Complete?.Invoke(null, new JQueryEventArgs(identifier));
        }
        public static Task<bool?> GetShowStatus(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxProgressBar_GetOption", dxTarget, "showStatus");
        }
        public static Task SetShowStatus(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxProgressBar_SetOption", dxTarget, "showStatus", value);
        }
        public static Task<object> GetStatusFormat(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxProgressBar_GetOption", dxTarget, "statusFormat");
        }
        public static Task SetStatusFormat(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxProgressBar_SetOption", dxTarget, "statusFormat", value);
        }
    }
    public class DxRadioGroupInterop: EditorInterop
    {
        public static Task Init(ElementReference dxTarget, DevExpress.Ui.DxRadioGroupOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxRadioGroup_Init", dxTarget, json);
        }
        public static Task<string> GetLayout(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxRadioGroup_GetOption", dxTarget, "layout");
        }
        public static Task SetLayout(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxRadioGroup_SetOption", dxTarget, "layout", value);
        }
        public static Task<string> GetName(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxRadioGroup_GetOption", dxTarget, "name");
        }
        public static Task SetName(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxRadioGroup_SetOption", dxTarget, "name", value);
        }
        public static Task<object> GetDataSource(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxRadioGroup_GetOption", dxTarget, "dataSource");
        }
        public static Task SetDataSource(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxRadioGroup_SetOption", dxTarget, "dataSource", value);
        }
        public static Task<object> GetDisplayExpr(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxRadioGroup_GetOption", dxTarget, "displayExpr");
        }
        public static Task SetDisplayExpr(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxRadioGroup_SetOption", dxTarget, "displayExpr", value);
        }
        public static Task<object> GetItems(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxRadioGroup_GetOption", dxTarget, "items");
        }
        public static Task SetItems(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxRadioGroup_SetOption", dxTarget, "items", value);
        }
        public static Task<object> GetItemTemplate(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxRadioGroup_GetOption", dxTarget, "itemTemplate");
        }
        public static Task SetItemTemplate(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxRadioGroup_SetOption", dxTarget, "itemTemplate", value);
        }
        public static Task<object> GetValueExpr(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxRadioGroup_GetOption", dxTarget, "valueExpr");
        }
        public static Task SetValueExpr(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxRadioGroup_SetOption", dxTarget, "valueExpr", value);
        }
        public static Task<object> GetDataSourceEx(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxRadioGroup_getDataSource_0", dxTarget);
        }
    }
    public class DxRangeSliderInterop: DxSliderBaseInterop
    {
        public static Task Init(ElementReference dxTarget, DevExpress.Ui.DxRangeSliderOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxRangeSlider_Init", dxTarget, json);
        }
        public static Task<float?> GetEnd(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_DxRangeSlider_GetOption", dxTarget, "end");
        }
        public static Task SetEnd(ElementReference dxTarget, float? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxRangeSlider_SetOption", dxTarget, "end", value);
        }
        public static Task<string> GetEndName(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxRangeSlider_GetOption", dxTarget, "endName");
        }
        public static Task SetEndName(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxRangeSlider_SetOption", dxTarget, "endName", value);
        }
        public static Task<float?> GetStart(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_DxRangeSlider_GetOption", dxTarget, "start");
        }
        public static Task SetStart(ElementReference dxTarget, float? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxRangeSlider_SetOption", dxTarget, "start", value);
        }
        public static Task<string> GetStartName(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxRangeSlider_GetOption", dxTarget, "startName");
        }
        public static Task SetStartName(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxRangeSlider_SetOption", dxTarget, "startName", value);
        }
        public static Task Reset(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxRangeSlider_reset_0", dxTarget);
        }
    }
    public class DxResizableInterop: DOMComponentInterop
    {
        public static event EventHandler<JQueryEventArgs> Resize;
        public static event EventHandler<JQueryEventArgs> ResizeEnd;
        public static event EventHandler<JQueryEventArgs> ResizeStart;
        public static Task Init(ElementReference dxTarget, DevExpress.Ui.DxResizableOptions options)
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
        public static Task<string> GetHandles(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxResizable_GetOption", dxTarget, "handles");
        }
        public static Task SetHandles(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxResizable_SetOption", dxTarget, "handles", value);
        }
        public static Task<float?> GetMaxHeight(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_DxResizable_GetOption", dxTarget, "maxHeight");
        }
        public static Task SetMaxHeight(ElementReference dxTarget, float? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxResizable_SetOption", dxTarget, "maxHeight", value);
        }
        public static Task<float?> GetMaxWidth(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_DxResizable_GetOption", dxTarget, "maxWidth");
        }
        public static Task SetMaxWidth(ElementReference dxTarget, float? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxResizable_SetOption", dxTarget, "maxWidth", value);
        }
        public static Task<float?> GetMinHeight(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_DxResizable_GetOption", dxTarget, "minHeight");
        }
        public static Task SetMinHeight(ElementReference dxTarget, float? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxResizable_SetOption", dxTarget, "minHeight", value);
        }
        public static Task<float?> GetMinWidth(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_DxResizable_GetOption", dxTarget, "minWidth");
        }
        public static Task SetMinWidth(ElementReference dxTarget, float? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxResizable_SetOption", dxTarget, "minWidth", value);
        }
    }
    public class DxResponsiveBoxInterop: CollectionWidgetInterop
    {
        public static Task Init(ElementReference dxTarget, DevExpress.Ui.DxResponsiveBoxOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxResponsiveBox_Init", dxTarget, json);
        }
        public static Task<object> GetCols(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxResponsiveBox_GetOption", dxTarget, "cols");
        }
        public static Task SetCols(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxResponsiveBox_SetOption", dxTarget, "cols", value);
        }
        public static Task<object> GetRows(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxResponsiveBox_GetOption", dxTarget, "rows");
        }
        public static Task SetRows(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxResponsiveBox_SetOption", dxTarget, "rows", value);
        }
        public static Task<object> GetScreenByWidth(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxResponsiveBox_GetOption", dxTarget, "screenByWidth");
        }
        public static Task SetScreenByWidth(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxResponsiveBox_SetOption", dxTarget, "screenByWidth", value);
        }
        public static Task<string> GetSingleColumnScreen(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxResponsiveBox_GetOption", dxTarget, "singleColumnScreen");
        }
        public static Task SetSingleColumnScreen(ElementReference dxTarget, string value)
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
        public static Task Init(ElementReference dxTarget, DevExpress.Ui.DxSchedulerOptions options)
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
        public static Task<string> GetAllDayExpr(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxScheduler_GetOption", dxTarget, "allDayExpr");
        }
        public static Task SetAllDayExpr(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScheduler_SetOption", dxTarget, "allDayExpr", value);
        }
        public static Task<object> GetAppointmentTemplate(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScheduler_GetOption", dxTarget, "appointmentTemplate");
        }
        public static Task SetAppointmentTemplate(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScheduler_SetOption", dxTarget, "appointmentTemplate", value);
        }
        public static Task<object> GetAppointmentTooltipTemplate(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScheduler_GetOption", dxTarget, "appointmentTooltipTemplate");
        }
        public static Task SetAppointmentTooltipTemplate(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScheduler_SetOption", dxTarget, "appointmentTooltipTemplate", value);
        }
        public static Task<float?> GetCellDuration(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_DxScheduler_GetOption", dxTarget, "cellDuration");
        }
        public static Task SetCellDuration(ElementReference dxTarget, float? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScheduler_SetOption", dxTarget, "cellDuration", value);
        }
        public static Task<bool?> GetCrossScrollingEnabled(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxScheduler_GetOption", dxTarget, "crossScrollingEnabled");
        }
        public static Task SetCrossScrollingEnabled(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScheduler_SetOption", dxTarget, "crossScrollingEnabled", value);
        }
        public static Task<object> GetCurrentDate(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScheduler_GetOption", dxTarget, "currentDate");
        }
        public static Task SetCurrentDate(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScheduler_SetOption", dxTarget, "currentDate", value);
        }
        public static Task<string> GetCurrentView(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxScheduler_GetOption", dxTarget, "currentView");
        }
        public static Task SetCurrentView(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScheduler_SetOption", dxTarget, "currentView", value);
        }
        public static Task<object> GetDataCellTemplate(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScheduler_GetOption", dxTarget, "dataCellTemplate");
        }
        public static Task SetDataCellTemplate(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScheduler_SetOption", dxTarget, "dataCellTemplate", value);
        }
        public static Task<object> GetDataSource(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScheduler_GetOption", dxTarget, "dataSource");
        }
        public static Task SetDataSource(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScheduler_SetOption", dxTarget, "dataSource", value);
        }
        public static Task<object> GetDateCellTemplate(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScheduler_GetOption", dxTarget, "dateCellTemplate");
        }
        public static Task SetDateCellTemplate(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScheduler_SetOption", dxTarget, "dateCellTemplate", value);
        }
        public static Task<string> GetDateSerializationFormat(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxScheduler_GetOption", dxTarget, "dateSerializationFormat");
        }
        public static Task SetDateSerializationFormat(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScheduler_SetOption", dxTarget, "dateSerializationFormat", value);
        }
        public static Task<string> GetDescriptionExpr(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxScheduler_GetOption", dxTarget, "descriptionExpr");
        }
        public static Task SetDescriptionExpr(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScheduler_SetOption", dxTarget, "descriptionExpr", value);
        }
        public static Task<object> GetDropDownAppointmentTemplate(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScheduler_GetOption", dxTarget, "dropDownAppointmentTemplate");
        }
        public static Task SetDropDownAppointmentTemplate(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScheduler_SetOption", dxTarget, "dropDownAppointmentTemplate", value);
        }
        public static Task<object> GetEditing(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScheduler_GetOption", dxTarget, "editing");
        }
        public static Task SetEditing(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScheduler_SetOption", dxTarget, "editing", value);
        }
        public static Task<string> GetEndDateExpr(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxScheduler_GetOption", dxTarget, "endDateExpr");
        }
        public static Task SetEndDateExpr(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScheduler_SetOption", dxTarget, "endDateExpr", value);
        }
        public static Task<string> GetEndDateTimeZoneExpr(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxScheduler_GetOption", dxTarget, "endDateTimeZoneExpr");
        }
        public static Task SetEndDateTimeZoneExpr(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScheduler_SetOption", dxTarget, "endDateTimeZoneExpr", value);
        }
        public static Task<float?> GetEndDayHour(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_DxScheduler_GetOption", dxTarget, "endDayHour");
        }
        public static Task SetEndDayHour(ElementReference dxTarget, float? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScheduler_SetOption", dxTarget, "endDayHour", value);
        }
        public static Task<object> GetFirstDayOfWeek(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScheduler_GetOption", dxTarget, "firstDayOfWeek");
        }
        public static Task SetFirstDayOfWeek(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScheduler_SetOption", dxTarget, "firstDayOfWeek", value);
        }
        public static Task<object> GetGroups(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScheduler_GetOption", dxTarget, "groups");
        }
        public static Task SetGroups(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScheduler_SetOption", dxTarget, "groups", value);
        }
        public static Task<float?> GetIndicatorUpdateInterval(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_DxScheduler_GetOption", dxTarget, "indicatorUpdateInterval");
        }
        public static Task SetIndicatorUpdateInterval(ElementReference dxTarget, float? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScheduler_SetOption", dxTarget, "indicatorUpdateInterval", value);
        }
        public static Task<object> GetMax(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScheduler_GetOption", dxTarget, "max");
        }
        public static Task SetMax(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScheduler_SetOption", dxTarget, "max", value);
        }
        public static Task<object> GetMaxAppointmentsPerCell(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScheduler_GetOption", dxTarget, "maxAppointmentsPerCell");
        }
        public static Task SetMaxAppointmentsPerCell(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScheduler_SetOption", dxTarget, "maxAppointmentsPerCell", value);
        }
        public static Task<object> GetMin(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScheduler_GetOption", dxTarget, "min");
        }
        public static Task SetMin(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScheduler_SetOption", dxTarget, "min", value);
        }
        public static Task<string> GetNoDataText(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxScheduler_GetOption", dxTarget, "noDataText");
        }
        public static Task SetNoDataText(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScheduler_SetOption", dxTarget, "noDataText", value);
        }
        public static Task<string> GetRecurrenceEditMode(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxScheduler_GetOption", dxTarget, "recurrenceEditMode");
        }
        public static Task SetRecurrenceEditMode(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScheduler_SetOption", dxTarget, "recurrenceEditMode", value);
        }
        public static Task<string> GetRecurrenceExceptionExpr(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxScheduler_GetOption", dxTarget, "recurrenceExceptionExpr");
        }
        public static Task SetRecurrenceExceptionExpr(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScheduler_SetOption", dxTarget, "recurrenceExceptionExpr", value);
        }
        public static Task<string> GetRecurrenceRuleExpr(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxScheduler_GetOption", dxTarget, "recurrenceRuleExpr");
        }
        public static Task SetRecurrenceRuleExpr(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScheduler_SetOption", dxTarget, "recurrenceRuleExpr", value);
        }
        public static Task<bool?> GetRemoteFiltering(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxScheduler_GetOption", dxTarget, "remoteFiltering");
        }
        public static Task SetRemoteFiltering(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScheduler_SetOption", dxTarget, "remoteFiltering", value);
        }
        public static Task<object> GetResourceCellTemplate(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScheduler_GetOption", dxTarget, "resourceCellTemplate");
        }
        public static Task SetResourceCellTemplate(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScheduler_SetOption", dxTarget, "resourceCellTemplate", value);
        }
        public static Task<object> GetResources(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScheduler_GetOption", dxTarget, "resources");
        }
        public static Task SetResources(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScheduler_SetOption", dxTarget, "resources", value);
        }
        public static Task<object> GetSelectedCellData(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScheduler_GetOption", dxTarget, "selectedCellData");
        }
        public static Task SetSelectedCellData(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScheduler_SetOption", dxTarget, "selectedCellData", value);
        }
        public static Task<bool?> GetShadeUntilCurrentTime(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxScheduler_GetOption", dxTarget, "shadeUntilCurrentTime");
        }
        public static Task SetShadeUntilCurrentTime(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScheduler_SetOption", dxTarget, "shadeUntilCurrentTime", value);
        }
        public static Task<bool?> GetShowAllDayPanel(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxScheduler_GetOption", dxTarget, "showAllDayPanel");
        }
        public static Task SetShowAllDayPanel(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScheduler_SetOption", dxTarget, "showAllDayPanel", value);
        }
        public static Task<bool?> GetShowCurrentTimeIndicator(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxScheduler_GetOption", dxTarget, "showCurrentTimeIndicator");
        }
        public static Task SetShowCurrentTimeIndicator(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScheduler_SetOption", dxTarget, "showCurrentTimeIndicator", value);
        }
        public static Task<string> GetStartDateExpr(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxScheduler_GetOption", dxTarget, "startDateExpr");
        }
        public static Task SetStartDateExpr(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScheduler_SetOption", dxTarget, "startDateExpr", value);
        }
        public static Task<string> GetStartDateTimeZoneExpr(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxScheduler_GetOption", dxTarget, "startDateTimeZoneExpr");
        }
        public static Task SetStartDateTimeZoneExpr(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScheduler_SetOption", dxTarget, "startDateTimeZoneExpr", value);
        }
        public static Task<float?> GetStartDayHour(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_DxScheduler_GetOption", dxTarget, "startDayHour");
        }
        public static Task SetStartDayHour(ElementReference dxTarget, float? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScheduler_SetOption", dxTarget, "startDayHour", value);
        }
        public static Task<string> GetTextExpr(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxScheduler_GetOption", dxTarget, "textExpr");
        }
        public static Task SetTextExpr(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScheduler_SetOption", dxTarget, "textExpr", value);
        }
        public static Task<object> GetTimeCellTemplate(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScheduler_GetOption", dxTarget, "timeCellTemplate");
        }
        public static Task SetTimeCellTemplate(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScheduler_SetOption", dxTarget, "timeCellTemplate", value);
        }
        public static Task<string> GetTimeZone(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxScheduler_GetOption", dxTarget, "timeZone");
        }
        public static Task SetTimeZone(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScheduler_SetOption", dxTarget, "timeZone", value);
        }
        public static Task<bool?> GetUseDropDownViewSwitcher(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxScheduler_GetOption", dxTarget, "useDropDownViewSwitcher");
        }
        public static Task SetUseDropDownViewSwitcher(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScheduler_SetOption", dxTarget, "useDropDownViewSwitcher", value);
        }
        public static Task<object> GetViews(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScheduler_GetOption", dxTarget, "views");
        }
        public static Task SetViews(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScheduler_SetOption", dxTarget, "views", value);
        }
        public static Task AddAppointment(ElementReference dxTarget, object appointment)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScheduler_addAppointment_0", dxTarget, appointment);
        }
        public static Task DeleteAppointment(ElementReference dxTarget, object appointment)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScheduler_deleteAppointment_1", dxTarget, appointment);
        }
        public static Task<object> GetDataSourceEx(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScheduler_getDataSource_2", dxTarget);
        }
        public static Task<object> GetEndViewDate(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScheduler_getEndViewDate_3", dxTarget);
        }
        public static Task<object> GetStartViewDate(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScheduler_getStartViewDate_4", dxTarget);
        }
        public static Task HideAppointmentPopup(ElementReference dxTarget, bool saveChanges)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScheduler_hideAppointmentPopup_5", dxTarget, saveChanges);
        }
        public static Task HideAppointmentTooltip(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScheduler_hideAppointmentTooltip_6", dxTarget);
        }
        public static Task RegisterKeyHandler(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScheduler_registerKeyHandler_7", dxTarget);
        }
        public static Task ScrollToTime(ElementReference dxTarget, float hours, float minutes, object date)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScheduler_scrollToTime_8", dxTarget, hours, minutes, date);
        }
        public static Task ShowAppointmentPopup(ElementReference dxTarget, object appointmentData, bool createNewAppointment, object currentAppointmentData)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScheduler_showAppointmentPopup_9", dxTarget, appointmentData, createNewAppointment, currentAppointmentData);
        }
        public static Task ShowAppointmentTooltip(ElementReference dxTarget, object appointmentData, object target, object currentAppointmentData)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScheduler_showAppointmentTooltip_10", dxTarget, appointmentData, target, currentAppointmentData);
        }
        public static Task UpdateAppointment(ElementReference dxTarget, object target, object appointment)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScheduler_updateAppointment_11", dxTarget, target, appointment);
        }
    }
    public class DxScrollViewInterop: DxScrollableInterop
    {
        public static event EventHandler<JQueryEventArgs> PullDown;
        public static event EventHandler<JQueryEventArgs> ReachBottom;
        public static Task Init(ElementReference dxTarget, DevExpress.Ui.DxScrollViewOptions options)
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
        public static Task<string> GetPulledDownText(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxScrollView_GetOption", dxTarget, "pulledDownText");
        }
        public static Task SetPulledDownText(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScrollView_SetOption", dxTarget, "pulledDownText", value);
        }
        public static Task<string> GetPullingDownText(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxScrollView_GetOption", dxTarget, "pullingDownText");
        }
        public static Task SetPullingDownText(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScrollView_SetOption", dxTarget, "pullingDownText", value);
        }
        public static Task<string> GetReachBottomText(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxScrollView_GetOption", dxTarget, "reachBottomText");
        }
        public static Task SetReachBottomText(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScrollView_SetOption", dxTarget, "reachBottomText", value);
        }
        public static Task<string> GetRefreshingText(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxScrollView_GetOption", dxTarget, "refreshingText");
        }
        public static Task SetRefreshingText(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScrollView_SetOption", dxTarget, "refreshingText", value);
        }
        public static Task Refresh(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScrollView_refresh_0", dxTarget);
        }
        public static Task<object> Release(ElementReference dxTarget, bool preventScrollBottom)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScrollView_release_1", dxTarget, preventScrollBottom);
        }
    }
    public class DxSelectBoxInterop: DxDropDownListInterop
    {
        public static event EventHandler<JQueryEventArgs> CustomItemCreating;
        public static Task Init(ElementReference dxTarget, DevExpress.Ui.DxSelectBoxOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxSelectBox_Init", dxTarget, json);
        }
        [JSInvokable("DevExpress.Ui.DxSelectBoxInterop.OnCustomItemCreating")]
        public static void OnCustomItemCreating(string identifier)
        {
            CustomItemCreating?.Invoke(null, new JQueryEventArgs(identifier));
        }
        public static Task<object> GetFieldTemplate(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxSelectBox_GetOption", dxTarget, "fieldTemplate");
        }
        public static Task SetFieldTemplate(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxSelectBox_SetOption", dxTarget, "fieldTemplate", value);
        }
        public static Task<bool?> GetShowSelectionControls(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxSelectBox_GetOption", dxTarget, "showSelectionControls");
        }
        public static Task SetShowSelectionControls(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxSelectBox_SetOption", dxTarget, "showSelectionControls", value);
        }
    }
    public class DxSliderInterop: DxSliderBaseInterop
    {
        public static Task Init(ElementReference dxTarget, DevExpress.Ui.DxSliderOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxSlider_Init", dxTarget, json);
        }
    }
    public class DxSlideOutInterop: CollectionWidgetInterop
    {
        public static event EventHandler<JQueryEventArgs> MenuGroupRendered;
        public static event EventHandler<JQueryEventArgs> MenuItemRendered;
        public static Task Init(ElementReference dxTarget, DevExpress.Ui.DxSlideOutOptions options)
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
        public static Task<object> GetContentTemplate(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxSlideOut_GetOption", dxTarget, "contentTemplate");
        }
        public static Task SetContentTemplate(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxSlideOut_SetOption", dxTarget, "contentTemplate", value);
        }
        public static Task<bool?> GetMenuGrouped(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxSlideOut_GetOption", dxTarget, "menuGrouped");
        }
        public static Task SetMenuGrouped(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxSlideOut_SetOption", dxTarget, "menuGrouped", value);
        }
        public static Task<object> GetMenuGroupTemplate(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxSlideOut_GetOption", dxTarget, "menuGroupTemplate");
        }
        public static Task SetMenuGroupTemplate(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxSlideOut_SetOption", dxTarget, "menuGroupTemplate", value);
        }
        public static Task<object> GetMenuItemTemplate(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxSlideOut_GetOption", dxTarget, "menuItemTemplate");
        }
        public static Task SetMenuItemTemplate(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxSlideOut_SetOption", dxTarget, "menuItemTemplate", value);
        }
        public static Task<string> GetMenuPosition(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxSlideOut_GetOption", dxTarget, "menuPosition");
        }
        public static Task SetMenuPosition(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxSlideOut_SetOption", dxTarget, "menuPosition", value);
        }
        public static Task<bool?> GetMenuVisible(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxSlideOut_GetOption", dxTarget, "menuVisible");
        }
        public static Task SetMenuVisible(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxSlideOut_SetOption", dxTarget, "menuVisible", value);
        }
        public static Task<bool?> GetSwipeEnabled(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxSlideOut_GetOption", dxTarget, "swipeEnabled");
        }
        public static Task SetSwipeEnabled(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxSlideOut_SetOption", dxTarget, "swipeEnabled", value);
        }
        public static Task<object> HideMenu(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxSlideOut_hideMenu_0", dxTarget);
        }
        public static Task<object> ShowMenu(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxSlideOut_showMenu_1", dxTarget);
        }
        public static Task<object> ToggleMenuVisibility(ElementReference dxTarget, bool showing)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxSlideOut_toggleMenuVisibility_2", dxTarget, showing);
        }
    }
    public class DxSlideOutViewInterop: WidgetInterop
    {
        public static Task Init(ElementReference dxTarget, DevExpress.Ui.DxSlideOutViewOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxSlideOutView_Init", dxTarget, json);
        }
        public static Task<object> GetContentTemplate(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxSlideOutView_GetOption", dxTarget, "contentTemplate");
        }
        public static Task SetContentTemplate(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxSlideOutView_SetOption", dxTarget, "contentTemplate", value);
        }
        public static Task<string> GetMenuPosition(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxSlideOutView_GetOption", dxTarget, "menuPosition");
        }
        public static Task SetMenuPosition(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxSlideOutView_SetOption", dxTarget, "menuPosition", value);
        }
        public static Task<object> GetMenuTemplate(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxSlideOutView_GetOption", dxTarget, "menuTemplate");
        }
        public static Task SetMenuTemplate(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxSlideOutView_SetOption", dxTarget, "menuTemplate", value);
        }
        public static Task<bool?> GetMenuVisible(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxSlideOutView_GetOption", dxTarget, "menuVisible");
        }
        public static Task SetMenuVisible(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxSlideOutView_SetOption", dxTarget, "menuVisible", value);
        }
        public static Task<bool?> GetSwipeEnabled(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxSlideOutView_GetOption", dxTarget, "swipeEnabled");
        }
        public static Task SetSwipeEnabled(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxSlideOutView_SetOption", dxTarget, "swipeEnabled", value);
        }
        public static Task<object> Content(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxSlideOutView_content_0", dxTarget);
        }
        public static Task<object> HideMenu(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxSlideOutView_hideMenu_1", dxTarget);
        }
        public static Task<object> MenuContent(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxSlideOutView_menuContent_2", dxTarget);
        }
        public static Task<object> ShowMenu(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxSlideOutView_showMenu_3", dxTarget);
        }
        public static Task<object> ToggleMenuVisibility(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxSlideOutView_toggleMenuVisibility_4", dxTarget);
        }
    }
    public class DxSwitchInterop: EditorInterop
    {
        public static Task Init(ElementReference dxTarget, DevExpress.Ui.DxSwitchOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxSwitch_Init", dxTarget, json);
        }
        public static Task<string> GetName(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxSwitch_GetOption", dxTarget, "name");
        }
        public static Task SetName(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxSwitch_SetOption", dxTarget, "name", value);
        }
        public static Task<string> GetOffText(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxSwitch_GetOption", dxTarget, "offText");
        }
        public static Task SetOffText(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxSwitch_SetOption", dxTarget, "offText", value);
        }
        public static Task<string> GetOnText(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxSwitch_GetOption", dxTarget, "onText");
        }
        public static Task SetOnText(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxSwitch_SetOption", dxTarget, "onText", value);
        }
    }
    public class DxTabsInterop: CollectionWidgetInterop
    {
        public static Task Init(ElementReference dxTarget, DevExpress.Ui.DxTabsOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTabs_Init", dxTarget, json);
        }
        public static Task<bool?> GetScrollByContent(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxTabs_GetOption", dxTarget, "scrollByContent");
        }
        public static Task SetScrollByContent(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTabs_SetOption", dxTarget, "scrollByContent", value);
        }
        public static Task<bool?> GetScrollingEnabled(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxTabs_GetOption", dxTarget, "scrollingEnabled");
        }
        public static Task SetScrollingEnabled(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTabs_SetOption", dxTarget, "scrollingEnabled", value);
        }
        public static Task<string> GetSelectionMode(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxTabs_GetOption", dxTarget, "selectionMode");
        }
        public static Task SetSelectionMode(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTabs_SetOption", dxTarget, "selectionMode", value);
        }
        public static Task<bool?> GetShowNavButtons(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxTabs_GetOption", dxTarget, "showNavButtons");
        }
        public static Task SetShowNavButtons(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTabs_SetOption", dxTarget, "showNavButtons", value);
        }
    }
    public class DxTabPanelInterop: DxMultiViewInterop
    {
        public static event EventHandler<JQueryEventArgs> TitleClick;
        public static event EventHandler<JQueryEventArgs> TitleHold;
        public static event EventHandler<JQueryEventArgs> TitleRendered;
        public static Task Init(ElementReference dxTarget, DevExpress.Ui.DxTabPanelOptions options)
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
        public static Task<object> GetItemTitleTemplate(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTabPanel_GetOption", dxTarget, "itemTitleTemplate");
        }
        public static Task SetItemTitleTemplate(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTabPanel_SetOption", dxTarget, "itemTitleTemplate", value);
        }
        public static Task<bool?> GetScrollByContent(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxTabPanel_GetOption", dxTarget, "scrollByContent");
        }
        public static Task SetScrollByContent(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTabPanel_SetOption", dxTarget, "scrollByContent", value);
        }
        public static Task<bool?> GetScrollingEnabled(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxTabPanel_GetOption", dxTarget, "scrollingEnabled");
        }
        public static Task SetScrollingEnabled(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTabPanel_SetOption", dxTarget, "scrollingEnabled", value);
        }
        public static Task<bool?> GetShowNavButtons(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxTabPanel_GetOption", dxTarget, "showNavButtons");
        }
        public static Task SetShowNavButtons(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTabPanel_SetOption", dxTarget, "showNavButtons", value);
        }
    }
    public class DxTagBoxInterop: DxSelectBoxInterop
    {
        public static event EventHandler<JQueryEventArgs> MultiTagPreparing;
        public static event EventHandler<JQueryEventArgs> SelectAllValueChanged;
        public static Task Init(ElementReference dxTarget, DevExpress.Ui.DxTagBoxOptions options)
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
        public static Task<bool?> GetHideSelectedItems(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxTagBox_GetOption", dxTarget, "hideSelectedItems");
        }
        public static Task SetHideSelectedItems(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTagBox_SetOption", dxTarget, "hideSelectedItems", value);
        }
        public static Task<float?> GetMaxDisplayedTags(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_DxTagBox_GetOption", dxTarget, "maxDisplayedTags");
        }
        public static Task SetMaxDisplayedTags(ElementReference dxTarget, float? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTagBox_SetOption", dxTarget, "maxDisplayedTags", value);
        }
        public static Task<bool?> GetMultiline(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxTagBox_GetOption", dxTarget, "multiline");
        }
        public static Task SetMultiline(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTagBox_SetOption", dxTarget, "multiline", value);
        }
        public static Task<string> GetSelectAllMode(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxTagBox_GetOption", dxTarget, "selectAllMode");
        }
        public static Task SetSelectAllMode(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTagBox_SetOption", dxTarget, "selectAllMode", value);
        }
        public static Task<object> GetSelectedItems(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTagBox_GetOption", dxTarget, "selectedItems");
        }
        public static Task SetSelectedItems(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTagBox_SetOption", dxTarget, "selectedItems", value);
        }
        public static Task<bool?> GetShowMultiTagOnly(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxTagBox_GetOption", dxTarget, "showMultiTagOnly");
        }
        public static Task SetShowMultiTagOnly(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTagBox_SetOption", dxTarget, "showMultiTagOnly", value);
        }
        public static Task<object> GetTagTemplate(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTagBox_GetOption", dxTarget, "tagTemplate");
        }
        public static Task SetTagTemplate(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTagBox_SetOption", dxTarget, "tagTemplate", value);
        }
    }
    public class DxTextAreaInterop: DxTextBoxInterop
    {
        public static Task Init(ElementReference dxTarget, DevExpress.Ui.DxTextAreaOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTextArea_Init", dxTarget, json);
        }
        public static Task<bool?> GetAutoResizeEnabled(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxTextArea_GetOption", dxTarget, "autoResizeEnabled");
        }
        public static Task SetAutoResizeEnabled(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTextArea_SetOption", dxTarget, "autoResizeEnabled", value);
        }
        public static Task<object> GetMaxHeight(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTextArea_GetOption", dxTarget, "maxHeight");
        }
        public static Task SetMaxHeight(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTextArea_SetOption", dxTarget, "maxHeight", value);
        }
        public static Task<object> GetMinHeight(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTextArea_GetOption", dxTarget, "minHeight");
        }
        public static Task SetMinHeight(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTextArea_SetOption", dxTarget, "minHeight", value);
        }
    }
    public class DxTextBoxInterop: DxTextEditorInterop
    {
        public static Task Init(ElementReference dxTarget, DevExpress.Ui.DxTextBoxOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTextBox_Init", dxTarget, json);
        }
        public static Task<object> GetMaxLength(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTextBox_GetOption", dxTarget, "maxLength");
        }
        public static Task SetMaxLength(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTextBox_SetOption", dxTarget, "maxLength", value);
        }
        public static Task<string> GetMode(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxTextBox_GetOption", dxTarget, "mode");
        }
        public static Task SetMode(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTextBox_SetOption", dxTarget, "mode", value);
        }
    }
    public class DxTileViewInterop: CollectionWidgetInterop
    {
        public static Task Init(ElementReference dxTarget, DevExpress.Ui.DxTileViewOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTileView_Init", dxTarget, json);
        }
        public static Task<float?> GetBaseItemHeight(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_DxTileView_GetOption", dxTarget, "baseItemHeight");
        }
        public static Task SetBaseItemHeight(ElementReference dxTarget, float? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTileView_SetOption", dxTarget, "baseItemHeight", value);
        }
        public static Task<float?> GetBaseItemWidth(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_DxTileView_GetOption", dxTarget, "baseItemWidth");
        }
        public static Task SetBaseItemWidth(ElementReference dxTarget, float? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTileView_SetOption", dxTarget, "baseItemWidth", value);
        }
        public static Task<string> GetDirection(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxTileView_GetOption", dxTarget, "direction");
        }
        public static Task SetDirection(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTileView_SetOption", dxTarget, "direction", value);
        }
        public static Task<float?> GetItemMargin(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_DxTileView_GetOption", dxTarget, "itemMargin");
        }
        public static Task SetItemMargin(ElementReference dxTarget, float? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTileView_SetOption", dxTarget, "itemMargin", value);
        }
        public static Task<bool?> GetShowScrollbar(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxTileView_GetOption", dxTarget, "showScrollbar");
        }
        public static Task SetShowScrollbar(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTileView_SetOption", dxTarget, "showScrollbar", value);
        }
        public static Task<float> ScrollPosition(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<float>("BlazorDevExtreme_DxTileView_scrollPosition_0", dxTarget);
        }
    }
    public class DxToastInterop: DxOverlayInterop
    {
        public static Task Init(ElementReference dxTarget, DevExpress.Ui.DxToastOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxToast_Init", dxTarget, json);
        }
        public static Task<bool?> GetCloseOnClick(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxToast_GetOption", dxTarget, "closeOnClick");
        }
        public static Task SetCloseOnClick(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxToast_SetOption", dxTarget, "closeOnClick", value);
        }
        public static Task<bool?> GetCloseOnSwipe(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxToast_GetOption", dxTarget, "closeOnSwipe");
        }
        public static Task SetCloseOnSwipe(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxToast_SetOption", dxTarget, "closeOnSwipe", value);
        }
        public static Task<float?> GetDisplayTime(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_DxToast_GetOption", dxTarget, "displayTime");
        }
        public static Task SetDisplayTime(ElementReference dxTarget, float? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxToast_SetOption", dxTarget, "displayTime", value);
        }
        public static Task<string> GetMessage(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxToast_GetOption", dxTarget, "message");
        }
        public static Task SetMessage(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxToast_SetOption", dxTarget, "message", value);
        }
        public static Task<string> GetType(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxToast_GetOption", dxTarget, "type");
        }
        public static Task SetType(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxToast_SetOption", dxTarget, "type", value);
        }
    }
    public class DxToolbarInterop: CollectionWidgetInterop
    {
        public static Task Init(ElementReference dxTarget, DevExpress.Ui.DxToolbarOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxToolbar_Init", dxTarget, json);
        }
        public static Task<object> GetMenuItemTemplate(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxToolbar_GetOption", dxTarget, "menuItemTemplate");
        }
        public static Task SetMenuItemTemplate(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxToolbar_SetOption", dxTarget, "menuItemTemplate", value);
        }
        public static Task<string> GetRenderAs(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxToolbar_GetOption", dxTarget, "renderAs");
        }
        public static Task SetRenderAs(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxToolbar_SetOption", dxTarget, "renderAs", value);
        }
    }
    public class DxTooltipInterop: DxPopoverInterop
    {
        public static Task Init(ElementReference dxTarget, DevExpress.Ui.DxTooltipOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTooltip_Init", dxTarget, json);
        }
    }
    public class DxTrackBarInterop: EditorInterop
    {
        public static Task Init(ElementReference dxTarget, DevExpress.Ui.DxTrackBarOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTrackBar_Init", dxTarget, json);
        }
        public static Task<float?> GetMax(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_DxTrackBar_GetOption", dxTarget, "max");
        }
        public static Task SetMax(ElementReference dxTarget, float? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTrackBar_SetOption", dxTarget, "max", value);
        }
        public static Task<float?> GetMin(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_DxTrackBar_GetOption", dxTarget, "min");
        }
        public static Task SetMin(ElementReference dxTarget, float? value)
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
        public static event EventHandler<JQueryEventArgs> NodesInitialized;
        public static event EventHandler<JQueryEventArgs> RowClick;
        public static event EventHandler<JQueryEventArgs> RowPrepared;
        public static Task Init(ElementReference dxTarget, DevExpress.Ui.DxTreeListOptions options)
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
        public static Task<bool?> GetAutoExpandAll(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxTreeList_GetOption", dxTarget, "autoExpandAll");
        }
        public static Task SetAutoExpandAll(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeList_SetOption", dxTarget, "autoExpandAll", value);
        }
        public static Task<object> GetCustomizeColumns(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeList_GetOption", dxTarget, "customizeColumns");
        }
        public static Task SetCustomizeColumns(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeList_SetOption", dxTarget, "customizeColumns", value);
        }
        public static Task<string> GetDataStructure(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxTreeList_GetOption", dxTarget, "dataStructure");
        }
        public static Task SetDataStructure(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeList_SetOption", dxTarget, "dataStructure", value);
        }
        public static Task<object> GetExpandedRowKeys(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeList_GetOption", dxTarget, "expandedRowKeys");
        }
        public static Task SetExpandedRowKeys(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeList_SetOption", dxTarget, "expandedRowKeys", value);
        }
        public static Task<bool?> GetExpandNodesOnFiltering(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxTreeList_GetOption", dxTarget, "expandNodesOnFiltering");
        }
        public static Task SetExpandNodesOnFiltering(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeList_SetOption", dxTarget, "expandNodesOnFiltering", value);
        }
        public static Task<object> GetHasItemsExpr(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeList_GetOption", dxTarget, "hasItemsExpr");
        }
        public static Task SetHasItemsExpr(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeList_SetOption", dxTarget, "hasItemsExpr", value);
        }
        public static Task<object> GetItemsExpr(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeList_GetOption", dxTarget, "itemsExpr");
        }
        public static Task SetItemsExpr(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeList_SetOption", dxTarget, "itemsExpr", value);
        }
        public static Task<object> GetKeyExpr(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeList_GetOption", dxTarget, "keyExpr");
        }
        public static Task SetKeyExpr(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeList_SetOption", dxTarget, "keyExpr", value);
        }
        public static Task<object> GetParentIdExpr(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeList_GetOption", dxTarget, "parentIdExpr");
        }
        public static Task SetParentIdExpr(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeList_SetOption", dxTarget, "parentIdExpr", value);
        }
        public static Task<object> GetRemoteOperations(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeList_GetOption", dxTarget, "remoteOperations");
        }
        public static Task SetRemoteOperations(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeList_SetOption", dxTarget, "remoteOperations", value);
        }
        public static Task<object> GetRootValue(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeList_GetOption", dxTarget, "rootValue");
        }
        public static Task SetRootValue(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeList_SetOption", dxTarget, "rootValue", value);
        }
        public static Task AddColumn(ElementReference dxTarget, object columnOptions)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeList_addColumn_0", dxTarget, columnOptions);
        }
        public static Task AddRow(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeList_addRow_1", dxTarget);
        }
        public static Task AddRow(ElementReference dxTarget, object parentId)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeList_addRow_2", dxTarget, parentId);
        }
        public static Task<object> CollapseRow(ElementReference dxTarget, object key)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeList_collapseRow_3", dxTarget, key);
        }
        public static Task<object> ExpandRow(ElementReference dxTarget, object key)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeList_expandRow_4", dxTarget, key);
        }
        public static Task ForEachNode(ElementReference dxTarget, object callback)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeList_forEachNode_5", dxTarget, callback);
        }
        public static Task ForEachNode(ElementReference dxTarget, object nodes, object callback)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeList_forEachNode_6", dxTarget, nodes, callback);
        }
        public static Task<object> GetNodeByKey(ElementReference dxTarget, object key)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeList_getNodeByKey_7", dxTarget, key);
        }
        public static Task<object> GetRootNode(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeList_getRootNode_8", dxTarget);
        }
        public static Task<object> GetSelectedRowKeys(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeList_getSelectedRowKeys_9", dxTarget);
        }
        public static Task<object> GetSelectedRowKeys(ElementReference dxTarget, bool leavesOnly)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeList_getSelectedRowKeys_10", dxTarget, leavesOnly);
        }
        public static Task<object> GetSelectedRowKeys(ElementReference dxTarget, string mode)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeList_getSelectedRowKeys_11", dxTarget, mode);
        }
        public static Task<object> GetSelectedRowsData(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeList_getSelectedRowsData_12", dxTarget);
        }
        public static Task<object> GetVisibleColumns(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeList_getVisibleColumns_13", dxTarget);
        }
        public static Task<object> GetVisibleColumns(ElementReference dxTarget, float headerLevel)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeList_getVisibleColumns_14", dxTarget, headerLevel);
        }
        public static Task<object> GetVisibleRows(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeList_getVisibleRows_15", dxTarget);
        }
        public static Task<bool> IsRowExpanded(ElementReference dxTarget, object key)
        {
            return JSRuntime.Current.InvokeAsync<bool>("BlazorDevExtreme_DxTreeList_isRowExpanded_16", dxTarget, key);
        }
        public static Task<object> LoadDescendants(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeList_loadDescendants_17", dxTarget);
        }
        public static Task<object> LoadDescendants(ElementReference dxTarget, object keys)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeList_loadDescendants_18", dxTarget, keys);
        }
        public static Task<object> LoadDescendants(ElementReference dxTarget, object keys, bool childrenOnly)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeList_loadDescendants_19", dxTarget, keys, childrenOnly);
        }
    }
    public class DxTreeViewInterop: HierarchicalCollectionWidgetInterop
    {
        public static event EventHandler<JQueryEventArgs> ItemCollapsed;
        public static event EventHandler<JQueryEventArgs> ItemExpanded;
        public static event EventHandler<JQueryEventArgs> ItemSelectionChanged;
        public static Task Init(ElementReference dxTarget, DevExpress.Ui.DxTreeViewOptions options)
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
        public static Task<bool?> GetAnimationEnabled(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxTreeView_GetOption", dxTarget, "animationEnabled");
        }
        public static Task SetAnimationEnabled(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeView_SetOption", dxTarget, "animationEnabled", value);
        }
        public static Task<object> GetCreateChildren(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeView_GetOption", dxTarget, "createChildren");
        }
        public static Task SetCreateChildren(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeView_SetOption", dxTarget, "createChildren", value);
        }
        public static Task<string> GetDataStructure(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxTreeView_GetOption", dxTarget, "dataStructure");
        }
        public static Task SetDataStructure(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeView_SetOption", dxTarget, "dataStructure", value);
        }
        public static Task<bool?> GetExpandAllEnabled(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxTreeView_GetOption", dxTarget, "expandAllEnabled");
        }
        public static Task SetExpandAllEnabled(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeView_SetOption", dxTarget, "expandAllEnabled", value);
        }
        public static Task<object> GetExpandedExpr(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeView_GetOption", dxTarget, "expandedExpr");
        }
        public static Task SetExpandedExpr(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeView_SetOption", dxTarget, "expandedExpr", value);
        }
        public static Task<bool?> GetExpandNodesRecursive(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxTreeView_GetOption", dxTarget, "expandNodesRecursive");
        }
        public static Task SetExpandNodesRecursive(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeView_SetOption", dxTarget, "expandNodesRecursive", value);
        }
        public static Task<object> GetHasItemsExpr(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeView_GetOption", dxTarget, "hasItemsExpr");
        }
        public static Task SetHasItemsExpr(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeView_SetOption", dxTarget, "hasItemsExpr", value);
        }
        public static Task<object> GetParentIdExpr(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeView_GetOption", dxTarget, "parentIdExpr");
        }
        public static Task SetParentIdExpr(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeView_SetOption", dxTarget, "parentIdExpr", value);
        }
        public static Task<object> GetRootValue(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeView_GetOption", dxTarget, "rootValue");
        }
        public static Task SetRootValue(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeView_SetOption", dxTarget, "rootValue", value);
        }
        public static Task<string> GetScrollDirection(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxTreeView_GetOption", dxTarget, "scrollDirection");
        }
        public static Task SetScrollDirection(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeView_SetOption", dxTarget, "scrollDirection", value);
        }
        public static Task<string> GetSelectAllText(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxTreeView_GetOption", dxTarget, "selectAllText");
        }
        public static Task SetSelectAllText(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeView_SetOption", dxTarget, "selectAllText", value);
        }
        public static Task<bool?> GetSelectByClick(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxTreeView_GetOption", dxTarget, "selectByClick");
        }
        public static Task SetSelectByClick(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeView_SetOption", dxTarget, "selectByClick", value);
        }
        public static Task<string> GetSelectionMode(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxTreeView_GetOption", dxTarget, "selectionMode");
        }
        public static Task SetSelectionMode(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeView_SetOption", dxTarget, "selectionMode", value);
        }
        public static Task<bool?> GetSelectNodesRecursive(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxTreeView_GetOption", dxTarget, "selectNodesRecursive");
        }
        public static Task SetSelectNodesRecursive(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeView_SetOption", dxTarget, "selectNodesRecursive", value);
        }
        public static Task<string> GetShowCheckBoxesMode(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxTreeView_GetOption", dxTarget, "showCheckBoxesMode");
        }
        public static Task SetShowCheckBoxesMode(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeView_SetOption", dxTarget, "showCheckBoxesMode", value);
        }
        public static Task<bool?> GetVirtualModeEnabled(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxTreeView_GetOption", dxTarget, "virtualModeEnabled");
        }
        public static Task SetVirtualModeEnabled(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeView_SetOption", dxTarget, "virtualModeEnabled", value);
        }
        public static Task<object> GetSearchEditorOptions(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeView_GetOption", dxTarget, "searchEditorOptions");
        }
        public static Task SetSearchEditorOptions(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeView_SetOption", dxTarget, "searchEditorOptions", value);
        }
        public static Task<bool?> GetSearchEnabled(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxTreeView_GetOption", dxTarget, "searchEnabled");
        }
        public static Task SetSearchEnabled(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeView_SetOption", dxTarget, "searchEnabled", value);
        }
        public static Task<object> GetSearchExpr(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeView_GetOption", dxTarget, "searchExpr");
        }
        public static Task SetSearchExpr(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeView_SetOption", dxTarget, "searchExpr", value);
        }
        public static Task<string> GetSearchMode(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxTreeView_GetOption", dxTarget, "searchMode");
        }
        public static Task SetSearchMode(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeView_SetOption", dxTarget, "searchMode", value);
        }
        public static Task<float?> GetSearchTimeout(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_DxTreeView_GetOption", dxTarget, "searchTimeout");
        }
        public static Task SetSearchTimeout(ElementReference dxTarget, float? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeView_SetOption", dxTarget, "searchTimeout", value);
        }
        public static Task<string> GetSearchValue(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxTreeView_GetOption", dxTarget, "searchValue");
        }
        public static Task SetSearchValue(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeView_SetOption", dxTarget, "searchValue", value);
        }
        public static Task CollapseItem(ElementReference dxTarget, object itemData)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeView_collapseItem_0", dxTarget, itemData);
        }
        public static Task ExpandItem(ElementReference dxTarget, object itemData)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeView_expandItem_3", dxTarget, itemData);
        }
        public static Task<object> GetNodes(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeView_getNodes_6", dxTarget);
        }
        public static Task SelectAll(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeView_selectAll_7", dxTarget);
        }
        public static Task SelectItem(ElementReference dxTarget, object itemData)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeView_selectItem_8", dxTarget, itemData);
        }
        public static Task UnselectAll(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeView_unselectAll_11", dxTarget);
        }
        public static Task UnselectItem(ElementReference dxTarget, object itemData)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeView_unselectItem_12", dxTarget, itemData);
        }
        public static Task<object> UpdateDimensions(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeView_updateDimensions_15", dxTarget);
        }
    }
    public class DxValidationGroupInterop: DOMComponentInterop
    {
        public static Task Init(ElementReference dxTarget, DevExpress.Ui.DxValidationGroupOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxValidationGroup_Init", dxTarget, json);
        }
        public static Task Reset(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxValidationGroup_reset_0", dxTarget);
        }
        public static Task<object> Validate(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxValidationGroup_validate_1", dxTarget);
        }
    }
    public class DxValidationSummaryInterop: CollectionWidgetInterop
    {
        public static Task Init(ElementReference dxTarget, DevExpress.Ui.DxValidationSummaryOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxValidationSummary_Init", dxTarget, json);
        }
        public static Task<string> GetValidationGroup(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxValidationSummary_GetOption", dxTarget, "validationGroup");
        }
        public static Task SetValidationGroup(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxValidationSummary_SetOption", dxTarget, "validationGroup", value);
        }
    }
    public class DxValidatorInterop: DOMComponentInterop
    {
        public static event EventHandler<JQueryEventArgs> Validated;
        public static Task Init(ElementReference dxTarget, DevExpress.Ui.DxValidatorOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxValidator_Init", dxTarget, json);
        }
        [JSInvokable("DevExpress.Ui.DxValidatorInterop.OnValidated")]
        public static void OnValidated(string identifier)
        {
            Validated?.Invoke(null, new JQueryEventArgs(identifier));
        }
        public static Task<object> GetAdapter(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxValidator_GetOption", dxTarget, "adapter");
        }
        public static Task SetAdapter(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxValidator_SetOption", dxTarget, "adapter", value);
        }
        public static Task<string> GetName(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxValidator_GetOption", dxTarget, "name");
        }
        public static Task SetName(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxValidator_SetOption", dxTarget, "name", value);
        }
        public static Task<string> GetValidationGroup(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxValidator_GetOption", dxTarget, "validationGroup");
        }
        public static Task SetValidationGroup(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxValidator_SetOption", dxTarget, "validationGroup", value);
        }
        public static Task<object> GetValidationRules(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxValidator_GetOption", dxTarget, "validationRules");
        }
        public static Task SetValidationRules(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxValidator_SetOption", dxTarget, "validationRules", value);
        }
        public static Task Focus(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxValidator_focus_0", dxTarget);
        }
        public static Task Reset(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxValidator_reset_1", dxTarget);
        }
        public static Task<object> Validate(ElementReference dxTarget)
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
        public static Task Init(ElementReference dxTarget, DevExpress.Ui.CollectionWidgetOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_CollectionWidget_Init", dxTarget, json);
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
        public static Task<object> GetDataSource(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_CollectionWidget_GetOption", dxTarget, "dataSource");
        }
        public static Task SetDataSource(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_CollectionWidget_SetOption", dxTarget, "dataSource", value);
        }
        public static Task<float?> GetItemHoldTimeout(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_CollectionWidget_GetOption", dxTarget, "itemHoldTimeout");
        }
        public static Task SetItemHoldTimeout(ElementReference dxTarget, float? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_CollectionWidget_SetOption", dxTarget, "itemHoldTimeout", value);
        }
        public static Task<object> GetItems(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_CollectionWidget_GetOption", dxTarget, "items");
        }
        public static Task SetItems(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_CollectionWidget_SetOption", dxTarget, "items", value);
        }
        public static Task<object> GetItemTemplate(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_CollectionWidget_GetOption", dxTarget, "itemTemplate");
        }
        public static Task SetItemTemplate(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_CollectionWidget_SetOption", dxTarget, "itemTemplate", value);
        }
        public static Task<object> GetKeyExpr(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_CollectionWidget_GetOption", dxTarget, "keyExpr");
        }
        public static Task SetKeyExpr(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_CollectionWidget_SetOption", dxTarget, "keyExpr", value);
        }
        public static Task<string> GetNoDataText(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_CollectionWidget_GetOption", dxTarget, "noDataText");
        }
        public static Task SetNoDataText(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_CollectionWidget_SetOption", dxTarget, "noDataText", value);
        }
        public static Task<float?> GetSelectedIndex(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_CollectionWidget_GetOption", dxTarget, "selectedIndex");
        }
        public static Task SetSelectedIndex(ElementReference dxTarget, float? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_CollectionWidget_SetOption", dxTarget, "selectedIndex", value);
        }
        public static Task<object> GetSelectedItem(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_CollectionWidget_GetOption", dxTarget, "selectedItem");
        }
        public static Task SetSelectedItem(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_CollectionWidget_SetOption", dxTarget, "selectedItem", value);
        }
        public static Task<object> GetSelectedItemKeys(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_CollectionWidget_GetOption", dxTarget, "selectedItemKeys");
        }
        public static Task SetSelectedItemKeys(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_CollectionWidget_SetOption", dxTarget, "selectedItemKeys", value);
        }
        public static Task<object> GetSelectedItems(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_CollectionWidget_GetOption", dxTarget, "selectedItems");
        }
        public static Task SetSelectedItems(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_CollectionWidget_SetOption", dxTarget, "selectedItems", value);
        }
        public static Task<object> GetDataSourceEx(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_CollectionWidget_getDataSource_0", dxTarget);
        }
    }
    public class DxMenuBaseInterop: HierarchicalCollectionWidgetInterop
    {
        public static Task Init(ElementReference dxTarget, DevExpress.Ui.DxMenuBaseOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxMenuBase_Init", dxTarget, json);
        }
        public static Task<object> GetAnimation(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxMenuBase_GetOption", dxTarget, "animation");
        }
        public static Task SetAnimation(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxMenuBase_SetOption", dxTarget, "animation", value);
        }
        public static Task<string> GetCssClass(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxMenuBase_GetOption", dxTarget, "cssClass");
        }
        public static Task SetCssClass(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxMenuBase_SetOption", dxTarget, "cssClass", value);
        }
        public static Task<bool?> GetSelectByClick(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxMenuBase_GetOption", dxTarget, "selectByClick");
        }
        public static Task SetSelectByClick(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxMenuBase_SetOption", dxTarget, "selectByClick", value);
        }
        public static Task<string> GetSelectionMode(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxMenuBase_GetOption", dxTarget, "selectionMode");
        }
        public static Task SetSelectionMode(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxMenuBase_SetOption", dxTarget, "selectionMode", value);
        }
        public static Task<object> GetShowSubmenuMode(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxMenuBase_GetOption", dxTarget, "showSubmenuMode");
        }
        public static Task SetShowSubmenuMode(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxMenuBase_SetOption", dxTarget, "showSubmenuMode", value);
        }
        public static Task SelectItem(ElementReference dxTarget, object itemElement)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxMenuBase_selectItem_0", dxTarget, itemElement);
        }
        public static Task UnselectItem(ElementReference dxTarget, object itemElement)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxMenuBase_unselectItem_1", dxTarget, itemElement);
        }
    }
    public class DxDropDownEditorInterop: DxTextBoxInterop
    {
        public static event EventHandler<JQueryEventArgs> Closed;
        public static event EventHandler<JQueryEventArgs> Opened;
        public static Task Init(ElementReference dxTarget, DevExpress.Ui.DxDropDownEditorOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDropDownEditor_Init", dxTarget, json);
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
        public static Task<bool?> GetAcceptCustomValue(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxDropDownEditor_GetOption", dxTarget, "acceptCustomValue");
        }
        public static Task SetAcceptCustomValue(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDropDownEditor_SetOption", dxTarget, "acceptCustomValue", value);
        }
        public static Task<string> GetApplyValueMode(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxDropDownEditor_GetOption", dxTarget, "applyValueMode");
        }
        public static Task SetApplyValueMode(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDropDownEditor_SetOption", dxTarget, "applyValueMode", value);
        }
        public static Task<bool?> GetDeferRendering(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxDropDownEditor_GetOption", dxTarget, "deferRendering");
        }
        public static Task SetDeferRendering(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDropDownEditor_SetOption", dxTarget, "deferRendering", value);
        }
        public static Task<object> GetDropDownButtonTemplate(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDropDownEditor_GetOption", dxTarget, "dropDownButtonTemplate");
        }
        public static Task SetDropDownButtonTemplate(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDropDownEditor_SetOption", dxTarget, "dropDownButtonTemplate", value);
        }
        public static Task<bool?> GetOpened(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxDropDownEditor_GetOption", dxTarget, "opened");
        }
        public static Task SetOpened(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDropDownEditor_SetOption", dxTarget, "opened", value);
        }
        public static Task Close(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDropDownEditor_close_0", dxTarget);
        }
        public static Task<object> Content(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDropDownEditor_content_1", dxTarget);
        }
        public static Task<object> Field(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDropDownEditor_field_2", dxTarget);
        }
        public static Task Open(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDropDownEditor_open_3", dxTarget);
        }
        public static Task Reset(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDropDownEditor_reset_4", dxTarget);
        }
    }
    public class DxDropDownListInterop: DxDropDownEditorInterop
    {
        public static event EventHandler<JQueryEventArgs> ItemClick;
        public static event EventHandler<JQueryEventArgs> SelectionChanged;
        public static Task Init(ElementReference dxTarget, DevExpress.Ui.DxDropDownListOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDropDownList_Init", dxTarget, json);
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
        public static Task<string> GetDisplayValue(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxDropDownList_GetOption", dxTarget, "displayValue");
        }
        public static Task SetDisplayValue(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDropDownList_SetOption", dxTarget, "displayValue", value);
        }
        public static Task<bool?> GetGrouped(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxDropDownList_GetOption", dxTarget, "grouped");
        }
        public static Task SetGrouped(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDropDownList_SetOption", dxTarget, "grouped", value);
        }
        public static Task<object> GetGroupTemplate(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDropDownList_GetOption", dxTarget, "groupTemplate");
        }
        public static Task SetGroupTemplate(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDropDownList_SetOption", dxTarget, "groupTemplate", value);
        }
        public static Task<float?> GetMinSearchLength(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_DxDropDownList_GetOption", dxTarget, "minSearchLength");
        }
        public static Task SetMinSearchLength(ElementReference dxTarget, float? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDropDownList_SetOption", dxTarget, "minSearchLength", value);
        }
        public static Task<string> GetNoDataText(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxDropDownList_GetOption", dxTarget, "noDataText");
        }
        public static Task SetNoDataText(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDropDownList_SetOption", dxTarget, "noDataText", value);
        }
        public static Task<bool?> GetSearchEnabled(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxDropDownList_GetOption", dxTarget, "searchEnabled");
        }
        public static Task SetSearchEnabled(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDropDownList_SetOption", dxTarget, "searchEnabled", value);
        }
        public static Task<object> GetSearchExpr(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDropDownList_GetOption", dxTarget, "searchExpr");
        }
        public static Task SetSearchExpr(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDropDownList_SetOption", dxTarget, "searchExpr", value);
        }
        public static Task<string> GetSearchMode(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxDropDownList_GetOption", dxTarget, "searchMode");
        }
        public static Task SetSearchMode(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDropDownList_SetOption", dxTarget, "searchMode", value);
        }
        public static Task<float?> GetSearchTimeout(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_DxDropDownList_GetOption", dxTarget, "searchTimeout");
        }
        public static Task SetSearchTimeout(ElementReference dxTarget, float? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDropDownList_SetOption", dxTarget, "searchTimeout", value);
        }
        public static Task<object> GetSelectedItem(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDropDownList_GetOption", dxTarget, "selectedItem");
        }
        public static Task SetSelectedItem(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDropDownList_SetOption", dxTarget, "selectedItem", value);
        }
        public static Task<bool?> GetShowDataBeforeSearch(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxDropDownList_GetOption", dxTarget, "showDataBeforeSearch");
        }
        public static Task SetShowDataBeforeSearch(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDropDownList_SetOption", dxTarget, "showDataBeforeSearch", value);
        }
        public static Task<object> GetDataSource(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDropDownList_GetOption", dxTarget, "dataSource");
        }
        public static Task SetDataSource(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDropDownList_SetOption", dxTarget, "dataSource", value);
        }
        public static Task<object> GetDisplayExpr(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDropDownList_GetOption", dxTarget, "displayExpr");
        }
        public static Task SetDisplayExpr(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDropDownList_SetOption", dxTarget, "displayExpr", value);
        }
        public static Task<object> GetItems(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDropDownList_GetOption", dxTarget, "items");
        }
        public static Task SetItems(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDropDownList_SetOption", dxTarget, "items", value);
        }
        public static Task<object> GetItemTemplate(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDropDownList_GetOption", dxTarget, "itemTemplate");
        }
        public static Task SetItemTemplate(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDropDownList_SetOption", dxTarget, "itemTemplate", value);
        }
        public static Task<object> GetValueExpr(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDropDownList_GetOption", dxTarget, "valueExpr");
        }
        public static Task SetValueExpr(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDropDownList_SetOption", dxTarget, "valueExpr", value);
        }
        public static Task<object> GetDataSourceEx(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDropDownList_getDataSource_0", dxTarget);
        }
    }
    public class EditorInterop: WidgetInterop
    {
        public static event EventHandler<(JQueryEventArgs, string)> ValueChanged;

        public static Task Init(ElementReference dxTarget, DevExpress.Ui.EditorOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Editor_Init", dxTarget, json);
        }
        [JSInvokable("DevExpress.Ui.EditorInterop.OnValueChanged")]
        public static void OnValueChanged(string identifier, string value)
        {
            ValueChanged?.Invoke(null, (new JQueryEventArgs(identifier), value));
        }

        public static Task<bool?> GetIsValid(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_Editor_GetOption", dxTarget, "isValid");
        }
        public static Task SetIsValid(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Editor_SetOption", dxTarget, "isValid", value);
        }
        public static Task<bool?> GetReadOnly(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_Editor_GetOption", dxTarget, "readOnly");
        }
        public static Task SetReadOnly(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Editor_SetOption", dxTarget, "readOnly", value);
        }
        public static Task<object> GetValidationError(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Editor_GetOption", dxTarget, "validationError");
        }
        public static Task SetValidationError(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Editor_SetOption", dxTarget, "validationError", value);
        }
        public static Task<string> GetValidationMessageMode(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_Editor_GetOption", dxTarget, "validationMessageMode");
        }
        public static Task SetValidationMessageMode(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Editor_SetOption", dxTarget, "validationMessageMode", value);
        }
        public static Task<object> GetValue(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Editor_GetOption", dxTarget, "value");
        }
        public static Task SetValue(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Editor_SetOption", dxTarget, "value", value);
        }
        public static Task Reset(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Editor_reset_0", dxTarget);
        }
    }
    public class DataExpressionMixinInterop
    {
        public static Task Init(ElementReference dxTarget, DevExpress.Ui.DataExpressionMixinOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DataExpressionMixin_Init", dxTarget, json);
        }
        public static Task<object> GetDataSource(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DataExpressionMixin_GetOption", dxTarget, "dataSource");
        }
        public static Task SetDataSource(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DataExpressionMixin_SetOption", dxTarget, "dataSource", value);
        }
        public static Task<object> GetDisplayExpr(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DataExpressionMixin_GetOption", dxTarget, "displayExpr");
        }
        public static Task SetDisplayExpr(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DataExpressionMixin_SetOption", dxTarget, "displayExpr", value);
        }
        public static Task<object> GetItems(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DataExpressionMixin_GetOption", dxTarget, "items");
        }
        public static Task SetItems(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DataExpressionMixin_SetOption", dxTarget, "items", value);
        }
        public static Task<object> GetItemTemplate(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DataExpressionMixin_GetOption", dxTarget, "itemTemplate");
        }
        public static Task SetItemTemplate(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DataExpressionMixin_SetOption", dxTarget, "itemTemplate", value);
        }
        public static Task<object> GetValue(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DataExpressionMixin_GetOption", dxTarget, "value");
        }
        public static Task SetValue(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DataExpressionMixin_SetOption", dxTarget, "value", value);
        }
        public static Task<object> GetValueExpr(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DataExpressionMixin_GetOption", dxTarget, "valueExpr");
        }
        public static Task SetValueExpr(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DataExpressionMixin_SetOption", dxTarget, "valueExpr", value);
        }
        public static Task<object> GetDataSourceEx(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DataExpressionMixin_getDataSource_0", dxTarget);
        }
    }
    public class HierarchicalCollectionWidgetInterop: CollectionWidgetInterop
    {
        public static Task Init(ElementReference dxTarget, DevExpress.Ui.HierarchicalCollectionWidgetOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_HierarchicalCollectionWidget_Init", dxTarget, json);
        }
        public static Task<object> GetDisabledExpr(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_HierarchicalCollectionWidget_GetOption", dxTarget, "disabledExpr");
        }
        public static Task SetDisabledExpr(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_HierarchicalCollectionWidget_SetOption", dxTarget, "disabledExpr", value);
        }
        public static Task<object> GetDisplayExpr(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_HierarchicalCollectionWidget_GetOption", dxTarget, "displayExpr");
        }
        public static Task SetDisplayExpr(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_HierarchicalCollectionWidget_SetOption", dxTarget, "displayExpr", value);
        }
        public static Task<object> GetItemsExpr(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_HierarchicalCollectionWidget_GetOption", dxTarget, "itemsExpr");
        }
        public static Task SetItemsExpr(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_HierarchicalCollectionWidget_SetOption", dxTarget, "itemsExpr", value);
        }
        public static Task<object> GetSelectedExpr(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_HierarchicalCollectionWidget_GetOption", dxTarget, "selectedExpr");
        }
        public static Task SetSelectedExpr(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_HierarchicalCollectionWidget_SetOption", dxTarget, "selectedExpr", value);
        }
    }
    public class DxPivotGridSummaryCellInterop
    {
        public static Task<object> Child(ElementReference dxTarget, string direction, object fieldValue)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPivotGridSummaryCell_child_0", dxTarget, direction, fieldValue);
        }
        public static Task<object> Children(ElementReference dxTarget, string direction)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPivotGridSummaryCell_children_1", dxTarget, direction);
        }
        public static Task<object> Field(ElementReference dxTarget, string area)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPivotGridSummaryCell_field_2", dxTarget, area);
        }
        public static Task<object> GrandTotal(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPivotGridSummaryCell_grandTotal_3", dxTarget);
        }
        public static Task<object> GrandTotal(ElementReference dxTarget, string direction)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPivotGridSummaryCell_grandTotal_4", dxTarget, direction);
        }
        public static Task<object> Next(ElementReference dxTarget, string direction)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPivotGridSummaryCell_next_5", dxTarget, direction);
        }
        public static Task<object> Next(ElementReference dxTarget, string direction, bool allowCrossGroup)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPivotGridSummaryCell_next_6", dxTarget, direction, allowCrossGroup);
        }
        public static Task<object> Parent(ElementReference dxTarget, string direction)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPivotGridSummaryCell_parent_7", dxTarget, direction);
        }
        public static Task<object> Prev(ElementReference dxTarget, string direction)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPivotGridSummaryCell_prev_8", dxTarget, direction);
        }
        public static Task<object> Prev(ElementReference dxTarget, string direction, bool allowCrossGroup)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPivotGridSummaryCell_prev_9", dxTarget, direction, allowCrossGroup);
        }
        public static Task<object> Slice(ElementReference dxTarget, object field, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPivotGridSummaryCell_slice_10", dxTarget, field, value);
        }
        public static Task<object> ValueEx(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPivotGridSummaryCell_value_11", dxTarget);
        }
        public static Task<object> ValueEx(ElementReference dxTarget, object field)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPivotGridSummaryCell_value_12", dxTarget, field);
        }
        public static Task<object> ValueEx(ElementReference dxTarget, object field, bool isCalculatedValue)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPivotGridSummaryCell_value_13", dxTarget, field, isCalculatedValue);
        }
        public static Task<object> ValueEx(ElementReference dxTarget, bool isCalculatedValue)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPivotGridSummaryCell_value_14", dxTarget, isCalculatedValue);
        }
    }
    public class DxScrollableInterop: DOMComponentInterop
    {
        public static event EventHandler<JQueryEventArgs> Scroll;
        public static event EventHandler<JQueryEventArgs> Updated;
        public static Task Init(ElementReference dxTarget, DevExpress.Ui.DxScrollableOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScrollable_Init", dxTarget, json);
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
        public static Task<bool?> GetBounceEnabled(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxScrollable_GetOption", dxTarget, "bounceEnabled");
        }
        public static Task SetBounceEnabled(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScrollable_SetOption", dxTarget, "bounceEnabled", value);
        }
        public static Task<string> GetDirection(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxScrollable_GetOption", dxTarget, "direction");
        }
        public static Task SetDirection(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScrollable_SetOption", dxTarget, "direction", value);
        }
        public static Task<bool?> GetDisabled(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxScrollable_GetOption", dxTarget, "disabled");
        }
        public static Task SetDisabled(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScrollable_SetOption", dxTarget, "disabled", value);
        }
        public static Task<bool?> GetScrollByContent(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxScrollable_GetOption", dxTarget, "scrollByContent");
        }
        public static Task SetScrollByContent(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScrollable_SetOption", dxTarget, "scrollByContent", value);
        }
        public static Task<bool?> GetScrollByThumb(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxScrollable_GetOption", dxTarget, "scrollByThumb");
        }
        public static Task SetScrollByThumb(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScrollable_SetOption", dxTarget, "scrollByThumb", value);
        }
        public static Task<string> GetShowScrollbar(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxScrollable_GetOption", dxTarget, "showScrollbar");
        }
        public static Task SetShowScrollbar(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScrollable_SetOption", dxTarget, "showScrollbar", value);
        }
        public static Task<bool?> GetUseNative(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxScrollable_GetOption", dxTarget, "useNative");
        }
        public static Task SetUseNative(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScrollable_SetOption", dxTarget, "useNative", value);
        }
        public static Task<float> ClientHeight(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<float>("BlazorDevExtreme_DxScrollable_clientHeight_0", dxTarget);
        }
        public static Task<float> ClientWidth(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<float>("BlazorDevExtreme_DxScrollable_clientWidth_1", dxTarget);
        }
        public static Task<object> Content(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScrollable_content_2", dxTarget);
        }
        public static Task ScrollBy(ElementReference dxTarget, float distance)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScrollable_scrollBy_3", dxTarget, distance);
        }
        public static Task ScrollBy(ElementReference dxTarget, object distanceObject)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScrollable_scrollBy_4", dxTarget, distanceObject);
        }
        public static Task<float> ScrollHeight(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<float>("BlazorDevExtreme_DxScrollable_scrollHeight_5", dxTarget);
        }
        public static Task<float> ScrollLeft(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<float>("BlazorDevExtreme_DxScrollable_scrollLeft_6", dxTarget);
        }
        public static Task<object> ScrollOffset(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScrollable_scrollOffset_7", dxTarget);
        }
        public static Task ScrollTo(ElementReference dxTarget, float targetLocation)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScrollable_scrollTo_8", dxTarget, targetLocation);
        }
        public static Task ScrollTo(ElementReference dxTarget, object targetLocation)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScrollable_scrollTo_9", dxTarget, targetLocation);
        }
        public static Task ScrollToElement(ElementReference dxTarget, object element)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScrollable_scrollToElement_10", dxTarget, element);
        }
        public static Task<float> ScrollTop(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<float>("BlazorDevExtreme_DxScrollable_scrollTop_11", dxTarget);
        }
        public static Task<float> ScrollWidth(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<float>("BlazorDevExtreme_DxScrollable_scrollWidth_12", dxTarget);
        }
        public static Task<object> Update(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScrollable_update_13", dxTarget);
        }
    }
    public class DxSliderBaseInterop: DxTrackBarInterop
    {
        public static Task Init(ElementReference dxTarget, DevExpress.Ui.DxSliderBaseOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxSliderBase_Init", dxTarget, json);
        }
        public static Task<float?> GetKeyStep(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_DxSliderBase_GetOption", dxTarget, "keyStep");
        }
        public static Task SetKeyStep(ElementReference dxTarget, float? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxSliderBase_SetOption", dxTarget, "keyStep", value);
        }
        public static Task<object> GetLabel(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxSliderBase_GetOption", dxTarget, "label");
        }
        public static Task SetLabel(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxSliderBase_SetOption", dxTarget, "label", value);
        }
        public static Task<string> GetName(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxSliderBase_GetOption", dxTarget, "name");
        }
        public static Task SetName(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxSliderBase_SetOption", dxTarget, "name", value);
        }
        public static Task<bool?> GetShowRange(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxSliderBase_GetOption", dxTarget, "showRange");
        }
        public static Task SetShowRange(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxSliderBase_SetOption", dxTarget, "showRange", value);
        }
        public static Task<float?> GetStep(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_DxSliderBase_GetOption", dxTarget, "step");
        }
        public static Task SetStep(ElementReference dxTarget, float? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxSliderBase_SetOption", dxTarget, "step", value);
        }
        public static Task<object> GetTooltip(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxSliderBase_GetOption", dxTarget, "tooltip");
        }
        public static Task SetTooltip(ElementReference dxTarget, object value)
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
        public static Task Init(ElementReference dxTarget, DevExpress.Ui.DxTextEditorOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTextEditor_Init", dxTarget, json);
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
        public static Task<object> GetInputAttr(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTextEditor_GetOption", dxTarget, "inputAttr");
        }
        public static Task SetInputAttr(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTextEditor_SetOption", dxTarget, "inputAttr", value);
        }
        public static Task<string> GetMask(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxTextEditor_GetOption", dxTarget, "mask");
        }
        public static Task SetMask(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTextEditor_SetOption", dxTarget, "mask", value);
        }
        public static Task<string> GetMaskChar(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxTextEditor_GetOption", dxTarget, "maskChar");
        }
        public static Task SetMaskChar(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTextEditor_SetOption", dxTarget, "maskChar", value);
        }
        public static Task<string> GetMaskInvalidMessage(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxTextEditor_GetOption", dxTarget, "maskInvalidMessage");
        }
        public static Task SetMaskInvalidMessage(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTextEditor_SetOption", dxTarget, "maskInvalidMessage", value);
        }
        public static Task<object> GetMaskRules(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTextEditor_GetOption", dxTarget, "maskRules");
        }
        public static Task SetMaskRules(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTextEditor_SetOption", dxTarget, "maskRules", value);
        }
        public static Task<string> GetName(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxTextEditor_GetOption", dxTarget, "name");
        }
        public static Task SetName(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTextEditor_SetOption", dxTarget, "name", value);
        }
        public static Task<string> GetPlaceholder(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxTextEditor_GetOption", dxTarget, "placeholder");
        }
        public static Task SetPlaceholder(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTextEditor_SetOption", dxTarget, "placeholder", value);
        }
        public static Task<bool?> GetShowClearButton(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxTextEditor_GetOption", dxTarget, "showClearButton");
        }
        public static Task SetShowClearButton(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTextEditor_SetOption", dxTarget, "showClearButton", value);
        }
        public static Task<string> GetShowMaskMode(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxTextEditor_GetOption", dxTarget, "showMaskMode");
        }
        public static Task SetShowMaskMode(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTextEditor_SetOption", dxTarget, "showMaskMode", value);
        }
        public static Task<bool?> GetSpellcheck(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxTextEditor_GetOption", dxTarget, "spellcheck");
        }
        public static Task SetSpellcheck(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTextEditor_SetOption", dxTarget, "spellcheck", value);
        }
        public static Task<string> GetText(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxTextEditor_GetOption", dxTarget, "text");
        }
        public static Task SetText(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTextEditor_SetOption", dxTarget, "text", value);
        }
        public static Task<bool?> GetUseMaskedValue(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxTextEditor_GetOption", dxTarget, "useMaskedValue");
        }
        public static Task SetUseMaskedValue(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTextEditor_SetOption", dxTarget, "useMaskedValue", value);
        }
        public static Task<string> GetValueChangeEvent(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxTextEditor_GetOption", dxTarget, "valueChangeEvent");
        }
        public static Task SetValueChangeEvent(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTextEditor_SetOption", dxTarget, "valueChangeEvent", value);
        }
        public static Task Blur(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTextEditor_blur_0", dxTarget);
        }
        public static Task Focus(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTextEditor_focus_1", dxTarget);
        }
    }
    public class SearchBoxMixinInterop
    {
        public static Task Init(ElementReference dxTarget, DevExpress.Ui.SearchBoxMixinOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_SearchBoxMixin_Init", dxTarget, json);
        }
        public static Task<object> GetSearchEditorOptions(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_SearchBoxMixin_GetOption", dxTarget, "searchEditorOptions");
        }
        public static Task SetSearchEditorOptions(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_SearchBoxMixin_SetOption", dxTarget, "searchEditorOptions", value);
        }
        public static Task<bool?> GetSearchEnabled(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_SearchBoxMixin_GetOption", dxTarget, "searchEnabled");
        }
        public static Task SetSearchEnabled(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_SearchBoxMixin_SetOption", dxTarget, "searchEnabled", value);
        }
        public static Task<object> GetSearchExpr(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_SearchBoxMixin_GetOption", dxTarget, "searchExpr");
        }
        public static Task SetSearchExpr(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_SearchBoxMixin_SetOption", dxTarget, "searchExpr", value);
        }
        public static Task<string> GetSearchMode(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_SearchBoxMixin_GetOption", dxTarget, "searchMode");
        }
        public static Task SetSearchMode(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_SearchBoxMixin_SetOption", dxTarget, "searchMode", value);
        }
        public static Task<float?> GetSearchTimeout(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_SearchBoxMixin_GetOption", dxTarget, "searchTimeout");
        }
        public static Task SetSearchTimeout(ElementReference dxTarget, float? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_SearchBoxMixin_SetOption", dxTarget, "searchTimeout", value);
        }
        public static Task<string> GetSearchValue(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_SearchBoxMixin_GetOption", dxTarget, "searchValue");
        }
        public static Task SetSearchValue(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_SearchBoxMixin_SetOption", dxTarget, "searchValue", value);
        }
    }
    public class DxTemplateInterop
    {
        public static Task Init(ElementReference dxTarget, DevExpress.Ui.DxTemplateOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTemplate_Init", dxTarget, json);
        }
        public static Task<string> GetName(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxTemplate_GetOption", dxTarget, "name");
        }
        public static Task SetName(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTemplate_SetOption", dxTarget, "name", value);
        }
    }
    public class WidgetInterop: DOMComponentInterop
    {
        public static event EventHandler<JQueryEventArgs> ContentReady;
        public static Task Init(ElementReference dxTarget, DevExpress.Ui.WidgetOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Widget_Init", dxTarget, json);
        }
        [JSInvokable("DevExpress.Ui.WidgetInterop.OnContentReady")]
        public static void OnContentReady(string identifier)
        {
            ContentReady?.Invoke(null, new JQueryEventArgs(identifier));
        }
        public static Task<string> GetAccessKey(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_Widget_GetOption", dxTarget, "accessKey");
        }
        public static Task SetAccessKey(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Widget_SetOption", dxTarget, "accessKey", value);
        }
        public static Task<bool?> GetActiveStateEnabled(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_Widget_GetOption", dxTarget, "activeStateEnabled");
        }
        public static Task SetActiveStateEnabled(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Widget_SetOption", dxTarget, "activeStateEnabled", value);
        }
        public static Task<bool?> GetDisabled(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_Widget_GetOption", dxTarget, "disabled");
        }
        public static Task SetDisabled(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Widget_SetOption", dxTarget, "disabled", value);
        }
        public static Task<bool?> GetFocusStateEnabled(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_Widget_GetOption", dxTarget, "focusStateEnabled");
        }
        public static Task SetFocusStateEnabled(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Widget_SetOption", dxTarget, "focusStateEnabled", value);
        }
        public static Task<string> GetHint(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_Widget_GetOption", dxTarget, "hint");
        }
        public static Task SetHint(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Widget_SetOption", dxTarget, "hint", value);
        }
        public static Task<bool?> GetHoverStateEnabled(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_Widget_GetOption", dxTarget, "hoverStateEnabled");
        }
        public static Task SetHoverStateEnabled(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Widget_SetOption", dxTarget, "hoverStateEnabled", value);
        }
        public static Task<float?> GetTabIndex(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_Widget_GetOption", dxTarget, "tabIndex");
        }
        public static Task SetTabIndex(ElementReference dxTarget, float? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Widget_SetOption", dxTarget, "tabIndex", value);
        }
        public static Task<bool?> GetVisible(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_Widget_GetOption", dxTarget, "visible");
        }
        public static Task SetVisible(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Widget_SetOption", dxTarget, "visible", value);
        }
        public static Task Focus(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Widget_focus_0", dxTarget);
        }
        public static Task RegisterKeyHandler(ElementReference dxTarget, string key, object handler)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Widget_registerKeyHandler_1", dxTarget, key, handler);
        }
        public static Task Repaint(ElementReference dxTarget)
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
        public static Task Init(ElementReference dxTarget, DevExpress.Viz.BaseWidgetOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BaseWidget_Init", dxTarget, json);
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
        public static Task<object> GetExport(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BaseWidget_GetOption", dxTarget, "export");
        }
        public static Task SetExport(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BaseWidget_SetOption", dxTarget, "export", value);
        }
        public static Task<object> GetLoadingIndicator(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BaseWidget_GetOption", dxTarget, "loadingIndicator");
        }
        public static Task SetLoadingIndicator(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BaseWidget_SetOption", dxTarget, "loadingIndicator", value);
        }
        public static Task<object> GetMargin(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BaseWidget_GetOption", dxTarget, "margin");
        }
        public static Task SetMargin(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BaseWidget_SetOption", dxTarget, "margin", value);
        }
        public static Task<bool?> GetPathModified(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_BaseWidget_GetOption", dxTarget, "pathModified");
        }
        public static Task SetPathModified(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BaseWidget_SetOption", dxTarget, "pathModified", value);
        }
        public static Task<bool?> GetRedrawOnResize(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_BaseWidget_GetOption", dxTarget, "redrawOnResize");
        }
        public static Task SetRedrawOnResize(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BaseWidget_SetOption", dxTarget, "redrawOnResize", value);
        }
        public static Task<object> GetSize(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BaseWidget_GetOption", dxTarget, "size");
        }
        public static Task SetSize(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BaseWidget_SetOption", dxTarget, "size", value);
        }
        public static Task<string> GetTheme(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_BaseWidget_GetOption", dxTarget, "theme");
        }
        public static Task SetTheme(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BaseWidget_SetOption", dxTarget, "theme", value);
        }
        public static Task<object> GetTitle(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BaseWidget_GetOption", dxTarget, "title");
        }
        public static Task SetTitle(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BaseWidget_SetOption", dxTarget, "title", value);
        }
        public static Task<object> GetTooltip(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BaseWidget_GetOption", dxTarget, "tooltip");
        }
        public static Task SetTooltip(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BaseWidget_SetOption", dxTarget, "tooltip", value);
        }
        public static Task ExportTo(ElementReference dxTarget, string fileName, string format)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BaseWidget_exportTo_0", dxTarget, fileName, format);
        }
        public static Task<object> GetSizeEx(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BaseWidget_getSize_1", dxTarget);
        }
        public static Task HideLoadingIndicator(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BaseWidget_hideLoadingIndicator_2", dxTarget);
        }
        public static Task Print(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BaseWidget_print_3", dxTarget);
        }
        public static Task Render(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BaseWidget_render_4", dxTarget);
        }
        public static Task ShowLoadingIndicator(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BaseWidget_showLoadingIndicator_5", dxTarget);
        }
        public static Task<string> Svg(ElementReference dxTarget)
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
        public static Task Init(ElementReference dxTarget, DevExpress.Viz.Charts.DxChartOptions options)
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
        public static Task<bool?> GetAdjustOnZoom(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxChart_GetOption", dxTarget, "adjustOnZoom");
        }
        public static Task SetAdjustOnZoom(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxChart_SetOption", dxTarget, "adjustOnZoom", value);
        }
        public static Task<object> GetArgumentAxis(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxChart_GetOption", dxTarget, "argumentAxis");
        }
        public static Task SetArgumentAxis(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxChart_SetOption", dxTarget, "argumentAxis", value);
        }
        public static Task<float?> GetBarGroupPadding(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_DxChart_GetOption", dxTarget, "barGroupPadding");
        }
        public static Task SetBarGroupPadding(ElementReference dxTarget, float? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxChart_SetOption", dxTarget, "barGroupPadding", value);
        }
        public static Task<float?> GetBarGroupWidth(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_DxChart_GetOption", dxTarget, "barGroupWidth");
        }
        public static Task SetBarGroupWidth(ElementReference dxTarget, float? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxChart_SetOption", dxTarget, "barGroupWidth", value);
        }
        public static Task<float?> GetBarWidth(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_DxChart_GetOption", dxTarget, "barWidth");
        }
        public static Task SetBarWidth(ElementReference dxTarget, float? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxChart_SetOption", dxTarget, "barWidth", value);
        }
        public static Task<object> GetCommonAxisSettings(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxChart_GetOption", dxTarget, "commonAxisSettings");
        }
        public static Task SetCommonAxisSettings(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxChart_SetOption", dxTarget, "commonAxisSettings", value);
        }
        public static Task<object> GetCommonPaneSettings(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxChart_GetOption", dxTarget, "commonPaneSettings");
        }
        public static Task SetCommonPaneSettings(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxChart_SetOption", dxTarget, "commonPaneSettings", value);
        }
        public static Task<object> GetCommonSeriesSettings(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxChart_GetOption", dxTarget, "commonSeriesSettings");
        }
        public static Task SetCommonSeriesSettings(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxChart_SetOption", dxTarget, "commonSeriesSettings", value);
        }
        public static Task<string> GetContainerBackgroundColor(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxChart_GetOption", dxTarget, "containerBackgroundColor");
        }
        public static Task SetContainerBackgroundColor(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxChart_SetOption", dxTarget, "containerBackgroundColor", value);
        }
        public static Task<object> GetCrosshair(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxChart_GetOption", dxTarget, "crosshair");
        }
        public static Task SetCrosshair(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxChart_SetOption", dxTarget, "crosshair", value);
        }
        public static Task<object> GetDataPrepareSettings(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxChart_GetOption", dxTarget, "dataPrepareSettings");
        }
        public static Task SetDataPrepareSettings(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxChart_SetOption", dxTarget, "dataPrepareSettings", value);
        }
        public static Task<string> GetDefaultPane(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxChart_GetOption", dxTarget, "defaultPane");
        }
        public static Task SetDefaultPane(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxChart_SetOption", dxTarget, "defaultPane", value);
        }
        public static Task<bool?> GetEqualBarWidth(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxChart_GetOption", dxTarget, "equalBarWidth");
        }
        public static Task SetEqualBarWidth(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxChart_SetOption", dxTarget, "equalBarWidth", value);
        }
        public static Task<float?> GetMaxBubbleSize(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_DxChart_GetOption", dxTarget, "maxBubbleSize");
        }
        public static Task SetMaxBubbleSize(ElementReference dxTarget, float? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxChart_SetOption", dxTarget, "maxBubbleSize", value);
        }
        public static Task<float?> GetMinBubbleSize(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_DxChart_GetOption", dxTarget, "minBubbleSize");
        }
        public static Task SetMinBubbleSize(ElementReference dxTarget, float? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxChart_SetOption", dxTarget, "minBubbleSize", value);
        }
        public static Task<bool?> GetNegativesAsZeroes(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxChart_GetOption", dxTarget, "negativesAsZeroes");
        }
        public static Task SetNegativesAsZeroes(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxChart_SetOption", dxTarget, "negativesAsZeroes", value);
        }
        public static Task<object> GetPanes(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxChart_GetOption", dxTarget, "panes");
        }
        public static Task SetPanes(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxChart_SetOption", dxTarget, "panes", value);
        }
        public static Task<string> GetResolveLabelOverlapping(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxChart_GetOption", dxTarget, "resolveLabelOverlapping");
        }
        public static Task SetResolveLabelOverlapping(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxChart_SetOption", dxTarget, "resolveLabelOverlapping", value);
        }
        public static Task<bool?> GetRotated(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxChart_GetOption", dxTarget, "rotated");
        }
        public static Task SetRotated(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxChart_SetOption", dxTarget, "rotated", value);
        }
        public static Task<object> GetScrollBar(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxChart_GetOption", dxTarget, "scrollBar");
        }
        public static Task SetScrollBar(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxChart_SetOption", dxTarget, "scrollBar", value);
        }
        public static Task<string> GetScrollingMode(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxChart_GetOption", dxTarget, "scrollingMode");
        }
        public static Task SetScrollingMode(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxChart_SetOption", dxTarget, "scrollingMode", value);
        }
        public static Task<string> GetSeriesSelectionMode(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxChart_GetOption", dxTarget, "seriesSelectionMode");
        }
        public static Task SetSeriesSelectionMode(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxChart_SetOption", dxTarget, "seriesSelectionMode", value);
        }
        public static Task<object> GetSeriesTemplate(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxChart_GetOption", dxTarget, "seriesTemplate");
        }
        public static Task SetSeriesTemplate(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxChart_SetOption", dxTarget, "seriesTemplate", value);
        }
        public static Task<bool?> GetSynchronizeMultiAxes(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxChart_GetOption", dxTarget, "synchronizeMultiAxes");
        }
        public static Task SetSynchronizeMultiAxes(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxChart_SetOption", dxTarget, "synchronizeMultiAxes", value);
        }
        public static Task<bool?> GetUseAggregation(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxChart_GetOption", dxTarget, "useAggregation");
        }
        public static Task SetUseAggregation(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxChart_SetOption", dxTarget, "useAggregation", value);
        }
        public static Task<object> GetValueAxis(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxChart_GetOption", dxTarget, "valueAxis");
        }
        public static Task SetValueAxis(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxChart_SetOption", dxTarget, "valueAxis", value);
        }
        public static Task<string> GetZoomingMode(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxChart_GetOption", dxTarget, "zoomingMode");
        }
        public static Task SetZoomingMode(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxChart_SetOption", dxTarget, "zoomingMode", value);
        }
        public static Task ZoomArgument(ElementReference dxTarget, object startValue, object endValue)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxChart_zoomArgument_0", dxTarget, startValue, endValue);
        }
    }
    public class DxPieChartInterop: BaseChartInterop
    {
        public static event EventHandler<JQueryEventArgs> LegendClick;
        public static Task Init(ElementReference dxTarget, DevExpress.Viz.Charts.DxPieChartOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPieChart_Init", dxTarget, json);
        }
        [JSInvokable("DevExpress.Viz.DxPieChartInterop.OnLegendClick")]
        public static void OnLegendClick(string identifier)
        {
            LegendClick?.Invoke(null, new JQueryEventArgs(identifier));
        }
        public static Task<object> GetCommonSeriesSettings(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPieChart_GetOption", dxTarget, "commonSeriesSettings");
        }
        public static Task SetCommonSeriesSettings(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPieChart_SetOption", dxTarget, "commonSeriesSettings", value);
        }
        public static Task<float?> GetDiameter(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_DxPieChart_GetOption", dxTarget, "diameter");
        }
        public static Task SetDiameter(ElementReference dxTarget, float? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPieChart_SetOption", dxTarget, "diameter", value);
        }
        public static Task<float?> GetInnerRadius(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_DxPieChart_GetOption", dxTarget, "innerRadius");
        }
        public static Task SetInnerRadius(ElementReference dxTarget, float? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPieChart_SetOption", dxTarget, "innerRadius", value);
        }
        public static Task<float?> GetMinDiameter(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_DxPieChart_GetOption", dxTarget, "minDiameter");
        }
        public static Task SetMinDiameter(ElementReference dxTarget, float? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPieChart_SetOption", dxTarget, "minDiameter", value);
        }
        public static Task<string> GetResolveLabelOverlapping(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxPieChart_GetOption", dxTarget, "resolveLabelOverlapping");
        }
        public static Task SetResolveLabelOverlapping(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPieChart_SetOption", dxTarget, "resolveLabelOverlapping", value);
        }
        public static Task<string> GetSegmentsDirection(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxPieChart_GetOption", dxTarget, "segmentsDirection");
        }
        public static Task SetSegmentsDirection(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPieChart_SetOption", dxTarget, "segmentsDirection", value);
        }
        public static Task<object> GetSeriesTemplate(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPieChart_GetOption", dxTarget, "seriesTemplate");
        }
        public static Task SetSeriesTemplate(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPieChart_SetOption", dxTarget, "seriesTemplate", value);
        }
        public static Task<string> GetSizeGroup(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxPieChart_GetOption", dxTarget, "sizeGroup");
        }
        public static Task SetSizeGroup(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPieChart_SetOption", dxTarget, "sizeGroup", value);
        }
        public static Task<float?> GetStartAngle(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_DxPieChart_GetOption", dxTarget, "startAngle");
        }
        public static Task SetStartAngle(ElementReference dxTarget, float? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPieChart_SetOption", dxTarget, "startAngle", value);
        }
        public static Task<string> GetType(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxPieChart_GetOption", dxTarget, "type");
        }
        public static Task SetType(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPieChart_SetOption", dxTarget, "type", value);
        }
        public static Task<object> GetSeriesEx(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPieChart_getSeries_0", dxTarget);
        }
        public static Task<object> GetSeriesByName(ElementReference dxTarget, object seriesName)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPieChart_getSeriesByName_1", dxTarget, seriesName);
        }
        public static Task<object> GetSeriesByPos(ElementReference dxTarget, float seriesIndex)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPieChart_getSeriesByPos_2", dxTarget, seriesIndex);
        }
    }
    public class DxPolarChartInterop: BaseChartInterop
    {
        public static event EventHandler<JQueryEventArgs> ArgumentAxisClick;
        public static event EventHandler<JQueryEventArgs> LegendClick;
        public static event EventHandler<JQueryEventArgs> SeriesClick;
        public static event EventHandler<JQueryEventArgs> SeriesHoverChanged;
        public static event EventHandler<JQueryEventArgs> SeriesSelectionChanged;
        public static Task Init(ElementReference dxTarget, DevExpress.Viz.Charts.DxPolarChartOptions options)
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
        public static Task<object> GetArgumentAxis(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPolarChart_GetOption", dxTarget, "argumentAxis");
        }
        public static Task SetArgumentAxis(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPolarChart_SetOption", dxTarget, "argumentAxis", value);
        }
        public static Task<float?> GetBarGroupPadding(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_DxPolarChart_GetOption", dxTarget, "barGroupPadding");
        }
        public static Task SetBarGroupPadding(ElementReference dxTarget, float? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPolarChart_SetOption", dxTarget, "barGroupPadding", value);
        }
        public static Task<float?> GetBarGroupWidth(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_DxPolarChart_GetOption", dxTarget, "barGroupWidth");
        }
        public static Task SetBarGroupWidth(ElementReference dxTarget, float? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPolarChart_SetOption", dxTarget, "barGroupWidth", value);
        }
        public static Task<float?> GetBarWidth(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_DxPolarChart_GetOption", dxTarget, "barWidth");
        }
        public static Task SetBarWidth(ElementReference dxTarget, float? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPolarChart_SetOption", dxTarget, "barWidth", value);
        }
        public static Task<object> GetCommonAxisSettings(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPolarChart_GetOption", dxTarget, "commonAxisSettings");
        }
        public static Task SetCommonAxisSettings(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPolarChart_SetOption", dxTarget, "commonAxisSettings", value);
        }
        public static Task<object> GetCommonSeriesSettings(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPolarChart_GetOption", dxTarget, "commonSeriesSettings");
        }
        public static Task SetCommonSeriesSettings(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPolarChart_SetOption", dxTarget, "commonSeriesSettings", value);
        }
        public static Task<string> GetContainerBackgroundColor(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxPolarChart_GetOption", dxTarget, "containerBackgroundColor");
        }
        public static Task SetContainerBackgroundColor(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPolarChart_SetOption", dxTarget, "containerBackgroundColor", value);
        }
        public static Task<object> GetDataPrepareSettings(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPolarChart_GetOption", dxTarget, "dataPrepareSettings");
        }
        public static Task SetDataPrepareSettings(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPolarChart_SetOption", dxTarget, "dataPrepareSettings", value);
        }
        public static Task<bool?> GetEqualBarWidth(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxPolarChart_GetOption", dxTarget, "equalBarWidth");
        }
        public static Task SetEqualBarWidth(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPolarChart_SetOption", dxTarget, "equalBarWidth", value);
        }
        public static Task<bool?> GetNegativesAsZeroes(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxPolarChart_GetOption", dxTarget, "negativesAsZeroes");
        }
        public static Task SetNegativesAsZeroes(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPolarChart_SetOption", dxTarget, "negativesAsZeroes", value);
        }
        public static Task<string> GetResolveLabelOverlapping(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxPolarChart_GetOption", dxTarget, "resolveLabelOverlapping");
        }
        public static Task SetResolveLabelOverlapping(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPolarChart_SetOption", dxTarget, "resolveLabelOverlapping", value);
        }
        public static Task<string> GetSeriesSelectionMode(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxPolarChart_GetOption", dxTarget, "seriesSelectionMode");
        }
        public static Task SetSeriesSelectionMode(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPolarChart_SetOption", dxTarget, "seriesSelectionMode", value);
        }
        public static Task<object> GetSeriesTemplate(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPolarChart_GetOption", dxTarget, "seriesTemplate");
        }
        public static Task SetSeriesTemplate(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPolarChart_SetOption", dxTarget, "seriesTemplate", value);
        }
        public static Task<bool?> GetUseSpiderWeb(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxPolarChart_GetOption", dxTarget, "useSpiderWeb");
        }
        public static Task SetUseSpiderWeb(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPolarChart_SetOption", dxTarget, "useSpiderWeb", value);
        }
        public static Task<object> GetValueAxis(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPolarChart_GetOption", dxTarget, "valueAxis");
        }
        public static Task SetValueAxis(ElementReference dxTarget, object value)
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
        public static Task Init(ElementReference dxTarget, DevExpress.Viz.Charts.BaseChartOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BaseChart_Init", dxTarget, json);
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
        public static Task<object> GetAdaptiveLayout(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BaseChart_GetOption", dxTarget, "adaptiveLayout");
        }
        public static Task SetAdaptiveLayout(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BaseChart_SetOption", dxTarget, "adaptiveLayout", value);
        }
        public static Task<object> GetAnimation(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BaseChart_GetOption", dxTarget, "animation");
        }
        public static Task SetAnimation(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BaseChart_SetOption", dxTarget, "animation", value);
        }
        public static Task<object> GetCustomizeLabel(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BaseChart_GetOption", dxTarget, "customizeLabel");
        }
        public static Task SetCustomizeLabel(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BaseChart_SetOption", dxTarget, "customizeLabel", value);
        }
        public static Task<object> GetCustomizePoint(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BaseChart_GetOption", dxTarget, "customizePoint");
        }
        public static Task SetCustomizePoint(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BaseChart_SetOption", dxTarget, "customizePoint", value);
        }
        public static Task<object> GetDataSource(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BaseChart_GetOption", dxTarget, "dataSource");
        }
        public static Task SetDataSource(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BaseChart_SetOption", dxTarget, "dataSource", value);
        }
        public static Task<object> GetLegend(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BaseChart_GetOption", dxTarget, "legend");
        }
        public static Task SetLegend(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BaseChart_SetOption", dxTarget, "legend", value);
        }
        public static Task<object> GetPalette(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BaseChart_GetOption", dxTarget, "palette");
        }
        public static Task SetPalette(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BaseChart_SetOption", dxTarget, "palette", value);
        }
        public static Task<string> GetPaletteExtensionMode(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_BaseChart_GetOption", dxTarget, "paletteExtensionMode");
        }
        public static Task SetPaletteExtensionMode(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BaseChart_SetOption", dxTarget, "paletteExtensionMode", value);
        }
        public static Task<string> GetPointSelectionMode(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_BaseChart_GetOption", dxTarget, "pointSelectionMode");
        }
        public static Task SetPointSelectionMode(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BaseChart_SetOption", dxTarget, "pointSelectionMode", value);
        }
        public static Task<object> GetSeries(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BaseChart_GetOption", dxTarget, "series");
        }
        public static Task SetSeries(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BaseChart_SetOption", dxTarget, "series", value);
        }
        public static Task ClearSelection(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BaseChart_clearSelection_0", dxTarget);
        }
        public static Task<object> GetAllSeries(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BaseChart_getAllSeries_1", dxTarget);
        }
        public static Task<object> GetDataSourceEx(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BaseChart_getDataSource_2", dxTarget);
        }
        public static Task<object> GetSeriesByName(ElementReference dxTarget, object seriesName)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BaseChart_getSeriesByName_3", dxTarget, seriesName);
        }
        public static Task<object> GetSeriesByPos(ElementReference dxTarget, float seriesIndex)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BaseChart_getSeriesByPos_4", dxTarget, seriesIndex);
        }
        public static Task HideTooltip(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BaseChart_hideTooltip_5", dxTarget);
        }
        public static Task Render(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BaseChart_render_6", dxTarget);
        }
        public static Task Render(ElementReference dxTarget, object renderOptions)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BaseChart_render_7", dxTarget, renderOptions);
        }
    }
    public class DxExporterInterop: ComponentInterop
    {
        public static Task Init(ElementReference dxTarget, DevExpress.Viz.DxExporterOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxExporter_Init", dxTarget, json);
        }
        public static Task<object> GetExportFormat(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxExporter_GetOption", dxTarget, "exportFormat");
        }
        public static Task SetExportFormat(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxExporter_SetOption", dxTarget, "exportFormat", value);
        }
        public static Task<string> GetFileName(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxExporter_GetOption", dxTarget, "fileName");
        }
        public static Task SetFileName(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxExporter_SetOption", dxTarget, "fileName", value);
        }
        public static Task<bool?> GetPrintingEnabled(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxExporter_GetOption", dxTarget, "printingEnabled");
        }
        public static Task SetPrintingEnabled(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxExporter_SetOption", dxTarget, "printingEnabled", value);
        }
        public static Task<string> GetServerUrl(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxExporter_GetOption", dxTarget, "serverUrl");
        }
        public static Task SetServerUrl(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxExporter_SetOption", dxTarget, "serverUrl", value);
        }
        public static Task<bool?> GetShowMenu(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxExporter_GetOption", dxTarget, "showMenu");
        }
        public static Task SetShowMenu(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxExporter_SetOption", dxTarget, "showMenu", value);
        }
        public static Task<string> GetSourceContainer(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxExporter_GetOption", dxTarget, "sourceContainer");
        }
        public static Task SetSourceContainer(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxExporter_SetOption", dxTarget, "sourceContainer", value);
        }
        public static Task ExportTo(ElementReference dxTarget, string fileName, string format)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxExporter_exportTo_0", dxTarget, fileName, format);
        }
        public static Task Print(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxExporter_print_1", dxTarget);
        }
    }
    public class DxFunnelInterop: BaseWidgetInterop
    {
        public static event EventHandler<JQueryEventArgs> HoverChanged;
        public static event EventHandler<JQueryEventArgs> ItemClick;
        public static event EventHandler<JQueryEventArgs> LegendClick;
        public static event EventHandler<JQueryEventArgs> SelectionChanged;
        public static Task Init(ElementReference dxTarget, DevExpress.Viz.Funnel.DxFunnelOptions options)
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
        public static Task<object> GetAdaptiveLayout(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxFunnel_GetOption", dxTarget, "adaptiveLayout");
        }
        public static Task SetAdaptiveLayout(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxFunnel_SetOption", dxTarget, "adaptiveLayout", value);
        }
        public static Task<string> GetAlgorithm(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxFunnel_GetOption", dxTarget, "algorithm");
        }
        public static Task SetAlgorithm(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxFunnel_SetOption", dxTarget, "algorithm", value);
        }
        public static Task<string> GetArgumentField(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxFunnel_GetOption", dxTarget, "argumentField");
        }
        public static Task SetArgumentField(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxFunnel_SetOption", dxTarget, "argumentField", value);
        }
        public static Task<string> GetColorField(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxFunnel_GetOption", dxTarget, "colorField");
        }
        public static Task SetColorField(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxFunnel_SetOption", dxTarget, "colorField", value);
        }
        public static Task<object> GetDataSource(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxFunnel_GetOption", dxTarget, "dataSource");
        }
        public static Task SetDataSource(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxFunnel_SetOption", dxTarget, "dataSource", value);
        }
        public static Task<bool?> GetHoverEnabled(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxFunnel_GetOption", dxTarget, "hoverEnabled");
        }
        public static Task SetHoverEnabled(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxFunnel_SetOption", dxTarget, "hoverEnabled", value);
        }
        public static Task<bool?> GetInverted(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxFunnel_GetOption", dxTarget, "inverted");
        }
        public static Task SetInverted(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxFunnel_SetOption", dxTarget, "inverted", value);
        }
        public static Task<object> GetItem(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxFunnel_GetOption", dxTarget, "item");
        }
        public static Task SetItem(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxFunnel_SetOption", dxTarget, "item", value);
        }
        public static Task<object> GetLabel(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxFunnel_GetOption", dxTarget, "label");
        }
        public static Task SetLabel(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxFunnel_SetOption", dxTarget, "label", value);
        }
        public static Task<object> GetLegend(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxFunnel_GetOption", dxTarget, "legend");
        }
        public static Task SetLegend(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxFunnel_SetOption", dxTarget, "legend", value);
        }
        public static Task<float?> GetNeckHeight(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_DxFunnel_GetOption", dxTarget, "neckHeight");
        }
        public static Task SetNeckHeight(ElementReference dxTarget, float? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxFunnel_SetOption", dxTarget, "neckHeight", value);
        }
        public static Task<float?> GetNeckWidth(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_DxFunnel_GetOption", dxTarget, "neckWidth");
        }
        public static Task SetNeckWidth(ElementReference dxTarget, float? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxFunnel_SetOption", dxTarget, "neckWidth", value);
        }
        public static Task<object> GetPalette(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxFunnel_GetOption", dxTarget, "palette");
        }
        public static Task SetPalette(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxFunnel_SetOption", dxTarget, "palette", value);
        }
        public static Task<string> GetPaletteExtensionMode(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxFunnel_GetOption", dxTarget, "paletteExtensionMode");
        }
        public static Task SetPaletteExtensionMode(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxFunnel_SetOption", dxTarget, "paletteExtensionMode", value);
        }
        public static Task<string> GetSelectionMode(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxFunnel_GetOption", dxTarget, "selectionMode");
        }
        public static Task SetSelectionMode(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxFunnel_SetOption", dxTarget, "selectionMode", value);
        }
        public static Task<bool?> GetSortData(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxFunnel_GetOption", dxTarget, "sortData");
        }
        public static Task SetSortData(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxFunnel_SetOption", dxTarget, "sortData", value);
        }
        public static Task<string> GetValueField(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxFunnel_GetOption", dxTarget, "valueField");
        }
        public static Task SetValueField(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxFunnel_SetOption", dxTarget, "valueField", value);
        }
        public static Task ClearSelection(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxFunnel_clearSelection_0", dxTarget);
        }
        public static Task<object> GetAllItems(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxFunnel_getAllItems_1", dxTarget);
        }
        public static Task<object> GetDataSourceEx(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxFunnel_getDataSource_2", dxTarget);
        }
        public static Task HideTooltip(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxFunnel_hideTooltip_3", dxTarget);
        }
    }
    public class BaseGaugeInterop: BaseWidgetInterop
    {
        public static event EventHandler<JQueryEventArgs> TooltipHidden;
        public static event EventHandler<JQueryEventArgs> TooltipShown;
        public static Task Init(ElementReference dxTarget, DevExpress.Viz.Gauges.BaseGaugeOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BaseGauge_Init", dxTarget, json);
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
        public static Task<object> GetAnimation(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BaseGauge_GetOption", dxTarget, "animation");
        }
        public static Task SetAnimation(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BaseGauge_SetOption", dxTarget, "animation", value);
        }
        public static Task<string> GetContainerBackgroundColor(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_BaseGauge_GetOption", dxTarget, "containerBackgroundColor");
        }
        public static Task SetContainerBackgroundColor(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BaseGauge_SetOption", dxTarget, "containerBackgroundColor", value);
        }
        public static Task<object> GetRangeContainer(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BaseGauge_GetOption", dxTarget, "rangeContainer");
        }
        public static Task SetRangeContainer(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BaseGauge_SetOption", dxTarget, "rangeContainer", value);
        }
        public static Task<object> GetScale(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BaseGauge_GetOption", dxTarget, "scale");
        }
        public static Task SetScale(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BaseGauge_SetOption", dxTarget, "scale", value);
        }
        public static Task<object> GetSubtitle(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BaseGauge_GetOption", dxTarget, "subtitle");
        }
        public static Task SetSubtitle(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BaseGauge_SetOption", dxTarget, "subtitle", value);
        }
        public static Task<object> GetSubvalues(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BaseGauge_GetOption", dxTarget, "subvalues");
        }
        public static Task SetSubvalues(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BaseGauge_SetOption", dxTarget, "subvalues", value);
        }
        public static Task<float?> GetValue(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_BaseGauge_GetOption", dxTarget, "value");
        }
        public static Task SetValue(ElementReference dxTarget, float? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BaseGauge_SetOption", dxTarget, "value", value);
        }
        public static Task<object> SubvaluesEx(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BaseGauge_subvalues_0", dxTarget);
        }
        public static Task SubvaluesEx(ElementReference dxTarget, object subvalues)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BaseGauge_subvalues_1", dxTarget, subvalues);
        }
        public static Task<float> ValueEx(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<float>("BlazorDevExtreme_BaseGauge_value_2", dxTarget);
        }
        public static Task ValueEx(ElementReference dxTarget, float value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BaseGauge_value_3", dxTarget, value);
        }
    }
    public class DxCircularGaugeInterop: BaseGaugeInterop
    {
        public static Task Init(ElementReference dxTarget, DevExpress.Viz.Gauges.DxCircularGaugeOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxCircularGauge_Init", dxTarget, json);
        }
        public static Task<object> GetGeometry(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxCircularGauge_GetOption", dxTarget, "geometry");
        }
        public static Task SetGeometry(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxCircularGauge_SetOption", dxTarget, "geometry", value);
        }
        public static Task<object> GetSubvalueIndicator(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxCircularGauge_GetOption", dxTarget, "subvalueIndicator");
        }
        public static Task SetSubvalueIndicator(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxCircularGauge_SetOption", dxTarget, "subvalueIndicator", value);
        }
        public static Task<object> GetValueIndicator(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxCircularGauge_GetOption", dxTarget, "valueIndicator");
        }
        public static Task SetValueIndicator(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxCircularGauge_SetOption", dxTarget, "valueIndicator", value);
        }
    }
    public class DxLinearGaugeInterop: BaseGaugeInterop
    {
        public static Task Init(ElementReference dxTarget, DevExpress.Viz.Gauges.DxLinearGaugeOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxLinearGauge_Init", dxTarget, json);
        }
        public static Task<object> GetGeometry(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxLinearGauge_GetOption", dxTarget, "geometry");
        }
        public static Task SetGeometry(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxLinearGauge_SetOption", dxTarget, "geometry", value);
        }
        public static Task<object> GetSubvalueIndicator(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxLinearGauge_GetOption", dxTarget, "subvalueIndicator");
        }
        public static Task SetSubvalueIndicator(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxLinearGauge_SetOption", dxTarget, "subvalueIndicator", value);
        }
        public static Task<object> GetValueIndicator(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxLinearGauge_GetOption", dxTarget, "valueIndicator");
        }
        public static Task SetValueIndicator(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxLinearGauge_SetOption", dxTarget, "valueIndicator", value);
        }
    }
    public class DxBarGaugeInterop: BaseWidgetInterop
    {
        public static event EventHandler<JQueryEventArgs> TooltipHidden;
        public static event EventHandler<JQueryEventArgs> TooltipShown;
        public static Task Init(ElementReference dxTarget, DevExpress.Viz.Gauges.DxBarGaugeOptions options)
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
        public static Task<object> GetAnimation(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxBarGauge_GetOption", dxTarget, "animation");
        }
        public static Task SetAnimation(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxBarGauge_SetOption", dxTarget, "animation", value);
        }
        public static Task<string> GetBackgroundColor(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxBarGauge_GetOption", dxTarget, "backgroundColor");
        }
        public static Task SetBackgroundColor(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxBarGauge_SetOption", dxTarget, "backgroundColor", value);
        }
        public static Task<float?> GetBarSpacing(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_DxBarGauge_GetOption", dxTarget, "barSpacing");
        }
        public static Task SetBarSpacing(ElementReference dxTarget, float? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxBarGauge_SetOption", dxTarget, "barSpacing", value);
        }
        public static Task<float?> GetBaseValue(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_DxBarGauge_GetOption", dxTarget, "baseValue");
        }
        public static Task SetBaseValue(ElementReference dxTarget, float? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxBarGauge_SetOption", dxTarget, "baseValue", value);
        }
        public static Task<float?> GetEndValue(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_DxBarGauge_GetOption", dxTarget, "endValue");
        }
        public static Task SetEndValue(ElementReference dxTarget, float? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxBarGauge_SetOption", dxTarget, "endValue", value);
        }
        public static Task<object> GetGeometry(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxBarGauge_GetOption", dxTarget, "geometry");
        }
        public static Task SetGeometry(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxBarGauge_SetOption", dxTarget, "geometry", value);
        }
        public static Task<object> GetLabel(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxBarGauge_GetOption", dxTarget, "label");
        }
        public static Task SetLabel(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxBarGauge_SetOption", dxTarget, "label", value);
        }
        public static Task<object> GetPalette(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxBarGauge_GetOption", dxTarget, "palette");
        }
        public static Task SetPalette(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxBarGauge_SetOption", dxTarget, "palette", value);
        }
        public static Task<string> GetPaletteExtensionMode(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxBarGauge_GetOption", dxTarget, "paletteExtensionMode");
        }
        public static Task SetPaletteExtensionMode(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxBarGauge_SetOption", dxTarget, "paletteExtensionMode", value);
        }
        public static Task<float?> GetRelativeInnerRadius(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_DxBarGauge_GetOption", dxTarget, "relativeInnerRadius");
        }
        public static Task SetRelativeInnerRadius(ElementReference dxTarget, float? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxBarGauge_SetOption", dxTarget, "relativeInnerRadius", value);
        }
        public static Task<float?> GetStartValue(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_DxBarGauge_GetOption", dxTarget, "startValue");
        }
        public static Task SetStartValue(ElementReference dxTarget, float? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxBarGauge_SetOption", dxTarget, "startValue", value);
        }
        public static Task<object> GetSubtitle(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxBarGauge_GetOption", dxTarget, "subtitle");
        }
        public static Task SetSubtitle(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxBarGauge_SetOption", dxTarget, "subtitle", value);
        }
        public static Task<object> GetValues(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxBarGauge_GetOption", dxTarget, "values");
        }
        public static Task SetValues(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxBarGauge_SetOption", dxTarget, "values", value);
        }
        public static Task<object> ValuesEx(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxBarGauge_values_0", dxTarget);
        }
        public static Task ValuesEx(ElementReference dxTarget, object values)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxBarGauge_values_1", dxTarget, values);
        }
    }
    public class BaseSeriesObjectInterop
    {
        public static Task ClearHover(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BaseSeriesObject_clearHover_0", dxTarget);
        }
        public static Task ClearSelection(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BaseSeriesObject_clearSelection_1", dxTarget);
        }
        public static Task DeselectPoint(ElementReference dxTarget, object point)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BaseSeriesObject_deselectPoint_2", dxTarget, point);
        }
        public static Task<object> GetAllPoints(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BaseSeriesObject_getAllPoints_3", dxTarget);
        }
        public static Task<string> GetColor(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_BaseSeriesObject_getColor_4", dxTarget);
        }
        public static Task<object> GetPointByPos(ElementReference dxTarget, float positionIndex)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BaseSeriesObject_getPointByPos_5", dxTarget, positionIndex);
        }
        public static Task<object> GetPointsByArg(ElementReference dxTarget, object pointArg)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BaseSeriesObject_getPointsByArg_6", dxTarget, pointArg);
        }
        public static Task<object> GetVisiblePoints(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BaseSeriesObject_getVisiblePoints_7", dxTarget);
        }
        public static Task Hide(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BaseSeriesObject_hide_8", dxTarget);
        }
        public static Task Hover(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BaseSeriesObject_hover_9", dxTarget);
        }
        public static Task<bool> IsHovered(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool>("BlazorDevExtreme_BaseSeriesObject_isHovered_10", dxTarget);
        }
        public static Task<bool> IsSelected(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool>("BlazorDevExtreme_BaseSeriesObject_isSelected_11", dxTarget);
        }
        public static Task<bool> IsVisible(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool>("BlazorDevExtreme_BaseSeriesObject_isVisible_12", dxTarget);
        }
        public static Task Select(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BaseSeriesObject_select_13", dxTarget);
        }
        public static Task SelectPoint(ElementReference dxTarget, object point)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BaseSeriesObject_selectPoint_14", dxTarget, point);
        }
        public static Task Show(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BaseSeriesObject_show_15", dxTarget);
        }
    }
    public class BasePointObjectInterop
    {
        public static Task ClearHover(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BasePointObject_clearHover_0", dxTarget);
        }
        public static Task ClearSelection(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BasePointObject_clearSelection_1", dxTarget);
        }
        public static Task<string> GetColor(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_BasePointObject_getColor_2", dxTarget);
        }
        public static Task<object> GetLabel(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BasePointObject_getLabel_3", dxTarget);
        }
        public static Task HideTooltip(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BasePointObject_hideTooltip_4", dxTarget);
        }
        public static Task Hover(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BasePointObject_hover_5", dxTarget);
        }
        public static Task<bool> IsHovered(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool>("BlazorDevExtreme_BasePointObject_isHovered_6", dxTarget);
        }
        public static Task<bool> IsSelected(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool>("BlazorDevExtreme_BasePointObject_isSelected_7", dxTarget);
        }
        public static Task Select(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BasePointObject_select_8", dxTarget);
        }
        public static Task ShowTooltip(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BasePointObject_showTooltip_9", dxTarget);
        }
    }
    public class BaseLabelObjectInterop
    {
        public static Task<object> GetBoundingRect(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BaseLabelObject_getBoundingRect_0", dxTarget);
        }
        public static Task Hide(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BaseLabelObject_hide_1", dxTarget);
        }
        public static Task Hide(ElementReference dxTarget, bool holdInvisible)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BaseLabelObject_hide_2", dxTarget, holdInvisible);
        }
        public static Task<bool> IsVisible(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool>("BlazorDevExtreme_BaseLabelObject_isVisible_3", dxTarget);
        }
        public static Task Show(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BaseLabelObject_show_4", dxTarget);
        }
        public static Task Show(ElementReference dxTarget, bool holdVisible)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BaseLabelObject_show_5", dxTarget, holdVisible);
        }
    }
    public class ChartSeriesObjectInterop: BaseSeriesObjectInterop
    {
    }
    public class ChartPointObjectInterop: BasePointObjectInterop
    {
        public static Task<object> GetBoundingRect(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_ChartPointObject_getBoundingRect_0", dxTarget);
        }
    }
    public class DxFunnelItemInterop
    {
        public static Task<string> GetColor(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxFunnelItem_getColor_0", dxTarget);
        }
        public static Task Hover(ElementReference dxTarget, bool state)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxFunnelItem_hover_1", dxTarget, state);
        }
        public static Task<bool> IsHovered(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool>("BlazorDevExtreme_DxFunnelItem_isHovered_2", dxTarget);
        }
        public static Task<bool> IsSelected(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool>("BlazorDevExtreme_DxFunnelItem_isSelected_3", dxTarget);
        }
        public static Task Select(ElementReference dxTarget, bool state)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxFunnelItem_select_4", dxTarget, state);
        }
        public static Task ShowTooltip(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxFunnelItem_showTooltip_5", dxTarget);
        }
    }
    public class PiePointObjectInterop: BasePointObjectInterop
    {
        public static Task Hide(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_PiePointObject_hide_0", dxTarget);
        }
        public static Task HideTooltip(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_PiePointObject_hideTooltip_1", dxTarget);
        }
        public static Task<bool> IsVisible(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool>("BlazorDevExtreme_PiePointObject_isVisible_2", dxTarget);
        }
        public static Task Show(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_PiePointObject_show_3", dxTarget);
        }
        public static Task ShowTooltip(ElementReference dxTarget)
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
    public class DxTreeMapNodeInterop
    {
        public static Task Customize(ElementReference dxTarget, object options)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeMapNode_customize_0", dxTarget, options);
        }
        public static Task DrillDown(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeMapNode_drillDown_1", dxTarget);
        }
        public static Task<object> GetAllChildren(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeMapNode_getAllChildren_2", dxTarget);
        }
        public static Task<object> GetAllNodes(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeMapNode_getAllNodes_3", dxTarget);
        }
        public static Task<object> GetChild(ElementReference dxTarget, float index)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeMapNode_getChild_4", dxTarget, index);
        }
        public static Task<float> GetChildrenCount(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<float>("BlazorDevExtreme_DxTreeMapNode_getChildrenCount_5", dxTarget);
        }
        public static Task<object> GetParent(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeMapNode_getParent_6", dxTarget);
        }
        public static Task<bool> IsActive(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool>("BlazorDevExtreme_DxTreeMapNode_isActive_7", dxTarget);
        }
        public static Task<bool> IsHovered(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool>("BlazorDevExtreme_DxTreeMapNode_isHovered_8", dxTarget);
        }
        public static Task<bool> IsLeaf(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool>("BlazorDevExtreme_DxTreeMapNode_isLeaf_9", dxTarget);
        }
        public static Task<bool> IsSelected(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool>("BlazorDevExtreme_DxTreeMapNode_isSelected_10", dxTarget);
        }
        public static Task<string> Label(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxTreeMapNode_label_11", dxTarget);
        }
        public static Task Label(ElementReference dxTarget, string label)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeMapNode_label_12", dxTarget, label);
        }
        public static Task ResetCustomization(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeMapNode_resetCustomization_13", dxTarget);
        }
        public static Task Select(ElementReference dxTarget, bool state)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeMapNode_select_14", dxTarget, state);
        }
        public static Task ShowTooltip(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeMapNode_showTooltip_15", dxTarget);
        }
        public static Task<float> ValueEx(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<float>("BlazorDevExtreme_DxTreeMapNode_value_16", dxTarget);
        }
    }
    public class MapLayerInterop
    {
        public static Task ClearSelection(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_MapLayer_clearSelection_0", dxTarget);
        }
        public static Task<object> GetDataSourceEx(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_MapLayer_getDataSource_1", dxTarget);
        }
        public static Task<object> GetElements(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_MapLayer_getElements_2", dxTarget);
        }
    }
    public class MapLayerElementInterop
    {
        public static Task ApplySettings(ElementReference dxTarget, object settings)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_MapLayerElement_applySettings_0", dxTarget, settings);
        }
        public static Task<object> Attribute(ElementReference dxTarget, string name)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_MapLayerElement_attribute_1", dxTarget, name);
        }
        public static Task Attribute(ElementReference dxTarget, string name, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_MapLayerElement_attribute_2", dxTarget, name, value);
        }
        public static Task<object> Coordinates(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_MapLayerElement_coordinates_3", dxTarget);
        }
        public static Task<bool> Selected(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool>("BlazorDevExtreme_MapLayerElement_selected_4", dxTarget);
        }
        public static Task Selected(ElementReference dxTarget, bool state)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_MapLayerElement_selected_5", dxTarget, state);
        }
    }
    public class AreaObjectsInterop
    {
        public static Task ApplySettings(ElementReference dxTarget, object settings)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_AreaObjects_applySettings_0", dxTarget, settings);
        }
        public static Task<object> Attribute(ElementReference dxTarget, string name)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_AreaObjects_attribute_1", dxTarget, name);
        }
        public static Task<bool> Selected(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool>("BlazorDevExtreme_AreaObjects_selected_2", dxTarget);
        }
        public static Task Selected(ElementReference dxTarget, bool state)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_AreaObjects_selected_3", dxTarget, state);
        }
    }
    public class MarkerObjectsInterop
    {
        public static Task ApplySettings(ElementReference dxTarget, object settings)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_MarkerObjects_applySettings_0", dxTarget, settings);
        }
        public static Task<object> Attribute(ElementReference dxTarget, string name)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_MarkerObjects_attribute_1", dxTarget, name);
        }
        public static Task<object> Coordinates(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_MarkerObjects_coordinates_2", dxTarget);
        }
        public static Task<bool> Selected(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool>("BlazorDevExtreme_MarkerObjects_selected_3", dxTarget);
        }
        public static Task Selected(ElementReference dxTarget, bool state)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_MarkerObjects_selected_4", dxTarget, state);
        }
    }
    public class DxRangeSelectorInterop: BaseWidgetInterop
    {
        public static event EventHandler<JQueryEventArgs> SelectedRangeChanged;
        public static event EventHandler<JQueryEventArgs> ValueChanged;
        public static Task Init(ElementReference dxTarget, DevExpress.Viz.RangeSelector.DxRangeSelectorOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxRangeSelector_Init", dxTarget, json);
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
        public static Task<object> GetBackground(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxRangeSelector_GetOption", dxTarget, "background");
        }
        public static Task SetBackground(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxRangeSelector_SetOption", dxTarget, "background", value);
        }
        public static Task<object> GetBehavior(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxRangeSelector_GetOption", dxTarget, "behavior");
        }
        public static Task SetBehavior(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxRangeSelector_SetOption", dxTarget, "behavior", value);
        }
        public static Task<object> GetChart(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxRangeSelector_GetOption", dxTarget, "chart");
        }
        public static Task SetChart(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxRangeSelector_SetOption", dxTarget, "chart", value);
        }
        public static Task<string> GetContainerBackgroundColor(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxRangeSelector_GetOption", dxTarget, "containerBackgroundColor");
        }
        public static Task SetContainerBackgroundColor(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxRangeSelector_SetOption", dxTarget, "containerBackgroundColor", value);
        }
        public static Task<object> GetDataSource(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxRangeSelector_GetOption", dxTarget, "dataSource");
        }
        public static Task SetDataSource(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxRangeSelector_SetOption", dxTarget, "dataSource", value);
        }
        public static Task<string> GetDataSourceField(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxRangeSelector_GetOption", dxTarget, "dataSourceField");
        }
        public static Task SetDataSourceField(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxRangeSelector_SetOption", dxTarget, "dataSourceField", value);
        }
        public static Task<object> GetIndent(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxRangeSelector_GetOption", dxTarget, "indent");
        }
        public static Task SetIndent(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxRangeSelector_SetOption", dxTarget, "indent", value);
        }
        public static Task<object> GetScale(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxRangeSelector_GetOption", dxTarget, "scale");
        }
        public static Task SetScale(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxRangeSelector_SetOption", dxTarget, "scale", value);
        }
        public static Task<object> GetSelectedRange(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxRangeSelector_GetOption", dxTarget, "selectedRange");
        }
        public static Task SetSelectedRange(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxRangeSelector_SetOption", dxTarget, "selectedRange", value);
        }
        public static Task<string> GetSelectedRangeColor(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxRangeSelector_GetOption", dxTarget, "selectedRangeColor");
        }
        public static Task SetSelectedRangeColor(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxRangeSelector_SetOption", dxTarget, "selectedRangeColor", value);
        }
        public static Task<object> GetShutter(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxRangeSelector_GetOption", dxTarget, "shutter");
        }
        public static Task SetShutter(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxRangeSelector_SetOption", dxTarget, "shutter", value);
        }
        public static Task<object> GetSliderHandle(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxRangeSelector_GetOption", dxTarget, "sliderHandle");
        }
        public static Task SetSliderHandle(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxRangeSelector_SetOption", dxTarget, "sliderHandle", value);
        }
        public static Task<object> GetSliderMarker(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxRangeSelector_GetOption", dxTarget, "sliderMarker");
        }
        public static Task SetSliderMarker(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxRangeSelector_SetOption", dxTarget, "sliderMarker", value);
        }
        public static Task<object> GetValue(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxRangeSelector_GetOption", dxTarget, "value");
        }
        public static Task SetValue(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxRangeSelector_SetOption", dxTarget, "value", value);
        }
        public static Task<object> GetDataSourceEx(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxRangeSelector_getDataSource_0", dxTarget);
        }
        public static Task<object> GetSelectedRangeEx(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxRangeSelector_getSelectedRange_1", dxTarget);
        }
        public static Task<object> GetValueEx(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxRangeSelector_getValue_2", dxTarget);
        }
        public static Task Render(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxRangeSelector_render_3", dxTarget);
        }
        public static Task Render(ElementReference dxTarget, bool skipChartAnimation)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxRangeSelector_render_4", dxTarget, skipChartAnimation);
        }
        public static Task SetSelectedRangeEx(ElementReference dxTarget, object selectedRange)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxRangeSelector_setSelectedRange_5", dxTarget, selectedRange);
        }
        public static Task SetValueEx(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxRangeSelector_setValue_6", dxTarget, value);
        }
    }
    public class BaseSparklineInterop: BaseWidgetInterop
    {
        public static event EventHandler<JQueryEventArgs> TooltipHidden;
        public static event EventHandler<JQueryEventArgs> TooltipShown;
        public static Task Init(ElementReference dxTarget, DevExpress.Viz.Sparklines.BaseSparklineOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BaseSparkline_Init", dxTarget, json);
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
    }
    public class DxSparklineInterop: BaseSparklineInterop
    {
        public static Task Init(ElementReference dxTarget, DevExpress.Viz.Sparklines.DxSparklineOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxSparkline_Init", dxTarget, json);
        }
        public static Task<string> GetArgumentField(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxSparkline_GetOption", dxTarget, "argumentField");
        }
        public static Task SetArgumentField(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxSparkline_SetOption", dxTarget, "argumentField", value);
        }
        public static Task<string> GetBarNegativeColor(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxSparkline_GetOption", dxTarget, "barNegativeColor");
        }
        public static Task SetBarNegativeColor(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxSparkline_SetOption", dxTarget, "barNegativeColor", value);
        }
        public static Task<string> GetBarPositiveColor(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxSparkline_GetOption", dxTarget, "barPositiveColor");
        }
        public static Task SetBarPositiveColor(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxSparkline_SetOption", dxTarget, "barPositiveColor", value);
        }
        public static Task<object> GetDataSource(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxSparkline_GetOption", dxTarget, "dataSource");
        }
        public static Task SetDataSource(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxSparkline_SetOption", dxTarget, "dataSource", value);
        }
        public static Task<string> GetFirstLastColor(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxSparkline_GetOption", dxTarget, "firstLastColor");
        }
        public static Task SetFirstLastColor(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxSparkline_SetOption", dxTarget, "firstLastColor", value);
        }
        public static Task<bool?> GetIgnoreEmptyPoints(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxSparkline_GetOption", dxTarget, "ignoreEmptyPoints");
        }
        public static Task SetIgnoreEmptyPoints(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxSparkline_SetOption", dxTarget, "ignoreEmptyPoints", value);
        }
        public static Task<string> GetLineColor(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxSparkline_GetOption", dxTarget, "lineColor");
        }
        public static Task SetLineColor(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxSparkline_SetOption", dxTarget, "lineColor", value);
        }
        public static Task<float?> GetLineWidth(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_DxSparkline_GetOption", dxTarget, "lineWidth");
        }
        public static Task SetLineWidth(ElementReference dxTarget, float? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxSparkline_SetOption", dxTarget, "lineWidth", value);
        }
        public static Task<string> GetLossColor(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxSparkline_GetOption", dxTarget, "lossColor");
        }
        public static Task SetLossColor(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxSparkline_SetOption", dxTarget, "lossColor", value);
        }
        public static Task<string> GetMaxColor(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxSparkline_GetOption", dxTarget, "maxColor");
        }
        public static Task SetMaxColor(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxSparkline_SetOption", dxTarget, "maxColor", value);
        }
        public static Task<float?> GetMaxValue(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_DxSparkline_GetOption", dxTarget, "maxValue");
        }
        public static Task SetMaxValue(ElementReference dxTarget, float? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxSparkline_SetOption", dxTarget, "maxValue", value);
        }
        public static Task<string> GetMinColor(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxSparkline_GetOption", dxTarget, "minColor");
        }
        public static Task SetMinColor(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxSparkline_SetOption", dxTarget, "minColor", value);
        }
        public static Task<float?> GetMinValue(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_DxSparkline_GetOption", dxTarget, "minValue");
        }
        public static Task SetMinValue(ElementReference dxTarget, float? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxSparkline_SetOption", dxTarget, "minValue", value);
        }
        public static Task<string> GetPointColor(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxSparkline_GetOption", dxTarget, "pointColor");
        }
        public static Task SetPointColor(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxSparkline_SetOption", dxTarget, "pointColor", value);
        }
        public static Task<float?> GetPointSize(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_DxSparkline_GetOption", dxTarget, "pointSize");
        }
        public static Task SetPointSize(ElementReference dxTarget, float? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxSparkline_SetOption", dxTarget, "pointSize", value);
        }
        public static Task<string> GetPointSymbol(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxSparkline_GetOption", dxTarget, "pointSymbol");
        }
        public static Task SetPointSymbol(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxSparkline_SetOption", dxTarget, "pointSymbol", value);
        }
        public static Task<bool?> GetShowFirstLast(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxSparkline_GetOption", dxTarget, "showFirstLast");
        }
        public static Task SetShowFirstLast(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxSparkline_SetOption", dxTarget, "showFirstLast", value);
        }
        public static Task<bool?> GetShowMinMax(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxSparkline_GetOption", dxTarget, "showMinMax");
        }
        public static Task SetShowMinMax(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxSparkline_SetOption", dxTarget, "showMinMax", value);
        }
        public static Task<string> GetType(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxSparkline_GetOption", dxTarget, "type");
        }
        public static Task SetType(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxSparkline_SetOption", dxTarget, "type", value);
        }
        public static Task<string> GetValueField(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxSparkline_GetOption", dxTarget, "valueField");
        }
        public static Task SetValueField(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxSparkline_SetOption", dxTarget, "valueField", value);
        }
        public static Task<string> GetWinColor(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxSparkline_GetOption", dxTarget, "winColor");
        }
        public static Task SetWinColor(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxSparkline_SetOption", dxTarget, "winColor", value);
        }
        public static Task<float?> GetWinlossThreshold(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_DxSparkline_GetOption", dxTarget, "winlossThreshold");
        }
        public static Task SetWinlossThreshold(ElementReference dxTarget, float? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxSparkline_SetOption", dxTarget, "winlossThreshold", value);
        }
        public static Task<object> GetDataSourceEx(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxSparkline_getDataSource_0", dxTarget);
        }
    }
    public class DxBulletInterop: BaseSparklineInterop
    {
        public static Task Init(ElementReference dxTarget, DevExpress.Viz.Sparklines.DxBulletOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxBullet_Init", dxTarget, json);
        }
        public static Task<string> GetColor(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxBullet_GetOption", dxTarget, "color");
        }
        public static Task SetColor(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxBullet_SetOption", dxTarget, "color", value);
        }
        public static Task<float?> GetEndScaleValue(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_DxBullet_GetOption", dxTarget, "endScaleValue");
        }
        public static Task SetEndScaleValue(ElementReference dxTarget, float? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxBullet_SetOption", dxTarget, "endScaleValue", value);
        }
        public static Task<bool?> GetShowTarget(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxBullet_GetOption", dxTarget, "showTarget");
        }
        public static Task SetShowTarget(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxBullet_SetOption", dxTarget, "showTarget", value);
        }
        public static Task<bool?> GetShowZeroLevel(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxBullet_GetOption", dxTarget, "showZeroLevel");
        }
        public static Task SetShowZeroLevel(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxBullet_SetOption", dxTarget, "showZeroLevel", value);
        }
        public static Task<float?> GetStartScaleValue(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_DxBullet_GetOption", dxTarget, "startScaleValue");
        }
        public static Task SetStartScaleValue(ElementReference dxTarget, float? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxBullet_SetOption", dxTarget, "startScaleValue", value);
        }
        public static Task<float?> GetTarget(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_DxBullet_GetOption", dxTarget, "target");
        }
        public static Task SetTarget(ElementReference dxTarget, float? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxBullet_SetOption", dxTarget, "target", value);
        }
        public static Task<string> GetTargetColor(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxBullet_GetOption", dxTarget, "targetColor");
        }
        public static Task SetTargetColor(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxBullet_SetOption", dxTarget, "targetColor", value);
        }
        public static Task<float?> GetTargetWidth(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_DxBullet_GetOption", dxTarget, "targetWidth");
        }
        public static Task SetTargetWidth(ElementReference dxTarget, float? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxBullet_SetOption", dxTarget, "targetWidth", value);
        }
        public static Task<float?> GetValue(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_DxBullet_GetOption", dxTarget, "value");
        }
        public static Task SetValue(ElementReference dxTarget, float? value)
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
        public static Task Init(ElementReference dxTarget, DevExpress.Viz.TreeMap.DxTreeMapOptions options)
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
        public static Task<string> GetChildrenField(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxTreeMap_GetOption", dxTarget, "childrenField");
        }
        public static Task SetChildrenField(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeMap_SetOption", dxTarget, "childrenField", value);
        }
        public static Task<string> GetColorField(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxTreeMap_GetOption", dxTarget, "colorField");
        }
        public static Task SetColorField(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeMap_SetOption", dxTarget, "colorField", value);
        }
        public static Task<object> GetColorizer(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeMap_GetOption", dxTarget, "colorizer");
        }
        public static Task SetColorizer(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeMap_SetOption", dxTarget, "colorizer", value);
        }
        public static Task<object> GetDataSource(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeMap_GetOption", dxTarget, "dataSource");
        }
        public static Task SetDataSource(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeMap_SetOption", dxTarget, "dataSource", value);
        }
        public static Task<object> GetGroup(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeMap_GetOption", dxTarget, "group");
        }
        public static Task SetGroup(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeMap_SetOption", dxTarget, "group", value);
        }
        public static Task<bool?> GetHoverEnabled(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxTreeMap_GetOption", dxTarget, "hoverEnabled");
        }
        public static Task SetHoverEnabled(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeMap_SetOption", dxTarget, "hoverEnabled", value);
        }
        public static Task<string> GetIdField(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxTreeMap_GetOption", dxTarget, "idField");
        }
        public static Task SetIdField(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeMap_SetOption", dxTarget, "idField", value);
        }
        public static Task<bool?> GetInteractWithGroup(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxTreeMap_GetOption", dxTarget, "interactWithGroup");
        }
        public static Task SetInteractWithGroup(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeMap_SetOption", dxTarget, "interactWithGroup", value);
        }
        public static Task<string> GetLabelField(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxTreeMap_GetOption", dxTarget, "labelField");
        }
        public static Task SetLabelField(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeMap_SetOption", dxTarget, "labelField", value);
        }
        public static Task<object> GetLayoutAlgorithm(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeMap_GetOption", dxTarget, "layoutAlgorithm");
        }
        public static Task SetLayoutAlgorithm(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeMap_SetOption", dxTarget, "layoutAlgorithm", value);
        }
        public static Task<string> GetLayoutDirection(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxTreeMap_GetOption", dxTarget, "layoutDirection");
        }
        public static Task SetLayoutDirection(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeMap_SetOption", dxTarget, "layoutDirection", value);
        }
        public static Task<float?> GetMaxDepth(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_DxTreeMap_GetOption", dxTarget, "maxDepth");
        }
        public static Task SetMaxDepth(ElementReference dxTarget, float? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeMap_SetOption", dxTarget, "maxDepth", value);
        }
        public static Task<string> GetParentField(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxTreeMap_GetOption", dxTarget, "parentField");
        }
        public static Task SetParentField(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeMap_SetOption", dxTarget, "parentField", value);
        }
        public static Task<string> GetResolveLabelOverflow(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxTreeMap_GetOption", dxTarget, "resolveLabelOverflow");
        }
        public static Task SetResolveLabelOverflow(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeMap_SetOption", dxTarget, "resolveLabelOverflow", value);
        }
        public static Task<string> GetSelectionMode(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxTreeMap_GetOption", dxTarget, "selectionMode");
        }
        public static Task SetSelectionMode(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeMap_SetOption", dxTarget, "selectionMode", value);
        }
        public static Task<object> GetTile(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeMap_GetOption", dxTarget, "tile");
        }
        public static Task SetTile(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeMap_SetOption", dxTarget, "tile", value);
        }
        public static Task<string> GetValueField(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxTreeMap_GetOption", dxTarget, "valueField");
        }
        public static Task SetValueField(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeMap_SetOption", dxTarget, "valueField", value);
        }
        public static Task ClearSelection(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeMap_clearSelection_0", dxTarget);
        }
        public static Task DrillUp(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeMap_drillUp_1", dxTarget);
        }
        public static Task<object> GetCurrentNode(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeMap_getCurrentNode_2", dxTarget);
        }
        public static Task<object> GetDataSourceEx(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeMap_getDataSource_3", dxTarget);
        }
        public static Task<object> GetRootNode(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeMap_getRootNode_4", dxTarget);
        }
        public static Task HideTooltip(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeMap_hideTooltip_5", dxTarget);
        }
        public static Task ResetDrillDown(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeMap_resetDrillDown_6", dxTarget);
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
        public static Task Init(ElementReference dxTarget, DevExpress.Viz.Map.DxVectorMapOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxVectorMap_Init", dxTarget, json);
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
        public static Task<object> GetAreaSettings(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxVectorMap_GetOption", dxTarget, "areaSettings");
        }
        public static Task SetAreaSettings(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxVectorMap_SetOption", dxTarget, "areaSettings", value);
        }
        public static Task<object> GetBackground(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxVectorMap_GetOption", dxTarget, "background");
        }
        public static Task SetBackground(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxVectorMap_SetOption", dxTarget, "background", value);
        }
        public static Task<object> GetBounds(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxVectorMap_GetOption", dxTarget, "bounds");
        }
        public static Task SetBounds(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxVectorMap_SetOption", dxTarget, "bounds", value);
        }
        public static Task<object> GetCenter(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxVectorMap_GetOption", dxTarget, "center");
        }
        public static Task SetCenter(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxVectorMap_SetOption", dxTarget, "center", value);
        }
        public static Task<object> GetControlBar(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxVectorMap_GetOption", dxTarget, "controlBar");
        }
        public static Task SetControlBar(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxVectorMap_SetOption", dxTarget, "controlBar", value);
        }
        public static Task<object> GetLayers(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxVectorMap_GetOption", dxTarget, "layers");
        }
        public static Task SetLayers(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxVectorMap_SetOption", dxTarget, "layers", value);
        }
        public static Task<object> GetLegends(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxVectorMap_GetOption", dxTarget, "legends");
        }
        public static Task SetLegends(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxVectorMap_SetOption", dxTarget, "legends", value);
        }
        public static Task<object> GetMapData(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxVectorMap_GetOption", dxTarget, "mapData");
        }
        public static Task SetMapData(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxVectorMap_SetOption", dxTarget, "mapData", value);
        }
        public static Task<object> GetMarkers(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxVectorMap_GetOption", dxTarget, "markers");
        }
        public static Task SetMarkers(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxVectorMap_SetOption", dxTarget, "markers", value);
        }
        public static Task<object> GetMarkerSettings(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxVectorMap_GetOption", dxTarget, "markerSettings");
        }
        public static Task SetMarkerSettings(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxVectorMap_SetOption", dxTarget, "markerSettings", value);
        }
        public static Task<float?> GetMaxZoomFactor(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_DxVectorMap_GetOption", dxTarget, "maxZoomFactor");
        }
        public static Task SetMaxZoomFactor(ElementReference dxTarget, float? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxVectorMap_SetOption", dxTarget, "maxZoomFactor", value);
        }
        public static Task<bool?> GetPanningEnabled(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxVectorMap_GetOption", dxTarget, "panningEnabled");
        }
        public static Task SetPanningEnabled(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxVectorMap_SetOption", dxTarget, "panningEnabled", value);
        }
        public static Task<object> GetProjection(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxVectorMap_GetOption", dxTarget, "projection");
        }
        public static Task SetProjection(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxVectorMap_SetOption", dxTarget, "projection", value);
        }
        public static Task<bool?> GetTouchEnabled(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxVectorMap_GetOption", dxTarget, "touchEnabled");
        }
        public static Task SetTouchEnabled(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxVectorMap_SetOption", dxTarget, "touchEnabled", value);
        }
        public static Task<bool?> GetWheelEnabled(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxVectorMap_GetOption", dxTarget, "wheelEnabled");
        }
        public static Task SetWheelEnabled(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxVectorMap_SetOption", dxTarget, "wheelEnabled", value);
        }
        public static Task<float?> GetZoomFactor(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_DxVectorMap_GetOption", dxTarget, "zoomFactor");
        }
        public static Task SetZoomFactor(ElementReference dxTarget, float? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxVectorMap_SetOption", dxTarget, "zoomFactor", value);
        }
        public static Task<bool?> GetZoomingEnabled(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxVectorMap_GetOption", dxTarget, "zoomingEnabled");
        }
        public static Task SetZoomingEnabled(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxVectorMap_SetOption", dxTarget, "zoomingEnabled", value);
        }
        public static Task<object> CenterEx(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxVectorMap_center_0", dxTarget);
        }
        public static Task CenterEx(ElementReference dxTarget, object centerCoordinates)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxVectorMap_center_1", dxTarget, centerCoordinates);
        }
        public static Task ClearAreaSelection(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxVectorMap_clearAreaSelection_2", dxTarget);
        }
        public static Task ClearMarkerSelection(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxVectorMap_clearMarkerSelection_3", dxTarget);
        }
        public static Task ClearSelection(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxVectorMap_clearSelection_4", dxTarget);
        }
        public static Task<object> ConvertCoordinates(ElementReference dxTarget, float x, float y)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxVectorMap_convertCoordinates_5", dxTarget, x, y);
        }
        public static Task<object> GetAreas(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxVectorMap_getAreas_6", dxTarget);
        }
        public static Task<object> GetLayerByIndex(ElementReference dxTarget, float index)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxVectorMap_getLayerByIndex_7", dxTarget, index);
        }
        public static Task<object> GetLayerByName(ElementReference dxTarget, string name)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxVectorMap_getLayerByName_8", dxTarget, name);
        }
        public static Task<object> GetLayersEx(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxVectorMap_getLayers_9", dxTarget);
        }
        public static Task<object> GetMarkersEx(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxVectorMap_getMarkers_10", dxTarget);
        }
        public static Task<object> Viewport(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxVectorMap_viewport_11", dxTarget);
        }
        public static Task Viewport(ElementReference dxTarget, object viewportCoordinates)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxVectorMap_viewport_12", dxTarget, viewportCoordinates);
        }
        public static Task<float> ZoomFactorEx(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<float>("BlazorDevExtreme_DxVectorMap_zoomFactor_13", dxTarget);
        }
        public static Task ZoomFactorEx(ElementReference dxTarget, float zoomFactor)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxVectorMap_zoomFactor_14", dxTarget, zoomFactor);
        }
    }
    public class CoreInterop
    {
        public static Task CurrentPalette(string paletteName)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Core_currentPalette_0", paletteName);
        }
        public static Task CurrentTheme(string platform, string colorScheme)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Core_currentTheme_1", platform, colorScheme);
        }
        public static Task CurrentTheme(string theme)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Core_currentTheme_2", theme);
        }
        public static Task<object> GetPalette(string paletteName)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Core_getPalette_3", paletteName);
        }
        public static Task RegisterPalette(string paletteName, object palette)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Core_registerPalette_4", paletteName, palette);
        }
        public static Task RegisterTheme(object customTheme, string baseTheme)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Core_registerTheme_5", customTheme, baseTheme);
        }
    }
}
