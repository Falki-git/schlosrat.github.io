﻿// Decompiled with JetBrains decompiler
// Type: AwesomeTechnologies.Vegetation.Masks.SampleRgbaChannelExcludeMaskJob
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

namespace AwesomeTechnologies.Vegetation.Masks
{
  [BurstCompile]
  public struct SampleRgbaChannelExcludeMaskJob : IJobParallelForDefer
  {
    public NativeArray<float3> Position;
    public NativeArray<byte> Excluded;
    [ReadOnly]
    public NativeArray<RGBABytes> RgbaNativeArray;
    public bool Inverse;
    public int SelectedChannel;
    public int Width;
    public int Height;
    public Rect TextureRect;
    public float MinValue;
    public float MaxValue;
    public float2 Repeat;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Execute(int index) => throw null;
  }
}
