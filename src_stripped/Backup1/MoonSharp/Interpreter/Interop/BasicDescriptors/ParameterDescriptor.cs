﻿// Decompiled with JetBrains decompiler
// Type: MoonSharp.Interpreter.Interop.BasicDescriptors.ParameterDescriptor
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace MoonSharp.Interpreter.Interop.BasicDescriptors
{
  public sealed class ParameterDescriptor : IWireableDescriptor
  {
    private Type m_OriginalType;

    public string Name
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public Type Type
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public bool HasDefaultValue
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public object DefaultValue
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public bool IsOut
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public bool IsRef
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public bool IsVarArgs
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public bool HasBeenRestricted
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Type OriginalType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ParameterDescriptor(
      string name,
      Type type,
      bool hasDefaultValue = false,
      object defaultValue = null,
      bool isOut = false,
      bool isRef = false,
      bool isVarArgs = false)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ParameterDescriptor(
      string name,
      Type type,
      bool hasDefaultValue,
      object defaultValue,
      bool isOut,
      bool isRef,
      bool isVarArgs,
      Type typeRestriction)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ParameterDescriptor(ParameterInfo pi) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override string ToString() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RestrictType(Type type) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void PrepareForWiring(MoonSharp.Interpreter.Table table) => throw null;
  }
}
