﻿// Decompiled with JetBrains decompiler
// Type: LibNoise.Modifiers.Terrace
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace LibNoise.Modifiers
{
  public class Terrace : Math, IModule
  {
    public List<double> ControlPoints;

    public IModule SourceModule
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public bool InvertTerraces
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Terrace(IModule sourceModule) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double GetValue(Vector3d coordinate) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double GetValue(Vector3 coordinate) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double GetValue(double x, double y, double z) => throw null;
  }
}
