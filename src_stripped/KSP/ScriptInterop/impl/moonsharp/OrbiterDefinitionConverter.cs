﻿// Decompiled with JetBrains decompiler
// Type: KSP.ScriptInterop.impl.moonsharp.OrbiterDefinitionConverter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Sim.Definitions;
using MoonSharp.Interpreter;
using System.Runtime.CompilerServices;

namespace KSP.ScriptInterop.impl.moonsharp
{
  [TypeInterop(typeof (OrbiterDefinition), "Orbiter", new string[] {"KSP.Sim.Definitions.OrbiterDefinition"})]
  public class OrbiterDefinitionConverter : 
    IStructConverter<OrbiterDefinition>,
    IValueConverter<OrbiterDefinition>,
    IValueConverter<OrbiterDefinition?>
  {
    private TypeInterop typeInterop;
    private MoonSharpBinding.Struct<OrbiterDefinition> moonsharpBinding;
    private OrbiterDefinition defaults;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public OrbiterDefinitionConverter(TypeInterop typeInterop) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    OrbiterDefinition IValueConverter<OrbiterDefinition>.ToValue(DynValue scriptValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynValue FromValue(OrbiterDefinition? clrValue, Script script) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public OrbiterDefinition? ToValue(DynValue scriptValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynValue FromValue(OrbiterDefinition clrValue, Script script) => throw null;
  }
}
