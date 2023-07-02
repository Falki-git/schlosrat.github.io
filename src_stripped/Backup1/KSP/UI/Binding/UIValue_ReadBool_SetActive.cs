﻿// Decompiled with JetBrains decompiler
// Type: KSP.UI.Binding.UIValue_ReadBool_SetActive
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.UI.Binding.Core;
using System;
using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Serialization;

namespace KSP.UI.Binding
{
  public class UIValue_ReadBool_SetActive : UIValueBinder<bool>
  {
    public GameObject target;
    [FormerlySerializedAs("enabledIfNotFound")]
    [Space]
    public bool activeIfNotFound;
    [FormerlySerializedAs("enabledIfValueTrue")]
    public bool activeIfValueTrue;
    private bool queuedActive;
    private Coroutine queuedActiveCoroutine;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void RedrawValue(bool instant = true) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void HandleIsBoundChanged(bool isBound) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private IEnumerator DelayAction(Action action) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetQueuedActive() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public UIValue_ReadBool_SetActive() => throw null;
  }
}
