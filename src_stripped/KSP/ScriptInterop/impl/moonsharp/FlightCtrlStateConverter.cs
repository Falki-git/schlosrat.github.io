﻿// Decompiled with JetBrains decompiler
// Type: KSP.ScriptInterop.impl.moonsharp.FlightCtrlStateConverter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Sim.State;
using MoonSharp.Interpreter;
using System.Runtime.CompilerServices;

namespace KSP.ScriptInterop.impl.moonsharp
{
  [TypeInterop(typeof (FlightCtrlStateIncremental), "FlightCtrlState", new string[] {"FlightCtrlStateIncremental", "KSP.Sim.State.FlightCtrlStateIncremental"})]
  public class FlightCtrlStateConverter : 
    IStructConverter<FlightCtrlStateIncremental>,
    IValueConverter<FlightCtrlStateIncremental>,
    IValueConverter<FlightCtrlStateIncremental?>
  {
    private TypeInterop typeInterop;
    private MoonSharpBinding.Struct<FlightCtrlStateIncremental> moonsharpBinding;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FlightCtrlStateConverter(TypeInterop typeInterop) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    FlightCtrlStateIncremental IValueConverter<FlightCtrlStateIncremental>.ToValue(
      DynValue scriptValue)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynValue FromValue(FlightCtrlStateIncremental? clrValue, Script script) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FlightCtrlStateIncremental? ToValue(DynValue scriptValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynValue FromValue(FlightCtrlStateIncremental clrValue, Script script) => throw null;
  }
}
