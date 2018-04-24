const assemblyName = "BlazorDevExtreme";
const namespace = "BlazorDevExtreme";

Blazor.registerFunction('BlazorDevExtreme.DxAccordion.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    if (options.onItemTitleClickEnabled) {
        options.onItemTitleClick = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxAccordion", "OnItemTitleClick");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    $(identifier).dxAccordion(options);
});
Blazor.registerFunction('BlazorDevExtreme.DxActionSheet.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    if (options.onCancelClickEnabled) {
        options.onCancelClick = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxActionSheet", "OnCancelClick");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    $(identifier).dxActionSheet(options);
});
Blazor.registerFunction('BlazorDevExtreme.DxAutocomplete.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    $(identifier).dxAutocomplete(options);
});
Blazor.registerFunction('BlazorDevExtreme.DxBox.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    $(identifier).dxBox(options);
});
Blazor.registerFunction('BlazorDevExtreme.DxButton.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    if (options.onClickEnabled) {
        options.onClick = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxButton", "OnClick");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    $(identifier).dxButton(options);
});
Blazor.registerFunction('BlazorDevExtreme.DxCalendar.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    $(identifier).dxCalendar(options);
});
Blazor.registerFunction('BlazorDevExtreme.DxCheckBox.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    $(identifier).dxCheckBox(options);
});
Blazor.registerFunction('BlazorDevExtreme.DxColorBox.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    $(identifier).dxColorBox(options);
});
Blazor.registerFunction('BlazorDevExtreme.DxContextMenu.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    if (options.onHiddenEnabled) {
        options.onHidden = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxContextMenu", "OnHidden");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onHidingEnabled) {
        options.onHiding = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxContextMenu", "OnHiding");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onPositioningEnabled) {
        options.onPositioning = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxContextMenu", "OnPositioning");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onShowingEnabled) {
        options.onShowing = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxContextMenu", "OnShowing");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onShownEnabled) {
        options.onShown = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxContextMenu", "OnShown");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    $(identifier).dxContextMenu(options);
});
Blazor.registerFunction('BlazorDevExtreme.DxDataGrid.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    if (options.onCellClickEnabled) {
        options.onCellClick = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxDataGrid", "OnCellClick");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onCellHoverChangedEnabled) {
        options.onCellHoverChanged = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxDataGrid", "OnCellHoverChanged");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onCellPreparedEnabled) {
        options.onCellPrepared = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxDataGrid", "OnCellPrepared");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onContextMenuPreparingEnabled) {
        options.onContextMenuPreparing = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxDataGrid", "OnContextMenuPreparing");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onEditingStartEnabled) {
        options.onEditingStart = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxDataGrid", "OnEditingStart");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onEditorPreparedEnabled) {
        options.onEditorPrepared = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxDataGrid", "OnEditorPrepared");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onEditorPreparingEnabled) {
        options.onEditorPreparing = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxDataGrid", "OnEditorPreparing");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onExportedEnabled) {
        options.onExported = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxDataGrid", "OnExported");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onExportingEnabled) {
        options.onExporting = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxDataGrid", "OnExporting");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onFileSavingEnabled) {
        options.onFileSaving = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxDataGrid", "OnFileSaving");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onRowClickEnabled) {
        options.onRowClick = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxDataGrid", "OnRowClick");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onRowPreparedEnabled) {
        options.onRowPrepared = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxDataGrid", "OnRowPrepared");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    $(identifier).dxDataGrid(options);
});
Blazor.registerFunction('BlazorDevExtreme.DxDateBox.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    $(identifier).dxDateBox(options);
});
Blazor.registerFunction('BlazorDevExtreme.DxDeferRendering.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    if (options.onRenderedEnabled) {
        options.onRendered = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxDeferRendering", "OnRendered");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onShownEnabled) {
        options.onShown = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxDeferRendering", "OnShown");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    $(identifier).dxDeferRendering(options);
});
Blazor.registerFunction('BlazorDevExtreme.DxDropDownBox.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    $(identifier).dxDropDownBox(options);
});
Blazor.registerFunction('BlazorDevExtreme.DxFileUploader.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    if (options.onProgressEnabled) {
        options.onProgress = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxFileUploader", "OnProgress");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onUploadAbortedEnabled) {
        options.onUploadAborted = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxFileUploader", "OnUploadAborted");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onUploadedEnabled) {
        options.onUploaded = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxFileUploader", "OnUploaded");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onUploadErrorEnabled) {
        options.onUploadError = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxFileUploader", "OnUploadError");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onUploadStartedEnabled) {
        options.onUploadStarted = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxFileUploader", "OnUploadStarted");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onValueChangedEnabled) {
        options.onValueChanged = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxFileUploader", "OnValueChanged");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    $(identifier).dxFileUploader(options);
});
Blazor.registerFunction('BlazorDevExtreme.DxFilterBuilder.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    if (options.onEditorPreparedEnabled) {
        options.onEditorPrepared = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxFilterBuilder", "OnEditorPrepared");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onEditorPreparingEnabled) {
        options.onEditorPreparing = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxFilterBuilder", "OnEditorPreparing");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onValueChangedEnabled) {
        options.onValueChanged = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxFilterBuilder", "OnValueChanged");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    $(identifier).dxFilterBuilder(options);
});
Blazor.registerFunction('BlazorDevExtreme.DxForm.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    if (options.onEditorEnterKeyEnabled) {
        options.onEditorEnterKey = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxForm", "OnEditorEnterKey");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onFieldDataChangedEnabled) {
        options.onFieldDataChanged = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxForm", "OnFieldDataChanged");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    $(identifier).dxForm(options);
});
Blazor.registerFunction('BlazorDevExtreme.DxGallery.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    $(identifier).dxGallery(options);
});
Blazor.registerFunction('BlazorDevExtreme.DxList.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    if (options.onGroupRenderedEnabled) {
        options.onGroupRendered = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxList", "OnGroupRendered");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onItemClickEnabled) {
        options.onItemClick = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxList", "OnItemClick");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onItemContextMenuEnabled) {
        options.onItemContextMenu = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxList", "OnItemContextMenu");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onItemDeletedEnabled) {
        options.onItemDeleted = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxList", "OnItemDeleted");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onItemDeletingEnabled) {
        options.onItemDeleting = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxList", "OnItemDeleting");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onItemHoldEnabled) {
        options.onItemHold = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxList", "OnItemHold");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onItemReorderedEnabled) {
        options.onItemReordered = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxList", "OnItemReordered");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onItemSwipeEnabled) {
        options.onItemSwipe = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxList", "OnItemSwipe");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onPageLoadingEnabled) {
        options.onPageLoading = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxList", "OnPageLoading");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onPullRefreshEnabled) {
        options.onPullRefresh = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxList", "OnPullRefresh");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onScrollEnabled) {
        options.onScroll = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxList", "OnScroll");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onSelectAllValueChangedEnabled) {
        options.onSelectAllValueChanged = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxList", "OnSelectAllValueChanged");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    $(identifier).dxList(options);
});
Blazor.registerFunction('BlazorDevExtreme.DxLoadIndicator.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    $(identifier).dxLoadIndicator(options);
});
Blazor.registerFunction('BlazorDevExtreme.DxLoadPanel.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    $(identifier).dxLoadPanel(options);
});
Blazor.registerFunction('BlazorDevExtreme.DxLookup.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    if (options.onPageLoadingEnabled) {
        options.onPageLoading = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxLookup", "OnPageLoading");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onPullRefreshEnabled) {
        options.onPullRefresh = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxLookup", "OnPullRefresh");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onScrollEnabled) {
        options.onScroll = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxLookup", "OnScroll");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onTitleRenderedEnabled) {
        options.onTitleRendered = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxLookup", "OnTitleRendered");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onValueChangedEnabled) {
        options.onValueChanged = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxLookup", "OnValueChanged");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    $(identifier).dxLookup(options);
});
Blazor.registerFunction('BlazorDevExtreme.DxMap.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    if (options.onClickEnabled) {
        options.onClick = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxMap", "OnClick");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onMarkerAddedEnabled) {
        options.onMarkerAdded = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxMap", "OnMarkerAdded");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onMarkerRemovedEnabled) {
        options.onMarkerRemoved = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxMap", "OnMarkerRemoved");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onReadyEnabled) {
        options.onReady = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxMap", "OnReady");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onRouteAddedEnabled) {
        options.onRouteAdded = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxMap", "OnRouteAdded");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onRouteRemovedEnabled) {
        options.onRouteRemoved = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxMap", "OnRouteRemoved");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    $(identifier).dxMap(options);
});
Blazor.registerFunction('BlazorDevExtreme.DxMenu.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    if (options.onSubmenuHiddenEnabled) {
        options.onSubmenuHidden = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxMenu", "OnSubmenuHidden");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onSubmenuHidingEnabled) {
        options.onSubmenuHiding = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxMenu", "OnSubmenuHiding");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onSubmenuShowingEnabled) {
        options.onSubmenuShowing = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxMenu", "OnSubmenuShowing");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onSubmenuShownEnabled) {
        options.onSubmenuShown = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxMenu", "OnSubmenuShown");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    $(identifier).dxMenu(options);
});
Blazor.registerFunction('BlazorDevExtreme.DxMultiView.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    $(identifier).dxMultiView(options);
});
Blazor.registerFunction('BlazorDevExtreme.DxNavBar.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    $(identifier).dxNavBar(options);
});
Blazor.registerFunction('BlazorDevExtreme.DxNumberBox.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    $(identifier).dxNumberBox(options);
});
Blazor.registerFunction('BlazorDevExtreme.DxPanorama.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    $(identifier).dxPanorama(options);
});
Blazor.registerFunction('BlazorDevExtreme.DxPivot.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    $(identifier).dxPivot(options);
});
Blazor.registerFunction('BlazorDevExtreme.DxPivotGrid.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    if (options.onCellClickEnabled) {
        options.onCellClick = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxPivotGrid", "OnCellClick");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onCellPreparedEnabled) {
        options.onCellPrepared = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxPivotGrid", "OnCellPrepared");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onContextMenuPreparingEnabled) {
        options.onContextMenuPreparing = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxPivotGrid", "OnContextMenuPreparing");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onExportedEnabled) {
        options.onExported = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxPivotGrid", "OnExported");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onExportingEnabled) {
        options.onExporting = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxPivotGrid", "OnExporting");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onFileSavingEnabled) {
        options.onFileSaving = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxPivotGrid", "OnFileSaving");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    $(identifier).dxPivotGrid(options);
});
Blazor.registerFunction('BlazorDevExtreme.DxPivotGridFieldChooser.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    if (options.onContextMenuPreparingEnabled) {
        options.onContextMenuPreparing = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxPivotGridFieldChooser", "OnContextMenuPreparing");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    $(identifier).dxPivotGridFieldChooser(options);
});
Blazor.registerFunction('BlazorDevExtreme.DxPopover.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    $(identifier).dxPopover(options);
});
Blazor.registerFunction('BlazorDevExtreme.DxPopup.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    if (options.onResizeEnabled) {
        options.onResize = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxPopup", "OnResize");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onResizeEndEnabled) {
        options.onResizeEnd = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxPopup", "OnResizeEnd");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onResizeStartEnabled) {
        options.onResizeStart = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxPopup", "OnResizeStart");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onTitleRenderedEnabled) {
        options.onTitleRendered = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxPopup", "OnTitleRendered");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    $(identifier).dxPopup(options);
});
Blazor.registerFunction('BlazorDevExtreme.DxProgressBar.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    if (options.onCompleteEnabled) {
        options.onComplete = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxProgressBar", "OnComplete");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    $(identifier).dxProgressBar(options);
});
Blazor.registerFunction('BlazorDevExtreme.DxRadioGroup.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    $(identifier).dxRadioGroup(options);
});
Blazor.registerFunction('BlazorDevExtreme.DxRangeSlider.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    if (options.onValueChangedEnabled) {
        options.onValueChanged = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxRangeSlider", "OnValueChanged");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    $(identifier).dxRangeSlider(options);
});
Blazor.registerFunction('BlazorDevExtreme.DxResizable.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    if (options.onResizeEnabled) {
        options.onResize = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxResizable", "OnResize");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onResizeEndEnabled) {
        options.onResizeEnd = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxResizable", "OnResizeEnd");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onResizeStartEnabled) {
        options.onResizeStart = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxResizable", "OnResizeStart");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    $(identifier).dxResizable(options);
});
Blazor.registerFunction('BlazorDevExtreme.DxResponsiveBox.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    $(identifier).dxResponsiveBox(options);
});
Blazor.registerFunction('BlazorDevExtreme.DxScheduler.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    if (options.onAppointmentAddedEnabled) {
        options.onAppointmentAdded = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxScheduler", "OnAppointmentAdded");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onAppointmentAddingEnabled) {
        options.onAppointmentAdding = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxScheduler", "OnAppointmentAdding");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onAppointmentClickEnabled) {
        options.onAppointmentClick = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxScheduler", "OnAppointmentClick");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onAppointmentContextMenuEnabled) {
        options.onAppointmentContextMenu = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxScheduler", "OnAppointmentContextMenu");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onAppointmentDblClickEnabled) {
        options.onAppointmentDblClick = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxScheduler", "OnAppointmentDblClick");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onAppointmentDeletedEnabled) {
        options.onAppointmentDeleted = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxScheduler", "OnAppointmentDeleted");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onAppointmentDeletingEnabled) {
        options.onAppointmentDeleting = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxScheduler", "OnAppointmentDeleting");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onAppointmentFormCreatedEnabled) {
        options.onAppointmentFormCreated = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxScheduler", "OnAppointmentFormCreated");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onAppointmentRenderedEnabled) {
        options.onAppointmentRendered = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxScheduler", "OnAppointmentRendered");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onAppointmentUpdatedEnabled) {
        options.onAppointmentUpdated = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxScheduler", "OnAppointmentUpdated");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onAppointmentUpdatingEnabled) {
        options.onAppointmentUpdating = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxScheduler", "OnAppointmentUpdating");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onCellClickEnabled) {
        options.onCellClick = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxScheduler", "OnCellClick");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onCellContextMenuEnabled) {
        options.onCellContextMenu = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxScheduler", "OnCellContextMenu");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    $(identifier).dxScheduler(options);
});
Blazor.registerFunction('BlazorDevExtreme.DxScrollView.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    if (options.onPullDownEnabled) {
        options.onPullDown = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxScrollView", "OnPullDown");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onReachBottomEnabled) {
        options.onReachBottom = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxScrollView", "OnReachBottom");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    $(identifier).dxScrollView(options);
});
Blazor.registerFunction('BlazorDevExtreme.DxSelectBox.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    if (options.onCustomItemCreatingEnabled) {
        options.onCustomItemCreating = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxSelectBox", "OnCustomItemCreating");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    $(identifier).dxSelectBox(options);
});
Blazor.registerFunction('BlazorDevExtreme.DxSlideOut.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    if (options.onMenuGroupRenderedEnabled) {
        options.onMenuGroupRendered = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxSlideOut", "OnMenuGroupRendered");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onMenuItemRenderedEnabled) {
        options.onMenuItemRendered = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxSlideOut", "OnMenuItemRendered");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    $(identifier).dxSlideOut(options);
});
Blazor.registerFunction('BlazorDevExtreme.DxSlideOutView.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    $(identifier).dxSlideOutView(options);
});
Blazor.registerFunction('BlazorDevExtreme.DxSlider.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    $(identifier).dxSlider(options);
});
Blazor.registerFunction('BlazorDevExtreme.DxSwitch.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    $(identifier).dxSwitch(options);
});
Blazor.registerFunction('BlazorDevExtreme.DxTabPanel.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    if (options.onTitleClickEnabled) {
        options.onTitleClick = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxTabPanel", "OnTitleClick");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onTitleHoldEnabled) {
        options.onTitleHold = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxTabPanel", "OnTitleHold");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onTitleRenderedEnabled) {
        options.onTitleRendered = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxTabPanel", "OnTitleRendered");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    $(identifier).dxTabPanel(options);
});
Blazor.registerFunction('BlazorDevExtreme.DxTabs.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    $(identifier).dxTabs(options);
});
Blazor.registerFunction('BlazorDevExtreme.DxTagBox.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    if (options.onMultiTagPreparingEnabled) {
        options.onMultiTagPreparing = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxTagBox", "OnMultiTagPreparing");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onSelectAllValueChangedEnabled) {
        options.onSelectAllValueChanged = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxTagBox", "OnSelectAllValueChanged");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onSelectionChangedEnabled) {
        options.onSelectionChanged = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxTagBox", "OnSelectionChanged");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    $(identifier).dxTagBox(options);
});
Blazor.registerFunction('BlazorDevExtreme.DxTextArea.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    $(identifier).dxTextArea(options);
});
Blazor.registerFunction('BlazorDevExtreme.DxTextBox.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    $(identifier).dxTextBox(options);
});
Blazor.registerFunction('BlazorDevExtreme.DxTileView.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    $(identifier).dxTileView(options);
});
Blazor.registerFunction('BlazorDevExtreme.DxToast.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    $(identifier).dxToast(options);
});
Blazor.registerFunction('BlazorDevExtreme.DxToolbar.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    $(identifier).dxToolbar(options);
});
Blazor.registerFunction('BlazorDevExtreme.DxTooltip.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    $(identifier).dxTooltip(options);
});
Blazor.registerFunction('BlazorDevExtreme.DxTreeList.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    if (options.onCellClickEnabled) {
        options.onCellClick = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxTreeList", "OnCellClick");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onCellHoverChangedEnabled) {
        options.onCellHoverChanged = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxTreeList", "OnCellHoverChanged");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onCellPreparedEnabled) {
        options.onCellPrepared = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxTreeList", "OnCellPrepared");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onContextMenuPreparingEnabled) {
        options.onContextMenuPreparing = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxTreeList", "OnContextMenuPreparing");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onEditingStartEnabled) {
        options.onEditingStart = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxTreeList", "OnEditingStart");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onEditorPreparedEnabled) {
        options.onEditorPrepared = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxTreeList", "OnEditorPrepared");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onEditorPreparingEnabled) {
        options.onEditorPreparing = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxTreeList", "OnEditorPreparing");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onNodesInitializedEnabled) {
        options.onNodesInitialized = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxTreeList", "OnNodesInitialized");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onRowClickEnabled) {
        options.onRowClick = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxTreeList", "OnRowClick");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onRowPreparedEnabled) {
        options.onRowPrepared = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxTreeList", "OnRowPrepared");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    $(identifier).dxTreeList(options);
});
Blazor.registerFunction('BlazorDevExtreme.DxTreeView.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    if (options.onItemClickEnabled) {
        options.onItemClick = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxTreeView", "OnItemClick");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onItemCollapsedEnabled) {
        options.onItemCollapsed = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxTreeView", "OnItemCollapsed");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onItemContextMenuEnabled) {
        options.onItemContextMenu = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxTreeView", "OnItemContextMenu");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onItemExpandedEnabled) {
        options.onItemExpanded = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxTreeView", "OnItemExpanded");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onItemHoldEnabled) {
        options.onItemHold = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxTreeView", "OnItemHold");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onItemRenderedEnabled) {
        options.onItemRendered = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxTreeView", "OnItemRendered");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onItemSelectionChangedEnabled) {
        options.onItemSelectionChanged = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxTreeView", "OnItemSelectionChanged");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onSelectionChangedEnabled) {
        options.onSelectionChanged = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxTreeView", "OnSelectionChanged");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    $(identifier).dxTreeView(options);
});
Blazor.registerFunction('BlazorDevExtreme.DxValidationGroup.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    $(identifier).dxValidationGroup(options);
});
Blazor.registerFunction('BlazorDevExtreme.DxValidationSummary.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    $(identifier).dxValidationSummary(options);
});
Blazor.registerFunction('BlazorDevExtreme.DxValidator.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    if (options.onValidatedEnabled) {
        options.onValidated = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxValidator", "OnValidated");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    $(identifier).dxValidator(options);
});
Blazor.registerFunction('BlazorDevExtreme.DxBarGauge.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    if (options.onTooltipHiddenEnabled) {
        options.onTooltipHidden = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxBarGauge", "OnTooltipHidden");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onTooltipShownEnabled) {
        options.onTooltipShown = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxBarGauge", "OnTooltipShown");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    $(identifier).dxBarGauge(options);
});
Blazor.registerFunction('BlazorDevExtreme.DxBullet.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    $(identifier).dxBullet(options);
});
Blazor.registerFunction('BlazorDevExtreme.DxChart.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    if (options.onArgumentAxisClickEnabled) {
        options.onArgumentAxisClick = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxChart", "OnArgumentAxisClick");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onLegendClickEnabled) {
        options.onLegendClick = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxChart", "OnLegendClick");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onSeriesClickEnabled) {
        options.onSeriesClick = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxChart", "OnSeriesClick");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onSeriesHoverChangedEnabled) {
        options.onSeriesHoverChanged = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxChart", "OnSeriesHoverChanged");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onSeriesSelectionChangedEnabled) {
        options.onSeriesSelectionChanged = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxChart", "OnSeriesSelectionChanged");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onZoomEndEnabled) {
        options.onZoomEnd = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxChart", "OnZoomEnd");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onZoomStartEnabled) {
        options.onZoomStart = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxChart", "OnZoomStart");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    $(identifier).dxChart(options);
});
Blazor.registerFunction('BlazorDevExtreme.DxCircularGauge.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    $(identifier).dxCircularGauge(options);
});
Blazor.registerFunction('BlazorDevExtreme.DxFunnel.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    if (options.onHoverChangedEnabled) {
        options.onHoverChanged = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxFunnel", "OnHoverChanged");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onItemClickEnabled) {
        options.onItemClick = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxFunnel", "OnItemClick");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onLegendClickEnabled) {
        options.onLegendClick = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxFunnel", "OnLegendClick");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onSelectionChangedEnabled) {
        options.onSelectionChanged = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxFunnel", "OnSelectionChanged");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    $(identifier).dxFunnel(options);
});
Blazor.registerFunction('BlazorDevExtreme.DxLinearGauge.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    $(identifier).dxLinearGauge(options);
});
Blazor.registerFunction('BlazorDevExtreme.DxPieChart.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    if (options.onLegendClickEnabled) {
        options.onLegendClick = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxPieChart", "OnLegendClick");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    $(identifier).dxPieChart(options);
});
Blazor.registerFunction('BlazorDevExtreme.DxPolarChart.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    if (options.onArgumentAxisClickEnabled) {
        options.onArgumentAxisClick = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxPolarChart", "OnArgumentAxisClick");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onLegendClickEnabled) {
        options.onLegendClick = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxPolarChart", "OnLegendClick");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onSeriesClickEnabled) {
        options.onSeriesClick = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxPolarChart", "OnSeriesClick");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onSeriesHoverChangedEnabled) {
        options.onSeriesHoverChanged = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxPolarChart", "OnSeriesHoverChanged");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onSeriesSelectionChangedEnabled) {
        options.onSeriesSelectionChanged = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxPolarChart", "OnSeriesSelectionChanged");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    $(identifier).dxPolarChart(options);
});
Blazor.registerFunction('BlazorDevExtreme.DxRangeSelector.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    if (options.onSelectedRangeChangedEnabled) {
        options.onSelectedRangeChanged = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxRangeSelector", "OnSelectedRangeChanged");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onValueChangedEnabled) {
        options.onValueChanged = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxRangeSelector", "OnValueChanged");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    $(identifier).dxRangeSelector(options);
});
Blazor.registerFunction('BlazorDevExtreme.DxSparkline.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    $(identifier).dxSparkline(options);
});
Blazor.registerFunction('BlazorDevExtreme.DxTreeMap.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    if (options.onClickEnabled) {
        options.onClick = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxTreeMap", "OnClick");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onDrillEnabled) {
        options.onDrill = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxTreeMap", "OnDrill");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onHoverChangedEnabled) {
        options.onHoverChanged = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxTreeMap", "OnHoverChanged");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onNodesInitializedEnabled) {
        options.onNodesInitialized = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxTreeMap", "OnNodesInitialized");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onNodesRenderingEnabled) {
        options.onNodesRendering = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxTreeMap", "OnNodesRendering");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onSelectionChangedEnabled) {
        options.onSelectionChanged = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxTreeMap", "OnSelectionChanged");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    $(identifier).dxTreeMap(options);
});
Blazor.registerFunction('BlazorDevExtreme.DxVectorMap.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    if (options.onAreaClickEnabled) {
        options.onAreaClick = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxVectorMap", "OnAreaClick");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onAreaSelectionChangedEnabled) {
        options.onAreaSelectionChanged = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxVectorMap", "OnAreaSelectionChanged");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onCenterChangedEnabled) {
        options.onCenterChanged = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxVectorMap", "OnCenterChanged");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onClickEnabled) {
        options.onClick = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxVectorMap", "OnClick");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onMarkerClickEnabled) {
        options.onMarkerClick = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxVectorMap", "OnMarkerClick");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onMarkerSelectionChangedEnabled) {
        options.onMarkerSelectionChanged = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxVectorMap", "OnMarkerSelectionChanged");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onSelectionChangedEnabled) {
        options.onSelectionChanged = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxVectorMap", "OnSelectionChanged");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onTooltipHiddenEnabled) {
        options.onTooltipHidden = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxVectorMap", "OnTooltipHidden");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onTooltipShownEnabled) {
        options.onTooltipShown = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxVectorMap", "OnTooltipShown");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    if (options.onZoomFactorChangedEnabled) {
        options.onZoomFactorChanged = function () {
            const callback = Blazor.platform.findMethod(assemblyName, namespace, "DxVectorMap", "OnZoomFactorChanged");
            Blazor.platform.callMethod(callback, null, [Blazor.platform.toDotNetString(identifier)]);
        }
    }
    $(identifier).dxVectorMap(options);
});