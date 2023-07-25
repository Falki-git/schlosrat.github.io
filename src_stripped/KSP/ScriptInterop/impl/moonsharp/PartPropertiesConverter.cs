﻿// Decompiled with JetBrains decompiler
// Type: KSP.ScriptInterop.impl.moonsharp.PartPropertiesConverter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Sim.Definitions;
using MoonSharp.Interpreter;
using System.Runtime.CompilerServices;

namespace KSP.ScriptInterop.impl.moonsharp
{
  [TypeInterop(typeof (PartProperties), "Part", new string[] {"PartProperties", "KSP.Sim.Definitions.PartProperties"})]
  public class PartPropertiesConverter : 
    IStructConverter<PartProperties>,
    IValueConverter<PartProperties>,
    IValueConverter<PartProperties?>
  {
    public const string MODULE_TYPE_KEY = "moduleType";
    private TypeInterop typeInterop;
    private MoonSharpBinding.Struct<PartProperties> moonsharpBinding;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PartPropertiesConverter(TypeInterop typeInterop) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    PartProperties IValueConverter<PartProperties>.ToValue(DynValue scriptValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynValue FromValue(PartProperties? clrValue, Script script) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PartProperties? ToValue(DynValue scriptValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynValue FromValue(PartProperties properties, Script script) => throw null;
  }
}
