﻿// Decompiled with JetBrains decompiler
// Type: UnityEngine.UI.ButtonExtended
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Messages;
using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine.Events;
using UnityEngine.EventSystems;

namespace UnityEngine.UI
{
  public class ButtonExtended : 
    Button,
    ISelectionStateEventProvider,
    IPointerClickHandler,
    IEventSystemHandler,
    IPointerDownHandler,
    IPointerUpHandler
  {
    public bool PublishMessages;
    public SelectedDiscoverableMessage ButtonClickedMessageType;
    public SelectionStateEvent onStateTransition;
    [Range(0.0f, 1f)]
    public float alphaHitTestThreshold;
    public Button.ButtonClickedEvent onLeftClick;
    public Button.ButtonClickedEvent onRightClick;
    public Button.ButtonClickedEvent onMiddleClick;
    public UnityEvent onLeftMouseHold;
    public UnityEvent onRightMouseHold;
    public UnityEvent onMiddleMouseHold;
    public float holdDelay;
    private UnityEngine.UI.SelectionState lastState;
    private Coroutine curClickCoroutine;
    private bool delayActionTriggered;

    public SelectionStateEvent OnStateTransition
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public UnityEngine.UI.SelectionState CurrentSelectionState
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void DoStateTransition(Selectable.SelectionState state, bool instant) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnPointerClick(PointerEventData eventData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnPointerDown(PointerEventData eventData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnPointerUp(PointerEventData eventData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ClickNow(int mouseButtonIndex) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnSelect(BaseEventData eventData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnDeselect(BaseEventData eventData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private IEnumerator ClickWithDelay(int mouseButtonIndex, float delay) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ClearTrackedCoroutine() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void Start() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static UnityEngine.UI.SelectionState ToExtendedSelectionState(
      Selectable.SelectionState state)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ButtonExtended() => throw null;
  }
}
