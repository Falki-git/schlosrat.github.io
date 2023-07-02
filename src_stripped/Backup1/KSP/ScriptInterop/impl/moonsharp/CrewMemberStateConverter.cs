﻿// Decompiled with JetBrains decompiler
// Type: KSP.ScriptInterop.impl.moonsharp.CrewMemberStateConverter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Sim.State;
using MoonSharp.Interpreter;
using System.Runtime.CompilerServices;

namespace KSP.ScriptInterop.impl.moonsharp
{
  [TypeInterop(typeof (CrewMemberState), "CrewMemberState", new string[] {"KSP.Sim.State.CrewMemberState"})]
  public class CrewMemberStateConverter : 
    IStructConverter<CrewMemberState>,
    IValueConverter<CrewMemberState>,
    IValueConverter<CrewMemberState?>
  {
    private TypeInterop typeInterop;
    private MoonSharpBinding.Struct<CrewMemberState> moonsharpBinding;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public CrewMemberStateConverter(TypeInterop typeInterop) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    CrewMemberState IValueConverter<CrewMemberState>.ToValue(DynValue scriptValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynValue FromValue(CrewMemberState? clrValue, Script script) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public CrewMemberState? ToValue(DynValue scriptValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynValue FromValue(CrewMemberState clrValue, Script script) => throw null;
  }
}
