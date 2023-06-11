﻿using Robust.Client.AutoGenerated;
using Robust.Client.UserInterface.CustomControls;
using Robust.Client.UserInterface.XAML;
using Content.Shared.SS220.CryopodSSD;

namespace Content.Client.SS220.CryopodSSD;

[GenerateTypedNameReferences]
public sealed partial class CryopodSSDWindow : DefaultWindow
{
    public CryopodSSDWindow()
    {
        RobustXamlLoader.Load(this);
    }

    public void UpdateState(SSDStorageConsoleState storageConsoleState)
    {
        PopulateCryopodSSDRecords(storageConsoleState.CryopodSSDRecords);
    }

    private void PopulateCryopodSSDRecords(IEnumerable<string>? records)
    {
        CryopodSSDRecord.Clear();
        CryopodSSDRecord.ClearSelected();

        if (records is null)
        {
            return;
        }

        foreach (var record in records)
        {
            CryopodSSDRecord.AddItem(record);
        }
        
        CryopodSSDRecord.SortItemsByText();
    }
    
}