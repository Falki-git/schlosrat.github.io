﻿// Decompiled with JetBrains decompiler
// Type: KSP.Rendering.Planets.PQSQuadTest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Rendering.Planets
{
  public class PQSQuadTest : MonoBehaviour
  {
    public PQS pqs;
    public QuadPlane plane;
    public PQSQuadTest.Quad[] quads;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnGUI() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PQSQuadTest() => throw null;

    [Serializable]
    public class Quad
    {
      public Matrix4x4 matrix;
      public Matrix4x4 matrixInverse;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public Quad(Vector3d pos) => throw null;
    }
  }
}
