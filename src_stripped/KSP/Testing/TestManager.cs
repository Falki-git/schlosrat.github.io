﻿// Decompiled with JetBrains decompiler
// Type: KSP.Testing.TestManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace KSP.Testing
{
  public class TestManager
  {
    private static List<UnitTest> tests;
    private static HashSet<Type> types;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void AddTest(UnitTest test) => throw null;

    public static bool HaveUnitTests
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void ClearUnitTests() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static TestResults RunTests() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static void AddTest(Type t) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public TestManager() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static TestManager() => throw null;
  }
}
