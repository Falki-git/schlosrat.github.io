﻿// Decompiled with JetBrains decompiler
// Type: MoonSharp.Interpreter.Tree.Statements.ScopeBlockStatement
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using MoonSharp.Interpreter.Debugging;
using MoonSharp.Interpreter.Execution;
using MoonSharp.Interpreter.Execution.VM;
using System.Runtime.CompilerServices;

namespace MoonSharp.Interpreter.Tree.Statements
{
  internal class ScopeBlockStatement : Statement
  {
    private Statement m_Block;
    private RuntimeScopeBlock m_StackFrame;
    private SourceRef m_Do;
    private SourceRef m_End;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ScopeBlockStatement(ScriptLoadingContext lcontext) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void Compile(ByteCode bc) => throw null;
  }
}
