﻿// Decompiled with JetBrains decompiler
// Type: MoonSharp.Interpreter.InternalErrorException
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
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
