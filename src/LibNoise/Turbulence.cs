﻿// Decompiled with JetBrains decompiler
// Type: LibNoise.Turbulence
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

namespace LibNoise
{
  public class Turbulence : IModule
  {
    private Perlin XDistort;
    private Perlin YDistort;
    private Perlin ZDistort;

    public IModule SourceModule
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public double Power
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Turbulence(IModule sourceModule) => throw null;

    public double Frequency
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double GetValue(Vector3d coordinate) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double GetValue(Vector3 coordinate) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double GetValue(double x, double y, double z) => throw null;

    public int Roughness
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public int Seed
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }
  }
}
