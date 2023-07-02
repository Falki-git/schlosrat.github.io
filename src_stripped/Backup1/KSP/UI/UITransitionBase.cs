﻿// Decompiled with JetBrains decompiler
// Type: KSP.UI.UITransitionBase
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.UI
{
  public abstract class UITransitionBase : MonoBehaviour
  {
    public RectTransform panelTransform;
    public UITransitionBase.Method method;
    protected Callback<float, Vector2, Vector2> PrepMethod;
    protected Func<float, Vector2, Vector2, Vector2> TransitionMethod;
    [SerializeField]
    private CanvasGroup ctrlGroup;
    private Vector2 vStep;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected void Linear_Pre(float transitionTime, Vector2 vCrr, Vector2 vTgt) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected Vector2 Linear_Transition(float t, Vector2 vCrr, Vector2 vTgt) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected void Lerp_Pre(float transitionTime, Vector2 vCrr, Vector2 vTgt) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected Vector2 Lerp_Transition(float t, Vector2 vCrr, Vector2 vTgt) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected void SetMethod(UITransitionBase.Method m) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected void SetInteractable(bool interactable) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected UITransitionBase() => throw null;

    public enum Method
    {
      Linear,
      Lerp,
    }
  }
}
