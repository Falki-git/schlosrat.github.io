﻿// Decompiled with JetBrains decompiler
// Type: KSP.OAB.ObjectAssemblyUIEvents
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.IO;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.OAB
{
  public class ObjectAssemblyUIEvents
  {
    public Action OnRefreshPartsPicker;
    [Obsolete("This action should no longer be used for updating UI - please implement actions specific to your use case")]
    [LogIgnore]
    public Action OnRefresh;
    public Action<IObjectAssemblyAvailablePart> OnCreatePart;
    public Action OnDeleteGrabbedParts;
    public Action OnUndo;
    public Action OnRedo;
    public Action OnExit;
    public Action OnNew;
    public Action<string, string, string, string, bool, IOProvider.DataLocation> OnSaveWorkspace;
    public Action<OABLoadDialogExistingSave> OnLoadWorkspace;
    public Action<OABLoadDialogExistingSave> OnMergeWorkspace;
    public Action<string, IOProvider.DataLocation> OnDeleteWorkspaceFile;
    public Action OnLaunch;
    public Action OnSaveDialogAfterWarning;
    public Action<bool> OnSetUIDeletionLock;
    public Action<string, RectTransform> OnShowTooltip;
    [LogIgnore]
    public Action OnHideTooltip;
    public Action<IObjectAssemblyAvailablePart, RectTransform> OnShowModal;
    [LogIgnore]
    public Action OnHideModal;
    public Action OnSetAssemblyAnchorButton;
    public Action OnSetLaunchAssemblyButton;
    public Action OnSetManipulatedPartButton;
    public Action OnSetColorButton;
    public Action<OABOrientation> OnSetOABOrientationMode;
    public Action<bool> OnPartsSearchFilterToggle;
    public Action<List<AssemblyPartsTechLevelFilter>> OnTechLevelFilterUpdated;
    public Action<List<AssemblyPartsFuelTypeFilter>> OnFuelTypeFilterUpdated;
    public Action<List<AssemblyPartsCostFilter>> OnCostFilterUpdated;
    public Action<List<AssemblyPartTypeFilter>> OnTypeFilterUpdated;
    public Action OnRevertTool;
    public Action OnColorPickerCancel;
    public Action<IObjectAssemblyPart, IReadOnlyList<IObjectAssemblyPart>> OnApplyColorToPart;
    public Action<IObjectAssemblyTool> OnToolReadyToRelease;
    public Action<Texture2D> OnCursorIconImageUpdated;
    public Action<bool, Vector2> OnCursorIconPositionUpdated;
    public Action<IObjectAssemblyAvailablePart> OnPartReload;
    public Action<bool, bool> OnStartOrthoTransition;
    public Action<bool, float, Quaternion> OnOrthoTransitionUpdated;
    public Action<float> OnOrthographicSizeChanged;
    public Action<float, float> OnOrthographicZoomChanged;
    public Action OnUserWorldRotateStart;
    public Action OnUserWorldRotateStop;
    public Action<bool> OnUserBlueprintToggle;
    public Action OnInitialVABUILoaded;
    public Action OnAssemblyBoundsStatusChange;
    public Action OnAssemblyResourceCostStatusChange;
    public Action<IObjectAssemblyPart, Vector3> OnRequestPartDeletionFX;
    public Action OnLanguageChange;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ObjectAssemblyUIEvents() => throw null;
  }
}
