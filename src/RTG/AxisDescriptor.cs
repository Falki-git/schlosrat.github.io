﻿// Decompiled with JetBrains decompiler
// Type: RTG.AxisDescriptor
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;

namespace RTG
{
  public class AxisDescriptor
  {
    private AxisSign _sign;
    private int _index;

    public AxisSign Sign
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public int Index
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool IsPositive
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool IsNegative
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public AxisDescriptor(int axisIndex, AxisSign axisSign) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public AxisDescriptor(int axisIndex, bool isNegative) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public BoxFace GetAssociatedBoxFace() => throw null;
  }
}
