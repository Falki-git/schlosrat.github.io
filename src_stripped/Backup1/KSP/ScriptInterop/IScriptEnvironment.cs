﻿// Decompiled with JetBrains decompiler
// Type: KSP.ScriptInterop.IScriptEnvironment
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using MoonSharp.Interpreter.Loaders;
using System;

namespace KSP.ScriptInterop
{
  public interface IScriptEnvironment : ITypeInterop
  {
    string name { get; }

    bool DataLinkEnabled { get; set; }

    IRunScriptInterop RunInterop { get; }

    ITypeInterop TypeInterop { get; }

    ITypeWriter TypeWriter { get; }

    IScriptValue RunScriptAsset(ICompiledScript scriptAsset);

    IScriptObject RegisterScriptObject(string name);

    IScriptObject RegisterScriptObject(string name, IScriptObject parent);

    byte[] CompileToBytes(string scriptCode, string name);

    ICompiledScript Compile(string scriptCode, string name);

    IScriptEnvironment Fork(string name, bool allowExternalInterop);

    IScriptLoader ScriptLoader { get; set; }

    Action<string> DebugPrint { get; set; }
  }
}
