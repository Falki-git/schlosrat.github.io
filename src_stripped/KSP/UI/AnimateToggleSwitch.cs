﻿// Decompiled with JetBrains decompiler
// Type: KSP.UI.AnimateToggleSwitch
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using DG.Tweening;
using KSP.Game;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace KSP.UI
{
  public class AnimateToggleSwitch : KerbalMonoBehaviour
  {
    [SerializeField]
    private RectTransform toggleSwitch;
    [SerializeField]
    private RectTransform targetRect;
    [SerializeField]
    private ToggleExtended toggle;
    [SerializeField]
    private float animationTime;
    [Header("Animations")]
    [SerializeField]
    private DOTweenAnimation _toggleOn;
    [SerializeField]
    private DOTweenAnimation _toggleOff;
    private float _offPosition;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDestroy() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnToggleValueChanged(bool state) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void HandleValueChanged() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void HandleStateChanged(SelectionState newState, bool isOn) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void HandleToggleAnimation() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnAnimation() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OffAnimation() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public AnimateToggleSwitch() => throw null;
  }
}
