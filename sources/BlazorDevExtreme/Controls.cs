using Microsoft.AspNetCore.Blazor.Browser.Interop;
using System;
using BlazorDevExtreme;

namespace DevExpress
{
    public class DataHelperMixinInterop
    {
        public static object GetDataSourceEx(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DataHelperMixin.getDataSource_0", identifier);
        }
    }
    public class DxEventInterop
    {
        public static bool IsDefaultPrevented(string identifier)
        {
            return RegisteredFunction.Invoke<bool>("BlazorDevExtreme.DxEvent.isDefaultPrevented_0", identifier);
        }
        public static bool IsImmediatePropagationStopped(string identifier)
        {
            return RegisteredFunction.Invoke<bool>("BlazorDevExtreme.DxEvent.isImmediatePropagationStopped_1", identifier);
        }
        public static bool IsPropagationStopped(string identifier)
        {
            return RegisteredFunction.Invoke<bool>("BlazorDevExtreme.DxEvent.isPropagationStopped_2", identifier);
        }
        public static void PreventDefault(string identifier)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxEvent.preventDefault_3", identifier);
        }
        public static void StopImmediatePropagation(string identifier)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxEvent.stopImmediatePropagation_4", identifier);
        }
        public static void StopPropagation(string identifier)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxEvent.stopPropagation_5", identifier);
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
        public static void ApplyChanges(string identifier)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.AnimationPresets.applyChanges_0", identifier);
        }
        public static void Clear(string identifier)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.AnimationPresets.clear_1", identifier);
        }
        public static void Clear(string identifier, string name)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.AnimationPresets.clear_2", identifier, name);
        }
        public static object GetPreset(string identifier, string name)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.AnimationPresets.getPreset_3", identifier, name);
        }
        public static void RegisterDefaultPresets(string identifier)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.AnimationPresets.registerDefaultPresets_4", identifier);
        }
        public static void RegisterPreset(string identifier, string name, object config)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.AnimationPresets.registerPreset_5", identifier, name, config);
        }
        public static void ResetToDefaults(string identifier)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.AnimationPresets.resetToDefaults_6", identifier);
        }
    }
    public class TransitionExecutorInterop
    {
        public static void Enter(string identifier, object elements, object animation)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.TransitionExecutor.enter_0", identifier, elements, animation);
        }
        public static void Leave(string identifier, object elements, object animation)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.TransitionExecutor.leave_1", identifier, elements, animation);
        }
        public static void Reset(string identifier)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.TransitionExecutor.reset_2", identifier);
        }
        public static object Start(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.TransitionExecutor.start_3", identifier);
        }
        public static void Stop(string identifier)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.TransitionExecutor.stop_4", identifier);
        }
    }
    public class ComponentInterop
    {
        public static event EventHandler<JQueryEventArgs> Disposing;
        public static event EventHandler<JQueryEventArgs> Initialized;
        public static event EventHandler<JQueryEventArgs> OptionChanged;
        public static void Init(string identifier, DevExpress.ComponentOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.Component.Init", identifier, json);
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
        public static void BeginUpdate(string identifier)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.Component.beginUpdate_0", identifier);
        }
        public static void EndUpdate(string identifier)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.Component.endUpdate_1", identifier);
        }
        public static object Instance(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.Component.instance_2", identifier);
        }
        public static object Off(string identifier, string eventName)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.Component.off_3", identifier, eventName);
        }
        public static object Off(string identifier, string eventName, object eventHandler)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.Component.off_4", identifier, eventName, eventHandler);
        }
        public static object On(string identifier, string eventName, object eventHandler)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.Component.on_5", identifier, eventName, eventHandler);
        }
        public static object On(string identifier, object events)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.Component.on_6", identifier, events);
        }
        public static object Option(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.Component.option_7", identifier);
        }
        public static object Option(string identifier, string optionName)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.Component.option_8", identifier, optionName);
        }
        public static void Option(string identifier, string optionName, object optionValue)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.Component.option_9", identifier, optionName, optionValue);
        }
        public static void Option(string identifier, object options)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.Component.option_10", identifier, options);
        }
    }
    public class DevicesObjectInterop
    {
        public static object Current(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DevicesObject.current_0", identifier);
        }
        public static void Current(string identifier, object deviceName)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DevicesObject.current_1", identifier, deviceName);
        }
        public static object Off(string identifier, string eventName)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DevicesObject.off_2", identifier, eventName);
        }
        public static object Off(string identifier, string eventName, object eventHandler)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DevicesObject.off_3", identifier, eventName, eventHandler);
        }
        public static object On(string identifier, string eventName, object eventHandler)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DevicesObject.on_4", identifier, eventName, eventHandler);
        }
        public static object On(string identifier, object events)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DevicesObject.on_5", identifier, events);
        }
        public static string Orientation(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DevicesObject.orientation_6", identifier);
        }
        public static object Real(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DevicesObject.real_7", identifier);
        }
    }
    public class DOMComponentInterop : ComponentInterop
    {
        public static event EventHandler<JQueryEventArgs> Disposing;
        public static event EventHandler<JQueryEventArgs> OptionChanged;
        public static void Init(string identifier, DevExpress.DOMComponentOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DOMComponent.Init", identifier, json);
        }
        public static void OnDisposing(string identifier)
        {
            Disposing?.Invoke(null, new JQueryEventArgs(identifier));
        }
        public static void OnOptionChanged(string identifier)
        {
            OptionChanged?.Invoke(null, new JQueryEventArgs(identifier));
        }
        public static object GetBindingOptions(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DOMComponent.GetOption", identifier, "bindingOptions");
        }
        public static void SetBindingOptions(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DOMComponent.SetOption", identifier, "bindingOptions", value);
        }
        public static object GetElementAttr(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DOMComponent.GetOption", identifier, "elementAttr");
        }
        public static void SetElementAttr(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DOMComponent.SetOption", identifier, "elementAttr", value);
        }
        public static object GetHeight(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DOMComponent.GetOption", identifier, "height");
        }
        public static void SetHeight(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DOMComponent.SetOption", identifier, "height", value);
        }
        public static bool? GetRtlEnabled(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DOMComponent.GetOption", identifier, "rtlEnabled");
        }
        public static void SetRtlEnabled(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DOMComponent.SetOption", identifier, "rtlEnabled", value);
        }
        public static object GetWidth(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DOMComponent.GetOption", identifier, "width");
        }
        public static void SetWidth(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DOMComponent.SetOption", identifier, "width", value);
        }
        public static void DefaultOptions(object rule)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DOMComponent.defaultOptions_0", rule);
        }
        public static object GetInstance(object element)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DOMComponent.getInstance_1", element);
        }
        public static void Dispose(string identifier)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DOMComponent.dispose_0", identifier);
        }
        public static object Element(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DOMComponent.element_1", identifier);
        }
    }
    public class EndpointSelectorInterop
    {
        public static string UrlFor(string identifier, string key)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.EndpointSelector.urlFor_0", identifier, key);
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
        public static string ToString(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.Guid.toString_0", identifier);
        }
        public static string ValueOf(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.Guid.valueOf_1", identifier);
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
        public static void Init(string identifier, DevExpress.Data.StoreOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.Store.Init", identifier, json);
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
        public static object GetErrorHandler(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.Store.GetOption", identifier, "errorHandler");
        }
        public static void SetErrorHandler(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.Store.SetOption", identifier, "errorHandler", value);
        }
        public static object GetKey(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.Store.GetOption", identifier, "key");
        }
        public static void SetKey(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.Store.SetOption", identifier, "key", value);
        }
        public static object ByKey(string identifier, object key)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.Store.byKey_0", identifier, key);
        }
        public static object Insert(string identifier, object values)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.Store.insert_1", identifier, values);
        }
        public static object Key(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.Store.key_2", identifier);
        }
        public static object KeyOf(string identifier, object obj)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.Store.keyOf_3", identifier, obj);
        }
        public static object Load(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.Store.load_4", identifier);
        }
        public static object Load(string identifier, object options)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.Store.load_5", identifier, options);
        }
        public static object Off(string identifier, string eventName)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.Store.off_6", identifier, eventName);
        }
        public static object Off(string identifier, string eventName, object eventHandler)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.Store.off_7", identifier, eventName, eventHandler);
        }
        public static object On(string identifier, string eventName, object eventHandler)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.Store.on_8", identifier, eventName, eventHandler);
        }
        public static object On(string identifier, object events)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.Store.on_9", identifier, events);
        }
        public static object Remove(string identifier, object key)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.Store.remove_10", identifier, key);
        }
        public static object TotalCount(string identifier, object obj)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.Store.totalCount_11", identifier, obj);
        }
        public static object Update(string identifier, object key, object values)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.Store.update_12", identifier, key, values);
        }
    }
    public class ArrayStoreInterop : StoreInterop
    {
        public static void Init(string identifier, DevExpress.Data.ArrayStoreOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.ArrayStore.Init", identifier, json);
        }
        public static object GetData(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.ArrayStore.GetOption", identifier, "data");
        }
        public static void SetData(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.ArrayStore.SetOption", identifier, "data", value);
        }
        public static void Clear(string identifier)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.ArrayStore.clear_0", identifier);
        }
        public static object CreateQuery(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.ArrayStore.createQuery_1", identifier);
        }
    }
    public class CustomStoreInterop : StoreInterop
    {
        public static void Init(string identifier, DevExpress.Data.CustomStoreOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.CustomStore.Init", identifier, json);
        }
        public static object GetByKey(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.CustomStore.GetOption", identifier, "byKey");
        }
        public static void SetByKey(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.CustomStore.SetOption", identifier, "byKey", value);
        }
        public static bool? GetCacheRawData(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.CustomStore.GetOption", identifier, "cacheRawData");
        }
        public static void SetCacheRawData(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.CustomStore.SetOption", identifier, "cacheRawData", value);
        }
        public static object GetInsert(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.CustomStore.GetOption", identifier, "insert");
        }
        public static void SetInsert(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.CustomStore.SetOption", identifier, "insert", value);
        }
        public static object GetLoad(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.CustomStore.GetOption", identifier, "load");
        }
        public static void SetLoad(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.CustomStore.SetOption", identifier, "load", value);
        }
        public static string GetLoadMode(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.CustomStore.GetOption", identifier, "loadMode");
        }
        public static void SetLoadMode(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.CustomStore.SetOption", identifier, "loadMode", value);
        }
        public static object GetRemove(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.CustomStore.GetOption", identifier, "remove");
        }
        public static void SetRemove(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.CustomStore.SetOption", identifier, "remove", value);
        }
        public static object GetTotalCount(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.CustomStore.GetOption", identifier, "totalCount");
        }
        public static void SetTotalCount(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.CustomStore.SetOption", identifier, "totalCount", value);
        }
        public static object GetUpdate(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.CustomStore.GetOption", identifier, "update");
        }
        public static void SetUpdate(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.CustomStore.SetOption", identifier, "update", value);
        }
        public static bool? GetUseDefaultSearch(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.CustomStore.GetOption", identifier, "useDefaultSearch");
        }
        public static void SetUseDefaultSearch(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.CustomStore.SetOption", identifier, "useDefaultSearch", value);
        }
        public static void ClearRawDataCache(string identifier)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.CustomStore.clearRawDataCache_0", identifier);
        }
    }
    public class DataSourceInterop
    {
        public static event EventHandler<JQueryEventArgs> Changed;
        public static event EventHandler<JQueryEventArgs> LoadError;
        public static event EventHandler<JQueryEventArgs> LoadingChanged;
        public static void Init(string identifier, DevExpress.Data.DataSourceOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DataSource.Init", identifier, json);
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
        public static object GetCustomQueryParams(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DataSource.GetOption", identifier, "customQueryParams");
        }
        public static void SetCustomQueryParams(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DataSource.SetOption", identifier, "customQueryParams", value);
        }
        public static object GetExpand(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DataSource.GetOption", identifier, "expand");
        }
        public static void SetExpand(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DataSource.SetOption", identifier, "expand", value);
        }
        public static object GetFilter(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DataSource.GetOption", identifier, "filter");
        }
        public static void SetFilter(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DataSource.SetOption", identifier, "filter", value);
        }
        public static object GetGroup(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DataSource.GetOption", identifier, "group");
        }
        public static void SetGroup(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DataSource.SetOption", identifier, "group", value);
        }
        public static object GetMap(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DataSource.GetOption", identifier, "map");
        }
        public static void SetMap(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DataSource.SetOption", identifier, "map", value);
        }
        public static float? GetPageSize(string identifier)
        {
            return RegisteredFunction.Invoke<float?>("BlazorDevExtreme.DataSource.GetOption", identifier, "pageSize");
        }
        public static void SetPageSize(string identifier, float? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DataSource.SetOption", identifier, "pageSize", value);
        }
        public static bool? GetPaginate(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DataSource.GetOption", identifier, "paginate");
        }
        public static void SetPaginate(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DataSource.SetOption", identifier, "paginate", value);
        }
        public static object GetPostProcess(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DataSource.GetOption", identifier, "postProcess");
        }
        public static void SetPostProcess(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DataSource.SetOption", identifier, "postProcess", value);
        }
        public static bool? GetRequireTotalCount(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DataSource.GetOption", identifier, "requireTotalCount");
        }
        public static void SetRequireTotalCount(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DataSource.SetOption", identifier, "requireTotalCount", value);
        }
        public static object GetSearchExpr(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DataSource.GetOption", identifier, "searchExpr");
        }
        public static void SetSearchExpr(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DataSource.SetOption", identifier, "searchExpr", value);
        }
        public static string GetSearchOperation(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DataSource.GetOption", identifier, "searchOperation");
        }
        public static void SetSearchOperation(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DataSource.SetOption", identifier, "searchOperation", value);
        }
        public static object GetSearchValue(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DataSource.GetOption", identifier, "searchValue");
        }
        public static void SetSearchValue(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DataSource.SetOption", identifier, "searchValue", value);
        }
        public static object GetSelect(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DataSource.GetOption", identifier, "select");
        }
        public static void SetSelect(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DataSource.SetOption", identifier, "select", value);
        }
        public static object GetSort(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DataSource.GetOption", identifier, "sort");
        }
        public static void SetSort(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DataSource.SetOption", identifier, "sort", value);
        }
        public static object GetStore(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DataSource.GetOption", identifier, "store");
        }
        public static void SetStore(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DataSource.SetOption", identifier, "store", value);
        }
        public static bool Cancel(string identifier)
        {
            return RegisteredFunction.Invoke<bool>("BlazorDevExtreme.DataSource.cancel_0", identifier);
        }
        public static void Dispose(string identifier)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DataSource.dispose_1", identifier);
        }
        public static object Filter(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DataSource.filter_2", identifier);
        }
        public static void Filter(string identifier, object filterExpr)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DataSource.filter_3", identifier, filterExpr);
        }
        public static object Group(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DataSource.group_4", identifier);
        }
        public static void Group(string identifier, object groupExpr)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DataSource.group_5", identifier, groupExpr);
        }
        public static bool IsLastPage(string identifier)
        {
            return RegisteredFunction.Invoke<bool>("BlazorDevExtreme.DataSource.isLastPage_6", identifier);
        }
        public static bool IsLoaded(string identifier)
        {
            return RegisteredFunction.Invoke<bool>("BlazorDevExtreme.DataSource.isLoaded_7", identifier);
        }
        public static bool IsLoading(string identifier)
        {
            return RegisteredFunction.Invoke<bool>("BlazorDevExtreme.DataSource.isLoading_8", identifier);
        }
        public static object Items(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DataSource.items_9", identifier);
        }
        public static object Key(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DataSource.key_10", identifier);
        }
        public static object Load(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DataSource.load_11", identifier);
        }
        public static object LoadOptions(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DataSource.loadOptions_12", identifier);
        }
        public static object Off(string identifier, string eventName)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DataSource.off_13", identifier, eventName);
        }
        public static object Off(string identifier, string eventName, object eventHandler)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DataSource.off_14", identifier, eventName, eventHandler);
        }
        public static object On(string identifier, string eventName, object eventHandler)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DataSource.on_15", identifier, eventName, eventHandler);
        }
        public static object On(string identifier, object events)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DataSource.on_16", identifier, events);
        }
        public static float PageIndex(string identifier)
        {
            return RegisteredFunction.Invoke<float>("BlazorDevExtreme.DataSource.pageIndex_17", identifier);
        }
        public static void PageIndex(string identifier, float newIndex)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DataSource.pageIndex_18", identifier, newIndex);
        }
        public static float PageSize(string identifier)
        {
            return RegisteredFunction.Invoke<float>("BlazorDevExtreme.DataSource.pageSize_19", identifier);
        }
        public static void PageSize(string identifier, float value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DataSource.pageSize_20", identifier, value);
        }
        public static bool Paginate(string identifier)
        {
            return RegisteredFunction.Invoke<bool>("BlazorDevExtreme.DataSource.paginate_21", identifier);
        }
        public static void Paginate(string identifier, bool value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DataSource.paginate_22", identifier, value);
        }
        public static object Reload(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DataSource.reload_23", identifier);
        }
        public static bool RequireTotalCount(string identifier)
        {
            return RegisteredFunction.Invoke<bool>("BlazorDevExtreme.DataSource.requireTotalCount_24", identifier);
        }
        public static void RequireTotalCount(string identifier, bool value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DataSource.requireTotalCount_25", identifier, value);
        }
        public static object SearchExpr(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DataSource.searchExpr_26", identifier);
        }
        public static void SearchExpr(string identifier, object expr)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DataSource.searchExpr_27", identifier, expr);
        }
        public static string SearchOperation(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DataSource.searchOperation_28", identifier);
        }
        public static void SearchOperation(string identifier, string op)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DataSource.searchOperation_29", identifier, op);
        }
        public static object SearchValue(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DataSource.searchValue_30", identifier);
        }
        public static void SearchValue(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DataSource.searchValue_31", identifier, value);
        }
        public static object Select(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DataSource.select_32", identifier);
        }
        public static void Select(string identifier, object expr)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DataSource.select_33", identifier, expr);
        }
        public static object Sort(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DataSource.sort_34", identifier);
        }
        public static void Sort(string identifier, object sortExpr)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DataSource.sort_35", identifier, sortExpr);
        }
        public static object Store(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DataSource.store_36", identifier);
        }
        public static float TotalCount(string identifier)
        {
            return RegisteredFunction.Invoke<float>("BlazorDevExtreme.DataSource.totalCount_37", identifier);
        }
    }
    public class LocalStoreInterop : ArrayStoreInterop
    {
        public static void Init(string identifier, DevExpress.Data.LocalStoreOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.LocalStore.Init", identifier, json);
        }
        public static float? GetFlushInterval(string identifier)
        {
            return RegisteredFunction.Invoke<float?>("BlazorDevExtreme.LocalStore.GetOption", identifier, "flushInterval");
        }
        public static void SetFlushInterval(string identifier, float? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.LocalStore.SetOption", identifier, "flushInterval", value);
        }
        public static bool? GetImmediate(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.LocalStore.GetOption", identifier, "immediate");
        }
        public static void SetImmediate(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.LocalStore.SetOption", identifier, "immediate", value);
        }
        public static string GetName(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.LocalStore.GetOption", identifier, "name");
        }
        public static void SetName(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.LocalStore.SetOption", identifier, "name", value);
        }
        public static void Clear(string identifier)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.LocalStore.clear_0", identifier);
        }
    }
    public class QueryInterop
    {
        public static object Aggregate(string identifier, object seed, object step, object finalize)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.Query.aggregate_0", identifier, seed, step, finalize);
        }
        public static object Aggregate(string identifier, object step)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.Query.aggregate_1", identifier, step);
        }
        public static object Avg(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.Query.avg_2", identifier);
        }
        public static object Avg(string identifier, object getter)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.Query.avg_3", identifier, getter);
        }
        public static object Count(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.Query.count_4", identifier);
        }
        public static object Enumerate(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.Query.enumerate_5", identifier);
        }
        public static object Filter(string identifier, object criteria)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.Query.filter_6", identifier, criteria);
        }
        public static object GroupBy(string identifier, object getter)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.Query.groupBy_8", identifier, getter);
        }
        public static object Max(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.Query.max_9", identifier);
        }
        public static object Max(string identifier, object getter)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.Query.max_10", identifier, getter);
        }
        public static object Min(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.Query.min_11", identifier);
        }
        public static object Min(string identifier, object getter)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.Query.min_12", identifier, getter);
        }
        public static object Select(string identifier, object getter)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.Query.select_13", identifier, getter);
        }
        public static object Slice(string identifier, float skip, float take)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.Query.slice_14", identifier, skip, take);
        }
        public static object SortBy(string identifier, object getter)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.Query.sortBy_15", identifier, getter);
        }
        public static object SortBy(string identifier, object getter, bool desc)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.Query.sortBy_16", identifier, getter, desc);
        }
        public static object Sum(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.Query.sum_17", identifier);
        }
        public static object Sum(string identifier, object getter)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.Query.sum_18", identifier, getter);
        }
        public static object ThenBy(string identifier, object getter)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.Query.thenBy_19", identifier, getter);
        }
        public static object ThenBy(string identifier, object getter, bool desc)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.Query.thenBy_20", identifier, getter, desc);
        }
        public static object ToArray(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.Query.toArray_21", identifier);
        }
    }
    public class ODataContextInterop
    {
        public static void Init(string identifier, DevExpress.Data.ODataContextOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.ODataContext.Init", identifier, json);
        }
        public static object GetBeforeSend(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.ODataContext.GetOption", identifier, "beforeSend");
        }
        public static void SetBeforeSend(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.ODataContext.SetOption", identifier, "beforeSend", value);
        }
        public static bool? GetDeserializeDates(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.ODataContext.GetOption", identifier, "deserializeDates");
        }
        public static void SetDeserializeDates(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.ODataContext.SetOption", identifier, "deserializeDates", value);
        }
        public static object GetEntities(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.ODataContext.GetOption", identifier, "entities");
        }
        public static void SetEntities(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.ODataContext.SetOption", identifier, "entities", value);
        }
        public static object GetErrorHandler(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.ODataContext.GetOption", identifier, "errorHandler");
        }
        public static void SetErrorHandler(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.ODataContext.SetOption", identifier, "errorHandler", value);
        }
        public static bool? GetJsonp(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.ODataContext.GetOption", identifier, "jsonp");
        }
        public static void SetJsonp(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.ODataContext.SetOption", identifier, "jsonp", value);
        }
        public static string GetUrl(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.ODataContext.GetOption", identifier, "url");
        }
        public static void SetUrl(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.ODataContext.SetOption", identifier, "url", value);
        }
        public static float? GetVersion(string identifier)
        {
            return RegisteredFunction.Invoke<float?>("BlazorDevExtreme.ODataContext.GetOption", identifier, "version");
        }
        public static void SetVersion(string identifier, float? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.ODataContext.SetOption", identifier, "version", value);
        }
        public static bool? GetWithCredentials(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.ODataContext.GetOption", identifier, "withCredentials");
        }
        public static void SetWithCredentials(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.ODataContext.SetOption", identifier, "withCredentials", value);
        }
        public static object Get(string identifier, string operationName, object @params)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.ODataContext.get_0", identifier, operationName, @params);
        }
        public static object Invoke(string identifier, string operationName, object @params, object httpMethod)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.ODataContext.invoke_1", identifier, operationName, @params, httpMethod);
        }
        public static object ObjectLink(string identifier, string entityAlias, object key)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.ODataContext.objectLink_2", identifier, entityAlias, key);
        }
    }
    public class ODataStoreInterop : StoreInterop
    {
        public static event EventHandler<JQueryEventArgs> Loading;
        public static void Init(string identifier, DevExpress.Data.ODataStoreOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.ODataStore.Init", identifier, json);
        }
        public static void OnLoading(string identifier)
        {
            Loading?.Invoke(null, new JQueryEventArgs(identifier));
        }
        public static object GetBeforeSend(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.ODataStore.GetOption", identifier, "beforeSend");
        }
        public static void SetBeforeSend(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.ODataStore.SetOption", identifier, "beforeSend", value);
        }
        public static bool? GetDeserializeDates(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.ODataStore.GetOption", identifier, "deserializeDates");
        }
        public static void SetDeserializeDates(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.ODataStore.SetOption", identifier, "deserializeDates", value);
        }
        public static object GetFieldTypes(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.ODataStore.GetOption", identifier, "fieldTypes");
        }
        public static void SetFieldTypes(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.ODataStore.SetOption", identifier, "fieldTypes", value);
        }
        public static bool? GetJsonp(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.ODataStore.GetOption", identifier, "jsonp");
        }
        public static void SetJsonp(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.ODataStore.SetOption", identifier, "jsonp", value);
        }
        public static object GetKeyType(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.ODataStore.GetOption", identifier, "keyType");
        }
        public static void SetKeyType(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.ODataStore.SetOption", identifier, "keyType", value);
        }
        public static string GetUrl(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.ODataStore.GetOption", identifier, "url");
        }
        public static void SetUrl(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.ODataStore.SetOption", identifier, "url", value);
        }
        public static float? GetVersion(string identifier)
        {
            return RegisteredFunction.Invoke<float?>("BlazorDevExtreme.ODataStore.GetOption", identifier, "version");
        }
        public static void SetVersion(string identifier, float? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.ODataStore.SetOption", identifier, "version", value);
        }
        public static bool? GetWithCredentials(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.ODataStore.GetOption", identifier, "withCredentials");
        }
        public static void SetWithCredentials(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.ODataStore.SetOption", identifier, "withCredentials", value);
        }
        public static object ByKey(string identifier, object key)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.ODataStore.byKey_0", identifier, key);
        }
        public static object ByKey(string identifier, object key, object extraOptions)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.ODataStore.byKey_1", identifier, key, extraOptions);
        }
        public static object CreateQuery(string identifier, object loadOptions)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.ODataStore.createQuery_2", identifier, loadOptions);
        }
        public static object Load(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.ODataStore.load_3", identifier);
        }
        public static object Load(string identifier, object options)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.ODataStore.load_4", identifier, options);
        }
    }
    public class EdmLiteralInterop
    {
        public static string ValueOf(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.EdmLiteral.valueOf_0", identifier);
        }
    }
    public class PivotGridDataSourceInterop
    {
        public static event EventHandler<JQueryEventArgs> Changed;
        public static event EventHandler<JQueryEventArgs> FieldsPrepared;
        public static event EventHandler<JQueryEventArgs> LoadError;
        public static event EventHandler<JQueryEventArgs> LoadingChanged;
        public static void Init(string identifier, DevExpress.Data.PivotGridDataSourceOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.PivotGridDataSource.Init", identifier, json);
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
        public static object GetFields(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.PivotGridDataSource.GetOption", identifier, "fields");
        }
        public static void SetFields(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.PivotGridDataSource.SetOption", identifier, "fields", value);
        }
        public static object GetFilter(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.PivotGridDataSource.GetOption", identifier, "filter");
        }
        public static void SetFilter(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.PivotGridDataSource.SetOption", identifier, "filter", value);
        }
        public static bool? GetRemoteOperations(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.PivotGridDataSource.GetOption", identifier, "remoteOperations");
        }
        public static void SetRemoteOperations(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.PivotGridDataSource.SetOption", identifier, "remoteOperations", value);
        }
        public static bool? GetRetrieveFields(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.PivotGridDataSource.GetOption", identifier, "retrieveFields");
        }
        public static void SetRetrieveFields(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.PivotGridDataSource.SetOption", identifier, "retrieveFields", value);
        }
        public static object GetStore(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.PivotGridDataSource.GetOption", identifier, "store");
        }
        public static void SetStore(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.PivotGridDataSource.SetOption", identifier, "store", value);
        }
        public static void CollapseAll(string identifier, object id)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.PivotGridDataSource.collapseAll_0", identifier, id);
        }
        public static void CollapseHeaderItem(string identifier, string area, object path)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.PivotGridDataSource.collapseHeaderItem_1", identifier, area, path);
        }
        public static object CreateDrillDownDataSource(string identifier, object options)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.PivotGridDataSource.createDrillDownDataSource_2", identifier, options);
        }
        public static void Dispose(string identifier)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.PivotGridDataSource.dispose_3", identifier);
        }
        public static void ExpandAll(string identifier, object id)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.PivotGridDataSource.expandAll_4", identifier, id);
        }
        public static void ExpandHeaderItem(string identifier, string area, object path)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.PivotGridDataSource.expandHeaderItem_5", identifier, area, path);
        }
        public static object Field(string identifier, object id)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.PivotGridDataSource.field_6", identifier, id);
        }
        public static void Field(string identifier, object id, object options)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.PivotGridDataSource.field_7", identifier, id, options);
        }
        public static object Fields(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.PivotGridDataSource.fields_8", identifier);
        }
        public static void Fields(string identifier, object fields)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.PivotGridDataSource.fields_9", identifier, fields);
        }
        public static object Filter(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.PivotGridDataSource.filter_10", identifier);
        }
        public static void Filter(string identifier, object filterExpr)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.PivotGridDataSource.filter_11", identifier, filterExpr);
        }
        public static object GetAreaFields(string identifier, string area, bool collectGroups)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.PivotGridDataSource.getAreaFields_12", identifier, area, collectGroups);
        }
        public static object GetData(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.PivotGridDataSource.getData_13", identifier);
        }
        public static bool IsLoading(string identifier)
        {
            return RegisteredFunction.Invoke<bool>("BlazorDevExtreme.PivotGridDataSource.isLoading_14", identifier);
        }
        public static object Load(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.PivotGridDataSource.load_15", identifier);
        }
        public static object Off(string identifier, string eventName)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.PivotGridDataSource.off_16", identifier, eventName);
        }
        public static object Off(string identifier, string eventName, object eventHandler)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.PivotGridDataSource.off_17", identifier, eventName, eventHandler);
        }
        public static object On(string identifier, string eventName, object eventHandler)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.PivotGridDataSource.on_18", identifier, eventName, eventHandler);
        }
        public static object On(string identifier, object events)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.PivotGridDataSource.on_19", identifier, events);
        }
        public static object Reload(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.PivotGridDataSource.reload_20", identifier);
        }
        public static object State(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.PivotGridDataSource.state_21", identifier);
        }
        public static void State(string identifier, object state)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.PivotGridDataSource.state_22", identifier, state);
        }
    }
    public class XmlaStoreInterop
    {
        public static void Init(string identifier, DevExpress.Data.XmlaStoreOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.XmlaStore.Init", identifier, json);
        }
        public static object GetBeforeSend(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.XmlaStore.GetOption", identifier, "beforeSend");
        }
        public static void SetBeforeSend(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.XmlaStore.SetOption", identifier, "beforeSend", value);
        }
        public static string GetCatalog(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.XmlaStore.GetOption", identifier, "catalog");
        }
        public static void SetCatalog(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.XmlaStore.SetOption", identifier, "catalog", value);
        }
        public static string GetCube(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.XmlaStore.GetOption", identifier, "cube");
        }
        public static void SetCube(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.XmlaStore.SetOption", identifier, "cube", value);
        }
        public static string GetUrl(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.XmlaStore.GetOption", identifier, "url");
        }
        public static void SetUrl(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.XmlaStore.SetOption", identifier, "url", value);
        }
    }
}
namespace DevExpress.Core
{
    public class EventsMixinInterop
    {
        public static object Off(string identifier, string eventName)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.EventsMixin.off_0", identifier, eventName);
        }
        public static object Off(string identifier, string eventName, object eventHandler)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.EventsMixin.off_1", identifier, eventName, eventHandler);
        }
        public static object On(string identifier, string eventName, object eventHandler)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.EventsMixin.on_2", identifier, eventName, eventHandler);
        }
        public static object On(string identifier, object events)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.EventsMixin.on_3", identifier, events);
        }
    }
}
namespace DevExpress.Framework
{
    public class DxCommandInterop : DOMComponentInterop
    {
        public static event EventHandler<JQueryEventArgs> Execute;
        public static void Init(string identifier, DevExpress.Framework.DxCommandOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxCommand.Init", identifier, json);
        }
        public static void OnExecute(string identifier)
        {
            Execute?.Invoke(null, new JQueryEventArgs(identifier));
        }
        public static bool? GetDisabled(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxCommand.GetOption", identifier, "disabled");
        }
        public static void SetDisabled(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxCommand.SetOption", identifier, "disabled", value);
        }
        public static string GetIcon(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxCommand.GetOption", identifier, "icon");
        }
        public static void SetIcon(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxCommand.SetOption", identifier, "icon", value);
        }
        public static object GetIconSrc(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxCommand.GetOption", identifier, "iconSrc");
        }
        public static void SetIconSrc(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxCommand.SetOption", identifier, "iconSrc", value);
        }
        public static string GetId(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxCommand.GetOption", identifier, "id");
        }
        public static void SetId(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxCommand.SetOption", identifier, "id", value);
        }
        public static string GetRenderStage(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxCommand.GetOption", identifier, "renderStage");
        }
        public static void SetRenderStage(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxCommand.SetOption", identifier, "renderStage", value);
        }
        public static string GetTitle(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxCommand.GetOption", identifier, "title");
        }
        public static void SetTitle(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxCommand.SetOption", identifier, "title", value);
        }
        public static string GetType(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxCommand.GetOption", identifier, "type");
        }
        public static void SetType(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxCommand.SetOption", identifier, "type", value);
        }
        public static bool? GetVisible(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxCommand.GetOption", identifier, "visible");
        }
        public static void SetVisible(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxCommand.SetOption", identifier, "visible", value);
        }
        public static void DoExecute(string identifier)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxCommand.execute_0", identifier);
        }
    }
    public class RouterInterop
    {
        public static string Format(string identifier, object obj)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.Router.format_0", identifier, obj);
        }
        public static object Parse(string identifier, string uri)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.Router.parse_1", identifier, uri);
        }
        public static void Register(string identifier, string pattern, object defaults, object constraints)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.Router.register_2", identifier, pattern, defaults, constraints);
        }
    }
    public class StateManagerInterop
    {
        public static void Init(string identifier, DevExpress.Framework.StateManagerOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.StateManager.Init", identifier, json);
        }
        public static object GetStorage(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.StateManager.GetOption", identifier, "storage");
        }
        public static void SetStorage(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.StateManager.SetOption", identifier, "storage", value);
        }
        public static void AddStateSource(string identifier, object stateSource)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.StateManager.addStateSource_0", identifier, stateSource);
        }
        public static void ClearState(string identifier)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.StateManager.clearState_1", identifier);
        }
        public static void RemoveStateSource(string identifier, object stateSource)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.StateManager.removeStateSource_2", identifier, stateSource);
        }
        public static void RestoreState(string identifier)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.StateManager.restoreState_3", identifier);
        }
        public static void SaveState(string identifier)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.StateManager.saveState_4", identifier);
        }
    }
    public class ViewCacheInterop
    {
        public static void Clear(string identifier)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.ViewCache.clear_0", identifier);
        }
        public static object GetView(string identifier, string key)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.ViewCache.getView_1", identifier, key);
        }
        public static bool HasView(string identifier, string key)
        {
            return RegisteredFunction.Invoke<bool>("BlazorDevExtreme.ViewCache.hasView_2", identifier, key);
        }
        public static object Off(string identifier, string eventName)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.ViewCache.off_3", identifier, eventName);
        }
        public static object Off(string identifier, string eventName, object eventHandler)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.ViewCache.off_4", identifier, eventName, eventHandler);
        }
        public static object On(string identifier, string eventName, object eventHandler)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.ViewCache.on_5", identifier, eventName, eventHandler);
        }
        public static object On(string identifier, object events)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.ViewCache.on_6", identifier, events);
        }
        public static object RemoveView(string identifier, string key)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.ViewCache.removeView_7", identifier, key);
        }
        public static void SetView(string identifier, string key, object viewInfo)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.ViewCache.setView_8", identifier, key, viewInfo);
        }
    }
    public class DxCommandContainerInterop
    {
        public static void Init(string identifier, DevExpress.Framework.DxCommandContainerOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxCommandContainer.Init", identifier, json);
        }
        public static string GetId(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxCommandContainer.GetOption", identifier, "id");
        }
        public static void SetId(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxCommandContainer.SetOption", identifier, "id", value);
        }
    }
    public class DxViewInterop
    {
        public static void Init(string identifier, DevExpress.Framework.DxViewOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxView.Init", identifier, json);
        }
        public static bool? GetDisableCache(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxView.GetOption", identifier, "disableCache");
        }
        public static void SetDisableCache(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxView.SetOption", identifier, "disableCache", value);
        }
        public static bool? GetModal(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxView.GetOption", identifier, "modal");
        }
        public static void SetModal(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxView.SetOption", identifier, "modal", value);
        }
        public static string GetName(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxView.GetOption", identifier, "name");
        }
        public static void SetName(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxView.SetOption", identifier, "name", value);
        }
        public static string GetOrientation(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxView.GetOption", identifier, "orientation");
        }
        public static void SetOrientation(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxView.SetOption", identifier, "orientation", value);
        }
        public static string GetPane(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxView.GetOption", identifier, "pane");
        }
        public static void SetPane(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxView.SetOption", identifier, "pane", value);
        }
        public static string GetTitle(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxView.GetOption", identifier, "title");
        }
        public static void SetTitle(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxView.SetOption", identifier, "title", value);
        }
    }
    public class DxLayoutInterop
    {
        public static void Init(string identifier, DevExpress.Framework.DxLayoutOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxLayout.Init", identifier, json);
        }
        public static string GetName(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxLayout.GetOption", identifier, "name");
        }
        public static void SetName(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxLayout.SetOption", identifier, "name", value);
        }
    }
    public class DxViewPlaceholderInterop
    {
        public static void Init(string identifier, DevExpress.Framework.DxViewPlaceholderOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxViewPlaceholder.Init", identifier, json);
        }
        public static string GetViewName(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxViewPlaceholder.GetOption", identifier, "viewName");
        }
        public static void SetViewName(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxViewPlaceholder.SetOption", identifier, "viewName", value);
        }
    }
    public class DxTransitionInterop
    {
        public static void Init(string identifier, DevExpress.Framework.DxTransitionOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTransition.Init", identifier, json);
        }
        public static string GetAnimation(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxTransition.GetOption", identifier, "animation");
        }
        public static void SetAnimation(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTransition.SetOption", identifier, "animation", value);
        }
        public static string GetName(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxTransition.GetOption", identifier, "name");
        }
        public static void SetName(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTransition.SetOption", identifier, "name", value);
        }
        public static string GetType(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxTransition.GetOption", identifier, "type");
        }
        public static void SetType(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTransition.SetOption", identifier, "type", value);
        }
    }
    public class DxContentPlaceholderInterop
    {
        public static void Init(string identifier, DevExpress.Framework.DxContentPlaceholderOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxContentPlaceholder.Init", identifier, json);
        }
        public static string GetAnimation(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxContentPlaceholder.GetOption", identifier, "animation");
        }
        public static void SetAnimation(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxContentPlaceholder.SetOption", identifier, "animation", value);
        }
        public static string GetContentCssPosition(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxContentPlaceholder.GetOption", identifier, "contentCssPosition");
        }
        public static void SetContentCssPosition(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxContentPlaceholder.SetOption", identifier, "contentCssPosition", value);
        }
        public static string GetName(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxContentPlaceholder.GetOption", identifier, "name");
        }
        public static void SetName(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxContentPlaceholder.SetOption", identifier, "name", value);
        }
        public static string GetTransition(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxContentPlaceholder.GetOption", identifier, "transition");
        }
        public static void SetTransition(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxContentPlaceholder.SetOption", identifier, "transition", value);
        }
    }
    public class DxContentInterop
    {
        public static void Init(string identifier, DevExpress.Framework.DxContentOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxContent.Init", identifier, json);
        }
        public static string GetTargetPlaceholder(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxContent.GetOption", identifier, "targetPlaceholder");
        }
        public static void SetTargetPlaceholder(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxContent.SetOption", identifier, "targetPlaceholder", value);
        }
    }
}
namespace DevExpress.Framework.Html
{
    public class HtmlApplicationInterop
    {
        public static void Init(string identifier, DevExpress.Framework.Html.HtmlApplicationOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.HtmlApplication.Init", identifier, json);
        }
        public static object GetAnimationSet(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.HtmlApplication.GetOption", identifier, "animationSet");
        }
        public static void SetAnimationSet(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.HtmlApplication.SetOption", identifier, "animationSet", value);
        }
        public static object GetCommandMapping(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.HtmlApplication.GetOption", identifier, "commandMapping");
        }
        public static void SetCommandMapping(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.HtmlApplication.SetOption", identifier, "commandMapping", value);
        }
        public static bool? GetDisableViewCache(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.HtmlApplication.GetOption", identifier, "disableViewCache");
        }
        public static void SetDisableViewCache(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.HtmlApplication.SetOption", identifier, "disableViewCache", value);
        }
        public static object GetLayoutSet(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.HtmlApplication.GetOption", identifier, "layoutSet");
        }
        public static void SetLayoutSet(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.HtmlApplication.SetOption", identifier, "layoutSet", value);
        }
        public static string GetMode(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.HtmlApplication.GetOption", identifier, "mode");
        }
        public static void SetMode(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.HtmlApplication.SetOption", identifier, "mode", value);
        }
        public static object GetNamespace(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.HtmlApplication.GetOption", identifier, "namespace");
        }
        public static void SetNamespace(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.HtmlApplication.SetOption", identifier, "namespace", value);
        }
        public static string GetNavigateToRootViewMode(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.HtmlApplication.GetOption", identifier, "navigateToRootViewMode");
        }
        public static void SetNavigateToRootViewMode(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.HtmlApplication.SetOption", identifier, "navigateToRootViewMode", value);
        }
        public static object GetNavigation(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.HtmlApplication.GetOption", identifier, "navigation");
        }
        public static void SetNavigation(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.HtmlApplication.SetOption", identifier, "navigation", value);
        }
        public static object GetRouter(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.HtmlApplication.GetOption", identifier, "router");
        }
        public static void SetRouter(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.HtmlApplication.SetOption", identifier, "router", value);
        }
        public static object GetStateManager(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.HtmlApplication.GetOption", identifier, "stateManager");
        }
        public static void SetStateManager(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.HtmlApplication.SetOption", identifier, "stateManager", value);
        }
        public static object GetStateStorage(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.HtmlApplication.GetOption", identifier, "stateStorage");
        }
        public static void SetStateStorage(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.HtmlApplication.SetOption", identifier, "stateStorage", value);
        }
        public static string GetTemplatesVersion(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.HtmlApplication.GetOption", identifier, "templatesVersion");
        }
        public static void SetTemplatesVersion(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.HtmlApplication.SetOption", identifier, "templatesVersion", value);
        }
        public static bool? GetUseViewTitleAsBackText(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.HtmlApplication.GetOption", identifier, "useViewTitleAsBackText");
        }
        public static void SetUseViewTitleAsBackText(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.HtmlApplication.SetOption", identifier, "useViewTitleAsBackText", value);
        }
        public static object GetViewCache(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.HtmlApplication.GetOption", identifier, "viewCache");
        }
        public static void SetViewCache(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.HtmlApplication.SetOption", identifier, "viewCache", value);
        }
        public static float? GetViewCacheSize(string identifier)
        {
            return RegisteredFunction.Invoke<float?>("BlazorDevExtreme.HtmlApplication.GetOption", identifier, "viewCacheSize");
        }
        public static void SetViewCacheSize(string identifier, float? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.HtmlApplication.SetOption", identifier, "viewCacheSize", value);
        }
        public static object GetViewPort(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.HtmlApplication.GetOption", identifier, "viewPort");
        }
        public static void SetViewPort(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.HtmlApplication.SetOption", identifier, "viewPort", value);
        }
        public static void Back(string identifier)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.HtmlApplication.back_0", identifier);
        }
        public static bool CanBack(string identifier)
        {
            return RegisteredFunction.Invoke<bool>("BlazorDevExtreme.HtmlApplication.canBack_1", identifier);
        }
        public static void ClearState(string identifier)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.HtmlApplication.clearState_2", identifier);
        }
        public static void CreateNavigation(string identifier, object navigationConfig)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.HtmlApplication.createNavigation_3", identifier, navigationConfig);
        }
        public static object GetViewTemplate(string identifier, string viewName)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.HtmlApplication.getViewTemplate_4", identifier, viewName);
        }
        public static object GetViewTemplateInfo(string identifier, string viewName)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.HtmlApplication.getViewTemplateInfo_5", identifier, viewName);
        }
        public static object LoadTemplates(string identifier, object source)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.HtmlApplication.loadTemplates_6", identifier, source);
        }
        public static void Navigate(string identifier, object uri)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.HtmlApplication.navigate_7", identifier, uri);
        }
        public static void Navigate(string identifier, object uri, object options)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.HtmlApplication.navigate_8", identifier, uri, options);
        }
        public static object Off(string identifier, string eventName)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.HtmlApplication.off_9", identifier, eventName);
        }
        public static object Off(string identifier, string eventName, object eventHandler)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.HtmlApplication.off_10", identifier, eventName, eventHandler);
        }
        public static object On(string identifier, string eventName, object eventHandler)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.HtmlApplication.on_11", identifier, eventName, eventHandler);
        }
        public static object On(string identifier, object events)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.HtmlApplication.on_12", identifier, events);
        }
        public static void RenderNavigation(string identifier)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.HtmlApplication.renderNavigation_13", identifier);
        }
        public static void RestoreState(string identifier)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.HtmlApplication.restoreState_14", identifier);
        }
        public static void SaveState(string identifier)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.HtmlApplication.saveState_15", identifier);
        }
        public static object TemplateContext(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.HtmlApplication.templateContext_16", identifier);
        }
    }
}
namespace DevExpress.Ui
{
    public class DxAccordionInterop : CollectionWidgetInterop
    {
        public static event EventHandler<JQueryEventArgs> ItemTitleClick;
        public static void Init(string identifier, DevExpress.Ui.DxAccordionOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxAccordion.Init", identifier, json);
        }
        public static void OnItemTitleClick(string identifier)
        {
            ItemTitleClick?.Invoke(null, new JQueryEventArgs(identifier));
        }
        public static float? GetAnimationDuration(string identifier)
        {
            return RegisteredFunction.Invoke<float?>("BlazorDevExtreme.DxAccordion.GetOption", identifier, "animationDuration");
        }
        public static void SetAnimationDuration(string identifier, float? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxAccordion.SetOption", identifier, "animationDuration", value);
        }
        public static bool? GetCollapsible(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxAccordion.GetOption", identifier, "collapsible");
        }
        public static void SetCollapsible(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxAccordion.SetOption", identifier, "collapsible", value);
        }
        public static bool? GetDeferRendering(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxAccordion.GetOption", identifier, "deferRendering");
        }
        public static void SetDeferRendering(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxAccordion.SetOption", identifier, "deferRendering", value);
        }
        public static new bool? GetFocusStateEnabled(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxAccordion.GetOption", identifier, "focusStateEnabled");
        }
        public static new void SetFocusStateEnabled(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxAccordion.SetOption", identifier, "focusStateEnabled", value);
        }
        public static new object GetHeight(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxAccordion.GetOption", identifier, "height");
        }
        public static new void SetHeight(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxAccordion.SetOption", identifier, "height", value);
        }
        public static new bool? GetHoverStateEnabled(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxAccordion.GetOption", identifier, "hoverStateEnabled");
        }
        public static new void SetHoverStateEnabled(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxAccordion.SetOption", identifier, "hoverStateEnabled", value);
        }
        public static new object GetItemTemplate(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxAccordion.GetOption", identifier, "itemTemplate");
        }
        public static new void SetItemTemplate(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxAccordion.SetOption", identifier, "itemTemplate", value);
        }
        public static object GetItemTitleTemplate(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxAccordion.GetOption", identifier, "itemTitleTemplate");
        }
        public static void SetItemTitleTemplate(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxAccordion.SetOption", identifier, "itemTitleTemplate", value);
        }
        public static bool? GetMultiple(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxAccordion.GetOption", identifier, "multiple");
        }
        public static void SetMultiple(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxAccordion.SetOption", identifier, "multiple", value);
        }
        public static new float? GetSelectedIndex(string identifier)
        {
            return RegisteredFunction.Invoke<float?>("BlazorDevExtreme.DxAccordion.GetOption", identifier, "selectedIndex");
        }
        public static new void SetSelectedIndex(string identifier, float? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxAccordion.SetOption", identifier, "selectedIndex", value);
        }
        public static object CollapseItem(string identifier, float index)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxAccordion.collapseItem_0", identifier, index);
        }
        public static object ExpandItem(string identifier, float index)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxAccordion.expandItem_1", identifier, index);
        }
        public static object UpdateDimensions(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxAccordion.updateDimensions_2", identifier);
        }
    }
    public class DxActionSheetInterop : CollectionWidgetInterop
    {
        public static event EventHandler<JQueryEventArgs> CancelClick;
        public static void Init(string identifier, DevExpress.Ui.DxActionSheetOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxActionSheet.Init", identifier, json);
        }
        public static void OnCancelClick(string identifier)
        {
            CancelClick?.Invoke(null, new JQueryEventArgs(identifier));
        }
        public static string GetCancelText(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxActionSheet.GetOption", identifier, "cancelText");
        }
        public static void SetCancelText(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxActionSheet.SetOption", identifier, "cancelText", value);
        }
        public static bool? GetShowCancelButton(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxActionSheet.GetOption", identifier, "showCancelButton");
        }
        public static void SetShowCancelButton(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxActionSheet.SetOption", identifier, "showCancelButton", value);
        }
        public static bool? GetShowTitle(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxActionSheet.GetOption", identifier, "showTitle");
        }
        public static void SetShowTitle(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxActionSheet.SetOption", identifier, "showTitle", value);
        }
        public static object GetTarget(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxActionSheet.GetOption", identifier, "target");
        }
        public static void SetTarget(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxActionSheet.SetOption", identifier, "target", value);
        }
        public static string GetTitle(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxActionSheet.GetOption", identifier, "title");
        }
        public static void SetTitle(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxActionSheet.SetOption", identifier, "title", value);
        }
        public static bool? GetUsePopover(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxActionSheet.GetOption", identifier, "usePopover");
        }
        public static void SetUsePopover(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxActionSheet.SetOption", identifier, "usePopover", value);
        }
        public static new bool? GetVisible(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxActionSheet.GetOption", identifier, "visible");
        }
        public static new void SetVisible(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxActionSheet.SetOption", identifier, "visible", value);
        }
        public static object Hide(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxActionSheet.hide_0", identifier);
        }
        public static object Show(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxActionSheet.show_1", identifier);
        }
        public static object Toggle(string identifier, bool showing)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxActionSheet.toggle_2", identifier, showing);
        }
    }
    public class DxAutocompleteInterop : DxDropDownListInterop
    {
        public static void Init(string identifier, DevExpress.Ui.DxAutocompleteOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxAutocomplete.Init", identifier, json);
        }
        public static float? GetMaxItemCount(string identifier)
        {
            return RegisteredFunction.Invoke<float?>("BlazorDevExtreme.DxAutocomplete.GetOption", identifier, "maxItemCount");
        }
        public static void SetMaxItemCount(string identifier, float? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxAutocomplete.SetOption", identifier, "maxItemCount", value);
        }
        public static new float? GetMinSearchLength(string identifier)
        {
            return RegisteredFunction.Invoke<float?>("BlazorDevExtreme.DxAutocomplete.GetOption", identifier, "minSearchLength");
        }
        public static new void SetMinSearchLength(string identifier, float? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxAutocomplete.SetOption", identifier, "minSearchLength", value);
        }
        public static new string GetValue(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxAutocomplete.GetOption", identifier, "value");
        }
        public static new void SetValue(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxAutocomplete.SetOption", identifier, "value", value);
        }
    }
    public class DxBoxInterop : CollectionWidgetInterop
    {
        public static void Init(string identifier, DevExpress.Ui.DxBoxOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxBox.Init", identifier, json);
        }
        public static string GetAlign(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxBox.GetOption", identifier, "align");
        }
        public static void SetAlign(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxBox.SetOption", identifier, "align", value);
        }
        public static string GetCrossAlign(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxBox.GetOption", identifier, "crossAlign");
        }
        public static void SetCrossAlign(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxBox.SetOption", identifier, "crossAlign", value);
        }
        public static string GetDirection(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxBox.GetOption", identifier, "direction");
        }
        public static void SetDirection(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxBox.SetOption", identifier, "direction", value);
        }
    }
    public class DxButtonInterop : WidgetInterop
    {
        public static event EventHandler<JQueryEventArgs> Click;
        public static void Init(string identifier, DevExpress.Ui.DxButtonOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxButton.Init", identifier, json);
        }
        public static void OnClick(string identifier)
        {
            Click?.Invoke(null, new JQueryEventArgs(identifier));
        }
        public static new bool? GetActiveStateEnabled(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxButton.GetOption", identifier, "activeStateEnabled");
        }
        public static new void SetActiveStateEnabled(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxButton.SetOption", identifier, "activeStateEnabled", value);
        }
        public static new bool? GetFocusStateEnabled(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxButton.GetOption", identifier, "focusStateEnabled");
        }
        public static new void SetFocusStateEnabled(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxButton.SetOption", identifier, "focusStateEnabled", value);
        }
        public static new bool? GetHoverStateEnabled(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxButton.GetOption", identifier, "hoverStateEnabled");
        }
        public static new void SetHoverStateEnabled(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxButton.SetOption", identifier, "hoverStateEnabled", value);
        }
        public static string GetIcon(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxButton.GetOption", identifier, "icon");
        }
        public static void SetIcon(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxButton.SetOption", identifier, "icon", value);
        }
        public static object GetTemplate(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxButton.GetOption", identifier, "template");
        }
        public static void SetTemplate(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxButton.SetOption", identifier, "template", value);
        }
        public static string GetText(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxButton.GetOption", identifier, "text");
        }
        public static void SetText(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxButton.SetOption", identifier, "text", value);
        }
        public static string GetType(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxButton.GetOption", identifier, "type");
        }
        public static void SetType(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxButton.SetOption", identifier, "type", value);
        }
        public static bool? GetUseSubmitBehavior(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxButton.GetOption", identifier, "useSubmitBehavior");
        }
        public static void SetUseSubmitBehavior(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxButton.SetOption", identifier, "useSubmitBehavior", value);
        }
        public static string GetValidationGroup(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxButton.GetOption", identifier, "validationGroup");
        }
        public static void SetValidationGroup(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxButton.SetOption", identifier, "validationGroup", value);
        }
    }
    public class DxCalendarInterop : EditorInterop
    {
        public static void Init(string identifier, DevExpress.Ui.DxCalendarOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxCalendar.Init", identifier, json);
        }
        public static new bool? GetActiveStateEnabled(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxCalendar.GetOption", identifier, "activeStateEnabled");
        }
        public static new void SetActiveStateEnabled(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxCalendar.SetOption", identifier, "activeStateEnabled", value);
        }
        public static object GetCellTemplate(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxCalendar.GetOption", identifier, "cellTemplate");
        }
        public static void SetCellTemplate(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxCalendar.SetOption", identifier, "cellTemplate", value);
        }
        public static string GetDateSerializationFormat(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxCalendar.GetOption", identifier, "dateSerializationFormat");
        }
        public static void SetDateSerializationFormat(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxCalendar.SetOption", identifier, "dateSerializationFormat", value);
        }
        public static object GetDisabledDates(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxCalendar.GetOption", identifier, "disabledDates");
        }
        public static void SetDisabledDates(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxCalendar.SetOption", identifier, "disabledDates", value);
        }
        public static object GetFirstDayOfWeek(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxCalendar.GetOption", identifier, "firstDayOfWeek");
        }
        public static void SetFirstDayOfWeek(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxCalendar.SetOption", identifier, "firstDayOfWeek", value);
        }
        public static new bool? GetFocusStateEnabled(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxCalendar.GetOption", identifier, "focusStateEnabled");
        }
        public static new void SetFocusStateEnabled(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxCalendar.SetOption", identifier, "focusStateEnabled", value);
        }
        public static new bool? GetHoverStateEnabled(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxCalendar.GetOption", identifier, "hoverStateEnabled");
        }
        public static new void SetHoverStateEnabled(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxCalendar.SetOption", identifier, "hoverStateEnabled", value);
        }
        public static object GetMax(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxCalendar.GetOption", identifier, "max");
        }
        public static void SetMax(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxCalendar.SetOption", identifier, "max", value);
        }
        public static string GetMaxZoomLevel(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxCalendar.GetOption", identifier, "maxZoomLevel");
        }
        public static void SetMaxZoomLevel(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxCalendar.SetOption", identifier, "maxZoomLevel", value);
        }
        public static object GetMin(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxCalendar.GetOption", identifier, "min");
        }
        public static void SetMin(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxCalendar.SetOption", identifier, "min", value);
        }
        public static string GetMinZoomLevel(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxCalendar.GetOption", identifier, "minZoomLevel");
        }
        public static void SetMinZoomLevel(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxCalendar.SetOption", identifier, "minZoomLevel", value);
        }
        public static string GetName(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxCalendar.GetOption", identifier, "name");
        }
        public static void SetName(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxCalendar.SetOption", identifier, "name", value);
        }
        public static bool? GetShowTodayButton(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxCalendar.GetOption", identifier, "showTodayButton");
        }
        public static void SetShowTodayButton(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxCalendar.SetOption", identifier, "showTodayButton", value);
        }
        public static new object GetValue(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxCalendar.GetOption", identifier, "value");
        }
        public static new void SetValue(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxCalendar.SetOption", identifier, "value", value);
        }
        public static string GetZoomLevel(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxCalendar.GetOption", identifier, "zoomLevel");
        }
        public static void SetZoomLevel(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxCalendar.SetOption", identifier, "zoomLevel", value);
        }
    }
    public class DxCheckBoxInterop : EditorInterop
    {
        public static void Init(string identifier, DevExpress.Ui.DxCheckBoxOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxCheckBox.Init", identifier, json);
        }
        public static new bool? GetActiveStateEnabled(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxCheckBox.GetOption", identifier, "activeStateEnabled");
        }
        public static new void SetActiveStateEnabled(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxCheckBox.SetOption", identifier, "activeStateEnabled", value);
        }
        public static new bool? GetFocusStateEnabled(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxCheckBox.GetOption", identifier, "focusStateEnabled");
        }
        public static new void SetFocusStateEnabled(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxCheckBox.SetOption", identifier, "focusStateEnabled", value);
        }
        public static new bool? GetHoverStateEnabled(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxCheckBox.GetOption", identifier, "hoverStateEnabled");
        }
        public static new void SetHoverStateEnabled(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxCheckBox.SetOption", identifier, "hoverStateEnabled", value);
        }
        public static string GetName(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxCheckBox.GetOption", identifier, "name");
        }
        public static void SetName(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxCheckBox.SetOption", identifier, "name", value);
        }
        public static string GetText(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxCheckBox.GetOption", identifier, "text");
        }
        public static void SetText(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxCheckBox.SetOption", identifier, "text", value);
        }
        public static new bool? GetValue(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxCheckBox.GetOption", identifier, "value");
        }
        public static new void SetValue(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxCheckBox.SetOption", identifier, "value", value);
        }
    }
    public class DxColorBoxInterop : DxDropDownEditorInterop
    {
        public static void Init(string identifier, DevExpress.Ui.DxColorBoxOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxColorBox.Init", identifier, json);
        }
        public static string GetApplyButtonText(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxColorBox.GetOption", identifier, "applyButtonText");
        }
        public static void SetApplyButtonText(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxColorBox.SetOption", identifier, "applyButtonText", value);
        }
        public static new string GetApplyValueMode(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxColorBox.GetOption", identifier, "applyValueMode");
        }
        public static new void SetApplyValueMode(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxColorBox.SetOption", identifier, "applyValueMode", value);
        }
        public static string GetCancelButtonText(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxColorBox.GetOption", identifier, "cancelButtonText");
        }
        public static void SetCancelButtonText(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxColorBox.SetOption", identifier, "cancelButtonText", value);
        }
        public static bool? GetEditAlphaChannel(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxColorBox.GetOption", identifier, "editAlphaChannel");
        }
        public static void SetEditAlphaChannel(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxColorBox.SetOption", identifier, "editAlphaChannel", value);
        }
        public static object GetFieldTemplate(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxColorBox.GetOption", identifier, "fieldTemplate");
        }
        public static void SetFieldTemplate(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxColorBox.SetOption", identifier, "fieldTemplate", value);
        }
        public static float? GetKeyStep(string identifier)
        {
            return RegisteredFunction.Invoke<float?>("BlazorDevExtreme.DxColorBox.GetOption", identifier, "keyStep");
        }
        public static void SetKeyStep(string identifier, float? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxColorBox.SetOption", identifier, "keyStep", value);
        }
        public static new string GetValue(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxColorBox.GetOption", identifier, "value");
        }
        public static new void SetValue(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxColorBox.SetOption", identifier, "value", value);
        }
    }
    public class DxContextMenuInterop : DxMenuBaseInterop
    {
        public static event EventHandler<JQueryEventArgs> Hidden;
        public static event EventHandler<JQueryEventArgs> Hiding;
        public static event EventHandler<JQueryEventArgs> Positioning;
        public static event EventHandler<JQueryEventArgs> Showing;
        public static event EventHandler<JQueryEventArgs> Shown;
        public static void Init(string identifier, DevExpress.Ui.DxContextMenuOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxContextMenu.Init", identifier, json);
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
        public static object GetCloseOnOutsideClick(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxContextMenu.GetOption", identifier, "closeOnOutsideClick");
        }
        public static void SetCloseOnOutsideClick(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxContextMenu.SetOption", identifier, "closeOnOutsideClick", value);
        }
        public static new object GetItems(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxContextMenu.GetOption", identifier, "items");
        }
        public static new void SetItems(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxContextMenu.SetOption", identifier, "items", value);
        }
        public static object GetPosition(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxContextMenu.GetOption", identifier, "position");
        }
        public static void SetPosition(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxContextMenu.SetOption", identifier, "position", value);
        }
        public static object GetShowEvent(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxContextMenu.GetOption", identifier, "showEvent");
        }
        public static void SetShowEvent(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxContextMenu.SetOption", identifier, "showEvent", value);
        }
        public static string GetSubmenuDirection(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxContextMenu.GetOption", identifier, "submenuDirection");
        }
        public static void SetSubmenuDirection(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxContextMenu.SetOption", identifier, "submenuDirection", value);
        }
        public static object GetTarget(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxContextMenu.GetOption", identifier, "target");
        }
        public static void SetTarget(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxContextMenu.SetOption", identifier, "target", value);
        }
        public static new bool? GetVisible(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxContextMenu.GetOption", identifier, "visible");
        }
        public static new void SetVisible(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxContextMenu.SetOption", identifier, "visible", value);
        }
        public static object Hide(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxContextMenu.hide_0", identifier);
        }
        public static object Show(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxContextMenu.show_1", identifier);
        }
        public static object Toggle(string identifier, bool showing)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxContextMenu.toggle_2", identifier, showing);
        }
    }
    public class GridBaseInterop : WidgetInterop
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
        public static void Init(string identifier, DevExpress.Ui.GridBaseOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.GridBase.Init", identifier, json);
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
        public static bool? GetAllowColumnReordering(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.GridBase.GetOption", identifier, "allowColumnReordering");
        }
        public static void SetAllowColumnReordering(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.GridBase.SetOption", identifier, "allowColumnReordering", value);
        }
        public static bool? GetAllowColumnResizing(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.GridBase.GetOption", identifier, "allowColumnResizing");
        }
        public static void SetAllowColumnResizing(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.GridBase.SetOption", identifier, "allowColumnResizing", value);
        }
        public static bool? GetCacheEnabled(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.GridBase.GetOption", identifier, "cacheEnabled");
        }
        public static void SetCacheEnabled(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.GridBase.SetOption", identifier, "cacheEnabled", value);
        }
        public static bool? GetCellHintEnabled(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.GridBase.GetOption", identifier, "cellHintEnabled");
        }
        public static void SetCellHintEnabled(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.GridBase.SetOption", identifier, "cellHintEnabled", value);
        }
        public static bool? GetColumnAutoWidth(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.GridBase.GetOption", identifier, "columnAutoWidth");
        }
        public static void SetColumnAutoWidth(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.GridBase.SetOption", identifier, "columnAutoWidth", value);
        }
        public static object GetColumnChooser(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.GridBase.GetOption", identifier, "columnChooser");
        }
        public static void SetColumnChooser(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.GridBase.SetOption", identifier, "columnChooser", value);
        }
        public static object GetColumnFixing(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.GridBase.GetOption", identifier, "columnFixing");
        }
        public static void SetColumnFixing(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.GridBase.SetOption", identifier, "columnFixing", value);
        }
        public static bool? GetColumnHidingEnabled(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.GridBase.GetOption", identifier, "columnHidingEnabled");
        }
        public static void SetColumnHidingEnabled(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.GridBase.SetOption", identifier, "columnHidingEnabled", value);
        }
        public static float? GetColumnMinWidth(string identifier)
        {
            return RegisteredFunction.Invoke<float?>("BlazorDevExtreme.GridBase.GetOption", identifier, "columnMinWidth");
        }
        public static void SetColumnMinWidth(string identifier, float? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.GridBase.SetOption", identifier, "columnMinWidth", value);
        }
        public static string GetColumnResizingMode(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.GridBase.GetOption", identifier, "columnResizingMode");
        }
        public static void SetColumnResizingMode(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.GridBase.SetOption", identifier, "columnResizingMode", value);
        }
        public static object GetColumns(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.GridBase.GetOption", identifier, "columns");
        }
        public static void SetColumns(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.GridBase.SetOption", identifier, "columns", value);
        }
        public static float? GetColumnWidth(string identifier)
        {
            return RegisteredFunction.Invoke<float?>("BlazorDevExtreme.GridBase.GetOption", identifier, "columnWidth");
        }
        public static void SetColumnWidth(string identifier, float? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.GridBase.SetOption", identifier, "columnWidth", value);
        }
        public static object GetDataSource(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.GridBase.GetOption", identifier, "dataSource");
        }
        public static void SetDataSource(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.GridBase.SetOption", identifier, "dataSource", value);
        }
        public static string GetDateSerializationFormat(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.GridBase.GetOption", identifier, "dateSerializationFormat");
        }
        public static void SetDateSerializationFormat(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.GridBase.SetOption", identifier, "dateSerializationFormat", value);
        }
        public static object GetEditing(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.GridBase.GetOption", identifier, "editing");
        }
        public static void SetEditing(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.GridBase.SetOption", identifier, "editing", value);
        }
        public static bool? GetErrorRowEnabled(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.GridBase.GetOption", identifier, "errorRowEnabled");
        }
        public static void SetErrorRowEnabled(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.GridBase.SetOption", identifier, "errorRowEnabled", value);
        }
        public static object GetFilterBuilder(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.GridBase.GetOption", identifier, "filterBuilder");
        }
        public static void SetFilterBuilder(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.GridBase.SetOption", identifier, "filterBuilder", value);
        }
        public static object GetFilterBuilderPopup(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.GridBase.GetOption", identifier, "filterBuilderPopup");
        }
        public static void SetFilterBuilderPopup(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.GridBase.SetOption", identifier, "filterBuilderPopup", value);
        }
        public static object GetFilterPanel(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.GridBase.GetOption", identifier, "filterPanel");
        }
        public static void SetFilterPanel(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.GridBase.SetOption", identifier, "filterPanel", value);
        }
        public static object GetFilterRow(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.GridBase.GetOption", identifier, "filterRow");
        }
        public static void SetFilterRow(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.GridBase.SetOption", identifier, "filterRow", value);
        }
        public static object GetFilterSyncEnabled(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.GridBase.GetOption", identifier, "filterSyncEnabled");
        }
        public static void SetFilterSyncEnabled(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.GridBase.SetOption", identifier, "filterSyncEnabled", value);
        }
        public static object GetFilterValue(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.GridBase.GetOption", identifier, "filterValue");
        }
        public static void SetFilterValue(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.GridBase.SetOption", identifier, "filterValue", value);
        }
        public static object GetHeaderFilter(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.GridBase.GetOption", identifier, "headerFilter");
        }
        public static void SetHeaderFilter(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.GridBase.SetOption", identifier, "headerFilter", value);
        }
        public static object GetLoadPanel(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.GridBase.GetOption", identifier, "loadPanel");
        }
        public static void SetLoadPanel(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.GridBase.SetOption", identifier, "loadPanel", value);
        }
        public static string GetNoDataText(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.GridBase.GetOption", identifier, "noDataText");
        }
        public static void SetNoDataText(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.GridBase.SetOption", identifier, "noDataText", value);
        }
        public static object GetPager(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.GridBase.GetOption", identifier, "pager");
        }
        public static void SetPager(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.GridBase.SetOption", identifier, "pager", value);
        }
        public static object GetPaging(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.GridBase.GetOption", identifier, "paging");
        }
        public static void SetPaging(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.GridBase.SetOption", identifier, "paging", value);
        }
        public static bool? GetRowAlternationEnabled(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.GridBase.GetOption", identifier, "rowAlternationEnabled");
        }
        public static void SetRowAlternationEnabled(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.GridBase.SetOption", identifier, "rowAlternationEnabled", value);
        }
        public static object GetScrolling(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.GridBase.GetOption", identifier, "scrolling");
        }
        public static void SetScrolling(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.GridBase.SetOption", identifier, "scrolling", value);
        }
        public static object GetSearchPanel(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.GridBase.GetOption", identifier, "searchPanel");
        }
        public static void SetSearchPanel(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.GridBase.SetOption", identifier, "searchPanel", value);
        }
        public static object GetSelectedRowKeys(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.GridBase.GetOption", identifier, "selectedRowKeys");
        }
        public static void SetSelectedRowKeys(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.GridBase.SetOption", identifier, "selectedRowKeys", value);
        }
        public static object GetSelection(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.GridBase.GetOption", identifier, "selection");
        }
        public static void SetSelection(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.GridBase.SetOption", identifier, "selection", value);
        }
        public static bool? GetShowBorders(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.GridBase.GetOption", identifier, "showBorders");
        }
        public static void SetShowBorders(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.GridBase.SetOption", identifier, "showBorders", value);
        }
        public static bool? GetShowColumnHeaders(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.GridBase.GetOption", identifier, "showColumnHeaders");
        }
        public static void SetShowColumnHeaders(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.GridBase.SetOption", identifier, "showColumnHeaders", value);
        }
        public static bool? GetShowColumnLines(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.GridBase.GetOption", identifier, "showColumnLines");
        }
        public static void SetShowColumnLines(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.GridBase.SetOption", identifier, "showColumnLines", value);
        }
        public static bool? GetShowRowLines(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.GridBase.GetOption", identifier, "showRowLines");
        }
        public static void SetShowRowLines(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.GridBase.SetOption", identifier, "showRowLines", value);
        }
        public static object GetSorting(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.GridBase.GetOption", identifier, "sorting");
        }
        public static void SetSorting(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.GridBase.SetOption", identifier, "sorting", value);
        }
        public static object GetStateStoring(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.GridBase.GetOption", identifier, "stateStoring");
        }
        public static void SetStateStoring(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.GridBase.SetOption", identifier, "stateStoring", value);
        }
        public static bool? GetTwoWayBindingEnabled(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.GridBase.GetOption", identifier, "twoWayBindingEnabled");
        }
        public static void SetTwoWayBindingEnabled(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.GridBase.SetOption", identifier, "twoWayBindingEnabled", value);
        }
        public static bool? GetWordWrapEnabled(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.GridBase.GetOption", identifier, "wordWrapEnabled");
        }
        public static void SetWordWrapEnabled(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.GridBase.SetOption", identifier, "wordWrapEnabled", value);
        }
        public static void BeginCustomLoading(string identifier, string messageText)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.GridBase.beginCustomLoading_0", identifier, messageText);
        }
        public static object ByKey(string identifier, object key)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.GridBase.byKey_1", identifier, key);
        }
        public static void CancelEditData(string identifier)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.GridBase.cancelEditData_2", identifier);
        }
        public static object CellValue(string identifier, float rowIndex, string dataField)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.GridBase.cellValue_3", identifier, rowIndex, dataField);
        }
        public static void CellValue(string identifier, float rowIndex, string dataField, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.GridBase.cellValue_4", identifier, rowIndex, dataField, value);
        }
        public static object CellValue(string identifier, float rowIndex, float visibleColumnIndex)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.GridBase.cellValue_5", identifier, rowIndex, visibleColumnIndex);
        }
        public static void CellValue(string identifier, float rowIndex, float visibleColumnIndex, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.GridBase.cellValue_6", identifier, rowIndex, visibleColumnIndex, value);
        }
        public static void ClearFilter(string identifier)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.GridBase.clearFilter_7", identifier);
        }
        public static void ClearFilter(string identifier, string filterName)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.GridBase.clearFilter_8", identifier, filterName);
        }
        public static void ClearSelection(string identifier)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.GridBase.clearSelection_9", identifier);
        }
        public static void ClearSorting(string identifier)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.GridBase.clearSorting_10", identifier);
        }
        public static void CloseEditCell(string identifier)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.GridBase.closeEditCell_11", identifier);
        }
        public static void CollapseAdaptiveDetailRow(string identifier)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.GridBase.collapseAdaptiveDetailRow_12", identifier);
        }
        public static float ColumnCount(string identifier)
        {
            return RegisteredFunction.Invoke<float>("BlazorDevExtreme.GridBase.columnCount_13", identifier);
        }
        public static object ColumnOption(string identifier, object id)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.GridBase.columnOption_14", identifier, id);
        }
        public static object ColumnOption(string identifier, object id, string optionName)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.GridBase.columnOption_15", identifier, id, optionName);
        }
        public static void ColumnOption(string identifier, object id, string optionName, object optionValue)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.GridBase.columnOption_16", identifier, id, optionName, optionValue);
        }
        public static void ColumnOption(string identifier, object id, object options)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.GridBase.columnOption_17", identifier, id, options);
        }
        public static void DeleteColumn(string identifier, object id)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.GridBase.deleteColumn_18", identifier, id);
        }
        public static void DeleteRow(string identifier, float rowIndex)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.GridBase.deleteRow_19", identifier, rowIndex);
        }
        public static object DeselectAll(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.GridBase.deselectAll_20", identifier);
        }
        public static object DeselectRows(string identifier, object keys)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.GridBase.deselectRows_21", identifier, keys);
        }
        public static void EditCell(string identifier, float rowIndex, string dataField)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.GridBase.editCell_22", identifier, rowIndex, dataField);
        }
        public static void EditCell(string identifier, float rowIndex, float visibleColumnIndex)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.GridBase.editCell_23", identifier, rowIndex, visibleColumnIndex);
        }
        public static void EditRow(string identifier, float rowIndex)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.GridBase.editRow_24", identifier, rowIndex);
        }
        public static void EndCustomLoading(string identifier)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.GridBase.endCustomLoading_25", identifier);
        }
        public static void ExpandAdaptiveDetailRow(string identifier, object key)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.GridBase.expandAdaptiveDetailRow_26", identifier, key);
        }
        public static object Filter(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.GridBase.filter_27", identifier);
        }
        public static void Filter(string identifier, object filterExpr)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.GridBase.filter_28", identifier, filterExpr);
        }
        public static void Focus(string identifier)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.GridBase.focus_29", identifier);
        }
        public static void Focus(string identifier, object element)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.GridBase.focus_30", identifier, element);
        }
        public static object GetCellElement(string identifier, float rowIndex, string dataField)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.GridBase.getCellElement_31", identifier, rowIndex, dataField);
        }
        public static object GetCellElement(string identifier, float rowIndex, float visibleColumnIndex)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.GridBase.getCellElement_32", identifier, rowIndex, visibleColumnIndex);
        }
        public static object GetCombinedFilter(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.GridBase.getCombinedFilter_33", identifier);
        }
        public static object GetCombinedFilter(string identifier, bool returnDataField)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.GridBase.getCombinedFilter_34", identifier, returnDataField);
        }
        public static object GetDataSourceEx(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.GridBase.getDataSource_35", identifier);
        }
        public static object GetKeyByRowIndex(string identifier, float rowIndex)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.GridBase.getKeyByRowIndex_36", identifier, rowIndex);
        }
        public static object GetRowElement(string identifier, float rowIndex)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.GridBase.getRowElement_37", identifier, rowIndex);
        }
        public static float GetRowIndexByKey(string identifier, object key)
        {
            return RegisteredFunction.Invoke<float>("BlazorDevExtreme.GridBase.getRowIndexByKey_38", identifier, key);
        }
        public static object GetScrollable(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.GridBase.getScrollable_39", identifier);
        }
        public static bool HasEditData(string identifier)
        {
            return RegisteredFunction.Invoke<bool>("BlazorDevExtreme.GridBase.hasEditData_40", identifier);
        }
        public static void HideColumnChooser(string identifier)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.GridBase.hideColumnChooser_41", identifier);
        }
        public static void IsAdaptiveDetailRowExpanded(string identifier, object key)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.GridBase.isAdaptiveDetailRowExpanded_42", identifier, key);
        }
        public static bool IsRowSelected(string identifier, object key)
        {
            return RegisteredFunction.Invoke<bool>("BlazorDevExtreme.GridBase.isRowSelected_43", identifier, key);
        }
        public static object KeyOf(string identifier, object obj)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.GridBase.keyOf_44", identifier, obj);
        }
        public static float PageCount(string identifier)
        {
            return RegisteredFunction.Invoke<float>("BlazorDevExtreme.GridBase.pageCount_45", identifier);
        }
        public static float PageIndex(string identifier)
        {
            return RegisteredFunction.Invoke<float>("BlazorDevExtreme.GridBase.pageIndex_46", identifier);
        }
        public static object PageIndex(string identifier, float newIndex)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.GridBase.pageIndex_47", identifier, newIndex);
        }
        public static float PageSize(string identifier)
        {
            return RegisteredFunction.Invoke<float>("BlazorDevExtreme.GridBase.pageSize_48", identifier);
        }
        public static void PageSize(string identifier, float value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.GridBase.pageSize_49", identifier, value);
        }
        public static object Refresh(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.GridBase.refresh_50", identifier);
        }
        public static void RepaintRows(string identifier, object rowIndexes)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.GridBase.repaintRows_51", identifier, rowIndexes);
        }
        public static object SaveEditData(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.GridBase.saveEditData_52", identifier);
        }
        public static void SearchByText(string identifier, string text)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.GridBase.searchByText_53", identifier, text);
        }
        public static object SelectAll(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.GridBase.selectAll_54", identifier);
        }
        public static object SelectRows(string identifier, object keys, bool preserve)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.GridBase.selectRows_55", identifier, keys, preserve);
        }
        public static object SelectRowsByIndexes(string identifier, object indexes)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.GridBase.selectRowsByIndexes_56", identifier, indexes);
        }
        public static void ShowColumnChooser(string identifier)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.GridBase.showColumnChooser_57", identifier);
        }
        public static object State(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.GridBase.state_58", identifier);
        }
        public static void State(string identifier, object state)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.GridBase.state_59", identifier, state);
        }
        public static void UndeleteRow(string identifier, float rowIndex)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.GridBase.undeleteRow_60", identifier, rowIndex);
        }
        public static void UpdateDimensions(string identifier)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.GridBase.updateDimensions_61", identifier);
        }
    }
    public class DxDataGridInterop : GridBaseInterop
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
        public static void Init(string identifier, DevExpress.Ui.DxDataGridOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDataGrid.Init", identifier, json);
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
        public static new object GetColumns(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDataGrid.GetOption", identifier, "columns");
        }
        public static new void SetColumns(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDataGrid.SetOption", identifier, "columns", value);
        }
        public static object GetCustomizeColumns(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDataGrid.GetOption", identifier, "customizeColumns");
        }
        public static void SetCustomizeColumns(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDataGrid.SetOption", identifier, "customizeColumns", value);
        }
        public static object GetCustomizeExportData(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDataGrid.GetOption", identifier, "customizeExportData");
        }
        public static void SetCustomizeExportData(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDataGrid.SetOption", identifier, "customizeExportData", value);
        }
        public static new object GetEditing(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDataGrid.GetOption", identifier, "editing");
        }
        public static new void SetEditing(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDataGrid.SetOption", identifier, "editing", value);
        }
        public static object GetExport(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDataGrid.GetOption", identifier, "export");
        }
        public static void SetExport(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDataGrid.SetOption", identifier, "export", value);
        }
        public static object GetGrouping(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDataGrid.GetOption", identifier, "grouping");
        }
        public static void SetGrouping(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDataGrid.SetOption", identifier, "grouping", value);
        }
        public static object GetGroupPanel(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDataGrid.GetOption", identifier, "groupPanel");
        }
        public static void SetGroupPanel(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDataGrid.SetOption", identifier, "groupPanel", value);
        }
        public static object GetKeyExpr(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDataGrid.GetOption", identifier, "keyExpr");
        }
        public static void SetKeyExpr(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDataGrid.SetOption", identifier, "keyExpr", value);
        }
        public static object GetMasterDetail(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDataGrid.GetOption", identifier, "masterDetail");
        }
        public static void SetMasterDetail(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDataGrid.SetOption", identifier, "masterDetail", value);
        }
        public static object GetRemoteOperations(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDataGrid.GetOption", identifier, "remoteOperations");
        }
        public static void SetRemoteOperations(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDataGrid.SetOption", identifier, "remoteOperations", value);
        }
        public static object GetRowTemplate(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDataGrid.GetOption", identifier, "rowTemplate");
        }
        public static void SetRowTemplate(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDataGrid.SetOption", identifier, "rowTemplate", value);
        }
        public static new object GetScrolling(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDataGrid.GetOption", identifier, "scrolling");
        }
        public static new void SetScrolling(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDataGrid.SetOption", identifier, "scrolling", value);
        }
        public static new object GetSelection(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDataGrid.GetOption", identifier, "selection");
        }
        public static new void SetSelection(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDataGrid.SetOption", identifier, "selection", value);
        }
        public static object GetSelectionFilter(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDataGrid.GetOption", identifier, "selectionFilter");
        }
        public static void SetSelectionFilter(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDataGrid.SetOption", identifier, "selectionFilter", value);
        }
        public static object GetSortByGroupSummaryInfo(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDataGrid.GetOption", identifier, "sortByGroupSummaryInfo");
        }
        public static void SetSortByGroupSummaryInfo(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDataGrid.SetOption", identifier, "sortByGroupSummaryInfo", value);
        }
        public static object GetSummary(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDataGrid.GetOption", identifier, "summary");
        }
        public static void SetSummary(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDataGrid.SetOption", identifier, "summary", value);
        }
        public static void AddColumn(string identifier, object columnOptions)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDataGrid.addColumn_0", identifier, columnOptions);
        }
        public static void AddRow(string identifier)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDataGrid.addRow_1", identifier);
        }
        public static void ClearGrouping(string identifier)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDataGrid.clearGrouping_2", identifier);
        }
        public static void CollapseAll(string identifier, float groupIndex)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDataGrid.collapseAll_3", identifier, groupIndex);
        }
        public static object CollapseRow(string identifier, object key)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDataGrid.collapseRow_4", identifier, key);
        }
        public static void ExpandAll(string identifier, float groupIndex)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDataGrid.expandAll_5", identifier, groupIndex);
        }
        public static object ExpandRow(string identifier, object key)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDataGrid.expandRow_6", identifier, key);
        }
        public static void ExportToExcel(string identifier, bool selectionOnly)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDataGrid.exportToExcel_7", identifier, selectionOnly);
        }
        public static object GetSelectedRowKeys(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDataGrid.getSelectedRowKeys_8", identifier);
        }
        public static object GetSelectedRowsData(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDataGrid.getSelectedRowsData_9", identifier);
        }
        public static object GetTotalSummaryValue(string identifier, string summaryItemName)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDataGrid.getTotalSummaryValue_10", identifier, summaryItemName);
        }
        public static object GetVisibleColumns(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDataGrid.getVisibleColumns_11", identifier);
        }
        public static object GetVisibleColumns(string identifier, float headerLevel)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDataGrid.getVisibleColumns_12", identifier, headerLevel);
        }
        public static object GetVisibleRows(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDataGrid.getVisibleRows_13", identifier);
        }
        public static void InsertRow(string identifier)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDataGrid.insertRow_14", identifier);
        }
        public static bool IsRowExpanded(string identifier, object key)
        {
            return RegisteredFunction.Invoke<bool>("BlazorDevExtreme.DxDataGrid.isRowExpanded_15", identifier, key);
        }
        public static bool IsRowSelected(string identifier, object data)
        {
            return RegisteredFunction.Invoke<bool>("BlazorDevExtreme.DxDataGrid.isRowSelected_16", identifier, data);
        }
        public static void RemoveRow(string identifier, float rowIndex)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDataGrid.removeRow_18", identifier, rowIndex);
        }
        public static float TotalCount(string identifier)
        {
            return RegisteredFunction.Invoke<float>("BlazorDevExtreme.DxDataGrid.totalCount_19", identifier);
        }
    }
    public class DxDateBoxInterop : DxDropDownEditorInterop
    {
        public static void Init(string identifier, DevExpress.Ui.DxDateBoxOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDateBox.Init", identifier, json);
        }
        public static bool? GetAdaptivityEnabled(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxDateBox.GetOption", identifier, "adaptivityEnabled");
        }
        public static void SetAdaptivityEnabled(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDateBox.SetOption", identifier, "adaptivityEnabled", value);
        }
        public static string GetApplyButtonText(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxDateBox.GetOption", identifier, "applyButtonText");
        }
        public static void SetApplyButtonText(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDateBox.SetOption", identifier, "applyButtonText", value);
        }
        public static object GetCalendarOptions(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDateBox.GetOption", identifier, "calendarOptions");
        }
        public static void SetCalendarOptions(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDateBox.SetOption", identifier, "calendarOptions", value);
        }
        public static string GetCancelButtonText(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxDateBox.GetOption", identifier, "cancelButtonText");
        }
        public static void SetCancelButtonText(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDateBox.SetOption", identifier, "cancelButtonText", value);
        }
        public static string GetDateOutOfRangeMessage(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxDateBox.GetOption", identifier, "dateOutOfRangeMessage");
        }
        public static void SetDateOutOfRangeMessage(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDateBox.SetOption", identifier, "dateOutOfRangeMessage", value);
        }
        public static string GetDateSerializationFormat(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxDateBox.GetOption", identifier, "dateSerializationFormat");
        }
        public static void SetDateSerializationFormat(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDateBox.SetOption", identifier, "dateSerializationFormat", value);
        }
        public static object GetDisabledDates(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDateBox.GetOption", identifier, "disabledDates");
        }
        public static void SetDisabledDates(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDateBox.SetOption", identifier, "disabledDates", value);
        }
        public static object GetDisplayFormat(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDateBox.GetOption", identifier, "displayFormat");
        }
        public static void SetDisplayFormat(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDateBox.SetOption", identifier, "displayFormat", value);
        }
        public static float? GetInterval(string identifier)
        {
            return RegisteredFunction.Invoke<float?>("BlazorDevExtreme.DxDateBox.GetOption", identifier, "interval");
        }
        public static void SetInterval(string identifier, float? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDateBox.SetOption", identifier, "interval", value);
        }
        public static string GetInvalidDateMessage(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxDateBox.GetOption", identifier, "invalidDateMessage");
        }
        public static void SetInvalidDateMessage(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDateBox.SetOption", identifier, "invalidDateMessage", value);
        }
        public static object GetMax(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDateBox.GetOption", identifier, "max");
        }
        public static void SetMax(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDateBox.SetOption", identifier, "max", value);
        }
        public static string GetMaxZoomLevel(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxDateBox.GetOption", identifier, "maxZoomLevel");
        }
        public static void SetMaxZoomLevel(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDateBox.SetOption", identifier, "maxZoomLevel", value);
        }
        public static object GetMin(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDateBox.GetOption", identifier, "min");
        }
        public static void SetMin(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDateBox.SetOption", identifier, "min", value);
        }
        public static string GetMinZoomLevel(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxDateBox.GetOption", identifier, "minZoomLevel");
        }
        public static void SetMinZoomLevel(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDateBox.SetOption", identifier, "minZoomLevel", value);
        }
        public static string GetPickerType(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxDateBox.GetOption", identifier, "pickerType");
        }
        public static void SetPickerType(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDateBox.SetOption", identifier, "pickerType", value);
        }
        public static new string GetPlaceholder(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxDateBox.GetOption", identifier, "placeholder");
        }
        public static new void SetPlaceholder(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDateBox.SetOption", identifier, "placeholder", value);
        }
        public static bool? GetShowAnalogClock(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxDateBox.GetOption", identifier, "showAnalogClock");
        }
        public static void SetShowAnalogClock(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDateBox.SetOption", identifier, "showAnalogClock", value);
        }
        public static string GetType(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxDateBox.GetOption", identifier, "type");
        }
        public static void SetType(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDateBox.SetOption", identifier, "type", value);
        }
        public static new object GetValue(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDateBox.GetOption", identifier, "value");
        }
        public static new void SetValue(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDateBox.SetOption", identifier, "value", value);
        }
        public static void Close(string identifier)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDateBox.close_0", identifier);
        }
        public static void Open(string identifier)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDateBox.open_1", identifier);
        }
    }
    public class DxDeferRenderingInterop : WidgetInterop
    {
        public static event EventHandler<JQueryEventArgs> Rendered;
        public static event EventHandler<JQueryEventArgs> Shown;
        public static void Init(string identifier, DevExpress.Ui.DxDeferRenderingOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDeferRendering.Init", identifier, json);
        }
        public static void OnRendered(string identifier)
        {
            Rendered?.Invoke(null, new JQueryEventArgs(identifier));
        }
        public static void OnShown(string identifier)
        {
            Shown?.Invoke(null, new JQueryEventArgs(identifier));
        }
        public static object GetAnimation(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDeferRendering.GetOption", identifier, "animation");
        }
        public static void SetAnimation(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDeferRendering.SetOption", identifier, "animation", value);
        }
        public static object GetRenderWhen(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDeferRendering.GetOption", identifier, "renderWhen");
        }
        public static void SetRenderWhen(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDeferRendering.SetOption", identifier, "renderWhen", value);
        }
        public static bool? GetShowLoadIndicator(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxDeferRendering.GetOption", identifier, "showLoadIndicator");
        }
        public static void SetShowLoadIndicator(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDeferRendering.SetOption", identifier, "showLoadIndicator", value);
        }
        public static string GetStaggerItemSelector(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxDeferRendering.GetOption", identifier, "staggerItemSelector");
        }
        public static void SetStaggerItemSelector(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDeferRendering.SetOption", identifier, "staggerItemSelector", value);
        }
    }
    public class DxDropDownBoxInterop : DxDropDownEditorInterop
    {
        public static void Init(string identifier, DevExpress.Ui.DxDropDownBoxOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDropDownBox.Init", identifier, json);
        }
        public static new bool? GetAcceptCustomValue(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxDropDownBox.GetOption", identifier, "acceptCustomValue");
        }
        public static new void SetAcceptCustomValue(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDropDownBox.SetOption", identifier, "acceptCustomValue", value);
        }
        public static object GetContentTemplate(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDropDownBox.GetOption", identifier, "contentTemplate");
        }
        public static void SetContentTemplate(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDropDownBox.SetOption", identifier, "contentTemplate", value);
        }
        public static object GetDropDownOptions(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDropDownBox.GetOption", identifier, "dropDownOptions");
        }
        public static void SetDropDownOptions(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDropDownBox.SetOption", identifier, "dropDownOptions", value);
        }
        public static object GetFieldTemplate(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDropDownBox.GetOption", identifier, "fieldTemplate");
        }
        public static void SetFieldTemplate(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDropDownBox.SetOption", identifier, "fieldTemplate", value);
        }
        public static new string GetValueChangeEvent(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxDropDownBox.GetOption", identifier, "valueChangeEvent");
        }
        public static new void SetValueChangeEvent(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDropDownBox.SetOption", identifier, "valueChangeEvent", value);
        }
        public static object GetDataSourceEx(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDropDownBox.getDataSource_0", identifier);
        }
    }
    public class DxDropDownMenuInterop : WidgetInterop
    {
        public static event EventHandler<JQueryEventArgs> ButtonClick;
        public static event EventHandler<JQueryEventArgs> ItemClick;
        public static void Init(string identifier, DevExpress.Ui.DxDropDownMenuOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDropDownMenu.Init", identifier, json);
        }
        public static void OnButtonClick(string identifier)
        {
            ButtonClick?.Invoke(null, new JQueryEventArgs(identifier));
        }
        public static void OnItemClick(string identifier)
        {
            ItemClick?.Invoke(null, new JQueryEventArgs(identifier));
        }
        public static new bool? GetActiveStateEnabled(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxDropDownMenu.GetOption", identifier, "activeStateEnabled");
        }
        public static new void SetActiveStateEnabled(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDropDownMenu.SetOption", identifier, "activeStateEnabled", value);
        }
        public static string GetButtonIcon(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxDropDownMenu.GetOption", identifier, "buttonIcon");
        }
        public static void SetButtonIcon(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDropDownMenu.SetOption", identifier, "buttonIcon", value);
        }
        public static string GetButtonText(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxDropDownMenu.GetOption", identifier, "buttonText");
        }
        public static void SetButtonText(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDropDownMenu.SetOption", identifier, "buttonText", value);
        }
        public static object GetDataSource(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDropDownMenu.GetOption", identifier, "dataSource");
        }
        public static void SetDataSource(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDropDownMenu.SetOption", identifier, "dataSource", value);
        }
        public static new bool? GetHoverStateEnabled(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxDropDownMenu.GetOption", identifier, "hoverStateEnabled");
        }
        public static new void SetHoverStateEnabled(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDropDownMenu.SetOption", identifier, "hoverStateEnabled", value);
        }
        public static object GetItems(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDropDownMenu.GetOption", identifier, "items");
        }
        public static void SetItems(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDropDownMenu.SetOption", identifier, "items", value);
        }
        public static object GetItemTemplate(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDropDownMenu.GetOption", identifier, "itemTemplate");
        }
        public static void SetItemTemplate(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDropDownMenu.SetOption", identifier, "itemTemplate", value);
        }
        public static bool? GetOpened(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxDropDownMenu.GetOption", identifier, "opened");
        }
        public static void SetOpened(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDropDownMenu.SetOption", identifier, "opened", value);
        }
        public static object GetPopupHeight(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDropDownMenu.GetOption", identifier, "popupHeight");
        }
        public static void SetPopupHeight(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDropDownMenu.SetOption", identifier, "popupHeight", value);
        }
        public static object GetPopupWidth(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDropDownMenu.GetOption", identifier, "popupWidth");
        }
        public static void SetPopupWidth(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDropDownMenu.SetOption", identifier, "popupWidth", value);
        }
        public static bool? GetUsePopover(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxDropDownMenu.GetOption", identifier, "usePopover");
        }
        public static void SetUsePopover(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDropDownMenu.SetOption", identifier, "usePopover", value);
        }
        public static void Close(string identifier)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDropDownMenu.close_0", identifier);
        }
        public static void Open(string identifier)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDropDownMenu.open_1", identifier);
        }
    }
    public class DxFileUploaderInterop : EditorInterop
    {
        public static event EventHandler<JQueryEventArgs> Progress;
        public static event EventHandler<JQueryEventArgs> UploadAborted;
        public static event EventHandler<JQueryEventArgs> Uploaded;
        public static event EventHandler<JQueryEventArgs> UploadError;
        public static event EventHandler<JQueryEventArgs> UploadStarted;
        public static event EventHandler<JQueryEventArgs> ValueChanged;
        public static void Init(string identifier, DevExpress.Ui.DxFileUploaderOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxFileUploader.Init", identifier, json);
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
        public static string GetAccept(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxFileUploader.GetOption", identifier, "accept");
        }
        public static void SetAccept(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxFileUploader.SetOption", identifier, "accept", value);
        }
        public static bool? GetAllowCanceling(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxFileUploader.GetOption", identifier, "allowCanceling");
        }
        public static void SetAllowCanceling(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxFileUploader.SetOption", identifier, "allowCanceling", value);
        }
        public static new bool? GetFocusStateEnabled(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxFileUploader.GetOption", identifier, "focusStateEnabled");
        }
        public static new void SetFocusStateEnabled(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxFileUploader.SetOption", identifier, "focusStateEnabled", value);
        }
        public static string GetLabelText(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxFileUploader.GetOption", identifier, "labelText");
        }
        public static void SetLabelText(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxFileUploader.SetOption", identifier, "labelText", value);
        }
        public static bool? GetMultiple(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxFileUploader.GetOption", identifier, "multiple");
        }
        public static void SetMultiple(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxFileUploader.SetOption", identifier, "multiple", value);
        }
        public static string GetName(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxFileUploader.GetOption", identifier, "name");
        }
        public static void SetName(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxFileUploader.SetOption", identifier, "name", value);
        }
        public static float? GetProgress(string identifier)
        {
            return RegisteredFunction.Invoke<float?>("BlazorDevExtreme.DxFileUploader.GetOption", identifier, "progress");
        }
        public static void SetProgress(string identifier, float? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxFileUploader.SetOption", identifier, "progress", value);
        }
        public static string GetReadyToUploadMessage(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxFileUploader.GetOption", identifier, "readyToUploadMessage");
        }
        public static void SetReadyToUploadMessage(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxFileUploader.SetOption", identifier, "readyToUploadMessage", value);
        }
        public static string GetSelectButtonText(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxFileUploader.GetOption", identifier, "selectButtonText");
        }
        public static void SetSelectButtonText(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxFileUploader.SetOption", identifier, "selectButtonText", value);
        }
        public static bool? GetShowFileList(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxFileUploader.GetOption", identifier, "showFileList");
        }
        public static void SetShowFileList(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxFileUploader.SetOption", identifier, "showFileList", value);
        }
        public static string GetUploadButtonText(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxFileUploader.GetOption", identifier, "uploadButtonText");
        }
        public static void SetUploadButtonText(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxFileUploader.SetOption", identifier, "uploadButtonText", value);
        }
        public static string GetUploadedMessage(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxFileUploader.GetOption", identifier, "uploadedMessage");
        }
        public static void SetUploadedMessage(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxFileUploader.SetOption", identifier, "uploadedMessage", value);
        }
        public static string GetUploadFailedMessage(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxFileUploader.GetOption", identifier, "uploadFailedMessage");
        }
        public static void SetUploadFailedMessage(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxFileUploader.SetOption", identifier, "uploadFailedMessage", value);
        }
        public static object GetUploadHeaders(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxFileUploader.GetOption", identifier, "uploadHeaders");
        }
        public static void SetUploadHeaders(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxFileUploader.SetOption", identifier, "uploadHeaders", value);
        }
        public static string GetUploadMethod(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxFileUploader.GetOption", identifier, "uploadMethod");
        }
        public static void SetUploadMethod(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxFileUploader.SetOption", identifier, "uploadMethod", value);
        }
        public static string GetUploadMode(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxFileUploader.GetOption", identifier, "uploadMode");
        }
        public static void SetUploadMode(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxFileUploader.SetOption", identifier, "uploadMode", value);
        }
        public static string GetUploadUrl(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxFileUploader.GetOption", identifier, "uploadUrl");
        }
        public static void SetUploadUrl(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxFileUploader.SetOption", identifier, "uploadUrl", value);
        }
        public static new object GetValue(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxFileUploader.GetOption", identifier, "value");
        }
        public static new void SetValue(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxFileUploader.SetOption", identifier, "value", value);
        }
    }
    public class DxFilterBuilderInterop : WidgetInterop
    {
        public static event EventHandler<JQueryEventArgs> EditorPrepared;
        public static event EventHandler<JQueryEventArgs> EditorPreparing;
        public static event EventHandler<JQueryEventArgs> ValueChanged;
        public static void Init(string identifier, DevExpress.Ui.DxFilterBuilderOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxFilterBuilder.Init", identifier, json);
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
        public static bool? GetAllowHierarchicalFields(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxFilterBuilder.GetOption", identifier, "allowHierarchicalFields");
        }
        public static void SetAllowHierarchicalFields(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxFilterBuilder.SetOption", identifier, "allowHierarchicalFields", value);
        }
        public static object GetCustomOperations(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxFilterBuilder.GetOption", identifier, "customOperations");
        }
        public static void SetCustomOperations(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxFilterBuilder.SetOption", identifier, "customOperations", value);
        }
        public static object GetFields(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxFilterBuilder.GetOption", identifier, "fields");
        }
        public static void SetFields(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxFilterBuilder.SetOption", identifier, "fields", value);
        }
        public static object GetFilterOperationDescriptions(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxFilterBuilder.GetOption", identifier, "filterOperationDescriptions");
        }
        public static void SetFilterOperationDescriptions(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxFilterBuilder.SetOption", identifier, "filterOperationDescriptions", value);
        }
        public static object GetGroupOperationDescriptions(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxFilterBuilder.GetOption", identifier, "groupOperationDescriptions");
        }
        public static void SetGroupOperationDescriptions(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxFilterBuilder.SetOption", identifier, "groupOperationDescriptions", value);
        }
        public static object GetValue(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxFilterBuilder.GetOption", identifier, "value");
        }
        public static void SetValue(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxFilterBuilder.SetOption", identifier, "value", value);
        }
        public static object GetFilterExpression(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxFilterBuilder.getFilterExpression_0", identifier);
        }
    }
    public class DxFormInterop : WidgetInterop
    {
        public static event EventHandler<JQueryEventArgs> EditorEnterKey;
        public static event EventHandler<JQueryEventArgs> FieldDataChanged;
        public static void Init(string identifier, DevExpress.Ui.DxFormOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxForm.Init", identifier, json);
        }
        public static void OnEditorEnterKey(string identifier)
        {
            EditorEnterKey?.Invoke(null, new JQueryEventArgs(identifier));
        }
        public static void OnFieldDataChanged(string identifier)
        {
            FieldDataChanged?.Invoke(null, new JQueryEventArgs(identifier));
        }
        public static bool? GetAlignItemLabels(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxForm.GetOption", identifier, "alignItemLabels");
        }
        public static void SetAlignItemLabels(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxForm.SetOption", identifier, "alignItemLabels", value);
        }
        public static bool? GetAlignItemLabelsInAllGroups(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxForm.GetOption", identifier, "alignItemLabelsInAllGroups");
        }
        public static void SetAlignItemLabelsInAllGroups(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxForm.SetOption", identifier, "alignItemLabelsInAllGroups", value);
        }
        public static object GetColCount(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxForm.GetOption", identifier, "colCount");
        }
        public static void SetColCount(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxForm.SetOption", identifier, "colCount", value);
        }
        public static object GetColCountByScreen(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxForm.GetOption", identifier, "colCountByScreen");
        }
        public static void SetColCountByScreen(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxForm.SetOption", identifier, "colCountByScreen", value);
        }
        public static object GetCustomizeItem(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxForm.GetOption", identifier, "customizeItem");
        }
        public static void SetCustomizeItem(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxForm.SetOption", identifier, "customizeItem", value);
        }
        public static object GetFormData(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxForm.GetOption", identifier, "formData");
        }
        public static void SetFormData(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxForm.SetOption", identifier, "formData", value);
        }
        public static object GetItems(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxForm.GetOption", identifier, "items");
        }
        public static void SetItems(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxForm.SetOption", identifier, "items", value);
        }
        public static string GetLabelLocation(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxForm.GetOption", identifier, "labelLocation");
        }
        public static void SetLabelLocation(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxForm.SetOption", identifier, "labelLocation", value);
        }
        public static float? GetMinColWidth(string identifier)
        {
            return RegisteredFunction.Invoke<float?>("BlazorDevExtreme.DxForm.GetOption", identifier, "minColWidth");
        }
        public static void SetMinColWidth(string identifier, float? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxForm.SetOption", identifier, "minColWidth", value);
        }
        public static string GetOptionalMark(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxForm.GetOption", identifier, "optionalMark");
        }
        public static void SetOptionalMark(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxForm.SetOption", identifier, "optionalMark", value);
        }
        public static bool? GetReadOnly(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxForm.GetOption", identifier, "readOnly");
        }
        public static void SetReadOnly(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxForm.SetOption", identifier, "readOnly", value);
        }
        public static string GetRequiredMark(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxForm.GetOption", identifier, "requiredMark");
        }
        public static void SetRequiredMark(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxForm.SetOption", identifier, "requiredMark", value);
        }
        public static string GetRequiredMessage(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxForm.GetOption", identifier, "requiredMessage");
        }
        public static void SetRequiredMessage(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxForm.SetOption", identifier, "requiredMessage", value);
        }
        public static object GetScreenByWidth(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxForm.GetOption", identifier, "screenByWidth");
        }
        public static void SetScreenByWidth(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxForm.SetOption", identifier, "screenByWidth", value);
        }
        public static bool? GetScrollingEnabled(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxForm.GetOption", identifier, "scrollingEnabled");
        }
        public static void SetScrollingEnabled(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxForm.SetOption", identifier, "scrollingEnabled", value);
        }
        public static bool? GetShowColonAfterLabel(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxForm.GetOption", identifier, "showColonAfterLabel");
        }
        public static void SetShowColonAfterLabel(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxForm.SetOption", identifier, "showColonAfterLabel", value);
        }
        public static bool? GetShowOptionalMark(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxForm.GetOption", identifier, "showOptionalMark");
        }
        public static void SetShowOptionalMark(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxForm.SetOption", identifier, "showOptionalMark", value);
        }
        public static bool? GetShowRequiredMark(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxForm.GetOption", identifier, "showRequiredMark");
        }
        public static void SetShowRequiredMark(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxForm.SetOption", identifier, "showRequiredMark", value);
        }
        public static bool? GetShowValidationSummary(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxForm.GetOption", identifier, "showValidationSummary");
        }
        public static void SetShowValidationSummary(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxForm.SetOption", identifier, "showValidationSummary", value);
        }
        public static string GetValidationGroup(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxForm.GetOption", identifier, "validationGroup");
        }
        public static void SetValidationGroup(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxForm.SetOption", identifier, "validationGroup", value);
        }
        public static object GetEditor(string identifier, string dataField)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxForm.getEditor_0", identifier, dataField);
        }
        public static object ItemOption(string identifier, string id)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxForm.itemOption_1", identifier, id);
        }
        public static void ItemOption(string identifier, string id, string option, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxForm.itemOption_2", identifier, id, option, value);
        }
        public static void ItemOption(string identifier, string id, object options)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxForm.itemOption_3", identifier, id, options);
        }
        public static void ResetValues(string identifier)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxForm.resetValues_4", identifier);
        }
        public static void UpdateData(string identifier, object data)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxForm.updateData_5", identifier, data);
        }
        public static void UpdateData(string identifier, string dataField, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxForm.updateData_6", identifier, dataField, value);
        }
        public static object UpdateDimensions(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxForm.updateDimensions_7", identifier);
        }
        public static object Validate(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxForm.validate_8", identifier);
        }
    }
    public class DxGalleryInterop : CollectionWidgetInterop
    {
        public static void Init(string identifier, DevExpress.Ui.DxGalleryOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxGallery.Init", identifier, json);
        }
        public static float? GetAnimationDuration(string identifier)
        {
            return RegisteredFunction.Invoke<float?>("BlazorDevExtreme.DxGallery.GetOption", identifier, "animationDuration");
        }
        public static void SetAnimationDuration(string identifier, float? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxGallery.SetOption", identifier, "animationDuration", value);
        }
        public static bool? GetAnimationEnabled(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxGallery.GetOption", identifier, "animationEnabled");
        }
        public static void SetAnimationEnabled(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxGallery.SetOption", identifier, "animationEnabled", value);
        }
        public static new bool? GetFocusStateEnabled(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxGallery.GetOption", identifier, "focusStateEnabled");
        }
        public static new void SetFocusStateEnabled(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxGallery.SetOption", identifier, "focusStateEnabled", value);
        }
        public static bool? GetIndicatorEnabled(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxGallery.GetOption", identifier, "indicatorEnabled");
        }
        public static void SetIndicatorEnabled(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxGallery.SetOption", identifier, "indicatorEnabled", value);
        }
        public static float? GetInitialItemWidth(string identifier)
        {
            return RegisteredFunction.Invoke<float?>("BlazorDevExtreme.DxGallery.GetOption", identifier, "initialItemWidth");
        }
        public static void SetInitialItemWidth(string identifier, float? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxGallery.SetOption", identifier, "initialItemWidth", value);
        }
        public static bool? GetLoop(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxGallery.GetOption", identifier, "loop");
        }
        public static void SetLoop(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxGallery.SetOption", identifier, "loop", value);
        }
        public static new float? GetSelectedIndex(string identifier)
        {
            return RegisteredFunction.Invoke<float?>("BlazorDevExtreme.DxGallery.GetOption", identifier, "selectedIndex");
        }
        public static new void SetSelectedIndex(string identifier, float? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxGallery.SetOption", identifier, "selectedIndex", value);
        }
        public static bool? GetShowIndicator(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxGallery.GetOption", identifier, "showIndicator");
        }
        public static void SetShowIndicator(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxGallery.SetOption", identifier, "showIndicator", value);
        }
        public static bool? GetShowNavButtons(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxGallery.GetOption", identifier, "showNavButtons");
        }
        public static void SetShowNavButtons(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxGallery.SetOption", identifier, "showNavButtons", value);
        }
        public static float? GetSlideshowDelay(string identifier)
        {
            return RegisteredFunction.Invoke<float?>("BlazorDevExtreme.DxGallery.GetOption", identifier, "slideshowDelay");
        }
        public static void SetSlideshowDelay(string identifier, float? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxGallery.SetOption", identifier, "slideshowDelay", value);
        }
        public static bool? GetStretchImages(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxGallery.GetOption", identifier, "stretchImages");
        }
        public static void SetStretchImages(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxGallery.SetOption", identifier, "stretchImages", value);
        }
        public static bool? GetSwipeEnabled(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxGallery.GetOption", identifier, "swipeEnabled");
        }
        public static void SetSwipeEnabled(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxGallery.SetOption", identifier, "swipeEnabled", value);
        }
        public static bool? GetWrapAround(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxGallery.GetOption", identifier, "wrapAround");
        }
        public static void SetWrapAround(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxGallery.SetOption", identifier, "wrapAround", value);
        }
        public static object GoToItem(string identifier, float itemIndex, bool animation)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxGallery.goToItem_0", identifier, itemIndex, animation);
        }
        public static object NextItem(string identifier, bool animation)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxGallery.nextItem_1", identifier, animation);
        }
        public static object PrevItem(string identifier, bool animation)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxGallery.prevItem_2", identifier, animation);
        }
    }
    public class DxListInterop : CollectionWidgetInterop
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
        public static void Init(string identifier, DevExpress.Ui.DxListOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxList.Init", identifier, json);
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
        public static new bool? GetActiveStateEnabled(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxList.GetOption", identifier, "activeStateEnabled");
        }
        public static new void SetActiveStateEnabled(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxList.SetOption", identifier, "activeStateEnabled", value);
        }
        public static bool? GetAllowItemDeleting(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxList.GetOption", identifier, "allowItemDeleting");
        }
        public static void SetAllowItemDeleting(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxList.SetOption", identifier, "allowItemDeleting", value);
        }
        public static bool? GetAllowItemReordering(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxList.GetOption", identifier, "allowItemReordering");
        }
        public static void SetAllowItemReordering(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxList.SetOption", identifier, "allowItemReordering", value);
        }
        public static bool? GetBounceEnabled(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxList.GetOption", identifier, "bounceEnabled");
        }
        public static void SetBounceEnabled(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxList.SetOption", identifier, "bounceEnabled", value);
        }
        public static bool? GetCollapsibleGroups(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxList.GetOption", identifier, "collapsibleGroups");
        }
        public static void SetCollapsibleGroups(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxList.SetOption", identifier, "collapsibleGroups", value);
        }
        public static new bool? GetFocusStateEnabled(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxList.GetOption", identifier, "focusStateEnabled");
        }
        public static new void SetFocusStateEnabled(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxList.SetOption", identifier, "focusStateEnabled", value);
        }
        public static bool? GetGrouped(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxList.GetOption", identifier, "grouped");
        }
        public static void SetGrouped(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxList.SetOption", identifier, "grouped", value);
        }
        public static object GetGroupTemplate(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxList.GetOption", identifier, "groupTemplate");
        }
        public static void SetGroupTemplate(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxList.SetOption", identifier, "groupTemplate", value);
        }
        public static new bool? GetHoverStateEnabled(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxList.GetOption", identifier, "hoverStateEnabled");
        }
        public static new void SetHoverStateEnabled(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxList.SetOption", identifier, "hoverStateEnabled", value);
        }
        public static bool? GetIndicateLoading(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxList.GetOption", identifier, "indicateLoading");
        }
        public static void SetIndicateLoading(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxList.SetOption", identifier, "indicateLoading", value);
        }
        public static string GetItemDeleteMode(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxList.GetOption", identifier, "itemDeleteMode");
        }
        public static void SetItemDeleteMode(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxList.SetOption", identifier, "itemDeleteMode", value);
        }
        public static object GetMenuItems(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxList.GetOption", identifier, "menuItems");
        }
        public static void SetMenuItems(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxList.SetOption", identifier, "menuItems", value);
        }
        public static string GetMenuMode(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxList.GetOption", identifier, "menuMode");
        }
        public static void SetMenuMode(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxList.SetOption", identifier, "menuMode", value);
        }
        public static string GetNextButtonText(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxList.GetOption", identifier, "nextButtonText");
        }
        public static void SetNextButtonText(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxList.SetOption", identifier, "nextButtonText", value);
        }
        public static string GetPageLoadingText(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxList.GetOption", identifier, "pageLoadingText");
        }
        public static void SetPageLoadingText(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxList.SetOption", identifier, "pageLoadingText", value);
        }
        public static string GetPageLoadMode(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxList.GetOption", identifier, "pageLoadMode");
        }
        public static void SetPageLoadMode(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxList.SetOption", identifier, "pageLoadMode", value);
        }
        public static string GetPulledDownText(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxList.GetOption", identifier, "pulledDownText");
        }
        public static void SetPulledDownText(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxList.SetOption", identifier, "pulledDownText", value);
        }
        public static string GetPullingDownText(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxList.GetOption", identifier, "pullingDownText");
        }
        public static void SetPullingDownText(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxList.SetOption", identifier, "pullingDownText", value);
        }
        public static bool? GetPullRefreshEnabled(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxList.GetOption", identifier, "pullRefreshEnabled");
        }
        public static void SetPullRefreshEnabled(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxList.SetOption", identifier, "pullRefreshEnabled", value);
        }
        public static string GetRefreshingText(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxList.GetOption", identifier, "refreshingText");
        }
        public static void SetRefreshingText(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxList.SetOption", identifier, "refreshingText", value);
        }
        public static bool? GetScrollByContent(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxList.GetOption", identifier, "scrollByContent");
        }
        public static void SetScrollByContent(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxList.SetOption", identifier, "scrollByContent", value);
        }
        public static bool? GetScrollByThumb(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxList.GetOption", identifier, "scrollByThumb");
        }
        public static void SetScrollByThumb(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxList.SetOption", identifier, "scrollByThumb", value);
        }
        public static bool? GetScrollingEnabled(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxList.GetOption", identifier, "scrollingEnabled");
        }
        public static void SetScrollingEnabled(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxList.SetOption", identifier, "scrollingEnabled", value);
        }
        public static string GetSelectAllMode(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxList.GetOption", identifier, "selectAllMode");
        }
        public static void SetSelectAllMode(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxList.SetOption", identifier, "selectAllMode", value);
        }
        public static string GetSelectionMode(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxList.GetOption", identifier, "selectionMode");
        }
        public static void SetSelectionMode(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxList.SetOption", identifier, "selectionMode", value);
        }
        public static string GetShowScrollbar(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxList.GetOption", identifier, "showScrollbar");
        }
        public static void SetShowScrollbar(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxList.SetOption", identifier, "showScrollbar", value);
        }
        public static bool? GetShowSelectionControls(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxList.GetOption", identifier, "showSelectionControls");
        }
        public static void SetShowSelectionControls(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxList.SetOption", identifier, "showSelectionControls", value);
        }
        public static bool? GetUseNativeScrolling(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxList.GetOption", identifier, "useNativeScrolling");
        }
        public static void SetUseNativeScrolling(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxList.SetOption", identifier, "useNativeScrolling", value);
        }
        public static float ClientHeight(string identifier)
        {
            return RegisteredFunction.Invoke<float>("BlazorDevExtreme.DxList.clientHeight_0", identifier);
        }
        public static object CollapseGroup(string identifier, float groupIndex)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxList.collapseGroup_1", identifier, groupIndex);
        }
        public static object DeleteItem(string identifier, object itemElement)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxList.deleteItem_2", identifier, itemElement);
        }
        public static object ExpandGroup(string identifier, float groupIndex)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxList.expandGroup_4", identifier, groupIndex);
        }
        public static bool IsItemSelected(string identifier, object itemElement)
        {
            return RegisteredFunction.Invoke<bool>("BlazorDevExtreme.DxList.isItemSelected_5", identifier, itemElement);
        }
        public static void Reload(string identifier)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxList.reload_7", identifier);
        }
        public static object ReorderItem(string identifier, object itemElement, object toItemElement)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxList.reorderItem_8", identifier, itemElement, toItemElement);
        }
        public static void ScrollBy(string identifier, float distance)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxList.scrollBy_10", identifier, distance);
        }
        public static float ScrollHeight(string identifier)
        {
            return RegisteredFunction.Invoke<float>("BlazorDevExtreme.DxList.scrollHeight_11", identifier);
        }
        public static void ScrollTo(string identifier, float location)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxList.scrollTo_12", identifier, location);
        }
        public static void ScrollToItem(string identifier, object itemElement)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxList.scrollToItem_13", identifier, itemElement);
        }
        public static float ScrollTop(string identifier)
        {
            return RegisteredFunction.Invoke<float>("BlazorDevExtreme.DxList.scrollTop_15", identifier);
        }
        public static void SelectAll(string identifier)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxList.selectAll_16", identifier);
        }
        public static void SelectItem(string identifier, object itemElement)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxList.selectItem_17", identifier, itemElement);
        }
        public static void UnselectAll(string identifier)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxList.unselectAll_19", identifier);
        }
        public static void UnselectItem(string identifier, object itemElement)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxList.unselectItem_20", identifier, itemElement);
        }
        public static object UpdateDimensions(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxList.updateDimensions_22", identifier);
        }
    }
    public class DxLoadIndicatorInterop : WidgetInterop
    {
        public static void Init(string identifier, DevExpress.Ui.DxLoadIndicatorOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxLoadIndicator.Init", identifier, json);
        }
        public static string GetIndicatorSrc(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxLoadIndicator.GetOption", identifier, "indicatorSrc");
        }
        public static void SetIndicatorSrc(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxLoadIndicator.SetOption", identifier, "indicatorSrc", value);
        }
    }
    public class DxLoadPanelInterop : DxOverlayInterop
    {
        public static void Init(string identifier, DevExpress.Ui.DxLoadPanelOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxLoadPanel.Init", identifier, json);
        }
        public static new object GetAnimation(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxLoadPanel.GetOption", identifier, "animation");
        }
        public static new void SetAnimation(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxLoadPanel.SetOption", identifier, "animation", value);
        }
        public static float? GetDelay(string identifier)
        {
            return RegisteredFunction.Invoke<float?>("BlazorDevExtreme.DxLoadPanel.GetOption", identifier, "delay");
        }
        public static void SetDelay(string identifier, float? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxLoadPanel.SetOption", identifier, "delay", value);
        }
        public static new bool? GetFocusStateEnabled(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxLoadPanel.GetOption", identifier, "focusStateEnabled");
        }
        public static new void SetFocusStateEnabled(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxLoadPanel.SetOption", identifier, "focusStateEnabled", value);
        }
        public static new float? GetHeight(string identifier)
        {
            return RegisteredFunction.Invoke<float?>("BlazorDevExtreme.DxLoadPanel.GetOption", identifier, "height");
        }
        public static new void SetHeight(string identifier, float? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxLoadPanel.SetOption", identifier, "height", value);
        }
        public static string GetIndicatorSrc(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxLoadPanel.GetOption", identifier, "indicatorSrc");
        }
        public static void SetIndicatorSrc(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxLoadPanel.SetOption", identifier, "indicatorSrc", value);
        }
        public static string GetMessage(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxLoadPanel.GetOption", identifier, "message");
        }
        public static void SetMessage(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxLoadPanel.SetOption", identifier, "message", value);
        }
        public static new object GetPosition(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxLoadPanel.GetOption", identifier, "position");
        }
        public static new void SetPosition(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxLoadPanel.SetOption", identifier, "position", value);
        }
        public static new string GetShadingColor(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxLoadPanel.GetOption", identifier, "shadingColor");
        }
        public static new void SetShadingColor(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxLoadPanel.SetOption", identifier, "shadingColor", value);
        }
        public static bool? GetShowIndicator(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxLoadPanel.GetOption", identifier, "showIndicator");
        }
        public static void SetShowIndicator(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxLoadPanel.SetOption", identifier, "showIndicator", value);
        }
        public static bool? GetShowPane(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxLoadPanel.GetOption", identifier, "showPane");
        }
        public static void SetShowPane(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxLoadPanel.SetOption", identifier, "showPane", value);
        }
        public static new float? GetWidth(string identifier)
        {
            return RegisteredFunction.Invoke<float?>("BlazorDevExtreme.DxLoadPanel.GetOption", identifier, "width");
        }
        public static new void SetWidth(string identifier, float? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxLoadPanel.SetOption", identifier, "width", value);
        }
    }
    public class DxLookupInterop : DxDropDownListInterop
    {
        public static event EventHandler<JQueryEventArgs> PageLoading;
        public static event EventHandler<JQueryEventArgs> PullRefresh;
        public static event EventHandler<JQueryEventArgs> Scroll;
        public static event EventHandler<JQueryEventArgs> TitleRendered;
        public static event EventHandler<JQueryEventArgs> ValueChanged;
        public static void Init(string identifier, DevExpress.Ui.DxLookupOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxLookup.Init", identifier, json);
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
        public static object GetAnimation(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxLookup.GetOption", identifier, "animation");
        }
        public static void SetAnimation(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxLookup.SetOption", identifier, "animation", value);
        }
        public static string GetApplyButtonText(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxLookup.GetOption", identifier, "applyButtonText");
        }
        public static void SetApplyButtonText(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxLookup.SetOption", identifier, "applyButtonText", value);
        }
        public static new string GetApplyValueMode(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxLookup.GetOption", identifier, "applyValueMode");
        }
        public static new void SetApplyValueMode(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxLookup.SetOption", identifier, "applyValueMode", value);
        }
        public static string GetCancelButtonText(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxLookup.GetOption", identifier, "cancelButtonText");
        }
        public static void SetCancelButtonText(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxLookup.SetOption", identifier, "cancelButtonText", value);
        }
        public static bool? GetCleanSearchOnOpening(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxLookup.GetOption", identifier, "cleanSearchOnOpening");
        }
        public static void SetCleanSearchOnOpening(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxLookup.SetOption", identifier, "cleanSearchOnOpening", value);
        }
        public static string GetClearButtonText(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxLookup.GetOption", identifier, "clearButtonText");
        }
        public static void SetClearButtonText(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxLookup.SetOption", identifier, "clearButtonText", value);
        }
        public static object GetCloseOnOutsideClick(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxLookup.GetOption", identifier, "closeOnOutsideClick");
        }
        public static void SetCloseOnOutsideClick(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxLookup.SetOption", identifier, "closeOnOutsideClick", value);
        }
        public static object GetFieldTemplate(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxLookup.GetOption", identifier, "fieldTemplate");
        }
        public static void SetFieldTemplate(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxLookup.SetOption", identifier, "fieldTemplate", value);
        }
        public static new bool? GetFocusStateEnabled(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxLookup.GetOption", identifier, "focusStateEnabled");
        }
        public static new void SetFocusStateEnabled(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxLookup.SetOption", identifier, "focusStateEnabled", value);
        }
        public static bool? GetFullScreen(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxLookup.GetOption", identifier, "fullScreen");
        }
        public static void SetFullScreen(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxLookup.SetOption", identifier, "fullScreen", value);
        }
        public static new bool? GetGrouped(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxLookup.GetOption", identifier, "grouped");
        }
        public static new void SetGrouped(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxLookup.SetOption", identifier, "grouped", value);
        }
        public static new object GetGroupTemplate(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxLookup.GetOption", identifier, "groupTemplate");
        }
        public static new void SetGroupTemplate(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxLookup.SetOption", identifier, "groupTemplate", value);
        }
        public static string GetNextButtonText(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxLookup.GetOption", identifier, "nextButtonText");
        }
        public static void SetNextButtonText(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxLookup.SetOption", identifier, "nextButtonText", value);
        }
        public static string GetPageLoadingText(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxLookup.GetOption", identifier, "pageLoadingText");
        }
        public static void SetPageLoadingText(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxLookup.SetOption", identifier, "pageLoadingText", value);
        }
        public static string GetPageLoadMode(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxLookup.GetOption", identifier, "pageLoadMode");
        }
        public static void SetPageLoadMode(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxLookup.SetOption", identifier, "pageLoadMode", value);
        }
        public static new string GetPlaceholder(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxLookup.GetOption", identifier, "placeholder");
        }
        public static new void SetPlaceholder(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxLookup.SetOption", identifier, "placeholder", value);
        }
        public static object GetPopupHeight(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxLookup.GetOption", identifier, "popupHeight");
        }
        public static void SetPopupHeight(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxLookup.SetOption", identifier, "popupHeight", value);
        }
        public static object GetPopupWidth(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxLookup.GetOption", identifier, "popupWidth");
        }
        public static void SetPopupWidth(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxLookup.SetOption", identifier, "popupWidth", value);
        }
        public static object GetPosition(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxLookup.GetOption", identifier, "position");
        }
        public static void SetPosition(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxLookup.SetOption", identifier, "position", value);
        }
        public static string GetPulledDownText(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxLookup.GetOption", identifier, "pulledDownText");
        }
        public static void SetPulledDownText(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxLookup.SetOption", identifier, "pulledDownText", value);
        }
        public static string GetPullingDownText(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxLookup.GetOption", identifier, "pullingDownText");
        }
        public static void SetPullingDownText(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxLookup.SetOption", identifier, "pullingDownText", value);
        }
        public static bool? GetPullRefreshEnabled(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxLookup.GetOption", identifier, "pullRefreshEnabled");
        }
        public static void SetPullRefreshEnabled(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxLookup.SetOption", identifier, "pullRefreshEnabled", value);
        }
        public static string GetRefreshingText(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxLookup.GetOption", identifier, "refreshingText");
        }
        public static void SetRefreshingText(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxLookup.SetOption", identifier, "refreshingText", value);
        }
        public static new bool? GetSearchEnabled(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxLookup.GetOption", identifier, "searchEnabled");
        }
        public static new void SetSearchEnabled(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxLookup.SetOption", identifier, "searchEnabled", value);
        }
        public static string GetSearchPlaceholder(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxLookup.GetOption", identifier, "searchPlaceholder");
        }
        public static void SetSearchPlaceholder(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxLookup.SetOption", identifier, "searchPlaceholder", value);
        }
        public static bool? GetShading(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxLookup.GetOption", identifier, "shading");
        }
        public static void SetShading(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxLookup.SetOption", identifier, "shading", value);
        }
        public static bool? GetShowCancelButton(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxLookup.GetOption", identifier, "showCancelButton");
        }
        public static void SetShowCancelButton(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxLookup.SetOption", identifier, "showCancelButton", value);
        }
        public static new bool? GetShowClearButton(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxLookup.GetOption", identifier, "showClearButton");
        }
        public static new void SetShowClearButton(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxLookup.SetOption", identifier, "showClearButton", value);
        }
        public static bool? GetShowPopupTitle(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxLookup.GetOption", identifier, "showPopupTitle");
        }
        public static void SetShowPopupTitle(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxLookup.SetOption", identifier, "showPopupTitle", value);
        }
        public static string GetTitle(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxLookup.GetOption", identifier, "title");
        }
        public static void SetTitle(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxLookup.SetOption", identifier, "title", value);
        }
        public static object GetTitleTemplate(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxLookup.GetOption", identifier, "titleTemplate");
        }
        public static void SetTitleTemplate(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxLookup.SetOption", identifier, "titleTemplate", value);
        }
        public static bool? GetUseNativeScrolling(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxLookup.GetOption", identifier, "useNativeScrolling");
        }
        public static void SetUseNativeScrolling(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxLookup.SetOption", identifier, "useNativeScrolling", value);
        }
        public static bool? GetUsePopover(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxLookup.GetOption", identifier, "usePopover");
        }
        public static void SetUsePopover(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxLookup.SetOption", identifier, "usePopover", value);
        }
    }
    public class DxMapInterop : WidgetInterop
    {
        public static event EventHandler<JQueryEventArgs> Click;
        public static event EventHandler<JQueryEventArgs> MarkerAdded;
        public static event EventHandler<JQueryEventArgs> MarkerRemoved;
        public static event EventHandler<JQueryEventArgs> Ready;
        public static event EventHandler<JQueryEventArgs> RouteAdded;
        public static event EventHandler<JQueryEventArgs> RouteRemoved;
        public static void Init(string identifier, DevExpress.Ui.DxMapOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxMap.Init", identifier, json);
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
        public static bool? GetAutoAdjust(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxMap.GetOption", identifier, "autoAdjust");
        }
        public static void SetAutoAdjust(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxMap.SetOption", identifier, "autoAdjust", value);
        }
        public static object GetCenter(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxMap.GetOption", identifier, "center");
        }
        public static void SetCenter(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxMap.SetOption", identifier, "center", value);
        }
        public static bool? GetControls(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxMap.GetOption", identifier, "controls");
        }
        public static void SetControls(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxMap.SetOption", identifier, "controls", value);
        }
        public static new bool? GetFocusStateEnabled(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxMap.GetOption", identifier, "focusStateEnabled");
        }
        public static new void SetFocusStateEnabled(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxMap.SetOption", identifier, "focusStateEnabled", value);
        }
        public static new object GetHeight(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxMap.GetOption", identifier, "height");
        }
        public static new void SetHeight(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxMap.SetOption", identifier, "height", value);
        }
        public static object GetKey(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxMap.GetOption", identifier, "key");
        }
        public static void SetKey(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxMap.SetOption", identifier, "key", value);
        }
        public static string GetMarkerIconSrc(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxMap.GetOption", identifier, "markerIconSrc");
        }
        public static void SetMarkerIconSrc(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxMap.SetOption", identifier, "markerIconSrc", value);
        }
        public static object GetMarkers(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxMap.GetOption", identifier, "markers");
        }
        public static void SetMarkers(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxMap.SetOption", identifier, "markers", value);
        }
        public static string GetProvider(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxMap.GetOption", identifier, "provider");
        }
        public static void SetProvider(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxMap.SetOption", identifier, "provider", value);
        }
        public static object GetRoutes(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxMap.GetOption", identifier, "routes");
        }
        public static void SetRoutes(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxMap.SetOption", identifier, "routes", value);
        }
        public static string GetType(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxMap.GetOption", identifier, "type");
        }
        public static void SetType(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxMap.SetOption", identifier, "type", value);
        }
        public static new object GetWidth(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxMap.GetOption", identifier, "width");
        }
        public static new void SetWidth(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxMap.SetOption", identifier, "width", value);
        }
        public static float? GetZoom(string identifier)
        {
            return RegisteredFunction.Invoke<float?>("BlazorDevExtreme.DxMap.GetOption", identifier, "zoom");
        }
        public static void SetZoom(string identifier, float? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxMap.SetOption", identifier, "zoom", value);
        }
        public static object AddMarker(string identifier, object markerOptions)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxMap.addMarker_0", identifier, markerOptions);
        }
        public static object AddRoute(string identifier, object options)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxMap.addRoute_1", identifier, options);
        }
        public static object RemoveMarker(string identifier, object marker)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxMap.removeMarker_2", identifier, marker);
        }
        public static object RemoveRoute(string identifier, object route)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxMap.removeRoute_3", identifier, route);
        }
    }
    public class DxMenuInterop : DxMenuBaseInterop
    {
        public static event EventHandler<JQueryEventArgs> SubmenuHidden;
        public static event EventHandler<JQueryEventArgs> SubmenuHiding;
        public static event EventHandler<JQueryEventArgs> SubmenuShowing;
        public static event EventHandler<JQueryEventArgs> SubmenuShown;
        public static void Init(string identifier, DevExpress.Ui.DxMenuOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxMenu.Init", identifier, json);
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
        public static bool? GetAdaptivityEnabled(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxMenu.GetOption", identifier, "adaptivityEnabled");
        }
        public static void SetAdaptivityEnabled(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxMenu.SetOption", identifier, "adaptivityEnabled", value);
        }
        public static bool? GetHideSubmenuOnMouseLeave(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxMenu.GetOption", identifier, "hideSubmenuOnMouseLeave");
        }
        public static void SetHideSubmenuOnMouseLeave(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxMenu.SetOption", identifier, "hideSubmenuOnMouseLeave", value);
        }
        public static new object GetItems(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxMenu.GetOption", identifier, "items");
        }
        public static new void SetItems(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxMenu.SetOption", identifier, "items", value);
        }
        public static string GetOrientation(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxMenu.GetOption", identifier, "orientation");
        }
        public static void SetOrientation(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxMenu.SetOption", identifier, "orientation", value);
        }
        public static object GetShowFirstSubmenuMode(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxMenu.GetOption", identifier, "showFirstSubmenuMode");
        }
        public static void SetShowFirstSubmenuMode(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxMenu.SetOption", identifier, "showFirstSubmenuMode", value);
        }
        public static string GetSubmenuDirection(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxMenu.GetOption", identifier, "submenuDirection");
        }
        public static void SetSubmenuDirection(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxMenu.SetOption", identifier, "submenuDirection", value);
        }
    }
    public class DxMultiViewInterop : CollectionWidgetInterop
    {
        public static void Init(string identifier, DevExpress.Ui.DxMultiViewOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxMultiView.Init", identifier, json);
        }
        public static bool? GetAnimationEnabled(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxMultiView.GetOption", identifier, "animationEnabled");
        }
        public static void SetAnimationEnabled(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxMultiView.SetOption", identifier, "animationEnabled", value);
        }
        public static bool? GetDeferRendering(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxMultiView.GetOption", identifier, "deferRendering");
        }
        public static void SetDeferRendering(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxMultiView.SetOption", identifier, "deferRendering", value);
        }
        public static new bool? GetFocusStateEnabled(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxMultiView.GetOption", identifier, "focusStateEnabled");
        }
        public static new void SetFocusStateEnabled(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxMultiView.SetOption", identifier, "focusStateEnabled", value);
        }
        public static bool? GetLoop(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxMultiView.GetOption", identifier, "loop");
        }
        public static void SetLoop(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxMultiView.SetOption", identifier, "loop", value);
        }
        public static new float? GetSelectedIndex(string identifier)
        {
            return RegisteredFunction.Invoke<float?>("BlazorDevExtreme.DxMultiView.GetOption", identifier, "selectedIndex");
        }
        public static new void SetSelectedIndex(string identifier, float? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxMultiView.SetOption", identifier, "selectedIndex", value);
        }
        public static bool? GetSwipeEnabled(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxMultiView.GetOption", identifier, "swipeEnabled");
        }
        public static void SetSwipeEnabled(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxMultiView.SetOption", identifier, "swipeEnabled", value);
        }
    }
    public class DxNavBarInterop : DxTabsInterop
    {
        public static void Init(string identifier, DevExpress.Ui.DxNavBarOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxNavBar.Init", identifier, json);
        }
        public static new bool? GetScrollByContent(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxNavBar.GetOption", identifier, "scrollByContent");
        }
        public static new void SetScrollByContent(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxNavBar.SetOption", identifier, "scrollByContent", value);
        }
    }
    public class DxNumberBoxInterop : DxTextEditorInterop
    {
        public static void Init(string identifier, DevExpress.Ui.DxNumberBoxOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxNumberBox.Init", identifier, json);
        }
        public static object GetFormat(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxNumberBox.GetOption", identifier, "format");
        }
        public static void SetFormat(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxNumberBox.SetOption", identifier, "format", value);
        }
        public static string GetInvalidValueMessage(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxNumberBox.GetOption", identifier, "invalidValueMessage");
        }
        public static void SetInvalidValueMessage(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxNumberBox.SetOption", identifier, "invalidValueMessage", value);
        }
        public static float? GetMax(string identifier)
        {
            return RegisteredFunction.Invoke<float?>("BlazorDevExtreme.DxNumberBox.GetOption", identifier, "max");
        }
        public static void SetMax(string identifier, float? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxNumberBox.SetOption", identifier, "max", value);
        }
        public static float? GetMin(string identifier)
        {
            return RegisteredFunction.Invoke<float?>("BlazorDevExtreme.DxNumberBox.GetOption", identifier, "min");
        }
        public static void SetMin(string identifier, float? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxNumberBox.SetOption", identifier, "min", value);
        }
        public static string GetMode(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxNumberBox.GetOption", identifier, "mode");
        }
        public static void SetMode(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxNumberBox.SetOption", identifier, "mode", value);
        }
        public static bool? GetShowSpinButtons(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxNumberBox.GetOption", identifier, "showSpinButtons");
        }
        public static void SetShowSpinButtons(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxNumberBox.SetOption", identifier, "showSpinButtons", value);
        }
        public static float? GetStep(string identifier)
        {
            return RegisteredFunction.Invoke<float?>("BlazorDevExtreme.DxNumberBox.GetOption", identifier, "step");
        }
        public static void SetStep(string identifier, float? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxNumberBox.SetOption", identifier, "step", value);
        }
        public static bool? GetUseLargeSpinButtons(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxNumberBox.GetOption", identifier, "useLargeSpinButtons");
        }
        public static void SetUseLargeSpinButtons(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxNumberBox.SetOption", identifier, "useLargeSpinButtons", value);
        }
        public static new float? GetValue(string identifier)
        {
            return RegisteredFunction.Invoke<float?>("BlazorDevExtreme.DxNumberBox.GetOption", identifier, "value");
        }
        public static new void SetValue(string identifier, float? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxNumberBox.SetOption", identifier, "value", value);
        }
    }
    public class DxOverlayInterop : WidgetInterop
    {
        public static event EventHandler<JQueryEventArgs> Hidden;
        public static event EventHandler<JQueryEventArgs> Hiding;
        public static event EventHandler<JQueryEventArgs> Showing;
        public static event EventHandler<JQueryEventArgs> Shown;
        public static void Init(string identifier, DevExpress.Ui.DxOverlayOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxOverlay.Init", identifier, json);
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
        public static object GetAnimation(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxOverlay.GetOption", identifier, "animation");
        }
        public static void SetAnimation(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxOverlay.SetOption", identifier, "animation", value);
        }
        public static bool? GetCloseOnBackButton(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxOverlay.GetOption", identifier, "closeOnBackButton");
        }
        public static void SetCloseOnBackButton(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxOverlay.SetOption", identifier, "closeOnBackButton", value);
        }
        public static object GetCloseOnOutsideClick(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxOverlay.GetOption", identifier, "closeOnOutsideClick");
        }
        public static void SetCloseOnOutsideClick(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxOverlay.SetOption", identifier, "closeOnOutsideClick", value);
        }
        public static object GetContentTemplate(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxOverlay.GetOption", identifier, "contentTemplate");
        }
        public static void SetContentTemplate(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxOverlay.SetOption", identifier, "contentTemplate", value);
        }
        public static bool? GetDeferRendering(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxOverlay.GetOption", identifier, "deferRendering");
        }
        public static void SetDeferRendering(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxOverlay.SetOption", identifier, "deferRendering", value);
        }
        public static bool? GetDragEnabled(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxOverlay.GetOption", identifier, "dragEnabled");
        }
        public static void SetDragEnabled(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxOverlay.SetOption", identifier, "dragEnabled", value);
        }
        public static new object GetHeight(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxOverlay.GetOption", identifier, "height");
        }
        public static new void SetHeight(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxOverlay.SetOption", identifier, "height", value);
        }
        public static object GetMaxHeight(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxOverlay.GetOption", identifier, "maxHeight");
        }
        public static void SetMaxHeight(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxOverlay.SetOption", identifier, "maxHeight", value);
        }
        public static object GetMaxWidth(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxOverlay.GetOption", identifier, "maxWidth");
        }
        public static void SetMaxWidth(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxOverlay.SetOption", identifier, "maxWidth", value);
        }
        public static object GetMinHeight(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxOverlay.GetOption", identifier, "minHeight");
        }
        public static void SetMinHeight(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxOverlay.SetOption", identifier, "minHeight", value);
        }
        public static object GetMinWidth(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxOverlay.GetOption", identifier, "minWidth");
        }
        public static void SetMinWidth(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxOverlay.SetOption", identifier, "minWidth", value);
        }
        public static object GetPosition(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxOverlay.GetOption", identifier, "position");
        }
        public static void SetPosition(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxOverlay.SetOption", identifier, "position", value);
        }
        public static bool? GetShading(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxOverlay.GetOption", identifier, "shading");
        }
        public static void SetShading(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxOverlay.SetOption", identifier, "shading", value);
        }
        public static string GetShadingColor(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxOverlay.GetOption", identifier, "shadingColor");
        }
        public static void SetShadingColor(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxOverlay.SetOption", identifier, "shadingColor", value);
        }
        public static new bool? GetVisible(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxOverlay.GetOption", identifier, "visible");
        }
        public static new void SetVisible(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxOverlay.SetOption", identifier, "visible", value);
        }
        public static new object GetWidth(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxOverlay.GetOption", identifier, "width");
        }
        public static new void SetWidth(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxOverlay.SetOption", identifier, "width", value);
        }
        public static object Content(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxOverlay.content_0", identifier);
        }
        public static object Hide(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxOverlay.hide_1", identifier);
        }
        public static void Repaint(string identifier)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxOverlay.repaint_2", identifier);
        }
        public static object Show(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxOverlay.show_3", identifier);
        }
        public static object Toggle(string identifier, bool showing)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxOverlay.toggle_4", identifier, showing);
        }
    }
    public class DxPanoramaInterop : CollectionWidgetInterop
    {
        public static void Init(string identifier, DevExpress.Ui.DxPanoramaOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPanorama.Init", identifier, json);
        }
        public static object GetBackgroundImage(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPanorama.GetOption", identifier, "backgroundImage");
        }
        public static void SetBackgroundImage(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPanorama.SetOption", identifier, "backgroundImage", value);
        }
        public static new bool? GetFocusStateEnabled(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxPanorama.GetOption", identifier, "focusStateEnabled");
        }
        public static new void SetFocusStateEnabled(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPanorama.SetOption", identifier, "focusStateEnabled", value);
        }
        public static new float? GetSelectedIndex(string identifier)
        {
            return RegisteredFunction.Invoke<float?>("BlazorDevExtreme.DxPanorama.GetOption", identifier, "selectedIndex");
        }
        public static new void SetSelectedIndex(string identifier, float? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPanorama.SetOption", identifier, "selectedIndex", value);
        }
        public static string GetTitle(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxPanorama.GetOption", identifier, "title");
        }
        public static void SetTitle(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPanorama.SetOption", identifier, "title", value);
        }
    }
    public class DxPivotInterop : CollectionWidgetInterop
    {
        public static void Init(string identifier, DevExpress.Ui.DxPivotOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPivot.Init", identifier, json);
        }
        public static object GetContentTemplate(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPivot.GetOption", identifier, "contentTemplate");
        }
        public static void SetContentTemplate(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPivot.SetOption", identifier, "contentTemplate", value);
        }
        public static object GetItemTitleTemplate(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPivot.GetOption", identifier, "itemTitleTemplate");
        }
        public static void SetItemTitleTemplate(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPivot.SetOption", identifier, "itemTitleTemplate", value);
        }
        public static new float? GetSelectedIndex(string identifier)
        {
            return RegisteredFunction.Invoke<float?>("BlazorDevExtreme.DxPivot.GetOption", identifier, "selectedIndex");
        }
        public static new void SetSelectedIndex(string identifier, float? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPivot.SetOption", identifier, "selectedIndex", value);
        }
        public static bool? GetSwipeEnabled(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxPivot.GetOption", identifier, "swipeEnabled");
        }
        public static void SetSwipeEnabled(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPivot.SetOption", identifier, "swipeEnabled", value);
        }
    }
    public class DxPivotGridInterop : WidgetInterop
    {
        public static event EventHandler<JQueryEventArgs> CellClick;
        public static event EventHandler<JQueryEventArgs> CellPrepared;
        public static event EventHandler<JQueryEventArgs> ContextMenuPreparing;
        public static event EventHandler<JQueryEventArgs> Exported;
        public static event EventHandler<JQueryEventArgs> Exporting;
        public static event EventHandler<JQueryEventArgs> FileSaving;
        public static void Init(string identifier, DevExpress.Ui.DxPivotGridOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPivotGrid.Init", identifier, json);
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
        public static bool? GetAllowExpandAll(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxPivotGrid.GetOption", identifier, "allowExpandAll");
        }
        public static void SetAllowExpandAll(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPivotGrid.SetOption", identifier, "allowExpandAll", value);
        }
        public static bool? GetAllowFiltering(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxPivotGrid.GetOption", identifier, "allowFiltering");
        }
        public static void SetAllowFiltering(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPivotGrid.SetOption", identifier, "allowFiltering", value);
        }
        public static bool? GetAllowSorting(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxPivotGrid.GetOption", identifier, "allowSorting");
        }
        public static void SetAllowSorting(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPivotGrid.SetOption", identifier, "allowSorting", value);
        }
        public static bool? GetAllowSortingBySummary(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxPivotGrid.GetOption", identifier, "allowSortingBySummary");
        }
        public static void SetAllowSortingBySummary(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPivotGrid.SetOption", identifier, "allowSortingBySummary", value);
        }
        public static string GetDataFieldArea(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxPivotGrid.GetOption", identifier, "dataFieldArea");
        }
        public static void SetDataFieldArea(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPivotGrid.SetOption", identifier, "dataFieldArea", value);
        }
        public static object GetDataSource(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPivotGrid.GetOption", identifier, "dataSource");
        }
        public static void SetDataSource(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPivotGrid.SetOption", identifier, "dataSource", value);
        }
        public static object GetExport(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPivotGrid.GetOption", identifier, "export");
        }
        public static void SetExport(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPivotGrid.SetOption", identifier, "export", value);
        }
        public static object GetFieldChooser(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPivotGrid.GetOption", identifier, "fieldChooser");
        }
        public static void SetFieldChooser(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPivotGrid.SetOption", identifier, "fieldChooser", value);
        }
        public static object GetFieldPanel(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPivotGrid.GetOption", identifier, "fieldPanel");
        }
        public static void SetFieldPanel(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPivotGrid.SetOption", identifier, "fieldPanel", value);
        }
        public static object GetHeaderFilter(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPivotGrid.GetOption", identifier, "headerFilter");
        }
        public static void SetHeaderFilter(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPivotGrid.SetOption", identifier, "headerFilter", value);
        }
        public static bool? GetHideEmptySummaryCells(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxPivotGrid.GetOption", identifier, "hideEmptySummaryCells");
        }
        public static void SetHideEmptySummaryCells(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPivotGrid.SetOption", identifier, "hideEmptySummaryCells", value);
        }
        public static object GetLoadPanel(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPivotGrid.GetOption", identifier, "loadPanel");
        }
        public static void SetLoadPanel(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPivotGrid.SetOption", identifier, "loadPanel", value);
        }
        public static string GetRowHeaderLayout(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxPivotGrid.GetOption", identifier, "rowHeaderLayout");
        }
        public static void SetRowHeaderLayout(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPivotGrid.SetOption", identifier, "rowHeaderLayout", value);
        }
        public static object GetScrolling(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPivotGrid.GetOption", identifier, "scrolling");
        }
        public static void SetScrolling(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPivotGrid.SetOption", identifier, "scrolling", value);
        }
        public static bool? GetShowBorders(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxPivotGrid.GetOption", identifier, "showBorders");
        }
        public static void SetShowBorders(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPivotGrid.SetOption", identifier, "showBorders", value);
        }
        public static bool? GetShowColumnGrandTotals(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxPivotGrid.GetOption", identifier, "showColumnGrandTotals");
        }
        public static void SetShowColumnGrandTotals(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPivotGrid.SetOption", identifier, "showColumnGrandTotals", value);
        }
        public static bool? GetShowColumnTotals(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxPivotGrid.GetOption", identifier, "showColumnTotals");
        }
        public static void SetShowColumnTotals(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPivotGrid.SetOption", identifier, "showColumnTotals", value);
        }
        public static bool? GetShowRowGrandTotals(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxPivotGrid.GetOption", identifier, "showRowGrandTotals");
        }
        public static void SetShowRowGrandTotals(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPivotGrid.SetOption", identifier, "showRowGrandTotals", value);
        }
        public static bool? GetShowRowTotals(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxPivotGrid.GetOption", identifier, "showRowTotals");
        }
        public static void SetShowRowTotals(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPivotGrid.SetOption", identifier, "showRowTotals", value);
        }
        public static string GetShowTotalsPrior(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxPivotGrid.GetOption", identifier, "showTotalsPrior");
        }
        public static void SetShowTotalsPrior(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPivotGrid.SetOption", identifier, "showTotalsPrior", value);
        }
        public static object GetStateStoring(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPivotGrid.GetOption", identifier, "stateStoring");
        }
        public static void SetStateStoring(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPivotGrid.SetOption", identifier, "stateStoring", value);
        }
        public static object GetTexts(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPivotGrid.GetOption", identifier, "texts");
        }
        public static void SetTexts(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPivotGrid.SetOption", identifier, "texts", value);
        }
        public static bool? GetWordWrapEnabled(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxPivotGrid.GetOption", identifier, "wordWrapEnabled");
        }
        public static void SetWordWrapEnabled(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPivotGrid.SetOption", identifier, "wordWrapEnabled", value);
        }
        public static object BindChart(string identifier, object chart, object integrationOptions)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPivotGrid.bindChart_0", identifier, chart, integrationOptions);
        }
        public static void ExportToExcel(string identifier)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPivotGrid.exportToExcel_1", identifier);
        }
        public static object GetDataSourceEx(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPivotGrid.getDataSource_2", identifier);
        }
        public static object GetFieldChooserPopup(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPivotGrid.getFieldChooserPopup_3", identifier);
        }
        public static void UpdateDimensions(string identifier)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPivotGrid.updateDimensions_4", identifier);
        }
    }
    public class DxPivotGridFieldChooserInterop : WidgetInterop
    {
        public static event EventHandler<JQueryEventArgs> ContextMenuPreparing;
        public static void Init(string identifier, DevExpress.Ui.DxPivotGridFieldChooserOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPivotGridFieldChooser.Init", identifier, json);
        }
        public static void OnContextMenuPreparing(string identifier)
        {
            ContextMenuPreparing?.Invoke(null, new JQueryEventArgs(identifier));
        }
        public static bool? GetAllowSearch(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxPivotGridFieldChooser.GetOption", identifier, "allowSearch");
        }
        public static void SetAllowSearch(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPivotGridFieldChooser.SetOption", identifier, "allowSearch", value);
        }
        public static string GetApplyChangesMode(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxPivotGridFieldChooser.GetOption", identifier, "applyChangesMode");
        }
        public static void SetApplyChangesMode(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPivotGridFieldChooser.SetOption", identifier, "applyChangesMode", value);
        }
        public static object GetDataSource(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPivotGridFieldChooser.GetOption", identifier, "dataSource");
        }
        public static void SetDataSource(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPivotGridFieldChooser.SetOption", identifier, "dataSource", value);
        }
        public static object GetHeaderFilter(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPivotGridFieldChooser.GetOption", identifier, "headerFilter");
        }
        public static void SetHeaderFilter(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPivotGridFieldChooser.SetOption", identifier, "headerFilter", value);
        }
        public static new object GetHeight(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPivotGridFieldChooser.GetOption", identifier, "height");
        }
        public static new void SetHeight(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPivotGridFieldChooser.SetOption", identifier, "height", value);
        }
        public static object GetLayout(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPivotGridFieldChooser.GetOption", identifier, "layout");
        }
        public static void SetLayout(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPivotGridFieldChooser.SetOption", identifier, "layout", value);
        }
        public static object GetState(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPivotGridFieldChooser.GetOption", identifier, "state");
        }
        public static void SetState(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPivotGridFieldChooser.SetOption", identifier, "state", value);
        }
        public static object GetTexts(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPivotGridFieldChooser.GetOption", identifier, "texts");
        }
        public static void SetTexts(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPivotGridFieldChooser.SetOption", identifier, "texts", value);
        }
        public static void ApplyChanges(string identifier)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPivotGridFieldChooser.applyChanges_0", identifier);
        }
        public static void CancelChanges(string identifier)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPivotGridFieldChooser.cancelChanges_1", identifier);
        }
        public static object GetDataSourceEx(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPivotGridFieldChooser.getDataSource_2", identifier);
        }
        public static void UpdateDimensions(string identifier)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPivotGridFieldChooser.updateDimensions_3", identifier);
        }
    }
    public class DxPopoverInterop : DxPopupInterop
    {
        public static void Init(string identifier, DevExpress.Ui.DxPopoverOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPopover.Init", identifier, json);
        }
        public static new object GetAnimation(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPopover.GetOption", identifier, "animation");
        }
        public static new void SetAnimation(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPopover.SetOption", identifier, "animation", value);
        }
        public static new object GetCloseOnOutsideClick(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPopover.GetOption", identifier, "closeOnOutsideClick");
        }
        public static new void SetCloseOnOutsideClick(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPopover.SetOption", identifier, "closeOnOutsideClick", value);
        }
        public static new object GetHeight(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPopover.GetOption", identifier, "height");
        }
        public static new void SetHeight(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPopover.SetOption", identifier, "height", value);
        }
        public static object GetHideEvent(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPopover.GetOption", identifier, "hideEvent");
        }
        public static void SetHideEvent(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPopover.SetOption", identifier, "hideEvent", value);
        }
        public static new object GetPosition(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPopover.GetOption", identifier, "position");
        }
        public static new void SetPosition(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPopover.SetOption", identifier, "position", value);
        }
        public static new bool? GetShading(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxPopover.GetOption", identifier, "shading");
        }
        public static new void SetShading(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPopover.SetOption", identifier, "shading", value);
        }
        public static object GetShowEvent(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPopover.GetOption", identifier, "showEvent");
        }
        public static void SetShowEvent(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPopover.SetOption", identifier, "showEvent", value);
        }
        public static new bool? GetShowTitle(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxPopover.GetOption", identifier, "showTitle");
        }
        public static new void SetShowTitle(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPopover.SetOption", identifier, "showTitle", value);
        }
        public static object GetTarget(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPopover.GetOption", identifier, "target");
        }
        public static void SetTarget(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPopover.SetOption", identifier, "target", value);
        }
        public static new object GetWidth(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPopover.GetOption", identifier, "width");
        }
        public static new void SetWidth(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPopover.SetOption", identifier, "width", value);
        }
        public static object Show(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPopover.show_0", identifier);
        }
        public static object Show(string identifier, object target)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPopover.show_1", identifier, target);
        }
    }
    public class DxPopupInterop : DxOverlayInterop
    {
        public static event EventHandler<JQueryEventArgs> Resize;
        public static event EventHandler<JQueryEventArgs> ResizeEnd;
        public static event EventHandler<JQueryEventArgs> ResizeStart;
        public static event EventHandler<JQueryEventArgs> TitleRendered;
        public static void Init(string identifier, DevExpress.Ui.DxPopupOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPopup.Init", identifier, json);
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
        public static new object GetAnimation(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPopup.GetOption", identifier, "animation");
        }
        public static new void SetAnimation(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPopup.SetOption", identifier, "animation", value);
        }
        public static object GetContainer(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPopup.GetOption", identifier, "container");
        }
        public static void SetContainer(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPopup.SetOption", identifier, "container", value);
        }
        public static new bool? GetDragEnabled(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxPopup.GetOption", identifier, "dragEnabled");
        }
        public static new void SetDragEnabled(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPopup.SetOption", identifier, "dragEnabled", value);
        }
        public static new bool? GetFocusStateEnabled(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxPopup.GetOption", identifier, "focusStateEnabled");
        }
        public static new void SetFocusStateEnabled(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPopup.SetOption", identifier, "focusStateEnabled", value);
        }
        public static bool? GetFullScreen(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxPopup.GetOption", identifier, "fullScreen");
        }
        public static void SetFullScreen(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPopup.SetOption", identifier, "fullScreen", value);
        }
        public static new object GetHeight(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPopup.GetOption", identifier, "height");
        }
        public static new void SetHeight(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPopup.SetOption", identifier, "height", value);
        }
        public static new object GetPosition(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPopup.GetOption", identifier, "position");
        }
        public static new void SetPosition(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPopup.SetOption", identifier, "position", value);
        }
        public static bool? GetResizeEnabled(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxPopup.GetOption", identifier, "resizeEnabled");
        }
        public static void SetResizeEnabled(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPopup.SetOption", identifier, "resizeEnabled", value);
        }
        public static bool? GetShowCloseButton(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxPopup.GetOption", identifier, "showCloseButton");
        }
        public static void SetShowCloseButton(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPopup.SetOption", identifier, "showCloseButton", value);
        }
        public static bool? GetShowTitle(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxPopup.GetOption", identifier, "showTitle");
        }
        public static void SetShowTitle(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPopup.SetOption", identifier, "showTitle", value);
        }
        public static string GetTitle(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxPopup.GetOption", identifier, "title");
        }
        public static void SetTitle(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPopup.SetOption", identifier, "title", value);
        }
        public static object GetTitleTemplate(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPopup.GetOption", identifier, "titleTemplate");
        }
        public static void SetTitleTemplate(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPopup.SetOption", identifier, "titleTemplate", value);
        }
        public static object GetToolbarItems(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPopup.GetOption", identifier, "toolbarItems");
        }
        public static void SetToolbarItems(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPopup.SetOption", identifier, "toolbarItems", value);
        }
        public static new object GetWidth(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPopup.GetOption", identifier, "width");
        }
        public static new void SetWidth(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPopup.SetOption", identifier, "width", value);
        }
    }
    public class DxProgressBarInterop : DxTrackBarInterop
    {
        public static event EventHandler<JQueryEventArgs> Complete;
        public static void Init(string identifier, DevExpress.Ui.DxProgressBarOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxProgressBar.Init", identifier, json);
        }
        public static void OnComplete(string identifier)
        {
            Complete?.Invoke(null, new JQueryEventArgs(identifier));
        }
        public static bool? GetShowStatus(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxProgressBar.GetOption", identifier, "showStatus");
        }
        public static void SetShowStatus(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxProgressBar.SetOption", identifier, "showStatus", value);
        }
        public static object GetStatusFormat(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxProgressBar.GetOption", identifier, "statusFormat");
        }
        public static void SetStatusFormat(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxProgressBar.SetOption", identifier, "statusFormat", value);
        }
        public static new float? GetValue(string identifier)
        {
            return RegisteredFunction.Invoke<float?>("BlazorDevExtreme.DxProgressBar.GetOption", identifier, "value");
        }
        public static new void SetValue(string identifier, float? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxProgressBar.SetOption", identifier, "value", value);
        }
    }
    public class DxRadioGroupInterop : EditorInterop
    {
        public static void Init(string identifier, DevExpress.Ui.DxRadioGroupOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxRadioGroup.Init", identifier, json);
        }
        public static new bool? GetActiveStateEnabled(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxRadioGroup.GetOption", identifier, "activeStateEnabled");
        }
        public static new void SetActiveStateEnabled(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxRadioGroup.SetOption", identifier, "activeStateEnabled", value);
        }
        public static new bool? GetFocusStateEnabled(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxRadioGroup.GetOption", identifier, "focusStateEnabled");
        }
        public static new void SetFocusStateEnabled(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxRadioGroup.SetOption", identifier, "focusStateEnabled", value);
        }
        public static new bool? GetHoverStateEnabled(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxRadioGroup.GetOption", identifier, "hoverStateEnabled");
        }
        public static new void SetHoverStateEnabled(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxRadioGroup.SetOption", identifier, "hoverStateEnabled", value);
        }
        public static string GetLayout(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxRadioGroup.GetOption", identifier, "layout");
        }
        public static void SetLayout(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxRadioGroup.SetOption", identifier, "layout", value);
        }
        public static string GetName(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxRadioGroup.GetOption", identifier, "name");
        }
        public static void SetName(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxRadioGroup.SetOption", identifier, "name", value);
        }
        public static new object GetValue(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxRadioGroup.GetOption", identifier, "value");
        }
        public static new void SetValue(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxRadioGroup.SetOption", identifier, "value", value);
        }
        public static object GetDataSourceEx(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxRadioGroup.getDataSource_0", identifier);
        }
    }
    public class DxRangeSliderInterop : DxSliderBaseInterop
    {
        public static event EventHandler<JQueryEventArgs> ValueChanged;
        public static void Init(string identifier, DevExpress.Ui.DxRangeSliderOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxRangeSlider.Init", identifier, json);
        }
        public static void OnValueChanged(string identifier)
        {
            ValueChanged?.Invoke(null, new JQueryEventArgs(identifier));
        }
        public static float? GetEnd(string identifier)
        {
            return RegisteredFunction.Invoke<float?>("BlazorDevExtreme.DxRangeSlider.GetOption", identifier, "end");
        }
        public static void SetEnd(string identifier, float? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxRangeSlider.SetOption", identifier, "end", value);
        }
        public static string GetEndName(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxRangeSlider.GetOption", identifier, "endName");
        }
        public static void SetEndName(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxRangeSlider.SetOption", identifier, "endName", value);
        }
        public static float? GetStart(string identifier)
        {
            return RegisteredFunction.Invoke<float?>("BlazorDevExtreme.DxRangeSlider.GetOption", identifier, "start");
        }
        public static void SetStart(string identifier, float? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxRangeSlider.SetOption", identifier, "start", value);
        }
        public static string GetStartName(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxRangeSlider.GetOption", identifier, "startName");
        }
        public static void SetStartName(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxRangeSlider.SetOption", identifier, "startName", value);
        }
        public static new object GetValue(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxRangeSlider.GetOption", identifier, "value");
        }
        public static new void SetValue(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxRangeSlider.SetOption", identifier, "value", value);
        }
        public static void Reset(string identifier)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxRangeSlider.reset_0", identifier);
        }
    }
    public class DxResizableInterop : DOMComponentInterop
    {
        public static event EventHandler<JQueryEventArgs> Resize;
        public static event EventHandler<JQueryEventArgs> ResizeEnd;
        public static event EventHandler<JQueryEventArgs> ResizeStart;
        public static void Init(string identifier, DevExpress.Ui.DxResizableOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxResizable.Init", identifier, json);
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
        public static string GetHandles(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxResizable.GetOption", identifier, "handles");
        }
        public static void SetHandles(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxResizable.SetOption", identifier, "handles", value);
        }
        public static new object GetHeight(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxResizable.GetOption", identifier, "height");
        }
        public static new void SetHeight(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxResizable.SetOption", identifier, "height", value);
        }
        public static float? GetMaxHeight(string identifier)
        {
            return RegisteredFunction.Invoke<float?>("BlazorDevExtreme.DxResizable.GetOption", identifier, "maxHeight");
        }
        public static void SetMaxHeight(string identifier, float? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxResizable.SetOption", identifier, "maxHeight", value);
        }
        public static float? GetMaxWidth(string identifier)
        {
            return RegisteredFunction.Invoke<float?>("BlazorDevExtreme.DxResizable.GetOption", identifier, "maxWidth");
        }
        public static void SetMaxWidth(string identifier, float? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxResizable.SetOption", identifier, "maxWidth", value);
        }
        public static float? GetMinHeight(string identifier)
        {
            return RegisteredFunction.Invoke<float?>("BlazorDevExtreme.DxResizable.GetOption", identifier, "minHeight");
        }
        public static void SetMinHeight(string identifier, float? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxResizable.SetOption", identifier, "minHeight", value);
        }
        public static float? GetMinWidth(string identifier)
        {
            return RegisteredFunction.Invoke<float?>("BlazorDevExtreme.DxResizable.GetOption", identifier, "minWidth");
        }
        public static void SetMinWidth(string identifier, float? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxResizable.SetOption", identifier, "minWidth", value);
        }
        public static new object GetWidth(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxResizable.GetOption", identifier, "width");
        }
        public static new void SetWidth(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxResizable.SetOption", identifier, "width", value);
        }
    }
    public class DxResponsiveBoxInterop : CollectionWidgetInterop
    {
        public static void Init(string identifier, DevExpress.Ui.DxResponsiveBoxOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxResponsiveBox.Init", identifier, json);
        }
        public static object GetCols(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxResponsiveBox.GetOption", identifier, "cols");
        }
        public static void SetCols(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxResponsiveBox.SetOption", identifier, "cols", value);
        }
        public static new object GetHeight(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxResponsiveBox.GetOption", identifier, "height");
        }
        public static new void SetHeight(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxResponsiveBox.SetOption", identifier, "height", value);
        }
        public static object GetRows(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxResponsiveBox.GetOption", identifier, "rows");
        }
        public static void SetRows(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxResponsiveBox.SetOption", identifier, "rows", value);
        }
        public static object GetScreenByWidth(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxResponsiveBox.GetOption", identifier, "screenByWidth");
        }
        public static void SetScreenByWidth(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxResponsiveBox.SetOption", identifier, "screenByWidth", value);
        }
        public static string GetSingleColumnScreen(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxResponsiveBox.GetOption", identifier, "singleColumnScreen");
        }
        public static void SetSingleColumnScreen(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxResponsiveBox.SetOption", identifier, "singleColumnScreen", value);
        }
        public static new object GetWidth(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxResponsiveBox.GetOption", identifier, "width");
        }
        public static new void SetWidth(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxResponsiveBox.SetOption", identifier, "width", value);
        }
    }
    public class DxSchedulerInterop : WidgetInterop
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
        public static void Init(string identifier, DevExpress.Ui.DxSchedulerOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxScheduler.Init", identifier, json);
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
        public static string GetAllDayExpr(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxScheduler.GetOption", identifier, "allDayExpr");
        }
        public static void SetAllDayExpr(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxScheduler.SetOption", identifier, "allDayExpr", value);
        }
        public static object GetAppointmentTemplate(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxScheduler.GetOption", identifier, "appointmentTemplate");
        }
        public static void SetAppointmentTemplate(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxScheduler.SetOption", identifier, "appointmentTemplate", value);
        }
        public static object GetAppointmentTooltipTemplate(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxScheduler.GetOption", identifier, "appointmentTooltipTemplate");
        }
        public static void SetAppointmentTooltipTemplate(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxScheduler.SetOption", identifier, "appointmentTooltipTemplate", value);
        }
        public static float? GetCellDuration(string identifier)
        {
            return RegisteredFunction.Invoke<float?>("BlazorDevExtreme.DxScheduler.GetOption", identifier, "cellDuration");
        }
        public static void SetCellDuration(string identifier, float? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxScheduler.SetOption", identifier, "cellDuration", value);
        }
        public static bool? GetCrossScrollingEnabled(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxScheduler.GetOption", identifier, "crossScrollingEnabled");
        }
        public static void SetCrossScrollingEnabled(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxScheduler.SetOption", identifier, "crossScrollingEnabled", value);
        }
        public static object GetCurrentDate(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxScheduler.GetOption", identifier, "currentDate");
        }
        public static void SetCurrentDate(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxScheduler.SetOption", identifier, "currentDate", value);
        }
        public static string GetCurrentView(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxScheduler.GetOption", identifier, "currentView");
        }
        public static void SetCurrentView(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxScheduler.SetOption", identifier, "currentView", value);
        }
        public static object GetDataCellTemplate(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxScheduler.GetOption", identifier, "dataCellTemplate");
        }
        public static void SetDataCellTemplate(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxScheduler.SetOption", identifier, "dataCellTemplate", value);
        }
        public static object GetDataSource(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxScheduler.GetOption", identifier, "dataSource");
        }
        public static void SetDataSource(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxScheduler.SetOption", identifier, "dataSource", value);
        }
        public static object GetDateCellTemplate(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxScheduler.GetOption", identifier, "dateCellTemplate");
        }
        public static void SetDateCellTemplate(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxScheduler.SetOption", identifier, "dateCellTemplate", value);
        }
        public static string GetDateSerializationFormat(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxScheduler.GetOption", identifier, "dateSerializationFormat");
        }
        public static void SetDateSerializationFormat(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxScheduler.SetOption", identifier, "dateSerializationFormat", value);
        }
        public static string GetDescriptionExpr(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxScheduler.GetOption", identifier, "descriptionExpr");
        }
        public static void SetDescriptionExpr(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxScheduler.SetOption", identifier, "descriptionExpr", value);
        }
        public static object GetDropDownAppointmentTemplate(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxScheduler.GetOption", identifier, "dropDownAppointmentTemplate");
        }
        public static void SetDropDownAppointmentTemplate(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxScheduler.SetOption", identifier, "dropDownAppointmentTemplate", value);
        }
        public static object GetEditing(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxScheduler.GetOption", identifier, "editing");
        }
        public static void SetEditing(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxScheduler.SetOption", identifier, "editing", value);
        }
        public static string GetEndDateExpr(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxScheduler.GetOption", identifier, "endDateExpr");
        }
        public static void SetEndDateExpr(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxScheduler.SetOption", identifier, "endDateExpr", value);
        }
        public static string GetEndDateTimeZoneExpr(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxScheduler.GetOption", identifier, "endDateTimeZoneExpr");
        }
        public static void SetEndDateTimeZoneExpr(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxScheduler.SetOption", identifier, "endDateTimeZoneExpr", value);
        }
        public static float? GetEndDayHour(string identifier)
        {
            return RegisteredFunction.Invoke<float?>("BlazorDevExtreme.DxScheduler.GetOption", identifier, "endDayHour");
        }
        public static void SetEndDayHour(string identifier, float? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxScheduler.SetOption", identifier, "endDayHour", value);
        }
        public static object GetFirstDayOfWeek(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxScheduler.GetOption", identifier, "firstDayOfWeek");
        }
        public static void SetFirstDayOfWeek(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxScheduler.SetOption", identifier, "firstDayOfWeek", value);
        }
        public static new bool? GetFocusStateEnabled(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxScheduler.GetOption", identifier, "focusStateEnabled");
        }
        public static new void SetFocusStateEnabled(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxScheduler.SetOption", identifier, "focusStateEnabled", value);
        }
        public static object GetGroups(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxScheduler.GetOption", identifier, "groups");
        }
        public static void SetGroups(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxScheduler.SetOption", identifier, "groups", value);
        }
        public static float? GetIndicatorUpdateInterval(string identifier)
        {
            return RegisteredFunction.Invoke<float?>("BlazorDevExtreme.DxScheduler.GetOption", identifier, "indicatorUpdateInterval");
        }
        public static void SetIndicatorUpdateInterval(string identifier, float? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxScheduler.SetOption", identifier, "indicatorUpdateInterval", value);
        }
        public static object GetMax(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxScheduler.GetOption", identifier, "max");
        }
        public static void SetMax(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxScheduler.SetOption", identifier, "max", value);
        }
        public static object GetMaxAppointmentsPerCell(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxScheduler.GetOption", identifier, "maxAppointmentsPerCell");
        }
        public static void SetMaxAppointmentsPerCell(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxScheduler.SetOption", identifier, "maxAppointmentsPerCell", value);
        }
        public static object GetMin(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxScheduler.GetOption", identifier, "min");
        }
        public static void SetMin(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxScheduler.SetOption", identifier, "min", value);
        }
        public static string GetNoDataText(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxScheduler.GetOption", identifier, "noDataText");
        }
        public static void SetNoDataText(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxScheduler.SetOption", identifier, "noDataText", value);
        }
        public static string GetRecurrenceEditMode(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxScheduler.GetOption", identifier, "recurrenceEditMode");
        }
        public static void SetRecurrenceEditMode(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxScheduler.SetOption", identifier, "recurrenceEditMode", value);
        }
        public static string GetRecurrenceExceptionExpr(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxScheduler.GetOption", identifier, "recurrenceExceptionExpr");
        }
        public static void SetRecurrenceExceptionExpr(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxScheduler.SetOption", identifier, "recurrenceExceptionExpr", value);
        }
        public static string GetRecurrenceRuleExpr(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxScheduler.GetOption", identifier, "recurrenceRuleExpr");
        }
        public static void SetRecurrenceRuleExpr(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxScheduler.SetOption", identifier, "recurrenceRuleExpr", value);
        }
        public static bool? GetRemoteFiltering(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxScheduler.GetOption", identifier, "remoteFiltering");
        }
        public static void SetRemoteFiltering(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxScheduler.SetOption", identifier, "remoteFiltering", value);
        }
        public static object GetResourceCellTemplate(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxScheduler.GetOption", identifier, "resourceCellTemplate");
        }
        public static void SetResourceCellTemplate(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxScheduler.SetOption", identifier, "resourceCellTemplate", value);
        }
        public static object GetResources(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxScheduler.GetOption", identifier, "resources");
        }
        public static void SetResources(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxScheduler.SetOption", identifier, "resources", value);
        }
        public static object GetSelectedCellData(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxScheduler.GetOption", identifier, "selectedCellData");
        }
        public static void SetSelectedCellData(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxScheduler.SetOption", identifier, "selectedCellData", value);
        }
        public static bool? GetShadeUntilCurrentTime(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxScheduler.GetOption", identifier, "shadeUntilCurrentTime");
        }
        public static void SetShadeUntilCurrentTime(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxScheduler.SetOption", identifier, "shadeUntilCurrentTime", value);
        }
        public static bool? GetShowAllDayPanel(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxScheduler.GetOption", identifier, "showAllDayPanel");
        }
        public static void SetShowAllDayPanel(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxScheduler.SetOption", identifier, "showAllDayPanel", value);
        }
        public static bool? GetShowCurrentTimeIndicator(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxScheduler.GetOption", identifier, "showCurrentTimeIndicator");
        }
        public static void SetShowCurrentTimeIndicator(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxScheduler.SetOption", identifier, "showCurrentTimeIndicator", value);
        }
        public static string GetStartDateExpr(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxScheduler.GetOption", identifier, "startDateExpr");
        }
        public static void SetStartDateExpr(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxScheduler.SetOption", identifier, "startDateExpr", value);
        }
        public static string GetStartDateTimeZoneExpr(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxScheduler.GetOption", identifier, "startDateTimeZoneExpr");
        }
        public static void SetStartDateTimeZoneExpr(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxScheduler.SetOption", identifier, "startDateTimeZoneExpr", value);
        }
        public static float? GetStartDayHour(string identifier)
        {
            return RegisteredFunction.Invoke<float?>("BlazorDevExtreme.DxScheduler.GetOption", identifier, "startDayHour");
        }
        public static void SetStartDayHour(string identifier, float? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxScheduler.SetOption", identifier, "startDayHour", value);
        }
        public static string GetTextExpr(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxScheduler.GetOption", identifier, "textExpr");
        }
        public static void SetTextExpr(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxScheduler.SetOption", identifier, "textExpr", value);
        }
        public static object GetTimeCellTemplate(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxScheduler.GetOption", identifier, "timeCellTemplate");
        }
        public static void SetTimeCellTemplate(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxScheduler.SetOption", identifier, "timeCellTemplate", value);
        }
        public static string GetTimeZone(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxScheduler.GetOption", identifier, "timeZone");
        }
        public static void SetTimeZone(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxScheduler.SetOption", identifier, "timeZone", value);
        }
        public static bool? GetUseDropDownViewSwitcher(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxScheduler.GetOption", identifier, "useDropDownViewSwitcher");
        }
        public static void SetUseDropDownViewSwitcher(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxScheduler.SetOption", identifier, "useDropDownViewSwitcher", value);
        }
        public static object GetViews(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxScheduler.GetOption", identifier, "views");
        }
        public static void SetViews(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxScheduler.SetOption", identifier, "views", value);
        }
        public static void AddAppointment(string identifier, object appointment)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxScheduler.addAppointment_0", identifier, appointment);
        }
        public static void DeleteAppointment(string identifier, object appointment)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxScheduler.deleteAppointment_1", identifier, appointment);
        }
        public static object GetDataSourceEx(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxScheduler.getDataSource_2", identifier);
        }
        public static object GetEndViewDate(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxScheduler.getEndViewDate_3", identifier);
        }
        public static object GetStartViewDate(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxScheduler.getStartViewDate_4", identifier);
        }
        public static void HideAppointmentPopup(string identifier, bool saveChanges)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxScheduler.hideAppointmentPopup_5", identifier, saveChanges);
        }
        public static void HideAppointmentTooltip(string identifier)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxScheduler.hideAppointmentTooltip_6", identifier);
        }
        public static void RegisterKeyHandler(string identifier)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxScheduler.registerKeyHandler_7", identifier);
        }
        public static void ScrollToTime(string identifier, float hours, float minutes, object date)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxScheduler.scrollToTime_8", identifier, hours, minutes, date);
        }
        public static void ShowAppointmentPopup(string identifier, object appointmentData, bool createNewAppointment, object currentAppointmentData)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxScheduler.showAppointmentPopup_9", identifier, appointmentData, createNewAppointment, currentAppointmentData);
        }
        public static void ShowAppointmentTooltip(string identifier, object appointmentData, object target, object currentAppointmentData)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxScheduler.showAppointmentTooltip_10", identifier, appointmentData, target, currentAppointmentData);
        }
        public static void UpdateAppointment(string identifier, object target, object appointment)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxScheduler.updateAppointment_11", identifier, target, appointment);
        }
    }
    public class DxScrollViewInterop : DxScrollableInterop
    {
        public static event EventHandler<JQueryEventArgs> PullDown;
        public static event EventHandler<JQueryEventArgs> ReachBottom;
        public static void Init(string identifier, DevExpress.Ui.DxScrollViewOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxScrollView.Init", identifier, json);
        }
        public static void OnPullDown(string identifier)
        {
            PullDown?.Invoke(null, new JQueryEventArgs(identifier));
        }
        public static void OnReachBottom(string identifier)
        {
            ReachBottom?.Invoke(null, new JQueryEventArgs(identifier));
        }
        public static string GetPulledDownText(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxScrollView.GetOption", identifier, "pulledDownText");
        }
        public static void SetPulledDownText(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxScrollView.SetOption", identifier, "pulledDownText", value);
        }
        public static string GetPullingDownText(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxScrollView.GetOption", identifier, "pullingDownText");
        }
        public static void SetPullingDownText(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxScrollView.SetOption", identifier, "pullingDownText", value);
        }
        public static string GetReachBottomText(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxScrollView.GetOption", identifier, "reachBottomText");
        }
        public static void SetReachBottomText(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxScrollView.SetOption", identifier, "reachBottomText", value);
        }
        public static string GetRefreshingText(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxScrollView.GetOption", identifier, "refreshingText");
        }
        public static void SetRefreshingText(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxScrollView.SetOption", identifier, "refreshingText", value);
        }
        public static void Refresh(string identifier)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxScrollView.refresh_0", identifier);
        }
        public static object Release(string identifier, bool preventScrollBottom)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxScrollView.release_1", identifier, preventScrollBottom);
        }
    }
    public class DxSelectBoxInterop : DxDropDownListInterop
    {
        public static event EventHandler<JQueryEventArgs> CustomItemCreating;
        public static void Init(string identifier, DevExpress.Ui.DxSelectBoxOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxSelectBox.Init", identifier, json);
        }
        public static void OnCustomItemCreating(string identifier)
        {
            CustomItemCreating?.Invoke(null, new JQueryEventArgs(identifier));
        }
        public static new bool? GetAcceptCustomValue(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxSelectBox.GetOption", identifier, "acceptCustomValue");
        }
        public static new void SetAcceptCustomValue(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxSelectBox.SetOption", identifier, "acceptCustomValue", value);
        }
        public static object GetFieldTemplate(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxSelectBox.GetOption", identifier, "fieldTemplate");
        }
        public static void SetFieldTemplate(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxSelectBox.SetOption", identifier, "fieldTemplate", value);
        }
        public static new string GetPlaceholder(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxSelectBox.GetOption", identifier, "placeholder");
        }
        public static new void SetPlaceholder(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxSelectBox.SetOption", identifier, "placeholder", value);
        }
        public static bool? GetShowSelectionControls(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxSelectBox.GetOption", identifier, "showSelectionControls");
        }
        public static void SetShowSelectionControls(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxSelectBox.SetOption", identifier, "showSelectionControls", value);
        }
        public static new string GetValueChangeEvent(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxSelectBox.GetOption", identifier, "valueChangeEvent");
        }
        public static new void SetValueChangeEvent(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxSelectBox.SetOption", identifier, "valueChangeEvent", value);
        }
    }
    public class DxSliderInterop : DxSliderBaseInterop
    {
        public static void Init(string identifier, DevExpress.Ui.DxSliderOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxSlider.Init", identifier, json);
        }
        public static new float? GetValue(string identifier)
        {
            return RegisteredFunction.Invoke<float?>("BlazorDevExtreme.DxSlider.GetOption", identifier, "value");
        }
        public static new void SetValue(string identifier, float? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxSlider.SetOption", identifier, "value", value);
        }
    }
    public class DxSlideOutInterop : CollectionWidgetInterop
    {
        public static event EventHandler<JQueryEventArgs> MenuGroupRendered;
        public static event EventHandler<JQueryEventArgs> MenuItemRendered;
        public static void Init(string identifier, DevExpress.Ui.DxSlideOutOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxSlideOut.Init", identifier, json);
        }
        public static void OnMenuGroupRendered(string identifier)
        {
            MenuGroupRendered?.Invoke(null, new JQueryEventArgs(identifier));
        }
        public static void OnMenuItemRendered(string identifier)
        {
            MenuItemRendered?.Invoke(null, new JQueryEventArgs(identifier));
        }
        public static new bool? GetActiveStateEnabled(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxSlideOut.GetOption", identifier, "activeStateEnabled");
        }
        public static new void SetActiveStateEnabled(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxSlideOut.SetOption", identifier, "activeStateEnabled", value);
        }
        public static object GetContentTemplate(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxSlideOut.GetOption", identifier, "contentTemplate");
        }
        public static void SetContentTemplate(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxSlideOut.SetOption", identifier, "contentTemplate", value);
        }
        public static bool? GetMenuGrouped(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxSlideOut.GetOption", identifier, "menuGrouped");
        }
        public static void SetMenuGrouped(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxSlideOut.SetOption", identifier, "menuGrouped", value);
        }
        public static object GetMenuGroupTemplate(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxSlideOut.GetOption", identifier, "menuGroupTemplate");
        }
        public static void SetMenuGroupTemplate(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxSlideOut.SetOption", identifier, "menuGroupTemplate", value);
        }
        public static object GetMenuItemTemplate(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxSlideOut.GetOption", identifier, "menuItemTemplate");
        }
        public static void SetMenuItemTemplate(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxSlideOut.SetOption", identifier, "menuItemTemplate", value);
        }
        public static string GetMenuPosition(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxSlideOut.GetOption", identifier, "menuPosition");
        }
        public static void SetMenuPosition(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxSlideOut.SetOption", identifier, "menuPosition", value);
        }
        public static bool? GetMenuVisible(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxSlideOut.GetOption", identifier, "menuVisible");
        }
        public static void SetMenuVisible(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxSlideOut.SetOption", identifier, "menuVisible", value);
        }
        public static new float? GetSelectedIndex(string identifier)
        {
            return RegisteredFunction.Invoke<float?>("BlazorDevExtreme.DxSlideOut.GetOption", identifier, "selectedIndex");
        }
        public static new void SetSelectedIndex(string identifier, float? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxSlideOut.SetOption", identifier, "selectedIndex", value);
        }
        public static bool? GetSwipeEnabled(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxSlideOut.GetOption", identifier, "swipeEnabled");
        }
        public static void SetSwipeEnabled(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxSlideOut.SetOption", identifier, "swipeEnabled", value);
        }
        public static object HideMenu(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxSlideOut.hideMenu_0", identifier);
        }
        public static object ShowMenu(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxSlideOut.showMenu_1", identifier);
        }
        public static object ToggleMenuVisibility(string identifier, bool showing)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxSlideOut.toggleMenuVisibility_2", identifier, showing);
        }
    }
    public class DxSlideOutViewInterop : WidgetInterop
    {
        public static void Init(string identifier, DevExpress.Ui.DxSlideOutViewOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxSlideOutView.Init", identifier, json);
        }
        public static object GetContentTemplate(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxSlideOutView.GetOption", identifier, "contentTemplate");
        }
        public static void SetContentTemplate(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxSlideOutView.SetOption", identifier, "contentTemplate", value);
        }
        public static string GetMenuPosition(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxSlideOutView.GetOption", identifier, "menuPosition");
        }
        public static void SetMenuPosition(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxSlideOutView.SetOption", identifier, "menuPosition", value);
        }
        public static object GetMenuTemplate(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxSlideOutView.GetOption", identifier, "menuTemplate");
        }
        public static void SetMenuTemplate(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxSlideOutView.SetOption", identifier, "menuTemplate", value);
        }
        public static bool? GetMenuVisible(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxSlideOutView.GetOption", identifier, "menuVisible");
        }
        public static void SetMenuVisible(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxSlideOutView.SetOption", identifier, "menuVisible", value);
        }
        public static bool? GetSwipeEnabled(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxSlideOutView.GetOption", identifier, "swipeEnabled");
        }
        public static void SetSwipeEnabled(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxSlideOutView.SetOption", identifier, "swipeEnabled", value);
        }
        public static object Content(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxSlideOutView.content_0", identifier);
        }
        public static object HideMenu(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxSlideOutView.hideMenu_1", identifier);
        }
        public static object MenuContent(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxSlideOutView.menuContent_2", identifier);
        }
        public static object ShowMenu(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxSlideOutView.showMenu_3", identifier);
        }
        public static object ToggleMenuVisibility(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxSlideOutView.toggleMenuVisibility_4", identifier);
        }
    }
    public class DxSwitchInterop : EditorInterop
    {
        public static void Init(string identifier, DevExpress.Ui.DxSwitchOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxSwitch.Init", identifier, json);
        }
        public static new bool? GetActiveStateEnabled(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxSwitch.GetOption", identifier, "activeStateEnabled");
        }
        public static new void SetActiveStateEnabled(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxSwitch.SetOption", identifier, "activeStateEnabled", value);
        }
        public static new bool? GetFocusStateEnabled(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxSwitch.GetOption", identifier, "focusStateEnabled");
        }
        public static new void SetFocusStateEnabled(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxSwitch.SetOption", identifier, "focusStateEnabled", value);
        }
        public static new bool? GetHoverStateEnabled(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxSwitch.GetOption", identifier, "hoverStateEnabled");
        }
        public static new void SetHoverStateEnabled(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxSwitch.SetOption", identifier, "hoverStateEnabled", value);
        }
        public static string GetName(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxSwitch.GetOption", identifier, "name");
        }
        public static void SetName(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxSwitch.SetOption", identifier, "name", value);
        }
        public static string GetOffText(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxSwitch.GetOption", identifier, "offText");
        }
        public static void SetOffText(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxSwitch.SetOption", identifier, "offText", value);
        }
        public static string GetOnText(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxSwitch.GetOption", identifier, "onText");
        }
        public static void SetOnText(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxSwitch.SetOption", identifier, "onText", value);
        }
        public static new bool? GetValue(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxSwitch.GetOption", identifier, "value");
        }
        public static new void SetValue(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxSwitch.SetOption", identifier, "value", value);
        }
    }
    public class DxTabsInterop : CollectionWidgetInterop
    {
        public static void Init(string identifier, DevExpress.Ui.DxTabsOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTabs.Init", identifier, json);
        }
        public static new bool? GetFocusStateEnabled(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxTabs.GetOption", identifier, "focusStateEnabled");
        }
        public static new void SetFocusStateEnabled(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTabs.SetOption", identifier, "focusStateEnabled", value);
        }
        public static new bool? GetHoverStateEnabled(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxTabs.GetOption", identifier, "hoverStateEnabled");
        }
        public static new void SetHoverStateEnabled(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTabs.SetOption", identifier, "hoverStateEnabled", value);
        }
        public static bool? GetScrollByContent(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxTabs.GetOption", identifier, "scrollByContent");
        }
        public static void SetScrollByContent(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTabs.SetOption", identifier, "scrollByContent", value);
        }
        public static bool? GetScrollingEnabled(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxTabs.GetOption", identifier, "scrollingEnabled");
        }
        public static void SetScrollingEnabled(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTabs.SetOption", identifier, "scrollingEnabled", value);
        }
        public static new object GetSelectedItems(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTabs.GetOption", identifier, "selectedItems");
        }
        public static new void SetSelectedItems(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTabs.SetOption", identifier, "selectedItems", value);
        }
        public static string GetSelectionMode(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxTabs.GetOption", identifier, "selectionMode");
        }
        public static void SetSelectionMode(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTabs.SetOption", identifier, "selectionMode", value);
        }
        public static bool? GetShowNavButtons(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxTabs.GetOption", identifier, "showNavButtons");
        }
        public static void SetShowNavButtons(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTabs.SetOption", identifier, "showNavButtons", value);
        }
    }
    public class DxTabPanelInterop : DxMultiViewInterop
    {
        public static event EventHandler<JQueryEventArgs> TitleClick;
        public static event EventHandler<JQueryEventArgs> TitleHold;
        public static event EventHandler<JQueryEventArgs> TitleRendered;
        public static void Init(string identifier, DevExpress.Ui.DxTabPanelOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTabPanel.Init", identifier, json);
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
        public static new bool? GetAnimationEnabled(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxTabPanel.GetOption", identifier, "animationEnabled");
        }
        public static new void SetAnimationEnabled(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTabPanel.SetOption", identifier, "animationEnabled", value);
        }
        public static new bool? GetFocusStateEnabled(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxTabPanel.GetOption", identifier, "focusStateEnabled");
        }
        public static new void SetFocusStateEnabled(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTabPanel.SetOption", identifier, "focusStateEnabled", value);
        }
        public static new bool? GetHoverStateEnabled(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxTabPanel.GetOption", identifier, "hoverStateEnabled");
        }
        public static new void SetHoverStateEnabled(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTabPanel.SetOption", identifier, "hoverStateEnabled", value);
        }
        public static object GetItemTitleTemplate(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTabPanel.GetOption", identifier, "itemTitleTemplate");
        }
        public static void SetItemTitleTemplate(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTabPanel.SetOption", identifier, "itemTitleTemplate", value);
        }
        public static bool? GetScrollByContent(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxTabPanel.GetOption", identifier, "scrollByContent");
        }
        public static void SetScrollByContent(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTabPanel.SetOption", identifier, "scrollByContent", value);
        }
        public static bool? GetScrollingEnabled(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxTabPanel.GetOption", identifier, "scrollingEnabled");
        }
        public static void SetScrollingEnabled(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTabPanel.SetOption", identifier, "scrollingEnabled", value);
        }
        public static bool? GetShowNavButtons(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxTabPanel.GetOption", identifier, "showNavButtons");
        }
        public static void SetShowNavButtons(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTabPanel.SetOption", identifier, "showNavButtons", value);
        }
        public static new bool? GetSwipeEnabled(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxTabPanel.GetOption", identifier, "swipeEnabled");
        }
        public static new void SetSwipeEnabled(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTabPanel.SetOption", identifier, "swipeEnabled", value);
        }
    }
    public class DxTagBoxInterop : DxSelectBoxInterop
    {
        public static event EventHandler<JQueryEventArgs> MultiTagPreparing;
        public static event EventHandler<JQueryEventArgs> SelectAllValueChanged;
        public static event EventHandler<JQueryEventArgs> SelectionChanged;
        public static void Init(string identifier, DevExpress.Ui.DxTagBoxOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTagBox.Init", identifier, json);
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
        public static new string GetApplyValueMode(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxTagBox.GetOption", identifier, "applyValueMode");
        }
        public static new void SetApplyValueMode(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTagBox.SetOption", identifier, "applyValueMode", value);
        }
        public static bool? GetHideSelectedItems(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxTagBox.GetOption", identifier, "hideSelectedItems");
        }
        public static void SetHideSelectedItems(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTagBox.SetOption", identifier, "hideSelectedItems", value);
        }
        public static float? GetMaxDisplayedTags(string identifier)
        {
            return RegisteredFunction.Invoke<float?>("BlazorDevExtreme.DxTagBox.GetOption", identifier, "maxDisplayedTags");
        }
        public static void SetMaxDisplayedTags(string identifier, float? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTagBox.SetOption", identifier, "maxDisplayedTags", value);
        }
        public static bool? GetMultiline(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxTagBox.GetOption", identifier, "multiline");
        }
        public static void SetMultiline(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTagBox.SetOption", identifier, "multiline", value);
        }
        public static string GetSelectAllMode(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxTagBox.GetOption", identifier, "selectAllMode");
        }
        public static void SetSelectAllMode(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTagBox.SetOption", identifier, "selectAllMode", value);
        }
        public static object GetSelectedItems(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTagBox.GetOption", identifier, "selectedItems");
        }
        public static void SetSelectedItems(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTagBox.SetOption", identifier, "selectedItems", value);
        }
        public static bool? GetShowMultiTagOnly(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxTagBox.GetOption", identifier, "showMultiTagOnly");
        }
        public static void SetShowMultiTagOnly(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTagBox.SetOption", identifier, "showMultiTagOnly", value);
        }
        public static object GetTagTemplate(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTagBox.GetOption", identifier, "tagTemplate");
        }
        public static void SetTagTemplate(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTagBox.SetOption", identifier, "tagTemplate", value);
        }
        public static new object GetValue(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTagBox.GetOption", identifier, "value");
        }
        public static new void SetValue(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTagBox.SetOption", identifier, "value", value);
        }
    }
    public class DxTextAreaInterop : DxTextBoxInterop
    {
        public static void Init(string identifier, DevExpress.Ui.DxTextAreaOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTextArea.Init", identifier, json);
        }
        public static bool? GetAutoResizeEnabled(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxTextArea.GetOption", identifier, "autoResizeEnabled");
        }
        public static void SetAutoResizeEnabled(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTextArea.SetOption", identifier, "autoResizeEnabled", value);
        }
        public static object GetMaxHeight(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTextArea.GetOption", identifier, "maxHeight");
        }
        public static void SetMaxHeight(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTextArea.SetOption", identifier, "maxHeight", value);
        }
        public static object GetMinHeight(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTextArea.GetOption", identifier, "minHeight");
        }
        public static void SetMinHeight(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTextArea.SetOption", identifier, "minHeight", value);
        }
        public static new bool? GetSpellcheck(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxTextArea.GetOption", identifier, "spellcheck");
        }
        public static new void SetSpellcheck(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTextArea.SetOption", identifier, "spellcheck", value);
        }
    }
    public class DxTextBoxInterop : DxTextEditorInterop
    {
        public static void Init(string identifier, DevExpress.Ui.DxTextBoxOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTextBox.Init", identifier, json);
        }
        public static object GetMaxLength(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTextBox.GetOption", identifier, "maxLength");
        }
        public static void SetMaxLength(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTextBox.SetOption", identifier, "maxLength", value);
        }
        public static string GetMode(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxTextBox.GetOption", identifier, "mode");
        }
        public static void SetMode(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTextBox.SetOption", identifier, "mode", value);
        }
        public static new string GetValue(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxTextBox.GetOption", identifier, "value");
        }
        public static new void SetValue(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTextBox.SetOption", identifier, "value", value);
        }
    }
    public class DxTileViewInterop : CollectionWidgetInterop
    {
        public static void Init(string identifier, DevExpress.Ui.DxTileViewOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTileView.Init", identifier, json);
        }
        public static new bool? GetActiveStateEnabled(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxTileView.GetOption", identifier, "activeStateEnabled");
        }
        public static new void SetActiveStateEnabled(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTileView.SetOption", identifier, "activeStateEnabled", value);
        }
        public static float? GetBaseItemHeight(string identifier)
        {
            return RegisteredFunction.Invoke<float?>("BlazorDevExtreme.DxTileView.GetOption", identifier, "baseItemHeight");
        }
        public static void SetBaseItemHeight(string identifier, float? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTileView.SetOption", identifier, "baseItemHeight", value);
        }
        public static float? GetBaseItemWidth(string identifier)
        {
            return RegisteredFunction.Invoke<float?>("BlazorDevExtreme.DxTileView.GetOption", identifier, "baseItemWidth");
        }
        public static void SetBaseItemWidth(string identifier, float? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTileView.SetOption", identifier, "baseItemWidth", value);
        }
        public static string GetDirection(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxTileView.GetOption", identifier, "direction");
        }
        public static void SetDirection(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTileView.SetOption", identifier, "direction", value);
        }
        public static new bool? GetFocusStateEnabled(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxTileView.GetOption", identifier, "focusStateEnabled");
        }
        public static new void SetFocusStateEnabled(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTileView.SetOption", identifier, "focusStateEnabled", value);
        }
        public static new object GetHeight(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTileView.GetOption", identifier, "height");
        }
        public static new void SetHeight(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTileView.SetOption", identifier, "height", value);
        }
        public static new bool? GetHoverStateEnabled(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxTileView.GetOption", identifier, "hoverStateEnabled");
        }
        public static new void SetHoverStateEnabled(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTileView.SetOption", identifier, "hoverStateEnabled", value);
        }
        public static float? GetItemMargin(string identifier)
        {
            return RegisteredFunction.Invoke<float?>("BlazorDevExtreme.DxTileView.GetOption", identifier, "itemMargin");
        }
        public static void SetItemMargin(string identifier, float? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTileView.SetOption", identifier, "itemMargin", value);
        }
        public static bool? GetShowScrollbar(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxTileView.GetOption", identifier, "showScrollbar");
        }
        public static void SetShowScrollbar(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTileView.SetOption", identifier, "showScrollbar", value);
        }
        public static float ScrollPosition(string identifier)
        {
            return RegisteredFunction.Invoke<float>("BlazorDevExtreme.DxTileView.scrollPosition_0", identifier);
        }
    }
    public class DxToastInterop : DxOverlayInterop
    {
        public static void Init(string identifier, DevExpress.Ui.DxToastOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxToast.Init", identifier, json);
        }
        public static new object GetAnimation(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxToast.GetOption", identifier, "animation");
        }
        public static new void SetAnimation(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxToast.SetOption", identifier, "animation", value);
        }
        public static new bool? GetCloseOnBackButton(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxToast.GetOption", identifier, "closeOnBackButton");
        }
        public static new void SetCloseOnBackButton(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxToast.SetOption", identifier, "closeOnBackButton", value);
        }
        public static bool? GetCloseOnClick(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxToast.GetOption", identifier, "closeOnClick");
        }
        public static void SetCloseOnClick(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxToast.SetOption", identifier, "closeOnClick", value);
        }
        public static new object GetCloseOnOutsideClick(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxToast.GetOption", identifier, "closeOnOutsideClick");
        }
        public static new void SetCloseOnOutsideClick(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxToast.SetOption", identifier, "closeOnOutsideClick", value);
        }
        public static bool? GetCloseOnSwipe(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxToast.GetOption", identifier, "closeOnSwipe");
        }
        public static void SetCloseOnSwipe(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxToast.SetOption", identifier, "closeOnSwipe", value);
        }
        public static float? GetDisplayTime(string identifier)
        {
            return RegisteredFunction.Invoke<float?>("BlazorDevExtreme.DxToast.GetOption", identifier, "displayTime");
        }
        public static void SetDisplayTime(string identifier, float? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxToast.SetOption", identifier, "displayTime", value);
        }
        public static new object GetHeight(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxToast.GetOption", identifier, "height");
        }
        public static new void SetHeight(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxToast.SetOption", identifier, "height", value);
        }
        public static new object GetMaxWidth(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxToast.GetOption", identifier, "maxWidth");
        }
        public static new void SetMaxWidth(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxToast.SetOption", identifier, "maxWidth", value);
        }
        public static string GetMessage(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxToast.GetOption", identifier, "message");
        }
        public static void SetMessage(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxToast.SetOption", identifier, "message", value);
        }
        public static new object GetMinWidth(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxToast.GetOption", identifier, "minWidth");
        }
        public static new void SetMinWidth(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxToast.SetOption", identifier, "minWidth", value);
        }
        public static new object GetPosition(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxToast.GetOption", identifier, "position");
        }
        public static new void SetPosition(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxToast.SetOption", identifier, "position", value);
        }
        public static new bool? GetShading(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxToast.GetOption", identifier, "shading");
        }
        public static new void SetShading(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxToast.SetOption", identifier, "shading", value);
        }
        public static string GetType(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxToast.GetOption", identifier, "type");
        }
        public static void SetType(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxToast.SetOption", identifier, "type", value);
        }
        public static new object GetWidth(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxToast.GetOption", identifier, "width");
        }
        public static new void SetWidth(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxToast.SetOption", identifier, "width", value);
        }
    }
    public class DxToolbarInterop : CollectionWidgetInterop
    {
        public static void Init(string identifier, DevExpress.Ui.DxToolbarOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxToolbar.Init", identifier, json);
        }
        public static object GetMenuItemTemplate(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxToolbar.GetOption", identifier, "menuItemTemplate");
        }
        public static void SetMenuItemTemplate(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxToolbar.SetOption", identifier, "menuItemTemplate", value);
        }
        public static string GetRenderAs(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxToolbar.GetOption", identifier, "renderAs");
        }
        public static void SetRenderAs(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxToolbar.SetOption", identifier, "renderAs", value);
        }
    }
    public class DxTooltipInterop : DxPopoverInterop
    {
        public static void Init(string identifier, DevExpress.Ui.DxTooltipOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTooltip.Init", identifier, json);
        }
    }
    public class DxTrackBarInterop : EditorInterop
    {
        public static void Init(string identifier, DevExpress.Ui.DxTrackBarOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTrackBar.Init", identifier, json);
        }
        public static float? GetMax(string identifier)
        {
            return RegisteredFunction.Invoke<float?>("BlazorDevExtreme.DxTrackBar.GetOption", identifier, "max");
        }
        public static void SetMax(string identifier, float? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTrackBar.SetOption", identifier, "max", value);
        }
        public static float? GetMin(string identifier)
        {
            return RegisteredFunction.Invoke<float?>("BlazorDevExtreme.DxTrackBar.GetOption", identifier, "min");
        }
        public static void SetMin(string identifier, float? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTrackBar.SetOption", identifier, "min", value);
        }
    }
    public class DxTreeListInterop : GridBaseInterop
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
        public static void Init(string identifier, DevExpress.Ui.DxTreeListOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeList.Init", identifier, json);
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
        public static bool? GetAutoExpandAll(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxTreeList.GetOption", identifier, "autoExpandAll");
        }
        public static void SetAutoExpandAll(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeList.SetOption", identifier, "autoExpandAll", value);
        }
        public static new object GetColumns(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeList.GetOption", identifier, "columns");
        }
        public static new void SetColumns(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeList.SetOption", identifier, "columns", value);
        }
        public static object GetCustomizeColumns(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeList.GetOption", identifier, "customizeColumns");
        }
        public static void SetCustomizeColumns(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeList.SetOption", identifier, "customizeColumns", value);
        }
        public static string GetDataStructure(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxTreeList.GetOption", identifier, "dataStructure");
        }
        public static void SetDataStructure(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeList.SetOption", identifier, "dataStructure", value);
        }
        public static new object GetEditing(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeList.GetOption", identifier, "editing");
        }
        public static new void SetEditing(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeList.SetOption", identifier, "editing", value);
        }
        public static object GetExpandedRowKeys(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeList.GetOption", identifier, "expandedRowKeys");
        }
        public static void SetExpandedRowKeys(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeList.SetOption", identifier, "expandedRowKeys", value);
        }
        public static bool? GetExpandNodesOnFiltering(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxTreeList.GetOption", identifier, "expandNodesOnFiltering");
        }
        public static void SetExpandNodesOnFiltering(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeList.SetOption", identifier, "expandNodesOnFiltering", value);
        }
        public static object GetHasItemsExpr(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeList.GetOption", identifier, "hasItemsExpr");
        }
        public static void SetHasItemsExpr(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeList.SetOption", identifier, "hasItemsExpr", value);
        }
        public static object GetItemsExpr(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeList.GetOption", identifier, "itemsExpr");
        }
        public static void SetItemsExpr(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeList.SetOption", identifier, "itemsExpr", value);
        }
        public static object GetKeyExpr(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeList.GetOption", identifier, "keyExpr");
        }
        public static void SetKeyExpr(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeList.SetOption", identifier, "keyExpr", value);
        }
        public static new object GetPaging(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeList.GetOption", identifier, "paging");
        }
        public static new void SetPaging(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeList.SetOption", identifier, "paging", value);
        }
        public static object GetParentIdExpr(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeList.GetOption", identifier, "parentIdExpr");
        }
        public static void SetParentIdExpr(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeList.SetOption", identifier, "parentIdExpr", value);
        }
        public static object GetRemoteOperations(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeList.GetOption", identifier, "remoteOperations");
        }
        public static void SetRemoteOperations(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeList.SetOption", identifier, "remoteOperations", value);
        }
        public static object GetRootValue(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeList.GetOption", identifier, "rootValue");
        }
        public static void SetRootValue(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeList.SetOption", identifier, "rootValue", value);
        }
        public static new object GetScrolling(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeList.GetOption", identifier, "scrolling");
        }
        public static new void SetScrolling(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeList.SetOption", identifier, "scrolling", value);
        }
        public static new object GetSelection(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeList.GetOption", identifier, "selection");
        }
        public static new void SetSelection(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeList.SetOption", identifier, "selection", value);
        }
        public static void AddColumn(string identifier, object columnOptions)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeList.addColumn_0", identifier, columnOptions);
        }
        public static void AddRow(string identifier)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeList.addRow_1", identifier);
        }
        public static void AddRow(string identifier, object parentId)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeList.addRow_2", identifier, parentId);
        }
        public static object CollapseRow(string identifier, object key)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeList.collapseRow_3", identifier, key);
        }
        public static object ExpandRow(string identifier, object key)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeList.expandRow_4", identifier, key);
        }
        public static void ForEachNode(string identifier, object callback)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeList.forEachNode_5", identifier, callback);
        }
        public static void ForEachNode(string identifier, object nodes, object callback)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeList.forEachNode_6", identifier, nodes, callback);
        }
        public static object GetNodeByKey(string identifier, object key)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeList.getNodeByKey_7", identifier, key);
        }
        public static object GetRootNode(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeList.getRootNode_8", identifier);
        }
        public static object GetSelectedRowKeys(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeList.getSelectedRowKeys_9", identifier);
        }
        public static object GetSelectedRowKeys(string identifier, bool leavesOnly)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeList.getSelectedRowKeys_10", identifier, leavesOnly);
        }
        public static object GetSelectedRowKeys(string identifier, string mode)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeList.getSelectedRowKeys_11", identifier, mode);
        }
        public static object GetSelectedRowsData(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeList.getSelectedRowsData_12", identifier);
        }
        public static object GetVisibleColumns(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeList.getVisibleColumns_13", identifier);
        }
        public static object GetVisibleColumns(string identifier, float headerLevel)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeList.getVisibleColumns_14", identifier, headerLevel);
        }
        public static object GetVisibleRows(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeList.getVisibleRows_15", identifier);
        }
        public static bool IsRowExpanded(string identifier, object key)
        {
            return RegisteredFunction.Invoke<bool>("BlazorDevExtreme.DxTreeList.isRowExpanded_16", identifier, key);
        }
        public static object LoadDescendants(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeList.loadDescendants_17", identifier);
        }
        public static object LoadDescendants(string identifier, object keys)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeList.loadDescendants_18", identifier, keys);
        }
        public static object LoadDescendants(string identifier, object keys, bool childrenOnly)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeList.loadDescendants_19", identifier, keys, childrenOnly);
        }
    }
    public class DxTreeViewInterop : HierarchicalCollectionWidgetInterop
    {
        public static event EventHandler<JQueryEventArgs> ItemClick;
        public static event EventHandler<JQueryEventArgs> ItemCollapsed;
        public static event EventHandler<JQueryEventArgs> ItemContextMenu;
        public static event EventHandler<JQueryEventArgs> ItemExpanded;
        public static event EventHandler<JQueryEventArgs> ItemHold;
        public static event EventHandler<JQueryEventArgs> ItemRendered;
        public static event EventHandler<JQueryEventArgs> ItemSelectionChanged;
        public static event EventHandler<JQueryEventArgs> SelectionChanged;
        public static void Init(string identifier, DevExpress.Ui.DxTreeViewOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeView.Init", identifier, json);
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
        public static bool? GetAnimationEnabled(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxTreeView.GetOption", identifier, "animationEnabled");
        }
        public static void SetAnimationEnabled(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeView.SetOption", identifier, "animationEnabled", value);
        }
        public static object GetCreateChildren(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeView.GetOption", identifier, "createChildren");
        }
        public static void SetCreateChildren(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeView.SetOption", identifier, "createChildren", value);
        }
        public static string GetDataStructure(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxTreeView.GetOption", identifier, "dataStructure");
        }
        public static void SetDataStructure(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeView.SetOption", identifier, "dataStructure", value);
        }
        public static bool? GetExpandAllEnabled(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxTreeView.GetOption", identifier, "expandAllEnabled");
        }
        public static void SetExpandAllEnabled(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeView.SetOption", identifier, "expandAllEnabled", value);
        }
        public static object GetExpandedExpr(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeView.GetOption", identifier, "expandedExpr");
        }
        public static void SetExpandedExpr(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeView.SetOption", identifier, "expandedExpr", value);
        }
        public static bool? GetExpandNodesRecursive(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxTreeView.GetOption", identifier, "expandNodesRecursive");
        }
        public static void SetExpandNodesRecursive(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeView.SetOption", identifier, "expandNodesRecursive", value);
        }
        public static object GetHasItemsExpr(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeView.GetOption", identifier, "hasItemsExpr");
        }
        public static void SetHasItemsExpr(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeView.SetOption", identifier, "hasItemsExpr", value);
        }
        public static new object GetItems(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeView.GetOption", identifier, "items");
        }
        public static new void SetItems(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeView.SetOption", identifier, "items", value);
        }
        public static object GetParentIdExpr(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeView.GetOption", identifier, "parentIdExpr");
        }
        public static void SetParentIdExpr(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeView.SetOption", identifier, "parentIdExpr", value);
        }
        public static object GetRootValue(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeView.GetOption", identifier, "rootValue");
        }
        public static void SetRootValue(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeView.SetOption", identifier, "rootValue", value);
        }
        public static string GetScrollDirection(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxTreeView.GetOption", identifier, "scrollDirection");
        }
        public static void SetScrollDirection(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeView.SetOption", identifier, "scrollDirection", value);
        }
        public static string GetSelectAllText(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxTreeView.GetOption", identifier, "selectAllText");
        }
        public static void SetSelectAllText(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeView.SetOption", identifier, "selectAllText", value);
        }
        public static bool? GetSelectByClick(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxTreeView.GetOption", identifier, "selectByClick");
        }
        public static void SetSelectByClick(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeView.SetOption", identifier, "selectByClick", value);
        }
        public static string GetSelectionMode(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxTreeView.GetOption", identifier, "selectionMode");
        }
        public static void SetSelectionMode(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeView.SetOption", identifier, "selectionMode", value);
        }
        public static bool? GetSelectNodesRecursive(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxTreeView.GetOption", identifier, "selectNodesRecursive");
        }
        public static void SetSelectNodesRecursive(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeView.SetOption", identifier, "selectNodesRecursive", value);
        }
        public static string GetShowCheckBoxesMode(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxTreeView.GetOption", identifier, "showCheckBoxesMode");
        }
        public static void SetShowCheckBoxesMode(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeView.SetOption", identifier, "showCheckBoxesMode", value);
        }
        public static bool? GetVirtualModeEnabled(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxTreeView.GetOption", identifier, "virtualModeEnabled");
        }
        public static void SetVirtualModeEnabled(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeView.SetOption", identifier, "virtualModeEnabled", value);
        }
        public static void CollapseItem(string identifier, object itemData)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeView.collapseItem_0", identifier, itemData);
        }
        public static void ExpandItem(string identifier, object itemData)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeView.expandItem_3", identifier, itemData);
        }
        public static object GetNodes(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeView.getNodes_6", identifier);
        }
        public static void SelectAll(string identifier)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeView.selectAll_7", identifier);
        }
        public static void SelectItem(string identifier, object itemData)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeView.selectItem_8", identifier, itemData);
        }
        public static void UnselectAll(string identifier)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeView.unselectAll_11", identifier);
        }
        public static void UnselectItem(string identifier, object itemData)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeView.unselectItem_12", identifier, itemData);
        }
        public static object UpdateDimensions(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeView.updateDimensions_15", identifier);
        }
    }
    public class DxValidationGroupInterop : DOMComponentInterop
    {
        public static void Init(string identifier, DevExpress.Ui.DxValidationGroupOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxValidationGroup.Init", identifier, json);
        }
        public static void Reset(string identifier)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxValidationGroup.reset_0", identifier);
        }
        public static object Validate(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxValidationGroup.validate_1", identifier);
        }
    }
    public class DxValidationSummaryInterop : CollectionWidgetInterop
    {
        public static void Init(string identifier, DevExpress.Ui.DxValidationSummaryOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxValidationSummary.Init", identifier, json);
        }
        public static string GetValidationGroup(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxValidationSummary.GetOption", identifier, "validationGroup");
        }
        public static void SetValidationGroup(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxValidationSummary.SetOption", identifier, "validationGroup", value);
        }
    }
    public class DxValidatorInterop : DOMComponentInterop
    {
        public static event EventHandler<JQueryEventArgs> Validated;
        public static void Init(string identifier, DevExpress.Ui.DxValidatorOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxValidator.Init", identifier, json);
        }
        public static void OnValidated(string identifier)
        {
            Validated?.Invoke(null, new JQueryEventArgs(identifier));
        }
        public static object GetAdapter(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxValidator.GetOption", identifier, "adapter");
        }
        public static void SetAdapter(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxValidator.SetOption", identifier, "adapter", value);
        }
        public static string GetName(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxValidator.GetOption", identifier, "name");
        }
        public static void SetName(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxValidator.SetOption", identifier, "name", value);
        }
        public static string GetValidationGroup(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxValidator.GetOption", identifier, "validationGroup");
        }
        public static void SetValidationGroup(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxValidator.SetOption", identifier, "validationGroup", value);
        }
        public static object GetValidationRules(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxValidator.GetOption", identifier, "validationRules");
        }
        public static void SetValidationRules(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxValidator.SetOption", identifier, "validationRules", value);
        }
        public static void Focus(string identifier)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxValidator.focus_0", identifier);
        }
        public static void Reset(string identifier)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxValidator.reset_1", identifier);
        }
        public static object Validate(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxValidator.validate_2", identifier);
        }
    }
    public class CollectionWidgetInterop : WidgetInterop
    {
        public static event EventHandler<JQueryEventArgs> ItemClick;
        public static event EventHandler<JQueryEventArgs> ItemContextMenu;
        public static event EventHandler<JQueryEventArgs> ItemHold;
        public static event EventHandler<JQueryEventArgs> ItemRendered;
        public static event EventHandler<JQueryEventArgs> SelectionChanged;
        public static void Init(string identifier, DevExpress.Ui.CollectionWidgetOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.CollectionWidget.Init", identifier, json);
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
        public static object GetDataSource(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.CollectionWidget.GetOption", identifier, "dataSource");
        }
        public static void SetDataSource(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.CollectionWidget.SetOption", identifier, "dataSource", value);
        }
        public static float? GetItemHoldTimeout(string identifier)
        {
            return RegisteredFunction.Invoke<float?>("BlazorDevExtreme.CollectionWidget.GetOption", identifier, "itemHoldTimeout");
        }
        public static void SetItemHoldTimeout(string identifier, float? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.CollectionWidget.SetOption", identifier, "itemHoldTimeout", value);
        }
        public static object GetItems(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.CollectionWidget.GetOption", identifier, "items");
        }
        public static void SetItems(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.CollectionWidget.SetOption", identifier, "items", value);
        }
        public static object GetItemTemplate(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.CollectionWidget.GetOption", identifier, "itemTemplate");
        }
        public static void SetItemTemplate(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.CollectionWidget.SetOption", identifier, "itemTemplate", value);
        }
        public static object GetKeyExpr(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.CollectionWidget.GetOption", identifier, "keyExpr");
        }
        public static void SetKeyExpr(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.CollectionWidget.SetOption", identifier, "keyExpr", value);
        }
        public static string GetNoDataText(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.CollectionWidget.GetOption", identifier, "noDataText");
        }
        public static void SetNoDataText(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.CollectionWidget.SetOption", identifier, "noDataText", value);
        }
        public static float? GetSelectedIndex(string identifier)
        {
            return RegisteredFunction.Invoke<float?>("BlazorDevExtreme.CollectionWidget.GetOption", identifier, "selectedIndex");
        }
        public static void SetSelectedIndex(string identifier, float? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.CollectionWidget.SetOption", identifier, "selectedIndex", value);
        }
        public static object GetSelectedItem(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.CollectionWidget.GetOption", identifier, "selectedItem");
        }
        public static void SetSelectedItem(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.CollectionWidget.SetOption", identifier, "selectedItem", value);
        }
        public static object GetSelectedItemKeys(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.CollectionWidget.GetOption", identifier, "selectedItemKeys");
        }
        public static void SetSelectedItemKeys(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.CollectionWidget.SetOption", identifier, "selectedItemKeys", value);
        }
        public static object GetSelectedItems(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.CollectionWidget.GetOption", identifier, "selectedItems");
        }
        public static void SetSelectedItems(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.CollectionWidget.SetOption", identifier, "selectedItems", value);
        }
        public static object GetDataSourceEx(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.CollectionWidget.getDataSource_0", identifier);
        }
    }
    public class DxMenuBaseInterop : HierarchicalCollectionWidgetInterop
    {
        public static void Init(string identifier, DevExpress.Ui.DxMenuBaseOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxMenuBase.Init", identifier, json);
        }
        public static new bool? GetActiveStateEnabled(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxMenuBase.GetOption", identifier, "activeStateEnabled");
        }
        public static new void SetActiveStateEnabled(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxMenuBase.SetOption", identifier, "activeStateEnabled", value);
        }
        public static object GetAnimation(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxMenuBase.GetOption", identifier, "animation");
        }
        public static void SetAnimation(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxMenuBase.SetOption", identifier, "animation", value);
        }
        public static string GetCssClass(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxMenuBase.GetOption", identifier, "cssClass");
        }
        public static void SetCssClass(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxMenuBase.SetOption", identifier, "cssClass", value);
        }
        public static new object GetItems(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxMenuBase.GetOption", identifier, "items");
        }
        public static new void SetItems(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxMenuBase.SetOption", identifier, "items", value);
        }
        public static bool? GetSelectByClick(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxMenuBase.GetOption", identifier, "selectByClick");
        }
        public static void SetSelectByClick(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxMenuBase.SetOption", identifier, "selectByClick", value);
        }
        public static string GetSelectionMode(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxMenuBase.GetOption", identifier, "selectionMode");
        }
        public static void SetSelectionMode(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxMenuBase.SetOption", identifier, "selectionMode", value);
        }
        public static object GetShowSubmenuMode(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxMenuBase.GetOption", identifier, "showSubmenuMode");
        }
        public static void SetShowSubmenuMode(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxMenuBase.SetOption", identifier, "showSubmenuMode", value);
        }
        public static void SelectItem(string identifier, object itemElement)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxMenuBase.selectItem_0", identifier, itemElement);
        }
        public static void UnselectItem(string identifier, object itemElement)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxMenuBase.unselectItem_1", identifier, itemElement);
        }
    }
    public class DxDropDownEditorInterop : DxTextBoxInterop
    {
        public static event EventHandler<JQueryEventArgs> Closed;
        public static event EventHandler<JQueryEventArgs> Opened;
        public static void Init(string identifier, DevExpress.Ui.DxDropDownEditorOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDropDownEditor.Init", identifier, json);
        }
        public static void OnClosed(string identifier)
        {
            Closed?.Invoke(null, new JQueryEventArgs(identifier));
        }
        public static void OnOpened(string identifier)
        {
            Opened?.Invoke(null, new JQueryEventArgs(identifier));
        }
        public static bool? GetAcceptCustomValue(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxDropDownEditor.GetOption", identifier, "acceptCustomValue");
        }
        public static void SetAcceptCustomValue(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDropDownEditor.SetOption", identifier, "acceptCustomValue", value);
        }
        public static new bool? GetActiveStateEnabled(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxDropDownEditor.GetOption", identifier, "activeStateEnabled");
        }
        public static new void SetActiveStateEnabled(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDropDownEditor.SetOption", identifier, "activeStateEnabled", value);
        }
        public static string GetApplyValueMode(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxDropDownEditor.GetOption", identifier, "applyValueMode");
        }
        public static void SetApplyValueMode(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDropDownEditor.SetOption", identifier, "applyValueMode", value);
        }
        public static bool? GetDeferRendering(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxDropDownEditor.GetOption", identifier, "deferRendering");
        }
        public static void SetDeferRendering(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDropDownEditor.SetOption", identifier, "deferRendering", value);
        }
        public static object GetDropDownButtonTemplate(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDropDownEditor.GetOption", identifier, "dropDownButtonTemplate");
        }
        public static void SetDropDownButtonTemplate(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDropDownEditor.SetOption", identifier, "dropDownButtonTemplate", value);
        }
        public static bool? GetOpened(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxDropDownEditor.GetOption", identifier, "opened");
        }
        public static void SetOpened(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDropDownEditor.SetOption", identifier, "opened", value);
        }
        public static new object GetValue(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDropDownEditor.GetOption", identifier, "value");
        }
        public static new void SetValue(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDropDownEditor.SetOption", identifier, "value", value);
        }
        public static void Close(string identifier)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDropDownEditor.close_0", identifier);
        }
        public static object Content(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDropDownEditor.content_1", identifier);
        }
        public static object Field(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDropDownEditor.field_2", identifier);
        }
        public static void Open(string identifier)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDropDownEditor.open_3", identifier);
        }
        public static void Reset(string identifier)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDropDownEditor.reset_4", identifier);
        }
    }
    public class DxDropDownListInterop : DxDropDownEditorInterop
    {
        public static event EventHandler<JQueryEventArgs> ItemClick;
        public static event EventHandler<JQueryEventArgs> SelectionChanged;
        public static event EventHandler<JQueryEventArgs> ValueChanged;
        public static void Init(string identifier, DevExpress.Ui.DxDropDownListOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDropDownList.Init", identifier, json);
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
        public static string GetDisplayValue(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxDropDownList.GetOption", identifier, "displayValue");
        }
        public static void SetDisplayValue(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDropDownList.SetOption", identifier, "displayValue", value);
        }
        public static bool? GetGrouped(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxDropDownList.GetOption", identifier, "grouped");
        }
        public static void SetGrouped(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDropDownList.SetOption", identifier, "grouped", value);
        }
        public static object GetGroupTemplate(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDropDownList.GetOption", identifier, "groupTemplate");
        }
        public static void SetGroupTemplate(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDropDownList.SetOption", identifier, "groupTemplate", value);
        }
        public static float? GetMinSearchLength(string identifier)
        {
            return RegisteredFunction.Invoke<float?>("BlazorDevExtreme.DxDropDownList.GetOption", identifier, "minSearchLength");
        }
        public static void SetMinSearchLength(string identifier, float? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDropDownList.SetOption", identifier, "minSearchLength", value);
        }
        public static string GetNoDataText(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxDropDownList.GetOption", identifier, "noDataText");
        }
        public static void SetNoDataText(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDropDownList.SetOption", identifier, "noDataText", value);
        }
        public static bool? GetSearchEnabled(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxDropDownList.GetOption", identifier, "searchEnabled");
        }
        public static void SetSearchEnabled(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDropDownList.SetOption", identifier, "searchEnabled", value);
        }
        public static object GetSearchExpr(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDropDownList.GetOption", identifier, "searchExpr");
        }
        public static void SetSearchExpr(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDropDownList.SetOption", identifier, "searchExpr", value);
        }
        public static string GetSearchMode(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxDropDownList.GetOption", identifier, "searchMode");
        }
        public static void SetSearchMode(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDropDownList.SetOption", identifier, "searchMode", value);
        }
        public static float? GetSearchTimeout(string identifier)
        {
            return RegisteredFunction.Invoke<float?>("BlazorDevExtreme.DxDropDownList.GetOption", identifier, "searchTimeout");
        }
        public static void SetSearchTimeout(string identifier, float? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDropDownList.SetOption", identifier, "searchTimeout", value);
        }
        public static object GetSelectedItem(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDropDownList.GetOption", identifier, "selectedItem");
        }
        public static void SetSelectedItem(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDropDownList.SetOption", identifier, "selectedItem", value);
        }
        public static bool? GetShowDataBeforeSearch(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxDropDownList.GetOption", identifier, "showDataBeforeSearch");
        }
        public static void SetShowDataBeforeSearch(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDropDownList.SetOption", identifier, "showDataBeforeSearch", value);
        }
        public static new object GetValue(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDropDownList.GetOption", identifier, "value");
        }
        public static new void SetValue(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDropDownList.SetOption", identifier, "value", value);
        }
        public static new string GetValueChangeEvent(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxDropDownList.GetOption", identifier, "valueChangeEvent");
        }
        public static new void SetValueChangeEvent(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDropDownList.SetOption", identifier, "valueChangeEvent", value);
        }
        public static object GetDataSourceEx(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDropDownList.getDataSource_0", identifier);
        }
    }
    public class EditorInterop : WidgetInterop
    {
        public static event EventHandler<JQueryEventArgs> ValueChanged;
        public static void Init(string identifier, DevExpress.Ui.EditorOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.Editor.Init", identifier, json);
        }
        public static void OnValueChanged(string identifier)
        {
            ValueChanged?.Invoke(null, new JQueryEventArgs(identifier));
        }
        public static bool? GetIsValid(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.Editor.GetOption", identifier, "isValid");
        }
        public static void SetIsValid(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.Editor.SetOption", identifier, "isValid", value);
        }
        public static bool? GetReadOnly(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.Editor.GetOption", identifier, "readOnly");
        }
        public static void SetReadOnly(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.Editor.SetOption", identifier, "readOnly", value);
        }
        public static object GetValidationError(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.Editor.GetOption", identifier, "validationError");
        }
        public static void SetValidationError(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.Editor.SetOption", identifier, "validationError", value);
        }
        public static string GetValidationMessageMode(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.Editor.GetOption", identifier, "validationMessageMode");
        }
        public static void SetValidationMessageMode(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.Editor.SetOption", identifier, "validationMessageMode", value);
        }
        public static object GetValue(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.Editor.GetOption", identifier, "value");
        }
        public static void SetValue(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.Editor.SetOption", identifier, "value", value);
        }
        public static void Reset(string identifier)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.Editor.reset_0", identifier);
        }
    }
    public class DataExpressionMixinInterop
    {
        public static void Init(string identifier, DevExpress.Ui.DataExpressionMixinOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DataExpressionMixin.Init", identifier, json);
        }
        public static object GetDataSource(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DataExpressionMixin.GetOption", identifier, "dataSource");
        }
        public static void SetDataSource(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DataExpressionMixin.SetOption", identifier, "dataSource", value);
        }
        public static object GetDisplayExpr(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DataExpressionMixin.GetOption", identifier, "displayExpr");
        }
        public static void SetDisplayExpr(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DataExpressionMixin.SetOption", identifier, "displayExpr", value);
        }
        public static object GetItems(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DataExpressionMixin.GetOption", identifier, "items");
        }
        public static void SetItems(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DataExpressionMixin.SetOption", identifier, "items", value);
        }
        public static object GetItemTemplate(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DataExpressionMixin.GetOption", identifier, "itemTemplate");
        }
        public static void SetItemTemplate(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DataExpressionMixin.SetOption", identifier, "itemTemplate", value);
        }
        public static object GetValue(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DataExpressionMixin.GetOption", identifier, "value");
        }
        public static void SetValue(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DataExpressionMixin.SetOption", identifier, "value", value);
        }
        public static object GetValueExpr(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DataExpressionMixin.GetOption", identifier, "valueExpr");
        }
        public static void SetValueExpr(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DataExpressionMixin.SetOption", identifier, "valueExpr", value);
        }
        public static object GetDataSourceEx(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DataExpressionMixin.getDataSource_0", identifier);
        }
    }
    public class HierarchicalCollectionWidgetInterop : CollectionWidgetInterop
    {
        public static void Init(string identifier, DevExpress.Ui.HierarchicalCollectionWidgetOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.HierarchicalCollectionWidget.Init", identifier, json);
        }
        public static object GetDisabledExpr(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.HierarchicalCollectionWidget.GetOption", identifier, "disabledExpr");
        }
        public static void SetDisabledExpr(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.HierarchicalCollectionWidget.SetOption", identifier, "disabledExpr", value);
        }
        public static object GetDisplayExpr(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.HierarchicalCollectionWidget.GetOption", identifier, "displayExpr");
        }
        public static void SetDisplayExpr(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.HierarchicalCollectionWidget.SetOption", identifier, "displayExpr", value);
        }
        public static new bool? GetFocusStateEnabled(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.HierarchicalCollectionWidget.GetOption", identifier, "focusStateEnabled");
        }
        public static new void SetFocusStateEnabled(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.HierarchicalCollectionWidget.SetOption", identifier, "focusStateEnabled", value);
        }
        public static new bool? GetHoverStateEnabled(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.HierarchicalCollectionWidget.GetOption", identifier, "hoverStateEnabled");
        }
        public static new void SetHoverStateEnabled(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.HierarchicalCollectionWidget.SetOption", identifier, "hoverStateEnabled", value);
        }
        public static object GetItemsExpr(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.HierarchicalCollectionWidget.GetOption", identifier, "itemsExpr");
        }
        public static void SetItemsExpr(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.HierarchicalCollectionWidget.SetOption", identifier, "itemsExpr", value);
        }
        public static new object GetKeyExpr(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.HierarchicalCollectionWidget.GetOption", identifier, "keyExpr");
        }
        public static new void SetKeyExpr(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.HierarchicalCollectionWidget.SetOption", identifier, "keyExpr", value);
        }
        public static object GetSelectedExpr(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.HierarchicalCollectionWidget.GetOption", identifier, "selectedExpr");
        }
        public static void SetSelectedExpr(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.HierarchicalCollectionWidget.SetOption", identifier, "selectedExpr", value);
        }
    }
    public class DxPivotGridSummaryCellInterop
    {
        public static object Child(string identifier, string direction, object fieldValue)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPivotGridSummaryCell.child_0", identifier, direction, fieldValue);
        }
        public static object Children(string identifier, string direction)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPivotGridSummaryCell.children_1", identifier, direction);
        }
        public static object Field(string identifier, string area)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPivotGridSummaryCell.field_2", identifier, area);
        }
        public static object GrandTotal(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPivotGridSummaryCell.grandTotal_3", identifier);
        }
        public static object GrandTotal(string identifier, string direction)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPivotGridSummaryCell.grandTotal_4", identifier, direction);
        }
        public static object Next(string identifier, string direction)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPivotGridSummaryCell.next_5", identifier, direction);
        }
        public static object Next(string identifier, string direction, bool allowCrossGroup)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPivotGridSummaryCell.next_6", identifier, direction, allowCrossGroup);
        }
        public static object Parent(string identifier, string direction)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPivotGridSummaryCell.parent_7", identifier, direction);
        }
        public static object Prev(string identifier, string direction)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPivotGridSummaryCell.prev_8", identifier, direction);
        }
        public static object Prev(string identifier, string direction, bool allowCrossGroup)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPivotGridSummaryCell.prev_9", identifier, direction, allowCrossGroup);
        }
        public static object Slice(string identifier, object field, object value)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPivotGridSummaryCell.slice_10", identifier, field, value);
        }
        public static object ValueEx(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPivotGridSummaryCell.value_11", identifier);
        }
        public static object ValueEx(string identifier, object field)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPivotGridSummaryCell.value_12", identifier, field);
        }
        public static object ValueEx(string identifier, object field, bool isCalculatedValue)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPivotGridSummaryCell.value_13", identifier, field, isCalculatedValue);
        }
        public static object ValueEx(string identifier, bool isCalculatedValue)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPivotGridSummaryCell.value_14", identifier, isCalculatedValue);
        }
    }
    public class DxScrollableInterop : DOMComponentInterop
    {
        public static event EventHandler<JQueryEventArgs> Scroll;
        public static event EventHandler<JQueryEventArgs> Updated;
        public static void Init(string identifier, DevExpress.Ui.DxScrollableOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxScrollable.Init", identifier, json);
        }
        public static void OnScroll(string identifier)
        {
            Scroll?.Invoke(null, new JQueryEventArgs(identifier));
        }
        public static void OnUpdated(string identifier)
        {
            Updated?.Invoke(null, new JQueryEventArgs(identifier));
        }
        public static bool? GetBounceEnabled(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxScrollable.GetOption", identifier, "bounceEnabled");
        }
        public static void SetBounceEnabled(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxScrollable.SetOption", identifier, "bounceEnabled", value);
        }
        public static string GetDirection(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxScrollable.GetOption", identifier, "direction");
        }
        public static void SetDirection(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxScrollable.SetOption", identifier, "direction", value);
        }
        public static bool? GetDisabled(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxScrollable.GetOption", identifier, "disabled");
        }
        public static void SetDisabled(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxScrollable.SetOption", identifier, "disabled", value);
        }
        public static bool? GetScrollByContent(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxScrollable.GetOption", identifier, "scrollByContent");
        }
        public static void SetScrollByContent(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxScrollable.SetOption", identifier, "scrollByContent", value);
        }
        public static bool? GetScrollByThumb(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxScrollable.GetOption", identifier, "scrollByThumb");
        }
        public static void SetScrollByThumb(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxScrollable.SetOption", identifier, "scrollByThumb", value);
        }
        public static string GetShowScrollbar(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxScrollable.GetOption", identifier, "showScrollbar");
        }
        public static void SetShowScrollbar(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxScrollable.SetOption", identifier, "showScrollbar", value);
        }
        public static bool? GetUseNative(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxScrollable.GetOption", identifier, "useNative");
        }
        public static void SetUseNative(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxScrollable.SetOption", identifier, "useNative", value);
        }
        public static float ClientHeight(string identifier)
        {
            return RegisteredFunction.Invoke<float>("BlazorDevExtreme.DxScrollable.clientHeight_0", identifier);
        }
        public static float ClientWidth(string identifier)
        {
            return RegisteredFunction.Invoke<float>("BlazorDevExtreme.DxScrollable.clientWidth_1", identifier);
        }
        public static object Content(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxScrollable.content_2", identifier);
        }
        public static void ScrollBy(string identifier, float distance)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxScrollable.scrollBy_3", identifier, distance);
        }
        public static void ScrollBy(string identifier, object distanceObject)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxScrollable.scrollBy_4", identifier, distanceObject);
        }
        public static float ScrollHeight(string identifier)
        {
            return RegisteredFunction.Invoke<float>("BlazorDevExtreme.DxScrollable.scrollHeight_5", identifier);
        }
        public static float ScrollLeft(string identifier)
        {
            return RegisteredFunction.Invoke<float>("BlazorDevExtreme.DxScrollable.scrollLeft_6", identifier);
        }
        public static object ScrollOffset(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxScrollable.scrollOffset_7", identifier);
        }
        public static void ScrollTo(string identifier, float targetLocation)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxScrollable.scrollTo_8", identifier, targetLocation);
        }
        public static void ScrollTo(string identifier, object targetLocation)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxScrollable.scrollTo_9", identifier, targetLocation);
        }
        public static void ScrollToElement(string identifier, object element)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxScrollable.scrollToElement_10", identifier, element);
        }
        public static float ScrollTop(string identifier)
        {
            return RegisteredFunction.Invoke<float>("BlazorDevExtreme.DxScrollable.scrollTop_11", identifier);
        }
        public static float ScrollWidth(string identifier)
        {
            return RegisteredFunction.Invoke<float>("BlazorDevExtreme.DxScrollable.scrollWidth_12", identifier);
        }
        public static object Update(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxScrollable.update_13", identifier);
        }
    }
    public class DxSliderBaseInterop : DxTrackBarInterop
    {
        public static void Init(string identifier, DevExpress.Ui.DxSliderBaseOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxSliderBase.Init", identifier, json);
        }
        public static new bool? GetActiveStateEnabled(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxSliderBase.GetOption", identifier, "activeStateEnabled");
        }
        public static new void SetActiveStateEnabled(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxSliderBase.SetOption", identifier, "activeStateEnabled", value);
        }
        public static new bool? GetFocusStateEnabled(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxSliderBase.GetOption", identifier, "focusStateEnabled");
        }
        public static new void SetFocusStateEnabled(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxSliderBase.SetOption", identifier, "focusStateEnabled", value);
        }
        public static new bool? GetHoverStateEnabled(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxSliderBase.GetOption", identifier, "hoverStateEnabled");
        }
        public static new void SetHoverStateEnabled(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxSliderBase.SetOption", identifier, "hoverStateEnabled", value);
        }
        public static float? GetKeyStep(string identifier)
        {
            return RegisteredFunction.Invoke<float?>("BlazorDevExtreme.DxSliderBase.GetOption", identifier, "keyStep");
        }
        public static void SetKeyStep(string identifier, float? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxSliderBase.SetOption", identifier, "keyStep", value);
        }
        public static object GetLabel(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxSliderBase.GetOption", identifier, "label");
        }
        public static void SetLabel(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxSliderBase.SetOption", identifier, "label", value);
        }
        public static string GetName(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxSliderBase.GetOption", identifier, "name");
        }
        public static void SetName(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxSliderBase.SetOption", identifier, "name", value);
        }
        public static bool? GetShowRange(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxSliderBase.GetOption", identifier, "showRange");
        }
        public static void SetShowRange(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxSliderBase.SetOption", identifier, "showRange", value);
        }
        public static float? GetStep(string identifier)
        {
            return RegisteredFunction.Invoke<float?>("BlazorDevExtreme.DxSliderBase.GetOption", identifier, "step");
        }
        public static void SetStep(string identifier, float? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxSliderBase.SetOption", identifier, "step", value);
        }
        public static object GetTooltip(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxSliderBase.GetOption", identifier, "tooltip");
        }
        public static void SetTooltip(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxSliderBase.SetOption", identifier, "tooltip", value);
        }
    }
    public class DxTextEditorInterop : EditorInterop
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
        public static void Init(string identifier, DevExpress.Ui.DxTextEditorOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTextEditor.Init", identifier, json);
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
        public static new bool? GetFocusStateEnabled(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxTextEditor.GetOption", identifier, "focusStateEnabled");
        }
        public static new void SetFocusStateEnabled(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTextEditor.SetOption", identifier, "focusStateEnabled", value);
        }
        public static new bool? GetHoverStateEnabled(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxTextEditor.GetOption", identifier, "hoverStateEnabled");
        }
        public static new void SetHoverStateEnabled(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTextEditor.SetOption", identifier, "hoverStateEnabled", value);
        }
        public static object GetInputAttr(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTextEditor.GetOption", identifier, "inputAttr");
        }
        public static void SetInputAttr(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTextEditor.SetOption", identifier, "inputAttr", value);
        }
        public static string GetMask(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxTextEditor.GetOption", identifier, "mask");
        }
        public static void SetMask(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTextEditor.SetOption", identifier, "mask", value);
        }
        public static string GetMaskChar(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxTextEditor.GetOption", identifier, "maskChar");
        }
        public static void SetMaskChar(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTextEditor.SetOption", identifier, "maskChar", value);
        }
        public static string GetMaskInvalidMessage(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxTextEditor.GetOption", identifier, "maskInvalidMessage");
        }
        public static void SetMaskInvalidMessage(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTextEditor.SetOption", identifier, "maskInvalidMessage", value);
        }
        public static object GetMaskRules(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTextEditor.GetOption", identifier, "maskRules");
        }
        public static void SetMaskRules(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTextEditor.SetOption", identifier, "maskRules", value);
        }
        public static string GetName(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxTextEditor.GetOption", identifier, "name");
        }
        public static void SetName(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTextEditor.SetOption", identifier, "name", value);
        }
        public static string GetPlaceholder(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxTextEditor.GetOption", identifier, "placeholder");
        }
        public static void SetPlaceholder(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTextEditor.SetOption", identifier, "placeholder", value);
        }
        public static bool? GetShowClearButton(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxTextEditor.GetOption", identifier, "showClearButton");
        }
        public static void SetShowClearButton(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTextEditor.SetOption", identifier, "showClearButton", value);
        }
        public static string GetShowMaskMode(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxTextEditor.GetOption", identifier, "showMaskMode");
        }
        public static void SetShowMaskMode(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTextEditor.SetOption", identifier, "showMaskMode", value);
        }
        public static bool? GetSpellcheck(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxTextEditor.GetOption", identifier, "spellcheck");
        }
        public static void SetSpellcheck(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTextEditor.SetOption", identifier, "spellcheck", value);
        }
        public static string GetText(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxTextEditor.GetOption", identifier, "text");
        }
        public static void SetText(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTextEditor.SetOption", identifier, "text", value);
        }
        public static bool? GetUseMaskedValue(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxTextEditor.GetOption", identifier, "useMaskedValue");
        }
        public static void SetUseMaskedValue(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTextEditor.SetOption", identifier, "useMaskedValue", value);
        }
        public static new object GetValue(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTextEditor.GetOption", identifier, "value");
        }
        public static new void SetValue(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTextEditor.SetOption", identifier, "value", value);
        }
        public static string GetValueChangeEvent(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxTextEditor.GetOption", identifier, "valueChangeEvent");
        }
        public static void SetValueChangeEvent(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTextEditor.SetOption", identifier, "valueChangeEvent", value);
        }
        public static void Blur(string identifier)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTextEditor.blur_0", identifier);
        }
        public static void Focus(string identifier)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTextEditor.focus_1", identifier);
        }
    }
    public class SearchBoxMixinInterop
    {
        public static void Init(string identifier, DevExpress.Ui.SearchBoxMixinOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.SearchBoxMixin.Init", identifier, json);
        }
        public static object GetSearchEditorOptions(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.SearchBoxMixin.GetOption", identifier, "searchEditorOptions");
        }
        public static void SetSearchEditorOptions(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.SearchBoxMixin.SetOption", identifier, "searchEditorOptions", value);
        }
        public static bool? GetSearchEnabled(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.SearchBoxMixin.GetOption", identifier, "searchEnabled");
        }
        public static void SetSearchEnabled(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.SearchBoxMixin.SetOption", identifier, "searchEnabled", value);
        }
        public static object GetSearchExpr(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.SearchBoxMixin.GetOption", identifier, "searchExpr");
        }
        public static void SetSearchExpr(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.SearchBoxMixin.SetOption", identifier, "searchExpr", value);
        }
        public static string GetSearchMode(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.SearchBoxMixin.GetOption", identifier, "searchMode");
        }
        public static void SetSearchMode(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.SearchBoxMixin.SetOption", identifier, "searchMode", value);
        }
        public static float? GetSearchTimeout(string identifier)
        {
            return RegisteredFunction.Invoke<float?>("BlazorDevExtreme.SearchBoxMixin.GetOption", identifier, "searchTimeout");
        }
        public static void SetSearchTimeout(string identifier, float? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.SearchBoxMixin.SetOption", identifier, "searchTimeout", value);
        }
        public static string GetSearchValue(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.SearchBoxMixin.GetOption", identifier, "searchValue");
        }
        public static void SetSearchValue(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.SearchBoxMixin.SetOption", identifier, "searchValue", value);
        }
    }
    public class DxTemplateInterop
    {
        public static void Init(string identifier, DevExpress.Ui.DxTemplateOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTemplate.Init", identifier, json);
        }
        public static string GetName(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxTemplate.GetOption", identifier, "name");
        }
        public static void SetName(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTemplate.SetOption", identifier, "name", value);
        }
    }
    public class WidgetInterop : DOMComponentInterop
    {
        public static event EventHandler<JQueryEventArgs> ContentReady;
        public static void Init(string identifier, DevExpress.Ui.WidgetOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.Widget.Init", identifier, json);
        }
        public static void OnContentReady(string identifier)
        {
            ContentReady?.Invoke(null, new JQueryEventArgs(identifier));
        }
        public static string GetAccessKey(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.Widget.GetOption", identifier, "accessKey");
        }
        public static void SetAccessKey(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.Widget.SetOption", identifier, "accessKey", value);
        }
        public static bool? GetActiveStateEnabled(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.Widget.GetOption", identifier, "activeStateEnabled");
        }
        public static void SetActiveStateEnabled(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.Widget.SetOption", identifier, "activeStateEnabled", value);
        }
        public static bool? GetDisabled(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.Widget.GetOption", identifier, "disabled");
        }
        public static void SetDisabled(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.Widget.SetOption", identifier, "disabled", value);
        }
        public static bool? GetFocusStateEnabled(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.Widget.GetOption", identifier, "focusStateEnabled");
        }
        public static void SetFocusStateEnabled(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.Widget.SetOption", identifier, "focusStateEnabled", value);
        }
        public static string GetHint(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.Widget.GetOption", identifier, "hint");
        }
        public static void SetHint(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.Widget.SetOption", identifier, "hint", value);
        }
        public static bool? GetHoverStateEnabled(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.Widget.GetOption", identifier, "hoverStateEnabled");
        }
        public static void SetHoverStateEnabled(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.Widget.SetOption", identifier, "hoverStateEnabled", value);
        }
        public static float? GetTabIndex(string identifier)
        {
            return RegisteredFunction.Invoke<float?>("BlazorDevExtreme.Widget.GetOption", identifier, "tabIndex");
        }
        public static void SetTabIndex(string identifier, float? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.Widget.SetOption", identifier, "tabIndex", value);
        }
        public static bool? GetVisible(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.Widget.GetOption", identifier, "visible");
        }
        public static void SetVisible(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.Widget.SetOption", identifier, "visible", value);
        }
        public static void Focus(string identifier)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.Widget.focus_0", identifier);
        }
        public static void RegisterKeyHandler(string identifier, string key, object handler)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.Widget.registerKeyHandler_1", identifier, key, handler);
        }
        public static void Repaint(string identifier)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.Widget.repaint_2", identifier);
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
    public class BaseWidgetInterop : DOMComponentInterop
    {
        public static event EventHandler<JQueryEventArgs> Drawn;
        public static event EventHandler<JQueryEventArgs> Exported;
        public static event EventHandler<JQueryEventArgs> Exporting;
        public static event EventHandler<JQueryEventArgs> FileSaving;
        public static event EventHandler<JQueryEventArgs> IncidentOccurred;
        public static void Init(string identifier, DevExpress.Viz.BaseWidgetOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.BaseWidget.Init", identifier, json);
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
        public static object GetExport(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.BaseWidget.GetOption", identifier, "export");
        }
        public static void SetExport(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.BaseWidget.SetOption", identifier, "export", value);
        }
        public static object GetLoadingIndicator(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.BaseWidget.GetOption", identifier, "loadingIndicator");
        }
        public static void SetLoadingIndicator(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.BaseWidget.SetOption", identifier, "loadingIndicator", value);
        }
        public static object GetMargin(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.BaseWidget.GetOption", identifier, "margin");
        }
        public static void SetMargin(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.BaseWidget.SetOption", identifier, "margin", value);
        }
        public static bool? GetPathModified(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.BaseWidget.GetOption", identifier, "pathModified");
        }
        public static void SetPathModified(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.BaseWidget.SetOption", identifier, "pathModified", value);
        }
        public static bool? GetRedrawOnResize(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.BaseWidget.GetOption", identifier, "redrawOnResize");
        }
        public static void SetRedrawOnResize(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.BaseWidget.SetOption", identifier, "redrawOnResize", value);
        }
        public static new bool? GetRtlEnabled(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.BaseWidget.GetOption", identifier, "rtlEnabled");
        }
        public static new void SetRtlEnabled(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.BaseWidget.SetOption", identifier, "rtlEnabled", value);
        }
        public static object GetSize(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.BaseWidget.GetOption", identifier, "size");
        }
        public static void SetSize(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.BaseWidget.SetOption", identifier, "size", value);
        }
        public static string GetTheme(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.BaseWidget.GetOption", identifier, "theme");
        }
        public static void SetTheme(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.BaseWidget.SetOption", identifier, "theme", value);
        }
        public static object GetTitle(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.BaseWidget.GetOption", identifier, "title");
        }
        public static void SetTitle(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.BaseWidget.SetOption", identifier, "title", value);
        }
        public static object GetTooltip(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.BaseWidget.GetOption", identifier, "tooltip");
        }
        public static void SetTooltip(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.BaseWidget.SetOption", identifier, "tooltip", value);
        }
        public static void ExportTo(string identifier, string fileName, string format)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.BaseWidget.exportTo_0", identifier, fileName, format);
        }
        public static object GetSizeEx(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.BaseWidget.getSize_1", identifier);
        }
        public static void HideLoadingIndicator(string identifier)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.BaseWidget.hideLoadingIndicator_2", identifier);
        }
        public static void Print(string identifier)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.BaseWidget.print_3", identifier);
        }
        public static void Render(string identifier)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.BaseWidget.render_4", identifier);
        }
        public static void ShowLoadingIndicator(string identifier)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.BaseWidget.showLoadingIndicator_5", identifier);
        }
        public static string Svg(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.BaseWidget.svg_6", identifier);
        }
    }
    public class DxChartInterop : BaseChartInterop
    {
        public static event EventHandler<JQueryEventArgs> ArgumentAxisClick;
        public static event EventHandler<JQueryEventArgs> LegendClick;
        public static event EventHandler<JQueryEventArgs> SeriesClick;
        public static event EventHandler<JQueryEventArgs> SeriesHoverChanged;
        public static event EventHandler<JQueryEventArgs> SeriesSelectionChanged;
        public static event EventHandler<JQueryEventArgs> ZoomEnd;
        public static event EventHandler<JQueryEventArgs> ZoomStart;
        public static void Init(string identifier, DevExpress.Viz.Charts.DxChartOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxChart.Init", identifier, json);
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
        public static bool? GetAdjustOnZoom(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxChart.GetOption", identifier, "adjustOnZoom");
        }
        public static void SetAdjustOnZoom(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxChart.SetOption", identifier, "adjustOnZoom", value);
        }
        public static object GetArgumentAxis(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxChart.GetOption", identifier, "argumentAxis");
        }
        public static void SetArgumentAxis(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxChart.SetOption", identifier, "argumentAxis", value);
        }
        public static float? GetBarGroupPadding(string identifier)
        {
            return RegisteredFunction.Invoke<float?>("BlazorDevExtreme.DxChart.GetOption", identifier, "barGroupPadding");
        }
        public static void SetBarGroupPadding(string identifier, float? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxChart.SetOption", identifier, "barGroupPadding", value);
        }
        public static float? GetBarGroupWidth(string identifier)
        {
            return RegisteredFunction.Invoke<float?>("BlazorDevExtreme.DxChart.GetOption", identifier, "barGroupWidth");
        }
        public static void SetBarGroupWidth(string identifier, float? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxChart.SetOption", identifier, "barGroupWidth", value);
        }
        public static float? GetBarWidth(string identifier)
        {
            return RegisteredFunction.Invoke<float?>("BlazorDevExtreme.DxChart.GetOption", identifier, "barWidth");
        }
        public static void SetBarWidth(string identifier, float? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxChart.SetOption", identifier, "barWidth", value);
        }
        public static object GetCommonAxisSettings(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxChart.GetOption", identifier, "commonAxisSettings");
        }
        public static void SetCommonAxisSettings(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxChart.SetOption", identifier, "commonAxisSettings", value);
        }
        public static object GetCommonPaneSettings(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxChart.GetOption", identifier, "commonPaneSettings");
        }
        public static void SetCommonPaneSettings(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxChart.SetOption", identifier, "commonPaneSettings", value);
        }
        public static object GetCommonSeriesSettings(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxChart.GetOption", identifier, "commonSeriesSettings");
        }
        public static void SetCommonSeriesSettings(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxChart.SetOption", identifier, "commonSeriesSettings", value);
        }
        public static string GetContainerBackgroundColor(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxChart.GetOption", identifier, "containerBackgroundColor");
        }
        public static void SetContainerBackgroundColor(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxChart.SetOption", identifier, "containerBackgroundColor", value);
        }
        public static object GetCrosshair(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxChart.GetOption", identifier, "crosshair");
        }
        public static void SetCrosshair(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxChart.SetOption", identifier, "crosshair", value);
        }
        public static object GetDataPrepareSettings(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxChart.GetOption", identifier, "dataPrepareSettings");
        }
        public static void SetDataPrepareSettings(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxChart.SetOption", identifier, "dataPrepareSettings", value);
        }
        public static string GetDefaultPane(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxChart.GetOption", identifier, "defaultPane");
        }
        public static void SetDefaultPane(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxChart.SetOption", identifier, "defaultPane", value);
        }
        public static bool? GetEqualBarWidth(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxChart.GetOption", identifier, "equalBarWidth");
        }
        public static void SetEqualBarWidth(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxChart.SetOption", identifier, "equalBarWidth", value);
        }
        public static new object GetLegend(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxChart.GetOption", identifier, "legend");
        }
        public static new void SetLegend(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxChart.SetOption", identifier, "legend", value);
        }
        public static float? GetMaxBubbleSize(string identifier)
        {
            return RegisteredFunction.Invoke<float?>("BlazorDevExtreme.DxChart.GetOption", identifier, "maxBubbleSize");
        }
        public static void SetMaxBubbleSize(string identifier, float? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxChart.SetOption", identifier, "maxBubbleSize", value);
        }
        public static float? GetMinBubbleSize(string identifier)
        {
            return RegisteredFunction.Invoke<float?>("BlazorDevExtreme.DxChart.GetOption", identifier, "minBubbleSize");
        }
        public static void SetMinBubbleSize(string identifier, float? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxChart.SetOption", identifier, "minBubbleSize", value);
        }
        public static bool? GetNegativesAsZeroes(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxChart.GetOption", identifier, "negativesAsZeroes");
        }
        public static void SetNegativesAsZeroes(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxChart.SetOption", identifier, "negativesAsZeroes", value);
        }
        public static object GetPanes(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxChart.GetOption", identifier, "panes");
        }
        public static void SetPanes(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxChart.SetOption", identifier, "panes", value);
        }
        public static string GetResolveLabelOverlapping(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxChart.GetOption", identifier, "resolveLabelOverlapping");
        }
        public static void SetResolveLabelOverlapping(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxChart.SetOption", identifier, "resolveLabelOverlapping", value);
        }
        public static bool? GetRotated(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxChart.GetOption", identifier, "rotated");
        }
        public static void SetRotated(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxChart.SetOption", identifier, "rotated", value);
        }
        public static object GetScrollBar(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxChart.GetOption", identifier, "scrollBar");
        }
        public static void SetScrollBar(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxChart.SetOption", identifier, "scrollBar", value);
        }
        public static string GetScrollingMode(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxChart.GetOption", identifier, "scrollingMode");
        }
        public static void SetScrollingMode(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxChart.SetOption", identifier, "scrollingMode", value);
        }
        public static new object GetSeries(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxChart.GetOption", identifier, "series");
        }
        public static new void SetSeries(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxChart.SetOption", identifier, "series", value);
        }
        public static string GetSeriesSelectionMode(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxChart.GetOption", identifier, "seriesSelectionMode");
        }
        public static void SetSeriesSelectionMode(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxChart.SetOption", identifier, "seriesSelectionMode", value);
        }
        public static object GetSeriesTemplate(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxChart.GetOption", identifier, "seriesTemplate");
        }
        public static void SetSeriesTemplate(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxChart.SetOption", identifier, "seriesTemplate", value);
        }
        public static bool? GetSynchronizeMultiAxes(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxChart.GetOption", identifier, "synchronizeMultiAxes");
        }
        public static void SetSynchronizeMultiAxes(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxChart.SetOption", identifier, "synchronizeMultiAxes", value);
        }
        public static new object GetTooltip(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxChart.GetOption", identifier, "tooltip");
        }
        public static new void SetTooltip(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxChart.SetOption", identifier, "tooltip", value);
        }
        public static bool? GetUseAggregation(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxChart.GetOption", identifier, "useAggregation");
        }
        public static void SetUseAggregation(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxChart.SetOption", identifier, "useAggregation", value);
        }
        public static object GetValueAxis(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxChart.GetOption", identifier, "valueAxis");
        }
        public static void SetValueAxis(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxChart.SetOption", identifier, "valueAxis", value);
        }
        public static string GetZoomingMode(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxChart.GetOption", identifier, "zoomingMode");
        }
        public static void SetZoomingMode(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxChart.SetOption", identifier, "zoomingMode", value);
        }
        public static void ZoomArgument(string identifier, object startValue, object endValue)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxChart.zoomArgument_0", identifier, startValue, endValue);
        }
    }
    public class DxPieChartInterop : BaseChartInterop
    {
        public static event EventHandler<JQueryEventArgs> LegendClick;
        public static void Init(string identifier, DevExpress.Viz.Charts.DxPieChartOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPieChart.Init", identifier, json);
        }
        public static void OnLegendClick(string identifier)
        {
            LegendClick?.Invoke(null, new JQueryEventArgs(identifier));
        }
        public static new object GetAdaptiveLayout(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPieChart.GetOption", identifier, "adaptiveLayout");
        }
        public static new void SetAdaptiveLayout(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPieChart.SetOption", identifier, "adaptiveLayout", value);
        }
        public static object GetCommonSeriesSettings(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPieChart.GetOption", identifier, "commonSeriesSettings");
        }
        public static void SetCommonSeriesSettings(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPieChart.SetOption", identifier, "commonSeriesSettings", value);
        }
        public static float? GetDiameter(string identifier)
        {
            return RegisteredFunction.Invoke<float?>("BlazorDevExtreme.DxPieChart.GetOption", identifier, "diameter");
        }
        public static void SetDiameter(string identifier, float? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPieChart.SetOption", identifier, "diameter", value);
        }
        public static float? GetInnerRadius(string identifier)
        {
            return RegisteredFunction.Invoke<float?>("BlazorDevExtreme.DxPieChart.GetOption", identifier, "innerRadius");
        }
        public static void SetInnerRadius(string identifier, float? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPieChart.SetOption", identifier, "innerRadius", value);
        }
        public static new object GetLegend(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPieChart.GetOption", identifier, "legend");
        }
        public static new void SetLegend(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPieChart.SetOption", identifier, "legend", value);
        }
        public static float? GetMinDiameter(string identifier)
        {
            return RegisteredFunction.Invoke<float?>("BlazorDevExtreme.DxPieChart.GetOption", identifier, "minDiameter");
        }
        public static void SetMinDiameter(string identifier, float? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPieChart.SetOption", identifier, "minDiameter", value);
        }
        public static new object GetPalette(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPieChart.GetOption", identifier, "palette");
        }
        public static new void SetPalette(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPieChart.SetOption", identifier, "palette", value);
        }
        public static string GetResolveLabelOverlapping(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxPieChart.GetOption", identifier, "resolveLabelOverlapping");
        }
        public static void SetResolveLabelOverlapping(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPieChart.SetOption", identifier, "resolveLabelOverlapping", value);
        }
        public static string GetSegmentsDirection(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxPieChart.GetOption", identifier, "segmentsDirection");
        }
        public static void SetSegmentsDirection(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPieChart.SetOption", identifier, "segmentsDirection", value);
        }
        public static new object GetSeries(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPieChart.GetOption", identifier, "series");
        }
        public static new void SetSeries(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPieChart.SetOption", identifier, "series", value);
        }
        public static object GetSeriesTemplate(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPieChart.GetOption", identifier, "seriesTemplate");
        }
        public static void SetSeriesTemplate(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPieChart.SetOption", identifier, "seriesTemplate", value);
        }
        public static string GetSizeGroup(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxPieChart.GetOption", identifier, "sizeGroup");
        }
        public static void SetSizeGroup(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPieChart.SetOption", identifier, "sizeGroup", value);
        }
        public static float? GetStartAngle(string identifier)
        {
            return RegisteredFunction.Invoke<float?>("BlazorDevExtreme.DxPieChart.GetOption", identifier, "startAngle");
        }
        public static void SetStartAngle(string identifier, float? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPieChart.SetOption", identifier, "startAngle", value);
        }
        public static string GetType(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxPieChart.GetOption", identifier, "type");
        }
        public static void SetType(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPieChart.SetOption", identifier, "type", value);
        }
        public static object GetSeriesEx(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPieChart.getSeries_0", identifier);
        }
        public static object GetSeriesByName(string identifier, object seriesName)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPieChart.getSeriesByName_1", identifier, seriesName);
        }
        public static object GetSeriesByPos(string identifier, float seriesIndex)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPieChart.getSeriesByPos_2", identifier, seriesIndex);
        }
    }
    public class DxPolarChartInterop : BaseChartInterop
    {
        public static event EventHandler<JQueryEventArgs> ArgumentAxisClick;
        public static event EventHandler<JQueryEventArgs> LegendClick;
        public static event EventHandler<JQueryEventArgs> SeriesClick;
        public static event EventHandler<JQueryEventArgs> SeriesHoverChanged;
        public static event EventHandler<JQueryEventArgs> SeriesSelectionChanged;
        public static void Init(string identifier, DevExpress.Viz.Charts.DxPolarChartOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPolarChart.Init", identifier, json);
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
        public static new object GetAdaptiveLayout(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPolarChart.GetOption", identifier, "adaptiveLayout");
        }
        public static new void SetAdaptiveLayout(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPolarChart.SetOption", identifier, "adaptiveLayout", value);
        }
        public static object GetArgumentAxis(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPolarChart.GetOption", identifier, "argumentAxis");
        }
        public static void SetArgumentAxis(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPolarChart.SetOption", identifier, "argumentAxis", value);
        }
        public static float? GetBarGroupPadding(string identifier)
        {
            return RegisteredFunction.Invoke<float?>("BlazorDevExtreme.DxPolarChart.GetOption", identifier, "barGroupPadding");
        }
        public static void SetBarGroupPadding(string identifier, float? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPolarChart.SetOption", identifier, "barGroupPadding", value);
        }
        public static float? GetBarGroupWidth(string identifier)
        {
            return RegisteredFunction.Invoke<float?>("BlazorDevExtreme.DxPolarChart.GetOption", identifier, "barGroupWidth");
        }
        public static void SetBarGroupWidth(string identifier, float? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPolarChart.SetOption", identifier, "barGroupWidth", value);
        }
        public static float? GetBarWidth(string identifier)
        {
            return RegisteredFunction.Invoke<float?>("BlazorDevExtreme.DxPolarChart.GetOption", identifier, "barWidth");
        }
        public static void SetBarWidth(string identifier, float? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPolarChart.SetOption", identifier, "barWidth", value);
        }
        public static object GetCommonAxisSettings(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPolarChart.GetOption", identifier, "commonAxisSettings");
        }
        public static void SetCommonAxisSettings(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPolarChart.SetOption", identifier, "commonAxisSettings", value);
        }
        public static object GetCommonSeriesSettings(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPolarChart.GetOption", identifier, "commonSeriesSettings");
        }
        public static void SetCommonSeriesSettings(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPolarChart.SetOption", identifier, "commonSeriesSettings", value);
        }
        public static string GetContainerBackgroundColor(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxPolarChart.GetOption", identifier, "containerBackgroundColor");
        }
        public static void SetContainerBackgroundColor(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPolarChart.SetOption", identifier, "containerBackgroundColor", value);
        }
        public static object GetDataPrepareSettings(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPolarChart.GetOption", identifier, "dataPrepareSettings");
        }
        public static void SetDataPrepareSettings(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPolarChart.SetOption", identifier, "dataPrepareSettings", value);
        }
        public static bool? GetEqualBarWidth(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxPolarChart.GetOption", identifier, "equalBarWidth");
        }
        public static void SetEqualBarWidth(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPolarChart.SetOption", identifier, "equalBarWidth", value);
        }
        public static new object GetLegend(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPolarChart.GetOption", identifier, "legend");
        }
        public static new void SetLegend(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPolarChart.SetOption", identifier, "legend", value);
        }
        public static bool? GetNegativesAsZeroes(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxPolarChart.GetOption", identifier, "negativesAsZeroes");
        }
        public static void SetNegativesAsZeroes(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPolarChart.SetOption", identifier, "negativesAsZeroes", value);
        }
        public static string GetResolveLabelOverlapping(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxPolarChart.GetOption", identifier, "resolveLabelOverlapping");
        }
        public static void SetResolveLabelOverlapping(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPolarChart.SetOption", identifier, "resolveLabelOverlapping", value);
        }
        public static new object GetSeries(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPolarChart.GetOption", identifier, "series");
        }
        public static new void SetSeries(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPolarChart.SetOption", identifier, "series", value);
        }
        public static string GetSeriesSelectionMode(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxPolarChart.GetOption", identifier, "seriesSelectionMode");
        }
        public static void SetSeriesSelectionMode(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPolarChart.SetOption", identifier, "seriesSelectionMode", value);
        }
        public static object GetSeriesTemplate(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPolarChart.GetOption", identifier, "seriesTemplate");
        }
        public static void SetSeriesTemplate(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPolarChart.SetOption", identifier, "seriesTemplate", value);
        }
        public static new object GetTooltip(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPolarChart.GetOption", identifier, "tooltip");
        }
        public static new void SetTooltip(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPolarChart.SetOption", identifier, "tooltip", value);
        }
        public static bool? GetUseSpiderWeb(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxPolarChart.GetOption", identifier, "useSpiderWeb");
        }
        public static void SetUseSpiderWeb(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPolarChart.SetOption", identifier, "useSpiderWeb", value);
        }
        public static object GetValueAxis(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPolarChart.GetOption", identifier, "valueAxis");
        }
        public static void SetValueAxis(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPolarChart.SetOption", identifier, "valueAxis", value);
        }
    }
    public class BaseChartInterop : BaseWidgetInterop
    {
        public static event EventHandler<JQueryEventArgs> Done;
        public static event EventHandler<JQueryEventArgs> PointClick;
        public static event EventHandler<JQueryEventArgs> PointHoverChanged;
        public static event EventHandler<JQueryEventArgs> PointSelectionChanged;
        public static event EventHandler<JQueryEventArgs> TooltipHidden;
        public static event EventHandler<JQueryEventArgs> TooltipShown;
        public static void Init(string identifier, DevExpress.Viz.Charts.BaseChartOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.BaseChart.Init", identifier, json);
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
        public static object GetAdaptiveLayout(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.BaseChart.GetOption", identifier, "adaptiveLayout");
        }
        public static void SetAdaptiveLayout(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.BaseChart.SetOption", identifier, "adaptiveLayout", value);
        }
        public static object GetAnimation(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.BaseChart.GetOption", identifier, "animation");
        }
        public static void SetAnimation(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.BaseChart.SetOption", identifier, "animation", value);
        }
        public static object GetCustomizeLabel(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.BaseChart.GetOption", identifier, "customizeLabel");
        }
        public static void SetCustomizeLabel(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.BaseChart.SetOption", identifier, "customizeLabel", value);
        }
        public static object GetCustomizePoint(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.BaseChart.GetOption", identifier, "customizePoint");
        }
        public static void SetCustomizePoint(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.BaseChart.SetOption", identifier, "customizePoint", value);
        }
        public static object GetDataSource(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.BaseChart.GetOption", identifier, "dataSource");
        }
        public static void SetDataSource(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.BaseChart.SetOption", identifier, "dataSource", value);
        }
        public static object GetLegend(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.BaseChart.GetOption", identifier, "legend");
        }
        public static void SetLegend(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.BaseChart.SetOption", identifier, "legend", value);
        }
        public static object GetPalette(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.BaseChart.GetOption", identifier, "palette");
        }
        public static void SetPalette(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.BaseChart.SetOption", identifier, "palette", value);
        }
        public static string GetPaletteExtensionMode(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.BaseChart.GetOption", identifier, "paletteExtensionMode");
        }
        public static void SetPaletteExtensionMode(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.BaseChart.SetOption", identifier, "paletteExtensionMode", value);
        }
        public static string GetPointSelectionMode(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.BaseChart.GetOption", identifier, "pointSelectionMode");
        }
        public static void SetPointSelectionMode(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.BaseChart.SetOption", identifier, "pointSelectionMode", value);
        }
        public static object GetSeries(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.BaseChart.GetOption", identifier, "series");
        }
        public static void SetSeries(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.BaseChart.SetOption", identifier, "series", value);
        }
        public static new object GetTooltip(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.BaseChart.GetOption", identifier, "tooltip");
        }
        public static new void SetTooltip(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.BaseChart.SetOption", identifier, "tooltip", value);
        }
        public static void ClearSelection(string identifier)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.BaseChart.clearSelection_0", identifier);
        }
        public static object GetAllSeries(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.BaseChart.getAllSeries_1", identifier);
        }
        public static object GetDataSourceEx(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.BaseChart.getDataSource_2", identifier);
        }
        public static object GetSeriesByName(string identifier, object seriesName)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.BaseChart.getSeriesByName_3", identifier, seriesName);
        }
        public static object GetSeriesByPos(string identifier, float seriesIndex)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.BaseChart.getSeriesByPos_4", identifier, seriesIndex);
        }
        public static void HideTooltip(string identifier)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.BaseChart.hideTooltip_5", identifier);
        }
        public static void Render(string identifier)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.BaseChart.render_6", identifier);
        }
        public static void Render(string identifier, object renderOptions)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.BaseChart.render_7", identifier, renderOptions);
        }
    }
    public class DxExporterInterop : ComponentInterop
    {
        public static void Init(string identifier, DevExpress.Viz.DxExporterOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxExporter.Init", identifier, json);
        }
        public static object GetExportFormat(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxExporter.GetOption", identifier, "exportFormat");
        }
        public static void SetExportFormat(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxExporter.SetOption", identifier, "exportFormat", value);
        }
        public static string GetFileName(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxExporter.GetOption", identifier, "fileName");
        }
        public static void SetFileName(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxExporter.SetOption", identifier, "fileName", value);
        }
        public static bool? GetPrintingEnabled(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxExporter.GetOption", identifier, "printingEnabled");
        }
        public static void SetPrintingEnabled(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxExporter.SetOption", identifier, "printingEnabled", value);
        }
        public static string GetServerUrl(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxExporter.GetOption", identifier, "serverUrl");
        }
        public static void SetServerUrl(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxExporter.SetOption", identifier, "serverUrl", value);
        }
        public static bool? GetShowMenu(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxExporter.GetOption", identifier, "showMenu");
        }
        public static void SetShowMenu(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxExporter.SetOption", identifier, "showMenu", value);
        }
        public static string GetSourceContainer(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxExporter.GetOption", identifier, "sourceContainer");
        }
        public static void SetSourceContainer(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxExporter.SetOption", identifier, "sourceContainer", value);
        }
        public static void ExportTo(string identifier, string fileName, string format)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxExporter.exportTo_0", identifier, fileName, format);
        }
        public static void Print(string identifier)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxExporter.print_1", identifier);
        }
    }
    public class DxFunnelInterop : BaseWidgetInterop
    {
        public static event EventHandler<JQueryEventArgs> HoverChanged;
        public static event EventHandler<JQueryEventArgs> ItemClick;
        public static event EventHandler<JQueryEventArgs> LegendClick;
        public static event EventHandler<JQueryEventArgs> SelectionChanged;
        public static void Init(string identifier, DevExpress.Viz.Funnel.DxFunnelOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxFunnel.Init", identifier, json);
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
        public static object GetAdaptiveLayout(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxFunnel.GetOption", identifier, "adaptiveLayout");
        }
        public static void SetAdaptiveLayout(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxFunnel.SetOption", identifier, "adaptiveLayout", value);
        }
        public static string GetAlgorithm(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxFunnel.GetOption", identifier, "algorithm");
        }
        public static void SetAlgorithm(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxFunnel.SetOption", identifier, "algorithm", value);
        }
        public static string GetArgumentField(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxFunnel.GetOption", identifier, "argumentField");
        }
        public static void SetArgumentField(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxFunnel.SetOption", identifier, "argumentField", value);
        }
        public static string GetColorField(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxFunnel.GetOption", identifier, "colorField");
        }
        public static void SetColorField(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxFunnel.SetOption", identifier, "colorField", value);
        }
        public static object GetDataSource(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxFunnel.GetOption", identifier, "dataSource");
        }
        public static void SetDataSource(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxFunnel.SetOption", identifier, "dataSource", value);
        }
        public static bool? GetHoverEnabled(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxFunnel.GetOption", identifier, "hoverEnabled");
        }
        public static void SetHoverEnabled(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxFunnel.SetOption", identifier, "hoverEnabled", value);
        }
        public static bool? GetInverted(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxFunnel.GetOption", identifier, "inverted");
        }
        public static void SetInverted(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxFunnel.SetOption", identifier, "inverted", value);
        }
        public static object GetItem(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxFunnel.GetOption", identifier, "item");
        }
        public static void SetItem(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxFunnel.SetOption", identifier, "item", value);
        }
        public static object GetLabel(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxFunnel.GetOption", identifier, "label");
        }
        public static void SetLabel(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxFunnel.SetOption", identifier, "label", value);
        }
        public static object GetLegend(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxFunnel.GetOption", identifier, "legend");
        }
        public static void SetLegend(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxFunnel.SetOption", identifier, "legend", value);
        }
        public static float? GetNeckHeight(string identifier)
        {
            return RegisteredFunction.Invoke<float?>("BlazorDevExtreme.DxFunnel.GetOption", identifier, "neckHeight");
        }
        public static void SetNeckHeight(string identifier, float? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxFunnel.SetOption", identifier, "neckHeight", value);
        }
        public static float? GetNeckWidth(string identifier)
        {
            return RegisteredFunction.Invoke<float?>("BlazorDevExtreme.DxFunnel.GetOption", identifier, "neckWidth");
        }
        public static void SetNeckWidth(string identifier, float? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxFunnel.SetOption", identifier, "neckWidth", value);
        }
        public static object GetPalette(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxFunnel.GetOption", identifier, "palette");
        }
        public static void SetPalette(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxFunnel.SetOption", identifier, "palette", value);
        }
        public static string GetPaletteExtensionMode(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxFunnel.GetOption", identifier, "paletteExtensionMode");
        }
        public static void SetPaletteExtensionMode(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxFunnel.SetOption", identifier, "paletteExtensionMode", value);
        }
        public static string GetSelectionMode(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxFunnel.GetOption", identifier, "selectionMode");
        }
        public static void SetSelectionMode(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxFunnel.SetOption", identifier, "selectionMode", value);
        }
        public static bool? GetSortData(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxFunnel.GetOption", identifier, "sortData");
        }
        public static void SetSortData(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxFunnel.SetOption", identifier, "sortData", value);
        }
        public static new object GetTooltip(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxFunnel.GetOption", identifier, "tooltip");
        }
        public static new void SetTooltip(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxFunnel.SetOption", identifier, "tooltip", value);
        }
        public static string GetValueField(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxFunnel.GetOption", identifier, "valueField");
        }
        public static void SetValueField(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxFunnel.SetOption", identifier, "valueField", value);
        }
        public static void ClearSelection(string identifier)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxFunnel.clearSelection_0", identifier);
        }
        public static object GetAllItems(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxFunnel.getAllItems_1", identifier);
        }
        public static object GetDataSourceEx(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxFunnel.getDataSource_2", identifier);
        }
        public static void HideTooltip(string identifier)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxFunnel.hideTooltip_3", identifier);
        }
    }
    public class BaseGaugeInterop : BaseWidgetInterop
    {
        public static event EventHandler<JQueryEventArgs> TooltipHidden;
        public static event EventHandler<JQueryEventArgs> TooltipShown;
        public static void Init(string identifier, DevExpress.Viz.Gauges.BaseGaugeOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.BaseGauge.Init", identifier, json);
        }
        public static void OnTooltipHidden(string identifier)
        {
            TooltipHidden?.Invoke(null, new JQueryEventArgs(identifier));
        }
        public static void OnTooltipShown(string identifier)
        {
            TooltipShown?.Invoke(null, new JQueryEventArgs(identifier));
        }
        public static object GetAnimation(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.BaseGauge.GetOption", identifier, "animation");
        }
        public static void SetAnimation(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.BaseGauge.SetOption", identifier, "animation", value);
        }
        public static string GetContainerBackgroundColor(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.BaseGauge.GetOption", identifier, "containerBackgroundColor");
        }
        public static void SetContainerBackgroundColor(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.BaseGauge.SetOption", identifier, "containerBackgroundColor", value);
        }
        public static object GetRangeContainer(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.BaseGauge.GetOption", identifier, "rangeContainer");
        }
        public static void SetRangeContainer(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.BaseGauge.SetOption", identifier, "rangeContainer", value);
        }
        public static object GetScale(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.BaseGauge.GetOption", identifier, "scale");
        }
        public static void SetScale(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.BaseGauge.SetOption", identifier, "scale", value);
        }
        public static object GetSubtitle(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.BaseGauge.GetOption", identifier, "subtitle");
        }
        public static void SetSubtitle(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.BaseGauge.SetOption", identifier, "subtitle", value);
        }
        public static object GetSubvalues(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.BaseGauge.GetOption", identifier, "subvalues");
        }
        public static void SetSubvalues(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.BaseGauge.SetOption", identifier, "subvalues", value);
        }
        public static new object GetTitle(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.BaseGauge.GetOption", identifier, "title");
        }
        public static new void SetTitle(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.BaseGauge.SetOption", identifier, "title", value);
        }
        public static new object GetTooltip(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.BaseGauge.GetOption", identifier, "tooltip");
        }
        public static new void SetTooltip(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.BaseGauge.SetOption", identifier, "tooltip", value);
        }
        public static float? GetValue(string identifier)
        {
            return RegisteredFunction.Invoke<float?>("BlazorDevExtreme.BaseGauge.GetOption", identifier, "value");
        }
        public static void SetValue(string identifier, float? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.BaseGauge.SetOption", identifier, "value", value);
        }
        public static object SubvaluesEx(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.BaseGauge.subvalues_0", identifier);
        }
        public static void SubvaluesEx(string identifier, object subvalues)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.BaseGauge.subvalues_1", identifier, subvalues);
        }
        public static float ValueEx(string identifier)
        {
            return RegisteredFunction.Invoke<float>("BlazorDevExtreme.BaseGauge.value_2", identifier);
        }
        public static void ValueEx(string identifier, float value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.BaseGauge.value_3", identifier, value);
        }
    }
    public class DxCircularGaugeInterop : BaseGaugeInterop
    {
        public static void Init(string identifier, DevExpress.Viz.Gauges.DxCircularGaugeOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxCircularGauge.Init", identifier, json);
        }
        public static object GetGeometry(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxCircularGauge.GetOption", identifier, "geometry");
        }
        public static void SetGeometry(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxCircularGauge.SetOption", identifier, "geometry", value);
        }
        public static new object GetRangeContainer(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxCircularGauge.GetOption", identifier, "rangeContainer");
        }
        public static new void SetRangeContainer(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxCircularGauge.SetOption", identifier, "rangeContainer", value);
        }
        public static new object GetScale(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxCircularGauge.GetOption", identifier, "scale");
        }
        public static new void SetScale(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxCircularGauge.SetOption", identifier, "scale", value);
        }
        public static object GetSubvalueIndicator(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxCircularGauge.GetOption", identifier, "subvalueIndicator");
        }
        public static void SetSubvalueIndicator(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxCircularGauge.SetOption", identifier, "subvalueIndicator", value);
        }
        public static object GetValueIndicator(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxCircularGauge.GetOption", identifier, "valueIndicator");
        }
        public static void SetValueIndicator(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxCircularGauge.SetOption", identifier, "valueIndicator", value);
        }
    }
    public class DxLinearGaugeInterop : BaseGaugeInterop
    {
        public static void Init(string identifier, DevExpress.Viz.Gauges.DxLinearGaugeOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxLinearGauge.Init", identifier, json);
        }
        public static object GetGeometry(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxLinearGauge.GetOption", identifier, "geometry");
        }
        public static void SetGeometry(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxLinearGauge.SetOption", identifier, "geometry", value);
        }
        public static new object GetRangeContainer(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxLinearGauge.GetOption", identifier, "rangeContainer");
        }
        public static new void SetRangeContainer(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxLinearGauge.SetOption", identifier, "rangeContainer", value);
        }
        public static new object GetScale(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxLinearGauge.GetOption", identifier, "scale");
        }
        public static new void SetScale(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxLinearGauge.SetOption", identifier, "scale", value);
        }
        public static object GetSubvalueIndicator(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxLinearGauge.GetOption", identifier, "subvalueIndicator");
        }
        public static void SetSubvalueIndicator(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxLinearGauge.SetOption", identifier, "subvalueIndicator", value);
        }
        public static object GetValueIndicator(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxLinearGauge.GetOption", identifier, "valueIndicator");
        }
        public static void SetValueIndicator(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxLinearGauge.SetOption", identifier, "valueIndicator", value);
        }
    }
    public class DxBarGaugeInterop : BaseWidgetInterop
    {
        public static event EventHandler<JQueryEventArgs> TooltipHidden;
        public static event EventHandler<JQueryEventArgs> TooltipShown;
        public static void Init(string identifier, DevExpress.Viz.Gauges.DxBarGaugeOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxBarGauge.Init", identifier, json);
        }
        public static void OnTooltipHidden(string identifier)
        {
            TooltipHidden?.Invoke(null, new JQueryEventArgs(identifier));
        }
        public static void OnTooltipShown(string identifier)
        {
            TooltipShown?.Invoke(null, new JQueryEventArgs(identifier));
        }
        public static object GetAnimation(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxBarGauge.GetOption", identifier, "animation");
        }
        public static void SetAnimation(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxBarGauge.SetOption", identifier, "animation", value);
        }
        public static string GetBackgroundColor(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxBarGauge.GetOption", identifier, "backgroundColor");
        }
        public static void SetBackgroundColor(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxBarGauge.SetOption", identifier, "backgroundColor", value);
        }
        public static float? GetBarSpacing(string identifier)
        {
            return RegisteredFunction.Invoke<float?>("BlazorDevExtreme.DxBarGauge.GetOption", identifier, "barSpacing");
        }
        public static void SetBarSpacing(string identifier, float? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxBarGauge.SetOption", identifier, "barSpacing", value);
        }
        public static float? GetBaseValue(string identifier)
        {
            return RegisteredFunction.Invoke<float?>("BlazorDevExtreme.DxBarGauge.GetOption", identifier, "baseValue");
        }
        public static void SetBaseValue(string identifier, float? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxBarGauge.SetOption", identifier, "baseValue", value);
        }
        public static float? GetEndValue(string identifier)
        {
            return RegisteredFunction.Invoke<float?>("BlazorDevExtreme.DxBarGauge.GetOption", identifier, "endValue");
        }
        public static void SetEndValue(string identifier, float? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxBarGauge.SetOption", identifier, "endValue", value);
        }
        public static object GetGeometry(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxBarGauge.GetOption", identifier, "geometry");
        }
        public static void SetGeometry(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxBarGauge.SetOption", identifier, "geometry", value);
        }
        public static object GetLabel(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxBarGauge.GetOption", identifier, "label");
        }
        public static void SetLabel(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxBarGauge.SetOption", identifier, "label", value);
        }
        public static object GetPalette(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxBarGauge.GetOption", identifier, "palette");
        }
        public static void SetPalette(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxBarGauge.SetOption", identifier, "palette", value);
        }
        public static string GetPaletteExtensionMode(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxBarGauge.GetOption", identifier, "paletteExtensionMode");
        }
        public static void SetPaletteExtensionMode(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxBarGauge.SetOption", identifier, "paletteExtensionMode", value);
        }
        public static float? GetRelativeInnerRadius(string identifier)
        {
            return RegisteredFunction.Invoke<float?>("BlazorDevExtreme.DxBarGauge.GetOption", identifier, "relativeInnerRadius");
        }
        public static void SetRelativeInnerRadius(string identifier, float? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxBarGauge.SetOption", identifier, "relativeInnerRadius", value);
        }
        public static float? GetStartValue(string identifier)
        {
            return RegisteredFunction.Invoke<float?>("BlazorDevExtreme.DxBarGauge.GetOption", identifier, "startValue");
        }
        public static void SetStartValue(string identifier, float? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxBarGauge.SetOption", identifier, "startValue", value);
        }
        public static object GetSubtitle(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxBarGauge.GetOption", identifier, "subtitle");
        }
        public static void SetSubtitle(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxBarGauge.SetOption", identifier, "subtitle", value);
        }
        public static new object GetTitle(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxBarGauge.GetOption", identifier, "title");
        }
        public static new void SetTitle(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxBarGauge.SetOption", identifier, "title", value);
        }
        public static new object GetTooltip(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxBarGauge.GetOption", identifier, "tooltip");
        }
        public static new void SetTooltip(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxBarGauge.SetOption", identifier, "tooltip", value);
        }
        public static object GetValues(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxBarGauge.GetOption", identifier, "values");
        }
        public static void SetValues(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxBarGauge.SetOption", identifier, "values", value);
        }
        public static object ValuesEx(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxBarGauge.values_0", identifier);
        }
        public static void ValuesEx(string identifier, object values)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxBarGauge.values_1", identifier, values);
        }
    }
    public class BaseSeriesObjectInterop
    {
        public static void ClearHover(string identifier)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.BaseSeriesObject.clearHover_0", identifier);
        }
        public static void ClearSelection(string identifier)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.BaseSeriesObject.clearSelection_1", identifier);
        }
        public static void DeselectPoint(string identifier, object point)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.BaseSeriesObject.deselectPoint_2", identifier, point);
        }
        public static object GetAllPoints(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.BaseSeriesObject.getAllPoints_3", identifier);
        }
        public static string GetColor(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.BaseSeriesObject.getColor_4", identifier);
        }
        public static object GetPointByPos(string identifier, float positionIndex)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.BaseSeriesObject.getPointByPos_5", identifier, positionIndex);
        }
        public static object GetPointsByArg(string identifier, object pointArg)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.BaseSeriesObject.getPointsByArg_6", identifier, pointArg);
        }
        public static object GetVisiblePoints(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.BaseSeriesObject.getVisiblePoints_7", identifier);
        }
        public static void Hide(string identifier)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.BaseSeriesObject.hide_8", identifier);
        }
        public static void Hover(string identifier)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.BaseSeriesObject.hover_9", identifier);
        }
        public static bool IsHovered(string identifier)
        {
            return RegisteredFunction.Invoke<bool>("BlazorDevExtreme.BaseSeriesObject.isHovered_10", identifier);
        }
        public static bool IsSelected(string identifier)
        {
            return RegisteredFunction.Invoke<bool>("BlazorDevExtreme.BaseSeriesObject.isSelected_11", identifier);
        }
        public static bool IsVisible(string identifier)
        {
            return RegisteredFunction.Invoke<bool>("BlazorDevExtreme.BaseSeriesObject.isVisible_12", identifier);
        }
        public static void Select(string identifier)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.BaseSeriesObject.select_13", identifier);
        }
        public static void SelectPoint(string identifier, object point)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.BaseSeriesObject.selectPoint_14", identifier, point);
        }
        public static void Show(string identifier)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.BaseSeriesObject.show_15", identifier);
        }
    }
    public class BasePointObjectInterop
    {
        public static void ClearHover(string identifier)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.BasePointObject.clearHover_0", identifier);
        }
        public static void ClearSelection(string identifier)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.BasePointObject.clearSelection_1", identifier);
        }
        public static string GetColor(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.BasePointObject.getColor_2", identifier);
        }
        public static object GetLabel(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.BasePointObject.getLabel_3", identifier);
        }
        public static void HideTooltip(string identifier)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.BasePointObject.hideTooltip_4", identifier);
        }
        public static void Hover(string identifier)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.BasePointObject.hover_5", identifier);
        }
        public static bool IsHovered(string identifier)
        {
            return RegisteredFunction.Invoke<bool>("BlazorDevExtreme.BasePointObject.isHovered_6", identifier);
        }
        public static bool IsSelected(string identifier)
        {
            return RegisteredFunction.Invoke<bool>("BlazorDevExtreme.BasePointObject.isSelected_7", identifier);
        }
        public static void Select(string identifier)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.BasePointObject.select_8", identifier);
        }
        public static void ShowTooltip(string identifier)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.BasePointObject.showTooltip_9", identifier);
        }
    }
    public class BaseLabelObjectInterop
    {
        public static object GetBoundingRect(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.BaseLabelObject.getBoundingRect_0", identifier);
        }
        public static void Hide(string identifier)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.BaseLabelObject.hide_1", identifier);
        }
        public static void Hide(string identifier, bool holdInvisible)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.BaseLabelObject.hide_2", identifier, holdInvisible);
        }
        public static bool IsVisible(string identifier)
        {
            return RegisteredFunction.Invoke<bool>("BlazorDevExtreme.BaseLabelObject.isVisible_3", identifier);
        }
        public static void Show(string identifier)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.BaseLabelObject.show_4", identifier);
        }
        public static void Show(string identifier, bool holdVisible)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.BaseLabelObject.show_5", identifier, holdVisible);
        }
    }
    public class ChartSeriesObjectInterop : BaseSeriesObjectInterop
    {
    }
    public class ChartPointObjectInterop : BasePointObjectInterop
    {
        public static object GetBoundingRect(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.ChartPointObject.getBoundingRect_0", identifier);
        }
    }
    public class DxFunnelItemInterop
    {
        public static string GetColor(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxFunnelItem.getColor_0", identifier);
        }
        public static void Hover(string identifier, bool state)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxFunnelItem.hover_1", identifier, state);
        }
        public static bool IsHovered(string identifier)
        {
            return RegisteredFunction.Invoke<bool>("BlazorDevExtreme.DxFunnelItem.isHovered_2", identifier);
        }
        public static bool IsSelected(string identifier)
        {
            return RegisteredFunction.Invoke<bool>("BlazorDevExtreme.DxFunnelItem.isSelected_3", identifier);
        }
        public static void Select(string identifier, bool state)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxFunnelItem.select_4", identifier, state);
        }
        public static void ShowTooltip(string identifier)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxFunnelItem.showTooltip_5", identifier);
        }
    }
    public class PiePointObjectInterop : BasePointObjectInterop
    {
        public static void Hide(string identifier)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.PiePointObject.hide_0", identifier);
        }
        public static void HideTooltip(string identifier)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.PiePointObject.hideTooltip_1", identifier);
        }
        public static bool IsVisible(string identifier)
        {
            return RegisteredFunction.Invoke<bool>("BlazorDevExtreme.PiePointObject.isVisible_2", identifier);
        }
        public static void Show(string identifier)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.PiePointObject.show_3", identifier);
        }
        public static void ShowTooltip(string identifier)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.PiePointObject.showTooltip_4", identifier);
        }
    }
    public class PieChartSeriesObjectInterop : BaseSeriesObjectInterop
    {
    }
    public class PolarChartSeriesObjectInterop : BaseSeriesObjectInterop
    {
    }
    public class PolarPointObjectInterop : BasePointObjectInterop
    {
    }
    public class DxTreeMapNodeInterop
    {
        public static void Customize(string identifier, object options)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeMapNode.customize_0", identifier, options);
        }
        public static void DrillDown(string identifier)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeMapNode.drillDown_1", identifier);
        }
        public static object GetAllChildren(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeMapNode.getAllChildren_2", identifier);
        }
        public static object GetAllNodes(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeMapNode.getAllNodes_3", identifier);
        }
        public static object GetChild(string identifier, float index)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeMapNode.getChild_4", identifier, index);
        }
        public static float GetChildrenCount(string identifier)
        {
            return RegisteredFunction.Invoke<float>("BlazorDevExtreme.DxTreeMapNode.getChildrenCount_5", identifier);
        }
        public static object GetParent(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeMapNode.getParent_6", identifier);
        }
        public static bool IsActive(string identifier)
        {
            return RegisteredFunction.Invoke<bool>("BlazorDevExtreme.DxTreeMapNode.isActive_7", identifier);
        }
        public static bool IsHovered(string identifier)
        {
            return RegisteredFunction.Invoke<bool>("BlazorDevExtreme.DxTreeMapNode.isHovered_8", identifier);
        }
        public static bool IsLeaf(string identifier)
        {
            return RegisteredFunction.Invoke<bool>("BlazorDevExtreme.DxTreeMapNode.isLeaf_9", identifier);
        }
        public static bool IsSelected(string identifier)
        {
            return RegisteredFunction.Invoke<bool>("BlazorDevExtreme.DxTreeMapNode.isSelected_10", identifier);
        }
        public static string Label(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxTreeMapNode.label_11", identifier);
        }
        public static void Label(string identifier, string label)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeMapNode.label_12", identifier, label);
        }
        public static void ResetCustomization(string identifier)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeMapNode.resetCustomization_13", identifier);
        }
        public static void Select(string identifier, bool state)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeMapNode.select_14", identifier, state);
        }
        public static void ShowTooltip(string identifier)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeMapNode.showTooltip_15", identifier);
        }
        public static float ValueEx(string identifier)
        {
            return RegisteredFunction.Invoke<float>("BlazorDevExtreme.DxTreeMapNode.value_16", identifier);
        }
    }
    public class MapLayerInterop
    {
        public static void ClearSelection(string identifier)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.MapLayer.clearSelection_0", identifier);
        }
        public static object GetDataSourceEx(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.MapLayer.getDataSource_1", identifier);
        }
        public static object GetElements(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.MapLayer.getElements_2", identifier);
        }
    }
    public class MapLayerElementInterop
    {
        public static void ApplySettings(string identifier, object settings)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.MapLayerElement.applySettings_0", identifier, settings);
        }
        public static object Attribute(string identifier, string name)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.MapLayerElement.attribute_1", identifier, name);
        }
        public static void Attribute(string identifier, string name, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.MapLayerElement.attribute_2", identifier, name, value);
        }
        public static object Coordinates(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.MapLayerElement.coordinates_3", identifier);
        }
        public static bool Selected(string identifier)
        {
            return RegisteredFunction.Invoke<bool>("BlazorDevExtreme.MapLayerElement.selected_4", identifier);
        }
        public static void Selected(string identifier, bool state)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.MapLayerElement.selected_5", identifier, state);
        }
    }
    public class AreaObjectsInterop
    {
        public static void ApplySettings(string identifier, object settings)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.AreaObjects.applySettings_0", identifier, settings);
        }
        public static object Attribute(string identifier, string name)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.AreaObjects.attribute_1", identifier, name);
        }
        public static bool Selected(string identifier)
        {
            return RegisteredFunction.Invoke<bool>("BlazorDevExtreme.AreaObjects.selected_2", identifier);
        }
        public static void Selected(string identifier, bool state)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.AreaObjects.selected_3", identifier, state);
        }
    }
    public class MarkerObjectsInterop
    {
        public static void ApplySettings(string identifier, object settings)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.MarkerObjects.applySettings_0", identifier, settings);
        }
        public static object Attribute(string identifier, string name)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.MarkerObjects.attribute_1", identifier, name);
        }
        public static object Coordinates(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.MarkerObjects.coordinates_2", identifier);
        }
        public static bool Selected(string identifier)
        {
            return RegisteredFunction.Invoke<bool>("BlazorDevExtreme.MarkerObjects.selected_3", identifier);
        }
        public static void Selected(string identifier, bool state)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.MarkerObjects.selected_4", identifier, state);
        }
    }
    public class DxRangeSelectorInterop : BaseWidgetInterop
    {
        public static event EventHandler<JQueryEventArgs> SelectedRangeChanged;
        public static event EventHandler<JQueryEventArgs> ValueChanged;
        public static void Init(string identifier, DevExpress.Viz.RangeSelector.DxRangeSelectorOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxRangeSelector.Init", identifier, json);
        }
        public static void OnSelectedRangeChanged(string identifier)
        {
            SelectedRangeChanged?.Invoke(null, new JQueryEventArgs(identifier));
        }
        public static void OnValueChanged(string identifier)
        {
            ValueChanged?.Invoke(null, new JQueryEventArgs(identifier));
        }
        public static object GetBackground(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxRangeSelector.GetOption", identifier, "background");
        }
        public static void SetBackground(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxRangeSelector.SetOption", identifier, "background", value);
        }
        public static object GetBehavior(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxRangeSelector.GetOption", identifier, "behavior");
        }
        public static void SetBehavior(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxRangeSelector.SetOption", identifier, "behavior", value);
        }
        public static object GetChart(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxRangeSelector.GetOption", identifier, "chart");
        }
        public static void SetChart(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxRangeSelector.SetOption", identifier, "chart", value);
        }
        public static string GetContainerBackgroundColor(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxRangeSelector.GetOption", identifier, "containerBackgroundColor");
        }
        public static void SetContainerBackgroundColor(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxRangeSelector.SetOption", identifier, "containerBackgroundColor", value);
        }
        public static object GetDataSource(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxRangeSelector.GetOption", identifier, "dataSource");
        }
        public static void SetDataSource(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxRangeSelector.SetOption", identifier, "dataSource", value);
        }
        public static string GetDataSourceField(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxRangeSelector.GetOption", identifier, "dataSourceField");
        }
        public static void SetDataSourceField(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxRangeSelector.SetOption", identifier, "dataSourceField", value);
        }
        public static object GetIndent(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxRangeSelector.GetOption", identifier, "indent");
        }
        public static void SetIndent(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxRangeSelector.SetOption", identifier, "indent", value);
        }
        public static object GetScale(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxRangeSelector.GetOption", identifier, "scale");
        }
        public static void SetScale(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxRangeSelector.SetOption", identifier, "scale", value);
        }
        public static object GetSelectedRange(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxRangeSelector.GetOption", identifier, "selectedRange");
        }
        public static void SetSelectedRange(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxRangeSelector.SetOption", identifier, "selectedRange", value);
        }
        public static string GetSelectedRangeColor(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxRangeSelector.GetOption", identifier, "selectedRangeColor");
        }
        public static void SetSelectedRangeColor(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxRangeSelector.SetOption", identifier, "selectedRangeColor", value);
        }
        public static object GetShutter(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxRangeSelector.GetOption", identifier, "shutter");
        }
        public static void SetShutter(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxRangeSelector.SetOption", identifier, "shutter", value);
        }
        public static object GetSliderHandle(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxRangeSelector.GetOption", identifier, "sliderHandle");
        }
        public static void SetSliderHandle(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxRangeSelector.SetOption", identifier, "sliderHandle", value);
        }
        public static object GetSliderMarker(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxRangeSelector.GetOption", identifier, "sliderMarker");
        }
        public static void SetSliderMarker(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxRangeSelector.SetOption", identifier, "sliderMarker", value);
        }
        public static object GetValue(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxRangeSelector.GetOption", identifier, "value");
        }
        public static void SetValue(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxRangeSelector.SetOption", identifier, "value", value);
        }
        public static object GetDataSourceEx(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxRangeSelector.getDataSource_0", identifier);
        }
        public static object GetSelectedRangeEx(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxRangeSelector.getSelectedRange_1", identifier);
        }
        public static object GetValueEx(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxRangeSelector.getValue_2", identifier);
        }
        public static void Render(string identifier)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxRangeSelector.render_3", identifier);
        }
        public static void Render(string identifier, bool skipChartAnimation)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxRangeSelector.render_4", identifier, skipChartAnimation);
        }
        public static void SetSelectedRangeEx(string identifier, object selectedRange)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxRangeSelector.setSelectedRange_5", identifier, selectedRange);
        }
        public static void SetValueEx(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxRangeSelector.setValue_6", identifier, value);
        }
    }
    public class BaseSparklineInterop : BaseWidgetInterop
    {
        public static event EventHandler<JQueryEventArgs> TooltipHidden;
        public static event EventHandler<JQueryEventArgs> TooltipShown;
        public static void Init(string identifier, DevExpress.Viz.Sparklines.BaseSparklineOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.BaseSparkline.Init", identifier, json);
        }
        public static void OnTooltipHidden(string identifier)
        {
            TooltipHidden?.Invoke(null, new JQueryEventArgs(identifier));
        }
        public static void OnTooltipShown(string identifier)
        {
            TooltipShown?.Invoke(null, new JQueryEventArgs(identifier));
        }
        public static new object GetTooltip(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.BaseSparkline.GetOption", identifier, "tooltip");
        }
        public static new void SetTooltip(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.BaseSparkline.SetOption", identifier, "tooltip", value);
        }
    }
    public class DxSparklineInterop : BaseSparklineInterop
    {
        public static void Init(string identifier, DevExpress.Viz.Sparklines.DxSparklineOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxSparkline.Init", identifier, json);
        }
        public static string GetArgumentField(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxSparkline.GetOption", identifier, "argumentField");
        }
        public static void SetArgumentField(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxSparkline.SetOption", identifier, "argumentField", value);
        }
        public static string GetBarNegativeColor(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxSparkline.GetOption", identifier, "barNegativeColor");
        }
        public static void SetBarNegativeColor(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxSparkline.SetOption", identifier, "barNegativeColor", value);
        }
        public static string GetBarPositiveColor(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxSparkline.GetOption", identifier, "barPositiveColor");
        }
        public static void SetBarPositiveColor(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxSparkline.SetOption", identifier, "barPositiveColor", value);
        }
        public static object GetDataSource(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxSparkline.GetOption", identifier, "dataSource");
        }
        public static void SetDataSource(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxSparkline.SetOption", identifier, "dataSource", value);
        }
        public static string GetFirstLastColor(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxSparkline.GetOption", identifier, "firstLastColor");
        }
        public static void SetFirstLastColor(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxSparkline.SetOption", identifier, "firstLastColor", value);
        }
        public static bool? GetIgnoreEmptyPoints(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxSparkline.GetOption", identifier, "ignoreEmptyPoints");
        }
        public static void SetIgnoreEmptyPoints(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxSparkline.SetOption", identifier, "ignoreEmptyPoints", value);
        }
        public static string GetLineColor(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxSparkline.GetOption", identifier, "lineColor");
        }
        public static void SetLineColor(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxSparkline.SetOption", identifier, "lineColor", value);
        }
        public static float? GetLineWidth(string identifier)
        {
            return RegisteredFunction.Invoke<float?>("BlazorDevExtreme.DxSparkline.GetOption", identifier, "lineWidth");
        }
        public static void SetLineWidth(string identifier, float? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxSparkline.SetOption", identifier, "lineWidth", value);
        }
        public static string GetLossColor(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxSparkline.GetOption", identifier, "lossColor");
        }
        public static void SetLossColor(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxSparkline.SetOption", identifier, "lossColor", value);
        }
        public static string GetMaxColor(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxSparkline.GetOption", identifier, "maxColor");
        }
        public static void SetMaxColor(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxSparkline.SetOption", identifier, "maxColor", value);
        }
        public static float? GetMaxValue(string identifier)
        {
            return RegisteredFunction.Invoke<float?>("BlazorDevExtreme.DxSparkline.GetOption", identifier, "maxValue");
        }
        public static void SetMaxValue(string identifier, float? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxSparkline.SetOption", identifier, "maxValue", value);
        }
        public static string GetMinColor(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxSparkline.GetOption", identifier, "minColor");
        }
        public static void SetMinColor(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxSparkline.SetOption", identifier, "minColor", value);
        }
        public static float? GetMinValue(string identifier)
        {
            return RegisteredFunction.Invoke<float?>("BlazorDevExtreme.DxSparkline.GetOption", identifier, "minValue");
        }
        public static void SetMinValue(string identifier, float? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxSparkline.SetOption", identifier, "minValue", value);
        }
        public static string GetPointColor(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxSparkline.GetOption", identifier, "pointColor");
        }
        public static void SetPointColor(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxSparkline.SetOption", identifier, "pointColor", value);
        }
        public static float? GetPointSize(string identifier)
        {
            return RegisteredFunction.Invoke<float?>("BlazorDevExtreme.DxSparkline.GetOption", identifier, "pointSize");
        }
        public static void SetPointSize(string identifier, float? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxSparkline.SetOption", identifier, "pointSize", value);
        }
        public static string GetPointSymbol(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxSparkline.GetOption", identifier, "pointSymbol");
        }
        public static void SetPointSymbol(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxSparkline.SetOption", identifier, "pointSymbol", value);
        }
        public static bool? GetShowFirstLast(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxSparkline.GetOption", identifier, "showFirstLast");
        }
        public static void SetShowFirstLast(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxSparkline.SetOption", identifier, "showFirstLast", value);
        }
        public static bool? GetShowMinMax(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxSparkline.GetOption", identifier, "showMinMax");
        }
        public static void SetShowMinMax(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxSparkline.SetOption", identifier, "showMinMax", value);
        }
        public static string GetType(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxSparkline.GetOption", identifier, "type");
        }
        public static void SetType(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxSparkline.SetOption", identifier, "type", value);
        }
        public static string GetValueField(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxSparkline.GetOption", identifier, "valueField");
        }
        public static void SetValueField(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxSparkline.SetOption", identifier, "valueField", value);
        }
        public static string GetWinColor(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxSparkline.GetOption", identifier, "winColor");
        }
        public static void SetWinColor(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxSparkline.SetOption", identifier, "winColor", value);
        }
        public static float? GetWinlossThreshold(string identifier)
        {
            return RegisteredFunction.Invoke<float?>("BlazorDevExtreme.DxSparkline.GetOption", identifier, "winlossThreshold");
        }
        public static void SetWinlossThreshold(string identifier, float? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxSparkline.SetOption", identifier, "winlossThreshold", value);
        }
        public static object GetDataSourceEx(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxSparkline.getDataSource_0", identifier);
        }
    }
    public class DxBulletInterop : BaseSparklineInterop
    {
        public static void Init(string identifier, DevExpress.Viz.Sparklines.DxBulletOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxBullet.Init", identifier, json);
        }
        public static string GetColor(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxBullet.GetOption", identifier, "color");
        }
        public static void SetColor(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxBullet.SetOption", identifier, "color", value);
        }
        public static float? GetEndScaleValue(string identifier)
        {
            return RegisteredFunction.Invoke<float?>("BlazorDevExtreme.DxBullet.GetOption", identifier, "endScaleValue");
        }
        public static void SetEndScaleValue(string identifier, float? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxBullet.SetOption", identifier, "endScaleValue", value);
        }
        public static bool? GetShowTarget(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxBullet.GetOption", identifier, "showTarget");
        }
        public static void SetShowTarget(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxBullet.SetOption", identifier, "showTarget", value);
        }
        public static bool? GetShowZeroLevel(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxBullet.GetOption", identifier, "showZeroLevel");
        }
        public static void SetShowZeroLevel(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxBullet.SetOption", identifier, "showZeroLevel", value);
        }
        public static float? GetStartScaleValue(string identifier)
        {
            return RegisteredFunction.Invoke<float?>("BlazorDevExtreme.DxBullet.GetOption", identifier, "startScaleValue");
        }
        public static void SetStartScaleValue(string identifier, float? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxBullet.SetOption", identifier, "startScaleValue", value);
        }
        public static float? GetTarget(string identifier)
        {
            return RegisteredFunction.Invoke<float?>("BlazorDevExtreme.DxBullet.GetOption", identifier, "target");
        }
        public static void SetTarget(string identifier, float? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxBullet.SetOption", identifier, "target", value);
        }
        public static string GetTargetColor(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxBullet.GetOption", identifier, "targetColor");
        }
        public static void SetTargetColor(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxBullet.SetOption", identifier, "targetColor", value);
        }
        public static float? GetTargetWidth(string identifier)
        {
            return RegisteredFunction.Invoke<float?>("BlazorDevExtreme.DxBullet.GetOption", identifier, "targetWidth");
        }
        public static void SetTargetWidth(string identifier, float? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxBullet.SetOption", identifier, "targetWidth", value);
        }
        public static float? GetValue(string identifier)
        {
            return RegisteredFunction.Invoke<float?>("BlazorDevExtreme.DxBullet.GetOption", identifier, "value");
        }
        public static void SetValue(string identifier, float? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxBullet.SetOption", identifier, "value", value);
        }
    }
    public class DxTreeMapInterop : BaseWidgetInterop
    {
        public static event EventHandler<JQueryEventArgs> Click;
        public static event EventHandler<JQueryEventArgs> Drill;
        public static event EventHandler<JQueryEventArgs> HoverChanged;
        public static event EventHandler<JQueryEventArgs> NodesInitialized;
        public static event EventHandler<JQueryEventArgs> NodesRendering;
        public static event EventHandler<JQueryEventArgs> SelectionChanged;
        public static void Init(string identifier, DevExpress.Viz.TreeMap.DxTreeMapOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeMap.Init", identifier, json);
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
        public static string GetChildrenField(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxTreeMap.GetOption", identifier, "childrenField");
        }
        public static void SetChildrenField(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeMap.SetOption", identifier, "childrenField", value);
        }
        public static string GetColorField(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxTreeMap.GetOption", identifier, "colorField");
        }
        public static void SetColorField(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeMap.SetOption", identifier, "colorField", value);
        }
        public static object GetColorizer(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeMap.GetOption", identifier, "colorizer");
        }
        public static void SetColorizer(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeMap.SetOption", identifier, "colorizer", value);
        }
        public static object GetDataSource(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeMap.GetOption", identifier, "dataSource");
        }
        public static void SetDataSource(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeMap.SetOption", identifier, "dataSource", value);
        }
        public static object GetGroup(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeMap.GetOption", identifier, "group");
        }
        public static void SetGroup(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeMap.SetOption", identifier, "group", value);
        }
        public static bool? GetHoverEnabled(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxTreeMap.GetOption", identifier, "hoverEnabled");
        }
        public static void SetHoverEnabled(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeMap.SetOption", identifier, "hoverEnabled", value);
        }
        public static string GetIdField(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxTreeMap.GetOption", identifier, "idField");
        }
        public static void SetIdField(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeMap.SetOption", identifier, "idField", value);
        }
        public static bool? GetInteractWithGroup(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxTreeMap.GetOption", identifier, "interactWithGroup");
        }
        public static void SetInteractWithGroup(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeMap.SetOption", identifier, "interactWithGroup", value);
        }
        public static string GetLabelField(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxTreeMap.GetOption", identifier, "labelField");
        }
        public static void SetLabelField(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeMap.SetOption", identifier, "labelField", value);
        }
        public static object GetLayoutAlgorithm(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeMap.GetOption", identifier, "layoutAlgorithm");
        }
        public static void SetLayoutAlgorithm(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeMap.SetOption", identifier, "layoutAlgorithm", value);
        }
        public static string GetLayoutDirection(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxTreeMap.GetOption", identifier, "layoutDirection");
        }
        public static void SetLayoutDirection(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeMap.SetOption", identifier, "layoutDirection", value);
        }
        public static float? GetMaxDepth(string identifier)
        {
            return RegisteredFunction.Invoke<float?>("BlazorDevExtreme.DxTreeMap.GetOption", identifier, "maxDepth");
        }
        public static void SetMaxDepth(string identifier, float? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeMap.SetOption", identifier, "maxDepth", value);
        }
        public static string GetParentField(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxTreeMap.GetOption", identifier, "parentField");
        }
        public static void SetParentField(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeMap.SetOption", identifier, "parentField", value);
        }
        public static string GetResolveLabelOverflow(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxTreeMap.GetOption", identifier, "resolveLabelOverflow");
        }
        public static void SetResolveLabelOverflow(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeMap.SetOption", identifier, "resolveLabelOverflow", value);
        }
        public static string GetSelectionMode(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxTreeMap.GetOption", identifier, "selectionMode");
        }
        public static void SetSelectionMode(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeMap.SetOption", identifier, "selectionMode", value);
        }
        public static object GetTile(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeMap.GetOption", identifier, "tile");
        }
        public static void SetTile(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeMap.SetOption", identifier, "tile", value);
        }
        public static new object GetTooltip(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeMap.GetOption", identifier, "tooltip");
        }
        public static new void SetTooltip(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeMap.SetOption", identifier, "tooltip", value);
        }
        public static string GetValueField(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxTreeMap.GetOption", identifier, "valueField");
        }
        public static void SetValueField(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeMap.SetOption", identifier, "valueField", value);
        }
        public static void ClearSelection(string identifier)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeMap.clearSelection_0", identifier);
        }
        public static void DrillUp(string identifier)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeMap.drillUp_1", identifier);
        }
        public static object GetCurrentNode(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeMap.getCurrentNode_2", identifier);
        }
        public static object GetDataSourceEx(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeMap.getDataSource_3", identifier);
        }
        public static object GetRootNode(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeMap.getRootNode_4", identifier);
        }
        public static void HideTooltip(string identifier)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeMap.hideTooltip_5", identifier);
        }
        public static void ResetDrillDown(string identifier)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeMap.resetDrillDown_6", identifier);
        }
    }
    public class DxVectorMapInterop : BaseWidgetInterop
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
        public static void Init(string identifier, DevExpress.Viz.Map.DxVectorMapOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxVectorMap.Init", identifier, json);
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
        public static object GetAreaSettings(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxVectorMap.GetOption", identifier, "areaSettings");
        }
        public static void SetAreaSettings(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxVectorMap.SetOption", identifier, "areaSettings", value);
        }
        public static object GetBackground(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxVectorMap.GetOption", identifier, "background");
        }
        public static void SetBackground(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxVectorMap.SetOption", identifier, "background", value);
        }
        public static object GetBounds(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxVectorMap.GetOption", identifier, "bounds");
        }
        public static void SetBounds(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxVectorMap.SetOption", identifier, "bounds", value);
        }
        public static object GetCenter(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxVectorMap.GetOption", identifier, "center");
        }
        public static void SetCenter(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxVectorMap.SetOption", identifier, "center", value);
        }
        public static object GetControlBar(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxVectorMap.GetOption", identifier, "controlBar");
        }
        public static void SetControlBar(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxVectorMap.SetOption", identifier, "controlBar", value);
        }
        public static object GetLayers(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxVectorMap.GetOption", identifier, "layers");
        }
        public static void SetLayers(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxVectorMap.SetOption", identifier, "layers", value);
        }
        public static object GetLegends(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxVectorMap.GetOption", identifier, "legends");
        }
        public static void SetLegends(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxVectorMap.SetOption", identifier, "legends", value);
        }
        public static object GetMapData(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxVectorMap.GetOption", identifier, "mapData");
        }
        public static void SetMapData(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxVectorMap.SetOption", identifier, "mapData", value);
        }
        public static object GetMarkers(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxVectorMap.GetOption", identifier, "markers");
        }
        public static void SetMarkers(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxVectorMap.SetOption", identifier, "markers", value);
        }
        public static object GetMarkerSettings(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxVectorMap.GetOption", identifier, "markerSettings");
        }
        public static void SetMarkerSettings(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxVectorMap.SetOption", identifier, "markerSettings", value);
        }
        public static float? GetMaxZoomFactor(string identifier)
        {
            return RegisteredFunction.Invoke<float?>("BlazorDevExtreme.DxVectorMap.GetOption", identifier, "maxZoomFactor");
        }
        public static void SetMaxZoomFactor(string identifier, float? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxVectorMap.SetOption", identifier, "maxZoomFactor", value);
        }
        public static bool? GetPanningEnabled(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxVectorMap.GetOption", identifier, "panningEnabled");
        }
        public static void SetPanningEnabled(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxVectorMap.SetOption", identifier, "panningEnabled", value);
        }
        public static object GetProjection(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxVectorMap.GetOption", identifier, "projection");
        }
        public static void SetProjection(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxVectorMap.SetOption", identifier, "projection", value);
        }
        public static new object GetTooltip(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxVectorMap.GetOption", identifier, "tooltip");
        }
        public static new void SetTooltip(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxVectorMap.SetOption", identifier, "tooltip", value);
        }
        public static bool? GetTouchEnabled(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxVectorMap.GetOption", identifier, "touchEnabled");
        }
        public static void SetTouchEnabled(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxVectorMap.SetOption", identifier, "touchEnabled", value);
        }
        public static bool? GetWheelEnabled(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxVectorMap.GetOption", identifier, "wheelEnabled");
        }
        public static void SetWheelEnabled(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxVectorMap.SetOption", identifier, "wheelEnabled", value);
        }
        public static float? GetZoomFactor(string identifier)
        {
            return RegisteredFunction.Invoke<float?>("BlazorDevExtreme.DxVectorMap.GetOption", identifier, "zoomFactor");
        }
        public static void SetZoomFactor(string identifier, float? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxVectorMap.SetOption", identifier, "zoomFactor", value);
        }
        public static bool? GetZoomingEnabled(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxVectorMap.GetOption", identifier, "zoomingEnabled");
        }
        public static void SetZoomingEnabled(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxVectorMap.SetOption", identifier, "zoomingEnabled", value);
        }
        public static object CenterEx(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxVectorMap.center_0", identifier);
        }
        public static void CenterEx(string identifier, object centerCoordinates)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxVectorMap.center_1", identifier, centerCoordinates);
        }
        public static void ClearAreaSelection(string identifier)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxVectorMap.clearAreaSelection_2", identifier);
        }
        public static void ClearMarkerSelection(string identifier)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxVectorMap.clearMarkerSelection_3", identifier);
        }
        public static void ClearSelection(string identifier)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxVectorMap.clearSelection_4", identifier);
        }
        public static object ConvertCoordinates(string identifier, float x, float y)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxVectorMap.convertCoordinates_5", identifier, x, y);
        }
        public static object GetAreas(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxVectorMap.getAreas_6", identifier);
        }
        public static object GetLayerByIndex(string identifier, float index)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxVectorMap.getLayerByIndex_7", identifier, index);
        }
        public static object GetLayerByName(string identifier, string name)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxVectorMap.getLayerByName_8", identifier, name);
        }
        public static object GetLayersEx(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxVectorMap.getLayers_9", identifier);
        }
        public static object GetMarkersEx(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxVectorMap.getMarkers_10", identifier);
        }
        public static object Viewport(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxVectorMap.viewport_11", identifier);
        }
        public static void Viewport(string identifier, object viewportCoordinates)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxVectorMap.viewport_12", identifier, viewportCoordinates);
        }
        public static float ZoomFactorEx(string identifier)
        {
            return RegisteredFunction.Invoke<float>("BlazorDevExtreme.DxVectorMap.zoomFactor_13", identifier);
        }
        public static void ZoomFactorEx(string identifier, float zoomFactor)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxVectorMap.zoomFactor_14", identifier, zoomFactor);
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
