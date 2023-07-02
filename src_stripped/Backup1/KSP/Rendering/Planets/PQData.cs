﻿// Decompiled with JetBrains decompiler
// Type: KSP.Rendering.Planets.PQData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using Unity.Burst;
using Unity.Collections;
using Unity.Mathematics;
using UnityEngine;

namespace KSP.Rendering.Planets
{
  public class PQData
  {
    [HideInInspector]
    public double[] subdivisionThresholds;
    [HideInInspector]
    public double[] collapseThresholds;
    [HideInInspector]
    public int numTesselationSteps;
    [HideInInspector]
    public double tesselationAltitudeFalloff;
    [NoAlias]
    public NativeList<PQJob.PQ> allPQ;
    [NoAlias]
    public NativeQueue<int> quadCache;
    public NativeHashSet<int> UniqueQuadCache;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private ref PQJob.PQ Q(QI initQuad) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetupQuad(
      PQS pqs,
      ref PQJob.PQ quad,
      QuadPlane plane,
      ref PQJob.PQ north,
      ref PQJob.PQ south,
      ref PQJob.PQ east,
      ref PQJob.PQ west,
      Vector3d pos)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateTargetRelativity(PQS pqs, ref PQJob.PQ pq) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void CreateQuads(PQS pqs) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PQData() => throw null;

    public struct TesselationPositionData
    {
      public double3 pos;
      public double heightOffset;
    }
  }
}
