using Microsoft.AspNetCore.Blazor.Browser.Interop;
using System;

namespace BlazorDevExtreme
{
    public static class DxAccordion
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
    }
    public static class DxActionSheet
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
    }
    public static class DxAutocomplete
    {
        public static void Init(string identifier, DevExpress.Ui.DxAutocompleteOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxAutocomplete.Init", identifier, json);
        }
    }
    public static class DxBox
    {
        public static void Init(string identifier, DevExpress.Ui.DxBoxOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxBox.Init", identifier, json);
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
    }
    public static class DxCalendar
    {
        public static void Init(string identifier, DevExpress.Ui.DxCalendarOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxCalendar.Init", identifier, json);
        }
    }
    public static class DxCheckBox
    {
        public static void Init(string identifier, DevExpress.Ui.DxCheckBoxOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxCheckBox.Init", identifier, json);
        }
    }
    public static class DxColorBox
    {
        public static void Init(string identifier, DevExpress.Ui.DxColorBoxOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxColorBox.Init", identifier, json);
        }
    }
    public static class DxContextMenu
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
    }
    public static class DxDataGrid
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
    public static class DxDateBox
    {
        public static void Init(string identifier, DevExpress.Ui.DxDateBoxOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDateBox.Init", identifier, json);
        }
    }
    public static class DxDeferRendering
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
    }
    public static class DxDropDownBox
    {
        public static void Init(string identifier, DevExpress.Ui.DxDropDownBoxOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxDropDownBox.Init", identifier, json);
        }
    }
    public static class DxFileUploader
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
    }
    public static class DxFilterBuilder
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
    }
    public static class DxForm
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
    }
    public static class DxGallery
    {
        public static void Init(string identifier, DevExpress.Ui.DxGalleryOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxGallery.Init", identifier, json);
        }
    }
    public static class DxList
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
    }
    public static class DxLoadIndicator
    {
        public static void Init(string identifier, DevExpress.Ui.DxLoadIndicatorOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxLoadIndicator.Init", identifier, json);
        }
    }
    public static class DxLoadPanel
    {
        public static void Init(string identifier, DevExpress.Ui.DxLoadPanelOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxLoadPanel.Init", identifier, json);
        }
    }
    public static class DxLookup
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
    }
    public static class DxMap
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
    }
    public static class DxMenu
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
    }
    public static class DxMultiView
    {
        public static void Init(string identifier, DevExpress.Ui.DxMultiViewOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxMultiView.Init", identifier, json);
        }
    }
    public static class DxNavBar
    {
        public static void Init(string identifier, DevExpress.Ui.DxNavBarOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxNavBar.Init", identifier, json);
        }
    }
    public static class DxNumberBox
    {
        public static void Init(string identifier, DevExpress.Ui.DxNumberBoxOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxNumberBox.Init", identifier, json);
        }
    }
    public static class DxPanorama
    {
        public static void Init(string identifier, DevExpress.Ui.DxPanoramaOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPanorama.Init", identifier, json);
        }
    }
    public static class DxPivot
    {
        public static void Init(string identifier, DevExpress.Ui.DxPivotOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPivot.Init", identifier, json);
        }
    }
    public static class DxPivotGrid
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
    }
    public static class DxPivotGridFieldChooser
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
    }
    public static class DxPopover
    {
        public static void Init(string identifier, DevExpress.Ui.DxPopoverOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxPopover.Init", identifier, json);
        }
    }
    public static class DxPopup
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
    }
    public static class DxProgressBar
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
    }
    public static class DxRadioGroup
    {
        public static void Init(string identifier, DevExpress.Ui.DxRadioGroupOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxRadioGroup.Init", identifier, json);
        }
    }
    public static class DxRangeSlider
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
    }
    public static class DxResizable
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
    }
    public static class DxResponsiveBox
    {
        public static void Init(string identifier, DevExpress.Ui.DxResponsiveBoxOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxResponsiveBox.Init", identifier, json);
        }
    }
    public static class DxScheduler
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
    }
    public static class DxScrollView
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
    }
    public static class DxSelectBox
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
    }
    public static class DxSlideOut
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
    }
    public static class DxSlideOutView
    {
        public static void Init(string identifier, DevExpress.Ui.DxSlideOutViewOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxSlideOutView.Init", identifier, json);
        }
    }
    public static class DxSlider
    {
        public static void Init(string identifier, DevExpress.Ui.DxSliderOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxSlider.Init", identifier, json);
        }
    }
    public static class DxSwitch
    {
        public static void Init(string identifier, DevExpress.Ui.DxSwitchOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxSwitch.Init", identifier, json);
        }
    }
    public static class DxTabPanel
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
    }
    public static class DxTabs
    {
        public static void Init(string identifier, DevExpress.Ui.DxTabsOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTabs.Init", identifier, json);
        }
    }
    public static class DxTagBox
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
    }
    public static class DxTextArea
    {
        public static void Init(string identifier, DevExpress.Ui.DxTextAreaOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTextArea.Init", identifier, json);
        }
    }
    public static class DxTextBox
    {
        public static void Init(string identifier, DevExpress.Ui.DxTextBoxOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTextBox.Init", identifier, json);
        }
    }
    public static class DxTileView
    {
        public static void Init(string identifier, DevExpress.Ui.DxTileViewOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTileView.Init", identifier, json);
        }
    }
    public static class DxToast
    {
        public static void Init(string identifier, DevExpress.Ui.DxToastOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxToast.Init", identifier, json);
        }
    }
    public static class DxToolbar
    {
        public static void Init(string identifier, DevExpress.Ui.DxToolbarOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxToolbar.Init", identifier, json);
        }
    }
    public static class DxTooltip
    {
        public static void Init(string identifier, DevExpress.Ui.DxTooltipOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxTooltip.Init", identifier, json);
        }
    }
    public static class DxTreeList
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
    }
    public static class DxTreeView
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
    }
    public static class DxValidationGroup
    {
        public static void Init(string identifier, DevExpress.Ui.DxValidationGroupOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxValidationGroup.Init", identifier, json);
        }
    }
    public static class DxValidationSummary
    {
        public static void Init(string identifier, DevExpress.Ui.DxValidationSummaryOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxValidationSummary.Init", identifier, json);
        }
    }
    public static class DxValidator
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
    }
    public static class DxBarGauge
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
    }
    public static class DxBullet
    {
        public static void Init(string identifier, DevExpress.Viz.Sparklines.DxBulletOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxBullet.Init", identifier, json);
        }
    }
    public static class DxChart
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
    }
    public static class DxCircularGauge
    {
        public static void Init(string identifier, DevExpress.Viz.Gauges.DxCircularGaugeOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxCircularGauge.Init", identifier, json);
        }
    }
    public static class DxFunnel
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
    }
    public static class DxLinearGauge
    {
        public static void Init(string identifier, DevExpress.Viz.Gauges.DxLinearGaugeOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxLinearGauge.Init", identifier, json);
        }
    }
    public static class DxPieChart
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
    }
    public static class DxPolarChart
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
    }
    public static class DxRangeSelector
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
    }
    public static class DxSparkline
    {
        public static void Init(string identifier, DevExpress.Viz.Sparklines.DxSparklineOptions options)
        {
            string json = SimpleJson.SimpleJson.SerializeObject(options);
            RegisteredFunction.Invoke<object>("BlazorDevExtreme.DxSparkline.Init", identifier, json);
        }
    }
    public static class DxTreeMap
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
    }
    public static class DxVectorMap
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
    }
}
