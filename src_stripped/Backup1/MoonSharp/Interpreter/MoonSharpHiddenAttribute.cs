﻿// Decompiled with JetBrains decompiler
// Type: MoonSharp.Interpreter.MoonSharpHiddenAttribute
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;

namespace MoonSharp.Interpreter
{
  [AttributeUsage(AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event, Inherited = true, AllowMultiple = false)]
  public sealed class MoonSharpHiddenAttribute : Attribute
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    public MoonSharpHiddenAttribute() => throw null;
  }
}
