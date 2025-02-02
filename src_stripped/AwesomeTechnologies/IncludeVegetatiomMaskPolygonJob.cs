﻿// Decompiled with JetBrains decompiler
// Type: AwesomeTechnologies.IncludeVegetatiomMaskPolygonJob
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using Unity.Mathematics;
using UnityEngine;

namespace AwesomeTechnologies
{
  [BurstCompile(CompileSynchronously = true)]
  public struct IncludeVegetatiomMaskPolygonJob : IJobParallelForDefer
  {
    public NativeArray<byte> Excluded;
    public NativeArray<float3> Position;
    public NativeArray<float> VegetationMaskScale;
    public NativeArray<float> VegetationMaskDensity;
    [ReadOnly]
    public NativeArray<Vector2> PolygonArray;
    public float Denisty;
    public float Scale;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Execute(int index) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool IsInPolygon(Vector2 p) => throw null;
  }
}
