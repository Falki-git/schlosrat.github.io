﻿// Decompiled with JetBrains decompiler
// Type: Performance
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Performance : MonoBehaviour
{
  [SerializeField]
  private int frameTimeCount;
  private float[] frameTimes;
  private int frameTimeIndex;
  private float frameTimeSum;
  private float frameTimeAvg;
  private float frameTimeMin;
  private float frameTimeMax;
  public bool forceGC;
  public bool doCleanup;
  public bool requireCleanup;
  public float unloadTime;
  private float nextUnloadTime;

  public static Performance Instance
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
  }

  public int FrameTimeCount
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  public float FrameTimeAverage
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  public float FrameTimeMin
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  public float FrameTimeMax
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  public float FramesPerSecond
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Awake() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void OnDestroy() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Start() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Update() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void UpdateFrameTimes() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public Vector2[] GetFrameTimePoints() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public Vector2[] GetFramePerSecondPoints() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void GetFramePerSecondPoints(Vector2[] points) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void GetFramePerSecondPoints(List<Vector2> points, float scaleX = 0.0f, float scaleY = 0.0f) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void GetFramePerSecondPoints(
    List<Vector2> points,
    float scaleX,
    float scaleY,
    ref float min,
    ref float max)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public Performance() => throw null;
}
