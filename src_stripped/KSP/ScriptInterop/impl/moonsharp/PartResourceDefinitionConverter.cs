﻿// Decompiled with JetBrains decompiler
// Type: KSP.ScriptInterop.impl.moonsharp.PartResourceDefinitionConverter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Sim;
using KSP.Sim.Definitions;
using MoonSharp.Interpreter;
using System.Runtime.CompilerServices;

namespace KSP.ScriptInterop.impl.moonsharp
{
  [TypeInterop(typeof (PartResourceDefinition), "PartResource", new string[] {"PartResourceDefinition", "KSP.Sim.PartResourceDefinition"})]
  public class PartResourceDefinitionConverter : IValueConverter<PartResourceDefinition>
  {
    private TypeInterop typeInterop;
    private MoonSharpBinding.Class<PartResourceDefinition> moonsharpBinding;
    private OrbiterDefinition defaults;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PartResourceDefinitionConverter(TypeInterop typeInterop) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PartResourceDefinition ToValue(DynValue scriptValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynValue FromValue(PartResourceDefinition clrValue, Script script) => throw null;
  }
}
