﻿// Decompiled with JetBrains decompiler
// Type: MoonSharp.Interpreter.Tree.Statements.FunctionDefinitionStatement
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using MoonSharp.Interpreter.Debugging;
using MoonSharp.Interpreter.Execution;
using MoonSharp.Interpreter.Execution.VM;
using MoonSharp.Interpreter.Tree.Expressions;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace MoonSharp.Interpreter.Tree.Statements
{
  internal class FunctionDefinitionStatement : Statement
  {
    private SymbolRef m_FuncSymbol;
    private SourceRef m_SourceRef;
    private bool m_Local;
    private bool m_IsMethodCallingConvention;
    private string m_MethodName;
    private string m_FriendlyName;
    private List<string> m_TableAccessors;
    private FunctionDefinitionExpression m_FuncDef;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FunctionDefinitionStatement(ScriptLoadingContext lcontext, bool local, Token localToken) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void Compile(ByteCode bc) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private int SetMethod(ByteCode bc) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private int SetFunction(ByteCode bc, int numPop) => throw null;
  }
}
