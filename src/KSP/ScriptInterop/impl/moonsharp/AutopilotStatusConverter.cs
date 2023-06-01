﻿// Decompiled with JetBrains decompiler
// Type: KSP.ScriptInterop.impl.moonsharp.AutopilotStatusConverter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Sim;
using MoonSharp.Interpreter;
using System.Runtime.CompilerServices;

namespace KSP.ScriptInterop.impl.moonsharp
{
  [TypeInterop(typeof (AutopilotStatus), "AutopilotStatus", new string[] {"KSP.Sim.AutopilotStatus"})]
  public class AutopilotStatusConverter : 
    IStructConverter<AutopilotStatus>,
    IValueConverter<AutopilotStatus>,
    IValueConverter<AutopilotStatus?>
  {
    private TypeInterop typeInterop;
    private MoonSharpBinding.Struct<AutopilotStatus> moonsharpBinding;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public AutopilotStatusConverter(TypeInterop typeInterop) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    AutopilotStatus IValueConverter<AutopilotStatus>.ToValue(DynValue scriptValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynValue FromValue(AutopilotStatus? clrValue, Script script) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public AutopilotStatus? ToValue(DynValue scriptValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynValue FromValue(AutopilotStatus clrValue, Script script) => throw null;
  }
}
