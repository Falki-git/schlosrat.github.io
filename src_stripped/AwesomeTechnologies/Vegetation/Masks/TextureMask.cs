﻿// Decompiled with JetBrains decompiler
// Type: AwesomeTechnologies.Vegetation.Masks.TextureMask
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using AwesomeTechnologies.VegetationSystem;
using System;
using System.Runtime.CompilerServices;
using Unity.Collections;
using Unity.Jobs;
using UnityEngine;

namespace AwesomeTechnologies.Vegetation.Masks
{
  [Serializable]
  public class TextureMask
  {
    public Rect TextureRect;
    public Vector2 Repeat;
    public Texture2D MaskTexture;
    private NativeArray<RGBABytes> _rgbaNativeArray;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public JobHandle SampleIncludeMask(
      VegetationInstanceData instanceData,
      Rect spawnRect,
      TextureMaskType textureMaskType,
      TextureMaskRule textureMaskRule,
      JobHandle dependsOn)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public JobHandle SampleExcludeMask(
      VegetationInstanceData instanceData,
      Rect spawnRect,
      TextureMaskType textureMaskType,
      TextureMaskRule textureMaskRule,
      JobHandle dependsOn)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Dispose() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public TextureMask() => throw null;
  }
}
