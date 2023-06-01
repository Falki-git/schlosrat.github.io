﻿// Decompiled with JetBrains decompiler
// Type: UIList_ListElement
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.UI.Binding;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

[RequireComponent(typeof (ContextBindRoot))]
public class UIList_ListElement : 
  MonoBehaviour,
  IDragHandler,
  IEventSystemHandler,
  IBeginDragHandler,
  IEndDragHandler,
  IInitializePotentialDragHandler
{
  public UIList_ListView parentListView;
  public bool ReceiveDragEvents;
  public UIList_ListElement.DragPointerEvent onDrag;
  public UIList_ListElement.DragPointerEvent onBeginDrag;
  public UIList_ListElement.DragPointerEvent onEndDrag;

  public ContextBindRoot BindRoot
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
  }

  public ContextListView.ViewElementEntry ElementEntry
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Awake() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void Init() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void OnDrag(PointerEventData eventData) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void OnBeginDrag(PointerEventData eventData) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void OnEndDrag(PointerEventData eventData) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void OnInitializePotentialDrag(PointerEventData eventData) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public UIList_ListElement() => throw null;

  public class DragPointerEvent : UnityEvent<PointerEventData, UIList_ListElement>
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    public DragPointerEvent() => throw null;
  }
}
