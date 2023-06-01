﻿// Decompiled with JetBrains decompiler
// Type: KSP.ScriptInterop.impl.moonsharp.ScriptValue
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using MoonSharp.Interpreter;
using System;
using System.Runtime.CompilerServices;

namespace KSP.ScriptInterop.impl.moonsharp
{
  public class ScriptValue : IScriptValue
  {
    public DynValue dynValue;
    protected ITypeWriter typeWriter;
    protected ITypeInterop typeInterop;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ScriptValue(ITypeInterop typeInterop, ITypeWriter typeWriter) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ScriptValue(DynValue dynValue, ITypeInterop typeInterop, ITypeWriter typeWriter) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ScriptValue(string theString, ITypeInterop typeInterop, ITypeWriter typeWriter) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ScriptValue(double number, ITypeInterop typeInterop, ITypeWriter typeWriter) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ScriptValue(bool boolean, ITypeInterop typeInterop, ITypeWriter typeWriter) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ScriptValue(
      Script script,
      object theObject,
      ITypeInterop typeInterop,
      ITypeWriter typeWriter)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ScriptValue(
      ITypeInterop typeInterop,
      ITypeWriter typeWriter,
      string theString,
      params object[] args)
    {
      throw null;
    }

    public bool IsNil
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public object ToObject(Type dotNetType) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public T ToValue<T>() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public T? ToReference<T>() where T : struct => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override string ToString() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public string ToString(FormatOptions options) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UsedOnlyForAOTCodeGeneration() => throw null;
  }
}
