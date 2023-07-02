﻿// Decompiled with JetBrains decompiler
// Type: KSP.ScriptInterop.impl.moonsharp.SerializedVesselConverter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Sim;
using MoonSharp.Interpreter;
using System.Runtime.CompilerServices;

namespace KSP.ScriptInterop.impl.moonsharp
{
  [TypeInterop(typeof (LegacySerializedVessel), "Vehicle", new string[] {"SerializedVessel", "KSP.Sim.SerializedVessel"})]
  public class SerializedVesselConverter : 
    IStructConverter<LegacySerializedVessel>,
    IValueConverter<LegacySerializedVessel>,
    IValueConverter<LegacySerializedVessel?>
  {
    private TypeInterop typeInterop;
    private LegacySerializedVessel defaults;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SerializedVesselConverter(TypeInterop typeInterop) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    LegacySerializedVessel IValueConverter<LegacySerializedVessel>.ToValue(DynValue scriptValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public LegacySerializedVessel? ToValue(DynValue scriptValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynValue FromValue(LegacySerializedVessel? clrValue, Script script) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynValue FromValue(LegacySerializedVessel clrValue, Script script) => throw null;
  }
}
