﻿// Decompiled with JetBrains decompiler
// Type: KSP.UI.KSP2DraggableWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;

namespace KSP.UI
{
  [Obsolete("Please use KSP2UIWindow for ant new windows and be wary of editing this class", false)]
  public class KSP2DraggableWindow : 
    MonoBehaviour,
    IPointerDownHandler,
    IEventSystemHandler,
    IDragHandler
  {
    [Header("UI Panel Root")]
    [SerializeField]
    private RectTransform uiPanelRootTransform;
    private RectTransform uiPanelTransform;
    private RectTransform canvasTransform;
    private Vector2 mousePointerOffset;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Start() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnDrag(PointerEventData eventData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnPointerDown(PointerEventData data) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public KSP2DraggableWindow() => throw null;
  }
}
