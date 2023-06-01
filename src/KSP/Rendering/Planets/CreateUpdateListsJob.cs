﻿// Decompiled with JetBrains decompiler
// Type: KSP.Rendering.Planets.CreateUpdateListsJob
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using UnityEngine;

namespace KSP.Rendering.Planets
{
  [BurstCompile(CompileSynchronously = true)]
  public struct CreateUpdateListsJob : IJobParallelFor
  {
    [ReadOnly]
    public NativeArray<QuadState> QuadStates;
    [ReadOnly]
    public NativeArray<QuadDataGPU> AllQuadList;
    [ReadOnly]
    public NativeHashMap<int, PQSColliderInfo> ActiveColliderMap;
    public NativeArray<PQJob.PQ> PQs;
    public NativeList<QuadDataGPU>.ParallelWriter CreateMeshQuadList;
    public NativeList<QuadDataGPU>.ParallelWriter UpdateNormalsQuadList;
    public NativeList<QuadDataGPU>.ParallelWriter VisibleQuadsDataList;
    public NativeList<QuadDataGPU>.ParallelWriter ColliderQuadDataList;
    public NativeList<int>.ParallelWriter DestroyedColliderIndexList;
    public NativeQueue<int>.ParallelWriter QuadCache;
    public NativeHashSet<int>.ParallelWriter UniqueQuadCache;
    public bool CreateColliders;
    public bool SelectSubdivision;
    public int MinSubdivision;
    public int MaxSubdivision;
    public bool WaterSphere;
    public bool ForceReload;
    public Vector3 CameraDirection;
    public bool CullBackSideQuads;
    public float BackSideCutoff;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Execute(int i) => throw null;
  }
}
