﻿// Decompiled with JetBrains decompiler
// Type: MoonSharp.Interpreter.InternalErrorException
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;

namespace MoonSharp.Interpreter
{
  [Serializable]
  public class InternalErrorException : InterpreterException
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal InternalErrorException(string message) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal InternalErrorException(string format, params object[] args) => throw null;
  }
}
