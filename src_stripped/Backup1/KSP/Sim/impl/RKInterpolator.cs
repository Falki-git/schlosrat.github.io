﻿// Decompiled with JetBrains decompiler
// Type: KSP.Sim.impl.RKInterpolator
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
