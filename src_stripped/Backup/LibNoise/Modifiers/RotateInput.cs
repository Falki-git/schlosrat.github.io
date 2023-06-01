﻿// Decompiled with JetBrains decompiler
// Type: LibNoise.Modifiers.RotateInput
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

namespace LibNoise.Modifiers
{
  public class RotateInput : IModule
  {
    private double XAngle;
    private double YAngle;
    private double ZAngle;
    private double m_x1Matrix;
    private double m_x2Matrix;
    private double m_x3Matrix;
    private double m_y1Matrix;
    private double m_y2Matrix;
    private double m_y3Matrix;
    private double m_z1Matrix;
    private double m_z2Matrix;
    private double m_z3Matrix;

    public IModule SourceModule
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public RotateInput(IModule sourceModule, double xAngle, double yAngle, double zAngle) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetAngles(double xAngle, double yAngle, double zAngle) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double GetValue(Vector3d coordinate) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double GetValue(Vector3 coordinate) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double GetValue(double x, double y, double z) => throw null;
  }
}
