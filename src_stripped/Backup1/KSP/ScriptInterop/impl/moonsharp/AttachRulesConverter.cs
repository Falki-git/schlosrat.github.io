﻿// Decompiled with JetBrains decompiler
// Type: KSP.ScriptInterop.impl.moonsharp.AttachRulesConverter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Sim.Definitions;
using MoonSharp.Interpreter;
using System.Runtime.CompilerServices;

namespace KSP.ScriptInterop.impl.moonsharp
{
  [TypeInterop(typeof (AttachRules), "AttachRules", new string[] {"KSP.Sim.Definitions.AttachRules"})]
  public class AttachRulesConverter : 
    IStructConverter<AttachRules>,
    IValueConverter<AttachRules>,
    IValueConverter<AttachRules?>
  {
    private TypeInterop typeInterop;
    private MoonSharpBinding.Struct<AttachRules> moonsharpBinding;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public AttachRulesConverter(TypeInterop typeInterop) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    AttachRules IValueConverter<AttachRules>.ToValue(DynValue scriptValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynValue FromValue(AttachRules? clrValue, Script script) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public AttachRules? ToValue(DynValue scriptValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynValue FromValue(AttachRules clrValue, Script script) => throw null;
  }
}
