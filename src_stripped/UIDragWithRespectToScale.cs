﻿// Decompiled with JetBrains decompiler
// Type: UIDragWithRespectToScale
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;

public class UIDragWithRespectToScale : 
  MonoBehaviour,
  IBeginDragHandler,
  IEventSystemHandler,
  IDragHandler,
  IEndDragHandler
{
  private Vector3 startPos;
  private Vector2 posAdjust;
  private Vector2 startDif;
  public GameObject referenceCanvas;
  public int snapGridSize;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void Awake() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void OnBeginDrag(PointerEventData eventData) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public Vector2 clampToScreen(Vector2 start, float border = 0.0f) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void OnDrag(PointerEventData eventData) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void OnEndDrag(PointerEventData eventData) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public UIDragWithRespectToScale() => throw null;
}
