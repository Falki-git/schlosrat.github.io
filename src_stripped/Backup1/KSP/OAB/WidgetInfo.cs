﻿// Decompiled with JetBrains decompiler
// Type: KSP.OAB.WidgetInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.OAB
{
  public class WidgetInfo
  {
    private WidgetInfoTransitionAction _transitionAction;
    private bool _isOnScreen;
    private RectTransform _rectTransform;
    private float _onScreenX;
    private float _onScreenY;
    private float _offScreenX;
    private float _lerpT;
    private float _lerpDT;
    private float _speed;
    private GameObject _obj;
    private CanvasGroup _canvasGroup;
    public Action OnWidgetShow;
    public Action OnWidgetHide;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public WidgetInfo(
      GameObject o,
      WidgetInfoTransitionAction transitionAction,
      Action onWidgetShow = null,
      Action onWidgetHide = null)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public GameObject GetObject() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetSpeed(float speed) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void GoOffscreen(bool immediate = false) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void GoOnscreen(bool immediate = false) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateAction() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateCanvasAlpha() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdatePos() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsOnScreen() => throw null;
  }
}
