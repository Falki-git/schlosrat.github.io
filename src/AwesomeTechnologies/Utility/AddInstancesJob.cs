﻿// Decompiled with JetBrains decompiler
// Type: AwesomeTechnologies.Utility.AddInstancesJob
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using AwesomeTechnologies.VegetationSystem;
using System.Runtime.CompilerServices;
using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using Unity.Mathematics;
using UnityEngine;

namespace AwesomeTechnologies.Utility
{
  [BurstCompile]
  public struct AddInstancesJob : IJob
  {
    public NativeList<ItemSelectorInstanceInfo> InstanceList;
    public NativeList<MatrixInstance> MatrixInstanceList;
    public int VegetationCellIndex;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Execute() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static float3 ExtractTranslationFromMatrix(Matrix4x4 matrix) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static Quaternion ExtractRotationFromMatrix(Matrix4x4 matrix) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static float3 ExtractScaleFromMatrix(Matrix4x4 matrix) => throw null;
  }
}
