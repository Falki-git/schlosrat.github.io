﻿// Decompiled with JetBrains decompiler
// Type: KSP.Tools.SceneSpaceTransform
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Sim;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Tools
{
  internal struct SceneSpaceTransform
  {
    public Vector3 scenePosition;
    public Quaternion sceneRotation;
    public Vector3 sceneScale;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SceneSpaceTransform(
      ITransformModel transform,
      IScaledSpaceProvider spaceProvider,
      double scale = 1.0)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SceneSpaceTransform(
      ITransformModel transform,
      IPhysicsSpaceProvider spaceProvider,
      double scale = 1.0)
    {
      throw null;
    }
  }
}
