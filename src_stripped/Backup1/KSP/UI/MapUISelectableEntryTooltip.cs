﻿// Decompiled with JetBrains decompiler
// Type: KSP.UI.MapUISelectableEntryTooltip
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using DG.Tweening;
using KSP.Api.CoreTypes;
using KSP.UI.Binding;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.UI
{
  [RequireComponent(typeof (CanvasGroup))]
  public class MapUISelectableEntryTooltip : ExtendedTooltip<MapUISelectableEntryTooltipData>
  {
    private const string PRIMARY_LINE_PROPERTY_KEY = "PrimaryLine";
    private const string SECONDARY_LINE_PROPERTY_KEY = "SecondaryLine";
    private const string START_DELAYED_ANIMATION_KEY = "startDelayed";
    [SerializeField]
    private ContextBindRoot _bindRoot;
    private DataContext _dataContext;
    private List<DOTweenAnimation> _tweenAnimations;
    private Property<string> _primaryLine;
    private Property<string> _secondaryLine;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Start() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void InitializeContextBinding() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateTooltipData() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void Show(RectTransform _targetRectTransform) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void HandleAnimation(string triggerType) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public MapUISelectableEntryTooltip() => throw null;
  }
}
