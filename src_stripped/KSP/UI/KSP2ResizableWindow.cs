﻿// Decompiled with JetBrains decompiler
// Type: KSP.UI.KSP2ResizableWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;

namespace KSP.UI
{
  public class KSP2ResizableWindow : 
    MonoBehaviour,
    IPointerDownHandler,
    IEventSystemHandler,
    IDragHandler
  {
    [Header("Min/Max sizes")]
    [SerializeField]
    private Vector2 minSize;
    [SerializeField]
    private Vector2 maxSize;
    [SerializeField]
    [Header("Resize cursor")]
    private Texture2D resizeCursor;
    private RectTransform uiPanelTransform;
    private Vector2 currentPointerPosition;
    private Vector2 previousPointerPosition;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnPointerEnter() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnPointerExit() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnPointerDown(PointerEventData data) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnDrag(PointerEventData data) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public KSP2ResizableWindow() => throw null;
  }
}
