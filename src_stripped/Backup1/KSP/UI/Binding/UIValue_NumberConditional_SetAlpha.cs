﻿// Decompiled with JetBrains decompiler
// Type: KSP.UI.Binding.UIValue_NumberConditional_SetAlpha
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.UI.Binding.Core;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.UI.Binding
{
  public class UIValue_NumberConditional_SetAlpha : UIValueNumberBinderConditional
  {
    [Space]
    public CanvasGroup target;
    [Space]
    public bool adjustInteractablity;
    public bool interactiveIfTrue;
    public bool interactiveIfFalse;
    [Space]
    public float alphaIfTrue;
    public float alphaIfFalse;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void HandleConditionalResult(bool result) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public UIValue_NumberConditional_SetAlpha() => throw null;
  }
}
