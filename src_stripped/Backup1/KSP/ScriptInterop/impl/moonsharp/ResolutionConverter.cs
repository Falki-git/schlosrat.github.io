﻿// Decompiled with JetBrains decompiler
// Type: KSP.ScriptInterop.impl.moonsharp.ResolutionConverter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using MoonSharp.Interpreter;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.ScriptInterop.impl.moonsharp
{
  [TypeInterop(typeof (Resolution), "Resolution", new string[] {"UnityEngine.Resolution)"})]
  public class ResolutionConverter : 
    IStructConverter<Resolution>,
    IValueConverter<Resolution>,
    IValueConverter<Resolution?>
  {
    private TypeInterop typeInterop;
    private Resolution defaults;
    private MoonSharpBinding.Struct<Resolution> moonsharpBinding;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ResolutionConverter(TypeInterop typeInterop) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    Resolution IValueConverter<Resolution>.ToValue(DynValue scriptValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Resolution? ToValue(DynValue scriptValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynValue FromValue(Resolution? clrValue, Script script) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynValue FromValue(Resolution clrValue, Script script) => throw null;
  }
}
