﻿// Decompiled with JetBrains decompiler
// Type: KSP.Game.Load.CollectCelestialBodyDataFlowAction
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Sim;
using KSP.Sim.impl;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace KSP.Game.Load
{
  [Obsolete("THis action should not be used in its current state as the CB data is held in a GalaxyDefinition Addressable", true)]
  public class CollectCelestialBodyDataFlowAction : SaveLoadGameFlowActionBase
  {
    public List<SerializedCelestialBody> CelestialBodies;
    private LoadGameData _gameData;

    public GameInstance Game
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public CollectCelestialBodyDataFlowAction(LoadGameData data) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void DoAction(Action resolve, Action<string> reject) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void CollectCelestialBodyComponents() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private SerializedOrbitProperties OrbitFromComponent(CelestialBodyComponent bodyComp) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private SerializedOribiterDefinition OrbiterFromComponent(CelestialBodyComponent bodyComp) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SerializedCelestialBody CelestialBodyToSerializable(
      SimulationObjectModel objectModel,
      bool isAutosave)
    {
      throw null;
    }
  }
}
