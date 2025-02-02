﻿// Decompiled with JetBrains decompiler
// Type: KSP.ScriptInterop.impl.moonsharp.PartDefinitionConverter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Sim.Definitions;
using MoonSharp.Interpreter;
using System.Runtime.CompilerServices;

namespace KSP.ScriptInterop.impl.moonsharp
{
  [TypeInterop(typeof (PartDefinition), "PartDefinition", new string[] {"KSP.Sim.Definitions.PartDefinition"})]
  public class PartDefinitionConverter : 
    IStructConverter<PartDefinition>,
    IValueConverter<PartDefinition>,
    IValueConverter<PartDefinition?>
  {
    private TypeInterop typeInterop;
    private MoonSharpBinding.Struct<PartDefinition> moonsharpBinding;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PartDefinitionConverter(TypeInterop typeInterop) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    PartDefinition IValueConverter<PartDefinition>.ToValue(DynValue scriptValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynValue FromValue(PartDefinition? clrValue, Script script) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PartDefinition? ToValue(DynValue scriptValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynValue FromValue(PartDefinition clrValue, Script script) => throw null;
  }
}
