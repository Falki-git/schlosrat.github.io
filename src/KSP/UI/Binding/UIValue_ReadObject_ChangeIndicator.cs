﻿// Decompiled with JetBrains decompiler
// Type: KSP.UI.Binding.UIValue_ReadObject_ChangeIndicator
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.UI.Binding.Core;
using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace KSP.UI.Binding
{
  public class UIValue_ReadObject_ChangeIndicator : UIValueBinder
  {
    [SerializeField]
    private Image indicatorImage;
    [SerializeField]
    private float fadeDuration;
    private bool hueFlip;
    private Coroutine fadeAnimation;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void RedrawValue(bool instant = true) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private IEnumerator FadeOut(float fadeDuration) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public UIValue_ReadObject_ChangeIndicator() => throw null;
  }
}
