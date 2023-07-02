﻿// Decompiled with JetBrains decompiler
// Type: KSP.CameraTemplate.CameraTemplateValidators
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.ModularCamera;
using KSP.PhysicsUtils;
using System.Runtime.CompilerServices;

namespace KSP.CameraTemplate
{
  public static class CameraTemplateValidators
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool SetActualDistToTargetDist(ICameraDriver driver, ValidatorType type) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool SetTargetDistToActualDist(ICameraDriver driver, ValidatorType type) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Validator DoAllUntilFirstValid(params Validator[] toRun) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Validator DoAll(params Validator[] toRun) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Validator MinTargetDistance(float minTargetDist) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Validator MinCameraDistance(float minCameraDist) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Validator MinCameraDistanceForceCamera(float minCameraDist) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Validator MoveBasedOnCollisions(TriggerIntersectionWatcher watcher, bool debug = false) => throw null;
  }
}
