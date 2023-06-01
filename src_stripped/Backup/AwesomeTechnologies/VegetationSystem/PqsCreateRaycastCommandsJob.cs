﻿// Decompiled with JetBrains decompiler
// Type: AwesomeTechnologies.VegetationSystem.PqsCreateRaycastCommandsJob
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using Unity.Mathematics;
using UnityEngine;

namespace AwesomeTechnologies.VegetationSystem
{
  [BurstCompile(CompileSynchronously = true)]
  public struct PqsCreateRaycastCommandsJob : IJob
  {
    [ReadOnly]
    public NativeArray<VegetationSpawnLocationInstance> SpawnLocationList;
    public NativeArray<RaycastCommand> RaycastCommands;
    public int LayerMask;
    public int MaxHits;
    public int ExcludeLayerMask;
    public float3 FloatingOriginOffset;
    public float SphereRadius;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Execute() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector3 PolarToCartesian(Vector2 polar, float radius) => throw null;
  }
}
