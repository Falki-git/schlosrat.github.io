﻿// Decompiled with JetBrains decompiler
// Type: KSP.Sim.impl.IVAPortraitEVAObstacleDetector
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Sim.impl
{
  public class IVAPortraitEVAObstacleDetector
  {
    private const float CLEARANCE_CAPSULE_HEIGHT = 0.8f;
    private const float CLEARANCE_CAPSULE_RADIUS = 0.25f;
    private const int COLLISION_RESULT_COUNT = 2;
    private readonly Collider[] _collisionResults;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsEVADisabledByObstacle(PartBehavior partBehavior) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ClearCollisionResults() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool GetEVADisabledCollisionResult(PartBehavior partBehavior) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static bool IsTransformChildOfParent(
      in Transform childTransform,
      in Transform parentTransform)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public IVAPortraitEVAObstacleDetector() => throw null;
  }
}
