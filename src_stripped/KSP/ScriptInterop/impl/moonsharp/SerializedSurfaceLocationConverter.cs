﻿// Decompiled with JetBrains decompiler
// Type: KSP.ScriptInterop.impl.moonsharp.SerializedSurfaceLocationConverter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Sim;
using MoonSharp.Interpreter;
using System.Runtime.CompilerServices;

namespace KSP.ScriptInterop.impl.moonsharp
{
  [TypeInterop(typeof (SerializedSurfaceLocation), "SerializedSurfaceLocation", new string[] {"KSP.Sim.SerializedSurfaceLocation"})]
  public class SerializedSurfaceLocationConverter : 
    IStructConverter<SerializedSurfaceLocation>,
    IValueConverter<SerializedSurfaceLocation>,
    IValueConverter<SerializedSurfaceLocation?>
  {
    private TypeInterop typeInterop;
    private SerializedSurfaceLocation defaults;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SerializedSurfaceLocationConverter(TypeInterop typeInterop) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    SerializedSurfaceLocation IValueConverter<SerializedSurfaceLocation>.ToValue(
      DynValue scriptValue)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SerializedSurfaceLocation? ToValue(DynValue scriptValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynValue FromValue(SerializedSurfaceLocation? clrValue, Script script) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynValue FromValue(SerializedSurfaceLocation clrValue, Script script) => throw null;
  }
}
