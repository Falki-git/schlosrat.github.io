﻿// Decompiled with JetBrains decompiler
// Type: KSP.OAB.OABGlobalConfig
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;

namespace KSP.OAB
{
  [Serializable]
  public class OABGlobalConfig
  {
    public const string CURRENT_VERSION = "0.5";
    public string Version;
    public ObjectAssemblyBehaviorValues OABBehavioralValues;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static OABGlobalConfig Defaults() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public OABGlobalConfig() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public OABGlobalConfig(ObjectAssemblyBehaviorValues behavioralValues) => throw null;
  }
}
