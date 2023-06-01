﻿// Decompiled with JetBrains decompiler
// Type: RTG.GizmoCap3DController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

namespace RTG
{
  public abstract class GizmoCap3DController : IGizmoCap3DController
  {
    protected GizmoCap3DControllerData _data;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public GizmoCap3DController(GizmoCap3DControllerData controllerData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public abstract void UpdateHandles() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public abstract void UpdateTransforms(float zoomFactor) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public abstract void CapSlider3D(
      Vector3 sliderDirection,
      Vector3 sliderEndPt,
      float zoomFactor)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public abstract void CapSlider3DInvert(
      Vector3 sliderDirection,
      Vector3 sliderEndPt,
      float zoomFactor)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public abstract float GetSliderAlignedRealLength(float zoomFactor) => throw null;
  }
}
