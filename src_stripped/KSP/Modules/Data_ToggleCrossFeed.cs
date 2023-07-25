﻿// Decompiled with JetBrains decompiler
// Type: KSP.Modules.Data_ToggleCrossFeed
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Sim;
using KSP.Sim.Definitions;
using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Modules
{
  [Serializable]
  public class Data_ToggleCrossFeed : ModuleData
  {
    [KSPDefinition]
    [Tooltip("Whether the player can toggle crossfeed in the OAB.")]
    public bool ToggleInEditor;
    [Tooltip("Whether the player can toggle crossfeed in the flight view.")]
    [KSPDefinition]
    public bool ToggleInFlight;

    public override System.Type ModuleType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Data_ToggleCrossFeed() => throw null;
  }
}
