﻿// Decompiled with JetBrains decompiler
// Type: KSP.UI.Binding.UIValue_ReadNumber_RectTransformSize
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.UI.Binding.Core;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.UI.Binding
{
  [DisallowMultipleComponent]
  public class UIValue_ReadNumber_RectTransformSize : UIValueNumberBinder
  {
    [Header("Transform To Resize")]
    [SerializeField]
    private RectTransform rectTransform;
    [SerializeField]
    private bool _setWidth;
    [SerializeField]
    private float minWidth;
    [SerializeField]
    private float maxWidth;
    [SerializeField]
    private bool _setHeight;
    [SerializeField]
    private float minHeight;
    [SerializeField]
    private float maxHeight;
    [SerializeField]
    private AnimationCurve transitionCurve;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void RedrawValue(bool instant = true) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnMappedNumberRangeChanged(
      UIValueNumberRange oldRange,
      bool shouldRedraw)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public UIValue_ReadNumber_RectTransformSize() => throw null;
  }
}
