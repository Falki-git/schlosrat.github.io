﻿// Decompiled with JetBrains decompiler
// Type: AwesomeTechnologies.VegetationSystem.CreateRaycastCommandsListJob
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using UnityEngine;

namespace AwesomeTechnologies.VegetationSystem
{
  [BurstCompile(CompileSynchronously = true)]
  public struct CreateRaycastCommandsListJob : IJob
  {
    [ReadOnly]
    public NativeList<VegetationSpawnLocationInstance> SpawnLocationList;
    public NativeList<RaycastCommand> RaycastCommands;
    public int LayerMask;
    public int MaxHits;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Execute() => throw null;
  }
}
