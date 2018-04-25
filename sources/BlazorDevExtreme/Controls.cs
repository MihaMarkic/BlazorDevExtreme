using Microsoft.AspNetCore.Blazor.Browser.Interop;
using System;

namespace BlazorDevExtreme
{
    public static class DxAccordionInterop
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
        public static bool? GetFocusStateEnabled(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxAccordion.GetOption", identifier, "focusStateEnabled");
        }
        public static void SetFocusStateEnabled(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxAccordion.SetOption", identifier, "focusStateEnabled", value);
        }
        public static bool? GetHoverStateEnabled(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxAccordion.GetOption", identifier, "hoverStateEnabled");
        }
        public static void SetHoverStateEnabled(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxAccordion.SetOption", identifier, "hoverStateEnabled", value);
        }
        public static bool? GetMultiple(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxAccordion.GetOption", identifier, "multiple");
        }
        public static void SetMultiple(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxAccordion.SetOption", identifier, "multiple", value);
        }
        public static float? GetSelectedIndex(string identifier)
        {
            return RegisteredFunction.Invoke<float?>("BlazorDevExtreme.DxAccordion.GetOption", identifier, "selectedIndex");
        }
        public static void SetSelectedIndex(string identifier, float? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxAccordion.SetOption", identifier, "selectedIndex", value);
        }
    }
    public static class DxActionSheetInterop
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
        public static bool? GetVisible(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxActionSheet.GetOption", identifier, "visible");
        }
        public static void SetVisible(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxActionSheet.SetOption", identifier, "visible", value);
        }
    }
    public static class DxAutocompleteInterop
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
        public static float? GetMinSearchLength(string identifier)
        {
            return RegisteredFunction.Invoke<float?>("BlazorDevExtreme.DxAutocomplete.GetOption", identifier, "minSearchLength");
        }
        public static void SetMinSearchLength(string identifier, float? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxAutocomplete.SetOption", identifier, "minSearchLength", value);
        }
        public static string GetValue(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxAutocomplete.GetOption", identifier, "value");
        }
        public static void SetValue(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxAutocomplete.SetOption", identifier, "value", value);
        }
    }
    public static class DxBoxInterop
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
    public static class DxButtonInterop
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
        public static bool? GetActiveStateEnabled(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxButton.GetOption", identifier, "activeStateEnabled");
        }
        public static void SetActiveStateEnabled(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxButton.SetOption", identifier, "activeStateEnabled", value);
        }
        public static bool? GetFocusStateEnabled(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxButton.GetOption", identifier, "focusStateEnabled");
        }
        public static void SetFocusStateEnabled(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxButton.SetOption", identifier, "focusStateEnabled", value);
        }
        public static bool? GetHoverStateEnabled(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxButton.GetOption", identifier, "hoverStateEnabled");
        }
        public static void SetHoverStateEnabled(string identifier, bool? value)
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
    public static class DxCalendarInterop
    {
        public static void Init(string identifier, DevExpress.Ui.DxCalendarOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxCalendar.Init", identifier, json);
        }
        public static bool? GetActiveStateEnabled(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxCalendar.GetOption", identifier, "activeStateEnabled");
        }
        public static void SetActiveStateEnabled(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxCalendar.SetOption", identifier, "activeStateEnabled", value);
        }
        public static string GetDateSerializationFormat(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxCalendar.GetOption", identifier, "dateSerializationFormat");
        }
        public static void SetDateSerializationFormat(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxCalendar.SetOption", identifier, "dateSerializationFormat", value);
        }
        public static bool? GetFocusStateEnabled(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxCalendar.GetOption", identifier, "focusStateEnabled");
        }
        public static void SetFocusStateEnabled(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxCalendar.SetOption", identifier, "focusStateEnabled", value);
        }
        public static bool? GetHoverStateEnabled(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxCalendar.GetOption", identifier, "hoverStateEnabled");
        }
        public static void SetHoverStateEnabled(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxCalendar.SetOption", identifier, "hoverStateEnabled", value);
        }
        public static string GetMaxZoomLevel(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxCalendar.GetOption", identifier, "maxZoomLevel");
        }
        public static void SetMaxZoomLevel(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxCalendar.SetOption", identifier, "maxZoomLevel", value);
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
        public static string GetZoomLevel(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxCalendar.GetOption", identifier, "zoomLevel");
        }
        public static void SetZoomLevel(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxCalendar.SetOption", identifier, "zoomLevel", value);
        }
    }
    public static class DxCheckBoxInterop
    {
        public static void Init(string identifier, DevExpress.Ui.DxCheckBoxOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxCheckBox.Init", identifier, json);
        }
        public static bool? GetActiveStateEnabled(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxCheckBox.GetOption", identifier, "activeStateEnabled");
        }
        public static void SetActiveStateEnabled(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxCheckBox.SetOption", identifier, "activeStateEnabled", value);
        }
        public static bool? GetFocusStateEnabled(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxCheckBox.GetOption", identifier, "focusStateEnabled");
        }
        public static void SetFocusStateEnabled(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxCheckBox.SetOption", identifier, "focusStateEnabled", value);
        }
        public static bool? GetHoverStateEnabled(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxCheckBox.GetOption", identifier, "hoverStateEnabled");
        }
        public static void SetHoverStateEnabled(string identifier, bool? value)
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
        public static bool? GetValue(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxCheckBox.GetOption", identifier, "value");
        }
        public static void SetValue(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxCheckBox.SetOption", identifier, "value", value);
        }
    }
    public static class DxColorBoxInterop
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
        public static string GetApplyValueMode(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxColorBox.GetOption", identifier, "applyValueMode");
        }
        public static void SetApplyValueMode(string identifier, string value)
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
        public static float? GetKeyStep(string identifier)
        {
            return RegisteredFunction.Invoke<float?>("BlazorDevExtreme.DxColorBox.GetOption", identifier, "keyStep");
        }
        public static void SetKeyStep(string identifier, float? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxColorBox.SetOption", identifier, "keyStep", value);
        }
        public static string GetValue(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxColorBox.GetOption", identifier, "value");
        }
        public static void SetValue(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxColorBox.SetOption", identifier, "value", value);
        }
    }
    public static class DxContextMenuInterop
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
        public static string GetSubmenuDirection(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxContextMenu.GetOption", identifier, "submenuDirection");
        }
        public static void SetSubmenuDirection(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxContextMenu.SetOption", identifier, "submenuDirection", value);
        }
        public static bool? GetVisible(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxContextMenu.GetOption", identifier, "visible");
        }
        public static void SetVisible(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxContextMenu.SetOption", identifier, "visible", value);
        }
    }
    public static class DxDataGridInterop
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
    }
    public static class DxDateBoxInterop
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
        public static string GetMaxZoomLevel(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxDateBox.GetOption", identifier, "maxZoomLevel");
        }
        public static void SetMaxZoomLevel(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDateBox.SetOption", identifier, "maxZoomLevel", value);
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
        public static string GetPlaceholder(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxDateBox.GetOption", identifier, "placeholder");
        }
        public static void SetPlaceholder(string identifier, string value)
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
    }
    public static class DxDeferRenderingInterop
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
    public static class DxDropDownBoxInterop
    {
        public static void Init(string identifier, DevExpress.Ui.DxDropDownBoxOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDropDownBox.Init", identifier, json);
        }
        public static bool? GetAcceptCustomValue(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxDropDownBox.GetOption", identifier, "acceptCustomValue");
        }
        public static void SetAcceptCustomValue(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDropDownBox.SetOption", identifier, "acceptCustomValue", value);
        }
        public static string GetValueChangeEvent(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxDropDownBox.GetOption", identifier, "valueChangeEvent");
        }
        public static void SetValueChangeEvent(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDropDownBox.SetOption", identifier, "valueChangeEvent", value);
        }
    }
    public static class DxFileUploaderInterop
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
        public static bool? GetFocusStateEnabled(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxFileUploader.GetOption", identifier, "focusStateEnabled");
        }
        public static void SetFocusStateEnabled(string identifier, bool? value)
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
    }
    public static class DxFilterBuilderInterop
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
    }
    public static class DxFormInterop
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
        public static object GetColCountByScreen(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxForm.GetOption", identifier, "colCountByScreen");
        }
        public static void SetColCountByScreen(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxForm.SetOption", identifier, "colCountByScreen", value);
        }
        public static object GetFormData(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxForm.GetOption", identifier, "formData");
        }
        public static void SetFormData(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxForm.SetOption", identifier, "formData", value);
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
    }
    public static class DxGalleryInterop
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
        public static bool? GetFocusStateEnabled(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxGallery.GetOption", identifier, "focusStateEnabled");
        }
        public static void SetFocusStateEnabled(string identifier, bool? value)
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
        public static float? GetSelectedIndex(string identifier)
        {
            return RegisteredFunction.Invoke<float?>("BlazorDevExtreme.DxGallery.GetOption", identifier, "selectedIndex");
        }
        public static void SetSelectedIndex(string identifier, float? value)
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
    }
    public static class DxListInterop
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
        public static bool? GetActiveStateEnabled(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxList.GetOption", identifier, "activeStateEnabled");
        }
        public static void SetActiveStateEnabled(string identifier, bool? value)
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
        public static bool? GetFocusStateEnabled(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxList.GetOption", identifier, "focusStateEnabled");
        }
        public static void SetFocusStateEnabled(string identifier, bool? value)
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
        public static bool? GetHoverStateEnabled(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxList.GetOption", identifier, "hoverStateEnabled");
        }
        public static void SetHoverStateEnabled(string identifier, bool? value)
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
    }
    public static class DxLoadIndicatorInterop
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
    public static class DxLoadPanelInterop
    {
        public static void Init(string identifier, DevExpress.Ui.DxLoadPanelOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxLoadPanel.Init", identifier, json);
        }
        public static float? GetDelay(string identifier)
        {
            return RegisteredFunction.Invoke<float?>("BlazorDevExtreme.DxLoadPanel.GetOption", identifier, "delay");
        }
        public static void SetDelay(string identifier, float? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxLoadPanel.SetOption", identifier, "delay", value);
        }
        public static bool? GetFocusStateEnabled(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxLoadPanel.GetOption", identifier, "focusStateEnabled");
        }
        public static void SetFocusStateEnabled(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxLoadPanel.SetOption", identifier, "focusStateEnabled", value);
        }
        public static float? GetHeight(string identifier)
        {
            return RegisteredFunction.Invoke<float?>("BlazorDevExtreme.DxLoadPanel.GetOption", identifier, "height");
        }
        public static void SetHeight(string identifier, float? value)
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
        public static object GetShadingColor(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxLoadPanel.GetOption", identifier, "shadingColor");
        }
        public static void SetShadingColor(string identifier, object value)
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
        public static float? GetWidth(string identifier)
        {
            return RegisteredFunction.Invoke<float?>("BlazorDevExtreme.DxLoadPanel.GetOption", identifier, "width");
        }
        public static void SetWidth(string identifier, float? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxLoadPanel.SetOption", identifier, "width", value);
        }
    }
    public static class DxLookupInterop
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
        public static string GetApplyButtonText(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxLookup.GetOption", identifier, "applyButtonText");
        }
        public static void SetApplyButtonText(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxLookup.SetOption", identifier, "applyButtonText", value);
        }
        public static string GetApplyValueMode(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxLookup.GetOption", identifier, "applyValueMode");
        }
        public static void SetApplyValueMode(string identifier, string value)
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
        public static bool? GetFocusStateEnabled(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxLookup.GetOption", identifier, "focusStateEnabled");
        }
        public static void SetFocusStateEnabled(string identifier, bool? value)
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
        public static bool? GetGrouped(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxLookup.GetOption", identifier, "grouped");
        }
        public static void SetGrouped(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxLookup.SetOption", identifier, "grouped", value);
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
        public static string GetPlaceholder(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxLookup.GetOption", identifier, "placeholder");
        }
        public static void SetPlaceholder(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxLookup.SetOption", identifier, "placeholder", value);
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
        public static bool? GetSearchEnabled(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxLookup.GetOption", identifier, "searchEnabled");
        }
        public static void SetSearchEnabled(string identifier, bool? value)
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
        public static bool? GetShowClearButton(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxLookup.GetOption", identifier, "showClearButton");
        }
        public static void SetShowClearButton(string identifier, bool? value)
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
    public static class DxMapInterop
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
        public static bool? GetControls(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxMap.GetOption", identifier, "controls");
        }
        public static void SetControls(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxMap.SetOption", identifier, "controls", value);
        }
        public static bool? GetFocusStateEnabled(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxMap.GetOption", identifier, "focusStateEnabled");
        }
        public static void SetFocusStateEnabled(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxMap.SetOption", identifier, "focusStateEnabled", value);
        }
        public static object GetHeight(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxMap.GetOption", identifier, "height");
        }
        public static void SetHeight(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxMap.SetOption", identifier, "height", value);
        }
        public static string GetMarkerIconSrc(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxMap.GetOption", identifier, "markerIconSrc");
        }
        public static void SetMarkerIconSrc(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxMap.SetOption", identifier, "markerIconSrc", value);
        }
        public static string GetProvider(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxMap.GetOption", identifier, "provider");
        }
        public static void SetProvider(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxMap.SetOption", identifier, "provider", value);
        }
        public static string GetType(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxMap.GetOption", identifier, "type");
        }
        public static void SetType(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxMap.SetOption", identifier, "type", value);
        }
        public static object GetWidth(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxMap.GetOption", identifier, "width");
        }
        public static void SetWidth(string identifier, object value)
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
    }
    public static class DxMenuInterop
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
        public static string GetOrientation(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxMenu.GetOption", identifier, "orientation");
        }
        public static void SetOrientation(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxMenu.SetOption", identifier, "orientation", value);
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
    public static class DxMultiViewInterop
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
        public static bool? GetFocusStateEnabled(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxMultiView.GetOption", identifier, "focusStateEnabled");
        }
        public static void SetFocusStateEnabled(string identifier, bool? value)
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
        public static float? GetSelectedIndex(string identifier)
        {
            return RegisteredFunction.Invoke<float?>("BlazorDevExtreme.DxMultiView.GetOption", identifier, "selectedIndex");
        }
        public static void SetSelectedIndex(string identifier, float? value)
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
    public static class DxNavBarInterop
    {
        public static void Init(string identifier, DevExpress.Ui.DxNavBarOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxNavBar.Init", identifier, json);
        }
        public static object GetScrollByContent(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxNavBar.GetOption", identifier, "scrollByContent");
        }
        public static void SetScrollByContent(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxNavBar.SetOption", identifier, "scrollByContent", value);
        }
    }
    public static class DxNumberBoxInterop
    {
        public static void Init(string identifier, DevExpress.Ui.DxNumberBoxOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxNumberBox.Init", identifier, json);
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
        public static float? GetValue(string identifier)
        {
            return RegisteredFunction.Invoke<float?>("BlazorDevExtreme.DxNumberBox.GetOption", identifier, "value");
        }
        public static void SetValue(string identifier, float? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxNumberBox.SetOption", identifier, "value", value);
        }
    }
    public static class DxPanoramaInterop
    {
        public static void Init(string identifier, DevExpress.Ui.DxPanoramaOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPanorama.Init", identifier, json);
        }
        public static bool? GetFocusStateEnabled(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxPanorama.GetOption", identifier, "focusStateEnabled");
        }
        public static void SetFocusStateEnabled(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPanorama.SetOption", identifier, "focusStateEnabled", value);
        }
        public static float? GetSelectedIndex(string identifier)
        {
            return RegisteredFunction.Invoke<float?>("BlazorDevExtreme.DxPanorama.GetOption", identifier, "selectedIndex");
        }
        public static void SetSelectedIndex(string identifier, float? value)
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
    public static class DxPivotInterop
    {
        public static void Init(string identifier, DevExpress.Ui.DxPivotOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPivot.Init", identifier, json);
        }
        public static float? GetSelectedIndex(string identifier)
        {
            return RegisteredFunction.Invoke<float?>("BlazorDevExtreme.DxPivot.GetOption", identifier, "selectedIndex");
        }
        public static void SetSelectedIndex(string identifier, float? value)
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
    public static class DxPivotGridInterop
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
        public static bool? GetHideEmptySummaryCells(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxPivotGrid.GetOption", identifier, "hideEmptySummaryCells");
        }
        public static void SetHideEmptySummaryCells(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPivotGrid.SetOption", identifier, "hideEmptySummaryCells", value);
        }
        public static string GetRowHeaderLayout(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxPivotGrid.GetOption", identifier, "rowHeaderLayout");
        }
        public static void SetRowHeaderLayout(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPivotGrid.SetOption", identifier, "rowHeaderLayout", value);
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
        public static bool? GetWordWrapEnabled(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxPivotGrid.GetOption", identifier, "wordWrapEnabled");
        }
        public static void SetWordWrapEnabled(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPivotGrid.SetOption", identifier, "wordWrapEnabled", value);
        }
    }
    public static class DxPivotGridFieldChooserInterop
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
        public static object GetState(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPivotGridFieldChooser.GetOption", identifier, "state");
        }
        public static void SetState(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPivotGridFieldChooser.SetOption", identifier, "state", value);
        }
    }
    public static class DxPopoverInterop
    {
        public static void Init(string identifier, DevExpress.Ui.DxPopoverOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPopover.Init", identifier, json);
        }
        public static object GetCloseOnOutsideClick(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPopover.GetOption", identifier, "closeOnOutsideClick");
        }
        public static void SetCloseOnOutsideClick(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPopover.SetOption", identifier, "closeOnOutsideClick", value);
        }
        public static bool? GetShading(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxPopover.GetOption", identifier, "shading");
        }
        public static void SetShading(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPopover.SetOption", identifier, "shading", value);
        }
        public static bool? GetShowTitle(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxPopover.GetOption", identifier, "showTitle");
        }
        public static void SetShowTitle(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPopover.SetOption", identifier, "showTitle", value);
        }
    }
    public static class DxPopupInterop
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
        public static object GetAnimation(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPopup.GetOption", identifier, "animation");
        }
        public static void SetAnimation(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPopup.SetOption", identifier, "animation", value);
        }
        public static bool? GetDragEnabled(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxPopup.GetOption", identifier, "dragEnabled");
        }
        public static void SetDragEnabled(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPopup.SetOption", identifier, "dragEnabled", value);
        }
        public static bool? GetFocusStateEnabled(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxPopup.GetOption", identifier, "focusStateEnabled");
        }
        public static void SetFocusStateEnabled(string identifier, bool? value)
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
        public static object GetHeight(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPopup.GetOption", identifier, "height");
        }
        public static void SetHeight(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPopup.SetOption", identifier, "height", value);
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
        public static object GetWidth(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPopup.GetOption", identifier, "width");
        }
        public static void SetWidth(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPopup.SetOption", identifier, "width", value);
        }
    }
    public static class DxProgressBarInterop
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
        public static float? GetValue(string identifier)
        {
            return RegisteredFunction.Invoke<float?>("BlazorDevExtreme.DxProgressBar.GetOption", identifier, "value");
        }
        public static void SetValue(string identifier, float? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxProgressBar.SetOption", identifier, "value", value);
        }
    }
    public static class DxRadioGroupInterop
    {
        public static void Init(string identifier, DevExpress.Ui.DxRadioGroupOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxRadioGroup.Init", identifier, json);
        }
        public static bool? GetActiveStateEnabled(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxRadioGroup.GetOption", identifier, "activeStateEnabled");
        }
        public static void SetActiveStateEnabled(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxRadioGroup.SetOption", identifier, "activeStateEnabled", value);
        }
        public static bool? GetFocusStateEnabled(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxRadioGroup.GetOption", identifier, "focusStateEnabled");
        }
        public static void SetFocusStateEnabled(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxRadioGroup.SetOption", identifier, "focusStateEnabled", value);
        }
        public static bool? GetHoverStateEnabled(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxRadioGroup.GetOption", identifier, "hoverStateEnabled");
        }
        public static void SetHoverStateEnabled(string identifier, bool? value)
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
        public static object GetValue(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxRadioGroup.GetOption", identifier, "value");
        }
        public static void SetValue(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxRadioGroup.SetOption", identifier, "value", value);
        }
    }
    public static class DxRangeSliderInterop
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
        public static float GetValue(string identifier)
        {
            return RegisteredFunction.Invoke<float>("BlazorDevExtreme.DxRangeSlider.GetOption", identifier, "value");
        }
        public static void SetValue(string identifier, float value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxRangeSlider.SetOption", identifier, "value", value);
        }
    }
    public static class DxResizableInterop
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
        public static object GetHeight(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxResizable.GetOption", identifier, "height");
        }
        public static void SetHeight(string identifier, object value)
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
        public static object GetWidth(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxResizable.GetOption", identifier, "width");
        }
        public static void SetWidth(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxResizable.SetOption", identifier, "width", value);
        }
    }
    public static class DxResponsiveBoxInterop
    {
        public static void Init(string identifier, DevExpress.Ui.DxResponsiveBoxOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxResponsiveBox.Init", identifier, json);
        }
        public static object GetHeight(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxResponsiveBox.GetOption", identifier, "height");
        }
        public static void SetHeight(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxResponsiveBox.SetOption", identifier, "height", value);
        }
        public static string GetSingleColumnScreen(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxResponsiveBox.GetOption", identifier, "singleColumnScreen");
        }
        public static void SetSingleColumnScreen(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxResponsiveBox.SetOption", identifier, "singleColumnScreen", value);
        }
        public static object GetWidth(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxResponsiveBox.GetOption", identifier, "width");
        }
        public static void SetWidth(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxResponsiveBox.SetOption", identifier, "width", value);
        }
    }
    public static class DxSchedulerInterop
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
        public static string GetCurrentView(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxScheduler.GetOption", identifier, "currentView");
        }
        public static void SetCurrentView(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxScheduler.SetOption", identifier, "currentView", value);
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
        public static bool? GetFocusStateEnabled(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxScheduler.GetOption", identifier, "focusStateEnabled");
        }
        public static void SetFocusStateEnabled(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxScheduler.SetOption", identifier, "focusStateEnabled", value);
        }
        public static string GetGroups(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxScheduler.GetOption", identifier, "groups");
        }
        public static void SetGroups(string identifier, string value)
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
    }
    public static class DxScrollViewInterop
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
    }
    public static class DxSelectBoxInterop
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
        public static bool? GetAcceptCustomValue(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxSelectBox.GetOption", identifier, "acceptCustomValue");
        }
        public static void SetAcceptCustomValue(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxSelectBox.SetOption", identifier, "acceptCustomValue", value);
        }
        public static string GetPlaceholder(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxSelectBox.GetOption", identifier, "placeholder");
        }
        public static void SetPlaceholder(string identifier, string value)
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
        public static string GetValueChangeEvent(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxSelectBox.GetOption", identifier, "valueChangeEvent");
        }
        public static void SetValueChangeEvent(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxSelectBox.SetOption", identifier, "valueChangeEvent", value);
        }
    }
    public static class DxSlideOutInterop
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
        public static bool? GetActiveStateEnabled(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxSlideOut.GetOption", identifier, "activeStateEnabled");
        }
        public static void SetActiveStateEnabled(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxSlideOut.SetOption", identifier, "activeStateEnabled", value);
        }
        public static bool? GetMenuGrouped(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxSlideOut.GetOption", identifier, "menuGrouped");
        }
        public static void SetMenuGrouped(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxSlideOut.SetOption", identifier, "menuGrouped", value);
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
        public static float? GetSelectedIndex(string identifier)
        {
            return RegisteredFunction.Invoke<float?>("BlazorDevExtreme.DxSlideOut.GetOption", identifier, "selectedIndex");
        }
        public static void SetSelectedIndex(string identifier, float? value)
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
    }
    public static class DxSlideOutViewInterop
    {
        public static void Init(string identifier, DevExpress.Ui.DxSlideOutViewOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxSlideOutView.Init", identifier, json);
        }
        public static string GetMenuPosition(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxSlideOutView.GetOption", identifier, "menuPosition");
        }
        public static void SetMenuPosition(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxSlideOutView.SetOption", identifier, "menuPosition", value);
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
    }
    public static class DxSliderInterop
    {
        public static void Init(string identifier, DevExpress.Ui.DxSliderOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxSlider.Init", identifier, json);
        }
        public static float? GetValue(string identifier)
        {
            return RegisteredFunction.Invoke<float?>("BlazorDevExtreme.DxSlider.GetOption", identifier, "value");
        }
        public static void SetValue(string identifier, float? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxSlider.SetOption", identifier, "value", value);
        }
    }
    public static class DxSwitchInterop
    {
        public static void Init(string identifier, DevExpress.Ui.DxSwitchOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxSwitch.Init", identifier, json);
        }
        public static bool? GetActiveStateEnabled(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxSwitch.GetOption", identifier, "activeStateEnabled");
        }
        public static void SetActiveStateEnabled(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxSwitch.SetOption", identifier, "activeStateEnabled", value);
        }
        public static bool? GetFocusStateEnabled(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxSwitch.GetOption", identifier, "focusStateEnabled");
        }
        public static void SetFocusStateEnabled(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxSwitch.SetOption", identifier, "focusStateEnabled", value);
        }
        public static bool? GetHoverStateEnabled(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxSwitch.GetOption", identifier, "hoverStateEnabled");
        }
        public static void SetHoverStateEnabled(string identifier, bool? value)
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
        public static bool? GetValue(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxSwitch.GetOption", identifier, "value");
        }
        public static void SetValue(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxSwitch.SetOption", identifier, "value", value);
        }
    }
    public static class DxTabPanelInterop
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
        public static bool? GetAnimationEnabled(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxTabPanel.GetOption", identifier, "animationEnabled");
        }
        public static void SetAnimationEnabled(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTabPanel.SetOption", identifier, "animationEnabled", value);
        }
        public static bool? GetFocusStateEnabled(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxTabPanel.GetOption", identifier, "focusStateEnabled");
        }
        public static void SetFocusStateEnabled(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTabPanel.SetOption", identifier, "focusStateEnabled", value);
        }
        public static bool? GetHoverStateEnabled(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxTabPanel.GetOption", identifier, "hoverStateEnabled");
        }
        public static void SetHoverStateEnabled(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTabPanel.SetOption", identifier, "hoverStateEnabled", value);
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
        public static bool? GetSwipeEnabled(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxTabPanel.GetOption", identifier, "swipeEnabled");
        }
        public static void SetSwipeEnabled(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTabPanel.SetOption", identifier, "swipeEnabled", value);
        }
    }
    public static class DxTabsInterop
    {
        public static void Init(string identifier, DevExpress.Ui.DxTabsOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTabs.Init", identifier, json);
        }
        public static bool? GetFocusStateEnabled(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxTabs.GetOption", identifier, "focusStateEnabled");
        }
        public static void SetFocusStateEnabled(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTabs.SetOption", identifier, "focusStateEnabled", value);
        }
        public static bool? GetHoverStateEnabled(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxTabs.GetOption", identifier, "hoverStateEnabled");
        }
        public static void SetHoverStateEnabled(string identifier, bool? value)
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
    public static class DxTagBoxInterop
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
        public static string GetApplyValueMode(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxTagBox.GetOption", identifier, "applyValueMode");
        }
        public static void SetApplyValueMode(string identifier, string value)
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
        public static bool? GetShowMultiTagOnly(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxTagBox.GetOption", identifier, "showMultiTagOnly");
        }
        public static void SetShowMultiTagOnly(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTagBox.SetOption", identifier, "showMultiTagOnly", value);
        }
    }
    public static class DxTextAreaInterop
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
        public static bool? GetSpellcheck(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxTextArea.GetOption", identifier, "spellcheck");
        }
        public static void SetSpellcheck(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTextArea.SetOption", identifier, "spellcheck", value);
        }
    }
    public static class DxTextBoxInterop
    {
        public static void Init(string identifier, DevExpress.Ui.DxTextBoxOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTextBox.Init", identifier, json);
        }
        public static string GetMode(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxTextBox.GetOption", identifier, "mode");
        }
        public static void SetMode(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTextBox.SetOption", identifier, "mode", value);
        }
        public static string GetValue(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxTextBox.GetOption", identifier, "value");
        }
        public static void SetValue(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTextBox.SetOption", identifier, "value", value);
        }
    }
    public static class DxTileViewInterop
    {
        public static void Init(string identifier, DevExpress.Ui.DxTileViewOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTileView.Init", identifier, json);
        }
        public static bool? GetActiveStateEnabled(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxTileView.GetOption", identifier, "activeStateEnabled");
        }
        public static void SetActiveStateEnabled(string identifier, bool? value)
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
        public static bool? GetFocusStateEnabled(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxTileView.GetOption", identifier, "focusStateEnabled");
        }
        public static void SetFocusStateEnabled(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTileView.SetOption", identifier, "focusStateEnabled", value);
        }
        public static bool? GetHoverStateEnabled(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxTileView.GetOption", identifier, "hoverStateEnabled");
        }
        public static void SetHoverStateEnabled(string identifier, bool? value)
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
    }
    public static class DxToastInterop
    {
        public static void Init(string identifier, DevExpress.Ui.DxToastOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxToast.Init", identifier, json);
        }
        public static bool? GetCloseOnBackButton(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxToast.GetOption", identifier, "closeOnBackButton");
        }
        public static void SetCloseOnBackButton(string identifier, bool? value)
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
        public static object GetCloseOnOutsideClick(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxToast.GetOption", identifier, "closeOnOutsideClick");
        }
        public static void SetCloseOnOutsideClick(string identifier, object value)
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
        public static object GetHeight(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxToast.GetOption", identifier, "height");
        }
        public static void SetHeight(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxToast.SetOption", identifier, "height", value);
        }
        public static object GetMaxWidth(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxToast.GetOption", identifier, "maxWidth");
        }
        public static void SetMaxWidth(string identifier, object value)
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
        public static object GetMinWidth(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxToast.GetOption", identifier, "minWidth");
        }
        public static void SetMinWidth(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxToast.SetOption", identifier, "minWidth", value);
        }
        public static bool? GetShading(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxToast.GetOption", identifier, "shading");
        }
        public static void SetShading(string identifier, bool? value)
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
        public static object GetWidth(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxToast.GetOption", identifier, "width");
        }
        public static void SetWidth(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxToast.SetOption", identifier, "width", value);
        }
    }
    public static class DxToolbarInterop
    {
        public static void Init(string identifier, DevExpress.Ui.DxToolbarOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxToolbar.Init", identifier, json);
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
    public static class DxTooltipInterop
    {
        public static void Init(string identifier, DevExpress.Ui.DxTooltipOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTooltip.Init", identifier, json);
        }
    }
    public static class DxTreeListInterop
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
        public static string GetDataStructure(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxTreeList.GetOption", identifier, "dataStructure");
        }
        public static void SetDataStructure(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeList.SetOption", identifier, "dataStructure", value);
        }
        public static bool? GetExpandNodesOnFiltering(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxTreeList.GetOption", identifier, "expandNodesOnFiltering");
        }
        public static void SetExpandNodesOnFiltering(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeList.SetOption", identifier, "expandNodesOnFiltering", value);
        }
        public static object GetRootValue(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeList.GetOption", identifier, "rootValue");
        }
        public static void SetRootValue(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeList.SetOption", identifier, "rootValue", value);
        }
    }
    public static class DxTreeViewInterop
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
        public static bool? GetExpandNodesRecursive(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxTreeView.GetOption", identifier, "expandNodesRecursive");
        }
        public static void SetExpandNodesRecursive(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeView.SetOption", identifier, "expandNodesRecursive", value);
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
    }
    public static class DxValidationGroupInterop
    {
        public static void Init(string identifier, DevExpress.Ui.DxValidationGroupOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxValidationGroup.Init", identifier, json);
        }
    }
    public static class DxValidationSummaryInterop
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
    public static class DxValidatorInterop
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
    }
    public static class DxBarGaugeInterop
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
        public static object GetTitle(string identifier)
        {
            return RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxBarGauge.GetOption", identifier, "title");
        }
        public static void SetTitle(string identifier, object value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxBarGauge.SetOption", identifier, "title", value);
        }
        public static float GetValues(string identifier)
        {
            return RegisteredFunction.Invoke<float>("BlazorDevExtreme.DxBarGauge.GetOption", identifier, "values");
        }
        public static void SetValues(string identifier, float value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxBarGauge.SetOption", identifier, "values", value);
        }
    }
    public static class DxBulletInterop
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
    public static class DxChartInterop
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
        public static string GetContainerBackgroundColor(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxChart.GetOption", identifier, "containerBackgroundColor");
        }
        public static void SetContainerBackgroundColor(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxChart.SetOption", identifier, "containerBackgroundColor", value);
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
        public static string GetScrollingMode(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxChart.GetOption", identifier, "scrollingMode");
        }
        public static void SetScrollingMode(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxChart.SetOption", identifier, "scrollingMode", value);
        }
        public static string GetSeriesSelectionMode(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxChart.GetOption", identifier, "seriesSelectionMode");
        }
        public static void SetSeriesSelectionMode(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxChart.SetOption", identifier, "seriesSelectionMode", value);
        }
        public static bool? GetSynchronizeMultiAxes(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxChart.GetOption", identifier, "synchronizeMultiAxes");
        }
        public static void SetSynchronizeMultiAxes(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxChart.SetOption", identifier, "synchronizeMultiAxes", value);
        }
        public static bool? GetUseAggregation(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxChart.GetOption", identifier, "useAggregation");
        }
        public static void SetUseAggregation(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxChart.SetOption", identifier, "useAggregation", value);
        }
        public static string GetZoomingMode(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxChart.GetOption", identifier, "zoomingMode");
        }
        public static void SetZoomingMode(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxChart.SetOption", identifier, "zoomingMode", value);
        }
    }
    public static class DxCircularGaugeInterop
    {
        public static void Init(string identifier, DevExpress.Viz.Gauges.DxCircularGaugeOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxCircularGauge.Init", identifier, json);
        }
    }
    public static class DxFunnelInterop
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
        public static string GetValueField(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxFunnel.GetOption", identifier, "valueField");
        }
        public static void SetValueField(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxFunnel.SetOption", identifier, "valueField", value);
        }
    }
    public static class DxLinearGaugeInterop
    {
        public static void Init(string identifier, DevExpress.Viz.Gauges.DxLinearGaugeOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxLinearGauge.Init", identifier, json);
        }
    }
    public static class DxPieChartInterop
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
        public static float? GetMinDiameter(string identifier)
        {
            return RegisteredFunction.Invoke<float?>("BlazorDevExtreme.DxPieChart.GetOption", identifier, "minDiameter");
        }
        public static void SetMinDiameter(string identifier, float? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPieChart.SetOption", identifier, "minDiameter", value);
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
    }
    public static class DxPolarChartInterop
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
        public static string GetContainerBackgroundColor(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxPolarChart.GetOption", identifier, "containerBackgroundColor");
        }
        public static void SetContainerBackgroundColor(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPolarChart.SetOption", identifier, "containerBackgroundColor", value);
        }
        public static bool? GetEqualBarWidth(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxPolarChart.GetOption", identifier, "equalBarWidth");
        }
        public static void SetEqualBarWidth(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPolarChart.SetOption", identifier, "equalBarWidth", value);
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
        public static string GetSeriesSelectionMode(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxPolarChart.GetOption", identifier, "seriesSelectionMode");
        }
        public static void SetSeriesSelectionMode(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPolarChart.SetOption", identifier, "seriesSelectionMode", value);
        }
        public static bool? GetUseSpiderWeb(string identifier)
        {
            return RegisteredFunction.Invoke<bool?>("BlazorDevExtreme.DxPolarChart.GetOption", identifier, "useSpiderWeb");
        }
        public static void SetUseSpiderWeb(string identifier, bool? value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPolarChart.SetOption", identifier, "useSpiderWeb", value);
        }
    }
    public static class DxRangeSelectorInterop
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
        public static string GetContainerBackgroundColor(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxRangeSelector.GetOption", identifier, "containerBackgroundColor");
        }
        public static void SetContainerBackgroundColor(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxRangeSelector.SetOption", identifier, "containerBackgroundColor", value);
        }
        public static string GetDataSourceField(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxRangeSelector.GetOption", identifier, "dataSourceField");
        }
        public static void SetDataSourceField(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxRangeSelector.SetOption", identifier, "dataSourceField", value);
        }
        public static string GetSelectedRangeColor(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxRangeSelector.GetOption", identifier, "selectedRangeColor");
        }
        public static void SetSelectedRangeColor(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxRangeSelector.SetOption", identifier, "selectedRangeColor", value);
        }
    }
    public static class DxSparklineInterop
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
    }
    public static class DxTreeMapInterop
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
        public static string GetValueField(string identifier)
        {
            return RegisteredFunction.Invoke<string>("BlazorDevExtreme.DxTreeMap.GetOption", identifier, "valueField");
        }
        public static void SetValueField(string identifier, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTreeMap.SetOption", identifier, "valueField", value);
        }
    }
    public static class DxVectorMapInterop
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
        public static float GetBounds(string identifier)
        {
            return RegisteredFunction.Invoke<float>("BlazorDevExtreme.DxVectorMap.GetOption", identifier, "bounds");
        }
        public static void SetBounds(string identifier, float value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxVectorMap.SetOption", identifier, "bounds", value);
        }
        public static float GetCenter(string identifier)
        {
            return RegisteredFunction.Invoke<float>("BlazorDevExtreme.DxVectorMap.GetOption", identifier, "center");
        }
        public static void SetCenter(string identifier, float value)
        {
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxVectorMap.SetOption", identifier, "center", value);
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
    }
}
