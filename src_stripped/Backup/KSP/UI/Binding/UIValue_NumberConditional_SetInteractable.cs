﻿// Decompiled with JetBrains decompiler
// Type: KSP.UI.Binding.UIValue_NumberConditional_SetInteractable
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.UI.Binding.Core;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace KSP.UI.Binding
{
  public class UIValue_NumberConditional_SetInteractable : UIValueNumberBinderConditional
  {
    [Space]
    public Selectable target;
    public bool interactableIfValueTrue;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void HandleConditionalResult(bool result) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public UIValue_NumberConditional_SetInteractable() => throw null;
  }
}
