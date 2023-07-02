﻿// Decompiled with JetBrains decompiler
// Type: KSP.VFX.FXContextualEventParams
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Rendering.Planets;
using KSP.Sim.impl;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.VFX
{
  public class FXContextualEventParams
  {
    public Transform SourceTransform;
    public Vector3 SourcePosition;
    public Quaternion SourceRotation;
    public PartBehavior SourcePartBehavior;
    public double PartExplosionPotential;
    public PQS Pqs;
    public SurfaceColliderData SurfaceData;
    public VFXSurfaceType SurfaceType;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FXContextualEventParams(
      Transform transform,
      Vector3 pos,
      Quaternion rotation,
      PartBehavior source,
      double impact,
      PQS pqs,
      SurfaceColliderData data)
    {
      throw null;
    }
  }
}
