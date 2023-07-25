﻿// Decompiled with JetBrains decompiler
// Type: MoonSharp.Interpreter.Execution.Scopes.BuildTimeScopeFrame
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using MoonSharp.Interpreter.Tree.Statements;
using System.Runtime.CompilerServices;

namespace MoonSharp.Interpreter.Execution.Scopes
{
  internal class BuildTimeScopeFrame
  {
    private BuildTimeScopeBlock m_ScopeTreeRoot;
    private BuildTimeScopeBlock m_ScopeTreeHead;
    private RuntimeScopeFrame m_ScopeFrame;

    public bool HasVarArgs
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal BuildTimeScopeFrame(bool hasVarArgs) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal void PushBlock() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal RuntimeScopeBlock PopBlock() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal RuntimeScopeFrame GetRuntimeFrameData() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal SymbolRef Find(string name) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal SymbolRef DefineLocal(string name) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal SymbolRef TryDefineLocal(string name) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal void ResolveLRefs() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal int AllocVar(SymbolRef var) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal int GetPosForNextVar() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal void DefineLabel(LabelStatement label) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal void RegisterGoto(GotoStatement gotostat) => throw null;
  }
}
