﻿// Decompiled with JetBrains decompiler
// Type: LibNoise.FastNoiseBasis
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;

namespace LibNoise
{
  public class FastNoiseBasis : Math
  {
    private int[] RandomPermutations;
    private int[] SelectedPermutations;
    private float[] GradientTable;
    private int mSeed;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FastNoiseBasis() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FastNoiseBasis(int seed) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double GradientCoherentNoise(
      double x,
      double y,
      double z,
      int seed,
      NoiseQuality noiseQuality)
    {
      throw null;
    }

    public int Seed
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }
  }
}
