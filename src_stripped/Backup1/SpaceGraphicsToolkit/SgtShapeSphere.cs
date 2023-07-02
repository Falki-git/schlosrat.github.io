﻿// Decompiled with JetBrains decompiler
// Type: SpaceGraphicsToolkit.SgtShapeSphere
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

namespace SpaceGraphicsToolkit
{
  [AddComponentMenu("Space Graphics Toolkit/SGT Shape Sphere")]
  [HelpURL("https://bitbucket.org/Darkcoder/space-graphics-toolkit/wiki/SgtShapeSphere")]
  public class SgtShapeSphere : SgtShape
  {
    public float Radius;
    public SgtEase.Type Ease;
    public float Sharpness;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override float GetDensity(Vector3 worldPoint) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static SgtShapeSphere Create(int layer = 0, Transform parent = null) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static SgtShapeSphere Create(
      int layer,
      Transform parent,
      Vector3 localPosition,
      Quaternion localRotation,
      Vector3 localScale)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SgtShapeSphere() => throw null;
  }
}
