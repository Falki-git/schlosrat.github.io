﻿// Decompiled with JetBrains decompiler
// Type: KSP.OAB.VABSizeLimits
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.OAB
{
  public class VABSizeLimits : IObjectAssemblyBuilderSizeLimits
  {
    private Bounds SizeBounds;
    private DebugShapesDraw.Cuboid DebugCuboid;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public VABSizeLimits(
      GameObject gameObj,
      Vector3 center,
      float height,
      float width,
      float depth)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsAssemblyOutOfBounds(Bounds assemblyBounds) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void EnableDebugSizeLimits(bool enable) => throw null;
  }
}
