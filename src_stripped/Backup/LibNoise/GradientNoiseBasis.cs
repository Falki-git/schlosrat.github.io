﻿// Decompiled with JetBrains decompiler
// Type: LibNoise.GradientNoiseBasis
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;

namespace LibNoise
{
  public class GradientNoiseBasis : Math
  {
    private const int XNoiseGen = 1619;
    private const int YNoiseGen = 31337;
    private const int ZNoiseGen = 6971;
    private const int SeedNoiseGen = 1013;
    private const int ShiftNoiseGen = 8;
    private static double[] RandomVectors;

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

    [MethodImpl(MethodImplOptions.NoInlining)]
    private double GradientNoise(
      double fx,
      double fy,
      double fz,
      int ix,
      int iy,
      int iz,
      long seed)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public GradientNoiseBasis() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static GradientNoiseBasis() => throw null;
  }
}
