﻿// Decompiled with JetBrains decompiler
// Type: KSP.UI.Binding.UIValue_ReadBool_CallUnityEvent
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.UI.Binding.Core;
using System.Runtime.CompilerServices;
using UnityEngine.Events;

namespace KSP.UI.Binding
{
  public class UIValue_ReadBool_CallUnityEvent : UIValueBinder<bool>
  {
    public UnityEvent OnValueTrue;
    public UnityEvent OnValueFalse;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void UpdateBoundValueFromContext() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void RedrawValue(bool instant = true) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public UIValue_ReadBool_CallUnityEvent() => throw null;
  }
}
