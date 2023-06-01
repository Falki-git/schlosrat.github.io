﻿// Decompiled with JetBrains decompiler
// Type: MoonSharp.Interpreter.Interop.EnumerableWrapper
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Collections;
using System.Runtime.CompilerServices;

namespace MoonSharp.Interpreter.Interop
{
  internal class EnumerableWrapper : IUserDataType
  {
    private IEnumerator m_Enumerator;
    private Script m_Script;
    private DynValue m_Prev;
    private bool m_HasTurnOnce;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private EnumerableWrapper(Script script, IEnumerator enumerator) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Reset() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private DynValue GetNext(DynValue prev) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private DynValue LuaIteratorCallback(
      ScriptExecutionContext executionContext,
      CallbackArguments args)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static DynValue ConvertIterator(Script script, IEnumerator enumerator) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static DynValue ConvertTable(Table table) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynValue Index(Script script, DynValue index, bool isDirectIndexing) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool SetIndex(Script script, DynValue index, DynValue value, bool isDirectIndexing) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynValue MetaIndex(Script script, string metaname) => throw null;
  }
}
