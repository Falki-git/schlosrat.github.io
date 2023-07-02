﻿// Decompiled with JetBrains decompiler
// Type: KSP.ScriptInterop.impl.moonsharp.ActionGroupStatesConverter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Sim.State;
using MoonSharp.Interpreter;
using System.Runtime.CompilerServices;

namespace KSP.ScriptInterop.impl.moonsharp
{
  [TypeInterop(typeof (ActionGroupStates), "ActionGroupStates", new string[] {"KSP.Sim.State.ActionGroupStates"})]
  public class ActionGroupStatesConverter : 
    IStructConverter<ActionGroupStates>,
    IValueConverter<ActionGroupStates>,
    IValueConverter<ActionGroupStates?>
  {
    private TypeInterop typeInterop;
    private MoonSharpBinding.Struct<ActionGroupStates> moonsharpBinding;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ActionGroupStatesConverter(TypeInterop typeInterop) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    ActionGroupStates IValueConverter<ActionGroupStates>.ToValue(DynValue scriptValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynValue FromValue(ActionGroupStates? clrValue, Script script) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ActionGroupStates? ToValue(DynValue scriptValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynValue FromValue(ActionGroupStates clrValue, Script script) => throw null;
  }
}
