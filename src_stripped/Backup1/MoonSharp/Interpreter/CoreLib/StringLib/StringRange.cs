﻿// Decompiled with JetBrains decompiler
// Type: MoonSharp.Interpreter.CoreLib.StringLib.StringRange
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;

namespace MoonSharp.Interpreter.CoreLib.StringLib
{
  internal class StringRange
  {
    public int Start
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public int End
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public StringRange() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public StringRange(int start, int end) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static StringRange FromLuaRange(DynValue start, DynValue end, int? defaultEnd = null) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public string ApplyToString(string value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public int Length() => throw null;
  }
}