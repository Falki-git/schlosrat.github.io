﻿// Decompiled with JetBrains decompiler
// Type: KSP.UI.FlyoutExtendedEventVisualizer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using DG.Tweening;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace KSP.UI
{
  [RequireComponent(typeof (Flyout))]
  public class FlyoutExtendedEventVisualizer : SelectableExtendedVisualizer
  {
    public AnimationTriggers DataAnimationTriggers;
    private Flyout flyout;
    private DOTweenAnimation[] tweenAnimations;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnEnable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnDisable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void HandleStateChanged(SelectionState newState, bool isOpen) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void HandleAnimation(string triggerType) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void HandleStateTransition(
      SelectionState currentSelectionState,
      bool instant)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FlyoutExtendedEventVisualizer() => throw null;
  }
}
