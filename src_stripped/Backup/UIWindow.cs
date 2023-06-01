﻿// Decompiled with JetBrains decompiler
// Type: UIWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;

public class UIWindow : MonoBehaviour
{
  public Vector2 minSize;
  public Vector2 maxSize;
  public bool maxSizeIsScreen;
  public float topBorder;
  public float bottomBorder;
  public float leftBorder;
  public float rightBorder;
  public bool invertTopBorder;
  public bool invertBottomBorder;
  public bool invertLeftBorder;
  public bool invertRightBorder;
  public Callback<RectTransform> OnWindowResize;
  public Callback<RectTransform> OnWindowMove;

  public RectTransform rectTransform
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Awake() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Start() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void OnDestroy() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void OnScreenResolutionModified(int width, int height) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void MoveWindow(PointerEventData data) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static void MoveRectTransform(RectTransform target, PointerEventData data) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void ResizeWindow(
    PointerEventData data,
    UIWindow.ResizeHeight resizeHeight,
    UIWindow.ResizeWidth resizeWidth)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static void ResizeRectTransform(
    RectTransform target,
    PointerEventData data,
    UIWindow.ResizeHeight resizeHeight,
    UIWindow.ResizeWidth resizeWidth)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void ClampToScreen() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public UIWindow() => throw null;

  public enum ResizeWidth
  {
    None,
    Left,
    Right,
  }

  public enum ResizeHeight
  {
    None,
    Top,
    Bottom,
  }
}
