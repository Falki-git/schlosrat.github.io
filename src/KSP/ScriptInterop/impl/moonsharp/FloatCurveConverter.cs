﻿// Decompiled with JetBrains decompiler
// Type: KSP.ScriptInterop.impl.moonsharp.FloatCurveConverter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using MoonSharp.Interpreter;
using System.Runtime.CompilerServices;

namespace KSP.ScriptInterop.impl.moonsharp
{
  [TypeInterop(typeof (FloatCurve), "FloatCurve")]
  public class FloatCurveConverter : IValueConverter<FloatCurve>
  {
    private TypeInterop typeInterop;
    private MoonSharpBinding.Class<FloatCurve> moonsharpBinding;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FloatCurveConverter(TypeInterop typeInterop) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FloatCurve ToValue(DynValue scriptValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynValue FromValue(FloatCurve clrValue, Script script) => throw null;
  }
}
