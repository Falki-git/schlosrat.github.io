﻿// Decompiled with JetBrains decompiler
// Type: KSP.Modules.Data_CrewedInterior
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Sim;
using KSP.Sim.Definitions;
using System;
using System.Runtime.CompilerServices;

namespace KSP.Modules
{
  [Serializable]
  public sealed class Data_CrewedInterior : ModuleData
  {
    [KSPDefinition]
    public string InteriorName;
    [KSPDefinition]
    public bool IsProbe;
    [KSPDefinition]
    public bool IsExternal;

    public override Type ModuleType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Data_CrewedInterior() => throw null;
  }
}
