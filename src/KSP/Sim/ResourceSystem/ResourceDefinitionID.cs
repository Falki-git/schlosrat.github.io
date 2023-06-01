﻿// Decompiled with JetBrains decompiler
// Type: KSP.Sim.ResourceSystem.ResourceDefinitionID
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace KSP.Sim.ResourceSystem
{
  [DebuggerDisplay("{ToString()}")]
  [Serializable]
  public readonly struct ResourceDefinitionID : 
    IEquatable<ResourceDefinitionID>,
    IComparable<ResourceDefinitionID>
  {
    public const ushort INVALID_ID_VALUE = 0;
    public static readonly ResourceDefinitionID InvalidID;
    public readonly ushort Value;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ResourceDefinitionID(int value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool Equals(ResourceDefinitionID other) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool Equals(object obj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override int GetHashCode() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public int CompareTo(ResourceDefinitionID other) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool operator ==(ResourceDefinitionID lhs, ResourceDefinitionID rhs) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool operator !=(ResourceDefinitionID lhs, ResourceDefinitionID rhs) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override string ToString() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static ResourceDefinitionID() => throw null;
  }
}
