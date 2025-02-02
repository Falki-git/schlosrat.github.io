﻿// Decompiled with JetBrains decompiler
// Type: KSP.ScriptInterop.impl.moonsharp.StagingStateConverter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Sim.State;
using MoonSharp.Interpreter;
using System.Runtime.CompilerServices;

namespace KSP.ScriptInterop.impl.moonsharp
{
  [TypeInterop(typeof (StagingState), "StagingState", new string[] {"KSP.Sim.State.StagingState"})]
  public class StagingStateConverter : 
    IStructConverter<StagingState>,
    IValueConverter<StagingState>,
    IValueConverter<StagingState?>
  {
    private TypeInterop typeInterop;
    private MoonSharpBinding.Struct<StagingState> moonsharpBinding;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public StagingStateConverter(TypeInterop typeInterop) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    StagingState IValueConverter<StagingState>.ToValue(DynValue scriptValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynValue FromValue(StagingState? clrValue, Script script) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public StagingState? ToValue(DynValue scriptValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynValue FromValue(StagingState clrValue, Script script) => throw null;
  }
}
