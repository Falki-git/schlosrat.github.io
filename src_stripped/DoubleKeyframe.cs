﻿// Decompiled with JetBrains decompiler
// Type: DoubleKeyframe
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;

public struct DoubleKeyframe : IComparable
{
  public double inTangent;
  public double outTangent;
  public double time;
  public double value;
  public bool autoTangent;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public DoubleKeyframe(double time, double value) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public DoubleKeyframe(double time, double value, double inTangent, double outTangent) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  int IComparable.CompareTo(object obj) => throw null;
}
