﻿// Decompiled with JetBrains decompiler
// Type: KSP.Iteration.UI.Binding.UIData_DemoVessel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.UI.Binding.Core;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Iteration.UI.Binding
{
  public class UIData_DemoVessel : UIDataDemoVesselBinder
  {
    [SerializeField]
    private float AnimationDuration;
    [SerializeField]
    private Vector3 OffsetWhenDisabled;
    [SerializeField]
    [Header("Bound UI Elements")]
    private UIValueBinder MapToggle;
    [SerializeField]
    private UIValueBinder GuidText;
    [SerializeField]
    private UIValueNumberBinder AltitudeSlider;
    [SerializeField]
    private UIValueNumberBinder VelocitySlider;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void ClearDataCallbacks() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void SetDataCallbacks() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void RedrawOnIsBoundChanged(bool instant = true) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public UIData_DemoVessel() => throw null;
  }
}
