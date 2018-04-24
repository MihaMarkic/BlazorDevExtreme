namespace DevExpress
{
    public partial class AnimationConfig
    {
        // couldn't parse complete
        public float? delay { get; set; }
        public string direction { get; set; }
        public float? duration { get; set; }
        public string easing { get; set; }
        // couldn't parse from
        public float? staggerDelay { get; set; }
        // couldn't parse start
        // couldn't parse to
        public string type { get; set; }
    }

    public static class AnimationConfigDirection
    {
        public const string Bottom = "bottom";
        public const string Left = "left";
        public const string Right = "right";
        public const string Top = "top";
    }
    public static class AnimationConfigType
    {
        public const string Css = "css";
        public const string Fade = "fade";
        public const string FadeIn = "fadeIn";
        public const string FadeOut = "fadeOut";
        public const string Pop = "pop";
        public const string Slide = "slide";
        public const string SlideIn = "slideIn";
        public const string SlideOut = "slideOut";
    }
    public partial class PositionConfig
    {
        // couldn't parse at
        // couldn't parse boundary
        // couldn't parse boundaryOffset
        // couldn't parse collision
        // couldn't parse my
        // couldn't parse of
        // couldn't parse offset
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
        public float version { get; set; }
        public bool? win { get; set; }
    }

    public static class DeviceDeviceType
    {
        public const string Phone = "phone";
        public const string Tablet = "tablet";
        public const string Desktop = "desktop";
    }
    public static class DeviceGrade
    {
        public const string A = "A";
        public const string B = "B";
        public const string C = "C";
    }
    public static class DevicePlatform
    {
        public const string Android = "android";
        public const string Ios = "ios";
        public const string Win = "win";
        public const string Generic = "generic";
    }
    public partial class DOMComponentOptions : ComponentOptions
    {
        public object bindingOptions { get; set; }
        public object elementAttr { get; set; }
        // couldn't parse height
        public bool? onDisposingEnabled { get; set; }
        public bool? onOptionChangedEnabled { get; set; }
        public bool? rtlEnabled { get; set; }
        // couldn't parse width
    }
}
namespace DevExpress.Data
{
    public partial class StoreOptions
    {
        // couldn't parse errorHandler
        // couldn't parse key
        public bool? onInsertedEnabled { get; set; }
        public bool? onInsertingEnabled { get; set; }
        public bool? onLoadedEnabled { get; set; }
        public bool? onLoadingEnabled { get; set; }
        // couldn't parse onModified
        // couldn't parse onModifying
        public bool? onRemovedEnabled { get; set; }
        public bool? onRemovingEnabled { get; set; }
        public bool? onUpdatedEnabled { get; set; }
        public bool? onUpdatingEnabled { get; set; }
    }
    public partial class ArrayStoreOptions : StoreOptions
    {
        // couldn't parse data
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
        // couldn't parse searchExpr
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
        // couldn't parse byKey
        public bool? cacheRawData { get; set; }
        // couldn't parse insert
        // couldn't parse load
        public string loadMode { get; set; }
        // couldn't parse remove
        // couldn't parse totalCount
        // couldn't parse update
        public bool? useDefaultSearch { get; set; }
    }

    public static class CustomStoreOptionsLoadMode
    {
        public const string Processed = "processed";
        public const string Raw = "raw";
    }
    public partial class DataSourceOptions
    {
        public object customQueryParams { get; set; }
        // couldn't parse expand
        // couldn't parse filter
        // couldn't parse group
        // couldn't parse map
        // couldn't parse onChanged
        public bool? onLoadErrorEnabled { get; set; }
        public bool? onLoadingChangedEnabled { get; set; }
        public float? pageSize { get; set; }
        public bool? paginate { get; set; }
        // couldn't parse postProcess
        public bool? requireTotalCount { get; set; }
        // couldn't parse searchExpr
        public string searchOperation { get; set; }
        public object searchValue { get; set; }
        // couldn't parse select
        // couldn't parse sort
        // couldn't parse store
    }
    public partial class LocalStoreOptions : ArrayStoreOptions
    {
        public float? flushInterval { get; set; }
        public bool? immediate { get; set; }
        public string name { get; set; }
    }
    public partial class ODataContextOptions
    {
        // couldn't parse beforeSend
        public bool? deserializeDates { get; set; }
        public object entities { get; set; }
        // couldn't parse errorHandler
        public bool? jsonp { get; set; }
        public string url { get; set; }
        public float? version { get; set; }
        public bool? withCredentials { get; set; }
    }
    public partial class ODataStoreOptions : StoreOptions
    {
        // couldn't parse beforeSend
        public bool? deserializeDates { get; set; }
        public object fieldTypes { get; set; }
        public bool? jsonp { get; set; }
        // couldn't parse keyType
        public object onLoading { get; set; }
        public string url { get; set; }
        public float? version { get; set; }
        public bool? withCredentials { get; set; }
    }
    public partial class PivotGridDataSourceOptions
    {
        // couldn't parse fields
        // couldn't parse filter
        // couldn't parse onChanged
        public bool? onFieldsPreparedEnabled { get; set; }
        public bool? onLoadErrorEnabled { get; set; }
        public bool? onLoadingChangedEnabled { get; set; }
        public bool? remoteOperations { get; set; }
        public bool? retrieveFields { get; set; }
        // couldn't parse store
    }
    public partial class XmlaStoreOptions
    {
        // couldn't parse beforeSend
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
        // couldn't parse area
        public float? areaIndex { get; set; }
        // couldn't parse calculateCustomSummary
        // couldn't parse calculateSummaryValue
        public string caption { get; set; }
        // couldn't parse customizeText
        public string dataField { get; set; }
        public string dataType { get; set; }
        public string displayFolder { get; set; }
        public bool? expanded { get; set; }
        public string filterType { get; set; }
        // couldn't parse filterValues
        // couldn't parse format
        public float? groupIndex { get; set; }
        // couldn't parse groupInterval
        public string groupName { get; set; }
        // couldn't parse headerFilter
        public bool? isMeasure { get; set; }
        public float? precision { get; set; }
        public string runningTotal { get; set; }
        // couldn't parse selector
        public bool? showGrandTotals { get; set; }
        public bool? showTotals { get; set; }
        public bool? showValues { get; set; }
        public string sortBy { get; set; }
        public string sortBySummaryField { get; set; }
        // couldn't parse sortBySummaryPath
        // couldn't parse sortingMethod
        public string sortOrder { get; set; }
        public string summaryDisplayMode { get; set; }
        public string summaryType { get; set; }
        public bool? visible { get; set; }
        public float? width { get; set; }
        public bool? wordWrapEnabled { get; set; }
    }

    public static class PivotGridDataSourceFieldDataType
    {
        public const string Date = "date";
        public const string Number = "number";
        public const string String = "string";
    }
    public static class PivotGridDataSourceFieldFilterType
    {
        public const string Exclude = "exclude";
        public const string Include = "include";
    }
    public static class PivotGridDataSourceFieldRunningTotal
    {
        public const string Column = "column";
        public const string Row = "row";
    }
    public static class PivotGridDataSourceFieldSortBy
    {
        public const string DisplayText = "displayText";
        public const string Value = "value";
        public const string None = "none";
    }
    public static class PivotGridDataSourceFieldSortOrder
    {
        public const string Asc = "asc";
        public const string Desc = "desc";
    }
    public static class PivotGridDataSourceFieldSummaryDisplayMode
    {
        public const string AbsoluteVariation = "absoluteVariation";
        public const string PercentOfColumnGrandTotal = "percentOfColumnGrandTotal";
        public const string PercentOfColumnTotal = "percentOfColumnTotal";
        public const string PercentOfGrandTotal = "percentOfGrandTotal";
        public const string PercentOfRowGrandTotal = "percentOfRowGrandTotal";
        public const string PercentOfRowTotal = "percentOfRowTotal";
        public const string PercentVariation = "percentVariation";
    }
    public static class PivotGridDataSourceFieldSummaryType
    {
        public const string Avg = "avg";
        public const string Count = "count";
        public const string Custom = "custom";
        public const string Max = "max";
        public const string Min = "min";
        public const string Sum = "sum";
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
        // couldn't parse onExecute
        public string renderStage { get; set; }
        public string title { get; set; }
        public string type { get; set; }
        public bool? visible { get; set; }
    }

    public static class DxCommandOptionsRenderStage
    {
        public const string OnViewShown = "onViewShown";
        public const string OnViewRendering = "onViewRendering";
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

    public static class DxViewOptionsOrientation
    {
        public const string Portrait = "portrait";
        public const string Landscape = "landscape";
    }
    public static class DxViewOptionsPane
    {
        public const string Master = "master";
        public const string Detail = "detail";
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

    public static class DxTransitionOptionsType
    {
        public const string Slide = "slide";
        public const string Fade = "fade";
        public const string Overflow = "overflow";
    }
    public partial class DxContentPlaceholderOptions
    {
        public string animation { get; set; }
        public string contentCssPosition { get; set; }
        public string name { get; set; }
        public string transition { get; set; }
    }

    public static class DxContentPlaceholderOptionsContentCssPosition
    {
        public const string Absolute = "absolute";
        public const string Static = "static";
    }
    public static class DxContentPlaceholderOptionsTransition
    {
        public const string None = "none";
        public const string Slide = "slide";
        public const string Fade = "fade";
        public const string Overflow = "overflow";
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
        // couldn't parse layoutSet
        public string mode { get; set; }
        public object @namespace { get; set; }
        public string navigateToRootViewMode { get; set; }
        // couldn't parse navigation
        public object router { get; set; }
        public object stateManager { get; set; }
        public object stateStorage { get; set; }
        public string templatesVersion { get; set; }
        public bool? useViewTitleAsBackText { get; set; }
        public object viewCache { get; set; }
        public float? viewCacheSize { get; set; }
        public object viewPort { get; set; }
    }

    public static class HtmlApplicationOptionsMode
    {
        public const string MobileApp = "mobileApp";
        public const string WebSite = "webSite";
    }
    public static class HtmlApplicationOptionsNavigateToRootViewMode
    {
        public const string KeepHistory = "keepHistory";
        public const string ResetHistory = "resetHistory";
    }
}
namespace DevExpress.Ui
{
    public partial class DxAccordionOptions : CollectionWidgetOptions
    {
        public float? animationDuration { get; set; }
        public bool? collapsible { get; set; }
        public bool? deferRendering { get; set; }
        public bool? focusStateEnabled { get; set; }
        // couldn't parse height
        public bool? hoverStateEnabled { get; set; }
        // couldn't parse itemTemplate
        // couldn't parse itemTitleTemplate
        public bool? multiple { get; set; }
        public bool? onItemTitleClickEnabled { get; set; }
        public float? selectedIndex { get; set; }
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
        // couldn't parse target
        public string title { get; set; }
        public bool? usePopover { get; set; }
        public bool? visible { get; set; }
    }
    public partial class DxActionSheetItemTemplate : CollectionWidgetItemTemplate
    {
        public string icon { get; set; }
        public bool? onClickEnabled { get; set; }
        public string type { get; set; }
    }

    public static class DxActionSheetItemTemplateType
    {
        public const string Back = "back";
        public const string Danger = "danger";
        public const string Default = "default";
        public const string Normal = "normal";
        public const string Success = "success";
    }
    public partial class DxAutocompleteOptions : DxDropDownListOptions
    {
        public float? maxItemCount { get; set; }
        public float? minSearchLength { get; set; }
        public string value { get; set; }
    }
    public partial class DxBoxOptions : CollectionWidgetOptions
    {
        public string align { get; set; }
        public string crossAlign { get; set; }
        public string direction { get; set; }
    }

    public static class DxBoxOptionsAlign
    {
        public const string Center = "center";
        public const string End = "end";
        public const string SpaceAround = "space-around";
        public const string SpaceBetween = "space-between";
        public const string Start = "start";
    }
    public static class DxBoxOptionsCrossAlign
    {
        public const string Center = "center";
        public const string End = "end";
        public const string Start = "start";
        public const string Stretch = "stretch";
    }
    public static class DxBoxOptionsDirection
    {
        public const string Col = "col";
        public const string Row = "row";
    }
    public partial class DxBoxItemTemplate : CollectionWidgetItemTemplate
    {
        // couldn't parse baseSize
        // couldn't parse box
        public float? ratio { get; set; }
        public float? shrink { get; set; }
    }
    public partial class DxButtonOptions : WidgetOptions
    {
        public bool? activeStateEnabled { get; set; }
        public bool? focusStateEnabled { get; set; }
        public bool? hoverStateEnabled { get; set; }
        public string icon { get; set; }
        public bool? onClickEnabled { get; set; }
        // couldn't parse template
        public string text { get; set; }
        public string type { get; set; }
        public bool? useSubmitBehavior { get; set; }
        public string validationGroup { get; set; }
    }

    public static class DxButtonOptionsType
    {
        public const string Back = "back";
        public const string Danger = "danger";
        public const string Default = "default";
        public const string Normal = "normal";
        public const string Success = "success";
    }
    public partial class DxButtonDefaultTemplate
    {
        public string icon { get; set; }
        public string text { get; set; }
    }
    public partial class DxCalendarOptions : EditorOptions
    {
        public bool? activeStateEnabled { get; set; }
        // couldn't parse cellTemplate
        public string dateSerializationFormat { get; set; }
        // couldn't parse disabledDates
        // couldn't parse firstDayOfWeek
        public bool? focusStateEnabled { get; set; }
        public bool? hoverStateEnabled { get; set; }
        // couldn't parse max
        public string maxZoomLevel { get; set; }
        // couldn't parse min
        public string minZoomLevel { get; set; }
        public string name { get; set; }
        public bool? showTodayButton { get; set; }
        // couldn't parse value
        public string zoomLevel { get; set; }
    }

    public static class DxCalendarOptionsMaxZoomLevel
    {
        public const string Century = "century";
        public const string Decade = "decade";
        public const string Month = "month";
        public const string Year = "year";
    }
    public static class DxCalendarOptionsMinZoomLevel
    {
        public const string Century = "century";
        public const string Decade = "decade";
        public const string Month = "month";
        public const string Year = "year";
    }
    public static class DxCalendarOptionsZoomLevel
    {
        public const string Century = "century";
        public const string Decade = "decade";
        public const string Month = "month";
        public const string Year = "year";
    }
    public partial class DxCheckBoxOptions : EditorOptions
    {
        public bool? activeStateEnabled { get; set; }
        public bool? focusStateEnabled { get; set; }
        public bool? hoverStateEnabled { get; set; }
        public string name { get; set; }
        public string text { get; set; }
        public bool? value { get; set; }
    }
    public partial class DxColorBoxOptions : DxDropDownEditorOptions
    {
        public string applyButtonText { get; set; }
        public string applyValueMode { get; set; }
        public string cancelButtonText { get; set; }
        public bool? editAlphaChannel { get; set; }
        // couldn't parse fieldTemplate
        public float? keyStep { get; set; }
        public string value { get; set; }
    }

    public static class DxColorBoxOptionsApplyValueMode
    {
        public const string Instantly = "instantly";
        public const string UseButtons = "useButtons";
    }
    public partial class DxContextMenuOptions : DxMenuBaseOptions
    {
        // couldn't parse closeOnOutsideClick
        // couldn't parse items
        public bool? onHiddenEnabled { get; set; }
        public bool? onHidingEnabled { get; set; }
        public bool? onPositioningEnabled { get; set; }
        public bool? onShowingEnabled { get; set; }
        public bool? onShownEnabled { get; set; }
        // couldn't parse position
        // couldn't parse showEvent
        public string submenuDirection { get; set; }
        // couldn't parse target
        public bool? visible { get; set; }
    }

    public static class DxContextMenuOptionsSubmenuDirection
    {
        public const string Auto = "auto";
        public const string Left = "left";
        public const string Right = "right";
    }
    public partial class GridBaseOptions : WidgetOptions
    {
        public bool? allowColumnReordering { get; set; }
        public bool? allowColumnResizing { get; set; }
        public bool? cacheEnabled { get; set; }
        public bool? cellHintEnabled { get; set; }
        public bool? columnAutoWidth { get; set; }
        // couldn't parse columnChooser
        // couldn't parse columnFixing
        public bool? columnHidingEnabled { get; set; }
        public float? columnMinWidth { get; set; }
        public string columnResizingMode { get; set; }
        // couldn't parse columns
        public float? columnWidth { get; set; }
        // couldn't parse dataSource
        public string dateSerializationFormat { get; set; }
        // couldn't parse editing
        public bool? errorRowEnabled { get; set; }
        // couldn't parse filterBuilder
        // couldn't parse filterBuilderPopup
        // couldn't parse filterPanel
        // couldn't parse filterRow
        // couldn't parse filterSyncEnabled
        // couldn't parse filterValue
        // couldn't parse headerFilter
        // couldn't parse loadPanel
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
        // couldn't parse pager
        // couldn't parse paging
        public bool? rowAlternationEnabled { get; set; }
        // couldn't parse scrolling
        // couldn't parse searchPanel
        // couldn't parse selectedRowKeys
        // couldn't parse selection
        public bool? showBorders { get; set; }
        public bool? showColumnHeaders { get; set; }
        public bool? showColumnLines { get; set; }
        public bool? showRowLines { get; set; }
        // couldn't parse sorting
        // couldn't parse stateStoring
        public bool? twoWayBindingEnabled { get; set; }
        public bool? wordWrapEnabled { get; set; }
    }

    public static class GridBaseOptionsColumnResizingMode
    {
        public const string NextColumn = "nextColumn";
        public const string Widget = "widget";
    }
    public partial class GridBaseEditing
    {
        public bool? allowAdding { get; set; }
        public bool? allowDeleting { get; set; }
        public bool? allowUpdating { get; set; }
        // couldn't parse form
        public string mode { get; set; }
        // couldn't parse popup
        // couldn't parse texts
        public bool? useIcons { get; set; }
    }

    public static class GridBaseEditingMode
    {
        public const string Batch = "batch";
        public const string Cell = "cell";
        public const string Row = "row";
        public const string Form = "form";
        public const string Popup = "popup";
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
        // couldn't parse useNative
    }

    public static class GridBaseScrollingColumnRenderingMode
    {
        public const string Standard = "standard";
        public const string Virtual = "virtual";
    }
    public static class GridBaseScrollingRowRenderingMode
    {
        public const string Standard = "standard";
        public const string Virtual = "virtual";
    }
    public static class GridBaseScrollingShowScrollbar
    {
        public const string Always = "always";
        public const string Never = "never";
        public const string OnHover = "onHover";
        public const string OnScroll = "onScroll";
    }
    public partial class GridBaseSelection
    {
        public bool? allowSelectAll { get; set; }
        public string mode { get; set; }
    }

    public static class GridBaseSelectionMode
    {
        public const string Multiple = "multiple";
        public const string None = "none";
        public const string Single = "single";
    }
    public partial class DxDataGridOptions : GridBaseOptions
    {
        // couldn't parse columns
        // couldn't parse customizeColumns
        // couldn't parse customizeExportData
        // couldn't parse editing
        // couldn't parse export
        // couldn't parse grouping
        // couldn't parse groupPanel
        // couldn't parse keyExpr
        // couldn't parse masterDetail
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
        // couldn't parse remoteOperations
        // couldn't parse rowTemplate
        // couldn't parse scrolling
        // couldn't parse selection
        // couldn't parse selectionFilter
        // couldn't parse sortByGroupSummaryInfo
        // couldn't parse summary
    }
    public partial class DxDataGridEditing : GridBaseEditing
    {
        public object texts { get; set; }
    }
    public partial class DxDataGridScrolling : GridBaseScrolling
    {
        public string mode { get; set; }
    }

    public static class DxDataGridScrollingMode
    {
        public const string Infinite = "infinite";
        public const string Standard = "standard";
        public const string Virtual = "virtual";
    }
    public partial class DxDataGridSelection : GridBaseSelection
    {
        public bool? deferred { get; set; }
        public string selectAllMode { get; set; }
        public string showCheckBoxesMode { get; set; }
    }

    public static class DxDataGridSelectionSelectAllMode
    {
        public const string AllPages = "allPages";
        public const string Page = "page";
    }
    public static class DxDataGridSelectionShowCheckBoxesMode
    {
        public const string Always = "always";
        public const string None = "none";
        public const string OnClick = "onClick";
        public const string OnLongTap = "onLongTap";
    }
    public partial class DxDateBoxOptions : DxDropDownEditorOptions
    {
        public bool? adaptivityEnabled { get; set; }
        public string applyButtonText { get; set; }
        // couldn't parse calendarOptions
        public string cancelButtonText { get; set; }
        public string dateOutOfRangeMessage { get; set; }
        public string dateSerializationFormat { get; set; }
        // couldn't parse disabledDates
        // couldn't parse displayFormat
        public float? interval { get; set; }
        public string invalidDateMessage { get; set; }
        // couldn't parse max
        public string maxZoomLevel { get; set; }
        // couldn't parse min
        public string minZoomLevel { get; set; }
        public string pickerType { get; set; }
        public string placeholder { get; set; }
        public bool? showAnalogClock { get; set; }
        public string type { get; set; }
        // couldn't parse value
    }

    public static class DxDateBoxOptionsMaxZoomLevel
    {
        public const string Century = "century";
        public const string Decade = "decade";
        public const string Month = "month";
        public const string Year = "year";
    }
    public static class DxDateBoxOptionsMinZoomLevel
    {
        public const string Century = "century";
        public const string Decade = "decade";
        public const string Month = "month";
        public const string Year = "year";
    }
    public static class DxDateBoxOptionsPickerType
    {
        public const string Calendar = "calendar";
        public const string List = "list";
        public const string Native = "native";
        public const string Rollers = "rollers";
    }
    public static class DxDateBoxOptionsType
    {
        public const string Date = "date";
        public const string Datetime = "datetime";
        public const string Time = "time";
    }
    public partial class DxDeferRenderingOptions : WidgetOptions
    {
        // couldn't parse animation
        public bool? onRenderedEnabled { get; set; }
        public bool? onShownEnabled { get; set; }
        // couldn't parse renderWhen
        public bool? showLoadIndicator { get; set; }
        public string staggerItemSelector { get; set; }
    }
    public partial class DxDropDownBoxOptions : DxDropDownEditorOptions
    {
        public bool? acceptCustomValue { get; set; }
        // couldn't parse contentTemplate
        // couldn't parse dropDownOptions
        // couldn't parse fieldTemplate
        public string valueChangeEvent { get; set; }
    }
    public partial class DxDropDownMenuOptions : WidgetOptions
    {
        public bool? activeStateEnabled { get; set; }
        public string buttonIcon { get; set; }
        public string buttonText { get; set; }
        // couldn't parse dataSource
        public bool? hoverStateEnabled { get; set; }
        // couldn't parse items
        // couldn't parse itemTemplate
        public bool? onButtonClickEnabled { get; set; }
        public bool? onItemClickEnabled { get; set; }
        public bool? opened { get; set; }
        // couldn't parse popupHeight
        // couldn't parse popupWidth
        public bool? usePopover { get; set; }
    }
    public partial class DxFileUploaderOptions : EditorOptions
    {
        public string accept { get; set; }
        public bool? allowCanceling { get; set; }
        public bool? focusStateEnabled { get; set; }
        public string labelText { get; set; }
        public bool? multiple { get; set; }
        public string name { get; set; }
        public bool? onProgressEnabled { get; set; }
        public bool? onUploadAbortedEnabled { get; set; }
        public bool? onUploadedEnabled { get; set; }
        public bool? onUploadErrorEnabled { get; set; }
        public bool? onUploadStartedEnabled { get; set; }
        public bool? onValueChangedEnabled { get; set; }
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
        // couldn't parse value
    }

    public static class DxFileUploaderOptionsUploadMethod
    {
        public const string POST = "POST";
        public const string PUT = "PUT";
    }
    public static class DxFileUploaderOptionsUploadMode
    {
        public const string Instantly = "instantly";
        public const string UseButtons = "useButtons";
        public const string UseForm = "useForm";
    }
    public partial class DxFilterBuilderOptions : WidgetOptions
    {
        public bool? allowHierarchicalFields { get; set; }
        // couldn't parse customOperations
        // couldn't parse fields
        // couldn't parse filterOperationDescriptions
        // couldn't parse groupOperationDescriptions
        public bool? onEditorPreparedEnabled { get; set; }
        public bool? onEditorPreparingEnabled { get; set; }
        public bool? onValueChangedEnabled { get; set; }
        // couldn't parse value
    }
    public partial class DxFormOptions : WidgetOptions
    {
        public bool? alignItemLabels { get; set; }
        public bool? alignItemLabelsInAllGroups { get; set; }
        // couldn't parse colCount
        public object colCountByScreen { get; set; }
        // couldn't parse customizeItem
        public object formData { get; set; }
        // couldn't parse items
        public string labelLocation { get; set; }
        public float? minColWidth { get; set; }
        public bool? onEditorEnterKeyEnabled { get; set; }
        public bool? onFieldDataChangedEnabled { get; set; }
        public string optionalMark { get; set; }
        public bool? readOnly { get; set; }
        public string requiredMark { get; set; }
        public string requiredMessage { get; set; }
        // couldn't parse screenByWidth
        public bool? scrollingEnabled { get; set; }
        public bool? showColonAfterLabel { get; set; }
        public bool? showOptionalMark { get; set; }
        public bool? showRequiredMark { get; set; }
        public bool? showValidationSummary { get; set; }
        public string validationGroup { get; set; }
    }

    public static class DxFormOptionsLabelLocation
    {
        public const string Left = "left";
        public const string Right = "right";
        public const string Top = "top";
    }
    public partial class DxGalleryOptions : CollectionWidgetOptions
    {
        public float? animationDuration { get; set; }
        public bool? animationEnabled { get; set; }
        public bool? focusStateEnabled { get; set; }
        public bool? indicatorEnabled { get; set; }
        public float? initialItemWidth { get; set; }
        public bool? loop { get; set; }
        public float? selectedIndex { get; set; }
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
        public bool? activeStateEnabled { get; set; }
        public bool? allowItemDeleting { get; set; }
        public bool? allowItemReordering { get; set; }
        public bool? bounceEnabled { get; set; }
        public bool? collapsibleGroups { get; set; }
        public bool? focusStateEnabled { get; set; }
        public bool? grouped { get; set; }
        // couldn't parse groupTemplate
        public bool? hoverStateEnabled { get; set; }
        public bool? indicateLoading { get; set; }
        public string itemDeleteMode { get; set; }
        // couldn't parse menuItems
        public string menuMode { get; set; }
        public string nextButtonText { get; set; }
        public bool? onGroupRenderedEnabled { get; set; }
        public bool? onItemClickEnabled { get; set; }
        public bool? onItemContextMenuEnabled { get; set; }
        public bool? onItemDeletedEnabled { get; set; }
        public bool? onItemDeletingEnabled { get; set; }
        public bool? onItemHoldEnabled { get; set; }
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
    }

    public static class DxListOptionsItemDeleteMode
    {
        public const string Context = "context";
        public const string SlideButton = "slideButton";
        public const string SlideItem = "slideItem";
        public const string Static = "static";
        public const string Swipe = "swipe";
        public const string Toggle = "toggle";
    }
    public static class DxListOptionsMenuMode
    {
        public const string Context = "context";
        public const string Slide = "slide";
    }
    public static class DxListOptionsPageLoadMode
    {
        public const string NextButton = "nextButton";
        public const string ScrollBottom = "scrollBottom";
    }
    public static class DxListOptionsSelectAllMode
    {
        public const string AllPages = "allPages";
        public const string Page = "page";
    }
    public static class DxListOptionsSelectionMode
    {
        public const string All = "all";
        public const string Multiple = "multiple";
        public const string None = "none";
        public const string Single = "single";
    }
    public static class DxListOptionsShowScrollbar
    {
        public const string Always = "always";
        public const string Never = "never";
        public const string OnHover = "onHover";
        public const string OnScroll = "onScroll";
    }
    public partial class DxLoadIndicatorOptions : WidgetOptions
    {
        public string indicatorSrc { get; set; }
    }
    public partial class DxLoadPanelOptions : DxOverlayOptions
    {
        // couldn't parse animation
        public float? delay { get; set; }
        public bool? focusStateEnabled { get; set; }
        public float? height { get; set; }
        public string indicatorSrc { get; set; }
        public string message { get; set; }
        // couldn't parse position
        public object shadingColor { get; set; }
        public bool? showIndicator { get; set; }
        public bool? showPane { get; set; }
        public float? width { get; set; }
    }
    public partial class DxLoadPanelAnimation : DxOverlayAnimation
    {
        // couldn't parse hide
        // couldn't parse show
    }
    public partial class DxLookupOptions : DxDropDownListOptions
    {
        // couldn't parse animation
        public string applyButtonText { get; set; }
        public string applyValueMode { get; set; }
        public string cancelButtonText { get; set; }
        public bool? cleanSearchOnOpening { get; set; }
        public string clearButtonText { get; set; }
        // couldn't parse closeOnOutsideClick
        // couldn't parse fieldTemplate
        public bool? focusStateEnabled { get; set; }
        public bool? fullScreen { get; set; }
        public bool? grouped { get; set; }
        // couldn't parse groupTemplate
        public string nextButtonText { get; set; }
        public bool? onPageLoadingEnabled { get; set; }
        public bool? onPullRefreshEnabled { get; set; }
        public bool? onScrollEnabled { get; set; }
        public bool? onTitleRenderedEnabled { get; set; }
        public bool? onValueChangedEnabled { get; set; }
        public string pageLoadingText { get; set; }
        public string pageLoadMode { get; set; }
        public string placeholder { get; set; }
        // couldn't parse popupHeight
        // couldn't parse popupWidth
        // couldn't parse position
        public string pulledDownText { get; set; }
        public string pullingDownText { get; set; }
        public bool? pullRefreshEnabled { get; set; }
        public string refreshingText { get; set; }
        public bool? searchEnabled { get; set; }
        public string searchPlaceholder { get; set; }
        public bool? shading { get; set; }
        public bool? showCancelButton { get; set; }
        public bool? showClearButton { get; set; }
        public bool? showPopupTitle { get; set; }
        public string title { get; set; }
        // couldn't parse titleTemplate
        public bool? useNativeScrolling { get; set; }
        public bool? usePopover { get; set; }
    }

    public static class DxLookupOptionsApplyValueMode
    {
        public const string Instantly = "instantly";
        public const string UseButtons = "useButtons";
    }
    public static class DxLookupOptionsPageLoadMode
    {
        public const string NextButton = "nextButton";
        public const string ScrollBottom = "scrollBottom";
    }
    public partial class DxMapOptions : WidgetOptions
    {
        public bool? autoAdjust { get; set; }
        // couldn't parse center
        public bool? controls { get; set; }
        public bool? focusStateEnabled { get; set; }
        public object height { get; set; }
        // couldn't parse key
        public string markerIconSrc { get; set; }
        // couldn't parse markers
        public bool? onClickEnabled { get; set; }
        public bool? onMarkerAddedEnabled { get; set; }
        public bool? onMarkerRemovedEnabled { get; set; }
        public bool? onReadyEnabled { get; set; }
        public bool? onRouteAddedEnabled { get; set; }
        public bool? onRouteRemovedEnabled { get; set; }
        public string provider { get; set; }
        // couldn't parse routes
        public string type { get; set; }
        public object width { get; set; }
        public float? zoom { get; set; }
    }

    public static class DxMapOptionsProvider
    {
        public const string Bing = "bing";
        public const string Google = "google";
        public const string GoogleStatic = "googleStatic";
    }
    public static class DxMapOptionsType
    {
        public const string Hybrid = "hybrid";
        public const string Roadmap = "roadmap";
        public const string Satellite = "satellite";
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
        // couldn't parse items
        public bool? onSubmenuHiddenEnabled { get; set; }
        public bool? onSubmenuHidingEnabled { get; set; }
        public bool? onSubmenuShowingEnabled { get; set; }
        public bool? onSubmenuShownEnabled { get; set; }
        public string orientation { get; set; }
        // couldn't parse showFirstSubmenuMode
        public string submenuDirection { get; set; }
    }

    public static class DxMenuOptionsOrientation
    {
        public const string Horizontal = "horizontal";
        public const string Vertical = "vertical";
    }
    public static class DxMenuOptionsSubmenuDirection
    {
        public const string Auto = "auto";
        public const string LeftOrTop = "leftOrTop";
        public const string RightOrBottom = "rightOrBottom";
    }
    public partial class DxMultiViewOptions : CollectionWidgetOptions
    {
        public bool? animationEnabled { get; set; }
        public bool? deferRendering { get; set; }
        public bool? focusStateEnabled { get; set; }
        public bool? loop { get; set; }
        public float? selectedIndex { get; set; }
        public bool? swipeEnabled { get; set; }
    }
    public partial class DxMultiViewItemTemplate : CollectionWidgetItemTemplate
    {
    }
    public partial class DxNavBarOptions : DxTabsOptions
    {
        public object scrollByContent { get; set; }
    }
    public partial class DxNavBarItemTemplate : DxTabsItemTemplate
    {
        public string badge { get; set; }
    }
    public partial class DxNumberBoxOptions : DxTextEditorOptions
    {
        // couldn't parse format
        public string invalidValueMessage { get; set; }
        public float? max { get; set; }
        public float? min { get; set; }
        public string mode { get; set; }
        public bool? showSpinButtons { get; set; }
        public float? step { get; set; }
        public bool? useLargeSpinButtons { get; set; }
        public float? value { get; set; }
    }

    public static class DxNumberBoxOptionsMode
    {
        public const string Number = "number";
        public const string Text = "text";
        public const string Tel = "tel";
    }
    public partial class DxOverlayOptions : WidgetOptions
    {
        // couldn't parse animation
        public bool? closeOnBackButton { get; set; }
        // couldn't parse closeOnOutsideClick
        // couldn't parse contentTemplate
        public bool? deferRendering { get; set; }
        public bool? dragEnabled { get; set; }
        // couldn't parse height
        // couldn't parse maxHeight
        // couldn't parse maxWidth
        // couldn't parse minHeight
        // couldn't parse minWidth
        public bool? onHiddenEnabled { get; set; }
        public bool? onHidingEnabled { get; set; }
        public bool? onShowingEnabled { get; set; }
        public bool? onShownEnabled { get; set; }
        public object position { get; set; }
        public bool? shading { get; set; }
        public string shadingColor { get; set; }
        public bool? visible { get; set; }
        // couldn't parse width
    }
    public partial class DxOverlayAnimation
    {
        // couldn't parse hide
        // couldn't parse show
    }
    public partial class DxPanoramaOptions : CollectionWidgetOptions
    {
        // couldn't parse backgroundImage
        public bool? focusStateEnabled { get; set; }
        public float? selectedIndex { get; set; }
        public string title { get; set; }
    }
    public partial class DxPanoramaItemTemplate : CollectionWidgetItemTemplate
    {
        public string title { get; set; }
    }
    public partial class DxPivotOptions : CollectionWidgetOptions
    {
        // couldn't parse contentTemplate
        // couldn't parse itemTitleTemplate
        public float? selectedIndex { get; set; }
        public bool? swipeEnabled { get; set; }
    }
    public partial class DxPivotItemTemplate : CollectionWidgetItemTemplate
    {
        public string title { get; set; }
        // couldn't parse titleTemplate
    }
    public partial class DxPivotGridOptions : WidgetOptions
    {
        public bool? allowExpandAll { get; set; }
        public bool? allowFiltering { get; set; }
        public bool? allowSorting { get; set; }
        public bool? allowSortingBySummary { get; set; }
        public string dataFieldArea { get; set; }
        // couldn't parse dataSource
        // couldn't parse export
        // couldn't parse fieldChooser
        // couldn't parse fieldPanel
        // couldn't parse headerFilter
        public bool? hideEmptySummaryCells { get; set; }
        // couldn't parse loadPanel
        public bool? onCellClickEnabled { get; set; }
        public bool? onCellPreparedEnabled { get; set; }
        public bool? onContextMenuPreparingEnabled { get; set; }
        public bool? onExportedEnabled { get; set; }
        public bool? onExportingEnabled { get; set; }
        public bool? onFileSavingEnabled { get; set; }
        public string rowHeaderLayout { get; set; }
        // couldn't parse scrolling
        public bool? showBorders { get; set; }
        public bool? showColumnGrandTotals { get; set; }
        public bool? showColumnTotals { get; set; }
        public bool? showRowGrandTotals { get; set; }
        public bool? showRowTotals { get; set; }
        public string showTotalsPrior { get; set; }
        // couldn't parse stateStoring
        // couldn't parse texts
        public bool? wordWrapEnabled { get; set; }
    }

    public static class DxPivotGridOptionsDataFieldArea
    {
        public const string Column = "column";
        public const string Row = "row";
    }
    public static class DxPivotGridOptionsRowHeaderLayout
    {
        public const string Standard = "standard";
        public const string Tree = "tree";
    }
    public static class DxPivotGridOptionsShowTotalsPrior
    {
        public const string Both = "both";
        public const string Columns = "columns";
        public const string None = "none";
        public const string Rows = "rows";
    }
    public partial class DxPivotGridFieldChooserOptions : WidgetOptions
    {
        public bool? allowSearch { get; set; }
        public string applyChangesMode { get; set; }
        // couldn't parse dataSource
        // couldn't parse headerFilter
        // couldn't parse height
        // couldn't parse layout
        public bool? onContextMenuPreparingEnabled { get; set; }
        public object state { get; set; }
        // couldn't parse texts
    }

    public static class DxPivotGridFieldChooserOptionsApplyChangesMode
    {
        public const string Instantly = "instantly";
        public const string OnDemand = "onDemand";
    }
    public partial class DxPopoverOptions : DxPopupOptions
    {
        // couldn't parse animation
        public object closeOnOutsideClick { get; set; }
        // couldn't parse height
        // couldn't parse hideEvent
        // couldn't parse position
        public bool? shading { get; set; }
        // couldn't parse showEvent
        public bool? showTitle { get; set; }
        // couldn't parse target
        // couldn't parse width
    }
    public partial class DxPopoverAnimation : DxPopupAnimation
    {
        // couldn't parse hide
        // couldn't parse show
    }
    public partial class DxPopupOptions : DxOverlayOptions
    {
        public object animation { get; set; }
        // couldn't parse container
        public bool? dragEnabled { get; set; }
        public bool? focusStateEnabled { get; set; }
        public bool? fullScreen { get; set; }
        public object height { get; set; }
        public bool? onResizeEnabled { get; set; }
        public bool? onResizeEndEnabled { get; set; }
        public bool? onResizeStartEnabled { get; set; }
        public bool? onTitleRenderedEnabled { get; set; }
        // couldn't parse position
        public bool? resizeEnabled { get; set; }
        public bool? showCloseButton { get; set; }
        public bool? showTitle { get; set; }
        public string title { get; set; }
        // couldn't parse titleTemplate
        // couldn't parse toolbarItems
        public object width { get; set; }
    }
    public partial class DxPopupAnimation : DxOverlayAnimation
    {
        public object hide { get; set; }
        public object show { get; set; }
    }
    public partial class DxPopupToolbarItem
    {
        public bool? disabled { get; set; }
        public string html { get; set; }
        public string location { get; set; }
        public object options { get; set; }
        // couldn't parse template
        public string text { get; set; }
        public string toolbar { get; set; }
        public bool? visible { get; set; }
        public string widget { get; set; }
    }

    public static class DxPopupToolbarItemLocation
    {
        public const string After = "after";
        public const string Before = "before";
        public const string Center = "center";
    }
    public static class DxPopupToolbarItemToolbar
    {
        public const string Bottom = "bottom";
        public const string Top = "top";
    }
    public static class DxPopupToolbarItemWidget
    {
        public const string DxAutocomplete = "dxAutocomplete";
        public const string DxButton = "dxButton";
        public const string DxCheckBox = "dxCheckBox";
        public const string DxDateBox = "dxDateBox";
        public const string DxMenu = "dxMenu";
        public const string DxSelectBox = "dxSelectBox";
        public const string DxTabs = "dxTabs";
        public const string DxTextBox = "dxTextBox";
    }
    public partial class DxProgressBarOptions : DxTrackBarOptions
    {
        public bool? onCompleteEnabled { get; set; }
        public bool? showStatus { get; set; }
        // couldn't parse statusFormat
        public float? value { get; set; }
    }
    public partial class DxRadioGroupOptions : EditorOptions
    {
        public bool? activeStateEnabled { get; set; }
        public bool? focusStateEnabled { get; set; }
        public bool? hoverStateEnabled { get; set; }
        public string layout { get; set; }
        public string name { get; set; }
        public object value { get; set; }
    }

    public static class DxRadioGroupOptionsLayout
    {
        public const string Horizontal = "horizontal";
        public const string Vertical = "vertical";
    }
    public partial class DxRangeSliderOptions : DxSliderBaseOptions
    {
        public float? end { get; set; }
        public string endName { get; set; }
        public bool? onValueChangedEnabled { get; set; }
        public float? start { get; set; }
        public string startName { get; set; }
        public float value { get; set; }
    }
    public partial class DxResizableOptions : DOMComponentOptions
    {
        public string handles { get; set; }
        public object height { get; set; }
        public float? maxHeight { get; set; }
        public float? maxWidth { get; set; }
        public float? minHeight { get; set; }
        public float? minWidth { get; set; }
        public bool? onResizeEnabled { get; set; }
        public bool? onResizeEndEnabled { get; set; }
        public bool? onResizeStartEnabled { get; set; }
        public object width { get; set; }
    }

    public static class DxResizableOptionsHandles
    {
        public const string Top = "top";
        public const string Bottom = "bottom";
        public const string Right = "right";
        public const string Left = "left";
        public const string All = "all";
    }
    public partial class DxResponsiveBoxOptions : CollectionWidgetOptions
    {
        // couldn't parse cols
        public object height { get; set; }
        // couldn't parse rows
        // couldn't parse screenByWidth
        public string singleColumnScreen { get; set; }
        public object width { get; set; }
    }
    public partial class DxResponsiveBoxItemTemplate : CollectionWidgetItemTemplate
    {
        // couldn't parse location
    }
    public partial class DxSchedulerOptions : WidgetOptions
    {
        public string allDayExpr { get; set; }
        // couldn't parse appointmentTemplate
        // couldn't parse appointmentTooltipTemplate
        public float? cellDuration { get; set; }
        public bool? crossScrollingEnabled { get; set; }
        // couldn't parse currentDate
        public string currentView { get; set; }
        // couldn't parse dataCellTemplate
        // couldn't parse dataSource
        // couldn't parse dateCellTemplate
        public string dateSerializationFormat { get; set; }
        public string descriptionExpr { get; set; }
        // couldn't parse dropDownAppointmentTemplate
        // couldn't parse editing
        public string endDateExpr { get; set; }
        public string endDateTimeZoneExpr { get; set; }
        public float? endDayHour { get; set; }
        // couldn't parse firstDayOfWeek
        public bool? focusStateEnabled { get; set; }
        public string groups { get; set; }
        public float? indicatorUpdateInterval { get; set; }
        // couldn't parse max
        // couldn't parse maxAppointmentsPerCell
        // couldn't parse min
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
        // couldn't parse resourceCellTemplate
        // couldn't parse resources
        // couldn't parse selectedCellData
        public bool? shadeUntilCurrentTime { get; set; }
        public bool? showAllDayPanel { get; set; }
        public bool? showCurrentTimeIndicator { get; set; }
        public string startDateExpr { get; set; }
        public string startDateTimeZoneExpr { get; set; }
        public float? startDayHour { get; set; }
        public string textExpr { get; set; }
        // couldn't parse timeCellTemplate
        public string timeZone { get; set; }
        public bool? useDropDownViewSwitcher { get; set; }
        // couldn't parse views
    }

    public static class DxSchedulerOptionsCurrentView
    {
        public const string Agenda = "agenda";
        public const string Day = "day";
        public const string Month = "month";
        public const string TimelineDay = "timelineDay";
        public const string TimelineMonth = "timelineMonth";
        public const string TimelineWeek = "timelineWeek";
        public const string TimelineWorkWeek = "timelineWorkWeek";
        public const string Week = "week";
        public const string WorkWeek = "workWeek";
    }
    public static class DxSchedulerOptionsRecurrenceEditMode
    {
        public const string Dialog = "dialog";
        public const string Occurrence = "occurrence";
        public const string Series = "series";
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
        public bool? acceptCustomValue { get; set; }
        // couldn't parse fieldTemplate
        public bool? onCustomItemCreatingEnabled { get; set; }
        public string placeholder { get; set; }
        public bool? showSelectionControls { get; set; }
        public string valueChangeEvent { get; set; }
    }
    public partial class DxSliderOptions : DxSliderBaseOptions
    {
        public float? value { get; set; }
    }
    public partial class DxSlideOutOptions : CollectionWidgetOptions
    {
        public bool? activeStateEnabled { get; set; }
        // couldn't parse contentTemplate
        public bool? menuGrouped { get; set; }
        // couldn't parse menuGroupTemplate
        // couldn't parse menuItemTemplate
        public string menuPosition { get; set; }
        public bool? menuVisible { get; set; }
        public bool? onMenuGroupRenderedEnabled { get; set; }
        public bool? onMenuItemRenderedEnabled { get; set; }
        public float? selectedIndex { get; set; }
        public bool? swipeEnabled { get; set; }
    }

    public static class DxSlideOutOptionsMenuPosition
    {
        public const string Inverted = "inverted";
        public const string Normal = "normal";
    }
    public partial class DxSlideOutItemTemplate : CollectionWidgetItemTemplate
    {
        // couldn't parse menuTemplate
    }
    public partial class DxSlideOutViewOptions : WidgetOptions
    {
        // couldn't parse contentTemplate
        public string menuPosition { get; set; }
        // couldn't parse menuTemplate
        public bool? menuVisible { get; set; }
        public bool? swipeEnabled { get; set; }
    }

    public static class DxSlideOutViewOptionsMenuPosition
    {
        public const string Inverted = "inverted";
        public const string Normal = "normal";
    }
    public partial class DxSwitchOptions : EditorOptions
    {
        public bool? activeStateEnabled { get; set; }
        public bool? focusStateEnabled { get; set; }
        public bool? hoverStateEnabled { get; set; }
        public string name { get; set; }
        public string offText { get; set; }
        public string onText { get; set; }
        public bool? value { get; set; }
    }
    public partial class DxTabsOptions : CollectionWidgetOptions
    {
        public bool? focusStateEnabled { get; set; }
        public bool? hoverStateEnabled { get; set; }
        public bool? scrollByContent { get; set; }
        public bool? scrollingEnabled { get; set; }
        // couldn't parse selectedItems
        public string selectionMode { get; set; }
        public bool? showNavButtons { get; set; }
    }

    public static class DxTabsOptionsSelectionMode
    {
        public const string Multiple = "multiple";
        public const string Single = "single";
    }
    public partial class DxTabsItemTemplate : CollectionWidgetItemTemplate
    {
        public string badge { get; set; }
        public string icon { get; set; }
    }
    public partial class DxTabPanelOptions : DxMultiViewOptions
    {
        public bool? animationEnabled { get; set; }
        public bool? focusStateEnabled { get; set; }
        public bool? hoverStateEnabled { get; set; }
        // couldn't parse itemTitleTemplate
        public bool? onTitleClickEnabled { get; set; }
        public bool? onTitleHoldEnabled { get; set; }
        public bool? onTitleRenderedEnabled { get; set; }
        public bool? scrollByContent { get; set; }
        public bool? scrollingEnabled { get; set; }
        public bool? showNavButtons { get; set; }
        public bool? swipeEnabled { get; set; }
    }
    public partial class DxTabPanelItemTemplate : DxMultiViewItemTemplate
    {
        public string badge { get; set; }
        public string icon { get; set; }
        // couldn't parse tabTemplate
        public string title { get; set; }
    }
    public partial class DxTagBoxOptions : DxSelectBoxOptions
    {
        public string applyValueMode { get; set; }
        public bool? hideSelectedItems { get; set; }
        public float? maxDisplayedTags { get; set; }
        public bool? multiline { get; set; }
        public bool? onMultiTagPreparingEnabled { get; set; }
        public bool? onSelectAllValueChangedEnabled { get; set; }
        public bool? onSelectionChangedEnabled { get; set; }
        public string selectAllMode { get; set; }
        // couldn't parse selectedItems
        public bool? showMultiTagOnly { get; set; }
        // couldn't parse tagTemplate
        // couldn't parse value
    }

    public static class DxTagBoxOptionsApplyValueMode
    {
        public const string Instantly = "instantly";
        public const string UseButtons = "useButtons";
    }
    public static class DxTagBoxOptionsSelectAllMode
    {
        public const string AllPages = "allPages";
        public const string Page = "page";
    }
    public partial class DxTextAreaOptions : DxTextBoxOptions
    {
        public bool? autoResizeEnabled { get; set; }
        // couldn't parse maxHeight
        // couldn't parse minHeight
        public bool? spellcheck { get; set; }
    }
    public partial class DxTextBoxOptions : DxTextEditorOptions
    {
        // couldn't parse maxLength
        public string mode { get; set; }
        public string value { get; set; }
    }

    public static class DxTextBoxOptionsMode
    {
        public const string Email = "email";
        public const string Password = "password";
        public const string Search = "search";
        public const string Tel = "tel";
        public const string Text = "text";
        public const string Url = "url";
    }
    public partial class DxTileViewOptions : CollectionWidgetOptions
    {
        public bool? activeStateEnabled { get; set; }
        public float? baseItemHeight { get; set; }
        public float? baseItemWidth { get; set; }
        public string direction { get; set; }
        public bool? focusStateEnabled { get; set; }
        // couldn't parse height
        public bool? hoverStateEnabled { get; set; }
        public float? itemMargin { get; set; }
        public bool? showScrollbar { get; set; }
    }

    public static class DxTileViewOptionsDirection
    {
        public const string Horizontal = "horizontal";
        public const string Vertical = "vertical";
    }
    public partial class DxTileViewItemTemplate : CollectionWidgetItemTemplate
    {
        public float? heightRatio { get; set; }
        public float? widthRatio { get; set; }
    }
    public partial class DxToastOptions : DxOverlayOptions
    {
        // couldn't parse animation
        public bool? closeOnBackButton { get; set; }
        public bool? closeOnClick { get; set; }
        public object closeOnOutsideClick { get; set; }
        public bool? closeOnSwipe { get; set; }
        public float? displayTime { get; set; }
        public object height { get; set; }
        public object maxWidth { get; set; }
        public string message { get; set; }
        public object minWidth { get; set; }
        // couldn't parse position
        public bool? shading { get; set; }
        public string type { get; set; }
        public object width { get; set; }
    }

    public static class DxToastOptionsType
    {
        public const string Custom = "custom";
        public const string Error = "error";
        public const string Info = "info";
        public const string Success = "success";
        public const string Warning = "warning";
    }
    public partial class DxToastAnimation : DxOverlayAnimation
    {
        // couldn't parse hide
        // couldn't parse show
    }
    public partial class DxToolbarOptions : CollectionWidgetOptions
    {
        // couldn't parse menuItemTemplate
        public string renderAs { get; set; }
    }

    public static class DxToolbarOptionsRenderAs
    {
        public const string BottomToolbar = "bottomToolbar";
        public const string TopToolbar = "topToolbar";
    }
    public partial class DxToolbarItemTemplate : CollectionWidgetItemTemplate
    {
        public string locateInMenu { get; set; }
        public string location { get; set; }
        // couldn't parse menuItemTemplate
        public object options { get; set; }
        public string showText { get; set; }
        public string widget { get; set; }
    }

    public static class DxToolbarItemTemplateLocateInMenu
    {
        public const string Always = "always";
        public const string Auto = "auto";
        public const string Never = "never";
    }
    public static class DxToolbarItemTemplateLocation
    {
        public const string After = "after";
        public const string Before = "before";
        public const string Center = "center";
    }
    public static class DxToolbarItemTemplateShowText
    {
        public const string Always = "always";
        public const string InMenu = "inMenu";
    }
    public static class DxToolbarItemTemplateWidget
    {
        public const string DxAutocomplete = "dxAutocomplete";
        public const string DxButton = "dxButton";
        public const string DxCheckBox = "dxCheckBox";
        public const string DxDateBox = "dxDateBox";
        public const string DxMenu = "dxMenu";
        public const string DxSelectBox = "dxSelectBox";
        public const string DxTabs = "dxTabs";
        public const string DxTextBox = "dxTextBox";
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
        // couldn't parse columns
        // couldn't parse customizeColumns
        public string dataStructure { get; set; }
        // couldn't parse editing
        // couldn't parse expandedRowKeys
        public bool? expandNodesOnFiltering { get; set; }
        // couldn't parse hasItemsExpr
        // couldn't parse itemsExpr
        // couldn't parse keyExpr
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
        // couldn't parse paging
        // couldn't parse parentIdExpr
        // couldn't parse remoteOperations
        public object rootValue { get; set; }
        // couldn't parse scrolling
        // couldn't parse selection
    }

    public static class DxTreeListOptionsDataStructure
    {
        public const string Plain = "plain";
        public const string Tree = "tree";
    }
    public partial class DxTreeListEditing : GridBaseEditing
    {
        // couldn't parse texts
    }
    public partial class DxTreeListEditingTexts : GridBaseEditingTexts
    {
        public string addRowToNode { get; set; }
    }
    public partial class DxTreeListPaging : GridBasePaging
    {
        public bool? enabled { get; set; }
    }
    public partial class DxTreeListScrolling : GridBaseScrolling
    {
        public string mode { get; set; }
    }

    public static class DxTreeListScrollingMode
    {
        public const string Standard = "standard";
        public const string Virtual = "virtual";
    }
    public partial class DxTreeListSelection : GridBaseSelection
    {
        public bool? recursive { get; set; }
    }
    public partial class DxTreeViewOptions : HierarchicalCollectionWidgetOptions
    {
        public bool? animationEnabled { get; set; }
        // couldn't parse createChildren
        public string dataStructure { get; set; }
        public bool? expandAllEnabled { get; set; }
        // couldn't parse expandedExpr
        public bool? expandNodesRecursive { get; set; }
        // couldn't parse hasItemsExpr
        // couldn't parse items
        public bool? onItemClickEnabled { get; set; }
        public bool? onItemCollapsedEnabled { get; set; }
        public bool? onItemContextMenuEnabled { get; set; }
        public bool? onItemExpandedEnabled { get; set; }
        public bool? onItemHoldEnabled { get; set; }
        public bool? onItemRenderedEnabled { get; set; }
        public bool? onItemSelectionChangedEnabled { get; set; }
        public bool? onSelectionChangedEnabled { get; set; }
        // couldn't parse parentIdExpr
        public object rootValue { get; set; }
        public string scrollDirection { get; set; }
        public string selectAllText { get; set; }
        public bool? selectByClick { get; set; }
        public string selectionMode { get; set; }
        public bool? selectNodesRecursive { get; set; }
        public string showCheckBoxesMode { get; set; }
        public bool? virtualModeEnabled { get; set; }
    }

    public static class DxTreeViewOptionsDataStructure
    {
        public const string Plain = "plain";
        public const string Tree = "tree";
    }
    public static class DxTreeViewOptionsScrollDirection
    {
        public const string Both = "both";
        public const string Horizontal = "horizontal";
        public const string Vertical = "vertical";
    }
    public static class DxTreeViewOptionsSelectionMode
    {
        public const string Multiple = "multiple";
        public const string Single = "single";
    }
    public static class DxTreeViewOptionsShowCheckBoxesMode
    {
        public const string None = "none";
        public const string Normal = "normal";
        public const string SelectAll = "selectAll";
    }
    public partial class RequiredRule
    {
        public string message { get; set; }
        public bool? trim { get; set; }
        public string type { get; set; }
    }

    public static class RequiredRuleType
    {
        public const string Required = "required";
        public const string Numeric = "numeric";
        public const string Range = "range";
        public const string StringLength = "stringLength";
        public const string Custom = "custom";
        public const string Compare = "compare";
        public const string Pattern = "pattern";
        public const string Email = "email";
    }
    public partial class NumericRule
    {
        public string message { get; set; }
        public string type { get; set; }
    }

    public static class NumericRuleType
    {
        public const string Required = "required";
        public const string Numeric = "numeric";
        public const string Range = "range";
        public const string StringLength = "stringLength";
        public const string Custom = "custom";
        public const string Compare = "compare";
        public const string Pattern = "pattern";
        public const string Email = "email";
    }
    public partial class RangeRule
    {
        // couldn't parse max
        public string message { get; set; }
        // couldn't parse min
        public bool? reevaluate { get; set; }
        public string type { get; set; }
    }

    public static class RangeRuleType
    {
        public const string Required = "required";
        public const string Numeric = "numeric";
        public const string Range = "range";
        public const string StringLength = "stringLength";
        public const string Custom = "custom";
        public const string Compare = "compare";
        public const string Pattern = "pattern";
        public const string Email = "email";
    }
    public partial class StringLengthRule
    {
        public float? max { get; set; }
        public string message { get; set; }
        public float? min { get; set; }
        public bool? trim { get; set; }
        public string type { get; set; }
    }

    public static class StringLengthRuleType
    {
        public const string Required = "required";
        public const string Numeric = "numeric";
        public const string Range = "range";
        public const string StringLength = "stringLength";
        public const string Custom = "custom";
        public const string Compare = "compare";
        public const string Pattern = "pattern";
        public const string Email = "email";
    }
    public partial class CustomRule
    {
        public string message { get; set; }
        public bool? reevaluate { get; set; }
        public string type { get; set; }
        // couldn't parse validationCallback
    }

    public static class CustomRuleType
    {
        public const string Required = "required";
        public const string Numeric = "numeric";
        public const string Range = "range";
        public const string StringLength = "stringLength";
        public const string Custom = "custom";
        public const string Compare = "compare";
        public const string Pattern = "pattern";
        public const string Email = "email";
    }
    public partial class CompareRule
    {
        // couldn't parse comparisonTarget
        public string comparisonType { get; set; }
        public string message { get; set; }
        public bool? reevaluate { get; set; }
        public string type { get; set; }
    }

    public static class CompareRuleComparisonType
    {
        public const string NotEqual = "!=";
        public const string StrictNotEqual = "!==";
        public const string LowerThan = "<";
        public const string LowerOrEqualThan = "<=";
        public const string Equal = "==";
        public const string StrictEqual = "===";
        public const string GreaterThan = ">";
        public const string GreaterThanEqual = ">=";
    }
    public static class CompareRuleType
    {
        public const string Required = "required";
        public const string Numeric = "numeric";
        public const string Range = "range";
        public const string StringLength = "stringLength";
        public const string Custom = "custom";
        public const string Compare = "compare";
        public const string Pattern = "pattern";
        public const string Email = "email";
    }
    public partial class PatternRule
    {
        public string message { get; set; }
        // couldn't parse pattern
        public string type { get; set; }
    }

    public static class PatternRuleType
    {
        public const string Required = "required";
        public const string Numeric = "numeric";
        public const string Range = "range";
        public const string StringLength = "stringLength";
        public const string Custom = "custom";
        public const string Compare = "compare";
        public const string Pattern = "pattern";
        public const string Email = "email";
    }
    public partial class EmailRule
    {
        public string message { get; set; }
        public string type { get; set; }
    }

    public static class EmailRuleType
    {
        public const string Required = "required";
        public const string Numeric = "numeric";
        public const string Range = "range";
        public const string StringLength = "stringLength";
        public const string Custom = "custom";
        public const string Compare = "compare";
        public const string Pattern = "pattern";
        public const string Email = "email";
    }
    public partial class DxValidationGroupResult
    {
        // couldn't parse brokenRules
        public bool? isValid { get; set; }
        // couldn't parse validators
    }
    public partial class DxValidatorResult
    {
        // couldn't parse brokenRule
        public bool? isValid { get; set; }
        // couldn't parse validationRules
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
        // couldn't parse adapter
        public string name { get; set; }
        public bool? onValidatedEnabled { get; set; }
        public string validationGroup { get; set; }
        // couldn't parse validationRules
    }
    public partial class DxCalendarCellTemplate
    {
        // couldn't parse date
        public string text { get; set; }
        public string view { get; set; }
    }

    public static class DxCalendarCellTemplateView
    {
        public const string Month = "month";
        public const string Year = "year";
        public const string Decade = "decade";
        public const string Century = "century";
    }
    public partial class CollectionWidgetOptions : WidgetOptions
    {
        // couldn't parse dataSource
        public float? itemHoldTimeout { get; set; }
        // couldn't parse items
        // couldn't parse itemTemplate
        // couldn't parse keyExpr
        public string noDataText { get; set; }
        public bool? onItemClickEnabled { get; set; }
        public bool? onItemContextMenuEnabled { get; set; }
        public bool? onItemHoldEnabled { get; set; }
        public bool? onItemRenderedEnabled { get; set; }
        public bool? onSelectionChangedEnabled { get; set; }
        public float? selectedIndex { get; set; }
        public object selectedItem { get; set; }
        // couldn't parse selectedItemKeys
        // couldn't parse selectedItems
    }
    public partial class CollectionWidgetItemTemplate
    {
        public bool? disabled { get; set; }
        public string html { get; set; }
        // couldn't parse template
        public string text { get; set; }
        public bool? visible { get; set; }
    }
    public partial class DxContextMenuItemTemplate : DxMenuBaseItemTemplate
    {
        // couldn't parse items
    }
    public partial class DxMenuBaseOptions : HierarchicalCollectionWidgetOptions
    {
        public bool? activeStateEnabled { get; set; }
        // couldn't parse animation
        public string cssClass { get; set; }
        // couldn't parse items
        public bool? selectByClick { get; set; }
        public string selectionMode { get; set; }
        // couldn't parse showSubmenuMode
    }

    public static class DxMenuBaseOptionsSelectionMode
    {
        public const string None = "none";
        public const string Single = "single";
    }
    public partial class DxMenuBaseItemTemplate : CollectionWidgetItemTemplate
    {
        public bool? beginGroup { get; set; }
        public bool? closeMenuOnClick { get; set; }
        public bool? disabled { get; set; }
        public string icon { get; set; }
        // couldn't parse items
        public bool? selectable { get; set; }
        public bool? selected { get; set; }
        public string text { get; set; }
        public bool? visible { get; set; }
    }
    public partial class DxDataGridColumn : GridBaseColumn
    {
        public bool? allowExporting { get; set; }
        public bool? allowGrouping { get; set; }
        public bool? autoExpandGroup { get; set; }
        // couldn't parse calculateGroupValue
        // couldn't parse columns
        // couldn't parse groupCellTemplate
        public float? groupIndex { get; set; }
        public float? precision { get; set; }
        public bool? showWhenGrouped { get; set; }
    }
    public partial class DxDropDownEditorOptions : DxTextBoxOptions
    {
        public bool? acceptCustomValue { get; set; }
        public bool? activeStateEnabled { get; set; }
        public string applyValueMode { get; set; }
        public bool? deferRendering { get; set; }
        // couldn't parse dropDownButtonTemplate
        public bool? onClosedEnabled { get; set; }
        public bool? onOpenedEnabled { get; set; }
        public bool? opened { get; set; }
        public object value { get; set; }
    }

    public static class DxDropDownEditorOptionsApplyValueMode
    {
        public const string Instantly = "instantly";
        public const string UseButtons = "useButtons";
    }
    public partial class DxDropDownListOptions : DxDropDownEditorOptions
    {
        public string displayValue { get; set; }
        public bool? grouped { get; set; }
        // couldn't parse groupTemplate
        public float? minSearchLength { get; set; }
        public string noDataText { get; set; }
        public bool? onItemClickEnabled { get; set; }
        public bool? onSelectionChangedEnabled { get; set; }
        public bool? onValueChangedEnabled { get; set; }
        public bool? searchEnabled { get; set; }
        // couldn't parse searchExpr
        public string searchMode { get; set; }
        public float? searchTimeout { get; set; }
        public object selectedItem { get; set; }
        public bool? showDataBeforeSearch { get; set; }
        public object value { get; set; }
        public string valueChangeEvent { get; set; }
    }

    public static class DxDropDownListOptionsSearchMode
    {
        public const string Contains = "contains";
        public const string Startswith = "startswith";
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

    public static class EditorOptionsValidationMessageMode
    {
        public const string Always = "always";
        public const string Auto = "auto";
    }
    public partial class DataExpressionMixinOptions
    {
        // couldn't parse dataSource
        // couldn't parse displayExpr
        // couldn't parse items
        // couldn't parse itemTemplate
        public object value { get; set; }
        // couldn't parse valueExpr
    }
    public partial class DataExpressionMixinItemTemplate
    {
        public bool? disabled { get; set; }
        public string html { get; set; }
        // couldn't parse template
        public string text { get; set; }
        public bool? visible { get; set; }
    }
    public partial class DxFilterBuilderField
    {
        // couldn't parse calculateFilterExpression
        public string caption { get; set; }
        // couldn't parse customizeText
        public string dataField { get; set; }
        public string dataType { get; set; }
        public object editorOptions { get; set; }
        // couldn't parse editorTemplate
        public string falseText { get; set; }
        // couldn't parse filterOperations
        // couldn't parse format
        // couldn't parse lookup
        public string trueText { get; set; }
    }

    public static class DxFilterBuilderFieldDataType
    {
        public const string String = "string";
        public const string Number = "number";
        public const string Date = "date";
        public const string Boolean = "boolean";
        public const string Object = "object";
        public const string Datetime = "datetime";
    }
    public partial class DxFilterBuilderCustomOperation
    {
        // couldn't parse calculateFilterExpression
        public string caption { get; set; }
        // couldn't parse customizeText
        // couldn't parse dataTypes
        // couldn't parse editorTemplate
        public bool? hasValue { get; set; }
        public string icon { get; set; }
        public string name { get; set; }
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
        // couldn't parse label
        public string name { get; set; }
        // couldn't parse template
        // couldn't parse validationRules
        public bool? visible { get; set; }
        public float? visibleIndex { get; set; }
    }

    public static class DxFormSimpleItemEditorType
    {
        public const string DxAutocomplete = "dxAutocomplete";
        public const string DxCalendar = "dxCalendar";
        public const string DxCheckBox = "dxCheckBox";
        public const string DxColorBox = "dxColorBox";
        public const string DxDateBox = "dxDateBox";
        public const string DxDropDownBox = "dxDropDownBox";
        public const string DxLookup = "dxLookup";
        public const string DxNumberBox = "dxNumberBox";
        public const string DxRadioGroup = "dxRadioGroup";
        public const string DxRangeSlider = "dxRangeSlider";
        public const string DxSelectBox = "dxSelectBox";
        public const string DxSlider = "dxSlider";
        public const string DxSwitch = "dxSwitch";
        public const string DxTagBox = "dxTagBox";
        public const string DxTextArea = "dxTextArea";
        public const string DxTextBox = "dxTextBox";
    }
    public static class DxFormSimpleItemItemType
    {
        public const string Empty = "empty";
        public const string Group = "group";
        public const string Simple = "simple";
        public const string Tabbed = "tabbed";
        public const string Button = "button";
    }
    public partial class DxFormGroupItem
    {
        public bool? alignItemLabels { get; set; }
        public string caption { get; set; }
        public float? colCount { get; set; }
        public object colCountByScreen { get; set; }
        public float? colSpan { get; set; }
        public string cssClass { get; set; }
        // couldn't parse items
        public string itemType { get; set; }
        public string name { get; set; }
        // couldn't parse template
        public bool? visible { get; set; }
        public float? visibleIndex { get; set; }
    }

    public static class DxFormGroupItemItemType
    {
        public const string Empty = "empty";
        public const string Group = "group";
        public const string Simple = "simple";
        public const string Tabbed = "tabbed";
        public const string Button = "button";
    }
    public partial class DxFormTabbedItem
    {
        public float? colSpan { get; set; }
        public string cssClass { get; set; }
        public string itemType { get; set; }
        public string name { get; set; }
        // couldn't parse tabPanelOptions
        // couldn't parse tabs
        public bool? visible { get; set; }
        public float? visibleIndex { get; set; }
    }

    public static class DxFormTabbedItemItemType
    {
        public const string Empty = "empty";
        public const string Group = "group";
        public const string Simple = "simple";
        public const string Tabbed = "tabbed";
        public const string Button = "button";
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

    public static class DxFormEmptyItemItemType
    {
        public const string Empty = "empty";
        public const string Group = "group";
        public const string Simple = "simple";
        public const string Tabbed = "tabbed";
        public const string Button = "button";
    }
    public partial class DxFormButtonItem
    {
        public string alignment { get; set; }
        // couldn't parse buttonOptions
        public float? colSpan { get; set; }
        public string cssClass { get; set; }
        public string itemType { get; set; }
        public string name { get; set; }
        public bool? visible { get; set; }
        public float? visibleIndex { get; set; }
    }

    public static class DxFormButtonItemAlignment
    {
        public const string Center = "center";
        public const string Left = "left";
        public const string Right = "right";
    }
    public static class DxFormButtonItemItemType
    {
        public const string Empty = "empty";
        public const string Group = "group";
        public const string Simple = "simple";
        public const string Tabbed = "tabbed";
        public const string Button = "button";
    }
    public partial class GridBaseColumn
    {
        // couldn't parse alignment
        public bool? allowEditing { get; set; }
        public bool? allowFiltering { get; set; }
        public bool? allowFixing { get; set; }
        public bool? allowHeaderFiltering { get; set; }
        public bool? allowHiding { get; set; }
        public bool? allowReordering { get; set; }
        public bool? allowResizing { get; set; }
        public bool? allowSearch { get; set; }
        public bool? allowSorting { get; set; }
        // couldn't parse calculateCellValue
        // couldn't parse calculateDisplayValue
        // couldn't parse calculateFilterExpression
        // couldn't parse calculateSortValue
        public string caption { get; set; }
        // couldn't parse cellTemplate
        public string cssClass { get; set; }
        // couldn't parse customizeText
        public string dataField { get; set; }
        public string dataType { get; set; }
        // couldn't parse editCellTemplate
        public object editorOptions { get; set; }
        public bool? encodeHtml { get; set; }
        public string falseText { get; set; }
        // couldn't parse filterOperations
        public string filterType { get; set; }
        public object filterValue { get; set; }
        // couldn't parse filterValues
        public bool? @fixed { get; set; }
        public string fixedPosition { get; set; }
        // couldn't parse format
        // couldn't parse formItem
        // couldn't parse headerCellTemplate
        // couldn't parse headerFilter
        public float? hidingPriority { get; set; }
        public bool? isBand { get; set; }
        // couldn't parse lookup
        public float? minWidth { get; set; }
        public string name { get; set; }
        public float? ownerBand { get; set; }
        public string selectedFilterOperation { get; set; }
        // couldn't parse setCellValue
        public bool? showEditorAlways { get; set; }
        public bool? showInColumnChooser { get; set; }
        public float? sortIndex { get; set; }
        // couldn't parse sortingMethod
        // couldn't parse sortOrder
        public string trueText { get; set; }
        // couldn't parse validationRules
        public bool? visible { get; set; }
        public float? visibleIndex { get; set; }
        // couldn't parse width
    }

    public static class GridBaseColumnDataType
    {
        public const string String = "string";
        public const string Number = "number";
        public const string Date = "date";
        public const string Boolean = "boolean";
        public const string Object = "object";
        public const string Datetime = "datetime";
    }
    public static class GridBaseColumnFilterType
    {
        public const string Exclude = "exclude";
        public const string Include = "include";
    }
    public static class GridBaseColumnFixedPosition
    {
        public const string Left = "left";
        public const string Right = "right";
    }
    public static class GridBaseColumnSelectedFilterOperation
    {
        public const string LowerThan = "<";
        public const string LowerOrEqualThan = "<=";
        public const string LowerGreaterThan = "<>";
        public const string Assignment = "=";
        public const string GreaterThan = ">";
        public const string GreaterThanEqual = ">=";
        public const string Between = "between";
        public const string Contains = "contains";
        public const string Endswith = "endswith";
        public const string Notcontains = "notcontains";
        public const string Startswith = "startswith";
    }
    public partial class DxTreeListColumn : GridBaseColumn
    {
        // couldn't parse columns
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
        // couldn't parse values
    }
    public partial class DxTreeListRowObject
    {
        public bool? isEditing { get; set; }
        public bool? isExpanded { get; set; }
        public bool? isSelected { get; set; }
        public object key { get; set; }
        public float? level { get; set; }
        // couldn't parse node
        public float? rowIndex { get; set; }
        public string rowType { get; set; }
        // couldn't parse values
    }
    public partial class HierarchicalCollectionWidgetOptions : CollectionWidgetOptions
    {
        // couldn't parse disabledExpr
        // couldn't parse displayExpr
        public bool? focusStateEnabled { get; set; }
        public bool? hoverStateEnabled { get; set; }
        // couldn't parse itemsExpr
        // couldn't parse keyExpr
        // couldn't parse selectedExpr
    }
    public partial class DxListItemTemplate : CollectionWidgetItemTemplate
    {
        public string badge { get; set; }
        public string key { get; set; }
        public bool? showChevron { get; set; }
    }
    public partial class DxMenuItemTemplate : DxMenuBaseItemTemplate
    {
        // couldn't parse items
    }
    public partial class DxPivotGridPivotGridCell
    {
        // couldn't parse columnPath
        public string columnType { get; set; }
        public float? dataIndex { get; set; }
        public bool? expanded { get; set; }
        // couldn't parse path
        // couldn't parse rowPath
        public string rowType { get; set; }
        public string text { get; set; }
        public string type { get; set; }
        public object value { get; set; }
    }

    public static class DxPivotGridPivotGridCellColumnType
    {
        public const string D = "D";
        public const string T = "T";
        public const string GT = "GT";
    }
    public static class DxPivotGridPivotGridCellRowType
    {
        public const string D = "D";
        public const string T = "T";
        public const string GT = "GT";
    }
    public static class DxPivotGridPivotGridCellType
    {
        public const string D = "D";
        public const string T = "T";
        public const string GT = "GT";
    }
    public partial class DxSchedulerAppointmentTemplate : CollectionWidgetItemTemplate
    {
        public bool? allDay { get; set; }
        public string description { get; set; }
        public bool? disabled { get; set; }
        // couldn't parse endDate
        public string endDateTimeZone { get; set; }
        public string html { get; set; }
        public string recurrenceException { get; set; }
        public string recurrenceRule { get; set; }
        // couldn't parse startDate
        public string startDateTimeZone { get; set; }
        // couldn't parse template
        public string text { get; set; }
        public bool? visible { get; set; }
    }
    public partial class DxSchedulerAppointmentTooltipTemplate
    {
        public bool? allDay { get; set; }
        public string description { get; set; }
        // couldn't parse endDate
        public string endDateTimeZone { get; set; }
        public string recurrenceException { get; set; }
        public string recurrenceRule { get; set; }
        // couldn't parse startDate
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

    public static class DxScrollableOptionsDirection
    {
        public const string Both = "both";
        public const string Horizontal = "horizontal";
        public const string Vertical = "vertical";
    }
    public static class DxScrollableOptionsShowScrollbar
    {
        public const string OnScroll = "onScroll";
        public const string OnHover = "onHover";
        public const string Always = "always";
        public const string Never = "never";
    }
    public partial class DxSliderBaseOptions : DxTrackBarOptions
    {
        public bool? activeStateEnabled { get; set; }
        public object focusStateEnabled { get; set; }
        public bool? hoverStateEnabled { get; set; }
        public float? keyStep { get; set; }
        // couldn't parse label
        public string name { get; set; }
        public bool? showRange { get; set; }
        public float? step { get; set; }
        // couldn't parse tooltip
    }
    public partial class DxTextEditorOptions : EditorOptions
    {
        public bool? focusStateEnabled { get; set; }
        public bool? hoverStateEnabled { get; set; }
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
        public object value { get; set; }
        public string valueChangeEvent { get; set; }
    }

    public static class DxTextEditorOptionsShowMaskMode
    {
        public const string Always = "always";
        public const string OnFocus = "onFocus";
    }
    public partial class DxTreeListNode
    {
        // couldn't parse children
        public object data { get; set; }
        public bool? hasChildren { get; set; }
        public object key { get; set; }
        public float? level { get; set; }
        // couldn't parse parent
        public bool? visible { get; set; }
    }
    public partial class DxTreeViewItemTemplate : CollectionWidgetItemTemplate
    {
        public bool? expanded { get; set; }
        public bool? hasItems { get; set; }
        public string icon { get; set; }
        // couldn't parse items
        // couldn't parse parentId
        public bool? selected { get; set; }
    }
    public partial class DxTreeViewNode
    {
        // couldn't parse children
        public bool? disabled { get; set; }
        public bool? expanded { get; set; }
        public object itemData { get; set; }
        public object key { get; set; }
        // couldn't parse parent
        public bool? selected { get; set; }
        public string text { get; set; }
    }
    public partial class SearchBoxMixinOptions
    {
        // couldn't parse searchEditorOptions
        public bool? searchEnabled { get; set; }
        // couldn't parse searchExpr
        public string searchMode { get; set; }
        public float? searchTimeout { get; set; }
        public string searchValue { get; set; }
    }

    public static class SearchBoxMixinOptionsSearchMode
    {
        public const string Contains = "contains";
        public const string Startswith = "startswith";
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
        // couldn't parse export
        // couldn't parse loadingIndicator
        // couldn't parse margin
        public bool? onDrawnEnabled { get; set; }
        public bool? onExportedEnabled { get; set; }
        public bool? onExportingEnabled { get; set; }
        public bool? onFileSavingEnabled { get; set; }
        public bool? onIncidentOccurredEnabled { get; set; }
        public bool? pathModified { get; set; }
        public bool? redrawOnResize { get; set; }
        public bool? rtlEnabled { get; set; }
        // couldn't parse size
        public string theme { get; set; }
        // couldn't parse title
        // couldn't parse tooltip
    }

    public static class BaseWidgetOptionsTheme
    {
        public const string GenericLight = "generic.light";
        public const string GenericDark = "generic.dark";
        public const string GenericContrast = "generic.contrast";
        public const string GenericCarmine = "generic.carmine";
        public const string GenericDarkmoon = "generic.darkmoon";
        public const string GenericSoftblue = "generic.softblue";
        public const string GenericDarkviolet = "generic.darkviolet";
        public const string GenericGreenmist = "generic.greenmist";
        public const string Android5Light = "android5.light";
        public const string Ios7Default = "ios7.default";
    }
    public partial class BaseWidgetExport
    {
        public string backgroundColor { get; set; }
        public bool? enabled { get; set; }
        public string fileName { get; set; }
        public string formats { get; set; }
        public bool? printingEnabled { get; set; }
        public string proxyUrl { get; set; }
    }
    public partial class BaseWidgetLoadingIndicator
    {
        public string backgroundColor { get; set; }
        // couldn't parse font
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
        // couldn't parse font
        public string horizontalAlignment { get; set; }
        // couldn't parse margin
        public float? placeholderSize { get; set; }
        // couldn't parse subtitle
        public string text { get; set; }
        public string verticalAlignment { get; set; }
    }

    public static class BaseWidgetTitleHorizontalAlignment
    {
        public const string Center = "center";
        public const string Left = "left";
        public const string Right = "right";
    }
    public static class BaseWidgetTitleVerticalAlignment
    {
        public const string Bottom = "bottom";
        public const string Top = "top";
    }
    public partial class BaseWidgetTooltip
    {
        public float? arrowLength { get; set; }
        // couldn't parse border
        public string color { get; set; }
        // couldn't parse container
        public bool? enabled { get; set; }
        // couldn't parse font
        // couldn't parse format
        public float? opacity { get; set; }
        public float? paddingLeftRight { get; set; }
        public float? paddingTopBottom { get; set; }
        public float? precision { get; set; }
        // couldn't parse shadow
        public float? zIndex { get; set; }
    }
    public partial class ScaleBreak
    {
        // couldn't parse endValue
        // couldn't parse startValue
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
        // couldn't parse AreaSeries
        // couldn't parse BarSeries
        // couldn't parse BubbleSeries
        // couldn't parse CandleStickSeries
        // couldn't parse CommonSeries
        // couldn't parse FullStackedAreaSeries
        // couldn't parse FullStackedBarSeries
        // couldn't parse FullStackedLineSeries
        // couldn't parse FullStackedSplineAreaSeries
        // couldn't parse FullStackedSplineSeries
        // couldn't parse LineSeries
        // couldn't parse RangeAreaSeries
        // couldn't parse RangeBarSeries
        // couldn't parse ScatterSeries
        // couldn't parse SplineAreaSeries
        // couldn't parse SplineSeries
        // couldn't parse StackedAreaSeries
        // couldn't parse StackedBarSeries
        // couldn't parse StackedLineSeries
        // couldn't parse StackedSplineAreaSeries
        // couldn't parse StackedSplineSeries
        // couldn't parse StepAreaSeries
        // couldn't parse StepLineSeries
        // couldn't parse StockSeries
    }
    public partial class DxChartSeriesTypesAreaSeries : DxChartSeriesTypesCommonSeries
    {
        // couldn't parse aggregation
        public string hoverMode { get; set; }
        // couldn't parse label
        // couldn't parse point
        public string selectionMode { get; set; }
    }

    public static class DxChartSeriesTypesAreaSeriesHoverMode
    {
        public const string NearestPoint = "nearestPoint";
        public const string IncludePoints = "includePoints";
        public const string ExcludePoints = "excludePoints";
        public const string None = "none";
    }
    public static class DxChartSeriesTypesAreaSeriesSelectionMode
    {
        public const string IncludePoints = "includePoints";
        public const string ExcludePoints = "excludePoints";
        public const string None = "none";
    }
    public partial class DxChartSeriesTypesAreaSeriesAggregation : DxChartSeriesTypesCommonSeriesAggregation
    {
        public string method { get; set; }
    }

    public static class DxChartSeriesTypesAreaSeriesAggregationMethod
    {
        public const string Avg = "avg";
        public const string Count = "count";
        public const string Max = "max";
        public const string Min = "min";
        public const string Sum = "sum";
        public const string Custom = "custom";
    }
    public partial class DxChartSeriesTypesAreaSeriesLabel : DxChartSeriesTypesCommonSeriesLabel
    {
        // couldn't parse customizeText
    }
    public partial class DxChartSeriesTypesAreaSeriesPoint : DxChartSeriesTypesCommonSeriesPoint
    {
        public bool? visible { get; set; }
    }
    public partial class DxChartSeriesTypesBarSeries : DxChartSeriesTypesCommonSeries
    {
        // couldn't parse aggregation
        public string hoverMode { get; set; }
        // couldn't parse label
        public string selectionMode { get; set; }
    }

    public static class DxChartSeriesTypesBarSeriesHoverMode
    {
        public const string OnlyPoint = "onlyPoint";
        public const string AllSeriesPoints = "allSeriesPoints";
        public const string AllArgumentPoints = "allArgumentPoints";
        public const string None = "none";
    }
    public static class DxChartSeriesTypesBarSeriesSelectionMode
    {
        public const string OnlyPoint = "onlyPoint";
        public const string AllSeriesPoints = "allSeriesPoints";
        public const string AllArgumentPoints = "allArgumentPoints";
        public const string None = "none";
    }
    public partial class DxChartSeriesTypesBarSeriesAggregation : DxChartSeriesTypesCommonSeriesAggregation
    {
        public string method { get; set; }
    }

    public static class DxChartSeriesTypesBarSeriesAggregationMethod
    {
        public const string Avg = "avg";
        public const string Count = "count";
        public const string Max = "max";
        public const string Min = "min";
        public const string Sum = "sum";
        public const string Custom = "custom";
    }
    public partial class DxChartSeriesTypesBarSeriesLabel : DxChartSeriesTypesCommonSeriesLabel
    {
        // couldn't parse customizeText
    }
    public partial class DxChartSeriesTypesBubbleSeries : DxChartSeriesTypesCommonSeries
    {
        // couldn't parse aggregation
        public string hoverMode { get; set; }
        // couldn't parse label
        public string selectionMode { get; set; }
    }

    public static class DxChartSeriesTypesBubbleSeriesHoverMode
    {
        public const string OnlyPoint = "onlyPoint";
        public const string AllSeriesPoints = "allSeriesPoints";
        public const string AllArgumentPoints = "allArgumentPoints";
        public const string None = "none";
    }
    public static class DxChartSeriesTypesBubbleSeriesSelectionMode
    {
        public const string OnlyPoint = "onlyPoint";
        public const string AllSeriesPoints = "allSeriesPoints";
        public const string AllArgumentPoints = "allArgumentPoints";
        public const string None = "none";
    }
    public partial class DxChartSeriesTypesBubbleSeriesAggregation : DxChartSeriesTypesCommonSeriesAggregation
    {
        public string method { get; set; }
    }

    public static class DxChartSeriesTypesBubbleSeriesAggregationMethod
    {
        public const string Avg = "avg";
        public const string Custom = "custom";
    }
    public partial class DxChartSeriesTypesBubbleSeriesLabel : DxChartSeriesTypesCommonSeriesLabel
    {
        // couldn't parse customizeText
    }
    public partial class DxChartSeriesTypesCandleStickSeries : DxChartSeriesTypesCommonSeries
    {
        // couldn't parse aggregation
        public string argumentField { get; set; }
        public string hoverMode { get; set; }
        // couldn't parse hoverStyle
        // couldn't parse label
        public string selectionMode { get; set; }
        // couldn't parse selectionStyle
    }

    public static class DxChartSeriesTypesCandleStickSeriesHoverMode
    {
        public const string OnlyPoint = "onlyPoint";
        public const string AllSeriesPoints = "allSeriesPoints";
        public const string AllArgumentPoints = "allArgumentPoints";
        public const string None = "none";
    }
    public static class DxChartSeriesTypesCandleStickSeriesSelectionMode
    {
        public const string OnlyPoint = "onlyPoint";
        public const string AllSeriesPoints = "allSeriesPoints";
        public const string AllArgumentPoints = "allArgumentPoints";
        public const string None = "none";
    }
    public partial class DxChartSeriesTypesCandleStickSeriesAggregation : DxChartSeriesTypesCommonSeriesAggregation
    {
        public string method { get; set; }
    }

    public static class DxChartSeriesTypesCandleStickSeriesAggregationMethod
    {
        public const string Ohlc = "ohlc";
        public const string Custom = "custom";
    }
    public partial class DxChartSeriesTypesCandleStickSeriesHoverStyle : DxChartSeriesTypesCommonSeriesHoverStyle
    {
        // couldn't parse hatching
    }
    public partial class DxChartSeriesTypesCandleStickSeriesHoverStyleHatching : DxChartSeriesTypesCommonSeriesHoverStyleHatching
    {
        public string direction { get; set; }
    }

    public static class DxChartSeriesTypesCandleStickSeriesHoverStyleHatchingDirection
    {
        public const string Left = "left";
        public const string None = "none";
        public const string Right = "right";
    }
    public partial class DxChartSeriesTypesCandleStickSeriesLabel : DxChartSeriesTypesCommonSeriesLabel
    {
        // couldn't parse customizeText
    }
    public partial class DxChartSeriesTypesCandleStickSeriesSelectionStyle : DxChartSeriesTypesCommonSeriesSelectionStyle
    {
        // couldn't parse hatching
    }
    public partial class DxChartSeriesTypesCandleStickSeriesSelectionStyleHatching : DxChartSeriesTypesCommonSeriesSelectionStyleHatching
    {
        public string direction { get; set; }
    }

    public static class DxChartSeriesTypesCandleStickSeriesSelectionStyleHatchingDirection
    {
        public const string Left = "left";
        public const string None = "none";
        public const string Right = "right";
    }
    public partial class DxChartSeriesTypesCommonSeries
    {
        // couldn't parse aggregation
        public string argumentField { get; set; }
        public string axis { get; set; }
        public float? barPadding { get; set; }
        public float? barWidth { get; set; }
        // couldn't parse border
        public string closeValueField { get; set; }
        public string color { get; set; }
        public float? cornerRadius { get; set; }
        public string dashStyle { get; set; }
        public string highValueField { get; set; }
        public string hoverMode { get; set; }
        // couldn't parse hoverStyle
        public bool? ignoreEmptyPoints { get; set; }
        public string innerColor { get; set; }
        // couldn't parse label
        public string lowValueField { get; set; }
        public float? maxLabelCount { get; set; }
        public float? minBarSize { get; set; }
        public float? opacity { get; set; }
        public string openValueField { get; set; }
        public string pane { get; set; }
        // couldn't parse point
        public string rangeValue1Field { get; set; }
        public string rangeValue2Field { get; set; }
        // couldn't parse reduction
        public string selectionMode { get; set; }
        // couldn't parse selectionStyle
        public bool? showInLegend { get; set; }
        public string sizeField { get; set; }
        public string stack { get; set; }
        public string tagField { get; set; }
        // couldn't parse valueErrorBar
        public string valueField { get; set; }
        public bool? visible { get; set; }
        public float? width { get; set; }
    }

    public static class DxChartSeriesTypesCommonSeriesDashStyle
    {
        public const string Dash = "dash";
        public const string Dot = "dot";
        public const string LongDash = "longDash";
        public const string Solid = "solid";
    }
    public static class DxChartSeriesTypesCommonSeriesHoverMode
    {
        public const string AllArgumentPoints = "allArgumentPoints";
        public const string AllSeriesPoints = "allSeriesPoints";
        public const string ExcludePoints = "excludePoints";
        public const string IncludePoints = "includePoints";
        public const string NearestPoint = "nearestPoint";
        public const string None = "none";
        public const string OnlyPoint = "onlyPoint";
    }
    public static class DxChartSeriesTypesCommonSeriesSelectionMode
    {
        public const string AllArgumentPoints = "allArgumentPoints";
        public const string AllSeriesPoints = "allSeriesPoints";
        public const string ExcludePoints = "excludePoints";
        public const string IncludePoints = "includePoints";
        public const string None = "none";
        public const string OnlyPoint = "onlyPoint";
    }
    public partial class DxChartSeriesTypesCommonSeriesAggregation
    {
        // couldn't parse calculate
        public bool? enabled { get; set; }
        public string method { get; set; }
    }

    public static class DxChartSeriesTypesCommonSeriesAggregationMethod
    {
        public const string Avg = "avg";
        public const string Count = "count";
        public const string Max = "max";
        public const string Min = "min";
        public const string Ohlc = "ohlc";
        public const string Range = "range";
        public const string Sum = "sum";
        public const string Custom = "custom";
    }
    public partial class DxChartSeriesTypesCommonSeriesBorder
    {
        public string color { get; set; }
        public string dashStyle { get; set; }
        public bool? visible { get; set; }
        public float? width { get; set; }
    }

    public static class DxChartSeriesTypesCommonSeriesBorderDashStyle
    {
        public const string Dash = "dash";
        public const string Dot = "dot";
        public const string LongDash = "longDash";
        public const string Solid = "solid";
    }
    public partial class DxChartSeriesTypesCommonSeriesHoverStyle
    {
        // couldn't parse border
        public string color { get; set; }
        public string dashStyle { get; set; }
        // couldn't parse hatching
        public float? width { get; set; }
    }

    public static class DxChartSeriesTypesCommonSeriesHoverStyleDashStyle
    {
        public const string Dash = "dash";
        public const string Dot = "dot";
        public const string LongDash = "longDash";
        public const string Solid = "solid";
    }
    public partial class DxChartSeriesTypesCommonSeriesHoverStyleBorder
    {
        public string color { get; set; }
        public string dashStyle { get; set; }
        public bool? visible { get; set; }
        public float? width { get; set; }
    }

    public static class DxChartSeriesTypesCommonSeriesHoverStyleBorderDashStyle
    {
        public const string Dash = "dash";
        public const string Dot = "dot";
        public const string LongDash = "longDash";
        public const string Solid = "solid";
    }
    public partial class DxChartSeriesTypesCommonSeriesHoverStyleHatching
    {
        public string direction { get; set; }
        public float? opacity { get; set; }
        public float? step { get; set; }
        public float? width { get; set; }
    }

    public static class DxChartSeriesTypesCommonSeriesHoverStyleHatchingDirection
    {
        public const string Left = "left";
        public const string None = "none";
        public const string Right = "right";
    }
    public partial class DxChartSeriesTypesCommonSeriesLabel
    {
        public string alignment { get; set; }
        // couldn't parse argumentFormat
        public float? argumentPrecision { get; set; }
        public string backgroundColor { get; set; }
        // couldn't parse border
        // couldn't parse connector
        // couldn't parse customizeText
        // couldn't parse font
        // couldn't parse format
        public float? horizontalOffset { get; set; }
        public float? percentPrecision { get; set; }
        public string position { get; set; }
        public float? precision { get; set; }
        public float? rotationAngle { get; set; }
        public bool? showForZeroValues { get; set; }
        public float? verticalOffset { get; set; }
        public bool? visible { get; set; }
    }

    public static class DxChartSeriesTypesCommonSeriesLabelAlignment
    {
        public const string Center = "center";
        public const string Left = "left";
        public const string Right = "right";
    }
    public static class DxChartSeriesTypesCommonSeriesLabelPosition
    {
        public const string Inside = "inside";
        public const string Outside = "outside";
    }
    public partial class DxChartSeriesTypesCommonSeriesPoint
    {
        // couldn't parse border
        public string color { get; set; }
        public string hoverMode { get; set; }
        // couldn't parse hoverStyle
        // couldn't parse image
        public string selectionMode { get; set; }
        // couldn't parse selectionStyle
        public float? size { get; set; }
        public string symbol { get; set; }
        public bool? visible { get; set; }
    }

    public static class DxChartSeriesTypesCommonSeriesPointHoverMode
    {
        public const string AllArgumentPoints = "allArgumentPoints";
        public const string AllSeriesPoints = "allSeriesPoints";
        public const string None = "none";
        public const string OnlyPoint = "onlyPoint";
    }
    public static class DxChartSeriesTypesCommonSeriesPointSelectionMode
    {
        public const string AllArgumentPoints = "allArgumentPoints";
        public const string AllSeriesPoints = "allSeriesPoints";
        public const string None = "none";
        public const string OnlyPoint = "onlyPoint";
    }
    public static class DxChartSeriesTypesCommonSeriesPointSymbol
    {
        public const string Circle = "circle";
        public const string Cross = "cross";
        public const string Polygon = "polygon";
        public const string Square = "square";
        public const string TriangleDown = "triangleDown";
        public const string TriangleUp = "triangleUp";
    }
    public partial class DxChartSeriesTypesCommonSeriesSelectionStyle
    {
        // couldn't parse border
        public string color { get; set; }
        public string dashStyle { get; set; }
        // couldn't parse hatching
        public float? width { get; set; }
    }

    public static class DxChartSeriesTypesCommonSeriesSelectionStyleDashStyle
    {
        public const string Dash = "dash";
        public const string Dot = "dot";
        public const string LongDash = "longDash";
        public const string Solid = "solid";
    }
    public partial class DxChartSeriesTypesCommonSeriesSelectionStyleBorder
    {
        public string color { get; set; }
        public string dashStyle { get; set; }
        public bool? visible { get; set; }
        public float? width { get; set; }
    }

    public static class DxChartSeriesTypesCommonSeriesSelectionStyleBorderDashStyle
    {
        public const string Dash = "dash";
        public const string Dot = "dot";
        public const string LongDash = "longDash";
        public const string Solid = "solid";
    }
    public partial class DxChartSeriesTypesCommonSeriesSelectionStyleHatching
    {
        public string direction { get; set; }
        public float? opacity { get; set; }
        public float? step { get; set; }
        public float? width { get; set; }
    }

    public static class DxChartSeriesTypesCommonSeriesSelectionStyleHatchingDirection
    {
        public const string Left = "left";
        public const string None = "none";
        public const string Right = "right";
    }
    public partial class DxChartSeriesTypesFullStackedAreaSeries : DxChartSeriesTypesCommonSeries
    {
        // couldn't parse aggregation
        public string hoverMode { get; set; }
        // couldn't parse label
        // couldn't parse point
        public string selectionMode { get; set; }
    }

    public static class DxChartSeriesTypesFullStackedAreaSeriesHoverMode
    {
        public const string NearestPoint = "nearestPoint";
        public const string IncludePoints = "includePoints";
        public const string ExcludePoints = "excludePoints";
        public const string None = "none";
    }
    public static class DxChartSeriesTypesFullStackedAreaSeriesSelectionMode
    {
        public const string IncludePoints = "includePoints";
        public const string ExcludePoints = "excludePoints";
        public const string None = "none";
    }
    public partial class DxChartSeriesTypesFullStackedAreaSeriesAggregation : DxChartSeriesTypesCommonSeriesAggregation
    {
        public string method { get; set; }
    }

    public static class DxChartSeriesTypesFullStackedAreaSeriesAggregationMethod
    {
        public const string Avg = "avg";
        public const string Count = "count";
        public const string Max = "max";
        public const string Min = "min";
        public const string Sum = "sum";
        public const string Custom = "custom";
    }
    public partial class DxChartSeriesTypesFullStackedAreaSeriesLabel : DxChartSeriesTypesCommonSeriesLabel
    {
        // couldn't parse customizeText
    }
    public partial class DxChartSeriesTypesFullStackedAreaSeriesPoint : DxChartSeriesTypesCommonSeriesPoint
    {
        public bool? visible { get; set; }
    }
    public partial class DxChartSeriesTypesFullStackedBarSeries : DxChartSeriesTypesCommonSeries
    {
        // couldn't parse aggregation
        public string hoverMode { get; set; }
        // couldn't parse label
        public string selectionMode { get; set; }
    }

    public static class DxChartSeriesTypesFullStackedBarSeriesHoverMode
    {
        public const string OnlyPoint = "onlyPoint";
        public const string AllSeriesPoints = "allSeriesPoints";
        public const string AllArgumentPoints = "allArgumentPoints";
        public const string None = "none";
    }
    public static class DxChartSeriesTypesFullStackedBarSeriesSelectionMode
    {
        public const string OnlyPoint = "onlyPoint";
        public const string AllSeriesPoints = "allSeriesPoints";
        public const string AllArgumentPoints = "allArgumentPoints";
        public const string None = "none";
    }
    public partial class DxChartSeriesTypesFullStackedBarSeriesAggregation : DxChartSeriesTypesCommonSeriesAggregation
    {
        public string method { get; set; }
    }

    public static class DxChartSeriesTypesFullStackedBarSeriesAggregationMethod
    {
        public const string Avg = "avg";
        public const string Count = "count";
        public const string Max = "max";
        public const string Min = "min";
        public const string Sum = "sum";
        public const string Custom = "custom";
    }
    public partial class DxChartSeriesTypesFullStackedBarSeriesLabel : DxChartSeriesTypesCommonSeriesLabel
    {
        // couldn't parse customizeText
        public string position { get; set; }
    }

    public static class DxChartSeriesTypesFullStackedBarSeriesLabelPosition
    {
        public const string Inside = "inside";
        public const string Outside = "outside";
    }
    public partial class DxChartSeriesTypesFullStackedLineSeries : DxChartSeriesTypesCommonSeries
    {
        // couldn't parse aggregation
        public string hoverMode { get; set; }
        // couldn't parse label
        public string selectionMode { get; set; }
    }

    public static class DxChartSeriesTypesFullStackedLineSeriesHoverMode
    {
        public const string NearestPoint = "nearestPoint";
        public const string IncludePoints = "includePoints";
        public const string ExcludePoints = "excludePoints";
        public const string None = "none";
    }
    public static class DxChartSeriesTypesFullStackedLineSeriesSelectionMode
    {
        public const string IncludePoints = "includePoints";
        public const string ExcludePoints = "excludePoints";
        public const string None = "none";
    }
    public partial class DxChartSeriesTypesFullStackedLineSeriesAggregation : DxChartSeriesTypesCommonSeriesAggregation
    {
        public string method { get; set; }
    }

    public static class DxChartSeriesTypesFullStackedLineSeriesAggregationMethod
    {
        public const string Avg = "avg";
        public const string Count = "count";
        public const string Max = "max";
        public const string Min = "min";
        public const string Sum = "sum";
        public const string Custom = "custom";
    }
    public partial class DxChartSeriesTypesFullStackedLineSeriesLabel : DxChartSeriesTypesCommonSeriesLabel
    {
        // couldn't parse customizeText
    }
    public partial class DxChartSeriesTypesFullStackedSplineAreaSeries : DxChartSeriesTypesCommonSeries
    {
        // couldn't parse aggregation
        public string hoverMode { get; set; }
        // couldn't parse label
        // couldn't parse point
        public string selectionMode { get; set; }
    }

    public static class DxChartSeriesTypesFullStackedSplineAreaSeriesHoverMode
    {
        public const string NearestPoint = "nearestPoint";
        public const string IncludePoints = "includePoints";
        public const string ExcludePoints = "excludePoints";
        public const string None = "none";
    }
    public static class DxChartSeriesTypesFullStackedSplineAreaSeriesSelectionMode
    {
        public const string IncludePoints = "includePoints";
        public const string ExcludePoints = "excludePoints";
        public const string None = "none";
    }
    public partial class DxChartSeriesTypesFullStackedSplineAreaSeriesAggregation : DxChartSeriesTypesCommonSeriesAggregation
    {
        public string method { get; set; }
    }

    public static class DxChartSeriesTypesFullStackedSplineAreaSeriesAggregationMethod
    {
        public const string Avg = "avg";
        public const string Count = "count";
        public const string Max = "max";
        public const string Min = "min";
        public const string Sum = "sum";
        public const string Custom = "custom";
    }
    public partial class DxChartSeriesTypesFullStackedSplineAreaSeriesLabel : DxChartSeriesTypesCommonSeriesLabel
    {
        // couldn't parse customizeText
    }
    public partial class DxChartSeriesTypesFullStackedSplineAreaSeriesPoint : DxChartSeriesTypesCommonSeriesPoint
    {
        public bool? visible { get; set; }
    }
    public partial class DxChartSeriesTypesFullStackedSplineSeries : DxChartSeriesTypesCommonSeries
    {
        // couldn't parse aggregation
        public string hoverMode { get; set; }
        // couldn't parse label
        public string selectionMode { get; set; }
    }

    public static class DxChartSeriesTypesFullStackedSplineSeriesHoverMode
    {
        public const string NearestPoint = "nearestPoint";
        public const string IncludePoints = "includePoints";
        public const string ExcludePoints = "excludePoints";
        public const string None = "none";
    }
    public static class DxChartSeriesTypesFullStackedSplineSeriesSelectionMode
    {
        public const string IncludePoints = "includePoints";
        public const string ExcludePoints = "excludePoints";
        public const string None = "none";
    }
    public partial class DxChartSeriesTypesFullStackedSplineSeriesAggregation : DxChartSeriesTypesCommonSeriesAggregation
    {
        public string method { get; set; }
    }

    public static class DxChartSeriesTypesFullStackedSplineSeriesAggregationMethod
    {
        public const string Avg = "avg";
        public const string Count = "count";
        public const string Max = "max";
        public const string Min = "min";
        public const string Sum = "sum";
        public const string Custom = "custom";
    }
    public partial class DxChartSeriesTypesFullStackedSplineSeriesLabel : DxChartSeriesTypesCommonSeriesLabel
    {
        // couldn't parse customizeText
    }
    public partial class DxChartSeriesTypesLineSeries : DxChartSeriesTypesCommonSeries
    {
        // couldn't parse aggregation
        public string hoverMode { get; set; }
        // couldn't parse label
        public string selectionMode { get; set; }
    }

    public static class DxChartSeriesTypesLineSeriesHoverMode
    {
        public const string NearestPoint = "nearestPoint";
        public const string IncludePoints = "includePoints";
        public const string ExcludePoints = "excludePoints";
        public const string None = "none";
    }
    public static class DxChartSeriesTypesLineSeriesSelectionMode
    {
        public const string IncludePoints = "includePoints";
        public const string ExcludePoints = "excludePoints";
        public const string None = "none";
    }
    public partial class DxChartSeriesTypesLineSeriesAggregation : DxChartSeriesTypesCommonSeriesAggregation
    {
        public string method { get; set; }
    }

    public static class DxChartSeriesTypesLineSeriesAggregationMethod
    {
        public const string Avg = "avg";
        public const string Count = "count";
        public const string Max = "max";
        public const string Min = "min";
        public const string Sum = "sum";
        public const string Custom = "custom";
    }
    public partial class DxChartSeriesTypesLineSeriesLabel : DxChartSeriesTypesCommonSeriesLabel
    {
        // couldn't parse customizeText
    }
    public partial class DxChartSeriesTypesRangeAreaSeries : DxChartSeriesTypesCommonSeries
    {
        // couldn't parse aggregation
        public string hoverMode { get; set; }
        // couldn't parse label
        // couldn't parse point
        public string selectionMode { get; set; }
    }

    public static class DxChartSeriesTypesRangeAreaSeriesHoverMode
    {
        public const string NearestPoint = "nearestPoint";
        public const string IncludePoints = "includePoints";
        public const string ExcludePoints = "excludePoints";
        public const string None = "none";
    }
    public static class DxChartSeriesTypesRangeAreaSeriesSelectionMode
    {
        public const string IncludePoints = "includePoints";
        public const string ExcludePoints = "excludePoints";
        public const string None = "none";
    }
    public partial class DxChartSeriesTypesRangeAreaSeriesAggregation : DxChartSeriesTypesCommonSeriesAggregation
    {
        public string method { get; set; }
    }

    public static class DxChartSeriesTypesRangeAreaSeriesAggregationMethod
    {
        public const string Range = "range";
        public const string Custom = "custom";
    }
    public partial class DxChartSeriesTypesRangeAreaSeriesLabel : DxChartSeriesTypesCommonSeriesLabel
    {
        // couldn't parse customizeText
    }
    public partial class DxChartSeriesTypesRangeAreaSeriesPoint : DxChartSeriesTypesCommonSeriesPoint
    {
        public bool? visible { get; set; }
    }
    public partial class DxChartSeriesTypesRangeBarSeries : DxChartSeriesTypesCommonSeries
    {
        // couldn't parse aggregation
        public string hoverMode { get; set; }
        // couldn't parse label
        public string selectionMode { get; set; }
    }

    public static class DxChartSeriesTypesRangeBarSeriesHoverMode
    {
        public const string OnlyPoint = "onlyPoint";
        public const string AllSeriesPoints = "allSeriesPoints";
        public const string AllArgumentPoints = "allArgumentPoints";
        public const string None = "none";
    }
    public static class DxChartSeriesTypesRangeBarSeriesSelectionMode
    {
        public const string OnlyPoint = "onlyPoint";
        public const string AllSeriesPoints = "allSeriesPoints";
        public const string AllArgumentPoints = "allArgumentPoints";
        public const string None = "none";
    }
    public partial class DxChartSeriesTypesRangeBarSeriesAggregation : DxChartSeriesTypesCommonSeriesAggregation
    {
        public string method { get; set; }
    }

    public static class DxChartSeriesTypesRangeBarSeriesAggregationMethod
    {
        public const string Range = "range";
        public const string Custom = "custom";
    }
    public partial class DxChartSeriesTypesRangeBarSeriesLabel : DxChartSeriesTypesCommonSeriesLabel
    {
        // couldn't parse customizeText
    }
    public partial class DxChartSeriesTypesScatterSeries : DxChartSeriesTypesCommonSeries
    {
        // couldn't parse aggregation
        // couldn't parse label
    }
    public partial class DxChartSeriesTypesScatterSeriesAggregation : DxChartSeriesTypesCommonSeriesAggregation
    {
        public string method { get; set; }
    }

    public static class DxChartSeriesTypesScatterSeriesAggregationMethod
    {
        public const string Avg = "avg";
        public const string Count = "count";
        public const string Max = "max";
        public const string Min = "min";
        public const string Sum = "sum";
        public const string Custom = "custom";
    }
    public partial class DxChartSeriesTypesScatterSeriesLabel : DxChartSeriesTypesCommonSeriesLabel
    {
        // couldn't parse customizeText
    }
    public partial class DxChartSeriesTypesSplineAreaSeries : DxChartSeriesTypesCommonSeries
    {
        // couldn't parse aggregation
        public string hoverMode { get; set; }
        // couldn't parse label
        // couldn't parse point
        public string selectionMode { get; set; }
    }

    public static class DxChartSeriesTypesSplineAreaSeriesHoverMode
    {
        public const string NearestPoint = "nearestPoint";
        public const string IncludePoints = "includePoints";
        public const string ExcludePoints = "excludePoints";
        public const string None = "none";
    }
    public static class DxChartSeriesTypesSplineAreaSeriesSelectionMode
    {
        public const string IncludePoints = "includePoints";
        public const string ExcludePoints = "excludePoints";
        public const string None = "none";
    }
    public partial class DxChartSeriesTypesSplineAreaSeriesAggregation : DxChartSeriesTypesCommonSeriesAggregation
    {
        public string method { get; set; }
    }

    public static class DxChartSeriesTypesSplineAreaSeriesAggregationMethod
    {
        public const string Avg = "avg";
        public const string Count = "count";
        public const string Max = "max";
        public const string Min = "min";
        public const string Sum = "sum";
        public const string Custom = "custom";
    }
    public partial class DxChartSeriesTypesSplineAreaSeriesLabel : DxChartSeriesTypesCommonSeriesLabel
    {
        // couldn't parse customizeText
    }
    public partial class DxChartSeriesTypesSplineAreaSeriesPoint : DxChartSeriesTypesCommonSeriesPoint
    {
        public bool? visible { get; set; }
    }
    public partial class DxChartSeriesTypesSplineSeries : DxChartSeriesTypesCommonSeries
    {
        // couldn't parse aggregation
        public string hoverMode { get; set; }
        // couldn't parse label
        public string selectionMode { get; set; }
    }

    public static class DxChartSeriesTypesSplineSeriesHoverMode
    {
        public const string NearestPoint = "nearestPoint";
        public const string IncludePoints = "includePoints";
        public const string ExcludePoints = "excludePoints";
        public const string None = "none";
    }
    public static class DxChartSeriesTypesSplineSeriesSelectionMode
    {
        public const string IncludePoints = "includePoints";
        public const string ExcludePoints = "excludePoints";
        public const string None = "none";
    }
    public partial class DxChartSeriesTypesSplineSeriesAggregation : DxChartSeriesTypesCommonSeriesAggregation
    {
        public string method { get; set; }
    }

    public static class DxChartSeriesTypesSplineSeriesAggregationMethod
    {
        public const string Avg = "avg";
        public const string Count = "count";
        public const string Max = "max";
        public const string Min = "min";
        public const string Sum = "sum";
        public const string Custom = "custom";
    }
    public partial class DxChartSeriesTypesSplineSeriesLabel : DxChartSeriesTypesCommonSeriesLabel
    {
        // couldn't parse customizeText
    }
    public partial class DxChartSeriesTypesStackedAreaSeries : DxChartSeriesTypesCommonSeries
    {
        // couldn't parse aggregation
        public string hoverMode { get; set; }
        // couldn't parse label
        // couldn't parse point
        public string selectionMode { get; set; }
    }

    public static class DxChartSeriesTypesStackedAreaSeriesHoverMode
    {
        public const string NearestPoint = "nearestPoint";
        public const string IncludePoints = "includePoints";
        public const string ExcludePoints = "excludePoints";
        public const string None = "none";
    }
    public static class DxChartSeriesTypesStackedAreaSeriesSelectionMode
    {
        public const string IncludePoints = "includePoints";
        public const string ExcludePoints = "excludePoints";
        public const string None = "none";
    }
    public partial class DxChartSeriesTypesStackedAreaSeriesAggregation : DxChartSeriesTypesCommonSeriesAggregation
    {
        public string method { get; set; }
    }

    public static class DxChartSeriesTypesStackedAreaSeriesAggregationMethod
    {
        public const string Avg = "avg";
        public const string Count = "count";
        public const string Max = "max";
        public const string Min = "min";
        public const string Sum = "sum";
        public const string Custom = "custom";
    }
    public partial class DxChartSeriesTypesStackedAreaSeriesLabel : DxChartSeriesTypesCommonSeriesLabel
    {
        // couldn't parse customizeText
    }
    public partial class DxChartSeriesTypesStackedAreaSeriesPoint : DxChartSeriesTypesCommonSeriesPoint
    {
        public bool? visible { get; set; }
    }
    public partial class DxChartSeriesTypesStackedBarSeries : DxChartSeriesTypesCommonSeries
    {
        // couldn't parse aggregation
        public string hoverMode { get; set; }
        // couldn't parse label
        public string selectionMode { get; set; }
    }

    public static class DxChartSeriesTypesStackedBarSeriesHoverMode
    {
        public const string OnlyPoint = "onlyPoint";
        public const string AllSeriesPoints = "allSeriesPoints";
        public const string AllArgumentPoints = "allArgumentPoints";
        public const string None = "none";
    }
    public static class DxChartSeriesTypesStackedBarSeriesSelectionMode
    {
        public const string OnlyPoint = "onlyPoint";
        public const string AllSeriesPoints = "allSeriesPoints";
        public const string AllArgumentPoints = "allArgumentPoints";
        public const string None = "none";
    }
    public partial class DxChartSeriesTypesStackedBarSeriesAggregation : DxChartSeriesTypesCommonSeriesAggregation
    {
        public string method { get; set; }
    }

    public static class DxChartSeriesTypesStackedBarSeriesAggregationMethod
    {
        public const string Avg = "avg";
        public const string Count = "count";
        public const string Max = "max";
        public const string Min = "min";
        public const string Sum = "sum";
        public const string Custom = "custom";
    }
    public partial class DxChartSeriesTypesStackedBarSeriesLabel : DxChartSeriesTypesCommonSeriesLabel
    {
        // couldn't parse customizeText
        public string position { get; set; }
    }

    public static class DxChartSeriesTypesStackedBarSeriesLabelPosition
    {
        public const string Inside = "inside";
        public const string Outside = "outside";
    }
    public partial class DxChartSeriesTypesStackedLineSeries : DxChartSeriesTypesCommonSeries
    {
        // couldn't parse aggregation
        public string hoverMode { get; set; }
        // couldn't parse label
        public string selectionMode { get; set; }
    }

    public static class DxChartSeriesTypesStackedLineSeriesHoverMode
    {
        public const string NearestPoint = "nearestPoint";
        public const string IncludePoints = "includePoints";
        public const string ExcludePoints = "excludePoints";
        public const string None = "none";
    }
    public static class DxChartSeriesTypesStackedLineSeriesSelectionMode
    {
        public const string IncludePoints = "includePoints";
        public const string ExcludePoints = "excludePoints";
        public const string None = "none";
    }
    public partial class DxChartSeriesTypesStackedLineSeriesAggregation : DxChartSeriesTypesCommonSeriesAggregation
    {
        public string method { get; set; }
    }

    public static class DxChartSeriesTypesStackedLineSeriesAggregationMethod
    {
        public const string Avg = "avg";
        public const string Count = "count";
        public const string Max = "max";
        public const string Min = "min";
        public const string Sum = "sum";
        public const string Custom = "custom";
    }
    public partial class DxChartSeriesTypesStackedLineSeriesLabel : DxChartSeriesTypesCommonSeriesLabel
    {
        // couldn't parse customizeText
    }
    public partial class DxChartSeriesTypesStackedSplineAreaSeries : DxChartSeriesTypesCommonSeries
    {
        // couldn't parse aggregation
        public string hoverMode { get; set; }
        // couldn't parse label
        // couldn't parse point
        public string selectionMode { get; set; }
    }

    public static class DxChartSeriesTypesStackedSplineAreaSeriesHoverMode
    {
        public const string NearestPoint = "nearestPoint";
        public const string IncludePoints = "includePoints";
        public const string ExcludePoints = "excludePoints";
        public const string None = "none";
    }
    public static class DxChartSeriesTypesStackedSplineAreaSeriesSelectionMode
    {
        public const string IncludePoints = "includePoints";
        public const string ExcludePoints = "excludePoints";
        public const string None = "none";
    }
    public partial class DxChartSeriesTypesStackedSplineAreaSeriesAggregation : DxChartSeriesTypesCommonSeriesAggregation
    {
        public string method { get; set; }
    }

    public static class DxChartSeriesTypesStackedSplineAreaSeriesAggregationMethod
    {
        public const string Avg = "avg";
        public const string Count = "count";
        public const string Max = "max";
        public const string Min = "min";
        public const string Sum = "sum";
        public const string Custom = "custom";
    }
    public partial class DxChartSeriesTypesStackedSplineAreaSeriesLabel : DxChartSeriesTypesCommonSeriesLabel
    {
        // couldn't parse customizeText
    }
    public partial class DxChartSeriesTypesStackedSplineAreaSeriesPoint : DxChartSeriesTypesCommonSeriesPoint
    {
        public bool? visible { get; set; }
    }
    public partial class DxChartSeriesTypesStackedSplineSeries : DxChartSeriesTypesCommonSeries
    {
        // couldn't parse aggregation
        public string hoverMode { get; set; }
        // couldn't parse label
        public string selectionMode { get; set; }
    }

    public static class DxChartSeriesTypesStackedSplineSeriesHoverMode
    {
        public const string NearestPoint = "nearestPoint";
        public const string IncludePoints = "includePoints";
        public const string ExcludePoints = "excludePoints";
        public const string None = "none";
    }
    public static class DxChartSeriesTypesStackedSplineSeriesSelectionMode
    {
        public const string IncludePoints = "includePoints";
        public const string ExcludePoints = "excludePoints";
        public const string None = "none";
    }
    public partial class DxChartSeriesTypesStackedSplineSeriesAggregation : DxChartSeriesTypesCommonSeriesAggregation
    {
        public string method { get; set; }
    }

    public static class DxChartSeriesTypesStackedSplineSeriesAggregationMethod
    {
        public const string Avg = "avg";
        public const string Count = "count";
        public const string Max = "max";
        public const string Min = "min";
        public const string Sum = "sum";
        public const string Custom = "custom";
    }
    public partial class DxChartSeriesTypesStackedSplineSeriesLabel : DxChartSeriesTypesCommonSeriesLabel
    {
        // couldn't parse customizeText
    }
    public partial class DxChartSeriesTypesStepAreaSeries : DxChartSeriesTypesCommonSeries
    {
        // couldn't parse aggregation
        // couldn't parse border
        public string hoverMode { get; set; }
        // couldn't parse hoverStyle
        // couldn't parse label
        // couldn't parse point
        public string selectionMode { get; set; }
        // couldn't parse selectionStyle
    }

    public static class DxChartSeriesTypesStepAreaSeriesHoverMode
    {
        public const string NearestPoint = "nearestPoint";
        public const string IncludePoints = "includePoints";
        public const string ExcludePoints = "excludePoints";
        public const string None = "none";
    }
    public static class DxChartSeriesTypesStepAreaSeriesSelectionMode
    {
        public const string IncludePoints = "includePoints";
        public const string ExcludePoints = "excludePoints";
        public const string None = "none";
    }
    public partial class DxChartSeriesTypesStepAreaSeriesAggregation : DxChartSeriesTypesCommonSeriesAggregation
    {
        public string method { get; set; }
    }

    public static class DxChartSeriesTypesStepAreaSeriesAggregationMethod
    {
        public const string Avg = "avg";
        public const string Count = "count";
        public const string Max = "max";
        public const string Min = "min";
        public const string Sum = "sum";
        public const string Custom = "custom";
    }
    public partial class DxChartSeriesTypesStepAreaSeriesBorder : DxChartSeriesTypesCommonSeriesBorder
    {
        public bool? visible { get; set; }
    }
    public partial class DxChartSeriesTypesStepAreaSeriesHoverStyle : DxChartSeriesTypesCommonSeriesHoverStyle
    {
        // couldn't parse border
    }
    public partial class DxChartSeriesTypesStepAreaSeriesHoverStyleBorder : DxChartSeriesTypesCommonSeriesHoverStyleBorder
    {
        public bool? visible { get; set; }
    }
    public partial class DxChartSeriesTypesStepAreaSeriesLabel : DxChartSeriesTypesCommonSeriesLabel
    {
        // couldn't parse customizeText
    }
    public partial class DxChartSeriesTypesStepAreaSeriesPoint : DxChartSeriesTypesCommonSeriesPoint
    {
        public bool? visible { get; set; }
    }
    public partial class DxChartSeriesTypesStepAreaSeriesSelectionStyle : DxChartSeriesTypesCommonSeriesSelectionStyle
    {
        // couldn't parse border
    }
    public partial class DxChartSeriesTypesStepAreaSeriesSelectionStyleBorder : DxChartSeriesTypesCommonSeriesSelectionStyleBorder
    {
        public bool? visible { get; set; }
    }
    public partial class DxChartSeriesTypesStepLineSeries : DxChartSeriesTypesCommonSeries
    {
        // couldn't parse aggregation
        public string hoverMode { get; set; }
        // couldn't parse label
        public string selectionMode { get; set; }
    }

    public static class DxChartSeriesTypesStepLineSeriesHoverMode
    {
        public const string NearestPoint = "nearestPoint";
        public const string IncludePoints = "includePoints";
        public const string ExcludePoints = "excludePoints";
        public const string None = "none";
    }
    public static class DxChartSeriesTypesStepLineSeriesSelectionMode
    {
        public const string IncludePoints = "includePoints";
        public const string ExcludePoints = "excludePoints";
        public const string None = "none";
    }
    public partial class DxChartSeriesTypesStepLineSeriesAggregation : DxChartSeriesTypesCommonSeriesAggregation
    {
        public string method { get; set; }
    }

    public static class DxChartSeriesTypesStepLineSeriesAggregationMethod
    {
        public const string Avg = "avg";
        public const string Count = "count";
        public const string Max = "max";
        public const string Min = "min";
        public const string Sum = "sum";
        public const string Custom = "custom";
    }
    public partial class DxChartSeriesTypesStepLineSeriesLabel : DxChartSeriesTypesCommonSeriesLabel
    {
        // couldn't parse customizeText
    }
    public partial class DxChartSeriesTypesStockSeries : DxChartSeriesTypesCommonSeries
    {
        // couldn't parse aggregation
        public string argumentField { get; set; }
        public string hoverMode { get; set; }
        // couldn't parse label
        public string selectionMode { get; set; }
    }

    public static class DxChartSeriesTypesStockSeriesHoverMode
    {
        public const string OnlyPoint = "onlyPoint";
        public const string AllSeriesPoints = "allSeriesPoints";
        public const string AllArgumentPoints = "allArgumentPoints";
        public const string None = "none";
    }
    public static class DxChartSeriesTypesStockSeriesSelectionMode
    {
        public const string OnlyPoint = "onlyPoint";
        public const string AllSeriesPoints = "allSeriesPoints";
        public const string AllArgumentPoints = "allArgumentPoints";
        public const string None = "none";
    }
    public partial class DxChartSeriesTypesStockSeriesAggregation : DxChartSeriesTypesCommonSeriesAggregation
    {
        public string method { get; set; }
    }

    public static class DxChartSeriesTypesStockSeriesAggregationMethod
    {
        public const string Ohlc = "ohlc";
        public const string Custom = "custom";
    }
    public partial class DxChartSeriesTypesStockSeriesLabel : DxChartSeriesTypesCommonSeriesLabel
    {
        // couldn't parse customizeText
    }
    public partial class DxExporterOptions : ComponentOptions
    {
        // couldn't parse exportFormat
        public string fileName { get; set; }
        public bool? printingEnabled { get; set; }
        public string serverUrl { get; set; }
        public bool? showMenu { get; set; }
        public string sourceContainer { get; set; }
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
        // couldn't parse palette
        public string secondColor { get; set; }
        public float? secondFraction { get; set; }
        public float? size { get; set; }
        public float? spindleGapSize { get; set; }
        public float? spindleSize { get; set; }
        // couldn't parse text
        public string verticalOrientation { get; set; }
        public float? width { get; set; }
    }

    public static class CommonIndicatorHorizontalOrientation
    {
        public const string Left = "left";
        public const string Right = "right";
    }
    public static class CommonIndicatorVerticalOrientation
    {
        public const string Bottom = "bottom";
        public const string Top = "top";
    }
    public partial class CommonIndicatorText
    {
        // couldn't parse customizeText
        // couldn't parse font
        // couldn't parse format
        public float? indent { get; set; }
        public float? precision { get; set; }
    }
    public partial class CircularRectangleNeedle : CommonIndicator
    {
        public string color { get; set; }
    }
    public partial class CircularTriangleNeedle : CommonIndicator
    {
        public string color { get; set; }
    }
    public partial class CircularTwoColorNeedle : CommonIndicator
    {
        public string color { get; set; }
    }
    public partial class CircularRangeBar : CommonIndicator
    {
        public string color { get; set; }
        public float? offset { get; set; }
    }
    public partial class CircularTriangleMarker : CommonIndicator
    {
        public string color { get; set; }
        public float? length { get; set; }
        public float? offset { get; set; }
        public float? width { get; set; }
    }
    public partial class CircularTextCloud : CommonIndicator
    {
        public string color { get; set; }
        public float? offset { get; set; }
        // couldn't parse text
    }
    public partial class CircularTextCloudText : CommonIndicatorText
    {
        // couldn't parse font
    }
    public partial class LinearRectangle : CommonIndicator
    {
        public string color { get; set; }
        public float? offset { get; set; }
        public float? width { get; set; }
    }
    public partial class LinearCircle : CommonIndicator
    {
        public string color { get; set; }
        public float? offset { get; set; }
    }
    public partial class LinearRhombus : CommonIndicator
    {
        public string color { get; set; }
        public float? offset { get; set; }
        public float? width { get; set; }
    }
    public partial class LinearRangeBar : CommonIndicator
    {
        public string color { get; set; }
        public float? offset { get; set; }
    }
    public partial class LinearTriangleMarker : CommonIndicator
    {
        public string color { get; set; }
        public float? length { get; set; }
        public float? offset { get; set; }
        public float? width { get; set; }
    }
    public partial class LinearTextCloud : CommonIndicator
    {
        public string color { get; set; }
        public float? offset { get; set; }
        // couldn't parse text
    }
    public partial class LinearTextCloudText : CommonIndicatorText
    {
        // couldn't parse font
    }
    public partial class ChartPointAggregationInfoObject
    {
        public object aggregationInterval { get; set; }
        // couldn't parse data
        public object intervalEnd { get; set; }
        public object intervalStart { get; set; }
    }
    public partial class DxPieChartSeriesTypes
    {
        // couldn't parse CommonPieChartSeries
        public object DoughnutSeries { get; set; }
        public object PieSeries { get; set; }
    }
    public partial class DxPieChartSeriesTypesCommonPieChartSeries
    {
        public string argumentField { get; set; }
        public string argumentType { get; set; }
        // couldn't parse border
        public string color { get; set; }
        public string hoverMode { get; set; }
        // couldn't parse hoverStyle
        public float? innerRadius { get; set; }
        // couldn't parse label
        public float? maxLabelCount { get; set; }
        public float? minSegmentSize { get; set; }
        public string segmentsDirection { get; set; }
        public string selectionMode { get; set; }
        // couldn't parse selectionStyle
        // couldn't parse smallValuesGrouping
        public float? startAngle { get; set; }
        public string tagField { get; set; }
        public string valueField { get; set; }
    }

    public static class DxPieChartSeriesTypesCommonPieChartSeriesArgumentType
    {
        public const string Datetime = "datetime";
        public const string Numeric = "numeric";
        public const string String = "string";
    }
    public static class DxPieChartSeriesTypesCommonPieChartSeriesHoverMode
    {
        public const string None = "none";
        public const string OnlyPoint = "onlyPoint";
    }
    public static class DxPieChartSeriesTypesCommonPieChartSeriesSegmentsDirection
    {
        public const string Anticlockwise = "anticlockwise";
        public const string Clockwise = "clockwise";
    }
    public static class DxPieChartSeriesTypesCommonPieChartSeriesSelectionMode
    {
        public const string None = "none";
        public const string OnlyPoint = "onlyPoint";
    }
    public partial class DxPolarChartSeriesTypes
    {
        // couldn't parse areapolarseries
        // couldn't parse barpolarseries
        // couldn't parse CommonPolarChartSeries
        // couldn't parse linepolarseries
        public object scatterpolarseries { get; set; }
        // couldn't parse stackedbarpolarseries
    }
    public partial class DxPolarChartSeriesTypesAreapolarseries : DxPolarChartSeriesTypesCommonPolarChartSeries
    {
        public string hoverMode { get; set; }
        // couldn't parse point
        public string selectionMode { get; set; }
    }

    public static class DxPolarChartSeriesTypesAreapolarseriesHoverMode
    {
        public const string NearestPoint = "nearestPoint";
        public const string IncludePoints = "includePoints";
        public const string ExcludePoints = "excludePoints";
        public const string None = "none";
    }
    public static class DxPolarChartSeriesTypesAreapolarseriesSelectionMode
    {
        public const string IncludePoints = "includePoints";
        public const string ExcludePoints = "excludePoints";
        public const string None = "none";
    }
    public partial class DxPolarChartSeriesTypesAreapolarseriesPoint : DxPolarChartSeriesTypesCommonPolarChartSeriesPoint
    {
        public bool? visible { get; set; }
    }
    public partial class DxPolarChartSeriesTypesBarpolarseries : DxPolarChartSeriesTypesCommonPolarChartSeries
    {
        public string hoverMode { get; set; }
        public string selectionMode { get; set; }
    }

    public static class DxPolarChartSeriesTypesBarpolarseriesHoverMode
    {
        public const string OnlyPoint = "onlyPoint";
        public const string AllSeriesPoints = "allSeriesPoints";
        public const string AllArgumentPoints = "allArgumentPoints";
        public const string None = "none";
    }
    public static class DxPolarChartSeriesTypesBarpolarseriesSelectionMode
    {
        public const string OnlyPoint = "onlyPoint";
        public const string AllSeriesPoints = "allSeriesPoints";
        public const string AllArgumentPoints = "allArgumentPoints";
        public const string None = "none";
    }
    public partial class DxPolarChartSeriesTypesCommonPolarChartSeries
    {
        public string argumentField { get; set; }
        public float? barPadding { get; set; }
        public float? barWidth { get; set; }
        // couldn't parse border
        public bool? closed { get; set; }
        public string color { get; set; }
        public string dashStyle { get; set; }
        public string hoverMode { get; set; }
        // couldn't parse hoverStyle
        public bool? ignoreEmptyPoints { get; set; }
        // couldn't parse label
        public float? maxLabelCount { get; set; }
        public float? minBarSize { get; set; }
        public float? opacity { get; set; }
        // couldn't parse point
        public string selectionMode { get; set; }
        // couldn't parse selectionStyle
        public bool? showInLegend { get; set; }
        public string stack { get; set; }
        public string tagField { get; set; }
        // couldn't parse valueErrorBar
        public string valueField { get; set; }
        public bool? visible { get; set; }
        public float? width { get; set; }
    }

    public static class DxPolarChartSeriesTypesCommonPolarChartSeriesDashStyle
    {
        public const string Dash = "dash";
        public const string Dot = "dot";
        public const string LongDash = "longDash";
        public const string Solid = "solid";
    }
    public static class DxPolarChartSeriesTypesCommonPolarChartSeriesHoverMode
    {
        public const string AllArgumentPoints = "allArgumentPoints";
        public const string AllSeriesPoints = "allSeriesPoints";
        public const string ExcludePoints = "excludePoints";
        public const string IncludePoints = "includePoints";
        public const string NearestPoint = "nearestPoint";
        public const string None = "none";
        public const string OnlyPoint = "onlyPoint";
    }
    public static class DxPolarChartSeriesTypesCommonPolarChartSeriesSelectionMode
    {
        public const string AllArgumentPoints = "allArgumentPoints";
        public const string AllSeriesPoints = "allSeriesPoints";
        public const string ExcludePoints = "excludePoints";
        public const string IncludePoints = "includePoints";
        public const string None = "none";
        public const string OnlyPoint = "onlyPoint";
    }
    public partial class DxPolarChartSeriesTypesCommonPolarChartSeriesLabel
    {
        // couldn't parse argumentFormat
        public float? argumentPrecision { get; set; }
        public string backgroundColor { get; set; }
        // couldn't parse border
        // couldn't parse connector
        // couldn't parse customizeText
        // couldn't parse font
        // couldn't parse format
        public string position { get; set; }
        public float? precision { get; set; }
        public float? rotationAngle { get; set; }
        public bool? showForZeroValues { get; set; }
        public bool? visible { get; set; }
    }

    public static class DxPolarChartSeriesTypesCommonPolarChartSeriesLabelPosition
    {
        public const string Inside = "inside";
        public const string Outside = "outside";
    }
    public partial class DxPolarChartSeriesTypesCommonPolarChartSeriesPoint
    {
        // couldn't parse border
        public string color { get; set; }
        public string hoverMode { get; set; }
        // couldn't parse hoverStyle
        // couldn't parse image
        public string selectionMode { get; set; }
        // couldn't parse selectionStyle
        public float? size { get; set; }
        public string symbol { get; set; }
        public bool? visible { get; set; }
    }

    public static class DxPolarChartSeriesTypesCommonPolarChartSeriesPointHoverMode
    {
        public const string AllArgumentPoints = "allArgumentPoints";
        public const string AllSeriesPoints = "allSeriesPoints";
        public const string None = "none";
        public const string OnlyPoint = "onlyPoint";
    }
    public static class DxPolarChartSeriesTypesCommonPolarChartSeriesPointSelectionMode
    {
        public const string AllArgumentPoints = "allArgumentPoints";
        public const string AllSeriesPoints = "allSeriesPoints";
        public const string None = "none";
        public const string OnlyPoint = "onlyPoint";
    }
    public static class DxPolarChartSeriesTypesCommonPolarChartSeriesPointSymbol
    {
        public const string Circle = "circle";
        public const string Cross = "cross";
        public const string Polygon = "polygon";
        public const string Square = "square";
        public const string Triangle = "triangle";
    }
    public partial class DxPolarChartSeriesTypesLinepolarseries : DxPolarChartSeriesTypesCommonPolarChartSeries
    {
        public string hoverMode { get; set; }
        public string selectionMode { get; set; }
    }

    public static class DxPolarChartSeriesTypesLinepolarseriesHoverMode
    {
        public const string NearestPoint = "nearestPoint";
        public const string IncludePoints = "includePoints";
        public const string ExcludePoints = "excludePoints";
        public const string None = "none";
    }
    public static class DxPolarChartSeriesTypesLinepolarseriesSelectionMode
    {
        public const string IncludePoints = "includePoints";
        public const string ExcludePoints = "excludePoints";
        public const string None = "none";
    }
    public partial class DxPolarChartSeriesTypesStackedbarpolarseries : DxPolarChartSeriesTypesCommonPolarChartSeries
    {
        public string hoverMode { get; set; }
        // couldn't parse label
        public string selectionMode { get; set; }
    }

    public static class DxPolarChartSeriesTypesStackedbarpolarseriesHoverMode
    {
        public const string OnlyPoint = "onlyPoint";
        public const string AllSeriesPoints = "allSeriesPoints";
        public const string AllArgumentPoints = "allArgumentPoints";
        public const string None = "none";
    }
    public static class DxPolarChartSeriesTypesStackedbarpolarseriesSelectionMode
    {
        public const string OnlyPoint = "onlyPoint";
        public const string AllSeriesPoints = "allSeriesPoints";
        public const string AllArgumentPoints = "allArgumentPoints";
        public const string None = "none";
    }
    public partial class DxPolarChartSeriesTypesStackedbarpolarseriesLabel : DxPolarChartSeriesTypesCommonPolarChartSeriesLabel
    {
        public string position { get; set; }
    }

    public static class DxPolarChartSeriesTypesStackedbarpolarseriesLabelPosition
    {
        public const string Inside = "inside";
        public const string Outside = "outside";
    }
    public partial class Font
    {
        public string color { get; set; }
        public string family { get; set; }
        public float? opacity { get; set; }
        // couldn't parse size
        public float? weight { get; set; }
    }
}
namespace DevExpress.Viz.Charts
{
    public partial class DxChartOptions : BaseChartOptions
    {
        public bool? adjustOnZoom { get; set; }
        // couldn't parse argumentAxis
        public float? barGroupPadding { get; set; }
        public float? barGroupWidth { get; set; }
        public float? barWidth { get; set; }
        // couldn't parse commonAxisSettings
        // couldn't parse commonPaneSettings
        // couldn't parse commonSeriesSettings
        public string containerBackgroundColor { get; set; }
        // couldn't parse crosshair
        // couldn't parse dataPrepareSettings
        public string defaultPane { get; set; }
        public bool? equalBarWidth { get; set; }
        // couldn't parse legend
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
        // couldn't parse panes
        public string resolveLabelOverlapping { get; set; }
        public bool? rotated { get; set; }
        // couldn't parse scrollBar
        public string scrollingMode { get; set; }
        // couldn't parse series
        public string seriesSelectionMode { get; set; }
        // couldn't parse seriesTemplate
        public bool? synchronizeMultiAxes { get; set; }
        // couldn't parse tooltip
        public bool? useAggregation { get; set; }
        // couldn't parse valueAxis
        public string zoomingMode { get; set; }
    }

    public static class DxChartOptionsResolveLabelOverlapping
    {
        public const string Hide = "hide";
        public const string None = "none";
        public const string Stack = "stack";
    }
    public static class DxChartOptionsScrollingMode
    {
        public const string All = "all";
        public const string Mouse = "mouse";
        public const string None = "none";
        public const string Touch = "touch";
    }
    public static class DxChartOptionsSeriesSelectionMode
    {
        public const string Multiple = "multiple";
        public const string Single = "single";
    }
    public static class DxChartOptionsZoomingMode
    {
        public const string All = "all";
        public const string Mouse = "mouse";
        public const string None = "none";
        public const string Touch = "touch";
    }
    public partial class DxChartArgumentAxis : DxChartCommonAxisSettings
    {
        public float? aggregationGroupWidth { get; set; }
        public object aggregationInterval { get; set; }
        public string argumentType { get; set; }
        public float? axisDivisionFactor { get; set; }
        // couldn't parse breaks
        // couldn't parse categories
        // couldn't parse constantLines
        // couldn't parse constantLineStyle
        public bool? endOnTick { get; set; }
        // couldn't parse holidays
        public string hoverMode { get; set; }
        // couldn't parse label
        public float? logarithmBase { get; set; }
        // couldn't parse max
        // couldn't parse min
        public float? minorTickCount { get; set; }
        public object minorTickInterval { get; set; }
        public string position { get; set; }
        // couldn't parse singleWorkdays
        // couldn't parse strips
        public object tickInterval { get; set; }
        // couldn't parse title
        public string type { get; set; }
        public bool? workdaysOnly { get; set; }
        public float workWeek { get; set; }
    }

    public static class DxChartArgumentAxisArgumentType
    {
        public const string Datetime = "datetime";
        public const string Numeric = "numeric";
        public const string String = "string";
    }
    public static class DxChartArgumentAxisHoverMode
    {
        public const string AllArgumentPoints = "allArgumentPoints";
        public const string None = "none";
    }
    public static class DxChartArgumentAxisPosition
    {
        public const string Bottom = "bottom";
        public const string Left = "left";
        public const string Right = "right";
        public const string Top = "top";
    }
    public static class DxChartArgumentAxisType
    {
        public const string Continuous = "continuous";
        public const string Discrete = "discrete";
        public const string Logarithmic = "logarithmic";
    }
    public partial class DxChartArgumentAxisConstantLines : DxChartCommonAxisSettingsConstantLineStyle
    {
        // couldn't parse label
        // couldn't parse value
    }
    public partial class DxChartArgumentAxisConstantLinesLabel : DxChartCommonAxisSettingsConstantLineStyleLabel
    {
        public string horizontalAlignment { get; set; }
        public string text { get; set; }
        public string verticalAlignment { get; set; }
    }

    public static class DxChartArgumentAxisConstantLinesLabelHorizontalAlignment
    {
        public const string Center = "center";
        public const string Left = "left";
        public const string Right = "right";
    }
    public static class DxChartArgumentAxisConstantLinesLabelVerticalAlignment
    {
        public const string Bottom = "bottom";
        public const string Center = "center";
        public const string Top = "top";
    }
    public partial class DxChartArgumentAxisConstantLineStyle : DxChartCommonAxisSettingsConstantLineStyle
    {
        // couldn't parse label
    }
    public partial class DxChartArgumentAxisConstantLineStyleLabel : DxChartCommonAxisSettingsConstantLineStyleLabel
    {
        public string horizontalAlignment { get; set; }
        public string verticalAlignment { get; set; }
    }

    public static class DxChartArgumentAxisConstantLineStyleLabelHorizontalAlignment
    {
        public const string Center = "center";
        public const string Left = "left";
        public const string Right = "right";
    }
    public static class DxChartArgumentAxisConstantLineStyleLabelVerticalAlignment
    {
        public const string Bottom = "bottom";
        public const string Center = "center";
        public const string Top = "top";
    }
    public partial class DxChartArgumentAxisLabel : DxChartCommonAxisSettingsLabel
    {
        // couldn't parse customizeHint
        // couldn't parse customizeText
        // couldn't parse format
        public float? precision { get; set; }
    }
    public partial class DxChartArgumentAxisStrips : DxChartCommonAxisSettingsStripStyle
    {
        public string color { get; set; }
        // couldn't parse endValue
        // couldn't parse label
        // couldn't parse startValue
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
        // couldn't parse breakStyle
        public string color { get; set; }
        // couldn't parse constantLineStyle
        public string discreteAxisDivisionMode { get; set; }
        public bool? endOnTick { get; set; }
        // couldn't parse grid
        public bool? inverted { get; set; }
        // couldn't parse label
        public float? maxValueMargin { get; set; }
        // couldn't parse minorGrid
        // couldn't parse minorTick
        public float? minValueMargin { get; set; }
        public float? opacity { get; set; }
        public float? placeholderSize { get; set; }
        public bool? setTicksAtUnitBeginning { get; set; }
        // couldn't parse stripStyle
        // couldn't parse tick
        // couldn't parse title
        public bool? valueMarginsEnabled { get; set; }
        public bool? visible { get; set; }
        public float? width { get; set; }
    }

    public static class DxChartCommonAxisSettingsDiscreteAxisDivisionMode
    {
        public const string BetweenLabels = "betweenLabels";
        public const string CrossLabels = "crossLabels";
    }
    public partial class DxChartCommonAxisSettingsConstantLineStyle
    {
        public string color { get; set; }
        public string dashStyle { get; set; }
        // couldn't parse label
        public float? paddingLeftRight { get; set; }
        public float? paddingTopBottom { get; set; }
        public float? width { get; set; }
    }

    public static class DxChartCommonAxisSettingsConstantLineStyleDashStyle
    {
        public const string Dash = "dash";
        public const string Dot = "dot";
        public const string LongDash = "longDash";
        public const string Solid = "solid";
    }
    public partial class DxChartCommonAxisSettingsConstantLineStyleLabel
    {
        // couldn't parse font
        public string position { get; set; }
        public bool? visible { get; set; }
    }

    public static class DxChartCommonAxisSettingsConstantLineStyleLabelPosition
    {
        public const string Inside = "inside";
        public const string Outside = "outside";
    }
    public partial class DxChartCommonAxisSettingsLabel
    {
        public string alignment { get; set; }
        public string displayMode { get; set; }
        // couldn't parse font
        public float? indentFromAxis { get; set; }
        // couldn't parse overlappingBehavior
        public float? rotationAngle { get; set; }
        public float? staggeringSpacing { get; set; }
        public bool? visible { get; set; }
    }

    public static class DxChartCommonAxisSettingsLabelAlignment
    {
        public const string Center = "center";
        public const string Left = "left";
        public const string Right = "right";
    }
    public static class DxChartCommonAxisSettingsLabelDisplayMode
    {
        public const string Rotate = "rotate";
        public const string Stagger = "stagger";
        public const string Standard = "standard";
    }
    public partial class DxChartCommonAxisSettingsStripStyle
    {
        // couldn't parse label
        public float? paddingLeftRight { get; set; }
        public float? paddingTopBottom { get; set; }
    }
    public partial class DxChartCommonAxisSettingsStripStyleLabel
    {
        // couldn't parse font
        public string horizontalAlignment { get; set; }
        public string verticalAlignment { get; set; }
    }

    public static class DxChartCommonAxisSettingsStripStyleLabelHorizontalAlignment
    {
        public const string Center = "center";
        public const string Left = "left";
        public const string Right = "right";
    }
    public static class DxChartCommonAxisSettingsStripStyleLabelVerticalAlignment
    {
        public const string Bottom = "bottom";
        public const string Center = "center";
        public const string Top = "top";
    }
    public partial class DxChartCommonAxisSettingsTitle
    {
        // couldn't parse font
        public float? margin { get; set; }
    }
    public partial class DxChartCommonPaneSettings
    {
        public string backgroundColor { get; set; }
        // couldn't parse border
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

    public static class DxChartCommonSeriesSettingsType
    {
        public const string Area = "area";
        public const string Bar = "bar";
        public const string Bubble = "bubble";
        public const string Candlestick = "candlestick";
        public const string Fullstackedarea = "fullstackedarea";
        public const string Fullstackedbar = "fullstackedbar";
        public const string Fullstackedline = "fullstackedline";
        public const string Fullstackedspline = "fullstackedspline";
        public const string Fullstackedsplinearea = "fullstackedsplinearea";
        public const string Line = "line";
        public const string Rangearea = "rangearea";
        public const string Rangebar = "rangebar";
        public const string Scatter = "scatter";
        public const string Spline = "spline";
        public const string Splinearea = "splinearea";
        public const string Stackedarea = "stackedarea";
        public const string Stackedbar = "stackedbar";
        public const string Stackedline = "stackedline";
        public const string Stackedspline = "stackedspline";
        public const string Stackedsplinearea = "stackedsplinearea";
        public const string Steparea = "steparea";
        public const string Stepline = "stepline";
        public const string Stock = "stock";
    }
    public partial class DxChartLegend : BaseChartLegend
    {
        // couldn't parse customizeHint
        // couldn't parse customizeText
        public string hoverMode { get; set; }
        public string position { get; set; }
    }

    public static class DxChartLegendHoverMode
    {
        public const string ExcludePoints = "excludePoints";
        public const string IncludePoints = "includePoints";
        public const string None = "none";
    }
    public static class DxChartLegendPosition
    {
        public const string Inside = "inside";
        public const string Outside = "outside";
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

    public static class DxChartSeriesType
    {
        public const string Area = "area";
        public const string Bar = "bar";
        public const string Bubble = "bubble";
        public const string Candlestick = "candlestick";
        public const string Fullstackedarea = "fullstackedarea";
        public const string Fullstackedbar = "fullstackedbar";
        public const string Fullstackedline = "fullstackedline";
        public const string Fullstackedspline = "fullstackedspline";
        public const string Fullstackedsplinearea = "fullstackedsplinearea";
        public const string Line = "line";
        public const string Rangearea = "rangearea";
        public const string Rangebar = "rangebar";
        public const string Scatter = "scatter";
        public const string Spline = "spline";
        public const string Splinearea = "splinearea";
        public const string Stackedarea = "stackedarea";
        public const string Stackedbar = "stackedbar";
        public const string Stackedline = "stackedline";
        public const string Stackedspline = "stackedspline";
        public const string Stackedsplinearea = "stackedsplinearea";
        public const string Steparea = "steparea";
        public const string Stepline = "stepline";
        public const string Stock = "stock";
    }
    public partial class DxChartTooltip : BaseChartTooltip
    {
        public string location { get; set; }
        public bool? shared { get; set; }
    }

    public static class DxChartTooltipLocation
    {
        public const string Center = "center";
        public const string Edge = "edge";
    }
    public partial class DxChartValueAxis : DxChartCommonAxisSettings
    {
        public bool? autoBreaksEnabled { get; set; }
        public float? axisDivisionFactor { get; set; }
        // couldn't parse breaks
        // couldn't parse categories
        // couldn't parse constantLines
        // couldn't parse constantLineStyle
        public bool? endOnTick { get; set; }
        // couldn't parse label
        public float? logarithmBase { get; set; }
        // couldn't parse max
        public float? maxAutoBreakCount { get; set; }
        // couldn't parse min
        public float? minorTickCount { get; set; }
        public object minorTickInterval { get; set; }
        public float? multipleAxesSpacing { get; set; }
        public string name { get; set; }
        public string pane { get; set; }
        public string position { get; set; }
        public bool? showZero { get; set; }
        // couldn't parse strips
        public float? synchronizedValue { get; set; }
        public object tickInterval { get; set; }
        // couldn't parse title
        public string type { get; set; }
        public string valueType { get; set; }
    }

    public static class DxChartValueAxisPosition
    {
        public const string Bottom = "bottom";
        public const string Left = "left";
        public const string Right = "right";
        public const string Top = "top";
    }
    public static class DxChartValueAxisType
    {
        public const string Continuous = "continuous";
        public const string Discrete = "discrete";
        public const string Logarithmic = "logarithmic";
    }
    public static class DxChartValueAxisValueType
    {
        public const string Datetime = "datetime";
        public const string Numeric = "numeric";
        public const string String = "string";
    }
    public partial class DxChartValueAxisConstantLines : DxChartCommonAxisSettingsConstantLineStyle
    {
        // couldn't parse label
        // couldn't parse value
    }
    public partial class DxChartValueAxisConstantLinesLabel : DxChartCommonAxisSettingsConstantLineStyleLabel
    {
        public string horizontalAlignment { get; set; }
        public string text { get; set; }
        public string verticalAlignment { get; set; }
    }

    public static class DxChartValueAxisConstantLinesLabelHorizontalAlignment
    {
        public const string Center = "center";
        public const string Left = "left";
        public const string Right = "right";
    }
    public static class DxChartValueAxisConstantLinesLabelVerticalAlignment
    {
        public const string Bottom = "bottom";
        public const string Center = "center";
        public const string Top = "top";
    }
    public partial class DxChartValueAxisConstantLineStyle : DxChartCommonAxisSettingsConstantLineStyle
    {
        // couldn't parse label
    }
    public partial class DxChartValueAxisConstantLineStyleLabel : DxChartCommonAxisSettingsConstantLineStyleLabel
    {
        public string horizontalAlignment { get; set; }
        public string verticalAlignment { get; set; }
    }

    public static class DxChartValueAxisConstantLineStyleLabelHorizontalAlignment
    {
        public const string Center = "center";
        public const string Left = "left";
        public const string Right = "right";
    }
    public static class DxChartValueAxisConstantLineStyleLabelVerticalAlignment
    {
        public const string Bottom = "bottom";
        public const string Center = "center";
        public const string Top = "top";
    }
    public partial class DxChartValueAxisLabel : DxChartCommonAxisSettingsLabel
    {
        // couldn't parse customizeHint
        // couldn't parse customizeText
        // couldn't parse format
        public float? precision { get; set; }
    }
    public partial class DxChartValueAxisStrips : DxChartCommonAxisSettingsStripStyle
    {
        public string color { get; set; }
        // couldn't parse endValue
        // couldn't parse label
        // couldn't parse startValue
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
        // couldn't parse adaptiveLayout
        // couldn't parse commonSeriesSettings
        public float? diameter { get; set; }
        public float? innerRadius { get; set; }
        // couldn't parse legend
        public float? minDiameter { get; set; }
        public bool? onLegendClickEnabled { get; set; }
        // couldn't parse palette
        public string resolveLabelOverlapping { get; set; }
        public string segmentsDirection { get; set; }
        // couldn't parse series
        // couldn't parse seriesTemplate
        public string sizeGroup { get; set; }
        public float? startAngle { get; set; }
        public string type { get; set; }
    }

    public static class DxPieChartOptionsResolveLabelOverlapping
    {
        public const string Hide = "hide";
        public const string None = "none";
        public const string Shift = "shift";
    }
    public static class DxPieChartOptionsSegmentsDirection
    {
        public const string Anticlockwise = "anticlockwise";
        public const string Clockwise = "clockwise";
    }
    public static class DxPieChartOptionsType
    {
        public const string Donut = "donut";
        public const string Doughnut = "doughnut";
        public const string Pie = "pie";
    }
    public partial class DxPieChartAdaptiveLayout : BaseChartAdaptiveLayout
    {
        public bool? keepLabels { get; set; }
    }
    public partial class DxPieChartCommonSeriesSettings : DxPieChartSeriesTypesCommonPieChartSeries
    {
        public string type { get; set; }
    }

    public static class DxPieChartCommonSeriesSettingsType
    {
        public const string Donut = "donut";
        public const string Doughnut = "doughnut";
        public const string Pie = "pie";
    }
    public partial class DxPieChartLegend : BaseChartLegend
    {
        // couldn't parse customizeHint
        // couldn't parse customizeText
        public string hoverMode { get; set; }
    }

    public static class DxPieChartLegendHoverMode
    {
        public const string None = "none";
        public const string AllArgumentPoints = "allArgumentPoints";
    }
    public partial class DxPieChartSeries : DxPieChartSeriesTypesCommonPieChartSeries
    {
        public string name { get; set; }
        public object tag { get; set; }
        public string type { get; set; }
    }

    public static class DxPieChartSeriesType
    {
        public const string Donut = "donut";
        public const string Doughnut = "doughnut";
        public const string Pie = "pie";
    }
    public partial class DxPolarChartOptions : BaseChartOptions
    {
        // couldn't parse adaptiveLayout
        // couldn't parse argumentAxis
        public float? barGroupPadding { get; set; }
        public float? barGroupWidth { get; set; }
        public float? barWidth { get; set; }
        // couldn't parse commonAxisSettings
        // couldn't parse commonSeriesSettings
        public string containerBackgroundColor { get; set; }
        // couldn't parse dataPrepareSettings
        public bool? equalBarWidth { get; set; }
        // couldn't parse legend
        public bool? negativesAsZeroes { get; set; }
        public bool? onArgumentAxisClickEnabled { get; set; }
        public bool? onLegendClickEnabled { get; set; }
        public bool? onSeriesClickEnabled { get; set; }
        public bool? onSeriesHoverChangedEnabled { get; set; }
        public bool? onSeriesSelectionChangedEnabled { get; set; }
        public string resolveLabelOverlapping { get; set; }
        // couldn't parse series
        public string seriesSelectionMode { get; set; }
        // couldn't parse seriesTemplate
        // couldn't parse tooltip
        public bool? useSpiderWeb { get; set; }
        // couldn't parse valueAxis
    }

    public static class DxPolarChartOptionsResolveLabelOverlapping
    {
        public const string Hide = "hide";
        public const string None = "none";
    }
    public static class DxPolarChartOptionsSeriesSelectionMode
    {
        public const string Multiple = "multiple";
        public const string Single = "single";
    }
    public partial class DxPolarChartAdaptiveLayout : BaseChartAdaptiveLayout
    {
        public float? height { get; set; }
        public float? width { get; set; }
    }
    public partial class DxPolarChartArgumentAxis : DxPolarChartCommonAxisSettings
    {
        public string argumentType { get; set; }
        public float? axisDivisionFactor { get; set; }
        // couldn't parse categories
        // couldn't parse constantLines
        public bool? firstPointOnStartAngle { get; set; }
        public string hoverMode { get; set; }
        // couldn't parse label
        public float? logarithmBase { get; set; }
        public float? minorTickCount { get; set; }
        public object minorTickInterval { get; set; }
        public float? originValue { get; set; }
        public float? period { get; set; }
        public float? startAngle { get; set; }
        // couldn't parse strips
        public object tickInterval { get; set; }
        public string type { get; set; }
    }

    public static class DxPolarChartArgumentAxisArgumentType
    {
        public const string Datetime = "datetime";
        public const string Numeric = "numeric";
        public const string String = "string";
    }
    public static class DxPolarChartArgumentAxisHoverMode
    {
        public const string AllArgumentPoints = "allArgumentPoints";
        public const string None = "none";
    }
    public static class DxPolarChartArgumentAxisType
    {
        public const string Continuous = "continuous";
        public const string Discrete = "discrete";
        public const string Logarithmic = "logarithmic";
    }
    public partial class DxPolarChartArgumentAxisConstantLines : DxPolarChartCommonAxisSettingsConstantLineStyle
    {
        // couldn't parse label
        // couldn't parse value
    }
    public partial class DxPolarChartArgumentAxisConstantLinesLabel : DxPolarChartCommonAxisSettingsConstantLineStyleLabel
    {
        public string text { get; set; }
    }
    public partial class DxPolarChartArgumentAxisLabel : DxPolarChartCommonAxisSettingsLabel
    {
        // couldn't parse customizeHint
        // couldn't parse customizeText
        // couldn't parse format
        public float? precision { get; set; }
    }
    public partial class DxPolarChartArgumentAxisStrips : DxPolarChartCommonAxisSettingsStripStyle
    {
        public string color { get; set; }
        // couldn't parse endValue
        // couldn't parse label
        // couldn't parse startValue
    }
    public partial class DxPolarChartArgumentAxisStripsLabel : DxPolarChartCommonAxisSettingsStripStyleLabel
    {
        public string text { get; set; }
    }
    public partial class DxPolarChartCommonAxisSettings
    {
        public bool? allowDecimals { get; set; }
        public string color { get; set; }
        // couldn't parse constantLineStyle
        public string discreteAxisDivisionMode { get; set; }
        public bool? endOnTick { get; set; }
        // couldn't parse grid
        public bool? inverted { get; set; }
        // couldn't parse label
        // couldn't parse minorGrid
        // couldn't parse minorTick
        public float? opacity { get; set; }
        public bool? setTicksAtUnitBeginning { get; set; }
        // couldn't parse stripStyle
        // couldn't parse tick
        public bool? visible { get; set; }
        public float? width { get; set; }
    }

    public static class DxPolarChartCommonAxisSettingsDiscreteAxisDivisionMode
    {
        public const string BetweenLabels = "betweenLabels";
        public const string CrossLabels = "crossLabels";
    }
    public partial class DxPolarChartCommonAxisSettingsConstantLineStyle
    {
        public string color { get; set; }
        public string dashStyle { get; set; }
        // couldn't parse label
        public float? width { get; set; }
    }

    public static class DxPolarChartCommonAxisSettingsConstantLineStyleDashStyle
    {
        public const string Dash = "dash";
        public const string Dot = "dot";
        public const string LongDash = "longDash";
        public const string Solid = "solid";
    }
    public partial class DxPolarChartCommonAxisSettingsConstantLineStyleLabel
    {
        // couldn't parse font
        public bool? visible { get; set; }
    }
    public partial class DxPolarChartCommonAxisSettingsLabel
    {
        // couldn't parse font
        public float? indentFromAxis { get; set; }
        public string overlappingBehavior { get; set; }
        public bool? visible { get; set; }
    }

    public static class DxPolarChartCommonAxisSettingsLabelOverlappingBehavior
    {
        public const string Hide = "hide";
        public const string None = "none";
    }
    public partial class DxPolarChartCommonAxisSettingsStripStyle
    {
        // couldn't parse label
    }
    public partial class DxPolarChartCommonAxisSettingsStripStyleLabel
    {
        // couldn't parse font
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

    public static class DxPolarChartCommonSeriesSettingsType
    {
        public const string Area = "area";
        public const string Bar = "bar";
        public const string Line = "line";
        public const string Scatter = "scatter";
        public const string Stackedbar = "stackedbar";
    }
    public partial class DxPolarChartLegend : BaseChartLegend
    {
        // couldn't parse customizeHint
        // couldn't parse customizeText
        public string hoverMode { get; set; }
    }

    public static class DxPolarChartLegendHoverMode
    {
        public const string ExcludePoints = "excludePoints";
        public const string IncludePoints = "includePoints";
        public const string None = "none";
    }
    public partial class DxPolarChartSeries : DxPolarChartSeriesTypesCommonPolarChartSeries
    {
        public string name { get; set; }
        public object tag { get; set; }
        public string type { get; set; }
    }

    public static class DxPolarChartSeriesType
    {
        public const string Area = "area";
        public const string Bar = "bar";
        public const string Line = "line";
        public const string Scatter = "scatter";
        public const string Stackedbar = "stackedbar";
    }
    public partial class DxPolarChartTooltip : BaseChartTooltip
    {
        public bool? shared { get; set; }
    }
    public partial class DxPolarChartValueAxis : DxPolarChartCommonAxisSettings
    {
        public float? axisDivisionFactor { get; set; }
        // couldn't parse categories
        // couldn't parse constantLines
        public bool? endOnTick { get; set; }
        // couldn't parse label
        public float? logarithmBase { get; set; }
        public float? maxValueMargin { get; set; }
        public float? minorTickCount { get; set; }
        public object minorTickInterval { get; set; }
        public float? minValueMargin { get; set; }
        public bool? showZero { get; set; }
        // couldn't parse strips
        // couldn't parse tick
        public object tickInterval { get; set; }
        public string type { get; set; }
        public bool? valueMarginsEnabled { get; set; }
        public string valueType { get; set; }
    }

    public static class DxPolarChartValueAxisType
    {
        public const string Continuous = "continuous";
        public const string Discrete = "discrete";
        public const string Logarithmic = "logarithmic";
    }
    public static class DxPolarChartValueAxisValueType
    {
        public const string Datetime = "datetime";
        public const string Numeric = "numeric";
        public const string String = "string";
    }
    public partial class DxPolarChartValueAxisConstantLines : DxPolarChartCommonAxisSettingsConstantLineStyle
    {
        // couldn't parse label
        // couldn't parse value
    }
    public partial class DxPolarChartValueAxisConstantLinesLabel : DxPolarChartCommonAxisSettingsConstantLineStyleLabel
    {
        public string text { get; set; }
    }
    public partial class DxPolarChartValueAxisLabel : DxPolarChartCommonAxisSettingsLabel
    {
        // couldn't parse customizeHint
        // couldn't parse customizeText
        // couldn't parse format
        public float? precision { get; set; }
    }
    public partial class DxPolarChartValueAxisStrips : DxPolarChartCommonAxisSettingsStripStyle
    {
        public string color { get; set; }
        // couldn't parse endValue
        // couldn't parse label
        // couldn't parse startValue
    }
    public partial class DxPolarChartValueAxisStripsLabel : DxPolarChartCommonAxisSettingsStripStyleLabel
    {
        public string text { get; set; }
    }
    public partial class DxPolarChartValueAxisTick : DxPolarChartCommonAxisSettingsTick
    {
        public bool? visible { get; set; }
    }
    public partial class BaseChartOptions : BaseWidgetOptions
    {
        // couldn't parse adaptiveLayout
        // couldn't parse animation
        // couldn't parse customizeLabel
        // couldn't parse customizePoint
        // couldn't parse dataSource
        // couldn't parse legend
        public bool? onDoneEnabled { get; set; }
        public bool? onPointClickEnabled { get; set; }
        public bool? onPointHoverChangedEnabled { get; set; }
        public bool? onPointSelectionChangedEnabled { get; set; }
        public bool? onTooltipHiddenEnabled { get; set; }
        public bool? onTooltipShownEnabled { get; set; }
        // couldn't parse palette
        public string paletteExtensionMode { get; set; }
        public string pointSelectionMode { get; set; }
        // couldn't parse series
        // couldn't parse tooltip
    }

    public static class BaseChartOptionsPaletteExtensionMode
    {
        public const string Alternate = "alternate";
        public const string Blend = "blend";
        public const string Extrapolate = "extrapolate";
    }
    public static class BaseChartOptionsPointSelectionMode
    {
        public const string Multiple = "multiple";
        public const string Single = "single";
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
        // couldn't parse border
        public float? columnCount { get; set; }
        public float? columnItemSpacing { get; set; }
        // couldn't parse font
        public string horizontalAlignment { get; set; }
        public string itemsAlignment { get; set; }
        public string itemTextPosition { get; set; }
        // couldn't parse margin
        public float? markerSize { get; set; }
        public string orientation { get; set; }
        public float? paddingLeftRight { get; set; }
        public float? paddingTopBottom { get; set; }
        public float? rowCount { get; set; }
        public float? rowItemSpacing { get; set; }
        public string verticalAlignment { get; set; }
        public bool? visible { get; set; }
    }

    public static class BaseChartLegendHorizontalAlignment
    {
        public const string Center = "center";
        public const string Left = "left";
        public const string Right = "right";
    }
    public static class BaseChartLegendItemsAlignment
    {
        public const string Center = "center";
        public const string Left = "left";
        public const string Right = "right";
    }
    public static class BaseChartLegendItemTextPosition
    {
        public const string Bottom = "bottom";
        public const string Left = "left";
        public const string Right = "right";
        public const string Top = "top";
    }
    public static class BaseChartLegendOrientation
    {
        public const string Horizontal = "horizontal";
        public const string Vertical = "vertical";
    }
    public static class BaseChartLegendVerticalAlignment
    {
        public const string Bottom = "bottom";
        public const string Top = "top";
    }
    public partial class BaseChartTooltip : BaseWidgetTooltip
    {
        // couldn't parse argumentFormat
        public float? argumentPrecision { get; set; }
        // couldn't parse customizeTooltip
        public float? percentPrecision { get; set; }
    }
}
namespace DevExpress.Viz.Funnel
{
    public partial class DxFunnelOptions : BaseWidgetOptions
    {
        // couldn't parse adaptiveLayout
        public string algorithm { get; set; }
        public string argumentField { get; set; }
        public string colorField { get; set; }
        // couldn't parse dataSource
        public bool? hoverEnabled { get; set; }
        public bool? inverted { get; set; }
        // couldn't parse item
        // couldn't parse label
        // couldn't parse legend
        public float? neckHeight { get; set; }
        public float? neckWidth { get; set; }
        public bool? onHoverChangedEnabled { get; set; }
        public bool? onItemClickEnabled { get; set; }
        public bool? onLegendClickEnabled { get; set; }
        public bool? onSelectionChangedEnabled { get; set; }
        // couldn't parse palette
        public string paletteExtensionMode { get; set; }
        public string selectionMode { get; set; }
        public bool? sortData { get; set; }
        // couldn't parse tooltip
        public string valueField { get; set; }
    }

    public static class DxFunnelOptionsAlgorithm
    {
        public const string DynamicHeight = "dynamicHeight";
        public const string DynamicSlope = "dynamicSlope";
    }
    public static class DxFunnelOptionsPaletteExtensionMode
    {
        public const string Alternate = "alternate";
        public const string Blend = "blend";
        public const string Extrapolate = "extrapolate";
    }
    public static class DxFunnelOptionsSelectionMode
    {
        public const string Multiple = "multiple";
        public const string None = "none";
        public const string Single = "single";
    }
    public partial class DxFunnelTooltip : BaseWidgetTooltip
    {
        // couldn't parse customizeTooltip
    }
}
namespace DevExpress.Viz.Gauges
{
    public partial class BaseGaugeOptions : BaseWidgetOptions
    {
        // couldn't parse animation
        public string containerBackgroundColor { get; set; }
        public bool? onTooltipHiddenEnabled { get; set; }
        public bool? onTooltipShownEnabled { get; set; }
        // couldn't parse rangeContainer
        // couldn't parse scale
        // couldn't parse subtitle
        public float subvalues { get; set; }
        public object title { get; set; }
        // couldn't parse tooltip
        public float? value { get; set; }
    }
    public partial class BaseGaugeAnimation
    {
        public float? duration { get; set; }
        public string easing { get; set; }
        public bool? enabled { get; set; }
    }

    public static class BaseGaugeAnimationEasing
    {
        public const string EaseOutCubic = "easeOutCubic";
        public const string Linear = "linear";
    }
    public partial class BaseGaugeRangeContainer
    {
        public string backgroundColor { get; set; }
        public float? offset { get; set; }
        // couldn't parse palette
        public string paletteExtensionMode { get; set; }
        // couldn't parse ranges
    }

    public static class BaseGaugeRangeContainerPaletteExtensionMode
    {
        public const string Alternate = "alternate";
        public const string Blend = "blend";
        public const string Extrapolate = "extrapolate";
    }
    public partial class BaseGaugeScale
    {
        public bool? allowDecimals { get; set; }
        public float customMinorTicks { get; set; }
        public float customTicks { get; set; }
        public float? endValue { get; set; }
        public bool? hideFirstLabel { get; set; }
        public bool? hideFirstTick { get; set; }
        public bool? hideLastLabel { get; set; }
        public bool? hideLastTick { get; set; }
        // couldn't parse label
        // couldn't parse majorTick
        // couldn't parse minorTick
        public float? minorTickInterval { get; set; }
        public float? startValue { get; set; }
        // couldn't parse tick
        public float? tickInterval { get; set; }
    }
    public partial class BaseGaugeScaleLabel
    {
        // couldn't parse customizeText
        // couldn't parse font
        // couldn't parse format
        // couldn't parse overlappingBehavior
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
        // couldn't parse font
        public string text { get; set; }
    }
    public partial class BaseGaugeTitle : BaseWidgetTitle
    {
        public string position { get; set; }
    }

    public static class BaseGaugeTitlePosition
    {
        public const string BottomCenter = "bottom-center";
        public const string BottomLeft = "bottom-left";
        public const string BottomRight = "bottom-right";
        public const string TopCenter = "top-center";
        public const string TopLeft = "top-left";
        public const string TopRight = "top-right";
    }
    public partial class BaseGaugeTooltip : BaseWidgetTooltip
    {
        // couldn't parse customizeTooltip
    }
    public partial class DxCircularGaugeOptions : BaseGaugeOptions
    {
        // couldn't parse geometry
        // couldn't parse rangeContainer
        // couldn't parse scale
        // couldn't parse subvalueIndicator
        // couldn't parse valueIndicator
    }
    public partial class DxCircularGaugeRangeContainer : BaseGaugeRangeContainer
    {
        public string orientation { get; set; }
        public float? width { get; set; }
    }

    public static class DxCircularGaugeRangeContainerOrientation
    {
        public const string Center = "center";
        public const string Inside = "inside";
        public const string Outside = "outside";
    }
    public partial class DxCircularGaugeScale : BaseGaugeScale
    {
        // couldn't parse label
        public string orientation { get; set; }
    }

    public static class DxCircularGaugeScaleOrientation
    {
        public const string Center = "center";
        public const string Inside = "inside";
        public const string Outside = "outside";
    }
    public partial class DxCircularGaugeScaleLabel : BaseGaugeScaleLabel
    {
        public string hideFirstOrLast { get; set; }
        public float? indentFromTick { get; set; }
        // couldn't parse overlappingBehavior
    }

    public static class DxCircularGaugeScaleLabelHideFirstOrLast
    {
        public const string First = "first";
        public const string Last = "last";
    }
    public partial class DxCircularGaugeScaleLabelOverlappingBehavior : BaseGaugeScaleLabelOverlappingBehavior
    {
        public string hideFirstOrLast { get; set; }
    }

    public static class DxCircularGaugeScaleLabelOverlappingBehaviorHideFirstOrLast
    {
        public const string First = "first";
        public const string Last = "last";
    }
    public partial class DxCircularGaugeSubvalueIndicator : CommonIndicator
    {
        public string type { get; set; }
    }

    public static class DxCircularGaugeSubvalueIndicatorType
    {
        public const string RectangleNeedle = "rectangleNeedle";
        public const string TriangleNeedle = "triangleNeedle";
        public const string TwoColorNeedle = "twoColorNeedle";
        public const string RangeBar = "rangeBar";
        public const string TriangleMarker = "triangleMarker";
        public const string TextCloud = "textCloud";
    }
    public partial class DxCircularGaugeValueIndicator : CommonIndicator
    {
        public string type { get; set; }
    }

    public static class DxCircularGaugeValueIndicatorType
    {
        public const string RectangleNeedle = "rectangleNeedle";
        public const string TriangleNeedle = "triangleNeedle";
        public const string TwoColorNeedle = "twoColorNeedle";
        public const string RangeBar = "rangeBar";
        public const string TriangleMarker = "triangleMarker";
        public const string TextCloud = "textCloud";
    }
    public partial class DxLinearGaugeOptions : BaseGaugeOptions
    {
        // couldn't parse geometry
        // couldn't parse rangeContainer
        // couldn't parse scale
        // couldn't parse subvalueIndicator
        // couldn't parse valueIndicator
    }
    public partial class DxLinearGaugeRangeContainer : BaseGaugeRangeContainer
    {
        public string horizontalOrientation { get; set; }
        public string verticalOrientation { get; set; }
        // couldn't parse width
    }

    public static class DxLinearGaugeRangeContainerHorizontalOrientation
    {
        public const string Center = "center";
        public const string Left = "left";
        public const string Right = "right";
    }
    public static class DxLinearGaugeRangeContainerVerticalOrientation
    {
        public const string Bottom = "bottom";
        public const string Center = "center";
        public const string Top = "top";
    }
    public partial class DxLinearGaugeScale : BaseGaugeScale
    {
        public string horizontalOrientation { get; set; }
        // couldn't parse label
        public string verticalOrientation { get; set; }
    }

    public static class DxLinearGaugeScaleHorizontalOrientation
    {
        public const string Center = "center";
        public const string Left = "left";
        public const string Right = "right";
    }
    public static class DxLinearGaugeScaleVerticalOrientation
    {
        public const string Bottom = "bottom";
        public const string Center = "center";
        public const string Top = "top";
    }
    public partial class DxLinearGaugeScaleLabel : BaseGaugeScaleLabel
    {
        public float? indentFromTick { get; set; }
        // couldn't parse overlappingBehavior
    }
    public partial class DxLinearGaugeScaleLabelOverlappingBehavior : BaseGaugeScaleLabelOverlappingBehavior
    {
        public string hideFirstOrLast { get; set; }
    }

    public static class DxLinearGaugeScaleLabelOverlappingBehaviorHideFirstOrLast
    {
        public const string First = "first";
        public const string Last = "last";
    }
    public partial class DxLinearGaugeSubvalueIndicator : CommonIndicator
    {
        public string type { get; set; }
    }

    public static class DxLinearGaugeSubvalueIndicatorType
    {
        public const string Rectangle = "rectangle";
        public const string Circle = "circle";
        public const string Rhombus = "rhombus";
        public const string RangeBar = "rangeBar";
        public const string TriangleMarker = "triangleMarker";
        public const string TextCloud = "textCloud";
    }
    public partial class DxLinearGaugeValueIndicator : CommonIndicator
    {
        public string type { get; set; }
    }

    public static class DxLinearGaugeValueIndicatorType
    {
        public const string Rectangle = "rectangle";
        public const string Circle = "circle";
        public const string Rhombus = "rhombus";
        public const string RangeBar = "rangeBar";
        public const string TriangleMarker = "triangleMarker";
        public const string TextCloud = "textCloud";
    }
    public partial class DxBarGaugeOptions : BaseWidgetOptions
    {
        public object animation { get; set; }
        public string backgroundColor { get; set; }
        public float? barSpacing { get; set; }
        public float? baseValue { get; set; }
        public float? endValue { get; set; }
        // couldn't parse geometry
        // couldn't parse label
        public bool? onTooltipHiddenEnabled { get; set; }
        public bool? onTooltipShownEnabled { get; set; }
        // couldn't parse palette
        public string paletteExtensionMode { get; set; }
        public float? relativeInnerRadius { get; set; }
        public float? startValue { get; set; }
        // couldn't parse subtitle
        public object title { get; set; }
        // couldn't parse tooltip
        public float values { get; set; }
    }

    public static class DxBarGaugeOptionsPaletteExtensionMode
    {
        public const string Alternate = "alternate";
        public const string Blend = "blend";
        public const string Extrapolate = "extrapolate";
    }
    public partial class DxBarGaugeTitle : BaseWidgetTitle
    {
        public string position { get; set; }
    }

    public static class DxBarGaugeTitlePosition
    {
        public const string BottomCenter = "bottom-center";
        public const string BottomLeft = "bottom-left";
        public const string BottomRight = "bottom-right";
        public const string TopCenter = "top-center";
        public const string TopLeft = "top-left";
        public const string TopRight = "top-right";
    }
    public partial class DxBarGaugeTooltip : BaseWidgetTooltip
    {
        // couldn't parse customizeTooltip
    }
}
namespace DevExpress.Viz.RangeSelector
{
    public partial class DxRangeSelectorOptions : BaseWidgetOptions
    {
        // couldn't parse background
        // couldn't parse behavior
        // couldn't parse chart
        public string containerBackgroundColor { get; set; }
        // couldn't parse dataSource
        public string dataSourceField { get; set; }
        // couldn't parse indent
        public bool? onSelectedRangeChangedEnabled { get; set; }
        public bool? onValueChangedEnabled { get; set; }
        // couldn't parse scale
        // couldn't parse selectedRange
        public string selectedRangeColor { get; set; }
        // couldn't parse shutter
        // couldn't parse sliderHandle
        // couldn't parse sliderMarker
        // couldn't parse value
    }
}
namespace DevExpress.Viz.Sparklines
{
    public partial class BaseSparklineOptions : BaseWidgetOptions
    {
        public bool? onTooltipHiddenEnabled { get; set; }
        public bool? onTooltipShownEnabled { get; set; }
        // couldn't parse tooltip
    }
    public partial class BaseSparklineTooltip : BaseWidgetTooltip
    {
        // couldn't parse customizeTooltip
        public bool? enabled { get; set; }
        public string horizontalAlignment { get; set; }
        public string verticalAlignment { get; set; }
    }

    public static class BaseSparklineTooltipHorizontalAlignment
    {
        public const string Center = "center";
        public const string Left = "left";
        public const string Right = "right";
    }
    public static class BaseSparklineTooltipVerticalAlignment
    {
        public const string Bottom = "bottom";
        public const string Top = "top";
    }
    public partial class DxSparklineOptions : BaseSparklineOptions
    {
        public string argumentField { get; set; }
        public string barNegativeColor { get; set; }
        public string barPositiveColor { get; set; }
        // couldn't parse dataSource
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

    public static class DxSparklineOptionsPointSymbol
    {
        public const string Circle = "circle";
        public const string Cross = "cross";
        public const string Polygon = "polygon";
        public const string Square = "square";
        public const string Triangle = "triangle";
    }
    public static class DxSparklineOptionsType
    {
        public const string Area = "area";
        public const string Bar = "bar";
        public const string Line = "line";
        public const string Spline = "spline";
        public const string Splinearea = "splinearea";
        public const string Steparea = "steparea";
        public const string Stepline = "stepline";
        public const string Winloss = "winloss";
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
        // couldn't parse areaSettings
        // couldn't parse background
        public float bounds { get; set; }
        public float center { get; set; }
        // couldn't parse controlBar
        // couldn't parse layers
        // couldn't parse legends
        // couldn't parse mapData
        // couldn't parse markers
        // couldn't parse markerSettings
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
        // couldn't parse tooltip
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
        public float colorGroups { get; set; }
        // couldn't parse customize
        public string hoveredBorderColor { get; set; }
        public float? hoveredBorderWidth { get; set; }
        public string hoveredColor { get; set; }
        public bool? hoverEnabled { get; set; }
        // couldn't parse label
        // couldn't parse palette
        public float? paletteSize { get; set; }
        public string selectedBorderColor { get; set; }
        public float? selectedBorderWidth { get; set; }
        public string selectedColor { get; set; }
        public string selectionMode { get; set; }
    }

    public static class DxVectorMapAreaSettingsSelectionMode
    {
        public const string Multiple = "multiple";
        public const string None = "none";
        public const string Single = "single";
    }
    public partial class DxVectorMapMarkerSettings
    {
        public string borderColor { get; set; }
        public float? borderWidth { get; set; }
        public string color { get; set; }
        public string colorGroupingField { get; set; }
        public float colorGroups { get; set; }
        // couldn't parse customize
        public string hoveredBorderColor { get; set; }
        public float? hoveredBorderWidth { get; set; }
        public string hoveredColor { get; set; }
        public bool? hoverEnabled { get; set; }
        // couldn't parse label
        public float? maxSize { get; set; }
        public float? minSize { get; set; }
        public float? opacity { get; set; }
        // couldn't parse palette
        public string selectedBorderColor { get; set; }
        public float? selectedBorderWidth { get; set; }
        public string selectedColor { get; set; }
        public string selectionMode { get; set; }
        public float? size { get; set; }
        public string sizeGroupingField { get; set; }
        public float sizeGroups { get; set; }
        public string type { get; set; }
    }

    public static class DxVectorMapMarkerSettingsSelectionMode
    {
        public const string Multiple = "multiple";
        public const string None = "none";
        public const string Single = "single";
    }
    public static class DxVectorMapMarkerSettingsType
    {
        public const string Bubble = "bubble";
        public const string Dot = "dot";
        public const string Image = "image";
        public const string Pie = "pie";
    }
    public partial class DxVectorMapTooltip : BaseWidgetTooltip
    {
        // couldn't parse customizeTooltip
    }
}
namespace DevExpress.Viz.TreeMap
{
    public partial class DxTreeMapOptions : BaseWidgetOptions
    {
        public string childrenField { get; set; }
        public string colorField { get; set; }
        // couldn't parse colorizer
        // couldn't parse dataSource
        // couldn't parse group
        public bool? hoverEnabled { get; set; }
        public string idField { get; set; }
        public bool? interactWithGroup { get; set; }
        public string labelField { get; set; }
        // couldn't parse layoutAlgorithm
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
        // couldn't parse tile
        // couldn't parse tooltip
        public string valueField { get; set; }
    }

    public static class DxTreeMapOptionsLayoutDirection
    {
        public const string LeftBottomRightTop = "leftBottomRightTop";
        public const string LeftTopRightBottom = "leftTopRightBottom";
        public const string RightBottomLeftTop = "rightBottomLeftTop";
        public const string RightTopLeftBottom = "rightTopLeftBottom";
    }
    public static class DxTreeMapOptionsResolveLabelOverflow
    {
        public const string Ellipsis = "ellipsis";
        public const string Hide = "hide";
    }
    public static class DxTreeMapOptionsSelectionMode
    {
        public const string Multiple = "multiple";
        public const string None = "none";
        public const string Single = "single";
    }
    public partial class DxTreeMapTooltip : BaseWidgetTooltip
    {
        // couldn't parse customizeTooltip
    }
}
