﻿// Decompiled with JetBrains decompiler
// Type: KSP.UI.Binding.UIValue_ReadNumber_PathIndicator
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.UI.Binding.Core;
using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Serialization;

namespace KSP.UI.Binding
{
  [DisallowMultipleComponent]
  public class UIValue_ReadNumber_PathIndicator : UIValueNumberBinder
  {
    [FormerlySerializedAs("pathIndicator")]
    [Header("Path")]
    [SerializeField]
    private RectTransform _pathIndicator;
    [SerializeField]
    private UIPathContainer _pathContainer;
    [SerializeField]
    private UIPathContainer.UpdateMode _updateMode;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected IEnumerator Start() => throw null;

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
    public void Evaluate(float value01) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public UIValue_ReadNumber_PathIndicator() => throw null;
  }
}
