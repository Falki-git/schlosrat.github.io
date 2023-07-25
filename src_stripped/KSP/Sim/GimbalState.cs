﻿// Decompiled with JetBrains decompiler
// Type: KSP.Sim.GimbalState
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Sim
{
  [Serializable]
  public struct GimbalState
  {
    public double distance;
    public double pitch;
    public double heading;
    public double roll;
    public double localPitch;
    public double localHeading;
    public Vector2 pan;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override string ToString() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool Equals(object obj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override int GetHashCode() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public GimbalState Lerp(GimbalState lhs, GimbalState rhs, float t) => throw null;
  }
}
