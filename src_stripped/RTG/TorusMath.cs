﻿// Decompiled with JetBrains decompiler
// Type: RTG.TorusMath
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace RTG
{
  public static class TorusMath
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static float CalcSphereRadius(float torusCoreRadius, float torusTubeRadius) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static AABB CalcCylModelAABB(
      float torusCoreRadius,
      float torusHrzRadius,
      float torusVertRadius)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static AABB CalcCylAABB(
      Vector3 torusCenter,
      float torusCoreRadius,
      float torusHrzRadius,
      float torusVertRadius,
      Quaternion torusRotation)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static List<Vector3> Calc3DHrzExtentPoints(
      Vector3 torusCenter,
      float torusCoreRadius,
      float torusTubeRadius,
      Quaternion torusRotation)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool Raycast(
      Ray ray,
      out float t,
      Vector3 torusCenter,
      float torusCoreRadius,
      float torusTubeRadius,
      Quaternion torusRotation,
      TorusEpsilon epsilon = default (TorusEpsilon))
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool RaycastCylindrical(
      Ray ray,
      out float t,
      Vector3 torusCenter,
      float torusCoreRadius,
      float torusHrzRadius,
      float torusVertRadius,
      Quaternion torusRotation,
      TorusEpsilon epsilon = default (TorusEpsilon))
    {
      throw null;
    }
  }
}
