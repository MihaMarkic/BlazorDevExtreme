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
        public static ValueTask<object> GetDataSourceEx(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DataHelperMixin_getDataSource_0", dxTarget);
        }
    }

    public class DxEventInterop
    {
        public static ValueTask<bool> IsDefaultPrevented(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool>("BlazorDevExtreme_DxEvent_isDefaultPrevented_0", dxTarget);
        }
        public static ValueTask<bool> IsImmediatePropagationStopped(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool>("BlazorDevExtreme_DxEvent_isImmediatePropagationStopped_1", dxTarget);
        }
        public static ValueTask<bool> IsPropagationStopped(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool>("BlazorDevExtreme_DxEvent_isPropagationStopped_2", dxTarget);
        }
        public static ValueTask<object> PreventDefault(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxEvent_preventDefault_3", dxTarget);
        }
        public static ValueTask<object> StopImmediatePropagation(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxEvent_stopImmediatePropagation_4", dxTarget);
        }
        public static ValueTask<object> StopPropagation(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxEvent_stopPropagation_5", dxTarget);
        }
    }
    public class LocalizationInterop
    {
        public static ValueTask<object> LoadMessages(object messages)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Localization_loadMessages_0", messages);
        }
        public static ValueTask<string> Locale()
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_Localization_locale_1");
        }
        public static ValueTask<object> Locale(string locale)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Localization_locale_2", locale);
        }
    }
    public class AnimationPresetsInterop
    {
        public static ValueTask<object> ApplyChanges(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_AnimationPresets_applyChanges_0", dxTarget);
        }
        public static ValueTask<object> Clear(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_AnimationPresets_clear_1", dxTarget);
        }
        public static ValueTask<object> Clear(ElementReference dxTarget, string name)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_AnimationPresets_clear_2", dxTarget, name);
        }
        public static ValueTask<object> GetPreset(ElementReference dxTarget, string name)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_AnimationPresets_getPreset_3", dxTarget, name);
        }
        public static ValueTask<object> RegisterDefaultPresets(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_AnimationPresets_registerDefaultPresets_4", dxTarget);
        }
        public static ValueTask<object> RegisterPreset(ElementReference dxTarget, string name, object config)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_AnimationPresets_registerPreset_5", dxTarget, name, config);
        }
        public static ValueTask<object> ResetToDefaults(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_AnimationPresets_resetToDefaults_6", dxTarget);
        }
    }
    public class TransitionExecutorInterop
    {
        public static ValueTask<object> Enter(ElementReference dxTarget, object elements, object animation)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_TransitionExecutor_enter_0", dxTarget, elements, animation);
        }
        public static ValueTask<object> Leave(ElementReference dxTarget, object elements, object animation)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_TransitionExecutor_leave_1", dxTarget, elements, animation);
        }
        public static ValueTask<object> Reset(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_TransitionExecutor_reset_2", dxTarget);
        }
        public static ValueTask<object> Start(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_TransitionExecutor_start_3", dxTarget);
        }
        public static ValueTask<object> Stop(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_TransitionExecutor_stop_4", dxTarget);
        }
    }
    public class ComponentInterop
    {
        public static event EventHandler<JQueryEventArgs> Disposing;
        public static event EventHandler<JQueryEventArgs> Initialized;
        public static event EventHandler<JQueryEventArgs> OptionChanged;
        public static ValueTask<object> Init(ElementReference dxTarget, DevExpress.ComponentOptions options)
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
        public static ValueTask<object> BeginUpdate(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Component_beginUpdate_0", dxTarget);
        }
        public static ValueTask<object> EndUpdate(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Component_endUpdate_1", dxTarget);
        }
        public static ValueTask<object> Instance(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Component_instance_2", dxTarget);
        }
        public static ValueTask<object> Off(ElementReference dxTarget, string eventName)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Component_off_3", dxTarget, eventName);
        }
        public static ValueTask<object> Off(ElementReference dxTarget, string eventName, object eventHandler)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Component_off_4", dxTarget, eventName, eventHandler);
        }
        public static ValueTask<object> On(ElementReference dxTarget, string eventName, object eventHandler)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Component_on_5", dxTarget, eventName, eventHandler);
        }
        public static ValueTask<object> On(ElementReference dxTarget, object events)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Component_on_6", dxTarget, events);
        }
        public static ValueTask<object> Option(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Component_option_7", dxTarget);
        }
        public static ValueTask<object> Option(ElementReference dxTarget, string optionName)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Component_option_8", dxTarget, optionName);
        }
        public static ValueTask<object> Option(ElementReference dxTarget, string optionName, object optionValue)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Component_option_9", dxTarget, optionName, optionValue);
        }
        public static ValueTask<object> Option(ElementReference dxTarget, object options)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Component_option_10", dxTarget, options);
        }
    }
    public class DevicesObjectInterop
    {
        public static ValueTask<object> Current(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DevicesObject_current_0", dxTarget);
        }
        public static ValueTask<object> Current(ElementReference dxTarget, object deviceName)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DevicesObject_current_1", dxTarget, deviceName);
        }
        public static ValueTask<object> Off(ElementReference dxTarget, string eventName)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DevicesObject_off_2", dxTarget, eventName);
        }
        public static ValueTask<object> Off(ElementReference dxTarget, string eventName, object eventHandler)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DevicesObject_off_3", dxTarget, eventName, eventHandler);
        }
        public static ValueTask<object> On(ElementReference dxTarget, string eventName, object eventHandler)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DevicesObject_on_4", dxTarget, eventName, eventHandler);
        }
        public static ValueTask<object> On(ElementReference dxTarget, object events)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DevicesObject_on_5", dxTarget, events);
        }
        public static ValueTask<string> Orientation(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DevicesObject_orientation_6", dxTarget);
        }
        public static ValueTask<object> Real(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DevicesObject_real_7", dxTarget);
        }
    }
    public class DOMComponentInterop: ComponentInterop
    {
        public static ValueTask<object> Init(ElementReference dxTarget, DevExpress.DOMComponentOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DOMComponent_Init", dxTarget, json);
        }
        public static ValueTask<object> GetBindingOptions(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DOMComponent_GetOption", dxTarget, "bindingOptions");
        }
        public static ValueTask<object> SetBindingOptions(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DOMComponent_SetOption", dxTarget, "bindingOptions", value);
        }
        public static ValueTask<object> GetElementAttr(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DOMComponent_GetOption", dxTarget, "elementAttr");
        }
        public static ValueTask<object> SetElementAttr(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DOMComponent_SetOption", dxTarget, "elementAttr", value);
        }
        public static ValueTask<object> GetHeight(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DOMComponent_GetOption", dxTarget, "height");
        }
        public static ValueTask<object> SetHeight(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DOMComponent_SetOption", dxTarget, "height", value);
        }
        public static ValueTask<bool?> GetRtlEnabled(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DOMComponent_GetOption", dxTarget, "rtlEnabled");
        }
        public static ValueTask<object> SetRtlEnabled(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DOMComponent_SetOption", dxTarget, "rtlEnabled", value);
        }
        public static ValueTask<object> GetWidth(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DOMComponent_GetOption", dxTarget, "width");
        }
        public static ValueTask<object> SetWidth(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DOMComponent_SetOption", dxTarget, "width", value);
        }
        public static ValueTask<object> DefaultOptions(object rule)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DOMComponent_defaultOptions_0", rule);
        }
        public static ValueTask<object> GetInstance(object element)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DOMComponent_getInstance_1", element);
        }
        public static ValueTask<object> Dispose(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DOMComponent_dispose_0", dxTarget);
        }
        public static ValueTask<object> Element(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DOMComponent_element_1", dxTarget);
        }
    }
    public class EndpointSelectorInterop
    {
        public static ValueTask<string> UrlFor(ElementReference dxTarget, string key)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_EndpointSelector_urlFor_0", dxTarget, key);
        }
    }
    public class ValidationEngineInterop
    {
        public static ValueTask<object> GetGroupConfig()
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_ValidationEngine_getGroupConfig_0");
        }
        public static ValueTask<object> GetGroupConfig(object group)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_ValidationEngine_getGroupConfig_1", group);
        }
        public static ValueTask<object> RegisterModelForValidation(object model)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_ValidationEngine_registerModelForValidation_2", model);
        }
        public static ValueTask<object> ResetGroup()
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_ValidationEngine_resetGroup_3");
        }
        public static ValueTask<object> ResetGroup(object group)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_ValidationEngine_resetGroup_4", group);
        }
        public static ValueTask<object> UnregisterModelForValidation(object model)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_ValidationEngine_unregisterModelForValidation_5", model);
        }
        public static ValueTask<object> ValidateGroup()
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_ValidationEngine_validateGroup_6");
        }
        public static ValueTask<object> ValidateGroup(object group)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_ValidationEngine_validateGroup_7", group);
        }
        public static ValueTask<object> ValidateModel(object model)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_ValidationEngine_validateModel_8", model);
        }
    }
    public class UiInterop
    {
        public static ValueTask<object> Notify(string message, string type, float displayTime)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Ui_notify_0", message, type, displayTime);
        }
        public static ValueTask<object> Notify(object options, string type, float displayTime)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Ui_notify_1", options, type, displayTime);
        }
        public static ValueTask<object> SetTemplateEngine(string templateEngineName)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Ui_setTemplateEngine_2", templateEngineName);
        }
        public static ValueTask<object> SetTemplateEngine(object templateEngineOptions)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Ui_setTemplateEngine_3", templateEngineOptions);
        }
    }
    public class VizInterop
    {
        public static ValueTask<object> CurrentPalette(string paletteName)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Viz_currentPalette_0", paletteName);
        }
        public static ValueTask<string> CurrentTheme()
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_Viz_currentTheme_1");
        }
        public static ValueTask<object> CurrentTheme(string platform, string colorScheme)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Viz_currentTheme_2", platform, colorScheme);
        }
        public static ValueTask<object> CurrentTheme(string theme)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Viz_currentTheme_3", theme);
        }
        public static ValueTask<object> ExportFromMarkup(string markup, object options)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Viz_exportFromMarkup_4", markup, options);
        }
        public static ValueTask<string> GetMarkup(object widgetInstances)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_Viz_getMarkup_5", widgetInstances);
        }
        public static ValueTask<object> GetPalette(string paletteName)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Viz_getPalette_6", paletteName);
        }
        public static ValueTask<object> GetTheme(string theme)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Viz_getTheme_7", theme);
        }
        public static ValueTask<object> RefreshPaths()
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Viz_refreshPaths_8");
        }
        public static ValueTask<object> RefreshTheme()
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Viz_refreshTheme_9");
        }
        public static ValueTask<object> RegisterPalette(string paletteName, object palette)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Viz_registerPalette_10", paletteName, palette);
        }
        public static ValueTask<object> RegisterTheme(object customTheme, string baseTheme)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Viz_registerTheme_11", customTheme, baseTheme);
        }
    }
}
namespace DevExpress.Data
{
    public class GuidInterop
    {
        public static ValueTask<string> ToString(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_Guid_toString_0", dxTarget);
        }
        public static ValueTask<string> ValueOf(ElementReference dxTarget)
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
        public static ValueTask<object> Init(ElementReference dxTarget, DevExpress.Data.StoreOptions options)
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
        public static ValueTask<object> GetErrorHandler(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Store_GetOption", dxTarget, "errorHandler");
        }
        public static ValueTask<object> SetErrorHandler(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Store_SetOption", dxTarget, "errorHandler", value);
        }
        public static ValueTask<object> GetKey(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Store_GetOption", dxTarget, "key");
        }
        public static ValueTask<object> SetKey(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Store_SetOption", dxTarget, "key", value);
        }
        public static ValueTask<object> ByKey(ElementReference dxTarget, object key)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Store_byKey_0", dxTarget, key);
        }
        public static ValueTask<object> Insert(ElementReference dxTarget, object values)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Store_insert_1", dxTarget, values);
        }
        public static ValueTask<object> Key(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Store_key_2", dxTarget);
        }
        public static ValueTask<object> KeyOf(ElementReference dxTarget, object obj)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Store_keyOf_3", dxTarget, obj);
        }
        public static ValueTask<object> Load(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Store_load_4", dxTarget);
        }
        public static ValueTask<object> Load(ElementReference dxTarget, object options)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Store_load_5", dxTarget, options);
        }
        public static ValueTask<object> Off(ElementReference dxTarget, string eventName)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Store_off_6", dxTarget, eventName);
        }
        public static ValueTask<object> Off(ElementReference dxTarget, string eventName, object eventHandler)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Store_off_7", dxTarget, eventName, eventHandler);
        }
        public static ValueTask<object> On(ElementReference dxTarget, string eventName, object eventHandler)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Store_on_8", dxTarget, eventName, eventHandler);
        }
        public static ValueTask<object> On(ElementReference dxTarget, object events)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Store_on_9", dxTarget, events);
        }
        public static ValueTask<object> Remove(ElementReference dxTarget, object key)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Store_remove_10", dxTarget, key);
        }
        public static ValueTask<object> TotalCount(ElementReference dxTarget, object obj)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Store_totalCount_11", dxTarget, obj);
        }
        public static ValueTask<object> Update(ElementReference dxTarget, object key, object values)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Store_update_12", dxTarget, key, values);
        }
    }
    public class ArrayStoreInterop: StoreInterop
    {
        public static ValueTask<object> Init(ElementReference dxTarget, DevExpress.Data.ArrayStoreOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_ArrayStore_Init", dxTarget, json);
        }
        public static ValueTask<object> GetData(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_ArrayStore_GetOption", dxTarget, "data");
        }
        public static ValueTask<object> SetData(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_ArrayStore_SetOption", dxTarget, "data", value);
        }
        public static ValueTask<object> Clear(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_ArrayStore_clear_0", dxTarget);
        }
        public static ValueTask<object> CreateQuery(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_ArrayStore_createQuery_1", dxTarget);
        }
    }
    public class CustomStoreInterop: StoreInterop
    {
        public static ValueTask<object> Init(ElementReference dxTarget, DevExpress.Data.CustomStoreOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_CustomStore_Init", dxTarget, json);
        }
        public static ValueTask<object> GetByKey(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_CustomStore_GetOption", dxTarget, "byKey");
        }
        public static ValueTask<object> SetByKey(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_CustomStore_SetOption", dxTarget, "byKey", value);
        }
        public static ValueTask<bool?> GetCacheRawData(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_CustomStore_GetOption", dxTarget, "cacheRawData");
        }
        public static ValueTask<object> SetCacheRawData(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_CustomStore_SetOption", dxTarget, "cacheRawData", value);
        }
        public static ValueTask<object> GetInsert(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_CustomStore_GetOption", dxTarget, "insert");
        }
        public static ValueTask<object> SetInsert(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_CustomStore_SetOption", dxTarget, "insert", value);
        }
        public static ValueTask<object> GetLoad(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_CustomStore_GetOption", dxTarget, "load");
        }
        public static ValueTask<object> SetLoad(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_CustomStore_SetOption", dxTarget, "load", value);
        }
        public static ValueTask<string> GetLoadMode(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_CustomStore_GetOption", dxTarget, "loadMode");
        }
        public static ValueTask<object> SetLoadMode(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_CustomStore_SetOption", dxTarget, "loadMode", value);
        }
        public static ValueTask<object> GetRemove(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_CustomStore_GetOption", dxTarget, "remove");
        }
        public static ValueTask<object> SetRemove(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_CustomStore_SetOption", dxTarget, "remove", value);
        }
        public static ValueTask<object> GetTotalCount(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_CustomStore_GetOption", dxTarget, "totalCount");
        }
        public static ValueTask<object> SetTotalCount(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_CustomStore_SetOption", dxTarget, "totalCount", value);
        }
        public static ValueTask<object> GetUpdate(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_CustomStore_GetOption", dxTarget, "update");
        }
        public static ValueTask<object> SetUpdate(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_CustomStore_SetOption", dxTarget, "update", value);
        }
        public static ValueTask<bool?> GetUseDefaultSearch(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_CustomStore_GetOption", dxTarget, "useDefaultSearch");
        }
        public static ValueTask<object> SetUseDefaultSearch(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_CustomStore_SetOption", dxTarget, "useDefaultSearch", value);
        }
        public static ValueTask<object> ClearRawDataCache(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_CustomStore_clearRawDataCache_0", dxTarget);
        }
    }
    public class DataSourceInterop
    {
        public static event EventHandler<JQueryEventArgs> Changed;
        public static event EventHandler<JQueryEventArgs> LoadError;
        public static event EventHandler<JQueryEventArgs> LoadingChanged;
        public static ValueTask<object> Init(ElementReference dxTarget, DevExpress.Data.DataSourceOptions options)
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
        public static ValueTask<object> GetCustomQueryParams(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DataSource_GetOption", dxTarget, "customQueryParams");
        }
        public static ValueTask<object> SetCustomQueryParams(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DataSource_SetOption", dxTarget, "customQueryParams", value);
        }
        public static ValueTask<object> GetExpand(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DataSource_GetOption", dxTarget, "expand");
        }
        public static ValueTask<object> SetExpand(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DataSource_SetOption", dxTarget, "expand", value);
        }
        public static ValueTask<object> GetFilter(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DataSource_GetOption", dxTarget, "filter");
        }
        public static ValueTask<object> SetFilter(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DataSource_SetOption", dxTarget, "filter", value);
        }
        public static ValueTask<object> GetGroup(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DataSource_GetOption", dxTarget, "group");
        }
        public static ValueTask<object> SetGroup(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DataSource_SetOption", dxTarget, "group", value);
        }
        public static ValueTask<object> GetMap(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DataSource_GetOption", dxTarget, "map");
        }
        public static ValueTask<object> SetMap(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DataSource_SetOption", dxTarget, "map", value);
        }
        public static ValueTask<float?> GetPageSize(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_DataSource_GetOption", dxTarget, "pageSize");
        }
        public static ValueTask<object> SetPageSize(ElementReference dxTarget, float? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DataSource_SetOption", dxTarget, "pageSize", value);
        }
        public static ValueTask<bool?> GetPaginate(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DataSource_GetOption", dxTarget, "paginate");
        }
        public static ValueTask<object> SetPaginate(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DataSource_SetOption", dxTarget, "paginate", value);
        }
        public static ValueTask<object> GetPostProcess(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DataSource_GetOption", dxTarget, "postProcess");
        }
        public static ValueTask<object> SetPostProcess(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DataSource_SetOption", dxTarget, "postProcess", value);
        }
        public static ValueTask<bool?> GetRequireTotalCount(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DataSource_GetOption", dxTarget, "requireTotalCount");
        }
        public static ValueTask<object> SetRequireTotalCount(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DataSource_SetOption", dxTarget, "requireTotalCount", value);
        }
        public static ValueTask<object> GetSearchExpr(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DataSource_GetOption", dxTarget, "searchExpr");
        }
        public static ValueTask<object> SetSearchExpr(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DataSource_SetOption", dxTarget, "searchExpr", value);
        }
        public static ValueTask<string> GetSearchOperation(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DataSource_GetOption", dxTarget, "searchOperation");
        }
        public static ValueTask<object> SetSearchOperation(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DataSource_SetOption", dxTarget, "searchOperation", value);
        }
        public static ValueTask<object> GetSearchValue(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DataSource_GetOption", dxTarget, "searchValue");
        }
        public static ValueTask<object> SetSearchValue(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DataSource_SetOption", dxTarget, "searchValue", value);
        }
        public static ValueTask<object> GetSelect(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DataSource_GetOption", dxTarget, "select");
        }
        public static ValueTask<object> SetSelect(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DataSource_SetOption", dxTarget, "select", value);
        }
        public static ValueTask<object> GetSort(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DataSource_GetOption", dxTarget, "sort");
        }
        public static ValueTask<object> SetSort(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DataSource_SetOption", dxTarget, "sort", value);
        }
        public static ValueTask<object> GetStore(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DataSource_GetOption", dxTarget, "store");
        }
        public static ValueTask<object> SetStore(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DataSource_SetOption", dxTarget, "store", value);
        }
        public static ValueTask<bool> Cancel(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool>("BlazorDevExtreme_DataSource_cancel_0", dxTarget);
        }
        public static ValueTask<object> Dispose(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DataSource_dispose_1", dxTarget);
        }
        public static ValueTask<object> Filter(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DataSource_filter_2", dxTarget);
        }
        public static ValueTask<object> Filter(ElementReference dxTarget, object filterExpr)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DataSource_filter_3", dxTarget, filterExpr);
        }
        public static ValueTask<object> Group(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DataSource_group_4", dxTarget);
        }
        public static ValueTask<object> Group(ElementReference dxTarget, object groupExpr)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DataSource_group_5", dxTarget, groupExpr);
        }
        public static ValueTask<bool> IsLastPage(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool>("BlazorDevExtreme_DataSource_isLastPage_6", dxTarget);
        }
        public static ValueTask<bool> IsLoaded(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool>("BlazorDevExtreme_DataSource_isLoaded_7", dxTarget);
        }
        public static ValueTask<bool> IsLoading(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool>("BlazorDevExtreme_DataSource_isLoading_8", dxTarget);
        }
        public static ValueTask<object> Items(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DataSource_items_9", dxTarget);
        }
        public static ValueTask<object> Key(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DataSource_key_10", dxTarget);
        }
        public static ValueTask<object> Load(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DataSource_load_11", dxTarget);
        }
        public static ValueTask<object> LoadOptions(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DataSource_loadOptions_12", dxTarget);
        }
        public static ValueTask<object> Off(ElementReference dxTarget, string eventName)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DataSource_off_13", dxTarget, eventName);
        }
        public static ValueTask<object> Off(ElementReference dxTarget, string eventName, object eventHandler)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DataSource_off_14", dxTarget, eventName, eventHandler);
        }
        public static ValueTask<object> On(ElementReference dxTarget, string eventName, object eventHandler)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DataSource_on_15", dxTarget, eventName, eventHandler);
        }
        public static ValueTask<object> On(ElementReference dxTarget, object events)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DataSource_on_16", dxTarget, events);
        }
        public static ValueTask<float> PageIndex(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<float>("BlazorDevExtreme_DataSource_pageIndex_17", dxTarget);
        }
        public static ValueTask<object> PageIndex(ElementReference dxTarget, float newIndex)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DataSource_pageIndex_18", dxTarget, newIndex);
        }
        public static ValueTask<float> PageSize(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<float>("BlazorDevExtreme_DataSource_pageSize_19", dxTarget);
        }
        public static ValueTask<object> PageSize(ElementReference dxTarget, float value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DataSource_pageSize_20", dxTarget, value);
        }
        public static ValueTask<bool> Paginate(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool>("BlazorDevExtreme_DataSource_paginate_21", dxTarget);
        }
        public static ValueTask<object> Paginate(ElementReference dxTarget, bool value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DataSource_paginate_22", dxTarget, value);
        }
        public static ValueTask<object> Reload(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DataSource_reload_23", dxTarget);
        }
        public static ValueTask<bool> RequireTotalCount(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool>("BlazorDevExtreme_DataSource_requireTotalCount_24", dxTarget);
        }
        public static ValueTask<object> RequireTotalCount(ElementReference dxTarget, bool value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DataSource_requireTotalCount_25", dxTarget, value);
        }
        public static ValueTask<object> SearchExpr(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DataSource_searchExpr_26", dxTarget);
        }
        public static ValueTask<object> SearchExpr(ElementReference dxTarget, object expr)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DataSource_searchExpr_27", dxTarget, expr);
        }
        public static ValueTask<string> SearchOperation(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DataSource_searchOperation_28", dxTarget);
        }
        public static ValueTask<object> SearchOperation(ElementReference dxTarget, string op)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DataSource_searchOperation_29", dxTarget, op);
        }
        public static ValueTask<object> SearchValue(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DataSource_searchValue_30", dxTarget);
        }
        public static ValueTask<object> SearchValue(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DataSource_searchValue_31", dxTarget, value);
        }
        public static ValueTask<object> Select(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DataSource_select_32", dxTarget);
        }
        public static ValueTask<object> Select(ElementReference dxTarget, object expr)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DataSource_select_33", dxTarget, expr);
        }
        public static ValueTask<object> Sort(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DataSource_sort_34", dxTarget);
        }
        public static ValueTask<object> Sort(ElementReference dxTarget, object sortExpr)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DataSource_sort_35", dxTarget, sortExpr);
        }
        public static ValueTask<object> Store(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DataSource_store_36", dxTarget);
        }
        public static ValueTask<float> TotalCount(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<float>("BlazorDevExtreme_DataSource_totalCount_37", dxTarget);
        }
    }
    public class LocalStoreInterop: ArrayStoreInterop
    {
        public static ValueTask<object> Init(ElementReference dxTarget, DevExpress.Data.LocalStoreOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_LocalStore_Init", dxTarget, json);
        }
        public static ValueTask<float?> GetFlushInterval(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_LocalStore_GetOption", dxTarget, "flushInterval");
        }
        public static ValueTask<object> SetFlushInterval(ElementReference dxTarget, float? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_LocalStore_SetOption", dxTarget, "flushInterval", value);
        }
        public static ValueTask<bool?> GetImmediate(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_LocalStore_GetOption", dxTarget, "immediate");
        }
        public static ValueTask<object> SetImmediate(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_LocalStore_SetOption", dxTarget, "immediate", value);
        }
        public static ValueTask<string> GetName(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_LocalStore_GetOption", dxTarget, "name");
        }
        public static ValueTask<object> SetName(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_LocalStore_SetOption", dxTarget, "name", value);
        }
        public static ValueTask<object> Clear(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_LocalStore_clear_0", dxTarget);
        }
    }
    public class QueryInterop
    {
        public static ValueTask<object> Aggregate(ElementReference dxTarget, object seed, object step, object finalize)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Query_aggregate_0", dxTarget, seed, step, finalize);
        }
        public static ValueTask<object> Aggregate(ElementReference dxTarget, object step)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Query_aggregate_1", dxTarget, step);
        }
        public static ValueTask<object> Avg(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Query_avg_2", dxTarget);
        }
        public static ValueTask<object> Avg(ElementReference dxTarget, object getter)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Query_avg_3", dxTarget, getter);
        }
        public static ValueTask<object> Count(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Query_count_4", dxTarget);
        }
        public static ValueTask<object> Enumerate(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Query_enumerate_5", dxTarget);
        }
        public static ValueTask<object> Filter(ElementReference dxTarget, object criteria)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Query_filter_6", dxTarget, criteria);
        }
        public static ValueTask<object> GroupBy(ElementReference dxTarget, object getter)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Query_groupBy_8", dxTarget, getter);
        }
        public static ValueTask<object> Max(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Query_max_9", dxTarget);
        }
        public static ValueTask<object> Max(ElementReference dxTarget, object getter)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Query_max_10", dxTarget, getter);
        }
        public static ValueTask<object> Min(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Query_min_11", dxTarget);
        }
        public static ValueTask<object> Min(ElementReference dxTarget, object getter)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Query_min_12", dxTarget, getter);
        }
        public static ValueTask<object> Select(ElementReference dxTarget, object getter)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Query_select_13", dxTarget, getter);
        }
        public static ValueTask<object> Slice(ElementReference dxTarget, float skip, float take)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Query_slice_14", dxTarget, skip, take);
        }
        public static ValueTask<object> SortBy(ElementReference dxTarget, object getter)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Query_sortBy_15", dxTarget, getter);
        }
        public static ValueTask<object> SortBy(ElementReference dxTarget, object getter, bool desc)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Query_sortBy_16", dxTarget, getter, desc);
        }
        public static ValueTask<object> Sum(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Query_sum_17", dxTarget);
        }
        public static ValueTask<object> Sum(ElementReference dxTarget, object getter)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Query_sum_18", dxTarget, getter);
        }
        public static ValueTask<object> ThenBy(ElementReference dxTarget, object getter)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Query_thenBy_19", dxTarget, getter);
        }
        public static ValueTask<object> ThenBy(ElementReference dxTarget, object getter, bool desc)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Query_thenBy_20", dxTarget, getter, desc);
        }
        public static ValueTask<object> ToArray(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Query_toArray_21", dxTarget);
        }
    }
    public class ODataContextInterop
    {
        public static ValueTask<object> Init(ElementReference dxTarget, DevExpress.Data.ODataContextOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_ODataContext_Init", dxTarget, json);
        }
        public static ValueTask<object> GetBeforeSend(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_ODataContext_GetOption", dxTarget, "beforeSend");
        }
        public static ValueTask<object> SetBeforeSend(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_ODataContext_SetOption", dxTarget, "beforeSend", value);
        }
        public static ValueTask<bool?> GetDeserializeDates(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_ODataContext_GetOption", dxTarget, "deserializeDates");
        }
        public static ValueTask<object> SetDeserializeDates(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_ODataContext_SetOption", dxTarget, "deserializeDates", value);
        }
        public static ValueTask<object> GetEntities(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_ODataContext_GetOption", dxTarget, "entities");
        }
        public static ValueTask<object> SetEntities(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_ODataContext_SetOption", dxTarget, "entities", value);
        }
        public static ValueTask<object> GetErrorHandler(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_ODataContext_GetOption", dxTarget, "errorHandler");
        }
        public static ValueTask<object> SetErrorHandler(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_ODataContext_SetOption", dxTarget, "errorHandler", value);
        }
        public static ValueTask<bool?> GetJsonp(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_ODataContext_GetOption", dxTarget, "jsonp");
        }
        public static ValueTask<object> SetJsonp(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_ODataContext_SetOption", dxTarget, "jsonp", value);
        }
        public static ValueTask<string> GetUrl(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_ODataContext_GetOption", dxTarget, "url");
        }
        public static ValueTask<object> SetUrl(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_ODataContext_SetOption", dxTarget, "url", value);
        }
        public static ValueTask<float?> GetVersion(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_ODataContext_GetOption", dxTarget, "version");
        }
        public static ValueTask<object> SetVersion(ElementReference dxTarget, float? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_ODataContext_SetOption", dxTarget, "version", value);
        }
        public static ValueTask<bool?> GetWithCredentials(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_ODataContext_GetOption", dxTarget, "withCredentials");
        }
        public static ValueTask<object> SetWithCredentials(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_ODataContext_SetOption", dxTarget, "withCredentials", value);
        }
        public static ValueTask<object> Get(ElementReference dxTarget, string operationName, object @params)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_ODataContext_get_0", dxTarget, operationName, @params);
        }
        public static ValueTask<object> Invoke(ElementReference dxTarget, string operationName, object @params, object httpMethod)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_ODataContext_invoke_1", dxTarget, operationName, @params, httpMethod);
        }
        public static ValueTask<object> ObjectLink(ElementReference dxTarget, string entityAlias, object key)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_ODataContext_objectLink_2", dxTarget, entityAlias, key);
        }
    }
    public class ODataStoreInterop: StoreInterop
    {
        public static ValueTask<object> Init(ElementReference dxTarget, DevExpress.Data.ODataStoreOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_ODataStore_Init", dxTarget, json);
        }
        public static ValueTask<object> GetBeforeSend(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_ODataStore_GetOption", dxTarget, "beforeSend");
        }
        public static ValueTask<object> SetBeforeSend(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_ODataStore_SetOption", dxTarget, "beforeSend", value);
        }
        public static ValueTask<bool?> GetDeserializeDates(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_ODataStore_GetOption", dxTarget, "deserializeDates");
        }
        public static ValueTask<object> SetDeserializeDates(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_ODataStore_SetOption", dxTarget, "deserializeDates", value);
        }
        public static ValueTask<object> GetFieldTypes(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_ODataStore_GetOption", dxTarget, "fieldTypes");
        }
        public static ValueTask<object> SetFieldTypes(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_ODataStore_SetOption", dxTarget, "fieldTypes", value);
        }
        public static ValueTask<bool?> GetJsonp(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_ODataStore_GetOption", dxTarget, "jsonp");
        }
        public static ValueTask<object> SetJsonp(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_ODataStore_SetOption", dxTarget, "jsonp", value);
        }
        public static ValueTask<object> GetKeyType(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_ODataStore_GetOption", dxTarget, "keyType");
        }
        public static ValueTask<object> SetKeyType(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_ODataStore_SetOption", dxTarget, "keyType", value);
        }
        public static ValueTask<string> GetUrl(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_ODataStore_GetOption", dxTarget, "url");
        }
        public static ValueTask<object> SetUrl(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_ODataStore_SetOption", dxTarget, "url", value);
        }
        public static ValueTask<float?> GetVersion(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_ODataStore_GetOption", dxTarget, "version");
        }
        public static ValueTask<object> SetVersion(ElementReference dxTarget, float? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_ODataStore_SetOption", dxTarget, "version", value);
        }
        public static ValueTask<bool?> GetWithCredentials(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_ODataStore_GetOption", dxTarget, "withCredentials");
        }
        public static ValueTask<object> SetWithCredentials(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_ODataStore_SetOption", dxTarget, "withCredentials", value);
        }
        public static ValueTask<object> ByKey(ElementReference dxTarget, object key)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_ODataStore_byKey_0", dxTarget, key);
        }
        public static ValueTask<object> ByKey(ElementReference dxTarget, object key, object extraOptions)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_ODataStore_byKey_1", dxTarget, key, extraOptions);
        }
        public static ValueTask<object> CreateQuery(ElementReference dxTarget, object loadOptions)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_ODataStore_createQuery_2", dxTarget, loadOptions);
        }
        public static ValueTask<object> Load(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_ODataStore_load_3", dxTarget);
        }
        public static ValueTask<object> Load(ElementReference dxTarget, object options)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_ODataStore_load_4", dxTarget, options);
        }
    }
    public class EdmLiteralInterop
    {
        public static ValueTask<string> ValueOf(ElementReference dxTarget)
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
        public static ValueTask<object> Init(ElementReference dxTarget, DevExpress.Data.PivotGridDataSourceOptions options)
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
        public static ValueTask<object> GetFields(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_PivotGridDataSource_GetOption", dxTarget, "fields");
        }
        public static ValueTask<object> SetFields(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_PivotGridDataSource_SetOption", dxTarget, "fields", value);
        }
        public static ValueTask<object> GetFilter(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_PivotGridDataSource_GetOption", dxTarget, "filter");
        }
        public static ValueTask<object> SetFilter(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_PivotGridDataSource_SetOption", dxTarget, "filter", value);
        }
        public static ValueTask<bool?> GetRemoteOperations(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_PivotGridDataSource_GetOption", dxTarget, "remoteOperations");
        }
        public static ValueTask<object> SetRemoteOperations(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_PivotGridDataSource_SetOption", dxTarget, "remoteOperations", value);
        }
        public static ValueTask<bool?> GetRetrieveFields(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_PivotGridDataSource_GetOption", dxTarget, "retrieveFields");
        }
        public static ValueTask<object> SetRetrieveFields(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_PivotGridDataSource_SetOption", dxTarget, "retrieveFields", value);
        }
        public static ValueTask<object> GetStore(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_PivotGridDataSource_GetOption", dxTarget, "store");
        }
        public static ValueTask<object> SetStore(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_PivotGridDataSource_SetOption", dxTarget, "store", value);
        }
        public static ValueTask<object> CollapseAll(ElementReference dxTarget, object id)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_PivotGridDataSource_collapseAll_0", dxTarget, id);
        }
        public static ValueTask<object> CollapseHeaderItem(ElementReference dxTarget, string area, object path)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_PivotGridDataSource_collapseHeaderItem_1", dxTarget, area, path);
        }
        public static ValueTask<object> CreateDrillDownDataSource(ElementReference dxTarget, object options)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_PivotGridDataSource_createDrillDownDataSource_2", dxTarget, options);
        }
        public static ValueTask<object> Dispose(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_PivotGridDataSource_dispose_3", dxTarget);
        }
        public static ValueTask<object> ExpandAll(ElementReference dxTarget, object id)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_PivotGridDataSource_expandAll_4", dxTarget, id);
        }
        public static ValueTask<object> ExpandHeaderItem(ElementReference dxTarget, string area, object path)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_PivotGridDataSource_expandHeaderItem_5", dxTarget, area, path);
        }
        public static ValueTask<object> Field(ElementReference dxTarget, object id)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_PivotGridDataSource_field_6", dxTarget, id);
        }
        public static ValueTask<object> Field(ElementReference dxTarget, object id, object options)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_PivotGridDataSource_field_7", dxTarget, id, options);
        }
        public static ValueTask<object> Fields(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_PivotGridDataSource_fields_8", dxTarget);
        }
        public static ValueTask<object> Fields(ElementReference dxTarget, object fields)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_PivotGridDataSource_fields_9", dxTarget, fields);
        }
        public static ValueTask<object> Filter(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_PivotGridDataSource_filter_10", dxTarget);
        }
        public static ValueTask<object> Filter(ElementReference dxTarget, object filterExpr)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_PivotGridDataSource_filter_11", dxTarget, filterExpr);
        }
        public static ValueTask<object> GetAreaFields(ElementReference dxTarget, string area, bool collectGroups)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_PivotGridDataSource_getAreaFields_12", dxTarget, area, collectGroups);
        }
        public static ValueTask<object> GetData(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_PivotGridDataSource_getData_13", dxTarget);
        }
        public static ValueTask<bool> IsLoading(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool>("BlazorDevExtreme_PivotGridDataSource_isLoading_14", dxTarget);
        }
        public static ValueTask<object> Load(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_PivotGridDataSource_load_15", dxTarget);
        }
        public static ValueTask<object> Off(ElementReference dxTarget, string eventName)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_PivotGridDataSource_off_16", dxTarget, eventName);
        }
        public static ValueTask<object> Off(ElementReference dxTarget, string eventName, object eventHandler)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_PivotGridDataSource_off_17", dxTarget, eventName, eventHandler);
        }
        public static ValueTask<object> On(ElementReference dxTarget, string eventName, object eventHandler)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_PivotGridDataSource_on_18", dxTarget, eventName, eventHandler);
        }
        public static ValueTask<object> On(ElementReference dxTarget, object events)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_PivotGridDataSource_on_19", dxTarget, events);
        }
        public static ValueTask<object> Reload(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_PivotGridDataSource_reload_20", dxTarget);
        }
        public static ValueTask<object> State(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_PivotGridDataSource_state_21", dxTarget);
        }
        public static ValueTask<object> State(ElementReference dxTarget, object state)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_PivotGridDataSource_state_22", dxTarget, state);
        }
    }
    public class XmlaStoreInterop
    {
        public static ValueTask<object> Init(ElementReference dxTarget, DevExpress.Data.XmlaStoreOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_XmlaStore_Init", dxTarget, json);
        }
        public static ValueTask<object> GetBeforeSend(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_XmlaStore_GetOption", dxTarget, "beforeSend");
        }
        public static ValueTask<object> SetBeforeSend(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_XmlaStore_SetOption", dxTarget, "beforeSend", value);
        }
        public static ValueTask<string> GetCatalog(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_XmlaStore_GetOption", dxTarget, "catalog");
        }
        public static ValueTask<object> SetCatalog(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_XmlaStore_SetOption", dxTarget, "catalog", value);
        }
        public static ValueTask<string> GetCube(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_XmlaStore_GetOption", dxTarget, "cube");
        }
        public static ValueTask<object> SetCube(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_XmlaStore_SetOption", dxTarget, "cube", value);
        }
        public static ValueTask<string> GetUrl(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_XmlaStore_GetOption", dxTarget, "url");
        }
        public static ValueTask<object> SetUrl(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_XmlaStore_SetOption", dxTarget, "url", value);
        }
    }
}
namespace DevExpress.Core
{
    public class EventsMixinInterop
    {
        public static ValueTask<object> Off(ElementReference dxTarget, string eventName)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_EventsMixin_off_0", dxTarget, eventName);
        }
        public static ValueTask<object> Off(ElementReference dxTarget, string eventName, object eventHandler)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_EventsMixin_off_1", dxTarget, eventName, eventHandler);
        }
        public static ValueTask<object> On(ElementReference dxTarget, string eventName, object eventHandler)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_EventsMixin_on_2", dxTarget, eventName, eventHandler);
        }
        public static ValueTask<object> On(ElementReference dxTarget, object events)
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
        public static ValueTask<object> Init(ElementReference dxTarget, DevExpress.Framework.DxCommandOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxCommand_Init", dxTarget, json);
        }
        [JSInvokable("DevExpress.Framework.DxCommandInterop.OnExecute")]
        public static void OnExecute(string identifier)
        {
            Execute?.Invoke(null, new JQueryEventArgs(identifier));
        }
        public static ValueTask<bool?> GetDisabled(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxCommand_GetOption", dxTarget, "disabled");
        }
        public static ValueTask<object> SetDisabled(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxCommand_SetOption", dxTarget, "disabled", value);
        }
        public static ValueTask<string> GetIcon(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxCommand_GetOption", dxTarget, "icon");
        }
        public static ValueTask<object> SetIcon(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxCommand_SetOption", dxTarget, "icon", value);
        }
        public static ValueTask<object> GetIconSrc(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxCommand_GetOption", dxTarget, "iconSrc");
        }
        public static ValueTask<object> SetIconSrc(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxCommand_SetOption", dxTarget, "iconSrc", value);
        }
        public static ValueTask<string> GetId(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxCommand_GetOption", dxTarget, "id");
        }
        public static ValueTask<object> SetId(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxCommand_SetOption", dxTarget, "id", value);
        }
        public static ValueTask<string> GetRenderStage(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxCommand_GetOption", dxTarget, "renderStage");
        }
        public static ValueTask<object> SetRenderStage(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxCommand_SetOption", dxTarget, "renderStage", value);
        }
        public static ValueTask<string> GetTitle(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxCommand_GetOption", dxTarget, "title");
        }
        public static ValueTask<object> SetTitle(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxCommand_SetOption", dxTarget, "title", value);
        }
        public static ValueTask<string> GetType(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxCommand_GetOption", dxTarget, "type");
        }
        public static ValueTask<object> SetType(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxCommand_SetOption", dxTarget, "type", value);
        }
        public static ValueTask<bool?> GetVisible(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxCommand_GetOption", dxTarget, "visible");
        }
        public static ValueTask<object> SetVisible(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxCommand_SetOption", dxTarget, "visible", value);
        }
        public static ValueTask<object> DoExecute(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxCommand_execute_0", dxTarget);
        }
    }
    public class RouterInterop
    {
        public static ValueTask<string> Format(ElementReference dxTarget, object obj)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_Router_format_0", dxTarget, obj);
        }
        public static ValueTask<object> Parse(ElementReference dxTarget, string uri)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Router_parse_1", dxTarget, uri);
        }
        public static ValueTask<object> Register(ElementReference dxTarget, string pattern, object defaults, object constraints)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Router_register_2", dxTarget, pattern, defaults, constraints);
        }
    }
    public class StateManagerInterop
    {
        public static ValueTask<object> Init(ElementReference dxTarget, DevExpress.Framework.StateManagerOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_StateManager_Init", dxTarget, json);
        }
        public static ValueTask<object> GetStorage(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_StateManager_GetOption", dxTarget, "storage");
        }
        public static ValueTask<object> SetStorage(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_StateManager_SetOption", dxTarget, "storage", value);
        }
        public static ValueTask<object> AddStateSource(ElementReference dxTarget, object stateSource)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_StateManager_addStateSource_0", dxTarget, stateSource);
        }
        public static ValueTask<object> ClearState(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_StateManager_clearState_1", dxTarget);
        }
        public static ValueTask<object> RemoveStateSource(ElementReference dxTarget, object stateSource)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_StateManager_removeStateSource_2", dxTarget, stateSource);
        }
        public static ValueTask<object> RestoreState(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_StateManager_restoreState_3", dxTarget);
        }
        public static ValueTask<object> SaveState(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_StateManager_saveState_4", dxTarget);
        }
    }
    public class ViewCacheInterop
    {
        public static ValueTask<object> Clear(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_ViewCache_clear_0", dxTarget);
        }
        public static ValueTask<object> GetView(ElementReference dxTarget, string key)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_ViewCache_getView_1", dxTarget, key);
        }
        public static ValueTask<bool> HasView(ElementReference dxTarget, string key)
        {
            return JSRuntime.Current.InvokeAsync<bool>("BlazorDevExtreme_ViewCache_hasView_2", dxTarget, key);
        }
        public static ValueTask<object> Off(ElementReference dxTarget, string eventName)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_ViewCache_off_3", dxTarget, eventName);
        }
        public static ValueTask<object> Off(ElementReference dxTarget, string eventName, object eventHandler)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_ViewCache_off_4", dxTarget, eventName, eventHandler);
        }
        public static ValueTask<object> On(ElementReference dxTarget, string eventName, object eventHandler)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_ViewCache_on_5", dxTarget, eventName, eventHandler);
        }
        public static ValueTask<object> On(ElementReference dxTarget, object events)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_ViewCache_on_6", dxTarget, events);
        }
        public static ValueTask<object> RemoveView(ElementReference dxTarget, string key)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_ViewCache_removeView_7", dxTarget, key);
        }
        public static ValueTask<object> SetView(ElementReference dxTarget, string key, object viewInfo)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_ViewCache_setView_8", dxTarget, key, viewInfo);
        }
    }
    public class DxCommandContainerInterop
    {
        public static ValueTask<object> Init(ElementReference dxTarget, DevExpress.Framework.DxCommandContainerOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxCommandContainer_Init", dxTarget, json);
        }
        public static ValueTask<string> GetId(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxCommandContainer_GetOption", dxTarget, "id");
        }
        public static ValueTask<object> SetId(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxCommandContainer_SetOption", dxTarget, "id", value);
        }
    }
    public class DxViewInterop
    {
        public static ValueTask<object> Init(ElementReference dxTarget, DevExpress.Framework.DxViewOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxView_Init", dxTarget, json);
        }
        public static ValueTask<bool?> GetDisableCache(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxView_GetOption", dxTarget, "disableCache");
        }
        public static ValueTask<object> SetDisableCache(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxView_SetOption", dxTarget, "disableCache", value);
        }
        public static ValueTask<bool?> GetModal(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxView_GetOption", dxTarget, "modal");
        }
        public static ValueTask<object> SetModal(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxView_SetOption", dxTarget, "modal", value);
        }
        public static ValueTask<string> GetName(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxView_GetOption", dxTarget, "name");
        }
        public static ValueTask<object> SetName(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxView_SetOption", dxTarget, "name", value);
        }
        public static ValueTask<string> GetOrientation(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxView_GetOption", dxTarget, "orientation");
        }
        public static ValueTask<object> SetOrientation(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxView_SetOption", dxTarget, "orientation", value);
        }
        public static ValueTask<string> GetPane(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxView_GetOption", dxTarget, "pane");
        }
        public static ValueTask<object> SetPane(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxView_SetOption", dxTarget, "pane", value);
        }
        public static ValueTask<string> GetTitle(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxView_GetOption", dxTarget, "title");
        }
        public static ValueTask<object> SetTitle(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxView_SetOption", dxTarget, "title", value);
        }
    }
    public class DxLayoutInterop
    {
        public static ValueTask<object> Init(ElementReference dxTarget, DevExpress.Framework.DxLayoutOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxLayout_Init", dxTarget, json);
        }
        public static ValueTask<string> GetName(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxLayout_GetOption", dxTarget, "name");
        }
        public static ValueTask<object> SetName(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxLayout_SetOption", dxTarget, "name", value);
        }
    }
    public class DxViewPlaceholderInterop
    {
        public static ValueTask<object> Init(ElementReference dxTarget, DevExpress.Framework.DxViewPlaceholderOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxViewPlaceholder_Init", dxTarget, json);
        }
        public static ValueTask<string> GetViewName(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxViewPlaceholder_GetOption", dxTarget, "viewName");
        }
        public static ValueTask<object> SetViewName(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxViewPlaceholder_SetOption", dxTarget, "viewName", value);
        }
    }
    public class DxTransitionInterop
    {
        public static ValueTask<object> Init(ElementReference dxTarget, DevExpress.Framework.DxTransitionOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTransition_Init", dxTarget, json);
        }
        public static ValueTask<string> GetAnimation(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxTransition_GetOption", dxTarget, "animation");
        }
        public static ValueTask<object> SetAnimation(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTransition_SetOption", dxTarget, "animation", value);
        }
        public static ValueTask<string> GetName(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxTransition_GetOption", dxTarget, "name");
        }
        public static ValueTask<object> SetName(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTransition_SetOption", dxTarget, "name", value);
        }
        public static ValueTask<string> GetType(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxTransition_GetOption", dxTarget, "type");
        }
        public static ValueTask<object> SetType(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTransition_SetOption", dxTarget, "type", value);
        }
    }
    public class DxContentPlaceholderInterop
    {
        public static ValueTask<object> Init(ElementReference dxTarget, DevExpress.Framework.DxContentPlaceholderOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxContentPlaceholder_Init", dxTarget, json);
        }
        public static ValueTask<string> GetAnimation(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxContentPlaceholder_GetOption", dxTarget, "animation");
        }
        public static ValueTask<object> SetAnimation(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxContentPlaceholder_SetOption", dxTarget, "animation", value);
        }
        public static ValueTask<string> GetContentCssPosition(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxContentPlaceholder_GetOption", dxTarget, "contentCssPosition");
        }
        public static ValueTask<object> SetContentCssPosition(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxContentPlaceholder_SetOption", dxTarget, "contentCssPosition", value);
        }
        public static ValueTask<string> GetName(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxContentPlaceholder_GetOption", dxTarget, "name");
        }
        public static ValueTask<object> SetName(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxContentPlaceholder_SetOption", dxTarget, "name", value);
        }
        public static ValueTask<string> GetTransition(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxContentPlaceholder_GetOption", dxTarget, "transition");
        }
        public static ValueTask<object> SetTransition(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxContentPlaceholder_SetOption", dxTarget, "transition", value);
        }
    }
    public class DxContentInterop
    {
        public static ValueTask<object> Init(ElementReference dxTarget, DevExpress.Framework.DxContentOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxContent_Init", dxTarget, json);
        }
        public static ValueTask<string> GetTargetPlaceholder(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxContent_GetOption", dxTarget, "targetPlaceholder");
        }
        public static ValueTask<object> SetTargetPlaceholder(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxContent_SetOption", dxTarget, "targetPlaceholder", value);
        }
    }
}
namespace DevExpress.Framework.Html
{
    public class HtmlApplicationInterop
    {
        public static ValueTask<object> Init(ElementReference dxTarget, DevExpress.Framework.Html.HtmlApplicationOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_HtmlApplication_Init", dxTarget, json);
        }
        public static ValueTask<object> GetAnimationSet(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_HtmlApplication_GetOption", dxTarget, "animationSet");
        }
        public static ValueTask<object> SetAnimationSet(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_HtmlApplication_SetOption", dxTarget, "animationSet", value);
        }
        public static ValueTask<object> GetCommandMapping(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_HtmlApplication_GetOption", dxTarget, "commandMapping");
        }
        public static ValueTask<object> SetCommandMapping(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_HtmlApplication_SetOption", dxTarget, "commandMapping", value);
        }
        public static ValueTask<bool?> GetDisableViewCache(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_HtmlApplication_GetOption", dxTarget, "disableViewCache");
        }
        public static ValueTask<object> SetDisableViewCache(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_HtmlApplication_SetOption", dxTarget, "disableViewCache", value);
        }
        public static ValueTask<object> GetLayoutSet(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_HtmlApplication_GetOption", dxTarget, "layoutSet");
        }
        public static ValueTask<object> SetLayoutSet(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_HtmlApplication_SetOption", dxTarget, "layoutSet", value);
        }
        public static ValueTask<string> GetMode(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_HtmlApplication_GetOption", dxTarget, "mode");
        }
        public static ValueTask<object> SetMode(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_HtmlApplication_SetOption", dxTarget, "mode", value);
        }
        public static ValueTask<object> GetNamespace(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_HtmlApplication_GetOption", dxTarget, "namespace");
        }
        public static ValueTask<object> SetNamespace(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_HtmlApplication_SetOption", dxTarget, "namespace", value);
        }
        public static ValueTask<string> GetNavigateToRootViewMode(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_HtmlApplication_GetOption", dxTarget, "navigateToRootViewMode");
        }
        public static ValueTask<object> SetNavigateToRootViewMode(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_HtmlApplication_SetOption", dxTarget, "navigateToRootViewMode", value);
        }
        public static ValueTask<object> GetNavigation(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_HtmlApplication_GetOption", dxTarget, "navigation");
        }
        public static ValueTask<object> SetNavigation(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_HtmlApplication_SetOption", dxTarget, "navigation", value);
        }
        public static ValueTask<object> GetRouter(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_HtmlApplication_GetOption", dxTarget, "router");
        }
        public static ValueTask<object> SetRouter(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_HtmlApplication_SetOption", dxTarget, "router", value);
        }
        public static ValueTask<object> GetStateManager(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_HtmlApplication_GetOption", dxTarget, "stateManager");
        }
        public static ValueTask<object> SetStateManager(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_HtmlApplication_SetOption", dxTarget, "stateManager", value);
        }
        public static ValueTask<object> GetStateStorage(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_HtmlApplication_GetOption", dxTarget, "stateStorage");
        }
        public static ValueTask<object> SetStateStorage(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_HtmlApplication_SetOption", dxTarget, "stateStorage", value);
        }
        public static ValueTask<string> GetTemplatesVersion(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_HtmlApplication_GetOption", dxTarget, "templatesVersion");
        }
        public static ValueTask<object> SetTemplatesVersion(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_HtmlApplication_SetOption", dxTarget, "templatesVersion", value);
        }
        public static ValueTask<bool?> GetUseViewTitleAsBackText(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_HtmlApplication_GetOption", dxTarget, "useViewTitleAsBackText");
        }
        public static ValueTask<object> SetUseViewTitleAsBackText(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_HtmlApplication_SetOption", dxTarget, "useViewTitleAsBackText", value);
        }
        public static ValueTask<object> GetViewCache(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_HtmlApplication_GetOption", dxTarget, "viewCache");
        }
        public static ValueTask<object> SetViewCache(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_HtmlApplication_SetOption", dxTarget, "viewCache", value);
        }
        public static ValueTask<float?> GetViewCacheSize(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_HtmlApplication_GetOption", dxTarget, "viewCacheSize");
        }
        public static ValueTask<object> SetViewCacheSize(ElementReference dxTarget, float? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_HtmlApplication_SetOption", dxTarget, "viewCacheSize", value);
        }
        public static ValueTask<object> GetViewPort(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_HtmlApplication_GetOption", dxTarget, "viewPort");
        }
        public static ValueTask<object> SetViewPort(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_HtmlApplication_SetOption", dxTarget, "viewPort", value);
        }
        public static ValueTask<object> Back(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_HtmlApplication_back_0", dxTarget);
        }
        public static ValueTask<bool> CanBack(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool>("BlazorDevExtreme_HtmlApplication_canBack_1", dxTarget);
        }
        public static ValueTask<object> ClearState(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_HtmlApplication_clearState_2", dxTarget);
        }
        public static ValueTask<object> CreateNavigation(ElementReference dxTarget, object navigationConfig)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_HtmlApplication_createNavigation_3", dxTarget, navigationConfig);
        }
        public static ValueTask<object> GetViewTemplate(ElementReference dxTarget, string viewName)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_HtmlApplication_getViewTemplate_4", dxTarget, viewName);
        }
        public static ValueTask<object> GetViewTemplateInfo(ElementReference dxTarget, string viewName)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_HtmlApplication_getViewTemplateInfo_5", dxTarget, viewName);
        }
        public static ValueTask<object> LoadTemplates(ElementReference dxTarget, object source)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_HtmlApplication_loadTemplates_6", dxTarget, source);
        }
        public static ValueTask<object> Navigate(ElementReference dxTarget, object uri)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_HtmlApplication_navigate_7", dxTarget, uri);
        }
        public static ValueTask<object> Navigate(ElementReference dxTarget, object uri, object options)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_HtmlApplication_navigate_8", dxTarget, uri, options);
        }
        public static ValueTask<object> Off(ElementReference dxTarget, string eventName)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_HtmlApplication_off_9", dxTarget, eventName);
        }
        public static ValueTask<object> Off(ElementReference dxTarget, string eventName, object eventHandler)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_HtmlApplication_off_10", dxTarget, eventName, eventHandler);
        }
        public static ValueTask<object> On(ElementReference dxTarget, string eventName, object eventHandler)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_HtmlApplication_on_11", dxTarget, eventName, eventHandler);
        }
        public static ValueTask<object> On(ElementReference dxTarget, object events)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_HtmlApplication_on_12", dxTarget, events);
        }
        public static ValueTask<object> RenderNavigation(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_HtmlApplication_renderNavigation_13", dxTarget);
        }
        public static ValueTask<object> RestoreState(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_HtmlApplication_restoreState_14", dxTarget);
        }
        public static ValueTask<object> SaveState(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_HtmlApplication_saveState_15", dxTarget);
        }
        public static ValueTask<object> TemplateContext(ElementReference dxTarget)
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
        public static ValueTask<object> Init(ElementReference dxTarget, DevExpress.Ui.DxAccordionOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxAccordion_Init", dxTarget, json);
        }
        [JSInvokable("DevExpress.Ui.DxAccordionInterop.OnItemTitleClick")]
        public static void OnItemTitleClick(string identifier)
        {
            ItemTitleClick?.Invoke(null, new JQueryEventArgs(identifier));
        }
        public static ValueTask<float?> GetAnimationDuration(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_DxAccordion_GetOption", dxTarget, "animationDuration");
        }
        public static ValueTask<object> SetAnimationDuration(ElementReference dxTarget, float? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxAccordion_SetOption", dxTarget, "animationDuration", value);
        }
        public static ValueTask<bool?> GetCollapsible(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxAccordion_GetOption", dxTarget, "collapsible");
        }
        public static ValueTask<object> SetCollapsible(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxAccordion_SetOption", dxTarget, "collapsible", value);
        }
        public static ValueTask<bool?> GetDeferRendering(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxAccordion_GetOption", dxTarget, "deferRendering");
        }
        public static ValueTask<object> SetDeferRendering(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxAccordion_SetOption", dxTarget, "deferRendering", value);
        }
        public static ValueTask<object> GetItemTitleTemplate(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxAccordion_GetOption", dxTarget, "itemTitleTemplate");
        }
        public static ValueTask<object> SetItemTitleTemplate(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxAccordion_SetOption", dxTarget, "itemTitleTemplate", value);
        }
        public static ValueTask<bool?> GetMultiple(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxAccordion_GetOption", dxTarget, "multiple");
        }
        public static ValueTask<object> SetMultiple(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxAccordion_SetOption", dxTarget, "multiple", value);
        }
        public static ValueTask<object> CollapseItem(ElementReference dxTarget, float index)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxAccordion_collapseItem_0", dxTarget, index);
        }
        public static ValueTask<object> ExpandItem(ElementReference dxTarget, float index)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxAccordion_expandItem_1", dxTarget, index);
        }
        public static ValueTask<object> UpdateDimensions(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxAccordion_updateDimensions_2", dxTarget);
        }
    }
    public class DxActionSheetInterop: CollectionWidgetInterop
    {
        public static event EventHandler<JQueryEventArgs> CancelClick;
        public static ValueTask<object> Init(ElementReference dxTarget, DevExpress.Ui.DxActionSheetOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxActionSheet_Init", dxTarget, json);
        }
        [JSInvokable("DevExpress.Ui.DxActionSheetInterop.OnCancelClick")]
        public static void OnCancelClick(string identifier)
        {
            CancelClick?.Invoke(null, new JQueryEventArgs(identifier));
        }
        public static ValueTask<string> GetCancelText(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxActionSheet_GetOption", dxTarget, "cancelText");
        }
        public static ValueTask<object> SetCancelText(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxActionSheet_SetOption", dxTarget, "cancelText", value);
        }
        public static ValueTask<bool?> GetShowCancelButton(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxActionSheet_GetOption", dxTarget, "showCancelButton");
        }
        public static ValueTask<object> SetShowCancelButton(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxActionSheet_SetOption", dxTarget, "showCancelButton", value);
        }
        public static ValueTask<bool?> GetShowTitle(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxActionSheet_GetOption", dxTarget, "showTitle");
        }
        public static ValueTask<object> SetShowTitle(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxActionSheet_SetOption", dxTarget, "showTitle", value);
        }
        public static ValueTask<object> GetTarget(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxActionSheet_GetOption", dxTarget, "target");
        }
        public static ValueTask<object> SetTarget(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxActionSheet_SetOption", dxTarget, "target", value);
        }
        public static ValueTask<string> GetTitle(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxActionSheet_GetOption", dxTarget, "title");
        }
        public static ValueTask<object> SetTitle(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxActionSheet_SetOption", dxTarget, "title", value);
        }
        public static ValueTask<bool?> GetUsePopover(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxActionSheet_GetOption", dxTarget, "usePopover");
        }
        public static ValueTask<object> SetUsePopover(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxActionSheet_SetOption", dxTarget, "usePopover", value);
        }
        public static ValueTask<object> Hide(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxActionSheet_hide_0", dxTarget);
        }
        public static ValueTask<object> Show(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxActionSheet_show_1", dxTarget);
        }
        public static ValueTask<object> Toggle(ElementReference dxTarget, bool showing)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxActionSheet_toggle_2", dxTarget, showing);
        }
    }
    public class DxAutocompleteInterop: DxDropDownListInterop
    {
        public static ValueTask<object> Init(ElementReference dxTarget, DevExpress.Ui.DxAutocompleteOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxAutocomplete_Init", dxTarget, json);
        }
        public static ValueTask<float?> GetMaxItemCount(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_DxAutocomplete_GetOption", dxTarget, "maxItemCount");
        }
        public static ValueTask<object> SetMaxItemCount(ElementReference dxTarget, float? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxAutocomplete_SetOption", dxTarget, "maxItemCount", value);
        }
    }
    public class DxBoxInterop: CollectionWidgetInterop
    {
        public static ValueTask<object> Init(ElementReference dxTarget, DevExpress.Ui.DxBoxOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxBox_Init", dxTarget, json);
        }
        public static ValueTask<string> GetAlign(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxBox_GetOption", dxTarget, "align");
        }
        public static ValueTask<object> SetAlign(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxBox_SetOption", dxTarget, "align", value);
        }
        public static ValueTask<string> GetCrossAlign(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxBox_GetOption", dxTarget, "crossAlign");
        }
        public static ValueTask<object> SetCrossAlign(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxBox_SetOption", dxTarget, "crossAlign", value);
        }
        public static ValueTask<string> GetDirection(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxBox_GetOption", dxTarget, "direction");
        }
        public static ValueTask<object> SetDirection(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxBox_SetOption", dxTarget, "direction", value);
        }
    }
    public class DxButtonInterop: WidgetInterop
    {
        public static event EventHandler<JQueryEventArgs> Click;
        public static ValueTask<object> Init(ElementReference dxTarget, DevExpress.Ui.DxButtonOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxButton_Init", dxTarget, json);
        }
        [JSInvokable("DevExpress.Ui.DxButtonInterop.OnClick")]
        public static void OnClick(string identifier)
        {
            Click?.Invoke(null, new JQueryEventArgs(identifier));
        }
        public static ValueTask<string> GetIcon(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxButton_GetOption", dxTarget, "icon");
        }
        public static ValueTask<object> SetIcon(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxButton_SetOption", dxTarget, "icon", value);
        }
        public static ValueTask<object> GetTemplate(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxButton_GetOption", dxTarget, "template");
        }
        public static ValueTask<object> SetTemplate(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxButton_SetOption", dxTarget, "template", value);
        }
        public static ValueTask<string> GetText(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxButton_GetOption", dxTarget, "text");
        }
        public static ValueTask<object> SetText(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxButton_SetOption", dxTarget, "text", value);
        }
        public static ValueTask<string> GetType(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxButton_GetOption", dxTarget, "type");
        }
        public static ValueTask<object> SetType(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxButton_SetOption", dxTarget, "type", value);
        }
        public static ValueTask<bool?> GetUseSubmitBehavior(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxButton_GetOption", dxTarget, "useSubmitBehavior");
        }
        public static ValueTask<object> SetUseSubmitBehavior(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxButton_SetOption", dxTarget, "useSubmitBehavior", value);
        }
        public static ValueTask<string> GetValidationGroup(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxButton_GetOption", dxTarget, "validationGroup");
        }
        public static ValueTask<object> SetValidationGroup(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxButton_SetOption", dxTarget, "validationGroup", value);
        }
    }
    public class DxCalendarInterop: EditorInterop
    {
        public static ValueTask<object> Init(ElementReference dxTarget, DevExpress.Ui.DxCalendarOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxCalendar_Init", dxTarget, json);
        }
        public static ValueTask<object> GetCellTemplate(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxCalendar_GetOption", dxTarget, "cellTemplate");
        }
        public static ValueTask<object> SetCellTemplate(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxCalendar_SetOption", dxTarget, "cellTemplate", value);
        }
        public static ValueTask<string> GetDateSerializationFormat(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxCalendar_GetOption", dxTarget, "dateSerializationFormat");
        }
        public static ValueTask<object> SetDateSerializationFormat(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxCalendar_SetOption", dxTarget, "dateSerializationFormat", value);
        }
        public static ValueTask<object> GetDisabledDates(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxCalendar_GetOption", dxTarget, "disabledDates");
        }
        public static ValueTask<object> SetDisabledDates(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxCalendar_SetOption", dxTarget, "disabledDates", value);
        }
        public static ValueTask<object> GetFirstDayOfWeek(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxCalendar_GetOption", dxTarget, "firstDayOfWeek");
        }
        public static ValueTask<object> SetFirstDayOfWeek(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxCalendar_SetOption", dxTarget, "firstDayOfWeek", value);
        }
        public static ValueTask<object> GetMax(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxCalendar_GetOption", dxTarget, "max");
        }
        public static ValueTask<object> SetMax(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxCalendar_SetOption", dxTarget, "max", value);
        }
        public static ValueTask<string> GetMaxZoomLevel(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxCalendar_GetOption", dxTarget, "maxZoomLevel");
        }
        public static ValueTask<object> SetMaxZoomLevel(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxCalendar_SetOption", dxTarget, "maxZoomLevel", value);
        }
        public static ValueTask<object> GetMin(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxCalendar_GetOption", dxTarget, "min");
        }
        public static ValueTask<object> SetMin(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxCalendar_SetOption", dxTarget, "min", value);
        }
        public static ValueTask<string> GetMinZoomLevel(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxCalendar_GetOption", dxTarget, "minZoomLevel");
        }
        public static ValueTask<object> SetMinZoomLevel(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxCalendar_SetOption", dxTarget, "minZoomLevel", value);
        }
        public static ValueTask<string> GetName(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxCalendar_GetOption", dxTarget, "name");
        }
        public static ValueTask<object> SetName(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxCalendar_SetOption", dxTarget, "name", value);
        }
        public static ValueTask<bool?> GetShowTodayButton(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxCalendar_GetOption", dxTarget, "showTodayButton");
        }
        public static ValueTask<object> SetShowTodayButton(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxCalendar_SetOption", dxTarget, "showTodayButton", value);
        }
        public static ValueTask<string> GetZoomLevel(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxCalendar_GetOption", dxTarget, "zoomLevel");
        }
        public static ValueTask<object> SetZoomLevel(ElementReference dxTarget, string value)
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

        public static ValueTask<object> Init(ElementReference dxTarget, DevExpress.Ui.DxCheckBoxOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxCheckBox_Init", dxTarget, json);
        }
        public static ValueTask<string> GetName(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxCheckBox_GetOption", dxTarget, "name");
        }
        public static ValueTask<object> SetName(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxCheckBox_SetOption", dxTarget, "name", value);
        }
        public static ValueTask<string> GetText(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxCheckBox_GetOption", dxTarget, "text");
        }
        public static ValueTask<object> SetText(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxCheckBox_SetOption", dxTarget, "text", value);
        }
    }
    public class DxColorBoxInterop: DxDropDownEditorInterop
    {
        public static ValueTask<object> Init(ElementReference dxTarget, DevExpress.Ui.DxColorBoxOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxColorBox_Init", dxTarget, json);
        }
        public static ValueTask<string> GetApplyButtonText(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxColorBox_GetOption", dxTarget, "applyButtonText");
        }
        public static ValueTask<object> SetApplyButtonText(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxColorBox_SetOption", dxTarget, "applyButtonText", value);
        }
        public static ValueTask<string> GetCancelButtonText(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxColorBox_GetOption", dxTarget, "cancelButtonText");
        }
        public static ValueTask<object> SetCancelButtonText(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxColorBox_SetOption", dxTarget, "cancelButtonText", value);
        }
        public static ValueTask<bool?> GetEditAlphaChannel(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxColorBox_GetOption", dxTarget, "editAlphaChannel");
        }
        public static ValueTask<object> SetEditAlphaChannel(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxColorBox_SetOption", dxTarget, "editAlphaChannel", value);
        }
        public static ValueTask<object> GetFieldTemplate(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxColorBox_GetOption", dxTarget, "fieldTemplate");
        }
        public static ValueTask<object> SetFieldTemplate(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxColorBox_SetOption", dxTarget, "fieldTemplate", value);
        }
        public static ValueTask<float?> GetKeyStep(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_DxColorBox_GetOption", dxTarget, "keyStep");
        }
        public static ValueTask<object> SetKeyStep(ElementReference dxTarget, float? value)
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
        public static ValueTask<object> Init(ElementReference dxTarget, DevExpress.Ui.DxContextMenuOptions options)
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
        public static ValueTask<object> GetCloseOnOutsideClick(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxContextMenu_GetOption", dxTarget, "closeOnOutsideClick");
        }
        public static ValueTask<object> SetCloseOnOutsideClick(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxContextMenu_SetOption", dxTarget, "closeOnOutsideClick", value);
        }
        public static ValueTask<object> GetPosition(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxContextMenu_GetOption", dxTarget, "position");
        }
        public static ValueTask<object> SetPosition(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxContextMenu_SetOption", dxTarget, "position", value);
        }
        public static ValueTask<object> GetShowEvent(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxContextMenu_GetOption", dxTarget, "showEvent");
        }
        public static ValueTask<object> SetShowEvent(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxContextMenu_SetOption", dxTarget, "showEvent", value);
        }
        public static ValueTask<string> GetSubmenuDirection(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxContextMenu_GetOption", dxTarget, "submenuDirection");
        }
        public static ValueTask<object> SetSubmenuDirection(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxContextMenu_SetOption", dxTarget, "submenuDirection", value);
        }
        public static ValueTask<object> GetTarget(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxContextMenu_GetOption", dxTarget, "target");
        }
        public static ValueTask<object> SetTarget(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxContextMenu_SetOption", dxTarget, "target", value);
        }
        public static ValueTask<object> Hide(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxContextMenu_hide_0", dxTarget);
        }
        public static ValueTask<object> Show(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxContextMenu_show_1", dxTarget);
        }
        public static ValueTask<object> Toggle(ElementReference dxTarget, bool showing)
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
        public static ValueTask<object> Init(ElementReference dxTarget, DevExpress.Ui.GridBaseOptions options)
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
        public static ValueTask<bool?> GetAllowColumnReordering(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_GridBase_GetOption", dxTarget, "allowColumnReordering");
        }
        public static ValueTask<object> SetAllowColumnReordering(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_SetOption", dxTarget, "allowColumnReordering", value);
        }
        public static ValueTask<bool?> GetAllowColumnResizing(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_GridBase_GetOption", dxTarget, "allowColumnResizing");
        }
        public static ValueTask<object> SetAllowColumnResizing(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_SetOption", dxTarget, "allowColumnResizing", value);
        }
        public static ValueTask<bool?> GetCacheEnabled(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_GridBase_GetOption", dxTarget, "cacheEnabled");
        }
        public static ValueTask<object> SetCacheEnabled(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_SetOption", dxTarget, "cacheEnabled", value);
        }
        public static ValueTask<bool?> GetCellHintEnabled(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_GridBase_GetOption", dxTarget, "cellHintEnabled");
        }
        public static ValueTask<object> SetCellHintEnabled(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_SetOption", dxTarget, "cellHintEnabled", value);
        }
        public static ValueTask<bool?> GetColumnAutoWidth(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_GridBase_GetOption", dxTarget, "columnAutoWidth");
        }
        public static ValueTask<object> SetColumnAutoWidth(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_SetOption", dxTarget, "columnAutoWidth", value);
        }
        public static ValueTask<object> GetColumnChooser(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_GetOption", dxTarget, "columnChooser");
        }
        public static ValueTask<object> SetColumnChooser(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_SetOption", dxTarget, "columnChooser", value);
        }
        public static ValueTask<object> GetColumnFixing(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_GetOption", dxTarget, "columnFixing");
        }
        public static ValueTask<object> SetColumnFixing(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_SetOption", dxTarget, "columnFixing", value);
        }
        public static ValueTask<bool?> GetColumnHidingEnabled(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_GridBase_GetOption", dxTarget, "columnHidingEnabled");
        }
        public static ValueTask<object> SetColumnHidingEnabled(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_SetOption", dxTarget, "columnHidingEnabled", value);
        }
        public static ValueTask<float?> GetColumnMinWidth(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_GridBase_GetOption", dxTarget, "columnMinWidth");
        }
        public static ValueTask<object> SetColumnMinWidth(ElementReference dxTarget, float? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_SetOption", dxTarget, "columnMinWidth", value);
        }
        public static ValueTask<string> GetColumnResizingMode(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_GridBase_GetOption", dxTarget, "columnResizingMode");
        }
        public static ValueTask<object> SetColumnResizingMode(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_SetOption", dxTarget, "columnResizingMode", value);
        }
        public static ValueTask<object> GetColumns(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_GetOption", dxTarget, "columns");
        }
        public static ValueTask<object> SetColumns(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_SetOption", dxTarget, "columns", value);
        }
        public static ValueTask<float?> GetColumnWidth(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_GridBase_GetOption", dxTarget, "columnWidth");
        }
        public static ValueTask<object> SetColumnWidth(ElementReference dxTarget, float? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_SetOption", dxTarget, "columnWidth", value);
        }
        public static ValueTask<object> GetDataSource(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_GetOption", dxTarget, "dataSource");
        }
        public static ValueTask<object> SetDataSource(ElementReference dxTarget, object value)
        {
            string jsonValue = SimpleJson.SimpleJson.SerializeObject(value);
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_SetOption", dxTarget, "dataSource", jsonValue);
        }
        public static ValueTask<string> GetDateSerializationFormat(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_GridBase_GetOption", dxTarget, "dateSerializationFormat");
        }
        public static ValueTask<object> SetDateSerializationFormat(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_SetOption", dxTarget, "dateSerializationFormat", value);
        }
        public static ValueTask<object> GetEditing(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_GetOption", dxTarget, "editing");
        }
        public static ValueTask<object> SetEditing(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_SetOption", dxTarget, "editing", value);
        }
        public static ValueTask<bool?> GetErrorRowEnabled(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_GridBase_GetOption", dxTarget, "errorRowEnabled");
        }
        public static ValueTask<object> SetErrorRowEnabled(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_SetOption", dxTarget, "errorRowEnabled", value);
        }
        public static ValueTask<object> GetFilterBuilder(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_GetOption", dxTarget, "filterBuilder");
        }
        public static ValueTask<object> SetFilterBuilder(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_SetOption", dxTarget, "filterBuilder", value);
        }
        public static ValueTask<object> GetFilterBuilderPopup(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_GetOption", dxTarget, "filterBuilderPopup");
        }
        public static ValueTask<object> SetFilterBuilderPopup(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_SetOption", dxTarget, "filterBuilderPopup", value);
        }
        public static ValueTask<object> GetFilterPanel(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_GetOption", dxTarget, "filterPanel");
        }
        public static ValueTask<object> SetFilterPanel(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_SetOption", dxTarget, "filterPanel", value);
        }
        public static ValueTask<object> GetFilterRow(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_GetOption", dxTarget, "filterRow");
        }
        public static ValueTask<object> SetFilterRow(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_SetOption", dxTarget, "filterRow", value);
        }
        public static ValueTask<object> GetFilterSyncEnabled(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_GetOption", dxTarget, "filterSyncEnabled");
        }
        public static ValueTask<object> SetFilterSyncEnabled(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_SetOption", dxTarget, "filterSyncEnabled", value);
        }
        public static ValueTask<object> GetFilterValue(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_GetOption", dxTarget, "filterValue");
        }
        public static ValueTask<object> SetFilterValue(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_SetOption", dxTarget, "filterValue", value);
        }
        public static ValueTask<object> GetHeaderFilter(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_GetOption", dxTarget, "headerFilter");
        }
        public static ValueTask<object> SetHeaderFilter(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_SetOption", dxTarget, "headerFilter", value);
        }
        public static ValueTask<object> GetLoadPanel(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_GetOption", dxTarget, "loadPanel");
        }
        public static ValueTask<object> SetLoadPanel(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_SetOption", dxTarget, "loadPanel", value);
        }
        public static ValueTask<string> GetNoDataText(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_GridBase_GetOption", dxTarget, "noDataText");
        }
        public static ValueTask<object> SetNoDataText(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_SetOption", dxTarget, "noDataText", value);
        }
        public static ValueTask<object> GetPager(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_GetOption", dxTarget, "pager");
        }
        public static ValueTask<object> SetPager(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_SetOption", dxTarget, "pager", value);
        }
        public static ValueTask<object> GetPaging(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_GetOption", dxTarget, "paging");
        }
        public static ValueTask<object> SetPaging(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_SetOption", dxTarget, "paging", value);
        }
        public static ValueTask<bool?> GetRowAlternationEnabled(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_GridBase_GetOption", dxTarget, "rowAlternationEnabled");
        }
        public static ValueTask<object> SetRowAlternationEnabled(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_SetOption", dxTarget, "rowAlternationEnabled", value);
        }
        public static ValueTask<object> GetScrolling(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_GetOption", dxTarget, "scrolling");
        }
        public static ValueTask<object> SetScrolling(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_SetOption", dxTarget, "scrolling", value);
        }
        public static ValueTask<object> GetSearchPanel(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_GetOption", dxTarget, "searchPanel");
        }
        public static ValueTask<object> SetSearchPanel(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_SetOption", dxTarget, "searchPanel", value);
        }
        public static ValueTask<object> GetSelectedRowKeys(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_GetOption", dxTarget, "selectedRowKeys");
        }
        public static ValueTask<object> SetSelectedRowKeys(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_SetOption", dxTarget, "selectedRowKeys", value);
        }
        public static ValueTask<object> GetSelection(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_GetOption", dxTarget, "selection");
        }
        public static ValueTask<object> SetSelection(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_SetOption", dxTarget, "selection", value);
        }
        public static ValueTask<bool?> GetShowBorders(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_GridBase_GetOption", dxTarget, "showBorders");
        }
        public static ValueTask<object> SetShowBorders(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_SetOption", dxTarget, "showBorders", value);
        }
        public static ValueTask<bool?> GetShowColumnHeaders(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_GridBase_GetOption", dxTarget, "showColumnHeaders");
        }
        public static ValueTask<object> SetShowColumnHeaders(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_SetOption", dxTarget, "showColumnHeaders", value);
        }
        public static ValueTask<bool?> GetShowColumnLines(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_GridBase_GetOption", dxTarget, "showColumnLines");
        }
        public static ValueTask<object> SetShowColumnLines(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_SetOption", dxTarget, "showColumnLines", value);
        }
        public static ValueTask<bool?> GetShowRowLines(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_GridBase_GetOption", dxTarget, "showRowLines");
        }
        public static ValueTask<object> SetShowRowLines(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_SetOption", dxTarget, "showRowLines", value);
        }
        public static ValueTask<object> GetSorting(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_GetOption", dxTarget, "sorting");
        }
        public static ValueTask<object> SetSorting(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_SetOption", dxTarget, "sorting", value);
        }
        public static ValueTask<object> GetStateStoring(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_GetOption", dxTarget, "stateStoring");
        }
        public static ValueTask<object> SetStateStoring(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_SetOption", dxTarget, "stateStoring", value);
        }
        public static ValueTask<bool?> GetTwoWayBindingEnabled(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_GridBase_GetOption", dxTarget, "twoWayBindingEnabled");
        }
        public static ValueTask<object> SetTwoWayBindingEnabled(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_SetOption", dxTarget, "twoWayBindingEnabled", value);
        }
        public static ValueTask<bool?> GetWordWrapEnabled(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_GridBase_GetOption", dxTarget, "wordWrapEnabled");
        }
        public static ValueTask<object> SetWordWrapEnabled(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_SetOption", dxTarget, "wordWrapEnabled", value);
        }
        public static ValueTask<object> BeginCustomLoading(ElementReference dxTarget, string messageText)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_beginCustomLoading_0", dxTarget, messageText);
        }
        public static ValueTask<object> ByKey(ElementReference dxTarget, object key)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_byKey_1", dxTarget, key);
        }
        public static ValueTask<object> CancelEditData(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_cancelEditData_2", dxTarget);
        }
        public static ValueTask<object> CellValue(ElementReference dxTarget, float rowIndex, string dataField)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_cellValue_3", dxTarget, rowIndex, dataField);
        }
        public static ValueTask<object> CellValue(ElementReference dxTarget, float rowIndex, string dataField, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_cellValue_4", dxTarget, rowIndex, dataField, value);
        }
        public static ValueTask<object> CellValue(ElementReference dxTarget, float rowIndex, float visibleColumnIndex)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_cellValue_5", dxTarget, rowIndex, visibleColumnIndex);
        }
        public static ValueTask<object> CellValue(ElementReference dxTarget, float rowIndex, float visibleColumnIndex, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_cellValue_6", dxTarget, rowIndex, visibleColumnIndex, value);
        }
        public static ValueTask<object> ClearFilter(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_clearFilter_7", dxTarget);
        }
        public static ValueTask<object> ClearFilter(ElementReference dxTarget, string filterName)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_clearFilter_8", dxTarget, filterName);
        }
        public static ValueTask<object> ClearSelection(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_clearSelection_9", dxTarget);
        }
        public static ValueTask<object> ClearSorting(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_clearSorting_10", dxTarget);
        }
        public static ValueTask<object> CloseEditCell(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_closeEditCell_11", dxTarget);
        }
        public static ValueTask<object> CollapseAdaptiveDetailRow(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_collapseAdaptiveDetailRow_12", dxTarget);
        }
        public static ValueTask<float> ColumnCount(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<float>("BlazorDevExtreme_GridBase_columnCount_13", dxTarget);
        }
        public static ValueTask<object> ColumnOption(ElementReference dxTarget, object id)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_columnOption_14", dxTarget, id);
        }
        public static ValueTask<object> ColumnOption(ElementReference dxTarget, object id, string optionName)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_columnOption_15", dxTarget, id, optionName);
        }
        public static ValueTask<object> ColumnOption(ElementReference dxTarget, object id, string optionName, object optionValue)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_columnOption_16", dxTarget, id, optionName, optionValue);
        }
        public static ValueTask<object> ColumnOption(ElementReference dxTarget, object id, object options)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_columnOption_17", dxTarget, id, options);
        }
        public static ValueTask<object> DeleteColumn(ElementReference dxTarget, object id)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_deleteColumn_18", dxTarget, id);
        }
        public static ValueTask<object> DeleteRow(ElementReference dxTarget, float rowIndex)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_deleteRow_19", dxTarget, rowIndex);
        }
        public static ValueTask<object> DeselectAll(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_deselectAll_20", dxTarget);
        }
        public static ValueTask<object> DeselectRows(ElementReference dxTarget, object keys)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_deselectRows_21", dxTarget, keys);
        }
        public static ValueTask<object> EditCell(ElementReference dxTarget, float rowIndex, string dataField)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_editCell_22", dxTarget, rowIndex, dataField);
        }
        public static ValueTask<object> EditCell(ElementReference dxTarget, float rowIndex, float visibleColumnIndex)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_editCell_23", dxTarget, rowIndex, visibleColumnIndex);
        }
        public static ValueTask<object> EditRow(ElementReference dxTarget, float rowIndex)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_editRow_24", dxTarget, rowIndex);
        }
        public static ValueTask<object> EndCustomLoading(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_endCustomLoading_25", dxTarget);
        }
        public static ValueTask<object> ExpandAdaptiveDetailRow(ElementReference dxTarget, object key)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_expandAdaptiveDetailRow_26", dxTarget, key);
        }
        public static ValueTask<object> Filter(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_filter_27", dxTarget);
        }
        public static ValueTask<object> Filter(ElementReference dxTarget, object filterExpr)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_filter_28", dxTarget, filterExpr);
        }
        public static ValueTask<object> Focus(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_focus_29", dxTarget);
        }
        public static ValueTask<object> Focus(ElementReference dxTarget, object element)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_focus_30", dxTarget, element);
        }
        public static ValueTask<object> GetCellElement(ElementReference dxTarget, float rowIndex, string dataField)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_getCellElement_31", dxTarget, rowIndex, dataField);
        }
        public static ValueTask<object> GetCellElement(ElementReference dxTarget, float rowIndex, float visibleColumnIndex)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_getCellElement_32", dxTarget, rowIndex, visibleColumnIndex);
        }
        public static ValueTask<object> GetCombinedFilter(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_getCombinedFilter_33", dxTarget);
        }
        public static ValueTask<object> GetCombinedFilter(ElementReference dxTarget, bool returnDataField)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_getCombinedFilter_34", dxTarget, returnDataField);
        }
        public static ValueTask<object> GetDataSourceEx(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_getDataSource_35", dxTarget);
        }
        public static ValueTask<object> GetKeyByRowIndex(ElementReference dxTarget, float rowIndex)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_getKeyByRowIndex_36", dxTarget, rowIndex);
        }
        public static ValueTask<object> GetRowElement(ElementReference dxTarget, float rowIndex)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_getRowElement_37", dxTarget, rowIndex);
        }
        public static ValueTask<float> GetRowIndexByKey(ElementReference dxTarget, object key)
        {
            return JSRuntime.Current.InvokeAsync<float>("BlazorDevExtreme_GridBase_getRowIndexByKey_38", dxTarget, key);
        }
        public static ValueTask<object> GetScrollable(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_getScrollable_39", dxTarget);
        }
        public static ValueTask<bool> HasEditData(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool>("BlazorDevExtreme_GridBase_hasEditData_40", dxTarget);
        }
        public static ValueTask<object> HideColumnChooser(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_hideColumnChooser_41", dxTarget);
        }
        public static ValueTask<object> IsAdaptiveDetailRowExpanded(ElementReference dxTarget, object key)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_isAdaptiveDetailRowExpanded_42", dxTarget, key);
        }
        public static ValueTask<bool> IsRowSelected(ElementReference dxTarget, object key)
        {
            return JSRuntime.Current.InvokeAsync<bool>("BlazorDevExtreme_GridBase_isRowSelected_43", dxTarget, key);
        }
        public static ValueTask<object> KeyOf(ElementReference dxTarget, object obj)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_keyOf_44", dxTarget, obj);
        }
        public static ValueTask<float> PageCount(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<float>("BlazorDevExtreme_GridBase_pageCount_45", dxTarget);
        }
        public static ValueTask<float> PageIndex(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<float>("BlazorDevExtreme_GridBase_pageIndex_46", dxTarget);
        }
        public static ValueTask<object> PageIndex(ElementReference dxTarget, float newIndex)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_pageIndex_47", dxTarget, newIndex);
        }
        public static ValueTask<float> PageSize(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<float>("BlazorDevExtreme_GridBase_pageSize_48", dxTarget);
        }
        public static ValueTask<object> PageSize(ElementReference dxTarget, float value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_pageSize_49", dxTarget, value);
        }
        public static ValueTask<object> Refresh(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_refresh_50", dxTarget);
        }
        public static ValueTask<object> RepaintRows(ElementReference dxTarget, object rowIndexes)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_repaintRows_51", dxTarget, rowIndexes);
        }
        public static ValueTask<object> SaveEditData(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_saveEditData_52", dxTarget);
        }
        public static ValueTask<object> SearchByText(ElementReference dxTarget, string text)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_searchByText_53", dxTarget, text);
        }
        public static ValueTask<object> SelectAll(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_selectAll_54", dxTarget);
        }
        public static ValueTask<object> SelectRows(ElementReference dxTarget, object keys, bool preserve)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_selectRows_55", dxTarget, keys, preserve);
        }
        public static ValueTask<object> SelectRowsByIndexes(ElementReference dxTarget, object indexes)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_selectRowsByIndexes_56", dxTarget, indexes);
        }
        public static ValueTask<object> ShowColumnChooser(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_showColumnChooser_57", dxTarget);
        }
        public static ValueTask<object> State(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_state_58", dxTarget);
        }
        public static ValueTask<object> State(ElementReference dxTarget, object state)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_state_59", dxTarget, state);
        }
        public static ValueTask<object> UndeleteRow(ElementReference dxTarget, float rowIndex)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_GridBase_undeleteRow_60", dxTarget, rowIndex);
        }
        public static ValueTask<object> UpdateDimensions(ElementReference dxTarget)
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
        public static ValueTask<object> Init(ElementReference dxTarget, DevExpress.Ui.DxDataGridOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDataGrid_Init", dxTarget, json);
        }

        public new static ValueTask<object> UpdateDimensions(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDataGid_updateDimensions", dxTarget);
        }

        public new static ValueTask<object> SetPaging(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDataGrid_SetOption", dxTarget, "paging", value);
        }
            
        public new static ValueTask<object> SetPager(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDataGrid_SetOption", dxTarget, "pager", value);
        }

        public new static ValueTask<object> SetFilterRow(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDataGrid_SetOption", dxTarget, "filterRow", value);
        }

        public new static ValueTask<object> SetColumns(ElementReference dxTarget, object value)
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
        public static ValueTask<object> GetCustomizeColumns(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDataGrid_GetOption", dxTarget, "customizeColumns");
        }
        public static ValueTask<object> SetCustomizeColumns(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDataGrid_SetOption", dxTarget, "customizeColumns", value);
        }
        public static ValueTask<object> GetCustomizeExportData(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDataGrid_GetOption", dxTarget, "customizeExportData");
        }
        public static ValueTask<object> SetCustomizeExportData(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDataGrid_SetOption", dxTarget, "customizeExportData", value);
        }
        public static ValueTask<object> GetExport(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDataGrid_GetOption", dxTarget, "export");
        }
        public static ValueTask<object> SetExport(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDataGrid_SetOption", dxTarget, "export", value);
        }
        public static ValueTask<object> GetGrouping(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDataGrid_GetOption", dxTarget, "grouping");
        }
        public static ValueTask<object> SetGrouping(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDataGrid_SetOption", dxTarget, "grouping", value);
        }
        public static ValueTask<object> GetGroupPanel(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDataGrid_GetOption", dxTarget, "groupPanel");
        }
        public static ValueTask<object> SetGroupPanel(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDataGrid_SetOption", dxTarget, "groupPanel", value);
        }
        public static ValueTask<object> GetKeyExpr(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDataGrid_GetOption", dxTarget, "keyExpr");
        }
        public static ValueTask<object> SetKeyExpr(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDataGrid_SetOption", dxTarget, "keyExpr", value);
        }
        public static ValueTask<object> GetMasterDetail(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDataGrid_GetOption", dxTarget, "masterDetail");
        }
        public static ValueTask<object> SetMasterDetail(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDataGrid_SetOption", dxTarget, "masterDetail", value);
        }
        public static ValueTask<object> GetRemoteOperations(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDataGrid_GetOption", dxTarget, "remoteOperations");
        }
        public static ValueTask<object> SetRemoteOperations(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDataGrid_SetOption", dxTarget, "remoteOperations", value);
        }
        public static ValueTask<object> GetRowTemplate(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDataGrid_GetOption", dxTarget, "rowTemplate");
        }
        public static ValueTask<object> SetRowTemplate(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDataGrid_SetOption", dxTarget, "rowTemplate", value);
        }
        public static ValueTask<object> GetSelectionFilter(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDataGrid_GetOption", dxTarget, "selectionFilter");
        }
        public static ValueTask<object> SetSelectionFilter(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDataGrid_SetOption", dxTarget, "selectionFilter", value);
        }
        public static ValueTask<object> GetSortByGroupSummaryInfo(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDataGrid_GetOption", dxTarget, "sortByGroupSummaryInfo");
        }
        public static ValueTask<object> SetSortByGroupSummaryInfo(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDataGrid_SetOption", dxTarget, "sortByGroupSummaryInfo", value);
        }
        public static ValueTask<object> GetSummary(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDataGrid_GetOption", dxTarget, "summary");
        }
        public static ValueTask<object> SetSummary(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDataGrid_SetOption", dxTarget, "summary", value);
        }
        public static ValueTask<object> AddColumn(ElementReference dxTarget, object columnOptions)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDataGrid_addColumn_0", dxTarget, columnOptions);
        }
        public static ValueTask<object> AddRow(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDataGrid_addRow_1", dxTarget);
        }
        public static ValueTask<object> ClearGrouping(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDataGrid_clearGrouping_2", dxTarget);
        }
        public static ValueTask<object> CollapseAll(ElementReference dxTarget, float groupIndex)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDataGrid_collapseAll_3", dxTarget, groupIndex);
        }
        public static ValueTask<object> CollapseRow(ElementReference dxTarget, object key)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDataGrid_collapseRow_4", dxTarget, key);
        }
        public static ValueTask<object> ExpandAll(ElementReference dxTarget, float groupIndex)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDataGrid_expandAll_5", dxTarget, groupIndex);
        }
        public static ValueTask<object> ExpandRow(ElementReference dxTarget, object key)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDataGrid_expandRow_6", dxTarget, key);
        }
        public static ValueTask<object> ExportToExcel(ElementReference dxTarget, bool selectionOnly)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDataGrid_exportToExcel_7", dxTarget, selectionOnly);
        }
        public static ValueTask<object> GetSelectedRowKeys(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDataGrid_getSelectedRowKeys_8", dxTarget);
        }
        public static ValueTask<object> GetSelectedRowsData(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDataGrid_getSelectedRowsData_9", dxTarget);
        }
        public static ValueTask<object> GetTotalSummaryValue(ElementReference dxTarget, string summaryItemName)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDataGrid_getTotalSummaryValue_10", dxTarget, summaryItemName);
        }
        public static ValueTask<object> GetVisibleColumns(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDataGrid_getVisibleColumns_11", dxTarget);
        }
        public static ValueTask<object> GetVisibleColumns(ElementReference dxTarget, float headerLevel)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDataGrid_getVisibleColumns_12", dxTarget, headerLevel);
        }
        public static ValueTask<object> GetVisibleRows(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDataGrid_getVisibleRows_13", dxTarget);
        }
        public static ValueTask<object> InsertRow(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDataGrid_insertRow_14", dxTarget);
        }
        public static ValueTask<bool> IsRowExpanded(ElementReference dxTarget, object key)
        {
            return JSRuntime.Current.InvokeAsync<bool>("BlazorDevExtreme_DxDataGrid_isRowExpanded_15", dxTarget, key);
        }
        public static ValueTask<bool> IsRowSelected(ElementReference dxTarget, object data)
        {
            return JSRuntime.Current.InvokeAsync<bool>("BlazorDevExtreme_DxDataGrid_isRowSelected_16", dxTarget, data);
        }
        public static ValueTask<object> RemoveRow(ElementReference dxTarget, float rowIndex)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDataGrid_removeRow_18", dxTarget, rowIndex);
        }
        public static ValueTask<float> TotalCount(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<float>("BlazorDevExtreme_DxDataGrid_totalCount_19", dxTarget);
        }
    }
    public class DxDateBoxInterop: DxDropDownEditorInterop
    {
        public static ValueTask<object> Init(ElementReference dxTarget, DevExpress.Ui.DxDateBoxOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDateBox_Init", dxTarget, json);
        }
        public static ValueTask<bool?> GetAdaptivityEnabled(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxDateBox_GetOption", dxTarget, "adaptivityEnabled");
        }
        public static ValueTask<object> SetAdaptivityEnabled(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDateBox_SetOption", dxTarget, "adaptivityEnabled", value);
        }
        public static ValueTask<string> GetApplyButtonText(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxDateBox_GetOption", dxTarget, "applyButtonText");
        }
        public static ValueTask<object> SetApplyButtonText(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDateBox_SetOption", dxTarget, "applyButtonText", value);
        }
        public static ValueTask<object> GetCalendarOptions(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDateBox_GetOption", dxTarget, "calendarOptions");
        }
        public static ValueTask<object> SetCalendarOptions(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDateBox_SetOption", dxTarget, "calendarOptions", value);
        }
        public static ValueTask<string> GetCancelButtonText(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxDateBox_GetOption", dxTarget, "cancelButtonText");
        }
        public static ValueTask<object> SetCancelButtonText(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDateBox_SetOption", dxTarget, "cancelButtonText", value);
        }
        public static ValueTask<string> GetDateOutOfRangeMessage(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxDateBox_GetOption", dxTarget, "dateOutOfRangeMessage");
        }
        public static ValueTask<object> SetDateOutOfRangeMessage(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDateBox_SetOption", dxTarget, "dateOutOfRangeMessage", value);
        }
        public static ValueTask<string> GetDateSerializationFormat(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxDateBox_GetOption", dxTarget, "dateSerializationFormat");
        }
        public static ValueTask<object> SetDateSerializationFormat(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDateBox_SetOption", dxTarget, "dateSerializationFormat", value);
        }
        public static ValueTask<object> GetDisabledDates(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDateBox_GetOption", dxTarget, "disabledDates");
        }
        public static ValueTask<object> SetDisabledDates(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDateBox_SetOption", dxTarget, "disabledDates", value);
        }
        public static ValueTask<object> GetDisplayFormat(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDateBox_GetOption", dxTarget, "displayFormat");
        }
        public static ValueTask<object> SetDisplayFormat(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDateBox_SetOption", dxTarget, "displayFormat", value);
        }
        public static ValueTask<float?> GetInterval(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_DxDateBox_GetOption", dxTarget, "interval");
        }
        public static ValueTask<object> SetInterval(ElementReference dxTarget, float? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDateBox_SetOption", dxTarget, "interval", value);
        }
        public static ValueTask<string> GetInvalidDateMessage(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxDateBox_GetOption", dxTarget, "invalidDateMessage");
        }
        public static ValueTask<object> SetInvalidDateMessage(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDateBox_SetOption", dxTarget, "invalidDateMessage", value);
        }
        public static ValueTask<object> GetMax(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDateBox_GetOption", dxTarget, "max");
        }
        public static ValueTask<object> SetMax(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDateBox_SetOption", dxTarget, "max", value);
        }
        public static ValueTask<string> GetMaxZoomLevel(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxDateBox_GetOption", dxTarget, "maxZoomLevel");
        }
        public static ValueTask<object> SetMaxZoomLevel(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDateBox_SetOption", dxTarget, "maxZoomLevel", value);
        }
        public static ValueTask<object> GetMin(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDateBox_GetOption", dxTarget, "min");
        }
        public static ValueTask<object> SetMin(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDateBox_SetOption", dxTarget, "min", value);
        }
        public static ValueTask<string> GetMinZoomLevel(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxDateBox_GetOption", dxTarget, "minZoomLevel");
        }
        public static ValueTask<object> SetMinZoomLevel(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDateBox_SetOption", dxTarget, "minZoomLevel", value);
        }
        public static ValueTask<string> GetPickerType(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxDateBox_GetOption", dxTarget, "pickerType");
        }
        public static ValueTask<object> SetPickerType(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDateBox_SetOption", dxTarget, "pickerType", value);
        }
        public static ValueTask<bool?> GetShowAnalogClock(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxDateBox_GetOption", dxTarget, "showAnalogClock");
        }
        public static ValueTask<object> SetShowAnalogClock(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDateBox_SetOption", dxTarget, "showAnalogClock", value);
        }
        public static ValueTask<string> GetType(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxDateBox_GetOption", dxTarget, "type");
        }
        public static ValueTask<object> SetType(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDateBox_SetOption", dxTarget, "type", value);
        }
        public static ValueTask<object> Close(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDateBox_close_0", dxTarget);
        }
        public static ValueTask<object> Open(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDateBox_open_1", dxTarget);
        }
    }
    public class DxDeferRenderingInterop: WidgetInterop
    {
        public static event EventHandler<JQueryEventArgs> Rendered;
        public static event EventHandler<JQueryEventArgs> Shown;
        public static ValueTask<object> Init(ElementReference dxTarget, DevExpress.Ui.DxDeferRenderingOptions options)
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
        public static ValueTask<object> GetAnimation(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDeferRendering_GetOption", dxTarget, "animation");
        }
        public static ValueTask<object> SetAnimation(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDeferRendering_SetOption", dxTarget, "animation", value);
        }
        public static ValueTask<object> GetRenderWhen(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDeferRendering_GetOption", dxTarget, "renderWhen");
        }
        public static ValueTask<object> SetRenderWhen(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDeferRendering_SetOption", dxTarget, "renderWhen", value);
        }
        public static ValueTask<bool?> GetShowLoadIndicator(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxDeferRendering_GetOption", dxTarget, "showLoadIndicator");
        }
        public static ValueTask<object> SetShowLoadIndicator(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDeferRendering_SetOption", dxTarget, "showLoadIndicator", value);
        }
        public static ValueTask<string> GetStaggerItemSelector(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxDeferRendering_GetOption", dxTarget, "staggerItemSelector");
        }
        public static ValueTask<object> SetStaggerItemSelector(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDeferRendering_SetOption", dxTarget, "staggerItemSelector", value);
        }
    }
    public class DxDropDownBoxInterop: DxDropDownEditorInterop
    {
        public static ValueTask<object> Init(ElementReference dxTarget, DevExpress.Ui.DxDropDownBoxOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDropDownBox_Init", dxTarget, json);
        }
        public static ValueTask<object> GetContentTemplate(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDropDownBox_GetOption", dxTarget, "contentTemplate");
        }
        public static ValueTask<object> SetContentTemplate(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDropDownBox_SetOption", dxTarget, "contentTemplate", value);
        }
        public static ValueTask<object> GetDropDownOptions(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDropDownBox_GetOption", dxTarget, "dropDownOptions");
        }
        public static ValueTask<object> SetDropDownOptions(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDropDownBox_SetOption", dxTarget, "dropDownOptions", value);
        }
        public static ValueTask<object> GetFieldTemplate(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDropDownBox_GetOption", dxTarget, "fieldTemplate");
        }
        public static ValueTask<object> SetFieldTemplate(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDropDownBox_SetOption", dxTarget, "fieldTemplate", value);
        }
        public static ValueTask<object> GetDataSource(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDropDownBox_GetOption", dxTarget, "dataSource");
        }
        public static ValueTask<object> SetDataSource(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDropDownBox_SetOption", dxTarget, "dataSource", value);
        }
        public static ValueTask<object> GetDisplayExpr(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDropDownBox_GetOption", dxTarget, "displayExpr");
        }
        public static ValueTask<object> SetDisplayExpr(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDropDownBox_SetOption", dxTarget, "displayExpr", value);
        }
        public static ValueTask<object> GetItems(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDropDownBox_GetOption", dxTarget, "items");
        }
        public static ValueTask<object> SetItems(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDropDownBox_SetOption", dxTarget, "items", value);
        }
        public static ValueTask<object> GetItemTemplate(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDropDownBox_GetOption", dxTarget, "itemTemplate");
        }
        public static ValueTask<object> SetItemTemplate(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDropDownBox_SetOption", dxTarget, "itemTemplate", value);
        }
        public static ValueTask<object> GetValueExpr(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDropDownBox_GetOption", dxTarget, "valueExpr");
        }
        public static ValueTask<object> SetValueExpr(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDropDownBox_SetOption", dxTarget, "valueExpr", value);
        }
        public static ValueTask<object> GetDataSourceEx(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDropDownBox_getDataSource_0", dxTarget);
        }
    }
    public class DxDropDownMenuInterop: WidgetInterop
    {
        public static event EventHandler<JQueryEventArgs> ButtonClick;
        public static event EventHandler<JQueryEventArgs> ItemClick;
        public static ValueTask<object> Init(ElementReference dxTarget, DevExpress.Ui.DxDropDownMenuOptions options)
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
        public static ValueTask<string> GetButtonIcon(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxDropDownMenu_GetOption", dxTarget, "buttonIcon");
        }
        public static ValueTask<object> SetButtonIcon(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDropDownMenu_SetOption", dxTarget, "buttonIcon", value);
        }
        public static ValueTask<string> GetButtonText(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxDropDownMenu_GetOption", dxTarget, "buttonText");
        }
        public static ValueTask<object> SetButtonText(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDropDownMenu_SetOption", dxTarget, "buttonText", value);
        }
        public static ValueTask<object> GetDataSource(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDropDownMenu_GetOption", dxTarget, "dataSource");
        }
        public static ValueTask<object> SetDataSource(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDropDownMenu_SetOption", dxTarget, "dataSource", value);
        }
        public static ValueTask<object> GetItems(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDropDownMenu_GetOption", dxTarget, "items");
        }
        public static ValueTask<object> SetItems(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDropDownMenu_SetOption", dxTarget, "items", value);
        }
        public static ValueTask<object> GetItemTemplate(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDropDownMenu_GetOption", dxTarget, "itemTemplate");
        }
        public static ValueTask<object> SetItemTemplate(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDropDownMenu_SetOption", dxTarget, "itemTemplate", value);
        }
        public static ValueTask<bool?> GetOpened(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxDropDownMenu_GetOption", dxTarget, "opened");
        }
        public static ValueTask<object> SetOpened(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDropDownMenu_SetOption", dxTarget, "opened", value);
        }
        public static ValueTask<object> GetPopupHeight(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDropDownMenu_GetOption", dxTarget, "popupHeight");
        }
        public static ValueTask<object> SetPopupHeight(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDropDownMenu_SetOption", dxTarget, "popupHeight", value);
        }
        public static ValueTask<object> GetPopupWidth(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDropDownMenu_GetOption", dxTarget, "popupWidth");
        }
        public static ValueTask<object> SetPopupWidth(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDropDownMenu_SetOption", dxTarget, "popupWidth", value);
        }
        public static ValueTask<bool?> GetUsePopover(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxDropDownMenu_GetOption", dxTarget, "usePopover");
        }
        public static ValueTask<object> SetUsePopover(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDropDownMenu_SetOption", dxTarget, "usePopover", value);
        }
        public static ValueTask<object> Close(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDropDownMenu_close_0", dxTarget);
        }
        public static ValueTask<object> Open(ElementReference dxTarget)
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
        
        public static ValueTask<object> Init(ElementReference dxTarget, DevExpress.Ui.DxFileUploaderOptions options)
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

        public static ValueTask<string> GetAccept(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxFileUploader_GetOption", dxTarget, "accept");
        }
        public static ValueTask<object> SetAccept(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxFileUploader_SetOption", dxTarget, "accept", value);
        }
        public static ValueTask<bool?> GetAllowCanceling(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxFileUploader_GetOption", dxTarget, "allowCanceling");
        }
        public static ValueTask<object> SetAllowCanceling(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxFileUploader_SetOption", dxTarget, "allowCanceling", value);
        }
        public static ValueTask<string> GetLabelText(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxFileUploader_GetOption", dxTarget, "labelText");
        }
        public static ValueTask<object> SetLabelText(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxFileUploader_SetOption", dxTarget, "labelText", value);
        }
        public static ValueTask<bool?> GetMultiple(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxFileUploader_GetOption", dxTarget, "multiple");
        }
        public static ValueTask<object> SetMultiple(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxFileUploader_SetOption", dxTarget, "multiple", value);
        }
        public static ValueTask<string> GetName(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxFileUploader_GetOption", dxTarget, "name");
        }
        public static ValueTask<object> SetName(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxFileUploader_SetOption", dxTarget, "name", value);
        }
        public static ValueTask<float?> GetProgress(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_DxFileUploader_GetOption", dxTarget, "progress");
        }
        public static ValueTask<object> SetProgress(ElementReference dxTarget, float? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxFileUploader_SetOption", dxTarget, "progress", value);
        }
        public static ValueTask<string> GetReadyToUploadMessage(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxFileUploader_GetOption", dxTarget, "readyToUploadMessage");
        }
        public static ValueTask<object> SetReadyToUploadMessage(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxFileUploader_SetOption", dxTarget, "readyToUploadMessage", value);
        }
        public static ValueTask<string> GetSelectButtonText(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxFileUploader_GetOption", dxTarget, "selectButtonText");
        }
        public static ValueTask<object> SetSelectButtonText(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxFileUploader_SetOption", dxTarget, "selectButtonText", value);
        }
        public static ValueTask<bool?> GetShowFileList(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxFileUploader_GetOption", dxTarget, "showFileList");
        }
        public static ValueTask<object> SetShowFileList(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxFileUploader_SetOption", dxTarget, "showFileList", value);
        }
        public static ValueTask<string> GetUploadButtonText(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxFileUploader_GetOption", dxTarget, "uploadButtonText");
        }
        public static ValueTask<object> SetUploadButtonText(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxFileUploader_SetOption", dxTarget, "uploadButtonText", value);
        }
        public static ValueTask<string> GetUploadedMessage(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxFileUploader_GetOption", dxTarget, "uploadedMessage");
        }
        public static ValueTask<object> SetUploadedMessage(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxFileUploader_SetOption", dxTarget, "uploadedMessage", value);
        }
        public static ValueTask<string> GetUploadFailedMessage(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxFileUploader_GetOption", dxTarget, "uploadFailedMessage");
        }
        public static ValueTask<object> SetUploadFailedMessage(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxFileUploader_SetOption", dxTarget, "uploadFailedMessage", value);
        }
        public static ValueTask<object> GetUploadHeaders(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxFileUploader_GetOption", dxTarget, "uploadHeaders");
        }
        public static ValueTask<object> SetUploadHeaders(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxFileUploader_SetOption", dxTarget, "uploadHeaders", value);
        }
        public static ValueTask<string> GetUploadMethod(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxFileUploader_GetOption", dxTarget, "uploadMethod");
        }
        public static ValueTask<object> SetUploadMethod(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxFileUploader_SetOption", dxTarget, "uploadMethod", value);
        }
        public static ValueTask<string> GetUploadMode(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxFileUploader_GetOption", dxTarget, "uploadMode");
        }
        public static ValueTask<object> SetUploadMode(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxFileUploader_SetOption", dxTarget, "uploadMode", value);
        }
        public static ValueTask<string> GetUploadUrl(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxFileUploader_GetOption", dxTarget, "uploadUrl");
        }
        public static ValueTask<object> SetUploadUrl(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxFileUploader_SetOption", dxTarget, "uploadUrl", value);
        }
    }
    public class DxFilterBuilderInterop: WidgetInterop
    {
        public static event EventHandler<JQueryEventArgs> EditorPrepared;
        public static event EventHandler<JQueryEventArgs> EditorPreparing;
        public static event EventHandler<JQueryEventArgs> ValueChanged;
        public static ValueTask<object> Init(ElementReference dxTarget, DevExpress.Ui.DxFilterBuilderOptions options)
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
        public static ValueTask<bool?> GetAllowHierarchicalFields(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxFilterBuilder_GetOption", dxTarget, "allowHierarchicalFields");
        }
        public static ValueTask<object> SetAllowHierarchicalFields(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxFilterBuilder_SetOption", dxTarget, "allowHierarchicalFields", value);
        }
        public static ValueTask<object> GetCustomOperations(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxFilterBuilder_GetOption", dxTarget, "customOperations");
        }
        public static ValueTask<object> SetCustomOperations(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxFilterBuilder_SetOption", dxTarget, "customOperations", value);
        }
        public static ValueTask<object> GetFields(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxFilterBuilder_GetOption", dxTarget, "fields");
        }
        public static ValueTask<object> SetFields(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxFilterBuilder_SetOption", dxTarget, "fields", value);
        }
        public static ValueTask<object> GetFilterOperationDescriptions(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxFilterBuilder_GetOption", dxTarget, "filterOperationDescriptions");
        }
        public static ValueTask<object> SetFilterOperationDescriptions(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxFilterBuilder_SetOption", dxTarget, "filterOperationDescriptions", value);
        }
        public static ValueTask<object> GetGroupOperationDescriptions(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxFilterBuilder_GetOption", dxTarget, "groupOperationDescriptions");
        }
        public static ValueTask<object> SetGroupOperationDescriptions(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxFilterBuilder_SetOption", dxTarget, "groupOperationDescriptions", value);
        }
        public static ValueTask<object> GetValue(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxFilterBuilder_GetOption", dxTarget, "value");
        }
        public static ValueTask<object> SetValue(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxFilterBuilder_SetOption", dxTarget, "value", value);
        }
        public static ValueTask<object> GetFilterExpression(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxFilterBuilder_getFilterExpression_0", dxTarget);
        }
    }
    public class DxFormInterop: WidgetInterop
    {
        public static event EventHandler<JQueryEventArgs> EditorEnterKey;
        public static event EventHandler<JQueryEventArgs> FieldDataChanged;
        public static ValueTask<object> Init(ElementReference dxTarget, DevExpress.Ui.DxFormOptions options)
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
        public static ValueTask<bool?> GetAlignItemLabels(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxForm_GetOption", dxTarget, "alignItemLabels");
        }
        public static ValueTask<object> SetAlignItemLabels(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxForm_SetOption", dxTarget, "alignItemLabels", value);
        }
        public static ValueTask<bool?> GetAlignItemLabelsInAllGroups(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxForm_GetOption", dxTarget, "alignItemLabelsInAllGroups");
        }
        public static ValueTask<object> SetAlignItemLabelsInAllGroups(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxForm_SetOption", dxTarget, "alignItemLabelsInAllGroups", value);
        }
        public static ValueTask<object> GetColCount(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxForm_GetOption", dxTarget, "colCount");
        }
        public static ValueTask<object> SetColCount(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxForm_SetOption", dxTarget, "colCount", value);
        }
        public static ValueTask<object> GetColCountByScreen(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxForm_GetOption", dxTarget, "colCountByScreen");
        }
        public static ValueTask<object> SetColCountByScreen(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxForm_SetOption", dxTarget, "colCountByScreen", value);
        }
        public static ValueTask<object> GetCustomizeItem(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxForm_GetOption", dxTarget, "customizeItem");
        }
        public static ValueTask<object> SetCustomizeItem(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxForm_SetOption", dxTarget, "customizeItem", value);
        }
        public static ValueTask<object> GetFormData(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxForm_GetOption", dxTarget, "formData");
        }
        public static ValueTask<object> SetFormData(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxForm_SetOption", dxTarget, "formData", value);
        }
        public static ValueTask<object> GetItems(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxForm_GetOption", dxTarget, "items");
        }
        public static ValueTask<object> SetItems(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxForm_SetOption", dxTarget, "items", value);
        }
        public static ValueTask<string> GetLabelLocation(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxForm_GetOption", dxTarget, "labelLocation");
        }
        public static ValueTask<object> SetLabelLocation(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxForm_SetOption", dxTarget, "labelLocation", value);
        }
        public static ValueTask<float?> GetMinColWidth(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_DxForm_GetOption", dxTarget, "minColWidth");
        }
        public static ValueTask<object> SetMinColWidth(ElementReference dxTarget, float? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxForm_SetOption", dxTarget, "minColWidth", value);
        }
        public static ValueTask<string> GetOptionalMark(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxForm_GetOption", dxTarget, "optionalMark");
        }
        public static ValueTask<object> SetOptionalMark(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxForm_SetOption", dxTarget, "optionalMark", value);
        }
        public static ValueTask<bool?> GetReadOnly(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxForm_GetOption", dxTarget, "readOnly");
        }
        public static ValueTask<object> SetReadOnly(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxForm_SetOption", dxTarget, "readOnly", value);
        }
        public static ValueTask<string> GetRequiredMark(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxForm_GetOption", dxTarget, "requiredMark");
        }
        public static ValueTask<object> SetRequiredMark(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxForm_SetOption", dxTarget, "requiredMark", value);
        }
        public static ValueTask<string> GetRequiredMessage(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxForm_GetOption", dxTarget, "requiredMessage");
        }
        public static ValueTask<object> SetRequiredMessage(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxForm_SetOption", dxTarget, "requiredMessage", value);
        }
        public static ValueTask<object> GetScreenByWidth(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxForm_GetOption", dxTarget, "screenByWidth");
        }
        public static ValueTask<object> SetScreenByWidth(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxForm_SetOption", dxTarget, "screenByWidth", value);
        }
        public static ValueTask<bool?> GetScrollingEnabled(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxForm_GetOption", dxTarget, "scrollingEnabled");
        }
        public static ValueTask<object> SetScrollingEnabled(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxForm_SetOption", dxTarget, "scrollingEnabled", value);
        }
        public static ValueTask<bool?> GetShowColonAfterLabel(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxForm_GetOption", dxTarget, "showColonAfterLabel");
        }
        public static ValueTask<object> SetShowColonAfterLabel(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxForm_SetOption", dxTarget, "showColonAfterLabel", value);
        }
        public static ValueTask<bool?> GetShowOptionalMark(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxForm_GetOption", dxTarget, "showOptionalMark");
        }
        public static ValueTask<object> SetShowOptionalMark(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxForm_SetOption", dxTarget, "showOptionalMark", value);
        }
        public static ValueTask<bool?> GetShowRequiredMark(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxForm_GetOption", dxTarget, "showRequiredMark");
        }
        public static ValueTask<object> SetShowRequiredMark(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxForm_SetOption", dxTarget, "showRequiredMark", value);
        }
        public static ValueTask<bool?> GetShowValidationSummary(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxForm_GetOption", dxTarget, "showValidationSummary");
        }
        public static ValueTask<object> SetShowValidationSummary(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxForm_SetOption", dxTarget, "showValidationSummary", value);
        }
        public static ValueTask<string> GetValidationGroup(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxForm_GetOption", dxTarget, "validationGroup");
        }
        public static ValueTask<object> SetValidationGroup(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxForm_SetOption", dxTarget, "validationGroup", value);
        }
        public static ValueTask<object> GetEditor(ElementReference dxTarget, string dataField)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxForm_getEditor_0", dxTarget, dataField);
        }
        public static ValueTask<object> ItemOption(ElementReference dxTarget, string id)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxForm_itemOption_1", dxTarget, id);
        }
        public static ValueTask<object> ItemOption(ElementReference dxTarget, string id, string option, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxForm_itemOption_2", dxTarget, id, option, value);
        }
        public static ValueTask<object> ItemOption(ElementReference dxTarget, string id, object options)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxForm_itemOption_3", dxTarget, id, options);
        }
        public static ValueTask<object> ResetValues(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxForm_resetValues_4", dxTarget);
        }
        public static ValueTask<object> UpdateData(ElementReference dxTarget, object data)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxForm_updateData_5", dxTarget, data);
        }
        public static ValueTask<object> UpdateData(ElementReference dxTarget, string dataField, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxForm_updateData_6", dxTarget, dataField, value);
        }
        public static ValueTask<object> UpdateDimensions(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxForm_updateDimensions_7", dxTarget);
        }
        public static ValueTask<object> Validate(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxForm_validate_8", dxTarget);
        }
    }
    public class DxGalleryInterop: CollectionWidgetInterop
    {
        public static ValueTask<object> Init(ElementReference dxTarget, DevExpress.Ui.DxGalleryOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxGallery_Init", dxTarget, json);
        }
        public static ValueTask<float?> GetAnimationDuration(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_DxGallery_GetOption", dxTarget, "animationDuration");
        }
        public static ValueTask<object> SetAnimationDuration(ElementReference dxTarget, float? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxGallery_SetOption", dxTarget, "animationDuration", value);
        }
        public static ValueTask<bool?> GetAnimationEnabled(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxGallery_GetOption", dxTarget, "animationEnabled");
        }
        public static ValueTask<object> SetAnimationEnabled(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxGallery_SetOption", dxTarget, "animationEnabled", value);
        }
        public static ValueTask<bool?> GetIndicatorEnabled(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxGallery_GetOption", dxTarget, "indicatorEnabled");
        }
        public static ValueTask<object> SetIndicatorEnabled(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxGallery_SetOption", dxTarget, "indicatorEnabled", value);
        }
        public static ValueTask<float?> GetInitialItemWidth(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_DxGallery_GetOption", dxTarget, "initialItemWidth");
        }
        public static ValueTask<object> SetInitialItemWidth(ElementReference dxTarget, float? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxGallery_SetOption", dxTarget, "initialItemWidth", value);
        }
        public static ValueTask<bool?> GetLoop(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxGallery_GetOption", dxTarget, "loop");
        }
        public static ValueTask<object> SetLoop(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxGallery_SetOption", dxTarget, "loop", value);
        }
        public static ValueTask<bool?> GetShowIndicator(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxGallery_GetOption", dxTarget, "showIndicator");
        }
        public static ValueTask<object> SetShowIndicator(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxGallery_SetOption", dxTarget, "showIndicator", value);
        }
        public static ValueTask<bool?> GetShowNavButtons(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxGallery_GetOption", dxTarget, "showNavButtons");
        }
        public static ValueTask<object> SetShowNavButtons(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxGallery_SetOption", dxTarget, "showNavButtons", value);
        }
        public static ValueTask<float?> GetSlideshowDelay(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_DxGallery_GetOption", dxTarget, "slideshowDelay");
        }
        public static ValueTask<object> SetSlideshowDelay(ElementReference dxTarget, float? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxGallery_SetOption", dxTarget, "slideshowDelay", value);
        }
        public static ValueTask<bool?> GetStretchImages(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxGallery_GetOption", dxTarget, "stretchImages");
        }
        public static ValueTask<object> SetStretchImages(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxGallery_SetOption", dxTarget, "stretchImages", value);
        }
        public static ValueTask<bool?> GetSwipeEnabled(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxGallery_GetOption", dxTarget, "swipeEnabled");
        }
        public static ValueTask<object> SetSwipeEnabled(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxGallery_SetOption", dxTarget, "swipeEnabled", value);
        }
        public static ValueTask<bool?> GetWrapAround(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxGallery_GetOption", dxTarget, "wrapAround");
        }
        public static ValueTask<object> SetWrapAround(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxGallery_SetOption", dxTarget, "wrapAround", value);
        }
        public static ValueTask<object> GoToItem(ElementReference dxTarget, float itemIndex, bool animation)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxGallery_goToItem_0", dxTarget, itemIndex, animation);
        }
        public static ValueTask<object> NextItem(ElementReference dxTarget, bool animation)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxGallery_nextItem_1", dxTarget, animation);
        }
        public static ValueTask<object> PrevItem(ElementReference dxTarget, bool animation)
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
        public static ValueTask<object> Init(ElementReference dxTarget, DevExpress.Ui.DxListOptions options)
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
        public static ValueTask<bool?> GetAllowItemDeleting(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxList_GetOption", dxTarget, "allowItemDeleting");
        }
        public static ValueTask<object> SetAllowItemDeleting(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxList_SetOption", dxTarget, "allowItemDeleting", value);
        }
        public static ValueTask<bool?> GetAllowItemReordering(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxList_GetOption", dxTarget, "allowItemReordering");
        }
        public static ValueTask<object> SetAllowItemReordering(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxList_SetOption", dxTarget, "allowItemReordering", value);
        }
        public static ValueTask<bool?> GetBounceEnabled(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxList_GetOption", dxTarget, "bounceEnabled");
        }
        public static ValueTask<object> SetBounceEnabled(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxList_SetOption", dxTarget, "bounceEnabled", value);
        }
        public static ValueTask<bool?> GetCollapsibleGroups(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxList_GetOption", dxTarget, "collapsibleGroups");
        }
        public static ValueTask<object> SetCollapsibleGroups(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxList_SetOption", dxTarget, "collapsibleGroups", value);
        }
        public static ValueTask<bool?> GetGrouped(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxList_GetOption", dxTarget, "grouped");
        }
        public static ValueTask<object> SetGrouped(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxList_SetOption", dxTarget, "grouped", value);
        }
        public static ValueTask<object> GetGroupTemplate(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxList_GetOption", dxTarget, "groupTemplate");
        }
        public static ValueTask<object> SetGroupTemplate(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxList_SetOption", dxTarget, "groupTemplate", value);
        }
        public static ValueTask<bool?> GetIndicateLoading(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxList_GetOption", dxTarget, "indicateLoading");
        }
        public static ValueTask<object> SetIndicateLoading(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxList_SetOption", dxTarget, "indicateLoading", value);
        }
        public static ValueTask<string> GetItemDeleteMode(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxList_GetOption", dxTarget, "itemDeleteMode");
        }
        public static ValueTask<object> SetItemDeleteMode(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxList_SetOption", dxTarget, "itemDeleteMode", value);
        }
        public static ValueTask<object> GetMenuItems(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxList_GetOption", dxTarget, "menuItems");
        }
        public static ValueTask<object> SetMenuItems(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxList_SetOption", dxTarget, "menuItems", value);
        }
        public static ValueTask<string> GetMenuMode(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxList_GetOption", dxTarget, "menuMode");
        }
        public static ValueTask<object> SetMenuMode(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxList_SetOption", dxTarget, "menuMode", value);
        }
        public static ValueTask<string> GetNextButtonText(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxList_GetOption", dxTarget, "nextButtonText");
        }
        public static ValueTask<object> SetNextButtonText(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxList_SetOption", dxTarget, "nextButtonText", value);
        }
        public static ValueTask<string> GetPageLoadingText(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxList_GetOption", dxTarget, "pageLoadingText");
        }
        public static ValueTask<object> SetPageLoadingText(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxList_SetOption", dxTarget, "pageLoadingText", value);
        }
        public static ValueTask<string> GetPageLoadMode(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxList_GetOption", dxTarget, "pageLoadMode");
        }
        public static ValueTask<object> SetPageLoadMode(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxList_SetOption", dxTarget, "pageLoadMode", value);
        }
        public static ValueTask<string> GetPulledDownText(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxList_GetOption", dxTarget, "pulledDownText");
        }
        public static ValueTask<object> SetPulledDownText(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxList_SetOption", dxTarget, "pulledDownText", value);
        }
        public static ValueTask<string> GetPullingDownText(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxList_GetOption", dxTarget, "pullingDownText");
        }
        public static ValueTask<object> SetPullingDownText(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxList_SetOption", dxTarget, "pullingDownText", value);
        }
        public static ValueTask<bool?> GetPullRefreshEnabled(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxList_GetOption", dxTarget, "pullRefreshEnabled");
        }
        public static ValueTask<object> SetPullRefreshEnabled(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxList_SetOption", dxTarget, "pullRefreshEnabled", value);
        }
        public static ValueTask<string> GetRefreshingText(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxList_GetOption", dxTarget, "refreshingText");
        }
        public static ValueTask<object> SetRefreshingText(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxList_SetOption", dxTarget, "refreshingText", value);
        }
        public static ValueTask<bool?> GetScrollByContent(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxList_GetOption", dxTarget, "scrollByContent");
        }
        public static ValueTask<object> SetScrollByContent(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxList_SetOption", dxTarget, "scrollByContent", value);
        }
        public static ValueTask<bool?> GetScrollByThumb(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxList_GetOption", dxTarget, "scrollByThumb");
        }
        public static ValueTask<object> SetScrollByThumb(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxList_SetOption", dxTarget, "scrollByThumb", value);
        }
        public static ValueTask<bool?> GetScrollingEnabled(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxList_GetOption", dxTarget, "scrollingEnabled");
        }
        public static ValueTask<object> SetScrollingEnabled(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxList_SetOption", dxTarget, "scrollingEnabled", value);
        }
        public static ValueTask<string> GetSelectAllMode(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxList_GetOption", dxTarget, "selectAllMode");
        }
        public static ValueTask<object> SetSelectAllMode(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxList_SetOption", dxTarget, "selectAllMode", value);
        }
        public static ValueTask<string> GetSelectionMode(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxList_GetOption", dxTarget, "selectionMode");
        }
        public static ValueTask<object> SetSelectionMode(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxList_SetOption", dxTarget, "selectionMode", value);
        }
        public static ValueTask<string> GetShowScrollbar(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxList_GetOption", dxTarget, "showScrollbar");
        }
        public static ValueTask<object> SetShowScrollbar(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxList_SetOption", dxTarget, "showScrollbar", value);
        }
        public static ValueTask<bool?> GetShowSelectionControls(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxList_GetOption", dxTarget, "showSelectionControls");
        }
        public static ValueTask<object> SetShowSelectionControls(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxList_SetOption", dxTarget, "showSelectionControls", value);
        }
        public static ValueTask<bool?> GetUseNativeScrolling(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxList_GetOption", dxTarget, "useNativeScrolling");
        }
        public static ValueTask<object> SetUseNativeScrolling(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxList_SetOption", dxTarget, "useNativeScrolling", value);
        }
        public static ValueTask<object> GetSearchEditorOptions(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxList_GetOption", dxTarget, "searchEditorOptions");
        }
        public static ValueTask<object> SetSearchEditorOptions(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxList_SetOption", dxTarget, "searchEditorOptions", value);
        }
        public static ValueTask<bool?> GetSearchEnabled(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxList_GetOption", dxTarget, "searchEnabled");
        }
        public static ValueTask<object> SetSearchEnabled(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxList_SetOption", dxTarget, "searchEnabled", value);
        }
        public static ValueTask<object> GetSearchExpr(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxList_GetOption", dxTarget, "searchExpr");
        }
        public static ValueTask<object> SetSearchExpr(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxList_SetOption", dxTarget, "searchExpr", value);
        }
        public static ValueTask<string> GetSearchMode(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxList_GetOption", dxTarget, "searchMode");
        }
        public static ValueTask<object> SetSearchMode(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxList_SetOption", dxTarget, "searchMode", value);
        }
        public static ValueTask<float?> GetSearchTimeout(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_DxList_GetOption", dxTarget, "searchTimeout");
        }
        public static ValueTask<object> SetSearchTimeout(ElementReference dxTarget, float? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxList_SetOption", dxTarget, "searchTimeout", value);
        }
        public static ValueTask<string> GetSearchValue(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxList_GetOption", dxTarget, "searchValue");
        }
        public static ValueTask<object> SetSearchValue(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxList_SetOption", dxTarget, "searchValue", value);
        }
        public static ValueTask<float> ClientHeight(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<float>("BlazorDevExtreme_DxList_clientHeight_0", dxTarget);
        }
        public static ValueTask<object> CollapseGroup(ElementReference dxTarget, float groupIndex)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxList_collapseGroup_1", dxTarget, groupIndex);
        }
        public static ValueTask<object> DeleteItem(ElementReference dxTarget, object itemElement)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxList_deleteItem_2", dxTarget, itemElement);
        }
        public static ValueTask<object> ExpandGroup(ElementReference dxTarget, float groupIndex)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxList_expandGroup_4", dxTarget, groupIndex);
        }
        public static ValueTask<bool> IsItemSelected(ElementReference dxTarget, object itemElement)
        {
            return JSRuntime.Current.InvokeAsync<bool>("BlazorDevExtreme_DxList_isItemSelected_5", dxTarget, itemElement);
        }
        public static ValueTask<object> Reload(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxList_reload_7", dxTarget);
        }
        public static ValueTask<object> ReorderItem(ElementReference dxTarget, object itemElement, object toItemElement)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxList_reorderItem_8", dxTarget, itemElement, toItemElement);
        }
        public static ValueTask<object> ScrollBy(ElementReference dxTarget, float distance)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxList_scrollBy_10", dxTarget, distance);
        }
        public static ValueTask<float> ScrollHeight(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<float>("BlazorDevExtreme_DxList_scrollHeight_11", dxTarget);
        }
        public static ValueTask<object> ScrollTo(ElementReference dxTarget, float location)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxList_scrollTo_12", dxTarget, location);
        }
        public static ValueTask<object> ScrollToItem(ElementReference dxTarget, object itemElement)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxList_scrollToItem_13", dxTarget, itemElement);
        }
        public static ValueTask<float> ScrollTop(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<float>("BlazorDevExtreme_DxList_scrollTop_15", dxTarget);
        }
        public static ValueTask<object> SelectAll(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxList_selectAll_16", dxTarget);
        }
        public static ValueTask<object> SelectItem(ElementReference dxTarget, object itemElement)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxList_selectItem_17", dxTarget, itemElement);
        }
        public static ValueTask<object> UnselectAll(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxList_unselectAll_19", dxTarget);
        }
        public static ValueTask<object> UnselectItem(ElementReference dxTarget, object itemElement)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxList_unselectItem_20", dxTarget, itemElement);
        }
        public static ValueTask<object> UpdateDimensions(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxList_updateDimensions_22", dxTarget);
        }
    }
    public class DxLoadIndicatorInterop: WidgetInterop
    {
        public static ValueTask<object> Init(ElementReference dxTarget, DevExpress.Ui.DxLoadIndicatorOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxLoadIndicator_Init", dxTarget, json);
        }
        public static ValueTask<string> GetIndicatorSrc(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxLoadIndicator_GetOption", dxTarget, "indicatorSrc");
        }
        public static ValueTask<object> SetIndicatorSrc(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxLoadIndicator_SetOption", dxTarget, "indicatorSrc", value);
        }
    }
    public class DxLoadPanelInterop: DxOverlayInterop
    {
        public static ValueTask<object> Init(ElementReference dxTarget, DevExpress.Ui.DxLoadPanelOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxLoadPanel_Init", dxTarget, json);
        }
        public static ValueTask<float?> GetDelay(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_DxLoadPanel_GetOption", dxTarget, "delay");
        }
        public static ValueTask<object> SetDelay(ElementReference dxTarget, float? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxLoadPanel_SetOption", dxTarget, "delay", value);
        }
        public static ValueTask<string> GetIndicatorSrc(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxLoadPanel_GetOption", dxTarget, "indicatorSrc");
        }
        public static ValueTask<object> SetIndicatorSrc(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxLoadPanel_SetOption", dxTarget, "indicatorSrc", value);
        }
        public static ValueTask<string> GetMessage(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxLoadPanel_GetOption", dxTarget, "message");
        }
        public static ValueTask<object> SetMessage(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxLoadPanel_SetOption", dxTarget, "message", value);
        }
        public static ValueTask<bool?> GetShowIndicator(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxLoadPanel_GetOption", dxTarget, "showIndicator");
        }
        public static ValueTask<object> SetShowIndicator(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxLoadPanel_SetOption", dxTarget, "showIndicator", value);
        }
        public static ValueTask<bool?> GetShowPane(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxLoadPanel_GetOption", dxTarget, "showPane");
        }
        public static ValueTask<object> SetShowPane(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxLoadPanel_SetOption", dxTarget, "showPane", value);
        }

        public static new ValueTask<object> SetVisible(ElementReference dxTarget, bool? value)
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
        public static ValueTask<object> Init(ElementReference dxTarget, DevExpress.Ui.DxLookupOptions options)
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
        public static ValueTask<object> GetAnimation(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxLookup_GetOption", dxTarget, "animation");
        }
        public static ValueTask<object> SetAnimation(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxLookup_SetOption", dxTarget, "animation", value);
        }
        public static ValueTask<string> GetApplyButtonText(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxLookup_GetOption", dxTarget, "applyButtonText");
        }
        public static ValueTask<object> SetApplyButtonText(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxLookup_SetOption", dxTarget, "applyButtonText", value);
        }
        public static ValueTask<string> GetCancelButtonText(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxLookup_GetOption", dxTarget, "cancelButtonText");
        }
        public static ValueTask<object> SetCancelButtonText(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxLookup_SetOption", dxTarget, "cancelButtonText", value);
        }
        public static ValueTask<bool?> GetCleanSearchOnOpening(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxLookup_GetOption", dxTarget, "cleanSearchOnOpening");
        }
        public static ValueTask<object> SetCleanSearchOnOpening(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxLookup_SetOption", dxTarget, "cleanSearchOnOpening", value);
        }
        public static ValueTask<string> GetClearButtonText(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxLookup_GetOption", dxTarget, "clearButtonText");
        }
        public static ValueTask<object> SetClearButtonText(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxLookup_SetOption", dxTarget, "clearButtonText", value);
        }
        public static ValueTask<object> GetCloseOnOutsideClick(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxLookup_GetOption", dxTarget, "closeOnOutsideClick");
        }
        public static ValueTask<object> SetCloseOnOutsideClick(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxLookup_SetOption", dxTarget, "closeOnOutsideClick", value);
        }
        public static ValueTask<object> GetFieldTemplate(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxLookup_GetOption", dxTarget, "fieldTemplate");
        }
        public static ValueTask<object> SetFieldTemplate(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxLookup_SetOption", dxTarget, "fieldTemplate", value);
        }
        public static ValueTask<bool?> GetFullScreen(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxLookup_GetOption", dxTarget, "fullScreen");
        }
        public static ValueTask<object> SetFullScreen(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxLookup_SetOption", dxTarget, "fullScreen", value);
        }
        public static ValueTask<string> GetNextButtonText(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxLookup_GetOption", dxTarget, "nextButtonText");
        }
        public static ValueTask<object> SetNextButtonText(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxLookup_SetOption", dxTarget, "nextButtonText", value);
        }
        public static ValueTask<string> GetPageLoadingText(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxLookup_GetOption", dxTarget, "pageLoadingText");
        }
        public static ValueTask<object> SetPageLoadingText(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxLookup_SetOption", dxTarget, "pageLoadingText", value);
        }
        public static ValueTask<string> GetPageLoadMode(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxLookup_GetOption", dxTarget, "pageLoadMode");
        }
        public static ValueTask<object> SetPageLoadMode(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxLookup_SetOption", dxTarget, "pageLoadMode", value);
        }
        public static ValueTask<object> GetPopupHeight(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxLookup_GetOption", dxTarget, "popupHeight");
        }
        public static ValueTask<object> SetPopupHeight(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxLookup_SetOption", dxTarget, "popupHeight", value);
        }
        public static ValueTask<object> GetPopupWidth(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxLookup_GetOption", dxTarget, "popupWidth");
        }
        public static ValueTask<object> SetPopupWidth(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxLookup_SetOption", dxTarget, "popupWidth", value);
        }
        public static ValueTask<object> GetPosition(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxLookup_GetOption", dxTarget, "position");
        }
        public static ValueTask<object> SetPosition(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxLookup_SetOption", dxTarget, "position", value);
        }
        public static ValueTask<string> GetPulledDownText(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxLookup_GetOption", dxTarget, "pulledDownText");
        }
        public static ValueTask<object> SetPulledDownText(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxLookup_SetOption", dxTarget, "pulledDownText", value);
        }
        public static ValueTask<string> GetPullingDownText(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxLookup_GetOption", dxTarget, "pullingDownText");
        }
        public static ValueTask<object> SetPullingDownText(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxLookup_SetOption", dxTarget, "pullingDownText", value);
        }
        public static ValueTask<bool?> GetPullRefreshEnabled(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxLookup_GetOption", dxTarget, "pullRefreshEnabled");
        }
        public static ValueTask<object> SetPullRefreshEnabled(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxLookup_SetOption", dxTarget, "pullRefreshEnabled", value);
        }
        public static ValueTask<string> GetRefreshingText(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxLookup_GetOption", dxTarget, "refreshingText");
        }
        public static ValueTask<object> SetRefreshingText(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxLookup_SetOption", dxTarget, "refreshingText", value);
        }
        public static ValueTask<string> GetSearchPlaceholder(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxLookup_GetOption", dxTarget, "searchPlaceholder");
        }
        public static ValueTask<object> SetSearchPlaceholder(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxLookup_SetOption", dxTarget, "searchPlaceholder", value);
        }
        public static ValueTask<bool?> GetShading(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxLookup_GetOption", dxTarget, "shading");
        }
        public static ValueTask<object> SetShading(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxLookup_SetOption", dxTarget, "shading", value);
        }
        public static ValueTask<bool?> GetShowCancelButton(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxLookup_GetOption", dxTarget, "showCancelButton");
        }
        public static ValueTask<object> SetShowCancelButton(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxLookup_SetOption", dxTarget, "showCancelButton", value);
        }
        public static ValueTask<bool?> GetShowPopupTitle(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxLookup_GetOption", dxTarget, "showPopupTitle");
        }
        public static ValueTask<object> SetShowPopupTitle(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxLookup_SetOption", dxTarget, "showPopupTitle", value);
        }
        public static ValueTask<string> GetTitle(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxLookup_GetOption", dxTarget, "title");
        }
        public static ValueTask<object> SetTitle(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxLookup_SetOption", dxTarget, "title", value);
        }
        public static ValueTask<object> GetTitleTemplate(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxLookup_GetOption", dxTarget, "titleTemplate");
        }
        public static ValueTask<object> SetTitleTemplate(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxLookup_SetOption", dxTarget, "titleTemplate", value);
        }
        public static ValueTask<bool?> GetUseNativeScrolling(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxLookup_GetOption", dxTarget, "useNativeScrolling");
        }
        public static ValueTask<object> SetUseNativeScrolling(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxLookup_SetOption", dxTarget, "useNativeScrolling", value);
        }
        public static ValueTask<bool?> GetUsePopover(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxLookup_GetOption", dxTarget, "usePopover");
        }
        public static ValueTask<object> SetUsePopover(ElementReference dxTarget, bool? value)
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
        public static ValueTask<object> Init(ElementReference dxTarget, DevExpress.Ui.DxMapOptions options)
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
        public static ValueTask<bool?> GetAutoAdjust(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxMap_GetOption", dxTarget, "autoAdjust");
        }
        public static ValueTask<object> SetAutoAdjust(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxMap_SetOption", dxTarget, "autoAdjust", value);
        }
        public static ValueTask<object> GetCenter(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxMap_GetOption", dxTarget, "center");
        }
        public static ValueTask<object> SetCenter(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxMap_SetOption", dxTarget, "center", value);
        }
        public static ValueTask<bool?> GetControls(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxMap_GetOption", dxTarget, "controls");
        }
        public static ValueTask<object> SetControls(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxMap_SetOption", dxTarget, "controls", value);
        }
        public static ValueTask<object> GetKey(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxMap_GetOption", dxTarget, "key");
        }
        public static ValueTask<object> SetKey(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxMap_SetOption", dxTarget, "key", value);
        }
        public static ValueTask<string> GetMarkerIconSrc(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxMap_GetOption", dxTarget, "markerIconSrc");
        }
        public static ValueTask<object> SetMarkerIconSrc(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxMap_SetOption", dxTarget, "markerIconSrc", value);
        }
        public static ValueTask<object> GetMarkers(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxMap_GetOption", dxTarget, "markers");
        }
        public static ValueTask<object> SetMarkers(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxMap_SetOption", dxTarget, "markers", value);
        }
        public static ValueTask<string> GetProvider(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxMap_GetOption", dxTarget, "provider");
        }
        public static ValueTask<object> SetProvider(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxMap_SetOption", dxTarget, "provider", value);
        }
        public static ValueTask<object> GetRoutes(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxMap_GetOption", dxTarget, "routes");
        }
        public static ValueTask<object> SetRoutes(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxMap_SetOption", dxTarget, "routes", value);
        }
        public static ValueTask<string> GetType(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxMap_GetOption", dxTarget, "type");
        }
        public static ValueTask<object> SetType(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxMap_SetOption", dxTarget, "type", value);
        }
        public static ValueTask<float?> GetZoom(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_DxMap_GetOption", dxTarget, "zoom");
        }
        public static ValueTask<object> SetZoom(ElementReference dxTarget, float? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxMap_SetOption", dxTarget, "zoom", value);
        }
        public static ValueTask<object> AddMarker(ElementReference dxTarget, object markerOptions)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxMap_addMarker_0", dxTarget, markerOptions);
        }
        public static ValueTask<object> AddRoute(ElementReference dxTarget, object options)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxMap_addRoute_1", dxTarget, options);
        }
        public static ValueTask<object> RemoveMarker(ElementReference dxTarget, object marker)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxMap_removeMarker_2", dxTarget, marker);
        }
        public static ValueTask<object> RemoveRoute(ElementReference dxTarget, object route)
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
        public static ValueTask<object> Init(ElementReference dxTarget, DevExpress.Ui.DxMenuOptions options)
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
        public static ValueTask<bool?> GetAdaptivityEnabled(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxMenu_GetOption", dxTarget, "adaptivityEnabled");
        }
        public static ValueTask<object> SetAdaptivityEnabled(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxMenu_SetOption", dxTarget, "adaptivityEnabled", value);
        }
        public static ValueTask<bool?> GetHideSubmenuOnMouseLeave(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxMenu_GetOption", dxTarget, "hideSubmenuOnMouseLeave");
        }
        public static ValueTask<object> SetHideSubmenuOnMouseLeave(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxMenu_SetOption", dxTarget, "hideSubmenuOnMouseLeave", value);
        }
        public static ValueTask<string> GetOrientation(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxMenu_GetOption", dxTarget, "orientation");
        }
        public static ValueTask<object> SetOrientation(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxMenu_SetOption", dxTarget, "orientation", value);
        }
        public static ValueTask<object> GetShowFirstSubmenuMode(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxMenu_GetOption", dxTarget, "showFirstSubmenuMode");
        }
        public static ValueTask<object> SetShowFirstSubmenuMode(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxMenu_SetOption", dxTarget, "showFirstSubmenuMode", value);
        }
        public static ValueTask<string> GetSubmenuDirection(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxMenu_GetOption", dxTarget, "submenuDirection");
        }
        public static ValueTask<object> SetSubmenuDirection(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxMenu_SetOption", dxTarget, "submenuDirection", value);
        }
    }
    public class DxMultiViewInterop: CollectionWidgetInterop
    {
        public static ValueTask<object> Init(ElementReference dxTarget, DevExpress.Ui.DxMultiViewOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxMultiView_Init", dxTarget, json);
        }
        public static ValueTask<bool?> GetAnimationEnabled(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxMultiView_GetOption", dxTarget, "animationEnabled");
        }
        public static ValueTask<object> SetAnimationEnabled(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxMultiView_SetOption", dxTarget, "animationEnabled", value);
        }
        public static ValueTask<bool?> GetDeferRendering(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxMultiView_GetOption", dxTarget, "deferRendering");
        }
        public static ValueTask<object> SetDeferRendering(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxMultiView_SetOption", dxTarget, "deferRendering", value);
        }
        public static ValueTask<bool?> GetLoop(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxMultiView_GetOption", dxTarget, "loop");
        }
        public static ValueTask<object> SetLoop(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxMultiView_SetOption", dxTarget, "loop", value);
        }
        public static ValueTask<bool?> GetSwipeEnabled(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxMultiView_GetOption", dxTarget, "swipeEnabled");
        }
        public static ValueTask<object> SetSwipeEnabled(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxMultiView_SetOption", dxTarget, "swipeEnabled", value);
        }
    }
    public class DxNavBarInterop: DxTabsInterop
    {
        public static ValueTask<object> Init(ElementReference dxTarget, DevExpress.Ui.DxNavBarOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxNavBar_Init", dxTarget, json);
        }
    }
    public class DxNumberBoxInterop: DxTextEditorInterop
    {
        public static ValueTask<object> Init(ElementReference dxTarget, DevExpress.Ui.DxNumberBoxOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxNumberBox_Init", dxTarget, json);
        }
        public static ValueTask<object> GetFormat(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxNumberBox_GetOption", dxTarget, "format");
        }
        public static ValueTask<object> SetFormat(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxNumberBox_SetOption", dxTarget, "format", value);
        }
        public static ValueTask<string> GetInvalidValueMessage(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxNumberBox_GetOption", dxTarget, "invalidValueMessage");
        }
        public static ValueTask<object> SetInvalidValueMessage(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxNumberBox_SetOption", dxTarget, "invalidValueMessage", value);
        }
        public static ValueTask<float?> GetMax(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_DxNumberBox_GetOption", dxTarget, "max");
        }
        public static ValueTask<object> SetMax(ElementReference dxTarget, float? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxNumberBox_SetOption", dxTarget, "max", value);
        }
        public static ValueTask<float?> GetMin(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_DxNumberBox_GetOption", dxTarget, "min");
        }
        public static ValueTask<object> SetMin(ElementReference dxTarget, float? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxNumberBox_SetOption", dxTarget, "min", value);
        }
        public static ValueTask<string> GetMode(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxNumberBox_GetOption", dxTarget, "mode");
        }
        public static ValueTask<object> SetMode(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxNumberBox_SetOption", dxTarget, "mode", value);
        }
        public static ValueTask<bool?> GetShowSpinButtons(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxNumberBox_GetOption", dxTarget, "showSpinButtons");
        }
        public static ValueTask<object> SetShowSpinButtons(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxNumberBox_SetOption", dxTarget, "showSpinButtons", value);
        }
        public static ValueTask<float?> GetStep(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_DxNumberBox_GetOption", dxTarget, "step");
        }
        public static ValueTask<object> SetStep(ElementReference dxTarget, float? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxNumberBox_SetOption", dxTarget, "step", value);
        }
        public static ValueTask<bool?> GetUseLargeSpinButtons(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxNumberBox_GetOption", dxTarget, "useLargeSpinButtons");
        }
        public static ValueTask<object> SetUseLargeSpinButtons(ElementReference dxTarget, bool? value)
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
        public static ValueTask<object> Init(ElementReference dxTarget, DevExpress.Ui.DxOverlayOptions options)
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
        public static ValueTask<object> GetAnimation(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxOverlay_GetOption", dxTarget, "animation");
        }
        public static ValueTask<object> SetAnimation(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxOverlay_SetOption", dxTarget, "animation", value);
        }
        public static ValueTask<bool?> GetCloseOnBackButton(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxOverlay_GetOption", dxTarget, "closeOnBackButton");
        }
        public static ValueTask<object> SetCloseOnBackButton(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxOverlay_SetOption", dxTarget, "closeOnBackButton", value);
        }
        public static ValueTask<object> GetCloseOnOutsideClick(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxOverlay_GetOption", dxTarget, "closeOnOutsideClick");
        }
        public static ValueTask<object> SetCloseOnOutsideClick(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxOverlay_SetOption", dxTarget, "closeOnOutsideClick", value);
        }
        public static ValueTask<object> GetContentTemplate(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxOverlay_GetOption", dxTarget, "contentTemplate");
        }
        public static ValueTask<object> SetContentTemplate(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxOverlay_SetOption", dxTarget, "contentTemplate", value);
        }
        public static ValueTask<bool?> GetDeferRendering(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxOverlay_GetOption", dxTarget, "deferRendering");
        }
        public static ValueTask<object> SetDeferRendering(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxOverlay_SetOption", dxTarget, "deferRendering", value);
        }
        public static ValueTask<bool?> GetDragEnabled(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxOverlay_GetOption", dxTarget, "dragEnabled");
        }
        public static ValueTask<object> SetDragEnabled(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxOverlay_SetOption", dxTarget, "dragEnabled", value);
        }
        public static ValueTask<object> GetMaxHeight(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxOverlay_GetOption", dxTarget, "maxHeight");
        }
        public static ValueTask<object> SetMaxHeight(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxOverlay_SetOption", dxTarget, "maxHeight", value);
        }
        public static ValueTask<object> GetMaxWidth(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxOverlay_GetOption", dxTarget, "maxWidth");
        }
        public static ValueTask<object> SetMaxWidth(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxOverlay_SetOption", dxTarget, "maxWidth", value);
        }
        public static ValueTask<object> GetMinHeight(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxOverlay_GetOption", dxTarget, "minHeight");
        }
        public static ValueTask<object> SetMinHeight(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxOverlay_SetOption", dxTarget, "minHeight", value);
        }
        public static ValueTask<object> GetMinWidth(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxOverlay_GetOption", dxTarget, "minWidth");
        }
        public static ValueTask<object> SetMinWidth(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxOverlay_SetOption", dxTarget, "minWidth", value);
        }
        public static ValueTask<object> GetPosition(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxOverlay_GetOption", dxTarget, "position");
        }
        public static ValueTask<object> SetPosition(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxOverlay_SetOption", dxTarget, "position", value);
        }
        public static ValueTask<bool?> GetShading(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxOverlay_GetOption", dxTarget, "shading");
        }
        public static ValueTask<object> SetShading(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxOverlay_SetOption", dxTarget, "shading", value);
        }
        public static ValueTask<string> GetShadingColor(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxOverlay_GetOption", dxTarget, "shadingColor");
        }
        public static ValueTask<object> SetShadingColor(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxOverlay_SetOption", dxTarget, "shadingColor", value);
        }
        public static ValueTask<object> Content(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxOverlay_content_0", dxTarget);
        }
        public static ValueTask<object> Hide(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxOverlay_hide_1", dxTarget);
        }
        public static ValueTask<object> Repaint(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxOverlay_repaint_2", dxTarget);
        }
        public static ValueTask<object> Show(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxOverlay_show_3", dxTarget);
        }
        public static ValueTask<object> Toggle(ElementReference dxTarget, bool showing)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxOverlay_toggle_4", dxTarget, showing);
        }
    }
    public class DxPanoramaInterop: CollectionWidgetInterop
    {
        public static ValueTask<object> Init(ElementReference dxTarget, DevExpress.Ui.DxPanoramaOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPanorama_Init", dxTarget, json);
        }
        public static ValueTask<object> GetBackgroundImage(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPanorama_GetOption", dxTarget, "backgroundImage");
        }
        public static ValueTask<object> SetBackgroundImage(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPanorama_SetOption", dxTarget, "backgroundImage", value);
        }
        public static ValueTask<string> GetTitle(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxPanorama_GetOption", dxTarget, "title");
        }
        public static ValueTask<object> SetTitle(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPanorama_SetOption", dxTarget, "title", value);
        }
    }
    public class DxPivotInterop: CollectionWidgetInterop
    {
        public static ValueTask<object> Init(ElementReference dxTarget, DevExpress.Ui.DxPivotOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPivot_Init", dxTarget, json);
        }
        public static ValueTask<object> GetContentTemplate(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPivot_GetOption", dxTarget, "contentTemplate");
        }
        public static ValueTask<object> SetContentTemplate(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPivot_SetOption", dxTarget, "contentTemplate", value);
        }
        public static ValueTask<object> GetItemTitleTemplate(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPivot_GetOption", dxTarget, "itemTitleTemplate");
        }
        public static ValueTask<object> SetItemTitleTemplate(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPivot_SetOption", dxTarget, "itemTitleTemplate", value);
        }
        public static ValueTask<bool?> GetSwipeEnabled(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxPivot_GetOption", dxTarget, "swipeEnabled");
        }
        public static ValueTask<object> SetSwipeEnabled(ElementReference dxTarget, bool? value)
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
        public static ValueTask<object> Init(ElementReference dxTarget, DevExpress.Ui.DxPivotGridOptions options)
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
        public static ValueTask<bool?> GetAllowExpandAll(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxPivotGrid_GetOption", dxTarget, "allowExpandAll");
        }
        public static ValueTask<object> SetAllowExpandAll(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPivotGrid_SetOption", dxTarget, "allowExpandAll", value);
        }
        public static ValueTask<bool?> GetAllowFiltering(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxPivotGrid_GetOption", dxTarget, "allowFiltering");
        }
        public static ValueTask<object> SetAllowFiltering(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPivotGrid_SetOption", dxTarget, "allowFiltering", value);
        }
        public static ValueTask<bool?> GetAllowSorting(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxPivotGrid_GetOption", dxTarget, "allowSorting");
        }
        public static ValueTask<object> SetAllowSorting(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPivotGrid_SetOption", dxTarget, "allowSorting", value);
        }
        public static ValueTask<bool?> GetAllowSortingBySummary(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxPivotGrid_GetOption", dxTarget, "allowSortingBySummary");
        }
        public static ValueTask<object> SetAllowSortingBySummary(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPivotGrid_SetOption", dxTarget, "allowSortingBySummary", value);
        }
        public static ValueTask<string> GetDataFieldArea(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxPivotGrid_GetOption", dxTarget, "dataFieldArea");
        }
        public static ValueTask<object> SetDataFieldArea(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPivotGrid_SetOption", dxTarget, "dataFieldArea", value);
        }
        public static ValueTask<object> GetDataSource(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPivotGrid_GetOption", dxTarget, "dataSource");
        }
        public static ValueTask<object> SetDataSource(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPivotGrid_SetOption", dxTarget, "dataSource", value);
        }
        public static ValueTask<object> GetExport(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPivotGrid_GetOption", dxTarget, "export");
        }
        public static ValueTask<object> SetExport(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPivotGrid_SetOption", dxTarget, "export", value);
        }
        public static ValueTask<object> GetFieldChooser(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPivotGrid_GetOption", dxTarget, "fieldChooser");
        }
        public static ValueTask<object> SetFieldChooser(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPivotGrid_SetOption", dxTarget, "fieldChooser", value);
        }
        public static ValueTask<object> GetFieldPanel(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPivotGrid_GetOption", dxTarget, "fieldPanel");
        }
        public static ValueTask<object> SetFieldPanel(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPivotGrid_SetOption", dxTarget, "fieldPanel", value);
        }
        public static ValueTask<object> GetHeaderFilter(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPivotGrid_GetOption", dxTarget, "headerFilter");
        }
        public static ValueTask<object> SetHeaderFilter(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPivotGrid_SetOption", dxTarget, "headerFilter", value);
        }
        public static ValueTask<bool?> GetHideEmptySummaryCells(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxPivotGrid_GetOption", dxTarget, "hideEmptySummaryCells");
        }
        public static ValueTask<object> SetHideEmptySummaryCells(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPivotGrid_SetOption", dxTarget, "hideEmptySummaryCells", value);
        }
        public static ValueTask<object> GetLoadPanel(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPivotGrid_GetOption", dxTarget, "loadPanel");
        }
        public static ValueTask<object> SetLoadPanel(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPivotGrid_SetOption", dxTarget, "loadPanel", value);
        }
        public static ValueTask<string> GetRowHeaderLayout(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxPivotGrid_GetOption", dxTarget, "rowHeaderLayout");
        }
        public static ValueTask<object> SetRowHeaderLayout(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPivotGrid_SetOption", dxTarget, "rowHeaderLayout", value);
        }
        public static ValueTask<object> GetScrolling(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPivotGrid_GetOption", dxTarget, "scrolling");
        }
        public static ValueTask<object> SetScrolling(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPivotGrid_SetOption", dxTarget, "scrolling", value);
        }
        public static ValueTask<bool?> GetShowBorders(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxPivotGrid_GetOption", dxTarget, "showBorders");
        }
        public static ValueTask<object> SetShowBorders(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPivotGrid_SetOption", dxTarget, "showBorders", value);
        }
        public static ValueTask<bool?> GetShowColumnGrandTotals(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxPivotGrid_GetOption", dxTarget, "showColumnGrandTotals");
        }
        public static ValueTask<object> SetShowColumnGrandTotals(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPivotGrid_SetOption", dxTarget, "showColumnGrandTotals", value);
        }
        public static ValueTask<bool?> GetShowColumnTotals(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxPivotGrid_GetOption", dxTarget, "showColumnTotals");
        }
        public static ValueTask<object> SetShowColumnTotals(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPivotGrid_SetOption", dxTarget, "showColumnTotals", value);
        }
        public static ValueTask<bool?> GetShowRowGrandTotals(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxPivotGrid_GetOption", dxTarget, "showRowGrandTotals");
        }
        public static ValueTask<object> SetShowRowGrandTotals(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPivotGrid_SetOption", dxTarget, "showRowGrandTotals", value);
        }
        public static ValueTask<bool?> GetShowRowTotals(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxPivotGrid_GetOption", dxTarget, "showRowTotals");
        }
        public static ValueTask<object> SetShowRowTotals(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPivotGrid_SetOption", dxTarget, "showRowTotals", value);
        }
        public static ValueTask<string> GetShowTotalsPrior(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxPivotGrid_GetOption", dxTarget, "showTotalsPrior");
        }
        public static ValueTask<object> SetShowTotalsPrior(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPivotGrid_SetOption", dxTarget, "showTotalsPrior", value);
        }
        public static ValueTask<object> GetStateStoring(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPivotGrid_GetOption", dxTarget, "stateStoring");
        }
        public static ValueTask<object> SetStateStoring(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPivotGrid_SetOption", dxTarget, "stateStoring", value);
        }
        public static ValueTask<object> GetTexts(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPivotGrid_GetOption", dxTarget, "texts");
        }
        public static ValueTask<object> SetTexts(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPivotGrid_SetOption", dxTarget, "texts", value);
        }
        public static ValueTask<bool?> GetWordWrapEnabled(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxPivotGrid_GetOption", dxTarget, "wordWrapEnabled");
        }
        public static ValueTask<object> SetWordWrapEnabled(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPivotGrid_SetOption", dxTarget, "wordWrapEnabled", value);
        }
        public static ValueTask<object> BindChart(ElementReference dxTarget, object chart, object integrationOptions)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPivotGrid_bindChart_0", dxTarget, chart, integrationOptions);
        }
        public static ValueTask<object> ExportToExcel(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPivotGrid_exportToExcel_1", dxTarget);
        }
        public static ValueTask<object> GetDataSourceEx(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPivotGrid_getDataSource_2", dxTarget);
        }
        public static ValueTask<object> GetFieldChooserPopup(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPivotGrid_getFieldChooserPopup_3", dxTarget);
        }
        public static ValueTask<object> UpdateDimensions(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPivotGrid_updateDimensions_4", dxTarget);
        }
    }
    public class DxPivotGridFieldChooserInterop: WidgetInterop
    {
        public static event EventHandler<JQueryEventArgs> ContextMenuPreparing;
        public static ValueTask<object> Init(ElementReference dxTarget, DevExpress.Ui.DxPivotGridFieldChooserOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPivotGridFieldChooser_Init", dxTarget, json);
        }
        [JSInvokable("DevExpress.Ui.DxPivotGridFieldChooserInterop.OnContextMenuPreparing")]
        public static void OnContextMenuPreparing(string identifier)
        {
            ContextMenuPreparing?.Invoke(null, new JQueryEventArgs(identifier));
        }
        public static ValueTask<bool?> GetAllowSearch(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxPivotGridFieldChooser_GetOption", dxTarget, "allowSearch");
        }
        public static ValueTask<object> SetAllowSearch(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPivotGridFieldChooser_SetOption", dxTarget, "allowSearch", value);
        }
        public static ValueTask<string> GetApplyChangesMode(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxPivotGridFieldChooser_GetOption", dxTarget, "applyChangesMode");
        }
        public static ValueTask<object> SetApplyChangesMode(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPivotGridFieldChooser_SetOption", dxTarget, "applyChangesMode", value);
        }
        public static ValueTask<object> GetDataSource(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPivotGridFieldChooser_GetOption", dxTarget, "dataSource");
        }
        public static ValueTask<object> SetDataSource(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPivotGridFieldChooser_SetOption", dxTarget, "dataSource", value);
        }
        public static ValueTask<object> GetHeaderFilter(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPivotGridFieldChooser_GetOption", dxTarget, "headerFilter");
        }
        public static ValueTask<object> SetHeaderFilter(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPivotGridFieldChooser_SetOption", dxTarget, "headerFilter", value);
        }
        public static ValueTask<object> GetLayout(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPivotGridFieldChooser_GetOption", dxTarget, "layout");
        }
        public static ValueTask<object> SetLayout(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPivotGridFieldChooser_SetOption", dxTarget, "layout", value);
        }
        public static ValueTask<object> GetState(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPivotGridFieldChooser_GetOption", dxTarget, "state");
        }
        public static ValueTask<object> SetState(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPivotGridFieldChooser_SetOption", dxTarget, "state", value);
        }
        public static ValueTask<object> GetTexts(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPivotGridFieldChooser_GetOption", dxTarget, "texts");
        }
        public static ValueTask<object> SetTexts(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPivotGridFieldChooser_SetOption", dxTarget, "texts", value);
        }
        public static ValueTask<object> ApplyChanges(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPivotGridFieldChooser_applyChanges_0", dxTarget);
        }
        public static ValueTask<object> CancelChanges(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPivotGridFieldChooser_cancelChanges_1", dxTarget);
        }
        public static ValueTask<object> GetDataSourceEx(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPivotGridFieldChooser_getDataSource_2", dxTarget);
        }
        public static ValueTask<object> UpdateDimensions(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPivotGridFieldChooser_updateDimensions_3", dxTarget);
        }
    }
    public class DxPopoverInterop: DxPopupInterop
    {
        public static ValueTask<object> Init(ElementReference dxTarget, DevExpress.Ui.DxPopoverOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPopover_Init", dxTarget, json);
        }
        public static ValueTask<object> GetHideEvent(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPopover_GetOption", dxTarget, "hideEvent");
        }
        public static ValueTask<object> SetHideEvent(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPopover_SetOption", dxTarget, "hideEvent", value);
        }
        public static ValueTask<object> GetShowEvent(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPopover_GetOption", dxTarget, "showEvent");
        }
        public static ValueTask<object> SetShowEvent(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPopover_SetOption", dxTarget, "showEvent", value);
        }
        public static ValueTask<object> GetTarget(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPopover_GetOption", dxTarget, "target");
        }
        public static ValueTask<object> SetTarget(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPopover_SetOption", dxTarget, "target", value);
        }
        public static ValueTask<object> Show(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPopover_show_0", dxTarget);
        }
        public static ValueTask<object> Show(ElementReference dxTarget, object target)
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
        public static ValueTask<object> Init(ElementReference dxTarget, DevExpress.Ui.DxPopupOptions options)
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
        public static ValueTask<object> GetContainer(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPopup_GetOption", dxTarget, "container");
        }
        public static ValueTask<object> SetContainer(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPopup_SetOption", dxTarget, "container", value);
        }
        public static ValueTask<bool?> GetFullScreen(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxPopup_GetOption", dxTarget, "fullScreen");
        }
        public static ValueTask<object> SetFullScreen(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPopup_SetOption", dxTarget, "fullScreen", value);
        }
        public static ValueTask<bool?> GetResizeEnabled(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxPopup_GetOption", dxTarget, "resizeEnabled");
        }
        public static ValueTask<object> SetResizeEnabled(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPopup_SetOption", dxTarget, "resizeEnabled", value);
        }
        public static ValueTask<bool?> GetShowCloseButton(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxPopup_GetOption", dxTarget, "showCloseButton");
        }
        public static ValueTask<object> SetShowCloseButton(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPopup_SetOption", dxTarget, "showCloseButton", value);
        }
        public static ValueTask<bool?> GetShowTitle(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxPopup_GetOption", dxTarget, "showTitle");
        }
        public static ValueTask<object> SetShowTitle(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPopup_SetOption", dxTarget, "showTitle", value);
        }
        public static ValueTask<string> GetTitle(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxPopup_GetOption", dxTarget, "title");
        }
        public static ValueTask<object> SetTitle(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPopup_SetOption", dxTarget, "title", value);
        }
        public static ValueTask<object> GetTitleTemplate(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPopup_GetOption", dxTarget, "titleTemplate");
        }
        public static ValueTask<object> SetTitleTemplate(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPopup_SetOption", dxTarget, "titleTemplate", value);
        }
        public static ValueTask<object> GetToolbarItems(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPopup_GetOption", dxTarget, "toolbarItems");
        }
        public static ValueTask<object> SetToolbarItems(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPopup_SetOption", dxTarget, "toolbarItems", value);
        }
    }
    public class DxProgressBarInterop: DxTrackBarInterop
    {
        public static event EventHandler<JQueryEventArgs> Complete;
        public static ValueTask<object> Init(ElementReference dxTarget, DevExpress.Ui.DxProgressBarOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxProgressBar_Init", dxTarget, json);
        }
        [JSInvokable("DevExpress.Ui.DxProgressBarInterop.OnComplete")]
        public static void OnComplete(string identifier)
        {
            Complete?.Invoke(null, new JQueryEventArgs(identifier));
        }
        public static ValueTask<bool?> GetShowStatus(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxProgressBar_GetOption", dxTarget, "showStatus");
        }
        public static ValueTask<object> SetShowStatus(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxProgressBar_SetOption", dxTarget, "showStatus", value);
        }
        public static ValueTask<object> GetStatusFormat(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxProgressBar_GetOption", dxTarget, "statusFormat");
        }
        public static ValueTask<object> SetStatusFormat(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxProgressBar_SetOption", dxTarget, "statusFormat", value);
        }
    }
    public class DxRadioGroupInterop: EditorInterop
    {
        public static ValueTask<object> Init(ElementReference dxTarget, DevExpress.Ui.DxRadioGroupOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxRadioGroup_Init", dxTarget, json);
        }
        public static ValueTask<string> GetLayout(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxRadioGroup_GetOption", dxTarget, "layout");
        }
        public static ValueTask<object> SetLayout(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxRadioGroup_SetOption", dxTarget, "layout", value);
        }
        public static ValueTask<string> GetName(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxRadioGroup_GetOption", dxTarget, "name");
        }
        public static ValueTask<object> SetName(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxRadioGroup_SetOption", dxTarget, "name", value);
        }
        public static ValueTask<object> GetDataSource(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxRadioGroup_GetOption", dxTarget, "dataSource");
        }
        public static ValueTask<object> SetDataSource(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxRadioGroup_SetOption", dxTarget, "dataSource", value);
        }
        public static ValueTask<object> GetDisplayExpr(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxRadioGroup_GetOption", dxTarget, "displayExpr");
        }
        public static ValueTask<object> SetDisplayExpr(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxRadioGroup_SetOption", dxTarget, "displayExpr", value);
        }
        public static ValueTask<object> GetItems(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxRadioGroup_GetOption", dxTarget, "items");
        }
        public static ValueTask<object> SetItems(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxRadioGroup_SetOption", dxTarget, "items", value);
        }
        public static ValueTask<object> GetItemTemplate(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxRadioGroup_GetOption", dxTarget, "itemTemplate");
        }
        public static ValueTask<object> SetItemTemplate(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxRadioGroup_SetOption", dxTarget, "itemTemplate", value);
        }
        public static ValueTask<object> GetValueExpr(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxRadioGroup_GetOption", dxTarget, "valueExpr");
        }
        public static ValueTask<object> SetValueExpr(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxRadioGroup_SetOption", dxTarget, "valueExpr", value);
        }
        public static ValueTask<object> GetDataSourceEx(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxRadioGroup_getDataSource_0", dxTarget);
        }
    }
    public class DxRangeSliderInterop: DxSliderBaseInterop
    {
        public static ValueTask<object> Init(ElementReference dxTarget, DevExpress.Ui.DxRangeSliderOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxRangeSlider_Init", dxTarget, json);
        }
        public static ValueTask<float?> GetEnd(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_DxRangeSlider_GetOption", dxTarget, "end");
        }
        public static ValueTask<object> SetEnd(ElementReference dxTarget, float? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxRangeSlider_SetOption", dxTarget, "end", value);
        }
        public static ValueTask<string> GetEndName(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxRangeSlider_GetOption", dxTarget, "endName");
        }
        public static ValueTask<object> SetEndName(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxRangeSlider_SetOption", dxTarget, "endName", value);
        }
        public static ValueTask<float?> GetStart(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_DxRangeSlider_GetOption", dxTarget, "start");
        }
        public static ValueTask<object> SetStart(ElementReference dxTarget, float? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxRangeSlider_SetOption", dxTarget, "start", value);
        }
        public static ValueTask<string> GetStartName(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxRangeSlider_GetOption", dxTarget, "startName");
        }
        public static ValueTask<object> SetStartName(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxRangeSlider_SetOption", dxTarget, "startName", value);
        }
        public static ValueTask<object> Reset(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxRangeSlider_reset_0", dxTarget);
        }
    }
    public class DxResizableInterop: DOMComponentInterop
    {
        public static event EventHandler<JQueryEventArgs> Resize;
        public static event EventHandler<JQueryEventArgs> ResizeEnd;
        public static event EventHandler<JQueryEventArgs> ResizeStart;
        public static ValueTask<object> Init(ElementReference dxTarget, DevExpress.Ui.DxResizableOptions options)
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
        public static ValueTask<string> GetHandles(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxResizable_GetOption", dxTarget, "handles");
        }
        public static ValueTask<object> SetHandles(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxResizable_SetOption", dxTarget, "handles", value);
        }
        public static ValueTask<float?> GetMaxHeight(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_DxResizable_GetOption", dxTarget, "maxHeight");
        }
        public static ValueTask<object> SetMaxHeight(ElementReference dxTarget, float? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxResizable_SetOption", dxTarget, "maxHeight", value);
        }
        public static ValueTask<float?> GetMaxWidth(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_DxResizable_GetOption", dxTarget, "maxWidth");
        }
        public static ValueTask<object> SetMaxWidth(ElementReference dxTarget, float? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxResizable_SetOption", dxTarget, "maxWidth", value);
        }
        public static ValueTask<float?> GetMinHeight(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_DxResizable_GetOption", dxTarget, "minHeight");
        }
        public static ValueTask<object> SetMinHeight(ElementReference dxTarget, float? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxResizable_SetOption", dxTarget, "minHeight", value);
        }
        public static ValueTask<float?> GetMinWidth(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_DxResizable_GetOption", dxTarget, "minWidth");
        }
        public static ValueTask<object> SetMinWidth(ElementReference dxTarget, float? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxResizable_SetOption", dxTarget, "minWidth", value);
        }
    }
    public class DxResponsiveBoxInterop: CollectionWidgetInterop
    {
        public static ValueTask<object> Init(ElementReference dxTarget, DevExpress.Ui.DxResponsiveBoxOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxResponsiveBox_Init", dxTarget, json);
        }
        public static ValueTask<object> GetCols(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxResponsiveBox_GetOption", dxTarget, "cols");
        }
        public static ValueTask<object> SetCols(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxResponsiveBox_SetOption", dxTarget, "cols", value);
        }
        public static ValueTask<object> GetRows(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxResponsiveBox_GetOption", dxTarget, "rows");
        }
        public static ValueTask<object> SetRows(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxResponsiveBox_SetOption", dxTarget, "rows", value);
        }
        public static ValueTask<object> GetScreenByWidth(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxResponsiveBox_GetOption", dxTarget, "screenByWidth");
        }
        public static ValueTask<object> SetScreenByWidth(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxResponsiveBox_SetOption", dxTarget, "screenByWidth", value);
        }
        public static ValueTask<string> GetSingleColumnScreen(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxResponsiveBox_GetOption", dxTarget, "singleColumnScreen");
        }
        public static ValueTask<object> SetSingleColumnScreen(ElementReference dxTarget, string value)
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
        public static ValueTask<object> Init(ElementReference dxTarget, DevExpress.Ui.DxSchedulerOptions options)
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
        public static ValueTask<string> GetAllDayExpr(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxScheduler_GetOption", dxTarget, "allDayExpr");
        }
        public static ValueTask<object> SetAllDayExpr(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScheduler_SetOption", dxTarget, "allDayExpr", value);
        }
        public static ValueTask<object> GetAppointmentTemplate(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScheduler_GetOption", dxTarget, "appointmentTemplate");
        }
        public static ValueTask<object> SetAppointmentTemplate(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScheduler_SetOption", dxTarget, "appointmentTemplate", value);
        }
        public static ValueTask<object> GetAppointmentTooltipTemplate(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScheduler_GetOption", dxTarget, "appointmentTooltipTemplate");
        }
        public static ValueTask<object> SetAppointmentTooltipTemplate(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScheduler_SetOption", dxTarget, "appointmentTooltipTemplate", value);
        }
        public static ValueTask<float?> GetCellDuration(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_DxScheduler_GetOption", dxTarget, "cellDuration");
        }
        public static ValueTask<object> SetCellDuration(ElementReference dxTarget, float? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScheduler_SetOption", dxTarget, "cellDuration", value);
        }
        public static ValueTask<bool?> GetCrossScrollingEnabled(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxScheduler_GetOption", dxTarget, "crossScrollingEnabled");
        }
        public static ValueTask<object> SetCrossScrollingEnabled(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScheduler_SetOption", dxTarget, "crossScrollingEnabled", value);
        }
        public static ValueTask<object> GetCurrentDate(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScheduler_GetOption", dxTarget, "currentDate");
        }
        public static ValueTask<object> SetCurrentDate(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScheduler_SetOption", dxTarget, "currentDate", value);
        }
        public static ValueTask<string> GetCurrentView(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxScheduler_GetOption", dxTarget, "currentView");
        }
        public static ValueTask<object> SetCurrentView(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScheduler_SetOption", dxTarget, "currentView", value);
        }
        public static ValueTask<object> GetDataCellTemplate(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScheduler_GetOption", dxTarget, "dataCellTemplate");
        }
        public static ValueTask<object> SetDataCellTemplate(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScheduler_SetOption", dxTarget, "dataCellTemplate", value);
        }
        public static ValueTask<object> GetDataSource(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScheduler_GetOption", dxTarget, "dataSource");
        }
        public static ValueTask<object> SetDataSource(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScheduler_SetOption", dxTarget, "dataSource", value);
        }
        public static ValueTask<object> GetDateCellTemplate(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScheduler_GetOption", dxTarget, "dateCellTemplate");
        }
        public static ValueTask<object> SetDateCellTemplate(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScheduler_SetOption", dxTarget, "dateCellTemplate", value);
        }
        public static ValueTask<string> GetDateSerializationFormat(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxScheduler_GetOption", dxTarget, "dateSerializationFormat");
        }
        public static ValueTask<object> SetDateSerializationFormat(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScheduler_SetOption", dxTarget, "dateSerializationFormat", value);
        }
        public static ValueTask<string> GetDescriptionExpr(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxScheduler_GetOption", dxTarget, "descriptionExpr");
        }
        public static ValueTask<object> SetDescriptionExpr(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScheduler_SetOption", dxTarget, "descriptionExpr", value);
        }
        public static ValueTask<object> GetDropDownAppointmentTemplate(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScheduler_GetOption", dxTarget, "dropDownAppointmentTemplate");
        }
        public static ValueTask<object> SetDropDownAppointmentTemplate(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScheduler_SetOption", dxTarget, "dropDownAppointmentTemplate", value);
        }
        public static ValueTask<object> GetEditing(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScheduler_GetOption", dxTarget, "editing");
        }
        public static ValueTask<object> SetEditing(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScheduler_SetOption", dxTarget, "editing", value);
        }
        public static ValueTask<string> GetEndDateExpr(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxScheduler_GetOption", dxTarget, "endDateExpr");
        }
        public static ValueTask<object> SetEndDateExpr(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScheduler_SetOption", dxTarget, "endDateExpr", value);
        }
        public static ValueTask<string> GetEndDateTimeZoneExpr(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxScheduler_GetOption", dxTarget, "endDateTimeZoneExpr");
        }
        public static ValueTask<object> SetEndDateTimeZoneExpr(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScheduler_SetOption", dxTarget, "endDateTimeZoneExpr", value);
        }
        public static ValueTask<float?> GetEndDayHour(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_DxScheduler_GetOption", dxTarget, "endDayHour");
        }
        public static ValueTask<object> SetEndDayHour(ElementReference dxTarget, float? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScheduler_SetOption", dxTarget, "endDayHour", value);
        }
        public static ValueTask<object> GetFirstDayOfWeek(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScheduler_GetOption", dxTarget, "firstDayOfWeek");
        }
        public static ValueTask<object> SetFirstDayOfWeek(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScheduler_SetOption", dxTarget, "firstDayOfWeek", value);
        }
        public static ValueTask<object> GetGroups(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScheduler_GetOption", dxTarget, "groups");
        }
        public static ValueTask<object> SetGroups(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScheduler_SetOption", dxTarget, "groups", value);
        }
        public static ValueTask<float?> GetIndicatorUpdateInterval(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_DxScheduler_GetOption", dxTarget, "indicatorUpdateInterval");
        }
        public static ValueTask<object> SetIndicatorUpdateInterval(ElementReference dxTarget, float? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScheduler_SetOption", dxTarget, "indicatorUpdateInterval", value);
        }
        public static ValueTask<object> GetMax(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScheduler_GetOption", dxTarget, "max");
        }
        public static ValueTask<object> SetMax(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScheduler_SetOption", dxTarget, "max", value);
        }
        public static ValueTask<object> GetMaxAppointmentsPerCell(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScheduler_GetOption", dxTarget, "maxAppointmentsPerCell");
        }
        public static ValueTask<object> SetMaxAppointmentsPerCell(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScheduler_SetOption", dxTarget, "maxAppointmentsPerCell", value);
        }
        public static ValueTask<object> GetMin(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScheduler_GetOption", dxTarget, "min");
        }
        public static ValueTask<object> SetMin(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScheduler_SetOption", dxTarget, "min", value);
        }
        public static ValueTask<string> GetNoDataText(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxScheduler_GetOption", dxTarget, "noDataText");
        }
        public static ValueTask<object> SetNoDataText(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScheduler_SetOption", dxTarget, "noDataText", value);
        }
        public static ValueTask<string> GetRecurrenceEditMode(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxScheduler_GetOption", dxTarget, "recurrenceEditMode");
        }
        public static ValueTask<object> SetRecurrenceEditMode(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScheduler_SetOption", dxTarget, "recurrenceEditMode", value);
        }
        public static ValueTask<string> GetRecurrenceExceptionExpr(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxScheduler_GetOption", dxTarget, "recurrenceExceptionExpr");
        }
        public static ValueTask<object> SetRecurrenceExceptionExpr(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScheduler_SetOption", dxTarget, "recurrenceExceptionExpr", value);
        }
        public static ValueTask<string> GetRecurrenceRuleExpr(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxScheduler_GetOption", dxTarget, "recurrenceRuleExpr");
        }
        public static ValueTask<object> SetRecurrenceRuleExpr(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScheduler_SetOption", dxTarget, "recurrenceRuleExpr", value);
        }
        public static ValueTask<bool?> GetRemoteFiltering(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxScheduler_GetOption", dxTarget, "remoteFiltering");
        }
        public static ValueTask<object> SetRemoteFiltering(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScheduler_SetOption", dxTarget, "remoteFiltering", value);
        }
        public static ValueTask<object> GetResourceCellTemplate(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScheduler_GetOption", dxTarget, "resourceCellTemplate");
        }
        public static ValueTask<object> SetResourceCellTemplate(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScheduler_SetOption", dxTarget, "resourceCellTemplate", value);
        }
        public static ValueTask<object> GetResources(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScheduler_GetOption", dxTarget, "resources");
        }
        public static ValueTask<object> SetResources(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScheduler_SetOption", dxTarget, "resources", value);
        }
        public static ValueTask<object> GetSelectedCellData(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScheduler_GetOption", dxTarget, "selectedCellData");
        }
        public static ValueTask<object> SetSelectedCellData(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScheduler_SetOption", dxTarget, "selectedCellData", value);
        }
        public static ValueTask<bool?> GetShadeUntilCurrentTime(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxScheduler_GetOption", dxTarget, "shadeUntilCurrentTime");
        }
        public static ValueTask<object> SetShadeUntilCurrentTime(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScheduler_SetOption", dxTarget, "shadeUntilCurrentTime", value);
        }
        public static ValueTask<bool?> GetShowAllDayPanel(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxScheduler_GetOption", dxTarget, "showAllDayPanel");
        }
        public static ValueTask<object> SetShowAllDayPanel(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScheduler_SetOption", dxTarget, "showAllDayPanel", value);
        }
        public static ValueTask<bool?> GetShowCurrentTimeIndicator(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxScheduler_GetOption", dxTarget, "showCurrentTimeIndicator");
        }
        public static ValueTask<object> SetShowCurrentTimeIndicator(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScheduler_SetOption", dxTarget, "showCurrentTimeIndicator", value);
        }
        public static ValueTask<string> GetStartDateExpr(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxScheduler_GetOption", dxTarget, "startDateExpr");
        }
        public static ValueTask<object> SetStartDateExpr(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScheduler_SetOption", dxTarget, "startDateExpr", value);
        }
        public static ValueTask<string> GetStartDateTimeZoneExpr(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxScheduler_GetOption", dxTarget, "startDateTimeZoneExpr");
        }
        public static ValueTask<object> SetStartDateTimeZoneExpr(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScheduler_SetOption", dxTarget, "startDateTimeZoneExpr", value);
        }
        public static ValueTask<float?> GetStartDayHour(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_DxScheduler_GetOption", dxTarget, "startDayHour");
        }
        public static ValueTask<object> SetStartDayHour(ElementReference dxTarget, float? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScheduler_SetOption", dxTarget, "startDayHour", value);
        }
        public static ValueTask<string> GetTextExpr(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxScheduler_GetOption", dxTarget, "textExpr");
        }
        public static ValueTask<object> SetTextExpr(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScheduler_SetOption", dxTarget, "textExpr", value);
        }
        public static ValueTask<object> GetTimeCellTemplate(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScheduler_GetOption", dxTarget, "timeCellTemplate");
        }
        public static ValueTask<object> SetTimeCellTemplate(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScheduler_SetOption", dxTarget, "timeCellTemplate", value);
        }
        public static ValueTask<string> GetTimeZone(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxScheduler_GetOption", dxTarget, "timeZone");
        }
        public static ValueTask<object> SetTimeZone(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScheduler_SetOption", dxTarget, "timeZone", value);
        }
        public static ValueTask<bool?> GetUseDropDownViewSwitcher(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxScheduler_GetOption", dxTarget, "useDropDownViewSwitcher");
        }
        public static ValueTask<object> SetUseDropDownViewSwitcher(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScheduler_SetOption", dxTarget, "useDropDownViewSwitcher", value);
        }
        public static ValueTask<object> GetViews(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScheduler_GetOption", dxTarget, "views");
        }
        public static ValueTask<object> SetViews(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScheduler_SetOption", dxTarget, "views", value);
        }
        public static ValueTask<object> AddAppointment(ElementReference dxTarget, object appointment)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScheduler_addAppointment_0", dxTarget, appointment);
        }
        public static ValueTask<object> DeleteAppointment(ElementReference dxTarget, object appointment)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScheduler_deleteAppointment_1", dxTarget, appointment);
        }
        public static ValueTask<object> GetDataSourceEx(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScheduler_getDataSource_2", dxTarget);
        }
        public static ValueTask<object> GetEndViewDate(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScheduler_getEndViewDate_3", dxTarget);
        }
        public static ValueTask<object> GetStartViewDate(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScheduler_getStartViewDate_4", dxTarget);
        }
        public static ValueTask<object> HideAppointmentPopup(ElementReference dxTarget, bool saveChanges)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScheduler_hideAppointmentPopup_5", dxTarget, saveChanges);
        }
        public static ValueTask<object> HideAppointmentTooltip(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScheduler_hideAppointmentTooltip_6", dxTarget);
        }
        public static ValueTask<object> RegisterKeyHandler(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScheduler_registerKeyHandler_7", dxTarget);
        }
        public static ValueTask<object> ScrollToTime(ElementReference dxTarget, float hours, float minutes, object date)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScheduler_scrollToTime_8", dxTarget, hours, minutes, date);
        }
        public static ValueTask<object> ShowAppointmentPopup(ElementReference dxTarget, object appointmentData, bool createNewAppointment, object currentAppointmentData)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScheduler_showAppointmentPopup_9", dxTarget, appointmentData, createNewAppointment, currentAppointmentData);
        }
        public static ValueTask<object> ShowAppointmentTooltip(ElementReference dxTarget, object appointmentData, object target, object currentAppointmentData)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScheduler_showAppointmentTooltip_10", dxTarget, appointmentData, target, currentAppointmentData);
        }
        public static ValueTask<object> UpdateAppointment(ElementReference dxTarget, object target, object appointment)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScheduler_updateAppointment_11", dxTarget, target, appointment);
        }
    }
    public class DxScrollViewInterop: DxScrollableInterop
    {
        public static event EventHandler<JQueryEventArgs> PullDown;
        public static event EventHandler<JQueryEventArgs> ReachBottom;
        public static ValueTask<object> Init(ElementReference dxTarget, DevExpress.Ui.DxScrollViewOptions options)
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
        public static ValueTask<string> GetPulledDownText(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxScrollView_GetOption", dxTarget, "pulledDownText");
        }
        public static ValueTask<object> SetPulledDownText(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScrollView_SetOption", dxTarget, "pulledDownText", value);
        }
        public static ValueTask<string> GetPullingDownText(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxScrollView_GetOption", dxTarget, "pullingDownText");
        }
        public static ValueTask<object> SetPullingDownText(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScrollView_SetOption", dxTarget, "pullingDownText", value);
        }
        public static ValueTask<string> GetReachBottomText(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxScrollView_GetOption", dxTarget, "reachBottomText");
        }
        public static ValueTask<object> SetReachBottomText(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScrollView_SetOption", dxTarget, "reachBottomText", value);
        }
        public static ValueTask<string> GetRefreshingText(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxScrollView_GetOption", dxTarget, "refreshingText");
        }
        public static ValueTask<object> SetRefreshingText(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScrollView_SetOption", dxTarget, "refreshingText", value);
        }
        public static ValueTask<object> Refresh(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScrollView_refresh_0", dxTarget);
        }
        public static ValueTask<object> Release(ElementReference dxTarget, bool preventScrollBottom)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScrollView_release_1", dxTarget, preventScrollBottom);
        }
    }
    public class DxSelectBoxInterop: DxDropDownListInterop
    {
        public static event EventHandler<JQueryEventArgs> CustomItemCreating;
        public static ValueTask<object> Init(ElementReference dxTarget, DevExpress.Ui.DxSelectBoxOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxSelectBox_Init", dxTarget, json);
        }
        [JSInvokable("DevExpress.Ui.DxSelectBoxInterop.OnCustomItemCreating")]
        public static void OnCustomItemCreating(string identifier)
        {
            CustomItemCreating?.Invoke(null, new JQueryEventArgs(identifier));
        }
        public static ValueTask<object> GetFieldTemplate(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxSelectBox_GetOption", dxTarget, "fieldTemplate");
        }
        public static ValueTask<object> SetFieldTemplate(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxSelectBox_SetOption", dxTarget, "fieldTemplate", value);
        }
        public static ValueTask<bool?> GetShowSelectionControls(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxSelectBox_GetOption", dxTarget, "showSelectionControls");
        }
        public static ValueTask<object> SetShowSelectionControls(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxSelectBox_SetOption", dxTarget, "showSelectionControls", value);
        }
    }
    public class DxSliderInterop: DxSliderBaseInterop
    {
        public static ValueTask<object> Init(ElementReference dxTarget, DevExpress.Ui.DxSliderOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxSlider_Init", dxTarget, json);
        }
    }
    public class DxSlideOutInterop: CollectionWidgetInterop
    {
        public static event EventHandler<JQueryEventArgs> MenuGroupRendered;
        public static event EventHandler<JQueryEventArgs> MenuItemRendered;
        public static ValueTask<object> Init(ElementReference dxTarget, DevExpress.Ui.DxSlideOutOptions options)
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
        public static ValueTask<object> GetContentTemplate(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxSlideOut_GetOption", dxTarget, "contentTemplate");
        }
        public static ValueTask<object> SetContentTemplate(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxSlideOut_SetOption", dxTarget, "contentTemplate", value);
        }
        public static ValueTask<bool?> GetMenuGrouped(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxSlideOut_GetOption", dxTarget, "menuGrouped");
        }
        public static ValueTask<object> SetMenuGrouped(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxSlideOut_SetOption", dxTarget, "menuGrouped", value);
        }
        public static ValueTask<object> GetMenuGroupTemplate(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxSlideOut_GetOption", dxTarget, "menuGroupTemplate");
        }
        public static ValueTask<object> SetMenuGroupTemplate(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxSlideOut_SetOption", dxTarget, "menuGroupTemplate", value);
        }
        public static ValueTask<object> GetMenuItemTemplate(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxSlideOut_GetOption", dxTarget, "menuItemTemplate");
        }
        public static ValueTask<object> SetMenuItemTemplate(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxSlideOut_SetOption", dxTarget, "menuItemTemplate", value);
        }
        public static ValueTask<string> GetMenuPosition(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxSlideOut_GetOption", dxTarget, "menuPosition");
        }
        public static ValueTask<object> SetMenuPosition(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxSlideOut_SetOption", dxTarget, "menuPosition", value);
        }
        public static ValueTask<bool?> GetMenuVisible(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxSlideOut_GetOption", dxTarget, "menuVisible");
        }
        public static ValueTask<object> SetMenuVisible(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxSlideOut_SetOption", dxTarget, "menuVisible", value);
        }
        public static ValueTask<bool?> GetSwipeEnabled(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxSlideOut_GetOption", dxTarget, "swipeEnabled");
        }
        public static ValueTask<object> SetSwipeEnabled(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxSlideOut_SetOption", dxTarget, "swipeEnabled", value);
        }
        public static ValueTask<object> HideMenu(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxSlideOut_hideMenu_0", dxTarget);
        }
        public static ValueTask<object> ShowMenu(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxSlideOut_showMenu_1", dxTarget);
        }
        public static ValueTask<object> ToggleMenuVisibility(ElementReference dxTarget, bool showing)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxSlideOut_toggleMenuVisibility_2", dxTarget, showing);
        }
    }
    public class DxSlideOutViewInterop: WidgetInterop
    {
        public static ValueTask<object> Init(ElementReference dxTarget, DevExpress.Ui.DxSlideOutViewOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxSlideOutView_Init", dxTarget, json);
        }
        public static ValueTask<object> GetContentTemplate(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxSlideOutView_GetOption", dxTarget, "contentTemplate");
        }
        public static ValueTask<object> SetContentTemplate(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxSlideOutView_SetOption", dxTarget, "contentTemplate", value);
        }
        public static ValueTask<string> GetMenuPosition(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxSlideOutView_GetOption", dxTarget, "menuPosition");
        }
        public static ValueTask<object> SetMenuPosition(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxSlideOutView_SetOption", dxTarget, "menuPosition", value);
        }
        public static ValueTask<object> GetMenuTemplate(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxSlideOutView_GetOption", dxTarget, "menuTemplate");
        }
        public static ValueTask<object> SetMenuTemplate(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxSlideOutView_SetOption", dxTarget, "menuTemplate", value);
        }
        public static ValueTask<bool?> GetMenuVisible(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxSlideOutView_GetOption", dxTarget, "menuVisible");
        }
        public static ValueTask<object> SetMenuVisible(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxSlideOutView_SetOption", dxTarget, "menuVisible", value);
        }
        public static ValueTask<bool?> GetSwipeEnabled(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxSlideOutView_GetOption", dxTarget, "swipeEnabled");
        }
        public static ValueTask<object> SetSwipeEnabled(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxSlideOutView_SetOption", dxTarget, "swipeEnabled", value);
        }
        public static ValueTask<object> Content(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxSlideOutView_content_0", dxTarget);
        }
        public static ValueTask<object> HideMenu(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxSlideOutView_hideMenu_1", dxTarget);
        }
        public static ValueTask<object> MenuContent(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxSlideOutView_menuContent_2", dxTarget);
        }
        public static ValueTask<object> ShowMenu(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxSlideOutView_showMenu_3", dxTarget);
        }
        public static ValueTask<object> ToggleMenuVisibility(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxSlideOutView_toggleMenuVisibility_4", dxTarget);
        }
    }
    public class DxSwitchInterop: EditorInterop
    {
        public static ValueTask<object> Init(ElementReference dxTarget, DevExpress.Ui.DxSwitchOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxSwitch_Init", dxTarget, json);
        }
        public static ValueTask<string> GetName(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxSwitch_GetOption", dxTarget, "name");
        }
        public static ValueTask<object> SetName(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxSwitch_SetOption", dxTarget, "name", value);
        }
        public static ValueTask<string> GetOffText(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxSwitch_GetOption", dxTarget, "offText");
        }
        public static ValueTask<object> SetOffText(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxSwitch_SetOption", dxTarget, "offText", value);
        }
        public static ValueTask<string> GetOnText(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxSwitch_GetOption", dxTarget, "onText");
        }
        public static ValueTask<object> SetOnText(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxSwitch_SetOption", dxTarget, "onText", value);
        }
    }
    public class DxTabsInterop: CollectionWidgetInterop
    {
        public static ValueTask<object> Init(ElementReference dxTarget, DevExpress.Ui.DxTabsOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTabs_Init", dxTarget, json);
        }
        public static ValueTask<bool?> GetScrollByContent(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxTabs_GetOption", dxTarget, "scrollByContent");
        }
        public static ValueTask<object> SetScrollByContent(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTabs_SetOption", dxTarget, "scrollByContent", value);
        }
        public static ValueTask<bool?> GetScrollingEnabled(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxTabs_GetOption", dxTarget, "scrollingEnabled");
        }
        public static ValueTask<object> SetScrollingEnabled(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTabs_SetOption", dxTarget, "scrollingEnabled", value);
        }
        public static ValueTask<string> GetSelectionMode(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxTabs_GetOption", dxTarget, "selectionMode");
        }
        public static ValueTask<object> SetSelectionMode(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTabs_SetOption", dxTarget, "selectionMode", value);
        }
        public static ValueTask<bool?> GetShowNavButtons(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxTabs_GetOption", dxTarget, "showNavButtons");
        }
        public static ValueTask<object> SetShowNavButtons(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTabs_SetOption", dxTarget, "showNavButtons", value);
        }
    }
    public class DxTabPanelInterop: DxMultiViewInterop
    {
        public static event EventHandler<JQueryEventArgs> TitleClick;
        public static event EventHandler<JQueryEventArgs> TitleHold;
        public static event EventHandler<JQueryEventArgs> TitleRendered;
        public static ValueTask<object> Init(ElementReference dxTarget, DevExpress.Ui.DxTabPanelOptions options)
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
        public static ValueTask<object> GetItemTitleTemplate(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTabPanel_GetOption", dxTarget, "itemTitleTemplate");
        }
        public static ValueTask<object> SetItemTitleTemplate(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTabPanel_SetOption", dxTarget, "itemTitleTemplate", value);
        }
        public static ValueTask<bool?> GetScrollByContent(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxTabPanel_GetOption", dxTarget, "scrollByContent");
        }
        public static ValueTask<object> SetScrollByContent(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTabPanel_SetOption", dxTarget, "scrollByContent", value);
        }
        public static ValueTask<bool?> GetScrollingEnabled(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxTabPanel_GetOption", dxTarget, "scrollingEnabled");
        }
        public static ValueTask<object> SetScrollingEnabled(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTabPanel_SetOption", dxTarget, "scrollingEnabled", value);
        }
        public static ValueTask<bool?> GetShowNavButtons(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxTabPanel_GetOption", dxTarget, "showNavButtons");
        }
        public static ValueTask<object> SetShowNavButtons(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTabPanel_SetOption", dxTarget, "showNavButtons", value);
        }
    }
    public class DxTagBoxInterop: DxSelectBoxInterop
    {
        public static event EventHandler<JQueryEventArgs> MultiTagPreparing;
        public static event EventHandler<JQueryEventArgs> SelectAllValueChanged;
        public static ValueTask<object> Init(ElementReference dxTarget, DevExpress.Ui.DxTagBoxOptions options)
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
        public static ValueTask<bool?> GetHideSelectedItems(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxTagBox_GetOption", dxTarget, "hideSelectedItems");
        }
        public static ValueTask<object> SetHideSelectedItems(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTagBox_SetOption", dxTarget, "hideSelectedItems", value);
        }
        public static ValueTask<float?> GetMaxDisplayedTags(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_DxTagBox_GetOption", dxTarget, "maxDisplayedTags");
        }
        public static ValueTask<object> SetMaxDisplayedTags(ElementReference dxTarget, float? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTagBox_SetOption", dxTarget, "maxDisplayedTags", value);
        }
        public static ValueTask<bool?> GetMultiline(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxTagBox_GetOption", dxTarget, "multiline");
        }
        public static ValueTask<object> SetMultiline(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTagBox_SetOption", dxTarget, "multiline", value);
        }
        public static ValueTask<string> GetSelectAllMode(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxTagBox_GetOption", dxTarget, "selectAllMode");
        }
        public static ValueTask<object> SetSelectAllMode(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTagBox_SetOption", dxTarget, "selectAllMode", value);
        }
        public static ValueTask<object> GetSelectedItems(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTagBox_GetOption", dxTarget, "selectedItems");
        }
        public static ValueTask<object> SetSelectedItems(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTagBox_SetOption", dxTarget, "selectedItems", value);
        }
        public static ValueTask<bool?> GetShowMultiTagOnly(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxTagBox_GetOption", dxTarget, "showMultiTagOnly");
        }
        public static ValueTask<object> SetShowMultiTagOnly(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTagBox_SetOption", dxTarget, "showMultiTagOnly", value);
        }
        public static ValueTask<object> GetTagTemplate(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTagBox_GetOption", dxTarget, "tagTemplate");
        }
        public static ValueTask<object> SetTagTemplate(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTagBox_SetOption", dxTarget, "tagTemplate", value);
        }
    }
    public class DxTextAreaInterop: DxTextBoxInterop
    {
        public static ValueTask<object> Init(ElementReference dxTarget, DevExpress.Ui.DxTextAreaOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTextArea_Init", dxTarget, json);
        }
        public static ValueTask<bool?> GetAutoResizeEnabled(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxTextArea_GetOption", dxTarget, "autoResizeEnabled");
        }
        public static ValueTask<object> SetAutoResizeEnabled(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTextArea_SetOption", dxTarget, "autoResizeEnabled", value);
        }
        public static ValueTask<object> GetMaxHeight(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTextArea_GetOption", dxTarget, "maxHeight");
        }
        public static ValueTask<object> SetMaxHeight(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTextArea_SetOption", dxTarget, "maxHeight", value);
        }
        public static ValueTask<object> GetMinHeight(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTextArea_GetOption", dxTarget, "minHeight");
        }
        public static ValueTask<object> SetMinHeight(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTextArea_SetOption", dxTarget, "minHeight", value);
        }
    }
    public class DxTextBoxInterop: DxTextEditorInterop
    {
        public static ValueTask<object> Init(ElementReference dxTarget, DevExpress.Ui.DxTextBoxOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTextBox_Init", dxTarget, json);
        }
        public static ValueTask<object> GetMaxLength(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTextBox_GetOption", dxTarget, "maxLength");
        }
        public static ValueTask<object> SetMaxLength(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTextBox_SetOption", dxTarget, "maxLength", value);
        }
        public static ValueTask<string> GetMode(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxTextBox_GetOption", dxTarget, "mode");
        }
        public static ValueTask<object> SetMode(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTextBox_SetOption", dxTarget, "mode", value);
        }
    }
    public class DxTileViewInterop: CollectionWidgetInterop
    {
        public static ValueTask<object> Init(ElementReference dxTarget, DevExpress.Ui.DxTileViewOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTileView_Init", dxTarget, json);
        }
        public static ValueTask<float?> GetBaseItemHeight(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_DxTileView_GetOption", dxTarget, "baseItemHeight");
        }
        public static ValueTask<object> SetBaseItemHeight(ElementReference dxTarget, float? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTileView_SetOption", dxTarget, "baseItemHeight", value);
        }
        public static ValueTask<float?> GetBaseItemWidth(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_DxTileView_GetOption", dxTarget, "baseItemWidth");
        }
        public static ValueTask<object> SetBaseItemWidth(ElementReference dxTarget, float? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTileView_SetOption", dxTarget, "baseItemWidth", value);
        }
        public static ValueTask<string> GetDirection(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxTileView_GetOption", dxTarget, "direction");
        }
        public static ValueTask<object> SetDirection(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTileView_SetOption", dxTarget, "direction", value);
        }
        public static ValueTask<float?> GetItemMargin(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_DxTileView_GetOption", dxTarget, "itemMargin");
        }
        public static ValueTask<object> SetItemMargin(ElementReference dxTarget, float? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTileView_SetOption", dxTarget, "itemMargin", value);
        }
        public static ValueTask<bool?> GetShowScrollbar(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxTileView_GetOption", dxTarget, "showScrollbar");
        }
        public static ValueTask<object> SetShowScrollbar(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTileView_SetOption", dxTarget, "showScrollbar", value);
        }
        public static ValueTask<float> ScrollPosition(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<float>("BlazorDevExtreme_DxTileView_scrollPosition_0", dxTarget);
        }
    }
    public class DxToastInterop: DxOverlayInterop
    {
        public static ValueTask<object> Init(ElementReference dxTarget, DevExpress.Ui.DxToastOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxToast_Init", dxTarget, json);
        }
        public static ValueTask<bool?> GetCloseOnClick(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxToast_GetOption", dxTarget, "closeOnClick");
        }
        public static ValueTask<object> SetCloseOnClick(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxToast_SetOption", dxTarget, "closeOnClick", value);
        }
        public static ValueTask<bool?> GetCloseOnSwipe(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxToast_GetOption", dxTarget, "closeOnSwipe");
        }
        public static ValueTask<object> SetCloseOnSwipe(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxToast_SetOption", dxTarget, "closeOnSwipe", value);
        }
        public static ValueTask<float?> GetDisplayTime(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_DxToast_GetOption", dxTarget, "displayTime");
        }
        public static ValueTask<object> SetDisplayTime(ElementReference dxTarget, float? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxToast_SetOption", dxTarget, "displayTime", value);
        }
        public static ValueTask<string> GetMessage(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxToast_GetOption", dxTarget, "message");
        }
        public static ValueTask<object> SetMessage(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxToast_SetOption", dxTarget, "message", value);
        }
        public static ValueTask<string> GetType(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxToast_GetOption", dxTarget, "type");
        }
        public static ValueTask<object> SetType(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxToast_SetOption", dxTarget, "type", value);
        }
    }
    public class DxToolbarInterop: CollectionWidgetInterop
    {
        public static ValueTask<object> Init(ElementReference dxTarget, DevExpress.Ui.DxToolbarOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxToolbar_Init", dxTarget, json);
        }
        public static ValueTask<object> GetMenuItemTemplate(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxToolbar_GetOption", dxTarget, "menuItemTemplate");
        }
        public static ValueTask<object> SetMenuItemTemplate(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxToolbar_SetOption", dxTarget, "menuItemTemplate", value);
        }
        public static ValueTask<string> GetRenderAs(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxToolbar_GetOption", dxTarget, "renderAs");
        }
        public static ValueTask<object> SetRenderAs(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxToolbar_SetOption", dxTarget, "renderAs", value);
        }
    }
    public class DxTooltipInterop: DxPopoverInterop
    {
        public static ValueTask<object> Init(ElementReference dxTarget, DevExpress.Ui.DxTooltipOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTooltip_Init", dxTarget, json);
        }
    }
    public class DxTrackBarInterop: EditorInterop
    {
        public static ValueTask<object> Init(ElementReference dxTarget, DevExpress.Ui.DxTrackBarOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTrackBar_Init", dxTarget, json);
        }
        public static ValueTask<float?> GetMax(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_DxTrackBar_GetOption", dxTarget, "max");
        }
        public static ValueTask<object> SetMax(ElementReference dxTarget, float? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTrackBar_SetOption", dxTarget, "max", value);
        }
        public static ValueTask<float?> GetMin(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_DxTrackBar_GetOption", dxTarget, "min");
        }
        public static ValueTask<object> SetMin(ElementReference dxTarget, float? value)
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
        public static ValueTask<object> Init(ElementReference dxTarget, DevExpress.Ui.DxTreeListOptions options)
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
        public static ValueTask<bool?> GetAutoExpandAll(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxTreeList_GetOption", dxTarget, "autoExpandAll");
        }
        public static ValueTask<object> SetAutoExpandAll(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeList_SetOption", dxTarget, "autoExpandAll", value);
        }
        public static ValueTask<object> GetCustomizeColumns(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeList_GetOption", dxTarget, "customizeColumns");
        }
        public static ValueTask<object> SetCustomizeColumns(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeList_SetOption", dxTarget, "customizeColumns", value);
        }
        public static ValueTask<string> GetDataStructure(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxTreeList_GetOption", dxTarget, "dataStructure");
        }
        public static ValueTask<object> SetDataStructure(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeList_SetOption", dxTarget, "dataStructure", value);
        }
        public static ValueTask<object> GetExpandedRowKeys(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeList_GetOption", dxTarget, "expandedRowKeys");
        }
        public static ValueTask<object> SetExpandedRowKeys(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeList_SetOption", dxTarget, "expandedRowKeys", value);
        }
        public static ValueTask<bool?> GetExpandNodesOnFiltering(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxTreeList_GetOption", dxTarget, "expandNodesOnFiltering");
        }
        public static ValueTask<object> SetExpandNodesOnFiltering(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeList_SetOption", dxTarget, "expandNodesOnFiltering", value);
        }
        public static ValueTask<object> GetHasItemsExpr(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeList_GetOption", dxTarget, "hasItemsExpr");
        }
        public static ValueTask<object> SetHasItemsExpr(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeList_SetOption", dxTarget, "hasItemsExpr", value);
        }
        public static ValueTask<object> GetItemsExpr(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeList_GetOption", dxTarget, "itemsExpr");
        }
        public static ValueTask<object> SetItemsExpr(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeList_SetOption", dxTarget, "itemsExpr", value);
        }
        public static ValueTask<object> GetKeyExpr(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeList_GetOption", dxTarget, "keyExpr");
        }
        public static ValueTask<object> SetKeyExpr(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeList_SetOption", dxTarget, "keyExpr", value);
        }
        public static ValueTask<object> GetParentIdExpr(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeList_GetOption", dxTarget, "parentIdExpr");
        }
        public static ValueTask<object> SetParentIdExpr(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeList_SetOption", dxTarget, "parentIdExpr", value);
        }
        public static ValueTask<object> GetRemoteOperations(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeList_GetOption", dxTarget, "remoteOperations");
        }
        public static ValueTask<object> SetRemoteOperations(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeList_SetOption", dxTarget, "remoteOperations", value);
        }
        public static ValueTask<object> GetRootValue(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeList_GetOption", dxTarget, "rootValue");
        }
        public static ValueTask<object> SetRootValue(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeList_SetOption", dxTarget, "rootValue", value);
        }
        public static ValueTask<object> AddColumn(ElementReference dxTarget, object columnOptions)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeList_addColumn_0", dxTarget, columnOptions);
        }
        public static ValueTask<object> AddRow(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeList_addRow_1", dxTarget);
        }
        public static ValueTask<object> AddRow(ElementReference dxTarget, object parentId)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeList_addRow_2", dxTarget, parentId);
        }
        public static ValueTask<object> CollapseRow(ElementReference dxTarget, object key)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeList_collapseRow_3", dxTarget, key);
        }
        public static ValueTask<object> ExpandRow(ElementReference dxTarget, object key)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeList_expandRow_4", dxTarget, key);
        }
        public static ValueTask<object> ForEachNode(ElementReference dxTarget, object callback)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeList_forEachNode_5", dxTarget, callback);
        }
        public static ValueTask<object> ForEachNode(ElementReference dxTarget, object nodes, object callback)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeList_forEachNode_6", dxTarget, nodes, callback);
        }
        public static ValueTask<object> GetNodeByKey(ElementReference dxTarget, object key)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeList_getNodeByKey_7", dxTarget, key);
        }
        public static ValueTask<object> GetRootNode(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeList_getRootNode_8", dxTarget);
        }
        public static ValueTask<object> GetSelectedRowKeys(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeList_getSelectedRowKeys_9", dxTarget);
        }
        public static ValueTask<object> GetSelectedRowKeys(ElementReference dxTarget, bool leavesOnly)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeList_getSelectedRowKeys_10", dxTarget, leavesOnly);
        }
        public static ValueTask<object> GetSelectedRowKeys(ElementReference dxTarget, string mode)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeList_getSelectedRowKeys_11", dxTarget, mode);
        }
        public static ValueTask<object> GetSelectedRowsData(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeList_getSelectedRowsData_12", dxTarget);
        }
        public static ValueTask<object> GetVisibleColumns(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeList_getVisibleColumns_13", dxTarget);
        }
        public static ValueTask<object> GetVisibleColumns(ElementReference dxTarget, float headerLevel)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeList_getVisibleColumns_14", dxTarget, headerLevel);
        }
        public static ValueTask<object> GetVisibleRows(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeList_getVisibleRows_15", dxTarget);
        }
        public static ValueTask<bool> IsRowExpanded(ElementReference dxTarget, object key)
        {
            return JSRuntime.Current.InvokeAsync<bool>("BlazorDevExtreme_DxTreeList_isRowExpanded_16", dxTarget, key);
        }
        public static ValueTask<object> LoadDescendants(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeList_loadDescendants_17", dxTarget);
        }
        public static ValueTask<object> LoadDescendants(ElementReference dxTarget, object keys)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeList_loadDescendants_18", dxTarget, keys);
        }
        public static ValueTask<object> LoadDescendants(ElementReference dxTarget, object keys, bool childrenOnly)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeList_loadDescendants_19", dxTarget, keys, childrenOnly);
        }
    }
    public class DxTreeViewInterop: HierarchicalCollectionWidgetInterop
    {
        public static event EventHandler<JQueryEventArgs> ItemCollapsed;
        public static event EventHandler<JQueryEventArgs> ItemExpanded;
        public static event EventHandler<JQueryEventArgs> ItemSelectionChanged;
        public static ValueTask<object> Init(ElementReference dxTarget, DevExpress.Ui.DxTreeViewOptions options)
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
        public static ValueTask<bool?> GetAnimationEnabled(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxTreeView_GetOption", dxTarget, "animationEnabled");
        }
        public static ValueTask<object> SetAnimationEnabled(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeView_SetOption", dxTarget, "animationEnabled", value);
        }
        public static ValueTask<object> GetCreateChildren(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeView_GetOption", dxTarget, "createChildren");
        }
        public static ValueTask<object> SetCreateChildren(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeView_SetOption", dxTarget, "createChildren", value);
        }
        public static ValueTask<string> GetDataStructure(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxTreeView_GetOption", dxTarget, "dataStructure");
        }
        public static ValueTask<object> SetDataStructure(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeView_SetOption", dxTarget, "dataStructure", value);
        }
        public static ValueTask<bool?> GetExpandAllEnabled(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxTreeView_GetOption", dxTarget, "expandAllEnabled");
        }
        public static ValueTask<object> SetExpandAllEnabled(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeView_SetOption", dxTarget, "expandAllEnabled", value);
        }
        public static ValueTask<object> GetExpandedExpr(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeView_GetOption", dxTarget, "expandedExpr");
        }
        public static ValueTask<object> SetExpandedExpr(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeView_SetOption", dxTarget, "expandedExpr", value);
        }
        public static ValueTask<bool?> GetExpandNodesRecursive(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxTreeView_GetOption", dxTarget, "expandNodesRecursive");
        }
        public static ValueTask<object> SetExpandNodesRecursive(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeView_SetOption", dxTarget, "expandNodesRecursive", value);
        }
        public static ValueTask<object> GetHasItemsExpr(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeView_GetOption", dxTarget, "hasItemsExpr");
        }
        public static ValueTask<object> SetHasItemsExpr(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeView_SetOption", dxTarget, "hasItemsExpr", value);
        }
        public static ValueTask<object> GetParentIdExpr(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeView_GetOption", dxTarget, "parentIdExpr");
        }
        public static ValueTask<object> SetParentIdExpr(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeView_SetOption", dxTarget, "parentIdExpr", value);
        }
        public static ValueTask<object> GetRootValue(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeView_GetOption", dxTarget, "rootValue");
        }
        public static ValueTask<object> SetRootValue(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeView_SetOption", dxTarget, "rootValue", value);
        }
        public static ValueTask<string> GetScrollDirection(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxTreeView_GetOption", dxTarget, "scrollDirection");
        }
        public static ValueTask<object> SetScrollDirection(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeView_SetOption", dxTarget, "scrollDirection", value);
        }
        public static ValueTask<string> GetSelectAllText(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxTreeView_GetOption", dxTarget, "selectAllText");
        }
        public static ValueTask<object> SetSelectAllText(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeView_SetOption", dxTarget, "selectAllText", value);
        }
        public static ValueTask<bool?> GetSelectByClick(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxTreeView_GetOption", dxTarget, "selectByClick");
        }
        public static ValueTask<object> SetSelectByClick(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeView_SetOption", dxTarget, "selectByClick", value);
        }
        public static ValueTask<string> GetSelectionMode(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxTreeView_GetOption", dxTarget, "selectionMode");
        }
        public static ValueTask<object> SetSelectionMode(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeView_SetOption", dxTarget, "selectionMode", value);
        }
        public static ValueTask<bool?> GetSelectNodesRecursive(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxTreeView_GetOption", dxTarget, "selectNodesRecursive");
        }
        public static ValueTask<object> SetSelectNodesRecursive(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeView_SetOption", dxTarget, "selectNodesRecursive", value);
        }
        public static ValueTask<string> GetShowCheckBoxesMode(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxTreeView_GetOption", dxTarget, "showCheckBoxesMode");
        }
        public static ValueTask<object> SetShowCheckBoxesMode(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeView_SetOption", dxTarget, "showCheckBoxesMode", value);
        }
        public static ValueTask<bool?> GetVirtualModeEnabled(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxTreeView_GetOption", dxTarget, "virtualModeEnabled");
        }
        public static ValueTask<object> SetVirtualModeEnabled(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeView_SetOption", dxTarget, "virtualModeEnabled", value);
        }
        public static ValueTask<object> GetSearchEditorOptions(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeView_GetOption", dxTarget, "searchEditorOptions");
        }
        public static ValueTask<object> SetSearchEditorOptions(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeView_SetOption", dxTarget, "searchEditorOptions", value);
        }
        public static ValueTask<bool?> GetSearchEnabled(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxTreeView_GetOption", dxTarget, "searchEnabled");
        }
        public static ValueTask<object> SetSearchEnabled(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeView_SetOption", dxTarget, "searchEnabled", value);
        }
        public static ValueTask<object> GetSearchExpr(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeView_GetOption", dxTarget, "searchExpr");
        }
        public static ValueTask<object> SetSearchExpr(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeView_SetOption", dxTarget, "searchExpr", value);
        }
        public static ValueTask<string> GetSearchMode(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxTreeView_GetOption", dxTarget, "searchMode");
        }
        public static ValueTask<object> SetSearchMode(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeView_SetOption", dxTarget, "searchMode", value);
        }
        public static ValueTask<float?> GetSearchTimeout(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_DxTreeView_GetOption", dxTarget, "searchTimeout");
        }
        public static ValueTask<object> SetSearchTimeout(ElementReference dxTarget, float? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeView_SetOption", dxTarget, "searchTimeout", value);
        }
        public static ValueTask<string> GetSearchValue(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxTreeView_GetOption", dxTarget, "searchValue");
        }
        public static ValueTask<object> SetSearchValue(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeView_SetOption", dxTarget, "searchValue", value);
        }
        public static ValueTask<object> CollapseItem(ElementReference dxTarget, object itemData)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeView_collapseItem_0", dxTarget, itemData);
        }
        public static ValueTask<object> ExpandItem(ElementReference dxTarget, object itemData)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeView_expandItem_3", dxTarget, itemData);
        }
        public static ValueTask<object> GetNodes(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeView_getNodes_6", dxTarget);
        }
        public static ValueTask<object> SelectAll(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeView_selectAll_7", dxTarget);
        }
        public static ValueTask<object> SelectItem(ElementReference dxTarget, object itemData)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeView_selectItem_8", dxTarget, itemData);
        }
        public static ValueTask<object> UnselectAll(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeView_unselectAll_11", dxTarget);
        }
        public static ValueTask<object> UnselectItem(ElementReference dxTarget, object itemData)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeView_unselectItem_12", dxTarget, itemData);
        }
        public static ValueTask<object> UpdateDimensions(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeView_updateDimensions_15", dxTarget);
        }
    }
    public class DxValidationGroupInterop: DOMComponentInterop
    {
        public static ValueTask<object> Init(ElementReference dxTarget, DevExpress.Ui.DxValidationGroupOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxValidationGroup_Init", dxTarget, json);
        }
        public static ValueTask<object> Reset(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxValidationGroup_reset_0", dxTarget);
        }
        public static ValueTask<object> Validate(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxValidationGroup_validate_1", dxTarget);
        }
    }
    public class DxValidationSummaryInterop: CollectionWidgetInterop
    {
        public static ValueTask<object> Init(ElementReference dxTarget, DevExpress.Ui.DxValidationSummaryOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxValidationSummary_Init", dxTarget, json);
        }
        public static ValueTask<string> GetValidationGroup(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxValidationSummary_GetOption", dxTarget, "validationGroup");
        }
        public static ValueTask<object> SetValidationGroup(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxValidationSummary_SetOption", dxTarget, "validationGroup", value);
        }
    }
    public class DxValidatorInterop: DOMComponentInterop
    {
        public static event EventHandler<JQueryEventArgs> Validated;
        public static ValueTask<object> Init(ElementReference dxTarget, DevExpress.Ui.DxValidatorOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxValidator_Init", dxTarget, json);
        }
        [JSInvokable("DevExpress.Ui.DxValidatorInterop.OnValidated")]
        public static void OnValidated(string identifier)
        {
            Validated?.Invoke(null, new JQueryEventArgs(identifier));
        }
        public static ValueTask<object> GetAdapter(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxValidator_GetOption", dxTarget, "adapter");
        }
        public static ValueTask<object> SetAdapter(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxValidator_SetOption", dxTarget, "adapter", value);
        }
        public static ValueTask<string> GetName(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxValidator_GetOption", dxTarget, "name");
        }
        public static ValueTask<object> SetName(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxValidator_SetOption", dxTarget, "name", value);
        }
        public static ValueTask<string> GetValidationGroup(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxValidator_GetOption", dxTarget, "validationGroup");
        }
        public static ValueTask<object> SetValidationGroup(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxValidator_SetOption", dxTarget, "validationGroup", value);
        }
        public static ValueTask<object> GetValidationRules(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxValidator_GetOption", dxTarget, "validationRules");
        }
        public static ValueTask<object> SetValidationRules(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxValidator_SetOption", dxTarget, "validationRules", value);
        }
        public static ValueTask<object> Focus(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxValidator_focus_0", dxTarget);
        }
        public static ValueTask<object> Reset(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxValidator_reset_1", dxTarget);
        }
        public static ValueTask<object> Validate(ElementReference dxTarget)
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
        public static ValueTask<object> Init(ElementReference dxTarget, DevExpress.Ui.CollectionWidgetOptions options)
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
        public static ValueTask<object> GetDataSource(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_CollectionWidget_GetOption", dxTarget, "dataSource");
        }
        public static ValueTask<object> SetDataSource(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_CollectionWidget_SetOption", dxTarget, "dataSource", value);
        }
        public static ValueTask<float?> GetItemHoldTimeout(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_CollectionWidget_GetOption", dxTarget, "itemHoldTimeout");
        }
        public static ValueTask<object> SetItemHoldTimeout(ElementReference dxTarget, float? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_CollectionWidget_SetOption", dxTarget, "itemHoldTimeout", value);
        }
        public static ValueTask<object> GetItems(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_CollectionWidget_GetOption", dxTarget, "items");
        }
        public static ValueTask<object> SetItems(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_CollectionWidget_SetOption", dxTarget, "items", value);
        }
        public static ValueTask<object> GetItemTemplate(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_CollectionWidget_GetOption", dxTarget, "itemTemplate");
        }
        public static ValueTask<object> SetItemTemplate(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_CollectionWidget_SetOption", dxTarget, "itemTemplate", value);
        }
        public static ValueTask<object> GetKeyExpr(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_CollectionWidget_GetOption", dxTarget, "keyExpr");
        }
        public static ValueTask<object> SetKeyExpr(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_CollectionWidget_SetOption", dxTarget, "keyExpr", value);
        }
        public static ValueTask<string> GetNoDataText(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_CollectionWidget_GetOption", dxTarget, "noDataText");
        }
        public static ValueTask<object> SetNoDataText(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_CollectionWidget_SetOption", dxTarget, "noDataText", value);
        }
        public static ValueTask<float?> GetSelectedIndex(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_CollectionWidget_GetOption", dxTarget, "selectedIndex");
        }
        public static ValueTask<object> SetSelectedIndex(ElementReference dxTarget, float? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_CollectionWidget_SetOption", dxTarget, "selectedIndex", value);
        }
        public static ValueTask<object> GetSelectedItem(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_CollectionWidget_GetOption", dxTarget, "selectedItem");
        }
        public static ValueTask<object> SetSelectedItem(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_CollectionWidget_SetOption", dxTarget, "selectedItem", value);
        }
        public static ValueTask<object> GetSelectedItemKeys(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_CollectionWidget_GetOption", dxTarget, "selectedItemKeys");
        }
        public static ValueTask<object> SetSelectedItemKeys(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_CollectionWidget_SetOption", dxTarget, "selectedItemKeys", value);
        }
        public static ValueTask<object> GetSelectedItems(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_CollectionWidget_GetOption", dxTarget, "selectedItems");
        }
        public static ValueTask<object> SetSelectedItems(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_CollectionWidget_SetOption", dxTarget, "selectedItems", value);
        }
        public static ValueTask<object> GetDataSourceEx(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_CollectionWidget_getDataSource_0", dxTarget);
        }
    }
    public class DxMenuBaseInterop: HierarchicalCollectionWidgetInterop
    {
        public static ValueTask<object> Init(ElementReference dxTarget, DevExpress.Ui.DxMenuBaseOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxMenuBase_Init", dxTarget, json);
        }
        public static ValueTask<object> GetAnimation(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxMenuBase_GetOption", dxTarget, "animation");
        }
        public static ValueTask<object> SetAnimation(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxMenuBase_SetOption", dxTarget, "animation", value);
        }
        public static ValueTask<string> GetCssClass(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxMenuBase_GetOption", dxTarget, "cssClass");
        }
        public static ValueTask<object> SetCssClass(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxMenuBase_SetOption", dxTarget, "cssClass", value);
        }
        public static ValueTask<bool?> GetSelectByClick(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxMenuBase_GetOption", dxTarget, "selectByClick");
        }
        public static ValueTask<object> SetSelectByClick(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxMenuBase_SetOption", dxTarget, "selectByClick", value);
        }
        public static ValueTask<string> GetSelectionMode(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxMenuBase_GetOption", dxTarget, "selectionMode");
        }
        public static ValueTask<object> SetSelectionMode(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxMenuBase_SetOption", dxTarget, "selectionMode", value);
        }
        public static ValueTask<object> GetShowSubmenuMode(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxMenuBase_GetOption", dxTarget, "showSubmenuMode");
        }
        public static ValueTask<object> SetShowSubmenuMode(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxMenuBase_SetOption", dxTarget, "showSubmenuMode", value);
        }
        public static ValueTask<object> SelectItem(ElementReference dxTarget, object itemElement)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxMenuBase_selectItem_0", dxTarget, itemElement);
        }
        public static ValueTask<object> UnselectItem(ElementReference dxTarget, object itemElement)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxMenuBase_unselectItem_1", dxTarget, itemElement);
        }
    }
    public class DxDropDownEditorInterop: DxTextBoxInterop
    {
        public static event EventHandler<JQueryEventArgs> Closed;
        public static event EventHandler<JQueryEventArgs> Opened;
        public static ValueTask<object> Init(ElementReference dxTarget, DevExpress.Ui.DxDropDownEditorOptions options)
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
        public static ValueTask<bool?> GetAcceptCustomValue(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxDropDownEditor_GetOption", dxTarget, "acceptCustomValue");
        }
        public static ValueTask<object> SetAcceptCustomValue(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDropDownEditor_SetOption", dxTarget, "acceptCustomValue", value);
        }
        public static ValueTask<string> GetApplyValueMode(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxDropDownEditor_GetOption", dxTarget, "applyValueMode");
        }
        public static ValueTask<object> SetApplyValueMode(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDropDownEditor_SetOption", dxTarget, "applyValueMode", value);
        }
        public static ValueTask<bool?> GetDeferRendering(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxDropDownEditor_GetOption", dxTarget, "deferRendering");
        }
        public static ValueTask<object> SetDeferRendering(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDropDownEditor_SetOption", dxTarget, "deferRendering", value);
        }
        public static ValueTask<object> GetDropDownButtonTemplate(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDropDownEditor_GetOption", dxTarget, "dropDownButtonTemplate");
        }
        public static ValueTask<object> SetDropDownButtonTemplate(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDropDownEditor_SetOption", dxTarget, "dropDownButtonTemplate", value);
        }
        public static ValueTask<bool?> GetOpened(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxDropDownEditor_GetOption", dxTarget, "opened");
        }
        public static ValueTask<object> SetOpened(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDropDownEditor_SetOption", dxTarget, "opened", value);
        }
        public static ValueTask<object> Close(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDropDownEditor_close_0", dxTarget);
        }
        public static ValueTask<object> Content(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDropDownEditor_content_1", dxTarget);
        }
        public static ValueTask<object> Field(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDropDownEditor_field_2", dxTarget);
        }
        public static ValueTask<object> Open(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDropDownEditor_open_3", dxTarget);
        }
        public static ValueTask<object> Reset(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDropDownEditor_reset_4", dxTarget);
        }
    }
    public class DxDropDownListInterop: DxDropDownEditorInterop
    {
        public static event EventHandler<JQueryEventArgs> ItemClick;
        public static event EventHandler<JQueryEventArgs> SelectionChanged;
        public static ValueTask<object> Init(ElementReference dxTarget, DevExpress.Ui.DxDropDownListOptions options)
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
        public static ValueTask<string> GetDisplayValue(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxDropDownList_GetOption", dxTarget, "displayValue");
        }
        public static ValueTask<object> SetDisplayValue(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDropDownList_SetOption", dxTarget, "displayValue", value);
        }
        public static ValueTask<bool?> GetGrouped(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxDropDownList_GetOption", dxTarget, "grouped");
        }
        public static ValueTask<object> SetGrouped(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDropDownList_SetOption", dxTarget, "grouped", value);
        }
        public static ValueTask<object> GetGroupTemplate(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDropDownList_GetOption", dxTarget, "groupTemplate");
        }
        public static ValueTask<object> SetGroupTemplate(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDropDownList_SetOption", dxTarget, "groupTemplate", value);
        }
        public static ValueTask<float?> GetMinSearchLength(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_DxDropDownList_GetOption", dxTarget, "minSearchLength");
        }
        public static ValueTask<object> SetMinSearchLength(ElementReference dxTarget, float? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDropDownList_SetOption", dxTarget, "minSearchLength", value);
        }
        public static ValueTask<string> GetNoDataText(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxDropDownList_GetOption", dxTarget, "noDataText");
        }
        public static ValueTask<object> SetNoDataText(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDropDownList_SetOption", dxTarget, "noDataText", value);
        }
        public static ValueTask<bool?> GetSearchEnabled(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxDropDownList_GetOption", dxTarget, "searchEnabled");
        }
        public static ValueTask<object> SetSearchEnabled(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDropDownList_SetOption", dxTarget, "searchEnabled", value);
        }
        public static ValueTask<object> GetSearchExpr(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDropDownList_GetOption", dxTarget, "searchExpr");
        }
        public static ValueTask<object> SetSearchExpr(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDropDownList_SetOption", dxTarget, "searchExpr", value);
        }
        public static ValueTask<string> GetSearchMode(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxDropDownList_GetOption", dxTarget, "searchMode");
        }
        public static ValueTask<object> SetSearchMode(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDropDownList_SetOption", dxTarget, "searchMode", value);
        }
        public static ValueTask<float?> GetSearchTimeout(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_DxDropDownList_GetOption", dxTarget, "searchTimeout");
        }
        public static ValueTask<object> SetSearchTimeout(ElementReference dxTarget, float? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDropDownList_SetOption", dxTarget, "searchTimeout", value);
        }
        public static ValueTask<object> GetSelectedItem(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDropDownList_GetOption", dxTarget, "selectedItem");
        }
        public static ValueTask<object> SetSelectedItem(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDropDownList_SetOption", dxTarget, "selectedItem", value);
        }
        public static ValueTask<bool?> GetShowDataBeforeSearch(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxDropDownList_GetOption", dxTarget, "showDataBeforeSearch");
        }
        public static ValueTask<object> SetShowDataBeforeSearch(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDropDownList_SetOption", dxTarget, "showDataBeforeSearch", value);
        }
        public static ValueTask<object> GetDataSource(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDropDownList_GetOption", dxTarget, "dataSource");
        }
        public static ValueTask<object> SetDataSource(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDropDownList_SetOption", dxTarget, "dataSource", value);
        }
        public static ValueTask<object> GetDisplayExpr(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDropDownList_GetOption", dxTarget, "displayExpr");
        }
        public static ValueTask<object> SetDisplayExpr(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDropDownList_SetOption", dxTarget, "displayExpr", value);
        }
        public static ValueTask<object> GetItems(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDropDownList_GetOption", dxTarget, "items");
        }
        public static ValueTask<object> SetItems(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDropDownList_SetOption", dxTarget, "items", value);
        }
        public static ValueTask<object> GetItemTemplate(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDropDownList_GetOption", dxTarget, "itemTemplate");
        }
        public static ValueTask<object> SetItemTemplate(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDropDownList_SetOption", dxTarget, "itemTemplate", value);
        }
        public static ValueTask<object> GetValueExpr(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDropDownList_GetOption", dxTarget, "valueExpr");
        }
        public static ValueTask<object> SetValueExpr(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDropDownList_SetOption", dxTarget, "valueExpr", value);
        }
        public static ValueTask<object> GetDataSourceEx(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxDropDownList_getDataSource_0", dxTarget);
        }
    }
    public class EditorInterop: WidgetInterop
    {
        public static event EventHandler<(JQueryEventArgs, string)> ValueChanged;

        public static ValueTask<object> Init(ElementReference dxTarget, DevExpress.Ui.EditorOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Editor_Init", dxTarget, json);
        }
        [JSInvokable("DevExpress.Ui.EditorInterop.OnValueChanged")]
        public static void OnValueChanged(string identifier, string value)
        {
            ValueChanged?.Invoke(null, (new JQueryEventArgs(identifier), value));
        }

        public static ValueTask<bool?> GetIsValid(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_Editor_GetOption", dxTarget, "isValid");
        }
        public static ValueTask<object> SetIsValid(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Editor_SetOption", dxTarget, "isValid", value);
        }
        public static ValueTask<bool?> GetReadOnly(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_Editor_GetOption", dxTarget, "readOnly");
        }
        public static ValueTask<object> SetReadOnly(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Editor_SetOption", dxTarget, "readOnly", value);
        }
        public static ValueTask<object> GetValidationError(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Editor_GetOption", dxTarget, "validationError");
        }
        public static ValueTask<object> SetValidationError(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Editor_SetOption", dxTarget, "validationError", value);
        }
        public static ValueTask<string> GetValidationMessageMode(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_Editor_GetOption", dxTarget, "validationMessageMode");
        }
        public static ValueTask<object> SetValidationMessageMode(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Editor_SetOption", dxTarget, "validationMessageMode", value);
        }
        public static ValueTask<object> GetValue(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Editor_GetOption", dxTarget, "value");
        }
        public static ValueTask<object> SetValue(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Editor_SetOption", dxTarget, "value", value);
        }
        public static ValueTask<object> Reset(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Editor_reset_0", dxTarget);
        }
    }
    public class DataExpressionMixinInterop
    {
        public static ValueTask<object> Init(ElementReference dxTarget, DevExpress.Ui.DataExpressionMixinOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DataExpressionMixin_Init", dxTarget, json);
        }
        public static ValueTask<object> GetDataSource(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DataExpressionMixin_GetOption", dxTarget, "dataSource");
        }
        public static ValueTask<object> SetDataSource(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DataExpressionMixin_SetOption", dxTarget, "dataSource", value);
        }
        public static ValueTask<object> GetDisplayExpr(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DataExpressionMixin_GetOption", dxTarget, "displayExpr");
        }
        public static ValueTask<object> SetDisplayExpr(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DataExpressionMixin_SetOption", dxTarget, "displayExpr", value);
        }
        public static ValueTask<object> GetItems(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DataExpressionMixin_GetOption", dxTarget, "items");
        }
        public static ValueTask<object> SetItems(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DataExpressionMixin_SetOption", dxTarget, "items", value);
        }
        public static ValueTask<object> GetItemTemplate(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DataExpressionMixin_GetOption", dxTarget, "itemTemplate");
        }
        public static ValueTask<object> SetItemTemplate(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DataExpressionMixin_SetOption", dxTarget, "itemTemplate", value);
        }
        public static ValueTask<object> GetValue(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DataExpressionMixin_GetOption", dxTarget, "value");
        }
        public static ValueTask<object> SetValue(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DataExpressionMixin_SetOption", dxTarget, "value", value);
        }
        public static ValueTask<object> GetValueExpr(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DataExpressionMixin_GetOption", dxTarget, "valueExpr");
        }
        public static ValueTask<object> SetValueExpr(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DataExpressionMixin_SetOption", dxTarget, "valueExpr", value);
        }
        public static ValueTask<object> GetDataSourceEx(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DataExpressionMixin_getDataSource_0", dxTarget);
        }
    }
    public class HierarchicalCollectionWidgetInterop: CollectionWidgetInterop
    {
        public static ValueTask<object> Init(ElementReference dxTarget, DevExpress.Ui.HierarchicalCollectionWidgetOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_HierarchicalCollectionWidget_Init", dxTarget, json);
        }
        public static ValueTask<object> GetDisabledExpr(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_HierarchicalCollectionWidget_GetOption", dxTarget, "disabledExpr");
        }
        public static ValueTask<object> SetDisabledExpr(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_HierarchicalCollectionWidget_SetOption", dxTarget, "disabledExpr", value);
        }
        public static ValueTask<object> GetDisplayExpr(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_HierarchicalCollectionWidget_GetOption", dxTarget, "displayExpr");
        }
        public static ValueTask<object> SetDisplayExpr(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_HierarchicalCollectionWidget_SetOption", dxTarget, "displayExpr", value);
        }
        public static ValueTask<object> GetItemsExpr(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_HierarchicalCollectionWidget_GetOption", dxTarget, "itemsExpr");
        }
        public static ValueTask<object> SetItemsExpr(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_HierarchicalCollectionWidget_SetOption", dxTarget, "itemsExpr", value);
        }
        public static ValueTask<object> GetSelectedExpr(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_HierarchicalCollectionWidget_GetOption", dxTarget, "selectedExpr");
        }
        public static ValueTask<object> SetSelectedExpr(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_HierarchicalCollectionWidget_SetOption", dxTarget, "selectedExpr", value);
        }
    }
    public class DxPivotGridSummaryCellInterop
    {
        public static ValueTask<object> Child(ElementReference dxTarget, string direction, object fieldValue)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPivotGridSummaryCell_child_0", dxTarget, direction, fieldValue);
        }
        public static ValueTask<object> Children(ElementReference dxTarget, string direction)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPivotGridSummaryCell_children_1", dxTarget, direction);
        }
        public static ValueTask<object> Field(ElementReference dxTarget, string area)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPivotGridSummaryCell_field_2", dxTarget, area);
        }
        public static ValueTask<object> GrandTotal(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPivotGridSummaryCell_grandTotal_3", dxTarget);
        }
        public static ValueTask<object> GrandTotal(ElementReference dxTarget, string direction)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPivotGridSummaryCell_grandTotal_4", dxTarget, direction);
        }
        public static ValueTask<object> Next(ElementReference dxTarget, string direction)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPivotGridSummaryCell_next_5", dxTarget, direction);
        }
        public static ValueTask<object> Next(ElementReference dxTarget, string direction, bool allowCrossGroup)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPivotGridSummaryCell_next_6", dxTarget, direction, allowCrossGroup);
        }
        public static ValueTask<object> Parent(ElementReference dxTarget, string direction)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPivotGridSummaryCell_parent_7", dxTarget, direction);
        }
        public static ValueTask<object> Prev(ElementReference dxTarget, string direction)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPivotGridSummaryCell_prev_8", dxTarget, direction);
        }
        public static ValueTask<object> Prev(ElementReference dxTarget, string direction, bool allowCrossGroup)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPivotGridSummaryCell_prev_9", dxTarget, direction, allowCrossGroup);
        }
        public static ValueTask<object> Slice(ElementReference dxTarget, object field, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPivotGridSummaryCell_slice_10", dxTarget, field, value);
        }
        public static ValueTask<object> ValueEx(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPivotGridSummaryCell_value_11", dxTarget);
        }
        public static ValueTask<object> ValueEx(ElementReference dxTarget, object field)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPivotGridSummaryCell_value_12", dxTarget, field);
        }
        public static ValueTask<object> ValueEx(ElementReference dxTarget, object field, bool isCalculatedValue)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPivotGridSummaryCell_value_13", dxTarget, field, isCalculatedValue);
        }
        public static ValueTask<object> ValueEx(ElementReference dxTarget, bool isCalculatedValue)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPivotGridSummaryCell_value_14", dxTarget, isCalculatedValue);
        }
    }
    public class DxScrollableInterop: DOMComponentInterop
    {
        public static event EventHandler<JQueryEventArgs> Scroll;
        public static event EventHandler<JQueryEventArgs> Updated;
        public static ValueTask<object> Init(ElementReference dxTarget, DevExpress.Ui.DxScrollableOptions options)
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
        public static ValueTask<bool?> GetBounceEnabled(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxScrollable_GetOption", dxTarget, "bounceEnabled");
        }
        public static ValueTask<object> SetBounceEnabled(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScrollable_SetOption", dxTarget, "bounceEnabled", value);
        }
        public static ValueTask<string> GetDirection(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxScrollable_GetOption", dxTarget, "direction");
        }
        public static ValueTask<object> SetDirection(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScrollable_SetOption", dxTarget, "direction", value);
        }
        public static ValueTask<bool?> GetDisabled(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxScrollable_GetOption", dxTarget, "disabled");
        }
        public static ValueTask<object> SetDisabled(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScrollable_SetOption", dxTarget, "disabled", value);
        }
        public static ValueTask<bool?> GetScrollByContent(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxScrollable_GetOption", dxTarget, "scrollByContent");
        }
        public static ValueTask<object> SetScrollByContent(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScrollable_SetOption", dxTarget, "scrollByContent", value);
        }
        public static ValueTask<bool?> GetScrollByThumb(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxScrollable_GetOption", dxTarget, "scrollByThumb");
        }
        public static ValueTask<object> SetScrollByThumb(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScrollable_SetOption", dxTarget, "scrollByThumb", value);
        }
        public static ValueTask<string> GetShowScrollbar(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxScrollable_GetOption", dxTarget, "showScrollbar");
        }
        public static ValueTask<object> SetShowScrollbar(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScrollable_SetOption", dxTarget, "showScrollbar", value);
        }
        public static ValueTask<bool?> GetUseNative(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxScrollable_GetOption", dxTarget, "useNative");
        }
        public static ValueTask<object> SetUseNative(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScrollable_SetOption", dxTarget, "useNative", value);
        }
        public static ValueTask<float> ClientHeight(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<float>("BlazorDevExtreme_DxScrollable_clientHeight_0", dxTarget);
        }
        public static ValueTask<float> ClientWidth(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<float>("BlazorDevExtreme_DxScrollable_clientWidth_1", dxTarget);
        }
        public static ValueTask<object> Content(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScrollable_content_2", dxTarget);
        }
        public static ValueTask<object> ScrollBy(ElementReference dxTarget, float distance)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScrollable_scrollBy_3", dxTarget, distance);
        }
        public static ValueTask<object> ScrollBy(ElementReference dxTarget, object distanceObject)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScrollable_scrollBy_4", dxTarget, distanceObject);
        }
        public static ValueTask<float> ScrollHeight(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<float>("BlazorDevExtreme_DxScrollable_scrollHeight_5", dxTarget);
        }
        public static ValueTask<float> ScrollLeft(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<float>("BlazorDevExtreme_DxScrollable_scrollLeft_6", dxTarget);
        }
        public static ValueTask<object> ScrollOffset(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScrollable_scrollOffset_7", dxTarget);
        }
        public static ValueTask<object> ScrollTo(ElementReference dxTarget, float targetLocation)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScrollable_scrollTo_8", dxTarget, targetLocation);
        }
        public static ValueTask<object> ScrollTo(ElementReference dxTarget, object targetLocation)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScrollable_scrollTo_9", dxTarget, targetLocation);
        }
        public static ValueTask<object> ScrollToElement(ElementReference dxTarget, object element)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScrollable_scrollToElement_10", dxTarget, element);
        }
        public static ValueTask<float> ScrollTop(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<float>("BlazorDevExtreme_DxScrollable_scrollTop_11", dxTarget);
        }
        public static ValueTask<float> ScrollWidth(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<float>("BlazorDevExtreme_DxScrollable_scrollWidth_12", dxTarget);
        }
        public static ValueTask<object> Update(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxScrollable_update_13", dxTarget);
        }
    }
    public class DxSliderBaseInterop: DxTrackBarInterop
    {
        public static ValueTask<object> Init(ElementReference dxTarget, DevExpress.Ui.DxSliderBaseOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxSliderBase_Init", dxTarget, json);
        }
        public static ValueTask<float?> GetKeyStep(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_DxSliderBase_GetOption", dxTarget, "keyStep");
        }
        public static ValueTask<object> SetKeyStep(ElementReference dxTarget, float? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxSliderBase_SetOption", dxTarget, "keyStep", value);
        }
        public static ValueTask<object> GetLabel(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxSliderBase_GetOption", dxTarget, "label");
        }
        public static ValueTask<object> SetLabel(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxSliderBase_SetOption", dxTarget, "label", value);
        }
        public static ValueTask<string> GetName(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxSliderBase_GetOption", dxTarget, "name");
        }
        public static ValueTask<object> SetName(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxSliderBase_SetOption", dxTarget, "name", value);
        }
        public static ValueTask<bool?> GetShowRange(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxSliderBase_GetOption", dxTarget, "showRange");
        }
        public static ValueTask<object> SetShowRange(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxSliderBase_SetOption", dxTarget, "showRange", value);
        }
        public static ValueTask<float?> GetStep(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_DxSliderBase_GetOption", dxTarget, "step");
        }
        public static ValueTask<object> SetStep(ElementReference dxTarget, float? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxSliderBase_SetOption", dxTarget, "step", value);
        }
        public static ValueTask<object> GetTooltip(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxSliderBase_GetOption", dxTarget, "tooltip");
        }
        public static ValueTask<object> SetTooltip(ElementReference dxTarget, object value)
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
        public static ValueTask<object> Init(ElementReference dxTarget, DevExpress.Ui.DxTextEditorOptions options)
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
        public static ValueTask<object> GetInputAttr(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTextEditor_GetOption", dxTarget, "inputAttr");
        }
        public static ValueTask<object> SetInputAttr(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTextEditor_SetOption", dxTarget, "inputAttr", value);
        }
        public static ValueTask<string> GetMask(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxTextEditor_GetOption", dxTarget, "mask");
        }
        public static ValueTask<object> SetMask(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTextEditor_SetOption", dxTarget, "mask", value);
        }
        public static ValueTask<string> GetMaskChar(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxTextEditor_GetOption", dxTarget, "maskChar");
        }
        public static ValueTask<object> SetMaskChar(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTextEditor_SetOption", dxTarget, "maskChar", value);
        }
        public static ValueTask<string> GetMaskInvalidMessage(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxTextEditor_GetOption", dxTarget, "maskInvalidMessage");
        }
        public static ValueTask<object> SetMaskInvalidMessage(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTextEditor_SetOption", dxTarget, "maskInvalidMessage", value);
        }
        public static ValueTask<object> GetMaskRules(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTextEditor_GetOption", dxTarget, "maskRules");
        }
        public static ValueTask<object> SetMaskRules(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTextEditor_SetOption", dxTarget, "maskRules", value);
        }
        public static ValueTask<string> GetName(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxTextEditor_GetOption", dxTarget, "name");
        }
        public static ValueTask<object> SetName(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTextEditor_SetOption", dxTarget, "name", value);
        }
        public static ValueTask<string> GetPlaceholder(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxTextEditor_GetOption", dxTarget, "placeholder");
        }
        public static ValueTask<object> SetPlaceholder(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTextEditor_SetOption", dxTarget, "placeholder", value);
        }
        public static ValueTask<bool?> GetShowClearButton(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxTextEditor_GetOption", dxTarget, "showClearButton");
        }
        public static ValueTask<object> SetShowClearButton(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTextEditor_SetOption", dxTarget, "showClearButton", value);
        }
        public static ValueTask<string> GetShowMaskMode(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxTextEditor_GetOption", dxTarget, "showMaskMode");
        }
        public static ValueTask<object> SetShowMaskMode(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTextEditor_SetOption", dxTarget, "showMaskMode", value);
        }
        public static ValueTask<bool?> GetSpellcheck(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxTextEditor_GetOption", dxTarget, "spellcheck");
        }
        public static ValueTask<object> SetSpellcheck(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTextEditor_SetOption", dxTarget, "spellcheck", value);
        }
        public static ValueTask<string> GetText(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxTextEditor_GetOption", dxTarget, "text");
        }
        public static ValueTask<object> SetText(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTextEditor_SetOption", dxTarget, "text", value);
        }
        public static ValueTask<bool?> GetUseMaskedValue(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxTextEditor_GetOption", dxTarget, "useMaskedValue");
        }
        public static ValueTask<object> SetUseMaskedValue(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTextEditor_SetOption", dxTarget, "useMaskedValue", value);
        }
        public static ValueTask<string> GetValueChangeEvent(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxTextEditor_GetOption", dxTarget, "valueChangeEvent");
        }
        public static ValueTask<object> SetValueChangeEvent(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTextEditor_SetOption", dxTarget, "valueChangeEvent", value);
        }
        public static ValueTask<object> Blur(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTextEditor_blur_0", dxTarget);
        }
        public static ValueTask<object> Focus(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTextEditor_focus_1", dxTarget);
        }
    }
    public class SearchBoxMixinInterop
    {
        public static ValueTask<object> Init(ElementReference dxTarget, DevExpress.Ui.SearchBoxMixinOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_SearchBoxMixin_Init", dxTarget, json);
        }
        public static ValueTask<object> GetSearchEditorOptions(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_SearchBoxMixin_GetOption", dxTarget, "searchEditorOptions");
        }
        public static ValueTask<object> SetSearchEditorOptions(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_SearchBoxMixin_SetOption", dxTarget, "searchEditorOptions", value);
        }
        public static ValueTask<bool?> GetSearchEnabled(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_SearchBoxMixin_GetOption", dxTarget, "searchEnabled");
        }
        public static ValueTask<object> SetSearchEnabled(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_SearchBoxMixin_SetOption", dxTarget, "searchEnabled", value);
        }
        public static ValueTask<object> GetSearchExpr(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_SearchBoxMixin_GetOption", dxTarget, "searchExpr");
        }
        public static ValueTask<object> SetSearchExpr(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_SearchBoxMixin_SetOption", dxTarget, "searchExpr", value);
        }
        public static ValueTask<string> GetSearchMode(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_SearchBoxMixin_GetOption", dxTarget, "searchMode");
        }
        public static ValueTask<object> SetSearchMode(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_SearchBoxMixin_SetOption", dxTarget, "searchMode", value);
        }
        public static ValueTask<float?> GetSearchTimeout(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_SearchBoxMixin_GetOption", dxTarget, "searchTimeout");
        }
        public static ValueTask<object> SetSearchTimeout(ElementReference dxTarget, float? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_SearchBoxMixin_SetOption", dxTarget, "searchTimeout", value);
        }
        public static ValueTask<string> GetSearchValue(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_SearchBoxMixin_GetOption", dxTarget, "searchValue");
        }
        public static ValueTask<object> SetSearchValue(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_SearchBoxMixin_SetOption", dxTarget, "searchValue", value);
        }
    }
    public class DxTemplateInterop
    {
        public static ValueTask<object> Init(ElementReference dxTarget, DevExpress.Ui.DxTemplateOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTemplate_Init", dxTarget, json);
        }
        public static ValueTask<string> GetName(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxTemplate_GetOption", dxTarget, "name");
        }
        public static ValueTask<object> SetName(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTemplate_SetOption", dxTarget, "name", value);
        }
    }
    public class WidgetInterop: DOMComponentInterop
    {
        public static event EventHandler<JQueryEventArgs> ContentReady;
        public static ValueTask<object> Init(ElementReference dxTarget, DevExpress.Ui.WidgetOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Widget_Init", dxTarget, json);
        }
        [JSInvokable("DevExpress.Ui.WidgetInterop.OnContentReady")]
        public static void OnContentReady(string identifier)
        {
            ContentReady?.Invoke(null, new JQueryEventArgs(identifier));
        }
        public static ValueTask<string> GetAccessKey(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_Widget_GetOption", dxTarget, "accessKey");
        }
        public static ValueTask<object> SetAccessKey(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Widget_SetOption", dxTarget, "accessKey", value);
        }
        public static ValueTask<bool?> GetActiveStateEnabled(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_Widget_GetOption", dxTarget, "activeStateEnabled");
        }
        public static ValueTask<object> SetActiveStateEnabled(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Widget_SetOption", dxTarget, "activeStateEnabled", value);
        }
        public static ValueTask<bool?> GetDisabled(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_Widget_GetOption", dxTarget, "disabled");
        }
        public static ValueTask<object> SetDisabled(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Widget_SetOption", dxTarget, "disabled", value);
        }
        public static ValueTask<bool?> GetFocusStateEnabled(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_Widget_GetOption", dxTarget, "focusStateEnabled");
        }
        public static ValueTask<object> SetFocusStateEnabled(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Widget_SetOption", dxTarget, "focusStateEnabled", value);
        }
        public static ValueTask<string> GetHint(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_Widget_GetOption", dxTarget, "hint");
        }
        public static ValueTask<object> SetHint(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Widget_SetOption", dxTarget, "hint", value);
        }
        public static ValueTask<bool?> GetHoverStateEnabled(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_Widget_GetOption", dxTarget, "hoverStateEnabled");
        }
        public static ValueTask<object> SetHoverStateEnabled(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Widget_SetOption", dxTarget, "hoverStateEnabled", value);
        }
        public static ValueTask<float?> GetTabIndex(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_Widget_GetOption", dxTarget, "tabIndex");
        }
        public static ValueTask<object> SetTabIndex(ElementReference dxTarget, float? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Widget_SetOption", dxTarget, "tabIndex", value);
        }
        public static ValueTask<bool?> GetVisible(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_Widget_GetOption", dxTarget, "visible");
        }
        public static ValueTask<object> SetVisible(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Widget_SetOption", dxTarget, "visible", value);
        }
        public static ValueTask<object> Focus(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Widget_focus_0", dxTarget);
        }
        public static ValueTask<object> RegisterKeyHandler(ElementReference dxTarget, string key, object handler)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Widget_registerKeyHandler_1", dxTarget, key, handler);
        }
        public static ValueTask<object> Repaint(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Widget_repaint_2", dxTarget);
        }
    }
    public class DialogInterop
    {
        public static ValueTask<object> Alert(string message, string title)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Dialog_alert_0", message, title);
        }
        public static ValueTask<object> Confirm(string message, string title)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Dialog_confirm_1", message, title);
        }
        public static ValueTask<object> Custom(object options)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Dialog_custom_2", options);
        }
    }
    public class ThemesInterop
    {
        public static ValueTask<string> Current()
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_Themes_current_0");
        }
        public static ValueTask<object> Current(string themeName)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Themes_current_1", themeName);
        }
        public static ValueTask<object> Ready(object callback)
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
        public static ValueTask<object> Init(ElementReference dxTarget, DevExpress.Viz.BaseWidgetOptions options)
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
        public static ValueTask<object> GetExport(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BaseWidget_GetOption", dxTarget, "export");
        }
        public static ValueTask<object> SetExport(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BaseWidget_SetOption", dxTarget, "export", value);
        }
        public static ValueTask<object> GetLoadingIndicator(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BaseWidget_GetOption", dxTarget, "loadingIndicator");
        }
        public static ValueTask<object> SetLoadingIndicator(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BaseWidget_SetOption", dxTarget, "loadingIndicator", value);
        }
        public static ValueTask<object> GetMargin(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BaseWidget_GetOption", dxTarget, "margin");
        }
        public static ValueTask<object> SetMargin(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BaseWidget_SetOption", dxTarget, "margin", value);
        }
        public static ValueTask<bool?> GetPathModified(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_BaseWidget_GetOption", dxTarget, "pathModified");
        }
        public static ValueTask<object> SetPathModified(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BaseWidget_SetOption", dxTarget, "pathModified", value);
        }
        public static ValueTask<bool?> GetRedrawOnResize(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_BaseWidget_GetOption", dxTarget, "redrawOnResize");
        }
        public static ValueTask<object> SetRedrawOnResize(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BaseWidget_SetOption", dxTarget, "redrawOnResize", value);
        }
        public static ValueTask<object> GetSize(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BaseWidget_GetOption", dxTarget, "size");
        }
        public static ValueTask<object> SetSize(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BaseWidget_SetOption", dxTarget, "size", value);
        }
        public static ValueTask<string> GetTheme(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_BaseWidget_GetOption", dxTarget, "theme");
        }
        public static ValueTask<object> SetTheme(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BaseWidget_SetOption", dxTarget, "theme", value);
        }
        public static ValueTask<object> GetTitle(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BaseWidget_GetOption", dxTarget, "title");
        }
        public static ValueTask<object> SetTitle(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BaseWidget_SetOption", dxTarget, "title", value);
        }
        public static ValueTask<object> GetTooltip(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BaseWidget_GetOption", dxTarget, "tooltip");
        }
        public static ValueTask<object> SetTooltip(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BaseWidget_SetOption", dxTarget, "tooltip", value);
        }
        public static ValueTask<object> ExportTo(ElementReference dxTarget, string fileName, string format)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BaseWidget_exportTo_0", dxTarget, fileName, format);
        }
        public static ValueTask<object> GetSizeEx(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BaseWidget_getSize_1", dxTarget);
        }
        public static ValueTask<object> HideLoadingIndicator(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BaseWidget_hideLoadingIndicator_2", dxTarget);
        }
        public static ValueTask<object> Print(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BaseWidget_print_3", dxTarget);
        }
        public static ValueTask<object> Render(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BaseWidget_render_4", dxTarget);
        }
        public static ValueTask<object> ShowLoadingIndicator(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BaseWidget_showLoadingIndicator_5", dxTarget);
        }
        public static ValueTask<string> Svg(ElementReference dxTarget)
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
        public static ValueTask<object> Init(ElementReference dxTarget, DevExpress.Viz.Charts.DxChartOptions options)
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
        public static ValueTask<bool?> GetAdjustOnZoom(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxChart_GetOption", dxTarget, "adjustOnZoom");
        }
        public static ValueTask<object> SetAdjustOnZoom(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxChart_SetOption", dxTarget, "adjustOnZoom", value);
        }
        public static ValueTask<object> GetArgumentAxis(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxChart_GetOption", dxTarget, "argumentAxis");
        }
        public static ValueTask<object> SetArgumentAxis(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxChart_SetOption", dxTarget, "argumentAxis", value);
        }
        public static ValueTask<float?> GetBarGroupPadding(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_DxChart_GetOption", dxTarget, "barGroupPadding");
        }
        public static ValueTask<object> SetBarGroupPadding(ElementReference dxTarget, float? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxChart_SetOption", dxTarget, "barGroupPadding", value);
        }
        public static ValueTask<float?> GetBarGroupWidth(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_DxChart_GetOption", dxTarget, "barGroupWidth");
        }
        public static ValueTask<object> SetBarGroupWidth(ElementReference dxTarget, float? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxChart_SetOption", dxTarget, "barGroupWidth", value);
        }
        public static ValueTask<float?> GetBarWidth(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_DxChart_GetOption", dxTarget, "barWidth");
        }
        public static ValueTask<object> SetBarWidth(ElementReference dxTarget, float? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxChart_SetOption", dxTarget, "barWidth", value);
        }
        public static ValueTask<object> GetCommonAxisSettings(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxChart_GetOption", dxTarget, "commonAxisSettings");
        }
        public static ValueTask<object> SetCommonAxisSettings(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxChart_SetOption", dxTarget, "commonAxisSettings", value);
        }
        public static ValueTask<object> GetCommonPaneSettings(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxChart_GetOption", dxTarget, "commonPaneSettings");
        }
        public static ValueTask<object> SetCommonPaneSettings(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxChart_SetOption", dxTarget, "commonPaneSettings", value);
        }
        public static ValueTask<object> GetCommonSeriesSettings(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxChart_GetOption", dxTarget, "commonSeriesSettings");
        }
        public static ValueTask<object> SetCommonSeriesSettings(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxChart_SetOption", dxTarget, "commonSeriesSettings", value);
        }
        public static ValueTask<string> GetContainerBackgroundColor(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxChart_GetOption", dxTarget, "containerBackgroundColor");
        }
        public static ValueTask<object> SetContainerBackgroundColor(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxChart_SetOption", dxTarget, "containerBackgroundColor", value);
        }
        public static ValueTask<object> GetCrosshair(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxChart_GetOption", dxTarget, "crosshair");
        }
        public static ValueTask<object> SetCrosshair(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxChart_SetOption", dxTarget, "crosshair", value);
        }
        public static ValueTask<object> GetDataPrepareSettings(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxChart_GetOption", dxTarget, "dataPrepareSettings");
        }
        public static ValueTask<object> SetDataPrepareSettings(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxChart_SetOption", dxTarget, "dataPrepareSettings", value);
        }
        public static ValueTask<string> GetDefaultPane(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxChart_GetOption", dxTarget, "defaultPane");
        }
        public static ValueTask<object> SetDefaultPane(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxChart_SetOption", dxTarget, "defaultPane", value);
        }
        public static ValueTask<bool?> GetEqualBarWidth(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxChart_GetOption", dxTarget, "equalBarWidth");
        }
        public static ValueTask<object> SetEqualBarWidth(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxChart_SetOption", dxTarget, "equalBarWidth", value);
        }
        public static ValueTask<float?> GetMaxBubbleSize(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_DxChart_GetOption", dxTarget, "maxBubbleSize");
        }
        public static ValueTask<object> SetMaxBubbleSize(ElementReference dxTarget, float? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxChart_SetOption", dxTarget, "maxBubbleSize", value);
        }
        public static ValueTask<float?> GetMinBubbleSize(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_DxChart_GetOption", dxTarget, "minBubbleSize");
        }
        public static ValueTask<object> SetMinBubbleSize(ElementReference dxTarget, float? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxChart_SetOption", dxTarget, "minBubbleSize", value);
        }
        public static ValueTask<bool?> GetNegativesAsZeroes(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxChart_GetOption", dxTarget, "negativesAsZeroes");
        }
        public static ValueTask<object> SetNegativesAsZeroes(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxChart_SetOption", dxTarget, "negativesAsZeroes", value);
        }
        public static ValueTask<object> GetPanes(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxChart_GetOption", dxTarget, "panes");
        }
        public static ValueTask<object> SetPanes(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxChart_SetOption", dxTarget, "panes", value);
        }
        public static ValueTask<string> GetResolveLabelOverlapping(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxChart_GetOption", dxTarget, "resolveLabelOverlapping");
        }
        public static ValueTask<object> SetResolveLabelOverlapping(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxChart_SetOption", dxTarget, "resolveLabelOverlapping", value);
        }
        public static ValueTask<bool?> GetRotated(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxChart_GetOption", dxTarget, "rotated");
        }
        public static ValueTask<object> SetRotated(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxChart_SetOption", dxTarget, "rotated", value);
        }
        public static ValueTask<object> GetScrollBar(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxChart_GetOption", dxTarget, "scrollBar");
        }
        public static ValueTask<object> SetScrollBar(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxChart_SetOption", dxTarget, "scrollBar", value);
        }
        public static ValueTask<string> GetScrollingMode(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxChart_GetOption", dxTarget, "scrollingMode");
        }
        public static ValueTask<object> SetScrollingMode(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxChart_SetOption", dxTarget, "scrollingMode", value);
        }
        public static ValueTask<string> GetSeriesSelectionMode(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxChart_GetOption", dxTarget, "seriesSelectionMode");
        }
        public static ValueTask<object> SetSeriesSelectionMode(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxChart_SetOption", dxTarget, "seriesSelectionMode", value);
        }
        public static ValueTask<object> GetSeriesTemplate(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxChart_GetOption", dxTarget, "seriesTemplate");
        }
        public static ValueTask<object> SetSeriesTemplate(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxChart_SetOption", dxTarget, "seriesTemplate", value);
        }
        public static ValueTask<bool?> GetSynchronizeMultiAxes(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxChart_GetOption", dxTarget, "synchronizeMultiAxes");
        }
        public static ValueTask<object> SetSynchronizeMultiAxes(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxChart_SetOption", dxTarget, "synchronizeMultiAxes", value);
        }
        public static ValueTask<bool?> GetUseAggregation(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxChart_GetOption", dxTarget, "useAggregation");
        }
        public static ValueTask<object> SetUseAggregation(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxChart_SetOption", dxTarget, "useAggregation", value);
        }
        public static ValueTask<object> GetValueAxis(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxChart_GetOption", dxTarget, "valueAxis");
        }
        public static ValueTask<object> SetValueAxis(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxChart_SetOption", dxTarget, "valueAxis", value);
        }
        public static ValueTask<string> GetZoomingMode(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxChart_GetOption", dxTarget, "zoomingMode");
        }
        public static ValueTask<object> SetZoomingMode(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxChart_SetOption", dxTarget, "zoomingMode", value);
        }
        public static ValueTask<object> ZoomArgument(ElementReference dxTarget, object startValue, object endValue)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxChart_zoomArgument_0", dxTarget, startValue, endValue);
        }
    }
    public class DxPieChartInterop: BaseChartInterop
    {
        public static event EventHandler<JQueryEventArgs> LegendClick;
        public static ValueTask<object> Init(ElementReference dxTarget, DevExpress.Viz.Charts.DxPieChartOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPieChart_Init", dxTarget, json);
        }
        [JSInvokable("DevExpress.Viz.DxPieChartInterop.OnLegendClick")]
        public static void OnLegendClick(string identifier)
        {
            LegendClick?.Invoke(null, new JQueryEventArgs(identifier));
        }
        public static ValueTask<object> GetCommonSeriesSettings(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPieChart_GetOption", dxTarget, "commonSeriesSettings");
        }
        public static ValueTask<object> SetCommonSeriesSettings(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPieChart_SetOption", dxTarget, "commonSeriesSettings", value);
        }
        public static ValueTask<float?> GetDiameter(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_DxPieChart_GetOption", dxTarget, "diameter");
        }
        public static ValueTask<object> SetDiameter(ElementReference dxTarget, float? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPieChart_SetOption", dxTarget, "diameter", value);
        }
        public static ValueTask<float?> GetInnerRadius(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_DxPieChart_GetOption", dxTarget, "innerRadius");
        }
        public static ValueTask<object> SetInnerRadius(ElementReference dxTarget, float? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPieChart_SetOption", dxTarget, "innerRadius", value);
        }
        public static ValueTask<float?> GetMinDiameter(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_DxPieChart_GetOption", dxTarget, "minDiameter");
        }
        public static ValueTask<object> SetMinDiameter(ElementReference dxTarget, float? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPieChart_SetOption", dxTarget, "minDiameter", value);
        }
        public static ValueTask<string> GetResolveLabelOverlapping(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxPieChart_GetOption", dxTarget, "resolveLabelOverlapping");
        }
        public static ValueTask<object> SetResolveLabelOverlapping(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPieChart_SetOption", dxTarget, "resolveLabelOverlapping", value);
        }
        public static ValueTask<string> GetSegmentsDirection(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxPieChart_GetOption", dxTarget, "segmentsDirection");
        }
        public static ValueTask<object> SetSegmentsDirection(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPieChart_SetOption", dxTarget, "segmentsDirection", value);
        }
        public static ValueTask<object> GetSeriesTemplate(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPieChart_GetOption", dxTarget, "seriesTemplate");
        }
        public static ValueTask<object> SetSeriesTemplate(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPieChart_SetOption", dxTarget, "seriesTemplate", value);
        }
        public static ValueTask<string> GetSizeGroup(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxPieChart_GetOption", dxTarget, "sizeGroup");
        }
        public static ValueTask<object> SetSizeGroup(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPieChart_SetOption", dxTarget, "sizeGroup", value);
        }
        public static ValueTask<float?> GetStartAngle(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_DxPieChart_GetOption", dxTarget, "startAngle");
        }
        public static ValueTask<object> SetStartAngle(ElementReference dxTarget, float? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPieChart_SetOption", dxTarget, "startAngle", value);
        }
        public static ValueTask<string> GetType(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxPieChart_GetOption", dxTarget, "type");
        }
        public static ValueTask<object> SetType(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPieChart_SetOption", dxTarget, "type", value);
        }
        public static ValueTask<object> GetSeriesEx(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPieChart_getSeries_0", dxTarget);
        }
        public static ValueTask<object> GetSeriesByName(ElementReference dxTarget, object seriesName)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPieChart_getSeriesByName_1", dxTarget, seriesName);
        }
        public static ValueTask<object> GetSeriesByPos(ElementReference dxTarget, float seriesIndex)
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
        public static ValueTask<object> Init(ElementReference dxTarget, DevExpress.Viz.Charts.DxPolarChartOptions options)
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
        public static ValueTask<object> GetArgumentAxis(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPolarChart_GetOption", dxTarget, "argumentAxis");
        }
        public static ValueTask<object> SetArgumentAxis(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPolarChart_SetOption", dxTarget, "argumentAxis", value);
        }
        public static ValueTask<float?> GetBarGroupPadding(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_DxPolarChart_GetOption", dxTarget, "barGroupPadding");
        }
        public static ValueTask<object> SetBarGroupPadding(ElementReference dxTarget, float? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPolarChart_SetOption", dxTarget, "barGroupPadding", value);
        }
        public static ValueTask<float?> GetBarGroupWidth(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_DxPolarChart_GetOption", dxTarget, "barGroupWidth");
        }
        public static ValueTask<object> SetBarGroupWidth(ElementReference dxTarget, float? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPolarChart_SetOption", dxTarget, "barGroupWidth", value);
        }
        public static ValueTask<float?> GetBarWidth(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_DxPolarChart_GetOption", dxTarget, "barWidth");
        }
        public static ValueTask<object> SetBarWidth(ElementReference dxTarget, float? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPolarChart_SetOption", dxTarget, "barWidth", value);
        }
        public static ValueTask<object> GetCommonAxisSettings(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPolarChart_GetOption", dxTarget, "commonAxisSettings");
        }
        public static ValueTask<object> SetCommonAxisSettings(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPolarChart_SetOption", dxTarget, "commonAxisSettings", value);
        }
        public static ValueTask<object> GetCommonSeriesSettings(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPolarChart_GetOption", dxTarget, "commonSeriesSettings");
        }
        public static ValueTask<object> SetCommonSeriesSettings(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPolarChart_SetOption", dxTarget, "commonSeriesSettings", value);
        }
        public static ValueTask<string> GetContainerBackgroundColor(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxPolarChart_GetOption", dxTarget, "containerBackgroundColor");
        }
        public static ValueTask<object> SetContainerBackgroundColor(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPolarChart_SetOption", dxTarget, "containerBackgroundColor", value);
        }
        public static ValueTask<object> GetDataPrepareSettings(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPolarChart_GetOption", dxTarget, "dataPrepareSettings");
        }
        public static ValueTask<object> SetDataPrepareSettings(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPolarChart_SetOption", dxTarget, "dataPrepareSettings", value);
        }
        public static ValueTask<bool?> GetEqualBarWidth(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxPolarChart_GetOption", dxTarget, "equalBarWidth");
        }
        public static ValueTask<object> SetEqualBarWidth(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPolarChart_SetOption", dxTarget, "equalBarWidth", value);
        }
        public static ValueTask<bool?> GetNegativesAsZeroes(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxPolarChart_GetOption", dxTarget, "negativesAsZeroes");
        }
        public static ValueTask<object> SetNegativesAsZeroes(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPolarChart_SetOption", dxTarget, "negativesAsZeroes", value);
        }
        public static ValueTask<string> GetResolveLabelOverlapping(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxPolarChart_GetOption", dxTarget, "resolveLabelOverlapping");
        }
        public static ValueTask<object> SetResolveLabelOverlapping(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPolarChart_SetOption", dxTarget, "resolveLabelOverlapping", value);
        }
        public static ValueTask<string> GetSeriesSelectionMode(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxPolarChart_GetOption", dxTarget, "seriesSelectionMode");
        }
        public static ValueTask<object> SetSeriesSelectionMode(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPolarChart_SetOption", dxTarget, "seriesSelectionMode", value);
        }
        public static ValueTask<object> GetSeriesTemplate(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPolarChart_GetOption", dxTarget, "seriesTemplate");
        }
        public static ValueTask<object> SetSeriesTemplate(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPolarChart_SetOption", dxTarget, "seriesTemplate", value);
        }
        public static ValueTask<bool?> GetUseSpiderWeb(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxPolarChart_GetOption", dxTarget, "useSpiderWeb");
        }
        public static ValueTask<object> SetUseSpiderWeb(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPolarChart_SetOption", dxTarget, "useSpiderWeb", value);
        }
        public static ValueTask<object> GetValueAxis(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxPolarChart_GetOption", dxTarget, "valueAxis");
        }
        public static ValueTask<object> SetValueAxis(ElementReference dxTarget, object value)
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
        public static ValueTask<object> Init(ElementReference dxTarget, DevExpress.Viz.Charts.BaseChartOptions options)
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
        public static ValueTask<object> GetAdaptiveLayout(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BaseChart_GetOption", dxTarget, "adaptiveLayout");
        }
        public static ValueTask<object> SetAdaptiveLayout(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BaseChart_SetOption", dxTarget, "adaptiveLayout", value);
        }
        public static ValueTask<object> GetAnimation(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BaseChart_GetOption", dxTarget, "animation");
        }
        public static ValueTask<object> SetAnimation(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BaseChart_SetOption", dxTarget, "animation", value);
        }
        public static ValueTask<object> GetCustomizeLabel(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BaseChart_GetOption", dxTarget, "customizeLabel");
        }
        public static ValueTask<object> SetCustomizeLabel(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BaseChart_SetOption", dxTarget, "customizeLabel", value);
        }
        public static ValueTask<object> GetCustomizePoint(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BaseChart_GetOption", dxTarget, "customizePoint");
        }
        public static ValueTask<object> SetCustomizePoint(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BaseChart_SetOption", dxTarget, "customizePoint", value);
        }
        public static ValueTask<object> GetDataSource(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BaseChart_GetOption", dxTarget, "dataSource");
        }
        public static ValueTask<object> SetDataSource(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BaseChart_SetOption", dxTarget, "dataSource", value);
        }
        public static ValueTask<object> GetLegend(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BaseChart_GetOption", dxTarget, "legend");
        }
        public static ValueTask<object> SetLegend(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BaseChart_SetOption", dxTarget, "legend", value);
        }
        public static ValueTask<object> GetPalette(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BaseChart_GetOption", dxTarget, "palette");
        }
        public static ValueTask<object> SetPalette(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BaseChart_SetOption", dxTarget, "palette", value);
        }
        public static ValueTask<string> GetPaletteExtensionMode(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_BaseChart_GetOption", dxTarget, "paletteExtensionMode");
        }
        public static ValueTask<object> SetPaletteExtensionMode(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BaseChart_SetOption", dxTarget, "paletteExtensionMode", value);
        }
        public static ValueTask<string> GetPointSelectionMode(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_BaseChart_GetOption", dxTarget, "pointSelectionMode");
        }
        public static ValueTask<object> SetPointSelectionMode(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BaseChart_SetOption", dxTarget, "pointSelectionMode", value);
        }
        public static ValueTask<object> GetSeries(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BaseChart_GetOption", dxTarget, "series");
        }
        public static ValueTask<object> SetSeries(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BaseChart_SetOption", dxTarget, "series", value);
        }
        public static ValueTask<object> ClearSelection(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BaseChart_clearSelection_0", dxTarget);
        }
        public static ValueTask<object> GetAllSeries(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BaseChart_getAllSeries_1", dxTarget);
        }
        public static ValueTask<object> GetDataSourceEx(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BaseChart_getDataSource_2", dxTarget);
        }
        public static ValueTask<object> GetSeriesByName(ElementReference dxTarget, object seriesName)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BaseChart_getSeriesByName_3", dxTarget, seriesName);
        }
        public static ValueTask<object> GetSeriesByPos(ElementReference dxTarget, float seriesIndex)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BaseChart_getSeriesByPos_4", dxTarget, seriesIndex);
        }
        public static ValueTask<object> HideTooltip(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BaseChart_hideTooltip_5", dxTarget);
        }
        public static ValueTask<object> Render(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BaseChart_render_6", dxTarget);
        }
        public static ValueTask<object> Render(ElementReference dxTarget, object renderOptions)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BaseChart_render_7", dxTarget, renderOptions);
        }
    }
    public class DxExporterInterop: ComponentInterop
    {
        public static ValueTask<object> Init(ElementReference dxTarget, DevExpress.Viz.DxExporterOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxExporter_Init", dxTarget, json);
        }
        public static ValueTask<object> GetExportFormat(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxExporter_GetOption", dxTarget, "exportFormat");
        }
        public static ValueTask<object> SetExportFormat(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxExporter_SetOption", dxTarget, "exportFormat", value);
        }
        public static ValueTask<string> GetFileName(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxExporter_GetOption", dxTarget, "fileName");
        }
        public static ValueTask<object> SetFileName(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxExporter_SetOption", dxTarget, "fileName", value);
        }
        public static ValueTask<bool?> GetPrintingEnabled(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxExporter_GetOption", dxTarget, "printingEnabled");
        }
        public static ValueTask<object> SetPrintingEnabled(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxExporter_SetOption", dxTarget, "printingEnabled", value);
        }
        public static ValueTask<string> GetServerUrl(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxExporter_GetOption", dxTarget, "serverUrl");
        }
        public static ValueTask<object> SetServerUrl(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxExporter_SetOption", dxTarget, "serverUrl", value);
        }
        public static ValueTask<bool?> GetShowMenu(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxExporter_GetOption", dxTarget, "showMenu");
        }
        public static ValueTask<object> SetShowMenu(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxExporter_SetOption", dxTarget, "showMenu", value);
        }
        public static ValueTask<string> GetSourceContainer(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxExporter_GetOption", dxTarget, "sourceContainer");
        }
        public static ValueTask<object> SetSourceContainer(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxExporter_SetOption", dxTarget, "sourceContainer", value);
        }
        public static ValueTask<object> ExportTo(ElementReference dxTarget, string fileName, string format)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxExporter_exportTo_0", dxTarget, fileName, format);
        }
        public static ValueTask<object> Print(ElementReference dxTarget)
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
        public static ValueTask<object> Init(ElementReference dxTarget, DevExpress.Viz.Funnel.DxFunnelOptions options)
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
        public static ValueTask<object> GetAdaptiveLayout(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxFunnel_GetOption", dxTarget, "adaptiveLayout");
        }
        public static ValueTask<object> SetAdaptiveLayout(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxFunnel_SetOption", dxTarget, "adaptiveLayout", value);
        }
        public static ValueTask<string> GetAlgorithm(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxFunnel_GetOption", dxTarget, "algorithm");
        }
        public static ValueTask<object> SetAlgorithm(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxFunnel_SetOption", dxTarget, "algorithm", value);
        }
        public static ValueTask<string> GetArgumentField(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxFunnel_GetOption", dxTarget, "argumentField");
        }
        public static ValueTask<object> SetArgumentField(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxFunnel_SetOption", dxTarget, "argumentField", value);
        }
        public static ValueTask<string> GetColorField(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxFunnel_GetOption", dxTarget, "colorField");
        }
        public static ValueTask<object> SetColorField(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxFunnel_SetOption", dxTarget, "colorField", value);
        }
        public static ValueTask<object> GetDataSource(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxFunnel_GetOption", dxTarget, "dataSource");
        }
        public static ValueTask<object> SetDataSource(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxFunnel_SetOption", dxTarget, "dataSource", value);
        }
        public static ValueTask<bool?> GetHoverEnabled(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxFunnel_GetOption", dxTarget, "hoverEnabled");
        }
        public static ValueTask<object> SetHoverEnabled(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxFunnel_SetOption", dxTarget, "hoverEnabled", value);
        }
        public static ValueTask<bool?> GetInverted(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxFunnel_GetOption", dxTarget, "inverted");
        }
        public static ValueTask<object> SetInverted(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxFunnel_SetOption", dxTarget, "inverted", value);
        }
        public static ValueTask<object> GetItem(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxFunnel_GetOption", dxTarget, "item");
        }
        public static ValueTask<object> SetItem(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxFunnel_SetOption", dxTarget, "item", value);
        }
        public static ValueTask<object> GetLabel(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxFunnel_GetOption", dxTarget, "label");
        }
        public static ValueTask<object> SetLabel(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxFunnel_SetOption", dxTarget, "label", value);
        }
        public static ValueTask<object> GetLegend(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxFunnel_GetOption", dxTarget, "legend");
        }
        public static ValueTask<object> SetLegend(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxFunnel_SetOption", dxTarget, "legend", value);
        }
        public static ValueTask<float?> GetNeckHeight(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_DxFunnel_GetOption", dxTarget, "neckHeight");
        }
        public static ValueTask<object> SetNeckHeight(ElementReference dxTarget, float? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxFunnel_SetOption", dxTarget, "neckHeight", value);
        }
        public static ValueTask<float?> GetNeckWidth(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_DxFunnel_GetOption", dxTarget, "neckWidth");
        }
        public static ValueTask<object> SetNeckWidth(ElementReference dxTarget, float? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxFunnel_SetOption", dxTarget, "neckWidth", value);
        }
        public static ValueTask<object> GetPalette(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxFunnel_GetOption", dxTarget, "palette");
        }
        public static ValueTask<object> SetPalette(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxFunnel_SetOption", dxTarget, "palette", value);
        }
        public static ValueTask<string> GetPaletteExtensionMode(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxFunnel_GetOption", dxTarget, "paletteExtensionMode");
        }
        public static ValueTask<object> SetPaletteExtensionMode(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxFunnel_SetOption", dxTarget, "paletteExtensionMode", value);
        }
        public static ValueTask<string> GetSelectionMode(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxFunnel_GetOption", dxTarget, "selectionMode");
        }
        public static ValueTask<object> SetSelectionMode(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxFunnel_SetOption", dxTarget, "selectionMode", value);
        }
        public static ValueTask<bool?> GetSortData(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxFunnel_GetOption", dxTarget, "sortData");
        }
        public static ValueTask<object> SetSortData(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxFunnel_SetOption", dxTarget, "sortData", value);
        }
        public static ValueTask<string> GetValueField(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxFunnel_GetOption", dxTarget, "valueField");
        }
        public static ValueTask<object> SetValueField(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxFunnel_SetOption", dxTarget, "valueField", value);
        }
        public static ValueTask<object> ClearSelection(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxFunnel_clearSelection_0", dxTarget);
        }
        public static ValueTask<object> GetAllItems(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxFunnel_getAllItems_1", dxTarget);
        }
        public static ValueTask<object> GetDataSourceEx(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxFunnel_getDataSource_2", dxTarget);
        }
        public static ValueTask<object> HideTooltip(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxFunnel_hideTooltip_3", dxTarget);
        }
    }
    public class BaseGaugeInterop: BaseWidgetInterop
    {
        public static event EventHandler<JQueryEventArgs> TooltipHidden;
        public static event EventHandler<JQueryEventArgs> TooltipShown;
        public static ValueTask<object> Init(ElementReference dxTarget, DevExpress.Viz.Gauges.BaseGaugeOptions options)
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
        public static ValueTask<object> GetAnimation(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BaseGauge_GetOption", dxTarget, "animation");
        }
        public static ValueTask<object> SetAnimation(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BaseGauge_SetOption", dxTarget, "animation", value);
        }
        public static ValueTask<string> GetContainerBackgroundColor(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_BaseGauge_GetOption", dxTarget, "containerBackgroundColor");
        }
        public static ValueTask<object> SetContainerBackgroundColor(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BaseGauge_SetOption", dxTarget, "containerBackgroundColor", value);
        }
        public static ValueTask<object> GetRangeContainer(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BaseGauge_GetOption", dxTarget, "rangeContainer");
        }
        public static ValueTask<object> SetRangeContainer(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BaseGauge_SetOption", dxTarget, "rangeContainer", value);
        }
        public static ValueTask<object> GetScale(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BaseGauge_GetOption", dxTarget, "scale");
        }
        public static ValueTask<object> SetScale(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BaseGauge_SetOption", dxTarget, "scale", value);
        }
        public static ValueTask<object> GetSubtitle(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BaseGauge_GetOption", dxTarget, "subtitle");
        }
        public static ValueTask<object> SetSubtitle(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BaseGauge_SetOption", dxTarget, "subtitle", value);
        }
        public static ValueTask<object> GetSubvalues(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BaseGauge_GetOption", dxTarget, "subvalues");
        }
        public static ValueTask<object> SetSubvalues(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BaseGauge_SetOption", dxTarget, "subvalues", value);
        }
        public static ValueTask<float?> GetValue(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_BaseGauge_GetOption", dxTarget, "value");
        }
        public static ValueTask<object> SetValue(ElementReference dxTarget, float? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BaseGauge_SetOption", dxTarget, "value", value);
        }
        public static ValueTask<object> SubvaluesEx(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BaseGauge_subvalues_0", dxTarget);
        }
        public static ValueTask<object> SubvaluesEx(ElementReference dxTarget, object subvalues)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BaseGauge_subvalues_1", dxTarget, subvalues);
        }
        public static ValueTask<float> ValueEx(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<float>("BlazorDevExtreme_BaseGauge_value_2", dxTarget);
        }
        public static ValueTask<object> ValueEx(ElementReference dxTarget, float value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BaseGauge_value_3", dxTarget, value);
        }
    }
    public class DxCircularGaugeInterop: BaseGaugeInterop
    {
        public static ValueTask<object> Init(ElementReference dxTarget, DevExpress.Viz.Gauges.DxCircularGaugeOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxCircularGauge_Init", dxTarget, json);
        }
        public static ValueTask<object> GetGeometry(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxCircularGauge_GetOption", dxTarget, "geometry");
        }
        public static ValueTask<object> SetGeometry(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxCircularGauge_SetOption", dxTarget, "geometry", value);
        }
        public static ValueTask<object> GetSubvalueIndicator(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxCircularGauge_GetOption", dxTarget, "subvalueIndicator");
        }
        public static ValueTask<object> SetSubvalueIndicator(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxCircularGauge_SetOption", dxTarget, "subvalueIndicator", value);
        }
        public static ValueTask<object> GetValueIndicator(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxCircularGauge_GetOption", dxTarget, "valueIndicator");
        }
        public static ValueTask<object> SetValueIndicator(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxCircularGauge_SetOption", dxTarget, "valueIndicator", value);
        }
    }
    public class DxLinearGaugeInterop: BaseGaugeInterop
    {
        public static ValueTask<object> Init(ElementReference dxTarget, DevExpress.Viz.Gauges.DxLinearGaugeOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxLinearGauge_Init", dxTarget, json);
        }
        public static ValueTask<object> GetGeometry(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxLinearGauge_GetOption", dxTarget, "geometry");
        }
        public static ValueTask<object> SetGeometry(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxLinearGauge_SetOption", dxTarget, "geometry", value);
        }
        public static ValueTask<object> GetSubvalueIndicator(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxLinearGauge_GetOption", dxTarget, "subvalueIndicator");
        }
        public static ValueTask<object> SetSubvalueIndicator(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxLinearGauge_SetOption", dxTarget, "subvalueIndicator", value);
        }
        public static ValueTask<object> GetValueIndicator(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxLinearGauge_GetOption", dxTarget, "valueIndicator");
        }
        public static ValueTask<object> SetValueIndicator(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxLinearGauge_SetOption", dxTarget, "valueIndicator", value);
        }
    }
    public class DxBarGaugeInterop: BaseWidgetInterop
    {
        public static event EventHandler<JQueryEventArgs> TooltipHidden;
        public static event EventHandler<JQueryEventArgs> TooltipShown;
        public static ValueTask<object> Init(ElementReference dxTarget, DevExpress.Viz.Gauges.DxBarGaugeOptions options)
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
        public static ValueTask<object> GetAnimation(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxBarGauge_GetOption", dxTarget, "animation");
        }
        public static ValueTask<object> SetAnimation(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxBarGauge_SetOption", dxTarget, "animation", value);
        }
        public static ValueTask<string> GetBackgroundColor(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxBarGauge_GetOption", dxTarget, "backgroundColor");
        }
        public static ValueTask<object> SetBackgroundColor(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxBarGauge_SetOption", dxTarget, "backgroundColor", value);
        }
        public static ValueTask<float?> GetBarSpacing(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_DxBarGauge_GetOption", dxTarget, "barSpacing");
        }
        public static ValueTask<object> SetBarSpacing(ElementReference dxTarget, float? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxBarGauge_SetOption", dxTarget, "barSpacing", value);
        }
        public static ValueTask<float?> GetBaseValue(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_DxBarGauge_GetOption", dxTarget, "baseValue");
        }
        public static ValueTask<object> SetBaseValue(ElementReference dxTarget, float? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxBarGauge_SetOption", dxTarget, "baseValue", value);
        }
        public static ValueTask<float?> GetEndValue(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_DxBarGauge_GetOption", dxTarget, "endValue");
        }
        public static ValueTask<object> SetEndValue(ElementReference dxTarget, float? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxBarGauge_SetOption", dxTarget, "endValue", value);
        }
        public static ValueTask<object> GetGeometry(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxBarGauge_GetOption", dxTarget, "geometry");
        }
        public static ValueTask<object> SetGeometry(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxBarGauge_SetOption", dxTarget, "geometry", value);
        }
        public static ValueTask<object> GetLabel(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxBarGauge_GetOption", dxTarget, "label");
        }
        public static ValueTask<object> SetLabel(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxBarGauge_SetOption", dxTarget, "label", value);
        }
        public static ValueTask<object> GetPalette(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxBarGauge_GetOption", dxTarget, "palette");
        }
        public static ValueTask<object> SetPalette(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxBarGauge_SetOption", dxTarget, "palette", value);
        }
        public static ValueTask<string> GetPaletteExtensionMode(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxBarGauge_GetOption", dxTarget, "paletteExtensionMode");
        }
        public static ValueTask<object> SetPaletteExtensionMode(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxBarGauge_SetOption", dxTarget, "paletteExtensionMode", value);
        }
        public static ValueTask<float?> GetRelativeInnerRadius(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_DxBarGauge_GetOption", dxTarget, "relativeInnerRadius");
        }
        public static ValueTask<object> SetRelativeInnerRadius(ElementReference dxTarget, float? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxBarGauge_SetOption", dxTarget, "relativeInnerRadius", value);
        }
        public static ValueTask<float?> GetStartValue(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_DxBarGauge_GetOption", dxTarget, "startValue");
        }
        public static ValueTask<object> SetStartValue(ElementReference dxTarget, float? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxBarGauge_SetOption", dxTarget, "startValue", value);
        }
        public static ValueTask<object> GetSubtitle(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxBarGauge_GetOption", dxTarget, "subtitle");
        }
        public static ValueTask<object> SetSubtitle(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxBarGauge_SetOption", dxTarget, "subtitle", value);
        }
        public static ValueTask<object> GetValues(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxBarGauge_GetOption", dxTarget, "values");
        }
        public static ValueTask<object> SetValues(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxBarGauge_SetOption", dxTarget, "values", value);
        }
        public static ValueTask<object> ValuesEx(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxBarGauge_values_0", dxTarget);
        }
        public static ValueTask<object> ValuesEx(ElementReference dxTarget, object values)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxBarGauge_values_1", dxTarget, values);
        }
    }
    public class BaseSeriesObjectInterop
    {
        public static ValueTask<object> ClearHover(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BaseSeriesObject_clearHover_0", dxTarget);
        }
        public static ValueTask<object> ClearSelection(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BaseSeriesObject_clearSelection_1", dxTarget);
        }
        public static ValueTask<object> DeselectPoint(ElementReference dxTarget, object point)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BaseSeriesObject_deselectPoint_2", dxTarget, point);
        }
        public static ValueTask<object> GetAllPoints(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BaseSeriesObject_getAllPoints_3", dxTarget);
        }
        public static ValueTask<string> GetColor(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_BaseSeriesObject_getColor_4", dxTarget);
        }
        public static ValueTask<object> GetPointByPos(ElementReference dxTarget, float positionIndex)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BaseSeriesObject_getPointByPos_5", dxTarget, positionIndex);
        }
        public static ValueTask<object> GetPointsByArg(ElementReference dxTarget, object pointArg)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BaseSeriesObject_getPointsByArg_6", dxTarget, pointArg);
        }
        public static ValueTask<object> GetVisiblePoints(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BaseSeriesObject_getVisiblePoints_7", dxTarget);
        }
        public static ValueTask<object> Hide(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BaseSeriesObject_hide_8", dxTarget);
        }
        public static ValueTask<object> Hover(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BaseSeriesObject_hover_9", dxTarget);
        }
        public static ValueTask<bool> IsHovered(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool>("BlazorDevExtreme_BaseSeriesObject_isHovered_10", dxTarget);
        }
        public static ValueTask<bool> IsSelected(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool>("BlazorDevExtreme_BaseSeriesObject_isSelected_11", dxTarget);
        }
        public static ValueTask<bool> IsVisible(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool>("BlazorDevExtreme_BaseSeriesObject_isVisible_12", dxTarget);
        }
        public static ValueTask<object> Select(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BaseSeriesObject_select_13", dxTarget);
        }
        public static ValueTask<object> SelectPoint(ElementReference dxTarget, object point)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BaseSeriesObject_selectPoint_14", dxTarget, point);
        }
        public static ValueTask<object> Show(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BaseSeriesObject_show_15", dxTarget);
        }
    }
    public class BasePointObjectInterop
    {
        public static ValueTask<object> ClearHover(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BasePointObject_clearHover_0", dxTarget);
        }
        public static ValueTask<object> ClearSelection(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BasePointObject_clearSelection_1", dxTarget);
        }
        public static ValueTask<string> GetColor(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_BasePointObject_getColor_2", dxTarget);
        }
        public static ValueTask<object> GetLabel(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BasePointObject_getLabel_3", dxTarget);
        }
        public static ValueTask<object> HideTooltip(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BasePointObject_hideTooltip_4", dxTarget);
        }
        public static ValueTask<object> Hover(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BasePointObject_hover_5", dxTarget);
        }
        public static ValueTask<bool> IsHovered(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool>("BlazorDevExtreme_BasePointObject_isHovered_6", dxTarget);
        }
        public static ValueTask<bool> IsSelected(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool>("BlazorDevExtreme_BasePointObject_isSelected_7", dxTarget);
        }
        public static ValueTask<object> Select(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BasePointObject_select_8", dxTarget);
        }
        public static ValueTask<object> ShowTooltip(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BasePointObject_showTooltip_9", dxTarget);
        }
    }
    public class BaseLabelObjectInterop
    {
        public static ValueTask<object> GetBoundingRect(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BaseLabelObject_getBoundingRect_0", dxTarget);
        }
        public static ValueTask<object> Hide(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BaseLabelObject_hide_1", dxTarget);
        }
        public static ValueTask<object> Hide(ElementReference dxTarget, bool holdInvisible)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BaseLabelObject_hide_2", dxTarget, holdInvisible);
        }
        public static ValueTask<bool> IsVisible(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool>("BlazorDevExtreme_BaseLabelObject_isVisible_3", dxTarget);
        }
        public static ValueTask<object> Show(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BaseLabelObject_show_4", dxTarget);
        }
        public static ValueTask<object> Show(ElementReference dxTarget, bool holdVisible)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_BaseLabelObject_show_5", dxTarget, holdVisible);
        }
    }
    public class ChartSeriesObjectInterop: BaseSeriesObjectInterop
    {
    }
    public class ChartPointObjectInterop: BasePointObjectInterop
    {
        public static ValueTask<object> GetBoundingRect(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_ChartPointObject_getBoundingRect_0", dxTarget);
        }
    }
    public class DxFunnelItemInterop
    {
        public static ValueTask<string> GetColor(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxFunnelItem_getColor_0", dxTarget);
        }
        public static ValueTask<object> Hover(ElementReference dxTarget, bool state)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxFunnelItem_hover_1", dxTarget, state);
        }
        public static ValueTask<bool> IsHovered(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool>("BlazorDevExtreme_DxFunnelItem_isHovered_2", dxTarget);
        }
        public static ValueTask<bool> IsSelected(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool>("BlazorDevExtreme_DxFunnelItem_isSelected_3", dxTarget);
        }
        public static ValueTask<object> Select(ElementReference dxTarget, bool state)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxFunnelItem_select_4", dxTarget, state);
        }
        public static ValueTask<object> ShowTooltip(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxFunnelItem_showTooltip_5", dxTarget);
        }
    }
    public class PiePointObjectInterop: BasePointObjectInterop
    {
        public static ValueTask<object> Hide(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_PiePointObject_hide_0", dxTarget);
        }
        public static ValueTask<object> HideTooltip(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_PiePointObject_hideTooltip_1", dxTarget);
        }
        public static ValueTask<bool> IsVisible(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool>("BlazorDevExtreme_PiePointObject_isVisible_2", dxTarget);
        }
        public static ValueTask<object> Show(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_PiePointObject_show_3", dxTarget);
        }
        public static ValueTask<object> ShowTooltip(ElementReference dxTarget)
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
        public static ValueTask<object> Customize(ElementReference dxTarget, object options)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeMapNode_customize_0", dxTarget, options);
        }
        public static ValueTask<object> DrillDown(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeMapNode_drillDown_1", dxTarget);
        }
        public static ValueTask<object> GetAllChildren(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeMapNode_getAllChildren_2", dxTarget);
        }
        public static ValueTask<object> GetAllNodes(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeMapNode_getAllNodes_3", dxTarget);
        }
        public static ValueTask<object> GetChild(ElementReference dxTarget, float index)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeMapNode_getChild_4", dxTarget, index);
        }
        public static ValueTask<float> GetChildrenCount(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<float>("BlazorDevExtreme_DxTreeMapNode_getChildrenCount_5", dxTarget);
        }
        public static ValueTask<object> GetParent(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeMapNode_getParent_6", dxTarget);
        }
        public static ValueTask<bool> IsActive(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool>("BlazorDevExtreme_DxTreeMapNode_isActive_7", dxTarget);
        }
        public static ValueTask<bool> IsHovered(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool>("BlazorDevExtreme_DxTreeMapNode_isHovered_8", dxTarget);
        }
        public static ValueTask<bool> IsLeaf(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool>("BlazorDevExtreme_DxTreeMapNode_isLeaf_9", dxTarget);
        }
        public static ValueTask<bool> IsSelected(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool>("BlazorDevExtreme_DxTreeMapNode_isSelected_10", dxTarget);
        }
        public static ValueTask<string> Label(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxTreeMapNode_label_11", dxTarget);
        }
        public static ValueTask<object> Label(ElementReference dxTarget, string label)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeMapNode_label_12", dxTarget, label);
        }
        public static ValueTask<object> ResetCustomization(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeMapNode_resetCustomization_13", dxTarget);
        }
        public static ValueTask<object> Select(ElementReference dxTarget, bool state)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeMapNode_select_14", dxTarget, state);
        }
        public static ValueTask<object> ShowTooltip(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeMapNode_showTooltip_15", dxTarget);
        }
        public static ValueTask<float> ValueEx(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<float>("BlazorDevExtreme_DxTreeMapNode_value_16", dxTarget);
        }
    }
    public class MapLayerInterop
    {
        public static ValueTask<object> ClearSelection(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_MapLayer_clearSelection_0", dxTarget);
        }
        public static ValueTask<object> GetDataSourceEx(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_MapLayer_getDataSource_1", dxTarget);
        }
        public static ValueTask<object> GetElements(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_MapLayer_getElements_2", dxTarget);
        }
    }
    public class MapLayerElementInterop
    {
        public static ValueTask<object> ApplySettings(ElementReference dxTarget, object settings)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_MapLayerElement_applySettings_0", dxTarget, settings);
        }
        public static ValueTask<object> Attribute(ElementReference dxTarget, string name)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_MapLayerElement_attribute_1", dxTarget, name);
        }
        public static ValueTask<object> Attribute(ElementReference dxTarget, string name, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_MapLayerElement_attribute_2", dxTarget, name, value);
        }
        public static ValueTask<object> Coordinates(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_MapLayerElement_coordinates_3", dxTarget);
        }
        public static ValueTask<bool> Selected(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool>("BlazorDevExtreme_MapLayerElement_selected_4", dxTarget);
        }
        public static ValueTask<object> Selected(ElementReference dxTarget, bool state)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_MapLayerElement_selected_5", dxTarget, state);
        }
    }
    public class AreaObjectsInterop
    {
        public static ValueTask<object> ApplySettings(ElementReference dxTarget, object settings)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_AreaObjects_applySettings_0", dxTarget, settings);
        }
        public static ValueTask<object> Attribute(ElementReference dxTarget, string name)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_AreaObjects_attribute_1", dxTarget, name);
        }
        public static ValueTask<bool> Selected(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool>("BlazorDevExtreme_AreaObjects_selected_2", dxTarget);
        }
        public static ValueTask<object> Selected(ElementReference dxTarget, bool state)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_AreaObjects_selected_3", dxTarget, state);
        }
    }
    public class MarkerObjectsInterop
    {
        public static ValueTask<object> ApplySettings(ElementReference dxTarget, object settings)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_MarkerObjects_applySettings_0", dxTarget, settings);
        }
        public static ValueTask<object> Attribute(ElementReference dxTarget, string name)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_MarkerObjects_attribute_1", dxTarget, name);
        }
        public static ValueTask<object> Coordinates(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_MarkerObjects_coordinates_2", dxTarget);
        }
        public static ValueTask<bool> Selected(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool>("BlazorDevExtreme_MarkerObjects_selected_3", dxTarget);
        }
        public static ValueTask<object> Selected(ElementReference dxTarget, bool state)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_MarkerObjects_selected_4", dxTarget, state);
        }
    }
    public class DxRangeSelectorInterop: BaseWidgetInterop
    {
        public static event EventHandler<JQueryEventArgs> SelectedRangeChanged;
        public static event EventHandler<JQueryEventArgs> ValueChanged;
        public static ValueTask<object> Init(ElementReference dxTarget, DevExpress.Viz.RangeSelector.DxRangeSelectorOptions options)
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
        public static ValueTask<object> GetBackground(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxRangeSelector_GetOption", dxTarget, "background");
        }
        public static ValueTask<object> SetBackground(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxRangeSelector_SetOption", dxTarget, "background", value);
        }
        public static ValueTask<object> GetBehavior(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxRangeSelector_GetOption", dxTarget, "behavior");
        }
        public static ValueTask<object> SetBehavior(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxRangeSelector_SetOption", dxTarget, "behavior", value);
        }
        public static ValueTask<object> GetChart(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxRangeSelector_GetOption", dxTarget, "chart");
        }
        public static ValueTask<object> SetChart(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxRangeSelector_SetOption", dxTarget, "chart", value);
        }
        public static ValueTask<string> GetContainerBackgroundColor(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxRangeSelector_GetOption", dxTarget, "containerBackgroundColor");
        }
        public static ValueTask<object> SetContainerBackgroundColor(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxRangeSelector_SetOption", dxTarget, "containerBackgroundColor", value);
        }
        public static ValueTask<object> GetDataSource(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxRangeSelector_GetOption", dxTarget, "dataSource");
        }
        public static ValueTask<object> SetDataSource(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxRangeSelector_SetOption", dxTarget, "dataSource", value);
        }
        public static ValueTask<string> GetDataSourceField(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxRangeSelector_GetOption", dxTarget, "dataSourceField");
        }
        public static ValueTask<object> SetDataSourceField(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxRangeSelector_SetOption", dxTarget, "dataSourceField", value);
        }
        public static ValueTask<object> GetIndent(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxRangeSelector_GetOption", dxTarget, "indent");
        }
        public static ValueTask<object> SetIndent(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxRangeSelector_SetOption", dxTarget, "indent", value);
        }
        public static ValueTask<object> GetScale(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxRangeSelector_GetOption", dxTarget, "scale");
        }
        public static ValueTask<object> SetScale(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxRangeSelector_SetOption", dxTarget, "scale", value);
        }
        public static ValueTask<object> GetSelectedRange(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxRangeSelector_GetOption", dxTarget, "selectedRange");
        }
        public static ValueTask<object> SetSelectedRange(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxRangeSelector_SetOption", dxTarget, "selectedRange", value);
        }
        public static ValueTask<string> GetSelectedRangeColor(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxRangeSelector_GetOption", dxTarget, "selectedRangeColor");
        }
        public static ValueTask<object> SetSelectedRangeColor(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxRangeSelector_SetOption", dxTarget, "selectedRangeColor", value);
        }
        public static ValueTask<object> GetShutter(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxRangeSelector_GetOption", dxTarget, "shutter");
        }
        public static ValueTask<object> SetShutter(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxRangeSelector_SetOption", dxTarget, "shutter", value);
        }
        public static ValueTask<object> GetSliderHandle(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxRangeSelector_GetOption", dxTarget, "sliderHandle");
        }
        public static ValueTask<object> SetSliderHandle(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxRangeSelector_SetOption", dxTarget, "sliderHandle", value);
        }
        public static ValueTask<object> GetSliderMarker(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxRangeSelector_GetOption", dxTarget, "sliderMarker");
        }
        public static ValueTask<object> SetSliderMarker(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxRangeSelector_SetOption", dxTarget, "sliderMarker", value);
        }
        public static ValueTask<object> GetValue(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxRangeSelector_GetOption", dxTarget, "value");
        }
        public static ValueTask<object> SetValue(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxRangeSelector_SetOption", dxTarget, "value", value);
        }
        public static ValueTask<object> GetDataSourceEx(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxRangeSelector_getDataSource_0", dxTarget);
        }
        public static ValueTask<object> GetSelectedRangeEx(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxRangeSelector_getSelectedRange_1", dxTarget);
        }
        public static ValueTask<object> GetValueEx(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxRangeSelector_getValue_2", dxTarget);
        }
        public static ValueTask<object> Render(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxRangeSelector_render_3", dxTarget);
        }
        public static ValueTask<object> Render(ElementReference dxTarget, bool skipChartAnimation)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxRangeSelector_render_4", dxTarget, skipChartAnimation);
        }
        public static ValueTask<object> SetSelectedRangeEx(ElementReference dxTarget, object selectedRange)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxRangeSelector_setSelectedRange_5", dxTarget, selectedRange);
        }
        public static ValueTask<object> SetValueEx(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxRangeSelector_setValue_6", dxTarget, value);
        }
    }
    public class BaseSparklineInterop: BaseWidgetInterop
    {
        public static event EventHandler<JQueryEventArgs> TooltipHidden;
        public static event EventHandler<JQueryEventArgs> TooltipShown;
        public static ValueTask<object> Init(ElementReference dxTarget, DevExpress.Viz.Sparklines.BaseSparklineOptions options)
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
        public static ValueTask<object> Init(ElementReference dxTarget, DevExpress.Viz.Sparklines.DxSparklineOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxSparkline_Init", dxTarget, json);
        }
        public static ValueTask<string> GetArgumentField(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxSparkline_GetOption", dxTarget, "argumentField");
        }
        public static ValueTask<object> SetArgumentField(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxSparkline_SetOption", dxTarget, "argumentField", value);
        }
        public static ValueTask<string> GetBarNegativeColor(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxSparkline_GetOption", dxTarget, "barNegativeColor");
        }
        public static ValueTask<object> SetBarNegativeColor(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxSparkline_SetOption", dxTarget, "barNegativeColor", value);
        }
        public static ValueTask<string> GetBarPositiveColor(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxSparkline_GetOption", dxTarget, "barPositiveColor");
        }
        public static ValueTask<object> SetBarPositiveColor(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxSparkline_SetOption", dxTarget, "barPositiveColor", value);
        }
        public static ValueTask<object> GetDataSource(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxSparkline_GetOption", dxTarget, "dataSource");
        }
        public static ValueTask<object> SetDataSource(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxSparkline_SetOption", dxTarget, "dataSource", value);
        }
        public static ValueTask<string> GetFirstLastColor(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxSparkline_GetOption", dxTarget, "firstLastColor");
        }
        public static ValueTask<object> SetFirstLastColor(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxSparkline_SetOption", dxTarget, "firstLastColor", value);
        }
        public static ValueTask<bool?> GetIgnoreEmptyPoints(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxSparkline_GetOption", dxTarget, "ignoreEmptyPoints");
        }
        public static ValueTask<object> SetIgnoreEmptyPoints(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxSparkline_SetOption", dxTarget, "ignoreEmptyPoints", value);
        }
        public static ValueTask<string> GetLineColor(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxSparkline_GetOption", dxTarget, "lineColor");
        }
        public static ValueTask<object> SetLineColor(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxSparkline_SetOption", dxTarget, "lineColor", value);
        }
        public static ValueTask<float?> GetLineWidth(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_DxSparkline_GetOption", dxTarget, "lineWidth");
        }
        public static ValueTask<object> SetLineWidth(ElementReference dxTarget, float? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxSparkline_SetOption", dxTarget, "lineWidth", value);
        }
        public static ValueTask<string> GetLossColor(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxSparkline_GetOption", dxTarget, "lossColor");
        }
        public static ValueTask<object> SetLossColor(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxSparkline_SetOption", dxTarget, "lossColor", value);
        }
        public static ValueTask<string> GetMaxColor(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxSparkline_GetOption", dxTarget, "maxColor");
        }
        public static ValueTask<object> SetMaxColor(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxSparkline_SetOption", dxTarget, "maxColor", value);
        }
        public static ValueTask<float?> GetMaxValue(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_DxSparkline_GetOption", dxTarget, "maxValue");
        }
        public static ValueTask<object> SetMaxValue(ElementReference dxTarget, float? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxSparkline_SetOption", dxTarget, "maxValue", value);
        }
        public static ValueTask<string> GetMinColor(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxSparkline_GetOption", dxTarget, "minColor");
        }
        public static ValueTask<object> SetMinColor(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxSparkline_SetOption", dxTarget, "minColor", value);
        }
        public static ValueTask<float?> GetMinValue(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_DxSparkline_GetOption", dxTarget, "minValue");
        }
        public static ValueTask<object> SetMinValue(ElementReference dxTarget, float? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxSparkline_SetOption", dxTarget, "minValue", value);
        }
        public static ValueTask<string> GetPointColor(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxSparkline_GetOption", dxTarget, "pointColor");
        }
        public static ValueTask<object> SetPointColor(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxSparkline_SetOption", dxTarget, "pointColor", value);
        }
        public static ValueTask<float?> GetPointSize(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_DxSparkline_GetOption", dxTarget, "pointSize");
        }
        public static ValueTask<object> SetPointSize(ElementReference dxTarget, float? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxSparkline_SetOption", dxTarget, "pointSize", value);
        }
        public static ValueTask<string> GetPointSymbol(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxSparkline_GetOption", dxTarget, "pointSymbol");
        }
        public static ValueTask<object> SetPointSymbol(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxSparkline_SetOption", dxTarget, "pointSymbol", value);
        }
        public static ValueTask<bool?> GetShowFirstLast(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxSparkline_GetOption", dxTarget, "showFirstLast");
        }
        public static ValueTask<object> SetShowFirstLast(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxSparkline_SetOption", dxTarget, "showFirstLast", value);
        }
        public static ValueTask<bool?> GetShowMinMax(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxSparkline_GetOption", dxTarget, "showMinMax");
        }
        public static ValueTask<object> SetShowMinMax(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxSparkline_SetOption", dxTarget, "showMinMax", value);
        }
        public static ValueTask<string> GetType(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxSparkline_GetOption", dxTarget, "type");
        }
        public static ValueTask<object> SetType(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxSparkline_SetOption", dxTarget, "type", value);
        }
        public static ValueTask<string> GetValueField(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxSparkline_GetOption", dxTarget, "valueField");
        }
        public static ValueTask<object> SetValueField(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxSparkline_SetOption", dxTarget, "valueField", value);
        }
        public static ValueTask<string> GetWinColor(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxSparkline_GetOption", dxTarget, "winColor");
        }
        public static ValueTask<object> SetWinColor(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxSparkline_SetOption", dxTarget, "winColor", value);
        }
        public static ValueTask<float?> GetWinlossThreshold(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_DxSparkline_GetOption", dxTarget, "winlossThreshold");
        }
        public static ValueTask<object> SetWinlossThreshold(ElementReference dxTarget, float? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxSparkline_SetOption", dxTarget, "winlossThreshold", value);
        }
        public static ValueTask<object> GetDataSourceEx(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxSparkline_getDataSource_0", dxTarget);
        }
    }
    public class DxBulletInterop: BaseSparklineInterop
    {
        public static ValueTask<object> Init(ElementReference dxTarget, DevExpress.Viz.Sparklines.DxBulletOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxBullet_Init", dxTarget, json);
        }
        public static ValueTask<string> GetColor(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxBullet_GetOption", dxTarget, "color");
        }
        public static ValueTask<object> SetColor(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxBullet_SetOption", dxTarget, "color", value);
        }
        public static ValueTask<float?> GetEndScaleValue(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_DxBullet_GetOption", dxTarget, "endScaleValue");
        }
        public static ValueTask<object> SetEndScaleValue(ElementReference dxTarget, float? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxBullet_SetOption", dxTarget, "endScaleValue", value);
        }
        public static ValueTask<bool?> GetShowTarget(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxBullet_GetOption", dxTarget, "showTarget");
        }
        public static ValueTask<object> SetShowTarget(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxBullet_SetOption", dxTarget, "showTarget", value);
        }
        public static ValueTask<bool?> GetShowZeroLevel(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxBullet_GetOption", dxTarget, "showZeroLevel");
        }
        public static ValueTask<object> SetShowZeroLevel(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxBullet_SetOption", dxTarget, "showZeroLevel", value);
        }
        public static ValueTask<float?> GetStartScaleValue(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_DxBullet_GetOption", dxTarget, "startScaleValue");
        }
        public static ValueTask<object> SetStartScaleValue(ElementReference dxTarget, float? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxBullet_SetOption", dxTarget, "startScaleValue", value);
        }
        public static ValueTask<float?> GetTarget(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_DxBullet_GetOption", dxTarget, "target");
        }
        public static ValueTask<object> SetTarget(ElementReference dxTarget, float? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxBullet_SetOption", dxTarget, "target", value);
        }
        public static ValueTask<string> GetTargetColor(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxBullet_GetOption", dxTarget, "targetColor");
        }
        public static ValueTask<object> SetTargetColor(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxBullet_SetOption", dxTarget, "targetColor", value);
        }
        public static ValueTask<float?> GetTargetWidth(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_DxBullet_GetOption", dxTarget, "targetWidth");
        }
        public static ValueTask<object> SetTargetWidth(ElementReference dxTarget, float? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxBullet_SetOption", dxTarget, "targetWidth", value);
        }
        public static ValueTask<float?> GetValue(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_DxBullet_GetOption", dxTarget, "value");
        }
        public static ValueTask<object> SetValue(ElementReference dxTarget, float? value)
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
        public static ValueTask<object> Init(ElementReference dxTarget, DevExpress.Viz.TreeMap.DxTreeMapOptions options)
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
        public static ValueTask<string> GetChildrenField(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxTreeMap_GetOption", dxTarget, "childrenField");
        }
        public static ValueTask<object> SetChildrenField(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeMap_SetOption", dxTarget, "childrenField", value);
        }
        public static ValueTask<string> GetColorField(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxTreeMap_GetOption", dxTarget, "colorField");
        }
        public static ValueTask<object> SetColorField(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeMap_SetOption", dxTarget, "colorField", value);
        }
        public static ValueTask<object> GetColorizer(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeMap_GetOption", dxTarget, "colorizer");
        }
        public static ValueTask<object> SetColorizer(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeMap_SetOption", dxTarget, "colorizer", value);
        }
        public static ValueTask<object> GetDataSource(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeMap_GetOption", dxTarget, "dataSource");
        }
        public static ValueTask<object> SetDataSource(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeMap_SetOption", dxTarget, "dataSource", value);
        }
        public static ValueTask<object> GetGroup(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeMap_GetOption", dxTarget, "group");
        }
        public static ValueTask<object> SetGroup(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeMap_SetOption", dxTarget, "group", value);
        }
        public static ValueTask<bool?> GetHoverEnabled(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxTreeMap_GetOption", dxTarget, "hoverEnabled");
        }
        public static ValueTask<object> SetHoverEnabled(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeMap_SetOption", dxTarget, "hoverEnabled", value);
        }
        public static ValueTask<string> GetIdField(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxTreeMap_GetOption", dxTarget, "idField");
        }
        public static ValueTask<object> SetIdField(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeMap_SetOption", dxTarget, "idField", value);
        }
        public static ValueTask<bool?> GetInteractWithGroup(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxTreeMap_GetOption", dxTarget, "interactWithGroup");
        }
        public static ValueTask<object> SetInteractWithGroup(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeMap_SetOption", dxTarget, "interactWithGroup", value);
        }
        public static ValueTask<string> GetLabelField(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxTreeMap_GetOption", dxTarget, "labelField");
        }
        public static ValueTask<object> SetLabelField(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeMap_SetOption", dxTarget, "labelField", value);
        }
        public static ValueTask<object> GetLayoutAlgorithm(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeMap_GetOption", dxTarget, "layoutAlgorithm");
        }
        public static ValueTask<object> SetLayoutAlgorithm(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeMap_SetOption", dxTarget, "layoutAlgorithm", value);
        }
        public static ValueTask<string> GetLayoutDirection(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxTreeMap_GetOption", dxTarget, "layoutDirection");
        }
        public static ValueTask<object> SetLayoutDirection(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeMap_SetOption", dxTarget, "layoutDirection", value);
        }
        public static ValueTask<float?> GetMaxDepth(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_DxTreeMap_GetOption", dxTarget, "maxDepth");
        }
        public static ValueTask<object> SetMaxDepth(ElementReference dxTarget, float? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeMap_SetOption", dxTarget, "maxDepth", value);
        }
        public static ValueTask<string> GetParentField(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxTreeMap_GetOption", dxTarget, "parentField");
        }
        public static ValueTask<object> SetParentField(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeMap_SetOption", dxTarget, "parentField", value);
        }
        public static ValueTask<string> GetResolveLabelOverflow(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxTreeMap_GetOption", dxTarget, "resolveLabelOverflow");
        }
        public static ValueTask<object> SetResolveLabelOverflow(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeMap_SetOption", dxTarget, "resolveLabelOverflow", value);
        }
        public static ValueTask<string> GetSelectionMode(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxTreeMap_GetOption", dxTarget, "selectionMode");
        }
        public static ValueTask<object> SetSelectionMode(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeMap_SetOption", dxTarget, "selectionMode", value);
        }
        public static ValueTask<object> GetTile(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeMap_GetOption", dxTarget, "tile");
        }
        public static ValueTask<object> SetTile(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeMap_SetOption", dxTarget, "tile", value);
        }
        public static ValueTask<string> GetValueField(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<string>("BlazorDevExtreme_DxTreeMap_GetOption", dxTarget, "valueField");
        }
        public static ValueTask<object> SetValueField(ElementReference dxTarget, string value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeMap_SetOption", dxTarget, "valueField", value);
        }
        public static ValueTask<object> ClearSelection(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeMap_clearSelection_0", dxTarget);
        }
        public static ValueTask<object> DrillUp(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeMap_drillUp_1", dxTarget);
        }
        public static ValueTask<object> GetCurrentNode(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeMap_getCurrentNode_2", dxTarget);
        }
        public static ValueTask<object> GetDataSourceEx(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeMap_getDataSource_3", dxTarget);
        }
        public static ValueTask<object> GetRootNode(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeMap_getRootNode_4", dxTarget);
        }
        public static ValueTask<object> HideTooltip(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxTreeMap_hideTooltip_5", dxTarget);
        }
        public static ValueTask<object> ResetDrillDown(ElementReference dxTarget)
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
        public static ValueTask<object> Init(ElementReference dxTarget, DevExpress.Viz.Map.DxVectorMapOptions options)
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
        public static ValueTask<object> GetAreaSettings(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxVectorMap_GetOption", dxTarget, "areaSettings");
        }
        public static ValueTask<object> SetAreaSettings(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxVectorMap_SetOption", dxTarget, "areaSettings", value);
        }
        public static ValueTask<object> GetBackground(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxVectorMap_GetOption", dxTarget, "background");
        }
        public static ValueTask<object> SetBackground(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxVectorMap_SetOption", dxTarget, "background", value);
        }
        public static ValueTask<object> GetBounds(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxVectorMap_GetOption", dxTarget, "bounds");
        }
        public static ValueTask<object> SetBounds(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxVectorMap_SetOption", dxTarget, "bounds", value);
        }
        public static ValueTask<object> GetCenter(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxVectorMap_GetOption", dxTarget, "center");
        }
        public static ValueTask<object> SetCenter(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxVectorMap_SetOption", dxTarget, "center", value);
        }
        public static ValueTask<object> GetControlBar(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxVectorMap_GetOption", dxTarget, "controlBar");
        }
        public static ValueTask<object> SetControlBar(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxVectorMap_SetOption", dxTarget, "controlBar", value);
        }
        public static ValueTask<object> GetLayers(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxVectorMap_GetOption", dxTarget, "layers");
        }
        public static ValueTask<object> SetLayers(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxVectorMap_SetOption", dxTarget, "layers", value);
        }
        public static ValueTask<object> GetLegends(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxVectorMap_GetOption", dxTarget, "legends");
        }
        public static ValueTask<object> SetLegends(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxVectorMap_SetOption", dxTarget, "legends", value);
        }
        public static ValueTask<object> GetMapData(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxVectorMap_GetOption", dxTarget, "mapData");
        }
        public static ValueTask<object> SetMapData(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxVectorMap_SetOption", dxTarget, "mapData", value);
        }
        public static ValueTask<object> GetMarkers(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxVectorMap_GetOption", dxTarget, "markers");
        }
        public static ValueTask<object> SetMarkers(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxVectorMap_SetOption", dxTarget, "markers", value);
        }
        public static ValueTask<object> GetMarkerSettings(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxVectorMap_GetOption", dxTarget, "markerSettings");
        }
        public static ValueTask<object> SetMarkerSettings(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxVectorMap_SetOption", dxTarget, "markerSettings", value);
        }
        public static ValueTask<float?> GetMaxZoomFactor(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_DxVectorMap_GetOption", dxTarget, "maxZoomFactor");
        }
        public static ValueTask<object> SetMaxZoomFactor(ElementReference dxTarget, float? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxVectorMap_SetOption", dxTarget, "maxZoomFactor", value);
        }
        public static ValueTask<bool?> GetPanningEnabled(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxVectorMap_GetOption", dxTarget, "panningEnabled");
        }
        public static ValueTask<object> SetPanningEnabled(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxVectorMap_SetOption", dxTarget, "panningEnabled", value);
        }
        public static ValueTask<object> GetProjection(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxVectorMap_GetOption", dxTarget, "projection");
        }
        public static ValueTask<object> SetProjection(ElementReference dxTarget, object value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxVectorMap_SetOption", dxTarget, "projection", value);
        }
        public static ValueTask<bool?> GetTouchEnabled(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxVectorMap_GetOption", dxTarget, "touchEnabled");
        }
        public static ValueTask<object> SetTouchEnabled(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxVectorMap_SetOption", dxTarget, "touchEnabled", value);
        }
        public static ValueTask<bool?> GetWheelEnabled(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxVectorMap_GetOption", dxTarget, "wheelEnabled");
        }
        public static ValueTask<object> SetWheelEnabled(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxVectorMap_SetOption", dxTarget, "wheelEnabled", value);
        }
        public static ValueTask<float?> GetZoomFactor(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<float?>("BlazorDevExtreme_DxVectorMap_GetOption", dxTarget, "zoomFactor");
        }
        public static ValueTask<object> SetZoomFactor(ElementReference dxTarget, float? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxVectorMap_SetOption", dxTarget, "zoomFactor", value);
        }
        public static ValueTask<bool?> GetZoomingEnabled(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<bool?>("BlazorDevExtreme_DxVectorMap_GetOption", dxTarget, "zoomingEnabled");
        }
        public static ValueTask<object> SetZoomingEnabled(ElementReference dxTarget, bool? value)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxVectorMap_SetOption", dxTarget, "zoomingEnabled", value);
        }
        public static ValueTask<object> CenterEx(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxVectorMap_center_0", dxTarget);
        }
        public static ValueTask<object> CenterEx(ElementReference dxTarget, object centerCoordinates)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxVectorMap_center_1", dxTarget, centerCoordinates);
        }
        public static ValueTask<object> ClearAreaSelection(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxVectorMap_clearAreaSelection_2", dxTarget);
        }
        public static ValueTask<object> ClearMarkerSelection(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxVectorMap_clearMarkerSelection_3", dxTarget);
        }
        public static ValueTask<object> ClearSelection(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxVectorMap_clearSelection_4", dxTarget);
        }
        public static ValueTask<object> ConvertCoordinates(ElementReference dxTarget, float x, float y)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxVectorMap_convertCoordinates_5", dxTarget, x, y);
        }
        public static ValueTask<object> GetAreas(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxVectorMap_getAreas_6", dxTarget);
        }
        public static ValueTask<object> GetLayerByIndex(ElementReference dxTarget, float index)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxVectorMap_getLayerByIndex_7", dxTarget, index);
        }
        public static ValueTask<object> GetLayerByName(ElementReference dxTarget, string name)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxVectorMap_getLayerByName_8", dxTarget, name);
        }
        public static ValueTask<object> GetLayersEx(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxVectorMap_getLayers_9", dxTarget);
        }
        public static ValueTask<object> GetMarkersEx(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxVectorMap_getMarkers_10", dxTarget);
        }
        public static ValueTask<object> Viewport(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxVectorMap_viewport_11", dxTarget);
        }
        public static ValueTask<object> Viewport(ElementReference dxTarget, object viewportCoordinates)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxVectorMap_viewport_12", dxTarget, viewportCoordinates);
        }
        public static ValueTask<float> ZoomFactorEx(ElementReference dxTarget)
        {
            return JSRuntime.Current.InvokeAsync<float>("BlazorDevExtreme_DxVectorMap_zoomFactor_13", dxTarget);
        }
        public static ValueTask<object> ZoomFactorEx(ElementReference dxTarget, float zoomFactor)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_DxVectorMap_zoomFactor_14", dxTarget, zoomFactor);
        }
    }
    public class CoreInterop
    {
        public static ValueTask<object> CurrentPalette(string paletteName)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Core_currentPalette_0", paletteName);
        }
        public static ValueTask<object> CurrentTheme(string platform, string colorScheme)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Core_currentTheme_1", platform, colorScheme);
        }
        public static ValueTask<object> CurrentTheme(string theme)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Core_currentTheme_2", theme);
        }
        public static ValueTask<object> GetPalette(string paletteName)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Core_getPalette_3", paletteName);
        }
        public static ValueTask<object> RegisterPalette(string paletteName, object palette)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Core_registerPalette_4", paletteName, palette);
        }
        public static ValueTask<object> RegisterTheme(object customTheme, string baseTheme)
        {
            return JSRuntime.Current.InvokeAsync<object>("BlazorDevExtreme_Core_registerTheme_5", customTheme, baseTheme);
        }
    }
}
