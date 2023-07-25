﻿// Decompiled with JetBrains decompiler
// Type: KSP.Modules.Data_ReinforcedConnection
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Sim;
using KSP.Sim.Definitions;
using System;
using System.Runtime.CompilerServices;

namespace KSP.Modules
{
  [Serializable]
  public sealed class Data_ReinforcedConnection : ModuleData
  {
    [KSPDefinition]
    public Data_ReinforcedConnection.ConnectionType ConnectionTarget;

    public override Type ModuleType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Data_ReinforcedConnection() => throw null;

    public enum ConnectionType
    {
      GrandParent,
      Root,
      Heaviest,
    }
  }
}
