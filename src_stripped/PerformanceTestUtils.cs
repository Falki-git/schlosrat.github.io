﻿// Decompiled with JetBrains decompiler
// Type: PerformanceTestUtils
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using System;
using System.Collections;
using System.Runtime.CompilerServices;

public static class PerformanceTestUtils
{
  public const string MAIN_MENU_SCENE = "kspFlow.unity";

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static IEnumerator CoroutineLoadInitialScene() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static IEnumerator CoroutineShutdownGame() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static IEnumerator CoroutinePerformOnTimer(
    float intervalSeconds,
    float timeoutSeconds,
    Action actionToPerform)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static void CycleCameraMode() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static void SpawnVesselInVAB(PerformanceTestUtils.TestVesselSize testVesselSize) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static void SpawnVesselOnLaunchpad(
    PerformanceTestUtils.TestVesselSize testVesselSize,
    Action onLaunchCallback)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static void SpawnVesselInOrbit(
    PerformanceTestUtils.TestVesselSize testVesselSize,
    Action onLaunchCallback)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  private static string GetTestVesselsDirectory() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private static string GetTestVesselFilename(PerformanceTestUtils.TestVesselSize vesselSize) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private static void OnVABShowComplete() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private static IEnumerator CoroutineWaitForAssemblyLoad() => throw null;

  public enum TestVesselSize
  {
    Large,
  }
}
