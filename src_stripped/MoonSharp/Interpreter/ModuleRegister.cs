﻿// Decompiled with JetBrains decompiler
// Type: MoonSharp.Interpreter.ModuleRegister
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace MoonSharp.Interpreter
{
  public static class ModuleRegister
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Table RegisterCoreModules(this Table table, CoreModules modules) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Table RegisterConstants(this Table table) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Table RegisterModuleType(this Table gtable, Type t) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void RegisterScriptFieldAsConst(
      FieldInfo fi,
      object o,
      Table table,
      Type t,
      string name)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void RegisterScriptField(
      FieldInfo fi,
      object o,
      Table table,
      Type t,
      string name)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static Table CreateModuleNamespace(Table gtable, Type t) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Table RegisterModuleType<T>(this Table table) => throw null;
  }
}
