﻿// Decompiled with JetBrains decompiler
// Type: AxisBinding_Single
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using System;
using System.Runtime.CompilerServices;

[Obsolete("requires some porting", false)]
public class AxisBinding_Single : InputBinding_obsolete, ICloneable
{
  public string idTag;
  public string name;
  public string title;
  public int deviceIdx;
  public int axisIdx;
  public bool inverted;
  public float sensitivity;
  public float deadzone;
  public float scale;
  public float neutralPoint;
  private float value;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public AxisBinding_Single() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public AxisBinding_Single(ControlTypes lockMask) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public AxisBinding_Single(float neutral) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public AxisBinding_Single(float neutral, ControlTypes lockMask) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public AxisBinding_Single(InputBindingModes useSwitch) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public AxisBinding_Single(InputBindingModes useSwitch, ControlTypes lockMask) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public AxisBinding_Single(InputBindingModes useSwitch, float neutral) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public AxisBinding_Single(InputBindingModes useSwitch, float neutral, ControlTypes lockMask) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public AxisBinding_Single(string Id, string Name, bool isInverted) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public AxisBinding_Single(string Id, string Name, bool isInverted, ControlTypes lockMask) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public AxisBinding_Single(
    string Id,
    string Name,
    bool isInverted,
    float sens,
    float dead_zone,
    float axisScale)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public AxisBinding_Single(
    string Id,
    string Name,
    bool isInverted,
    float sens,
    float dead_zone,
    float axisScale,
    ControlTypes lockMask)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public float GetAxis() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public override bool IsNeutral() => throw null;
}
