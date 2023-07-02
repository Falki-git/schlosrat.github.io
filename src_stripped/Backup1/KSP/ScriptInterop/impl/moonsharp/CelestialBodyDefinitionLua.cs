﻿// Decompiled with JetBrains decompiler
// Type: KSP.ScriptInterop.impl.moonsharp.CelestialBodyDefinitionLua
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Sim.Definitions;
using MoonSharp.Interpreter;
using System.Runtime.CompilerServices;

namespace KSP.ScriptInterop.impl.moonsharp
{
  [TypeInterop(typeof (CelestialBodyDefinition), "CelestialBody", new string[] {"CelestialBodyDefinition", "KSP.Sim.Definitions.CelestialBodyDefinition"})]
  public class CelestialBodyDefinitionLua : 
    IStructConverter<CelestialBodyDefinition>,
    IValueConverter<CelestialBodyDefinition>,
    IValueConverter<CelestialBodyDefinition?>
  {
    private CelestialBodyDefinition defaults;
    private TypeInterop typeInterop;
    private MoonSharpBinding.Struct<CelestialBodyDefinition> moonsharpBinding;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public CelestialBodyDefinitionLua(TypeInterop typeInterop) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynValue FromValue(CelestialBodyDefinition? clrValue, Script script) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    CelestialBodyDefinition IValueConverter<CelestialBodyDefinition>.ToValue(DynValue scriptValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public CelestialBodyDefinition? ToValue(DynValue scriptValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynValue FromValue(CelestialBodyDefinition clrValue, Script script) => throw null;
  }
}
