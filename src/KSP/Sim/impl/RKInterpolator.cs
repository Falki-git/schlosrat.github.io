﻿// Decompiled with JetBrains decompiler
// Type: KSP.Sim.impl.RKInterpolator
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;

namespace KSP.Sim.impl
{
  public class RKInterpolator
  {
    public readonly double TimeOld;
    public readonly double Time;
    private readonly double _h;
    private readonly double[,] _QArray;
    private readonly double[] _yOld;
    private double[,] _p;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public RKInterpolator(double timeOld, double t, double[] yOld, double[,] qArray) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double[] GetStateAtUT(double time) => throw null;
  }
}
