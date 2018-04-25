const assemblyName = "BlazorDevExtreme";
const namespace = "BlazorDevExtreme";

// DevExpress.ui.dxAccordion interop automatically generated
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
Blazor.registerFunction('BlazorDevExtreme.DxAccordion.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.ui.dxAccordion.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.DxAccordion.GetOption', function (identifier, key) {
    let element = document.getElementById(identifier);
    return DevExpress.ui.dxAccordion.getInstance(element).option(key);
});
// DevExpress.ui.dxActionSheet interop automatically generated
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
Blazor.registerFunction('BlazorDevExtreme.DxActionSheet.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.ui.dxActionSheet.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.DxActionSheet.GetOption', function (identifier, key) {
    let element = document.getElementById(identifier);
    return DevExpress.ui.dxActionSheet.getInstance(element).option(key);
});
// DevExpress.ui.dxAutocomplete interop automatically generated
Blazor.registerFunction('BlazorDevExtreme.DxAutocomplete.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    let element = document.getElementById(identifier);
    let instance = new DevExpress.ui.dxAutocomplete(element, options);
});
Blazor.registerFunction('BlazorDevExtreme.DxAutocomplete.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.ui.dxAutocomplete.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.DxAutocomplete.GetOption', function (identifier, key) {
    let element = document.getElementById(identifier);
    return DevExpress.ui.dxAutocomplete.getInstance(element).option(key);
});
// DevExpress.ui.dxBox interop automatically generated
Blazor.registerFunction('BlazorDevExtreme.DxBox.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    let element = document.getElementById(identifier);
    let instance = new DevExpress.ui.dxBox(element, options);
});
Blazor.registerFunction('BlazorDevExtreme.DxBox.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.ui.dxBox.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.DxBox.GetOption', function (identifier, key) {
    let element = document.getElementById(identifier);
    return DevExpress.ui.dxBox.getInstance(element).option(key);
});
// DevExpress.ui.dxButton interop automatically generated
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
Blazor.registerFunction('BlazorDevExtreme.DxButton.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.ui.dxButton.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.DxButton.GetOption', function (identifier, key) {
    let element = document.getElementById(identifier);
    return DevExpress.ui.dxButton.getInstance(element).option(key);
});
// DevExpress.ui.dxCalendar interop automatically generated
Blazor.registerFunction('BlazorDevExtreme.DxCalendar.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    let element = document.getElementById(identifier);
    let instance = new DevExpress.ui.dxCalendar(element, options);
});
Blazor.registerFunction('BlazorDevExtreme.DxCalendar.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.ui.dxCalendar.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.DxCalendar.GetOption', function (identifier, key) {
    let element = document.getElementById(identifier);
    return DevExpress.ui.dxCalendar.getInstance(element).option(key);
});
// DevExpress.ui.dxCheckBox interop automatically generated
Blazor.registerFunction('BlazorDevExtreme.DxCheckBox.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    let element = document.getElementById(identifier);
    let instance = new DevExpress.ui.dxCheckBox(element, options);
});
Blazor.registerFunction('BlazorDevExtreme.DxCheckBox.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.ui.dxCheckBox.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.DxCheckBox.GetOption', function (identifier, key) {
    let element = document.getElementById(identifier);
    return DevExpress.ui.dxCheckBox.getInstance(element).option(key);
});
// DevExpress.ui.dxColorBox interop automatically generated
Blazor.registerFunction('BlazorDevExtreme.DxColorBox.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    let element = document.getElementById(identifier);
    let instance = new DevExpress.ui.dxColorBox(element, options);
});
Blazor.registerFunction('BlazorDevExtreme.DxColorBox.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.ui.dxColorBox.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.DxColorBox.GetOption', function (identifier, key) {
    let element = document.getElementById(identifier);
    return DevExpress.ui.dxColorBox.getInstance(element).option(key);
});
// DevExpress.ui.dxContextMenu interop automatically generated
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
Blazor.registerFunction('BlazorDevExtreme.DxContextMenu.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.ui.dxContextMenu.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.DxContextMenu.GetOption', function (identifier, key) {
    let element = document.getElementById(identifier);
    return DevExpress.ui.dxContextMenu.getInstance(element).option(key);
});
// DevExpress.ui.dxDataGrid interop automatically generated
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
Blazor.registerFunction('BlazorDevExtreme.DxDataGrid.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.ui.dxDataGrid.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.DxDataGrid.GetOption', function (identifier, key) {
    let element = document.getElementById(identifier);
    return DevExpress.ui.dxDataGrid.getInstance(element).option(key);
});
// DevExpress.ui.dxDateBox interop automatically generated
Blazor.registerFunction('BlazorDevExtreme.DxDateBox.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    let element = document.getElementById(identifier);
    let instance = new DevExpress.ui.dxDateBox(element, options);
});
Blazor.registerFunction('BlazorDevExtreme.DxDateBox.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.ui.dxDateBox.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.DxDateBox.GetOption', function (identifier, key) {
    let element = document.getElementById(identifier);
    return DevExpress.ui.dxDateBox.getInstance(element).option(key);
});
// DevExpress.ui.dxDeferRendering interop automatically generated
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
Blazor.registerFunction('BlazorDevExtreme.DxDeferRendering.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.ui.dxDeferRendering.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.DxDeferRendering.GetOption', function (identifier, key) {
    let element = document.getElementById(identifier);
    return DevExpress.ui.dxDeferRendering.getInstance(element).option(key);
});
// DevExpress.ui.dxDropDownBox interop automatically generated
Blazor.registerFunction('BlazorDevExtreme.DxDropDownBox.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    let element = document.getElementById(identifier);
    let instance = new DevExpress.ui.dxDropDownBox(element, options);
});
Blazor.registerFunction('BlazorDevExtreme.DxDropDownBox.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.ui.dxDropDownBox.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.DxDropDownBox.GetOption', function (identifier, key) {
    let element = document.getElementById(identifier);
    return DevExpress.ui.dxDropDownBox.getInstance(element).option(key);
});
// DevExpress.ui.dxFileUploader interop automatically generated
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
Blazor.registerFunction('BlazorDevExtreme.DxFileUploader.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.ui.dxFileUploader.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.DxFileUploader.GetOption', function (identifier, key) {
    let element = document.getElementById(identifier);
    return DevExpress.ui.dxFileUploader.getInstance(element).option(key);
});
// DevExpress.ui.dxFilterBuilder interop automatically generated
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
Blazor.registerFunction('BlazorDevExtreme.DxFilterBuilder.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.ui.dxFilterBuilder.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.DxFilterBuilder.GetOption', function (identifier, key) {
    let element = document.getElementById(identifier);
    return DevExpress.ui.dxFilterBuilder.getInstance(element).option(key);
});
// DevExpress.ui.dxForm interop automatically generated
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
Blazor.registerFunction('BlazorDevExtreme.DxForm.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.ui.dxForm.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.DxForm.GetOption', function (identifier, key) {
    let element = document.getElementById(identifier);
    return DevExpress.ui.dxForm.getInstance(element).option(key);
});
// DevExpress.ui.dxGallery interop automatically generated
Blazor.registerFunction('BlazorDevExtreme.DxGallery.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    let element = document.getElementById(identifier);
    let instance = new DevExpress.ui.dxGallery(element, options);
});
Blazor.registerFunction('BlazorDevExtreme.DxGallery.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.ui.dxGallery.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.DxGallery.GetOption', function (identifier, key) {
    let element = document.getElementById(identifier);
    return DevExpress.ui.dxGallery.getInstance(element).option(key);
});
// DevExpress.ui.dxList interop automatically generated
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
Blazor.registerFunction('BlazorDevExtreme.DxList.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.ui.dxList.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.DxList.GetOption', function (identifier, key) {
    let element = document.getElementById(identifier);
    return DevExpress.ui.dxList.getInstance(element).option(key);
});
// DevExpress.ui.dxLoadIndicator interop automatically generated
Blazor.registerFunction('BlazorDevExtreme.DxLoadIndicator.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    let element = document.getElementById(identifier);
    let instance = new DevExpress.ui.dxLoadIndicator(element, options);
});
Blazor.registerFunction('BlazorDevExtreme.DxLoadIndicator.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.ui.dxLoadIndicator.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.DxLoadIndicator.GetOption', function (identifier, key) {
    let element = document.getElementById(identifier);
    return DevExpress.ui.dxLoadIndicator.getInstance(element).option(key);
});
// DevExpress.ui.dxLoadPanel interop automatically generated
Blazor.registerFunction('BlazorDevExtreme.DxLoadPanel.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    let element = document.getElementById(identifier);
    let instance = new DevExpress.ui.dxLoadPanel(element, options);
});
Blazor.registerFunction('BlazorDevExtreme.DxLoadPanel.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.ui.dxLoadPanel.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.DxLoadPanel.GetOption', function (identifier, key) {
    let element = document.getElementById(identifier);
    return DevExpress.ui.dxLoadPanel.getInstance(element).option(key);
});
// DevExpress.ui.dxLookup interop automatically generated
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
Blazor.registerFunction('BlazorDevExtreme.DxLookup.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.ui.dxLookup.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.DxLookup.GetOption', function (identifier, key) {
    let element = document.getElementById(identifier);
    return DevExpress.ui.dxLookup.getInstance(element).option(key);
});
// DevExpress.ui.dxMap interop automatically generated
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
Blazor.registerFunction('BlazorDevExtreme.DxMap.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.ui.dxMap.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.DxMap.GetOption', function (identifier, key) {
    let element = document.getElementById(identifier);
    return DevExpress.ui.dxMap.getInstance(element).option(key);
});
// DevExpress.ui.dxMenu interop automatically generated
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
Blazor.registerFunction('BlazorDevExtreme.DxMenu.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.ui.dxMenu.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.DxMenu.GetOption', function (identifier, key) {
    let element = document.getElementById(identifier);
    return DevExpress.ui.dxMenu.getInstance(element).option(key);
});
// DevExpress.ui.dxMultiView interop automatically generated
Blazor.registerFunction('BlazorDevExtreme.DxMultiView.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    let element = document.getElementById(identifier);
    let instance = new DevExpress.ui.dxMultiView(element, options);
});
Blazor.registerFunction('BlazorDevExtreme.DxMultiView.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.ui.dxMultiView.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.DxMultiView.GetOption', function (identifier, key) {
    let element = document.getElementById(identifier);
    return DevExpress.ui.dxMultiView.getInstance(element).option(key);
});
// DevExpress.ui.dxNavBar interop automatically generated
Blazor.registerFunction('BlazorDevExtreme.DxNavBar.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    let element = document.getElementById(identifier);
    let instance = new DevExpress.ui.dxNavBar(element, options);
});
Blazor.registerFunction('BlazorDevExtreme.DxNavBar.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.ui.dxNavBar.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.DxNavBar.GetOption', function (identifier, key) {
    let element = document.getElementById(identifier);
    return DevExpress.ui.dxNavBar.getInstance(element).option(key);
});
// DevExpress.ui.dxNumberBox interop automatically generated
Blazor.registerFunction('BlazorDevExtreme.DxNumberBox.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    let element = document.getElementById(identifier);
    let instance = new DevExpress.ui.dxNumberBox(element, options);
});
Blazor.registerFunction('BlazorDevExtreme.DxNumberBox.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.ui.dxNumberBox.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.DxNumberBox.GetOption', function (identifier, key) {
    let element = document.getElementById(identifier);
    return DevExpress.ui.dxNumberBox.getInstance(element).option(key);
});
// DevExpress.ui.dxPanorama interop automatically generated
Blazor.registerFunction('BlazorDevExtreme.DxPanorama.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    let element = document.getElementById(identifier);
    let instance = new DevExpress.ui.dxPanorama(element, options);
});
Blazor.registerFunction('BlazorDevExtreme.DxPanorama.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.ui.dxPanorama.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.DxPanorama.GetOption', function (identifier, key) {
    let element = document.getElementById(identifier);
    return DevExpress.ui.dxPanorama.getInstance(element).option(key);
});
// DevExpress.ui.dxPivot interop automatically generated
Blazor.registerFunction('BlazorDevExtreme.DxPivot.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    let element = document.getElementById(identifier);
    let instance = new DevExpress.ui.dxPivot(element, options);
});
Blazor.registerFunction('BlazorDevExtreme.DxPivot.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.ui.dxPivot.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.DxPivot.GetOption', function (identifier, key) {
    let element = document.getElementById(identifier);
    return DevExpress.ui.dxPivot.getInstance(element).option(key);
});
// DevExpress.ui.dxPivotGrid interop automatically generated
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
Blazor.registerFunction('BlazorDevExtreme.DxPivotGrid.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.ui.dxPivotGrid.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.DxPivotGrid.GetOption', function (identifier, key) {
    let element = document.getElementById(identifier);
    return DevExpress.ui.dxPivotGrid.getInstance(element).option(key);
});
// DevExpress.ui.dxPivotGridFieldChooser interop automatically generated
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
Blazor.registerFunction('BlazorDevExtreme.DxPivotGridFieldChooser.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.ui.dxPivotGridFieldChooser.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.DxPivotGridFieldChooser.GetOption', function (identifier, key) {
    let element = document.getElementById(identifier);
    return DevExpress.ui.dxPivotGridFieldChooser.getInstance(element).option(key);
});
// DevExpress.ui.dxPopover interop automatically generated
Blazor.registerFunction('BlazorDevExtreme.DxPopover.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    let element = document.getElementById(identifier);
    let instance = new DevExpress.ui.dxPopover(element, options);
});
Blazor.registerFunction('BlazorDevExtreme.DxPopover.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.ui.dxPopover.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.DxPopover.GetOption', function (identifier, key) {
    let element = document.getElementById(identifier);
    return DevExpress.ui.dxPopover.getInstance(element).option(key);
});
// DevExpress.ui.dxPopup interop automatically generated
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
Blazor.registerFunction('BlazorDevExtreme.DxPopup.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.ui.dxPopup.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.DxPopup.GetOption', function (identifier, key) {
    let element = document.getElementById(identifier);
    return DevExpress.ui.dxPopup.getInstance(element).option(key);
});
// DevExpress.ui.dxProgressBar interop automatically generated
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
Blazor.registerFunction('BlazorDevExtreme.DxProgressBar.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.ui.dxProgressBar.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.DxProgressBar.GetOption', function (identifier, key) {
    let element = document.getElementById(identifier);
    return DevExpress.ui.dxProgressBar.getInstance(element).option(key);
});
// DevExpress.ui.dxRadioGroup interop automatically generated
Blazor.registerFunction('BlazorDevExtreme.DxRadioGroup.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    let element = document.getElementById(identifier);
    let instance = new DevExpress.ui.dxRadioGroup(element, options);
});
Blazor.registerFunction('BlazorDevExtreme.DxRadioGroup.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.ui.dxRadioGroup.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.DxRadioGroup.GetOption', function (identifier, key) {
    let element = document.getElementById(identifier);
    return DevExpress.ui.dxRadioGroup.getInstance(element).option(key);
});
// DevExpress.ui.dxRangeSlider interop automatically generated
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
Blazor.registerFunction('BlazorDevExtreme.DxRangeSlider.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.ui.dxRangeSlider.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.DxRangeSlider.GetOption', function (identifier, key) {
    let element = document.getElementById(identifier);
    return DevExpress.ui.dxRangeSlider.getInstance(element).option(key);
});
// DevExpress.ui.dxResizable interop automatically generated
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
Blazor.registerFunction('BlazorDevExtreme.DxResizable.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.ui.dxResizable.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.DxResizable.GetOption', function (identifier, key) {
    let element = document.getElementById(identifier);
    return DevExpress.ui.dxResizable.getInstance(element).option(key);
});
// DevExpress.ui.dxResponsiveBox interop automatically generated
Blazor.registerFunction('BlazorDevExtreme.DxResponsiveBox.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    let element = document.getElementById(identifier);
    let instance = new DevExpress.ui.dxResponsiveBox(element, options);
});
Blazor.registerFunction('BlazorDevExtreme.DxResponsiveBox.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.ui.dxResponsiveBox.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.DxResponsiveBox.GetOption', function (identifier, key) {
    let element = document.getElementById(identifier);
    return DevExpress.ui.dxResponsiveBox.getInstance(element).option(key);
});
// DevExpress.ui.dxScheduler interop automatically generated
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
Blazor.registerFunction('BlazorDevExtreme.DxScheduler.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.ui.dxScheduler.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.DxScheduler.GetOption', function (identifier, key) {
    let element = document.getElementById(identifier);
    return DevExpress.ui.dxScheduler.getInstance(element).option(key);
});
// DevExpress.ui.dxScrollView interop automatically generated
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
Blazor.registerFunction('BlazorDevExtreme.DxScrollView.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.ui.dxScrollView.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.DxScrollView.GetOption', function (identifier, key) {
    let element = document.getElementById(identifier);
    return DevExpress.ui.dxScrollView.getInstance(element).option(key);
});
// DevExpress.ui.dxSelectBox interop automatically generated
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
Blazor.registerFunction('BlazorDevExtreme.DxSelectBox.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.ui.dxSelectBox.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.DxSelectBox.GetOption', function (identifier, key) {
    let element = document.getElementById(identifier);
    return DevExpress.ui.dxSelectBox.getInstance(element).option(key);
});
// DevExpress.ui.dxSlideOut interop automatically generated
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
Blazor.registerFunction('BlazorDevExtreme.DxSlideOut.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.ui.dxSlideOut.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.DxSlideOut.GetOption', function (identifier, key) {
    let element = document.getElementById(identifier);
    return DevExpress.ui.dxSlideOut.getInstance(element).option(key);
});
// DevExpress.ui.dxSlideOutView interop automatically generated
Blazor.registerFunction('BlazorDevExtreme.DxSlideOutView.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    let element = document.getElementById(identifier);
    let instance = new DevExpress.ui.dxSlideOutView(element, options);
});
Blazor.registerFunction('BlazorDevExtreme.DxSlideOutView.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.ui.dxSlideOutView.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.DxSlideOutView.GetOption', function (identifier, key) {
    let element = document.getElementById(identifier);
    return DevExpress.ui.dxSlideOutView.getInstance(element).option(key);
});
// DevExpress.ui.dxSlider interop automatically generated
Blazor.registerFunction('BlazorDevExtreme.DxSlider.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    let element = document.getElementById(identifier);
    let instance = new DevExpress.ui.dxSlider(element, options);
});
Blazor.registerFunction('BlazorDevExtreme.DxSlider.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.ui.dxSlider.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.DxSlider.GetOption', function (identifier, key) {
    let element = document.getElementById(identifier);
    return DevExpress.ui.dxSlider.getInstance(element).option(key);
});
// DevExpress.ui.dxSwitch interop automatically generated
Blazor.registerFunction('BlazorDevExtreme.DxSwitch.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    let element = document.getElementById(identifier);
    let instance = new DevExpress.ui.dxSwitch(element, options);
});
Blazor.registerFunction('BlazorDevExtreme.DxSwitch.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.ui.dxSwitch.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.DxSwitch.GetOption', function (identifier, key) {
    let element = document.getElementById(identifier);
    return DevExpress.ui.dxSwitch.getInstance(element).option(key);
});
// DevExpress.ui.dxTabPanel interop automatically generated
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
Blazor.registerFunction('BlazorDevExtreme.DxTabPanel.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.ui.dxTabPanel.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.DxTabPanel.GetOption', function (identifier, key) {
    let element = document.getElementById(identifier);
    return DevExpress.ui.dxTabPanel.getInstance(element).option(key);
});
// DevExpress.ui.dxTabs interop automatically generated
Blazor.registerFunction('BlazorDevExtreme.DxTabs.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    let element = document.getElementById(identifier);
    let instance = new DevExpress.ui.dxTabs(element, options);
});
Blazor.registerFunction('BlazorDevExtreme.DxTabs.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.ui.dxTabs.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.DxTabs.GetOption', function (identifier, key) {
    let element = document.getElementById(identifier);
    return DevExpress.ui.dxTabs.getInstance(element).option(key);
});
// DevExpress.ui.dxTagBox interop automatically generated
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
Blazor.registerFunction('BlazorDevExtreme.DxTagBox.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.ui.dxTagBox.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.DxTagBox.GetOption', function (identifier, key) {
    let element = document.getElementById(identifier);
    return DevExpress.ui.dxTagBox.getInstance(element).option(key);
});
// DevExpress.ui.dxTextArea interop automatically generated
Blazor.registerFunction('BlazorDevExtreme.DxTextArea.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    let element = document.getElementById(identifier);
    let instance = new DevExpress.ui.dxTextArea(element, options);
});
Blazor.registerFunction('BlazorDevExtreme.DxTextArea.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.ui.dxTextArea.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.DxTextArea.GetOption', function (identifier, key) {
    let element = document.getElementById(identifier);
    return DevExpress.ui.dxTextArea.getInstance(element).option(key);
});
// DevExpress.ui.dxTextBox interop automatically generated
Blazor.registerFunction('BlazorDevExtreme.DxTextBox.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    let element = document.getElementById(identifier);
    let instance = new DevExpress.ui.dxTextBox(element, options);
});
Blazor.registerFunction('BlazorDevExtreme.DxTextBox.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.ui.dxTextBox.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.DxTextBox.GetOption', function (identifier, key) {
    let element = document.getElementById(identifier);
    return DevExpress.ui.dxTextBox.getInstance(element).option(key);
});
// DevExpress.ui.dxTileView interop automatically generated
Blazor.registerFunction('BlazorDevExtreme.DxTileView.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    let element = document.getElementById(identifier);
    let instance = new DevExpress.ui.dxTileView(element, options);
});
Blazor.registerFunction('BlazorDevExtreme.DxTileView.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.ui.dxTileView.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.DxTileView.GetOption', function (identifier, key) {
    let element = document.getElementById(identifier);
    return DevExpress.ui.dxTileView.getInstance(element).option(key);
});
// DevExpress.ui.dxToast interop automatically generated
Blazor.registerFunction('BlazorDevExtreme.DxToast.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    let element = document.getElementById(identifier);
    let instance = new DevExpress.ui.dxToast(element, options);
});
Blazor.registerFunction('BlazorDevExtreme.DxToast.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.ui.dxToast.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.DxToast.GetOption', function (identifier, key) {
    let element = document.getElementById(identifier);
    return DevExpress.ui.dxToast.getInstance(element).option(key);
});
// DevExpress.ui.dxToolbar interop automatically generated
Blazor.registerFunction('BlazorDevExtreme.DxToolbar.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    let element = document.getElementById(identifier);
    let instance = new DevExpress.ui.dxToolbar(element, options);
});
Blazor.registerFunction('BlazorDevExtreme.DxToolbar.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.ui.dxToolbar.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.DxToolbar.GetOption', function (identifier, key) {
    let element = document.getElementById(identifier);
    return DevExpress.ui.dxToolbar.getInstance(element).option(key);
});
// DevExpress.ui.dxTooltip interop automatically generated
Blazor.registerFunction('BlazorDevExtreme.DxTooltip.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    let element = document.getElementById(identifier);
    let instance = new DevExpress.ui.dxTooltip(element, options);
});
Blazor.registerFunction('BlazorDevExtreme.DxTooltip.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.ui.dxTooltip.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.DxTooltip.GetOption', function (identifier, key) {
    let element = document.getElementById(identifier);
    return DevExpress.ui.dxTooltip.getInstance(element).option(key);
});
// DevExpress.ui.dxTreeList interop automatically generated
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
Blazor.registerFunction('BlazorDevExtreme.DxTreeList.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.ui.dxTreeList.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.DxTreeList.GetOption', function (identifier, key) {
    let element = document.getElementById(identifier);
    return DevExpress.ui.dxTreeList.getInstance(element).option(key);
});
// DevExpress.ui.dxTreeView interop automatically generated
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
Blazor.registerFunction('BlazorDevExtreme.DxTreeView.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.ui.dxTreeView.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.DxTreeView.GetOption', function (identifier, key) {
    let element = document.getElementById(identifier);
    return DevExpress.ui.dxTreeView.getInstance(element).option(key);
});
// DevExpress.ui.dxValidationGroup interop automatically generated
Blazor.registerFunction('BlazorDevExtreme.DxValidationGroup.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    let element = document.getElementById(identifier);
    let instance = new DevExpress.ui.dxValidationGroup(element, options);
});
Blazor.registerFunction('BlazorDevExtreme.DxValidationGroup.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.ui.dxValidationGroup.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.DxValidationGroup.GetOption', function (identifier, key) {
    let element = document.getElementById(identifier);
    return DevExpress.ui.dxValidationGroup.getInstance(element).option(key);
});
// DevExpress.ui.dxValidationSummary interop automatically generated
Blazor.registerFunction('BlazorDevExtreme.DxValidationSummary.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    let element = document.getElementById(identifier);
    let instance = new DevExpress.ui.dxValidationSummary(element, options);
});
Blazor.registerFunction('BlazorDevExtreme.DxValidationSummary.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.ui.dxValidationSummary.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.DxValidationSummary.GetOption', function (identifier, key) {
    let element = document.getElementById(identifier);
    return DevExpress.ui.dxValidationSummary.getInstance(element).option(key);
});
// DevExpress.ui.dxValidator interop automatically generated
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
Blazor.registerFunction('BlazorDevExtreme.DxValidator.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.ui.dxValidator.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.DxValidator.GetOption', function (identifier, key) {
    let element = document.getElementById(identifier);
    return DevExpress.ui.dxValidator.getInstance(element).option(key);
});
// DevExpress.viz.gauges.dxBarGauge interop automatically generated
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
Blazor.registerFunction('BlazorDevExtreme.DxBarGauge.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.viz.gauges.dxBarGauge.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.DxBarGauge.GetOption', function (identifier, key) {
    let element = document.getElementById(identifier);
    return DevExpress.viz.gauges.dxBarGauge.getInstance(element).option(key);
});
// DevExpress.viz.sparklines.dxBullet interop automatically generated
Blazor.registerFunction('BlazorDevExtreme.DxBullet.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    let element = document.getElementById(identifier);
    let instance = new DevExpress.viz.sparklines.dxBullet(element, options);
});
Blazor.registerFunction('BlazorDevExtreme.DxBullet.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.viz.sparklines.dxBullet.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.DxBullet.GetOption', function (identifier, key) {
    let element = document.getElementById(identifier);
    return DevExpress.viz.sparklines.dxBullet.getInstance(element).option(key);
});
// DevExpress.viz.charts.dxChart interop automatically generated
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
Blazor.registerFunction('BlazorDevExtreme.DxChart.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.viz.charts.dxChart.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.DxChart.GetOption', function (identifier, key) {
    let element = document.getElementById(identifier);
    return DevExpress.viz.charts.dxChart.getInstance(element).option(key);
});
// DevExpress.viz.gauges.dxCircularGauge interop automatically generated
Blazor.registerFunction('BlazorDevExtreme.DxCircularGauge.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    let element = document.getElementById(identifier);
    let instance = new DevExpress.viz.gauges.dxCircularGauge(element, options);
});
Blazor.registerFunction('BlazorDevExtreme.DxCircularGauge.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.viz.gauges.dxCircularGauge.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.DxCircularGauge.GetOption', function (identifier, key) {
    let element = document.getElementById(identifier);
    return DevExpress.viz.gauges.dxCircularGauge.getInstance(element).option(key);
});
// DevExpress.viz.funnel.dxFunnel interop automatically generated
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
Blazor.registerFunction('BlazorDevExtreme.DxFunnel.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.viz.funnel.dxFunnel.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.DxFunnel.GetOption', function (identifier, key) {
    let element = document.getElementById(identifier);
    return DevExpress.viz.funnel.dxFunnel.getInstance(element).option(key);
});
// DevExpress.viz.gauges.dxLinearGauge interop automatically generated
Blazor.registerFunction('BlazorDevExtreme.DxLinearGauge.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    let element = document.getElementById(identifier);
    let instance = new DevExpress.viz.gauges.dxLinearGauge(element, options);
});
Blazor.registerFunction('BlazorDevExtreme.DxLinearGauge.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.viz.gauges.dxLinearGauge.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.DxLinearGauge.GetOption', function (identifier, key) {
    let element = document.getElementById(identifier);
    return DevExpress.viz.gauges.dxLinearGauge.getInstance(element).option(key);
});
// DevExpress.viz.charts.dxPieChart interop automatically generated
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
Blazor.registerFunction('BlazorDevExtreme.DxPieChart.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.viz.charts.dxPieChart.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.DxPieChart.GetOption', function (identifier, key) {
    let element = document.getElementById(identifier);
    return DevExpress.viz.charts.dxPieChart.getInstance(element).option(key);
});
// DevExpress.viz.charts.dxPolarChart interop automatically generated
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
Blazor.registerFunction('BlazorDevExtreme.DxPolarChart.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.viz.charts.dxPolarChart.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.DxPolarChart.GetOption', function (identifier, key) {
    let element = document.getElementById(identifier);
    return DevExpress.viz.charts.dxPolarChart.getInstance(element).option(key);
});
// DevExpress.viz.rangeSelector.dxRangeSelector interop automatically generated
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
Blazor.registerFunction('BlazorDevExtreme.DxRangeSelector.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.viz.rangeSelector.dxRangeSelector.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.DxRangeSelector.GetOption', function (identifier, key) {
    let element = document.getElementById(identifier);
    return DevExpress.viz.rangeSelector.dxRangeSelector.getInstance(element).option(key);
});
// DevExpress.viz.sparklines.dxSparkline interop automatically generated
Blazor.registerFunction('BlazorDevExtreme.DxSparkline.Init', function (identifier, optionsText) {
    const options = JSON.parse(optionsText);

    let element = document.getElementById(identifier);
    let instance = new DevExpress.viz.sparklines.dxSparkline(element, options);
});
Blazor.registerFunction('BlazorDevExtreme.DxSparkline.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.viz.sparklines.dxSparkline.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.DxSparkline.GetOption', function (identifier, key) {
    let element = document.getElementById(identifier);
    return DevExpress.viz.sparklines.dxSparkline.getInstance(element).option(key);
});
// DevExpress.viz.treeMap.dxTreeMap interop automatically generated
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
Blazor.registerFunction('BlazorDevExtreme.DxTreeMap.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.viz.treeMap.dxTreeMap.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.DxTreeMap.GetOption', function (identifier, key) {
    let element = document.getElementById(identifier);
    return DevExpress.viz.treeMap.dxTreeMap.getInstance(element).option(key);
});
// DevExpress.viz.map.dxVectorMap interop automatically generated
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
Blazor.registerFunction('BlazorDevExtreme.DxVectorMap.SetOption', function (identifier, key, value) {
    let element = document.getElementById(identifier);
    DevExpress.viz.map.dxVectorMap.getInstance(element).option(key, value);
});
Blazor.registerFunction('BlazorDevExtreme.DxVectorMap.GetOption', function (identifier, key) {
    let element = document.getElementById(identifier);
    return DevExpress.viz.map.dxVectorMap.getInstance(element).option(key);
});
