﻿// Decompiled with JetBrains decompiler
// Type: KSP.UI.Binding.UIValue_ReadNumber_Dial_Curved
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.UI.Binding.Core;
using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.UI.Binding
{
  [DisallowMultipleComponent]
  public class UIValue_ReadNumber_Dial_Curved : UIValueNumberBinder
  {
    [Header("Dial")]
    [SerializeField]
    private RectTransform minDialLocator;
    [SerializeField]
    private RectTransform maxDialLocator;
    [SerializeField]
    private RectTransform curveHandleLocator;
    [SerializeField]
    private RectTransform dialIndicator;
    [SerializeField]
    private AnimationCurve transitionPath;
    [SerializeField]
    private bool lerpLocatorPositions;
    [SerializeField]
    private bool lerpSizeDelta;
    [SerializeField]
    private bool lerpLocatorRotation;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected IEnumerator Start() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void RedrawValue(bool instant = true) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private Vector3 QuadraticLerp(Vector3 a, Vector3 b, Vector3 c, float t) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnMappedNumberRangeChanged(
      UIValueNumberRange oldRange,
      bool shouldRedraw)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public UIValue_ReadNumber_Dial_Curved() => throw null;
  }
}
