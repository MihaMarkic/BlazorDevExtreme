namespace DevExpress
{
    public partial class AnimationConfig
    {
        public object complete { get; set; }
        public float? delay { get; set; }
        public string direction { get; set; }
        public float? duration { get; set; }
        public string easing { get; set; }
        public object from { get; set; }
        public float? staggerDelay { get; set; }
        public object start { get; set; }
        public object to { get; set; }
        public string type { get; set; }
    }

    public partial class PositionConfig
    {
        public object at { get; set; }
        public object boundary { get; set; }
        public object boundaryOffset { get; set; }
        public object collision { get; set; }
        public object my { get; set; }
        public object of { get; set; }
        public object offset { get; set; }
    }

    public partial class ComponentOptions
    {
        public bool? onDisposingEnabled { get; set; }
        public bool? onInitializedEnabled { get; set; }
        public bool? onOptionChangedEnabled { get; set; }
    }

    public partial class GlobalConfig
    {
        public string decimalSeparator { get; set; }
        public string defaultCurrency { get; set; }
        public bool? forceIsoDateParsing { get; set; }
        public bool? rtlEnabled { get; set; }
        public string serverDecimalSeparator { get; set; }
        public string thousandsSeparator { get; set; }
    }

    public partial class Device
    {
        public bool? android { get; set; }
        public string deviceType { get; set; }
        public bool? generic { get; set; }
        public string grade { get; set; }
        public bool? ios { get; set; }
        public bool? phone { get; set; }
        public string platform { get; set; }
        public bool? tablet { get; set; }
        public object version { get; set; }
        public bool? win { get; set; }
    }

    public partial class DOMComponentOptions : ComponentOptions
    {
        public object bindingOptions { get; set; }
        public object elementAttr { get; set; }
        public object height { get; set; }
        public bool? rtlEnabled { get; set; }
        public object width { get; set; }
    }

}
namespace DevExpress.Data
{
    public partial class StoreOptions
    {
        public object errorHandler { get; set; }
        public object key { get; set; }
        public bool? onInsertedEnabled { get; set; }
        public bool? onInsertingEnabled { get; set; }
        public bool? onLoadedEnabled { get; set; }
        public bool? onLoadingEnabled { get; set; }
        public bool? onModifiedEnabled { get; set; }
        public bool? onModifyingEnabled { get; set; }
        public bool? onRemovedEnabled { get; set; }
        public bool? onRemovingEnabled { get; set; }
        public bool? onUpdatedEnabled { get; set; }
        public bool? onUpdatingEnabled { get; set; }
    }

    public partial class ArrayStoreOptions : StoreOptions
    {
        public object data { get; set; }
    }

    public partial class LoadOptions
    {
        public object customQueryParams { get; set; }
        public object expand { get; set; }
        public object filter { get; set; }
        public object group { get; set; }
        public object groupSummary { get; set; }
        public bool? requireGroupCount { get; set; }
        public bool? requireTotalCount { get; set; }
        public object searchExpr { get; set; }
        public string searchOperation { get; set; }
        public object searchValue { get; set; }
        public object select { get; set; }
        public float? skip { get; set; }
        public object sort { get; set; }
        public float? take { get; set; }
        public object totalSummary { get; set; }
        public object userData { get; set; }
    }

    public partial class CustomStoreOptions : StoreOptions
    {
        public object byKey { get; set; }
        public bool? cacheRawData { get; set; }
        public object insert { get; set; }
        public object load { get; set; }
        public string loadMode { get; set; }
        public object remove { get; set; }
        public object totalCount { get; set; }
        public object update { get; set; }
        public bool? useDefaultSearch { get; set; }
    }

    public partial class DataSourceOptions
    {
        public object customQueryParams { get; set; }
        public object expand { get; set; }
        public object filter { get; set; }
        public object group { get; set; }
        public object map { get; set; }
        public bool? onChangedEnabled { get; set; }
        public bool? onLoadErrorEnabled { get; set; }
        public bool? onLoadingChangedEnabled { get; set; }
        public float? pageSize { get; set; }
        public bool? paginate { get; set; }
        public object postProcess { get; set; }
        public bool? requireTotalCount { get; set; }
        public object searchExpr { get; set; }
        public string searchOperation { get; set; }
        public object searchValue { get; set; }
        public object select { get; set; }
        public object sort { get; set; }
        public object store { get; set; }
    }

    public partial class LocalStoreOptions : ArrayStoreOptions
    {
        public float? flushInterval { get; set; }
        public bool? immediate { get; set; }
        public string name { get; set; }
    }

    public partial class ODataContextOptions
    {
        public object beforeSend { get; set; }
        public bool? deserializeDates { get; set; }
        public object entities { get; set; }
        public object errorHandler { get; set; }
        public bool? jsonp { get; set; }
        public string url { get; set; }
        public float? version { get; set; }
        public bool? withCredentials { get; set; }
    }

    public partial class ODataStoreOptions : StoreOptions
    {
        public object beforeSend { get; set; }
        public bool? deserializeDates { get; set; }
        public object fieldTypes { get; set; }
        public bool? jsonp { get; set; }
        public object keyType { get; set; }
        public string url { get; set; }
        public float? version { get; set; }
        public bool? withCredentials { get; set; }
    }

    public partial class PivotGridDataSourceOptions
    {
        public object fields { get; set; }
        public object filter { get; set; }
        public bool? onChangedEnabled { get; set; }
        public bool? onFieldsPreparedEnabled { get; set; }
        public bool? onLoadErrorEnabled { get; set; }
        public bool? onLoadingChangedEnabled { get; set; }
        public bool? remoteOperations { get; set; }
        public bool? retrieveFields { get; set; }
        public object store { get; set; }
    }

    public partial class XmlaStoreOptions
    {
        public object beforeSend { get; set; }
        public string catalog { get; set; }
        public string cube { get; set; }
        public string url { get; set; }
    }

    public partial class PivotGridDataSourceField
    {
        public bool? allowCrossGroupCalculation { get; set; }
        public bool? allowExpandAll { get; set; }
        public bool? allowFiltering { get; set; }
        public bool? allowSorting { get; set; }
        public bool? allowSortingBySummary { get; set; }
        public object area { get; set; }
        public float? areaIndex { get; set; }
        public object calculateCustomSummary { get; set; }
        public object calculateSummaryValue { get; set; }
        public string caption { get; set; }
        public object customizeText { get; set; }
        public string dataField { get; set; }
        public string dataType { get; set; }
        public string displayFolder { get; set; }
        public bool? expanded { get; set; }
        public string filterType { get; set; }
        public object filterValues { get; set; }
        public object format { get; set; }
        public float? groupIndex { get; set; }
        public object groupInterval { get; set; }
        public string groupName { get; set; }
        public object headerFilter { get; set; }
        public bool? isMeasure { get; set; }
        public float? precision { get; set; }
        public string runningTotal { get; set; }
        public object selector { get; set; }
        public bool? showGrandTotals { get; set; }
        public bool? showTotals { get; set; }
        public bool? showValues { get; set; }
        public string sortBy { get; set; }
        public string sortBySummaryField { get; set; }
        public object sortBySummaryPath { get; set; }
        public object sortingMethod { get; set; }
        public string sortOrder { get; set; }
        public string summaryDisplayMode { get; set; }
        public string summaryType { get; set; }
        public bool? visible { get; set; }
        public float? width { get; set; }
        public bool? wordWrapEnabled { get; set; }
    }

}
namespace DevExpress.Framework
{
    public partial class DxCommandOptions : DOMComponentOptions
    {
        public bool? disabled { get; set; }
        public string icon { get; set; }
        public object iconSrc { get; set; }
        public string id { get; set; }
        public bool? onExecuteEnabled { get; set; }
        public string renderStage { get; set; }
        public string title { get; set; }
        public string type { get; set; }
        public bool? visible { get; set; }
    }

    public partial class StateManagerOptions
    {
        public object storage { get; set; }
    }

    public partial class DxCommandContainerOptions
    {
        public string id { get; set; }
    }

    public partial class DxViewOptions
    {
        public bool? disableCache { get; set; }
        public bool? modal { get; set; }
        public string name { get; set; }
        public string orientation { get; set; }
        public string pane { get; set; }
        public string title { get; set; }
    }

    public partial class DxLayoutOptions
    {
        public string name { get; set; }
    }

    public partial class DxViewPlaceholderOptions
    {
        public string viewName { get; set; }
    }

    public partial class DxTransitionOptions
    {
        public string animation { get; set; }
        public string name { get; set; }
        public string type { get; set; }
    }

    public partial class DxContentPlaceholderOptions
    {
        public string animation { get; set; }
        public string contentCssPosition { get; set; }
        public string name { get; set; }
        public string transition { get; set; }
    }

    public partial class DxContentOptions
    {
        public string targetPlaceholder { get; set; }
    }

}
namespace DevExpress.Framework.Html
{
    public partial class HtmlApplicationOptions
    {
        public object animationSet { get; set; }
        public object commandMapping { get; set; }
        public bool? disableViewCache { get; set; }
        public object layoutSet { get; set; }
        public string mode { get; set; }
        public object @namespace { get; set; }
        public string navigateToRootViewMode { get; set; }
        public object navigation { get; set; }
        public object router { get; set; }
        public object stateManager { get; set; }
        public object stateStorage { get; set; }
        public string templatesVersion { get; set; }
        public bool? useViewTitleAsBackText { get; set; }
        public object viewCache { get; set; }
        public float? viewCacheSize { get; set; }
        public object viewPort { get; set; }
    }

}
namespace DevExpress.Ui
{
    public partial class DxAccordionOptions : CollectionWidgetOptions
    {
        public float? animationDuration { get; set; }
        public bool? collapsible { get; set; }
        public bool? deferRendering { get; set; }
        public object itemTitleTemplate { get; set; }
        public bool? multiple { get; set; }
        public bool? onItemTitleClickEnabled { get; set; }
    }

    public partial class DxAccordionItemTemplate : CollectionWidgetItemTemplate
    {
        public string icon { get; set; }
        public string title { get; set; }
    }

    public partial class DxActionSheetOptions : CollectionWidgetOptions
    {
        public string cancelText { get; set; }
        public bool? onCancelClickEnabled { get; set; }
        public bool? showCancelButton { get; set; }
        public bool? showTitle { get; set; }
        public object target { get; set; }
        public string title { get; set; }
        public bool? usePopover { get; set; }
    }

    public partial class DxActionSheetItemTemplate : CollectionWidgetItemTemplate
    {
        public string icon { get; set; }
        public bool? onClickEnabled { get; set; }
        public string type { get; set; }
    }

    public partial class DxAutocompleteOptions : DxDropDownListOptions
    {
        public float? maxItemCount { get; set; }
    }

    public partial class DxBoxOptions : CollectionWidgetOptions
    {
        public string align { get; set; }
        public string crossAlign { get; set; }
        public string direction { get; set; }
    }

    public partial class DxBoxItemTemplate : CollectionWidgetItemTemplate
    {
        public object baseSize { get; set; }
        public object box { get; set; }
        public float? ratio { get; set; }
        public float? shrink { get; set; }
    }

    public partial class DxButtonOptions : WidgetOptions
    {
        public string icon { get; set; }
        public bool? onClickEnabled { get; set; }
        public object template { get; set; }
        public string text { get; set; }
        public string type { get; set; }
        public bool? useSubmitBehavior { get; set; }
        public string validationGroup { get; set; }
    }

    public partial class DxButtonDefaultTemplate
    {
        public string icon { get; set; }
        public string text { get; set; }
    }

    public partial class DxCalendarOptions : EditorOptions
    {
        public object cellTemplate { get; set; }
        public string dateSerializationFormat { get; set; }
        public object disabledDates { get; set; }
        public object firstDayOfWeek { get; set; }
        public object max { get; set; }
        public string maxZoomLevel { get; set; }
        public object min { get; set; }
        public string minZoomLevel { get; set; }
        public string name { get; set; }
        public bool? showTodayButton { get; set; }
        public string zoomLevel { get; set; }
    }

    public partial class DxCheckBoxOptions : EditorOptions
    {
        public string name { get; set; }
        public string text { get; set; }
    }

    public partial class DxColorBoxOptions : DxDropDownEditorOptions
    {
        public string applyButtonText { get; set; }
        public string cancelButtonText { get; set; }
        public bool? editAlphaChannel { get; set; }
        public object fieldTemplate { get; set; }
        public float? keyStep { get; set; }
    }

    public partial class DxContextMenuOptions : DxMenuBaseOptions
    {
        public object closeOnOutsideClick { get; set; }
        public bool? onHiddenEnabled { get; set; }
        public bool? onHidingEnabled { get; set; }
        public bool? onPositioningEnabled { get; set; }
        public bool? onShowingEnabled { get; set; }
        public bool? onShownEnabled { get; set; }
        public object position { get; set; }
        public object showEvent { get; set; }
        public string submenuDirection { get; set; }
        public object target { get; set; }
    }

    public partial class GridBaseOptions : WidgetOptions
    {
        public bool? allowColumnReordering { get; set; }
        public bool? allowColumnResizing { get; set; }
        public bool? cacheEnabled { get; set; }
        public bool? cellHintEnabled { get; set; }
        public bool? columnAutoWidth { get; set; }
        public object columnChooser { get; set; }
        public object columnFixing { get; set; }
        public bool? columnHidingEnabled { get; set; }
        public float? columnMinWidth { get; set; }
        public string columnResizingMode { get; set; }
        public object columns { get; set; }
        public float? columnWidth { get; set; }
        public object dataSource { get; set; }
        public string dateSerializationFormat { get; set; }
        public object editing { get; set; }
        public bool? errorRowEnabled { get; set; }
        public object filterBuilder { get; set; }
        public object filterBuilderPopup { get; set; }
        public object filterPanel { get; set; }
        public object filterRow { get; set; }
        public object filterSyncEnabled { get; set; }
        public object filterValue { get; set; }
        public object headerFilter { get; set; }
        public object loadPanel { get; set; }
        public string noDataText { get; set; }
        public bool? onAdaptiveDetailRowPreparingEnabled { get; set; }
        public bool? onDataErrorOccurredEnabled { get; set; }
        public bool? onInitNewRowEnabled { get; set; }
        public bool? onKeyDownEnabled { get; set; }
        public bool? onRowCollapsedEnabled { get; set; }
        public bool? onRowCollapsingEnabled { get; set; }
        public bool? onRowExpandedEnabled { get; set; }
        public bool? onRowExpandingEnabled { get; set; }
        public bool? onRowInsertedEnabled { get; set; }
        public bool? onRowInsertingEnabled { get; set; }
        public bool? onRowRemovedEnabled { get; set; }
        public bool? onRowRemovingEnabled { get; set; }
        public bool? onRowUpdatedEnabled { get; set; }
        public bool? onRowUpdatingEnabled { get; set; }
        public bool? onRowValidatingEnabled { get; set; }
        public bool? onSelectionChangedEnabled { get; set; }
        public bool? onToolbarPreparingEnabled { get; set; }
        public object pager { get; set; }
        public object paging { get; set; }
        public bool? rowAlternationEnabled { get; set; }
        public object scrolling { get; set; }
        public object searchPanel { get; set; }
        public object selectedRowKeys { get; set; }
        public object selection { get; set; }
        public bool? showBorders { get; set; }
        public bool? showColumnHeaders { get; set; }
        public bool? showColumnLines { get; set; }
        public bool? showRowLines { get; set; }
        public object sorting { get; set; }
        public object stateStoring { get; set; }
        public bool? twoWayBindingEnabled { get; set; }
        public bool? wordWrapEnabled { get; set; }
    }

    public partial class GridBaseEditing
    {
        public bool? allowAdding { get; set; }
        public bool? allowDeleting { get; set; }
        public bool? allowUpdating { get; set; }
        public object form { get; set; }
        public string mode { get; set; }
        public object popup { get; set; }
        public object texts { get; set; }
        public bool? useIcons { get; set; }
    }

    public partial class GridBaseEditingTexts
    {
        public string addRow { get; set; }
        public string cancelAllChanges { get; set; }
        public string cancelRowChanges { get; set; }
        public string confirmDeleteMessage { get; set; }
        public string confirmDeleteTitle { get; set; }
        public string deleteRow { get; set; }
        public string editRow { get; set; }
        public string saveAllChanges { get; set; }
        public string saveRowChanges { get; set; }
        public string undeleteRow { get; set; }
        public string validationCancelChanges { get; set; }
    }

    public partial class GridBasePaging
    {
        public bool? enabled { get; set; }
        public float? pageIndex { get; set; }
        public float? pageSize { get; set; }
    }

    public partial class GridBaseScrolling
    {
        public string columnRenderingMode { get; set; }
        public bool? preloadEnabled { get; set; }
        public string rowRenderingMode { get; set; }
        public bool? scrollByContent { get; set; }
        public bool? scrollByThumb { get; set; }
        public string showScrollbar { get; set; }
        public object useNative { get; set; }
    }

    public partial class GridBaseSelection
    {
        public bool? allowSelectAll { get; set; }
        public string mode { get; set; }
    }

    public partial class DxDataGridOptions : GridBaseOptions
    {
        public object customizeColumns { get; set; }
        public object customizeExportData { get; set; }
        public object export { get; set; }
        public object grouping { get; set; }
        public object groupPanel { get; set; }
        public object keyExpr { get; set; }
        public object masterDetail { get; set; }
        public bool? onCellClickEnabled { get; set; }
        public bool? onCellHoverChangedEnabled { get; set; }
        public bool? onCellPreparedEnabled { get; set; }
        public bool? onContextMenuPreparingEnabled { get; set; }
        public bool? onEditingStartEnabled { get; set; }
        public bool? onEditorPreparedEnabled { get; set; }
        public bool? onEditorPreparingEnabled { get; set; }
        public bool? onExportedEnabled { get; set; }
        public bool? onExportingEnabled { get; set; }
        public bool? onFileSavingEnabled { get; set; }
        public bool? onRowClickEnabled { get; set; }
        public bool? onRowPreparedEnabled { get; set; }
        public object remoteOperations { get; set; }
        public object rowTemplate { get; set; }
        public object selectionFilter { get; set; }
        public object sortByGroupSummaryInfo { get; set; }
        public object summary { get; set; }
    }

    public partial class DxDataGridEditing : GridBaseEditing
    {
    }

    public partial class DxDataGridScrolling : GridBaseScrolling
    {
        public string mode { get; set; }
    }

    public partial class DxDataGridSelection : GridBaseSelection
    {
        public bool? deferred { get; set; }
        public string selectAllMode { get; set; }
        public string showCheckBoxesMode { get; set; }
    }

    public partial class DxDateBoxOptions : DxDropDownEditorOptions
    {
        public bool? adaptivityEnabled { get; set; }
        public string applyButtonText { get; set; }
        public object calendarOptions { get; set; }
        public string cancelButtonText { get; set; }
        public string dateOutOfRangeMessage { get; set; }
        public string dateSerializationFormat { get; set; }
        public object disabledDates { get; set; }
        public object displayFormat { get; set; }
        public float? interval { get; set; }
        public string invalidDateMessage { get; set; }
        public object max { get; set; }
        public string maxZoomLevel { get; set; }
        public object min { get; set; }
        public string minZoomLevel { get; set; }
        public string pickerType { get; set; }
        public bool? showAnalogClock { get; set; }
        public string type { get; set; }
    }

    public partial class DxDeferRenderingOptions : WidgetOptions
    {
        public object animation { get; set; }
        public bool? onRenderedEnabled { get; set; }
        public bool? onShownEnabled { get; set; }
        public object renderWhen { get; set; }
        public bool? showLoadIndicator { get; set; }
        public string staggerItemSelector { get; set; }
    }

    public partial class DxDropDownBoxOptions : DxDropDownEditorOptions
    {
        public object contentTemplate { get; set; }
        public object dropDownOptions { get; set; }
        public object fieldTemplate { get; set; }
        public object dataSource { get; set; }
        public object displayExpr { get; set; }
        public object items { get; set; }
        public object itemTemplate { get; set; }
        public object valueExpr { get; set; }
    }

    public partial class DxDropDownMenuOptions : WidgetOptions
    {
        public string buttonIcon { get; set; }
        public string buttonText { get; set; }
        public object dataSource { get; set; }
        public object items { get; set; }
        public object itemTemplate { get; set; }
        public bool? onButtonClickEnabled { get; set; }
        public bool? onItemClickEnabled { get; set; }
        public bool? opened { get; set; }
        public object popupHeight { get; set; }
        public object popupWidth { get; set; }
        public bool? usePopover { get; set; }
    }

    public partial class DxFileUploaderOptions : EditorOptions
    {
        public string accept { get; set; }
        public bool? allowCanceling { get; set; }
        public string labelText { get; set; }
        public bool? multiple { get; set; }
        public string name { get; set; }
        public bool? onProgressEnabled { get; set; }
        public bool? onUploadAbortedEnabled { get; set; }
        public bool? onUploadedEnabled { get; set; }
        public bool? onUploadErrorEnabled { get; set; }
        public bool? onUploadStartedEnabled { get; set; }
        public float? progress { get; set; }
        public string readyToUploadMessage { get; set; }
        public string selectButtonText { get; set; }
        public bool? showFileList { get; set; }
        public string uploadButtonText { get; set; }
        public string uploadedMessage { get; set; }
        public string uploadFailedMessage { get; set; }
        public object uploadHeaders { get; set; }
        public string uploadMethod { get; set; }
        public string uploadMode { get; set; }
        public string uploadUrl { get; set; }
    }

    public partial class DxFilterBuilderOptions : WidgetOptions
    {
        public bool? allowHierarchicalFields { get; set; }
        public object customOperations { get; set; }
        public object fields { get; set; }
        public object filterOperationDescriptions { get; set; }
        public object groupOperationDescriptions { get; set; }
        public bool? onEditorPreparedEnabled { get; set; }
        public bool? onEditorPreparingEnabled { get; set; }
        public bool? onValueChangedEnabled { get; set; }
        public object value { get; set; }
    }

    public partial class DxFormOptions : WidgetOptions
    {
        public bool? alignItemLabels { get; set; }
        public bool? alignItemLabelsInAllGroups { get; set; }
        public object colCount { get; set; }
        public object colCountByScreen { get; set; }
        public object customizeItem { get; set; }
        public object formData { get; set; }
        public object items { get; set; }
        public string labelLocation { get; set; }
        public float? minColWidth { get; set; }
        public bool? onEditorEnterKeyEnabled { get; set; }
        public bool? onFieldDataChangedEnabled { get; set; }
        public string optionalMark { get; set; }
        public bool? readOnly { get; set; }
        public string requiredMark { get; set; }
        public string requiredMessage { get; set; }
        public object screenByWidth { get; set; }
        public bool? scrollingEnabled { get; set; }
        public bool? showColonAfterLabel { get; set; }
        public bool? showOptionalMark { get; set; }
        public bool? showRequiredMark { get; set; }
        public bool? showValidationSummary { get; set; }
        public string validationGroup { get; set; }
    }

    public partial class DxGalleryOptions : CollectionWidgetOptions
    {
        public float? animationDuration { get; set; }
        public bool? animationEnabled { get; set; }
        public bool? indicatorEnabled { get; set; }
        public float? initialItemWidth { get; set; }
        public bool? loop { get; set; }
        public bool? showIndicator { get; set; }
        public bool? showNavButtons { get; set; }
        public float? slideshowDelay { get; set; }
        public bool? stretchImages { get; set; }
        public bool? swipeEnabled { get; set; }
        public bool? wrapAround { get; set; }
    }

    public partial class DxGalleryItemTemplate : CollectionWidgetItemTemplate
    {
        public string imageAlt { get; set; }
        public string imageSrc { get; set; }
    }

    public partial class DxListOptions : CollectionWidgetOptions
    {
        public bool? allowItemDeleting { get; set; }
        public bool? allowItemReordering { get; set; }
        public bool? bounceEnabled { get; set; }
        public bool? collapsibleGroups { get; set; }
        public bool? grouped { get; set; }
        public object groupTemplate { get; set; }
        public bool? indicateLoading { get; set; }
        public string itemDeleteMode { get; set; }
        public object menuItems { get; set; }
        public string menuMode { get; set; }
        public string nextButtonText { get; set; }
        public bool? onGroupRenderedEnabled { get; set; }
        public bool? onItemDeletedEnabled { get; set; }
        public bool? onItemDeletingEnabled { get; set; }
        public bool? onItemReorderedEnabled { get; set; }
        public bool? onItemSwipeEnabled { get; set; }
        public bool? onPageLoadingEnabled { get; set; }
        public bool? onPullRefreshEnabled { get; set; }
        public bool? onScrollEnabled { get; set; }
        public bool? onSelectAllValueChangedEnabled { get; set; }
        public string pageLoadingText { get; set; }
        public string pageLoadMode { get; set; }
        public string pulledDownText { get; set; }
        public string pullingDownText { get; set; }
        public bool? pullRefreshEnabled { get; set; }
        public string refreshingText { get; set; }
        public bool? scrollByContent { get; set; }
        public bool? scrollByThumb { get; set; }
        public bool? scrollingEnabled { get; set; }
        public string selectAllMode { get; set; }
        public string selectionMode { get; set; }
        public string showScrollbar { get; set; }
        public bool? showSelectionControls { get; set; }
        public bool? useNativeScrolling { get; set; }
        public object searchEditorOptions { get; set; }
        public bool? searchEnabled { get; set; }
        public object searchExpr { get; set; }
        public string searchMode { get; set; }
        public float? searchTimeout { get; set; }
        public string searchValue { get; set; }
    }

    public partial class DxLoadIndicatorOptions : WidgetOptions
    {
        public string indicatorSrc { get; set; }
    }

    public partial class DxLoadPanelOptions : DxOverlayOptions
    {
        public float? delay { get; set; }
        public string indicatorSrc { get; set; }
        public string message { get; set; }
        public bool? showIndicator { get; set; }
        public bool? showPane { get; set; }
    }

    public partial class DxLoadPanelAnimation : DxOverlayAnimation
    {
    }

    public partial class DxLookupOptions : DxDropDownListOptions
    {
        public object animation { get; set; }
        public string applyButtonText { get; set; }
        public string cancelButtonText { get; set; }
        public bool? cleanSearchOnOpening { get; set; }
        public string clearButtonText { get; set; }
        public object closeOnOutsideClick { get; set; }
        public object fieldTemplate { get; set; }
        public bool? fullScreen { get; set; }
        public string nextButtonText { get; set; }
        public bool? onPageLoadingEnabled { get; set; }
        public bool? onPullRefreshEnabled { get; set; }
        public bool? onScrollEnabled { get; set; }
        public bool? onTitleRenderedEnabled { get; set; }
        public string pageLoadingText { get; set; }
        public string pageLoadMode { get; set; }
        public object popupHeight { get; set; }
        public object popupWidth { get; set; }
        public object position { get; set; }
        public string pulledDownText { get; set; }
        public string pullingDownText { get; set; }
        public bool? pullRefreshEnabled { get; set; }
        public string refreshingText { get; set; }
        public string searchPlaceholder { get; set; }
        public bool? shading { get; set; }
        public bool? showCancelButton { get; set; }
        public bool? showPopupTitle { get; set; }
        public string title { get; set; }
        public object titleTemplate { get; set; }
        public bool? useNativeScrolling { get; set; }
        public bool? usePopover { get; set; }
    }

    public partial class DxMapOptions : WidgetOptions
    {
        public bool? autoAdjust { get; set; }
        public object center { get; set; }
        public bool? controls { get; set; }
        public object key { get; set; }
        public string markerIconSrc { get; set; }
        public object markers { get; set; }
        public bool? onClickEnabled { get; set; }
        public bool? onMarkerAddedEnabled { get; set; }
        public bool? onMarkerRemovedEnabled { get; set; }
        public bool? onReadyEnabled { get; set; }
        public bool? onRouteAddedEnabled { get; set; }
        public bool? onRouteRemovedEnabled { get; set; }
        public string provider { get; set; }
        public object routes { get; set; }
        public string type { get; set; }
        public float? zoom { get; set; }
    }

    public partial class MapLocation
    {
        public float? lat { get; set; }
        public float? lng { get; set; }
    }

    public partial class DxMenuOptions : DxMenuBaseOptions
    {
        public bool? adaptivityEnabled { get; set; }
        public bool? hideSubmenuOnMouseLeave { get; set; }
        public bool? onSubmenuHiddenEnabled { get; set; }
        public bool? onSubmenuHidingEnabled { get; set; }
        public bool? onSubmenuShowingEnabled { get; set; }
        public bool? onSubmenuShownEnabled { get; set; }
        public string orientation { get; set; }
        public object showFirstSubmenuMode { get; set; }
        public string submenuDirection { get; set; }
    }

    public partial class DxMultiViewOptions : CollectionWidgetOptions
    {
        public bool? animationEnabled { get; set; }
        public bool? deferRendering { get; set; }
        public bool? loop { get; set; }
        public bool? swipeEnabled { get; set; }
    }

    public partial class DxMultiViewItemTemplate : CollectionWidgetItemTemplate
    {
    }

    public partial class DxNavBarOptions : DxTabsOptions
    {
    }

    public partial class DxNavBarItemTemplate : DxTabsItemTemplate
    {
    }

    public partial class DxNumberBoxOptions : DxTextEditorOptions
    {
        public object format { get; set; }
        public string invalidValueMessage { get; set; }
        public float? max { get; set; }
        public float? min { get; set; }
        public string mode { get; set; }
        public bool? showSpinButtons { get; set; }
        public float? step { get; set; }
        public bool? useLargeSpinButtons { get; set; }
    }

    public partial class DxOverlayOptions : WidgetOptions
    {
        public object animation { get; set; }
        public bool? closeOnBackButton { get; set; }
        public object closeOnOutsideClick { get; set; }
        public object contentTemplate { get; set; }
        public bool? deferRendering { get; set; }
        public bool? dragEnabled { get; set; }
        public object maxHeight { get; set; }
        public object maxWidth { get; set; }
        public object minHeight { get; set; }
        public object minWidth { get; set; }
        public bool? onHiddenEnabled { get; set; }
        public bool? onHidingEnabled { get; set; }
        public bool? onShowingEnabled { get; set; }
        public bool? onShownEnabled { get; set; }
        public object position { get; set; }
        public bool? shading { get; set; }
        public string shadingColor { get; set; }
    }

    public partial class DxOverlayAnimation
    {
        public object hide { get; set; }
        public object show { get; set; }
    }

    public partial class DxPanoramaOptions : CollectionWidgetOptions
    {
        public object backgroundImage { get; set; }
        public string title { get; set; }
    }

    public partial class DxPanoramaItemTemplate : CollectionWidgetItemTemplate
    {
        public string title { get; set; }
    }

    public partial class DxPivotOptions : CollectionWidgetOptions
    {
        public object contentTemplate { get; set; }
        public object itemTitleTemplate { get; set; }
        public bool? swipeEnabled { get; set; }
    }

    public partial class DxPivotItemTemplate : CollectionWidgetItemTemplate
    {
        public string title { get; set; }
        public object titleTemplate { get; set; }
    }

    public partial class DxPivotGridOptions : WidgetOptions
    {
        public bool? allowExpandAll { get; set; }
        public bool? allowFiltering { get; set; }
        public bool? allowSorting { get; set; }
        public bool? allowSortingBySummary { get; set; }
        public string dataFieldArea { get; set; }
        public object dataSource { get; set; }
        public object export { get; set; }
        public object fieldChooser { get; set; }
        public object fieldPanel { get; set; }
        public object headerFilter { get; set; }
        public bool? hideEmptySummaryCells { get; set; }
        public object loadPanel { get; set; }
        public bool? onCellClickEnabled { get; set; }
        public bool? onCellPreparedEnabled { get; set; }
        public bool? onContextMenuPreparingEnabled { get; set; }
        public bool? onExportedEnabled { get; set; }
        public bool? onExportingEnabled { get; set; }
        public bool? onFileSavingEnabled { get; set; }
        public string rowHeaderLayout { get; set; }
        public object scrolling { get; set; }
        public bool? showBorders { get; set; }
        public bool? showColumnGrandTotals { get; set; }
        public bool? showColumnTotals { get; set; }
        public bool? showRowGrandTotals { get; set; }
        public bool? showRowTotals { get; set; }
        public string showTotalsPrior { get; set; }
        public object stateStoring { get; set; }
        public object texts { get; set; }
        public bool? wordWrapEnabled { get; set; }
    }

    public partial class DxPivotGridFieldChooserOptions : WidgetOptions
    {
        public bool? allowSearch { get; set; }
        public string applyChangesMode { get; set; }
        public object dataSource { get; set; }
        public object headerFilter { get; set; }
        public object layout { get; set; }
        public bool? onContextMenuPreparingEnabled { get; set; }
        public object state { get; set; }
        public object texts { get; set; }
    }

    public partial class DxPopoverOptions : DxPopupOptions
    {
        public object hideEvent { get; set; }
        public object showEvent { get; set; }
        public object target { get; set; }
    }

    public partial class DxPopoverAnimation : DxPopupAnimation
    {
    }

    public partial class DxPopupOptions : DxOverlayOptions
    {
        public object container { get; set; }
        public bool? fullScreen { get; set; }
        public bool? onResizeEnabled { get; set; }
        public bool? onResizeEndEnabled { get; set; }
        public bool? onResizeStartEnabled { get; set; }
        public bool? onTitleRenderedEnabled { get; set; }
        public bool? resizeEnabled { get; set; }
        public bool? showCloseButton { get; set; }
        public bool? showTitle { get; set; }
        public string title { get; set; }
        public object titleTemplate { get; set; }
        public object toolbarItems { get; set; }
    }

    public partial class DxPopupAnimation : DxOverlayAnimation
    {
    }

    public partial class DxPopupToolbarItem
    {
        public bool? disabled { get; set; }
        public string html { get; set; }
        public string location { get; set; }
        public object options { get; set; }
        public object template { get; set; }
        public string text { get; set; }
        public string toolbar { get; set; }
        public bool? visible { get; set; }
        public string widget { get; set; }
    }

    public partial class DxProgressBarOptions : DxTrackBarOptions
    {
        public bool? onCompleteEnabled { get; set; }
        public bool? showStatus { get; set; }
        public object statusFormat { get; set; }
    }

    public partial class DxRadioGroupOptions : EditorOptions
    {
        public string layout { get; set; }
        public string name { get; set; }
        public object dataSource { get; set; }
        public object displayExpr { get; set; }
        public object items { get; set; }
        public object itemTemplate { get; set; }
        public object valueExpr { get; set; }
    }

    public partial class DxRangeSliderOptions : DxSliderBaseOptions
    {
        public float? end { get; set; }
        public string endName { get; set; }
        public float? start { get; set; }
        public string startName { get; set; }
    }

    public partial class DxResizableOptions : DOMComponentOptions
    {
        public string handles { get; set; }
        public float? maxHeight { get; set; }
        public float? maxWidth { get; set; }
        public float? minHeight { get; set; }
        public float? minWidth { get; set; }
        public bool? onResizeEnabled { get; set; }
        public bool? onResizeEndEnabled { get; set; }
        public bool? onResizeStartEnabled { get; set; }
    }

    public partial class DxResponsiveBoxOptions : CollectionWidgetOptions
    {
        public object cols { get; set; }
        public object rows { get; set; }
        public object screenByWidth { get; set; }
        public string singleColumnScreen { get; set; }
    }

    public partial class DxResponsiveBoxItemTemplate : CollectionWidgetItemTemplate
    {
        public object location { get; set; }
    }

    public partial class DxSchedulerOptions : WidgetOptions
    {
        public string allDayExpr { get; set; }
        public object appointmentTemplate { get; set; }
        public object appointmentTooltipTemplate { get; set; }
        public float? cellDuration { get; set; }
        public bool? crossScrollingEnabled { get; set; }
        public object currentDate { get; set; }
        public string currentView { get; set; }
        public object dataCellTemplate { get; set; }
        public object dataSource { get; set; }
        public object dateCellTemplate { get; set; }
        public string dateSerializationFormat { get; set; }
        public string descriptionExpr { get; set; }
        public object dropDownAppointmentTemplate { get; set; }
        public object editing { get; set; }
        public string endDateExpr { get; set; }
        public string endDateTimeZoneExpr { get; set; }
        public float? endDayHour { get; set; }
        public object firstDayOfWeek { get; set; }
        public object groups { get; set; }
        public float? indicatorUpdateInterval { get; set; }
        public object max { get; set; }
        public object maxAppointmentsPerCell { get; set; }
        public object min { get; set; }
        public string noDataText { get; set; }
        public bool? onAppointmentAddedEnabled { get; set; }
        public bool? onAppointmentAddingEnabled { get; set; }
        public bool? onAppointmentClickEnabled { get; set; }
        public bool? onAppointmentContextMenuEnabled { get; set; }
        public bool? onAppointmentDblClickEnabled { get; set; }
        public bool? onAppointmentDeletedEnabled { get; set; }
        public bool? onAppointmentDeletingEnabled { get; set; }
        public bool? onAppointmentFormCreatedEnabled { get; set; }
        public bool? onAppointmentRenderedEnabled { get; set; }
        public bool? onAppointmentUpdatedEnabled { get; set; }
        public bool? onAppointmentUpdatingEnabled { get; set; }
        public bool? onCellClickEnabled { get; set; }
        public bool? onCellContextMenuEnabled { get; set; }
        public string recurrenceEditMode { get; set; }
        public string recurrenceExceptionExpr { get; set; }
        public string recurrenceRuleExpr { get; set; }
        public bool? remoteFiltering { get; set; }
        public object resourceCellTemplate { get; set; }
        public object resources { get; set; }
        public object selectedCellData { get; set; }
        public bool? shadeUntilCurrentTime { get; set; }
        public bool? showAllDayPanel { get; set; }
        public bool? showCurrentTimeIndicator { get; set; }
        public string startDateExpr { get; set; }
        public string startDateTimeZoneExpr { get; set; }
        public float? startDayHour { get; set; }
        public string textExpr { get; set; }
        public object timeCellTemplate { get; set; }
        public string timeZone { get; set; }
        public bool? useDropDownViewSwitcher { get; set; }
        public object views { get; set; }
    }

    public static class DxSchedulerOptionsViews
    {
        public const string Day = "day";
        public const string Week = "week";
        public const string WorkWeek = "workWeek";
        public const string Month = "month";
        public const string TimelineDay = "timelineDay";
        public const string TimelineWeek = "timelineWeek";
        public const string TimelineWorkWeek = "timelineWorkWeek";
        public const string TimelineMonth = "timelineMonth";
        public const string Agenda = "agenda";
    }
    public partial class DxScrollViewOptions : DxScrollableOptions
    {
        public bool? onPullDownEnabled { get; set; }
        public bool? onReachBottomEnabled { get; set; }
        public string pulledDownText { get; set; }
        public string pullingDownText { get; set; }
        public string reachBottomText { get; set; }
        public string refreshingText { get; set; }
    }

    public partial class DxSelectBoxOptions : DxDropDownListOptions
    {
        public object fieldTemplate { get; set; }
        public bool? onCustomItemCreatingEnabled { get; set; }
        public bool? showSelectionControls { get; set; }
    }

    public partial class DxSliderOptions : DxSliderBaseOptions
    {
    }

    public partial class DxSlideOutOptions : CollectionWidgetOptions
    {
        public object contentTemplate { get; set; }
        public bool? menuGrouped { get; set; }
        public object menuGroupTemplate { get; set; }
        public object menuItemTemplate { get; set; }
        public string menuPosition { get; set; }
        public bool? menuVisible { get; set; }
        public bool? onMenuGroupRenderedEnabled { get; set; }
        public bool? onMenuItemRenderedEnabled { get; set; }
        public bool? swipeEnabled { get; set; }
    }

    public partial class DxSlideOutItemTemplate : CollectionWidgetItemTemplate
    {
        public object menuTemplate { get; set; }
    }

    public partial class DxSlideOutViewOptions : WidgetOptions
    {
        public object contentTemplate { get; set; }
        public string menuPosition { get; set; }
        public object menuTemplate { get; set; }
        public bool? menuVisible { get; set; }
        public bool? swipeEnabled { get; set; }
    }

    public partial class DxSwitchOptions : EditorOptions
    {
        public string name { get; set; }
        public string offText { get; set; }
        public string onText { get; set; }
    }

    public partial class DxTabsOptions : CollectionWidgetOptions
    {
        public bool? scrollByContent { get; set; }
        public bool? scrollingEnabled { get; set; }
        public string selectionMode { get; set; }
        public bool? showNavButtons { get; set; }
    }

    public partial class DxTabsItemTemplate : CollectionWidgetItemTemplate
    {
        public string badge { get; set; }
        public string icon { get; set; }
    }

    public partial class DxTabPanelOptions : DxMultiViewOptions
    {
        public object itemTitleTemplate { get; set; }
        public bool? onTitleClickEnabled { get; set; }
        public bool? onTitleHoldEnabled { get; set; }
        public bool? onTitleRenderedEnabled { get; set; }
        public bool? scrollByContent { get; set; }
        public bool? scrollingEnabled { get; set; }
        public bool? showNavButtons { get; set; }
    }

    public partial class DxTabPanelItemTemplate : DxMultiViewItemTemplate
    {
        public string badge { get; set; }
        public string icon { get; set; }
        public object tabTemplate { get; set; }
        public string title { get; set; }
    }

    public partial class DxTagBoxOptions : DxSelectBoxOptions
    {
        public bool? hideSelectedItems { get; set; }
        public float? maxDisplayedTags { get; set; }
        public bool? multiline { get; set; }
        public bool? onMultiTagPreparingEnabled { get; set; }
        public bool? onSelectAllValueChangedEnabled { get; set; }
        public string selectAllMode { get; set; }
        public object selectedItems { get; set; }
        public bool? showMultiTagOnly { get; set; }
        public object tagTemplate { get; set; }
    }

    public partial class DxTextAreaOptions : DxTextBoxOptions
    {
        public bool? autoResizeEnabled { get; set; }
        public object maxHeight { get; set; }
        public object minHeight { get; set; }
    }

    public partial class DxTextBoxOptions : DxTextEditorOptions
    {
        public object maxLength { get; set; }
        public string mode { get; set; }
    }

    public partial class DxTileViewOptions : CollectionWidgetOptions
    {
        public float? baseItemHeight { get; set; }
        public float? baseItemWidth { get; set; }
        public string direction { get; set; }
        public float? itemMargin { get; set; }
        public bool? showScrollbar { get; set; }
    }

    public partial class DxTileViewItemTemplate : CollectionWidgetItemTemplate
    {
        public float? heightRatio { get; set; }
        public float? widthRatio { get; set; }
    }

    public partial class DxToastOptions : DxOverlayOptions
    {
        public bool? closeOnClick { get; set; }
        public bool? closeOnSwipe { get; set; }
        public float? displayTime { get; set; }
        public string message { get; set; }
        public string type { get; set; }
    }

    public partial class DxToastAnimation : DxOverlayAnimation
    {
    }

    public partial class DxToolbarOptions : CollectionWidgetOptions
    {
        public object menuItemTemplate { get; set; }
        public string renderAs { get; set; }
    }

    public partial class DxToolbarItemTemplate : CollectionWidgetItemTemplate
    {
        public string locateInMenu { get; set; }
        public string location { get; set; }
        public object menuItemTemplate { get; set; }
        public object options { get; set; }
        public string showText { get; set; }
        public string widget { get; set; }
    }

    public partial class DxTooltipOptions : DxPopoverOptions
    {
    }

    public partial class DxTrackBarOptions : EditorOptions
    {
        public float? max { get; set; }
        public float? min { get; set; }
    }

    public partial class DxTreeListOptions : GridBaseOptions
    {
        public bool? autoExpandAll { get; set; }
        public object customizeColumns { get; set; }
        public string dataStructure { get; set; }
        public object expandedRowKeys { get; set; }
        public bool? expandNodesOnFiltering { get; set; }
        public object hasItemsExpr { get; set; }
        public object itemsExpr { get; set; }
        public object keyExpr { get; set; }
        public bool? onCellClickEnabled { get; set; }
        public bool? onCellHoverChangedEnabled { get; set; }
        public bool? onCellPreparedEnabled { get; set; }
        public bool? onContextMenuPreparingEnabled { get; set; }
        public bool? onEditingStartEnabled { get; set; }
        public bool? onEditorPreparedEnabled { get; set; }
        public bool? onEditorPreparingEnabled { get; set; }
        public bool? onNodesInitializedEnabled { get; set; }
        public bool? onRowClickEnabled { get; set; }
        public bool? onRowPreparedEnabled { get; set; }
        public object parentIdExpr { get; set; }
        public object remoteOperations { get; set; }
        public object rootValue { get; set; }
    }

    public partial class DxTreeListEditing : GridBaseEditing
    {
    }

    public partial class DxTreeListEditingTexts : GridBaseEditingTexts
    {
        public string addRowToNode { get; set; }
    }

    public partial class DxTreeListPaging : GridBasePaging
    {
    }

    public partial class DxTreeListScrolling : GridBaseScrolling
    {
        public string mode { get; set; }
    }

    public partial class DxTreeListSelection : GridBaseSelection
    {
        public bool? recursive { get; set; }
    }

    public partial class DxTreeViewOptions : HierarchicalCollectionWidgetOptions
    {
        public bool? animationEnabled { get; set; }
        public object createChildren { get; set; }
        public string dataStructure { get; set; }
        public bool? expandAllEnabled { get; set; }
        public object expandedExpr { get; set; }
        public bool? expandNodesRecursive { get; set; }
        public object hasItemsExpr { get; set; }
        public bool? onItemCollapsedEnabled { get; set; }
        public bool? onItemExpandedEnabled { get; set; }
        public bool? onItemSelectionChangedEnabled { get; set; }
        public object parentIdExpr { get; set; }
        public object rootValue { get; set; }
        public string scrollDirection { get; set; }
        public string selectAllText { get; set; }
        public bool? selectByClick { get; set; }
        public string selectionMode { get; set; }
        public bool? selectNodesRecursive { get; set; }
        public string showCheckBoxesMode { get; set; }
        public bool? virtualModeEnabled { get; set; }
        public object searchEditorOptions { get; set; }
        public bool? searchEnabled { get; set; }
        public object searchExpr { get; set; }
        public string searchMode { get; set; }
        public float? searchTimeout { get; set; }
        public string searchValue { get; set; }
    }

    public partial class RequiredRule
    {
        public string message { get; set; }
        public bool? trim { get; set; }
        public string type { get; set; }
    }

    public partial class NumericRule
    {
        public string message { get; set; }
        public string type { get; set; }
    }

    public partial class RangeRule
    {
        public object max { get; set; }
        public string message { get; set; }
        public object min { get; set; }
        public bool? reevaluate { get; set; }
        public string type { get; set; }
    }

    public partial class StringLengthRule
    {
        public float? max { get; set; }
        public string message { get; set; }
        public float? min { get; set; }
        public bool? trim { get; set; }
        public string type { get; set; }
    }

    public partial class CustomRule
    {
        public string message { get; set; }
        public bool? reevaluate { get; set; }
        public string type { get; set; }
        public object validationCallback { get; set; }
    }

    public partial class CompareRule
    {
        public object comparisonTarget { get; set; }
        public string comparisonType { get; set; }
        public string message { get; set; }
        public bool? reevaluate { get; set; }
        public string type { get; set; }
    }

    public partial class PatternRule
    {
        public string message { get; set; }
        public object pattern { get; set; }
        public string type { get; set; }
    }

    public partial class EmailRule
    {
        public string message { get; set; }
        public string type { get; set; }
    }

    public partial class DxValidationGroupResult
    {
        public object brokenRules { get; set; }
        public bool? isValid { get; set; }
        public object validators { get; set; }
    }

    public partial class DxValidatorResult
    {
        public object brokenRule { get; set; }
        public bool? isValid { get; set; }
        public object validationRules { get; set; }
        public object value { get; set; }
    }

    public partial class DxValidationGroupOptions : DOMComponentOptions
    {
    }

    public partial class DxValidationSummaryOptions : CollectionWidgetOptions
    {
        public string validationGroup { get; set; }
    }

    public partial class DxValidatorOptions : DOMComponentOptions
    {
        public object adapter { get; set; }
        public string name { get; set; }
        public bool? onValidatedEnabled { get; set; }
        public string validationGroup { get; set; }
        public object validationRules { get; set; }
    }

    public partial class DxCalendarCellTemplate
    {
        public object date { get; set; }
        public string text { get; set; }
        public string view { get; set; }
    }

    public partial class CollectionWidgetOptions : WidgetOptions
    {
        public object dataSource { get; set; }
        public float? itemHoldTimeout { get; set; }
        public object items { get; set; }
        public object itemTemplate { get; set; }
        public object keyExpr { get; set; }
        public string noDataText { get; set; }
        public bool? onItemClickEnabled { get; set; }
        public bool? onItemContextMenuEnabled { get; set; }
        public bool? onItemHoldEnabled { get; set; }
        public bool? onItemRenderedEnabled { get; set; }
        public bool? onSelectionChangedEnabled { get; set; }
        public float? selectedIndex { get; set; }
        public object selectedItem { get; set; }
        public object selectedItemKeys { get; set; }
        public object selectedItems { get; set; }
    }

    public partial class CollectionWidgetItemTemplate
    {
        public bool? disabled { get; set; }
        public string html { get; set; }
        public object template { get; set; }
        public string text { get; set; }
        public bool? visible { get; set; }
    }

    public partial class DxContextMenuItemTemplate : DxMenuBaseItemTemplate
    {
    }

    public partial class DxMenuBaseOptions : HierarchicalCollectionWidgetOptions
    {
        public object animation { get; set; }
        public string cssClass { get; set; }
        public bool? selectByClick { get; set; }
        public string selectionMode { get; set; }
        public object showSubmenuMode { get; set; }
    }

    public partial class DxMenuBaseItemTemplate : CollectionWidgetItemTemplate
    {
        public bool? beginGroup { get; set; }
        public bool? closeMenuOnClick { get; set; }
        public string icon { get; set; }
        public object items { get; set; }
        public bool? selectable { get; set; }
        public bool? selected { get; set; }
    }

    public partial class DxDataGridColumn : GridBaseColumn
    {
        public bool? allowExporting { get; set; }
        public bool? allowGrouping { get; set; }
        public bool? autoExpandGroup { get; set; }
        public object calculateGroupValue { get; set; }
        public object columns { get; set; }
        public object groupCellTemplate { get; set; }
        public float? groupIndex { get; set; }
        public float? precision { get; set; }
        public bool? showWhenGrouped { get; set; }
    }

    public partial class DxDropDownEditorOptions : DxTextBoxOptions
    {
        public bool? acceptCustomValue { get; set; }
        public string applyValueMode { get; set; }
        public bool? deferRendering { get; set; }
        public object dropDownButtonTemplate { get; set; }
        public bool? onClosedEnabled { get; set; }
        public bool? onOpenedEnabled { get; set; }
        public bool? opened { get; set; }
    }

    public partial class DxDropDownListOptions : DxDropDownEditorOptions
    {
        public string displayValue { get; set; }
        public bool? grouped { get; set; }
        public object groupTemplate { get; set; }
        public float? minSearchLength { get; set; }
        public string noDataText { get; set; }
        public bool? onItemClickEnabled { get; set; }
        public bool? onSelectionChangedEnabled { get; set; }
        public bool? searchEnabled { get; set; }
        public object searchExpr { get; set; }
        public string searchMode { get; set; }
        public float? searchTimeout { get; set; }
        public object selectedItem { get; set; }
        public bool? showDataBeforeSearch { get; set; }
        public object dataSource { get; set; }
        public object displayExpr { get; set; }
        public object items { get; set; }
        public object itemTemplate { get; set; }
        public object valueExpr { get; set; }
    }

    public partial class EditorOptions : WidgetOptions
    {
        public bool? isValid { get; set; }
        public bool? onValueChangedEnabled { get; set; }
        public bool? readOnly { get; set; }
        public object validationError { get; set; }
        public string validationMessageMode { get; set; }
        public object value { get; set; }
    }

    public partial class DataExpressionMixinOptions
    {
        public object dataSource { get; set; }
        public object displayExpr { get; set; }
        public object items { get; set; }
        public object itemTemplate { get; set; }
        public object value { get; set; }
        public object valueExpr { get; set; }
    }

    public partial class DataExpressionMixinItemTemplate
    {
        public bool? disabled { get; set; }
        public string html { get; set; }
        public object template { get; set; }
        public string text { get; set; }
        public bool? visible { get; set; }
    }

    public partial class DxFilterBuilderField
    {
        public object calculateFilterExpression { get; set; }
        public string caption { get; set; }
        public object customizeText { get; set; }
        public string dataField { get; set; }
        public string dataType { get; set; }
        public object editorOptions { get; set; }
        public object editorTemplate { get; set; }
        public string falseText { get; set; }
        public object filterOperations { get; set; }
        public object format { get; set; }
        public object lookup { get; set; }
        public string trueText { get; set; }
    }

    public static class DxFilterBuilderFieldFilterOperations
    {
        public const string Assignment = "=";
        public const string LowerGreaterThan = "<>";
        public const string LowerThan = "<";
        public const string LowerOrEqualThan = "<=";
        public const string GreaterThan = ">";
        public const string GreaterThanEqual = ">=";
        public const string Contains = "contains";
        public const string Endswith = "endswith";
        public const string Isblank = "isblank";
        public const string Isnotblank = "isnotblank";
        public const string Notcontains = "notcontains";
        public const string Startswith = "startswith";
        public const string Between = "between";
    }
    public partial class DxFilterBuilderCustomOperation
    {
        public object calculateFilterExpression { get; set; }
        public string caption { get; set; }
        public object customizeText { get; set; }
        public object dataTypes { get; set; }
        public object editorTemplate { get; set; }
        public bool? hasValue { get; set; }
        public string icon { get; set; }
        public string name { get; set; }
    }

    public static class DxFilterBuilderCustomOperationDataTypes
    {
        public const string String = "string";
        public const string Number = "number";
        public const string Date = "date";
        public const string Boolean = "boolean";
        public const string Object = "object";
        public const string Datetime = "datetime";
    }
    public partial class ColCountResponsible
    {
        public float? lg { get; set; }
        public float? md { get; set; }
        public float? sm { get; set; }
        public float? xs { get; set; }
    }

    public partial class DxFormSimpleItem
    {
        public float? colSpan { get; set; }
        public string cssClass { get; set; }
        public string dataField { get; set; }
        public object editorOptions { get; set; }
        public string editorType { get; set; }
        public string helpText { get; set; }
        public bool? isRequired { get; set; }
        public string itemType { get; set; }
        public object label { get; set; }
        public string name { get; set; }
        public object template { get; set; }
        public object validationRules { get; set; }
        public bool? visible { get; set; }
        public float? visibleIndex { get; set; }
    }

    public partial class DxFormGroupItem
    {
        public bool? alignItemLabels { get; set; }
        public string caption { get; set; }
        public float? colCount { get; set; }
        public object colCountByScreen { get; set; }
        public float? colSpan { get; set; }
        public string cssClass { get; set; }
        public object items { get; set; }
        public string itemType { get; set; }
        public string name { get; set; }
        public object template { get; set; }
        public bool? visible { get; set; }
        public float? visibleIndex { get; set; }
    }

    public partial class DxFormTabbedItem
    {
        public float? colSpan { get; set; }
        public string cssClass { get; set; }
        public string itemType { get; set; }
        public string name { get; set; }
        public object tabPanelOptions { get; set; }
        public object tabs { get; set; }
        public bool? visible { get; set; }
        public float? visibleIndex { get; set; }
    }

    public partial class DxFormEmptyItem
    {
        public float? colSpan { get; set; }
        public string cssClass { get; set; }
        public string itemType { get; set; }
        public string name { get; set; }
        public bool? visible { get; set; }
        public float? visibleIndex { get; set; }
    }

    public partial class DxFormButtonItem
    {
        public string alignment { get; set; }
        public object buttonOptions { get; set; }
        public float? colSpan { get; set; }
        public string cssClass { get; set; }
        public string itemType { get; set; }
        public string name { get; set; }
        public bool? visible { get; set; }
        public float? visibleIndex { get; set; }
    }

    public partial class GridBaseColumn
    {
        public object alignment { get; set; }
        public bool? allowEditing { get; set; }
        public bool? allowFiltering { get; set; }
        public bool? allowFixing { get; set; }
        public bool? allowHeaderFiltering { get; set; }
        public bool? allowHiding { get; set; }
        public bool? allowReordering { get; set; }
        public bool? allowResizing { get; set; }
        public bool? allowSearch { get; set; }
        public bool? allowSorting { get; set; }
        public object calculateCellValue { get; set; }
        public object calculateDisplayValue { get; set; }
        public object calculateFilterExpression { get; set; }
        public object calculateSortValue { get; set; }
        public string caption { get; set; }
        public object cellTemplate { get; set; }
        public string cssClass { get; set; }
        public object customizeText { get; set; }
        public string dataField { get; set; }
        public string dataType { get; set; }
        public object editCellTemplate { get; set; }
        public object editorOptions { get; set; }
        public bool? encodeHtml { get; set; }
        public string falseText { get; set; }
        public object filterOperations { get; set; }
        public string filterType { get; set; }
        public object filterValue { get; set; }
        public object filterValues { get; set; }
        public bool? @fixed { get; set; }
        public string fixedPosition { get; set; }
        public object format { get; set; }
        public object formItem { get; set; }
        public object headerCellTemplate { get; set; }
        public object headerFilter { get; set; }
        public float? hidingPriority { get; set; }
        public bool? isBand { get; set; }
        public object lookup { get; set; }
        public float? minWidth { get; set; }
        public string name { get; set; }
        public float? ownerBand { get; set; }
        public string selectedFilterOperation { get; set; }
        public object setCellValue { get; set; }
        public bool? showEditorAlways { get; set; }
        public bool? showInColumnChooser { get; set; }
        public float? sortIndex { get; set; }
        public object sortingMethod { get; set; }
        public object sortOrder { get; set; }
        public string trueText { get; set; }
        public object validationRules { get; set; }
        public bool? visible { get; set; }
        public float? visibleIndex { get; set; }
        public object width { get; set; }
    }

    public static class GridBaseColumnFilterOperations
    {
        public const string Assignment = "=";
        public const string LowerGreaterThan = "<>";
        public const string LowerThan = "<";
        public const string LowerOrEqualThan = "<=";
        public const string GreaterThan = ">";
        public const string GreaterThanEqual = ">=";
        public const string Notcontains = "notcontains";
        public const string Contains = "contains";
        public const string Startswith = "startswith";
        public const string Endswith = "endswith";
        public const string Between = "between";
    }
    public partial class DxTreeListColumn : GridBaseColumn
    {
        public object columns { get; set; }
    }

    public partial class DxDataGridRowObject
    {
        public object data { get; set; }
        public float? groupIndex { get; set; }
        public bool? isEditing { get; set; }
        public bool? isExpanded { get; set; }
        public bool? isSelected { get; set; }
        public object key { get; set; }
        public float? rowIndex { get; set; }
        public string rowType { get; set; }
        public object values { get; set; }
    }

    public partial class DxTreeListRowObject
    {
        public bool? isEditing { get; set; }
        public bool? isExpanded { get; set; }
        public bool? isSelected { get; set; }
        public object key { get; set; }
        public float? level { get; set; }
        public object node { get; set; }
        public float? rowIndex { get; set; }
        public string rowType { get; set; }
        public object values { get; set; }
    }

    public partial class HierarchicalCollectionWidgetOptions : CollectionWidgetOptions
    {
        public object disabledExpr { get; set; }
        public object displayExpr { get; set; }
        public object itemsExpr { get; set; }
        public object selectedExpr { get; set; }
    }

    public partial class DxListItemTemplate : CollectionWidgetItemTemplate
    {
        public string badge { get; set; }
        public string key { get; set; }
        public bool? showChevron { get; set; }
    }

    public partial class DxMenuItemTemplate : DxMenuBaseItemTemplate
    {
    }

    public partial class DxPivotGridPivotGridCell
    {
        public object columnPath { get; set; }
        public string columnType { get; set; }
        public float? dataIndex { get; set; }
        public bool? expanded { get; set; }
        public object path { get; set; }
        public object rowPath { get; set; }
        public string rowType { get; set; }
        public string text { get; set; }
        public string type { get; set; }
        public object value { get; set; }
    }

    public partial class DxSchedulerAppointmentTemplate : CollectionWidgetItemTemplate
    {
        public bool? allDay { get; set; }
        public string description { get; set; }
        public object endDate { get; set; }
        public string endDateTimeZone { get; set; }
        public string recurrenceException { get; set; }
        public string recurrenceRule { get; set; }
        public object startDate { get; set; }
        public string startDateTimeZone { get; set; }
    }

    public partial class DxSchedulerAppointmentTooltipTemplate
    {
        public bool? allDay { get; set; }
        public string description { get; set; }
        public object endDate { get; set; }
        public string endDateTimeZone { get; set; }
        public string recurrenceException { get; set; }
        public string recurrenceRule { get; set; }
        public object startDate { get; set; }
        public string startDateTimeZone { get; set; }
        public string text { get; set; }
    }

    public partial class DxScrollableOptions : DOMComponentOptions
    {
        public bool? bounceEnabled { get; set; }
        public string direction { get; set; }
        public bool? disabled { get; set; }
        public bool? onScrollEnabled { get; set; }
        public bool? onUpdatedEnabled { get; set; }
        public bool? scrollByContent { get; set; }
        public bool? scrollByThumb { get; set; }
        public string showScrollbar { get; set; }
        public bool? useNative { get; set; }
    }

    public partial class DxSliderBaseOptions : DxTrackBarOptions
    {
        public float? keyStep { get; set; }
        public object label { get; set; }
        public string name { get; set; }
        public bool? showRange { get; set; }
        public float? step { get; set; }
        public object tooltip { get; set; }
    }

    public partial class DxTextEditorOptions : EditorOptions
    {
        public object inputAttr { get; set; }
        public string mask { get; set; }
        public string maskChar { get; set; }
        public string maskInvalidMessage { get; set; }
        public object maskRules { get; set; }
        public string name { get; set; }
        public bool? onChangeEnabled { get; set; }
        public bool? onCopyEnabled { get; set; }
        public bool? onCutEnabled { get; set; }
        public bool? onEnterKeyEnabled { get; set; }
        public bool? onFocusInEnabled { get; set; }
        public bool? onFocusOutEnabled { get; set; }
        public bool? onInputEnabled { get; set; }
        public bool? onKeyDownEnabled { get; set; }
        public bool? onKeyPressEnabled { get; set; }
        public bool? onKeyUpEnabled { get; set; }
        public bool? onPasteEnabled { get; set; }
        public string placeholder { get; set; }
        public bool? showClearButton { get; set; }
        public string showMaskMode { get; set; }
        public bool? spellcheck { get; set; }
        public string text { get; set; }
        public bool? useMaskedValue { get; set; }
        public string valueChangeEvent { get; set; }
    }

    public partial class DxTreeListNode
    {
        public object children { get; set; }
        public object data { get; set; }
        public bool? hasChildren { get; set; }
        public object key { get; set; }
        public float? level { get; set; }
        public object parent { get; set; }
        public bool? visible { get; set; }
    }

    public partial class DxTreeViewItemTemplate : CollectionWidgetItemTemplate
    {
        public bool? expanded { get; set; }
        public bool? hasItems { get; set; }
        public string icon { get; set; }
        public object items { get; set; }
        public object parentId { get; set; }
        public bool? selected { get; set; }
    }

    public partial class DxTreeViewNode
    {
        public object children { get; set; }
        public bool? disabled { get; set; }
        public bool? expanded { get; set; }
        public object itemData { get; set; }
        public object key { get; set; }
        public object parent { get; set; }
        public bool? selected { get; set; }
        public string text { get; set; }
    }

    public partial class SearchBoxMixinOptions
    {
        public object searchEditorOptions { get; set; }
        public bool? searchEnabled { get; set; }
        public object searchExpr { get; set; }
        public string searchMode { get; set; }
        public float? searchTimeout { get; set; }
        public string searchValue { get; set; }
    }

    public partial class DxTemplateOptions
    {
        public string name { get; set; }
    }

    public partial class WidgetOptions : DOMComponentOptions
    {
        public string accessKey { get; set; }
        public bool? activeStateEnabled { get; set; }
        public bool? disabled { get; set; }
        public bool? focusStateEnabled { get; set; }
        public string hint { get; set; }
        public bool? hoverStateEnabled { get; set; }
        public bool? onContentReadyEnabled { get; set; }
        public float? tabIndex { get; set; }
        public bool? visible { get; set; }
    }

}
namespace DevExpress.Viz
{
    public partial class BaseWidgetOptions : DOMComponentOptions
    {
        public object export { get; set; }
        public object loadingIndicator { get; set; }
        public object margin { get; set; }
        public bool? onDrawnEnabled { get; set; }
        public bool? onExportedEnabled { get; set; }
        public bool? onExportingEnabled { get; set; }
        public bool? onFileSavingEnabled { get; set; }
        public bool? onIncidentOccurredEnabled { get; set; }
        public bool? pathModified { get; set; }
        public bool? redrawOnResize { get; set; }
        public object size { get; set; }
        public string theme { get; set; }
        public object title { get; set; }
        public object tooltip { get; set; }
    }

    public partial class BaseWidgetExport
    {
        public string backgroundColor { get; set; }
        public bool? enabled { get; set; }
        public string fileName { get; set; }
        public object formats { get; set; }
        public bool? printingEnabled { get; set; }
        public string proxyUrl { get; set; }
    }

    public partial class BaseWidgetLoadingIndicator
    {
        public string backgroundColor { get; set; }
        public object font { get; set; }
        public bool? show { get; set; }
        public string text { get; set; }
    }

    public partial class BaseWidgetMargin
    {
        public float? bottom { get; set; }
        public float? left { get; set; }
        public float? right { get; set; }
        public float? top { get; set; }
    }

    public partial class BaseWidgetSize
    {
        public float? height { get; set; }
        public float? width { get; set; }
    }

    public partial class BaseWidgetTitle
    {
        public object font { get; set; }
        public string horizontalAlignment { get; set; }
        public object margin { get; set; }
        public float? placeholderSize { get; set; }
        public object subtitle { get; set; }
        public string text { get; set; }
        public string verticalAlignment { get; set; }
    }

    public partial class BaseWidgetTooltip
    {
        public float? arrowLength { get; set; }
        public object border { get; set; }
        public string color { get; set; }
        public object container { get; set; }
        public bool? enabled { get; set; }
        public object font { get; set; }
        public object format { get; set; }
        public float? opacity { get; set; }
        public float? paddingLeftRight { get; set; }
        public float? paddingTopBottom { get; set; }
        public float? precision { get; set; }
        public object shadow { get; set; }
        public float? zIndex { get; set; }
    }

    public partial class ScaleBreak
    {
        public object endValue { get; set; }
        public object startValue { get; set; }
    }

    public partial class VizTimeInterval
    {
        public float? days { get; set; }
        public float? hours { get; set; }
        public float? milliseconds { get; set; }
        public float? minutes { get; set; }
        public float? months { get; set; }
        public float? quarters { get; set; }
        public float? seconds { get; set; }
        public float? weeks { get; set; }
        public float? years { get; set; }
    }

    public partial class DxChartSeriesTypes
    {
        public object AreaSeries { get; set; }
        public object BarSeries { get; set; }
        public object BubbleSeries { get; set; }
        public object CandleStickSeries { get; set; }
        public object CommonSeries { get; set; }
        public object FullStackedAreaSeries { get; set; }
        public object FullStackedBarSeries { get; set; }
        public object FullStackedLineSeries { get; set; }
        public object FullStackedSplineAreaSeries { get; set; }
        public object FullStackedSplineSeries { get; set; }
        public object LineSeries { get; set; }
        public object RangeAreaSeries { get; set; }
        public object RangeBarSeries { get; set; }
        public object ScatterSeries { get; set; }
        public object SplineAreaSeries { get; set; }
        public object SplineSeries { get; set; }
        public object StackedAreaSeries { get; set; }
        public object StackedBarSeries { get; set; }
        public object StackedLineSeries { get; set; }
        public object StackedSplineAreaSeries { get; set; }
        public object StackedSplineSeries { get; set; }
        public object StepAreaSeries { get; set; }
        public object StepLineSeries { get; set; }
        public object StockSeries { get; set; }
    }

    public partial class DxChartSeriesTypesAreaSeries : DxChartSeriesTypesCommonSeries
    {
    }

    public partial class DxChartSeriesTypesAreaSeriesAggregation : DxChartSeriesTypesCommonSeriesAggregation
    {
    }

    public partial class DxChartSeriesTypesAreaSeriesLabel : DxChartSeriesTypesCommonSeriesLabel
    {
    }

    public partial class DxChartSeriesTypesAreaSeriesPoint : DxChartSeriesTypesCommonSeriesPoint
    {
    }

    public partial class DxChartSeriesTypesBarSeries : DxChartSeriesTypesCommonSeries
    {
    }

    public partial class DxChartSeriesTypesBarSeriesAggregation : DxChartSeriesTypesCommonSeriesAggregation
    {
    }

    public partial class DxChartSeriesTypesBarSeriesLabel : DxChartSeriesTypesCommonSeriesLabel
    {
    }

    public partial class DxChartSeriesTypesBubbleSeries : DxChartSeriesTypesCommonSeries
    {
    }

    public partial class DxChartSeriesTypesBubbleSeriesAggregation : DxChartSeriesTypesCommonSeriesAggregation
    {
    }

    public partial class DxChartSeriesTypesBubbleSeriesLabel : DxChartSeriesTypesCommonSeriesLabel
    {
    }

    public partial class DxChartSeriesTypesCandleStickSeries : DxChartSeriesTypesCommonSeries
    {
    }

    public partial class DxChartSeriesTypesCandleStickSeriesAggregation : DxChartSeriesTypesCommonSeriesAggregation
    {
    }

    public partial class DxChartSeriesTypesCandleStickSeriesHoverStyle : DxChartSeriesTypesCommonSeriesHoverStyle
    {
    }

    public partial class DxChartSeriesTypesCandleStickSeriesHoverStyleHatching : DxChartSeriesTypesCommonSeriesHoverStyleHatching
    {
    }

    public partial class DxChartSeriesTypesCandleStickSeriesLabel : DxChartSeriesTypesCommonSeriesLabel
    {
    }

    public partial class DxChartSeriesTypesCandleStickSeriesSelectionStyle : DxChartSeriesTypesCommonSeriesSelectionStyle
    {
    }

    public partial class DxChartSeriesTypesCandleStickSeriesSelectionStyleHatching : DxChartSeriesTypesCommonSeriesSelectionStyleHatching
    {
    }

    public partial class DxChartSeriesTypesCommonSeries
    {
        public object aggregation { get; set; }
        public string argumentField { get; set; }
        public string axis { get; set; }
        public float? barPadding { get; set; }
        public float? barWidth { get; set; }
        public object border { get; set; }
        public string closeValueField { get; set; }
        public string color { get; set; }
        public float? cornerRadius { get; set; }
        public string dashStyle { get; set; }
        public string highValueField { get; set; }
        public string hoverMode { get; set; }
        public object hoverStyle { get; set; }
        public bool? ignoreEmptyPoints { get; set; }
        public string innerColor { get; set; }
        public object label { get; set; }
        public string lowValueField { get; set; }
        public float? maxLabelCount { get; set; }
        public float? minBarSize { get; set; }
        public float? opacity { get; set; }
        public string openValueField { get; set; }
        public string pane { get; set; }
        public object point { get; set; }
        public string rangeValue1Field { get; set; }
        public string rangeValue2Field { get; set; }
        public object reduction { get; set; }
        public string selectionMode { get; set; }
        public object selectionStyle { get; set; }
        public bool? showInLegend { get; set; }
        public string sizeField { get; set; }
        public string stack { get; set; }
        public string tagField { get; set; }
        public object valueErrorBar { get; set; }
        public string valueField { get; set; }
        public bool? visible { get; set; }
        public float? width { get; set; }
    }

    public partial class DxChartSeriesTypesCommonSeriesAggregation
    {
        public object calculate { get; set; }
        public bool? enabled { get; set; }
        public string method { get; set; }
    }

    public partial class DxChartSeriesTypesCommonSeriesBorder
    {
        public string color { get; set; }
        public string dashStyle { get; set; }
        public bool? visible { get; set; }
        public float? width { get; set; }
    }

    public partial class DxChartSeriesTypesCommonSeriesHoverStyle
    {
        public object border { get; set; }
        public string color { get; set; }
        public string dashStyle { get; set; }
        public object hatching { get; set; }
        public float? width { get; set; }
    }

    public partial class DxChartSeriesTypesCommonSeriesHoverStyleBorder
    {
        public string color { get; set; }
        public string dashStyle { get; set; }
        public bool? visible { get; set; }
        public float? width { get; set; }
    }

    public partial class DxChartSeriesTypesCommonSeriesHoverStyleHatching
    {
        public string direction { get; set; }
        public float? opacity { get; set; }
        public float? step { get; set; }
        public float? width { get; set; }
    }

    public partial class DxChartSeriesTypesCommonSeriesLabel
    {
        public string alignment { get; set; }
        public object argumentFormat { get; set; }
        public float? argumentPrecision { get; set; }
        public string backgroundColor { get; set; }
        public object border { get; set; }
        public object connector { get; set; }
        public object customizeText { get; set; }
        public object font { get; set; }
        public object format { get; set; }
        public float? horizontalOffset { get; set; }
        public float? percentPrecision { get; set; }
        public string position { get; set; }
        public float? precision { get; set; }
        public float? rotationAngle { get; set; }
        public bool? showForZeroValues { get; set; }
        public float? verticalOffset { get; set; }
        public bool? visible { get; set; }
    }

    public partial class DxChartSeriesTypesCommonSeriesPoint
    {
        public object border { get; set; }
        public string color { get; set; }
        public string hoverMode { get; set; }
        public object hoverStyle { get; set; }
        public object image { get; set; }
        public string selectionMode { get; set; }
        public object selectionStyle { get; set; }
        public float? size { get; set; }
        public string symbol { get; set; }
        public bool? visible { get; set; }
    }

    public partial class DxChartSeriesTypesCommonSeriesSelectionStyle
    {
        public object border { get; set; }
        public string color { get; set; }
        public string dashStyle { get; set; }
        public object hatching { get; set; }
        public float? width { get; set; }
    }

    public partial class DxChartSeriesTypesCommonSeriesSelectionStyleBorder
    {
        public string color { get; set; }
        public string dashStyle { get; set; }
        public bool? visible { get; set; }
        public float? width { get; set; }
    }

    public partial class DxChartSeriesTypesCommonSeriesSelectionStyleHatching
    {
        public string direction { get; set; }
        public float? opacity { get; set; }
        public float? step { get; set; }
        public float? width { get; set; }
    }

    public partial class DxChartSeriesTypesFullStackedAreaSeries : DxChartSeriesTypesCommonSeries
    {
    }

    public partial class DxChartSeriesTypesFullStackedAreaSeriesAggregation : DxChartSeriesTypesCommonSeriesAggregation
    {
    }

    public partial class DxChartSeriesTypesFullStackedAreaSeriesLabel : DxChartSeriesTypesCommonSeriesLabel
    {
    }

    public partial class DxChartSeriesTypesFullStackedAreaSeriesPoint : DxChartSeriesTypesCommonSeriesPoint
    {
    }

    public partial class DxChartSeriesTypesFullStackedBarSeries : DxChartSeriesTypesCommonSeries
    {
    }

    public partial class DxChartSeriesTypesFullStackedBarSeriesAggregation : DxChartSeriesTypesCommonSeriesAggregation
    {
    }

    public partial class DxChartSeriesTypesFullStackedBarSeriesLabel : DxChartSeriesTypesCommonSeriesLabel
    {
    }

    public partial class DxChartSeriesTypesFullStackedLineSeries : DxChartSeriesTypesCommonSeries
    {
    }

    public partial class DxChartSeriesTypesFullStackedLineSeriesAggregation : DxChartSeriesTypesCommonSeriesAggregation
    {
    }

    public partial class DxChartSeriesTypesFullStackedLineSeriesLabel : DxChartSeriesTypesCommonSeriesLabel
    {
    }

    public partial class DxChartSeriesTypesFullStackedSplineAreaSeries : DxChartSeriesTypesCommonSeries
    {
    }

    public partial class DxChartSeriesTypesFullStackedSplineAreaSeriesAggregation : DxChartSeriesTypesCommonSeriesAggregation
    {
    }

    public partial class DxChartSeriesTypesFullStackedSplineAreaSeriesLabel : DxChartSeriesTypesCommonSeriesLabel
    {
    }

    public partial class DxChartSeriesTypesFullStackedSplineAreaSeriesPoint : DxChartSeriesTypesCommonSeriesPoint
    {
    }

    public partial class DxChartSeriesTypesFullStackedSplineSeries : DxChartSeriesTypesCommonSeries
    {
    }

    public partial class DxChartSeriesTypesFullStackedSplineSeriesAggregation : DxChartSeriesTypesCommonSeriesAggregation
    {
    }

    public partial class DxChartSeriesTypesFullStackedSplineSeriesLabel : DxChartSeriesTypesCommonSeriesLabel
    {
    }

    public partial class DxChartSeriesTypesLineSeries : DxChartSeriesTypesCommonSeries
    {
    }

    public partial class DxChartSeriesTypesLineSeriesAggregation : DxChartSeriesTypesCommonSeriesAggregation
    {
    }

    public partial class DxChartSeriesTypesLineSeriesLabel : DxChartSeriesTypesCommonSeriesLabel
    {
    }

    public partial class DxChartSeriesTypesRangeAreaSeries : DxChartSeriesTypesCommonSeries
    {
    }

    public partial class DxChartSeriesTypesRangeAreaSeriesAggregation : DxChartSeriesTypesCommonSeriesAggregation
    {
    }

    public partial class DxChartSeriesTypesRangeAreaSeriesLabel : DxChartSeriesTypesCommonSeriesLabel
    {
    }

    public partial class DxChartSeriesTypesRangeAreaSeriesPoint : DxChartSeriesTypesCommonSeriesPoint
    {
    }

    public partial class DxChartSeriesTypesRangeBarSeries : DxChartSeriesTypesCommonSeries
    {
    }

    public partial class DxChartSeriesTypesRangeBarSeriesAggregation : DxChartSeriesTypesCommonSeriesAggregation
    {
    }

    public partial class DxChartSeriesTypesRangeBarSeriesLabel : DxChartSeriesTypesCommonSeriesLabel
    {
    }

    public partial class DxChartSeriesTypesScatterSeries : DxChartSeriesTypesCommonSeries
    {
    }

    public partial class DxChartSeriesTypesScatterSeriesAggregation : DxChartSeriesTypesCommonSeriesAggregation
    {
    }

    public partial class DxChartSeriesTypesScatterSeriesLabel : DxChartSeriesTypesCommonSeriesLabel
    {
    }

    public partial class DxChartSeriesTypesSplineAreaSeries : DxChartSeriesTypesCommonSeries
    {
    }

    public partial class DxChartSeriesTypesSplineAreaSeriesAggregation : DxChartSeriesTypesCommonSeriesAggregation
    {
    }

    public partial class DxChartSeriesTypesSplineAreaSeriesLabel : DxChartSeriesTypesCommonSeriesLabel
    {
    }

    public partial class DxChartSeriesTypesSplineAreaSeriesPoint : DxChartSeriesTypesCommonSeriesPoint
    {
    }

    public partial class DxChartSeriesTypesSplineSeries : DxChartSeriesTypesCommonSeries
    {
    }

    public partial class DxChartSeriesTypesSplineSeriesAggregation : DxChartSeriesTypesCommonSeriesAggregation
    {
    }

    public partial class DxChartSeriesTypesSplineSeriesLabel : DxChartSeriesTypesCommonSeriesLabel
    {
    }

    public partial class DxChartSeriesTypesStackedAreaSeries : DxChartSeriesTypesCommonSeries
    {
    }

    public partial class DxChartSeriesTypesStackedAreaSeriesAggregation : DxChartSeriesTypesCommonSeriesAggregation
    {
    }

    public partial class DxChartSeriesTypesStackedAreaSeriesLabel : DxChartSeriesTypesCommonSeriesLabel
    {
    }

    public partial class DxChartSeriesTypesStackedAreaSeriesPoint : DxChartSeriesTypesCommonSeriesPoint
    {
    }

    public partial class DxChartSeriesTypesStackedBarSeries : DxChartSeriesTypesCommonSeries
    {
    }

    public partial class DxChartSeriesTypesStackedBarSeriesAggregation : DxChartSeriesTypesCommonSeriesAggregation
    {
    }

    public partial class DxChartSeriesTypesStackedBarSeriesLabel : DxChartSeriesTypesCommonSeriesLabel
    {
    }

    public partial class DxChartSeriesTypesStackedLineSeries : DxChartSeriesTypesCommonSeries
    {
    }

    public partial class DxChartSeriesTypesStackedLineSeriesAggregation : DxChartSeriesTypesCommonSeriesAggregation
    {
    }

    public partial class DxChartSeriesTypesStackedLineSeriesLabel : DxChartSeriesTypesCommonSeriesLabel
    {
    }

    public partial class DxChartSeriesTypesStackedSplineAreaSeries : DxChartSeriesTypesCommonSeries
    {
    }

    public partial class DxChartSeriesTypesStackedSplineAreaSeriesAggregation : DxChartSeriesTypesCommonSeriesAggregation
    {
    }

    public partial class DxChartSeriesTypesStackedSplineAreaSeriesLabel : DxChartSeriesTypesCommonSeriesLabel
    {
    }

    public partial class DxChartSeriesTypesStackedSplineAreaSeriesPoint : DxChartSeriesTypesCommonSeriesPoint
    {
    }

    public partial class DxChartSeriesTypesStackedSplineSeries : DxChartSeriesTypesCommonSeries
    {
    }

    public partial class DxChartSeriesTypesStackedSplineSeriesAggregation : DxChartSeriesTypesCommonSeriesAggregation
    {
    }

    public partial class DxChartSeriesTypesStackedSplineSeriesLabel : DxChartSeriesTypesCommonSeriesLabel
    {
    }

    public partial class DxChartSeriesTypesStepAreaSeries : DxChartSeriesTypesCommonSeries
    {
    }

    public partial class DxChartSeriesTypesStepAreaSeriesAggregation : DxChartSeriesTypesCommonSeriesAggregation
    {
    }

    public partial class DxChartSeriesTypesStepAreaSeriesBorder : DxChartSeriesTypesCommonSeriesBorder
    {
    }

    public partial class DxChartSeriesTypesStepAreaSeriesHoverStyle : DxChartSeriesTypesCommonSeriesHoverStyle
    {
    }

    public partial class DxChartSeriesTypesStepAreaSeriesHoverStyleBorder : DxChartSeriesTypesCommonSeriesHoverStyleBorder
    {
    }

    public partial class DxChartSeriesTypesStepAreaSeriesLabel : DxChartSeriesTypesCommonSeriesLabel
    {
    }

    public partial class DxChartSeriesTypesStepAreaSeriesPoint : DxChartSeriesTypesCommonSeriesPoint
    {
    }

    public partial class DxChartSeriesTypesStepAreaSeriesSelectionStyle : DxChartSeriesTypesCommonSeriesSelectionStyle
    {
    }

    public partial class DxChartSeriesTypesStepAreaSeriesSelectionStyleBorder : DxChartSeriesTypesCommonSeriesSelectionStyleBorder
    {
    }

    public partial class DxChartSeriesTypesStepLineSeries : DxChartSeriesTypesCommonSeries
    {
    }

    public partial class DxChartSeriesTypesStepLineSeriesAggregation : DxChartSeriesTypesCommonSeriesAggregation
    {
    }

    public partial class DxChartSeriesTypesStepLineSeriesLabel : DxChartSeriesTypesCommonSeriesLabel
    {
    }

    public partial class DxChartSeriesTypesStockSeries : DxChartSeriesTypesCommonSeries
    {
    }

    public partial class DxChartSeriesTypesStockSeriesAggregation : DxChartSeriesTypesCommonSeriesAggregation
    {
    }

    public partial class DxChartSeriesTypesStockSeriesLabel : DxChartSeriesTypesCommonSeriesLabel
    {
    }

    public partial class DxExporterOptions : ComponentOptions
    {
        public object exportFormat { get; set; }
        public string fileName { get; set; }
        public bool? printingEnabled { get; set; }
        public string serverUrl { get; set; }
        public bool? showMenu { get; set; }
        public string sourceContainer { get; set; }
    }

    public static class DxExporterOptionsExportFormat
    {
        public const string PNG = "PNG";
        public const string JPEG = "JPEG";
        public const string GIF = "GIF";
        public const string PDF = "PDF";
        public const string SVG = "SVG";
    }
    public partial class CommonIndicator
    {
        public float? arrowLength { get; set; }
        public string backgroundColor { get; set; }
        public float? baseValue { get; set; }
        public float? beginAdaptingAtRadius { get; set; }
        public string color { get; set; }
        public string horizontalOrientation { get; set; }
        public float? indentFromCenter { get; set; }
        public float? length { get; set; }
        public float? offset { get; set; }
        public object palette { get; set; }
        public string secondColor { get; set; }
        public float? secondFraction { get; set; }
        public float? size { get; set; }
        public float? spindleGapSize { get; set; }
        public float? spindleSize { get; set; }
        public object text { get; set; }
        public string verticalOrientation { get; set; }
        public float? width { get; set; }
    }

    public partial class CommonIndicatorText
    {
        public object customizeText { get; set; }
        public object font { get; set; }
        public object format { get; set; }
        public float? indent { get; set; }
        public float? precision { get; set; }
    }

    public partial class CircularRectangleNeedle : CommonIndicator
    {
    }

    public partial class CircularTriangleNeedle : CommonIndicator
    {
    }

    public partial class CircularTwoColorNeedle : CommonIndicator
    {
    }

    public partial class CircularRangeBar : CommonIndicator
    {
    }

    public partial class CircularTriangleMarker : CommonIndicator
    {
    }

    public partial class CircularTextCloud : CommonIndicator
    {
    }

    public partial class CircularTextCloudText : CommonIndicatorText
    {
    }

    public partial class LinearRectangle : CommonIndicator
    {
    }

    public partial class LinearCircle : CommonIndicator
    {
    }

    public partial class LinearRhombus : CommonIndicator
    {
    }

    public partial class LinearRangeBar : CommonIndicator
    {
    }

    public partial class LinearTriangleMarker : CommonIndicator
    {
    }

    public partial class LinearTextCloud : CommonIndicator
    {
    }

    public partial class LinearTextCloudText : CommonIndicatorText
    {
    }

    public partial class ChartPointAggregationInfoObject
    {
        public object aggregationInterval { get; set; }
        public object data { get; set; }
        public object intervalEnd { get; set; }
        public object intervalStart { get; set; }
    }

    public partial class DxPieChartSeriesTypes
    {
        public object CommonPieChartSeries { get; set; }
        public object DoughnutSeries { get; set; }
        public object PieSeries { get; set; }
    }

    public partial class DxPieChartSeriesTypesCommonPieChartSeries
    {
        public string argumentField { get; set; }
        public string argumentType { get; set; }
        public object border { get; set; }
        public string color { get; set; }
        public string hoverMode { get; set; }
        public object hoverStyle { get; set; }
        public float? innerRadius { get; set; }
        public object label { get; set; }
        public float? maxLabelCount { get; set; }
        public float? minSegmentSize { get; set; }
        public string segmentsDirection { get; set; }
        public string selectionMode { get; set; }
        public object selectionStyle { get; set; }
        public object smallValuesGrouping { get; set; }
        public float? startAngle { get; set; }
        public string tagField { get; set; }
        public string valueField { get; set; }
    }

    public partial class DxPolarChartSeriesTypes
    {
        public object areapolarseries { get; set; }
        public object barpolarseries { get; set; }
        public object CommonPolarChartSeries { get; set; }
        public object linepolarseries { get; set; }
        public object scatterpolarseries { get; set; }
        public object stackedbarpolarseries { get; set; }
    }

    public partial class DxPolarChartSeriesTypesAreapolarseries : DxPolarChartSeriesTypesCommonPolarChartSeries
    {
    }

    public partial class DxPolarChartSeriesTypesAreapolarseriesPoint : DxPolarChartSeriesTypesCommonPolarChartSeriesPoint
    {
    }

    public partial class DxPolarChartSeriesTypesBarpolarseries : DxPolarChartSeriesTypesCommonPolarChartSeries
    {
    }

    public partial class DxPolarChartSeriesTypesCommonPolarChartSeries
    {
        public string argumentField { get; set; }
        public float? barPadding { get; set; }
        public float? barWidth { get; set; }
        public object border { get; set; }
        public bool? closed { get; set; }
        public string color { get; set; }
        public string dashStyle { get; set; }
        public string hoverMode { get; set; }
        public object hoverStyle { get; set; }
        public bool? ignoreEmptyPoints { get; set; }
        public object label { get; set; }
        public float? maxLabelCount { get; set; }
        public float? minBarSize { get; set; }
        public float? opacity { get; set; }
        public object point { get; set; }
        public string selectionMode { get; set; }
        public object selectionStyle { get; set; }
        public bool? showInLegend { get; set; }
        public string stack { get; set; }
        public string tagField { get; set; }
        public object valueErrorBar { get; set; }
        public string valueField { get; set; }
        public bool? visible { get; set; }
        public float? width { get; set; }
    }

    public partial class DxPolarChartSeriesTypesCommonPolarChartSeriesLabel
    {
        public object argumentFormat { get; set; }
        public float? argumentPrecision { get; set; }
        public string backgroundColor { get; set; }
        public object border { get; set; }
        public object connector { get; set; }
        public object customizeText { get; set; }
        public object font { get; set; }
        public object format { get; set; }
        public string position { get; set; }
        public float? precision { get; set; }
        public float? rotationAngle { get; set; }
        public bool? showForZeroValues { get; set; }
        public bool? visible { get; set; }
    }

    public partial class DxPolarChartSeriesTypesCommonPolarChartSeriesPoint
    {
        public object border { get; set; }
        public string color { get; set; }
        public string hoverMode { get; set; }
        public object hoverStyle { get; set; }
        public object image { get; set; }
        public string selectionMode { get; set; }
        public object selectionStyle { get; set; }
        public float? size { get; set; }
        public string symbol { get; set; }
        public bool? visible { get; set; }
    }

    public partial class DxPolarChartSeriesTypesLinepolarseries : DxPolarChartSeriesTypesCommonPolarChartSeries
    {
    }

    public partial class DxPolarChartSeriesTypesStackedbarpolarseries : DxPolarChartSeriesTypesCommonPolarChartSeries
    {
    }

    public partial class DxPolarChartSeriesTypesStackedbarpolarseriesLabel : DxPolarChartSeriesTypesCommonPolarChartSeriesLabel
    {
    }

    public partial class Font
    {
        public string color { get; set; }
        public string family { get; set; }
        public float? opacity { get; set; }
        public object size { get; set; }
        public float? weight { get; set; }
    }

}
namespace DevExpress.Viz.Charts
{
    public partial class DxChartOptions : BaseChartOptions
    {
        public bool? adjustOnZoom { get; set; }
        public object argumentAxis { get; set; }
        public float? barGroupPadding { get; set; }
        public float? barGroupWidth { get; set; }
        public float? barWidth { get; set; }
        public object commonAxisSettings { get; set; }
        public object commonPaneSettings { get; set; }
        public object commonSeriesSettings { get; set; }
        public string containerBackgroundColor { get; set; }
        public object crosshair { get; set; }
        public object dataPrepareSettings { get; set; }
        public string defaultPane { get; set; }
        public bool? equalBarWidth { get; set; }
        public float? maxBubbleSize { get; set; }
        public float? minBubbleSize { get; set; }
        public bool? negativesAsZeroes { get; set; }
        public bool? onArgumentAxisClickEnabled { get; set; }
        public bool? onLegendClickEnabled { get; set; }
        public bool? onSeriesClickEnabled { get; set; }
        public bool? onSeriesHoverChangedEnabled { get; set; }
        public bool? onSeriesSelectionChangedEnabled { get; set; }
        public bool? onZoomEndEnabled { get; set; }
        public bool? onZoomStartEnabled { get; set; }
        public object panes { get; set; }
        public string resolveLabelOverlapping { get; set; }
        public bool? rotated { get; set; }
        public object scrollBar { get; set; }
        public string scrollingMode { get; set; }
        public string seriesSelectionMode { get; set; }
        public object seriesTemplate { get; set; }
        public bool? synchronizeMultiAxes { get; set; }
        public bool? useAggregation { get; set; }
        public object valueAxis { get; set; }
        public string zoomingMode { get; set; }
    }

    public partial class DxChartArgumentAxis : DxChartCommonAxisSettings
    {
        public float? aggregationGroupWidth { get; set; }
        public object aggregationInterval { get; set; }
        public string argumentType { get; set; }
        public float? axisDivisionFactor { get; set; }
        public object breaks { get; set; }
        public object categories { get; set; }
        public object constantLines { get; set; }
        public object holidays { get; set; }
        public string hoverMode { get; set; }
        public float? logarithmBase { get; set; }
        public object max { get; set; }
        public object min { get; set; }
        public float? minorTickCount { get; set; }
        public object minorTickInterval { get; set; }
        public string position { get; set; }
        public object singleWorkdays { get; set; }
        public object strips { get; set; }
        public object tickInterval { get; set; }
        public string type { get; set; }
        public bool? workdaysOnly { get; set; }
        public object workWeek { get; set; }
    }

    public partial class DxChartArgumentAxisConstantLines : DxChartCommonAxisSettingsConstantLineStyle
    {
        public object value { get; set; }
    }

    public partial class DxChartArgumentAxisConstantLinesLabel : DxChartCommonAxisSettingsConstantLineStyleLabel
    {
        public string horizontalAlignment { get; set; }
        public string text { get; set; }
        public string verticalAlignment { get; set; }
    }

    public partial class DxChartArgumentAxisConstantLineStyle : DxChartCommonAxisSettingsConstantLineStyle
    {
    }

    public partial class DxChartArgumentAxisConstantLineStyleLabel : DxChartCommonAxisSettingsConstantLineStyleLabel
    {
        public string horizontalAlignment { get; set; }
        public string verticalAlignment { get; set; }
    }

    public partial class DxChartArgumentAxisLabel : DxChartCommonAxisSettingsLabel
    {
        public object customizeHint { get; set; }
        public object customizeText { get; set; }
        public object format { get; set; }
        public float? precision { get; set; }
    }

    public partial class DxChartArgumentAxisStrips : DxChartCommonAxisSettingsStripStyle
    {
        public string color { get; set; }
        public object endValue { get; set; }
        public object startValue { get; set; }
    }

    public partial class DxChartArgumentAxisStripsLabel : DxChartCommonAxisSettingsStripStyleLabel
    {
        public string text { get; set; }
    }

    public partial class DxChartArgumentAxisTitle : DxChartCommonAxisSettingsTitle
    {
        public string text { get; set; }
    }

    public partial class DxChartCommonAxisSettings
    {
        public bool? allowDecimals { get; set; }
        public object breakStyle { get; set; }
        public string color { get; set; }
        public object constantLineStyle { get; set; }
        public string discreteAxisDivisionMode { get; set; }
        public bool? endOnTick { get; set; }
        public object grid { get; set; }
        public bool? inverted { get; set; }
        public object label { get; set; }
        public float? maxValueMargin { get; set; }
        public object minorGrid { get; set; }
        public object minorTick { get; set; }
        public float? minValueMargin { get; set; }
        public float? opacity { get; set; }
        public float? placeholderSize { get; set; }
        public bool? setTicksAtUnitBeginning { get; set; }
        public object stripStyle { get; set; }
        public object tick { get; set; }
        public object title { get; set; }
        public bool? valueMarginsEnabled { get; set; }
        public bool? visible { get; set; }
        public float? width { get; set; }
    }

    public partial class DxChartCommonAxisSettingsConstantLineStyle
    {
        public string color { get; set; }
        public string dashStyle { get; set; }
        public object label { get; set; }
        public float? paddingLeftRight { get; set; }
        public float? paddingTopBottom { get; set; }
        public float? width { get; set; }
    }

    public partial class DxChartCommonAxisSettingsConstantLineStyleLabel
    {
        public object font { get; set; }
        public string position { get; set; }
        public bool? visible { get; set; }
    }

    public partial class DxChartCommonAxisSettingsLabel
    {
        public string alignment { get; set; }
        public string displayMode { get; set; }
        public object font { get; set; }
        public float? indentFromAxis { get; set; }
        public object overlappingBehavior { get; set; }
        public float? rotationAngle { get; set; }
        public float? staggeringSpacing { get; set; }
        public bool? visible { get; set; }
    }

    public partial class DxChartCommonAxisSettingsStripStyle
    {
        public object label { get; set; }
        public float? paddingLeftRight { get; set; }
        public float? paddingTopBottom { get; set; }
    }

    public partial class DxChartCommonAxisSettingsStripStyleLabel
    {
        public object font { get; set; }
        public string horizontalAlignment { get; set; }
        public string verticalAlignment { get; set; }
    }

    public partial class DxChartCommonAxisSettingsTitle
    {
        public object font { get; set; }
        public float? margin { get; set; }
    }

    public partial class DxChartCommonPaneSettings
    {
        public string backgroundColor { get; set; }
        public object border { get; set; }
    }

    public partial class DxChartCommonSeriesSettings : DxChartSeriesTypesCommonSeries
    {
        public object area { get; set; }
        public object bar { get; set; }
        public object bubble { get; set; }
        public object candlestick { get; set; }
        public object fullstackedarea { get; set; }
        public object fullstackedbar { get; set; }
        public object fullstackedline { get; set; }
        public object fullstackedspline { get; set; }
        public object fullstackedsplinearea { get; set; }
        public object line { get; set; }
        public object rangearea { get; set; }
        public object rangebar { get; set; }
        public object scatter { get; set; }
        public object spline { get; set; }
        public object splinearea { get; set; }
        public object stackedarea { get; set; }
        public object stackedbar { get; set; }
        public object stackedline { get; set; }
        public object stackedspline { get; set; }
        public object stackedsplinearea { get; set; }
        public object steparea { get; set; }
        public object stepline { get; set; }
        public object stock { get; set; }
        public string type { get; set; }
    }

    public partial class DxChartLegend : BaseChartLegend
    {
        public object customizeHint { get; set; }
        public object customizeText { get; set; }
        public string hoverMode { get; set; }
        public string position { get; set; }
    }

    public partial class DxChartPanes : DxChartCommonPaneSettings
    {
        public string name { get; set; }
    }

    public partial class DxChartSeries : DxChartSeriesTypesCommonSeries
    {
        public string name { get; set; }
        public object tag { get; set; }
        public string type { get; set; }
    }

    public partial class DxChartTooltip : BaseChartTooltip
    {
        public string location { get; set; }
        public bool? shared { get; set; }
    }

    public partial class DxChartValueAxis : DxChartCommonAxisSettings
    {
        public bool? autoBreaksEnabled { get; set; }
        public float? axisDivisionFactor { get; set; }
        public object breaks { get; set; }
        public object categories { get; set; }
        public object constantLines { get; set; }
        public float? logarithmBase { get; set; }
        public object max { get; set; }
        public float? maxAutoBreakCount { get; set; }
        public object min { get; set; }
        public float? minorTickCount { get; set; }
        public object minorTickInterval { get; set; }
        public float? multipleAxesSpacing { get; set; }
        public string name { get; set; }
        public string pane { get; set; }
        public string position { get; set; }
        public bool? showZero { get; set; }
        public object strips { get; set; }
        public float? synchronizedValue { get; set; }
        public object tickInterval { get; set; }
        public string type { get; set; }
        public string valueType { get; set; }
    }

    public partial class DxChartValueAxisConstantLines : DxChartCommonAxisSettingsConstantLineStyle
    {
        public object value { get; set; }
    }

    public partial class DxChartValueAxisConstantLinesLabel : DxChartCommonAxisSettingsConstantLineStyleLabel
    {
        public string horizontalAlignment { get; set; }
        public string text { get; set; }
        public string verticalAlignment { get; set; }
    }

    public partial class DxChartValueAxisConstantLineStyle : DxChartCommonAxisSettingsConstantLineStyle
    {
    }

    public partial class DxChartValueAxisConstantLineStyleLabel : DxChartCommonAxisSettingsConstantLineStyleLabel
    {
        public string horizontalAlignment { get; set; }
        public string verticalAlignment { get; set; }
    }

    public partial class DxChartValueAxisLabel : DxChartCommonAxisSettingsLabel
    {
        public object customizeHint { get; set; }
        public object customizeText { get; set; }
        public object format { get; set; }
        public float? precision { get; set; }
    }

    public partial class DxChartValueAxisStrips : DxChartCommonAxisSettingsStripStyle
    {
        public string color { get; set; }
        public object endValue { get; set; }
        public object startValue { get; set; }
    }

    public partial class DxChartValueAxisStripsLabel : DxChartCommonAxisSettingsStripStyleLabel
    {
        public string text { get; set; }
    }

    public partial class DxChartValueAxisTitle : DxChartCommonAxisSettingsTitle
    {
        public string text { get; set; }
    }

    public partial class DxPieChartOptions : BaseChartOptions
    {
        public object commonSeriesSettings { get; set; }
        public float? diameter { get; set; }
        public float? innerRadius { get; set; }
        public float? minDiameter { get; set; }
        public bool? onLegendClickEnabled { get; set; }
        public string resolveLabelOverlapping { get; set; }
        public string segmentsDirection { get; set; }
        public object seriesTemplate { get; set; }
        public string sizeGroup { get; set; }
        public float? startAngle { get; set; }
        public string type { get; set; }
    }

    public partial class DxPieChartAdaptiveLayout : BaseChartAdaptiveLayout
    {
    }

    public partial class DxPieChartCommonSeriesSettings : DxPieChartSeriesTypesCommonPieChartSeries
    {
        public string type { get; set; }
    }

    public partial class DxPieChartLegend : BaseChartLegend
    {
        public object customizeHint { get; set; }
        public object customizeText { get; set; }
        public string hoverMode { get; set; }
    }

    public partial class DxPieChartSeries : DxPieChartSeriesTypesCommonPieChartSeries
    {
        public string name { get; set; }
        public object tag { get; set; }
        public string type { get; set; }
    }

    public partial class DxPolarChartOptions : BaseChartOptions
    {
        public object argumentAxis { get; set; }
        public float? barGroupPadding { get; set; }
        public float? barGroupWidth { get; set; }
        public float? barWidth { get; set; }
        public object commonAxisSettings { get; set; }
        public object commonSeriesSettings { get; set; }
        public string containerBackgroundColor { get; set; }
        public object dataPrepareSettings { get; set; }
        public bool? equalBarWidth { get; set; }
        public bool? negativesAsZeroes { get; set; }
        public bool? onArgumentAxisClickEnabled { get; set; }
        public bool? onLegendClickEnabled { get; set; }
        public bool? onSeriesClickEnabled { get; set; }
        public bool? onSeriesHoverChangedEnabled { get; set; }
        public bool? onSeriesSelectionChangedEnabled { get; set; }
        public string resolveLabelOverlapping { get; set; }
        public string seriesSelectionMode { get; set; }
        public object seriesTemplate { get; set; }
        public bool? useSpiderWeb { get; set; }
        public object valueAxis { get; set; }
    }

    public partial class DxPolarChartAdaptiveLayout : BaseChartAdaptiveLayout
    {
    }

    public partial class DxPolarChartArgumentAxis : DxPolarChartCommonAxisSettings
    {
        public string argumentType { get; set; }
        public float? axisDivisionFactor { get; set; }
        public object categories { get; set; }
        public object constantLines { get; set; }
        public bool? firstPointOnStartAngle { get; set; }
        public string hoverMode { get; set; }
        public float? logarithmBase { get; set; }
        public float? minorTickCount { get; set; }
        public object minorTickInterval { get; set; }
        public float? originValue { get; set; }
        public float? period { get; set; }
        public float? startAngle { get; set; }
        public object strips { get; set; }
        public object tickInterval { get; set; }
        public string type { get; set; }
    }

    public partial class DxPolarChartArgumentAxisConstantLines : DxPolarChartCommonAxisSettingsConstantLineStyle
    {
        public object value { get; set; }
    }

    public partial class DxPolarChartArgumentAxisConstantLinesLabel : DxPolarChartCommonAxisSettingsConstantLineStyleLabel
    {
        public string text { get; set; }
    }

    public partial class DxPolarChartArgumentAxisLabel : DxPolarChartCommonAxisSettingsLabel
    {
        public object customizeHint { get; set; }
        public object customizeText { get; set; }
        public object format { get; set; }
        public float? precision { get; set; }
    }

    public partial class DxPolarChartArgumentAxisStrips : DxPolarChartCommonAxisSettingsStripStyle
    {
        public string color { get; set; }
        public object endValue { get; set; }
        public object startValue { get; set; }
    }

    public partial class DxPolarChartArgumentAxisStripsLabel : DxPolarChartCommonAxisSettingsStripStyleLabel
    {
        public string text { get; set; }
    }

    public partial class DxPolarChartCommonAxisSettings
    {
        public bool? allowDecimals { get; set; }
        public string color { get; set; }
        public object constantLineStyle { get; set; }
        public string discreteAxisDivisionMode { get; set; }
        public bool? endOnTick { get; set; }
        public object grid { get; set; }
        public bool? inverted { get; set; }
        public object label { get; set; }
        public object minorGrid { get; set; }
        public object minorTick { get; set; }
        public float? opacity { get; set; }
        public bool? setTicksAtUnitBeginning { get; set; }
        public object stripStyle { get; set; }
        public object tick { get; set; }
        public bool? visible { get; set; }
        public float? width { get; set; }
    }

    public partial class DxPolarChartCommonAxisSettingsConstantLineStyle
    {
        public string color { get; set; }
        public string dashStyle { get; set; }
        public object label { get; set; }
        public float? width { get; set; }
    }

    public partial class DxPolarChartCommonAxisSettingsConstantLineStyleLabel
    {
        public object font { get; set; }
        public bool? visible { get; set; }
    }

    public partial class DxPolarChartCommonAxisSettingsLabel
    {
        public object font { get; set; }
        public float? indentFromAxis { get; set; }
        public string overlappingBehavior { get; set; }
        public bool? visible { get; set; }
    }

    public partial class DxPolarChartCommonAxisSettingsStripStyle
    {
        public object label { get; set; }
    }

    public partial class DxPolarChartCommonAxisSettingsStripStyleLabel
    {
        public object font { get; set; }
    }

    public partial class DxPolarChartCommonAxisSettingsTick
    {
        public string color { get; set; }
        public float? length { get; set; }
        public float? opacity { get; set; }
        public bool? visible { get; set; }
        public float? width { get; set; }
    }

    public partial class DxPolarChartCommonSeriesSettings : DxPolarChartSeriesTypesCommonPolarChartSeries
    {
        public object area { get; set; }
        public object bar { get; set; }
        public object line { get; set; }
        public object scatter { get; set; }
        public object stackedbar { get; set; }
        public string type { get; set; }
    }

    public partial class DxPolarChartLegend : BaseChartLegend
    {
        public object customizeHint { get; set; }
        public object customizeText { get; set; }
        public string hoverMode { get; set; }
    }

    public partial class DxPolarChartSeries : DxPolarChartSeriesTypesCommonPolarChartSeries
    {
        public string name { get; set; }
        public object tag { get; set; }
        public string type { get; set; }
    }

    public partial class DxPolarChartTooltip : BaseChartTooltip
    {
        public bool? shared { get; set; }
    }

    public partial class DxPolarChartValueAxis : DxPolarChartCommonAxisSettings
    {
        public float? axisDivisionFactor { get; set; }
        public object categories { get; set; }
        public object constantLines { get; set; }
        public float? logarithmBase { get; set; }
        public float? maxValueMargin { get; set; }
        public float? minorTickCount { get; set; }
        public object minorTickInterval { get; set; }
        public float? minValueMargin { get; set; }
        public bool? showZero { get; set; }
        public object strips { get; set; }
        public object tickInterval { get; set; }
        public string type { get; set; }
        public bool? valueMarginsEnabled { get; set; }
        public string valueType { get; set; }
    }

    public partial class DxPolarChartValueAxisConstantLines : DxPolarChartCommonAxisSettingsConstantLineStyle
    {
        public object value { get; set; }
    }

    public partial class DxPolarChartValueAxisConstantLinesLabel : DxPolarChartCommonAxisSettingsConstantLineStyleLabel
    {
        public string text { get; set; }
    }

    public partial class DxPolarChartValueAxisLabel : DxPolarChartCommonAxisSettingsLabel
    {
        public object customizeHint { get; set; }
        public object customizeText { get; set; }
        public object format { get; set; }
        public float? precision { get; set; }
    }

    public partial class DxPolarChartValueAxisStrips : DxPolarChartCommonAxisSettingsStripStyle
    {
        public string color { get; set; }
        public object endValue { get; set; }
        public object startValue { get; set; }
    }

    public partial class DxPolarChartValueAxisStripsLabel : DxPolarChartCommonAxisSettingsStripStyleLabel
    {
        public string text { get; set; }
    }

    public partial class DxPolarChartValueAxisTick : DxPolarChartCommonAxisSettingsTick
    {
    }

    public partial class BaseChartOptions : BaseWidgetOptions
    {
        public object adaptiveLayout { get; set; }
        public object animation { get; set; }
        public object customizeLabel { get; set; }
        public object customizePoint { get; set; }
        public object dataSource { get; set; }
        public object legend { get; set; }
        public bool? onDoneEnabled { get; set; }
        public bool? onPointClickEnabled { get; set; }
        public bool? onPointHoverChangedEnabled { get; set; }
        public bool? onPointSelectionChangedEnabled { get; set; }
        public bool? onTooltipHiddenEnabled { get; set; }
        public bool? onTooltipShownEnabled { get; set; }
        public object palette { get; set; }
        public string paletteExtensionMode { get; set; }
        public string pointSelectionMode { get; set; }
        public object series { get; set; }
    }

    public partial class BaseChartAdaptiveLayout
    {
        public float? height { get; set; }
        public bool? keepLabels { get; set; }
        public float? width { get; set; }
    }

    public partial class BaseChartLegend
    {
        public string backgroundColor { get; set; }
        public object border { get; set; }
        public float? columnCount { get; set; }
        public float? columnItemSpacing { get; set; }
        public object font { get; set; }
        public string horizontalAlignment { get; set; }
        public string itemsAlignment { get; set; }
        public string itemTextPosition { get; set; }
        public object margin { get; set; }
        public float? markerSize { get; set; }
        public string orientation { get; set; }
        public float? paddingLeftRight { get; set; }
        public float? paddingTopBottom { get; set; }
        public float? rowCount { get; set; }
        public float? rowItemSpacing { get; set; }
        public string verticalAlignment { get; set; }
        public bool? visible { get; set; }
    }

    public partial class BaseChartTooltip : BaseWidgetTooltip
    {
        public object argumentFormat { get; set; }
        public float? argumentPrecision { get; set; }
        public object customizeTooltip { get; set; }
        public float? percentPrecision { get; set; }
    }

}
namespace DevExpress.Viz.Funnel
{
    public partial class DxFunnelOptions : BaseWidgetOptions
    {
        public object adaptiveLayout { get; set; }
        public string algorithm { get; set; }
        public string argumentField { get; set; }
        public string colorField { get; set; }
        public object dataSource { get; set; }
        public bool? hoverEnabled { get; set; }
        public bool? inverted { get; set; }
        public object item { get; set; }
        public object label { get; set; }
        public object legend { get; set; }
        public float? neckHeight { get; set; }
        public float? neckWidth { get; set; }
        public bool? onHoverChangedEnabled { get; set; }
        public bool? onItemClickEnabled { get; set; }
        public bool? onLegendClickEnabled { get; set; }
        public bool? onSelectionChangedEnabled { get; set; }
        public object palette { get; set; }
        public string paletteExtensionMode { get; set; }
        public string selectionMode { get; set; }
        public bool? sortData { get; set; }
        public string valueField { get; set; }
    }

    public partial class DxFunnelTooltip : BaseWidgetTooltip
    {
        public object customizeTooltip { get; set; }
    }

}
namespace DevExpress.Viz.Gauges
{
    public partial class BaseGaugeOptions : BaseWidgetOptions
    {
        public object animation { get; set; }
        public string containerBackgroundColor { get; set; }
        public bool? onTooltipHiddenEnabled { get; set; }
        public bool? onTooltipShownEnabled { get; set; }
        public object rangeContainer { get; set; }
        public object scale { get; set; }
        public object subtitle { get; set; }
        public object subvalues { get; set; }
        public float? value { get; set; }
    }

    public partial class BaseGaugeAnimation
    {
        public float? duration { get; set; }
        public string easing { get; set; }
        public bool? enabled { get; set; }
    }

    public partial class BaseGaugeRangeContainer
    {
        public string backgroundColor { get; set; }
        public float? offset { get; set; }
        public object palette { get; set; }
        public string paletteExtensionMode { get; set; }
        public object ranges { get; set; }
    }

    public partial class BaseGaugeScale
    {
        public bool? allowDecimals { get; set; }
        public object customMinorTicks { get; set; }
        public object customTicks { get; set; }
        public float? endValue { get; set; }
        public bool? hideFirstLabel { get; set; }
        public bool? hideFirstTick { get; set; }
        public bool? hideLastLabel { get; set; }
        public bool? hideLastTick { get; set; }
        public object label { get; set; }
        public object majorTick { get; set; }
        public object minorTick { get; set; }
        public float? minorTickInterval { get; set; }
        public float? startValue { get; set; }
        public object tick { get; set; }
        public float? tickInterval { get; set; }
    }

    public partial class BaseGaugeScaleLabel
    {
        public object customizeText { get; set; }
        public object font { get; set; }
        public object format { get; set; }
        public object overlappingBehavior { get; set; }
        public float? precision { get; set; }
        public bool? useRangeColors { get; set; }
        public bool? visible { get; set; }
    }

    public partial class BaseGaugeScaleLabelOverlappingBehavior
    {
        public bool? useAutoArrangement { get; set; }
    }

    public partial class BaseGaugeSubtitle
    {
        public object font { get; set; }
        public string text { get; set; }
    }

    public partial class BaseGaugeTitle : BaseWidgetTitle
    {
        public string position { get; set; }
    }

    public partial class BaseGaugeTooltip : BaseWidgetTooltip
    {
        public object customizeTooltip { get; set; }
    }

    public partial class DxCircularGaugeOptions : BaseGaugeOptions
    {
        public object geometry { get; set; }
        public object subvalueIndicator { get; set; }
        public object valueIndicator { get; set; }
    }

    public partial class DxCircularGaugeRangeContainer : BaseGaugeRangeContainer
    {
        public string orientation { get; set; }
        public float? width { get; set; }
    }

    public partial class DxCircularGaugeScale : BaseGaugeScale
    {
        public string orientation { get; set; }
    }

    public partial class DxCircularGaugeScaleLabel : BaseGaugeScaleLabel
    {
        public string hideFirstOrLast { get; set; }
        public float? indentFromTick { get; set; }
    }

    public partial class DxCircularGaugeScaleLabelOverlappingBehavior : BaseGaugeScaleLabelOverlappingBehavior
    {
        public string hideFirstOrLast { get; set; }
    }

    public partial class DxCircularGaugeSubvalueIndicator : CommonIndicator
    {
        public string type { get; set; }
    }

    public partial class DxCircularGaugeValueIndicator : CommonIndicator
    {
        public string type { get; set; }
    }

    public partial class DxLinearGaugeOptions : BaseGaugeOptions
    {
        public object geometry { get; set; }
        public object subvalueIndicator { get; set; }
        public object valueIndicator { get; set; }
    }

    public partial class DxLinearGaugeRangeContainer : BaseGaugeRangeContainer
    {
        public string horizontalOrientation { get; set; }
        public string verticalOrientation { get; set; }
        public object width { get; set; }
    }

    public partial class DxLinearGaugeScale : BaseGaugeScale
    {
        public string horizontalOrientation { get; set; }
        public string verticalOrientation { get; set; }
    }

    public partial class DxLinearGaugeScaleLabel : BaseGaugeScaleLabel
    {
        public float? indentFromTick { get; set; }
    }

    public partial class DxLinearGaugeScaleLabelOverlappingBehavior : BaseGaugeScaleLabelOverlappingBehavior
    {
        public string hideFirstOrLast { get; set; }
    }

    public partial class DxLinearGaugeSubvalueIndicator : CommonIndicator
    {
        public string type { get; set; }
    }

    public partial class DxLinearGaugeValueIndicator : CommonIndicator
    {
        public string type { get; set; }
    }

    public partial class DxBarGaugeOptions : BaseWidgetOptions
    {
        public object animation { get; set; }
        public string backgroundColor { get; set; }
        public float? barSpacing { get; set; }
        public float? baseValue { get; set; }
        public float? endValue { get; set; }
        public object geometry { get; set; }
        public object label { get; set; }
        public bool? onTooltipHiddenEnabled { get; set; }
        public bool? onTooltipShownEnabled { get; set; }
        public object palette { get; set; }
        public string paletteExtensionMode { get; set; }
        public float? relativeInnerRadius { get; set; }
        public float? startValue { get; set; }
        public object subtitle { get; set; }
        public object values { get; set; }
    }

    public partial class DxBarGaugeTitle : BaseWidgetTitle
    {
        public string position { get; set; }
    }

    public partial class DxBarGaugeTooltip : BaseWidgetTooltip
    {
        public object customizeTooltip { get; set; }
    }

}
namespace DevExpress.Viz.RangeSelector
{
    public partial class DxRangeSelectorOptions : BaseWidgetOptions
    {
        public object background { get; set; }
        public object behavior { get; set; }
        public object chart { get; set; }
        public string containerBackgroundColor { get; set; }
        public object dataSource { get; set; }
        public string dataSourceField { get; set; }
        public object indent { get; set; }
        public bool? onSelectedRangeChangedEnabled { get; set; }
        public bool? onValueChangedEnabled { get; set; }
        public object scale { get; set; }
        public object selectedRange { get; set; }
        public string selectedRangeColor { get; set; }
        public object shutter { get; set; }
        public object sliderHandle { get; set; }
        public object sliderMarker { get; set; }
        public object value { get; set; }
    }

}
namespace DevExpress.Viz.Sparklines
{
    public partial class BaseSparklineOptions : BaseWidgetOptions
    {
        public bool? onTooltipHiddenEnabled { get; set; }
        public bool? onTooltipShownEnabled { get; set; }
    }

    public partial class BaseSparklineTooltip : BaseWidgetTooltip
    {
        public object customizeTooltip { get; set; }
        public string horizontalAlignment { get; set; }
        public string verticalAlignment { get; set; }
    }

    public partial class DxSparklineOptions : BaseSparklineOptions
    {
        public string argumentField { get; set; }
        public string barNegativeColor { get; set; }
        public string barPositiveColor { get; set; }
        public object dataSource { get; set; }
        public string firstLastColor { get; set; }
        public bool? ignoreEmptyPoints { get; set; }
        public string lineColor { get; set; }
        public float? lineWidth { get; set; }
        public string lossColor { get; set; }
        public string maxColor { get; set; }
        public float? maxValue { get; set; }
        public string minColor { get; set; }
        public float? minValue { get; set; }
        public string pointColor { get; set; }
        public float? pointSize { get; set; }
        public string pointSymbol { get; set; }
        public bool? showFirstLast { get; set; }
        public bool? showMinMax { get; set; }
        public string type { get; set; }
        public string valueField { get; set; }
        public string winColor { get; set; }
        public float? winlossThreshold { get; set; }
    }

    public partial class DxBulletOptions : BaseSparklineOptions
    {
        public string color { get; set; }
        public float? endScaleValue { get; set; }
        public bool? showTarget { get; set; }
        public bool? showZeroLevel { get; set; }
        public float? startScaleValue { get; set; }
        public float? target { get; set; }
        public string targetColor { get; set; }
        public float? targetWidth { get; set; }
        public float? value { get; set; }
    }

}
namespace DevExpress.Viz.Map
{
    public partial class DxVectorMapOptions : BaseWidgetOptions
    {
        public object areaSettings { get; set; }
        public object background { get; set; }
        public object bounds { get; set; }
        public object center { get; set; }
        public object controlBar { get; set; }
        public object layers { get; set; }
        public object legends { get; set; }
        public object mapData { get; set; }
        public object markers { get; set; }
        public object markerSettings { get; set; }
        public float? maxZoomFactor { get; set; }
        public bool? onAreaClickEnabled { get; set; }
        public bool? onAreaSelectionChangedEnabled { get; set; }
        public bool? onCenterChangedEnabled { get; set; }
        public bool? onClickEnabled { get; set; }
        public bool? onMarkerClickEnabled { get; set; }
        public bool? onMarkerSelectionChangedEnabled { get; set; }
        public bool? onSelectionChangedEnabled { get; set; }
        public bool? onTooltipHiddenEnabled { get; set; }
        public bool? onTooltipShownEnabled { get; set; }
        public bool? onZoomFactorChangedEnabled { get; set; }
        public bool? panningEnabled { get; set; }
        public object projection { get; set; }
        public bool? touchEnabled { get; set; }
        public bool? wheelEnabled { get; set; }
        public float? zoomFactor { get; set; }
        public bool? zoomingEnabled { get; set; }
    }

    public partial class DxVectorMapAreaSettings
    {
        public string borderColor { get; set; }
        public float? borderWidth { get; set; }
        public string color { get; set; }
        public string colorGroupingField { get; set; }
        public object colorGroups { get; set; }
        public object customize { get; set; }
        public string hoveredBorderColor { get; set; }
        public float? hoveredBorderWidth { get; set; }
        public string hoveredColor { get; set; }
        public bool? hoverEnabled { get; set; }
        public object label { get; set; }
        public object palette { get; set; }
        public float? paletteSize { get; set; }
        public string selectedBorderColor { get; set; }
        public float? selectedBorderWidth { get; set; }
        public string selectedColor { get; set; }
        public string selectionMode { get; set; }
    }

    public partial class DxVectorMapMarkerSettings
    {
        public string borderColor { get; set; }
        public float? borderWidth { get; set; }
        public string color { get; set; }
        public string colorGroupingField { get; set; }
        public object colorGroups { get; set; }
        public object customize { get; set; }
        public string hoveredBorderColor { get; set; }
        public float? hoveredBorderWidth { get; set; }
        public string hoveredColor { get; set; }
        public bool? hoverEnabled { get; set; }
        public object label { get; set; }
        public float? maxSize { get; set; }
        public float? minSize { get; set; }
        public float? opacity { get; set; }
        public object palette { get; set; }
        public string selectedBorderColor { get; set; }
        public float? selectedBorderWidth { get; set; }
        public string selectedColor { get; set; }
        public string selectionMode { get; set; }
        public float? size { get; set; }
        public string sizeGroupingField { get; set; }
        public object sizeGroups { get; set; }
        public string type { get; set; }
    }

    public partial class DxVectorMapTooltip : BaseWidgetTooltip
    {
        public object customizeTooltip { get; set; }
    }

}
namespace DevExpress.Viz.TreeMap
{
    public partial class DxTreeMapOptions : BaseWidgetOptions
    {
        public string childrenField { get; set; }
        public string colorField { get; set; }
        public object colorizer { get; set; }
        public object dataSource { get; set; }
        public object group { get; set; }
        public bool? hoverEnabled { get; set; }
        public string idField { get; set; }
        public bool? interactWithGroup { get; set; }
        public string labelField { get; set; }
        public object layoutAlgorithm { get; set; }
        public string layoutDirection { get; set; }
        public float? maxDepth { get; set; }
        public bool? onClickEnabled { get; set; }
        public bool? onDrillEnabled { get; set; }
        public bool? onHoverChangedEnabled { get; set; }
        public bool? onNodesInitializedEnabled { get; set; }
        public bool? onNodesRenderingEnabled { get; set; }
        public bool? onSelectionChangedEnabled { get; set; }
        public string parentField { get; set; }
        public string resolveLabelOverflow { get; set; }
        public string selectionMode { get; set; }
        public object tile { get; set; }
        public string valueField { get; set; }
    }

    public partial class DxTreeMapTooltip : BaseWidgetTooltip
    {
        public object customizeTooltip { get; set; }
    }

}
