﻿// Decompiled with JetBrains decompiler
// Type: KSP.Game.Flow.LoadStartingCelestialBodyFlowAction
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Game.Load;
using KSP.Sim;
using KSP.Sim.impl;
using System;
using System.Collections;
using System.Runtime.CompilerServices;

namespace KSP.Game.Flow
{
  public class LoadStartingCelestialBodyFlowAction : FlowAction
  {
    private readonly LoadGameData _loadGameData;
    private readonly GameInstance _game;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public LoadStartingCelestialBodyFlowAction(LoadGameData data) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void DoAction(Action resolve, Action<string> reject) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private IEnumerator CoroutineWaitForCelestialBodyLoad(
      CelestialBodyComponent model,
      Action resolve,
      Action<string> reject)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private string GetStartingSoiCelestialBodyName(SerializedSavedGame savedGame) => throw null;
  }
}
