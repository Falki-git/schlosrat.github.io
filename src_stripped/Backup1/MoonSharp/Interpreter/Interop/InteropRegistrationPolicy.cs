﻿// Decompiled with JetBrains decompiler
// Type: MoonSharp.Interpreter.Interop.InteropRegistrationPolicy
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using MoonSharp.Interpreter.Interop.RegistrationPolicies;
using System;
using System.Runtime.CompilerServices;

namespace MoonSharp.Interpreter.Interop
{
  public static class InteropRegistrationPolicy
  {
    public static IRegistrationPolicy Default
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [Obsolete("Please use InteropRegistrationPolicy.Default instead.")]
    public static IRegistrationPolicy Explicit
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public static IRegistrationPolicy Automatic
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }
  }
}
