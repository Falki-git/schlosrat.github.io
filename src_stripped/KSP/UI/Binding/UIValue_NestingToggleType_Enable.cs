﻿// Decompiled with JetBrains decompiler
// Type: KSP.UI.Binding.UIValue_NestingToggleType_Enable
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Map;
using KSP.UI.Binding.Core;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.UI.Binding
{
  public class UIValue_NestingToggleType_Enable : UIValueBinder<NestingToggleType>
  {
    [SerializeField]
    private GameObject _target;
    [SerializeField]
    private NestingToggleType _typeDisplayedFor;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void RedrawValue(bool instant = true) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetTargetActive(bool isBound) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public UIValue_NestingToggleType_Enable() => throw null;
  }
}
