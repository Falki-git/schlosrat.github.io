﻿// Decompiled with JetBrains decompiler
// Type: RTG.GizmoPlaneSlider3DController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;

namespace RTG
{
  public abstract class GizmoPlaneSlider3DController : IGizmoPlaneSlider3DController
  {
    protected GizmoPlaneSlider3DControllerData _data;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public GizmoPlaneSlider3DController(GizmoPlaneSlider3DControllerData controllerData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public abstract void UpdateHandles() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public abstract void UpdateTransforms(float zoomFactor) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public abstract void UpdateEpsilons(float zoomFactor) => throw null;
  }
}
