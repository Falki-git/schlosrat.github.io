﻿// Decompiled with JetBrains decompiler
// Type: MoonSharp.Interpreter.Debugging.DebugService
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using MoonSharp.Interpreter.Execution.VM;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace MoonSharp.Interpreter.Debugging
{
  public sealed class DebugService : IScriptPrivateResource
  {
    private Processor m_Processor;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal DebugService(Script script, Processor processor) => throw null;

    public Script OwnerScript
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public HashSet<int> ResetBreakPoints(SourceCode src, HashSet<int> lines) => throw null;
  }
}
