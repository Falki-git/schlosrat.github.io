﻿// Decompiled with JetBrains decompiler
// Type: UI.Control.ToggleGroupExtended
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine.Events;
using UnityEngine.UI;

namespace UI.Control
{
  public class ToggleGroupExtended : ToggleGroup
  {
    private Func<List<Toggle>> m_TogglesInternal;
    private Dictionary<Toggle, ToggleGroupExtended.ToggleListenerEntry> toggleListeners;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private Toggle GetFirstActiveToggle() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void EnforceSingleActiveToggle() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void Start() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnEnable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnDisable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnToggleValueChanged(Toggle toggle, bool value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetInteractable(bool state) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ToggleGroupExtended() => throw null;

    private class ToggleListenerEntry
    {
      public UnityAction<bool> listener;
      public bool isListening;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public ToggleListenerEntry() => throw null;
    }
  }
}
