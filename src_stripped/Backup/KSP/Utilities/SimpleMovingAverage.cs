﻿// Decompiled with JetBrains decompiler
// Type: KSP.Utilities.SimpleMovingAverage
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace KSP.Utilities
{
  public class SimpleMovingAverage
  {
    private int _windowSize;
    private Vector3d _accumulator;
    private readonly Queue<Vector3d> _queue;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SimpleMovingAverage(int windowSize) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddSample(Vector3d newSample) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool HasSamples() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector3d GetAverage() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Reset() => throw null;
  }
}
