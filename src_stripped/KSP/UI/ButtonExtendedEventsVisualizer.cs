﻿// Decompiled with JetBrains decompiler
// Type: KSP.UI.ButtonExtendedEventsVisualizer
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
  [RequireComponent(typeof (ButtonExtended))]
  public class ButtonExtendedEventsVisualizer : SelectableExtendedVisualizer
  {
    [Header("Button Animations")]
    public AnimationTriggers DataAnimationTriggers;
    private ButtonExtended button;
    private DOTweenAnimation[] tweenAnimations;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void HandleStateChanged(SelectionState newState, bool isOn) => throw null;

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
    public ButtonExtendedEventsVisualizer() => throw null;
  }
}
