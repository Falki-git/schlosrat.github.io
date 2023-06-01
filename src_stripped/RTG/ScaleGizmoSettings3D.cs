﻿// Decompiled with JetBrains decompiler
// Type: RTG.ScaleGizmoSettings3D
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace RTG
{
  [Serializable]
  public class ScaleGizmoSettings3D : Settings
  {
    [SerializeField]
    private float _uniformSnapStep;
    [SerializeField]
    private GizmoLineSlider3DSettings[] _sglSliderSettings;
    [SerializeField]
    private GizmoPlaneSlider3DSettings[] _dblSliderSettings;

    public float LineSliderHoverEps
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float BoxSliderHoverEps
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float CylinderSliderHoverEps
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float XSnapStep
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float YSnapStep
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float ZSnapStep
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float XYSnapStep
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float YZSnapStep
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float ZXSnapStep
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float UniformSnapStep
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float DragSensitivity
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ScaleGizmoSettings3D() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetLineSliderHoverEps(float eps) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetBoxSliderHoverEps(float eps) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetCylinderSliderHoverEps(float eps) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetXSnapStep(float snapStep) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetYSnapStep(float snapStep) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetZSnapStep(float snapStep) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetXYSnapStep(float snapStep) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetYZSnapStep(float snapStep) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetZXSnapStep(float snapStep) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetUniformScaleSnapStep(float snapStep) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetDragSensitivity(float sensitivity) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ConnectSliderSettings(GizmoLineSlider3D slider, int axisIndex, AxisSign axisSign) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ConnectDblSliderSettings(GizmoPlaneSlider3D dblSlider, PlaneId planeId) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private GizmoLineSlider3DSettings GetSglSliderSettings(int axisIndex, AxisSign axisSign) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private GizmoPlaneSlider3DSettings GetDblSliderSettings(PlaneId planeId) => throw null;
  }
}
