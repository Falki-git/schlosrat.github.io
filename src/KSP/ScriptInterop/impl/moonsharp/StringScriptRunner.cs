﻿// Decompiled with JetBrains decompiler
// Type: KSP.ScriptInterop.impl.moonsharp.StringScriptRunner
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using MoonSharp.Interpreter;
using System.Runtime.CompilerServices;

namespace KSP.ScriptInterop.impl.moonsharp
{
  public class StringScriptRunner : IRunScriptInterop
  {
    public Script script;
    public Table context;
    public ScriptEnvironment typeInterop;
    public ITypeWriter typeWriter;
    private Coroutine coroutine;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public StringScriptRunner(
      Script script,
      Table context,
      ScriptEnvironment typeInterp,
      ITypeWriter typeWriter)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public IScriptValue RunScript(string scriptString, string friendlyname = null) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public IScriptValue RunScript(ICompiledScript script) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public IScriptValue RunScript(byte[] compiledScript, string friendlyName = null) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public IScriptThread RunScriptAsync(string scriptString) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private DynValue UnprotectedCall_NoCoroutine(DynValue function) => throw null;
  }
}
