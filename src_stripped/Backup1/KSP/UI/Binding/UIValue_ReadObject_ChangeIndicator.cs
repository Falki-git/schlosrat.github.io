﻿// Decompiled with JetBrains decompiler
// Type: KSP.UI.Binding.UIValue_ReadObject_ChangeIndicator
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
