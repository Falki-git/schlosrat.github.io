﻿// Decompiled with JetBrains decompiler
// Type: EdyCommonTools.RigidbodyUtility
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

namespace EdyCommonTools
{
  public static class RigidbodyUtility
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static float GetKineticEnergy(Rigidbody rb) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static float GetNormalizedKineticEnergy(Rigidbody rb) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static float GetLinearKineticEnergy(Rigidbody rb) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static float GetAngularKineticEnergy(Rigidbody rb) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static float GetNormalizedLinearKineticEnergy(Rigidbody rb) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static float GetNormalizedAngularKineticEnergy(Rigidbody rb) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void DiagonalizeInertiaTensor(
      Matrix4x4 m,
      out Vector3 inertiaTensor,
      out Quaternion inertiaTensorRotation)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static int GetNextIndex3(int i) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static Quaternion IndexedRotation(int axis, float s, float c) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static Quaternion Normalize(Quaternion q) => throw null;
  }
}
