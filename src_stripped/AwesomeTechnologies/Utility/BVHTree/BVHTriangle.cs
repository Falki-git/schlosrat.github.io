﻿// Decompiled with JetBrains decompiler
// Type: AwesomeTechnologies.Utility.BVHTree.BVHTriangle
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

namespace AwesomeTechnologies.Utility.BVHTree
{
  public class BVHTriangle
  {
    public int PrimID;
    public Vector3 V0;
    public Vector3 V1;
    public Vector3 V2;
    public Vector3 N0;
    public Vector3 N1;
    public Vector3 N2;
    public Vector3 N;
    public int TerrainSourceID;
    public Vector3 Center;
    public Vector3 Min;
    public Vector3 Max;
    public Vector3 Centroid;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public BVHTriangle(
      Vector3 v0,
      Vector3 v1,
      Vector3 v2,
      Vector3 n0,
      Vector3 n1,
      Vector3 n2,
      int primID,
      int terrainSourceID)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void CalculateBBox() => throw null;
  }
}
