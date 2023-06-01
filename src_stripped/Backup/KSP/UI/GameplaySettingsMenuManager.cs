﻿// Decompiled with JetBrains decompiler
// Type: KSP.UI.GameplaySettingsMenuManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Api.CoreTypes;
using KSP.UI.Binding;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.UI
{
  public class GameplaySettingsMenuManager : SettingsSubMenu
  {
    private const string MAX_PERSISTANT_DEBRIS_PROPERTY_KEY = "MaxPersistantDebris";
    private const string MAX_PATCHES_TO_DISPLAY_PROPERTY_KEY = "MaxPatchesToDisplay";
    private const string SKIP_LAUNCH_SEQUENCE_PROPERTY_KEY = "SkipLaunchSequence";
    private const string SHOW_FPS_PROPERTY_KEY = "ShowFPS";
    [SerializeField]
    private ContextBindRoot _bindRoot;
    private DataContext _dataContext;
    private Property<float> _maxPersistantDebris;
    private Property<float> _maxPatchesToDisplay;
    private Property<bool> _skipLaunchSequence;
    private Property<bool> _showFps;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Start() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void Revert() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void InitializeContextBinding() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnMaxDebrisChanged(float value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnConicPatchLimitChanged(float value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnLaunchSequenceChanged(bool value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnShowFPSChanged(bool value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ApplyMaxDebris(int selectionValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ApplyConicPatchLimit(int selectionValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ApplySkipLaunchSequence(bool selectionValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ApplyShowFPS(bool selectionValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public GameplaySettingsMenuManager() => throw null;
  }
}
