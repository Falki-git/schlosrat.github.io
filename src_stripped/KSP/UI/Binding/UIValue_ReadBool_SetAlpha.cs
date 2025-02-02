﻿// Decompiled with JetBrains decompiler
// Type: KSP.UI.Binding.UIValue_ReadBool_SetAlpha
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using KSP.UI.Binding.Core;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Serialization;

namespace KSP.UI.Binding
{
  public class UIValue_ReadBool_SetAlpha : UIValueBinder<bool>
  {
    public CanvasGroup target;
    [FormerlySerializedAs("interactableIfNotFound")]
    [Space]
    public bool alphaIfNotFound;
    [Space]
    public float alphaIfTrue;
    public float alphaIfFalse;
    [Space]
    public bool disableRaycastIfInvisible;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void HandleIsBoundChanged(bool isBound, bool instant = true) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void RedrawValue(bool instant = true) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public UIValue_ReadBool_SetAlpha() => throw null;
  }
}
