﻿// Decompiled with JetBrains decompiler
// Type: MoonSharp.Interpreter.Diagnostics.PerformanceCounters.GlobalPerformanceStopwatch
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace MoonSharp.Interpreter.Diagnostics.PerformanceCounters
{
  internal class GlobalPerformanceStopwatch : IPerformanceStopwatch
  {
    private int m_Count;
    private long m_Elapsed;
    private MoonSharp.Interpreter.Diagnostics.PerformanceCounter m_Counter;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public GlobalPerformanceStopwatch(MoonSharp.Interpreter.Diagnostics.PerformanceCounter perfcounter) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SignalStopwatchTerminated(Stopwatch sw) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public IDisposable Start() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PerformanceResult GetResult() => throw null;

    private class GlobalPerformanceStopwatch_StopwatchObject : IDisposable
    {
      private Stopwatch m_Stopwatch;
      private GlobalPerformanceStopwatch m_Parent;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public GlobalPerformanceStopwatch_StopwatchObject(GlobalPerformanceStopwatch parent) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public void Dispose() => throw null;
    }
  }
}
