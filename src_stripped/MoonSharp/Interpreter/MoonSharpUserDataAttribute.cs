﻿// Decompiled with JetBrains decompiler
// Type: MoonSharp.Interpreter.MoonSharpUserDataAttribute
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;

namespace MoonSharp.Interpreter
{
  [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct, Inherited = false, AllowMultiple = false)]
  public sealed class MoonSharpUserDataAttribute : Attribute
  {
    public InteropAccessMode AccessMode
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public MoonSharpUserDataAttribute() => throw null;
  }
}
