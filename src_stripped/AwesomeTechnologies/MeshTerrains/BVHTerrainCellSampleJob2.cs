﻿// Decompiled with JetBrains decompiler
// Type: AwesomeTechnologies.MeshTerrains.BVHTerrainCellSampleJob2
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using AwesomeTechnologies.Utility.BVHTree;
using System.Runtime.CompilerServices;
using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using UnityEngine;

namespace AwesomeTechnologies.MeshTerrains
{
  [BurstCompile(CompileSynchronously = true)]
  public struct BVHTerrainCellSampleJob2 : IJobParallelFor
  {
    public NativeArray<Bounds> VegetationCellBoundsList;
    [ReadOnly]
    public NativeArray<LBVHNODE> Nodes;
    public Rect TerrainRect;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Execute(int index) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool CalculateCellSize(
      int nodeID,
      ref Vector3 cellMinExtended,
      ref Vector3 cellMaxExtended,
      ref Vector3 cellMin,
      ref Vector3 cellMax)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool OverlapBbox(Vector3 aMin, Vector3 aMax, Vector3 bMin, Vector3 bMax) => throw null;
  }
}
