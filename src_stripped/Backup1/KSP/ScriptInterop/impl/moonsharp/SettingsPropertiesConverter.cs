﻿// Decompiled with JetBrains decompiler
// Type: KSP.ScriptInterop.impl.moonsharp.SettingsPropertiesConverter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Sim.Definitions;
using MoonSharp.Interpreter;
using System.Runtime.CompilerServices;

namespace KSP.ScriptInterop.impl.moonsharp
{
  [TypeInterop(typeof (SettingsProperties), "SettingsProperties", new string[] {"KSP.Sim.Definitions.SettingsProperties"})]
  public class SettingsPropertiesConverter : 
    IStructConverter<SettingsProperties>,
    IValueConverter<SettingsProperties>,
    IValueConverter<SettingsProperties?>
  {
    private SettingsProperties defaults;
    private TypeInterop typeInterop;
    private MoonSharpBinding.Struct<SettingsProperties> moonsharpBinding;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SettingsPropertiesConverter(TypeInterop typeInterop) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynValue FromValue(SettingsProperties clrValue, Script script) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynValue FromValue(SettingsProperties? clrValue, Script script) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SettingsProperties? ToValue(DynValue scriptValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    SettingsProperties IValueConverter<SettingsProperties>.ToValue(DynValue scriptValue) => throw null;
  }
}
