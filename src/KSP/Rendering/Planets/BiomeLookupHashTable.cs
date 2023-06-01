﻿// Decompiled with JetBrains decompiler
// Type: KSP.Rendering.Planets.BiomeLookupHashTable
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Rendering.Planets
{
  public class BiomeLookupHashTable : ScriptableObject
  {
    public const int BakingRefDimension = 4096;
    public const int BiomeSamplingHashTableDimension = 256;
    public const int BiomeSamplingHashTableSize = 65536;
    public const int CellDimension = 16;
    public BiomeLookupHashCell[] Cells;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public BiomeLookupHashTable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PQSData.BiomeSurfaceData GetBiomeDataAtUV(
      Vector2 uv,
      ref BiomeTextureColorLookupTable colorTable)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static int PackBiomeChunkData(
      int umin,
      int umax,
      int vmin,
      int vmax,
      int type,
      int colorIndex)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void UnpackBiomeChunkData(
      int data,
      out int umin,
      out int umax,
      out int vmin,
      out int vmax,
      out int type,
      out int colorIndex)
    {
      throw null;
    }
  }
}
