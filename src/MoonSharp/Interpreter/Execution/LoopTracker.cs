﻿// Decompiled with JetBrains decompiler
// Type: MoonSharp.Interpreter.Execution.LoopTracker
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using MoonSharp.Interpreter.DataStructs;
using System.Runtime.CompilerServices;

namespace MoonSharp.Interpreter.Execution
{
  internal class LoopTracker
  {
    public FastStack<ILoop> Loops;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public LoopTracker() => throw null;
  }
}
