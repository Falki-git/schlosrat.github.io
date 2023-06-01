﻿// Decompiled with JetBrains decompiler
// Type: KSP.AtmosphereScattering.TransmittanceCalculate
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.AtmosphereScattering
{
  public static class TransmittanceCalculate
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    private static float ClampCosine(float mu) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static float ClampDistance(float d) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static float ClampRadius(AtmosphereConfig atmosphere, float r) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static float SafeSqrt(float a) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static float DistanceToTopAtmosphereBoundary(
      AtmosphereConfig atmosphere,
      float r,
      float mu)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static float GetScaleHeight(float altitude, float scale_height) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static float ComputeOpticalLengthToTopAtmosphereBoundary(
      AtmosphereConfig atmosphere,
      float r,
      float mu,
      float scale_height)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Vector3 ComputeTransmittanceToTopAtmosphereBoundary(
      AtmosphereConfig atmosphere,
      float r,
      float mu)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Vector3 GetTransmittanceToSun(AtmosphereConfig atmosphere, float r, float mu_s) => throw null;
  }
}
