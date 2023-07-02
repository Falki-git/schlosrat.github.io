﻿// Decompiled with JetBrains decompiler
// Type: KSP.ScriptInterop.impl.moonsharp.TransformHierarchyConverter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Sim.State;
using MoonSharp.Interpreter;
using System.Runtime.CompilerServices;

namespace KSP.ScriptInterop.impl.moonsharp
{
  [TypeInterop(typeof (TransformHierarchy), "TransformHierarchy", new string[] {"KSP.Sim.State.TransformHierarchy"})]
  public class TransformHierarchyConverter : 
    IStructConverter<TransformHierarchy>,
    IValueConverter<TransformHierarchy>,
    IValueConverter<TransformHierarchy?>
  {
    private TypeInterop typeInterop;
    private MoonSharpBinding.Struct<TransformHierarchy> moonsharpBinding;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public TransformHierarchyConverter(TypeInterop typeInterop) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    TransformHierarchy IValueConverter<TransformHierarchy>.ToValue(DynValue scriptValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynValue FromValue(TransformHierarchy? clrValue, Script script) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public TransformHierarchy? ToValue(DynValue scriptValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynValue FromValue(TransformHierarchy clrValue, Script script) => throw null;
  }
}
