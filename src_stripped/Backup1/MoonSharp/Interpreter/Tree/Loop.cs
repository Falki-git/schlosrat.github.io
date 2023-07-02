﻿// Decompiled with JetBrains decompiler
// Type: MoonSharp.Interpreter.Tree.Loop
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using MoonSharp.Interpreter.Execution;
using MoonSharp.Interpreter.Execution.VM;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace MoonSharp.Interpreter.Tree
{
  internal class Loop : ILoop
  {
    public RuntimeScopeBlock Scope;
    public List<Instruction> BreakJumps;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void CompileBreak(ByteCode bc) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsBoundary() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Loop() => throw null;
  }
}
