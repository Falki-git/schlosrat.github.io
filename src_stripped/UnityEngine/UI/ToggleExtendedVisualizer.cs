﻿// Decompiled with JetBrains decompiler
// Type: UnityEngine.UI.ToggleExtendedVisualizer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using AK.Wwise;
using System.Runtime.CompilerServices;
using UnityEngine.EventSystems;

namespace UnityEngine.UI
{
  [RequireComponent(typeof (ToggleExtended))]
  public class ToggleExtendedVisualizer : 
    TransitionVisualizerBase,
    IPointerExitHandler,
    IEventSystemHandler
  {
    public ToggleExtended toggle;
    public TransitionVisualToggle[] transitionVisuals;
    [NonReorderable]
    public Event[] OnButtonPressedEvents;
    [NonReorderable]
    public Event[] OnButtonHoverEvents;
    [NonReorderable]
    public Event[] OnToggleEnabledButtonPressedEvents;
    [NonReorderable]
    public Event[] OnToggleDisabledButtonPressedEvents;
    private uint _rtpcX;
    private uint _rtpcY;
    private bool _isHighlighted;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnDisable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnEnable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void HandleToggle(bool isOn) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void HandleStateTransition(SelectionState state, bool instant) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void RemoveStateVisuals() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected void HandleStateAudio(SelectionState state) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected uint GetRTCPIDX() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected uint GetRTCPIDY() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected void PostAKEventsWithPositionalRTPC(Event[] EventsToPost) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnPointerExit(PointerEventData eventData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ToggleExtendedVisualizer() => throw null;
  }
}
