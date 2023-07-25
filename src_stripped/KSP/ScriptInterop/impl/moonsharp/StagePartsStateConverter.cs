﻿// Decompiled with JetBrains decompiler
// Type: KSP.ScriptInterop.impl.moonsharp.StagePartsStateConverter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Sim.State;
using MoonSharp.Interpreter;
using System.Runtime.CompilerServices;

namespace KSP.ScriptInterop.impl.moonsharp
{
  [TypeInterop(typeof (StagePartsState), "StageParts", new string[] {"StagePartsState", "KSP.Sim.State.StagePartsState"})]
  public class StagePartsStateConverter : 
    IStructConverter<StagePartsState>,
    IValueConverter<StagePartsState>,
    IValueConverter<StagePartsState?>
  {
    private TypeInterop typeInterop;
    private MoonSharpBinding.Struct<StagePartsState> moonsharpBinding;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public StagePartsStateConverter(TypeInterop typeInterop) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    StagePartsState IValueConverter<StagePartsState>.ToValue(DynValue scriptValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynValue FromValue(StagePartsState? clrValue, Script script) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public StagePartsState? ToValue(DynValue scriptValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynValue FromValue(StagePartsState clrValue, Script script) => throw null;
  }
}
