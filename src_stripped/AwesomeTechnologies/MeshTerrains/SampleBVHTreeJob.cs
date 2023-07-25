﻿// Decompiled with JetBrains decompiler
// Type: AwesomeTechnologies.MeshTerrains.SampleBVHTreeJob
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using AwesomeTechnologies.Utility.BVHTree;
using System.Runtime.CompilerServices;
using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;

namespace AwesomeTechnologies.MeshTerrains
{
  [BurstCompile(CompileSynchronously = true)]
  public struct SampleBVHTreeJob : IJobParallelFor
  {
    [ReadOnly]
    public NativeArray<BVHRay> Rays;
    public NativeArray<HitInfo> HitInfos;
    [ReadOnly]
    public NativeArray<LBVHNODE> NativeNodes;
    [ReadOnly]
    public NativeArray<LBVHTriangle> NativePrims;
    public NativeArray<HitInfo> TempHi;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Execute(int index) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool RayCastStackless(int index) => throw null;

    public enum TraverseSstate
    {
      FromParent,
      FromSibling,
      FromChild,
    }
  }
}
