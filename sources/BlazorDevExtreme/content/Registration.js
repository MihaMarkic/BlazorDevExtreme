const assemblyName = "BlazorDevExtreme";
const namespace = "BlazorDevExtreme";

Blazor.registerFunction('BlazorDevExtreme.DxAccordion.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    if (options.onItemTitleClickEnabled) {
        options.onItemTitleClick = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxAccordionInterop", "OnItemTitleClick");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    let element = document.getElementById(identifier);
    let instance = new DevExpress.ui.dxAccordion(element, options);
});
Blazor.registerFunction('BlazorDevExtreme.DxActionSheet.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    if (options.onCancelClickEnabled) {
        options.onCancelClick = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxActionSheetInterop", "OnCancelClick");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    let element = document.getElementById(identifier);
    let instance = new DevExpress.ui.dxActionSheet(element, options);
});
Blazor.registerFunction('BlazorDevExtreme.DxAutocomplete.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    let element = document.getElementById(identifier);
    let instance = new DevExpress.ui.dxAutocomplete(element, options);
});
Blazor.registerFunction('BlazorDevExtreme.DxBox.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    let element = document.getElementById(identifier);
    let instance = new DevExpress.ui.dxBox(element, options);
});
Blazor.registerFunction('BlazorDevExtreme.DxButton.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    if (options.onClickEnabled) {
        options.onClick = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxButtonInterop", "OnClick");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    let element = document.getElementById(identifier);
    let instance = new DevExpress.ui.dxButton(element, options);
});
Blazor.registerFunction('BlazorDevExtreme.DxCalendar.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    let element = document.getElementById(identifier);
    let instance = new DevExpress.ui.dxCalendar(element, options);
});
Blazor.registerFunction('BlazorDevExtreme.DxCheckBox.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    let element = document.getElementById(identifier);
    let instance = new DevExpress.ui.dxCheckBox(element, options);
});
Blazor.registerFunction('BlazorDevExtreme.DxColorBox.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    let element = document.getElementById(identifier);
    let instance = new DevExpress.ui.dxColorBox(element, options);
});
Blazor.registerFunction('BlazorDevExtreme.DxContextMenu.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    if (options.onHiddenEnabled) {
        options.onHidden = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxContextMenuInterop", "OnHidden");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onHidingEnabled) {
        options.onHiding = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxContextMenuInterop", "OnHiding");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onPositioningEnabled) {
        options.onPositioning = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxContextMenuInterop", "OnPositioning");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onShowingEnabled) {
        options.onShowing = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxContextMenuInterop", "OnShowing");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onShownEnabled) {
        options.onShown = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxContextMenuInterop", "OnShown");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    let element = document.getElementById(identifier);
    let instance = new DevExpress.ui.dxContextMenu(element, options);
});
Blazor.registerFunction('BlazorDevExtreme.DxDataGrid.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    if (options.onCellClickEnabled) {
        options.onCellClick = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxDataGridInterop", "OnCellClick");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onCellHoverChangedEnabled) {
        options.onCellHoverChanged = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxDataGridInterop", "OnCellHoverChanged");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onCellPreparedEnabled) {
        options.onCellPrepared = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxDataGridInterop", "OnCellPrepared");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onContextMenuPreparingEnabled) {
        options.onContextMenuPreparing = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxDataGridInterop", "OnContextMenuPreparing");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onEditingStartEnabled) {
        options.onEditingStart = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxDataGridInterop", "OnEditingStart");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onEditorPreparedEnabled) {
        options.onEditorPrepared = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxDataGridInterop", "OnEditorPrepared");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onEditorPreparingEnabled) {
        options.onEditorPreparing = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxDataGridInterop", "OnEditorPreparing");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onExportedEnabled) {
        options.onExported = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxDataGridInterop", "OnExported");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onExportingEnabled) {
        options.onExporting = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxDataGridInterop", "OnExporting");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onFileSavingEnabled) {
        options.onFileSaving = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxDataGridInterop", "OnFileSaving");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onRowClickEnabled) {
        options.onRowClick = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxDataGridInterop", "OnRowClick");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onRowPreparedEnabled) {
        options.onRowPrepared = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxDataGridInterop", "OnRowPrepared");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    let element = document.getElementById(identifier);
    let instance = new DevExpress.ui.dxDataGrid(element, options);
});
Blazor.registerFunction('BlazorDevExtreme.DxDateBox.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    let element = document.getElementById(identifier);
    let instance = new DevExpress.ui.dxDateBox(element, options);
});
Blazor.registerFunction('BlazorDevExtreme.DxDeferRendering.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    if (options.onRenderedEnabled) {
        options.onRendered = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxDeferRenderingInterop", "OnRendered");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onShownEnabled) {
        options.onShown = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxDeferRenderingInterop", "OnShown");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    let element = document.getElementById(identifier);
    let instance = new DevExpress.ui.dxDeferRendering(element, options);
});
Blazor.registerFunction('BlazorDevExtreme.DxDropDownBox.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    let element = document.getElementById(identifier);
    let instance = new DevExpress.ui.dxDropDownBox(element, options);
});
Blazor.registerFunction('BlazorDevExtreme.DxFileUploader.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    if (options.onProgressEnabled) {
        options.onProgress = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxFileUploaderInterop", "OnProgress");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onUploadAbortedEnabled) {
        options.onUploadAborted = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxFileUploaderInterop", "OnUploadAborted");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onUploadedEnabled) {
        options.onUploaded = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxFileUploaderInterop", "OnUploaded");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onUploadErrorEnabled) {
        options.onUploadError = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxFileUploaderInterop", "OnUploadError");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onUploadStartedEnabled) {
        options.onUploadStarted = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxFileUploaderInterop", "OnUploadStarted");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onValueChangedEnabled) {
        options.onValueChanged = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxFileUploaderInterop", "OnValueChanged");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    let element = document.getElementById(identifier);
    let instance = new DevExpress.ui.dxFileUploader(element, options);
});
Blazor.registerFunction('BlazorDevExtreme.DxFilterBuilder.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    if (options.onEditorPreparedEnabled) {
        options.onEditorPrepared = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxFilterBuilderInterop", "OnEditorPrepared");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onEditorPreparingEnabled) {
        options.onEditorPreparing = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxFilterBuilderInterop", "OnEditorPreparing");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onValueChangedEnabled) {
        options.onValueChanged = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxFilterBuilderInterop", "OnValueChanged");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    let element = document.getElementById(identifier);
    let instance = new DevExpress.ui.dxFilterBuilder(element, options);
});
Blazor.registerFunction('BlazorDevExtreme.DxForm.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    if (options.onEditorEnterKeyEnabled) {
        options.onEditorEnterKey = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxFormInterop", "OnEditorEnterKey");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onFieldDataChangedEnabled) {
        options.onFieldDataChanged = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxFormInterop", "OnFieldDataChanged");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    let element = document.getElementById(identifier);
    let instance = new DevExpress.ui.dxForm(element, options);
});
Blazor.registerFunction('BlazorDevExtreme.DxGallery.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    let element = document.getElementById(identifier);
    let instance = new DevExpress.ui.dxGallery(element, options);
});
Blazor.registerFunction('BlazorDevExtreme.DxList.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    if (options.onGroupRenderedEnabled) {
        options.onGroupRendered = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxListInterop", "OnGroupRendered");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onItemClickEnabled) {
        options.onItemClick = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxListInterop", "OnItemClick");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onItemContextMenuEnabled) {
        options.onItemContextMenu = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxListInterop", "OnItemContextMenu");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onItemDeletedEnabled) {
        options.onItemDeleted = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxListInterop", "OnItemDeleted");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onItemDeletingEnabled) {
        options.onItemDeleting = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxListInterop", "OnItemDeleting");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onItemHoldEnabled) {
        options.onItemHold = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxListInterop", "OnItemHold");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onItemReorderedEnabled) {
        options.onItemReordered = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxListInterop", "OnItemReordered");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onItemSwipeEnabled) {
        options.onItemSwipe = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxListInterop", "OnItemSwipe");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onPageLoadingEnabled) {
        options.onPageLoading = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxListInterop", "OnPageLoading");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onPullRefreshEnabled) {
        options.onPullRefresh = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxListInterop", "OnPullRefresh");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onScrollEnabled) {
        options.onScroll = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxListInterop", "OnScroll");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onSelectAllValueChangedEnabled) {
        options.onSelectAllValueChanged = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxListInterop", "OnSelectAllValueChanged");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    let element = document.getElementById(identifier);
    let instance = new DevExpress.ui.dxList(element, options);
});
Blazor.registerFunction('BlazorDevExtreme.DxLoadIndicator.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    let element = document.getElementById(identifier);
    let instance = new DevExpress.ui.dxLoadIndicator(element, options);
});
Blazor.registerFunction('BlazorDevExtreme.DxLoadPanel.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    let element = document.getElementById(identifier);
    let instance = new DevExpress.ui.dxLoadPanel(element, options);
});
Blazor.registerFunction('BlazorDevExtreme.DxLookup.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    if (options.onPageLoadingEnabled) {
        options.onPageLoading = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxLookupInterop", "OnPageLoading");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onPullRefreshEnabled) {
        options.onPullRefresh = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxLookupInterop", "OnPullRefresh");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onScrollEnabled) {
        options.onScroll = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxLookupInterop", "OnScroll");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onTitleRenderedEnabled) {
        options.onTitleRendered = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxLookupInterop", "OnTitleRendered");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onValueChangedEnabled) {
        options.onValueChanged = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxLookupInterop", "OnValueChanged");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    let element = document.getElementById(identifier);
    let instance = new DevExpress.ui.dxLookup(element, options);
});
Blazor.registerFunction('BlazorDevExtreme.DxMap.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    if (options.onClickEnabled) {
        options.onClick = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxMapInterop", "OnClick");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onMarkerAddedEnabled) {
        options.onMarkerAdded = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxMapInterop", "OnMarkerAdded");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onMarkerRemovedEnabled) {
        options.onMarkerRemoved = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxMapInterop", "OnMarkerRemoved");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onReadyEnabled) {
        options.onReady = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxMapInterop", "OnReady");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onRouteAddedEnabled) {
        options.onRouteAdded = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxMapInterop", "OnRouteAdded");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onRouteRemovedEnabled) {
        options.onRouteRemoved = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxMapInterop", "OnRouteRemoved");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    let element = document.getElementById(identifier);
    let instance = new DevExpress.ui.dxMap(element, options);
});
Blazor.registerFunction('BlazorDevExtreme.DxMenu.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    if (options.onSubmenuHiddenEnabled) {
        options.onSubmenuHidden = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxMenuInterop", "OnSubmenuHidden");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onSubmenuHidingEnabled) {
        options.onSubmenuHiding = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxMenuInterop", "OnSubmenuHiding");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onSubmenuShowingEnabled) {
        options.onSubmenuShowing = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxMenuInterop", "OnSubmenuShowing");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onSubmenuShownEnabled) {
        options.onSubmenuShown = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxMenuInterop", "OnSubmenuShown");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    let element = document.getElementById(identifier);
    let instance = new DevExpress.ui.dxMenu(element, options);
});
Blazor.registerFunction('BlazorDevExtreme.DxMultiView.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    let element = document.getElementById(identifier);
    let instance = new DevExpress.ui.dxMultiView(element, options);
});
Blazor.registerFunction('BlazorDevExtreme.DxNavBar.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    let element = document.getElementById(identifier);
    let instance = new DevExpress.ui.dxNavBar(element, options);
});
Blazor.registerFunction('BlazorDevExtreme.DxNumberBox.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    let element = document.getElementById(identifier);
    let instance = new DevExpress.ui.dxNumberBox(element, options);
});
Blazor.registerFunction('BlazorDevExtreme.DxPanorama.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    let element = document.getElementById(identifier);
    let instance = new DevExpress.ui.dxPanorama(element, options);
});
Blazor.registerFunction('BlazorDevExtreme.DxPivot.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    let element = document.getElementById(identifier);
    let instance = new DevExpress.ui.dxPivot(element, options);
});
Blazor.registerFunction('BlazorDevExtreme.DxPivotGrid.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    if (options.onCellClickEnabled) {
        options.onCellClick = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxPivotGridInterop", "OnCellClick");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onCellPreparedEnabled) {
        options.onCellPrepared = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxPivotGridInterop", "OnCellPrepared");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onContextMenuPreparingEnabled) {
        options.onContextMenuPreparing = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxPivotGridInterop", "OnContextMenuPreparing");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onExportedEnabled) {
        options.onExported = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxPivotGridInterop", "OnExported");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onExportingEnabled) {
        options.onExporting = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxPivotGridInterop", "OnExporting");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onFileSavingEnabled) {
        options.onFileSaving = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxPivotGridInterop", "OnFileSaving");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    let element = document.getElementById(identifier);
    let instance = new DevExpress.ui.dxPivotGrid(element, options);
});
Blazor.registerFunction('BlazorDevExtreme.DxPivotGridFieldChooser.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    if (options.onContextMenuPreparingEnabled) {
        options.onContextMenuPreparing = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxPivotGridFieldChooserInterop", "OnContextMenuPreparing");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    let element = document.getElementById(identifier);
    let instance = new DevExpress.ui.dxPivotGridFieldChooser(element, options);
});
Blazor.registerFunction('BlazorDevExtreme.DxPopover.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    let element = document.getElementById(identifier);
    let instance = new DevExpress.ui.dxPopover(element, options);
});
Blazor.registerFunction('BlazorDevExtreme.DxPopup.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    if (options.onResizeEnabled) {
        options.onResize = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxPopupInterop", "OnResize");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onResizeEndEnabled) {
        options.onResizeEnd = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxPopupInterop", "OnResizeEnd");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onResizeStartEnabled) {
        options.onResizeStart = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxPopupInterop", "OnResizeStart");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onTitleRenderedEnabled) {
        options.onTitleRendered = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxPopupInterop", "OnTitleRendered");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    let element = document.getElementById(identifier);
    let instance = new DevExpress.ui.dxPopup(element, options);
});
Blazor.registerFunction('BlazorDevExtreme.DxProgressBar.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    if (options.onCompleteEnabled) {
        options.onComplete = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxProgressBarInterop", "OnComplete");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    let element = document.getElementById(identifier);
    let instance = new DevExpress.ui.dxProgressBar(element, options);
});
Blazor.registerFunction('BlazorDevExtreme.DxRadioGroup.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    let element = document.getElementById(identifier);
    let instance = new DevExpress.ui.dxRadioGroup(element, options);
});
Blazor.registerFunction('BlazorDevExtreme.DxRangeSlider.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    if (options.onValueChangedEnabled) {
        options.onValueChanged = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxRangeSliderInterop", "OnValueChanged");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    let element = document.getElementById(identifier);
    let instance = new DevExpress.ui.dxRangeSlider(element, options);
});
Blazor.registerFunction('BlazorDevExtreme.DxResizable.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    if (options.onResizeEnabled) {
        options.onResize = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxResizableInterop", "OnResize");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onResizeEndEnabled) {
        options.onResizeEnd = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxResizableInterop", "OnResizeEnd");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onResizeStartEnabled) {
        options.onResizeStart = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxResizableInterop", "OnResizeStart");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    let element = document.getElementById(identifier);
    let instance = new DevExpress.ui.dxResizable(element, options);
});
Blazor.registerFunction('BlazorDevExtreme.DxResponsiveBox.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    let element = document.getElementById(identifier);
    let instance = new DevExpress.ui.dxResponsiveBox(element, options);
});
Blazor.registerFunction('BlazorDevExtreme.DxScheduler.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    if (options.onAppointmentAddedEnabled) {
        options.onAppointmentAdded = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxSchedulerInterop", "OnAppointmentAdded");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onAppointmentAddingEnabled) {
        options.onAppointmentAdding = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxSchedulerInterop", "OnAppointmentAdding");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onAppointmentClickEnabled) {
        options.onAppointmentClick = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxSchedulerInterop", "OnAppointmentClick");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onAppointmentContextMenuEnabled) {
        options.onAppointmentContextMenu = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxSchedulerInterop", "OnAppointmentContextMenu");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onAppointmentDblClickEnabled) {
        options.onAppointmentDblClick = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxSchedulerInterop", "OnAppointmentDblClick");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onAppointmentDeletedEnabled) {
        options.onAppointmentDeleted = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxSchedulerInterop", "OnAppointmentDeleted");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onAppointmentDeletingEnabled) {
        options.onAppointmentDeleting = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxSchedulerInterop", "OnAppointmentDeleting");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onAppointmentFormCreatedEnabled) {
        options.onAppointmentFormCreated = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxSchedulerInterop", "OnAppointmentFormCreated");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onAppointmentRenderedEnabled) {
        options.onAppointmentRendered = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxSchedulerInterop", "OnAppointmentRendered");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onAppointmentUpdatedEnabled) {
        options.onAppointmentUpdated = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxSchedulerInterop", "OnAppointmentUpdated");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onAppointmentUpdatingEnabled) {
        options.onAppointmentUpdating = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxSchedulerInterop", "OnAppointmentUpdating");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onCellClickEnabled) {
        options.onCellClick = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxSchedulerInterop", "OnCellClick");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onCellContextMenuEnabled) {
        options.onCellContextMenu = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxSchedulerInterop", "OnCellContextMenu");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    let element = document.getElementById(identifier);
    let instance = new DevExpress.ui.dxScheduler(element, options);
});
Blazor.registerFunction('BlazorDevExtreme.DxScrollView.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    if (options.onPullDownEnabled) {
        options.onPullDown = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxScrollViewInterop", "OnPullDown");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onReachBottomEnabled) {
        options.onReachBottom = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxScrollViewInterop", "OnReachBottom");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    let element = document.getElementById(identifier);
    let instance = new DevExpress.ui.dxScrollView(element, options);
});
Blazor.registerFunction('BlazorDevExtreme.DxSelectBox.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    if (options.onCustomItemCreatingEnabled) {
        options.onCustomItemCreating = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxSelectBoxInterop", "OnCustomItemCreating");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    let element = document.getElementById(identifier);
    let instance = new DevExpress.ui.dxSelectBox(element, options);
});
Blazor.registerFunction('BlazorDevExtreme.DxSlideOut.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    if (options.onMenuGroupRenderedEnabled) {
        options.onMenuGroupRendered = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxSlideOutInterop", "OnMenuGroupRendered");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onMenuItemRenderedEnabled) {
        options.onMenuItemRendered = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxSlideOutInterop", "OnMenuItemRendered");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    let element = document.getElementById(identifier);
    let instance = new DevExpress.ui.dxSlideOut(element, options);
});
Blazor.registerFunction('BlazorDevExtreme.DxSlideOutView.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    let element = document.getElementById(identifier);
    let instance = new DevExpress.ui.dxSlideOutView(element, options);
});
Blazor.registerFunction('BlazorDevExtreme.DxSlider.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    let element = document.getElementById(identifier);
    let instance = new DevExpress.ui.dxSlider(element, options);
});
Blazor.registerFunction('BlazorDevExtreme.DxSwitch.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    let element = document.getElementById(identifier);
    let instance = new DevExpress.ui.dxSwitch(element, options);
});
Blazor.registerFunction('BlazorDevExtreme.DxTabPanel.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    if (options.onTitleClickEnabled) {
        options.onTitleClick = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxTabPanelInterop", "OnTitleClick");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onTitleHoldEnabled) {
        options.onTitleHold = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxTabPanelInterop", "OnTitleHold");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onTitleRenderedEnabled) {
        options.onTitleRendered = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxTabPanelInterop", "OnTitleRendered");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    let element = document.getElementById(identifier);
    let instance = new DevExpress.ui.dxTabPanel(element, options);
});
Blazor.registerFunction('BlazorDevExtreme.DxTabs.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    let element = document.getElementById(identifier);
    let instance = new DevExpress.ui.dxTabs(element, options);
});
Blazor.registerFunction('BlazorDevExtreme.DxTagBox.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    if (options.onMultiTagPreparingEnabled) {
        options.onMultiTagPreparing = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxTagBoxInterop", "OnMultiTagPreparing");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onSelectAllValueChangedEnabled) {
        options.onSelectAllValueChanged = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxTagBoxInterop", "OnSelectAllValueChanged");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onSelectionChangedEnabled) {
        options.onSelectionChanged = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxTagBoxInterop", "OnSelectionChanged");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    let element = document.getElementById(identifier);
    let instance = new DevExpress.ui.dxTagBox(element, options);
});
Blazor.registerFunction('BlazorDevExtreme.DxTextArea.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    let element = document.getElementById(identifier);
    let instance = new DevExpress.ui.dxTextArea(element, options);
});
Blazor.registerFunction('BlazorDevExtreme.DxTextBox.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    let element = document.getElementById(identifier);
    let instance = new DevExpress.ui.dxTextBox(element, options);
});
Blazor.registerFunction('BlazorDevExtreme.DxTileView.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    let element = document.getElementById(identifier);
    let instance = new DevExpress.ui.dxTileView(element, options);
});
Blazor.registerFunction('BlazorDevExtreme.DxToast.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    let element = document.getElementById(identifier);
    let instance = new DevExpress.ui.dxToast(element, options);
});
Blazor.registerFunction('BlazorDevExtreme.DxToolbar.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    let element = document.getElementById(identifier);
    let instance = new DevExpress.ui.dxToolbar(element, options);
});
Blazor.registerFunction('BlazorDevExtreme.DxTooltip.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    let element = document.getElementById(identifier);
    let instance = new DevExpress.ui.dxTooltip(element, options);
});
Blazor.registerFunction('BlazorDevExtreme.DxTreeList.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    if (options.onCellClickEnabled) {
        options.onCellClick = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxTreeListInterop", "OnCellClick");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onCellHoverChangedEnabled) {
        options.onCellHoverChanged = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxTreeListInterop", "OnCellHoverChanged");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onCellPreparedEnabled) {
        options.onCellPrepared = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxTreeListInterop", "OnCellPrepared");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onContextMenuPreparingEnabled) {
        options.onContextMenuPreparing = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxTreeListInterop", "OnContextMenuPreparing");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onEditingStartEnabled) {
        options.onEditingStart = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxTreeListInterop", "OnEditingStart");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onEditorPreparedEnabled) {
        options.onEditorPrepared = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxTreeListInterop", "OnEditorPrepared");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onEditorPreparingEnabled) {
        options.onEditorPreparing = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxTreeListInterop", "OnEditorPreparing");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onNodesInitializedEnabled) {
        options.onNodesInitialized = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxTreeListInterop", "OnNodesInitialized");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onRowClickEnabled) {
        options.onRowClick = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxTreeListInterop", "OnRowClick");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onRowPreparedEnabled) {
        options.onRowPrepared = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxTreeListInterop", "OnRowPrepared");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    let element = document.getElementById(identifier);
    let instance = new DevExpress.ui.dxTreeList(element, options);
});
Blazor.registerFunction('BlazorDevExtreme.DxTreeView.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    if (options.onItemClickEnabled) {
        options.onItemClick = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxTreeViewInterop", "OnItemClick");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onItemCollapsedEnabled) {
        options.onItemCollapsed = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxTreeViewInterop", "OnItemCollapsed");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onItemContextMenuEnabled) {
        options.onItemContextMenu = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxTreeViewInterop", "OnItemContextMenu");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onItemExpandedEnabled) {
        options.onItemExpanded = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxTreeViewInterop", "OnItemExpanded");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onItemHoldEnabled) {
        options.onItemHold = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxTreeViewInterop", "OnItemHold");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onItemRenderedEnabled) {
        options.onItemRendered = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxTreeViewInterop", "OnItemRendered");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onItemSelectionChangedEnabled) {
        options.onItemSelectionChanged = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxTreeViewInterop", "OnItemSelectionChanged");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onSelectionChangedEnabled) {
        options.onSelectionChanged = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxTreeViewInterop", "OnSelectionChanged");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    let element = document.getElementById(identifier);
    let instance = new DevExpress.ui.dxTreeView(element, options);
});
Blazor.registerFunction('BlazorDevExtreme.DxValidationGroup.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    let element = document.getElementById(identifier);
    let instance = new DevExpress.ui.dxValidationGroup(element, options);
});
Blazor.registerFunction('BlazorDevExtreme.DxValidationSummary.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    let element = document.getElementById(identifier);
    let instance = new DevExpress.ui.dxValidationSummary(element, options);
});
Blazor.registerFunction('BlazorDevExtreme.DxValidator.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    if (options.onValidatedEnabled) {
        options.onValidated = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxValidatorInterop", "OnValidated");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    let element = document.getElementById(identifier);
    let instance = new DevExpress.ui.dxValidator(element, options);
});
Blazor.registerFunction('BlazorDevExtreme.DxBarGauge.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    if (options.onTooltipHiddenEnabled) {
        options.onTooltipHidden = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxBarGaugeInterop", "OnTooltipHidden");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onTooltipShownEnabled) {
        options.onTooltipShown = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxBarGaugeInterop", "OnTooltipShown");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    let element = document.getElementById(identifier);
    let instance = new DevExpress.viz.gauges.dxBarGauge(element, options);
});
Blazor.registerFunction('BlazorDevExtreme.DxBullet.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    let element = document.getElementById(identifier);
    let instance = new DevExpress.viz.sparklines.dxBullet(element, options);
});
Blazor.registerFunction('BlazorDevExtreme.DxChart.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    if (options.onArgumentAxisClickEnabled) {
        options.onArgumentAxisClick = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxChartInterop", "OnArgumentAxisClick");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onLegendClickEnabled) {
        options.onLegendClick = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxChartInterop", "OnLegendClick");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onSeriesClickEnabled) {
        options.onSeriesClick = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxChartInterop", "OnSeriesClick");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onSeriesHoverChangedEnabled) {
        options.onSeriesHoverChanged = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxChartInterop", "OnSeriesHoverChanged");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onSeriesSelectionChangedEnabled) {
        options.onSeriesSelectionChanged = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxChartInterop", "OnSeriesSelectionChanged");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onZoomEndEnabled) {
        options.onZoomEnd = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxChartInterop", "OnZoomEnd");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onZoomStartEnabled) {
        options.onZoomStart = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxChartInterop", "OnZoomStart");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    let element = document.getElementById(identifier);
    let instance = new DevExpress.viz.charts.dxChart(element, options);
});
Blazor.registerFunction('BlazorDevExtreme.DxCircularGauge.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    let element = document.getElementById(identifier);
    let instance = new DevExpress.viz.gauges.dxCircularGauge(element, options);
});
Blazor.registerFunction('BlazorDevExtreme.DxFunnel.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    if (options.onHoverChangedEnabled) {
        options.onHoverChanged = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxFunnelInterop", "OnHoverChanged");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onItemClickEnabled) {
        options.onItemClick = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxFunnelInterop", "OnItemClick");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onLegendClickEnabled) {
        options.onLegendClick = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxFunnelInterop", "OnLegendClick");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onSelectionChangedEnabled) {
        options.onSelectionChanged = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxFunnelInterop", "OnSelectionChanged");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    let element = document.getElementById(identifier);
    let instance = new DevExpress.viz.funnel.dxFunnel(element, options);
});
Blazor.registerFunction('BlazorDevExtreme.DxLinearGauge.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    let element = document.getElementById(identifier);
    let instance = new DevExpress.viz.gauges.dxLinearGauge(element, options);
});
Blazor.registerFunction('BlazorDevExtreme.DxPieChart.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    if (options.onLegendClickEnabled) {
        options.onLegendClick = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxPieChartInterop", "OnLegendClick");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    let element = document.getElementById(identifier);
    let instance = new DevExpress.viz.charts.dxPieChart(element, options);
});
Blazor.registerFunction('BlazorDevExtreme.DxPolarChart.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    if (options.onArgumentAxisClickEnabled) {
        options.onArgumentAxisClick = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxPolarChartInterop", "OnArgumentAxisClick");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onLegendClickEnabled) {
        options.onLegendClick = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxPolarChartInterop", "OnLegendClick");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onSeriesClickEnabled) {
        options.onSeriesClick = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxPolarChartInterop", "OnSeriesClick");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onSeriesHoverChangedEnabled) {
        options.onSeriesHoverChanged = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxPolarChartInterop", "OnSeriesHoverChanged");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onSeriesSelectionChangedEnabled) {
        options.onSeriesSelectionChanged = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxPolarChartInterop", "OnSeriesSelectionChanged");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    let element = document.getElementById(identifier);
    let instance = new DevExpress.viz.charts.dxPolarChart(element, options);
});
Blazor.registerFunction('BlazorDevExtreme.DxRangeSelector.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    if (options.onSelectedRangeChangedEnabled) {
        options.onSelectedRangeChanged = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxRangeSelectorInterop", "OnSelectedRangeChanged");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onValueChangedEnabled) {
        options.onValueChanged = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxRangeSelectorInterop", "OnValueChanged");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    let element = document.getElementById(identifier);
    let instance = new DevExpress.viz.rangeSelector.dxRangeSelector(element, options);
});
Blazor.registerFunction('BlazorDevExtreme.DxSparkline.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    let element = document.getElementById(identifier);
    let instance = new DevExpress.viz.sparklines.dxSparkline(element, options);
});
Blazor.registerFunction('BlazorDevExtreme.DxTreeMap.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    if (options.onClickEnabled) {
        options.onClick = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxTreeMapInterop", "OnClick");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onDrillEnabled) {
        options.onDrill = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxTreeMapInterop", "OnDrill");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onHoverChangedEnabled) {
        options.onHoverChanged = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxTreeMapInterop", "OnHoverChanged");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onNodesInitializedEnabled) {
        options.onNodesInitialized = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxTreeMapInterop", "OnNodesInitialized");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onNodesRenderingEnabled) {
        options.onNodesRendering = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxTreeMapInterop", "OnNodesRendering");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onSelectionChangedEnabled) {
        options.onSelectionChanged = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxTreeMapInterop", "OnSelectionChanged");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    let element = document.getElementById(identifier);
    let instance = new DevExpress.viz.treeMap.dxTreeMap(element, options);
});
Blazor.registerFunction('BlazorDevExtreme.DxVectorMap.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    if (options.onAreaClickEnabled) {
        options.onAreaClick = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxVectorMapInterop", "OnAreaClick");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onAreaSelectionChangedEnabled) {
        options.onAreaSelectionChanged = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxVectorMapInterop", "OnAreaSelectionChanged");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onCenterChangedEnabled) {
        options.onCenterChanged = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxVectorMapInterop", "OnCenterChanged");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onClickEnabled) {
        options.onClick = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxVectorMapInterop", "OnClick");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onMarkerClickEnabled) {
        options.onMarkerClick = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxVectorMapInterop", "OnMarkerClick");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onMarkerSelectionChangedEnabled) {
        options.onMarkerSelectionChanged = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxVectorMapInterop", "OnMarkerSelectionChanged");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onSelectionChangedEnabled) {
        options.onSelectionChanged = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxVectorMapInterop", "OnSelectionChanged");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onTooltipHiddenEnabled) {
        options.onTooltipHidden = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxVectorMapInterop", "OnTooltipHidden");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onTooltipShownEnabled) {
        options.onTooltipShown = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxVectorMapInterop", "OnTooltipShown");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onZoomFactorChangedEnabled) {
        options.onZoomFactorChanged = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxVectorMapInterop", "OnZoomFactorChanged");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    let element = document.getElementById(identifier);
    let instance = new DevExpress.viz.map.dxVectorMap(element, options);
});
