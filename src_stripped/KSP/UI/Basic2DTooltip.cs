﻿// Decompiled with JetBrains decompiler
// Type: KSP.UI.Basic2DTooltip
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using DG.Tweening;
using KSP.UI.Binding;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.UI
{
  public class Basic2DTooltip : ExtendedTooltip<BasicTextTooltipData>
  {
    private const string START_DELAYED_ANIMATION_KEY = "startDelayed";
    [SerializeField]
    private string _tooltipPrefabId;
    [SerializeField]
    private ContextBindRoot _bindRoot;
    [SerializeField]
    private RectTransform _contentRectTransform;
    private List<DOTweenAnimation> _tweenAnimations;

    public string TooltipPrefabId
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Start() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void UpdateTooltip() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void Configure(BasicTextTooltipData data) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void Show() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void Show(RectTransform targetRectTransform) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void HandleAnimation(string triggerType) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Basic2DTooltip() => throw null;
  }
}
